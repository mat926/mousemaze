Public Class Form66

    Private Sub ProgressBar1_Click(sender As System.Object, e As System.EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub ProgressBar1_MouseEnter(sender As Object, e As System.EventArgs) Handles ProgressBar1.MouseEnter
        ProgressBar1.Increment(0.6)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            timer1.start()
        End If
    End Sub

   

    Private Sub ProgressBar1_MouseMove(sender As System.Object, e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar1.MouseMove
        ProgressBar1.Increment(0.6)
        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Start()
        End If
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label4.Width -= 1
    End Sub

    Private Sub ProgressBar2_MouseEnter(sender As Object, e As System.EventArgs) Handles ProgressBar2.MouseEnter

    End Sub

    Private Sub ProgressBar2_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar2.MouseMove
        ProgressBar2.Increment(0.6)
        If ProgressBar2.Value = ProgressBar2.Maximum Then
            Label8.Show()
        End If
    End Sub

    Private Sub Form66_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ProgressBar3_MouseEnter(sender As Object, e As System.EventArgs) Handles ProgressBar3.MouseEnter
       
    End Sub

    Private Sub ProgressBar3_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles ProgressBar3.MouseMove
        ProgressBar3.Increment(0.6)
        If ProgressBar3.Value = 100% Then
            ProgressBar4.Increment(0.6)
            If ProgressBar4.Value = 100% Then
                ProgressBar5.Increment(0.6)
                If ProgressBar5.Value = 100% Then
                    ProgressBar6.Increment(0.6)
                    If ProgressBar6.Value = 100% Then
                        ProgressBar7.Increment(0.6)
                        If ProgressBar7.Value = 100% Then
                            ProgressBar8.Increment(0.6)
                            If ProgressBar8.Value = 100% Then
                                ProgressBar9.Increment(0.6)
                                If ProgressBar9.Value = 100% Then
                                    ProgressBar10.Increment(0.6)
                                    If ProgressBar10.Value Then
                                        Label2.Show()
                                    End If
                                End If
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label2_Click(sender As System.Object, e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label2_MouseHover(sender As Object, e As System.EventArgs) Handles Label2.MouseHover
        MsgBox("Level cleared. Good work!", MsgBoxStyle.Information)
        Form68.Show()
        Me.Close()
    End Sub
End Class