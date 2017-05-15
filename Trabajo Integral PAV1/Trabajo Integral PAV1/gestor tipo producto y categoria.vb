Public Class gestor_tipo_producto_y_categorias

    Enum tipo_accion
        nulo
        modificar
        nuevo
    End Enum

    Dim C As Conexion = New Conexion
    Dim accion As tipo_accion = tipo_accion.nulo
    Dim parenta As Form

    Private Sub gestor_tipo_producto_y_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_forms()
    End Sub

    Private Sub cmb_area_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_area.SelectedValueChanged
        If (cmb_area.Items.Count <> 0) Then
            C.cargar_combo_flitrado(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", cmb_area.Text, "AREAS")
            tabla_categorias.DataSource = C.cargar_categorias_filtrada("CATEGORIAS", cmb_tipo_producto.Text)
        End If

    End Sub


    Private Sub cmb_tipo_producto_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_tipo_producto.SelectedValueChanged
        If (cmb_tipo_producto.Items.Count <> 0) Then
            tabla_categorias.DataSource = C.cargar_categorias_filtrada("CATEGORIAS", cmb_tipo_producto.Text)
        End If
    End Sub

    Private Sub cmd_nueva_area_Click(sender As Button, e As EventArgs) Handles cmd_nueva_area.Click, cmd_nueva_categoria.Click, cmd_nuevo_producto.Click
        Dim cadena1 As String = ""
        Dim cadena2 As String = ""
        Dim tabla_buscada As String = ""

        Select Case sender.Name
            Case "cmd_nueva_area"
                cadena1 = "Ingrese el nombre de la nueva área"
                cadena2 = "Nueva Área"
                tabla_buscada = " AREAS "
            Case "cmd_nuevo_producto"
                cadena1 = "Ingrese el nombre del nuevo tipo de producto"
                cadena2 = "Nuevo Tipo de Producto"
                tabla_buscada = " TIPOS_PRODUCTOS"
            Case "cmd_nueva_categoria"
                cadena1 = "Ingrese el nombre de la nueva categoría"
                cadena2 = "Nueva Categroría"
                tabla_buscada = " CATEGORIAS "
        End Select
        Dim nuevo_texto As String = InputBox(cadena1, cadena2, " ")
        accion = tipo_accion.nuevo
        If (nuevo_texto <> "") Then
            If (comprobar_linea(nuevo_texto) And C.buscar_nombre(tabla_buscada, nuevo_texto)) Then
                Select Case tabla_buscada
                    Case " CATEGORIAS "
                        C.insertar_categoria(nuevo_texto, cmb_tipo_producto.Text)
                    Case " AREAS "
                        C.insertar_area(nuevo_texto)
                    Case " TIPOS_PRODUCTOS "
                        C.insertar_tipo_producto(nuevo_texto, cmb_area.Text)
                End Select
                Me.cargar_forms()
                MsgBox(" " & nuevo_texto & " se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
            Else : MsgBox("No se pueden ingresar campos vacíos, numerales o repetidos", MsgBoxStyle.Critical, "AVISO")
            End If
        End If
        If (Me.IsMdiChild = True) Then
            Dim gestor As gestor_pedidos = Me.MdiParent
            gestor.cargar_combos()
        End If
            accion = tipo_accion.nulo
    End Sub


    Private Function comprobar_linea(ByVal cadena As String) As Boolean
        Dim b As Boolean = False
        For index = 0 To cadena.Length - 1
            b = Char.IsLetter(cadena, index)
            If (b = False And Char.IsWhiteSpace(cadena, index) = False) Then
                Return b
            End If

        Next
        Return b
    End Function


    Private Sub cmd_modificar_area_Click(sender As Object, e As EventArgs) Handles cmd_modificar_area.Click, cmd_modificar_categoria.Click, cmd_modificar_tipo_producto.Click
        Dim nombre_nuevo As String = InputBox("Ingrese el nombre nuevo", "Cambiar Nombre", " ")
        Dim tabla As String = ""
        Dim seleccion As String = ""
        accion = tipo_accion.modificar
        If (nombre_nuevo <> " ") Then
            Select Case sender.Name
                Case "cmd_modificar_area"
                    tabla = " AREAS "
                    seleccion = cmb_area.Text
                Case "cmd_modificar_tipo_producto"
                    tabla = " TIPOS_PRODUCTOS "
                    seleccion = cmb_tipo_producto.Text
                Case "cmd_modificar_categoria"
                    tabla = " CATEGORIAS "
                    seleccion = tabla_categorias.SelectedRows.Item(0).Cells(0).Value.ToString
            End Select

            If MessageBox.Show("¿Seguro que desea cambiar " & seleccion & " por " & nombre_nuevo & "? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then

                If (tabla = " AREAS " And comprobar_linea(tabla) = True) Then
                    Return
                End If
                If (tabla = " TIPOS_PRODUCTOS " And comprobar_linea(tabla) = True) Then
                    Return
                Else
                End If
                If (nombre_nuevo <> "" And C.buscar_nombre(tabla, nombre_nuevo) = True) Then
                    C.cambiar_nombre(tabla, nombre_nuevo, seleccion)
                    MsgBox("Se ha modificado el nombre satisfactoriamente", MsgBoxStyle.Information, "Aviso")
                    accion = tipo_accion.nulo
                    Me.cargar_forms()
                Else : MsgBox("No se pueden ingresar campos vacíos, erróneos o repetidos", MsgBoxStyle.Critical, "AVISO")
                    accion = tipo_accion.nulo
                End If
            End If
        End If


    End Sub

    Private Sub cmd_eliminar_area_Click(sender As Object, e As EventArgs) Handles cmd_eliminar_area.Click, cmd_eliminar_categoria.Click, cmd_eliminar_tipo.Click
        Dim tabla As String = ""
        Dim seleccion As String = ""
        Select Case sender.Name
            Case "cmd_eliminar_area"
                tabla = " AREAS "
                seleccion = cmb_area.Text
            Case "cmd_eliminar_tipo"
                tabla = " TIPOS_PRODUCTOS "
                seleccion = cmb_tipo_producto.Text
            Case "cmd_eliminar_categoria"
                tabla = " CATEGORIAS "
                seleccion = tabla_categorias.SelectedRows.Item(0).Cells(0).Value.ToString
        End Select

        If MessageBox.Show("¿Seguro que desea eliminar " & seleccion & "? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then

            If (seleccion <> "") Then
                Try
                    C.eliminar_nombre(tabla, seleccion)
                    MsgBox("Se ha eliminado el elemento satisfactoriamente", MsgBoxStyle.Information, "Aviso")
                Catch ex As Exception
                    MsgBox("No se pudo realizar el borrado por problemas de referencia")
                End Try
                Me.cargar_forms()
            Else : MsgBox("No se pueden ingresar campos vacíos o erróneos", MsgBoxStyle.Critical, "AVISO")
            End If
        End If

    End Sub

    Private Sub cargar_forms()
        cmb_area = C.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
        cmb_tipo_producto = C.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
        tabla_categorias.DataSource = C.cargar_grilla("categorias")

    End Sub

    Private Sub salirCruz(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (accion <> tipo_accion.nulo) Then
            If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        Else : e.Cancel = False
        End If
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub
End Class