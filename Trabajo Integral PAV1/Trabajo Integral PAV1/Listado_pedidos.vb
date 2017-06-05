Public Class Listado_pedidos

    Dim conexion As New Conexion

    Private Sub Listado_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()

        Me.t_pedidosBindingSource.DataSource = conexion.tabla_listado_pedidos(Me.txt_buscar.Text.Trim())
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.cargar_reporte()
    End Sub
End Class