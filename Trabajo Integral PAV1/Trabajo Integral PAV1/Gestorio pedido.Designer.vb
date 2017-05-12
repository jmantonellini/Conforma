<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_pedido
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmd_nuevo_pedido = New System.Windows.Forms.Button()
        Me.cmd_ver_pedidos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(153, 33)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(216, 25)
        Me.Label22.TabIndex = 36
        Me.Label22.Text = "Gestor de Pedidos"
        '
        'cmd_nuevo_pedido
        '
        Me.cmd_nuevo_pedido.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_nuevo_pedido.Location = New System.Drawing.Point(42, 97)
        Me.cmd_nuevo_pedido.Name = "cmd_nuevo_pedido"
        Me.cmd_nuevo_pedido.Size = New System.Drawing.Size(426, 54)
        Me.cmd_nuevo_pedido.TabIndex = 37
        Me.cmd_nuevo_pedido.Text = "Nuevo Pedido"
        Me.cmd_nuevo_pedido.UseVisualStyleBackColor = True
        '
        'cmd_ver_pedidos
        '
        Me.cmd_ver_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_ver_pedidos.Location = New System.Drawing.Point(42, 190)
        Me.cmd_ver_pedidos.Name = "cmd_ver_pedidos"
        Me.cmd_ver_pedidos.Size = New System.Drawing.Size(426, 54)
        Me.cmd_ver_pedidos.TabIndex = 38
        Me.cmd_ver_pedidos.Text = "Ver Pedidos"
        Me.cmd_ver_pedidos.UseVisualStyleBackColor = True
        '
        'gestor_pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 298)
        Me.Controls.Add(Me.cmd_ver_pedidos)
        Me.Controls.Add(Me.cmd_nuevo_pedido)
        Me.Controls.Add(Me.Label22)
        Me.Name = "gestor_pedido"
        Me.Text = "Gestor de Pedidos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo_pedido As System.Windows.Forms.Button
    Friend WithEvents cmd_ver_pedidos As System.Windows.Forms.Button
End Class
