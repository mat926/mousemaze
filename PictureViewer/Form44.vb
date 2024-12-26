Public Class Form44

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Me.Width = TrackBar1.Value
        Panel1.Width = TrackBar1.Value
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Me.Height = 227
        Me.Width = 112
        Panel1.Width = 83
        Panel1.Height = 178
        Button1.Enabled = True
        Label2.Hide()
        Timer1.Stop()
        Label2.Hide()
        Button1.Text = 10
    End Sub

    Private Sub Form44_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Form45.Show()
        Me.Hide()
    End Sub
End Class