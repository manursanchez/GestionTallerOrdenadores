Imports System.Data.OleDb
Public Class DtablaRMA
    Inherits Conexion
    'Atributos
    Private centrada As Integer
    Private fechaentrada As Date
    'Private fechasalida As Date
    Private Nombre As String
    Private direccion As String
    Private telefono As String
    'Private movil As Integer
    Private email As String
    Private problema As String
    'Private solucion As String
    Private observaciones As String

    'Creamos el objeto que representará una instrucción SQL o procedimiento que se ejecutara en 
    'un origen de datos
    Private cmd As OleDbCommand


    'Constructor
    Public Sub New(codentrada As Integer, fecha_entrada As Date, nom As String, direc As String, tlf As String, correo_e As String, problem As String,
                   comentarios As String)
        centrada = codentrada
        fechaentrada = fecha_entrada
        Nombre = nom
        direccion = direc
        telefono = tlf
        email = correo_e
        problema = problem
        observaciones = comentarios
    End Sub
    Public Sub New(codigoEntrada As Integer)
        centrada = codigoEntrada
    End Sub
    'Constructor vacío
    Public Sub New()

    End Sub
    'Encapsulación
    Public Property CodigoEntrada As Integer
        Get
            Return centrada
        End Get
        Set(value As Integer)
            centrada = value
        End Set
    End Property

    Public Property FechaDeEntrada As Date
        Get
            Return fechaentrada
        End Get
        Set(value As Date)
            fechaentrada = value
        End Set
    End Property

    Public Property NombreCliente As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property

    Public Property DireccionCliente As String
        Get
            Return direccion
        End Get
        Set(value As String)
            direccion = value
        End Set
    End Property

    Public Property TelefonoCliente As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value
        End Set
    End Property

    Public Property EmailCliente As String
        Get
            Return email
        End Get
        Set(value As String)
            email = value
        End Set
    End Property

    Public Property DescripcionProblema As String
        Get
            Return problema
        End Get
        Set(value As String)
            problema = value
        End Set
    End Property

    Public Property ObservacionesUsuario As String
        Get
            Return observaciones
        End Get
        Set(value As String)
            observaciones = value
        End Set
    End Property

    'Función para grabar una entrada de un dispositivo que ha entrado en el taller
    Public Function insertarEntrada(dRMA As DtablaRMA) As Boolean
        Try
            'Establecemos la conexión con la base de datos
            conectar()
            Dim sql As String =
            "INSERT INTO RMA(centrada,fechaentrada,Nombre,direccion,telefono,email,problema,observaciones)VALUES('" & dRMA.CodigoEntrada & "','" & dRMA.FechaDeEntrada & "','" & dRMA.NombreCliente & "',' 
            " & dRMA.DireccionCliente & "','" & dRMA.TelefonoCliente & "','" & dRMA.EmailCliente & "','" & dRMA.DescripcionProblema & "','" & dRMA.ObservacionesUsuario & "')"

            cmd = New OleDbCommand(sql, conect)

            If cmd.ExecuteNonQuery() Then
                MsgBox("La entrada ha sido registrada")
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectar()

        End Try

    End Function

    'Función para recuperar información de la tabla a partir de un código de registro 
    Public Function recuperarEntrada(dRMA As DtablaRMA) As Boolean
        Try
            'Establecemos la conexión con la base de datos
            conectar()
            Dim sql As String = "SELECT * FROM RMA WHERE centrada=" + Str(dRMA.CodigoEntrada)
            Dim registroLeido As OleDbDataReader
            cmd = New OleDbCommand(sql, conect)
            registroLeido = cmd.ExecuteReader()
            If registroLeido.HasRows Then
                While registroLeido.Read()
                    'MsgBox(registroLeido(0).ToString + " " + registroLeido(1).ToString + " " + registroLeido(2).ToString + " " + registroLeido(3).ToString + " " + registroLeido(4).ToString + " " + registroLeido(5).ToString + " " + registroLeido(6).ToString + " " + registroLeido(7).ToString)
                    dRMA.CodigoEntrada = registroLeido(0)
                    dRMA.FechaDeEntrada = registroLeido(1)
                    dRMA.Nombre = registroLeido(3).ToString
                    dRMA.DireccionCliente = registroLeido(4)
                    dRMA.TelefonoCliente = registroLeido(5)
                    dRMA.EmailCliente = registroLeido(7)
                    dRMA.DescripcionProblema = registroLeido(8)
                    dRMA.ObservacionesUsuario = registroLeido(10)
                End While

                Return True
            Else
                MsgBox("No existen registros para el código de entrada proporcionado.")
                Return False
            End If
        Catch ex As Exception
            MsgBox("Error en datos: " + ex.Message)
            Return False
        Finally
            desconectar()

        End Try
    End Function

End Class
