Public Class Grafico_productos_pedidos

    Dim conexion As New Conexion

    Private Sub Grafico_productos_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grafico()
    End Sub

    Private Sub cargar_grafico()
        Me.t_productos_pedidosBindingSource.DataSource = Me.conexion.grafico_pedidos_productos()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class