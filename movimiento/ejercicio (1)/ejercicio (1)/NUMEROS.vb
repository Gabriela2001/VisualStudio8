Public Class NUMEROS
    Dim num As Double
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        num = TextBox1.Text
        If num < 0 Then
            Label2.Text = "Negativo"
        Else
            Label2.Text = "Positivo"
        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class