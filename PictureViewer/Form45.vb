Public Class Form45
    Private Declare Function mciSendString Lib "winmm.dll" Alias "mciSendStringA" (ByVal Command As String, ByVal ReturnString As String, ByVal ReturnLength As Long, ByVal hWnd As Long) As Long
    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Try
            PictureBox1.Hide()
            Label3.Show()
            mciSendString("set cdaudio door open", 0, 0, 0)
            mciSendString("set cdaudio door closed", 0, 0, 0)
        Catch ex As Exception
            PictureBox1.Hide()
        End Try

    End Sub

    Private Sub Form45_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        MoveToStart()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Me.Hide()
        form46.show()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        Label7.Hide()
        Label3.Hide()
        Me.BackColor = Color.LightGray
        PictureBox1.Show()
    End Sub
    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        Me.BackColor = Color.RoyalBlue
        Label7.Show()
    End Sub

    Private Sub Label9_Click(sender As System.Object, e As System.EventArgs) Handles Label9.Click

    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter, Label8.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form45_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form45_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class