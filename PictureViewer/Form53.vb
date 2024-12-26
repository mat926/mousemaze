Public Class Form53

    Private Sub Form53_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Settings.level = 3
        My.Settings.Save()

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
       

            Me.Hide()
            Form21.Show()

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class