Public Class Form57

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label5.Text += 1
        MoveToStart()
    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As System.EventArgs) Handles Label4.TextChanged

    End Sub

    Private Sub Label5_TextChanged(sender As Object, e As System.EventArgs) Handles Label5.TextChanged
        If Label5.Text = 400 Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label7.Height = Label7.Height + 1
        Label6.Width = Label6.Width + 1

        If Label7.Height = 234 Then
            Timer1.Stop()
            Timer1.Enabled = False
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form57_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form58.show()
        Me.Hide()
    End Sub
End Class