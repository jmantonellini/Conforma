Public Class gestor_marcas_modelos

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Dim conexion As New Conexion
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim marca As New Data.DataTable
    Dim modelo As New Data.DataTable


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub


    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub gestor_marcas_modelos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub gestor_marcas_modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class