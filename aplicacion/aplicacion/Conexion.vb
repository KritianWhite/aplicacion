Imports MySqlConnector

Public Class Conexion

    Public connection As New MySqlConnection
    Public Sub conexion()
        connection.ConnectionString = "datasource=localhost;port=3306;username=root;password=;database=inventario;ConvertZeroDateTime=True"
        connection.Open()
    End Sub

    Public Sub desconexion()
        connection.Close()
    End Sub

End Class
