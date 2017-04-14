<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_tipo_producto_y_categorias
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
        Me.lbl_area = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.cmd_nueva_area = New System.Windows.Forms.Button()
        Me.cmd_modificar_area = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lbl_area
        '
        Me.lbl_area.AutoSize = True
        Me.lbl_area.Location = New System.Drawing.Point(77, 49)
        Me.lbl_area.Name = "lbl_area"
        Me.lbl_area.Size = New System.Drawing.Size(32, 13)
        Me.lbl_area.TabIndex = 0
        Me.lbl_area.Text = "Área:"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(115, 46)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 1
        '
        'cmd_nueva_area
        '
        Me.cmd_nueva_area.Location = New System.Drawing.Point(277, 44)
        Me.cmd_nueva_area.Name = "cmd_nueva_area"
        Me.cmd_nueva_area.Size = New System.Drawing.Size(75, 23)
        Me.cmd_nueva_area.TabIndex = 2
        Me.cmd_nueva_area.Text = "Nuevo"
        Me.cmd_nueva_area.UseVisualStyleBackColor = True
        '
        'cmd_modificar_area
        '
        Me.cmd_modificar_area.Location = New System.Drawing.Point(371, 44)
        Me.cmd_modificar_area.Name = "cmd_modificar_area"
        Me.cmd_modificar_area.Size = New System.Drawing.Size(75, 23)
        Me.cmd_modificar_area.TabIndex = 2
        Me.cmd_modificar_area.Text = "Modificar"
        Me.cmd_modificar_area.UseVisualStyleBackColor = True
        '
        'gestor_tipo_producto_y_categorias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(523, 411)
        Me.Controls.Add(Me.cmd_modificar_area)
        Me.Controls.Add(Me.cmd_nueva_area)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.lbl_area)
        Me.Name = "gestor_tipo_producto_y_categorias"
        Me.Text = "Gestor de tipo de producto y categorías"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_area As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_nueva_area As System.Windows.Forms.Button
    Friend WithEvents cmd_modificar_area As System.Windows.Forms.Button
End Class
