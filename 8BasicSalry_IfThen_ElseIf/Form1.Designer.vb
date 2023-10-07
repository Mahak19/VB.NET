<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSalaryCalculator
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
        lblAge = New Label()
        lblBasic = New Label()
        lblGross = New Label()
        txtName = New TextBox()
        txtAge = New TextBox()
        txtBasic = New TextBox()
        txtGross = New TextBox()
        btnCalculate = New Button()
        btnReset = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblName
        ' 
        lblName.AutoSize = True
        lblName.Location = New Point(70, 47)
        lblName.Name = "lblName"
        lblName.Size = New Size(108, 25)
        lblName.TabIndex = 0
        lblName.Text = "Enter Name:"
        ' 
        ' lblAge
        ' 
        lblAge.AutoSize = True
        lblAge.Location = New Point(70, 86)
        lblAge.Name = "lblAge"
        lblAge.Size = New Size(93, 25)
        lblAge.TabIndex = 1
        lblAge.Text = "Enter Age:"
        ' 
        ' lblBasic
        ' 
        lblBasic.AutoSize = True
        lblBasic.Location = New Point(70, 127)
        lblBasic.Name = "lblBasic"
        lblBasic.Size = New Size(152, 25)
        lblBasic.TabIndex = 2
        lblBasic.Text = "Enter Basic Salary:"
        ' 
        ' lblGross
        ' 
        lblGross.AutoSize = True
        lblGross.Location = New Point(70, 170)
        lblGross.Name = "lblGross"
        lblGross.Size = New Size(113, 25)
        lblGross.TabIndex = 3
        lblGross.Text = "Gross Salary:"
        ' 
        ' txtName
        ' 
        txtName.Location = New Point(273, 41)
        txtName.Name = "txtName"
        txtName.Size = New Size(150, 31)
        txtName.TabIndex = 4
        ' 
        ' txtAge
        ' 
        txtAge.Location = New Point(273, 80)
        txtAge.Name = "txtAge"
        txtAge.Size = New Size(150, 31)
        txtAge.TabIndex = 5
        ' 
        ' txtBasic
        ' 
        txtBasic.Location = New Point(273, 121)
        txtBasic.Name = "txtBasic"
        txtBasic.Size = New Size(150, 31)
        txtBasic.TabIndex = 6
        ' 
        ' txtGross
        ' 
        txtGross.Location = New Point(273, 164)
        txtGross.Name = "txtGross"
        txtGross.Size = New Size(150, 31)
        txtGross.TabIndex = 7
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(39, 224)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(119, 65)
        btnCalculate.TabIndex = 8
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(178, 224)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(122, 65)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(326, 224)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(125, 65)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmSalaryCalculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(481, 315)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnCalculate)
        Controls.Add(txtGross)
        Controls.Add(txtBasic)
        Controls.Add(txtAge)
        Controls.Add(txtName)
        Controls.Add(lblGross)
        Controls.Add(lblBasic)
        Controls.Add(lblAge)
        Controls.Add(lblName)
        Name = "frmSalaryCalculator"
        Text = "Salary Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents lblAge As Label
    Friend WithEvents lblBasic As Label
    Friend WithEvents lblGross As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtBasic As TextBox
    Friend WithEvents txtGross As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
