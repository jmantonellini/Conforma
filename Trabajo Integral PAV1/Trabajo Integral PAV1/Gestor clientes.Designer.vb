<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_clientes
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
        Me.tabla_clientes = New System.Windows.Forms.DataGridView()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.control_tab = New System.Windows.Forms.TabControl()
        Me.tab_datos_personales = New System.Windows.Forms.TabPage()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_contacto = New System.Windows.Forms.TabPage()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_celular = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_fijo = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tab_domicilios = New System.Windows.Forms.TabPage()
        Me.txt_altura_calle = New System.Windows.Forms.MaskedTextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cmb_barrio = New System.Windows.Forms.ComboBox()
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_pais = New System.Windows.Forms.ComboBox()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.control_tab.SuspendLayout()
        Me.tab_datos_personales.SuspendLayout()
        Me.tab_contacto.SuspendLayout()
        Me.tab_domicilios.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla_clientes
        '
        Me.tabla_clientes.BackgroundColor = System.Drawing.SystemColors.Control
        Me.tabla_clientes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Empresa, Me.Celular})
        Me.tabla_clientes.GridColor = System.Drawing.SystemColors.Control
        Me.tabla_clientes.Location = New System.Drawing.Point(443, 45)
        Me.tabla_clientes.Margin = New System.Windows.Forms.Padding(0)
        Me.tabla_clientes.Name = "tabla_clientes"
        Me.tabla_clientes.Size = New System.Drawing.Size(446, 391)
        Me.tabla_clientes.TabIndex = 1
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'control_tab
        '
        Me.control_tab.Controls.Add(Me.tab_datos_personales)
        Me.control_tab.Controls.Add(Me.tab_contacto)
        Me.control_tab.Controls.Add(Me.tab_domicilios)
        Me.control_tab.Location = New System.Drawing.Point(1, 23)
        Me.control_tab.Margin = New System.Windows.Forms.Padding(0)
        Me.control_tab.Name = "control_tab"
        Me.control_tab.Padding = New System.Drawing.Point(0, 0)
        Me.control_tab.SelectedIndex = 0
        Me.control_tab.Size = New System.Drawing.Size(446, 417)
        Me.control_tab.TabIndex = 2
        '
        'tab_datos_personales
        '
        Me.tab_datos_personales.BackColor = System.Drawing.SystemColors.Control
        Me.tab_datos_personales.Controls.Add(Me.Label19)
        Me.tab_datos_personales.Controls.Add(Me.Label12)
        Me.tab_datos_personales.Controls.Add(Me.Label11)
        Me.tab_datos_personales.Controls.Add(Me.Label10)
        Me.tab_datos_personales.Controls.Add(Me.txt_empresa)
        Me.tab_datos_personales.Controls.Add(Me.txt_cuit)
        Me.tab_datos_personales.Controls.Add(Me.txt_documento)
        Me.tab_datos_personales.Controls.Add(Me.cmb_tipo_documento)
        Me.tab_datos_personales.Controls.Add(Me.txt_apellido)
        Me.tab_datos_personales.Controls.Add(Me.txt_nombre)
        Me.tab_datos_personales.Controls.Add(Me.Label6)
        Me.tab_datos_personales.Controls.Add(Me.Label5)
        Me.tab_datos_personales.Controls.Add(Me.Label4)
        Me.tab_datos_personales.Controls.Add(Me.Label3)
        Me.tab_datos_personales.Controls.Add(Me.Label2)
        Me.tab_datos_personales.Controls.Add(Me.Label1)
        Me.tab_datos_personales.Location = New System.Drawing.Point(4, 22)
        Me.tab_datos_personales.Margin = New System.Windows.Forms.Padding(0)
        Me.tab_datos_personales.Name = "tab_datos_personales"
        Me.tab_datos_personales.Size = New System.Drawing.Size(438, 391)
        Me.tab_datos_personales.TabIndex = 0
        Me.tab_datos_personales.Text = "Datos Personales"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Location = New System.Drawing.Point(12, 131)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(17, 24)
        Me.Label19.TabIndex = 27
        Me.Label19.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(24, 96)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(17, 24)
        Me.Label12.TabIndex = 26
        Me.Label12.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(69, 62)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(17, 24)
        Me.Label11.TabIndex = 25
        Me.Label11.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(69, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(17, 24)
        Me.Label10.TabIndex = 24
        Me.Label10.Text = "*"
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(138, 202)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(251, 20)
        Me.txt_empresa.TabIndex = 6
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(139, 168)
        Me.txt_cuit.Mask = "99999999999"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(78, 20)
        Me.txt_cuit.TabIndex = 4
        Me.txt_cuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(139, 134)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(58, 20)
        Me.txt_documento.TabIndex = 3
        Me.txt_documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(139, 99)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_documento.TabIndex = 2
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(139, 65)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(250, 20)
        Me.txt_apellido.TabIndex = 1
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(139, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(250, 20)
        Me.txt_nombre.TabIndex = 0
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(79, 202)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Empresa:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(95, 168)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CUIT:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Número Documento:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(41, 99)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Documento:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 65)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'tab_contacto
        '
        Me.tab_contacto.Controls.Add(Me.txt_mail)
        Me.tab_contacto.Controls.Add(Me.Label9)
        Me.tab_contacto.Controls.Add(Me.txt_celular)
        Me.tab_contacto.Controls.Add(Me.Label8)
        Me.tab_contacto.Controls.Add(Me.txt_fijo)
        Me.tab_contacto.Controls.Add(Me.Label7)
        Me.tab_contacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_contacto.Name = "tab_contacto"
        Me.tab_contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_contacto.Size = New System.Drawing.Size(438, 391)
        Me.tab_contacto.TabIndex = 1
        Me.tab_contacto.Text = "Contacto"
        Me.tab_contacto.UseVisualStyleBackColor = True
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(139, 95)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(248, 20)
        Me.txt_mail.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(98, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Email:"
        '
        'txt_celular
        '
        Me.txt_celular.Location = New System.Drawing.Point(139, 63)
        Me.txt_celular.Name = "txt_celular"
        Me.txt_celular.Size = New System.Drawing.Size(248, 20)
        Me.txt_celular.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(46, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Teléfono Celular:"
        '
        'txt_fijo
        '
        Me.txt_fijo.Location = New System.Drawing.Point(139, 31)
        Me.txt_fijo.Name = "txt_fijo"
        Me.txt_fijo.Size = New System.Drawing.Size(248, 20)
        Me.txt_fijo.TabIndex = 0
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(62, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Teléfono Fijo:"
        '
        'tab_domicilios
        '
        Me.tab_domicilios.Controls.Add(Me.txt_altura_calle)
        Me.tab_domicilios.Controls.Add(Me.Label18)
        Me.tab_domicilios.Controls.Add(Me.txt_calle)
        Me.tab_domicilios.Controls.Add(Me.Label17)
        Me.tab_domicilios.Controls.Add(Me.Label16)
        Me.tab_domicilios.Controls.Add(Me.cmb_barrio)
        Me.tab_domicilios.Controls.Add(Me.cmb_ciudad)
        Me.tab_domicilios.Controls.Add(Me.Label15)
        Me.tab_domicilios.Controls.Add(Me.Label14)
        Me.tab_domicilios.Controls.Add(Me.cmb_provincia)
        Me.tab_domicilios.Controls.Add(Me.Label13)
        Me.tab_domicilios.Controls.Add(Me.cmb_pais)
        Me.tab_domicilios.Location = New System.Drawing.Point(4, 22)
        Me.tab_domicilios.Name = "tab_domicilios"
        Me.tab_domicilios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_domicilios.Size = New System.Drawing.Size(438, 391)
        Me.tab_domicilios.TabIndex = 2
        Me.tab_domicilios.Text = "Domicilios"
        Me.tab_domicilios.UseVisualStyleBackColor = True
        '
        'txt_altura_calle
        '
        Me.txt_altura_calle.Location = New System.Drawing.Point(139, 215)
        Me.txt_altura_calle.Mask = "999999"
        Me.txt_altura_calle.Name = "txt_altura_calle"
        Me.txt_altura_calle.Size = New System.Drawing.Size(61, 20)
        Me.txt_altura_calle.TabIndex = 5
        Me.txt_altura_calle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(114, 218)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(22, 13)
        Me.Label18.TabIndex = 10
        Me.Label18.Text = "Nº:"
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(139, 179)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(161, 20)
        Me.txt_calle.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(100, 182)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(33, 13)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Calle:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(99, 144)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(34, 13)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "Barrio"
        '
        'cmb_barrio
        '
        Me.cmb_barrio.FormattingEnabled = True
        Me.cmb_barrio.Location = New System.Drawing.Point(139, 142)
        Me.cmb_barrio.Name = "cmb_barrio"
        Me.cmb_barrio.Size = New System.Drawing.Size(161, 21)
        Me.cmb_barrio.TabIndex = 3
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.FormattingEnabled = True
        Me.cmb_ciudad.Location = New System.Drawing.Point(139, 105)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(161, 21)
        Me.cmb_ciudad.TabIndex = 2
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(90, 106)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(43, 13)
        Me.Label15.TabIndex = 4
        Me.Label15.Text = "Ciudad:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(79, 71)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(54, 13)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Provincia:"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(139, 68)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(161, 21)
        Me.cmb_provincia.TabIndex = 1
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(101, 34)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "País:"
        '
        'cmb_pais
        '
        Me.cmb_pais.FormattingEnabled = True
        Me.cmb_pais.Location = New System.Drawing.Point(139, 31)
        Me.cmb_pais.Name = "cmb_pais"
        Me.cmb_pais.Size = New System.Drawing.Size(161, 21)
        Me.cmb_pais.TabIndex = 0
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(12, 443)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(64, 55)
        Me.cmd_nuevo.TabIndex = 20
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.Location = New System.Drawing.Point(81, 443)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(64, 55)
        Me.cmd_guardar.TabIndex = 21
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(827, 443)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(55, 55)
        Me.cmd_salir.TabIndex = 22
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'cmd_modificar
        '
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Location = New System.Drawing.Point(150, 443)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(64, 55)
        Me.cmd_modificar.TabIndex = 23
        Me.cmd_modificar.Text = "Modificar"
        Me.cmd_modificar.UseVisualStyleBackColor = True
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Location = New System.Drawing.Point(220, 443)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(64, 55)
        Me.cmd_eliminar.TabIndex = 24
        Me.cmd_eliminar.Text = "Eliminar"
        Me.cmd_eliminar.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(12, 501)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 24)
        Me.Label20.TabIndex = 33
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(25, 512)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(91, 13)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Datos obligatorios"
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(758, 23)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 34
        Me.lbl_hora.Text = "Label22"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'gestor_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 560)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.control_tab)
        Me.Controls.Add(Me.tabla_clientes)
        Me.HelpButton = True
        Me.Name = "gestor_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        Me.TransparencyKey = System.Drawing.SystemColors.ControlDarkDark
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.control_tab.ResumeLayout(False)
        Me.tab_datos_personales.ResumeLayout(False)
        Me.tab_datos_personales.PerformLayout()
        Me.tab_contacto.ResumeLayout(False)
        Me.tab_contacto.PerformLayout()
        Me.tab_domicilios.ResumeLayout(False)
        Me.tab_domicilios.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents control_tab As System.Windows.Forms.TabControl
    Friend WithEvents tab_datos_personales As System.Windows.Forms.TabPage
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.MaskedTextBox
    Friend WithEvents txt_documento As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmb_tipo_documento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tab_contacto As System.Windows.Forms.TabPage
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_celular As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_fijo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tab_domicilios As System.Windows.Forms.TabPage
    Friend WithEvents tabla_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents cmb_pais As System.Windows.Forms.ComboBox
    Friend WithEvents txt_altura_calle As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_calle As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents cmb_barrio As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
End Class
