Public Class Level1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Level1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Customise_Player.shipType = "Red Ship" Then
            Label1.Text = "red ship"
        End If
    End Sub
End Class