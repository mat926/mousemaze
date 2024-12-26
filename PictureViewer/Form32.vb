Public Class Form32

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label2.Width = Label2.Width + 1
        If Label2.Width = 172 Then
            Button1.Show()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Timer1.Start()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub Form32_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Button1.Hide()
        MoveToStart()
        PictureBox2.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MoveToStart()
        Timer1.Stop()
        PictureBox1.Show()
        Label2.Width = 0
        Button1.Enabled = True
        Button1.Text = 30
        Button1.Hide()
        Timer2.Stop()
        PictureBox2.Hide()
        Label1.Text = "Start"
    End Sub

    Private Sub Form32_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
        Timer1.Stop()
        PictureBox1.Show()
        Label2.Width = 0
        Button1.Enabled = True
        Button1.Text = 30
        Button1.Hide()
        Timer2.Stop()
        PictureBox2.Hide()
        Label1.Text = "Start"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer2.Start()
        Button1.Enabled = False
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Timer2.Stop()
            PictureBox2.Show()
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        PictureBox2.Hide()
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label2.Width = Label2.Width - 1
        If Label2.Width = 0 Then
            Timer3.Stop()
            Label1.Text = "Finish"
        End If

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        If Label1.Text = "Finish" Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            Form33.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Form32_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class