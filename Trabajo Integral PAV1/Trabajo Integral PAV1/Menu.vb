Public Class Menu

    Dim nuevo As Form

    Private Sub cmd_gestor_Click(sender As Button, e As EventArgs) Handles cmd_gestor_clientes.Click, cmd_gestor_empresas.Click, cmd_gestor_marcas.Click, cmd_gestor_paises.Click, cmd_gestor_categoria.Click, cmd_provincias.Click, cmd_gestor_localidades.Click

        Dim ventana As String = sender.Text

        Select Case ventana
            Case "Gestor Empresas"
                nuevo = New gestor_empresas
            Case "Gestor Marcas"
                nuevo = New gestor_marcas_modelos
            Case "Gestor Clientes"
                nuevo = New gestor_clientes
            Case "Gestor Paises"
                nuevo = New gestor_paises
            Case "Gestor Categorias"
                nuevo = New gestor_tipo_producto_y_categorias
            Case "Gestor Provincias"
                nuevo = New Gestor_Provincias
            Case "Gestor Localidades"
                nuevo = New Gestor_localidades
        End Select
        nuevo.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class