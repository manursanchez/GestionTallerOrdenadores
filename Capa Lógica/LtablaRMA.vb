Imports System.Data.OleDb
Public Class LtablaRMA
    Public Function insertarEntrada(fecha_entrada As Date, nom As String, direc As String, tlf As Integer, correo_e As String, problem As String,
                   comentarios As String)
        Dim objetoDatosTablaRMA As New DtablaRMA(fecha_entrada, nom, direc, tlf, correo_e, problem, comentarios)
        If objetoDatosTablaRMA.insertarEntrada(objetoDatosTablaRMA) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
