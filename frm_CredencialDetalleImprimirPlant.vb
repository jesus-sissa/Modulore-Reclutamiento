Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_CredencialDetalleImprimirPlant
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

    'Funciones de Dibujado en Rectangulo
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawImageRect", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawImageRect(ByVal fileName As Byte(), ByVal x As Integer, ByVal y As Integer, _
                                               ByVal width As Integer, ByVal height As Integer, ByRef err As Integer) As Integer
    End Function

    'Funcion para Texto en Rectangulo
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawTextRect", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawTextRect(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, ByVal height As Integer, _
                                           ByVal alignment As Integer, ByVal text As Byte(), ByVal font As Byte(), ByVal fontSize As Integer, _
                                           ByVal fontStyle As Integer, ByVal color As Integer, ByRef err As Integer) As Integer
    End Function

    'Funcion para Rectangulo
    <DllImport("ZBRGraphics.dll", EntryPoint:="ZBRGDIDrawRectangle", CharSet:=CharSet.Auto, SetLastError:=True)> _
    Public Shared Function ZBRGDIDrawRectangle(ByVal x As Integer, ByVal y As Integer, ByVal width As Integer, _
                                                ByVal height As Integer, ByVal thickness As Single, ByVal color As Integer, _
                                                ByRef Err As Integer) As Integer
    End Function

    Public Shared Function ImageToByteArray(ByVal filename As String) As Byte()
        Dim ms As New MemoryStream()
        Dim img As Image = System.Drawing.Image.FromFile(filename)
        img.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp)
        Dim arr As Byte() = ms.ToArray()
        ms = Nothing
        Return arr
    End Function

    '*************Variables de ZEBRA****************************
    Dim hDC As IntPtr = IntPtr.Zero
    Dim err As Integer = 0
    Dim fontSize As Integer
    Dim fontBold As Integer = &H1
    Dim fontColor As Integer = &H0
    'Dim printerName As String = "HP Laser Jet Professional P1606dn"
    Dim printerName As String
    'Dim printerName As String = "Zebra ZXP Series 3 USB Card Printer"
    Dim Ruta As String = "C:\Siac\Temporales\"

    '************************************************************
    '--variables editor imagen

    Private Mover As Boolean = False
    Private p_Mouse As Point = Nothing
    Private img As Image
    Private Clave_PlantillaFrente As String
    Private Clave_PlantillaReverso As String
    Dim cropBitmap As Bitmap
    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Yellow
    Public ban As String = ""
    '--variables editor imagen
    Private imgEditado As Image
    Dim banderaImg As Boolean = False
    Dim AnchoMascara As Short
    Dim AltoMascara As Short
    '--------------------------
    Public TipoEmpleado As Byte = 1 ' Interno
    Public Id_Credencial As Integer
    Dim dr_Credenciales As DataRow
    Dim Tiene_Firma As Boolean

    Private Sub frm_CredencialDetalleImprimirPlant_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_CredencialDetalleImprimirPlant_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '---Ponemos una mascara en el  Picturebox
        ptb_Foto.Controls.Add(ptb_mascara)
        ban = ""
        ptb_Foto.Width = 248 'siempre al tamaño original
        ptb_Foto.Height = 186

        'cargar los datos de la credencial
        'NOTA: En Cat_EmpleadosCredenciales hay un campo Tipo: 1=Empleados; 2=EmpleadosXF (Empleados por fuera)
        If TipoEmpleado = 1 Then
            dr_Credenciales = Cn_Reclutamiento.fn_Credenciales_ObtenValores(Id_Credencial)
        Else
            dr_Credenciales = Cn_Reclutamiento.fn_CredencialesXF_ObtenValores(Id_Credencial)
        End If

        If dr_Credenciales Is Nothing Then
            MsgBox("Ocurrió un error al cargar la información del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If

        'cunsultar las plantillas
        Dim dt_Plantilla As DataTable = Cn_Reclutamiento.fn_ConsultarPlantilla()

        If dt_Plantilla Is Nothing Then
            MsgBox("Ocurrió un Error al intentar obtener los Datos de la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If
        If dt_Plantilla.Rows.Count = 0 Then
            MsgBox("No se encontraron los Datos de la Plantilla de Impresion.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
            Exit Sub
        End If

        Clave_PlantillaFrente = dt_Plantilla.Rows(0)("PlantillaCredF")
        Clave_PlantillaReverso = dt_Plantilla.Rows(0)("PlantillaCredR")

        If Not dr_Credenciales Is Nothing Then
            btn_Imprimir.Enabled = True
            ptb_Foto.Image = Nothing
            pct_Codigo.Image = Nothing

            tbx_Nombres.Tag = 0
            tbx_Nombres.Tag = dr_Credenciales("Id_Empleado")

            tbx_Clave.Text = dr_Credenciales("Clave")
            tbx_Clave.Tag = Id_Credencial
            tbx_Nombres.Text = dr_Credenciales("Nombres")
            tbx_Apellidos.Text = dr_Credenciales("Apellidos")
            tbx_Departamento.Text = dr_Credenciales("Departamento")
            tbx_Puesto.Text = dr_Credenciales("Puesto")
            tbx_FechaRegistro.Text = dr_Credenciales("Fecha_Registro")
            tbx_FechaIngreso.Text = dr_Credenciales("Fecha_Ingreso")
            tbx_FechaVencimiento.Text = dr_Credenciales("FechaVenceCred")

            If Not IsDBNull(dr_Credenciales("Credencial")) Then
                Dim ms1 As MemoryStream = New MemoryStream(dr_Credenciales("Credencial"), 0, dr_Credenciales("Credencial").Length)
                ms1.Write(dr_Credenciales("Credencial"), 0, dr_Credenciales("Credencial").Length)
                'pasamos la imagen real de la base de datos ala variable img
                img = Image.FromStream(ms1, True)
                ptb_Foto.Image = img
                ' Habilita el botonOriginal
                btn_fotoOriginal.Enabled = True

                ban = "C"
                rdb_FotoNo.Checked = False
                rdb_FotoSi.Checked = True
                rdb_FotoNo.Enabled = True
                rdb_FotoSi.Enabled = True

            ElseIf Not IsDBNull(dr_Credenciales("Frente")) Then
                Dim ms2 As MemoryStream = New MemoryStream(dr_Credenciales("Frente"), 0, dr_Credenciales("Frente").Length)
                ms2.Write(dr_Credenciales("Frente"), 0, dr_Credenciales("Frente").Length)

                img = Image.FromStream(ms2, True)
                ptb_Foto.Image = img
                ban = "F"
                rdb_FotoNo.Checked = False
                rdb_FotoSi.Checked = True
                rdb_FotoNo.Enabled = True
                rdb_FotoSi.Enabled = True
                '-----------------------------
                tbr_brillo.Enabled = True
                ptb_mascara.Visible = True
                btn_cortaFoto.Enabled = True
                btn_masc2.Enabled = True
                '--------------------------
                '-------------ajusta la imagen----------------------
                Dim ANCHOES As Single, ALTOESC As Single
                Dim RESUL As Single

                ANCHOES = (ptb_Foto.Image.Width) / ptb_Foto.Width 'ANCHO 248
                ALTOESC = ptb_Foto.Image.Height / ptb_Foto.Height ' ALTO 186
                RESUL = ANCHOES - ALTOESC

                If RESUL = 0.0 OrElse (RESUL.ToString.Substring(0, 4)) = "0.0" Then
                    'NORMAL
                ElseIf RESUL > 0 Then
                    ptb_Foto.Height = ptb_Foto.Image.Height / ANCHOES 'AJUSTA ALTO PICTUREBOX
                ElseIf RESUL < 0 Then
                    'KIERE DECIR QUE ALTO ES MAS GRANDE QUE ANCHO
                    ptb_Foto.Width = ptb_Foto.Image.Width / ALTOESC 'AJUSTA EL ANCHO DEL PICTUREBOX   
                End If
                '-------------------------------------------------------

            Else
                rdb_FotoNo.Checked = True
                rdb_FotoSi.Checked = False
                rdb_FotoNo.Enabled = False
                rdb_FotoSi.Enabled = False
            End If

            If Not IsDBNull(dr_Credenciales("Codigo")) Then
                Dim ms2 As MemoryStream = New MemoryStream(dr_Credenciales("Codigo"), 0, dr_Credenciales("Codigo").Length)
                ms2.Write(dr_Credenciales("Codigo"), 0, dr_Credenciales("Codigo").Length)
                pct_Codigo.Image = Image.FromStream(ms2, True)
            End If

            Try
                If Not IsDBNull(dr_Credenciales("Firma")) Then
                    Dim ms2 As MemoryStream = New MemoryStream(dr_Credenciales("Firma"), 0, dr_Credenciales("Firma").Length)
                    ms2.Write(dr_Credenciales("Firma"), 0, dr_Credenciales("Firma").Length)
                    pct_Firma.Image = Image.FromStream(ms2, True)
                End If
                Dim Anchofirma As Single = pct_Firma.Image.Width
                Dim AltoFirma As Single = pct_Firma.Image.Height
                Dim Resfirma As Single = Anchofirma - AltoFirma

                If (Resfirma < (Anchofirma * 0.25)) OrElse (Resfirma > (Anchofirma * 0.55)) Then
                    lbl_Firma.Text = "La Firma no tiene el formato correcto para la impresión de la Credencial"
                    lbl_Firma.ForeColor = Color.Red
                    Tiene_Firma = False
                Else
                    lbl_Firma.Text = "Firma Correcta"
                    lbl_Firma.ForeColor = Color.Green
                    Tiene_Firma = True
                End If

            Catch ex As Exception
                lbl_Firma.Text = "El empleado no tiene Firma"
                Tiene_Firma = False
            End Try

            tbx_Folio.Text = dr_Credenciales("Folio")
            tbx_FechaExpedicion.Text = dr_Credenciales("Fecha_Expide")
            tbx_UsuarioExpide.Text = dr_Credenciales("UsuarioExpide")
            tbx_FechaAutorizacion.Text = dr_Credenciales("Fecha_Expide")
            tbx_UsuarioAutoriza.Text = dr_Credenciales("UsuarioAutoriza")
            tbx_Status.Text = dr_Credenciales("Status")
        Else

            btn_Imprimir.Enabled = False
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()

        End If

        If My.Settings.Zebra.Trim = "" Then
            lbl_Impresora.Text = "No has Seleccionado una Impresora"
        Else
            lbl_Impresora.Text = My.Settings.Zebra
        End If
        printerName = lbl_Impresora.Text
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        If ptb_mascara.Visible = True Then
            MsgBox("Para Imprimir la Credencial Debe editar la foto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If ban = "F" Then
            Dim Bytes As Byte()
            'aqui pasa la imagen del picturebox a byte()ptb_Foto.Image
            Bytes = Cn_Reclutamiento.ImageToByteArray(imgEditado) 'imprimimos la imagenOriginal editada y No del PictureBox
            If Not Cn_Reclutamiento.fn_EmpleadosI_ActualizaCredencial(tbx_Nombres.Tag, Bytes) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            ban = "C"
            tbr_brillo.Enabled = False
            btn_fotoOriginal.Enabled = False
            ptb_mascara.Visible = False
            btn_masc2.Enabled = False
        End If
        '--------------------

        If tbx_Margen.Text = "" Then tbx_Margen.Text = "0"

        If tbx_Firma.Enabled = True Then
            If tbx_Firma.Text = "" Then
                MsgBox("Indique el Número de Firma.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Firma.Focus()
                Exit Sub
            End If
        End If

        Dim frm As New frm_Reporte

        frm.crv.ReportSource = Cn_Reclutamiento.fn_Credenciales_Generar(Id_Credencial, TipoEmpleado)
        frm.Text = "Credenciales"

        Dim Seccion As CrystalDecisions.CrystalReports.Engine.Section = frm.crv.ReportSource.Section2
        Seccion.Height = CInt(tbx_Margen.Text)

        If rdb_FotoNo.Checked = True Then
            Dim foto As CrystalDecisions.CrystalReports.Engine.BlobFieldObject = frm.crv.ReportSource.Section3.ReportObjects("Frente1")
            foto.ObjectFormat.EnableSuppress = True
        End If
        If tbx_Firma.Enabled = False Then
            Dim Firma As CrystalDecisions.CrystalReports.Engine.TextObject = frm.crv.ReportSource.Section3.ReportObjects("tbx_Firma")
            Firma.Text = ""
        Else
            Dim Firma As CrystalDecisions.CrystalReports.Engine.TextObject = frm.crv.ReportSource.Section3.ReportObjects("tbx_Firma")
            Firma.Text = "( No. Firma: " & tbx_Firma.Text & " )"
        End If

        frm.ShowDialog()

        If rdb_ReversoSi.Checked Then
            frm.crv.ReportSource = Cn_Reclutamiento.fn_CredencialesR_Generar(Id_Credencial, TipoEmpleado)
            Seccion = frm.crv.ReportSource.Section2
            Seccion.Height = CInt(tbx_Margen.Text)
            If chk_Codigo.Checked = False Then
                Dim Codigo As CrystalDecisions.CrystalReports.Engine.BlobFieldObject = frm.crv.ReportSource.Section3.ReportObjects("Codigo1")
                Codigo.ObjectFormat.EnableSuppress = True
            End If
            If chk_Leyenda.Checked = False Then
                Dim Leyenda As CrystalDecisions.CrystalReports.Engine.TextObject = frm.crv.ReportSource.Section3.ReportObjects("tbx_Leyenda")
                Dim Leyenda1 As CrystalDecisions.CrystalReports.Engine.TextObject = frm.crv.ReportSource.Section3.ReportObjects("tbx_Leyenda1")
                Dim Linea As CrystalDecisions.CrystalReports.Engine.LineObject = frm.crv.ReportSource.Section3.ReportObjects("Linea")
                Leyenda.ObjectFormat.EnableSuppress = True
                Leyenda1.ObjectFormat.EnableSuppress = True
                Linea.ObjectFormat.EnableSuppress = True
            End If
            frm.ShowDialog()
        End If
    End Sub

    Private Sub chk_Firma_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Firma.CheckedChanged
        tbx_Firma.Clear()
        If chk_Firma.Checked Then
            tbx_Firma.Enabled = False
        Else
            tbx_Firma.Enabled = True
        End If
    End Sub

    Private Sub chk_Leyenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Leyenda.CheckedChanged
        If chk_Leyenda.Checked = False And chk_Codigo.Checked = False Then
            rdb_ReversoNo.Checked = True
        End If
    End Sub

    Private Sub chk_Codigo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Codigo.CheckedChanged
        If chk_Leyenda.Checked = False And chk_Codigo.Checked = False Then
            rdb_ReversoNo.Checked = True
        End If
    End Sub

    Private Sub rdb_ReversoNo_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_ReversoNo.CheckedChanged
        If rdb_ReversoNo.Checked = True Then
            chk_Leyenda.Enabled = False
            chk_Codigo.Enabled = False
        Else
            chk_Leyenda.Enabled = True
            chk_Codigo.Enabled = True
        End If
    End Sub

    Private Sub rdb_ReversoSi_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles rdb_ReversoSi.CheckedChanged
        If rdb_ReversoSi.Checked = True Then
            chk_Leyenda.Checked = True
            chk_Codigo.Checked = True
        End If
    End Sub

    Private Sub GroupBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Datos.MouseHover
        SegundosDesconexion = 0
    End Sub

#Region "EDICION DE FOTOS --->  MASCARA"

    Private Sub btn_fotoOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fotoOriginal.Click
        SegundosDesconexion = 0
        ptb_Foto.Width = 248
        ptb_Foto.Height = 186

        'Vuelve a la imagen de frente Original
        If ban = "F" Then
            ptb_Foto.Image = img
        Else
            'Dim dr_Credenciales As DataRow = Cn_Reclutamiento.fn_Credenciales_ObtenValores(Id_Credencial)
            Dim ms2 As MemoryStream = New MemoryStream(dr_Credenciales("Frente"), 0, dr_Credenciales("Frente").Length)
            ms2.Write(dr_Credenciales("Frente"), 0, dr_Credenciales("Frente").Length)
            img = Image.FromStream(ms2, True)
            ptb_Foto.Image = img
            ban = "F"
        End If
        '-------------ajusta la imagen----------------------
        Dim ANCHOES As Single, ALTOESC As Single
        Dim RESUL As Single

        ANCHOES = ptb_Foto.Image.Width / ptb_Foto.Width 'ANCHO 248
        ALTOESC = ptb_Foto.Image.Height / ptb_Foto.Height ' ALTO 186
        RESUL = ANCHOES - ALTOESC

        If RESUL = 0.0 OrElse (RESUL.ToString.Substring(0, 4)) = "0.00" Then
            'NORMAL
        ElseIf RESUL > 0 Then
            ptb_Foto.Height = ptb_Foto.Image.Height / ANCHOES 'AJUSTA ALTO PICTUREBOX
        ElseIf RESUL < 0 Then
            'KIERE DECIR QUE ALTO ES MAS GRANDE QUE ANCHO
            ptb_Foto.Width = ptb_Foto.Image.Width / ALTOESC 'AJUSTA EL ANCHO DEL PICTUREBOX   
        End If
        '-------------------------------------------------------
        btn_cortaFoto.Enabled = True
        ptb_mascara.Visible = True
        tbr_brillo.Enabled = True
        tbr_brillo.Value = 0
        btn_masc2.Enabled = True
        btn_fotoOriginal.Enabled = False
    End Sub

    Private Sub ptb_mascara_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptb_mascara.MouseDown
        SegundosDesconexion = 0
        Cursor = Cursors.SizeAll
        Mover = True
        ' guarda rl el x e y donde se hizo clic   
        p_Mouse.X = e.X
        p_Mouse.Y = e.Y
    End Sub

    Private Sub ptb_mascara_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptb_mascara.MouseMove
        SegundosDesconexion = 0
        AnchoMascara = (CShort(ptb_Foto.Width) - CShort(ptb_mascara.Width)) - 4 '-4 porque son 4px entre bordes
        AltoMascara = (CShort(ptb_Foto.Height) - CShort(ptb_mascara.Height)) - 4
        If Mover Then
            Cursor = Cursors.SizeAll
            ' referencia al control   
            Dim unControl As Control = CType(sender, Control)

            ' cambiar las coordenadas   
            Dim p1 As Point = unControl.PointToScreen(e.Location)
            Dim p2 As Point = unControl.Parent.PointToClient(p1)

            Dim yy As Short = p2.Y - p_Mouse.Y
            Dim xx As Short = p2.X - p_Mouse.X


            If yy <= 0 Then 'arriba 
                ptb_mascara.Top = 0
                If xx >= AnchoMascara Then
                    ptb_mascara.Left = AnchoMascara 'era 124,132
                ElseIf xx <= 0 Then
                    ptb_mascara.Left = 0
                Else
                    unControl.Left = p2.X - p_Mouse.X
                End If
            ElseIf xx <= 0 Then 'derecha
                ptb_mascara.Left = 0
                If yy >= AltoMascara Then
                    ptb_mascara.Top = AltoMascara
                Else
                    unControl.Top = p2.Y - p_Mouse.Y
                End If
            ElseIf yy >= AltoMascara Then 'abajo
                ptb_mascara.Top = AltoMascara
                If xx >= AnchoMascara Then
                    ptb_mascara.Left = AnchoMascara
                Else
                    unControl.Left = p2.X - p_Mouse.X
                End If

            ElseIf xx >= AnchoMascara Then ' izquierda
                ptb_mascara.Left = AnchoMascara
                If yy >= AltoMascara Then
                    ptb_mascara.Top = AltoMascara
                Else
                    unControl.Top = p2.Y - p_Mouse.Y
                End If
            Else

                unControl.Left = p2.X - p_Mouse.X
                unControl.Top = p2.Y - p_Mouse.Y
            End If
        End If
    End Sub

    Private Sub ptb_mascara_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptb_mascara.MouseUp
        SegundosDesconexion = 0

        If ban = "C" Then Exit Sub
        btn_cortaFoto.Enabled = True
        btn_masc2.Enabled = True
        Cursor = Cursors.Default
        ' flag para mover el control   
        Mover = False

    End Sub

    Private Sub btn_cortaFoto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cortaFoto.Click
        SegundosDesconexion = 0
        Dim Xm As Short = 0
        Dim Ym As Short = 0
        Dim XX As Decimal '16 bytes
        Dim YY As Decimal
        Dim WidthMascara As Short '2 bytes
        Dim HeightMascara As Short
        XX = Format((CShort(img.Width) / CShort(ptb_Foto.Width)), "##,##0.00") 'toma 2 decimales Divide el tamaño Real de la foto entre el tamaño delPictureBox
        YY = Format((CShort(img.Height) / CShort(ptb_Foto.Height)), "##,##0.00") 'esto para tomar la proporcion a Usar

        WidthMascara = CShort(ptb_mascara.Width) * XX 'multiplicamos la Proporcion por el tamaño de mascara aRecortar
        HeightMascara = CShort(ptb_mascara.Height) * YY 'y obtenemos el tamaño real a Recortar

        If banderaImg Then 'para saber si tomamos la editada o la original
            imgEditado = imgEditado
        Else
            imgEditado = img 'original
        End If

        Try
            Cursor = Cursors.Default

            Xm = XX * CShort(ptb_mascara.Left.ToString) 'estas 2 lineas  es de que punto X y Y vamos a empezar adibujar el rectangulo
            Ym = YY * CShort(ptb_mascara.Top.ToString) ' en la imagenREal no del PictureBox

            Dim rect As Rectangle = New Rectangle(Xm, Ym, WidthMascara, HeightMascara)
            Dim bit As Bitmap = New Bitmap(imgEditado) '(foto,W,H)

            cropBitmap = New Bitmap(WidthMascara, HeightMascara)

            Dim g As Graphics = Graphics.FromImage(cropBitmap) '--------<<cropBitmap>> almacena la imagenRecortada
            g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
            g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality

            g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel) 'sobrecargo 11

            'My.Computer.Clipboard.SetImage(cropBitmap) 'copia en portapapeles
            ptb_Foto.Image = cropBitmap 'muestra la imagen en el PictureBox
            imgEditado = cropBitmap 'pasamos la imagen editada a la Variable y esta es la ke manda a CrystalReport
            ptb_Foto.SizeMode = PictureBoxSizeMode.Zoom

            btn_fotoOriginal.Enabled = True
            btn_cortaFoto.Enabled = False
            btn_masc2.Enabled = False
            ptb_mascara.Visible = False
            tbr_brillo.Enabled = False
            banderaImg = False
            ptb_Foto.Refresh() 'refresca la imagen
            '-+--------------------
            'ptb_Foto.Image.Save("C:\Documents and Settings\programador3\Escritorio\imagen2.jpg")
        Catch exc As Exception

        End Try

        ptb_Foto.Width = 248 'vuelve al tamaño original del picturebox
        ptb_Foto.Height = 186
    End Sub

    Private Sub tbr_brillo_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbr_brillo.Scroll

        Dim value As Double = tbr_brillo.Value * 0.01F
        Dim colorMatrixElements As Single()() = { _
          New Single() {1, 0, 0, 0, 0}, _
          New Single() {0, 1, 0, 0, 0}, _
          New Single() {0, 0, 1, 0, 0}, _
          New Single() {0, 0, 0, 1, 0}, _
          New Single() {value, value, value, 0, 1}}
        Dim colorMatrix As New Imaging.ColorMatrix(colorMatrixElements)
        Dim imageAttributes As New ImageAttributes()

        imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap)

        Dim _img As Image = img 'img variable ke tiene la imagen original 'PictureBox1.Image
        Dim _g As Graphics
        Dim bm_dest As New Bitmap(CInt(_img.Width), CInt(_img.Height))
        _g = Graphics.FromImage(bm_dest)

        _g.DrawImage(_img, New Rectangle(0, 0, bm_dest.Width + 1, bm_dest.Height + 1), 0, 0, bm_dest.Width + 1, bm_dest.Height + 1, GraphicsUnit.Pixel, imageAttributes)
        ptb_Foto.Image = bm_dest 'este lo pasa el pictureBox editado
        imgEditado = bm_dest ' aki edita la foto original 
        banderaImg = True
    End Sub

    Private Sub btn_masc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_masc2.Click
        SegundosDesconexion = 0

        If btn_masc2.Text = "Usar Mascara 2" Then
            ptb_mascara.Width = 133 'estas medidas son proporcionales a 120 y 130 y son definidas
            ptb_mascara.Height = 144  'Nota: la imagen en el picturebox debe abarcar todo y en Zoom
            btn_masc2.Text = "Usar Mascara 1"
        Else
            ptb_mascara.Width = 120  'X 1.1155
            ptb_mascara.Height = 130
            btn_masc2.Text = "Usar Mascara 2"
        End If
    End Sub

#End Region

#Region "Impresión de Credencial zebra (SISSA y PROTEGE-VRV) 29/10/2014"

    Private Function ValidarDatosCredencial() As Boolean
        If My.Settings.Zebra.Trim = "" Then
            MsgBox("Debe configurar la Impresora para credenciales.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        If ptb_Foto.Image Is Nothing Then
            MsgBox("El Empleado no tiene Foto capturada, no se realizará la impresión de la credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If

        If Tiene_Firma = False Then
            MsgBox("El Empleado no tiene Firma ó  la Firma no tiene el formato correcto para la impresión de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Function
        End If
        Return True
    End Function

    Private Sub btn_ZebraFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ZebraFrente.Click
        SegundosDesconexion = 0
        'Usando Plantillas 27/10/2014
        If ValidarDatosCredencial() Then Call Imprimir_Zebra_Credencial(Clave_PlantillaFrente)
    End Sub

    Private Sub btn_ZebraTrasera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ZebraTrasera.Click
        SegundosDesconexion = 0
        'Usando Plantillas 27/10/2014
        If ValidarDatosCredencial() Then Call Imprimir_Zebra_Credencial(Clave_PlantillaReverso)
    End Sub

    Private Sub Imprimir_Zebra_Credencial(ByVal clavePlantilla As String)
        SegundosDesconexion = 0
        '27/10/2014 by Herg 27/03/2015
        If tbx_Firma.Enabled = True Then
            If tbx_Firma.Text = "" Then
                MsgBox("Indique el Número de Firma.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Firma.Focus()
                Exit Sub
            End If
        End If
        If ptb_mascara.Visible = True Then
            MsgBox("Para Imprimir la Credencial Debe editar la foto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If ban = "F" Then
            Dim Bytes As Byte()
            'aqui pasa la imagen del picturebox a byte()ptb_Foto.Image
            Bytes = Cn_Reclutamiento.ImageToByteArray(imgEditado) 'imprimimos la imagenOriginal editada y No del PictureBox

            If dr_Credenciales("Tipo") = "1" Then

                If Not Cn_Reclutamiento.fn_EmpleadosI_ActualizaCredencial(tbx_Nombres.Tag, Bytes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Error al intentar guardar la foto.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                If Not Cn_Reclutamiento.fn_EmpleadosXFI_ActualizaCredencial(tbx_Nombres.Tag, Bytes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Error al intentar guardar la foto.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If

            tbr_brillo.Enabled = False
            btn_fotoOriginal.Enabled = False
            ptb_mascara.Visible = False
            btn_masc2.Enabled = False
        End If

        If Not System.IO.Directory.Exists(Ruta) Then
            'Crea la ruta para las imagenes Temporales
            System.IO.Directory.CreateDirectory(Ruta)
        Else
            If File.Exists(Ruta & "FotoEmpleado.JPG") Then File.Delete(Ruta & "FotoEmpleado.JPG")
            If File.Exists(Ruta & "CodigoBarEmpleado.JPG") Then File.Delete(Ruta & "CodigoBarEmpleado.JPG")
            If File.Exists(Ruta & "LogoEmpresa.JPG") Then File.Delete(Ruta & "LogoEmpresa.JPG")
            If File.Exists(Ruta & "FirmaEmpleado.JPG") Then File.Delete(Ruta & "FirmaEmpleado.JPG")
            If File.Exists(Ruta & "FirmaAutoriza.JPG") Then File.Delete(Ruta & "FirmaAutoriza.JPG")
            If File.Exists(Ruta & "FirmaRepresentante.JPG") Then File.Delete(Ruta & "FirmaRepresentante.JPG")
        End If

        If Not dr_Credenciales Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")
            ' ************************TEXTO*********************
            Try
                '1= remisiones 2=Credenciales
                Dim Dt_Plantilla As DataTable = fn_ConsultarPlantillaCampos(clavePlantilla, 2)
                'ARMAS
                Dim dt_ArmasPlant As DataTable = fn_Credenciales_ObtenValoresZebraArmas(dr_Credenciales("Id_Empleado"))
                Dim Armas As Boolean = False
                If Not dt_ArmasPlant Is Nothing Then Armas = True

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
                For Each Dr_Plantilla As DataRow In Dt_Plantilla.Rows
                    If Dr_Plantilla("Alineacion") <> "" Then
                        Select Case Dr_Plantilla("Alineacion")
                            Case "DERECHA"
                                AlineacionPlant = 6
                            Case "CENTRO"
                                AlineacionPlant = 4
                            Case "IZQUIERDA"
                                AlineacionPlant = 5
                        End Select
                    End If
                    If Dr_Plantilla("Negrita") <> "" Then
                        Select Case Dr_Plantilla("Negrita")
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
                    Dr_Plantilla("Color") = "&H" & Microsoft.VisualBasic.Right(Dr_Plantilla("Color"), 6)
                    Select Case Dr_Plantilla("Nombre").ToString.ToUpper

                        Case "LOGO"
                            If Not IsDBNull(Dr_Plantilla("logo")) Then
                                Dim ImagenCad As String
                                Dim LogoEmpresa As Byte() = Dr_Plantilla("Logo")
                                Dim imagenImg As Image

                                Dim ms_ByteToImagen As New IO.MemoryStream(LogoEmpresa)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "LogoEmpresa.JPG")
                                ImagenCad = Ruta & "LogoEmpresa.JPG"
                                LogoEmpresa = ascii.GetBytes(ImagenCad)
                                Dim anch As Integer = imagenImg.Width
                                Dim alt As Integer = imagenImg.Height

                                If (ZBRGDIDrawImageRect(LogoEmpresa, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el logotipo de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                imagenImg.Dispose()
                            End If

                        Case "RFCEMPRESA"
                            If Not IsDBNull(dr_Credenciales("Clave")) Then
                                Dim RFCEmpresa As Byte()
                                RFCEmpresa = ascii.GetBytes(dr_Credenciales("RFCEmpresa"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, RFCEmpresa, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el RFC de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If

                        Case "NOMINAFIRMA"
                            If Not IsDBNull(dr_Credenciales("Clave")) Then
                                Dim ClavePlant As Byte()
                                ClavePlant = ascii.GetBytes(dr_Credenciales("Clave"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, ClavePlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el número de nómina del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "RFCEMPLEADO"
                            If Not IsDBNull(dr_Credenciales("RFCEmpleado")) Then
                                Dim ClavePlant As Byte()
                                ClavePlant = ascii.GetBytes(dr_Credenciales("RFCEmpleado"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, ClavePlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el RFC del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If

                        Case "FOTOEMPLEADO"
                            Dim FotoEmpleado As Byte() = Nothing
                            If ban = "F" Then
                                FotoEmpleado = Cn_Reclutamiento.ImageToByteArray(imgEditado) ' imprime la imgen editada
                                ban = "C"
                            Else
                                If Not IsDBNull(dr_Credenciales("Credencial")) Then
                                    FotoEmpleado = dr_Credenciales("Credencial")
                                End If
                            End If

                            If FotoEmpleado IsNot Nothing Then
                                Dim ImagenCad As String
                                Dim imagenImg As Image
                                Dim ms_ByteToImagen As New IO.MemoryStream(FotoEmpleado)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "FotoEmpleado.JPG")
                                ImagenCad = Ruta & "FotoEmpleado.JPG"
                                FotoEmpleado = ascii.GetBytes(ImagenCad)

                                If (ZBRGDIDrawImageRect(FotoEmpleado, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la foto del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                imagenImg.Dispose()
                            End If

                        Case "NOMBRE"

                            Dim EmpleadoPlant As Byte()
                            Dim NombrePlant As String = dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos")
                            NombrePlant = Replace(NombrePlant, "Ñ", "N")
                            EmpleadoPlant = ascii.GetBytes(NombrePlant)

                            If EmpleadoPlant.Length >= 23 Then
                                Dr_Plantilla("Fuente") = 8
                            End If

                            If EmpleadoPlant.Length < 27 Then Dr_Plantilla("Y") += 45
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, EmpleadoPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir el nombre del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "PUESTO"
                            Dim PuestoPlant As Byte()
                            PuestoPlant = ascii.GetBytes(dr_Credenciales("Puesto"))

                            If Dr_Plantilla("Fuente") > 9 Then
                                If PuestoPlant.Length >= 22 Then
                                    fontSize = 10
                                    Dr_Plantilla("Y") -= 20
                                End If
                            End If
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, PuestoPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir el puesto del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "DEPARTAMENTO"
                            Dim DepartamentoPlant As Byte()
                            DepartamentoPlant = ascii.GetBytes(dr_Credenciales("Departamento"))
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, DepartamentoPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir el departamento del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "FECHAEXPIDE"
                            Dim ExpedidaPlant As Byte()
                            ExpedidaPlant = ascii.GetBytes(dr_Credenciales("Fecha_Expide"))
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, ExpedidaPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir la fecha de expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "FECHAEXPIRA"
                            Dim ExpiraPlant As Byte()
                            ExpiraPlant = ascii.GetBytes(dr_Credenciales("FechaVenceCred"))
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, ExpiraPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir la fecha de expiración de la credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                            'Case "CODIGO"
                            '    If Not IsDBNull(dr_Credenciales("Codigo")) Then
                            '        Dim ImagenCad As String
                            '        Dim CodigoBarEmpleado As Byte() = dr_Credenciales("Codigo")
                            '        Dim imagenImg As Image

                            '        Dim ms_ByteToImagen As New IO.MemoryStream(CodigoBarEmpleado)
                            '        imagenImg = Image.FromStream(ms_ByteToImagen, True)
                            '        imagenImg.Save(Ruta & "CodigoBarEmpleado.JPG")
                            '        ImagenCad = Ruta & "CodigoBarEmpleado.JPG"
                            '        CodigoBarEmpleado = ascii.GetBytes(ImagenCad)

                            '        If (ZBRGDIDrawImageRect(CodigoBarEmpleado, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                            '            ascii = Nothing
                            '            ZBRGDICloseGraphics(hDC, err)
                            '            MsgBox("Ha ocurrido un error al imprimir el código de barras.", MsgBoxStyle.Critical, frm_MENU.Text)
                            '            Exit Sub
                            '        End If
                            '        imagenImg.Dispose()
                            '    End If

                        Case "REGFEDPERM"
                            Dim ExpiraPlant As Byte()
                            ExpiraPlant = ascii.GetBytes(dr_Credenciales("RegFedPerm"))
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, ExpiraPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir el Registro Federal Permanente.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "CURP"
                            If Not IsDBNull(dr_Credenciales("CURP")) Then
                                Dim CurpPlant As Byte()
                                CurpPlant = ascii.GetBytes(dr_Credenciales("CURP"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, CurpPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la CURP.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If

                        Case "CUIP"
                            If Not IsDBNull(dr_Credenciales("CUIP")) Then
                                Dim CuipPlant As Byte()
                                CuipPlant = ascii.GetBytes(dr_Credenciales("CUIP"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, CuipPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir CUIP.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "TIPOSANGRE"
                            If Not IsDBNull(dr_Credenciales("TipoSangre")) Then
                                Dim SangrePlant As Byte()
                                SangrePlant = ascii.GetBytes(dr_Credenciales("TipoSangre") & "  " & dr_Credenciales("FactorSangre"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, SangrePlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el tipo/factor sangre.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "NUMEROSEGURO"
                            If Not IsDBNull(dr_Credenciales("Seguro")) Then
                                Dim IMSSPlant As Byte() = ascii.GetBytes(dr_Credenciales("Seguro"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, IMSSPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el numero de seguro social.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "FIRMAEMPLEADO"

                            If Not IsDBNull(dr_Credenciales("Firma")) Then
                                Dim ImagenCad As String
                                Dim FirmaEmpleado As Byte() = dr_Credenciales("Firma")
                                Dim imagenImg As Image

                                Dim ms_ByteToImagen As New IO.MemoryStream(FirmaEmpleado)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "FirmaEmpleado.JPG")
                                ImagenCad = Ruta & "FirmaEmpleado.JPG"
                                FirmaEmpleado = ascii.GetBytes(ImagenCad)
                                If (ZBRGDIDrawImageRect(FirmaEmpleado, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la firma del empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                imagenImg.Dispose()
                            Else
                                MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma. ", MsgBoxStyle.Critical, frm_MENU.Text)
                            End If

                        Case "USUARIOAUTORIZA"
                            Dim RepLegal As String = dr_Credenciales("UsuarioAutoriza")
                            RepLegal = Replace(RepLegal, "Ñ", "N")

                            Dim AutorizaPlant As Byte()
                            If RepLegal.ToString.Length > 22 Then Dr_Plantilla("Fuente") = 7
                            AutorizaPlant = ascii.GetBytes(RepLegal)
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, AutorizaPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir los datos del Representante Legal.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If

                        Case "FIRMAAUTORIZA"

                            If Not IsDBNull(dr_Credenciales("FirmaAutoriza")) Then
                                Dim ImagenCad As String
                                Dim FirmaEmpleadoAut As Byte() = dr_Credenciales("FirmaAutoriza")
                                Dim imagenImg As Image

                                Dim ms_ByteToImagen As New IO.MemoryStream(FirmaEmpleadoAut)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "FirmaAutoriza.JPG")
                                ImagenCad = Ruta & "FirmaAutoriza.JPG"
                                FirmaEmpleadoAut = ascii.GetBytes(ImagenCad)

                                If (ZBRGDIDrawImageRect(FirmaEmpleadoAut, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la firma del autorizante.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                imagenImg.Dispose()
                            Else
                                MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma de Autorización. ", MsgBoxStyle.Critical, frm_MENU.Text)
                            End If

                        Case "CADENAARMA", "CADENAARMA2"

                            If Armas = True And dt_ArmasPlant IsNot Nothing Then
                                If dt_ArmasPlant.Rows.Count = 0 Then Exit Select
                                Dim Fila As Integer = 0
                                thickness = 2

                                If Dr_Plantilla("Nombre").ToString.ToUpper = "CADENAARMA2" Then
                                    If dt_ArmasPlant.Rows.Count = 2 Then Fila = 1 Else Exit Select
                                End If

                                ' de620 se usa 590-->(19.35, 16.12, 38.7, 20.96)=95.13%
                                ' '120 + 100 + 240 + 130 = 590Validar este valor
                                Dim AnchoContenedor As Integer = Dr_Plantilla("Ancho")
                                Dim Encabezado As Byte()
                                Dim Porciento() As Decimal = {19.35, 16.12, 38.7, 20.96} '25/03/2015
                                Dim Ancho(3) As Integer
                                Dim Coord_X As Integer = Dr_Plantilla("X")

                                Dim separador As Integer = 5

                                For I As Integer = 0 To 3
                                    Ancho(I) = (AnchoContenedor * Porciento(I)) / 100

                                Next

                                Encabezado = ascii.GetBytes(dt_ArmasPlant(Fila)("Tipo"))
                                If (ZBRGDIDrawTextRect(Coord_X, Dr_Plantilla("Y"), Ancho(0), Dr_Plantilla("Alto"), AlineacionPlant, Encabezado, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el tipo de arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If

                                Coord_X += Ancho(0) + separador
                                Encabezado = ascii.GetBytes(dt_ArmasPlant(Fila)("Calibre"))
                                If (ZBRGDIDrawTextRect(Coord_X, Dr_Plantilla("Y"), Ancho(1), Dr_Plantilla("Alto"), AlineacionPlant, Encabezado, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir el calibre del arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                                Coord_X += Ancho(1) + separador
                                Encabezado = ascii.GetBytes(dt_ArmasPlant(Fila)("Marca"))
                                If (ZBRGDIDrawTextRect(Coord_X, Dr_Plantilla("Y"), Ancho(2), Dr_Plantilla("Alto"), AlineacionPlant, Encabezado, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la marca de arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If

                                Coord_X += Ancho(2) + separador
                                Encabezado = ascii.GetBytes(dt_ArmasPlant(Fila)("Matricula"))
                                If (ZBRGDIDrawTextRect(Coord_X, Dr_Plantilla("Y"), Ancho(3), Dr_Plantilla("Alto"), AlineacionPlant, Encabezado, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la matricula del arma.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If

                        Case "PERMISOSECRETARIA"
                            If Not IsDBNull(dr_Credenciales("Registro")) Then
                                Dim RegistroPlant As Byte()
                                If Not IsDBNull(dr_Credenciales("Registro")) Then
                                    RegistroPlant = ascii.GetBytes(dr_Credenciales("Registro"))
                                    If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, RegistroPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                        ascii = Nothing
                                        ZBRGDICloseGraphics(hDC, err)
                                        MsgBox("Ha ocurrido un error al imprimir el permiso de la Secretaria de Seguridad Publica.", MsgBoxStyle.Critical, frm_MENU.Text)
                                        Exit Sub
                                    End If
                                End If
                            End If
                        Case "REPRESENTANTELEGAL"
                            If Not IsDBNull(dr_Credenciales("Representante")) Then
                                Dim AutorizaPlant As Byte()
                                If dr_Credenciales("Representante").ToString.Length > 22 Then fontSize = 6
                                AutorizaPlant = ascii.GetBytes(dr_Credenciales("Representante"))
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, AutorizaPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir los datos del representante legal.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "FIRMAREPRESENTANTE"

                            If Not IsDBNull(dr_Credenciales("Firma_Representante")) Then
                                Dim ImagenCad As String
                                Dim FirmaRepresentante As Byte() = dr_Credenciales("Firma_Representante")
                                Dim imagenImg As Image
                                Dim ms_ByteToImagen As New IO.MemoryStream(FirmaRepresentante)
                                imagenImg = Image.FromStream(ms_ByteToImagen, True)
                                imagenImg.Save(Ruta & "FirmaRepresentante.JPG")
                                ImagenCad = Ruta & "FirmaRepresentante.JPG"
                                FirmaRepresentante = ascii.GetBytes(ImagenCad)

                                If (ZBRGDIDrawImageRect(FirmaRepresentante, Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir la firma del representante legal.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If

                        Case "TELEMERGENCIA"
                            If Not IsDBNull(dr_Credenciales("Tel_Fijo")) Then
                                Dim TelEmergencia As String = dr_Credenciales("Tel_Fijo")
                                If dr_Credenciales("Tel_Cel") <> "" Then
                                    If TelEmergencia <> "" Then TelEmergencia += "/"
                                    TelEmergencia += dr_Credenciales("Tel_Cel")
                                End If

                                Dim Tel_EmergPlant As Byte() = ascii.GetBytes(TelEmergencia)
                                If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, Tel_EmergPlant, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                    ascii = Nothing
                                    ZBRGDICloseGraphics(hDC, err)
                                    MsgBox("Ha ocurrido un error al imprimir los teléfonos de emergencia.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    Exit Sub
                                End If
                            End If
                        Case "RECTANGULO"
                            thickness = Dr_Plantilla("Grosor_Linea")

                            If (ZBRGDIDrawRectangle(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), thickness, Dr_Plantilla("Color"), err) = 0) Then
                                MsgBox("Ha ocurrido un error al imprimir el margen de la foto.", MsgBoxStyle.Critical, frm_MENU.Text)
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                            End If

                        Case "ETIQUETATEXTO"

                            If Dr_Plantilla("Porte_Armas") = "S" Then
                                If Armas = False Then
                                    Continue For
                                End If
                            End If

                            Dim EtiquetaTexto As Byte() = ascii.GetBytes(Dr_Plantilla("ValorFijo"))
                            If (ZBRGDIDrawTextRect(Dr_Plantilla("X"), Dr_Plantilla("Y"), Dr_Plantilla("Ancho"), Dr_Plantilla("Alto"), AlineacionPlant, EtiquetaTexto, Fuente, Dr_Plantilla("Fuente"), fontBold, Dr_Plantilla("Color"), err) = 0) Then
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha ocurrido un error al imprimir la etiqueta teléfono de emergencia.", MsgBoxStyle.Critical, frm_MENU.Text)
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

#End Region

End Class