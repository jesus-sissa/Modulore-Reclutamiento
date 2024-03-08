Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices.ComTypes
Imports Camera_NET
Imports DirectShowLib

Public Class frm_ObtenerImagen

    Dim RutaTmp As String = Ruta_Temporal
    Dim Foto As Image
    Dim FotoTmp As Image
    'Dim Bandera As Boolean = False
    Dim Ancho As Integer
    Dim Alto As Integer
    Dim AnchoTmp As Integer
    Dim AltoTmp As Integer
    Dim Valortmp As Integer
    'Variables para Scanner
    Dim tempfile As String
    Dim mydevice As WIA.Device
    Dim item As WIA.Item
    Dim imfile As WIA.ImageFile
    Dim Commondialog1 As WIA.CommonDialog
    Dim Bandera As Boolean
    Dim HayEscaner As Boolean = False
    Dim Accion As AccionBotones

    Public NombreDocumento As String = "" 'para mostrar de que documento es la imagen que va a capturar
    Public OrigenImagen As String = ""
    Public NombreEmpleado As String = ""
    Public Aceptar As Boolean = False
    Public ImagenRegresada As Image = Nothing
    Public MimeType As String = ""
    Public Extension As String = ""
    Public PesoArchivo As String = ""

    Enum AccionBotones As Integer
        CAMARA = 1
        ESCANER = 2
        ARCHIVO = 3
    End Enum

    ' Estatus manejados
    'NU= Nuevo
    'CA= Camata
    'ED= Editando
    'RE= Recortando
    'EA= Edicion Aplicada

    'Camara
    'Rect selection with mouse
    Private _MouseSelectionRect As NormalizedRect = New NormalizedRect(0, 0, 0, 0)
    Private _bDrawMouseSelection As Boolean = False

    '   // Zooming
    Private _bZoomed As Boolean = False
    Private _fZoomValue As Double = 1.0

    '  // Camera choice
    Private _CameraChoice As CameraChoice = New CameraChoice()

    '---------------------------------------------------------

    'Variable publicas para Foto Recortada
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer
    Dim cropX2 As Integer
    Dim cropY2 As Integer
    Dim cropTx As Integer
    Dim cropTy As Integer
    Dim Estatus As String = ""

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Yellow
    '----------------------------------------------------------

    Dim iDevice As Integer = 1
    Dim hHwnd As Integer



    Public FotoCamara As Boolean = False
    Dim Iniciado As Boolean = False
    Dim Captura As Boolean = False

    Private Sub frm_ObtenerImagen_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Ctr_Camara.CameraCreated Then Ctr_Camara.CloseCamera()
        Try
            IO.File.Delete(RutaTmp & "ImgTmp.jpg")
            IO.File.Delete(RutaTmp & "ImgTmp_copy.jpg")
        Catch ex As Exception
        End Try
    End Sub

    Private Sub frm_ObtenerImagen_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.F2
                If btn_Capturar.Enabled Then
                    btn_Capturar.PerformClick()
                End If
                'Case Keys.F3
                '    If Btn_Guardar.Enabled Then
                '        Btn_Guardar.PerformClick()
                '    End If
            Case Keys.Escape
                FotoCamara = False
                btn_Salir.PerformClick()
        End Select
    End Sub

    Private Sub frm_ObtenerImagen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        Me.Text = NombreEmpleado
        lbl_Camara.Text = "Seleccione el Origen de la imagen"
        lbl_NombreDocumento.Text = "Obteniendo imagen para: " & NombreDocumento

        Ancho = Pct_Foto.Width
        Alto = Pct_Foto.Height
        If Directory.Exists(RutaTmp) = False Then
            Directory.CreateDirectory(RutaTmp)
        End If
        Estatus = "NU"

        Call Botones()
    End Sub


