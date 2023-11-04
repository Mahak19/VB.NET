Public Class Form1
    Private Sub cmbColor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbColor.SelectedIndexChanged
        'MsgBox(cmbColor.SelectedIndex)
        'MsgBox(cmbColor.SelectedItem)
        'MsgBox(cmbColor.SelectedValue)

        If cmbColor.SelectedItem = "Red" Then
            Me.BackColor = Color.Red
        ElseIf cmbColor.SelectedItem = "Violet" Then
            Me.BackColor = Color.Violet
        ElseIf cmbColor.SelectedItem = "Yellow" Then
            Me.BackColor = Color.Yellow
        ElseIf cmbColor.SelectedItem = "Blue" Then
            Me.BackColor = Color.Blue
        ElseIf cmbColor.SelectedItem = "Orange" Then
            Me.BackColor = Color.Orange
        ElseIf cmbColor.SelectedItem = "Tomato" Then
            Me.BackColor = Color.Tomato
        End If
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        MsgBox("Click")
    End Sub
End Class
