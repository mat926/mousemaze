Public Class Form33

    Private Sub Form33_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing


    End Sub

    Private Sub Form33_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        My.Settings.level = 2
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form34.show()
        Me.Hide()
    End Sub

    Private Sub Form33_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level done")
        Form34.Show()
        Me.Hide()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
End Class