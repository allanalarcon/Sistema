Imports System.ComponentModel

Public Class frmgenerarpago
    Private Sub btbuscarc_Click(sender As Object, e As EventArgs) Handles btbuscarc.Click
        frmempleado.txtbandera.Text = "2"
        frmcontenedor.pnpantallas.Controls.Clear()
        frmempleado.TopLevel = False
        frmempleado.Visible = True
        frmcontenedor.pnpantallas.Controls.Add(frmempleado)
        frmempleado.Show()
    End Sub

    Public Sub limpiar()
        txtidempleado.Text = ""
        txtnombre.Text = ""
        txtapellido.Text = ""
        txtultima.Text = ""
        txtpago.Text = ""
        dtpfecha.ResetText()
        dgvlistado.DataSource = Nothing
        dgvlistado.ColumnHeadersVisible = False
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
    End Sub

    Private Sub btgenerar_Click(sender As Object, e As EventArgs) Handles btgenerar.Click
        ultima_fecha(txtidempleado.Text)
        If txtultima.Text = "0:00:00" Then txtultima.Text = "01/01/1990"
        generar_tabla(txtidempleado.Text, txtultima.Text, Format(dtpfecha.Value, "dd/MM/yyyy"))
        generar_total(txtidempleado.Text, txtultima.Text, Format(dtpfecha.Value, "dd/MM/yyyy"))
    End Sub

    Private Sub ultima_fecha(ByVal dts As Integer)
        'Try
        Dim dt As New Date
            Dim func As New fpago
            dt = func.obtener_fecha(dts)
        txtultima.Text = dt
        If txtultima.Text.ToString = "00:00:00" Then txtultima.Text = "01/01/1990"
        'Catch ex As Exception
        'MsgBox(ex.Message)
        'End Try
    End Sub

    Private Sub generar_tabla(ByVal dts As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date)
        Try
            Dim func As New fpago
            Dim dt As New DataTable
            dt = func.generar_tabla(dts, fecha1, fecha2)

            If dt.Rows.Count <> 0 Then
                dgvlistado.DataSource = dt
                dgvlistado.ColumnHeadersVisible = True
                'modificar_columnas()
            Else
                dgvlistado.DataSource = Nothing
                dgvlistado.ColumnHeadersVisible = False
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub generar_total(ByVal dts As Integer, ByVal fecha1 As Date, ByVal fecha2 As Date)
        Try
            Dim func As New fpago
            Dim dt As New Double
            dt = func.generar_total(dts, fecha1, fecha2)
            txtpago.Text = dt
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
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


    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtpago.Text <> "" And txtidempleado.Text <> "" And txtultima.Text <> "" Then
            Try
                Dim dts As New vpago
                Dim func As New fpago

                dts.gidempleado = txtidempleado.Text
                dts.gpago = txtpago.Text
                dts.gfechapago = Format(dtpfecha.Value, "dd/MM/yyyy")

                If func.ingresar(dts) Then
                    MessageBox.Show("Registro completado", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    limpiar()
                Else
                    MessageBox.Show("No se pudo completar el registro", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    limpiar()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("Datos incompletos. Llene los campos obligatorios", "Guardando Registro", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub
End Class