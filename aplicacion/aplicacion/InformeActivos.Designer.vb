<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InformeActivos
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.DGV_informeActivos = New System.Windows.Forms.DataGridView()
        Me.TB_buscarBajaEquipo = New System.Windows.Forms.TextBox()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.DGV_informeActivos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BTN_regresar
        '
        Me.BTN_regresar.Font = New System.Drawing.Font("Vensim Sans Tamil", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_regresar.Location = New System.Drawing.Point(12, 12)
        Me.BTN_regresar.Name = "BTN_regresar"
        Me.BTN_regresar.Size = New System.Drawing.Size(112, 26)
        Me.BTN_regresar.TabIndex = 31
        Me.BTN_regresar.Text = "Regresar"
        Me.BTN_regresar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Vensim Sans Tamil", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(66, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(672, 47)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "INFORME DE ACTIVOS ASIGNADOS"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.AliceBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.RadioButton4)
        Me.Panel1.Controls.Add(Me.RadioButton3)
        Me.Panel1.Controls.Add(Me.RadioButton2)
        Me.Panel1.Controls.Add(Me.RadioButton1)
        Me.Panel1.Controls.Add(Me.DGV_informeActivos)
        Me.Panel1.Controls.Add(Me.TB_buscarBajaEquipo)
        Me.Panel1.Location = New System.Drawing.Point(12, 91)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(799, 374)
        Me.Panel1.TabIndex = 40
        '
        'DGV_informeActivos
        '
        Me.DGV_informeActivos.AllowUserToAddRows = False
        Me.DGV_informeActivos.AllowUserToDeleteRows = False
        Me.DGV_informeActivos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGV_informeActivos.BackgroundColor = System.Drawing.Color.White
        Me.DGV_informeActivos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGV_informeActivos.Location = New System.Drawing.Point(35, 107)
        Me.DGV_informeActivos.Name = "DGV_informeActivos"
        Me.DGV_informeActivos.ReadOnly = True
        Me.DGV_informeActivos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DGV_informeActivos.Size = New System.Drawing.Size(729, 248)
        Me.DGV_informeActivos.TabIndex = 40
        '
        'TB_buscarBajaEquipo
        '
        Me.TB_buscarBajaEquipo.Font = New System.Drawing.Font("Vensim Sans Tamil", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TB_buscarBajaEquipo.Location = New System.Drawing.Point(553, 69)
        Me.TB_buscarBajaEquipo.Name = "TB_buscarBajaEquipo"
        Me.TB_buscarBajaEquipo.Size = New System.Drawing.Size(211, 22)
        Me.TB_buscarBajaEquipo.TabIndex = 39
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton1.Location = New System.Drawing.Point(35, 47)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 19)
        Me.RadioButton1.TabIndex = 41
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "VENTA"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton2.Location = New System.Drawing.Point(35, 70)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(65, 19)
        Me.RadioButton2.TabIndex = 42
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "RENTA"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton3.Location = New System.Drawing.Point(276, 47)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(120, 19)
        Me.RadioButton3.TabIndex = 43
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "POSITION LOGIC"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4.Location = New System.Drawing.Point(276, 70)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(79, 19)
        Me.RadioButton4.TabIndex = 44
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "RED GPS"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(32, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 15)
        Me.Label2.TabIndex = 45
        Me.Label2.Text = "Tipo de adquisición:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(273, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(132, 15)
        Me.Label3.TabIndex = 46
        Me.Label3.Text = "Tipo de plataforma:"
        '
        'InformeActivos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(824, 477)
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BTN_regresar)
        Me.Name = "InformeActivos"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informe activos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGV_informeActivos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTN_regresar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents DGV_informeActivos As DataGridView
    Friend WithEvents TB_buscarBajaEquipo As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Label3 As Label
End Class
