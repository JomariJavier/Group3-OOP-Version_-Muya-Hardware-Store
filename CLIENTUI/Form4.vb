Imports System.IO
Imports MySql.Data.MySqlClient
Imports OpenCvSharp
Imports OpenCvSharp.Extensions

Public Class Form4
    Private Sub PictureBox11_Click(sender As Object, e As EventArgs) Handles PictureBox11.Click
        Dim ofd As New OpenFileDialog With {
        .Title = "Select an Image",
        .Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif",
        .Multiselect = False
    }

        If ofd.ShowDialog() = DialogResult.OK Then
            Try
                PictureBox11.Image = Image.FromFile(ofd.FileName)
                PictureBox11.SizeMode = PictureBoxSizeMode.Zoom
            Catch ex As Exception
                MessageBox.Show("Unable to load image: " & ex.Message)
            End Try
        End If
    End Sub
    ' --- INSERT CLIENT & ADDRESS DATA ---
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conn As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Pwd=;Database=db_rent;")
        conn.Open()

        Try
            ' Insert Address
            Dim queryAddress As String = "INSERT INTO tbl_address (Street, Block, Lot) VALUES (@Street, @Block, @Lot)"
            Using cmd As New MySqlCommand(queryAddress, conn)
                cmd.Parameters.AddWithValue("@Street", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Lot", TextBox7.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Insert Client
            Dim queryClient As String = "INSERT INTO tbl_client (FirstName, MiddleName, LastName, MobileNum, ReceiptientNum) VALUES (@FirstName, @MiddleName, @LastName, @Contact, @ReceiptientNum)"
            Using cmd As New MySqlCommand(queryClient, conn)
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@MiddleName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Contact", TextBox4.Text)
                cmd.Parameters.AddWithValue("@ReceiptientNum", TextBox8.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Get the last inserted ClientID
            Dim clientID As Integer
            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                clientID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Save photo if available
            If PictureBox11.Image IsNot Nothing Then
                MessageBox.Show("Saving image for Client_ID = " & clientID)

                Using ms As New MemoryStream()
                    PictureBox11.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Dim imgBytes() As Byte = ms.ToArray()

                    Dim queryPhoto As String = "UPDATE tbl_client SET Picture=@photo WHERE Client_ID=@id"
                    Using cmd As New MySqlCommand(queryPhoto, conn)
                        cmd.Parameters.AddWithValue("@photo", imgBytes)
                        cmd.Parameters.AddWithValue("@id", clientID)
                        cmd.ExecuteNonQuery()
                        MessageBox.Show("Rows affected: " & cmd.ExecuteNonQuery().ToString())

                    End Using
                End Using
            End If

            MessageBox.Show("Record Saved!")
            Dim Agreement As New Agreement
            Agreement.Show()
            Me.Hide()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        Finally
            conn.Close()
        End Try
    End Sub


    ' --- NAVIGATION BUTTON ---
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form3 As New Form3
        Form3.Show()
        Me.Hide()
    End Sub
End Class
