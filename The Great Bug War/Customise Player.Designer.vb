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
        Me.RedShip = New System.Windows.Forms.PictureBox()
        Me.selectedZone = New System.Windows.Forms.PictureBox()
        Me.selectedShip = New System.Windows.Forms.Label()
        Me.BlueShip = New System.Windows.Forms.PictureBox()
        CType(Me.RedShip, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.selectedZone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BlueShip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = True
        Me.BackBtn.BackColor = System.Drawing.Color.Transparent
        Me.BackBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(34, 390)
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
        'RedShip
        '
        Me.RedShip.Image = Global.The_Great_Bug_War.My.Resources.Resources.red_06
        Me.RedShip.Location = New System.Drawing.Point(370, 332)
        Me.RedShip.Name = "RedShip"
        Me.RedShip.Size = New System.Drawing.Size(50, 50)
        Me.RedShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.RedShip.TabIndex = 2
        Me.RedShip.TabStop = False
        Me.RedShip.Visible = False
        '
        'selectedZone
        '
        Me.selectedZone.BackColor = System.Drawing.Color.Transparent
        Me.selectedZone.Location = New System.Drawing.Point(370, 184)
        Me.selectedZone.Name = "selectedZone"
        Me.selectedZone.Size = New System.Drawing.Size(50, 50)
        Me.selectedZone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.selectedZone.TabIndex = 3
        Me.selectedZone.TabStop = False
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
        Me.BlueShip.Location = New System.Drawing.Point(445, 332)
        Me.BlueShip.Name = "BlueShip"
        Me.BlueShip.Size = New System.Drawing.Size(50, 50)
        Me.BlueShip.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.BlueShip.TabIndex = 5
        Me.BlueShip.TabStop = False
        Me.BlueShip.Visible = False
        '
        'Customise_Player
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.The_Great_Bug_War.My.Resources.Resources._1000_F_264279006_WDXxV3OHjAOoHqH7iiLDrg23p0947g7U
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BlueShip)
        Me.Controls.Add(Me.selectedShip)
        Me.Controls.Add(Me.RedShip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.selectedZone)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Customise_Player"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Customise_Player"
        CType(Me.RedShip, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.selectedZone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BlueShip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents RedShip As PictureBox
    Friend WithEvents selectedZone As PictureBox
    Friend WithEvents selectedShip As Label
    Friend WithEvents BlueShip As PictureBox
End Class
