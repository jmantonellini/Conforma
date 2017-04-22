Public Class gestor_empresas

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
    Private Sub lbl_datos_empresa_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub lbl_razon_social_Click(sender As Object, e As EventArgs) Handles lbl_razon_social.Click

    End Sub
    Private Sub lbl_cuit_Click(sender As Object, e As EventArgs) Handles lbl_cuit.Click

    End Sub
    Private Sub lbl_nombre_Click(sender As Object, e As EventArgs) Handles lbl_nombre.Click

    End Sub
    Private Sub lbl_telefono_fijo_Click(sender As Object, e As EventArgs) Handles lbl_telefono_fijo.Click

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

   
End Class