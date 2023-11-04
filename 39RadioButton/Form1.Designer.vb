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
        rbtMale = New RadioButton()
        rbtFemale = New RadioButton()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' rbtMale
        ' 
        rbtMale.Appearance = Appearance.Button
        rbtMale.AutoSize = True
        rbtMale.Location = New Point(45, 69)
        rbtMale.Name = "rbtMale"
        rbtMale.Size = New Size(60, 35)
        rbtMale.TabIndex = 1
        rbtMale.TabStop = True
        rbtMale.Text = "Male"
        rbtMale.TextAlign = ContentAlignment.TopLeft
        rbtMale.UseVisualStyleBackColor = True
        ' 
        ' rbtFemale
        ' 
        rbtFemale.Appearance = Appearance.Button
        rbtFemale.AutoSize = True
        rbtFemale.Location = New Point(45, 140)
        rbtFemale.Name = "rbtFemale"
        rbtFemale.Size = New Size(78, 35)
        rbtFemale.TabIndex = 2
        rbtFemale.TabStop = True
        rbtFemale.Text = "Female"
        rbtFemale.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(163, 96)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 0
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(319, 256)
        Controls.Add(Button1)
        Controls.Add(rbtFemale)
        Controls.Add(rbtMale)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents rbtMale As RadioButton
    Friend WithEvents rbtFemale As RadioButton
    Friend WithEvents Button1 As Button
End Class
