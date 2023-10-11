Public Class AgregarActivo

    Dim controlador As New Controlador()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_placaActivo.Text <> String.Empty And TB_chasisActivo.Text <> String.Empty And TB_tipoActivo.Text <> String.Empty And
            TB_marcaActivo.Text <> String.Empty And TB_modeloActivo.Text <> String.Empty And TB_anioActivo.Text <> String.Empty) Then
            'MessageBox.Show("Se agregó el activo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Try
                If controlador.AgregarActivo(TB_placaActivo.Text, TB_chasisActivo.Text, TB_tipoActivo.Text, TB_marcaActivo.Text, TB_modeloActivo.Text, TB_colorActivo.Text, TB_anioActivo.Text) Then
                    MessageBox.Show("Se agregó el activo.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarInputs()
                End If

            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

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