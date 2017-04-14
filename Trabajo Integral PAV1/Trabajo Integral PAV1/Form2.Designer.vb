<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestor_clientes
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
        Me.control_tab = New System.Windows.Forms.TabControl()
        Me.tab_datos_personales = New System.Windows.Forms.TabPage()
        Me.tab_contacto = New System.Windows.Forms.TabPage()
        Me.tab_domicilios = New System.Windows.Forms.TabPage()
        Me.control_tab.SuspendLayout()
        Me.SuspendLayout()
        '
        'control_tab
        '
        Me.control_tab.Controls.Add(Me.tab_datos_personales)
        Me.control_tab.Controls.Add(Me.tab_contacto)
        Me.control_tab.Controls.Add(Me.tab_domicilios)
        Me.control_tab.Location = New System.Drawing.Point(1, 12)
        Me.control_tab.Name = "control_tab"
        Me.control_tab.SelectedIndex = 0
        Me.control_tab.Size = New System.Drawing.Size(398, 453)
        Me.control_tab.TabIndex = 0
        '
        'tab_datos_personales
        '
        Me.tab_datos_personales.Location = New System.Drawing.Point(4, 22)
        Me.tab_datos_personales.Name = "tab_datos_personales"
        Me.tab_datos_personales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_datos_personales.Size = New System.Drawing.Size(390, 427)
        Me.tab_datos_personales.TabIndex = 0
        Me.tab_datos_personales.Text = "Datos Personales"
        Me.tab_datos_personales.UseVisualStyleBackColor = True
        '
        'tab_contacto
        '
        Me.tab_contacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_contacto.Name = "tab_contacto"
        Me.tab_contacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_contacto.Size = New System.Drawing.Size(390, 427)
        Me.tab_contacto.TabIndex = 1
        Me.tab_contacto.Text = "Contacto"
        Me.tab_contacto.UseVisualStyleBackColor = True
        '
        'tab_domicilios
        '
        Me.tab_domicilios.Location = New System.Drawing.Point(4, 22)
        Me.tab_domicilios.Name = "tab_domicilios"
        Me.tab_domicilios.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_domicilios.Size = New System.Drawing.Size(390, 427)
        Me.tab_domicilios.TabIndex = 2
        Me.tab_domicilios.Text = "Domicilios"
        Me.tab_domicilios.UseVisualStyleBackColor = True
        '
        'gestor_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(720, 517)
        Me.Controls.Add(Me.control_tab)
        Me.Name = "gestor_clientes"
        Me.Text = "Clientes"
        Me.control_tab.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents control_tab As System.Windows.Forms.TabControl
    Friend WithEvents tab_datos_personales As System.Windows.Forms.TabPage
    Friend WithEvents tab_contacto As System.Windows.Forms.TabPage
    Friend WithEvents tab_domicilios As System.Windows.Forms.TabPage
End Class
