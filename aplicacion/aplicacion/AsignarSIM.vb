Public Class AsignarSIM
<<<<<<< Updated upstream
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
=======
    Dim controlador As New Controlador()
    Dim valorSeleccionado_equipo As String = ""
    Dim valorSeleccionado_sim As String = ""
    Dim valorSeleccionado_asignacion As String = ""
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
        FormAdmin.Show()
    End Sub

    Private Sub AsignarSIM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_equipos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_sim.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_equipos.EnableHeadersVisualStyles = False
        DGV_sim.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False
        ' Carga de tablas (Equipo, SIM y asignaciones)
        If Not controlador.CargarTablaSim_Sim() Then
            MessageBox.Show("Error al cargar tabla de sim.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
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

    Private Sub TB_buscarSim_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarSim.TextChanged
        Dim searchText As String = TB_buscarSim.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_sim.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_sim.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (ICC y Numero)
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

    Private Sub TB_buscarAsignaciones_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarAsignaciones.TextChanged
        Dim searchText As String = TB_buscarAsignaciones.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_asignaciones.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_asignaciones.Rows
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
>>>>>>> Stashed changes
    End Sub

    ' Funciones para los botones
    Private Sub BTN_seleccionarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarEquipo.Click
        If valorSeleccionado_equipo <> "" Then
            LB_equipoSeleccionado.Text = valorSeleccionado_equipo
        Else
            MessageBox.Show("No ha seleccionado ningún equipo para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_seleccionarSim_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarSim.Click
        If valorSeleccionado_sim <> "" Then
            LB_simSeleccionado.Text = valorSeleccionado_sim
        Else
            MessageBox.Show("No ha seleccionado ninguna sim para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_equipoSeleccionado.Text <> "No seleccionado" And LB_simSeleccionado.Text <> "No seleccionado" Then
            ' Codigo aqui para consulta query
            MessageBox.Show("hola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Eqiupo/SIM no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub BTN_desasignarEquipo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarEquipo.Click
        If valorSeleccionado_asignacion <> "" Then
            ' Codigo para enviar datos a consulta query
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación para desasignarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Para obtener el valor que se selecciona del datagridview
    Private Sub DGV_equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_equipos.CellClick
        valorSeleccionado_equipo = DGV_equipos.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DGV_sim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_sim.CellClick
        valorSeleccionado_sim = DGV_sim.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DGV_asignaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_asignaciones.CellClick
        valorSeleccionado_asignacion = DGV_asignaciones.CurrentRow.Cells(0).Value
    End Sub

    Private Sub DGV_equipos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_equipos.CellContentClick

    End Sub
End Class