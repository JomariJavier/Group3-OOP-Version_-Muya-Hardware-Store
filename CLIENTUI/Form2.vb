Imports System.IO
Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Asn1.Cmp

Public Class Form2
    Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent")

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim f As New Form3

        ' Pass the cart to Form3
        For Each row As DataGridViewRow In dgvCart.Rows
            f.dgvConfirm.Rows.Add(
            row.Cells("colName").Value,
            row.Cells("colPrice").Value,
            row.Cells("colQty").Value
        )
        Next

        f.Show()
        Hide()

    End Sub

    Private Sub LoadTools()
        Try
            Using conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent")
                conn.Open()

                Using cmd As New MySqlCommand("
                SELECT Tool_ID, Stocks, Price, Tool_Name, is_Available, Tool_Image 
                FROM tbl_tools 
                ORDER BY Tool_ID ASC LIMIT 3", conn)

                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        Dim index As Integer = 0

                        While reader.Read()

                            Dim toolImg As Image = Nothing
                            If Not IsDBNull(reader("Tool_Image")) Then
                                Dim imgBytes() As Byte = CType(reader("Tool_Image"), Byte())
                                Using ms As New MemoryStream(imgBytes)
                                    toolImg = Image.FromStream(ms)
                                End Using
                            End If

                            '️⃣ FIRST: Load values into labels
                            Select Case index
                                Case 0
                                    ToolPicture1.Image = toolImg
                                    StockLabel1.Text = reader("Stocks").ToString()
                                    ToolName1.Text = reader("Tool_Name").ToString()
                                    Price1.Text = "₱" & Convert.ToDecimal(reader("Price")).ToString("N2")
                                    AvailabilityLabel1.Text = reader("is_Available").ToString()

                                Case 1
                                    ToolPicture2.Image = toolImg
                                    StockLabel2.Text = reader("Stocks").ToString()
                                    ToolName2.Text = reader("Tool_Name").ToString()
                                    Price2.Text = "₱" & Convert.ToDecimal(reader("Price")).ToString("N2")
                                    AvailabilityLabel2.Text = reader("is_Available").ToString()

                                Case 2
                                    ToolPicture3.Image = toolImg
                                    StockLabel3.Text = reader("Stocks").ToString()
                                    ToolName3.Text = reader("Tool_Name").ToString()
                                    Price3.Text = "₱" & Convert.ToDecimal(reader("Price")).ToString("N2")
                                    AvailabilityLabel3.Text = reader("is_Available").ToString()
                            End Select

                            index += 1
                        End While
                    End Using
                End Using
            End Using



            '️⃣ SECOND: NOW APPLY availability coloring & button enable
            UpdateButtonStates()

        Catch ex As Exception
            MsgBox("LoadTools ERROR: " & ex.Message)
        End Try
    End Sub

    Private Sub UpdateButtonStates()
        ' TOOL 1
        If Val(StockLabel1.Text) <= 0 Or Not IsToolAvailable(AvailabilityLabel1.Text) Then
            btnAdd1.Enabled = False
            AvailabilityLabel1.ForeColor = Color.Red
        Else
            btnAdd1.Enabled = True
            AvailabilityLabel1.ForeColor = Color.Green
        End If

        ' TOOL 2
        If Val(StockLabel2.Text) <= 0 Or Not IsToolAvailable(AvailabilityLabel2.Text) Then
            btnAdd2.Enabled = False
            AvailabilityLabel2.ForeColor = Color.Red
        Else
            btnAdd2.Enabled = True
            AvailabilityLabel2.ForeColor = Color.Green
        End If

        ' TOOL 3
        If Val(StockLabel3.Text) <= 0 Or Not IsToolAvailable(AvailabilityLabel3.Text) Then
            btnAdd3.Enabled = False
            AvailabilityLabel3.ForeColor = Color.Red
        Else
            btnAdd3.Enabled = True
            AvailabilityLabel3.ForeColor = Color.Green
        End If
    End Sub

    Private Function IsToolAvailable(availability As String) As Boolean
        Dim a As String = availability.Trim().ToLower()

        Return (a = "yes" Or a = "available" Or a = "on" Or a = "true" Or a = "1")
    End Function
    Private Sub ReduceStock(label As Label)
        Dim current As Integer = Val(label.Text)
        If current > 0 Then
            label.Text = (current - 1).ToString()
        End If
    End Sub

    Private Sub RemoveFromCart(itemName As String)
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("colName").Value = itemName Then
                dgvCart.Rows.Remove(row)
                Exit Sub
            End If
        Next
    End Sub
    Private Function ParsePrice(priceText As String) As Decimal
        If String.IsNullOrWhiteSpace(priceText) Then Return 0D

        ' Remove peso sign and commas
        priceText = priceText.Replace("₱", "").Replace(",", "").Trim()

        Dim value As Decimal
        Decimal.TryParse(priceText, value)
        Return value
    End Function

    Public Sub AddToCart(itemName As String, priceText As String, qty As Integer, maxStock As Integer)

        Dim price As Decimal = ParsePrice(priceText)

        ' Validate quantity
        If qty <= 0 Then
            MsgBox("Invalid quantity.")
            Exit Sub
        End If

        ' Check if item already in cart
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("colName").Value = itemName Then

                Dim currentQty As Integer = CInt(row.Cells("colQty").Value)

                If currentQty + qty > maxStock Then
                    MsgBox("You cannot add more than the available stock (" & maxStock & ").")
                    Exit Sub
                End If

                ' Update existing row
                row.Cells("colQty").Value = currentQty + qty
                Return
            End If
        Next

        ' Validate new addition does not exceed stock
        If qty > maxStock Then
            MsgBox("You cannot add more than the available stock (" & maxStock & ").")
            Exit Sub
        End If

        ' Add new row
        dgvCart.Rows.Add(itemName, price, qty)
    End Sub



    ' Limit sa add button
    Private Function CanAddItem(toolName As String, currentStock As Integer, availability As String) As Boolean
        Dim a As String = availability.ToString().Trim().ToLower()

        ' Valid available states
        Dim isAvailable As Boolean =
            (a = "yes" Or
             a = "available" Or
             a = "on" Or
             a = "true" Or
             a = "1")

        If Not isAvailable Then
            MsgBox("This item is not available right now.")
            Return False
        End If

        If currentStock <= 0 Then
            MsgBox("This item is out of stock.")
            Return False
        End If

        ' Prevent adding more than available
        For Each row As DataGridViewRow In dgvCart.Rows
            If row.Cells("colName").Value = toolName Then
                Dim qtyInCart As Integer = CInt(row.Cells("colQty").Value)
                If qtyInCart >= currentStock Then
                    MsgBox("You already added all available stock.")
                    Return False
                End If
            End If
        Next

        Return True
    End Function

    Private Sub btnAdd1_Click(sender As Object, e As EventArgs) Handles btnAdd1.Click
        If Not IsToolAvailable(AvailabilityLabel1.Text) Then
            MsgBox("This item is currently unavailable.")
            Exit Sub
        End If

        If Val(StockLabel1.Text) <= 0 Then
            MsgBox("This item is out of stock.")
            Exit Sub
        End If

        ' Add to cart (NO STOCK REDUCTION YET)
        AddToCart(ToolName1.Text, Price1.Text, 1, Val(StockLabel1.Text))


    End Sub
    Private Sub btnAdd2_Click(sender As Object, e As EventArgs) Handles btnAdd2.Click
        If Not IsToolAvailable(AvailabilityLabel2.Text) Then
            MsgBox("This item is currently unavailable.")
            Exit Sub
        End If

        If Val(StockLabel2.Text) <= 0 Then
            MsgBox("This item is out of stock.")
            Exit Sub
        End If

        AddToCart(ToolName2.Text, Price2.Text, 1, Val(StockLabel2.Text))


    End Sub


    Private Sub btnAdd3_Click(sender As Object, e As EventArgs) Handles btnAdd3.Click
        If Not IsToolAvailable(AvailabilityLabel3.Text) Then
            MsgBox("This item is currently unavailable.")
            Exit Sub
        End If

        If Val(StockLabel3.Text) <= 0 Then
            MsgBox("This item is out of stock.")
            Exit Sub
        End If

        AddToCart(ToolName2.Text, Price2.Text, 1, Val(StockLabel2.Text))


    End Sub
    Private Sub dgvCart_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvCart.CellFormatting
        If dgvCart.Columns(e.ColumnIndex).Name = "colPrice" Then
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                e.Value = "₱" & FormatNumber(CDec(e.Value), 2)
                e.FormattingApplied = True
            End If
        End If
    End Sub


    Private Sub Logout_Click(sender As Object, e As EventArgs) Handles Logout.Click
        Dim frm1 As New Form1
        Me.Hide()
        frm1.Show()

    End Sub
    Private Sub Label21_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Show()
        Me.Hide()
    End Sub


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadTools()
    End Sub

    Private Sub btnRemove1_Click(sender As Object, e As EventArgs) Handles btnRemove1.Click
        RemoveFromCart(ToolName1.Text)
    End Sub

    Private Sub btnRemove2_Click(sender As Object, e As EventArgs) Handles btnRemove2.Click
        RemoveFromCart(ToolName2.Text)
    End Sub

    Private Sub btnRemove3_Click(sender As Object, e As EventArgs) Handles btnRemove3.Click
        RemoveFromCart(ToolName3.Text)
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Label17.Text = (CInt(Label17.Text) + 1).ToString
    End Sub

    Private Sub btnRefresh_Click(sender As Object, e As EventArgs)
        LoadTools()
    End Sub

    Private Sub dgvCart_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCart.CellContentClick

    End Sub
End Class
