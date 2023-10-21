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
        Me.TB_contraseniaUsuario = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_usuarioUsuario = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_contrasenia2Usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.CB_rolUsuario = New System.Windows.Forms.ComboBox()
        Me.BTN_agregarUsuario = New System.Windows.Forms.Button()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TB_contraseniaUsuario
        '
        Me.TB_contraseniaUsuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_contraseniaUsuario.Location = New System.Drawing.Point(174, 311)
        Me.TB_contraseniaUsuario.Name = "TB_contraseniaUsuario"
        Me.TB_contraseniaUsuario.Size = New System.Drawing.Size(211, 26)
        Me.TB_contraseniaUsuario.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(73, 314)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 19)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(513, 215)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 19)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Rol:"
        '
        'TB_usuarioUsuario
        '
        Me.TB_usuarioUsuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_usuarioUsuario.Location = New System.Drawing.Point(174, 209)
        Me.TB_usuarioUsuario.Name = "TB_usuarioUsuario"
        Me.TB_usuarioUsuario.Size = New System.Drawing.Size(211, 26)
        Me.TB_usuarioUsuario.TabIndex = 16
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(73, 212)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Usuario:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 47.99999!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(687, 79)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "AGREGAR USUARIOS"
        '
        'TB_contrasenia2Usuario
        '
        Me.TB_contrasenia2Usuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_contrasenia2Usuario.Location = New System.Drawing.Point(614, 311)
        Me.TB_contrasenia2Usuario.Name = "TB_contrasenia2Usuario"
        Me.TB_contrasenia2Usuario.Size = New System.Drawing.Size(211, 26)
        Me.TB_contrasenia2Usuario.TabIndex = 24
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(428, 314)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 19)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "Confirmar contraseña:"
        '
        'CB_rolUsuario
        '
        Me.CB_rolUsuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_rolUsuario.FormattingEnabled = True
        Me.CB_rolUsuario.Items.AddRange(New Object() {"USUARIO", "ADMINISTRADOR"})
        Me.CB_rolUsuario.Location = New System.Drawing.Point(614, 209)
        Me.CB_rolUsuario.Name = "CB_rolUsuario"
        Me.CB_rolUsuario.Size = New System.Drawing.Size(211, 27)
        Me.CB_rolUsuario.TabIndex = 26
        Me.CB_rolUsuario.Text = "Seleccione una opción"
        '
        'BTN_agregarUsuario
        '
        Me.BTN_agregarUsuario.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregarUsuario.Location = New System.Drawing.Point(667, 408)
        Me.BTN_agregarUsuario.Name = "BTN_agregarUsuario"
        Me.BTN_agregarUsuario.Size = New System.Drawing.Size(158, 33)
        Me.BTN_agregarUsuario.TabIndex = 27
        Me.BTN_agregarUsuario.Text = "Agregar usuario"
        Me.BTN_agregarUsuario.UseVisualStyleBackColor = True
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(77, 35)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 28
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'AgregarUsuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.BTN_agregarUsuario)
        Me.Controls.Add(Me.CB_rolUsuario)
        Me.Controls.Add(Me.TB_contrasenia2Usuario)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_contraseniaUsuario)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_usuarioUsuario)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AgregarUsuario"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TB_contraseniaUsuario As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_usuarioUsuario As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_contrasenia2Usuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents CB_rolUsuario As ComboBox
    Friend WithEvents BTN_agregarUsuario As Button
    Friend WithEvents BTN_regresar As Button
End Class
