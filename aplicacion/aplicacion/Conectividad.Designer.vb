<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Conectividad
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TB_baseDatos = New System.Windows.Forms.TextBox()
        Me.TB_contrasenia = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TB_usuario = New System.Windows.Forms.TextBox()
        Me.TB_puerto = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.TB_baseDatos)
        Me.Panel1.Controls.Add(Me.TB_contrasenia)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.TB_usuario)
        Me.Panel1.Controls.Add(Me.TB_puerto)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(18, 161)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(702, 398)
        Me.Panel1.TabIndex = 0
        '
        'TB_baseDatos
        '
        Me.TB_baseDatos.Location = New System.Drawing.Point(315, 223)
        Me.TB_baseDatos.Name = "TB_baseDatos"
        Me.TB_baseDatos.Size = New System.Drawing.Size(268, 26)
        Me.TB_baseDatos.TabIndex = 10
        '
        'TB_contrasenia
        '
        Me.TB_contrasenia.Location = New System.Drawing.Point(315, 165)
        Me.TB_contrasenia.Name = "TB_contrasenia"
        Me.TB_contrasenia.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TB_contrasenia.Size = New System.Drawing.Size(268, 26)
        Me.TB_contrasenia.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(113, 227)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(154, 22)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "BASE DE DATOS:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(113, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(136, 22)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "CONTRASEÑA:"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Vensim Sans Tamil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(422, 295)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 54)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "CONECTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TB_usuario
        '
        Me.TB_usuario.Location = New System.Drawing.Point(315, 114)
        Me.TB_usuario.Name = "TB_usuario"
        Me.TB_usuario.Size = New System.Drawing.Size(268, 26)
        Me.TB_usuario.TabIndex = 5
        '
        'TB_puerto
        '
        Me.TB_puerto.Location = New System.Drawing.Point(315, 56)
        Me.TB_puerto.Name = "TB_puerto"
        Me.TB_puerto.Size = New System.Drawing.Size(268, 26)
        Me.TB_puerto.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(113, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 22)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "USUARIO:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(113, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PUERTO:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 40.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 55)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(683, 67)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "CONECTIVIDAD REMOTA"
        '
        'Conectividad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(733, 581)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Conectividad"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conectividad"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_usuario As TextBox
    Friend WithEvents TB_puerto As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents TB_baseDatos As TextBox
    Friend WithEvents TB_contrasenia As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
