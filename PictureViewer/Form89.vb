Public Class Form89

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        Form90.Show()
        Me.Hide()
    End Sub

    Private Sub Label6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label21.MouseEnter, Label17.MouseEnter, Label16.MouseEnter, Label15.MouseEnter, Label14.MouseEnter, Label13.MouseEnter, Label12.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form89_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        
    End Sub

    Private Sub Label23_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label23.MouseEnter, Label22.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Form91.Show()
        Me.Hide()
    End Sub

    Private Sub Form89_VisibleChanged(sender As Object, e As System.EventArgs) Handles Me.VisibleChanged
       
    End Sub

    Private Sub Label22_VisibleChanged(sender As Object, e As System.EventArgs) Handles Label22.VisibleChanged
        If Label22.Visible = True And Label23.Visible = True Then
            Label21.Hide()
            Label2.Enabled = True
        End If
    End Sub

    Private Sub Label23_VisibleChanged(sender As Object, e As System.EventArgs) Handles Label23.VisibleChanged
        If Label22.Visible = True And Label23.Visible = True Then
            Label21.Hide()
            Label2.Enabled = True
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Form92.Show()
        Me.Close()
    End Sub
End Class