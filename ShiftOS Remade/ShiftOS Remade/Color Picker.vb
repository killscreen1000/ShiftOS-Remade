Public Class Color_Picker
    Public colortochange As String
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
#Region "Template Code"
    Private Sub titlebar_MouseDown(sender As Object, e As MouseEventArgs) Handles titlebar.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub titlebar_MouseMove(sender As Object, e As MouseEventArgs) Handles titlebar.MouseMove
        If e.Button = MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (Y)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub titlebar_MouseUp(sender As Object, e As MouseEventArgs) Handles titlebar.MouseUp

    End Sub

    Private Sub Color_Picker_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        Select Case colortochange
            Case "Close Button Color"
                pnloldcolour.BackColor = closebutton.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = closebutton.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & closebutton.BackColor.R & ", " & closebutton.BackColor.G & ", " & closebutton.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Titlebar Color"
                pnloldcolour.BackColor = titlebar.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = titlebar.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & titlebar.BackColor.R & ", " & titlebar.BackColor.G & ", " & titlebar.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Border Color"
                pnloldcolour.BackColor = pgbottom.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = pgbottom.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & pgbottom.BackColor.R & ", " & pgbottom.BackColor.G & ", " & pgbottom.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Titlebar Text Color"
                pnloldcolour.BackColor = lbtitletext.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = lbtitletext.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & lbtitletext.ForeColor.R & ", " & lbtitletext.ForeColor.G & ", " & lbtitletext.ForeColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Desktop Background Color"
                pnloldcolour.BackColor = ShiftOSDesktop.desktopiconsbackground.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.desktopiconsbackground.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.desktopiconsbackground.BackColor.R & ", " & ShiftOSDesktop.desktopiconsbackground.BackColor.G & ", " & ShiftOSDesktop.desktopiconsbackground.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Desktop Panel Color"
                pnloldcolour.BackColor = ShiftOSDesktop.FLP.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.FLP.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.FLP.BackColor.R & ", " & ShiftOSDesktop.FLP.BackColor.G & ", " & ShiftOSDesktop.FLP.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Menu Color"
                pnloldcolour.BackColor = ShiftOSDesktop.CLOCK.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.CLOCK.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.CLOCK.BackColor.R & ", " & ShiftOSDesktop.CLOCK.BackColor.G & ", " & ShiftOSDesktop.CLOCK.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Menu Button Color"
                pnloldcolour.BackColor = ShiftOSDesktop.MenuStrip1.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.MenuStrip1.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.MenuStrip1.BackColor.R & ", " & ShiftOSDesktop.MenuStrip1.BackColor.G & ", " & ShiftOSDesktop.MenuStrip1.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Panel Clock Background Color"
                pnloldcolour.BackColor = ShiftOSDesktop.timepanel.BackColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.timepanel.BackColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.timepanel.BackColor.R & ", " & ShiftOSDesktop.timepanel.BackColor.G & ", " & ShiftOSDesktop.timepanel.BackColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Panel Clock Text Color"
                pnloldcolour.BackColor = ShiftOSDesktop.timepanel.ForeColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.timepanel.ForeColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.timepanel.ForeColor.R & ", " & ShiftOSDesktop.timepanel.ForeColor.G & ", " & ShiftOSDesktop.timepanel.ForeColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Launcher Text Color"
                pnloldcolour.BackColor = ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor.R & ", " & ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor.G & ", " & ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
            Case "Launcher Menu Text Color"
                pnloldcolour.BackColor = ShiftOSDesktop.CLOCK.ForeColor
                lblobjecttocolour.Text = colortochange
                lbloldcolourname.Text = ShiftOSDesktop.CLOCK.ForeColor.Name
                lbloldcolourrgb.Text = "RGB: " & ShiftOSDesktop.CLOCK.ForeColor.R & ", " & ShiftOSDesktop.CLOCK.ForeColor.G & ", " & ShiftOSDesktop.CLOCK.ForeColor.B
                lblnewcolourname.Text = "White"
                lblnewcolourrgb.Text = "RGB: 255, 255, 255"
        End Select

        closebutton.BackColor = My.Settings.closecolor
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
        Else
            titlebar.Visible = False
        End If
        If My.Settings.BoughtBorders = True Then
            pgbottom.Visible = True
            pgleft.Visible = True
            pgright.Visible = True
            pgbottomlcorner.Visible = False
            pgbottomrcorner.Visible = False
            pgtoplcorner.Visible = False
            pgtoprcorner.Visible = False
        End If
        If My.Settings.BoughtCloseButton = True Then
            closebutton.Visible = True
        End If
        If My.Settings.BoughtTitlebarText = True Then
            lbtitletext.Visible = True
        End If
        If My.Settings.BoughtTitlebarText = False Then
            lbtitletext.Visible = False
        End If
