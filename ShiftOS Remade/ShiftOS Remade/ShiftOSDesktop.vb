Public Class ShiftOSDesktop
    Dim BoughtCustomTerminalText As Integer
    Dim BoughtTitlebar As Integer
    Dim BoughtBorders As Integer
    Dim bootfileexists As Integer
    Dim Content As String
    Public ShiftOSPath As String = "C:/ShiftOS/"

    Private Sub ShiftOSDesktop_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If My.Computer.FileSystem.FileExists("C:/ShiftOS/System/Boot/Required_Boot.txt") Then
            Content = My.Computer.FileSystem.ReadAllText("C:/ShiftOS/System/Boot/Required_Boot.txt")
            If Not My.Computer.FileSystem.ReadAllText("C:/ShiftOS/System/Boot/Required_Boot.txt").Contains("BootSector = AA" + Environment.NewLine + "BootSector2 = A0" + Environment.NewLine + "BootSector3 = B0" + Environment.NewLine + "BootSector4 = CA") Then
                crashscreen.Show()
                crashscreen.BackgroundImage = My.Resources.Error_Code_6
            End If
        End If
        If Not My.Computer.FileSystem.FileExists("C:/ShiftOS/System/Boot/Required_Boot.txt") Then
            Content = Nothing
            crashscreen.Show()
            crashscreen.BackgroundImage = My.Resources.Error_Code_5
        End If

        Dim AntiPiracyCheats = My.Computer.FileSystem.ReadAllText("C:/ShiftOS/System/shift42/Cheats.txt")
        If Not AntiPiracyCheats.Contains("Cheats.Enabled = False" + Environment.NewLine + "Cheats.AbleToBeEnabled = False") Then
            crashscreen.Show()
            crashscreen.BackgroundImage = My.Resources.Error_Code_10
        End If
        desktopiconsbackground.BackColor = My.Settings.desktopcolor
        FLP.BackColor = My.Settings.desktoppanelcolor
        CLOCK.BackColor = My.Settings.menucolor
        CPCLICKER.BackColor = My.Settings.menucolor
        SHUTDOWN.BackColor = My.Settings.menucolor
        TerminalSTRIP.BackColor = My.Settings.menucolor
        ShifterTSMI.BackColor = My.Settings.menucolor
        SHIFTORIUMSTRIP.BackColor = My.Settings.menucolor
        TextpadSTRIP.BackColor = My.Settings.menucolor
        FileSKIMMER.BackColor = My.Settings.menucolor
        ApplicationsToolStripMenuItem.BackColor = My.Settings.applaunchercolor
        MenuStrip1.BackColor = My.Settings.applaunchercolor
        timepanel.BackColor = My.Settings.panelclockcolor
        timelabel.ForeColor = My.Settings.clocktextcolor
        Terminal.lbtitletext.Font = My.Settings.ttextfont
        Shifter.lbtitletext.Font = My.Settings.ttextfont
        CodepointClicker.lbtitletext.Font = My.Settings.ttextfont
        Shiftorium.lbtitletext.Font = My.Settings.ttextfont
        ShiftOSClock.lbtitletext.Font = My.Settings.ttextfont
        Color_Picker.lbtitletext.Font = My.Settings.ttextfont
        Textpad.lbtitletext.Font = My.Settings.ttextfont
        File_Skimmer.lbtitletext.Font = My.Settings.ttextfont
        ApplicationsToolStripMenuItem.ForeColor = My.Settings.launchertextcolor
        ApplicationsToolStripMenuItem.Text = My.Settings.launcherlabel
        CLOCK.ForeColor = My.Settings.lmenutextcolor
        SHUTDOWN.ForeColor = My.Settings.lmenutextcolor
        CPCLICKER.ForeColor = My.Settings.lmenutextcolor
        TerminalSTRIP.ForeColor = My.Settings.lmenutextcolor
        SHIFTORIUMSTRIP.ForeColor = My.Settings.lmenutextcolor
        ShifterTSMI.ForeColor = My.Settings.lmenutextcolor
        TextpadSTRIP.ForeColor = My.Settings.lmenutextcolor
        FileSKIMMER.ForeColor = My.Settings.lmenutextcolor
        Select Case My.Settings.desktoppanellocation
            Case "Top"
                MenuStrip1.Location = New Point(0, FLP.Height)
            Case "Bottom"
                MenuStrip1.Location = New Point(0, Me.Height - FLP.Height - MenuStrip1.Height)
        End Select
        If My.Settings.desktoppanellocation = "Top" Then
            FLP.Dock = DockStyle.Top
            MenuStrip1.Location = FLP.Location
            timepanel.Location = New Point(timepanel.Location.X, FLP.Location.Y)
        End If
        If My.Settings.desktoppanellocation = "Bottom" Then
            FLP.Dock = DockStyle.Bottom
            MenuStrip1.Location = FLP.Location
            timepanel.Location = New Point(timepanel.Location.X, FLP.Location.Y)
        End If
        If My.Settings.BoughtCloseButton = True Then
            Terminal.closebutton.BackColor = My.Settings.closecolor
            Shifter.closebutton.BackColor = My.Settings.closecolor
            CodepointClicker.closebutton.BackColor = My.Settings.closecolor
            Shiftorium.closebutton.BackColor = My.Settings.closecolor
            ShiftOSClock.closebutton.BackColor = My.Settings.closecolor
            Textpad.closebutton.BackColor = My.Settings.closecolor
            File_Skimmer.closebutton.BackColor = My.Settings.closecolor
        End If
        If My.Settings.DoIntro = False Then
            ShiftOSintro.Close()
        End If
        If My.Settings.DoIntro = True Then
            ShiftOSintro.Show()
        End If
        Me.TopMost = False
        If My.Settings.BoughtTitlebar = False Then
            Shiftorium.titlebar.Visible = False
            CodepointClicker.titlebar.Visible = False
            ShiftOSClock.titlebar.Visible = False
            Terminal.titlebar.Visible = False
            Textpad.titlebar.Visible = False
            File_Skimmer.titlebar.Visible = False
        End If
        If My.Settings.BoughtDesktopPanelClock = True Then
            timelabel.Visible = True
        End If
        If My.Settings.BoughtGray = True Then

        End If

        If My.Settings.BoughtTitlebar = True Then
            Shiftorium.titlebar.Visible = True
            CodepointClicker.titlebar.Visible = True
            CodepointClicker.titlebar.Visible = True
            ShiftOSClock.titlebar.Visible = True
            Textpad.titlebar.Visible = True
            File_Skimmer.titlebar.Visible = True
        End If
        If My.Settings.BoughtDesktopPanel = True Then
            MenuStrip1.Visible = True
            MenuStrip1.BringToFront()
            FLP.Visible = True
            FLP.SendToBack()
            desktopiconsbackground.SendToBack()
        End If
        If My.Settings.BoughtDesktopPanel = False Then
            Me.MenuStrip1.Visible = False
            Me.FLP.Visible = False
            Me.timepanel.Visible = False
        End If
        If My.Settings.BoughtALShiftorium = False Then
            SHIFTORIUMSTRIP.Visible = False
        End If

        If My.Settings.BoughtALShiftorium = True Then
            SHIFTORIUMSTRIP.Visible = True
        End If

        If My.Settings.BoughtALShutdown = False Then
            ToolStripSeparator1.Visible = False
            SHUTDOWN.Visible = False
        End If
        If My.Settings.BoughtALShutdown = True Then
            ToolStripSeparator1.Visible = True
            SHUTDOWN.Visible = True
        End If
        If My.Settings.BoughtALCPClicker = True Then
            CPCLICKER.Visible = True
        End If
        If My.Settings.BoughtALCPClicker = False Then
            CPCLICKER.Visible = False
        End If
        If My.Settings.BoughtALClock = True Then
            CLOCK.Visible = True
        End If
        If My.Settings.BoughtALClock = False Then
            CLOCK.Visible = False
        End If
        If My.Settings.BoughtALShifter = True Then
            ShifterTSMI.Visible = True
        End If
        If My.Settings.BoughtALShifter = False Then
            ShifterTSMI.Visible = False
        End If
        If My.Settings.BoughtALTextpad = True Then
            TextpadSTRIP.Visible = True
        End If
        If My.Settings.BoughtALTextpad = False Then
            TextpadSTRIP.Visible = False
        End If
        If My.Settings.BoughtALFileSkimmer = True Then
            FileSKIMMER.Visible = True
        End If
        If My.Settings.BoughtALFileSkimmer = False Then
            FileSKIMMER.Visible = False
        End If
    End Sub
    Private Sub refresheverything()

    End Sub
    Private Sub ShiftOSDesktop_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Terminal.WindowState = FormWindowState.Maximized
            Terminal.pgbottom.Visible = False
            Terminal.pgbottomlcorner.Visible = False
            Terminal.pgbottomrcorner.Visible = False
            Terminal.pgleft.Visible = False
            Terminal.pgright.Visible = False
            Terminal.pgtoplcorner.Visible = False
            Terminal.pgtoprcorner.Visible = False
            Terminal.titlebar.Visible = False
            Terminal.Show()
            Terminal.TopLevel = True
        End If
    End Sub

    Private Sub MakeDirectory()
        My.Computer.FileSystem.CreateDirectory("C:/ShiftOS/Desktop")
    End Sub

    Private Sub DfToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TerminalSTRIP.Click
        Terminal.Show()
        Terminal.TopLevel = True
    End Sub

    Private Sub SHIFTORIUMSTRIP_Click(sender As Object, e As EventArgs) Handles SHIFTORIUMSTRIP.Click
        Shiftorium.Show()
        Shiftorium.TopLevel = True
    End Sub

    Private Sub MenuStrip1_VisibleChanged(sender As Object, e As EventArgs) Handles MenuStrip1.VisibleChanged
        If MenuStrip1.Visible = True Then
            If My.Settings.BoughtALShiftorium = True Then
                SHIFTORIUMSTRIP.Visible = True
            End If
            If My.Settings.BoughtALShiftorium = False Then
                SHIFTORIUMSTRIP.Visible = False
            End If
            If My.Settings.BoughtALCPClicker = True Then
                CPCLICKER.Visible = True
            End If
            If My.Settings.BoughtALCPClicker = False Then
                CPCLICKER.Visible = False
            End If
            If My.Settings.BoughtALShutdown = True Then
                ToolStripSeparator1.Visible = True
                SHUTDOWN.Visible = True
            End If
            If My.Settings.BoughtALShutdown = False Then
                ToolStripSeparator1.Visible = False
                SHUTDOWN.Visible = False
            End If
            If My.Settings.BoughtALClock = True Then
                CLOCK.Visible = True
            End If
            If My.Settings.BoughtALClock = False Then
                CLOCK.Visible = False
            End If
            If My.Settings.BoughtALShifter = True Then
                ShifterTSMI.Visible = True
            End If
            If My.Settings.BoughtALShifter = False Then
                ShifterTSMI.Visible = False
            End If
            If My.Settings.BoughtALTextpad = True Then
                TextpadSTRIP.Visible = True
            End If
            If My.Settings.BoughtALTextpad = False Then
                TextpadSTRIP.Visible = False
            End If
            If My.Settings.BoughtALFileSkimmer = True Then
                FileSKIMMER.Visible = True
            End If
            If My.Settings.BoughtALFileSkimmer = False Then
                FileSKIMMER.Visible = False
            End If
        End If
    End Sub

    Private Sub SHUTDOWN_Click(sender As Object, e As EventArgs) Handles SHUTDOWN.Click
        Application.Exit()
    End Sub

    Private Sub CPCLICKER_Click(sender As Object, e As EventArgs) Handles CPCLICKER.Click
        CodepointClicker.Show()
        CodepointClicker.TopLevel = True
    End Sub

    Private Sub CLOCK_Click(sender As Object, e As EventArgs) Handles CLOCK.Click
        ShiftOSClock.Show()
        ShiftOSClock.TopLevel = True
    End Sub

    Public Sub startautocodepoints()
        autocp.Enabled = True
    End Sub

    Private Sub autocp_Tick(sender As Object, e As EventArgs) Handles autocp.Tick
        My.Settings.Codepoints = My.Settings.Codepoints + My.Settings.CPperClick2
    End Sub

    Private Sub MenuStrip1_Paint(sender As Object, e As PaintEventArgs) Handles MenuStrip1.Paint

    End Sub

    Private Sub ShifterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShifterTSMI.Click
        Shifter.Show()
        Shifter.TopLevel = True
    End Sub
    Private Sub changeclosebuttoncolor()
        My.Settings.closecolor = Shifter.closebuttoncolor.BackColor
        Terminal.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        Shifter.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        CodepointClicker.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        Shiftorium.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        ShiftOSClock.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        Textpad.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
        File_Skimmer.closebutton.BackColor = Shifter.closebuttoncolor.BackColor
    End Sub

    Private Sub desktopiconsbackground_SelectedIndexChanged(sender As Object, e As EventArgs) Handles desktopiconsbackground.SelectedIndexChanged

    End Sub

    Private Sub desktopiconsbackground_KeyDown(sender As Object, e As KeyEventArgs) Handles desktopiconsbackground.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Terminal.WindowState = FormWindowState.Maximized
            Terminal.pgbottom.Visible = False
            Terminal.pgbottomlcorner.Visible = False
            Terminal.pgbottomrcorner.Visible = False
            Terminal.pgleft.Visible = False
            Terminal.pgright.Visible = False
            Terminal.pgtoplcorner.Visible = False
            Terminal.pgtoprcorner.Visible = False
            Terminal.titlebar.Visible = False
            Terminal.Show()
            Terminal.TopLevel = True
        End If
    End Sub

    Private Sub TextpadSTRIP_Click(sender As Object, e As EventArgs) Handles TextpadSTRIP.Click
        Textpad.Show()
        Textpad.TopLevel = True
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub FileSKIMMER_Click(sender As Object, e As EventArgs) Handles FileSKIMMER.Click
        File_Skimmer.Show()
        File_Skimmer.TopLevel = True
    End Sub
End Class