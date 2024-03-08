Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Imports System.IO
Imports System.Drawing
Imports Modulo_Reclutamiento.Cn_Reclutamiento
Public Class frm_CredencialesActualizar

    Enum Alineacion
        Centrado = 4
        Izquierda = 5
        Derecha = 6
    End Enum

    'ZBRGraphics.dll imports   
  
    'Funciones de guardado de Gráficas
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIInitGraphics", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIInitGraphics(ByVal strPrinterName As Byte(), ByRef HDC As IntPtr, ByRef err As Integer) As Integer
    End Function

    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIPrintGraphics", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIPrintGraphics(ByVal hDC As IntPtr, ByRef err As Integer) As Integer
    End Function

    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDICloseGraphics", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDICloseGraphics(ByVal hDC As IntPtr, ByRef err As Integer) As Integer
    End Function

    'Funciones de Dibujado
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawImageRect", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawImageRect(ByVal fileName As Byte(), ByVal x As Integer, ByVal y As Integer, _
                                               ByVal width As Integer, ByVal height As Integer, ByRef err As Integer) As Integer
    End Function
   
    'Funcion para Texto en cuadro
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawTextRect", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawTextRect(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, _
                                           ByVal alignment As Integer, ByVal text As Byte(), ByVal font As Byte(), ByVal fontSize As Integer, _
                                           ByVal fontStyle As Integer, ByVal color As Integer, ByRef err As Integer) As Integer
    End Function
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawRectangle", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawRectangle(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, _
                                                ByVal height As Integer, ByVal thickness As Single, ByVal color As Integer, _
                                                ByRef err As Integer) As Integer
    End Function
    Public Shared Function ImageToByteArray(ByVal filename As String) As Byte()
        Dim ms As New MemoryStream()
        Dim img As Image = System.Drawing.Image.FromFile(filename)
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
        Dim arr As Byte() = ms.ToArray()
        ms = Nothing
        Return arr
    End Function

    Dim hDC As IntPtr = IntPtr.Zero
    Dim err As Integer = 0
    Dim fontSize As Integer
    Dim fontBold As Integer = &H1
    Dim fontColor As Integer = &H0
    'Dim printerName As String = "Enviar a OneNote 2007"
    Dim printerName As String = "Zebra ZXP Series 3 USB Card Printer"
    Dim Path As String = "C:\SIAC\SIAC\Modulos\Modulo_Reclutamiento\Resources\"
    Dim Ruta As String = "C:\SIAC\SIAC\Modulos\Modulo_Reclutamiento\bin\Debug\"
    Dim Numero_Firma As String = "N"
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("UltimaValidacion")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

    End Sub

    Sub Imprimir()
        SegundosDesconexion = 0
        For Each Elem As ListViewItem In lsv_Catalogo.CheckedItems
            Dim dr_Credenciales As DataRow = fn_Credenciales_ObtenValoresZebra(Elem.Tag, "E")
            If Not dr_Credenciales Is Nothing Then
                Dim ascii As New ASCIIEncoding()
                Dim prnDriver As Byte() = ascii.GetBytes(printerName)
                Dim Fuente As Byte() = ascii.GetBytes("Arial")
                ' ************************TEXTO*********************
                Try

                    If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                        MsgBox("Ha Ocurrido un Error de Conexion con la Impresora ", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    ' ''FONDO GUIA
                    'Dim ImageG As String
                    'Dim xCoordG As Integer = 0
                    'Dim yCoordG As Integer = 0
                    'Dim widthG As Integer = 648
                    'Dim heightG As Integer = 1015
                    'Dim fNameG As Byte()
                    'ImageG = (Path & "guia.JPG")
                    'fNameG = ascii.GetBytes(ImageG)
                    'If (ZBRGDIDrawImageRect(fNameG, xCoordG, yCoordG, widthG, heightG, err) = 0) Then
                    '    'error drawing image into buffer
                    '    ascii = Nothing
                    '    ZBRGDICloseGraphics(hDC, err)
                    '    'exit
                    '    MsgBox("Ha Ocurrido un Error, al Imprimir la Imagen de Fondo." & err.ToString())
                    '    Exit Sub
                    'End If

                    '***********************************************************************************
                    '****************************IMAGENES************************

                    'Draw an image into the buffer:

                    Dim Imagen As String
                    Dim xCoord As Integer = 5
                    Dim yCoord As Integer = 70
                    Dim width As Integer = 160
                    Dim height As Integer = 130
                    Dim fName As Byte()

                    '***************************Imagen de SISSA********************************
                    Imagen = (Path & "LogoSISSAZebra.JPG")
                    fName = ascii.GetBytes(Imagen)
                    If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                        'error drawing image into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        'exit
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Logotipo de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If


                    '************************************BANDA DORADA DE SISSA SUPERIOR***************************

                    Dim Color As Integer = &HC0A062 '&H0
                    Dim thickness As Single = 80
                    Dim Nombre_Empresa As Byte()
                    xCoord += 210
                    yCoord += 40
                    width = 395
                    height = 55
                    If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                        MsgBox("Error al crear rectangulo de color", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                    '********************************NOMBRE COMPLETO DE SISSA

                    fontSize = 10
                    xCoord -= 55
                    yCoord -= 20
                    width = 500
                    height = 95
                    fontColor = &H0
                    Nombre_Empresa = ascii.GetBytes("Servicio Integral de Seguridad, S.A. de C.V.")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, 500, 95, Alineacion.Centrado, Nombre_Empresa, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    '************************BANDA DORADA DE SISSA INFERIOR******************************
                    xCoord = 0
                    yCoord += 830
                    width = 610
                    height = 75
                    If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                        MsgBox("Error al crear rectangulo de color.", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If

                    '*********TITULO DE NOMINA Y FIRMA**************************
                    Dim Nomina As Byte()
                    Dim Firma As Byte()
                    Dim Clave As Byte()
                    Dim FirmaNum As Byte()
                    Dim Ingreso As Byte()
                    xCoord = 190
                    yCoord = 215
                    width = 400
                    height = 100
                    fontSize = 6
                    fontColor = &HFF0000
                    Nomina = ascii.GetBytes("NOMINA:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Nomina, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord += 110
                    yCoord -= 8
                    fontSize = 9
                    fontColor = &H0
                    Clave = ascii.GetBytes(dr_Credenciales("Clave"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Clave, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Clave del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    If Numero_Firma = "S" Then
                        xCoord += 130
                        yCoord += 10
                        fontSize = 6
                        fontColor = &HFF0000
                        Firma = ascii.GetBytes("FIRMA:")
                        If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Firma, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                            'error drawing text into buffer
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        xCoord += 95
                        yCoord -= 8
                        fontSize = 9
                        fontColor = &H0
                        FirmaNum = ascii.GetBytes("2305")
                        If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, FirmaNum, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                            'error drawing text into buffer
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If
                        xCoord -= 225
                    End If
                    xCoord -= 125
                    yCoord += 60
                    fontSize = 6
                    fontColor = &HFF0000
                    Ingreso = ascii.GetBytes("INGRESO:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Ingreso, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord += 130
                    yCoord -= 5
                    width += 20
                    fontSize = 8
                    fontColor = &H0
                    Ingreso = ascii.GetBytes(dr_Credenciales("Ingreso"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Ingreso, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    '*****************************Imagen del Empleado*******************************
                    xCoord = 160
                    yCoord = 300
                    width = 340 '378
                    height = 355
                    Using fs As New FileStream(Ruta & "Foto.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(dr_Credenciales("Frente"), 0, dr_Credenciales("Frente").Length)
                        fs.Flush()
                        fs.Close()
                    End Using
                    fName = ascii.GetBytes(Ruta & "Foto.JPG")
                    If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        'exit
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Foto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    '**********************************************************************************************
                    '********************************TEXTO PARA LA TARJETA***************************
                    Dim Empleado As Byte()
                    Dim Departamento As Byte()
                    Dim Puesto As Byte()
                    Dim Expedida As Byte()
                    Dim Expira As Byte()
                    Dim ExpedidaTit As Byte()
                    Dim ExpiraTit As Byte()

                    xCoord -= xCoord
                    yCoord += 378  '370
                    width = 648 '270
                    height -= 290
                    fontSize = 9
                    fontColor = &H0
                    Empleado = ascii.GetBytes(dr_Credenciales("Apellidos"))
                    If Empleado.Length > 26 Then
                        fontSize = 8
                        height += 670
                    End If

                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Empleado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    yCoord += 90
                    Puesto = ascii.GetBytes(dr_Credenciales("Puesto"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Puesto, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Puesto del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    yCoord += 50
                    Departamento = ascii.GetBytes(dr_Credenciales("Departamento"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Departamento, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Departamento del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    fontSize = 6
                    fontColor = &HFF0000
                    xCoord += 10
                    yCoord += 75 '115
                    ExpedidaTit = ascii.GetBytes("EXPEDIDA:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, ExpedidaTit, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Fecha de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    fontColor = &H0
                    fontSize = 8
                    xCoord += 140
                    yCoord -= 6
                    width -= 460
                    Expedida = ascii.GetBytes(Date.Today)
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Expedida, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Fecha de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    fontSize = 6
                    fontColor = &HFF0000
                    xCoord += 200
                    yCoord += 5
                    ExpiraTit = ascii.GetBytes("EXPIRA:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, ExpiraTit, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Fecha de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    fontColor = &H0
                    fontSize = 8
                    xCoord += 105
                    yCoord -= 6
                    Expira = ascii.GetBytes(dtp_FechaExpira.Value.Date)
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Expira, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Fecha de Expiración", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord -= xCoord
                    yCoord += 50
                    width = 648
                    height = 60
                    Using fs As New FileStream(Ruta & "Barra.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(dr_Credenciales("Codigo"), 0, dr_Credenciales("Codigo").Length)
                        fs.Flush()
                        fs.Close()
                    End Using
                    fName = ascii.GetBytes(Ruta & "Barra.JPG")
                    If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        'exit
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Codigo de Barra del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    '************************TERMINA TEXTO DE LA TARJETA**********************************

                    ' ***********************Imprime todo lo que contenga el Buffer***********************
                    If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                        'error printing buffer
                        MsgBox("Ocurrio un Error al Imprimir las Tarjetas", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    '  *********************************************************************************

                    If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                        MsgBox("Ha Ocurrido un Error", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    ascii = Nothing
                    If File.Exists(Ruta & "Foto.JPG") Then
                        File.Delete(Ruta & "Foto.JPG")
                        File.Delete(Ruta & "Barra.JPG")
                    End If
                Catch Ex As Exception
                    MsgBox(Ex.Message)
                End Try
            Else
                MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Next


    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpFrente.Click
        Call Imprimir()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImpAtras.Click
        SegundosDesconexion = 0
        For Each Elem As ListViewItem In lsv_Catalogo.CheckedItems
            Dim dr_Credenciales As DataRow = fn_Credenciales_ObtenValoresZebra(Elem.Tag, "E")
            If Not dr_Credenciales Is Nothing Then
                Dim ascii As New ASCIIEncoding()
                Dim prnDriver As Byte() = ascii.GetBytes(printerName)
                Dim Fuente As Byte() = ascii.GetBytes("Arial")

                Try
                    ' *********************************Inicia Parte Trasera**********************************************
                    'Iniciar las Graficas
                    If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                        MsgBox("Ha Ocurrido un Error de Conexion con la Impresora ", MsgBoxStyle.Critical, frm_MENU.Text)
                        Me.Close()
                        Exit Sub
                    End If

                    '***********************************************************************************
                    '****************************IMAGENES************************

                    'Dibuja una Imagen en el Buffer:


                    ' ''FONDO GUIA
                    'Dim ImageG As String
                    'Dim xCoordG As Integer = 0
                    'Dim yCoordG As Integer = 0
                    'Dim widthG As Integer = 648
                    'Dim heightG As Integer = 1015
                    'Dim fNameG As Byte()
                    'ImageG = (Path & "guia.JPG")
                    'fNameG = ascii.GetBytes(ImageG)
                    'If (ZBRGDIDrawImageRect(fNameG, xCoordG, yCoordG, widthG, heightG, err) = 0) Then
                    '    'error drawing image into buffer
                    '    ascii = Nothing
                    '    ZBRGDICloseGraphics(hDC, err)
                    '    'exit
                    '    MsgBox("Ha Ocurrido un Error, al Imprimir la Imagen de Fondo." & err.ToString())
                    '    Exit Sub
                    'End If

                    '********************************Texto******************************************
                    Dim xCoord As Integer = 130
                    Dim yCoord As Integer = 70
                    Dim width As Integer = 100
                    Dim height As Integer = 50
                    Dim Curp As Byte()
                    Dim Cuip As Byte()
                    Dim Sangre As Byte()
                    Dim Seguro As Byte()
                    Dim Encabezado As Byte()
                    Dim Autoriza As Byte()
                    Dim fname As Byte()

                    'Negro
                    fontSize = 6
                    fontColor = &HFF0000
                    Curp = ascii.GetBytes("CURP:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Curp, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la CURP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord += 85
                    yCoord -= 5
                    width += 500
                    height += 200
                    fontSize = 8
                    fontColor = &H0
                    Curp = ascii.GetBytes(dr_Credenciales("CURP"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Curp, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir la CURP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord -= 75
                    yCoord += 40
                    fontSize = 6
                    fontColor = &HFF0000
                    Cuip = ascii.GetBytes("CUIP:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Cuip, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord += 75
                    yCoord -= 5
                    fontSize = 8
                    fontColor = &H0
                    Cuip = ascii.GetBytes(dr_Credenciales("Cuip"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Cuip, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord -= 185
                    yCoord += 40
                    fontSize = 6
                    fontColor = &HFF0000
                    Sangre = ascii.GetBytes("TIPO SANGRE:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord += 190
                    yCoord -= 5
                    fontSize = 8
                    fontColor = &H0
                    Sangre = ascii.GetBytes(dr_Credenciales("Sangre"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord -= 190
                    yCoord += 40
                    fontSize = 6
                    fontColor = &HFF0000
                    Seguro = ascii.GetBytes("NUM.SEGURO:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Seguro, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord += 190
                    yCoord -= 5
                    fontSize = 8
                    fontColor = &H0
                    Seguro = ascii.GetBytes(dr_Credenciales("Seguro"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Seguro, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    '**************AQUI SE HARA UN FOR DE UNA FUNCION QUE TRAE LAS ARMAS DEL EMPLEADO******************
                    Dim dr_Armas As DataTable = fn_Credenciales_ObtenValoresZebraArmas(Elem.Tag)
                    If Not dr_Armas Is Nothing Then

                        xCoord = 20
                        ' yCoord += 300
                        yCoord = 500
                        fontSize = 5
                        width += 30
                        fontColor = &HFF0000
                        Encabezado = ascii.GetBytes("TIPO       CALIBRE       MARCA       MODELO       MATRICULA")
                        If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                            'error drawing text into buffer
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            MsgBox("Ha Ocurrido un Error, al Imprimir la Cabezera de Armas.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If

                        For Each Row As DataRow In dr_Armas.Rows
                            xCoord = 10
                            yCoord += 30
                            fontColor = &H0
                            fontSize = 4
                            Encabezado = ascii.GetBytes(Row("Tipo"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir el Tipo de Arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Calibre"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir el Calibre del Arma", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Marca"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir la Marca del Arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Modelo"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir el Modelo del Arma", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 130
                            Encabezado = ascii.GetBytes(Row("Matricula"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir la Matricula del Arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord -= 490
                        Next
                        yCoord = 470
                    Else
                        xCoord = 20
                        yCoord += 300 '270
                    End If

                    '*******************************************************************************************
                    yCoord += 130 '200
                    fontSize = 6
                    fontColor = &HFF0000
                    Autoriza = ascii.GetBytes("AUTORIZA:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Autoriza, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    fontSize = 7
                    fontColor = &H0
                    xCoord -= xCoord
                    yCoord += 30

                    If dr_Credenciales("Autoriza").ToString.Length > 22 Then fontSize = 7
                    Autoriza = ascii.GetBytes(dr_Credenciales("Autoriza"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Autoriza, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el CUIP del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    '******************BANDA DORADA SISSA INFERIOR TRASERA
                    Dim Color As Integer = &HC0A062 '&H0
                    Dim thickness As Single = 80
                    Dim Leyenda As Byte()
                    yCoord += 290 '240
                    width = 610
                    height = 75
                    If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                        MsgBox("Error al crear rectangulo de color", MsgBoxStyle.Critical)
                    End If
                    xCoord = 0
                    yCoord -= 35
                    width += 50 '48
                    height += 20
                    fontColor = &H0
                    fontSize = 5
                    Leyenda = ascii.GetBytes("ESTE GAFETE ES PROPIEDAD DE")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Puesto del Empleado", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    yCoord += 30
                    Leyenda = ascii.GetBytes("SERVICIO INTEGRAL DE SEGURIDAD, S.A. DE C.V.")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Puesto del Empleado", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    yCoord += 30
                    Leyenda = ascii.GetBytes("ALVAREZ 209 NTE, COL CENTRO, MONTERREY, N.L.")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Puesto del Empleado", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    yCoord += 30
                    Leyenda = ascii.GetBytes("TELEFONO (81)8047-4545")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir el Puesto del Empleado", MsgBoxStyle.Critical)
                        Exit Sub
                    End If


                    ''*****************************Firma del Empleado*******************************
                    xCoord = (648 - 345) / 2
                    yCoord = 240 '270
                    width = 345 '176
                    height = 206 '176
                    If Not IsDBNull(dr_Credenciales("Firma")) Then
                        Using fs As New FileStream(Ruta & "Firma.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(dr_Credenciales("Firma"), 0, dr_Credenciales("Firma").Length)
                            fs.Flush()
                            fs.Close()
                        End Using

                        fname = ascii.GetBytes(Ruta & "Firma.JPG")
                        If (ZBRGDIDrawImageRect(fname, xCoord, yCoord, width, height, err) = 0) Then
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            'exit
                            MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Empleado." & err.ToString())
                            Exit Sub
                        End If
                    Else
                        MsgBox("El Empleado " & dr_Credenciales("Apellidos") & "No tiene Firma. ", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                    yCoord += 430 '400
                    width = 345
                    height = 206
                    '********************FIRMA DE QUIEN AUTORIZA****************************************
                    If Not IsDBNull(dr_Credenciales("FirmaAutoriza")) Then
                        Using fs As New FileStream(Ruta & "FirmaAutoriza.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                            fs.Write(dr_Credenciales("FirmaAutoriza"), 0, dr_Credenciales("FirmaAutoriza").Length)
                            fs.Flush()
                            fs.Close()
                        End Using

                        fname = ascii.GetBytes(Ruta & "FirmaAutoriza.JPG")
                        If (ZBRGDIDrawImageRect(fname, xCoord, yCoord, width, height, err) = 0) Then
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            'exit
                            MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Empleado." & err.ToString())
                            Exit Sub
                        End If
                    Else
                        MsgBox("El Empleado " & dr_Credenciales("Apellidos") & "No tiene Firma. ", MsgBoxStyle.Critical, frm_MENU.Text)
                    End If
                    'Dibuja el Texto en el Buffer:

                    ' ***********************Imprime todo lo que contenga el Buffer***********************
                    If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                        'error printing buffer
                        MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    '  *********************************************************************************
                    If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                        MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical)
                        Exit Sub
                    End If
                    ascii = Nothing
                    If File.Exists(Ruta & "Firma.JPG") Then
                        File.Delete(Ruta & "Firma.JPG")
                        File.Delete(Ruta & "FirmaAutoriza.JPG")
                    End If

                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Else
                MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

        Next
    End Sub

    Private Sub btn_MostrarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarCatalogo.Click
        If cmb_DepartamentoFiltro.SelectedValue Is Nothing Then Exit Sub
        If cmb_PuestoFiltro.SelectedValue Is Nothing Then Exit Sub

        If cmb_DepartamentoFiltro.Enabled AndAlso cmb_DepartamentoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DepartamentoFiltro.Focus()
            Exit Sub
        End If
        If cmb_PuestoFiltro.Enabled AndAlso cmb_PuestoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PuestoFiltro.Focus()
            Exit Sub
        End If
        If Not fn_Empleados_LlenarLista(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, "A") Then
            MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If lsv_Catalogo.Items.Count = 0 Then
            btn_ImpFrente.Enabled = False
            btn_ImpAtras.Enabled = False
        Else
            btn_ImpFrente.Enabled = True
            btn_ImpAtras.Enabled = True
        End If
        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        'Llenar los Puestos
        lsv_Catalogo.Items.Clear()
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 AndAlso Not chk_DepartamentoFiltro.Checked Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_DepartamentoFiltro.SelectedValue = 0
        cmb_DepartamentoFiltro.Enabled = Not chk_DepartamentoFiltro.Checked

        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 AndAlso Not chk_DepartamentoFiltro.Checked Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_ImpFrente.Enabled = True
            btn_ImpAtras.Enabled = True
        Else
            btn_ImpFrente.Enabled = False
            btn_ImpAtras.Enabled = False
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub
End Class
