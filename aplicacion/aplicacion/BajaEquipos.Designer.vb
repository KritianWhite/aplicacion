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
        Me.TB_buscarBajaEquipo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
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
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(668, 73)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BAJAS DE EQUIPOS"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(43, 35)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
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
        '
        'IMEI_bajaEquipo
        '
        Me.IMEI_bajaEquipo.HeaderText = "IMEI"
        Me.IMEI_bajaEquipo.Name = "IMEI_bajaEquipo"
        '
        'Modelo_bajaEquipo
        '
        Me.Modelo_bajaEquipo.HeaderText = "Modelo"
        Me.Modelo_bajaEquipo.Name = "Modelo_bajaEquipo"
        '
        'Marca_bajaEquipo
        '
        Me.Marca_bajaEquipo.HeaderText = "Marca"
        Me.Marca_bajaEquipo.Name = "Marca_bajaEquipo"
        '
        'BajaEquipos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BajaEquipos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de equipos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_buscarBajaEquipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IMEI_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Marca_bajaEquipo As DataGridViewTextBoxColumn
End Class
