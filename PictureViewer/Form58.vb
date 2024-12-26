Public Class Form58

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)
        Me.Width = Me.Width + 1
    End Sub

    Private Sub Form58_Load(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        PictureBox1.Left = PictureBox1.Left + 10
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        PictureBox1.Left = PictureBox1.Left - 10

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        PictureBox1.Top = PictureBox1.Top - 10

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        PictureBox1.Top = PictureBox1.Top + 10
    End Sub

    Private Sub Form58_Load_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
        Button1.Enabled = True

    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label16.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            timer2.start()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label16.Height = Label16.Height - 1
        If Label16.Height = 0 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub PictureBox1_LocationChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.LocationChanged
        If PictureBox1.Location.X = Label11.Location.X Then
            MsgBox("SS")
        End If
        If PictureBox1.Location.X <= Label17.Location.X Then
            MsgBox("SS")
        End If
        If PictureBox1.Location.X = Label18.Location.X Then
            MsgBox("SS")
        End If
        If PictureBox1.Location.X = Label19.Location.X Then
            MsgBox("SS")
        End If
        If PictureBox1.Location.X = Label20.Location.X Then
            MsgBox("SS")
        End If
        If PictureBox1.Location.X = Label21.Location.X Then
            PictureBox1.Location = New Point(166, 406)
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter

    End Sub

    Private Sub Label14_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label14.Enter

    End Sub

    Private Sub PictureBox1_Move(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.Move
 
    End Sub

    Private Sub Label15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label15_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label15.MouseEnter
        Form59.Show()
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class