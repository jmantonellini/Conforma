Public Class gestor_paises

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Dim paises As New Data.DataTable
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim conexion As New Conexion

    Private Sub gestor_paises_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If accion = tipo_grabacion.insertar Or accion = tipo_grabacion.modificar Then
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
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
        Next
        Me.cmd_modificar.Enabled = True
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()
        Me.accion = tipo_grabacion.insertar
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
        paises = conexion.buscar_paises(tabla_paises.CurrentRow.Cells(1).Value)

        Me.txt_nombre.Text = paises.Rows(0).Item(1).ToString

        Me.cmd_editar.Enabled = True
        Me.cmd_eliminar.Enabled = True
    End Sub

    Private Sub cmd_editar_Click(sender As Object, e As EventArgs) Handles cmd_editar.Click
        Me.txt_nombre.Enabled = True
        Me.txt_nombre.Focus()
        Me.cmd_modificar.Enabled = True
        Me.accion = tipo_grabacion.modificar
    End Sub


    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        If accion = tipo_grabacion.insertar Then
            Try
                Me.conexion.insertar_pais(Me.txt_nombre.Text.ToString)
                MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cargar_grilla()

            Catch ex As OleDb.OleDbException
                MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        Else
            Try
                Me.conexion.modificar_pais(Me.txt_nombre.Text.ToString, Me.tabla_paises.CurrentRow.Cells(0).Value)
                MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Me.cargar_grilla()

            Catch ex As OleDb.OleDbException
                MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
            End Try
        End If
    End Sub
End Class