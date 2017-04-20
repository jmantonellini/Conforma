Public Class gestor_marcas_modelos
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub gestor_marcas_modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class