#Region "Making colors appear depending on upgrades and colors bought"
        If My.Settings.BoughtGrayShades = False Then
            pnlgray1.Visible = True
            pnlgray1.BackColor = Color.Black
            pnlgray2.Visible = True
            pnlgray2.BackColor = Color.Gray
            pnlgray3.Visible = True
            pnlgray3.BackColor = Color.White
            lblgraylevel.Text = "Level 1"
        End If
        If My.Settings.BoughtGrayShades = True Then
            pnlgray1.Visible = True
            pnlgray1.BackColor = Color.Black
            pnlgray2.Visible = True
            pnlgray2.BackColor = Color.DimGray
            pnlgray3.Visible = True
            pnlgray3.BackColor = Color.Gray
            pnlgray4.Visible = True
            pnlgray4.BackColor = Color.LightGray
            pnlgray5.Visible = True
            pnlgray5.BackColor = Color.White
            lblgraylevel.Text = "Level 2"
        End If
        If My.Settings.BoughtGraySet = True Then
            pnlgray1.Visible = True
            pnlgray1.BackColor = Color.Black
            pnlgray2.Visible = True
            pnlgray2.BackColor = Color.DimGray
            pnlgray3.Visible = True
            pnlgray3.BackColor = Color.Gray
            pnlgray4.Visible = True
            pnlgray4.BackColor = Color.Silver
            pnlgray5.Visible = True
            pnlgray5.BackColor = Color.LightGray
            pnlgray6.Visible = True
            pnlgray6.BackColor = Color.Gainsboro
            pnlgray7.Visible = True
            pnlgray7.BackColor = Color.WhiteSmoke
            pnlgray8.Visible = True
            pnlgray8.BackColor = Color.White
            lblgraylevel.Text = "Level 3"
        End If
        If My.Settings.BoughtRed = True Then
            pnlredcolours.Visible = True
            pnlred1.Visible = True
            pnlred1.BackColor = Color.Red
            lblredlevel.Text = "Level 1"
        End If
        If My.Settings.BoughtRedShades = True Then
            pnlred1.Visible = True
            pnlred1.BackColor = Color.DarkRed
            pnlred2.Visible = True
            pnlred2.BackColor = Color.Red
            pnlred3.Visible = True
            pnlred3.BackColor = Color.Salmon
            lblredlevel.Text = "Level 2"
        End If
        If My.Settings.BoughtRedSet = True Then
            pnlred1.Visible = True
            pnlred2.Visible = True
            pnlred3.Visible = True
            pnlred4.Visible = True
            pnlred5.Visible = True
            pnlred6.Visible = True
            pnlred7.Visible = True
            pnlred8.Visible = True
            pnlred9.Visible = True
            pnlred1.BackColor = Color.DarkRed
            pnlred2.BackColor = Color.Red
            pnlred3.BackColor = Color.Firebrick
            pnlred4.BackColor = Color.Crimson
            pnlred5.BackColor = Color.IndianRed
            pnlred6.BackColor = Color.LightCoral
            pnlred7.BackColor = Color.DarkSalmon
            pnlred8.BackColor = Color.Salmon
            pnlred9.BackColor = Color.LightSalmon
            lblredlevel.Text = "Level 3"
        End If
        If My.Settings.BoughtOrange = True Then
            pnlorangecolours.Visible = True
            pnlorange1.Visible = True
            pnlorange1.BackColor = Color.Orange
            lblorangelevel.Text = "Level 1"
        End If
        If My.Settings.BoughtOrangeShades = True Then
            pnlorange1.Visible = True
            pnlorange2.Visible = True
            pnlorange3.Visible = True
            pnlorange1.BackColor = Color.OrangeRed
            pnlorange2.BackColor = Color.DarkOrange
            pnlorange3.BackColor = Color.Orange
            lblorangelevel.Text = "Level 2"
        End If
        If My.Settings.BoughtOrangeSet = True Then
            pnlorange1.Visible = True
            pnlorange2.Visible = True
            pnlorange3.Visible = True
            pnlorange4.Visible = True
            pnlorange5.Visible = True
            pnlorange6.Visible = True
            pnlorange1.BackColor = Color.OrangeRed
            pnlorange2.BackColor = Color.Tomato
            pnlorange3.BackColor = Color.Coral
            pnlorange4.BackColor = Color.DarkOrange
            pnlorange5.BackColor = Color.Orange
            pnlorange6.BackColor = Color.Gold
            lblorangelevel.Text = "Level 3"
        End If
        If My.Settings.BoughtYellow = True Then
            pnlyellowcolours.Visible = True
            pnlyellow1.Visible = True
            pnlyellow1.BackColor = Color.Yellow
            lblyellowlevel.Text = "Level 1"
        End If
        If My.Settings.BoughtYellowShades = True Then
            pnlyellow1.Visible = True
            pnlyellow2.Visible = True
            pnlyellow3.Visible = True
            pnlyellow1.BackColor = Color.DarkKhaki
            pnlyellow2.BackColor = Color.Yellow
            pnlyellow3.BackColor = Color.PaleGoldenrod
            lblyellowlevel.Text = "Level 2"
        End If
        If My.Settings.BoughtYellowSet = True Then
            pnlyellow1.Visible = True
            pnlyellow2.Visible = True
            pnlyellow3.Visible = True
            pnlyellow4.Visible = True
            pnlyellow5.Visible = True
            pnlyellow6.Visible = True
            pnlyellow7.Visible = True
            pnlyellow8.Visible = True
            pnlyellow9.Visible = True
            pnlyellow10.Visible = True
            pnlyellow1.BackColor = Color.DarkKhaki
            pnlyellow2.BackColor = Color.Yellow
            pnlyellow3.BackColor = Color.Khaki
            pnlyellow4.BackColor = Color.PaleGoldenrod
            pnlyellow5.BackColor = Color.PeachPuff
            pnlyellow6.BackColor = Color.Moccasin
            pnlyellow7.BackColor = Color.PapayaWhip
            pnlyellow8.BackColor = Color.LightGoldenrodYellow
            pnlyellow9.BackColor = Color.LemonChiffon
            pnlyellow10.BackColor = Color.LightYellow
            lblyellowlevel.Text = "Level 3"
        End If
        If My.Settings.BoughtGreen = True Then
            pnlgreencolours.Visible = True
            pnlgreen1.Visible = True
            pnlgreen1.BackColor = Color.Green
            lblgreenlevel.Text = "Level 1"
        End If
        If My.Settings.BoughtGreenShades = True Then
            pnlgreen1.Visible = True
            pnlgreen2.Visible = True
            pnlgreen3.Visible = True
            pnlgreen1.BackColor = Color.DarkGreen
            pnlgreen2.BackColor = Color.Green
            pnlgreen3.BackColor = Color.LightGreen
            lblgreenlevel.Text = "Level 2"
        End If
        If My.Settings.BoughtGreenSet = True Then
            pnlgreen1.Visible = True
            pnlgreen2.Visible = True
            pnlgreen3.Visible = True
            pnlgreen4.Visible = True
            pnlgreen5.Visible = True
            pnlgreen6.Visible = True
            pnlgreen7.Visible = True
            pnlgreen8.Visible = True
            pnlgreen9.Visible = True
            pnlgreen10.Visible = True
            pnlgreen11.Visible = True
            pnlgreen12.Visible = True
            pnlgreen13.Visible = True
            pnlgreen14.Visible = True
            pnlgreen15.Visible = True
            pnlgreen16.Visible = True
            pnlgreen1.BackColor = Color.DarkGreen
            pnlgreen2.BackColor = Color.Green
            pnlgreen3.BackColor = Color.SeaGreen
            pnlgreen4.BackColor = Color.MediumSeaGreen
            pnlgreen5.BackColor = Color.DarkSeaGreen
            pnlgreen6.BackColor = Color.LightGreen
            pnlgreen7.BackColor = Color.MediumSpringGreen
            pnlgreen8.BackColor = Color.SpringGreen
            pnlgreen9.BackColor = Color.GreenYellow
            pnlgreen10.BackColor = Color.LawnGreen
            pnlgreen11.BackColor = Color.Lime
            pnlgreen12.BackColor = Color.LimeGreen
            pnlgreen13.BackColor = Color.YellowGreen
            pnlgreen14.BackColor = Color.OliveDrab
            pnlgreen15.BackColor = Color.Olive
            pnlgreen16.BackColor = Color.DarkOliveGreen
            lblgreenlevel.Text = "Level 3"
        End If
        If My.Settings.BoughtBlue = True Then
            pnlbluecolours.Visible = True
            pnlblue1.Visible = True
            pnlblue1.BackColor = Color.Blue
            lblbluelevel.Text = "Level 1"
        End If
        If My.Settings.BoughtBlueShades = True Then
            pnlblue1.Visible = True
            pnlblue2.Visible = True
            pnlblue3.Visible = True
            pnlblue1.BackColor = Color.Navy
            pnlblue2.BackColor = Color.Blue
            pnlblue3.BackColor = Color.LightBlue
            lblbluelevel.Text = "Level 2"
        End If
        If My.Settings.BoughtBlueSet = True Then
            pnlblue1.Visible = True
            pnlblue1.BackColor = Color.MidnightBlue
            pnlblue2.Visible = True
            pnlblue2.BackColor = Color.Navy
            pnlblue3.Visible = True
            pnlblue3.BackColor = Color.Blue
            pnlblue4.Visible = True
            pnlblue4.BackColor = Color.RoyalBlue
            pnlblue5.Visible = True
            pnlblue5.BackColor = Color.CornflowerBlue
            pnlblue6.Visible = True
            pnlblue6.BackColor = Color.DeepSkyBlue
            pnlblue7.Visible = True
            pnlblue7.BackColor = Color.SkyBlue
            pnlblue8.Visible = True
            pnlblue8.BackColor = Color.LightBlue
            pnlblue9.Visible = True
            pnlblue9.BackColor = Color.LightSteelBlue
            pnlblue10.Visible = True
            pnlblue10.BackColor = Color.Cyan
            pnlblue11.Visible = True
            pnlblue11.BackColor = Color.Aquamarine
            pnlblue12.Visible = True
            pnlblue12.BackColor = Color.DarkTurquoise
            pnlblue13.Visible = True
            pnlblue13.BackColor = Color.LightSeaGreen
            pnlblue14.Visible = True
            pnlblue14.BackColor = Color.MediumAquamarine
            pnlblue15.Visible = True
            pnlblue15.BackColor = Color.CadetBlue
            pnlblue16.Visible = True
            pnlblue16.BackColor = Color.Teal
            lblbluelevel.Text = "Level 3"
        End If
        If My.Settings.BoughtPurple = True Then
            pnlpurplecolours.Visible = True
            pnlpurple1.Visible = True
            pnlpurple1.BackColor = Color.Purple
            lblpurplelevel.Text = "Level 1"
        End If
        If My.Settings.BoughtPurpleShades = True Then
            pnlpurple1.Visible = True
            pnlpurple2.Visible = True
            pnlpurple3.Visible = True
            pnlpurple1.BackColor = Color.Indigo
            pnlpurple2.BackColor = Color.Purple
            pnlpurple3.BackColor = Color.MediumPurple
            lblpurplelevel.Text = "Level 2"
        End If
        If My.Settings.BoughtPurpleSet = True Then
            pnlpurple1.Visible = True
            pnlpurple2.Visible = True
            pnlpurple3.Visible = True
            pnlpurple4.Visible = True
            pnlpurple5.Visible = True
            pnlpurple6.Visible = True
            pnlpurple7.Visible = True
            pnlpurple8.Visible = True
            pnlpurple9.Visible = True
            pnlpurple10.Visible = True
            pnlpurple11.Visible = True
            pnlpurple12.Visible = True
            pnlpurple13.Visible = True
            pnlpurple14.Visible = True
            pnlpurple15.Visible = True
            pnlpurple16.Visible = True
            pnlpurple1.BackColor = Color.Indigo
            pnlpurple2.BackColor = Color.DarkSlateBlue
            pnlpurple3.BackColor = Color.Purple
            pnlpurple4.BackColor = Color.DarkOrchid
            pnlpurple5.BackColor = Color.DarkViolet
            pnlpurple6.BackColor = Color.BlueViolet
            pnlpurple7.BackColor = Color.SlateBlue
            pnlpurple8.BackColor = Color.MediumSlateBlue
            pnlpurple9.BackColor = Color.MediumPurple
            pnlpurple10.BackColor = Color.MediumOrchid
            pnlpurple11.BackColor = Color.Magenta
            pnlpurple12.BackColor = Color.Orchid
            pnlpurple13.BackColor = Color.Violet
            pnlpurple14.BackColor = Color.Plum
            pnlpurple15.BackColor = Color.Thistle
            pnlpurple16.BackColor = Color.Lavender
            lblpurplelevel.Text = "Level 3"
        End If
        If My.Settings.BoughtPink = True Then
            pnlpinkcolours.Visible = True
            pnlpink1.Visible = True
            pnlpink1.BackColor = Color.HotPink
            lblpinklevel.Text = "Level 1"
        End If
        If My.Settings.BoughtPinkShades = True Then
            pnlpink1.Visible = True
            pnlpink2.Visible = True
            pnlpink3.Visible = True
            pnlpink1.BackColor = Color.DeepPink
            pnlpink2.BackColor = Color.HotPink
            pnlpink3.BackColor = Color.LightPink
            lblpinklevel.Text = "Level 2"
        End If
        If My.Settings.BoughtPinkSet = True Then
            pnlpink1.Visible = True
            pnlpink2.Visible = True
            pnlpink3.Visible = True
            pnlpink4.Visible = True
            pnlpink5.Visible = True
            pnlpink6.Visible = True
            pnlpink1.BackColor = Color.MediumVioletRed
            pnlpink2.BackColor = Color.PaleVioletRed
            pnlpink3.BackColor = Color.DeepPink
            pnlpink4.BackColor = Color.HotPink
            pnlpink5.BackColor = Color.LightPink
            pnlpink6.BackColor = Color.Pink
            lblpinklevel.Text = "Level 3"
        End If
        If My.Settings.BoughtBrown = True Then
            pnlbrowncolours.Visible = True
            pnlbrown1.Visible = True
            pnlbrown1.BackColor = Color.Sienna
            lblbrownlevel.Text = "Level 1"
        End If
        If My.Settings.BoughtBrownShades = True Then
            pnlbrown1.Visible = True
            pnlbrown2.Visible = True
            pnlbrown3.Visible = True
            pnlbrown1.BackColor = Color.SaddleBrown
            pnlbrown2.BackColor = Color.Sienna
            pnlbrown3.BackColor = Color.BurlyWood
            lblbrownlevel.Text = "Level 2"
        End If
        If My.Settings.BoughtBrownSet = True Then
            pnlbrown1.Visible = True
            pnlbrown2.Visible = True
            pnlbrown3.Visible = True
            pnlbrown4.Visible = True
            pnlbrown5.Visible = True
            pnlbrown6.Visible = True
            pnlbrown7.Visible = True
            pnlbrown8.Visible = True
            pnlbrown9.Visible = True
            pnlbrown10.Visible = True
            pnlbrown11.Visible = True
            pnlbrown12.Visible = True
            pnlbrown13.Visible = True
            pnlbrown14.Visible = True
            pnlbrown15.Visible = True
            pnlbrown16.Visible = True
            pnlbrown1.BackColor = Color.Maroon
            pnlbrown2.BackColor = Color.Brown
            pnlbrown3.BackColor = Color.Sienna
            pnlbrown4.BackColor = Color.SaddleBrown
            pnlbrown5.BackColor = Color.Chocolate
            pnlbrown6.BackColor = Color.Peru
            pnlbrown7.BackColor = Color.DarkGoldenrod
            pnlbrown8.BackColor = Color.Goldenrod
            pnlbrown9.BackColor = Color.SandyBrown
            pnlbrown10.BackColor = Color.RosyBrown
            pnlbrown11.BackColor = Color.Tan
            pnlbrown12.BackColor = Color.BurlyWood
            pnlbrown13.BackColor = Color.Wheat
            pnlbrown14.BackColor = Color.NavajoWhite
            pnlbrown15.BackColor = Color.Bisque
            pnlbrown16.BackColor = Color.BlanchedAlmond
        End If
