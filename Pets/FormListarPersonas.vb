Public Class FormListarPersonas
    Private Sub FormListarPersonas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub lbPersonas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbPersonas.SelectedIndexChanged

    End Sub
End Class