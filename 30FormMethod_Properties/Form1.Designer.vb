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
        btnSubmit = New Button()
        btnCancel = New Button()
        btnExit = New Button()
        btnForm2 = New Button()
        btnForm3 = New Button()
        btnForm4 = New Button()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(148, 61)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(112, 34)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(148, 142)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(112, 34)
        btnCancel.TabIndex = 1
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(148, 211)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 34)
        btnExit.TabIndex = 2
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnForm2
        ' 
        btnForm2.Location = New Point(148, 292)
        btnForm2.Name = "btnForm2"
        btnForm2.Size = New Size(112, 34)
        btnForm2.TabIndex = 3
        btnForm2.Text = "Form2"
        btnForm2.UseVisualStyleBackColor = True
        ' 
        ' btnForm3
        ' 
        btnForm3.Location = New Point(362, 292)
        btnForm3.Name = "btnForm3"
        btnForm3.Size = New Size(112, 34)
        btnForm3.TabIndex = 4
        btnForm3.Text = "Form3"
        btnForm3.UseVisualStyleBackColor = True
        ' 
        ' btnForm4
        ' 
        btnForm4.Location = New Point(553, 292)
        btnForm4.Name = "btnForm4"
        btnForm4.Size = New Size(112, 34)
        btnForm4.TabIndex = 5
        btnForm4.Text = "Form4"
        btnForm4.UseVisualStyleBackColor = True
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(472, 64)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(150, 31)
        TextBox1.TabIndex = 6
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(472, 145)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(150, 31)
        TextBox2.TabIndex = 7
        ' 
        ' Form1
        ' 
        AcceptButton = btnSubmit
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        CancelButton = btnCancel
        ClientSize = New Size(800, 450)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(btnForm4)
        Controls.Add(btnForm3)
        Controls.Add(btnForm2)
        Controls.Add(btnExit)
        Controls.Add(btnCancel)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnForm2 As Button
    Friend WithEvents btnForm3 As Button
    Friend WithEvents btnForm4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
End Class
