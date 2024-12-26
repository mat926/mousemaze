Public Class Form86

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label8.Left -= 1
        If Label8.Location.X = 158 Then
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label8.Left += 1
        If Label8.Location.X = 502 Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label10.Left -= 2
        Label10.Top += 1

        If Label10.Location.X = 168 Then
            Timer3.Stop()
            Timer4.Start()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label10.Left += 2
        Label10.Top -= 1
        If Label10.Location.Y = 150 Then
            Timer4.Stop()
            Timer3.Start()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label11.Left += 3
        If Label11.Location.X = 634 Then
            Timer6.Start()
            Timer5.Stop()

        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label11.Left -= 3
        If Label11.Location.X = 181 Then
            Timer6.Stop()
            Timer5.Start()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Label1.Text = "Start"
        PictureBox1.Show()

    End Sub

    Private Sub Form86_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label1.Text = "Finish"
        PictureBox1.Hide()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        If Label1.Text = "Finish" Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            Form87.Show()
            Me.Close()

        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter
        MoveToStart()
    End Sub
End Class