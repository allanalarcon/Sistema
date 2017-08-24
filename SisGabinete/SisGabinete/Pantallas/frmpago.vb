Imports System.ComponentModel

Public Class frmpago

    Private dt As New DataTable

    Private Sub bloqueartext()
        txtnombre.BorderStyle = BorderStyle.None
        txtapellido.BorderStyle = BorderStyle.None
        txtpago.BorderStyle = BorderStyle.None
        txtfecha.BorderStyle = BorderStyle.None

        txtnombre.ReadOnly = True
        txtapellido.ReadOnly = True
        txtpago.ReadOnly = True
        txtfecha.ReadOnly = True

        txtfecha.BackColor = Color.White
    End Sub

    Private Sub bloquearbtn()
        btncancelar.Enabled = False
        btneliminar.Enabled = False
        btngenerar.Enabled = False
    End Sub

    Private Sub desbloqueartext()
        txtpago.BorderStyle = BorderStyle.FixedSingle
        txtfecha.BorderStyle = BorderStyle.FixedSingle

        txtpago.ReadOnly = False
        txtfecha.ReadOnly = False
    End Sub

    Private Sub desbloquearbtn()
        btncancelar.Enabled = True
        btneliminar.Enabled = True
        btngenerar.Enabled = True
    End Sub

    Private Sub frmpago_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
        bloqueartext()
        bloquearbtn()
        btngenerar.Enabled = True
    End Sub

    Public Sub mostrar()
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
        dgvlistado.Columns("idempleado").Visible = False

        'Visibles
        dgvlistado.Columns("nombre").HeaderText = "Nombres"
        dgvlistado.Columns("nombre").Width = 134

        dgvlistado.Columns("apellido").HeaderText = "Apellidos"
        dgvlistado.Columns("apellido").Width = 134

        dgvlistado.Columns("pago").HeaderText = "Pago"
        dgvlistado.Columns("pago").Width = 43

        dgvlistado.Columns("fechapago").HeaderText = "Fecha"
        dgvlistado.Columns("fechapago").Width = 69

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = "nombre Like '" & txtbuscar.Text & "%'"

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
        txtidempleado.Text = dgvlistado.SelectedCells.Item(5).Value.ToString
        Dim fecha As String = dgvlistado.SelectedCells.Item(4).Value.ToString
        If Not fecha = "" Then
            txtfecha.Text = Format(dgvlistado.SelectedCells.Item(4).Value, "dd/MM/yyyy")
        End If
        desbloquearbtn()
        bloqueartext()
        desbloquearbtn()
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

    Private Sub txtpago_Validating(sender As Object, e As CancelEventArgs) Handles txtpago.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txtfecha_Validating(sender As Object, e As CancelEventArgs) Handles txtfecha.Validating
        If DirectCast(sender, MaskedTextBox).Text <> "  /  /" Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Desea eliminar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtpago.Text <> "" And txtfecha.Text <> "" And txtidempleado.Text <> "" Then
                Try
                    Dim dts As New vpago
                    Dim func As New fpago

                    dts.gidpago = dgvlistado.SelectedCells.Item(0).Value

                    If func.eliminar(dts) Then
                        MessageBox.Show("Eliminar completado.", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                        bloqueartext()
                        bloquearbtn()
                        btngenerar.Enabled = True
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
        bloqueartext()
        bloquearbtn()
        btngenerar.Enabled = True
    End Sub

    Private Sub btngenerar_Click(sender As Object, e As EventArgs) Handles btngenerar.Click
        frmcontenedor.pnpantallas.Controls.Clear()
        frmgenerarpago.TopLevel = False
        frmgenerarpago.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmgenerarpago)
        frmgenerarpago.Show()
    End Sub
End Class