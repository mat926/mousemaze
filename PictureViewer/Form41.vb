Public Class Form41

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Height = Label4.Height - 1
        If Label4.Height = 0 Then
            Timer1.Stop()
        End If

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Timer1.Start()
        PictureBox1.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer2.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer2.Stop()
            Timer3.start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label14.Height = Label14.Height - 1
        Label14.Width = Label14.Width - 1
        If Label14.Height = 84 Then
            Timer3.Stop()
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As System.Object, e As System.EventArgs) Handles TrackBar1.Scroll
        Label9.Height = TrackBar1.Value
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs)
     
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label20.Text += 1
        If Label20.Text = 60 Then
            Timer5.Start()
        End If
        If Label20.Text = 120 Then
            Timer6.Start()
        End If
        If Label20.Text = 180 Then
            Timer7.Start()
        End If
        If Label20.Text = 250 Then
            timer8.start()
        End If
        If Label20.Text = 280 Then
            timer9.start()
        End If
        If Label20.Text = 300 Then
            timer10.start()
        End If
        If Label20.Text = 340 Then
            Timer11.Start()
        End If
        If Label20.Text = 374 Then
            Timer11.Stop()
        End If
        If Label20.Text = 400 Then
            timer12.start()
        End If
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label21.Left = Label21.Left - 4
        Label22.Left = Label22.Left - 4
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label23.Left = Label23.Left - 4
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Label24.Left = Label24.Left - 4
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Label25.Left = Label25.Left - 4
        Label26.Left = Label26.Left - 4
    End Sub

    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        Label27.Left = Label27.Left - 4
        Label28.Left = Label28.Left - 4
    End Sub

    Private Sub Timer10_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        Label29.Left = Label29.Left - 4
        Label30.Left = Label30.Left - 4
    End Sub

    Private Sub Timer11_Tick(sender As System.Object, e As System.EventArgs) Handles Timer11.Tick
        Label31.Left = Label31.Left - 3
    End Sub

    Private Sub Timer12_Tick(sender As System.Object, e As System.EventArgs) Handles Timer12.Tick
        Label31.Width = Label31.Width - 1
        If Label31.Width = 0 Then
            Label32.Show()
            Timer4.Stop()
            Timer5.Stop()
            Timer6.Stop()
            Timer7.Stop()
            Timer8.Stop()
            Timer9.Stop()
            Timer10.Stop()
            Timer11.Stop()
            Timer12.Stop()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label10.Width = 566
        PictureBox2.Hide()
        Timer4.Start()
    End Sub

    Private Sub Label19_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
        MsgBox("Sorry for interuption, but here's a tip.  When a message box like this pops up on the screen. Do NOT move the mouse so you can click 'Ok'. Simply press 'Enter' on your keyboard to make it go away. Otherwise, you would mess up.", MsgBoxStyle.Information)
        Label19.Hide()
    End Sub

    Private Sub Label43_Click(sender As System.Object, e As System.EventArgs) Handles Label43.Click

    End Sub

    Private Sub Label43_MouseEnter(sender As Object, e As System.EventArgs) Handles Label43.MouseEnter
        Label43.Hide()

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Label20.Text = 0
        PictureBox1.Show()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        Timer10.Stop()
        Timer11.Stop()
        Timer12.Stop()
        Timer1.Stop()

        Timer3.Stop()
        PictureBox2.Show()
        Label10.Width = 473
    End Sub
    Private Sub Label45_Click(sender As System.Object, e As System.EventArgs) Handles Label45.Click

    End Sub

    Private Sub Label45_LostFocus(sender As Object, e As System.EventArgs) Handles Label45.LostFocus

    End Sub

    Private Sub Label45_MouseEnter(sender As Object, e As System.EventArgs) Handles Label45.MouseEnter
        MsgBox("Your powers with the purple box are used up. You no longer are invincible to walls", MsgBoxStyle.Critical)

        Label43.Show()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter

        If Label43.Visible = True Then
            MsgBox("Congratulations! You have FINALLY completed this level", MsgBoxStyle.Information)
            My.Computer.Audio.Stop()
            form42.show()
            Me.Hide()
        Else
            MsgBox("HA HA HA HA. Did you ACTUALLY think that you could finish this level easily from that purple box? Well no.", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub Form41_Deactivate(sender As Object, e As System.EventArgs) Handles Me.Deactivate
        Me.Focus()
    End Sub

    Private Sub Form41_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label7.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As System.EventArgs) Handles Label13.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As System.EventArgs) Handles Label15.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As System.EventArgs) Handles Label17.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As System.EventArgs) Handles Label18.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As System.EventArgs) Handles Label21.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As System.EventArgs) Handles Label22.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As System.EventArgs) Handles Label23.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As System.EventArgs) Handles Label24.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label25_MouseEnter(sender As Object, e As System.EventArgs) Handles Label25.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label26_MouseEnter(sender As Object, e As System.EventArgs) Handles Label26.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label27_MouseEnter(sender As Object, e As System.EventArgs) Handles Label27.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label28_MouseEnter(sender As Object, e As System.EventArgs) Handles Label28.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs) Handles Label29.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label30_MouseEnter(sender As Object, e As System.EventArgs) Handles Label30.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label31_MouseEnter(sender As Object, e As System.EventArgs) Handles Label31.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label34_MouseEnter(sender As Object, e As System.EventArgs) Handles Label34.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label35_MouseEnter(sender As Object, e As System.EventArgs) Handles Label35.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label36_MouseEnter(sender As Object, e As System.EventArgs) Handles Label36.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label37_MouseEnter(sender As Object, e As System.EventArgs) Handles Label37.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label38_MouseEnter(sender As Object, e As System.EventArgs) Handles Label38.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label39_MouseEnter(sender As Object, e As System.EventArgs) Handles Label39.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label40_MouseEnter(sender As Object, e As System.EventArgs) Handles Label40.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label41_MouseEnter(sender As Object, e As System.EventArgs) Handles Label41.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label42_MouseEnter(sender As Object, e As System.EventArgs) Handles Label42.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label44_MouseEnter(sender As Object, e As System.EventArgs) Handles Label44.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label46_MouseEnter(sender As Object, e As System.EventArgs) Handles Label46.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label47_MouseEnter(sender As Object, e As System.EventArgs) Handles Label47.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label48_MouseEnter(sender As Object, e As System.EventArgs) Handles Label48.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label49_MouseEnter(sender As Object, e As System.EventArgs) Handles Label49.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label50_MouseEnter(sender As Object, e As System.EventArgs) Handles Label50.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label51_MouseEnter(sender As Object, e As System.EventArgs) Handles Label51.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label52_MouseEnter(sender As Object, e As System.EventArgs) Handles Label52.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label53_MouseEnter(sender As Object, e As System.EventArgs) Handles Label53.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label54_MouseEnter(sender As Object, e As System.EventArgs) Handles Label54.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label55_MouseEnter(sender As Object, e As System.EventArgs) Handles Label55.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label56_MouseEnter(sender As Object, e As System.EventArgs) Handles Label56.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label57_MouseEnter(sender As Object, e As System.EventArgs) Handles Label57.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label58_MouseEnter(sender As Object, e As System.EventArgs) Handles Label58.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label59_MouseEnter(sender As Object, e As System.EventArgs) Handles Label59.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label60_MouseEnter(sender As Object, e As System.EventArgs) Handles Label60.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label61_MouseEnter(sender As Object, e As System.EventArgs) Handles Label61.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label62_MouseEnter(sender As Object, e As System.EventArgs) Handles Label62.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label63_MouseEnter(sender As Object, e As System.EventArgs) Handles Label63.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label64_MouseEnter(sender As Object, e As System.EventArgs) Handles Label64.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label65_MouseEnter(sender As Object, e As System.EventArgs) Handles Label65.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label66_MouseEnter(sender As Object, e As System.EventArgs) Handles Label66.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label69_MouseEnter(sender As Object, e As System.EventArgs) Handles Label69.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label70_MouseEnter(sender As Object, e As System.EventArgs) Handles Label70.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label72_MouseEnter(sender As Object, e As System.EventArgs) Handles Label72.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label73_MouseEnter(sender As Object, e As System.EventArgs) Handles Label73.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label74_Layout(sender As Object, e As System.Windows.Forms.LayoutEventArgs) Handles Label74.Layout

    End Sub

    Private Sub Label74_MouseEnter(sender As Object, e As System.EventArgs) Handles Label74.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label78_MouseEnter(sender As Object, e As System.EventArgs) Handles Label78.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label82_MouseEnter(sender As Object, e As System.EventArgs) Handles Label82.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub Label83_MouseEnter(sender As Object, e As System.EventArgs) Handles Label83.MouseEnter
        If Label43.Visible = True Then
            MoveToStart()
        Else
        End If
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label83.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub Label32_MouseEnter(sender As Object, e As System.EventArgs) Handles Label32.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label33.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label67_MouseEnter(sender As Object, e As System.EventArgs) Handles Label67.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label68.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label75_MouseEnter(sender As Object, e As System.EventArgs) Handles Label75.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label76.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label77_MouseEnter(sender As Object, e As System.EventArgs) Handles Label77.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label80.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label79_MouseEnter(sender As Object, e As System.EventArgs) Handles Label79.MouseEnter
        If Label43.Visible = True Then
            Dim startingPoint = Label81.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        Else
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form41_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub Form41_LostFocus(sender As Object, e As System.EventArgs) Handles Me.LostFocus
        Me.Focus()
    End Sub
End Class