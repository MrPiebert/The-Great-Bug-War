Imports Microsoft.VisualBasic.Devices

Public Class Customise_Player
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Customise_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RedShip.MouseDown
        drag = True 'Sets the variable drag to true.
        mousex = Windows.Forms.Cursor.Position.X - RedShip.Left 'Sets variable mousex
        mousey = Windows.Forms.Cursor.Position.Y - RedShip.Top 'Sets variable mousey
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RedShip.MouseMove
        'If drag is set to true then move the form accordingly.
        If drag Then
            Dim newTop As Integer = Windows.Forms.Cursor.Position.Y - mousey
            Dim newLeft As Integer = Windows.Forms.Cursor.Position.X - mousex

            ' Check if the new location is within the form
            If newTop >= 0 And newTop + RedShip.Height <= Me.Height And newLeft >= 0 And newLeft + RedShip.Width <= Me.Width Then
                RedShip.Top = newTop
                RedShip.Left = newLeft
            End If
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RedShip.MouseUp
        drag = False 'Sets drag to false, so the form does not move according to the code in MouseMove.
    End Sub
End Class
