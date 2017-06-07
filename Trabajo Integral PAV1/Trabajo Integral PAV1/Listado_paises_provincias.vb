<<<<<<< HEAD
Public Class Listado_paises_provincias
    Dim conexion As New Conexion
    Private Sub Listado_paises_provincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load

=======
﻿Public Class Listado_paises_provincias

    Dim conexion As New Conexion

    Private Sub Listado_paises_provincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
>>>>>>> 1950145139942b370f823a936b1f4aa7d6c81662
        Me.cargar_reporte()
    End Sub

    Private Sub cargar_reporte()
<<<<<<< HEAD
        Me.t_paises_y_provinciasBindingSource.DataSource = conexion.tabla_listado_paises_provincias()
=======
        Me.t_paises_y_provinciasBindingSource.DataSource = Me.conexion.tabla_listado_paises_provincias()
>>>>>>> 1950145139942b370f823a936b1f4aa7d6c81662
        Me.ReportViewer1.RefreshReport()
    End Sub
End Class