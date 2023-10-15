Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnNormal.Click
        TextBox1.CharacterCasing = CharacterCasing.Normal
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btnUpper.Click
        TextBox1.CharacterCasing = CharacterCasing.Upper
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnLower.Click
        TextBox1.CharacterCasing = CharacterCasing.Lower
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox(TextBox1.SelectionLength)
    End Sub
End Class
