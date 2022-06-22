Public Class CodepointClicker
    Dim rn As Random
    Dim rnbuttonvalue As Random
    Dim rninterval As Integer = 1000
    Dim rnbutton As String
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
    Private Sub ListBox2_Click(sender As Object, e As EventArgs)
        My.Settings.Codepoints = My.Settings.Codepoints + 1
    End Sub

    Private Sub ListBox2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = "Codepoints: " & My.Settings.Codepoints
        Label2.Text = "Codepoints Per Click: " & My.Settings.CPperClick
        Label3.Text = "CP/s: " & My.Settings.CPperClick2
    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs)

    End Sub

    Private Sub minimizebutton_Paint(sender As Object, e As PaintEventArgs) Handles minimizebutton.Paint

    End Sub

    Private Sub pnlicon_Click(sender As Object, e As EventArgs) Handles pnlicon.Click

    End Sub

    Private Sub rollupbutton_Paint(sender As Object, e As PaintEventArgs) Handles rollupbutton.Paint

    End Sub

    Private Sub closebutton_Paint(sender As Object, e As PaintEventArgs) Handles closebutton.Paint

    End Sub

    Private Sub lbtitletext_Click(sender As Object, e As EventArgs) Handles lbtitletext.Click

    End Sub

    Private Sub pgtoplcorner_Paint(sender As Object, e As PaintEventArgs) Handles pgtoplcorner.Paint

    End Sub

    Private Sub pgtoprcorner_Paint(sender As Object, e As PaintEventArgs) Handles pgtoprcorner.Paint

    End Sub

    Private Sub pgright_Paint(sender As Object, e As PaintEventArgs) Handles pgright.Paint

    End Sub

    Private Sub pgbottomrcorner_Paint(sender As Object, e As PaintEventArgs) Handles pgbottomrcorner.Paint

    End Sub

    Private Sub pgleft_Paint(sender As Object, e As PaintEventArgs) Handles pgleft.Paint

    End Sub

    Private Sub pgbottomlcorner_Paint(sender As Object, e As PaintEventArgs) Handles pgbottomlcorner.Paint

    End Sub

    Private Sub pgbottom_Paint(sender As Object, e As PaintEventArgs) Handles pgbottom.Paint

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub titlebar_Paint(sender As Object, e As PaintEventArgs) Handles titlebar.Paint

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub KnowledgeInput_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.ControlKey Then
            Terminal.Show()
            Terminal.TopLevel = True
            Me.Hide()
        End If
    End Sub

    Private Sub KnowledgeInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        Label1.Text = "Codepoints: " & My.Settings.Codepoints
        Label2.Text = "Codepoints Per Click: " & My.Settings.CPperClick
        Label3.Text = "CP/s: " & My.Settings.CPperClick2
        Button2.Text = "Upgrade Codepoints Per Click amount - " & My.Settings.CPClickerUpgradeAmount & " CP"
        Button5.Text = "Upgrade Automatic Codepoints Per Second amount - " & My.Settings.CPClickerUpgradeAmount2 & " CP"

        If My.Settings.BoughtCloseButton = True Then
            Me.closebutton.BackColor = My.Settings.closecolor
            closebutton.Visible = True
        End If
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
        End If
        If My.Settings.BoughtTitlebarText = True Then
            lbtitletext.Visible = True
        End If
        If My.Settings.BoughtBorders = True Then
            pgbottom.Visible = True
            pgleft.Visible = True
            pgright.Visible = True
        End If
    End Sub

    Private Sub GameTimer_Tick(sender As Object, e As EventArgs) Handles GameTimer.Tick

    End Sub

    Private Sub KnowledgeInput_Click(sender As Object, e As EventArgs) Handles MyBase.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.Codepoints = My.Settings.Codepoints + My.Settings.CPperClick
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If Button2.Text = "Upgrade Codepoints Per Click amount - " & My.Settings.CPClickerUpgradeAmount & " CP" Then
            If My.Settings.Codepoints >= My.Settings.CPClickerUpgradeAmount Then
                My.Settings.Codepoints = My.Settings.Codepoints - My.Settings.CPClickerUpgradeAmount
                My.Settings.CPClickerUpgradeAmount = My.Settings.CPClickerUpgradeAmount * 2
                My.Settings.CPperClick = My.Settings.CPClickerUpgradeAmount / 50
                Button2.Text = "Upgrade Codepoints Per Click amount - " & My.Settings.CPClickerUpgradeAmount & " CP"
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button5.Text = "Upgrade Automatic Codepoints Per Second amount - " & My.Settings.CPClickerUpgradeAmount2 & " CP" Then
            If My.Settings.Codepoints >= My.Settings.CPClickerUpgradeAmount2 Then
                ShiftOSDesktop.startautocodepoints()
                My.Settings.Codepoints = My.Settings.Codepoints - My.Settings.CPClickerUpgradeAmount2
                My.Settings.CPClickerUpgradeAmount2 = My.Settings.CPClickerUpgradeAmount2 * 2
                My.Settings.CPperClick2 = My.Settings.CPClickerUpgradeAmount2 / 500
                Button5.Text = "Upgrade Automatic Codepoints Per Second amount - " & My.Settings.CPClickerUpgradeAmount2 & " CP"
            End If
        End If
    End Sub
End Class