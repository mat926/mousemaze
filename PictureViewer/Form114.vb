Public Class Form114

    Private Sub Form114_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)

        TrackBar1.Value = 0
        TrackBar2.Value = 100
        TrackBar3.Value = 100
        TrackBar4.Value = 0
        TrackBar5.Value = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("61345")
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Dim SAPI
        SAPI = CreateObject("SAPI.spvoice")
        SAPI.speak("-02348")
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = 100 Then
            Label44.Hide()
        End If
    End Sub

    Private Sub TrackBar2_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar2.Scroll
        Label5.Width -= 1
    End Sub

    Private Sub Form114_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label22.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label10.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label8.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label18.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub TrackBar4_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar4.Scroll
        Label26.Height -= 1
    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text = "61345" Then
            Label27.Hide()
            TextBox1.Enabled = False
        End If
    End Sub

    Private Sub Label32_Click(sender As System.Object, e As System.EventArgs) Handles Label32.Click

    End Sub

    Private Sub Label32_MouseEnter(sender As Object, e As System.EventArgs) Handles Label32.MouseEnter
        Dim startingPoint = Button2.Location
        startingPoint.Offset(30, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Timer1.Stop()
            Label37.Hide()
        End If
    End Sub

    Private Sub TrackBar5_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar5.Scroll
        Label38.Height -= 1
    End Sub

    Private Sub Label42_Click(sender As System.Object, e As System.EventArgs) Handles Label42.Click

    End Sub

    Private Sub Label42_MouseEnter(sender As Object, e As System.EventArgs) Handles Label42.MouseEnter
        Dim startingPoint = Label45.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub TextBox2_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text = "-02348" Then
            Label43.Hide()
            TextBox2.Enabled = False
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Exclamation)
        form115.show()
        Me.Hide()
    End Sub
End Class