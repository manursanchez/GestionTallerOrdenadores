Imports System.Data.OleDb
Public Class FrmListado
    Private Sub FrmListado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\manue\OneDrive - UNED\Trabajos y artículos\Desarrollos Visual Basic\RMA_2021\RMA2021\RMA2021\RMA.MDB")
        Dim comandoSQL As New OleDbCommand("SELECT * FROM RMA", con)
        Dim miDataReader As OleDbDataReader
        Dim miDataTable As New DataTable()
        con.Open()
        miDataReader = comandoSQL.ExecuteReader
        miDataTable.Load(miDataReader)
        Me.DataGridView1.DataSource = miDataTable
        con.Close()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        Me.Close()
    End Sub
End Class