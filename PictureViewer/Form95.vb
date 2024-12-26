Public Class Form95

    Private Sub Form95_FormClosing(sender As Object, e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If Label15.Text = "Hmm, try clicking that close button over there." And Label15.Visible = True Then
            PictureBox1.Show()
        End If
        If Label15.Text = "Now try doing it again" Then
            Label23.Hide()
        End If
        If Label15.Text = "Again!" Then
            Label17.Hide()
        End If
        If Label15.Text = "Again! " Then
            Label9.Hide()
            Me.ControlBox = False
        End If
    End Sub

    Private Sub Form95_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        TabControl1.TabPages.Remove(TabPage3)
    End Sub

    Private Sub Label24_Click(sender As System.Object, e As System.EventArgs) Handles Label24.Click

    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As System.EventArgs) Handles Label24.MouseEnter
        Label15.Show()
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label7.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label15.Text = "Now try doing it again"
        PictureBox2.Hide()
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False Then
            PictureBox3.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Timer2.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False Then
            PictureBox3.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Timer3.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False Then
            PictureBox3.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Timer4.Start()
        If Button1.Enabled = False And Button2.Enabled = False And Button3.Enabled = False And Button4.Enabled = False Then
            PictureBox3.Show()
            Timer1.Stop()
            Timer2.Stop()
            Timer3.Stop()
            Timer4.Stop()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Button1.Enabled = True
            Timer1.Stop()
            Button1.Text = 2
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button2.Text -= 1
        If Button2.Text = 0 Then
            Button2.Enabled = True
            Timer2.Stop()
            Button2.Text = 2
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Button3.Text -= 1
        If Button3.Text = 0 Then
            Button3.Enabled = True
            Timer3.Stop()
            Button3.Text = 2
        End If
    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Button4.Text -= 1
        If Button4.Text = 0 Then
            Button4.Enabled = True
            Timer4.Stop()
            Button4.Text = 2
        End If
    End Sub

    Private Sub PictureBox3_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        TabControl1.TabPages.Add(TabPage3)
        PictureBox3.Hide()
    End Sub

    Private Sub PictureBox4_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox4.Click

    End Sub

    Private Sub PictureBox4_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox4.MouseEnter
        Label15.Text = "Again!"
        PictureBox4.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        Label15.Text = "Again! "
        PictureBox5.Hide()
        Label16.Width = 216
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        Form96.Show()
        Me.Hide()

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Panel1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Panel1.MouseEnter

    End Sub

    Private Sub Label13_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label40.MouseEnter, Label4.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label37.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form95_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label36_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label36.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter
        MoveToStart()
    End Sub
End Class