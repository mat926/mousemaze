Public Class Form28

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs) Handles Label2.Layout

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter

        Dim startingPoint = Form29.Label3.Location
        startingPoint.Offset(120, 550)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form28_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        Dim startingPoint = Label3.Location
        startingPoint.Offset(50, 50)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        Dim startingPoint = Label3.Location
        startingPoint.Offset(50, 50)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs)
   
    End Sub

    Private Sub Form28_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class