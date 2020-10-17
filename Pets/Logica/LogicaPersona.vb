Public Class LogicaPersona
    Public Sub altaPersona(personaUser As Persona)
        Dim persistencia As New PersistenciaPersona
        persistencia.altaPersona(personaUser)
    End Sub

    Public Function buscarPersona(ci As Integer) As Persona
        Dim persistencia = New PersistenciaPersona

        Return persistencia.BuscarPersona(ci)
    End Function

    Public Sub modificarPersona(persona As Persona)
        Dim persistencia = New PersistenciaPersona
        persistencia.modificarPersona(persona)
    End Sub

    Public Function listarPersonas() As List(Of Persona)
        Dim persistencia = New PersistenciaPersona
        Dim personas As List(Of Persona) = persistencia.listarPersona
        Return personas
    End Function
End Class
