Imports System.Data.SqlClient
Imports System.IO
Imports Modulo_Reclutamiento.Cn_Datos
Imports Modulo_Reclutamiento.FuncionesGlobales
Imports Newtonsoft.Json

Public Class Cn_Reclutamiento

    Public Enum TipoFoto As Integer
        CuerpoCompleto = 1
        Frente = 2
        Derecho = 3
        Izquierdo = 4
        Firma = 5
        Codigo = 6
    End Enum

    Public Enum TipoHuella As Integer
        Huella1 = 1
        Huella2 = 2
        Huella3 = 3
        Huella4 = 4
        Huella5 = 5
        Huella6 = 6
        Huella7 = 7
        Huella8 = 8
        Huella9 = 9
        Huella10 = 10
    End Enum

#Region "PARAMETROS LOCALES"

    Public Shared Function fn_ParametrosLocales_Read() As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ParametrosL_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
        Cmd.Dispose()
        Return Tbl
    End Function

#End Region

#Region "GLOBALES"

    Public Shared Function fn_Menu_Progreso(ByVal Progreso As Byte) As Boolean
        'Aqui se actualiza la barra de progreso
        Try
            frm_MENU.prg_Barra.Value = Progreso
            Return True
        Catch
            Return False
        End Try
    End Function

#End Region

#Region "BUSCAR CLIENTE"

    ''' <summary>
    ''' Llena la lista lsv_Clientes
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarLista(ByVal lsv As cp_Listview, Optional ByVal Cliente As Boolean = True) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_ClientesCombo_Get", CommandType.StoredProcedure, Crea_ConexionSTD)


        Crea_Parametro(cmd, "@Pista", SqlDbType.VarChar, "")
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        If Cliente = False Then
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "P")
        Else
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        End If

        Try
            lsv.Actualizar(cmd, "Id_Cliente")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Empleados
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaEmpleados(ByVal lsv As cp_Listview, ByVal Status As String) As Boolean
        Dim cmd As SqlCommand = Nothing

        If Status = "A" Then
            cmd = Crea_Comando("Cat_Empleados_GetBusca", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
        ElseIf Status = "B" Then
            cmd = Crea_Comando("Cat_Empleados_GetReingresos", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If
        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Cajas Bancarias
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaCajasBancarias(ByVal lsv As cp_Listview) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Pro_CajasBancarias_ComboGet", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Try
            lsv.Actualizar(cmd, "Id_CajaBancaria")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    ''' <summary>
    ''' Llena la lista lsv_Clientes con Empleados y Prospectos
    ''' </summary>
    ''' <returns>Devuelve true en caso de que se haya hecho correctamente la acutalizacion</returns>
    Public Shared Function fn_BuscarClientes_LlenarListaEmpleadosyProspectos(ByVal lsv As cp_Listview, ByVal Nombres As String, ByVal APaterno As String, ByVal AMaterno As String) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosP_GetLike", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(cmd, "@Cadena", SqlDbType.VarChar, "") 'Ya nos se necesita este parametro
        Crea_Parametro(cmd, "@Nombres", SqlDbType.VarChar, Nombres)
        Crea_Parametro(cmd, "@APaterno", SqlDbType.VarChar, APaterno)
        Crea_Parametro(cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)


        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "FUNCIONES COMPARTIDAS"

    'Public Shared Function fn_ValidarClave(ByVal clave As String, ByVal Parametro As String, ByVal Procedure As String) As Boolean
    '    'Aqui se actualiza un elemento 
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
    '    Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
    '    Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, clave)

    '    Try

    '        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        If Tbl.Rows.Count = 0 Then
    '            Return True
    '        Else
    '            Return False
    '        End If

    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    Public Shared Function fn_LlenarLista(ByVal Procedure As String, ByVal Indice As String, ByVal Lista As cp_Listview) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedure, CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            'Aqui se Actualiza la lista
            Lista.Actualizar(Cmd, Indice)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Status(ByVal Id As Integer, ByVal status As Char, ByVal Procedimiento As String, ByVal Campo As String) As Boolean

        'Aqui se actualiza el Status de un Empleado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Campo, SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch Ex As Exception
            TrataEx(Ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ValidarDependencias(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String) As Boolean

        'Aqui se valida una dependencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.VarChar, Id)
        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ObtenValores(ByVal Id As Integer, ByVal Procedimiento As String, ByVal Parametro As String, ByVal Sucursal As Boolean) As DataRow

        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, Cnn)

        If Not Parametro = "" Then
            Cn_Datos.Crea_Parametro(Cmd, Parametro, SqlDbType.Int, Id)
        End If

        If Sucursal Then
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        End If

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                'MsgBox("No existe el registro solicitado.")
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Menu Principal"

    Public Shared Function fn_Menu_ObtenerEmpleadosSinEscolares() As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosEscolares_GetVacios", CommandType.StoredProcedure, Cnn)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Menu_ObtenerEmpleadosSinLaborales() As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_GetVacios", CommandType.StoredProcedure, Cnn)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Menu_ObtenerCredencialesPorExpirar() As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_PorExpirar", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_AlertasGeneradas_Existe(ByVal Clave_AlertaTipo As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_Existe", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return True
        End Try
    End Function

    Public Shared Function fn_Menu_ObtenerEmpleadosSinCredencial() As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_GetSinCredencial", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Menu_ObtenerCredencialesExpiradas() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_Expiradas", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "EMPLEADOS"

    Public Shared Function fn_Empleados_FichaTecnicaImprimir(ByVal IdEmpleado As Integer, ByRef tabla As DataTable) As Boolean
        'funcion que regresa tabla de la ficha tecnica del empleado
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetFichaTecnica", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)

            tabla.Rows.Clear()
            Cmd.Connection.Open()
            tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_CapacitacionesImprimir(ByVal IdEmpleado As Integer, ByRef tabla As DataTable) As Boolean
        'funcion que regresa tabla de la ficha tecnica del empleado
        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosCursos_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)

            tabla.Rows.Clear()
            Cmd.Connection.Open()
            tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarClientes_Validos(ByVal Id_Empleado As Integer) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_ReadbyId_EmpleadoOriginal", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim Dt As DataTable = EjecutaConsulta(cmd)
            Return Dt

            'If Dt IsNot Nothing AndAlso Dt.Rows.Count > 0 Then
            '    Return Dt
            'Else
            '    Return Nothing
            'End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Empleados_ObtenValores(ByVal Id As Integer) As DataRow
        'Return fn_ObtenValores(Id, "Cat_Empleados_Read_Completo", "@Id_Empleado", False)
        Return fn_ObtenValores(Id, "Cat_Empleados_Read_CompletoSSP", "@Id_Empleado", False)
    End Function

    Public Shared Function fn_Empleados_ValidarClave(ByVal Clave As String) As Boolean
        '        If ClaveAnt = "" Then GoTo Validar ' asi estaba antes 
        '        If Not Clave = ClaveAnt Then GoTo Validar
        '        Return True
        '        Exit Function
        'Validar:
        '        Return fn_ValidarClave(Clave, "@Clave_Empleado", "Cat_EmpleadosClave_Read")

        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosClave_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave)
        Try

            Dim tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If tbl IsNot Nothing AndAlso tbl.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Empleados_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Status As String) As Boolean
        'Return fn_LlenarLista("Cat_Empleados_Get", "Id_Empleado", lsv)
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Empleados_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Empleado")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_LlenarListaCartas(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Status As String) As Boolean

        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetCartas", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Dim DT As DataTable = EjecutaConsulta(Cmd)

            If DT IsNot Nothing AndAlso DT.Rows.Count > 0 Then
                'Aqui se Actualiza la lista
                lsv.Actualizar(Cmd, "Id_Empleado")
                For J As Integer = 0 To lsv.Items.Count - 1
                    If lsv.Items(J).SubItems(4).Text = "BAJA" Then
                        lsv.Items(J).ForeColor = Color.Red
                    End If
                Next
            End If

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_ReporteCartasImprimir(ByVal IdEmpleado As Integer, ByRef tabla As DataTable) As Boolean

        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("[Cat_Empleados_GetCartasRpt]", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)

            tabla.Rows.Clear()
            Cmd.Connection.Open()
            tabla.Load(Cmd.ExecuteReader)
            Cmd.Connection.Close()
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_TieneImagenes(ByVal Id As Integer) As Boolean
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try

            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosI_Existe", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "Id_Empleado", SqlDbType.Int, Id)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    '---- Reingreso de un empleado 26/03/2014
    Public Shared Function fn_Empleados_ReingresarExistente(ByVal IdEmpleado As Integer, ByVal FechaIngreso As Date) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            ' Reingresa un empleado existente(Clave y ID keda igual), estatus='A' , reingreso='S'
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("[Cat_Empleados_Reingresar]", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, IdEmpleado)
            Cn_Datos.Crea_Parametro(CmdF, "@Reingreso", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(CmdF, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(CmdF, "@Fecha_Ingreso", SqlDbType.DateTime, FechaIngreso)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_Nuevo(ByVal Clave As String, ByVal NombreCompleto As String, ByVal Departamento As Integer,
                                              ByVal Puesto As Integer, ByVal Sexo As Char, ByVal EstadoCivil As Integer,
                                              ByVal Mail As String, ByVal Catalogo As String, ByVal APaterno As String,
                                              ByVal AMaterno As String, ByVal Nombres As String, ByVal Sale_Ruta As Char,
                                              ByVal Credito_Infonavit As Char, ByVal Id_Puesto As Integer, ByVal Verifica_Servicios As Char,
                                              ByVal Id_EmpleadoP As Integer, ByVal Mail_Personal As String, ByVal Id_Reingreso As Integer,
                                              ByVal Portara_Arma As Char, ByVal Numero_Credito As String, ByVal Tipo_Descuento As String,
                                              ByVal Monto_Descuento As Decimal) As Integer

        'Aqui se inserta un nuevo registro
        Dim Id_Empleado As Integer = 0
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            '--verificar si la clave ya existe -Antes de insertar el empleado
            If Id_Reingreso = 0 OrElse Modo_ReingresoEmp = 1 Then
                If fn_Empleados_ValidarClave(Clave) Then
                    'si es true existe la clave -salir
                    Return 0
                End If
            End If

            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Empleados_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Catalogo", SqlDbType.VarChar, Catalogo)
            Cn_Datos.Crea_Parametro(Cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Cn_Datos.Crea_Parametro(Cmd, "@Sale_Ruta", SqlDbType.VarChar, Sale_Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Credito_Infonavit", SqlDbType.VarChar, Credito_Infonavit)
            Cn_Datos.Crea_Parametro(Cmd, "@Verifica_Servicios", SqlDbType.VarChar, Verifica_Servicios)
            Cn_Datos.Crea_Parametro(Cmd, "@Nuevo_Ingreso", SqlDbType.VarChar, "S")
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail_Personal", SqlDbType.VarChar, Mail_Personal) 'new
            Cn_Datos.Crea_Parametro(Cmd, "@Porte_Armas", SqlDbType.VarChar, Portara_Arma)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Credito", SqlDbType.VarChar, Numero_Credito)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Descuento", SqlDbType.VarChar, Tipo_Descuento)
            Cn_Datos.Crea_Parametro(Cmd, "@Monto_Descuento", SqlDbType.Decimal, Monto_Descuento)

            If Id_Reingreso > 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Reingreso", SqlDbType.VarChar, "S")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoOriginal", SqlDbType.Int, Id_Reingreso)
            End If

            Id_Empleado = Cn_Datos.EjecutarScalarT(Cmd)

            If Id_Reingreso > 0 Then
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Empleados_UpdateReingreso")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Reingreso)
                Crea_Parametro(Cmd, "@Id_Reingreso", SqlDbType.Int, Id_Empleado)
                EjecutarNonQueryT(Cmd)
            End If

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Calcular")
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            EjecutarNonQueryT(Cmd)

            Tr.Commit()
            Return Id_Empleado
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex, False)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Empleados_IncrementaEmpleado(ByVal Clave_Guardada As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_IncrementaEmpleado", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(CmdF, "@Ult_Empleado", SqlDbType.Int, Clave_Guardada)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_Actualizar(ByVal Id_Empleado As Integer, ByVal Clave As String, ByVal NombreCompleto As String,
                                                   ByVal Departamento As Integer, ByVal Puesto As Integer, ByVal Sexo As Char,
                                                   ByVal EstadoCivil As Integer, ByVal Mail As String, ByVal Catalogo As String,
                                                   ByVal APaterno As String, ByVal AMaterno As String, ByVal Nombres As String,
                                                   ByVal Sale_Ruta As Char, ByVal Credito_Infonavit As Char, ByVal Verifica_Servicios As Char,
                                                   ByVal Calcular As Boolean, ByVal Mail_Personal As String, ByVal BuscarClave As Boolean,
                                                   ByVal PortaraArmas As Char, ByVal Numero_Credito As String, ByVal Tipo_Descuento As String,
                                                   ByVal Monto_Descuento As Decimal, LPC As String) As Boolean
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = crear_Trans(Cnn)
        Try
            '--verificar si la clave ya existe -Antes de Actualizar el empleado
            If BuscarClave Then
                If fn_Empleados_ValidarClave(Clave) Then
                    'si es true existe la clave -salir
                    Return False
                End If
            End If

            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Empleados_UpdateSSP")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(Cmd, "@Catalogo", SqlDbType.VarChar, Catalogo)
            Cn_Datos.Crea_Parametro(Cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Cn_Datos.Crea_Parametro(Cmd, "@Sale_Ruta", SqlDbType.VarChar, Sale_Ruta)
            Cn_Datos.Crea_Parametro(Cmd, "@Credito_Infonavit", SqlDbType.VarChar, Credito_Infonavit)
            Cn_Datos.Crea_Parametro(Cmd, "@Verifica_Servicios", SqlDbType.VarChar, Verifica_Servicios)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail_Personal", SqlDbType.VarChar, Mail_Personal) 'new
            Cn_Datos.Crea_Parametro(Cmd, "@Porte_Armas", SqlDbType.VarChar, PortaraArmas)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Credito", SqlDbType.VarChar, Numero_Credito)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Descuento", SqlDbType.VarChar, Tipo_Descuento)
            Cn_Datos.Crea_Parametro(Cmd, "@Monto_Descuento", SqlDbType.Decimal, Monto_Descuento)
            Cn_Datos.Crea_Parametro(Cmd, "@LPC", SqlDbType.VarChar, LPC)

            Cn_Datos.EjecutarNonQueryT(Cmd)

            If Calcular Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Calcular")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
                EjecutarNonQueryT(Cmd)
            End If

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_ActualizarAdicionales(ByVal Id_Empleado As Integer, ByVal SueldoBase As Decimal,
                                                              ByVal Calle As String, ByVal NumExterior As Integer,
                                                              ByVal NumInterior As String, ByVal Colonia As String,
                                                              ByVal Zona As Integer, ByVal CodigoPostal As Integer,
                                                              ByVal Telefono As String, ByVal TelefonoMovil As String,
                                                              ByVal FechaNac As Date, ByVal LugarNac As String,
                                                              ByVal RFC As String, ByVal CURP As String,
                                                              ByVal IMSS As String, ByVal IFE As String,
                                                              ByVal TipoLicencia As Integer,
                                                              ByVal FechaExpira As Date,
                                                              ByVal NumCartilla As String,
                                                              ByVal Certificacion As String, ByVal ConFamilia As String,
                                                              ByVal CantidadHijos As Integer, ByVal Edad As Integer,
                                                              ByVal FechaIngreso As Date, ByVal Id_EmpleadoRef As Integer,
                                                              ByVal EntreCalle1 As String, ByVal EntreCalle2 As String,
                                                              ByVal ModoNacionalidad As Byte, ByVal PaisNacimiento As String,
                                                              ByVal FechaNaturalizacion As Date, ByVal Pasaporte As String,
                                                              ByVal Jefe_Area As Char, ByVal Latitud As Decimal,
                                                              ByVal Longitud As Decimal, ByVal UMF As String,
                                                              ByVal Ciudad_Nacimiento As Integer,
                                                              ByVal Id_ModoContactoD As Integer,
                                                              ByVal CUIP As String,
                                                              ByVal NumeroLicencia As String,
                                                              ByVal NumeroLicenciaFed As String,
                                                              ByVal FechaExpiraFed As Date,
                                                              ByVal IdTributario As String,
                                                              ByVal Tipo_SSP As Integer,
                                                              Registro_SSP As Integer,
                                                              Cartilla_SSP As Integer) As Boolean
        Try

            'Aquí se actualizan datos de la tabla Cat_Empleados de un Empleado seleccionado o de uno nuevo
            Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            '            Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_UpdateAdicionales", CommandType.StoredProcedure, cnn)
            Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_UpdateAdicionalesSSP", CommandType.StoredProcedure, cnn)

            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(cmd, "@Sueldo_Base", SqlDbType.Money, SueldoBase)
            Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, Calle)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroExterior", SqlDbType.Int, NumExterior)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroInterior", SqlDbType.VarChar, NumInterior)
            Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Cn_Datos.Crea_Parametro(cmd, "@Zona", SqlDbType.Int, Zona)
            Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, CodigoPostal)
            Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Cn_Datos.Crea_Parametro(cmd, "@TelefonoMovil", SqlDbType.VarChar, TelefonoMovil)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNacimiento", SqlDbType.DateTime, FechaNac)
            Cn_Datos.Crea_Parametro(cmd, "@LugarNacimiento", SqlDbType.VarChar, LugarNac)
            Cn_Datos.Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            Cn_Datos.Crea_Parametro(cmd, "@CURP", SqlDbType.VarChar, CURP)
            Cn_Datos.Crea_Parametro(cmd, "@IMSS", SqlDbType.VarChar, IMSS)
            Cn_Datos.Crea_Parametro(cmd, "@IFE", SqlDbType.VarChar, IFE)
            Cn_Datos.Crea_Parametro(cmd, "@TipoLicencia", SqlDbType.Int, TipoLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@FechaExpira", SqlDbType.DateTime, FechaExpira)
            Cn_Datos.Crea_Parametro(cmd, "@NumCartilla", SqlDbType.VarChar, NumCartilla)
            Cn_Datos.Crea_Parametro(cmd, "@Certificacion", SqlDbType.VarChar, Certificacion)
            Cn_Datos.Crea_Parametro(cmd, "@ConFamilia", SqlDbType.VarChar, ConFamilia)
            Cn_Datos.Crea_Parametro(cmd, "@CantidadHijos", SqlDbType.Int, CantidadHijos)
            Cn_Datos.Crea_Parametro(cmd, "@Edad", SqlDbType.Int, Edad)
            Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, FechaIngreso)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoRef", SqlDbType.Int, Id_EmpleadoRef)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, EntreCalle1)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, EntreCalle2)
            Cn_Datos.Crea_Parametro(cmd, "@ModoNacionalidad", SqlDbType.Int, ModoNacionalidad)
            Cn_Datos.Crea_Parametro(cmd, "@PaisNacimiento", SqlDbType.VarChar, PaisNacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNaturalizacion", SqlDbType.Date, FechaNaturalizacion)
            Cn_Datos.Crea_Parametro(cmd, "@Pasaporte", SqlDbType.VarChar, Pasaporte)
            Cn_Datos.Crea_Parametro(cmd, "@Jefe_Area", SqlDbType.VarChar, Jefe_Area)
            Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, Latitud)
            Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, Longitud)
            Cn_Datos.Crea_Parametro(cmd, "@UMF", SqlDbType.VarChar, UMF)
            Cn_Datos.Crea_Parametro(cmd, "@Ciudad_Nacimiento", SqlDbType.Int, Ciudad_Nacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_ModoContactoD", SqlDbType.Int, Id_ModoContactoD)
            Cn_Datos.Crea_Parametro(cmd, "@CUIP", SqlDbType.VarChar, CUIP)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicencia", SqlDbType.VarChar, NumeroLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicenciaFed", SqlDbType.VarChar, NumeroLicenciaFed)
            Cn_Datos.Crea_Parametro(cmd, "@FechaExpiraFed", SqlDbType.DateTime, FechaExpiraFed)
            Cn_Datos.Crea_Parametro(cmd, "@IdTributario", SqlDbType.VarChar, IdTributario)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_SSP", SqlDbType.Int, Tipo_SSP)
            Cn_Datos.Crea_Parametro(cmd, "@Registro_SSP", SqlDbType.Int, Registro_SSP)
            Cn_Datos.Crea_Parametro(cmd, "@Cartilla_SSP", SqlDbType.Int, Cartilla_SSP)

            Cn_Datos.EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_Baja(ByVal Id_Empleado As Integer) As Boolean
        'Return fn_Status(Id, "B", "Cat_Empleados_Status", "@Id_Empleado")
        'Aquí se actualizan datos de la tabla Cat_Empleados de un Empleado seleccionado o de uno nuevo
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_Baja", CommandType.StoredProcedure, cnn)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleados_Alta(ByVal Id As Integer) As Boolean
        Return fn_Status(Id, "A", "Cat_Empleados_Status", "@Id_Empleado")
    End Function

    Public Shared Function fn_Empleados_ValidarDependencias(ByVal Id As Integer) As Boolean
        Return fn_ValidarDependencias(Id, "Cat_Empleados_Dependencias", "@Id_Empleado")
    End Function

    Public Shared Function fn_Empleados_ValidarArmas(ByVal Id_Empleado As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("SI_Armas_GetAsignadas", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Usuario_Asignado", SqlDbType.Int, Id_Empleado)

            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt IsNot Nothing Then
                Return dt.Rows.Count = 0
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosEscolares_ObtenValores(ByVal Id As Integer) As DataRow
        'Aquí se obtienen los Datos Escolares del Empleado seleccionado
        Return fn_ObtenValores(Id, "Cat_EmpleadosEscolares_Read", "@Id_Empleado", False)
    End Function

    Public Shared Function fn_DatosEscolares_Nuevo(ByVal Id_Empleado As Integer, ByVal Id_GradoEscolar As Integer, ByVal NombreEscuela As String, ByVal Carrera As String, ByVal Especialidad As String, ByVal Id_TipoDocto As Integer, ByVal Folio As String, ByVal FechaInicio As Integer, ByVal FechaFin As Integer, ByVal Promedio As Decimal, ByVal CedulaProfesional As String) As Integer
        Dim Id_EmpleadoEscolar As Integer = 0
        'Aquí se inserta un nuevo registro de los Datos Escolares de un Empleado seleccionado o de uno nuevo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosEscolares_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id_GradoEscolar)
        Cn_Datos.Crea_Parametro(Cmd, "@NombreEscuela", SqlDbType.VarChar, NombreEscuela)
        Cn_Datos.Crea_Parametro(Cmd, "@Carrera", SqlDbType.VarChar, Carrera)
        Cn_Datos.Crea_Parametro(Cmd, "@Especialidad", SqlDbType.VarChar, Especialidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id_TipoDocto)
        Cn_Datos.Crea_Parametro(Cmd, "@FolioDocumento", SqlDbType.VarChar, Folio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Int, FechaInicio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Int, FechaFin)
        Cn_Datos.Crea_Parametro(Cmd, "@Promedio", SqlDbType.Money, Promedio)
        Cn_Datos.Crea_Parametro(Cmd, "@CedulaProfesional", SqlDbType.VarChar, CedulaProfesional)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Id_EmpleadoEscolar = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_EmpleadoEscolar
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_DatosEscolares_Actualizar(ByVal Id_Empleado As Integer, ByVal Id_GradoEscolar As Integer, ByVal NombreEscuela As String, ByVal Carrera As String, ByVal Especialidad As String, ByVal Id_TipoDocto As Integer, ByVal Folio As String, ByVal FechaInicio As Integer, ByVal FechaFin As Integer, ByVal Promedio As Decimal, ByVal CedulaProfesional As String) As Boolean
        'Aquí se actualizan los Datos Escolares de un empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosEscolares_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id_GradoEscolar)
        Cn_Datos.Crea_Parametro(Cmd, "@NombreEscuela", SqlDbType.VarChar, NombreEscuela)
        Cn_Datos.Crea_Parametro(Cmd, "@Carrera", SqlDbType.VarChar, Carrera)
        Cn_Datos.Crea_Parametro(Cmd, "@Especialidad", SqlDbType.VarChar, Especialidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id_TipoDocto)
        Cn_Datos.Crea_Parametro(Cmd, "@FolioDocumento", SqlDbType.VarChar, Folio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Int, FechaInicio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Int, FechaFin)
        Cn_Datos.Crea_Parametro(Cmd, "@Promedio", SqlDbType.Money, Promedio)
        Cn_Datos.Crea_Parametro(Cmd, "@CedulaProfesional", SqlDbType.VarChar, CedulaProfesional)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CursosRecibidos_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todos los CURSOS RECIBIDOS de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCursos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoCurso")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CursosRecibidos_Guardar(ByVal Id_Empleado As Integer, ByVal lsv As ListView) As Boolean
        'Aquí se Guardan los Cursos Recibidos de un Empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cont As Integer = 0

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    'Curso nuevo
                    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosCursos_Create")

                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                    Cn_Datos.Crea_Parametro(Cmd, "@NombreCurso", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.DateTime, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Finalizado", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Instructor", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDocto", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    'Curso existente modificado
                    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosCursos_Update")

                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoCurso", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Inicio", SqlDbType.DateTime, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Fin", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Finalizado", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Instructor", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDocumento", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_CursosRecibidos_Borrar(ByVal Id_EmpleadoCurso As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCursos_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoCurso", SqlDbType.Int, Id_EmpleadoCurso)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosFamiliares_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todos los DATOS FAMILIARES de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosFamiliares_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoFamiliares")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosFamiliares_Nuevo(ByVal Id_Empleado As Integer, ByVal lsv As ListView) As Boolean
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If Not lsv.Items(cont).SubItems(0).Tag Is Nothing Then
                    If lsv.Items(cont).SubItems(0).Tag = 0 Then
                        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosFamiliares_Create")
                        Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                        Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@DepEconomico", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_TipoParentesco", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@FechaNac", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Direccion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(10).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@MismoDomicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(7).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Vive", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        Cn_Datos.EjecutarScalarT(cmd)
                    Else
                        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosFamiliares_Update")
                        Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoFamiliares", SqlDbType.Int, lsv.Items(cont).Tag)
                        Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@DepEconomico", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_TipoParentesco", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@FechaNac", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Direccion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(10).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@MismoDomicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(7).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Vive", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                        Cn_Datos.Crea_Parametro(cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                        Cn_Datos.EjecutarNonQueryT(cmd)
                    End If
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_DatosFamiliares_Borrar(ByVal Id_EmpleadoFamiliares As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosFamiliares_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoFamiliares", SqlDbType.Int, Id_EmpleadoFamiliares)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleos_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todos los EMPLEOS anteriores de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoLaborales")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).TextAlign = HorizontalAlignment.Right
            lsv.Columns(17).TextAlign = HorizontalAlignment.Right
            lsv.Columns(18).TextAlign = HorizontalAlignment.Right
            lsv.Columns(23).Width = 0
            lsv.Columns(24).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleos_Guardar(ByVal Id_Empleado As Integer, ByVal lsv As ListView) As Boolean

        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(cnn)
        'NombreEmpresa  item
        'Calle          subitem(1)
        'EntreCalle1    subitem(2)
        'EntreCalle2    subitem(3)
        'NumeroExt      subitem(4)
        'NumeroInt      subitem(5)
        'Colonia        subitem(6)
        'Ciudad         subitem(7)
        'CodigoPostal   subitem(8)
        'Latitud        subitem(9)
        'Longitud       subitem(10)
        'FIngreso       subitem(11)
        'FBaja          subitem(12)
        'Puesto         subitem(13)
        'NombreJefe     subitem(14)
        'PuestoJefe     subitem(15)
        'Telefono       subitem(16)
        'SueldoInicial  subitem(17)
        'SueldoFinal    subitem(18)
        'MotivoSep      subitem(19)
        'OtroMotivo     subitem(20)
        'EmpResaSeg     subitem(21)
        'PorteArmas     subitem(22)
        'Id_Ciudad      subitem(23)
        'Id_MotivoSep   subitem(24)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).SubItems(9).Text = "" Then lsv.Items(cont).SubItems(9).Text = "0"
                If lsv.Items(cont).SubItems(10).Text = "" Then lsv.Items(cont).SubItems(10).Text = "0"
                If lsv.Items(cont).Tag = 0 Then
                    Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosLaborales_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreEmpresa", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(23).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaBaja", SqlDbType.DateTime, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, lsv.Items(cont).SubItems(13).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PuestoJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoInicial", SqlDbType.Money, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoFinal", SqlDbType.Money, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_MotivoBaja", SqlDbType.Int, lsv.Items(cont).SubItems(24).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@OtroMotivo", SqlDbType.VarChar, lsv.Items(cont).SubItems(20).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EmpresaSegPriv", SqlDbType.VarChar, lsv.Items(cont).SubItems(21).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PorteArmas", SqlDbType.VarChar, lsv.Items(cont).SubItems(22).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(10).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarScalarT(cmd)
                Else
                    Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosLaborales_Update")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoLaborales", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreEmpresa", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(23).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaBaja", SqlDbType.DateTime, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, lsv.Items(cont).SubItems(13).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PuestoJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoInicial", SqlDbType.Money, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoFinal", SqlDbType.Money, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_MotivoBaja", SqlDbType.Int, lsv.Items(cont).SubItems(24).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@OtroMotivo", SqlDbType.VarChar, lsv.Items(cont).SubItems(20).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EmpresaSegPriv", SqlDbType.VarChar, lsv.Items(cont).SubItems(21).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PorteArmas", SqlDbType.VarChar, lsv.Items(cont).SubItems(22).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(10).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarNonQueryT(cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_Empleos_Borrar(ByVal Id_EmpleadoLaborales As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoLaborales", SqlDbType.Int, Id_EmpleadoLaborales)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Empleos_ObtenerPredictivoEmpresas() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_GetEmpresas", CommandType.StoredProcedure, Cnn)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Empleos_ObtenValoresPredictivo(ByVal Id As Integer) As DataRow
        'Aqui se obtienen todos los datos de la Empresa seleccionada en el Predictivo
        Dim dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_ReadEmpresas", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoLaborales", SqlDbType.Int, Id)

        Try
            dt = EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Referencias_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todas las REFERENCIAS de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosReferencias_Read", CommandType.StoredProcedure, Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosReferencias_ReadSSP", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)
        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoReferencia")
            lsv.Columns(13).Width = 0
            lsv.Columns(14).Width = 0
            lsv.Columns(15).Width = 0
            lsv.Columns(16).Width = 0
            lsv.Columns(17).Width = 0
            lsv.Columns(18).Width = 0
            lsv.Columns(19).Width = 0
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(11).TextAlign = HorizontalAlignment.Right
            lsv.Columns(12).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Referencias_Guardar(ByVal Id_Empleado As Integer, ByVal lsv As cp_Listview) As Boolean

        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosReferencias_CreateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoReferencia", SqlDbType.Int, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ocupacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@OcupacionSSP", SqlDbType.Int, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoP", SqlDbType.VarChar, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoM", SqlDbType.VarChar, lsv.Items(cont).SubItems(19).Text)
                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    'Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosReferencias_Update")
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosReferencias_UpdateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoReferencia", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoReferencia", SqlDbType.Int, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ocupacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@OcupacionSSP", SqlDbType.Int, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoP", SqlDbType.VarChar, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoM", SqlDbType.VarChar, lsv.Items(cont).SubItems(19).Text)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_Referencias_Borrar(ByVal Id_EmpleadoReferencia As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosReferencias_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoReferencia", SqlDbType.Int, Id_EmpleadoReferencia)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DatosIngresos_ObtenValores(ByVal Id As Integer) As DataRow
        'Aqui se obtienen toda la información de Ingresos de un Empleado en particular
        Return fn_ObtenValores(Id, "Cat_EmpleadosIngresos_Read", "@Id_Empleado", False)
    End Function

    Public Shared Function fn_SeñasParticulares_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todas las Señas Particulares de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        ' Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosSenas_Read", CommandType.StoredProcedure, Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosSenas_ReadSSP", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoSena")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_SeñasParticulares_Borrar(ByVal Id_EmpleadoSena As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosSenas_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoSena", SqlDbType.Int, Id_EmpleadoSena)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosIngresos_Nuevo(ByVal Id_Empleado, ByVal IngresoFamiliar, ByVal IngresoAdicional, ByVal DescripcionAdicional, ByVal GastoMensual, ByVal Id_TipoVivienda, ByVal PagoMensual, ByVal ValorVivienda, ByVal VehiculoPropio, ByVal Modelo, ByVal ValorVehiculo) As Integer

        Dim Id_EmpleadosIngresos As Integer = 0

        'Aquí se está insertando el registro único de los Ingresos y otros de un Empleado seleccionado o nuevo
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosIngresos_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoMensual", SqlDbType.Money, IngresoFamiliar)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoAdicional", SqlDbType.Money, IngresoAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@DescripcionAdicional", SqlDbType.VarChar, DescripcionAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@GastoMensual", SqlDbType.Money, GastoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id_TipoVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@PagoMensual", SqlDbType.Money, PagoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVivienda", SqlDbType.Money, ValorVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@VehiculoPropio", SqlDbType.VarChar, VehiculoPropio)
        Cn_Datos.Crea_Parametro(Cmd, "@ModeloVehiculo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVehiculo", SqlDbType.Money, ValorVehiculo)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Id_EmpleadosIngresos = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_EmpleadosIngresos
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_EmpleadosIngresos_Actualizar(ByVal Id_Empleado, ByVal IngresoFamiliar, ByVal IngresoAdicional, ByVal DescripcionAdicional, ByVal GastoMensual, ByVal Id_TipoVivienda, ByVal PagoMensual, ByVal ValorVivienda, ByVal VehiculoPropio, ByVal Modelo, ByVal ValorVehiculo)

        'Aquí se actualizan los datos de Ingresos y otros de un Empleado seleccionado
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosIngresos_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoMensual", SqlDbType.Money, IngresoFamiliar)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoAdicional", SqlDbType.Money, IngresoAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@DescripcionAdicional", SqlDbType.VarChar, DescripcionAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@GastoMensual", SqlDbType.Money, GastoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id_TipoVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@PagoMensual", SqlDbType.Money, PagoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVivienda", SqlDbType.Money, ValorVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@VehiculoPropio", SqlDbType.VarChar, VehiculoPropio)
        Cn_Datos.Crea_Parametro(Cmd, "@ModeloVehiculo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVehiculo", SqlDbType.Money, ValorVehiculo)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosSenas_Guardar(ByVal Id_Empleado As Integer, ByVal lsv As cp_Listview)

        'Aquí se esta insertando un nuevo registro de Señas Particulares de un Empleado seleccionado o nuevo
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosSenas_CreateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

                    Cn_Datos.Crea_Parametro(Cmd, "@RegionSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@LadoSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosSenas_UpdateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoSena", SqlDbType.Int, lsv.Items(cont).Tag)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(5).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@RegionSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@LadoSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True

    End Function

    Public Shared Function fn_Empleados_ActualizarVarios(ByVal Id_Empleado As Integer, ByVal Vicios As String, ByVal Habilidades As String, ByVal Actividades As String, ByVal Idiomas As String) As Boolean

        'Aquí se actualizan Algunos datos de la tabla Cat_Empleados del Empleado seleccionado o de uno nuevo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_UpdateVarios", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Vicios", SqlDbType.VarChar, Vicios)
        Cn_Datos.Crea_Parametro(Cmd, "@Habilidades", SqlDbType.VarChar, Habilidades)
        Cn_Datos.Crea_Parametro(Cmd, "@Actividades", SqlDbType.VarChar, Actividades)
        Cn_Datos.Crea_Parametro(Cmd, "@Idiomas", SqlDbType.VarChar, Idiomas)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Rasgos_ObtenValores(ByVal Id As Integer) As DataRow
        'Aqui se obtiene todos los Rasgos de un Empleado seleccionado
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosRasgos_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Rasgos_Nuevo(ByVal Id_Empleado As Integer, ByVal Complexion As Byte, ByVal ColorPiel As Byte, ByVal Cara As Byte, ByVal TipoSangre As Byte, ByVal FactorRH As Byte, ByVal Peso As Decimal, ByVal Estatura As Decimal, ByVal UsaAnteojos As String, ByVal CantidadCabello As Byte, ByVal ColorCabello As Byte, ByVal FormaCabello As Byte, ByVal Calvicie As Byte, ByVal ImplantacionCabello As Byte,
                                           ByVal AlturaFrante As Byte, ByVal InclinacionFrente As Byte, ByVal AnchoFrente As Byte, ByVal DireccionCejas As Byte, ByVal ImplantacionCejas As Byte, ByVal FormaCejas As Byte, ByVal TamanoCejas As Byte, ByVal ColorOjos As Byte, ByVal FormaOjos As Byte, ByVal TamanoOjos As Byte,
                                           ByVal RaizNariz As Byte, ByVal DorsoNariz As Byte, ByVal AnchoNariz As Byte, ByVal BaseNariz As Byte, ByVal AlturaNariz As Byte, ByVal TamanoBoca As Byte, ByVal ComisurasBoca As Byte, ByVal EspesorLabios As Byte, ByVal AlturaNasoLabial As Byte, ByVal ProminenciaLabios As Byte,
                                           ByVal TipoMenton As Byte, ByVal FormaMenton As Byte, ByVal InclinacionMenton As Byte, ByVal FormaOreja As Byte, ByVal OriginalOreja As Byte, ByVal HelixSuperior As Byte, ByVal HelixPosterior As Byte, ByVal HelixAdherencia As Byte, ByVal HelixContorno As Byte, ByVal LobuloAdherencia As Byte, ByVal LobuloParticularidad As Byte, ByVal LobuloDimension As Byte) As Integer

        Dim Id_EmpleadosRasgos As Integer = 0

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosRasgos_Create", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Complexion", SqlDbType.Int, Complexion)
            Crea_Parametro(Cmd, "@PielColor", SqlDbType.Int, ColorPiel)
            Crea_Parametro(Cmd, "@CaraForma", SqlDbType.Int, Cara)

            Crea_Parametro(Cmd, "@CabelloCantidad", SqlDbType.Int, CantidadCabello)
            Crea_Parametro(Cmd, "@CabelloColor", SqlDbType.Int, ColorCabello)
            Crea_Parametro(Cmd, "@CabelloForma", SqlDbType.Int, FormaCabello)
            Crea_Parametro(Cmd, "@CabelloCalvicie", SqlDbType.Int, Calvicie)
            Crea_Parametro(Cmd, "@CabelloImplantacion", SqlDbType.Int, ImplantacionCabello)

            Crea_Parametro(Cmd, "@FrenteAltura", SqlDbType.Int, AlturaFrante)
            Crea_Parametro(Cmd, "@FrenteInclinacion", SqlDbType.Int, InclinacionFrente)
            Crea_Parametro(Cmd, "@FrenteAncho", SqlDbType.Int, AnchoFrente)

            Crea_Parametro(Cmd, "@CejasDireccion", SqlDbType.Int, DireccionCejas)
            Crea_Parametro(Cmd, "@CejasImplantacion", SqlDbType.Int, ImplantacionCejas)
            Crea_Parametro(Cmd, "@CejasForma", SqlDbType.Int, FormaCejas)
            Crea_Parametro(Cmd, "@CejasTamano", SqlDbType.Int, TamanoCejas)

            Crea_Parametro(Cmd, "@OjosColor", SqlDbType.Int, ColorOjos)
            Crea_Parametro(Cmd, "@OjosForma", SqlDbType.Int, FormaOjos)
            Crea_Parametro(Cmd, "@OjosTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@NarizRaiz", SqlDbType.Int, RaizNariz)
            Crea_Parametro(Cmd, "@NarizDorso", SqlDbType.Int, DorsoNariz)
            Crea_Parametro(Cmd, "@NarizAncho", SqlDbType.Int, AnchoNariz)
            Crea_Parametro(Cmd, "@NarizBase", SqlDbType.Int, BaseNariz)
            Crea_Parametro(Cmd, "@NarizAltura", SqlDbType.Int, AlturaNariz)

            Crea_Parametro(Cmd, "@BocaTamano", SqlDbType.Int, TamanoBoca)
            Crea_Parametro(Cmd, "@BocaComisuras", SqlDbType.Int, ComisurasBoca)

            Crea_Parametro(Cmd, "@LabiosEspesor", SqlDbType.Int, EspesorLabios)
            Crea_Parametro(Cmd, "@LabiosAlturaNasoLabial", SqlDbType.Int, AlturaNasoLabial)
            Crea_Parametro(Cmd, "@LabiosProminencia", SqlDbType.Int, ProminenciaLabios)

            Crea_Parametro(Cmd, "@MentonTipo", SqlDbType.Int, TipoMenton)
            Crea_Parametro(Cmd, "@MentonForma", SqlDbType.Int, FormaMenton)
            Crea_Parametro(Cmd, "@MentonInclinacion", SqlDbType.Int, InclinacionMenton)

            Crea_Parametro(Cmd, "@OrejaForma", SqlDbType.Int, FormaOreja)
            Crea_Parametro(Cmd, "@OrejaOriginal", SqlDbType.Int, OriginalOreja)
            Crea_Parametro(Cmd, "@HelixSuperior", SqlDbType.Int, HelixSuperior)
            Crea_Parametro(Cmd, "@HelixPosterior", SqlDbType.Int, HelixPosterior)
            Crea_Parametro(Cmd, "@HelixAdherencia", SqlDbType.Int, HelixAdherencia)
            Crea_Parametro(Cmd, "@HelixContorno", SqlDbType.Int, HelixContorno)
            Crea_Parametro(Cmd, "@LobuloAdherencia", SqlDbType.Int, LobuloAdherencia)
            Crea_Parametro(Cmd, "@LobuloParticularidad", SqlDbType.Int, LobuloParticularidad)
            Crea_Parametro(Cmd, "@LobuloDimension", SqlDbType.Int, LobuloDimension)

            Crea_Parametro(Cmd, "@SangreTipo", SqlDbType.Int, TipoSangre)
            Crea_Parametro(Cmd, "@SangreFactorRH", SqlDbType.Int, FactorRH)
            Crea_Parametro(Cmd, "@UsaAnteojos", SqlDbType.VarChar, UsaAnteojos)
            Crea_Parametro(Cmd, "@Estatura", SqlDbType.Money, Estatura)
            Crea_Parametro(Cmd, "@Peso", SqlDbType.Money, Peso)

            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Id_EmpleadosRasgos = EjecutarScalar(Cmd)
            Return Id_EmpleadosRasgos
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_Rasgos_Actualizar(ByVal Id_Empleado As Integer, ByVal Complexion As Integer, ByVal ColorPiel As Integer, ByVal Cara As Integer, ByVal TipoSangre As Integer, ByVal FactorRH As Byte, ByVal Peso As Decimal, ByVal Estatura As Decimal, ByVal UsaAnteojos As String, ByVal CantidadCabello As Integer, ByVal ColorCabello As Integer, ByVal FormaCabello As Integer, ByVal Calvicie As Integer, ByVal ImplantacionCabello As Integer,
                                           ByVal AlturaFrante As Integer, ByVal InclinacionFrente As Integer, ByVal AnchoFrente As Integer, ByVal DireccionCejas As Integer, ByVal ImplantacionCejas As Integer, ByVal FormaCejas As Integer, ByVal TamanoCejas As Integer, ByVal ColorOjos As Integer, ByVal FormaOjos As Integer, ByVal TamanoOjos As Integer,
                                           ByVal RaizNariz As Integer, ByVal DorsoNariz As Integer, ByVal AnchoNariz As Integer, ByVal BaseNariz As Integer, ByVal AlturaNariz As Integer, ByVal TamanoBoca As Integer, ByVal ComisurasBoca As Integer, ByVal EspesorLabios As Integer, ByVal AlturaNasoLabial As Integer, ByVal ProminenciaLabios As Integer,
                                           ByVal TipoMenton As Integer, ByVal FormaMenton As Integer, ByVal InclinacionMenton As Integer, ByVal FormaOreja As Integer, ByVal OriginalOreja As Integer, ByVal HelixSuperior As Integer, ByVal HelixPosterior As Integer, ByVal HelixAdherencia As Integer, ByVal HelixContorno As Integer, ByVal LobuloAdherencia As Integer, ByVal LobuloParticularidad As Integer, ByVal LobuloDimension As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosRasgos_Update", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Complexion", SqlDbType.Int, Complexion)
            Crea_Parametro(Cmd, "@PielColor", SqlDbType.Int, ColorPiel)
            Crea_Parametro(Cmd, "@CaraForma", SqlDbType.Int, Cara)

            Crea_Parametro(Cmd, "@CabelloCantidad", SqlDbType.Int, CantidadCabello)
            Crea_Parametro(Cmd, "@CabelloColor", SqlDbType.Int, ColorCabello)
            Crea_Parametro(Cmd, "@CabelloForma", SqlDbType.Int, FormaCabello)
            Crea_Parametro(Cmd, "@CabelloCalvicie", SqlDbType.Int, Calvicie)
            Crea_Parametro(Cmd, "@CabelloImplantacion", SqlDbType.Int, ImplantacionCabello)

            Crea_Parametro(Cmd, "@FrenteAltura", SqlDbType.Int, AlturaFrante)
            Crea_Parametro(Cmd, "@FrenteInclinacion", SqlDbType.Int, InclinacionFrente)
            Crea_Parametro(Cmd, "@FrenteAncho", SqlDbType.Int, AnchoFrente)

            Crea_Parametro(Cmd, "@CejasDireccion", SqlDbType.Int, DireccionCejas)
            Crea_Parametro(Cmd, "@CejasImplantacion", SqlDbType.Int, ImplantacionCejas)
            Crea_Parametro(Cmd, "@CejasForma", SqlDbType.Int, FormaCejas)
            Crea_Parametro(Cmd, "@CejasTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@OjosColor", SqlDbType.Int, ColorOjos)
            Crea_Parametro(Cmd, "@OjosForma", SqlDbType.Int, FormaOjos)
            Crea_Parametro(Cmd, "@OjosTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@NarizRaiz", SqlDbType.Int, RaizNariz)
            Crea_Parametro(Cmd, "@NarizDorso", SqlDbType.Int, DorsoNariz)
            Crea_Parametro(Cmd, "@NarizAncho", SqlDbType.Int, AnchoNariz)
            Crea_Parametro(Cmd, "@NarizBase", SqlDbType.Int, BaseNariz)
            Crea_Parametro(Cmd, "@NarizAltura", SqlDbType.Int, AlturaNariz)

            Crea_Parametro(Cmd, "@BocaTamano", SqlDbType.Int, TamanoBoca)
            Crea_Parametro(Cmd, "@BocaComisuras", SqlDbType.Int, ComisurasBoca)

            Crea_Parametro(Cmd, "@LabiosEspesor", SqlDbType.Int, EspesorLabios)
            Crea_Parametro(Cmd, "@LabiosAlturaNasoLabial", SqlDbType.Int, AlturaNasoLabial)
            Crea_Parametro(Cmd, "@LabiosProminencia", SqlDbType.Int, ProminenciaLabios)

            Crea_Parametro(Cmd, "@MentonTipo", SqlDbType.Int, TipoMenton)
            Crea_Parametro(Cmd, "@MentonForma", SqlDbType.Int, FormaMenton)
            Crea_Parametro(Cmd, "@MentonInclinacion", SqlDbType.Int, InclinacionMenton)

            Crea_Parametro(Cmd, "@OrejaForma", SqlDbType.Int, FormaOreja)
            Crea_Parametro(Cmd, "@OrejaOriginal", SqlDbType.Int, OriginalOreja)
            Crea_Parametro(Cmd, "@HelixSuperior", SqlDbType.Int, HelixSuperior)
            Crea_Parametro(Cmd, "@HelixPosterior", SqlDbType.Int, HelixPosterior)
            Crea_Parametro(Cmd, "@HelixAdherencia", SqlDbType.Int, HelixAdherencia)
            Crea_Parametro(Cmd, "@HelixContorno", SqlDbType.Int, HelixContorno)
            Crea_Parametro(Cmd, "@LobuloAdherencia", SqlDbType.Int, LobuloAdherencia)
            Crea_Parametro(Cmd, "@LobuloParticularidad", SqlDbType.Int, LobuloParticularidad)
            Crea_Parametro(Cmd, "@LobuloDimension", SqlDbType.Int, LobuloDimension)

            Crea_Parametro(Cmd, "@SangreTipo", SqlDbType.Int, TipoSangre)
            Crea_Parametro(Cmd, "@SangreFactorRH", SqlDbType.Int, FactorRH)
            Crea_Parametro(Cmd, "@UsaAnteojos", SqlDbType.VarChar, UsaAnteojos)
            Crea_Parametro(Cmd, "@Estatura", SqlDbType.Money, Estatura)
            Crea_Parametro(Cmd, "@Peso", SqlDbType.Money, Peso)

            Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosDatosReingreso_Nuevo(ByVal IdReingreso As Integer, ByVal Id As Integer) As Boolean

        'Aquí se insertan los Datos de las demas tablas del Empleado Reingresado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosReingreso_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id) 'Este es el nuevo Id que se genero 
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reingreso", SqlDbType.Int, IdReingreso) 'Este es el Id que se le asigno la primea vez que se dio de alta en el sistema
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Cn_Datos.EjecutarNonQueryT(Cmd)

        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
        Trans.Commit()
        Return True
    End Function

    Public Shared Function fn_Empleados_LlenarListaEmpleados(ByVal lsv As cp_Listview) As Boolean
        'En esta función se llena una lists con todos los Empleados en Cat_Empleados, Activos y Baja
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosCombo_GetTodos", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_CursosRecibidos_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer) As Boolean
        'En esta función se llena una lists con todos los Empleados en Cat_Empleados, Activos y Baja
        Dim cmd As SqlCommand = Crea_Comando("Cap_Programacion_GetEmpleado", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            lsv.Actualizar(cmd, "Id_Programacion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_BuscarLugar(ByVal CodigoPostal As String) As DataTable
        Dim Cmd As SqlCommand = Crea_Comando("Buscar_Lugar", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.VarChar, CodigoPostal)

        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(Cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function



#Region "Nueva Forma de manejar los documentos de los empleados 22-oct-15"
    Public Shared Function fn_EmpleadosDoctosI_Lista(ByVal Id_Empleado As Integer) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosDoctosI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosDoctos_Guardar(ByVal Id_Empleado As Integer, ByVal Id_DoctoR As Integer, ByVal Id_Docto As Integer,
                                                      ByVal Nombre_Archivo As String, ByVal MimeType As String, ByVal Archivo As Byte(), ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand = Nothing
        Try
            If Id_Docto = 0 Then
                cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosDoctos_Create")
                Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Cn_Datos.Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Id_DoctoR)
                Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Id_Docto = EjecutarScalarT(cmd)
                cmd.Parameters.Clear()
            End If

            cmd = Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosDoctosI_Create")
            Crea_Parametro(cmd, "@Id_EmpleadoDocto", SqlDbType.Int, Id_Docto)
            Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Nombre_Archivo, False)
            Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, MimeType)
            Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Archivo)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            EjecutarNonQueryT(cmd)
            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, False)
            Return False

        End Try
    End Function

    Public Shared Function fn_EmpleadosDoctosI_Eliminar(ByVal Id_EmpleadoDoctoI As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosDoctosI_Delete", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoDoctoI", SqlDbType.Int, Id_EmpleadoDoctoI)
            EjecutaConsulta(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosDoctos_EliminarMasivo(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand = Nothing
        Try
            For Each ItemDocto As ListViewItem In lsv.Items
                cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosDoctosI_Delete")
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoDoctoI", SqlDbType.Int, ItemDocto.Tag)
                EjecutarNonQueryT(cmd)
                cmd.Parameters.Clear()
            Next

            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, False)
            Return False

        End Try
    End Function

#End Region

#End Region

#Region "DOCUMENTOS RECIBIDOS DE EMPLEADOS"

    Public Shared Function fn_EmpleadosDoctos_Actualizar(ByVal Id_Empleado As Integer, ByVal lsv As cp_Listview) As Boolean

        'solo registra el documento al empleado, las imagenes se gestionan desde la vetana de Cargar Doctos.
        Dim Id_NuevoDocto As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand

        Try
            For Each Elemento As ListViewItem In lsv.Items
                If Elemento.Checked AndAlso Elemento.SubItems(3).Text = 0 Then
                    'Crear Elemento Nuevo
                    cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctos_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Elemento.Tag)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Id_NuevoDocto = EjecutarScalarT(cmd)
                ElseIf Elemento.Checked = False AndAlso Elemento.SubItems(3).Text <> 0 Then
                    'Se eliminará el Documento Recibido si existe.
                    cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctos_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoDocto", SqlDbType.Int, Elemento.SubItems(3).Text)
                    EjecutarNonQueryT(cmd)
                End If
            Next

            trans.Commit()
            Cnn.Dispose()
            Arreglo_Archivo = Nothing
            Return True
        Catch ex As Exception
            trans.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosEmpleado_CargarArreglo(ByVal Id_Empleado As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosDoctosI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count - 1) ' 1/oct/2012 puse -1
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_EmpleadoDoctoI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("DescripcionArchivo")
                    Arreglo_Archivo(Contador).Extension_Archivo = Elemento("Id_DoctoR")
                    Arreglo_Archivo(Contador).Adicional_Archivo = Elemento("TipoDocumentoRecibido")
                    Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosEmpleado_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Empleado As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosDoctosR_GetEmpleado", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            lsv.Actualizar(cmd, "Id_DoctoR")

            If lsv.Columns.Count > 2 Then
                lsv.Columns(2).TextAlign = HorizontalAlignment.Right
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(2).Text = "SI" Then
                        Elemento.Checked = True
                    Else
                        Elemento.Checked = False
                    End If
                Next
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    '**************************Agregado CARLOS SOLA 17/06/13*****************************************
    Public Shared Function Fn_DoctosRequeridosCargar_LlenarDT(ByVal Id_Empleado As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctos_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function Fn_DoctosRequeridosNuevoReingreso(ByVal Id_Empleado As Integer, ByVal Id_Reingreso As Integer, ByVal Id_Docto As Integer) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand

        Dim Id_NuevoDocto As Integer
        Try
            cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctos_Create")
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Id_Docto)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Id_NuevoDocto = EjecutarScalarT(cmd)

            cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctosI_Reingreso_Create")
            Crea_Parametro(cmd, "@Id_Reingreso", SqlDbType.Int, Id_Reingreso)
            Crea_Parametro(cmd, "@Id_EmpleadoDocto", SqlDbType.Int, Id_NuevoDocto)
            Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Id_Docto)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            EjecutarNonQueryT(cmd)

            trans.Commit()
            Cnn.Dispose()
            Return True
        Catch ex As Exception
            trans.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try

    End Function
    '**************************Agregado CARLOS SOLA 17/06/13*****************************************

