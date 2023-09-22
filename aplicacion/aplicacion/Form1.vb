
Imports System.Security.Cryptography

Public Class Form1
    Dim aes As New RijndaelManaged()
    Dim encryp As New Encrypted()

    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click


        If (TB_usuario.Text <> String.Empty And TB_contrasena.Text <> String.Empty) Then
            Dim encrypted As String = encryp.EncryptString(TB_contrasena.Text, aes.Key, aes.IV)
            MessageBox.Show("Usted inició sesión correctamente ", "Acceso de authenticacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Limpiar()
        Else
            MessageBox.Show("Ingrese su usuario y/o contraseña.", "Error de authenticacion", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub Limpiar()
        TB_usuario.Text = ""
        TB_contrasena.Text = ""
    End Sub
End Class
