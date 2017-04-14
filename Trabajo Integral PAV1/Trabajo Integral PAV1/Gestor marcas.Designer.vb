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
        Me.lbl_nombre_marca = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.cmd_nueva_marca = New System.Windows.Forms.Button()
        Me.cmd_modificar_marca = New System.Windows.Forms.Button()
        Me.cmd_modificar_modelo = New System.Windows.Forms.Button()
        Me.cmd_nuevo_modelo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_nombre_marca
        '
        Me.lbl_nombre_marca.AutoSize = True
        Me.lbl_nombre_marca.Location = New System.Drawing.Point(10, 12)
        Me.lbl_nombre_marca.Name = "lbl_nombre_marca"
        Me.lbl_nombre_marca.Size = New System.Drawing.Size(45, 13)
        Me.lbl_nombre_marca.TabIndex = 0
        Me.lbl_nombre_marca.Text = "Marcas:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(113, 20)
        Me.TextBox1.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 74)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(262, 331)
        Me.DataGridView1.TabIndex = 2
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(0, 74)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(262, 331)
        Me.DataGridView2.TabIndex = 2
        '
        'cmd_nueva_marca
        '
        Me.cmd_nueva_marca.Location = New System.Drawing.Point(0, 421)
        Me.cmd_nueva_marca.Name = "cmd_nueva_marca"
        Me.cmd_nueva_marca.Size = New System.Drawing.Size(61, 55)
        Me.cmd_nueva_marca.TabIndex = 3
        Me.cmd_nueva_marca.Text = "Nuevo"
        Me.cmd_nueva_marca.UseVisualStyleBackColor = True
        '
        'cmd_modificar_marca
        '
        Me.cmd_modificar_marca.Location = New System.Drawing.Point(80, 421)
        Me.cmd_modificar_marca.Name = "cmd_modificar_marca"
        Me.cmd_modificar_marca.Size = New System.Drawing.Size(61, 55)
        Me.cmd_modificar_marca.TabIndex = 3
        Me.cmd_modificar_marca.Text = "Modificar"
        Me.cmd_modificar_marca.UseVisualStyleBackColor = True
        '
        'cmd_modificar_modelo
        '
        Me.cmd_modificar_modelo.Location = New System.Drawing.Point(81, 421)
        Me.cmd_modificar_modelo.Name = "cmd_modificar_modelo"
        Me.cmd_modificar_modelo.Size = New System.Drawing.Size(61, 55)
        Me.cmd_modificar_modelo.TabIndex = 3
        Me.cmd_modificar_modelo.Text = "Modificar"
        Me.cmd_modificar_modelo.UseVisualStyleBackColor = True
        '
        'cmd_nuevo_modelo
        '
        Me.cmd_nuevo_modelo.Location = New System.Drawing.Point(3, 421)
        Me.cmd_nuevo_modelo.Name = "cmd_nuevo_modelo"
        Me.cmd_nuevo_modelo.Size = New System.Drawing.Size(61, 55)
        Me.cmd_nuevo_modelo.TabIndex = 3
        Me.cmd_nuevo_modelo.Text = "Nuevo"
        Me.cmd_nuevo_modelo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.cmd_modificar_modelo)
        Me.Panel1.Controls.Add(Me.cmd_nuevo_modelo)
        Me.Panel1.Controls.Add(Me.DataGridView1)
        Me.Panel1.Location = New System.Drawing.Point(305, 41)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(262, 476)
        Me.Panel1.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(-3, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Datos de modelos:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(-3, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Datos de marcas:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.cmd_modificar_marca)
        Me.Panel2.Controls.Add(Me.lbl_nombre_marca)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.cmd_nueva_marca)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Location = New System.Drawing.Point(19, 41)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(262, 476)
        Me.Panel2.TabIndex = 5
        '
        'gestor_marcas_modelos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 527)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "gestor_marcas_modelos"
        Me.Text = "Gestor de marcas y modelos"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_nombre_marca As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nueva_marca As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_marca As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_modelo As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo_modelo As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
