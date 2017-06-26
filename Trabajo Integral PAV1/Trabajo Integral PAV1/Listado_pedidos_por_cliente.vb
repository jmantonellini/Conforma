Public Class Listado_pedidos_por_cliente

    Dim conexion As New Conexion
    Private Sub Listado_pedidos_por_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim screenWidth As Integer = My.Computer.Screen.Bounds.Width
        Panel1.Width = screenWidth
        Panel2.Width = screenWidth

        Me.cargar_reporte()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
        Me.t_pedidos_clienteBindingSource.DataSource = conexion.tabla_pedidos_por_cliente(txt_filtro.Text, fecha_inicio.Value, fecha_fin.Value)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class