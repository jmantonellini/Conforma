<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reportes
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
        Me.cmd_provincias = New System.Windows.Forms.Button()
        Me.cmd_detalles = New System.Windows.Forms.Button()
        Me.cmd_clientes = New System.Windows.Forms.Button()
        Me.cmd_pedidos_cliente = New System.Windows.Forms.Button()
        Me.cmd_productos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(253, 23)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(111, 25)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Reportes"
        '
        'cmd_provincias
        '
        Me.cmd_provincias.Location = New System.Drawing.Point(62, 78)
        Me.cmd_provincias.Name = "cmd_provincias"
        Me.cmd_provincias.Size = New System.Drawing.Size(132, 23)
        Me.cmd_provincias.TabIndex = 42
        Me.cmd_provincias.Text = "Provincias Por País"
        Me.cmd_provincias.UseVisualStyleBackColor = True
        '
        'cmd_detalles
        '
        Me.cmd_detalles.Location = New System.Drawing.Point(62, 140)
        Me.cmd_detalles.Name = "cmd_detalles"
        Me.cmd_detalles.Size = New System.Drawing.Size(132, 23)
        Me.cmd_detalles.TabIndex = 43
        Me.cmd_detalles.Text = "Pedidos Detallados"
        Me.cmd_detalles.UseVisualStyleBackColor = True
        '
        'cmd_clientes
        '
        Me.cmd_clientes.Location = New System.Drawing.Point(62, 191)
        Me.cmd_clientes.Name = "cmd_clientes"
        Me.cmd_clientes.Size = New System.Drawing.Size(132, 23)
        Me.cmd_clientes.TabIndex = 44
        Me.cmd_clientes.Text = "Clientes"
        Me.cmd_clientes.UseVisualStyleBackColor = True
        '
        'cmd_pedidos_cliente
        '
        Me.cmd_pedidos_cliente.Location = New System.Drawing.Point(250, 78)
        Me.cmd_pedidos_cliente.Name = "cmd_pedidos_cliente"
        Me.cmd_pedidos_cliente.Size = New System.Drawing.Size(132, 23)
        Me.cmd_pedidos_cliente.TabIndex = 45
        Me.cmd_pedidos_cliente.Text = "Pedidos por Cliente"
        Me.cmd_pedidos_cliente.UseVisualStyleBackColor = True
        '
        'cmd_productos
        '
        Me.cmd_productos.Location = New System.Drawing.Point(250, 140)
        Me.cmd_productos.Name = "cmd_productos"
        Me.cmd_productos.Size = New System.Drawing.Size(132, 23)
        Me.cmd_productos.TabIndex = 46
        Me.cmd_productos.Text = "Productos Pedidos"
        Me.cmd_productos.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(617, 412)
        Me.Controls.Add(Me.cmd_productos)
        Me.Controls.Add(Me.cmd_pedidos_cliente)
        Me.Controls.Add(Me.cmd_clientes)
        Me.Controls.Add(Me.cmd_detalles)
        Me.Controls.Add(Me.cmd_provincias)
        Me.Controls.Add(Me.Label22)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmd_provincias As System.Windows.Forms.Button
    Friend WithEvents cmd_detalles As System.Windows.Forms.Button
    Friend WithEvents cmd_clientes As System.Windows.Forms.Button
    Friend WithEvents cmd_pedidos_cliente As System.Windows.Forms.Button
    Friend WithEvents cmd_productos As System.Windows.Forms.Button
End Class
