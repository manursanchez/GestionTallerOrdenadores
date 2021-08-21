Public Class FrmInsertarEntrada
    Private Sub btnInsertarEntrada_Click(sender As Object, e As EventArgs) Handles btnInsertarEntrada.Click
        Try
            If 
            Dim lc As New LtablaRMA()
            lc.insertarEntrada(TextFechaEntrada.Text, TextNombre.Text, TextDireccion.Text, TextTelefono.Text, TextCorreoE.Text, RichTextDescripcion.Text, RichTextObservaciones.Text)
            limpiarCampos()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Sub limpiarCampos()
        TextFechaEntrada.Clear()
        TextNombre.Clear()
        TextDireccion.Clear()
        TextTelefono.Clear()
        TextCorreoE.Clear()
        RichTextDescripcion.Clear()
        RichTextObservaciones.Clear()
    End Sub

End Class