Public Class Listado_clientes_por_empresa


    Dim conexion As New Conexion
    Private Sub Listado_clientes_por_empresa_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_reporte()

    End Sub

    Public Sub cargar_reporte()
        Me.t_clientes_empresaBindingSource.DataSource = conexion.tabla_clientes_por_empresa(txt_empresa.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        cargar_reporte()
    End Sub
End Class