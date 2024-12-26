Public Class Form40

    Private Sub Form40_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Form39.Label1.Location
        startingPoint.Offset(-700, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        MsgBox("Very nice. Level cleared!", MsgBoxStyle.Information)
        Form39.Hide()
        Me.Hide()
        form41.show()
    End Sub
End Class