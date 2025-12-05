Imports System.IO
Imports MySql.Data.MySqlClient
Imports Mysqlx
Imports Mysqlx.Crud
Imports System.Data
Imports System.Data.SqlClient
Imports System.Drawing.Text
Imports System.Configuration

Public Class AdminForm1
    Dim MySqlConn As MySqlConnection
    Dim Command1 As MySqlCommand
    Dim Command2 As MySqlCommand
    Dim Command3 As MySqlCommand
    Dim cmd As MySqlCommand
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Enter.Click
        Dim Query1Status As Boolean = False
        Dim Query2Status As Boolean = False
        Dim Query3Status As Boolean = False
        Dim SomeisEmpty1 As Boolean = String.IsNullOrEmpty(LabelBox1.Text) Or String.IsNullOrEmpty(AvailabilityBox1.Text) Or String.IsNullOrEmpty(UpdatePriceBox1.Text) Or String.IsNullOrEmpty(UpdateStocksBox1.Text)
        Dim SomeisEmpty2 As Boolean = String.IsNullOrEmpty(LabelBox2.Text) Or String.IsNullOrEmpty(AvailabilityBox2.Text) Or String.IsNullOrEmpty(UpdatePriceBox2.Text) Or String.IsNullOrEmpty(UpdateStocksBox2.Text)
        Dim SomeisEmpty3 As Boolean = String.IsNullOrEmpty(LabelBox3.Text) Or String.IsNullOrEmpty(AvailabilityBox3.Text) Or String.IsNullOrEmpty(UpdatePriceBox3.Text) Or String.IsNullOrEmpty(UpdateStocksBox3.Text)
        Dim AllisEmpty1 As Boolean = String.IsNullOrEmpty(LabelBox1.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox1.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox1.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox1.Text)
        Dim AllisEmpty2 As Boolean = String.IsNullOrEmpty(LabelBox2.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox2.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox2.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox2.Text)
        Dim AllisEmpty3 As Boolean = String.IsNullOrEmpty(LabelBox3.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox3.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox3.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox3.Text)

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"

        Dim imgData() As Byte
        If ProductImage1.Image Is Nothing Then

        Else

            Using ms As New MemoryStream()
                ProductImage1.Image.Save(ms, ProductImage1.Image.RawFormat)
                imgData = ms.ToArray()
            End Using
        End If

        Dim imgData2() As Byte
        If ProductImage2.Image Is Nothing Then
        Else

            Using ms As New MemoryStream()
                ProductImage2.Image.Save(ms, ProductImage2.Image.RawFormat)
                imgData2 = ms.ToArray()
            End Using
        End If

        Dim imgData3() As Byte
        If ProductImage3.Image Is Nothing Then
        Else

            Using ms As New MemoryStream()
                ProductImage3.Image.Save(ms, ProductImage3.Image.RawFormat)
                imgData3 = ms.ToArray()
            End Using
            Dim ImageQuery As String = "INSERT INTO tbl_tools (Tool_Image) VALUES (@img);"
        End If

        If AllisEmpty1 And ProductImage1.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty1 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")
        Else
            Try
                MySqlConn.Open()

                Dim Query1 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

                Dim cmd As New MySqlCommand(Query1, MySqlConn)

                ' Add text values
                cmd.Parameters.AddWithValue("@name", LabelBox1.Text)
                cmd.Parameters.AddWithValue("@avail", AvailabilityBox1.Text)
                cmd.Parameters.AddWithValue("@price", UpdatePriceBox1.Text)
                cmd.Parameters.AddWithValue("@stocks", UpdateStocksBox1.Text)

                ' Add image blob
                cmd.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData

                cmd.ExecuteNonQuery()
                MySqlConn.Close()
                Query1Status = True
            Catch ex As Exception
                MessageBox.Show("Error in Query number 1: " & ex.Message)
                MySqlConn.Close()
            End Try

        End If

        If AllisEmpty2 And ProductImage2.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty2 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")
        Else
            Try
                MySqlConn.Open()

                Dim Query2 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

                Dim cmd2 As New MySqlCommand(Query2, MySqlConn)

                ' Add text values
                cmd2.Parameters.AddWithValue("@name", LabelBox2.Text)
                cmd2.Parameters.AddWithValue("@avail", AvailabilityBox2.Text)
                cmd2.Parameters.AddWithValue("@price", UpdatePriceBox2.Text)
                cmd2.Parameters.AddWithValue("@stocks", UpdateStocksBox2.Text)

                ' Add image blob
                cmd2.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData2

                cmd2.ExecuteNonQuery()
                MySqlConn.Close()
                Query2Status = True
            Catch ex As Exception
                MessageBox.Show("Error in Query number 2: " & ex.Message)
                MySqlConn.Close()
            End Try
        End If

        If AllisEmpty3 And ProductImage3.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty3 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")

        Else
            Try
                MySqlConn.Open()

                Dim Query3 As String = "INSERT INTO db_rent.tbl_tools 
                            (Tool_Name, is_Available, Price, Stocks, Tool_Image) 
                            VALUES (@name, @avail, @price, @stocks, @img)"

                Dim cmd3 As New MySqlCommand(Query3, MySqlConn)

                ' Add text values
                cmd3.Parameters.AddWithValue("@name", LabelBox3.Text)
                cmd3.Parameters.AddWithValue("@avail", AvailabilityBox3.Text)
                cmd3.Parameters.AddWithValue("@price", UpdatePriceBox3.Text)
                cmd3.Parameters.AddWithValue("@stocks", UpdateStocksBox3.Text)

                ' Add image blob
                cmd3.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData3

                cmd3.ExecuteNonQuery()
                MySqlConn.Close()
                Query3Status = True
            Catch ex As Exception
                MessageBox.Show("Error in Query number 3: " & ex.Message)
                MySqlConn.Close()
            End Try
        End If

        Dim msg As String = ""
        If Query1Status Then msg &= LabelBox1.Text & " is saved" & Environment.NewLine
        If Query2Status Then msg &= LabelBox2.Text & " is saved" & Environment.NewLine
        If Query3Status Then msg &= LabelBox3.Text & " is saved" & Environment.NewLine
        If msg = "" Then
            msg = "No data is saved"
        End If
        MessageBox.Show(msg, "Query Status")
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Update.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader
        Dim SomeisEmpty1 As Boolean = String.IsNullOrEmpty(LabelBox1.Text) Or String.IsNullOrEmpty(AvailabilityBox1.Text) Or String.IsNullOrEmpty(UpdatePriceBox1.Text) Or String.IsNullOrEmpty(UpdateStocksBox1.Text)
        Dim SomeisEmpty2 As Boolean = String.IsNullOrEmpty(LabelBox2.Text) Or String.IsNullOrEmpty(AvailabilityBox2.Text) Or String.IsNullOrEmpty(UpdatePriceBox2.Text) Or String.IsNullOrEmpty(UpdateStocksBox2.Text)
        Dim SomeisEmpty3 As Boolean = String.IsNullOrEmpty(LabelBox3.Text) Or String.IsNullOrEmpty(AvailabilityBox3.Text) Or String.IsNullOrEmpty(UpdatePriceBox3.Text) Or String.IsNullOrEmpty(UpdateStocksBox3.Text)
        Dim AllisEmpty1 As Boolean = String.IsNullOrEmpty(LabelBox1.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox1.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox1.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox1.Text)
        Dim AllisEmpty2 As Boolean = String.IsNullOrEmpty(LabelBox2.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox2.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox2.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox2.Text)
        Dim AllisEmpty3 As Boolean = String.IsNullOrEmpty(LabelBox3.Text) AndAlso String.IsNullOrEmpty(AvailabilityBox3.Text) AndAlso String.IsNullOrEmpty(UpdatePriceBox3.Text) AndAlso String.IsNullOrEmpty(UpdateStocksBox3.Text)

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"

        Dim imgData() As Byte
        If ProductImage1.Image Is Nothing Then

        Else

            Using ms As New MemoryStream()
                ProductImage1.Image.Save(ms, ProductImage1.Image.RawFormat)
                imgData = ms.ToArray()
            End Using
        End If

        Dim imgData2() As Byte
        If ProductImage2.Image Is Nothing Then
        Else

            Using ms As New MemoryStream()
                ProductImage2.Image.Save(ms, ProductImage2.Image.RawFormat)
                imgData2 = ms.ToArray()
            End Using
        End If

        Dim imgData3() As Byte
        If ProductImage3.Image Is Nothing Then
        Else

            Using ms As New MemoryStream()
                ProductImage3.Image.Save(ms, ProductImage3.Image.RawFormat)
                imgData3 = ms.ToArray()
            End Using
            Dim ImageQuery As String = "INSERT INTO tbl_tools (Tool_Image) VALUES (@img);"
        End If

        If AllisEmpty1 And ProductImage1.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty1 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")
        Else
            Try
                MySqlConn.Open()
                Dim Query1 As String

                Query1 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox1.Text & "', 
                    is_Available='" & AvailabilityBox1.Text & "', 
                    Price='" & UpdatePriceBox1.Text & "', 
                    Stocks='" & UpdateStocksBox1.Text & "',
                    Tool_Image= @img WHERE Tool_Name ='" & LabelBox1.Text & "'"

                Command1 = New MySqlCommand(Query1, MySqlConn)

                Command1.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData

                Reader1 = Command1.ExecuteReader


                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Query number 1")
                MySqlConn.Close()
            End Try
        End If

        If AllisEmpty2 And ProductImage2.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty2 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")
        Else
            Try
                MySqlConn.Open()
                Dim Query2 As String

                Query2 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox2.Text & "', 
                    is_Available='" & AvailabilityBox2.Text & "', 
                    Price='" & UpdatePriceBox2.Text & "', 
                    Stocks='" & UpdateStocksBox2.Text & "',
                    Tool_Image= @img WHERE Tool_Name ='" & LabelBox2.Text & "'"

                Command2 = New MySqlCommand(Query2, MySqlConn)
                Command2.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData2

                Reader2 = Command2.ExecuteReader

                MySqlConn.Close()
            Catch ex As Exception
                MessageBox.Show("Error in Query number 2")
                MySqlConn.Close()
            End Try
        End If

        If AllisEmpty3 And ProductImage3.Image Is Nothing Then
            'Do absolutely nothing
        ElseIf SomeisEmpty3 Then
            MessageBox.Show("Incomplete Entries And/Or Empty ImageBox, Please Add Them")
        Else
            Try
                MySqlConn.Open()
                Dim Query3 As String

                Query3 = "update db_rent.tbl_tools set Tool_Name='" & LabelBox3.Text & "', 
                    is_Available='" & AvailabilityBox3.Text & "', 
                    Price='" & UpdatePriceBox3.Text & "', 
                    Stocks='" & UpdateStocksBox3.Text & "',
                    Tool_Image= @img WHERE Tool_Name ='" & LabelBox3.Text & "'"

                Command3 = New MySqlCommand(Query3, MySqlConn)
                Command3.Parameters.Add("@img", MySqlDbType.Blob).Value = imgData3
                Reader3 = Command3.ExecuteReader

                MySqlConn.Close()
                MessageBox.Show("Data Updated")
            Catch ex As Exception
                MessageBox.Show("Error in Query number 3")
                MySqlConn.Close()
            End Try
        End If

    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim Reader1 As MySqlDataReader
        Dim Reader2 As MySqlDataReader
        Dim Reader3 As MySqlDataReader
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"


        Try
            MySqlConn.Open()
            Dim Query1 As String = "DELETE FROM db_rent.tbl_tools WHERE Tool_Name=@ToolName"
            Using Command1 As New MySqlCommand(Query1, MySqlConn)
                Command1.Parameters.AddWithValue("@ToolName", LabelBox1.Text)
                Command1.ExecuteNonQuery()
            End Using
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 1: " & ex.Message)
            MySqlConn.Close()
        End Try

        Try
            MySqlConn.Open()
            Dim Query2 As String = "DELETE FROM db_rent.tbl_tools WHERE Tool_Name=@ToolName"
            Using Command2 As New MySqlCommand(Query2, MySqlConn)
                Command2.Parameters.AddWithValue("@ToolName", LabelBox2.Text)
                Command2.ExecuteNonQuery()
            End Using
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 2: " & ex.Message)
            MySqlConn.Close()
        End Try

        Try
            MySqlConn.Open()
            Dim Query3 As String = "DELETE FROM db_rent.tbl_tools WHERE Tool_Name=@ToolName"
            Using Command3 As New MySqlCommand(Query3, MySqlConn)
                Command3.Parameters.AddWithValue("@ToolName", LabelBox3.Text)
                Command3.ExecuteNonQuery()
            End Using
            MySqlConn.Close()
        Catch ex As Exception
            MessageBox.Show("Error in Query number 3: " & ex.Message)
            MySqlConn.Close()
        End Try

    End Sub
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String = "SELECT * FROM tbl_tools"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ViewTools.DataSource = dt
                End Using
            End Using
        End Using
        ViewTools.DefaultCellStyle.ForeColor = Color.Black
        CType(ViewTools.Columns("Tool_Image"), DataGridViewImageColumn).ImageLayout = DataGridViewImageCellLayout.Zoom
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim scaleX As Single = Screen.PrimaryScreen.Bounds.Width / 1920.0F
        Dim scaleY As Single = Screen.PrimaryScreen.Bounds.Height / 1080.0F
        Me.Scale(New SizeF(scaleX, scaleY))
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

    Dim currentPic As PictureBox

    ' ==========================
    ' CLICK EVENT FOR PICTUREBOX2 TO PICTUREBOX8
    ' ==========================
    Private Sub PictureBox_Click(sender As Object, e As EventArgs) _
            Handles ProductImage1.Click, ProductImage2.Click, ProductImage3.Click

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
        CurrentStocks1.Text = UpdateStocksBox1.Text
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox1.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox1.Text, value) Then
            Price1.Text = "₱" & value.ToString("N2")
        Else
            Price1.Text = ""
        End If
    End Sub
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox2.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox2.Text, value) Then
            Price2.Text = "₱" & value.ToString("N2")
        Else
            Price2.Text = ""
        End If
    End Sub
    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles UpdatePriceBox3.TextChanged
        Dim value As Decimal
        If Decimal.TryParse(UpdatePriceBox3.Text, value) Then
            Price3.Text = "₱" & value.ToString("N2")
        Else
            Price3.Text = ""
        End If
    End Sub
    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox2.SelectedIndexChanged
        CurrentStocks2.Text = UpdateStocksBox2.Text
    End Sub
    Private Sub ComboBox6_SelectedIndexChanged(sender As Object, e As EventArgs) Handles UpdateStocksBox3.SelectedIndexChanged
        CurrentStocks3.Text = UpdateStocksBox3.Text
    End Sub
    Private Sub ClearInputs(adminForm1 As AdminForm1)
        For Each ctrl As Control In TableLayoutPanel1.Controls
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
        For Each ctrl As Control In TableLayoutPanel2.Controls
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
        For Each ctrl As Control In TableLayoutPanel3.Controls
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
        For Each ctrl As Control In TableLayoutPanel5.Controls
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

    End Sub

    Private Sub Cancel_Click(sender As Object, e As EventArgs) Handles Cancel.Click
        MessageBox.Show(" The Operation is canceled")
        Me.Hide()
        ClearInputs(Me)
        Me.Show()
    End Sub

    Private Sub LabelBox2_TextChanged(sender As Object, e As EventArgs) Handles LabelBox2.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LOGIN As New LOGIN
        LOGIN.Show()
        Hide()
    End Sub
End Class
