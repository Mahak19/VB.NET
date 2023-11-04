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
        CheckBox1 = New CheckBox()
        txtPassword = New TextBox()
        chkPassword = New CheckBox()
        SuspendLayout()
        ' 
        ' CheckBox1
        ' 
        CheckBox1.Appearance = Appearance.Button
        CheckBox1.AutoSize = True
        CheckBox1.CheckAlign = ContentAlignment.TopCenter
        CheckBox1.Checked = True
        CheckBox1.CheckState = CheckState.Checked
        CheckBox1.Location = New Point(131, 41)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(68, 35)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Green"
        CheckBox1.ThreeState = True
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' txtPassword
        ' 
        txtPassword.Location = New Point(51, 121)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(150, 31)
        txtPassword.TabIndex = 1
        ' 
        ' chkPassword
        ' 
        chkPassword.AutoSize = True
        chkPassword.Location = New Point(243, 127)
        chkPassword.Name = "chkPassword"
        chkPassword.Size = New Size(22, 21)
        chkPassword.TabIndex = 2
        chkPassword.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(378, 198)
        Controls.Add(chkPassword)
        Controls.Add(txtPassword)
        Controls.Add(CheckBox1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents chkPassword As CheckBox
End Class
