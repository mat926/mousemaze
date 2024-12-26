Public Class Form109

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Hide()
        Label3.Height -= 15
        Label37.Hide()
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox9_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseEnter
        PictureBox9.Hide()
        Label3.Height -= 15
        Label43.Hide()
    End Sub

    Private Sub PictureBox12_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox12.Click

    End Sub

    Private Sub PictureBox12_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox12.MouseEnter
        PictureBox12.Hide()
        Label3.Height -= 15
        Label39.Hide()
    End Sub

    Private Sub PictureBox11_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub PictureBox11_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox11.MouseEnter
        PictureBox11.Hide()
        Label3.Height -= 15
        Label41.Hide()
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click
        
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Hide()
        Label3.Height -= 15
        Label42.Hide()
    End Sub

    Private Sub PictureBox7_LostFocus(sender As Object, e As System.EventArgs) Handles PictureBox7.LostFocus

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Hide()
        Label3.Height -= 15
        Label33.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Hide()
        Label3.Height -= 15
        Label34.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Hide()
        Label3.Height -= 15
        Label31.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles PictureBox2.MouseClick

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Hide()
        Label3.Height -= 15
        Label38.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Hide()
        Label3.Height -= 15
        Label35.Hide()
    End Sub

    Private Sub PictureBox10_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub PictureBox10_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox10.MouseEnter
        PictureBox10.Hide()
        Label3.Height -= 15
        Label36.Hide()
    End Sub

    Private Sub PictureBox13_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox13.Click

    End Sub

    Private Sub PictureBox13_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox13.MouseEnter
        PictureBox13.Hide()
        Label3.Height -= 15
        Label32.Hide()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label3.Height -= 15

    End Sub

    Private Sub Form109_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        
    End Sub

    Private Sub Form109_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form110.show()
        Me.Hide()
    End Sub
End Class