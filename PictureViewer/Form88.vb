Public Class Form88

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label16.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        PictureBox4.Hide()
        Label12.Hide()
    End Sub

    Private Sub Label33_Click(sender As System.Object, e As System.EventArgs) Handles Label33.Click

    End Sub

    Private Sub Label33_MouseEnter(sender As Object, e As System.EventArgs) Handles Label33.MouseEnter
        Label32.Show()
        TextBox1.Enabled = True
        Label33.Hide()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Contains("qwerty") Then
            Label11.Hide()

        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Hide()
        Label18.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Hide()
        Label34.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        Label10.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub Label13_Click(sender As System.Object, e As System.EventArgs) Handles Label13.Click

    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As System.EventArgs) Handles Label13.MouseEnter
        Dim startingPoint = Label37.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        Label36.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        Label9.Hide()
        Label35.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll

    End Sub

    Private Sub TrackBar1_ValueChanged(sender As Object, e As System.EventArgs) Handles TrackBar1.ValueChanged
        If TrackBar1.Value = 100 Then
            Label38.Hide()
        End If
    End Sub

    Private Sub PictureBox9_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox9_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseEnter
        Label8.Hide()
        PictureBox9.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label2.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        PictureBox10.Left += 1

    End Sub

    Private Sub Form88_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Label5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label38.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()

    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label20.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form89.show()
        Me.Close()
    End Sub
End Class