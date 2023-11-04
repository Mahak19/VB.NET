Public Class frmCalculator
    Dim first As Decimal
    Dim second As Decimal
    Dim operation As String
    Dim op As Boolean = False
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "0"
        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "1"
        Else
            txtResult.Text = "1"
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "2"
        Else
            txtResult.Text = "2"
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "3"
        Else
            txtResult.Text = "3"
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "4"
        Else
            txtResult.Text = "4"
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "5"
        Else
            txtResult.Text = "5"
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "6"
        Else
            txtResult.Text = "6"
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "7"
        Else
            txtResult.Text = "7"
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "8"
        Else
            txtResult.Text = "8"
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If txtResult.Text <> "0" Then
            txtResult.Text = txtResult.Text + "9"
        Else
            txtResult.Text = "9"
        End If
    End Sub

    Private Sub btnC_Click(sender As Object, e As EventArgs) Handles btnC.Click
        txtResult.Text = ""
    End Sub

    Private Sub btnBackspace_Click(sender As Object, e As EventArgs) Handles btnBackspace.Click
        If txtResult.Text.Length > 0 Then
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1, 1)
        Else
            If txtResult.Text = "" Then
                txtResult.Text = 0
            End If
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        first = Val(txtResult.Text)
        txtResult.Text = ""
        op = True
        operation = "+"
    End Sub

    Private Sub btnSub_Click(sender As Object, e As EventArgs) Handles btnSub.Click
        first = Val(txtResult.Text)
        txtResult.Text = ""
        op = True
        operation = "-"
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        first = Val(txtResult.Text)
        txtResult.Text = ""
        op = True
        operation = "*"
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        first = Val(txtResult.Text)
        txtResult.Text = ""
        op = True
        operation = "/"
    End Sub

    Private Sub btnModule_Click(sender As Object, e As EventArgs) Handles btnModule.Click
        first = Val(txtResult.Text)
        txtResult.Text = ""
        op = True
        operation = "%"
    End Sub

    Private Sub btnEqual_Click(sender As Object, e As EventArgs) Handles btnEqual.Click
        If op = True Then
            second = Val(txtResult.Text)
            If operation = "+" Then
                txtResult.Text = first + second
            ElseIf operation = "-" Then
                txtResult.Text = first - second
            ElseIf operation = "/" Then
                If second = 0 Then
                    txtResult.Text = "Can't Divide by zero"
                Else
                    txtResult.Text = first / second
                End If
            ElseIf operation = "*" Then
                txtResult.Text = first * second
            ElseIf operation = "%" Then
                txtResult.Text = first Mod second
            End If
        End If
    End Sub

    Private Sub btnDot_Click(sender As Object, e As EventArgs) Handles btnDot.Click
        If Not (txtResult.Text.Contains(".")) Then
            txtResult.Text = txtResult.Text + "."
        End If
    End Sub

    Private Sub btnSqrt_Click(sender As Object, e As EventArgs) Handles btnSqrt.Click
        first = Val(txtResult.Text)
        txtResult.Text = Math.Sqrt(first)
    End Sub
End Class
