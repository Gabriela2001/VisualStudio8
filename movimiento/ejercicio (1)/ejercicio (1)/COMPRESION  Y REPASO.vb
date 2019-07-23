Public Class COMPRESION__Y_REPASO

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If PictureBox1.Top >= 276 Then
            PictureBox1.Left = PictureBox1.Left + 10
        Else
            PictureBox1.Top = PictureBox1.Top + 10
        End If

        If PictureBox1.Left >= 366 Then
            Timer1.Enabled = False
            Timer2.Enabled = True
        End If


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        If PictureBox1.Top >= 12 Then
            PictureBox1.Top = PictureBox1.Top - 10
        Else
            PictureBox1.Left = PictureBox1.Left - 10
        End If

        If PictureBox1.Left <= 12 Then
            Timer2.Enabled = False
        End If
    End Sub
End Class