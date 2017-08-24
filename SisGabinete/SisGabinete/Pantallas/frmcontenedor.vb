Public Class frmcontenedor
    Dim validador As Integer

    Public Function empleado()
        btconfiguracion.Visible = False
        Label4.Visible = False

        btproductos.Visible = False
        btproveedor.Visible = False
        btvendedor.Visible = False
        btservicios.Visible = False
        Label6.Visible = False
        Label8.Visible = False
        Label11.Visible = False
        Label12.Visible = False

        frmempleado.btnnuevo.Visible = False
        frmempleado.btnguardar.Visible = False
        frmempleado.btneliminar.Visible = False
        frmempleado.btneditar.Visible = False
        frmempleado.btncancelar.Visible = False
        frmpago.btngenerar.Visible = False
        frmpago.btneliminar.Visible = False
        frmpago.btncancelar.Visible = False
    End Function

    Public Function administrador()
        btconfiguracion.Visible = True
        Label4.Visible = True

        btproductos.Visible = True
        btproveedor.Visible = True
        btvendedor.Visible = True
        btservicios.Visible = True
        Label6.Visible = True
        Label8.Visible = True
        Label11.Visible = True
        Label12.Visible = True

        frmempleado.btnnuevo.Visible = True
        frmempleado.btnguardar.Visible = True
        frmempleado.btneliminar.Visible = True
        frmempleado.btneditar.Visible = True
        frmempleado.btncancelar.Visible = True
        frmpago.btngenerar.Visible = True
        frmpago.btneliminar.Visible = True
        frmpago.btncancelar.Visible = True
    End Function

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
                txtuser.Clear()
                txtpassword.Clear()
                pnpantallas.Visible = True
                pnbotones.Visible = True
                pnlogin.Visible = False
                pnbotones2.Visible = True
                pblogo.Visible = False
                pnpantallas.Controls.Clear()
                frmventas.TopLevel = False
                frmventas.Visible = True
                pnpantallas.Controls.Add(frmventas)
                frmventas.Show()
                administrador()
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
        pnpantallas.Visible = True
        pnbotones.Visible = True
        pnlogin.Visible = False
        pblogo.Visible = False
        pnbotones2.Visible = True
        empleado()
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

    Private Sub btpagos_Click(sender As Object, e As EventArgs) Handles btpagos.Click
        pnpantallas.Controls.Clear()
        frmpago.TopLevel = False
        frmpago.Visible = True
        pnpantallas.Controls.Add(frmpago)
        frmpago.Show()
    End Sub

    Private Sub btconfiguracion_Click(sender As Object, e As EventArgs) Handles btconfiguracion.Click
        pnpantallas.Controls.Clear()
        frmusuario.TopLevel = False
        frmusuario.Visible = True
        pnpantallas.Controls.Add(frmusuario)
        frmusuario.Show()
    End Sub

    Private Sub btexit_Click(sender As Object, e As EventArgs) Handles btexit.Click
        End
    End Sub

    Private Sub btminimizar_Click(sender As Object, e As EventArgs) Handles btminimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btcerrar_Click(sender As Object, e As EventArgs) Handles btcerrar.Click
        pnpantallas.Visible = False
        pnbotones.Visible = False
        pnbotones2.Visible = False
        pnlogin.Visible = True
        pblogo.Visible = True
    End Sub
End Class