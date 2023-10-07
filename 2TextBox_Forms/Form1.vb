Public Class frmName
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click
        MsgBox(txtName.Text)
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtName.Text = ""
    End Sub
End Class
