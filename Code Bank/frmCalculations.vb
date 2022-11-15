Public Class frmCalculations
    Dim number1 As Decimal
    Dim number2 As Decimal
    Dim answer As Decimal
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If (IsNumeric(txtNum1.Text)) And (IsNumeric(txtNum2.Text)) Then
            number1 = txtNum1.Text
            number2 = txtNum2.Text
            answer = number1 + number2
            lblAnswer.Text = answer
        Else
            MsgBox("Please enter two numbers", , "Error")
        End If
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        If (IsNumeric(txtNum1.Text)) And (IsNumeric(txtNum2.Text)) Then
            number1 = txtNum1.Text
            number2 = txtNum2.Text
            answer = number1 - number2
            lblAnswer.Text = answer
        Else
            MsgBox("Please enter two numbers", , "Error")
        End If
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If (IsNumeric(txtNum1.Text)) And (IsNumeric(txtNum2.Text)) Then
            number1 = txtNum1.Text
            number2 = txtNum2.Text
            answer = number1 * number2
            lblAnswer.Text = answer
        Else
            MsgBox("Please enter two numbers", , "Error")
        End If
    End Sub
End Class