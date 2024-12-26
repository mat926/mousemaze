Public Class Form25

    Private Sub Form25_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Label12.Hide()
        Label23.Hide()
        MoveToStart()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        If TrackBar1.Value = TrackBar1.Maximum Then
            Label6.Hide()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer1_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label12.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        timer2.start()
        Label23.Show()
        PictureBox2.Hide()
    End Sub
    Private Sub MoveToStart()
        Timer2.Stop()
        Label24.Width = 0
        PictureBox2.Show()
        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label24.Width = Label24.Width + 1
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label14_Click(sender As System.Object, e As System.EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label15_Click(sender As System.Object, e As System.EventArgs) Handles Label15.Click

    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As System.EventArgs) Handles Label15.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label11_Click(sender As System.Object, e As System.EventArgs) Handles Label11.Click

    End Sub

    Private Sub Label11_LostFocus(sender As Object, e As System.EventArgs) Handles Label11.LostFocus

    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As System.EventArgs) Handles Label16.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label10_Click(sender As System.Object, e As System.EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label17_Click(sender As System.Object, e As System.EventArgs) Handles Label17.Click

    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As System.EventArgs) Handles Label17.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label18_Click(sender As System.Object, e As System.EventArgs) Handles Label18.Click

    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As System.EventArgs) Handles Label18.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As System.EventArgs) Handles Label21.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As System.EventArgs) Handles Label20.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label22_Click(sender As System.Object, e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As System.EventArgs) Handles Label22.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As System.EventArgs) Handles Label24.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label8_Click(sender As System.Object, e As System.EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter
        Dim startingPoint = Label9.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click
       
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        If Button1.Text = 0 Then
            Dim startingPoint = Label13.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label15.Hide()
    End Sub

    Private Sub Form25_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        Timer2.Stop()
        MsgBox("Level finished", MsgBoxStyle.Information)
        Me.Close()
        form26.show()
    End Sub

    Private Sub Form25_KeyPress(sender As System.Object, e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress

    End Sub

    Private Sub Form25_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class