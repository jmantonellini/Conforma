Public Class gestor_paises

    Enum tipo_grabacion
        insertar
        modificar
        nulo
    End Enum

    Dim paises As New Data.DataTable
    Dim accion As tipo_grabacion = tipo_grabacion.nulo
    Dim conexion As New Conexion
    Dim buscando As Boolean = True

    Private Sub gestor_paises_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If accion <> tipo_grabacion.nulo Then
            If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub Gestor_paises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        Me.txt_nombre.Text = ""
        'For Each obj As Windows.Forms.Control In Me.Controls
        '    If obj.GetType().Name = "TextBox" Then
        '        obj.Text = ""
        '    End If
        'Next
        Me.cmd_modificar.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = tipo_grabacion.insertar
        Me.buscando = False
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As Data.DataTable = conexion.cargar_grilla("paises")
        tabla_paises.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_paises.Rows.Add()
            Me.tabla_paises.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_PAIS")
            Me.tabla_paises.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
        Next

    End Sub

    Private Sub tabla_paises_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_paises.CellClick
        Me.accion = tipo_grabacion.insertar
        Me.cmd_eliminar.Enabled = True
        Me.txt_nombre.Enabled = True
    End Sub

    Private Sub tabla_paises_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_paises.CellDoubleClick
        paises = conexion.buscar_paises(tabla_paises.CurrentRow.Cells(1).Value)
        Me.txt_nombre.Text = paises.Rows(0).Item(1).ToString
        Me.accion = tipo_grabacion.modificar
        Me.cmd_eliminar.Enabled = True
        Me.txt_nombre.Enabled = True
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        If Me.buscando = False Then
            Me.grabar_pais(Me.txt_nombre.Text)
            Me.buscando = True
        Else
            MessageBox.Show("Seleccione nuevo pais antes de guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
        accion = tipo_grabacion.nulo
    End Sub

    Private Sub grabar_pais(ByVal nombre As String)
        If Me.conexion.buscar_paises(nombre.ToString).Rows.Count = 1 Then
            MessageBox.Show("El pais ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Me.accion = tipo_grabacion.insertar Then
                Try
                    Me.conexion.insertar_pais(nombre.ToString)
                    MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargar_grilla()

                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                If Me.conexion.buscar_paises(nombre.ToString).Rows.Count = 0 Then
                    Try
                        Me.conexion.modificar_pais(nombre.ToString, Me.tabla_paises.CurrentRow.Cells(0).Value)
                        MessageBox.Show("Se modifico correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargar_grilla()

                    Catch ex As OleDb.OleDbException
                        MessageBox.Show("No se modifico correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("El pais ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub txt_nombre_Click(sender As Object, e As EventArgs) Handles txt_nombre.Click
        Me.buscando = True
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        e.Handled = Not Char.IsLetter(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        Me.cmd_modificar.Enabled = True
        If Me.buscando <> False Then
            Dim tabla As Data.DataTable = Me.conexion.buscar_paises_expRegular(txt_nombre.Text.ToString)

            tabla_paises.Rows.Clear()

            Dim index As Integer
            For index = 0 To tabla.Rows.Count - 1

                Me.tabla_paises.Rows.Add()
                Me.tabla_paises.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_PAIS")
                Me.tabla_paises.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Next
        End If
    End Sub

    Private Sub cmd_eliminar_Click(sender As Object, e As EventArgs) Handles cmd_eliminar.Click
        Dim index As Integer
        Dim celdas_seleccionadas = Me.tabla_paises.SelectedRows.Count
        If Me.tabla_paises.SelectedRows.Count >= 1 Then
            For index = 0 To celdas_seleccionadas - 1
                Try
                    Me.conexion.eliminar_pais(Me.tabla_paises.SelectedRows(index).Cells(1).Value.ToString())
                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se elimino correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    Exit Sub
                End Try
            Next
            MessageBox.Show("Se elimino correctamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.cargar_grilla()
            Me.txt_nombre.Text = ""
            Exit Sub
        Else
            If Me.conexion.buscar_paises(txt_nombre.Text.ToString).Rows.Count = 1 Then
                Try
                    Me.conexion.eliminar_pais(txt_nombre.Text.ToString)
                    Me.cargar_grilla()
                    MessageBox.Show("Se elimino correctamente", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se elimino correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                MessageBox.Show("No se puede eliminar debido ya que no existe el pais", "Eliminacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If
        End If
        accion = tipo_grabacion.nulo

    End Sub

    
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_reporte_Click(sender As Object, e As EventArgs)
        Dim listado_paises As New Listado_paises_provincias
        listado_paises.Show()
    End Sub
End Class