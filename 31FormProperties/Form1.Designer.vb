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
        TextBox1 = New TextBox()
        btnNormal = New Button()
        btnUpper = New Button()
        btnLower = New Button()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' TextBox1
        ' 
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black
        TextBox1.Location = New Point(535, 155)
        TextBox1.MaxLength = 3000
        TextBox1.MinimumSize = New Size(3, 3)
        TextBox1.Multiline = True
        TextBox1.Name = "TextBox1"
        TextBox1.ScrollBars = ScrollBars.Both
        TextBox1.Size = New Size(177, 86)
        TextBox1.TabIndex = 0
        TextBox1.WordWrap = False
        ' 
        ' btnNormal
        ' 
        btnNormal.ForeColor = Color.Blue
        btnNormal.Location = New Point(133, 51)
        btnNormal.Name = "btnNormal"
        btnNormal.Size = New Size(112, 34)
        btnNormal.TabIndex = 2
        btnNormal.Text = "Normal"
        btnNormal.UseVisualStyleBackColor = True
        ' 
        ' btnUpper
        ' 
        btnUpper.Location = New Point(133, 111)
        btnUpper.Name = "btnUpper"
        btnUpper.Size = New Size(112, 34)
        btnUpper.TabIndex = 3
        btnUpper.Text = "Upper"
        btnUpper.UseVisualStyleBackColor = True
        ' 
        ' btnLower
        ' 
        btnLower.Location = New Point(133, 171)
        btnLower.Name = "btnLower"
        btnLower.Size = New Size(112, 34)
        btnLower.TabIndex = 4
        btnLower.Text = "Lower"
        btnLower.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Location = New Point(290, 277)
        Button1.Name = "Button1"
        Button1.Size = New Size(112, 34)
        Button1.TabIndex = 5
        Button1.Text = "Button1"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        ClientSize = New Size(800, 450)
        Controls.Add(Button1)
        Controls.Add(btnLower)
        Controls.Add(btnUpper)
        Controls.Add(btnNormal)
        Controls.Add(TextBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnNormal As Button
    Friend WithEvents btnUpper As Button
    Friend WithEvents btnLower As Button
    Friend WithEvents Button1 As Button
End Class
