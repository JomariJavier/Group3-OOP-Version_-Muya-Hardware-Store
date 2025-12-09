Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.IO
Imports System.Net
Imports System.Resources
Imports System.Runtime.InteropServices
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud

Public Class AdminForm1
    Dim MySqlConn As MySqlConnection
    Dim Command1 As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim Command3 As MySqlCommand
    Dim cmd As MySqlCommand

    Public Function LoadTools() As DataTable
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String = "SELECT Tool_ID, Tool_Name, is_Available, Price, Stocks, Tool_Image  FROM tbl_tools WHERE is_Deleted = '0'"
        Dim dt As New DataTable()
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)

                    ViewTools.DataSource = dt
                End Using
            End Using
        End Using
        ViewTools.DataSource = dt
        If ViewTools.Columns.Contains("Tool_ID") Then
            ViewTools.Columns("Tool_ID").Visible = False
        End If
        If ViewTools.Columns.Contains("Tool_Image") Then
            Dim imgCol As DataGridViewImageColumn =
            CType(ViewTools.Columns("Tool_Image"), DataGridViewImageColumn)
            imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
        End If
        ViewTools.DefaultCellStyle.ForeColor = Color.Black
        CType(ViewTools.Columns("Tool_Image"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
    End Function
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
            Handles ProductImage1.Click

        currentPic = CType(sender, PictureBox)
        ' Show dialog options
        Dim answer = MessageBox.Show(
                "Choose an action:" & vbCrLf &
                "Yes = Add Photo" & vbCrLf &
                "No = Update Photo" & vbCrLf &
                "Cancel = Delete Photo",
                "Photo Options",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question)

        Select Case answer
            Case DialogResult.Yes
                AddPhoto()
            Case DialogResult.No
                UpdatePhoto()
            Case DialogResult.Cancel
                DeletePhoto()
        End Select

    End Sub

    ' ==========================
    ' ADD PHOTO
    ' ==========================
    Private Sub AddPhoto()
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            currentPic.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' ==========================
    ' UPDATE PHOTO
    ' ==========================
    Private Sub UpdatePhoto()
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            currentPic.Image = Image.FromFile(OpenFileDialog1.FileName)
        End If
    End Sub

    ' ==========================
    ' DELETE PHOTO
    ' ==========================
    Private Sub DeletePhoto()
        currentPic.Image = Nothing
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox1.SelectedIndexChanged
        CurrentStocks.Text = UpdateStocksBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox1.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox1.Text, value) Then
            Price1.Text = "₱" & value.ToString("N2")
        Else
            Price1.Text = ""
        End If
    End Sub
    Private Sub ClearInputs(adminForm1 As AdminForm1)

        For Each ctrl As Control In Panel1.Controls
            Select Case True
                Case TypeOf ctrl Is TextBox
                    DirectCast(ctrl, TextBox).Clear()
                Case TypeOf ctrl Is ComboBox
                    Dim cb = DirectCast(ctrl, ComboBox)
                    cb.SelectedIndex = -1
                    cb.Text = ""
                Case TypeOf ctrl Is PictureBox
                    DirectCast(ctrl, PictureBox).Image = Nothing
            End Select
        Next

        For Each ctrl As Control In TableLayoutPanel1.Controls
            Select Case True
                Case TypeOf ctrl Is TextBox
                    DirectCast(ctrl, TextBox).Clear()
                Case TypeOf ctrl Is ComboBox
                    Dim cb = DirectCast(ctrl, ComboBox)
                    cb.SelectedIndex = -1
                    cb.Text = ""
            End Select
        Next
    End Sub
    Public Class ToolItem
        Public Property ToolID As Integer
        Public Property Name As String
        Public Property Availability As String
        Public Property Price As Decimal
        Public Property Stocks As Integer
        Public Property ImageData As Byte()
    End Class
    Public Class ToolValidator
        Public Shared Function Validate(tool As ToolItem) As String
            Dim allowed = {"AVAILABLE", "NOT AVAILABLE"}

            'TOOL NAME VALIDATION
            If String.IsNullOrWhiteSpace(tool.Name) Then
                Return "Tool name cannot be empty."
            End If
            If tool.Name.Length > 100 Then
                Return "Tool name exceeds allowed length."
            End If
            If tool.Name.Trim().Length < 2 Then
                Return "Tool name is too short."
            End If
            If System.Text.RegularExpressions.Regex.IsMatch(tool.Name, "\d") Then
                Return "Tool name cannot contain numbers."
            End If

            'AVAILABILITY VALIDATION
            If String.IsNullOrWhiteSpace(tool.Availability) Then
                Return "Availability status cannot be empty."
            End If
            If Not allowed.Contains(tool.Availability) Then
                Return "Availability value is not recognized. Must be AVAILABLE or NOT AVAILABLE (All Capitalized)."
            End If

            If tool.Availability = "Available" And tool.Stocks = 0 Then
                Return "Available tools must have stocks greater than zero."
            End If

            'PRICE VALIDATION
            If tool.Price < 0 Then
                Return "Price cannot be negative."
            End If
            If tool.Price = 0 Then
                Return "Price cannot be zero."
            End If
            If tool.Price > 9999 Then
                Return "Price is unreasonably high."
            End If

            'STOCK VALIDATION
            If tool.Stocks < 0 Then
                Return "Stocks cannot be negative."
            End If
            If tool.Stocks > 100000 Then
                Return "Stock value is too large."
            End If

            'IMAGE VALIDATION
            If tool.ImageData Is Nothing OrElse tool.ImageData.Length = 0 Then
                Return "Image is required. Please click the Picture Box above."
            End If
            Return Nothing
        End Function
    End Class

    Public Class ToolRepository
        Private ReadOnly connectionString As String =
        "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"

        Public Function AddTool(tool As ToolItem) As Boolean
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                INSERT INTO tbl_tools (Tool_Name, is_Available, Price, Stocks, Tool_Image)
                VALUES (@name, @avail, @price, @stocks, @img)
            "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@name", tool.Name)
                    cmd.Parameters.AddWithValue("@avail", tool.Availability)
                    cmd.Parameters.AddWithValue("@price", tool.Price)
                    cmd.Parameters.AddWithValue("@stocks", tool.Stocks)
                    cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = tool.ImageData

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        End Function

        Public Function UpdateTool(tool As ToolItem) As Boolean
            Using conn As New MySqlConnection(connectionString)
                conn.Open()

                Dim query As String = "
                UPDATE tbl_tools SET
                    Tool_Name=@name,
                    is_Available=@avail,
                    Price=@price,
                    Stocks=@stocks,
                    Tool_Image=@img
                WHERE Tool_ID=@id
            "

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", tool.ToolID)
                    cmd.Parameters.AddWithValue("@name", tool.Name)
                    cmd.Parameters.AddWithValue("@avail", tool.Availability)
                    cmd.Parameters.AddWithValue("@price", tool.Price)
                    cmd.Parameters.AddWithValue("@stocks", tool.Stocks)
                    cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = tool.ImageData

                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        End Function

        Public Function DeleteTool(tool As ToolItem) As Boolean
            Using conn As New MySqlConnection(connectionString)
                conn.Open()
                Dim query As String = "
                UPDATE tbl_tools
                SET is_Deleted= '1'
                WHERE Tool_ID=@id"
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@id", tool.ToolID)
                    cmd.ExecuteNonQuery()
                    Return True
                End Using
            End Using
        End Function
    End Class

    Private Function ImageToBytes(img As Image) As Byte()
        Using bmp As New Bitmap(img)
            Using ms As New MemoryStream()
                bmp.Save(ms, Imaging.ImageFormat.Png)
                Return ms.ToArray()
            End Using
        End Using
    End Function



    Private Sub AddTool_Click(sender As Object, e As EventArgs) Handles AddTool.Click
        Dim price As Decimal
        If Not Decimal.TryParse(UpdatePriceBox1.Text, price) Then
            MessageBox.Show("Price must be a valid number.")
            Exit Sub
        End If

        Dim stocks As Integer
        If Not Integer.TryParse(UpdateStocksBox1.Text, stocks) Then
            MessageBox.Show("Stocks must be a valid number.")
            Exit Sub
        End If
        Dim tool As New ToolItem With {
        .Name = ToolNameBox1.Text,
        .Availability = AvailabilityBox1.Text.ToUpper(),
        .Price = UpdatePriceBox1.Text,
        .Stocks = UpdateStocksBox1.Text,
        .ImageData = If(ProductImage1.Image IsNot Nothing, ImageToBytes(ProductImage1.Image), Nothing)}

        Dim repo As New ToolRepository

        Dim errorMsg = ToolValidator.Validate(tool)
        If errorMsg IsNot Nothing Then
            MessageBox.Show(errorMsg)
            Exit Sub
        ElseIf repo.AddTool(tool) Then
            MessageBox.Show("Tool saved successfully.")
            LoadTools()
        End If

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim price As Decimal
        If Not Decimal.TryParse(UpdatePriceBox1.Text, price) Then
            MessageBox.Show("Price must be a valid number.")
            Exit Sub
        End If

        Dim stocks As Integer
        If Not Integer.TryParse(UpdateStocksBox1.Text, stocks) Then
            MessageBox.Show("Stocks must be a valid number.")
            Exit Sub
        End If
        Dim tool As New ToolItem With {
        .ToolID = Integer.Parse(ToolID.Text),
        .Name = ToolNameBox1.Text,
        .Availability = AvailabilityBox1.Text,
        .Price = UpdatePriceBox1.Text,
        .Stocks = UpdateStocksBox1.Text,
        .ImageData = IIf(ProductImage1.Image IsNot Nothing, ImageToBytes(ProductImage1.Image), Nothing)
    }

        Dim errorMsg = ToolValidator.Validate(tool)
        If errorMsg IsNot Nothing Then
            MessageBox.Show(errorMsg)
            Exit Sub
        End If

        Dim repo As New ToolRepository
        If repo.UpdateTool(tool) Then
            MessageBox.Show("Tool updated successfully.")
            LoadTools()
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim tool As New ToolItem With {
        .ToolID = Integer.Parse(ToolID.Text)}
        Dim repo As New ToolRepository
        If repo.DeleteTool(tool) Then
            MessageBox.Show("Tool Deleted Successfully")
        End If
        LoadTools()
        ClearInputs(Me)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scaleX As Single = Screen.PrimaryScreen.Bounds.Width / 1920.0F
        Dim scaleY As Single = Screen.PrimaryScreen.Bounds.Height / 1080.0F
        Me.Scale(New SizeF(scaleX, scaleY))
        LoadTools()
    End Sub

    Dim currentPic As PictureBox

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MessageBox.Show(" The Operation is canceled")
        Me.Hide()
        ClearInputs(Me)
        Me.Show()
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LOGIN As New LOGIN
        LOGIN.Show()
        Hide()
    End Sub

    Private Sub ViewTools_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewTools.CellClick, ViewTools.CellContentClick
        If e.RowIndex >= 0 Then
            Dim imgBytes As Byte() = TryCast(ViewTools.Rows(e.RowIndex).Cells("Tool_Image").Value, Byte())

            If imgBytes IsNot Nothing AndAlso imgBytes.Length > 0 Then
                Using ms As New MemoryStream(imgBytes)
                    ProductImage1.Image = Image.FromStream(ms)
                End Using
            Else
                ProductImage1.Image = Nothing
            End If
            Dim row = ViewTools.Rows(e.RowIndex)
            ToolID.Text = row.Cells("Tool_ID").Value.ToString
            ToolNameBox1.Text = row.Cells("Tool_Name").Value.ToString
            AvailabilityBox1.Text = row.Cells("is_Available").Value.ToString
            UpdatePriceBox1.Text = row.Cells("Price").Value.ToString
            UpdateStocksBox1.Text = row.Cells("Stocks").Value.ToString
            Dim toolImgBytes As Byte() = TryCast(row.Cells("Tool_Image").Value, Byte())
            If toolImgBytes IsNot Nothing AndAlso toolImgBytes.Length > 0 Then
                Using ms As New MemoryStream(toolImgBytes)
                    ProductImage1.Image = Image.FromStream(ms)
                End Using
            Else
                ProductImage1.Image = Nothing
            End If
        End If
    End Sub
    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        LoadTools()
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Try
            MySqlConn.Open()
            MessageBox.Show("You are Connected to mySQL!")
        Catch ex As Exception
            MessageBox.Show("You are not connected to mySQL, please open XAMPP Databse: " & ex.Message)
            MySqlConn.Close()
        Finally
            MySqlConn.Close()
        End Try
    End Sub
    Private Sub btnStocks_Click(sender As Object, e As EventArgs) Handles btnStocks.Click
        Dim AdminForm1 As New AdminForm1
        AdminForm1.Show()
        Hide()
    End Sub

    Private Sub btnHistory_Click(sender As Object, e As EventArgs) Handles btnHistory.Click
        Dim AdminForm2 As New AdminForm2
        AdminForm2.Show()
        Hide()
    End Sub

    Private Sub btnBannedList_Click_1(sender As Object, e As EventArgs) Handles btnBannedList.Click
        Dim AdminForm3 As New AdminForm3
        AdminForm3.Show()
        Hide()
    End Sub
End Class
