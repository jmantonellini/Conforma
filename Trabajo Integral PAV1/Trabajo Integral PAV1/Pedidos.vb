Public Class gestor_pedidos
    Enum tipo_accion
        modificacion
        nuevo
        nulo
    End Enum

    Enum tipo_eliminacion
        detalle_en_BD
        detalle_no_en_BD
        pedido
    End Enum

    Dim eliminacion As tipo_eliminacion = tipo_eliminacion.pedido
    Dim conexion As New Conexion
    Dim accion As tipo_accion = tipo_accion.nulo
    Dim contador As Int16 = 0
    Dim ventana_hija As Boolean = False
    Dim data_table As New DataTable
    Dim listado_pedidos As Listado_pedidos

    Private Sub txt_observaciones_TextChanged(sender As Object, e As EventArgs) Handles txt_observaciones.Click, txt_observaciones.GotFocus
        txt_observaciones.Text = ""
        txt_observaciones.ForeColor = Color.Black
    End Sub


    Private Sub salirCruz(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (accion <> tipo_accion.nulo) Then
            If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        Else : e.Cancel = False
        End If
    End Sub

    Private Sub cmd_nuevo_cliente_Click(sender As Button, e As EventArgs) Handles cmd_nuevo_cliente.Click, cmd_nueva_marca.Click, cmd_nuevo_producto.Click
        Dim nuevo As Form = New Form
        Select Case sender.Name
            Case "cmd_nuevo_producto"
                nuevo = New gestor_tipo_producto_y_categorias
            Case "cmd_nueva_marca"
                nuevo = New gestor_marcas_modelos
            Case "cmd_nuevo_cliente"
                nuevo = New gestor_clientes
        End Select
        ventana_hija = True
        nuevo.Show()
        Me.ActivateMdiChild(nuevo)
    End Sub

    Private Sub actualizar_combo_clientes()
        conexion.cargar_combo(cmb_cliente, " CLIENTES ", "ID_CLIENTE", "NOMBRE")
    End Sub

    Private Sub gestor_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        
        tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
        deshabilitar_campos()

    End Sub

    Private Sub txt_perder_foco() Handles txt_observaciones.LostFocus
        If (txt_observaciones.Text = "") Then
            txt_observaciones.Text = "Observaciones.."
            txt_observaciones.ForeColor = Color.Gray
        End If
    End Sub

    Public Sub cargar_combos()
        conexion.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
        conexion.cargar_combo(cmb_categoria, "CATEGORIAS", "ID_CATEGORIA", "NOMBRE")
        conexion.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
        conexion.cargar_combo(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE")
        conexion.cargar_combo(cmb_modelo, "MODELOS", "ID_MODELO", "NOMBRE")
        conexion.cargar_combo(cmb_cliente, "CLIENTES", "ID_CLIENTE", "NRO_DOC")
    End Sub

    Private Sub habilitar_campos()
        For Each obj As Windows.Forms.Control In Me.panel_nuevo.Controls
            obj.Enabled = True
        Next

        For Each obj As Windows.Forms.Control In Me.panel_producto.Controls
            obj.Enabled = True
        Next

        For Each obj As Windows.Forms.Control In Me.panel_especificaciones.Controls
            obj.Enabled = True
        Next
    End Sub

    Private Sub deshabilitar_campos()

        For Each obj As Windows.Forms.Control In Me.panel_nuevo.Controls
            If (obj.GetType.Name <> "Label" And obj.GetType.Name <> "DataGridView") Then
                obj.Enabled = False
            End If
        Next

        For Each obj As Windows.Forms.Control In Me.panel_producto.Controls
            If (obj.GetType.Name <> "Label") Then
                obj.Enabled = False
            End If
        Next

        For Each obj As Windows.Forms.Control In Me.panel_especificaciones.Controls
            If (obj.GetType.Name <> "Label") Then
                obj.Enabled = False
            End If
        Next
    End Sub

    Private Sub cmd_nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.cargar_combos()
        Me.habilitar_campos()
        tabla_detalles.Columns.Clear()
        cmd_guardar.Enabled = True
        accion = tipo_accion.nuevo
        cmd_nuevo.Enabled = False
        Me.eliminacion = tipo_eliminacion.detalle_no_en_BD
    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub tabla_pedidos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_pedidos.CellClick
        Me.cmd_eliminar.Enabled = True
        Me.eliminacion = tipo_eliminacion.pedido
        Me.cmd_modificar.Enabled = True
    End Sub

    Private Sub tabla_pedidos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_pedidos.CellDoubleClick
        Me.cargar_combos_desde_pedido()
        TabControl1.SelectedTab = tab_nuevo
        cmd_modificar.Enabled = True
        fecha_entrega.Enabled = False
        Me.eliminacion = tipo_eliminacion.detalle_en_BD
    End Sub

    Private Sub cargar_combos_desde_pedido()
        Dim cadena_busqueda As String = " DETALLES_PEDIDOS DP JOIN PRODUCTOS P ON P.ID_PRODUCTO = DP.ID_PRODUCTO " _
                                       & " JOIN AREAS A ON A.ID_AREA = P.ID_AREA " _
                                       & " LEFT JOIN CATEGORIAS C ON C.ID_CATEGORIA = P.ID_CATEGORIA " _
                                       & " LEFT JOIN MODELOS M ON M.ID_MODELO = P.ID_MODELO " _
                                       & " LEFT JOIN TIPOS_PRODUCTOS TP ON TP.ID_TIPO_PRODUCTO = P.ID_TIPO_PRODUCTO "

        tabla_detalles.DataSource = conexion.leer_tabla_filtrada_generica(cadena_busqueda, _
                                                                          "NRO_PEDIDO", _
                                                                          tabla_pedidos.SelectedRows.Item(0).Cells(0).Value, _
                                                                          " DP.ID_DETALLE_PEDIDO as 'Detalle Nº' , " _
                                                                          & " A.NOMBRE AS 'Área' ," _
                                                                          & " TP.NOMBRE AS 'Tipo de Producto' ," _
                                                                          & " C.NOMBRE AS 'Categoría' ," _
                                                                          & " M.NOMBRE AS 'Modelo', " _
                                                                          & " DP.CANTIDAD AS 'Cantidad', " _
                                                                          & " P.OBSERVACIONES AS 'Observaciones' ")
        If (tabla_detalles.Rows.Count > 0) Then
            conexion.cargar_combo_generico_nombre(cmb_area, "AREAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(1).Value)
            If (IsDBNull(tabla_detalles.SelectedRows.Item(0).Cells(3).Value) = False) Then
                conexion.cargar_combo_generico_nombre(cmb_categoria, "CATEGORIAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(3).Value)
            End If
            conexion.cargar_combo_generico_nombre(cmb_tipo_producto, "TIPOS_PRODUCTOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(2).Value)
            If (IsDBNull(tabla_detalles.SelectedRows.Item(0).Cells(4).Value) = False) Then
                conexion.cargar_combo_generico_nombre(cmb_modelo, "MODELOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(4).Value)
                conexion.carga_combo_generico_dos_tablas(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE", "MODELOS", "ID_MARCA", cmb_modelo.Text)
            Else : cmb_modelo.SelectedIndex = -1
                cmb_marca.SelectedIndex = -1
            End If
            txt_cantidad.Text = tabla_detalles.Item(5, 0).Value
        End If
        Dim id_cliente As Integer = conexion.leer_tabla_filtrada_generica("PEDIDOS", "NRO_PEDIDO", tabla_pedidos.SelectedRows.Item(0).Cells(0).Value, "ID_CLIENTE").Rows(0).Item(0)
        conexion.cargar_combo_generico_filtrado(cmb_cliente, "CLIENTES", "ID_CLIENTE", "NRO_DOC", id_cliente)
        'conexion.carga_combo_generico_dos_tablas(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", "CATEGORIAS", "ID_TIPO_PRODUCTO", cmb_categoria.Text)
        fecha_entrega.CustomFormat = "DD/MM/YYYY"
        Me.fecha_entrega.Value = (CDate(tabla_pedidos.SelectedRows.Item(0).Cells(3).Value))
        data_table = tabla_detalles.DataSource
    End Sub

    Private Sub tabla_detalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_detalles.CellClick
        conexion.cargar_combo_generico_nombre(cmb_area, "AREAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(1).Value)
        conexion.cargar_combo_generico_nombre(cmb_tipo_producto, "TIPOS_PRODUCTOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(2).Value)

        If (IsDBNull(tabla_detalles.SelectedRows.Item(0).Cells(3).Value) = False) Then
            conexion.cargar_combo_generico_nombre(cmb_categoria, "CATEGORIAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(3).Value)
        End If
        If (IsDBNull(tabla_detalles.SelectedRows.Item(0).Cells(4).Value) = False) Then
            conexion.cargar_combo_generico_nombre(cmb_modelo, "MODELOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(4).Value)
            conexion.carga_combo_generico_dos_tablas(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE", "MODELOS", "ID_MARCA", cmb_modelo.Text)
        Else : cmb_marca.SelectedIndex = -1
            cmb_modelo.SelectedIndex = -1
        End If
        txt_cantidad.Text = tabla_detalles.SelectedRows.Item(0).Cells(5).Value
        cmd_eliminar.Enabled = True
        cmd_modificar.Enabled = True
        If (accion = tipo_accion.modificacion) Then
            Me.eliminacion = tipo_eliminacion.detalle_en_BD 'Setea la variable eliminacion para cuando se quiera eliminar un detalle
        End If
    End Sub

    Private Sub cmb_area_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_area.SelectedIndexChanged
        conexion.carga_combo_generico_dos_tablas(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", "AREAS", "ID_AREA", cmb_area.Text)
        conexion.carga_combo_generico_dos_tablas(cmb_categoria, "CATEGORIAS", "ID_CATEGORIA", "NOMBRE", "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", cmb_tipo_producto.Text)
        If (cmb_area.Text <> "Escape") Then
            cmb_marca.Enabled = False
            cmb_marca.SelectedIndex = -1
            cmb_modelo.Enabled = False
            cmb_modelo.SelectedIndex = -1
        End If

        If (cmb_area.Text = "Escape") Then
            cmb_marca.Enabled = True
            cmb_marca.SelectedIndex = -1
            cmb_modelo.Enabled = True
            cmb_modelo.SelectedIndex = -1
        End If
    End Sub

    Private Sub cmb_tipo_producto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_tipo_producto.SelectedIndexChanged
        conexion.carga_combo_generico_dos_tablas(cmb_categoria, "CATEGORIAS", "ID_CATEGORIA", "NOMBRE", "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", cmb_tipo_producto.Text)
    End Sub

    Private Sub cmb_marca_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_marca.SelectedIndexChanged
        conexion.carga_combo_generico_dos_tablas(cmb_modelo, "MODELOS", "ID_MODELO", "NOMBRE", "MARCAS", "ID_MARCA", cmb_marca.Text)
    End Sub


    Private Sub cmd_agregar_detalle_Click(sender As Object, e As EventArgs) Handles cmd_agregar_detalle.Click
        If (txt_observaciones.Text = "Observaciones...") Then
            txt_observaciones.Text = ""
        End If

        If (accion = tipo_accion.modificacion) Then
            Dim indice As Integer = tabla_detalles.SelectedRows.Item(0).Cells(0).Value
            data_table.Rows.Item(indice - 1).Item(1) = cmb_area.Text
            data_table.Rows.Item(indice - 1).Item(2) = cmb_tipo_producto.Text
            data_table.Rows.Item(indice - 1).Item(3) = cmb_categoria.Text
            data_table.Rows.Item(indice - 1).Item(4) = cmb_modelo.Text
            data_table.Rows.Item(indice - 1).Item(6) = txt_observaciones.Text
            data_table.Rows.Item(indice - 1).Item(5) = CInt(txt_cantidad.Text)
            tabla_detalles.DataSource = data_table
            MsgBox("Detalle modificado con éxito", MsgBoxStyle.Information, "Información")
            Me.deshabilitar_campos()
            cmd_guardar.Enabled = True

            Exit Sub
        End If

        If (data_table.Columns.Count = 0) Then
            data_table.Columns.Add("Numero", GetType(Int16))
            data_table.Columns.Add("Área", GetType(String))
            data_table.Columns.Add("Tipo de Producto", GetType(String))
            data_table.Columns.Add("Categoría", GetType(String))
            data_table.Columns.Add("Modelo", GetType(String))
            data_table.Columns.Add("Observaciones", GetType(String))
            data_table.Columns.Add("Cantidad", GetType(Int16))
        End If
        If (txt_cantidad.Text <> "" And txt_cantidad.Text <> "0") Then
            If ((cmb_area.Text = "Escape" And cmb_marca.Text <> "" And cmb_modelo.Text <> "") Or cmb_area.Text <> "Escape") Then
                data_table.Rows.Add(tabla_detalles.Rows.Count + 1, cmb_area.Text, cmb_tipo_producto.Text, cmb_categoria.Text, cmb_modelo.Text, txt_observaciones.Text, CInt(txt_cantidad.Text))
                tabla_detalles.DataSource = data_table
                cmb_cliente.Enabled = False
            Else : MsgBox("La marca o el modelo no puede ser nula si el producto es un escape")
            End If
        Else : MsgBox("La cantidad de productos no puede ser nula o cero")
        End If

    End Sub

   
    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar.Click
        If (txt_cantidad.Text <> "" Or txt_cantidad.Text <> "0") Then
            If ((cmb_area.Text = "Escape" And cmb_marca.Text <> "" And cmb_modelo.Text <> "") Or cmb_area.Text <> "Escape") Then
                If (accion = tipo_accion.modificacion) Then
                    If (conexion.modificar_detalles(CLng(cmb_cliente.Text), CDate(fecha_entrega.Value), data_table)) Then
                        tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
                        Me.deshabilitar_campos()
                        Me.tabla_detalles.Columns.Clear()
                        accion = tipo_accion.nulo
                        MessageBox.Show("El pedido se ha modificado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                ElseIf accion = tipo_accion.nuevo Then
                    If (fecha_entrega.Value.Date.CompareTo(Today) > 0) Then
                        If (conexion.transaccion_pedidos(CLng(cmb_cliente.Text), CDate(fecha_entrega.Value), data_table)) Then
                            tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
                            Me.deshabilitar_campos()
                            Me.tabla_detalles.Columns.Clear()
                            accion = tipo_accion.nulo
                            MessageBox.Show("El pedido se ha agregado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        End If
                    Else : MessageBox.Show("La fecha de entrega debe ser posterior a la fecha de hoy", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        Exit Sub
                    End If
                End If
            Else : MsgBox("La marca o el modelo no puede ser nula si el producto es un escape")
                Exit Sub
            End If
        Else : MsgBox("La cantidad de productos no puede ser nula o cero")
            Exit Sub
        End If

        Me.cmd_nuevo.Enabled = True
        Me.cmd_guardar.Enabled = False


    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        If Me.TabControl1.SelectedTab.Name = "tab_nuevo" Then
            Dim indice As Integer = tabla_detalles.SelectedRows.Item(0).Cells(0).Value
            Dim area As String = cmb_area.Text
            Dim categoria As String = cmb_categoria.Text
            Dim tipo_prod As String = cmb_tipo_producto.Text
            Dim marca As String = cmb_marca.Text
            Dim modelo As String = cmb_modelo.Text
            Dim cantidad As Integer = CInt(txt_cantidad.Text)
            Dim obser As String = txt_observaciones.Text
            Dim cliente As String = cmb_cliente.Text
            accion = tipo_accion.modificacion
            tabla_detalles.Enabled = False 'Para que no se pueda elegir otro detalle si no se guardaron los cambios del anterior'
            Me.cargar_combos()
            cmb_area.Text = area
            cmb_tipo_producto.Text = tipo_prod
            cmb_categoria.Text = categoria
            cmb_marca.Text = marca
            cmb_modelo.Text = modelo
            txt_cantidad.Text = cantidad
            txt_observaciones.Text = obser
            cmb_cliente.Text = cliente
            'Me.cargar_combos_desde_pedido()
            Me.habilitar_campos()
            cmb_cliente.Enabled = False
            tabla_detalles.Rows(indice - 1).Selected = True

        Else
            If Me.tabla_pedidos.CurrentRow.Cells(5).Value = True Then 'Si ya está habilitado muestra el mensaje correspondiente
                If MessageBox.Show("Seguro que desea habilitar el pedido seleccionado", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    If Me.conexion.habilitar_pedido(Me.tabla_pedidos.CurrentRow.Cells(0).Value) = True Then
                        MessageBox.Show("Pedido habilitado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
                    Else
                        MessageBox.Show("El pedido no se puedo habilitar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("El pedido ya está habilitado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)

            End If

        End If

    End Sub

    ''' <summary>
    ''' Subrutina que se ejecuta en el momento de hacer click en el botón eliminar, dependiendo del contexto puede cancelar pedido o eliminar detalles de pedido
    ''' </summary>
    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        If Me.eliminacion = tipo_eliminacion.pedido Then
            If Me.tabla_pedidos.CurrentRow.Cells(5).Value = False Then
                If MessageBox.Show("¿Seguro que desea cancelar un pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    If conexion.cancelar_pedido(Me.tabla_pedidos.CurrentRow.Cells(0).Value) = True Then 'Verificar que la transacción se ejecute correctamente mostrando los mensajes correpondientes
                        MessageBox.Show("Pedido cancelado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)

                    Else
                        MessageBox.Show("El pedido no se pudo cancelar", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                    Me.tabla_pedidos.DataSource = Me.conexion.cargar_grilla("pedidos") 'Carga nuevamente la grilla luego de cambiar el estado
                End If

            Else
                MessageBox.Show("El pedido ya está cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        ElseIf Me.eliminacion = tipo_eliminacion.detalle_en_BD Then 'Para eliminar detalle que estan en la base de datos
            If Me.tabla_pedidos.CurrentRow.Cells(5).Value = False Then
                If MessageBox.Show("¿Seguro que desea eliminar un detalle?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                    If Me.conexion.eliminar_detalle(Me.tabla_pedidos.CurrentRow.Cells(0).Value, Me.tabla_detalles.CurrentRow.Cells(0).Value) = True Then
                        MessageBox.Show("Detalle de pedido eliminado con éxito", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargar_combos_desde_pedido()
                    Else
                        MessageBox.Show("El detalle de pedido no se eliminó correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If
                End If
            Else
                MessageBox.Show("No se puede eliminar un detalle que está cancelado", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If


        Else
            If MessageBox.Show("¿Seguro que desea eliminar un detalle de pedido?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.Yes Then
                Dim tabla_auxiliar As DataTable = Me.tabla_detalles.DataSource
                Dim indice As Integer = Me.tabla_detalles.CurrentRow.Index
                tabla_auxiliar.Rows.RemoveAt(indice)
                tabla_detalles.DataSource = tabla_auxiliar
            End If
        End If

    End Sub

    Private Sub cmd_reporte_Click(sender As Object, e As EventArgs)
        Me.listado_pedidos = New Listado_pedidos
        Me.listado_pedidos.Show()
    End Sub

    Private Sub cmd_reporte_productos_Click(sender As Object, e As EventArgs)
        Dim listado_productos As New Listado_productos
        listado_productos.Show()
    End Sub
End Class

