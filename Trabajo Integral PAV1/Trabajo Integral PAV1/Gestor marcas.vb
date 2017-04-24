Public Class gestor_marcas_modelos

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Dim conexion As New Conexion
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Dim marca As New Data.DataTable
    Dim modelo As New Data.DataTable
    Dim buscando As Boolean = False


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub


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
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
        Next
        Me.cmd_guardar_marca.Enabled = True
        Me.txt_marcas.Enabled = True
        Me.txt_marcas.Focus()
        Me.buscando = False
        Me.accion = tipo_grabacion.insertar
    End Sub

    Private Sub cmd_guardar_Click(sender As Object, e As EventArgs) Handles cmd_guardar_marca.Click
        If Me.conexion.buscar_marca(txt_marcas.Text.ToString).Rows.Count = 1 Then
            MessageBox.Show("La marca ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Me.accion = tipo_grabacion.insertar Then
                Try
                    Me.conexion.insertar_marca(Me.txt_marcas.Text.ToString)
                    MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargar_grilla_marcas()

                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                If Me.conexion.buscar_marca(txt_marcas.Text.ToString).Rows.Count = 0 Then
                    Try
                        Me.conexion.modificar_marca(Me.txt_marcas.Text.ToString, Me.tabla_marcas.CurrentRow.Cells(0).Value)
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
        Me.marca = conexion.buscar_marca(tabla_marcas.CurrentRow.Cells(1).Value)
        Me.txt_marcas.Text = Me.marca.Rows(0).Item(1).ToString
        Me.accion = tipo_grabacion.modificar
        'Me.cmd_eliminar.Enabled = True
        Me.txt_marcas.Enabled = True

        Dim tabla As Data.DataTable = conexion.modelos_de_una_marca(Me.tabla_marcas.CurrentRow.Cells(1).Value)

        Me.tabla_modelos.Rows.Clear()

        Dim index As Integer
        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_modelos.Rows.Add()
            Me.tabla_modelos.Rows(index).Cells(0).Value = tabla.Rows(index)("ID_MODELO")
            Me.tabla_modelos.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
        Next
    End Sub

    Private Sub tabla_modelos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_modelos.CellClick
        Me.modelo = conexion.buscar_modelo(tabla_marcas.CurrentRow.Cells(1).Value)
        Me.txt_modelos.Text = Me.modelo.Rows(0).Item(1).ToString
        Me.accion = tipo_grabacion.modificar
        'Me.cmd_eliminar.Enabled = True
        Me.txt_modelos.Enabled = True
    End Sub

    Private Sub btn_buscar_marcas_Click(sender As Object, e As EventArgs) Handles btn_buscar_marcas.Click
        If Me.buscando = True Then
            Me.buscando = False
            cargar_grilla_marcas()
        Else
            Me.buscando = True
            Me.txt_marcas.Text = ""
            Me.txt_marcas.Enabled = True
            Me.txt_marcas.Focus()
        End If
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_marcas.TextChanged
        Me.cmd_guardar_marca.Enabled = True
        If Me.buscando <> False Then
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

    Private Sub cmd_nuevo_modelo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo_modelo.Click
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
        Next
        Me.cmd_guardar_modelo.Enabled = True
        Me.txt_modelos.Enabled = True
        Me.txt_modelos.Focus()
        Me.buscando = False
        Me.accion = tipo_grabacion.insertar
    End Sub

    Private Sub cmd_guardar_modelo_Click(sender As Object, e As EventArgs) Handles cmd_guardar_modelo.Click
        If Me.conexion.buscar_modelo(txt_modelos.Text.ToString).Rows.Count = 1 Then
            MessageBox.Show("La marca ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else
            If Me.accion = tipo_grabacion.insertar Then
                Try
                    Me.conexion.insertar_modelo(Me.txt_modelos.Text.ToString)
                    MessageBox.Show("Se grabo correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Me.cargar_grilla_modelos()

                Catch ex As OleDb.OleDbException
                    MessageBox.Show("No se grabo correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                End Try
            Else
                If Me.conexion.buscar_modelo(txt_modelos.Text.ToString).Rows.Count = 0 Then
                    Try
                        Me.conexion.modificar_modelo(Me.txt_modelos.Text.ToString, Me.tabla_modelos.CurrentRow.Cells(0).Value)
                        MessageBox.Show("Se modifico correctamente", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Me.cargar_grilla_modelos()

                    Catch ex As OleDb.OleDbException
                        MessageBox.Show("No se modifico correctamente", "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error)
                    End Try
                Else
                    MessageBox.Show("La marca ya existe", "Grabacion", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            End If
        End If
    End Sub

    Private Sub cmd_buscar_modelos_Click(sender As Object, e As EventArgs) Handles cmd_buscar_modelos.Click

        If Me.buscando = True Then
            Me.buscando = False
            cargar_grilla_modelos()
        Else
            Me.buscando = True
            Me.txt_modelos.Text = ""
            Me.txt_modelos.Enabled = True
            Me.txt_modelos.Focus()
        End If     
    End Sub
End Class