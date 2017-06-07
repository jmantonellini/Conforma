Public Class Reportes

    
    Private Sub cmd_provincias_Click(sender As Button, e As EventArgs) Handles cmd_provincias.Click, cmd_clientes.Click, cmd_detalles.Click, cmd_pedidos_cliente.Click, cmd_productos.Click

        Dim boton As String = sender.Name
        Dim ventana As New Form

        Select Case boton
            Case "cmd_provincias"
                ventana = New Listado_paises_provincias
            Case "cmd_clientes"
                ventana = New Listado_clientes
            Case "cmd_detalles"
                ventana = New Listado_pedidos
            Case "cmd_productos"
                ventana = New Listado_productos
            Case "cmd_pedidos_cliente"
                ventana = New Listado_pedidos_por_cliente

        End Select
        ventana.Show()

    End Sub
End Class