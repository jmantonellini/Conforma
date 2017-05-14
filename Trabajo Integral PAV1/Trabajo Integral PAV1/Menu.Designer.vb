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
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmd_gestor_paises = New System.Windows.Forms.Button()
        Me.cmd_gestor_categoria = New System.Windows.Forms.Button()
        Me.cmd_provincias = New System.Windows.Forms.Button()
        Me.cmd_gestor_localidades = New System.Windows.Forms.Button()
        Me.cmd_pedidos = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_gestor_clientes
        '
        Me.cmd_gestor_clientes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_clientes.Location = New System.Drawing.Point(266, 56)
        Me.cmd_gestor_clientes.Name = "cmd_gestor_clientes"
        Me.cmd_gestor_clientes.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_clientes.TabIndex = 0
        Me.cmd_gestor_clientes.Text = "Gestor Clientes"
        Me.cmd_gestor_clientes.UseVisualStyleBackColor = False
        '
        'cmd_gestor_empresas
        '
        Me.cmd_gestor_empresas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_empresas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_empresas.Location = New System.Drawing.Point(79, 56)
        Me.cmd_gestor_empresas.Name = "cmd_gestor_empresas"
        Me.cmd_gestor_empresas.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_empresas.TabIndex = 1
        Me.cmd_gestor_empresas.Text = "Gestor Empresas"
        Me.cmd_gestor_empresas.UseVisualStyleBackColor = False
        '
        'cmd_gestor_marcas
        '
        Me.cmd_gestor_marcas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_marcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_marcas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_marcas.Location = New System.Drawing.Point(79, 147)
        Me.cmd_gestor_marcas.Name = "cmd_gestor_marcas"
        Me.cmd_gestor_marcas.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_marcas.TabIndex = 2
        Me.cmd_gestor_marcas.Text = "Gestor Marcas"
        Me.cmd_gestor_marcas.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(238, 470)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.LogoConforma_Mesc_e1484836503615
        Me.PictureBox1.Location = New System.Drawing.Point(154, 392)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(183, 63)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 36
        Me.PictureBox1.TabStop = False
        '
        'cmd_gestor_paises
        '
        Me.cmd_gestor_paises.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_paises.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_paises.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_paises.Location = New System.Drawing.Point(266, 146)
        Me.cmd_gestor_paises.Name = "cmd_gestor_paises"
        Me.cmd_gestor_paises.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_paises.TabIndex = 2
        Me.cmd_gestor_paises.Text = "Gestor Paises"
        Me.cmd_gestor_paises.UseVisualStyleBackColor = False
        '
        'cmd_gestor_categoria
        '
        Me.cmd_gestor_categoria.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_categoria.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_categoria.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_categoria.Location = New System.Drawing.Point(79, 238)
        Me.cmd_gestor_categoria.Name = "cmd_gestor_categoria"
        Me.cmd_gestor_categoria.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_categoria.TabIndex = 37
        Me.cmd_gestor_categoria.Text = "Gestor Categorias"
        Me.cmd_gestor_categoria.UseVisualStyleBackColor = False
        '
        'cmd_provincias
        '
        Me.cmd_provincias.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_provincias.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_provincias.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_provincias.Location = New System.Drawing.Point(266, 238)
        Me.cmd_provincias.Name = "cmd_provincias"
        Me.cmd_provincias.Size = New System.Drawing.Size(171, 58)
        Me.cmd_provincias.TabIndex = 38
        Me.cmd_provincias.Text = "Gestor Provincias"
        Me.cmd_provincias.UseVisualStyleBackColor = False
        '
        'cmd_gestor_localidades
        '
        Me.cmd_gestor_localidades.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_localidades.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_localidades.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_localidades.Location = New System.Drawing.Point(79, 316)
        Me.cmd_gestor_localidades.Name = "cmd_gestor_localidades"
        Me.cmd_gestor_localidades.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_localidades.TabIndex = 37
        Me.cmd_gestor_localidades.Text = "Gestor Localidades"
        Me.cmd_gestor_localidades.UseVisualStyleBackColor = False
        '
        'cmd_pedidos
        '
        Me.cmd_pedidos.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_pedidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_pedidos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_pedidos.Location = New System.Drawing.Point(266, 316)
        Me.cmd_pedidos.Name = "cmd_pedidos"
        Me.cmd_pedidos.Size = New System.Drawing.Size(171, 58)
        Me.cmd_pedidos.TabIndex = 39
        Me.cmd_pedidos.Text = "Pedidos"
        Me.cmd_pedidos.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(516, 516)
        Me.Controls.Add(Me.cmd_pedidos)
        Me.Controls.Add(Me.cmd_provincias)
        Me.Controls.Add(Me.cmd_gestor_localidades)
        Me.Controls.Add(Me.cmd_gestor_categoria)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.cmd_gestor_paises)
        Me.Controls.Add(Me.cmd_gestor_marcas)
        Me.Controls.Add(Me.cmd_gestor_empresas)
        Me.Controls.Add(Me.cmd_gestor_clientes)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Menu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Conforma"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
