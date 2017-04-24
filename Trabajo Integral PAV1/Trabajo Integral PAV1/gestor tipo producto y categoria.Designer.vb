<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_tipo_producto_y_categorias
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
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.cmd_nueva_area = New System.Windows.Forms.Button()
        Me.cmd_modificar_area = New System.Windows.Forms.Button()
        Me.lbl_tipo_producto = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevo_producto = New System.Windows.Forms.Button()
        Me.cmd_modificar_tipo_producto = New System.Windows.Forms.Button()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.tabla_categorias = New System.Windows.Forms.DataGridView()
        Me.cmd_nueva_categoria = New System.Windows.Forms.Button()
        Me.cmd_modificar_categoria = New System.Windows.Forms.Button()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabla_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(77, 49)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(32, 13)
        Me.lbl_area.TabIndex = 0
        Me.lbl_area.Text = "Área:"
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(115, 46)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(121, 21)
        Me.cmb_area.TabIndex = 1
        '
        'cmd_nueva_area
        '
        Me.cmd_nueva_area.Location = New System.Drawing.Point(277, 44)
        Me.cmd_nueva_area.Name = "cmd_nueva_area"
        Me.cmd_nueva_area.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nueva_area.TabIndex = 2
        Me.cmd_nueva_area.Text = "Nuevo"
        Me.cmd_nueva_area.UseVisualStyleBackColor = True
        '
        'cmd_modificar_area
        '
        Me.cmd_modificar_area.Location = New System.Drawing.Point(371, 44)
        Me.cmd_modificar_area.Name = "cmd_modificar_area"
        Me.cmd_modificar_area.Size = New System.Drawing.Size(75, 23)
        Me.cmd_modificar_area.TabIndex = 2
        Me.cmd_modificar_area.Text = "Modificar"
        Me.cmd_modificar_area.UseVisualStyleBackColor = True
        '
        'lbl_tipo_producto
        '
        Me.lbl_tipo_producto.AutoSize = True
        Me.lbl_tipo_producto.Location = New System.Drawing.Point(35, 112)
        Me.lbl_tipo_producto.Name = "lbl_tipo_producto"
        Me.lbl_tipo_producto.Size = New System.Drawing.Size(77, 13)
        Me.lbl_tipo_producto.TabIndex = 3
        Me.lbl_tipo_producto.Text = "Tipo Producto:"
        '
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(115, 109)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_producto.TabIndex = 4
        '
        'cmd_nuevo_producto
        '
        Me.cmd_nuevo_producto.Location = New System.Drawing.Point(277, 107)
        Me.cmd_nuevo_producto.Name = "cmd_nuevo_producto"
        Me.cmd_nuevo_producto.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nuevo_producto.TabIndex = 2
        Me.cmd_nuevo_producto.Text = "Nuevo"
        Me.cmd_nuevo_producto.UseVisualStyleBackColor = True
        '
        'cmd_modificar_tipo_producto
        '
        Me.cmd_modificar_tipo_producto.Location = New System.Drawing.Point(371, 107)
        Me.cmd_modificar_tipo_producto.Name = "cmd_modificar_tipo_producto"
        Me.cmd_modificar_tipo_producto.Size = New System.Drawing.Size(75, 23)
        Me.cmd_modificar_tipo_producto.TabIndex = 2
        Me.cmd_modificar_tipo_producto.Text = "Modificar"
        Me.cmd_modificar_tipo_producto.UseVisualStyleBackColor = True
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Location = New System.Drawing.Point(35, 186)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(62, 13)
        Me.lbl_categoria.TabIndex = 5
        Me.lbl_categoria.Text = "Categorías:"
        '
        'tabla_categorias
        '
        Me.tabla_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_categorias.Location = New System.Drawing.Point(38, 217)
        Me.tabla_categorias.Name = "tabla_categorias"
        Me.tabla_categorias.Size = New System.Drawing.Size(373, 192)
        Me.tabla_categorias.TabIndex = 6
        '
        'cmd_nueva_categoria
        '
        Me.cmd_nueva_categoria.Location = New System.Drawing.Point(38, 415)
        Me.cmd_nueva_categoria.Name = "cmd_nueva_categoria"
        Me.cmd_nueva_categoria.Size = New System.Drawing.Size(75, 41)
        Me.cmd_nueva_categoria.TabIndex = 7
        Me.cmd_nueva_categoria.Text = "Nueva categoría"
        Me.cmd_nueva_categoria.UseVisualStyleBackColor = True
        '
        'cmd_modificar_categoria
        '
        Me.cmd_modificar_categoria.Location = New System.Drawing.Point(119, 415)
        Me.cmd_modificar_categoria.Name = "cmd_modificar_categoria"
        Me.cmd_modificar_categoria.Size = New System.Drawing.Size(75, 41)
        Me.cmd_modificar_categoria.TabIndex = 7
        Me.cmd_modificar_categoria.Text = "Modificar categoría"
        Me.cmd_modificar_categoria.UseVisualStyleBackColor = True
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(313, 459)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gestor_tipo_producto_y_categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(481, 478)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.cmd_modificar_categoria)
        Me.Controls.Add(Me.cmd_nueva_categoria)
        Me.Controls.Add(Me.tabla_categorias)
        Me.Controls.Add(Me.lbl_categoria)
        Me.Controls.Add(Me.cmb_tipo_producto)
        Me.Controls.Add(Me.lbl_tipo_producto)
        Me.Controls.Add(Me.cmd_modificar_tipo_producto)
        Me.Controls.Add(Me.cmd_modificar_area)
        Me.Controls.Add(Me.cmd_nuevo_producto)
        Me.Controls.Add(Me.cmd_nueva_area)
        Me.Controls.Add(Me.cmb_area)
        Me.Controls.Add(Me.lbl_area)
        Me.Name = "gestor_tipo_producto_y_categorias"
        Me.Text = "Gestor de tipo de producto, categorías y áreas"
        CType(Me.tabla_categorias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_area As System.Windows.Forms.Label
    Friend WithEvents cmb_area As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nueva_area As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_area As System.Windows.Forms.Button
    Friend WithEvents lbl_tipo_producto As System.Windows.Forms.Label
    Friend WithEvents cmb_tipo_producto As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nuevo_producto As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_tipo_producto As System.Windows.Forms.Button
    Friend WithEvents lbl_categoria As System.Windows.Forms.Label
    Friend WithEvents tabla_categorias As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nueva_categoria As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_categoria As System.Windows.Forms.Button
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
