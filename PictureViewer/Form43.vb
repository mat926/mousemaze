Public Class Form43

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Me.Height = Me.Height - 3
        Panel1.Height = Panel1.Height - 3
        If Panel1.Height <= 271 Then
            Timer1.Interval = 100
        End If

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Timer1.Stop()
        Me.Height = 548
        Panel1.Height = 497
        Timer1.Interval = 1
    End Sub
    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        Timer1.Start()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter
        Timer1.Start()
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Me.Hide()
        form44.show()
    End Sub

    Private Sub Form43_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form43_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
        MoveToStart()
    End Sub

    Private Sub Form43_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class