Public Class Form36

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Form36_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Timer1.Start()
        Cursor.Hide()
        My.Computer.Audio.Play(My.Resources.Scary_mp3, AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label1.Text -= 1
        If Label1.Text = 0 Then
            Timer1.Stop()
            Form37.Show()

            Me.Hide()
            Cursor.Show()
        End If
    End Sub
End Class