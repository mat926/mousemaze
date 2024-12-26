Public Class Form69

    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Panel1.Left += 1 = TrackBar1.Value
    End Sub

    Private Sub Form69_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class