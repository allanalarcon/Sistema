Imports System.ComponentModel

Public Class frmempleado

    Private dt As New DataTable

    Private Sub frmempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mostrar()
    End Sub

    Private Sub mostrar()
        Try
            Dim func As New fempleado
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
        dgvlistado.Columns("idempleado").Visible = False
        dgvlistado.Columns("direccion").Visible = False
        dgvlistado.Columns("email").Visible = False
        dgvlistado.Columns("fechanacimiento").Visible = False
        dgvlistado.Columns("cedula").Visible = False
        dgvlistado.Columns("tipo").Visible = False

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
            txtfecha.Text = Format(dgvlistado.SelectedCells.Item(6).Value, "dd/MM/yyyy")
            txtedad.Text = DateDiff(DateInterval.Year, dgvlistado.SelectedCells.Item(6).Value, Date.Now)
        End If
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

    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "Campo Obligatorio")
        End If
    End Sub

    Private Sub txttelefono_Validating(sender As Object, e As CancelEventArgs) Handles txttelefono.Validating
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

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btneditar_Click(sender As Object, e As EventArgs) Handles btneditar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Desea modificar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtcedula.Text <> "" Then
                Try
                    Dim dts As New vempleado
                    Dim func As New fempleado

                    dts.gidempleado = dgvlistado.SelectedCells.Item(0).Value
                    dts.gnombre = txtnombre.Text
                    dts.gapellido = txtapellido.Text
                    dts.gdireccion = txtdireccion.Text
                    dts.gtelefono = txttelefono.Text
                    dts.gemail = txtemail.Text
                    dts.gfechanacimiento = txtfecha.Text
                    dts.gcedula = txtcedula.Text
                    dts.gtipo = dgvlistado.SelectedCells.Item(8).Value.ToString


                    If func.editar(dts) Then
                        MessageBox.Show("Editar completado", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se pudo completar la edición", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtcedula.Text <> "" Then
            Try
                Dim dts As New vempleado
                Dim func As New fempleado

                dts.gnombre = txtnombre.Text
                dts.gapellido = txtapellido.Text
                dts.gdireccion = txtdireccion.Text
                dts.gtelefono = txttelefono.Text
                dts.gemail = txtemail.Text
                dts.gfechanacimiento = Date.ParseExact(txtfecha.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
                dts.gcedula = txtcedula.Text
                dts.gtipo = 0

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

    Private Sub btneliminar_Click(sender As Object, e As EventArgs) Handles btneliminar.Click
        Dim result As DialogResult

        result = MessageBox.Show("¿Desea eliminar los datos?", "Modificando Datos", MessageBoxButtons.OKCancel, MessageBoxIcon.Question)

        If result = DialogResult.OK Then

            If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txttelefono.Text <> "" And txtcedula.Text <> "" Then
                Try
                    Dim dts As New vempleado
                    Dim func As New fempleado

                    dts.gidempleado = dgvlistado.SelectedCells.Item(0).Value

                    If func.eliminar(dts) Then
                        MessageBox.Show("Eliminar completado", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        mostrar()
                        limpiar()
                    Else
                        MessageBox.Show("No se pudo completar la eliminación", "Eliminando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        mostrar()
                        limpiar()
                    End If
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MessageBox.Show("Datos incompletos. Llene los campos obligatorios", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Private Sub dgvlistado_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvlistado.CellDoubleClick
        If txtbandera.Text = "1" Then
            frmventas.txtidempleado.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmventas.txtempleado.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            txtbandera.Text = "0"
            frmcontenedor.pnpantallas.Controls.Clear()
            frmventas.TopLevel = False
            frmventas.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmventas)
            frmventas.Show()
            Me.Close()
        ElseIf txtbandera.Text = "2" Then
            frmpago.txtidempleado.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmpago.txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            frmpago.txtapellido.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
            txtbandera.Text = "0"
            frmcontenedor.pnpantallas.Controls.Clear()
            frmpago.TopLevel = False
            frmpago.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmpago)
            frmpago.Show()
            Me.Close()
        ElseIf txtbandera.Text = "3" Then
            frmgenerarpago.txtidempleado.Text = dgvlistado.SelectedCells.Item(0).Value.ToString
            frmgenerarpago.txtnombre.Text = dgvlistado.SelectedCells.Item(1).Value.ToString
            frmgenerarpago.txtapellido.Text = dgvlistado.SelectedCells.Item(2).Value.ToString
            txtbandera.Text = "0"
            frmcontenedor.pnpantallas.Controls.Clear()
            frmgenerarpago.TopLevel = False
            frmgenerarpago.Visible = True
            frmcontenedor.pnpantallas.Controls.Add(frmgenerarpago)
            frmgenerarpago.Show()
            Me.Close()
        End If
    End Sub
End Class