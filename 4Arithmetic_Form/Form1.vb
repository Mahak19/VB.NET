Public Class frmArithmetic
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtFirst.Text) + Val(txtSecond.Text)
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        txtResult.Text = Val(txtFirst.Text) - Val(txtSecond.Text)
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        txtResult.Text = Val(txtFirst.Text) * Val(txtSecond.Text)
    End Sub

    Private Sub btnIntegerDivision_Click(sender As Object, e As EventArgs) Handles btnIntegerDivision.Click
        txtResult.Text = Val(txtFirst.Text) / Val(txtSecond.Text)
    End Sub

    Private Sub btnFloatDivision_Click(sender As Object, e As EventArgs) Handles btnFloatDivision.Click
        txtResult.Text = Val(txtFirst.Text) \ Val(txtSecond.Text)
    End Sub

    Private Sub btnModulation_Click(sender As Object, e As EventArgs) Handles btnModulation.Click
        txtResult.Text = Val(txtFirst.Text) Mod Val(txtSecond.Text)
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtFirst.Text = ""
        txtSecond.Text = ""
        txtResult.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
