<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class infobox
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(infobox))
        Me.pgbottom = New System.Windows.Forms.Panel()
        Me.minimizebutton = New System.Windows.Forms.Panel()
        Me.pnlicon = New System.Windows.Forms.PictureBox()
        Me.rollupbutton = New System.Windows.Forms.Panel()
        Me.closebutton = New System.Windows.Forms.Panel()
        Me.lbtitletext = New System.Windows.Forms.Label()
        Me.pgtoplcorner = New System.Windows.Forms.Panel()
        Me.titlebar = New System.Windows.Forms.Panel()
        Me.pgtoprcorner = New System.Windows.Forms.Panel()
        Me.pgbottomrcorner = New System.Windows.Forms.Panel()
        Me.pgright = New System.Windows.Forms.Panel()
        Me.pgbottomlcorner = New System.Windows.Forms.Panel()
        Me.pgleft = New System.Windows.Forms.Panel()
        Me.btnok = New System.Windows.Forms.Button()
        Me.txtmessage = New System.Windows.Forms.Label()
        Me.pboximage = New System.Windows.Forms.PictureBox()
        Me.lblintructtext = New System.Windows.Forms.Label()
        Me.pgcontents = New System.Windows.Forms.Panel()
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.titlebar.SuspendLayout()
        Me.pgright.SuspendLayout()
        Me.pgleft.SuspendLayout()
        CType(Me.pboximage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pgcontents.SuspendLayout()
        Me.SuspendLayout()
        '
        'pgbottom
        '
        Me.pgbottom.BackColor = System.Drawing.Color.Gray
        Me.pgbottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottom.Location = New System.Drawing.Point(5, 149)
        Me.pgbottom.Name = "pgbottom"
        Me.pgbottom.Size = New System.Drawing.Size(361, 5)
        Me.pgbottom.TabIndex = 28
        Me.pgbottom.Visible = False
        '
        'minimizebutton
        '
        Me.minimizebutton.BackColor = System.Drawing.Color.Black
        Me.minimizebutton.Location = New System.Drawing.Point(246, 3)
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
        Me.rollupbutton.Location = New System.Drawing.Point(274, 3)
        Me.rollupbutton.Name = "rollupbutton"
        Me.rollupbutton.Size = New System.Drawing.Size(22, 22)
        Me.rollupbutton.TabIndex = 22
        Me.rollupbutton.Visible = False
        '
        'closebutton
        '
        Me.closebutton.BackColor = System.Drawing.Color.Black
        Me.closebutton.Location = New System.Drawing.Point(334, 3)
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
        Me.lbtitletext.Size = New System.Drawing.Size(36, 18)
        Me.lbtitletext.TabIndex = 19
        Me.lbtitletext.Text = "Info"
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
        Me.titlebar.Location = New System.Drawing.Point(5, 0)
        Me.titlebar.Name = "titlebar"
        Me.titlebar.Size = New System.Drawing.Size(361, 30)
        Me.titlebar.TabIndex = 24
        Me.titlebar.Visible = False
        '
        'pgtoprcorner
        '
        Me.pgtoprcorner.BackColor = System.Drawing.Color.Red
        Me.pgtoprcorner.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgtoprcorner.Location = New System.Drawing.Point(359, 0)
        Me.pgtoprcorner.Name = "pgtoprcorner"
        Me.pgtoprcorner.Size = New System.Drawing.Size(2, 30)
        Me.pgtoprcorner.TabIndex = 16
        Me.pgtoprcorner.Visible = False
        '
        'pgbottomrcorner
        '
        Me.pgbottomrcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomrcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomrcorner.Location = New System.Drawing.Point(0, 152)
        Me.pgbottomrcorner.Name = "pgbottomrcorner"
        Me.pgbottomrcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomrcorner.TabIndex = 15
        Me.pgbottomrcorner.Visible = False
        '
        'pgright
        '
        Me.pgright.BackColor = System.Drawing.Color.Gray
        Me.pgright.Controls.Add(Me.pgbottomrcorner)
        Me.pgright.Dock = System.Windows.Forms.DockStyle.Right
        Me.pgright.Location = New System.Drawing.Point(366, 0)
        Me.pgright.Name = "pgright"
        Me.pgright.Size = New System.Drawing.Size(5, 154)
        Me.pgright.TabIndex = 27
        Me.pgright.Visible = False
        '
        'pgbottomlcorner
        '
        Me.pgbottomlcorner.BackColor = System.Drawing.Color.Red
        Me.pgbottomlcorner.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pgbottomlcorner.Location = New System.Drawing.Point(0, 152)
        Me.pgbottomlcorner.Name = "pgbottomlcorner"
        Me.pgbottomlcorner.Size = New System.Drawing.Size(5, 2)
        Me.pgbottomlcorner.TabIndex = 14
        Me.pgbottomlcorner.Visible = False
        '
        'pgleft
        '
        Me.pgleft.BackColor = System.Drawing.Color.Gray
        Me.pgleft.Controls.Add(Me.pgbottomlcorner)
        Me.pgleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.pgleft.Location = New System.Drawing.Point(0, 0)
        Me.pgleft.Name = "pgleft"
        Me.pgleft.Size = New System.Drawing.Size(5, 154)
        Me.pgleft.TabIndex = 26
        Me.pgleft.Visible = False
        '
        'btnok
        '
        Me.btnok.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnok.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnok.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnok.ForeColor = System.Drawing.Color.Black
        Me.btnok.Location = New System.Drawing.Point(135, 112)
        Me.btnok.Name = "btnok"
        Me.btnok.Size = New System.Drawing.Size(109, 30)
        Me.btnok.TabIndex = 7
        Me.btnok.TabStop = False
        Me.btnok.Text = "Ok"
        Me.btnok.UseVisualStyleBackColor = True
        '
        'txtmessage
        '
        Me.txtmessage.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmessage.Location = New System.Drawing.Point(100, 13)
        Me.txtmessage.Name = "txtmessage"
        Me.txtmessage.Size = New System.Drawing.Size(266, 102)
        Me.txtmessage.TabIndex = 2
        Me.txtmessage.Text = resources.GetString("txtmessage.Text")
        Me.txtmessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'pboximage
        '
        Me.pboximage.Image = Global.ShiftOS_Remade.My.Resources.Resources.Symbolinfo
        Me.pboximage.Location = New System.Drawing.Point(16, 36)
        Me.pboximage.Name = "pboximage"
        Me.pboximage.Size = New System.Drawing.Size(80, 70)
        Me.pboximage.TabIndex = 0
        Me.pboximage.TabStop = False
        '
        'lblintructtext
        '
        Me.lblintructtext.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblintructtext.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.lblintructtext.Location = New System.Drawing.Point(105, 7)
        Me.lblintructtext.Name = "lblintructtext"
        Me.lblintructtext.Size = New System.Drawing.Size(256, 76)
        Me.lblintructtext.TabIndex = 9
        Me.lblintructtext.Text = "Please enter a name for your new folder:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Or " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Die" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.lblintructtext.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.lblintructtext.Visible = False
        '
        'pgcontents
        '
        Me.pgcontents.BackColor = System.Drawing.Color.White
        Me.pgcontents.Controls.Add(Me.btnok)
        Me.pgcontents.Controls.Add(Me.txtmessage)
        Me.pgcontents.Controls.Add(Me.pboximage)
        Me.pgcontents.Controls.Add(Me.lblintructtext)
        Me.pgcontents.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pgcontents.Location = New System.Drawing.Point(0, 0)
        Me.pgcontents.Name = "pgcontents"
        Me.pgcontents.Size = New System.Drawing.Size(371, 154)
        Me.pgcontents.TabIndex = 25
        '
        'infobox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(371, 154)
        Me.Controls.Add(Me.pgbottom)
        Me.Controls.Add(Me.titlebar)
        Me.Controls.Add(Me.pgright)
        Me.Controls.Add(Me.pgleft)
        Me.Controls.Add(Me.pgcontents)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "infobox"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "infobox"
        CType(Me.pnlicon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.titlebar.ResumeLayout(False)
        Me.titlebar.PerformLayout()
        Me.pgright.ResumeLayout(False)
        Me.pgleft.ResumeLayout(False)
        CType(Me.pboximage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pgcontents.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pgbottom As Panel
    Friend WithEvents minimizebutton As Panel
    Friend WithEvents pnlicon As PictureBox
    Friend WithEvents rollupbutton As Panel
    Friend WithEvents closebutton As Panel
    Friend WithEvents lbtitletext As Label
    Friend WithEvents pgtoplcorner As Panel
    Friend WithEvents titlebar As Panel
    Friend WithEvents pgtoprcorner As Panel
    Friend WithEvents pgbottomrcorner As Panel
    Friend WithEvents pgright As Panel
    Friend WithEvents pgbottomlcorner As Panel
    Friend WithEvents pgleft As Panel
    Friend WithEvents btnok As Button
    Friend WithEvents txtmessage As Label
    Friend WithEvents pboximage As PictureBox
    Friend WithEvents lblintructtext As Label
    Friend WithEvents pgcontents As Panel
End Class
