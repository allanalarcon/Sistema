Public Class frmcliente

    Private dt As New DataTable

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fcliente
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
        dgvlistado.Columns("idcliente").Visible = False
        dgvlistado.Columns("direccion").Visible = False
        dgvlistado.Columns("email").Visible = False
        dgvlistado.Columns("fechanacimiento").Visible = False
        dgvlistado.Columns("cedula").Visible = False

        'Visibles
        dgvlistado.Columns("nombre").HeaderText = "Nombres"
        dgvlistado.Columns("nombre").Width = 150

        dgvlistado.Columns("apellido").HeaderText = "Apellidos"
        dgvlistado.Columns("apellido").Width = 150

        dgvlistado.Columns("telefono").HeaderText = "Teléfono"
        dgvlistado.Columns("telefono").Width = 80
        dgvlistado.Columns("telefono").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
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
        txtcedula.Text = ""
        txtdireccion.Text = ""
        txttelefono.Text = ""
        txtemail.Text = ""
        txtfecha.Text = ""
        txtedad.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        limpiar()
        txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString.ToString
        txtapellido.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        txtcedula.Text = dgvlistado.SelectedCells.Item(7).Value.ToString
        txtdireccion.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        txttelefono.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
        txtemail.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
        Dim fecha As String = dgvlistado.SelectedCells.Item(6).Value.ToString
        If Not fecha = "" Then
            txtfecha.Text = fecha.Substring(0, fecha.Length - 8)
            txtedad.Text = DateDiff(DateInterval.Year, dgvlistado.SelectedCells.Item(6).Value, Date.Now)
        End If
    End Sub
End Class