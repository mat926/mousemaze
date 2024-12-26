Public Class Form91

    Private Sub Form91_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 100
    End Sub

    Private Sub Label23_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form91_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label12.Hide()
        PictureBox1.Hide()

    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter

        Dim startingPoint = Label64.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label19.Hide()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label22.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs) Handles Label29.MouseEnter
        Dim startingPoint = Label65.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Form89.Show()
        Me.Hide()
        Form89.Label23.Show()
    End Sub
End Class