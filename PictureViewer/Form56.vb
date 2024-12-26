Public Class Form56

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
        Label11.Show()
    End Sub

    Private Sub Form56_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        Label2.Show()
    End Sub

    Private Sub Form56_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label9.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label13.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label2.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label13.Height = Label13.Height + 1
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        Me.Hide()
        form57.show()
    End Sub
End Class