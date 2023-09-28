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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BTN_buscar = New System.Windows.Forms.Button()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.TB_buscarBajaEquipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ICC_anterior = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ICC_actual = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Propietario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Compania = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ICC_anterior, Me.ICC_actual, Me.Telefono, Me.Propietario, Me.Compania})
        Me.DataGridView1.Location = New System.Drawing.Point(92, 232)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 259)
        Me.DataGridView1.TabIndex = 43
        '
        'BTN_buscar
        '
        Me.BTN_buscar.Location = New System.Drawing.Point(460, 180)
        Me.BTN_buscar.Name = "BTN_buscar"
        Me.BTN_buscar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_buscar.TabIndex = 42
        Me.BTN_buscar.Text = "Buscar"
        Me.BTN_buscar.UseVisualStyleBackColor = True
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(45, 36)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 41
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(610, 178)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 28)
        Me.TB_buscarBajaEquipo.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(111, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(655, 73)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "MIGRACION DE SIM"
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
        'MigracionSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.BTN_buscar)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "MigracionSIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Migracion de SIM"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents BTN_buscar As Button
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents TB_buscarBajaEquipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ICC_anterior As DataGridViewTextBoxColumn
    Friend WithEvents ICC_actual As DataGridViewTextBoxColumn
    Friend WithEvents Telefono As DataGridViewTextBoxColumn
    Friend WithEvents Propietario As DataGridViewTextBoxColumn
    Friend WithEvents Compania As DataGridViewTextBoxColumn
End Class
