Public Class Form1
    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        pcbPic.Image = Image.FromFile("C:\Users\hp\Pictures\milkshakeMain.jpg")
    End Sub

    Private Sub btnUnload_Click(sender As Object, e As EventArgs) Handles btnUnload.Click
        pcbPic.Image = Image.FromFile("C:\Users\hp\Pictures\blank.jpg")
    End Sub
End Class
