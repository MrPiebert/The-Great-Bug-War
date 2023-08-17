<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Options
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
        Me.OptionsLbl = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AudioLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Label()
        Me.AudioBar = New System.Windows.Forms.TrackBar()
        Me.Panel1.SuspendLayout()
        CType(Me.AudioBar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OptionsLbl
        '
        Me.OptionsLbl.AutoSize = True
        Me.OptionsLbl.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.OptionsLbl.Location = New System.Drawing.Point(75, 24)
        Me.OptionsLbl.Name = "OptionsLbl"
        Me.OptionsLbl.Size = New System.Drawing.Size(152, 27)
        Me.OptionsLbl.TabIndex = 0
        Me.OptionsLbl.Text = "Options"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.AudioBar)
        Me.Panel1.Controls.Add(Me.AudioLbl)
        Me.Panel1.Controls.Add(Me.BackBtn)
        Me.Panel1.Controls.Add(Me.OptionsLbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(304, 408)
        Me.Panel1.TabIndex = 1
        '
        'AudioLbl
        '
        Me.AudioLbl.AutoSize = True
        Me.AudioLbl.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AudioLbl.Location = New System.Drawing.Point(108, 148)
        Me.AudioLbl.Name = "AudioLbl"
        Me.AudioLbl.Size = New System.Drawing.Size(92, 27)
        Me.AudioLbl.TabIndex = 2
        Me.AudioLbl.Text = "Mute"
        Me.AudioLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = True
        Me.BackBtn.Font = New System.Drawing.Font("Press Start 2P", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(109, 338)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(78, 23)
        Me.BackBtn.TabIndex = 1
        Me.BackBtn.Text = "Back"
        '
        'AudioBar
        '
        Me.AudioBar.Location = New System.Drawing.Point(57, 230)
        Me.AudioBar.Maximum = 100
        Me.AudioBar.Name = "AudioBar"
        Me.AudioBar.Size = New System.Drawing.Size(181, 56)
        Me.AudioBar.TabIndex = 3
        '
        'Options
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(328, 432)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Options"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Options"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AudioBar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents OptionsLbl As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BackBtn As Label
    Friend WithEvents AudioLbl As Label
    Friend WithEvents AudioBar As TrackBar
End Class
