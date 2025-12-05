Imports MySql.Data.MySqlClient
Public Class LOGIN
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim username As String = TextBox1.Text
        Dim password As String = TextBox2.Text
        Dim Reader As MySqlDataReader

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "SELECT * FROM db_rent.tbl_admin WHERE UserName='" & TextBox1.Text & "'and password='" & TextBox2.Text & "' "
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader
            Dim count As Integer
            count = 0
            While Reader.Read
                count = count + 1
            End While
            If count = 1 Then
                MessageBox.Show("Username and Password is correct, welcome!")
                AdminForm1.Show()
                Me.Hide()
            ElseIf count > 1 Then
                MessageBox.Show("Username and Password are duplicated")
            Else
                MessageBox.Show("Username and Password are incorrect, please try again")
            End If

        Catch ex As Exception

        End Try
    End Sub


    ' ===== USERNAME TEXTBOX =====
    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown

        ' ENTER key → go to password
        If e.KeyCode = Keys.Enter Then
            TextBox2.Focus()
            e.SuppressKeyPress = True
        End If

        ' ↓ Down Arrow → go to password
        If e.KeyCode = Keys.Down Then
            TextBox2.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub


    ' ===== PASSWORD TEXTBOX =====
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown

        ' ENTER key → click login button
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If

        ' ↑ Up Arrow → go back to username
        If e.KeyCode = Keys.Up Then
            TextBox1.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub

    Private Sub TableLayoutPanel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub
End Class
