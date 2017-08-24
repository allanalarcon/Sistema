Imports System.Data.SqlClient

Public Class fproducto
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_productos")
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

    Public Function ingresar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("ingresar_producto")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idvendedor", dts.gidvendedor)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@precioventa", dts.gprecioventa)
            cmd.Parameters.AddWithValue("@stock", dts.gstock)

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

    Public Function editar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("editar_producto")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)
            cmd.Parameters.AddWithValue("@idvendedor", dts.gidvendedor)
            cmd.Parameters.AddWithValue("@nombre", dts.gnombre)
            cmd.Parameters.AddWithValue("@descripcion", dts.gdescripcion)
            cmd.Parameters.AddWithValue("@precioventa", dts.gprecioventa)
            cmd.Parameters.AddWithValue("@stock", dts.gstock)

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

    Public Function eliminar(ByVal dts As vproducto) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("eliminar_producto")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn

            cmd.Parameters.AddWithValue("@idproducto", dts.gidproducto)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            If ex.Message.ToString = "The DELETE statement conflicted with the REFERENCE constraint ""FK__detalle_p__idpro__3F115E1A"". The conflict occurred in database ""dbGabinete"", table ""dbo.detalle_producto"", column 'idproducto'." & vbNewLine & "The statement has been terminated." Then
                MessageBox.Show("No se puede eliminar el producto. Existe en ventas registradas.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                MsgBox(ex.Message)
            End If
            Return False
        Finally
            desconectado()
        End Try
    End Function
End Class