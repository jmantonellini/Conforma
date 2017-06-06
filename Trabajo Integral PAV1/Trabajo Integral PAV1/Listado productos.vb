Public Class Listado_productos

    Dim conexion As New Conexion

    Private Sub Listado_productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
        Me.t_productosBindingSource.DataSource = Me.conexion.tabla_listado_productos(Me.txt_buscar.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub

    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.cargar_reporte()
    End Sub
End Class