Public Class Gestor_Provincias

    Dim c As Conexion = New Conexion

    Private Sub Gestor_Provincias_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        c.cargar_combo(cmb_pais, "PAISES", "ID_PAIS", "NOMBRE")
        tabla_provincias.DataSource = c.cargar_provincias_filtrada(cmb_pais.Text)

    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Dim provincia_nueva As String = InputBox("Ingrese el nombre de la nueva provincia de " & cmb_pais.Text, "Nueva Provincia")
        If (provincia_nueva <> "" And comprobar_linea(provincia_nueva) And c.buscar_nombre(" PROVINCIAS ", provincia_nueva) = True) Then

            Try
                c.insertar_provincia(provincia_nueva, cmb_pais.Text)
                MsgBox("Se ha añadido el elemento satisfactoriamente", MsgBoxStyle.Information, "Aviso")
                tabla_provincias.DataSource = c.cargar_provincias_filtrada(cmb_pais.Text)
            Catch ex As Exception
                MsgBox("No se pudo añadir ")
            End Try
        Else : MsgBox("No se pueden ingresar campos vacíos o numerales", MsgBoxStyle.Critical, "AVISO")
        End If
    End Sub

    Private Function comprobar_linea(ByVal cadena As String) As Boolean
        Dim b As Boolean = False
        For index = 0 To cadena.Length - 1
            b = Char.IsLetter(cadena, index)
            If (b = False And Char.IsWhiteSpace(cadena, index) = False) Then
                Return b
            End If

        Next
        Return b
    End Function

    Private Sub cmb_pais_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_pais.SelectedValueChanged
        If (cmb_pais.Items.Count <> 0) Then
            tabla_provincias.DataSource = c.cargar_provincias_filtrada(cmb_pais.Text)
        End If
    End Sub
End Class