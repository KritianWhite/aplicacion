Public Class AgregarUsuario
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_usuarioUsuario.Text <> String.Empty And TB_contraseniaUsuario.Text <> String.Empty And TB_contrasenia2Usuario.Text <> String.Empty) Then
            If (CB_rolUsuario.Text <> String.Empty) Then
                MessageBox.Show("Se agregó el usuario correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarInputs()
            Else
                MessageBox.Show("Seleccione un rol para el usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Else
            MessageBox.Show("Falta ingresar datos en el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_usuarioUsuario.Clear()
        TB_contraseniaUsuario.Clear()
        TB_contrasenia2Usuario.Clear()
        CB_rolUsuario.Text = "Seleccione una opcion"
    End Sub
End Class