#End Region

#Region "EMPLEADOS BAJA"

    Public Shared Function fn_EmpleadosBaja_Nuevo(ByVal Id_Empleado As Integer, ByVal Fecha_FinLabores As DateTime, ByVal Observaciones As String, ByVal Id_MotivoB As Integer, ByVal Status As String, ByVal BajaInmediata As Boolean, ByVal ListaNegra As Boolean, ByVal NombreParaListaNegra As String, ByVal MotivoParaListaNegra As String, ByVal PuestoParaListaNegra As String, ByVal Id_Puesto As Integer, ByVal Id_Departamento As Integer) As Boolean
        Dim Id_Baja As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand
        Dim Id_ListaNegra As Integer = 0

        Try
            If ListaNegra Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosListaNegra_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreParaListaNegra)
                Cn_Datos.Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, EmpresaNombre)
                Cn_Datos.Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, PuestoParaListaNegra)
                Cn_Datos.Crea_Parametro(Cmd, "@Motivo", SqlDbType.VarChar, MotivoParaListaNegra)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Id_ListaNegra = Cn_Datos.EjecutarScalarT(Cmd)
            End If

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosBajas_Create")
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@UsuarioRegistro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@EstacionRegistro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@FechaBaja", SqlDbType.DateTime, Fecha_FinLabores)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(Cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
            Id_Baja = EjecutarScalarT(Cmd)

            If BajaInmediata Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_Empleados_Baja")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
                Cn_Datos.Crea_Parametro(Cmd, "@Fecha_FinLabores", SqlDbType.Date, Fecha_FinLabores)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Seg_Guardias_StatusByEmpleado")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Seg_Supervisores_StatusByEmpleado")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Calcular")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
                EjecutarNonQueryT(Cmd)
            End If

            Tr.Commit()
            Cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosBaja_Actualizar(ByVal Id_Baja As Integer, ByVal FechaBaja As DateTime, ByVal Observaciones As String, ByVal Id_MotivoB As Integer, ByVal Status As String, ByVal Id_Puesto As Integer, ByVal Id_Departamento As Integer,
                                                       ByVal ListaNegra As Boolean, ByVal Id_ListaNegra As Integer, ByVal Id_Empleado As Integer, ByVal NombreParaListaNegra As String, ByVal PuestoParaListaNegra As String, ByVal MotivoParaListaNegra As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            If ListaNegra Then
                If Id_ListaNegra = 0 Or Id_ListaNegra = Nothing Then
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosListaNegra_Create")
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreParaListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, EmpresaNombre)
                    Cn_Datos.Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, PuestoParaListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Motivo", SqlDbType.VarChar, MotivoParaListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Id_ListaNegra = Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosListaNegra_Update")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreParaListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, EmpresaNombre)
                    Cn_Datos.Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, PuestoParaListaNegra)
                    Cn_Datos.Crea_Parametro(Cmd, "@Motivo", SqlDbType.VarChar, MotivoParaListaNegra)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            ElseIf Id_ListaNegra > 0 Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosListaNegra_Delete")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
                Cn_Datos.EjecutarNonQueryT(Cmd)
                Id_ListaNegra = 0
            Else
                Id_ListaNegra = 0
            End If

            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosBajas_Update")
            Crea_Parametro(Cmd, "@Id_Baja", SqlDbType.Int, Id_Baja)
            Crea_Parametro(Cmd, "@UsuarioRegistro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@EstacionRegistro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(Cmd, "@FechaBaja", SqlDbType.DateTime, FechaBaja)
            Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(Cmd, "@Id_MotivoB", SqlDbType.Int, Id_MotivoB)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
            EjecutarNonQueryT(Cmd)

            If Status = "V" Then
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Empleados_Baja")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
                Cn_Datos.Crea_Parametro(Cmd, "@Fecha_FinLabores", SqlDbType.Date, FechaBaja)
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Seg_Guardias_StatusByEmpleado")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Seg_Supervisores_StatusByEmpleado")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Calcular")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
                EjecutarNonQueryT(Cmd)
            End If

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosBaja_Borrar(ByVal Id As Integer) As Boolean

        'Aquí se borra el registro de Baja del Empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosBajas_Delete", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosBaja_ActualizarAuto() As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim trans As SqlTransaction = crear_Trans(Cnn)

        Try
            Dim Cmd As SqlCommand = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_Empleados_UpdateAuto")
            Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)

            EjecutarNonQueryT(Cmd)
            trans.Commit()
            Return True
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosBaja_ObtenValores(ByVal Id_Empleado As Integer) As DataRow
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosBajas_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Dim Tbl As DataTable = EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosBaja_LitsaNegra(ByVal Id_ListaNegra As Integer) As DataRow
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosListaNegra_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
            Dim Tbl As DataTable = EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "Actualiza Credencial"

    Public Shared Function ImageToByteArray(ByVal imageIn As Image) As Byte()
        'pasa de imagen a byte 9 agosto
        Dim ms As New IO.MemoryStream()
        imageIn.Save(ms, Imaging.ImageFormat.Jpeg)
        Return ms.ToArray()

    End Function

    Public Shared Function ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        'pasa de byte a imagen
        Dim ms As New IO.MemoryStream(byteArrayIn)
        Return Image.FromStream(ms)

    End Function

    Public Shared Function fn_EmpleadosI_ActualizaCredencial(ByVal Id_Empleado As Integer, ByVal Foto As Byte()) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            'guardar las imagenes si las hay
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosI_UpdateFotoCredencial", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            If Foto IsNot Nothing Then Cn_Datos.Crea_Parametro(CmdF, "@Foto", SqlDbType.Image, Foto)


            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXFI_ActualizaCredencial(ByVal Id_Empleado As Integer, ByVal Foto As Byte()) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            'guardar las imagenes si las hay
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXFI_UpdateFotoCredencial", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            If Foto IsNot Nothing Then Cn_Datos.Crea_Parametro(CmdF, "@Foto", SqlDbType.Image, Foto)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


#End Region

#Region "EXPEDICION DE CREDENCIALES"
    'jueves 15 von 2012 recortar imagenes
    Public Shared Function fn_Empleados_RecortarImagen(ByVal Id_Empleado As Integer) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_GetRecortaImagen", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Return EjecutaConsulta(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_RecortarImagen(ByVal Id_Empleado As Integer) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_GetRecortaImagen", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Return EjecutaConsulta(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    'Public Shared Function Firmas() As DataTable
    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosExportarFirmas", CommandType.StoredProcedure, Cnn)

    '        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        If Tbl.Rows.Count = 0 Then
    '            Return Nothing
    '        Else
    '            Return Tbl
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function


    Public Shared Function fn_Credenciales_ObtenValoresZebra(ByVal Id_Empleado As Integer, ByVal Status As String) As DataRow
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_GetZebra", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Status_Credencial", SqlDbType.VarChar, Status)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Credenciales_ObtenValoresZebraArmas(ByVal Id_Empleado As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("SI_ArmasAsigna_GetAsignados", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Credenciales_ObtenValores(ByVal Id_Credencial As Integer) As DataRow
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_GetDetalle", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Credencial", SqlDbType.Int, Id_Credencial)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_CredencialesXF_ObtenValores(ByVal Id_Credencial As Integer) As DataRow
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXFCredenciales_GetDetalle", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Credencial", SqlDbType.Int, Id_Credencial)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosCred_ObtenValores(ByVal Id_Empleado As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_GetDCredenciales", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosXFCred_ObtenValores(ByVal Id_Empleado As Integer) As DataRow

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_GetDCredenciales", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Credenciales_Validar(ByVal Id_Empleado As Integer, ByVal Tipo As Byte) As Boolean
        'Aquí se valida si existe un folio vigente para el Empleado seleccionado
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_Read", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Credenciales_Nuevo(ByVal Id_Empleado As Integer, ByVal Folio As String, ByVal FechaExpide As DateTime, ByVal EntregoAnterior As String,
                                                 ByVal FechaExpira As Date, ByVal Comentarios As String, ByVal Id_MotivoE As Integer, ByVal UsuarioAutoriza As Integer, ByVal Tipo As Byte) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_Create", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Folio", SqlDbType.VarChar, Folio) 'coRre 21/10/2014
            Cn_Datos.Crea_Parametro(Cmd, "@FechaExpide", SqlDbType.DateTime, FechaExpide)
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioExpide", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionExpide", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@EntregoAnterior", SqlDbType.VarChar, EntregoAnterior)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaExpira", SqlDbType.Date, FechaExpira)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoE", SqlDbType.Int, Id_MotivoE)
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioAutoriza", SqlDbType.Int, UsuarioAutoriza)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionAutoriza", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.TinyInt, Tipo)

            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "AUTORIZACION DE CREDENCIALES"  'Del formulario donde se imprimen las credenciales

    Public Shared Function fn_Credenciales_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_GetByStatus", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "V")

            lsv.Actualizar(Cmd, "Id_Credencial")
            lsv.Columns(7).Width = 0
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Credenciales_LlenarListaXF(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXFCredenciales_GetByStatus", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "V")

            lsv.Actualizar(Cmd, "Id_Credencial")
            lsv.Columns(7).Width = 0
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Credenciales_Actualizar(ByVal Status As String, ByVal Tipo As String, ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Try
            Dim Cmd As SqlClient.SqlCommand
            For Each element As ListViewItem In lsv.CheckedItems
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosCredenciales_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Credencial", SqlDbType.Int, element.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, element.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
                Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Empleado", SqlDbType.TinyInt, element.SubItems(11).Text)

                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
        Trans.Commit()
        Return True
    End Function

    Public Shared Function fn_Empleados_FechaVenceCred_Actualizar(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Try
            For Each element As ListViewItem In lsv.CheckedItems
                Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Empleados_UpdateFechaVenceCred")

                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, element.SubItems(8).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@FechaExpira", SqlDbType.DateTime, element.SubItems(5).Text)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        Trans.Commit()
        Return True
    End Function

    Public Shared Function fn_Empleados_FechaVenceCred_ActualizarUno(ByVal Id_Empleado As Integer, ByVal Fecha As Date) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_UpdateFechaVenceCred", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaExpira", SqlDbType.DateTime, Fecha)
            Cn_Datos.EjecutarNonQuery(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

#End Region

#Region "CONSULTA DE CREDENCIALES"

    Public Shared Function fn_CredencialesConsulta_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal Status As String, ByVal StatusE As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosCredenciales_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Cn_Datos.Crea_Parametro(Cmd, "@StatusE", SqlDbType.VarChar, StatusE)

            lsv.Actualizar(Cmd, "Id_Credencial")
            lsv.Columns(10).Width = 0
            lsv.Columns(11).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "IMPRESION DE CREDENCIALES"

    Public Shared Function fn_Credenciales_Generar(ByVal Id_Credencial As Integer, ByVal TipoEmpleado As Byte) As rpt_Credencial
        Dim rpt As New rpt_Credencial
        Dim Ds As New ds_Credencial

        Call fn_Credenciales_LlenarDataSet(Ds, Id_Credencial, TipoEmpleado)
        rpt.SetDataSource(Ds)
        Return rpt
    End Function

    Public Shared Function fn_CredencialesR_Generar(ByVal Id_Credencial As Integer, ByVal TipoEmpleado As Byte) As rpt_CredencialR
        Dim rpt As New rpt_CredencialR
        Dim Ds As New ds_Credencial

        fn_Credenciales_LlenarDataSet(Ds, Id_Credencial, TipoEmpleado)
        rpt.SetDataSource(Ds)
        Return rpt
    End Function

    Public Shared Sub fn_Credenciales_LlenarDataSet(ByRef Ds As ds_Credencial, ByVal Id_Credencial As Integer, ByVal TipoEmpleado As Byte)

        Dim Procedure As String = "Cat_EmpleadosCredenciales_GetDetalle"
        If TipoEmpleado = 2 Then Procedure = "Cat_EmpleadosXFCredenciales_GetDetalle"

        Dim cmd As SqlCommand = Crea_Comando(Procedure, CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Credencial", SqlDbType.Int, Id_Credencial)
        Try
            cmd.Connection.Open()
            Ds.Cat_EmpleadosCredenciales_GetDetalle.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Function fn_ConsultarPlantillaCampos(ByVal Clave_Plantilla As String, ByVal Tipo_Plantilla As Integer) As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_ImpresionPlantillaD_Get2", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Tipo_Plantilla", SqlDbType.Int, Tipo_Plantilla)
        Crea_Parametro(Cmd, "@Clave_Plantilla", SqlDbType.VarChar, Clave_Plantilla)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Contacto Empleado"

    Public Shared Function fn_Contacto_Nuevo(ByVal Id_Empleado As Integer, ByVal Id_Localizacion As Integer, ByVal Descripcion As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleadoslocaliza_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(Cmd, "@Id_Tlocalizacion", SqlDbType.Int, Id_Localizacion)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_Contacto_CargarLista(ByRef lsv As cp_Listview, ByVal Id_Empleado As Integer) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleadoslocaliza_Get", CommandType.StoredProcedure, Cnn)

        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoLocaliza")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contacto_Borrar(ByVal Id_EmpleadoLocaliza As Integer) As Boolean


        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleadoslocaliza_Delete", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_EmpleadoLocaliza", SqlDbType.Int, Id_EmpleadoLocaliza)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ContactoP_Nuevo(ByVal Id_Empleado As Integer, ByVal Id_Localizacion As Integer, ByVal Descripcion As String) As Boolean

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPlocaliza_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(Cmd, "@Id_Tlocalizacion", SqlDbType.Int, Id_Localizacion)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ContactoP_CargarLista(ByRef lsv As cp_Listview, ByVal Id_Empleado As Integer) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPlocaliza_Get", CommandType.StoredProcedure, Cnn)

        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoPLocaliza")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ContactoP_Borrar(ByVal Id_EmpleadoLocaliza As Integer) As Boolean


        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPlocaliza_Delete", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_EmpleadoLocaliza", SqlDbType.Int, Id_EmpleadoLocaliza)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "TIPOS DE SANGRE"
    Public Shared Function fn_TipoSangre_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSangre_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoSangre")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoSangre_Validar(ByVal Grupo As String, ByVal Tipo As String) As Boolean

        'Aquí se valida si existe el Tipo de Sangre
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSangre_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Grupo", SqlDbType.VarChar, Grupo)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)
        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoSangre_Nuevo(ByVal Grupo As String, ByVal Tipo As String) As Boolean

        'Aqui se inserta una nuevo Tipo de Sangre
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSangre_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Grupo", SqlDbType.VarChar, Grupo)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


#End Region

#Region "GRADOS ESCOLARES"

    Public Shared Function fn_GradosEscolares_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GradosEscolares_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_GradoEscolar")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GradosEscolares_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Grado Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GradosEscolares_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_GradosEscolares_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Grado Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GradosEscolares_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_GradosEscolares_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Grado Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GradosEscolares_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_GradosEscolares_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Grado Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_GradosEscolares_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "TIPOS DE PARENTESCOS"

    Public Shared Function fn_TiposParentescos_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoParentesco_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoParentesco")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoParentesco_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Parentesco
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoParentesco_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoParentesco_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Parentesco
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoParentesco_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoParentesco_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Tipo de Parentesco
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoParentesco_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoParentesco", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoParentesco_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Parentesco
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoParentesco_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoParentesco", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "TIPOS DE LICENCIA"


    Public Shared Function fn_TipoLicencia_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoLicencia_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoLicencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoLicencia_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Licencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoLicencia_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoLicencia_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Licencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoLicencia_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoLicencia_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Tipo de Licencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoLicencia_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoLicencia", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoLicencia_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Licencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoLicencia_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoLicencia", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "TIPOS DE REFERENCIA"

    Public Shared Function fn_TipoReferencia_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Tiporeferencia_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoReferencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoReferencia_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Referencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoReferencia_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoReferencia_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Referencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Tiporeferencia_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Tiporeferencia_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Tipo de referencia
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoReferencia_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Tiporeferencia", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoReferencia_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Referencia
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoReferencia_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoReferencia", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "DOCUMENTOS ESCOLARES"

    Public Shared Function fn_TipoDoctoEscolar_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDoctoEscolar_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoDoctoEscolar")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoDoctoEscolar_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Documento Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDoctoEscolar_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoDoctoEscolar_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Documento Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDoctoEscolar_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoDoctoEscolar_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Tipo de Documento Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDoctoEscolar_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoDoctoEscolar_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Documento Escolar
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoDoctoEscolar_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "TIPOS DE COMPLEXION"


    Public Shared Function fn_TipoComplexion_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoComplexion_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoComplexion")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoComplexion_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Complexión
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoComplexion_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoComplexion_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Complexion
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoComplexion_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoComplexion_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Tipo de Complexión
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoComplexion_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoComplexion", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoComplexion_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Complexion
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoComplexion_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Tipocomplexion", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "SEÑAS PARTICULARES"


    Public Shared Function fn_TipoSena_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSenas_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoSena")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoSena_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Seña Particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSena_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_TipoSena_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Seña Particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSena_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_TipoSena_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Tipo Seña Particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSena_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoSena_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza un Tipo de Seña Particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoSena_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "COLOR DE OJOS"

    Public Shared Function fn_ColorOjos_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorOjos_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_ColorOjos")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ColorOjos_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Color de Ojos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorOjos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorOjos_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Color de Ojos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorOjos_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ColorOjos_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Color de Ojos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorOjos_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorOjos", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorOjos_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Color de Ojos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorOjos_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorOjos", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "COLOR DE CABELLO"


    Public Shared Function fn_ColorCabello_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorCabello_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_ColorCabello")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ColorCabello_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Color de Cabello
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorCabello_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorCabello_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Color de Cabello
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorCabello_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ColorCabello_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Color de Cabello
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorCabello_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorCabello", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorCabello_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Color de Cabello
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorCabello_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorCabello", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "COLOR DE PIEL"


    Public Shared Function fn_ColorPiel_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorPiel_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_ColorPiel")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ColorPiel_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Color de Piel
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorPiel_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorPiel_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Color de Piel
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorPiel_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ColorPiel_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Color de Piel
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorPiel_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorPiel", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ColorPiel_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Color de Piel
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ColorPiel_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_ColorPiel", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "TIPO DE VIVIENDA"


    Public Shared Function fn_TipoVivienda_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoVivienda_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_TipoVivienda")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoVivienda_Validar(ByVal Descripcion As String) As Boolean

        'Aquí se valida si existe el Tipo de Vivienda
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoVivienda_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoVivienda_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Tipo de Vivienda
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoVivienda_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_TipoVivienda_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean

        'Aqui se actualiza un Tipo de Vivienda
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoVivienda_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_TipoVivienda_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Tipo de Vivienda
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_TipoVivienda_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "CATÁLOGO DOCUMENTOS REQUERIDOS"

    Public Shared Function fn_DoctosRequeridos_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        'Aqui se llena el listview de los Documentos Requeridos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctosR_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_DoctoR")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctosRequeridos_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean
        'Aqui se actualiza el Status de un Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctosR_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_DoctoR", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctosRequeridos_Validar(ByVal Descripcion As String) As Boolean
        'Aquí se valida si existe el Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctosR_ReadValidar", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctosRequeridos_Nuevo(ByVal Descripcion As String) As Boolean
        'Aqui se inserta un nuevo Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctosR_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctosRequeridos_Actualizar(ByVal Id As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        'Aqui se actualiza un Documento Requerido
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDoctosR_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_DoctoR", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "MOTIVOS BAJA"

    Public Shared Function fn_MotivosBaja_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        Try
            'Aqui se llena el listview de los Motivos de Baja
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosBaja_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)

            lsv.Actualizar(Cmd, "Id_MotivoB")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_MotivosBaja_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Motivo de Baja
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosBaja_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoB", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_MotivosBaja_Validar(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean

        'Aqui se filtran todos los casos
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosBajaClave_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_MotivoB", SqlDbType.VarChar, Clave)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_MotivosBaja_Nuevo(ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Motivo de Baja
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosBaja_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_MotivosBaja_Actualizar(ByVal Id As Integer, ByVal Descripcion As String) As Boolean

        'Aqui se actualiza un Motivos Baja
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosBaja_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoB", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "CATALOGO DE MOTIVOS DE EXPEDICION DE CREDENCIALES"

    Public Shared Function fn_MotivosExpedicion_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosExpedicionC_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_MotivoE")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_MotivosExpedicion_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean

        'Aqui se actualiza el Status de un Motivo de Expedición
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosExpedicionC_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoE", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_MotivosExpedicion_Validar(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean

        'Aqui se valida si existe la Clave de Motivos de Expedición
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosExpedicionC_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_MotivoE", SqlDbType.VarChar, Clave)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_MotivosExpedicion_Nuevo(ByVal Clave As String, ByVal Descripcion As String) As Boolean

        'Aqui se inserta un nuevo Motivo de Expedición
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosExpedicionC_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Clave_MotivoE", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_MotivosExpedicion_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String) As Boolean

        'Aqui se actualiza un Motivos Expedición
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_MotivosExpedicionC_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_MotivoE", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_MotivoE", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


#End Region

#Region "CATALOGO DE IMPLEMENTOS"

    Public Shared Function fn_Implementos_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Implementos_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_Implemento")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Implementos_CambiarStatus(ByVal Id As Integer, ByVal Status As String) As Boolean
        'Aqui se actualiza el Status de un Implemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Implementos_Status", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Implementos_Validar(ByVal Clave As String, ByVal ClaveAnt As String) As Boolean
        'Aqui se filtran todos los casos
        If ClaveAnt = "" Then GoTo Validar
        If Not Clave = ClaveAnt Then GoTo Validar
        Return True
        Exit Function
Validar:
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Implementos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave", SqlDbType.VarChar, Clave)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Implementos_Nuevo(ByVal Clave As String, ByVal Descripcion As String, ByVal Precio As Integer, ByVal Id_Proveedor As Integer) As Integer
        Dim Id_Implemento As Integer = 0

        'Aqui se inserta un nuevo Implemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Implementos_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Precio", SqlDbType.Money, Precio)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Id_Implemento = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_Implemento
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Implementos_Actualizar(ByVal Id As Integer, ByVal Clave As String, ByVal Descripcion As String, ByVal Precio As Integer, ByVal Id_Proveedor As Integer, ByVal Status As String) As Boolean
        'Aqui se actualiza un Implemento
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Implementos_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.Int, Id)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave", SqlDbType.VarChar, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@Precio", SqlDbType.Money, Precio)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Proveedor", SqlDbType.Int, Id_Proveedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ImplementosInventarios_Nuevo(ByVal Id_Implemento As Integer) As Boolean
        'Aqui se inserta un nuevo Implemento en el Inventario de la Sucursal
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ImplementosInventario_Create", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.VarChar, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.VarChar, Id_Implemento)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Try
            Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "INVENTARIO DE IMPLEMENTOS"

    Public Shared Function fn_ImplementosInventarios_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ImplementosInventario_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "Id_Inventario")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_ImplementosInventarios_Actualizar(ByVal Id_Inventario As Integer, ByVal Stock As Integer, ByVal Existencia As Integer) As Boolean

        'Aqui se inserta un nuevo Implemento en el Inventario de la Sucursal
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ImplementosInventario_Update", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
        Cn_Datos.Crea_Parametro(Cmd, "@StockMinimo", SqlDbType.Int, Stock)
        Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, Existencia)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



