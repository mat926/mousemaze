Public Class Form125

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 75% Then
            Label7.Show()
        End If
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            MsgBox("Congratulations, your progress was restored and you may now continue")
            worldselection.show()
            Me.Hide()
        End If
    End Sub

    Private Sub Button1_GotFocus(sender As Object, e As System.EventArgs) Handles Button1.GotFocus
        Label6.Focus()
    End Sub

    Private Sub Form125_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()

        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub
End Class