Public Class Form100

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.levelsaved = True
        Button1.Enabled = False
        My.Settings.Save()
        Button1.Text = "Saved!"
    End Sub

    Private Sub Form100_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub Form100_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.levelsaved = True Then
            Button1.Enabled = False
            Button1.Text = "Saved!"
            MoveToStart()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form100_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form101.show()
        Me.Close()
    End Sub
End Class