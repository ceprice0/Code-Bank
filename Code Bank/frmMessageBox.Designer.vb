<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMessageBox
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
        Me.btnSimple = New System.Windows.Forms.Button()
        Me.btnVariable = New System.Windows.Forms.Button()
        Me.btnInteractive = New System.Windows.Forms.Button()
        Me.btnPresCheck = New System.Windows.Forms.Button()
        Me.btnNumCheck = New System.Windows.Forms.Button()
        Me.btnDateCheck = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPresent = New System.Windows.Forms.TextBox()
        Me.txtNum = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnSimple
        '
        Me.btnSimple.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSimple.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnSimple.Location = New System.Drawing.Point(12, 66)
        Me.btnSimple.Name = "btnSimple"
        Me.btnSimple.Size = New System.Drawing.Size(160, 96)
        Me.btnSimple.TabIndex = 0
        Me.btnSimple.Text = "Simple Msg Box"
        Me.btnSimple.UseVisualStyleBackColor = False
        '
        'btnVariable
        '
        Me.btnVariable.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnVariable.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnVariable.Location = New System.Drawing.Point(12, 219)
        Me.btnVariable.Name = "btnVariable"
        Me.btnVariable.Size = New System.Drawing.Size(160, 45)
        Me.btnVariable.TabIndex = 1
        Me.btnVariable.Text = "Variable Msg Box"
        Me.btnVariable.UseVisualStyleBackColor = False
        '
        'btnInteractive
        '
        Me.btnInteractive.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnInteractive.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnInteractive.Location = New System.Drawing.Point(12, 270)
        Me.btnInteractive.Name = "btnInteractive"
        Me.btnInteractive.Size = New System.Drawing.Size(160, 96)
        Me.btnInteractive.TabIndex = 2
        Me.btnInteractive.Text = "Interactive Msg Box"
        Me.btnInteractive.UseVisualStyleBackColor = False
        '
        'btnPresCheck
        '
        Me.btnPresCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnPresCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnPresCheck.Location = New System.Drawing.Point(178, 95)
        Me.btnPresCheck.Name = "btnPresCheck"
        Me.btnPresCheck.Size = New System.Drawing.Size(160, 67)
        Me.btnPresCheck.TabIndex = 3
        Me.btnPresCheck.Text = "Presence Check Validation"
        Me.btnPresCheck.UseVisualStyleBackColor = False
        '
        'btnNumCheck
        '
        Me.btnNumCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnNumCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnNumCheck.Location = New System.Drawing.Point(178, 197)
        Me.btnNumCheck.Name = "btnNumCheck"
        Me.btnNumCheck.Size = New System.Drawing.Size(160, 67)
        Me.btnNumCheck.TabIndex = 4
        Me.btnNumCheck.Text = "Number Check Validation"
        Me.btnNumCheck.UseVisualStyleBackColor = False
        '
        'btnDateCheck
        '
        Me.btnDateCheck.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnDateCheck.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnDateCheck.Location = New System.Drawing.Point(178, 298)
        Me.btnDateCheck.Name = "btnDateCheck"
        Me.btnDateCheck.Size = New System.Drawing.Size(160, 68)
        Me.btnDateCheck.TabIndex = 5
        Me.btnDateCheck.Text = "Data Check Validation"
        Me.btnDateCheck.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(12, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(317, 30)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Message Box Examples"
        '
        'txtPresent
        '
        Me.txtPresent.Location = New System.Drawing.Point(178, 66)
        Me.txtPresent.Name = "txtPresent"
        Me.txtPresent.Size = New System.Drawing.Size(160, 23)
        Me.txtPresent.TabIndex = 7
        '
        'txtNum
        '
        Me.txtNum.Location = New System.Drawing.Point(178, 168)
        Me.txtNum.Name = "txtNum"
        Me.txtNum.Size = New System.Drawing.Size(160, 23)
        Me.txtNum.TabIndex = 8
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(178, 270)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(160, 23)
        Me.txtDate.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(12, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Enter Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(12, 194)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(160, 23)
        Me.txtName.TabIndex = 11
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.btnBack.Location = New System.Drawing.Point(12, 372)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(104, 36)
        Me.btnBack.TabIndex = 12
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmMessageBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(351, 408)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtNum)
        Me.Controls.Add(Me.txtPresent)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDateCheck)
        Me.Controls.Add(Me.btnNumCheck)
        Me.Controls.Add(Me.btnPresCheck)
        Me.Controls.Add(Me.btnInteractive)
        Me.Controls.Add(Me.btnVariable)
        Me.Controls.Add(Me.btnSimple)
        Me.Name = "frmMessageBox"
        Me.Text = "frmMessageBox"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnSimple As Button
    Friend WithEvents btnVariable As Button
    Friend WithEvents btnInteractive As Button
    Friend WithEvents btnPresCheck As Button
    Friend WithEvents btnNumCheck As Button
    Friend WithEvents btnDateCheck As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtPresent As TextBox
    Friend WithEvents txtNum As TextBox
    Friend WithEvents txtDate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnBack As Button
End Class
