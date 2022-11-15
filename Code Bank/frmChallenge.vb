Public Class frmChallenge
    Dim rng As New Random
    Dim comp As String
    Dim playerscore As Integer
    Dim compScore As Integer



    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        picboxPaper.Enabled = True
        picboxPaper.Visible = True
        picboxRock.Enabled = True
        picboxRock.Visible = True
        picboxScissors.Enabled = True
        picboxScissors.Visible = True
    End Sub

    Private Sub picboxRock_Click(sender As Object, e As EventArgs) Handles picboxRock.Click
        lblChoice.Text = "You Chose Rock"
        comp = rng.Next(3)
        If comp = "1" Then
            comp = "Rock"
            MsgBox("Computer chose rock. Draw")
        End If
        If comp = "2" Then
            comp = "Paper"
            MsgBox("Computer chose paper. Lose")
            compScore = compScore + 1
            lblScore1.Text = compScore
        End If
        If comp = "3" Then
            comp = "Scissors"
            MsgBox("Computer chose scissors. Win")
            playerscore = playerscore + 1
            lblScore.Text = playerscore
        End If
    End Sub

    Private Sub picboxPaper_Click(sender As Object, e As EventArgs) Handles picboxPaper.Click
        lblChoice.Text = "You Chose Paper"
        comp = rng.Next(3)
        If comp = "1" Then
            comp = "Rock"
            MsgBox("Computer chose rock. You Win")
            playerscore = playerscore + 1
            lblScore.Text = playerscore
        End If
        If comp = "2" Then
            comp = "Paper"
            MsgBox("Computer chose paper. Draw")
        End If
        If comp = "3" Then
            comp = "Scissors"
            MsgBox("Computer chose scissors. Lose")
            compScore = compScore + 1
            lblScore1.Text = compScore
        End If
    End Sub

    Private Sub picboxScissors_Click(sender As Object, e As EventArgs) Handles picboxScissors.Click
        lblChoice.Text = "You Chose Scissors"
        comp = rng.Next(3)
        If comp = "1" Then
            comp = "Rock"
            MsgBox("Computer chose rock. Lose")
            compScore = compScore + 1
            lblScore1.Text = compScore
        End If
        If comp = "2" Then
            comp = "Paper"
            MsgBox("Computer chose paper. Win")
            playerscore = playerscore + 1
            lblScore.Text = playerscore
        End If
        If comp = "3" Then
            comp = "Scissors"
            MsgBox("Computer chose scissors. Draw")
        End If
    End Sub

    Private Sub frmChallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class