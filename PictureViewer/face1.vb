Public Class face1

    Private Sub face1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources.Awesomesong, AudioPlayMode.BackgroundLoop)
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(15, 15)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub


    Private Sub PictureBox64_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox9.MouseEnter, PictureBox8.MouseEnter, PictureBox7.MouseEnter, PictureBox64.MouseEnter, PictureBox63.MouseEnter, PictureBox62.MouseEnter, PictureBox61.MouseEnter, PictureBox6.MouseEnter, PictureBox59.MouseEnter, PictureBox58.MouseEnter, PictureBox57.MouseEnter, PictureBox56.MouseEnter, PictureBox55.MouseEnter, PictureBox54.MouseEnter, PictureBox53.MouseEnter, PictureBox52.MouseEnter, PictureBox51.MouseEnter, PictureBox50.MouseEnter, PictureBox5.MouseEnter, PictureBox49.MouseEnter, PictureBox48.MouseEnter, PictureBox47.MouseEnter, PictureBox46.MouseEnter, PictureBox45.MouseEnter, PictureBox44.MouseEnter, PictureBox43.MouseEnter, PictureBox42.MouseEnter, PictureBox41.MouseEnter, PictureBox40.MouseEnter, PictureBox4.MouseEnter, PictureBox39.MouseEnter, PictureBox38.MouseEnter, PictureBox37.MouseEnter, PictureBox36.MouseEnter, PictureBox34.MouseEnter, PictureBox33.MouseEnter, PictureBox32.MouseEnter, PictureBox31.MouseEnter, PictureBox30.MouseEnter, PictureBox3.MouseEnter, PictureBox28.MouseEnter, PictureBox27.MouseEnter, PictureBox26.MouseEnter, PictureBox25.MouseEnter, PictureBox24.MouseEnter, PictureBox23.MouseEnter, PictureBox22.MouseEnter, PictureBox21.MouseEnter, PictureBox20.MouseEnter, PictureBox2.MouseEnter, PictureBox19.MouseEnter, PictureBox18.MouseEnter, PictureBox17.MouseEnter, PictureBox16.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, PictureBox12.MouseEnter, PictureBox11.MouseEnter, PictureBox10.MouseEnter, PictureBox1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox29_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox29.Click

    End Sub

    Private Sub PictureBox29_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox29.MouseEnter
        PictureBox21.Hide()
        PictureBox29.Hide()
    End Sub

    Private Sub PictureBox35_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox35.Click

    End Sub

    Private Sub PictureBox35_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox35.MouseEnter
        PictureBox17.Hide()
        PictureBox35.Hide()
    End Sub

    Private Sub PictureBox65_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox65.Click

    End Sub

    Private Sub PictureBox65_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox65.MouseEnter
        PictureBox61.Hide()
        PictureBox65.Hide()
    End Sub

    Private Sub PictureBox60_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox60.Click
        PictureBox36.Width -= 6
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level Cleared")
        face2.show()
        Me.Close()
    End Sub

    Private Sub face1_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub
End Class