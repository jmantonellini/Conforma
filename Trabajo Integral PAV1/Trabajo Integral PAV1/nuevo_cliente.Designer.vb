<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevo_cliente
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.tab_datos_personales = New System.Windows.Forms.TabPage()
        Me.tab_contacto = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tab_datos_personales)
        Me.TabControl1.Controls.Add(Me.tab_contacto)
        Me.TabControl1.Location = New System.Drawing.Point(-3, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(668, 507)
        Me.TabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.TabControl1.TabIndex = 0
        '
        'tab_datos_personales
        '
        Me.tab_datos_personales.Location = New System.Drawing.Point(4, 22)
        Me.tab_datos_personales.Name = "tab_datos_personales"
        Me.tab_datos_personales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datos_personales.Size = New System.Drawing.Size(660, 481)
        Me.tab_datos_personales.TabIndex = 0
        Me.tab_datos_personales.Text = "Datos Personales"
        Me.tab_datos_personales.UseVisualStyleBackColor = True
        '
        'tab_contacto
        '
        Me.tab_contacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_contacto.Name = "tab_contacto"
        Me.tab_contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_contacto.Size = New System.Drawing.Size(660, 481)
        Me.tab_contacto.TabIndex = 1
        Me.tab_contacto.Text = "TabPage2"
        Me.tab_contacto.UseVisualStyleBackColor = True
        '
        'nuevo_cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(665, 509)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "nuevo_cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "nuevo_cliente"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents tab_datos_personales As System.Windows.Forms.TabPage
    Friend WithEvents tab_contacto As System.Windows.Forms.TabPage
End Class
