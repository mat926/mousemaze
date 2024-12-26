Public Class face4

    Private Sub face4_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label8.MouseEnter
        PictureBox19.Show()
    End Sub

    Private Sub Label9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter
        PictureBox20.Show()
    End Sub

    Private Sub Label11_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label11.MouseEnter
        PictureBox21.Show()
        PictureBox23.Show()
    End Sub

    Private Sub face4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox9.MouseEnter, PictureBox8.MouseEnter, PictureBox7.MouseEnter, PictureBox6.MouseEnter, PictureBox5.MouseEnter, PictureBox4.MouseEnter, PictureBox17.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, PictureBox12.MouseEnter, PictureBox11.MouseEnter, PictureBox10.MouseEnter, MyBase.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox21_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox21.MouseEnter, PictureBox20.MouseEnter, PictureBox19.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox27_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox27.Click
        PictureBox24.Height -= 1
        If PictureBox24.Height = 9 Then
            PictureBox27.Hide()
        End If
    End Sub

    Private Sub PictureBox22_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox22.Click
        PictureBox25.Height -= 1
        If PictureBox25.Height = 0 Then
            PictureBox22.Hide()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        PictureBox26.Height -= 1
        If PictureBox26.Height = 0 Then
            PictureBox16.Hide()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PictureBox21.Height -= 1

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click
        PictureBox20.Height -= 1
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click
        PictureBox19.Height -= 1
    End Sub

    Private Sub PictureBox23_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox23.Click

    End Sub

    Private Sub PictureBox23_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox23.MouseEnter
        PictureBox17.Hide()
        PictureBox23.Hide()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label13.Width += 1
        PictureBox4.Width -= 1

    End Sub

    Private Sub PictureBox18_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox18.Click
        Timer1.Start()
        PictureBox18.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face5.show()
        Me.Close()
    End Sub
End Class