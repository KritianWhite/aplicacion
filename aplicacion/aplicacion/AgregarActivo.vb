Public Class AgregarActivo
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_placaActivo.Text <> String.Empty And TB_chasisActivo.Text <> String.Empty And TB_tipoActivo.Text <> String.Empty And
            TB_marcaActivo.Text <> String.Empty And TB_modeloActivo.Text <> String.Empty And TB_anioActivo.Text <> String.Empty) Then
            MessageBox.Show("Se agregó el activo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInputs()
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_anioActivo.Clear()
        TB_chasisActivo.Clear()
        TB_marcaActivo.Clear()
        TB_modeloActivo.Clear()
        TB_placaActivo.Clear()
        TB_tipoActivo.Clear()
    End Sub
End Class