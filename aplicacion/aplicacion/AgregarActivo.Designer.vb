<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AgregarActivo
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
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.BTN_agregarCliente = New System.Windows.Forms.Button()
        Me.TB_tipoActivo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_chasisActivo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_placaActivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_marcaActivo = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_anioActivo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_modeloActivo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(49, 38)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 22
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'BTN_agregarCliente
        '
        Me.BTN_agregarCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregarCliente.Location = New System.Drawing.Point(669, 433)
        Me.BTN_agregarCliente.Name = "BTN_agregarCliente"
        Me.BTN_agregarCliente.Size = New System.Drawing.Size(158, 33)
        Me.BTN_agregarCliente.TabIndex = 21
        Me.BTN_agregarCliente.Text = "Agregar activo"
        Me.BTN_agregarCliente.UseVisualStyleBackColor = True
        '
        'TB_tipoActivo
        '
        Me.TB_tipoActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_tipoActivo.Location = New System.Drawing.Point(176, 277)
        Me.TB_tipoActivo.Name = "TB_tipoActivo"
        Me.TB_tipoActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_tipoActivo.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(75, 280)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Tipo:"
        '
        'TB_chasisActivo
        '
        Me.TB_chasisActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_chasisActivo.Location = New System.Drawing.Point(616, 223)
        Me.TB_chasisActivo.Name = "TB_chasisActivo"
        Me.TB_chasisActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_chasisActivo.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(515, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Chásis:"
        '
        'TB_placaActivo
        '
        Me.TB_placaActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_placaActivo.Location = New System.Drawing.Point(176, 220)
        Me.TB_placaActivo.Name = "TB_placaActivo"
        Me.TB_placaActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_placaActivo.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(75, 223)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Placa:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(667, 73)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "AGREGAR ACTIVOS"
        '
        'TB_marcaActivo
        '
        Me.TB_marcaActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_marcaActivo.Location = New System.Drawing.Point(616, 280)
        Me.TB_marcaActivo.Name = "TB_marcaActivo"
        Me.TB_marcaActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_marcaActivo.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(515, 283)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Marca:"
        '
        'TB_anioActivo
        '
        Me.TB_anioActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_anioActivo.Location = New System.Drawing.Point(616, 337)
        Me.TB_anioActivo.Name = "TB_anioActivo"
        Me.TB_anioActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_anioActivo.TabIndex = 28
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(515, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(45, 21)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Año:"
        '
        'TB_modeloActivo
        '
        Me.TB_modeloActivo.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_modeloActivo.Location = New System.Drawing.Point(176, 334)
        Me.TB_modeloActivo.Name = "TB_modeloActivo"
        Me.TB_modeloActivo.Size = New System.Drawing.Size(211, 28)
        Me.TB_modeloActivo.TabIndex = 26
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(75, 337)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 21)
        Me.Label7.TabIndex = 25
        Me.Label7.Text = "Modelo:"
        '
        'AgregarActivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.TB_anioActivo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_modeloActivo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TB_marcaActivo)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.BTN_agregarCliente)
        Me.Controls.Add(Me.TB_tipoActivo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_chasisActivo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_placaActivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarActivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar activos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_regresar As Button
    Friend WithEvents BTN_agregarCliente As Button
    Friend WithEvents TB_tipoActivo As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_chasisActivo As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_placaActivo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_marcaActivo As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_anioActivo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_modeloActivo As TextBox
    Friend WithEvents Label7 As Label
End Class
