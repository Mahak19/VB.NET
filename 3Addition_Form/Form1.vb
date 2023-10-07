Public Class frmAddition
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        txtResult.Text = Val(txtFirst.Text) + Val(txtSecond.Text)
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
