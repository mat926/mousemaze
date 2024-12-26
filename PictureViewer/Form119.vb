Public Class Form119

    Private Sub Form119_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location

        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        form120.show()
        Me.Hide()
    End Sub
End Class