Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Dim cliente As Data.DataTable = New DataTable
    Dim domicilios As DataTable = New DataTable
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
        cmb_pais = c.cargar_combo(cmb_pais, "PAISES", "ID_PAIS", "NOMBRE")
        tabla_clientes.Rows(0).Selected = True
        'Me.cargar_cliente()
        domicilios = c.buscar_domicilios_cliente(tabla_clientes.Item(0, 1).Value, tabla_clientes.Item(0, 0).Value)
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        limpiar_campos()
        Me.accion = tipo_grabacion.insertar
        Me.cmd_modificar.Enabled = False
        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


    Private Sub cargar_grilla()
        Me.tabla_clientes.Rows.Clear()
        Me.tabla_clientes.Columns.Clear()
        Dim tabla = c.cargar_grilla("clientes")
        tabla_clientes.DataSource = tabla

    End Sub
    Private Sub limpiar_campos()
        For Each obj As Windows.Forms.Control In Me.tab_datos_personales.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_domicilios.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
        For Each obj As Windows.Forms.Control In Me.tab_contacto.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                Dim local As ComboBox = obj
                local.SelectedIndex = -1
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Text = ""
                obj.Enabled = True
            End If
        Next
    End Sub


    Private Sub tabla_clientes_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tabla_clientes.CellClick
        cargar_cliente()
        cmd_modificar.Enabled = True
        cmd_eliminar.Enabled = True

    End Sub

    Private Sub cargar_cliente()

        cliente = c.buscar_datos_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)
        domicilios = c.buscar_domicilios_cliente(tabla_clientes.CurrentRow.Cells(1).Value, tabla_clientes.CurrentRow.Cells(0).Value)


        txt_nombre.Text = cliente.Rows(0).Item(3).ToString
        txt_apellido.Text = cliente.Rows(0).Item(4).ToString
        txt_documento.Text = cliente.Rows(0).Item(2).ToString
        txt_cuit.Text = cliente.Rows(0).Item(8).ToString
        txt_celular.Text = cliente.Rows(0).Item(6).ToString
        txt_fijo.Text = cliente.Rows(0).Item(7).ToString



    End Sub

End Class