Public Class Form103

    Private Sub Form103_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub LineShape4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LineShape4.MouseEnter, LineShape3.MouseEnter, LineShape2.MouseEnter, LineShape1.MouseEnter, LineShape9.MouseEnter, LineShape8.MouseEnter, LineShape7.MouseEnter, LineShape6.MouseEnter, LineShape5.MouseEnter, LineShape15.MouseEnter, LineShape14.MouseEnter, LineShape13.MouseEnter, LineShape12.MouseEnter, LineShape11.MouseEnter, LineShape10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        Dim startingPoint = Label10.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form104.show()
        Me.Hide()
    End Sub
End Class