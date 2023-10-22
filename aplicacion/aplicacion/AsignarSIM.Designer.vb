<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AsignarSIM
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.DTV_Equipos = New System.Windows.Forms.DataGridView()
        Me.imeiEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ModeloEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MarcaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LB_equipoSeleccionado = New System.Windows.Forms.Label()
        Me.BTN_seleccionarEquipo = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.BTN_buscarEquipo = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.LB_simSeleccionado = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BTN_seleccionarSim = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BTN_buscarSIM = New System.Windows.Forms.Button()
        Me.DTV_SIM = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BTN_desasignarEquipo = New System.Windows.Forms.Button()
        Me.DTV_Asignacion = New System.Windows.Forms.DataGridView()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.BTN_buscarAsignacion = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_asignar = New System.Windows.Forms.Button()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ICCSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompaniaSim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMEIAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Espacio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICCAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NumeroAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PropietarioAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CompaniaAsignacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel6.SuspendLayout()
        CType(Me.DTV_Equipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel5.SuspendLayout()
        CType(Me.DTV_SIM, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.DTV_Asignacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.DTV_Equipos)
        Me.Panel6.Controls.Add(Me.LB_equipoSeleccionado)
        Me.Panel6.Controls.Add(Me.BTN_seleccionarEquipo)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.TextBox2)
        Me.Panel6.Controls.Add(Me.BTN_buscarEquipo)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Location = New System.Drawing.Point(12, 61)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(479, 288)
        Me.Panel6.TabIndex = 38
        '
        'DTV_Equipos
        '
<<<<<<< Updated upstream
        Me.DTV_Equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTV_Equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTV_Equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imeiEquipo, Me.ModeloEquipo, Me.MarcaEquipo})
        Me.DTV_Equipos.Location = New System.Drawing.Point(22, 30)
        Me.DTV_Equipos.Name = "DTV_Equipos"
        Me.DTV_Equipos.Size = New System.Drawing.Size(440, 217)
        Me.DTV_Equipos.TabIndex = 33
=======
        Me.DGV_equipos.AllowUserToAddRows = False
        Me.DGV_equipos.AllowUserToDeleteRows = False
        Me.DGV_equipos.AllowUserToResizeRows = False
        Me.DGV_equipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_equipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_equipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_equipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.imeiEquipo, Me.ModeloEquipo, Me.MarcaEquipo})
        Me.DGV_equipos.Location = New System.Drawing.Point(19, 41)
        Me.DGV_equipos.Name = "DGV_equipos"
        Me.DGV_equipos.ReadOnly = True
        Me.DGV_equipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_equipos.Size = New System.Drawing.Size(440, 202)
        Me.DGV_equipos.TabIndex = 33
>>>>>>> Stashed changes
        '
        'imeiEquipo
        '
        Me.imeiEquipo.HeaderText = "IMEI"
        Me.imeiEquipo.Name = "imeiEquipo"
        '
        'ModeloEquipo
        '
        Me.ModeloEquipo.HeaderText = "Modelo"
        Me.ModeloEquipo.Name = "ModeloEquipo"
        '
        'MarcaEquipo
        '
        Me.MarcaEquipo.HeaderText = "Marca"
        Me.MarcaEquipo.Name = "MarcaEquipo"
        '
        'LB_equipoSeleccionado
        '
        Me.LB_equipoSeleccionado.AutoSize = True
<<<<<<< Updated upstream
        Me.LB_equipoSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_equipoSeleccionado.Location = New System.Drawing.Point(161, 260)
        Me.LB_equipoSeleccionado.Name = "LB_equipoSeleccionado"
        Me.LB_equipoSeleccionado.Size = New System.Drawing.Size(76, 16)
=======
        Me.LB_equipoSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_equipoSeleccionado.Location = New System.Drawing.Point(160, 253)
        Me.LB_equipoSeleccionado.Name = "LB_equipoSeleccionado"
        Me.LB_equipoSeleccionado.Size = New System.Drawing.Size(104, 15)
