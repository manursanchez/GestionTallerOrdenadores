Public Class FrmInicio


    Private Sub BtnSalir_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Close()
    End Sub

    Private Sub BtnRecuperaEntrada_Click(sender As Object, e As EventArgs) Handles BtnRecuperaEntrada.Click
        FrmRecuperaEntrada.ShowDialog()
    End Sub

    Private Sub BtnCambiaEntrada_Click(sender As Object, e As EventArgs) Handles BtnCambiaEntrada.Click
        FrmCambiaEntrada.ShowDialog()

    End Sub

    Private Sub BtnSalidas_Click(sender As Object, e As EventArgs) Handles BtnSalidas.Click
        FrmSalida.ShowDialog()

    End Sub

    Private Sub BtnListado_Click(sender As Object, e As EventArgs) Handles BtnListado.Click
        FrmListado.ShowDialog()

    End Sub

    Private Sub BtnEntradas_Click(sender As Object, e As EventArgs) Handles BtnEntradas.Click
        FrmInsertarEntrada.ShowDialog()

    End Sub
End Class
