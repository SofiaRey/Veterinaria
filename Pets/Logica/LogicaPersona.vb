Public Class LogicaPersona
    Public Sub altaPersona(personaUser As Persona)
        Dim persistencia As New PersistenciaPersona
        persistencia.altaPersona(personaUser)
    End Sub

    Public Sub altaTelefono(ci As Integer, telefono As Integer)
        Dim persistencia = New PersistenciaPersona
        persistencia.altaTelefono(ci, telefono)
    End Sub

    Public Function buscarPersona(ci As Integer) As Persona
        Dim persistencia = New PersistenciaPersona

        Return persistencia.BuscarPersona(ci)
    End Function
End Class
