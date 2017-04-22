Public Class gestor_empresas

    Dim c As Conexion = New Conexion

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub


    Private Sub gestor_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As Data.DataTable = New DataTable
        tablaEmpresas.DataSource = c.cargar_grilla("empresas")

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


        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
    End Sub
End Class