Public Class myname

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("You must enter in your name", MsgBoxStyle.Critical)
        Else
            If MsgBox("Your name is: " & TextBox1.Text & " is this correct? Please note that you cannot change your name later", MsgBoxStyle.YesNo, "Welcome") = MsgBoxResult.Yes Then
                MsgBox("Welcome to MouseMaze " & TextBox1.Text & "! The game will now restart.")
                My.Settings.name = TextBox1.Text
                My.Settings.Firstimeplaying = False
                My.Settings.Save()
                Application.Restart()
            Else
                MsgBox("Please go back and change your name then.", MsgBoxStyle.Exclamation)

            End If

        End If
    End Sub

    Private Sub myname_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

        If My.Settings.Firstimeplaying = True Then
            Me.Show()
        Else
            Me.Hide()
            Form21.Show()
        End If
    End Sub
End Class