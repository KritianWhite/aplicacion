Public Class AsignarEquipo
    Dim controlador As New Controlador()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub AsignarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_Activos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_equipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_Activos.EnableHeadersVisualStyles = False
        DGV_equipos.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False
        ' Carga de tablas (Activo, equipo y asignaciones)
        If Not controlador.CargarTablaActivos_Equipo() Then
            MessageBox.Show("Error al cargar la tabla de activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarActivos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivos.TextChanged
        Dim searchText As String = TB_buscarActivos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If Not row.IsNewRow AndAlso row.Index <> 0 AndAlso row.Cells.Count >= 2 Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Placa y chásis)
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

    Private Sub TB_buscarEquipos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarEquipos.TextChanged
        Dim searchText As String = TB_buscarEquipos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_equipos.Rows
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
    End Sub

    Private Sub TB_buscarAsignaciones_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarAsignaciones.TextChanged
        Dim searchText As String = TB_buscarAsignaciones.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_asignaciones.Rows
            If Not row.IsNewRow AndAlso row.Index <> 0 AndAlso row.Cells.Count >= 2 Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (ACTIVO[placa] y Equipo[IMEI])
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