Public Class frmproducto
    Private dt As New DataTable

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fproducto
            dt = func.mostrar()

            If dt.Rows.Count <> 0 Then
                dgvlistado.DataSource = dt
                txtbuscar.Enabled = True
                dgvlistado.ColumnHeadersVisible = True
                modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
                txtbuscar.Enabled = False
                dgvlistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub modificar_columnas()

        dgvlistado.CurrentRow.Selected = False

        'Ocultas
        dgvlistado.Columns("descripcion").Visible = False
        dgvlistado.Columns("proveedor").Visible = False
        dgvlistado.Columns("nombre_vendedor").Visible = False
        dgvlistado.Columns("apellido_vendedor").Visible = False

        'Visibles
        dgvlistado.Columns("idproducto").HeaderText = "Código"
        dgvlistado.Columns("idproducto").Width = 30

        dgvlistado.Columns("producto").HeaderText = "Nombre"
        dgvlistado.Columns("producto").Width = 150

        dgvlistado.Columns("precioventa").HeaderText = "Precio Unitario"
        dgvlistado.Columns("precioventa").Width = 30

        dgvlistado.Columns("stock").HeaderText = "Stock"
        dgvlistado.Columns("stock").Width = 30

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre like '" & txtbuscar.Text & "%'"

            If dv.Count <> 0 Then
                dgvlistado.DataSource = dv
                modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub limpiar()
        txtcodigo.Text = ""
        txtnombre.Text = ""
        txtdescripcion.Text = ""
        txtprecio.Text = ""
        txtstock.Text = ""
        txtnombrevendedor.Text = ""
        txtapellidovendedor.Text = ""
        txtproveedor.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        limpiar()
        txtcodigo.Text = dgvlistado.SelectedCells.Item(0).Value.ToString.ToString
        txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString.ToString
        txtdescripcion.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        txtprecio.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        txtstock.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
        txtnombrevendedor.Text = dgvlistado.SelectedCells.Item(6).Value.ToString
        txtapellidovendedor.Text = dgvlistado.SelectedCells.Item(7).Value.ToString
        txtproveedor.Text = dgvlistado.SelectedCells.Item(5).Value.ToString

    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class