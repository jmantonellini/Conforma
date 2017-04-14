Public Class gestor_clientes

    Private Sub gestor_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

   
    Private Sub blanquear_campos() Handles cmd_nuevo.Click, cmd_eliminar.Click
        cmb_tipo_documento.SelectedIndex = -1
        cmb_barrio.SelectedIndex = -1
        cmb_ciudad.SelectedIndex = -1
        cmb_pais.SelectedIndex = -1
        cmb_provincia.SelectedIndex = -1
        cmb_tipo_documento.SelectedIndex = -1
        txt_altura_calle.Text = ""
        txt_apellido.Text = ""
        txt_calle.Text = ""
        txt_celular.Text = ""
        txt_cuit.Text = ""
        txt_documento.Text = ""
        txt_empresa.Text = ""
        txt_fijo.Text = ""
        txt_mail.Text = ""
        txt_nombre.Text = ""



    End Sub

End Class