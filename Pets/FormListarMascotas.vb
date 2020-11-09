Public Class FormListarMascotas
    Private Sub Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            lbMascotas.Items.Clear()
            Dim logica = New LogicaMascota
            Dim mascotas As New List(Of Mascota)
            mascotas = logica.listarMascotas()

            For Each mascota As Mascota In mascotas
                lbMascotas.Items.Add(mascota.Nombre)
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class