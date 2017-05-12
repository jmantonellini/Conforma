Public Class gestor_marcas_modelos

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Dim conexion As New Conexion
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim marca As New Data.DataTable
    Dim modelo As New Data.DataTable
    Dim buscando_marcas As Boolean = True
    Dim buscando_modelos As Boolean = True
    Dim auxiliar As Formulario_auxiliar_de_gestor_marcas
    Dim marca_a_modificar As String
    Dim modelo_a_modificar As String

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub gestor_marcas_modelos_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub gestor_marcas_modelos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla_marcas()
        Me.cargar_grilla_modelos()
    End Sub

    Private Sub cargar_grilla_marcas()
        Dim tabla As Data.DataTable = conexion.cargar_grilla("marcas")

        Me.tabla_marcas.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_marcas.Rows.Add()
            Me.tabla_marcas.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MARCA")
            Me.tabla_marcas.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
        Next
    End Sub

    Private Sub cargar_grilla_modelos()
        Dim tabla As Data.DataTable = conexion.cargar_grilla("modelos")

        Me.tabla_modelos.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_modelos.Rows.Add()
            Me.tabla_modelos.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MODELO")
            Me.tabla_modelos.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
        Next
    End Sub
    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nueva_marca.Click
        Me.txt_marcas.Text = ""
        Me.cmd_guardar_marca.Enabled = True
        Me.txt_marcas.Enabled = True
        Me.txt_marcas.Focus()
        Me.accion = tipo_grabacion.insertar
        Me.cargar_grilla_marcas()
        Me.buscando_marcas = False
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar_marca.Click
        If Me.buscando_marcas = False Then
            Me.grabar_marca(txt_marcas.Text)
            Me.buscando_marcas = True
        Else
            MessageBox.Show("Seleccione nueva marca antes de guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub


    Private Sub grabar_marca(ByVal nombre As String)
        If Me.conexion.buscar_marca(nombre.ToString).Rows.Count = 1 Then
            MessageBox.Show("La marca ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Me.accion = tipo_grabacion.insertar Then
                Try
                    Me.conexion.insertar_marca(nombre.ToString)
                    MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargar_grilla_marcas()

                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                If Me.conexion.buscar_marca(nombre.ToString).Rows.Count = 0 Then
                    Try
                        Me.conexion.modificar_marca(nombre.ToString, Me.marca_a_modificar)
                        MessageBox.Show("Se modifico correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargar_grilla_marcas()

                    Catch ex As OleDb.OleDbException
                        MessageBox.Show("No se modifico correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("La marca ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub



    Private Sub tabla_marcas_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_marcas.CellClick
        'Me.marca = conexion.buscar_marca(tabla_marcas.CurrentRow.Cells(1).Value)
        'Me.txt_marcas.Text = Me.marca.Rows(0).Item(1).ToString
        'Me.accion = tipo_grabacion.modificar
        If (tabla_marcas.RowCount = 0) Then
            Exit Sub
        End If
        Me.txt_marcas.Enabled = True

        Dim tabla As Data.DataTable = conexion.modelos_de_una_marca(Me.tabla_marcas.CurrentRow.Cells(1).Value)

        Me.tabla_modelos.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_modelos.Rows.Add()
            Me.tabla_modelos.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MODELO")
            Me.tabla_modelos.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
        Next
        Me.marca_a_modificar = ""
        Me.accion = tipo_grabacion.insertar
    End Sub

    Private Sub tabla_modelos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_modelos.CellClick
        'Me.modelo = conexion.buscar_modelo(tabla_modelos.CurrentRow.Cells(1).Value)
        'Me.txt_modelos.Text = Me.modelo.Rows(0).Item(1).ToString
        'Me.accion = tipo_grabacion.modificar
        'Me.cmd_eliminar.Enabled = True
        Me.txt_modelos.Enabled = True
        Me.modelo_a_modificar = ""
        Me.accion = tipo_grabacion.insertar
    End Sub

    Private Sub txt_marcas_Click(sender As Object, e As EventArgs) Handles txt_marcas.Click
        Me.buscando_marcas = True
    End Sub

    Private Sub txt_marcas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_marcas.KeyPress
        e.Handled = Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub



    Private Sub txt_marcas_TextChanged(sender As Object, e As EventArgs) Handles txt_marcas.TextChanged
        Me.cmd_guardar_marca.Enabled = True
        If Me.buscando_marcas <> False Then
            Dim tabla As Data.DataTable = Me.conexion.buscar_marcas_expRegular(txt_marcas.Text.ToString)

            tabla_marcas.Rows.Clear()

            Dim index As Integer
            For index = 0 To tabla.Rows.Count - 1

                Me.tabla_marcas.Rows.Add()
                Me.tabla_marcas.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MARCA")
                Me.tabla_marcas.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Next
        End If
    End Sub

    Private Sub txt_modelos_Click(sender As Object, e As EventArgs) Handles txt_modelos.Click
        Me.buscando_modelos = True
    End Sub

    Private Sub txt_modelos_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_modelos.KeyPress
        e.Handled = Not Char.IsLetterOrDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not Char.IsSeparator(e.KeyChar)
    End Sub

    Private Sub txt_modelos_TextChanged(sender As Object, e As EventArgs) Handles txt_modelos.TextChanged
        Me.cmd_guardar_modelo.Enabled = True
        If Me.buscando_modelos <> False Then
            Dim tabla As Data.DataTable = Me.conexion.buscar_modelos_expRegular(txt_modelos.Text.ToString)

            tabla_modelos.Rows.Clear()

            Dim index As Integer
            For index = 0 To tabla.Rows.Count - 1

                Me.tabla_modelos.Rows.Add()
                Me.tabla_modelos.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MODELO")
                Me.tabla_modelos.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Next
        End If
    End Sub

    Private Sub cmd_nuevo_modelo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo_modelo.Click
        Me.txt_modelos.Text = ""
        Me.cmd_guardar_modelo.Enabled = True
        Me.txt_modelos.Enabled = True
        Me.txt_modelos.Focus()
        Me.accion = tipo_grabacion.insertar
        Me.cargar_grilla_modelos()
        Me.buscando_modelos = False
    End Sub

    Private Sub cmd_guardar_modelo_Click(sender As Object, e As EventArgs) Handles cmd_guardar_modelo.Click
        If Me.buscando_modelos = False Then
            Me.grabar_modelo(txt_modelos.Text, Me.tabla_marcas.CurrentRow.Cells(0).Value)
            Me.buscando_modelos = True
        Else
            MessageBox.Show("Seleccione nuevo modelo antes de guardar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub grabar_modelo(ByVal nombre As String, ByVal id_marca As Integer)
        If Me.conexion.buscar_modelo(nombre.ToString).Rows.Count = 1 Then
            MessageBox.Show("El modelo ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Me.accion = tipo_grabacion.insertar Then
                Try
                    Me.conexion.insertar_modelo(nombre.ToString, id_marca)
                    MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargar_grilla_modelos()

                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                If Me.conexion.buscar_modelo(nombre.ToString).Rows.Count = 0 Then
                    Try
                        Me.conexion.modificar_modelo(nombre.ToString, Me.modelo_a_modificar)
                        MessageBox.Show("Se modifico correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargar_grilla_modelos()

                    Catch ex As OleDb.OleDbException
                        MessageBox.Show("No se modifico correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("El modelo ya existe ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub
    Private Sub tabla_modelos_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_modelos.CellDoubleClick
        Me.modelo = conexion.buscar_modelo(tabla_modelos.CurrentRow.Cells(1).Value)
        Me.txt_modelos.Text = Me.modelo.Rows(0).Item(1).ToString
        Me.accion = tipo_grabacion.modificar
        Me.modelo_a_modificar = Me.tabla_modelos.CurrentRow.Cells(0).Value
    End Sub

    Private Sub tabla_marcas_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_marcas.CellDoubleClick
        Me.marca = conexion.buscar_marca(tabla_marcas.CurrentRow.Cells(1).Value)
        Me.txt_marcas.Text = Me.marca.Rows(0).Item(1).ToString
        Me.accion = tipo_grabacion.modificar
        Me.marca_a_modificar = Me.tabla_marcas.CurrentRow.Cells(0).Value
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub
End Class