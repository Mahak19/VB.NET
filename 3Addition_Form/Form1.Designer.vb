<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAddition
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
        btnReset = New Button()
        btnExit = New Button()
        txtResult = New TextBox()
        txtSecond = New TextBox()
        txtFirst = New TextBox()
        SuspendLayout()
        ' 
        ' lblFirst
        ' 
        lblFirst.AutoSize = True
        lblFirst.Location = New Point(35, 37)
        lblFirst.Name = "lblFirst"
        lblFirst.Size = New Size(155, 25)
        lblFirst.TabIndex = 0
        lblFirst.Text = "Enter 1st Number:"
        ' 
        ' lblSecond
        ' 
        lblSecond.AutoSize = True
        lblSecond.Location = New Point(35, 87)
        lblSecond.Name = "lblSecond"
        lblSecond.Size = New Size(162, 25)
        lblSecond.TabIndex = 1
        lblSecond.Text = "Enter 2nd Number:"
        ' 
        ' lblResult
        ' 
        lblResult.AutoSize = True
        lblResult.Location = New Point(35, 156)
        lblResult.Name = "lblResult"
        lblResult.Size = New Size(63, 25)
        lblResult.TabIndex = 2
        lblResult.Text = "Result:"
        ' 
        ' btnAdd
        ' 
        btnAdd.Location = New Point(23, 221)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(102, 62)
        btnAdd.TabIndex = 3
        btnAdd.Text = "Add"
        btnAdd.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(145, 221)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(102, 62)
        btnReset.TabIndex = 4
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.Location = New Point(272, 221)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(106, 62)
        btnExit.TabIndex = 5
        btnExit.Text = "Exit"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' txtResult
        ' 
        txtResult.Location = New Point(223, 150)
        txtResult.Name = "txtResult"
        txtResult.Size = New Size(150, 31)
        txtResult.TabIndex = 6
        ' 
        ' txtSecond
        ' 
        txtSecond.Location = New Point(223, 81)
        txtSecond.Name = "txtSecond"
        txtSecond.Size = New Size(150, 31)
        txtSecond.TabIndex = 7
        ' 
        ' txtFirst
        ' 
        txtFirst.Location = New Point(223, 31)
        txtFirst.Name = "txtFirst"
        txtFirst.Size = New Size(150, 31)
        txtFirst.TabIndex = 8
        ' 
        ' frmAddition
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(397, 314)
        Controls.Add(txtFirst)
        Controls.Add(txtSecond)
        Controls.Add(txtResult)
        Controls.Add(btnExit)
        Controls.Add(btnReset)
        Controls.Add(btnAdd)
        Controls.Add(lblResult)
        Controls.Add(lblSecond)
        Controls.Add(lblFirst)
        Name = "frmAddition"
        Text = "Addition"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblFirst As Label
    Friend WithEvents lblSecond As Label
    Friend WithEvents lblResult As Label
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtResult As TextBox
    Friend WithEvents txtSecond As TextBox
    Friend WithEvents txtFirst As TextBox
End Class
