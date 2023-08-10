<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.PlayBtn = New System.Windows.Forms.Label()
        Me.InstructionsBtn = New System.Windows.Forms.Label()
        Me.OptionsBtn = New System.Windows.Forms.Label()
        Me.HighBtn = New System.Windows.Forms.Label()
        Me.CreditsBtn = New System.Windows.Forms.Label()
        Me.ExitBtn = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 48)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Insect Invasion:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "The Great Bug War" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PlayBtn
        '
        Me.PlayBtn.AutoSize = True
        Me.PlayBtn.Location = New System.Drawing.Point(378, 280)
        Me.PlayBtn.Name = "PlayBtn"
        Me.PlayBtn.Size = New System.Drawing.Size(34, 16)
        Me.PlayBtn.TabIndex = 1
        Me.PlayBtn.Text = "Play"
        Me.PlayBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'InstructionsBtn
        '
        Me.InstructionsBtn.AutoSize = True
        Me.InstructionsBtn.Location = New System.Drawing.Point(364, 307)
        Me.InstructionsBtn.Name = "InstructionsBtn"
        Me.InstructionsBtn.Size = New System.Drawing.Size(73, 16)
        Me.InstructionsBtn.TabIndex = 2
        Me.InstructionsBtn.Text = "Instructions"
        Me.InstructionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'OptionsBtn
        '
        Me.OptionsBtn.AutoSize = True
        Me.OptionsBtn.Location = New System.Drawing.Point(370, 337)
        Me.OptionsBtn.Name = "OptionsBtn"
        Me.OptionsBtn.Size = New System.Drawing.Size(53, 16)
        Me.OptionsBtn.TabIndex = 3
        Me.OptionsBtn.Text = "Options"
        Me.OptionsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'HighBtn
        '
        Me.HighBtn.AutoSize = True
        Me.HighBtn.Location = New System.Drawing.Point(361, 367)
        Me.HighBtn.Name = "HighBtn"
        Me.HighBtn.Size = New System.Drawing.Size(81, 16)
        Me.HighBtn.TabIndex = 3
        Me.HighBtn.Text = "High Scores"
        Me.HighBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CreditsBtn
        '
        Me.CreditsBtn.AutoSize = True
        Me.CreditsBtn.Location = New System.Drawing.Point(374, 396)
        Me.CreditsBtn.Name = "CreditsBtn"
        Me.CreditsBtn.Size = New System.Drawing.Size(49, 16)
        Me.CreditsBtn.TabIndex = 4
        Me.CreditsBtn.Text = "Credits"
        Me.CreditsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ExitBtn
        '
        Me.ExitBtn.AutoSize = True
        Me.ExitBtn.Location = New System.Drawing.Point(383, 427)
        Me.ExitBtn.Name = "ExitBtn"
        Me.ExitBtn.Size = New System.Drawing.Size(28, 16)
        Me.ExitBtn.TabIndex = 5
        Me.ExitBtn.Text = "Exit"
        Me.ExitBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(802, 553)
        Me.Controls.Add(Me.ExitBtn)
        Me.Controls.Add(Me.CreditsBtn)
        Me.Controls.Add(Me.HighBtn)
        Me.Controls.Add(Me.OptionsBtn)
        Me.Controls.Add(Me.InstructionsBtn)
        Me.Controls.Add(Me.PlayBtn)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
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
End Class
