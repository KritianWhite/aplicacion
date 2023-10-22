<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AgregarSIM
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
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.BTN_agregarSIM = New System.Windows.Forms.Button()
        Me.DateTime = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_plandatosSim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TB_propietarioSim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_companiaSim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.BTN_agregarCliente = New System.Windows.Forms.Button()
        Me.TB_numeroSim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_iccSim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
<<<<<<< Updated upstream
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TB_propietarioSim = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TB_plandatosSim = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.SuspendLayout()
        '
        'TB_companiaSim
        '
        Me.TB_companiaSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_companiaSim.Location = New System.Drawing.Point(200, 284)
        Me.TB_companiaSim.Name = "TB_companiaSim"
        Me.TB_companiaSim.Size = New System.Drawing.Size(211, 28)
        Me.TB_companiaSim.TabIndex = 50
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(77, 287)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(92, 21)
        Me.Label7.TabIndex = 49
        Me.Label7.Text = "Compañía:"
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Location = New System.Drawing.Point(51, 40)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 48
        Me.BTN_regresar.Text = "<- Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'BTN_agregarCliente
        '
        Me.BTN_agregarCliente.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregarCliente.Location = New System.Drawing.Point(671, 435)
        Me.BTN_agregarCliente.Name = "BTN_agregarCliente"
        Me.BTN_agregarCliente.Size = New System.Drawing.Size(158, 33)
        Me.BTN_agregarCliente.TabIndex = 47
        Me.BTN_agregarCliente.Text = "Agregar SIM"
        Me.BTN_agregarCliente.UseVisualStyleBackColor = True
        '
        'TB_numeroSim
        '
        Me.TB_numeroSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_numeroSim.Location = New System.Drawing.Point(618, 225)
        Me.TB_numeroSim.Name = "TB_numeroSim"
        Me.TB_numeroSim.Size = New System.Drawing.Size(211, 28)
        Me.TB_numeroSim.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(517, 228)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 21)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Número:"
        '
        'TB_iccSim
        '
        Me.TB_iccSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_iccSim.Location = New System.Drawing.Point(200, 222)
        Me.TB_iccSim.Name = "TB_iccSim"
        Me.TB_iccSim.Size = New System.Drawing.Size(211, 28)
        Me.TB_iccSim.TabIndex = 44
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(77, 225)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 21)
        Me.Label2.TabIndex = 43
        Me.Label2.Text = "ICC:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(198, 89)
=======
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(161, 41)
>>>>>>> Stashed changes
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 73)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "AGREGAR SIM"
        '
<<<<<<< Updated upstream
        'TB_propietarioSim
        '
        Me.TB_propietarioSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_propietarioSim.Location = New System.Drawing.Point(618, 284)
        Me.TB_propietarioSim.Name = "TB_propietarioSim"
        Me.TB_propietarioSim.Size = New System.Drawing.Size(211, 28)
        Me.TB_propietarioSim.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(517, 287)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 21)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Propietario:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(442, 345)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(181, 21)
        Me.Label5.TabIndex = 55
        Me.Label5.Text = "Fecha de vencimiento:"
        '
        'TB_plandatosSim
        '
        Me.TB_plandatosSim.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_plandatosSim.Location = New System.Drawing.Point(200, 342)
        Me.TB_plandatosSim.Name = "TB_plandatosSim"
        Me.TB_plandatosSim.Size = New System.Drawing.Size(211, 28)
        Me.TB_plandatosSim.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(77, 345)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(118, 21)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Plan de datos:"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(629, 346)
        Me.DateTimePicker1.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 57
        Me.DateTimePicker1.Value = New Date(2023, 9, 27, 21, 16, 24, 0)
