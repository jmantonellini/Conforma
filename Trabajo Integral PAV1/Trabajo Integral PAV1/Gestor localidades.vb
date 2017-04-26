Public Class Gestor_localidades

    Dim conexion As Conexion = New Conexion

    Private Sub Gestor_localidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cmb_pais = conexion.cargar_combo(cmb_pais, "PAISES", "ID_PAIS", "NOMBRE")
        cmb_provincia = conexion.cargar_combo_flitrado_provincia(cmb_provincia, "PROVINCIAS", "ID_PROVINCIA", "NOMBRE", cmb_pais.Text, "PAISES")
        cargar_grilla()


    End Sub

    Private Sub cmb_pais_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_pais.SelectedValueChanged
        If (Me.cmb_pais.SelectedIndex <> -1) Then
            cmb_provincia = conexion.cargar_combo_flitrado_provincia(Me.cmb_provincia, "PROVINCIAS", "ID_PROVINCIA", "NOMBRE", cmb_pais.Text, "PAISES")
            cargar_grilla()
        End If
    End Sub

    Private Sub cargar_grilla()
        If (cmb_provincia.Items.Count <> 0) Then
            Dim tabla As Data.DataTable = conexion.leer_localidades(cmb_provincia.Text)
            tabla_localidades.DataSource = tabla
            tabla_localidades.Columns(tabla_localidades.Columns.Count - 1).Visible = False
        End If

    End Sub

    Private Sub cmb_provincia_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_provincia.SelectedValueChanged
        If (cmb_provincia.SelectedIndex <> -1) Then
            cargar_grilla()
        End If
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Dim localidad_nueva As String = InputBox("Ingrese el nombre de la nueva localidad", "Nueva Localidad")
        Dim codigo_posta As String = InputBox("Ingrese el Codigo Postal", "Nueva Localidad")

        If (localidad_nueva <> "" And conexion.buscar_localidad(" CIUDADES ", cmb_provincia.Text) = True And comprobar_linea(localidad_nueva)) Then
            Try
                
                conexion.insertar_localidad(localidad_nueva, cmb_provincia.Text, CInt(codigo_posta))
                MsgBox("Se ha añadido el elemento satisfactoriamente", MsgBoxStyle.Information, "Aviso")
                cargar_grilla()
            Catch ex As Exception
                MsgBox("No se pudo añadir" & ex.ToString)
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

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click

       
            Dim provincia_nueva As String = InputBox("Ingrese el nuevo nombre de " & tabla_localidades.SelectedRows.Item(0).Cells(0).Value, "Modificar Localidad")
        If MessageBox.Show("¿Seguro que desea cambiar " & tabla_localidades.SelectedRows.Item(0).Cells(0).Value & " por " & provincia_nueva & "? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then

            If (provincia_nueva <> "" And comprobar_linea(provincia_nueva) And conexion.buscar_nombre(" CIUDADES ", provincia_nueva) = True) Then
                Try
                    conexion.cambiar_nombre_localidad(tabla_localidades.SelectedRows.Item(0).Cells(0).Value, provincia_nueva)
                    cargar_grilla()
                Catch ex As Exception
                    MsgBox("No se pudo cambiar el nombre", MsgBoxStyle.Information)
                End Try
            End If

        End If

    End Sub

    Private Sub tabla_localidades_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_localidades.CellClick
        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True

    End Sub


    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        If MessageBox.Show("¿Seguro que desea eliminar " & tabla_localidades.SelectedRows.Item(0).Cells(0).Value & "? ", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Stop) = Windows.Forms.DialogResult.Yes Then
            Try
                conexion.elimnar_localidad(tabla_localidades.SelectedRows.Item(0).Cells(0).Value)
                MsgBox("Se ha eliminado la localidad satisfactoriamente")
                cargar_grilla()
            Catch ex As Exception
                MsgBox("No se pudo eliminar la localidad")
            End Try

        End If

    End Sub
End Class