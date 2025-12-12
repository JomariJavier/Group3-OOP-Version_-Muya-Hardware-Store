Imports MySql.Data.MySqlClient

Public Class AdminForm2
    Dim MySqlConn As MySqlConnection
    Public Function LoadHistory()
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT  r.Rent_ID, CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status, r.is_Late " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "ORDER BY r.Date_Of_Rent DESC;"
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewHistory.DataSource = dt
                    ViewHistory.Columns("Rent_ID").Visible = False
                    ViewHistory.Columns("is_Late").Visible = False
                End Using
            End Using
            conn.Close()
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
        FormatNotReturnedRows()
        FormatReturnedRows()
        Return 0
    End Function
    Public Sub UpdateLateRentals()
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "UPDATE tbl_rent " &
        "SET is_Late = 1 " &
        "WHERE Date_Of_Return < CURDATE() " &
        "AND Return_Status <> 'RETURNED';"
        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.ExecuteNonQuery()
            End Using
            conn.Close()
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Public Sub ShowNotReturned()
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT  r.Rent_ID, CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status, r.is_Late " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "WHERE r.Return_Status = 'NOT RETURNED'" &
        "ORDER BY r.Date_Of_Rent DESC;"

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewHistory.DataSource = dt
                    ViewHistory.Columns("Rent_ID").Visible = False
                    ViewHistory.Columns("is_Late").Visible = False
                End Using
            End Using
            conn.Close()
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
        FormatNotReturnedRows()
    End Sub

    Public Sub ShowReturned()
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT  r.Rent_ID, CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status, r.is_Late " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "WHERE r.Return_Status = 'RETURNED'" &
        "ORDER BY r.Date_Of_Rent DESC;"

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewHistory.DataSource = dt
                    ViewHistory.Columns("Rent_ID").Visible = False
                    ViewHistory.Columns("is_Late").Visible = False
                End Using
            End Using
            conn.Close()
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
        FormatReturnedRows()
    End Sub
    Public Sub ToggleReturnStatus(rentId As Integer, newStatus As String, isReturned As Integer)
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "UPDATE tbl_rent SET Return_Status = @status, is_Returned = @isreturned WHERE Rent_ID = @id;"

        Using conn As New MySqlConnection(ConnectionString)
            conn.Open()
            Using cmd As New MySqlCommand(query, conn)
                cmd.Parameters.AddWithValue("@status", newStatus)
                cmd.Parameters.AddWithValue("@isreturned", isReturned)
                cmd.Parameters.AddWithValue("@id", rentId)
                cmd.ExecuteNonQuery()
            End Using
        End Using
    End Sub


    Public Sub ShowLate()
        Dim ConnectionString As String =
        "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"

        Dim query As String =
        "SELECT r.Rent_ID, CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status, r.is_Late " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "WHERE r.is_Late = '1'" &
        "ORDER BY r.Date_Of_Rent DESC;"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    da.Fill(dt)
                    ViewHistory.DataSource = dt
                    ViewHistory.Columns("Rent_ID").Visible = False
                    ViewHistory.Columns("is_Late").Visible = False
                End Using
            End Using
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Public Sub SearchHistory()
        MySqlConn = New MySqlConnection
        Dim ConnectionString As String = "Server=localhost;Port=3306;Database=db_rent;Uid=root;Pwd=;"
        Dim query As String =
        "SELECT r.Rent_ID, CONCAT(c.LastName, ', ', c.FirstName, ' ', c.MiddleName) AS FullName, " &
        "t.Tool_Name, r.Amount, r.Total_Price, r.Date_Of_Rent, r.Date_Of_Return, r.Return_Status, r.is_Late " &
        "FROM tbl_rent r " &
        "LEFT JOIN tbl_client c ON r.Client_ID = c.Client_ID " &
        "LEFT JOIN tbl_tools t ON r.Tool_ID = t.Tool_ID " &
        "WHERE FirstName LIKE @term OR MiddleName LIKE @term OR LastName LIKE @term " &
        "ORDER BY r.Date_Of_Rent DESC;"

        Using conn As New MySqlConnection(ConnectionString)
            Using cmd As New MySqlCommand(query, conn)
                Using da As New MySqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    cmd.Parameters.AddWithValue("@term", "%" & SearchTextBox.Text & "%")
                    da.Fill(dt)
                    ViewHistory.Columns("Rent_ID").Visible = False
                    ViewHistory.Columns("is_Late").Visible = False
                    ViewHistory.DataSource = dt
                End Using
            End Using
        End Using
        ViewHistory.DefaultCellStyle.ForeColor = Color.Black
    End Sub
    Private Sub FormatNotReturnedRows()

        For Each row As DataGridViewRow In ViewHistory.Rows

            If row.IsNewRow = False Then

                Dim statusValue = row.Cells("Return_Status").Value

                If statusValue IsNot Nothing AndAlso statusValue.ToString().ToUpper() = "NOT RETURNED" Then
                    row.DefaultCellStyle.BackColor = Color.FromArgb(255, 150, 150)
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If

            End If

        Next

    End Sub
    Private Sub FormatReturnedRows()

        For Each row As DataGridViewRow In ViewHistory.Rows

            If row.IsNewRow = False Then

                Dim statusValue = row.Cells("Return_Status").Value

                If statusValue IsNot Nothing AndAlso statusValue.ToString().ToUpper() = "RETURNED" Then
                    row.DefaultCellStyle.BackColor = Color.LightGreen
                    row.DefaultCellStyle.ForeColor = Color.Black
                End If

            End If

        Next

    End Sub
    Private Sub FormatLateRows()

        If Not ViewHistory.Columns.Contains("is_Late") Or Not ViewHistory.Columns.Contains("Date_Of_Return") Then Exit Sub

        For Each row As DataGridViewRow In ViewHistory.Rows
            If row.IsNewRow Then Continue For

            Dim val = row.Cells("is_Late").Value

            If val IsNot Nothing AndAlso val.ToString().Trim() = "1" Then
                row.Cells("Date_Of_Return").Style.ForeColor = Color.Red

            Else

                row.Cells("Date_Of_Return").Style.ForeColor = Color.Black
            End If
        Next

    End Sub
    Private Sub AdminForm2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ChangeStatusButton.Enabled = False
        UpdateLateRentals()
        LoadHistory()
    End Sub
    Private Sub ViewHistory_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewHistory.CellContentClick, ViewHistory.CellClick
        If e.RowIndex < 0 Then Exit Sub

        ' Enable button when a row is selected
        ChangeStatusButton.Enabled = True

        Dim row As DataGridViewRow = ViewHistory.Rows(e.RowIndex)
        If row Is Nothing Then Exit Sub

        ' Get Rent_ID safely
        Dim rentValue = row.Cells("Rent_ID").Value
        If rentValue Is Nothing OrElse IsDBNull(rentValue) Then
            Exit Sub
        End If

        Dim rentId As Integer = Convert.ToInt32(rentValue)

        ' Get Return_Status safely
        Dim statusValue = row.Cells("Return_Status").Value
        Dim currentStatus As String = If(statusValue IsNot Nothing AndAlso Not IsDBNull(statusValue), statusValue.ToString().ToUpper(), "")

        Dim isReturned As Integer = If(currentStatus = "RETURNED", 1, 0)

        ' Now rentId and isReturned are safe to use
    End Sub
    Private Sub ViewHistory_DoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles ViewHistory.CellDoubleClick, ViewHistory.CellContentDoubleClick
        If e.RowIndex < 0 Then Exit Sub
        If e.RowIndex >= 0 Then
            ChangeStatusButton.Enabled = True
        End If
        Dim row As DataGridViewRow = ViewHistory.Rows(e.RowIndex)
        Dim rentId = row.Cells("Rent_ID").Value
        If rentId Is Nothing OrElse IsDBNull(rentId) Then
            Exit Sub
        End If
        Dim currentStatus As String = row.Cells("Return_Status").Value.ToString().ToUpper()
        Dim isReturned As Integer = If(currentStatus = "RETURNED", 1, 0)
        Dim newStatus As String
        If currentStatus = "RETURNED" Then
            newStatus = "NOT RETURNED"
            isReturned = 0
        Else
            newStatus = "RETURNED"
            isReturned = 1
        End If
        If MessageBox.Show("Change status to " & newStatus & "?",
                   "Confirm Update",
                   MessageBoxButtons.YesNo,
                   MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If
        ToggleReturnStatus(rentId, newStatus, isReturned)
        UpdateLateRentals()
        LoadHistory()
    End Sub
    Private Sub btnToggleStatus_Click(sender As Object, e As EventArgs) Handles ChangeStatusButton.Click
        If ViewHistory.CurrentRow Is Nothing Then
            MessageBox.Show("Please select a record first.")
            Exit Sub
        End If

        Dim row = ViewHistory.CurrentRow
        Dim rentId As Integer = row.Cells("Rent_ID").Value
        Dim currentStatus = row.Cells("Return_Status").Value.ToString.ToUpper
        Dim newStatus As String
        Dim isReturned As Integer

        If currentStatus = "RETURNED" Then
            newStatus = "NOT RETURNED"
            isReturned = 0
        Else
            newStatus = "RETURNED"
            isReturned = 1
        End If

        If MessageBox.Show("Change status to " & newStatus & "?",
                       "Confirm Update",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        ToggleReturnStatus(rentId, newStatus, isReturned)
        UpdateLateRentals()
        LoadHistory()
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
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles NotReturnedButton.Click
        ShowNotReturned()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs)
        LoadHistory()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles LateButton.Click
        ShowLate()
        For Each col As DataGridViewColumn In ViewHistory.Columns
            Debug.Print(col.Index & " - " & col.Name)
        Next
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ShowReturned()
    End Sub
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        SearchHistory()
    End Sub

    Private Sub HistoryFormat(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles ViewHistory.CellFormatting

        If e.RowIndex < 0 Then Exit Sub
        Dim colName = ViewHistory.Columns(e.ColumnIndex).Name

        ' Replace "Date_Of_Return" with the actual name from Debug.Print
        If colName = "Date_Of_Return" Then
            Dim isLateVal = ViewHistory.Rows(e.RowIndex).Cells("is_Late").Value
            If isLateVal IsNot Nothing AndAlso isLateVal.ToString().Trim() = "1" Then
                e.CellStyle.ForeColor = Color.Red
                e.CellStyle.Font = New Font(ViewHistory.Font, FontStyle.Bold)
            Else
                e.CellStyle.ForeColor = Color.Black
            End If
        End If
    End Sub
End Class