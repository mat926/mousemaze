Public Class mouse3

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Text += 1
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label7.Text += 1
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_TextChanged(sender As Object, e As System.EventArgs) Handles Label4.TextChanged
        If Label4.Text = "20" Then
            Label6.Show()
        End If
        If Label4.Text = "40" Then
            Label6.Text = "You are going to pay for what you did to my friends!!!"
        End If
        If Label4.Text = "60" Then
            Label6.Text = "NOW DIE!"
        End If
        If Label4.Text = "65" Then
            Label6.Hide()
        End If
        If Label4.Text = "70" Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_TextChanged(sender As Object, e As System.EventArgs) Handles Label7.TextChanged

        If Label7.Text = "10" Then
            Timer3.Start()
        End If

        If Label7.Text = "40" Then
            Timer4.Start()
        End If
        If Label7.Text = "60" Then
            Timer5.Start()
        End If
        If Label7.Text = "80" Then
            Timer6.Start()
        End If
        If Label7.Text = "100" Then
            Timer7.Start()
        End If
        If Label7.Text = "130" Then
            Timer8.Start()
        End If
        If Label7.Text = "160" Then
            Timer9.Start()
        End If
        If Label7.Text = "180" Then
            Label6.Show()
            Label6.Text = "You think you're so tough, eh?"
        End If
        If Label7.Text = "195" Then
            Label6.Text = ""
            Timer10.Start()
        End If
        If Label7.Text = "210" Then
            Timer11.Start()
        End If
        If Label7.Text = "230" Then
            Timer12.Start()
        End If
        If Label7.Text = "250" Then
            Timer13.Start()
        End If
        If Label7.Text = "270" Then
            Timer14.Start()
        End If
        If Label7.Text = "280" Then
            Timer15.Start()
        End If
        If Label7.Text = "300" Then
            Timer16.Start()
        End If
        If Label7.Text = "330" Then
            Timer17.Start()
        End If
        If Label7.Text = "320" Then
            Timer18.Start()
        End If
        If Label7.Text = "350" Then
            Label6.Text = "Okay, YOU'RE ASKING FOR IT"
        End If
        If Label7.Text = "360" Then
            Timer19.Start()
        End If
        If Label7.Text = "370" Then
            Timer20.Start()
        End If
        If Label7.Text = "380" Then
            Timer21.Start()
        End If
        If Label7.Text = "390" Then
            Timer22.Start()
        End If
        If Label7.Text = "400" Then
            Timer23.Start()
        End If
        If Label7.Text = "410" Then
            Timer24.Start()
        End If
        If Label7.Text = "410" Then
            Timer25.Start()
        End If
    End Sub

    Private Sub mouse3_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        Timer3.Stop()
        Timer2.Stop()
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

        Timer18.Stop()
        Timer19.Stop()
        Timer20.Stop()
        Timer21.Stop()
        Timer22.Stop()
        Timer23.Stop()
        Timer24.Stop()
        Timer25.Stop()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label2.Top += 4
        Label8.Top += 4

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub



    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
        Label5.Top += 5

    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label9.Top += 5
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        Label10.Top += 5
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        Label11.Top += 5
        Label12.Top += 5
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        Label13.Top += 5
        Label14.Top += 5
        Label15.Top += 5
    End Sub

    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        Label16.Top += 5
        Label17.Top += 5
        Label18.Top += 5
        Label19.Top += 5
        Label20.Top += 5
    End Sub

    Private Sub Timer10_Tick(sender As System.Object, e As System.EventArgs)
        
    End Sub

    Private Sub mouse3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label3.MouseEnter
        If Label7.Text = "0" Then
            MoveToStart()
        Else
            MsgBox("You died x(", MsgBoxStyle.Critical)
            Me.Close()
            lastlevel3.Show()
        End If
    End Sub

    Private Sub Timer11_Tick(sender As System.Object, e As System.EventArgs) Handles Timer11.Tick
        Label23.Left += 5
    End Sub

    Private Sub Timer10_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer10.Tick
        Label21.Left += 5
        Label22.Left += 5
    End Sub

    Private Sub Timer12_Tick(sender As System.Object, e As System.EventArgs) Handles Timer12.Tick

        Label24.Left += 5
        Label25.Left += 5
        Label26.Left += 5
        Label28.Left += 5
        Label29.Left += 5
    End Sub

    Private Sub Timer13_Tick(sender As System.Object, e As System.EventArgs) Handles Timer13.Tick
        Label30.Left += 5
    End Sub

    Private Sub Timer14_Tick(sender As System.Object, e As System.EventArgs) Handles Timer14.Tick
        Label31.Left += 5
        Label32.Left += 5
    End Sub

    Private Sub Timer15_Tick(sender As System.Object, e As System.EventArgs) Handles Timer15.Tick
        Label33.Left += 5
        Label34.Left += 5
        Label35.Left += 5
        Label36.Left += 6
    End Sub

    Private Sub Timer16_Tick(sender As System.Object, e As System.EventArgs) Handles Timer16.Tick
        Label37.Left += 5
        Label38.Left += 5
        Label39.Left += 5
        Label40.Left += 5
    End Sub

    Private Sub Timer17_Tick(sender As System.Object, e As System.EventArgs) Handles Timer17.Tick
        Label42.Left += 5
        Label42.Left += 5
        Label43.Left += 5
        Label44.Left += 5
        Label46.Left += 5
    End Sub

    Private Sub Timer18_Tick(sender As System.Object, e As System.EventArgs) Handles Timer18.Tick
        Label45.Left += 5
        Label47.Left += 5
        Label48.Left += 5
        Label49.Left += 5
    End Sub
End Class