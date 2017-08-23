Public Class frmcontenedor
    Private Sub frmcontenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnpantallas.Visible = False
        pnbotones.Visible = False
        pnbotones2.Visible = False
    End Sub

    Private Sub btclientes_Click(sender As Object, e As EventArgs) Handles btclientes.Click
        pnpantallas.Controls.Clear()
        frmcliente.TopLevel = False
        frmcliente.Visible = True
        pnpantallas.Controls.Add(frmcliente)
        frmcliente.Show()
    End Sub

    Private Sub btempleados_Click(sender As Object, e As EventArgs) Handles btempleados.Click
        pnpantallas.Controls.Clear()
        frmempleado.TopLevel = False
        frmempleado.Visible = True
        pnpantallas.Controls.Add(frmempleado)
        frmempleado.Show()
    End Sub

    Private Sub iniciar(ByVal user As String, password As String)
        Try
            Dim dts As New vusuario
            Dim func As New fusuario

            dts.gusuario = user
            dts.gpassword = password

            If func.validar_usuario(dts) = True Then
                pnpantallas.Visible = True
                pnbotones.Visible = True
                pnlogin.Visible = False
                pnbotones2.Visible = True
            Else
                MsgBox("Credencial incorrecta", MsgBoxStyle.Information, "Acceso denegado al sistema")
                txtpassword.Clear()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btingresar_Click(sender As Object, e As EventArgs) Handles btingresar.Click
        iniciar(txtuser.Text, txtpassword.Text)
    End Sub

    Private Sub txtuser_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtuser.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            iniciar(txtuser.Text, txtpassword.Text)
        End If
    End Sub

    Private Sub txtpassword_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpassword.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            e.Handled = True
            iniciar(txtuser.Text, txtpassword.Text)
        End If
    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        End
    End Sub

    Private Sub btventas_Click(sender As Object, e As EventArgs) Handles btventas.Click
        pnpantallas.Controls.Clear()
        frmventas.TopLevel = False
        frmventas.Visible = True
        pnpantallas.Controls.Add(frmventas)
        frmventas.Show()
    End Sub

    Private Sub btproveedor_Click(sender As Object, e As EventArgs) Handles btproveedor.Click
        pnpantallas.Controls.Clear()
        frmproveedor.TopLevel = False
        frmproveedor.Visible = True
        pnpantallas.Controls.Add(frmproveedor)
        frmproveedor.Show()
    End Sub

    Private Sub btvendedor_Click(sender As Object, e As EventArgs) Handles btvendedor.Click
        pnpantallas.Controls.Clear()
        frmvendedor.TopLevel = False
        frmvendedor.Visible = True
        pnpantallas.Controls.Add(frmvendedor)
        frmvendedor.Show()
    End Sub

    Private Sub btproductos_Click(sender As Object, e As EventArgs) Handles btproductos.Click
        pnpantallas.Controls.Clear()
        frmproducto.TopLevel = False
        frmproducto.Visible = True
        pnpantallas.Controls.Add(frmproducto)
        frmproducto.Show()
    End Sub

    Private Sub btservicios_Click(sender As Object, e As EventArgs) Handles btservicios.Click
        pnpantallas.Controls.Clear()
        frmservicio.TopLevel = False
        frmservicio.Visible = True
        pnpantallas.Controls.Add(frmservicio)
        frmservicio.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        pnpantallas.Controls.Clear()
        frmpago.TopLevel = False
        frmpago.Visible = True
        pnpantallas.Controls.Add(frmpago)
        frmpago.Show()
    End Sub
End Class