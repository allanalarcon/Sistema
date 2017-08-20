<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpago
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
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.pandatossec = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfecha = New System.Windows.Forms.TextBox()
        Me.txtpago = New System.Windows.Forms.TextBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.dgvlistado = New System.Windows.Forms.DataGridView()
        Me.pandatosprin = New System.Windows.Forms.Panel()
        Me.txtapellido = New System.Windows.Forms.TextBox()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.picempleado = New System.Windows.Forms.PictureBox()
        Me.pandatossec.SuspendLayout()
        CType(Me.dgvlistado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pandatosprin.SuspendLayout()
        CType(Me.picempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pandatossec
        '
        Me.pandatossec.BackColor = System.Drawing.Color.White
        Me.pandatossec.Controls.Add(Me.Label2)
        Me.pandatossec.Controls.Add(Me.Label1)
        Me.pandatossec.Controls.Add(Me.txtfecha)
        Me.pandatossec.Controls.Add(Me.txtpago)
        Me.pandatossec.Location = New System.Drawing.Point(501, 230)
        Me.pandatossec.Name = "pandatossec"
        Me.pandatossec.Size = New System.Drawing.Size(463, 96)
        Me.pandatossec.TabIndex = 7
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 53)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 17)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label1.Location = New System.Drawing.Point(17, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 17)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Pago"
        '
        'txtfecha
        '
        Me.txtfecha.BackColor = System.Drawing.Color.White
        Me.txtfecha.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtfecha.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfecha.ForeColor = System.Drawing.Color.Black
        Me.txtfecha.Location = New System.Drawing.Point(156, 51)
        Me.txtfecha.Name = "txtfecha"
        Me.txtfecha.Size = New System.Drawing.Size(287, 25)
        Me.txtfecha.TabIndex = 5
        '
        'txtpago
        '
        Me.txtpago.BackColor = System.Drawing.Color.White
        Me.txtpago.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpago.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpago.ForeColor = System.Drawing.Color.Black
        Me.txtpago.Location = New System.Drawing.Point(156, 20)
        Me.txtpago.MaxLength = 10
        Me.txtpago.Name = "txtpago"
        Me.txtpago.Size = New System.Drawing.Size(287, 25)
        Me.txtpago.TabIndex = 4
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
        Me.txtbuscar.TabIndex = 4
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
        DataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(CType(CType(68, Byte), Integer), CType(CType(72, Byte), Integer), CType(CType(90, Byte), Integer))
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(55, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(73, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.dgvlistado.RowsDefaultCellStyle = DataGridViewCellStyle4
        Me.dgvlistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvlistado.Size = New System.Drawing.Size(381, 470)
        Me.dgvlistado.TabIndex = 5
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
        Me.pandatosprin.TabIndex = 8
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
        'frmpago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1024, 621)
        Me.Controls.Add(Me.pandatosprin)
        Me.Controls.Add(Me.pandatossec)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.dgvlistado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmpago"
        Me.Text = "frmpago"
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
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfecha As TextBox
    Friend WithEvents txtpago As TextBox
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents dgvlistado As DataGridView
    Friend WithEvents pandatosprin As Panel
    Friend WithEvents txtapellido As TextBox
    Friend WithEvents txtnombre As TextBox
    Friend WithEvents picempleado As PictureBox
End Class
