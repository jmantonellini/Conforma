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
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmd_gestor_clientes
        '
        Me.cmd_gestor_clientes.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_clientes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_clientes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_clientes.Location = New System.Drawing.Point(106, 95)
        Me.cmd_gestor_clientes.Name = "cmd_gestor_clientes"
        Me.cmd_gestor_clientes.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_clientes.TabIndex = 0
        Me.cmd_gestor_clientes.Text = "Gestor clientes"
        Me.cmd_gestor_clientes.UseVisualStyleBackColor = False
        '
        'cmd_gestor_empresas
        '
        Me.cmd_gestor_empresas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_empresas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_empresas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_empresas.Location = New System.Drawing.Point(106, 26)
        Me.cmd_gestor_empresas.Name = "cmd_gestor_empresas"
        Me.cmd_gestor_empresas.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_empresas.TabIndex = 1
        Me.cmd_gestor_empresas.Text = "Gestor empresas"
        Me.cmd_gestor_empresas.UseVisualStyleBackColor = False
        '
        'cmd_gestor_marcas
        '
        Me.cmd_gestor_marcas.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_gestor_marcas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_gestor_marcas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.cmd_gestor_marcas.Location = New System.Drawing.Point(106, 164)
        Me.cmd_gestor_marcas.Name = "cmd_gestor_marcas"
        Me.cmd_gestor_marcas.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_marcas.TabIndex = 2
        Me.cmd_gestor_marcas.Text = "Gestor marcas"
        Me.cmd_gestor_marcas.UseVisualStyleBackColor = False
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(251, 403)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.LogoConforma_Mesc_e1484836503615
        Me.PictureBox1.Location = New System.Drawing.Point(94, 325)
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
        Me.cmd_gestor_paises.Location = New System.Drawing.Point(106, 237)
        Me.cmd_gestor_paises.Name = "cmd_gestor_paises"
        Me.cmd_gestor_paises.Size = New System.Drawing.Size(171, 58)
        Me.cmd_gestor_paises.TabIndex = 2
        Me.cmd_gestor_paises.Text = "Gestor paises"
        Me.cmd_gestor_paises.UseVisualStyleBackColor = False
        '
        'Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(384, 476)
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
End Class
