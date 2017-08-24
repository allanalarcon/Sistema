Imports System.ComponentModel

Public Class frmservicio
    Private dt As New DataTable
    Dim save_edit As New Integer

    Private Sub bloqueartext()
        txtdescripcion.BorderStyle = BorderStyle.None
        txtprecio.BorderStyle = BorderStyle.None

        txtdescripcion.ReadOnly = True
        txtprecio.ReadOnly = True
        txtprecio.BackColor = Color.White
    End Sub

    Private Sub bloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btneditar.Enabled = False
        btnnuevo.Enabled = False
    End Sub

    Private Sub desbloqueartext()
        txtdescripcion.BorderStyle = BorderStyle.FixedSingle
        txtprecio.BorderStyle = BorderStyle.FixedSingle

        txtdescripcion.ReadOnly = False
        txtprecio.ReadOnly = False
    End Sub

    Private Sub desbloquearbtn()
        btnguardar.Enabled = True
        btncancelar.Enabled = True
        btneliminar.Enabled = True
        btneditar.Enabled = True
        btnnuevo.Enabled = True
    End Sub

    Private Sub frmservicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fservicio
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
        dgvlistado.Columns("idservicio").Visible = False

        'Visibles
        dgvlistado.Columns("descripcion").HeaderText = "Descripción"
        dgvlistado.Columns("descripcion").Width = 300

        dgvlistado.Columns("precio").HeaderText = "Precio"
        dgvlistado.Columns("precio").Width = 80
        dgvlistado.Columns("precio").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "descripcion like '" & txtbuscar.Text & "%'"

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
        txtdescripcion.Text = ""
        txtprecio.Text = ""
    End Sub

    Private Sub txtbuscar_TextChanged(sender As Object, e As EventArgs) Handles txtbuscar.TextChanged
        buscar()
    End Sub

    Private Sub dgvlistado_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellClick
        limpiar()
        txtdescripcion.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
        txtprecio.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
        desbloquearbtn()
        bloqueartext()
        desbloquearbtn()
        btnguardar.Enabled = False
        btncancelar.Enabled = False
    End Sub

    Private Sub txtdescripcion_Validating(sender As Object, e As CancelEventArgs) Handles txtdescripcion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtprecio_Validating(sender As Object, e As CancelEventArgs)
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

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        desbloqueartext()
        save_edit = 0
        desbloquearbtn()
        btnnuevo.Enabled = False
        btneliminar.Enabled = False
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        txtbuscar.Select()
        If save_edit = 1 Then
            If Me.ValidateChildren = True And txtdescripcion.Text <> "" And txtprecio.Text <> "" Then
                Try
                    Dim dts As New vservicio
                    Dim func As New fservicio

                    dts.gdescripcion = txtdescripcion.Text
                    dts.gprecio = txtprecio.Text

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

                If Me.ValidateChildren = True And txtdescripcion.Text <> "" And txtprecio.Text <> "" Then
                    Try
                        Dim dts As New vservicio
                        Dim func As New fservicio

                        dts.gidservicio = dgvlistado.SelectedCells.Item(0).Value
                        dts.gdescripcion = txtdescripcion.Text
                        dts.gprecio = txtprecio.Text

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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        txtbuscar.Select()
        Dim result As DialogResult

        result = MessageBox.Show("¿Desea eliminar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtdescripcion.Text <> "" And txtprecio.Text <> "" Then
                Try
                    Dim dts As New vservicio
                    Dim func As New fservicio

                    dts.gidservicio = dgvlistado.SelectedCells.Item(0).Value

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
        If txtbandera.Text = "1" Then
            frmventas.txtidservicio.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmventas.txtservicio.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            frmventas.txtprecios.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
            txtbandera.Text = "0"
            frmcontenedor.pnpantallas.Controls.Clear()
            frmventas.TopLevel = False
            frmventas.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmventas)
            frmventas.Show()
            Me.Close()
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        txtbuscar.Select()
        bloqueartext()
        bloquearbtn()
        btnnuevo.Enabled = True
    End Sub
End Class