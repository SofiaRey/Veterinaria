Public Class PersistenciaPersona
    Dim conexionPP = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(persona As Persona)
        Try
            Dim classcnn = New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim query As String
            query = "INSERT INTO PERSONA (ci, nombre, direccion) VALUES (@ci, @nombre, @direccion);"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Direccion

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < persona.Telefonos.Count
                    query = "INSERT INTO Telefono (ci, telefono) VALUES (@ci, @telefono);"

                    cmd.CommandText = query
                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Telefonos.Item(i)
                    i = i + 1
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Sub

    Public Sub altaTelefono(persona As Persona)
        Try

            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP
            Dim cadenaDeComandos As String

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < persona.Telefonos.Count
                    cadenaDeComandos = "INSERT INTO Telefono (ci, telefono) VALUES (@ci, @telefono);"

                    cmd.CommandText = cadenaDeComandos
                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Telefonos.Item(i)
                    i = i + 1
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Sub

    Public Function buscarPersona(ci As Integer) As Persona
        Try
            Dim persona As New Persona
            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim cadenaDeComandos As String
            cadenaDeComandos = "SELECT * FROM PERSONA WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            Dim lector As Npgsql.NpgsqlDataReader = cmd.ExecuteReader()

            If lector.HasRows Then
                lector.Read()
                persona.Ci = Convert.ToInt32(lector(0).ToString)
                persona.Nombre = lector(1).ToString
                persona.Direccion = lector(2).ToString
            End If

            Return persona
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Function
End Class