>>>>>>> Stashed changes
        Me.LB_equipoSeleccionado.TabIndex = 32
        Me.LB_equipoSeleccionado.Text = "No seleccionado"
        '
        'BTN_seleccionarEquipo
        '
        Me.BTN_seleccionarEquipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarEquipo.Location = New System.Drawing.Point(371, 253)
        Me.BTN_seleccionarEquipo.Name = "BTN_seleccionarEquipo"
        Me.BTN_seleccionarEquipo.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarEquipo.TabIndex = 31
        Me.BTN_seleccionarEquipo.Text = "Seleccionar"
        Me.BTN_seleccionarEquipo.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(19, 260)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(138, 16)
        Me.Label7.TabIndex = 31
        Me.Label7.Text = "Equipo seleccionado:"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(294, 1)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(168, 24)
        Me.TextBox2.TabIndex = 30
        '
        'BTN_buscarEquipo
        '
        Me.BTN_buscarEquipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_buscarEquipo.Location = New System.Drawing.Point(213, 0)
        Me.BTN_buscarEquipo.Name = "BTN_buscarEquipo"
        Me.BTN_buscarEquipo.Size = New System.Drawing.Size(75, 23)
        Me.BTN_buscarEquipo.TabIndex = 29
        Me.BTN_buscarEquipo.Text = "Buscar"
        Me.BTN_buscarEquipo.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(18, 1)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 19)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Equipos"
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.LB_simSeleccionado)
        Me.Panel5.Controls.Add(Me.Label4)
        Me.Panel5.Controls.Add(Me.BTN_seleccionarSim)
        Me.Panel5.Controls.Add(Me.TextBox1)
        Me.Panel5.Controls.Add(Me.BTN_buscarSIM)
        Me.Panel5.Controls.Add(Me.DTV_SIM)
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Location = New System.Drawing.Point(497, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(475, 288)
        Me.Panel5.TabIndex = 37
        '
        'LB_simSeleccionado
        '
        Me.LB_simSeleccionado.AutoSize = True
<<<<<<< Updated upstream
        Me.LB_simSeleccionado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_simSeleccionado.Location = New System.Drawing.Point(158, 260)
        Me.LB_simSeleccionado.Name = "LB_simSeleccionado"
        Me.LB_simSeleccionado.Size = New System.Drawing.Size(76, 16)
=======
        Me.LB_simSeleccionado.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LB_simSeleccionado.Location = New System.Drawing.Point(151, 253)
        Me.LB_simSeleccionado.Name = "LB_simSeleccionado"
        Me.LB_simSeleccionado.Size = New System.Drawing.Size(104, 15)
>>>>>>> Stashed changes
        Me.LB_simSeleccionado.TabIndex = 30
        Me.LB_simSeleccionado.Text = "No seleccionado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 260)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(132, 16)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Activo seleccionado:"
        '
        'BTN_seleccionarSim
        '
        Me.BTN_seleccionarSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_seleccionarSim.Location = New System.Drawing.Point(368, 253)
        Me.BTN_seleccionarSim.Name = "BTN_seleccionarSim"
        Me.BTN_seleccionarSim.Size = New System.Drawing.Size(91, 23)
        Me.BTN_seleccionarSim.TabIndex = 29
        Me.BTN_seleccionarSim.Text = "Seleccionar"
        Me.BTN_seleccionarSim.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(291, 1)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(168, 24)
        Me.TextBox1.TabIndex = 28
        '
        'BTN_buscarSIM
        '
<<<<<<< Updated upstream
        Me.BTN_buscarSIM.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_buscarSIM.Location = New System.Drawing.Point(210, 0)
        Me.BTN_buscarSIM.Name = "BTN_buscarSIM"
        Me.BTN_buscarSIM.Size = New System.Drawing.Size(75, 23)
        Me.BTN_buscarSIM.TabIndex = 27
        Me.BTN_buscarSIM.Text = "Buscar"
        Me.BTN_buscarSIM.UseVisualStyleBackColor = True
=======
        Me.DGV_sim.AllowUserToAddRows = False
        Me.DGV_sim.AllowUserToDeleteRows = False
        Me.DGV_sim.AllowUserToResizeRows = False
        Me.DGV_sim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_sim.BackgroundColor = System.Drawing.Color.White
        Me.DGV_sim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_sim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICCSim, Me.NumeroSim, Me.PropietarioSim, Me.CompaniaSim})
        Me.DGV_sim.Location = New System.Drawing.Point(19, 41)
        Me.DGV_sim.Name = "DGV_sim"
        Me.DGV_sim.ReadOnly = True
        Me.DGV_sim.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_sim.Size = New System.Drawing.Size(440, 202)
        Me.DGV_sim.TabIndex = 30
