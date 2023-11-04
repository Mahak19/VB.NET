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
        components = New ComponentModel.Container()
        Timer1 = New Timer(components)
        ColorDialog1 = New ColorDialog()
        lblCounter = New Label()
        Timer2 = New Timer(components)
        SuspendLayout()
        ' 
        ' Timer1
        ' 
        Timer1.Enabled = True
        Timer1.Interval = 2000
        ' 
        ' lblCounter
        ' 
        lblCounter.AutoSize = True
        lblCounter.Font = New Font("Tempus Sans ITC", 22F, FontStyle.Regular, GraphicsUnit.Point)
        lblCounter.Location = New Point(125, 79)
        lblCounter.Name = "lblCounter"
        lblCounter.Size = New Size(71, 57)
        lblCounter.TabIndex = 0
        lblCounter.Text = "10"
        ' 
        ' Timer2
        ' 
        Timer2.Enabled = True
        Timer2.Interval = 1000
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(350, 208)
        Controls.Add(lblCounter)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Timer1 As Timer
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents lblCounter As Label
    Friend WithEvents Timer2 As Timer
End Class
