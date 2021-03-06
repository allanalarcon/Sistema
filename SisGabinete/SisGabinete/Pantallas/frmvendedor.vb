﻿Imports System.ComponentModel

Public Class frmvendedor

    Private dt As New DataTable
    Dim save_edit As New Integer

    Private Sub bloqueartext()
        txtnombre.BorderStyle = BorderStyle.None
        txtapellido.BorderStyle = BorderStyle.None
        txtcedula.BorderStyle = BorderStyle.None
        txttelefono.BorderStyle = BorderStyle.None
        txtproveedor.BorderStyle = BorderStyle.None
        btbuscarp.Visible = False

        txtnombre.ReadOnly = True
        txtapellido.ReadOnly = True
        txtcedula.ReadOnly = True
        txttelefono.ReadOnly = True
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
        txtapellido.BorderStyle = BorderStyle.FixedSingle
        txtcedula.BorderStyle = BorderStyle.FixedSingle
        txttelefono.BorderStyle = BorderStyle.FixedSingle
        txtproveedor.BorderStyle = BorderStyle.FixedSingle
        btbuscarp.Visible = True

        txtnombre.ReadOnly = False
        txtapellido.ReadOnly = False
        txtcedula.ReadOnly = False
        txttelefono.ReadOnly = False
    End Sub

    Private Sub desbloquearbtn()
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btneliminar.Enabled = True
        btneditar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub frmvendedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fvendedor
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
        dgvlistado.Columns("idvendedor").Visible = False
        dgvlistado.Columns("idproveedor").Visible = False
        dgvlistado.Columns("cedula").Visible = False
        dgvlistado.Columns("apellido").Visible = False

        'Visibles
        dgvlistado.Columns("nombrep").HeaderText = "Proveedor"
        dgvlistado.Columns("nombrep").Width = 150

        dgvlistado.Columns("nombrev").HeaderText = "Nombre del vendedor"
        dgvlistado.Columns("nombrev").Width = 150

        'dgvlistado.Columns("apellido").HeaderText = "Apellidos"
        'dgvlistado.Columns("apellido").Width = 150

        dgvlistado.Columns("celular").HeaderText = "Teléfono"
        dgvlistado.Columns("celular").Width = 80
        dgvlistado.Columns("celular").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombrev like '" & txtbuscar.Text & "%'"

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
        txttelefono.Text = ""
        txtproveedor.Text = ""
        txtidproveedor.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        limpiar()
        txtnombre.Text = dgvlistado.SelectedCells.Item(2).Value.ToString.ToString
        txtapellido.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        txtcedula.Text = dgvlistado.SelectedCells.Item(4).Value.ToString
        txttelefono.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
        txtproveedor.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
        txtidproveedor.Text = dgvlistado.SelectedCells.Item(6).Value.ToString
        desbloquearbtn()
        bloqueartext()
        desbloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtcedula_Validating(sender As Object, e As CancelEventArgs) Handles txtcedula.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtproveedor_Validating(sender As Object, e As CancelEventArgs) Handles txtproveedor.Validating
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
            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtcedula.Text <> "" And txtproveedor.Text <> "" And txtidproveedor.Text <> "" Then
                Try
                    Dim dts As New vvendedor
                    Dim func As New fvendedor

                    dts.gnombre = txtnombre.Text
                    dts.gapellido = txtapellido.Text
                    dts.gcedula = txtcedula.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gidproveedor = txtidproveedor.Text

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

                If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtcedula.Text <> "" And txtproveedor.Text <> "" And txtidproveedor.Text <> "" Then
                    Try
                        Dim dts As New vvendedor
                        Dim func As New fvendedor

                        dts.gidvendedor = dgvlistado.SelectedCells.Item(0).Value
                        dts.gnombre = txtnombre.Text
                        dts.gapellido = txtapellido.Text
                        dts.gcedula = txtcedula.Text
                        dts.gtelefono = txttelefono.Text
                        dts.gidproveedor = txtidproveedor.Text

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
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
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

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtcedula.Text <> "" And txtproveedor.Text <> "" Then
                Try
                    Dim dts As New vvendedor
                    Dim func As New fvendedor

                    dts.gidvendedor = dgvlistado.SelectedCells.Item(0).Value

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

    Private Sub dgvlistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellDoubleClick
        frmproducto.txtidvendedor.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
        frmproducto.txtnombrevendedor.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        frmproducto.txtapellidovendedor.Text = dgvlistado.SelectedCells.Item(3).Value.ToString
        frmproducto.txtidproveedor.Text = dgvlistado.SelectedCells.Item(6).Value.ToString
        frmproducto.txtproveedor.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
        txtbandera.Text = "0"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmproducto.TopLevel = False
        frmproducto.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmproducto)
        frmproducto.Show()
        Me.Close()
    End Sub

    Private Sub btbuscarp_Click(sender As Object, e As EventArgs) Handles btbuscarp.Click
        frmproveedor.txtbandera.Text = "1"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmproveedor.TopLevel = False
        frmproveedor.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmproveedor)
        frmproveedor.Show()
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtbuscar.Select()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub
End Class