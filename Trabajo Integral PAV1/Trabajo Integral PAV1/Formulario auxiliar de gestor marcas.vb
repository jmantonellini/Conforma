Public Class Formulario_auxiliar_de_gestor_marcas

    Dim conexion As New Conexion
    Dim marca As String
    Dim id_marca As Integer

    Private Sub Formulario_auxiliar_de_gestor_marcas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If Me.cmb_nombre_marca.SelectedIndex = -1 Then
            e.Cancel = True
        End If

    End Sub

    Private Sub Formulario_auxiliar_de_gestor_marcas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_nombre_marca = conexion.cargar_combo(cmb_nombre_marca, "MARCAS", "ID_MARCA", "NOMBRE")
        Me.cmb_nombre_marca.SelectedIndex = -1
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.cmb_nombre_marca.SelectedIndex <> -1 Then
            Me.marca = Me.cmb_nombre_marca.Text
            Me.id_marca = Me.cmb_nombre_marca.SelectedValue
            Me.Close()
        Else
            MessageBox.Show("Seleccione una marca", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If

    End Sub
    Public Function get_marca() As String
        Return Me.marca
    End Function

    Public Function get_id_marca()
        Return Me.id_marca
    End Function
End Class