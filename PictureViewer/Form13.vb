Public Class Form13

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Label3.Width = Label3.Width + 1
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(30, 30)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form13_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label4_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles Label4.DragEnter

    End Sub

    Private Sub Label4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.LostFocus

    End Sub

    Private Sub Label4_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label4.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label6_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label7_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label8_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label8.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label9_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label9.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label10_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label10.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label11_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label11.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label12_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label12.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label13_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label13.MouseEnter
        MoveToStart()
        Label3.Width = Label3.Width = 0
    End Sub

    Private Sub Label2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label2.MouseEnter
        Timer1.Stop()
        MsgBox("Level done", MsgBoxStyle.Information)
        form14.show()
        Me.Hide()
    End Sub

    Private Sub Form13_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class