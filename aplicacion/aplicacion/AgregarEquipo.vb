Public Class AgregarEquipo
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Hide()
        FormAdmin.Show()
    End Sub

<<<<<<< Updated upstream
    Private Sub BTN_agregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_agregarCliente.Click
        If (TB_modeloEquipo.Text <> String.Empty And TB_imeiEquipo.Text <> String.Empty And TB_marcaEquipo.Text <> String.Empty) Then
            MessageBox.Show("Se agregó el equipo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
            LimpiarInputs()
=======
    Private Sub BTN_agregarEquipo_Click(sender As Object, e As EventArgs) 
        If (TB_imeiEquipo.Text <> String.Empty And CB_modelo.Text <> String.Empty) Then
            Try
                If controlador.AgregarEquipo_(TB_imeiEquipo.Text, CB_modelo.Text) Then
                    MessageBox.Show("Se agregó el equipo correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    LimpiarInputs()
                End If
            Catch ex As Exception
                MessageBox.Show("Algo inesperado ocurrió: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
>>>>>>> Stashed changes
        Else
            MessageBox.Show("Falta ingresar datos en el formulario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub LimpiarInputs()
        TB_modeloEquipo.Clear()
        TB_imeiEquipo.Clear()
<<<<<<< Updated upstream
        TB_marcaEquipo.Clear()
=======
    End Sub

    Private Sub AgregarEquipo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not controlador.CargarModeloEquipo() Then
            MessageBox.Show("Error al cargar los modelos de equipos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
>>>>>>> Stashed changes
    End Sub
End Class