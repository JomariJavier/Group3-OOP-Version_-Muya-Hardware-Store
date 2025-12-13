Imports MySql.Data.MySqlClient
Imports Org.BouncyCastle.Math
Imports Org.BouncyCastle.Pqc.Crypto.Frodo

Public Class Form3
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        ' Do NOT update stock here!
        ' Just pass the cart to Form4

        Dim f4 As New Form4

        ' Pass the cart rows to Form4
        For Each row As DataGridViewRow In dgvConfirm.Rows
            If Not row.IsNewRow Then
                f4.dgvFinal.Rows.Add(
                row.Cells("colName").Value,
                row.Cells("colPrice").Value,
                row.Cells("colQty").Value
            )
            End If
        Next

        f4.Show()
        Me.Hide()

    End Sub




    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs)
        Dim Form1 As New Form1
        Form1.Show()
        Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Form2 As New Form2
        Form2.Show()
        Hide()
    End Sub

    Private Sub CalculateTotalPrice()
        If dtReturn.Value.Date < dtBorrow.Value.Date Then
            MessageBox.Show("Return date cannot be earlier than borrow date.")
            Exit Sub
        End If

        Dim days As Integer = (dtReturn.Value.Date - dtBorrow.Value.Date).TotalDays

        If days = 0 Then days = 1 ' Minimum 1 day rent

        Dim total As Decimal = 0D

        ' Add price for each item in the cart
        For Each row As DataGridViewRow In dgvConfirm.Rows
            If Not row.IsNewRow Then
                Dim price As Decimal = CDec(row.Cells("colPrice").Value)
                Dim qty As Integer = CInt(row.Cells("colQty").Value)

                total += (price * qty * days)
            End If
        Next

        txtTotalPrice.Text = total.ToString("0.00")

    End Sub

    Private Sub dtBorrow_ValueChanged(sender As Object, e As EventArgs) Handles dtBorrow.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub dtReturn_ValueChanged(sender As Object, e As EventArgs) Handles dtReturn.ValueChanged
        CalculateTotalPrice()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Dim frm1 As New Form1
        Hide()
        frm1.Show()
    End Sub

    Private Sub dgvConfirm_CellContentClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Function ParsePrice(priceText As String) As Decimal
        If String.IsNullOrWhiteSpace(priceText) Then Return 0D

        ' Remove peso sign and commas
        priceText = priceText.Replace("₱", "").Replace(",", "").Trim()

        Dim value As Decimal
        Decimal.TryParse(priceText, value)
        Return value
    End Function

    Private Sub txtTotalPrice_Click(sender As Object, e As EventArgs) Handles txtTotalPrice.Click

    End Sub

    Private Sub PesoSwap(sender As Object, e As EventArgs) Handles txtTotalPrice.TextChanged
        Dim rawValue As String = txtTotalPrice.Text.Replace("₱", "").Trim()
        Dim amount As Decimal

        If Decimal.TryParse(rawValue, amount) Then
            txtTotalPrice.Text = "₱" & amount.ToString("N2")
        End If
    End Sub

    Private Sub dgvConfirm_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles dgvConfirm.CellFormatting
        If dgvConfirm.Columns(e.ColumnIndex).Name = "colPrice" Then
            If e.Value IsNot Nothing AndAlso IsNumeric(e.Value) Then
                e.Value = "₱" & FormatNumber(CDec(e.Value), 2)
                e.FormattingApplied = True
            End If
        End If
    End Sub
End Class