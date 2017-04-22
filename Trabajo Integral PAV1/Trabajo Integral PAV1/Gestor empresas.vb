Public Class gestor_empresas

<<<<<<< HEAD
=======

    Dim c As Conexion = New Conexion

>>>>>>> parent of f89051d... grilla empresas
    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbl_hora.Text = DateTime.Now.ToString("dd/mm/yyyy HH:mm:ss ")
    End Sub

    Private Sub cmd_salir_Click(sender As Object, e As EventArgs) Handles cmd_salir.Click
        Me.Close()

    End Sub
<<<<<<< HEAD
=======

   
    Private Sub gestor_empresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim tabla As Data.DataTable = New DataTable
        tablaEmpresas.DataSource = c.cargar_grilla("empresas")

    End Sub
>>>>>>> parent of f89051d... grilla empresas
End Class