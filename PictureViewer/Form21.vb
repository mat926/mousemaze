
Public Class Form21

    Private Sub Form21_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Main Menu - " & My.Settings.name
            My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)



        If My.Settings.level = 2 Then
            Button5.Show()
        Else
            Button5.Hide()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If My.Settings.Firstimeplaying = True Then
            myname.Show()
            Me.Hide()
        Else
            If MsgBox("IMPORTANT!!" & vbNewLine & _
                   "MouseMaze is designed to run on computers with a screen resolution of AT LEAST 1280 by 1024. Your computer's current resolution is " & My.Computer.Screen.Bounds.Size.ToString & "If this does not meet the 1280 x 1024 requirement, then it is HIGHLY RECOMMENDED that you change your screen resolution. You can still play Mouse Maze , but if you don't have the required resolution, then some levels can display incorrectly and you may be unable to finish a level." & vbNewLine &
                   "" & vbNewLine & _
                   "Click YES if you want to continue anyway" & vbNewLine & _
                   "Click NO if you want to go back and change your screen resolution. You can obtain intructions on how to change it by going into the game's Settings and then click Screen Resolution", MsgBoxStyle.YesNo, MessageBoxIcon.Exclamation) = MsgBoxResult.Yes Then
                Form1.Show()
                Me.Hide()
            Else

            End If
            If My.Settings.level = 3 Then
                MsgBox("You already have a saved game in the Extented Levels, you cannot play on Normal levels again. If you want to start out fresh on MouseMaze, you can reset your game data in the Settings.", MsgBoxStyle.Critical, "Saved game already exists")

                Application.Restart()
            End If

  
            End If




    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            My.Computer.Audio.Play(My.Resources.title__2_, AudioPlayMode.BackgroundLoop)


        Else
            My.Computer.Audio.Stop()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If My.Settings.level = "f" = False Then
            MsgBox("You will need to complete ALL levels in order to have access to this feature", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        gamesettings.Show()

        Me.Hide()

    End Sub



    Private Sub Form21_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseUp

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form33.Label2.Show()
        Me.Hide()
        Form33.Show()
    End Sub

    Private Sub Button1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub



    Private Sub Button1_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        If My.Settings.level = "3" = True Then
            MsgBox("You will need to complete ALL the normal levels AND the extended levels in order to have access to this feature", MsgBoxStyle.Critical)

        End If
        If My.Settings.level < 3 Then
            MsgBox("You will need to complete ALL the normal levels AND the extended levels in order to have access to this feature", MsgBoxStyle.Critical)

        End If
        If My.Settings.level = 4 Then
            Form54.Show()
            Me.Hide()
        End If
    End Sub





    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If My.Settings.level = "3" = False Then
            MsgBox("You will need to complete ALL the normal levels in order to have access to this feature", MsgBoxStyle.Critical)
        Else
            Form55.Show()
            Me.Hide()
        End If
       
        If My.Settings.levelsaved = True And My.Settings.level = "3" Then
            Form55.Hide()
            MsgBox("Mouse Maze has detected you have a saved game in progress. You will now continue off from that point.", MsgBoxStyle.Information)
            Me.Hide()
            Form100.Show()


        End If


        If My.Settings.levelsaved2 = True And My.Settings.level = "3" Then
            Form55.Hide()
            MsgBox("Mouse Maze has detected you have a saved game in progress. You will now continue off from that point.", MsgBoxStyle.Information)
            Me.Hide()
            Form104.Show()


        End If

        If My.Settings.levelsaved3 = True And My.Settings.level = "3" Then
            Form55.Hide()
            MsgBox("Mouse Maze has detected you have a saved game in progress. You will now continue off from that point.", MsgBoxStyle.Information)
            Me.Hide()
            worldselection.Show()


        End If

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        Form42.Show()
        Me.Hide()
    End Sub
End Class