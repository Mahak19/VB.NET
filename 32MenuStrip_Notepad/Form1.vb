Public Class Form1
    Private Sub mnuUndo_Click(sender As Object, e As EventArgs) Handles mnuUndo.Click
        txtMenu.Undo()
    End Sub

    Private Sub mnuCut_Click(sender As Object, e As EventArgs) Handles mnuCut.Click
        txtMenu.Cut()
    End Sub

    Private Sub mnuCopy_Click(sender As Object, e As EventArgs) Handles mnuCopy.Click
        txtMenu.Copy()
    End Sub

    Private Sub mnuPaste_Click(sender As Object, e As EventArgs) Handles mnuPaste.Click
        txtMenu.Paste()
    End Sub

    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        txtMenu.Clear()
    End Sub

    Private Sub mnuSelect_Click(sender As Object, e As EventArgs) Handles mnuSelect.Click
        txtMenu.Select()
    End Sub

    Private Sub mnuSelectAll_Click(sender As Object, e As EventArgs) Handles mnuSelectAll.Click
        txtMenu.SelectAll()
    End Sub

    Private Sub mnuDeslectAll_Click(sender As Object, e As EventArgs) Handles mnuDeselectAll.Click
        txtMenu.DeselectAll()
    End Sub

    Private Sub mnuShow_Click(sender As Object, e As EventArgs) Handles mnuShow.Click
        txtMenu.Show()
    End Sub

    Private Sub mnuHide_Click(sender As Object, e As EventArgs) Handles mnuHide.Click
        txtMenu.Hide()
    End Sub

End Class
