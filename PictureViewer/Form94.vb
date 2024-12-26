Public Class Form94

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Timer2.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Timer4.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Timer3.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Timer5.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Button6.Enabled = False
        Timer6.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs) Handles Button7.Click
        Button7.Enabled = False
        Timer7.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False And Button6.Enabled = False And Button7.Enabled = False Then
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Button1.Enabled = True
            Button1.Text = 10
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Timer2.Stop()
            Button2.Enabled = True
            Button2.Text = 10
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Button3.Text -= 1
        If Button3.Text = 0 Then
            Timer3.Stop()
            Button3.Enabled = True
            Button3.Text = 10
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Button4.Text -= 1
        If Button4.Text = 0 Then
            Timer4.Stop()
            Button4.Enabled = True
            Button4.Text = 10
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Button5.Text -= 1
        If Button5.Text = 0 Then
            Timer5.Stop()
            Button5.Enabled = True
            Button5.Text = 10
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Button6.Text -= 1
        If Button6.Text = 0 Then
            Timer6.Stop()
            Button6.Enabled = True
            Button6.Text = 10
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Button7.Text -= 1
        If Button7.Text = 0 Then
            Timer7.Stop()
            Button7.Enabled = True
            Button7.Text = 10
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form95.show()
        Me.Close()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form94_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form94_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub
End Class