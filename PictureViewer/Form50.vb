Public Class Form50

    Private Sub Form50_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)


    End Sub
    Private Sub TextBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text.Contains("Finish") Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            form51.show()
            Me.Hide()

        ElseIf TextBox1.Text = "finish" Then
            Label6.Text = "You created a Finish, but " & vbNewLine & _
                "remember that you always must" & vbNewLine & _
                "have a capital 'F'"

        End If
    End Sub

    Private Sub Form50_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form50_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class