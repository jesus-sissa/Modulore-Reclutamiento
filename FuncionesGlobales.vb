Imports System.Data.SqlClient
Imports System.Management
Imports System.Net
Imports System.Text
Imports Modulo_Reclutamiento.Cn_Datos

Public Class FuncionesGlobales

#Region "Globales"

    Public Enum ParametrosGlobales As Byte
        Puesto_JRU = 0
        Puesto_OPE = 1
        Puesto_CUS = 2
        Puesto_Ventas = 3
        Puesto_Sistemas = 4
        Puesto_Sproceso = 5
        Puesto_Cajero = 6
    End Enum

    Public Shared Function fn_ParametrosGlobales(ByVal Parametro As ParametrosGlobales) As Integer
        Dim cmd As SqlCommand = Crea_Comando("Cat_ParametrosG_Read", CommandType.StoredProcedure, Crea_ConexionSTD)

        Try
            Return EjecutaConsulta(cmd).Rows(0)(CByte(Parametro))
        Catch ex As Exception
            TrataEx(ex)
            Return 0
        End Try
    End Function

    Public Shared Sub MostrarVentana(ByVal Ventana As Form, Optional ByVal Maximizada As Boolean = True)
        For Each element As Form In frm_MENU.MdiChildren
            If element Is Ventana Then Exit Sub
            element.Close()
        Next
        If Maximizada Then
            Ventana.MdiParent = frm_MENU
            Ventana.Show()
            Ventana.WindowState = FormWindowState.Maximized
        Else
            Ventana.ShowDialog()
        End If

    End Sub

    'Public Shared Sub MsgBox(ByVal Mensaje As String)
    '    Global.Microsoft.VisualBasic.MsgBox(Mensaje, MsgBoxStyle.Critical, My.Application.Info.ProductName)
    'End Sub

    Public Shared Function fn_Menu_Progreso(ByVal Progreso As Byte) As Boolean
        'Aqui se actualiza la barra de progreso
        Try
            frm_MENU.prg_Barra.Value = Progreso
            Return True
        Catch
            Return False
        End Try
    End Function

    Public Shared Sub AgregarItem(ByVal Combo As Object, ByVal Value As String, ByVal Display As String)

        If Combo.DataSource Is Nothing Then
            Combo.DataSource = New DataTable
        End If
        Dim Tbl As DataTable = Combo.DataSource
        If Tbl.Columns.Count = 0 Then
            Tbl.Columns.Add("value")
            Tbl.Columns.Add("display")
        End If
        Combo.ValueMember = "value"
        Combo.DisplayMember = "display"
        Dim Row As DataRow = Tbl.NewRow
        Row("value") = Value
        Row("display") = Display
        Tbl.Rows.Add(Row)

    End Sub

    Public Shared Function ObtenPais() As Integer
        Dim Cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim Cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_PaisesSucursal_Get", CommandType.StoredProcedure, Cnn)
        Cn_Datos.Crea_Parametro(Cmd, "@Id_Sucursal", SqlDbType.Int, SucursalId)

        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(Cmd)
        If Tbl.Rows.Count = 0 Then
            Return 0
        Else
            Return Tbl.Rows(0).Item(0)
        End If

    End Function

    Public Shared Sub TrataEx(ByVal Ex As Exception, Optional ByVal Mostrar_Mensaje As Boolean = True)
        If TypeOf (Ex) Is System.Data.SqlClient.SqlException Then
            Dim SqlEx As System.Data.SqlClient.SqlException = CType(Ex, System.Data.SqlClient.SqlException)
            FuncionesGlobales.fn_GuardaError(SqlEx.Procedure, SqlEx.Number, SqlEx.Message, True)
        Else
            FuncionesGlobales.fn_GuardaError(Ex.StackTrace, 0, Ex.Message, True)
        End If
        If Mostrar_Mensaje Then
            MsgBox("No se ha podido realizar la accion consulte a su administrador.", MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End If
    End Sub

#End Region

    Public Enum Validar_Cadena
        Ninguno = 0
        Numeros_Enteros = 1
        Numeros_Decimales = 2
        Letras = 3
        LetrasYcaracteres = 4
        LetrasYnumeros = 5
        LetrasNumerosYCar = 6
        Porcentaje = 7
        DireccionIP = 8
    End Enum

    ''' <summary>
    ''' Sirve para llenar un combo con intervalos de minutos definidos
    ''' </summary>
    ''' <param name="Minutos">Es el numero de minutos que se van a avanzar con cada ciclo</param>
    ''' <param name="combo">es el combo que se va a llentar</param>

    Public Shared Sub LlenarMinutos(ByVal Minutos As Integer, ByVal combo As cp_cmb_Manual)
        Dim t As DateTime = #12:00:00 AM#

        While t <= #11:59:59 PM#
            combo.AgregarItem(combo.Items.Count, t.ToShortTimeString)
            t = t.AddMinutes(Minutos)
        End While

    End Sub

#Region "CONVIERTE IMPORTE A LETRAS"

    Public Shared Function fn_EnLetras(ByVal numero As String, Optional ByVal IDMoneda As Integer = 0) As String

        Dim BandBilion As Boolean
        Dim b, paso, cifra As Integer
        Dim expresion As String = ""
        Dim entero As String = ""
        Dim deci As String = ""
        Dim flag As String = ""
        Dim valor As String = ""
        Dim gOpcionMil As Boolean = False
        Dim Moneda As String

        flag = "N"

        '** AQUI REVISAMOS SI EL MONTO TIENE PARTE DECIMAL.
        For paso = 1 To Len(numero) 'DETERMINA CUANTOS CARACTERES TIENE LA CADENA
            If Mid(numero, paso, 1) = "." Or Mid(numero, paso, 1) = "," Then 'DEPENDIENDO DE LA REGIÓN
                flag = "S"
            Else
                If flag = "N" Then
                    entero = entero + Mid(numero, paso, 1) 'EXTAE LA PARTE ENTERA DEL NUMERO
                Else
                    deci = deci + Mid(numero, paso, 1) 'EXTRAE LA PARTE DECIMAL DEL NUMERO
                End If
            End If
        Next paso

        'DEFINIMOS VALOR EN LAS VARIABLES
        'CIFRA Y VALOR PARA USARLAS COMO
        'BANDERAS CONDICIONALES.

        cifra = Len(entero)

        Select Case cifra
            Case Is = 1
                valor = "UNIDAD" 'SIN USAR
            Case Is = 2
                valor = "DECENAS" 'SIN USAR
            Case Is = 3
                valor = "CENTENAS" 'SIN USAR
            Case Is = 4, 5, 6
                valor = "MILES" 'USADO
            Case Is = 7, 8, 9
                valor = "MILION" 'USADO
            Case Is = 10, 11, 12
                valor = "MILIARDOS" 'USADO
            Case Is = 13, 14, 15
                valor = "BILIONES" 'USADO
        End Select

        '*** SI LA CIFRA TIENE VALOR DECIMAL LO ASIGNAMOS AQUI.
        If Len(deci) >= 1 Then
            If Len(deci) = 1 Then deci = deci & "0"
            If Len(deci) > 2 Then deci = Left(deci, 2)
            deci = deci & "/100."
        Else
            deci = "00/100."
        End If


        flag = "N"
        If Val(numero) >= -999999999999999.0# And Val(numero) <= 999999999999999.0# Then  'SI EL NUMERO ESTA DENTRO DE 0 A 999.999.999
            For paso = Len(entero) To 1 Step -1
                b = Len(entero) - (paso - 1)
                Select Case paso
                    Case 3, 6, 9, 12, 15
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" And Mid(entero, b + 2, 1) = "0" Then
                                    expresion = expresion & "CIEN "
                                Else
                                    expresion = expresion & "CIENTO "
                                End If
                            Case "2"
                                expresion = expresion & "DOSCIENTOS "
                            Case "3"
                                expresion = expresion & "TRESCIENTOS "
                            Case "4"
                                expresion = expresion & "CUATROCIENTOS "
                            Case "5"
                                expresion = expresion & "QUINIENTOS "
                            Case "6"
                                expresion = expresion & "SEISCIENTOS "
                            Case "7"
                                expresion = expresion & "SETECIENTOS "
                            Case "8"
                                expresion = expresion & "OCHOCIENTOS "
                            Case "9"
                                expresion = expresion & "NOVECIENTOS "

                        End Select

                    Case 2, 5, 8, 11, 14
                        Select Case Mid(entero, b, 1)
                            Case "1"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    flag = "S"
                                    expresion = expresion & "DIEZ "
                                End If
                                If Mid(entero, b + 1, 1) = "1" Then
                                    flag = "S"
                                    expresion = expresion & "ONCE "
                                End If
                                If Mid(entero, b + 1, 1) = "2" Then
                                    flag = "S"
                                    expresion = expresion & "DOCE "
                                End If
                                If Mid(entero, b + 1, 1) = "3" Then
                                    flag = "S"
                                    expresion = expresion & "TRECE "
                                End If
                                If Mid(entero, b + 1, 1) = "4" Then
                                    flag = "S"
                                    expresion = expresion & "CATORCE "
                                End If
                                If Mid(entero, b + 1, 1) = "5" Then
                                    flag = "S"
                                    expresion = expresion & "QUINCE "
                                End If
                                If Mid(entero, b + 1, 1) > "5" Then
                                    flag = "N"
                                    expresion = expresion & "DIECI"
                                End If

                            Case "2"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "VEINTE "
                                    flag = "S"
                                Else
                                    expresion = expresion & "VEINTI"
                                    flag = "N"
                                End If

                            Case "3"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "TREINTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "TREINTA Y "
                                    flag = "N"
                                End If

                            Case "4"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "CUARENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "CUARENTA Y "
                                    flag = "N"
                                End If

                            Case "5"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "CINCUENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "CINCUENTA Y "
                                    flag = "N"
                                End If

                            Case "6"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "SESENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "SESENTA Y "
                                    flag = "N"
                                End If

                            Case "7"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "SETENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "SETENTA Y "
                                    flag = "N"
                                End If

                            Case "8"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "OCHENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "OCHENTA Y "
                                    flag = "N"
                                End If

                            Case "9"
                                If Mid(entero, b + 1, 1) = "0" Then
                                    expresion = expresion & "NOVENTA "
                                    flag = "S"
                                Else
                                    expresion = expresion & "NOVENTA Y "
                                    flag = "N"
                                End If

                            Case "0"
                                'EXPRESION = EXPRESION & ""
                                flag = "N"
                        End Select


                    Case 1, 4, 7, 10, 13
                        Select Case Mid(entero, b, 1)
                            Case "1"

                                If flag = "N" Then
                                    If paso = 1 Then
                                        expresion = expresion & "UNO "
                                    Else
                                        expresion = expresion & "UN "
                                    End If
                                End If

                            Case "2"
                                If flag = "N" Then
                                    expresion = expresion & "DOS "
                                End If

                            Case "3"
                                If flag = "N" Then
                                    expresion = expresion & "TRES "
                                End If
                            Case "4"
                                If flag = "N" Then
                                    expresion = expresion & "CUATRO "
                                End If
                            Case "5"
                                If flag = "N" Then
                                    expresion = expresion & "CINCO "
                                End If
                            Case "6"
                                If flag = "N" Then
                                    expresion = expresion & "SEIS "
                                End If
                            Case "7"
                                If flag = "N" Then
                                    expresion = expresion & "SIETE "
                                End If
                            Case "8"
                                If flag = "N" Then
                                    expresion = expresion & "OCHO "
                                End If
                            Case "9"
                                If flag = "N" Then
                                    expresion = expresion & "NUEVE "
                                End If
                        End Select
                End Select

                '*************************************************************************

                '********* MILES PARA MILES
                If paso = 4 And valor = "MILES" Then
                    If Mid(entero, 6, 1) <> "0" Or Mid(entero, 5, 1) <> "0" Or Mid(entero, 4, 1) <> "0" Or _
                        (Mid(entero, 6, 1) = "0" And Mid(entero, 5, 1) = "0" And Mid(entero, 4, 1) = "0" And _
                        Len(entero) <= 6) Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '********** MILES PARA MILLONES
                If paso = 4 And valor = "MILION" Then

                    If cifra = 7 And Val(Mid(entero, 2, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If


                    If cifra = 8 And Val(Mid(entero, 3, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 9 And Val(Mid(entero, 4, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If


                '********** MILES PARA MILLARDOS
                If paso = 4 And valor = "MILIARDOS" Then

                    If cifra = 10 And Val(Mid(entero, 5, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If


                    If cifra = 11 And Val(Mid(entero, 6, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 12 And Val(Mid(entero, 7, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '********** MILES PARA BILLONES
                If paso = 4 And valor = "BILIONES" Then

                    If cifra = 13 And Val(Mid(entero, 8, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 14 And Val(Mid(entero, 9, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If

                    If cifra = 15 And Val(Mid(entero, 10, 3)) >= 1 Then
                        expresion = expresion & "MIL "
                    End If
                End If

                '**********"INICIAMOS CONDICIONES PARA USAR PALABRA MILES DE MILLONES"*****************
                Select Case gOpcionMil
                    Case True 'DESEA USAR LA PALABRA MILES DE MILLONES
                        'Z********[SOLO PARA MILLARDOS] CUANDO MILLONES ES IGUAL A CERO
                        If paso = 7 And valor = "MILIARDOS" And cifra = 10 _
                        And Val(Mid(entero, 2, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If


                        If paso = 7 And valor = "MILIARDOS" And cifra = 11 _
                        And Val(Mid(entero, 3, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If


                        If paso = 7 And valor = "MILIARDOS" And cifra = 12 _
                        And Val(Mid(entero, 4, 3)) = 0 Then
                            expresion = expresion & "MILLONES "
                        End If
                        'Z*****PONER MILLARDOS DE BILLONES ******
                        If paso = 10 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 2, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        If paso = 10 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 3, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        If paso = 10 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 4, 3)) > 0 Then
                            expresion = expresion & "MIL "
                            BandBilion = True
                        End If

                        'Z******** SOLO PARA BILLONES CUANDO MILLARDOS ES MAS DE CERO
                        If paso = 7 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 5, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        If paso = 7 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 6, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        If paso = 7 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 7, 3)) = 0 And BandBilion Then
                            expresion = expresion & "MILLONES "
                            BandBilion = False
                        End If

                        'Z********** SOLO PARA MILLARDOS PRONUNCIADOS EN MILES DE MILLONES.
                        If paso = 10 And valor = "MILIARDOS" Then
                            expresion = expresion & "MIL "
                        End If
                        '**********"TERMINAMOS CONDICIONES PARA USAR PALABRA MILES DE MILLONES"**********


                        '**********"INICIAMOS CONDICIONES PARA USAR PALABRA MILLARDO(S)"**********
                    Case Else ' DESEA USAR  LA PALABRA MILLARDOS

                        If paso = 10 And valor = "BILIONES" And cifra = 13 _
                        And Val(Mid(entero, 2, 3)) > 0 Then
                            If Val(Mid(entero, 2, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        If paso = 10 And valor = "BILIONES" And cifra = 14 _
                        And Val(Mid(entero, 3, 3)) > 0 Then
                            If Val(Mid(entero, 3, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        If paso = 10 And valor = "BILIONES" And cifra = 15 _
                        And Val(Mid(entero, 4, 3)) > 0 Then
                            If Val(Mid(entero, 4, 3)) = 1 Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If

                        '********** MILLARDOS

                        If paso = 10 And valor = "MILIARDOS" Then
                            If Len(entero) = 10 And Mid(entero, 1, 1) = "1" Then
                                expresion = expresion & "MILLARDO "
                            Else
                                expresion = expresion & "MILLARDOS "
                            End If
                        End If
                        '**********"TERMINAMOS CONDICIONES PARA USAR PALABRA MILLARDO(S)"**********
                        '**************************************************************************
                End Select

                '*******[SOLO PARA MILLARDOS] CUANDO MILLONES ES MAS DE CERO

                If paso = 7 And valor = "MILIARDOS" And cifra = 10 And _
                Val(Mid(entero, 2, 3)) > 0 Then
                    If Val(Mid(entero, 2, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "MILIARDOS" And cifra = 11 _
                And Val(Mid(entero, 3, 3)) > 0 Then
                    If Val(Mid(entero, 3, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "MILIARDOS" And cifra = 12 _
                And Val(Mid(entero, 4, 3)) > 0 Then
                    If Val(Mid(entero, 4, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                '*************************************************


                '******** SOLO BILLONES

                If paso = 7 And valor = "BILIONES" And cifra = 13 _
                And Val(Mid(entero, 5, 3)) > 0 Then
                    If Val(Mid(entero, 5, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "BILIONES" And cifra = 14 _
                And Val(Mid(entero, 6, 3)) > 0 Then
                    If Val(Mid(entero, 6, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                If paso = 7 And valor = "BILIONES" And cifra = 15 _
                And Val(Mid(entero, 7, 3)) > 0 Then
                    If Val(Mid(entero, 7, 3)) = 1 Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If
                '****************************************************


                '********** SOLO PARA MILLONES
                If paso = 7 And valor = "MILION" Then
                    If Len(entero) = 7 And Mid(entero, 1, 1) = "1" Then
                        expresion = expresion & "MILLÓN "
                    Else
                        expresion = expresion & "MILLONES "
                    End If
                End If

                '******** SOLO PARA BILLONES
                If paso = 13 Then
                    If Len(entero) = 13 And Mid(entero, 1, 1) = "1" Then
                        expresion = expresion & "BILLÓN "
                    Else
                        expresion = expresion & "BILLONES "
                    End If
                End If


            Next paso

            'Agregar Moneda

            If IDMoneda <> 0 Then
                Moneda = Cn_Login.fn_ObtenTipoMoneda(IDMoneda)
                expresion += " " + Moneda + " "
            End If


            '*** EVALUAR QUE ESCRIBIR
            If deci <> "" Then 'SI EL VALOR RESULTANTE ES NEGATIVO CON DECIMAL
                If Mid(entero, 1, 1) = "-" Or Mid(entero, 1, 1) = "(" Then
                    fn_EnLetras = "MENOS " & expresion & "CON " & deci 'ANTES & "/100"
                Else
                    fn_EnLetras = expresion & "CON " & deci 'ANTES & "/100"
                End If
            Else 'SI EL VALOR RESULTANTE ES NEGATIVO SIN DECIMAL
                If Mid(entero, 1, 1) = "-" Or Mid(entero, 1, 1) = "(" Then
                    fn_EnLetras = "MENOS " & expresion
                Else
                    fn_EnLetras = expresion 'SI NO TIENE DECIMAL
                End If
            End If

            If Val(numero) = 0 Then fn_EnLetras = "MONTO ES IGUAL A CERO." 'NO DEBERÍA LLEAGR AQUI
        Else 'SI EL NUMERO A CONVERTIR ESTÁ FUERA DEL RANGO SUPERIOR O INFERIOR
            fn_EnLetras = "ERROR EN EL DATO INTRODUCIDO"
        End If
    End Function

#End Region


    Public Shared Function fn_GetComputerName() As String
        fn_GetComputerName = System.Net.Dns.GetHostName
    End Function

    Public Shared Function fn_GetComputerIP() As String
        fn_GetComputerIP = ""
        Try
            Dim hostName As String = Dns.GetHostName()
            Dim host As IPHostEntry = Dns.GetHostEntry(hostName)
            'Dim firstAddress As IPAddress = host.AddressList(0)
            Dim IP As IPAddress() = host.AddressList

            Dim index As Integer

            For index = 0 To IP.Length - 1
                If IP(index).ToString.Length > 7 And IP(index).ToString.Length < 16 Then
                    fn_GetComputerIP = IP(index).ToString
                    Exit For
                End If
            Next index
        Catch

        End Try

        Return fn_GetComputerIP '= firstAddress.ToString
    End Function

    Public Shared Function fn_GetComputarMAC() As String
        Dim mc As ManagementClass
        Dim moc As ManagementObjectCollection
        Dim MACAddress As String = String.Empty
        mc = New ManagementClass("Win32_NetworkAdapterConfiguration")
        moc = mc.GetInstances()
        For Each mo As ManagementObject In moc
            If MACAddress = String.Empty Then ' only return MAC Address from first card
                If (mo("IPEnabled") = True) Then
                    MACAddress = mo("MacAddress").ToString()
                    Exit For
                End If
            End If
            mo.Dispose()
        Next
        fn_GetComputarMAC = MACAddress 'MACAddress.Replace(":", "")
    End Function

    Public Shared Function fn_Fecha102(ByVal fe As String) As String
        If fe.Length <> 10 Then
            fn_Fecha102 = fe
        Else
            fn_Fecha102 = Right(fe, 4) + "." + Mid(fe, 4, 2) + "." + Left(fe, 2)
        End If
    End Function

    Public Shared Function fn_PonerCeros(ByVal cadena As String, ByVal longitud As Integer) As String
        Dim n As Integer
        If cadena.Length >= longitud Then
            fn_PonerCeros = cadena
        Else
            fn_PonerCeros = cadena
            For n = cadena.Length To longitud - 1
                fn_PonerCeros = "0" & fn_PonerCeros
            Next n
        End If
    End Function

    Public Shared Function fn_Columna(ByVal lsv As ListView, ByVal Uno As Integer, ByVal Dos As Integer, _
            ByVal Tres As Integer, ByVal Cuatro As Integer, ByVal Cinco As Integer, ByVal Seis As Integer, _
            ByVal Siete As Integer, ByVal Ocho As Integer, ByVal Nueve As Integer, ByVal Diez As Integer) As Boolean

        On Error Resume Next
        fn_Columna = False
        Dim Columnas As Integer
        Dim anchos(10) As Integer
        Dim CC As Integer
        anchos(1) = Uno
        anchos(2) = Dos
        anchos(3) = Tres
        anchos(4) = Cuatro
        anchos(5) = Cinco
        anchos(6) = Seis
        anchos(7) = Siete
        anchos(8) = Ocho
        anchos(9) = Nueve
        anchos(10) = Diez
        If lsv.Columns.Count > 10 Then
            Columnas = 10
        End If
        For CC = 1 To lsv.Columns.Count
            If anchos(CC) <> 0 Then
                lsv.Columns(CC - 1).Width = anchos(CC) * (lsv.Width / 100)
            Else
                lsv.Columns(CC - 1).Width = 0
            End If
        Next
        fn_Columna = True
    End Function

    Public Shared Function fn_Valida_Cadena(ByVal cadena As String, ByVal tipo As Validar_Cadena) As Boolean
        Dim Ii As Integer
        Dim Car As String
        Dim Numeros As String = "-0123456789"
        Dim Numeros_Dec As String = "-0123456789."
        Dim Letras As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁ´B´C´DÉ´F´G´HÍ´J´K´L´M´NÓ´P´Q´R´S´TÚ´V´W´XÝ´Zabcdefghijklmnñopqrstuvwxyzá´b´c´dé´f´g´hí´j´k´l´m´nó´p´q´r´s´tú´v´w´xý´z "
        Dim LetrasYcar As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁ´B´C´DÉ´F´G´HÍ´J´K´L´M´NÓ´P´Q´R´S´TÚ´V´W´XÝ´Zabcdefghijklmnñopqrstuvwxyzá´b´c´dé´f´g´hí´j´k´l´m´nó´p´q´r´s´tú´v´w´xý´z .,-()@\/_*"
        Dim LetrasYnumeros As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz0123456789 "
        Dim LetrasNumerosYCar As String = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZÁ´B´C´DÉ´F´G´HÍ´J´K´L´M´NÓ´P´Q´R´S´TÚ´V´W´XÝ´Zabcdefghijklmnñopqrstuvwxyzá´b´c´dé´f´g´hí´j´k´l´m´nó´p´q´r´s´tú´v´w´xý´z0123456789 .,-()@\/_*"
        Select Case tipo
            Case 0
                Return True
            Case 1 ' Solo Numeros
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    If InStr(Numeros, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 2, 7, 8 ' Numeros Decimales
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    If InStr(Numeros_Dec, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 3 ' Solo Letras
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    'Car = Car.ToUpper
                    If InStr(Letras, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 4 ' Letras y Caracteres
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(LetrasYcar, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 5 ' Letras y numeros
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    'Car = Car.ToUpper
                    If InStr(LetrasYnumeros, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
            Case 6
                fn_Valida_Cadena = True
                For Ii = 1 To cadena.Length
                    Car = Mid(cadena, Ii, 1)
                    Car = Car.ToUpper
                    If InStr(LetrasNumerosYCar, Car) = 0 Then
                        fn_Valida_Cadena = False
                        Exit Function
                    End If
                Next Ii
        End Select
    End Function

    Public Shared Function fn_Valida_Contra(ByVal cadena As String) As Boolean
        Dim Ii As Integer
        Dim Car As String
        Dim Numeros As String = "0123456789"
        Dim Mayus As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
        Dim Minus As String = "abcdefghijklmnopqrstuvwxyz"
        Dim Cant_Numeros As Integer = 0
        Dim Cant_Mayus As Integer = 0
        Dim Cant_Minus As Integer = 0

        fn_Valida_Contra = False
        If cadena.Length < 8 Then
            Exit Function
        End If
        For Ii = 1 To cadena.Length
            Car = Mid(cadena, Ii, 1)
            If InStr(Numeros, Car) > 0 Then
                Cant_Numeros = Cant_Numeros + 1
            End If
            If InStr(Mayus, Car) > 0 Then
                Cant_Mayus = Cant_Mayus + 1
            End If
            If InStr(Minus, Car) > 0 Then
                Cant_Minus = Cant_Minus + 1
            End If
        Next Ii
        If Cant_Mayus > 0 And Cant_Minus > 0 And Cant_Numeros > 3 And (Cant_Mayus + Cant_Minus) > 3 Then
            fn_Valida_Contra = True
        Else
            fn_Valida_Contra = False
        End If

    End Function

    Public Shared Function LetrA(ByVal ch As Integer) As String
        LetrA = ""
        If ch > 64 And ch < 91 Then
            LetrA = Chr(ch) 'A - Z
        ElseIf ch > 90 And ch < 117 Then
            LetrA = Chr(64 + 1) & Chr(ch - 26) 'AA - AZ
        ElseIf ch > 116 And ch < 143 Then
            LetrA = Chr(64 + 2) & Chr(ch - 52) 'BA - BZ
        ElseIf ch > 142 And ch < 169 Then
            LetrA = Chr(64 + 3) & Chr(ch - 78) 'CA - CZ
        ElseIf ch > 168 And ch < 195 Then
            LetrA = Chr(64 + 4) & Chr(ch - 104) 'DA - DZ
        ElseIf ch > 194 And ch < 221 Then
            LetrA = Chr(64 + 5) & Chr(ch - 130) 'EA - EZ
        ElseIf ch > 220 And ch < 247 Then
            LetrA = Chr(64 + 6) & Chr(ch - 156) 'FA - FZ
        ElseIf ch > 246 And ch < 273 Then
            LetrA = Chr(64 + 7) & Chr(ch - 182) 'GA - GZ
        ElseIf ch > 272 And ch < 299 Then
            LetrA = Chr(64 + 8) & Chr(ch - 208) 'HA - HZ
        ElseIf ch > 298 And ch < 325 Then
            LetrA = Chr(64 + 9) & Chr(ch - 234) 'IA - IZ
        ElseIf ch > 324 And ch < 351 Then
            LetrA = Chr(64 + 10) & Chr(ch - 260) 'JA - JZ
        End If
    End Function

    Public Shared Function fn_ExportarExcel_Microsoft_KingSoft(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, _
                                                               ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, _
                                                               ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar, ByVal ObjetoHC As String, _
                                                               Optional ByVal ExportarConBorde As Boolean = True, Optional ByVal ExportarConLineas As Boolean = False, _
                                                               Optional ByVal TituloFiltro As String = "", Optional ByVal TotalRegistros As Integer = -1) As Boolean
        'Funcion que exporta a Hoja de Cálculo de Microsoft Office y Kingsoft Office
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer

        If Lista.Items.Count = 0 Then
            fn_ExportarExcel_Microsoft_KingSoft = False
            Microsoft.VisualBasic.MsgBox("No existe Información para Exportar.", 64 + 0, Titulo)
            Exit Function
        End If

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then
            'Bar.Value = 20
            Try
                'mandamos la cadena Objeto ya sea Microsoft o Kinsoft
                Dim objExcel = CreateObject(ObjetoHC)

                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objExcel.UserControl = True
                Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                'Bar.Value = 30
                objExcel.SheetsInNewWorkbook = 1
                objExcel.Workbooks.Add()

                'Bar.Value = 35
                With objExcel
                    'Bar.Value = 40
                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = Lista.Columns(I).Text
                            End If
                            If I = 0 Then
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).Text
                            Else
                                .Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & Lista.Items(J).SubItems(I).Text
                            End If
                            Bar.Value += 1
                        Next J
                        ' Bar.Value = 40 + (I * (60 / (Lista.Columns.Count - 1 - Cols_Derecha_Omitir)))
                    Next I

                    For n = 0 To I + 1
                        .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                    Next n

                    .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True

                    If Filas_sin_Texto > 0 Then
                        '.Range("A1").Value = Titulo
                        '.Range("A1").Font.Bold = True
                        '.Range("A1:" & LetrA(64 + I) & "1").Merge()
                        '.Selection.HorizontalAlignment = -4108

                        'coloca el nombre de la empresa
                        ' .Range("A1").Value = EmpresaN & " - SUCURSAL " & SucursalN
                        .Range("A1").Font.Bold = True
                        .Range("A1:" & LetrA(64 + I) & "1").Merge()
                        .range("A1").select()
                        .selection.horizontalalignment = -4108

                        'coloca el Titulo del Reporte
                        .Range("A2").Value = Titulo.ToUpper
                        .Range("A2").Font.Bold = True
                        .Range("A2:" & LetrA(64 + I) & "2").Merge()
                        .RANGE("A2").Select()
                        .Selection.HorizontalAlignment = -4108

                        'Coloca el Rango de Fechas o Algun otro dato
                        .Range("A3").Value = TituloFiltro.ToUpper
                        .Range("A3").Font.Bold = True
                        .Range("A3:" & LetrA(64 + I) & "3").Merge()
                        .RANGE("a3").SELECT()
                        .Selection.HorizontalAlignment = -4108
                    End If

                    'Pone el Borde a los datos
                    If ExportarConBorde Then
                        .Range(LetrA(64 + 1 - Cols_Izquierda_Omitir) & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (Filas_sin_Texto + J + 1).ToString).Borders().LineStyle = 1
                    End If

                    'coloca pie de reporte
                    .Range(LetrA(64 + 1 - Cols_Izquierda_Omitir) & (Filas_sin_Texto + J + 1 + 2).ToString).Value = "Total de Registros: " & If(TotalRegistros = -1, Lista.Items.Count, TotalRegistros)
                    .Range(LetrA(64 + 1 - Cols_Izquierda_Omitir) & (Filas_sin_Texto + J + 1 + 3).ToString).Value = "Fecha: " & Format(Today.Date, "dd/MMM/yyyy") & "-" & frm_MENU.lbl_Hora.Text
                    .Range(LetrA(64 + 1 - Cols_Izquierda_Omitir) & (Filas_sin_Texto + J + 1 + 4).ToString).Value = "Usuario: " & UsuarioN

                End With

                Bar.Value = Bar.Maximum

                fn_ExportarExcel_Microsoft_KingSoft = True
                objExcel.Visible = True
                objExcel = Nothing
                Bar.Value = 0
            Catch ex As Exception
                fn_ExportarExcel_Microsoft_KingSoft = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_ExportarExcel_Microsoft_KingSoft = False
        End If
    End Function

    Public Shared Function fn_Exportar_CalcOpenOffice(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim Cont As Integer = 0
        Dim SumLetra As String = ""

        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < Lista.Columns.Count Then

            Try
                Dim objServManager As Object
                Dim objDesktop As Object
                Dim objDocument As Object '--->
                Dim objSheet1 As Object
                Dim objArguments As Object() = {} 'ok

                objServManager = CreateObject("com.sun.star.ServiceManager")
                objDesktop = objServManager.createInstance("com.sun.star.frame.Desktop")
                objDocument = objDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, objArguments)
                Bar.Maximum = (Lista.Columns.Count - Cols_Derecha_Omitir - Cols_Izquierda_Omitir) * Lista.Items.Count + 2
                Bar.Value = 0

                objSheet1 = objDocument.Sheets.getByIndex(0)
                With objSheet1

                    For I = (0 + Cols_Izquierda_Omitir) To Lista.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To Lista.Items.Count - 1
                            If J = 0 Then
                                'ESCRIBE ENCABEZADOS
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).SetString(Lista.Columns(I).Text)
                            End If
                            If I = 0 Then
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).Text)
                            Else
                                'ESCRIBE CONTENIDO DE LISTVIEW
                                .getCellRangeByName(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).SetString(Lista.Items(J).SubItems(I).Text)
                            End If
                            Bar.Value += 1
                        Next J
                    Next I

                    '--PONE EN NEGRITA LOS ENCABEZADOS
                    SumLetra = "A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString
                    .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita encabezado

                    '--AJUSTA LAS COLUMNAS - AUTOFIT
                    For Cont = 0 To I - 1
                        .Columns(Cont).OptimalWidth = True
                    Next Cont

                    If Filas_sin_Texto > 0 Then
                        'TITULO EN NEGRITA CENTRADO Y CELDA COMBINADO
                        .getCellRangeByName("A1").SetString(Titulo)

                        Cont = (Lista.Columns.Count) - (Cols_Derecha_Omitir + Cols_Izquierda_Omitir)
                        SumLetra = "A1:" & LetrA(64 + Cont) & "1"

                        .getCellRangeByName(SumLetra).Merge(True) 'combina celda
                        .getCellRangeByName(SumLetra).VertJustify = 2 'centrar
                        .getCellRangeByName(SumLetra).HoriJustify = 2 ' centrar
                        .getCellRangeByName(SumLetra).CharWeight = 150 ' negrita
                    End If
                End With

                Bar.Value = Bar.Maximum
                fn_Exportar_CalcOpenOffice = True
                objServManager = Nothing
                Bar.Value = 0

            Catch ex As Exception
                fn_Exportar_CalcOpenOffice = False
                MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
                Bar.Value = Bar.Minimum
            End Try
        Else
            fn_Exportar_CalcOpenOffice = False
        End If

    End Function

    Public Shared Function fn_Exporta_ListviewToExcel(ByVal Lista As ListView, ByVal RutaficheroCSV As String) As Boolean
        Try

            'Dim Fecha As String = Format(Now, "_dd-MM-yyyy")
            'Dim Hora As String = Format(Now, "_HH-mm-ss")
            Dim sb As String = ""
            Dim i As Integer = 0, j As Integer = 0
            FileOpen(1, RutaficheroCSV, OpenMode.Output)

            For Each elemento As ColumnHeader In Lista.Columns
                sb &= Trim(elemento.Text) & ";"
            Next
            PrintLine(1, sb)
            '------------
            For i = 0 To Lista.Items.Count - 1
                sb = ""
                For j = 0 To Lista.Columns.Count - 1
                    sb &= Lista.Items(i).SubItems(j).Text.Trim & ";"
                Next j
                'va imprimiendo cada linea
                PrintLine(1, sb)
            Next i

            'cerrando el archivo
            FileClose(1)
            Return True
        Catch ex As Exception
            MsgBox("error al guadar archivo: " & ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FileClose(1)
            Return False
        End Try

    End Function

    Public Shared Function fn_Exportar_Excel(ByVal Lista As ListView, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Try
            '-----para Microsoft Office(Excel)
            Try
                ObjetoHC = "Excel.Application"
                Dim objExcel = CreateObject(ObjetoHC)
                versionHC = True
                objExcel = Nothing
                Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
            Catch ex As Exception
                versionHC = False
            End Try

            '-----para KingSoft Office (Spreadsheets) 
            If versionHC = False Then
                Try
                    ObjetoHC = "Ket.Application"
                    Dim objExcel = CreateObject(ObjetoHC)
                    versionHC = True
                    objExcel = Nothing
                    Call fn_ExportarExcel_Microsoft_KingSoft(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar, ObjetoHC)
                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            '----------para Apache OpenOffice 4.0 (Calc)--
            If versionHC = False Then

                Try
                    Dim objServManager = CreateObject("com.sun.star.ServiceManager")
                    versionHC = True
                    objServManager = Nothing
                    fn_Exportar_CalcOpenOffice(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar)

                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            If versionHC = False Then
                MsgBox("No se encontró niguna paqueteria  de gestión de hoja de cálculo para la exportación de la lista, por lo tanto se procederá a guardar el archivo.", MsgBoxStyle.Exclamation, frm_MENU.Text)

                Dim svd As New SaveFileDialog
                svd.Title = "Guardar Como"
                svd.Filter = "Texto CSV (*.csv)|*.csv"
                svd.FilterIndex = 1
                svd.DefaultExt = "csv"
                svd.OverwritePrompt = True
                svd.FileName = "Reporte"
                If svd.ShowDialog = DialogResult.OK Then
                    '--en caso de que no hay paqueteria, solo guarda con .csv
                    If fn_Exporta_ListviewToExcel(Lista, svd.FileName) Then
                        versionHC = True
                        MsgBox("El archivo se ha guardado correctamente en: " & svd.FileName, MsgBoxStyle.Information, frm_MENU.Text)

                    End If
                End If
            End If
            Return versionHC

        Catch ex As Exception
            MsgBox("No se pudo exportar lista a hoja de cálculo", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End Try

    End Function

    Public Shared Function fn_ExportarTabla_Excel(ByVal dt As DataTable, ByVal Filas_sin_Texto As Integer, ByVal Titulo As String, ByVal Cols_Izquierda_Omitir As Integer, ByVal Cols_Derecha_Omitir As Integer, ByVal Bar As ToolStripProgressBar) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim n As Integer
        Dim Libro As Object
        Dim Hoja As Object
        Dim Ruta As String = My.Application.Info.DirectoryPath & "\DatosPendientes"

        Try
            Kill(Ruta & ".xlsx")
            Kill(Ruta & ".xls")
        Catch

        End Try
        If (Cols_Izquierda_Omitir + Cols_Derecha_Omitir) < dt.Columns.Count Then
            Try
                Dim objExcel = CreateObject("Excel.Application")
                objExcel.SheetsInNewWorkbook = 1
                Libro = objExcel.Workbooks.Add()
                Hoja = Libro.Sheets(1)
                Bar.Value = 10

                objExcel.UserControl = True
                Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
                System.Threading.Thread.CurrentThread.CurrentCulture = oldCI
                Bar.Value = 20

                'objExcel.Workbooks.Add()
                Bar.Value = 25
                With Hoja
                    If Filas_sin_Texto > 0 Then
                        .Range("A1:D1").Mergecells = True
                        .Range("A1").Value = Titulo
                        .Range("A1").Font.Bold = True
                    End If
                    '.Range(LetrA(64 + I + 1) & J + Filas_sin_Texto).Value = Lista.Columns(I).Text
                    Bar.Value = 30
                    For I = (0 + Cols_Izquierda_Omitir) To dt.Columns.Count - 1 - Cols_Derecha_Omitir
                        For J = 0 To dt.Rows.Count - 1
                            If J = 0 Then
                                Select Case I
                                    Case 0
                                        '.Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = "Clave"
                                    Case 1
                                        .Range(LetrA(64 + I - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = "Clave"
                                    Case 2
                                        .Range(LetrA(64 + I - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = "Nombre"
                                    Case 3
                                        .Range(LetrA(64 + I - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = "Departamento"
                                    Case 4
                                        .Range(LetrA(64 + I - Cols_Izquierda_Omitir) & J + Filas_sin_Texto + 1).Value = "Puesto"
                                End Select
                            End If
                            If I = 0 Then
                                '.Range(LetrA(64 + I + 1 - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = dt.Rows(J)(I + 1)
                            Else
                                .Range(LetrA(64 + I - Cols_Izquierda_Omitir) & J + 1 + Filas_sin_Texto + 1).Value = "'" & dt.Rows(J)(I)
                            End If
                        Next J
                        Bar.Value = 30 + (I * (60 / (dt.Columns.Count - 1 - Cols_Derecha_Omitir)))
                    Next I
                    For n = 0 To I + 1
                        .Range(LetrA(64 + n + 1) & "1").EntireColumn.AutoFit()
                    Next n
                    .Range("A" & (0 + Filas_sin_Texto + 1).ToString & ":" & LetrA(64 + I) & (0 + Filas_sin_Texto + 1).ToString).Font.Bold = True
                End With
                Bar.Value = 95
                Bar.Value = 100

                Libro.SaveAs(Ruta)
                Libro.close()
                objExcel.Quit()
                objExcel = Nothing

                Bar.Value = 0
                fn_ExportarTabla_Excel = True

            Catch ex As Exception
                TrataEx(ex, False)
                fn_ExportarTabla_Excel = False
            End Try
        Else
            fn_ExportarTabla_Excel = False
        End If
    End Function

    Public Shared Function fn_Graficar_ExcelDetallado(ByVal Lista As ListView, ByVal Tipo As Integer) As Boolean
        Dim I As Integer = 0
        Dim J As Integer = 0
        Dim K As Integer = 0
        Dim Hoja As String
        Dim CantidadHojas As Integer = 0
        Dim Departamento As String = ""
        Dim Filas As Integer = Lista.Items.Count
        Dim Ruta As String = My.Application.Info.DirectoryPath & "Grafico"
        Dim Hora As String = Now.TimeOfDay.ToString & ".JPG"
        Hora = Replace(Hora, ":", "_")
        Ruta = Ruta & Hora

        Try
            Dim objExcel = CreateObject("Excel.Application")

            objExcel.SheetsInNewWorkbook = 1
            objExcel.Workbooks.Add()
            Dim Libro As Object = objExcel.ActiveWorkbook
            With objExcel
                For Each Elemento In Lista.Items
                    If Departamento <> Elemento.Text Then
                        If cantidadhojas > 0 Then
                            'Creamos el Gráfico
                            .Range("A:" & LetrA(64 + Lista.Columns.Count - 1)).EntireColumn.AutoFit()
                            .Range("A2:" & LetrA(64 + Lista.Columns.Count - 1) & J).Select()
                            .ActiveSheet.Shapes.AddChart.Select()
                            .ActiveChart.SetSourceData(Source:= .Range("$A$2:$" & LetrA(64 + Lista.Columns.Count - 1) & "$" & J), PlotBy:=2)
                            .ActiveChart.ChartType = Tipo
                            .ActiveChart.ClearToMatchStyle()
                            .ActiveChart.ChartStyle = 2
                            .ActiveChart.HasTitle = True
                            .ActiveChart.ChartTitle.Text = Departamento
                            'Ponemos tamaño 8 para el eje Y
                            .ActiveChart.Axes(2).Select()
                            .Selection.TickLabels.AutoScaleFont = True
                            With .Selection.TickLabels.Font
                                .Size = 8
                            End With
                            'Ponemos tamaño 8 para el eje X
                            .ActiveChart.Axes(1).Select()
                            .Selection.TickLabels.AutoScaleFont = True
                            With .Selection.TickLabels.Font
                                .Size = 8
                            End With

                            'Ubica el gráfico en la posición A9
                            .ActiveChart.Parent.Top = .Range("F1").Top
                            .ActiveChart.Parent.Left = .Range("F1").Left
                            .ActiveChart.Parent.Name = Departamento
                            .Range("A1").Select()
                            .Worksheets(Departamento).ChartObjects(Departamento).RoundedCorners = True
                        End If

                        'Cambiar de Hoja
                        Departamento = Elemento.Text
                        'Agregar una hoja nueva cuando sea un departamento nuevo
                        Libro.Sheets.Add(After:=Libro.Sheets(Libro.Sheets.Count))
                        'tomar el nombre de la hoja en una variable y seleccionar la hoja
                        Hoja = Libro.ActiveSheet.Name
                        Libro.Sheets(Hoja).Select()
                        'La hoja creada nombrarla como se llama el departamento
                        Libro.Sheets(Hoja).Name = Departamento
                        .Range("A1").Value = Departamento
                        For I = 1 To Lista.Columns.Count - 1
                            .Range(LetrA(64 + I) & 2).Value = Lista.Columns(I).Text
                        Next I
                        .Range("A1:" & LetrA(64 + Lista.Columns.Count + 1) & 2).Font.Bold = True
                        .Range("A1:" & LetrA(64 + Lista.Columns.Count + 1) & 1).EntireColumn.AutoFit()
                        J = 2
                    End If
                    'sólo poner las filas que contiene el departamento
                    J += 1
                    For I = 1 To Lista.Columns.Count - 1
                        .Range(LetrA(64 + I) & J).Value = Elemento.Subitems(I).text
                    Next I
                    cantidadhojas += 1

                    If Elemento.index = Lista.Items.Count - 1 Then
                        'Creamos el Gráfico
                        .Range("A:" & LetrA(64 + Lista.Columns.Count - 1)).EntireColumn.AutoFit()
                        .Range("A2:" & LetrA(64 + Lista.Columns.Count - 1) & J).Select()
                        .ActiveSheet.Shapes.AddChart.Select()
                        .ActiveChart.SetSourceData(Source:= .Range("$A$2:$" & LetrA(64 + Lista.Columns.Count - 1) & "$" & J), PlotBy:=2)
                        .ActiveChart.ChartType = Tipo
                        .ActiveChart.ClearToMatchStyle()
                        .ActiveChart.ChartStyle = 2
                        .ActiveChart.HasTitle = True
                        .ActiveChart.ChartTitle.Text = Departamento
                        'Ponemos tamaño 8 para el eje Y
                        .ActiveChart.Axes(2).Select()
                        .Selection.TickLabels.AutoScaleFont = True
                        With .Selection.TickLabels.Font
                            .Size = 8
                        End With
                        'Ponemos tamaño 8 para el eje X
                        .ActiveChart.Axes(1).Select()
                        .Selection.TickLabels.AutoScaleFont = True
                        With .Selection.TickLabels.Font
                            .Size = 8
                        End With

                        'Ubica el gráfico en la posición A9
                        .ActiveChart.Parent.Top = .Range("F1").Top
                        .ActiveChart.Parent.Left = .Range("F1").Left
                        .ActiveChart.Parent.Name = Departamento
                        .Range("A1").Select()
                        .Worksheets(Departamento).ChartObjects(Departamento).RoundedCorners = True
                    End If
                Next

                'Borrar la Hoja inicial que estaba vacia
                Libro.Sheets(1).Select()
                .ActiveWindow.SelectedSheets.Delete()
            End With

            objExcel.Visible = True
            objExcel = Nothing
            Return True
        Catch ex As Exception
            MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Return False
        End Try
    End Function

    Public Shared Function fn_Graficar_ExcelGlobal(ByVal Lista As ListView, ByVal Titulo As String, ByVal pct As PictureBox, ByVal Visible As Boolean, ByVal Tipo As Integer) As Boolean
        Dim I As Integer
        Dim J As Integer
        Dim Filas As Integer = Lista.Items.Count
        Dim Hoja As String = ""
        pct.Image = Nothing
        Dim Ruta As String = My.Application.Info.DirectoryPath & "Grafico"
        Dim Hora As String = Now.TimeOfDay.ToString & ".JPG"
        Hora = Replace(Hora, ":", "_")
        Ruta = Ruta & Hora

        Try
            Dim objExcel = CreateObject("Excel.Application")

            objExcel.SheetsInNewWorkbook = 1
            objExcel.Workbooks.Add()
            Dim Libro As Object = objExcel.ActiveWorkbook
            Hoja = Libro.ActiveSheet.Name
            Libro.Sheets(Hoja).Select()
            'La hoja creada nombrarla como se llama el departamento
            Libro.Sheets(Hoja).Name = Titulo
            With objExcel

                For I = 0 To Lista.Columns.Count - 1
                    For J = 0 To Lista.Items.Count - 1
                        If J = 0 Then
                            .Range(LetrA(64 + I + 1) & J + 1).Value = Lista.Columns(I).Text
                        End If
                        If I = 0 Then
                            .Range(LetrA(64 + I + 1) & J + 2).Value = Lista.Items(J).Text
                        Else
                            .Range(LetrA(64 + I + 1) & J + 2).Value = Lista.Items(J).SubItems(I).Text
                        End If
                    Next J
                Next I

                .Range("A1").Value = Titulo
                .Range("A1:C1").Font.Bold = True
                .Range("A:C").EntireColumn.AutoFit()
                .Range("A1:C" & filas + 1).Select()
                .ActiveSheet.Shapes.AddChart.Select()
                .ActiveChart.SetSourceData(Source:= .Range("$A$1:$C$" & filas + 1), PlotBy:=2)
                .ActiveChart.ChartType = Tipo
                .ActiveChart.ClearToMatchStyle()
                .ActiveChart.ChartStyle = 2
                .ActiveChart.HasTitle = True
                .ActiveChart.ChartTitle.Text = Titulo
                'Ponemos tamaño 8 para el eje Y
                .ActiveChart.Axes(2).Select()
                .Selection.TickLabels.AutoScaleFont = True
                With .Selection.TickLabels.Font
                    .Size = 8
                End With
                'Ponemos tamaño 8 para el eje X
                .ActiveChart.Axes(1).Select()
                .Selection.TickLabels.AutoScaleFont = True
                With .Selection.TickLabels.Font
                    .Size = 8
                End With

                .ActiveChart.Parent.Top = .Range("F1").Top
                .ActiveChart.Parent.Left = .Range("F1").Left
                .ActiveChart.Parent.Name = Titulo
                .Worksheets(Titulo).ChartObjects(Titulo).RoundedCorners = True
                .ActiveChart.Export(Filename:=ruta, Filtername:="JPG")
                .Range("A1").Select()
            End With

            objExcel.Visible = Visible
            'Revisa si se muestra o no el libro, porque si no se mostrará al obtener la
            'gráfica se cierra sin guardar cambios (sólo el libro que se uso para la gráfica)
            If Visible = False Then
                objExcel.DisplayAlerts = False
                Libro.Close()
                objExcel.displayAlerts = True
            End If
            objExcel = Nothing
        Catch ex As Exception
            MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
            Return False
        End Try
        'Mostrar la imagen
        Try
            pct.Image = New System.Drawing.Bitmap(ruta)
        Catch ex As Exception
            MsgBox("Ocurrió un error." & ex.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, frm_MENU.Text)
        End Try
        Return True
    End Function

    Public Shared Function fn_Buscar_enListView(ByRef Lista As ListView, ByVal cadena As String, ByVal Columna As Integer, ByVal Fila_Inicio As Integer) As Boolean
        Dim n As Integer
        Dim col As Integer

        Lista.SelectedItems.Clear()
        If Columna = 0 Then
            For n = Fila_Inicio To Lista.Items.Count - 1
                For col = 0 To Lista.Columns.Count - 1
                    If col = 0 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(col).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    End If
                Next col
            Next n
        Else
            If Columna > Lista.Columns.Count Then
                fn_Buscar_enListView = False
                Exit Function
            Else
                For n = Fila_Inicio To Lista.Items.Count - 1
                    If Columna = 1 Then
                        If InStr(1, Lista.Items(n).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    Else
                        If InStr(1, Lista.Items(n).SubItems(Columna - 1).Text.ToUpper, cadena) > 0 Then
                            Lista.Items(n).Selected = True
                            Lista.Items(n).EnsureVisible()
                            fn_Buscar_enListView = True
                            Exit Function
                        End If
                    End If
                Next n
            End If
        End If
        fn_Buscar_enListView = False
    End Function

    Public Shared Function fn_CargaLista(ByVal Consulta As String, ByVal lsw As ListView, ByVal icono As Integer, ByVal Cadena As String) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim CnN0 As New SqlConnection
        Dim CmD0 As New SqlCommand
        Dim Dr0 As SqlDataReader
        fn_CargaLista = False
        Try
            CnN0 = Cn_Datos.Crea_Conexion(Cadena)
            CmD0 = Cn_Datos.Crea_Comando(Consulta, CommandType.Text, CnN0)
            CmD0.Connection.Open()
            Dr0 = CmD0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                lsw.Columns.Add(Dr0.GetName(I))
            Next I
            indeXX = 0
            While Dr0.Read
                lsw.Items.Add(Dr0.Item(0).ToString)
                For I = 1 To Dr0.FieldCount - 1
                    lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                Next
                indeXX = indeXX + 1
            End While
            fn_CargaLista = True
            Dr0.Close()
            CmD0.Connection.Close()
            CmD0.Dispose()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            If CnN0.State = ConnectionState.Open Then
                CnN0.Close()
            End If
            CnN0.Dispose()
            CmD0.Dispose()

            fn_CargaLista = False
            Call fn_GuardaError("fn_CargarLista", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaListaCMD(ByVal Cmd0 As SqlCommand, ByVal lsw As ListView, ByVal icono As Integer) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim Dr0 As SqlDataReader
        fn_CargaListaCMD = False
        Try
            Dr0 = Cmd0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                lsw.Columns.Add(Dr0.GetName(I))
            Next I
            indeXX = 0
            While Dr0.Read
                lsw.Items.Add(Dr0.Item(0).ToString)
                For I = 1 To Dr0.FieldCount - 1
                    lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                Next
                indeXX = indeXX + 1
            End While
            fn_CargaListaCMD = True
            Dr0.Close()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            fn_CargaListaCMD = False
            Call fn_GuardaError("fn_CargarListaCMD", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaListaCMDtag(ByVal Cmd0 As SqlCommand, ByVal lsw As ListView, ByVal icono As Integer, ByVal Campo_Tag As String) As Boolean
        Dim I As Integer
        Dim indeXX As Integer
        Dim Dr0 As SqlDataReader
        fn_CargaListaCMDtag = False
        Try
            Dr0 = Cmd0.ExecuteReader
            lsw.GridLines = False
            lsw.Items.Clear()
            lsw.Columns.Clear()
            For I = 0 To Dr0.FieldCount - 1
                If Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper Then

                Else
                    lsw.Columns.Add(Dr0.GetName(I))
                End If

            Next I
            indeXX = 0
            While Dr0.Read
                If Dr0.GetName(0).ToUpper = Campo_Tag.ToUpper Then
                    lsw.Items.Add(Dr0.Item(1).ToString)
                    lsw.Items(indeXX).Tag = Dr0.Item(0).ToString
                    For I = 2 To Dr0.FieldCount - 1
                        If Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper Then
                            lsw.Items(indeXX).Tag = Dr0.Item(I).ToString
                        Else
                            lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                        End If
                    Next
                Else
                    lsw.Items.Add(Dr0.Item(0).ToString)
                    For I = 1 To Dr0.FieldCount - 1
                        If Dr0.GetName(I).ToUpper = Campo_Tag.ToUpper Then
                            lsw.Items(indeXX).Tag = Dr0.Item(I).ToString
                        Else
                            lsw.Items(indeXX).SubItems.Add(Dr0.Item(I).ToString)
                        End If
                    Next
                End If
                indeXX = indeXX + 1
            End While
            fn_CargaListaCMDtag = True
            Dr0.Close()
            Exit Function
        Catch ex As Exception
            If Not IsNothing(Dr0) Then
                If Not Dr0.IsClosed Then
                    Dr0.Close()
                End If
            End If
            fn_CargaListaCMDtag = False
            Call fn_GuardaError("fn_CargarListaCMDtag", "", ex.Message.ToUpper, True)
        End Try
    End Function

    Public Shared Function fn_CargaCombo(ByVal cmb As ComboBox, ByVal dt As DataTable, ByVal ValueMember As String, ByVal DisplayMember As String) As Boolean
        On Error GoTo Err_1
        Dim Ilocal As Integer
        Dim dtr As DataRow = dt.NewRow
        Dim i As Integer
        fn_CargaCombo = False
        dtr.Item(ValueMember) = "0"
        dtr.Item(DisplayMember) = "Seleccione..."

        For i = 0 To dt.Columns.Count - 1
            If dt.Columns(i).ColumnName <> DisplayMember And dt.Columns(i).ColumnName <> ValueMember Then
                If dt.Columns(i).DataType Is GetType(DateTime) Then
                    dtr.Item(i) = Today
                Else
                    dtr.Item(i) = "0"
                End If

            End If
        Next i

        cmb.ValueMember = ValueMember
        cmb.DisplayMember = DisplayMember
        dt.Rows.InsertAt(dtr, 0)
        cmb.DataSource = dt

        'cmb.SelectedIndex = 0
        fn_CargaCombo = True
        Exit Function
Err_1:
        fn_CargaCombo = False
        MsgBox("Ocurrió el siguiente Error: " & Err.Description)
        Err.Clear()
    End Function


    Public Shared Function fn_GuardaError(ByVal Donde As String, ByVal Numero_Error As String, ByVal Descripcion As String, ByVal Enviar_Mail As Boolean) As Boolean
        On Error GoTo kk
        Dim Resu As Integer
        Dim CnN1 As New SqlConnection
        Dim CmD1 As New SqlCommand
        Dim Consulta As String
        fn_GuardaError = False
        Dim Ruta As String = My.Application.Info.DirectoryPath & "\Error.jpg"
        Dim Texto_Mail As String = ""

        SendKeys.SendWait("({PRTSC})")
        My.Computer.Clipboard.GetImage().Save(Ruta)

        CnN1 = Cn_Datos.Crea_Conexion(Cnx_Datos)
        CmD1 = Cn_Datos.Crea_Comando("Usr_Errores_Create", CommandType.StoredProcedure, CnN1)

        Cn_Datos.Crea_Parametro(CmD1, "@Id_Sucursal", SqlDbType.Int, SucursalId)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Empleado", SqlDbType.Int, UsuarioId)
        Cn_Datos.Crea_Parametro(CmD1, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Cn_Datos.Crea_Parametro(CmD1, "@Version", SqlDbType.VarChar, ModuloVersion)
        Cn_Datos.Crea_Parametro(CmD1, "@Estacion", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
        Cn_Datos.Crea_Parametro(CmD1, "@Donde", SqlDbType.VarChar, Donde)
        Cn_Datos.Crea_Parametro(CmD1, "@Numero_Error", SqlDbType.VarChar, Numero_Error)
        Cn_Datos.Crea_Parametro(CmD1, "@Descripcion", SqlDbType.VarChar, Descripcion)


        Resu = Cn_Datos.EjecutarScalar(CmD1)
        If Resu > 0 Then
            fn_GuardaError = True
        Else
            fn_GuardaError = False
        End If
        CmD1.Dispose()
        CnN1.Dispose()
        If Enviar_Mail Then

            Texto_Mail = "                Sucursal: " & SucursalN & Chr(13) _
                        & "                 Módulo: " & frm_MENU.Text & Chr(13) _
                       & "         Usuario Firmado: " & UsuarioN & Chr(13) _
                       & "                  Equipo: " & EstacioN & Chr(13) _
                       & "                   Donde: " & Donde & Chr(13) _
                       & "             Descripcion: " & Descripcion & Chr(13) & Chr(13) _
                       & "Agente de Servicios SIAC."
            Cn_Mail.fn_Enviar_MailFallas("!!!SIAC: Error Manejado", Texto_Mail, Ruta)
        End If
        Exit Function
kk:
        fn_GuardaError = False
    End Function

    Public Shared Function fn_GuardaBitacora(ByVal Tipo As Integer, ByVal Descripcion As String, ByVal Id As Integer) As Boolean
        On Error GoTo kk
        Dim Resu As Integer
        Dim CnN1 As New SqlConnection
        Dim CmD1 As New SqlCommand
        Dim Consulta As String

        CnN1 = Cn_Datos.Crea_Conexion(Cnx_Datos)
        CmD1 = Cn_Datos.Crea_Comando("Usr_Bitacora_Create", CommandType.StoredProcedure, CnN1)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Sucursal", SqlDbType.BigInt, SucursalId)
        Cn_Datos.Crea_Parametro(CmD1, "@Id_Usuario", SqlDbType.BigInt, UsuarioId)
        Cn_Datos.Crea_Parametro(CmD1, "@Clave_Modulo", SqlDbType.VarChar, ModuloClave)
        Cn_Datos.Crea_Parametro(CmD1, "@Tipo", SqlDbType.Int, Tipo)
        Cn_Datos.Crea_Parametro(CmD1, "@Descripcion", SqlDbType.VarChar, Descripcion)
        Cn_Datos.Crea_Parametro(CmD1, "@Estacion", SqlDbType.VarChar, EstacioN)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionIP", SqlDbType.VarChar, EstacionIp)
        Cn_Datos.Crea_Parametro(CmD1, "@EstacionMAC", SqlDbType.VarChar, EstacionMac)
        Cn_Datos.Crea_Parametro(CmD1, "@Version", SqlDbType.VarChar, ModuloVersion)
        Cn_Datos.Crea_Parametro(CmD1, "@Id", SqlDbType.Int, Id)

        Resu = Cn_Datos.EjecutarNonQuery(CmD1)
        If Resu > 0 Then
            fn_GuardaBitacora = True
        Else
            fn_GuardaBitacora = False
        End If
        CmD1.Dispose()
        CnN1.Dispose()
        Exit Function
kk:
        fn_GuardaBitacora = False
    End Function

    Public Shared Function fn_DatatableToHTML(ByVal dt As DataTable, ByVal Titulo As String, ByVal Cols_Omitir_Izq As Integer, ByVal Cols_Omitir_Der As Integer, ByVal Tamaño As Int32) As String
        '"Prueba de Correo HTML.<Br><Table><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr></Table>"
        Dim Cadena As String = ""
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0
        'Titulo
        Cadena = "<Table style='border:solid 1px black; border-collapse:collapse' width='100%'>"
        Cadena &= "<CAPTION style='border:solid 1px black'><b>"
        Cadena &= Titulo
        Cadena &= "</b></CAPTION>"
        'Encabezados
        Cadena &= "<thead>"
        Cadena &= "<tr>"
        Dim indice As Integer = 0
        For Each cl As DataColumn In dt.Columns
            If indice >= Cols_Omitir_Izq Then
                If indice > (dt.Columns.Count - 1 - Cols_Omitir_Der) Then Exit For
                Cadena &= "<th style='border:solid 1px black'>"
                Cadena &= cl.Caption
                Cadena &= "</th>"
            End If
            indice += 1
        Next
        Cadena &= "</tr>"
        Cadena &= "<thead>"
        'Filas
        For Fila = 0 To dt.Rows.Count - 1
            Cadena &= "<Tr>"
            For Columna = 0 + Cols_Omitir_Izq To dt.Columns.Count - 1 - Cols_Omitir_Der
                Cadena &= "<Td style='border:solid 1px black; font-family:Arial; font-size:" & Tamaño & "'>"
                Cadena &= dt.Rows(Fila)(Columna).ToString
                Cadena &= "</Td>"
            Next
            Cadena &= "</Tr>"
        Next Fila
        Cadena &= "</Table>"
        Return Cadena
    End Function

    Public Shared Function fn_ListviewToHTML(ByVal lsv As cp_Listview, ByVal Titulo As String, ByVal Cols_Omitir_Izq As Integer, ByVal Cols_Omitir_Der As Integer) As String
        '"Prueba de Correo HTML.<Br><Table><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr><Tr><Td>Celda 1</Td><Td>Celda 2</Td></Tr></Table>"
        Dim Cadena As String = ""
        Dim Fila As Integer = 0
        Dim Columna As Integer = 0
        'Titulo
        Cadena = "<Table border=" & Chr(34) & 1 & Chr(34) & ">"
        Cadena &= "<CAPTION>"
        Cadena &= Titulo
        Cadena &= "</CAPTION>"
        'Encabezados
        Cadena &= "<thead>"
        Cadena &= "<tr>"
        Dim indice As Integer = 0
        For Each cl As ColumnHeader In lsv.Columns
            If indice >= Cols_Omitir_Izq Then
                If indice > (lsv.Columns.Count - 1 - Cols_Omitir_Der) Then Exit For
                Cadena &= "<th>"
                Cadena &= cl.Text
                Cadena &= "</th>"
            End If
            indice += 1
        Next
        Cadena &= "</tr>"
        Cadena &= "<thead>"
        'Filas
        For Each Elemento As ListViewItem In lsv.Items
            Cadena &= "<Tr>"
            For Columna = 0 + Cols_Omitir_Izq To lsv.Columns.Count - 1 - Cols_Omitir_Der
                Cadena &= "<Td>"
                Cadena &= Elemento.SubItems(Columna).Text
                Cadena &= "</Td>"
            Next
            Cadena &= "</Tr>"
        Next
        Cadena &= "</Table>"
        Return Cadena
    End Function

    Public Shared Function fn_ReducirImagen(ByVal Nombre As String, ByVal Imagen As Image, ByVal TamanoMax As Integer, ByVal Compresion As Integer, ByVal RutaTemp As String, ByVal AnchoDeseado As Integer, ByVal AltoDeseado As Integer) As String
        Dim Resulta1 As String = RutaTemp & Nombre & ".jpg"
        Dim Resulta2 As String = RutaTemp & Nombre & "_Copia.jpg"
        Try
            'Las imagenes que se crean y su nombre
            If System.IO.File.Exists(Resulta1) Then Kill(Resulta1)
            If System.IO.File.Exists(Resulta2) Then Kill(Resulta2)
        Catch
        End Try

        Try
            Dim ImagenLocal As Image = Imagen
            ImagenLocal.Save(Resulta1)

            ' Modifica el tamaño (dimensiones) de la imagen, para hacerse deben de tener un valor el Width (valor común 800px) y Height (valor común 600px)
            Dim AnchoFinal As Integer = 0
            Dim AltoFinal As Integer = 0

            'Modifica los valores de width y height dependiendo si la foto se toma vertical u horizontalmente
            If AnchoDeseado <> 0 Or AltoDeseado <> 0 Then
                If ImagenLocal.Width > ImagenLocal.Height Then
                    AnchoFinal = AnchoDeseado
                    AltoFinal = AltoDeseado
                Else
                    AnchoFinal = AltoDeseado
                    AltoFinal = AnchoDeseado
                End If

                If ImagenLocal.Width > AnchoFinal Or ImagenLocal.Height > AltoFinal Then
                    'Darle las dimensiones que deseen
                    Dim Redimencionar As New Bitmap(AnchoFinal, AltoFinal)
                    Dim g As Graphics = Graphics.FromImage(Redimencionar)
                    g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                    g.DrawImage(ImagenLocal, 0, 0, Redimencionar.Width, Redimencionar.Height)
                    ImagenLocal.Dispose()
                    Kill(Resulta1)
                    'Guardar la imagen en la ruta y nombre que se propocione
                    Redimencionar.Save(Resulta1, System.Drawing.Imaging.ImageFormat.Jpeg)
                    Redimencionar.Dispose()
                End If
            End If

            Dim Contador As Integer = 0
            Dim FileSize As Long
            FileSize = fn_TamañoArchivo(Resulta1)
            'Buscar el Codec para JPEG
            If FileSize > TamanoMax Then
                Dim iciJpegCodec As System.Drawing.Imaging.ImageCodecInfo = Nothing
                Dim iciCodecs As System.Drawing.Imaging.ImageCodecInfo() = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
                For i As Integer = 0 To iciCodecs.Length - 1
                    If iciCodecs(i).MimeType = "image/jpeg" Then
                        iciJpegCodec = iciCodecs(i)
                        Exit For
                    End If
                Next
                'Modificar el tamaño (kilobytes) de la imagen
                While FileSize > TamanoMax
                    Dim epQuality As New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, Compresion)
                    Dim epParameters As New System.Drawing.Imaging.EncoderParameters(1)
                    epParameters.Param(0) = epQuality
                    'Guardar la imagen modificada y Elimina la anterior
                    If System.IO.File.Exists(Resulta1) Then
                        ImagenLocal.Dispose()
                        ImagenLocal = Image.FromFile(Resulta1)
                        ImagenLocal.Save(Resulta2, iciJpegCodec, epParameters)
                        ImagenLocal.Dispose()
                        Kill(Resulta1)
                        ImagenLocal = Image.FromFile(Resulta2)
                        FileSize = fn_TamañoArchivo(Resulta2)
                    Else
                        ImagenLocal.Dispose()
                        ImagenLocal = Image.FromFile(Resulta2)
                        ImagenLocal.Save(Resulta1, iciJpegCodec, epParameters)
                        ImagenLocal.Dispose()
                        Kill(Resulta2)
                        ImagenLocal = Image.FromFile(Resulta1)
                        FileSize = fn_TamañoArchivo(Resulta1)
                    End If
                    If Contador >= 2 Then Exit While
                    Contador += 1
                End While
            End If

            ImagenLocal.Dispose()
            'Regresa la imagen
            If System.IO.File.Exists(Resulta1) Then
                Return Resulta1
            ElseIf System.IO.File.Exists(Resulta2) Then
                ImagenLocal = Image.FromFile(Resulta2)
                ImagenLocal.Save(Resulta1)
                ImagenLocal.Dispose()
                Kill(Resulta2)
                Return Resulta1
            Else
                Return ""
            End If
        Catch
            Return ""
        End Try
    End Function

    Public Shared Function fn_TamañoArchivo(ByVal Ruta) As Long
        Dim FileSize As Long = 0
        Try
            Dim MyFile As New System.IO.FileInfo(Ruta)
            FileSize = MyFile.Length
            Return FileSize
        Catch
            Return 0
        End Try
    End Function

    Public Shared Function fn_ValidarMail(ByVal sMail As String) As Boolean
        Return System.Text.RegularExpressions.Regex.IsMatch(sMail, "^([\w-]+\.)*?[\w-]+@[\w-]+\.([\w-]+\.)*?[\w]+$")
    End Function

    Public Shared Function fn_CalcularNombreFecha(ByRef Nombres As String, ByVal APaterno As String, ByVal AMaterno As String, ByVal FNacimiento As Date, ByRef ApellidoPat As String, ByRef ApellidoMat As String, ByRef Nombre As String) As String
        Dim Resultado As String

        Dim NombresNulos As String = "JOSE,MARIA,MA.,MA,DE,LA,LAS,MC,VON,DEL,LOS,Y,MAC,VAN"
        '--------------------------------------------------------------------------------------------------
        ' modificando la Ñ por la X By Herg 25/03/2014 (/ . -)
        Nombres = Nombres.Replace("Ñ", "X")
        APaterno = APaterno.Replace("Ñ", "X")
        AMaterno = AMaterno.Replace("Ñ", "X")

        'Quitando caracteres especiales 
        Dim ExpresionRegular As RegularExpressions.Regex = New RegularExpressions.Regex("[^a-zA-Z0-9 ]")
        Dim StringNormalizada As String
        'Nombres sin caracteres
        StringNormalizada = Nombres.Normalize(NormalizationForm.FormD)
        Nombres = ExpresionRegular.Replace(StringNormalizada, "")
        'Apellido Paterno sin caracteres
        If APaterno <> "" Then
            StringNormalizada = APaterno.Normalize(NormalizationForm.FormD)
            APaterno = ExpresionRegular.Replace(StringNormalizada, "")
        End If
        'Apellido Materno sin caracteres
        If AMaterno <> "" Then
            StringNormalizada = AMaterno.Normalize(NormalizationForm.FormD)
            AMaterno = ExpresionRegular.Replace(StringNormalizada, "")
        End If

        'Procesando Nombres y quitando nulos 
        Dim ArrayNombres() As String = Split(Nombres)
        For Each NombreValida As String In ArrayNombres
            If InStr(NombresNulos, NombreValida, CompareMethod.Text) = 0 And ArrayNombres.Count > 1 Then
                Nombre = NombreValida
                Exit For
            Else
                Nombre = NombreValida
            End If
        Next

        'ASIGNANDO LETRAS
        '------------------------------------------------------------------------------------------------------------
        Dim Primeraletra As String = ""
        Dim SegundaLetra As String = ""
        Dim TerceraLetra As String = ""
        Dim CuartaLetra As String = ""

        If APaterno <> "" And AMaterno <> "" Then 'En el Caso de que tenga los dos Apelldios

            'Procesando Apellido Paterno
            Dim ArrayApellidoPat() As String = Split(APaterno)

            For Each ApellidoPatValida As String In ArrayApellidoPat
                If InStr(NombresNulos, ApellidoPatValida, CompareMethod.Text) = 0 And ArrayApellidoPat.Count > 1 Then
                    ApellidoPat = ApellidoPatValida
                    Exit For
                Else
                    ApellidoPat = ApellidoPatValida
                End If
            Next

            'Procesando Apellido Materno
            Dim ArrayApellidoMat() As String = Split(AMaterno)

            For Each ApellidoMatValida As String In ArrayApellidoMat
                If InStr(NombresNulos, ApellidoMatValida, CompareMethod.Text) = 0 And ArrayApellidoMat.Count > 1 Then
                    ApellidoMat = ApellidoMatValida
                    Exit For
                Else
                    ApellidoMat = ApellidoMatValida
                End If
            Next

            'Extrayendo la primera letra del Apellido Paterno y la primera vocal(si aplica)
            Dim StrVocales As String = "A,E,I,O,U"
            Primeraletra = Mid(ApellidoPat, 1, 1)

            If Len(ApellidoPat) > 2 Then 'En el Caso que el Apellido Paterno sea Mayor de dos letras
                'Procesando Vocal
                For ILocal = 2 To Len(ApellidoPat)
                    If InStr(StrVocales, Mid(ApellidoPat, ILocal, 1), CompareMethod.Text) > 0 Then
                        SegundaLetra = Mid(ApellidoPat, ILocal, 1)
                        Exit For
                    End If
                Next
                TerceraLetra = Mid(ApellidoMat, 1, 1)
                CuartaLetra = Mid(Nombre, 1, 1)
            Else
                'Aplicando Regla "En los casos en que el apellido paterno de la persona física se componga
                'de una o dos letras, la clave se formará de la siguiente manera:
                '1. La primera letra del apellido paterno.
                '2. La primera letra del apellido materno.
                '3. La primera y segunda letra del nombre."
                SegundaLetra = Mid(ApellidoMat, 1, 1)
                TerceraLetra = Mid(Nombre, 1, 1)
                CuartaLetra = Mid(Nombre, 2, 1)
            End If
        Else '-> En el caso de que no cuente con alguno de los dos Apellidos
            'Aplicando Regla "En los casos en que la persona física tenga un solo apellido, se conformará
            'con la primera y segunda letras del apellido paterno o materno, según figure en el acta de nacimiento,
            'más la primera y segunda letras del nombre
            If APaterno = "" Then
                Dim ArrayApellidoMat() As String = Split(AMaterno)

                For Each ApellidoMatValida As String In ArrayApellidoMat
                    If InStr(NombresNulos, ApellidoMatValida, CompareMethod.Text) = 0 And ArrayApellidoMat.Count > 1 Then
                        ApellidoMat = ApellidoMatValida
                        Exit For
                    Else
                        ApellidoMat = ApellidoMatValida
                    End If
                Next
                Primeraletra = Mid(ApellidoMat, 1, 1)
                SegundaLetra = Mid(ApellidoMat, 2, 1)
            Else
                Dim ArrayApellidoPat() As String = Split(APaterno)

                For Each ApellidoPatValida As String In ArrayApellidoPat
                    If InStr(NombresNulos, ApellidoPatValida, CompareMethod.Text) = 0 And ArrayApellidoPat.Count > 1 Then
                        ApellidoPat = ApellidoPatValida
                        Exit For
                    Else
                        ApellidoPat = ApellidoPatValida
                    End If
                Next
                Primeraletra = Mid(ApellidoPat, 1, 1)
                SegundaLetra = Mid(ApellidoPat, 2, 1)
            End If
            TerceraLetra = Mid(Nombre, 1, 1)
            CuartaLetra = Mid(Nombre, 2, 1)
        End If

        'Procesando Fecha de Nacimiento------------------------------------------------------------------------------
        Dim FechaNac As String
        Dim AñoNac As String
        Dim MesNac As String
        Dim DiaNac As String

        AñoNac = DatePart(DateInterval.Year, FNacimiento)
        'Quitando los dos primeros caracteres del año
        AñoNac = Mid(AñoNac, 3, 2).PadLeft(2, "0")
        MesNac = DatePart(DateInterval.Month, FNacimiento)
        MesNac = MesNac.PadLeft(2, "0")
        DiaNac = DatePart(DateInterval.Day, FNacimiento)
        DiaNac = DiaNac.PadLeft(2, "0")
        FechaNac = AñoNac & MesNac & DiaNac

        Resultado = Primeraletra + SegundaLetra + TerceraLetra + CuartaLetra

        'Verificamos si se forma alguna palablra "Inconveniente" con las 4 letras del RFC
        Dim STrInconvenientes As String = "BUEI,CACA,CAGA,CAKA,COGE,COJE,COJO,FETO,JOTO,KACO,KAGO,KOJO,KULO,MAMO,MEAS,MION,MULA," & _
        "PEDO,PUTA,QULO,RUIN,BUEY,CACO,CAGO,CAKO,COJA,COJI,CULO,GUEY,KACA,KAGA,KOGE,KAKA,MAME," & _
        "MEAR,MEON,MOCO,PEDA,PENE,PUTO,RATA"

        If InStr(STrInconvenientes, Resultado, CompareMethod.Text) > 0 Then
            Resultado = Primeraletra + SegundaLetra + TerceraLetra + "X" + FechaNac
        Else
            Resultado = Primeraletra + SegundaLetra + TerceraLetra + CuartaLetra + FechaNac
        End If

        Resultado = UCase(Resultado)
        Return Resultado
    End Function

    Public Shared Function fn_CalcularRFC(ByVal Nombres As String, ByVal APaterno As String, ByVal AMaterno As String, ByVal FNacimiento As Date) As String
        '-------------------------------------------------------------------------------------------------------------
        Dim ApellidoPat As String = ""
        Dim ApellidoMat As String = ""
        Dim NombreUsar As String = ""
        Dim RFC As String = fn_CalcularNombreFecha(Nombres, APaterno, AMaterno, FNacimiento, ApellidoPat, ApellidoMat, NombreUsar)
        '-------------------------------------------------------------------------------------------------------------

        'Proceso de conversión de letras a números
        Dim nombreEnNumero As Integer = 0 'Guardara el nombre en su correspondiente numérico
        Dim valorSumas As Long = 0 'La suma de la secuencia de números de nombreEnNumero

        'Procesando Nombre Numerico
        Dim AnexoII As String = "&ABCDEFGHI_JKLMNOPQR__STUVWXYZÑ" 'Valores del Anexo II
        Dim NombreCompleto As String
        If APaterno <> "" And AMaterno <> "" Then
            NombreCompleto = ApellidoPat & " " & ApellidoMat & " " & Nombres
        Else
            If APaterno = "" Then
                NombreCompleto = ApellidoMat & " " & Nombres
            Else
                NombreCompleto = ApellidoPat & " " & Nombres
            End If
        End If
        'convirtiendo nombre a numeros
        Dim ValorAcumulado As String = ""
        For ILocal = 1 To Len(NombreCompleto)
            If InStr(AnexoII, Mid(NombreCompleto, ILocal, 1), CompareMethod.Text) = 0 Then
                ValorAcumulado = ValorAcumulado & "00"
            Else
                ValorAcumulado = ValorAcumulado & (InStr(AnexoII, Mid(NombreCompleto, ILocal, 1), CompareMethod.Text) + 9)
            End If
        Next
        'Se agrega un cero al valor de la primera letra para uniformar el criterio de los números a tomar de dos en dos
        ValorAcumulado = "0" + ValorAcumulado
        'Se efectuaran las multiplicaciones de los números tomados de dos en dos para la posición de la pareja
        'Se suma el resultado de las multiplicaciones y del resultado obtenido, se tomaran las tres ultimas cifras
        'y estas se dividen entre el factor 34, por que 34?, no lo se, si alguien lo sabe
        'que me lo diga jeje, pero en fin, asi nos lo dicen nuestros amigos de la SHCP, lo hice por acto de fe
        Dim Suma As Double
        Dim x As String
        Dim y As String

        For ILocal = 1 To Len(ValorAcumulado) - 1
            x = Mid(ValorAcumulado, ILocal, 2)
            y = Mid(x, 2, 1)
            Suma = Suma + (x * y)
        Next
        'De la suma obtenemos los 3 últimos numeros
        Suma = Microsoft.VisualBasic.Right(Suma, 3)
        'Obtenemos el cociente de la "Suma" dividiendo por el factor 34
        Dim VarCociente As Double = Int(Suma / 34)
        'Después calculamos el residuo
        Dim VarResiduo As Double = Suma Mod 34
        'Con el cociente y el residuo se asigna la homonimia
        Dim AsignaHomonimas As String = "123456789ABCDEFGHIJKLMNPQRSTUVWXYZ"
        Dim PrimeraHomonima As String = Mid(AsignaHomonimas, VarCociente + 1, 1)
        Dim SegundaHomonimas As String = Mid(AsignaHomonimas, VarResiduo + 1, 1)

        'Concatenarle al RFC las Homonimas (sólo falta calcular el digito verificador)
        RFC = RFC & PrimeraHomonima & SegundaHomonimas

        'Procedimiento para calcular el digito verificador
        '--------------------------------------------------------------------------------------------------------------------------------
        'Se asignaran los valores del Anexo III a las letras y números del registro federal de contribuyentes formado a 12 posiciones
        'Una vez asignados los valores se aplicara la siguiente forma tomando como base el factor 13 en orden descendente
        'a cada letra y número del R.F.C. para su multiplicación, de acuerdo a la siguiente formula:
        '(Vi * (Pi + 1)) + (Vi * (Pi + 1)) + ..............+ (Vi * (Pi + 1)) MOD 11
        Dim Vi As Integer 'Valor asociado al carácter de acuerdo a la tabla del Anexo III.
        Dim Pi As Integer 'Posición que ocupa el i-esimo carácter tomando de derecha a izquierda es decir P toma los valores de 1 a 12

        Dim AnexoIII As String = "123456789ABCDEFGHIJKLMN&OPQRSTUVWXYZ Ñ" 'Valores del Anexo III
        Dim SumaVerificador As Double
        For ILocal = 1 To 12
            Pi = 14 - ILocal
            If InStr(AnexoIII, Mid(RFC, ILocal, 1), CompareMethod.Text) = 0 Then
                Vi = 0
            Else
                Vi = (InStr(AnexoIII, Mid(RFC, ILocal, 1), CompareMethod.Text))
            End If
            SumaVerificador = SumaVerificador + (Vi * Pi)
        Next

        Dim ResiduoVerif As Double = SumaVerificador Mod 11
        Dim DigitoVerif As String = ""
        'Si el residuo es igual a cero, este será el valor que se le asignara al dígito verificador.
        'Si el residuo es mayor a cero se restara este al factor 11
        'Si el residuo es igual a 10 el dígito verificador será “ A”.
        Select Case ResiduoVerif
            Case Is = 0
                DigitoVerif = 0
            Case Is > 0
                DigitoVerif = 11 - ResiduoVerif
                If DigitoVerif = 10 Then
                    DigitoVerif = "A"
                End If
            Case Is = 10
                DigitoVerif = "A"
        End Select

        RFC = RFC & DigitoVerif
        Return RFC
    End Function

    Public Shared Function fn_CalcularCUPR(ByVal Nombres As String, ByVal APaterno As String, ByVal AMaterno As String, ByVal FNacimiento As Date, ByVal Sexo As Char, ByVal LugarNacimiento As String) As String
        '-------------------------------------------------------------------------------------------------
        Dim ApellidoPat As String = ""
        Dim ApellidoMat As String = ""
        Dim NombreUsar As String = ""
        Dim CURP As String = fn_CalcularNombreFecha(Nombres, APaterno, AMaterno, FNacimiento, ApellidoPat, ApellidoMat, NombreUsar)
        '-------------------------------------------------------------------------------------------------

        'Se agrega H por Hombre y M por Mujer
        'LugarNacimiento es el Prefijo del Estado
        CURP = CURP & Sexo & LugarNacimiento

        'Las 3 letras siguientes son las primeras consonantes internas del
        'apellido paterno, apellido materno y del nombre de pila.
        Dim StrConsonantes As String = "B,C,D,F,G,H,J,K,L,M,N,Ñ,P,Q,R,S,T,V,W,X,Y,Z"
        Dim LetraCatorce As String = ""
        Dim LetraQuince As String = ""
        Dim LetraDieciseis As String = ""
        'Procesando Constante del Apellido Paterno
        For ILocal = 2 To Len(ApellidoPat)
            If InStr(StrConsonantes, Mid(ApellidoPat, ILocal, 1), CompareMethod.Text) > 0 Then
                LetraCatorce = Mid(ApellidoPat, ILocal, 1)
                Exit For
            End If
        Next
        'Procesando Constante del Apellido Materno
        For ILocal = 2 To Len(ApellidoMat)
            If InStr(StrConsonantes, Mid(ApellidoMat, ILocal, 1), CompareMethod.Text) > 0 Then
                LetraQuince = Mid(ApellidoMat, ILocal, 1)
                Exit For
            End If
        Next

        'Procesando Constante del Nombre
        For ILocal = 2 To Len(NombreUsar)
            If InStr(StrConsonantes, Mid(NombreUsar, ILocal, 1), CompareMethod.Text) > 0 Then
                LetraDieciseis = Mid(NombreUsar, ILocal, 1)
                Exit For
            End If
        Next

        CURP = CURP & LetraCatorce & LetraQuince & LetraDieciseis

        'La Homoclave se le asigna el valor 0 (Cero) cuando son nacidos antes del 2000
        'y una A a los nacidos después del 2000 (puede ser de la A hasta la Z 
        'pero pues eso si ya no se, como dicen con pura fé y ojala sale bien)
        Dim AñoNac As Integer = DatePart(DateInterval.Year, FNacimiento)
        If AñoNac < 2000 Then
            CURP = CURP & "0"
        Else
            CURP = CURP & "A"
        End If

        'AnexoI serán todos los Valores para luego convertir la CURP a numérico
        Dim AnexoI As String = "0123456789ABCDEFGHIJKLMNÑOPQRSTUVWXYZ"
        'Arreglo para guardar los valores resultantes de la conversión de las letras a numérico
        Dim intFactor(16) As Integer

        Dim lngSuma As Long = 0.0
        Dim lngDigito As Long = 0.0

        'Ciclo donde Revisa cada valor del CURP y lo va comparando según la posición encontrada en AnexoI
        'Dando su valor numérico a cada uno guardandolo en el arreglo intFactor
        For ILocal As Integer = 1 To 17
            For JLocal As Integer = 1 To 37
                If Mid(CURP, ILocal, 1) = Mid(AnexoI, JLocal, 1) Then
                    intFactor(ILocal - 1) = JLocal - 1
                    Exit For
                End If
            Next
        Next

        'Luego para cada valor en intFactor se sumara para obtener el dígito verificador
        For KLocal As Integer = 0 To 16
            lngSuma = lngSuma + ((intFactor(KLocal)) * (18 - KLocal))
        Next

        'Con la suma se obtiene su residuo
        lngDigito = 10 - (lngSuma Mod 10)

        'Como el valor es de un sólo dígito si es 10 el resultado se pone cero
        If lngDigito = 10 Then
            lngDigito = 0
        End If

        CURP = CURP & lngDigito.ToString

        Return CURP
    End Function

    Public Shared Function fn_ArchivosPath(ByVal Remplazar As String) As String
        'Regresa el Path de la ubicación donde estará el archivo, esto debido a que cuando se ejecuta en debug,
        'release o una aplicación publicada la ubicación de la aplicación (.exe) cambia.
        Try
            Dim Exe As String = Application.StartupPath
            If InStr(Exe, "bin\Debug") > 0 Then
                Return Replace(Exe, "bin\Debug", Remplazar) 'Ejecutando en Debug
            ElseIf InStr(Exe, "bin\Release") > 0 Then
                Return Replace(Exe, "bin\Release", Remplazar) 'Ejecutando en Release
            Else
                Exe &= "\" & Remplazar 'Ejecutando Directamente
                Return Exe
            End If
        Catch
            Return ""
        End Try
    End Function

    Public Shared Function fn_NumRegistros(ByVal Label As Label, ByVal NumeroDFilas As Integer) As Boolean
        Label.Text = "Registros: " & NumeroDFilas.ToString
    End Function


    Public Shared Function fn_OrdenaTabla(ByVal dt As DataTable, ByVal Columa_Orden As String) As DataTable
        Dim Seleccione As Boolean = False

        If dt.Rows(0)(1).ToString.ToUpper = "SELECCIONE..." Then
            Seleccione = True
            dt.Rows.RemoveAt(0)
        End If

        Dim Vista As New DataView
        Vista = dt.DefaultView
        Vista.Sort = Columa_Orden 'ColumnaAordenar Orden 
        dt = Vista.ToTable

        If Seleccione Then
            Dim dr As DataRow = dt.NewRow
            dr("Value") = "0"
            dr("Display") = "Seleccione..."
            dt.Rows.InsertAt(dr, 0)
        End If

        Return dt

    End Function


    Public Shared Function fn_ValidaPermisoControl(ByVal Control As String) As Boolean
        Dim Correcto As Boolean = False

        If UsuarioTipo = 2 Or UsuarioTipo = 4 Then
            'si es usuario tipo Administrador Local    o   Administrador Global, tiene acceso a todo
            Correcto = True

        ElseIf Control Is Nothing OrElse Control.Trim = "" Then
            'Si el control no tiene Tag, es accesible por todos los usuarios
            Correcto = True

        ElseIf CadenaPermisosControles = "--" Then
            'Si es "--", es porque el Submenu no tiene Tag por lo que el usuario tiene acceso a todo
            Correcto = True
        End If

        'Busca el Control en los permisos de controles que tiene el usuario firmado
        If Correcto Or InStr(CadenaPermisosControles, Control) Then
            Correcto = True
        Else
            Correcto = False
        End If

        If Not Correcto Then
            ' cn_Mensajes.fn_UltimaActividad("Usted no tiene acceso a ésta función.")
            MsgBox("Acceso Denegado, Usted no tiene acceso a ésta opción, si necesita privilegios consulte a su administrador de sistemas.")
        End If

        Return Correcto

    End Function

End Class
