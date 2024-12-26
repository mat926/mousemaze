Public Class Form18

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form18_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        PictureBox2.Hide()
        PictureBox3.Hide()
        MoveToStart()
        label16.hide()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(40, 40)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Panel1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Panel1.MouseEnter
        MoveToStart()
        Label1.Show()
        Label2.Show()
        Label3.Show()
        Label4.Show()
        Label5.Show()
        Label6.Show()
        PictureBox1.Show()
        PictureBox2.Hide()
        PictureBox3.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label11.Hide()
        Label12.Hide()
        Label13.Hide()
        Label14.Hide()
        Label15.Hide()
        label16.hide()

    End Sub
    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub PictureBox1_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.MouseEnter
        PictureBox1.Hide()
        Label7.Show()
        Label8.Show()
        Label9.Show()
        Label10.Show()
        Label1.Hide()
        Label2.Hide()
        Label3.Hide()
        Label4.Hide()
        PictureBox2.Show()
    End Sub

    Private Sub Form18_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox2.MouseEnter

        Label6.Hide()
        Label11.Show()
        PictureBox3.Show()
        PictureBox2.Hide()

    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub PictureBox3_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox3.MouseEnter
        PictureBox3.Hide()
        Label5.Hide()
        Label7.Hide()
        Label8.Hide()
        Label9.Hide()
        Label10.Hide()
        Label12.Show()
        Label13.Show()
        Label14.Show()
        Label15.Show()
        Label16.Show()
    End Sub

    Private Sub Label16_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label16.Click

    End Sub

    Private Sub Label16_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Label16.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form19.show()
        Me.Close()
    End Sub

    Private Sub Form18_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class