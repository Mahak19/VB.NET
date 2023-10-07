<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmArithmetic
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
        lblResult = New Label()
        btnAdd = New Button()
        btnSubtract = New Button()
        btnMultiply = New Button()
        btnIntegerDivision = New Button()
        btnFloatDivision = New Button()
        btnModulation = New Button()
        btnReset = New Button()
        btnExit = New Button()
        txtFirst = New TextBox()
        txtSecond = New TextBox()
        txtResult = New TextBox()
        SuspendLayout()
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(123, 52)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(155, 25)
        lblFirst.TabIndex = 0
        lblFirst.Text = "Enter 1st Number:"
        ' 
        ' lblSecond
        ' 
        lblSecond.AutoSize = True
        lblSecond.Location = New Point(123, 114)
        lblSecond.Name = "lblSecond"
        lblSecond.Size = New Size(162, 25)
        lblSecond.TabIndex = 1
        lblSecond.Text = "Enter 2nd Number:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(123, 195)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(63, 25)
        lblResult.TabIndex = 2
        lblResult.Text = "Result:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(12, 277)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(138, 76)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnSubtract
        ' 
        btnSubtract.Location = New Point(156, 277)
        btnSubtract.Name = "btnSubtract"
        btnSubtract.Size = New Size(123, 76)
        btnSubtract.TabIndex = 4
        btnSubtract.Text = "Subtract"
        btnSubtract.UseVisualStyleBackColor = True
        ' 
        ' btnMultiply
        ' 
        btnMultiply.Location = New Point(285, 277)
        btnMultiply.Name = "btnMultiply"
        btnMultiply.Size = New Size(127, 76)
        btnMultiply.TabIndex = 5
        btnMultiply.Text = "Multiply"
        btnMultiply.UseVisualStyleBackColor = True
        ' 
        ' btnIntegerDivision
        ' 
        btnIntegerDivision.Location = New Point(418, 277)
        btnIntegerDivision.Name = "btnIntegerDivision"
        btnIntegerDivision.Size = New Size(115, 76)
        btnIntegerDivision.TabIndex = 6
        btnIntegerDivision.Text = "Integer Division"
        btnIntegerDivision.UseVisualStyleBackColor = True
        ' 
        ' btnFloatDivision
        ' 
        btnFloatDivision.Location = New Point(539, 277)
        btnFloatDivision.Name = "btnFloatDivision"
        btnFloatDivision.Size = New Size(121, 76)
        btnFloatDivision.TabIndex = 7
        btnFloatDivision.Text = "Float Division"
        btnFloatDivision.UseVisualStyleBackColor = True
        ' 
        ' btnModulation
        ' 
        btnModulation.Location = New Point(666, 277)
        btnModulation.Name = "btnModulation"
        btnModulation.Size = New Size(122, 76)
        btnModulation.TabIndex = 8
        btnModulation.Text = "Modulation"
        btnModulation.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(477, 371)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(116, 57)
        btnReset.TabIndex = 9
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(619, 371)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(116, 57)
        btnExit.TabIndex = 10
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(399, 46)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(150, 31)
        txtFirst.TabIndex = 11
        ' 
        ' txtSecond
        ' 
        txtSecond.Location = New Point(399, 108)
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(150, 31)
        txtSecond.TabIndex = 12
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(399, 189)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(150, 31)
        txtResult.TabIndex = 13
        ' 
        ' frmArithmetic
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(799, 443)
        Controls.Add(txtResult)
        Controls.Add(txtSecond)
        Controls.Add(txtFirst)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnModulation)
        Controls.Add(btnFloatDivision)
        Controls.Add(btnIntegerDivision)
        Controls.Add(btnMultiply)
        Controls.Add(btnSubtract)
        Controls.Add(btnAdd)
        Controls.Add(lblResult)
        Controls.Add(lblSecond)
        Controls.Add(lblFirst)
        Name = "frmArithmetic"
        Text = "Arithmetic Operator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents btnIntegerDivision As Button
    Friend WithEvents btnFloatDivision As Button
    Friend WithEvents btnModulation As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtFirst As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtResult As TextBox
End Class
