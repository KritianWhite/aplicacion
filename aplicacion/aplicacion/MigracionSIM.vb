Public Class MigracionSIM
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        TB_buscarBajaEquipo.Clear()
    End Sub

    Private Sub BTN_buscar_Click(sender As Object, e As EventArgs) Handles BTN_buscar.Click
        If (TB_buscarBajaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se encontró", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_buscarBajaEquipo.Clear()
        Else
            MessageBox.Show("Ingrese el ICC actual para buscar el SIM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub MigracionSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_migracionesSim.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_migracionesSim.EnableHeadersVisualStyles = False
    End Sub
End Class