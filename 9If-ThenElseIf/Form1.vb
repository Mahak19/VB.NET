Public Class frmPercentage
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        txtResult.Text = Val(txtFirst.Text) + Val(txtSecond.Text) + Val(txtThird.Text) + txtFourth.Text + Val(txtFirst.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirst.Text = ""
        txtSecond.Text = ""
        txtThird.Text = ""
        txtFourth.Text = ""
        txtFifth.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
