Public Class lastlevel3

    Private Sub Form68_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label6.Text += 1
    End Sub

    Private Sub Label6_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.TextChanged
        If Label6.Text = 75 Then
            MoveToStart()
            Label2.Show()
            Label3.Show()
            Label4.Show()
            Label5.Show()


        End If
        If Label6.Text = 130 Then
            Timer2.Start()

           
        End If
        If Label6.Text = 165 Then
            Label7.Show()
        End If
        If Label6.Text = 200 Then
            Label7.Hide()
            Label8.Show()
        End If
        If Label6.Text = 240 Then
            Label8.Hide()
            Timer3.Start()
        End If
        If Label6.Text = 295 Then
            Label9.Show()
        End If
        If Label6.Text = 318 Then
            Label9.Hide()
            label10.show()
        End If
        If Label6.Text = 335 Then
            Label10.Hide()
            label11.show()

        End If
        If Label6.Text = 360 Then
            Label11.Hide()
            Label12.Show()
        End If
        If Label6.Text = 400 Then
            Label12.Hide()
            Label13.Show()
        End If
        If Label6.Text = 430 Then
            Label13.Hide()
            Label14.Show()
            Label15.Show()
            Label16.Show()
            Label17.Show()
        End If
        If Label6.Text = 455 Then
            Timer6.Start()
            Button1.Show()
            Button2.Show()
            Button3.Show()
            Button4.Show()
            PictureBox1.Hide()
            PictureBox2.Hide()
            PictureBox3.Hide()
            PictureBox4.Hide()
            Label14.Hide()
            Label15.Hide()
            Label16.Hide()
            Label17.Hide()
            Panel1.BackColor = Color.Black
            Me.BackColor = Color.Black
            Timer1.Stop()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(17, 17)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Timer2_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        PictureBox1.Left -= 2
        If PictureBox1.Location.X = 590 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick

        PictureBox4.Left += 2

        If PictureBox4.Location.X = 224 Then
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        PictureBox2.Top -= 2
        If PictureBox2.Location.Y = 450 Then
            Timer4.Stop()
            Timer5.Start()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        PictureBox3.Top += 2
        If PictureBox3.Location.Y >= 220 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub lastlevel3_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        MsgBox(" I just wanted to say ..... Good luck. ", MsgBoxStyle.Information)
        mouse4.Show()
        Me.Hide()
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label3.Width -= 1
        If Label3.Width = 0 Then
            Timer6.Stop()
        End If
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        mouse1.show()
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        mouse2.show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        mouse3.show()
        Me.Hide()
    End Sub
End Class