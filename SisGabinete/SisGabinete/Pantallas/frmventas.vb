Public Class frmventas
    Private Sub btbuscarc_Click(sender As Object, e As EventArgs) Handles btbuscarc.Click
        txtnombrec.Enabled = False
        txtapellidoc.Enabled = False
        checknuevo.Checked = False
        checkgenerico.Checked = False
        checknuevo.Enabled = True
        checkgenerico.Enabled = True
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

    Private Sub btbuscars_Click(sender As Object, e As EventArgs) Handles btbuscars.Click
        frmservicio.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmservicio.TopLevel = False
        frmservicio.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmservicio)
        frmservicio.Show()
    End Sub

    Private Sub checkgenerico_CheckedChanged(sender As Object, e As EventArgs) Handles checkgenerico.CheckedChanged
        If checkgenerico.Checked = True Then
            txtnombrec.Text = "Genérico"
            txtapellidoc.Text = "Genérico"
            txtidcliente.Text = 1
            txtnombrec.Enabled = False
            txtapellidoc.Enabled = False
            checknuevo.Checked = False
            checknuevo.Enabled = True
            checkgenerico.Enabled = False
        End If
    End Sub

    Private Sub checknuevo_CheckedChanged(sender As Object, e As EventArgs) Handles checknuevo.CheckedChanged
        If checknuevo.Checked = True Then
            txtnombrec.Enabled = True
            txtapellidoc.Enabled = True
            txtidcliente.Clear()
            checkgenerico.Checked = False
            checkgenerico.Enabled = True
            checknuevo.Enabled = False
        End If
    End Sub
End Class