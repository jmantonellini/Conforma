Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum

<<<<<<< HEAD
    Dim cadena_conexion = "Provider=SQLNCLI11;Data Source=POWERSTATION-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"

=======
    Dim c As Conexion = New Conexion

>>>>>>> parent of f89051d... grilla empresas
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
<<<<<<< HEAD
        cargar_grilla()
        cargar_combo(cmb_tipo_documento, leer_tabla("TIPOS_DOCUMENTOS") _
                     , "ID_TIPO_DOCUMENTO" _
=======

        Me.cargar_grilla()
        cmb_tipo_documento = c.cargar_combo(cmb_tipo_documento, "TIPOS_DOCUMENTOS" _
                    , "ID_TIPO_DOCUMENTO" _
>>>>>>> parent of f89051d... grilla empresas
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

<<<<<<< HEAD
    Private Sub cargar_combo(ByRef combo As ComboBox _
                             , tabla As Data.DataTable _
                             , pk As String _
                             , descriptor As String)
        combo.DataSource = tabla
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
    End Sub
    Private Sub cargar_grilla()
        Dim tabla As New Data.DataTable
        tabla = Me.ejecuto_sql("SELECT C.NOMBRE, C.APELLIDO, C.CUIT, C.TEL_CEL FROM CLIENTES C")

        Dim index As Integer
        Me.tabla_clientes.Rows.Clear()

        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_clientes.Rows.Add()
            Me.tabla_clientes.Rows(index).Cells(0).Value = tabla.Rows(index)("APELLIDO")
            Me.tabla_clientes.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Me.tabla_clientes.Rows(index).Cells(2).Value = tabla.Rows(index)("CUIT") 'HAY QUE MODIFICAR EL CUIT POR EL NOMBRE DE LA EMPRESA
            Me.tabla_clientes.Rows(index).Cells(3).Value = tabla.Rows(index)("TEL_CEL")
        Next
    End Sub

    Private Function ejecuto_sql(ByVal sql As String) As Data.DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader)

        Return tabla
    End Function

    Private Function leer_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT * FROM " + nombre_tabla)
    End Function

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub
=======

    Private Sub cargar_grilla()
        Me.tabla_clientes.Rows.Clear()
        Me.tabla_clientes.Columns.Clear()
        Dim tabla = c.cargar_grilla("clientes")
        tabla_clientes.DataSource = tabla

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub


>>>>>>> parent of f89051d... grilla empresas
End Class