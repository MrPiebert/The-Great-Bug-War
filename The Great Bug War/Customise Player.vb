Imports Microsoft.VisualBasic.Devices
Imports System.Diagnostics.Contracts
Imports System.Drawing
Imports System.IO


Public Class Customise_Player

    Public shipTypeFilePath As String = "shipType.txt"
    Public shotTypeFilePath As String = "shotType.txt"
    Public skillTypeFilePath As String = "skillType.txt"


    Public shipType As String
    Public shotType As String
    Public skillType As String

    Dim shipSelected As Boolean
    Dim shotSelected As Boolean
    Dim skillSelected As Boolean

    Dim reddrag As Boolean
    Dim bluedrag As Boolean
    Dim orangedrag As Boolean
    Dim greendrag As Boolean
    Dim purpledrag As Boolean
    Dim blackdrag As Boolean

    Dim stingTypedrag As Boolean
    Dim wingTypedrag As Boolean
    Dim stringTypedrag As Boolean

    Dim carapacedrag As Boolean
    Dim buzzdrag As Boolean
    Dim hosedrag As Boolean

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

    Dim stingTypeBitmap As Bitmap
    Dim wingTypeBitmap As Bitmap
    Dim stringTypeBitmap As Bitmap
    Dim stingTypeLocation As Point
    Dim wingTypeLocation As Point
    Dim stringTypeLocation As Point

    Dim carapaceBitmap As Bitmap
    Dim buzzBitmap As Bitmap
    Dim hoseBitmap As Bitmap
    Dim carapaceLocation As Point
    Dim buzzLocation As Point
    Dim hoseLocation As Point

    Dim selectedZoneCenter As New Point(301, 180) ' Center of the selection zone
    Dim selectedZoneSize As New Size(55, 55) ' Size of the selection zone (square)
    Dim shotZoneCenter As New Point(241, 180) ' Center of the shot selection zone
    Dim shotZoneSize As New Size(30, 55) ' Size of the shot selection zone (square)
    Dim skillZoneCenter As New Point(361, 180) ' Center of the skill selection zone
    Dim skillZoneSize As New Size(30, 55) ' Size of the skill selection zone (square)
    Public Sub New()
        InitializeComponent()
        Me.DoubleBuffered = True
    End Sub

    Private Sub BackBtn_Click(sender As Object, e As EventArgs) Handles BackBtn.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub Customise_Player_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ClearFile(shipTypeFilePath)
        ClearFile(shotTypeFilePath)
        ClearFile(skillTypeFilePath)
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

        stingTypeBitmap = New Bitmap(StingType.Image)
        stingTypeLocation = StingType.Location
        wingTypeBitmap = New Bitmap(WingType.Image)
        wingTypeLocation = WingType.Location
        stringTypeBitmap = New Bitmap(StringType.Image)
        stringTypeLocation = StringType.Location

        carapaceBitmap = New Bitmap(Carapace.Image, 50, 50)
        carapaceLocation = Carapace.Location
        buzzBitmap = New Bitmap(Buzz.Image, 50, 50)
        buzzLocation = Buzz.Location
        hoseBitmap = New Bitmap(Hose.Image, 45, 45)
        hoseLocation = Hose.Location
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

            offScreenGraphics.DrawImage(stingTypeBitmap, stingTypeLocation)
            offScreenGraphics.DrawImage(wingTypeBitmap, wingTypeLocation)
            offScreenGraphics.DrawImage(stringTypeBitmap, stringTypeLocation)

            offScreenGraphics.DrawImage(carapaceBitmap, carapaceLocation)
            offScreenGraphics.DrawImage(buzzBitmap, buzzLocation)
            offScreenGraphics.DrawImage(hoseBitmap, hoseLocation)
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
                shipSelected = False
            End If

            Dim shotZoneRect As New Rectangle(shotZoneCenter.X - shotZoneSize.Width / 2, shotZoneCenter.Y - shotZoneSize.Height / 2, shotZoneSize.Width, shotZoneSize.Height)
            offScreenGraphics.DrawRectangle(Pens.White, shotZoneRect)
            ' Check if there's any ship inside the selection zone
            Dim anyShotInZone As Boolean = shotZoneRect.IntersectsWith(New Rectangle(stingTypeLocation, stingTypeBitmap.Size)) OrElse
                                      shotZoneRect.IntersectsWith(New Rectangle(wingTypeLocation, wingTypeBitmap.Size)) OrElse
                                      shotZoneRect.IntersectsWith(New Rectangle(stringTypeLocation, stringTypeBitmap.Size))

            If Not anyShotInZone Then
                selectedShot.Text = "No Weapon"
                shotSelected = False
            End If

            Dim skillZoneRect As New Rectangle(skillZoneCenter.X - skillZoneSize.Width / 2, skillZoneCenter.Y - skillZoneSize.Height / 2, skillZoneSize.Width, skillZoneSize.Height)
            offScreenGraphics.DrawRectangle(Pens.White, skillZoneRect)
            ' Check if there's any ship inside the selection zone
            Dim anySkillInZone As Boolean = skillZoneRect.IntersectsWith(New Rectangle(carapaceLocation, carapaceBitmap.Size)) OrElse
                                      skillZoneRect.IntersectsWith(New Rectangle(buzzLocation, buzzBitmap.Size)) OrElse
                                      skillZoneRect.IntersectsWith(New Rectangle(hoseLocation, hoseBitmap.Size))

            If Not anySkillInZone Then
                selectedSkill.Text = "No Skill"
                skillSelected = False
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
        ElseIf New Rectangle(stringTypeLocation, stringTypeBitmap.Size).Contains(e.Location) Then
            stringTypedrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(wingTypeLocation, wingTypeBitmap.Size).Contains(e.Location) Then
            wingTypedrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(stingTypeLocation, stingTypeBitmap.Size).Contains(e.Location) Then
            stingTypedrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(carapaceLocation, carapaceBitmap.Size).Contains(e.Location) Then
            carapacedrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(buzzLocation, buzzBitmap.Size).Contains(e.Location) Then
            buzzdrag = True
            mousex = e.X
            mousey = e.Y
        ElseIf New Rectangle(hoseLocation, hoseBitmap.Size).Contains(e.Location) Then
            hosedrag = True
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

        ElseIf stringTypedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            stringTypeLocation.X += deltaX
            stringTypeLocation.Y += deltaY

            ' Check if the new location is within the form
            If stringTypeLocation.X >= 0 And stringTypeLocation.X + stringTypeBitmap.Width <= Me.Width And
               stringTypeLocation.Y >= 0 And stringTypeLocation.Y + stringTypeBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf wingTypedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            wingTypeLocation.X += deltaX
            wingTypeLocation.Y += deltaY

            ' Check if the new location is within the form
            If wingTypeLocation.X >= 0 And wingTypeLocation.X + wingTypeBitmap.Width <= Me.Width And
               wingTypeLocation.Y >= 0 And wingTypeLocation.Y + wingTypeBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf stingTypedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            stingTypeLocation.X += deltaX
            stingTypeLocation.Y += deltaY

            ' Check if the new location is within the form
            If stingTypeLocation.X >= 0 And stingTypeLocation.X + stingTypeBitmap.Width <= Me.Width And
               stingTypeLocation.Y >= 0 And stingTypeLocation.Y + stingTypeBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y
        ElseIf carapacedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            carapaceLocation.X += deltaX
            carapaceLocation.Y += deltaY

            ' Check if the new location is within the form
            If carapaceLocation.X >= 0 And carapaceLocation.X + carapaceBitmap.Width <= Me.Width And
               carapaceLocation.Y >= 0 And carapaceLocation.Y + carapaceBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf buzzdrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            buzzLocation.X += deltaX
            buzzLocation.Y += deltaY

            ' Check if the new location is within the form
            If buzzLocation.X >= 0 And buzzLocation.X + buzzBitmap.Width <= Me.Width And
               buzzLocation.Y >= 0 And buzzLocation.Y + buzzBitmap.Height <= Me.Height Then

                Invalidate() ' Invalidate the form to trigger a repaint
            End If

            mousex = e.X
            mousey = e.Y

        ElseIf hosedrag Then
            Dim deltaX As Integer = e.X - mousex
            Dim deltaY As Integer = e.Y - mousey

            hoseLocation.X += deltaX
            hoseLocation.Y += deltaY

            ' Check if the new location is within the form
            If hoseLocation.X >= 0 And hoseLocation.X + hoseBitmap.Width <= Me.Width And
               hoseLocation.Y >= 0 And hoseLocation.Y + hoseBitmap.Height <= Me.Height Then

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
                shipType = "Red Ship"
                shipSelected = True
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
                shipType = "Blue Ship"
                shipSelected = True
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
                shipType = "Orange Ship"
                shipSelected = True
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
                shipType = "Green Ship"
                shipSelected = True
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
                shipType = "Purple Ship"
                shipSelected = True
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
                shipType = "Black Ship"
                shipSelected = True
            End If


        ElseIf stingTypedrag Then
            Dim stingTypeRect As New Rectangle(stingTypeLocation.X - stingTypeBitmap.Width / 2, stingTypeLocation.Y - stingTypeBitmap.Height / 2, stingTypeBitmap.Width, stingTypeBitmap.Height)

            If Not New Rectangle(shotZoneCenter.X - shotZoneSize.Width / 2, shotZoneCenter.Y - shotZoneSize.Height / 2, shotZoneSize.Width, shotZoneSize.Height).IntersectsWith(stingTypeRect) Then
                stingTypeLocation = StingType.Location ' Return to original position
            Else
                stingTypeLocation = New Point(shotZoneCenter.X - stingTypeBitmap.Width / 2, shotZoneCenter.Y - stingTypeBitmap.Height / 2) ' Snap to selectedZone
                wingTypeLocation = WingType.Location
                stringTypeLocation = StringType.Location
                selectedShot.Text = "Sting Type"
                shotType = "Sting Type"
                shotSelected = True
            End If
        ElseIf wingTypedrag Then
            Dim wingTypeRect As New Rectangle(wingTypeLocation.X - wingTypeBitmap.Width / 2, wingTypeLocation.Y - wingTypeBitmap.Height / 2, wingTypeBitmap.Width, wingTypeBitmap.Height)

            If Not New Rectangle(shotZoneCenter.X - shotZoneSize.Width / 2, shotZoneCenter.Y - shotZoneSize.Height / 2, shotZoneSize.Width, shotZoneSize.Height).IntersectsWith(wingTypeRect) Then
                wingTypeLocation = WingType.Location ' Return to original position
            Else
                wingTypeLocation = New Point(shotZoneCenter.X - wingTypeBitmap.Width / 2, shotZoneCenter.Y - wingTypeBitmap.Height / 2) ' Snap to shotZone
                stingTypeLocation = StingType.Location
                stringTypeLocation = StringType.Location
                selectedShot.Text = "Wing Type"
                shotType = "Wing Type"
                shotSelected = True
            End If

        ElseIf stringTypedrag Then
            Dim stringTypeRect As New Rectangle(stringTypeLocation.X - stringTypeBitmap.Width / 2, stringTypeLocation.Y - stringTypeBitmap.Height / 2, stringTypeBitmap.Width, stringTypeBitmap.Height)

            If Not New Rectangle(shotZoneCenter.X - shotZoneSize.Width / 2, shotZoneCenter.Y - shotZoneSize.Height / 2, shotZoneSize.Width, shotZoneSize.Height).IntersectsWith(stringTypeRect) Then
                stringTypeLocation = StringType.Location ' Return to original position
            Else
                stringTypeLocation = New Point(shotZoneCenter.X - stringTypeBitmap.Width / 2, shotZoneCenter.Y - stringTypeBitmap.Height / 2) ' Snap to shotZone
                stingTypeLocation = StingType.Location
                wingTypeLocation = WingType.Location
                selectedShot.Text = "String Type"
                shotType = "String Type"
                shotSelected = True
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
                shipType = "Blue Ship"
                shipSelected = True
            End If

        ElseIf carapacedrag Then
            Dim carapaceRect As New Rectangle(carapaceLocation.X - carapaceBitmap.Width / 2, carapaceLocation.Y - carapaceBitmap.Height / 2, carapaceBitmap.Width, carapaceBitmap.Height)

            If Not New Rectangle(skillZoneCenter.X - skillZoneSize.Width / 2, skillZoneCenter.Y - skillZoneSize.Height / 2, skillZoneSize.Width, skillZoneSize.Height).IntersectsWith(carapaceRect) Then
                carapaceLocation = Carapace.Location ' Return to original position
            Else
                carapaceLocation = New Point(skillZoneCenter.X - hoseBitmap.Width / 2, skillZoneCenter.Y - hoseBitmap.Height / 2) ' Snap to selectedZone
                buzzLocation = Buzz.Location
                hoseLocation = Hose.Location
                selectedSkill.Text = "Carapace"
                skillType = "Carapace"
                skillSelected = True
            End If

        ElseIf buzzdrag Then
            Dim buzzRect As New Rectangle(buzzLocation.X - buzzBitmap.Width / 2, buzzLocation.Y - buzzBitmap.Height / 2, buzzBitmap.Width, buzzBitmap.Height)

            If Not New Rectangle(skillZoneCenter.X - skillZoneSize.Width / 2, skillZoneCenter.Y - skillZoneSize.Height / 2, skillZoneSize.Width, skillZoneSize.Height).IntersectsWith(buzzRect) Then
                buzzLocation = Buzz.Location ' Return to original position
            Else
                buzzLocation = New Point(skillZoneCenter.X - hoseBitmap.Width / 2, skillZoneCenter.Y - hoseBitmap.Height / 2) ' Snap to selectedZone
                carapaceLocation = Carapace.Location
                hoseLocation = Hose.Location
                selectedSkill.Text = "Buzz"
                skillType = "Buzz"
                skillSelected = True
            End If

        ElseIf hosedrag Then
            Dim hoseRect As New Rectangle(hoseLocation.X - hoseBitmap.Width / 2, hoseLocation.Y - hoseBitmap.Height / 2, hoseBitmap.Width, hoseBitmap.Height)

            If Not New Rectangle(skillZoneCenter.X - skillZoneSize.Width / 2, skillZoneCenter.Y - skillZoneSize.Height / 2, skillZoneSize.Width, skillZoneSize.Height).IntersectsWith(hoseRect) Then
                hoseLocation = Hose.Location ' Return to original position
            Else
                hoseLocation = New Point(skillZoneCenter.X - hoseBitmap.Width / 2, skillZoneCenter.Y - hoseBitmap.Height / 2) ' Snap to selectedZone
                carapaceLocation = Carapace.Location
                buzzLocation = Buzz.Location
                selectedSkill.Text = "Hose Blast"
                skillType = "Hose"
                skillSelected = True
            End If
        End If
        reddrag = False
        bluedrag = False
        orangedrag = False
        greendrag = False
        purpledrag = False
        blackdrag = False
        stingTypedrag = False
        wingTypedrag = False
        stringTypedrag = False
        carapacedrag = False
        buzzdrag = False
        hosedrag = False

        Invalidate() ' Trigger a repaint
    End Sub

    Private Sub WriteToFile(filePath As String, content As String)
        ' Write the content to the specified file
        Using writer As StreamWriter = New StreamWriter(filePath, False)
            writer.WriteLine(content)
        End Using
    End Sub

    Private Sub ClearFile(filePath As String)
        ' Clear the content of the specified file
        Using writer As StreamWriter = New StreamWriter(filePath, False)
            writer.Write(String.Empty)
        End Using
    End Sub

    Private Sub BeginBtn_Click(sender As Object, e As EventArgs) Handles BeginBtn.Click
        If shipSelected AndAlso shotSelected AndAlso skillSelected Then
            WriteToFile(shipTypeFilePath, shipType)
            WriteToFile(shotTypeFilePath, shotType)
            WriteToFile(skillTypeFilePath, skillType)
            Me.Close()
            Form1.Close()
            Try
                ' Specify the path to the .exe file you want to run
                Dim exePath As String = "C:\Users\mrpie\source\repos\MonoGameVBExample\MonoGameVBExample\bin\Debug\net6.0\MonoGameVBExample.exe"

                ' Check if the .exe file exists
                If File.Exists(exePath) Then
                    ' Run the .exe file
                    Dim processInfo As New ProcessStartInfo()
                    processInfo.FileName = exePath
                    Process.Start(processInfo)
                Else
                    MessageBox.Show("The specified .exe file does not exist.")
                End If
            Catch ex As Exception
                MessageBox.Show("An error occurred while attempting to run the .exe file: " & ex.Message)
            End Try
        End If
    End Sub
End Class