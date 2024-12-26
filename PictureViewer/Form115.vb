Public Class Form115

    Private Sub Panel4_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs)

    End Sub

    Private Sub Form115_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label26.Location
        startingPoint.Offset(10, 10)
        Cursor.Position = PointToScreen(startingPoint)

        

    End Sub

    Private Sub Label4_MouseEnter(sender As System.Object, e As System.EventArgs) Handles MyBase.MouseEnter, Label5.MouseEnter, Label4.MouseEnter, Label3.MouseEnter, Label2.MouseEnter, Label1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub LineShape1_MouseEnter(sender As System.Object, e As System.EventArgs) Handles LineShape99.MouseEnter, LineShape98.MouseEnter, LineShape97.MouseEnter, LineShape96.MouseEnter, LineShape95.MouseEnter, LineShape94.MouseEnter, LineShape93.MouseEnter, LineShape92.MouseEnter, LineShape91.MouseEnter, LineShape90.MouseEnter, LineShape9.MouseEnter, LineShape89.MouseEnter, LineShape88.MouseEnter, LineShape87.MouseEnter, LineShape86.MouseEnter, LineShape85.MouseEnter, LineShape84.MouseEnter, LineShape83.MouseEnter, LineShape82.MouseEnter, LineShape81.MouseEnter, LineShape80.MouseEnter, LineShape8.MouseEnter, LineShape79.MouseEnter, LineShape78.MouseEnter, LineShape77.MouseEnter, LineShape76.MouseEnter, LineShape75.MouseEnter, LineShape74.MouseEnter, LineShape73.MouseEnter, LineShape72.MouseEnter, LineShape71.MouseEnter, LineShape70.MouseEnter, LineShape7.MouseEnter, LineShape69.MouseEnter, LineShape68.MouseEnter, LineShape67.MouseEnter, LineShape66.MouseEnter, LineShape65.MouseEnter, LineShape64.MouseEnter, LineShape63.MouseEnter, LineShape62.MouseEnter, LineShape61.MouseEnter, LineShape60.MouseEnter, LineShape6.MouseEnter, LineShape59.MouseEnter, LineShape58.MouseEnter, LineShape57.MouseEnter, LineShape56.MouseEnter, LineShape55.MouseEnter, LineShape54.MouseEnter, LineShape53.MouseEnter, LineShape52.MouseEnter, LineShape51.MouseEnter, LineShape50.MouseEnter, LineShape5.MouseEnter, LineShape49.MouseEnter, LineShape48.MouseEnter, LineShape47.MouseEnter, LineShape46.MouseEnter, LineShape45.MouseEnter, LineShape44.MouseEnter, LineShape43.MouseEnter, LineShape42.MouseEnter, LineShape41.MouseEnter, LineShape40.MouseEnter, LineShape4.MouseEnter, LineShape39.MouseEnter, LineShape38.MouseEnter, LineShape37.MouseEnter, LineShape36.MouseEnter, LineShape35.MouseEnter, LineShape34.MouseEnter, LineShape338.MouseEnter, LineShape337.MouseEnter, LineShape336.MouseEnter, LineShape335.MouseEnter, LineShape334.MouseEnter, LineShape333.MouseEnter, LineShape332.MouseEnter, LineShape331.MouseEnter, LineShape330.MouseEnter, LineShape33.MouseEnter, LineShape329.MouseEnter, LineShape328.MouseEnter, LineShape327.MouseEnter, LineShape326.MouseEnter, LineShape325.MouseEnter, LineShape324.MouseEnter, LineShape323.MouseEnter, LineShape322.MouseEnter, LineShape321.MouseEnter, LineShape320.MouseEnter, LineShape32.MouseEnter, LineShape319.MouseEnter, LineShape318.MouseEnter, LineShape317.MouseEnter, LineShape316.MouseEnter, LineShape315.MouseEnter, LineShape314.MouseEnter, LineShape313.MouseEnter, LineShape312.MouseEnter, LineShape311.MouseEnter, LineShape310.MouseEnter, LineShape31.MouseEnter, LineShape30.MouseEnter, LineShape3.MouseEnter, LineShape29.MouseEnter, LineShape28.MouseEnter, LineShape27.MouseEnter, LineShape26.MouseEnter, LineShape25.MouseEnter, LineShape24.MouseEnter, LineShape23.MouseEnter, LineShape22.MouseEnter, LineShape21.MouseEnter, LineShape20.MouseEnter, LineShape2.MouseEnter, LineShape19.MouseEnter, LineShape18.MouseEnter, LineShape17.MouseEnter, LineShape16.MouseEnter, LineShape15.MouseEnter, LineShape140.MouseEnter, LineShape14.MouseEnter, LineShape139.MouseEnter, LineShape138.MouseEnter, LineShape137.MouseEnter, LineShape136.MouseEnter, LineShape135.MouseEnter, LineShape134.MouseEnter, LineShape133.MouseEnter, LineShape132.MouseEnter, LineShape131.MouseEnter, LineShape130.MouseEnter, LineShape13.MouseEnter, LineShape129.MouseEnter, LineShape128.MouseEnter, LineShape127.MouseEnter, LineShape126.MouseEnter, LineShape125.MouseEnter, LineShape124.MouseEnter, LineShape123.MouseEnter, LineShape122.MouseEnter, LineShape121.MouseEnter, LineShape120.MouseEnter, LineShape12.MouseEnter, LineShape119.MouseEnter, LineShape118.MouseEnter, LineShape117.MouseEnter, LineShape116.MouseEnter, LineShape115.MouseEnter, LineShape114.MouseEnter, LineShape113.MouseEnter, LineShape112.MouseEnter, LineShape111.MouseEnter, LineShape110.MouseEnter, LineShape11.MouseEnter, LineShape109.MouseEnter, LineShape108.MouseEnter, LineShape107.MouseEnter, LineShape106.MouseEnter, LineShape105.MouseEnter, LineShape104.MouseEnter, LineShape103.MouseEnter, LineShape102.MouseEnter, LineShape101.MouseEnter, LineShape100.MouseEnter, LineShape10.MouseEnter, LineShape1.MouseEnter
        MoveToStart()
    End Sub

    Private Sub PictureBox7_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox7_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox7.MouseEnter
        Label1.Hide()
        PictureBox7.Hide()
    End Sub

    Private Sub PictureBox6_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox6_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox6.MouseEnter
        LineShape43.Hide()
        PictureBox6.Hide()
    End Sub

    Private Sub PictureBox8_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox8.Click

    End Sub

    Private Sub PictureBox8_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox8.MouseEnter
        Label2.Hide()
        PictureBox8.Hide()
    End Sub

    Private Sub PictureBox5_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox5.Click

    End Sub

    Private Sub PictureBox5_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox5.MouseEnter
        LineShape1.Hide()
        PictureBox5.Hide()
    End Sub

    Private Sub Label7_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label7.MouseEnter
        MsgBox("Level cleared", MsgBoxStyle.Information)
        Form116.Show()
        Me.Hide()
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class