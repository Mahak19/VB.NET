Public Class Form1
    Private Sub btnArea_Click(sender As Object, e As EventArgs) Handles btnArea.Click
        Dim r As Double
        r = Val(txtRadius.Text)
        r = 3.14 * 3.14 * r
        MsgBox("Area of Circle is: " & r)
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
