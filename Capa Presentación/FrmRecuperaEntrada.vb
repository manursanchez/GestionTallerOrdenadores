Public Class FrmRecuperaEntrada


    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim lc As New LtablaRMA()
            lc.recuperarEntrada()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class