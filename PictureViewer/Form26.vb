Public Class Form26

    Private Sub Form26_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        Label3.Hide()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form26_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
        If Label2.Text = "Finish" Then
            Dim startingPoint = Label3.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label2.Text = "Finish"
        Label3.Show()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If Label2.Text = "Finish" Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            Form27.Show()
          
            Me.Hide()
        End If
    End Sub

    Private Sub Form26_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class