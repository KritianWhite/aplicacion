Imports System.IO
Imports System.Security.Cryptography

Public Class Encrypted
    Dim aes As New RijndaelManaged()
    ' Dim encrypted As String = EncryptString(password, aes.Key, aes.IV)

    Public Function EncryptString(plaintext As String, key As Byte(), iv As Byte()) As String
        'Instancia que implementa el AES (Advanced Encryption Standard)
        Using aesAlg = New RijndaelManaged()
            ' Establecer la clave y el vector de inicialización (IV) para el cifrado
            aesAlg.Key = key
            aesAlg.IV = iv
            'Creamos un objeto para poder realizar el cifrado
            Dim encryptor = aesAlg.CreateEncryptor(aesAlg.Key, aesAlg.IV)
            ' Creamos un MemoryStream para almacenar el resultado del cifrado
            Using msEncrypt = New MemoryStream()
                ' Creamos un CryptoStream que encriptará los datos (contraseña)
                Using csEncrypt = New CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write)
                    ' Cremamos un StreamWriter para escribir los datos en el CryptoStream
                    Using swEncrypt = New StreamWriter(csEncrypt)
                        ' Escribir el texto sin cifrar en el StreamWriter
                        swEncrypt.Write(plaintext)
                    End Using
                    ' Almacenamos el IV actualizado en la variable iv
                    iv = aesAlg.IV
                    ' Obtenemos el contenido del cifrado como un arreglo de bytes
                    Dim decryptedContent = msEncrypt.ToArray()
                    ' Convertimos y retornamos el IV y el contenido cifrado a cadenas Base64 y concatenamos con un separador (|)
                    Return Convert.ToBase64String(iv) + "|" + Convert.ToBase64String(decryptedContent)
                End Using
            End Using
        End Using
    End Function

End Class