#Region "Camara"


    Sub Camera_OutputVideoSizeChanged(ByVal sender As Object, ByVal e As EventArgs)
        'actualiza la camaa
        Call UpdateCameraBitmap()

        'falta actualizar el zoom
        'Call UpdateUnzoomButton()
    End Sub

    Private Sub UpdateCameraBitmap()
        If Not Ctr_Camara.MixerEnabled Then
            Exit Sub
        End If

        Ctr_Camara.OverlayBitmap = GenerateColorKeyBitmap(False)

    End Sub

    Private Function GenerateColorKeyBitmap(ByVal useAntiAlias As Boolean) As Bitmap
        Dim w As Integer = Ctr_Camara.OutputVideoSize.Width
        Dim h As Integer = Ctr_Camara.OutputVideoSize.Height

        If w <= 0 OrElse h <= 0 Then
            Return Nothing
        End If

        Dim bmp As Bitmap = New Bitmap(w, h, PixelFormat.Format24bppRgb)
        Dim g As Graphics = Graphics.FromImage(bmp)

        If useAntiAlias Then
            g.SmoothingMode = SmoothingMode.AntiAlias
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.AntiAlias
        Else
            g.SmoothingMode = SmoothingMode.None
            g.TextRenderingHint = Drawing.Text.TextRenderingHint.SingleBitPerPixelGridFit
        End If

        g.Clear(Ctr_Camara.GDIColorKey)

        'falta hacer que dibuje el rectangulo y haga zoom
        'If _bDrawMouseSelection Then

        'End If

        'If _bZoomed Then

        'End If

        g.Dispose()

        Return bmp
    End Function

    Private Sub SetCamera(ByVal camera_moniker As IMoniker, ByVal resolution As Resolution)
        Try
            Ctr_Camara.SetCamera(camera_moniker, resolution)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

        If Not Ctr_Camara.CameraCreated Then
            Exit Sub
        End If

        Ctr_Camara.MixerEnabled = True

        AddHandler Ctr_Camara.OutputVideoSizeChanged, AddressOf Camera_OutputVideoSizeChanged
        UpdateCameraBitmap()

    End Sub

    Private Sub SeleccionarCamara()
        Dim Encontrada As Boolean = False
        Dim SetCamara As String = My.Settings.Camara
        Dim SetResolucionStr As String = My.Settings.Resolucion

        If SetCamara.Trim.Equals("") OrElse SetResolucionStr.Trim.Equals("") Then
            If SetCamara.Trim.Equals("") Then
                MsgBox("No ha seleccionado una camara.", MsgBoxStyle.Exclamation, Me.Text)
            ElseIf SetResolucionStr.Trim.Equals("") Then
                MsgBox("No ha seleccionado la resolucion de la camara.", MsgBoxStyle.Exclamation, Me.Text)
            End If
            Dim frm As New frm_ObtenerImagen_Settings
            frm.ShowDialog()
            If Not frm.Guardado Then
                Exit Sub
            Else

                Call SeleccionarCamara()
                Exit Sub
            End If
        End If

        _CameraChoice.UpdateDeviceList()
        Dim SetResolucion As New Camera_NET.Resolution(SetResolucionStr.Split("x")(0), SetResolucionStr.Split("x")(1))

        For Each Camara_Device In _CameraChoice.Devices
            If SetCamara.ToUpper = Camara_Device.Name.ToUpper Then
                SetCamera(Camara_Device.Mon, SetResolucion)
                Encontrada = True
                Exit Sub
            End If
        Next
        If Not Encontrada Then
            MsgBox("La cámara configurada no se encuentra disponible, seleccione otra.", MsgBoxStyle.Exclamation, Me.Text)
            Btn_Setting.PerformClick()

        End If
    End Sub

    Sub NuevaFoto()
        'pct_Foto.Width = Ancho
        'pct_Foto.Height = Alto
        Estatus = "CA"
        Call SeleccionarCamara()
        If Not Ctr_Camara.CameraCreated Then
            Estatus = "NU"
            Exit Sub
        End If

        lbl_Camara.Text = "Desde: " & My.Settings.Camara & "  a " & My.Settings.Resolucion
        OrigenImagen = "CAMARA"

        pct_Foto.Visible = False
        Ctr_Camara.Visible = True

        Captura = False
        Accion = AccionBotones.CAMARA
        Call Botones()
    End Sub

    Sub Capturar()
        'Dim data As System.Windows.Forms.IDataObject
        Dim bitmap As Image
        Foto = Nothing

        If Not Ctr_Camara.CameraCreated Then
            Exit Sub
        End If

        bitmap = Ctr_Camara.SnapshotOutputImage()

        If bitmap Is Nothing Then
            Exit Sub
        End If

        Foto = bitmap
        FotoTmp = bitmap
        Captura = True
        pct_Foto.Image = Foto
        Ctr_Camara.CloseCamera()

    End Sub

