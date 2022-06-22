<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ShiftOSDesktop
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ShiftOSDesktop))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ApplicationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CLOCK = New System.Windows.Forms.ToolStripMenuItem()
        Me.CPCLICKER = New System.Windows.Forms.ToolStripMenuItem()
        Me.ShifterTSMI = New System.Windows.Forms.ToolStripMenuItem()
        Me.SHIFTORIUMSTRIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TerminalSTRIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextpadSTRIP = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.SHUTDOWN = New System.Windows.Forms.ToolStripMenuItem()
        Me.FLP = New System.Windows.Forms.FlowLayoutPanel()
        Me.timepanel = New System.Windows.Forms.Panel()
        Me.timelabel = New System.Windows.Forms.Label()
        Me.autocp = New System.Windows.Forms.Timer(Me.components)
        Me.colortext = New System.Windows.Forms.Label()
        Me.desktopiconsbackground = New System.Windows.Forms.ListView()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.FileSKIMMER = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.timepanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.BackColor = System.Drawing.Color.Gray
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Font = New System.Drawing.Font("Bahnschrift Light", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ApplicationsToolStripMenuItem})
        Me.MenuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.MaximumSize = New System.Drawing.Size(130, 24)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(130, 24)
        Me.MenuStrip1.Stretch = False
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "Applications"
        Me.MenuStrip1.Visible = False
        '
        'ApplicationsToolStripMenuItem
        '
        Me.ApplicationsToolStripMenuItem.BackColor = System.Drawing.Color.Gray
        Me.ApplicationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CLOCK, Me.CPCLICKER, Me.FileSKIMMER, Me.ShifterTSMI, Me.SHIFTORIUMSTRIP, Me.TerminalSTRIP, Me.TextpadSTRIP, Me.ToolStripSeparator1, Me.SHUTDOWN})
        Me.ApplicationsToolStripMenuItem.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.ApplicationsToolStripMenuItem.ForeColor = System.Drawing.Color.Black
        Me.ApplicationsToolStripMenuItem.Name = "ApplicationsToolStripMenuItem"
        Me.ApplicationsToolStripMenuItem.Size = New System.Drawing.Size(99, 20)
        Me.ApplicationsToolStripMenuItem.Text = "Applications"
        '
        'CLOCK
        '
        Me.CLOCK.BackColor = System.Drawing.Color.Gray
        Me.CLOCK.Name = "CLOCK"
        Me.CLOCK.Size = New System.Drawing.Size(186, 22)
        Me.CLOCK.Text = "Clock"
        '
        'CPCLICKER
        '
        Me.CPCLICKER.BackColor = System.Drawing.Color.Gray
        Me.CPCLICKER.Font = New System.Drawing.Font("Georgia", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CPCLICKER.Name = "CPCLICKER"
        Me.CPCLICKER.Size = New System.Drawing.Size(186, 22)
        Me.CPCLICKER.Text = "Codepoint Clicker"
        Me.CPCLICKER.Visible = False
        '
        'ShifterTSMI
        '
        Me.ShifterTSMI.BackColor = System.Drawing.Color.Gray
        Me.ShifterTSMI.Name = "ShifterTSMI"
        Me.ShifterTSMI.Size = New System.Drawing.Size(186, 22)
        Me.ShifterTSMI.Text = "Shifter"
        '
        'SHIFTORIUMSTRIP
        '
        Me.SHIFTORIUMSTRIP.BackColor = System.Drawing.Color.Gray
        Me.SHIFTORIUMSTRIP.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.SHIFTORIUMSTRIP.Name = "SHIFTORIUMSTRIP"
        Me.SHIFTORIUMSTRIP.Size = New System.Drawing.Size(186, 22)
        Me.SHIFTORIUMSTRIP.Text = "Shiftorium"
        '
        'TerminalSTRIP
        '
        Me.TerminalSTRIP.BackColor = System.Drawing.Color.Gray
        Me.TerminalSTRIP.Font = New System.Drawing.Font("Georgia", 9.75!)
        Me.TerminalSTRIP.Name = "TerminalSTRIP"
        Me.TerminalSTRIP.Size = New System.Drawing.Size(186, 22)
        Me.TerminalSTRIP.Text = "Terminal"
        '
        'TextpadSTRIP
        '
        Me.TextpadSTRIP.BackColor = System.Drawing.Color.Gray
        Me.TextpadSTRIP.Name = "TextpadSTRIP"
        Me.TextpadSTRIP.Size = New System.Drawing.Size(186, 22)
        Me.TextpadSTRIP.Text = "Textpad"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.BackColor = System.Drawing.Color.Gray
        Me.ToolStripSeparator1.ForeColor = System.Drawing.Color.Black
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(183, 6)
        Me.ToolStripSeparator1.Visible = False
        '
        'SHUTDOWN
        '
        Me.SHUTDOWN.BackColor = System.Drawing.Color.Gray
        Me.SHUTDOWN.Name = "SHUTDOWN"
        Me.SHUTDOWN.Size = New System.Drawing.Size(186, 22)
        Me.SHUTDOWN.Text = "Shutdown"
        Me.SHUTDOWN.Visible = False
        '
        'FLP
        '
        Me.FLP.BackColor = System.Drawing.Color.Gray
        Me.FLP.Dock = System.Windows.Forms.DockStyle.Top
        Me.FLP.Location = New System.Drawing.Point(0, 0)
        Me.FLP.MaximumSize = New System.Drawing.Size(10000, 24)
        Me.FLP.Name = "FLP"
        Me.FLP.Size = New System.Drawing.Size(1284, 24)
        Me.FLP.TabIndex = 2
        '
        'timepanel
        '
        Me.timepanel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timepanel.BackColor = System.Drawing.Color.Gray
        Me.timepanel.Controls.Add(Me.timelabel)
        Me.timepanel.Location = New System.Drawing.Point(1172, 0)
        Me.timepanel.MaximumSize = New System.Drawing.Size(112, 24)
        Me.timepanel.Name = "timepanel"
        Me.timepanel.Size = New System.Drawing.Size(112, 24)
        Me.timepanel.TabIndex = 3
        Me.timepanel.Visible = False
        '
        'timelabel
        '
        Me.timelabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.timelabel.AutoSize = True
        Me.timelabel.Font = New System.Drawing.Font("Trebuchet MS", 14.25!)
        Me.timelabel.Location = New System.Drawing.Point(-2, 0)
        Me.timelabel.Name = "timelabel"
        Me.timelabel.Size = New System.Drawing.Size(67, 24)
        Me.timelabel.TabIndex = 0
        Me.timelabel.Text = "Label2"
        Me.timelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.timelabel.Visible = False
        '
        'autocp
        '
        Me.autocp.Interval = 1000
        '
        'colortext
        '
        Me.colortext.AutoSize = True
        Me.colortext.Location = New System.Drawing.Point(176, 409)
        Me.colortext.Name = "colortext"
        Me.colortext.Size = New System.Drawing.Size(30, 13)
        Me.colortext.TabIndex = 4
        Me.colortext.Text = "color"
        Me.colortext.Visible = False
        '
        'desktopiconsbackground
        '
        Me.desktopiconsbackground.BackColor = System.Drawing.Color.Black
        Me.desktopiconsbackground.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.desktopiconsbackground.HideSelection = False
        Me.desktopiconsbackground.Location = New System.Drawing.Point(-162, -7)
        Me.desktopiconsbackground.Name = "desktopiconsbackground"
        Me.desktopiconsbackground.OwnerDraw = True
        Me.desktopiconsbackground.Size = New System.Drawing.Size(5000, 5000)
        Me.desktopiconsbackground.TabIndex = 5
        Me.desktopiconsbackground.UseCompatibleStateImageBehavior = False
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'FileSKIMMER
        '
        Me.FileSKIMMER.BackColor = System.Drawing.Color.Gray
        Me.FileSKIMMER.Name = "FileSKIMMER"
        Me.FileSKIMMER.Size = New System.Drawing.Size(186, 22)
        Me.FileSKIMMER.Text = "File Skimmer"
        '
        'ShiftOSDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(1284, 724)
        Me.Controls.Add(Me.timepanel)
        Me.Controls.Add(Me.FLP)
        Me.Controls.Add(Me.colortext)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.desktopiconsbackground)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "ShiftOSDesktop"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ShiftOSDesktop"
        Me.TopMost = True
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.timepanel.ResumeLayout(False)
        Me.timepanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ApplicationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TerminalSTRIP As ToolStripMenuItem
    Friend WithEvents SHIFTORIUMSTRIP As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents SHUTDOWN As ToolStripMenuItem
    Friend WithEvents CPCLICKER As ToolStripMenuItem
    Friend WithEvents CLOCK As ToolStripMenuItem
    Friend WithEvents FLP As FlowLayoutPanel
    Friend WithEvents timepanel As Panel
    Friend WithEvents timelabel As Label
    Friend WithEvents autocp As Timer
    Friend WithEvents ShifterTSMI As ToolStripMenuItem
    Friend WithEvents colortext As Label
    Friend WithEvents desktopiconsbackground As ListView
    Friend WithEvents TextpadSTRIP As ToolStripMenuItem
    Friend WithEvents Timer1 As Timer
    Friend WithEvents FileSKIMMER As ToolStripMenuItem
End Class
