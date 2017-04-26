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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestor_tipo_producto_y_categorias))
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.cmb_area = New System.Windows.Forms.ComboBox()
        Me.lbl_tipo_producto = New System.Windows.Forms.Label()
        Me.cmb_tipo_producto = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevo_producto = New System.Windows.Forms.Button()
        Me.cmd_modificar_tipo_producto = New System.Windows.Forms.Button()
        Me.lbl_categoria = New System.Windows.Forms.Label()
        Me.tabla_categorias = New System.Windows.Forms.DataGridView()
        Me.cmd_nueva_categoria = New System.Windows.Forms.Button()
        Me.cmd_modificar_categoria = New System.Windows.Forms.Button()
        Me.cmd_eliminar_tipo = New System.Windows.Forms.Button()
        Me.cmd_eliminar_categoria = New System.Windows.Forms.Button()
        Me.cmd_eliminar_area = New System.Windows.Forms.Button()
        Me.cmd_modificar_area = New System.Windows.Forms.Button()
        Me.cmd_nueva_area = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        CType(Me.tabla_categorias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_area.Location = New System.Drawing.Point(109, 38)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(52, 20)
        Me.lbl_area.TabIndex = 0
        Me.lbl_area.Text = "Área:"
        '
        'cmb_area
        '
        Me.cmb_area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_area.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_area.FormattingEnabled = True
        Me.cmb_area.Location = New System.Drawing.Point(167, 35)
        Me.cmb_area.Name = "cmb_area"
        Me.cmb_area.Size = New System.Drawing.Size(133, 28)
        Me.cmb_area.TabIndex = 1
        '
        'lbl_tipo_producto
        '
        Me.lbl_tipo_producto.AutoSize = True
        Me.lbl_tipo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_tipo_producto.Location = New System.Drawing.Point(36, 88)
        Me.lbl_tipo_producto.Name = "lbl_tipo_producto"
        Me.lbl_tipo_producto.Size = New System.Drawing.Size(125, 20)
        Me.lbl_tipo_producto.TabIndex = 3
        Me.lbl_tipo_producto.Text = "Tipo Producto:"
        '
        'cmb_tipo_producto
        '
        Me.cmb_tipo_producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_tipo_producto.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_tipo_producto.FormattingEnabled = True
        Me.cmb_tipo_producto.Location = New System.Drawing.Point(167, 85)
        Me.cmb_tipo_producto.Name = "cmb_tipo_producto"
        Me.cmb_tipo_producto.Size = New System.Drawing.Size(133, 28)
        Me.cmb_tipo_producto.TabIndex = 4
        '
        'cmd_nuevo_producto
        '
        Me.cmd_nuevo_producto.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._16909
        Me.cmd_nuevo_producto.Location = New System.Drawing.Point(324, 80)
        Me.cmd_nuevo_producto.Name = "cmd_nuevo_producto"
        Me.cmd_nuevo_producto.Size = New System.Drawing.Size(38, 38)
        Me.cmd_nuevo_producto.TabIndex = 2
        Me.cmd_nuevo_producto.UseVisualStyleBackColor = True
        '
        'cmd_modificar_tipo_producto
        '
        Me.cmd_modificar_tipo_producto.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.X
        Me.cmd_modificar_tipo_producto.Location = New System.Drawing.Point(412, 80)
        Me.cmd_modificar_tipo_producto.Name = "cmd_modificar_tipo_producto"
        Me.cmd_modificar_tipo_producto.Size = New System.Drawing.Size(38, 38)
        Me.cmd_modificar_tipo_producto.TabIndex = 2
        Me.cmd_modificar_tipo_producto.UseVisualStyleBackColor = True
        '
        'lbl_categoria
        '
        Me.lbl_categoria.AutoSize = True
        Me.lbl_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_categoria.Location = New System.Drawing.Point(53, 140)
        Me.lbl_categoria.Name = "lbl_categoria"
        Me.lbl_categoria.Size = New System.Drawing.Size(101, 20)
        Me.lbl_categoria.TabIndex = 5
        Me.lbl_categoria.Text = "Categorías:"
        '
        'tabla_categorias
        '
        Me.tabla_categorias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_categorias.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.tabla_categorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_categorias.Location = New System.Drawing.Point(57, 173)
        Me.tabla_categorias.Name = "tabla_categorias"
        Me.tabla_categorias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_categorias.Size = New System.Drawing.Size(373, 172)
        Me.tabla_categorias.TabIndex = 6
        '
        'cmd_nueva_categoria
        '
        Me.cmd_nueva_categoria.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nueva_categoria.Location = New System.Drawing.Point(57, 370)
        Me.cmd_nueva_categoria.Name = "cmd_nueva_categoria"
        Me.cmd_nueva_categoria.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nueva_categoria.TabIndex = 7
        Me.cmd_nueva_categoria.UseVisualStyleBackColor = True
        '
        'cmd_modificar_categoria
        '
        Me.cmd_modificar_categoria.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._84380_edit_button545
        Me.cmd_modificar_categoria.Location = New System.Drawing.Point(154, 370)
        Me.cmd_modificar_categoria.Name = "cmd_modificar_categoria"
        Me.cmd_modificar_categoria.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar_categoria.TabIndex = 7
        Me.cmd_modificar_categoria.UseVisualStyleBackColor = True
        '
        'cmd_eliminar_tipo
        '
        Me.cmd_eliminar_tipo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._126483
        Me.cmd_eliminar_tipo.Location = New System.Drawing.Point(368, 80)
        Me.cmd_eliminar_tipo.Name = "cmd_eliminar_tipo"
        Me.cmd_eliminar_tipo.Size = New System.Drawing.Size(38, 38)
        Me.cmd_eliminar_tipo.TabIndex = 37
        Me.cmd_eliminar_tipo.UseVisualStyleBackColor = True
        '
        'cmd_eliminar_categoria
        '
        Me.cmd_eliminar_categoria.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._61848_deltton
        Me.cmd_eliminar_categoria.Location = New System.Drawing.Point(252, 370)
        Me.cmd_eliminar_categoria.Name = "cmd_eliminar_categoria"
        Me.cmd_eliminar_categoria.Size = New System.Drawing.Size(80, 80)
        Me.cmd_eliminar_categoria.TabIndex = 38
        Me.cmd_eliminar_categoria.UseVisualStyleBackColor = True
        '
        'cmd_eliminar_area
        '
        Me.cmd_eliminar_area.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.X
        Me.cmd_eliminar_area.Location = New System.Drawing.Point(412, 30)
        Me.cmd_eliminar_area.Name = "cmd_eliminar_area"
        Me.cmd_eliminar_area.Size = New System.Drawing.Size(38, 38)
        Me.cmd_eliminar_area.TabIndex = 36
        Me.cmd_eliminar_area.UseVisualStyleBackColor = True
        '
        'cmd_modificar_area
        '
        Me.cmd_modificar_area.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._126483
        Me.cmd_modificar_area.Location = New System.Drawing.Point(368, 30)
        Me.cmd_modificar_area.Name = "cmd_modificar_area"
        Me.cmd_modificar_area.Size = New System.Drawing.Size(38, 38)
        Me.cmd_modificar_area.TabIndex = 2
        Me.cmd_modificar_area.UseVisualStyleBackColor = True
        '
        'cmd_nueva_area
        '
        Me.cmd_nueva_area.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._16909
        Me.cmd_nueva_area.Location = New System.Drawing.Point(324, 30)
        Me.cmd_nueva_area.Name = "cmd_nueva_area"
        Me.cmd_nueva_area.Size = New System.Drawing.Size(38, 38)
        Me.cmd_nueva_area.TabIndex = 2
        Me.cmd_nueva_area.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.cmd_salir.Location = New System.Drawing.Point(394, 370)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(80, 80)
        Me.cmd_salir.TabIndex = 39
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'gestor_tipo_producto_y_categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(486, 462)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar_categoria)
        Me.Controls.Add(Me.cmd_eliminar_tipo)
        Me.Controls.Add(Me.cmd_eliminar_area)
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
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
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
    Friend WithEvents cmd_eliminar_area As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_tipo As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar_categoria As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
End Class
