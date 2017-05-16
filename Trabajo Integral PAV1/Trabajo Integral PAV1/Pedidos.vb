Public Class gestor_pedidos
    Enum tipo_accion
        modificacion
        nuevo
        nulo
    End Enum

    Dim conexion As New Conexion
    Dim accion As tipo_accion = tipo_accion.nulo
    Dim contador As Int16 = 0
    Dim ventana_hija As Boolean = False


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
        Me.tabla_detalles.RowCount = 0
        accion = tipo_accion.nuevo
    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub tabla_pedidos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_pedidos.CellDoubleClick
        'cargar todos los detalles pedidos
        Dim cadena_busqueda As String = " DETALLES_PEDIDOS DP JOIN PRODUCTOS P ON P.ID_PRODUCTO = DP.ID_PRODUCTO " _
                                        & " JOIN AREAS A ON A.ID_AREA = P.ID_AREA " _
                                        & " JOIN CATEGORIAS C ON C.ID_CATEGORIA = P.ID_CATEGORIA " _
                                        & " JOIN MODELOS M ON M.ID_MODELO = P.ID_MODELO " _
                                        & " JOIN TIPOS_PRODUCTOS TP ON TP.ID_TIPO_PRODUCTO = P.ID_TIPO_PRODUCTO "

        tabla_detalles.DataSource = conexion.leer_tabla_filtrada_generica(cadena_busqueda, _
                                                                          "NRO_PEDIDO", _
                                                                          tabla_pedidos.SelectedRows.Item(0).Cells(0).Value, _
                                                                          " DP.ID_DETALLE_PEDIDO as 'Detalle Nº' , " _
                                                                          & " A.NOMBRE AS 'Área' ," _
                                                                          & " C.NOMBRE AS 'Categoría' ," _
                                                                          & " M.NOMBRE AS 'Modelo' ")
        'cargar todos los combos desde la tabla detalle ACA TIRA ERROR; DESPUES DE ESTO
        conexion.cargar_combo_generico_nombre(cmb_area, "AREAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(1).Value)
        conexion.cargar_combo_generico_nombre(cmb_categoria, "CATEGORIAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(2).Value)
        conexion.cargar_combo_generico_nombre(cmb_modelo, "MODELOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(3).Value)
        Dim tabla_auxiliar As DataTable = conexion.leer_tabla_filtrada_generica(" DETALLES_PEDIDOS ", "ID_DETALLE_PEDIDO", tabla_detalles.SelectedRows.Item(0).Cells(0).Value, " CANTIDAD")
        txt_cantidad.Text = tabla_auxiliar.Rows().Item(0).Item(0)
        conexion.carga_combo_generico_dos_tablas(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", "CATEGORIAS", "ID_TIPO_PRODUCTO", cmb_categoria.Text)
        conexion.carga_combo_generico_dos_tablas(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE", "MODELOS", "ID_MARCA", cmb_modelo.Text)
        fecha_entrega.CustomFormat = "DD/MM/YYYY"
        Me.fecha_entrega.Value = (CDate(tabla_pedidos.SelectedRows.Item(0).Cells(3).Value))
        TabControl1.SelectedTab = tab_nuevo
    End Sub

    Private Sub tabla_detalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_detalles.CellClick
        conexion.cargar_combo_generico_nombre(cmb_area, "AREAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(1).Value)
        conexion.cargar_combo_generico_nombre(cmb_categoria, "CATEGORIAS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(2).Value)
        conexion.cargar_combo_generico_nombre(cmb_modelo, "MODELOS", "NOMBRE", "NOMBRE", tabla_detalles.SelectedRows.Item(0).Cells(3).Value)
        Dim tabla_auxiliar As DataTable = conexion.leer_tabla_filtrada_generica(" DETALLES_PEDIDOS ", "ID_DETALLE_PEDIDO", tabla_detalles.SelectedRows.Item(0).Cells(0).Value, " CANTIDAD")
        txt_cantidad.Text = tabla_auxiliar.Rows().Item(0).Item(0)
        conexion.carga_combo_generico_dos_tablas(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", "CATEGORIAS", "ID_TIPO_PRODUCTO", cmb_categoria.Text)
        conexion.carga_combo_generico_dos_tablas(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE", "MODELOS", "ID_MARCA", cmb_modelo.Text)
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
        
        tabla_detalles.Rows.Add(tabla_detalles.Rows.Count + 1, cmb_area.Text, cmb_categoria.Text, cmb_modelo.Text)
    End Sub
End Class

