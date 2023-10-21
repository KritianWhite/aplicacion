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
        Me.DGV_bajaEquipos = New System.Windows.Forms.DataGridView()
        Me.IMEI_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Modelo_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Marca_bajaEquipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(608, 177)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 26)
        Me.TB_buscarBajaEquipo.TabIndex = 33
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(76, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(630, 79)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "BAJAS DE EQUIPOS"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(90, 29)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 36
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'DGV_bajaEquipos
        '
        Me.DGV_bajaEquipos.AllowUserToAddRows = False
        Me.DGV_bajaEquipos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_bajaEquipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_bajaEquipos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IMEI_bajaEquipo, Me.Modelo_bajaEquipo, Me.Marca_bajaEquipo})
        Me.DGV_bajaEquipos.Location = New System.Drawing.Point(90, 231)
        Me.DGV_bajaEquipos.Name = "DGV_bajaEquipos"
        Me.DGV_bajaEquipos.Size = New System.Drawing.Size(729, 259)
        Me.DGV_bajaEquipos.TabIndex = 38
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
        Me.Controls.Add(Me.DGV_bajaEquipos)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "BajaEquipos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de equipos"
        CType(Me.DGV_bajaEquipos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_buscarBajaEquipo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents DGV_bajaEquipos As DataGridView
    Friend WithEvents IMEI_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Modelo_bajaEquipo As DataGridViewTextBoxColumn
    Friend WithEvents Marca_bajaEquipo As DataGridViewTextBoxColumn
End Class
