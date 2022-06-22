Public Class Shiftorium
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
#Region "Upgrades"
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "Codepoints: " & My.Settings.Codepoints
        '0.0.3
        If ListBox1.SelectedItem = "Gray - 5 CP" Then
            upgradedescription.Text = "Want to be able to use the color 
Gray on your device? Well, now you can by just simply 
purchasing this item for 5 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegray
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 5 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 5 Then
                Button1.Text = "Gray - 5 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Titlebar - 10 CP" Then
            upgradedescription.Text = "Want to be able to have a titlebar on all of your 
windows? Well, now you can by just simply purchasing this 
item for 10 codepoints. Note that you will also be able to
drag windows around the screen as well once you
purchase this upgrade. You will also be able to type
''windowed terminal'' to window the terminal, and ''fullscreen
terminal'' to make the terminal fullscreen once you buy
this upgrade."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradetitlebar
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 10 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 10 Then
                Button1.Text = "Titlebar - 10 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Borders - 5 CP" Then
            upgradedescription.Text = "Want to be able to have borders on all
of your windows so that it looks cleaner? Well, this is a very
cheap upgrade that you can buy for 5 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradewindowborders
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 5 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 5 Then
                Button1.Text = "Borders - 5 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Desktop Panel - 100 CP" Then
            upgradedescription.Text = "Want a panel on the top of
your desktop that you can use to access an app launcher
where you can open programs? The catch is that this
upgrade is 100 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradedesktoppanel
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 100 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 100 Then
                Button1.Text = "Desktop Panel - 100 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Gray Shades - 20 CP" Then
            upgradedescription.Text = "Want access to more 
interesting gray shades than just black, gray, 
and white? Well, you can then buy this 
upgrade for 20 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegrayshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Gray Shades - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Titlebar Text - 25 CP" Then
            upgradedescription.Text = "Want to be able to 
have text on the titlebar of a program 
so that you know what that 
program specifically is? Well, then you can buy this 
upgrade for 25 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradetitletext
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "Titlebar Text - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Close Button - 60 CP" Then
            upgradedescription.Text = "Want to be able to close
the windows easily without having to manually type in
''close [program name]'' into the Terminal? Well, buy
this more expensive upgrade for 60 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeclosebutton
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 60 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 60 Then
                Button1.Text = "Close Button - 60 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Full Gray Shade Set - 30 CP" Then
            upgradedescription.Text = "Want to have
all of the shades of the Black to White spectrum?
Well, then you can buy this upgrade for 30 codepoints
to recieve all of the shades of White, Gray, and
Black."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegrayshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 30 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 30 Then
                Button1.Text = "Full Gray Shade Set - 30 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - Shiftorium - 25 CP" Then
            upgradedescription.Text = "Want to be able to easily
open the Shiftorium in the App Launcher Menu without
needing to type ''open shiftorium''? Well, you can then
buy this for 25 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradealshiftorium
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Shiftorium - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - Shutdown - 25 CP" Then
            upgradedescription.Text = "Want to be able to easily
shut down ShiftOS without needing to type ''shutdown''
in the Terminal? Well, then you should buy
this upgrade for 25 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeapplaunchershutdown
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Shutdown - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - CodepointClicker - 25 CP" Then
            upgradedescription.Text = "Have you thought
about being able to open your codepoint generation
program in the app launcher? This is now possible
and you can do it by just buying this upgrade for
25 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeknowledgeinput
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Codepoint Clicker - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Clock - 40 CP" Then
            upgradedescription.Text = "Have you wanted to know what
time it is while you are playing ShiftOS? Well, here's your
upgrade you've probably wanted for ages!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeclock
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Clock - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Minutes Since Midnight - 20 CP" Then
            upgradedescription.Text = "Do you want an interesting
method of tracking time? Then you should buy this, as you 
can now display minutes since midnight on your clock for
only 20 codepoints!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgrademinutesssincemidnight
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Minutes Since Midnight - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Hours Since Midnight - 40 CP" Then
            upgradedescription.Text = "Do you want a semi-normal
way of tracking time with your clock? Then, you should buy
this upgrade as it will display how many hours have passed 
since midnight for only 40 codepoints!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradehoursssincemidnight
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Hours Since Midnight - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "PM and AM - 80 CP" Then
            upgradedescription.Text = "Do you want
to know what hour of the day you are in and if it is the
morning or afternoon? Then you need this upgrade!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeamandpm
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "PM and AM - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - Clock - 25 CP" Then
            upgradedescription.Text = "Do you want to
be able to open your interesting clock in the
app launcher menu? Then you need this
upgrade!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradealclock
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Clock - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Minute Accuracy Time - 160 CP" Then
            upgradedescription.Text = "Want to know the exact hour
and minute of the day while using ShiftOS?
Well, you need this SUPER expensive upgrade then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgrademinuteaccuracytime
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 160 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 160 Then
                Button1.Text = "Minute Accuracy Time - 160 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Split Second Time - 320 CP" Then
            upgradedescription.Text = "Would you like to
know the exact hour, minute, and second of the day when
using ShiftOS? Well, you need this upgrade."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradesplitsecondaccuracy
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 320 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 320 Then
                Button1.Text = "Split Second Time - 320 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Desktop Panel Clock - 40 CP" Then
            upgradedescription.Text = "Want to be
able to see the time of the day on your top panel? Then
you need this upgrade!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradedesktoppanelclock
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Desktop Panel Clock - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Shifter - 100 CP" Then
            upgradedescription.Text = "Want to be able to customize
