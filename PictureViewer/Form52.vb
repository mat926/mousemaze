Public Class Form52

    Private Sub Form52_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.BackColor = Color.Beige
        End If
    End Sub



    Private Sub Form52_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Label74_MouseEnter(sender As Object, e As System.EventArgs) Handles Label74.MouseEnter
        Label75.Show()
    End Sub

    Private Sub Label79_MouseEnter(sender As Object, e As System.EventArgs) Handles Label79.MouseEnter
        If Label96.Visible = False Then

            Label76.Height = 200
            Timer1.Start()
        Else
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label80.Text += 1
        If Label80.Text = 50 Then
            Timer2.Start()
        End If
        If Label80.Text = 60 Then
            Timer3.Start()
        End If
        If Label80.Text = 75 Then
            Timer4.Start()
        End If
        If Label80.Text = 90 Then
            Timer5.Start()
        End If
        If Label80.Text = 105 Then
            Timer6.Start()

        End If
        If Label80.Text = 100 Then
            Timer7.Start()
            Timer2.Stop()
        End If
        If Label80.Text = 110 Then
            Timer8.Start()
            Timer3.Stop()
        End If
        If Label80.Text = 125 Then
            Timer9.Start()
            Timer4.Stop()
        End If
        If Label80.Text = 140 Then
            Timer10.Start()
            Timer5.Stop()
        End If
        If Label80.Text = 155 Then
            Timer11.Start()
            Timer6.Stop()
        End If
        If Label80.Text = 170 Then
            Timer12.Start()
        End If
        If Label80.Text = 195 Then
            Timer13.Start()
        End If
        If Label80.Text = 230 Then
            Timer14.Start()
        End If
        If Label80.Text = 290 Then
            Timer14.Stop()
            Timer13.Stop()
            Timer12.Stop()
            Timer11.Stop()
            Label96.Show()
            Timer1.Stop()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label81.Left = Label81.Left - 4
        Label82.Left = Label82.Left - 4
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label84.Left = Label84.Left - 4
        Label83.Left = Label83.Left - 4
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label85.Left = Label85.Left - 4
        Label86.Left = Label86.Left - 4
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label87.Left = Label87.Left - 4

    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label88.Left = Label88.Left - 4
        Label89.Left = Label89.Left - 4
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick

        Label81.Left = Label81.Left + 4
        Label82.Left = Label82.Left + 4
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Label84.Left = Label84.Left + 4
        Label83.Left = Label83.Left + 4
    End Sub

    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        Label85.Left = Label85.Left + 4
        Label86.Left = Label86.Left + 4
    End Sub

    Private Sub Timer10_Tick(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        Label87.Left = Label87.Left + 4
    End Sub

    Private Sub Timer11_Tick(sender As System.Object, e As System.EventArgs) Handles Timer11.Tick
        Label88.Left = Label88.Left + 4
        Label89.Left = Label89.Left + 4
    End Sub

    Private Sub Timer12_Tick(sender As System.Object, e As System.EventArgs) Handles Timer12.Tick
        Label90.Location = New Point(Label90.Location.X, Label90.Location.Y + 4)
        Label91.Location = New Point(Label91.Location.X, Label91.Location.Y - 4)
    End Sub

    Private Sub Timer13_Tick(sender As System.Object, e As System.EventArgs) Handles Timer13.Tick
        Label93.Location = New Point(Label93.Location.X - 4, Label93.Location.Y)
        Label92.Location = New Point(Label92.Location.X + 4, Label92.Location.Y)
    End Sub

    Private Sub Timer14_Tick(sender As System.Object, e As System.EventArgs) Handles Timer14.Tick
        Label94.Location = New Point(Label94.Location.X + 4, Label94.Location.Y + 2)
        Label95.Location = New Point(Label95.Location.X + 4, Label95.Location.Y - 4)
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer15.Start()
    End Sub

    Private Sub Timer15_Tick(sender As System.Object, e As System.EventArgs) Handles Timer15.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer15.Stop()
            Timer16.Start()

        End If
    End Sub

    Private Sub Timer16_Tick(sender As System.Object, e As System.EventArgs) Handles Timer16.Tick
        Label107.Width = Label107.Width - 1
        If Label107.Width = 0 Then
            Timer16.Stop()
        End If
    End Sub




    Private Sub Label116_MouseEnter(sender As Object, e As System.EventArgs) Handles Label116.MouseEnter
        Me.BackColor = Color.Black
    End Sub

    Private Sub Label127_MouseEnter(sender As Object, e As System.EventArgs) Handles Label127.MouseEnter
        Label128.Show()
        Label75.Hide()
        Label74.Hide()
    End Sub

    Private Sub Label127_Click(sender As System.Object, e As System.EventArgs) Handles Label127.Click

    End Sub

    Private Sub Label44_Click(sender As System.Object, e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label154_MouseEnter(sender As Object, e As System.EventArgs)
        Timer17.Start()
    End Sub

    Private Sub Timer17_Tick(sender As System.Object, e As System.EventArgs) Handles Timer17.Tick
        Label168.Height = Label168.Height + 1
    End Sub

    Private Sub PictureBox10_MouseEnter(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub Label166_MouseEnter(sender As Object, e As System.EventArgs) Handles Label166.MouseEnter
        If Label155.Visible = True Then
            Label167.Show()
            Timer17.Start()
        Else
        End If

    End Sub

    Private Sub Label168_MouseEnter(sender As Object, e As System.EventArgs) Handles Label168.MouseEnter
        If Label155.Visible = True Then
            MoveToStart()
        Else
        End If
        If Label75.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label75.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
            TrackBar3.Value = 0
            TrackBar1.Value = 0
        End If
        If Label128.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label128.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 100
        TrackBar2.Value = 100
        TrackBar3.Value = 0
        Label155.Show()
        Label156.Show()
        Label168.Height = 0
        Label80.Text = 0
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()
        Timer4.Stop()
        Timer5.Stop()
        Timer6.Stop()
        Timer7.Stop()
        Timer8.Stop()
        Timer9.Stop()
        Timer10.Stop()
        Timer11.Stop()
        Timer12.Stop()
        Timer13.Stop()
        Timer14.Stop()
        Timer15.Stop()
        Timer16.Stop()
        Timer17.Stop()
        Label76.Height = 134
    End Sub
    Private Sub Label172_MouseEnter(sender As Object, e As System.EventArgs) Handles Label172.MouseEnter
        Me.BackColor = Color.LightGray
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label19.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs)
        If PictureBox2.Visible = True Then

            Dim startingPoint = Label30.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label18.Hide()
        PictureBox2.Hide()

    End Sub

    Private Sub Label47_MouseEnter(sender As Object, e As System.EventArgs)
        Dim startingPoint = Label49.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label55_MouseEnter(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub Label58_MouseEnter(sender As Object, e As System.EventArgs)
        Dim startingPoint = Label59.Location
        startingPoint.Offset(3, 3)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label46_MouseEnter(sender As Object, e As System.EventArgs)
        Dim startingPoint = Label29.Location
        startingPoint.Offset(3, 3)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        PictureBox5.Hide()
        Label102.Hide()
    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        PictureBox6.Hide()
        Label103.Hide()
    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        PictureBox7.Hide()
        Label70.Hide()
    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        PictureBox8.Hide()
        Label71.Hide()
    End Sub

    Private Sub Label96_MouseEnter(sender As Object, e As System.EventArgs)
        Dim startingPoint = Label101.Location
        startingPoint.Offset(3, 3)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        Label97.Hide()
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        Label9.Hide()
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox9_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox9.MouseEnter
        Label4.Hide()
        PictureBox9.Hide()
    End Sub

    Private Sub Label150_MouseEnter(sender As Object, e As System.EventArgs)
        Dim startingPoint = Label151.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label155_MouseEnter(sender As Object, e As System.EventArgs) Handles Label155.MouseEnter
        Label155.Hide()
    End Sub

    Private Sub Label163_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label99.MouseEnter, Label98.MouseEnter, Label97.MouseEnter, Label93.MouseEnter, Label92.MouseEnter, Label9.MouseEnter, Label87.MouseEnter, Label8.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label71.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label68.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label48.MouseEnter, Label45.MouseEnter, Label44.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label3.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label171.MouseEnter, Label170.MouseEnter, Label17.MouseEnter, Label169.MouseEnter, Label164.MouseEnter, Label163.MouseEnter, Label162.MouseEnter, Label160.MouseEnter, Label16.MouseEnter, Label159.MouseEnter, Label158.MouseEnter, Label157.MouseEnter, Label154.MouseEnter, Label153.MouseEnter, Label152.MouseEnter, Label15.MouseEnter, Label149.MouseEnter, Label148.MouseEnter, Label147.MouseEnter, Label146.MouseEnter, Label145.MouseEnter, Label144.MouseEnter, Label143.MouseEnter, Label142.MouseEnter, Label141.MouseEnter, Label140.MouseEnter, Label14.MouseEnter, Label139.MouseEnter, Label138.MouseEnter, Label137.MouseEnter, Label136.MouseEnter, Label135.MouseEnter, Label134.MouseEnter, Label133.MouseEnter, Label132.MouseEnter, Label131.MouseEnter, Label130.MouseEnter, Label13.MouseEnter, Label129.MouseEnter, Label126.MouseEnter, Label125.MouseEnter, Label124.MouseEnter, Label123.MouseEnter, Label122.MouseEnter, Label121.MouseEnter, Label120.MouseEnter, Label12.MouseEnter, Label119.MouseEnter, Label118.MouseEnter, Label117.MouseEnter, Label115.MouseEnter, Label114.MouseEnter, Label113.MouseEnter, Label112.MouseEnter, Label111.MouseEnter, Label110.MouseEnter, Label11.MouseEnter, Label109.MouseEnter, Label108.MouseEnter, Label107.MouseEnter, Label106.MouseEnter, Label105.MouseEnter, Label104.MouseEnter, Label103.MouseEnter, Label102.MouseEnter, Label100.MouseEnter, Label10.MouseEnter
        If Label155.Visible = True Then
            MoveToStart()
        Else
        End If
        If Label75.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label75.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
            TrackBar3.Value = 0
            TrackBar1.Value = 0
        End If
        If Label128.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label128.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
        End If

    End Sub


    Private Sub Label165_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label165.MouseEnter
        If Label155.Visible = False Then
            MsgBox("Did you ACTUALLY think you could finish so easily with that purple box? HA HA HA HA HA!!!!!!!!!!", MsgBoxStyle.Critical)
        Else

            MsgBox("CONGRATULATIONS!", MsgBoxStyle.Information)
            My.Settings.level = "3"
            My.Settings.Save()
            Form53.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Label96_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label96.MouseEnter
        Dim startingPoint = Label101.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label156_MouseEnter(sender As Object, e As System.EventArgs) Handles Label156.MouseEnter
        If Label155.Visible = False Then
            Label155.Show()
        Else
            MsgBox("So how did you get here???", MsgBoxStyle.Critical)
        End If
    End Sub

    Private Sub Label150_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label150.MouseEnter
        Dim startingPoint = Label151.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label81_MouseEnter(sender As Object, e As System.EventArgs) Handles Label81.MouseEnter, Label82.MouseEnter, Label83.MouseEnter, Label84.MouseEnter, Label85.MouseEnter, Label86.MouseEnter, Label87.MouseEnter, Label88.MouseEnter, Label89.MouseEnter, Label90.MouseEnter, Label91.MouseEnter, Label92.MouseEnter, Label93.MouseEnter, Label94.MouseEnter, Label95.MouseEnter
        If Label155.Visible = True Then
            MoveToStart()
        Else
        End If
        If Label75.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label75.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
            TrackBar3.Value = 0
            TrackBar1.Value = 0
        End If
        If Label128.Visible = True And Label155.Visible = True Then
            Dim startingPoint = Label128.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub Label165_Click(sender As System.Object, e As System.EventArgs) Handles Label165.Click

    End Sub

    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label29_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label29.MouseMove
        If PictureBox2.Visible = False Then

        Else
            Dim startingPoint = Label30.Location
            startingPoint.Offset(2, 2)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub Label46_Click(sender As System.Object, e As System.EventArgs) Handles Label46.Click

    End Sub

    Private Sub Label46_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label46.MouseEnter
        Dim startingPoint = Label29.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label47_Click(sender As System.Object, e As System.EventArgs) Handles Label47.Click

    End Sub

    Private Sub Label47_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label47.MouseEnter
        Dim startingPoint = Label49.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label58_Click(sender As System.Object, e As System.EventArgs) Handles Label58.Click
        
    End Sub

    Private Sub Label96_Click(sender As System.Object, e As System.EventArgs) Handles Label96.Click

    End Sub

    Private Sub Label58_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label58.MouseEnter
        Dim startingPoint = Label59.Location
        startingPoint.Offset(2, 2)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
End Class