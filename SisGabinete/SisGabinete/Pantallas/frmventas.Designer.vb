<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmventas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
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
        Me.checknuevo = New System.Windows.Forms.CheckBox()
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
        Me.txtbuscarser = New System.Windows.Forms.TextBox()
        Me.dgvservicios = New System.Windows.Forms.DataGridView()
        Me.dgvproductos = New System.Windows.Forms.DataGridView()
        Me.txtbuscarpro = New System.Windows.Forms.TextBox()
        Me.txtidcliente = New System.Windows.Forms.TextBox()
        Me.txtidempleado = New System.Windows.Forms.TextBox()
        Me.txtidservicio = New System.Windows.Forms.TextBox()
        Me.pandatossec.SuspendLayout()
        CType(Me.txtcantidads, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvservicios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvproductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'batncancelar
        '
        Me.batncancelar.Location = New System.Drawing.Point(860, 562)
        Me.batncancelar.Name = "batncancelar"
        Me.batncancelar.Size = New System.Drawing.Size(104, 43)
        Me.batncancelar.TabIndex = 23
        Me.batncancelar.Text = "Cancelar"
        Me.batncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(623, 513)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(104, 43)
        Me.btnguardar.TabIndex = 20
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(623, 562)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(104, 43)
        Me.btneditar.TabIndex = 21
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(743, 562)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 43)
        Me.btneliminar.TabIndex = 22
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(501, 562)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 43)
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
        Me.pandatossec.Location = New System.Drawing.Point(501, 234)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 127)
        Me.pandatossec.TabIndex = 18
        '
        'btagregars
        '
        Me.btagregars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btagregars.Location = New System.Drawing.Point(378, 82)
        Me.btagregars.Name = "btagregars"
        Me.btagregars.Size = New System.Drawing.Size(65, 25)
        Me.btagregars.TabIndex = 20
        Me.btagregars.Text = "Agregar"
        Me.btagregars.UseVisualStyleBackColor = True
        '
        'txtprecios
        '
        Me.txtprecios.BackColor = System.Drawing.Color.White
        Me.txtprecios.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecios.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecios.ForeColor = System.Drawing.Color.Black
        Me.txtprecios.Location = New System.Drawing.Point(182, 82)
        Me.txtprecios.Name = "txtprecios"
        Me.txtprecios.Size = New System.Drawing.Size(71, 25)
        Me.txtprecios.TabIndex = 19
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Location = New System.Drawing.Point(131, 84)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 17)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Precio"
        '
        'btbuscars
        '
        Me.btbuscars.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscars.Location = New System.Drawing.Point(418, 51)
        Me.btbuscars.Name = "btbuscars"
        Me.btbuscars.Size = New System.Drawing.Size(25, 25)
        Me.btbuscars.TabIndex = 17
        Me.btbuscars.Text = "..."
        Me.btbuscars.UseVisualStyleBackColor = True
        '
        'btbuscare
        '
        Me.btbuscare.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscare.Location = New System.Drawing.Point(418, 20)
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
        Me.txtempleado.Location = New System.Drawing.Point(156, 20)
        Me.txtempleado.MaxLength = 10
        Me.txtempleado.Name = "txtempleado"
        Me.txtempleado.Size = New System.Drawing.Size(256, 25)
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
        Me.txtservicio.Location = New System.Drawing.Point(156, 51)
        Me.txtservicio.Name = "txtservicio"
        Me.txtservicio.Size = New System.Drawing.Size(256, 25)
        Me.txtservicio.TabIndex = 5
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.checknuevo)
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
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 144)
        Me.pandatosprin.TabIndex = 17
        '
        'checknuevo
        '
        Me.checknuevo.AutoSize = True
        Me.checknuevo.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.checknuevo.Location = New System.Drawing.Point(286, 16)
        Me.checknuevo.Name = "checknuevo"
        Me.checknuevo.Size = New System.Drawing.Size(67, 21)
        Me.checknuevo.TabIndex = 15
        Me.checknuevo.Text = "Nuevo"
        Me.checknuevo.UseVisualStyleBackColor = True
        '
        'txthora
        '
        Me.txthora.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txthora.Location = New System.Drawing.Point(279, 99)
        Me.txthora.Mask = "00:00"
        Me.txthora.Name = "txthora"
        Me.txthora.Size = New System.Drawing.Size(164, 25)
        Me.txthora.TabIndex = 14
        Me.txthora.ValidatingType = GetType(Date)
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
        Me.txtapellidoc.Enabled = False
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
        Me.txtnombrec.Enabled = False
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
        'txtbuscarser
        '
        Me.txtbuscarser.BackColor = System.Drawing.Color.White
        Me.txtbuscarser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscarser.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscarser.ForeColor = System.Drawing.Color.Black
        Me.txtbuscarser.Location = New System.Drawing.Point(94, 60)
        Me.txtbuscarser.Name = "txtbuscarser"
        Me.txtbuscarser.Size = New System.Drawing.Size(347, 25)
        Me.txtbuscarser.TabIndex = 0
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
        Me.dgvservicios.Location = New System.Drawing.Point(60, 91)
        Me.dgvservicios.Name = "dgvservicios"
        Me.dgvservicios.ReadOnly = True
        Me.dgvservicios.RowHeadersVisible = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvservicios.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.dgvservicios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvservicios.Size = New System.Drawing.Size(381, 210)
        Me.dgvservicios.TabIndex = 1
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
        Me.dgvproductos.Location = New System.Drawing.Point(60, 351)
        Me.dgvproductos.Name = "dgvproductos"
        Me.dgvproductos.ReadOnly = True
        Me.dgvproductos.RowHeadersVisible = False
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvproductos.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvproductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvproductos.Size = New System.Drawing.Size(381, 210)
        Me.dgvproductos.TabIndex = 3
        '
        'txtbuscarpro
        '
        Me.txtbuscarpro.BackColor = System.Drawing.Color.White
        Me.txtbuscarpro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscarpro.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscarpro.ForeColor = System.Drawing.Color.Black
        Me.txtbuscarpro.Location = New System.Drawing.Point(94, 320)
        Me.txtbuscarpro.Name = "txtbuscarpro"
        Me.txtbuscarpro.Size = New System.Drawing.Size(347, 25)
        Me.txtbuscarpro.TabIndex = 2
        '
        'txtidcliente
        '
        Me.txtidcliente.Location = New System.Drawing.Point(501, 34)
        Me.txtidcliente.Name = "txtidcliente"
        Me.txtidcliente.Size = New System.Drawing.Size(100, 20)
        Me.txtidcliente.TabIndex = 24
        '
        'txtidempleado
        '
        Me.txtidempleado.Location = New System.Drawing.Point(501, 210)
        Me.txtidempleado.Name = "txtidempleado"
        Me.txtidempleado.Size = New System.Drawing.Size(100, 20)
        Me.txtidempleado.TabIndex = 25
        Me.txtidempleado.Visible = False
        '
        'txtidservicio
        '
        Me.txtidservicio.Location = New System.Drawing.Point(607, 210)
        Me.txtidservicio.Name = "txtidservicio"
        Me.txtidservicio.Size = New System.Drawing.Size(100, 20)
        Me.txtidservicio.TabIndex = 26
        Me.txtidservicio.Visible = False
        '
        'frmventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.txtidservicio)
        Me.Controls.Add(Me.txtidempleado)
        Me.Controls.Add(Me.txtidcliente)
        Me.Controls.Add(Me.txtbuscarpro)
        Me.Controls.Add(Me.dgvproductos)
        Me.Controls.Add(Me.batncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.pandatosprin)
        Me.Controls.Add(Me.txtbuscarser)
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
    Friend WithEvents txtbuscarser As TextBox
    Friend WithEvents dgvservicios As DataGridView
    Friend WithEvents dgvproductos As DataGridView
    Friend WithEvents txtbuscarpro As TextBox
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
    Friend WithEvents checknuevo As CheckBox
End Class
