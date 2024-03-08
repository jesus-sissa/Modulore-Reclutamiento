Imports System.IO
Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales


Public Class frm_EmpleadosI2
    Public Id_Empleado As Integer
    Public Clave As String
    Public Nombre As String
    Public Departamento As String = ""
    Public Puesto As String = ""
    Public Hubo_Cambios As Boolean = False
    Dim TeniaImagenes As Boolean = False
    Dim FileSize As Long = 0
    Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Imagen|*.jpg", .Multiselect = False}
    Dim HuellasImagen(9) As Image

    Private Sub frm_EmpleadosI_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dialogo.InitialDirectory = "C:\"

        If Not Directory.Exists(Ruta_Temporal) Then
            System.IO.Directory.CreateDirectory(Ruta_Temporal)
        End If

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

        btn_ExtraerTodo.Enabled = False

        'Consultar Imagenes-->Empleado
        Dim dr As DataRow = fn_Empleados_LeerImagenes(Id_Empleado)
        If dr IsNot Nothing Then
            TeniaImagenes = True
            btn_ExtraerTodo.Enabled = True
            btn_ExtraerFotos.Enabled = True
            'Frente
            MostrarImagen(dr, pct_Frente, "Frente", "TieneFrente", btn_LimpiarFrente)
            'Perfil derecho
            MostrarImagen(dr, pct_Derecho, "Perfil_Derecho", "TienePerfil_Derecho", btn_LimpiarDerecho)
            'Perfil Izquierdo
            MostrarImagen(dr, pct_Izquierdo, "Perfil_Izquierdo", "TienePerfil_Izquierdo", btn_LimpiarIzquierdo)
            'Cuerpo Completo
            MostrarImagen(dr, pct_Completo, "Cuerpo_Completo", "TieneCuerpo_Completo", btn_LimpiarCompleto)
            'Firma
            MostrarImagen(dr, pct_Firma, "Firma", "TieneFirma", btn_LimpiarFirma)
            'Código
            MostrarImagen(dr, pct_Codigo, "Codigo", "TieneCodigo", btn_codigo)
        End If

        'Leer Huellas -> Template(Huellas ZK)
        Call LeerHuellasT()

        'Arreglo de Dedos versiones ZK 9 y 10
        Dim Dedos() As String = {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", _
                                  "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce", _
                                  "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte"}
        'Leer las HuellasImagen-->
        dr = Cn_Reclutamiento.fn_Empleados_LeerHuellas(Id_Empleado)
        If dr IsNot Nothing Then
            For pos As Integer = 0 To 9
                If Not IsDBNull(dr(Dedos(pos))) Then
                    Dim ms1 As MemoryStream = New MemoryStream(dr(Dedos(pos)), 0, dr(Dedos(pos)).Length)
                    ms1.Write(dr(Dedos(pos)), 0, dr(Dedos(pos)).Length)
                    HuellasImagen(pos) = Image.FromStream(ms1, True)
                    btn_ExtraerHuellas.Enabled = True
                End If
            Next
        End If
    End Sub

    Private Sub frm_EmpleadosI_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Call BorrarImagenes()
    End Sub

    Sub MostrarImagen(ByVal DaRow As DataRow, ByRef PCT As PictureBox, ByVal FotoRevisar As String, _
                      ByVal TieneImagen As String, ByVal Boton As Button)
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

    Sub BorrarImagenes()
        Try
            If File.Exists(Ruta_Temporal & "PCT_Completo.jpg") Then Kill(Ruta_Temporal & "PCT_Completo.jpg")
        Catch
        End Try
        Try
            If File.Exists(Ruta_Temporal & "PCT_Frente.jpg") Then Kill(Ruta_Temporal & "PCT_Frente.jpg")
        Catch
        End Try
        Try
            If File.Exists(Ruta_Temporal & "PCT_Derecho.jpg") Then Kill(Ruta_Temporal & "PCT_Derecho.jpg")
        Catch
        End Try
        Try
            If File.Exists(Ruta_Temporal & "PCT_Izquierdo.jpg") Then Kill(Ruta_Temporal & "PCT_Izquierdo.jpg")
        Catch
        End Try
        Try
            If File.Exists(Ruta_Temporal & "PCT_Firma.jpg") Then Kill(Ruta_Temporal & "PCT_Firma.jpg")
        Catch
        End Try
    End Sub

    Sub Extraer()
        'Extraer las imagenes de los PCTs que contengan una Imagen
        Call BorrarImagenes()

        If pct_Completo.Tag = 1 Then
            Dim ImagenCompleto As New Bitmap(pct_Completo.Image)
            ImagenCompleto.Save(Ruta_Temporal & "PCT_Completo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Frente.Tag = 1 Then
            Dim ImagenFrente As New Bitmap(pct_Frente.Image)

            'ImagenFrente.Save(Ruta_Temporal & "PCT_Frente.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

            Dim ms As New MemoryStream()
            ImagenFrente.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            ms.Seek(0, SeekOrigin.Begin)
            Image.FromStream(ms).Save(Ruta_Temporal & "PCT_Frente.jpg")
            ms.Close()
            ms.Dispose()


        End If
        If pct_Derecho.Tag = 1 Then
            Dim ImagenDerecho As New Bitmap(pct_Derecho.Image)
            ImagenDerecho.Save(Ruta_Temporal & "PCT_Derecho.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Izquierdo.Tag = 1 Then
            Dim ImagenIzquierdo As New Bitmap(pct_Izquierdo.Image)
            ImagenIzquierdo.Save(Ruta_Temporal & "PCT_Izquierdo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
        If pct_Firma.Tag = 1 Then
            Dim ImagenFirma As New Bitmap(pct_Firma.Image)
            ImagenFirma.Save(Ruta_Temporal & "PCT_Firma.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
        End If
    End Sub

    Sub GuardarImagenes_Bytes(ByVal Nombre As String, ByVal Mensaje As String, ByVal TipoI As TipoFoto)
        Dim Bytes As Byte()
        Dim fs 'As New System.IO.FileStream("", FileMode.Open)

        If Not File.Exists(Ruta_Temporal & Nombre) Then Exit Sub

        fs = New System.IO.FileStream(Ruta_Temporal & Nombre, System.IO.FileMode.Open)
        Bytes = New Byte(fs.Length - 1) {}
        fs.Read(Bytes, 0, Bytes.Length)
        fs.Close()

        If Not fn_EmpleadosI_Actualizar(Id_Empleado, Bytes, TeniaImagenes, TipoI) Then
            Me.Cursor = Cursors.Default
            MsgBox("Error al intentar guardar la " & Mensaje, MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            TeniaImagenes = True
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Me.Cursor = Cursors.WaitCursor
        '24/10/2014 Las Huellas se guardan al Ir Capturando en la pantalla Huellas.
        Cn_Login.fn_Log_Create("GUARDAR FOTOS DEL EMPLEADO: " & lbl_Clave.Text & " - " & lbl_Nombre.Text)

        Dim TipoActualizaImagen As Integer

        TipoActualizaImagen = 0 'No actualizar Imagenes

        Call Extraer()

        Call GuardarImagenes_Bytes("PCT_Completo.jpg", "Foto de Cuerpo Completo.", TipoFoto.CuerpoCompleto)
        Call GuardarImagenes_Bytes("PCT_Frente.jpg", "Foto de Frente.", TipoFoto.Frente)
        Call GuardarImagenes_Bytes("PCT_Derecho.jpg", "Foto de Perfil Derecho.", TipoFoto.Derecho)
        Call GuardarImagenes_Bytes("PCT_Izquierdo.jpg", "Foto de Perfil Izquierdo.", TipoFoto.Izquierdo)
        Call GuardarImagenes_Bytes("PCT_Firma.jpg", "Firma.", TipoFoto.Firma)

        Call BorrarImagenes()

        MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Huellas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Huellas.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Huellas
        frm.Id_Empleado = Id_Empleado
        frm.ShowDialog()

        'Leer Huellas
        Call LeerHuellasT()
    End Sub

    Private Sub LeerHuellasT()

        'Leer Huellas -> Template
        Dim dr As DataRow = fn_Empleados_LeerHuellasT(Id_Empleado, 0)
        If dr IsNot Nothing Then
            'Cuando se tenga guardado la nueva versión se pondrá también en el If ' AndAlso dr("Once") <> "" '
            If dr("Uno") <> "" AndAlso dr("Once") <> "" Then lbl_0.Image = My.Resources.HoraSi
            If dr("Dos") <> "" AndAlso dr("Doce") <> "" Then lbl_1.Image = My.Resources.HoraSi
            If dr("Tres") <> "" AndAlso dr("Trece") <> "" Then lbl_2.Image = My.Resources.HoraSi
            If dr("Cuatro") <> "" AndAlso dr("Catorce") <> "" Then lbl_3.Image = My.Resources.HoraSi
            If dr("Cinco") <> "" AndAlso dr("Quince") <> "" Then lbl_4.Image = My.Resources.HoraSi
            If dr("Seis") <> "" AndAlso dr("Dieciseis") <> "" Then lbl_5.Image = My.Resources.HoraSi
            If dr("Siete") <> "" AndAlso dr("Diecisiete") <> "" Then lbl_6.Image = My.Resources.HoraSi
            If dr("Ocho") <> "" AndAlso dr("Dieciocho") <> "" Then lbl_7.Image = My.Resources.HoraSi
            If dr("Nueve") <> "" AndAlso dr("Diecinueve") <> "" Then lbl_8.Image = My.Resources.HoraSi
            If dr("Diez") <> "" AndAlso dr("Veinte") <> "" Then lbl_9.Image = My.Resources.HoraSi
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

#Region "Capturar Imagenes (Desde Archivo o Desde Cámara)"

    Sub Examinar(ByVal Pct As PictureBox, ByVal Btn As Button, ByVal NombreJPG As String)
        Dialogo.ShowDialog()

        If Dialogo.FileName <> "" Then
            Me.Cursor = Cursors.WaitCursor
            btn_Guardar.Enabled = True
            Dim Imagen As Image = CargarImagen(Dialogo.FileName)


            Pct.Image = CargarImagen(fn_ReducirImagen(NombreJPG, Imagen, 200000, 30, Ruta_Temporal, 800, 600))
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

    Public Function CargarImagen(path As String) As Image
        Dim ms As MemoryStream = Nothing
        Dim Imagen As Image
        Dim ImagenB As Byte() = File.ReadAllBytes(path)
        ms = New MemoryStream(ImagenB)
        Imagen = Image.FromStream(ms, True)
        Return Imagen
    End Function


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

    Private Sub btns_Examinar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarCompleto.Click, btn_ExaminarFrente.Click, btn_ExaminarDerecho.Click, btn_ExaminarIzquierdo.Click, btn_ExaminarFirma.Click
        'No le debo mandar la extensión porque cuando la reduce se la pone

        Select Case sender.Name
            Case btn_ExaminarCompleto.Name
                Call Examinar(pct_Completo, btn_LimpiarCompleto, "PCT_Completo")


            Case btn_ExaminarFrente.Name
                Call Examinar(pct_Frente, btn_LimpiarFrente, "PCT_Frente")

            Case btn_ExaminarDerecho.Name
                Call Examinar(pct_Derecho, btn_LimpiarDerecho, "PCT_Derecho")

            Case btn_ExaminarIzquierdo.Name
                Call Examinar(pct_Izquierdo, btn_LimpiarIzquierdo, "PCT_Izquierdo")

            Case btn_ExaminarFirma.Name
                Call Examinar(pct_Firma, btn_LimpiarFirma, "PCT_Firma")

        End Select


    End Sub

    Private Sub btns_Tomar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarCompleto.Click, btn_TomarFrente.Click, btn_TomarDerecho.Click, btn_TomarIzquierdo.Click, btn_TomarFirma.Click
        Select Case sender.Name
            Case btn_TomarCompleto.Name
                Call CapturarCamara(pct_Completo, btn_LimpiarCompleto)

            Case btn_TomarFrente.Name
                Call CapturarCamara(pct_Frente, btn_LimpiarFrente)

            Case btn_TomarDerecho.Name
                Call CapturarCamara(pct_Derecho, btn_LimpiarDerecho)

            Case btn_TomarIzquierdo.Name
                Call CapturarCamara(pct_Izquierdo, btn_LimpiarIzquierdo)

            Case btn_TomarFirma.Name
                Call CapturarCamara(pct_Firma, btn_LimpiarFirma)

        End Select
    End Sub

#End Region

#Region "Limpiar Imagenes"

    Sub LimpiarImagenes(ByVal Pct As PictureBox, ByVal NombreJPG As String, ByVal NombreEliminar As String)
        SegundosDesconexion = 0

        Pct.Image = Nothing

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

            Pct.Tag = 2
            Try
                If File.Exists(Ruta_Temporal & NombreJPG) Then Kill(Ruta_Temporal & NombreJPG)
            Catch
            End Try
        Else
            Pct.Tag = 0
        End If
    End Sub

    Private Sub btns_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarCompleto.Click, btn_LimpiarFrente.Click, btn_LimpiarDerecho.Click, btn_LimpiarIzquierdo.Click, btn_LimpiarFirma.Click
        Select Case sender.Name
            Case btn_LimpiarCompleto.Name
                Call LimpiarImagenes(pct_Completo, "PCT_Completo.jpg", gbx_CuerpoEntero.Text)

            Case btn_LimpiarFrente.Name
                Call LimpiarImagenes(pct_Frente, "PCT_Frente.jpg", gbx_Frente.Text)

            Case btn_LimpiarDerecho.Name
                Call LimpiarImagenes(pct_Derecho, "PCT_Derecho.jpg", gbx_Derecho.Text)

            Case btn_LimpiarIzquierdo.Name
                Call LimpiarImagenes(pct_Izquierdo, "PCT_Izquierdo.jpg", gbx_Izquierdo.Text)

            Case btn_LimpiarFirma.Name
                Call LimpiarImagenes(pct_Firma, "PCT_Firma.jpg", gbx_Derecho.Text)

        End Select
        sender.Enabled = False
    End Sub

#End Region

#Region "Exportar Imagenes"

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

    Private Sub ExtraerImagenes(ByVal pct As PictureBox, ByVal RutaExportar As String)
        Dim Copia As Bitmap = Nothing
        If pct.Tag > 0 Then
            If pct.Image IsNot Nothing Then
                Copia = New Bitmap(pct.Image)
                Copia.Save(RutaExportar, System.Drawing.Imaging.ImageFormat.Jpeg)
                Copia.Dispose()
            End If
        End If
    End Sub

    Private Sub ExtraerHuelllas(ByVal img As Image, ByVal RutaExportar As String)
        Dim Copia As Bitmap = Nothing

        If img IsNot Nothing Then
            Copia = New Bitmap(img)
            Copia.Save(RutaExportar, System.Drawing.Imaging.ImageFormat.Jpeg)
            Copia.Dispose()
        End If
    End Sub

    Private Sub btn_ExtraerTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerTodo.Click
        Dim RutaExportar As String = ExtraerDialogo()
        If RutaExportar = "" Then Exit Sub

        Try
            'Extraer las Fotos
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & " - CuerpoCompleto.jpg")
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & " - Frente.jpg")
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & " - PerfilDerecho.jpg")
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & " - PerfilIzquierdo.jpg")
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & " - Firma.jpg")

            'Extraer las Huellas --> Mano(Izquierda)
            ExtraerHuelllas(HuellasImagen(0), RutaExportar & "\" & lbl_Clave.Text & " - MeñiqueIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(1), RutaExportar & "\" & lbl_Clave.Text & " - AnularIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(2), RutaExportar & "\" & lbl_Clave.Text & " - MedioIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(3), RutaExportar & "\" & lbl_Clave.Text & " - IndiceIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(4), RutaExportar & "\" & lbl_Clave.Text & " - PulgarIzquierdo.jpg")

            'Extraer las Huellas--> Mano Derecha
            ExtraerHuelllas(HuellasImagen(5), RutaExportar & "\" & lbl_Clave.Text & " - PulgarDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(6), RutaExportar & "\" & lbl_Clave.Text & " - IndiceDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(7), RutaExportar & "\" & lbl_Clave.Text & " - MedioDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(8), RutaExportar & "\" & lbl_Clave.Text & " - AnularDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(9), RutaExportar & "\" & lbl_Clave.Text & " - MeñiqueDerecho.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudieron extraer las Fotos y Huellas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerFotos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFotos.Click
        Dim RutaExportar As String = ExtraerDialogo()
        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & " - CuerpoCompleto.jpg")
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & " - Frente.jpg")
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & " - PerfilDerecho.jpg")
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & " - PerfilIzquierdo.jpg")
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & " - Firma.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudieron extraer las Fotos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerHuellas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerHuellas.Click
        Dim RutaExportar As String = ExtraerDialogo()
        If RutaExportar = "" Then Exit Sub
        Me.Cursor = Cursors.WaitCursor

        Try
            'Mano(Izquierda)
            ExtraerHuelllas(HuellasImagen(0), RutaExportar & "\" & lbl_Clave.Text & " - MeñiqueIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(1), RutaExportar & "\" & lbl_Clave.Text & " - AnularIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(2), RutaExportar & "\" & lbl_Clave.Text & " - MedioIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(3), RutaExportar & "\" & lbl_Clave.Text & " - IndiceIzquierdo.jpg")
            ExtraerHuelllas(HuellasImagen(4), RutaExportar & "\" & lbl_Clave.Text & " - PulgarIzquierdo.jpg")

            'Mano Derecha
            ExtraerHuelllas(HuellasImagen(5), RutaExportar & "\" & lbl_Clave.Text & " - PulgarDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(6), RutaExportar & "\" & lbl_Clave.Text & " - IndiceDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(7), RutaExportar & "\" & lbl_Clave.Text & " - MedioDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(8), RutaExportar & "\" & lbl_Clave.Text & " - AnularDerecho.jpg")
            ExtraerHuelllas(HuellasImagen(9), RutaExportar & "\" & lbl_Clave.Text & " - MeñiqueDerecho.jpg")

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
            ExtraerImagenes(pct_Completo, RutaExportar & "\" & lbl_Clave.Text & " - CuerpoCompleto.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudo extraer la Foto de Cuerpo Entero.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFrente.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Frente, RutaExportar & "\" & lbl_Clave.Text & " - Frente.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudo extraer la Foto de Frente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFirma.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Firma, RutaExportar & "\" & lbl_Clave.Text & " - Firma.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudo extraer la Firma.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerIzquierdo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerIzquierdo.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Izquierdo, RutaExportar & "\" & lbl_Clave.Text & " - PerfilIzquierdo.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudo extraer la Foto de Perfil Izquierdo.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_ExtraerDerecho_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerDerecho.Click
        Dim RutaExportar As String = ExtraerDialogo()

        If RutaExportar = "" Then Exit Sub

        Try
            ExtraerImagenes(pct_Derecho, RutaExportar & "\" & lbl_Clave.Text & " - PerfilDerecho.jpg")

            MsgBox("Proceso Finalizado.", MsgBoxStyle.Information, frm_MENU.Text)

        Catch Ex As Exception
            MsgBox("No se pudo extraer la Foto de Perfil Derecho.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

#End Region

#Region "Zoom"
    Private Sub pcts_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Completo.Click, pct_Frente.Click, pct_Derecho.Click, pct_Izquierdo.Click, pct_Firma.Click
        SegundosDesconexion = 0

        Dim frm As New frm_VisorImagenes
        frm.Imagen = sender.Image
        frm.ShowDialog()
    End Sub

#End Region

End Class