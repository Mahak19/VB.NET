<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        ListBox1 = New ListBox()
        btnEnter = New Button()
        btnAdd = New Button()
        btnInsert = New Button()
        btnClear = New Button()
        btnCopyTo = New Button()
        btnRemove = New Button()
        btnRemoveAt = New Button()
        btnContains = New Button()
        btnCount = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"", "A LEVEL", "B LEVEL", "BCA", "M TECH", "MCA", "MSC", "O LEVEL", "PGDCA", "VSCIT"})
        ListBox1.Location = New Point(12, 4)
        ListBox1.Name = "ListBox1"
        ListBox1.SelectionMode = SelectionMode.MultiExtended
        ListBox1.Size = New Size(148, 179)
        ListBox1.Sorted = True
        ListBox1.TabIndex = 0
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(8, 205)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(148, 72)
        btnEnter.TabIndex = 2
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(231, 32)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(112, 54)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnInsert
        ' 
        btnInsert.Location = New Point(409, 32)
        btnInsert.Name = "btnInsert"
        btnInsert.Size = New Size(112, 54)
        btnInsert.TabIndex = 4
        btnInsert.Text = "Insert"
        btnInsert.UseVisualStyleBackColor = True
        ' 
        ' btnClear
        ' 
        btnClear.Location = New Point(231, 99)
        btnClear.Name = "btnClear"
        btnClear.Size = New Size(112, 51)
        btnClear.TabIndex = 5
        btnClear.Text = "Clear"
        btnClear.UseVisualStyleBackColor = True
        ' 
        ' btnCopyTo
        ' 
        btnCopyTo.Location = New Point(409, 99)
        btnCopyTo.Name = "btnCopyTo"
        btnCopyTo.Size = New Size(112, 51)
        btnCopyTo.TabIndex = 6
        btnCopyTo.Text = "Copy To"
        btnCopyTo.UseVisualStyleBackColor = True
        ' 
        ' btnRemove
        ' 
        btnRemove.Location = New Point(231, 166)
        btnRemove.Name = "btnRemove"
        btnRemove.Size = New Size(112, 50)
        btnRemove.TabIndex = 7
        btnRemove.Text = "Remove"
        btnRemove.UseVisualStyleBackColor = True
        ' 
        ' btnRemoveAt
        ' 
        btnRemoveAt.Location = New Point(409, 166)
        btnRemoveAt.Name = "btnRemoveAt"
        btnRemoveAt.Size = New Size(112, 50)
        btnRemoveAt.TabIndex = 8
        btnRemoveAt.Text = "Remove At"
        btnRemoveAt.UseVisualStyleBackColor = True
        ' 
        ' btnContains
        ' 
        btnContains.Location = New Point(231, 226)
        btnContains.Name = "btnContains"
        btnContains.Size = New Size(112, 51)
        btnContains.TabIndex = 9
        btnContains.Text = "Contains"
        btnContains.UseVisualStyleBackColor = True
        ' 
        ' btnCount
        ' 
        btnCount.Location = New Point(409, 226)
        btnCount.Name = "btnCount"
        btnCount.Size = New Size(112, 51)
        btnCount.TabIndex = 10
        btnCount.Text = "Count"
        btnCount.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(685, 321)
        Controls.Add(btnCount)
        Controls.Add(btnContains)
        Controls.Add(btnRemoveAt)
        Controls.Add(btnRemove)
        Controls.Add(btnCopyTo)
        Controls.Add(btnClear)
        Controls.Add(btnInsert)
        Controls.Add(btnAdd)
        Controls.Add(btnEnter)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnInsert As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnCopyTo As Button
    Friend WithEvents btnRemove As Button
    Friend WithEvents btnRemoveAt As Button
    Friend WithEvents btnContains As Button
    Friend WithEvents btnCount As Button
End Class
