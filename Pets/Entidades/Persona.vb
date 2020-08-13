Public Class Persona
    Private _ci As Integer
    Private _nombre As String
    Private _direccion As String
    Private _telefonos As New List(Of Integer)

    Public Property Ci As Integer
        Get
            Return _ci
        End Get
        Set(value As Integer)
            _ci = value
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
    Public Property Direccion As String
        Get
            Return _direccion
        End Get
        Set(value As String)
            _direccion = value
        End Set
    End Property

    Public Property Telefonos As List(Of Integer)
        Get
            Return _telefonos
        End Get
        Set(value As List(Of Integer))
            _telefonos = value
        End Set
    End Property

    Public Sub persona()

    End Sub
    Public Sub persona(ci_ As Integer, nombre_ As String, direccion_ As String, telefonos_ As List(Of Integer))
        Ci = ci_
        Nombre = nombre_
        Direccion = direccion_
        Telefonos = telefonos_
    End Sub

End Class
