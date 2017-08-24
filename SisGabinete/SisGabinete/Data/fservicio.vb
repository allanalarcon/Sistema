Imports System.Data.SqlClient

Public Class fservicio
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar()
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

    Public Function ingresar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_servicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)

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

    Public Function editar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_servicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idservicio", dts.gidservicio)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@precio", dts.gprecio)

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

    Public Function eliminar(ByVal dts As vservicio) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_servicio")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idservicio", dts.gidservicio)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__detalle_s__idser__42E1EEFE"". The conflict occurred in database ""dbGabinete"", table ""dbo.detalle_servicio"", column 'idservicio'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar el servicio. Existe en ventas registradas.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class