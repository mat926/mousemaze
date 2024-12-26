Public Class Form29

    Private Sub Form29_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form29_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        Dim startingPoint = Label3.Location
        startingPoint.Offset(50, 50)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox2_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub PictureBox2_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox2.MouseEnter
        Label1.Hide()
        PictureBox2.Hide()
    End Sub

    Private Sub Label1_Click(sender As System.Object, e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Label1.MouseDown

    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As System.EventArgs) Handles Label1.MouseEnter
        Dim startingPoint = Label3.Location
        startingPoint.Offset(50, 50)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs)
        Form27.Timer3.Start()
        Form27.Label1.Text = "Finish"

    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter
        If Form27.Label1.Text = "Finish" Then
            Dim startingPoint = Form28.Label2.Location
            startingPoint.Offset(270, 450)
            Cursor.Position = PointToScreen(startingPoint)
        End If
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Good job! Level cleared", MsgBoxStyle.Information)
        Me.Hide()
        Form28.Hide()
        Form27.Hide()
        form30.show()
    End Sub

    Private Sub Form29_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class