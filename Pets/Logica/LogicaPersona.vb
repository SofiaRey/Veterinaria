Public Class LogicaPersona
    Public Sub altaPersona(personaUser As Persona)
        Dim persistencia As New PersistenciaPersona
        persistencia.altaPersona(personaUser)
    End Sub

    Public Sub altaTelefono(persona As Persona)
        Dim persistencia = New PersistenciaPersona
        persistencia.AltaTelefono(persona)
    End Sub

    Public Function buscarPersona(ci As Integer) As Persona
        Dim persistencia = New PersistenciaPersona

        Return persistencia.BuscarPersona(ci)
    End Function
End Class
