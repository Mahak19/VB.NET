Public Class frmSalaryCalculator
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim Basic, DA, HRA, Gross As Double
        If txtName.Text = "" Then
            MsgBox("Please Enter Name")
            txtName.Focus()
        ElseIf txtAge.Text = "" Then
            MsgBox("Please Enter Age")
            txtAge.Focus()
        ElseIf txtBasic.Text = "" Then
            MsgBox("Please Enter Basic Salary")
            txtBasic.Focus()
        Else
            Basic = Val(txtBasic.Text)
            DA = Basic * 0.8
            HRA = (Basic + DA) * 0.12
            Gross = Basic + DA + HRA
            txtGross.Text = Gross
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        txtGross.Text = ""
        txtBasic.Text = ""
        txtAge.Text = ""
        txtName.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
