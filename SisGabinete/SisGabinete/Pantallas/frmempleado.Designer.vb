<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempleado
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
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.picempleado = New System.Windows.Forms.PictureBox()
        Me.txtedad = New System.Windows.Forms.TextBox()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.txtfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.batncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.picempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatossec.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtnombre
        '
        Me.txtnombre.BackColor = System.Drawing.Color.White
        Me.txtnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtnombre.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.ForeColor = System.Drawing.Color.Black
        Me.txtnombre.Location = New System.Drawing.Point(156, 20)
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
        'txtedad
        '
        Me.txtedad.BackColor = System.Drawing.Color.White
        Me.txtedad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtedad.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtedad.ForeColor = System.Drawing.Color.Black
        Me.txtedad.Location = New System.Drawing.Point(156, 175)
        Me.txtedad.Name = "txtedad"
        Me.txtedad.Size = New System.Drawing.Size(287, 25)
        Me.txtedad.TabIndex = 9
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.ForeColor = System.Drawing.Color.Black
        Me.txtapellido.Location = New System.Drawing.Point(156, 69)
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(287, 43)
        Me.txtapellido.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Location = New System.Drawing.Point(17, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Edad"
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.txtfecha)
        Me.pandatossec.Controls.Add(Me.Label6)
        Me.pandatossec.Controls.Add(Me.txtedad)
        Me.pandatossec.Controls.Add(Me.Label5)
        Me.pandatossec.Controls.Add(Me.Label4)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtemail)
        Me.pandatossec.Controls.Add(Me.txttelefono)
        Me.pandatossec.Controls.Add(Me.txtdireccion)
        Me.pandatossec.Controls.Add(Me.txtcedula)
        Me.pandatossec.Location = New System.Drawing.Point(501, 230)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 220)
        Me.pandatossec.TabIndex = 7
        '
        'txtfecha
        '
        Me.txtfecha.Location = New System.Drawing.Point(156, 144)
        Me.txtfecha.Mask = "00/00/0000"
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(287, 20)
        Me.txtfecha.TabIndex = 15
        Me.txtfecha.ValidatingType = GetType(Date)
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Location = New System.Drawing.Point(17, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 17)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Fecha de nacimiento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Location = New System.Drawing.Point(17, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(40, 17)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Email"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Location = New System.Drawing.Point(17, 84)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Telefóno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Dirección"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Cédula"
        '
        'txtemail
        '
        Me.txtemail.BackColor = System.Drawing.Color.White
        Me.txtemail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtemail.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.ForeColor = System.Drawing.Color.Black
        Me.txtemail.Location = New System.Drawing.Point(156, 113)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(287, 25)
        Me.txtemail.TabIndex = 7
        '
        'txttelefono
        '
        Me.txttelefono.BackColor = System.Drawing.Color.White
        Me.txttelefono.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttelefono.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttelefono.ForeColor = System.Drawing.Color.Black
        Me.txttelefono.Location = New System.Drawing.Point(156, 82)
        Me.txttelefono.MaxLength = 10
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(287, 25)
        Me.txttelefono.TabIndex = 6
        '
        'txtdireccion
        '
        Me.txtdireccion.BackColor = System.Drawing.Color.White
        Me.txtdireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdireccion.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdireccion.ForeColor = System.Drawing.Color.Black
        Me.txtdireccion.Location = New System.Drawing.Point(156, 51)
        Me.txtdireccion.Name = "txtdireccion"
        Me.txtdireccion.Size = New System.Drawing.Size(287, 25)
        Me.txtdireccion.TabIndex = 5
        '
        'txtcedula
        '
        Me.txtcedula.BackColor = System.Drawing.Color.White
        Me.txtcedula.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcedula.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcedula.ForeColor = System.Drawing.Color.Black
        Me.txtcedula.Location = New System.Drawing.Point(156, 20)
        Me.txtcedula.MaxLength = 10
        Me.txtcedula.Name = "txtcedula"
        Me.txtcedula.Size = New System.Drawing.Size(287, 25)
        Me.txtcedula.TabIndex = 4
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
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvlistado.RowsDefaultCellStyle = DataGridViewCellStyle2
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
        Me.pandatosprin.Controls.Add(Me.txtapellido)
        Me.pandatosprin.Controls.Add(Me.txtnombre)
        Me.pandatosprin.Controls.Add(Me.picempleado)
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 140)
        Me.pandatosprin.TabIndex = 6
        '
        'batncancelar
        '
        Me.batncancelar.Location = New System.Drawing.Point(857, 518)
        Me.batncancelar.Name = "batncancelar"
        Me.batncancelar.Size = New System.Drawing.Size(104, 43)
        Me.batncancelar.TabIndex = 16
        Me.batncancelar.Text = "Cancelar"
        Me.batncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(620, 469)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(104, 43)
        Me.btnguardar.TabIndex = 15
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(620, 518)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(104, 43)
        Me.btneditar.TabIndex = 14
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(740, 518)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 43)
        Me.btneliminar.TabIndex = 13
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(498, 518)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 43)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'frmempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.batncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.dgvlistado)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.pandatosprin)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmempleado"
        Me.Text = "frmempleado"
        CType(Me.picempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtnombre As TextBox
    Friend WithEvents picempleado As PictureBox
    Friend WithEvents txtedad As TextBox
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents batncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents txtfecha As MaskedTextBox
End Class
