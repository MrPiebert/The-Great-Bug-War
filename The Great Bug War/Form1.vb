Imports WMPLib
Imports System.IO

Public Class Form1
    Public player As New WindowsMediaPlayer

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch                      'sets background image size
        player.URL = "Terraria - Overworld Day 8-Bit Theme.wav"
        player.settings.setMode("loop", True)
        player.controls.play()
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
End Class
