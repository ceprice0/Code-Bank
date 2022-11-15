Public Class Form1
    Private Sub btnMessageBoxes_Click(sender As Object, e As EventArgs) Handles btnMessageBoxes.Click
        Me.Hide()
        frmMessageBox.Show()

    End Sub

    Private Sub btnControl_Click(sender As Object, e As EventArgs) Handles btnControl.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub btnDoLoops_Click(sender As Object, e As EventArgs) Handles btnDoLoops.Click
        Me.Hide()
        frmDoUntil.Show()
    End Sub

    Private Sub btnCalculation_Click(sender As Object, e As EventArgs) Handles btnCalculation.Click
        Me.Hide()
        frmCalculations.Show()
    End Sub

    Private Sub btnForLoops_Click(sender As Object, e As EventArgs) Handles btnForLoops.Click
        Me.Hide()
        Form3.Show()
    End Sub

    Private Sub btnChallenge_Click(sender As Object, e As EventArgs) Handles btnChallenge.Click
        Me.Hide()
        frmChallenge.Show()
    End Sub
End Class
