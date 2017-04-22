<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_empresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(gestor_empresas))
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_telefono_fijo = New System.Windows.Forms.TextBox()
        Me.lbl_telefono_fijo = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tabla_empresas = New System.Windows.Forms.DataGridView()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.lbl_hora = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmd_modificar = New System.Windows.Forms.Button()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cuit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.razon_social = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.tabla_empresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(200, 244)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(232, 20)
        Me.txt_email.TabIndex = 33
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(130, 246)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(57, 20)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "E-mail:"
        '
        'txt_telefono_fijo
        '
        Me.txt_telefono_fijo.Location = New System.Drawing.Point(200, 206)
        Me.txt_telefono_fijo.Name = "txt_telefono_fijo"
        Me.txt_telefono_fijo.Size = New System.Drawing.Size(232, 20)
        Me.txt_telefono_fijo.TabIndex = 31
        '
        'lbl_telefono_fijo
        '
        Me.lbl_telefono_fijo.AutoSize = True
        Me.lbl_telefono_fijo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_telefono_fijo.Location = New System.Drawing.Point(83, 208)
        Me.lbl_telefono_fijo.Name = "lbl_telefono_fijo"
        Me.lbl_telefono_fijo.Size = New System.Drawing.Size(104, 20)
        Me.lbl_telefono_fijo.TabIndex = 30
        Me.lbl_telefono_fijo.Text = "Teléfono Fijo:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(113, 243)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(59, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(59, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(128, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "*"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(100, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "*"
        '
        'tabla_empresas
        '
        Me.tabla_empresas.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.tabla_empresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.tabla_empresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cuit, Me.nombre, Me.razon_social, Me.telefono, Me.email})
        Me.tabla_empresas.Location = New System.Drawing.Point(23, 309)
        Me.tabla_empresas.Name = "tabla_empresas"
        Me.tabla_empresas.Size = New System.Drawing.Size(468, 182)
        Me.tabla_empresas.TabIndex = 18
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(200, 167)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(232, 20)
        Me.txt_razon_social.TabIndex = 17
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(200, 131)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(232, 20)
        Me.txt_cuit.TabIndex = 16
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(200, 96)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(232, 20)
        Me.txt_nombre.TabIndex = 15
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_nombre.Location = New System.Drawing.Point(118, 98)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(69, 20)
        Me.lbl_nombre.TabIndex = 14
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_razon_social.Location = New System.Drawing.Point(80, 169)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(107, 20)
        Me.lbl_razon_social.TabIndex = 13
        Me.lbl_razon_social.Text = "Razón Social:"
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cuit.Location = New System.Drawing.Point(146, 133)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(41, 20)
        Me.lbl_cuit.TabIndex = 12
        Me.lbl_cuit.Text = "Cuit:"
        '
        'lbl_hora
        '
        Me.lbl_hora.Location = New System.Drawing.Point(367, 9)
        Me.lbl_hora.Name = "lbl_hora"
        Me.lbl_hora.Size = New System.Drawing.Size(124, 14)
        Me.lbl_hora.TabIndex = 35
        Me.lbl_hora.Text = "Label22"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        '
        'cmd_modificar
        '
        Me.cmd_modificar.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_modificar.Enabled = False
        Me.cmd_modificar.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources.f02a629827a6_4542
        Me.cmd_modificar.Location = New System.Drawing.Point(267, 500)
        Me.cmd_modificar.Name = "cmd_modificar"
        Me.cmd_modificar.Size = New System.Drawing.Size(80, 80)
        Me.cmd_modificar.TabIndex = 37
        Me.cmd_modificar.UseVisualStyleBackColor = False
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.BackColor = System.Drawing.Color.Gainsboro
        Me.cmd_nuevo.Image = Global.Trabajo_Integral_PAV1.My.Resources.Resources._554545
        Me.cmd_nuevo.Location = New System.Drawing.Point(173, 500)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(80, 80)
        Me.cmd_nuevo.TabIndex = 36
        Me.cmd_nuevo.UseVisualStyleBackColor = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(336, 269)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(17, 24)
        Me.Label20.TabIndex = 39
        Me.Label20.Text = "*"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(354, 275)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(137, 20)
        Me.Label21.TabIndex = 38
        Me.Label21.Text = "Datos obligatorios"
        '
        'cmd_salir
        '
        Me.cmd_salir.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.cmd_salir.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmd_salir.Location = New System.Drawing.Point(407, 511)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(84, 55)
        Me.cmd_salir.TabIndex = 40
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Lucida Sans Unicode", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(142, 36)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(236, 25)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "Gestor de Empresas"
        '
        'cuit
        '
        Me.cuit.HeaderText = "Cuit"
        Me.cuit.Name = "cuit"
        Me.cuit.Visible = False
        '
        'nombre
        '
        Me.nombre.HeaderText = "Nombre"
        Me.nombre.Name = "nombre"
        Me.nombre.Width = 105
        '
        'razon_social
        '
        Me.razon_social.HeaderText = "Razón Social"
        Me.razon_social.Name = "razon_social"
        Me.razon_social.Width = 105
        '
        'telefono
        '
        Me.telefono.HeaderText = "Teléfono"
        Me.telefono.Name = "telefono"
        Me.telefono.Width = 105
        '
        'email
        '
        Me.email.HeaderText = "Email"
        Me.email.Name = "email"
        Me.email.Width = 110
        '
        'gestor_empresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(520, 588)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.cmd_modificar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.lbl_hora)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_telefono_fijo)
        Me.Controls.Add(Me.lbl_telefono_fijo)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.tabla_empresas)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Controls.Add(Me.lbl_cuit)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "gestor_empresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gestor empresas"
        CType(Me.tabla_empresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_email As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_fijo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_telefono_fijo As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tabla_empresas As System.Windows.Forms.DataGridView
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_hora As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents cmd_modificar As System.Windows.Forms.Button
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents cuit As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents razon_social As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents email As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
