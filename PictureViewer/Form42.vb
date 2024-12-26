Public Class Form42

    Private Sub Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
    Private Sub MoveToStart()

        Dim startingPoint = Label1.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
        My.Computer.Audio.Stop()
        PictureBox1.Show()
        Label2.Show()
        Timer1.Stop()
        Label3.Text = 0
        Timer2.Stop()
        Me.Height = 344
        Me.Width = 546
        Panel1.Height = 293
        Panel1.Width = 512
        Me.BackColor = Color.LightGray
        Label1.Show()
    End Sub
    Private Sub PictureBox1_MouseEnter(sender As Object, e As System.EventArgs) Handles PictureBox1.MouseEnter
        Label1.Hide()
        Label2.Hide()
        PictureBox1.Hide()
        Timer1.Start()
        My.Computer.Audio.Play(My.Resources.I_Go_U_Go, AudioPlayMode.Background)
    End Sub

    Private Sub Timer1_Tick(sender As System.Object, e As System.EventArgs) Handles Timer1.Tick
        Label3.Text += 1
       
    End Sub

    Private Sub Form42_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        MoveToStart()
    End Sub

    Private Sub Form42_MouseEnter(sender As Object, e As System.EventArgs) Handles Me.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label3_TextChanged(sender As Object, e As System.EventArgs) Handles Label3.TextChanged
        If Label3.Text = 90 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 92 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 98 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 108 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 110 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 116 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 126 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 128 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 133 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 137 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 141 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 143 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 145 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 151 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 162 Then
            Me.BackColor = Color.Black

        End If
        If Label3.Text = 164 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 169 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 178 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 180 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 185 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 196 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 198 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 204 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 208 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 213 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 215 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 217 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 221 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 232 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 236 Then
            Me.BackColor = Color.White
            timer2.start()
        End If
        If Label3.Text = 241 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 245 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 250 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 255 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 260 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 265 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 270 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 275 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 280 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 285 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 300 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 302 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 304 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 306 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 308 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 310 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 312 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 314 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 316 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 318 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 320 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 322 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 324 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 326 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 328 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 330 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 332 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 334 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 336 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 338 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 340 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 342 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 344 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 346 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 348 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 350 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 352 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 354 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 356 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 358 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 360 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 362 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 364 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 366 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 368 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 370 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 372 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 374 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 376 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 378 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 380 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 382 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 384 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 386 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 388 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 390 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 392 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 394 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 396 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 398 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 400 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 402 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 404 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 406 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 408 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 410 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 412 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 414 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 416 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 418 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 420 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 422 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 424 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 426 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 428 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 430 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 432 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 434 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 436 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 438 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 440 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 442 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 444 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 446 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 448 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 450 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 452 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 454 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 456 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 458 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 460 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 461 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 462 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 463 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 464 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 465 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 466 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 467 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 468 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 469 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 470 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 471 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 472 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 473 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 474 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 475 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 476 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 477 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 478 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 479 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 480 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 481 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 482 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 483 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 484 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 485 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 486 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 487 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 488 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 489 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 490 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 491 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 492 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 493 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 494 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 495 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 496 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 497 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 498 Then
            Me.BackColor = Color.Black
        End If
        If Label3.Text = 499 Then
            Me.BackColor = Color.White
        End If
        If Label3.Text = 500 Then
            Me.BackColor = Color.Black
        End If

    End Sub

    Private Sub Timer2_Tick(sender As System.Object, e As System.EventArgs) Handles Timer2.Tick
        Me.Height = Me.Height + 1
        Me.Width = Me.Width + 1
        Panel1.Height = Panel1.Height + 1
        Panel1.Width = Panel1.Width + 1
    End Sub

    Private Sub Form42_Move(sender As Object, e As System.EventArgs) Handles Me.Move
        MsgBox("This window is not meant to be moved!", MsgBoxStyle.Critical)
        MoveToStart()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As System.EventArgs) Handles Label6.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As System.EventArgs) Handles Label7.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As System.EventArgs) Handles Label8.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label9_MouseEnter(sender As Object, e As System.EventArgs) Handles Label9.MouseEnter
        Timer1.Stop()
        Timer2.Stop()
        MsgBox("Level cleared", MsgBoxStyle.Information)
        My.Computer.Audio.Stop()
        Me.Hide()
        form43.show()

    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As System.EventArgs) Handles Label10.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label11_MouseEnter(sender As Object, e As System.EventArgs) Handles Label11.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label12_MouseEnter(sender As Object, e As System.EventArgs) Handles Label12.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label13_MouseEnter(sender As Object, e As System.EventArgs) Handles Label13.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label14_MouseEnter(sender As Object, e As System.EventArgs) Handles Label14.MouseEnter
        Dim startingPoint = Label17.Location
        startingPoint.Offset(20, 20)
        Cursor.Position = PointToScreen(startingPoint)
    End Sub

    Private Sub Label15_MouseEnter(sender As Object, e As System.EventArgs) Handles Label15.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label16_MouseEnter(sender As Object, e As System.EventArgs) Handles Label16.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As System.EventArgs) Handles Label18.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label19_MouseEnter(sender As Object, e As System.EventArgs) Handles Label19.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As System.EventArgs) Handles Label20.MouseEnter
        MoveToStart()
    End Sub

    Private Sub Form42_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Form21.Show()
        End If
    End Sub

    Private Sub Label21_Click(sender As System.Object, e As System.EventArgs) Handles Label21.Click

    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As System.EventArgs) Handles Label21.MouseEnter
        Form43.Show()
        Me.Close()
    End Sub
End Class