Public Class Estadisticas

    Dim conexion As New Conexion

    Private Sub Estadisticas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub


    Private Sub cmd_ventas_x_cliente_Click(sender As Object, e As EventArgs) Handles cmd_ventas_x_cliente.Click
        Dim ventas_x_cliente As New Grafico_ventas_por_cliente
        ventas_x_cliente.Show()
    End Sub

    Private Sub cmd_productos_pedidos_Click(sender As Object, e As EventArgs) Handles cmd_productos_pedidos.Click
        Dim productos_pedidos As New Grafico_productos_pedidos
        productos_pedidos.Show()
    End Sub

    Private Sub cmd_pedidos_cancelados_Click(sender As Object, e As EventArgs) Handles cmd_pedidos_cancelados.Click
        Dim pedidos_cancelados As New Grafico_pedidos_cancelados
        pedidos_cancelados.Show()
    End Sub
End Class