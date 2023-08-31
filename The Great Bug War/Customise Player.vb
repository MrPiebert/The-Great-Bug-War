Imports Microsoft.VisualBasic.Devices
Imports System.Drawing

Public Class Customise_Player
    Dim reddrag As Boolean
    Dim bluedrag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim redShipBitmap As Bitmap
    Dim redShipLocation As Point
    Dim blueShipBitmap As Bitmap
    Dim blueShipLocation As Point

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
        blueShipBitmap = New Bitmap(BlueShip.Image)
        blueShipLocation = BlueShip.Location
    End Sub

    Private Sub Customise_Player_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim offScreenBitmap As New Bitmap(Me.Width, Me.Height)
        Using offScreenGraphics As Graphics = Graphics.FromImage(offScreenBitmap)
            offScreenGraphics.DrawImage(redShipBitmap, redShipLocation)
            offScreenGraphics.DrawImage(blueShipBitmap, blueShipLocation)
        End Using

        e.Graphics.DrawImage(offScreenBitmap, 0, 0)
    End Sub

    Private Sub Ship_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If New Rectangle(redShipLocation, redShipBitmap.Size).Contains(e.Location) Then
            reddrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(blueShipLocation, blueShipBitmap.Size).Contains(e.Location) Then
            bluedrag = True
            mousex = e.X
            mousey = e.Y
        End If
    End Sub

    Private Sub Ship_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If reddrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            redShipLocation.X += deltaX
            redShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If redShipLocation.X >= 0 And redShipLocation.X + redShipBitmap.Width <= Me.Width And
               redShipLocation.Y >= 0 And redShipLocation.Y + redShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf bluedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            blueShipLocation.X += deltaX
            blueShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If blueShipLocation.X >= 0 And blueShipLocation.X + blueShipBitmap.Width <= Me.Width And
               blueShipLocation.Y >= 0 And blueShipLocation.Y + blueShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y
        End If
    End Sub

    Private Sub Ship_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If reddrag Then
            If Not New Rectangle(selectedZone.Location, selectedZone.Size).Contains(e.Location) Then
                redShipLocation = RedShip.Location ' Return to original position
            Else
                redShipLocation = selectedZone.Location ' Snap to selectedZone
                blueShipLocation = BlueShip.Location
                selectedShip.Text = "Red Ship"
            End If
        ElseIf bluedrag Then
            If Not New Rectangle(selectedZone.Location, selectedZone.Size).Contains(e.Location) Then
                blueShipLocation = BlueShip.Location ' Return to original position
            Else
                blueShipLocation = selectedZone.Location ' Snap to selectedZone
                redShipLocation = RedShip.Location
                selectedShip.Text = "Blue Ship"
            End If
        End If

        reddrag = False
        bluedrag = False
        Invalidate() ' Trigger a repaint
    End Sub

End Class