#End Region

    End Sub


#End Region
    Private Sub pnlbluecolours_Paint(sender As Object, e As PaintEventArgs) Handles pnlbluecolours.Paint

    End Sub

    Private Sub pnloldcolour_Click(sender As Object, e As EventArgs) Handles pnloldcolour.Click
        Me.Close()
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub

    Private Sub colorselectiongray(sender As Object, e As MouseEventArgs) Handles pnlgray1.Click, pnlgray2.Click, pnlgray3.Click, pnlgray4.Click, pnlgray5.Click, pnlgray6.Click, pnlgray7.Click, pnlgray8.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionred(sender As Object, e As MouseEventArgs) Handles pnlred1.Click, pnlred2.Click, pnlred3.Click, pnlred4.Click, pnlred5.Click, pnlred6.Click, pnlred7.Click, pnlred8.Click, pnlred9.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionorange(sender As Object, e As MouseEventArgs) Handles pnlorange1.Click, pnlorange2.Click, pnlorange3.Click, pnlorange4.Click, pnlorange5.Click, pnlorange6.Click, pnlorange7.Click, pnlorange8.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionyellow(sender As Object, e As MouseEventArgs) Handles pnlyellow1.Click, pnlyellow2.Click, pnlyellow3.Click, pnlyellow4.Click, pnlyellow5.Click, pnlyellow6.Click, pnlyellow7.Click, pnlyellow8.Click, pnlyellow9.Click, pnlyellow10.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectiongreen(sender As Object, e As MouseEventArgs) Handles pnlgreen1.Click, pnlgreen2.Click, pnlgreen3.Click, pnlgreen4.Click, pnlgreen5.Click, pnlgreen6.Click, pnlgreen7.Click, pnlgreen8.Click, pnlgreen9.Click, pnlgreen10.Click, pnlgreen11.Click, pnlgreen12.Click, pnlgreen13.Click, pnlgreen14.Click, pnlgreen15.Click, pnlgreen16.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionblue(sender As Object, e As MouseEventArgs) Handles pnlblue1.Click, pnlblue2.Click, pnlblue3.Click, pnlblue4.Click, pnlblue5.Click, pnlblue6.Click, pnlblue7.Click, pnlblue8.Click, pnlblue9.Click, pnlblue10.Click, pnlblue11.Click, pnlblue12.Click, pnlblue13.Click, pnlblue14.Click, pnlblue15.Click, pnlblue16.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionpurple(sender As Object, e As MouseEventArgs) Handles pnlpurple1.Click, pnlpurple2.Click, pnlpurple3.Click, pnlpurple4.Click, pnlpurple5.Click, pnlpurple6.Click, pnlpurple7.Click, pnlpurple8.Click, pnlpurple9.Click, pnlpurple10.Click, pnlpurple11.Click, pnlpurple12.Click, pnlpurple13.Click, pnlpurple14.Click, pnlpurple15.Click, pnlpurple16.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionpink(sender As Object, e As MouseEventArgs) Handles pnlpink1.Click, pnlpink2.Click, pnlpink3.Click, pnlpink4.Click, pnlpink5.Click, pnlpink6.Click, pnlpink7.Click, pnlpink8.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub colorselectionbrown(sender As Object, e As MouseEventArgs) Handles pnlbrown1.Click, pnlbrown2.Click, pnlbrown3.Click, pnlbrown4.Click, pnlbrown5.Click, pnlbrown6.Click, pnlbrown7.Click, pnlbrown8.Click, pnlbrown9.Click, pnlbrown10.Click, pnlbrown11.Click, pnlbrown12.Click, pnlbrown13.Click, pnlbrown14.Click, pnlbrown15.Click, pnlbrown16.Click
        If e.Button = MouseButtons.Left Then
            pnlnewcolour.BackColor = sender.backcolor
            lblnewcolourname.Text = pnlnewcolour.BackColor.Name
            lblnewcolourrgb.Text = "RGB: " & pnlnewcolour.BackColor.R & ", " & pnlnewcolour.BackColor.G & ", " & pnlnewcolour.BackColor.B
        End If

    End Sub
    Private Sub pnlgraycolours_Paint(sender As Object, e As PaintEventArgs) Handles pnlgraycolours.Paint

    End Sub

    Private Sub pnlnewcolour_Click(sender As Object, e As EventArgs) Handles pnlnewcolour.Click
        Select Case colortochange
            Case "Close Button Color"
                Shifter.closebuttoncolor.BackColor = pnlnewcolour.BackColor
            Case "Titlebar Color"
                Shifter.titlebarcolorbutton.BackColor = pnlnewcolour.BackColor
            Case "Border Color"
                Shifter.bordercolorbutton.BackColor = pnlnewcolour.BackColor
            Case "Titlebar Text Color"
                Shifter.tbartextcolor.BackColor = pnlnewcolour.BackColor
            Case "Desktop Background Color"
                Shifter.desktopbackcolor.BackColor = pnlnewcolour.BackColor
            Case "Desktop Panel Color"
                Shifter.desktoppanelcolor.BackColor = pnlnewcolour.BackColor
            Case "Menu Color"
                Shifter.menucolor.BackColor = pnlnewcolour.BackColor
            Case "Menu Button Color"
                Shifter.menubuttoncolor.BackColor = pnlnewcolour.BackColor
            Case "Panel Clock Background Color"
                Shifter.panelclockcolor.BackColor = pnlnewcolour.BackColor
            Case "Panel Clock Text Color"
                Shifter.clocktextcolor.BackColor = pnlnewcolour.BackColor
            Case "Launcher Text Color"
                Shifter.launchertextcolor.BackColor = pnlnewcolour.BackColor
            Case "Launcher Menu Text Color"
                Shifter.lmenutextcolor.BackColor = pnlnewcolour.BackColor
        End Select
        Me.Close()
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub pnlpurplecolours_Paint(sender As Object, e As PaintEventArgs) Handles pnlpurplecolours.Paint

    End Sub
End Class