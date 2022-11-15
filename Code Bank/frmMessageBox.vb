Public Class frmMessageBox
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub btnSimple_Click(sender As Object, e As EventArgs) Handles btnSimple.Click
        MsgBox("Hello World")
    End Sub

    Private Sub btnPresCheck_Click(sender As Object, e As EventArgs) Handles btnPresCheck.Click
        If txtPresent.Text = "" Then
            MsgBox("Please enter a value in the textbox")
        Else
            MsgBox("You entered: " & txtPresent.Text)
        End If
    End Sub

    Private Sub btnVariable_Click(sender As Object, e As EventArgs) Handles btnVariable.Click
        Dim varName As String
        varName = txtName.Text
        MsgBox("Hello " & varName)
    End Sub

    Private Sub btnNumCheck_Click(sender As Object, e As EventArgs) Handles btnNumCheck.Click
        If (IsNumeric(txtNum.Text)) Then
            MsgBox("You entered a number: " & txtNum.Text, , txtNum.Text)
        Else
            MsgBox("That's not a number!")
        End If
    End Sub

    Private Sub btnInteractive_Click(sender As Object, e As EventArgs) Handles btnInteractive.Click
        Dim choice As String

        choice = MsgBox("Choose Yes or No", MsgBoxStyle.YesNoCancel)

        If choice = vbYes Then
            MsgBox("You chose Yes")
        End If
        If choice = vbNo Then
            MsgBox("You chose No")
        End If
    End Sub

    Private Sub btnDateCheck_Click(sender As Object, e As EventArgs) Handles btnDateCheck.Click
        Dim checkDate As String
        checkDate = txtDate.Text
        If (IsDate(checkDate)) Then
            MsgBox("You entered a date")
        Else
            MsgBox("Not a valid date")
        End If
    End Sub
End Class