=======
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 59
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
>>>>>>> Stashed changes
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.BTN_agregarSIM)
        Me.Panel1.Controls.Add(Me.DateTime)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.TB_plandatosSim)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.TB_propietarioSim)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.TB_companiaSim)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.TB_numeroSim)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.TB_iccSim)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 123)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 340)
        Me.Panel1.TabIndex = 60
        '
        'BTN_agregarSIM
        '
        Me.BTN_agregarSIM.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_agregarSIM.Location = New System.Drawing.Point(617, 258)
        Me.BTN_agregarSIM.Name = "BTN_agregarSIM"
        Me.BTN_agregarSIM.Size = New System.Drawing.Size(158, 33)
        Me.BTN_agregarSIM.TabIndex = 71
        Me.BTN_agregarSIM.Text = "Agregar SIM"
        Me.BTN_agregarSIM.UseVisualStyleBackColor = True
        '
        'DateTime
        '
        Me.DateTime.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTime.Location = New System.Drawing.Point(564, 174)
        Me.DateTime.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        Me.DateTime.Name = "DateTime"
        Me.DateTime.Size = New System.Drawing.Size(211, 21)
        Me.DateTime.TabIndex = 70
        Me.DateTime.Value = New Date(2023, 9, 27, 21, 16, 24, 0)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(388, 173)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 19)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Fecha de vencimiento:"
        '
        'TB_plandatosSim
        '
        Me.TB_plandatosSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_plandatosSim.Location = New System.Drawing.Point(146, 170)
        Me.TB_plandatosSim.Name = "TB_plandatosSim"
        Me.TB_plandatosSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_plandatosSim.TabIndex = 68
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(23, 173)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 19)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "Plan de datos:"
        '
        'TB_propietarioSim
        '
        Me.TB_propietarioSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_propietarioSim.Location = New System.Drawing.Point(564, 112)
        Me.TB_propietarioSim.Name = "TB_propietarioSim"
        Me.TB_propietarioSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_propietarioSim.TabIndex = 66
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(461, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(90, 19)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "Propietario:"
        '
        'TB_companiaSim
        '
        Me.TB_companiaSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_companiaSim.Location = New System.Drawing.Point(146, 112)
        Me.TB_companiaSim.Name = "TB_companiaSim"
        Me.TB_companiaSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_companiaSim.TabIndex = 64
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(23, 115)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Compañía:"
        '
        'TB_numeroSim
        '
        Me.TB_numeroSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_numeroSim.Location = New System.Drawing.Point(564, 53)
        Me.TB_numeroSim.Name = "TB_numeroSim"
        Me.TB_numeroSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_numeroSim.TabIndex = 62
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(461, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 19)
        Me.Label3.TabIndex = 61
        Me.Label3.Text = "Número:"
        '
        'TB_iccSim
        '
        Me.TB_iccSim.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_iccSim.Location = New System.Drawing.Point(146, 50)
        Me.TB_iccSim.Name = "TB_iccSim"
        Me.TB_iccSim.Size = New System.Drawing.Size(211, 26)
        Me.TB_iccSim.TabIndex = 60
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Vensim Sans Tamil", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 19)
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "ICC:"
        '
        'AgregarSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
<<<<<<< Updated upstream
        Me.ClientSize = New System.Drawing.Size(912, 525)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TB_plandatosSim)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TB_propietarioSim)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TB_companiaSim)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Controls.Add(Me.BTN_agregarCliente)
        Me.Controls.Add(Me.TB_numeroSim)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TB_iccSim)
        Me.Controls.Add(Me.Label2)
=======
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.BTN_regresar)
>>>>>>> Stashed changes
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarSIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar SIM"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BTN_agregarSIM As Button
    Friend WithEvents DateTime As DateTimePicker
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_plandatosSim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TB_propietarioSim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TB_companiaSim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents BTN_agregarCliente As Button
    Friend WithEvents TB_numeroSim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_iccSim As TextBox
    Friend WithEvents Label2 As Label
<<<<<<< Updated upstream
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_propietarioSim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_plandatosSim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
=======
>>>>>>> Stashed changes
End Class
