<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPercentage
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
        lblFirst = New Label()
        lblSecond = New Label()
        lblThird = New Label()
        lblFourth = New Label()
        lblFifth = New Label()
        lblResult = New Label()
        txtFirst = New TextBox()
        txtSecond = New TextBox()
        txtThird = New TextBox()
        txtFourth = New TextBox()
        txtFifth = New TextBox()
        txtResult = New TextBox()
        btnCalculate = New Button()
        btnReset = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(44, 25)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(201, 25)
        lblFirst.TabIndex = 0
        lblFirst.Text = "Enter 1st Subject Marks:"
        ' 
        ' lblSecond
        ' 
        lblSecond.AutoSize = True
        lblSecond.Location = New Point(44, 75)
        lblSecond.Name = "lblSecond"
        lblSecond.Size = New Size(208, 25)
        lblSecond.TabIndex = 1
        lblSecond.Text = "Enter 2nd Subject Marks:"
        ' 
        ' lblThird
        ' 
        lblThird.AutoSize = True
        lblThird.Location = New Point(44, 129)
        lblThird.Name = "lblThird"
        lblThird.Size = New Size(204, 25)
        lblThird.TabIndex = 2
        lblThird.Text = "Enter 3rd Subject Marks:"
        ' 
        ' lblFourth
        ' 
        lblFourth.AutoSize = True
        lblFourth.Location = New Point(44, 186)
        lblFourth.Name = "lblFourth"
        lblFourth.Size = New Size(203, 25)
        lblFourth.TabIndex = 3
        lblFourth.Text = "Enter 4th Subject Marks:"
        ' 
        ' lblFifth
        ' 
        lblFifth.AutoSize = True
        lblFifth.Location = New Point(44, 240)
        lblFifth.Name = "lblFifth"
        lblFifth.Size = New Size(203, 25)
        lblFifth.TabIndex = 4
        lblFifth.Text = "Enter 5th Subject Marks:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(44, 295)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(63, 25)
        lblResult.TabIndex = 5
        lblResult.Text = "Result:"
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(292, 19)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(150, 31)
        txtFirst.TabIndex = 6
        ' 
        ' txtSecond
        ' 
        txtSecond.Location = New Point(292, 69)
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(150, 31)
        txtSecond.TabIndex = 7
        ' 
        ' txtThird
        ' 
        txtThird.Location = New Point(292, 123)
        txtThird.Name = "txtThird"
        txtThird.Size = New Size(150, 31)
        txtThird.TabIndex = 8
        ' 
        ' txtFourth
        ' 
        txtFourth.Location = New Point(292, 180)
        txtFourth.Name = "txtFourth"
        txtFourth.Size = New Size(150, 31)
        txtFourth.TabIndex = 9
        ' 
        ' txtFifth
        ' 
        txtFifth.Location = New Point(292, 234)
        txtFifth.Name = "txtFifth"
        txtFifth.Size = New Size(150, 31)
        txtFifth.TabIndex = 10
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(292, 289)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(150, 31)
        txtResult.TabIndex = 11
        ' 
        ' btnCalculate
        ' 
        btnCalculate.Location = New Point(44, 352)
        btnCalculate.Name = "btnCalculate"
        btnCalculate.Size = New Size(120, 65)
        btnCalculate.TabIndex = 12
        btnCalculate.Text = "Calculate"
        btnCalculate.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(193, 352)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(118, 65)
        btnReset.TabIndex = 13
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(342, 352)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(113, 65)
        btnExit.TabIndex = 14
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' frmPercentage
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(498, 432)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnCalculate)
        Controls.Add(txtResult)
        Controls.Add(txtFifth)
        Controls.Add(txtFourth)
        Controls.Add(txtThird)
        Controls.Add(txtSecond)
        Controls.Add(txtFirst)
        Controls.Add(lblResult)
        Controls.Add(lblFifth)
        Controls.Add(lblFourth)
        Controls.Add(lblThird)
        Controls.Add(lblSecond)
        Controls.Add(lblFirst)
        Name = "frmPercentage"
        Text = "Calculate Percentage"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblThird As Label
    Friend WithEvents lblFourth As Label
    Friend WithEvents lblFifth As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtThird As TextBox
    Friend WithEvents txtFourth As TextBox
    Friend WithEvents txtFifth As TextBox
    Friend WithEvents txtResult As TextBox
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
End Class
