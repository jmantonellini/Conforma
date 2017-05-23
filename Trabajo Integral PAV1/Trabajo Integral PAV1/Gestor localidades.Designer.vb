<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Gestor_localidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Gestor_localidades))
        Me.tabla_localidades = New System.Windows.Forms.DataGridView()
        Me.cmb_pais = New System.Windows.Forms.ComboBox()
        Me.lbl_gestor_localidades = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.cmd_eliminar = New System.Windows.Forms.Button()
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.lbl_modelos = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_provincia = New System.Windows.Forms.ComboBox()
        CType(Me.tabla_localidades, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tabla_localidades
        '
        Me.tabla_localidades.AllowUserToAddRows = False
        Me.tabla_localidades.AllowUserToDeleteRows = False
        Me.tabla_localidades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.tabla_localidades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_localidades.Location = New System.Drawing.Point(45, 141)
        Me.tabla_localidades.Name = "tabla_localidades"
        Me.tabla_localidades.ReadOnly = True
        Me.tabla_localidades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.tabla_localidades.Size = New System.Drawing.Size(538, 150)
        Me.tabla_localidades.TabIndex = 49
        '
        'cmb_pais
        '
        Me.cmb_pais.FormattingEnabled = True
        Me.cmb_pais.Location = New System.Drawing.Point(98, 80)
        Me.cmb_pais.Name = "cmb_pais"
        Me.cmb_pais.Size = New System.Drawing.Size(176, 21)
        Me.cmb_pais.TabIndex = 47
        '
        'lbl_gestor_localidades
        '
        Me.lbl_gestor_localidades.AutoSize = True
        Me.lbl_gestor_localidades.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_gestor_localidades.Location = New System.Drawing.Point(184, 18)
        Me.lbl_gestor_localidades.Name = "lbl_gestor_localidades"
        Me.lbl_gestor_localidades.Size = New System.Drawing.Size(260, 25)
        Me.lbl_gestor_localidades.TabIndex = 46
        Me.lbl_gestor_localidades.Text = "Gestor de Localidades"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.exit_icon
        Me.cmd_salir.Location = New System.Drawing.Point(499, 347)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(84, 80)
        Me.cmd_salir.TabIndex = 54
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'cmd_eliminar
        '
        Me.cmd_eliminar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_eliminar.Enabled = False
        Me.cmd_eliminar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._61848_deltton
        Me.cmd_eliminar.Location = New System.Drawing.Point(236, 347)
        Me.cmd_eliminar.Name = "cmd_eliminar"
        Me.cmd_eliminar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_eliminar.TabIndex = 53
        Me.cmd_eliminar.UseVisualStyleBackColor = False
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._84380_edit_button545
        Me.cmd_modificar.Location = New System.Drawing.Point(141, 347)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar.TabIndex = 51
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(45, 347)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 50
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'lbl_modelos
        '
        Me.lbl_modelos.AutoSize = True
        Me.lbl_modelos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_modelos.Location = New System.Drawing.Point(311, 78)
        Me.lbl_modelos.Name = "lbl_modelos"
        Me.lbl_modelos.Size = New System.Drawing.Size(76, 20)
        Me.lbl_modelos.TabIndex = 55
        Me.lbl_modelos.Text = "Provincia:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 20)
        Me.Label1.TabIndex = 56
        Me.Label1.Text = "Pais:"
        '
        'cmb_provincia
        '
        Me.cmb_provincia.FormattingEnabled = True
        Me.cmb_provincia.Location = New System.Drawing.Point(393, 80)
        Me.cmb_provincia.Name = "cmb_provincia"
        Me.cmb_provincia.Size = New System.Drawing.Size(176, 21)
        Me.cmb_provincia.TabIndex = 47
        '
        'Gestor_localidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 444)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_modelos)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_eliminar)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.tabla_localidades)
        Me.Controls.Add(Me.cmb_provincia)
        Me.Controls.Add(Me.cmb_pais)
        Me.Controls.Add(Me.lbl_gestor_localidades)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Gestor_localidades"
        Me.Text = "Gestor_localidades"
        CType(Me.tabla_localidades, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents cmd_eliminar As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents tabla_localidades As System.Windows.Forms.DataGridView
    Friend WithEvents cmb_pais As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_gestor_localidades As System.Windows.Forms.Label
    Friend WithEvents lbl_modelos As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_provincia As System.Windows.Forms.ComboBox
End Class
