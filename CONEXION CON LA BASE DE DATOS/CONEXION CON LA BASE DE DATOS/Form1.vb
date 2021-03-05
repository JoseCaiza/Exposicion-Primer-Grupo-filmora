Imports System.Data
Imports System.Data.OleDb
Public Class Form1
    Dim conexion As New OleDbConnection
    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        Try
            conexion.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\JIMMY DELGADO\Desktop\data1.accdb"
            conexion.Open()
            'mostrar()
            MsgBox("conexion exitosa")
        Catch ex As Exception
            MsgBox("no se realizo la conexion")

        End Try
        Dim adaptador As New OleDbDataAdapter("select*from CLIENTE", conexion)
        Dim datos As New DataSet
        adaptador.Fill(datos)
        DataGridView1.DataSource = datos.Tables(0)
    End Sub

End Class
