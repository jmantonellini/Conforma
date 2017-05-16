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


    Private Sub deshabilitar_campos()
        For Each obj As Windows.Forms.Control In Me.tab_nuevo.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                local.Enabled = False
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
            If (obj.GetType().Name = "Button") Then
                If (obj.Name = "cmd_agregar_detalle" Or obj.Name = "cmd_nueva_marca" Or obj.Name = "cmd_nuevo_cliente" Or obj.Name = "cmd_nuevo_producto") Then
                    obj.Enabled = False
                End If
            End If

        Next
    End Sub

    Private Sub actualizar_combo_clientes()
        conexion.cargar_combo(cmb_cliente, " CLIENTES ", "ID_CLIENTE", "NOMBRE")
    End Sub

    Private Sub gestor_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_nuevo.Enabled = True
        cmd_guardar.Enabled = False
        cmd_salir.Enabled = True
        cmd_nueva_marca.Enabled = False
        cmd_nuevo_producto.Enabled = False
        cmd_nuevo_cliente.Enabled = False
        cmd_agregar_detalle.Enabled = False
        tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
        cmd_agregar_detalle.Enabled = False
        cmd_nueva_marca.Enabled = False
        cmd_nuevo_cliente.Enabled = False
        cmd_nuevo_producto.Enabled = False
        txt_observaciones.Enabled = False
        txt_cantidad.Enabled = False
        cmb_area.Enabled = False
        cmb_categoria.Enabled = False
        cmb_cliente.Enabled = False
        cmb_marca.Enabled = False
        cmb_modelo.Enabled = False
        cmb_tipo_producto.Enabled = False
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
        MsgBox("Combos cargados")
    End Sub

    Private Sub cmd_nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        cmd_nuevo_cliente.Enabled = True
        cmd_nueva_marca.Enabled = True
        cmd_nuevo_producto.Enabled = True
        cmd_agregar_detalle.Enabled = True
        Me.cargar_combos()
        accion = tipo_accion.nuevo
    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles cmd_salir2.Click, cmd_salir.Click
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

        'conexion.cargar_combo_generico_filtrado(cmb_categoria, " CATEGORIAS ", " ID_CATEGORIA ", " NOMBRE ", tabla_detalles.SelectedRows.Item(0).Cells(2).Value)
        TabControl1.SelectedTab = tab_nuevo
    End Sub
End Class

