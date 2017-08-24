<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.batncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.btagregars = New System.Windows.Forms.Button()
        Me.txtprecios = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btbuscars = New System.Windows.Forms.Button()
        Me.btbuscare = New System.Windows.Forms.Button()
        Me.txtcantidads = New System.Windows.Forms.NumericUpDown()
        Me.txtempleado = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtservicio = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.txthora = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.checkgenerico = New System.Windows.Forms.CheckBox()
        Me.btbuscarc = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtapellidoc = New System.Windows.Forms.TextBox()
        Me.txtnombrec = New System.Windows.Forms.TextBox()
        Me.piccliente = New System.Windows.Forms.PictureBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtidservicio = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtstock = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btagregarp = New System.Windows.Forms.Button()
        Me.txtpreciop = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btbuscarp = New System.Windows.Forms.Button()
        Me.txtcantidadp = New System.Windows.Forms.NumericUpDown()
        Me.txtproducto = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgvservicios = New System.Windows.Forms.DataGridView()
        Me.txtidproducto = New System.Windows.Forms.TextBox()
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        Me.txtidventa = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.pandatossec.SuspendLayout()
        CType(Me.txtcantidads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtcantidadp, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvservicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'batncancelar
        '
        Me.batncancelar.Location = New System.Drawing.Point(860, 567)
        Me.batncancelar.Name = "batncancelar"
        Me.batncancelar.Size = New System.Drawing.Size(104, 37)
        Me.batncancelar.TabIndex = 23
        Me.batncancelar.Text = "Cancelar"
        Me.batncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(380, 567)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(104, 37)
        Me.btnguardar.TabIndex = 20
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(621, 567)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(104, 37)
        Me.btneditar.TabIndex = 21
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(741, 567)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 37)
        Me.btneliminar.TabIndex = 22
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(501, 567)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 37)
        Me.btnnuevo.TabIndex = 19
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.btagregars)
        Me.pandatossec.Controls.Add(Me.txtprecios)
        Me.pandatossec.Controls.Add(Me.Label10)
        Me.pandatossec.Controls.Add(Me.btbuscars)
        Me.pandatossec.Controls.Add(Me.btbuscare)
        Me.pandatossec.Controls.Add(Me.txtcantidads)
        Me.pandatossec.Controls.Add(Me.txtempleado)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtservicio)
        Me.pandatossec.Location = New System.Drawing.Point(583, 60)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(381, 127)
        Me.pandatossec.TabIndex = 18
        '
        'btagregars
        '
        Me.btagregars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregars.Location = New System.Drawing.Point(308, 82)
        Me.btagregars.Name = "btagregars"
        Me.btagregars.Size = New System.Drawing.Size(54, 25)
        Me.btagregars.TabIndex = 20
        Me.btagregars.Text = "Add"
        Me.btagregars.UseVisualStyleBackColor = True
        '
        'txtprecios
        '
        Me.txtprecios.BackColor = System.Drawing.Color.White
        Me.txtprecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecios.ForeColor = System.Drawing.Color.Black
        Me.txtprecios.Location = New System.Drawing.Point(265, 82)
        Me.txtprecios.Name = "txtprecios"
        Me.txtprecios.Size = New System.Drawing.Size(37, 25)
        Me.txtprecios.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(214, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio"
        '
        'btbuscars
        '
        Me.btbuscars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscars.Location = New System.Drawing.Point(337, 51)
        Me.btbuscars.Name = "btbuscars"
        Me.btbuscars.Size = New System.Drawing.Size(25, 25)
        Me.btbuscars.TabIndex = 17
        Me.btbuscars.Text = "..."
        Me.btbuscars.UseVisualStyleBackColor = True
        '
        'btbuscare
        '
        Me.btbuscare.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscare.Location = New System.Drawing.Point(337, 20)
        Me.btbuscare.Name = "btbuscare"
        Me.btbuscare.Size = New System.Drawing.Size(25, 25)
        Me.btbuscare.TabIndex = 16
        Me.btbuscare.Text = "..."
        Me.btbuscare.UseVisualStyleBackColor = True
        '
        'txtcantidads
        '
        Me.txtcantidads.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidads.Location = New System.Drawing.Point(85, 82)
        Me.txtcantidads.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcantidads.Name = "txtcantidads"
        Me.txtcantidads.Size = New System.Drawing.Size(40, 25)
        Me.txtcantidads.TabIndex = 15
        Me.txtcantidads.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtempleado
        '
        Me.txtempleado.BackColor = System.Drawing.Color.White
        Me.txtempleado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtempleado.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtempleado.ForeColor = System.Drawing.Color.Black
        Me.txtempleado.Location = New System.Drawing.Point(91, 20)
        Me.txtempleado.MaxLength = 10
        Me.txtempleado.Name = "txtempleado"
        Me.txtempleado.Size = New System.Drawing.Size(240, 25)
        Me.txtempleado.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Cantidad"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Servicio"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Empleado"
        '
        'txtservicio
        '
        Me.txtservicio.BackColor = System.Drawing.Color.White
        Me.txtservicio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtservicio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtservicio.ForeColor = System.Drawing.Color.Black
        Me.txtservicio.Location = New System.Drawing.Point(91, 51)
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.Size = New System.Drawing.Size(240, 25)
        Me.txtservicio.TabIndex = 5
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.txthora)
        Me.pandatosprin.Controls.Add(Me.Label9)
        Me.pandatosprin.Controls.Add(Me.Label8)
        Me.pandatosprin.Controls.Add(Me.dtpfecha)
        Me.pandatosprin.Controls.Add(Me.checkgenerico)
        Me.pandatosprin.Controls.Add(Me.btbuscarc)
        Me.pandatosprin.Controls.Add(Me.Label7)
        Me.pandatosprin.Controls.Add(Me.txtapellidoc)
        Me.pandatosprin.Controls.Add(Me.txtnombrec)
        Me.pandatosprin.Controls.Add(Me.piccliente)
        Me.pandatosprin.Location = New System.Drawing.Point(60, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 144)
        Me.pandatosprin.TabIndex = 17
        '
        'txthora
        '
        Me.txthora.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora.Location = New System.Drawing.Point(279, 99)
        Me.txthora.Mask = "00:00:00"
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(164, 25)
        Me.txthora.TabIndex = 14
        Me.txthora.Visible = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(235, 102)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(38, 17)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Hora"
        Me.Label9.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(17, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(43, 17)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Fecha"
        '
        'dtpfecha
        '
        Me.dtpfecha.CustomFormat = ""
        Me.dtpfecha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpfecha.Location = New System.Drawing.Point(66, 99)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpfecha.Size = New System.Drawing.Size(164, 25)
        Me.dtpfecha.TabIndex = 11
        '
        'checkgenerico
        '
        Me.checkgenerico.AutoSize = True
        Me.checkgenerico.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checkgenerico.Location = New System.Drawing.Point(359, 16)
        Me.checkgenerico.Name = "checkgenerico"
        Me.checkgenerico.Size = New System.Drawing.Size(80, 21)
        Me.checkgenerico.TabIndex = 10
        Me.checkgenerico.Text = "Genérico"
        Me.checkgenerico.UseVisualStyleBackColor = True
        '
        'btbuscarc
        '
        Me.btbuscarc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscarc.Location = New System.Drawing.Point(418, 37)
        Me.btbuscarc.Name = "btbuscarc"
        Me.btbuscarc.Size = New System.Drawing.Size(25, 25)
        Me.btbuscarc.TabIndex = 9
        Me.btbuscarc.Text = "..."
        Me.btbuscarc.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Location = New System.Drawing.Point(17, 17)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 17)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Cliente"
        '
        'txtapellidoc
        '
        Me.txtapellidoc.BackColor = System.Drawing.Color.White
        Me.txtapellidoc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellidoc.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidoc.ForeColor = System.Drawing.Color.Black
        Me.txtapellidoc.Location = New System.Drawing.Point(20, 68)
        Me.txtapellidoc.Name = "txtapellidoc"
        Me.txtapellidoc.Size = New System.Drawing.Size(392, 25)
        Me.txtapellidoc.TabIndex = 3
        '
        'txtnombrec
        '
        Me.txtnombrec.BackColor = System.Drawing.Color.White
        Me.txtnombrec.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombrec.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrec.ForeColor = System.Drawing.Color.Black
        Me.txtnombrec.Location = New System.Drawing.Point(20, 37)
        Me.txtnombrec.Name = "txtnombrec"
        Me.txtnombrec.Size = New System.Drawing.Size(392, 25)
        Me.txtnombrec.TabIndex = 2
        '
        'piccliente
        '
        Me.piccliente.Location = New System.Drawing.Point(30, 20)
        Me.piccliente.Name = "piccliente"
        Me.piccliente.Size = New System.Drawing.Size(0, 0)
        Me.piccliente.TabIndex = 0
        Me.piccliente.TabStop = False
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(94, 234)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(429, 25)
        Me.txtbuscar.TabIndex = 0
        '
        'dgvlistado
        '
        Me.dgvlistado.AllowUserToAddRows = False
        Me.dgvlistado.AllowUserToDeleteRows = False
        Me.dgvlistado.AllowUserToResizeColumns = False
        Me.dgvlistado.AllowUserToResizeRows = False
        Me.dgvlistado.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvlistado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvlistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvlistado.Location = New System.Drawing.Point(60, 265)
        Me.dgvlistado.Name = "dgvlistado"
        Me.dgvlistado.ReadOnly = True
        Me.dgvlistado.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvlistado.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistado.Size = New System.Drawing.Size(463, 296)
        Me.dgvlistado.TabIndex = 1
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(423, 34)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 24
        Me.txtidcliente.Visible = False
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(652, 34)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(100, 20)
        Me.txtidempleado.TabIndex = 25
        Me.txtidempleado.Visible = False
        '
        'txtidservicio
        '
        Me.txtidservicio.Location = New System.Drawing.Point(758, 34)
        Me.txtidservicio.Name = "txtidservicio"
        Me.txtidservicio.Size = New System.Drawing.Size(100, 20)
        Me.txtidservicio.TabIndex = 26
        Me.txtidservicio.Visible = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.txtstock)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.btagregarp)
        Me.Panel1.Controls.Add(Me.txtpreciop)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.btbuscarp)
        Me.Panel1.Controls.Add(Me.txtcantidadp)
        Me.Panel1.Controls.Add(Me.txtproducto)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Location = New System.Drawing.Point(583, 217)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(381, 96)
        Me.Panel1.TabIndex = 27
        '
        'txtstock
        '
        Me.txtstock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.Location = New System.Drawing.Point(173, 51)
        Me.txtstock.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(35, 25)
        Me.txtstock.TabIndex = 22
        Me.txtstock.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(126, 53)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(41, 17)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Stock"
        '
        'btagregarp
        '
        Me.btagregarp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregarp.Location = New System.Drawing.Point(308, 51)
        Me.btagregarp.Name = "btagregarp"
        Me.btagregarp.Size = New System.Drawing.Size(54, 25)
        Me.btagregarp.TabIndex = 20
        Me.btagregarp.Text = "Add"
        Me.btagregarp.UseVisualStyleBackColor = True
        '
        'txtpreciop
        '
        Me.txtpreciop.BackColor = System.Drawing.Color.White
        Me.txtpreciop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpreciop.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpreciop.ForeColor = System.Drawing.Color.Black
        Me.txtpreciop.Location = New System.Drawing.Point(265, 51)
        Me.txtpreciop.Name = "txtpreciop"
        Me.txtpreciop.Size = New System.Drawing.Size(37, 25)
        Me.txtpreciop.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(214, 53)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 17)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Precio"
        '
        'btbuscarp
        '
        Me.btbuscarp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscarp.Location = New System.Drawing.Point(337, 20)
        Me.btbuscarp.Name = "btbuscarp"
        Me.btbuscarp.Size = New System.Drawing.Size(25, 25)
        Me.btbuscarp.TabIndex = 16
        Me.btbuscarp.Text = "..."
        Me.btbuscarp.UseVisualStyleBackColor = True
        '
        'txtcantidadp
        '
        Me.txtcantidadp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcantidadp.Location = New System.Drawing.Point(85, 51)
        Me.txtcantidadp.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txtcantidadp.Name = "txtcantidadp"
        Me.txtcantidadp.Size = New System.Drawing.Size(35, 25)
        Me.txtcantidadp.TabIndex = 15
        Me.txtcantidadp.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'txtproducto
        '
        Me.txtproducto.BackColor = System.Drawing.Color.White
        Me.txtproducto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproducto.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproducto.ForeColor = System.Drawing.Color.Black
        Me.txtproducto.Location = New System.Drawing.Point(91, 20)
        Me.txtproducto.MaxLength = 10
        Me.txtproducto.Name = "txtproducto"
        Me.txtproducto.Size = New System.Drawing.Size(240, 25)
        Me.txtproducto.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cantidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label11.Location = New System.Drawing.Point(17, 22)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(64, 17)
        Me.Label11.TabIndex = 7
        Me.Label11.Text = "Producto"
        '
        'dgvservicios
        '
        Me.dgvservicios.AllowUserToAddRows = False
        Me.dgvservicios.AllowUserToDeleteRows = False
        Me.dgvservicios.AllowUserToResizeColumns = False
        Me.dgvservicios.AllowUserToResizeRows = False
        Me.dgvservicios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvservicios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvservicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvservicios.Location = New System.Drawing.Point(583, 343)
        Me.dgvservicios.Name = "dgvservicios"
        Me.dgvservicios.ReadOnly = True
        Me.dgvservicios.RowHeadersVisible = False
        DataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvservicios.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvservicios.Size = New System.Drawing.Size(381, 106)
        Me.dgvservicios.TabIndex = 29
        '
        'txtidproducto
        '
        Me.txtidproducto.Location = New System.Drawing.Point(864, 34)
        Me.txtidproducto.Name = "txtidproducto"
        Me.txtidproducto.Size = New System.Drawing.Size(100, 20)
        Me.txtidproducto.TabIndex = 30
        Me.txtidproducto.Visible = False
        '
        'dgvproductos
        '
        Me.dgvproductos.AllowUserToAddRows = False
        Me.dgvproductos.AllowUserToDeleteRows = False
        Me.dgvproductos.AllowUserToResizeColumns = False
        Me.dgvproductos.AllowUserToResizeRows = False
        Me.dgvproductos.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        Me.dgvproductos.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvproductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvproductos.Location = New System.Drawing.Point(583, 455)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.ReadOnly = True
        Me.dgvproductos.RowHeadersVisible = False
        DataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvproductos.RowsDefaultCellStyle = DataGridViewCellStyle6
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(381, 106)
        Me.dgvproductos.TabIndex = 31
        '
        'txtidventa
        '
        Me.txtidventa.Location = New System.Drawing.Point(298, 34)
        Me.txtidventa.Name = "txtidventa"
        Me.txtidventa.Size = New System.Drawing.Size(100, 20)
        Me.txtidventa.TabIndex = 32
        Me.txtidventa.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.White
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.Black
        Me.TextBox1.Location = New System.Drawing.Point(41, 574)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 25)
        Me.TextBox1.TabIndex = 23
        Me.TextBox1.Visible = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(52, 10)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 47)
        Me.Label12.TabIndex = 33
        Me.Label12.Text = "Venta"
        '
        'frmventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtidventa)
        Me.Controls.Add(Me.dgvproductos)
        Me.Controls.Add(Me.txtidproducto)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtidservicio)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.batncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.pandatosprin)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvlistado)
        Me.Controls.Add(Me.dgvservicios)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmventas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmventas"
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.txtcantidads, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.txtstock, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtcantidadp, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvservicios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents batncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtservicio As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txthora As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents checkgenerico As CheckBox
    Friend WithEvents btbuscarc As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents txtapellidoc As TextBox
    Friend WithEvents txtnombrec As TextBox
    Friend WithEvents piccliente As PictureBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtidcliente As TextBox
    Friend WithEvents txtempleado As TextBox
    Friend WithEvents btagregars As Button
    Friend WithEvents txtprecios As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents btbuscars As Button
    Friend WithEvents btbuscare As Button
    Friend WithEvents txtcantidads As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txtidempleado As TextBox
    Friend WithEvents txtidservicio As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtstock As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents btagregarp As Button
    Friend WithEvents txtpreciop As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btbuscarp As Button
    Friend WithEvents txtcantidadp As NumericUpDown
    Friend WithEvents txtproducto As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgvservicios As DataGridView
    Friend WithEvents txtidproducto As TextBox
    Friend WithEvents dgvproductos As DataGridView
    Friend WithEvents txtidventa As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label12 As Label
End Class
