Imports MySql.Data.MySqlClient

Public Class Agreement

    ' Go back button
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim frm As New Form2()
        frm.Show()
        Me.Hide()
    End Sub


    ' Final confirmation button
    Private Sub btnFinalConfirm_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As New MySqlConnection("Server=localhost;Port=3306;Uid=root;Database=db_rent")
        con.Open()

        ' Loop through the DataGridView
        For Each row As DataGridViewRow In Form4.dgvFinal.Rows

            If row.IsNewRow Then Continue For

            If row.Cells("colName").Value Is Nothing OrElse row.Cells("colQty").Value Is Nothing Then
                Continue For
            End If

            Dim toolName As String = row.Cells("colName").Value.ToString()
            Dim qty As Integer = CInt(row.Cells("colQty").Value)

            Dim cmd As New MySqlCommand("
                UPDATE tbl_tools
                SET Stocks = Stocks - @qty
                WHERE tool_name = @name
            ", con)

            cmd.Parameters.AddWithValue("@qty", qty)
            cmd.Parameters.AddWithValue("@name", toolName)

            cmd.ExecuteNonQuery()

        Next

        con.Close()

        MessageBox.Show("Rental Successfully Completed! Stock Updated.")

        Dim f1 As New Form1()
        f1.Show()
        Me.Close()

    End Sub

End Class


