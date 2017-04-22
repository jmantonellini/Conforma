Public Class gestor_empresas

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Dim cadena_conexion As String = "Provider=SQLNCLI11;Data Source=POWERSTATION-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim accion As tipo_grabacion = tipo_grabacion.insertar
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
        For Each obj As Windows.Forms.Control In Me.Controls
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
        Me.txt_nombre.Focus()
        Me.accion = tipo_grabacion.insertar
        Me.cmd_modificar.Enabled = True
    End Sub

    Private Sub gestor_empresas_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub

    Private Sub cargar_grilla()
        Dim tabla As New Data.DataTable
        tabla = Me.ejecuto_sql("SELECT * FROM EMPRESAS")

        Dim index As Integer
        Me.tabla_empresas.Rows.Clear()

        For index = 0 To tabla.Rows.Count - 1

            Me.tabla_empresas.Rows.Add()
            Me.tabla_empresas.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Me.tabla_empresas.Rows(index).Cells(2).Value = tabla.Rows(index)("RAZON_SOCIAL")
            Me.tabla_empresas.Rows(index).Cells(3).Value = tabla.Rows(index)("TELEFONO") 'HAY QUE MODIFICAR EL CUIT POR EL NOMBRE DE LA EMPRESA
            Me.tabla_empresas.Rows(index).Cells(4).Value = tabla.Rows(index)("EMAIL")
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
    Private Sub gestor_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.cargar_grilla()
    End Sub
End Class