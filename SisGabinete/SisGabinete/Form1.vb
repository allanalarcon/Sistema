Imports System.Data.SqlClient

Public Class Form1
    Dim cn As conexion = New conexion()
    Dim cmd As New SqlCommand

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        mostrar("clientes")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        mostrar("empleados")
    End Sub

    Private Sub mostrar(ByVal tabla As String)
        Try
            cn.conectado()
            cmd = New SqlCommand("mostrar_" & tabla)
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cn.cn

            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                DataGridView1.DataSource = dt
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            cn.desconectado()
        End Try
    End Sub
End Class
