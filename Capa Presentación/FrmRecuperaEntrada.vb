Public Class FrmRecuperaEntrada
    Private Sub BtnConsulta_Click(sender As Object, e As EventArgs) Handles BtnConsulta.Click
        Try
            Dim lc As New LtablaRMA()
            If lc.recuperarEntrada(TextBox1.Text) = True Then
                TextBox2.Text = lc.ObjetoDatos1.FechaDeEntrada
                TextBox3.Text = lc.ObjetoDatos1.NombreCliente
                TextBox6.Text = lc.ObjetoDatos1.DireccionCliente
                TextBox7.Text = lc.ObjetoDatos1.TelefonoCliente
                TextBox8.Text = lc.ObjetoDatos1.EmailCliente
                TextBox4.Text = lc.ObjetoDatos1.DescripcionProblema
                TextBox9.Text = lc.ObjetoDatos1.ObservacionesUsuario
            Else

            End If

        Catch ex As Exception
            MsgBox("Error en formulario: " + ex.Message)
        End Try
    End Sub

    Private Sub RMABindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.RMABindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.RMADataSet)

    End Sub

    Private Sub FrmRecuperaEntrada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'RMADataSet.RMA' Puede moverla o quitarla según sea necesario.
        Me.RMATableAdapter.Fill(Me.RMADataSet.RMA)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox8.Clear()
        TextBox4.Clear()
        TextBox9.Clear()

        Close()

    End Sub
End Class