<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formulario_gestor_empresa
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
        Me.lbl_cuit = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_razon_social = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_cuit = New System.Windows.Forms.TextBox()
        Me.txt_razon_social = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.cmd_nuevo = New System.Windows.Forms.Button()
        Me.cmd_guardar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmd_salir = New System.Windows.Forms.Button()
        Me.lbl_datos_empresa = New System.Windows.Forms.Label()
        Me.lbl_telefono_fijo = New System.Windows.Forms.Label()
        Me.txt_telefono_fijo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_email = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_cuit
        '
        Me.lbl_cuit.AutoSize = True
        Me.lbl_cuit.Location = New System.Drawing.Point(94, 70)
        Me.lbl_cuit.Name = "lbl_cuit"
        Me.lbl_cuit.Size = New System.Drawing.Size(28, 13)
        Me.lbl_cuit.TabIndex = 0
        Me.lbl_cuit.Text = "Cuit:"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(75, 35)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(47, 13)
        Me.lbl_nombre.TabIndex = 1
        Me.lbl_nombre.Text = "Nombre:"
        '
        'lbl_razon_social
        '
        Me.lbl_razon_social.AutoSize = True
        Me.lbl_razon_social.Location = New System.Drawing.Point(49, 106)
        Me.lbl_razon_social.Name = "lbl_razon_social"
        Me.lbl_razon_social.Size = New System.Drawing.Size(73, 13)
        Me.lbl_razon_social.TabIndex = 0
        Me.lbl_razon_social.Text = "Razón Social:"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(145, 32)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(232, 20)
        Me.txt_nombre.TabIndex = 2
        '
        'txt_cuit
        '
        Me.txt_cuit.Location = New System.Drawing.Point(145, 67)
        Me.txt_cuit.Name = "txt_cuit"
        Me.txt_cuit.Size = New System.Drawing.Size(232, 20)
        Me.txt_cuit.TabIndex = 2
        '
        'txt_razon_social
        '
        Me.txt_razon_social.Location = New System.Drawing.Point(145, 103)
        Me.txt_razon_social.Name = "txt_razon_social"
        Me.txt_razon_social.Size = New System.Drawing.Size(232, 20)
        Me.txt_razon_social.TabIndex = 2
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(33, 241)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(429, 150)
        Me.DataGridView1.TabIndex = 3
        '
        'cmd_nuevo
        '
        Me.cmd_nuevo.Location = New System.Drawing.Point(33, 397)
        Me.cmd_nuevo.Name = "cmd_nuevo"
        Me.cmd_nuevo.Size = New System.Drawing.Size(55, 55)
        Me.cmd_nuevo.TabIndex = 4
        Me.cmd_nuevo.Text = "Nuevo"
        Me.cmd_nuevo.UseVisualStyleBackColor = True
        '
        'cmd_guardar
        '
        Me.cmd_guardar.Location = New System.Drawing.Point(109, 397)
        Me.cmd_guardar.Name = "cmd_guardar"
        Me.cmd_guardar.Size = New System.Drawing.Size(55, 55)
        Me.cmd_guardar.TabIndex = 4
        Me.cmd_guardar.Text = "Guardar"
        Me.cmd_guardar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(374, 214)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Datos obligatorios"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(383, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 24)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "*"
        '
        'cmd_salir
        '
        Me.cmd_salir.Location = New System.Drawing.Point(407, 397)
        Me.cmd_salir.Name = "cmd_salir"
        Me.cmd_salir.Size = New System.Drawing.Size(55, 55)
        Me.cmd_salir.TabIndex = 4
        Me.cmd_salir.Text = "Salir"
        Me.cmd_salir.UseVisualStyleBackColor = True
        '
        'lbl_datos_empresa
        '
        Me.lbl_datos_empresa.AutoSize = True
        Me.lbl_datos_empresa.Location = New System.Drawing.Point(11, 9)
        Me.lbl_datos_empresa.Name = "lbl_datos_empresa"
        Me.lbl_datos_empresa.Size = New System.Drawing.Size(108, 13)
        Me.lbl_datos_empresa.TabIndex = 7
        Me.lbl_datos_empresa.Text = "Datos de la Empresa:"
        '
        'lbl_telefono_fijo
        '
        Me.lbl_telefono_fijo.AutoSize = True
        Me.lbl_telefono_fijo.Location = New System.Drawing.Point(51, 147)
        Me.lbl_telefono_fijo.Name = "lbl_telefono_fijo"
        Me.lbl_telefono_fijo.Size = New System.Drawing.Size(68, 13)
        Me.lbl_telefono_fijo.TabIndex = 8
        Me.lbl_telefono_fijo.Text = "Teléfono Fijo"
        '
        'txt_telefono_fijo
        '
        Me.txt_telefono_fijo.Location = New System.Drawing.Point(145, 144)
        Me.txt_telefono_fijo.Name = "txt_telefono_fijo"
        Me.txt_telefono_fijo.Size = New System.Drawing.Size(232, 20)
        Me.txt_telefono_fijo.TabIndex = 9
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(383, 62)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(17, 24)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(383, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 24)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(383, 139)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 24)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "*"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(352, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 24)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(87, 185)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Email"
        '
        'txt_email
        '
        Me.txt_email.Location = New System.Drawing.Point(145, 182)
        Me.txt_email.Name = "txt_email"
        Me.txt_email.Size = New System.Drawing.Size(232, 20)
        Me.txt_email.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(383, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(17, 24)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "*"
        '
        'formulario_gestor_empresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 462)
        Me.Controls.Add(Me.txt_email)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txt_telefono_fijo)
        Me.Controls.Add(Me.lbl_telefono_fijo)
        Me.Controls.Add(Me.lbl_datos_empresa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmd_salir)
        Me.Controls.Add(Me.cmd_guardar)
        Me.Controls.Add(Me.cmd_nuevo)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txt_razon_social)
        Me.Controls.Add(Me.txt_cuit)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_razon_social)
        Me.Controls.Add(Me.lbl_cuit)
        Me.Name = "formulario_gestor_empresa"
        Me.Text = "Gestor Empresa"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_cuit As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_razon_social As System.Windows.Forms.Label

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lbl_razon_social.Click, lbl_cuit.Click

    End Sub
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_cuit As System.Windows.Forms.TextBox
    Friend WithEvents txt_razon_social As System.Windows.Forms.TextBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cmd_nuevo As System.Windows.Forms.Button
    Friend WithEvents cmd_guardar As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmd_salir As System.Windows.Forms.Button
    Friend WithEvents lbl_datos_empresa As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono_fijo As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_fijo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_email As System.Windows.Forms.TextBox

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Friend WithEvents Label8 As System.Windows.Forms.Label
End Class
