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
            PictureBox1.Image = My.Resources.Mute_Icon
        Else
            Form1.player.controls.play()
            AudioLbl.Text = "Mute"
            PictureBox1.Image = My.Resources.Speaker_Icon_svg
        End If
    End Sub

    Private Sub Options_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.player.settings.volume = 100
        AudioBar.Value = Form1.player.settings.volume
    End Sub

    Private Sub AudioBar_Scroll(sender As Object, e As EventArgs) Handles AudioBar.Scroll
        Form1.player.settings.volume = AudioBar.Value
        If AudioBar.Value = 0 Then
            PictureBox1.Image = My.Resources.Mute_Icon
        Else
            PictureBox1.Image = My.Resources.Speaker_Icon_svg
        End If
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class