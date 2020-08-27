Public Class FormBuscarPersona
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub btnAceptTelephone_Click(sender As Object, e As EventArgs) Handles btnAceptTelephone.Click
        Dim ci As Integer
        ci = txtbxCI.Text

        Dim logica = New LogicaPersona

        Dim persona As Persona
        persona = logica.BuscarPersona(ci)

        txtbxNameToComplete.Text = persona.Nombre
        txtbxAddressToComplete.Text = persona.Direccion
    End Sub

    Private Sub btnModificar_Click(sender As Object, e As EventArgs) Handles btnModificar.Click
        Dim ci As Integer
        ci = txtbxCI.Text

        Dim name As String
        name = txtbxNameToComplete.Text

        Dim address As String
        address = txtbxAddressToComplete.Text

        Dim logica = New LogicaPersona

        Dim persona As Persona
        persona = logica.modificarPersona(ci, name, address)
    End Sub

    Private Sub Label3_Click_1(sender As Object, e As EventArgs) Handles lbltelephones.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblNameToComplete_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtbxPhone_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAddPhone_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lvPhonesList_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub
End Class