Public Class Form51

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = "0" Then
            Timer1.Stop()
            Label3.Hide()

            Timer2.Start()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)


    End Sub
    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label25.Width = Label25.Width - 1
        If Label25.Width = 0 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Form51_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form51_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
        If PictureBox1.Visible = True Then
            Dim startingPoint = Label11.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label2.Hide()
        PictureBox1.Hide()
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        If PictureBox1.Visible = False Then
            Dim startingPoint = Label10.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label4.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub PictureBox3_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox3.MouseEnter
        TextBox1.Enabled = True
        PictureBox3.Hide()
    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles TextBox1.MouseEnter
        If TextBox1.Text = "Finish" Then
            MsgBox("Level cleared", MsgBoxStyle.Information)
            Form52.Show()
            Me.Hide()
        End If
    End Sub

    Private Sub Label14_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label2.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form51_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class