Public Class Listado_paises_provincias

    Dim conexion As New Conexion

    Private Sub Listado_paises_provincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
        Me.t_paises_y_provinciasBindingSource.DataSource = Me.conexion.tabla_listado_paises_provincias()
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class