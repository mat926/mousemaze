Public Class Form110

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Label4.Text -= 1
        Label3.Width -= 1
        If Label4.Text = 0 Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Label5.Text -= 1
        Label6.Width -= 1
        If Label5.Text = 0 Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Label8.Text -= 1
        Label7.Height -= 1
        If Label8.Text = 0 Then
            Button3.Enabled = False
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label9.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Label11.Height -= 1
        Label10.Text -= 1
        If Label10.Text = 0 Then
            Button4.Enabled = False
        End If
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        Label12.Text -= 1
        Label11.Width -= 1
        If Label12.Text = 0 Then
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form111.show()
        Me.Hide()
    End Sub

    Private Sub Form110_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form110_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label3.MouseEnter, Label11.MouseEnter
        MoveToStart()
    End Sub
End Class