>>>>>>> Stashed changes
        '
        'DTV_SIM
        '
        Me.DTV_SIM.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTV_SIM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTV_SIM.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICCSim, Me.NumeroSim, Me.PropietarioSim, Me.CompaniaSim})
        Me.DTV_SIM.Location = New System.Drawing.Point(19, 30)
        Me.DTV_SIM.Name = "DTV_SIM"
        Me.DTV_SIM.Size = New System.Drawing.Size(440, 217)
        Me.DTV_SIM.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(15, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(37, 19)
        Me.Label2.TabIndex = 27
        Me.Label2.Text = "SIM:"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.BTN_desasignarEquipo)
        Me.Panel3.Controls.Add(Me.DTV_Asignacion)
        Me.Panel3.Controls.Add(Me.TextBox3)
        Me.Panel3.Controls.Add(Me.BTN_buscarAsignacion)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Location = New System.Drawing.Point(12, 387)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(960, 260)
        Me.Panel3.TabIndex = 34
        '
        'BTN_desasignarEquipo
        '
        Me.BTN_desasignarEquipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_desasignarEquipo.Location = New System.Drawing.Point(775, 234)
        Me.BTN_desasignarEquipo.Name = "BTN_desasignarEquipo"
        Me.BTN_desasignarEquipo.Size = New System.Drawing.Size(127, 23)
        Me.BTN_desasignarEquipo.TabIndex = 35
        Me.BTN_desasignarEquipo.Text = "Desasignar SIM"
        Me.BTN_desasignarEquipo.UseVisualStyleBackColor = True
        '
        'DTV_Asignacion
        '
<<<<<<< Updated upstream
        Me.DTV_Asignacion.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DTV_Asignacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DTV_Asignacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEIAsignacion, Me.Espacio, Me.ICCAsignacion, Me.NumeroAsignacion, Me.PropietarioAsignacion, Me.CompaniaAsignacion})
        Me.DTV_Asignacion.Location = New System.Drawing.Point(69, 48)
        Me.DTV_Asignacion.Name = "DTV_Asignacion"
        Me.DTV_Asignacion.Size = New System.Drawing.Size(833, 180)
        Me.DTV_Asignacion.TabIndex = 34
=======
        Me.DGV_asignaciones.AllowUserToAddRows = False
        Me.DGV_asignaciones.AllowUserToDeleteRows = False
        Me.DGV_asignaciones.AllowUserToResizeRows = False
        Me.DGV_asignaciones.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_asignaciones.BackgroundColor = System.Drawing.Color.White
        Me.DGV_asignaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_asignaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEIAsignacion, Me.ICCAsignacion, Me.NumeroAsignacion, Me.PropietarioAsignacion, Me.CompaniaAsignacion})
        Me.DGV_asignaciones.Location = New System.Drawing.Point(87, 43)
        Me.DGV_asignaciones.Name = "DGV_asignaciones"
        Me.DGV_asignaciones.ReadOnly = True
        Me.DGV_asignaciones.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_asignaciones.Size = New System.Drawing.Size(833, 208)
        Me.DGV_asignaciones.TabIndex = 34