#End Region

#Region "Escaner"

    Sub scan()

        tempfile = RutaTmp & "ImgTmp.jpg"

        Dim filesystemobject = CreateObject("Scripting.FileSystemObject")
        If filesystemobject.fileExists(tempfile) Then
            File.Delete(tempfile)
        End If

        'Dim Commondialog1 As New WIA.CommonDialog
        'mydevice = Commondialog1.ShowSelectDevice

        Dim WiaFormatJPEG As String = "{B96B3CAE-0728-11D3-9D7B-0000F81EF32E}"
        Dim WiaFormatBMP As String = "{B96B3CAB-0728-11D3-9D7B-0000F81EF32E}"
        Dim Nombre As String = mydevice.DeviceID
        item = mydevice.Items(1)

        '***
        'se pone en un sub separado para que acepte el Try
        'porque en este sub se usa el Resume Next para manejar los errores.
        Call ObtenerResolucion()
        '**

        imfile = DirectCast(Commondialog1.ShowTransfer(item, WiaFormatJPEG, False), WIA.ImageFile)

        imfile.SaveFile(tempfile)
        '***************
        Dim fs As System.IO.FileStream
        fs = New System.IO.FileStream(tempfile, IO.FileMode.Open, IO.FileAccess.Read)
        Foto = Image.FromStream(fs)
        FotoTmp = Image.FromStream(fs)
        fs.Close()


        AnchoTmp = Foto.Width
        AltoTmp = Foto.Height

        Captura = True
Exit_btnTakePicture_click:
        mydevice = Nothing
        item = Nothing
        Exit Sub

