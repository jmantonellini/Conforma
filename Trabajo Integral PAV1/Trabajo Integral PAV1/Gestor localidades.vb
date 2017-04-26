Public Class Gestor_localidades

    Dim conexion As New Conexion
    Private Sub Gestor_localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_pais = conexion.cargar_combo(cmb_pais, "PAISES", "ID_PAIS", "NOMBRE")
    End Sub

    Private Sub cmb_pais_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_pais.SelectedValueChanged
        If (Me.cmb_pais.SelectedIndex <> -1) Then
            conexion.cargar_combo_flitrado_provincia(Me.cmb_provincia, "PROVINCIAS", "ID_PROVINCIA", "NOMBRE", cmb_pais.Text, "PAISES")
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As Data.DataTable = conexion.leer_localidades("PROVINCIAS", "NOMBRE", "CIUDADES")
        Me.tabla_localidades.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_localidades.Rows.Add()
            Me.tabla_localidades.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_CIUDAD")
            Me.tabla_localidades.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Me.tabla_localidades.Rows(index).Cells(1).Value = tabla.Rows(index)("CODIGO_POSTAL")
        Next

    End Sub

End Class