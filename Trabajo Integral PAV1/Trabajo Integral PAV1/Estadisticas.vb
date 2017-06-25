Public Class Estadisticas

    Private Sub cmd_pedidos_cancelados_Click(sender As Object, e As EventArgs) Handles cmd_pedidos_cancelados.Click
        Dim pedidos_cancelados As New Grafico_pedidos_cancelados
        pedidos_cancelados.Show()
    End Sub

    Private Sub cmd_productos_pedidos_Click(sender As Object, e As EventArgs) Handles cmd_productos_pedidos.Click
        Dim pedidos_productos As New Grafico_productos_pedidos
        pedidos_productos.Show()
    End Sub
End Class