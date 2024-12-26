Public Class mouse4

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label3.Text += 1
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As System.EventArgs) Handles Label3.TextChanged
        If Label3.Text = 50 Then
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        PictureBox1.Left -= 1
        If PictureBox1.Location.X = 353 Then
            Timer2.Stop()
            timer3.start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        PictureBox1.Width += 1
        PictureBox1.Height += 1
    End Sub
End Class