Public Class Form63

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label9.Height += 1
        Label10.Width += 1

       
        If Label9.Height = 519 Then
            Timer1.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Label8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        Timer1.Start()
        Timer2.Start()
        Label8.Hide()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label6.Height -= 1
        If Label6.Height = 432 Then
            Timer2.Stop()

        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label13.Text += 1

    End Sub

    Private Sub Label13_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.TextChanged
        If Label13.Text = 10 Then
            Timer4.Start()
            Timer5.Start()
        End If
        If Label13.Text = 150 Then
            Timer5.Stop()
            timer6.start()
        End If
        If Label13.Text = 190 Then
            Label14.Show()
        End If
        If Label13.Text = 240 Then
            Label14.Text = "You better watch out for this guy!"
        End If
        If Label13.Text = 280 Then
            timer8.start()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label6.Height += 2
        If Label6.Height = 432 Then
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label9.Height -= 1
        Label10.Width -= 1
        If Label9.Height = 0 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        PictureBox1.Left -= 2
        If PictureBox1.Location.X <= 618 Then
            Timer7.Start()
            Timer6.Stop()
        End If

    End Sub

    Private Sub Timer7_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer7.Tick
        PictureBox1.Top += 2
        If PictureBox1.Location.Y >= 376 Then
            Timer7.Stop()
        End If

    End Sub

    Private Sub Timer8_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer8.Tick
        PictureBox1.Top -= 2
        PictureBox1.Left += 2
        If PictureBox1.Location.X >= 749 Then
            Timer8.Stop()
            Timer9.Start()
        End If
    End Sub

    Private Sub Timer9_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer9.Tick
        PictureBox1.Top -= 2
        If PictureBox1.Location.Y <= 70 Then
            PictureBox2.Hide()
            Label6.Height = 432
        End If
    End Sub

    Private Sub Timer10_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer10.Tick
       
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
        Label13.Text = 0
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()

        Label6.Height = 552
        Label9.Height = 0
        Label10.Width = 0
        Label8.Show()
        PictureBox2.Show()
    End Sub



  
    Private Sub Label10_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form63_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        MoveToStart()
    End Sub

    Private Sub Form63_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level Cleared!", MsgBoxStyle.Information)
        form64.show()
        Me.Close()
    End Sub
End Class