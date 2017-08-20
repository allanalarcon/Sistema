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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.txtapellidovendedor = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtproveedor = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtnombrevendedor = New System.Windows.Forms.TextBox()
        Me.txtstock = New System.Windows.Forms.TextBox()
        Me.txtprecio = New System.Windows.Forms.TextBox()
        Me.txtdescripcion = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.picempleado = New System.Windows.Forms.PictureBox()
        Me.txtcodigo = New System.Windows.Forms.TextBox()
        Me.pandatossec.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.picempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.txtapellidovendedor)
        Me.pandatossec.Controls.Add(Me.Label6)
        Me.pandatossec.Controls.Add(Me.txtproveedor)
        Me.pandatossec.Controls.Add(Me.Label5)
        Me.pandatossec.Controls.Add(Me.Label4)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtnombrevendedor)
        Me.pandatossec.Controls.Add(Me.txtstock)
        Me.pandatossec.Controls.Add(Me.txtprecio)
        Me.pandatossec.Controls.Add(Me.txtdescripcion)
        Me.pandatossec.Location = New System.Drawing.Point(501, 230)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 220)
        Me.pandatossec.TabIndex = 11
        '
        'txtapellidovendedor
        '
        Me.txtapellidovendedor.BackColor = System.Drawing.Color.White
        Me.txtapellidovendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellidovendedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellidovendedor.ForeColor = System.Drawing.Color.Black
        Me.txtapellidovendedor.Location = New System.Drawing.Point(156, 144)
        Me.txtapellidovendedor.Name = "txtapellidovendedor"
        Me.txtapellidovendedor.Size = New System.Drawing.Size(287, 25)
        Me.txtapellidovendedor.TabIndex = 8
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(17, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(71, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Proveedor"
        '
        'txtproveedor
        '
        Me.txtproveedor.BackColor = System.Drawing.Color.White
        Me.txtproveedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtproveedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtproveedor.ForeColor = System.Drawing.Color.Black
        Me.txtproveedor.Location = New System.Drawing.Point(156, 175)
        Me.txtproveedor.Name = "txtproveedor"
        Me.txtproveedor.Size = New System.Drawing.Size(287, 25)
        Me.txtproveedor.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Apellido Vendedor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(17, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Nombre Vendedor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Stock"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Precio"
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
        'txtnombrevendedor
        '
        Me.txtnombrevendedor.BackColor = System.Drawing.Color.White
        Me.txtnombrevendedor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombrevendedor.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombrevendedor.ForeColor = System.Drawing.Color.Black
        Me.txtnombrevendedor.Location = New System.Drawing.Point(156, 113)
        Me.txtnombrevendedor.Name = "txtnombrevendedor"
        Me.txtnombrevendedor.Size = New System.Drawing.Size(287, 25)
        Me.txtnombrevendedor.TabIndex = 7
        '
        'txtstock
        '
        Me.txtstock.BackColor = System.Drawing.Color.White
        Me.txtstock.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtstock.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtstock.ForeColor = System.Drawing.Color.Black
        Me.txtstock.Location = New System.Drawing.Point(156, 82)
        Me.txtstock.MaxLength = 10
        Me.txtstock.Name = "txtstock"
        Me.txtstock.Size = New System.Drawing.Size(287, 25)
        Me.txtstock.TabIndex = 6
        '
        'txtprecio
        '
        Me.txtprecio.BackColor = System.Drawing.Color.White
        Me.txtprecio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtprecio.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtprecio.ForeColor = System.Drawing.Color.Black
        Me.txtprecio.Location = New System.Drawing.Point(156, 51)
        Me.txtprecio.Name = "txtprecio"
        Me.txtprecio.Size = New System.Drawing.Size(287, 25)
        Me.txtprecio.TabIndex = 5
        '
        'txtdescripcion
        '
        Me.txtdescripcion.BackColor = System.Drawing.Color.White
        Me.txtdescripcion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdescripcion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescripcion.ForeColor = System.Drawing.Color.Black
        Me.txtdescripcion.Location = New System.Drawing.Point(156, 20)
        Me.txtdescripcion.MaxLength = 10
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
        Me.dgvlistado.TabIndex = 9
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
        Me.txtbuscar.TabIndex = 8
        '
        'pandatosprin
        '
        Me.pandatosprin.BackColor = System.Drawing.Color.White
        Me.pandatosprin.Controls.Add(Me.txtcodigo)
        Me.pandatosprin.Controls.Add(Me.txtnombre)
        Me.pandatosprin.Controls.Add(Me.picempleado)
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 140)
        Me.pandatosprin.TabIndex = 10
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(156, 77)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(287, 43)
        Me.txtnombre.TabIndex = 2
        '
        'picempleado
        '
        Me.picempleado.Location = New System.Drawing.Point(30, 20)
        Me.picempleado.Name = "picempleado"
        Me.picempleado.Size = New System.Drawing.Size(100, 100)
        Me.picempleado.TabIndex = 0
        Me.picempleado.TabStop = False
        '
        'txtcodigo
        '
        Me.txtcodigo.BackColor = System.Drawing.Color.White
        Me.txtcodigo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcodigo.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcodigo.ForeColor = System.Drawing.Color.Black
        Me.txtcodigo.Location = New System.Drawing.Point(156, 20)
        Me.txtcodigo.Name = "txtcodigo"
        Me.txtcodigo.Size = New System.Drawing.Size(287, 43)
        Me.txtcodigo.TabIndex = 3
        '
        'frmproducto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
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
        CType(Me.picempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents pandatossec As Panel
    Friend WithEvents txtapellidovendedor As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtproveedor As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtnombrevendedor As TextBox
    Friend WithEvents txtstock As TextBox
    Friend WithEvents txtprecio As TextBox
    Friend WithEvents txtdescripcion As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents picempleado As PictureBox
    Friend WithEvents txtcodigo As TextBox
End Class
