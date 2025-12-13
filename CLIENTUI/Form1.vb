Imports System.Drawing.Drawing2D
Imports MySql.Data.MySqlClient

Public Class Form1

    ' =========================
    ' DATABASE CONNECTION
    ' =========================
    Private connectionstring As String =
        "Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;"

    ' Login attempts counter
    Private attemptCount As Integer = 0

    ' =========================
    ' ROUND CORNERS
    ' =========================
    Public Sub RoundCorners(panel As TableLayoutPanel, radius As Integer)
        Dim path As New GraphicsPath()
        Dim w As Integer = panel.Width
        Dim h As Integer = panel.Height

        path.StartFigure()
        path.AddArc(0, 0, radius, radius, 180, 90)
        path.AddLine(radius, 0, w - radius, 0)
        path.AddArc(w - radius, 0, radius, radius, 270, 90)
        path.AddLine(w, radius, w, h - radius)
        path.AddArc(w - radius, h - radius, radius, radius, 0, 90)
        path.AddLine(w - radius, h, radius, h)
        path.AddArc(0, h - radius, radius, radius, 90, 90)
        path.CloseFigure()

        panel.Region = New Region(path)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RoundCorners(LoginPanel, 100)
        Passwordtxt.UseSystemPasswordChar = True
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) _
        Handles chkShowPassword.CheckedChanged

        Passwordtxt.UseSystemPasswordChar = Not chkShowPassword.Checked
    End Sub
    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click

        Dim username As String = Usernametxt.Text.Trim()
        Dim password As String = Passwordtxt.Text.Trim()

        If String.IsNullOrEmpty(username) OrElse String.IsNullOrEmpty(password) Then
            MessageBox.Show("Please enter both username and password",
                            "Input Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Warning)
            Exit Sub
        End If

        Using conn As New MySqlConnection(connectionstring)
            Try
                conn.Open()

                Dim role As String = ""
                Dim isLocked As Boolean = False
                Dim loginSuccess As Boolean = False

                Dim query As String =
                    "SELECT role, is_locked
                    FROM tbl_admin
                    WHERE username=@username AND password=@password"

                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@username", username)
                    cmd.Parameters.AddWithValue("@password", password)
                    Using reader As MySqlDataReader = cmd.ExecuteReader()
                        If reader.Read() Then
                            role = reader("role").ToString()
                            isLocked = Convert.ToBoolean(reader("is_locked"))
                            loginSuccess = True
                        End If
                    End Using
                End Using
                If loginSuccess Then

                    If isLocked AndAlso role <> "superadmin" Then
                        MessageBox.Show("Account is locked. Super Admin access required.")
                        Exit Sub
                    End If

                    attemptCount = 0
                    MessageBox.Show("Login Successful!")
                    Dim form2 As New Form2
                    Me.Hide()
                    form2.Show()

                Else
                    attemptCount += 1

                    If attemptCount >= 3 Then
                        Dim lockQuery As String =
                            "UPDATE tbl_admin SET is_locked = 1 WHERE username=@username"

                        Using lockCmd As New MySqlCommand(lockQuery, conn)
                            lockCmd.Parameters.AddWithValue("@username", username)
                            lockCmd.ExecuteNonQuery()
                        End Using

                        MessageBox.Show("Too many failed attempts. Account locked.")
                    Else
                        MessageBox.Show($"Invalid username or password. Attempts left: {3 - attemptCount}")
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show("Database Error: " & ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error)
            End Try

        End Using
    End Sub

End Class

