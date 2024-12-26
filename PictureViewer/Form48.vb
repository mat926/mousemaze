Public Class Form48

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        ProgressBar1.Value = TrackBar1.Value

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBar1.ValueChanged
        If TrackBar1.Value = 50 And Label7.Text = "50%" Then
            Label7.Text = "10%"

        End If
        If TrackBar1.Value = 10 And Label7.Text = "10%" Then
            Label7.Text = "80%"
        End If
        If TrackBar1.Value = 80 And Label7.Text = "80%" Then
            Label7.Text = "65%"
        End If
        If TrackBar1.Value = 65 And Label7.Text = "65%" Then
            Label7.Text = "14%"
        End If
        If TrackBar1.Value = 14 And Label7.Text = "14%" Then
            Label7.Text = "68%"
        End If
        If TrackBar1.Value = 68 And Label7.Text = "68%" Then
            Label7.Text = "44%"
        End If
        If TrackBar1.Value = 44 And Label7.Text = "44%" Then
            Label7.Text = "Finish"
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 0
        Label7.Text = "50%"
        
    End Sub
    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        If Label7.Text = "Finish" Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            form49.show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form48_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form48_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form48_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class