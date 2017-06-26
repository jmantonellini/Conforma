Public Class Grafico_ventas_por_cliente

    Dim conexion As New Conexion


    Private Sub cargar_grafico()
        Me.t_ventas_x_clienteBindingSource.DataSource = conexion.grafico_ventas_x_cliente(txt_minimo.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub Grafico_ventas_por_cliente_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grafico()
        Me.Width = ReportViewer1.Width

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        cargar_grafico()
    End Sub
End Class