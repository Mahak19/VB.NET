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
        Label1 = New Label()
        Button1 = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.FlatStyle = FlatStyle.Popup
        Label1.Image = My.Resources.Resources.friesMain
        Label1.Location = New Point(310, 106)
        Label1.Name = "Label1"
        Label1.Size = New Size(63, 25)
        Label1.TabIndex = 0
        Label1.Text = "Label1"
        ' 
        ' Button1
        ' 
        Button1.Image = My.Resources.Resources.donut2
        Button1.Location = New Point(57, 37)
        Button1.Name = "Button1"
        Button1.Size = New Size(209, 149)
        Button1.TabIndex = 1
        Button1.Text = "Login"
        Button1.TextImageRelation = TextImageRelation.TextBeforeImage
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(451, 198)
        Controls.Add(Button1)
        Controls.Add(Label1)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
