<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Menu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Menu))
        Me.cmd_gestor_clientes = New System.Windows.Forms.Button()
        Me.cmd_gestor_empresas = New System.Windows.Forms.Button()
        Me.cmd_gestor_marcas = New System.Windows.Forms.Button()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.cmd_gestor_paises = New System.Windows.Forms.Button()
        Me.cmd_gestor_categoria = New System.Windows.Forms.Button()
        Me.cmd_provincias = New System.Windows.Forms.Button()
        Me.cmd_gestor_localidades = New System.Windows.Forms.Button()
        Me.cmd_pedidos = New System.Windows.Forms.Button()
        Me.cmd_reportes = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_estadisticas = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmd_gestor_clientes
        '
        Me.cmd_gestor_clientes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_clientes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_clientes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_clientes.Location = New System.Drawing.Point(15, 55)
        Me.cmd_gestor_clientes.Name = "cmd_gestor_clientes"
        Me.cmd_gestor_clientes.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_clientes.TabIndex = 1
        Me.cmd_gestor_clientes.Text = "Clientes"
        Me.cmd_gestor_clientes.UseVisualStyleBackColor = False
        '
        'cmd_gestor_empresas
        '
        Me.cmd_gestor_empresas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_empresas.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_empresas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_empresas.Location = New System.Drawing.Point(140, 56)
        Me.cmd_gestor_empresas.Name = "cmd_gestor_empresas"
        Me.cmd_gestor_empresas.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_empresas.TabIndex = 0
        Me.cmd_gestor_empresas.Text = "Empresas"
        Me.cmd_gestor_empresas.UseVisualStyleBackColor = False
        '
        'cmd_gestor_marcas
        '
        Me.cmd_gestor_marcas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_marcas.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_marcas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_marcas.Location = New System.Drawing.Point(265, 56)
        Me.cmd_gestor_marcas.Name = "cmd_gestor_marcas"
        Me.cmd_gestor_marcas.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_marcas.TabIndex = 2
        Me.cmd_gestor_marcas.Text = "Marcas"
        Me.cmd_gestor_marcas.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(423, 531)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'cmd_gestor_paises
        '
        Me.cmd_gestor_paises.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_paises.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_paises.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_paises.Location = New System.Drawing.Point(515, 56)
        Me.cmd_gestor_paises.Name = "cmd_gestor_paises"
        Me.cmd_gestor_paises.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_paises.TabIndex = 3
        Me.cmd_gestor_paises.Text = "Paises"
        Me.cmd_gestor_paises.UseVisualStyleBackColor = False
        '
        'cmd_gestor_categoria
        '
        Me.cmd_gestor_categoria.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_categoria.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_categoria.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_categoria.Location = New System.Drawing.Point(390, 56)
        Me.cmd_gestor_categoria.Name = "cmd_gestor_categoria"
        Me.cmd_gestor_categoria.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_categoria.TabIndex = 4
        Me.cmd_gestor_categoria.Text = "Categorias"
        Me.cmd_gestor_categoria.UseVisualStyleBackColor = False
        '
        'cmd_provincias
        '
        Me.cmd_provincias.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_provincias.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_provincias.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_provincias.Location = New System.Drawing.Point(640, 56)
        Me.cmd_provincias.Name = "cmd_provincias"
        Me.cmd_provincias.Size = New System.Drawing.Size(120, 50)
        Me.cmd_provincias.TabIndex = 5
        Me.cmd_provincias.Text = "Provincias"
        Me.cmd_provincias.UseVisualStyleBackColor = False
        '
        'cmd_gestor_localidades
        '
        Me.cmd_gestor_localidades.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_localidades.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_localidades.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_gestor_localidades.Location = New System.Drawing.Point(765, 56)
        Me.cmd_gestor_localidades.Name = "cmd_gestor_localidades"
        Me.cmd_gestor_localidades.Size = New System.Drawing.Size(120, 50)
        Me.cmd_gestor_localidades.TabIndex = 6
        Me.cmd_gestor_localidades.Text = "Localidades"
        Me.cmd_gestor_localidades.UseVisualStyleBackColor = False
        '
        'cmd_pedidos
        '
        Me.cmd_pedidos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_pedidos.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pedidos.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_pedidos.Location = New System.Drawing.Point(406, 155)
        Me.cmd_pedidos.Name = "cmd_pedidos"
        Me.cmd_pedidos.Size = New System.Drawing.Size(171, 58)
        Me.cmd_pedidos.TabIndex = 7
        Me.cmd_pedidos.Text = "Pedidos"
        Me.cmd_pedidos.UseVisualStyleBackColor = False
        '
        'cmd_reportes
        '
        Me.cmd_reportes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_reportes.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_reportes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_reportes.Location = New System.Drawing.Point(248, 52)
        Me.cmd_reportes.Name = "cmd_reportes"
        Me.cmd_reportes.Size = New System.Drawing.Size(148, 50)
        Me.cmd_reportes.TabIndex = 37
        Me.cmd_reportes.Text = "Reportes"
        Me.cmd_reportes.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.LogoConforma_Mesc_e1484836503615
        Me.PictureBox1.Location = New System.Drawing.Point(363, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(244, 78)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'cmd_estadisticas
        '
        Me.cmd_estadisticas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_estadisticas.Font = New System.Drawing.Font("Candara", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_estadisticas.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.cmd_estadisticas.Location = New System.Drawing.Point(65, 52)
        Me.cmd_estadisticas.Name = "cmd_estadisticas"
        Me.cmd_estadisticas.Size = New System.Drawing.Size(148, 50)
        Me.cmd_estadisticas.TabIndex = 4
        Me.cmd_estadisticas.Text = "Estadisticas"
        Me.cmd_estadisticas.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cmd_gestor_clientes)
        Me.Panel1.Controls.Add(Me.cmd_gestor_localidades)
        Me.Panel1.Controls.Add(Me.cmd_gestor_empresas)
        Me.Panel1.Controls.Add(Me.cmd_gestor_marcas)
        Me.Panel1.Controls.Add(Me.cmd_provincias)
        Me.Panel1.Controls.Add(Me.cmd_gestor_categoria)
        Me.Panel1.Controls.Add(Me.cmd_gestor_paises)
        Me.Panel1.Location = New System.Drawing.Point(33, 230)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(904, 134)
        Me.Panel1.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(386, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Gestores"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cmd_estadisticas)
        Me.Panel2.Controls.Add(Me.cmd_reportes)
        Me.Panel2.Location = New System.Drawing.Point(257, 382)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(457, 115)
        Me.Panel2.TabIndex = 39
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, CType(((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic) _
                Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(162, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(128, 31)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "Informes"
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(971, 557)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.cmd_pedidos)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_hora)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conforma"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmd_gestor_clientes As System.Windows.Forms.Button
    Friend WithEvents cmd_gestor_empresas As System.Windows.Forms.Button
    Friend WithEvents cmd_gestor_marcas As System.Windows.Forms.Button
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmd_gestor_paises As System.Windows.Forms.Button
    Friend WithEvents cmd_gestor_categoria As System.Windows.Forms.Button
    Friend WithEvents cmd_provincias As System.Windows.Forms.Button
    Friend WithEvents cmd_gestor_localidades As System.Windows.Forms.Button
    Friend WithEvents cmd_pedidos As System.Windows.Forms.Button
    Friend WithEvents cmd_reportes As System.Windows.Forms.Button
    Friend WithEvents cmd_estadisticas As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
