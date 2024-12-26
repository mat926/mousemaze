Public Class face2


    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click
        PictureBox2.Height -= 1
        If PictureBox2.Height <= 0 Then
            Label3.Height = 72
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub face2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox32.MouseEnter, PictureBox31.MouseEnter, PictureBox30.MouseEnter, PictureBox29.MouseEnter, PictureBox28.MouseEnter, PictureBox27.MouseEnter, PictureBox26.MouseEnter, PictureBox25.MouseEnter, PictureBox24.MouseEnter, PictureBox23.MouseEnter, PictureBox22.MouseEnter, PictureBox21.MouseEnter, PictureBox20.MouseEnter, PictureBox19.MouseEnter, PictureBox18.MouseEnter, PictureBox17.MouseEnter, PictureBox16.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox10.MouseEnter
        PictureBox10.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Hide()
        MoveToStart()
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click
        Label4.Height -= 1
        If Label4.Height = 71 Then
            PictureBox12.Enabled = False
        End If
    End Sub

    Private Sub PictureBox33_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox33.Click
        PictureBox1.Height -= 1
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face3.show()
        Me.Close()
    End Sub
End Class