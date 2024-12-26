Public Class Form111

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter

        Label4.BackColor = Color.RoyalBlue
        Label5.BackColor = Color.RoyalBlue
        Label6.BackColor = Color.RoyalBlue

        Label8.BackColor = Color.RoyalBlue

        Label10.BackColor = Color.RoyalBlue
        Label11.BackColor = Color.RoyalBlue
        Label13.BackColor = Color.RoyalBlue
        Label14.BackColor = Color.RoyalBlue
        Label15.Hide()
        PictureBox1.Hide()
        Label2.BackColor = Color.RoyalBlue
        Label2.ForeColor = Color.White
    End Sub

    Private Sub Form111_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)
        Label4.BackColor = Color.LightGray
        Label5.BackColor = Color.LightGray
        Label6.BackColor = Color.LightGray
        Label8.BackColor = Color.LightGray
        Label10.BackColor = Color.LightGray
        Label11.BackColor = Color.LightGray
        Label13.BackColor = Color.LightGray
        Label14.BackColor = Color.LightGray

        Label15.Show()
        PictureBox1.Show()
        Label2.BackColor = Color.LightGray
        Label2.ForeColor = Color.Black
    End Sub


    Private Sub Form111_MouseEnter_1(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label15.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        form112.show()
        Me.Hide()
    End Sub
End Class