Public Class Form39

    Private Sub Form39_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Form40.Show()
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

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

    Private Sub Form39_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form39_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class