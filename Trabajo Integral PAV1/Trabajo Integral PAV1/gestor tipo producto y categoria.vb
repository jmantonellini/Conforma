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
            cmb_tipo_producto = C.cargar_combo_flitrado(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE", cmb_area.Text, "AREAS")
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
        If (area_nueva <> "" And comprobar_linea(area_nueva)) Then
            C.insertar_area(area_nueva)
            MsgBox("La nueva área se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If

    End Sub

    Private Sub cmd_nuevo_producto_Click(sender As Object, e As EventArgs) Handles cmd_nuevo_producto.Click
        Dim tipo_nuevo As String = InputBox("Ingrese el nombre del nuevo tipo de producto", "Nuevo Tipo de Producto")

        If (tipo_nuevo <> "" And comprobar_linea(tipo_nuevo)) Then
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

        If (categoria_nuevo <> "") Then
            C.insertar_categoria(categoria_nuevo, cmb_tipo_producto.Text)
            MsgBox("El nuevo tipo de producto se ha cargado satisfactoriamente", MsgBoxStyle.Information, "Aviso")
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If
    End Sub
End Class