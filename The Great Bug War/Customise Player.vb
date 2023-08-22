Imports Microsoft.VisualBasic.Devices
Imports System.Drawing

Public Class Customise_Player
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim redShipBitmap As Bitmap
    Dim redShipLocation As Point

    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Customise_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImageLayout = ImageLayout.Stretch
        redShipBitmap = New Bitmap(RedShip.Image)
        redShipLocation = RedShip.Location
    End Sub

    Private Sub Customise_Player_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim offScreenBitmap As New Bitmap(Me.Width, Me.Height)
        Using offScreenGraphics As Graphics = Graphics.FromImage(offScreenBitmap)
            offScreenGraphics.DrawImage(redShipBitmap, redShipLocation)
        End Using

        e.Graphics.DrawImage(offScreenBitmap, 0, 0)
    End Sub

    Private Sub RedShip_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If New Rectangle(redShipLocation, redShipBitmap.Size).Contains(e.Location) Then
            drag = True
            mousex = e.X
            mousey = e.Y
        End If
    End Sub

    Private Sub RedShip_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If drag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            redShipLocation.X += deltaX
            redShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If redShipLocation.X >= 0 And redShipLocation.X + redShipBitmap.Width <= Me.Width And
               redShipLocation.Y >= 0 And redShipLocation.Y + redShipBitmap.Height <= Me.Height Then

                ' Check if the red ship overlaps with the selectedZone PictureBox
                Dim selectedZoneRect As New Rectangle(selectedZone.Location, selectedZone.Size)
                Dim redShipRect As New Rectangle(redShipLocation, redShipBitmap.Size)

                If redShipRect.IntersectsWith(selectedZoneRect) Then
                    ' Snap red ship to the location of the selectedZone PictureBox
                    redShipLocation = selectedZone.Location
                    selectedShip.Text = "Red Ship"
                End If

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y
        End If
    End Sub

    Private Sub RedShip_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        drag = False
    End Sub
End Class