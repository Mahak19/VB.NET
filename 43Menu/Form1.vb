Public Class Form1
    Private Sub WordWrapToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WordWrapToolStripMenuItem.Click
        If WordWrapToolStripMenuItem.CheckState = CheckState.Unchecked Then
            txtMenu.WordWrap = True
            WordWrapToolStripMenuItem.Checked = CheckState.Checked
        Else
            txtMenu.WordWrap = False
            WordWrapToolStripMenuItem.Checked = CheckState.Unchecked
        End If
    End Sub


    Private Sub BackgroundToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackgroundToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub BackColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        txtMenu.BackColor = ColorDialog1.Color
    End Sub

    Private Sub ForeColorToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForeColorToolStripMenuItem.Click
        ColorDialog1.ShowDialog()
        txtMenu.ForeColor = ColorDialog1.Color
    End Sub

    Private Sub PrintToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PrintToolStripMenuItem.Click
        PrintDialog1.ShowDialog()
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
        txtMenu.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
    End Sub
End Class
