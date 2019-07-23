Public Class Form1
    Dim Q As Double
    Dim pesos As Double
    Dim libra As Double
    Dim yen As Double
    Dim dolar As Double
    Dim rublo As Double
    Dim bolivar As Double
    Dim bit As Double


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        'Obtener el valor en querzales'
        Q = textBox8.Text
        'convierte a pesos mexicanos'
        pesos = Q * 2.52
        textBox1.Text = pesos
        'convierte a libra esterlina'
        libra = Q * 0.1
        textBox2.Text = libra
        'convierte a yen'
        yen = Q * 14.85
        textBox3.Text = yen
        'convierte a dolar estadounidense'
        dolar = Q * 0.13
        textBox4.Text = dolar
        'convierte a rublo ruso'
        rublo = Q * 8.95
        textBox5.Text = rublo
        'convierte a bolivar venezolano'
        bolivar = Q * 33168.72
        textBox6.Text = bolivar
        'convierte a bit coin'
        bit = Q * 0.00002
        textBox7.Text = bit

    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click

    End Sub
End Class
