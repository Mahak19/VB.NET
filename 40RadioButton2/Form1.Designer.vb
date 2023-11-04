<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmFormat
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
        grpAlignment = New GroupBox()
        rbtRight = New RadioButton()
        rbtCenter = New RadioButton()
        rbtLeft = New RadioButton()
        txtDemo = New TextBox()
        grpAlignment.SuspendLayout()
        SuspendLayout()
        ' 
        ' grpAlignment
        ' 
        grpAlignment.Controls.Add(rbtRight)
        grpAlignment.Controls.Add(rbtCenter)
        grpAlignment.Controls.Add(rbtLeft)
        grpAlignment.Location = New Point(12, 56)
        grpAlignment.Name = "grpAlignment"
        grpAlignment.Size = New Size(302, 173)
        grpAlignment.TabIndex = 0
        grpAlignment.TabStop = False
        grpAlignment.Text = "Alignment"
        ' 
        ' rbtRight
        ' 
        rbtRight.Appearance = Appearance.Button
        rbtRight.AutoSize = True
        rbtRight.Location = New Point(186, 41)
        rbtRight.Name = "rbtRight"
        rbtRight.Size = New Size(64, 35)
        rbtRight.TabIndex = 2
        rbtRight.TabStop = True
        rbtRight.Text = "Right"
        rbtRight.UseVisualStyleBackColor = True
        ' 
        ' rbtCenter
        ' 
        rbtCenter.Appearance = Appearance.Button
        rbtCenter.AutoSize = True
        rbtCenter.Location = New Point(107, 41)
        rbtCenter.Name = "rbtCenter"
        rbtCenter.Size = New Size(73, 35)
        rbtCenter.TabIndex = 1
        rbtCenter.TabStop = True
        rbtCenter.Text = "Center"
        rbtCenter.UseVisualStyleBackColor = True
        ' 
        ' rbtLeft
        ' 
        rbtLeft.Appearance = Appearance.Button
        rbtLeft.AutoSize = True
        rbtLeft.Location = New Point(50, 41)
        rbtLeft.Name = "rbtLeft"
        rbtLeft.Size = New Size(51, 35)
        rbtLeft.TabIndex = 0
        rbtLeft.TabStop = True
        rbtLeft.Text = "Left"
        rbtLeft.UseVisualStyleBackColor = True
        ' 
        ' txtDemo
        ' 
        txtDemo.Location = New Point(117, 281)
        txtDemo.Name = "txtDemo"
        txtDemo.Size = New Size(150, 31)
        txtDemo.TabIndex = 3
        ' 
        ' frmFormat
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(573, 468)
        Controls.Add(txtDemo)
        Controls.Add(grpAlignment)
        Name = "frmFormat"
        Text = "Format"
        grpAlignment.ResumeLayout(False)
        grpAlignment.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents grpAlignment As GroupBox
    Friend WithEvents rbtRight As RadioButton
    Friend WithEvents rbtCenter As RadioButton
    Friend WithEvents rbtLeft As RadioButton
    Friend WithEvents txtDemo As TextBox
End Class
