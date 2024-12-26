Public Class lastlevel2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label10.Left += 2
        If Label10.Location.X = 748 Then
            Timer2.Start()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        Label10.Left -= 2
        If Label10.Location.X = 500 Then
            Timer1.Start()
            Timer2.Stop()
        End If
    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Label13.Left += 1
        If Label13.Location.X = 560 Then
            Timer4.Start()
            Timer3.Stop()
        End If
    End Sub

    Private Sub Timer4_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer4.Tick
        Label13.Left -= 1
        If Label13.Location.X = 464 Then
            Timer3.Start()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer5_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer5.Tick
        Label21.Width += 4
        If Label21.Width = 753 Then
            Timer6.Start()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer6.Tick
        Label21.Width -= 4
        If Label21.Width = 1 Then
            Timer5.Start()
            Timer6.Stop()
        End If
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        lastlevel1.Label6.Hide()
        Me.Close()
        lastlevel1.Show()





    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label3.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form67_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label21_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub
End Class