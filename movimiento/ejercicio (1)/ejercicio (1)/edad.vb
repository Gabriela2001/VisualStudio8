﻿Public Class edad
    Dim edad As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        edad = TextBox1.Text
        If edad >= 18 Then
            Label2.Text = "MAYOR DE EDAD"
        Else
            Label2.Text = "MENOR DE EDAD"
        End If
    End Sub
End Class