<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmName
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
        lblName = New Label()
        btnOk = New Button()
        btnCancel = New Button()
        txtName = New TextBox()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(19, 37)
        lblName.Name = "lblName"
        lblName.Size = New Size(149, 25)
        lblName.TabIndex = 0
        lblName.Text = "Enter your Name:"
        ' 
        ' btnOk
        ' 
        btnOk.Location = New Point(45, 105)
        btnOk.Name = "btnOk"
        btnOk.Size = New Size(108, 58)
        btnOk.TabIndex = 1
        btnOk.Text = "Ok"
        btnOk.UseVisualStyleBackColor = True
        ' 
        ' btnCancel
        ' 
        btnCancel.Location = New Point(194, 105)
        btnCancel.Name = "btnCancel"
        btnCancel.Size = New Size(110, 58)
        btnCancel.TabIndex = 2
        btnCancel.Text = "Cancel"
        btnCancel.UseVisualStyleBackColor = True
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(174, 31)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 3
        ' 
        ' frmName
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(353, 193)
        Controls.Add(txtName)
        Controls.Add(btnCancel)
        Controls.Add(btnOk)
        Controls.Add(lblName)
        Name = "frmName"
        Text = "Name Form"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents btnOk As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents txtName As TextBox
End Class
