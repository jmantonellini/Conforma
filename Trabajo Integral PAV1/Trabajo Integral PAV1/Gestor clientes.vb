Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum

   Dim c As Conexion = New Conexion

    Dim accion As tipo_grabacion = tipo_grabacion.insertar

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub gestor_clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub


    Private Sub gestor_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.cargar_grilla()
        cmb_tipo_documento = c.cargar_combo(cmb_tipo_documento, "TIPOS_DOCUMENTOS" _
                    , "ID_TIPO_DOCUMENTO" _
                     , "NOMBRE")
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
            End If
        Next
        Me.accion = tipo_grabacion.insertar
        Me.cmd_guardar.Enabled = True
        Me.cmd_modificar.Enabled = True
        Me.txt_nombre.Focus()
    End Sub

    
    Private Sub cargar_grilla()
        Me.tabla_clientes.Rows.Clear()
        Me.tabla_clientes.Columns.Clear()
        Dim tabla = c.cargar_grilla("clientes")
        tabla_clientes.DataSource = tabla

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


End Class