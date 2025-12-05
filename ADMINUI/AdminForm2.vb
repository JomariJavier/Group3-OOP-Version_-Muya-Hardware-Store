Imports MySql.Data.MySqlClient

Public Class AdminForm2
    Dim MySqlConn As MySqlConnection
    Private Sub ViewTools_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewHistory.CellContentClick

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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, t.Price, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "ORDER BY r.Date_Of_Rent DESC;"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ViewHistory.DataSource = dt
                End Using
            End Using
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LOGIN As New LOGIN
        LOGIN.Show()
        Hide()
    End Sub
End Class