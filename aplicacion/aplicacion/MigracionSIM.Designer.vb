<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MigracionSIM
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
        Me.DGV_migracionesSim = New System.Windows.Forms.DataGridView()
        Me.ICC_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICC_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.TB_buscarSim = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DGV_migracionesSim, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGV_migracionesSim
        '
        Me.DGV_migracionesSim.AllowUserToAddRows = False
        Me.DGV_migracionesSim.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_migracionesSim.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_migracionesSim.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICC_anterior, Me.ICC_actual, Me.Telefono, Me.Propietario, Me.Compania})
        Me.DGV_migracionesSim.Location = New System.Drawing.Point(92, 232)
        Me.DGV_migracionesSim.Name = "DGV_migracionesSim"
        Me.DGV_migracionesSim.Size = New System.Drawing.Size(729, 259)
        Me.DGV_migracionesSim.TabIndex = 43
        '
        'ICC_anterior
        '
        Me.ICC_anterior.HeaderText = "ICC anterior"
        Me.ICC_anterior.Name = "ICC_anterior"
        '
        'ICC_actual
        '
        Me.ICC_actual.HeaderText = "ICC actual"
        Me.ICC_actual.Name = "ICC_actual"
        '
        'Telefono
        '
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        '
        'Propietario
        '
        Me.Propietario.HeaderText = "Propietario"
        Me.Propietario.Name = "Propietario"
        '
        'Compania
        '
        Me.Compania.HeaderText = "Compañia"
        Me.Compania.Name = "Compania"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(92, 35)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 41
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'TB_buscarSim
        '
        Me.TB_buscarSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarSim.Location = New System.Drawing.Point(610, 178)
        Me.TB_buscarSim.Name = "TB_buscarSim"
        Me.TB_buscarSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_buscarSim.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(78, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(658, 79)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "MIGRACION DE SIM"
        '
        'MigracionSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.DGV_migracionesSim)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.TB_buscarSim)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MigracionSIM"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migracion de SIM"
        CType(Me.DGV_migracionesSim, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGV_migracionesSim As DataGridView
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents TB_buscarSim As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ICC_anterior As DataGridViewTextBoxColumn
    Friend WithEvents ICC_actual As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Propietario As DataGridViewTextBoxColumn
    Friend WithEvents Compania As DataGridViewTextBoxColumn
End Class
