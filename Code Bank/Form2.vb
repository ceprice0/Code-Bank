Public Class Form2
    Public varGlobal As String


    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles lblText.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
        If txtGlobal.Text <> "" Then
            txtGlobal.Clear()

        End If
    End Sub

    Private Sub btnColour_Click(sender As Object, e As EventArgs) Handles btnColour.Click
        If rdoGreen.Checked = True Then
            Me.BackColor = Color.Green
        ElseIf rdoAqua.Checked = True Then
            Me.BackColor = Color.Aqua
        ElseIf rdoOrange.Checked = True Then
            Me.BackColor = Color.Orange
        ElseIf rdoPurple.Checked = True Then
            Me.BackColor = Color.Purple
        ElseIf rdoYellow.Checked = True Then
            Me.BackColor = Color.Yellow

        End If
    End Sub

    Private Sub btnCheckBox_Click(sender As Object, e As EventArgs) Handles btnCheckBox.Click
        If chkCheck1.Checked = True And chkCheck2.Checked = False Then
            MsgBox("You Chose Option 1")

        ElseIf chkCheck1.Checked = False And chkCheck2.Checked = True Then
            MsgBox("You Chose Option 2")

        ElseIf chkCheck1.Checked = True And chkCheck2.Checked = True Then
            MsgBox("You Chose Both Options!")

        ElseIf chkCheck1.Checked = False And chkCheck2.Checked = False Then
            MsgBox("No Option Selected")

        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btnDate.Click
        Dim strDate As String

        strDate = dateTimePicker.Value

        MsgBox("You have selected " & strDate)
    End Sub

    Private Sub btnLocal_Click(sender As Object, e As EventArgs) Handles btnLocal.Click
        Dim varLocal As String
        varLocal = txtLocal.Text
        MsgBox(varLocal & " is a Local Variable that is only available to this subroutine.")
    End Sub

    Private Sub btnGlobal_Click(sender As Object, e As EventArgs) Handles btnGlobal.Click
        varGlobal = txtGlobal.Text

        Me.Hide()
        frmGlobal.Show()

    End Sub

    Private Sub txtLocal_TextChanged(sender As Object, e As EventArgs)
        If txtLocal.Text <> "" Then
            txtLocal.Clear()

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        Form1.Show()

    End Sub

    Private Sub btnSmaller_Click(sender As Object, e As EventArgs) Handles btnSmaller.Click
        lblText.Font = New Font(lblText.Font.FontFamily, lblText.Font.Size - 1, lblText.Font.Style)
    End Sub

    Private Sub btnBigger_Click(sender As Object, e As EventArgs) Handles btnBigger.Click
        lblText.Font = New Font(lblText.Font.FontFamily, lblText.Font.Size + 1, lblText.Font.Style)
    End Sub

    Private Sub btnBold_Click(sender As Object, e As EventArgs) Handles btnBold.Click
        If Me.lblText.Font.Bold Then
            lblText.Font = New Font(lblText.Font, FontStyle.Regular)
        Else
            lblText.Font = New Font(lblText.Font, FontStyle.Bold)
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtLocal.TextChanged

    End Sub

    Private Sub txtGlobal_TextChanged(sender As Object, e As EventArgs) Handles txtGlobal.TextChanged

    End Sub
End Class