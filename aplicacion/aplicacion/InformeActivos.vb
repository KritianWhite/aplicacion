Public Class InformeActivos
    Private Sub BTN_regresar_Click(sender As Object, e As EventArgs) Handles BTN_regresar.Click
        Me.Close()
    End Sub

    Private Sub InformeActivos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGV_informeActivos.ColumnHeadersDefaultCellStyle.BackColor = ColorTranslator.FromHtml("#B3BEC5") ' Establecemos el color al encabezado del datagridview.
        DGV_informeActivos.EnableHeadersVisualStyles = False ' Inhabilitamos el visual styles del header para poder implementar el color aplicado anteriormente.
    End Sub
End Class