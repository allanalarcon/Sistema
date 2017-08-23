Public Class frmventas
    Private Sub btbuscarc_Click(sender As Object, e As EventArgs) Handles btbuscarc.Click
        frmcliente.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmcliente.TopLevel = False
        frmcliente.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmcliente)
        frmcliente.Show()
    End Sub

    Private Sub btbuscare_Click(sender As Object, e As EventArgs) Handles btbuscare.Click
        frmempleado.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmempleado.TopLevel = False
        frmempleado.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmempleado)
        frmempleado.Show()
    End Sub
End Class