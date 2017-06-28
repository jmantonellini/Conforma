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
        Me.cmd_provincias = New System.Windows.Forms.Button()
        Me.cmd_detalles = New System.Windows.Forms.Button()
        Me.cmd_clientes = New System.Windows.Forms.Button()
        Me.cmd_pedidos_cliente = New System.Windows.Forms.Button()
        Me.cmd_productos = New System.Windows.Forms.Button()
        Me.cmd_empresas = New System.Windows.Forms.Button()
        Me.cmd_clientes_por_empresa = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cmd_provincias
        '
        Me.cmd_provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_provincias.Location = New System.Drawing.Point(166, 278)
        Me.cmd_provincias.Name = "cmd_provincias"
        Me.cmd_provincias.Size = New System.Drawing.Size(173, 56)
        Me.cmd_provincias.TabIndex = 42
        Me.cmd_provincias.Text = "Provincias Por País"
        Me.cmd_provincias.UseVisualStyleBackColor = True
        '
        'cmd_detalles
        '
        Me.cmd_detalles.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_detalles.Location = New System.Drawing.Point(76, 211)
        Me.cmd_detalles.Name = "cmd_detalles"
        Me.cmd_detalles.Size = New System.Drawing.Size(173, 56)
        Me.cmd_detalles.TabIndex = 43
        Me.cmd_detalles.Text = "Pedidos Detallados"
        Me.cmd_detalles.UseVisualStyleBackColor = True
        '
        'cmd_clientes
        '
        Me.cmd_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clientes.Location = New System.Drawing.Point(76, 77)
        Me.cmd_clientes.Name = "cmd_clientes"
        Me.cmd_clientes.Size = New System.Drawing.Size(173, 56)
        Me.cmd_clientes.TabIndex = 44
        Me.cmd_clientes.Text = "Clientes"
        Me.cmd_clientes.UseVisualStyleBackColor = True
        '
        'cmd_pedidos_cliente
        '
        Me.cmd_pedidos_cliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pedidos_cliente.Location = New System.Drawing.Point(76, 144)
        Me.cmd_pedidos_cliente.Name = "cmd_pedidos_cliente"
        Me.cmd_pedidos_cliente.Size = New System.Drawing.Size(173, 56)
        Me.cmd_pedidos_cliente.TabIndex = 45
        Me.cmd_pedidos_cliente.Text = "Pedidos por Cliente"
        Me.cmd_pedidos_cliente.UseVisualStyleBackColor = True
        '
        'cmd_productos
        '
        Me.cmd_productos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_productos.Location = New System.Drawing.Point(255, 211)
        Me.cmd_productos.Name = "cmd_productos"
        Me.cmd_productos.Size = New System.Drawing.Size(173, 56)
        Me.cmd_productos.TabIndex = 46
        Me.cmd_productos.Text = "Productos Pedidos"
        Me.cmd_productos.UseVisualStyleBackColor = True
        '
        'cmd_empresas
        '
        Me.cmd_empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_empresas.Location = New System.Drawing.Point(255, 77)
        Me.cmd_empresas.Name = "cmd_empresas"
        Me.cmd_empresas.Size = New System.Drawing.Size(173, 56)
        Me.cmd_empresas.TabIndex = 47
        Me.cmd_empresas.Text = "Empresas"
        Me.cmd_empresas.UseVisualStyleBackColor = True
        '
        'cmd_clientes_por_empresa
        '
        Me.cmd_clientes_por_empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_clientes_por_empresa.Location = New System.Drawing.Point(255, 144)
        Me.cmd_clientes_por_empresa.Name = "cmd_clientes_por_empresa"
        Me.cmd_clientes_por_empresa.Size = New System.Drawing.Size(173, 56)
        Me.cmd_clientes_por_empresa.TabIndex = 48
        Me.cmd_clientes_por_empresa.Text = "Clientes por Empresa"
        Me.cmd_clientes_por_empresa.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(186, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 31)
        Me.Label1.TabIndex = 49
        Me.Label1.Text = "Reportes"
        '
        'Button1
        '
        Me.Button1.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.Button1.Location = New System.Drawing.Point(421, 300)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(72, 80)
        Me.Button1.TabIndex = 50
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 392)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_clientes_por_empresa)
        Me.Controls.Add(Me.cmd_empresas)
        Me.Controls.Add(Me.cmd_productos)
        Me.Controls.Add(Me.cmd_pedidos_cliente)
        Me.Controls.Add(Me.cmd_clientes)
        Me.Controls.Add(Me.cmd_detalles)
        Me.Controls.Add(Me.cmd_provincias)
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_provincias As System.Windows.Forms.Button
    Friend WithEvents cmd_detalles As System.Windows.Forms.Button
    Friend WithEvents cmd_clientes As System.Windows.Forms.Button
    Friend WithEvents cmd_pedidos_cliente As System.Windows.Forms.Button
    Friend WithEvents cmd_productos As System.Windows.Forms.Button
    Friend WithEvents cmd_empresas As System.Windows.Forms.Button
    Friend WithEvents cmd_clientes_por_empresa As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
