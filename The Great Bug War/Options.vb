Imports Microsoft.VisualBasic.Devices

Public Class Options
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AudioLbl.Click
        If AudioLbl.Text = "Mute" Then
            Form1.player.controls.pause()
            AudioLbl.Text = "Unmute"
        Else
            Form1.player.controls.play()
            AudioLbl.Text = "Mute"
        End If
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.player.settings.volume = 100
        AudioBar.Value = Form1.player.settings.volume
    End Sub

    Private Sub AudioBar_Scroll(sender As Object, e As EventArgs) Handles AudioBar.Scroll
        Form1.player.settings.volume = AudioBar.Value
    End Sub
End Class