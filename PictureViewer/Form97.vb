Public Class Form97

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label6.Hide()
        PictureBox1.Hide()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Label16_Click(sender As System.Object, e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As System.EventArgs) Handles Label16.MouseEnter


        Dim startingPoint = Label84.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)


    End Sub

    Private Sub Label23_Click(sender As System.Object, e As System.EventArgs) Handles Label23.Click

    End Sub

    Private Sub Label23_MouseEnter(sender As Object, e As System.EventArgs) Handles Label23.MouseEnter

        Dim startingPoint = Label85.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label44_Click(sender As System.Object, e As System.EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label44_MouseEnter(sender As Object, e As System.EventArgs) Handles Label44.MouseEnter

        Dim startingPoint = Label86.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label68_Click(sender As System.Object, e As System.EventArgs) Handles Label68.Click

    End Sub

    Private Sub Label68_MouseEnter(sender As Object, e As System.EventArgs) Handles Label68.MouseEnter
        Dim startingPoint = Label87.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label71_Click(sender As System.Object, e As System.EventArgs) Handles Label71.Click

    End Sub

    Private Sub Label71_MouseEnter(sender As Object, e As System.EventArgs) Handles Label71.MouseEnter
        Dim startingPoint = Label88.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label81_Click(sender As System.Object, e As System.EventArgs) Handles Label81.Click

    End Sub

    Private Sub Label81_MouseEnter(sender As Object, e As System.EventArgs) Handles Label81.MouseEnter
        Dim startingPoint = Label89.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label83_Click(sender As System.Object, e As System.EventArgs) Handles Label83.Click

    End Sub

    Private Sub Label83_MouseEnter(sender As Object, e As System.EventArgs) Handles Label83.MouseEnter
        Dim startingPoint = Label90.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Form97_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label9.MouseEnter, Label82.MouseEnter, Label80.MouseEnter, Label8.MouseEnter, Label79.MouseEnter, Label78.MouseEnter, Label77.MouseEnter, Label76.MouseEnter, Label75.MouseEnter, Label74.MouseEnter, Label73.MouseEnter, Label72.MouseEnter, Label70.MouseEnter, Label7.MouseEnter, Label69.MouseEnter, Label67.MouseEnter, Label66.MouseEnter, Label65.MouseEnter, Label64.MouseEnter, Label63.MouseEnter, Label62.MouseEnter, Label61.MouseEnter, Label60.MouseEnter, Label6.MouseEnter, Label59.MouseEnter, Label58.MouseEnter, Label57.MouseEnter, Label56.MouseEnter, Label55.MouseEnter, Label54.MouseEnter, Label53.MouseEnter, Label52.MouseEnter, Label51.MouseEnter, Label50.MouseEnter, Label5.MouseEnter, Label49.MouseEnter, Label48.MouseEnter, Label47.MouseEnter, Label46.MouseEnter, Label45.MouseEnter, Label43.MouseEnter, Label42.MouseEnter, Label41.MouseEnter, Label39.MouseEnter, Label38.MouseEnter, Label36.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label29.MouseEnter, Label28.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
        If Button2.Enabled = False Then
            Dim startingPoint = Button2.Location
            startingPoint.Offset(30, 30)
            Cursor.Position = PointToScreen(startingPoint)
        End If
        If Button3.Enabled = False Then
            Dim startingPoint = Button3.Location
            startingPoint.Offset(25, 25)
            Cursor.Position = PointToScreen(startingPoint)
        End If
        If Button4.Enabled = False Then
            Dim startingPoint = Button4.Location
            startingPoint.Offset(25, 25)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button2.Text = "Good job"
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        Button3.Enabled = False
        Button3.Text = "Good job"
    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Button4.Enabled = False
        Button4.Text = "Good job"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Label70.Hide()
            Label2.Enabled = True
        End If
    End Sub

    Private Sub Label19_Click(sender As System.Object, e As System.EventArgs) Handles Label19.Click

    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
        MoveToStart()
        If Button2.Enabled = False Then
            Dim startingPoint = Button2.Location
            startingPoint.Offset(30, 30)
            Cursor.Position = PointToScreen(startingPoint)
        End If
        If Button3.Enabled = False Then
            Dim startingPoint = Button3.Location
            startingPoint.Offset(25, 25)
            Cursor.Position = PointToScreen(startingPoint)
        End If
        If Button4.Enabled = False Then
            Dim startingPoint = Button4.Location
            startingPoint.Offset(25, 25)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form98.show()
        Me.Close()
    End Sub
End Class