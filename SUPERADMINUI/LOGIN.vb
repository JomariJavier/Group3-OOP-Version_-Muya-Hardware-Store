Imports MySql.Data.MySqlClient
Public Class LOGIN
    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Public Class LoginInfo
        Public Property Username As String
        Public Property Password As String
    End Class
    Public Class LoginValidation
        Public Shared Function IsValidUsername(Username As String) As String

            'USERNAME VALIDATION
            If String.IsNullOrWhiteSpace(Username) OrElse Username.Length < 3 OrElse Username.Length > 20 Then
                Return "Incorrect Username, Try Again"
            End If

            Dim regex As New Text.RegularExpressions.Regex("^[a-zA-Z0-9_]+$")
            If Not regex.IsMatch(Username) Then
                Return "Incorrect Username, Try Again"
            End If

            Return Nothing

        End Function

        'PASSWORD VALIDATION
        Public Shared Function IsValidPassword(password As String) As String
            If String.IsNullOrWhiteSpace(password) OrElse password.Length < 6 OrElse password.Length > 32 Then
                Return "Incorrect Password, Try Again"
            End If

            Dim hasUpper As Boolean = False
            Dim hasLower As Boolean = False
            Dim hasDigit As Boolean = False
            Dim hasSpecial As Boolean = False

            For Each c As Char In password
                If Char.IsUpper(c) Then hasUpper = True
                If Char.IsLower(c) Then hasLower = True
                If Char.IsDigit(c) Then hasDigit = True
                If Not Char.IsLetterOrDigit(c) Then hasSpecial = True
            Next

            If Not hasUpper Then Return "Incorrect Password, Try Again"
            If Not hasLower Then Return "Incorrect Password, Try Again"
            If Not hasDigit Then Return "Incorrect Password, Try Again"
            If Not hasSpecial Then Return "Incorrect Password, Try Again"

            Return Nothing  ' Valid
        End Function
    End Class

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim login As New LoginInfo With {
        .Username = UsernameBox.Text,
        .Password = PasswordBox.Text
        }

        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim UsernameErrorMsg = LoginValidation.IsValidUsername(login.Username)
        If UsernameErrorMsg IsNot Nothing Then
            MessageBox.Show(UsernameErrorMsg)
            Exit Sub
        End If

        Dim PasswordErrorMsg = LoginValidation.IsValidPassword(login.Password)
        If LoginValidation.IsValidPassword(login.Password) IsNot Nothing Then
            MessageBox.Show(PasswordErrorMsg)
            Exit Sub
        End If

        Try
            MySqlConn.Open()

            Dim Query As String = "SELECT * FROM tbl_admin WHERE UserName=@username AND Password=@password"

            Using cmd = New MySqlCommand(Query, MySqlConn)
                cmd.Parameters.AddWithValue("@username", login.Username)
                cmd.Parameters.AddWithValue("@password", login.Password)

                Using reader = cmd.ExecuteReader()
                    If reader.HasRows Then
                        MessageBox.Show("Username and Password are correct, welcome!")
                        AdminForm1.Show()
                        Me.Hide()
                    Else
                        MessageBox.Show("Incorrect Username and Password, try again.")
                    End If
                End Using
            End Using

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            MySqlConn.Close()
        End Try
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles UsernameBox.KeyDown

        ' ENTER key → go to password
        If e.KeyCode = Keys.Enter Then
            PasswordBox.Focus()
            e.SuppressKeyPress = True
        End If

        ' ↓ Down Arrow → go to password
        If e.KeyCode = Keys.Down Then
            PasswordBox.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles PasswordBox.KeyDown

        ' ENTER key → click login button
        If e.KeyCode = Keys.Enter Then
            Button1.PerformClick()
            e.SuppressKeyPress = True
        End If

        ' ↑ Up Arrow → go back to username
        If e.KeyCode = Keys.Up Then
            UsernameBox.Focus()
            e.SuppressKeyPress = True
        End If

    End Sub

End Class
