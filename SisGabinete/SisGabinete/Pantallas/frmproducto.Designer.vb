<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmproducto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtbandera = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btbuscarv = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtapellidovendedor = New System.Windows.Forms.TextBox()
        Me.txtnombrevendedor = New System.Windows.Forms.TextBox()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.txtidproveedor = New System.Windows.Forms.TextBox()
        Me.txtidvendedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pandatossec.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtstock)
        Me.pandatossec.Controls.Add(Me.txtdescripcion)
        Me.pandatossec.Location = New System.Drawing.Point(501, 222)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 96)
        Me.pandatossec.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stock"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Descripción"
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.White
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.Black
        Me.txtstock.Location = New System.Drawing.Point(156, 51)
        Me.txtstock.MaxLength = 10
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(287, 25)
        Me.txtstock.TabIndex = 5
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcion.Location = New System.Drawing.Point(156, 20)
        Me.txtdescripcion.MaxLength = 60
        Me.txtdescripcion.Name = "txtdescripcion"
        Me.txtdescripcion.Size = New System.Drawing.Size(287, 25)
        Me.txtdescripcion.TabIndex = 4
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
        Me.dgvlistado.Location = New System.Drawing.Point(60, 91)
        Me.dgvlistado.Name = "dgvlistado"
        Me.dgvlistado.ReadOnly = True
        Me.dgvlistado.RowHeadersVisible = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvlistado.RowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistado.Size = New System.Drawing.Size(381, 470)
        Me.dgvlistado.TabIndex = 1
        '
        'txtbuscar
        '
        Me.txtbuscar.BackColor = System.Drawing.Color.White
        Me.txtbuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbuscar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbuscar.ForeColor = System.Drawing.Color.Black
        Me.txtbuscar.Location = New System.Drawing.Point(94, 60)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(347, 25)
        Me.txtbuscar.TabIndex = 0
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.Label7)
        Me.pandatosprin.Controls.Add(Me.txtnombre)
        Me.pandatosprin.Controls.Add(Me.txtprecio)
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 132)
        Me.pandatosprin.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label7.Location = New System.Drawing.Point(133, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 37)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "Precio"
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(20, 20)
        Me.txtnombre.MaxLength = 40
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(423, 43)
        Me.txtnombre.TabIndex = 2
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecio.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Location = New System.Drawing.Point(232, 69)
        Me.txtprecio.MaxLength = 10
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(211, 43)
        Me.txtprecio.TabIndex = 3
        Me.txtprecio.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtbandera
        '
        Me.txtbandera.Location = New System.Drawing.Point(501, 34)
        Me.txtbandera.Name = "txtbandera"
        Me.txtbandera.Size = New System.Drawing.Size(100, 20)
        Me.txtbandera.TabIndex = 17
        Me.txtbandera.Text = "0"
        Me.txtbandera.Visible = False
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btbuscarv)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.txtapellidovendedor)
        Me.Panel1.Controls.Add(Me.txtnombrevendedor)
        Me.Panel1.Controls.Add(Me.txtproveedor)
        Me.Panel1.Location = New System.Drawing.Point(501, 348)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 127)
        Me.Panel1.TabIndex = 18
        '
        'btbuscarv
        '
        Me.btbuscarv.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btbuscarv.Location = New System.Drawing.Point(418, 51)
        Me.btbuscarv.Name = "btbuscarv"
        Me.btbuscarv.Size = New System.Drawing.Size(25, 25)
        Me.btbuscarv.TabIndex = 17
        Me.btbuscarv.Text = "..."
        Me.btbuscarv.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Proveedor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Location = New System.Drawing.Point(17, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(119, 17)
        Me.Label8.TabIndex = 11
        Me.Label8.Text = "Apellido vendedor"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Location = New System.Drawing.Point(17, 53)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(120, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Nombre vendedor"
        '
        'txtapellidovendedor
        '
        Me.txtapellidovendedor.BackColor = System.Drawing.Color.White
        Me.txtapellidovendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellidovendedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidovendedor.ForeColor = System.Drawing.Color.Black
        Me.txtapellidovendedor.Location = New System.Drawing.Point(156, 82)
        Me.txtapellidovendedor.MaxLength = 40
        Me.txtapellidovendedor.Name = "txtapellidovendedor"
        Me.txtapellidovendedor.ReadOnly = True
        Me.txtapellidovendedor.Size = New System.Drawing.Size(256, 25)
        Me.txtapellidovendedor.TabIndex = 8
        '
        'txtnombrevendedor
        '
        Me.txtnombrevendedor.BackColor = System.Drawing.Color.White
        Me.txtnombrevendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombrevendedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrevendedor.ForeColor = System.Drawing.Color.Black
        Me.txtnombrevendedor.Location = New System.Drawing.Point(156, 51)
        Me.txtnombrevendedor.MaxLength = 40
        Me.txtnombrevendedor.Name = "txtnombrevendedor"
        Me.txtnombrevendedor.ReadOnly = True
        Me.txtnombrevendedor.Size = New System.Drawing.Size(256, 25)
        Me.txtnombrevendedor.TabIndex = 7
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.White
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.ForeColor = System.Drawing.Color.Black
        Me.txtproveedor.Location = New System.Drawing.Point(156, 20)
        Me.txtproveedor.MaxLength = 40
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.ReadOnly = True
        Me.txtproveedor.Size = New System.Drawing.Size(287, 25)
        Me.txtproveedor.TabIndex = 6
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(860, 524)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(104, 37)
        Me.btncancelar.TabIndex = 12
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(741, 524)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(104, 37)
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(621, 524)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(104, 37)
        Me.btneditar.TabIndex = 10
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(860, 481)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 37)
        Me.btneliminar.TabIndex = 13
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(501, 524)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 37)
        Me.btnnuevo.TabIndex = 9
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'txtidproveedor
        '
        Me.txtidproveedor.Location = New System.Drawing.Point(623, 324)
        Me.txtidproveedor.Name = "txtidproveedor"
        Me.txtidproveedor.Size = New System.Drawing.Size(100, 20)
        Me.txtidproveedor.TabIndex = 30
        Me.txtidproveedor.Visible = False
        '
        'txtidvendedor
        '
        Me.txtidvendedor.Location = New System.Drawing.Point(501, 324)
        Me.txtidvendedor.Name = "txtidvendedor"
        Me.txtidvendedor.Size = New System.Drawing.Size(100, 20)
        Me.txtidvendedor.TabIndex = 31
        Me.txtidvendedor.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 26.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(52, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(165, 47)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Producto"
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtidvendedor)
        Me.Controls.Add(Me.txtidproveedor)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.txtbandera)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.dgvlistado)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.pandatosprin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmproducto"
        Me.Text = "frmproducto"
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtbandera As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtapellidovendedor As TextBox
    Friend WithEvents txtnombrevendedor As TextBox
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents btbuscarv As Button
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtidvendedor As TextBox
    Friend WithEvents txtidproveedor As TextBox
    Friend WithEvents Label5 As Label
End Class
