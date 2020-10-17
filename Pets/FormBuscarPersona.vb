Public Class FormBuscarPersona
    Dim ListaTelefonos As New List(Of Integer)
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles lblAddress.Click

    End Sub

    Private Sub btnSearchPerson_Click(sender As Object, e As EventArgs) Handles btnSearchPerson.Click
        Dim ci As Integer
        ci = txtbxCI.Text

        Dim logica = New LogicaPersona

        Dim persona As Persona
        persona = logica.buscarPersona(ci)

        ListaTelefonos = persona.Telefonos

        For Each telefono As Integer In ListaTelefonos
            lvPhonesList.Items.Add(telefono)
        Next

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

        Dim persona As New Persona
        persona.Ci = ci
        persona.Nombre = name
        persona.Direccion = address

        For Each telefono As ListViewItem In lvPhonesList.Items
            persona.Telefonos.Add(Convert.ToInt32(telefono.Text.ToString))
        Next

        logica.modificarPersona(persona)
    End Sub

    Private Sub lvPhonesList_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles lvPhonesList.SelectedIndexChanged
        Try
            Dim tel As String
            Dim telDel As Integer
            tel = lvPhonesList.SelectedItems(0).SubItems(0).Text
            telDel = Convert.ToInt32(tel)

            Dim i = 0
            While i < ListaTelefonos.Count
                If telDel = ListaTelefonos.Item(i) Then
                    ListaTelefonos.Remove(telDel)
                    i = ListaTelefonos.Count
                End If
                i = i + 1
            End While
            lvPhonesList.Clear()
            i = 0
            While i < ListaTelefonos.Count
                lvPhonesList.Items.Add(ListaTelefonos(i))
                i = i + 1
            End While
        Catch ex As Exception
            MsgBox("Tuviste un error: " + ex.Message)
        End Try
    End Sub

    Private Sub btnAddPhone_Click_1(sender As Object, e As EventArgs) Handles btnAddPhone.Click
        Dim telefono As Integer
        telefono = txtbxPhone.Text

        lvPhonesList.Items.Add(telefono)
        ListaTelefonos.Add(telefono)

        txtbxPhone.Text = ""
    End Sub
End Class