ShiftOS to your liking? Then you can start with the colors
you have bought so far and continue from there to begin
customizing ShiftOS!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeshifter
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "Shifter - 100 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - Shifter - 25 CP" Then
            upgradedescription.Text = "Would you like to be able
to open your customization app, Shifter, in the
application launcher? Then you need this upgrade!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradealshifter
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Shifter - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Red - 20 CP" Then
            upgradedescription.Text = "Want to be able to have
a valuable and important color of the entire color
spectrum, red? Then, you should buy this upgrade.
If you bought the Shifter, you can then customize 
ShiftOS with this color."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradered
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Red - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Orange - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with an offbrand version
of Red? Well, you now can by buying this
for 20 codepoints."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeorange
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Orange - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Yellow - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of some
flowers, or the sun on a hot day? Well, you
should buy this upgrade then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeyellow
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Yellow - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Green - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of grass? 
Well, you should buy this upgrade then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegreen
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Green - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Blue - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of the sky
or water? Well, you should buy this upgrade
then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeblue
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Blue - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Purple - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of blueberries?
(yes, blueberries are purple.) Well, you should 
buy this upgrade then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepurple
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Purple - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Pink - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of sunsets?
Well, you should buy this upgrade then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepink
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Pink - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Brown - 20 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with the color of dirt?
Well, you should buy this upgrade then."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradebrown
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 20 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 20 Then
                Button1.Text = "Brown - 20 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Red Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able to have
shades of red? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgraderedshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Red Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Orange Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with shades of
orange? You can buy this then to appease you!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeorangeshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Orange Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Yellow Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with shades of
yellow? You can buy this upgrade then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeyellowshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Yellow Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Green Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with shades of green?
You should buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegreenshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Green Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Blue Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with blue shades? You
should buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeblueshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Blue Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Purple Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with purple shades? You
should buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepurpleshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Purple Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Pink Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with pink shades? You
should buy this then! :3"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepinkshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Pink Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Brown Shades - 40 CP" Then
            upgradedescription.Text = "Want to be able
to customize ShiftOS with brown ugly shades?
You should NOT buy this, but if you
really want to deal with damn dirt, buy this
I guess. ;)"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradebrownshades
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 40 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 40 Then
                Button1.Text = "Brown Shades - 40 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Red Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of red? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgraderedshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Red Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Orange Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of orange? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeorangeshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Orange Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Yellow Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of yellow? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeyellowshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Yellow Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Green Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of green? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradegreenshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Green Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Blue Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of blue? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradeblueshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Blue Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Purple Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of purple? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepurpleshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Purple Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Pink Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of pink? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradepinkshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Pink Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Brown Shade Set - 80 CP" Then
            upgradedescription.Text = "Want to be able to have
ALL shades of brown? You can buy this then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradebrownshadeset
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 80 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 80 Then
                Button1.Text = "Brown Shade Set - 80 CP"
            End If
        End If
        If ListBox1.SelectedItem = "Textpad - 60 CP" Then
            upgradedescription.Text = "Want to be able
to save text documents with a program? Well
now you can! :D"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradetextpad
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 60 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 60 Then
                Button1.Text = "Textpad - 60 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - Textpad - 25 CP" Then
            upgradedescription.Text = "Want to be able
to open your magnificent Textpad program without
needing to go into the terminal? Then you need this
upgrade."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradealtextpad
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - Textpad - 25 CP"
            End If
        End If
        If ListBox1.SelectedItem = "File Skimmer - 100 CP" Then
            upgradedescription.Text = "Would you like to
be able to browse all of your files on your device? Well,
you should buy this upgrade then!"
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradefileskimmer
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 100 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 100 Then
                Button1.Text = "File Skimmer - 100 CP"
            End If
        End If
        If ListBox1.SelectedItem = "AL - File Skimmer - 25 CP" Then
            upgradedescription.Text = "Want to be able
to open your magnificent File Skimmer without
needing to go into the terminal? Then you need this
upgrade."
            upgradedescription.Visible = True
            upgradepreview.Image = My.Resources.upgradealfileskimmer
            upgradepreview.Visible = True
            Button1.Visible = True
            If My.Settings.Codepoints < 25 Then
                Button1.Text = "Can't Afford"
            End If
            If My.Settings.Codepoints >= 25 Then
                Button1.Text = "AL - File Skimmer - 25 CP"
            End If
        End If
    End Sub