#End Region

#Region "ASIGNACION DE IMPLEMENTOS"

    Public Shared Function fn_ImplementosInventarios_ObtenValores() As DataTable
        'Aqui se obtiene toda la Papeleria Recibida de un Empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ImplementosInventario_Read", CommandType.StoredProcedure, Cnn)

        Try
            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosImplementos_Nuevo(ByVal trans As SqlTransaction, ByVal Id_Empleado As Integer, ByVal Id_Implemento As Integer, ByVal Cantidad As Integer, ByVal Comentarios As String) As Boolean

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(trans.Connection, trans, CommandType.StoredProcedure, "Cat_EmpleadosImplementos_Create")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.Int, Id_Implemento)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, Cantidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Asigna", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Asigna", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

        Cn_Datos.EjecutarScalarT(Cmd)

    End Function


    Public Shared Function fn_ImplementosInventario_ActualizarExistencia(ByVal trans As SqlTransaction, ByVal Id_Inventario As Integer, ByVal Id_Implemento As Integer, ByVal Existencia As Integer) As Boolean

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(trans.Connection, trans, CommandType.StoredProcedure, "Cat_ImplementosInventario_UpdateExistencia")

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Inventario", SqlDbType.Int, Id_Inventario)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.Int, Id_Implemento)
        Cn_Datos.Crea_Parametro(Cmd, "@Existencia", SqlDbType.Int, Existencia)


        Cn_Datos.EjecutarNonQueryT(Cmd)

    End Function

    Public Shared Function fn_ImplementosAsignar_Transaccion(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        Try
            Dim dt As DataTable = fn_ImplementosInventarios_ObtenValores()
            Dim Existencia As Integer = 0

            'Aquí se recorre el listado de Implementos agrgados para insertar y actualizar las tablas correspondientes
            For Each elemento As ListViewItem In lsv.Items
                'Aquí se recorre el datatable con el inventario de todos los Implementos
                For Each dr_Implementos As DataRow In dt.Rows
                    If dr_Implementos("Id_Inventario") = elemento.SubItems(4).Text Then
                        'Cuando coincide el ID del datatable y el del listado
                        Existencia = dr_Implementos("Existencia")
                        Existencia -= elemento.Text
                        fn_EmpleadosImplementos_Nuevo(trans, elemento.SubItems(5).Text, elemento.SubItems(3).Text, elemento.Text, elemento.SubItems(2).Text)
                        fn_ImplementosInventario_ActualizarExistencia(trans, dr_Implementos("Id_Inventario"), elemento.SubItems(3).Text, Existencia)

                    End If
                Next
            Next

        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try

        trans.Commit()
        Return True
    End Function

#End Region

#Region "DEVOLUCION DE IMPLEMENTOS"

    Public Shared Function fn_ImpementosDevolucion_ObtenValores(ByVal Id_Empleado As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosImplementos_Read", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ImplementosInventario_Actualizar(ByVal Id_Empleado As Integer, ByVal dt As DataTable) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        Try
            For Each dr As DataRow In dt.Rows
                Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_ImplementosInventario_UpdateDevoluciones")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Implemento", SqlDbType.Int, dr("Id_Implemento"))
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Dev", SqlDbType.Int, IIf(IsDBNull(dr("Cantidad_Devolucion")), 0, dr("Cantidad_Devolucion")))
                Cn_Datos.EjecutarNonQueryT(Cmd)

                Cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosImplementos_Update")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoImplemento", SqlDbType.Int, dr("Id_EmpleadoImplemento"))
                Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Dev", SqlDbType.Int, IIf(IsDBNull(dr("Cantidad_Devolucion")), 0, dr("Cantidad_Devolucion")))
                Cn_Datos.Crea_Parametro(Cmd, "@Comentarios_Dev", SqlDbType.VarChar, dr("Comentarios_Devolucion"))
                Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Dev", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Dev", SqlDbType.VarChar, EstacioN)
                Cn_Datos.EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

#End Region

