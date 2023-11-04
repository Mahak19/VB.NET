Public Class frmFormat
    Private Sub rbtLeft_CheckedChanged(sender As Object, e As EventArgs) Handles rbtLeft.CheckedChanged
        If rbtLeft.Checked Then
            txtDemo.TextAlign = HorizontalAlignment.Left
        End If
    End Sub

    Private Sub rbtCenter_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCenter.CheckedChanged
        If rbtCenter.Checked Then
            txtDemo.TextAlign = HorizontalAlignment.Center
        End If
    End Sub

    Private Sub rbtRight_CheckedChanged(sender As Object, e As EventArgs) Handles rbtRight.CheckedChanged
        If rbtRight.Checked Then
            txtDemo.TextAlign = HorizontalAlignment.Right
        End If
    End Sub
End Class
