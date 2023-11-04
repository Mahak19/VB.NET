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
        ListBox2 = New ListBox()
        btnRightShift = New Button()
        btnAllRightShift = New Button()
        btnLeftShift = New Button()
        btnAllLeftShift = New Button()
        SuspendLayout()
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 25
        ListBox1.Items.AddRange(New Object() {"BCA", "BCOM", "BSC", "BSC(BIO)", "MA", "MCOM"})
        ListBox1.Location = New Point(12, 6)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(270, 354)
        ListBox1.TabIndex = 0
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 25
        ListBox2.Location = New Point(452, 6)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(303, 354)
        ListBox2.TabIndex = 1
        ' 
        ' btnRightShift
        ' 
        btnRightShift.Location = New Point(315, 24)
        btnRightShift.Name = "btnRightShift"
        btnRightShift.Size = New Size(112, 62)
        btnRightShift.TabIndex = 2
        btnRightShift.Text = ">"
        btnRightShift.UseVisualStyleBackColor = True
        ' 
        ' btnAllRightShift
        ' 
        btnAllRightShift.Location = New Point(315, 115)
        btnAllRightShift.Name = "btnAllRightShift"
        btnAllRightShift.Size = New Size(112, 60)
        btnAllRightShift.TabIndex = 3
        btnAllRightShift.Text = ">>"
        btnAllRightShift.UseVisualStyleBackColor = True
        ' 
        ' btnLeftShift
        ' 
        btnLeftShift.Location = New Point(315, 203)
        btnLeftShift.Name = "btnLeftShift"
        btnLeftShift.Size = New Size(112, 57)
        btnLeftShift.TabIndex = 4
        btnLeftShift.Text = "<"
        btnLeftShift.UseVisualStyleBackColor = True
        ' 
        ' btnAllLeftShift
        ' 
        btnAllLeftShift.Location = New Point(315, 289)
        btnAllLeftShift.Name = "btnAllLeftShift"
        btnAllLeftShift.Size = New Size(112, 56)
        btnAllLeftShift.TabIndex = 5
        btnAllLeftShift.Text = "<<"
        btnAllLeftShift.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(797, 409)
        Controls.Add(btnAllLeftShift)
        Controls.Add(btnLeftShift)
        Controls.Add(btnAllRightShift)
        Controls.Add(btnRightShift)
        Controls.Add(ListBox2)
        Controls.Add(ListBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents btnRightShift As Button
    Friend WithEvents btnAllRightShift As Button
    Friend WithEvents btnLeftShift As Button
    Friend WithEvents btnAllLeftShift As Button
End Class
