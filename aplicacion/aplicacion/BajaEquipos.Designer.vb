<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BajaEquipos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
<<<<<<< Updated upstream
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IMEI_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(608, 177)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 28)
        Me.TB_buscarBajaEquipo.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(109, 64)
=======
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_bajaEquipos = New System.Windows.Forms.DataGridView()
        Me.IMEI_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TB_buscarBajaEquipo = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(75, 41)
>>>>>>> Stashed changes
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 73)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BAJAS DE EQUIPOS"
        '
        'BTN_regresar
        '
<<<<<<< Updated upstream
        Me.BTN_regresar.Location = New System.Drawing.Point(43, 35)
=======
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
>>>>>>> Stashed changes
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
<<<<<<< Updated upstream
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(458, 179)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 26)
        Me.Button1.TabIndex = 37
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI_bajaEquipo, Me.Modelo_bajaEquipo, Me.Marca_bajaEquipo})
        Me.DataGridView1.Location = New System.Drawing.Point(90, 231)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 259)
        Me.DataGridView1.TabIndex = 38
=======
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.DGV_bajaEquipos)
        Me.Panel1.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Panel1.Location = New System.Drawing.Point(12, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 340)
        Me.Panel1.TabIndex = 39
        '
        'DGV_bajaEquipos
        '
        Me.DGV_bajaEquipos.AllowUserToAddRows = False
        Me.DGV_bajaEquipos.AllowUserToDeleteRows = False
        Me.DGV_bajaEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_bajaEquipos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_bajaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bajaEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI_bajaEquipo, Me.Modelo_bajaEquipo, Me.Marca_bajaEquipo})
        Me.DGV_bajaEquipos.Location = New System.Drawing.Point(35, 68)
        Me.DGV_bajaEquipos.Name = "DGV_bajaEquipos"
        Me.DGV_bajaEquipos.ReadOnly = True
        Me.DGV_bajaEquipos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_bajaEquipos.Size = New System.Drawing.Size(729, 259)
        Me.DGV_bajaEquipos.TabIndex = 40
>>>>>>> Stashed changes
        '
        'IMEI_bajaEquipo
        '
        Me.IMEI_bajaEquipo.HeaderText = "IMEI"
        Me.IMEI_bajaEquipo.Name = "IMEI_bajaEquipo"
        Me.IMEI_bajaEquipo.ReadOnly = True
        '
        'Modelo_bajaEquipo
        '
        Me.Modelo_bajaEquipo.HeaderText = "Modelo"
        Me.Modelo_bajaEquipo.Name = "Modelo_bajaEquipo"
        Me.Modelo_bajaEquipo.ReadOnly = True
        '
        'Marca_bajaEquipo
        '
        Me.Marca_bajaEquipo.HeaderText = "Marca"
        Me.Marca_bajaEquipo.Name = "Marca_bajaEquipo"
        Me.Marca_bajaEquipo.ReadOnly = True
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(553, 14)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 22)
        Me.TB_buscarBajaEquipo.TabIndex = 39
        '
        'BajaEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
=======
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.Panel1)
>>>>>>> Stashed changes
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BajaEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de equipos"
<<<<<<< Updated upstream
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
=======
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).EndInit()
>>>>>>> Stashed changes
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
<<<<<<< Updated upstream
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
=======
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_bajaEquipos As DataGridView
>>>>>>> Stashed changes
    Friend WithEvents IMEI_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Marca_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents TB_buscarBajaEquipo As TextBox
End Class
