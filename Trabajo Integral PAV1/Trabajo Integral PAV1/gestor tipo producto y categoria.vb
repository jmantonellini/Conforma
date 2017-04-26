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
End Class