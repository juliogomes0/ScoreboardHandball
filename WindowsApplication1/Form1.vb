'Code by Julio Gomes '
'Version 1 '
' Data 22/09/2015 '
' Sobre mim : Apenas um programador! '
' Faça bom uso do código e melhore-o :)'
' Open source <3
Public Class Form1

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label3.Text -= 1
        If Label3.Text = 0 Then
            Label2.Text -= 1
            Label3.Text = "59"
        End If

        If Label2.Text = 0 Then
            Label1.Text -= 1
            Label2.Text = "59"
        End If

        If Label1.Text = 0 Then
            Label1.Text = "00"
        End If

        If Label1.Text = -1 Then
            Label2.Text = "00"
            Label3.Text = "00"
            Label1.Text = "00"
            Timer1.Stop()
            My.Computer.Audio.Play(My.Resources.sound, AudioPlayMode.WaitToComplete)
        End If
    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Turma1_Click(sender As Object, e As EventArgs) Handles Turma1.Click
        Dim var As Integer
        var = 0
        var = (Turma1.Text) + 1
        Me.Turma1.Text = var

        If Turma1.Text = 3 Then
            Turma1.Text = "4"
        End If

        If Turma1.Text = 5 Then
            Turma1.Text = "6"
        End If

        If Turma1.Text = 7 Then
            Turma1.Text = "8"
        End If

        If Turma1.Text >= 9 Then
            Turma1.Text = "2"
        End If

    End Sub

    Private Sub Turma2_Click(sender As Object, e As EventArgs) Handles Turma2.Click
        Dim var As Integer
        var = 0
        var = (Turma2.Text) + 1
        Me.Turma2.Text = var

        If Turma2.Text = 3 Then
            Turma2.Text = "4"
        End If

        If Turma2.Text = 5 Then
            Turma2.Text = "6"
        End If

        If Turma2.Text = 7 Then
            Turma2.Text = "8"
        End If

        If Turma2.Text >= 9 Then
            Turma2.Text = "2"
        End If
    End Sub

    Private Sub Maisgol1_Click(sender As Object, e As EventArgs) Handles Maisgol1.Click
        Dim var As Integer
        var = 0
        var = (Gol1.Text) + 1
        Me.Gol1.Text = var
    End Sub

    Private Sub menosgol1_Click(sender As Object, e As EventArgs) Handles menosgol1.Click
        Dim var As Integer
        var = 0
        var = (Gol1.Text) - 1
        Me.Gol1.Text = var
        If Gol1.Text < 0 Then
            Gol1.Text = "00"
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click
        Gol1.Text = "00"
    End Sub

    Private Sub MenosGol2_Click(sender As Object, e As EventArgs) Handles MenosGol2.Click
        Dim var As Integer
        var = 0
        var = (gol2.Text) - 1
        Me.gol2.Text = var
        If gol2.Text < 0 Then
            gol2.Text = "00"
        End If
    End Sub

    Private Sub MaisGol2_Click(sender As Object, e As EventArgs) Handles MaisGol2.Click
        Dim var As Integer
        var = 0
        var = (gol2.Text) + 1
        Me.gol2.Text = var
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click
        gol2.Text = "00"
    End Sub


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Timer1.Start()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Timer1.Stop()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label10.Text -= 1
        If Label10.Text = 0 Then
            Label9.Text -= 1
            Label10.Text = "59"
        End If

        If Label9.Text = 0 Then
            Label11.Text -= 1
            Label9.Text = "59"
        End If

        If Label11.Text = 0 Then
            Label11.Text = "00"
        End If

        If Label11.Text = -1 Then
            Label9.Text = "00"
            Label10.Text = "00"
            Label11.Text = "00"
            Timer2.Stop()
        End If

    End Sub

    Private Sub Label11_Click(sender As Object, e As EventArgs) Handles Label11.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Timer2.Start()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Timer2.Stop()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Label11.Text = "02"
        Label10.Text = "60"
        Label9.Text = "00"
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Label14.Text -= 1
        If Label14.Text = 0 Then
            Label15.Text -= 1
            Label14.Text = "59"
        End If

        If Label15.Text = 0 Then
            Label16.Text -= 1
            Label15.Text = "59"
        End If

        If Label16.Text = 0 Then
            Label16.Text = "00"
        End If

        If Label16.Text = -1 Then
            Label15.Text = "00"
            Label14.Text = "00"
            Label16.Text = "00"
            Timer3.Stop()
        End If

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Timer3.Start()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Timer3.Stop()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Label14.Text = "60"
        Label15.Text = "00"
        Label16.Text = "02"
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Label18.Text -= 1
        If Label18.Text = 0 Then
            Label19.Text -= 1
            Label18.Text = "59"
        End If

        If Label19.Text = 0 Then
            Label20.Text -= 1
            Label19.Text = "59"
        End If

        If Label20.Text = 0 Then
            Label20.Text = "00"
        End If

        If Label20.Text = -1 Then
            Label19.Text = "00"
            Label18.Text = "00"
            Label20.Text = "00"
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Timer4.Start()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        Timer4.Stop()
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Label18.Text = "60"
        Label19.Text = "00"
        Label20.Text = "02"
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label21.Text -= 1
        If Label21.Text = 0 Then
            Label23.Text -= 1
            Label21.Text = "59"
        End If

        If Label23.Text = 0 Then
            Label24.Text -= 1
            Label23.Text = "59"
        End If

        If Label24.Text = 0 Then
            Label24.Text = "00"
        End If

        If Label24.Text = -1 Then
            Label23.Text = "00"
            Label21.Text = "00"
            Label24.Text = "00"
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button20_Click(sender As Object, e As EventArgs) Handles Button20.Click
        Timer5.Start()
    End Sub

    Private Sub Button19_Click(sender As Object, e As EventArgs) Handles Button19.Click
        Timer5.Stop()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        Label21.Text = "60"
        Label23.Text = "00"
        Label24.Text = "02"
    End Sub

    Private Sub Timer6_Tick(sender As Object, e As EventArgs) Handles Timer6.Tick
        Label25.Text -= 1
        If Label25.Text = 0 Then
            Label27.Text -= 1
            Label25.Text = "59"
        End If

        If Label27.Text = 0 Then
            Label28.Text -= 1
            Label27.Text = "59"
        End If

        If Label28.Text = 0 Then
            Label28.Text = "00"
        End If

        If Label28.Text = -1 Then
            Label27.Text = "00"
            Label25.Text = "00"
            Label28.Text = "00"
            Timer6.Stop()
        End If
    End Sub

    Private Sub Button21_Click(sender As Object, e As EventArgs) Handles Button21.Click
        Timer6.Start()
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        Timer6.Stop()
    End Sub

    Private Sub Button22_Click(sender As Object, e As EventArgs) Handles Button22.Click
        Label25.Text = "60"
        Label27.Text = "00"
        Label28.Text = "02"
    End Sub

    Private Sub Label31_Click(sender As Object, e As EventArgs) Handles Label31.Click

    End Sub

    Private Sub Timer7_Tick(sender As Object, e As EventArgs) Handles Timer7.Tick
        Label29.Text -= 1
        If Label29.Text = 0 Then
            Label31.Text -= 1
            Label29.Text = "59"
        End If

        If Label31.Text = 0 Then
            Label32.Text -= 1
            Label31.Text = "59"
        End If

        If Label32.Text = 0 Then
            Label32.Text = "00"
        End If

        If Label32.Text = -1 Then
            Label31.Text = "00"
            Label29.Text = "00"
            Label32.Text = "00"
            Timer6.Stop()
        End If
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        Timer7.Start()
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Timer7.Stop()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Label29.Text = "60"
        Label31.Text = "00"
        Label32.Text = "02"
    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub

    Private Sub Label32_Click(sender As Object, e As EventArgs) Handles Label32.Click

    End Sub

    Private Sub Timer8_Tick(sender As Object, e As EventArgs) Handles Timer8.Tick
        Label33.Text = TimeOfDay
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Close()
    End Sub

    Private Sub Button24_Click(sender As Object, e As EventArgs) Handles Button24.Click
        Label1.Text = "10"
        Label2.Text = "00"
        Label3.Text = "60"
    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        Me.WindowState = FormWindowState.Maximized
    End Sub
End Class