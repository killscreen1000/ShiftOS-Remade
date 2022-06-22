Public Class Shifter
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
    Dim mistype As String
    Dim previewfontsize As Integer
    Dim previewfont As String
    Dim color As New System.Drawing.Color
    Public itemstyle As FontStyle = FontStyle.Bold
    Dim MyFont As FontFamily
    Dim MyFont2 As FontFamily
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

    Private Sub Shifter_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        closebuttoncolor.BackColor = My.Settings.closecolor
        titlebarcolorbutton.BackColor = My.Settings.titlebarcolor
        bordercolorbutton.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        tbartextcolor.BackColor = My.Settings.titlebartextcolor
        desktopbackcolor.BackColor = My.Settings.desktopcolor
        desktoppanelcolor.BackColor = My.Settings.desktoppanelcolor
        menucolor.BackColor = My.Settings.menucolor
        menubuttoncolor.BackColor = My.Settings.applaunchercolor
        panelclockcolor.BackColor = My.Settings.panelclockcolor
        clocktextcolor.BackColor = My.Settings.clocktextcolor
        tbartextsize.Text = My.Settings.ttextsize
        previewtext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        tbartextsize.Text = lbtitletext.Font.Size
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        tbartextsize.Text = My.Settings.ttextsize
        panelocationbox.Text = My.Settings.desktoppanellocation
        fontcombobox.Text = My.Settings.ttextfontname
        launchertextcolor.BackColor = My.Settings.launchertextcolor
        applauncherlabel.Text = My.Settings.launcherlabel
        lmenutextcolor.BackColor = My.Settings.lmenutextcolor

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
    End Sub


