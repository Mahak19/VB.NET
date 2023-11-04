Public Class Form1
    Private Sub rbtMale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtMale.CheckedChanged
        If rbtMale.Checked Then
            MsgBox("Male")
        End If
    End Sub

    Private Sub rbtFemale_CheckedChanged(sender As Object, e As EventArgs) Handles rbtFemale.CheckedChanged
        If rbtFemale.Checked Then
            MsgBox("Female")
        End If
    End Sub
End Class
