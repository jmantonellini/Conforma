Public Class gestor_empresas

    Enum operacion
        guardar
        sin_modificar
    End Enum

    Enum tipo_operacion
        nuevo
        modificar
    End Enum



    Dim c As Conexion = New Conexion
    Dim empresa As DataTable = New DataTable
    Dim accion As operacion = operacion.sin_modificar
    Dim tipo_accion As tipo_operacion

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub


    Private Sub gestor_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As Data.DataTable = New DataTable
        tablaEmpresas.DataSource = c.cargar_grilla("empresas")
        tt_guardar.SetToolTip(cmd_guardar, "Guardar")
        tt_nuevo.SetToolTip(cmd_nuevo, "Nuevo")
        tt_modificar.SetToolTip(cmd_modificar, "Modificar")
    End Sub

    Private Sub nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
        Next

        Me.habilitar_campos()
        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
        accion = operacion.guardar
        tipo_accion = tipo_operacion.nuevo
        Me.cmd_modificar.Enabled = False
        Me.cmd_nuevo.Enabled = False

    End Sub

    Private Sub tablaEmpresas_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tablaEmpresas.CellClick
        empresa.Clear()

        empresa = c.buscar_empresa(Me.tablaEmpresas.CurrentRow.Cells(1).Value)

        txt_cuit.Text = empresa.Rows(0).Item(0).ToString
        txt_nombre.Text = empresa.Rows(0).Item(1).ToString
        txt_razon_social.Text = empresa.Rows(0).Item(2).ToString
        txt_telefono_fijo.Text = empresa.Rows(0).Item(3).ToString
        txt_email.Text = empresa.Rows(0).Item(4).ToString
        cmd_eliminar.Enabled = True

        cmd_modificar.Enabled = True
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click

        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
        Me.cmd_nuevo.Enabled = False
        Me.habilitar_campos()
        accion = operacion.guardar
        tipo_accion = tipo_operacion.modificar


    End Sub

    Private Sub gestor_clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        If (accion = operacion.guardar) Then
            If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If

    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        
        Dim b As Boolean = False
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.Text = "" And obj.GetType.Name = "TextBox" Then
                b = True
                obj.BackColor = Color.PaleVioletRed

            End If
        Next


        If b Then
            MsgBox("Debes completar todos los campos para aceptar", MsgBoxStyle.OkOnly, "Advertencia")
        Else
            If (tipo_accion = tipo_operacion.modificar) Then
                c.modificar_empresa(Me.txt_cuit.Text, Me.txt_nombre.Text, Me.txt_razon_social.Text, Me.txt_email.Text, Me.txt_telefono_fijo.Text)
            Else
                c.insertar_empresa(Me.txt_cuit.Text, Me.txt_nombre.Text, Me.txt_razon_social.Text, Me.txt_email.Text, Me.txt_telefono_fijo.Text)
            End If

            tablaEmpresas.DataSource = c.cargar_grilla("empresas")
            cmd_nuevo.Enabled = True
            cmd_modificar.Enabled = False
            cmd_guardar.Enabled = False
            Me.deshabilitar_campos()
            accion = operacion.sin_modificar
            For Each obj As Windows.Forms.Control In Me.Controls
                If obj.Text = "" And obj.GetType.Name = "TextBox" Then
                    b = True
                    obj.BackColor = Color.White
                End If
            Next
            Me.deshabilitar_campos()

        End If




    End Sub

    Private Sub deshabilitar_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Enabled = False
            End If
            If obj.GetType().Name = "ComboBox" Then
                obj.Enabled = False
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Enabled = False
            End If
        Next
    End Sub

    Private Sub habilitar_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Enabled = True
            End If
        Next
    End Sub

    Private Sub blanquear_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim ccmb As ComboBox = obj
                ccmb.SelectedIndex = -1
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
        Next
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar la empresa seleccionada? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then
            c.eliminar_empresa(tablaEmpresas.CurrentRow.Cells(1).Value)
            tablaEmpresas.DataSource = c.cargar_grilla("empresas")
            Me.blanquear_campos()
        End If
    End Sub
End Class