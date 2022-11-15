Public Class Form3
    Dim multiplier As Integer
    Dim answer As Integer
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        If (IsNumeric(txtTimesTable.Text)) Then

            lstAnswers.Items.Clear()

            multiplier = txtTimesTable.Text
            For i = 1 To 12
                answer = i * multiplier
                lstAnswers.Items.Add(i & " Times " & multiplier & " = " & answer)

            Next

        Else
            MsgBox("That's not a number!")
        End If
    End Sub
End Class