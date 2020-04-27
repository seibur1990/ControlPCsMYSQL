Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms

Public Class Class1
    Public Function mostrar(tabla As String) As DataTable   ' como se llena el  datagridview segun video
        Dim datos As New DataTable
        Dim adapter As SqlDataAdapter
        Dim ds As New DataSet

        Dim sql As String = "SELECT id_incidencia, usr, id_pc, data, hora, problema, id_prioritat, estat, solucio, darrera_ullada, id_cat ,id_estat,assignada  FROM incidencies "
        'Select * From "& tabla

        Try
            conSQL.Open()
            adapter = New SqlDataAdapter(sql, conSQL)
            adapter.Fill(ds)
            datos = ds.Tables(0)

            conMySQL.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return datos

    End Function

    Public Function filtrar(tabla As String, criterio As String, campo As String) As DataSet
        Dim datos As New DataTable
        Dim adapter As SqlDataAdapter
        Dim ds As resolutionDataSet
        '  sql = "SELECT id_incidencia, usr, id_pc, data, problema, solucio, id_cat, id_estat FROM incidencies " & condicion

        Dim sql As String = "select * from incidencies where " & campo & " like '%" & criterio & "%'"


        Try
            conSQL.Open()
            adapter = New SqlDataAdapter(sql, conSQL.ConnectionString)
            adapter.Fill(ds)
            ' datos = ds.Tables(0)

            conSQL.Close()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return ds
    End Function

End Class
