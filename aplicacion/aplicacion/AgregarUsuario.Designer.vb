<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarUsuario
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
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.BTN_agregarCliente = New System.Windows.Forms.Button()
        Me.TB_contraseniaUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_usuarioUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_contrasenia2Usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_rolUsuario = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(34, 26)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 22
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'BTN_agregarCliente
        '
        Me.BTN_agregarCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregarCliente.Location = New System.Drawing.Point(667, 422)
        Me.BTN_agregarCliente.Name = "BTN_agregarCliente"
        Me.BTN_agregarCliente.Size = New System.Drawing.Size(158, 33)
        Me.BTN_agregarCliente.TabIndex = 21
        Me.BTN_agregarCliente.Text = "Agregar usuario"
        Me.BTN_agregarCliente.UseVisualStyleBackColor = True
        '
        'TB_contraseniaUsuario
        '
        Me.TB_contraseniaUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_contraseniaUsuario.Location = New System.Drawing.Point(174, 311)
        Me.TB_contraseniaUsuario.Name = "TB_contraseniaUsuario"
        Me.TB_contraseniaUsuario.Size = New System.Drawing.Size(211, 28)
        Me.TB_contraseniaUsuario.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 21)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 21)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Rol:"
        '
        'TB_usuarioUsuario
        '
        Me.TB_usuarioUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_usuarioUsuario.Location = New System.Drawing.Point(174, 209)
        Me.TB_usuarioUsuario.Name = "TB_usuarioUsuario"
        Me.TB_usuarioUsuario.Size = New System.Drawing.Size(211, 28)
        Me.TB_usuarioUsuario.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 21)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(91, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(721, 73)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "AGREGAR USUARIOS"
        '
        'TB_contrasenia2Usuario
        '
        Me.TB_contrasenia2Usuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_contrasenia2Usuario.Location = New System.Drawing.Point(614, 311)
        Me.TB_contrasenia2Usuario.Name = "TB_contrasenia2Usuario"
        Me.TB_contrasenia2Usuario.Size = New System.Drawing.Size(211, 28)
        Me.TB_contrasenia2Usuario.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(180, 21)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Confirmar contraseña:"
        '
        'CB_rolUsuario
        '
        Me.CB_rolUsuario.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_rolUsuario.FormattingEnabled = True
        Me.CB_rolUsuario.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.CB_rolUsuario.Location = New System.Drawing.Point(614, 211)
        Me.CB_rolUsuario.Name = "CB_rolUsuario"
        Me.CB_rolUsuario.Size = New System.Drawing.Size(211, 27)
        Me.CB_rolUsuario.TabIndex = 25
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.CB_rolUsuario)
        Me.Controls.Add(Me.TB_contrasenia2Usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.BTN_agregarCliente)
        Me.Controls.Add(Me.TB_contraseniaUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_usuarioUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarUsuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_regresar As Button
    Friend WithEvents BTN_agregarCliente As Button
    Friend WithEvents TB_contraseniaUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_usuarioUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_contrasenia2Usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_rolUsuario As ComboBox
End Class
