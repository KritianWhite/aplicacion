Imports MySqlConnector

Public Class Conexion

    Public puerto As String
    Public username As String
    Public password As String
    Public database As String

    Public connection As New MySqlConnection
    Public Sub conexion()
        connection.ConnectionString = "datasource=localhost;port=3306;username=root;password=;database=inventario;ConvertZeroDateTime=True"
        connection.Open()
    End Sub

    Public Sub desconexion()
        connection.Close()
    End Sub

End Class
