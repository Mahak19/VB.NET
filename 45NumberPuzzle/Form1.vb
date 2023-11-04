Public Class frmNumberPuzzle
    Private Sub frmNumberPuzzle_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn1.Text = 2
        btn2.Text = 4
        btn3.Text = 1
        btn4.Text = 3
        btn5.Text = 6
        btn6.Text = 5
        btn7.Text = 9
        btn8.Text = 7
        btn9.Text = ""
        btn10.Text = 15
        btn11.Text = 14
        btn12.Text = 11
        btn13.Text = 10
        btn14.Text = 12
        btn15.Text = 8
        btn16.Text = 13
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        If btn2.Text = "" Then
            btn2.Text = btn1.Text
            btn1.Text = ""
        End If
        If btn5.Text = "" Then
            btn5.Text = btn1.Text
            btn1.Text = ""
        End If
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        If btn1.Text = "" Then
            btn1.Text = btn2.Text
            btn2.Text = ""
        End If
        If btn3.Text = "" Then
            btn3.Text = btn2.Text
            btn2.Text = ""
        End If
        If btn6.Text = "" Then
            btn6.Text = btn2.Text
            btn2.Text = ""
        End If
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        If btn2.Text = "" Then
            btn2.Text = btn3.Text
            btn3.Text = ""
        End If
        If btn4.Text = "" Then
            btn4.Text = btn3.Text
            btn3.Text = ""
        End If
        If btn7.Text = "" Then
            btn7.Text = btn3.Text
            btn3.Text = ""
        End If
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        If btn3.Text = "" Then
            btn3.Text = btn4.Text
            btn4.Text = ""
        End If
        If btn8.Text = "" Then
            btn8.Text = btn4.Text
            btn4.Text = ""
        End If
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        If btn1.Text = "" Then
            btn1.Text = btn5.Text
            btn5.Text = ""
        End If
        If btn6.Text = "" Then
            btn6.Text = btn5.Text
            btn5.Text = ""
        End If
        If btn9.Text = "" Then
            btn9.Text = btn5.Text
            btn5.Text = ""
        End If
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        If btn2.Text = "" Then
            btn2.Text = btn6.Text
            btn6.Text = ""
        End If
        If btn5.Text = "" Then
            btn5.Text = btn6.Text
            btn6.Text = ""
        End If
        If btn7.Text = "" Then
            btn7.Text = btn6.Text
            btn6.Text = ""
        End If
        If btn10.Text = "" Then
            btn10.Text = btn6.Text
            btn6.Text = ""
        End If
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        If btn3.Text = "" Then
            btn3.Text = btn7.Text
            btn7.Text = ""
        End If
        If btn6.Text = "" Then
            btn6.Text = btn7.Text
            btn7.Text = ""
        End If
        If btn8.Text = "" Then
            btn8.Text = btn7.Text
            btn7.Text = ""
        End If
        If btn11.Text = "" Then
            btn11.Text = btn7.Text
            btn7.Text = ""
        End If
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        If btn4.Text = "" Then
            btn4.Text = btn8.Text
            btn8.Text = ""
        End If
        If btn7.Text = "" Then
            btn7.Text = btn8.Text
            btn8.Text = ""
        End If
        If btn12.Text = "" Then
            btn12.Text = btn8.Text
            btn8.Text = ""
        End If
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        If btn5.Text = "" Then
            btn5.Text = btn9.Text
            btn9.Text = ""
        End If
        If btn10.Text = "" Then
            btn10.Text = btn9.Text
            btn9.Text = ""
        End If
        If btn13.Text = "" Then
            btn13.Text = btn9.Text
            btn9.Text = ""
        End If
    End Sub

    Private Sub btn10_Click(sender As Object, e As EventArgs) Handles btn10.Click
        If btn6.Text = "" Then
            btn6.Text = btn10.Text
            btn10.Text = ""
        End If
        If btn9.Text = "" Then
            btn9.Text = btn10.Text
            btn10.Text = ""
        End If
        If btn11.Text = "" Then
            btn11.Text = btn10.Text
            btn10.Text = ""
        End If
        If btn14.Text = "" Then
            btn14.Text = btn10.Text
            btn10.Text = ""
        End If
    End Sub

    Private Sub btn11_Click(sender As Object, e As EventArgs) Handles btn11.Click
        If btn7.Text = "" Then
            btn7.Text = btn11.Text
            btn11.Text = ""
        End If
        If btn10.Text = "" Then
            btn10.Text = btn11.Text
            btn11.Text = ""
        End If
        If btn12.Text = "" Then
            btn12.Text = btn11.Text
            btn11.Text = ""
        End If
        If btn15.Text = "" Then
            btn15.Text = btn11.Text
            btn11.Text = ""
        End If
    End Sub

    Private Sub btn12_Click(sender As Object, e As EventArgs) Handles btn12.Click
        If btn8.Text = "" Then
            btn8.Text = btn12.Text
            btn12.Text = ""
        End If
        If btn11.Text = "" Then
            btn11.Text = btn12.Text
            btn12.Text = ""
        End If
        If btn16.Text = "" Then
            btn16.Text = btn12.Text
            btn12.Text = ""
        End If
    End Sub

    Private Sub btn13_Click(sender As Object, e As EventArgs) Handles btn13.Click
        If btn9.Text = "" Then
            btn9.Text = btn13.Text
            btn13.Text = ""
        End If
        If btn14.Text = "" Then
            btn14.Text = btn13.Text
            btn13.Text = ""
        End If
    End Sub

    Private Sub btn14_Click(sender As Object, e As EventArgs) Handles btn14.Click
        If btn10.Text = "" Then
            btn10.Text = btn14.Text
            btn14.Text = ""
        End If
        If btn15.Text = "" Then
            btn15.Text = btn14.Text
            btn14.Text = ""
        End If
    End Sub

    Private Sub btn15_Click(sender As Object, e As EventArgs) Handles btn15.Click
        If btn14.Text = "" Then
            btn14.Text = btn15.Text
            btn15.Text = ""
        End If
        If btn16.Text = "" Then
            btn16.Text = btn15.Text
            btn15.Text = ""
        End If
        If btn11.Text = "" Then
            btn11.Text = btn15.Text
            btn15.Text = ""
        End If
    End Sub

    Private Sub btn16_Click(sender As Object, e As EventArgs) Handles btn16.Click
        If btn12.Text = "" Then
            btn12.Text = btn16.Text
            btn16.Text = ""
        End If
        If btn15.Text = "" Then
            btn15.Text = btn16.Text
            btn16.Text = ""
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        btn1.Text = 2
        btn2.Text = 4
        btn3.Text = 1
        btn4.Text = 3
        btn5.Text = 6
        btn6.Text = 5
        btn7.Text = 9
        btn8.Text = 7
        btn9.Text = ""
        btn10.Text = 15
        btn11.Text = 14
        btn12.Text = 11
        btn13.Text = 10
        btn14.Text = 12
        btn15.Text = 8
        btn16.Text = 13
    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If btn1.Text = "1" And btn2.Text = "2" And btn3.Text = "3" And btn4.Text = "4" And btn5.Text = "5" And btn6.Text = "6" And btn7.Text = "7" And btn8.Text = "8" And btn9.Text = "9" And btn10.Text = "10" And btn11.Text = "11" And btn12.Text = "12" And btn13.Text = "13" And btn14.Text = "14" And btn15.Text = "15" And btn16.Text = "" Then
        Else
            MsgBox("Done")
        End If
    End Sub
End Class
