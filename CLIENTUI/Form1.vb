Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient
Public Class Form1
    Public Sub RoundCorners(panel As TableLayoutPanel, radius As Integer)
        Dim path As New GraphicsPath()
        Dim w As Integer = panel.Width
        Dim h As Integer = panel.Height

        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)          ' Top-left
        path.AddLine(radius, 0, w - radius, 0)             ' Top edge
        path.AddArc(w - radius, 0, radius, radius, 270, 90) ' Top-right
        path.AddLine(w, radius, w, h - radius)             ' Right edge
        path.AddArc(w - radius, h - radius, radius, radius, 0, 90) ' Bottom-right
        path.AddLine(w - radius, h, radius, h)             ' Bottom edge
        path.AddArc(0, h - radius, radius, radius, 90, 90) ' Bottom-left
        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(LoginPanel, 100) ' 20px radius
    End Sub

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
End Class
