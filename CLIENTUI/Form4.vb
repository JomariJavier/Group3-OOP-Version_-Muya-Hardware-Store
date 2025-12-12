Imports System.IO
Imports MySql.Data.MySqlClient
Imports OpenCvSharp
Imports OpenCvSharp.Extensions

Public Class Form4

    Public BorrowDate As Date = Date.Now
    Public ReturnDate As Date = Date.Now
    Public TotalPrice As Decimal = 0D

    Private Sub PictureBoc11_Load9(Sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
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
            ' 1. INSERT ADDRESS -----------------------
            Dim addressID As Integer
            Dim qAddress As String = "INSERT INTO tbl_address (Street, Block, Lot) 
                                      VALUES (@Street, @Block, @Lot)"

            Using cmd As New MySqlCommand(qAddress, conn)
                cmd.Parameters.AddWithValue("@Street", TextBox5.Text)
                cmd.Parameters.AddWithValue("@Block", TextBox6.Text)
                cmd.Parameters.AddWithValue("@Lot", TextBox7.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Retrieve inserted Address_ID
            Using cmd As New MySqlCommand("SELECT LAST_INSERT_ID()", conn)
                addressID = Convert.ToInt32(cmd.ExecuteScalar())
            End Using

            ' Insert Client
            Dim clientID As Integer
            Dim qClient As String =
                "INSERT INTO tbl_client 
                 (Address_ID, FirstName, MiddleName, LastName, MobileNum, ReceiptientNum) 
                 VALUES 
                 (@Address_ID, @FirstName, @MiddleName, @LastName, @Mobile, @Receiptient)"

            Using cmd As New MySqlCommand(qClient, conn)
                cmd.Parameters.AddWithValue("@Address_ID", addressID)
                cmd.Parameters.AddWithValue("@FirstName", TextBox1.Text)
                cmd.Parameters.AddWithValue("@MiddleName", TextBox2.Text)
                cmd.Parameters.AddWithValue("@LastName", TextBox3.Text)
                cmd.Parameters.AddWithValue("@Mobile", TextBox4.Text)
                cmd.Parameters.AddWithValue("@Receiptient", TextBox8.Text)
                cmd.ExecuteNonQuery()
            End Using

            ' Get the last inserted ClientID
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
            ' 4. INSERT RENT RECORDS ------------------
            ' Ensure each item in dgvFinal is saved into tbl_rent with Client_ID, Tool_ID, dates, price, qty and initial Return_Status.
            ' If a tool name cannot be resolved to a Tool_ID the operation will raise an exception to surface the problem.

            Try
                ' Use a transaction for rent inserts to ensure all-or-nothing for rent rows
                Dim trans As MySqlTransaction = conn.BeginTransaction()

                For Each row As DataGridViewRow In dgvFinal.Rows
                    If row.IsNewRow Then Continue For
                    If row.Cells("colName").Value Is Nothing Then Continue For

                    Dim toolName As String = row.Cells("colName").Value.ToString()
                    Dim price As Decimal = 0D
                    Dim qty As Integer = 1

                    If row.Cells("colPrice").Value IsNot Nothing Then
                        Decimal.TryParse(row.Cells("colPrice").Value.ToString(), price)
                    End If
                    If row.Cells("colQty").Value IsNot Nothing Then
                        Integer.TryParse(row.Cells("colQty").Value.ToString(), qty)
                    End If

                    ' Calculate days (minimum 1)
                    Dim days As Integer = Math.Max(1, (ReturnDate.Date - BorrowDate.Date).Days)
                    If days = 0 Then days = 1

                    Dim perItemTotal As Decimal = price * qty * days

                    ' Resolve Tool_ID
                    Dim toolIdCmd As New MySqlCommand("SELECT Tool_ID FROM tbl_tools WHERE Tool_Name=@name LIMIT 1", conn, trans)
                    toolIdCmd.Parameters.AddWithValue("@name", toolName)
                    Dim toolIDObj As Object = toolIdCmd.ExecuteScalar()

                    If toolIDObj Is Nothing OrElse IsDBNull(toolIDObj) Then
                        ' If a tool is not found rollback and surface clear message
                        trans.Rollback()
                        Throw New Exception("Tool '" & toolName & "' not found in database. Rent records not saved.")
                    End If

                    Dim toolID As Integer = Convert.ToInt32(toolIDObj)

                    Dim qRent As String = "
                        INSERT INTO tbl_rent
                        (Client_ID, Tool_ID, Date_Of_Rent, Date_Of_Return, Total_Price, Amount, Return_Status)
                        VALUES
                        (@Client_ID, @Tool_ID, @Date_Of_Rent, @Date_Of_Return, @Total_Price, @Amount, @Return_Status)
                    "

                    Using rentCmd As New MySqlCommand(qRent, conn, trans)
                        rentCmd.Parameters.AddWithValue("@Client_ID", clientID)
                        rentCmd.Parameters.AddWithValue("@Tool_ID", toolID)
                        rentCmd.Parameters.AddWithValue("@Date_Of_Rent", BorrowDate.Date)
                        rentCmd.Parameters.AddWithValue("@Date_Of_Return", ReturnDate.Date)
                        rentCmd.Parameters.AddWithValue("@Total_Price", perItemTotal)
                        rentCmd.Parameters.AddWithValue("@Amount", qty)
                        rentCmd.Parameters.AddWithValue("@Return_Status", "Borrowed")
                        rentCmd.ExecuteNonQuery()
                    End Using

                Next

                trans.Commit()
            Catch exRent As Exception
                MessageBox.Show("Error saving rent records: " & exRent.Message)
                ' Do not rethrow here to allow the rest of the save flow to continue if desired.
            End Try



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
        Dim frm2 As New Form2
        frm2.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Dim frm1 As New Form1
        Hide()
        frm1.Show()
    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs) Handles Label16.Click

    End Sub

    Private Sub dgvFinal_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvFinal.CellContentClick

    End Sub
End Class
