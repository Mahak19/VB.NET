<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCalculator
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
        txtResult = New TextBox()
        btn7 = New Button()
        btn8 = New Button()
        btn9 = New Button()
        btnC = New Button()
        btnBackspace = New Button()
        btn4 = New Button()
        btn5 = New Button()
        btn6 = New Button()
        btnAdd = New Button()
        btnSub = New Button()
        btn1 = New Button()
        btn2 = New Button()
        btn3 = New Button()
        btnSqrt = New Button()
        btnModule = New Button()
        btn0 = New Button()
        btnDot = New Button()
        btnEqual = New Button()
        btnDivide = New Button()
        btnMultiply = New Button()
        SuspendLayout()
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(12, 12)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(353, 31)
        txtResult.TabIndex = 0
        ' 
        ' btn7
        ' 
        btn7.Location = New Point(13, 49)
        btn7.Name = "btn7"
        btn7.Size = New Size(66, 62)
        btn7.TabIndex = 1
        btn7.Text = "7"
        btn7.UseVisualStyleBackColor = True
        ' 
        ' btn8
        ' 
        btn8.Location = New Point(85, 49)
        btn8.Name = "btn8"
        btn8.Size = New Size(65, 62)
        btn8.TabIndex = 2
        btn8.Text = "8"
        btn8.UseVisualStyleBackColor = True
        ' 
        ' btn9
        ' 
        btn9.Location = New Point(152, 49)
        btn9.Name = "btn9"
        btn9.Size = New Size(67, 62)
        btn9.TabIndex = 3
        btn9.Text = "9"
        btn9.UseVisualStyleBackColor = True
        ' 
        ' btnC
        ' 
        btnC.Location = New Point(225, 49)
        btnC.Name = "btnC"
        btnC.Size = New Size(67, 62)
        btnC.TabIndex = 4
        btnC.Text = "C"
        btnC.UseVisualStyleBackColor = True
        ' 
        ' btnBackspace
        ' 
        btnBackspace.Location = New Point(298, 49)
        btnBackspace.Name = "btnBackspace"
        btnBackspace.Size = New Size(67, 62)
        btnBackspace.TabIndex = 5
        btnBackspace.Text = "<-"
        btnBackspace.UseVisualStyleBackColor = True
        ' 
        ' btn4
        ' 
        btn4.Location = New Point(12, 117)
        btn4.Name = "btn4"
        btn4.Size = New Size(67, 58)
        btn4.TabIndex = 6
        btn4.Text = "4"
        btn4.UseVisualStyleBackColor = True
        ' 
        ' btn5
        ' 
        btn5.Location = New Point(85, 117)
        btn5.Name = "btn5"
        btn5.Size = New Size(65, 58)
        btn5.TabIndex = 7
        btn5.Text = "5"
        btn5.UseVisualStyleBackColor = True
        ' 
        ' btn6
        ' 
        btn6.Location = New Point(156, 117)
        btn6.Name = "btn6"
        btn6.Size = New Size(63, 58)
        btn6.TabIndex = 8
        btn6.Text = "6"
        btn6.UseVisualStyleBackColor = True
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(225, 117)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(67, 58)
        btnAdd.TabIndex = 9
        btnAdd.Text = "+"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSub
        ' 
        btnSub.Location = New Point(298, 117)
        btnSub.Name = "btnSub"
        btnSub.Size = New Size(67, 58)
        btnSub.TabIndex = 10
        btnSub.Text = "-"
        btnSub.UseVisualStyleBackColor = True
        ' 
        ' btn1
        ' 
        btn1.Location = New Point(13, 181)
        btn1.Name = "btn1"
        btn1.Size = New Size(66, 60)
        btn1.TabIndex = 11
        btn1.Text = "1"
        btn1.UseVisualStyleBackColor = True
        ' 
        ' btn2
        ' 
        btn2.Location = New Point(85, 181)
        btn2.Name = "btn2"
        btn2.Size = New Size(65, 60)
        btn2.TabIndex = 12
        btn2.Text = "2"
        btn2.UseVisualStyleBackColor = True
        ' 
        ' btn3
        ' 
        btn3.Location = New Point(156, 181)
        btn3.Name = "btn3"
        btn3.Size = New Size(63, 60)
        btn3.TabIndex = 13
        btn3.Text = "3"
        btn3.UseVisualStyleBackColor = True
        ' 
        ' btnSqrt
        ' 
        btnSqrt.Location = New Point(225, 181)
        btnSqrt.Name = "btnSqrt"
        btnSqrt.Size = New Size(67, 60)
        btnSqrt.TabIndex = 14
        btnSqrt.Text = "SQRT"
        btnSqrt.UseVisualStyleBackColor = True
        ' 
        ' btnModule
        ' 
        btnModule.Location = New Point(298, 181)
        btnModule.Name = "btnModule"
        btnModule.Size = New Size(67, 60)
        btnModule.TabIndex = 15
        btnModule.Text = "%"
        btnModule.UseVisualStyleBackColor = True
        ' 
        ' btn0
        ' 
        btn0.Location = New Point(13, 246)
        btn0.Name = "btn0"
        btn0.Size = New Size(66, 62)
        btn0.TabIndex = 16
        btn0.Text = "0"
        btn0.UseVisualStyleBackColor = True
        ' 
        ' btnDot
        ' 
        btnDot.Location = New Point(85, 247)
        btnDot.Name = "btnDot"
        btnDot.Size = New Size(65, 62)
        btnDot.TabIndex = 17
        btnDot.Text = "."
        btnDot.UseVisualStyleBackColor = True
        ' 
        ' btnEqual
        ' 
        btnEqual.Location = New Point(156, 247)
        btnEqual.Name = "btnEqual"
        btnEqual.Size = New Size(63, 62)
        btnEqual.TabIndex = 18
        btnEqual.Text = "="
        btnEqual.UseVisualStyleBackColor = True
        ' 
        ' btnDivide
        ' 
        btnDivide.Location = New Point(225, 247)
        btnDivide.Name = "btnDivide"
        btnDivide.Size = New Size(67, 62)
        btnDivide.TabIndex = 19
        btnDivide.Text = "/"
        btnDivide.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(298, 247)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(67, 62)
        btnMultiply.TabIndex = 20
        btnMultiply.Text = "*"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' frmCalculator
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(374, 363)
        Controls.Add(btnMultiply)
        Controls.Add(btnDivide)
        Controls.Add(btnEqual)
        Controls.Add(btnDot)
        Controls.Add(btn0)
        Controls.Add(btnModule)
        Controls.Add(btnSqrt)
        Controls.Add(btn3)
        Controls.Add(btn2)
        Controls.Add(btn1)
        Controls.Add(btnSub)
        Controls.Add(btnAdd)
        Controls.Add(btn6)
        Controls.Add(btn5)
        Controls.Add(btn4)
        Controls.Add(btnBackspace)
        Controls.Add(btnC)
        Controls.Add(btn9)
        Controls.Add(btn8)
        Controls.Add(btn7)
        Controls.Add(txtResult)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmCalculator"
        Text = "Calculator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtResult As TextBox
    Friend WithEvents btn7 As Button
    Friend WithEvents btn8 As Button
    Friend WithEvents btn9 As Button
    Friend WithEvents btnC As Button
    Friend WithEvents btnBackspace As Button
    Friend WithEvents btn4 As Button
    Friend WithEvents btn5 As Button
    Friend WithEvents btn6 As Button
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSub As Button
    Friend WithEvents btn1 As Button
    Friend WithEvents btn2 As Button
    Friend WithEvents btn3 As Button
    Friend WithEvents btnSqrt As Button
    Friend WithEvents btnModule As Button
    Friend WithEvents btn0 As Button
    Friend WithEvents btnDot As Button
    Friend WithEvents btnEqual As Button
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnMultiply As Button
End Class
