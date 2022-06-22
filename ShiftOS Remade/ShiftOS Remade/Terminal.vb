Public Class Terminal
    Dim Command As String
    Dim Further As Boolean = True
    Dim trackpos As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        If My.Settings.TerminalWindowed = True Then
            Me.pgbottom.Visible = True
            Me.pgleft.Visible = True
            Me.pgright.Visible = True
            titlebar.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.Width = 650
            Me.Height = 400
            Me.Left = (Screen.PrimaryScreen.Bounds.Width - Me.Width) / 2
            Me.Top = (Screen.PrimaryScreen.Bounds.Height - Me.Height) / 2
        End If

        If My.Settings.TerminalWindowed = False Then
            Me.WindowState = FormWindowState.Maximized
            Me.pgbottom.Visible = False
            Me.pgbottomlcorner.Visible = False
            Me.pgbottomrcorner.Visible = False
            Me.pgleft.Visible = False
            Me.pgright.Visible = False
            Me.pgtoplcorner.Visible = False
            Me.pgtoprcorner.Visible = False
            titlebar.Visible = False
        End If
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
        End If
        If My.Settings.BoughtBorders = True Then
            If My.Settings.TerminalWindowed = True Then
                Me.pgleft.Visible = True
                Me.pgbottom.Visible = True
                Me.pgright.Visible = True
            End If
        End If

        If My.Settings.BoughtTitlebar = False Then
            titlebar.Visible = False
        End If


        If My.Settings.BoughtTitlebarText = True Then
            Me.lbtitletext.Visible = True
        End If

        If My.Settings.BoughtCloseButton = True Then
            Me.closebutton.BackColor = My.Settings.closecolor
            Me.closebutton.Visible = True
        End If
        If My.Settings.BoughtCloseButton = False Then
            Me.closebutton.Visible = False

        End If


        txtterm.Text = txtterm.Text + "user@shiftos$> "
        txtterm.Select(txtterm.Text.Length, 0)
        txtterm.Cursor = Nothing
        If My.Settings.BoughtTitlebar = False Then
            titlebar.Visible = False
        End If
    End Sub
    Private Sub ReadCommand()
        Command = txtterm.Lines(txtterm.Lines.Length - 1)
        Command = Command.ToLower()
    End Sub
