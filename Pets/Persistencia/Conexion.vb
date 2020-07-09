Public Class Conexion
    Public Function AbrirConexion() As Npgsql.NpgsqlConnection

        Dim conexionPg As Npgsql.NpgsqlConnection

        Try
            conexionPg = New Npgsql.NpgsqlConnection()

            Dim cadenaDeConexion As String
            cadenaDeConexion = "server = 127.0.0.1; port = 5432; user = 'postgres'; password = 'root'; database: Pets"
            conexionPg.ConnectionString = cadenaDeConexion

            conexionPg.Open()
        Catch ex As Exception
            Throw ex
        End Try

        Return conexionPg
    End Function
End Class