#Region "CARTAS DE ACCESO"

    Public Shared Function fn_CartasAcceso_Nuevo(ByVal Observaciones As String, ByVal UsuarioAutoriza As Integer, ByVal Items As cp_Listview.ListViewItemCollection, ByVal FechaInicio As Date, ByVal FechaFin As Date, ByVal Tipo As String, ByVal EmpleadoDestino As Integer) As Integer

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim Id_Carta As Integer = 0

        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_CartasAcceso_Create")
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioRegistro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionRegistro", SqlDbType.VarChar, EstacioN)
            'Cn_Datos.Crea_Parametro(Cmd, "@EmpresaVisitante", SqlDbType.VarChar, EmpresaVisitante)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioAutoriza", SqlDbType.Int, UsuarioAutoriza)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Date, FechaInicio)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Date, FechaFin)
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
            Cn_Datos.Crea_Parametro(Cmd, "@Empleado_Destino", SqlDbType.Int, EmpleadoDestino)
            Id_Carta = Cn_Datos.EjecutarScalarT(Cmd)

            If Id_Carta = 0 Then
                trans.Rollback()
                Return 0
            End If

            For Each elemento As ListViewItem In Items
                Cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_CartasAccesoD_Create")
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
                Cn_Datos.Crea_Parametro(Cmd, "@NombreVisitante", SqlDbType.VarChar, elemento.SubItems(1).Text)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, elemento.Tag)
                Cn_Datos.Crea_Parametro(Cmd, "@EmpresaVisitante", SqlDbType.VarChar, elemento.SubItems(2).Text)
                If EjecutarNonQueryT(Cmd) = 0 Then
                    trans.Rollback()
                    Return 0
                End If
            Next

        Catch ex As Exception
            TrataEx(ex)
            trans.Rollback()
            Return 0
        End Try
        trans.Commit()
        Return Id_Carta

    End Function


    Public Shared Function fn_CartasAcceso_GeneraReporte(ByVal Id_Carta As Integer) As rpt_CartaAcceso

        Dim rpt As New rpt_CartaAcceso
        Dim Ds As New Ds_CartaAcceso

        fn_CartasAcceso_LlenarDataSet(Ds, Id_Carta)

        '--------------pruebas de imagen en reportes {
        If Not IsDBNull(Ds.Cat_CartasAcceso_GetRpt.Rows(0)("logo")) Then

            Dim imagenNueva As Image = Nothing
            Dim imagenBytes As Byte() = Ds.Cat_CartasAcceso_GetRpt.Rows(0)("logo")
            Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
            imagenNueva = Image.FromStream(ms_ByteToImagen, True)

            Dim Ancho As Integer = imagenNueva.Width
            Dim Alto As Integer = imagenNueva.Height
            Dim valordiv As Decimal = 0.0

            With rpt.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                Dim Top_Obj As Integer = .Top
                Dim Left_Obj As Integer = .Left '+- 342default
                Dim Width_Obj As Integer = .Width '1440Default

                If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                Dim nuevoAncho As Integer = Ancho * valordiv
                Dim NuevoAlto As Integer = Alto * valordiv

                If Ancho > Alto Then
                    'horizontal
                    Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                    .Top = Top_Obj
                Else
                    'vertical,cuadrado
                    Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                    .Left = Left_Obj
                End If
                .Width = nuevoAncho
                .Height = NuevoAlto
            End With

            '-------liberar objetos
            ms_ByteToImagen.Dispose()
            imagenNueva.Dispose()
        End If
        '--------------}


        rpt.SetDataSource(Ds)
        Return rpt

    End Function


    Public Shared Sub fn_CartasAcceso_LlenarDataSet(ByRef Ds As Ds_CartaAcceso, ByVal Id_Carta As Integer)

        Dim cmd As SqlCommand = Crea_Comando("Cat_CartasAcceso_GetRpt", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

        Try
            cmd.Connection.Open()
            Ds.Cat_CartasAcceso_GetRpt.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Function fn_CartasAcceso_ObtenerEmpresa() As DataRow

        Dim cmd As SqlCommand = Crea_Comando("Cat_Empresas_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empresa", SqlDbType.Int, EmpresaId)

        Try
            Dim dt As DataTable = EjecutaConsulta(cmd)
            If dt.Rows.Count = 0 Then
                Return Nothing
            Else
                Return dt.Rows(0)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

#End Region

#Region "CONSULTA DE CARTAS DE ACCESO"

    Public Shared Function fn_CartasAccesoConsulta_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer, ByVal FechaDesde As DateTime, ByVal FechaHasta As DateTime, ByVal Status As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CartasAcceso_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(Cmd, "Id_Carta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_CartasAccesoConsulta_LlenarDetalle(ByVal lsv As cp_Listview, ByVal Id_Carta As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CartasAccesoD_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)

            lsv.Actualizar(Cmd, "Id_Carta")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function


    Public Shared Function fn_CartasAccesoConsulta_ActualizarStatus(ByVal Id_Carta As Integer, ByVal Status As String) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CartasAcceso_Status", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Carta", SqlDbType.Int, Id_Carta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioCancela", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@EstacionCancela", SqlDbType.VarChar, EstacioN)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "CONFIGURACION DE NOTIFICACIONES"

    Public Shared Function fn_ConfiguracionNotificaciones_LlenarListaPuestos(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Puestos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            lsv.Actualizar(Cmd, "Id_Puesto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConfiguracionNotificaciones_LlenarListaDepartamentos(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Departamentos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            lsv.Actualizar(Cmd, "Id_Departamento")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConfiguracionNotificaciones_LlenarListaDepNotificar(ByVal lsv As cp_Listview, ByVal Id_Puesto As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosNotifica_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)

            lsv.Actualizar(Cmd, "Id_EmpleadoNotifica")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConfiguracionNotificaciones_Guardar(ByVal Id_Puesto As Integer, ByVal lsvD As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosNotifica_Create", CommandType.StoredProcedure, Cnn)

            For Each element As ListViewItem In lsvD.CheckedItems
                Cmd.Parameters.Clear()
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
                Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, element.Tag)
                EjecutarScalar(Cmd)
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConfiguracionNotificaciones_Borrar(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosNotifica_Delete", CommandType.StoredProcedure, Cnn)

            For Each element As ListViewItem In lsv.CheckedItems
                Cmd.Parameters.Clear()
                Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoNotifica", SqlDbType.Int, element.Tag)
                EjecutarNonQuery(Cmd)
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "PLANTILLA POR DEPARTAMENTO"

    Public Shared Function fn_PlantillaDepartamento_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand
        Dim SubTotal As Integer

        Try
            Cmd = Cn_Datos.Crea_Comando("Cat_PuestosPlantilla_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            lsv.Actualizar(Cmd, "Id_Plantilla")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right

            For J As Byte = 0 To lsv.Items.Count - 1
                SubTotal = (lsv.Items(J).SubItems(2).Text) - (lsv.Items(J).SubItems(3).Text)
                If SubTotal > 0 Then
                    lsv.Items(J).ForeColor = Color.OrangeRed
                End If
                lsv.Items(J).SubItems(4).Text = SubTotal
            Next

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_PlantillaDepartamento_Guardar(ByVal Id_Plantilla As Integer, ByVal Plantilla_Req As Integer, ByVal Plantilla_Act As Integer) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_PuestosPlantilla_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Plantilla", SqlDbType.Int, Id_Plantilla)
        Crea_Parametro(Cmd, "@PlantillaRequerida", SqlDbType.Int, Plantilla_Req)
        Crea_Parametro(Cmd, "@PlantillaActual", SqlDbType.Int, Plantilla_Act)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function Fn_Plantilla_Recalculo() As Boolean
        Dim Dt_Empleados As DataTable
        Dim Dt_PxD As DataTable
        Dim Dt_Plantilla As DataTable
        Dim Nuevo As Boolean = True
        Dim Num As Integer = 0
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetPlantilla", CommandType.StoredProcedure, Cnn)
        Try
            Dt_Empleados = EjecutaConsulta(Cmd)

        Catch ex As Exception
            Return False
        End Try
        Cmd = Crea_Comando("Cat_DepartamentosPuestos_GetPlantilla", CommandType.StoredProcedure, Cnn)
        Try
            Dt_PxD = EjecutaConsulta(Cmd)
        Catch ex As Exception
            Return False
        End Try
        Cmd = Crea_Comando("Cat_PuestosPlantilla_GetRecalculo", CommandType.StoredProcedure, Cnn)
        Try
            Dt_Plantilla = EjecutaConsulta(Cmd)
        Catch ex As Exception
            Return False
        End Try
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            For Each Dr_Puesto As DataRow In Dt_PxD.Rows
                Nuevo = True
                For Each Dr_Plantilla As DataRow In Dt_Plantilla.Rows
                    If Dr_Puesto("Id_Departamento") = Dr_Plantilla("Id_Departamento") And Dr_Puesto("Id_Puesto") = Dr_Plantilla("Id_Puesto") Then
                        Nuevo = False
                    End If
                Next
                If Nuevo Then
                    Dim Cnn2 As SqlConnection = Crea_ConexionSTD()
                    Dim Cmd2 As SqlCommand = Crea_Comando("Cat_PuestosPlantilla_Create", CommandType.StoredProcedure, Cnn2)
                    Crea_Parametro(Cmd2, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(Cmd2, "@Id_Departamento", SqlDbType.Int, Dr_Puesto("Id_Departamento"))
                    Crea_Parametro(Cmd2, "@Id_Puesto", SqlDbType.Int, Dr_Puesto("Id_Puesto"))
                    Crea_Parametro(Cmd2, "@Plantilla_Requerida", SqlDbType.Int, 0)
                    Crea_Parametro(Cmd2, "@Plantilla_Actual", SqlDbType.Int, 0)
                    Crea_Parametro(Cmd2, "@Comentarios", SqlDbType.VarChar, "")
                    EjecutarNonQuery(Cmd2)
                    Num += 1
                End If
            Next
            For Each DR_Empleados As DataRow In Dt_Empleados.Rows
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Update2")
                Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, DR_Empleados("Id_Departamento"))
                Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, DR_Empleados("Id_Puesto"))
                Crea_Parametro(Cmd, "@Plantilla_Actual", SqlDbType.Int, DR_Empleados("Cantidad"))
                EjecutarNonQueryT(Cmd)
            Next
            Tr.Commit()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_PlantillaDepartamento_Eliminar(ByVal Id_Plantilla As Integer) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand

        Try
            Cmd = Crea_Comando("Cat_Plantilla_Delete", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Plantilla", SqlDbType.Int, Id_Plantilla)
            EjecutarNonQuery(Cmd)

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
        Return True
    End Function

#End Region

#Region "PLANTILLA POR PUESTO"

    Public Shared Function fn_PlantillaPuesto_LlenarDT(ByVal Id_Depto As Integer) As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand
        Dim dt As DataTable
        Try
            Cmd = Crea_Comando("Cat_PuestosPlantilla_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Depto)

            dt = EjecutaConsulta(Cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_PlantillaPuestos_LlenarListaDeptos(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Departamentos_GetByStatus", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            lsv.Actualizar(Cmd, "Id_Departamento")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_PlantillaPuestos_LlenarListaPuestos(ByVal lsv As cp_Listview) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Puestos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Pista", SqlDbType.VarChar, "")

            lsv.Actualizar(Cmd, "Id_Puesto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_PlantillaPuestos_Guardar(ByVal dt As DataTable) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim trans As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            For Each dr As DataRow In dt.Rows
                If dr("Id_PlantillaP") = 0 Then
                    Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_PuestoPlantilla_Create")
                    Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                    Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, dr("IdPuesto"))
                    Crea_Parametro(Cmd, "@PlantillaRequerida", SqlDbType.Int, dr("Plantilla Requerida"))
                    Crea_Parametro(Cmd, "@PlantillaActual", SqlDbType.Int, dr("Plantilla Actual"))
                Else
                    Cmd = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Update")
                    Crea_Parametro(Cmd, "@Id_PlantillaP", SqlDbType.Int, dr("Id_PlantillaP"))
                    Crea_Parametro(Cmd, "@PlantillaRequerida", SqlDbType.Int, dr("Plantilla Requerida"))
                    Crea_Parametro(Cmd, "@PlantillaActual", SqlDbType.Int, dr("Plantilla Actual"))
                End If
                EjecutarNonQueryT(Cmd)
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

#End Region

#Region "Consulta de Plantilla"

    Public Shared Function fn_PlantillaConsulta_ObtenerDepto() As Integer

        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand
        Dim DeptoId As Integer

        Try
            Cmd = Cn_Datos.Crea_Comando("Cat_Empleados_GetDepto", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, UsuarioId)

            DeptoId = EjecutarScalar(Cmd)
            Return DeptoId
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try

    End Function

    Public Shared Function fn_PlantillaConsulta_LlenarLista(ByVal lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlCommand

            Cmd = Cn_Datos.Crea_Comando("Cat_Plantilla_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

            lsv.Actualizar(Cmd, "Id_Plantilla")
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function



    Public Shared Function fn_PlantillaConsulta_LlenarListaD(ByVal lsv As cp_Listview, ByVal Id_Depto As Integer, ByVal Id_Puesto As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_GetByPuestoDpto", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Depto)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            lsv.Actualizar(Cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Consulta de Reingresos"
    Public Shared Function fn_EmpleadosReingresos_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal Status As String) As Boolean
        Try

            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand

            Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosReingresos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(Cmd, "Id_Empleado")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
#End Region

#Region "CONSULTA DE EMPLEADOS DADOS DE BAJA"

    Public Shared Function fn_EmpleadosBaja_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal FechaDesde As Date, ByVal FechaHasta As Date, Optional ByVal Tipo As Integer = 1) As Boolean
        Try
            'Tipo = 1 = Empleados
            'Tipo = 2 = Prospectos
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand
            If Tipo = 1 Then
                Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosBajas_Get", CommandType.StoredProcedure, Cnn)
            Else
                Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosP_GetBajas", CommandType.StoredProcedure, Cnn)
            End If

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaDesde", SqlDbType.Date, FechaDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@FechaHasta", SqlDbType.Date, FechaHasta)

            If Tipo = 1 Then
                lsv.Actualizar(Cmd, "Id_Baja")
            Else
                lsv.Actualizar(Cmd, "Id_EmpleadoP")
            End If
            lsv.Columns(10).Width = 200
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "CATALOGO DE PROSPECTOS"

    Public Shared Function fn_Prospectos_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer,
                                                     ByVal Id_Puesto As Integer, ByVal Status As String,
                                                     ByVal FDesde As Date, ByVal FHasta As Date, ByVal Apto As Char) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_GetCatalogo", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
            Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
            Crea_Parametro(Cmd, "@Apto", SqlDbType.VarChar, Apto)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_EmpleadoP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosP_ValidarClave(ByVal Clave As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPClave_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_EmpleadoP", SqlDbType.VarChar, Clave)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl IsNot Nothing AndAlso Tbl.Rows.Count > 0 Then '--
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosP_IncrementaEmpleadoP(ByVal Clave_Guardada As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_IncrementaEmpleadoP", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(CmdF, "@Ult_EmpleadoP", SqlDbType.Int, Clave_Guardada)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosP_Nuevo(ByVal Clave As String, ByVal NombreCompleto As String,
                                               ByVal Departamento As Integer, ByVal Puesto As Integer,
                                               ByVal Sexo As Char, ByVal EstadoCivil As Integer, ByVal Mail As String,
                                               ByVal Catalogo As String,
                                               ByVal APaterno As String, ByVal AMaterno As String, ByVal Nombres As String,
                                               ByVal SueldoBase As Decimal, ByVal Calle As String, ByVal NumExterior As Integer,
                                               ByVal NumInterior As String,
                                               ByVal Colonia As String, ByVal Zona As Integer, ByVal CodigoPostal As Integer,
                                               ByVal Telefono As String, ByVal TelefonoMovil As String, ByVal FechaNac As Date,
                                               ByVal LugarNac As String,
                                               ByVal RFC As String, ByVal CURP As String, ByVal IMSS As String,
                                               ByVal IFE As String, ByVal TipoLicencia As Integer,
                                               ByVal FechaExpira As Date,
                                               ByVal NumCartilla As String, ByVal Certificacion As String,
                                               ByVal ConFamilia As String, ByVal CantidadHijos As Integer,
                                               ByVal Edad As Integer, ByVal Id_EmpleadoRef As Integer,
                                               ByVal EntreCalle1 As String, ByVal EntreCalle2 As String,
                                               ByVal ModoNacionalidad As Byte,
                                               ByVal PaisNacimiento As String, ByVal FechaNaturalizacion As Date,
                                               ByVal Pasaporte As String, ByVal Jefe_Area As Char, ByVal Latitud As Decimal,
                                               ByVal Longitud As Decimal, ByVal UMF As String,
                                               ByVal Id_ModoContactoD As Integer, ByVal lsv_Entrevistas As cp_Listview,
                                               ByVal Sale_Ruta As Char, ByVal Credito_Infonavit As Char,
                                               ByVal Verifica_Servicios As Char, ByVal Ciudad_Nacimiento As Integer,
                                               ByVal Numero_Credito As String, ByVal Tipo_Descuento As String,
                                               ByVal Monto_Descuento As Decimal,
                                               ByVal NumeroLicencia As String,
                                               ByVal NumeroLicenciaFed As String,
                                               ByVal FechaExpiraFed As Date,
                                               ByVal IdTributario As String) As Integer

        'Aquí se inserta un nuevo prospecto
        Dim cnn As SqlClient.SqlConnection
        Dim tr As SqlTransaction
        Dim cmd As SqlClient.SqlCommand
        Dim Id_EmpleadoP As Integer = 0
        Dim Id_Entrevista As Integer = 0
        Try
            'validar clave antes d einsertar prospecto 31/03/2014
            If fn_EmpleadosP_ValidarClave(Clave) Then
                'si regresa 0 esporke la clave ya se insertó
                Return 0
            End If

            cnn = Cn_Datos.Crea_ConexionSTD
            tr = Cn_Datos.crear_Trans(cnn)
            cmd = Cn_Datos.Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosP_Create")

            Cn_Datos.Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(cmd, "@Clave_EmpleadoP", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
            Cn_Datos.Crea_Parametro(cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Cn_Datos.Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(cmd, "@Catalogo", SqlDbType.VarChar, Catalogo)
            Cn_Datos.Crea_Parametro(cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Cn_Datos.Crea_Parametro(cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Cn_Datos.Crea_Parametro(cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Cn_Datos.Crea_Parametro(cmd, "@Sueldo_Base", SqlDbType.Money, SueldoBase)
            Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, Calle)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroExterior", SqlDbType.Int, NumExterior)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroInterior", SqlDbType.VarChar, NumInterior)
            Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Cn_Datos.Crea_Parametro(cmd, "@Zona", SqlDbType.Int, Zona)
            Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, CodigoPostal)
            Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Cn_Datos.Crea_Parametro(cmd, "@TelefonoMovil", SqlDbType.VarChar, TelefonoMovil)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNacimiento", SqlDbType.DateTime, FechaNac)
            Cn_Datos.Crea_Parametro(cmd, "@LugarNacimiento", SqlDbType.VarChar, LugarNac)
            Cn_Datos.Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            Cn_Datos.Crea_Parametro(cmd, "@CURP", SqlDbType.VarChar, CURP)
            Cn_Datos.Crea_Parametro(cmd, "@IMSS", SqlDbType.VarChar, IMSS)
            Cn_Datos.Crea_Parametro(cmd, "@IFE", SqlDbType.VarChar, IFE)
            Cn_Datos.Crea_Parametro(cmd, "@TipoLicencia", SqlDbType.Int, TipoLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@FechaExpira", SqlDbType.DateTime, FechaExpira)
            Cn_Datos.Crea_Parametro(cmd, "@NumCartilla", SqlDbType.VarChar, NumCartilla)
            Cn_Datos.Crea_Parametro(cmd, "@Certificacion", SqlDbType.VarChar, Certificacion)
            Cn_Datos.Crea_Parametro(cmd, "@ConFamilia", SqlDbType.VarChar, ConFamilia)
            Cn_Datos.Crea_Parametro(cmd, "@CantidadHijos", SqlDbType.Int, CantidadHijos)
            Cn_Datos.Crea_Parametro(cmd, "@Edad", SqlDbType.Int, Edad)
            'Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, FechaIngreso)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoRef", SqlDbType.Int, Id_EmpleadoRef)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, EntreCalle1)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, EntreCalle2)
            Cn_Datos.Crea_Parametro(cmd, "@ModoNacionalidad", SqlDbType.Int, ModoNacionalidad)
            Cn_Datos.Crea_Parametro(cmd, "@PaisNacimiento", SqlDbType.VarChar, PaisNacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNaturalizacion", SqlDbType.Date, FechaNaturalizacion)
            Cn_Datos.Crea_Parametro(cmd, "@Pasaporte", SqlDbType.VarChar, Pasaporte)
            Cn_Datos.Crea_Parametro(cmd, "@Jefe_Area", SqlDbType.VarChar, Jefe_Area)
            Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, Latitud)
            Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, Longitud)
            Cn_Datos.Crea_Parametro(cmd, "@UMF", SqlDbType.VarChar, UMF)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Id_ModoContactoD", SqlDbType.VarChar, Id_ModoContactoD)
            Cn_Datos.Crea_Parametro(cmd, "@Sale_Ruta", SqlDbType.VarChar, Sale_Ruta)
            Cn_Datos.Crea_Parametro(cmd, "@Credito_Infonavit", SqlDbType.VarChar, Credito_Infonavit)
            Cn_Datos.Crea_Parametro(cmd, "@Verifica_Servicios", SqlDbType.VarChar, Verifica_Servicios)
            Cn_Datos.Crea_Parametro(cmd, "@Ciudad_Nacimiento", SqlDbType.Int, Ciudad_Nacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Numero_Credito", SqlDbType.VarChar, Numero_Credito)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, Tipo_Descuento)
            Cn_Datos.Crea_Parametro(cmd, "@Monto_Descuento", SqlDbType.Decimal, Monto_Descuento)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicencia", SqlDbType.VarChar, NumeroLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicenciaFed", SqlDbType.VarChar, NumeroLicenciaFed)
            Cn_Datos.Crea_Parametro(cmd, "@IdTributario", SqlDbType.VarChar, IdTributario)

            Id_EmpleadoP = Cn_Datos.EjecutarScalarT(cmd)

            If Id_EmpleadoP > 0 Then
                'Guardar las Entrevistas
                For Each Elemento As ListViewItem In lsv_Entrevistas.Items
                    cmd.Parameters.Clear()
                    cmd = Cn_Datos.Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosPentrevistas_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(cmd, "@Fecha_Entrevista", SqlDbType.Date, Elemento.Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Empleado_Entrevista", SqlDbType.Int, Elemento.SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(cmd, "@Apto", SqlDbType.VarChar, Microsoft.VisualBasic.Left(Elemento.SubItems(2).Text, 1))
                    Cn_Datos.Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Elemento.SubItems(3).Text)

                    Id_Entrevista = Cn_Datos.EjecutarScalarT(cmd)
                Next
            End If
            tr.Commit()
            cmd.Dispose()
            Return Id_EmpleadoP
        Catch ex As Exception
            tr.Rollback()
            cmd.Dispose()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_Empleados_IncrementaProspecto(ByVal Clave_Guardada As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Sucursales_IncrementaEmpleadoP", CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(CmdF, "@Ult_EmpleadoP", SqlDbType.Int, Clave_Guardada)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_EmpleadosP_Update(ByVal Id_EmpleadoP As Integer, ByVal NombreCompleto As String,
                                                ByVal Departamento As Integer, ByVal Puesto As Integer,
                                                ByVal Sexo As Char, ByVal EstadoCivil As Integer, ByVal Mail As String,
                                                ByVal Catalogo As String,
                                               ByVal APaterno As String, ByVal AMaterno As String, ByVal Nombres As String,
                                                ByVal SueldoBase As Decimal, ByVal Calle As String, ByVal NumExterior As Integer,
                                                ByVal NumInterior As String,
                                               ByVal Colonia As String, ByVal Zona As Integer, ByVal CodigoPostal As Integer,
                                                ByVal Telefono As String, ByVal TelefonoMovil As String, ByVal FechaNac As Date,
                                                ByVal LugarNac As String,
                                               ByVal RFC As String, ByVal CURP As String, ByVal IMSS As String,
                                                ByVal IFE As String, ByVal TipoLicencia As Integer,
                                                ByVal FechaExpira As Date,
                                                ByVal NumCartilla As String, ByVal Certificacion As String,
                                               ByVal ConFamilia As String, ByVal CantidadHijos As Integer,
                                                ByVal Edad As Integer, ByVal Id_EmpleadoRef As Integer,
                                                ByVal EntreCalle1 As String, ByVal EntreCalle2 As String,
                                                ByVal ModoNacionalidad As Byte,
                                               ByVal PaisNacimiento As String, ByVal FechaNaturalizacion As Date,
                                                ByVal Pasaporte As String, ByVal Jefe_Area As Char, ByVal Latitud As Decimal,
                                                ByVal Longitud As Decimal, ByVal UMF As String,
                                               ByVal Id_ModoContactoD As Integer, ByVal Sale_Ruta As Char,
                                                ByVal Credito_Infonavit As Char, ByVal Verifica_Servicios As Char,
                                                ByVal Ciudad_Nacimiento As Integer, ByVal Numero_Credito As String,
                                               ByVal Tipo_Descuento As String, ByVal Monto_Descuento As Decimal,
                                                ByVal NumeroLicencia As String,
                                                ByVal NumeroLicenciaFed As String,
                                                ByVal FechaExpiraFed As Date,
                                                ByVal IdTributario As String) As Boolean

        Try

            'Aquí se inserta un nuevo prospecto
            Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_Update", CommandType.StoredProcedure, cnn)
            Dim Filas As Integer = 0

            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Departamento)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Puesto)
            Cn_Datos.Crea_Parametro(cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EstadoCivil", SqlDbType.Int, EstadoCivil)
            Cn_Datos.Crea_Parametro(cmd, "@Mail", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Catalogo", SqlDbType.VarChar, Catalogo)
            Cn_Datos.Crea_Parametro(cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Cn_Datos.Crea_Parametro(cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Cn_Datos.Crea_Parametro(cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Cn_Datos.Crea_Parametro(cmd, "@Sueldo_Base", SqlDbType.Money, SueldoBase)
            Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, Calle)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroExterior", SqlDbType.Int, NumExterior)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroInterior", SqlDbType.VarChar, NumInterior)
            Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Cn_Datos.Crea_Parametro(cmd, "@Zona", SqlDbType.Int, Zona)
            Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, CodigoPostal)
            Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Cn_Datos.Crea_Parametro(cmd, "@TelefonoMovil", SqlDbType.VarChar, TelefonoMovil)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNacimiento", SqlDbType.DateTime, FechaNac)
            Cn_Datos.Crea_Parametro(cmd, "@LugarNacimiento", SqlDbType.VarChar, LugarNac)
            Cn_Datos.Crea_Parametro(cmd, "@RFC", SqlDbType.VarChar, RFC)
            Cn_Datos.Crea_Parametro(cmd, "@CURP", SqlDbType.VarChar, CURP)
            Cn_Datos.Crea_Parametro(cmd, "@IMSS", SqlDbType.VarChar, IMSS)
            Cn_Datos.Crea_Parametro(cmd, "@IFE", SqlDbType.VarChar, IFE)
            Cn_Datos.Crea_Parametro(cmd, "@TipoLicencia", SqlDbType.Int, TipoLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@FechaExpira", SqlDbType.DateTime, FechaExpira)
            Cn_Datos.Crea_Parametro(cmd, "@NumCartilla", SqlDbType.VarChar, NumCartilla)
            Cn_Datos.Crea_Parametro(cmd, "@Certificacion", SqlDbType.VarChar, Certificacion)
            Cn_Datos.Crea_Parametro(cmd, "@ConFamilia", SqlDbType.VarChar, ConFamilia)
            Cn_Datos.Crea_Parametro(cmd, "@CantidadHijos", SqlDbType.Int, CantidadHijos)
            Cn_Datos.Crea_Parametro(cmd, "@Edad", SqlDbType.Int, Edad)
            'Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, FechaIngreso)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoRef", SqlDbType.Int, Id_EmpleadoRef)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, EntreCalle1)
            Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, EntreCalle2)
            Cn_Datos.Crea_Parametro(cmd, "@ModoNacionalidad", SqlDbType.Int, ModoNacionalidad)
            Cn_Datos.Crea_Parametro(cmd, "@PaisNacimiento", SqlDbType.VarChar, PaisNacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@FechaNaturalizacion", SqlDbType.Date, FechaNaturalizacion)
            Cn_Datos.Crea_Parametro(cmd, "@Pasaporte", SqlDbType.VarChar, Pasaporte)
            Cn_Datos.Crea_Parametro(cmd, "@Jefe_Area", SqlDbType.VarChar, Jefe_Area)
            Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, Latitud)
            Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, Longitud)
            Cn_Datos.Crea_Parametro(cmd, "@UMF", SqlDbType.VarChar, UMF)
            Cn_Datos.Crea_Parametro(cmd, "@Id_ModoContactoD", SqlDbType.Int, Id_ModoContactoD)
            Cn_Datos.Crea_Parametro(cmd, "@Sale_Ruta", SqlDbType.VarChar, Sale_Ruta)
            Cn_Datos.Crea_Parametro(cmd, "@Credito_Infonavit", SqlDbType.VarChar, Credito_Infonavit)
            Cn_Datos.Crea_Parametro(cmd, "@Verifica_Servicios", SqlDbType.VarChar, Verifica_Servicios)
            Cn_Datos.Crea_Parametro(cmd, "@Ciudad_Nacimiento", SqlDbType.Int, Ciudad_Nacimiento)
            Cn_Datos.Crea_Parametro(cmd, "@Numero_Credito", SqlDbType.VarChar, Numero_Credito)
            Cn_Datos.Crea_Parametro(cmd, "@Tipo_Descuento", SqlDbType.VarChar, Tipo_Descuento)
            Cn_Datos.Crea_Parametro(cmd, "@Monto_Descuento", SqlDbType.Decimal, Monto_Descuento)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicencia", SqlDbType.VarChar, NumeroLicencia)
            Cn_Datos.Crea_Parametro(cmd, "@NumeroLicenciaFed", SqlDbType.VarChar, NumeroLicenciaFed)
            Cn_Datos.Crea_Parametro(cmd, "@FechaExpiraFed", SqlDbType.DateTime, FechaExpiraFed)
            Cn_Datos.Crea_Parametro(cmd, "@IdTributario", SqlDbType.VarChar, IdTributario)
            Filas = Cn_Datos.EjecutarNonQuery(cmd)

            cmd.Dispose()
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosPentrevista_Nuevo(ByVal Id_EmpleadoP As Integer, ByVal Fecha_Entrevista As Date, ByVal Empleado_Entrevista As Integer, ByVal Apto As Char, ByVal Comentarios As String) As Boolean

        'Aquí se inserta un nuevo prospecto
        Dim cnn As SqlClient.SqlConnection
        Dim cmd As SqlClient.SqlCommand
        Dim Id_Entrevista As Integer = 0
        Try
            cnn = Cn_Datos.Crea_ConexionSTD
            cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosPentrevistas_Create", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Cn_Datos.Crea_Parametro(cmd, "@Fecha_Entrevista", SqlDbType.Date, Fecha_Entrevista)
            Cn_Datos.Crea_Parametro(cmd, "@Empleado_Entrevista", SqlDbType.Int, Empleado_Entrevista)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Apto", SqlDbType.VarChar, Apto)
            Cn_Datos.Crea_Parametro(cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)

            Id_Entrevista = Cn_Datos.EjecutarScalar(cmd)

            If Id_Entrevista > 0 Then
                ' consulta prospecto
                cmd = Cn_Datos.Crea_Comando("[Cat_EmpleadosP_GetAptos]", CommandType.StoredProcedure, cnn)
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Dim dt_aptos As DataTable = EjecutaConsulta(cmd)

                If IsDBNull(dt_aptos.Rows(0)("Apto")) OrElse dt_aptos.Rows(0)("Apto") = "N" Then
                    'Actualizar prospecto 'apto-No apto
                    cmd = Cn_Datos.Crea_Comando("[Cat_EmpleadosP_UpdateAptos]", CommandType.StoredProcedure, cnn)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(cmd, "@Apto", SqlDbType.VarChar, Apto)

                    EjecutarNonQuery(cmd)
                End If
            End If

            cmd.Dispose()
            Return True
        Catch ex As Exception
            cmd.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosP_ObtenValores(ByVal Id_EmpleadoP As Integer) As DataRow
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_Get", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

        Try

            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl.Rows.Count = 0 Then
                Return Nothing
            Else
                Return Tbl.Rows(0)
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Prospectos_Read(ByVal Id_EmpleadoP As Integer) As DataRow
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl Is Nothing Then
                Return Nothing
            Else
                If Tbl.Rows.Count = 0 Then
                    Return Nothing
                Else
                    Return Tbl.Rows(0)
                End If
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ProspectosEntrevistas_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_EmpleadoP As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPentrevistas_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Entrevista")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosEscolaresP_ObtenValores(ByVal Id As Integer) As DataRow
        'Aquí se obtienen los Datos Escolares del Empleado seleccionado
        Return fn_ObtenValores(Id, "Cat_EmpleadosPEscolares_Read", "@Id_EmpleadoP", False)
    End Function

    Public Shared Function fn_CursosRecibidosP_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todos los CURSOS RECIBIDOS de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPCursos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoPCurso")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosFamiliaresP_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        Try
            'Aqui se obtienen todos los DATOS FAMILIARES de un Empleado en particular
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPFamiliares_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id)
            lsv.Actualizar(Cmd, "Id_EmpleadoPFamiliares")
            lsv.Columns(10).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleosP_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        Try
            'Aqui se obtienen todos los EMPLEOS anteriores de un Empleado en particular
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPLaborales_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id)
            lsv.Actualizar(Cmd, "Id_EmpleadoPLaborales")
            lsv.Columns(4).TextAlign = HorizontalAlignment.Right
            lsv.Columns(5).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(9).TextAlign = HorizontalAlignment.Right
            lsv.Columns(10).TextAlign = HorizontalAlignment.Right
            lsv.Columns(17).TextAlign = HorizontalAlignment.Right
            lsv.Columns(18).TextAlign = HorizontalAlignment.Right
            lsv.Columns(23).Width = 0
            lsv.Columns(24).Width = 0
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReferenciasP_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        Try
            'Aqui se obtienen todas las REFERENCIAS de un Empleado en particular
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            '            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPReferencias_Read", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPReferencias_ReadSSP", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id)
            lsv.Actualizar(Cmd, "Id_EmpleadoPReferencia")
            lsv.Columns(13).Width = 0
            lsv.Columns(14).Width = 0
            lsv.Columns(15).Width = 0
            lsv.Columns(16).Width = 0
            lsv.Columns(17).Width = 0
            lsv.Columns(18).Width = 0
            lsv.Columns(19).Width = 0
            'lsv.Columns(20).Width = 0
            lsv.Columns(7).TextAlign = HorizontalAlignment.Right
            lsv.Columns(8).TextAlign = HorizontalAlignment.Right
            lsv.Columns(11).TextAlign = HorizontalAlignment.Right
            lsv.Columns(12).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosIngresosP_ObtenValores(ByVal Id As Integer) As DataRow
        'Aqui se obtienen toda la información de Ingresos de un Empleado en particular
        Return fn_ObtenValores(Id, "Cat_EmpleadosPIngresos_Read", "@Id_EmpleadoP", False)
    End Function

    Public Shared Function fn_SeñasParticularesP_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todas las Señas Particulares de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPSenas_Read", CommandType.StoredProcedure, Cnn)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPSenas_ReadSSP", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_EmpleadoPSena")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_RasgosP_ObtenValores(ByVal Id_EmpleadoP As Integer) As DataRow
        'Aqui se obtiene todos los Rasgos de un Empleado seleccionado
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPRasgos_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_RasgosP_Nuevo(ByVal Id_EmpleadoP As Integer, ByVal Complexion As Byte, ByVal ColorPiel As Byte, ByVal Cara As Byte, ByVal TipoSangre As Byte, ByVal FactorRH As Byte, ByVal Peso As Decimal, ByVal Estatura As Decimal, ByVal UsaAnteojos As String, ByVal CantidadCabello As Byte, ByVal ColorCabello As Byte, ByVal FormaCabello As Byte, ByVal Calvicie As Byte, ByVal ImplantacionCabello As Byte,
                                           ByVal AlturaFrante As Byte, ByVal InclinacionFrente As Byte, ByVal AnchoFrente As Byte, ByVal DireccionCejas As Byte, ByVal ImplantacionCejas As Byte, ByVal FormaCejas As Byte, ByVal TamanoCejas As Byte, ByVal ColorOjos As Byte, ByVal FormaOjos As Byte, ByVal TamanoOjos As Byte,
                                           ByVal RaizNariz As Byte, ByVal DorsoNariz As Byte, ByVal AnchoNariz As Byte, ByVal BaseNariz As Byte, ByVal AlturaNariz As Byte, ByVal TamanoBoca As Byte, ByVal ComisurasBoca As Byte, ByVal EspesorLabios As Byte, ByVal AlturaNasoLabial As Byte, ByVal ProminenciaLabios As Byte,
                                           ByVal TipoMenton As Byte, ByVal FormaMenton As Byte, ByVal InclinacionMenton As Byte, ByVal FormaOreja As Byte, ByVal OriginalOreja As Byte, ByVal HelixSuperior As Byte, ByVal HelixPosterior As Byte, ByVal HelixAdherencia As Byte, ByVal HelixContorno As Byte, ByVal LobuloAdherencia As Byte, ByVal LobuloParticularidad As Byte, ByVal LobuloDimension As Byte) As Integer

        Dim Id_EmpleadosPRasgos As Integer = 0

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPRasgos_Create", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Crea_Parametro(Cmd, "@Complexion", SqlDbType.Int, Complexion)
            Crea_Parametro(Cmd, "@PielColor", SqlDbType.Int, ColorPiel)
            Crea_Parametro(Cmd, "@CaraForma", SqlDbType.Int, Cara)

            Crea_Parametro(Cmd, "@CabelloCantidad", SqlDbType.Int, CantidadCabello)
            Crea_Parametro(Cmd, "@CabelloColor", SqlDbType.Int, ColorCabello)
            Crea_Parametro(Cmd, "@CabelloForma", SqlDbType.Int, FormaCabello)
            Crea_Parametro(Cmd, "@CabelloCalvicie", SqlDbType.Int, Calvicie)
            Crea_Parametro(Cmd, "@CabelloImplantacion", SqlDbType.Int, ImplantacionCabello)

            Crea_Parametro(Cmd, "@FrenteAltura", SqlDbType.Int, AlturaFrante)
            Crea_Parametro(Cmd, "@FrenteInclinacion", SqlDbType.Int, InclinacionFrente)
            Crea_Parametro(Cmd, "@FrenteAncho", SqlDbType.Int, AnchoFrente)

            Crea_Parametro(Cmd, "@CejasDireccion", SqlDbType.Int, DireccionCejas)
            Crea_Parametro(Cmd, "@CejasImplantacion", SqlDbType.Int, ImplantacionCejas)
            Crea_Parametro(Cmd, "@CejasForma", SqlDbType.Int, FormaCejas)
            Crea_Parametro(Cmd, "@CejasTamano", SqlDbType.Int, TamanoCejas)

            Crea_Parametro(Cmd, "@OjosColor", SqlDbType.Int, ColorOjos)
            Crea_Parametro(Cmd, "@OjosForma", SqlDbType.Int, FormaOjos)
            Crea_Parametro(Cmd, "@OjosTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@NarizRaiz", SqlDbType.Int, RaizNariz)
            Crea_Parametro(Cmd, "@NarizDorso", SqlDbType.Int, DorsoNariz)
            Crea_Parametro(Cmd, "@NarizAncho", SqlDbType.Int, AnchoNariz)
            Crea_Parametro(Cmd, "@NarizBase", SqlDbType.Int, BaseNariz)
            Crea_Parametro(Cmd, "@NarizAltura", SqlDbType.Int, AlturaNariz)

            Crea_Parametro(Cmd, "@BocaTamano", SqlDbType.Int, TamanoBoca)
            Crea_Parametro(Cmd, "@BocaComisuras", SqlDbType.Int, ComisurasBoca)

            Crea_Parametro(Cmd, "@LabiosEspesor", SqlDbType.Int, EspesorLabios)
            Crea_Parametro(Cmd, "@LabiosAlturaNasoLabial", SqlDbType.Int, AlturaNasoLabial)
            Crea_Parametro(Cmd, "@LabiosProminencia", SqlDbType.Int, ProminenciaLabios)

            Crea_Parametro(Cmd, "@MentonTipo", SqlDbType.Int, TipoMenton)
            Crea_Parametro(Cmd, "@MentonForma", SqlDbType.Int, FormaMenton)
            Crea_Parametro(Cmd, "@MentonInclinacion", SqlDbType.Int, InclinacionMenton)

            Crea_Parametro(Cmd, "@OrejaForma", SqlDbType.Int, FormaOreja)
            Crea_Parametro(Cmd, "@OrejaOriginal", SqlDbType.Int, OriginalOreja)
            Crea_Parametro(Cmd, "@HelixSuperior", SqlDbType.Int, HelixSuperior)
            Crea_Parametro(Cmd, "@HelixPosterior", SqlDbType.Int, HelixPosterior)
            Crea_Parametro(Cmd, "@HelixAdherencia", SqlDbType.Int, HelixAdherencia)
            Crea_Parametro(Cmd, "@HelixContorno", SqlDbType.Int, HelixContorno)
            Crea_Parametro(Cmd, "@LobuloAdherencia", SqlDbType.Int, LobuloAdherencia)
            Crea_Parametro(Cmd, "@LobuloParticularidad", SqlDbType.Int, LobuloParticularidad)
            Crea_Parametro(Cmd, "@LobuloDimension", SqlDbType.Int, LobuloDimension)

            Crea_Parametro(Cmd, "@SangreTipo", SqlDbType.Int, TipoSangre)
            Crea_Parametro(Cmd, "@SangreFactorRH", SqlDbType.Int, FactorRH)
            Crea_Parametro(Cmd, "@UsaAnteojos", SqlDbType.VarChar, UsaAnteojos)
            Crea_Parametro(Cmd, "@Estatura", SqlDbType.Money, Estatura)
            Crea_Parametro(Cmd, "@Peso", SqlDbType.Money, Peso)

            Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Id_EmpleadosPRasgos = EjecutarScalar(Cmd)
            Return Id_EmpleadosPRasgos
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_RasgosP_Actualizar(ByVal Id_EmpleadoP As Integer, ByVal Complexion As Integer, ByVal ColorPiel As Integer, ByVal Cara As Integer, ByVal TipoSangre As Integer, ByVal FactorRH As Byte, ByVal Peso As Decimal, ByVal Estatura As Decimal, ByVal UsaAnteojos As String, ByVal CantidadCabello As Integer, ByVal ColorCabello As Integer, ByVal FormaCabello As Integer, ByVal Calvicie As Integer, ByVal ImplantacionCabello As Integer,
                                           ByVal AlturaFrante As Integer, ByVal InclinacionFrente As Integer, ByVal AnchoFrente As Integer, ByVal DireccionCejas As Integer, ByVal ImplantacionCejas As Integer, ByVal FormaCejas As Integer, ByVal TamanoCejas As Integer, ByVal ColorOjos As Integer, ByVal FormaOjos As Integer, ByVal TamanoOjos As Integer,
                                           ByVal RaizNariz As Integer, ByVal DorsoNariz As Integer, ByVal AnchoNariz As Integer, ByVal BaseNariz As Integer, ByVal AlturaNariz As Integer, ByVal TamanoBoca As Integer, ByVal ComisurasBoca As Integer, ByVal EspesorLabios As Integer, ByVal AlturaNasoLabial As Integer, ByVal ProminenciaLabios As Integer,
                                           ByVal TipoMenton As Integer, ByVal FormaMenton As Integer, ByVal InclinacionMenton As Integer, ByVal FormaOreja As Integer, ByVal OriginalOreja As Integer, ByVal HelixSuperior As Integer, ByVal HelixPosterior As Integer, ByVal HelixAdherencia As Integer, ByVal HelixContorno As Integer, ByVal LobuloAdherencia As Integer, ByVal LobuloParticularidad As Integer, ByVal LobuloDimension As Integer) As Boolean

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPRasgos_Update", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Crea_Parametro(Cmd, "@Complexion", SqlDbType.Int, Complexion)
            Crea_Parametro(Cmd, "@PielColor", SqlDbType.Int, ColorPiel)
            Crea_Parametro(Cmd, "@CaraForma", SqlDbType.Int, Cara)

            Crea_Parametro(Cmd, "@CabelloCantidad", SqlDbType.Int, CantidadCabello)
            Crea_Parametro(Cmd, "@CabelloColor", SqlDbType.Int, ColorCabello)
            Crea_Parametro(Cmd, "@CabelloForma", SqlDbType.Int, FormaCabello)
            Crea_Parametro(Cmd, "@CabelloCalvicie", SqlDbType.Int, Calvicie)
            Crea_Parametro(Cmd, "@CabelloImplantacion", SqlDbType.Int, ImplantacionCabello)

            Crea_Parametro(Cmd, "@FrenteAltura", SqlDbType.Int, AlturaFrante)
            Crea_Parametro(Cmd, "@FrenteInclinacion", SqlDbType.Int, InclinacionFrente)
            Crea_Parametro(Cmd, "@FrenteAncho", SqlDbType.Int, AnchoFrente)

            Crea_Parametro(Cmd, "@CejasDireccion", SqlDbType.Int, DireccionCejas)
            Crea_Parametro(Cmd, "@CejasImplantacion", SqlDbType.Int, ImplantacionCejas)
            Crea_Parametro(Cmd, "@CejasForma", SqlDbType.Int, FormaCejas)
            Crea_Parametro(Cmd, "@CejasTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@OjosColor", SqlDbType.Int, ColorOjos)
            Crea_Parametro(Cmd, "@OjosForma", SqlDbType.Int, FormaOjos)
            Crea_Parametro(Cmd, "@OjosTamano", SqlDbType.Int, TamanoOjos)

            Crea_Parametro(Cmd, "@NarizRaiz", SqlDbType.Int, RaizNariz)
            Crea_Parametro(Cmd, "@NarizDorso", SqlDbType.Int, DorsoNariz)
            Crea_Parametro(Cmd, "@NarizAncho", SqlDbType.Int, AnchoNariz)
            Crea_Parametro(Cmd, "@NarizBase", SqlDbType.Int, BaseNariz)
            Crea_Parametro(Cmd, "@NarizAltura", SqlDbType.Int, AlturaNariz)

            Crea_Parametro(Cmd, "@BocaTamano", SqlDbType.Int, TamanoBoca)
            Crea_Parametro(Cmd, "@BocaComisuras", SqlDbType.Int, ComisurasBoca)

            Crea_Parametro(Cmd, "@LabiosEspesor", SqlDbType.Int, EspesorLabios)
            Crea_Parametro(Cmd, "@LabiosAlturaNasoLabial", SqlDbType.Int, AlturaNasoLabial)
            Crea_Parametro(Cmd, "@LabiosProminencia", SqlDbType.Int, ProminenciaLabios)

            Crea_Parametro(Cmd, "@MentonTipo", SqlDbType.Int, TipoMenton)
            Crea_Parametro(Cmd, "@MentonForma", SqlDbType.Int, FormaMenton)
            Crea_Parametro(Cmd, "@MentonInclinacion", SqlDbType.Int, InclinacionMenton)

            Crea_Parametro(Cmd, "@OrejaForma", SqlDbType.Int, FormaOreja)
            Crea_Parametro(Cmd, "@OrejaOriginal", SqlDbType.Int, OriginalOreja)
            Crea_Parametro(Cmd, "@HelixSuperior", SqlDbType.Int, HelixSuperior)
            Crea_Parametro(Cmd, "@HelixPosterior", SqlDbType.Int, HelixPosterior)
            Crea_Parametro(Cmd, "@HelixAdherencia", SqlDbType.Int, HelixAdherencia)
            Crea_Parametro(Cmd, "@HelixContorno", SqlDbType.Int, HelixContorno)
            Crea_Parametro(Cmd, "@LobuloAdherencia", SqlDbType.Int, LobuloAdherencia)
            Crea_Parametro(Cmd, "@LobuloParticularidad", SqlDbType.Int, LobuloParticularidad)
            Crea_Parametro(Cmd, "@LobuloDimension", SqlDbType.Int, LobuloDimension)

            Crea_Parametro(Cmd, "@SangreTipo", SqlDbType.Int, TipoSangre)
            Crea_Parametro(Cmd, "@SangreFactorRH", SqlDbType.Int, FactorRH)
            Crea_Parametro(Cmd, "@UsaAnteojos", SqlDbType.VarChar, UsaAnteojos)
            Crea_Parametro(Cmd, "@Estatura", SqlDbType.Money, Estatura)
            Crea_Parametro(Cmd, "@Peso", SqlDbType.Money, Peso)

            Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosEscolaresP_Actualizar(ByVal Id_EmpleadoP As Integer, ByVal Id_GradoEscolar As Integer, ByVal NombreEscuela As String, ByVal Carrera As String, ByVal Especialidad As String, ByVal Id_TipoDocto As Integer, ByVal Folio As String, ByVal FechaInicio As Integer, ByVal FechaFin As Integer, ByVal Promedio As Decimal, ByVal CedulaProfesional As String) As Boolean
        'Aquí se actualizan los Datos Escolares de un empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPEscolares_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id_GradoEscolar)
        Cn_Datos.Crea_Parametro(Cmd, "@NombreEscuela", SqlDbType.VarChar, NombreEscuela)
        Cn_Datos.Crea_Parametro(Cmd, "@Carrera", SqlDbType.VarChar, Carrera)
        Cn_Datos.Crea_Parametro(Cmd, "@Especialidad", SqlDbType.VarChar, Especialidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id_TipoDocto)
        Cn_Datos.Crea_Parametro(Cmd, "@FolioDocumento", SqlDbType.VarChar, Folio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Int, FechaInicio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Int, FechaFin)
        Cn_Datos.Crea_Parametro(Cmd, "@Promedio", SqlDbType.Money, Promedio)
        Cn_Datos.Crea_Parametro(Cmd, "@CedulaProfesional", SqlDbType.VarChar, CedulaProfesional)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosEscolaresP_Nuevo(ByVal Id_EmpleadoP As Integer, ByVal Id_GradoEscolar As Integer, ByVal NombreEscuela As String, ByVal Carrera As String, ByVal Especialidad As String, ByVal Id_TipoDocto As Integer, ByVal Folio As String, ByVal FechaInicio As Integer, ByVal FechaFin As Integer, ByVal Promedio As Decimal, ByVal CedulaProfesional As String) As Integer
        Dim Id_EmpleadoEscolar As Integer = 0
        'Aquí se inserta un nuevo registro de los Datos Escolares de un Empleado seleccionado o de uno nuevo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPEscolares_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_GradoEscolar", SqlDbType.Int, Id_GradoEscolar)
        Cn_Datos.Crea_Parametro(Cmd, "@NombreEscuela", SqlDbType.VarChar, NombreEscuela)
        Cn_Datos.Crea_Parametro(Cmd, "@Carrera", SqlDbType.VarChar, Carrera)
        Cn_Datos.Crea_Parametro(Cmd, "@Especialidad", SqlDbType.VarChar, Especialidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDoctoEscolar", SqlDbType.Int, Id_TipoDocto)
        Cn_Datos.Crea_Parametro(Cmd, "@FolioDocumento", SqlDbType.VarChar, Folio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.Int, FechaInicio)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.Int, FechaFin)
        Cn_Datos.Crea_Parametro(Cmd, "@Promedio", SqlDbType.Money, Promedio)
        Cn_Datos.Crea_Parametro(Cmd, "@CedulaProfesional", SqlDbType.VarChar, CedulaProfesional)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Id_EmpleadoEscolar = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_EmpleadoEscolar
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_CursosRecibidosP_Guardar(ByVal Id_EmpleadoP As Integer, ByVal lsv As ListView) As Boolean
        'Aquí se Guardan los Cursos Recibidos de un Prospecto seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cont As Integer = 0

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    'Curso nuevo
                    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPCursos_Create")

                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(Cmd, "@NombreCurso", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@FechaInicio", SqlDbType.DateTime, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@FechaFin", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Finalizado", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Instructor", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDocto", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    'Curso existente modificado
                    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPCursos_Update")

                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPCurso", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Inicio", SqlDbType.DateTime, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Fin", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Finalizado", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Instructor", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoDocumento", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@Interno", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Programacion", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_CursosRecibidosP_Borrar(ByVal Id_EmpleadoPCurso As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPCursos_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPCurso", SqlDbType.Int, Id_EmpleadoPCurso)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosFamiliaresP_Nuevo(ByVal Id_EmpleadoP As Integer, ByVal lsv As ListView) As Boolean
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If Not lsv.Items(cont).SubItems(0).Tag Is Nothing Then
                    If lsv.Items(cont).SubItems(0).Tag = 0 Then
                        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPFamiliares_Create")
                        Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                        Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@DepEconomico", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_TipoParentesco", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@FechaNac", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Direccion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(10).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@MismoDomicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(7).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Vive", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        Cn_Datos.EjecutarScalarT(cmd)
                    Else
                        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPFamiliares_Update")
                        Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoPFamiliares", SqlDbType.Int, lsv.Items(cont).Tag)
                        Cn_Datos.Crea_Parametro(cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@DepEconomico", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_TipoParentesco", SqlDbType.Int, lsv.Items(cont).SubItems(9).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@FechaNac", SqlDbType.DateTime, lsv.Items(cont).SubItems(2).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Direccion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(10).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@MismoDomicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(7).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Vive", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                        Cn_Datos.Crea_Parametro(cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                        Cn_Datos.Crea_Parametro(cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                        Cn_Datos.EjecutarNonQueryT(cmd)
                    End If
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_DatosFamiliaresP_Borrar(ByVal Id_EmpleadoPFamiliares As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPFamiliares_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPFamiliares", SqlDbType.Int, Id_EmpleadoPFamiliares)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleosP_Guardar(ByVal Id_EmpleadoP As Integer, ByVal lsv As ListView) As Boolean
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(cnn)
        'NombreEmpresa  item
        'Calle          subitem(1)
        'EntreCalle1    subitem(2)
        'EntreCalle2    subitem(3)
        'NumeroExt      subitem(4)
        'NumeroInt      subitem(5)
        'Colonia        subitem(6)
        'Ciudad         subitem(7)
        'CodigoPostal   subitem(8)
        'Latitud        subitem(9)
        'Longitud       subitem(10)
        'FIngreso       subitem(11)
        'FBaja          subitem(12)
        'Puesto         subitem(13)
        'NombreJefe     subitem(14)
        'PuestoJefe     subitem(15)
        'Telefono       subitem(16)
        'SueldoInicial  subitem(17)
        'SueldoFinal    subitem(18)
        'MotivoSep      subitem(19)
        'OtroMotivo     subitem(20)
        'EmpResaSeg     subitem(21)
        'PorteArmas     subitem(22)
        'Id_Ciudad      subitem(23)
        'Id_MotivoSep   subitem(24)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).SubItems(9).Text = "" Then lsv.Items(cont).SubItems(9).Text = "0"
                If lsv.Items(cont).SubItems(10).Text = "" Then lsv.Items(cont).SubItems(10).Text = "0"
                If lsv.Items(cont).Tag = 0 Then
                    Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPLaborales_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreEmpresa", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(23).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaBaja", SqlDbType.DateTime, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, lsv.Items(cont).SubItems(13).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PuestoJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoInicial", SqlDbType.Money, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoFinal", SqlDbType.Money, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_MotivoBaja", SqlDbType.Int, lsv.Items(cont).SubItems(24).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@OtroMotivo", SqlDbType.VarChar, lsv.Items(cont).SubItems(20).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EmpresaSegPriv", SqlDbType.VarChar, lsv.Items(cont).SubItems(21).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PorteArmas", SqlDbType.VarChar, lsv.Items(cont).SubItems(22).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(10).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarScalarT(cmd)
                Else
                    Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPLaborales_Update")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoPLaborales", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreEmpresa", SqlDbType.VarChar, lsv.Items(cont).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(23).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaIngreso", SqlDbType.DateTime, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@FechaBaja", SqlDbType.DateTime, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Puesto", SqlDbType.VarChar, lsv.Items(cont).SubItems(13).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@NombreJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PuestoJefe", SqlDbType.VarChar, lsv.Items(cont).SubItems(15).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoInicial", SqlDbType.Money, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@SueldoFinal", SqlDbType.Money, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_MotivoBaja", SqlDbType.Int, lsv.Items(cont).SubItems(24).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@OtroMotivo", SqlDbType.VarChar, lsv.Items(cont).SubItems(20).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@EmpresaSegPriv", SqlDbType.VarChar, lsv.Items(cont).SubItems(21).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@PorteArmas", SqlDbType.VarChar, lsv.Items(cont).SubItems(22).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Latitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Longitud", SqlDbType.Decimal, lsv.Items(cont).SubItems(10).Text)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarNonQueryT(cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_EmpleosP_Borrar(ByVal Id_EmpleadoLaborales As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPLaborales_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id_EmpleadoLaborales)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleosP_ObtenerPredictivoEmpresas() As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPLaborales_GetEmpresas", CommandType.StoredProcedure, Cnn)
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_GetPredictivo", CommandType.StoredProcedure, Cnn)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleosP_ObtenValoresPredictivo(ByVal Id As Integer, ByVal Tipo As Char) As DataRow
        'Aqui se obtienen todos los datos de la Empresa seleccionada en el Predictivo
        Dim Dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand
        If Tipo = "E" Then
            Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosLaborales_ReadEmpresas", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoLaborales", SqlDbType.Int, Id)
        ElseIf Tipo = "P" Then
            Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosPLaborales_ReadEmpresas", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id)
        End If

        Try
            Dt = EjecutaConsulta(Cmd)
            If Dt.Rows.Count > 0 Then
                Return Dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ReferenciasP_Guardar(ByVal Id_EmpleadoP As Integer, ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPReferencias_CreateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoReferencia", SqlDbType.Int, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ocupacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@OcupacionSSP", SqlDbType.Int, lsv.Items(cont).SubItems(17).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoP", SqlDbType.VarChar, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoM", SqlDbType.VarChar, lsv.Items(cont).SubItems(19).Text)
                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPReferencias_UpdateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPReferencia", SqlDbType.Int, lsv.Items(cont).Tag)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoReferencia", SqlDbType.Int, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ocupacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroExt", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@NumeroInt", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, lsv.Items(cont).SubItems(12).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, lsv.Items(cont).SubItems(16).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@CodigoPostal", SqlDbType.Int, lsv.Items(cont).SubItems(11).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle1", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@EntreCalle2", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.Crea_Parametro(Cmd, "@OcupacionSSP", SqlDbType.Int, lsv.Items(cont).SubItems(14).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoP", SqlDbType.VarChar, lsv.Items(cont).SubItems(18).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@ApellidoM", SqlDbType.VarChar, lsv.Items(cont).SubItems(19).Text)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_ReferenciasP_Borrar(ByVal Id_EmpleadoPReferencia As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPReferencias_Delete", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPReferencia", SqlDbType.Int, Id_EmpleadoPReferencia)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosIngresosP_Nuevo(ByVal Id_EmpleadoP, ByVal IngresoFamiliar, ByVal IngresoAdicional, ByVal DescripcionAdicional, ByVal GastoMensual, ByVal Id_TipoVivienda, ByVal PagoMensual, ByVal ValorVivienda, ByVal VehiculoPropio, ByVal Modelo, ByVal ValorVehiculo) As Integer
        Dim Id_EmpleadosPIngresos As Integer = 0

        'Aquí se está insertando el registro único de los Ingresos y otros de un Empleado seleccionado o nuevo
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPIngresos_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoMensual", SqlDbType.Money, IngresoFamiliar)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoAdicional", SqlDbType.Money, IngresoAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@DescripcionAdicional", SqlDbType.VarChar, DescripcionAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@GastoMensual", SqlDbType.Money, GastoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id_TipoVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@PagoMensual", SqlDbType.Money, PagoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVivienda", SqlDbType.Money, ValorVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@VehiculoPropio", SqlDbType.VarChar, VehiculoPropio)
        Cn_Datos.Crea_Parametro(Cmd, "@ModeloVehiculo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVehiculo", SqlDbType.Money, ValorVehiculo)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            Id_EmpleadosPIngresos = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_EmpleadosPIngresos
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_EmpleadosIngresosP_Actualizar(ByVal Id_EmpleadoP, ByVal IngresoFamiliar, ByVal IngresoAdicional, ByVal DescripcionAdicional, ByVal GastoMensual, ByVal Id_TipoVivienda, ByVal PagoMensual, ByVal ValorVivienda, ByVal VehiculoPropio, ByVal Modelo, ByVal ValorVehiculo)
        'Aquí se actualizan los datos de Ingresos y otros de un Empleado seleccionado
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPIngresos_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoMensual", SqlDbType.Money, IngresoFamiliar)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoAdicional", SqlDbType.Money, IngresoAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@DescripcionAdicional", SqlDbType.VarChar, DescripcionAdicional)
        Cn_Datos.Crea_Parametro(Cmd, "@GastoMensual", SqlDbType.Money, GastoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoVivienda", SqlDbType.Int, Id_TipoVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@PagoMensual", SqlDbType.Money, PagoMensual)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVivienda", SqlDbType.Money, ValorVivienda)
        Cn_Datos.Crea_Parametro(Cmd, "@VehiculoPropio", SqlDbType.VarChar, VehiculoPropio)
        Cn_Datos.Crea_Parametro(Cmd, "@ModeloVehiculo", SqlDbType.Int, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@ValorVehiculo", SqlDbType.Money, ValorVehiculo)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosP_ActualizarVarios(ByVal Id_EmpleadoP As Integer, ByVal Vicios As String, ByVal Habilidades As String, ByVal Actividades As String, ByVal Idiomas As String) As Boolean

        'Aquí se actualizan Algunos datos de la tabla Cat_Empleados del Empleado seleccionado o de uno nuevo
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_UpdateVarios", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@Vicios", SqlDbType.VarChar, Vicios)
        Cn_Datos.Crea_Parametro(Cmd, "@Habilidades", SqlDbType.VarChar, Habilidades)
        Cn_Datos.Crea_Parametro(Cmd, "@Actividades", SqlDbType.VarChar, Actividades)
        Cn_Datos.Crea_Parametro(Cmd, "@Idiomas", SqlDbType.VarChar, Idiomas)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosSenasP_Guardar(ByVal Id_EmpleadoP As Integer, ByVal lsv As cp_Listview)
        'Aquí se esta insertando un nuevo registro de Señas Particulares de un Empleado seleccionado o nuevo
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPSenas_CreateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

                    'Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(5).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@RegionSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@LadoSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarScalarT(Cmd)
                Else
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPSenas_UpdateSSP")
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPSena", SqlDbType.Int, lsv.Items(cont).Tag)

                    'Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    'Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@RegionSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Int, lsv.Items(cont).SubItems(4).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Forma", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Id_TipoSena", SqlDbType.Int, lsv.Items(cont).SubItems(7).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@Ubicacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(8).Text)
                    Cn_Datos.Crea_Parametro(Cmd, "@LadoSSP", SqlDbType.VarChar, lsv.Items(cont).SubItems(9).Text)

                    Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
                    Cn_Datos.EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_SeñasParticularesP_Borrar(ByVal Id_EmpleadoPSena As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPSenas_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPSena", SqlDbType.Int, Id_EmpleadoPSena)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#Region "Documentos"

#Region "Nueva Forma de manejar los documentos de los prospectos 30-oct-15"
    Public Shared Function fn_ProspectosDoctosI_Lista(ByVal Id_EmpleadoP As Integer) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosPDoctosI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ProspectosDoctos_Guardar(ByVal Id_EmpleadoP As Integer, ByVal Id_DoctoR As Integer, ByVal Id_EmpleadoPDocto As Integer,
                                                      ByVal Nombre_Archivo As String, ByVal MimeType As String, ByVal Archivo As Byte(), ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand = Nothing
        Try
            If Id_EmpleadoPDocto = 0 Then
                cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosPDoctos_Create")
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Cn_Datos.Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Id_DoctoR)
                Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Id_EmpleadoPDocto = EjecutarScalarT(cmd)
                cmd.Parameters.Clear()
            End If

            cmd = Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosPDoctosI_Create")
            Crea_Parametro(cmd, "@Id_EmpleadoPDocto", SqlDbType.Int, Id_EmpleadoPDocto)
            Crea_Parametro(cmd, "@Nombre_Archivo", SqlDbType.VarChar, Nombre_Archivo, False)
            Crea_Parametro(cmd, "@MimeType", SqlDbType.VarChar, MimeType)
            Crea_Parametro(cmd, "@Archivo", SqlDbType.VarBinary, Archivo)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            EjecutarNonQueryT(cmd)
            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, False)
            Return False

        End Try
    End Function

    Public Shared Function fn_ProspectosDoctosI_Eliminar(ByVal Id_EmpleadoPDoctoI As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosPDoctosI_Delete", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoPDoctoI", SqlDbType.Int, Id_EmpleadoPDoctoI)
            EjecutaConsulta(cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_ProspectosDoctos_EliminarMasivo(ByVal lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim tr As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand = Nothing
        Try
            For Each ItemDocto As ListViewItem In lsv.Items
                cmd = Cn_Datos.Crea_ComandoT(Cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosPDoctosI_Delete")
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoPDoctoI", SqlDbType.Int, ItemDocto.Tag)
                EjecutarNonQueryT(cmd)
                cmd.Parameters.Clear()
            Next

            tr.Commit()
            Return True
        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, False)
            Return False

        End Try
    End Function

#End Region

    Public Shared Function fn_ProspectosDoctos_Actualizar(ByVal Id_EmpleadoP As Integer, ByVal lsv As ListView) As Boolean
        'solo registra el documento al empleado, las imagenes se gestionan desde la vetana de Cargar Doctos.
        Dim Id_NuevoDocto As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim trans As SqlClient.SqlTransaction = Cn_Datos.crear_Trans(Cnn)
        Dim cmd As SqlClient.SqlCommand

        Try
            For Each Elemento As ListViewItem In lsv.Items
                If Elemento.Checked AndAlso Elemento.SubItems(3).Text = 0 Then
                    'Crear Elemento Nuevo revisando si se creará también Archivo Nuevo
                    cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPDoctos_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                    Cn_Datos.Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, Elemento.Tag)
                    Cn_Datos.Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                    Cn_Datos.Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                    Id_NuevoDocto = EjecutarScalarT(cmd)

                ElseIf Elemento.Checked = False AndAlso Elemento.SubItems(3).Text <> 0 Then
                    'Se eliminará el Documento Recibido si existe y su Archivo si es que tenía.
                    cmd = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPDoctos_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoPDocto", SqlDbType.Int, Elemento.SubItems(3).Text)
                    EjecutarNonQueryT(cmd)
                End If
            Next

            trans.Commit()
            Cnn.Dispose()
            Arreglo_Archivo = Nothing
            Return True
        Catch ex As Exception
            trans.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosProspecto_CargarArreglo(ByVal Id_EmpleadoP As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosPDoctosI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                ReDim Arreglo_Archivo(dt.Rows.Count)
                Dim Contador As Integer = 0
                For Each Elemento As DataRow In dt.Rows
                    Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_EmpleadoPDoctoI")
                    Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Nombre_Archivo")
                    Arreglo_Archivo(Contador).MimeType_Archivo = Elemento("MimeType")
                    Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Archivo")
                    Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("DescripcionArchivo")
                    Arreglo_Archivo(Contador).Extension_Archivo = Elemento("Id_DoctoR")
                    Arreglo_Archivo(Contador).Adicional_Archivo = Elemento("TipoDocumentoRecibido")
                    Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                    Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                    Contador += 1
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DoctoRequeridosProspecto_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_EmpleadoP As Integer) As Boolean
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosPDoctosR_GetEmpleado", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            lsv.Actualizar(cmd, "Id_DoctoR")

            If lsv.Columns.Count > 2 Then
                lsv.Columns(2).TextAlign = HorizontalAlignment.Right
                For Each Elemento As ListViewItem In lsv.Items
                    If Elemento.SubItems(2).Text = "SI" Then
                        Elemento.Checked = True
                    End If
                Next
            Else
                Return False
            End If

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

    Public Shared Function fn_EmpleadosP_Comprobar(ByRef lsv As cp_Listview, ByVal Nombres As String, ByVal APaterno As String, ByVal AMaterno As String) As Boolean
        'Función utilizada en EmpleadosP y Empleados
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosP_Comprobar", CommandType.StoredProcedure, cnn)
            If Nombres IsNot Nothing Then Crea_Parametro(cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            If APaterno IsNot Nothing Then Crea_Parametro(cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            If AMaterno IsNot Nothing Then Crea_Parametro(cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)

            lsv.Actualizar(cmd, "Id_EmpleadoP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "EmpleadosPI"

    Public Shared Function fn_EmpleadosPI_LeerImagenes(ByVal Id_EmpleadoP As Integer) As DataRow

        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EmpleadosPI_Actualizar(ByVal Id_EmpleadoP As Integer, ByVal Frente As Byte(), ByVal FrenteFormal As Byte(), ByVal TeniaImagenes As Boolean) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            'Cuando se envie algún valor significa que se esta creando o modificando sino se eliminará el registro
            If Frente IsNot Nothing OrElse FrenteFormal IsNot Nothing Then
                If TeniaImagenes Then
                    'Actualizar
                    Procedimiento = "Cat_EmpleadosPI_Update"
                Else
                    'Crear
                    Procedimiento = "Cat_EmpleadosPI_Create"
                End If

                Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
                Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, CnnF)
                Cn_Datos.Crea_Parametro(CmdF, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                If Frente IsNot Nothing Then Cn_Datos.Crea_Parametro(CmdF, "@Frente", SqlDbType.Image, Frente)
                If FrenteFormal IsNot Nothing Then Cn_Datos.Crea_Parametro(CmdF, "@FrenteFormal", SqlDbType.Image, FrenteFormal)

                Cn_Datos.EjecutarNonQuery(CmdF)
                Return True
            Else
                Return fn_EmpleadosPI_Eliminar(Id_EmpleadoP)
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosPI_Eliminar(ByVal Id_EmpleadoP As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPI_Delete", CommandType.StoredProcedure, Cnn)
        Try
            'Elimina las imagenes
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "EVALUAR PROSPECTOS"

    Public Shared Function fn_Prospectos_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosP_GetActivos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)

        Try
            lsv.Actualizar(cmd, "Id_EmpleadoP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ClaveEmpleado_Consultar(ByVal Id_EmpleadoP As Integer) As DataTable
        Dim dt As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetClave", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)

        Try
            dt = EjecutaConsulta(cmd)
            Return dt
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_EmpleadosP_ActualizaStatus(ByVal Id_EmpleadoP As Integer, ByVal Status As Char, ByVal Observaciones As String, ByVal Nuevo As Boolean, Optional ByVal Fecha_Ingreso As Date = #1/1/1900#, Optional ByRef Clave_Empleado As String = "") As Boolean
        Dim Id_Empleado As Integer = 0
        Dim Id_Departamento As Integer = 0
        Dim Id_Puesto As Integer = 0
        'Aquí se actualiza el Status de un Prospecto seleccionado (Validar o Baja)
        Dim cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlClient.SqlCommand
        Dim Dt As DataTable
        cmd = Crea_Comando("Cat_EmpleadosP_Read", CommandType.StoredProcedure, cnn)
        Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Dt = EjecutaConsulta(cmd)
        If Dt IsNot Nothing Then
            If Dt.Rows.Count > 0 Then
                Id_Departamento = Dt.Rows(0)("Id_Departamento")
                Id_Puesto = Dt.Rows(0)("Id_Puesto")
            Else
                Return False
            End If
        Else
            Return False
        End If
        Dt.Dispose()
        Dim trans As SqlClient.SqlTransaction = crear_Trans(cnn)

        Try
            cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosP_UpdateStatus")

            Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)
            Crea_Parametro(cmd, "@Usuario", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)

            EjecutarNonQueryT(cmd)

            If Nuevo Then
                cmd.Parameters.Clear()
                'Crear el registro en Cat_Empleados e Imagenes
                'cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_Empleados_CreateDProspecto")
                cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_Empleados_CreateDProspectoSSP")
                Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Fecha_Ingreso", SqlDbType.Date, Fecha_Ingreso)
                Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Crea_Parametro(cmd, "@Clave_Empleado", SqlDbType.VarChar, Clave_Empleado)
                Id_Empleado = EjecutarScalarT(cmd)
                Id_EmpleadoRecienCreado = Id_Empleado

                'JGMC-|2023-11-29|-Enlaza los documentos de contratacion al empleado'
                cmd.Parameters.Clear()
                cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosP_Contratos_Update")
                Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                EjecutaConsultaT(cmd)

                'JGMC-|2023-11-29|-Enlaza los huellas de contratacion al empleado'
                cmd.Parameters.Clear()
                cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosP_ContratosHuellas_Update")
                Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                EjecutaConsultaT(cmd)

                'JGMC-|2023-11-29|-Enlazar examen barsit al empleado'
                cmd.Parameters.Clear()
                cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosP_Examen_Update")
                Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                EjecutaConsultaT(cmd)

                'JGMC-|2023-11-29|-Enlazar Custionario Medico al empleado'
                cmd.Parameters.Clear()
                cmd = Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosP_CuestionarioM_Update")
                Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                EjecutaConsultaT(cmd)

                'copia los documentos del prospecto al nuevo empleado
                cmd.Parameters.Clear()
                Dim Dt_DoctosP As DataTable = Nothing
                Dim Id_NuevoDocto As Integer = 0
                cmd = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosPDoctos_Read")
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Dt_DoctosP = EjecutaConsultaT(cmd)
                If Not Dt_DoctosP Is Nothing Then
                    For Each dr_Dcto As DataRow In Dt_DoctosP.Rows

                        cmd = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctos_Create")
                        Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                        Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, dr_Dcto("Id_DoctoR"))
                        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, dr_Dcto("Usuario_Registro"))
                        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, dr_Dcto("Estacion_Registro"))
                        Id_NuevoDocto = EjecutarScalarT(cmd)

                        cmd.Parameters.Clear()
                        cmd = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDoctosI_CreateDProspecto")
                        Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                        Crea_Parametro(cmd, "@Id_EmpleadoDocto", SqlDbType.Int, Id_NuevoDocto)
                        Crea_Parametro(cmd, "@Id_DoctoR", SqlDbType.Int, dr_Dcto("Id_DoctoR"))
                        Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        EjecutarNonQueryT(cmd)
                    Next

                End If

                'Recalcular la Plantilla Laboral
                cmd = Cn_Datos.Crea_ComandoT(cnn, trans, CommandType.StoredProcedure, "Cat_PuestosPlantilla_Calcular")
                Cn_Datos.Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
                EjecutarNonQueryT(cmd)
            End If
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

#End Region

#Region "CATALOGO DE UMF'S"

    Public Shared Function fn_UMF_LlenarLista(ByRef lsv As cp_Listview) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_UMF_Get", CommandType.StoredProcedure, Cnn)

        Try
            lsv.Actualizar(Cmd, "")
            lsv.Columns(0).TextAlign = HorizontalAlignment.Right
            lsv.Columns(2).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_UMF_Validar(ByVal UMF As String) As Boolean

        'Aquí se valida si existe el Tipo de Complexión
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_UMF_Read", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_UMF", SqlDbType.Int, UMF)

        Try
            Dim Tbl As DataTable = EjecutaConsulta(Cmd)
            If Tbl.Rows.Count = 0 Then
                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_UMF_Nuevo(ByVal UMF As Integer, ByVal Municipio As String, ByVal CP As Integer) As Boolean

        'Aqui se inserta una nueva UMF
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_UMF_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_UMF", SqlDbType.Int, UMF)
        Crea_Parametro(Cmd, "@Municipio", SqlDbType.VarChar, Municipio)
        Crea_Parametro(Cmd, "@CP", SqlDbType.Int, CP)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_UMF_Actualizar(ByVal UMF_Anterior As Integer, ByVal UMF As Integer, ByVal Municipio As String, ByVal CP As Integer) As Boolean

        'Aqui se actualiza una UMF
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_UMF_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Numero_Anterior_UMF", SqlDbType.Int, UMF_Anterior)
        Crea_Parametro(Cmd, "@Numero_UMF", SqlDbType.Int, UMF)
        Crea_Parametro(Cmd, "@Municipio", SqlDbType.VarChar, Municipio)
        Crea_Parametro(Cmd, "@CP", SqlDbType.Int, CP)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "CATALOGO DE EMPLEADOS EN LISTA NEGRA"

    Public Shared Function fn_ListaNegra_LlenarLista(ByRef lsv As cp_Listview, ByVal Linicial As String, ByVal Lfinal As String) As Boolean
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosListaNegra_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@LetraInicial", SqlDbType.VarChar, Linicial)
        Crea_Parametro(Cmd, "@LetraFinal", SqlDbType.VarChar, Lfinal)
        Try
            lsv.Actualizar(Cmd, "Id_ListaNegra")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ListaNegra_Nuevo(ByVal Nombre As String, ByVal Empresa As String, ByVal Puesto As String, ByVal Motivo As String) As Boolean

        'Aqui se inserta una nuevo Empleado en la Lista Negra
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosListaNegra_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
        Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, Empresa)
        Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, Puesto)
        Crea_Parametro(Cmd, "@Motivo", SqlDbType.VarChar, Motivo)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ListaNegra_Actualizar(ByVal Id_ListaNegra As Integer, ByVal Nombre As String, ByVal Empresa As String, ByVal Puesto As String, ByVal Motivo As String) As Boolean
        'Aqui se actualiza un Empleado de la Lista Negra
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosListaNegra_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_ListaNegra", SqlDbType.Int, Id_ListaNegra)
        Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
        Crea_Parametro(Cmd, "@Empresa", SqlDbType.VarChar, Empresa)
        Crea_Parametro(Cmd, "@Puesto", SqlDbType.VarChar, Puesto)
        Crea_Parametro(Cmd, "@Motivo", SqlDbType.VarChar, Motivo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ListaNegra_Comprobar(ByRef lsv As cp_Listview, ByVal Nombres As String, ByVal APaterno As String, ByVal AMaterno As String) As Boolean
        'Función utilizada en EmpleadosP y Empleados
        Try
            Dim cnn As SqlConnection = Crea_ConexionSTD()
            Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosListaNegra_Comprobar", CommandType.StoredProcedure, cnn)
            If Nombres IsNot Nothing Then Crea_Parametro(cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            If APaterno IsNot Nothing Then Crea_Parametro(cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            If AMaterno IsNot Nothing Then Crea_Parametro(cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)

            lsv.Actualizar(cmd, "Id_ListaNegra")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "GRÁFICAS"

    Public Shared Function fn_IndicadorAltaBajaEmpleado_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetAltaBaja", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Reclutados_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosP_Reclutados", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            lsv.Actualizar(cmd, "Id_EmpleadoP")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Contratados_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_Contratados", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            lsv.Actualizar(cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Entrevistas_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Desde As Date, ByVal Hasta As Date) As Boolean
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosP_Entrevistas", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
        Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
        Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
        Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

        Try
            lsv.Actualizar(cmd, "Id_Entrevista")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    'Public Shared Function fn_IndicadorAltaBajaEmpleado_Grafica(ByVal Id_Departamento As Integer, ByVal Desde As Date, ByVal Hasta As Date) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_Indicador", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

    '    Try
    '        Dim dt As DataTable = EjecutaConsulta(cmd)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_IndicadorAltaBajaEmpleado_GraficaG(ByVal Desde As Date, ByVal Hasta As Date) As DataTable
    '    Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_IndicadorG", CommandType.StoredProcedure, Crea_ConexionSTD)
    '    Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
    '    Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)

    '    Try
    '        Dim dt As DataTable = EjecutaConsulta(cmd)
    '        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
    '            Return dt
    '        Else
    '            Return Nothing
    '        End If
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

#End Region

#Region "EmpleadosI"

    Public Shared Function fn_Empleados_LeerImagenes(ByVal Id_Empleado As Integer) As DataRow
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosI_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_LeerImagenes(ByVal Id_Empleado As Integer) As DataRow
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosIXF_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_EmpleadoXF", SqlDbType.Int, Id_Empleado)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Empleados_LeerHuellas(ByVal Id_Empleado As Integer) As DataRow

        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosHuellas_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_Empleados_LeerHuellasT(ByVal Id_Empleado As Integer) As DataRow
        Dim con As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosHuellasT_Read", CommandType.StoredProcedure, con)
        Cn_Datos.Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(com)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosI_Actualizar(ByVal Id_Empleado As Integer, ByVal Foto As Byte(), ByVal TeniaImagenes As Boolean, ByVal Tipo As TipoFoto) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            If TeniaImagenes Then
                Procedimiento = "Cat_EmpleadosI_Update"
            Else
                Procedimiento = "Cat_EmpleadosI_Create"
            End If
            'guardar las imagenes si las hay
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            If Foto IsNot Nothing Then Cn_Datos.Crea_Parametro(CmdF, "@Foto", SqlDbType.Image, Foto)
            Cn_Datos.Crea_Parametro(CmdF, "@Tipo", SqlDbType.Int, CInt(Tipo))

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosHuellas_Actualizar(ByVal Id_Empleado As Integer, ByVal Foto As Byte(), ByVal TeniaImagenes As Boolean, ByVal Tipo As TipoHuella) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            If TeniaImagenes Then
                Procedimiento = "Cat_EmpleadosHuellas_Update"
            Else
                Procedimiento = "Cat_EmpleadosHuellas_Create"
            End If
            'guardar las imagenes si las hay
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(CmdF, "@Foto", SqlDbType.Image, Foto)
            Cn_Datos.Crea_Parametro(CmdF, "@Tipo", SqlDbType.Int, CInt(Tipo))

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosHuellasT_Actualizar(ByVal Id_Empleado As Integer, ByVal Lectura1 As String,
                                                           ByVal Lectura2 As String, ByVal Lectura3 As String,
                                                           ByVal Lectura4 As String, ByVal Lectura5 As String,
                                                           ByVal Lectura6 As String, ByVal Lectura7 As String,
                                                           ByVal Lectura8 As String, ByVal Lectura9 As String,
                                                           ByVal Lectura10 As String, ByVal TeniaImagenesT As Boolean) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            If TeniaImagenesT Then
                Procedimiento = "Cat_EmpleadosHuellasT_Update"
            Else
                Procedimiento = "Cat_EmpleadosHuellasT_Create"
            End If
            'guardar las imagenes si las hay
            Dim CnnF As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim CmdF As SqlClient.SqlCommand = Cn_Datos.Crea_Comando(Procedimiento, CommandType.StoredProcedure, CnnF)
            Cn_Datos.Crea_Parametro(CmdF, "@Id_Empleado", SqlDbType.Int, Id_Empleado, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Uno", SqlDbType.Text, Lectura1, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Dos", SqlDbType.VarChar, Lectura2, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Tres", SqlDbType.VarChar, Lectura3, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Cuatro", SqlDbType.VarChar, Lectura4, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Cinco", SqlDbType.VarChar, Lectura5, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Seis", SqlDbType.VarChar, Lectura6, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Siete", SqlDbType.VarChar, Lectura7, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Ocho", SqlDbType.VarChar, Lectura8, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Nueve", SqlDbType.VarChar, Lectura9, False)
            Cn_Datos.Crea_Parametro(CmdF, "@Diez", SqlDbType.VarChar, Lectura10, False)

            Cn_Datos.EjecutarNonQuery(CmdF)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosHuellas_HuellasT_Eliminar(ByVal Id_Empleado As Integer, ByVal NumeroHuella As Integer) As Boolean
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            'Eliminar las Imagenes y Huellas
            Dim Cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosHuellasT_UpdatexHuella")
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, NumeroHuella)
            EjecutarNonQueryT(Cmd)

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosHuellas_Update")
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, NumeroHuella)
            EjecutarNonQueryT(Cmd)

            Tr.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosHuellasT_Validado(ByVal Id_Empleado As Integer) As String
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosHuellasT_UpdateValidacion", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Return "Ultima Validación: " & EjecutaConsulta(Cmd).Rows(0)("Fecha")
        Catch ex As Exception
            TrataEx(ex)
            Return ""
        End Try
    End Function

#End Region

#Region "VISITAS DOMICILIARIAS"

    Public Shared Function fn_VisitaDomiciliaria_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Empleado As Integer, ByVal Id_EmpleadoP As Integer) As Boolean
        Try
            Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim cmd As SqlCommand

            If Id_Empleado > 0 Then
                cmd = Crea_Comando("Cat_EmpleadosVisitas_GetxEmpleado", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Else
                cmd = Crea_Comando("Cat_EmpleadosVisitas_GetxProspecto", CommandType.StoredProcedure, Cnn)
                Cn_Datos.Crea_Parametro(cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
            End If

            'Aqui se Actualiza la lista
            lsv.Actualizar(cmd, "Id_Visita")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliaria_LlenarLista(ByVal lsv As cp_Listview, ByVal FechaDesde As Date, ByVal FechaHasta As Date, ByVal TipoEmpleado As Integer, ByVal Id As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitas_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Desde", SqlDbType.Date, FechaDesde)
            Cn_Datos.Crea_Parametro(Cmd, "@Hasta", SqlDbType.Date, FechaHasta)
            'Tipo = 1 si es Empleado o Tipo = 2 si es Prospecto
            Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, TipoEmpleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Id", SqlDbType.Int, Id)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_Visita")

            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliaria_Nuevo(ByVal Id_Empleado As Integer, ByVal Id_EmpleadoP As Integer, ByVal Fecha_Visita As Date, ByVal Hora_Visita As String, ByVal Usuario_Visita As Integer, ByVal Motivo_Visita As String,
                                                       ByVal Observaciones As String, ByVal UsuarioProx_Visita As Integer, ByVal FechaProx_Visita As Date, ByVal HoraProx_Visita As String, ByVal MotivoProx_Visita As String, ByRef Id_VisitaNuevo As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitas_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Visita", SqlDbType.Date, Fecha_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Visita", SqlDbType.Time, Microsoft.VisualBasic.Left(Hora_Visita, 5))
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Visita", SqlDbType.Int, Usuario_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Motivo_Visita", SqlDbType.Char, Motivo_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@UsuarioProx_Visita", SqlDbType.Int, UsuarioProx_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaProx_Visita", SqlDbType.Date, FechaProx_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@HoraProx_Visita", SqlDbType.Time, Microsoft.VisualBasic.Left(HoraProx_Visita, 5))
        Cn_Datos.Crea_Parametro(Cmd, "@MotivoProx_Visita", SqlDbType.Char, MotivoProx_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.Char, EstacioN)
        Cn_Datos.Crea_Parametro(Cmd, "@Status   ", SqlDbType.Char, "A")

        Try
            Id_VisitaNuevo = Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_VisitaDomiciliaria_Actualizar(ByVal Id_Visita As Integer, ByVal Fecha_Visita As Date, ByVal Hora_Visita As String, ByVal Usuario_Visita As Integer, ByVal Motivo_Visita As String,
                                                      ByVal Observaciones As String, ByVal UsuarioProx_Visita As Integer, ByVal FechaProx_Visita As Date, ByVal HoraProx_Visita As String, ByVal MotivoProx_Visita As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitas_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Visita", SqlDbType.Date, Fecha_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Hora_Visita", SqlDbType.Time, Microsoft.VisualBasic.Left(Hora_Visita, 5))
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Visita", SqlDbType.Int, Usuario_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Motivo_Visita", SqlDbType.Char, Motivo_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.Text, Observaciones)
        Cn_Datos.Crea_Parametro(Cmd, "@UsuarioProx_Visita", SqlDbType.Int, UsuarioProx_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@FechaProx_Visita", SqlDbType.Date, FechaProx_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@HoraProx_Visita", SqlDbType.Time, Microsoft.VisualBasic.Left(HoraProx_Visita, 5))
        Cn_Datos.Crea_Parametro(Cmd, "@MotivoProx_Visita", SqlDbType.Char, MotivoProx_Visita)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_VisitaDomiciliaria_Read(ByVal Id_Visita As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitas_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_VisitaDomiciliariaI_CargarArreglo(ByVal Id_Visita As Integer) As Boolean
        Dim dt As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosVisitasI_Read", CommandType.StoredProcedure, cnn)

        Try
            Cn_Datos.Crea_Parametro(cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing Then
                If dt.Rows.Count > 0 Then
                    ReDim Arreglo_Archivo(dt.Rows.Count)
                    Dim Contador As Integer = 0
                    For Each Elemento As DataRow In dt.Rows
                        Arreglo_Archivo(Contador).Id_Archivo = Elemento("Id_VisitaI")
                        Arreglo_Archivo(Contador).Nombre_Archivo = Elemento("Descripcion")
                        Arreglo_Archivo(Contador).MimeType_Archivo = "IMAGE/JPEG"
                        Arreglo_Archivo(Contador).Objeto_Archivo = Elemento("Foto")
                        Arreglo_Archivo(Contador).Descripcion_Archivo = Elemento("Descripcion")
                        Arreglo_Archivo(Contador).FileSize_Archivo = Nothing
                        Arreglo_Archivo(Contador).Extension_Archivo = Nothing
                        Arreglo_Archivo(Contador).Ruta_Archivo = Nothing
                        Arreglo_Archivo(Contador).Adicional_Archivo = Nothing
                        Contador += 1
                    Next
                End If
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaI_Actualizar(ByVal Id_Visita As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = Cn_Datos.crear_Trans(cnn)
        Dim cmd As SqlCommand

        Try
            For ILocal As Integer = 0 To Arreglo_Archivo.Length - 1
                If Arreglo_Archivo(ILocal).Id_Archivo = Nothing And Arreglo_Archivo(ILocal).Objeto_Archivo Is Nothing Then
                    Continue For
                ElseIf Arreglo_Archivo(ILocal).Id_Archivo = Nothing Then
                    'Nuevo Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosVisitasI_Create")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)

                ElseIf Arreglo_Archivo(ILocal).Objeto_Archivo IsNot Nothing Then
                    'Actualizar un Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosVisitasI_Update")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_VisitaI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)

                Else
                    'Eliminar un Registro
                    cmd = Crea_ComandoT(cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosVisitasI_Delete")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_VisitaI", SqlDbType.Int, Arreglo_Archivo(ILocal).Id_Archivo)
                    EjecutarNonQueryT(cmd)
                    Continue For
                End If

                Cn_Datos.Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Arreglo_Archivo(ILocal).Descripcion_Archivo)
                Cn_Datos.Crea_Parametro(cmd, "@Foto", SqlDbType.VarBinary, Arreglo_Archivo(ILocal).Objeto_Archivo)
                EjecutarNonQueryT(cmd)
            Next
            Tr.Commit()
            cnn.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

    'Public Shared Function fn_VisitaDomiciliariaI_Nuevo(ByVal Id_Visita As Integer, ByVal Descripcion As String, ByVal Foto As Byte()) As Boolean
    '    'Aqui se actualiza un registro
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasI_Create", CommandType.StoredProcedure, Cnn)

    '    Try
    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.Char, Descripcion)
    '        Cn_Datos.Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Foto)

    '        Cn_Datos.EjecutarNonQuery(Cmd)
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    'Public Shared Function fn_VisitaDomiciliariaI_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Visita As Integer) As DataTable
    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasI_Get", CommandType.StoredProcedure, Cnn)

    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)

    '        'Aqui se Actualiza la lista
    '        lsv.Actualizar(Cmd, "Id_VisitaI")

    '        'Leer de SQL
    '        Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
    '        Return DT
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return Nothing
    '    End Try
    'End Function

    'Public Shared Function fn_VisitaDomiciliariaI_Eliminar(ByVal Id_VisitaI As Integer) As Boolean
    '    Try
    '        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasI_Delete", CommandType.StoredProcedure, Cnn)

    '        Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaI", SqlDbType.Int, Id_VisitaI)

    '        Cn_Datos.EjecutarNonQuery(Cmd)
    '        Return True
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function

    Public Shared Function fn_VisitaDomiciliariaInmueble_Nuevo(ByVal Id_Visita As Integer, ByVal Tipo_Casa As Integer, ByVal Propietario As String, ByVal Tipo_CasaOtro As String, ByVal Tipo_Material As Integer, ByVal Tipo_MaterialOtro As String,
                                                               ByVal Cantidad_Habitantes As Integer, ByVal Tiene_Sala As String, ByVal Tiene_Cocina As String, ByVal Tiene_Comedor As String, ByVal Tiene_Cochera As String, ByVal Tiene_PatioDelantero As String,
                                                               ByVal Tiene_PatioTrasero As String, ByVal Cantidad_Mobiliario As Integer, ByVal Cantidad_MobiliarioOtro As String, ByVal Tipo_Mobiliario As Integer, ByVal Tipo_MobiliarioOtro As String,
                                                               ByVal Calidad_Mobiliario As Integer, ByVal Calidad_MobiliarioOtro As String, ByVal Cantidad_Plantas As Integer, ByVal Cantidad_Recamaras As Integer, ByVal Cantidad_Banos As Decimal,
                                                               ByVal Planea_Endeudamiento As String, ByVal Descripcion_Endeudamiento As String, ByVal Endeudamiento_Actual As String, ByVal Descripcion_EndeudamientoA As String, ByVal Limpio_Ordenado As String,
                                                               ByVal Observaciones_Interior As String, ByVal Observaciones_Exterior As String, ByRef Id_VisitaInmueble As Integer) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasInmueble_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Casa", SqlDbType.TinyInt, Tipo_Casa)
        Cn_Datos.Crea_Parametro(Cmd, "@Propietario", SqlDbType.VarChar, Propietario)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_CasaOtro", SqlDbType.VarChar, Tipo_CasaOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Material", SqlDbType.TinyInt, Tipo_Material)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_MaterialOtro", SqlDbType.VarChar, Tipo_MaterialOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Habitantes", SqlDbType.TinyInt, Cantidad_Habitantes)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Sala", SqlDbType.Char, Tiene_Sala)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Cocina", SqlDbType.Char, Tiene_Cocina)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Comedor", SqlDbType.Char, Tiene_Comedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Cochera", SqlDbType.Char, Tiene_Cochera)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_PatioDelantero", SqlDbType.Char, Tiene_PatioDelantero)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_PatioTrasero", SqlDbType.Char, Tiene_PatioTrasero)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Mobiliario", SqlDbType.TinyInt, Cantidad_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_MobiliarioOtro", SqlDbType.VarChar, Cantidad_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mobiliario", SqlDbType.TinyInt, Tipo_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_MobiliarioOtro", SqlDbType.VarChar, Tipo_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Calidad_Mobiliario", SqlDbType.TinyInt, Calidad_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Calidad_MobiliarioOtro", SqlDbType.VarChar, Calidad_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Plantas", SqlDbType.TinyInt, Cantidad_Plantas)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Recamaras", SqlDbType.TinyInt, Cantidad_Recamaras)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Banos", SqlDbType.Decimal, Cantidad_Banos)
        Cn_Datos.Crea_Parametro(Cmd, "@Planea_Endeudamiento", SqlDbType.Char, Planea_Endeudamiento)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion_Endeudamiento", SqlDbType.VarChar, Descripcion_Endeudamiento)
        Cn_Datos.Crea_Parametro(Cmd, "@Endeudamiento_Actual", SqlDbType.Char, Endeudamiento_Actual)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion_EndeudamientoA", SqlDbType.VarChar, Descripcion_EndeudamientoA)
        Cn_Datos.Crea_Parametro(Cmd, "@Limpio_Ordenado", SqlDbType.Char, Limpio_Ordenado)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Interior", SqlDbType.Text, Observaciones_Interior)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Exterior", SqlDbType.Text, Observaciones_Exterior)

        Try
            Id_VisitaInmueble = Cn_Datos.EjecutarScalar(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaInmueble_Actualizar(ByVal Id_VisitaInmueble As Integer, ByVal Tipo_Casa As Integer, ByVal Propietario As String, ByVal Tipo_CasaOtro As String, ByVal Tipo_Material As Integer, ByVal Tipo_MaterialOtro As String,
                                                                    ByVal Cantidad_Habitantes As Integer, ByVal Tiene_Sala As String, ByVal Tiene_Cocina As String, ByVal Tiene_Comedor As String, ByVal Tiene_Cochera As String, ByVal Tiene_PatioDelantero As String,
                                                                    ByVal Tiene_PatioTrasero As String, ByVal Cantidad_Mobiliario As Integer, ByVal Cantidad_MobiliarioOtro As String, ByVal Tipo_Mobiliario As Integer, ByVal Tipo_MobiliarioOtro As String,
                                                                    ByVal Calidad_Mobiliario As Integer, ByVal Calidad_MobiliarioOtro As String, ByVal Cantidad_Plantas As Integer, ByVal Cantidad_Recamaras As Integer, ByVal Cantidad_Banos As Decimal,
                                                                    ByVal Planea_Endeudamiento As String, ByVal Descripcion_Endeudamiento As String, ByVal Endeudamiento_Actual As String, ByVal Descripcion_EndeudamientoA As String, ByVal Limpio_Ordenado As String,
                                                                    ByVal Observaciones_Interior As String, ByVal Observaciones_Exterior As String) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasInmueble_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaInmueble", SqlDbType.Int, Id_VisitaInmueble)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Casa", SqlDbType.TinyInt, Tipo_Casa)
        Cn_Datos.Crea_Parametro(Cmd, "@Propietario", SqlDbType.VarChar, Propietario)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_CasaOtro", SqlDbType.VarChar, Tipo_CasaOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Material", SqlDbType.TinyInt, Tipo_Material)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_MaterialOtro", SqlDbType.VarChar, Tipo_MaterialOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Habitantes", SqlDbType.TinyInt, Cantidad_Habitantes)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Sala", SqlDbType.Char, Tiene_Sala)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Cocina", SqlDbType.Char, Tiene_Cocina)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Comedor", SqlDbType.Char, Tiene_Comedor)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_Cochera", SqlDbType.Char, Tiene_Cochera)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_PatioDelantero", SqlDbType.Char, Tiene_PatioDelantero)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiene_PatioTrasero", SqlDbType.Char, Tiene_PatioTrasero)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Mobiliario", SqlDbType.TinyInt, Cantidad_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_MobiliarioOtro", SqlDbType.VarChar, Cantidad_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Mobiliario", SqlDbType.TinyInt, Tipo_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_MobiliarioOtro", SqlDbType.VarChar, Tipo_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Calidad_Mobiliario", SqlDbType.TinyInt, Calidad_Mobiliario)
        Cn_Datos.Crea_Parametro(Cmd, "@Calidad_MobiliarioOtro", SqlDbType.VarChar, Calidad_MobiliarioOtro)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Plantas", SqlDbType.TinyInt, Cantidad_Plantas)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Recamaras", SqlDbType.TinyInt, Cantidad_Recamaras)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad_Banos", SqlDbType.Decimal, Cantidad_Banos)
        Cn_Datos.Crea_Parametro(Cmd, "@Planea_Endeudamiento", SqlDbType.Char, Planea_Endeudamiento)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion_Endeudamiento", SqlDbType.VarChar, Descripcion_Endeudamiento)
        Cn_Datos.Crea_Parametro(Cmd, "@Endeudamiento_Actual", SqlDbType.Char, Endeudamiento_Actual)
        Cn_Datos.Crea_Parametro(Cmd, "@Descripcion_EndeudamientoA", SqlDbType.VarChar, Descripcion_EndeudamientoA)
        Cn_Datos.Crea_Parametro(Cmd, "@Limpio_Ordenado", SqlDbType.Char, Limpio_Ordenado)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Interior", SqlDbType.Text, Observaciones_Interior)
        Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Exterior", SqlDbType.Text, Observaciones_Exterior)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaInmueble_Read(ByVal Id_VisitaInmueble As Integer) As DataRow
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasInmueble_Read", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_VisitaInmueble)

        Try
            'Leer de SQL
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaInmueble_Borrar(ByVal Id_VisitaInmueble As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasInmueble_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaInmueble", SqlDbType.Int, Id_VisitaInmueble)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaRef_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Visita As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasRef_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_VisitaRef")

            'Leer de SQL
            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaRef_Nuevo(ByVal Id_Visita As Integer, ByVal Nombre As String, ByVal Tipo_Persona As Integer, ByVal Definicion_Persona As String, ByVal Definicion_Familia As String, ByVal Tiempo_Conocerlo As Decimal) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasRef_Create", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Visita", SqlDbType.Int, Id_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Persona", SqlDbType.TinyInt, Tipo_Persona)
        Cn_Datos.Crea_Parametro(Cmd, "@Definicion_Persona", SqlDbType.VarChar, Definicion_Persona)
        Cn_Datos.Crea_Parametro(Cmd, "@Definicion_Familia", SqlDbType.VarChar, Definicion_Familia)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiempo_Conocerlo", SqlDbType.Decimal, Tiempo_Conocerlo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaRef_Actualizar(ByVal Id_VisitaRef As Integer, ByVal Nombre As String, ByVal Tipo_Persona As Integer, ByVal Definicion_Persona As String, ByVal Definicion_Familia As String, ByVal Tiempo_Conocerlo As Decimal) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasRef_Update", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaRef", SqlDbType.Int, Id_VisitaRef)
        Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, Nombre)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo_Persona", SqlDbType.TinyInt, Tipo_Persona)
        Cn_Datos.Crea_Parametro(Cmd, "@Definicion_Persona", SqlDbType.VarChar, Definicion_Persona)
        Cn_Datos.Crea_Parametro(Cmd, "@Definicion_Familia", SqlDbType.VarChar, Definicion_Familia)
        Cn_Datos.Crea_Parametro(Cmd, "@Tiempo_Conocerlo", SqlDbType.Decimal, Tiempo_Conocerlo)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_VisitaDomiciliariaRef_Borrar(ByVal Id_VisitaRef As Integer) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosVisitasRef_Delete", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaRef", SqlDbType.Int, Id_VisitaRef)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    '2023-08-31 JM
    Public Shared Function fn_VisitaDom_IngresosEgresos_LlenarLista(ByVal Id_Visita As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_IngresosEgresos_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaDom", SqlDbType.Int, Id_Visita)

            'Aqui se Actualiza la lista


            'Leer de SQL
            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_VisitaDom_Familiares_LlenarLista(ByVal Id_Empleado As Integer, ByVal Id_EmpleadoP As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPFamiliares_VisDom", CommandType.StoredProcedure, Cnn)
            If Id_Empleado > 0 Then
                Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_Empleado)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, "E")
            Else
                Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
                Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, "P")
            End If

            'Leer de SQL
            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_VisitaDom_DistribucionIngresosMensuales_Llenartabla(ByVal Id_IngEg As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosPDistribucion_IngresoMensuales_Get", CommandType.StoredProcedure, Cnn)

            Cn_Datos.Crea_Parametro(Cmd, "@Id_IngresosEgresos", SqlDbType.Int, Id_IngEg)

            'Aqui se Actualiza la lista


            'Leer de SQL
            Dim DT As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Return DT
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_VisitaDom_IngresosEgresos_Nuevo(ByVal Id_Visita As Integer,
                                                              ByVal PlanEndeudamiento As String,
                                                              ByVal PlanDeudaDescripcion As String,
                                                              ByVal TieneDeuda As String,
                                                              ByVal CantidadDeuda As Decimal,
                                                              ByVal Ingresos As Decimal,
                                                              ByVal IngresoDedicadoAhorro As Decimal,
                                                              ByVal NoPersAportaEconomicamente As Integer,
                                                              ByVal NoPerDependienteEconomico As Integer,
                                                              ByVal FamTrabCorpPoliOPriv As String,
                                                              ByVal ManejaTDC As String,
                                                              ByVal AutoPropio As String,
                                                              ByVal Marca As String,
                                                              ByVal Modelo As String,
                                                              ByVal TienePropiedad As String,
                                                              ByVal UbicacionPropiedad As String, ByVal DistribucionIngresos As DataGridView
                                                              ) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_IngresosEgresos_Add", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_VisitaDom", SqlDbType.Int, Id_Visita)
        Cn_Datos.Crea_Parametro(Cmd, "@PlanEndeudamiento", SqlDbType.VarChar, PlanEndeudamiento)
        Cn_Datos.Crea_Parametro(Cmd, "@PlanEndeuDescripcion", SqlDbType.VarChar, PlanDeudaDescripcion)
        Cn_Datos.Crea_Parametro(Cmd, "@TieneDeuda", SqlDbType.VarChar, TieneDeuda)
        Cn_Datos.Crea_Parametro(Cmd, "@CantidadDeuda", SqlDbType.Money, CantidadDeuda)
        Cn_Datos.Crea_Parametro(Cmd, "@Ingresos", SqlDbType.Decimal, Ingresos)
        Cn_Datos.Crea_Parametro(Cmd, "@IngresoDedicadoAhorro", SqlDbType.Decimal, IngresoDedicadoAhorro)
        Cn_Datos.Crea_Parametro(Cmd, "@NoPersAportaEconomicamente", SqlDbType.Int, NoPersAportaEconomicamente)
        Cn_Datos.Crea_Parametro(Cmd, "@NoPerDependienteEconomico", SqlDbType.Int, NoPerDependienteEconomico)
        Cn_Datos.Crea_Parametro(Cmd, "@FamTrabCorpPoliOPriv", SqlDbType.VarChar, FamTrabCorpPoliOPriv)
        Cn_Datos.Crea_Parametro(Cmd, "@ManejaTDC", SqlDbType.VarChar, ManejaTDC)
        Cn_Datos.Crea_Parametro(Cmd, "@AutoPropio", SqlDbType.VarChar, AutoPropio)
        Cn_Datos.Crea_Parametro(Cmd, "@Marca", SqlDbType.VarChar, Marca)
        Cn_Datos.Crea_Parametro(Cmd, "@Modelo", SqlDbType.VarChar, Modelo)
        Cn_Datos.Crea_Parametro(Cmd, "@TienePropiedad", SqlDbType.VarChar, TienePropiedad)
        Cn_Datos.Crea_Parametro(Cmd, "@UbicacionPropiedad", SqlDbType.VarChar, UbicacionPropiedad)
        Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Registra", SqlDbType.DateTime, Date.Today)
        Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registra", SqlDbType.Decimal, UsuarioId)
        Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registra", SqlDbType.VarChar, EstacioN)

        Try
            Dim idIE As Integer = Cn_Datos.EjecutarScalar(Cmd)
            If idIE > 0 Then
                For i As Integer = 0 To DistribucionIngresos.Rows.Count - 1
                    fn_VisitaDom_Distribucion_IngresoMensuales_Agregar(idIE, DistribucionIngresos.Rows(i).Cells(1).Value, Decimal.Parse(DistribucionIngresos.Rows(i).Cells(2).Value), (i + 1))
                Next
            End If
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_VisitaDom_Distribucion_IngresoMensuales_Agregar(ByVal Id_IngresosEgresos As Integer,
            ByVal Ingreso As String, ByVal Cantidad As Decimal, ByVal Orden As Integer
                                                              ) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosDistribucion_IngresoMensuales_AddUpd", CommandType.StoredProcedure, Cnn)

        Cn_Datos.Crea_Parametro(Cmd, "@Id_IngresosEgresos", SqlDbType.Int, Id_IngresosEgresos)
        Cn_Datos.Crea_Parametro(Cmd, "@Ingreso", SqlDbType.VarChar, Ingreso)
        Cn_Datos.Crea_Parametro(Cmd, "@Cantidad", SqlDbType.Decimal, Cantidad)
        Cn_Datos.Crea_Parametro(Cmd, "@Orden", SqlDbType.Int, Orden)

        Try
            Cn_Datos.EjecutarNonQuery(Cmd)


            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_VisitaDom_IngresosEgresos_Actualizar(ByVal Id_IngresosEgresos As Integer,
                                                                   ByVal Id_Visita As Integer,
                                                              ByVal PlanEndeudamiento As String,
                                                              ByVal PlanDeudaDescripcion As String,
                                                              ByVal TieneDeuda As String,
                                                              ByVal CantidadDeuda As Decimal,
                                                              ByVal Ingresos As Decimal,
                                                              ByVal IngresoDedicadoAhorro As Decimal,
                                                              ByVal NoPersAportaEconomicamente As Integer,
                                                              ByVal NoPerDependienteEconomico As Integer,
                                                              ByVal FamTrabCorpPoliOPriv As String,
                                                              ByVal ManejaTDC As String,
                                                              ByVal AutoPropio As String,
                                                              ByVal Marca As String,
                                                              ByVal Modelo As String,
                                                              ByVal TienePropiedad As String,
                                                              ByVal UbicacionPropiedad As String,
                                                                   ByVal DistribucionIngresos As DataGridView
                                                              ) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)

        'Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_IngresosEgresos_Update", CommandType.StoredProcedure, Cnn)
        Try
            Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosP_IngresosEgresos_Update")
            Cn_Datos.Crea_Parametro(cmd, "@Id_IngresosEgresos", SqlDbType.Int, Id_IngresosEgresos)
            Cn_Datos.Crea_Parametro(cmd, "@Id_VisitaDom", SqlDbType.Int, Id_Visita)
            Cn_Datos.Crea_Parametro(cmd, "@PlanEndeudamiento", SqlDbType.VarChar, PlanEndeudamiento)
            Cn_Datos.Crea_Parametro(cmd, "@PlanEndeuDescripcion", SqlDbType.VarChar, PlanDeudaDescripcion)
            Cn_Datos.Crea_Parametro(cmd, "@TieneDeuda", SqlDbType.VarChar, TieneDeuda)
            Cn_Datos.Crea_Parametro(cmd, "@CantidadDeuda", SqlDbType.Decimal, CantidadDeuda)
            Cn_Datos.Crea_Parametro(cmd, "@Ingresos", SqlDbType.Decimal, Ingresos)
            Cn_Datos.Crea_Parametro(cmd, "@IngresoDedicadoAhorro", SqlDbType.Decimal, IngresoDedicadoAhorro)
            Cn_Datos.Crea_Parametro(cmd, "@NoPersAportaEconomicamente", SqlDbType.Int, NoPersAportaEconomicamente)
            Cn_Datos.Crea_Parametro(cmd, "@NoPerDependienteEconomico", SqlDbType.Int, NoPerDependienteEconomico)
            Cn_Datos.Crea_Parametro(cmd, "@FamTrabCorpPoliOPriv", SqlDbType.VarChar, FamTrabCorpPoliOPriv)
            Cn_Datos.Crea_Parametro(cmd, "@ManejaTDC", SqlDbType.VarChar, ManejaTDC)
            Cn_Datos.Crea_Parametro(cmd, "@AutoPropio", SqlDbType.VarChar, AutoPropio)
            Cn_Datos.Crea_Parametro(cmd, "@Marca", SqlDbType.VarChar, Marca)
            Cn_Datos.Crea_Parametro(cmd, "@Modelo", SqlDbType.VarChar, Modelo)
            Cn_Datos.Crea_Parametro(cmd, "@TienePropiedad", SqlDbType.VarChar, TienePropiedad)
            Cn_Datos.Crea_Parametro(cmd, "@UbicacionPropiedad", SqlDbType.VarChar, UbicacionPropiedad)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Actualiza", SqlDbType.VarChar, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
            Dim idIE As Integer = Cn_Datos.EjecutarNonQueryT(cmd)
            If idIE > 0 Then
                For i As Integer = 0 To DistribucionIngresos.Rows.Count - 1
                    cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosDistribucion_IngresoMensuales_AddUpd")
                    Cn_Datos.Crea_Parametro(cmd, "@Id_IngresosEgresos", SqlDbType.Int, Id_IngresosEgresos)
                    Cn_Datos.Crea_Parametro(cmd, "@Ingreso", SqlDbType.VarChar, DistribucionIngresos.Rows(i).Cells(1).Value)
                    Cn_Datos.Crea_Parametro(cmd, "@Cantidad", SqlDbType.Decimal, Decimal.Parse(DistribucionIngresos.Rows(i).Cells(2).Value))
                    Cn_Datos.Crea_Parametro(cmd, "@Orden", SqlDbType.Int, (i + 1))
                    EjecutarNonQueryT(cmd)
                    'fn_VisitaDom_Distribucion_IngresoMensuales_Agregar(Id_IngresosEgresos, DistribucionIngresos.Rows(i).Cells(1).Value, Decimal.Parse(DistribucionIngresos.Rows(i).Cells(2).Value), (i + 1))
                Next
                Tr.Commit()
                Return True
            End If
        Catch ex As Exception
            Tr.Rollback()
            Return False
        End Try

    End Function
    Public Shared Function fn_VisitaDom_Distribucion_IngresoMensuales_Eliminar(ByVal Id_IngresosEgresos As Integer
                                                              ) As Boolean
        Dim resp As Boolean = False
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_IngresosEgresos_Delete", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_IngresosEgresos", SqlDbType.Int, Id_IngresosEgresos)
            Dim eliminados As Integer = Cn_Datos.EjecutarNonQuery(Cmd)
            If eliminados > 0 Then
                resp = True
            End If

        Catch ex As Exception
            TrataEx(ex)

        End Try

        Return resp

    End Function


