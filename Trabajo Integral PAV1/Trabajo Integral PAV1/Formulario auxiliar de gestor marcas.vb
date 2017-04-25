Public Class Formulario_auxiliar_de_gestor_marcas

    Dim conexion As New Conexion

    Private Sub Formulario_auxiliar_de_gestor_marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_nombre_marca = conexion.cargar_combo(cmb_nombre_marca, "MARCAS", "ID_MARCA", "NOMBRE")
    End Sub
End Class