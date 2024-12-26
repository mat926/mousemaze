Public Class face9

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click
        Timer1.Start()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label10.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label8.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label40.Text -= 1
        If Label40.Text = 0 Then
            Timer1.Stop()
            Label40.Hide()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label18.Width += 1
        If Label18.Width = 307 Then
            Timer2.Stop()
        End If

    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click
        Timer3.Start()
        PictureBox5.Hide()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label41.Text -= 1
        If Label41.Text = 0 Then
            Label15.Hide()
            Timer3.Stop()
            Label41.Hide()
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        Timer4.Start()
        PictureBox7.Hide()
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label42.Text -= 1
        If Label42.Text = 0 Then
            Label22.Hide()
            Label42.Hide()
            Timer4.Stop()
        End If
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        Label32.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        Label28.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click
        Timer5.Start()
        PictureBox9.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label43.Text -= 1
        If Label43.Text = 0 Then
            Timer5.Stop()
            Label43.Hide()
            timer6.start()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label9.Width -= 1
        If Label9.Width = 0 Then
            Timer6.Stop()
        End If
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox10_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox10.MouseEnter
        Timer7.Start()
        PictureBox10.Hide()
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        PictureBox1.Height -= 1
        PictureBox1.Width = -1
        If PictureBox1.Height = 0 Then
            Timer7.Stop()
        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face10.show()
        Me.Hide()
    End Sub

    Private Sub face9_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub face9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter, Me.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label32_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label32.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label19_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label19.MouseEnter
        MoveToStart()
    End Sub

    Private Sub LineShape10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LineShape9.MouseEnter, LineShape8.MouseEnter, LineShape7.MouseEnter, LineShape5.MouseEnter, LineShape4.MouseEnter, LineShape3.MouseEnter, LineShape2.MouseEnter, LineShape11.MouseEnter, LineShape10.MouseEnter, LineShape1.MouseEnter
        MoveToStart()
    End Sub
End Class