#End Region

#Region "Catálogo Modo de Contacto"

    Public Shared Function fn_ModoContacto_LlenarLista(ByRef lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContacto_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)
            lsv.Actualizar(Cmd, "Id_ModoContacto")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContacto_Validar(ByVal Descripcion As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContacto_Existe", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

            Dim Existe As Integer = EjecutarScalar(Cmd)
            Return Existe > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContacto_Nuevo(ByVal Descripcion As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContacto_Create", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Return EjecutarScalar(Cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContacto_Actualizar(ByVal Id_ModoContacto As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContacto_Update", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ModoContacto", SqlDbType.Int, Id_ModoContacto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Return EjecutarNonQuery(Cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContactoD_LlenarLista(ByVal Id_ModoContacto As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContactoD_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ModoContacto", SqlDbType.Int, Id_ModoContacto)
            lsv.Actualizar(Cmd, "Id_ModoContactoD")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContactoD_Validar(ByVal Id_ModoContacto As Integer, ByVal Descripcion As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContactoD_Existe", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ModoContacto", SqlDbType.Int, Id_ModoContacto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)

            Dim Existe As Integer = EjecutarScalar(Cmd)
            Return Existe > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContactoD_Nuevo(ByVal Id_ModoContacto As Integer, ByVal Descripcion As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContactoD_Create", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_ModoContacto", SqlDbType.Int, Id_ModoContacto)
            Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

            Return EjecutarScalar(Cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ModoContactoD_Actualizar(ByVal Id_ModoContactoD As Integer, ByVal Descripcion As String, ByVal Status As String) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ModoContactoD_Update", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_ModoContactoD", SqlDbType.Int, Id_ModoContactoD)
            Cn_Datos.Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Return EjecutarNonQuery(Cmd) > 0
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


#End Region

#Region "Unidades Reporte Fallas"

    Public Shared Function fn_UnidadesReporteFallas_NuevoSinAtender(ByVal Id_Unidad As Integer, ByVal Fecha_Reporte As Date, ByVal Hora_Reporte As Date, ByVal Usuario_Reporte As Integer, ByVal Id_ParteF As Integer, ByVal Observaciones As String, ByVal Descripcion_Unidad As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)

        Try
            Dim cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_UnidadesFallas_CreateCM")

            Crea_Parametro(cmd, "@Id_Unidad", SqlDbType.Int, Id_Unidad)
            Crea_Parametro(cmd, "@Id_Programacion", SqlDbType.Int, 0)
            Crea_Parametro(cmd, "@Fecha_Reporte", SqlDbType.Date, Fecha_Reporte)
            Crea_Parametro(cmd, "@Hora_Reporte", SqlDbType.Time, Format(Hora_Reporte, "HH:mm:ss"))
            Crea_Parametro(cmd, "@Usuario_Reporta", SqlDbType.Int, Usuario_Reporte)
            Crea_Parametro(cmd, "@Id_ParteF", SqlDbType.Int, Id_ParteF)
            Crea_Parametro(cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            EjecutarNonQueryT(cmd)

            '-------en el Proced Cat_RIA_Create( busca el N° siguiehynte de RIA y actualiza Cat_Sucursales Ult_Ria + 1
            '*******INSERTAR EN CAT_RIA
            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_RIA_Create")
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 1) ' 1 porque es falla de unidad
            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, Id_Unidad)
            Crea_Parametro(cmd, "@Fecha_RIA", SqlDbType.Date, Fecha_Reporte)
            Crea_Parametro(cmd, "@Hora_RIA", SqlDbType.Time, Format(Hora_Reporte, "HH:mm:ss"))
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Notas_Adicionales", SqlDbType.VarChar, "")
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Modo_Captura", SqlDbType.Int, 1) '1 es fijo ?
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Crea_Parametro(cmd, "@Descripcion_Entidad", SqlDbType.VarChar, Descripcion_Unidad)
            Dim ID_RIA As Integer = EjecutarScalarT(cmd)

            '*********INSERTAR EN CAT_RIAD
            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_RIAD_Create")
            Crea_Parametro(cmd, "@Id_RIA", SqlDbType.Int, ID_RIA)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 2) 'es fijo ?
            Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, Id_Unidad)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Fecha", SqlDbType.Date, Fecha_Reporte)
            Crea_Parametro(cmd, "@Hora", SqlDbType.Time, Format(Hora_Reporte, "HH:mm:ss"))
            EjecutarNonQueryT(cmd)

            '*********INSERTAR LOS DESTINATARIOS EN CAT_RIAU
            cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_RiaU_CreateXTipo")
            Crea_Parametro(cmd, "@Id_RIA", SqlDbType.Int, ID_RIA)
            Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, 2) 'es fijo
            Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, "18")
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.VarChar, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Rol", SqlDbType.Int, 2) '2 es secundario 1 es principal
            EjecutarNonQueryT(cmd)

            Tr.Commit()
            cmd.Dispose()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Dispose()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Alertas"

    Public Shared Function fn_AlertasGeneradas_Guardar(ByVal Clave_AlertaTipo As String, ByVal Detalles As String, ByVal AlertasD As DataTable, ByVal EnviarMail As Boolean, ByVal Asunto As String, ByVal Adjunto As String, ByVal DetallesHTML As String, Optional ByVal Reingreso As Boolean = False) As Boolean
        Dim Id_Alerta As Integer = 0
        Dim cmd As SqlCommand
        Dim Dt_Destinos As DataTable
        Dim Encabezado As String = ""
        Dim Pie As String = ""

        Try
            'Obtener los Destinos
            Dt_Destinos = fn_AlertasDestinos_Consultar(Clave_AlertaTipo)
            If Dt_Destinos Is Nothing Then
                MsgBox("No se encontraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
            If Dt_Destinos.Rows.Count = 0 Then
                MsgBox("No se encotnraron destinatarios para enviar la Alerta.", MsgBoxStyle.Critical, frm_MENU.Text)
                Return False
            End If
            If Adjunto <> "" Then
                Detalles = Detalles & Chr(13) & Chr(13) & "(Ver archivo adjunto)"
            End If

            'Guardar la alerta para cada destino
            For Each Destino As DataRow In Dt_Destinos.Rows
                cmd = Crea_Comando("Cat_AlertasGeneradas_CreateUna", CommandType.StoredProcedure, Crea_ConexionSTD())
                Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
                Crea_Parametro(cmd, "@Detalles", SqlDbType.VarChar, Detalles)
                Crea_Parametro(cmd, "@Id_EmpleadoDestino", SqlDbType.Int, Destino("Id_Empleado"))
                Crea_Parametro(cmd, "@Id_EmpleadoGenera", SqlDbType.Int, UsuarioId)
                Crea_Parametro(cmd, "@Estacion_Genera", SqlDbType.VarChar, EstacioN)
                Crea_Parametro(cmd, "@Tipo_Alerta", SqlDbType.Int, 1)
                Id_Alerta = CInt(EjecutarScalar(cmd))
                'Guardar el Detalle para cada alerta generada
                If AlertasD IsNot Nothing Then
                    For Each dr As DataRow In AlertasD.Rows
                        cmd.Parameters.Clear()
                        cmd = Crea_Comando("Cat_AlertasGeneradasD_Create", CommandType.StoredProcedure, Crea_ConexionSTD())
                        Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
                        Crea_Parametro(cmd, "@Id_Entidad", SqlDbType.Int, dr("Id"))
                        Crea_Parametro(cmd, "@Clave_Entidad", SqlDbType.VarChar, dr("Clave"))
                        Crea_Parametro(cmd, "@Descripcion", SqlDbType.VarChar, dr("Nombre"))
                        EjecutarNonQuery(cmd)
                    Next
                End If
                If EnviarMail Then
                    Select Case Clave_AlertaTipo
                        Case "12"
                            If Reingreso Then
                                Encabezado = "Por medio del presente se le informa del «Reingreso» del Empleado con los siguientes datos:"
                            Else
                                Encabezado = "Por medio del presente se le informa del Registro del Empleado de «Nuevo Ingreso» con los siguientes datos:"
                            End If

                        Case "13"
                            Encabezado = "Por medio del presente se le informa de la Baja del Empleado con los siguientes datos a partir de la fecha señalada:"

                        Case "17"
                            Encabezado = "FALLA EN UNIDAD DE TRASLADO DE VALORES"

                        Case "18"
                            Encabezado = "FALLA EN UNIDAD DE CAJEROS AUTOMATICOS"

                        Case "25"
                            Encabezado = "Por medio del presente se le informa del Registro de Custodia de Ruta con los siguientes datos:"

                        Case "32"
                            Encabezado = "FALLA EN UNIDAD DE CARTERA"

                        Case "33"
                            Encabezado = "FALLA EN UNIDAD DE SEGURIDAD PATRIMONIAL"

                        Case "34"
                            Encabezado = "FALLA EN UNIDAD DE SEGURIDAD INTERNA"

                        Case "35"
                            Encabezado = "FALLA EN UNIDAD OTRAS"

                        Case "37"
                            Encabezado = "FALLA EN UNIDAD DE RECLUTAMIENTO"

                    End Select

                    Pie = "Agente de Servicios SIAC " & Today.Year.ToString

                    If DetallesHTML = "" Then
                        Cn_Mail.fn_Enviar_Mail(Destino("Mail"), Asunto, Detalles, Adjunto)
                    Else
                        DetallesHTML = Replace(DetallesHTML, "Encabezado", Encabezado)
                        DetallesHTML = Replace(DetallesHTML, "Pie", Pie)
                        Cn_Mail.fn_Enviar_MailHTML(Destino("Mail"), Asunto, DetallesHTML, Adjunto)
                    End If
                End If
            Next
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_AlertasDestinos_Consultar(ByVal Clave_Alerta As String) As DataTable

        Try
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasDestinos_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_Alerta)

            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                Return dt
            Else
                Return Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "Generar Boletas"

    Public Shared Function fn_Boletas_GeneraReporte(ByVal Id_Empleado As Integer) As rpt_Boleta

        Dim rpt As New rpt_Boleta
        Dim Ds As New ds_Boleta

        fn_Boletas_LlenarDatosEmpleado(Ds, Id_Empleado)
        fn_Boletas_LlenarDatosFamiliares(Ds, Id_Empleado)

        If Ds.Cat_Empleados_ReadWEB.Rows.Count = 0 Then
            Return Nothing
        End If
        'If Ds.Cat_EmpleadosFamiliares_Read.Rows.Count = 0 Then
        '    Return Nothing
        'End If

        rpt.SetDataSource(Ds)

        Return rpt

    End Function

    Public Shared Sub fn_Boletas_LlenarDatosEmpleado(ByRef Ds As ds_Boleta, ByVal Id_Empleado As Integer)

        Dim cmd As SqlCommand = Crea_Comando("Cat_Empleados_ReadWEB", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            cmd.Connection.Open()
            Ds.Cat_Empleados_ReadWEB.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

    Public Shared Sub fn_Boletas_LlenarDatosFamiliares(ByRef Ds As ds_Boleta, ByVal Id_Empleado As Integer)

        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosFamiliares_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            cmd.Connection.Open()
            Ds.Cat_EmpleadosFamiliares_Read.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            TrataEx(ex)
        End Try
    End Sub

#End Region

#Region "Promoción de Empleados"

    Public Shared Function fn_EmpleadosPromo_LlenarLista(ByRef lsv As cp_Listview, ByVal IdDepto As Integer, ByVal IdPuesto As Integer, ByVal IdEmpleado As Integer) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosPromo_Get", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, IdDepto)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, IdPuesto)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_EmpleadoPromo")
            lsv.Columns(3).TextAlign = HorizontalAlignment.Right
            lsv.Columns(6).TextAlign = HorizontalAlignment.Right
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosPromo_Cancela(ByVal Id_EmpleadoPromo As Integer, ByVal Observ_cancela As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlTransaction = crear_Trans(Cnn)

        Try
            Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosPromo_Cancela")
            Crea_Parametro(Cmd, "@Id_EmpleadoPromo", SqlDbType.Int, Id_EmpleadoPromo)
            Crea_Parametro(Cmd, "@Observaciones_Cancela", SqlDbType.VarChar, Observ_cancela)
            Crea_Parametro(Cmd, "@Usuario_Cancela", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Cancela", SqlDbType.VarChar, EstacioN)
            If EjecutarNonQueryT(Cmd) = 0 Then
                Trans.Rollback()
                Cnn.Close()
                Return False
            End If

            Cmd = Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Empleados_UpdatePromo2")
            Crea_Parametro(Cmd, "@Id_EmpleadoPromo", SqlDbType.Int, Id_EmpleadoPromo)
            If EjecutarNonQueryT(Cmd) > 0 Then
                Trans.Commit()
                Cnn.Close()
                Return True
            Else
                Trans.Rollback()
                Cnn.Close()
                Return False
            End If
        Catch ex As Exception
            Trans.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosPromo_Guardar(ByVal IdEmpleado As Integer, ByVal IdDepartamentoA As Integer, ByVal IdPuestoA As Integer, ByVal SueldoDA As Decimal, ByVal SaleRutaA As String,
                                                     ByVal VerificaServA As String, ByVal IdDepartamentoN As Integer, ByVal IdPuestoN As Integer, ByVal SueldoDN As Decimal, ByVal SaleRutaN As String,
                                                     ByVal VerificaServN As String, ByVal Observaciones As String, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Trans As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand

        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_EmpleadosPromociones_Create")

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_DepartamentoA", SqlDbType.Int, IdDepartamentoA)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuestoA", SqlDbType.Int, IdPuestoA)
            Cn_Datos.Crea_Parametro(Cmd, "@Sueldo_DiarioA", SqlDbType.Decimal, SueldoDA)
            Cn_Datos.Crea_Parametro(Cmd, "@Sale_RutaA", SqlDbType.VarChar, SaleRutaA)
            Cn_Datos.Crea_Parametro(Cmd, "@Verifica_ServiciosA", SqlDbType.VarChar, VerificaServN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_DepartamentoN", SqlDbType.Int, IdDepartamentoN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuestoN", SqlDbType.Int, IdPuestoN)
            Cn_Datos.Crea_Parametro(Cmd, "@Sueldo_DiarioN", SqlDbType.Decimal, SueldoDN)
            Cn_Datos.Crea_Parametro(Cmd, "@Sale_RutaN", SqlDbType.VarChar, SaleRutaN)
            Cn_Datos.Crea_Parametro(Cmd, "@Verifica_ServiciosN", SqlDbType.VarChar, VerificaServN)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            Cn_Datos.EjecutarNonQueryT(Cmd)

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, Trans, CommandType.StoredProcedure, "Cat_Empleados_UpdatePromo")
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, IdEmpleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_DepartamentoN", SqlDbType.Int, IdDepartamentoN)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_PuestoN", SqlDbType.Int, IdPuestoN)
            Cn_Datos.Crea_Parametro(Cmd, "@Sueldo_DiarioN", SqlDbType.Decimal, SueldoDN)
            Cn_Datos.Crea_Parametro(Cmd, "@Sale_RutaN", SqlDbType.VarChar, SaleRutaN)
            Cn_Datos.Crea_Parametro(Cmd, "@Verifica_ServiciosN", SqlDbType.VarChar, VerificaServN)
            Cn_Datos.EjecutarNonQueryT(Cmd)

            Trans.Commit()
            Return True
        Catch ex As Exception
            Trans.Rollback()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Captura de Huellas"

    Public Shared Function fn_Empleados_LeerHuellasT(ByVal Id_Empleado As Integer, ByVal Version As Integer) As DataRow
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosHuellasTZK_Read", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@Version", SqlDbType.Int, Version)

        Try
            'Leer de SQL
            Dim dt As DataTable = EjecutaConsulta(com)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosHuellas_T_Actualizar(ByVal Id_Empleado As Integer, ByVal Dr_Huellas As DataRow, ByRef TeniaHuellas As Boolean, ByRef TeniaHuellasT As Boolean) As Boolean
        Dim Procedimiento As String = ""
        'Aqui se actualiza un registro
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlClient.SqlCommand
        Try
            If TeniaHuellas Then
                Procedimiento = "Cat_EmpleadosHuellas_Update"
            Else
                Procedimiento = "Cat_EmpleadosHuellas_Create"
            End If
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, Procedimiento)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Select Case Dr_Huellas("Dedo")
                Case 0
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 1)

                Case 1
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 2)

                Case 2
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 3)

                Case 3
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 4)

                Case 4
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 5)

                Case 5
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 6)

                Case 6
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 7)

                Case 7
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 8)

                Case 8
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 9)

                Case 9
                    Crea_Parametro(Cmd, "@Foto", SqlDbType.Image, Dr_Huellas("Huella_ImagenB"))
                    Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, 10)

            End Select

            If EjecutarNonQueryT(Cmd) > 0 Then TeniaHuellas = True

            If TeniaHuellasT Then
                Procedimiento = "Cat_EmpleadosHuellasTZK_Update"
            Else
                Procedimiento = "Cat_EmpleadosHuellasTZK_Create"
            End If
            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, Procedimiento)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Select Case Dr_Huellas("Dedo")
                Case 0
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Uno", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Once", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 1
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Dos", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Doce", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 2
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Tres", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Trece", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 3
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Cuatro", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Catorce", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 4
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Cinco", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Quince", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 5
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Seis", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Dieciseis", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 6
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Siete", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Diecisiete", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 7
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Ocho", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Dieciocho", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 8
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Nueve", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Diecinueve", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

                Case 9
                    If Dr_Huellas("HuellaV9") <> "" Then Crea_Parametro(Cmd, "@Diez", SqlDbType.VarChar, Dr_Huellas("HuellaV9"), False)
                    If Dr_Huellas("HuellaV10") <> "" Then Crea_Parametro(Cmd, "@Veinte", SqlDbType.VarChar, Dr_Huellas("HuellaV10"), False)

            End Select
            If Not TeniaHuellasT Then
                Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            End If

            If EjecutarNonQueryT(Cmd) > 0 Then TeniaHuellasT = True

            Tr.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Agregar Empleados A Relojes"

    Public Shared Function fn_RelojEmpleados_LlenarLista(ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Version As Integer, ByRef lsv As cp_Listview) As DataTable
        Try
            Dim dt As DataTable
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosHuellasTZK_Read2", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Crea_Parametro(Cmd, "@Version", SqlDbType.Int, Version)
            dt = EjecutaConsulta(Cmd)

            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Cmd = Crea_Comando("Cat_EmpleadosHuellasTZK_Get", CommandType.StoredProcedure, Cnn)
                Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
                Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
                Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
                Crea_Parametro(Cmd, "@Version", SqlDbType.Int, Version)
                Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")

                'Aqui se Actualiza la lista
                lsv.Actualizar(Cmd, "Id_Empleado")
            End If
            Return dt
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_Reloj_LlenarLista(ByVal Reloj As Integer, ByRef lsv As cp_Listview) As Boolean
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosXreloj_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reloj", SqlDbType.Int, Reloj)

            lsv.Actualizar(Cmd, "Id_EmpleadoReloj")
            Return True
        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXReloj_Agregados(ByVal Reloj As Integer) As DataTable
        Try
            Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosXreloj_Read", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Reloj", SqlDbType.Int, Reloj)

            Return EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosXReloj_Agregar(ByVal lsv As cp_Listview, ByVal Id_Reloj As Integer, ByVal Dt_HuellasT As DataTable) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim Creados As Integer = 0
            Dim Cmd As SqlClient.SqlCommand
            For Each Item As ListViewItem In lsv.CheckedItems
                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosXreloj_DeleteXReloj")
                Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Item.Tag)
                Crea_Parametro(Cmd, "@Id_Reloj", SqlDbType.Int, Id_Reloj)
                EjecutarNonQueryT(Cmd)

                Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosXreloj_Create")
                For Each Row As DataRow In Dt_HuellasT.Rows
                    If Item.Tag = Row("Id_Empleado") Then
                        Cmd.Parameters.Clear()

                        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Item.Tag)
                        Crea_Parametro(Cmd, "@Id_Reloj", SqlDbType.Int, Id_Reloj)
                        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
                        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
                        'Cuando se utilice también la versión 10 verificar de la sig manera:
                        If Row("Uno") <> "" OrElse Row("Once") <> "" Then Crea_Parametro(Cmd, "@Uno", SqlDbType.VarChar, "S")
                        If Row("Dos") <> "" OrElse Row("Doce") <> "" Then Crea_Parametro(Cmd, "@Dos", SqlDbType.VarChar, "S")
                        If Row("Tres") <> "" OrElse Row("Trece") <> "" Then Crea_Parametro(Cmd, "@Tres", SqlDbType.VarChar, "S")
                        If Row("Cuatro") <> "" OrElse Row("Catorce") <> "" Then Crea_Parametro(Cmd, "@Cuatro", SqlDbType.VarChar, "S")
                        If Row("Cinco") <> "" OrElse Row("Quince") <> "" Then Crea_Parametro(Cmd, "@Cinco", SqlDbType.VarChar, "S")
                        If Row("Seis") <> "" OrElse Row("Dieciseis") <> "" Then Crea_Parametro(Cmd, "@Seis", SqlDbType.VarChar, "S")
                        If Row("Siete") <> "" OrElse Row("Diecisiete") <> "" Then Crea_Parametro(Cmd, "@Siete", SqlDbType.VarChar, "S")
                        If Row("Ocho") <> "" OrElse Row("Dieciocho") <> "" Then Crea_Parametro(Cmd, "@Ocho", SqlDbType.VarChar, "S")
                        If Row("Nueve") <> "" OrElse Row("Diecinueve") <> "" Then Crea_Parametro(Cmd, "@Nueve", SqlDbType.VarChar, "S")
                        If Row("Diez") <> "" OrElse Row("Veinte") <> "" Then Crea_Parametro(Cmd, "@Diez", SqlDbType.VarChar, "S")

                        If EjecutarNonQueryT(Cmd) > 0 Then
                            Creados += 1
                            Exit For
                        End If
                    End If
                Next
            Next

            If Creados = lsv.CheckedItems.Count Then
                Tr.Commit()
                Cnn.Close()
                Return True
            Else
                Tr.Rollback()
                Cnn.Close()
                Return False
            End If
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXReloj_Eliminar(ByVal lsv As cp_Listview, ByVal Dt_NoEliminados As DataTable) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Try
            Dim Eliminados As Integer = 0
            Dim Cmd As SqlClient.SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosXreloj_Delete")
            If Dt_NoEliminados Is Nothing OrElse Dt_NoEliminados.Rows.Count = 0 Then
                'Cuando se hayan eliminado todos los registros en el reloj se hará lo mismo en la BD
                For Each Item As ListViewItem In lsv.CheckedItems
                    Cmd.Parameters.Clear()
                    Crea_Parametro(Cmd, "@Id_EmpleadoReloj", SqlDbType.Int, Item.Tag)
                    If EjecutarNonQueryT(Cmd) > 0 Then Eliminados += 1
                Next

                If Eliminados = lsv.CheckedItems.Count Then
                    Tr.Commit()
                    Cnn.Close()
                    Return True
                Else
                    Tr.Rollback()
                    Cnn.Close()
                    Return False
                End If
            Else
                'Solo eliminar en BD los que si se eliminaron en el reloj correctamente.
                For Each Item As ListViewItem In lsv.CheckedItems
                    For Each Row As DataRow In Dt_NoEliminados.Rows
                        If Item.Tag = Row("Id_EmpleadoReloj") Then Continue For

                        Cmd.Parameters.Clear()
                        Crea_Parametro(Cmd, "@Id_EmpleadoReloj", SqlDbType.Int, Item.Tag)
                        If EjecutarNonQueryT(Cmd) > 0 Then Eliminados += 1
                    Next
                Next

                If Eliminados = (lsv.CheckedItems.Count - Dt_NoEliminados.Rows.Count) Then
                    Tr.Commit()
                    Cnn.Close()
                    Return True
                Else
                    Tr.Rollback()
                    Cnn.Close()
                    Return False
                End If
            End If
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "CONSULTA DE BOLSA DE TRABAJO EN WEB"

    Public Shared Function fn_BolsadeTrabajo_LlenarLista(ByRef lsv As cp_Listview, ByVal Tipo As Integer) As Boolean

        Dim cmd As SqlCommand = Crea_Comando("www_Contacto_Get", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Tipo", SqlDbType.Int, Tipo)

        Try
            lsv.Actualizar(cmd, "Id_ContactoWeb")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "DATOS DE EMERGENCIA DEL EMPLEADO"

    Public Shared Function fn_DatosEmergencia_Guardar(ByVal Id_Empleado As Integer, ByVal lsv As cp_Listview) As Boolean

        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim trans As SqlClient.SqlTransaction = crear_Trans(Cnn)

        Try
            For cont = 0 To lsv.Items.Count - 1
                If lsv.Items(cont).Tag = 0 Then
                    Dim Cmd As SqlCommand = Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDatosEmergencia_Create")
                    Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
                    Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(0).Text)
                    Crea_Parametro(Cmd, "@Relacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Crea_Parametro(Cmd, "@Domicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Crea_Parametro(Cmd, "@Telefono_Fijo", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Crea_Parametro(Cmd, "@Telefono_Celular", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    EjecutarScalarT(Cmd)
                Else
                    Dim Cmd As SqlCommand = Cn_Datos.Crea_ComandoT(Cnn, trans, CommandType.StoredProcedure, "Cat_EmpleadosDatosEmergencia_Update")
                    Crea_Parametro(Cmd, "@Id_DatosEmergencia", SqlDbType.Int, lsv.Items(cont).Tag)
                    Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, lsv.Items(cont).SubItems(0).Text)
                    Crea_Parametro(Cmd, "@Relacion", SqlDbType.VarChar, lsv.Items(cont).SubItems(1).Text)
                    Crea_Parametro(Cmd, "@Domicilio", SqlDbType.VarChar, lsv.Items(cont).SubItems(2).Text)
                    Crea_Parametro(Cmd, "@Telefono_Fijo", SqlDbType.VarChar, lsv.Items(cont).SubItems(3).Text)
                    Crea_Parametro(Cmd, "@Telefono_Celular", SqlDbType.VarChar, lsv.Items(cont).SubItems(4).Text)
                    Crea_Parametro(Cmd, "@Mail", SqlDbType.VarChar, lsv.Items(cont).SubItems(5).Text)
                    Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, lsv.Items(cont).SubItems(6).Text)
                    EjecutarNonQueryT(Cmd)
                End If
            Next
        Catch ex As Exception
            trans.Rollback()
            TrataEx(ex)
            Return False
        End Try
        trans.Commit()
        Return True
    End Function

    Public Shared Function fn_DatosEmergencia_ObtenValores(ByVal lsv As cp_Listview, ByVal Id As Integer) As Boolean
        'Aqui se obtienen todas los datosDel contacto De Emergencia de un Empleado en particular
        Dim Cnn As SqlConnection = Crea_ConexionSTD()

        Dim Cmd As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosDatosEmergencia_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id)

        Try
            lsv.Actualizar(Cmd, "Id_DatosEmergencia")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_DatosEmergencia_Borrar(ByVal Id_DatosEmergencia As Integer) As Boolean

        Try
            Dim Cnn As SqlConnection = Crea_ConexionSTD()
            Dim Cmd As SqlCommand = Crea_Comando("Cat_EmpleadosDatosEmergencia_Delete", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_DatosEmergencia", SqlDbType.Int, Id_DatosEmergencia)
            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

#End Region

#Region "DESCARGA DE ARCHIVO"
    Public Shared Function fn_ModulosArchivos_LlenarLista(ByRef lsv As cp_Listview, ByVal Clave_Modulo As String) As Boolean

        'Aqui se llena el listview
        Dim Cnn As SqlConnection = Cn_Datos.Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, Clave_Modulo)
        Try
            lsv.Actualizar(Cmd, "Id_Doc")
            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex, True)
            Return False
        End Try
    End Function

    Public Shared Function fn_Archivos_Descargar(ByVal Id_Doc As Integer) As Byte()
        Dim dt As DataTable
        'Aqui se llena el listview
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Usr_Documentos_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Doc", SqlDbType.Int, Id_Doc)
        Try
            dt = Cn_Datos.EjecutaConsulta(Cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt.Rows(0)("Archivo")
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try

    End Function
#End Region

#Region "CATALOGO DE EMPLEADOS POX FUERA"

    Public Shared Function fn_EmpleadosXF_Guardar(ByVal Clave As String, ByVal NombreCompleto As String,
                                                  ByVal Id_Departamento As Integer,
                                                  ByVal Id_Puesto As Integer, ByVal Sexo As Char,
                                                  ByVal Id_EstadoCivil As Integer, ByVal Mail As String,
                                                  ByVal APaterno As String,
                                                  ByVal AMaterno As String, ByVal Nombres As String,
                                                  ByVal Calle As String, ByVal Numero As Integer, ByVal Colonia As String,
                                                  ByVal Telefono As String, ByVal FechaNac As Date,
                                                 ByVal FechaIngreso As Date, ByVal Id_Ciudad As Integer,
                                                  ByVal Numero_Seguro As String,
                                                  ByVal RFC As String, ByVal CURP As String, ByVal IdTributario As String) As Integer

        'Aquí se inserta un nuevo "empleado de fuera"
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_Create", CommandType.StoredProcedure, Cnn)

        Try
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Cn_Datos.Crea_Parametro(Cmd, "@Clave_EmpleadoXF", SqlDbType.VarChar, Clave)
            Cn_Datos.Crea_Parametro(Cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Cn_Datos.Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Cn_Datos.Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, Id_EstadoCivil)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Nacimiento", SqlDbType.Date, FechaNac)
            Cn_Datos.Crea_Parametro(Cmd, "@Mail_Personal", SqlDbType.VarChar, Mail)
            Cn_Datos.Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Cn_Datos.Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, Calle)
            Cn_Datos.Crea_Parametro(Cmd, "@Numero", SqlDbType.Int, Numero)
            Cn_Datos.Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Ingreso", SqlDbType.Date, FechaIngreso)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@Numero_Seguro", SqlDbType.VarChar, Numero_Seguro)
            Cn_Datos.Crea_Parametro(Cmd, "@RFC", SqlDbType.VarChar, RFC)
            Cn_Datos.Crea_Parametro(Cmd, "@CURP", SqlDbType.VarChar, CURP)
            Cn_Datos.Crea_Parametro(Cmd, "@IdTributario", SqlDbType.VarChar, IdTributario)

            Dim Id_EmpleadoXF As Integer
            Id_EmpleadoXF = EjecutarScalar(Cmd)
            Return Id_EmpleadoXF

        Catch ex As Exception
            Cmd.Dispose()
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_LlenarLista(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer, ByVal Status As String) As Boolean
        Try
            'Aqui se llena el listview
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)

            'Aqui se Actualiza la lista
            lsv.Actualizar(Cmd, "Id_EmpleadoXF")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_GuardaImagenes(ByVal Id_EmpleadoXF As Integer, ByVal FotoFrente As Byte(), ByVal FotoFirma As Byte()) As Boolean

        Try
            'guardar las imagenes si las hay
            Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXFI_Create", CommandType.StoredProcedure, Cnn)

            Crea_Parametro(Cmd, "@Id_EmpleadoXF", SqlDbType.Int, Id_EmpleadoXF)
            Crea_Parametro(Cmd, "@Frente", SqlDbType.VarBinary, FotoFrente)
            Crea_Parametro(Cmd, "@Firma", SqlDbType.VarBinary, FotoFirma)

            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_Read(ByVal Id_EmpleadoXF As Integer) As DataRow
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoXF", SqlDbType.Int, Id_EmpleadoXF)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If Tbl IsNot Nothing AndAlso Tbl.Rows.Count > 0 Then
                Return Tbl.Rows(0)
            Else
                Return Nothing
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_ValidarClave(ByVal Clave As String) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_ClaveRead", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Clave_EmpleadoXF", SqlDbType.VarChar, Clave)

        Try
            Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If Tbl.Rows.Count > 0 Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_BajaAlta(ByVal Id_EmpleadoXF As Integer) As Boolean
        'Aqui se actualiza un elemento 
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Try
            Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosXF_Status", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_EmpleadoXF", SqlDbType.Int, Id_EmpleadoXF)
            Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
            Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.Int, EstacioN)
            Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "B")


            EjecutarNonQuery(Cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_EmpleadosXF_GuardarCambios(ByVal Id_EmpleadoXF As Integer, ByVal Clave As String,
                                                         ByVal NombreCompleto As String, ByVal Id_Departamento As Integer,
                                                         ByVal Id_Puesto As Integer,
                                                         ByVal Sexo As Char, ByVal Id_EstadoCivil As Integer,
                                                         ByVal Mail As String, ByVal APaterno As String,
                                                         ByVal AMaterno As String, ByVal Nombres As String,
                                                         ByVal Calle As String, ByVal Numero As Integer,
                                                         ByVal Colonia As String,
                                                         ByVal Telefono As String, ByVal FechaNac As Date,
                                                         ByVal FotoFrente As Byte(),
                                                         ByVal FotoFirma As Byte(), ByVal FotoCodigo As Byte(),
                                                         ByVal FechaIngreso As Date, ByVal Id_Ciudad As Integer,
                                                         ByVal Numero_Seguro As String, ByVal RFC As String,
                                                         ByVal CURP As String, ByVal IdTributario As String) As Boolean

        'Aquí se inserta Actualiza "empleado de fuera"
        Dim Cnn As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim Tr As SqlTransaction = crear_Trans(Cnn)
        Dim Cmd As SqlCommand = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosXF_Update")

        Try
            Crea_Parametro(Cmd, "@Id_EmpleadoXF", SqlDbType.Int, Id_EmpleadoXF) 'mandar ste parametro

            Crea_Parametro(Cmd, "@Clave_EmpleadoXF", SqlDbType.VarChar, Clave)
            Crea_Parametro(Cmd, "@APaterno", SqlDbType.VarChar, APaterno)
            Crea_Parametro(Cmd, "@AMaterno", SqlDbType.VarChar, AMaterno)
            Crea_Parametro(Cmd, "@Nombres", SqlDbType.VarChar, Nombres)
            Crea_Parametro(Cmd, "@Nombre", SqlDbType.VarChar, NombreCompleto)
            Crea_Parametro(Cmd, "@Sexo", SqlDbType.VarChar, Sexo)
            Crea_Parametro(Cmd, "@Id_EstadoCivil", SqlDbType.Int, Id_EstadoCivil)
            Crea_Parametro(Cmd, "@Fecha_Nacimiento", SqlDbType.Date, FechaNac)
            Crea_Parametro(Cmd, "@Mail_Personal", SqlDbType.VarChar, Mail)
            Crea_Parametro(Cmd, "@Telefono", SqlDbType.VarChar, Telefono)
            Crea_Parametro(Cmd, "@Calle", SqlDbType.VarChar, Calle)
            Crea_Parametro(Cmd, "@Numero", SqlDbType.Int, Numero)
            Crea_Parametro(Cmd, "@Colonia", SqlDbType.VarChar, Colonia)
            Crea_Parametro(Cmd, "@Id_Ciudad", SqlDbType.Int, Id_Ciudad)
            Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
            Crea_Parametro(Cmd, "@Fecha_Ingreso", SqlDbType.Date, FechaIngreso)
            Crea_Parametro(Cmd, "@Numero_Seguro", SqlDbType.VarChar, Numero_Seguro)
            Crea_Parametro(Cmd, "@RFC", SqlDbType.VarChar, RFC)
            Crea_Parametro(Cmd, "@IdTributario", SqlDbType.VarChar, IdTributario)
            Crea_Parametro(Cmd, "@CURP", SqlDbType.VarChar, CURP)
            EjecutarNonQueryT(Cmd)

            Cmd = Crea_ComandoT(Cnn, Tr, CommandType.StoredProcedure, "Cat_EmpleadosXFI_Update")
            Crea_Parametro(Cmd, "@Id_EmpleadoXF", SqlDbType.Int, Id_EmpleadoXF)
            Crea_Parametro(Cmd, "@Frente", SqlDbType.VarBinary, FotoFrente)
            Crea_Parametro(Cmd, "@Firma", SqlDbType.VarBinary, FotoFirma)
            Crea_Parametro(Cmd, "@Codigo", SqlDbType.VarBinary, FotoCodigo)
            EjecutarNonQueryT(Cmd)

            Tr.Commit()
            Cnn.Close()
            Return True
        Catch ex As Exception
            Tr.Rollback()
            Cnn.Close()
            TrataEx(ex)
            Return False
        End Try
    End Function

#End Region

#Region "Cargar Documentos"

#End Region

#Region "Reporte General"

    Public Shared Function fn_ReporteGeneral_LlenarLista(ByVal Lsv As cp_Listview, ByVal Id_departamento As Integer, ByVal Status As String, ByVal Id_Puesto As Integer, ByVal FDesde As Date, ByVal FHasta As Date, ByVal FiltroFecha As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_Empleados_GetCompleto", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Departamento", SqlDbType.Int, Id_departamento)
        Crea_Parametro(Cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Crea_Parametro(Cmd, "@FDesde", SqlDbType.Date, FDesde)
        Crea_Parametro(Cmd, "@FHasta", SqlDbType.Date, FHasta)
        Crea_Parametro(Cmd, "@FiltroF", SqlDbType.VarChar, FiltroFecha)
        Try
            Lsv.Actualizar(Cmd, "Id_Empleado")
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function

#End Region

#Region "FUNCION CUENTA SETTINGS"

    Public Shared Function fn_CuentaSettings() As Integer
        Dim CuentaSettings As Integer = 0
        For Each setting As System.Configuration.SettingsProperty In My.Settings.Properties
            If Microsoft.VisualBasic.Left(setting.Name.ToString.ToUpper, 9) = "SERVDATOS" AndAlso (My.Settings(setting.Name)).ToString.Split(",")(0) = "VACIO" Then
                CuentaSettings += 1
            End If
        Next
        Return CuentaSettings
    End Function

#End Region

#Region "Configurar Plantilla Impresion 27/10/2014"
    Public Shared Function fn_ConsultarPlantilla() As DataTable
        Dim Dt As DataTable
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Usr_ModulosP_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ModificarPlantilla(ByVal Clave_Venta As String, ByVal Clave_Rotulo As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Usr_ModulosP_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Crea_Parametro(Cmd, "@Plantilla_VentaMat", SqlDbType.VarChar, Clave_Venta)
        Crea_Parametro(Cmd, "@Plantilla_RotuloMat", SqlDbType.VarChar, Clave_Rotulo)
        Try
            EjecutaConsulta(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex, True)
            Return False
        End Try
    End Function
#End Region

#Region "Imprimir Gafetes 20 Marzo 2015"

    Public Shared Function fn_Gafetes_Llenarlista(ByVal Lsv As cp_Listview, ByVal Tipo As Byte, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GafetInterno_Get", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.VarChar, Tipo)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            Lsv.Actualizar(Cmd, "Id_GafetInterno")
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Gafetes_Status(ByVal Id_Gafete As Integer, ByVal Status As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GafetInterno_Status", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_GafetInterno", SqlDbType.Int, Id_Gafete)
        Crea_Parametro(Cmd, "@Usuario_Baja", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Baja", SqlDbType.VarChar, EstacioN)
        Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Gafetes_Nuevo(ByVal Tipo As Byte, ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GafetInterno_Create", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
        Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Gafetes_Modificar(ByVal Id_Gafete As Integer, ByVal Tipo As Byte, ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GafetInterno_Update", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_GafetInterno", SqlDbType.Int, Id_Gafete)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Try
            EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_Gafetes_Existe(ByVal Tipo As Byte, ByVal Descripcion As String) As Boolean
        Dim Cnn As SqlConnection = Crea_ConexionSTD()
        Dim Cmd As SqlCommand = Crea_Comando("Cat_GafetInterno_Existe", CommandType.StoredProcedure, Cnn)
        Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
        Crea_Parametro(Cmd, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Try
            Dim dt_gafetes As DataTable = EjecutaConsulta(Cmd)

            If dt_gafetes.Rows.Count > 0 Then
                Return False
            Else
                Return True
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_ConsultaDatosEmpresa() As DataTable
        Dim dt_DatosEmpresa As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Cat_Sucursales_GetDatos", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Try
            dt_DatosEmpresa = EjecutaConsulta(cmd)
            Return dt_DatosEmpresa
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function
#End Region

#Region "DATOS ADICIONALES 27 julio 2015,29ago2015"

    Public Shared Function fn_DatosAdicionales_Guardar(ByVal Id_Empleado As Integer, ByVal FechaAntidoping As Date, ByVal Antecedentes_Penales As String,
                                  ByVal Demandas As String, ByVal Examen_Medico As String, ByVal Antidoping As String, ByVal Enfermedades As String,
                                  ByVal Observaciones As String, ByVal Estudio_Socioeconomico As String, ByVal Antecedentes_Observaciones As String,
                                  ByVal Demandas_Observaciones As String, ByVal Examen_Observaciones As String, ByVal Antidoping_Observaciones As String,
                                  ByVal Enfermedades_Observaciones As String, ByVal Estudio_Observaciones As String, ByVal Examen_Psicometrico As String,
                                  ByVal Psicometrico_Observaciones As String, ByVal Fecha_Psicometrico As Date, ByVal Examen_Antidoping As String,
                                  ByVal Fecha_CartaAPenales As Date, ByVal Fecha_ESocioeconomico As Date, ByVal Fecha_ExMedico As Date) As Integer


        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosAdicionales_Create", CommandType.StoredProcedure, Cnn)
        Dim Id_DatosAdicionales As Integer = 0

        Try
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Antecedentes_Penales", SqlDbType.VarChar, Antecedentes_Penales)
            Cn_Datos.Crea_Parametro(Cmd, "@Demandas", SqlDbType.VarChar, Demandas)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Medico", SqlDbType.VarChar, Examen_Medico)
            Cn_Datos.Crea_Parametro(Cmd, "@Antidoping", SqlDbType.VarChar, Antidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Antidoping", SqlDbType.Date, FechaAntidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Enfermedades", SqlDbType.VarChar, Enfermedades)
            Cn_Datos.Crea_Parametro(Cmd, "@Estudio_Socioeconomico", SqlDbType.VarChar, Estudio_Socioeconomico)
            Cn_Datos.Crea_Parametro(Cmd, "@Antecedentes_Observaciones", SqlDbType.VarChar, Antecedentes_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Demandas_Observaciones", SqlDbType.VarChar, Demandas_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Observaciones", SqlDbType.VarChar, Examen_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Antidoping_Observaciones", SqlDbType.VarChar, Antidoping_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Enfermedades_Observaciones", SqlDbType.VarChar, Enfermedades_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Estudio_Observaciones", SqlDbType.VarChar, Estudio_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Psicometrico", SqlDbType.VarChar, Examen_Psicometrico)
            Cn_Datos.Crea_Parametro(Cmd, "@Psicometrico_Observaciones", SqlDbType.VarChar, Psicometrico_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Psicometrico", SqlDbType.Date, Fecha_Psicometrico)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_CartaAPenales", SqlDbType.Date, Fecha_CartaAPenales)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_ESocioeconomico", SqlDbType.Date, Fecha_ESocioeconomico)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_ExMedico", SqlDbType.Date, Fecha_ExMedico)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Antidoping", SqlDbType.VarChar, Examen_Antidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)

            Id_DatosAdicionales = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_DatosAdicionales

        Catch ex As Exception
            TrataEx(ex)
            Return -1
        End Try

    End Function

    Public Shared Function fn_DatosAdicionales_Actualizar(ByVal Id_Empleado As Integer, ByVal FechaAntidoping As Date, ByVal Antecedentes_Penales As String,
                              ByVal Demandas As String, ByVal Examen_Medico As String, ByVal Antidoping As String, ByVal Enfermedades As String, ByVal Observaciones As String,
                              ByVal Estudio_Socioeconomico As String, ByVal Antecedentes_Observaciones As String, ByVal Demandas_Observaciones As String,
                              ByVal Examen_Observaciones As String, ByVal Antidoping_Observaciones As String, ByVal Enfermedades_Observaciones As String,
                              ByVal Estudio_Observaciones As String, ByVal Examen_Psicometrico As String, ByVal Psicometrico_Observaciones As String,
                              ByVal Fecha_Psicometrico As Date, ByVal Examen_Antidoping As String,
                              ByVal Fecha_CartaAPenales As Date, ByVal Fecha_ESocioeconomico As Date, ByVal Fecha_ExMedico As Date) As Boolean



        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosAdicionales_Update", CommandType.StoredProcedure, Cnn)

        Try
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Antecedentes_Penales", SqlDbType.VarChar, Antecedentes_Penales)
            Cn_Datos.Crea_Parametro(Cmd, "@Demandas", SqlDbType.VarChar, Demandas)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Medico", SqlDbType.VarChar, Examen_Medico)
            Cn_Datos.Crea_Parametro(Cmd, "@Antidoping", SqlDbType.VarChar, Antidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Antidoping", SqlDbType.Date, FechaAntidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Enfermedades", SqlDbType.VarChar, Enfermedades)
            Cn_Datos.Crea_Parametro(Cmd, "@Estudio_Socioeconomico", SqlDbType.VarChar, Estudio_Socioeconomico)
            Cn_Datos.Crea_Parametro(Cmd, "@Antecedentes_Observaciones", SqlDbType.VarChar, Antecedentes_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Demandas_Observaciones", SqlDbType.VarChar, Demandas_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Observaciones", SqlDbType.VarChar, Examen_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Antidoping_Observaciones", SqlDbType.VarChar, Antidoping_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Enfermedades_Observaciones", SqlDbType.VarChar, Enfermedades_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Estudio_Observaciones", SqlDbType.VarChar, Estudio_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Psicometrico", SqlDbType.VarChar, Examen_Psicometrico)
            Cn_Datos.Crea_Parametro(Cmd, "@Psicometrico_Observaciones", SqlDbType.VarChar, Psicometrico_Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Psicometrico", SqlDbType.Date, Fecha_Psicometrico)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_CartaAPenales", SqlDbType.Date, Fecha_CartaAPenales)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_ESocioeconomico", SqlDbType.Date, Fecha_ESocioeconomico)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_ExMedico", SqlDbType.Date, Fecha_ExMedico)
            Cn_Datos.Crea_Parametro(Cmd, "@Examen_Antidoping", SqlDbType.VarChar, Examen_Antidoping)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DatosAdicionales_Consultar(ByVal Id_Empleado As Integer) As DataTable
        Dim dt_DatosAdic As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosAdicionales_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            dt_DatosAdic = EjecutaConsulta(cmd)
            Return dt_DatosAdic
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "DATOS EXPEDIENTE 10 de Septiembre de 2015"

    Public Shared Function fn_DatosExpediente_Guardar(ByVal Id_Empleado As Integer, ByVal Observaciones As String, ByVal UsuarioReviso As Integer,
                                                      ByVal FechaRevision As Date) As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosExpediente_Create", CommandType.StoredProcedure, Cnn)
        Dim Id_Expediente As Integer = 0

        Try
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Revision", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Revision", SqlDbType.Int, UsuarioReviso)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Revision", SqlDbType.Date, FechaRevision)

            Id_Expediente = Cn_Datos.EjecutarScalar(Cmd)
            Return Id_Expediente

        Catch ex As Exception
            TrataEx(ex)
            Return -1
        End Try

    End Function

    Public Shared Function fn_DatosExpediente_Actualizar(ByVal Id_Empleado As Integer, ByVal Observaciones As String, ByVal UsuarioReviso As Integer,
                                                      ByVal FechaRevision As Date) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosExpediente_Update", CommandType.StoredProcedure, Cnn)
        Try

            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Cn_Datos.Crea_Parametro(Cmd, "@Observaciones_Revision", SqlDbType.VarChar, Observaciones)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Revision", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Fecha_Revision", SqlDbType.Date, FechaRevision)
            Cn_Datos.Crea_Parametro(Cmd, "@Usuario_Actualiza", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Estacion_Actualiza", SqlDbType.VarChar, EstacioN)
            Cn_Datos.EjecutarNonQuery(Cmd)
            Return True
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_DatosExpediente_Consultar(ByVal Id_Empleado As Integer) As DataTable
        Dim dt_DatosExp As DataTable

        Dim cmd As SqlCommand = Crea_Comando("Cat_EmpleadosExpediente_Read", CommandType.StoredProcedure, Crea_ConexionSTD)
        Cn_Datos.Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)

        Try
            dt_DatosExp = EjecutaConsulta(cmd)
            Return dt_DatosExp
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

#End Region

#Region "SORTEO ANTODOPING 30-SEP-15"
    Public Shared Function fn_SorteoAntodoping_ListaEmpleados(ByRef lsv As cp_Listview, ByVal Id_Departamento As Integer, ByVal Id_Puesto As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_Empleados_GetAntidoping", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Id_Departamento", SqlDbType.Int, Id_Departamento)
            Crea_Parametro(cmd, "@Id_Puesto", SqlDbType.Int, Id_Puesto)

            lsv.Actualizar(cmd, "Id_Empleado")
            Return True

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_SorteoAntodoping_Guardar(ByVal Filtro_Departamento As Integer, ByVal Filtro_Puesto As Integer, ByVal TotalDisponibles As Integer,
                                                       ByVal TotalSeleccionados As Integer, ByVal TotalSorteo As Integer, ByVal Dias As Integer,
                                                       ByVal Dt_Sorteo As DataTable, ByVal Usuario_Autoriza As Integer) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim tr As SqlTransaction = crear_Trans(cnn)
        Dim cmd As SqlCommand = Nothing

        Try
            cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosSorteos_Create")
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo_Sorteo", SqlDbType.TinyInt, 1)
            Crea_Parametro(cmd, "@Filtro_Departamento", SqlDbType.Int, Filtro_Departamento)
            Crea_Parametro(cmd, "@Filtro_Puesto", SqlDbType.Int, Filtro_Puesto)
            Crea_Parametro(cmd, "@Dias_Antidoping", SqlDbType.Int, Dias)
            Crea_Parametro(cmd, "@Total_Disponibles", SqlDbType.Int, TotalDisponibles)
            Crea_Parametro(cmd, "@Total_Seleccionados", SqlDbType.Int, TotalSeleccionados)
            Crea_Parametro(cmd, "@Total_Sorteados", SqlDbType.Int, TotalSorteo)
            Crea_Parametro(cmd, "@Usuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Registro", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Usuario_Autoriza", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
            Dim Id_EmpleadoSorteo As Integer = EjecutarScalarT(cmd)

            If Id_EmpleadoSorteo > 0 Then
                For Each dr_Sorteo As DataRow In Dt_Sorteo.Rows
                    cmd.Parameters.Clear()
                    cmd = Crea_ComandoT(cnn, tr, CommandType.StoredProcedure, "Cat_EmpleadosSorteosD_Create")
                    Crea_Parametro(cmd, "@Id_EmpleadoSorteo", SqlDbType.Int, Id_EmpleadoSorteo)
                    Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, dr_Sorteo("Id_Empleado"))
                    Crea_Parametro(cmd, "@Seleccionado", SqlDbType.VarChar, dr_Sorteo("Seleccionado"))
                    Crea_Parametro(cmd, "@Sorteado", SqlDbType.VarChar, dr_Sorteo("Sorteado"))
                    EjecutarNonQueryT(cmd)
                Next
            Else
                tr.Rollback()
                Return False
            End If

            tr.Commit()
            Return True

        Catch ex As Exception
            tr.Rollback()
            TrataEx(ex, False)
            Return False
        End Try

    End Function

#End Region

#Region "Consulta Sorteo Antidoping 03-Oct-15"

    Public Shared Function fn_SorteoAntidopingConsulta_Sorteos(ByRef lsv As cp_Listview, ByVal Desde As Date, ByVal Hasta As Date, ByVal Status As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_EmpleadosSorteos_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            Crea_Parametro(cmd, "@Tipo_Sorteo", SqlDbType.TinyInt, 1)
            Crea_Parametro(cmd, "@Desde", SqlDbType.Date, Desde)
            Crea_Parametro(cmd, "@Hasta", SqlDbType.Date, Hasta)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            lsv.Actualizar(cmd, "Id_EmpleadoSorteo")
            Return True

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

    Public Shared Function fn_SorteoAntidopingConsulta_Detalle(ByVal Id_EmpleadoSorteo As Integer) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_EmpleadosSorteosD_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_EmpleadoSorteo", SqlDbType.Int, Id_EmpleadoSorteo)

            Return EjecutaConsulta(cmd)

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try

    End Function

    Public Shared Function fn_SorteoAntidopingConsulta_Status(ByVal Id_EmpleadoSorteo As Integer, ByVal Observaciones As String, ByVal Status As String) As Boolean
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_EmpleadosSorteos_Status", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_EmpleadoSorteo", SqlDbType.Int, Id_EmpleadoSorteo)
            Crea_Parametro(cmd, "@Usuario_Afecta", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@Estacion_Afecta", SqlDbType.VarChar, EstacioN)
            Crea_Parametro(cmd, "@Observaciones_Afecta", SqlDbType.VarChar, Observaciones)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            EjecutarNonQuery(cmd)
            Return True

        Catch ex As Exception
            TrataEx(ex, False)
            Return False
        End Try
    End Function

#End Region

#Region "Documentos por Empleado"
    'Raul Coss 07Jul2017
    Public Shared Function fn_DoctosRequeridos_Consultar(ByVal Status As String) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_EmpleadosDoctosR_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            Dim dt_Datos As DataTable = EjecutaConsulta(cmd)
            Return dt_Datos

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function


    Public Shared Function fn_DoctosXempleado_Consultar(ByVal FDesde As Date, ByVal FHasta As Date, ByVal Status As String) As DataTable
        Dim cnn As SqlConnection = Crea_ConexionSTD()
        Dim cmd As SqlCommand = Nothing
        Try
            cmd = Crea_Comando("Cat_EmpleadosDoctos_Get", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@FDesde", SqlDbType.Date, FDesde)
            Crea_Parametro(cmd, "@FHasta", SqlDbType.Date, FHasta)
            Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, Status)

            Dim dt_Datos As DataTable = EjecutaConsulta(cmd)
            Return dt_Datos

        Catch ex As Exception
            TrataEx(ex, False)
            Return Nothing
        End Try
    End Function

#End Region


#Region "SOLICITUD DE EMPLEO"
    Public Shared Function fn_Empleado_Registro_empleo_rpt(ByRef ds As ds_Solicitud, ByVal Id_Empleado As Integer) As Boolean
        Dim cnn As SqlConnection = Nothing
        Dim cmd As SqlCommand = Nothing
        Try
            cnn = Crea_ConexionSTD()
            '
            cmd = Crea_Comando("Cat_Empleados_GetFichaTecnica_Rpt", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            Crea_Parametro(cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)
            cmd.Connection.Open()
            ds.dt_Solicitud.Load(cmd.ExecuteReader)

            'Dim cont As Integer = ds.dt_Solicitud.Count

            '
            cmd = Crea_Comando("Cat_Empleados_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_Datos.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosEscolares_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_DatosE.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosFamiliares_rpt__Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_DatosF.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosFamiliares3_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_Padre.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosFamiliares1_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_Hermanos.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosFamiliares2_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_Madre.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosRasgos_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.Dt_Rasgos.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosReferencias_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_Referencias.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosIngresos_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_Iengresos.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosSenas1_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_mafiliacion1.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosSenas2_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_mafiliacion2.Load(cmd.ExecuteReader)

            cmd = Crea_Comando("Cat_EmpleadosSenas3_rpt_Read", CommandType.StoredProcedure, cnn)
            Crea_Parametro(cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            ds.dt_mafiliacion3.Load(cmd.ExecuteReader)
            cmd.Connection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString())
            cnn.Dispose()
            cmd.Dispose()
            Return False
        End Try
        Return True
    End Function
    Public Shared Function fn_EmpleadoRead_TrabajoAnterior(ByVal Id_Empleado As Integer) As DataTable
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cmd As SqlCommand = Nothing
        Dim Cnn As SqlConnection = Nothing
        Dim dt_EmpleadosEmpleoAnt As DataTable

        Try
            Cnn = Crea_ConexionSTD()
            Cmd = Crea_Comando("Cat_EmpleadosLaborales_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            dt_EmpleadosEmpleoAnt = EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Cnn.Dispose()
            Cmd.Dispose()
            Return Nothing
        End Try
        Return dt_EmpleadosEmpleoAnt
    End Function
    Public Shared Function fn_EmpleadoRead_Cusosrecibidos(ByVal Id_Empleado As Integer) As DataTable
        'Aqui se obtienen todos los valores de un registro en particular
        Dim Cmd As SqlCommand = Nothing
        Dim Cnn As SqlConnection = Nothing
        Dim dt_cursosrecibidos As DataTable

        Try
            Cnn = Crea_ConexionSTD()
            Cmd = Crea_Comando("Cat_EmpleadosCursos_Read", CommandType.StoredProcedure, Cnn)
            Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
            dt_cursosrecibidos = EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
            Cnn.Dispose()
            Cmd.Dispose()
            Return Nothing
        End Try
        Return dt_cursosrecibidos
    End Function
#End Region

    Public Shared Function fn_Agregar_Colonia(ByVal idPais As Integer,
                                                 ByVal claveEstado As String,
                                                 ByVal claveCiudad As String,
                                                 ByVal codigoPostal As String,
                                                 ByVal nombreColonia As String,
                                                 ByVal idEstado As Integer,
                                                 ByVal idCiudad As Integer,
                                                 ByVal clave_Colonia As Integer) As Integer
        Dim fecha = DateTime.Now.ToString("dd-MM-yyyy HH:mm:ss")

        Dim cmd As SqlCommand
        Try
            cmd = Crea_Comando("insertarColoniaPorUsuario", CommandType.StoredProcedure, Crea_ConexionSTD)
            Crea_Parametro(cmd, "@claveColonia", SqlDbType.VarChar, clave_Colonia.ToString())
            Crea_Parametro(cmd, "@idPais", SqlDbType.Int, idPais)
            Crea_Parametro(cmd, "@claveEstado", SqlDbType.VarChar, claveEstado)
            Crea_Parametro(cmd, "@claveCiudad", SqlDbType.VarChar, claveCiudad)
            Crea_Parametro(cmd, "@codigoPostal", SqlDbType.VarChar, codigoPostal)
            Crea_Parametro(cmd, "@nombreColonia", SqlDbType.VarChar, nombreColonia)
            Crea_Parametro(cmd, "@idEstado", SqlDbType.Int, idEstado)
            Crea_Parametro(cmd, "@idCiudad", SqlDbType.Int, idCiudad)
            Crea_Parametro(cmd, "@idUsuario_Registro", SqlDbType.Int, UsuarioId)
            Crea_Parametro(cmd, "@fechaRegistro", SqlDbType.DateTime, fecha)

            EjecutarNonQuery(cmd)
            cmd.Connection.Close()
            Return 1
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Function fn_BuscarDatosColonia(ByVal CodigoPostal As String) As DataTable
        Dim cmd As SqlCommand = Crea_Comando("Buscar_DatosColonia", CommandType.StoredProcedure, Crea_ConexionSTD)
        Crea_Parametro(cmd, "@CodigoPostal", SqlDbType.VarChar, CodigoPostal)
        Try
            Dim dt As DataTable
            dt = EjecutaConsulta(cmd)
            If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
                Return dt
            End If
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try
    End Function
    Public Shared Function fn_BolsaDeEmpleo_Add(ByVal Titulo As String, ByVal Ciudad As String, ByVal Sueldo As String, ByVal StatusContratacion As String, ByVal Detalle As String) As Boolean

        'Aquí se Guardan los vacantes 

        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim cont As Integer = 0
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)

        Try

            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Add_vacante")
            Cn_Datos.Crea_Parametro(Cmd, "@Titulo", SqlDbType.VarChar, Titulo)
            Cn_Datos.Crea_Parametro(Cmd, "@Estado", SqlDbType.VarChar, Ciudad)
            Cn_Datos.Crea_Parametro(Cmd, "@sueldo", SqlDbType.VarChar, Sueldo)
            Cn_Datos.Crea_Parametro(Cmd, "@StatusDeContratacion", SqlDbType.VarChar, StatusContratacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Detalle", SqlDbType.VarChar, Detalle)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, "A")
            Cn_Datos.Crea_Parametro(Cmd, "@UsuarioRigistra", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Socursal", SqlDbType.Int, SucursalClave)

            Cn_Datos.EjecutarNonQueryT(Cmd)
            lc_Transaccion.Commit()

            Return True

        Catch ex As Exception
            lc_Transaccion.Rollback()
            TrataEx(ex)
            Return False
        End Try


    End Function


    Public Shared Function fn_Postulados_ObtenValores(ByVal lsv As cp_Listview) As Boolean
        'Aqui se obtienen todas las REFERENCIAS de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProspectosPostulacion_Read", CommandType.StoredProcedure, Crea_Conexion(Cnx_Central))

        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalClave)

        lsv.Actualizar(Cmd, "Id_Empleo")
        'lsv.Columns(0).Width = 0
        'lsv.Columns(1).Width = 0
        'lsv.Columns(15).Width = 0
        'lsv.Columns(16).Width = 0
        'lsv.Columns(7).TextAlign = HorizontalAlignment.Right
        'lsv.Columns(8).TextAlign = HorizontalAlignment.Right
        lsv.Columns(10).Width = 700
        'lsv.Columns(12).TextAlign = HorizontalAlignment.Right
        Cn_Datos.EjecutarNonQuery(Cmd)
        Return True
        Try
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ConsultaSucursales(ByVal Clave_Sucursal As String) As DataTable
        'consulta el catalogo de Sucursales
        Dim Dt_Datos As DataTable
        Dim cmd As SqlClient.SqlCommand = Crea_Comando("Cat_Sucursales_Get2", CommandType.StoredProcedure, Crea_Conexion(Cnx_Sucursal))
        Crea_Parametro(cmd, "@Clave_Sucursal", SqlDbType.VarChar, Clave_Sucursal)

        Try
            Dt_Datos = Cn_Datos.EjecutaConsulta(cmd)
            Return Dt_Datos
        Catch ex As Exception
            TrataEx(ex)
            Return Nothing
        End Try

    End Function

    Public Shared Function Fn_SuscursalesPropias_Combo() As DataTable
        'consulta las Sucursales Propias de la Base de Datos Central
        Dim Dt As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("SucursalesPropias_Get", CommandType.StoredProcedure, Cnn)
        Try
            Dt = EjecutaConsulta(Cmd)
            Return Dt
        Catch ex As Exception
            TrataEx(ex, True)
            Return Nothing
        End Try
    End Function

    Public Shared Function fn_ParametrosPDF_Read(ByRef Id_Prospecto As Integer) As DataTable
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProspectosPostulacionPDF_Read", CommandType.StoredProcedure, Crea_Conexion(Cnx_Central))
        'Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_ProspectosPostulacionPDF_Read", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Prospecto", SqlDbType.Int, Id_Prospecto)
        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
        Cmd.Dispose()
        Return Tbl
    End Function




    Public Shared Function fn_Vacantes_ObtenValores(ByVal lsv As cp_Listview) As Boolean
        'Aqui se obtienen todas las REFERENCIAS de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Get_Vacantes_Read", CommandType.StoredProcedure, Crea_Conexion(Cnx_Central))
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Socursal", SqlDbType.Int, SucursalClave)

        lsv.Actualizar(Cmd, "Id_Empleo")
        'lsv.Columns(0).Width = 0
        'lsv.Columns(1).Width = 0
        'lsv.Columns(15).Width = 0
        'lsv.Columns(16).Width = 0
        'lsv.Columns(7).TextAlign = HorizontalAlignment.Right
        'lsv.Columns(8).TextAlign = HorizontalAlignment.Right
        'lsv.Columns(11).TextAlign = HorizontalAlignment.Right
        'lsv.Columns(12).TextAlign = HorizontalAlignment.Right
        Cn_Datos.EjecutarNonQuery(Cmd)
        Return True
        Try
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_vacante_Actualizar(ByVal Id_Empleo As Integer, ByVal Titulo As String, ByVal Estado As String, ByVal sueldo As String, ByVal StatusDeContratacion As String, ByVal Detalle As String, ByVal Status As String) As Boolean
        'Aquí se actualizan los Datos Escolares de un empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim cont As Integer = 0
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Update_vacante")


            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleo", SqlDbType.Int, Id_Empleo)
            Cn_Datos.Crea_Parametro(Cmd, "@Titulo", SqlDbType.VarChar, Titulo)
            Cn_Datos.Crea_Parametro(Cmd, "@Estado", SqlDbType.VarChar, Estado)
            Cn_Datos.Crea_Parametro(Cmd, "@sueldo", SqlDbType.VarChar, sueldo)
            Cn_Datos.Crea_Parametro(Cmd, "@StatusDeContratacion", SqlDbType.VarChar, StatusDeContratacion)
            Cn_Datos.Crea_Parametro(Cmd, "@Detalle", SqlDbType.VarChar, Detalle)
            'Cn_Datos.Crea_Parametro(Cmd, -@ConocimientosTecnicos"@Promedio", SqlDbType.Money, Promedio)
            Cn_Datos.Crea_Parametro(Cmd, "@Status", SqlDbType.VarChar, Status)


            Cn_Datos.EjecutarNonQueryT(Cmd)
            lc_Transaccion.Commit()
            Return True
        Catch ex As Exception
            lc_Transaccion.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function


    Public Shared Function fn_ValidarProspeto(ByVal Id_Prospecto As Integer, ByVal Comentarios As String, ByVal Apto As String) As Boolean
        'Aquí se actualizan los Datos Escolares de un empleado seleccionado
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_Conexion(Cnx_Central)
        Dim lc_Transaccion As SqlClient.SqlTransaction
        Dim Cmd As SqlClient.SqlCommand
        Dim cont As Integer = 0
        lc_Transaccion = Cn_Datos.crear_Trans(Cnn)


        Try
            Cmd = Cn_Datos.Crea_ComandoT(Cnn, lc_Transaccion, CommandType.StoredProcedure, "Cat_Prospectos_Update")


            Cn_Datos.Crea_Parametro(Cmd, "@Id_Prospecto", SqlDbType.Int, Id_Prospecto)
            Cn_Datos.Crea_Parametro(Cmd, "@Apto", SqlDbType.VarChar, Apto)
            Cn_Datos.Crea_Parametro(Cmd, "@Comentarios", SqlDbType.VarChar, Comentarios)



            Cn_Datos.EjecutarNonQueryT(Cmd)
            lc_Transaccion.Commit()
            Return True
        Catch ex As Exception
            lc_Transaccion.Rollback()
            TrataEx(ex)
            Return False
        End Try
    End Function

    Public Shared Function fn_ReporteSSP(Tipo As Integer, Registro As Integer, Cartilla As Integer) As DataTable
        Dim tbl As New DataTable
        'Aqui se obtienen todos los DATOS FAMILIARES de un Empleado en particular
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD

        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Reporte_SSP", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Tipo", SqlDbType.Int, Tipo)
        Cn_Datos.Crea_Parametro(Cmd, "@Registro", SqlDbType.Int, Registro)
        Cn_Datos.Crea_Parametro(Cmd, "@Cartilla", SqlDbType.Int, Cartilla)

        Try
            tbl = Cn_Datos.EjecutaConsulta(Cmd)
        Catch ex As Exception
            TrataEx(ex)
        End Try
        Return tbl
    End Function

    'JGMC - 2023.11.27
#Region "CapturaHuellaProspecto"
    Public Shared Function fn_Add_HuellasProspecto(Clave_Prospectos As Integer, ByVal pulgar As Integer, ByVal Dr_huellas As DataRow) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("AddHuellasProspectos", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@IdEmpleadoP", SqlDbType.Int, Clave_Prospectos)
        Crea_Parametro(com, "@Pulgar", SqlDbType.Int, pulgar)
        Crea_Parametro(com, "@imagen", SqlDbType.VarChar, ConvertToBase64(Dr_huellas("Huella_ImagenB")))


        Try
            'Leer de SQL
            EjecutarNonQuery(com)
            resp = True
        Catch ex As Exception

        End Try
        Return resp
    End Function
    Public Shared Function fn_Del_HuellasProspecto(Clave_Prospectos As String, ByVal pulgar As Integer) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("DeleteHuellasProspectos", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Clave_Prospecto", SqlDbType.VarChar, Clave_Prospectos)
        Crea_Parametro(com, "@Pulgar", SqlDbType.Int, pulgar)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function
    Public Shared Function fn_Get_HuellasProspecto(ByVal Clave As Integer, ByVal Filter As Integer) As cls_Huellas
        Dim _huellas As New cls_Huellas
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("getHuellasProspecto", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.Int, Clave)
        Cn_Datos.Crea_Parametro(Cmd, "@filter", SqlDbType.Int, Filter)

        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            If dt.Rows.Count > 0 Then
                For Each d As DataRow In dt.Rows

                    With _huellas
                        .HuellaD = IIf(d("PulgarD") IsNot DBNull.Value, d("PulgarD"), Nothing)
                        .HuellaI = IIf(d("PulgarI") IsNot DBNull.Value, d("PulgarI"), Nothing)
                    End With

                Next
            Else
                _huellas = Nothing
            End If

        Catch ex As Exception
            TrataEx(ex)

        End Try

        Return _huellas
    End Function
    Public Shared Function ConvertToBase64(img As Byte()) As String
        Dim data As Byte()
        Using ms As New MemoryStream(img, 0, img.Length)
            data = ms.ToArray()
        End Using

        Return "data:image/jpg;base64," + Convert.ToBase64String(data)

    End Function
    Public Shared Function Base64ToImage(ByVal base64String As String) As Image
        Dim base64 = base64String.Replace("data:image/jpg;base64,", "")
        Dim imageBytes As Byte() = Convert.FromBase64String(base64)

        Using ms = New MemoryStream(imageBytes, 0, imageBytes.Length)
            Dim image As Image = Image.FromStream(ms, True)
            Return image
        End Using
    End Function
#End Region

#Region "ReferenciasLaborales"

    Public Shared Function fn_Consulta_ReferenciaLaboral(ByVal Id_EmpleadoPLaborales As String) As DataRow
        Dim dt As DataTable = Nothing
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_InvestigacionLaboral_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoLaborales", SqlDbType.Int, Id_EmpleadoPLaborales)

        dt = Cn_Datos.EjecutaConsulta(Cmd)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

        Try
        Catch ex As Exception
            TrataEx(ex)

        End Try
    End Function

    Public Shared Function fn_Consulta_ReferenciaLaboralP(ByVal Id_EmpleadoPLaborales As String) As DataRow
        Dim dt As DataTable = Nothing
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_InvestigacionLaboral_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id_EmpleadoPLaborales)

        dt = Cn_Datos.EjecutaConsulta(Cmd)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

        Try
        Catch ex As Exception
            TrataEx(ex)

        End Try
    End Function

    Public Shared Function fn_GuardarReferenciaLaboral(Id_EmpleadoLaborales As Integer, Id_Empleado As Integer, Desempeño As String, Conducta As String, Puntualidad As String,
                                                     Honestidad As String, Actitud As String, Asistencia As String, Disponibilidad As String, Motivo_Salida As Integer,
                                                      Demando As String, PertenecioSindicato As String, Cual As String, FueDelegadoSindical As String,
                                                      Recomendable As String, Porque As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_Empleados_InvestigacionLaboral_Add", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoLaborales", SqlDbType.Int, Id_EmpleadoLaborales)
        Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@Desempeño", SqlDbType.VarChar, Desempeño)
        Crea_Parametro(com, "@Conducta", SqlDbType.VarChar, Conducta)
        Crea_Parametro(com, "@Puntualidad", SqlDbType.VarChar, Puntualidad)
        Crea_Parametro(com, "@Honestidad", SqlDbType.VarChar, Honestidad)
        Crea_Parametro(com, "@Actitud", SqlDbType.VarChar, Actitud)
        Crea_Parametro(com, "@Asistencia", SqlDbType.VarChar, Asistencia)
        Crea_Parametro(com, "@Disponibilidad", SqlDbType.VarChar, Disponibilidad)
        Crea_Parametro(com, "@Motivo_Salida", SqlDbType.Int, Motivo_Salida)
        Crea_Parametro(com, "@Demando", SqlDbType.VarChar, Demando)
        Crea_Parametro(com, "@PertenecioSindicato", SqlDbType.VarChar, PertenecioSindicato)
        Crea_Parametro(com, "@Cual", SqlDbType.VarChar, Cual)
        Crea_Parametro(com, "@FueDelegadoSindical", SqlDbType.VarChar, FueDelegadoSindical)
        Crea_Parametro(com, "@Recomendable", SqlDbType.VarChar, Recomendable)
        Crea_Parametro(com, "@Porque", SqlDbType.VarChar, Porque)


        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_GuardarReferenciaLaboralP(Id_EmpleadoPLaborales As Integer, Id_EmpleadoP As Integer, Desempeño As String, Conducta As String, Puntualidad As String,
                                                     Honestidad As String, Actitud As String, Asistencia As String, Disponibilidad As String, Motivo_Salida As Integer,
                                                      Demando As String, PertenecioSindicato As String, Cual As String, FueDelegadoSindical As String,
                                                      Recomendable As String, Porque As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosP_InvestigacionLaboral_Add", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id_EmpleadoPLaborales)
        Crea_Parametro(com, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Crea_Parametro(com, "@Desempeño", SqlDbType.VarChar, Desempeño)
        Crea_Parametro(com, "@Conducta", SqlDbType.VarChar, Conducta)
        Crea_Parametro(com, "@Puntualidad", SqlDbType.VarChar, Puntualidad)
        Crea_Parametro(com, "@Honestidad", SqlDbType.VarChar, Honestidad)
        Crea_Parametro(com, "@Actitud", SqlDbType.VarChar, Actitud)
        Crea_Parametro(com, "@Asistencia", SqlDbType.VarChar, Asistencia)
        Crea_Parametro(com, "@Disponibilidad", SqlDbType.VarChar, Disponibilidad)
        Crea_Parametro(com, "@Motivo_Salida", SqlDbType.Int, Motivo_Salida)
        Crea_Parametro(com, "@Demando", SqlDbType.VarChar, Demando)
        Crea_Parametro(com, "@PertenecioSindicato", SqlDbType.VarChar, PertenecioSindicato)
        Crea_Parametro(com, "@Cual", SqlDbType.VarChar, Cual)
        Crea_Parametro(com, "@FueDelegadoSindical", SqlDbType.VarChar, FueDelegadoSindical)
        Crea_Parametro(com, "@Recomendable", SqlDbType.VarChar, Recomendable)
        Crea_Parametro(com, "@Porque", SqlDbType.VarChar, Porque)


        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_ActualizarReferenciaLaboral(Id_EmpleadoLaborales As Integer, Id_Empleado As Integer, Desempeño As String, Conducta As String, Puntualidad As String,
                                                     Honestidad As String, Actitud As String, Asistencia As String, Disponibilidad As String, Motivo_Salida As Integer,
                                                      Demando As String, PertenecioSindicato As String, Cual As String, FueDelegadoSindical As String,
                                                      Recomendable As String, Porque As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_Empleados_InvestigacionLaboral_Upd", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id_EmpleadoLaborales)
        Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@Desempeño", SqlDbType.VarChar, Desempeño)
        Crea_Parametro(com, "@Conducta", SqlDbType.VarChar, Conducta)
        Crea_Parametro(com, "@Puntualidad", SqlDbType.VarChar, Puntualidad)
        Crea_Parametro(com, "@Honestidad", SqlDbType.VarChar, Honestidad)
        Crea_Parametro(com, "@Actitud", SqlDbType.VarChar, Actitud)
        Crea_Parametro(com, "@Asistencia", SqlDbType.VarChar, Asistencia)
        Crea_Parametro(com, "@Disponibilidad", SqlDbType.VarChar, Disponibilidad)
        Crea_Parametro(com, "@Motivo_Salida", SqlDbType.Int, Motivo_Salida)
        Crea_Parametro(com, "@Demando", SqlDbType.VarChar, Demando)
        Crea_Parametro(com, "@PertenecioSindicato", SqlDbType.VarChar, PertenecioSindicato)
        Crea_Parametro(com, "@Cual", SqlDbType.VarChar, Cual)
        Crea_Parametro(com, "@FueDelegadoSindical", SqlDbType.VarChar, FueDelegadoSindical)
        Crea_Parametro(com, "@Recomendable", SqlDbType.VarChar, Recomendable)
        Crea_Parametro(com, "@Porque", SqlDbType.VarChar, Porque)


        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_ActualizarReferenciaLaboralP(Id_EmpleadoLaborales As Integer, Id_Empleado As Integer, Desempeño As String, Conducta As String, Puntualidad As String,
                                                    Honestidad As String, Actitud As String, Asistencia As String, Disponibilidad As String, Motivo_Salida As Integer,
                                                     Demando As String, PertenecioSindicato As String, Cual As String, FueDelegadoSindical As String,
                                                     Recomendable As String, Porque As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadosP_InvestigacionLaboral_Upd", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoPLaborales", SqlDbType.Int, Id_EmpleadoLaborales)
        Crea_Parametro(com, "@Id_EmpleadoP", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@Desempeño", SqlDbType.VarChar, Desempeño)
        Crea_Parametro(com, "@Conducta", SqlDbType.VarChar, Conducta)
        Crea_Parametro(com, "@Puntualidad", SqlDbType.VarChar, Puntualidad)
        Crea_Parametro(com, "@Honestidad", SqlDbType.VarChar, Honestidad)
        Crea_Parametro(com, "@Actitud", SqlDbType.VarChar, Actitud)
        Crea_Parametro(com, "@Asistencia", SqlDbType.VarChar, Asistencia)
        Crea_Parametro(com, "@Disponibilidad", SqlDbType.VarChar, Disponibilidad)
        Crea_Parametro(com, "@Motivo_Salida", SqlDbType.Int, Motivo_Salida)
        Crea_Parametro(com, "@Demando", SqlDbType.VarChar, Demando)
        Crea_Parametro(com, "@PertenecioSindicato", SqlDbType.VarChar, PertenecioSindicato)
        Crea_Parametro(com, "@Cual", SqlDbType.VarChar, Cual)
        Crea_Parametro(com, "@FueDelegadoSindical", SqlDbType.VarChar, FueDelegadoSindical)
        Crea_Parametro(com, "@Recomendable", SqlDbType.VarChar, Recomendable)
        Crea_Parametro(com, "@Porque", SqlDbType.VarChar, Porque)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    'referencias personales
    Public Shared Function fn_Consulta_ReferenciaPersonal(ByVal Id_EmpleadoReferencia As String) As DataRow
        Dim dt As DataTable = Nothing
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_Empleados_InvestigacionPersonal_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoReferencia", SqlDbType.Int, Id_EmpleadoReferencia)

        dt = Cn_Datos.EjecutaConsulta(Cmd)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

        Try
        Catch ex As Exception
            TrataEx(ex)

        End Try
    End Function

    Public Shared Function fn_Consulta_ReferenciaPersonalP(ByVal Id_EmpleadoPReferencia As String) As DataRow
        Dim dt As DataTable = Nothing
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_EmpleadosP_InvestigacionPersonal_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoPReferencia", SqlDbType.Int, Id_EmpleadoPReferencia)

        dt = Cn_Datos.EjecutaConsulta(Cmd)

        If dt IsNot Nothing AndAlso dt.Rows.Count > 0 Then
            Return dt.Rows(0)
        Else
            Return Nothing
        End If

        Try
        Catch ex As Exception
            TrataEx(ex)

        End Try
    End Function

    Public Shared Function fn_GuardarReferenciaPersonal(Id_EmpleadoReferencia As Integer, Id_Empleado As Integer, TiempoConocerlo As Decimal, ConfirmaDomicilio As String,
            ConsideraAlCandidato As Integer, RelacionFamiliar As String, ConocimientoEmpleosCandidato As String, Recomendado As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_Empleado_InvestigacionPersonal_Add", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoReferencia", SqlDbType.Int, Id_EmpleadoReferencia)
        Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@TiempoConocerlo", SqlDbType.Decimal, TiempoConocerlo)
        Crea_Parametro(com, "@ConfirmaDomicilio", SqlDbType.VarChar, ConfirmaDomicilio)
        Crea_Parametro(com, "@ConsideraAlCandidato", SqlDbType.Int, ConsideraAlCandidato)
        Crea_Parametro(com, "@RelacionFamiliar", SqlDbType.VarChar, RelacionFamiliar)
        Crea_Parametro(com, "@ConocimientoEmpleosCandidato", SqlDbType.VarChar, ConocimientoEmpleosCandidato)
        Crea_Parametro(com, "@Recomendado", SqlDbType.VarChar, Recomendado)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_GuardarReferenciaPersonalP(Id_EmpleadoPReferencia As Integer, Id_EmpleadoP As Integer, TiempoConocerlo As Decimal, ConfirmaDomicilio As String,
        ConsideraAlCandidato As Integer, RelacionFamiliar As String, ConocimientoEmpleosCandidato As String, Recomendado As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadoP_InvestigacionPersonal_Add", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoPReferencia", SqlDbType.Int, Id_EmpleadoPReferencia)
        Crea_Parametro(com, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Crea_Parametro(com, "@TiempoConocerlo", SqlDbType.Decimal, TiempoConocerlo)
        Crea_Parametro(com, "@ConfirmaDomicilio", SqlDbType.VarChar, ConfirmaDomicilio)
        Crea_Parametro(com, "@ConsideraAlCandidato", SqlDbType.Int, ConsideraAlCandidato)
        Crea_Parametro(com, "@RelacionFamiliar", SqlDbType.VarChar, RelacionFamiliar)
        Crea_Parametro(com, "@ConocimientoEmpleosCandidato", SqlDbType.VarChar, ConocimientoEmpleosCandidato)
        Crea_Parametro(com, "@Recomendado", SqlDbType.VarChar, Recomendado)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_ActualizarReferenciaPersonal(Id_EmpleadoReferencia As Integer, Id_Empleado As Integer, TiempoConocerlo As Decimal, ConfirmaDomicilio As String,
        ConsideraAlCandidato As Integer, RelacionFamiliar As String, ConocimientoEmpleosCandidato As String, Recomendado As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_Empleado_InvestigacionPersonal_Upd", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoReferencia", SqlDbType.Int, Id_EmpleadoReferencia)
        Crea_Parametro(com, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Crea_Parametro(com, "@TiempoConocerlo", SqlDbType.Decimal, TiempoConocerlo)
        Crea_Parametro(com, "@ConfirmaDomicilio", SqlDbType.VarChar, ConfirmaDomicilio)
        Crea_Parametro(com, "@ConsideraAlCandidato", SqlDbType.Int, ConsideraAlCandidato)
        Crea_Parametro(com, "@RelacionFamiliar", SqlDbType.VarChar, RelacionFamiliar)
        Crea_Parametro(com, "@ConocimientoEmpleosCandidato", SqlDbType.VarChar, ConocimientoEmpleosCandidato)
        Crea_Parametro(com, "@Recomendado", SqlDbType.VarChar, Recomendado)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function

    Public Shared Function fn_ActualizarReferenciaPersonalP(Id_EmpleadoPReferencia As Integer, Id_EmpleadoP As Integer, TiempoConocerlo As Decimal, ConfirmaDomicilio As String,
      ConsideraAlCandidato As Integer, RelacionFamiliar As String, ConocimientoEmpleosCandidato As String, Recomendado As String) As Boolean
        Dim resp As Boolean = False
        Dim con As SqlClient.SqlConnection = Crea_ConexionSTD()
        Dim com As SqlClient.SqlCommand = Crea_Comando("Cat_EmpleadoP_InvestigacionPersonal_Upd", CommandType.StoredProcedure, con)
        Crea_Parametro(com, "@Id_EmpleadoPReferencia", SqlDbType.Int, Id_EmpleadoPReferencia)
        Crea_Parametro(com, "@Id_EmpleadoP", SqlDbType.Int, Id_EmpleadoP)
        Crea_Parametro(com, "@TiempoConocerlo", SqlDbType.Decimal, TiempoConocerlo)
        Crea_Parametro(com, "@ConfirmaDomicilio", SqlDbType.VarChar, ConfirmaDomicilio)
        Crea_Parametro(com, "@ConsideraAlCandidato", SqlDbType.Int, ConsideraAlCandidato)
        Crea_Parametro(com, "@RelacionFamiliar", SqlDbType.VarChar, RelacionFamiliar)
        Crea_Parametro(com, "@ConocimientoEmpleosCandidato", SqlDbType.VarChar, ConocimientoEmpleosCandidato)
        Crea_Parametro(com, "@Recomendado", SqlDbType.VarChar, Recomendado)

        Try
            'Leer de SQL
            Dim upd As Integer = EjecutarNonQuery(com)
            If upd > 0 Then
                resp = True
            End If

        Catch ex As Exception

        End Try
        Return resp
    End Function


#End Region



#Region "Documentos/formatos "

    'Public Shared Function fn_DocumentosContratos(ByVal Id_Empleado As String, lsv As cp_Listview) As Boolean
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Get_DocumentosContratos", CommandType.StoredProcedure, Cnn)
    '    Cn_Datos.Crea_Parametro(Cmd, "@clave", SqlDbType.VarChar, Id_Empleado)

    '    lsv.Actualizar(Cmd, "Id_EmpleadoP")
    '    lsv.Columns(0).Width = 90
    '    lsv.Columns(1).Width = 0
    '    lsv.Columns(2).Width = 90
    '    lsv.Columns(3).Width = 90
    '    lsv.Columns(4).Width = 90
    '    lsv.Columns(5).Width = 90
    '    lsv.Columns(6).Width = 90
    '    lsv.Columns(7).Width = 90
    '    lsv.Columns(8).Width = 0
    '    lsv.Columns(9).Width = 0
    '    lsv.Columns(10).Width = 90
    '    lsv.Columns(11).Width = 0
    '    lsv.Columns(12).Width = 0
    '    lsv.Columns(13).Width = 0
    '    lsv.Columns(14).Width = 0
    '    lsv.Columns(15).Width = 0
    '    lsv.Columns(16).Width = 0
    '    lsv.Columns(17).Width = 0
    '    lsv.Columns(18).Width = 0
    '    lsv.Columns(19).Width = 0


    '    Cn_Datos.EjecutarNonQuery(Cmd)
    '    Return True
    '    Try
    '    Catch ex As Exception
    '        TrataEx(ex)
    '        Return False
    '    End Try
    'End Function
    Public Shared Function fn_DocumentosContratosEmp(ByVal Id As Integer, ByVal filter As Integer, lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Nothing
        'filter 1-Prospectos, 2-Empleados
        If filter = 1 Then
            Cmd = Cn_Datos.Crea_Comando("Get_DocumentosContratos", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id", SqlDbType.Int, Id)
        Else
            Cmd = Cn_Datos.Crea_Comando("Get_DocumentosContratosEmp", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id", SqlDbType.Int, Id)
        End If

        'Cn_Datos.Crea_Parametro(Cmd, "@filter", SqlDbType.Int, Id)
        lsv.Actualizar(Cmd, "Id")

        lsv.Columns(10).Width = 0
        lsv.Columns(11).Width = 0
        lsv.Columns(12).Width = 0
        lsv.Columns(13).Width = 0
        lsv.Columns(14).Width = 0
        lsv.Columns(15).Width = 0
        lsv.Columns(16).Width = 0
        lsv.Columns(17).Width = 0
        lsv.Columns(18).Width = 0
        lsv.Columns(19).Width = 0
        Cn_Datos.EjecutarNonQuery(Cmd)

        Return True
        Try
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_GetFirmasTestigoReprecentante(ByVal Id_Empleado As String, ByVal filter As Integer) As List(Of cls_FirmasRepTes)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("getFirmasTestigoReprecentante", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@filter", SqlDbType.Int, filter)
        Dim list As New List(Of cls_FirmasRepTes)
        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            For Each d As DataRow In dt.Rows
                Dim _firma As New cls_FirmasRepTes
                With _firma
                    .Nombre = d("Nombre")
                    .Firma = ConvertToBase64(d("Firma"))
                    .Posicion = d("Rol")
                End With
                list.Add(_firma)
            Next

        Catch ex As Exception
            TrataEx(ex)

        End Try
        Return list
    End Function
#End Region

#Region "Examen Barsit"
    'Public Shared Function fn_Consulta_Prospecto(ByVal Id_Empleado As String) As DataTable
    '    Dim dt As DataTable = Nothing
    '    Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
    '    Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Get_Prospecto", CommandType.StoredProcedure, Cnn)
    '    Cn_Datos.Crea_Parametro(Cmd, "@clave", SqlDbType.VarChar, Id_Empleado)

    '    dt = Cn_Datos.EjecutaConsulta(Cmd)
    '    Return dt
    '    Try
    '    Catch ex As Exception
    '        TrataEx(ex)

    '    End Try
    'End Function
    Public Shared Function fn_ResultadoExamenBarsit(ByVal Id_Empleado As String, lsv As cp_Listview) As Boolean
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("EXAM_BARSIT_RESUELTO", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.VarChar, Id_Empleado)

        lsv.Actualizar(Cmd, "Id_Examen")
        lsv.Columns(0).Width = 90
        lsv.Columns(1).Width = 90
        lsv.Columns(2).Width = 90
        lsv.Columns(3).Width = 200





        Cn_Datos.EjecutarNonQuery(Cmd)
        Return True
        Try
        Catch ex As Exception
            TrataEx(ex)
            Return False
        End Try
    End Function
    Public Shared Function fn_RespuestasExamen(ByVal Id_Empleado As Integer, ByVal filter As Integer) As List(Of RespuestasExamen)
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("EXAM_BARSIT_RESULTADO", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.Int, Id_Empleado)
        Cn_Datos.Crea_Parametro(Cmd, "@filter", SqlDbType.Int, filter)
        Dim list As New List(Of RespuestasExamen)
        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            For Each d As DataRow In dt.Rows
                Dim _respuestas As New RespuestasExamen
                With _respuestas
                    .IdPregunta = d("Id_Pregunta")
                    .Pregunta = d("Pregunta")
                    .Respuesta = d("Respuesta")
                    .EsCorrecta = IIf(Convert.ToBoolean(d("RespuestaCorrecta")) = True, "Correcta", "Incorrecta")
                    .RespuestaCorrecta = d("RC")
                End With
                list.Add(_respuestas)
            Next

        Catch ex As Exception
            TrataEx(ex)

        End Try
        Return list
    End Function
#End Region
#Region "Cuestionario Medico"

    Public Shared Function fn_CM_Cuestionario(ByVal Id_Prospecto As Integer, ByVal filter As Integer) As CuestionarioMedico
        Dim _cuestionario As New CuestionarioMedico
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CuestionarioMedico_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id", SqlDbType.VarChar, Id_Prospecto)
        Cn_Datos.Crea_Parametro(Cmd, "@filter", SqlDbType.VarChar, filter)

        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then

                With _cuestionario
                    .Antidoping = dt.Rows(0)("Antidoping")
                    .IsSigned = dt.Rows(0)("Firmado")
                    .ServicioMedico = dt.Rows(0)("ServicioMedico")
                    .ServicioMedicoAprobacion = dt.Rows(0)("ServicioMedicoAprobacion")
                    .Observaciones = dt.Rows(0)("Observaciones")
                    .FechaRegistro = dt.Rows(0)("Fecha_Registro")
                    .IdAntecedemteMedico = dt.Rows(0)("Id_AntecedenteMP")
                    .IdAntecedemteGinecologico = dt.Rows(0)("Id_AntecedenteGine")
                End With

            End If

        Catch ex As Exception
            TrataEx(ex)

        End Try
        Return _cuestionario
    End Function

    Public Shared Function fn_CM_InformacionPersonal(ByVal Id As Integer, ByVal filter As Integer) As InformPersonal
        Dim _informacion As New InformPersonal
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Nothing
        If filter = 1 Then
            Cmd = Cn_Datos.Crea_Comando("Cat_EmpleadosP_CM_InformProsp_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_EmpleadoP", SqlDbType.VarChar, Id)
        Else
            Cmd = Cn_Datos.Crea_Comando("Cat_Empleados_CM_InformEmp_Get", CommandType.StoredProcedure, Cnn)
            Cn_Datos.Crea_Parametro(Cmd, "@Id_Empleado", SqlDbType.VarChar, Id)
        End If


        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                Dim resultadobusquedalugarNaci As String = dt.Rows(0)("Lugar_Nacimiento").ToString()
                Dim lugarNaci As String() = resultadobusquedalugarNaci.Split(",")
                Dim resultadobusquedaestadociudad As String = fn_EstadoCiudadProspecto(1, Convert.ToInt32(dt.Rows(0)("Id_Ciudad")))
                Dim EstadoCiudad As String() = resultadobusquedaestadociudad.Split(",")
                With _informacion
                    .Id = Convert.ToInt32(dt.Rows(0)("Id"))
                    .Puesto = dt.Rows(0)("Puesto")
                    .Nombre = dt.Rows(0)("Nombre")
                    .Edad = Convert.ToInt32(dt.Rows(0)("Edad"))
                    .FechaNacimiento = dt.Rows(0)("Fecha_Nacimiento")
                    .Genero = dt.Rows(0)("Sexo")
                    .EstadoCivil = dt.Rows(0)("EstadoCivil")
                    .LugarNacimiento = lugarNaci(1)
                    .EstadoNacimiento = lugarNaci(0)
                    .Calle = dt.Rows(0)("Calle")
                    .Numero = dt.Rows(0)("Numero")
                    .Colonia = dt.Rows(0)("Colonia")
                    .Ciudad = EstadoCiudad(1)
                    .Cp = dt.Rows(0)("CP")
                    .Estado = EstadoCiudad(0)
                    .Telefono = dt.Rows(0)("Telefono")
                    .Celular = dt.Rows(0)("Telefono_Movil")
                    .NoHijos = dt.Rows(0)("Cantidad_Hijos")
                    .Complexion = dt.Rows(0)("Complexion")
                    .Peso = dt.Rows(0)("Peso")
                    .Altura = dt.Rows(0)("Estatura")
                End With

            End If

        Catch ex As Exception
            TrataEx(ex)

        End Try
        Return _informacion

    End Function
    Private Shared Function fn_EstadoCiudadProspecto(ByVal Pais As Integer, ByVal Ciudad As Integer) As String
        Dim data As String = ""
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_CiudadesPais_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Pais", SqlDbType.VarChar, Pais)
        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
            Dim filteredRows = dt.Select($"Id_Ciudad = '{Ciudad}'")
            data = filteredRows(0)("Nombre")
        Catch ex As Exception

        End Try
        Return data
    End Function

    Public Shared Function fn_CM_AntecedenteMedico(ByVal Id_AntecedenteMP As Integer) As AntecedentesMedicos
        Dim _antecedente As New AntecedentesMedicos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AntecedentesMedicosPersonales_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_AntecedenteMP", SqlDbType.VarChar, Id_AntecedenteMP)
        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                With _antecedente
                    .UsaLentesoPupilentes = gBit(dt.Rows(0)("UsoLentesORPup"))
                    .Desdecuando = dt.Rows(0)("ULP_Desde")
                    .RespuestaLentesPupilentes = dt.Rows(0)("ULP_Respuesta")
                    .OpcionesAntecedentesFamiliares = gList(dt.Rows(0)("AntecedentesFamiliares"))
                    .EnfermedadCongenita = gBit(dt.Rows(0)("EnfermedadCongenORHered"))
                    .DeformidadCongenita = gBit(dt.Rows(0)("DeformidadCongenita"))
                    .EnfermedadesInfantiles = gBit(dt.Rows(0)("EnfermedadesInfantiles"))
                    .OpcionesEnfermedadesInfantiles = gList(dt.Rows(0)("EI_Respuesta"))
                    .OtraEnfermedadInfantil = dt.Rows(0)("EI_Otras")
                    .Alergias = gBit(dt.Rows(0)("Alergias"))
                    .OpcionesAlergias = gList(dt.Rows(0)("All_Respuesta"))
                    .UsaLentesContacto = gBit(dt.Rows(0)("UsaLentesORLentesContac"))
                    .OpcionesUsaLentesContacto = gList(dt.Rows(0)("ULLC_Respuesta"))
                    .VeUstedBien = gBit(dt.Rows(0)("VeUstedBien"))
                    .OjoIzquierdo = gBit(dt.Rows(0)("OjoIzquierdo"))
                    .OjoDerecho = gBit(dt.Rows(0)("OjoDerecho"))
                    .CirugiaOcular = gBit(dt.Rows(0)("CirugiaOcular"))
                    .PorqueRealizoCirugiaOcular = dt.Rows(0)("CO_Por")
                    .FechaCirugia = dt.Rows(0)("CO_Fecha")
                    .EnfermedadOidos = gBit(dt.Rows(0)("EnfermedadEnOidos"))
                    .CualEnfermedadOidos = dt.Rows(0)("EO_Cual")
                    .EscuchaUstedBien = gBit(dt.Rows(0)("OyeBienUsted"))
                    .UsaAparatoAuditivo = gBit(dt.Rows(0)("UsaAparatoAuditivo"))
                    .DesdeCuandoUsaAparatoAuditivo = dt.Rows(0)("UAA_Desde")
                    .EnfermedadesDentales = gBit(dt.Rows(0)("EnfermedadDental"))
                    .OpcionesEnfermedadesDentales = gList(dt.Rows(0)("ED_Respuesta"))
                    .OpcionesEnfermedadesHormonales = gList(dt.Rows(0)("EnfermedadHormonal"))
                    .OtrasEnfermedadesHormonales = dt.Rows(0)("EH_Otras")
                    .EnfermedadesPulmonares = gBit(dt.Rows(0)("EnfermedadPulmones"))
                    .OpcionesEnfermedadesPulmonares = gList(dt.Rows(0)("EP_Respuesta"))
                    .OtrasEnfermedadesPulmonares = dt.Rows(0)("EP_Otras")
                    .EnfermadesCorazon = gBit(dt.Rows(0)("EnfermedadCorazon"))
                    .OpcionesEnfermedadesCorazon = gList(dt.Rows(0)("EC_Respuesta"))
                    .AlteracionPresionArterial = gBit(dt.Rows(0)("AlteracionArterial"))
                    .OpcionesAlteracionPresionArterial = gList(dt.Rows(0)("AA_Respuesta"))
                    .MedicamentosAlteracionPresionArterial = dt.Rows(0)("AA_Medicamentos")
                    .ControlMedicoAlteracionPresionArterial = gBit(dt.Rows(0)("AA_EstoyControlMedico"))
                    .OpcionescontrolMedicoAlteracionPresionArterial = gList(dt.Rows(0)("AA_CM_Respuesta"))
                    .EnfermedadDigestiva = gBit(dt.Rows(0)("EnfermedadesDigestivas"))
                    .OpcionEnfermedadesDigestivas = gList(dt.Rows(0)("EDG_Respuesta"))
                    .EnfermedadHigado = gBit(dt.Rows(0)("EnfermedadesHigado"))
                    .OpcionesEnfermedadesHigado = gList(dt.Rows(0)("EH_Respuesta"))
                    .DiabetesMellitus = gBit(dt.Rows(0)("DiabetesMellitus"))
                    .OpcionesDiabetesMelitus = gList(dt.Rows(0)("DM_Respuesta"))
                    .FechaUltimoExamenSangre = dt.Rows(0)("DM_FechaUltExamSangre")
                    .ControlMedicoDiabetesMelitus = gBit(dt.Rows(0)("DM_ControlMedicoDiabettes"))
                    .OpcionesControlMedicoDiabetes = gList(dt.Rows(0)("DM_CM_Respuesta"))
                    .EnfermedadColesterol = gBit(dt.Rows(0)("EnfermedadColesterol"))
                    .MedicamentosColesterol = dt.Rows(0)("ECO_Medicamentos")
                    .EnfermedadAcidoUrico = gBit(dt.Rows(0)("EnfermedadAcidoUrico"))
                    .MedicamentosAcidoUrico = dt.Rows(0)("EAU_Medicamentos")
                    .EnfermedadRinon = gBit(dt.Rows(0)("EnfermedadRiñon"))
                    .OpcionesRinones = gList(dt.Rows(0)("ER_Respuesta"))
                    .EnfermedadNeurologica = gBit(dt.Rows(0)("EnfermedadNeurologicas"))
                    .OpcionesEnfermedadNuerologicas = gList(dt.Rows(0)("EN_Respuesta"))
                    .EnfermedadesPsiquiatricas = gBit(dt.Rows(0)("EnfermedadPsiquiatrica"))
                    .OpcionesEnfermedadesPsiquiatricas = gList(dt.Rows(0)("EPS"))
                    .EnfermedadOsteoMuscular = gBit(dt.Rows(0)("EnfermedadOsteoMuscular"))
                    .OpcionesEnfermedadesOsteoMuscular = gList(dt.Rows(0)("EOM_Respuesta"))
                    .EnfermedadPiel = gBit(dt.Rows(0)("EnfermedadPiel"))
                    .EnfermedadUñas = gBit(dt.Rows(0)("EnfermedadUñas"))
                    .EnfermedadCabello = gBit(dt.Rows(0)("EnfermedadPelo"))
                    .EnfermedadesInfecciosas = gBit(dt.Rows(0)("EnfermedadesInfecciosas"))
                    .OpcionesEnfermedadesInfecciosas = gList(dt.Rows(0)("EIF_Respuesta"))
                    .AccidentesdeImportancia = gBit(dt.Rows(0)("AccidentesDeImportancia"))
                    .TranfusionDeSangre = gBit(dt.Rows(0)("TransfusionSangre"))
                    .IngresoHospital = gBit(dt.Rows(0)("IngresoHospital"))
                    .OpcionesIngresoHospital = gList(dt.Rows(0)("IH_Respuesta"))
                    .CirugiasRealizadas = dt.Rows(0)("CirugiasRealizada")
                    .TieneSecuela = gBit(dt.Rows(0)("TieneSecuela"))
                    .ImpedimentoFisicoPsicologico = gBit(dt.Rows(0)("TieneUstImpFisPsicoEmocinal"))
                    .EnfermedadCronica = gBit(dt.Rows(0)("TieneEfermedadCronica"))
                    .OpcionesEnfermedadCronica = gList(dt.Rows(0)("ECR_Respuesta"))
                    .OtraEnfermedadCronica = dt.Rows(0)("ECR_Otra")
                    .PadecidoCancerTumorMaligno = gBit(dt.Rows(0)("PadecidoCancerOrTumor"))
                    .TieneVarices = gBit(dt.Rows(0)("Varices"))
                    .Tabaco = dt.Rows(0)("Tabaco")
                    .FechaDejeFumar = dt.Rows(0)("DejeDeFumarHace")
                    .DiariamenteFumo = dt.Rows(0)("DiariamenteFumo")
                    .SemanalmenteFumo = dt.Rows(0)("SemanalmenteFumo")
                    .Alcohol = dt.Rows(0)("Alcohol")
                    .TipoBebida = dt.Rows(0)("TipoBebida")
                    .Drogas = dt.Rows(0)("Drogas")
                    .FechaDejeDrogas = dt.Rows(0)("DejeDeConsumir")
                    .TipoDrogras = dt.Rows(0)("TipoDroga")
                    .DeportesActividadFisica = dt.Rows(0)("Deportes")
                    .TipoEjercicio = dt.Rows(0)("TipoEjercicio")
                    .TiempoDedicado = dt.Rows(0)("TiempoDedicado")
                    .UsoMedicamentos = gBit(dt.Rows(0)("UsoMedicamentos"))
                    .OpcionesUsoMedicamentos = gList(dt.Rows(0)("UM_Respuesta"))
                    .NombreMedicamento = dt.Rows(0)("UM_NombreMedicamento")
                    .MedicamentoUsadoPara = dt.Rows(0)("UM_UsadoPara")
                    .HorasSuenoDia = dt.Rows(0)("HorasSueño")
                    .OtrosTrabajos = gBit(dt.Rows(0)("OtrosTrabajos"))
                    .DondeRealizaOtrosTrabajos = dt.Rows(0)("OT_Donde")
                    .QueHaceEnOtrosTrabajos = dt.Rows(0)("OT_QueHace")
                    .FechaDesdeQueRealizaOtrosTrabajos = dt.Rows(0)("OT_Desde")
                    .RealizaTareasDomesticas = gBit(dt.Rows(0)("RealizaTareasDomesticas"))
                End With
            End If



        Catch ex As Exception

        End Try

        Return _antecedente
    End Function

    Public Shared Function fn_CM_AntecedenteGinecologico(ByVal Id_AntecedenteGine As Integer) As AntecedentesGinecologicos
        Dim _antecedente As New AntecedentesGinecologicos
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AntecedentesMedicosGinecilogicos_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_AntecedenteGine", SqlDbType.VarChar, Id_AntecedenteGine)
        Try
            Dim dt As DataTable = Cn_Datos.EjecutaConsulta(Cmd)

            If dt.Rows.Count > 0 Then
                With _antecedente
                    .Embarazos = Convert.ToInt32(dt.Rows(0)("Embarazos"))
                    .Nacimientos = Convert.ToInt32(dt.Rows(0)("Partos"))
                    .Cesarias = Convert.ToInt32(dt.Rows(0)("Cesarias"))
                    .Abortos = Convert.ToInt32(dt.Rows(0)("Abortos"))
                    .FechasNacimientoHijos = dt.Rows(0)("FechasNacimientosHijos")
                    .IrregularidaddesMenstruales = gBit(dt.Rows(0)("IrregularidadesMestruales"))
                    .Infecciones = gBit(dt.Rows(0)("Infecciones"))
                    .Quistes = gBit(dt.Rows(0)("QuistesOREnfOvarios"))
                    .Esterilidad = gBit(dt.Rows(0)("Esterilidad"))
                    .Otrosproblemas = gBit(dt.Rows(0)("OtrosProblemas"))
                    .Cualesproblemas = dt.Rows(0)("OtrosProblemas_Desc")
                    .BolitaSeno = gBit(dt.Rows(0)("BultoORNoduloORBolita"))
                    .QuistesSenos = gBit(dt.Rows(0)("QuistesSenos"))
                    .Secrecion = gBit(dt.Rows(0)("Secrecion"))
                    .Cualesproblemaspecho = dt.Rows(0)("OtrosProblemasEnSenos_Desc")
                    .RevisionGinecologica = gBit(dt.Rows(0)("RevisionesGinecologicas"))
                    .UltimaFechaRevisionmedica = dt.Rows(0)("FechaUltimaRevision")
                    .Lugares = gList(dt.Rows(0)("Lugar"))
                    .UltimaFechaExamenDetecCancer = dt.Rows(0)("FechaUltExamDetCancer")
                    .RespuestaUltimaFechaExamenCancer = gList(dt.Rows(0)("FUEDC_Respuesta"))
                    .MetodoAnticonceptivo = gBit(dt.Rows(0)("UsaMetodoAnticonceptivo"))
                    .CualMetodoAnticonceptivo = dt.Rows(0)("cual")
                    .UltimaFechaMenstruacion = dt.Rows(0)("UltFechaMenstruacion")
                    .RespuestaUltimaFechaMenstruacion = gList(dt.Rows(0)("UFM_Respuesta"))
                    .EstaEmbarazada = gBit(dt.Rows(0)("EstaEmbarazada"))
                    .FechaParto = dt.Rows(0)("FechaParto")
                    .SospechaEmbarazo = gBit(dt.Rows(0)("SospechaEmbarazo"))

                End With
            End If


        Catch ex As Exception

        End Try

        Return _antecedente
    End Function

    Private Shared Function gBit(ByVal data As Boolean) As String
        If data Then
            Return "S"
        Else
            Return "N"
        End If
    End Function

    Private Shared Function gList(ByVal list As String) As List(Of ListaItems)

        Try
            Return JsonConvert.DeserializeObject(Of List(Of ListaItems))(list)
        Catch ex As Exception

        End Try

    End Function

#End Region

End Class
