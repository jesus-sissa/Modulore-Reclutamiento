Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_GafeteImprimirPlant
    Enum Alineacion
        Centrado = 4
        Izquierda = 5
        Derecha = 6
    End Enum

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
                                                ByRef Err As Integer) As Integer
    End Function


    '------------Variables de ZEBRA---------------
    Dim hDC As IntPtr = IntPtr.Zero
    Dim err As Integer = 0
    Dim fontSize As Integer
    Dim fontBold As Integer = &H1
    Dim fontColor As Integer = &H0
    Dim printerName As String
    Dim Ruta As String = "C:\Siac\Temporales\"

    Private Clave_PlantGafeteProvF As String
    Private Clave_PlantGafeteProvR As String
    Private Clave_PlantGafeteVisitF As String
    Private Clave_PlantGafeteVisitR As String
    Private Clave_PlantGafeteAreaSeguraF As String
    Private Clave_PlantGafeteAreaSeguraR As String
    Public TextoImprimir As String = "00"
    Public TipoGafete As String = ""

    Dim dt_DatosEmpresa As DataTable

    Private Sub frm_GafeteImprimirPlant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_GafeteImprimirPlant_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Consultar las plantillas de gafetes
        Dim dt_PlantillaGafete As DataTable = Cn_Reclutamiento.fn_ConsultarPlantilla()

        If dt_PlantillaGafete Is Nothing Then
            MsgBox("Ocurrió un Error al intentar obtener los Datos de la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If
        If dt_PlantillaGafete.Rows.Count = 0 Then
            MsgBox("No se encontraron los Datos de la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If

        Clave_PlantGafeteProvF = dt_PlantillaGafete.Rows(0)("PlantillaGafProF")
        Clave_PlantGafeteProvR = dt_PlantillaGafete.Rows(0)("PlantillaGafProR")
        Clave_PlantGafeteVisitF = dt_PlantillaGafete.Rows(0)("PlantillaGafVisitF")
        Clave_PlantGafeteVisitR = dt_PlantillaGafete.Rows(0)("PlantillaGafVisitR")

        If My.Settings.Zebra.Trim = "" Then
            lbl_Impresora.Text = "No ha seleccionado una Impresora"
        Else
            lbl_Impresora.Text = My.Settings.Zebra
        End If
        printerName = lbl_Impresora.Text

        dt_DatosEmpresa = fn_ConsultaDatosEmpresa()
        If dt_DatosEmpresa Is Nothing Then
            MsgBox("Ocurrió un error al cargar la información de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_ZebraFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ZebraFrente.Click
        SegundosDesconexion = 0

        Dim TipoPlantImprime As String = ""
        If TipoGafete = "VISITANTE" Then TipoPlantImprime = Clave_PlantGafeteVisitF
        If TipoGafete = "PROVEEDOR" Then TipoPlantImprime = Clave_PlantGafeteProvF
        If TipoGafete = "AREA SEGURA" Then TipoPlantImprime = Clave_PlantGafeteAreaSeguraF

        If TipoPlantImprime = "" Then
            MsgBox("No existen o no se cargaron los datos de la Plantilla.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call Imprimir_Zebra_Gafetes(TipoPlantImprime)
    End Sub

    Private Sub btn_ZebraTrasera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ZebraTrasera.Click
        SegundosDesconexion = 0
        Dim TipoPlantImprime As String = ""
        '= Clave_PlantGafeteVisitR 'visitanTeDefaulT
        If TipoGafete = "VISITANTE" Then
            TipoPlantImprime = Clave_PlantGafeteVisitR
        ElseIf TipoGafete = "PROVEEDOR" Then
            TipoPlantImprime = Clave_PlantGafeteProvR
        ElseIf TipoGafete = "AREA SEGURA" Then
            TipoPlantImprime = Clave_PlantGafeteAreaSeguraR
        End If

        If TipoPlantImprime = "" Then
            MsgBox("No existen o no se cargaron los datos de la Plantilla.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call Imprimir_Zebra_Gafetes(TipoPlantImprime)
    End Sub

    Private Sub Imprimir_Zebra_Gafetes(ByVal clavePlantilla As String)
        SegundosDesconexion = 0
        If My.Settings.Zebra.Trim = "" Then
            MsgBox("Debe configurar la Impresora para credenciales.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not System.IO.Directory.Exists(Ruta) Then
            'crea la ruta para Imagens temp
            System.IO.Directory.CreateDirectory(Ruta)
        Else
            If File.Exists(Ruta & "FotoEmpleado.JPG") Then File.Delete(Ruta & "FotoEmpleado.JPG")
            If File.Exists(Ruta & "CodigoBarEmpleado.JPG") Then File.Delete(Ruta & "CodigoBarEmpleado.JPG")
            If File.Exists(Ruta & "LogoEmpresa.JPG") Then File.Delete(Ruta & "LogoEmpresa.JPG")
            If File.Exists(Ruta & "FirmaEmpleado.JPG") Then File.Delete(Ruta & "FirmaEmpleado.JPG")
            If File.Exists(Ruta & "FirmaAutoriza.JPG") Then File.Delete(Ruta & "FirmaAutoriza.JPG")
            If File.Exists(Ruta & "FirmaRepresentante.JPG") Then File.Delete(Ruta & "FirmaRepresentante.JPG")
        End If

        '---validacion de campos credencial
        If Not dt_DatosEmpresa Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")
            ' ************************TEXTO*********************
            Try
                '1= remisiones 2=Credenciales (solo se imprimen Gafetes-->1 Credencial)

                'Imprime gafetes(PROVEEDOR O VISITANTE)
                Dim Dt_Plantilla As DataTable = fn_ConsultarPlantillaCampos(clavePlantilla, 2)

                If Dt_Plantilla Is Nothing Then
                    MsgBox("Ocurrio un Error al cargar la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If Dt_Plantilla.Rows.Count = 0 Then
                    MsgBox("No hay Campos en la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error de Conexion con la Impresora.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ZBRGDICloseGraphics(hDC, err)
                    Exit Sub
                End If

                Dim AlineacionPlant As Integer
                Dim thickness As Single
                For Each Dr_Campo As DataRow In Dt_Plantilla.Rows
                    If Dr_Campo("Alineacion") <> "" Then
                        Select Case Dr_Campo("Alineacion")
                            Case "DERECHA"
                                AlineacionPlant = 6
                            Case "CENTRO"
                                AlineacionPlant = 4
                            Case "IZQUIERDA"
                                AlineacionPlant = 5
                        End Select
                    End If
                    If Dr_Campo("Negrita") <> "" Then
                        Select Case Dr_Campo("Negrita")
                            Case "NORMAL"
                                fontBold = 0
                            Case "NEGRITA"
                                fontBold = 1
                            Case "CURSIVA"
                                fontBold = 2
                            Case "NEGRITA CURSIVA"
                                fontBold = 3
                        End Select
                    End If
                    Dr_Campo("Color") = "&H" & Microsoft.VisualBasic.Right(Dr_Campo("Color"), 6)
                    Select Case Dr_Campo("Nombre").ToString.ToUpper

                        Case "LOGO"
                            If Not IsDBNull(Dr_Campo("logo")) Then
                                Dim ImagenCad As String
                                Dim LogoEmpresa As Byte() = Dr_Campo("Logo")
                                Dim imagenImg As Image

                                Dim ms_ByteToImagen As New IO.MemoryStream(LogoEmpresa)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "LogoEmpresa.JPG")
                                ImagenCad = Ruta & "LogoEmpresa.JPG"
                                LogoEmpresa = ascii.GetBytes(ImagenCad)

                                If (ZBRGDIDrawImageRect(LogoEmpresa, Dr_Campo("X"), Dr_Campo("Y"), Dr_Campo("Ancho"), Dr_Campo("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el logotipo de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                imagenImg.Dispose()
                            End If

                        Case "RECTANGULO"
                            thickness = Dr_Campo("Grosor_Linea") '80 'es el grosor del rectangulo
                            If (ZBRGDIDrawRectangle(Dr_Campo("X"), Dr_Campo("Y"), Dr_Campo("Ancho"), Dr_Campo("Alto"), thickness, Dr_Campo("Color"), err) = 0) Then
                                MsgBox("Ha ocurrido un error al imprimir la banda superior.", MsgBoxStyle.Critical, frm_MENU.Text)
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                            End If

                            '--nuevos campos agregados----18MARZO2015

                        Case "ETIQUETATEXTO"
                            Dim EtiquetaTexto As Byte()
                            Dim NumeroGafete As String = Dr_Campo("ValorFijo")
                            If Dr_Campo("ValorFijo") = "00" Then NumeroGafete = TextoImprimir

                            EtiquetaTexto = ascii.GetBytes(NumeroGafete)
                            If (ZBRGDIDrawTextRect(Dr_Campo("X"), Dr_Campo("Y"), Dr_Campo("Ancho"), Dr_Campo("Alto"), AlineacionPlant, EtiquetaTexto, Fuente, Dr_Campo("Fuente"), fontBold, Dr_Campo("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir el departamento del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                    End Select
                Next
                If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                    MsgBox("Ocurrio un Error al Imprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ascii = Nothing
                If File.Exists(Ruta & "FotoEmpleado.JPG") Then File.Delete(Ruta & "FotoEmpleado.JPG")
                If File.Exists(Ruta & "CodigoBarEmpleado.JPG") Then File.Delete(Ruta & "CodigoBarEmpleado.JPG")
                If File.Exists(Ruta & "LogoEmpresa.JPG") Then File.Delete(Ruta & "LogoEmpresa.JPG")
                If File.Exists(Ruta & "FirmaEmpleado.JPG") Then File.Delete(Ruta & "FirmaEmpleado.JPG")
                If File.Exists(Ruta & "FirmaAutoriza.JPG") Then File.Delete(Ruta & "FirmaAutoriza.JPG")
                If File.Exists(Ruta & "FirmaRepresentante.JPG") Then File.Delete(Ruta & "FirmaRepresentante.JPG")

            Catch Ex As Exception
                FuncionesGlobales.TrataEx(Ex, True)
            End Try

        Else
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btn_ConfigPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConfigPrint.Click
        SegundosDesconexion = 0
        Dim dlg_Impresora As New PrintDialog()
        Dim dlg_Result As DialogResult
        dlg_Result = dlg_Impresora.ShowDialog

        If dlg_Result = Windows.Forms.DialogResult.OK Then
            My.Settings.Zebra = dlg_Impresora.PrinterSettings.PrinterName()
            My.Settings.Save()
        End If
        lbl_Impresora.Text = My.Settings.Zebra
    End Sub

End Class