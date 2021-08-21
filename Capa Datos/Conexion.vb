'Clase que contendrá los métodos para conectar y desonectar la base de datos
Imports System.Data.OleDb

Public Class Conexion
    Protected conect As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\manue\OneDrive - UNED\Trabajos y artículos\Desarrollos Visual Basic\RMA_2021\RMA2021\RMA2021\RMA.MDB")

    Public Function conectar() As Boolean
        Try
            conect.Open()
            Return True

        Catch ex As Exception
            MsgBox("No se ha podido establecer la conexión" + ex.Message)
            Return False
        End Try
    End Function

    Public Sub desconectar()
        Try
            If conect.State = ConnectionState.Open Then
                conect.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class
