Public Class Form96

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1

        If Button1.Text = 990 Then
            Timer1.Interval = 900
        End If

        If Button1.Text = 980 Then
            Timer1.Interval = 800
        End If

        If Button1.Text = 970 Then
            Timer1.Interval = 700
        End If
        If Button1.Text = 960 Then
            Timer1.Interval = 600
        End If
        If Button1.Text = 950 Then
            Timer1.Interval = 500
        End If
        If Button1.Text = 940 Then
            Timer1.Interval = 400
        End If
        If Button1.Text = 930 Then
            Timer1.Interval = 300
        End If
        If Button1.Text = 920 Then
            Timer1.Interval = 200
        End If
        If Button1.Text = 910 Then
            Timer1.Interval = 100
        End If
        If Button1.Text = 900 Then
            Timer1.Interval = 90
        End If
        If Button1.Text = 880 Then
            Timer1.Interval = 80
        End If
        If Button1.Text = 860 Then
            Timer1.Interval = 70
        End If
        If Button1.Text = 840 Then
            Timer1.Interval = 60
        End If
        If Button1.Text = 820 Then
            Timer1.Interval = 50
        End If
        If Button1.Text = 800 Then
            Timer1.Interval = 40
        End If
        If Button1.Text = 770 Then
            Timer1.Interval = 30
        End If
        If Button1.Text = 750 Then
            Timer1.Interval = 20
        End If
        If Button1.Text = 730 Then
            Timer1.Interval = 10
        End If
        If Button1.Text = 690 Then
            Timer1.Interval = 5
        End If
        If Button1.Text = 660 Then
            Timer1.Interval = 1
        End If
        If Button1.Text = 5 Then
            Timer1.Interval = 5000
        End If
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label6.Show()
            Label7.Show()
            Label8.Show()
            Label9.Show()
            Label10.Show()
            Label11.Show()
            Label12.Show()
            Button2.Show()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs)
       
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Timer2.Start()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Timer3.Start()
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Button3.Text -= 1

        If Button3.Text = 990 Then
            Timer3.Interval = 900
        End If

        If Button3.Text = 980 Then
            Timer3.Interval = 800
        End If

        If Button3.Text = 970 Then
            Timer3.Interval = 700
        End If
        If Button3.Text = 960 Then
            Timer3.Interval = 600
        End If
        If Button3.Text = 950 Then
            Timer3.Interval = 500
        End If
        If Button3.Text = 940 Then
            Timer3.Interval = 400
        End If
        If Button3.Text = 930 Then
            Timer3.Interval = 300
        End If
        If Button3.Text = 920 Then
            Timer3.Interval = 200
        End If
        If Button3.Text = 910 Then
            Timer3.Interval = 100
        End If
        If Button3.Text = 900 Then
            Timer3.Interval = 90
        End If
        If Button3.Text = 880 Then
            Timer3.Interval = 80
        End If
        If Button3.Text = 860 Then
            Timer3.Interval = 70
        End If
        If Button3.Text = 840 Then
            Timer3.Interval = 60
        End If
        If Button3.Text = 820 Then
            Timer3.Interval = 50
        End If
        If Button3.Text = 800 Then
            Timer3.Interval = 40
        End If
        If Button3.Text = 770 Then
            Timer3.Interval = 30
        End If
        If Button3.Text = 750 Then
            Timer3.Interval = 20
        End If
        If Button3.Text = 730 Then
            Timer3.Interval = 10
        End If
        If Button3.Text = 690 Then
            Timer3.Interval = 5
        End If
        If Button3.Text = 660 Then
            Timer3.Interval = 1
        End If
        If Button3.Text = 5 Then
            Timer3.Interval = 5000
        End If
        If Button3.Text = 0 Then
            Timer3.Stop()
            Label23.Show()
            Label24.Show()
            Label25.Show()
            Label2.Show()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form96_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form96_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Timer2_Tick_1(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button2.Text -= 1

        If Button2.Text = 990 Then
            Timer2.Interval = 900
        End If

        If Button2.Text = 980 Then
            Timer2.Interval = 800
        End If

        If Button2.Text = 970 Then
            Timer2.Interval = 700
        End If
        If Button2.Text = 960 Then
            Timer2.Interval = 600
        End If
        If Button2.Text = 950 Then
            Timer2.Interval = 500
        End If
        If Button2.Text = 940 Then
            Timer2.Interval = 400
        End If
        If Button2.Text = 930 Then
            Timer2.Interval = 300
        End If
        If Button2.Text = 920 Then
            Timer2.Interval = 200
        End If
        If Button2.Text = 910 Then
            Timer2.Interval = 100
        End If
        If Button2.Text = 900 Then
            Timer2.Interval = 90
        End If
        If Button2.Text = 880 Then
            Timer2.Interval = 80
        End If
        If Button2.Text = 860 Then
            Timer2.Interval = 70
        End If
        If Button2.Text = 840 Then
            Timer2.Interval = 60
        End If
        If Button2.Text = 820 Then
            Timer2.Interval = 50
        End If
        If Button2.Text = 800 Then
            Timer2.Interval = 40
        End If
        If Button2.Text = 770 Then
            Timer2.Interval = 30
        End If
        If Button2.Text = 750 Then
            Timer2.Interval = 20
        End If
        If Button2.Text = 730 Then
            Timer2.Interval = 10
        End If
        If Button2.Text = 690 Then
            Timer2.Interval = 5
        End If
        If Button2.Text = 660 Then
            Timer2.Interval = 1
        End If
        If Button2.Text = 5 Then
            Timer2.Interval = 5000
        End If
        If Button2.Text = 0 Then
            Timer2.Stop()
            Label13.Show()
            Label14.Show()
            Label15.Show()
            Label16.Show()
            Label17.Show()
            Label18.Show()
            Label19.Show()
            Label20.Show()
            Label21.Show()
            Label22.Show()
            Button3.Show()
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form97.show()
        Me.Hide()
    End Sub
End Class