Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Label7.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        lblyear.Text = Val(txtSalary.Text * 12)
        lblTax.Text = Val(lblyear.Text * 0.05)
        lblBalance.Text = Val(lblyear.Text - lblTax.Text)










    End Sub
End Class
