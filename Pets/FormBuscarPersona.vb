Public Class FormBuscarPersona
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub btnAceptTelephone_Click(sender As Object, e As EventArgs) Handles btnAceptTelephone.Click
        Dim ci As Integer
        ci = txtbxCI.Text

        Dim logica = New LogicaPersona

        Dim persona As Persona
        persona = logica.BuscarPersona(ci)

        lblNameToComplete.Text = persona.Nombre
        lblAddressToComplete.Text = persona.Direccion
    End Sub
End Class