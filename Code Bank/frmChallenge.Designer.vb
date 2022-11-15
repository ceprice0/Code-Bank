<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChallenge
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbRPS = New System.Windows.Forms.GroupBox()
        Me.lblChoice = New System.Windows.Forms.Label()
        Me.lblPlayerChoice = New System.Windows.Forms.Label()
        Me.picboxScissors = New System.Windows.Forms.PictureBox()
        Me.picboxPaper = New System.Windows.Forms.PictureBox()
        Me.picboxRock = New System.Windows.Forms.PictureBox()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbRPS.SuspendLayout()
        CType(Me.picboxScissors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxPaper, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picboxRock, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbRPS
        '
        Me.gbRPS.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.gbRPS.Controls.Add(Me.lblChoice)
        Me.gbRPS.Controls.Add(Me.lblPlayerChoice)
        Me.gbRPS.Controls.Add(Me.picboxScissors)
        Me.gbRPS.Controls.Add(Me.picboxPaper)
        Me.gbRPS.Controls.Add(Me.picboxRock)
        Me.gbRPS.Controls.Add(Me.lblScore1)
        Me.gbRPS.Controls.Add(Me.lblScore)
        Me.gbRPS.Controls.Add(Me.Label3)
        Me.gbRPS.Controls.Add(Me.Label2)
        Me.gbRPS.Controls.Add(Me.btnStart)
        Me.gbRPS.Controls.Add(Me.Label1)
        Me.gbRPS.Location = New System.Drawing.Point(55, 32)
        Me.gbRPS.Name = "gbRPS"
        Me.gbRPS.Size = New System.Drawing.Size(372, 292)
        Me.gbRPS.TabIndex = 0
        Me.gbRPS.TabStop = False
        Me.gbRPS.Text = "Rock, Paper, Scissors"
        '
        'lblChoice
        '
        Me.lblChoice.AutoSize = True
        Me.lblChoice.Location = New System.Drawing.Point(159, 259)
        Me.lblChoice.Name = "lblChoice"
        Me.lblChoice.Size = New System.Drawing.Size(41, 15)
        Me.lblChoice.TabIndex = 10
        Me.lblChoice.Text = "Label4"
        '
        'lblPlayerChoice
        '
        Me.lblPlayerChoice.AutoSize = True
        Me.lblPlayerChoice.Location = New System.Drawing.Point(184, 259)
        Me.lblPlayerChoice.Name = "lblPlayerChoice"
        Me.lblPlayerChoice.Size = New System.Drawing.Size(0, 15)
        Me.lblPlayerChoice.TabIndex = 9
        '
        'picboxScissors
        '
        Me.picboxScissors.Enabled = False
        Me.picboxScissors.Image = Global.Code_Bank.My.Resources.Resources.Standard_household_scissors
        Me.picboxScissors.Location = New System.Drawing.Point(241, 159)
        Me.picboxScissors.Name = "picboxScissors"
        Me.picboxScissors.Size = New System.Drawing.Size(100, 79)
        Me.picboxScissors.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxScissors.TabIndex = 8
        Me.picboxScissors.TabStop = False
        Me.picboxScissors.Visible = False
        '
        'picboxPaper
        '
        Me.picboxPaper.Enabled = False
        Me.picboxPaper.Image = Global.Code_Bank.My.Resources.Resources.paper_111691001
        Me.picboxPaper.Location = New System.Drawing.Point(136, 159)
        Me.picboxPaper.Name = "picboxPaper"
        Me.picboxPaper.Size = New System.Drawing.Size(100, 79)
        Me.picboxPaper.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxPaper.TabIndex = 7
        Me.picboxPaper.TabStop = False
        Me.picboxPaper.Visible = False
        '
        'picboxRock
        '
        Me.picboxRock.Enabled = False
        Me.picboxRock.Image = Global.Code_Bank.My.Resources.Resources.National_Pet_Rock_Day_640x514
        Me.picboxRock.Location = New System.Drawing.Point(46, 159)
        Me.picboxRock.Name = "picboxRock"
        Me.picboxRock.Size = New System.Drawing.Size(100, 79)
        Me.picboxRock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picboxRock.TabIndex = 6
        Me.picboxRock.TabStop = False
        Me.picboxRock.Visible = False
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblScore1.Location = New System.Drawing.Point(279, 110)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(31, 33)
        Me.lblScore1.TabIndex = 5
        Me.lblScore1.Text = "0"
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblScore.Location = New System.Drawing.Point(61, 110)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(31, 33)
        Me.lblScore.TabIndex = 4
        Me.lblScore.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(258, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(79, 17)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CPU Score"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(29, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Your Score"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnStart.ForeColor = System.Drawing.Color.Black
        Me.btnStart.Location = New System.Drawing.Point(136, 94)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(95, 49)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(94, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(192, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Rounds Remaining"
        '
        'frmChallenge
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(477, 353)
        Me.Controls.Add(Me.gbRPS)
        Me.Name = "frmChallenge"
        Me.Text = "frmChallenge"
        Me.gbRPS.ResumeLayout(False)
        Me.gbRPS.PerformLayout()
        CType(Me.picboxScissors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxPaper, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picboxRock, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents gbRPS As GroupBox
    Friend WithEvents picboxScissors As PictureBox
    Friend WithEvents picboxPaper As PictureBox
    Friend WithEvents picboxRock As PictureBox
    Friend WithEvents lblScore1 As Label
    Friend WithEvents lblScore As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents lblPlayerChoice As Label
    Friend WithEvents lblChoice As Label
End Class
