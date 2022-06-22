<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ShiftOSClock
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
        Me.bottomtext = New System.Windows.Forms.Label()
        Me.toptext = New System.Windows.Forms.Label()
        Me.pgbottom = New System.Windows.Forms.Panel()
        Me.lbmaintime = New System.Windows.Forms.Label()
        Me.minimizebutton = New System.Windows.Forms.Panel()
        Me.pnlicon = New System.Windows.Forms.PictureBox()
        Me.rollupbutton = New System.Windows.Forms.Panel()
        Me.pgbottomlcorner = New System.Windows.Forms.Panel()
        Me.closebutton = New System.Windows.Forms.Panel()
        Me.lbtitletext = New System.Windows.Forms.Label()
        Me.pgtoplcorner = New System.Windows.Forms.Panel()
        Me.pgtoprcorner = New System.Windows.Forms.Panel()
        Me.pgleft = New System.Windows.Forms.Panel()
        Me.pgbottomrcorner = New System.Windows.Forms.Panel()
        Me.pgcontents = New System.Windows.Forms.Panel()
        Me.pgright = New System.Windows.Forms.Panel()
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.clocktimer = New System.Windows.Forms.Timer(Me.components)
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgleft.SuspendLayout()
        Me.pgcontents.SuspendLayout()
        Me.pgright.SuspendLayout()
        Me.titlebar.SuspendLayout()
        Me.SuspendLayout()
        '
        'bottomtext
        '
        Me.bottomtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bottomtext.Location = New System.Drawing.Point(10, 88)
        Me.bottomtext.Name = "bottomtext"
        Me.bottomtext.Size = New System.Drawing.Size(342, 23)
        Me.bottomtext.TabIndex = 2
        Me.bottomtext.Text = "Seconds have passed"
        Me.bottomtext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'toptext
        '
        Me.toptext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.toptext.Location = New System.Drawing.Point(10, 22)
        Me.toptext.Name = "toptext"
        Me.toptext.Size = New System.Drawing.Size(342, 23)
        Me.toptext.TabIndex = 1
        Me.toptext.Text = "The Time is"
        Me.toptext.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'pgbottom
        '
        Me.pgbottom.BackColor = System.Drawing.Color.Gray
        Me.pgbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottom.Location = New System.Drawing.Point(5, 162)
        Me.pgbottom.Name = "pgbottom"
        Me.pgbottom.Size = New System.Drawing.Size(356, 5)
        Me.pgbottom.TabIndex = 28
        Me.pgbottom.Visible = False
        '
        'lbmaintime
        '
        Me.lbmaintime.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbmaintime.Location = New System.Drawing.Point(6, 38)
        Me.lbmaintime.Name = "lbmaintime"
        Me.lbmaintime.Size = New System.Drawing.Size(350, 52)
        Me.lbmaintime.TabIndex = 0
        Me.lbmaintime.Text = "00000000"
        Me.lbmaintime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'minimizebutton
        '
        Me.minimizebutton.BackColor = System.Drawing.Color.Black
        Me.minimizebutton.Location = New System.Drawing.Point(246, 3)
        Me.minimizebutton.Name = "minimizebutton"
        Me.minimizebutton.Size = New System.Drawing.Size(22, 22)
        Me.minimizebutton.TabIndex = 22
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
        Me.rollupbutton.Location = New System.Drawing.Point(274, 3)
        Me.rollupbutton.Name = "rollupbutton"
        Me.rollupbutton.Size = New System.Drawing.Size(22, 22)
        Me.rollupbutton.TabIndex = 21
        Me.rollupbutton.Visible = False
        '
        'pgbottomlcorner
        '
        Me.pgbottomlcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomlcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomlcorner.Location = New System.Drawing.Point(0, 135)
        Me.pgbottomlcorner.Name = "pgbottomlcorner"
        Me.pgbottomlcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomlcorner.TabIndex = 14
        Me.pgbottomlcorner.Visible = False
        '
        'closebutton
        '
        Me.closebutton.BackColor = System.Drawing.Color.Black
        Me.closebutton.Location = New System.Drawing.Point(335, 4)
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
        Me.lbtitletext.Size = New System.Drawing.Size(52, 18)
        Me.lbtitletext.TabIndex = 19
        Me.lbtitletext.Text = "Clock"
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
        Me.pgtoprcorner.Location = New System.Drawing.Point(364, 0)
        Me.pgtoprcorner.Name = "pgtoprcorner"
        Me.pgtoprcorner.Size = New System.Drawing.Size(2, 30)
        Me.pgtoprcorner.TabIndex = 16
        Me.pgtoprcorner.Visible = False
        '
        'pgleft
        '
        Me.pgleft.BackColor = System.Drawing.Color.Gray
        Me.pgleft.Controls.Add(Me.pgbottomlcorner)
        Me.pgleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pgleft.Location = New System.Drawing.Point(0, 30)
        Me.pgleft.Name = "pgleft"
        Me.pgleft.Size = New System.Drawing.Size(5, 137)
        Me.pgleft.TabIndex = 26
        Me.pgleft.Visible = False
        '
        'pgbottomrcorner
        '
        Me.pgbottomrcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomrcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomrcorner.Location = New System.Drawing.Point(0, 135)
        Me.pgbottomrcorner.Name = "pgbottomrcorner"
        Me.pgbottomrcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomrcorner.TabIndex = 15
        Me.pgbottomrcorner.Visible = False
        '
        'pgcontents
        '
        Me.pgcontents.BackColor = System.Drawing.Color.White
        Me.pgcontents.Controls.Add(Me.bottomtext)
        Me.pgcontents.Controls.Add(Me.toptext)
        Me.pgcontents.Controls.Add(Me.lbmaintime)
        Me.pgcontents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcontents.Location = New System.Drawing.Point(0, 30)
        Me.pgcontents.Name = "pgcontents"
        Me.pgcontents.Size = New System.Drawing.Size(361, 137)
        Me.pgcontents.TabIndex = 25
        '
        'pgright
        '
        Me.pgright.BackColor = System.Drawing.Color.Gray
        Me.pgright.Controls.Add(Me.pgbottomrcorner)
        Me.pgright.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgright.Location = New System.Drawing.Point(361, 30)
        Me.pgright.Name = "pgright"
        Me.pgright.Size = New System.Drawing.Size(5, 137)
        Me.pgright.TabIndex = 27
        Me.pgright.Visible = False
        '
        'titlebar
        '
        Me.titlebar.BackColor = System.Drawing.Color.Gray
        Me.titlebar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
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
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(366, 30)
        Me.titlebar.TabIndex = 24
        Me.titlebar.Visible = False
        '
        'clocktimer
        '
        Me.clocktimer.Enabled = True
        '
        'ShiftOSClock
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(366, 167)
        Me.Controls.Add(Me.pgbottom)
        Me.Controls.Add(Me.pgleft)
        Me.Controls.Add(Me.pgcontents)
        Me.Controls.Add(Me.pgright)
        Me.Controls.Add(Me.titlebar)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ShiftOSClock"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clock"
        Me.TopMost = True
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgleft.ResumeLayout(False)
        Me.pgcontents.ResumeLayout(False)
        Me.pgright.ResumeLayout(False)
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents bottomtext As Label
    Friend WithEvents toptext As Label
    Friend WithEvents pgbottom As Panel
    Friend WithEvents lbmaintime As Label
    Friend WithEvents minimizebutton As Panel
    Friend WithEvents pnlicon As PictureBox
    Friend WithEvents rollupbutton As Panel
    Friend WithEvents pgbottomlcorner As Panel
    Friend WithEvents closebutton As Panel
    Friend WithEvents lbtitletext As Label
    Friend WithEvents pgtoplcorner As Panel
    Friend WithEvents pgtoprcorner As Panel
    Friend WithEvents pgleft As Panel
    Friend WithEvents pgbottomrcorner As Panel
    Friend WithEvents pgcontents As Panel
    Friend WithEvents pgright As Panel
    Friend WithEvents titlebar As Panel
    Friend WithEvents clocktimer As Timer
End Class
