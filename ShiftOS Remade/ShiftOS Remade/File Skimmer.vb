Imports System.IO
Public Class File_Skimmer
    Dim NewPoint As New System.Drawing.Point
    Dim X As Integer
    Dim Y As Integer
    Dim filetype As Integer
    Public ShiftOSPath As String = ShiftOSDesktop.ShiftOSPath
#Region "Template Code"
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

    Private Sub File_Skimmer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lbllocation.Text = "C:/ShiftOS/Home/"
        showcontents()
        titlebar.BackColor = My.Settings.titlebarcolor
        closebutton.BackColor = My.Settings.closecolor
        pgbottom.BackColor = My.Settings.bordercolor
        pgleft.BackColor = My.Settings.bordercolor
        pgright.BackColor = My.Settings.bordercolor
        lbtitletext.ForeColor = My.Settings.titlebartextcolor
        Me.lbtitletext.Font = New Font(My.Settings.ttextfontname, My.Settings.ttextsize, Shifter.itemstyle)
        If My.Settings.BoughtTitlebar = True Then
            titlebar.Visible = True
        Else
            titlebar.Visible = False
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
#End Region
    End Sub



    Private Sub pnloptions_Paint(sender As Object, e As PaintEventArgs) Handles pnloptions.Paint

    End Sub

    Private Sub lvfiles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvfiles.SelectedIndexChanged

    End Sub

    Private Sub closebutton_Click(sender As Object, e As EventArgs) Handles closebutton.Click
        Close()
    End Sub

    Private Sub pnlbreak_MouseEnter(sender As Object, e As EventArgs) Handles pnlbreak.MouseEnter

    End Sub

    Private Sub pnlbreak_MouseClick(sender As Object, e As MouseEventArgs) Handles pnlbreak.MouseClick
        If pnloptions.Visible = False Then
            pnlbreak.BackgroundImage = My.Resources.downarrow
            pnloptions.Show()
        Else
            pnlbreak.BackgroundImage = My.Resources.uparrow
            pnloptions.Hide()
        End If
    End Sub
    Private Sub showcontents()
        Me.Show()

        lvfiles.Items.Clear()

        lvfiles.Items.Add("Exit Folder", 5)

        Dim dir As New DirectoryInfo(lbllocation.Text)
        Dim files As FileInfo() = dir.GetFiles()
        Dim file As FileInfo
        Dim folders As DirectoryInfo() = dir.GetDirectories()
        Dim folder As DirectoryInfo

        For Each folder In folders
            Dim foldername As String = folder.Name
            lvfiles.Items.Add(foldername, 0)
        Next

        For Each file In files
            Dim filename As String = file.Name
            Dim fileex As String = file.Extension

            filetype = getExType(fileex)(0)

            lvfiles.Items.Add(filename, filetype)
        Next
    End Sub
    Public Function getExType(fileex As String)

        Dim filetype As Integer
        Dim program As String

        Select Case fileex
            Case ".txt"
                filetype = 2
                program = "Text Document"
            Case ".doc"
                filetype = 2
                program = "Word Document"
            Case ".docx"
                filetype = 2
                program = "Word Document"
            Case ".lst"
                filetype = 2
                program = "Spreadsheet"
            Case ".png"
                filetype = 3
                program = "Picture"
            Case ".jpg"
                filetype = 3
                program = "Picture"
            Case ".jpeg"
                filetype = 3
                program = "Picture"
            Case ".bmp"
                filetype = 3
                program = "Bitmap"
            Case ".gif"
                filetype = 3
                program = "Animated Picture"
            Case ".avi"
                filetype = 4
                program = "Video Clip"
            Case ".m4v"
                filetype = 4
                program = "MPEG-4 Video"
            Case ".mp4"
                filetype = 4
                program = "MPEG-4 Video"
            Case ".wmv"
                filetype = 4
                program = "Windows Media Video"
            Case ".mp3"
                filetype = 4
                program = "MPEG-3 Song"
            Case ".dll"
                filetype = 6
                program = "System File"
            Case ".exe"
                filetype = 7
                program = "MS-DOS Executable"
            Case ".sft"
                filetype = 8
                program = "System File"
            Case ".dri"
                filetype = 9
                program = "System File"
            Case ".pic"
                filetype = 3
                program = ".pic File"
            Case ".skn"
                filetype = 10
                program = ".skn file"
            Case ".nls"
                filetype = 11
                program = "Font File"
            Case ".icp"
                filetype = 12
                program = ".icp file"
            Case ".stp"
                filetype = 13
                program = "Setup File"
            Case ".trm"
                filetype = 14
                program = "Terminal Script File"
            Case ".owd"
                filetype = 2
                program = ".owd file"
            Case ".sh"
                filetype = 14
                program = "BASH Script"
            Case ".bat"
                filetype = 14
                program = "MS-DOS Batch File"
            Case ".command"
                filetype = 14
                program = ".command file"
            Case ".saa"
                If My.Settings.BoughtGray = True Then filetype = 15 Else filetype = 19
                program = "Stand Alone Application"
            Case ".flood"
                filetype = 16
                program = ".flood file"
            Case ".url"
                filetype = 17
                program = "Shortcut"
            Case ".urls"
                filetype = 18
                program = "Shiftnet Link"
            Case Else
                filetype = 1
                program = "Unknown File Type"
        End Select

        Dim array() As String = {CStr(filetype), program}

        Return (array)

    End Function

    Private Sub lvfiles_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles lvfiles.MouseDoubleClick
        If lvfiles.SelectedItems(0).Text = "Exit Folder" Then

            If lbllocation.Text = "C:/ShiftOS" Or lbllocation.Text = "C:/ShiftOS/" Then
                infobox.lbtitletext.Text = "File Skimmer - Warning!"
                infobox.txtmessage.Text = "Unable to move into a higher directory due to error reading the requested folder on the drive." & Environment.NewLine & Environment.NewLine & "You can only enter directories formatted in the ShiftOS file system (ShiftFS)"
                infobox.Show()
            Else
                Dim directoryInfo As System.IO.DirectoryInfo
                directoryInfo = System.IO.Directory.GetParent(lbllocation.Text)
                If directoryInfo.FullName = "C:/" Then Dim errerror As String = "an error" Else lbllocation.Text = directoryInfo.FullName
                showcontents()
            End If
        Else
            'Check if selected item is a file or folder. It it's a folder check its extension
            If lbllocation.Text Like "*/" Then
            Else
                lbllocation.Text = lbllocation.Text + "/"
            End If
            openfile(lbllocation.Text + lvfiles.SelectedItems(0).Text)
        End If
        'Dim endloop As Boolean = False
        'lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)

        'While endloop = False
        '    Try
        '        If lbllocation.Text.Substring(lbllocation.Text.Length - 1) = "/" Then
        '            endloop = True
        '        Else
        '            lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)
        '        End If
        '    Catch
        '        infobox.title = "File Skimmer - Error!"
        '        infobox.textinfo = "Unable to move into a higher directory due to error reading the requested folder on the drive." & Environment.NewLine & Environment.NewLine & "An error occured going up"
        '        infobox.Show()
        '    End Try
        'End While
        Dim endloop As Boolean = False
        lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)

        While endloop = False
            If lbllocation.Text.Substring(lbllocation.Text.Length - 0) = "/" Then
                endloop = True
            Else
                lbllocation.Text = lbllocation.Text.Substring(0, lbllocation.Text.Length - 1)
            End If
        End While
        showcontents()
    End Sub
    Public Sub openfile(Path As String)
        If Path Like "*.txt" Then
            If Textpad.needtosave = False Then
                Textpad.Show()
                Textpad.TextBox1.Text = My.Computer.FileSystem.ReadAllText(Path)
                Textpad.needtosave = False
            End If
        End If
    End Sub
End Class