Public Class Form46

    Private Sub Form46_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 0
    End Sub

    Private Sub Label3_LostFocus(sender As Object, e As System.EventArgs) Handles Label3.LostFocus

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form46_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If TrackBar1.Value <= 23 Then
            MsgBox("Please do not cheat!", MsgBoxStyle.Critical)
            MoveToStart()
        Else
            MsgBox("Level Finished!", MsgBoxStyle.Information)
            form47.show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form46_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class