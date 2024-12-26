Public Class Form55

    Private Sub Form55_BackColorChanged(sender As Object, e As System.EventArgs) Handles Me.BackColorChanged
        
    End Sub

    Private Sub Form55_ChangeUICues(sender As Object, e As System.Windows.Forms.UICuesEventArgs) Handles Me.ChangeUICues
    
    End Sub

    Private Sub Form55_EnabledChanged(sender As Object, e As System.EventArgs) Handles Me.EnabledChanged
       
    End Sub

    Private Sub Form55_ForeColorChanged(sender As Object, e As System.EventArgs) Handles Me.ForeColorChanged

    End Sub

    Private Sub Form55_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label8_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label8.MouseEnter
        Label8.BackColor = Color.Lime
    End Sub

    Private Sub Label12_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label12.MouseEnter
        Label12.BackColor = Color.Lime
    End Sub

    Private Sub Label13_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label13.MouseEnter
        Label13.BackColor = Color.Lime
    End Sub

    Private Sub Label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        Label7.BackColor = Color.Lime
    End Sub

    Private Sub Label14_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label14.MouseEnter
        Label14.BackColor = Color.Lime
    End Sub

    Private Sub Label9_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter
        Label9.BackColor = Color.Lime
    End Sub

    Private Sub Label6_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label6.MouseEnter
        Label6.BackColor = Color.Lime
    End Sub

    Private Sub Label11_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label11.MouseEnter
        Label11.BackColor = Color.Lime
    End Sub

    Private Sub Label10_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label10.MouseEnter
        Label10.BackColor = Color.Lime
    End Sub

    Private Sub Form55_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form55_Paint(sender As Object, e As System.Windows.Forms.PaintEventArgs) Handles Me.Paint
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Form55_ParentChanged(sender As Object, e As System.EventArgs) Handles Me.ParentChanged
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Form55_RegionChanged(sender As Object, e As System.EventArgs) Handles Me.RegionChanged
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Form55_Shown(sender As Object, e As System.EventArgs) Handles Me.Shown
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Form55_StyleChanged(sender As Object, e As System.EventArgs) Handles Me.StyleChanged
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Form55_SystemColorsChanged(sender As Object, e As System.EventArgs) Handles Me.SystemColorsChanged
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Panel1_MouseEnter(sender As Object, e As System.EventArgs) Handles Panel1.MouseEnter
        If Label6.BackColor = Color.Lime And Label7.BackColor = Color.Lime And Label8.BackColor = Color.Lime And Label9.BackColor = Color.Lime And Label10.BackColor = Color.Lime And Label11.BackColor = Color.Lime And Label12.BackColor = Color.Lime And Label13.BackColor = Color.Lime And Label14.BackColor = Color.Lime Then
            Label3.Show()
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        Form56.Show()
        Me.Hide()
    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label5.MouseEnter, Label4.MouseEnter
        MoveToStart()
    End Sub
End Class