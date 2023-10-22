<<<<<<< Updated upstream
﻿Public Class AsignarActivos
=======
﻿Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class AsignarActivos
    Dim controlador As New Controlador()
    Dim valorSeleccionado_cliente As String = ""
    Dim valorSeleccionado_activo As String = ""
    Dim valorSeleccionado_asignacion As String = ""
>>>>>>> Stashed changes
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
    End Sub

<<<<<<< Updated upstream
=======
    Private Sub AsignarActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Establecemos el color al encabezado del datagridview.
        DGV_Clientes.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_Activos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        DGV_asignaciones.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5")
        ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
        DGV_Clientes.EnableHeadersVisualStyles = False
        DGV_Activos.EnableHeadersVisualStyles = False
        DGV_asignaciones.EnableHeadersVisualStyles = False

        'Cargamos tablas (Clientes, activos y asignaciones)
        If Not controlador.CargarTablaClientes_Activo() Then
            MessageBox.Show("Error al cargar la tabla de clientes.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If Not controlador.CargarTablaActivos_Activo() Then
            MessageBox.Show("Error al cargar la tabla de activos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    ' Busquedas en las tablas
    Private Sub TB_buscarCliente_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarCliente.TextChanged
        Dim searchText As String = TB_buscarCliente.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Clientes.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Clientes.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre del cliente)
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

    Private Sub TB_buscarActivo_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivo.TextChanged
        Dim searchText As String = TB_buscarActivo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_Activos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_Activos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera y segunda columna (Placa o chasis)
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
                ' Obtener los valores de las celdas en la primera y segunda columna (Cliente[Nonmbre] y placa)
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

    ' Funcionalidades de botones para el envio de la informacion
    Private Sub BTN_seleccionarCliente_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarCliente.Click
        If valorSeleccionado_cliente <> "" Then
            LB_clienteSeleccionado.Text = valorSeleccionado_cliente
        Else
            MessageBox.Show("No ha seleccionado ningún cliente para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_seleccionarActivo_Click(sender As Object, e As EventArgs) Handles BTN_seleccionarActivo.Click
        If valorSeleccionado_activo <> "" Then
            LB_activoSeleccionado.Text = valorSeleccionado_activo
        Else
            MessageBox.Show("No ha seleccionado ningún activo para la asignación.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_asignar_Click(sender As Object, e As EventArgs) Handles BTN_asignar.Click
        If LB_clienteSeleccionado.Text <> "No seleccionado" And LB_activoSeleccionado.Text <> "No seleccionado" Then
            ' Codigo aqui para consulta query
            MessageBox.Show("hola", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Cliente/Activo no seleccionado.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
    Private Sub BTN_desasignarActivo_Click(sender As Object, e As EventArgs) Handles BTN_desasignarActivo.Click
        If valorSeleccionado_asignacion <> "" Then
            ' Realizar aqui el envio del dato seleccionado a consulta query
        Else
            MessageBox.Show("No ha seleccionado ninguna asignación para desasignarla.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    ' Metodos para obtener el valor de la primer columna de la fila seleccionada
    Private Sub DGV_Clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellClick
        valorSeleccionado_cliente = DGV_Clientes.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        valorSeleccionado_activo = DGV_Activos.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_asignaciones_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_asignaciones.CellClick
        valorSeleccionado_asignacion = DGV_asignaciones.CurrentRow.Cells(0).Value
    End Sub
>>>>>>> Stashed changes
End Class