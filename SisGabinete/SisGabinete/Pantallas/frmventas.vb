Imports System.ComponentModel

Public Class frmventas

    Private dt As New DataTable

    Private Sub btbuscarc_Click(sender As Object, e As EventArgs) Handles btbuscarc.Click
        txtnombrec.Enabled = False
        txtapellidoc.Enabled = False
        checkgenerico.Checked = False
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
            checkgenerico.Enabled = False
        End If
    End Sub

    Private Sub btbuscarp_Click(sender As Object, e As EventArgs) Handles btbuscarp.Click
        frmproducto.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmproducto.TopLevel = False
        frmproducto.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmproducto)
        frmproducto.Show()
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidcliente.Text <> "" And txtnombrec.Text <> "" And txthora.Text <> "  :" Then
            Try
                Dim dts As New vventa
                Dim func As New fventa

                dts.gidcliente = txtidcliente.Text
                dts.gfecha = Format(dtpfecha.Value, "dd/MM/yyyy")
                dts.ghora = txthora.Text
                dts.gtotal = 0
                dts.greserva = 0

                If func.ingresar(dts) Then
                    MessageBox.Show("Registro completado", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("No se pudo completar el registro", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos incompletos. Llene los campos obligatorios", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub frmventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fventa
            dt = func.mostrar()

            If dt.Rows.Count <> 0 Then
                dgvlistado.DataSource = dt
                txtbuscar.Enabled = True
                dgvlistado.ColumnHeadersVisible = True
                'modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
                txtbuscar.Enabled = False
                dgvlistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgvlistado.DataSource = dv
                'modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtidcliente.Text = ""
        txtidempleado.Text = ""
        txtidservicio.Text = ""
        txtidproducto.Text = ""
        txtnombrec.Text = ""
        txtapellidoc.Text = ""
        txthora.Text = ""
        txtempleado.Text = ""
        txtservicio.Text = ""
        txtprecios.Text = ""
        txtidservicio.Text = ""
        txtcantidads.Text = "1"
        txtcantidadp.Text = ""
        txtproducto.Text = ""
        txtstock.Text = "1"
        txtpreciop.Text = ""
        txtcantidadp.Text = "1"
        dgvservicios.DataSource = Nothing
        dgvservicios.ColumnHeadersVisible = False
        dgvproductos.DataSource = Nothing
        dgvproductos.ColumnHeadersVisible = False
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub
End Class