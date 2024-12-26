Public Class Form105

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label12.Left -= 4
        If Label12.Location.X = 28 Then
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label12.Left += 4
        If Label12.Location.X = 604 Then
            Timer1.Start()
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label13.Left -= 5
        If Label13.Location.X = 80 Then
            Timer4.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label13.Left += 5
        If Label13.Location.X = 720 Then
            Timer3.Start()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label14.Width += 5
        If Label14.Width = 530 Then
            Timer6.Start()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label14.Width -= 5
        If Label14.Width = 0 Then
            Timer5.Start()
            Timer6.Stop()
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Label15.Height += 2
        If Label15.Height = 64 Then
            Timer7.Stop()
            Timer8.Start()
        End If
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Label15.Height -= 2
        If Label15.Height = 0 Then
            Timer8.Stop()
            Timer7.Start()
        End If
    End Sub

    Private Sub Label12_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label10.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Form105_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        MsgBox("Level Cleared!", MsgBoxStyle.Information)
        form106.show()
        Me.Hide()
    End Sub
End Class