Public Class FormAdmin

    Dim WithEvents MyBasesToolStripMenuItem As ToolStripMenuItem
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub SallirToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SallirToolStripMenuItem.Click
        Me.Close()
        Login.Show()
    End Sub

    Private Sub ActivosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ActivosToolStripMenuItem.Click
        If (PanelActivos.Visible = False) Then
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelActivos.Visible = True
            PanelActivos.Location = New Point(0, 0)
            PanelActivos.Dock = DockStyle.Fill
        End If

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem.Click
        If (PanelCliente.Visible = False) Then
            PanelActivos.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelCliente.Visible = True
            PanelCliente.Location = New Point(0, 0)
            PanelCliente.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub EquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EquiposToolStripMenuItem.Click
        If (PanelEquipos.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = False
            PanelEquipos.Visible = True
            PanelEquipos.Location = New Point(0, 0)
            PanelEquipos.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub SIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SIMToolStripMenuItem.Click
        If (PanelSIM.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelUsuario.Visible = False
            PanelSIM.Visible = True
            PanelSIM.Location = New Point(0, 0)
            PanelSIM.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub UsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UsuariosToolStripMenuItem.Click
        If (PanelUsuario.Visible = False) Then
            PanelActivos.Visible = False
            PanelCliente.Visible = False
            PanelEquipos.Visible = False
            PanelSIM.Visible = False
            PanelUsuario.Visible = True
            PanelUsuario.Location = New Point(0, 0)
            PanelUsuario.Dock = DockStyle.Fill
        End If
    End Sub

    Private Sub BTN_AgregarCliente_Click(sender As Object, e As EventArgs) Handles BTN_AgregarCliente.Click
        AgregarCliente.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        AgregarActivo.Show()
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        AgregarEquipo.Show()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        AgregarSIM.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        AgregarUsuario.Show()
    End Sub

    Private Sub BajaDeEquiposToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BajaDeEquiposToolStripMenuItem.Click
        BajaEquipos.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MigrarSIM.Show()
    End Sub

    Private Sub MigracionesDeSIMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MigracionesDeSIMToolStripMenuItem.Click
        MigracionSIM.Show()
    End Sub
End Class