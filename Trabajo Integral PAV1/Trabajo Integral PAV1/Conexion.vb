Public Class Conexion
    Dim cadena_conexion_mateo = "Provider=SQLNCLI11;Data Source=OCHANPC\SQLEXPRESS;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_gaston = "Provider=SQLNCLI11;Data Source=POWERSTATION-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma1 = "Provider=SQLNCLI11;Data Source=JUANMA-PC\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"
    Dim cadena_conexion_juanma2 = "Provider=SQLNCLI11;Data Source=POWERSTATION\SQLEXPRESS2014;Integrated Security=SSPI;Initial Catalog=Conforma"

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
                                       & "P.FECHA_ENTREGA AS 'Fecha de entrega', COUNT(DP.ID_DETALLE_PEDIDO) AS 'Items' FROM CLIENTES C" _
                                       & " JOIN PEDIDOS P ON P.ID_CLIENTE = C.ID_CLIENTE" _
                                       & " JOIN DETALLES_PEDIDOS DP ON DP.NRO_PEDIDO = P.NRO_PEDIDO" _
                                       & " GROUP BY P.NRO_PEDIDO,C.NOMBRE,C.APELLIDO,P.FECHA_ENTREGA")
        End Select


        Return tabla
    End Function

    Private Function ejecuto_sql(ByVal sql As String) As Data.DataTable
        Dim conexion As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand
        Dim tabla As New DataTable

        conexion.ConnectionString = cadena_conexion_mateo
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

    Public Function carga_combo_generico_dos_tablas(ByRef combo As ComboBox, tabla1 As String, pk As String _
                                         , nombre As String, tabla2 As String, atributo_union As String)
        Dim tabla_fuentes As Data.DataTable = leer_tabla_filtrada_dos_tablas(tabla1, nombre, tabla2, atributo_union)
        combo.DataSource = tabla_fuentes
        combo.DisplayMember = nombre
        combo.ValueMember = pk
        Return combo
    End Function

    Public Function cargar_combo_generico_filtrado(ByRef combo As ComboBox, tabla As String, pk As String _
                                                   , nombre As String, atributo_id As Integer)
        Dim tabla_fuente As DataTable = leer_tabla_filtrada_generica(tabla, pk, atributo_id, nombre)
        combo.DataSource = tabla_fuente
        combo.ValueMember = pk
        combo.DisplayMember = nombre
        Return combo
    End Function

    Public Function leer_tabla_filtrada_generica(ByVal tabla As String, pk As String, atributo_id As Integer _
                                                 , nombre As String)
        Dim tabla_fuente As DataTable = Me.ejecuto_sql("SELECT " & nombre & " FROM " & tabla & " WHERE " & pk & " = " & atributo_id)
        Return tabla_fuente
    End Function

    Public Function leer_tabla_filtrada_dos_tablas(ByVal tabla1 As String, nombre As String, tabla2 As String, atributo_union As String) As Data.DataTable
        Dim tabla As DataTable = Me.ejecuto_sql("SELECT " & nombre & " FROM " & tabla1 & " T1 JOIN " & tabla2 & " T2 ON T1." & atributo_union & " = T2." & atributo_union & " WHERE T1.NOMBRE LIKE '" & nombre & "'")
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

    Public Function buscar_localidad(ByVal tabla As String, filtro As String)
        Dim id_cadena As String = ""
        Dim id_provincia As Int16 = CInt(ejecuto_sql("SELECT ID_PROVINCIA FROM PROVINCIAS WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString)

        If (Me.ejecuto_sql("SELECT * FROM " & tabla & " WHERE ID_PROVINCIA = " & id_provincia).Rows.Count = 0) Then
            Return True
        End If
        Return False
    End Function
    Public Sub insertar_localidad(ByVal localidad As String, filtro As String, cp As Int16)
        Dim id_provincia As Int16 = CInt(ejecuto_sql("SELECT ID_PROVINCIA FROM PROVINCIAS WHERE NOMBRE LIKE '" & filtro & "'").Rows(0).Item(0).ToString)
        Me.ejecuto_sql("INSERT INTO CIUDADES VALUES('" & localidad & "'," & id_provincia & ", " & cp & ")")
    End Sub

End Class
