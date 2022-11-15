Public Class frmDoUntil
    Dim varNum As Integer
    Dim varTens As Integer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        varNum = txtNumber.Text
        varTens = 0

        Do Until varNum < 10
            varTens = varTens + 1
            varNum = varNum - 10
        Loop

        lblAnswer.Text = varTens
    End Sub
End Class