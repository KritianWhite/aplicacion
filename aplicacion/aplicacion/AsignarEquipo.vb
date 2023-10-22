Public Class AsignarEquipo
<<<<<<< Updated upstream
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
=======
    Dim controlador As New Controlador()
    Dim valorSeleccionado_activo As String = ""
    Dim valorSeleccionado_equipo As String = ""
    Dim valorSeleccionado_asignacion As String = ""
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
        ' Carga de los comobobox's
        If Not controlador.CargarPlataformaAsignacion_Equipo() Then
            MessageBox.Show("Error al cargar las plataformas.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarActivos_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivos.TextChanged
        Dim searchText As String = TB_buscarActivos.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Activos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If row IsNot selectedRow Then
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

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_equipos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_equipos.Rows
            If row IsNot selectedRow Then
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

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_asignaciones.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_asignaciones.Rows
            If row IsNot selectedRow Then
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
>>>>>>> Stashed changes
    End Sub

    ' Funciones para los botones
    Private Sub BTN_seleccionarActivo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarActivo.Click
        If valorSeleccionado_activo <> "" Then
            LB_activoSeleccionado.Text = valorSeleccionado_activo
        Else
            MessageBox.Show("No ha seleccionado ningún activo para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_seleccionarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarEquipo.Click
        If valorSeleccionado_equipo <> "" Then
            LB_equipoSeleccionado.Text = valorSeleccionado_equipo
        Else
            MessageBox.Show("No ha seleccionado ningún equipo para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_activoSeleccionado.Text <> "No seleccionado" And LB_equipoSeleccionado.Text <> "No seleccionado" Then
            If CB_plataforma.Text <> String.Empty Then
                If CB_adquisicion.Text <> String.Empty Then
                    ' Codigo aqui para consulta query
                    MessageBox.Show("hola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Seleccione un tipo de adquisición para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Seleccione una plataforma para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Activo/Eqiupo no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_desasignarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarEquipo.Click
        If valorSeleccionado_asignacion <> "" Then
            ' Realizar aqui el envio del dato seleccionado a consulta query
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación para desasignarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Funciones para la obtención de datos de la tabla al seleccionar una fila
    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        valorSeleccionado_activo = DGV_Activos.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DGV_equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_equipos.CellClick
        valorSeleccionado_equipo = DGV_equipos.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DGV_asignaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_asignaciones.CellClick
        valorSeleccionado_asignacion = DGV_asignaciones.CurrentRow.Cells(0).Value
    End Sub

End Class