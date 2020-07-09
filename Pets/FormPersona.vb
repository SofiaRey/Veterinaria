Public Class FormPersona
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblPersonTitle.Click

    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs) Handles lblCI.Click

    End Sub

    Private Sub btnAceptPersona_Click(sender As Object, e As EventArgs) Handles btnAceptPersona.Click
        Try
            Dim ci As Integer
            ci = txtbxCI.Text

            Dim nombre As String
            nombre = txtbxName.Text

            Dim direccion As String
            direccion = txtbxAdd.Text

            Dim newPersona As New Persona()
            newPersona.Ci = ci
            newPersona.Nombre = nombre
            newPersona.Direccion = direccion

            Dim logica As LogicaPersona
            logica.altaPersona(newPersona)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class
