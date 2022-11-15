Imports System.DirectoryServices
Imports System.Net.Http.Headers
Imports Microsoft.VisualBasic.Devices

Public Class frmChallenge

    Dim playerScore As Integer
    Dim computerScore As Integer


    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        picboxPaper.Enabled = True
        picboxPaper.Visible = True
        picboxRock.Enabled = True
        picboxRock.Visible = True
        picboxScissors.Enabled = True
        picboxScissors.Visible = True
    End Sub

    Private Sub picboxScissors_Click(sender As Object, e As EventArgs) Handles picboxScissors.Click

        rockPaperScissors(1)

    End Sub

    Private Sub picboxRock_Click(sender As Object, e As EventArgs) Handles picboxRock.Click

        rockPaperScissors(2)

    End Sub

    Private Sub picboxPaper_Click(sender As Object, e As EventArgs) Handles picboxPaper.Click

        rockPaperScissors(3)

    End Sub


    Private Sub rockPaperScissors(user As Integer)
        Dim rng As New Random
        Dim computer As Integer = rng.Next(1, 3)

        Dim winner As Integer = determineResult(user, computer)

        If winner = 2 Then
            playerScore = playerScore + 1
        ElseIf winner = 3 Then
            computerScore = computerScore + 1
        End If

        lblScore.Text = playerScore
        lblScore1.Text = computerScore

        resultMessage(winner, user, computer)

    End Sub

    Private Function determineResult(userchoice As Integer, computer As Integer) As Integer

        '1=draw / 2=user wins / 3=computer wins
        Dim result As Integer
        result = 3

        If userchoice = computer Then
            result = 1

        ElseIf userchoice = 1 Then
            If computer = 3 Then
                result = 2
            End If

        ElseIf userchoice = 2 Then
            If computer = 1 Then
                result = 2
            End If

        ElseIf userchoice = 3 Then
            If computer = 2 Then
                result = 2
            End If
        End If

        Return result

    End Function


    Private Sub resultMessage(result As Integer, user As Integer, computer As Integer)

        Dim drawMessage As String
        Dim userWinsMessage As String
        Dim computerWinsMessage As String

        drawMessage = "It's a draw. "
        userWinsMessage = "You won! "
        computerWinsMessage = "Computer won! "

        Dim userChoice As String = numberToChoice(user)
        Dim computerChoice As String = numberToChoice(computer)
        Dim message = "You chose " & userChoice & ". Computer chose " & computerChoice

        If result = 1 Then
            MsgBox(drawMessage & message)
        ElseIf result = 2 Then
            MsgBox(userWinsMessage & message)
        ElseIf result = 3 Then
            MsgBox(computerWinsMessage & message)
        End If

    End Sub



    Private Function choiceToNumber(choice As String) As Integer
        Dim result As Integer

        result = 0

        If LCase(choice) = "scissors" Then
            result = 1
        ElseIf LCase(choice) = "rock" Then
            result = 2
        ElseIf LCase(choice) = "paper" Then
            result = 3
        End If

        Return result

    End Function

    Private Function numberToChoice(choice As Integer) As String
        Dim result As String

        If choice = 1 Then
            result = "scissors"
        ElseIf choice = 2 Then
            result = "rock"
        ElseIf choice = 3 Then
            result = "paper"
        End If

        Return result

    End Function


    Private Sub frmChallenge_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub
End Class