Public Class FormListarPersonas
    Private Sub btnListar_Click(sender As Object, e As EventArgs) Handles btnListar.Click
        Try
            lbPersonas.Items.Clear()
            Dim logica = New LogicaPersona
            Dim personas As List(Of Persona)

            personas = logica.listarPersonas()

            For Each persona As Persona In personas
                lbPersonas.Items.Add(persona.Nombre)
            Next
        Catch ex As Exception
        End Try
    End Sub
End Class