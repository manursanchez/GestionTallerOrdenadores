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

    Public Function recuperarEntrada(codigoEntrada As Integer) As Boolean
        Dim objetoDatosTablaRMA As New DtablaRMA(codigoEntrada)
        Dim resultadoConsulta As DtablaRMA
        'objetoDatosTablaRMA.CodigoEntrada = 8

        'Aquí hago la llamada al método de la clase DtablaRMA con el objeto creado del mismo tipo que la clase, donde en este objeto,
        'ya va encapsulado el código de entrada recogido en el formulario. 
        If objetoDatosTablaRMA.recuperarEntrada(objetoDatosTablaRMA) = True Then
            Return True
        Else
            Return False
        End If
    End Function
End Class
