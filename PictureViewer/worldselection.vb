Public Class worldselection

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub worldselection_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
        If My.Settings.levelsaved3 = True Then
            Button1.Enabled = False
            Button1.Text = "Saved"
        End If
    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub worldselection_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label20_Click(sender As System.Object, e As System.EventArgs) Handles Label20.Click

    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As System.EventArgs) Handles Label20.MouseEnter
        Dim startingPoint = Label23.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label22_Click(sender As System.Object, e As System.EventArgs) Handles Label22.Click

    End Sub

    Private Sub Label22_MouseEnter(sender As Object, e As System.EventArgs) Handles Label22.MouseEnter
        Dim startingPoint = Label21.Location
        startingPoint.Offset(0, 0)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label27_MouseEnter(sender As System.Object, e As System.EventArgs) Handles Label27.MouseEnter, Label26.MouseEnter, Label25.MouseEnter, Label24.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label12_Click(sender As System.Object, e As System.EventArgs) Handles Label12.Click

    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        If MsgBox("You are about to enter:  Face World. Do you really want to continue?", MsgBoxStyle.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            face1.Show()
            Me.Hide()
        Else
            MoveToStart()
        End If
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            My.Settings.levelsaved2 = False
            My.Settings.levelsaved3 = True
            My.Settings.Save()
            Button1.Enabled = False
            Button1.Text = "Saved"
        Catch ex As Exception
            MsgBox("There was a problem saving your game :(")
        End Try
    End Sub
End Class