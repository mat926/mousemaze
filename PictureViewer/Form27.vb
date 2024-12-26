Public Class Form27

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Timer1.Start()
        Button1.Enabled = False

    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Button1.Text -= 1
        If Button1.Text = 0 Then
            Timer1.Stop()
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Label2.Height = Label2.Height - 2
        If Label2.Height = 0 Then
            Timer2.Stop()
        End If
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)
        Timer3.Start()

    End Sub

    Private Sub Timer3_Tick(sender As System.Object, e As System.EventArgs) Handles Timer3.Tick
        Label2.Height = Label2.Height + 2
        If Label2.Height = 232 Then
            Timer2.Stop()
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub
    Private Sub Form27_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


        Form28.Show()
        Form29.Show()
        MoveToStart()
    End Sub

    Private Sub Label3_Click(sender As System.Object, e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label3_MouseEnter(sender As Object, e As System.EventArgs) Handles Label3.MouseEnter


        Dim startingPoint = Form28.Label3.Location
        startingPoint.Offset(550, -255)
        Cursor.Position = PointToScreen(startingPoint)

    End Sub

    Private Sub Form27_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As System.EventArgs) Handles Label2.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form27_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub
End Class