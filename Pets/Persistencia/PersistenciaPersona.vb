Public Class PersistenciaPersona
    Dim conexionPP = New Npgsql.NpgsqlConnection

    Public Sub altaPersona(persona As Persona)
        Try
            Dim classcnn = New Conexion
            conexionPP = classcnn.AbrirConexion()

            Dim cmd = New Npgsql.NpgsqlCommand()
            cmd.Connection = conexionPP

            Dim query = "INSERT INTO PERSONA (ci, nombre, direccion) VALUES (@ci, @nombre, @direccion);"
            cmd.CommandText = query

            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Direccion

            Dim resultado As Integer

            resultado = cmd.ExecuteNonQuery()

            If resultado = 1 Then
                Dim i = 0
                While i < persona.Telefonos.Count
                    cmd = New Npgsql.NpgsqlCommand()
                    cmd.Connection = conexionPP

                    query = "INSERT INTO Telefono (ci, telefono) VALUES (@ci, @telefono);"
                    cmd.CommandText = query

                    cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
                    cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Telefonos.Item(i)

                    resultado = cmd.ExecuteNonQuery()
                    i = i + 1
                End While
            End If
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Sub

    Public Sub modificarPersona(persona As Persona)
        Try
            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim cadenaDeComandos As String
            ' UPDATE persona SET nombre = 'Gonzalo Nun', direccion = 'A. Legnani 6742' WHERE ci = 14725836;
            cadenaDeComandos = "UPDATE PERSONA SET nombre = @nombre, direccion = @direccion WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Nombre
            cmd.Parameters.Add("@direccion", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = persona.Direccion

            cmd.ExecuteNonQuery()

            cadenaDeComandos = "DELETE FROM TELEFONO WHERE ci = @ci"
            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = persona.Ci
            cmd.ExecuteNonQuery()

            For Each telefono As Integer In persona.Telefonos
                altaTelefono(persona.Ci, telefono)
            Next
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Sub

    Public Sub altaTelefono(ci As Integer, telefono As Integer)
        Try
            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim cadenaDeComandos As String
            cadenaDeComandos = "INSERT INTO TELEFONO (ci, telefono) VALUES (@ci, @telefono)"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@telefono", NpgsqlTypes.NpgsqlDbType.Integer).Value = telefono

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
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


            Using lector = cmd.ExecuteReader()

                If lector.HasRows Then
                    lector.Read()
                    persona.Ci = Convert.ToInt32(lector(0).ToString)
                    persona.Nombre = lector(1).ToString
                    persona.Direccion = lector(2).ToString
                End If

            End Using



            Dim lector2 As Npgsql.NpgsqlDataReader

            cadenaDeComandos = "SELECT * FROM TELEFONO WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            lector2 = cmd.ExecuteReader()

            If lector2.HasRows Then
                While lector2.Read()
                    persona.Telefonos.Add(Convert.ToInt32(lector2(1).ToString))
                End While
            End If

            Return persona
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Function

    Public Function listarPersona() As List(Of Persona)
        Try
            Dim listaPersonas As New List(Of Persona)

            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim cadenaDeComandos As String
            cadenaDeComandos = "SELECT * FROM PERSONA"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim persona As New Persona
                    persona.Ci = Convert.ToInt32(Lector(0).ToString)
                    persona.Nombre = Lector(1).ToString
                    persona.Direccion = Lector(2).ToString
                    listaPersonas.Add(persona)
                End While
            End If

            Return listaPersonas
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Function

    Public Sub eliminarPersona(ci As Integer)
        Try
            Dim classcnn As New Conexion
            conexionPP = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexionPP

            Dim cadenaDeComandos As String
            cadenaDeComandos = "DELETE FROM TELEFONO WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

            cadenaDeComandos = "DELETE FROM MASCOTA WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()

            cadenaDeComandos = "DELETE FROM PERSONA WHERE ci = @ci"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexionPP.Close()
        End Try
    End Sub
End Class
