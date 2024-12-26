Public Class gamesettings

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form21.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
     
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
       
    End Sub

    Private Sub Form70_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Public Sub CheckForUpdates()

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://dl.dropbox.com/u/76348047/mmversion.txt")

        Dim response As System.Net.HttpWebResponse = request.GetResponse()
        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())
        Dim newestversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        If newestversion.Contains(currentversion) Then
            MsgBox(" You have the latest version :D", MsgBoxStyle.Information)
        Else
            updater.Show()
        End If
        Me.Cursor = Cursors.Default


    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Try
            System.Diagnostics.Process.Start("http://www.myyearbook.com/members/40675140")
        Catch
            MsgBox("There was a problem opening the site", MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub Button6_Click_1(sender As System.Object, e As System.EventArgs) Handles Button6.Click
        Try
            Me.Cursor = Cursors.WaitCursor
            CheckForUpdates()
        Catch ex As Exception
            MsgBox("Oops, there was a problem while I was checking. Check your internet connection and try again", MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button5_Click_1(sender As System.Object, e As System.EventArgs) Handles Button5.Click
        If MsgBox("WARNING! If you reset data, ALL your current games will be lost. The next time Mouse Maze starts, it will act just like it started for the first time. Are you REALLY sure you wanted to reset data?", MsgBoxStyle.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            My.Settings.level = "1"
            My.Settings.name = Nothing
            My.Settings.levelsaved = False
            My.Settings.levelsaved2 = False
            My.Settings.levelsaved3 = False
            My.Settings.Firstimeplaying = True
            My.Settings.Save()
            MsgBox("Your settings have been reset, the game will now restart.")
            Application.Restart()
        Else

        End If

    End Sub

    Private Sub Button4_Click_1(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Form71.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Form73.Show()
        Me.Close()
    End Sub

    Private Sub Label4_Click(sender As System.Object, e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub LinkLabel1_LinkClicked_1(sender As System.Object, e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        Form73.Show()
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)
        Try
            Me.Cursor = Cursors.WaitCursor
            CheckForUpdates()
        Catch ex As Exception
            MsgBox("Oops, there was a problem while I was checking. Check your internet connection and try again", MsgBoxStyle.Critical)
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        Try
            Process.Start("main.cpl")
        Catch ex As Exception
            MsgBox("There was a problem opening the mouse settings. You can try opening the settings manually by going into the Control Panel and clicking on Mouse.", MsgBoxStyle.Critical)
        End Try

    End Sub
End Class