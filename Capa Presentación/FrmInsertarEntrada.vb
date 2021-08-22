Public Class FrmInsertarEntrada
    Private Sub btnInsertarEntrada_Click(sender As Object, e As EventArgs) Handles btnInsertarEntrada.Click
        Try
            'creamos objeto de la capa lógica para peticin de datos
            Dim lrma As New LtablaRMA()
            ' Initialize the random-number generator.
            Randomize()
            ' Generate random value between 1 and 6.
            Dim codigoEntrada As Integer = CInt(Int((6 * Rnd()) + 1))
            lrma.insertarEntrada(codigoEntrada, TextFechaEntrada.Text, TextNombre.Text, TextDireccion.Text, TextTelefono.Text, TextCorreoE.Text, RichTextDescripcion.Text, RichTextObservaciones.Text)
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

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Close()
    End Sub


End Class