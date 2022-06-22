<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Shifter
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.minimizebutton = New System.Windows.Forms.Panel()
        Me.pnlicon = New System.Windows.Forms.PictureBox()
        Me.rollupbutton = New System.Windows.Forms.Panel()
        Me.closebutton = New System.Windows.Forms.Panel()
        Me.lbtitletext = New System.Windows.Forms.Label()
        Me.pgtoplcorner = New System.Windows.Forms.Panel()
        Me.pgtoprcorner = New System.Windows.Forms.Panel()
        Me.pgright = New System.Windows.Forms.Panel()
        Me.pgbottomrcorner = New System.Windows.Forms.Panel()
        Me.pgleft = New System.Windows.Forms.Panel()
        Me.pgbottomlcorner = New System.Windows.Forms.Panel()
        Me.pgbottom = New System.Windows.Forms.Panel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.DesktopButtonPanel = New System.Windows.Forms.Panel()
        Me.lmenutextcolor = New System.Windows.Forms.Panel()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.launchertextcolor = New System.Windows.Forms.Panel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.applauncherlabel = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.panelocationbox = New System.Windows.Forms.ComboBox()
        Me.previewtext = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.clocktextcolor = New System.Windows.Forms.Panel()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.fontcombobox = New System.Windows.Forms.ComboBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.tbartextsize = New System.Windows.Forms.TextBox()
        Me.panelclockcolor = New System.Windows.Forms.Panel()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.menubuttoncolor = New System.Windows.Forms.Panel()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.menucolor = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.desktoppanelcolor = New System.Windows.Forms.Panel()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.desktopbackcolor = New System.Windows.Forms.Panel()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.tbartextcolor = New System.Windows.Forms.Panel()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.bordercolorbutton = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.titlebarcolorbutton = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.closebuttoncolor = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.menutextcolor = New System.Windows.Forms.Panel()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.titlebar.SuspendLayout()
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgright.SuspendLayout()
        Me.pgleft.SuspendLayout()
        Me.DesktopButtonPanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'titlebar
        '
        Me.titlebar.BackColor = System.Drawing.Color.Gray
        Me.titlebar.Controls.Add(Me.minimizebutton)
        Me.titlebar.Controls.Add(Me.pnlicon)
        Me.titlebar.Controls.Add(Me.rollupbutton)
        Me.titlebar.Controls.Add(Me.closebutton)
        Me.titlebar.Controls.Add(Me.lbtitletext)
        Me.titlebar.Controls.Add(Me.pgtoplcorner)
        Me.titlebar.Controls.Add(Me.pgtoprcorner)
        Me.titlebar.Dock = System.Windows.Forms.DockStyle.Top
        Me.titlebar.ForeColor = System.Drawing.Color.White
        Me.titlebar.Location = New System.Drawing.Point(0, 0)
        Me.titlebar.MinimumSize = New System.Drawing.Size(978, 30)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(978, 30)
        Me.titlebar.TabIndex = 32
        Me.titlebar.Visible = False
        '
        'minimizebutton
        '
        Me.minimizebutton.BackColor = System.Drawing.Color.Black
        Me.minimizebutton.Location = New System.Drawing.Point(885, 3)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(22, 22)
        Me.minimizebutton.TabIndex = 24
        Me.minimizebutton.Visible = False
        '
        'pnlicon
        '
        Me.pnlicon.BackColor = System.Drawing.Color.Transparent
        Me.pnlicon.Location = New System.Drawing.Point(8, 8)
        Me.pnlicon.Name = "pnlicon"
        Me.pnlicon.Size = New System.Drawing.Size(16, 16)
        Me.pnlicon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pnlicon.TabIndex = 24
        Me.pnlicon.TabStop = False
        Me.pnlicon.Visible = False
        '
        'rollupbutton
        '
        Me.rollupbutton.BackColor = System.Drawing.Color.Black
        Me.rollupbutton.Location = New System.Drawing.Point(913, 3)
        Me.rollupbutton.Name = "rollupbutton"
        Me.rollupbutton.Size = New System.Drawing.Size(22, 22)
        Me.rollupbutton.TabIndex = 22
        Me.rollupbutton.Visible = False
        '
        'closebutton
        '
        Me.closebutton.BackColor = System.Drawing.Color.Black
        Me.closebutton.Location = New System.Drawing.Point(947, 4)
        Me.closebutton.Name = "closebutton"
        Me.closebutton.Size = New System.Drawing.Size(22, 22)
        Me.closebutton.TabIndex = 20
        Me.closebutton.Visible = False
        '
        'lbtitletext
        '
        Me.lbtitletext.AutoSize = True
        Me.lbtitletext.BackColor = System.Drawing.Color.Transparent
        Me.lbtitletext.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbtitletext.Location = New System.Drawing.Point(26, 7)
        Me.lbtitletext.Name = "lbtitletext"
        Me.lbtitletext.Size = New System.Drawing.Size(57, 18)
        Me.lbtitletext.TabIndex = 19
        Me.lbtitletext.Text = "Shifter"
        Me.lbtitletext.Visible = False
        '
        'pgtoplcorner
        '
        Me.pgtoplcorner.BackColor = System.Drawing.Color.Red
        Me.pgtoplcorner.Dock = System.Windows.Forms.DockStyle.Left
        Me.pgtoplcorner.Location = New System.Drawing.Point(0, 0)
        Me.pgtoplcorner.Name = "pgtoplcorner"
        Me.pgtoplcorner.Size = New System.Drawing.Size(2, 30)
        Me.pgtoplcorner.TabIndex = 17
        Me.pgtoplcorner.Visible = False
        '
        'pgtoprcorner
        '
        Me.pgtoprcorner.BackColor = System.Drawing.Color.Red
        Me.pgtoprcorner.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgtoprcorner.Location = New System.Drawing.Point(976, 0)
        Me.pgtoprcorner.Name = "pgtoprcorner"
        Me.pgtoprcorner.Size = New System.Drawing.Size(2, 30)
        Me.pgtoprcorner.TabIndex = 16
        Me.pgtoprcorner.Visible = False
        '
        'pgright
        '
        Me.pgright.BackColor = System.Drawing.Color.Gray
        Me.pgright.Controls.Add(Me.pgbottomrcorner)
        Me.pgright.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgright.Location = New System.Drawing.Point(973, 0)
        Me.pgright.Name = "pgright"
        Me.pgright.Size = New System.Drawing.Size(5, 478)
        Me.pgright.TabIndex = 33
        Me.pgright.Visible = False
        '
        'pgbottomrcorner
        '
        Me.pgbottomrcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomrcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomrcorner.Location = New System.Drawing.Point(0, 476)
        Me.pgbottomrcorner.Name = "pgbottomrcorner"
        Me.pgbottomrcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomrcorner.TabIndex = 15
        Me.pgbottomrcorner.Visible = False
        '
        'pgleft
        '
        Me.pgleft.BackColor = System.Drawing.Color.Gray
        Me.pgleft.Controls.Add(Me.pgbottomlcorner)
        Me.pgleft.Location = New System.Drawing.Point(0, 29)
        Me.pgleft.Name = "pgleft"
        Me.pgleft.Size = New System.Drawing.Size(5, 478)
        Me.pgleft.TabIndex = 34
        Me.pgleft.Visible = False
        '
        'pgbottomlcorner
        '
        Me.pgbottomlcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomlcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomlcorner.Location = New System.Drawing.Point(0, 476)
        Me.pgbottomlcorner.Name = "pgbottomlcorner"
        Me.pgbottomlcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomlcorner.TabIndex = 14
        Me.pgbottomlcorner.Visible = False
        '
        'pgbottom
        '
        Me.pgbottom.BackColor = System.Drawing.Color.Gray
        Me.pgbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottom.Location = New System.Drawing.Point(0, 478)
        Me.pgbottom.Name = "pgbottom"
        Me.pgbottom.Size = New System.Drawing.Size(978, 5)
        Me.pgbottom.TabIndex = 35
        Me.pgbottom.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'DesktopButtonPanel
        '
        Me.DesktopButtonPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.DesktopButtonPanel.Controls.Add(Me.lmenutextcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label30)
        Me.DesktopButtonPanel.Controls.Add(Me.launchertextcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label29)
        Me.DesktopButtonPanel.Controls.Add(Me.applauncherlabel)
        Me.DesktopButtonPanel.Controls.Add(Me.Label28)
        Me.DesktopButtonPanel.Controls.Add(Me.Label27)
        Me.DesktopButtonPanel.Controls.Add(Me.panelocationbox)
        Me.DesktopButtonPanel.Controls.Add(Me.previewtext)
        Me.DesktopButtonPanel.Controls.Add(Me.Label26)
        Me.DesktopButtonPanel.Controls.Add(Me.clocktextcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label24)
        Me.DesktopButtonPanel.Controls.Add(Me.Label25)
        Me.DesktopButtonPanel.Controls.Add(Me.fontcombobox)
        Me.DesktopButtonPanel.Controls.Add(Me.Label23)
        Me.DesktopButtonPanel.Controls.Add(Me.tbartextsize)
        Me.DesktopButtonPanel.Controls.Add(Me.panelclockcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label21)
        Me.DesktopButtonPanel.Controls.Add(Me.Label22)
        Me.DesktopButtonPanel.Controls.Add(Me.menubuttoncolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label19)
        Me.DesktopButtonPanel.Controls.Add(Me.Label20)
        Me.DesktopButtonPanel.Controls.Add(Me.menucolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label17)
        Me.DesktopButtonPanel.Controls.Add(Me.Label18)
        Me.DesktopButtonPanel.Controls.Add(Me.desktoppanelcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label15)
        Me.DesktopButtonPanel.Controls.Add(Me.Label16)
        Me.DesktopButtonPanel.Controls.Add(Me.desktopbackcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label13)
        Me.DesktopButtonPanel.Controls.Add(Me.Label14)
        Me.DesktopButtonPanel.Controls.Add(Me.tbartextcolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label11)
        Me.DesktopButtonPanel.Controls.Add(Me.Label12)
        Me.DesktopButtonPanel.Controls.Add(Me.bordercolorbutton)
        Me.DesktopButtonPanel.Controls.Add(Me.Label9)
        Me.DesktopButtonPanel.Controls.Add(Me.Label10)
        Me.DesktopButtonPanel.Controls.Add(Me.titlebarcolorbutton)
        Me.DesktopButtonPanel.Controls.Add(Me.Label7)
        Me.DesktopButtonPanel.Controls.Add(Me.Label8)
        Me.DesktopButtonPanel.Controls.Add(Me.closebuttoncolor)
        Me.DesktopButtonPanel.Controls.Add(Me.Label6)
        Me.DesktopButtonPanel.Controls.Add(Me.Label5)
        Me.DesktopButtonPanel.Controls.Add(Me.Button1)
        Me.DesktopButtonPanel.Controls.Add(Me.Panel3)
        Me.DesktopButtonPanel.Controls.Add(Me.Label3)
        Me.DesktopButtonPanel.Controls.Add(Me.Label4)
        Me.DesktopButtonPanel.Controls.Add(Me.Panel2)
        Me.DesktopButtonPanel.Controls.Add(Me.Label2)
        Me.DesktopButtonPanel.Controls.Add(Me.Label1)
        Me.DesktopButtonPanel.Controls.Add(Me.menutextcolor)
        Me.DesktopButtonPanel.Location = New System.Drawing.Point(13, 42)
        Me.DesktopButtonPanel.Name = "DesktopButtonPanel"
        Me.DesktopButtonPanel.Size = New System.Drawing.Size(953, 352)
        Me.DesktopButtonPanel.TabIndex = 38
        '
        'lmenutextcolor
        '
        Me.lmenutextcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lmenutextcolor.Location = New System.Drawing.Point(387, 38)
        Me.lmenutextcolor.Name = "lmenutextcolor"
        Me.lmenutextcolor.Size = New System.Drawing.Size(38, 24)
        Me.lmenutextcolor.TabIndex = 89
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(323, 38)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(58, 39)
        Me.Label30.TabIndex = 88
        Me.Label30.Text = "Menu Text" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Color:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'launchertextcolor
        '
        Me.launchertextcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.launchertextcolor.Location = New System.Drawing.Point(668, 43)
        Me.launchertextcolor.Name = "launchertextcolor"
        Me.launchertextcolor.Size = New System.Drawing.Size(38, 24)
        Me.launchertextcolor.TabIndex = 87
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(528, 38)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(134, 39)
        Me.Label29.TabIndex = 86
        Me.Label29.Text = "Application Launcher Text " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Color:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.Label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'applauncherlabel
        '
        Me.applauncherlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!)
        Me.applauncherlabel.Location = New System.Drawing.Point(668, 13)
        Me.applauncherlabel.Name = "applauncherlabel"
        Me.applauncherlabel.Size = New System.Drawing.Size(157, 22)
        Me.applauncherlabel.TabIndex = 85
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(526, 18)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(136, 13)
        Me.Label28.TabIndex = 84
        Me.Label28.Text = "Application Launcher Label" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(195, 15)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(78, 13)
        Me.Label27.TabIndex = 83
        Me.Label27.Text = "Panel Location"
        '
        'panelocationbox
        '
        Me.panelocationbox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.panelocationbox.FormattingEnabled = True
        Me.panelocationbox.Items.AddRange(New Object() {"Top", "Bottom"})
        Me.panelocationbox.Location = New System.Drawing.Point(279, 10)
        Me.panelocationbox.Name = "panelocationbox"
        Me.panelocationbox.Size = New System.Drawing.Size(135, 24)
        Me.panelocationbox.TabIndex = 82
        '
        'previewtext
        '
        Me.previewtext.AutoSize = True
        Me.previewtext.BackColor = System.Drawing.Color.Transparent
        Me.previewtext.Location = New System.Drawing.Point(416, 122)
        Me.previewtext.Name = "previewtext"
        Me.previewtext.Size = New System.Drawing.Size(221, 13)
        Me.previewtext.TabIndex = 81
        Me.previewtext.Text = "The quick brown fox jumps over the lazy dog."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(270, 167)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 13)
        Me.Label26.TabIndex = 80
        Me.Label26.Text = "Titlebar Text Font"
        '
        'clocktextcolor
        '
        Me.clocktextcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.clocktextcolor.Location = New System.Drawing.Point(279, 70)
        Me.clocktextcolor.Name = "clocktextcolor"
        Me.clocktextcolor.Size = New System.Drawing.Size(38, 24)
        Me.clocktextcolor.TabIndex = 79
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(239, 81)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(34, 13)
        Me.Label24.TabIndex = 78
        Me.Label24.Text = "Color:"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(216, 68)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 77
        Me.Label25.Text = "Clock Text"
        '
        'fontcombobox
        '
        Me.fontcombobox.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fontcombobox.FormattingEnabled = True
        Me.fontcombobox.Location = New System.Drawing.Point(365, 159)
        Me.fontcombobox.Name = "fontcombobox"
        Me.fontcombobox.Size = New System.Drawing.Size(135, 24)
        Me.fontcombobox.TabIndex = 75
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(270, 129)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(89, 13)
        Me.Label23.TabIndex = 74
        Me.Label23.Text = "Titlebar Text Size"
        '
        'tbartextsize
        '
        Me.tbartextsize.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbartextsize.Location = New System.Drawing.Point(365, 124)
        Me.tbartextsize.Multiline = True
        Me.tbartextsize.Name = "tbartextsize"
        Me.tbartextsize.Size = New System.Drawing.Size(45, 24)
        Me.tbartextsize.TabIndex = 73
        Me.tbartextsize.Text = "11.25"
        '
        'panelclockcolor
        '
        Me.panelclockcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelclockcolor.Location = New System.Drawing.Point(279, 40)
        Me.panelclockcolor.Name = "panelclockcolor"
        Me.panelclockcolor.Size = New System.Drawing.Size(38, 24)
        Me.panelclockcolor.TabIndex = 72
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(239, 51)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(34, 13)
        Me.Label21.TabIndex = 71
        Me.Label21.Text = "Color:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(209, 38)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 13)
        Me.Label22.TabIndex = 70
        Me.Label22.Text = "Panel Clock"
        '
        'menubuttoncolor
        '
        Me.menubuttoncolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menubuttoncolor.Location = New System.Drawing.Point(169, 70)
        Me.menubuttoncolor.Name = "menubuttoncolor"
        Me.menubuttoncolor.Size = New System.Drawing.Size(38, 24)
        Me.menubuttoncolor.TabIndex = 69
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(136, 81)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(34, 13)
        Me.Label19.TabIndex = 68
        Me.Label19.Text = "Color:"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(103, 68)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(68, 13)
        Me.Label20.TabIndex = 67
        Me.Label20.Text = "Menu Button"
        '
        'menucolor
        '
        Me.menucolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.menucolor.Location = New System.Drawing.Point(169, 40)
        Me.menucolor.Name = "menucolor"
        Me.menucolor.Size = New System.Drawing.Size(38, 24)
        Me.menucolor.TabIndex = 66
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(136, 51)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(34, 13)
        Me.Label17.TabIndex = 65
        Me.Label17.Text = "Color:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(136, 38)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(34, 13)
        Me.Label18.TabIndex = 64
        Me.Label18.Text = "Menu"
        '
        'desktoppanelcolor
        '
        Me.desktoppanelcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.desktoppanelcolor.Location = New System.Drawing.Point(65, 70)
        Me.desktoppanelcolor.Name = "desktoppanelcolor"
        Me.desktoppanelcolor.Size = New System.Drawing.Size(38, 24)
        Me.desktoppanelcolor.TabIndex = 63
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(28, 81)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(34, 13)
        Me.Label15.TabIndex = 62
        Me.Label15.Text = "Color:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(26, 68)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 61
        Me.Label16.Text = "Panel"
        '
        'desktopbackcolor
        '
        Me.desktopbackcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.desktopbackcolor.Location = New System.Drawing.Point(65, 40)
        Me.desktopbackcolor.Name = "desktopbackcolor"
        Me.desktopbackcolor.Size = New System.Drawing.Size(38, 24)
        Me.desktopbackcolor.TabIndex = 60
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(28, 51)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(34, 13)
        Me.Label13.TabIndex = 59
        Me.Label13.Text = "Color:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(-1, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(65, 13)
        Me.Label14.TabIndex = 58
        Me.Label14.Text = "Background"
        '
        'tbartextcolor
        '
        Me.tbartextcolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tbartextcolor.Location = New System.Drawing.Point(226, 124)
        Me.tbartextcolor.Name = "tbartextcolor"
        Me.tbartextcolor.Size = New System.Drawing.Size(38, 24)
        Me.tbartextcolor.TabIndex = 57
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(189, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 13)
        Me.Label11.TabIndex = 56
        Me.Label11.Text = "Color:"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(161, 122)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(66, 13)
        Me.Label12.TabIndex = 55
        Me.Label12.Text = "Titlebar Text"
        '
        'bordercolorbutton
        '
        Me.bordercolorbutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.bordercolorbutton.Location = New System.Drawing.Point(57, 161)
        Me.bordercolorbutton.Name = "bordercolorbutton"
        Me.bordercolorbutton.Size = New System.Drawing.Size(38, 24)
        Me.bordercolorbutton.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(20, 172)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(34, 13)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "Color:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Border"
        '
        'titlebarcolorbutton
        '
        Me.titlebarcolorbutton.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.titlebarcolorbutton.Location = New System.Drawing.Point(226, 161)
        Me.titlebarcolorbutton.Name = "titlebarcolorbutton"
        Me.titlebarcolorbutton.Size = New System.Drawing.Size(38, 24)
        Me.titlebarcolorbutton.TabIndex = 51
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(189, 172)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 13)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "Color:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(183, 159)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 49
        Me.Label8.Text = "Titlebar"
        '
        'closebuttoncolor
        '
        Me.closebuttoncolor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.closebuttoncolor.Location = New System.Drawing.Point(57, 273)
        Me.closebuttoncolor.Name = "closebuttoncolor"
        Me.closebuttoncolor.Size = New System.Drawing.Size(38, 24)
        Me.closebuttoncolor.TabIndex = 48
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 269)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(34, 13)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Color:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 13)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Close Button"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(279, 311)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(546, 32)
        Me.Button1.TabIndex = 44
        Me.Button1.Text = "Reset: WARNING, YOU CANNOT UNDO THIS RESET, ONCE YOU RESET, THE RESET IS PERMANEN" &
    "T."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Black
        Me.Panel3.Location = New System.Drawing.Point(0, 303)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1000, 2)
        Me.Panel3.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 308)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(212, 37)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "Global Reset"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(13, 219)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(133, 37)
        Me.Label4.TabIndex = 44
        Me.Label4.Text = "Buttons"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Black
        Me.Panel2.Location = New System.Drawing.Point(0, 214)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1000, 2)
        Me.Panel2.TabIndex = 43
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(155, 37)
        Me.Label2.TabIndex = 42
        Me.Label2.Text = "Windows"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 37)
        Me.Label1.TabIndex = 40
        Me.Label1.Text = "Desktop"
        '
        'menutextcolor
        '
        Me.menutextcolor.BackColor = System.Drawing.Color.Black
        Me.menutextcolor.Location = New System.Drawing.Point(0, 106)
        Me.menutextcolor.Name = "menutextcolor"
        Me.menutextcolor.Size = New System.Drawing.Size(1000, 2)
        Me.menutextcolor.TabIndex = 39
        '
        'ColorDialog1
        '
        Me.ColorDialog1.AnyColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(13, 400)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 32)
        Me.Button2.TabIndex = 39
        Me.Button2.Text = "Apply Changes"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Shifter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(978, 483)
        Me.Controls.Add(Me.titlebar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.DesktopButtonPanel)
        Me.Controls.Add(Me.pgright)
        Me.Controls.Add(Me.pgleft)
        Me.Controls.Add(Me.pgbottom)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Shifter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Shifter"
        Me.TopMost = True
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgright.ResumeLayout(False)
        Me.pgleft.ResumeLayout(False)
        Me.DesktopButtonPanel.ResumeLayout(False)
        Me.DesktopButtonPanel.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents titlebar As Panel
    Friend WithEvents minimizebutton As Panel
    Friend WithEvents pnlicon As PictureBox
    Friend WithEvents rollupbutton As Panel
    Friend WithEvents closebutton As Panel
    Friend WithEvents lbtitletext As Label
    Friend WithEvents pgtoplcorner As Panel
    Friend WithEvents pgtoprcorner As Panel
    Friend WithEvents pgright As Panel
    Friend WithEvents pgbottomrcorner As Panel
    Friend WithEvents pgleft As Panel
    Friend WithEvents pgbottomlcorner As Panel
    Friend WithEvents pgbottom As Panel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents DesktopButtonPanel As Panel
    Friend WithEvents menutextcolor As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents closebuttoncolor As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents ColorDialog1 As ColorDialog
    Friend WithEvents Button2 As Button
    Friend WithEvents titlebarcolorbutton As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents bordercolorbutton As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tbartextcolor As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents desktopbackcolor As Panel
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents desktoppanelcolor As Panel
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents menucolor As Panel
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents menubuttoncolor As Panel
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents panelclockcolor As Panel
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents tbartextsize As TextBox
    Friend WithEvents fontcombobox As ComboBox
    Friend WithEvents clocktextcolor As Panel
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents previewtext As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents panelocationbox As ComboBox
    Friend WithEvents launchertextcolor As Panel
    Friend WithEvents Label29 As Label
    Friend WithEvents applauncherlabel As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents lmenutextcolor As Panel
    Friend WithEvents Label30 As Label
End Class
