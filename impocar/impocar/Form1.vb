Public Class Form1
    Dim cliente As String
    Dim modelo As String
    Dim marca As String
    Dim anio As Integer
    Dim precio As Double
    Dim fechaCompra As String
    Dim tipoPago As String

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Clientes.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Module1.CAuto = Codigoautos.Text
        Module1.Ncliente = Clientes.Text
        Module1.Marca = Marcas.Text
        Module1.Formapago = Tipopagos.Text
        Module1.FechaVenta = Fechas.Text
        Module1.NVendedor = Vendedores.Text
        Module1.Modelo = Modelos.Text
        Module1.Total = Totales.Text
        Module1.Precio = Precios.Text
        Form2.Show()
        Me.Hide()

    End Sub
End Class
