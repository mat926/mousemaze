Public Class Form70

    Private Sub Label30_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label35.MouseEnter, Label34.MouseEnter, Label33.MouseEnter, Label32.MouseEnter, Label31.MouseEnter, Label30.MouseEnter, Label3.MouseEnter, Label28.MouseEnter, Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter, Label23.MouseEnter, Label22.MouseEnter, Label21.MouseEnter, Label20.MouseEnter, Label19.MouseEnter, Label18.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        If Label29.Visible = True Then
            MoveToStart()
        Else
        End If
        If Button1.Enabled = False Then
            Dim startingPoint = Button1.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
        If Button1.Enabled = False And Button2.Enabled = False Then
            Dim startingPoint = Button2.Location
            startingPoint.Offset(20, 20)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
       

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Button1.Text = "Good Job"
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Button2.Text = "Good Job"
    End Sub

    Private Sub Label29_Click(sender As System.Object, e As System.EventArgs) Handles Label29.Click

    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As System.EventArgs) Handles Label29.MouseEnter
        Label29.Hide()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Form75.Show()
        Me.Hide()
    End Sub
End Class