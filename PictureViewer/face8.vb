Public Class face8
    Dim MoveRight As Boolean
    Dim MoveUp As Boolean
    Dim MoveRight2 As Boolean
    Dim MoveUp2 As Boolean
    Dim MoveRight3 As Boolean
    Dim MoveUp3 As Boolean
    Dim MoveRight4 As Boolean
    Dim MoveUp4 As Boolean
    Dim MoveRight5 As Boolean
    Dim MoveUp5 As Boolean
    Dim MoveRight6 As Boolean
    Dim MoveUp6 As Boolean
    Dim MoveRight7 As Boolean
    Dim MoveUp7 As Boolean
    Private Sub face8_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        If MoveRight = True Then
            PictureBox1.Left += 2
        Else
            PictureBox1.Left -= 2
        End If

        If MoveUp = True Then
            PictureBox1.Top -= 2
        Else
            PictureBox1.Top += 2
        End If

        If PictureBox1.Left <= Label28.Left Then
            MoveRight = True
        End If
        If PictureBox1.Left + PictureBox1.Width >= Label28.Right Then
            MoveRight = False
        End If

        If PictureBox1.Top <= Label28.Top Then
            MoveUp = False
        End If

        If PictureBox1.Top + PictureBox1.Height >= Label28.Bottom Then
            MoveUp = True
        End If
    End Sub

    Private Sub Label27_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label27.MouseEnter
        Timer2.Start()

        Timer3.Start()
        Timer4.Start()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label26.Width -= 1
        If Label26.Width = 0 Then
            Timer2.Stop()


        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
    

        If MoveRight2 = True Then
            PictureBox2.Left += 2
        Else
            PictureBox2.Left -= 2
        End If

        If MoveUp2 = True Then
            PictureBox2.Top -= 2
        Else
            PictureBox2.Top += 2
        End If

        If PictureBox2.Left <= Label29.Left Then
            MoveRight2 = True
        End If
        If PictureBox2.Left + PictureBox2.Width >= Label29.Right Then
            MoveRight2 = False
        End If

        If PictureBox2.Top <= Label29.Top Then
            MoveUp2 = False
        End If

        If PictureBox2.Top + PictureBox2.Height >= Label29.Bottom Then
            MoveUp2 = True
        End If
    End Sub

    Private Sub Label27_Click(sender As System.Object, e As System.EventArgs) Handles Label27.Click

    End Sub

    Private Sub Timer4_Tick(sender As System.Object, e As System.EventArgs) Handles Timer4.Tick
       

        If MoveRight3 = True Then
            PictureBox5.Left += 2
        Else
            PictureBox5.Left -= 2
        End If

        If MoveUp3 = True Then
            PictureBox5.Top -= 2
        Else
            PictureBox5.Top += 2
        End If

        If PictureBox5.Left <= Label29.Left Then
            MoveRight3 = True
        End If
        If PictureBox5.Left + PictureBox5.Width >= Label29.Right Then
            MoveRight3 = False
        End If

        If PictureBox5.Top <= Label29.Top Then
            MoveUp3 = False
        End If

        If PictureBox5.Top + PictureBox5.Height >= Label29.Bottom Then
            MoveUp3 = True
        End If
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        Timer5.Start()
        Timer6.Start()

        Timer7.Start()
        Timer8.Start()
        Timer9.Start()
        PictureBox7.Hide()
    End Sub

    Private Sub Timer5_Tick(sender As System.Object, e As System.EventArgs) Handles Timer5.Tick
        Label19.Height -= 1
        Label24.Width -= 2
        Label25.Height -= 1
        If Label24.Width = 0 Then
            Timer5.Stop()
        End If
    End Sub

    Private Sub Timer6_Tick(sender As System.Object, e As System.EventArgs) Handles Timer6.Tick
        If MoveRight4 = True Then
            PictureBox3.Left += 2
        Else
            PictureBox3.Left -= 2
        End If

        If MoveUp4 = True Then
            PictureBox3.Top -= 2
        Else
            PictureBox3.Top += 2
        End If

        If PictureBox3.Left <= Label30.Left Then
            MoveRight4 = True
        End If
        If PictureBox3.Left + PictureBox3.Width >= Label30.Right Then
            MoveRight4 = False
        End If

        If PictureBox3.Top <= Label30.Top Then


            MoveUp4 = False
        End If

        If PictureBox3.Top + PictureBox3.Height >= Label30.Bottom Then
            MoveUp4 = True
        End If
    End Sub

    Private Sub Timer7_Tick(sender As System.Object, e As System.EventArgs) Handles Timer7.Tick
        If MoveRight5 = True Then
            PictureBox4.Left += 2
        Else
            PictureBox4.Left -= 2
        End If

        If MoveUp5 = True Then
            PictureBox4.Top -= 2
        Else
            PictureBox4.Top += 2
        End If

        If PictureBox4.Left <= Label31.Left Then
            MoveRight5 = True
        End If
        If PictureBox4.Left + PictureBox4.Width >= Label31.Right Then
            MoveRight5 = False
        End If

        If PictureBox4.Top <= Label31.Top Then


            MoveUp5 = False
        End If

        If PictureBox4.Top + PictureBox4.Height >= Label31.Bottom Then
            MoveUp5 = True
        End If
    End Sub

    Private Sub Timer8_Tick(sender As System.Object, e As System.EventArgs) Handles Timer8.Tick
        If MoveRight6 = True Then
            PictureBox6.Left += 2
        Else
            PictureBox6.Left -= 2
        End If

        If MoveUp6 = True Then
            PictureBox6.Top -= 2
        Else
            PictureBox6.Top += 2
        End If

        If PictureBox6.Left <= Label31.Left Then
            MoveRight6 = True
        End If
        If PictureBox6.Left + PictureBox6.Width >= Label31.Right Then
            MoveRight6 = False
        End If

        If PictureBox6.Top <= Label31.Top Then


            MoveUp6 = False
        End If

        If PictureBox6.Top + PictureBox6.Height >= Label31.Bottom Then
            MoveUp6 = True
        End If
    End Sub

    Private Sub Timer9_Tick(sender As System.Object, e As System.EventArgs) Handles Timer9.Tick
        If MoveRight7 = True Then
            PictureBox8.Left += 2
        Else
            PictureBox8.Left -= 2
        End If

        If MoveUp7 = True Then
            PictureBox8.Top -= 2
        Else
            PictureBox8.Top += 2
        End If

        If PictureBox8.Left <= Label31.Left Then
            MoveRight7 = True
        End If
        If PictureBox8.Left + PictureBox8.Width >= Label31.Right Then
            MoveRight7 = False
        End If

        If PictureBox8.Top <= Label31.Top Then


            MoveUp7 = False
        End If

        If PictureBox8.Top + PictureBox8.Height >= Label31.Bottom Then
            MoveUp7 = True
        End If
    End Sub

    Private Sub Label25_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox1.MouseEnter, MyBase.MouseEnter, Label9.MouseEnter, Label8.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label20.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox5_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox5.MouseEnter, PictureBox2.MouseEnter, Label21.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox8.MouseEnter, PictureBox6.MouseEnter, PictureBox4.MouseEnter, PictureBox3.MouseEnter, Label23.MouseEnter, Label22.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared")
        face9.show()
        Me.Close()
    End Sub

    Private Sub Label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
    End Sub
End Class