Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum
    Dim empresa1 As Data.DataTable = New DataTable
    Dim documento As Data.DataTable = New DataTable
    Dim cliente As Data.DataTable = New DataTable
    Dim domicilio As DataTable = New DataTable
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
        limpiar_campos()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        limpiar_campos()
        habilitar_campos()
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
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_domicilios.Controls
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
        For Each obj As Windows.Forms.Control In Me.tab_contacto.Controls
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
    End Sub


    Private Sub habilitar_campos()
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls
            If obj.Name <> "txt_cuit" Then
                obj.Enabled = True
            End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_domicilios.Controls
            obj.Enabled = True
        Next
        For Each obj As Windows.Forms.Control In Me.tab_contacto.Controls
            obj.Enabled = True
        Next

    End Sub


    Private Sub tabla_clientes_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_clientes.CellClick
        cargar_cliente()
        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True

    End Sub

    Private Sub cargar_cliente()

        cliente = c.buscar_datos_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)
        domicilio = c.buscar_domicilio_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)
        empresa1 = c.buscar_empresa_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)
        documento = c.buscar_documento_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)

        txt_nombre.Text = cliente.Rows(0).Item(3).ToString
        txt_apellido.Text = cliente.Rows(0).Item(4).ToString
        txt_documento.Text = cliente.Rows(0).Item(2).ToString
        txt_cuit.Text = cliente.Rows(0).Item(8).ToString
        txt_celular.Text = cliente.Rows(0).Item(6).ToString
        txt_fijo.Text = cliente.Rows(0).Item(7).ToString
        txt_mail.Text = cliente.Rows(0).Item(5).ToString
        cmb_empresa.Text = empresa1.Rows(0).Item(1).ToString
        cmb_tipo_documento.Text = documento.Rows(0).Item(1).ToString
        txt_calle.Text = domicilio.Rows(0).Item(0).ToString
        txt_altura_calle.Text = domicilio.Rows(0).Item(1).ToString
        cmb_ciudad.Text = domicilio.Rows(0).Item(2).ToString
        cmb_pais.Text = domicilio.Rows(0).Item(3).ToString
        cmb_provincia.Text = domicilio.Rows(0).Item(4).ToString



    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If validar_datos() = respuesta_validacion._ok Then
            If accion = tipo_grabacion.insertar Then
                If validar_cliente() = respuesta_validacion._ok Then
                    Dim id_tipodoc As Int64 = CLng(Me.cmb_tipo_documento.SelectedValue)
                    Dim documento As Int64 = CLng(Me.txt_documento.Text)
                    Dim fijo As Nullable(Of Integer)
                    Dim celular As Nullable(Of Integer)
                    Dim cuit As Nullable(Of Integer)
                    If txt_fijo.Text = "" Then
                        fijo = Nothing
                    Else : fijo = CLng(txt_fijo.Text)
                    End If
                    If txt_celular.Text = "" Then
                        celular = Nothing
                    Else : celular = CLng(txt_celular.Text)
                    End If
                    If txt_cuit.Text = "" Then
                        cuit = Nothing
                    Else : cuit = CLng(txt_cuit.Text)
                    End If
                    c.insertar_cliente(Me.txt_nombre.Text, Me.txt_apellido.Text, id_tipodoc, documento, fijo, celular, Me.txt_mail.Text, cuit)
                    MsgBox("Se guardó correctamente")
                End If
            End If
        End If
    End Sub

    Private Function validar_datos()
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls()
            If obj.GetType().Name = "TextBox" And obj.GetType().Name = "MaskedTextBox" And obj.Name <> "txt_cuit" Then
                If obj.Text = "" Then
                    MsgBox("El campo " + obj.Name + " está vacío", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If
            If obj.GetType().Name = "ComboBox" And obj.Name <> "cmb_empresa" Then
                Dim o As ComboBox = obj
                If o.SelectedIndex = -1 Then
                    MsgBox("El campo " + obj.Name + " está sin selección", MsgBoxStyle.OkOnly, "Error")
                    obj.Focus()
                    Return respuesta_validacion._error
                End If
            End If
        Next
        If txt_fijo.Text = "" And txt_celular.Text = "" And txt_mail.Text = "" Then
            control_tab.SelectedTab = tab_contacto
            txt_fijo.Focus()
            MsgBox("Debe cargar al menos un dato de contacto", MsgBoxStyle.OkOnly, "Faltan datos")
            
            Return respuesta_validacion._error
        End If
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

    Private Sub cmd_anterior2_Click(sender As Object, e As EventArgs) Handles cmd_anterior2.Click
        control_tab.SelectedTab = tab_contacto
    End Sub

    Private Sub cmb_empresa_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_empresa.SelectedValueChanged
        If (cmb_empresa.SelectedIndex <> -1) Then
            Me.txt_cuit.Text = Me.cmb_empresa.SelectedValue.ToString
        End If
    End Sub

    Private Sub cmb_pais_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_pais.SelectedValueChanged
        cmb_provincia.SelectedIndex = -1
        cmb_ciudad.SelectedIndex = -1
        If (cmb_pais.Items.Count <> 0) Then
            c.cargar_combo_flitrado_provincia(cmb_provincia, "PROVINCIAS", "ID_PROVINCIA", "NOMBRE", cmb_pais.Text, "PAISES")
        End If
    End Sub

    Private Sub cmb_provincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedValueChanged
        cmb_ciudad.SelectedIndex = -1
        If (cmb_provincia.Items.Count <> 0) Then
            c.cargar_combo_flitrado_ciudad(cmb_ciudad, "CIUDADES", "ID_CIUDAD", "NOMBRE", cmb_provincia.Text, "PROVINCIAS")
        End If
    End Sub


End Class