#End Region

    Private Sub Shiftorium_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Terminal.Show()
            Terminal.TopLevel = True
            Me.Hide()
        End If
    End Sub

    Private Sub Shiftorium_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
            Me.pgleft.Visible = True
            Me.pgbottom.Visible = True
            Me.pgright.Visible = True
        End If
        If My.Settings.BoughtGray = True Then
            ListBox1.Items.Remove("Gray - 5 CP")
            ListBox1.Items.Add("Titlebar - 10 CP")
            ListBox1.Items.Add("Borders - 5 CP")
            ListBox1.Items.Add("Gray Shades - 20 CP")
            ListBox1.Items.Add("Desktop Panel - 100 CP")
            ListBox1.Items.Add("Clock - 40 CP")
            ListBox1.Items.Add("Shifter - 100 CP")
            ListBox1.Items.Add("Textpad - 60 CP")
            ListBox1.Items.Add("File Skimmer - 100 CP")
        End If

        If My.Settings.BoughtTitlebar = True Then
            ListBox1.Items.Remove("Titlebar - 10 CP")
            ListBox1.Items.Add("Titlebar Text - 25 CP")
            ListBox1.Items.Add("Close Button - 60 CP")
        End If

        If My.Settings.BoughtBorders = True Then
            ListBox1.Items.Remove("Borders - 5 CP")
            showborders()
        End If
        If My.Settings.BoughtDesktopPanel = True Then
            ShiftOSDesktop.MenuStrip1.Visible = True
            ShiftOSDesktop.FLP.Visible = True
            ShiftOSDesktop.timepanel.Visible = True
            ListBox1.Items.Remove("Desktop Panel - 100 CP")
            ListBox1.Items.Add("AL - Shiftorium - 25 CP")
            ListBox1.Items.Add("AL - CodepointClicker - 25 CP")
            ListBox1.Items.Add("AL - Shutdown - 25 CP")
            If My.Settings.BoughtShifter = True Then
                ListBox1.Items.Add("AL - Shifter - 25 CP")
            End If
            If My.Settings.BoughtTextpad = True Then
                ListBox1.Items.Add("AL - Textpad - 25 CP")
            End If
        End If
        If My.Settings.BoughtDesktopPanel = False Then
            ShiftOSDesktop.MenuStrip1.Visible = False
        End If
        If My.Settings.BoughtTitlebar = False Then
            titlebar.Visible = False
        End If
        If My.Settings.BoughtGrayShades = True Then
            ListBox1.Items.Remove("Gray Shades - 20 CP")
            ListBox1.Items.Add("Full Gray Shade Set - 30 CP")
        End If

        If My.Settings.BoughtTitlebarText = True Then
            ListBox1.Items.Remove("Titlebar Text - 25 CP")
            showtitlebartext()
        End If

        If My.Settings.BoughtCloseButton = True Then
            ListBox1.Items.Remove("Close Button - 60 CP")
            Me.closebutton.BackColor = My.Settings.closecolor
            showclosebuttons()
        End If
        If My.Settings.BoughtCloseButton = False Then
            Terminal.closebutton.Visible = False
            Shifter.closebutton.Visible = False
            Me.closebutton.Visible = False
            CodepointClicker.closebutton.Visible = False
            Color_Picker.closebutton.Visible = False
            infobox.closebutton.Visible = False
            ShiftOSClock.closebutton.Visible = False
        End If
        If My.Settings.BoughtGraySet = True Then
            ListBox1.Items.Remove("Full Gray Shade Set - 30 CP")
            ListBox1.Items.Add("Red - 20 CP")
            ListBox1.Items.Add("Orange - 20 CP")
            ListBox1.Items.Add("Yellow - 20 CP")
            ListBox1.Items.Add("Green - 20 CP")
            ListBox1.Items.Add("Blue - 20 CP")
            ListBox1.Items.Add("Purple - 20 CP")
            ListBox1.Items.Add("Pink - 20 CP")
            ListBox1.Items.Add("Brown - 20 CP")
        End If
        If My.Settings.BoughtALShiftorium = False Then
            If My.Settings.BoughtDesktopPanel = True Then

            End If
        End If
        If My.Settings.BoughtALShiftorium = True Then
            ListBox1.Items.Remove("AL - Shiftorium - 25 CP")
        End If

        If My.Settings.BoughtALShutdown = False Then
            If My.Settings.BoughtDesktopPanel = True Then

                ShiftOSDesktop.ToolStripSeparator1.Visible = False
                ShiftOSDesktop.SHUTDOWN.Visible = False
            End If
        End If
        If My.Settings.BoughtALShutdown = True Then
                ListBox1.Items.Remove("AL - Shutdown - 25 CP")
                ShiftOSDesktop.ToolStripSeparator1.Visible = True
                ShiftOSDesktop.SHUTDOWN.Visible = True
            End If
        If My.Settings.BoughtALCPClicker = False Then
            If My.Settings.BoughtDesktopPanel = True Then

                ShiftOSDesktop.CPCLICKER.Visible = False
            End If
        End If
        If My.Settings.BoughtALCPClicker = True Then
            ListBox1.Items.Remove("AL - CodepointClicker - 25 CP")
            ShiftOSDesktop.CPCLICKER.Visible = True
        End If
        If My.Settings.BoughtClock = True Then
            ListBox1.Items.Remove("Clock - 40 CP")
            If My.Settings.BoughtMinutesSinceMidnight = False Then
                ListBox1.Items.Add("Minutes Since Midnight - 20 CP")
            End If
            If My.Settings.BoughtMinutesSinceMidnight = True Then
                ListBox1.Items.Remove("Minutes Since Midnight - 20 CP")
            End If
            If My.Settings.BoughtHoursSinceMidnight = False Then
                If My.Settings.BoughtMinutesSinceMidnight = True Then
                    ListBox1.Items.Add("Hours Since Midnight - 40 CP")
                End If
            End If
            If My.Settings.BoughtHoursSinceMidnight = True Then
                ListBox1.Items.Remove("Hours Since Midnight - 40 CP")
            End If
            If My.Settings.BoughtPMandAM = False Then
                If My.Settings.BoughtHoursSinceMidnight = True Then
                    If My.Settings.BoughtMinutesSinceMidnight = True Then
                        ListBox1.Items.Add("PM and AM - 80 CP")
                    End If
                End If
            End If
            If My.Settings.BoughtPMandAM = True Then
                ListBox1.Items.Remove("PM and AM - 80 CP")
            End If
            If My.Settings.BoughtMinuteAccuracyTime = False Then
                If My.Settings.BoughtPMandAM = True Then
                    If My.Settings.BoughtHoursSinceMidnight = True Then
                        If My.Settings.BoughtMinutesSinceMidnight = True Then
                            ListBox1.Items.Add("Minute Accuracy Time - 160 CP")
                        End If
                    End If
                End If
            End If
            If My.Settings.BoughtMinuteAccuracyTime = True Then
                ListBox1.Items.Remove("Minute Accuracy Time - 160 CP")
                ListBox1.Items.Add("Split Second Time - 320 CP")
            End If
            If My.Settings.BoughtSplitSecondTime = False Then
                If My.Settings.BoughtMinuteAccuracyTime = True Then
                    If My.Settings.BoughtPMandAM = True Then
                        If My.Settings.BoughtHoursSinceMidnight = True Then
                            If My.Settings.BoughtMinutesSinceMidnight = True Then
                                ListBox1.Items.Add("Split Second Time - 320 CP")
                            End If
                        End If
                    End If
                End If
            End If
            If My.Settings.BoughtSplitSecondTime = True Then
                ListBox1.Items.Remove("Split Second Time - 320 CP")
            End If
        End If
        If My.Settings.BoughtALClock = False Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.BoughtClock = True Then
                    ListBox1.Items.Add("AL - Clock - 25 CP")
                    ShiftOSDesktop.CLOCK.Visible = False
                End If
            End If
            End If
        If My.Settings.BoughtALClock = True Then
            ListBox1.Items.Remove("AL - Clock - 25 CP")
            ShiftOSDesktop.CLOCK.Visible = True
        End If
        If My.Settings.BoughtDesktopPanelClock = False Then
            If My.Settings.BoughtClock = True Then
                If My.Settings.BoughtDesktopPanel = True Then
                    ListBox1.Items.Add("Desktop Panel Clock - 40 CP")
                End If
            End If
        End If
        If My.Settings.BoughtDesktopPanelClock = True Then
            ListBox1.Items.Remove("Desktop Panel Clock - 40 CP")
        End If
        If My.Settings.BoughtShifter = True Then
            ListBox1.Items.Remove("Shifter - 100 CP")
            If My.Settings.BoughtALShifter = True Then
                ListBox1.Items.Remove("AL - Shifter - 25 CP")
            End If
        End If
        If My.Settings.BoughtRed = True Then
            ListBox1.Items.Remove("Red - 20 CP")
            ListBox1.Items.Add("Red Shades - 40 CP")
        End If
        If My.Settings.BoughtRedShades = True Then
            ListBox1.Items.Remove("Red Shades - 40 CP")
            ListBox1.Items.Add("Red Shade Set - 80 CP")
        End If
        If My.Settings.BoughtOrange = True Then
            ListBox1.Items.Remove("Orange - 20 CP")
            ListBox1.Items.Add("Orange Shades - 40 CP")
        End If
        If My.Settings.BoughtOrangeShades = True Then
            ListBox1.Items.Remove("Orange Shades - 40 CP")
            ListBox1.Items.Add("Orange Shade Set - 80 CP")
        End If
        If My.Settings.BoughtYellow = True Then
            ListBox1.Items.Remove("Yellow - 20 CP")
            ListBox1.Items.Add("Yellow Shades - 40 CP")
        End If
        If My.Settings.BoughtYellowShades = True Then
            ListBox1.Items.Remove("Yellow Shades - 40 CP")
            ListBox1.Items.Add("Yellow Shade Set - 80 CP")
        End If
        If My.Settings.BoughtGreen = True Then
            ListBox1.Items.Remove("Green - 20 CP")
            ListBox1.Items.Add("Green Shades - 40 CP")
        End If
        If My.Settings.BoughtGreenShades = True Then
            ListBox1.Items.Remove("Green Shades - 40 CP")
            ListBox1.Items.Add("Green Shade Set - 80 CP")
        End If
        If My.Settings.BoughtBlue = True Then
            ListBox1.Items.Remove("Blue - 20 CP")
            ListBox1.Items.Add("Blue Shades - 40 CP")
        End If
        If My.Settings.BoughtBlueShades = True Then
            ListBox1.Items.Remove("Blue Shades - 40 CP")
            ListBox1.Items.Add("Blue Shade Set - 80 CP")
        End If
        If My.Settings.BoughtPurple = True Then
            ListBox1.Items.Remove("Purple - 20 CP")
            ListBox1.Items.Add("Purple Shades - 40 CP")
        End If
        If My.Settings.BoughtPurpleShades = True Then
            ListBox1.Items.Remove("Purple Shades - 40 CP")
            ListBox1.Items.Add("Purple Shade Set - 80 CP")
        End If
        If My.Settings.BoughtPink = True Then
            ListBox1.Items.Remove("Pink - 20 CP")
            ListBox1.Items.Add("Pink Shades - 40 CP")
        End If
        If My.Settings.BoughtPinkShades = True Then
            ListBox1.Items.Remove("Pink Shades - 40 CP")
            ListBox1.Items.Add("Pink Shade Set - 80 CP")
        End If
        If My.Settings.BoughtBrown = True Then
            ListBox1.Items.Remove("Brown - 20 CP")
            ListBox1.Items.Add("Brown Shades - 40 CP")
        End If
        If My.Settings.BoughtBrownShades = True Then
            ListBox1.Items.Remove("Brown Shades - 40 CP")
            ListBox1.Items.Add("Brown Shade Set - 80 CP")
        End If
        If My.Settings.BoughtRedSet = True Then
            ListBox1.Items.Remove("Red Shade Set - 80 CP")
        End If
        If My.Settings.BoughtOrangeSet = True Then
            ListBox1.Items.Remove("Orange Shade Set - 80 CP")
        End If
        If My.Settings.BoughtYellowSet = True Then
            ListBox1.Items.Remove("Yellow Shade Set - 80 CP")
        End If
        If My.Settings.BoughtGreenSet = True Then
            ListBox1.Items.Remove("Green Shade Set - 80 CP")
        End If
        If My.Settings.BoughtBlueSet = True Then
            ListBox1.Items.Remove("Blue Shade Set - 80 CP")
        End If
        If My.Settings.BoughtPurpleSet = True Then
            ListBox1.Items.Remove("Purple Shade Set - 80 CP")
        End If
        If My.Settings.BoughtPinkSet = True Then
            ListBox1.Items.Remove("Pink Shade Set - 80 CP")
        End If
        If My.Settings.BoughtBrownSet = True Then
            ListBox1.Items.Remove("Brown Shade Set - 80 CP")
        End If
        If My.Settings.BoughtTextpad = True Then
            ListBox1.Items.Remove("Textpad - 60 CP")
        End If
        If My.Settings.BoughtALTextpad = True Then
            ShiftOSDesktop.TextpadSTRIP.Visible = True
            ListBox1.Items.Remove("AL - Textpad - 25 CP")
        End If
        If My.Settings.BoughtFileSkimmer = True Then
            ListBox1.Items.Remove("File Skimmer - 100 CP")
        End If
        If My.Settings.BoughtALTextpad = True Then
            ShiftOSDesktop.FileSKIMMER.Visible = True
            ListBox1.Items.Remove("AL - File Skimmer - 25 CP")
        End If
    End Sub
