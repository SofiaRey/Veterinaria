Public Class FormPet
    Private Sub FormPet_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnAceptPet_Click(sender As Object, e As EventArgs) Handles btnAceptPet.Click
        Try
            Dim ci As Integer
            ci = txtbxCIOwner.Text

            Dim nombre As String
            nombre = txtbxName.Text


            Dim anoNacimiento As String
            anoNacimiento = txtbxYearBirth.Text

            Dim logica = New LogicaMascota
            logica.AltaMascota(ci, nombre, anoNacimiento)
        Catch ex As Exception
            Throw ex
        End Try
    End Sub
End Class