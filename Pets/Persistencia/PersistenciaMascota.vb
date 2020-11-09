Public Class PersistenciaMascota
    Dim conexion As Npgsql.NpgsqlConnection
    Public Sub AltaMascota(ci As Integer, nombre As String, anoNac As Integer)
        Try
            Dim con = New Conexion
            conexion = con.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "INSERT INTO MASCOTAS (ci, nombre, aÑoNacimiento) VALUES (@ci, @nombre, @anoNac);"

            cmd.CommandText = query
            cmd.Parameters.Add("@ci", NpgsqlTypes.NpgsqlDbType.Integer).Value = ci
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nombre
            cmd.Parameters.Add("@anoNac", NpgsqlTypes.NpgsqlDbType.Integer).Value = anoNac

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Function BuscarMascota(id As Integer) As Mascota
        Try
            Dim mascota As New Mascota
            Dim con = New Conexion
            conexion = con.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "SELECT * FROM MASCOTAS WHERE id = @id"

            cmd.CommandText = query
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            Using lector = cmd.ExecuteReader()
                If lector.HasRows Then
                    lector.Read()
                    mascota.Id = Convert.ToInt32(lector(0).ToString)
                    mascota.Nombre = lector(1).ToString
                    mascota.AnoNac = lector(2).ToString
                    mascota.Dueno = Convert.ToInt32(lector(3).ToString)
                End If
            End Using

            Return mascota
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Function listarMascotas() As List(Of Mascota)
        Try
            Dim listaMascotas As New List(Of Mascota)

            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim cadenaDeComandos As String
            cadenaDeComandos = "SELECT * FROM MASCOTAS"

            cmd.CommandText = cadenaDeComandos

            Dim Lector As Npgsql.NpgsqlDataReader
            Lector = cmd.ExecuteReader

            If Lector.HasRows Then
                While Lector.Read()
                    Dim mascota As New Mascota
                    mascota.Id = Convert.ToInt32(Lector(0).ToString)
                    mascota.Nombre = Lector(1).ToString
                    mascota.AnoNac = Lector(2).ToString
                    mascota.Dueno = Convert.ToInt32(Lector(3).ToString)
                    listaMascotas.Add(mascota)
                End While
            End If

            Return listaMascotas
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Function

    Public Sub ModificarMascota(id As Integer, nombre As String, anoNac As Integer)
        Try
            Dim con = New Conexion
            conexion = con.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim query As String
            query = "UPDATE MASCOTAS SET nombre = @nombre, aÑonacimiento = @anoNac WHERE id = @id"

            cmd.CommandText = query
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id
            cmd.Parameters.Add("@nombre", NpgsqlTypes.NpgsqlDbType.Varchar, 50).Value = nombre
            cmd.Parameters.Add("@anoNac", NpgsqlTypes.NpgsqlDbType.Integer).Value = anoNac

            Dim resultado As Integer
            resultado = cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub

    Public Sub EliminarMascota(id As Integer)
        Try
            Dim classcnn As New Conexion
            conexion = classcnn.AbrirConexion

            Dim cmd = New Npgsql.NpgsqlCommand

            cmd.Connection = conexion

            Dim cadenaDeComandos As String
            cadenaDeComandos = "DELETE FROM MASCOTAS WHERE id = @id"

            cmd.CommandText = cadenaDeComandos
            cmd.Parameters.Add("@id", NpgsqlTypes.NpgsqlDbType.Integer).Value = id

            cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw ex
        Finally
            conexion.Close()
        End Try
    End Sub
End Class