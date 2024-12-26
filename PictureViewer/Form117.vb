Public Class Form117

    Private Sub Form117_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label2.Location
        startingPoint.Offset(20, 100)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form117_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MsgBox("Level cleared")
        Form118.Show()
        Me.Hide()
    End Sub
End Class