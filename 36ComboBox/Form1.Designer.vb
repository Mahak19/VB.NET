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
        cmbColor = New ComboBox()
        btnEnter = New Button()
        SuspendLayout()
        ' 
        ' cmbColor
        ' 
        cmbColor.BackColor = Color.LemonChiffon
        cmbColor.DropDownHeight = 550
        cmbColor.Font = New Font("Script MT Bold", 11F, FontStyle.Bold, GraphicsUnit.Point)
        cmbColor.ForeColor = Color.Navy
        cmbColor.FormattingEnabled = True
        cmbColor.IntegralHeight = False
        cmbColor.Items.AddRange(New Object() {"Blue", "Yellow", "Red", "Violet", "Orange", "Tomato"})
        cmbColor.Location = New Point(57, 40)
        cmbColor.MaxDropDownItems = 3
        cmbColor.MaxLength = 6
        cmbColor.Name = "cmbColor"
        cmbColor.Size = New Size(180, 35)
        cmbColor.TabIndex = 3
        ' 
        ' btnEnter
        ' 
        btnEnter.Location = New Point(333, 40)
        btnEnter.Name = "btnEnter"
        btnEnter.Size = New Size(134, 211)
        btnEnter.TabIndex = 0
        btnEnter.Text = "Enter"
        btnEnter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(554, 277)
        Controls.Add(btnEnter)
        Controls.Add(cmbColor)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
    End Sub

    Friend WithEvents cmbColor As ComboBox
    Friend WithEvents btnEnter As Button
End Class
