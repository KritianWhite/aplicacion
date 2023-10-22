Public Class BajaEquipos
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        TB_buscarBajaEquipo.Clear()
    End Sub

<<<<<<< Updated upstream
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (TB_buscarBajaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se encontró", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            TB_buscarBajaEquipo.Clear()
        Else
            MessageBox.Show("Ingrese el IMEI", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
=======
    Private Sub BajaEquipos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_bajaEquipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_bajaEquipos.EnableHeadersVisualStyles = False
    End Sub

    Private Sub TB_buscarBajaEquipo_TextChanged(sender As Object, e As EventArgs) 
        Dim searchText As String = TB_buscarBajaEquipo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_bajaEquipos.Rows
            If Not row.IsNewRow AndAlso row.Index <> 0 AndAlso row.Cells.Count >= 2 Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (IMEI)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
>>>>>>> Stashed changes
    End Sub

    Private Sub TB_buscarBajaEquipo_TextChanged_1(sender As Object, e As EventArgs) Handles TB_buscarBajaEquipo.TextChanged
        Dim searchText As String = TB_buscarBajaEquipo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_bajaEquipos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_bajaEquipos.Rows
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