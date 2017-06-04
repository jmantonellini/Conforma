Public Class Listado_clientes

    Dim conexion As New Conexion
    Private Sub Listado_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cargar_reporte()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
        Me.t_clientesBindingSource.DataSource = conexion.tabla_listado_clientes(Me.txt_buscar.Text.Trim())
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class