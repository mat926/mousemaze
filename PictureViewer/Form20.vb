Public Class Form20

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs)
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick


    End Sub


    Private Sub Form20_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        Label2.Width = Label2.Width - 1
    End Sub

    Private Sub Label2_MouseHover(sender As System.Object, e As System.EventArgs) Handles Label2.MouseHover
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        If Label2.Width = 0 = False Then
            MsgBox("You still got some pushin' to do!", MsgBoxStyle.Critical)
        Else
            MsgBox("Level cleared!", MsgBoxStyle.Information)
        End If
    End Sub
End Class

