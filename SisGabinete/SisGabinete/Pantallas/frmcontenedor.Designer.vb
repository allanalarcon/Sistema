<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmcontenedor
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
        Me.pnbotones = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'pnbotones
        '
        Me.pnbotones.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.pnbotones.Location = New System.Drawing.Point(0, 0)
        Me.pnbotones.Name = "pnbotones"
        Me.pnbotones.Size = New System.Drawing.Size(80, 621)
        Me.pnbotones.TabIndex = 0
        '
        'frmcontenedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1104, 621)
        Me.Controls.Add(Me.pnbotones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmcontenedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmcontenedor"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents pnbotones As Panel
End Class
