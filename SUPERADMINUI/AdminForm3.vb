Imports MySql.Data.MySqlClient

Public Class AdminForm3
    Dim MySqlConn As MySqlConnection

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT Picture, FirstName, LastName, MiddleName FROM tbl_client WHERE Is_Banned = 'TRUE'"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ViewBanned.DataSource = dt
                End Using
            End Using
        End Using
        ViewBanned.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT Picture, FirstName, LastName, MiddleName FROM tbl_client WHERE FirstName = '" & BannedSearchBox.Text & "'"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)

                    ViewBanned.DataSource = dt
                End Using
            End Using
        End Using
        ViewBanned.DefaultCellStyle.ForeColor = Color.Black
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim LOGIN As New LOGIN
        LOGIN.Show()
        Hide()
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
        Dim AdminForm4 As New AdminForm4
        AdminForm4.Show()
        Hide()
    End Sub
End Class