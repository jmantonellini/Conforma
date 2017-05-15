﻿Public Class gestor_pedidos
    Enum tipo_accion
        modificacion
        nuevo
        nulo
    End Enum

    Dim conexion As New Conexion
    Dim accion As tipo_accion = tipo_accion.nulo
    Dim contador As Int16 = 0
    Dim ventana_hija As Boolean = False


    Private Sub txt_observaciones_TextChanged(sender As Object, e As EventArgs) Handles txt_observaciones.Click, txt_observaciones.GotFocus
        txt_observaciones.Text = ""
        txt_observaciones.ForeColor = Color.Black
    End Sub


    Private Sub salirCruz(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If (accion <> tipo_accion.nulo) Then
            If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
                e.Cancel = True
            End If
        Else : e.Cancel = False
        End If
    End Sub

    Private Sub cmd_nuevo_cliente_Click(sender As Button, e As EventArgs) Handles cmd_nuevo_cliente.Click, cmd_nueva_marca.Click, cmd_nuevo_producto.Click
        Dim nuevo As Form = New Form
        Select Case sender.Name
            Case "cmd_nuevo_producto"
                nuevo = New gestor_tipo_producto_y_categorias
            Case "cmd_nueva_marca"
                nuevo = New gestor_marcas_modelos
            Case "cmd_nuevo_cliente"
                nuevo = New gestor_clientes
        End Select
        ventana_hija = True
        nuevo.Show()
        Me.ActivateMdiChild(nuevo)
    End Sub


    Private Sub deshabilitar_campos()
        For Each obj As Windows.Forms.Control In Me.Controls
            Select Case obj.GetType.Name
                Case "ComboBox"
                    obj.Enabled = False
                    Dim aux As ComboBox = obj
                    aux.SelectedIndex = -1
                    obj = aux
                Case "TextBox" Or "MaskedTextBox"
                    obj.Enabled = False
                    obj.Text = ""
            End Select
        Next
    End Sub

    Private Sub actualizar_combo_clientes()
        conexion.cargar_combo(cmb_cliente, " CLIENTES ", "ID_CLIENTE", "NOMBRE")
    End Sub

    Private Sub gestor_pedidos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmd_nuevo.Enabled = True
        cmd_guardar.Enabled = False
        cmd_salir.Enabled = True
        cmd_nueva_marca.Enabled = False
        cmd_nuevo_producto.Enabled = False
        cmd_nuevo_cliente.Enabled = False
        cmd_agregar_detalle.Enabled = False
        tabla_pedidos.DataSource = conexion.cargar_grilla("pedidos")
    End Sub

    Private Sub txt_perder_foco() Handles txt_observaciones.LostFocus
        If (txt_observaciones.Text = "") Then
            txt_observaciones.Text = "Observaciones.."
            txt_observaciones.ForeColor = Color.Gray
        End If
    End Sub

    Public Sub cargar_combos()
        conexion.cargar_combo(cmb_area, "AREAS", "ID_AREA", "NOMBRE")
        conexion.cargar_combo(cmb_categoria, "CATEGORIAS", "ID_CATEGORIA", "NOMBRE")
        conexion.cargar_combo(cmb_tipo_producto, "TIPOS_PRODUCTOS", "ID_TIPO_PRODUCTO", "NOMBRE")
        conexion.cargar_combo(cmb_marca, "MARCAS", "ID_MARCA", "NOMBRE")
        conexion.cargar_combo(cmb_modelo, "MODELOS", "ID_MODELO", "NOMBRE")
        conexion.cargar_combo(cmb_cliente, "CLIENTES", "ID_CLIENTE", "NRO_DOC")
        MsgBox("Combos cargados")
    End Sub

    Private Sub cmd_nuevo_Click_1(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        cmd_nuevo.Enabled = False
        cmd_guardar.Enabled = True
        cmd_nuevo_cliente.Enabled = True
        cmd_nueva_marca.Enabled = True
        cmd_nuevo_producto.Enabled = True
        cmd_agregar_detalle.Enabled = True
        Me.cargar_combos()
        accion = tipo_accion.nuevo
    End Sub

    Private Sub salir(sender As Object, e As EventArgs) Handles cmd_salir2.Click, cmd_salir.Click
        Me.Close()
    End Sub
End Class
