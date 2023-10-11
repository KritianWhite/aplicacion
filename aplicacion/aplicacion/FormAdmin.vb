Public Class FormAdmin

    ' LLamamos a nuestro controlador
    Dim controlador As New Controlador()
    ' Variable global para la seleccion de dato en cualquier tabla
    Dim valorSeleccionado As String = ""

    Private Sub SallirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SallirToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    ' Navegación de los paneles
    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click
        If (PanelActivos.Visible = False) Then
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelActivos.Visible = True
            PanelActivos.Location = New Point(0, 0)
            PanelActivos.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If (PanelCliente.Visible = False) Then
            PanelActivos.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelCliente.Visible = True
            PanelCliente.Location = New Point(0, 0)
            PanelCliente.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        If (PanelEquipos.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelEquipos.Visible = True
            PanelEquipos.Location = New Point(0, 0)
            PanelEquipos.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub SIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIMToolStripMenuItem.Click
        If (PanelSIM.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelUsuario.Visible = False
            PanelSIM.Visible = True
            PanelSIM.Location = New Point(0, 0)
            PanelSIM.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If (PanelUsuario.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = True
            PanelUsuario.Location = New Point(0, 0)
            PanelUsuario.Dock = DockStyle.Fill
        End If
    End Sub

    ' Navegación hacia otras pestañas
    Private Sub BTN_AgregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarClientes.Click
        AgregarCliente.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles BTN_agregarActivos.Click
        AgregarActivo.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles BTN_agregarEquipos.Click
        AgregarEquipo.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AgregarSIM.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AgregarUsuario.Show()
    End Sub

    Private Sub BajaDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeEquiposToolStripMenuItem.Click
        BajaEquipos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MigrarSIM.Show()
    End Sub

    Private Sub MigracionesDeSIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MigracionesDeSIMToolStripMenuItem.Click
        MigracionSIM.Show()
    End Sub

    Private Sub BTN_asignarActivo_Cliente_Click(sender As Object, e As EventArgs) Handles BTN_asignarActivo_Clientes.Click
        AsignarActivos.Show()
    End Sub

    Private Sub BTN_asignarEquipo_Activos_Click(sender As Object, e As EventArgs) Handles BTN_asignarEquipo_Activos.Click
        AsignarEquipo.Show()
    End Sub

    Private Sub BTN_asignarSIM_Equipos_Click(sender As Object, e As EventArgs) Handles BTN_asignarSIM_Equipos.Click
        AsignarSIM.Show()
    End Sub

    ' En este metodo se cargan todas las tablas al iniciar sesión
    Private Sub FormAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If (PanelCliente.Visible = False) Then
            PanelActivos.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelCliente.Visible = True
            PanelCliente.Location = New Point(0, 0)
            PanelCliente.Dock = DockStyle.Fill
        End If
        Try
            If controlador.CargarTablaClientes() = False Then
                MessageBox.Show("No se pudo cargar la tabla de clientes.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaActivos() = False Then
                MessageBox.Show("No se pudo cargar la tabla de activos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaEquipos() = False Then
                MessageBox.Show("No se pudo cargar la tabla de equipos.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaSIM() = False Then
                MessageBox.Show("No se pudo cargar la tabla de sim.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
            If controlador.CargarTablaUsuarios() = False Then
                MessageBox.Show("No se pudo cargar la tabla de usuarios.", "Error de conexión", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        Catch ex As Exception
            MessageBox.Show("Ocurrió algo inesperado (" & ex.Message & ").", "Error Fatal", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Editar tablas
    Private Sub BTN_editarClientes_Click(sender As Object, e As EventArgs) Handles BTN_editarClientes.Click
        'DGV_clientes.ReadOnly = False
        DGV_clientes.Columns("Telefono_C").ReadOnly = False
        DGV_clientes.Columns("Correo_C").ReadOnly = False

    End Sub

    Private Sub DGV_clientes_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_clientes.CellEndEdit

        If e.ColumnIndex = DGV_clientes.Columns("Telefono_C").Index OrElse
            e.ColumnIndex = DGV_clientes.Columns("Correo_C").Index Then
            'Aquí va tu código para guardar cambios
            Try
                Dim resultado = MessageBox.Show("¿Desea editar la información del cliente " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
                If resultado = DialogResult.OK Then
                    Dim telefono = DGV_clientes.CurrentRow.Cells("Telefono_C").Value
                    Dim correo = DGV_clientes.CurrentRow.Cells("Correo_C").Value
                    If (controlador.Editarcliente(valorSeleccionado, telefono, correo)) Then
                        MessageBox.Show("Se editó la información del cliente " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        DGV_clientes.ReadOnly = True
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If

        'DGV_clientes.CurrentCell = DGV_clientes(e.ColumnIndex, e.RowIndex)
        'DGV_clientes.ClearSelection()
        'DGV_clientes.Rows(e.RowIndex).Cells(e.ColumnIndex).Selected = True

    End Sub

    'Private Sub DGV_clientes_KeyDown(sender As Object, e As KeyEventArgs) Handles DGV_clientes.KeyDown
    '    'Obtenemos valores

    '    ' Validación de confirmar edición o no
    '    ' Recordemos que valorSeleccionado siempre toma el valor de la primera columna (nombre)
    '    ' de la fila seleccionada.
    '    Try
    '        ' Obtener el KeyChar a partir del objeto e (CellEventArgs)
    '        If e.KeyCode = Keys.Enter Then
    '            Dim resultado = MessageBox.Show("¿Desea editar la información del cliente " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
    '            If resultado = DialogResult.OK Then
    '                Dim telefono = DGV_clientes.CurrentRow.Cells("Telefono_C").Value
    '                Dim correo = DGV_clientes.CurrentRow.Cells("Correo_C").Value
    '                If (controlador.Editarcliente(valorSeleccionado, telefono, correo)) Then
    '                    DGV_clientes.ReadOnly = True
    '                    MessageBox.Show("Se editó la información del cliente " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
    '                End If
    '            End If
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try

    'End Sub

    ' Funcionalidades de los botonoes eliminar
    Private Sub BTN_eliminarClientes_Click(sender As Object, e As EventArgs) Handles BTN_eliminarClientes.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar al cliente " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarCliente(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó al cliente " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarActivos_Click(sender As Object, e As EventArgs) Handles BTN_eliminarActivos.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar el activo " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarActivo(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó el activo con placa " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarSim_Click(sender As Object, e As EventArgs) Handles BTN_eliminarSim.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar la sim con icc " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarSim(valorSeleccionado.ToString())) Then
                    MessageBox.Show("Se eliminó la sim con icc " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub BTN_eliminarUsuarios_Click(sender As Object, e As EventArgs) Handles BTN_eliminarUsuarios.Click
        Try
            Dim resultado = MessageBox.Show("¿Desea eliminar al usuario " & valorSeleccionado & "?", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)
            If resultado = DialogResult.OK Then
                If (controlador.EliminarUsuario(valorSeleccionado)) Then
                    MessageBox.Show("Se eliminó al usuario " & valorSeleccionado, "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    ' Metodos para poder obtener el item de la primera columna de cada tabla
    Private Sub DGV_clientes_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_clientes.CellClick
        valorSeleccionado = DGV_clientes.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_Activos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Activos.CellClick
        valorSeleccionado = DGV_Activos.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_Equipos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Equipos.CellClick
        valorSeleccionado = DGV_Equipos.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_Sim_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Sim.CellClick
        'Debo de corregir el error al obtener el icc, ya que no se porque ocurre aún (Pero a de ser por la fecha[Talvez])
        valorSeleccionado = DGV_Sim.CurrentRow.Cells(0).Value
    End Sub
    Private Sub DGV_Usuarios_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Usuarios.CellClick
        valorSeleccionado = DGV_Usuarios.CurrentRow.Cells(0).Value
    End Sub

End Class