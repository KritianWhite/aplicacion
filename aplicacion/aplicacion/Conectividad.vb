Public Class Conectividad
    Private conn As New Conexion()
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If TB_puerto.Text <> String.Empty Then
            If TB_contrasenia.Text <> String.Empty And TB_usuario.Text <> String.Empty Then
                If TB_baseDatos.Text <> String.Empty Then
                    conn.puerto = TB_puerto.Text
                    conn.username = TB_usuario.Text
                    conn.password = TB_contrasenia.Text
                    conn.database = TB_baseDatos.Text
                    conn.conexion()
                    conn.desconexion()

                    Login.Show()
                    Me.Hide()
                Else
                    MessageBox.Show("Ingrese el nombre de la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Else
                MessageBox.Show("Ingrese el usuario/contraseña.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Else
            MessageBox.Show("Ingrese el puerto al que desa conectarse.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub

End Class