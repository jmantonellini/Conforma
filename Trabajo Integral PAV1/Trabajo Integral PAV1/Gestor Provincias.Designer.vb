<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestor_Provincias
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
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_pais = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tabla_provincias = New System.Windows.Forms.DataGridView()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_salir = New System.Windows.Forms.Button()
        CType(Me.tabla_provincias, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(203, 31)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(243, 25)
        Me.Label22.TabIndex = 37
        Me.Label22.Text = "Gestor de Provincias"
        '
        'cmb_pais
        '
        Me.cmb_pais.FormattingEnabled = True
        Me.cmb_pais.Location = New System.Drawing.Point(239, 93)
        Me.cmb_pais.Name = "cmb_pais"
        Me.cmb_pais.Size = New System.Drawing.Size(176, 21)
        Me.cmb_pais.TabIndex = 38
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(203, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(30, 13)
        Me.Label1.TabIndex = 39
        Me.Label1.Text = "Pais:"
        '
        'tabla_provincias
        '
        Me.tabla_provincias.AllowUserToAddRows = False
        Me.tabla_provincias.AllowUserToDeleteRows = False
        Me.tabla_provincias.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_provincias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_provincias.Location = New System.Drawing.Point(35, 154)
        Me.tabla_provincias.Name = "tabla_provincias"
        Me.tabla_provincias.ReadOnly = True
        Me.tabla_provincias.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_provincias.Size = New System.Drawing.Size(538, 170)
        Me.tabla_provincias.TabIndex = 40
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._61848_deltton
        Me.cmd_eliminar.Location = New System.Drawing.Point(323, 360)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_eliminar.TabIndex = 44
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'cmd_guardar
        '
        Me.cmd_guardar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_guardar.Enabled = False
        Me.cmd_guardar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.cmd_guardar.Location = New System.Drawing.Point(227, 360)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_guardar.TabIndex = 43
        Me.cmd_guardar.UseVisualStyleBackColor = False
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._84380_edit_button545
        Me.cmd_modificar.Location = New System.Drawing.Point(131, 360)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar.TabIndex = 42
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(35, 360)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 41
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.cmd_salir.Location = New System.Drawing.Point(489, 360)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(84, 80)
        Me.cmd_salir.TabIndex = 45
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Gestor_Provincias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(619, 472)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.tabla_provincias)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_pais)
        Me.Controls.Add(Me.Label22)
        Me.Name = "Gestor_Provincias"
        Me.Text = "Gestor Provincias"
        CType(Me.tabla_provincias, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cmb_pais As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tabla_provincias As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
End Class
