Public Class Form24

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        timer1.start()
        PictureBox1.Hide()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label5.Height = Label5.Height + 5
    End Sub

    Private Sub Form24_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        PictureBox1.Show()
        Label5.Height = 0
        Timer1.Stop()
        MoveToStart()
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
        PictureBox1.Show()
        Label5.Height = 0
        Timer1.Stop()
        MoveToStart()
    End Sub

    Private Sub Form24_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        PictureBox1.Show()
        Label5.Height = 0
        Timer1.Stop()
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared.", MsgBoxStyle.Information)
        form25.show()
        Me.Close()
    End Sub

    Private Sub Form24_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class