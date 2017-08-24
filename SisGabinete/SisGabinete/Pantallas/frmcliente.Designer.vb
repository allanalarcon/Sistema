<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcliente
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
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.piccliente = New System.Windows.Forms.PictureBox()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtdireccion = New System.Windows.Forms.TextBox()
        Me.txtcedula = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtbandera = New System.Windows.Forms.TextBox()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatossec.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.pandatosprin.Controls.Add(Me.txtapellido)
        Me.pandatosprin.Controls.Add(Me.txtnombre)
        Me.pandatosprin.Controls.Add(Me.piccliente)
        Me.pandatosprin.Location = New System.Drawing.Point(501, 60)
        Me.pandatosprin.Name = "pandatosprin"
        Me.pandatosprin.Size = New System.Drawing.Size(463, 132)
        Me.pandatosprin.TabIndex = 2
        '
        'txtapellido
        '
        Me.txtapellido.BackColor = System.Drawing.Color.White
        Me.txtapellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtapellido.Font = New System.Drawing.Font("Segoe UI Semibold", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtapellido.ForeColor = System.Drawing.Color.Black
        Me.txtapellido.Location = New System.Drawing.Point(20, 69)
        Me.txtapellido.MaxLength = 40
        Me.txtapellido.Name = "txtapellido"
        Me.txtapellido.Size = New System.Drawing.Size(423, 43)
        Me.txtapellido.TabIndex = 3
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
        'piccliente
        '
        Me.piccliente.Location = New System.Drawing.Point(30, 20)
        Me.piccliente.Name = "piccliente"
        Me.piccliente.Size = New System.Drawing.Size(0, 0)
        Me.piccliente.TabIndex = 0
        Me.piccliente.TabStop = False
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.Label4)
        Me.pandatossec.Controls.Add(Me.Label3)
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtemail)
        Me.pandatossec.Controls.Add(Me.txttelefono)
        Me.pandatossec.Controls.Add(Me.txtdireccion)
        Me.pandatossec.Controls.Add(Me.txtcedula)
        Me.pandatossec.Location = New System.Drawing.Point(501, 222)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 158)
        Me.pandatossec.TabIndex = 3
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
        Me.txtemail.MaxLength = 50
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
        Me.txtdireccion.MaxLength = 60
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
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'btnnuevo
        '
        Me.btnnuevo.Location = New System.Drawing.Point(501, 524)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(104, 37)
        Me.btnnuevo.TabIndex = 8
        Me.btnnuevo.Text = "Nuevo"
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(860, 481)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(104, 37)
        Me.btneliminar.TabIndex = 12
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Location = New System.Drawing.Point(621, 524)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(104, 37)
        Me.btneditar.TabIndex = 9
        Me.btneditar.Text = "Editar"
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btncancelar
        '
        Me.btncancelar.Location = New System.Drawing.Point(860, 524)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(104, 37)
        Me.btncancelar.TabIndex = 11
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(741, 524)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(104, 37)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtbandera
        '
        Me.txtbandera.Location = New System.Drawing.Point(501, 12)
        Me.txtbandera.Name = "txtbandera"
        Me.txtbandera.Size = New System.Drawing.Size(100, 20)
        Me.txtbandera.TabIndex = 15
        Me.txtbandera.Text = "0"
        Me.txtbandera.Visible = False
        '
        'frmcliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(240, Byte), Integer), CType(CType(247, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.txtbandera)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.btneditar)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnnuevo)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.pandatosprin)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvlistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcliente"
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatosprin.ResumeLayout(False)
        Me.pandatosprin.PerformLayout()
        CType(Me.piccliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pandatossec.ResumeLayout(False)
        Me.pandatossec.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents piccliente As PictureBox
    Friend WithEvents pandatossec As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents txttelefono As TextBox
    Friend WithEvents txtdireccion As TextBox
    Friend WithEvents txtcedula As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents btncancelar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents txtbandera As TextBox
End Class
