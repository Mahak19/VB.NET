Public Class Form1
    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        Dim a As Integer
        a = Val(txtNumber.Text)
        If a >= 0 Then
            MsgBox("Positive Number")
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End

    End Sub
End Class
