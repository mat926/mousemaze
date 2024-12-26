Public Class Form118

    Private Sub Form118_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location

        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form118_MouseHover(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseHover, Label3.MouseHover, Label2.MouseHover

    End Sub

    Private Sub Form118_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label3.MouseEnter, Label2.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        MsgBox("Level cleared")
        form119.show()
        Me.Hide()
    End Sub
End Class