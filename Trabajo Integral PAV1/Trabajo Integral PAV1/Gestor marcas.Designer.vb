<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_marcas_modelos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestor_marcas_modelos))
        Me.lbl_nombre_marca = New System.Windows.Forms.Label()
        Me.txt_marcas = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.tabla_marcas = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cmd_buscar_modelos = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.txt_modelos = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_modelos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_buscar_marcas = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tabla_marcas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre_marca
        '
        Me.lbl_nombre_marca.AutoSize = True
        Me.lbl_nombre_marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre_marca.Location = New System.Drawing.Point(10, 12)
        Me.lbl_nombre_marca.Name = "lbl_nombre_marca"
        Me.lbl_nombre_marca.Size = New System.Drawing.Size(65, 20)
        Me.lbl_nombre_marca.TabIndex = 0
        Me.lbl_nombre_marca.Text = "Marcas:"
        '
        'txt_marcas
        '
        Me.txt_marcas.Enabled = False
        Me.txt_marcas.Location = New System.Drawing.Point(81, 14)
        Me.txt_marcas.Name = "txt_marcas"
        Me.txt_marcas.Size = New System.Drawing.Size(113, 20)
        Me.txt_marcas.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(262, 316)
        Me.DataGridView1.TabIndex = 2
        '
        'tabla_marcas
        '
        Me.tabla_marcas.AllowUserToAddRows = False
        Me.tabla_marcas.AllowUserToDeleteRows = False
        Me.tabla_marcas.AllowUserToResizeColumns = False
        Me.tabla_marcas.AllowUserToResizeRows = False
        Me.tabla_marcas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_marcas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.nombre})
        Me.tabla_marcas.Location = New System.Drawing.Point(0, 74)
        Me.tabla_marcas.Name = "tabla_marcas"
        Me.tabla_marcas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_marcas.Size = New System.Drawing.Size(262, 316)
        Me.tabla_marcas.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cmd_buscar_modelos)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.txt_modelos)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.lbl_modelos)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(305, 99)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 476)
        Me.Panel1.TabIndex = 4
        '
        'cmd_buscar_modelos
        '
        Me.cmd_buscar_modelos.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.BUSCAR01
        Me.cmd_buscar_modelos.Location = New System.Drawing.Point(210, 416)
        Me.cmd_buscar_modelos.Name = "cmd_buscar_modelos"
        Me.cmd_buscar_modelos.Size = New System.Drawing.Size(40, 40)
        Me.cmd_buscar_modelos.TabIndex = 47
        Me.cmd_buscar_modelos.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Gainsboro
        Me.Button1.Enabled = False
        Me.Button1.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.Button1.Location = New System.Drawing.Point(115, 396)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(80, 80)
        Me.Button1.TabIndex = 25
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Gainsboro
        Me.Button2.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.Button2.Location = New System.Drawing.Point(16, 396)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(80, 80)
        Me.Button2.TabIndex = 24
        Me.Button2.UseVisualStyleBackColor = False
        '
        'txt_modelos
        '
        Me.txt_modelos.Enabled = False
        Me.txt_modelos.Location = New System.Drawing.Point(91, 14)
        Me.txt_modelos.Name = "txt_modelos"
        Me.txt_modelos.Size = New System.Drawing.Size(113, 20)
        Me.txt_modelos.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(142, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos de modelos:"
        '
        'lbl_modelos
        '
        Me.lbl_modelos.AutoSize = True
        Me.lbl_modelos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelos.Location = New System.Drawing.Point(12, 12)
        Me.lbl_modelos.Name = "lbl_modelos"
        Me.lbl_modelos.Size = New System.Drawing.Size(73, 20)
        Me.lbl_modelos.TabIndex = 0
        Me.lbl_modelos.Text = "Modelos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(134, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de marcas:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btn_buscar_marcas)
        Me.Panel2.Controls.Add(Me.cmd_guardar)
        Me.Panel2.Controls.Add(Me.cmd_nuevo)
        Me.Panel2.Controls.Add(Me.txt_marcas)
        Me.Panel2.Controls.Add(Me.lbl_nombre_marca)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.tabla_marcas)
        Me.Panel2.Location = New System.Drawing.Point(19, 99)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 476)
        Me.Panel2.TabIndex = 5
        '
        'btn_buscar_marcas
        '
        Me.btn_buscar_marcas.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.BUSCAR01
        Me.btn_buscar_marcas.Location = New System.Drawing.Point(210, 416)
        Me.btn_buscar_marcas.Name = "btn_buscar_marcas"
        Me.btn_buscar_marcas.Size = New System.Drawing.Size(40, 40)
        Me.btn_buscar_marcas.TabIndex = 46
        Me.btn_buscar_marcas.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.cmd_guardar.Location = New System.Drawing.Point(115, 396)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_guardar.TabIndex = 23
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(14, 396)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 22
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(443, 9)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(251, 576)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(84, 55)
        Me.cmd_salir.TabIndex = 36
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(129, 43)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(329, 25)
        Me.Label22.TabIndex = 42
        Me.Label22.Text = "Gestor de Marcas y Modelos"
        '
        'id
        '
        Me.id.HeaderText = "Id"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 219
        '
        'gestor_marcas_modelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 641)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestor_marcas_modelos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestor de marcas y modelos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tabla_marcas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_nombre_marca As System.Windows.Forms.Label
    Friend WithEvents txt_marcas As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents tabla_marcas As System.Windows.Forms.DataGridView
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_modelos As System.Windows.Forms.TextBox
    Friend WithEvents lbl_modelos As System.Windows.Forms.Label
    Friend WithEvents cmd_buscar_modelos As System.Windows.Forms.Button
    Friend WithEvents btn_buscar_marcas As System.Windows.Forms.Button
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
