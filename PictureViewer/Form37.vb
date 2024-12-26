Public Class Form37

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label5.Show()
        Label31.Show()
        Label4.Hide()
        Label1.Hide()
        Timer1.Start()
        Label6.Show()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label7.Text += 1
        If Label7.Text >= 300 Then
            Label8.Location = New Point(Label8.Location.X, Label8.Location.Y + 4)
        End If
        If Label7.Text >= 500 Then
            Label9.Location = New Point(Label9.Location.X, Label9.Location.Y + 4)
        End If
        If Label7.Text >= 700 Then
            Label10.Location = New Point(Label10.Location.X, Label10.Location.Y + 5)
        End If
        If Label7.Text >= 1000 Then
            Label11.Location = New Point(Label11.Location.X, Label11.Location.Y + 4)
        End If
        If Label7.Text >= 1200 Then
            Label14.Location = New Point(Label14.Location.X, Label14.Location.Y + 4)
            Label13.Location = New Point(Label13.Location.X, Label13.Location.Y + 4)
            Label12.Location = New Point(Label12.Location.X, Label12.Location.Y + 4)
        End If
        If Label7.Text >= 1500 Then
            Label16.Location = New Point(Label16.Location.X, Label16.Location.Y + 3)

            Label15.Location = New Point(Label15.Location.X, Label15.Location.Y + 3)

        End If
        If Label7.Text >= 1700 Then
            Label18.Location = New Point(Label18.Location.X, Label18.Location.Y + 3)
            Label17.Location = New Point(Label17.Location.X, Label17.Location.Y + 3)
        End If
        If Label7.Text >= 1900 Then
            Label19.Location = New Point(Label19.Location.X, Label19.Location.Y + 3)
            Label20.Location = New Point(Label20.Location.X, Label20.Location.Y + 3)
        End If
        If Label7.Text >= 2200 Then
            Label21.Location = New Point(Label21.Location.X, Label21.Location.Y + 3)

        End If
        If Label7.Text >= 2250 Then
            Label22.Location = New Point(Label22.Location.X, Label22.Location.Y + 3)

        End If
        If Label7.Text >= 2300 Then
            Label23.Location = New Point(Label23.Location.X, Label23.Location.Y + 3)

        End If
        If Label7.Text >= 2350 Then
            Label24.Location = New Point(Label24.Location.X, Label24.Location.Y + 3)

        End If
        If Label7.Text >= 2400 Then
            Label25.Location = New Point(Label25.Location.X, Label25.Location.Y + 3)

        End If
        If Label7.Text >= 2450 Then
            Label26.Location = New Point(Label26.Location.X, Label26.Location.Y + 3)

        End If
        If Label7.Text >= 2500 Then
            Label27.Location = New Point(Label27.Location.X, Label27.Location.Y + 3)

        End If
        If Label7.Text >= 2550 Then
            Label28.Location = New Point(Label28.Location.X, Label28.Location.Y + 3)

        End If
        If Label7.Text >= 2600 Then
            Label29.Location = New Point(Label29.Location.X, Label29.Location.Y + 3)

        End If
        If Label7.Text = 2900 Then
            Timer1.Stop()
            timer2.start()
            Label30.Show()

        End If
    End Sub

    Private Sub Label7_Click(sender As System.Object, e As System.EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label7_TextChanged(sender As Object, e As System.EventArgs) Handles Label7.TextChanged
        
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label31.Height = Label31.Height - 1
      
        Label6.Height = Label6.Height - 1
        If Label6.Height = 0 Then
            Timer2.Stop()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Label4.Show()


        Label7.Text = 0
        Timer1.Stop()
        Timer2.Stop()
        Label31.Height = Label31.Height = 60
        Label5.Hide()

    End Sub

    Private Sub Form37_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()

        End If
    End Sub

    Private Sub Form37_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
    
        MoveToStart()
    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter

        MoveToStart()

    End Sub

    Private Sub Label5_MouseEnter(sender As Object, e As System.EventArgs) Handles Label5.MouseEnter
      
        MoveToStart()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs)
     
        MoveToStart()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
   
        MoveToStart()
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
  
        MoveToStart()
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
     
        MoveToStart()
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As System.EventArgs) Handles Label13.MouseEnter

        MoveToStart()
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
    
        MoveToStart()
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As System.EventArgs) Handles Label15.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As System.EventArgs) Handles Label16.MouseEnter
     
        MoveToStart()
    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As System.EventArgs) Handles Label17.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As System.EventArgs) Handles Label18.MouseEnter
      
        MoveToStart()
    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As System.EventArgs) Handles Label20.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As System.EventArgs) Handles Label21.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As System.EventArgs) Handles Label22.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As System.EventArgs) Handles Label23.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label24_MouseEnter(sender As Object, e As System.EventArgs) Handles Label24.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label25_MouseEnter(sender As Object, e As System.EventArgs) Handles Label25.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label26_MouseEnter(sender As Object, e As System.EventArgs) Handles Label26.MouseEnter
     
        MoveToStart()
    End Sub

    Private Sub Label27_MouseEnter(sender As Object, e As System.EventArgs) Handles Label27.MouseEnter
     
        MoveToStart()
    End Sub

    Private Sub Label28_MouseEnter(sender As Object, e As System.EventArgs) Handles Label28.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs) Handles Label29.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label30_MouseEnter(sender As Object, e As System.EventArgs) Handles Label30.MouseEnter
        MsgBox("Level finished!", MsgBoxStyle.Information)
        form38.show()
        Me.Hide()
    End Sub

    Private Sub Form37_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
      
        MoveToStart()
    End Sub

    Private Sub Label31_Click(sender As System.Object, e As System.EventArgs) Handles Label31.Click

    End Sub

    Private Sub Label31_MouseEnter(sender As Object, e As System.EventArgs) Handles Label31.MouseEnter
       
        MoveToStart()
    End Sub

    Private Sub Label6_Click(sender As System.Object, e As System.EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label6_MouseEnter1(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
      
        MoveToStart()
    End Sub
End Class