Err_btnTakePicture_click:
        MsgBox(Err.Description, vbOKOnly + vbCritical, "Error al Intentar Scannear")
        Resume Exit_btnTakePicture_click
    End Sub

    Private Sub ObtenerResolucion()
        Dim ValorResolucion As Integer
        Dim ValorAceptado As Boolean
        For Each MiProp In item.Properties
            Dim Propiedad As String = MiProp.Name
            Select Case MiProp.PropertyID
                Case 6146
                    MiProp.Value = 1
                Case 6147
                    ValorResolucion = 100
                    ValorAceptado = False
                    Do
                        Try
                            ValorResolucion += 50
                            MiProp.Value = ValorResolucion
                            ValorAceptado = True
                        Catch ex As Exception
                            ValorAceptado = False
                        End Try
                    Loop Until (ValorAceptado)
                Case 6148
                    ValorResolucion = 100
                    ValorAceptado = False
                    Do
                        Try
                            ValorResolucion += 50
                            MiProp.Value = ValorResolucion
                            ValorAceptado = True
                        Catch ex As Exception
                            ValorAceptado = False
                        End Try
                    Loop Until (ValorAceptado)
            End Select
        Next

    End Sub

    Private Function CompruebaScaner() As Integer
        Try
            Commondialog1 = New WIA.CommonDialog
            Dim Manejador As New WIA.DeviceManager
            Dim cantidad As Integer = Manejador.DeviceInfos.Count
            mydevice = Commondialog1.ShowSelectDevice(WIA.WiaDeviceType.ScannerDeviceType, True, True)

            'para obtener el nombre del escaner
            'Dim manejador As New WIA.DeviceManager
            'Dim nombredispo As String = ""
            'For Each dispo As WIA.DeviceInfo In manejador.DeviceInfos
            '    nombredispo = dispo.DeviceID
            'Next

            Return mydevice.Type
        Catch ex As Exception
            Return 0
        End Try
    End Function

    Private Sub Command1_Click()

        Dim oWIA_DeviceManager As WIA.DeviceManager
        Dim i As Long

        oWIA_DeviceManager = New WIA.DeviceManager

        If oWIA_DeviceManager.DeviceInfos.Count > 0 Then
            Commondialog1 = New WIA.CommonDialog

            For i = 1 To oWIA_DeviceManager.DeviceInfos.Count

                imfile = Commondialog1.ShowAcquireImage

            Next i
            mydevice = oWIA_DeviceManager.DeviceInfos.Item(i).Connect
        Else
            MsgBox("No Existen Dispositivos WIA Conectados.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub

#End Region

    Private Sub Original()
        If pct_Foto.Image Is Nothing Then
            MsgBox("No se a Capturado una Imagen.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        FotoTmp = New Bitmap(Foto)
        'pct_Foto.Width = Ancho
        'pct_Foto.Height = Alto
        Pct_Foto.Image = FotoTmp
        Estatus = "ED"
        Call Botones()
    End Sub

    Public Shared Function fn_ReducirImagen(ByVal Nombre As String, ByVal Imagen As Image, ByVal TamanoMax As Integer, ByVal Compresion As Integer, ByVal RutaTemp As String, ByVal AnchoDeseado As Integer, ByVal AltoDeseado As Integer) As String
        'RutaTemp = "C:\Siac_temp\"
        Dim Resulta1 As String = RutaTemp & Nombre & ".jpg"
        Dim Resulta2 As String = RutaTemp & Nombre & "_Copia.jpg"
        Dim fs As System.IO.FileStream
        Try
            'Las imagenes que se crean y su nombre
            If System.IO.File.Exists(Resulta1) Then IO.File.Delete(Resulta1)
        Catch
            Resulta1 = Resulta2
        End Try
        Try
            If System.IO.File.Exists(Resulta2) Then IO.File.Delete(Resulta2)
        Catch
            Resulta2 = Resulta1
        End Try

        Try
            Dim ImagenLocal As New Bitmap(Imagen)
            ImagenLocal.Save(Resulta1, System.Drawing.Imaging.ImageFormat.Jpeg)

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
                    IO.File.Delete(Resulta1)
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
                        fs = New System.IO.FileStream(Resulta1, IO.FileMode.Open, IO.FileAccess.Read)
                        ImagenLocal = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                        'ImagenLocal = Image.FromFile(Resulta1)
                        ImagenLocal.Save(Resulta2, iciJpegCodec, epParameters)
                        ImagenLocal.Dispose()
                        IO.File.Delete(Resulta1)

                        fs = New System.IO.FileStream(Resulta2, IO.FileMode.Open, IO.FileAccess.Read)
                        ImagenLocal = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                        'ImagenLocal = Image.FromFile(Resulta2)
                        FileSize = fn_TamañoArchivo(Resulta2)
                    Else
                        fs = New System.IO.FileStream(Resulta2, IO.FileMode.Open, IO.FileAccess.Read)
                        ImagenLocal = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                        'ImagenLocal = Image.FromFile(Resulta2)
                        ImagenLocal.Save(Resulta1, iciJpegCodec, epParameters)
                        ImagenLocal.Dispose()
                        IO.File.Delete(Resulta2)

                        fs = New System.IO.FileStream(Resulta1, IO.FileMode.Open, IO.FileAccess.Read)
                        ImagenLocal = System.Drawing.Image.FromStream(fs)
                        fs.Close()
                        'ImagenLocal = Image.FromFile(Resulta1)
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
                fs = New System.IO.FileStream(Resulta2, IO.FileMode.Open, IO.FileAccess.Read)
                ImagenLocal = System.Drawing.Image.FromStream(fs)
                fs.Close()
                'ImagenLocal = Image.FromFile(Resulta2)
                ImagenLocal.Save(Resulta1)
                ImagenLocal.Dispose()
                IO.File.Delete(Resulta2)

                Return Resulta1
            Else
                Return ""
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function

    Private Shared Function fn_TamañoArchivo(ByVal Ruta) As Long
        Dim FileSize As Long = 0
        Try
            Dim MyFile As New System.IO.FileInfo(Ruta)
            FileSize = MyFile.Length / 1024
            Return FileSize
        Catch
            Return 0
        End Try
    End Function

    Sub Botones()
        btn_NuevaFoto.Enabled = (Estatus = "NU" Or Estatus = "ED" Or Estatus = "EA")
        btn_Scan.Enabled = ((Estatus = "NU" Or Estatus = "ED" Or Estatus = "EA" Or Estatus = "CA"))
        'btn_Scan.Enabled = (CompruebaScaner() > 0 AndAlso (Estatus = "NU" Or Estatus = "ED" Or Estatus = "EA" Or Estatus = "CA"))
        Btn_AddImagen.Enabled = (Estatus = "NU" Or Estatus = "ED" Or Estatus = "EA" Or Estatus = "CA")

        btn_Capturar.Enabled = (Estatus = "CA")
        Btn_Guardar.Enabled = (Estatus = "ED" Or Estatus = "EA")

        btn_MasBrillo.Enabled = (Estatus = "ED" Or Estatus = "EA")
        btn_MenosBrillo.Enabled = (Estatus = "ED" Or Estatus = "EA")
        btn_Rotar.Enabled = (Estatus = "ED" Or Estatus = "EA")
        Btn_RotarDerecha.Enabled = (Estatus = "ED" Or Estatus = "EA")
        Chk_Recortar.Enabled = (Estatus = "ED" Or Estatus = "RE" Or Estatus = "EA")
        Btn_AplicarRecorte.Enabled = (Estatus = "RE")
        btn_Original.Enabled = (Estatus = "EA")
    End Sub

#Region "Origen de la imagen"

    Private Sub btn_NuevaFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_NuevaFoto.Click
        Call NuevaFoto()
    End Sub

    Private Sub btn_Scan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Scan.Click

        If Not HayEscaner Then
            If CompruebaScaner() = 0 Then
                MsgBox("No se tiene conexión con un escaner.", MsgBoxStyle.Critical, Me.tempfile)
                If Accion = AccionBotones.CAMARA Then
                    Call NuevaFoto()
                End If
                Exit Sub
            End If
        End If

        If Ctr_Camara.CameraCreated Then Ctr_Camara.CloseCamera()

        Call scan()

        Pct_Foto.Visible = True
        Ctr_Camara.Visible = False

        If Not IsNothing(Foto) Then
            Accion = AccionBotones.ESCANER
            Try
                IO.File.Delete(tempfile)
            Catch ex As Exception
            End Try


            Dim nombrearchivo As String = "ImgTmp"
            tempfile = RutaTmp & nombrearchivo & ".jpg"

            Pct_Foto.Image = Foto
            FotoTmp = New Bitmap(Foto)

            lbl_Camara.Text = "Desde: Escaner"
            OrigenImagen = "ESCANER"

            Estatus = "ED"

        End If
        Call Botones()
    End Sub

    Private Sub Btn_AddImagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AddImagen.Click

        Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Imagen|*.jpg", .Multiselect = False}

        Dialogo.ShowDialog()
        If Dialogo.FileName <> "" Then
            Accion = AccionBotones.ARCHIVO

            Me.Cursor = Cursors.WaitCursor

            If Ctr_Camara.CameraCreated Then
                Ctr_Camara.CloseCamera()
                Pct_Foto.Visible = True
                Ctr_Camara.Visible = False
            End If
            Pct_Foto.Visible = True
            Ctr_Camara.Visible = False


            tempfile = Dialogo.FileName

            Try
                Dim fs As System.IO.FileStream
                fs = New System.IO.FileStream(tempfile, IO.FileMode.Open, IO.FileAccess.Read)
                Foto = Image.FromStream(fs)
                FotoTmp = Image.FromStream(fs)
                Pct_Foto.Image = Foto
                fs.Close()

                Estatus = "ED"
                Me.Cursor = Cursors.Default
                lbl_Camara.Text = "Desde: Archivo"
                OrigenImagen = "ARCHIVO"
            Catch ex As Exception
                MsgBox("Ocurrió un error al cargar el archivo. Intente de nuevo o seleccione otro archivo", MsgBoxStyle.Critical, Me.Text)
            End Try
        End If
        Dialogo.Dispose()
        Call Botones()
    End Sub

    Private Sub btn_Setting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Setting.Click
        Dim frm As New frm_ObtenerImagen_Settings
        frm.Tipo = 1
        frm.ShowDialog()
        If Not frm.Guardado Then
            Exit Sub
        Else

            Exit Sub
        End If
    End Sub

    Private Sub Btn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Aceptar.Click
        If Pct_Foto.Image Is Nothing Then
            MsgBox("No se ha Capturado una Imagen", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim bmap As New Bitmap(Pct_Foto.Image)
        'Dim bmap As Image = Pct_Foto.Image.Clone
        Pct_Foto.Image = bmap
        ImagenRegresada = bmap
        FotoCamara = True
        Bandera = True
        Aceptar = True
        Me.Close()
    End Sub

    Private Sub btn_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Salir.Click
        Me.Close()
    End Sub

#End Region

#Region "Manipulacion de la imagen"

    Private Sub btn_Capturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar.Click
        Dim fs As System.IO.FileStream

        Call Capturar()

        If Foto Is Nothing Then
            MsgBox("No se Logro Capturar la Imagen.", MsgBoxStyle.Critical, Me.Text)
            tmr_Foto.Enabled = True
            Exit Sub
        End If

        Pct_Foto.Visible = True
        Ctr_Camara.Visible = False

        Dim nombrearchivo As String = "ImgTmp"
        tempfile = RutaTmp & nombrearchivo & ".jpg"

        'If Chk_Comprimir.Checked Then
        '    If fn_ReducirImagen(nombrearchivo, Foto, 400, 50, RutaTmp, 0, 0) = "Error" Then
        '        ' cn_Mensajes.fn_MsgBox(Me.Text, "Error al reducir la imagen.", MessageBoxIcon.Error, False)
        '        MsgBox("Ocurrió un error al comprimir la imagen.", MsgBoxStyle.Critical, Me.Text)
        '        tmr_Foto.Enabled = True
        '        Exit Sub
        '    End If

        '    fs = New System.IO.FileStream(tempfile, IO.FileMode.Open, IO.FileAccess.Read)
        '    Foto = Image.FromStream(fs, True)
        '    FotoTmp = Image.FromStream(fs, True)
        '    fs.Close()
        '    Pct_Foto.Image = FotoTmp
        'Else
        Pct_Foto.Image = Foto
        FotoTmp = New Bitmap(Foto)
        'End If


        'If Chk_GuardarAutomatico.Checked Then
        '    Call Guardar()
        'Else
        Estatus = "ED"
        'End If

        Call Botones()
    End Sub

    Private Sub btn_MenosBrillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MenosBrillo.Click
        If IsNothing(FotoTmp) Then Exit Sub
        Dim Map As New Bitmap(FotoTmp)
        Dim Pix1 As Color
        Dim Pix2 As New Color
        Dim PixR As Byte = 0
        Dim PixG As Byte = 0
        Dim PixB As Byte = 0
        Me.Cursor = Cursors.WaitCursor
        For X As Integer = 0 To Map.Width - 1
            For Y As Integer = 0 To Map.Height - 1
                Pix1 = Map.GetPixel(X, Y)
                If Pix1.R > 10 Then PixR = Pix1.R - 5 Else PixR = Pix1.R
                If Pix1.G > 10 Then PixG = Pix1.G - 5 Else PixG = Pix1.G
                If Pix1.B > 10 Then PixB = Pix1.B - 5 Else PixB = Pix1.B
                Pix2 = Drawing.Color.FromArgb(Pix1.A, PixR, PixG, PixB)
                Map.SetPixel(X, Y, Pix2)
            Next
        Next
        Estatus = "EA"
        Me.Cursor = Cursors.Default
        FotoTmp = Map
        Pct_Foto.Image = Map
        Call Botones()
    End Sub

    Private Sub btn_MasBrillo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MasBrillo.Click
        If IsNothing(FotoTmp) Then Exit Sub
        Dim Map As New Bitmap(FotoTmp)
        Dim Pix1 As Color
        Dim Pix2 As New Color
        Dim PixR As Byte = 0
        Dim PixG As Byte = 0
        Dim PixB As Byte = 0
        Me.Cursor = Cursors.WaitCursor
        For X As Integer = 0 To Map.Width - 1
            For Y As Integer = 0 To Map.Height - 1
                Pix1 = Map.GetPixel(X, Y)
                If Pix1.R < 245 Then PixR = Pix1.R + 5 Else PixR = Pix1.R
                If Pix1.G < 245 Then PixG = Pix1.G + 5 Else PixG = Pix1.G
                If Pix1.B < 245 Then PixB = Pix1.B + 5 Else PixB = Pix1.B
                Pix2 = Drawing.Color.FromArgb(Pix1.A, PixR, PixG, PixB)
                Map.SetPixel(X, Y, Pix2)
            Next
        Next
        Me.Cursor = Cursors.Default
        FotoTmp = Map
        Pct_Foto.Image = Map
        Estatus = "EA"
        Call Botones()
    End Sub

    Private Sub btn_Rotar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Rotar.Click
        If Pct_Foto.Image Is Nothing Then
            MsgBox("No se a Capturado una Imagen.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        ' Dim ImagenRotada As Image = pct_Foto.Image
        Dim ImagenRotada As Image = FotoTmp
        ImagenRotada.RotateFlip(RotateFlipType.Rotate90FlipXY)
        'ImagenRotada.RotateFlip(RotateFlipType.Rotate90FlipXY)
        FotoTmp = ImagenRotada
        Pct_Foto.Image = ImagenRotada
        Valortmp = AnchoTmp
        AnchoTmp = AltoTmp
        AltoTmp = Valortmp
        Estatus = "EA"
        Call Botones()
    End Sub

    Private Sub Btn_RotarDerecha_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_RotarDerecha.Click
        If Pct_Foto.Image Is Nothing Then
            MsgBox("No se a Capturado una Imagen.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If
        ' Dim ImagenRotada As Image = pct_Foto.Image
        Dim ImagenRotada As Image = FotoTmp
        'ImagenRotada.RotateFlip(RotateFlipType.Rotate90FlipXY)
        ImagenRotada.RotateFlip(RotateFlipType.Rotate90FlipNone)
        FotoTmp = ImagenRotada
        Pct_Foto.Image = ImagenRotada
        Valortmp = AnchoTmp
        AnchoTmp = AltoTmp
        AltoTmp = Valortmp
        Estatus = "EA"
        Call Botones()
    End Sub

    Private Sub Chk_Recortar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Recortar.CheckedChanged
        ' SegundosDesconexion = 0
        If Chk_Recortar.Checked Then
            Chk_Recortar.Tag = Estatus
            Estatus = "RE"
        Else
            Estatus = Chk_Recortar.Tag
            Pct_Foto.Refresh()
        End If
        Call Botones()
    End Sub

    Private Sub Btn_AplicarRecorte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AplicarRecorte.Click
        Try
            Dim Proporcion As Decimal
            Dim XRecorte As Integer
            Dim YRecorte As Integer

            Dim WidthRecorte As Integer
            Dim HeightRecorte As Integer

            Dim BlancoX As Integer = 0
            Dim BlancoY As Integer = 0

            Cursor = Cursors.Default

            If cropWidth < 1 Or cropHeight < 1 Then
                Exit Sub
            End If

            cropWidth = cropX2 - cropX
            cropHeight = cropY2 - cropY

            If FotoTmp.Width > FotoTmp.Height Then
                Proporcion = (FotoTmp.Width / Pct_Foto.Width)
                If (FotoTmp.Height / Proporcion) > Pct_Foto.Height Then
                    Proporcion = (FotoTmp.Height / Pct_Foto.Height)
                    BlancoX = (Pct_Foto.Width - (FotoTmp.Width / Proporcion)) / 2
                Else
                    BlancoY = (Pct_Foto.Height - (FotoTmp.Height / Proporcion)) / 2
                End If
            Else
                Proporcion = (FotoTmp.Height / Pct_Foto.Height)
                If (FotoTmp.Width / Proporcion) > Pct_Foto.Width Then
                    Proporcion = (FotoTmp.Width / Pct_Foto.Width)
                    BlancoY = (Pct_Foto.Height - (FotoTmp.Height / Proporcion)) / 2
                Else
                    BlancoX = (Pct_Foto.Width - (FotoTmp.Width / Proporcion)) / 2
                End If
            End If

            WidthRecorte = cropWidth * Proporcion
            HeightRecorte = cropHeight * Proporcion

            XRecorte = (cropX - BlancoX) * Proporcion
            YRecorte = (cropY - BlancoY) * Proporcion

            Dim rect As Rectangle = New Rectangle(XRecorte, YRecorte, WidthRecorte, HeightRecorte)
            Dim bit As Bitmap = New Bitmap(FotoTmp)

            cropBitmap = New Bitmap(WidthRecorte, HeightRecorte)
            Dim g As Graphics = Graphics.FromImage(cropBitmap)
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
            g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)

            ' My.Computer.Clipboard.SetImage(cropBitmap)

            Pct_Foto.Image = cropBitmap
            FotoTmp = cropBitmap

            cropWidth = 0
            cropHeight = 0
            Chk_Recortar.Checked = False
            Estatus = "EA"
        Catch exc As Exception
        End Try
        Call Botones()
    End Sub

    Private Sub btn_Original_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Original.Click
        Call Original()
    End Sub

    Private Sub Pct_Foto_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pct_Foto.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left And Estatus = "RE" Then
                cropWidth = 0
                cropHeight = 0
                cropX = e.Location.X
                cropY = e.Location.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            Pct_Foto.Refresh()
        Catch exc As Exception
        End Try
    End Sub

    Private Sub Pct_Foto_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pct_Foto.MouseMove
        Try
            If Pct_Foto.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left And Estatus = "RE" Then

                Pct_Foto.Refresh()

                cropTx = cropX
                cropTy = cropY

                If e.Location.X > cropTx Then
                    cropX2 = e.Location.X
                Else
                    cropX2 = cropX
                    cropTx = e.Location.X
                End If

                If e.Location.Y > cropTy Then
                    cropY2 = e.Location.Y
                Else
                    cropY2 = cropY
                    cropTy = e.Location.Y
                End If

                cropWidth = cropX2 - cropTx
                cropHeight = cropY2 - cropTy

                Pct_Foto.CreateGraphics.DrawRectangle(cropPen, cropTx, cropTy, cropWidth, cropHeight)
            End If
            'GC.Collect()

        Catch exc As Exception
            If Err.Number = 5 Then Exit Sub
        End Try
    End Sub

    Private Sub Pct_Foto_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Pct_Foto.MouseUp
        cropX = cropTx
        cropY = cropTy

        Me.Cursor = Cursors.Default

    End Sub

#End Region

End Class