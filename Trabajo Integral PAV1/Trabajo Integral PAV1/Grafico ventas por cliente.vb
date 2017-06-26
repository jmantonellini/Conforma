Public Class Grafico_ventas_por_cliente

    Dim conexion As New Conexion

    Private Sub Grafico_ventas_por_cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grafico()
    End Sub

    Private Sub cargar_grafico()
        Me.t_ventas_x_clienteBindingSource.DataSource = Me.conexion.grafico_ventas_x_cliente()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class