>>>>>>> Stashed changes
        '
        'TextBox3
        '
        Me.TextBox3.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox3.Location = New System.Drawing.Point(734, 18)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(168, 24)
        Me.TextBox3.TabIndex = 33
        '
        'BTN_buscarAsignacion
        '
        Me.BTN_buscarAsignacion.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_buscarAsignacion.Location = New System.Drawing.Point(653, 17)
        Me.BTN_buscarAsignacion.Name = "BTN_buscarAsignacion"
        Me.BTN_buscarAsignacion.Size = New System.Drawing.Size(75, 23)
        Me.BTN_buscarAsignacion.TabIndex = 32
        Me.BTN_buscarAsignacion.Text = "Buscar"
        Me.BTN_buscarAsignacion.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Location = New System.Drawing.Point(0, 311)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(960, 227)
        Me.Panel4.TabIndex = 1
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Panel1.Controls.Add(Me.BTN_asignar)
        Me.Panel1.Location = New System.Drawing.Point(12, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(960, 320)
        Me.Panel1.TabIndex = 33
        '
        'BTN_asignar
        '
        Me.BTN_asignar.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_asignar.Location = New System.Drawing.Point(440, 294)
        Me.BTN_asignar.Name = "BTN_asignar"
        Me.BTN_asignar.Size = New System.Drawing.Size(75, 23)
        Me.BTN_asignar.TabIndex = 29
        Me.BTN_asignar.Text = "Asignar"
        Me.BTN_asignar.UseVisualStyleBackColor = True
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft YaHei UI", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(286, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 46)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "ASIGNACION DE SIM"
        '
        'ICCSim
        '
        Me.ICCSim.HeaderText = "ICC"
        Me.ICCSim.Name = "ICCSim"
        '
        'NumeroSim
        '
        Me.NumeroSim.HeaderText = "Numero"
        Me.NumeroSim.Name = "NumeroSim"
        '
        'PropietarioSim
        '
        Me.PropietarioSim.HeaderText = "Propietario"
        Me.PropietarioSim.Name = "PropietarioSim"
        '
        'CompaniaSim
        '
        Me.CompaniaSim.HeaderText = "Compañia"
        Me.CompaniaSim.Name = "CompaniaSim"
        '
        'IMEIAsignacion
        '
        Me.IMEIAsignacion.HeaderText = "IMEI (Equipo)"
        Me.IMEIAsignacion.Name = "IMEIAsignacion"
        '
        'Espacio
        '
        Me.Espacio.HeaderText = ""
        Me.Espacio.Name = "Espacio"
        '
        'ICCAsignacion
        '
        Me.ICCAsignacion.HeaderText = "ICC"
        Me.ICCAsignacion.Name = "ICCAsignacion"
        '
        'NumeroAsignacion
        '
        Me.NumeroAsignacion.HeaderText = "Numero"
        Me.NumeroAsignacion.Name = "NumeroAsignacion"
        '
        'PropietarioAsignacion
        '
        Me.PropietarioAsignacion.HeaderText = "Propietario"
        Me.PropietarioAsignacion.Name = "PropietarioAsignacion"
        '
        'CompaniaAsignacion
        '
        Me.CompaniaAsignacion.HeaderText = "Compañia"
        Me.CompaniaAsignacion.Name = "CompaniaAsignacion"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(215, 22)
        Me.Label5.TabIndex = 36
        Me.Label5.Text = "SIM asignadas a equipos:"
        '
        'AsignarSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 661)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AsignarSIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Asignacion de SIM"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DTV_Equipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DTV_SIM, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.DTV_Asignacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents DTV_Equipos As DataGridView
    Friend WithEvents imeiEquipo As DataGridViewTextBoxColumn
    Friend WithEvents ModeloEquipo As DataGridViewTextBoxColumn
    Friend WithEvents MarcaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents LB_equipoSeleccionado As Label
    Friend WithEvents BTN_seleccionarEquipo As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents BTN_buscarEquipo As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents LB_simSeleccionado As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents BTN_seleccionarSim As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BTN_buscarSIM As Button
    Friend WithEvents DTV_SIM As DataGridView
    Friend WithEvents ICCSim As DataGridViewTextBoxColumn
    Friend WithEvents NumeroSim As DataGridViewTextBoxColumn
    Friend WithEvents PropietarioSim As DataGridViewTextBoxColumn
    Friend WithEvents CompaniaSim As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BTN_desasignarEquipo As Button
    Friend WithEvents DTV_Asignacion As DataGridView
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents BTN_buscarAsignacion As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_asignar As Button
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents IMEIAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents Espacio As DataGridViewTextBoxColumn
    Friend WithEvents ICCAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents NumeroAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents PropietarioAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents CompaniaAsignacion As DataGridViewTextBoxColumn
    Friend WithEvents Label5 As Label
End Class
