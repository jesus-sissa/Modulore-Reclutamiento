Imports System.IO
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosI

    Public Id_Empleado As Integer
    Public Clave As String
    Public Nombre As String
    Public Departamento As String = ""
    Public Puesto As String = ""
    Public Hubo_Cambios As Boolean = False

    Dim frm As New frm_EmpleadosIValidar
    Dim TeniaImagenes As Boolean
    Dim TeniaHuellas As Boolean
    Dim TeniaHuellasT As Boolean
    Dim TieneDispositivo As Boolean = False
    Dim FileSize As Long = 0
    Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Imagen|*.jpg", .Multiselect = False}
    Dim Ruta As String

    'Variables para la Captura de Huellas
    Dim objNBioBSP As NBioBSPCOMLib.NBioBSP
    Dim objNBioBSP2 As NBioBSPCOMLib.IDevice

    Dim objDevice As NBioBSPCOMLib.IDevice                ' Device object
    Dim objExtraction As NBioBSPCOMLib.IExtraction        ' Extraction object
    Dim objMatching As NBioBSPCOMLib.IMatching            ' Matching object
    Dim objFPData As NBioBSPCOMLib.IFPData                ' FPData object
    Dim objFPImage As NBioBSPCOMLib.IFPImage              ' FPImage object

    Dim Mensaje As String 'Mensaje de regreso de la Funcion Capturar

    Function InicializaVariables() As Boolean
        ' Create NBioBSP object
        Try
            objNBioBSP = New NBioBSPCOMLib.NBioBSP
            objDevice = objNBioBSP.Device
            objExtraction = objNBioBSP.Extraction
            objMatching = objNBioBSP.Matching
            objFPData = objNBioBSP.FPData
            objFPImage = objNBioBSP.FPImage

        Catch ex As Exception
            'FuncionesGlobales.TrataEx(ex)
            TieneDispositivo = False
            lbl_Dispositivo.Text = "Dispositivo NO Encontrado"
            lbl_Dispositivo.ForeColor = Color.Red
            MsgBox("Al parecer no tiene instalado el Dispositivo de Huellas Digitales.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return False
        End Try
        TieneDispositivo = True
        lbl_Dispositivo.Text = "Dispositivo Encontrado"
        lbl_Dispositivo.ForeColor = Color.Green
        Return True
    End Function

    Sub MostrarImagen(ByVal DaRow As DataRow, ByRef PCT As PictureBox, ByVal FotoRevisar As String, ByVal TieneImagen As String, ByVal Boton As Button)
        Dim ms_FotoRevisar As MemoryStream
        Boton.Enabled = True
        If DaRow IsNot Nothing Then
            If Not IsDBNull(DaRow(FotoRevisar)) Then
                ms_FotoRevisar = New MemoryStream(DaRow(FotoRevisar), 0, DaRow(FotoRevisar).Length)
                ms_FotoRevisar.Write(DaRow(FotoRevisar), 0, DaRow(FotoRevisar).Length)
                PCT.Image = Image.FromStream(ms_FotoRevisar, True)
                If DaRow(TieneImagen) = "SI" Then
                    PCT.Tag = 1
                    Boton.Enabled = True
                End If
                ms_FotoRevisar.Dispose()
                PCT.Refresh()
            End If
        End If
    End Sub

    Sub MostrarHuella(ByVal DaRow As DataRow, ByRef PCT As PictureBox, ByVal FotoRevisar As String, ByVal Boton As Button)
        Dim ms_FotoRevisar As MemoryStream
        Boton.Enabled = False
        PCT.Tag = 0
        If DaRow IsNot Nothing Then
            If Not IsDBNull(DaRow(FotoRevisar)) Then
                ms_FotoRevisar = New MemoryStream(DaRow(FotoRevisar), 0, DaRow(FotoRevisar).Length)
                ms_FotoRevisar.Write(DaRow(FotoRevisar), 0, DaRow(FotoRevisar).Length)
                PCT.Image = Image.FromStream(ms_FotoRevisar, True)

                PCT.Tag = 1
                Boton.Enabled = True
                ms_FotoRevisar.Dispose()
                PCT.Refresh()
            End If
        End If
    End Sub

    Private Sub frm_EmpleadosI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InicializaVariables()
        Ruta = Application.StartupPath & "\"
        Dialogo.InitialDirectory = "c:\"

        lbl_Clave.Text = Clave
        lbl_Nombre.Text = Nombre

        pct_Frente.Tag = 0
        pct_Derecho.Tag = 0
        pct_Izquierdo.Tag = 0
        pct_Firma.Tag = 0
        pct_Completo.Tag = 0
        pct_Codigo.Tag = 0
        pct_Frente.Image = Nothing
        pct_Derecho.Image = Nothing
        pct_Izquierdo.Image = Nothing
        pct_Completo.Image = Nothing
        pct_Firma.Image = Nothing
        pct_Codigo.Image = Nothing
        TeniaImagenes = False
        btn_LimpiarFrente.Enabled = False
        btn_LimpiarDerecho.Enabled = False
        btn_LimpiarIzquierdo.Enabled = False
        btn_LimpiarCompleto.Enabled = False
        btn_LimpiarFirma.Enabled = False

        btn_Extraer.Enabled = False

        'CONSULTAR LAS IMAGENES
        Dim dr As DataRow = fn_Empleados_LeerImagenes(Id_Empleado)
        If dr IsNot Nothing Then
            TeniaImagenes = True
            btn_Extraer.Enabled = True
            btn_ExtFotos.Enabled = True
            'Frente
            MostrarImagen(dr, pct_Frente, "Frente", "TieneFrente", btn_LimpiarFrente)
            btn_ExtraerFrente.Enabled = True
            'Perfil derecho
            MostrarImagen(dr, pct_Derecho, "Perfil_Derecho", "TienePerfil_Derecho", btn_LimpiarDerecho)
            btn_ExtraerDerecho.Enabled = True
            'Perfil Izquierdo
            MostrarImagen(dr, pct_Izquierdo, "Perfil_Izquierdo", "TienePerfil_Izquierdo", btn_LimpiarIzquierdo)
            btn_ExtraerIzquierdo.Enabled = True
            'Cuerpo Completo
            MostrarImagen(dr, pct_Completo, "Cuerpo_Completo", "TieneCuerpo_Completo", btn_LimpiarCompleto)
            btn_ExtraerEntero.Enabled = True
            'Firma
            MostrarImagen(dr, pct_Firma, "Firma", "TieneFirma", btn_LimpiarFirma)
            btn_ExtraerFirma.Enabled = True
            'Código
            MostrarImagen(dr, pct_Codigo, "Codigo", "TieneCodigo", btn_codigo)
        End If
        '***************************************************
        'Huellas
        '***************************************************
        dr = Cn_Reclutamiento.fn_Empleados_LeerHuellas(Id_Empleado)
        If dr IsNot Nothing Then

            TeniaHuellas = True
            btn_ExtraerHuellas.Enabled = True
            MostrarHuella(dr, pct_1, "Uno", btn_Limpiar1)
            MostrarHuella(dr, pct_2, "Dos", btn_Limpiar2)
            MostrarHuella(dr, pct_3, "Tres", btn_Limpiar3)
            MostrarHuella(dr, pct_4, "Cuatro", btn_Limpiar4)
            MostrarHuella(dr, pct_5, "Cinco", btn_Limpiar5)
            MostrarHuella(dr, pct_6, "Seis", btn_Limpiar6)
            MostrarHuella(dr, pct_7, "Siete", btn_Limpiar7)
            MostrarHuella(dr, pct_8, "Ocho", btn_Limpiar8)
            MostrarHuella(dr, pct_9, "Nueve", btn_Limpiar9)
            MostrarHuella(dr, pct_10, "Diez", btn_Limpiar10)
        Else
            TeniaHuellas = False

            pct_1.Image = Nothing
            pct_2.Image = Nothing
            pct_3.Image = Nothing
            pct_4.Image = Nothing
            pct_5.Image = Nothing
            pct_6.Image = Nothing
            pct_7.Image = Nothing
            pct_8.Image = Nothing
            pct_9.Image = Nothing
            pct_10.Image = Nothing

            pct_1.Tag = 0
            pct_2.Tag = 0
            pct_3.Tag = 0
            pct_4.Tag = 0
            pct_5.Tag = 0
            pct_6.Tag = 0
            pct_7.Tag = 0
            pct_8.Tag = 0
            pct_9.Tag = 0
            pct_10.Tag = 0

            btn_Limpiar1.Enabled = False
            btn_Limpiar2.Enabled = False
            btn_Limpiar3.Enabled = False
            btn_Limpiar4.Enabled = False
            btn_Limpiar5.Enabled = False
            btn_Limpiar6.Enabled = False
            btn_Limpiar7.Enabled = False
            btn_Limpiar8.Enabled = False
            btn_Limpiar9.Enabled = False
            btn_Limpiar10.Enabled = False
            '  btn_ExtraerHuellas.Enabled = False
        End If
        'Leer las Huellas T (texto encriptado de las Huellas)
        dr = Cn_Reclutamiento.fn_Empleados_LeerHuellasT(Id_Empleado)
        If dr IsNot Nothing Then
            TeniaHuellasT = True
            lbl_1.Tag = dr("Uno")
            lbl_2.Tag = dr("Dos")
            lbl_3.Tag = dr("Tres")
            lbl_4.Tag = dr("Cuatro")
            lbl_5.Tag = dr("Cinco")
            lbl_6.Tag = dr("Seis")
            lbl_7.Tag = dr("Siete")
            lbl_8.Tag = dr("Ocho")
            lbl_9.Tag = dr("Nueve")
            lbl_10.Tag = dr("Diez")
            If dr("Ult_Validacion") <> "" Then
                lbl_UltimaValidacion.ForeColor = Color.Green
                lbl_UltimaValidacion.Text = "Ultima Validación: " & dr("Ult_Validacion")
            End If
        Else
            TeniaHuellasT = False
            lbl_1.Tag = ""
            lbl_2.Tag = ""
            lbl_3.Tag = ""
            lbl_4.Tag = ""
            lbl_5.Tag = ""
            lbl_6.Tag = ""
            lbl_7.Tag = ""
            lbl_8.Tag = ""
            lbl_9.Tag = ""
            lbl_10.Tag = ""
        End If
        dr = Nothing

        btn_ValidarHuellas.Enabled = TeniaHuellas AndAlso TeniaHuellasT
    End Sub

#Region "Botón Guardar"

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Me.Cursor = Cursors.WaitCursor

        Cn_Login.fn_Log_Create("GUARDAR FOTOS Y HUELLAS DEL EMPLEADO: " & lbl_Clave.Text & " - " & lbl_Nombre.Text)

        Dim Bytes As Byte()
        Dim fs 'As New System.IO.FileStream("", FileMode.Open)

        Dim TipoActualizaImagen As Integer

        TipoActualizaImagen = 0 'No actualizar Imagenes

        Call Extraer()

        '*******************************************
        'Fotos
        '*******************************************
        'Convertir las Imagenes en Bytes
        If File.Exists(Ruta & "PCT_Completo.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_Completo.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoFoto.CuerpoCompleto) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Foto de Cuerpo Completo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaImagenes = True
            End If
        End If
        If File.Exists(Ruta & "PCT_Frente.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_Frente.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoFoto.Frente) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Foto de Frente.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaImagenes = True
            End If
        End If
        If File.Exists(Ruta & "PCT_Derecho.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_Derecho.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoFoto.Derecho) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Foto de Perfil Derecho.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaImagenes = True
            End If
        End If
        If File.Exists(Ruta & "PCT_Izquierdo.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_Izquierdo.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoFoto.Izquierdo) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Foto de Perfil Izquierdo.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaImagenes = True
            End If
        End If
        If File.Exists(Ruta & "PCT_Firma.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_Firma.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoFoto.Firma) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Firma.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaImagenes = True
            End If
        End If
        '*******************************************
        'Huellas
        '*******************************************
        If File.Exists(Ruta & "PCT_1.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_1.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella1) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 1.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_2.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_2.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella2) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 2.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_3.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_3.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella3) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 3.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_4.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_4.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella4) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 4.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_5.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_5.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella5) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 5.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If

        If File.Exists(Ruta & "PCT_6.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_6.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella6) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 6.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_7.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_7.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella7) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 7.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_8.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_8.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella8) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 8.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_9.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_9.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella9) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 9.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        If File.Exists(Ruta & "PCT_10.jpg") Then
            fs = New System.IO.FileStream(Ruta & "PCT_10.jpg", System.IO.FileMode.Open)
            Bytes = New Byte(fs.Length - 1) {}
            fs.Read(Bytes, 0, Bytes.Length)
            fs.Close()
            If Not fn_EmpleadosHuellas_Actualizar(Id_Empleado, Bytes, TeniaHuellas, TipoHuella.Huella10) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la Huella 10.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                TeniaHuellas = True
            End If
        End If
        'HuellasT
        If Not fn_EmpleadosHuellasT_Actualizar(Id_Empleado, lbl_1.Tag, lbl_2.Tag, lbl_3.Tag, lbl_4.Tag, lbl_5.Tag, lbl_6.Tag, lbl_7.Tag, lbl_8.Tag, lbl_9.Tag, lbl_10.Tag, TeniaHuellasT) Then
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar guardar la Lectura de las Huellas.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            TeniaHuellasT = True
        End If

        Call BorrarImagenes()

        btn_ValidarHuellas.Enabled = TeniaHuellas AndAlso TeniaHuellasT

        MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
        Me.Cursor = Cursors.Default
    End Sub

    Sub BorrarImagenes()
        'On Error Resume Next
        If File.Exists(Ruta & "PCT_1.jpg") Then Kill(Ruta & "PCT_1.jpg")
        If File.Exists(Ruta & "PCT_2.jpg") Then Kill(Ruta & "PCT_2.jpg")
        If File.Exists(Ruta & "PCT_3.jpg") Then Kill(Ruta & "PCT_3.jpg")
        If File.Exists(Ruta & "PCT_4.jpg") Then Kill(Ruta & "PCT_4.jpg")
        If File.Exists(Ruta & "PCT_5.jpg") Then Kill(Ruta & "PCT_5.jpg")
        If File.Exists(Ruta & "PCT_6.jpg") Then Kill(Ruta & "PCT_6.jpg")
        If File.Exists(Ruta & "PCT_7.jpg") Then Kill(Ruta & "PCT_7.jpg")
        If File.Exists(Ruta & "PCT_8.jpg") Then Kill(Ruta & "PCT_8.jpg")
        If File.Exists(Ruta & "PCT_9.jpg") Then Kill(Ruta & "PCT_9.jpg")
        If File.Exists(Ruta & "PCT_10.jpg") Then Kill(Ruta & "PCT_10.jpg")
        If File.Exists(Ruta & "PCT_Completo.jpg") Then Kill(Ruta & "PCT_Completo.jpg")
        If File.Exists(Ruta & "PCT_Frente.jpg") Then Kill(Ruta & "PCT_Frente.jpg")
        If File.Exists(Ruta & "PCT_Derecho.jpg") Then Kill(Ruta & "PCT_Derecho.jpg")
        If File.Exists(Ruta & "PCT_Izquierdo.jpg") Then Kill(Ruta & "PCT_Izquierdo.jpg")
        If File.Exists(Ruta & "PCT_Firma.jpg") Then Kill(Ruta & "PCT_Firma.jpg")
    End Sub

    Sub Extraer()
        'Extraer las imagenes de los PCTs que contengan una
        Call BorrarImagenes()

        If pct_1.Tag = 1 Then
            Dim Imagen1 As New Bitmap(pct_1.Image)
            Imagen1.Save(Ruta & "PCT_1.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_2.Tag = 1 Then
            Dim Imagen2 As New Bitmap(pct_2.Image)
            Imagen2.Save(Ruta & "PCT_2.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_3.Tag = 1 Then
            Dim Imagen3 As New Bitmap(pct_3.Image)
            Imagen3.Save(Ruta & "PCT_3.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_4.Tag = 1 Then
            Dim Imagen4 As New Bitmap(pct_4.Image)
            Imagen4.Save(Ruta & "PCT_4.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_5.Tag = 1 Then
            Dim Imagen5 As New Bitmap(pct_5.Image)
            Imagen5.Save(Ruta & "PCT_5.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_6.Tag = 1 Then
            Dim Imagen6 As New Bitmap(pct_6.Image)
            Imagen6.Save(Ruta & "PCT_6.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_7.Tag = 1 Then
            Dim Imagen7 As New Bitmap(pct_7.Image)
            Imagen7.Save(Ruta & "PCT_7.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_8.Tag = 1 Then
            Dim Imagen8 As New Bitmap(pct_8.Image)
            Imagen8.Save(Ruta & "PCT_8.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_9.Tag = 1 Then
            Dim Imagen9 As New Bitmap(pct_9.Image)
            Imagen9.Save(Ruta & "PCT_9.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_10.Tag = 1 Then
            Dim Imagen10 As New Bitmap(pct_10.Image)
            Imagen10.Save(Ruta & "PCT_10.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Completo.Tag = 1 Then
            Dim ImagenCompleto As New Bitmap(pct_Completo.Image)
            ImagenCompleto.Save(Ruta & "PCT_Completo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Frente.Tag = 1 Then
            Dim ImagenFrente As New Bitmap(pct_Frente.Image)
            ImagenFrente.Save(Ruta & "PCT_Frente.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Derecho.Tag = 1 Then
            Dim ImagenDerecho As New Bitmap(pct_Derecho.Image)
            ImagenDerecho.Save(Ruta & "PCT_Derecho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Izquierdo.Tag = 1 Then
            Dim ImagenIzquierdo As New Bitmap(pct_Izquierdo.Image)
            ImagenIzquierdo.Save(Ruta & "PCT_Izquierdo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Firma.Tag = 1 Then
            Dim ImagenFirma As New Bitmap(pct_Firma.Image)
            ImagenFirma.Save(Ruta & "PCT_Firma.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

#End Region

#Region "Capturar Imagenes (Desde Archivo o Desde Cámara)"

    Sub Examinar(ByVal Pct As PictureBox, ByVal Btn As Button, ByVal NombreJPG As String)
        Dialogo.ShowDialog()
        If Dialogo.FileName <> "" Then
            Me.Cursor = Cursors.WaitCursor
            btn_Guardar.Enabled = True
            Dim Imagen As Image = Image.FromFile(Dialogo.FileName)
            Pct.Load(FuncionesGlobales.fn_ReducirImagen(NombreJPG, Imagen, 200000, 30, Ruta, 800, 600))
            Imagen.Dispose()
            Pct.Refresh()
            'Si la imagen cambió se le camia el Tag para saber que es una Modificación (2)
            Pct.Tag = 1
            Btn.Enabled = True
            Me.Cursor = Cursors.Default
        Else
            If Pct.Tag = 0 Then 'Si no tenia imagen desde el principio, queda vacío
                Btn.Enabled = False
            End If
        End If
        Dialogo.Reset()
    End Sub

    Private Sub btn_ExaminarCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarCompleto.Click
        'No le debo mandar la extensión porque cuando la reduce se la pone
        Call Examinar(pct_Completo, btn_LimpiarCompleto, "PCT_Completo")
    End Sub

    Private Sub btn_ExaminarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarFrente.Click
        Call Examinar(pct_Frente, btn_LimpiarFrente, "PCT_Frente")
    End Sub

    Private Sub btn_ExaminarDerecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarDerecho.Click
        Call Examinar(pct_Derecho, btn_LimpiarDerecho, "PCT_Derecho")
    End Sub

    Private Sub btn_ExaminarIzquierdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarIzquierdo.Click
        Call Examinar(pct_Izquierdo, btn_LimpiarIzquierdo, "PCT_Izquierdo")
    End Sub

    Private Sub btn_ExaminarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarFirma.Click
        Call Examinar(pct_Firma, btn_LimpiarFirma, "PCT_Firma")
    End Sub

    Private Sub btn_TomarCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarCompleto.Click
        Call CapturarCamara(pct_Completo, btn_LimpiarCompleto)
    End Sub

    Private Sub btn_TomarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarFrente.Click
        Call CapturarCamara(pct_Frente, btn_LimpiarFrente)
    End Sub

    Private Sub btn_TomarDerecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarDerecho.Click
        Call CapturarCamara(pct_Derecho, btn_LimpiarDerecho)
    End Sub

    Private Sub btn_TomarIzquierdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarIzquierdo.Click
        Call CapturarCamara(pct_Izquierdo, btn_LimpiarIzquierdo)
    End Sub

    Private Sub btn_TomarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarFirma.Click
        Call CapturarCamara(pct_Firma, btn_LimpiarFirma)
    End Sub

    Sub CapturarCamara(ByVal Pct As PictureBox, ByVal Btn As Button)
        'Tomar la Foto de Cuerpo Completo desde la cámara
        SegundosDesconexion = 0

        Dim frm As New frm_Fotos
        BanderA = False
        frm.ShowDialog()
        If BanderA Then
            Pct.Image = frm.pct_Foto.Image
            Pct.Refresh()
            Pct.Tag = 1
            Btn.Enabled = True
        Else
            If Pct.Tag = 0 Then 'Si no tenia imagen desde el principio, queda vacío
                Pct.Image = Nothing
                Btn.Enabled = False
            End If
        End If
        frm.Dispose()
        btn_Guardar.Enabled = True
    End Sub

#End Region

#Region "Limpiar Imagenes"

    Private Sub btn_LimpiarCompleto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarCompleto.Click
        Call LimpiarImagenes(pct_Completo, btn_LimpiarCompleto, "PCT_Completo.jpg", gbx_CuerpoEntero.Text)
    End Sub

    Private Sub btn_LimpiarFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarFrente.Click
        Call LimpiarImagenes(pct_Frente, btn_LimpiarFrente, "PCT_Frente.jpg", gbx_Frente.Text)
    End Sub

    Private Sub btn_LimpiarDerecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarDerecho.Click
        Call LimpiarImagenes(pct_Derecho, btn_LimpiarDerecho, "PCT_Derecho.jpg", gbx_Derecho.Text)
    End Sub

    Private Sub btn_LimpiarIzquierdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarIzquierdo.Click
        Call LimpiarImagenes(pct_Izquierdo, btn_LimpiarIzquierdo, "PCT_Izquierdo.jpg", gbx_Izquierdo.Text)
    End Sub

    Private Sub btn_LimpiarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarFirma.Click
        Call LimpiarImagenes(pct_Firma, btn_LimpiarFirma, "PCT_Firma.jpg", gbx_Firma.Text)
    End Sub

    Sub LimpiarImagenes(ByVal Pct As PictureBox, ByVal Btn As Button, ByVal NombreJPG As String, ByVal NombreEliminar As String)
        SegundosDesconexion = 0

        If TeniaImagenes Then
            If MsgBox("Seguro desea eliminar la imagen de '" & NombreEliminar & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If

            Dim NoEliminada As Boolean = False
            Select Case Pct.Name
                Case pct_Completo.Name
                    NoEliminada = fn_EmpleadosI_Actualizar(Id_Empleado, Nothing, True, TipoFoto.CuerpoCompleto)

                Case pct_Frente.Name
                    NoEliminada = fn_EmpleadosI_Actualizar(Id_Empleado, Nothing, True, TipoFoto.Frente)

                Case pct_Derecho.Name
                    NoEliminada = fn_EmpleadosI_Actualizar(Id_Empleado, Nothing, True, TipoFoto.Derecho)

                Case pct_Izquierdo.Name
                    NoEliminada = fn_EmpleadosI_Actualizar(Id_Empleado, Nothing, True, TipoFoto.Izquierdo)

                Case pct_Firma.Name
                    NoEliminada = fn_EmpleadosI_Actualizar(Id_Empleado, Nothing, True, TipoFoto.Firma)

            End Select

            If Not NoEliminada Then
                MsgBox("Ocurrio un erro al intentar eliminar la Imagen de " & NombreEliminar, MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Pct.Image = Nothing
            Pct.Tag = 2
            Try
                If File.Exists(Ruta & NombreJPG) Then Kill(Ruta & NombreJPG)
            Catch
            End Try
        Else
            Pct.Tag = 0
        End If
        Btn.Enabled = False
    End Sub

#End Region

#Region "Capturar Huellas"

    Private Sub btn_Capturar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar1.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_1, btn_Limpiar1, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar1.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar2.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_2, btn_Limpiar2, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar2.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar3.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_3, btn_Limpiar3, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar3.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar4.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_4, btn_Limpiar4, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar4.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar5.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_5, btn_Limpiar5, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar5.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar6.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_6, btn_Limpiar6, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar6.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar7.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_7, btn_Limpiar7, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar7.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar8.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_8, btn_Limpiar8, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar8.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar9.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_9, btn_Limpiar9, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar9.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Private Sub btn_Capturar10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar10.Click
        If Not TieneDispositivo Then Exit Sub
        If Not CapturarHuella(pct_10, btn_Limpiar10, Mensaje) Then
            MsgBox("Ocurrió un Error. " & Mensaje & Chr(13) & Chr(13) & "Intente de nuevo por favor.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Limpiar10.Enabled = True
        btn_Guardar.Enabled = True
    End Sub

    Function CapturarHuella(ByRef PCT As PictureBox, ByRef BTN As Button, ByRef Mensaje As String) As Boolean
        Dim biFIR() As Byte
        Dim NombreArchivo As String
        Dim Extension As String
        Dim nMinType As Integer
        Dim nImgType As Integer
        Dim nFingerCnt As Integer
        Dim nFingerID As Object

        Mensaje = ""
        BTN.Tag = 0
        ' Capture
        Try
            objDevice.Open(NBioAPI_DEVICE_ID_AUTO_DETECT)
            objExtraction.WindowStyle = NBioAPI_WINDOW_STYLE_INVISIBLE
            objExtraction.IdentifyImageQuality = 70
            objExtraction.VerifyImageQuality = 70
            objExtraction.EnrollImageQuality = 70
            objExtraction.SecurityLevel = 6
            objExtraction.Capture(NBioAPI_FIR_PURPOSE_VERIFY)
            objDevice.Close(NBioAPI_DEVICE_ID_AUTO_DETECT)

            If objExtraction.ErrorCode > 0 Then
                Mensaje = "No se pudo Inicializar el Dispositivo."
                Return False
            End If

            ' Get binary encoded FIR data
            'Se conserva el FIR capturado en el Tag de los Labels que acompañan a cada Picturebox
            biFIR = objExtraction.FIR
            Dim textFIR = objExtraction.TextEncodeFIR
            Select Case PCT.Name.ToUpper
                Case "PCT_1"
                    lbl_1.Tag = textFIR
                Case "PCT_2"
                    lbl_2.Tag = textFIR
                Case "PCT_3"
                    lbl_3.Tag = textFIR
                Case "PCT_4"
                    lbl_4.Tag = textFIR
                Case "PCT_5"
                    lbl_5.Tag = textFIR
                Case "PCT_6"
                    lbl_6.Tag = textFIR
                Case "PCT_7"
                    lbl_7.Tag = textFIR
                Case "PCT_8"
                    lbl_8.Tag = textFIR
                Case "PCT_9"
                    lbl_9.Tag = textFIR
                Case "PCT_10"
                    lbl_10.Tag = textFIR
            End Select
            ' Set Min type
            nMinType = MINCONV_TYPE_FDP
            nImgType = NBioAPI_IMG_TYPE_JPG
            Extension = ".jpg"
            NombreArchivo = Ruta & "Huella.jpg"
            ' Export image data
            objFPImage.Export()

            If objFPImage.ErrorCode = NBioAPIERROR_NONE Then
                ' Get finger count & sample number
                nFingerCnt = objFPImage.TotalFingerCount
                For f = 0 To nFingerCnt - 1
                    nFingerID = objFPImage.FingerID(f)
                    ' Make new filename
                    NombreArchivo = Microsoft.VisualBasic.Left(NombreArchivo, Len(NombreArchivo) - 4)
                    NombreArchivo = NombreArchivo & "_" & CStr(f) & Extension
                    If Dir(NombreArchivo, vbNormal) <> "" Then
                        Kill(NombreArchivo)
                    End If

                    objFPImage.Save(NombreArchivo, nImgType, nFingerID)
                    PCT.Load(NombreArchivo)
                    BTN.Tag = 1
                    Kill(NombreArchivo)
                    If objFPImage.ErrorCode <> NBioAPIERROR_NONE Then
                        Exit For
                    End If
                Next f
            Else
                Mensaje = "Error en el método Export."
                PCT.Tag = 0
                Return False
            End If

            If objFPImage.ErrorCode = NBioAPIERROR_NONE Then
                Mensaje = ""
                PCT.Tag = 1
                Return True
            Else
                Mensaje = CStr(objFPImage.ErrorCode)
                PCT.Tag = 0
                Return False
            End If
        Catch
            PCT.Tag = 0
            Mensaje = "Error General."
            Return False
        End Try
    End Function

#End Region

#Region "Limpiar Huellas"

    Private Sub btn_Limpiar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar1.Click
        Call LimpiarHuellas(lbl_1, pct_1, pct_V1, btn_Limpiar1, gbx_ManoI.Text)
    End Sub

    Private Sub btn_Limpiar2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar2.Click
        Call LimpiarHuellas(lbl_2, pct_2, pct_V2, btn_Limpiar2, gbx_ManoI.Text)
    End Sub

    Private Sub btn_Limpiar3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar3.Click
        Call LimpiarHuellas(lbl_3, pct_3, pct_V3, btn_Limpiar3, gbx_ManoI.Text)
    End Sub

    Private Sub btn_Limpiar4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar4.Click
        Call LimpiarHuellas(lbl_4, pct_4, pct_V4, btn_Limpiar4, gbx_ManoI.Text)
    End Sub

    Private Sub btn_Limpiar5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar5.Click
        Call LimpiarHuellas(lbl_5, pct_5, pct_V5, btn_Limpiar5, gbx_ManoI.Text)
    End Sub

    Private Sub btn_Limpiar6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar6.Click
        Call LimpiarHuellas(lbl_6, pct_6, pct_V6, btn_Limpiar6, gbx_ManoD.Text)
    End Sub

    Private Sub btn_Limpiar7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar7.Click
        Call LimpiarHuellas(lbl_7, pct_7, pct_V7, btn_Limpiar7, gbx_ManoD.Text)
    End Sub

    Private Sub btn_Limpiar8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar8.Click
        Call LimpiarHuellas(lbl_8, pct_8, pct_V8, btn_Limpiar8, gbx_ManoD.Text)
    End Sub

    Private Sub btn_Limpiar9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar9.Click
        Call LimpiarHuellas(lbl_9, pct_9, pct_V9, btn_Limpiar9, gbx_ManoD.Text)
    End Sub

    Private Sub btn_Limpiar10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar10.Click
        Call LimpiarHuellas(lbl_10, pct_10, pct_V10, btn_Limpiar10, gbx_ManoD.Text)
    End Sub

    Sub LimpiarHuellas(ByVal lbl As Label, ByVal pct As PictureBox, ByVal pct_Validar As PictureBox, ByVal btn As Button, ByVal ManoEliminar As String)
        SegundosDesconexion = 0

        If MsgBox("Seguro desea eliminar la Huella '" & lbl.Text & "' de la '" & ManoEliminar & "'?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not fn_EmpleadosHuellas_HuellasT_Eliminar(Id_Empleado, Microsoft.VisualBasic.Mid(lbl.Name, 5)) Then
            MsgBox("Ocurrio un error al intentar eliminar la Huella '" & lbl.Text & "' de la '" & ManoEliminar & "'.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        pct.Image = Nothing
        pct.Tag = 0
        lbl.Tag = ""
        btn.Enabled = False
        pct_Validar.Visible = False
        Call CambiarColor(Microsoft.VisualBasic.Mid(lbl.Name, 5), My.Resources.Delete, Color.Red)

        If lbl_1.Tag <> "" AndAlso pct_1.Tag = 2 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_2.Tag <> "" AndAlso pct_2.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_3.Tag <> "" AndAlso pct_3.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_4.Tag <> "" AndAlso pct_4.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_5.Tag <> "" AndAlso pct_5.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_6.Tag <> "" AndAlso pct_6.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_7.Tag <> "" AndAlso pct_7.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_8.Tag <> "" AndAlso pct_8.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_9.Tag <> "" AndAlso pct_9.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub
        If lbl_10.Tag <> "" AndAlso pct_10.Tag = 1 Then btn_ValidarHuellas.Enabled = True : Exit Sub

        btn_ValidarHuellas.Enabled = False
    End Sub

#End Region

#Region "Exportar Imagenes"

    Sub ExtraerImagenes(ByVal pct As PictureBox, ByVal RutaExportar As String)
        Dim Copia As Bitmap = Nothing
        If pct.Tag > 0 Then
            If pct.Image IsNot Nothing Then
                Copia = New Bitmap(pct.Image)
                Copia.Save(RutaExportar, System.Drawing.Imaging.ImageFormat.Jpeg)
                Copia.Dispose()
            End If
        End If
    End Sub

    Private Sub btn_Extraer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Extraer.Click
        SegundosDesconexion = 0
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Try
            'Fotos
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - CuerpoCompleto.jpg")
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Frente.jpg")
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilDerecho.jpg")
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilIzquierdo.jpg")
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Firma.jpg")

            'Huellas
            'Mano Izquierda
            ExtraerImagenes(pct_1, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MeñiqueIzquierdo.jpg")
            ExtraerImagenes(pct_2, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - AnularIzquierdo.jpg")
            ExtraerImagenes(pct_3, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MedioIzquierdo.jpg")
            ExtraerImagenes(pct_4, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - IndiceIzquierdo.jpg")
            ExtraerImagenes(pct_5, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PulgarIzquierdo.jpg")
            'Mano Derecha
            ExtraerImagenes(pct_6, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PulgarDerecho.jpg")
            ExtraerImagenes(pct_7, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - IndiceDerecho.jpg")
            ExtraerImagenes(pct_8, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MedioDerecho.jpg")
            ExtraerImagenes(pct_9, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - AnularDerecho.jpg")
            ExtraerImagenes(pct_10, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MeñiqueDerecho.jpg")

            Me.Cursor = Cursors.Default
            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

#End Region

#Region "Validar Huellas"

    Private Sub btn_ValidarHuellas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ValidarHuellas.Click
        SegundosDesconexion = 0
        If TieneDispositivo = False Then
            MsgBox("El Dispositivo no esta disponible, consulte al Administrador.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        frm = New frm_EmpleadosIValidar

        For ILocal As Integer = 1 To 10
            Call CambiarColor(ILocal, My.Resources.Delete, Color.Red)
        Next

        frm.pct_Huella.Image = My.Resources.LogoNoDisponible
        frm.tbx_Empleado.Text = lbl_Clave.Text & " - " & lbl_Nombre.Text
        frm.tbx_Departamento.Text = Departamento
        frm.tbx_Puesto.Text = Puesto

        frm.Dt_Huellas.Columns.Add("Id", GetType(Integer))
        frm.Dt_Huellas.Columns.Add("Mano")
        frm.Dt_Huellas.Columns.Add("Dedo")
        frm.Dt_Huellas.Columns.Add("Huella")
        frm.Dt_Huellas.Columns.Add("CambiarColor")
        If lbl_1.Tag <> "" Then frm.Dt_Huellas.Rows.Add(1, gbx_ManoI.Text, lbl_1.Text, lbl_1.Tag, "N") : pct_V1.Visible = True
        If lbl_2.Tag <> "" Then frm.Dt_Huellas.Rows.Add(2, gbx_ManoI.Text, lbl_2.Text, lbl_2.Tag, "N") : pct_V2.Visible = True
        If lbl_3.Tag <> "" Then frm.Dt_Huellas.Rows.Add(3, gbx_ManoI.Text, lbl_3.Text, lbl_3.Tag, "N") : pct_V3.Visible = True
        If lbl_4.Tag <> "" Then frm.Dt_Huellas.Rows.Add(4, gbx_ManoI.Text, lbl_4.Text, lbl_4.Tag, "N") : pct_V4.Visible = True
        If lbl_5.Tag <> "" Then frm.Dt_Huellas.Rows.Add(5, gbx_ManoI.Text, lbl_5.Text, lbl_5.Tag, "N") : pct_V5.Visible = True
        If lbl_6.Tag <> "" Then frm.Dt_Huellas.Rows.Add(6, gbx_ManoD.Text, lbl_6.Text, lbl_6.Tag, "N") : pct_V6.Visible = True
        If lbl_7.Tag <> "" Then frm.Dt_Huellas.Rows.Add(7, gbx_ManoD.Text, lbl_7.Text, lbl_7.Tag, "N") : pct_V7.Visible = True
        If lbl_8.Tag <> "" Then frm.Dt_Huellas.Rows.Add(8, gbx_ManoD.Text, lbl_8.Text, lbl_8.Tag, "N") : pct_V8.Visible = True
        If lbl_9.Tag <> "" Then frm.Dt_Huellas.Rows.Add(9, gbx_ManoD.Text, lbl_9.Text, lbl_9.Tag, "N") : pct_V9.Visible = True
        If lbl_10.Tag <> "" Then frm.Dt_Huellas.Rows.Add(10, gbx_ManoD.Text, lbl_10.Text, lbl_10.Tag, "N") : pct_V10.Visible = True

        tmr_Huellas.Enabled = True

        frm.ShowDialog()

        Dim Contador As Integer = 0
        For Each Row As DataRow In frm.Dt_Huellas.Rows
            If Row("CambiarColor") = "S" Then
                Contador += 1
            End If
        Next

        If Contador >= 6 Then
            'Se actualizá sólo el campo de la Ultima Fecha de Validación.
            lbl_UltimaValidacion.ForeColor = Color.Green
            lbl_UltimaValidacion.Text = fn_EmpleadosHuellasT_Validado(Id_Empleado)
        Else
            MsgBox("Se deben de Validar por lo menos 6 Dedos para garantizar el proceso.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        tmr_Huellas.Enabled = False
    End Sub

    Private Sub tmr_Huellas_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Huellas.Tick
        If frm.Dt_Huellas Is Nothing AndAlso frm.Dt_Huellas.Rows.Count = 0 Then Exit Sub

        For Each Row As DataRow In frm.Dt_Huellas.Rows
            If Row("CambiarColor") = "S" Then
                Call CambiarColor(Row("Id"), My.Resources.HoraSi, Color.Green)
            End If
        Next
    End Sub

    Sub CambiarColor(ByVal Tipo As Integer, ByVal Imagen As Image, ByVal NuevoColor As Color)
        Select Case Tipo
            Case 1
                pct_V1.Image = Imagen
                pct_V1.Refresh()
                lbl_1.ForeColor = NuevoColor
                lbl_1.Refresh()

            Case 2
                pct_V2.Image = Imagen
                pct_V2.Refresh()
                lbl_2.ForeColor = NuevoColor
                lbl_2.Refresh()

            Case 3
                pct_V3.Image = Imagen
                pct_V3.Refresh()
                lbl_3.ForeColor = NuevoColor
                lbl_3.Refresh()

            Case 4
                pct_V4.Image = Imagen
                pct_V4.Refresh()
                lbl_4.ForeColor = NuevoColor
                lbl_4.Refresh()

            Case 5
                pct_V5.Image = Imagen
                pct_V5.Refresh()
                lbl_5.ForeColor = NuevoColor
                lbl_5.Refresh()

            Case 6
                pct_V6.Image = Imagen
                pct_V6.Refresh()
                lbl_6.ForeColor = NuevoColor
                lbl_6.Refresh()

            Case 7
                pct_V7.Image = Imagen
                pct_V7.Refresh()
                lbl_7.ForeColor = NuevoColor
                lbl_7.Refresh()

            Case 8
                pct_V8.Image = Imagen
                pct_V8.Refresh()
                lbl_8.ForeColor = NuevoColor
                lbl_8.Refresh()

            Case 9
                pct_V9.Image = Imagen
                pct_V9.Refresh()
                lbl_9.ForeColor = NuevoColor
                lbl_9.Refresh()

            Case 10
                pct_V10.Image = Imagen
                pct_V10.Refresh()
                lbl_10.ForeColor = NuevoColor
                lbl_10.Refresh()

        End Select
    End Sub

#End Region

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_EmpleadosI_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Call BorrarImagenes()
        Catch
        End Try
    End Sub

    Private Sub btn_ExtFotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtFotos.Click

        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Try
            'Imagenes
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - CuerpoCompleto.jpg")
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Frente.jpg")
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilDerecho.jpg")
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilIzquierdo.jpg")
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Firma.jpg")

            Me.Cursor = Cursors.Default
            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try

    End Sub

    Private Sub btn_ExtraerHuellas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerHuellas.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Try
            'Mano Izquierda
            ExtraerImagenes(pct_1, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MeñiqueIzquierdo.jpg")
            ExtraerImagenes(pct_2, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - AnularIzquierdo.jpg")
            ExtraerImagenes(pct_3, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MedioIzquierdo.jpg")
            ExtraerImagenes(pct_4, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - IndiceIzquierdo.jpg")
            ExtraerImagenes(pct_5, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PulgarIzquierdo.jpg")
            'Mano Derecha
            ExtraerImagenes(pct_6, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PulgarDerecho.jpg")
            ExtraerImagenes(pct_7, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - IndiceDerecho.jpg")
            ExtraerImagenes(pct_8, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MedioDerecho.jpg")
            ExtraerImagenes(pct_9, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - AnularDerecho.jpg")
            ExtraerImagenes(pct_10, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - MeñiqueDerecho.jpg")

            Me.Cursor = Cursors.Default
            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Huellas. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try

    End Sub

    Private Sub btn_ExtraerEntero_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerEntero.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - CuerpoCompleto.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

    Private Sub btn_ExtraerFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFrente.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Frente.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

    Private Sub btn_ExtraerDerecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerDerecho.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilDerecho.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

    Private Sub btn_ExtraerIzquierdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerIzquierdo.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - PerfilIzquierdo.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

    Private Sub btn_ExtraerFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFirma.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & "-" & lbl_Nombre.Text & " - Firma.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            Me.Cursor = Cursors.Default
            MsgBox("No se pudieron extraer las Fotos. " & Ex.Message, MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.TrataEx(Ex, False)
        End Try
    End Sub

    Private Function ExtraerDialogo() As String
        SegundosDesconexion = 0

        Dim RutaExportar As String = "C:\"
        Dim dialogo As New FolderBrowserDialog With {.ShowNewFolderButton = False, .Description = "Seleccione la Carpeta para las Imágenes"}
        dialogo.ShowDialog()
        If dialogo.SelectedPath = "" Then
            MsgBox("No seleccionó una Carpeta. No se exportarán las Imágenes.", MsgBoxStyle.Critical, frm_MENU.Text)
            Return ""
        End If
        RutaExportar = dialogo.SelectedPath
        If RutaExportar.Length <= 3 Then
            RutaExportar = Microsoft.VisualBasic.Left(RutaExportar, 2)
        End If
        dialogo.Dispose()
        Cn_Login.fn_Log_Create("EXTRAER FOTOS Y HUELLAS DEL EMPLEADO: " & lbl_Clave.Text & " - " & lbl_Nombre.Text)
        Return RutaExportar
    End Function
End Class