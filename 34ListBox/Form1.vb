Public Class Form1
    Dim course As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'MsgBox("Index is " & ListBox1.SelectedIndex)
        'MsgBox("Item is " & ListBox1.SelectedItem)
        'MsgBox("Selected Items " & ListBox1.SelectedItems)
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        course = InputBox("Enter the couse name- ")
        If ListBox1.Items.Contains(course) Then
            MsgBox("Course Exists,You can't add it,Please enter another course name")

        Else
            ListBox1.Items.Add(course)
            'MsgBox("Course Doesn't Exists")
        End If
        'ListBox1.Items.Add(course)
    End Sub

    Private Sub btnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click
        Dim ind As Byte
        course = InputBox("Enter the couse name- ")
        ind = InputBox("Enter index number- ")
        ListBox1.Items.Insert(ind, course)
    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click
        'ListBox1.Items.Remove("BCA")
        'ListBox1.Items.Remove(ListBox1.SelectedItem)
        If ListBox1.SelectedIndex < 0 Then
            MsgBox("Please select the course you want to remove")
            ListBox1.SelectedIndex = 0
        Else
            ListBox1.Items.Remove(ListBox1.SelectedItem)
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ListBox1.Items.Clear()
    End Sub

    Private Sub btnRemoveAt_Click(sender As Object, e As EventArgs) Handles btnRemoveAt.Click
        'ListBox1.Items.RemoveAt(1)
        If ListBox1.SelectedIndex < 0 Then
            MsgBox("Please select an item to remove")
            ListBox1.SelectedIndex = 0
        Else
            ListBox1.Items.RemoveAt(ListBox1.SelectedIndex)
        End If
    End Sub

    Private Sub btnContains_Click(sender As Object, e As EventArgs) Handles btnContains.Click
        course = InputBox("Enter the name of course you want to search ")
        If ListBox1.Items.Contains(course) Then
            MsgBox("Course Exists")
        Else
            MsgBox("Course Doesn't Exists")
        End If

    End Sub

    Private Sub btnCopyTo_Click(sender As Object, e As EventArgs) Handles btnCopyTo.Click
        Dim ar(10) As String
        Dim i As String
        ListBox1.Items.CopyTo(ar, 0)
        For Each i In ar
            MsgBox(i)
        Next
    End Sub
End Class
