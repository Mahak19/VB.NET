Public Class Form1
    Private Sub btnRightShift_Click(sender As Object, e As EventArgs) Handles btnRightShift.Click
        If ListBox1.SelectedIndex < 0 Then

            If ListBox1.SelectedIndex = -1 And ListBox1.Items.Count() Then
                MsgBox("Please select the course to move")
                ListBox1.SetSelected(0, True)
            Else
                MsgBox("List is empty")
            End If

        Else
            ListBox2.Items.Add(ListBox1.SelectedItem)
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub btnAllRightShift_Click(sender As Object, e As EventArgs) Handles btnAllRightShift.Click
        Dim size As Integer
        size = ListBox1.Items.Count - 1
        Dim ar(size) As Object
        ListBox1.Items.CopyTo(ar, 0)
        ListBox2.Items.AddRange(ar)
        ListBox1.Items.Clear()

        If ListBox1.SelectedIndex = -1 Then
            MsgBox("List is empty")
        End If
    End Sub

    Private Sub btnAllLeftShift_Click(sender As Object, e As EventArgs) Handles btnAllLeftShift.Click
        Dim size As Integer
        size = ListBox2.Items.Count - 1
        Dim ar(size) As Object
        ListBox2.Items.CopyTo(ar, 0)
        ListBox1.Items.AddRange(ar)
        ListBox2.Items.Clear()
    End Sub

    Private Sub btnLeftShift_Click(sender As Object, e As EventArgs) Handles btnLeftShift.Click
        If ListBox2.SelectedIndex < 0 Then

            If ListBox2.SelectedIndex = -1 And ListBox2.Items.Count() Then
                MsgBox("Please select the course to move")
                ListBox2.SetSelected(0, True)
            Else
                MsgBox("List is empty")
            End If

        Else
            ListBox1.Items.Add(ListBox2.SelectedItem)
            ListBox2.Items.Remove(ListBox2.SelectedItem)
        End If
    End Sub
End Class
