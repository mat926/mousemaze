Public Class mouse1

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label3.Text += 1
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As System.EventArgs) Handles Label3.TextChanged
        If Label3.Text = 60 Then
            Label4.Show()
            Label2.Hide()
        End If
        If Label3.Text = 120 Then
            Label10.Show()
            Label5.Show()
            Label4.Hide()
            Label5.Show()
            Label6.Show()
            Label7.Show()
            Label8.Show()
            Label9.ForeColor = Color.White
            Timer1.Stop()
           
        End If
        If Label3.Text = 180 Then
            Label12.Show()
            Label11.Hide()
        End If
        If Label3.Text = 215 Then
            Label12.Text = "It's not fair! IT's NOT FAIR!!!!!!!!!!!!!!!!!!"

            Label11.Hide()

        End If
        If Label3.Text = 240 Then

            Label13.Show()
            Label13.Text = "CURRRSEEEEEEEE YOUUUUUU " + My.Settings.name
            Label12.Hide()

        End If
        If Label3.Text = 250 Then
            PictureBox1.Hide()
            Timer1.Stop()
            MsgBox("Mouse 1 is defeated")
            lastlevel3.Button1.Text = "GONE!"
            lastlevel3.Button2.Enabled = True
            lastlevel3.Button1.Enabled = False
            Me.Hide()
            lastlevel3.Show()
        End If
    End Sub

    Private Sub Label5_Click(sender As System.Object, e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs)

    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        Timer1.Start()
        Label11.Show()
        Label10.Hide()
        Label5.Hide()
        Label6.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
    End Sub

    Private Sub mouse1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(3, 3)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub mouse1_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter

        MoveToStart()
        

    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label5_MouseEnter_1(sender As System.Object, e As System.EventArgs) Handles Label5.MouseEnter

    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter

    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As System.EventArgs) Handles Label1.MouseLeave

    End Sub

    Private Sub Label6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter

    End Sub
End Class