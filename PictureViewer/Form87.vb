Public Class Form87

    Private Sub PictureBox111_MouseEnter(sender As System.Object, e As System.EventArgs) Handles PictureBox99.MouseEnter, PictureBox98.MouseEnter, PictureBox97.MouseEnter, PictureBox96.MouseEnter, PictureBox95.MouseEnter, PictureBox94.MouseEnter, PictureBox93.MouseEnter, PictureBox92.MouseEnter, PictureBox91.MouseEnter, PictureBox90.MouseEnter, PictureBox9.MouseEnter, PictureBox89.MouseEnter, PictureBox88.MouseEnter, PictureBox87.MouseEnter, PictureBox86.MouseEnter, PictureBox85.MouseEnter, PictureBox84.MouseEnter, PictureBox83.MouseEnter, PictureBox82.MouseEnter, PictureBox81.MouseEnter, PictureBox80.MouseEnter, PictureBox8.MouseEnter, PictureBox79.MouseEnter, PictureBox78.MouseEnter, PictureBox77.MouseEnter, PictureBox76.MouseEnter, PictureBox75.MouseEnter, PictureBox74.MouseEnter, PictureBox73.MouseEnter, PictureBox72.MouseEnter, PictureBox71.MouseEnter, PictureBox70.MouseEnter, PictureBox7.MouseEnter, PictureBox69.MouseEnter, PictureBox68.MouseEnter, PictureBox67.MouseEnter, PictureBox66.MouseEnter, PictureBox65.MouseEnter, PictureBox64.MouseEnter, PictureBox63.MouseEnter, PictureBox62.MouseEnter, PictureBox61.MouseEnter, PictureBox60.MouseEnter, PictureBox6.MouseEnter, PictureBox59.MouseEnter, PictureBox58.MouseEnter, PictureBox57.MouseEnter, PictureBox56.MouseEnter, PictureBox55.MouseEnter, PictureBox54.MouseEnter, PictureBox53.MouseEnter, PictureBox52.MouseEnter, PictureBox51.MouseEnter, PictureBox50.MouseEnter, PictureBox5.MouseEnter, PictureBox49.MouseEnter, PictureBox48.MouseEnter, PictureBox47.MouseEnter, PictureBox46.MouseEnter, PictureBox45.MouseEnter, PictureBox44.MouseEnter, PictureBox43.MouseEnter, PictureBox42.MouseEnter, PictureBox41.MouseEnter, PictureBox40.MouseEnter, PictureBox4.MouseEnter, PictureBox39.MouseEnter, PictureBox38.MouseEnter, PictureBox37.MouseEnter, PictureBox36.MouseEnter, PictureBox35.MouseEnter, PictureBox34.MouseEnter, PictureBox33.MouseEnter, PictureBox32.MouseEnter, PictureBox31.MouseEnter, PictureBox30.MouseEnter, PictureBox3.MouseEnter, PictureBox29.MouseEnter, PictureBox28.MouseEnter, PictureBox27.MouseEnter, PictureBox26.MouseEnter, PictureBox25.MouseEnter, PictureBox24.MouseEnter, PictureBox23.MouseEnter, PictureBox22.MouseEnter, PictureBox21.MouseEnter, PictureBox20.MouseEnter, PictureBox2.MouseEnter, PictureBox19.MouseEnter, PictureBox18.MouseEnter, PictureBox17.MouseEnter, PictureBox16.MouseEnter, PictureBox15.MouseEnter, PictureBox14.MouseEnter, PictureBox13.MouseEnter, PictureBox12.MouseEnter, PictureBox112.MouseEnter, PictureBox111.MouseEnter, PictureBox110.MouseEnter, PictureBox11.MouseEnter, PictureBox109.MouseEnter, PictureBox108.MouseEnter, PictureBox107.MouseEnter, PictureBox106.MouseEnter, PictureBox105.MouseEnter, PictureBox104.MouseEnter, PictureBox103.MouseEnter, PictureBox102.MouseEnter, PictureBox101.MouseEnter, PictureBox100.MouseEnter, PictureBox10.MouseEnter, PictureBox1.MouseEnter
        Timer1.Start()
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Height += 10
    End Sub

    Private Sub Label4_MouseEnter(sender As Object, e As System.EventArgs) Handles Label4.MouseEnter
        Label4.Height = 0
        Timer1.Stop()
        MoveToStart()
    End Sub

    Private Sub Form87_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Button1.Enabled = False
        Timer2.Start()
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer2.Stop()
            PictureBox41.Hide()
        End If
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter

        Dim startingPoint = Label5.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MsgBox("Level cleared!", MsgBoxStyle.Information)
        form88.show()
        Me.Close()
    End Sub
End Class