Imports System.Reflection.Emit
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient

Public Class AdminForm4
    Dim MySqlConn As MySqlConnection
    Public Sub LoadClientsToBan()
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT Client_ID, Picture, CONCAT(FirstName, ', ' ,LastName,' ',MiddleName)AS Fullname, is_Banned FROM tbl_client WHERE is_Banned = '0'"
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewClientsToBan.DataSource = dt
                    ViewClientsToBan.Columns("Client_ID").Visible = False
                    ViewClientsToBan.Columns("is_Banned").Visible = False
                    Dim imgCol As DataGridViewImageColumn = CType(ViewClientsToBan.Columns("Picture"), DataGridViewImageColumn)
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                    ViewClientsToBan.RowTemplate.Height = 80
                End Using
            End Using
        End Using
        ViewClientsToBan.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub ConfirmButton_Click(sender As Object, e As EventArgs) Handles ConfirmButton.Click
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "UPDATE tbl_client " &
        "SET Is_Banned = @banStatus, Ban_Reason = @reason " &
        "WHERE Client_ID = @id;"
        Dim user_action As DialogResult =
        MessageBox.Show("Are you certain?", "Ban Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If user_action = DialogResult.Yes Then
            Using conn As New MySqlConnection(ConnectionString)
                Using cmd As New MySqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@banStatus", 1)
                    cmd.Parameters.AddWithValue("@reason", ReasonTextBox.Text.Trim())
                    cmd.Parameters.AddWithValue("@id", IDTextBox.Text.Trim())

                    conn.Open()
                    cmd.ExecuteNonQuery()
                End Using
            End Using

            MessageBox.Show("Ban Success!")
        Else
            MessageBox.Show("The ban has been canceled.")
        End If

        LoadClientsToBan()
    End Sub
    Private Sub ViewClientsToBan_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewClientsToBan.CellContentClick, ViewClientsToBan.CellClick
        If e.RowIndex < 0 Then Exit Sub
        Dim selectedRow As DataGridViewRow = ViewClientsToBan.Rows(e.RowIndex)
        IDTextBox.Text = selectedRow.Cells("Client_ID").Value.ToString()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim LOGIN As New LOGIN
        LOGIN.Show()
        Hide()
    End Sub

    Private Sub AdminForm4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadClientsToBan()
    End Sub
End Class