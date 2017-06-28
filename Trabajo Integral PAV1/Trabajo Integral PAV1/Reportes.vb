Public Class Reportes

    
    Private Sub cmd_provincias_Click(sender As Button, e As EventArgs) Handles cmd_provincias.Click, cmd_clientes.Click, cmd_detalles.Click, cmd_pedidos_cliente.Click, cmd_productos.Click, cmd_empresas.Click, cmd_clientes_por_empresa.Click

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
            Case "cmd_empresas"
                ventana = New Listado_empresas
            Case "cmd_clientes_por_empresa"
                ventana = New Listado_clientes_por_empresa
        End Select
        ventana.Show()

    End Sub

  
    Private Sub cmd_provincias_Click(sender As Object, e As EventArgs) Handles cmd_provincias.Click, cmd_productos.Click, cmd_pedidos_cliente.Click, cmd_empresas.Click, cmd_detalles.Click, cmd_clientes.Click, cmd_clientes_por_empresa.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub
End Class