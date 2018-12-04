Public Class Form2
    Private Sub btncompute_Click(sender As Object, e As EventArgs) Handles btncompute.Click


        Dim sale1 As Double
        Dim sale2 As Double
        Dim saletotal As Double
        Dim Commissions1 As Double
        Dim Commissions2 As Double
        Dim Commissionstotal As Double

        sale1 = Val(txtComputer.Text)
        sale2 = Val(txtPrinter.Text)
        saletotal = sale1 + sale2

        Commissions1 = sale1 * 0.05
        Commissions2 = sale2 * 0.1
        Commissionstotal = Commissions1 + Commissions2

        lblsale1.Text = sale1
        lblsale2.Text = sale2
        lblsaletotal.Text = saletotal
        lblCommissions1.Text = Commissions1
        lblCommissions2.Text = Commissions2
        lblCommissionstotal.Text = Commissionstotal








    End Sub
End Class