﻿Imports System.Data.SqlClient

Public Class fservicio
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar(ByVal tabla As String)
        Try
            conectado()
            cmd = New SqlCommand("mostrar_servicios")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function
End Class
