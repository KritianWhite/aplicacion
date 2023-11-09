Public Class InformeActivos
    Dim controlador As New Controlador()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If Not controlador.CargarTablaPlataforma_InformeActivos(RadioButton3.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If Not controlador.CargarTablaPlataforma_InformeActivos(RadioButton4.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If Not controlador.CargarTablaAdquisicion_InformeActivos(RadioButton1.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If Not controlador.CargarTablaAdquisicion_InformeActivos(RadioButton2.Text) Then
            MessageBox.Show("No se pudo cargar la tabla.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub TB_buscarActivo_TextChanged(sender As Object, e As EventArgs) Handles TB_buscarActivo.TextChanged
        Dim searchText As String = TB_buscarActivo.Text.Trim().ToLower() ' Obtener el texto de búsqueda en minúsculas

        ' Obtener la fila seleccionada (si hay alguna)
        Dim selectedRow As DataGridViewRow = DGV_informeActivos.CurrentRow

        ' Iterar a través de las filas del DataGridView
        For Each row As DataGridViewRow In DGV_informeActivos.Rows
            If row IsNot selectedRow Then
                ' Verificar que no sea la fila de encabezado, que no sea la primera fila y que tenga al menos dos celdas
                ' Obtener los valores de las celdas en la primera (Nombre de usuario)
                Dim cellValue1 As String = row.Cells(0).Value.ToString().ToLower()
                Dim cellValue2 As String = row.Cells(0).Value.ToString().ToLower()

                ' Verificar si el texto de búsqueda está contenido en alguna de las celdas
                If cellValue1.Contains(searchText) Or cellValue2.Contains(searchText) Then
                    row.Visible = True ' Mostrar la fila si se encuentra una coincidencia
                Else
                    row.Visible = False ' Ocultar la fila si no hay coincidencia
                End If
            End If
        Next
    End Sub

    Private Sub DGV_informeActivos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_informeActivos.CellClick
        If DGV_informeActivos.SelectedRows.Count > 0 Then

        End If
    End Sub
End Class