Public Class Form1
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim i As Integer
        For i = ProgressBar1.Minimum To ProgressBar1.Maximum - 1
            ProgressBar1.PerformStep()
        Next
    End Sub
End Class
