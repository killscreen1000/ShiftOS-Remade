Public Class ShiftOSClock
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
    Private Sub toptext_Click(sender As Object, e As EventArgs) Handles toptext.Click

    End Sub

    Private Sub Clocktimer_Tick(sender As Object, e As EventArgs) Handles clocktimer.Tick

        If My.Settings.BoughtMinutesSinceMidnight = False Then
            toptext.Text = "Since Midnight"
            lbmaintime.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds)
            bottomtext.Text = "Seconds have passed"
            bottomtext.Show()
            ShiftOSDesktop.timelabel.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalSeconds)
        End If
        If My.Settings.BoughtMinutesSinceMidnight = True Then
            toptext.Text = "Since Midnight"
            lbmaintime.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes)
            bottomtext.Text = "Minutes have passed"
            bottomtext.Show()
            ShiftOSDesktop.timelabel.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalMinutes)
        End If
        If My.Settings.BoughtHoursSinceMidnight = True Then
            toptext.Text = "Since Midnight"
            lbmaintime.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalHours)
            bottomtext.Text = "Hours have passed"
            bottomtext.Show()
            ShiftOSDesktop.timelabel.Text = Math.Floor(Date.Now.Subtract(Date.Today).TotalHours)
        End If
        If My.Settings.BoughtPMandAM = True Then
            bottomtext.Hide()
            If Date.Now.Hour < 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = TimeOfDay.Hour & " AM"
                ShiftOSDesktop.timelabel.Text = TimeOfDay.Hour & " AM"
            End If
            If Date.Now.Hour = 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = "12 PM"
                ShiftOSDesktop.timelabel.Text = "12 PM"
            End If
            If Date.Now.Hour > 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = TimeOfDay.Hour - 12 & " PM"
                ShiftOSDesktop.timelabel.Text = TimeOfDay.Hour - 12 & " PM"
            End If
        End If
        If My.Settings.BoughtMinuteAccuracyTime = True Then
            bottomtext.Hide()
            toptext.Text = "The Time is"
            If Date.Now.Hour < 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = TimeOfDay.Hour & ":" & Format(TimeOfDay.Minute, "00") & " AM"
                bottomtext.Hide()
                ShiftOSDesktop.timelabel.Text = TimeOfDay.Hour & ":" & Format(TimeOfDay.Minute, "00") & " AM"
            End If
            If Date.Now.Hour = 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = "12:" & Format(TimeOfDay.Minute, "00") & " PM"
                bottomtext.Hide()
                ShiftOSDesktop.timelabel.Text = "12:" & Format(TimeOfDay.Minute, "00") & " PM"
            End If
            If Date.Now.Hour > 12 Then
                toptext.Text = "The Time is"
                lbmaintime.Text = TimeOfDay.Hour - 12 & ":" & Format(TimeOfDay.Minute, "00") & " PM"
                bottomtext.Hide()
                ShiftOSDesktop.timelabel.Text = TimeOfDay.Hour - 12 & ":" & Format(TimeOfDay.Minute, "00") & " PM"
            End If

        End If
        If My.Settings.BoughtSplitSecondTime = True Then
            bottomtext.Hide()
            toptext.Text = "The Time is"
            lbmaintime.Text = TimeOfDay
            ShiftOSDesktop.timelabel.Text = TimeOfDay
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

    Private Sub Clock_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        If My.Settings.BoughtCloseButton = False Then
            Me.closebutton.Visible = False
        End If
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
        End If
        If My.Settings.BoughtBorders = True Then
            Me.pgleft.Visible = True
            Me.pgbottom.Visible = True
            Me.pgright.Visible = True
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

    End Sub

    Private Sub pgcontents_Paint(sender As Object, e As PaintEventArgs) Handles pgcontents.Paint

    End Sub

    Private Sub lbmaintime_Click(sender As Object, e As EventArgs) Handles lbmaintime.Click

    End Sub

    Private Sub bottomtext_Click(sender As Object, e As EventArgs) Handles bottomtext.Click

    End Sub
End Class