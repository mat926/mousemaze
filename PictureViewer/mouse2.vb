Public Class mouse2

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label24.Width -= 1
        Button2.Text -= 1
        If Label24.Width = 0 Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("If I have 12 apples, and I ate 7. How many apples do I have left?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "5" Then
            TextBox1.Enabled = False
            Label26.Hide()
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox2.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub mouse2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        TabControl1.TabPages.Remove(TabPage4)
        Timer2.Stop()
        Timer1.Stop()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label12.Hide()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("How many days,  are there in a year?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is?  84 divided by 12?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = "7" Then
            TextBox3.Enabled = False
            Label16.Hide()
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "365" Then
            TextBox2.Enabled = False
            Label13.Hide()
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("9")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = "9" Then
            Label17.Hide()
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("21")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = "21" Then
            TextBox5.Enabled = False
            Label11.Hide()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("1996")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text = "1996" Then
            TextBox4.Enabled = False
            Label10.Hide()
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("Negative 3")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = "-3" Then
            Label18.Hide()
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub Label28_Click(sender As System.Object, e As System.EventArgs) Handles Label28.Click

    End Sub

    Private Sub Label28_MouseEnter(sender As Object, e As System.EventArgs) Handles Label28.MouseEnter
        Timer2.Start()
        Label32.Show()
        Label28.Hide()
        TabControl1.TabPages.Add(TabPage4)
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label27.Text += 1
        
    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label27_TextChanged(sender As Object, e As System.EventArgs) Handles Label27.TextChanged
       
        If Label27.Text = 1 Then
            Label31.Show()
        End If
        If Label27.Text = 3 Then
            Label30.Show()
        End If
        If Label27.Text >= 5 Then
            Label29.Show()
            Timer2.Stop()
        End If



    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Label10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter, Label8.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label37.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
       
        If Label39.Text = "0" = True Then
            MoveToStart()
        Else
        End If

    End Sub

    Private Sub Label38_Click(sender As System.Object, e As System.EventArgs) Handles Label38.Click

    End Sub

    Private Sub Label38_MouseEnter(sender As Object, e As System.EventArgs) Handles Label38.MouseEnter
        Label38.Hide()
        Label39.Text = "1"

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If Label39.Text = "1" Then
            MsgBox("Mouse #2 is defeated", MsgBoxStyle.Critical)
            lastlevel3.Button2.Text = "GONE!"
            lastlevel3.Button3.Enabled = True
            lastlevel3.Button2.Enabled = False
            lastlevel3.Show()
            Me.Close()
            If MessageBox.Show("Now is a good idea to save your game. Would you like to save your game now?", "Save game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                'have to add save data here
                MsgBox("Okay, I saved your game now", MsgBoxStyle.Information)
            Else
                If MessageBox.Show("ARE YOU SURE?    THIS IS YOUR LAST CHANCE!!  Would you still like to save your game?", "Save game", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
                    'have to add save data here
                    MsgBox("Okay, I saved your game now", MsgBoxStyle.Information)
                Else
                    MsgBox("Alright, your game will NOT be saved", MsgBoxStyle.Exclamation)
                End If
            End If
        Else
            MsgBox("Cheating detected", MsgBoxStyle.Critical)
            Me.Close()
            lastlevel3.Show()
        End If

    End Sub

    Private Sub TabPage4_Click(sender As System.Object, e As System.EventArgs) Handles TabPage4.Click

    End Sub

    Private Sub mouse2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter
        If Label39.Text = "0" = True Then
            MoveToStart()
        Else
        End If
    End Sub
End Class