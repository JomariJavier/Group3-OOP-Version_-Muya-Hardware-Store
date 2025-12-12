Imports MySql.Data.MySqlClient

Public Class AdminForm3
    Dim MySqlConn As MySqlConnection

    Public Sub LoadBannedList()
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT Picture, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS FullName, Ban_Reason FROM tbl_client WHERE Is_Banned = '1'"
        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewBanned.DataSource = dt
                    If ViewBanned.Columns.Contains("Picture") Then
                        Dim imgCol As DataGridViewImageColumn = CType(ViewBanned.Columns("Picture"), DataGridViewImageColumn)
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                        imgCol.Width = 150
                    End If
                    If ViewBanned.Columns.Contains("FullName") Then
                        ViewBanned.Columns("FullName").AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
                    End If
                    If ViewBanned.Columns.Contains("Ban_Reason") Then
                        ViewBanned.Columns("Ban_Reason").AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
                        ViewBanned.Columns("Ban_Reason").DefaultCellStyle.WrapMode = DataGridViewTriState.True
                    End If
                    ViewBanned.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells
                    ViewBanned.RowTemplate.Height = 150
                End Using
            End Using
        End Using
        ViewBanned.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
       "SELECT Picture, CONCAT(LastName, ', ', FirstName, ' ', MiddleName) AS FullName, Ban_Reason " &
        "FROM tbl_client " &
        "WHERE (FirstName LIKE @term OR MiddleName LIKE @term OR LastName LIKE @term) " &
        "AND Is_Banned = '1';"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@term", "%" & BannedSearchBox.Text & "%")

                Dim dt As New DataTable()
                Using da As New MySqlDataAdapter(cmd)
                    da.Fill(dt)
                End Using

                ViewBanned.DataSource = dt
                If ViewBanned.Columns.Contains("Picture") Then
                    Dim imgCol As DataGridViewImageColumn =
                    CType(ViewBanned.Columns("Picture"), DataGridViewImageColumn)
                    imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom
                End If
                ViewBanned.RowTemplate.Height = 80
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
    Private Sub AdminForm3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadBannedList()
    End Sub

    Private Sub BannedSearchBox_TextChanged(sender As Object, e As EventArgs) Handles BannedSearchBox.TextChanged

    End Sub

    Private Sub ViewBanned_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewBanned.CellContentClick

    End Sub
End Class