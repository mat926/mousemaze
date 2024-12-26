Public Class Form108

    Private Sub Form108_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 0
        TrackBar2.Value = 0
        TrackBar3.Value = 0
        TrackBar4.Value = 100
    End Sub

    Private Sub Label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter
        If Label9.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub LineShape2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LineShape9.MouseEnter, LineShape8.MouseEnter, LineShape7.MouseEnter, LineShape6.MouseEnter, LineShape5.MouseEnter, LineShape4.MouseEnter, LineShape3.MouseEnter, LineShape2.MouseEnter, LineShape1.MouseEnter
        If Label9.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        LineShape1.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        LineShape6.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label6.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        LineShape9.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        Label9.Hide()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If Label9.Visible = False Then
            MsgBox("Level cleared!", MsgBoxStyle.Information)
            form109.show()
            Me.Hide()
        Else
            MsgBox("Cheating detected!", MsgBoxStyle.Critical)
            MoveToStart()
        End If
    End Sub
End Class