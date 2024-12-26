Public Class face7

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Left += 1
        If PictureBox1.Location.X = 876 Then
            PictureBox1.Location = New Point(-17, 478)
        End If
        PictureBox2.Left += 1
        If PictureBox2.Location.X = 876 Then
            PictureBox2.Location = New Point(-17, 478)
        End If
        PictureBox3.Left += 1
        If PictureBox3.Location.X = 876 Then
            PictureBox3.Location = New Point(-17, 478)
        End If
        PictureBox4.Left += 1
        If PictureBox4.Location.X = 876 Then
            PictureBox4.Location = New Point(-17, 478)
        End If
        PictureBox5.Left += 1
        If PictureBox5.Location.X = 876 Then
            PictureBox5.Location = New Point(-17, 478)
        End If
        PictureBox6.Left += 1
        If PictureBox6.Location.X = 876 Then
            PictureBox6.Location = New Point(-17, 478)
        End If
        PictureBox7.Left += 1
        If PictureBox7.Location.X = 876 Then
            PictureBox7.Location = New Point(-17, 478)
        End If
        PictureBox8.Left += 1
        If PictureBox8.Location.X = 876 Then
            PictureBox8.Location = New Point(-17, 478)
        End If
        PictureBox9.Left += 1
        If PictureBox9.Location.X = 876 Then
            PictureBox9.Location = New Point(-17, 478)
        End If
        PictureBox10.Left += 1
        If PictureBox10.Location.X = 876 Then
            PictureBox10.Location = New Point(-17, 478)
        End If
        PictureBox11.Left += 1
        If PictureBox11.Location.X = 876 Then
            PictureBox11.Location = New Point(-17, 478)
        End If
        PictureBox12.Left += 1
        If PictureBox12.Location.X = 876 Then
            PictureBox12.Location = New Point(-17, 478)
        End If
        PictureBox13.Left += 1
        If PictureBox13.Location.X = 876 Then
            PictureBox13.Location = New Point(-17, 478)
        End If
        PictureBox14.Left += 1
        If PictureBox14.Location.X = 876 Then
            PictureBox14.Location = New Point(-17, 478)
        End If
        PictureBox15.Left += 1
        If PictureBox15.Location.X = 876 Then
            PictureBox15.Location = New Point(-17, 478)
        End If
        PictureBox16.Left += 1
        If PictureBox16.Location.X = 876 Then
            PictureBox16.Location = New Point(-17, 478)
        End If
        PictureBox17.Left += 1
        If PictureBox17.Location.X = 876 Then
            PictureBox17.Location = New Point(-17, 478)
        End If
    End Sub

    Private Sub PictureBox29_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox29.Click

    End Sub

    Private Sub PictureBox18_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox18.Click

    End Sub

    Private Sub face7_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox18_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox18.MouseEnter
        Dim startingPoint = PictureBox19.Location
        startingPoint.Offset(30, 30)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox20_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox20.Click
     
    End Sub

    Private Sub PictureBox20_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox20.MouseEnter
        Label36.Hide()
        PictureBox20.Hide()
    End Sub

    Private Sub PictureBox22_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub PictureBox22_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox22.MouseEnter
        Label11.Hide()
        PictureBox22.Hide()
    End Sub

    Private Sub PictureBox43_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox43.Click

    End Sub

    Private Sub PictureBox43_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox43.MouseEnter
        Label35.Hide()
        PictureBox43.Hide()
    End Sub

    Private Sub PictureBox21_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox21.Click

    End Sub

    Private Sub PictureBox21_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox21.MouseEnter
        Label39.Hide()
        PictureBox21.Hide()
    End Sub

    Private Sub PictureBox23_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub PictureBox23_LostFocus(sender As Object, e As System.EventArgs) Handles PictureBox23.LostFocus

    End Sub

    Private Sub PictureBox23_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox23.MouseEnter
        Label41.Hide()
        PictureBox23.Hide()
    End Sub

    Private Sub PictureBox24_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox24.Click
        Label43.Width -= 3
        If Label43.Width <= 0 Then
            PictureBox24.Hide()
        End If
    End Sub

    Private Sub PictureBox26_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox26.Click
        PictureBox26.Hide()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label49.Text -= 1
        If Label49.Text = 0 Then
            Timer2.Stop()
            Label12.Hide()
            Label49.Hide()
        End If
    End Sub

    Private Sub PictureBox41_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox41.Click
        Timer3.Start()
        PictureBox41.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label58.Text -= 1
        If Label58.Text = 0 Then
            Label57.Hide()
            Timer3.Stop()
            Label58.Hide()
        End If
    End Sub

    Private Sub PictureBox42_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox42.Click
        Timer4.Start()
        PictureBox42.Hide()
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label70.Text -= 1
        If Label70.Text = 0 Then
            Timer5.Start()
            Timer4.Stop()
            Label70.Hide()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label27.Width -= 1
        If Label27.Width = 0 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub face7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox9.MouseEnter, PictureBox8.MouseEnter, PictureBox7.MouseEnter, PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox40.MouseEnter, PictureBox4.MouseEnter, PictureBox39.MouseEnter, PictureBox38.MouseEnter, PictureBox37.MouseEnter, PictureBox36.MouseEnter, PictureBox35.MouseEnter, PictureBox34.MouseEnter, PictureBox33.MouseEnter, PictureBox32.MouseEnter, PictureBox31.MouseEnter, PictureBox30.MouseEnter, PictureBox3.MouseEnter, PictureBox29.MouseEnter, PictureBox28.MouseEnter, PictureBox27.MouseEnter, PictureBox25.MouseEnter, PictureBox2.MouseEnter, PictureBox17.MouseEnter, PictureBox16.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, PictureBox12.MouseEnter, PictureBox11.MouseEnter, PictureBox10.MouseEnter, PictureBox1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox44_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox44.Click
        PictureBox44.Hide()
        Timer6.Start()
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label24.Text -= 1
        If Label24.Text = 0 Then
            Timer6.Stop()
            timer7.start()
            Label53.Hide()
            Label24.Hide()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        PictureBox25.Top -= 1
        If PictureBox25.Location.Y = -15 Then
            PictureBox25.Location = New Point(421, 305)
        End If
        PictureBox27.Top -= 1
        If PictureBox27.Location.Y = -15 Then
            PictureBox27.Location = New Point(421, 305)
        End If
        PictureBox28.Top -= 1
        If PictureBox28.Location.Y = -15 Then
            PictureBox28.Location = New Point(421, 305)
        End If
        PictureBox29.Top -= 1
        If PictureBox29.Location.Y = -15 Then
            PictureBox29.Location = New Point(421, 305)
        End If
        PictureBox31.Top -= 1
        If PictureBox31.Location.Y = -15 Then
            PictureBox31.Location = New Point(421, 305)
        End If
        PictureBox30.Top += 1
        If PictureBox30.Location.Y = 305 Then
            PictureBox30.Location = New Point(490, -29)
        End If
        PictureBox32.Top += 1
        If PictureBox32.Location.Y = 305 Then
            PictureBox32.Location = New Point(490, -29)
        End If
        PictureBox33.Top += 1
        If PictureBox33.Location.Y = 305 Then
            PictureBox33.Location = New Point(490, -29)
        End If
        PictureBox34.Top += 1
        If PictureBox34.Location.Y = 305 Then
            PictureBox34.Location = New Point(490, -29)
        End If
        PictureBox35.Top += 1
        If PictureBox35.Location.Y = 305 Then
            PictureBox35.Location = New Point(490, -29)
        End If
        PictureBox36.Top -= 1
        If PictureBox36.Location.Y = -29 Then
            PictureBox36.Location = New Point(562, 305)
        End If
        PictureBox37.Top -= 1
        If PictureBox37.Location.Y = -29 Then
            PictureBox37.Location = New Point(562, 305)
        End If
        PictureBox38.Top -= 1
        If PictureBox38.Location.Y = -29 Then
            PictureBox38.Location = New Point(562, 305)
        End If
        PictureBox39.Top -= 1
        If PictureBox39.Location.Y = -29 Then
            PictureBox39.Location = New Point(562, 305)
        End If
        PictureBox40.Top -= 1
        If PictureBox40.Location.Y = -29 Then
            PictureBox40.Location = New Point(562, 305)
        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face8.show()
        Me.Close()
    End Sub
End Class