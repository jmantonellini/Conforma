Public Class Menu

    Dim nuevo As Form

    Private Sub cmd_gestor_Click(sender As Button, e As EventArgs) Handles cmd_gestor_clientes.Click, cmd_gestor_empresas.Click, cmd_gestor_marcas.Click, cmd_gestor_paises.Click, _
        cmd_gestor_categoria.Click, cmd_provincias.Click, cmd_gestor_localidades.Click, cmd_pedidos.Click, cmd_reportes.Click, cmd_estadisticas.Click

        Dim ventana As String = sender.Text

        Select Case ventana
            Case "Empresas"
                nuevo = New gestor_empresas
            Case "Marcas"
                nuevo = New gestor_marcas_modelos
            Case "Clientes"
                nuevo = New gestor_clientes
            Case "Paises"
                nuevo = New gestor_paises
            Case "Categorias"
                nuevo = New gestor_tipo_producto_y_categorias
            Case "Provincias"
                nuevo = New Gestor_Provincias
            Case "Localidades"
                nuevo = New Gestor_localidades
            Case "Pedidos"
                nuevo = New gestor_pedidos
            Case "Reportes"
                nuevo = New Reportes
            Case "Estadisticas"
                nuevo = New Estadisticas
        End Select
        nuevo.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss ")
    End Sub


End Class