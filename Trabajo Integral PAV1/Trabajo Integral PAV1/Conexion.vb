Public Class Conexion
    Dim cadena_conexion_mateo = "Provider=SQLNCLI11;Data Source=OCHANPC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_gaston = "Provider=SQLNCLI11;Data Source=POWERSTATION-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma1 = "Provider=SQLNCLI11;Data Source=JUANMA-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma2 = "Provider=SQLNCLI11;Data Source=POWERSTATION\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"

    Public Function cargar_grilla(ByVal ventana As String) As Data.DataTable
        Dim tabla As New Data.DataTable

        Select Case ventana
            Case "clientes"
                tabla = Me.ejecuto_sql("SELECT C.APELLIDO as 'Apellido', C.NOMBRE as 'Nombre', E.NOMBRE as 'Empresa', C.TEL_CEL as 'Celular' FROM CLIENTES C LEFT JOIN EMPRESAS E ON E.CUIT = C.CUIT")
            Case "empresas"
                tabla = Me.ejecuto_sql("SELECT NOMBRE as 'Nombre' , CUIT as 'CUIT' FROM EMPRESAS")
            Case "paises"
                tabla = Me.ejecuto_sql("SELECT P.ID_PAIS, P.NOMBRE FROM PAISES P")
            Case "marcas"
                tabla = Me.ejecuto_sql("SELECT M.ID_MARCA, M.NOMBRE FROM MARCAS M")

        End Select


        Return tabla
    End Function

    Private Function ejecuto_sql(ByVal sql As String) As Data.DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion_juanma2
        conexion.Open()
        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        tabla.Load(cmd.ExecuteReader)
        conexion.Close()
        Return tabla
    End Function

    Public Function leer_tabla(ByVal nombre_tabla As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT * FROM " + nombre_tabla)
    End Function

    Public Function cargar_combo(ByRef combo As ComboBox _
                             , tabla As String _
                             , pk As String _
                             , descriptor As String) As ComboBox
        Dim tablaFuente As Data.DataTable = leer_tabla(tabla)
        combo.DataSource = tablaFuente
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        Return combo
    End Function

    Public Function buscar_datos_cliente(ByVal nombre As String, apellido As String) As Data.DataTable
        Dim cliente As DataTable = ejecuto_sql("SELECT C.* FROM CLIENTES  C LEFT JOIN EMPRESAS E ON C.CUIT = E.CUIT where C.NOMBRE LIKE '" & nombre & "' AND C.APELLIDO LIKE '" & apellido & "' ")
        Return cliente
    End Function

    Public Function buscar_domicilios_cliente(ByVal nombre As String, apellido As String) As Data.DataTable
        Dim domicilios As DataTable = ejecuto_sql("Select D.* from DOMICILIOS D RIGHT JOIN CLIENTES C ON C.ID_CLIENTE = D.ID_CLIENTE WHERE C.NOMBRE LIKE '" & nombre & "' AND C.APELLIDO LIKE '" & apellido & "' ")
        Return domicilios

    End Function

    Public Function buscar_empresa(ByVal cuit As Int64) As Data.DataTable
        Dim empresa As DataTable = ejecuto_sql("Select * FROM EMPRESAS WHERE CUIT =" & cuit)

        Return empresa

    End Function

    Public Sub modificar_empresa(ByVal cuit As Int64, nombre As String, razon_social As String, email As String, telefono As Int64)

        Me.ejecuto_sql("UPDATE EMPRESAS SET NOMBRE = '" & nombre & "' ,RAZON_SOCIAL = '" & razon_social & "', TELEFONO = " & telefono & ", EMAIL = '" & email & "' where CUIT = " & cuit)


    End Sub

    Public Sub insertar_cliente(ByVal nombre As String, apellido As String, tipo_documento As Int64, numero_documento As Int64, telefono_fijo As Int64, telefono_celular As Int64, email As String)

        Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & telefono_celular & ", " & telefono_fijo & ")")

    End Sub

    Public Sub insertar_empresa(ByVal cuit As Int64, nombre As String, razon_social As String, email As String, telefono As Int64)

        Me.ejecuto_sql("INSERT INTO EMPRESAS VALUES (" & cuit & ", '" & nombre & "', '" & razon_social & "', " & telefono & ", '" & email & "')")


    End Sub

    Public Function buscar_paises(ByVal nombre As String) As Data.DataTable
        Dim pais As Data.DataTable = Me.ejecuto_sql("SELECT P.* FROM PAISES P WHERE P.NOMBRE = " & "'" & nombre & "'")

        Return pais
    End Function

    Public Sub insertar_pais(ByRef nombre As String)
        Me.ejecuto_sql("INSERT INTO PAISES VALUES('" & nombre & "')")
    End Sub

    Public Sub modificar_pais(ByRef nombre_nuevo As String, ByRef id_pais As Integer)
        Me.ejecuto_sql("UPDATE PAISES SET NOMBRE = " & "'" & nombre_nuevo & "'" & "WHERE ID_PAIS = " & "'" & id_pais & "'")
    End Sub

    Public Function buscar_paises_expRegular(ByRef patron As String) As Data.DataTable
        Dim paises As Data.DataTable = Me.ejecuto_sql("SELECT * FROM PAISES WHERE NOMBRE LIKE " & "'" & patron & "%" & "'")

        Return paises
    End Function

    Public Sub eliminar_pais(ByRef nombre As String)
        Me.ejecuto_sql("DELETE FROM PAISES WHERE NOMBRE = " & "'" & nombre & "'")
    End Sub

    Public Function buscar_marcas(ByVal nombre As String) As Data.DataTable
        Dim marca As Data.DataTable = Me.ejecuto_sql("SELECT M.* FROM MARCAS M WHERE M.NOMBRE = " & "'" & nombre & "'")

        Return marca
    End Function

    Public Sub insertar_marca(ByRef nombre As String)
        Me.ejecuto_sql("INSERT INTO MARCAS VALUES(" & "'" & nombre & "'" & ")")
    End Sub

    Public Sub modificar_marca(ByRef nombre_nuevo As String, ByRef id_marca As Integer)
        Me.ejecuto_sql("UPDATE MARCAS SET NOMBRE = " & "'" & nombre_nuevo & "'" & "WHERE ID_MARCA = " & "'" & id_marca & "'")
    End Sub

    Public Function buscar_marcas_expRegular(ByRef patron As String) As Data.DataTable
        Dim paises As Data.DataTable = Me.ejecuto_sql("SELECT * FROM MARCAS WHERE NOMBRE LIKE " & "'" & patron & "%" & "'")

        Return paises
    End Function

    Public Sub eliminar_marca(ByRef nombre As String)
        Me.ejecuto_sql("DELETE FROM MARCAS WHERE NOMBRE = " & "'" & nombre & "'")
    End Sub
End Class
