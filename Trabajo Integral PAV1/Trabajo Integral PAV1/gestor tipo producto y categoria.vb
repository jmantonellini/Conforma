Public Class gestor_tipo_producto_y_categorias

    Dim C As Conexion = New Conexion

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub gestor_tipo_producto_y_categorias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        cmb_area = C.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
        cmb_tipo_producto = C.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
        tabla_categorias.DataSource = C.cargar_grilla("categorias")



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

    Private Sub cmd_nueva_area_Click(sender As Object, e As EventArgs) Handles cmd_nueva_area.Click
        Dim area_nueva As String = InputBox("Ingrese el nombre de la nueva área", "Nueva Área")
        If (area_nueva <> "" And comprobar_linea(area_nueva) And C.buscar_nombre(" AREAS ", cmb_area.Text) = False) Then
            C.insertar_area(area_nueva)
            MsgBox("La nueva área se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If

    End Sub

    Private Sub cmd_nuevo_producto_Click(sender As Object, e As EventArgs) Handles cmd_nuevo_producto.Click
        Dim tipo_nuevo As String = InputBox("Ingrese el nombre del nuevo tipo de producto", "Nuevo Tipo de Producto")

        If (tipo_nuevo <> "" And comprobar_linea(tipo_nuevo) And C.buscar_nombre(" TIPOS_PRODUCTO ", cmb_tipo_producto.Text) = False) Then
            C.insertar_tipo_producto(tipo_nuevo, cmb_area.Text)
            MsgBox("El nuevo tipo de producto se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If

    End Sub

    Private Function comprobar_linea(ByVal cadena As String) As Boolean
        Dim b As Boolean = False
        For index = 0 To cadena.Length - 1
            b = Char.IsLetter(cadena, index)
            If (b = False) Then
                Return b
            End If

        Next
        Return b
    End Function

    Private Sub cmd_nueva_categoria_Click(sender As Object, e As EventArgs) Handles cmd_nueva_categoria.Click
        Dim categoria_nuevo As String = InputBox("Ingrese el nombre de la nueva categoría", "Nueva Categoría")

        If (categoria_nuevo <> "" And C.buscar_nombre(" CATEGORIAS ", cmb_tipo_producto.Text) = False) Then
            C.insertar_categoria(categoria_nuevo, cmb_tipo_producto.Text)
            MsgBox("El nuevo tipo de producto se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If
    End Sub

    Private Sub cmd_modificar_area_Click(sender As Object, e As EventArgs) Handles cmd_modificar_area.Click, cmd_modificar_categoria.Click, cmd_modificar_tipo_producto.Click
        Dim nombre_nuevo As String = InputBox("Ingrese el nombre nuevo", "Cambiar Nombre")
        Dim tabla As String = ""
        Dim seleccion As String = ""
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


        If (tabla = " AREAS " And comprobar_linea(tabla) = True) Then
            Return
        End If
        If (tabla = " TIPOS_PRODUCTOS " And comprobar_linea(tabla) = True) Then
            Return
        Else
        End If
        If (nombre_nuevo <> "" And C.buscar_nombre(tabla, seleccion) = False) Then
            C.cambiar_nombre(tabla, nombre_nuevo, seleccion)
            MsgBox("Se ha modificado el nombre satisfactoriamente", MsgBoxStyle.Information, "Aviso")
            cmb_area = C.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
            cmb_tipo_producto = C.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
            tabla_categorias.DataSource = C.cargar_grilla("categorias")
        Else : MsgBox("No se pueden ingresar campos vacíos o erróneos", MsgBoxStyle.Critical, "AVISO")
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

        If (seleccion <> "") Then
            Try
                C.eliminar_nombre(tabla, seleccion)
                MsgBox("Se ha eliminado el elemento satisfactoriamente", MsgBoxStyle.Information, "Aviso")
            Catch ex As Exception
                MsgBox("No se pudo realizar la consulta por problemas de referencia ")
            End Try

            cmb_area = C.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
            cmb_tipo_producto = C.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
            tabla_categorias.DataSource = C.cargar_grilla("categorias")
        Else : MsgBox("No se pueden ingresar campos vacíos o erróneos", MsgBoxStyle.Critical, "AVISO")
        End If

    End Sub
End Class