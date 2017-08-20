Public Class frmpago

    Private dt As New DataTable

    Private Sub frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fpago
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
        dgvlistado.Columns("idpago").Visible = False

        'Visibles
        dgvlistado.Columns("nombre").HeaderText = "Nombres"
        dgvlistado.Columns("nombre").Width = 150

        dgvlistado.Columns("apellido").HeaderText = "Apellidos"
        dgvlistado.Columns("apellido").Width = 150

        dgvlistado.Columns("pago").HeaderText = "Pago"
        dgvlistado.Columns("pago").Width = 80
        dgvlistado.Columns("pago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

        dgvlistado.Columns("fechapago").HeaderText = "Fecha"
        dgvlistado.Columns("fechapago").Width = 80
        dgvlistado.Columns("fechapago").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter

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
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtpago.Text = ""
        txtfecha.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        limpiar()
        txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString.ToString
        txtapellido.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        txtpago.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        Dim fecha As String = dgvlistado.SelectedCells.Item(6).Value.ToString
    End Sub

    Private Sub txtnombre_TextChanged(sender As Object, e As EventArgs) Handles txtnombre.TextChanged

    End Sub
End Class