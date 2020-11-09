Public Class FormBuscarMascota
    Private Sub btnSearchPet_Click(sender As Object, e As EventArgs) Handles btnSearchPet.Click
        Dim logica = New LogicaMascota
        Dim mascota As New Mascota
        mascota = logica.BuscarMascota(txtbxID.Text)

        txtbxNombre.Text = mascota.Nombre
        txtbxAnoNac.Text = mascota.AnoNac
        lblDataCedula.Text = mascota.Dueno
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim logica = New LogicaMascota

        logica.ModificarMascota(txtbxID.Text, txtbxNombre.Text, txtbxAnoNac.Text)
    End Sub

    Private Sub btnDeletePet_Click(sender As Object, e As EventArgs) Handles btnDeletePet.Click
        Dim logica = New LogicaMascota
        logica.EliminarMascota(txtbxID.Text)

        txtbxID.Clear()
        txtbxNombre.Clear()
        txtbxAnoNac.Clear()
        lblDataCedula.Text = "-"
    End Sub
End Class