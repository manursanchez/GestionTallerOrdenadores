Public Class FrmRecuperaEntrada
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim lc As New LtablaRMA()
            lc.recuperarEntrada(Int(TextBox1.Text))

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub RMABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles RMABindingNavigatorSaveItem.Click
        Me.Validate()
        Me.RMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMADataSet)

    End Sub

    Private Sub FrmRecuperaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RMADataSet.RMA' Puede moverla o quitarla según sea necesario.
        Me.RMATableAdapter.Fill(Me.RMADataSet.RMA)

    End Sub
End Class