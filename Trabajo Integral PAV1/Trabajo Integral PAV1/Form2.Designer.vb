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
        Me.tabla_clientes = New System.Windows.Forms.DataGridView()
        Me.Celular = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.control_tab = New System.Windows.Forms.TabControl()
        Me.tab_domicilios = New System.Windows.Forms.TabPage()
        Me.tab_contacto = New System.Windows.Forms.TabPage()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_fijo = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tab_datos_personales = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.cmb_tipo_documento = New System.Windows.Forms.ComboBox()
        Me.txt_documento = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cuit = New System.Windows.Forms.MaskedTextBox()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.control_tab.SuspendLayout()
        Me.tab_contacto.SuspendLayout()
        Me.tab_datos_personales.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla_clientes
        '
        Me.tabla_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_clientes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Apellido, Me.Nombre, Me.Empresa, Me.Celular})
        Me.tabla_clientes.Location = New System.Drawing.Point(407, 3)
        Me.tabla_clientes.Name = "tabla_clientes"
        Me.tabla_clientes.Size = New System.Drawing.Size(444, 428)
        Me.tabla_clientes.TabIndex = 1
        '
        'Celular
        '
        Me.Celular.HeaderText = "Celular"
        Me.Celular.Name = "Celular"
        Me.Celular.ReadOnly = True
        '
        'Empresa
        '
        Me.Empresa.HeaderText = "Empresa"
        Me.Empresa.Name = "Empresa"
        Me.Empresa.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Apellido
        '
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        '
        'control_tab
        '
        Me.control_tab.Controls.Add(Me.tab_datos_personales)
        Me.control_tab.Controls.Add(Me.tab_contacto)
        Me.control_tab.Controls.Add(Me.tab_domicilios)
        Me.control_tab.Location = New System.Drawing.Point(3, 3)
        Me.control_tab.Name = "control_tab"
        Me.control_tab.SelectedIndex = 0
        Me.control_tab.Size = New System.Drawing.Size(398, 453)
        Me.control_tab.TabIndex = 0
        '
        'tab_domicilios
        '
        Me.tab_domicilios.Location = New System.Drawing.Point(4, 22)
        Me.tab_domicilios.Name = "tab_domicilios"
        Me.tab_domicilios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_domicilios.Size = New System.Drawing.Size(390, 427)
        Me.tab_domicilios.TabIndex = 2
        Me.tab_domicilios.Text = "Domicilios"
        Me.tab_domicilios.UseVisualStyleBackColor = True
        '
        'tab_contacto
        '
        Me.tab_contacto.Controls.Add(Me.Label9)
        Me.tab_contacto.Controls.Add(Me.TextBox1)
        Me.tab_contacto.Controls.Add(Me.Label8)
        Me.tab_contacto.Controls.Add(Me.txt_fijo)
        Me.tab_contacto.Controls.Add(Me.Label7)
        Me.tab_contacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_contacto.Name = "tab_contacto"
        Me.tab_contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_contacto.Size = New System.Drawing.Size(390, 427)
        Me.tab_contacto.TabIndex = 1
        Me.tab_contacto.Text = "Contacto"
        Me.tab_contacto.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(46, 34)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 13)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Telefono Fijo:"
        '
        'txt_fijo
        '
        Me.txt_fijo.Location = New System.Drawing.Point(120, 31)
        Me.txt_fijo.Name = "txt_fijo"
        Me.txt_fijo.Size = New System.Drawing.Size(248, 20)
        Me.txt_fijo.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 67)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Telefono Celular:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(120, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(248, 20)
        Me.TextBox1.TabIndex = 3
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(82, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Email:"
        '
        'tab_datos_personales
        '
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
        Me.tab_datos_personales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datos_personales.Size = New System.Drawing.Size(390, 427)
        Me.tab_datos_personales.TabIndex = 0
        Me.tab_datos_personales.Text = "Datos Personales"
        Me.tab_datos_personales.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(66, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(66, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Apellido:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo Documento:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(8, 137)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Numero Documento:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(78, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CUIT:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(62, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Empresa:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(120, 31)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(250, 20)
        Me.txt_nombre.TabIndex = 6
        '
        'txt_apellido
        '
        Me.txt_apellido.Location = New System.Drawing.Point(120, 66)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(250, 20)
        Me.txt_apellido.TabIndex = 7
        '
        'cmb_tipo_documento
        '
        Me.cmb_tipo_documento.FormattingEnabled = True
        Me.cmb_tipo_documento.Location = New System.Drawing.Point(120, 99)
        Me.cmb_tipo_documento.Name = "cmb_tipo_documento"
        Me.cmb_tipo_documento.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo_documento.TabIndex = 8
        '
        'txt_documento
        '
        Me.txt_documento.Location = New System.Drawing.Point(120, 134)
        Me.txt_documento.Mask = "99999999"
        Me.txt_documento.Name = "txt_documento"
        Me.txt_documento.Size = New System.Drawing.Size(121, 20)
        Me.txt_documento.TabIndex = 9
        Me.txt_documento.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(120, 168)
        Me.txt_cuit.Mask = "99999999999"
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(121, 20)
        Me.txt_cuit.TabIndex = 10
        Me.txt_cuit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(119, 203)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(251, 20)
        Me.txt_empresa.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(58, 32)
        Me.Label10.Margin = New System.Windows.Forms.Padding(0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(11, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "*"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(58, 69)
        Me.Label11.Margin = New System.Windows.Forms.Padding(0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(11, 13)
        Me.Label11.TabIndex = 13
        Me.Label11.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(0, 134)
        Me.Label12.Margin = New System.Windows.Forms.Padding(0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(11, 13)
        Me.Label12.TabIndex = 14
        Me.Label12.Text = "*"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.AutoSize = True
        Me.FlowLayoutPanel1.Controls.Add(Me.control_tab)
        Me.FlowLayoutPanel1.Controls.Add(Me.tabla_clientes)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(894, 560)
        Me.FlowLayoutPanel1.TabIndex = 2
        '
        'gestor_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 560)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.HelpButton = True
        Me.Name = "gestor_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Clientes"
        CType(Me.tabla_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.control_tab.ResumeLayout(false)
        Me.tab_contacto.ResumeLayout(false)
        Me.tab_contacto.PerformLayout
        Me.tab_datos_personales.ResumeLayout(false)
        Me.tab_datos_personales.PerformLayout
        Me.FlowLayoutPanel1.ResumeLayout(false)
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents control_tab As System.Windows.Forms.TabControl
    Friend WithEvents tab_datos_personales As System.Windows.Forms.TabPage
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
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
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_fijo As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents tab_domicilios As System.Windows.Forms.TabPage
    Friend WithEvents tabla_clientes As System.Windows.Forms.DataGridView
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Empresa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Celular As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
End Class
