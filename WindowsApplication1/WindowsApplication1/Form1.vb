Public Class Form1
    Dim puntos As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        puntos = TextBox1.Text

        If puntos <= 100 Then
            Label5.Text = "Felicidades.Has ganado 1 salario en recompensa por tu buen desempeño."
        ElseIf puntos <= 150 Then
            Label5.Text = "Felicidades! Has ganado 2 salario en recompensa por tu buen desempeno."
        Else
            Label5.Text = "Felicidades! Has ganado 3 salario en recompensa por tu buen desempeno."
        End If
    End Sub
End Class
