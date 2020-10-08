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
End Class