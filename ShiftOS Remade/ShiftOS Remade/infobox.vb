Public Class infobox
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
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
    Private Sub yes_Click(sender As Object, e As EventArgs)
        If txtmessage.Text = "Are you sure you want to global reset? Note that this cannot be undone, and you will lose all of your custom preferences. You can still use your colors you bought, but you will not have the skin/theme applied." Then

        End If

    End Sub

    Private Sub no_Click(sender As Object, e As EventArgs)
        If txtmessage.Text = "Are you sure you want to global reset? Note that this cannot be undone, and you will lose all of your custom preferences. You can still use your colors you bought, but you will not have the skin/theme applied." Then
            Me.Close()
        End If
    End Sub

    Private Sub pgcontents_Paint(sender As Object, e As PaintEventArgs) Handles pgcontents.Paint

    End Sub

    Private Sub infobox_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        Me.TopMost = True
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
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
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub

    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
        If txtmessage.Text = "Are you sure you want to global reset? Note that this cannot be undone, and you will lose all of your custom preferences. You can still use your colors you bought, but you will not have the skin/theme applied." Then
            My.Settings.titlebarcolor = Color.Gray
            My.Settings.titlebartextcolor = Color.White
            My.Settings.desktopcolor = Color.Black
            My.Settings.bordercolor = Color.Gray
            My.Settings.desktoppanelcolor = Color.Gray
            My.Settings.applaunchercolor = Color.Gray
            My.Settings.menucolor = Color.Gray
            My.Settings.panelclockcolor = Color.Gray
            My.Settings.panelclocktextcolor = Color.Black
            My.Settings.clocktextcolor = Color.Black
            'BUTTONS
            My.Settings.closecolor = Color.Black
            Terminal.closebutton.BackColor = Color.Black
            Shifter.closebutton.BackColor = Color.Black
            CodepointClicker.closebutton.BackColor = Color.Black
            Shiftorium.closebutton.BackColor = Color.Black
            ShiftOSClock.closebutton.BackColor = Color.Black
            Color_Picker.closebutton.BackColor = Color.Black
            Me.closebutton.BackColor = Color.Black
            Textpad.closebutton.BackColor = Color.Black
            File_Skimmer.closebutton.BackColor = Color.Black

            'TITLEBAR
            My.Settings.titlebarcolor = Color.Gray
            Terminal.titlebar.BackColor = My.Settings.titlebarcolor
            Me.titlebar.BackColor = My.Settings.titlebarcolor
            CodepointClicker.titlebar.BackColor = My.Settings.titlebarcolor
            Shiftorium.titlebar.BackColor = My.Settings.titlebarcolor
            ShiftOSClock.titlebar.BackColor = My.Settings.titlebarcolor
            Color_Picker.titlebar.BackColor = My.Settings.titlebarcolor
            Shifter.titlebar.BackColor = My.Settings.titlebarcolor
            Textpad.titlebar.BackColor = My.Settings.titlebarcolor
            File_Skimmer.titlebar.BackColor = My.Settings.titlebarcolor

            'TITLEBAR TEXT
            My.Settings.titlebartextcolor = Color.White
            Terminal.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            Me.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            CodepointClicker.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            Shiftorium.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            ShiftOSClock.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            Color_Picker.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            Shifter.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            Textpad.lbtitletext.ForeColor = My.Settings.titlebartextcolor
            File_Skimmer.lbtitletext.ForeColor = My.Settings.titlebartextcolor

            'TITLEBAR TEXT SIZE
            My.Settings.ttextsize = 11.25
            My.Settings.ttextfontname = "Microsoft Sans Serif"
            My.Settings.ttextfont = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Terminal.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Me.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            CodepointClicker.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Shiftorium.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            ShiftOSClock.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Color_Picker.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Shifter.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            Textpad.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)
            File_Skimmer.lbtitletext.Font = New Font("Microsoft Sans Serif", 11.25, FontStyle.Bold)

            'BORDERS
            My.Settings.bordercolor = Color.Gray
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
            Me.pgbottom.BackColor = My.Settings.bordercolor
            Me.pgleft.BackColor = My.Settings.bordercolor
            Me.pgright.BackColor = My.Settings.bordercolor
            Shifter.pgbottom.BackColor = My.Settings.bordercolor
            Shifter.pgleft.BackColor = My.Settings.bordercolor
            Shifter.pgright.BackColor = My.Settings.bordercolor
            Textpad.pgbottom.BackColor = My.Settings.bordercolor
            Textpad.pgleft.BackColor = My.Settings.bordercolor
            Textpad.pgright.BackColor = My.Settings.bordercolor
            File_Skimmer.pgbottom.BackColor = My.Settings.bordercolor
            File_Skimmer.BackColor = My.Settings.bordercolor
            File_Skimmer.BackColor = My.Settings.bordercolor
            'DESKTOP BACKGROUND
            My.Settings.desktopcolor = Color.Black
            ShiftOSDesktop.desktopiconsbackground.BackColor = My.Settings.desktopcolor

            'DESKTOP PANEL
            My.Settings.desktoppanelcolor = Color.Gray
            ShiftOSDesktop.FLP.BackColor = My.Settings.desktoppanelcolor

            'DESKTOP PANEL LOCATION
            My.Settings.desktoppanellocation = "Top"
            ShiftOSDesktop.FLP.Dock = DockStyle.Top
            ShiftOSDesktop.MenuStrip1.Location = ShiftOSDesktop.FLP.Location
            ShiftOSDesktop.timepanel.Location = New Point(ShiftOSDesktop.timepanel.Location.X, ShiftOSDesktop.FLP.Location.Y)

            'MENU BUTTON COLOR
            My.Settings.applaunchercolor = Color.Gray
            ShiftOSDesktop.ApplicationsToolStripMenuItem.BackColor = My.Settings.applaunchercolor
            ShiftOSDesktop.MenuStrip1.BackColor = My.Settings.applaunchercolor

            'MENU
            My.Settings.menucolor = Color.Gray
            ShiftOSDesktop.CLOCK.BackColor = My.Settings.menucolor
            ShiftOSDesktop.CPCLICKER.BackColor = My.Settings.menucolor
            ShiftOSDesktop.SHUTDOWN.BackColor = My.Settings.menucolor
            ShiftOSDesktop.TerminalSTRIP.BackColor = My.Settings.menucolor
            ShiftOSDesktop.ShifterTSMI.BackColor = My.Settings.menucolor
            ShiftOSDesktop.SHIFTORIUMSTRIP.BackColor = My.Settings.menucolor
            ShiftOSDesktop.TextpadSTRIP.BackColor = My.Settings.menucolor
            ShiftOSDesktop.FileSKIMMER.BackColor = My.Settings.menucolor

            'PANEL CLOCK COLOR
            My.Settings.panelclockcolor = Color.Gray
            ShiftOSDesktop.timepanel.BackColor = My.Settings.panelclockcolor

            'PANEL CLOCK TEXT COLOR
            My.Settings.clocktextcolor = Color.Black
            ShiftOSDesktop.timelabel.ForeColor = My.Settings.clocktextcolor
            Me.Close()

            'APP LAUNCHER TEXT COLOR
            My.Settings.launchertextcolor = Color.Black
            ShiftOSDesktop.ApplicationsToolStripMenuItem.ForeColor = My.Settings.launchertextcolor

            'LAUNCHER LABEL
            My.Settings.launcherlabel = "Applications"
            ShiftOSDesktop.ApplicationsToolStripMenuItem.Text = My.Settings.launcherlabel

            'APP LAUNCHER MENU TEXT COLOR
            My.Settings.lmenutextcolor = Color.Black
            ShiftOSDesktop.CLOCK.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.SHUTDOWN.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.CPCLICKER.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.TerminalSTRIP.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.SHIFTORIUMSTRIP.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.ShifterTSMI.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.TextpadSTRIP.ForeColor = My.Settings.lmenutextcolor
            ShiftOSDesktop.FileSKIMMER.ForeColor = My.Settings.lmenutextcolor
        End If
        If txtmessage.Text = "You cannot have more than 13 characters, otherwise the system will break." Then
            Shifter.applauncherlabel.ReadOnly = False
            Shifter.applauncherlabel.Text = Shifter.applauncherlabel.Text.Remove(Shifter.applauncherlabel.TextLength - 1)
            Me.Close()
        End If
    End Sub
End Class