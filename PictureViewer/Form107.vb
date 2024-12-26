Public Class Form107

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label3.Left += 1
        If Label3.Location.X = 673 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label3.Left -= 1
        If Label3.Location.X = 158 Then
            Timer2.Stop()
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label7.Top += 1
        If Label7.Location.Y = 254 Then
            Timer4.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label7.Left -= 1
        If Label7.Location.X = 94 Then
            timer5.start()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label7.Left += 1
        If Label7.Location.X = 736 Then
            Timer6.Start()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label7.Top -= 1
        If Label7.Location.Y = 105 Then
            Timer3.Start()
            Timer6.Stop()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Label10.Top += 1
        If Label10.Location.Y = 475 Then
            timer8.start()
            Timer7.Stop()
        End If
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Label10.Left += 1
        If Label10.Location.X = 658 Then
            timer9.start()
            Timer8.Stop()
        End If
    End Sub

    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        Label10.Left -= 1
        If Label10.Location.X = 64 Then
            timer10.start()
            Timer9.Stop()
        End If
    End Sub

    Private Sub Timer10_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        Label10.Top -= 1
        If Label10.Location.Y = 281 Then
            Timer10.Stop()
            Timer7.Start()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        Timer11.Stop()
        Label8.Show()
        Button1.Enabled = True
        Button1.Text = "43"
    End Sub

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label8.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer11.Start()
        Label8.Hide()
        Button1.Enabled = False
    End Sub

    Private Sub Timer11_Tick(sender As System.Object, e As System.EventArgs) Handles Timer11.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Label8.Show()
            Timer11.Stop()
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form108.show()
        Me.Hide()
    End Sub

    Private Sub Form107_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class