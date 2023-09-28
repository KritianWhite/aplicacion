Public Class AgregarEquipo
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_modeloEquipo.Text <> String.Empty And TB_imeiEquipo.Text <> String.Empty And TB_marcaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se agregó el equipo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInputs()
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_modeloEquipo.Clear()
        TB_imeiEquipo.Clear()
        TB_marcaEquipo.Clear()
    End Sub
End Class