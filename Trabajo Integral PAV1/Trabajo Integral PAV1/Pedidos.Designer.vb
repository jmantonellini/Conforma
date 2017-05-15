<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_pedidos
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
        Me.cmb_cliente = New System.Windows.Forms.ComboBox()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmd_nuevo_cliente = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_categoria = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_nuevo_producto = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.cmd_nueva_marca = New System.Windows.Forms.Button()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_modelo = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabla_detalles = New System.Windows.Forms.DataGridView()
        Me.cmd_agregar_detalle = New System.Windows.Forms.Button()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir2 = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_nuevo = New System.Windows.Forms.TabPage()
        Me.tab_listado = New System.Windows.Forms.TabPage()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.tabla_pedidos = New System.Windows.Forms.DataGridView()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.tabla_detalles, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.tab_nuevo.SuspendLayout()
        Me.tab_listado.SuspendLayout()
        CType(Me.tabla_pedidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_cliente
        '
        Me.cmb_cliente.Enabled = False
        Me.cmb_cliente.FormattingEnabled = True
        Me.cmb_cliente.Location = New System.Drawing.Point(129, 37)
        Me.cmb_cliente.Name = "cmb_cliente"
        Me.cmb_cliente.Size = New System.Drawing.Size(166, 21)
        Me.cmb_cliente.TabIndex = 0
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(159, 34)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(121, 21)
        Me.cmb_area.TabIndex = 0
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(316, 0)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(165, 25)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Nuevo Pedido"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(39, 13)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Cliente"
        '
        'cmd_nuevo_cliente
        '
        Me.cmd_nuevo_cliente.Location = New System.Drawing.Point(312, 37)
        Me.cmd_nuevo_cliente.Name = "cmd_nuevo_cliente"
        Me.cmd_nuevo_cliente.Size = New System.Drawing.Size(75, 21)
        Me.cmd_nuevo_cliente.TabIndex = 39
        Me.cmd_nuevo_cliente.Text = "Nuevo"
        Me.cmd_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Producto"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(125, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(32, 13)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "Área:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(65, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(92, 13)
        Me.Label4.TabIndex = 43
        Me.Label4.Text = "Tipo de Producto:"
        '
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(159, 69)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_producto.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(91, 107)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 45
        Me.Label5.Text = "Categorías:"
        '
        'cmb_categoria
        '
        Me.cmb_categoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_categoria.FormattingEnabled = True
        Me.cmb_categoria.Location = New System.Drawing.Point(159, 103)
        Me.cmb_categoria.Name = "cmb_categoria"
        Me.cmb_categoria.Size = New System.Drawing.Size(121, 21)
        Me.cmb_categoria.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.cmd_nuevo_producto)
        Me.Panel1.Controls.Add(Me.cmb_area)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmb_categoria)
        Me.Panel1.Controls.Add(Me.Label3)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.cmb_tipo_producto)
        Me.Panel1.Location = New System.Drawing.Point(22, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(365, 160)
        Me.Panel1.TabIndex = 1
        '
        'cmd_nuevo_producto
        '
        Me.cmd_nuevo_producto.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._16909
        Me.cmd_nuevo_producto.Location = New System.Drawing.Point(322, 117)
        Me.cmd_nuevo_producto.Name = "cmd_nuevo_producto"
        Me.cmd_nuevo_producto.Size = New System.Drawing.Size(38, 38)
        Me.cmd_nuevo_producto.TabIndex = 43
        Me.cmd_nuevo_producto.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.cmd_nueva_marca)
        Me.Panel2.Controls.Add(Me.MaskedTextBox1)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.cmb_modelo)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.cmb_marca)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label6)
        Me.Panel2.Location = New System.Drawing.Point(419, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(365, 160)
        Me.Panel2.TabIndex = 2
        '
        'cmd_nueva_marca
        '
        Me.cmd_nueva_marca.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._16909
        Me.cmd_nueva_marca.Location = New System.Drawing.Point(322, 117)
        Me.cmd_nueva_marca.Name = "cmd_nueva_marca"
        Me.cmd_nueva_marca.Size = New System.Drawing.Size(38, 38)
        Me.cmd_nueva_marca.TabIndex = 46
        Me.cmd_nueva_marca.UseVisualStyleBackColor = True
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(148, 104)
        Me.MaskedTextBox1.Mask = "99999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(36, 20)
        Me.MaskedTextBox1.TabIndex = 2
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(94, 107)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(52, 13)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Cantidad:"
        '
        'cmb_modelo
        '
        Me.cmb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_modelo.FormattingEnabled = True
        Me.cmb_modelo.Location = New System.Drawing.Point(148, 69)
        Me.cmb_modelo.Name = "cmb_modelo"
        Me.cmb_modelo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_modelo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(101, 72)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 13)
        Me.Label8.TabIndex = 47
        Me.Label8.Text = "Modelo:"
        '
        'cmb_marca
        '
        Me.cmb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(148, 34)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(121, 21)
        Me.cmb_marca.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(106, 37)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Marca:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Especificaciones:"
        '
        'tabla_detalles
        '
        Me.tabla_detalles.AllowUserToAddRows = False
        Me.tabla_detalles.AllowUserToDeleteRows = False
        Me.tabla_detalles.AllowUserToResizeColumns = False
        Me.tabla_detalles.AllowUserToResizeRows = False
        Me.tabla_detalles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_detalles.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tabla_detalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_detalles.GridColor = System.Drawing.Color.Gainsboro
        Me.tabla_detalles.Location = New System.Drawing.Point(22, 376)
        Me.tabla_detalles.Name = "tabla_detalles"
        Me.tabla_detalles.ReadOnly = True
        Me.tabla_detalles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_detalles.Size = New System.Drawing.Size(762, 85)
        Me.tabla_detalles.TabIndex = 5
        '
        'cmd_agregar_detalle
        '
        Me.cmd_agregar_detalle.Location = New System.Drawing.Point(346, 335)
        Me.cmd_agregar_detalle.Name = "cmd_agregar_detalle"
        Me.cmd_agregar_detalle.Size = New System.Drawing.Size(114, 23)
        Me.cmd_agregar_detalle.TabIndex = 4
        Me.cmd_agregar_detalle.Text = "Agregar Producto"
        Me.cmd_agregar_detalle.UseVisualStyleBackColor = True
        '
        'txt_observaciones
        '
        Me.txt_observaciones.ForeColor = System.Drawing.SystemColors.InactiveCaption
        Me.txt_observaciones.Location = New System.Drawing.Point(232, 239)
        Me.txt_observaciones.Multiline = True
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(364, 90)
        Me.txt_observaciones.TabIndex = 3
        Me.txt_observaciones.Text = "Observaciones..."
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.cmd_guardar)
        Me.Panel3.Controls.Add(Me.cmd_salir2)
        Me.Panel3.Controls.Add(Me.cmd_nuevo)
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.txt_observaciones)
        Me.Panel3.Controls.Add(Me.cmb_cliente)
        Me.Panel3.Controls.Add(Me.cmd_agregar_detalle)
        Me.Panel3.Controls.Add(Me.Label22)
        Me.Panel3.Controls.Add(Me.tabla_detalles)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Controls.Add(Me.cmd_nuevo_cliente)
        Me.Panel3.Location = New System.Drawing.Point(-4, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(809, 559)
        Me.Panel3.TabIndex = 0
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.cmd_guardar.Location = New System.Drawing.Point(108, 464)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_guardar.TabIndex = 42
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_salir2
        '
        Me.cmd_salir2.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_salir2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir2.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.cmd_salir2.Location = New System.Drawing.Point(704, 462)
        Me.cmd_salir2.Name = "cmd_salir2"
        Me.cmd_salir2.Size = New System.Drawing.Size(80, 80)
        Me.cmd_salir2.TabIndex = 41
        Me.cmd_salir2.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(22, 464)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 40
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_nuevo)
        Me.TabControl1.Controls.Add(Me.tab_listado)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(813, 576)
        Me.TabControl1.TabIndex = 0
        '
        'tab_nuevo
        '
        Me.tab_nuevo.Controls.Add(Me.Panel3)
        Me.tab_nuevo.Location = New System.Drawing.Point(4, 22)
        Me.tab_nuevo.Name = "tab_nuevo"
        Me.tab_nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_nuevo.Size = New System.Drawing.Size(805, 550)
        Me.tab_nuevo.TabIndex = 0
        Me.tab_nuevo.Text = "Nuevo "
        Me.tab_nuevo.UseVisualStyleBackColor = True
        '
        'tab_listado
        '
        Me.tab_listado.Controls.Add(Me.Label10)
        Me.tab_listado.Controls.Add(Me.cmd_eliminar)
        Me.tab_listado.Controls.Add(Me.cmd_salir)
        Me.tab_listado.Controls.Add(Me.cmd_modificar)
        Me.tab_listado.Controls.Add(Me.tabla_pedidos)
        Me.tab_listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_listado.Name = "tab_listado"
        Me.tab_listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_listado.Size = New System.Drawing.Size(805, 550)
        Me.tab_listado.TabIndex = 1
        Me.tab_listado.Text = "Listado"
        Me.tab_listado.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(351, 3)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(99, 25)
        Me.Label10.TabIndex = 38
        Me.Label10.Text = "Pedidos"
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._61848_deltton
        Me.cmd_eliminar.Location = New System.Drawing.Point(107, 464)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_eliminar.TabIndex = 27
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.cmd_salir.Location = New System.Drawing.Point(703, 462)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(80, 80)
        Me.cmd_salir.TabIndex = 26
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._84380_edit_button545
        Me.cmd_modificar.Location = New System.Drawing.Point(21, 464)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar.TabIndex = 25
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'tabla_pedidos
        '
        Me.tabla_pedidos.AllowUserToAddRows = False
        Me.tabla_pedidos.AllowUserToDeleteRows = False
        Me.tabla_pedidos.AllowUserToResizeColumns = False
        Me.tabla_pedidos.AllowUserToResizeRows = False
        Me.tabla_pedidos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_pedidos.BackgroundColor = System.Drawing.Color.Gainsboro
        Me.tabla_pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_pedidos.Location = New System.Drawing.Point(21, 43)
        Me.tabla_pedidos.Name = "tabla_pedidos"
        Me.tabla_pedidos.ReadOnly = True
        Me.tabla_pedidos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_pedidos.Size = New System.Drawing.Size(762, 349)
        Me.tabla_pedidos.TabIndex = 0
        '
        'gestor_pedidos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(812, 574)
        Me.Controls.Add(Me.TabControl1)
        Me.IsMdiContainer = True
        Me.Name = "gestor_pedidos"
        Me.Text = "Pedidos"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.tabla_detalles, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.tab_nuevo.ResumeLayout(False)
        Me.tab_listado.ResumeLayout(False)
        Me.tab_listado.PerformLayout()
        CType(Me.tabla_pedidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents cmb_categoria As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents MaskedTextBox1 As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmb_modelo As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmb_marca As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tabla_detalles As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_agregar_detalle As System.Windows.Forms.Button
    Friend WithEvents txt_observaciones As System.Windows.Forms.TextBox
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_nuevo As System.Windows.Forms.TabPage
    Friend WithEvents tab_listado As System.Windows.Forms.TabPage
    Friend WithEvents tabla_pedidos As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir2 As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo_producto As System.Windows.Forms.Button
    Friend WithEvents cmd_nueva_marca As System.Windows.Forms.Button
End Class
