<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Instructions
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
        Me.BackBtn = New System.Windows.Forms.Label()
        Me.IntructionsLbl = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = True
        Me.BackBtn.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(356, 409)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(92, 27)
        Me.BackBtn.TabIndex = 0
        Me.BackBtn.Text = "Back"
        '
        'IntructionsLbl
        '
        Me.IntructionsLbl.AutoSize = True
        Me.IntructionsLbl.Font = New System.Drawing.Font("Press Start 2P", 16.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IntructionsLbl.Location = New System.Drawing.Point(219, 20)
        Me.IntructionsLbl.Name = "IntructionsLbl"
        Me.IntructionsLbl.Size = New System.Drawing.Size(353, 38)
        Me.IntructionsLbl.TabIndex = 1
        Me.IntructionsLbl.Text = "Instructions"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(46, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(355, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Just press WASD to move and Z to shoot and X to skill smh"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(511, 100)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(233, 220)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Instructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 460)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.IntructionsLbl)
        Me.Controls.Add(Me.BackBtn)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Instructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Instructions"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BackBtn As Label
    Friend WithEvents IntructionsLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
