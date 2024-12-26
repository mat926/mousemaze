Public Class face3
    Private picture As Image = My.Resources.Awesome
    Private angle As Integer
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        'Rotate the image by a further 1 degree.
        Me.angle = (Me.angle + 1) Mod 360

        'Repaint the image.
        Me.PictureBox1.Refresh()
    End Sub
    Private Sub PictureBox1_Paint(ByVal sender As Object, _
                                  ByVal e As PaintEventArgs) Handles PictureBox1.Paint
        With e.Graphics
            'Move the origin to the centre of the PictureBox.
            .TranslateTransform(Me.PictureBox1.Width \ 2, Me.PictureBox1.Height \ 2)

            'Rotate the world.
            .RotateTransform(Me.angle)

            'Draw the image so its centre coincides with the origin.
            .DrawImage(Me.picture, _
                       -Me.picture.Width \ 2, _
                       -Me.picture.Height \ 2)
        End With
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Timer1.Interval = TrackBar1.Value
        If TrackBar1.Value = 1 Then
            Label13.Hide()
        End If
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        PictureBox4.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        PictureBox5.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click
        PictureBox6.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        PictureBox7.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        PictureBox9.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click
        PictureBox8.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click
        PictureBox11.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        PictureBox12.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click
        PictureBox10.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox18_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox18.Click
        PictureBox18.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click
        PictureBox13.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        PictureBox14.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox15_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox15.Click
        PictureBox15.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox19_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox19.Click
        PictureBox19.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox17_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox17.Click
        PictureBox17.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        PictureBox16.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub PictureBox20_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox20.Click
        PictureBox20.BackColor = Color.Green
        If PictureBox19.BackColor = Color.Green And PictureBox20.BackColor = Color.Green And PictureBox4.BackColor = Color.Green And PictureBox6.BackColor = Color.Green And PictureBox7.BackColor = Color.Green And PictureBox8.BackColor = Color.Green And PictureBox9.BackColor = Color.Green And PictureBox10.BackColor = Color.Green And PictureBox11.BackColor = Color.Green And PictureBox12.BackColor = Color.Green And PictureBox13.BackColor = Color.Green And PictureBox5.BackColor = Color.Green And PictureBox14.BackColor = Color.Green And PictureBox15.BackColor = Color.Green And PictureBox16.BackColor = Color.Green And PictureBox17.BackColor = Color.Green And PictureBox18.BackColor = Color.Green Then
            Label14.Hide()
        End If
    End Sub

    Private Sub face3_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
       
    End Sub

    Private Sub face3_Click(sender As Object, e As System.EventArgs) Handles Me.Click
       
    End Sub

    Private Sub face3_ForeColorChanged(sender As Object, e As System.EventArgs) Handles Me.ForeColorChanged
       
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label6.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        PictureBox3.Hide()
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label11.Text -= 1
        If Label11.Text = 0 Then
            Timer2.Stop()
            Label11.Hide()
            Label12.Hide()
        End If
    End Sub

    Private Sub PictureBox21_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox21.Click
        PictureBox21.Hide()
        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label17.Text -= 1
        If Label17.Text = 0 Then

            Label17.Hide()
            PictureBox22.Show()
            PictureBox27.Show()
        End If
        If Label17.Text = -5 Then
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        PictureBox22.Left += 1
      
    End Sub

    Private Sub PictureBox22_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox22.Click

    End Sub

    Private Sub PictureBox27_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox27.Click
        PictureBox22.Width -= 1
        If PictureBox22.Width = 0 Then
            Timer4.Stop()
            Timer5.Start()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label16.Width -= 1
        PictureBox27.Hide()
        If Label16.Width = 0 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub PictureBox25_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox25.Click
        PictureBox26.Left += 2
        If PictureBox26.Location.X = 796 Then
            PictureBox24.Enabled = True
            PictureBox25.Hide()
        End If
    End Sub

    Private Sub PictureBox24_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox24.Click
        PictureBox26.Height += 6
        If PictureBox26.Height >= 532 Then
            Label19.Hide()
            PictureBox24.Hide()
        End If
    End Sub

    Private Sub PictureBox23_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox23.Click
        PictureBox23.Hide()
        Timer6.Start()
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label22.Text -= 1
        If Label22.Text = 0 Then
            Timer7.Start()
            Label22.Hide()
            Timer6.Stop()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        PictureBox1.Height -= 1
        PictureBox1.Width -= 1
    End Sub

    Private Sub face3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
    
    End Sub

    Private Sub face3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label5.MouseEnter, Label3.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()
        Dim startingPoint = Label1.Location
        startingPoint.Offset(30, 30)
        Cursor.Position = PointToScreen(startingPoint)
        PictureBox22.Location = New Point(190, 601)
        PictureBox22.Hide()
        PictureBox27.Hide()
        If Label16.Width = 0 = False Then
            PictureBox21.Show()
            Label17.Show()
            Label17.Text = 15
        End If
        Timer3.Stop()
        Timer4.Stop()
    End Sub

    Private Sub PictureBox22_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox22.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face4.show()
        Me.Close()
    End Sub
End Class