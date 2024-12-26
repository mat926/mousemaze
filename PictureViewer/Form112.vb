Public Class Form112

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Timer1.Start()
        Button2.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Timer1.Stop()
            Label12.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("432")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Form112_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        Timer1.Stop()

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = 432 Then
            Label11.Hide()
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("98")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = 98 Then
            Label5.Hide()
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("45")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox3_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text = 45 Then
            Label6.Hide()
            TextBox3.Enabled = False
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("1432")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox4_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Contains("1432") Then
            Label16.Hide()
            TextBox4.Enabled = False

        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is, 2 plus 2?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox5_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox5.TextChanged
        If TextBox5.Text = 4 Then
            Label21.Hide()
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is, 10 plus 12?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox6_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox6.TextChanged
        If TextBox6.Text = 32 Then
            Label26.Hide()
            TextBox6.Enabled = False
        End If
    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs) Handles Button8.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is, 5 times 6")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox7_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox7.TextChanged
        If TextBox7.Text = 30 Then
            Label25.Hide()
            TextBox7.Enabled = False
        End If
    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs) Handles Button9.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is, 10 times 10?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox8_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox8.TextChanged
        If TextBox8.Text = 100 Then
            Label24.Hide()
            TextBox8.Enabled = False
        End If
    End Sub

    Private Sub Button10_Click(sender As System.Object, e As System.EventArgs) Handles Button10.Click
        My.Computer.Audio.Stop()
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("What is, 10 times 4 plus 6?")
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub TextBox9_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox9.TextChanged
        If TextBox9.Text = 46 Then
            Label23.Hide()
            TextBox9.Enabled = False
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 0
        TrackBar2.Value = 0

    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Label27_MouseEnter(sender As Object, e As System.EventArgs) Handles Label27.MouseEnter
        Dim startingPoint = Label17.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label14_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form113.Show()
        Me.Hide()
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub
End Class