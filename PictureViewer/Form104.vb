Public Class Form104

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        My.Settings.levelsaved2 = True
        My.Settings.levelsaved = False
        Button1.Enabled = False
        My.Settings.Save()
        Button1.Text = "Saved!"
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        If My.Computer.Clock.LocalTime.DayOfWeek = DayOfWeek.Friday = False Then
            Label10.Show()
        End If
    End Sub

    Private Sub Form104_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub Form104_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        If My.Settings.levelsaved2 = True Then
            Button1.Enabled = False
            Button1.Text = "Saved!"
        End If
        MoveToStart()
        If My.Computer.Clock.LocalTime.DayOfWeek = DayOfWeek.Friday Then
            Label10.Show()
            Label10.Text = "Horray! It's Friday!"
            Label9.Hide()
            Label12.Enabled = True
        End If

    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        MsgBox("Level Cleared!", MsgBoxStyle.Information)
        form105.show()
        Me.Hide()
    End Sub

    Private Sub Label8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
End Class