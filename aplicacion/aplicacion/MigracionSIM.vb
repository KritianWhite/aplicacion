Public Class MigracionSIM
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        TB_buscarBajaEquipo.Clear()
    End Sub

<<<<<<< Updated upstream
    Private Sub BTN_buscar_Click(sender As Object, e As EventArgs) Handles BTN_buscar.Click
        If (TB_buscarBajaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se encontró", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_buscarBajaEquipo.Clear()
        Else
            MessageBox.Show("Ingrese el ICC actual para buscar el SIM", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
=======
    Private Sub MigracionSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_migracionesSim.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_migracionesSim.EnableHeadersVisualStyles = False
    End Sub

    Private Sub TB_buscarSim_TextChanged(sender As Object, e As EventArgs) 
        Dim searchText As String = TB_buscarSim.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_migracionesSim.Rows
            If Not row.IsNewRow AndAlso row.Index <> 0 AndAlso row.Cells.Count >= 2 Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera, segunda y tercera columna (ICC anterior, ICC actual y Numero)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()
                Dim cellValue3 As String = row.Cells(2).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Or cellValue3.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
>>>>>>> Stashed changes
    End Sub

    Private Sub TB_buscarSim_TextChanged_1(sender As Object, e As EventArgs) Handles TB_buscarSim.TextChanged
        Dim searchText As String = TB_buscarSim.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_migracionesSim.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_migracionesSim.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Equipo o ICC)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(1).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub
End Class