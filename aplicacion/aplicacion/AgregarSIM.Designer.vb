﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.TB_companiaSim = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.BTN_regresar = New System.Windows.Forms.Button()
        Me.BTN_agregarCliente = New System.Windows.Forms.Button()
        Me.TB_numeroSim = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TB_iccSim = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
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
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(495, 73)
        Me.Label1.TabIndex = 42
        Me.Label1.Text = "AGREGAR SIM"
        '
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
        '
        'AgregarSIM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
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
        Me.Controls.Add(Me.Label1)
        Me.Name = "AgregarSIM"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar SIM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TB_companiaSim As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents BTN_regresar As Button
    Friend WithEvents BTN_agregarCliente As Button
    Friend WithEvents TB_numeroSim As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TB_iccSim As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TB_propietarioSim As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TB_plandatosSim As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
End Class
