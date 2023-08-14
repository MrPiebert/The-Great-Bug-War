<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HighScores
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ScoreSeven = New System.Windows.Forms.Label()
        Me.ScoreSix = New System.Windows.Forms.Label()
        Me.ScoreFive = New System.Windows.Forms.Label()
        Me.ScoreFour = New System.Windows.Forms.Label()
        Me.ScoreThree = New System.Windows.Forms.Label()
        Me.ScoreTwo = New System.Windows.Forms.Label()
        Me.ScoreOne = New System.Windows.Forms.Label()
        Me.HighScoresLbl = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.BackBtn)
        Me.Panel1.Controls.Add(Me.ScoreSeven)
        Me.Panel1.Controls.Add(Me.ScoreSix)
        Me.Panel1.Controls.Add(Me.ScoreFive)
        Me.Panel1.Controls.Add(Me.ScoreFour)
        Me.Panel1.Controls.Add(Me.ScoreThree)
        Me.Panel1.Controls.Add(Me.ScoreTwo)
        Me.Panel1.Controls.Add(Me.ScoreOne)
        Me.Panel1.Controls.Add(Me.HighScoresLbl)
        Me.Panel1.Location = New System.Drawing.Point(12, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(264, 423)
        Me.Panel1.TabIndex = 0
        '
        'ScoreSeven
        '
        Me.ScoreSeven.AutoSize = True
        Me.ScoreSeven.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreSeven.Location = New System.Drawing.Point(40, 343)
        Me.ScoreSeven.Name = "ScoreSeven"
        Me.ScoreSeven.Size = New System.Drawing.Size(86, 18)
        Me.ScoreSeven.TabIndex = 7
        Me.ScoreSeven.Text = "Label6"
        '
        'ScoreSix
        '
        Me.ScoreSix.AutoSize = True
        Me.ScoreSix.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreSix.Location = New System.Drawing.Point(40, 302)
        Me.ScoreSix.Name = "ScoreSix"
        Me.ScoreSix.Size = New System.Drawing.Size(86, 18)
        Me.ScoreSix.TabIndex = 6
        Me.ScoreSix.Text = "Label5"
        '
        'ScoreFive
        '
        Me.ScoreFive.AutoSize = True
        Me.ScoreFive.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreFive.Location = New System.Drawing.Point(40, 258)
        Me.ScoreFive.Name = "ScoreFive"
        Me.ScoreFive.Size = New System.Drawing.Size(86, 18)
        Me.ScoreFive.TabIndex = 5
        Me.ScoreFive.Text = "Label4"
        '
        'ScoreFour
        '
        Me.ScoreFour.AutoSize = True
        Me.ScoreFour.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreFour.Location = New System.Drawing.Point(40, 216)
        Me.ScoreFour.Name = "ScoreFour"
        Me.ScoreFour.Size = New System.Drawing.Size(86, 18)
        Me.ScoreFour.TabIndex = 4
        Me.ScoreFour.Text = "Label3"
        '
        'ScoreThree
        '
        Me.ScoreThree.AutoSize = True
        Me.ScoreThree.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreThree.Location = New System.Drawing.Point(40, 175)
        Me.ScoreThree.Name = "ScoreThree"
        Me.ScoreThree.Size = New System.Drawing.Size(86, 18)
        Me.ScoreThree.TabIndex = 3
        Me.ScoreThree.Text = "Label2"
        '
        'ScoreTwo
        '
        Me.ScoreTwo.AutoSize = True
        Me.ScoreTwo.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreTwo.Location = New System.Drawing.Point(40, 135)
        Me.ScoreTwo.Name = "ScoreTwo"
        Me.ScoreTwo.Size = New System.Drawing.Size(203, 18)
        Me.ScoreTwo.TabIndex = 2
        Me.ScoreTwo.Text = "BOB      000004"
        '
        'ScoreOne
        '
        Me.ScoreOne.AutoSize = True
        Me.ScoreOne.Font = New System.Drawing.Font("Press Start 2P", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ScoreOne.Location = New System.Drawing.Point(40, 94)
        Me.ScoreOne.Name = "ScoreOne"
        Me.ScoreOne.Size = New System.Drawing.Size(203, 18)
        Me.ScoreOne.TabIndex = 1
        Me.ScoreOne.Text = "GUY      456789" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'HighScoresLbl
        '
        Me.HighScoresLbl.AutoSize = True
        Me.HighScoresLbl.Font = New System.Drawing.Font("Press Start 2P", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HighScoresLbl.Location = New System.Drawing.Point(18, 29)
        Me.HighScoresLbl.Name = "HighScoresLbl"
        Me.HighScoresLbl.Size = New System.Drawing.Size(232, 27)
        Me.HighScoresLbl.TabIndex = 0
        Me.HighScoresLbl.Text = "High Scores"
        '
        'BackBtn
        '
        Me.BackBtn.AutoSize = True
        Me.BackBtn.Font = New System.Drawing.Font("Press Start 2P", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.Location = New System.Drawing.Point(19, 382)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(78, 23)
        Me.BackBtn.TabIndex = 8
        Me.BackBtn.Text = "Back"
        '
        'HighScores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(288, 447)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "HighScores"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HighScores"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents ScoreSeven As Label
    Friend WithEvents ScoreSix As Label
    Friend WithEvents ScoreFive As Label
    Friend WithEvents ScoreFour As Label
    Friend WithEvents ScoreThree As Label
    Friend WithEvents ScoreTwo As Label
    Friend WithEvents ScoreOne As Label
    Friend WithEvents HighScoresLbl As Label
    Friend WithEvents BackBtn As Label
End Class
