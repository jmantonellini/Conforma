Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Dim cliente As Data.DataTable = New DataTable
    Dim domicilios As DataTable = New DataTable
    Dim c As Conexion = New Conexion
    Dim accion As tipo_grabacion = tipo_grabacion.insertar

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")

    End Sub

    Private Sub gestor_clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub gestor_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cargar_grilla()
        cmb_empresa = c.cargar_combo(cmb_empresa, "EMPRESAS", "CUIT", "NOMBRE")
        cmb_pais = c.cargar_combo(cmb_pais, "PAISES", "ID_PAIS", "NOMBRE")
        cmb_provincia = c.cargar_combo(cmb_provincia, "PROVINCIAS", "ID_PROVINCIA", "NOMBRE")
        cmb_ciudad = c.cargar_combo(cmb_ciudad, "CIUDADES", "ID_CIUDAD", "NOMBRE")
        cmb_tipo_documento = c.cargar_combo(cmb_tipo_documento, "TIPOS_DOCUMENTOS", "ID_TIPO_DOCUMENTO", "NOMBRE")
        tabla_clientes.Rows(0).Selected = True

        domicilios = c.buscar_domicilios_cliente(tabla_clientes.Item(0, 1).Value, tabla_clientes.Item(0, 0).Value)
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        limpiar_campos()
        Me.accion = tipo_grabacion.insertar
        Me.cmd_modificar.Enabled = False
        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cargar_grilla()
        Me.tabla_clientes.Rows.Clear()
        Me.tabla_clientes.Columns.Clear()
        Dim tabla = c.cargar_grilla("clientes")
        tabla_clientes.DataSource = tabla

    End Sub
    Private Sub limpiar_campos()
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_domicilios.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_contacto.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
    End Sub

    Private Sub tabla_clientes_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_clientes.CellClick
        cargar_cliente()
        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True

    End Sub

    Private Sub cargar_cliente()

        cliente = c.buscar_datos_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)
        domicilios = c.buscar_domicilios_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)


        txt_nombre.Text = cliente.Rows(0).Item(3).ToString
        txt_apellido.Text = cliente.Rows(0).Item(4).ToString
        txt_documento.Text = cliente.Rows(0).Item(2).ToString
        txt_cuit.Text = cliente.Rows(0).Item(8).ToString
        txt_celular.Text = cliente.Rows(0).Item(6).ToString
        txt_fijo.Text = cliente.Rows(0).Item(7).ToString



    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If validar_datos() = respuesta_validacion._ok Then
            If accion = tipo_grabacion.insertar Then
                If validar_cliente() = respuesta_validacion._ok Then
                    Dim id_tipodoc As Int64 = CLng(Me.cmb_tipo_documento.SelectedValue)
                    c.insertar_cliente(Me.txt_nombre.Text, Me.txt_apellido.Text, id_tipodoc, Me.txt_documento.Text, Me.txt_fijo.Text, Me.txt_celular.Text, Me.txt_mail.Text, Me.txt_cuit.Text)
                    MsgBox("Se guardó correctamente")
                End If
            End If
        End If
    End Sub

    Private Function validar_datos()
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls()
            If obj.GetType().Name = "TextBox" And obj.GetType().Name = "MaskedTextBox" And obj.Name <> "txt_cuit" And obj.Name <> "txt_empresa" Then
                If obj.Text = "" Then
                    MsgBox("El campo " + obj.Name + " está vacío", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim o As ComboBox = obj
                If o.SelectedIndex = -1 Then
                    MsgBox("El campo " + obj.Name + " está sin selección", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If
        Next
        Return respuesta_validacion._ok
    End Function


    Private Function validar_cliente() As respuesta_validacion
        Dim tabla As New DataTable
        tabla = c.buscar_datos_cliente(Me.txt_nombre.Text, Me.txt_apellido.Text)

        If tabla.Rows.Count = 0 Then
            Return respuesta_validacion._ok
        Else
            Return respuesta_validacion._error
        End If
    End Function

    Private Sub cmd_siguiente_Click(sender As Object, e As EventArgs) Handles cmd_siguiente.Click

        control_tab.SelectedTab = tab_contacto
    End Sub

    Private Sub cmd_anterior_Click(sender As Object, e As EventArgs) Handles cmd_anterior.Click
        control_tab.SelectedTab = tab_datos_personales
    End Sub

    Private Sub cmd_siguiente2_Click(sender As Object, e As EventArgs) Handles cmd_siguiente2.Click
        control_tab.SelectedTab = tab_domicilios
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        control_tab.SelectedTab = tab_contacto
    End Sub

    Private Sub cmb_empresa_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_empresa.SelectionChangeCommitted
        Me.txt_cuit.Text = Me.cmb_empresa.SelectedValue.ToString
    End Sub
End Class