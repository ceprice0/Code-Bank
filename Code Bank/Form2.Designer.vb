<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.chkCheck2 = New System.Windows.Forms.CheckBox()
        Me.chkCheck1 = New System.Windows.Forms.CheckBox()
        Me.btnCheckBox = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.btnDate = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdoPurple = New System.Windows.Forms.RadioButton()
        Me.rdoYellow = New System.Windows.Forms.RadioButton()
        Me.rdoOrange = New System.Windows.Forms.RadioButton()
        Me.rdoAqua = New System.Windows.Forms.RadioButton()
        Me.rdoGreen = New System.Windows.Forms.RadioButton()
        Me.btnColour = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.txtLocal = New System.Windows.Forms.TextBox()
        Me.txtGlobal = New System.Windows.Forms.TextBox()
        Me.btnLocal = New System.Windows.Forms.Button()
        Me.btnGlobal = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.btnSmaller = New System.Windows.Forms.Button()
        Me.btnBigger = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.btnBold = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(140, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Controls and Variables"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.chkCheck2)
        Me.GroupBox1.Controls.Add(Me.chkCheck1)
        Me.GroupBox1.Controls.Add(Me.btnCheckBox)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 73)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(181, 93)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CheckBoxControl"
        '
        'chkCheck2
        '
        Me.chkCheck2.AutoSize = True
        Me.chkCheck2.Location = New System.Drawing.Point(5, 50)
        Me.chkCheck2.Name = "chkCheck2"
        Me.chkCheck2.Size = New System.Drawing.Size(72, 19)
        Me.chkCheck2.TabIndex = 2
        Me.chkCheck2.Text = "Option 2"
        Me.chkCheck2.UseVisualStyleBackColor = True
        '
        'chkCheck1
        '
        Me.chkCheck1.AutoSize = True
        Me.chkCheck1.Location = New System.Drawing.Point(5, 28)
        Me.chkCheck1.Name = "chkCheck1"
        Me.chkCheck1.Size = New System.Drawing.Size(72, 19)
        Me.chkCheck1.TabIndex = 1
        Me.chkCheck1.Text = "Option 1"
        Me.chkCheck1.UseVisualStyleBackColor = True
        '
        'btnCheckBox
        '
        Me.btnCheckBox.Location = New System.Drawing.Point(93, 22)
        Me.btnCheckBox.Name = "btnCheckBox"
        Me.btnCheckBox.Size = New System.Drawing.Size(69, 56)
        Me.btnCheckBox.TabIndex = 0
        Me.btnCheckBox.Text = "Click Here"
        Me.btnCheckBox.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox2.Controls.Add(Me.dateTimePicker)
        Me.GroupBox2.Controls.Add(Me.btnDate)
        Me.GroupBox2.Location = New System.Drawing.Point(25, 201)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(237, 93)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Pick a Date"
        '
        'dateTimePicker
        '
        Me.dateTimePicker.Location = New System.Drawing.Point(6, 16)
        Me.dateTimePicker.Name = "dateTimePicker"
        Me.dateTimePicker.Size = New System.Drawing.Size(200, 23)
        Me.dateTimePicker.TabIndex = 1
        '
        'btnDate
        '
        Me.btnDate.Location = New System.Drawing.Point(186, 45)
        Me.btnDate.Name = "btnDate"
        Me.btnDate.Size = New System.Drawing.Size(45, 43)
        Me.btnDate.TabIndex = 0
        Me.btnDate.Text = "Go"
        Me.btnDate.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox3.Controls.Add(Me.rdoPurple)
        Me.GroupBox3.Controls.Add(Me.rdoYellow)
        Me.GroupBox3.Controls.Add(Me.rdoOrange)
        Me.GroupBox3.Controls.Add(Me.rdoAqua)
        Me.GroupBox3.Controls.Add(Me.rdoGreen)
        Me.GroupBox3.Controls.Add(Me.btnColour)
        Me.GroupBox3.Location = New System.Drawing.Point(231, 73)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(266, 93)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Pick a Colour"
        '
        'rdoPurple
        '
        Me.rdoPurple.AutoSize = True
        Me.rdoPurple.Location = New System.Drawing.Point(110, 44)
        Me.rdoPurple.Name = "rdoPurple"
        Me.rdoPurple.Size = New System.Drawing.Size(59, 19)
        Me.rdoPurple.TabIndex = 6
        Me.rdoPurple.TabStop = True
        Me.rdoPurple.Text = "Purple"
        Me.rdoPurple.UseVisualStyleBackColor = True
        '
        'rdoYellow
        '
        Me.rdoYellow.AutoSize = True
        Me.rdoYellow.Location = New System.Drawing.Point(110, 22)
        Me.rdoYellow.Name = "rdoYellow"
        Me.rdoYellow.Size = New System.Drawing.Size(59, 19)
        Me.rdoYellow.TabIndex = 5
        Me.rdoYellow.TabStop = True
        Me.rdoYellow.Text = "Yellow"
        Me.rdoYellow.UseVisualStyleBackColor = True
        '
        'rdoOrange
        '
        Me.rdoOrange.AutoSize = True
        Me.rdoOrange.Location = New System.Drawing.Point(6, 69)
        Me.rdoOrange.Name = "rdoOrange"
        Me.rdoOrange.Size = New System.Drawing.Size(64, 19)
        Me.rdoOrange.TabIndex = 4
        Me.rdoOrange.TabStop = True
        Me.rdoOrange.Text = "Orange"
        Me.rdoOrange.UseVisualStyleBackColor = True
        '
        'rdoAqua
        '
        Me.rdoAqua.AutoSize = True
        Me.rdoAqua.Location = New System.Drawing.Point(7, 44)
        Me.rdoAqua.Name = "rdoAqua"
        Me.rdoAqua.Size = New System.Drawing.Size(53, 19)
        Me.rdoAqua.TabIndex = 3
        Me.rdoAqua.TabStop = True
        Me.rdoAqua.Text = "Aqua"
        Me.rdoAqua.UseVisualStyleBackColor = True
        '
        'rdoGreen
        '
        Me.rdoGreen.AutoSize = True
        Me.rdoGreen.Location = New System.Drawing.Point(6, 22)
        Me.rdoGreen.Name = "rdoGreen"
        Me.rdoGreen.Size = New System.Drawing.Size(56, 19)
        Me.rdoGreen.TabIndex = 2
        Me.rdoGreen.TabStop = True
        Me.rdoGreen.Text = "Green"
        Me.rdoGreen.UseVisualStyleBackColor = True
        '
        'btnColour
        '
        Me.btnColour.Location = New System.Drawing.Point(215, 44)
        Me.btnColour.Name = "btnColour"
        Me.btnColour.Size = New System.Drawing.Size(45, 43)
        Me.btnColour.TabIndex = 1
        Me.btnColour.Text = "Go"
        Me.btnColour.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.txtLocal)
        Me.GroupBox4.Controls.Add(Me.txtGlobal)
        Me.GroupBox4.Controls.Add(Me.btnLocal)
        Me.GroupBox4.Controls.Add(Me.btnGlobal)
        Me.GroupBox4.Location = New System.Drawing.Point(286, 201)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(184, 93)
        Me.GroupBox4.TabIndex = 4
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Variables"
        '
        'txtLocal
        '
        Me.txtLocal.Location = New System.Drawing.Point(6, 60)
        Me.txtLocal.Name = "txtLocal"
        Me.txtLocal.Size = New System.Drawing.Size(100, 23)
        Me.txtLocal.TabIndex = 11
        '
        'txtGlobal
        '
        Me.txtGlobal.Location = New System.Drawing.Point(6, 22)
        Me.txtGlobal.Name = "txtGlobal"
        Me.txtGlobal.Size = New System.Drawing.Size(100, 23)
        Me.txtGlobal.TabIndex = 10
        '
        'btnLocal
        '
        Me.btnLocal.Location = New System.Drawing.Point(133, 54)
        Me.btnLocal.Name = "btnLocal"
        Me.btnLocal.Size = New System.Drawing.Size(45, 33)
        Me.btnLocal.TabIndex = 3
        Me.btnLocal.Text = "Go"
        Me.btnLocal.UseVisualStyleBackColor = True
        '
        'btnGlobal
        '
        Me.btnGlobal.Location = New System.Drawing.Point(133, 16)
        Me.btnGlobal.Name = "btnGlobal"
        Me.btnGlobal.Size = New System.Drawing.Size(45, 33)
        Me.btnGlobal.TabIndex = 2
        Me.btnGlobal.Text = "Go"
        Me.btnGlobal.UseVisualStyleBackColor = True
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBack.Location = New System.Drawing.Point(25, 311)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(79, 39)
        Me.btnBack.TabIndex = 5
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'btnSmaller
        '
        Me.btnSmaller.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnSmaller.Location = New System.Drawing.Point(128, 323)
        Me.btnSmaller.Name = "btnSmaller"
        Me.btnSmaller.Size = New System.Drawing.Size(78, 34)
        Me.btnSmaller.TabIndex = 6
        Me.btnSmaller.Text = "Smaller"
        Me.btnSmaller.UseVisualStyleBackColor = False
        '
        'btnBigger
        '
        Me.btnBigger.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBigger.Location = New System.Drawing.Point(128, 363)
        Me.btnBigger.Name = "btnBigger"
        Me.btnBigger.Size = New System.Drawing.Size(78, 34)
        Me.btnBigger.TabIndex = 7
        Me.btnBigger.Text = "Bigger"
        Me.btnBigger.UseVisualStyleBackColor = False
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(231, 342)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(178, 15)
        Me.lblText.TabIndex = 8
        Me.lblText.Text = "I can change the size of this text."
        '
        'btnBold
        '
        Me.btnBold.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnBold.Location = New System.Drawing.Point(258, 365)
        Me.btnBold.Name = "btnBold"
        Me.btnBold.Size = New System.Drawing.Size(120, 24)
        Me.btnBold.TabIndex = 9
        Me.btnBold.Text = "Make Text Bold"
        Me.btnBold.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(531, 401)
        Me.Controls.Add(Me.btnBold)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnBigger)
        Me.Controls.Add(Me.btnSmaller)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents btnBack As Button
    Friend WithEvents btnSmaller As Button
    Friend WithEvents btnBigger As Button
    Friend WithEvents lblText As Label
    Friend WithEvents btnCheckBox As Button
    Friend WithEvents btnDate As Button
    Friend WithEvents btnColour As Button
    Friend WithEvents btnLocal As Button
    Friend WithEvents btnGlobal As Button
    Friend WithEvents btnBold As Button
    Friend WithEvents chkCheck2 As CheckBox
    Friend WithEvents chkCheck1 As CheckBox
    Friend WithEvents rdoPurple As RadioButton
    Friend WithEvents rdoYellow As RadioButton
    Friend WithEvents rdoOrange As RadioButton
    Friend WithEvents rdoAqua As RadioButton
    Friend WithEvents rdoGreen As RadioButton
    Friend WithEvents dateTimePicker As DateTimePicker
    Friend WithEvents txtGlobal As TextBox
    Friend WithEvents txtLocal As TextBox
End Class
