Public Class BajaEquipos
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        TB_buscarBajaEquipo.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TB_buscarBajaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se encontró", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_buscarBajaEquipo.Clear()
        Else
            MessageBox.Show("Ingrese el IMEI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
End Class