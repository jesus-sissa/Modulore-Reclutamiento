Imports System.IO
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_CargarDoctos
    Public IdEmp As Integer = 0
    Public NombreEmpleado As String = ""
    Public ClaveEmpleado As String = ""
    Public Lista As cp_Listview = Nothing

    Public Tipo As Query = Query.Empleados
    Dim EtiquetaTipo As String = ""
    Dim CampoIdElemento As String = ""
    Dim tempfile As String = Ruta_Temporal
    Dim RutaTmp As String = Ruta_Temporal
    Dim ContadorImagenes As Integer = 0
    Dim Dt_Doctos As DataTable = Nothing
    Dim CompresionImagen As Integer = 30
    Dim TamanoMaxImagen As Integer = 400

    <Flags()> _
    Enum Query As Byte
        Empleados
        Prospectos
        VisitasDomiciliarias
    End Enum

    Private Sub frm_CargarDoctos_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyUp
        SegundosDesconexion = 0

        Select Case e.KeyCode
            Case Keys.Escape
                Me.Close()
        End Select
    End Sub

    Private Sub frm_CargarDoctos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "Documentos de: " & NombreEmpleado

        ContadorImagenes = 1

        lsv_Archivos.Clear()
        lsv_Archivos.Columns.Add("Documento")
        lsv_Archivos.Columns.Add("Fecha")
        lsv_Archivos.Columns.Add("Hora")
        lsv_Archivos.Columns.Add("Usuario Registro")
        lsv_Archivos.Columns.Add("IdDR")
        lsv_Archivos.Columns.Add("IdED")
        FuncionesGlobales.fn_Columna(lsv_Archivos, 50, 20, 15, 50, 0, 0, 0, 0, 0, 0)

        cmb_Docto.StoredProcedure = "Cat_EmpleadosDoctosR_Get"
        cmb_Docto.ValueMember = "Id_DoctoR"
        cmb_Docto.DisplayMember = "Descripcion"
        cmb_Docto.Empresa = False
        cmb_Docto.Pista = False
        cmb_Docto.Sucursal = False
        cmb_Docto.AgregaParametro("@Status", "A", 0)
        cmb_Docto.Actualizar()
        cmb_Docto.Visible = True

        Select Case Tipo
            Case Query.Empleados
                EtiquetaTipo = "empleado"
                CampoIdElemento = "Id_EmpleadoDoctoI"

                Call ListaEmpleadosDoctos()

            Case Query.Prospectos
                EtiquetaTipo = "prospecto"
                CampoIdElemento = "Id_EmpleadoPDoctoI"

                Call ListaProspectosDoctos()
        End Select

        CompresionImagen = My.Settings.CompresionImagen
        TamanoMaxImagen = My.Settings.TamanoMaxImagen


    End Sub

    Sub ListaEmpleadosDoctos()
        Dt_Doctos = Nothing
        lsv_Archivos.Items.Clear()
        lsv_Archivos.SelectedItems.Clear()

        Call LimpiarImagen()

        Dt_Doctos = fn_EmpleadosDoctosI_Lista(IdEmp)

        If Dt_Doctos Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        End If

        Dim item As ListViewItem
        For Each dr_Docto As DataRow In Dt_Doctos.Rows
            item = New ListViewItem
            item.Tag = dr_Docto("Id_EmpleadoDoctoI")
            item.Text = dr_Docto("TipoDocumentoRecibido") '0
            item.SubItems.Add(dr_Docto("Fecha")) '1
            item.SubItems.Add(dr_Docto("Hora")) '2
            item.SubItems.Add(dr_Docto("UsuarioRegistro")) '3
            item.SubItems.Add(dr_Docto("Id_DoctoR")) '4
            item.SubItems.Add(dr_Docto("Id_EmpleadoDocto")) '5
            lsv_Archivos.Items.Add(item)
        Next

        Call Botones()
    End Sub

    Sub ListaProspectosDoctos()
        Dt_Doctos = Nothing
        lsv_Archivos.Items.Clear()
        lsv_Archivos.SelectedItems.Clear()

        Call LimpiarImagen()

        Dt_Doctos = fn_ProspectosDoctosI_Lista(IdEmp)

        If Dt_Doctos Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        End If

        Dim item As ListViewItem
        For Each dr_Docto As DataRow In Dt_Doctos.Rows
            item = New ListViewItem
            item.Tag = dr_Docto("Id_EmpleadoPDoctoI")
            item.Text = dr_Docto("TipoDocumentoRecibido") '0
            item.SubItems.Add(dr_Docto("Fecha")) '1
            item.SubItems.Add(dr_Docto("Hora")) '2
            item.SubItems.Add(dr_Docto("UsuarioRegistro")) '3
            item.SubItems.Add(dr_Docto("Id_DoctoR")) '4
            item.SubItems.Add(dr_Docto("Id_EmpleadoPDocto")) '5
            lsv_Archivos.Items.Add(item)
        Next

        Call Botones()
    End Sub

    Sub Botones()
        If lsv_Archivos.SelectedItems.Count > 0 Then
            btn_Limpiar.Enabled = True
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
            btn_Limpiar.Enabled = False
        End If

        If lsv_Archivos.Items.Count > 0 Then
            btn_LimpiarTodo.Enabled = True
            btn_ExportarTodos.Enabled = True
        Else
            btn_LimpiarTodo.Enabled = False
            btn_ExportarTodos.Enabled = False
        End If

    End Sub

    Sub LimpiarImagen()
        pct_Imagen.Image = My.Resources.LogoNoDisponible
        pct_Imagen.Tag = 0
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        If cmb_Docto.SelectedValue = 0 Then
            MsgBox("Seleccione un Documento.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim FrmI As New frm_ObtenerImagen
        Dim Imagen As Bitmap = Nothing
        Dim OrigenImagen As String = ""
        Dim PesoImagen As Decimal = 0
        Dim Mimetype As String = "IMAGE/JPEG"
        Dim NombreArchivo As String = "IMG"
        Dim Id_EmpleadoDocto As Integer = 0
        Dim Bytes As Byte()
        Dim fs

        FrmI.NombreEmpleado = NombreEmpleado
        FrmI.NombreDocumento = cmb_Docto.Text
        FrmI.ShowDialog()
        If Not FrmI.Aceptar Then
            FrmI.Dispose()
            Exit Sub
        End If

        If MsgBox("Confirma que desea agregar el documento: " & cmb_Docto.Text & " al expediente del " & EtiquetaTipo & ": " & _
                  NombreEmpleado, MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If


        Imagen = FrmI.ImagenRegresada
        OrigenImagen = FrmI.OrigenImagen
        FrmI.Dispose()

        tempfile = RutaTmp & NombreArchivo & ".jpg"

        If fn_ReducirImagen(NombreArchivo, Imagen, TamanoMaxImagen, CompresionImagen, RutaTmp, 0, 0) = "" Then
            MsgBox("Ocurrió un error al comprimir la imagen.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        fs = New System.IO.FileStream(RutaTmp & NombreArchivo & ".jpg", System.IO.FileMode.Open)
        Bytes = New Byte(fs.Length - 1) {}
        fs.Read(Bytes, 0, Bytes.Length)
        fs.Close()

        'compara que la imagen no este asignada a cualquier documento
        For Each Dr_Docto As DataRow In Dt_Doctos.Rows
            If Convert.ToBase64String(Dr_Docto("Archivo")) = Convert.ToBase64String(Bytes) Then
                If MsgBox("La imagen que intenta agregar ya fue registrada. ¿Desea agregarla nuevamente?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
                    Imagen = Nothing
                    OrigenImagen = ""
                    Exit Sub
                End If
            End If
        Next

        'busca si ya existe el documento en la lista de papeleria recibida
        For Each ItemPapeleria As ListViewItem In Lista.CheckedItems
            If ItemPapeleria.Tag = cmb_Docto.SelectedValue Then
                Id_EmpleadoDocto = ItemPapeleria.SubItems(3).Text
                Exit For
            End If
        Next

        If Id_EmpleadoDocto = 0 Then
            'busca si ya tiene imagen para ese documento
            For Each ItemDocto As ListViewItem In lsv_Archivos.Items
                If ItemDocto.SubItems(4).Text = cmb_Docto.SelectedValue Then
                    Id_EmpleadoDocto = ItemDocto.SubItems(5).Text
                    Exit For
                End If
            Next
        End If

        'elimina el archivo temporal de la imagen
        Try
            File.Delete(RutaTmp & NombreArchivo & ".jpg")
        Catch ex As Exception
        End Try

        'aqui verifica si es empleado o prospecto
        Select Case Tipo
            Case Query.Empleados
                If Not fn_EmpleadosDoctos_Guardar(IdEmp, cmb_Docto.SelectedValue, Id_EmpleadoDocto, "", Mimetype, Bytes, cmb_Docto.Text) Then
                    MsgBox("Ocurrió un error al guardar el archivo.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("SE AGREGO DOCUMENTO: " & cmb_Docto.Text & " / DESDE: " & OrigenImagen)
                Call ListaEmpleadosDoctos()

            Case Query.Prospectos
                If Not fn_ProspectosDoctos_Guardar(IdEmp, cmb_Docto.SelectedValue, Id_EmpleadoDocto, "", Mimetype, Bytes, cmb_Docto.Text) Then
                    MsgBox("Ocurrió un error al guardar el archivo.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("SE AGREGO DOCUMENTO: " & cmb_Docto.Text & " / DESDE: " & OrigenImagen)
                Call ListaProspectosDoctos()

        End Select

        ContadorImagenes = ContadorImagenes + 1

    End Sub

    Public Shared Function fn_ReducirImagen(ByVal Nombre As String, ByVal Imagen As Image, ByVal TamanoMax As Integer, ByVal Compresion As Integer, ByVal RutaTemp As String, ByVal AnchoDeseado As Integer, ByVal AltoDeseado As Integer) As String
        Dim Resulta1 As String = RutaTemp & Nombre & ".jpg"
        Dim Resulta2 As String = RutaTemp & Nombre & "_Copia.jpg"
        Try
            'Las imagenes que se crean y su nombre
            If System.IO.File.Exists(Resulta1) Then File.Delete(Resulta1)
            If System.IO.File.Exists(Resulta2) Then File.Delete(Resulta2)
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
                        File.Delete(Resulta1)
                        ImagenLocal = Image.FromFile(Resulta2)
                        FileSize = fn_TamañoArchivo(Resulta2)
                    Else
                        ImagenLocal.Dispose()
                        ImagenLocal = Image.FromFile(Resulta2)
                        ImagenLocal.Save(Resulta1, iciJpegCodec, epParameters)
                        ImagenLocal.Dispose()
                        File.Delete(Resulta2)
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
                File.Delete(Resulta2)
                Return Resulta1
            Else
                Return ""
            End If
        Catch
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

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Limpiar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Limpiar.Click
        SegundosDesconexion = 0

        If lsv_Archivos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Documento de la lista.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If MsgBox("Confirma que desea eliminar la imagen del documento " & lsv_Archivos.SelectedItems(0).Text & _
                  " del " & EtiquetaTipo & ": " & NombreEmpleado, MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If

        Select Case Tipo
            Case Query.Empleados
                If Not fn_EmpleadosDoctosI_Eliminar(lsv_Archivos.SelectedItems(0).Tag) Then
                    MsgBox("Ocurrió un error al intentar eliminar el Documento.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("SE ELIMINO DOCUMENTO: " & lsv_Archivos.SelectedItems(0).Text)
                Call ListaEmpleadosDoctos()

            Case Query.Prospectos
                If Not fn_ProspectosDoctosI_Eliminar(lsv_Archivos.SelectedItems(0).Tag) Then
                    MsgBox("Ocurrió un error al intentar eliminar el Documento.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If
                Cn_Login.fn_Log_Create("SE ELIMINO DOCUMENTO: " & lsv_Archivos.SelectedItems(0).Text)
                Call ListaProspectosDoctos()

        End Select

    End Sub

    Private Sub btn_LimpiarTodo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarTodo.Click
        'Este boton se oculta temporalmente
        SegundosDesconexion = 0

        If lsv_Archivos.Items.Count = 0 Then
            MsgBox("No se tienen Documentos para eliminar.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If MsgBox("Confirma que desea eliminar todas las imagenes de los documentos.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
            Exit Sub
        End If


        Select Case Tipo
            Case Query.Empleados
                If Not fn_EmpleadosDoctos_EliminarMasivo(lsv_Archivos) Then
                    MsgBox("Ocurrió un error al intentar eliminar todos los Documentos.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If

                For Each itemDocto As ListViewItem In lsv_Archivos.Items
                    Cn_Login.fn_Log_Create("EN EVENTO MASIVO SE ELIMINO DOCUMENTO: " & itemDocto.Text)
                Next

                Call ListaEmpleadosDoctos()

            Case Query.Prospectos
                If Not fn_ProspectosDoctos_EliminarMasivo(lsv_Archivos) Then
                    MsgBox("Ocurrió un error al intentar eliminar todos los Documentos.", MsgBoxStyle.Critical, Me.Text)
                    Exit Sub
                End If

                For Each itemDocto As ListViewItem In lsv_Archivos.Items
                    Cn_Login.fn_Log_Create("EN EVENTO MASIVO SE ELIMINO DOCUMENTO: " & itemDocto.Text)
                Next

                Call ListaProspectosDoctos()

        End Select

    End Sub

    Private Sub lsv_Archivos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Archivos.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Archivos.SelectedItems.Count = 0 Then
            Call LimpiarImagen()

            Call Botones()
            Exit Sub
        End If

        Dim Id_EmpleadoDoctoI As Integer = lsv_Archivos.SelectedItems(0).Tag
        Dim Indice As Integer = -1

        Dim Bytes() As Byte = Nothing


        For Each Dr_Docto As DataRow In Dt_Doctos.Rows
            If Dr_Docto(CampoIdElemento) = Id_EmpleadoDoctoI Then
                If Dr_Docto("MimeType").ToString.ToUpper = "IMAGE/JPEG" Then
                    Bytes = Dr_Docto("Archivo")
                    Dim ms_Imagen As MemoryStream = New MemoryStream(Bytes.Length)
                    ms_Imagen.Write(Bytes, 0, Bytes.Length)
                    pct_Imagen.Image = Image.FromStream(ms_Imagen, True)
                    pct_Imagen.Tag = 1
                    ms_Imagen.Close()
                    ms_Imagen.Dispose()
                Else
                    pct_Imagen.Image = My.Resources.LogoNoDisponible
                End If
                Exit For
            End If
        Next


        Call Botones()
    End Sub

    Private Sub pct_Imagen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Imagen.Click
        SegundosDesconexion = 0

        If pct_Imagen.Tag = 0 Then Exit Sub

        Dim frm As New frm_VisorImagenes
        frm.Imagen = pct_Imagen.Image
        frm.ShowDialog()

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino del Archivo.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim CarpetaDestino As String = Dialogo.SelectedPath
        Dim NombreArchivo As String = ClaveEmpleado & "-" & lsv_Archivos.SelectedItems(0).Text & ".jpg"

        If CarpetaDestino.Length = 3 Then
            CarpetaDestino = CarpetaDestino & NombreArchivo
        Else
            CarpetaDestino = CarpetaDestino & "\" & NombreArchivo
        End If

        Dim Id_EmpleadoDoctoI As Integer = lsv_Archivos.SelectedItems(0).Tag
        Dim Indice As Integer = -1

        Dim Bytes() As Byte = Nothing

        For Each Dr_Docto As DataRow In Dt_Doctos.Rows
            If Dr_Docto(CampoIdElemento) = Id_EmpleadoDoctoI Then
                If Dr_Docto("MimeType").ToString.ToUpper = "IMAGE/JPEG" Then
                    Bytes = Dr_Docto("Archivo")
                End If
                Exit For
            End If
        Next

        Try

            If File.Exists(CarpetaDestino) Then
                If MsgBox("El Archivo ya existe en la carpeta seleccionada. ¿Desea reemplazarlo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
                    Exit Sub
                End If
            End If

            Using fs As New FileStream(CarpetaDestino, FileMode.OpenOrCreate, FileAccess.Write)
                fs.Write(Bytes, 0, Bytes.Length)
                'Set image variable value using memory stream. 
                fs.Flush()
                fs.Close()
            End Using

            'Open File
            If MsgBox("El Archivo se descargó correctamente. Desea Abrirlo?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, Me.Text) = MsgBoxResult.Yes Then
                Process.Start(CarpetaDestino)
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar guardar el Archivo. " & ex.Message, MsgBoxStyle.Critical, Me.Text)
        End Try

    End Sub

    Private Sub btn_ExportarTodos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarTodos.Click
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog With {.Description = "Destino de los Archivos.", .ShowNewFolderButton = True}

        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Exit Sub
        Dim CarpetaDestino As String = Dialogo.SelectedPath
        'Tomando en cuenta que el nombre del archivo a guardar no tiene extensión
        If CarpetaDestino.Length <= 3 Then
            MsgBox("Seleccione una Carpeta Válida para la Extracción de los Archivos.", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Exit Sub
        Else
            CarpetaDestino = CarpetaDestino & "\" & NombreEmpleado & "\"
        End If

        Try

            If Directory.Exists(CarpetaDestino) Then
                If MsgBox("Ya existe un expediente con el nombre del " & EtiquetaTipo & ", si continúa el expediente se reemplazará." & vbNewLine & _
                           "¿Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) <> MsgBoxResult.Yes Then
                    Exit Sub
                Else
                    Directory.Delete(CarpetaDestino, True)
                End If
            End If

            Directory.CreateDirectory(CarpetaDestino)
            Dim Contador As Integer = 1
            Dim Bytes() As Byte = Nothing
            Dim NombreArchivo As String = ""

            For Each Dr_Docto As DataRow In Dt_Doctos.Rows
                Bytes = Dr_Docto("Archivo")
                NombreArchivo = CarpetaDestino & Contador.ToString & "_" & ClaveEmpleado & "-" & Dr_Docto("TipoDocumentoRecibido") & ".jpg"
                Using fs As New FileStream(NombreArchivo, FileMode.OpenOrCreate, FileAccess.Write)
                    fs.Write(Bytes, 0, Bytes.Length)
                    'Set image variable value using memory stream. 
                    fs.Flush()
                    fs.Close()
                End Using
                Contador = Contador + 1
            Next

            MsgBox("Los archivos se descargaron correctamente.", MsgBoxStyle.Information, Me.Text)

        Catch ex As Exception
            MsgBox("Ocurrió un error al intentar descargar los archivos.", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub
End Class