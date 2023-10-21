<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FormAdmin
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.ClientesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ActivosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BajaDeEquiposToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MigracionesDeSIMToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuariosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SallirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelCliente = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BTN_asignarActivo_Clientes = New System.Windows.Forms.Button()
        Me.BTN_eliminarClientes = New System.Windows.Forms.Button()
        Me.BTN_editarClientes = New System.Windows.Forms.Button()
        Me.BTN_agregarClientes = New System.Windows.Forms.Button()
        Me.TB_buscarClientes = New System.Windows.Forms.TextBox()
        Me.DGV_clientes = New System.Windows.Forms.DataGridView()
        Me.Nombre_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Correo_C = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelActivos = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.BTN_asignarEquipo_Activos = New System.Windows.Forms.Button()
        Me.BTN_eliminarActivos = New System.Windows.Forms.Button()
        Me.BTN_editarActivos = New System.Windows.Forms.Button()
        Me.BTN_agregarActivos = New System.Windows.Forms.Button()
        Me.TB_buscarActivos = New System.Windows.Forms.TextBox()
        Me.DGV_Activos = New System.Windows.Forms.DataGridView()
        Me.Placa_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Chasis_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Color_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anio_A = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelEquipos = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTN_asignarSIM_Equipos = New System.Windows.Forms.Button()
        Me.BTN_bajaEquipos = New System.Windows.Forms.Button()
        Me.BTN_agregarEquipos = New System.Windows.Forms.Button()
        Me.TB_buscarEquipos = New System.Windows.Forms.TextBox()
        Me.DGV_Equipos = New System.Windows.Forms.DataGridView()
        Me.IMEI_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_E = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelSIM = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.BTN_eliminarSim = New System.Windows.Forms.Button()
        Me.BTN_editarSIM = New System.Windows.Forms.Button()
        Me.Button14 = New System.Windows.Forms.Button()
        Me.TB_buscarSim = New System.Windows.Forms.TextBox()
        Me.DGV_Sim = New System.Windows.Forms.DataGridView()
        Me.ICC_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Vence_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Plan_Datos_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania_S = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PanelUsuario = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.BTN_eliminarUsuarios = New System.Windows.Forms.Button()
        Me.BTN_editarUsuario = New System.Windows.Forms.Button()
        Me.BTN_agregarUsuario = New System.Windows.Forms.Button()
        Me.TB_buscarUsuario = New System.Windows.Forms.TextBox()
        Me.DGV_Usuarios = New System.Windows.Forms.DataGridView()
        Me.Nombre_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Rol_U = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MenuStrip1.SuspendLayout()
        Me.PanelCliente.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelActivos.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelEquipos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DGV_Equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSIM.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.DGV_Sim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelUsuario.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.White
        Me.MenuStrip1.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem, Me.ActivosToolStripMenuItem, Me.EquiposToolStripMenuItem, Me.SIMToolStripMenuItem, Me.UsuariosToolStripMenuItem, Me.SallirToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1091, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'ClientesToolStripMenuItem
        '
        Me.ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        Me.ClientesToolStripMenuItem.Size = New System.Drawing.Size(66, 20)
        Me.ClientesToolStripMenuItem.Text = "Clientes"
        '
        'ActivosToolStripMenuItem
        '
        Me.ActivosToolStripMenuItem.Name = "ActivosToolStripMenuItem"
        Me.ActivosToolStripMenuItem.Size = New System.Drawing.Size(62, 20)
        Me.ActivosToolStripMenuItem.Text = "Activos"
        '
        'EquiposToolStripMenuItem
        '
        Me.EquiposToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BajaDeEquiposToolStripMenuItem})
        Me.EquiposToolStripMenuItem.Name = "EquiposToolStripMenuItem"
        Me.EquiposToolStripMenuItem.Size = New System.Drawing.Size(67, 20)
        Me.EquiposToolStripMenuItem.Text = "Equipos"
        '
        'BajaDeEquiposToolStripMenuItem
        '
        Me.BajaDeEquiposToolStripMenuItem.Name = "BajaDeEquiposToolStripMenuItem"
        Me.BajaDeEquiposToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BajaDeEquiposToolStripMenuItem.Text = "Baja de equipos"
        '
        'SIMToolStripMenuItem
        '
        Me.SIMToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MigracionesDeSIMToolStripMenuItem})
        Me.SIMToolStripMenuItem.Name = "SIMToolStripMenuItem"
        Me.SIMToolStripMenuItem.Size = New System.Drawing.Size(42, 20)
        Me.SIMToolStripMenuItem.Text = "SIM"
        '
        'MigracionesDeSIMToolStripMenuItem
        '
        Me.MigracionesDeSIMToolStripMenuItem.Name = "MigracionesDeSIMToolStripMenuItem"
        Me.MigracionesDeSIMToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.MigracionesDeSIMToolStripMenuItem.Text = "Migraciones de SIM"
        '
        'UsuariosToolStripMenuItem
        '
        Me.UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        Me.UsuariosToolStripMenuItem.Size = New System.Drawing.Size(72, 20)
        Me.UsuariosToolStripMenuItem.Text = "Usuarios"
        '
        'SallirToolStripMenuItem
        '
        Me.SallirToolStripMenuItem.Name = "SallirToolStripMenuItem"
        Me.SallirToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.SallirToolStripMenuItem.Text = "Sallir"
        '
        'PanelCliente
        '
        Me.PanelCliente.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelCliente.Controls.Add(Me.Label1)
        Me.PanelCliente.Controls.Add(Me.GroupBox1)
        Me.PanelCliente.Location = New System.Drawing.Point(0, 88)
        Me.PanelCliente.Name = "PanelCliente"
        Me.PanelCliente.Size = New System.Drawing.Size(1088, 614)
        Me.PanelCliente.TabIndex = 3
        Me.PanelCliente.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 79)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "CLIENTES"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.BTN_asignarActivo_Clientes)
        Me.GroupBox1.Controls.Add(Me.BTN_eliminarClientes)
        Me.GroupBox1.Controls.Add(Me.BTN_editarClientes)
        Me.GroupBox1.Controls.Add(Me.BTN_agregarClientes)
        Me.GroupBox1.Controls.Add(Me.TB_buscarClientes)
        Me.GroupBox1.Controls.Add(Me.DGV_clientes)
        Me.GroupBox1.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(62, 137)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(964, 430)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'BTN_asignarActivo_Clientes
        '
        Me.BTN_asignarActivo_Clientes.Location = New System.Drawing.Point(832, 384)
        Me.BTN_asignarActivo_Clientes.Name = "BTN_asignarActivo_Clientes"
        Me.BTN_asignarActivo_Clientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarActivo_Clientes.TabIndex = 8
        Me.BTN_asignarActivo_Clientes.Text = "Asignar activos"
        Me.BTN_asignarActivo_Clientes.UseVisualStyleBackColor = True
        '
        'BTN_eliminarClientes
        '
        Me.BTN_eliminarClientes.Location = New System.Drawing.Point(83, 250)
        Me.BTN_eliminarClientes.Name = "BTN_eliminarClientes"
        Me.BTN_eliminarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarClientes.TabIndex = 7
        Me.BTN_eliminarClientes.Text = "Eliminar"
        Me.BTN_eliminarClientes.UseVisualStyleBackColor = True
        '
        'BTN_editarClientes
        '
        Me.BTN_editarClientes.Location = New System.Drawing.Point(83, 205)
        Me.BTN_editarClientes.Name = "BTN_editarClientes"
        Me.BTN_editarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarClientes.TabIndex = 6
        Me.BTN_editarClientes.Text = "Editar"
        Me.BTN_editarClientes.UseVisualStyleBackColor = True
        '
        'BTN_agregarClientes
        '
        Me.BTN_agregarClientes.Location = New System.Drawing.Point(83, 157)
        Me.BTN_agregarClientes.Name = "BTN_agregarClientes"
        Me.BTN_agregarClientes.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarClientes.TabIndex = 3
        Me.BTN_agregarClientes.Text = "Agregar"
        Me.BTN_agregarClientes.UseVisualStyleBackColor = True
        '
        'TB_buscarClientes
        '
        Me.TB_buscarClientes.Location = New System.Drawing.Point(711, 51)
        Me.TB_buscarClientes.Name = "TB_buscarClientes"
        Me.TB_buscarClientes.Size = New System.Drawing.Size(230, 22)
        Me.TB_buscarClientes.TabIndex = 5
        '
        'DGV_clientes
        '
        Me.DGV_clientes.AllowUserToAddRows = False
        Me.DGV_clientes.AllowUserToDeleteRows = False
        Me.DGV_clientes.AllowUserToResizeColumns = False
        Me.DGV_clientes.AllowUserToResizeRows = False
        Me.DGV_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_C, Me.Telefono_C, Me.Correo_C})
        Me.DGV_clientes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_clientes.Location = New System.Drawing.Point(318, 84)
        Me.DGV_clientes.MultiSelect = False
        Me.DGV_clientes.Name = "DGV_clientes"
        Me.DGV_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_clientes.Size = New System.Drawing.Size(623, 291)
        Me.DGV_clientes.StandardTab = True
        Me.DGV_clientes.TabIndex = 3
        '
        'Nombre_C
        '
        Me.Nombre_C.HeaderText = "Nombre"
        Me.Nombre_C.Name = "Nombre_C"
        Me.Nombre_C.ReadOnly = True
        '
        'Telefono_C
        '
        Me.Telefono_C.HeaderText = "Télefono"
        Me.Telefono_C.Name = "Telefono_C"
        Me.Telefono_C.ReadOnly = True
        '
        'Correo_C
        '
        Me.Correo_C.HeaderText = "Correo"
        Me.Correo_C.Name = "Correo_C"
        Me.Correo_C.ReadOnly = True
        '
        'PanelActivos
        '
        Me.PanelActivos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelActivos.Controls.Add(Me.Label2)
        Me.PanelActivos.Controls.Add(Me.GroupBox2)
        Me.PanelActivos.Location = New System.Drawing.Point(24, 71)
        Me.PanelActivos.Name = "PanelActivos"
        Me.PanelActivos.Size = New System.Drawing.Size(1088, 614)
        Me.PanelActivos.TabIndex = 4
        Me.PanelActivos.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(48, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(308, 79)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "ACTIVOS"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.BTN_asignarEquipo_Activos)
        Me.GroupBox2.Controls.Add(Me.BTN_eliminarActivos)
        Me.GroupBox2.Controls.Add(Me.BTN_editarActivos)
        Me.GroupBox2.Controls.Add(Me.BTN_agregarActivos)
        Me.GroupBox2.Controls.Add(Me.TB_buscarActivos)
        Me.GroupBox2.Controls.Add(Me.DGV_Activos)
        Me.GroupBox2.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(62, 137)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(964, 430)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        '
        'BTN_asignarEquipo_Activos
        '
        Me.BTN_asignarEquipo_Activos.Location = New System.Drawing.Point(832, 384)
        Me.BTN_asignarEquipo_Activos.Name = "BTN_asignarEquipo_Activos"
        Me.BTN_asignarEquipo_Activos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarEquipo_Activos.TabIndex = 8
        Me.BTN_asignarEquipo_Activos.Text = "Asignar equipo"
        Me.BTN_asignarEquipo_Activos.UseVisualStyleBackColor = True
        '
        'BTN_eliminarActivos
        '
        Me.BTN_eliminarActivos.Location = New System.Drawing.Point(83, 250)
        Me.BTN_eliminarActivos.Name = "BTN_eliminarActivos"
        Me.BTN_eliminarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarActivos.TabIndex = 7
        Me.BTN_eliminarActivos.Text = "Eliminar"
        Me.BTN_eliminarActivos.UseVisualStyleBackColor = True
        '
        'BTN_editarActivos
        '
        Me.BTN_editarActivos.Location = New System.Drawing.Point(83, 205)
        Me.BTN_editarActivos.Name = "BTN_editarActivos"
        Me.BTN_editarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarActivos.TabIndex = 6
        Me.BTN_editarActivos.Text = "Editar"
        Me.BTN_editarActivos.UseVisualStyleBackColor = True
        '
        'BTN_agregarActivos
        '
        Me.BTN_agregarActivos.Location = New System.Drawing.Point(83, 157)
        Me.BTN_agregarActivos.Name = "BTN_agregarActivos"
        Me.BTN_agregarActivos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarActivos.TabIndex = 3
        Me.BTN_agregarActivos.Text = "Agregar"
        Me.BTN_agregarActivos.UseVisualStyleBackColor = True
        '
        'TB_buscarActivos
        '
        Me.TB_buscarActivos.Location = New System.Drawing.Point(711, 51)
        Me.TB_buscarActivos.Name = "TB_buscarActivos"
        Me.TB_buscarActivos.Size = New System.Drawing.Size(230, 22)
        Me.TB_buscarActivos.TabIndex = 5
        '
        'DGV_Activos
        '
        Me.DGV_Activos.AllowUserToAddRows = False
        Me.DGV_Activos.AllowUserToDeleteRows = False
        Me.DGV_Activos.AllowUserToResizeColumns = False
        Me.DGV_Activos.AllowUserToResizeRows = False
        Me.DGV_Activos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Activos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Activos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Placa_A, Me.Chasis_A, Me.Tipo_A, Me.Marca_A, Me.Modelo_A, Me.Color_A, Me.Anio_A})
        Me.DGV_Activos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Activos.Location = New System.Drawing.Point(318, 84)
        Me.DGV_Activos.MultiSelect = False
        Me.DGV_Activos.Name = "DGV_Activos"
        Me.DGV_Activos.ReadOnly = True
        Me.DGV_Activos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Activos.Size = New System.Drawing.Size(623, 294)
        Me.DGV_Activos.StandardTab = True
        Me.DGV_Activos.TabIndex = 3
        '
        'Placa_A
        '
        Me.Placa_A.HeaderText = "Placa"
        Me.Placa_A.Name = "Placa_A"
        Me.Placa_A.ReadOnly = True
        '
        'Chasis_A
        '
        Me.Chasis_A.HeaderText = "Chásis"
        Me.Chasis_A.Name = "Chasis_A"
        Me.Chasis_A.ReadOnly = True
        '
        'Tipo_A
        '
        Me.Tipo_A.HeaderText = "Tipo"
        Me.Tipo_A.Name = "Tipo_A"
        Me.Tipo_A.ReadOnly = True
        '
        'Marca_A
        '
        Me.Marca_A.HeaderText = "Marca"
        Me.Marca_A.Name = "Marca_A"
        Me.Marca_A.ReadOnly = True
        '
        'Modelo_A
        '
        Me.Modelo_A.HeaderText = "Modelo"
        Me.Modelo_A.Name = "Modelo_A"
        Me.Modelo_A.ReadOnly = True
        '
        'Color_A
        '
        Me.Color_A.HeaderText = "Color"
        Me.Color_A.Name = "Color_A"
        Me.Color_A.ReadOnly = True
        '
        'Anio_A
        '
        Me.Anio_A.HeaderText = "Año"
        Me.Anio_A.Name = "Anio_A"
        Me.Anio_A.ReadOnly = True
        '
        'PanelEquipos
        '
        Me.PanelEquipos.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelEquipos.Controls.Add(Me.Label3)
        Me.PanelEquipos.Controls.Add(Me.GroupBox3)
        Me.PanelEquipos.Location = New System.Drawing.Point(44, 55)
        Me.PanelEquipos.Name = "PanelEquipos"
        Me.PanelEquipos.Size = New System.Drawing.Size(1088, 614)
        Me.PanelEquipos.TabIndex = 5
        Me.PanelEquipos.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(48, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(324, 79)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "EQUIPOS"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.BTN_asignarSIM_Equipos)
        Me.GroupBox3.Controls.Add(Me.BTN_bajaEquipos)
        Me.GroupBox3.Controls.Add(Me.BTN_agregarEquipos)
        Me.GroupBox3.Controls.Add(Me.TB_buscarEquipos)
        Me.GroupBox3.Controls.Add(Me.DGV_Equipos)
        Me.GroupBox3.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(62, 137)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(964, 430)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        '
        'BTN_asignarSIM_Equipos
        '
        Me.BTN_asignarSIM_Equipos.Location = New System.Drawing.Point(832, 381)
        Me.BTN_asignarSIM_Equipos.Name = "BTN_asignarSIM_Equipos"
        Me.BTN_asignarSIM_Equipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_asignarSIM_Equipos.TabIndex = 8
        Me.BTN_asignarSIM_Equipos.Text = "Asignar SIM"
        Me.BTN_asignarSIM_Equipos.UseVisualStyleBackColor = True
        '
        'BTN_bajaEquipos
        '
        Me.BTN_bajaEquipos.Location = New System.Drawing.Point(83, 206)
        Me.BTN_bajaEquipos.Name = "BTN_bajaEquipos"
        Me.BTN_bajaEquipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_bajaEquipos.TabIndex = 7
        Me.BTN_bajaEquipos.Text = "Dar de baja"
        Me.BTN_bajaEquipos.UseVisualStyleBackColor = True
        '
        'BTN_agregarEquipos
        '
        Me.BTN_agregarEquipos.Location = New System.Drawing.Point(83, 157)
        Me.BTN_agregarEquipos.Name = "BTN_agregarEquipos"
        Me.BTN_agregarEquipos.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarEquipos.TabIndex = 3
        Me.BTN_agregarEquipos.Text = "Agregar"
        Me.BTN_agregarEquipos.UseVisualStyleBackColor = True
        '
        'TB_buscarEquipos
        '
        Me.TB_buscarEquipos.Location = New System.Drawing.Point(711, 51)
        Me.TB_buscarEquipos.Name = "TB_buscarEquipos"
        Me.TB_buscarEquipos.Size = New System.Drawing.Size(230, 22)
        Me.TB_buscarEquipos.TabIndex = 5
        '
        'DGV_Equipos
        '
        Me.DGV_Equipos.AllowUserToAddRows = False
        Me.DGV_Equipos.AllowUserToDeleteRows = False
        Me.DGV_Equipos.AllowUserToResizeColumns = False
        Me.DGV_Equipos.AllowUserToResizeRows = False
        Me.DGV_Equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI_E, Me.Modelo_E, Me.Marca_E})
        Me.DGV_Equipos.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Equipos.Location = New System.Drawing.Point(318, 84)
        Me.DGV_Equipos.MultiSelect = False
        Me.DGV_Equipos.Name = "DGV_Equipos"
        Me.DGV_Equipos.ReadOnly = True
        Me.DGV_Equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Equipos.Size = New System.Drawing.Size(623, 291)
        Me.DGV_Equipos.StandardTab = True
        Me.DGV_Equipos.TabIndex = 3
        '
        'IMEI_E
        '
        Me.IMEI_E.HeaderText = "IMEI"
        Me.IMEI_E.Name = "IMEI_E"
        Me.IMEI_E.ReadOnly = True
        '
        'Modelo_E
        '
        Me.Modelo_E.HeaderText = "Modelo"
        Me.Modelo_E.Name = "Modelo_E"
        Me.Modelo_E.ReadOnly = True
        '
        'Marca_E
        '
        Me.Marca_E.HeaderText = "Marca"
        Me.Marca_E.Name = "Marca_E"
        Me.Marca_E.ReadOnly = True
        '
        'PanelSIM
        '
        Me.PanelSIM.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelSIM.Controls.Add(Me.Label4)
        Me.PanelSIM.Controls.Add(Me.GroupBox4)
        Me.PanelSIM.Location = New System.Drawing.Point(62, 42)
        Me.PanelSIM.Name = "PanelSIM"
        Me.PanelSIM.Size = New System.Drawing.Size(1088, 614)
        Me.PanelSIM.TabIndex = 6
        Me.PanelSIM.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(48, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 79)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "SIM"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox4.Controls.Add(Me.Button1)
        Me.GroupBox4.Controls.Add(Me.BTN_eliminarSim)
        Me.GroupBox4.Controls.Add(Me.BTN_editarSIM)
        Me.GroupBox4.Controls.Add(Me.Button14)
        Me.GroupBox4.Controls.Add(Me.TB_buscarSim)
        Me.GroupBox4.Controls.Add(Me.DGV_Sim)
        Me.GroupBox4.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox4.Location = New System.Drawing.Point(62, 137)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(964, 430)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(831, 384)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(109, 27)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Migrar SIM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'BTN_eliminarSim
        '
        Me.BTN_eliminarSim.Location = New System.Drawing.Point(83, 250)
        Me.BTN_eliminarSim.Name = "BTN_eliminarSim"
        Me.BTN_eliminarSim.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarSim.TabIndex = 7
        Me.BTN_eliminarSim.Text = "Eliminar"
        Me.BTN_eliminarSim.UseVisualStyleBackColor = True
        '
        'BTN_editarSIM
        '
        Me.BTN_editarSIM.Location = New System.Drawing.Point(83, 205)
        Me.BTN_editarSIM.Name = "BTN_editarSIM"
        Me.BTN_editarSIM.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarSIM.TabIndex = 6
        Me.BTN_editarSIM.Text = "Editar"
        Me.BTN_editarSIM.UseVisualStyleBackColor = True
        '
        'Button14
        '
        Me.Button14.Location = New System.Drawing.Point(83, 157)
        Me.Button14.Name = "Button14"
        Me.Button14.Size = New System.Drawing.Size(109, 27)
        Me.Button14.TabIndex = 3
        Me.Button14.Text = "Agregar"
        Me.Button14.UseVisualStyleBackColor = True
        '
        'TB_buscarSim
        '
        Me.TB_buscarSim.Location = New System.Drawing.Point(711, 51)
        Me.TB_buscarSim.Name = "TB_buscarSim"
        Me.TB_buscarSim.Size = New System.Drawing.Size(230, 22)
        Me.TB_buscarSim.TabIndex = 5
        '
        'DGV_Sim
        '
        Me.DGV_Sim.AllowUserToAddRows = False
        Me.DGV_Sim.AllowUserToDeleteRows = False
        Me.DGV_Sim.AllowUserToResizeColumns = False
        Me.DGV_Sim.AllowUserToResizeRows = False
        Me.DGV_Sim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Sim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICC_S, Me.Numero_S, Me.Propietario_S, Me.Vence_S, Me.Plan_Datos_S, Me.Compania_S})
        Me.DGV_Sim.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Sim.Location = New System.Drawing.Point(318, 84)
        Me.DGV_Sim.MultiSelect = False
        Me.DGV_Sim.Name = "DGV_Sim"
        Me.DGV_Sim.ReadOnly = True
        Me.DGV_Sim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Sim.Size = New System.Drawing.Size(623, 288)
        Me.DGV_Sim.StandardTab = True
        Me.DGV_Sim.TabIndex = 3
        '
        'ICC_S
        '
        Me.ICC_S.HeaderText = "ICC"
        Me.ICC_S.Name = "ICC_S"
        Me.ICC_S.ReadOnly = True
        '
        'Numero_S
        '
        Me.Numero_S.HeaderText = "Numero"
        Me.Numero_S.Name = "Numero_S"
        Me.Numero_S.ReadOnly = True
        '
        'Propietario_S
        '
        Me.Propietario_S.HeaderText = "Propietario"
        Me.Propietario_S.Name = "Propietario_S"
        Me.Propietario_S.ReadOnly = True
        '
        'Vence_S
        '
        Me.Vence_S.HeaderText = "Vence"
        Me.Vence_S.Name = "Vence_S"
        Me.Vence_S.ReadOnly = True
        '
        'Plan_Datos_S
        '
        Me.Plan_Datos_S.HeaderText = "Plan de datos"
        Me.Plan_Datos_S.Name = "Plan_Datos_S"
        Me.Plan_Datos_S.ReadOnly = True
        '
        'Compania_S
        '
        Me.Compania_S.HeaderText = "Compañia"
        Me.Compania_S.Name = "Compania_S"
        Me.Compania_S.ReadOnly = True
        '
        'PanelUsuario
        '
        Me.PanelUsuario.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.PanelUsuario.Controls.Add(Me.Label5)
        Me.PanelUsuario.Controls.Add(Me.GroupBox5)
        Me.PanelUsuario.Location = New System.Drawing.Point(86, 22)
        Me.PanelUsuario.Name = "PanelUsuario"
        Me.PanelUsuario.Size = New System.Drawing.Size(1088, 614)
        Me.PanelUsuario.TabIndex = 7
        Me.PanelUsuario.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(48, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(366, 79)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "USUARIOS"
        '
        'GroupBox5
        '
        Me.GroupBox5.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox5.Controls.Add(Me.BTN_eliminarUsuarios)
        Me.GroupBox5.Controls.Add(Me.BTN_editarUsuario)
        Me.GroupBox5.Controls.Add(Me.BTN_agregarUsuario)
        Me.GroupBox5.Controls.Add(Me.TB_buscarUsuario)
        Me.GroupBox5.Controls.Add(Me.DGV_Usuarios)
        Me.GroupBox5.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox5.Location = New System.Drawing.Point(62, 137)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(964, 430)
        Me.GroupBox5.TabIndex = 3
        Me.GroupBox5.TabStop = False
        '
        'BTN_eliminarUsuarios
        '
        Me.BTN_eliminarUsuarios.Location = New System.Drawing.Point(83, 250)
        Me.BTN_eliminarUsuarios.Name = "BTN_eliminarUsuarios"
        Me.BTN_eliminarUsuarios.Size = New System.Drawing.Size(109, 27)
        Me.BTN_eliminarUsuarios.TabIndex = 7
        Me.BTN_eliminarUsuarios.Text = "Eliminar"
        Me.BTN_eliminarUsuarios.UseVisualStyleBackColor = True
        '
        'BTN_editarUsuario
        '
        Me.BTN_editarUsuario.Location = New System.Drawing.Point(83, 205)
        Me.BTN_editarUsuario.Name = "BTN_editarUsuario"
        Me.BTN_editarUsuario.Size = New System.Drawing.Size(109, 27)
        Me.BTN_editarUsuario.TabIndex = 6
        Me.BTN_editarUsuario.Text = "Editar"
        Me.BTN_editarUsuario.UseVisualStyleBackColor = True
        '
        'BTN_agregarUsuario
        '
        Me.BTN_agregarUsuario.Location = New System.Drawing.Point(83, 157)
        Me.BTN_agregarUsuario.Name = "BTN_agregarUsuario"
        Me.BTN_agregarUsuario.Size = New System.Drawing.Size(109, 27)
        Me.BTN_agregarUsuario.TabIndex = 3
        Me.BTN_agregarUsuario.Text = "Agregar"
        Me.BTN_agregarUsuario.UseVisualStyleBackColor = True
        '
        'TB_buscarUsuario
        '
        Me.TB_buscarUsuario.Location = New System.Drawing.Point(711, 51)
        Me.TB_buscarUsuario.Name = "TB_buscarUsuario"
        Me.TB_buscarUsuario.Size = New System.Drawing.Size(230, 22)
        Me.TB_buscarUsuario.TabIndex = 5
        '
        'DGV_Usuarios
        '
        Me.DGV_Usuarios.AllowUserToAddRows = False
        Me.DGV_Usuarios.AllowUserToDeleteRows = False
        Me.DGV_Usuarios.AllowUserToResizeColumns = False
        Me.DGV_Usuarios.AllowUserToResizeRows = False
        Me.DGV_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_Usuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nombre_U, Me.Rol_U})
        Me.DGV_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.DGV_Usuarios.Location = New System.Drawing.Point(318, 84)
        Me.DGV_Usuarios.MultiSelect = False
        Me.DGV_Usuarios.Name = "DGV_Usuarios"
        Me.DGV_Usuarios.ReadOnly = True
        Me.DGV_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_Usuarios.Size = New System.Drawing.Size(623, 308)
        Me.DGV_Usuarios.StandardTab = True
        Me.DGV_Usuarios.TabIndex = 3
        '
        'Nombre_U
        '
        Me.Nombre_U.HeaderText = "Nombre"
        Me.Nombre_U.Name = "Nombre_U"
        Me.Nombre_U.ReadOnly = True
        '
        'Rol_U
        '
        Me.Rol_U.HeaderText = "Rol"
        Me.Rol_U.Name = "Rol_U"
        Me.Rol_U.ReadOnly = True
        '
        'FormAdmin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1091, 671)
        Me.Controls.Add(Me.PanelUsuario)
        Me.Controls.Add(Me.PanelSIM)
        Me.Controls.Add(Me.PanelEquipos)
        Me.Controls.Add(Me.PanelActivos)
        Me.Controls.Add(Me.PanelCliente)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FormAdmin"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Administración"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.PanelCliente.ResumeLayout(False)
        Me.PanelCliente.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelActivos.ResumeLayout(False)
        Me.PanelActivos.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGV_Activos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelEquipos.ResumeLayout(False)
        Me.PanelEquipos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DGV_Equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSIM.ResumeLayout(False)
        Me.PanelSIM.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.DGV_Sim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelUsuario.ResumeLayout(False)
        Me.PanelUsuario.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.DGV_Usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ActivosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BajaDeEquiposToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SIMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MigracionesDeSIMToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SallirToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PanelCliente As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents BTN_eliminarClientes As Button
    Friend WithEvents BTN_editarClientes As Button
    Friend WithEvents BTN_agregarClientes As Button
    Friend WithEvents TB_buscarClientes As TextBox
    Friend WithEvents DGV_clientes As DataGridView
    Friend WithEvents PanelActivos As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents BTN_eliminarActivos As Button
    Friend WithEvents BTN_editarActivos As Button
    Friend WithEvents BTN_agregarActivos As Button
    Friend WithEvents TB_buscarActivos As TextBox
    Friend WithEvents DGV_Activos As DataGridView
    Friend WithEvents PanelEquipos As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BTN_bajaEquipos As Button
    Friend WithEvents BTN_agregarEquipos As Button
    Friend WithEvents TB_buscarEquipos As TextBox
    Friend WithEvents DGV_Equipos As DataGridView
    Friend WithEvents Nombre_C As DataGridViewTextBoxColumn
    Friend WithEvents Telefono_C As DataGridViewTextBoxColumn
    Friend WithEvents Correo_C As DataGridViewTextBoxColumn
    Friend WithEvents IMEI_E As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_E As DataGridViewTextBoxColumn
    Friend WithEvents Marca_E As DataGridViewTextBoxColumn
    Friend WithEvents PanelSIM As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents BTN_eliminarSim As Button
    Friend WithEvents BTN_editarSIM As Button
    Friend WithEvents Button14 As Button
    Friend WithEvents TB_buscarSim As TextBox
    Friend WithEvents DGV_Sim As DataGridView
    Friend WithEvents ICC_S As DataGridViewTextBoxColumn
    Friend WithEvents Numero_S As DataGridViewTextBoxColumn
    Friend WithEvents Propietario_S As DataGridViewTextBoxColumn
    Friend WithEvents Vence_S As DataGridViewTextBoxColumn
    Friend WithEvents Plan_Datos_S As DataGridViewTextBoxColumn
    Friend WithEvents Compania_S As DataGridViewTextBoxColumn
    Friend WithEvents PanelUsuario As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents BTN_eliminarUsuarios As Button
    Friend WithEvents BTN_editarUsuario As Button
    Friend WithEvents BTN_agregarUsuario As Button
    Friend WithEvents TB_buscarUsuario As TextBox
    Friend WithEvents DGV_Usuarios As DataGridView
    Friend WithEvents Nombre_U As DataGridViewTextBoxColumn
    Friend WithEvents Rol_U As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents BTN_asignarActivo_Clientes As Button
    Friend WithEvents BTN_asignarEquipo_Activos As Button
    Friend WithEvents BTN_asignarSIM_Equipos As Button
    Friend WithEvents Placa_A As DataGridViewTextBoxColumn
    Friend WithEvents Chasis_A As DataGridViewTextBoxColumn
    Friend WithEvents Tipo_A As DataGridViewTextBoxColumn
    Friend WithEvents Marca_A As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_A As DataGridViewTextBoxColumn
    Friend WithEvents Color_A As DataGridViewTextBoxColumn
    Friend WithEvents Anio_A As DataGridViewTextBoxColumn
End Class
