Public Class Mascota
    Private _id Ad Integer
    Private _dueno As Persona
    Private _nombre As String
    Private _anoNac As Integer

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property
    Public Property Dueno As Persona
        Get
            Return _dueno
        End Get
        Set(value As Persona)
            _dueno = value
        End Set
    End Property
    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property
    Public Property AnoNac As String
        Get
            Return _anoNac
        End Get
        Set(value As String)
            _anoNac = value
        End Set
    End Property

    'You can use the empty constructor or the other one, so you can choose the way you create your class.
    Public Sub mascota()

    End Sub

    Public Sub mascota(id_ As Integer, dueno_ As Persona, nombre_ As String, anoNac_ As Integer)
        Id = id_
        Dueno = dueno_
        Nombre = nombre_
        AnoNac = anoNac_
    End Sub
End Class
