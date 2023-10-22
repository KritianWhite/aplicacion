Imports System.Text.RegularExpressions

Public Class AgregarCliente

    Dim numeroValido As New Auxiliares()
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) 
        ' Agregar validación de solo numeros en el textbox del telefono de igual manera el formato de numero a utilizar
        ' nombre tipo string
        ' correo tipo string
        ' numero tipo numero/integer (12345678)
        If (TB_nombreCliente.Text <> String.Empty And TB_telefonoCliente.Text <> String.Empty And TB_correoCliente.Text <> String.Empty) Then
            Dim numero = TB_telefonoCliente.Text
            If (numeroValido.ValidarTelefono(numero)) Then
                MessageBox.Show("Se agregó el cliente", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                LimpiarInputs()
            Else
                MessageBox.Show("Número no válido. Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                TB_telefonoCliente.Clear()
            End If
        Else
            MessageBox.Show("Falta ingresar datos en el formulario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_nombreCliente.Clear()
        TB_telefonoCliente.Clear()
        TB_correoCliente.Clear()
    End Sub
End Class