#Region "Removing and Adding Upgrades"
#Region "0.0.3 Upgrades"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ListBox1.SelectedItem = "Gray - 5 CP" Then
            If My.Settings.Codepoints > 5 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 5
                My.Settings.BoughtGray = True
                Button1.Hide()
                ListBox1.Items.Remove("Gray - 5 CP")
                ListBox1.Items.Add("Titlebar - 10 CP")
                ListBox1.Items.Add("Borders - 5 CP")
                ListBox1.Items.Add("Gray Shades - 20 CP")
                ListBox1.Items.Add("Desktop Panel - 100 CP")
                ListBox1.Items.Add("Clock - 40 CP")
                ListBox1.Items.Add("Shifter - 100 CP")
                ListBox1.Items.Add("Textpad - 60 CP")
                ListBox1.Items.Add("File Skimmer - 100 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 5 Then

            End If
        End If
        If ListBox1.SelectedItem = "Titlebar - 10 CP" Then
            If My.Settings.BoughtGray = True Then
                If My.Settings.Codepoints > 10 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 10
                    Terminal.closebutton.Visible = False
                    Shifter.closebutton.Visible = False
                    Me.closebutton.Visible = False
                    CodepointClicker.closebutton.Visible = False
                    My.Settings.BoughtTitlebar = True
                    Button1.Hide()
                    ListBox1.Items.Remove("Titlebar - 10 CP")
                    ListBox1.Items.Add("Titlebar Text - 25 CP")
                    ListBox1.Items.Add("Close Button - 60 CP")
                    showtitlebar()
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 10 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "Borders - 5 CP" Then
            If My.Settings.BoughtGray = True Then
                If My.Settings.Codepoints > 5 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 5
                    My.Settings.BoughtBorders = True
                    Button1.Hide()
                    ListBox1.Items.Remove("Borders - 5 CP")
                    showborders()
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 5 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "Desktop Panel - 100 CP" Then
            If My.Settings.BoughtGray = True Then
                If My.Settings.Codepoints > 100 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 100
                    My.Settings.BoughtDesktopPanel = True
                    Button1.Hide()
                    ListBox1.Items.Remove("Desktop Panel - 100 CP")
                    ListBox1.Items.Add("AL - Shiftorium - 25 CP")
                    ListBox1.Items.Add("AL - CodepointClicker - 25 CP")
                    ListBox1.Items.Add("AL - Shutdown - 25 CP")
                    ListBox1.Items.Add("Desktop Panel Clock - 40 CP")
                    If My.Settings.BoughtClock = True Then
                        If My.Settings.BoughtALClock = False Then
                            ListBox1.Items.Add("AL - Clock - 25 CP")
                        End If
                    End If
                    If My.Settings.BoughtShifter = True Then
                        ListBox1.Items.Add("AL - Shifter - 25 CP")
                    End If
                    If My.Settings.BoughtTextpad = True Then
                        ListBox1.Items.Add("AL - Shifter - 25 CP")
                    End If
                    showdesktoppanel()
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 100 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "Gray Shades - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtGrayShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Gray Shades - 20 CP")
                ListBox1.Items.Add("Full Gray Shade Set - 30 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 5 Then

            End If
        End If
        If ListBox1.SelectedItem = "Titlebar Text - 25 CP" Then
            If My.Settings.Codepoints > 25 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 25
                My.Settings.BoughtTitlebarText = True
                showtitlebartext()
                Button1.Hide()
                ListBox1.Items.Remove("Titlebar Text - 25 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 25 Then

            End If
        End If
        If ListBox1.SelectedItem = "Close Button - 60 CP" Then
            If My.Settings.Codepoints > 60 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 60
                My.Settings.BoughtCloseButton = True
                showclosebuttons()
                Button1.Hide()
                ListBox1.Items.Remove("Close Button - 60 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 60 Then

            End If
        End If
        If ListBox1.SelectedItem = "Full Gray Shade Set - 30 CP" Then
            If My.Settings.Codepoints > 30 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 30
                My.Settings.BoughtGraySet = True
                Button1.Hide()
                ListBox1.Items.Remove("Full Gray Shade Set - 30 CP")
                ListBox1.Items.Add("Red - 20 CP")
                ListBox1.Items.Add("Orange - 20 CP")
                ListBox1.Items.Add("Yellow - 20 CP")
                ListBox1.Items.Add("Green - 20 CP")
                ListBox1.Items.Add("Blue - 20 CP")
                ListBox1.Items.Add("Purple - 20 CP")
                ListBox1.Items.Add("Pink - 20 CP")
                ListBox1.Items.Add("Brown - 20 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 30 Then

            End If
        End If
        If ListBox1.SelectedItem = "AL - Shiftorium - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.Codepoints > 25 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 25
                    My.Settings.BoughtALShiftorium = True
                    ShiftOSDesktop.SHIFTORIUMSTRIP.Visible = True
                    Button1.Hide()
                    ListBox1.Items.Remove("AL - Shiftorium - 25 CP")
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 25 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "AL - Shutdown - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.Codepoints > 25 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 25
                    My.Settings.BoughtALShutdown = True
                    ShiftOSDesktop.ToolStripSeparator1.Visible = True
                    ShiftOSDesktop.SHUTDOWN.Visible = True
                    Button1.Hide()
                    ListBox1.Items.Remove("AL - Shutdown - 25 CP")
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 25 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "AL - CodepointClicker - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.Codepoints > 25 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 25
                    My.Settings.BoughtALCPClicker = True
                    ShiftOSDesktop.CPCLICKER.Visible = True
                    Button1.Hide()
                    ListBox1.Items.Remove("AL - CodepointClicker - 25 CP")
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 25 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "Clock - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtClock = True
                Button1.Hide()
                ListBox1.Items.Remove("Clock - 40 CP")
                ListBox1.Items.Add("Minutes Since Midnight - 20 CP")
                If My.Settings.BoughtDesktopPanel = True Then
                    ListBox1.Items.Add("AL - Clock - 25 CP")
                End If
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Minutes Since Midnight - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtMinutesSinceMidnight = True
                Button1.Hide()
                ListBox1.Items.Remove("Minutes Since Midnight - 20 CP")
                ListBox1.Items.Add("Hours Since Midnight - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Hours Since Midnight - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtHoursSinceMidnight = True
                Button1.Hide()
                ListBox1.Items.Remove("Hours Since Midnight - 40 CP")
                ListBox1.Items.Add("PM and AM - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "PM and AM - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtPMandAM = True
                Button1.Hide()
                ListBox1.Items.Remove("PM and AM - 80 CP")
                ListBox1.Items.Add("Minute Accuracy Time - 160 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "AL - Clock - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.Codepoints > 25 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 25
                    My.Settings.BoughtALClock = True
                    ShiftOSDesktop.CLOCK.Visible = True
                    Button1.Hide()
                    ListBox1.Items.Remove("AL - Clock - 25 CP")
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 25 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "Minute Accuracy Time - 160 CP" Then
            If My.Settings.Codepoints > 160 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 160
                My.Settings.BoughtMinuteAccuracyTime = True
                Button1.Hide()
                ListBox1.Items.Remove("Minute Accuracy Time - 160 CP")
                ListBox1.Items.Add("Split Second Time - 320 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 160 Then

            End If
        End If
        If ListBox1.SelectedItem = "Split Second Time - 320 CP" Then
            If My.Settings.Codepoints > 320 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 320
                My.Settings.BoughtSplitSecondTime = True
                Button1.Hide()
                ListBox1.Items.Remove("Split Second Time - 320 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 320 Then

            End If
        End If
        If ListBox1.SelectedItem = "Desktop Panel Clock - 40 CP" Then
            If My.Settings.BoughtClock = True Then
                If My.Settings.BoughtDesktopPanel = True Then
                    If My.Settings.Codepoints > 40 Then
                        My.Settings.Codepoints = My.Settings.Codepoints - 40
                        My.Settings.BoughtDesktopPanelClock = True
                        Button1.Hide()
                        ListBox1.Items.Remove("Desktop Panel Clock - 40 CP")
                        ShiftOSDesktop.timelabel.Visible = True
                        upgradedescription.Hide()
                        upgradepreview.Hide()
                    ElseIf My.Settings.Codepoints < 40 Then

                    End If
                End If
            End If
        End If
#End Region
#Region "0.0.4 Upgrades"
        If ListBox1.SelectedItem = "Shifter - 100 CP" Then
            If My.Settings.BoughtGray = True Then
                If My.Settings.Codepoints > 25 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 25
                    My.Settings.BoughtShifter = True
                    Button1.Hide()
                    ListBox1.Items.Remove("Shifter - 100 CP")
                    If My.Settings.BoughtDesktopPanel = True Then
                        ListBox1.Items.Add("AL - Shifter - 25 CP")
                    End If
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 40 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "AL - Shifter - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.BoughtShifter = True Then
                    If My.Settings.Codepoints > 25 Then
                        My.Settings.Codepoints = My.Settings.Codepoints - 25
                        My.Settings.BoughtALShifter = True
                        ShiftOSDesktop.ShifterTSMI.Visible = True
                        Button1.Hide()
                        ListBox1.Items.Remove("AL - Shifter - 25 CP")
                        upgradedescription.Hide()
                        upgradepreview.Hide()
                    ElseIf My.Settings.Codepoints < 25 Then

                    End If
                End If
            End If
        End If
        If ListBox1.SelectedItem = "Red - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtRed = True
                Button1.Hide()
                ListBox1.Items.Remove("Red - 20 CP")
                ListBox1.Items.Add("Red Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Orange - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtOrange = True
                Button1.Hide()
                ListBox1.Items.Remove("Orange - 20 CP")
                ListBox1.Items.Add("Orange Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Yellow - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtYellow = True
                Button1.Hide()
                ListBox1.Items.Remove("Yellow - 20 CP")
                ListBox1.Items.Add("Yellow Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Green - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtGreen = True
                Button1.Hide()
                ListBox1.Items.Remove("Green - 20 CP")
                ListBox1.Items.Add("Green Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Blue - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtBlue = True
                Button1.Hide()
                ListBox1.Items.Remove("Blue - 20 CP")
                ListBox1.Items.Add("Blue Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Purple - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtPurple = True
                Button1.Hide()
                ListBox1.Items.Remove("Purple - 20 CP")
                ListBox1.Items.Add("Purple Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Pink - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtPink = True
                Button1.Hide()
                ListBox1.Items.Remove("Pink - 20 CP")
                ListBox1.Items.Add("Pink Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Brown - 20 CP" Then
            If My.Settings.Codepoints > 20 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 20
                My.Settings.BoughtBrown = True
                Button1.Hide()
                ListBox1.Items.Remove("Brown - 20 CP")
                ListBox1.Items.Add("Brown Shades - 40 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 20 Then

            End If
        End If
        If ListBox1.SelectedItem = "Red Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtRedShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Red Shades - 40 CP")
                ListBox1.Items.Add("Red Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Orange Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtOrangeShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Orange Shades - 40 CP")
                ListBox1.Items.Add("Orange Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Yellow Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtYellowShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Yellow Shades - 40 CP")
                ListBox1.Items.Add("Yellow Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Green Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtGreenShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Green Shades - 40 CP")
                ListBox1.Items.Add("Green Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Blue Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtBlueShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Blue Shades - 40 CP")
                ListBox1.Items.Add("Blue Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Purple Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtPurpleShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Purple Shades - 40 CP")
                ListBox1.Items.Add("Purple Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Pink Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtPinkShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Pink Shades - 40 CP")
                ListBox1.Items.Add("Pink Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 40 Then

            End If
        End If
        If ListBox1.SelectedItem = "Brown Shades - 40 CP" Then
            If My.Settings.Codepoints > 40 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 40
                My.Settings.BoughtBrownShades = True
                Button1.Hide()
                ListBox1.Items.Remove("Brown Shades - 40 CP")
                ListBox1.Items.Add("Brown Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Red Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtRedSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Red Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Orange Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtOrangeSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Orange Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Yellow Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtYellowSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Yellow Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Green Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtGreenSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Green Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Blue Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtBlueSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Blue Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Purple Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtPurpleSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Purple Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Pink Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtPinkSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Pink Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
        If ListBox1.SelectedItem = "Brown Shade Set - 80 CP" Then
            If My.Settings.Codepoints > 80 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 80
                My.Settings.BoughtBrownSet = True
                Button1.Hide()
                ListBox1.Items.Remove("Brown Shade Set - 80 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 80 Then

            End If
        End If
#End Region
#Region "0.0.5 Upgrades"
        If ListBox1.SelectedItem = "Textpad - 60 CP" Then
            If My.Settings.Codepoints > 60 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 60
                My.Settings.BoughtTextpad = True
                Button1.Hide()
                ListBox1.Items.Remove("Textpad - 60 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 60 Then

            End If
        End If
        If ListBox1.SelectedItem = "AL - Textpad - 25 CP" Then
            If My.Settings.Codepoints > 25 Then
                My.Settings.Codepoints = My.Settings.Codepoints - 25
                My.Settings.BoughtALTextpad = True
                ShiftOSDesktop.TextpadSTRIP.Visible = True
                Button1.Hide()
                ListBox1.Items.Remove("AL - Textpad - 25 CP")
                upgradedescription.Hide()
                upgradepreview.Hide()
            ElseIf My.Settings.Codepoints < 60 Then

            End If
        End If
        If ListBox1.SelectedItem = "File Skimmer - 100 CP" Then
            If My.Settings.BoughtGray = True Then
                If My.Settings.Codepoints > 100 Then
                    My.Settings.Codepoints = My.Settings.Codepoints - 100
                    My.Settings.BoughtFileSkimmer = True
                    Button1.Hide()
                    ListBox1.Items.Remove("File Skimmer - 100 CP")
                    If My.Settings.BoughtDesktopPanel = True Then
                        ListBox1.Items.Add("AL - File Skimmer - 25 CP")
                    End If
                    upgradedescription.Hide()
                    upgradepreview.Hide()
                ElseIf My.Settings.Codepoints < 40 Then

                End If
            End If
        End If
        If ListBox1.SelectedItem = "AL - File Skimmer - 25 CP" Then
            If My.Settings.BoughtDesktopPanel = True Then
                If My.Settings.BoughtFileSkimmer = True Then
                    If My.Settings.Codepoints > 25 Then
                        My.Settings.Codepoints = My.Settings.Codepoints - 25
                        My.Settings.BoughtALFileSkimmer = True
                        ShiftOSDesktop.FileSKIMMER.Visible = True
                        Button1.Hide()
                        ListBox1.Items.Remove("AL - File Skimmer - 25 CP")
                        upgradedescription.Hide()
                        upgradepreview.Hide()
                    ElseIf My.Settings.Codepoints < 25 Then

                    End If
                End If
            End If
        End If
    End Sub
#End Region
#End Region
#Region "What the upgrades do when bought"
    Private Sub showtitlebar()
        Me.titlebar.Visible = True
        titlebar.Show()
        Terminal.titlebar.Visible = True
        CodepointClicker.titlebar.Visible = True
        ShiftOSClock.titlebar.Visible = True
        ShiftOSClock.closebutton.Visible = False
        Shifter.titlebar.Visible = True
        Color_Picker.titlebar.Visible = True
        infobox.titlebar.Visible = True
        Textpad.titlebar.Visible = True
        File_Skimmer.titlebar.Visible = True
    End Sub
    Private Sub showborders()
        Me.pgleft.Visible = True
        Me.pgbottom.Visible = True
        Me.pgright.Visible = True
        CodepointClicker.pgleft.Visible = True
        CodepointClicker.pgbottom.Visible = True
        CodepointClicker.pgright.Visible = True
        ShiftOSClock.pgleft.Visible = True
        ShiftOSClock.pgbottom.Visible = True
        ShiftOSClock.pgright.Visible = True
        Shifter.pgleft.Visible = True
        Shifter.pgbottom.Visible = True
        Shifter.pgright.Visible = True
        Color_Picker.pgleft.Visible = True
        Color_Picker.pgright.Visible = True
        Color_Picker.pgbottom.Visible = True
        infobox.pgleft.Visible = True
        infobox.pgright.Visible = True
        infobox.pgbottom.Visible = True
        Textpad.pgleft.Visible = True
        Textpad.pgright.Visible = True
        Textpad.pgbottom.Visible = True
        File_Skimmer.pgleft.Visible = True
        File_Skimmer.pgright.Visible = True
        File_Skimmer.pgbottom.Visible = True
        If My.Settings.TerminalWindowed = True Then
            Terminal.pgleft.Visible = True
            Terminal.pgbottom.Visible = True
            Terminal.pgright.Visible = True
            Terminal.Size = New Size(Terminal.Width + Terminal.pgleft.Width + Terminal.pgright.Width, Terminal.Height + Terminal.pgbottom.Height)
            ShiftOSClock.pgleft.Visible = True
            ShiftOSClock.pgbottom.Visible = True
            ShiftOSClock.pgright.Visible = True
        End If
    End Sub
    Private Sub showdesktoppanel()
        ShiftOSDesktop.MenuStrip1.Visible = True
        ShiftOSDesktop.MenuStrip1.BringToFront()
        ShiftOSDesktop.FLP.Visible = True
        ShiftOSDesktop.FLP.SendToBack()
        ShiftOSDesktop.desktopiconsbackground.SendToBack()

        If My.Settings.BoughtDesktopPanelClock = True Then
            ShiftOSDesktop.timepanel.Visible = True
            ShiftOSDesktop.timepanel.BringToFront()
        ElseIf My.Settings.BoughtDesktopPanelClock = False Then
            ShiftOSDesktop.timepanel.Visible = False
        End If
    End Sub
    Private Sub showtitlebartext()
        Terminal.lbtitletext.Visible = True
        Shifter.lbtitletext.Visible = True
        Me.lbtitletext.Visible = True
        CodepointClicker.lbtitletext.Visible = True
        ShiftOSClock.lbtitletext.Visible = True
        Shifter.lbtitletext.Visible = True
        Color_Picker.lbtitletext.Visible = True
        infobox.lbtitletext.Visible = True
        Textpad.lbtitletext.Visible = True
        File_Skimmer.lbtitletext.Visible = True
    End Sub
    Private Sub showclosebuttons()
        Terminal.closebutton.Visible = True
        Shifter.closebutton.Visible = True
        Me.closebutton.Visible = True
        CodepointClicker.closebutton.Visible = True
        ShiftOSClock.closebutton.Visible = True
        Color_Picker.closebutton.Visible = True
        infobox.closebutton.Visible = True
        Textpad.closebutton.Visible = True
        File_Skimmer.closebutton.Visible = True
    End Sub





    Private Sub ListBox1_Click(sender As Object, e As EventArgs) Handles ListBox1.Click

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

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Me.Close()
    End Sub

    Private Sub ListBox1_DrawItem(sender As Object, e As DrawItemEventArgs) Handles ListBox1.DrawItem
        e.DrawBackground()
        If (e.State And DrawItemState.Selected) = DrawItemState.Selected Then
            e.Graphics.FillRectangle(Brushes.Black, e.Bounds)
        End If
        Dim sf As New StringFormat
        sf.Alignment = StringAlignment.Center
        On Error Resume Next
        Using b As New SolidBrush(e.ForeColor)
            e.Graphics.DrawString(ListBox1.GetItemText(ListBox1.Items(e.Index)), e.Font, b, e.Bounds, sf)
        End Using
        e.DrawFocusRectangle()
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub
#End Region
End Class