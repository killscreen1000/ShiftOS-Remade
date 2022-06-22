Imports System.IO
Public Class ShiftOSintro
    Dim fs As FileStream
    Private Sub ShiftOSintro_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Visible = True
        Label1.Text = "ShiftOS finished installing."
        If (Not System.IO.Directory.Exists("C:/ShiftOS/")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/")
        'SYSTEM FILES
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/System")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/System")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/System/Boot")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/System/Boot")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/Boot/Required_Boot.txt")) Then System.IO.File.Create("C:/ShiftOS/System/Boot/Required_Boot.txt")
        System.IO.File.WriteAllText("C:/ShiftOS/System/Boot/Required_Boot.txt", "BootSector = AA" + Environment.NewLine + "BootSector2 = A0" + Environment.NewLine + "BootSector3 = B0" + Environment.NewLine + "BootSector4 = CA")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/System/shift42")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/System/shift42")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/shift42/Mouse.dri")) Then System.IO.File.Create("C:/ShiftOS/System/shift42/Mouse.dri")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/shift42/Keyboard.dri")) Then System.IO.File.Create("C:/ShiftOS/System/shift42/Keyboard.dri")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/shift42/Display.dri")) Then System.IO.File.Create("C:/ShiftOS/System/shift42/Display.dri")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/shift42/BootLoader.dll")) Then System.IO.File.Create("C:/ShiftOS/System/shift42/BootLoader.dll")
        If (Not System.IO.File.Exists("C:/ShiftOS/System/shift42/Cheats.txt")) Then System.IO.File.Create("C:/ShiftOS/System/shift42/Cheats.txt")
        System.IO.File.WriteAllText("C:/ShiftOS/System/shift42/Cheats.txt", "Cheats.Enabled = False" + Environment.NewLine + "Cheats.AbleToBeEnabled = False")
        'HOME/BASIC FILES FOR EASY USE
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Pictures")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Pictures")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Documents")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Documents")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Desktop")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Desktop")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Music")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Music")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Pictures/Skins")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Pictures/Skins")
        If (Not System.IO.Directory.Exists("C:/ShiftOS/Home/Downloads")) Then System.IO.Directory.CreateDirectory("C:/ShiftOS/Home/Downloads")
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        My.Settings.DoIntro = False
        If Label1.Text = "ShiftOS finished installing." Then
            Label1.Text = Label1.Text + Environment.NewLine + "developer@shiftos$> Hello, thank you for testing out my custom operating system, ShiftOS. I will boot you to the desktop
shortly, but please remember what I am about to say. Press the CONTROL key after you click on the desktop to open the terminal. I'm going to go now and...
work on something else...
Remember to press the control key on the desktop, otherwise you can't open the terminal! Type ''help'' in the terminal to get started. I will boot you to the desktop now."
        End If
        If Label1.Text = "ShiftOS finished installing." Then
            If Label1.Text = Label1.Text + Environment.NewLine + "developer@shiftos$> Hello, thank you for testing out my custom operating system, ShiftOS. I will boot you to the desktop
shortly, but please remember what I am about to say. Press the CONTROL key after you click on the desktop to open the terminal. I'm going to go now and...
work on something else...
Remember to press the control key on the desktop, otherwise you can't open the terminal! Type ''help'' in the terminal to get started. I will boot you to the desktop now." Then
                Me.Close()
            End If
        End If
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Button1.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
End Class