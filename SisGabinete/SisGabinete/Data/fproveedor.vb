Imports System.Data.SqlClient

Public Class fproveedor
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_proveedores")
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

    Public Function ingresar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)

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

    Public Function editar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@direccion", dts.gdireccion)
            cmd.Parameters.AddWithValue("@telefono", dts.gtelefono)
            cmd.Parameters.AddWithValue("@email", dts.gemail)

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

    Public Function eliminar(ByVal dts As vproveedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_proveedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__vendedor__idprov__30C33EC3"". The conflict occurred in database ""dbGabinete"", table ""dbo.vendedor"", column 'idproveedor'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar el proveedor. Tiene vendedores registrados.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class