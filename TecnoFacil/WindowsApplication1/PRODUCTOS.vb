﻿Public Class PRODUCTOS
    Private Sub PRODUCTOS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'TECNOFACILDataSet1.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter1.Fill(Me.TECNOFACILDataSet1.Productos)
        'TODO: esta línea de código carga datos en la tabla 'TECNOFACILDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.TECNOFACILDataSet.Productos)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class