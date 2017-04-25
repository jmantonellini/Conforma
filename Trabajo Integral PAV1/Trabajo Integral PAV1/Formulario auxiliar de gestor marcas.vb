Public Class Formulario_auxiliar_de_gestor_marcas

    Dim conexion As New Conexion
    Public marca As String

    Public Sub New(ByRef _marca As String)
        Me.marca = _marca
    End Sub
    Private Sub Formulario_auxiliar_de_gestor_marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_nombre_marca = conexion.cargar_combo(cmb_nombre_marca, "MARCAS", "ID_MARCA", "NOMBRE")
        Me.cmb_nombre_marca.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim tabla As Data.DataTable
        If Me.cmb_nombre_marca.SelectedIndex > -1 Then
            tabla = conexion.buscar_modelo(Me.cmb_nombre_marca.Text)
            conexion.insertar_modelo(Me.marca, Me.cmb_nombre_marca.SelectedValue)

        Else
            MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub
End Class