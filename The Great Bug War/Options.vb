Public Class Options
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles AudioLbl.Click
        If AudioLbl.Text = "Mute" Then
            My.Computer.Audio.Stop()
            AudioLbl.Text = "Unmute"
        Else
            My.Computer.Audio.Play(My.Resources.Terraria___Overworld_Day_8_Bit_Theme, AudioPlayMode.BackgroundLoop)
            AudioLbl.Text = "Mute"
        End If
    End Sub
End Class