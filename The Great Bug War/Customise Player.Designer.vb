<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Customise_Player
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
        Me.BackBtn = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OrangeShip = New System.Windows.Forms.PictureBox()
        Me.selectedShip = New System.Windows.Forms.Label()
        Me.BlueShip = New System.Windows.Forms.PictureBox()
        Me.RedShip = New System.Windows.Forms.PictureBox()
        Me.GreenShip = New System.Windows.Forms.PictureBox()
        Me.PurpleShip = New System.Windows.Forms.PictureBox()
        Me.BlackShip = New System.Windows.Forms.PictureBox()
        Me.StingType = New System.Windows.Forms.PictureBox()
        Me.WingType = New System.Windows.Forms.PictureBox()
        Me.StringType = New System.Windows.Forms.PictureBox()
        Me.Carapace = New System.Windows.Forms.PictureBox()
        Me.Buzz = New System.Windows.Forms.PictureBox()
        Me.Hose = New System.Windows.Forms.PictureBox()
        Me.selectedShot = New System.Windows.Forms.Label()
        Me.selectedSkill = New System.Windows.Forms.Label()
        Me.BeginBtn = New System.Windows.Forms.Label()
        CType(Me.OrangeShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurpleShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlackShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StingType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WingType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StringType, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Carapace, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Buzz, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Hose, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = True
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(28, 402)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(92, 27)
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.Text = "Back"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(222, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(372, 54)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Drag and Drop " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "to Build Your Ship"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OrangeShip
        '
        Me.OrangeShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.orange_05
        Me.OrangeShip.Location = New System.Drawing.Point(446, 321)
        Me.OrangeShip.Name = "OrangeShip"
        Me.OrangeShip.Size = New System.Drawing.Size(50, 50)
        Me.OrangeShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.OrangeShip.TabIndex = 2
        Me.OrangeShip.TabStop = False
        Me.OrangeShip.Visible = False
        '
        'selectedShip
        '
        Me.selectedShip.AutoSize = True
        Me.selectedShip.BackColor = System.Drawing.Color.Transparent
        Me.selectedShip.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedShip.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.selectedShip.Location = New System.Drawing.Point(350, 84)
        Me.selectedShip.Name = "selectedShip"
        Me.selectedShip.Size = New System.Drawing.Size(99, 18)
        Me.selectedShip.TabIndex = 4
        Me.selectedShip.Text = "No Ship"
        Me.selectedShip.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BlueShip
        '
        Me.BlueShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.blue_01
        Me.BlueShip.Location = New System.Drawing.Point(371, 321)
        Me.BlueShip.Name = "BlueShip"
        Me.BlueShip.Size = New System.Drawing.Size(50, 50)
        Me.BlueShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlueShip.TabIndex = 5
        Me.BlueShip.TabStop = False
        Me.BlueShip.Visible = False
        '
        'RedShip
        '
        Me.RedShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.red_06
        Me.RedShip.Location = New System.Drawing.Point(297, 321)
        Me.RedShip.Name = "RedShip"
        Me.RedShip.Size = New System.Drawing.Size(50, 50)
        Me.RedShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RedShip.TabIndex = 6
        Me.RedShip.TabStop = False
        Me.RedShip.Visible = False
        '
        'GreenShip
        '
        Me.GreenShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.green_03
        Me.GreenShip.Location = New System.Drawing.Point(297, 379)
        Me.GreenShip.Name = "GreenShip"
        Me.GreenShip.Size = New System.Drawing.Size(50, 50)
        Me.GreenShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.GreenShip.TabIndex = 7
        Me.GreenShip.TabStop = False
        Me.GreenShip.Visible = False
        '
        'PurpleShip
        '
        Me.PurpleShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.purple_06
        Me.PurpleShip.Location = New System.Drawing.Point(371, 379)
        Me.PurpleShip.Name = "PurpleShip"
        Me.PurpleShip.Size = New System.Drawing.Size(50, 50)
        Me.PurpleShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PurpleShip.TabIndex = 8
        Me.PurpleShip.TabStop = False
        Me.PurpleShip.Visible = False
        '
        'BlackShip
        '
        Me.BlackShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.darkgrey_01
        Me.BlackShip.Location = New System.Drawing.Point(446, 379)
        Me.BlackShip.Name = "BlackShip"
        Me.BlackShip.Size = New System.Drawing.Size(50, 50)
        Me.BlackShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlackShip.TabIndex = 9
        Me.BlackShip.TabStop = False
        Me.BlackShip.Visible = False
        '
        'StingType
        '
        Me.StingType.Image = Global.The_Great_Bug_War.My.Resources.Resources.projectile05_4
        Me.StingType.Location = New System.Drawing.Point(118, 128)
        Me.StingType.Name = "StingType"
        Me.StingType.Size = New System.Drawing.Size(50, 50)
        Me.StingType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StingType.TabIndex = 10
        Me.StingType.TabStop = False
        Me.StingType.Visible = False
        '
        'WingType
        '
        Me.WingType.Image = Global.The_Great_Bug_War.My.Resources.Resources.projectile04_3
        Me.WingType.Location = New System.Drawing.Point(118, 184)
        Me.WingType.Name = "WingType"
        Me.WingType.Size = New System.Drawing.Size(50, 50)
        Me.WingType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.WingType.TabIndex = 11
        Me.WingType.TabStop = False
        Me.WingType.Visible = False
        '
        'StringType
        '
        Me.StringType.Image = Global.The_Great_Bug_War.My.Resources.Resources.projectile03_5
        Me.StringType.Location = New System.Drawing.Point(118, 240)
        Me.StringType.Name = "StringType"
        Me.StringType.Size = New System.Drawing.Size(50, 50)
        Me.StringType.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.StringType.TabIndex = 12
        Me.StringType.TabStop = False
        Me.StringType.Visible = False
        '
        'Carapace
        '
        Me.Carapace.Image = Global.The_Great_Bug_War.My.Resources.Resources.f5c21548b9ef4e43f6184c4209451caeDCUfy5dqBbO8RLpI_0_removebg_preview
        Me.Carapace.Location = New System.Drawing.Point(619, 128)
        Me.Carapace.Name = "Carapace"
        Me.Carapace.Size = New System.Drawing.Size(50, 50)
        Me.Carapace.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Carapace.TabIndex = 13
        Me.Carapace.TabStop = False
        Me.Carapace.Visible = False
        '
        'Buzz
        '
        Me.Buzz.Image = Global.The_Great_Bug_War.My.Resources.Resources.Spray_Can_removebg_preview
        Me.Buzz.Location = New System.Drawing.Point(619, 184)
        Me.Buzz.Name = "Buzz"
        Me.Buzz.Size = New System.Drawing.Size(50, 50)
        Me.Buzz.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Buzz.TabIndex = 14
        Me.Buzz.TabStop = False
        Me.Buzz.Visible = False
        '
        'Hose
        '
        Me.Hose.Image = Global.The_Great_Bug_War.My.Resources.Resources._removal_ai__93560fd2_eb40_48de_b1ff_e54c01f835ac_1000_f_92205404_exfuaygjfnqrd4tvbn2ppjfjshnonads
        Me.Hose.Location = New System.Drawing.Point(625, 249)
        Me.Hose.Name = "Hose"
        Me.Hose.Size = New System.Drawing.Size(50, 50)
        Me.Hose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.Hose.TabIndex = 15
        Me.Hose.TabStop = False
        Me.Hose.Visible = False
        '
        'selectedShot
        '
        Me.selectedShot.AutoSize = True
        Me.selectedShot.BackColor = System.Drawing.Color.Transparent
        Me.selectedShot.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedShot.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.selectedShot.Location = New System.Drawing.Point(88, 84)
        Me.selectedShot.Name = "selectedShot"
        Me.selectedShot.Size = New System.Drawing.Size(125, 18)
        Me.selectedShot.TabIndex = 16
        Me.selectedShot.Text = "No Weapon"
        Me.selectedShot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'selectedSkill
        '
        Me.selectedSkill.AutoSize = True
        Me.selectedSkill.BackColor = System.Drawing.Color.Transparent
        Me.selectedSkill.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.selectedSkill.ForeColor = System.Drawing.Color.MediumSeaGreen
        Me.selectedSkill.Location = New System.Drawing.Point(590, 84)
        Me.selectedSkill.Name = "selectedSkill"
        Me.selectedSkill.Size = New System.Drawing.Size(112, 18)
        Me.selectedSkill.TabIndex = 17
        Me.selectedSkill.Text = "No Skill"
        Me.selectedSkill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BeginBtn
        '
        Me.BeginBtn.AutoSize = True
        Me.BeginBtn.BackColor = System.Drawing.Color.Transparent
        Me.BeginBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeginBtn.ForeColor = System.Drawing.Color.White
        Me.BeginBtn.Location = New System.Drawing.Point(620, 402)
        Me.BeginBtn.Name = "BeginBtn"
        Me.BeginBtn.Size = New System.Drawing.Size(112, 27)
        Me.BeginBtn.TabIndex = 18
        Me.BeginBtn.Text = "Begin"
        '
        'Customise_Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Great_Bug_War.My.Resources.Resources._1000_F_264279006_WDXxV3OHjAOoHqH7iiLDrg23p0947g7U
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BeginBtn)
        Me.Controls.Add(Me.selectedSkill)
        Me.Controls.Add(Me.selectedShot)
        Me.Controls.Add(Me.Hose)
        Me.Controls.Add(Me.Buzz)
        Me.Controls.Add(Me.Carapace)
        Me.Controls.Add(Me.StringType)
        Me.Controls.Add(Me.WingType)
        Me.Controls.Add(Me.StingType)
        Me.Controls.Add(Me.BlackShip)
        Me.Controls.Add(Me.PurpleShip)
        Me.Controls.Add(Me.GreenShip)
        Me.Controls.Add(Me.RedShip)
        Me.Controls.Add(Me.BlueShip)
        Me.Controls.Add(Me.selectedShip)
        Me.Controls.Add(Me.OrangeShip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customise_Player"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customise_Player"
        CType(Me.OrangeShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RedShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GreenShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PurpleShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlackShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StingType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WingType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StringType, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Carapace, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Buzz, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Hose, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents OrangeShip As PictureBox
    Friend WithEvents selectedShip As Label
    Friend WithEvents BlueShip As PictureBox
    Friend WithEvents RedShip As PictureBox
    Friend WithEvents GreenShip As PictureBox
    Friend WithEvents PurpleShip As PictureBox
    Friend WithEvents BlackShip As PictureBox
    Friend WithEvents StingType As PictureBox
    Friend WithEvents WingType As PictureBox
    Friend WithEvents StringType As PictureBox
    Friend WithEvents Carapace As PictureBox
    Friend WithEvents Buzz As PictureBox
    Friend WithEvents Hose As PictureBox
    Friend WithEvents selectedShot As Label
    Friend WithEvents selectedSkill As Label
    Friend WithEvents BeginBtn As Label
End Class
