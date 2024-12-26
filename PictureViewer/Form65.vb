Public Class Form65

    Private Sub Panel2_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel2.Paint

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form65_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label30_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form65_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label33_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label33.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form66.show()
        Me.Hide()
    End Sub
End Class