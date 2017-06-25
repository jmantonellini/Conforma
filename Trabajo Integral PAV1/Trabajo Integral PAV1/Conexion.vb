Public Class Conexion
    Dim cadena_conexion_mateo = "Provider=SQLNCLI11;Data Source=OCHANPC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_gaston = "Provider=SQLNCLI11;Data Source=POWERSTATION-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma1 = "Provider=SQLNCLI11;Data Source=JUANMA-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma2 = "Provider=SQLNCLI11;Data Source=POWERSTATION\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_gaston_note = "Provider=SQLNCLI11;Data Source=GASTONGARCIA\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"


    Public Function getNombreEquipo() As String
        Return My.Computer.Name.ToString()
    End Function

    ''' <summary>
    ''' Función que retorna la cadena de conexión correspondiente al nombre del equipo
    ''' </summary>
    ''' <returns>
    ''' Retorna la cadena de conexión
    ''' </returns>
    Public Function get_cadena_conexion()
        Dim cadena_conexion As String = ""

        Select Case getNombreEquipo() 'Creen sus cases con sus respectivos nombres de sus máquinas
            Case "GASTONGARCIA"
                cadena_conexion = Me.cadena_conexion_gaston_note
            Case "POWERSTATION-PC"
                cadena_conexion = Me.cadena_conexion_gaston
            Case "JUANMA-PC"
                cadena_conexion = Me.cadena_conexion_juanma1
            Case "POWERSTATION"
                cadena_conexion = Me.cadena_conexion_juanma2
            Case "OCHANPC"
                cadena_conexion = Me.cadena_conexion_mateo
        End Select

        Return cadena_conexion
    End Function

    Public Function cargar_grilla(ByVal ventana As String) As Data.DataTable
        Dim tabla As New Data.DataTable

        Select Case ventana
            Case "clientes"
                tabla = Me.ejecuto_sql("SELECT C.APELLIDO as 'Apellido', C.NOMBRE as 'Nombre', E.NOMBRE as 'Empresa', C.TEL_CEL as 'Celular', C.ID_CLIENTE as 'ID' FROM CLIENTES C LEFT JOIN EMPRESAS E ON E.CUIT = C.CUIT")
            Case "empresas"
                tabla = Me.ejecuto_sql("SELECT NOMBRE as 'Nombre' , CUIT as 'CUIT' FROM EMPRESAS")
            Case "paises"
                tabla = Me.ejecuto_sql("SELECT P.ID_PAIS, P.NOMBRE FROM PAISES P")
            Case "marcas"
                tabla = Me.ejecuto_sql("SELECT M.ID_MARCA, M.NOMBRE FROM MARCAS M")
            Case "modelos"
                tabla = Me.ejecuto_sql("SELECT M.ID_MODELO, M.NOMBRE FROM MODELOS M")
            Case "categorias"
                tabla = Me.ejecuto_sql("SELECT NOMBRE FROM CATEGORIAS")
            Case "pedidos"
                tabla = Me.ejecuto_sql("SELECT P.NRO_PEDIDO AS 'Nro.',C.NOMBRE AS 'Nombre',C.APELLIDO AS 'Apellido', " _
                                       & "P.FECHA_ENTREGA AS 'Fecha de entrega', COUNT(DP.ID_DETALLE_PEDIDO) AS 'Items', P.CANCELADO AS 'Cancelado' FROM CLIENTES C" _
                                       & " JOIN PEDIDOS P ON P.ID_CLIENTE = C.ID_CLIENTE" _
                                       & " JOIN DETALLES_PEDIDOS DP ON DP.NRO_PEDIDO = P.NRO_PEDIDO" _
                                       & " GROUP BY P.NRO_PEDIDO,C.NOMBRE,C.APELLIDO,P.FECHA_ENTREGA, P.CANCELADO") 'Se ha modificado la consulta para que muestre la columna cancelado
        End Select


        Return tabla
    End Function

    Private Function ejecuto_sql(ByVal sql As String) As Data.DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = Me.get_cadena_conexion()
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



    Public Function cargar_categorias_filtrada(ByVal nombre_tabla As String, filtro As String) As Data.DataTable

        Return ejecuto_sql("SELECT C.NOMBRE AS 'Nombre' FROM CATEGORIAS C JOIN TIPOS_PRODUCTOS TP ON C.ID_TIPO_PRODUCTO = TP.ID_TIPO_PRODUCTO WHERE TP.NOMBRE LIKE '" & filtro & "' ")

    End Function

    Public Function leer_areas_filtrada(ByVal nombre_tabla As String, descriptor As String, tabla2 As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT TP.ID_TIPO_PRODUCTO, TP.NOMBRE FROM AREAS A JOIN TIPOS_PRODUCTOS TP ON A.ID_AREA = TP.ID_AREA WHERE A.NOMBRE LIKE '" & descriptor & "'")
    End Function

    Public Function leer_paises_filtrada(ByVal nombre_tabla As String, descriptor As String, tabla2 As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT P.ID_PROVINCIA, P.NOMBRE FROM PROVINCIAS P JOIN PAISES PA ON P.ID_PAIS = PA.ID_PAIS WHERE PA.NOMBRE LIKE '" & descriptor & "'")
    End Function

    Public Function leer_provincias_filtrada(ByVal nombre_tabla As String, descriptor As String, tabla2 As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT C.ID_CIUDAD, C.NOMBRE FROM CIUDADES C JOIN PROVINCIAS P ON C.ID_PROVINCIA = P.ID_PROVINCIA WHERE P.NOMBRE LIKE '" & descriptor & "'")
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

    Public Function cargar_combo_flitrado(ByRef combo As ComboBox _
                             , tabla As String _
                             , pk As String _
                             , descriptor As String, filtro As String, tabla2 As String) As ComboBox
        Dim tablaFuente As Data.DataTable = leer_areas_filtrada(tabla, filtro, tabla2)
        combo.DataSource = tablaFuente
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        Return combo
    End Function

    Public Function carga_combo_generico_dos_tablas(ByRef combo As ComboBox, tabla_hija As String, pk As String _
                                         , nombre As String, tabla_padre As String, atributo_union As String, filtro As String)
        Dim tabla_fuentes As Data.DataTable = leer_tabla_filtrada_dos_tablas(tabla_hija, nombre, tabla_padre, atributo_union, filtro)
        combo.DataSource = tabla_fuentes
        combo.DisplayMember = nombre
        'combo.ValueMember = pk
        Return combo
    End Function

    Public Function cargar_combo_generico_filtrado(ByRef combo As ComboBox, tabla As String, pk As String _
                                                   , nombre As String, atributo_id As Integer)
        Dim tabla_fuente As DataTable = leer_tabla_filtrada_generica(tabla, pk, atributo_id, nombre)
        combo.DataSource = tabla_fuente
        'combo.ValueMember = pk
        combo.DisplayMember = nombre
        Return combo
    End Function

    Public Function leer_tabla_filtrada_generica(ByVal tabla As String, pk As String, atributo_id As Integer _
                                                 , nombre As String) As DataTable
        Dim tabla_fuente As DataTable = Me.ejecuto_sql("SELECT " & nombre & " FROM " & tabla & " WHERE " & pk & " = " & atributo_id)
        Return tabla_fuente
    End Function

    Public Function cargar_combo_generico_nombre(ByRef combo As ComboBox, tabla As String, pk As String _
                                                   , nombre As String, atributo_id As String)
        Dim tabla_fuente As DataTable = leer_tabla_filtrada_nombre(tabla, pk, atributo_id, nombre)
        combo.DataSource = tabla_fuente
        'combo.ValueMember = pk
        combo.DisplayMember = nombre
        Return combo
    End Function



    Public Function leer_tabla_filtrada_nombre(ByVal tabla As String, pk As String, atributo_id As String _
                                                 , nombre As String) As DataTable
        Dim tabla_fuente As DataTable = Me.ejecuto_sql("SELECT " & nombre & " FROM " & tabla & " WHERE " & pk & " like '" & atributo_id & "'")
        Return tabla_fuente
    End Function

    Public Function leer_tabla_filtrada_dos_tablas(ByVal tabla1 As String, nombre As String, tabla2 As String, atributo_union As String, filtro As String) As Data.DataTable
        Dim tabla As DataTable = Me.ejecuto_sql("SELECT T1." & nombre & " FROM " & tabla1 & " T1 JOIN " & tabla2 & " T2 ON T1." & atributo_union & " = T2." & atributo_union & " WHERE T2.NOMBRE LIKE '" & filtro & "'")
        Return tabla
    End Function

    Public Function cargar_combo_flitrado_provincia(ByRef combo As ComboBox _
                         , tabla As String _
                         , pk As String _
                         , descriptor As String, filtro As String, tabla2 As String) As ComboBox
        Dim tablaFuente As Data.DataTable = leer_paises_filtrada(tabla, filtro, tabla2)
        combo.DataSource = tablaFuente
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        Return combo
    End Function

    Public Function cargar_combo_flitrado_ciudad(ByRef combo As ComboBox _
                        , tabla As String _
                        , pk As String _
                        , descriptor As String, filtro As String, tabla2 As String) As ComboBox
        Dim tablaFuente As Data.DataTable = leer_provincias_filtrada(tabla, filtro, tabla2)
        combo.DataSource = tablaFuente
        combo.DisplayMember = descriptor
        combo.ValueMember = pk
        Return combo
    End Function

    Public Function buscar_datos_cliente_id(ByVal id_cliente As Int64) As Data.DataTable
        Dim cliente As DataTable = ejecuto_sql("SELECT * FROM CLIENTES WHERE ID_CLIENTE =" & id_cliente)
        Return cliente
    End Function

    Public Function buscar_datos_cliente_doc(ByVal tipo_doc As Int64, nro_doc As Int64) As Data.DataTable
        Dim cliente As DataTable = ejecuto_sql("SELECT * FROM CLIENTES WHERE ID_TIPO_DOCUMENTO = " & tipo_doc & " AND NRO_DOC = " & nro_doc)
        Return cliente
    End Function

    Public Function buscar_domicilio_cliente(ByVal id_cliente As Int64) As Data.DataTable
        Dim domicilio As DataTable = ejecuto_sql("Select D.CALLE, D.NUMERO, CI.NOMBRE, PA.NOMBRE, PR.NOMBRE from DOMICILIOS D RIGHT JOIN CLIENTES C ON C.ID_CLIENTE = D.ID_CLIENTE LEFT JOIN CIUDADES CI ON D.ID_CIUDAD = CI.ID_CIUDAD LEFT JOIN PROVINCIAS PR ON CI.ID_PROVINCIA = PR.ID_PROVINCIA LEFT JOIN PAISES PA ON PR.ID_PAIS = PA.ID_PAIS WHERE C.ID_CLIENTE =" & id_cliente)
        Return domicilio

    End Function

    Public Function tiene_domicilio(ByVal id_cliente As Int64) As Boolean
        Dim domicilio As DataTable = ejecuto_sql("Select D.* FROM DOMICILIOS D JOIN CLIENTES C ON C.ID_CLIENTE = D.ID_CLIENTE WHERE C.ID_CLIENTE =" & id_cliente)
        If domicilio.Rows.Count = 0 Then
            Return False
        Else : Return True
        End If
    End Function
    Public Function buscar_documento_cliente(ByVal nombre As String, apellido As String) As Data.DataTable
        Dim documento As DataTable = ejecuto_sql("Select T_D.* from TIPOS_DOCUMENTOS T_D RIGHT JOIN CLIENTES C ON C.ID_TIPO_DOCUMENTO = T_D.ID_TIPO_DOCUMENTO WHERE C.NOMBRE LIKE '" & nombre & "' AND C.APELLIDO LIKE '" & apellido & "' ")
        Return documento

    End Function

    Public Function buscar_empresa_cliente(ByVal nombre As String, apellido As String) As Data.DataTable
        Dim empresa As DataTable = ejecuto_sql("Select E.* from EMPRESAS E RIGHT JOIN CLIENTES C ON C.CUIT = E.CUIT WHERE C.NOMBRE LIKE '" & nombre & "' AND C.APELLIDO LIKE '" & apellido & "' ")
        Return empresa

    End Function

    Public Function buscar_empresa(ByVal cuit As Int64) As Data.DataTable
        Dim empresa As DataTable = ejecuto_sql("Select * FROM EMPRESAS WHERE CUIT =" & cuit)

        Return empresa

    End Function

    Public Function buscar_empresa_cuit(ByVal nombre As String) As Data.DataTable
        Dim empresa1 As DataTable = ejecuto_sql("Select CUIT FROM EMPRESAS WHERE NOMBRE LIKE '" & nombre & "'")

        Return empresa1

    End Function
    Public Sub modificar_empresa(ByVal cuit As Int64, nombre As String, razon_social As String, email As String, telefono As Int64)

        Me.ejecuto_sql("UPDATE EMPRESAS SET NOMBRE = '" & nombre & "' ,RAZON_SOCIAL = '" & razon_social & "', TELEFONO = " & telefono & ", EMAIL = '" & email & "' where CUIT = " & cuit)


    End Sub

    Public Sub insertar_cliente(ByVal nombre As String, apellido As String, tipo_documento As Int64, numero_documento As Int64, telefono_fijo As Int64?, telefono_celular As Int64?, email As String, cuit As Int64?)
        Dim celular_nulo As String = "NULL"
        Dim fijo_nulo As String = "NULL"
        Dim cuit_nulo As String = "NULL"
        If IsNothing(telefono_celular) And telefono_fijo IsNot Nothing And cuit IsNot Nothing Then
            Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & celular_nulo & ", " & telefono_fijo & ", " & cuit & ")")
        Else
            If IsNothing(telefono_fijo) And telefono_celular IsNot Nothing And cuit IsNot Nothing Then
                Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & telefono_celular & ", " & fijo_nulo & ", " & cuit & ")")
            Else
                If IsNothing(cuit) And telefono_celular IsNot Nothing And telefono_fijo IsNot Nothing Then
                    Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & telefono_celular & ", " & telefono_fijo & ", " & cuit_nulo & ")")
                Else
                    If IsNothing(telefono_celular) And IsNothing(telefono_fijo) Then
                        Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & celular_nulo & ", " & fijo_nulo & ", " & cuit & ")")
                    Else
                        If IsNothing(telefono_celular) And IsNothing(cuit) Then
                            Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & celular_nulo & ", " & telefono_fijo & ", " & cuit_nulo & ")")
                        Else
                            If IsNothing(telefono_fijo) And IsNothing(cuit) Then
                                Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & telefono_celular & ", " & fijo_nulo & ", " & cuit_nulo & ")")
                            Else : Me.ejecuto_sql("INSERT INTO CLIENTES VALUES (" & tipo_documento & ", " & numero_documento & ", '" & nombre & "', '" & apellido & "', '" & email & "', " & telefono_celular & ", " & telefono_fijo & ", " & cuit & ")")
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub

    Public Sub eliminar_cliente(ByVal id_cliente As Int64)
        Me.ejecuto_sql("DELETE FROM CLIENTES WHERE ID_CLIENTE = " & id_cliente)
    End Sub

    Public Sub eliminar_domicilio(ByVal id_cliente As Int64)
        Me.ejecuto_sql("DELETE FROM DOMICILIOS WHERE ID_CLIENTE = " & id_cliente)
    End Sub

    Public Sub modificar_cliente(ByVal id_cliente As Int64, nombre_nuevo As String, apellido_nuevo As String, nvo_tipo_doc As Int64, nuevo_documento As Int64, nuevo_cuit As Int64?, nuevo_celular As Int64?, nuevo_fijo As Int64?, nuevo_mail As String, nueva_ciudad As Int64?, nueva_calle As String, nuevo_nro As Int64?)
        Dim celular_nulo As String = "NULL"
        Dim fijo_nulo As String = "NULL"
        Dim cuit_nulo As String = "NULL"
        Dim numero_nulo As String = "NULL"
        If IsNothing(nuevo_celular) And nuevo_fijo IsNot Nothing And nuevo_cuit IsNot Nothing Then
            Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & celular_nulo & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
        Else
            If IsNothing(nuevo_fijo) And nuevo_celular IsNot Nothing And nuevo_cuit IsNot Nothing Then
                Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
            Else
                If IsNothing(nuevo_cuit) And nuevo_celular IsNot Nothing And nuevo_fijo IsNot Nothing Then
                    Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                Else
                    If IsNothing(nuevo_celular) And IsNothing(nuevo_fijo) Then
                        Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO = '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO = " & nvo_tipo_doc & ", NRO_DOC = " & nuevo_documento & ", CUIT = " & nuevo_cuit & ", TEL_CEL= " & celular_nulo & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                    Else
                        If IsNothing(nuevo_fijo) And IsNothing(nuevo_cuit) Then
                            Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                        Else
                            If IsNothing(nuevo_celular) And IsNothing(nuevo_cuit) Then
                                Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & celular_nulo & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                            Else : Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                            End If
                        End If
                    End If
                End If
            End If
        End If

        Me.ejecuto_sql("UPDATE DOMICILIOS SET ID_CIUDAD =" & nueva_ciudad & ", CALLE='" & nueva_calle & "', NUMERO=" & nuevo_nro & " WHERE ID_CLIENTE= " & id_cliente)



    End Sub


    Public Sub modificar_cliente_sin_domicilio(ByVal id_cliente As Int64, nombre_nuevo As String, apellido_nuevo As String, nvo_tipo_doc As Int64, nuevo_documento As Int64, nuevo_cuit As Int64?, nuevo_celular As Int64?, nuevo_fijo As Int64?, nuevo_mail As String)
        Dim celular_nulo As String = "NULL"
        Dim fijo_nulo As String = "NULL"
        Dim cuit_nulo As String = "NULL"
        If IsNothing(nuevo_celular) And nuevo_fijo IsNot Nothing And nuevo_cuit IsNot Nothing Then
            Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & celular_nulo & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
        Else
            If IsNothing(nuevo_fijo) And nuevo_celular IsNot Nothing And nuevo_cuit IsNot Nothing Then
                Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
            Else
                If IsNothing(nuevo_cuit) And nuevo_celular IsNot Nothing And nuevo_fijo IsNot Nothing Then
                    Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                Else
                    If IsNothing(nuevo_celular) And IsNothing(nuevo_fijo) Then
                        Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO = '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO = " & nvo_tipo_doc & ", NRO_DOC = " & nuevo_documento & ", CUIT = " & nuevo_cuit & ", TEL_CEL= " & celular_nulo & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                    Else
                        If IsNothing(nuevo_fijo) And IsNothing(nuevo_cuit) Then
                            Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & fijo_nulo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                        Else
                            If IsNothing(nuevo_celular) And IsNothing(nuevo_cuit) Then
                                Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & cuit_nulo & ", TEL_CEL=" & celular_nulo & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                            Else : Me.ejecuto_sql("UPDATE CLIENTES SET NOMBRE = '" & nombre_nuevo & "', APELLIDO= '" & apellido_nuevo & "', ID_TIPO_DOCUMENTO= " & nvo_tipo_doc & ", NRO_DOC= " & nuevo_documento & ", CUIT=" & nuevo_cuit & ", TEL_CEL=" & nuevo_celular & ", TEL_FIJO=" & nuevo_fijo & ", EMAIL='" & nuevo_mail & "' WHERE ID_CLIENTE = " & id_cliente)
                            End If
                        End If
                    End If
                End If
            End If
        End If
    End Sub




    Public Sub insertar_empresa(ByVal cuit As Int64, nombre As String, razon_social As String, email As String, telefono As Int64)

        Me.ejecuto_sql("INSERT INTO EMPRESAS VALUES (" & cuit & ", '" & nombre & "', '" & razon_social & "', " & telefono & ", '" & email & "')")

    End Sub

    Public Sub insertar_domicilio(ByVal id_cliente As Int64, calle As String, numero As Int64?, id_ciudad As Int64)
        Me.ejecuto_sql("INSERT INTO DOMICILIOS(ID_CLIENTE, CALLE, NUMERO, ID_CIUDAD) VALUES(" & id_cliente & ", '" & calle & "', " & numero & ", " & id_ciudad & ")")
    End Sub


    Public Function dame_id_cliente(ByVal tipo_doc As Int64, nro_doc As Int64) As Data.DataTable

        Dim id_cli As Data.DataTable = Me.ejecuto_sql("SELECT ID_CLIENTE FROM CLIENTES WHERE ID_TIPO_DOCUMENTO = " & tipo_doc & " AND NRO_DOC= " & nro_doc)

        Return id_cli
    End Function


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

    Public Function buscar_marca(ByVal nombre As String) As Data.DataTable
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
        Dim marcas As Data.DataTable = Me.ejecuto_sql("SELECT * FROM MARCAS WHERE NOMBRE LIKE " & "'" & patron & "%" & "'")

        Return marcas
    End Function

    Public Sub eliminar_marca(ByRef nombre As String)
        Me.ejecuto_sql("DELETE FROM MARCAS WHERE NOMBRE = " & "'" & nombre & "'")
    End Sub

    Public Function buscar_modelo(ByVal nombre As String) As Data.DataTable
        Dim modelo As Data.DataTable = Me.ejecuto_sql("SELECT M.* FROM MODELOS M WHERE M.NOMBRE LIKE " & "'" & nombre & "'")

        Return modelo
    End Function

    Public Sub insertar_modelo(ByRef nombre As String, ByRef id_marca As Integer)
        Me.ejecuto_sql("INSERT INTO MODELOS(NOMBRE, ID_MARCA) VALUES('" & nombre & "','" & id_marca & "')")
    End Sub

    Public Function buscar_modelos_expRegular(ByRef patron As String) As Data.DataTable
        Dim modelos As Data.DataTable = Me.ejecuto_sql("SELECT * FROM MODELOS WHERE NOMBRE LIKE " & "'" & patron & "%" & "'")

        Return modelos
    End Function

    Public Sub eliminar_modelo(ByRef nombre As String)
        Me.ejecuto_sql("DELETE FROM MODELOS WHERE NOMBRE = " & "'" & nombre & "'")
    End Sub

    Public Sub modificar_modelo(ByRef nombre_nuevo As String, ByRef id_modelo As Integer)
        Me.ejecuto_sql("UPDATE MODELOS SET NOMBRE = " & "'" & nombre_nuevo & "'" & "WHERE ID_MODELO = " & "'" & id_modelo & "'")
    End Sub

    Public Function modelos_de_una_marca(ByRef marca As String) As Data.DataTable
        Dim modelos As Data.DataTable = Me.ejecuto_sql("SELECT MO.ID_MODELO, MO.NOMBRE FROM MARCAS MA JOIN MODELOS MO ON MO.ID_MARCA = MA.ID_MARCA WHERE MA.NOMBRE = '" & marca & "'")

        Return modelos
    End Function

    Public Sub eliminar_empresa(ByRef empresa As String)
        Me.ejecuto_sql("DELETE FROM EMPRESAS WHERE CUIT = " & empresa)
    End Sub

    Public Sub insertar_area(ByVal nueva_area As String)
        Me.ejecuto_sql("INSERT INTO AREAS VALUES( '" & nueva_area & "')")
    End Sub

    Public Sub insertar_tipo_producto(ByVal nuevo_tipo As String, area As String)
        Dim id_area As Int16 = CInt(Me.ejecuto_sql("SELECT ID_AREA FROM AREAS WHERE NOMBRE LIKE '" & area & "'").Rows(0).Item(0).ToString)

        Me.ejecuto_sql("INSERT INTO TIPOS_PRODUCTOS VALUES(" & id_area & ",'" & nuevo_tipo & "')")
    End Sub

    Public Sub insertar_categoria(ByVal nueva_categoria As String, tipo_producto As String)
        Dim id_tipo As Int16 = CInt(Me.ejecuto_sql("SELECT ID_TIPO_PRODUCTO FROM TIPOS_PRODUCTOS WHERE NOMBRE LIKE '" & tipo_producto & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("INSERT INTO CATEGORIAS VALUES('" & nueva_categoria & "', " & id_tipo & ")")
    End Sub

    Public Sub cambiar_nombre(ByVal tabla As String, nuevo_nombre As String, nombre_viejo As String)
        Dim id_cadena As String = ""

        Select Case tabla
            Case " AREAS "
                id_cadena = "AREA"
            Case " TIPOS_PRODUCTOS "
                id_cadena = "TIPO_PRODUCTO"
            Case " CATEGORIAS "
                id_cadena = "CATEGORIA"
        End Select

        Dim id As Int16 = CInt(Me.ejecuto_sql("SELECT ID_" & id_cadena & " FROM " & tabla & " WHERE NOMBRE LIKE '" & nombre_viejo & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("UPDATE " & tabla & " SET NOMBRE = '" & nuevo_nombre & "' WHERE ID_" & id_cadena & " = " & id)
    End Sub

    Public Sub eliminar_nombre(ByVal tabla As String, filtro As String)
        Dim id_cadena As String = ""

        Select Case tabla
            Case " AREAS "
                id_cadena = "AREA"
            Case " TIPOS_PRODUCTOS "
                id_cadena = "TIPO_PRODUCTO"
            Case " CATEGORIAS "
                id_cadena = "CATEGORIA"
        End Select

        Dim id As Int16 = CInt(Me.ejecuto_sql("SELECT ID_" & id_cadena & " FROM " & tabla & " WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("DELETE FROM " & tabla & " WHERE ID_" & id_cadena & " = " & id)
    End Sub

    Public Function buscar_nombre(ByVal tabla As String, filtro As String)
        Dim id_cadena As String = ""
        If (CInt(Me.ejecuto_sql("SELECT COUNT(NOMBRE) FROM " & tabla & " WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString) = 0) Then
            Return True
        End If
        Return False
    End Function

    Public Function cargar_provincias_filtrada(ByVal pais As String) As Data.DataTable
        Return Me.ejecuto_sql("SELECT PR.NOMBRE AS 'Nombre' FROM PROVINCIAS PR JOIN PAISES P ON PR.ID_PAIS = P.ID_PAIS WHERE P.NOMBRE LIKE '" & pais & "'")
    End Function

    Public Sub insertar_provincia(ByVal provincia As String, pais As String)
        Dim id As Int16 = CInt(Me.ejecuto_sql("SELECT ID_PAIS FROM PAISES WHERE NOMBRE LIKE '" & pais & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("INSERT INTO PROVINCIAS VALUES ('" & provincia & "'," & id & ")")

    End Sub

    Public Sub elimnar_provincia(ByVal provincia As String)
        Me.ejecuto_sql("DELETE FROM PROVINCIAS WHERE NOMBRE LIKE '" & provincia & "'")
    End Sub

    Public Sub elimnar_localidad(ByVal provincia As String)
        Me.ejecuto_sql("DELETE FROM CIUDADES WHERE NOMBRE LIKE '" & provincia & "'")
    End Sub

    Public Sub cambiar_nombre_provincia(ByVal provincia As String, nombre_nuevo As String)
        Me.ejecuto_sql("UPDATE PROVINCIAS SET NOMBRE = '" & nombre_nuevo & "' WHERE NOMBRE LIKE '" & provincia & "'")
    End Sub

    Public Sub cambiar_nombre_localidad(ByVal provincia As String, nombre_nuevo As String)
        Me.ejecuto_sql("UPDATE CIUDADES SET NOMBRE = '" & nombre_nuevo & "' WHERE NOMBRE LIKE '" & provincia & "'")
    End Sub

    Public Function leer_localidades(ByVal provincia As String) As DataTable
        Dim id_provincia As Int16 = CInt(ejecuto_sql("SELECT ID_PROVINCIA FROM PROVINCIAS WHERE NOMBRE LIKE '" & provincia & "'").Rows(0).Item(0).ToString)
        Return Me.ejecuto_sql("SELECT NOMBRE AS 'Nombre', CODIGO_POSTAL AS 'Codigo Postal',ID_CIUDAD AS 'ID' FROM CIUDADES C  WHERE C.ID_PROVINCIA =" & id_provincia)
    End Function

    Public Function buscar_localidad(ByVal tabla As String, filtro As String, codigo_postal As Int16)
        Dim id_cadena As String = ""
        Dim id_provincia As Int16 = CInt(ejecuto_sql("SELECT ID_PROVINCIA FROM PROVINCIAS WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString)
        Return (Me.ejecuto_sql("SELECT * FROM " & tabla & " WHERE  ID_PROVINCIA = " & id_provincia & " AND CODIGO_POSTAL = " & codigo_postal).Rows.Count = 0)

    End Function

    Public Sub insertar_localidad(ByVal localidad As String, filtro As String, cp As Int16)
        Dim id_provincia As Int16 = CInt(ejecuto_sql("SELECT ID_PROVINCIA FROM PROVINCIAS WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("INSERT INTO CIUDADES VALUES('" & localidad & "'," & id_provincia & ", " & cp & ")")
    End Sub

    Public Function buscar_id_client(ByVal nro_doc As Int64) As Int16
        Return CInt(Me.leer_tabla_filtrada_generica("CLIENTES", "NRO_DOC", nro_doc, "ID_CLIENTE").Rows.Item(0).Item(0).ToString)
    End Function

    Public Function buscar_id_pedido(ByVal nro_doc As Int64, ByVal fecha_actual As Date) As Int16
        Dim id_cliente As Int16 = buscar_id_client(nro_doc)
        Dim id_pedido As Int16 = CInt(Me.ejecuto_sql("SELECT NRO_PEDIDO FROM PEDIDOS WHERE ID_CLIENTE = 1 AND DATEDIFF(day, FECHA_PEDIDO, CAST(GETDATE() AS DATE))<2").Rows.Item(0).Item(0).ToString)
        Return id_pedido
    End Function

    Public Function buscar_checkident(ByVal tabla As String) As Int16
        Return CInt(Me.ejecuto_sql("SELECT IDENT_CURRENT('" & tabla & "')").Rows(0)(0).ToString)
    End Function

    Public Function transaccion_pedidos(ByVal doc_cliente As Int64, ByVal fecha_entrega As Date, ByVal tabla_detalle As DataTable) As Boolean
        Dim transaccion_completa = False
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transaccion As OleDb.OleDbTransaction
        Dim cmd2 As New OleDb.OleDbCommand

        conexion.ConnectionString = cadena_conexion_mateo
        conexion.Open()

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        Dim id_pedido As Int16 = Me.buscar_checkident("PEDIDOS") + 1
        transaccion = conexion.BeginTransaction
        cmd.Transaction = transaccion
        Dim non_query As String = ""

        Try
            non_query = "INSERT INTO PEDIDOS VALUES(" & Me.buscar_id_client(doc_cliente) & ", CAST( GETDATE() AS DATE), '" & CDate(fecha_entrega).ToString("yyyy-MM-dd") & "',0)"
            cmd.CommandText = non_query
            cmd.ExecuteNonQuery()
            Dim i As Integer
            For i = 0 To tabla_detalle.Rows.Count - 1
                Dim area As String = tabla_detalle.Rows.Item(i).Item(1).ToString
                Dim tipo_producto As String = tabla_detalle.Rows.Item(i).Item(2).ToString
                Dim categoria As String = tabla_detalle.Rows.Item(i).Item(3).ToString
                Dim modelo As String = tabla_detalle.Rows.Item(i).Item(4).ToString
                Dim observaciones As String = tabla_detalle.Rows.Item(i).Item(5).ToString
                Dim cantidad As Int16 = tabla_detalle.Rows.Item(i).Item(6)

                Dim modelos_tabla As String = "NULL "
                Dim categorias_tabla As String = "NULL "
                Dim tipo_tabla As String = "NULL "
                'Verificaciones para categorias y modelos vacios'
                If (CInt(Me.leer_tabla_filtrada_nombre("MODELOS", "NOMBRE", modelo, "ID_MODELO").Rows.Count) > 0) Then
                    modelos_tabla = Me.leer_tabla_filtrada_nombre("MODELOS", "NOMBRE", modelo, "ID_MODELO").Rows(0)(0).ToString
                End If

                If (Me.leer_tabla_filtrada_nombre("TIPOS_PRODUCTOS", "NOMBRE", tipo_producto, "ID_TIPO_PRODUCTO").Rows.Count > 0) Then
                    tipo_tabla = Me.leer_tabla_filtrada_nombre("TIPOS_PRODUCTOS", "NOMBRE", tipo_producto, "ID_TIPO_PRODUCTO").Rows(0)(0).ToString
                End If

                If (CInt(Me.leer_tabla_filtrada_nombre("CATEGORIAS", "NOMBRE", categoria, "ID_CATEGORIA").Rows.Count) > 0) Then
                    categorias_tabla = CInt(Me.leer_tabla_filtrada_nombre("CATEGORIAS", "NOMBRE", categoria, "ID_CATEGORIA").Rows(0)(0).ToString)
                End If


                non_query = "INSERT INTO PRODUCTOS VALUES(" _
                    & CInt(Me.leer_tabla_filtrada_nombre("AREAS", "NOMBRE", area, "ID_AREA").Rows(0)(0).ToString) & ", " _
                    & tipo_tabla & ", " _
                    & modelos_tabla & ", " _
                    & categorias_tabla & ", " _
                    & "'" & observaciones & "')"
                cmd.CommandText = non_query
                cmd.ExecuteNonQuery()
                Dim id_producto As Int16 = CInt(Me.ejecuto_sql("SELECT IDENT_CURRENT( 'PRODUCTOS' )").Rows(0)(0))
                non_query = "INSERT INTO DETALLES_PEDIDOS VALUES( " & i + 1 & ", " & id_pedido & "," & id_producto & ", " & cantidad & ")"
                cmd.CommandText = non_query
                cmd.ExecuteNonQuery()
            Next
            transaccion.Commit()
            transaccion_completa = True
        Catch ex As Exception
            conexion.Close()
            MsgBox("FALLO LA TRANSACCION " & ex.Message & " EN " & ex.StackTrace)
            Me.ejecuto_sql("DBCC CHECKIDENT ('PEDIDOS', RESEED, " & id_pedido - 1 & ")")
        End Try
        conexion.Close()
        Return transaccion_completa
    End Function

    Public Function modificar_detalles(ByVal doc_cliente As Int64, ByVal fecha_entrega As Date, ByVal tabla_detalle As DataTable) As Boolean
        Dim transaccion_completa = False
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transaccion As OleDb.OleDbTransaction
        Dim cmd2 As New OleDb.OleDbCommand

        conexion.ConnectionString = get_cadena_conexion()
        conexion.Open()

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        Dim id_pedido As Int16 = Me.buscar_checkident("PEDIDOS")
        transaccion = conexion.BeginTransaction
        cmd.Transaction = transaccion
        Dim non_query As String = ""

        Try

            Me.ejecuto_sql("DELETE FROM DETALLES_PEDIDOS WHERE NRO_PEDIDO = " & id_pedido)
            Dim i As Integer
            For i = 0 To tabla_detalle.Rows.Count - 1
                Dim area As String = tabla_detalle.Rows.Item(i).Item(1).ToString
                Dim tipo_producto As String = tabla_detalle.Rows.Item(i).Item(2).ToString
                Dim categoria As String = tabla_detalle.Rows.Item(i).Item(3).ToString
                Dim modelo As String = tabla_detalle.Rows.Item(i).Item(4).ToString
                Dim observaciones As String = tabla_detalle.Rows.Item(i).Item(6).ToString
                Dim cantidad As Int16 = tabla_detalle.Rows.Item(i).Item(5)

                Dim modelos_tabla As String = "NULL "
                Dim categorias_tabla As String = "NULL "
                Dim tipo_tabla As String = "NULL "
                'Verificaciones para categorias y modelos vacios'
                If (CInt(Me.leer_tabla_filtrada_nombre("MODELOS", "NOMBRE", modelo, "ID_MODELO").Rows.Count) > 0) Then
                    modelos_tabla = Me.leer_tabla_filtrada_nombre("MODELOS", "NOMBRE", modelo, "ID_MODELO").Rows(0)(0).ToString
                End If

                If (Me.leer_tabla_filtrada_nombre("TIPOS_PRODUCTOS", "NOMBRE", tipo_producto, "ID_TIPO_PRODUCTO").Rows.Count > 0) Then
                    tipo_tabla = Me.leer_tabla_filtrada_nombre("TIPOS_PRODUCTOS", "NOMBRE", tipo_producto, "ID_TIPO_PRODUCTO").Rows(0)(0).ToString
                End If

                If (CInt(Me.leer_tabla_filtrada_nombre("CATEGORIAS", "NOMBRE", categoria, "ID_CATEGORIA").Rows.Count) > 0) Then
                    categorias_tabla = CInt(Me.leer_tabla_filtrada_nombre("CATEGORIAS", "NOMBRE", categoria, "ID_CATEGORIA").Rows(0)(0).ToString)
                End If


                non_query = "INSERT INTO PRODUCTOS VALUES(" _
                    & CInt(Me.leer_tabla_filtrada_nombre("AREAS", "NOMBRE", area, "ID_AREA").Rows(0)(0).ToString) & ", " _
                    & tipo_tabla & ", " _
                    & modelos_tabla & ", " _
                    & categorias_tabla & ", " _
                    & "'" & observaciones & "')"
                cmd.CommandText = non_query
                cmd.ExecuteNonQuery()
                Dim id_producto As Int16 = CInt(Me.ejecuto_sql("SELECT IDENT_CURRENT( 'PRODUCTOS' )").Rows(0)(0))
                non_query = "INSERT INTO DETALLES_PEDIDOS VALUES( " & i + 1 & ", " & id_pedido & "," & id_producto & ", " & cantidad & ")"
                cmd.CommandText = non_query
                cmd.ExecuteNonQuery()
            Next
            transaccion.Commit()
            transaccion_completa = True
        Catch ex As Exception
            conexion.Close()
            MsgBox("FALLO LA TRANSACCION " & ex.Message & " EN " & ex.StackTrace)
        End Try
        conexion.Close()
        Return transaccion_completa
    End Function
    ''' <summary>
    ''' Función que cancela un pedido, cambia el valor de la columna cancelado a 1 que significa que esta cancelado y 0 que no lo está
    ''' </summary>
    ''' <param name="nro_pedido">
    ''' El id del pedido a cancelar
    ''' </param>
    ''' <returns>
    ''' Retorna true si se logro cancelar con éxito, retorna false en caso contrario
    ''' </returns>
    Public Function cancelar_pedido(ByVal nro_pedido As Integer) As Boolean
        Dim transaccion_completa As Boolean = False 'Variable de retorno de la función

        'Conexión con la base de datos y el inicio de la transacción
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transaccion As OleDb.OleDbTransaction
        Dim cmd2 As New OleDb.OleDbCommand

        conexion.ConnectionString = Me.get_cadena_conexion()
        conexion.Open()

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        transaccion = conexion.BeginTransaction
        cmd.Transaction = transaccion
        Dim non_query As String = "UPDATE PEDIDOS SET CANCELADO = " & 1 & " WHERE NRO_PEDIDO = " & nro_pedido 'Consulta para cancelar un pedido

        Try
            cmd.CommandText = non_query
            cmd.ExecuteNonQuery()
            transaccion.Commit()
            transaccion_completa = True
        Catch ex As Exception
            conexion.Close()
            MsgBox("FALLO LA TRANSACCION " & ex.Message & " EN " & ex.StackTrace)
        End Try
        conexion.Close()

        Return transaccion_completa
    End Function

    ''' <summary>
    ''' Función que elimina un detalle de pedido
    ''' </summary>
    ''' <param name="nro_pedido">
    ''' El número de pedido a eliminar su detalle
    ''' </param>
    ''' <param name="id_detalle">
    ''' El número identificador del detalle de pedido a eliminar
    ''' </param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Function eliminar_detalle(ByVal nro_pedido, ByVal id_detalle) As Boolean
        Dim transaccion_completa As Boolean = True

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transaccion As OleDb.OleDbTransaction
        Dim cmd2 As New OleDb.OleDbCommand

        conexion.ConnectionString = Me.get_cadena_conexion()
        conexion.Open()

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        transaccion = conexion.BeginTransaction
        cmd.Transaction = transaccion
        Dim non_query As String = "DELETE FROM DETALLES_PEDIDOS WHERE NRO_PEDIDO = " & nro_pedido & "AND ID_DETALLE_PEDIDO = " & id_detalle  'Consulta para eliminar el detalle de un pedido"

        Try
            cmd.CommandText = non_query
            cmd.ExecuteNonQuery()
            transaccion.Commit()
            conexion.Close()
            transaccion_completa = True

        Catch ex As Exception
            conexion.Close()
            MsgBox("FALLO LA TRANSACCION " & ex.Message & " EN " & ex.StackTrace)
        End Try

        conexion.Close()

        Return transaccion_completa
    End Function

    ''' <summary>
    ''' Función que permite habilitar un pedido
    ''' </summary>
    ''' <param name="nro_pedido">
    ''' Número de pedido a habilitar
    ''' </param>
    Public Function habilitar_pedido(ByVal nro_pedido As Integer) As Boolean
        Dim transaccion_completa As Boolean = True

        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim transaccion As OleDb.OleDbTransaction
        Dim cmd2 As New OleDb.OleDbCommand

        conexion.ConnectionString = Me.get_cadena_conexion()
        conexion.Open()

        cmd.Connection = conexion
        cmd.CommandType = CommandType.Text
        transaccion = conexion.BeginTransaction
        cmd.Transaction = transaccion
        Dim non_query As String = "UPDATE PEDIDOS SET CANCELADO = " & 0 & " WHERE NRO_PEDIDO = " & nro_pedido 'Consulta para eliminar el detalle de un pedido"

        Try
            cmd.CommandText = non_query
            cmd.ExecuteNonQuery()
            transaccion.Commit()
            conexion.Close()
            transaccion_completa = True

        Catch ex As Exception
            conexion.Close()
            MsgBox("FALLO LA TRANSACCION " & ex.Message & " EN " & ex.StackTrace)
        End Try

        conexion.Close()

        Return transaccion_completa

    End Function

    Public Function tabla_listado_clientes(ByVal filtro As String) As Data.DataTable
        Dim sql As String = ""
        sql = "SELECT * FROM CLIENTES WHERE CLIENTES.APELLIDO LIKE '" & filtro & "%'"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_listado_pedidos(ByVal filtro As String) As Data.DataTable
        Dim sql As String = ""
        sql = "SELECT P.NRO_PEDIDO, DETALLES_PEDIDOS.ID_DETALLE_PEDIDO, A.NOMBRE as 'NOMBRE_AREA', TIPO.NOMBRE AS 'NOMBRE_PRODUCTO', P.FECHA_PEDIDO, P.FECHA_ENTREGA, DETALLES_PEDIDOS.CANTIDAD,PRODUCTOS.OBSERVACIONES"
        sql &= " FROM PEDIDOS P JOIN DETALLES_PEDIDOS ON DETALLES_PEDIDOS.NRO_PEDIDO = P.NRO_PEDIDO"
        sql &= " JOIN PRODUCTOS ON DETALLES_PEDIDOS.ID_PRODUCTO = PRODUCTOS.ID_PRODUCTO"
        sql &= " JOIN AREAS A ON PRODUCTOS.ID_AREA = A.ID_AREA"
        sql &= " JOIN TIPOS_PRODUCTOS TIPO ON PRODUCTOS.ID_TIPO_PRODUCTO = TIPO.ID_TIPO_PRODUCTO"
        sql &= " WHERE P.NRO_PEDIDO LIKE '%" & filtro & "%'"
        sql &= " ORDER BY 2"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_listado_productos(ByVal filtro As String) As Data.DataTable
        Dim sql As String = ""

        sql &= "select distinct A.NOMBRE as 'Area',TP.NOMBRE as 'Tipo',C.NOMBRE as 'Categoria',MA.NOMBRE as 'Marca' from TIPOS_PRODUCTOS TP join AREAS A ON TP.ID_AREA = A.ID_AREA"
        sql &= " join PRODUCTOS P on P.ID_TIPO_PRODUCTO=TP.ID_TIPO_PRODUCTO"
        sql &= " left join MODELOS M ON M.ID_MODELO = P.ID_MODELO"
        sql &= " left join MARCAS MA ON MA.ID_MARCA = M.ID_MARCA"
        sql &= " left join CATEGORIAS C on C.ID_CATEGORIA=P.ID_CATEGORIA"
        sql &= " where A.NOMBRE like '" & filtro & "%'"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_listado_paises_provincias() As Data.DataTable
        Dim sql As String = ""

        sql &= "SELECT P.NOMBRE AS 'NOMBRE_PAIS', PR.NOMBRE AS 'NOMBRE_PROVINCIA', COUNT(C.NOMBRE) AS 'CANT_LOCALIDADES'"
        sql &= " FROM PAISES P JOIN PROVINCIAS PR ON P.ID_PAIS = PR.ID_PAIS LEFT JOIN CIUDADES C ON C.ID_PROVINCIA = PR.ID_PROVINCIA"
        sql &= " GROUP BY P.NOMBRE, PR.NOMBRE"
        sql &= " ORDER BY P.NOMBRE,3 DESC"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_pedidos_por_cliente(ByVal filtro As String) As Data.DataTable
        Dim sql As String = "SELECT C.ID_CLIENTE AS 'CLIENTE',C.NOMBRE as 'NOMBRE',C.APELLIDO AS 'APELLIDO',P.NRO_PEDIDO AS 'NRO_PEDIDO',P.FECHA_ENTREGA AS 'FECHA_ENTREGA',COUNT(DP.ID_DETALLE_PEDIDO) AS 'CANTIDAD_ITEMS' FROM PEDIDOS P" _
                            & " RIGHT JOIN CLIENTES C ON C.ID_CLIENTE = P.ID_CLIENTE " _
                            & " LEFT JOIN DETALLES_PEDIDOS DP ON DP.NRO_PEDIDO = P.NRO_PEDIDO " _
                            & " WHERE C.APELLIDO LIKE '" & filtro & "%'" _
                            & " GROUP BY C.ID_CLIENTE,C.NOMBRE,C.APELLIDO,P.NRO_PEDIDO,P.FECHA_ENTREGA"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_empresas(ByVal filtro As String) As Data.DataTable
        Dim sql As String = "SELECT NOMBRE,CUIT,RAZON_SOCIAL,TELEFONO,EMAIL FROM EMPRESAS WHERE NOMBRE LIKE '" & filtro & "%'"
        Return Me.ejecuto_sql(sql)
    End Function

    Public Function tabla_clientes_por_empresa(ByVal filtro As String) As Data.DataTable
        Dim sql As String = "SELECT E.CUIT,E.NOMBRE AS 'NOMBRE_EMPRESA',C.NOMBRE AS 'NOMBRE_CLIENTE',C.APELLIDO AS 'APELLIDO_CLIENTE',C.EMAIL AS 'EMAIL_CLIENTE',C.TEL_CEL as 'TEL_CEL' " _
                            & " FROM EMPRESAS E JOIN CLIENTES C ON E.CUIT = C.CUIT " _
                            & " WHERE E.NOMBRE LIKE '" & filtro & "%' " _
                            & " GROUP BY E.CUIT,E.NOMBRE,C.NOMBRE,C.APELLIDO,C.EMAIL,C.TEL_CEL " _
                            & " ORDER BY 2"
        Return Me.ejecuto_sql(sql)
    End Function

    Public Function grafico_pedidos_cancelados() As Data.DataTable
        Dim sql As String = "SELECT COUNT(*) AS 'CANTIDAD' FROM PEDIDOS WHERE CANCELADO = 0"
        sql &= " UNION"
        sql &= " SELECT COUNT(*) AS 'CANT_CANCELADOS' FROM PEDIDOS WHERE CANCELADO = 1"

        Return Me.ejecuto_sql(sql)
    End Function

    Public Function grafico_pedidos_productos() As Data.DataTable
        Dim sql As String = "SELECT TP.NOMBRE AS 'TIPO_PRODUCTO', COUNT(*) AS 'CANTIDAD' FROM PEDIDOS JOIN DETALLES_PEDIDOS ON PEDIDOS.NRO_PEDIDO ="
        sql &= " DETALLES_PEDIDOS.NRO_PEDIDO JOIN PRODUCTOS ON DETALLES_PEDIDOS.ID_PRODUCTO = PRODUCTOS.ID_PRODUCTO"
        sql &= " JOIN TIPOS_PRODUCTOS TP ON PRODUCTOS.ID_TIPO_PRODUCTO = TP.ID_TIPO_PRODUCTO"
        sql &= " GROUP BY TP.NOMBRE"

        Return Me.ejecuto_sql(sql)
    End Function
End Class
