<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnMessageBoxes = New System.Windows.Forms.Button()
        Me.btnControl = New System.Windows.Forms.Button()
        Me.btnCalculation = New System.Windows.Forms.Button()
        Me.btnDoLoops = New System.Windows.Forms.Button()
        Me.btnForLoops = New System.Windows.Forms.Button()
        Me.btnChallenge = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnMessageBoxes
        '
        Me.btnMessageBoxes.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnMessageBoxes.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnMessageBoxes.Location = New System.Drawing.Point(50, 76)
        Me.btnMessageBoxes.Name = "btnMessageBoxes"
        Me.btnMessageBoxes.Size = New System.Drawing.Size(136, 119)
        Me.btnMessageBoxes.TabIndex = 0
        Me.btnMessageBoxes.Text = "Message Boxes and Validation"
        Me.btnMessageBoxes.UseVisualStyleBackColor = False
        '
        'btnControl
        '
        Me.btnControl.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnControl.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnControl.Location = New System.Drawing.Point(224, 76)
        Me.btnControl.Name = "btnControl"
        Me.btnControl.Size = New System.Drawing.Size(136, 119)
        Me.btnControl.TabIndex = 1
        Me.btnControl.Text = "Controls and Variables"
        Me.btnControl.UseVisualStyleBackColor = False
        '
        'btnCalculation
        '
        Me.btnCalculation.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnCalculation.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnCalculation.Location = New System.Drawing.Point(391, 76)
        Me.btnCalculation.Name = "btnCalculation"
        Me.btnCalculation.Size = New System.Drawing.Size(136, 119)
        Me.btnCalculation.TabIndex = 2
        Me.btnCalculation.Text = "Calculations"
        Me.btnCalculation.UseVisualStyleBackColor = False
        '
        'btnDoLoops
        '
        Me.btnDoLoops.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDoLoops.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDoLoops.Location = New System.Drawing.Point(50, 221)
        Me.btnDoLoops.Name = "btnDoLoops"
        Me.btnDoLoops.Size = New System.Drawing.Size(136, 119)
        Me.btnDoLoops.TabIndex = 3
        Me.btnDoLoops.Text = "Do Until Loops"
        Me.btnDoLoops.UseVisualStyleBackColor = False
        '
        'btnForLoops
        '
        Me.btnForLoops.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnForLoops.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnForLoops.Location = New System.Drawing.Point(224, 221)
        Me.btnForLoops.Name = "btnForLoops"
        Me.btnForLoops.Size = New System.Drawing.Size(136, 119)
        Me.btnForLoops.TabIndex = 4
        Me.btnForLoops.Text = "For Loops"
        Me.btnForLoops.UseVisualStyleBackColor = False
        '
        'btnChallenge
        '
        Me.btnChallenge.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChallenge.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnChallenge.Location = New System.Drawing.Point(391, 221)
        Me.btnChallenge.Name = "btnChallenge"
        Me.btnChallenge.Size = New System.Drawing.Size(136, 119)
        Me.btnChallenge.TabIndex = 5
        Me.btnChallenge.Text = "Challenge"
        Me.btnChallenge.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(150, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 27)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Code Bank - VB Training"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 371)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnChallenge)
        Me.Controls.Add(Me.btnForLoops)
        Me.Controls.Add(Me.btnDoLoops)
        Me.Controls.Add(Me.btnCalculation)
        Me.Controls.Add(Me.btnControl)
        Me.Controls.Add(Me.btnMessageBoxes)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnMessageBoxes As Button
    Friend WithEvents btnControl As Button
    Friend WithEvents btnCalculation As Button
    Friend WithEvents btnDoLoops As Button
    Friend WithEvents btnForLoops As Button
    Friend WithEvents btnChallenge As Button
    Friend WithEvents Label1 As Label
End Class
