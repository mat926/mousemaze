Imports System.Net.Mail
Public Class Form73

    Private Sub Form73_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = Nothing Then
            MsgBox("You need to enter in a feedback", MsgBoxStyle.Critical)
        Else
            Try

                Dim smtpServer As New SmtpClient()
                Dim mail As New MailMessage()
                smtpServer.Credentials = New Net.NetworkCredential("matteochirco", "matteo")
                smtpServer.Port = 587
                smtpServer.Host = "smtp.gmail.com"
                smtpServer.EnableSsl = True
                mail = New MailMessage()
                mail.From = New MailAddress("matteochirco@gmail.com")
                mail.To.Add("matteochirco@gmail.com")
                mail.Subject = "Mouse Maze Feedback"
                mail.Body = TextBox1.Text
                smtpServer.Send(mail)
                MsgBox("Your feedback has been sent!", MsgBoxStyle.Information)
            Catch ex As Exception
                MsgBox("There was a problem, check your internet connection", MsgBoxStyle.Critical)
            End Try
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
        gamesettings.Show()
    End Sub
End Class