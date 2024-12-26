Public Class Form123

    Private Sub Form123_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        MoveToStart()

    End Sub
    Private Sub MoveToStart()
        Try
            Dim startingPoint = Label1.Location
            startingPoint.Offset(30, 30)
            Cursor.Position = PointToScreen(startingPoint)
            PictureBox1.Location = New Point(-393, 12)
        Catch ex As Exception
            MsgBox("There was a problem")
        End Try
    End Sub

    Private Sub Form123_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label4.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        PictureBox1.Left += 1
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        form124.show()
        Me.Hide()
    End Sub
End Class