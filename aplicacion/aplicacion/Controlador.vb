Imports MySqlConnector

Public Class Controlador
    Dim conn As New Conexion()

    ' Clausulas para poder agregar datos a las tablas
    Function AgregarCliente(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO cliente(NOMBRE, TELEFONO, CORREO) VALUES(@NOMBRE, @TELEFONO, @CORREO);", conn.connection)

            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre.ToString()
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono.ToString()
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo.ToString()
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaClientes()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el cliente" & nombre & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function AgregarActivo(ByVal placa As String, ByVal chasis As String, ByVal tipo As String, ByVal marca As String,
                           ByVal modelo As String, ByVal color As String, ByVal anio As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO activo(PLACA, CHASIS, TIPO, MARCA, MODELO, COLOR, ANIO, ESTADO) 
                                            VALUES(@PLACA, @CHASIS, @TIPO, @MARCA, @MODELO, @COLOR, @ANIO, @ESTADO);", conn.connection)

            comando.Parameters.Add("@PLACA", MySqlDbType.VarChar).Value = placa.ToString()
            comando.Parameters.Add("@CHASIS", MySqlDbType.VarChar).Value = chasis.ToString()
            comando.Parameters.Add("@TIPO", MySqlDbType.VarChar).Value = tipo.ToString()
            comando.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = marca.ToString()
            comando.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = modelo.ToString()
            comando.Parameters.Add("@COLOR", MySqlDbType.VarChar).Value = color.ToString()
            comando.Parameters.Add("@ANIO", MySqlDbType.VarChar).Value = anio.ToString()
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INACTIVO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaActivos()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el activo con placa " & placa & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function AgregarEquipo(ByVal imei As String, ByVal modelo As String, ByVal marca As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO equipo(IMEI, MODELO, MARCA, ESTADO) VALUES(@IMEI, @MODELO, @MARCA, @ESTADO);", conn.connection)

            comando.Parameters.Add("@IMEI", MySqlDbType.VarChar).Value = imei.ToString()
            comando.Parameters.Add("@MODELO", MySqlDbType.VarChar).Value = modelo.ToString()
            comando.Parameters.Add("@MARCA", MySqlDbType.VarChar).Value = marca.ToString()
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INACTIVO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaEquipos()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar el equipo con " & imei & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function AgregarSim(ByVal icc As String, ByVal numero As String, ByVal compania As String, ByVal propietario As String,
                           ByVal plan_datos As String, ByVal fecha_vencimiento As String) As Boolean
        Try
            Dim fecha As DateTime = DateTime.Parse(fecha_vencimiento)
            Dim fechaString As String = fecha.ToString("yyyy-MM-dd")
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO sim(ICC, NUMERO, COMPANIA, PROPIETARIO, PLAN_DATOS, VENCE, ESTADO) 
                                            VALUES(@ICC, @NUMERO, @COMPANIA, @PROPIETARIO, @PLAN_DATOS, @VENCE, @ESTADO);", conn.connection)
            comando.Parameters.Add("@ICC", MySqlDbType.VarChar).Value = icc.ToString()
            comando.Parameters.Add("@NUMERO", MySqlDbType.VarChar).Value = numero.ToString()
            comando.Parameters.Add("@COMPANIA", MySqlDbType.VarChar).Value = compania.ToString()
            comando.Parameters.Add("@PROPIETARIO", MySqlDbType.VarChar).Value = propietario.ToString()
            comando.Parameters.Add("@PLAN_DATOS", MySqlDbType.VarChar).Value = plan_datos.ToString()
            comando.Parameters.Add("@VENCE", MySqlDbType.DateTime).Value = fechaString
            comando.Parameters.Add("@ESTADO", MySqlDbType.VarChar).Value = "INACTIVO"
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaSIM()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar la sim con icc " & icc & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function AgregarUsuario(ByVal nombre As String, ByVal rol As String, ByVal contrasenia As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("INSERT INTO usuarios(USUARIO, ROL, CONTRASENIA) VALUES(@USUARIO, @ROL, @CONTRASENIA);", conn.connection)

            comando.Parameters.Add("@USUARIO", MySqlDbType.VarChar).Value = nombre.ToString()
            comando.Parameters.Add("@ROL", MySqlDbType.VarChar).Value = rol.ToString()
            comando.Parameters.Add("@CONTRASENIA", MySqlDbType.VarChar).Value = contrasenia.ToString()
            'Verificamos que se haya insertado a la base datos 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar agregar al usuario " & nombre & " a la base de datos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    ' Clausula para editar datos en las tablas
    Function Editarcliente(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  cliente SET TELEFONO=@TELEFONO, CORREO=@CORREO WHERE NOMBRE=@NOMBRE", conn.connection)
            'comando.Parameters.Add("@ID", MySqlDbType.Int64).Value = id -----  WHERE ID=@ID
            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaClientes()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function EditarActivo(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  activo SET TELEFONO=@TELEFONO, CORREO=@CORREO WHERE NOMBRE=@NOMBRE", conn.connection)
            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaActivos()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function EditarSim(ByVal nombre As String, ByVal telefono As String, ByVal correo As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  activo SET TELEFONO=@TELEFONO, CORREO=@CORREO WHERE NOMBRE=@NOMBRE", conn.connection)
            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre
            comando.Parameters.Add("@TELEFONO", MySqlDbType.VarChar).Value = telefono
            comando.Parameters.Add("@CORREO", MySqlDbType.VarChar).Value = correo
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaSIM()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function
    Function EditarUsuario(ByVal id As String, ByVal nombre As String, ByVal rol As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("UPDATE  activo SET NOMBRE=@NOMBRE, ROL=@ROL WHERE ID=@ID", conn.connection)
            comando.Parameters.Add("@NOMBRE", MySqlDbType.VarChar).Value = nombre
            comando.Parameters.Add("@ROL", MySqlDbType.VarChar).Value = rol
            comando.Parameters.Add("@ID", MySqlDbType.VarChar).Value = id
            ' Verificamos que se haya actualizado solo 1 elemento
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar editar la información del cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function



    ' Clausula para poder eliminar datos de las tablas
    Function EliminarCliente(ByVal nombre As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("DELETE FROM cliente WHERE NOMBRE='" & nombre & "'", conn.connection)
            ' Verificamos que se haya eliminado 1 elemento de la tabla
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaClientes()
                Return True
            Else
                MessageBox.Show("Error al intentar elimnar al cliente " & nombre, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function EliminarActivo(ByVal placa As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("DELETE FROM activo WHERE PLACA='" & placa & "'", conn.connection)
            ' Verificamos que se haya eliminado 1 elemento de la tabla
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaActivos()
                Return True
            Else
                MessageBox.Show("Error al intentar elimnar el activo con placa " & placa, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function EliminarSim(ByVal icc As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("DELETE FROM sim WHERE ICC='" & icc & "'", conn.connection)
            ' Verificamos que se haya eliminado 1 elemento de la tabla
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaSIM()
                Return True
            Else
                MessageBox.Show("Error al intentar elimnar la sim con icc " & icc, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function EliminarUsuario(ByVal usuario As String) As Boolean
        Try
            conn.conexion()
            Dim comando As New MySqlCommand("DELETE FROM usuarios WHERE USUARIO='" & usuario & "'", conn.connection)
            ' Verificamos que se haya eliminado 1 elemento de la tabla
            If comando.ExecuteNonQuery() = 1 Then
                conn.desconexion()
                CargarTablaUsuarios()
                Return True
            Else
                MessageBox.Show("Error al intentar elimnar al usuario " & usuario, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                conn.desconexion()
                Return False
            End If
        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function





    ' Metodos para cargar las tablas 
    Function CargarTablaClientes() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT NOMBRE, TELEFONO, CORREO FROM cliente", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_clientes.Columns("Nombre_C").DataPropertyName = "NOMBRE"
            FormAdmin.DGV_clientes.Columns("Telefono_C").DataPropertyName = "TELEFONO"
            FormAdmin.DGV_clientes.Columns("Correo_C").DataPropertyName = "CORREO"
            FormAdmin.DGV_clientes.DataSource = table

            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function CargarTablaActivos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT PLACA, CHASIS, TIPO, MARCA, MODELO, COLOR, ANIO FROM activo", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Activos.Columns("Placa_A").DataPropertyName = "PLACA"
            FormAdmin.DGV_Activos.Columns("Chasis_A").DataPropertyName = "CHASIS"
            FormAdmin.DGV_Activos.Columns("Tipo_A").DataPropertyName = "TIPO"
            FormAdmin.DGV_Activos.Columns("Marca_A").DataPropertyName = "MARCA"
            FormAdmin.DGV_Activos.Columns("Modelo_A").DataPropertyName = "MODELO"
            FormAdmin.DGV_Activos.Columns("Color_A").DataPropertyName = "COLOR"
            FormAdmin.DGV_Activos.Columns("Anio_A").DataPropertyName = "ANIO"
            FormAdmin.DGV_Activos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function CargarTablaEquipos() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT IMEI, MARCA, MODELO FROM equipo", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Equipos.Columns("IMEI_E").DataPropertyName = "IMEI"
            FormAdmin.DGV_Equipos.Columns("Modelo_E").DataPropertyName = "MODELO"
            FormAdmin.DGV_Equipos.Columns("Marca_E").DataPropertyName = "MARCA"
            FormAdmin.DGV_Equipos.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function CargarTablaSIM() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT ICC, NUMERO, PROPIETARIO, VENCE, PLAN_DATOS, COMPANIA FROM sim", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Sim.Columns("ICC_S").DataPropertyName = "ICC"
            FormAdmin.DGV_Sim.Columns("Numero_S").DataPropertyName = "NUMERO"
            FormAdmin.DGV_Sim.Columns("Propietario_S").DataPropertyName = "PROPIETARIO"
            'FormAdmin.DGV_Sim.Columns("Vence_S").DefaultCellStyle.Format = "yyyy-MM-dd"
            FormAdmin.DGV_Sim.Columns("Vence_S").DataPropertyName = "VENCE"
            'FormAdmin.DGV_Sim.Columns("Vence_S").DefaultCellStyle.NullValue = DBNull.Value
            FormAdmin.DGV_Sim.Columns("Plan_Datos_S").DataPropertyName = "PLAN_DATOS"
            FormAdmin.DGV_Sim.Columns("Compania_S").DataPropertyName = "COMPANIA"
            FormAdmin.DGV_Sim.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

    Function CargarTablaUsuarios() As Boolean
        Try
            conn.conexion()
            Dim adapter As New MySqlDataAdapter("SELECT USUARIO, ROL FROM usuarios;", conn.connection)
            Dim table As New DataTable()

            adapter.Fill(table)
            FormAdmin.DGV_Usuarios.Columns("Nombre_U").DataPropertyName = "USUARIO"
            FormAdmin.DGV_Usuarios.Columns("Rol_U").DataPropertyName = "ROL"
            FormAdmin.DGV_Usuarios.DataSource = table
            conn.desconexion()
            Return True

        Catch ex As Exception
            MessageBox.Show("Error con la base de datos: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            conn.desconexion()
            Return False
        End Try
    End Function

End Class
