Imports System.Data.SqlClient

Public Class fusuario
    Inherits conexion
    Dim cmd As New SqlCommand

    Public Function validar_usuario(ByVal user As String, ByVal password As String)
        Try
            conectado()
            cmd = New SqlCommand("iniciar_sesion")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cn
            cmd.Parameters.AddWithValue("@usuario", user)
            cmd.Parameters.AddWithValue("@password", password)

            Dim dr As SqlDataReader
            dr = cmd.ExecuteReader

            If dr.HasRows = True Then
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
End Class
