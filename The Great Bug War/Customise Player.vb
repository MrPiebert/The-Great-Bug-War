Imports Microsoft.VisualBasic.Devices
Imports System.Drawing

Public Class Customise_Player
    Dim reddrag As Boolean
    Dim bluedrag As Boolean
    Dim orangedrag As Boolean
    Dim greendrag As Boolean
    Dim purpledrag As Boolean
    Dim blackdrag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim redShipBitmap As Bitmap
    Dim redShipLocation As Point
    Dim blueShipBitmap As Bitmap
    Dim blueShipLocation As Point
    Dim orangeShipBitmap As Bitmap
    Dim orangeShipLocation As Point
    Dim greenShipBitmap As Bitmap
    Dim greenShipLocation As Point
    Dim purpleShipBitmap As Bitmap
    Dim purpleShipLocation As Point
    Dim blackShipBitmap As Bitmap
    Dim blackShipLocation As Point
    Dim selectedZoneCenter As New Point(301, 180) ' Center of the selection zone
    Dim selectedZoneSize As New Size(55, 55) ' Size of the selection zone (square)

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
        orangeShipBitmap = New Bitmap(OrangeShip.Image)
        orangeShipLocation = OrangeShip.Location
        greenShipBitmap = New Bitmap(GreenShip.Image)
        greenShipLocation = GreenShip.Location
        purpleShipBitmap = New Bitmap(PurpleShip.Image)
        purpleShipLocation = PurpleShip.Location
        blackShipBitmap = New Bitmap(BlackShip.Image)
        blackShipLocation = BlackShip.Location
    End Sub

    Private Sub Customise_Player_Paint(sender As Object, e As PaintEventArgs) Handles MyBase.Paint
        Dim offScreenBitmap As New Bitmap(Me.Width, Me.Height)
        Using offScreenGraphics As Graphics = Graphics.FromImage(offScreenBitmap)
            offScreenGraphics.DrawImage(redShipBitmap, redShipLocation)
            offScreenGraphics.DrawImage(blueShipBitmap, blueShipLocation)
            offScreenGraphics.DrawImage(orangeShipBitmap, orangeShipLocation)
            offScreenGraphics.DrawImage(greenShipBitmap, greenShipLocation)
            offScreenGraphics.DrawImage(purpleShipBitmap, purpleShipLocation)
            offScreenGraphics.DrawImage(blackShipBitmap, blackShipLocation)
            Dim selectionZoneRect As New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height)
            offScreenGraphics.DrawRectangle(Pens.White, selectionZoneRect)
            ' Check if there's any ship inside the selection zone
            Dim anyShipInZone As Boolean = selectionZoneRect.IntersectsWith(New Rectangle(redShipLocation, redShipBitmap.Size)) OrElse
                                      selectionZoneRect.IntersectsWith(New Rectangle(blueShipLocation, blueShipBitmap.Size)) OrElse
                                      selectionZoneRect.IntersectsWith(New Rectangle(orangeShipLocation, orangeShipBitmap.Size)) OrElse
                                      selectionZoneRect.IntersectsWith(New Rectangle(greenShipLocation, greenShipBitmap.Size)) OrElse
                                      selectionZoneRect.IntersectsWith(New Rectangle(purpleShipLocation, purpleShipBitmap.Size)) OrElse
                                      selectionZoneRect.IntersectsWith(New Rectangle(blackShipLocation, blackShipBitmap.Size))

            If Not anyShipInZone Then
                selectedShip.Text = "No Ship"
            End If
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
        ElseIf New Rectangle(orangeShipLocation, orangeShipBitmap.Size).Contains(e.Location) Then
            orangedrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(greenShipLocation, greenShipBitmap.Size).Contains(e.Location) Then
            greendrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(purpleShipLocation, purpleShipBitmap.Size).Contains(e.Location) Then
            purpledrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(blackShipLocation, blackShipBitmap.Size).Contains(e.Location) Then
            blackdrag = True
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

        ElseIf orangedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            orangeShipLocation.X += deltaX
            orangeShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If orangeShipLocation.X >= 0 And orangeShipLocation.X + orangeShipBitmap.Width <= Me.Width And
               orangeShipLocation.Y >= 0 And orangeShipLocation.Y + orangeShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf greendrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            greenShipLocation.X += deltaX
            greenShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If greenShipLocation.X >= 0 And greenShipLocation.X + greenShipBitmap.Width <= Me.Width And
       greenShipLocation.Y >= 0 And greenShipLocation.Y + greenShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf purpledrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            purpleShipLocation.X += deltaX
            purpleShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If purpleShipLocation.X >= 0 And purpleShipLocation.X + purpleShipBitmap.Width <= Me.Width And
       purpleShipLocation.Y >= 0 And purpleShipLocation.Y + purpleShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf blackdrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            blackShipLocation.X += deltaX
            blackShipLocation.Y += deltaY

            ' Check if the new location is within the form
            If blackShipLocation.X >= 0 And blackShipLocation.X + blackShipBitmap.Width <= Me.Width And
       blackShipLocation.Y >= 0 And blackShipLocation.Y + blackShipBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        End If
    End Sub

    Private Sub Ship_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If reddrag Then
            Dim redShipRect As New Rectangle(redShipLocation.X - redShipBitmap.Width / 2, redShipLocation.Y - redShipBitmap.Height / 2, redShipBitmap.Width, redShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(redShipRect) Then
                redShipLocation = RedShip.Location ' Return to original position
            Else
                redShipLocation = New Point(selectedZoneCenter.X - redShipBitmap.Width / 2, selectedZoneCenter.Y - redShipBitmap.Height / 2) ' Snap to selectedZone
                blueShipLocation = BlueShip.Location
                orangeShipLocation = OrangeShip.Location
                greenShipLocation = GreenShip.Location
                blackShipLocation = BlackShip.Location
                purpleShipLocation = PurpleShip.Location
                selectedShip.Text = "Red Ship"
            End If
        ElseIf bluedrag Then
            Dim blueShipRect As New Rectangle(blueShipLocation.X - blueShipBitmap.Width / 2, blueShipLocation.Y - blueShipBitmap.Height / 2, blueShipBitmap.Width, blueShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(blueShipRect) Then
                blueShipLocation = BlueShip.Location ' Return to original position
            Else
                blueShipLocation = New Point(selectedZoneCenter.X - blueShipBitmap.Width / 2, selectedZoneCenter.Y - blueShipBitmap.Height / 2) ' Snap to selectedZone
                redShipLocation = RedShip.Location
                orangeShipLocation = OrangeShip.Location
                greenShipLocation = GreenShip.Location
                blackShipLocation = BlackShip.Location
                purpleShipLocation = PurpleShip.Location
                selectedShip.Text = "Blue Ship"
            End If

        ElseIf orangedrag Then
            Dim orangeShipRect As New Rectangle(orangeShipLocation.X - orangeShipBitmap.Width / 2, orangeShipLocation.Y - orangeShipBitmap.Height / 2, orangeShipBitmap.Width, orangeShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(orangeShipRect) Then
                orangeShipLocation = OrangeShip.Location ' Return to original position
            Else
                orangeShipLocation = New Point(selectedZoneCenter.X - orangeShipBitmap.Width / 2, selectedZoneCenter.Y - orangeShipBitmap.Height / 2) ' Snap to selectedZone
                ' Handle snapping behavior for other ships (e.g., reset their locations)
                redShipLocation = RedShip.Location
                blueShipLocation = BlueShip.Location
                greenShipLocation = GreenShip.Location
                blackShipLocation = BlackShip.Location
                purpleShipLocation = PurpleShip.Location
                selectedShip.Text = "Orange Ship"
            End If

        ElseIf greendrag Then
            Dim greenShipRect As New Rectangle(greenShipLocation.X - greenShipBitmap.Width / 2, greenShipLocation.Y - greenShipBitmap.Height / 2, greenShipBitmap.Width, greenShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(greenShipRect) Then
                greenShipLocation = GreenShip.Location ' Return to original position
            Else
                greenShipLocation = New Point(selectedZoneCenter.X - greenShipBitmap.Width / 2, selectedZoneCenter.Y - greenShipBitmap.Height / 2) ' Snap to selectedZone
                redShipLocation = RedShip.Location
                blueShipLocation = BlueShip.Location
                orangeShipLocation = OrangeShip.Location
                blackShipLocation = BlackShip.Location
                purpleShipLocation = PurpleShip.Location
                selectedShip.Text = "Green Ship"
            End If

        ElseIf purpledrag Then
            Dim purpleShipRect As New Rectangle(purpleShipLocation.X - purpleShipBitmap.Width / 2, purpleShipLocation.Y - purpleShipBitmap.Height / 2, purpleShipBitmap.Width, purpleShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(purpleShipRect) Then
                purpleShipLocation = PurpleShip.Location ' Return to original position
            Else
                purpleShipLocation = New Point(selectedZoneCenter.X - purpleShipBitmap.Width / 2, selectedZoneCenter.Y - purpleShipBitmap.Height / 2) ' Snap to selectedZone
                redShipLocation = RedShip.Location
                blueShipLocation = BlueShip.Location
                orangeShipLocation = OrangeShip.Location
                blackShipLocation = BlackShip.Location
                greenShipLocation = GreenShip.Location
                selectedShip.Text = "Purple Ship"
            End If

        ElseIf blackdrag Then
            Dim blackShipRect As New Rectangle(blackShipLocation.X - blackShipBitmap.Width / 2, blackShipLocation.Y - blackShipBitmap.Height / 2, blackShipBitmap.Width, blackShipBitmap.Height)

            If Not New Rectangle(selectedZoneCenter.X - selectedZoneSize.Width / 2, selectedZoneCenter.Y - selectedZoneSize.Height / 2, selectedZoneSize.Width, selectedZoneSize.Height).IntersectsWith(blackShipRect) Then
                blackShipLocation = BlackShip.Location ' Return to original position
            Else
                blackShipLocation = New Point(selectedZoneCenter.X - blackShipBitmap.Width / 2, selectedZoneCenter.Y - blackShipBitmap.Height / 2) ' Snap to selectedZone
                redShipLocation = RedShip.Location
                blueShipLocation = BlueShip.Location
                orangeShipLocation = OrangeShip.Location
                greenShipLocation = GreenShip.Location
                purpleShipLocation = PurpleShip.Location
                selectedShip.Text = "Black Ship"
            End If
        End If
        reddrag = False
        bluedrag = False
        orangedrag = False
        greendrag = False
        purpledrag = False
        blackdrag = False
        Invalidate() ' Trigger a repaint
    End Sub

End Class