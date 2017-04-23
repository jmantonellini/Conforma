Public Class gestor_clientes

    Enum tipo_grabacion
        insertar
        modificar
    End Enum

    Enum respuesta_validacion
        _ok
        _error
    End Enum

    Dim cadena_conexion = "Provider=SQLNCLI11;Data Source=JUANMA-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
   


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub


    Private Sub tab_datos_personales_Click(sender As Object, e As EventArgs) Handles tab_datos_personales.Click

    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()
    End Sub

    Private Sub cmd_nuevo_Click(sender As Object, e As EventArgs) Handles cmd_nuevo.Click
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
    End Sub

    Private Sub cargar_clientes()
        Dim tabla As New DataTable

        Dim index As Integer
        Me.tabla_clientes.Rows.Clear()

        For index = 0 To tabla.Rows.Count - 1
            Me.tabla_clientes.Rows.Add()
            Me.tabla_clientes.Rows(index).Cells(0).Value = tabla.Rows(index)("APELLIDO")
            Me.tabla_clientes.Rows(index).Cells(1).Value = tabla.Rows(index)("NOMBRE")
            Me.tabla_clientes.Rows(index).Cells(2).Value = tabla.Rows(index)("CUIL_EMPRESA")
            Me.tabla_clientes.Rows(index).Cells(3).Value = tabla.Rows(index)("TELEFONO_CELULAR")
        Next




    End Sub

    Private Function leer_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return Conexion.ejecuto_sql("SELECT * " + nombre_tabla)
    End Function

    Private Sub gestor_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_clientes()

    End Sub
End Class