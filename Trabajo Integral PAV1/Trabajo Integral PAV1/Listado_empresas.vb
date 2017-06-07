Public Class Listado_empresas

    Dim conexion As New Conexion

    Private Sub Listado_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.ReportViewer1.Width = My.Computer.Screen.Bounds.Width
        Me.cargar_reporte()

    End Sub

    Private Sub cargar_reporte()
        Me.t_empresasBindingSource.DataSource = conexion.tabla_empresas(txt_buscar.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub


    Private Sub cmd_buscar_Click(sender As Object, e As EventArgs) Handles cmd_buscar.Click
        Me.t_empresasBindingSource.DataSource = conexion.tabla_empresas(txt_buscar.Text)
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class