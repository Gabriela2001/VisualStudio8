Public Class Form1
    Private Sub JugadoresBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles JugadoresBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.JugadoresBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FutbolDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FutbolDataSet.Jugadores' Puede moverla o quitarla según sea necesario.
        Me.JugadoresTableAdapter.Fill(Me.FutbolDataSet.Jugadores)

    End Sub
End Class
