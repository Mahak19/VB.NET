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
        lblNumber = New Label()
        txtNumber = New TextBox()
        SuspendLayout()
        ' 
        ' btnCheck
        ' 
        btnCheck.Location = New Point(50, 115)
        btnCheck.Name = "btnCheck"
        btnCheck.Size = New Size(112, 60)
        btnCheck.TabIndex = 0
        btnCheck.Text = "Check"
        btnCheck.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(222, 115)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(111, 60)
        btnExit.TabIndex = 1
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' lblNumber
        ' 
        lblNumber.AutoSize = True
        lblNumber.Location = New Point(60, 56)
        lblNumber.Name = "lblNumber"
        lblNumber.Size = New Size(126, 25)
        lblNumber.TabIndex = 2
        lblNumber.Text = "Enter Number:"
        ' 
        ' txtNumber
        ' 
        txtNumber.Location = New Point(196, 50)
        txtNumber.Name = "txtNumber"
        txtNumber.Size = New Size(150, 31)
        txtNumber.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(388, 206)
        Controls.Add(txtNumber)
        Controls.Add(lblNumber)
        Controls.Add(btnExit)
        Controls.Add(btnCheck)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCheck As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents lblNumber As Label
    Friend WithEvents txtNumber As TextBox
End Class
