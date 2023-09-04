Imports WMPLib
Imports System.IO

Public Class Form1
    Public player As New WindowsMediaPlayer
    Public beep As New WindowsMediaPlayer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch                      'sets background image size
        player.URL = "Terraria - Overworld Day 8-Bit Theme.wav"
        player.settings.setMode("loop", True)
        player.controls.play()
        beep.URL = "Beeper.mp3"
    End Sub

    Private Sub ExitBtn_Click(sender As Object, e As EventArgs) Handles ExitBtn.Click
        Me.Close()
    End Sub

    Private Sub PlayBtn_Click(sender As Object, e As EventArgs) Handles PlayBtn.Click
        Me.Hide()
        Customise_Player.Show()
    End Sub

    Private Sub OptionsBtn_Click(sender As Object, e As EventArgs) Handles OptionsBtn.Click
        Options.Show()
    End Sub

    Private Sub HighBtn_Click(sender As Object, e As EventArgs) Handles HighBtn.Click
        HighScores.Show()
    End Sub

    Private Sub InstructionsBtn_Click(sender As Object, e As EventArgs) Handles InstructionsBtn.Click
        Instructions.Show()
    End Sub
    Private Sub Play_MouseHover(sender As Object, e As EventArgs) Handles PlayBtn.MouseEnter
        beep.controls.play()
        PictureBox1.Visible = True
        PlayBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub Play_MouseLeave(sender As Object, e As EventArgs) Handles PlayBtn.MouseLeave
        PictureBox1.Visible = False
        PlayBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
    Private Sub Intructions_MouseHover(sender As Object, e As EventArgs) Handles InstructionsBtn.MouseEnter
        beep.controls.play()
        PictureBox2.Visible = True
        InstructionsBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub Instructions_MouseLeave(sender As Object, e As EventArgs) Handles InstructionsBtn.MouseLeave
        PictureBox2.Visible = False
        InstructionsBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
    Private Sub Options_MouseHover(sender As Object, e As EventArgs) Handles OptionsBtn.MouseEnter
        beep.controls.play()
        PictureBox3.Visible = True
        OptionsBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub Options_MouseLeave(sender As Object, e As EventArgs) Handles OptionsBtn.MouseLeave
        PictureBox3.Visible = False
        OptionsBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
    Private Sub HighScore_MouseHover(sender As Object, e As EventArgs) Handles HighBtn.MouseEnter
        beep.controls.play()
        PictureBox4.Visible = True
        HighBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub HighScore_MouseLeave(sender As Object, e As EventArgs) Handles HighBtn.MouseLeave
        PictureBox4.Visible = False
        HighBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
    Private Sub Credits_MouseHover(sender As Object, e As EventArgs) Handles CreditsBtn.MouseEnter
        beep.controls.play()
        PictureBox5.Visible = True
        CreditsBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub Credits_MouseLeave(sender As Object, e As EventArgs) Handles CreditsBtn.MouseLeave
        PictureBox5.Visible = False
        CreditsBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
    Private Sub Exit_MouseHover(sender As Object, e As EventArgs) Handles ExitBtn.MouseEnter
        beep.controls.play()
        PictureBox6.Visible = True
        ExitBtn.Font = New Font("Press Start 2P", 13, FontStyle.Regular)
    End Sub

    Private Sub Exit_MouseLeave(sender As Object, e As EventArgs) Handles ExitBtn.MouseLeave
        PictureBox6.Visible = False
        ExitBtn.Font = New Font("Press Start 2P", 12, FontStyle.Regular)
    End Sub
End Class
