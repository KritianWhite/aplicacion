Public Class AgregarSIM
    Dim numeroValido As New Auxiliares()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
    End Sub
<<<<<<< Updated upstream

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
=======
    Private Sub BTN_agregarSIM_Click(sender As Object, e As EventArgs)
>>>>>>> Stashed changes
        If (TB_iccSim.Text <> String.Empty And TB_numeroSim.Text <> String.Empty And TB_companiaSim.Text <> String.Empty And
            TB_propietarioSim.Text <> String.Empty And TB_plandatosSim.Text <> String.Empty) Then
            If (numeroValido.ValidarTelefono(TB_numeroSim.Text)) Then
                MessageBox.Show("Se agregó la SIM correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarInputs()
            Else
                MessageBox.Show("Ingrese un número válido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TB_numeroSim.Clear()
            End If
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
    End Sub

    Private Sub LimpiarInputs()
        TB_iccSim.Clear()
        TB_numeroSim.Clear()
        TB_companiaSim.Clear()
        TB_propietarioSim.Clear()
        TB_plandatosSim.Clear()
    End Sub
End Class