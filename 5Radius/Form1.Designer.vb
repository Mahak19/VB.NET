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
        btnExit = New Button()
        btnArea = New Button()
        lblRadius = New Label()
        txtRadius = New TextBox()
        SuspendLayout()
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(214, 128)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(112, 62)
        btnExit.TabIndex = 0
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' btnArea
        ' 
        btnArea.Location = New Point(49, 128)
        btnArea.Name = "btnArea"
        btnArea.Size = New Size(113, 62)
        btnArea.TabIndex = 1
        btnArea.Text = "Area"
        btnArea.UseVisualStyleBackColor = True
        ' 
        ' lblRadius
        ' 
        lblRadius.AutoSize = True
        lblRadius.Location = New Point(48, 55)
        lblRadius.Name = "lblRadius"
        lblRadius.Size = New Size(114, 25)
        lblRadius.TabIndex = 2
        lblRadius.Text = "Enter Radius:"
        ' 
        ' txtRadius
        ' 
        txtRadius.Location = New Point(176, 49)
        txtRadius.Name = "txtRadius"
        txtRadius.Size = New Size(150, 31)
        txtRadius.TabIndex = 3
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(359, 211)
        Controls.Add(txtRadius)
        Controls.Add(lblRadius)
        Controls.Add(btnArea)
        Controls.Add(btnExit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnExit As Button
    Friend WithEvents btnArea As Button
    Friend WithEvents lblRadius As Label
    Friend WithEvents txtRadius As TextBox
End Class
