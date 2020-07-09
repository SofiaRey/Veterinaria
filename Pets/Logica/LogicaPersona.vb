Public Class LogicaPersona
    Public Sub altaPersona(personaUser As Persona)
        Dim persistencia As New PersistenciaPersona
        persistencia.altaPersona(personaUser)
    End Sub
End Class
