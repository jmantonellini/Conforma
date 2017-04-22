Public Class gestor_empresas

    Dim c As Conexion = New Conexion
    Dim empresa As DataTable = New DataTable

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


        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
    End Sub

    Private Sub tablaEmpresas_Click(sender As Object, e As DataGridViewCellEventArgs) Handles tablaEmpresas.CellContentClick
        empresa.Clear()

        empresa = c.buscar_empresa(Me.tablaEmpresas.CurrentRow.Cells(1).Value)

        txt_cuit.Text = empresa.Rows(0).Item(0).ToString
        txt_nombre.Text = empresa.Rows(0).Item(1).ToString
        txt_razon_social.Text = empresa.Rows(0).Item(2).ToString
        txt_telefono_fijo.Text = empresa.Rows(0).Item(3).ToString
        txt_email.Text = empresa.Rows(0).Item(4).ToString

        cmd_modificar.Enabled = True
    End Sub

    Private Sub cmd_modificar_Click(sender As Object, e As EventArgs) Handles cmd_modificar.Click
        For Each obj As Windows.Forms.Control In Me.Controls
            If obj.GetType().Name = "TextBox" Then
                obj.Enabled = True
            End If
            If obj.GetType().Name = "ComboBox" Then
                obj.Enabled = True
            End If
            If obj.GetType().Name = "MaskedTextBox" Then
                obj.Enabled = True
            End If
        Next


        Me.cmd_guardar.Enabled = True
        Me.txt_nombre.Focus()
        Me.cmd_nuevo.Enabled = False


    End Sub

    Private Sub gestor_clientes_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        If MessageBox.Show("¿Seguro que desea salir? Los datos que no hayan sido guardados se perderan", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            e.Cancel = True
        End If
    End Sub
End Class