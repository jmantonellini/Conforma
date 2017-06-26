Public Class Reporte_ventas_por_mes

    Dim conexion As New Conexion

    Private Sub Reporte_ventas_por_mes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        graficar()

    End Sub

    Private Sub graficar()

        Me.t_pedidos_por_mesBindingSource.DataSource = conexion.grafico_ventas_por_mes(txt_año.Text)
        Me.ReportViewer1.RefreshReport()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        graficar()

    End Sub
End Class