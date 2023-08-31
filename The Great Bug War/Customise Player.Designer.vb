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
        CType(Me.OrangeShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RedShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GreenShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PurpleShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlackShip, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Label1.Location = New System.Drawing.Point(251, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(312, 27)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Build Your Ship"
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
        Me.selectedShip.Location = New System.Drawing.Point(606, 104)
        Me.selectedShip.Name = "selectedShip"
        Me.selectedShip.Size = New System.Drawing.Size(48, 16)
        Me.selectedShip.TabIndex = 4
        Me.selectedShip.Text = "Label2"
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
        'Customise_Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Great_Bug_War.My.Resources.Resources._1000_F_264279006_WDXxV3OHjAOoHqH7iiLDrg23p0947g7U
        Me.ClientSize = New System.Drawing.Size(800, 450)
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
End Class
