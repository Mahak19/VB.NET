Public Class Form1
    Dim i As Byte
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'MsgBox("Times Up")
        'Timer1.Enabled = False
        If i = 1 Then
            Me.BackColor = Color.LawnGreen
        ElseIf i = 2 Then
            Me.BackColor = Color.LightBlue
        ElseIf i = 3 Then
            Me.BackColor = Color.Violet
        ElseIf i = 4 Then
            Me.BackColor = Color.Yellow
        Else
            Me.BackColor = Color.Turquoise
            i = 1
        End If
        i = i + 1
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        i = 1
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblCounter.Text = lblCounter.Text - 1
        If lblCounter.Text = 0 Then
            Timer2.Enabled = False
            MsgBox("Times Up")
        End If
    End Sub
End Class
