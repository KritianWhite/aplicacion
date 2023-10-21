Public Class Login
    Dim encryp As New Encrypted()
    Dim controlador As New Controlador()

    Private Sub BTN_iniciarSesion_Click(sender As Object, e As EventArgs) Handles BTN_iniciarSesion.Click
        If (TB_usuario.Text <> String.Empty And TB_contrasena.Text <> String.Empty) Then
            Dim encrypted As String = encryp.EncriptarSHA1(TB_contrasena.Text)
            'controlador.Login(TB_usuario.Text, encrypted)
            If controlador.IniciarSesion(TB_usuario.Text, encrypted) Then
                Limpiar()
            Else
                TB_contrasena.Text = ""
            End If
        End If
    End Sub

    Private Sub Limpiar()
        TB_usuario.Text = ""
        TB_contrasena.Text = ""
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = ColorTranslator.FromHtml("#0080AA")
    End Sub
End Class
