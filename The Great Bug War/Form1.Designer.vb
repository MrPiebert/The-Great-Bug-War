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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PlayBtn = New System.Windows.Forms.Label()
        Me.InstructionsBtn = New System.Windows.Forms.Label()
        Me.OptionsBtn = New System.Windows.Forms.Label()
        Me.HighBtn = New System.Windows.Forms.Label()
        Me.CreditsBtn = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Press Start 2P", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.IndianRed
        Me.Label1.Location = New System.Drawing.Point(192, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(493, 114)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insect Invasion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Great Bug War" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayBtn
        '
        Me.PlayBtn.AutoSize = True
        Me.PlayBtn.BackColor = System.Drawing.Color.Transparent
        Me.PlayBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlayBtn.ForeColor = System.Drawing.Color.White
        Me.PlayBtn.Location = New System.Drawing.Point(398, 277)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(92, 27)
        Me.PlayBtn.TabIndex = 1
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InstructionsBtn
        '
        Me.InstructionsBtn.AutoSize = True
        Me.InstructionsBtn.BackColor = System.Drawing.Color.Transparent
        Me.InstructionsBtn.Font = New System.Drawing.Font("Press Start 2P", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InstructionsBtn.ForeColor = System.Drawing.Color.White
        Me.InstructionsBtn.Location = New System.Drawing.Point(317, 316)
        Me.InstructionsBtn.Name = "InstructionsBtn"
        Me.InstructionsBtn.Size = New System.Drawing.Size(228, 25)
        Me.InstructionsBtn.TabIndex = 2
        Me.InstructionsBtn.Text = "Instructions"
        Me.InstructionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OptionsBtn
        '
        Me.OptionsBtn.AutoSize = True
        Me.OptionsBtn.BackColor = System.Drawing.Color.Transparent
        Me.OptionsBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsBtn.ForeColor = System.Drawing.Color.Transparent
        Me.OptionsBtn.Location = New System.Drawing.Point(368, 353)
        Me.OptionsBtn.Name = "OptionsBtn"
        Me.OptionsBtn.Size = New System.Drawing.Size(152, 27)
        Me.OptionsBtn.TabIndex = 3
        Me.OptionsBtn.Text = "Options"
        Me.OptionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighBtn
        '
        Me.HighBtn.AutoSize = True
        Me.HighBtn.BackColor = System.Drawing.Color.Transparent
        Me.HighBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighBtn.ForeColor = System.Drawing.Color.Snow
        Me.HighBtn.Location = New System.Drawing.Point(331, 395)
        Me.HighBtn.Name = "HighBtn"
        Me.HighBtn.Size = New System.Drawing.Size(232, 27)
        Me.HighBtn.TabIndex = 3
        Me.HighBtn.Text = "High Scores"
        Me.HighBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreditsBtn
        '
        Me.CreditsBtn.AutoSize = True
        Me.CreditsBtn.BackColor = System.Drawing.Color.Transparent
        Me.CreditsBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CreditsBtn.ForeColor = System.Drawing.Color.Snow
        Me.CreditsBtn.Location = New System.Drawing.Point(368, 435)
        Me.CreditsBtn.Name = "CreditsBtn"
        Me.CreditsBtn.Size = New System.Drawing.Size(152, 27)
        Me.CreditsBtn.TabIndex = 4
        Me.CreditsBtn.Text = "Credits"
        Me.CreditsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoSize = True
        Me.ExitBtn.BackColor = System.Drawing.Color.Transparent
        Me.ExitBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitBtn.ForeColor = System.Drawing.Color.Snow
        Me.ExitBtn.Location = New System.Drawing.Point(398, 474)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(92, 27)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox1.Location = New System.Drawing.Point(357, 271)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox2.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox2.Location = New System.Drawing.Point(284, 309)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 7
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox3.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox3.Location = New System.Drawing.Point(329, 348)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 8
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox4.Location = New System.Drawing.Point(291, 391)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox4.TabIndex = 9
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox5.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox5.Location = New System.Drawing.Point(326, 429)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 10
        Me.PictureBox5.TabStop = False
        Me.PictureBox5.Visible = False
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox6.Image = Global.The_Great_Bug_War.My.Resources.Resources.New_Piskel_1_png__1_
        Me.PictureBox6.Location = New System.Drawing.Point(358, 469)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(45, 30)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox6.TabIndex = 11
        Me.PictureBox6.TabStop = False
        Me.PictureBox6.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Great_Bug_War.My.Resources.Resources.cropped_1920_1200_900628
        Me.ClientSize = New System.Drawing.Size(879, 578)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CreditsBtn)
        Me.Controls.Add(Me.HighBtn)
        Me.Controls.Add(Me.OptionsBtn)
        Me.Controls.Add(Me.InstructionsBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents PlayBtn As Label
    Friend WithEvents InstructionsBtn As Label
    Friend WithEvents OptionsBtn As Label
    Friend WithEvents HighBtn As Label
    Friend WithEvents CreditsBtn As Label
    Friend WithEvents ExitBtn As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox6 As PictureBox
End Class
