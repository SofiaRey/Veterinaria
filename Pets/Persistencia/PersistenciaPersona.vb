Public Class PersistenciaPersona
    Dim conexionPP = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(personaUser As Persona)
        Try
            Dim classcnn = New Conexion

            Dim cadenaDeComandos As String
            cadenaDeComandos = "INSERT INTO PERSONA(ci, nombre, direccion) VALUES(ci, nombre, direccion)"

            Dim cmd As Npgsql.NpgsqlCommand
            cmd.Connection = conexionPP

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = personaUser.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = personaUser.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 100).Value = personaUser.Direccion

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.close()
        End Try
    End Sub
End Class
