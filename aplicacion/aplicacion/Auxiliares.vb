Imports System.Text.RegularExpressions

Public Class Auxiliares

    ' Función para validar numero telefono correcto (12345678)
    Public Function ValidarTelefono(numero As String) As Boolean

        Dim regex As New Regex("^\d{8}$")

        If regex.IsMatch(numero) Then
            Return True
        Else
            Return False
        End If

    End Function

End Class
