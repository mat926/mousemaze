Public Class face5

    Private Sub face5_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub face5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox2.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label8.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label10.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        Label9.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label11.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        Label14.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        Label12.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        Label15.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox9.MouseEnter
        Label13.Hide()
        PictureBox9.Hide()
    End Sub

    Private Sub PictureBox10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox10.MouseEnter
        Label19.Hide()
        PictureBox10.Hide()
    End Sub

    Private Sub PictureBox11_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox11.MouseEnter
        Label18.Hide()
        PictureBox11.Hide()
    End Sub

    Private Sub PictureBox12_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox12.MouseEnter
        Label26.Hide()
        PictureBox12.Hide()
    End Sub

    Private Sub PictureBox13_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox13.MouseEnter
        Label25.Hide()
        PictureBox13.Hide()
    End Sub

    Private Sub PictureBox14_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox14.Click
        Label29.Height -= 3
        If Label29.Height <= 0 Then
            PictureBox11.Hide()

        End If
    End Sub

    Private Sub PictureBox15_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox15.Click
        Label43.Width -= 1
        If Label43.Width = 45 Then
            PictureBox15.Hide()
            Label46.Hide()
        End If
    End Sub

    Private Sub PictureBox16_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox16.Click
        Label43.Width -= 1
        If Label43.Width = 0 Then
            PictureBox16.Hide()
        End If
    End Sub

    Private Sub Label46_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label46.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level Cleared")
        face6.show()
        Me.Close()
    End Sub
End Class