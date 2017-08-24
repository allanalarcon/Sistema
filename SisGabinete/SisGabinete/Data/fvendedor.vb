Imports System.Data.SqlClient

Public Class fvendedor
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_vendedores")
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

    Public Function ingresar(ByVal dts As vvendedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_vendedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@celular", dts.gtelefono)
            cmd.Parameters.AddWithValue("@cedula", dts.gcedula)
            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)

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

    Public Function editar(ByVal dts As vvendedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_vendedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idvendedor", dts.gidvendedor)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@apellido", dts.gapellido)
            cmd.Parameters.AddWithValue("@celular", dts.gtelefono)
            cmd.Parameters.AddWithValue("@cedula", dts.gcedula)
            cmd.Parameters.AddWithValue("@idproveedor", dts.gidproveedor)

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

    Public Function eliminar(ByVal dts As vvendedor) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_vendedor")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idvendedor", dts.gidvendedor)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__producto__idvend__3B40CD36"". The conflict occurred in database ""dbGabinete"", table ""dbo.producto"", column 'idvendedor'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar el vendedor. Tiene productos registrados.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class