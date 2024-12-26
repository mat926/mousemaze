Public Class Form93

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False Then
            Label3.Hide()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Timer2.Stop()
            Button2.Enabled = True
            Button2.Text = 3
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Timer2.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False Then
            Label3.Hide()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Timer3.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False Then
            Label3.Hide()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Timer4.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False Then
            Label3.Hide()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Timer5.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False And Button5.Enabled = False Then
            Label3.Hide()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Button1.Enabled = True
            Button1.Text = 3
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Button3.Text -= 1
        If Button3.Text = 0 Then
            Timer3.Stop()
            Button3.Enabled = True
            Button3.Text = 3
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Button4.Text -= 1
        If Button4.Text = 0 Then
            Timer4.Stop()
            Button4.Enabled = True
            Button4.Text = 3
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Button5.Text -= 1
        If Button5.Text = 0 Then
            Timer5.Stop()
            Button5.Enabled = True
            Button5.Text = 3
        End If
    End Sub

    Private Sub Form93_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
      
    End Sub

    Private Sub Form93_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form93_ParentChanged(sender As Object, e As System.EventArgs) Handles Me.ParentChanged
       
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form94.show()
        Me.Close()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub
End Class