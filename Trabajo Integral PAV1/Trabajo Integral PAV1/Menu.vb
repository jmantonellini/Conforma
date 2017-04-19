Public Class Menu

    Dim nuevo As Form

    Private Sub cmd_gestor_Click(sender As Button, e As EventArgs) Handles cmd_gestor_clientes.Click, cmd_gestor_empresas.Click, cmd_gestor_marcas.Click

        Dim ventana As String = sender.Text
        If ventana = "Gestor empresas" Then
            nuevo = New gestor_empresas
        ElseIf ventana = "Gestor marcas" Then
            nuevo = New gestor_marcas_modelos
        Else
            nuevo = New gestor_clientes

        End If

        nuevo.Show()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class