#Region "Commands"
    Private Sub DoCommand()
        If Command Like "user@shiftos$> open *" Then
            Select Case Command
                Case "user@shiftos$> open codepoint clicker"
                    CodepointClicker.Show()
                    CodepointClicker.TopMost = True
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                    If My.Settings.TerminalWindowed = False Then
                        Me.Hide()
                    End If
                Case "user@shiftos$> open codepoint clicker"
                    CodepointClicker.Show()
                    CodepointClicker.TopMost = True
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                    If My.Settings.TerminalWindowed = False Then
                        Me.Hide()
                    End If
                Case "user@shiftos$> open shiftorium"
                    Shiftorium.Show()
                    Shiftorium.TopMost = True
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                    If My.Settings.TerminalWindowed = False Then
                        Me.Hide()
                    End If
                Case "user@shiftos$> open clock"
                    If My.Settings.BoughtClock = True Then
                        ShiftOSClock.Show()
                        ShiftOSClock.TopMost = True
                        txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                        If My.Settings.TerminalWindowed = False Then
                            Me.Hide()
                        End If
                    End If
                Case "user@shiftos$> open shifter"
                    If My.Settings.BoughtShifter = True Then
                        Shifter.Show()
                        Shifter.TopMost = True
                        txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                        If My.Settings.TerminalWindowed = False Then
                            Me.Hide()
                        End If
                    End If
            End Select
        End If
        If Command Like "user@shiftos$> close *" Then
            Select Case Command
                Case "user@shiftos$> close codepoint clicker"
                    CodepointClicker.Close()
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> close shiftorium"
                    Shiftorium.Close()
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> close terminal"
                    Me.Close()
                Case "user@shiftos$> close clock"
                    ShiftOSClock.Close()
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> close shifter"
                    Shifter.RemoveFonts()
                    Shifter.Close()
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
            End Select

        End If

        If Command Like "user@shiftos$> *" Then
            Select Case Command
                Case "user@shiftos$> 05tray"
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> gave user 500 codepoints" + Environment.NewLine + "user@shiftos$> "
                    My.Settings.Codepoints = My.Settings.Codepoints + 500
                Case "user@shiftos$> programs"
                    If My.Settings.BoughtClock = False Then
                        txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Programs:" + Environment.NewLine + Environment.NewLine + "Terminal - Application you are using right now that can type and recognize commands." + Environment.NewLine + "Codepoint Clicker - Game where you can click the button to earn codepoints, and you upgrade the amount of codepoints you make over time." + Environment.NewLine + "Shiftorium - App that you can buy upgrades from to improve your ShiftOS appearance." + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                    End If
                    If My.Settings.BoughtClock = True Then
                        txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Programs:" + Environment.NewLine + Environment.NewLine + "Terminal - Application you are using right now that can type and recognize commands." + Environment.NewLine + "Codepoint Clicker - Game where you can click the button to earn codepoints, and you upgrade the amount of codepoints you make over time." + Environment.NewLine + "Shiftorium - App that you can buy upgrades from to improve your ShiftOS appearance." + Environment.NewLine + "Clock - Application that you can use to tell the time; this was bought from the Shiftorium." + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                    End If
                    If My.Settings.BoughtShifter = True Then
                        If My.Settings.BoughtClock = True Then
                            txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Programs:" + Environment.NewLine + Environment.NewLine + "Terminal - Application you are using right now that can type and recognize commands." + Environment.NewLine + "Codepoint Clicker - Game where you can click the button to earn codepoints, and you upgrade the amount of codepoints you make over time." + Environment.NewLine + "Shiftorium - App that you can buy upgrades from to improve your ShiftOS appearance." + Environment.NewLine + "Clock - Application that you can use to tell the time; this was bought from the Shiftorium." + Environment.NewLine + "Shifter - Application that allows you to customize the look and feel of ShiftOS" + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                        End If
                        If My.Settings.BoughtClock = False Then
                            txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Programs:" + Environment.NewLine + Environment.NewLine + "Terminal - Application you are using right now that can type and recognize commands." + Environment.NewLine + "Codepoint Clicker - Game where you can click the button to earn codepoints, and you upgrade the amount of codepoints you make over time." + Environment.NewLine + "Shiftorium - App that you can buy upgrades from to improve your ShiftOS appearance." + Environment.NewLine + "Shifter - Application that allows you to customize the look and feel of ShiftOS" + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                        End If
                    End If
                Case "user@shiftos$> help"
                        If Not My.Settings.BoughtWindowedTerminal = True Then
                        txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Commands:" + Environment.NewLine + Environment.NewLine + "Programs - Command to see all of your installed programs" + Environment.NewLine + "Open [program name] - opens the program listed after 'open'" + Environment.NewLine + "Shutdown - Saves and shuts down the application" + Environment.NewLine + "Save - Saves your progress" + Environment.NewLine + "Codepoints - Lists all of your current codepoints you have" + Environment.NewLine + "Version - Lists the current version" + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                    End If
                    If My.Settings.BoughtWindowedTerminal = True Then
                        txtterm.Text = txtterm.Text + Environment.NewLine + Environment.NewLine + "Commands:" + Environment.NewLine + Environment.NewLine + "Programs - Command to see all of your installed programs" + Environment.NewLine + "Open [program name] - opens the program listed after 'open'" + Environment.NewLine + "Shutdown - Saves and shuts down the application" + Environment.NewLine + "Save - Saves your progress" + "Fullscreen/Windowed Terminal - Able to choose if you want the terminal to be fullscreen or windowed like other applications." + Environment.NewLine + "Codepoints - Lists all of your current codepoints you have" + Environment.NewLine + "Version - Lists the current version" + Environment.NewLine + Environment.NewLine + "user@shiftos$> "
                    End If

                Case "user@shiftos$> shutdown"
                    Application.Exit()
                Case "user@shiftos$> save"
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> saved all changes." + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> codepoints"
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> You have " & My.Settings.Codepoints & " codepoints." + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> version"
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> ShiftOS 0.0.5 Alpha 2 - June 20, 2022" + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> clear"
                    txtterm.Text = "user@shiftos$> "
                Case "user@shiftos$> clear codepoints"
                    My.Settings.Codepoints = 0
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> rmvupgrades"
                    Me.WindowState = FormWindowState.Maximized
                    My.Settings.TerminalWindowed = False
                    Me.titlebar.Visible = False
                    My.Settings.BoughtTitlebar = False
                    My.Settings.BoughtDesktopPanel = False
                    My.Settings.BoughtGray = False
                    My.Settings.BoughtBorders = False
                    My.Settings.BoughtTitlebarText = False
                    My.Settings.BoughtGraySet = False
                    My.Settings.BoughtALShiftorium = False
                    My.Settings.BoughtCloseButton = False
                    My.Settings.BoughtGrayShades = False
                    My.Settings.BoughtALShutdown = False
                    My.Settings.BoughtALCPClicker = False
                    My.Settings.BoughtClock = False
                    My.Settings.BoughtMinutesSinceMidnight = False
                    My.Settings.BoughtHoursSinceMidnight = False
                    My.Settings.BoughtPMandAM = False
                    My.Settings.BoughtALClock = False
                    My.Settings.BoughtMinuteAccuracyTime = False
                    My.Settings.BoughtSplitSecondTime = False
                    My.Settings.BoughtDesktopPanelClock = False
                    My.Settings.CPClickerUpgradeAmount = 10
                    My.Settings.CPperClick = 0.2
                    My.Settings.CPClickerUpgradeAmount2 = 100
                    My.Settings.CPperClick2 = 0
                    My.Settings.DoIntro = True
                    My.Settings.BoughtShifter = False
                    My.Settings.BoughtALShifter = False
                    My.Settings.closecolor = Color.Black
                    My.Settings.BoughtRed = False
                    My.Settings.BoughtOrange = False
                    My.Settings.BoughtYellow = False
                    My.Settings.BoughtGreen = False
                    My.Settings.BoughtBlue = False
                    My.Settings.BoughtPurple = False
                    My.Settings.BoughtPink = False
                    My.Settings.BoughtBrown = False
                    My.Settings.BoughtRedShades = False
                    My.Settings.BoughtOrangeShades = False
                    My.Settings.BoughtYellowShades = False
                    My.Settings.BoughtGreenShades = False
                    My.Settings.BoughtBlueShades = False
                    My.Settings.BoughtPurpleShades = False
                    My.Settings.BoughtPinkShades = False
                    My.Settings.BoughtBrownShades = False
                    My.Settings.BoughtRedSet = False
                    My.Settings.BoughtOrangeSet = False
                    My.Settings.BoughtYellowSet = False
                    My.Settings.BoughtGreenSet = False
                    My.Settings.BoughtBlueSet = False
                    My.Settings.BoughtPurpleSet = False
                    My.Settings.BoughtPinkSet = False
                    My.Settings.BoughtBrownSet = False
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
                    My.Settings.BoughtALFileSkimmer = False
                    My.Settings.BoughtFileSkimmer = False
                    Me.pgbottom.Visible = False
                    Me.pgbottomlcorner.Visible = False
                    Me.pgbottomrcorner.Visible = False
                    Me.pgleft.Visible = False
                    Me.pgright.Visible = False
                    Me.pgtoplcorner.Visible = False
                    Me.pgtoprcorner.Visible = False
                    Me.closebutton.BackColor = Color.Black
                    ShiftOSDesktop.ApplicationsToolStripMenuItem.Visible = False
                    ShiftOSDesktop.FLP.Visible = False
                    ShiftOSDesktop.timepanel.Visible = False
                    txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> all upgrades bought removed, please restart to apply changes." + Environment.NewLine + "user@shiftos$> "
                Case "user@shiftos$> windowed terminal"
                    If My.Settings.BoughtTitlebar = True Then
                        If My.Settings.TerminalWindowed = True Then
                            txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> already windowed!" + Environment.NewLine + "user@shiftos$> "
                        End If
                        If My.Settings.TerminalWindowed = False Then
                            If My.Settings.BoughtBorders = True Then
                                If My.Settings.BoughtTitlebarText = True Then
                                    lbtitletext.Visible = True
                                End If
                                If My.Settings.BoughtTitlebarText = False Then
                                    lbtitletext.Visible = False
                                End If
                                My.Settings.TerminalWindowed = True
                                pgleft.Visible = True
                                pgbottom.Visible = True
                                pgright.Visible = True
                                Me.Size = New Size(Me.Width + Me.pgleft.Width + Me.pgright.Width, Me.Height + Me.pgbottom.Height)
                                titlebar.Visible = True
                                Me.WindowState = FormWindowState.Normal
                                Me.Width = 650
                                Me.Height = 400
                                txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                            End If
                            If My.Settings.BoughtBorders = False Then
                                My.Settings.TerminalWindowed = True
                                titlebar.Visible = True
                                Me.WindowState = FormWindowState.Normal
                                Me.Width = 650
                                Me.Height = 400
                                txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                            End If
                        End If
                    End If
                Case "user@shiftos$> fullscreen terminal"
                        If My.Settings.TerminalWindowed = True Then
                        My.Settings.TerminalWindowed = False
                        Me.WindowState = FormWindowState.Maximized
                        Me.pgbottom.Visible = False
                        Me.pgbottomlcorner.Visible = False
                        Me.pgbottomrcorner.Visible = False
                        Me.pgleft.Visible = False
                        Me.pgright.Visible = False
                        Me.pgtoplcorner.Visible = False
                        Me.pgtoprcorner.Visible = False
                        titlebar.Visible = False
                        txtterm.Text = txtterm.Text + Environment.NewLine + "user@shiftos$> "
                    End If
            End Select
        End If
    End Sub
#End Region
    Private Sub txtterm_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtterm.KeyPress

    End Sub

    Private Sub txtterm_KeyDown(sender As Object, e As KeyEventArgs) Handles txtterm.KeyDown
        If e.KeyCode = Keys.Enter Then
            txtterm.ScrollToCaret()
            ReadCommand()
            DoCommand()

            e.SuppressKeyPress = True
        End If
    End Sub

    Private Sub txtterm_TextChanged(sender As Object, e As EventArgs) Handles txtterm.TextChanged

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        txtterm.Select(txtterm.Text.Length, 0)

        If My.Settings.TerminalWindowed = True Then
            titlebar.Visible = True
            Me.WindowState = FormWindowState.Normal
            Me.Width = 650
            Me.Height = 400
        End If
        If My.Settings.TerminalWindowed = False Then
            titlebar.Visible = False
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub
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
End Class
