Imports System.IO
Imports MySql.Data.MySqlClient
Imports OpenCvSharp
Imports OpenCvSharp.Extensions
Imports System.Drawing.Drawing2D

Public Class Form4

    Public BorrowDate As Date = Date.Now
    Public ReturnDate As Date = Date.Now
    Public TotalPrice As Decimal = 0D

    ' ErrorProvider
    Private ep As New ErrorProvider()

    ' =========================
    ' FORM LOAD
    ' =========================
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ep.BlinkStyle = ErrorBlinkStyle.NeverBlink
    End Sub

    ' =========================
    ' NUMBERS ONLY INPUT
    ' =========================
    Private Sub NumbersOnly_KeyPress(sender As Object, e As KeyPressEventArgs) _
        Handles TextBox4.KeyPress, TextBox8.KeyPress, TextBox6.KeyPress

        If Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> ControlChars.Back Then
            e.Handled = True
        End If
    End Sub

    ' =========================
    ' PH MOBILE AUTO FORMAT
    ' 09XX-XXX-XXXX
    ' =========================
    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged
        Dim txt As String = New String(TextBox4.Text.Where(AddressOf Char.IsDigit).ToArray())

        If txt.Length > 11 Then txt = txt.Substring(0, 11)

        If txt.Length >= 4 AndAlso txt.Length <= 7 Then
            txt = txt.Insert(4, "-")
        ElseIf txt.Length > 7 Then
            txt = txt.Insert(4, "-").Insert(8, "-")
        End If

        TextBox4.Text = txt
        TextBox4.SelectionStart = TextBox4.Text.Length
    End Sub
    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        Dim txt As String = New String(TextBox8.Text.Where(AddressOf Char.IsDigit).ToArray())

        If txt.Length > 11 Then txt = txt.Substring(0, 11)

        If txt.Length >= 4 AndAlso txt.Length <= 7 Then
            txt = txt.Insert(4, "-")
        ElseIf txt.Length > 7 Then
            txt = txt.Insert(4, "-").Insert(8, "-")
        End If

        TextBox8.Text = txt
        TextBox8.SelectionStart = TextBox8.Text.Length
    End Sub

    ' =========================
    ' VALIDATION FUNCTION
    ' =========================
    Private Function ValidateInputs() As Boolean
        Dim isValid As Boolean = True

        ' Reset errors
        ep.Clear()
        ResetBorder(TextBox1)
        ResetBorder(TextBox3)
        ResetBorder(TextBox4)
        ResetBorder(TextBox8)
        ResetBorder(TextBox5)
        ResetBorder(TextBox6)
        ResetBorder(TextBox7)

        ' Required fields
        isValid = CheckRequired(TextBox1, "First name required") And isValid
        isValid = CheckRequired(TextBox3, "Last name required") And isValid
        isValid = CheckRequired(TextBox4, "Mobile number required") And isValid
        isValid = CheckRequired(TextBox8, "Recipient number required") And isValid
        isValid = CheckRequired(TextBox5, "Street required") And isValid
        isValid = CheckRequired(TextBox6, "Block required") And isValid
        isValid = CheckRequired(TextBox7, "Lot required") And isValid

        ' Mobile format check
        If TextBox4.Text.Length <> 13 Then
            ep.SetError(TextBox4, "Invalid Philippine mobile format")
            SetRedBorder(TextBox4)
            isValid = False
        End If

        Return isValid
    End Function

    ' =========================
    ' REQUIRED FIELD CHECK
    ' =========================
    Private Function CheckRequired(tb As TextBox, msg As String) As Boolean
        If String.IsNullOrWhiteSpace(tb.Text) Then
            ep.SetError(tb, msg)
            SetRedBorder(tb)
            Return False
        End If
        Return True
    End Function

    ' =========================
    ' RED BORDER EFFECT
    ' =========================
    Private Sub SetRedBorder(tb As TextBox)
        tb.BackColor = Color.MistyRose
    End Sub

    Private Sub ResetBorder(tb As TextBox)
        tb.BackColor = Color.White
    End Sub

    ' =========================
    ' IMAGE UPLOAD
    ' =========================
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim ofd As New OpenFileDialog With {
            .Title = "Select an Image",
            .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif"
        }

        If ofd.ShowDialog() = DialogResult.OK Then
            PictureBox11.Image = Image.FromFile(ofd.FileName)
            PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
        End If
    End Sub

    ' =========================
    ' SAVE BUTTON
    ' =========================
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        ' 🔒 VALIDATE FIRST
        If Not ValidateInputs() Then Exit Sub

        Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;")
        conn.Open()

        Try
            Dim clientID As Integer

            ' INSERT CLIENT
            Dim qClient As String =
                "INSERT INTO tbl_client
                (FirstName, MiddleName, LastName, StreetName, Block, Lot, MobileNumber, ReceiptientNumber)
                VALUES
                (@FirstName, @MiddleName, @LastName, @Street, @Block, @Lot, @Mobile, @Receiptient)"

            Using cmd As New MySqlCommand(qClient, conn)
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@MiddleName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Street", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Lot", TextBox7.Text)
                cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Receiptient", TextBox8.Text)
                cmd.ExecuteNonQuery()
            End Using

            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                clientID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' SAVE IMAGE
            If PictureBox11.Image IsNot Nothing Then
                Using ms As New MemoryStream()
                    PictureBox11.Image.Save(ms, Imaging.ImageFormat.Jpeg)
                    Dim img() As Byte = ms.ToArray()

                    Using cmd As New MySqlCommand(
                        "UPDATE tbl_client SET Picture=@img WHERE Client_ID=@id", conn)
                        cmd.Parameters.AddWithValue("@img", img)
                        cmd.Parameters.AddWithValue("@id", clientID)
                        cmd.ExecuteNonQuery()
                    End Using
                End Using
            End If

            MessageBox.Show("Record saved successfully!", "Success",
                            MessageBoxButtons.OK, MessageBoxIcon.Information)

            Dim Agreement As New Agreement
            Agreement.Show()
            Me.Hide()

        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    ' =========================
    ' BACK BUTTON
    ' =========================
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm2 As New Form2
        frm2.Show()
        Me.Hide()
    End Sub

End Class