#End Region
    Private Sub closebutton_Paint(sender As Object, e As PaintEventArgs) Handles closebutton.Paint

    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        RemoveFonts()
        Me.Close()
    End Sub



    Private Sub btndesktop_Click(sender As Object, e As EventArgs)
        DesktopButtonPanel.Show()
    End Sub

    Private Sub DesktopButtonPanel_Paint(sender As Object, e As PaintEventArgs) Handles DesktopButtonPanel.Paint

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub closebuttoncolor_Click(sender As Object, e As EventArgs) Handles closebuttoncolor.Click
        Color_Picker.colortochange = "Close Button Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'BUTTONS
        My.Settings.closecolor = closebuttoncolor.BackColor
        Terminal.closebutton.BackColor = My.Settings.closecolor
        Me.closebutton.BackColor = My.Settings.closecolor
        CodepointClicker.closebutton.BackColor = My.Settings.closecolor
        Shiftorium.closebutton.BackColor = My.Settings.closecolor
        ShiftOSClock.closebutton.BackColor = My.Settings.closecolor
        Color_Picker.closebutton.BackColor = My.Settings.closecolor
        infobox.closebutton.BackColor = My.Settings.closecolor
        Textpad.closebutton.BackColor = My.Settings.closecolor
        File_Skimmer.closebutton.BackColor = My.Settings.closecolor

        'TITLEBAR
        My.Settings.titlebarcolor = titlebarcolorbutton.BackColor
        Terminal.titlebar.BackColor = My.Settings.titlebarcolor
        Me.titlebar.BackColor = My.Settings.titlebarcolor
        CodepointClicker.titlebar.BackColor = My.Settings.titlebarcolor
        Shiftorium.titlebar.BackColor = My.Settings.titlebarcolor
        ShiftOSClock.titlebar.BackColor = My.Settings.titlebarcolor
        Color_Picker.titlebar.BackColor = My.Settings.titlebarcolor
        infobox.titlebar.BackColor = My.Settings.titlebarcolor
        Textpad.titlebar.BackColor = My.Settings.titlebarcolor
        File_Skimmer.titlebar.BackColor = My.Settings.titlebarcolor

        'TITLEBAR TEXT
        My.Settings.titlebartextcolor = tbartextcolor.BackColor
        Terminal.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        CodepointClicker.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Shiftorium.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        ShiftOSClock.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Color_Picker.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        infobox.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Textpad.lbtitletext.ForeColor = My.Settings.titlebartextcolor
        File_Skimmer.lbtitletext.ForeColor = My.Settings.titlebartextcolor

        'TITLEBAR TEXT SIZE
        My.Settings.ttextsize = tbartextsize.Text
        My.Settings.ttextfontname = fontcombobox.Text
        My.Settings.ttextfont = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        Terminal.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        CodepointClicker.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        Shiftorium.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        ShiftOSClock.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        Color_Picker.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        infobox.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        Textpad.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)
        File_Skimmer.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, itemstyle)

        'BORDERS
        My.Settings.bordercolor = bordercolorbutton.BackColor
        Terminal.pgbottom.BackColor = My.Settings.bordercolor
        Terminal.pgleft.BackColor = My.Settings.bordercolor
        Terminal.pgright.BackColor = My.Settings.bordercolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        CodepointClicker.pgbottom.BackColor = My.Settings.bordercolor
        CodepointClicker.pgleft.BackColor = My.Settings.bordercolor
        CodepointClicker.pgright.BackColor = My.Settings.bordercolor
        Shiftorium.pgbottom.BackColor = My.Settings.bordercolor
        Shiftorium.pgleft.BackColor = My.Settings.bordercolor
        Shiftorium.pgright.BackColor = My.Settings.bordercolor
        ShiftOSClock.pgbottom.BackColor = My.Settings.bordercolor
        ShiftOSClock.pgleft.BackColor = My.Settings.bordercolor
        ShiftOSClock.pgright.BackColor = My.Settings.bordercolor
        Color_Picker.pgbottom.BackColor = My.Settings.bordercolor
        Color_Picker.pgleft.BackColor = My.Settings.bordercolor
        Color_Picker.pgright.BackColor = My.Settings.bordercolor
        infobox.pgbottom.BackColor = My.Settings.bordercolor
        infobox.pgleft.BackColor = My.Settings.bordercolor
        infobox.pgright.BackColor = My.Settings.bordercolor
        Textpad.pgbottom.BackColor = My.Settings.bordercolor
        Textpad.pgleft.BackColor = My.Settings.bordercolor
        Textpad.pgright.BackColor = My.Settings.bordercolor
        File_Skimmer.pgbottom.BackColor = My.Settings.bordercolor
        File_Skimmer.pgleft.BackColor = My.Settings.bordercolor
        File_Skimmer.pgright.BackColor = My.Settings.bordercolor

        'DESKTOP BACKGROUND
        My.Settings.desktopcolor = desktopbackcolor.BackColor
        ShiftOSDesktop.desktopiconsbackground.BackColor = My.Settings.desktopcolor

        'DESKTOP PANEL
        My.Settings.desktoppanelcolor = desktoppanelcolor.BackColor
        ShiftOSDesktop.FLP.BackColor = My.Settings.desktoppanelcolor

        'DESKTOP PANEL LOCATION
        If panelocationbox.Text = "Top" Then
            My.Settings.desktoppanellocation = "Top"
            ShiftOSDesktop.FLP.Dock = DockStyle.Top
            ShiftOSDesktop.MenuStrip1.Location = ShiftOSDesktop.FLP.Location
            ShiftOSDesktop.timepanel.Location = New Point(ShiftOSDesktop.timepanel.Location.X, ShiftOSDesktop.FLP.Location.Y)
        End If
        If panelocationbox.Text = "Bottom" Then
            My.Settings.desktoppanellocation = "Bottom"
            ShiftOSDesktop.FLP.Dock = DockStyle.Bottom
            ShiftOSDesktop.MenuStrip1.Location = ShiftOSDesktop.FLP.Location
            ShiftOSDesktop.timepanel.Location = New Point(ShiftOSDesktop.timepanel.Location.X, ShiftOSDesktop.FLP.Location.Y)
        End If

        'MENU BUTTON COLOR
        My.Settings.applaunchercolor = menubuttoncolor.BackColor
        ShiftOSDesktop.ApplicationsToolStripMenuItem.BackColor = My.Settings.applaunchercolor
        ShiftOSDesktop.MenuStrip1.BackColor = My.Settings.applaunchercolor

        'MENU
        My.Settings.menucolor = menucolor.BackColor
        ShiftOSDesktop.CLOCK.BackColor = My.Settings.menucolor
        ShiftOSDesktop.CPCLICKER.BackColor = My.Settings.menucolor
        ShiftOSDesktop.SHUTDOWN.BackColor = My.Settings.menucolor
        ShiftOSDesktop.TerminalSTRIP.BackColor = My.Settings.menucolor
        ShiftOSDesktop.ShifterTSMI.BackColor = My.Settings.menucolor
        ShiftOSDesktop.SHIFTORIUMSTRIP.BackColor = My.Settings.menucolor
        ShiftOSDesktop.TextpadSTRIP.BackColor = My.Settings.menucolor
        ShiftOSDesktop.FileSKIMMER.BackColor = My.Settings.menucolor

        'PANEL CLOCK COLOR
        My.Settings.panelclockcolor = panelclockcolor.BackColor
        ShiftOSDesktop.timepanel.BackColor = My.Settings.panelclockcolor

        'PANEL CLOCK TEXT COLOR
        My.Settings.clocktextcolor = clocktextcolor.BackColor
        ShiftOSDesktop.timelabel.ForeColor = My.Settings.clocktextcolor

        'APP LAUNCHER TEXT COLOR
        My.Settings.launchertextcolor = launchertextcolor.BackColor
        ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor = My.Settings.launchertextcolor

        'LAUNCHER LABEL
        My.Settings.launcherlabel = applauncherlabel.Text
        ShiftOSDesktop.ApplicationsToolStripMenuItem.Text = My.Settings.launcherlabel

        'APP LAUNCHER MENU TEXT COLOR
        My.Settings.lmenutextcolor = lmenutextcolor.BackColor
        ShiftOSDesktop.CLOCK.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.SHUTDOWN.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.CPCLICKER.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.TerminalSTRIP.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.SHIFTORIUMSTRIP.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.ShifterTSMI.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.TextpadSTRIP.ForeColor = My.Settings.lmenutextcolor
        ShiftOSDesktop.FileSKIMMER.ForeColor = My.Settings.lmenutextcolor
    End Sub

    Private Sub titlebarcolorbutton_Click(sender As Object, e As EventArgs) Handles titlebarcolorbutton.Click
        Color_Picker.colortochange = "Titlebar Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub bordercolorbutton_Click(sender As Object, e As EventArgs) Handles bordercolorbutton.Click
        Color_Picker.colortochange = "Border Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub tbartextcolor_Click(sender As Object, e As EventArgs) Handles tbartextcolor.Click
        Color_Picker.colortochange = "Titlebar Text Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub Panel4_Click(sender As Object, e As EventArgs) Handles desktopbackcolor.Click
        Color_Picker.colortochange = "Desktop Background Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub Panel4_Click_1(sender As Object, e As EventArgs) Handles desktoppanelcolor.Click
        Color_Picker.colortochange = "Desktop Panel Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub menucolor_Click(sender As Object, e As EventArgs) Handles menucolor.Click
        Color_Picker.colortochange = "Menu Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub Panel5_Click(sender As Object, e As EventArgs) Handles menubuttoncolor.Click
        Color_Picker.colortochange = "Menu Button Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub panelclockcolor_Click(sender As Object, e As EventArgs) Handles panelclockcolor.Click
        Color_Picker.colortochange = "Panel Clock Background Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub AddFonts()
        Dim allFonts As New Drawing.Text.InstalledFontCollection
        Dim fontfamiles() As FontFamily = allFonts.Families
        For Each myfont As FontFamily In fontfamiles
            fontcombobox.Items.Add(myfont.Name)
        Next
    End Sub

    Public Sub RemoveFonts()
        Dim allfontsinstalled As New Drawing.Text.InstalledFontCollection
        Dim fontfamiliestotal() As FontFamily = allfontsinstalled.Families
        For Each MyFont2 As FontFamily In fontfamiliestotal
            fontcombobox.Items.Remove(MyFont2.Name)
        Next
    End Sub
    Private Sub fontcombobox_Click(sender As Object, e As EventArgs) Handles fontcombobox.Click
        RemoveFonts()
        AddFonts()
    End Sub

    Private Sub clocktextcolor_Click(sender As Object, e As EventArgs) Handles clocktextcolor.Click
        Color_Picker.colortochange = "Panel Clock Text Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub DesktopButtonPanel_Click(sender As Object, e As EventArgs) Handles DesktopButtonPanel.Click

    End Sub

    Private Sub tbartextsize_TextChanged(sender As Object, e As EventArgs) Handles tbartextsize.TextChanged
        If tbartextsize.Text = "" Then
            previewfontsize = 11.25
            tbartextsize.Text = "11.25"
        End If
        If Not tbartextsize.Text = "" Then
            previewfontsize = tbartextsize.Text
        End If
        previewfont = fontcombobox.SelectedItem
        previewtext.Font = New Font(previewfont, previewfontsize, itemstyle)
    End Sub

    Private Sub fontcombobox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles fontcombobox.SelectedIndexChanged
        previewfontsize = tbartextsize.Text
        previewfont = fontcombobox.SelectedItem
        previewtext.Font = New Font(previewfont, previewfontsize, itemstyle)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        infobox.Show()
        infobox.lbtitletext.Text = "Global Reset Confirmation"
        infobox.txtmessage.Text = "Are you sure you want to global reset? Note that this cannot be undone, and you will lose all of your custom preferences. You can still use your colors you bought, but you will not have the skin/theme applied."
        My.Computer.Audio.Play(My.Resources.infobox, AudioPlayMode.Background)
    End Sub

    Private Sub launchertextcolor_Click(sender As Object, e As EventArgs) Handles launchertextcolor.Click
        Color_Picker.colortochange = "Launcher Text Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub

    Private Sub applauncherlabel_TextChanged(sender As Object, e As EventArgs) Handles applauncherlabel.TextChanged
        If applauncherlabel.TextLength > 13 Then
            applauncherlabel.ReadOnly = True
            infobox.Show()
            infobox.lbtitletext.Text = "Text Error"
            infobox.txtmessage.Text = "You cannot have more than 13 characters, otherwise the system will break."
        End If
    End Sub

    Private Sub lmenutextcolor_Click(sender As Object, e As EventArgs) Handles lmenutextcolor.Click
        Color_Picker.colortochange = "Launcher Menu Text Color"
        Color_Picker.Show()
        Color_Picker.TopMost = True
    End Sub
End Class