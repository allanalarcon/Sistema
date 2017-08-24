Imports System.ComponentModel

Public Class frmproducto
    Private dt As New DataTable
    Dim save_edit As New Integer

    Private Sub bloqueartext()
        txtnombre.BorderStyle = BorderStyle.None
        txtprecio.BorderStyle = BorderStyle.None
        txtdescripcion.BorderStyle = BorderStyle.None
        txtstock.BorderStyle = BorderStyle.None
        txtproveedor.BorderStyle = BorderStyle.None
        txtnombrevendedor.BorderStyle = BorderStyle.None
        txtapellidovendedor.BorderStyle = BorderStyle.None
        btbuscarv.Visible = False

        txtnombre.ReadOnly = True
        txtprecio.ReadOnly = True
        txtdescripcion.ReadOnly = True
        txtstock.ReadOnly = True
    End Sub

    Private Sub bloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btneditar.Enabled = False
        btnnuevo.Enabled = False
    End Sub

    Private Sub desbloqueartext()
        txtnombre.BorderStyle = BorderStyle.FixedSingle
        txtprecio.BorderStyle = BorderStyle.FixedSingle
        txtdescripcion.BorderStyle = BorderStyle.FixedSingle
        txtstock.BorderStyle = BorderStyle.FixedSingle
        txtproveedor.BorderStyle = BorderStyle.FixedSingle
        txtnombrevendedor.BorderStyle = BorderStyle.FixedSingle
        txtapellidovendedor.BorderStyle = BorderStyle.FixedSingle
        btbuscarv.Visible = True

        txtnombre.ReadOnly = False
        txtprecio.ReadOnly = False
        txtdescripcion.ReadOnly = False
        txtstock.ReadOnly = False
    End Sub

    Private Sub desbloquearbtn()
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btneliminar.Enabled = True
        btneditar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub frmcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
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
        dgvlistado.Columns("nombre_vendedor").Visible = False
        dgvlistado.Columns("apellido_vendedor").Visible = False
        dgvlistado.Columns("idproducto").Visible = False
        dgvlistado.Columns("idvendedor").Visible = False

        'Visibles

        dgvlistado.Columns("producto").HeaderText = "Nombre"
        dgvlistado.Columns("producto").Width = 150

        dgvlistado.Columns("proveedor").HeaderText = "Proveedor"
        dgvlistado.Columns("proveedor").Width = 150

        dgvlistado.Columns("precioventa").HeaderText = "Precio"
        dgvlistado.Columns("precioventa").Width = 40

        dgvlistado.Columns("stock").HeaderText = "Stock"
        dgvlistado.Columns("stock").Width = 40

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
        txtprecio.Text = ""
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
        txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString.ToString
        txtdescripcion.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        txtprecio.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
        txtstock.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
        txtnombrevendedor.Text = dgvlistado.SelectedCells.Item(6).Value.ToString
        txtapellidovendedor.Text = dgvlistado.SelectedCells.Item(7).Value.ToString
        txtproveedor.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        txtidvendedor.Text = dgvlistado.SelectedCells.Item(8).Value.ToString
        desbloquearbtn()
        bloqueartext()
        desbloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
    End Sub

    Private Sub dgvlistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellDoubleClick
        If txtbandera.Text = "1" Then
            frmventas.txtidproducto.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmventas.txtproducto.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            frmventas.txtpreciop.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
            frmventas.txtstock.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
            txtbandera.Text = "0"
            frmcontenedor.pnpantallas.Controls.Clear()
            frmventas.TopLevel = False
            frmventas.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmventas)
            frmventas.Show()
            frmventas.txtcantidadp.Maximum = frmventas.txtstock.Text
            Me.Close()
        End If
    End Sub

    Private Sub btbuscarv_Click(sender As Object, e As EventArgs) Handles btbuscarv.Click
        frmvendedor.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmvendedor.TopLevel = False
        frmvendedor.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmvendedor)
        frmvendedor.Show()
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs) Handles txtprecio.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtstock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtstock_Validating(sender As Object, e As CancelEventArgs) Handles txtstock.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtnombrevendedor_Validating(sender As Object, e As CancelEventArgs) Handles txtnombrevendedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtapellidovendedor_Validating(sender As Object, e As CancelEventArgs) Handles txtnombrevendedor.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        desbloqueartext()
        save_edit = 1
        desbloquearbtn()
        btneditar.Enabled = False
        btneliminar.Enabled = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        txtbuscar.Select()
        If save_edit = 1 Then
            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtprecio.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtnombrevendedor.Text <> "" And txtapellidovendedor.Text <> "" Then
                Try
                    Dim dts As New vproducto
                    Dim func As New fproducto

                    dts.gnombre = txtnombre.Text
                    dts.gdescripcion = txtdescripcion.Text
                    dts.gprecioventa = txtprecio.Text
                    dts.gstock = txtstock.Text
                    dts.gidvendedor = txtidvendedor.Text

                    If func.ingresar(dts) Then
                        MessageBox.Show("Registro completado.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloqueartext()
                        bloquearbtn()
                        btnnuevo.Enabled = True
                    Else
                        MessageBox.Show("No se pudo completar el registro.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        ElseIf save_edit = 0 Then
            Dim result As DialogResult

            result = MessageBox.Show("¿Desea modificar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

            If result = DialogResult.OK Then

                If Me.ValidateChildren = True And txtnombre.Text <> "" And txtprecio.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtnombrevendedor.Text <> "" And txtapellidovendedor.Text <> "" Then
                    'Try
                    Dim dts As New vproducto
                        Dim func As New fproducto

                        dts.gidproducto = dgvlistado.SelectedCells.Item(0).Value.ToString
                        dts.gnombre = txtnombre.Text
                        dts.gdescripcion = txtdescripcion.Text
                        dts.gprecioventa = txtprecio.Text
                        dts.gstock = txtstock.Text
                        dts.gidvendedor = txtidvendedor.Text

                        If func.editar(dts) Then
                            MessageBox.Show("Edición completada.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            mostrar()
                            limpiar()
                            bloqueartext()
                            bloquearbtn()
                            btnnuevo.Enabled = True
                        Else
                            MessageBox.Show("No se pudo completar la edición.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End If
                    'Catch ex As Exception
                    'MsgBox(ex.Message)
                    'End Try
                Else
                    MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        desbloqueartext()
        save_edit = 0
        desbloquearbtn()
        btnnuevo.Enabled = False
        btneliminar.Enabled = False
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        txtbuscar.Select()
        Dim result As DialogResult

        result = MessageBox.Show("¿Desea eliminar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtprecio.Text <> "" And txtdescripcion.Text <> "" And txtstock.Text <> "" And txtnombrevendedor.Text <> "" And txtapellidovendedor.Text <> "" Then
                Try
                    Dim dts As New vproducto
                    Dim func As New fproducto

                    dts.gidproducto = dgvlistado.SelectedCells.Item(0).Value

                    If func.eliminar(dts) Then
                        MessageBox.Show("Eliminar completado.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloqueartext()
                        bloquearbtn()
                        btnnuevo.Enabled = True
                    Else
                        MessageBox.Show("No se pudo completar la eliminación.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios.", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtbuscar.Select()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub
End Class