Public Class Gestor_barrios


    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub Gestor_barrios_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub
End Class