Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AdminForm4
    Dim MySqlConn As MySqlConnection
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
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT Client_ID, Client_Photo, FirstName, LastName, MiddleName, Is_Banned FROM tbl_client"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ViewClientsToBan.DataSource = dt
                End Using
            End Using
        End Using
        ViewClientsToBan.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "UPDATE tbl_client SET Is_Banned = 'TRUE', Ban_Reason = '" & ReasonTextBox.Text & "' WHERE Client_ID = '" & IDTextBox.Text & "' "

        Dim user_action As DialogResult
        user_action = MessageBox.Show("Are you certain?", "Ban Confirmation", MessageBoxButtons.YesNo)

        If user_action = DialogResult.Yes Then
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    conn.Open()
                    cmd.ExecuteNonQuery()

                    conn.Close()
                    MessageBox.Show("Ban Success!")
                End Using
            End Using
        Else
            MessageBox.Show("The Ban has been canceled.")
        End If
    End Sub
End Class