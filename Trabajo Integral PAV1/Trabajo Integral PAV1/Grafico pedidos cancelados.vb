Public Class Grafico_pedidos_cancelados

    Dim conexion As New Conexion

    Private Sub Grafico_pedidos_cancelados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grafico()
    End Sub

    Private Sub cargar_grafico()
        Me.t_pedidos_canceladosBindingSource.DataSource = Me.conexion.grafico_pedidos_cancelados()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class