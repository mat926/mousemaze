Public Class Form47

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        If TrackBar1.Value >= 90 Or TrackBar2.Value <= 75 Or TrackBar3.Value <= 20 Or TrackBar4.Value <= 70 Or TrackBar5.Value >= 90 Or TrackBar6.Value <= 8 Then
            MsgBox("Please do not cheat!", MsgBoxStyle.Critical)
        Else
            MsgBox("Level cleared", MsgBoxStyle.Information)
            Me.Hide()
            form48.show()
        End If

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        TrackBar1.Value = 100
        TrackBar2.Value = 0
        TrackBar3.Value = 0
        TrackBar4.Value = 0
        TrackBar5.Value = 100
        TrackBar6.Value = 0
    End Sub

    Private Sub Form47_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label9.Hide()
    End Sub

    Private Sub Panel1_MouseDown(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown

    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseUp

    End Sub

    Private Sub Label4_DragEnter(sender As System.Object, e As System.Windows.Forms.DragEventArgs)

    End Sub

    Private Sub Label3_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label7.MouseEnter, Label6.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label11.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form47_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form47_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class