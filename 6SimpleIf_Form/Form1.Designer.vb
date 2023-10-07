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
        btnCheck = New Button()
        btnExit = New Button()
        Label1 = New Label()
        txtNumber = New TextBox()
        lblNumber = New Label()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(64, 92)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(116, 61)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(223, 92)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(117, 61)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(16, 16)
        Label1.Name = "Label1"
        Label1.Size = New Size(0, 25)
        Label1.TabIndex = 2
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(211, 33)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(150, 31)
        txtNumber.TabIndex = 3
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Location = New Point(40, 39)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(140, 25)
        lblNumber.TabIndex = 4
        lblNumber.Text = "Enter a Number:"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 182)
        Controls.Add(lblNumber)
        Controls.Add(txtNumber)
        Controls.Add(Label1)
        Controls.Add(btnExit)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtNumber As TextBox
    Friend WithEvents lblNumber As Label
End Class
