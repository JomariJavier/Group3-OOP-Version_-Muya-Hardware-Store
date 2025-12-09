Imports MySql.Data.MySqlClient
Public Class Form1
    Private connectionstring As String = "Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;"
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        Dim username As String = Usernametxt.Text
        Dim password As String = Passwordtxt.Text

        If String.IsNullOrEmpty(username) Or String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return

        End If
        Using conn As New MySqlConnection(connectionstring)

            Try
                conn.Open()

                Dim query As String = "SELECT COUNT(*) FROM tbl_admin
                                       WHERE username=@username
                                       AND password=@password"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Dim result As Integer = Convert.ToInt32(cmd.ExecuteScalar())
                    If result > 0 Then
                        MessageBox.Show("Login Successful!",
                                        "Success",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information)
                        Dim form2 As New Form2
                        Me.Hide()
                        form2.Show()
                    Else
                        MessageBox.Show("Invalid username or password. ",
                                        "Login Failed",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Error)


                    End If
                End Using


            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)

            End Try
        End Using
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
