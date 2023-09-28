Public Class MigrarSIM
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        LimpiarInputs()
    End Sub

    Private Sub BTN_migrarSim_Click(sender As Object, e As EventArgs) Handles BTN_migrarSim.Click
        If (TB_icc2MigrarSim.Text <> String.Empty) Then
            MessageBox.Show("Se migró la SIM correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_icc2MigrarSim.Clear()
        Else
            MessageBox.Show("Ingrese el ICC nuevo de la SIM que desea migrar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_iccMigrarSIM.Clear()
        TB_icc2MigrarSim.Clear()
        TB_numeroMigrarSim.Clear()
        TB_propietarioMigrarSim.Clear()
        TB_companiaMigrarSim.Clear()
    End Sub
End Class