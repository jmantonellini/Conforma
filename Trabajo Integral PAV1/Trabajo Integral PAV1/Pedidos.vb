Public Class gestor_pedidos
    Private Sub txt_observaciones_TextChanged(sender As Object, e As EventArgs) Handles txt_observaciones.Click, txt_observaciones.GotFocus
        txt_observaciones.Text = ""
        txt_observaciones.ForeColor = Color.Black
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs)

    End Sub
End Class