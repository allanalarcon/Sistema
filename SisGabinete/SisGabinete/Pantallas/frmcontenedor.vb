Public Class frmcontenedor
    Private Sub frmcontenedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnpantallas.Visible = False
        pnbotones.Visible = False
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

    Private Sub iniciar(ByVal user As String, password As String)

    End Sub
    Private Sub btingresar_Click(sender As Object, e As EventArgs) Handles btingresar.Click

    End Sub

    Private Sub txtuser_KeyDown(sender As Object, e As KeyEventArgs) Handles txtuser.KeyDown

    End Sub

    Private Sub txtpassword_KeyDown(sender As Object, e As KeyEventArgs) Handles txtpassword.KeyDown

    End Sub

    Private Sub btsalir_Click(sender As Object, e As EventArgs) Handles btsalir.Click
        End
    End Sub
End Class