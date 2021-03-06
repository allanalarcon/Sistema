﻿Imports System.Data.SqlClient

Public Class fpago
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_pagos")
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

    Public Function ingresar(ByVal dts As vpago) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_pago")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idempleado", dts.gidempleado)
            cmd.Parameters.AddWithValue("@pago", dts.gpago)
            cmd.Parameters.AddWithValue("@fechapago", dts.gfechapago)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function editar(ByVal dts As vpago) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_pago")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)
            cmd.Parameters.AddWithValue("@idempleado", dts.gidempleado)
            cmd.Parameters.AddWithValue("@pago", dts.gpago)
            cmd.Parameters.AddWithValue("@fechapago", dts.gfechapago)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function eliminar(ByVal dts As vpago) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_pago")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idpago", dts.gidpago)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()
        End Try
    End Function

    Public Function obtener_fecha(ByVal dts As Integer) As Date
        Try
            conectado()
            cmd = New SqlCommand("obtener_fecha")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idempleado", dts)

            If cmd.ExecuteNonQuery Then
                Return cmd.ExecuteScalar
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

    Public Function generar_tabla(ByVal dts As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date) As DataTable
        Try
            conectado()
            cmd = New SqlCommand("generar_tabla")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idempleado", dts)
            cmd.Parameters.AddWithValue("@fechaultima", fecha1)
            cmd.Parameters.AddWithValue("@fechaactual", fecha2)

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

    Public Function generar_total(ByVal dts As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date) As Double
        Try
            conectado()
            cmd = New SqlCommand("generar_total")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idempleado", dts)
            cmd.Parameters.AddWithValue("@fechaultima", fecha1)
            cmd.Parameters.AddWithValue("@fechaactual", fecha2)

            If cmd.ExecuteNonQuery Then
                Return cmd.ExecuteScalar
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