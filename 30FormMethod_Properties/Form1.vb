Public Class Form1
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        MsgBox("Submit")
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        MsgBox("Cancel")
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub

    Private Sub btnForm2_Click(sender As Object, e As EventArgs) Handles btnForm2.Click
        Form2.Show()
    End Sub

    Private Sub btnForm3_Click(sender As Object, e As EventArgs) Handles btnForm3.Click
        Form3.Show()
    End Sub

    Private Sub btnForm4_Click(sender As Object, e As EventArgs) Handles btnForm4.Click
        Form4.Show()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MsgBox("Load Event")
    End Sub
    Private Sub Form1_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        MsgBox("Activated Event")
    End Sub
    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        MsgBox("Close Event")
    End Sub

    Private Sub Form1_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim i As Integer
        i = MsgBox("Do you want to exit from the project", MsgBoxStyle.YesNoCancel, "Close")
        MsgBox(i)
        If i = 6 Then
            Me.Close()
        ElseIf i = 7 Then
            Me.Focus()
        Else
            Me.Focus()
        End If
    End Sub


End Class
