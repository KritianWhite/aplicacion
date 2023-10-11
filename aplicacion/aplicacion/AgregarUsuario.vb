Imports System.Security.Cryptography

Public Class AgregarUsuario
    Dim controlador As New Controlador()
    Dim encryp As New Encrypted()
    Dim aes As New RijndaelManaged()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_usuarioUsuario.Text <> String.Empty And TB_contraseniaUsuario.Text <> String.Empty And TB_contrasenia2Usuario.Text <> String.Empty And CB_rolUsuario.Text <> String.Empty) Then
            If TB_contraseniaUsuario.Text = TB_contrasenia2Usuario.Text Then
                Dim encrypted As String = encryp.EncryptString(TB_contraseniaUsuario.Text, aes.Key, aes.IV)
                Try
                    If controlador.AgregarUsuario(TB_usuarioUsuario.Text, CB_rolUsuario.Text, encrypted) Then
                        MessageBox.Show("Se agregó el usuario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        LimpiarInputs()
                    End If
                Catch ex As Exception
                    MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        Else
            MessageBox.Show("Falta ingresar datos en el formulario", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_usuarioUsuario.Clear()
        TB_contraseniaUsuario.Clear()
        TB_contrasenia2Usuario.Clear()
        CB_rolUsuario.Text = "Seleccione una opcion"
    End Sub
End Class