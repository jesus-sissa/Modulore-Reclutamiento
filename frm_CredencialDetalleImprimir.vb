Imports System.IO
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D
Imports System
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_CredencialDetalleImprimir

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
    Public TipoEmpleado As Byte = 1 'interno
    Public Id_Credencial As Integer
    Dim dr_Credenciales As DataRow
    Dim Tiene_Firma As Boolean

    Private Sub frm_CredencialDetalleImprimir_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_CredencialDetalleImprimir_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '---Ponemos una mascara en el  Picturebox
        ptb_Foto.Controls.Add(ptb_mascara)
        ban = ""
        ptb_Foto.Width = 248 'siempre al tamaño original
        ptb_Foto.Height = 186

        'cargar los datos de la credencial
        'NOTA: En Cat_EmpleadosCredenciales hay un campo Tipo: 1=EmpleadosInternos; 2=EmpleadosXF (Empleados por fuera)
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
                '-------------ajusta la imagen-------------
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
                    'Call Desactivar_Btn()22/10/2014
                    Tiene_Firma = False
                Else
                    lbl_Firma.Text = "Firma Correcta"
                    lbl_Firma.ForeColor = Color.Green
                    'Call Activar_Btn()22/10/2014
                    Tiene_Firma = True
                End If

            Catch ex As Exception
                lbl_Firma.Text = "El empleado no tiene Firma"
                'Call Desactivar_Btn()
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
            lbl_Impresora.Text = "No ha Seleccionado una Impresora"
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

        If ptb_Foto.Image Is Nothing Then
            MsgBox("El Empleado no tiene Foto capturada, no se realizará la impresión de la credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
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

#Region "Impresión de Credencial zebra (SISSA y VRV)"

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
        If ValidarDatosCredencial() Then Call Imprimir_ZebraFrente_SISSA()
        ''Call Imprimir_ZebraFrente_VRV 'descomentar para VRV
    End Sub

    Private Sub btn_ZebraTrasera_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ZebraTrasera.Click
        SegundosDesconexion = 0

        If ValidarDatosCredencial() Then Call Imprimir_ZebraTrasera_SISSA()
        ''Call Imprimir_ZebraTrasera_VRV 'descomentar para VRV
    End Sub

    Private Sub Imprimir_ZebraFrente_SISSA()
        SegundosDesconexion = 0

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
                    MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                If Not Cn_Reclutamiento.fn_EmpleadosXFI_ActualizaCredencial(tbx_Nombres.Tag, Bytes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            ban = "C"
            tbr_brillo.Enabled = False
            btn_fotoOriginal.Enabled = False
            ptb_mascara.Visible = False
            btn_masc2.Enabled = False
        End If

        If Not System.IO.Directory.Exists(Ruta) Then
            System.IO.Directory.CreateDirectory(Ruta)
            ptb_Foto.Image.Save(Ruta & "Frente.JPG")
            pct_Codigo.Image.Save(Ruta & "Codigo.JPG")
        Else
            ptb_Foto.Image.Save(Ruta & "Frente.JPG")
            pct_Codigo.Image.Save(Ruta & "Codigo.JPG")
        End If


        If Not dr_Credenciales Is Nothing Then
            '  Dim dr_Credenciales As DataRow = fn_Credenciales_ObtenValoresZebra(Elem.Tag)
            'If Not dr_Credenciales Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")
            ' ************************TEXTO*********************
            Try

                If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error de Conexion con la Impresora ", MsgBoxStyle.Critical, frm_MENU.Text)
                    ZBRGDICloseGraphics(hDC, err)
                    Exit Sub
                End If

                ' ''FONDO GUIA
                'Dim ImageG As String
                'Dim xCoordG As Integer = 0
                'Dim yCoordG As Integer = 0
                'Dim widthG As Integer = 648
                'Dim heightG As Integer = 1015
                'Dim fNameG As Byte()
                'ImageG = (Ruta & "guia.JPG")
                'fNameG = ascii.GetBytes(ImageG)
                'If (ZBRGDIDrawImageRect(fNameG, xCoordG, yCoordG, widthG, heightG, err) = 0) Then
                '    'error drawing image into buffer
                '    ascii = Nothing
                '    ZBRGDICloseGraphics(hDC, err)
                '    'exit
                '    MsgBox("Ha Ocurrido un Error, al Imprimir la Imagen de Fondo." & err.ToString())
                '    Exit Sub
                'End If

                '**************************GUIA DE RECORTE ************************************************
                Dim xCoord As Integer = 0
                Dim yCoord As Integer = 70
                Dim Guia As Byte()
                fontSize = 7
                Guia = ascii.GetBytes("*         *")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, 648, 10, Alineacion.Centrado, Guia, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Guia de Recorte", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '****************************IMAGENES************************

                'Dibuja una Imagen en el Buffer:

                Dim Imagen As String
                xCoord = 5
                yCoord = 100 '70
                Dim width As Integer = 160
                Dim height As Integer = 130
                Dim fName As Byte()
                My.Resources.LogoSISSAZebra.Save(Ruta & "LogoSISSAZebra.JPG")
                '***************************Imagen de SISSA********************************
                Imagen = Ruta & "LogoSISSAZebra.JPG"
                fName = ascii.GetBytes(Imagen)
                If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                    'error drawing image into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error, en el Logotipo de SISSA.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                    MsgBox("Error al Crear la Banda Dorada de SISSA Superior", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If
                '********************************NOMBRE COMPLETO DE SISSA

                fontSize = 10
                xCoord -= 55
                yCoord -= 20
                width = 500
                height = 95
                fontColor = &H0
                Nombre_Empresa = ascii.GetBytes("Servicio Integral de Seguridad, S.A. de C.V.")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Nombre_Empresa, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                '************************BANDA DORADA DE SISSA INFERIOR******************************
                xCoord = 0
                'ycoord+=830
                yCoord = 920 '830
                width = 610
                height = 75
                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear la Banda Dorada de SISSA Inferior", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If

                '*********TITULO DE NOMINA Y FIRMA**************************
                Dim Nomina As Byte()
                Dim Firma As Byte()
                Dim Clave As Byte()
                Dim FirmaNum As Byte()

                xCoord = 140
                yCoord = 250 '215
                width = 400
                height = 100
                fontSize = 6
                fontColor = &HFF0000
                Nomina = ascii.GetBytes("NOMINA/FIRMA:")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Nomina, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Número de Nomina.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                xCoord += 200
                yCoord -= 8
                fontSize = 9
                fontColor = &H0
                Clave = ascii.GetBytes(dr_Credenciales("Clave"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Clave, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Número de Nomina.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                'If dr_Credenciales("NumFirma") <> "" Then
                '    xCoord += 130
                '    yCoord += 10
                '    fontSize = 6
                '    fontColor = &HFF0000
                '    'Firma = ascii.GetBytes("FIRMA:")
                '    Firma = ascii.GetBytes("")
                '    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Firma, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                '        'error drawing text into buffer
                '        ascii = Nothing
                '        ZBRGDICloseGraphics(hDC, err)
                '        MsgBox("Ha Ocurrido un Error al Imprimir el Número de Firma.", MsgBoxStyle.Critical)
                '        Exit Sub
                '    End If
                '    xCoord += 95
                '    yCoord -= 8
                '    fontSize = 9
                '    fontColor = &H0
                '    'FirmaNum = ascii.GetBytes(dr_Credenciales("NumFirma"))
                '    FirmaNum = ascii.GetBytes("")
                '    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, FirmaNum, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                '        'error drawing text into buffer
                '        ascii = Nothing
                '        ZBRGDICloseGraphics(hDC, err)
                '        MsgBox("Ha Ocurrido un Error al Imprimir el Número de Firma.", MsgBoxStyle.Critical, frm_MENU.Text)
                '        Exit Sub
                '    End If
                '    xCoord -= 225
                'End If
                'xCoord -= 125
                'yCoord += 60
                'fontSize = 6
                'fontColor = &HFF0000
                'Ingreso = ascii.GetBytes("INGRESO:")
                'If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Ingreso, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                '    'error drawing text into buffer
                '    ascii = Nothing
                '    ZBRGDICloseGraphics(hDC, err)
                '    MsgBox("Ha Ocurrido un Error, al Imprimir el Ingreso del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                '    Exit Sub
                'End If
                'xCoord += 130
                'yCoord -= 5
                'width += 20
                'fontSize = 8
                'fontColor = &H0
                'Ingreso = ascii.GetBytes(dr_Credenciales("Fecha_Ingreso"))
                'If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Ingreso, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                '    'error drawing text into buffer
                '    ascii = Nothing
                '    ZBRGDICloseGraphics(hDC, err)
                '    MsgBox("Ha Ocurrido un Error, al Imprimir el Ingreso del Empleado", MsgBoxStyle.Critical, frm_MENU.Text)
                '    Exit Sub
                'End If

                '*****************************Imagen del Empleado*******************************
                xCoord = 160
                yCoord = 300
                width = 330 '340 '378
                height = 355
                'Using fs As New FileStream(Ruta & "Foto.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                'fs.Write(Dr_CredencialesZEBRA("Frente"), 0, Dr_CredencialesZEBRA("Frente").Length)
                ' fs.Flush()
                'fs.Close()
                ' End Using
                fName = ascii.GetBytes(Ruta & "Frente.JPG")
                If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error al Imprimir la Foto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                Dim Nombre As String = dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos")
                Nombre = Replace(Nombre, "Ñ", "N")
                Empleado = ascii.GetBytes(Nombre)

                If Empleado.Length >= 23 Then
                    fontSize = 8
                    height += 670
                End If
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Empleado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Nombre del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 90
                Puesto = ascii.GetBytes(dr_Credenciales("Puesto"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Puesto, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Puesto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 50
                Departamento = ascii.GetBytes(dr_Credenciales("Departamento"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Departamento, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Departamento del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                    MsgBox("Ha Ocurrido un Error al Imprimir la Fecha de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                fontColor = &H0
                fontSize = 8
                xCoord += 140
                yCoord -= 6
                width -= 460
                Expedida = ascii.GetBytes(dr_Credenciales("Fecha_Expide"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Expedida, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir la Fecha de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                    MsgBox("Ha Ocurrido un Error al Imprimir la Fecha de Expiración.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                fontColor = &H0
                fontSize = 8
                xCoord += 105
                yCoord -= 6
                Expira = ascii.GetBytes(dr_Credenciales("FechaVenceCred"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Expira, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir la Fecha de Expiración.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                xCoord -= xCoord
                yCoord += 50
                width = 648
                height = 60
                'Using fs As New FileStream(Ruta & "Barra.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                'fs.Write(Dr_CredencialesZEBRA("Codigo"), 0, Dr_CredencialesZEBRA("Codigo").Length)
                'fs.Flush()
                'fs.Close()
                ' End Using
                fName = ascii.GetBytes(Ruta & "Codigo.JPG")
                If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error al Imprimir el Codigo de Barras.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '************************TERMINA TEXTO DE LA TARJETA**********************************

                ' ***********************Imprime todo lo que contenga el Buffer***********************
                If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                    'error printing buffer
                    MsgBox("Ocurrio un Error al Imprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '  *********************************************************************************

                If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ascii = Nothing


                If File.Exists(Ruta & "Frente.JPG") Then File.Delete(Ruta & "Frente.JPG")
                If File.Exists(Ruta & "Codigo.JPG") Then File.Delete(Ruta & "Codigo.JPG")
                If File.Exists(Ruta & "LogoSISSAZebra.JPG") Then File.Delete(Ruta & "LogoSISSAZebra.JPG")

            Catch Ex As Exception
                FuncionesGlobales.TrataEx(Ex, True)
            End Try
        Else
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If


    End Sub

    Private Sub Imprimir_ZebraTrasera_SISSA()
        SegundosDesconexion = 0

        If Not dr_Credenciales Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")

            Try
                ' *********************************Inicia Parte Trasera**********************************************
                'Iniciar las Graficas
                If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error de Conexion con la Impresora.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ZBRGDICloseGraphics(hDC, err)
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
                'ImageG = ("C:\SIAC\SIAC\Modulos\Modulo_Reclutamiento\bin\Debug\guia.JPG")
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
                Dim yCoord As Integer = 110 '100 '70
                Dim width As Integer = 100
                Dim height As Integer = 50
                Dim Curp As Byte()
                Dim Cuip As Byte()
                Dim Sangre As Byte()
                Dim Seguro As Byte()
                Dim Encabezado As Byte()
                Dim Autoriza As Byte()
                Dim fname As Byte()
                Dim LeyendaSEDENA As Byte()

                If dr_Credenciales("Tipo") = "1" Then
                    'Negro
                    fontSize = 6
                    fontColor = &HFF0000
                    Curp = ascii.GetBytes("CURP:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Curp, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    xCoord += 75
                    yCoord -= 5
                    fontSize = 8
                    fontColor = &H0
                    Cuip = ascii.GetBytes(dr_Credenciales("CUIP"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Cuip, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord += 190
                    yCoord -= 5
                    fontSize = 8
                    fontColor = &H0
                    Sangre = ascii.GetBytes(dr_Credenciales("TipoSangre"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                    fontSize = 6
                    xCoord += 35
                    yCoord += 7
                    Sangre = ascii.GetBytes(dr_Credenciales("FactorSangre"))
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    xCoord -= 225 '190
                    yCoord += 35 '37 '40
                    fontSize = 6
                    fontColor = &HFF0000
                    Seguro = ascii.GetBytes("NUM.SEGURO:")
                    If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Seguro, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                        'error drawing text into buffer
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                        MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If

                    '**************AQUI SE HARA UN FOR DE UNA FUNCION QUE TRAE LAS ARMAS DEL EMPLEADO******************
                    Dim dr_Armas As DataTable = fn_Credenciales_ObtenValoresZebraArmas(dr_Credenciales("Id_Empleado"))
                    If Not dr_Armas Is Nothing Then

                        xCoord = 0
                        yCoord = 470
                        fontSize = 4
                        width += 30 '70
                        LeyendaSEDENA = ascii.GetBytes("AUT.SEDENA OF. S.L./13202 DEL 21/ENE/2012 AL 20/ENE/2014")
                        If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, LeyendaSEDENA, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                            'error drawing text into buffer
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub
                        End If

                        xCoord = 20
                        ' yCoord += 300
                        yCoord += 30 '500
                        fontSize = 5
                        'width += 30
                        fontColor = &HFF0000
                        Encabezado = ascii.GetBytes("TIPO       CALIBRE       MARCA       MODELO       MATRICULA")
                        If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                            'error drawing text into buffer
                            ascii = Nothing
                            ZBRGDICloseGraphics(hDC, err)
                            MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
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
                                MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Calibre"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Marca"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 120
                            Encabezado = ascii.GetBytes(Row("Modelo"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord += 130
                            Encabezado = ascii.GetBytes(Row("Matricula"))
                            If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Encabezado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                                'error drawing text into buffer
                                ascii = Nothing
                                ZBRGDICloseGraphics(hDC, err)
                                MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                                Exit Sub
                            End If
                            xCoord -= 490
                        Next
                        yCoord = 500 '510 '500 '470
                    Else
                        xCoord = 20
                        yCoord += 288 '300 '270
                        width += 30
                    End If
                Else
                    xCoord = 20
                    yCoord = 500
                    width = 630
                End If

                '*******************************************************************************************
                yCoord += 100 '130 '200

                fontSize = 6
                fontColor = &HFF0000
                Autoriza = ascii.GetBytes("AUTORIZA:")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Autoriza, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                fontSize = 7
                fontColor = &H0
                xCoord -= xCoord
                yCoord += 30

                If dr_Credenciales("UsuarioAutoriza").ToString.Length > 22 Then fontSize = 7
                Autoriza = ascii.GetBytes(dr_Credenciales("UsuarioAutoriza"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Autoriza, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '******************BANDA DORADA SISSA INFERIOR TRASERA
                Dim Color As Integer = &HC0A062 '&H0
                Dim thickness As Single = 80
                Dim Leyenda As Byte()
                yCoord += 290 '280 '290 '240
                width = 610
                height = 75
                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Error al crear rectangulo de color", MsgBoxStyle.Critical, frm_MENU.Text)
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
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 30
                Leyenda = ascii.GetBytes("SERVICIO INTEGRAL DE SEGURIDAD, S.A. DE C.V.")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 30
                Leyenda = ascii.GetBytes("ALVAREZ 209 NTE, COL CENTRO, MONTERREY, N.L.")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 30
                Leyenda = ascii.GetBytes("TELEFONO (81)8047-4545")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If


                ''*****************************Firma del Empleado*******************************
                xCoord = (648 - 345) / 2
                yCoord = 250 '240 '270
                width = 345 '176
                height = 206 '176
                If Not System.IO.Directory.Exists(Ruta) Then
                    System.IO.Directory.CreateDirectory(Ruta)
                End If

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
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Else
                    MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma. ", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                yCoord += 420 '430 '400
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
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Autorizante.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Else
                    MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma de Autorización. ", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                'Dibuja el Texto en el Buffer:

                ' ***********************Imprime todo lo que contenga el Buffer***********************
                If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                    'error printing buffer
                    MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '  *********************************************************************************
                If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                    MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ascii = Nothing

                If File.Exists(Ruta & "Firma.JPG") Then File.Delete(Ruta & "Firma.JPG")
                If File.Exists(Ruta & "FirmaAutoriza.JPG") Then File.Delete(Ruta & "FirmaAutoriza.JPG")

            Catch Ex As Exception
                FuncionesGlobales.TrataEx(Ex, True)
            End Try
        Else
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Imprimir_ZebraFrente_VRV()
        SegundosDesconexion = 0
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
                    MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                If Not Cn_Reclutamiento.fn_EmpleadosXFI_ActualizaCredencial(tbx_Nombres.Tag, Bytes) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            ban = "C"
            tbr_brillo.Enabled = False
            btn_fotoOriginal.Enabled = False
            ptb_mascara.Visible = False
            btn_masc2.Enabled = False
        End If

        If Not System.IO.Directory.Exists(Ruta) Then
            System.IO.Directory.CreateDirectory(Ruta)
            ptb_Foto.Image.Save(Ruta & "Frente.JPG")
            pct_Codigo.Image.Save(Ruta & "Codigo.JPG")
        Else
            ptb_Foto.Image.Save(Ruta & "Frente.JPG")
            pct_Codigo.Image.Save(Ruta & "Codigo.JPG")
        End If



        '********************************INICIA CREDENCIAL VRV********************************************************

        If Not dr_Credenciales Is Nothing Then

            '  Dim dr_Credenciales As DataRow = fn_Credenciales_ObtenValoresZebra(Elem.Tag)
            'If Not dr_Credenciales Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")
            ' ******************TEXTO*********************
            Try

                If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error de Conexion con la Impresora ", MsgBoxStyle.Critical, frm_MENU.Text)
                    ZBRGDICloseGraphics(hDC, err)
                    Exit Sub
                End If

                ' ''FONDO GUIA
                'Dim ImageG As String
                'Dim xCoordG As Integer = 0
                'Dim yCoordG As Integer = 0
                'Dim widthG As Integer = 648
                'Dim heightG As Integer = 1015
                'Dim fNameG As Byte()
                'ImageG = (Ruta & "guia.JPG")
                'fNameG = ascii.GetBytes(ImageG)
                'If (ZBRGDIDrawImageRect(fNameG, xCoordG, yCoordG, widthG, heightG, err) = 0) Then
                '    'error drawing image into buffer
                '    ascii = Nothing
                '    ZBRGDICloseGraphics(hDC, err)
                '    'exit
                '    MsgBox("Ha Ocurrido un Error, al Imprimir la Imagen de Fondo." & err.ToString())
                '    Exit Sub
                'End If

                '**************************GUIA DE RECORTE ************************************************
                Dim xCoord As Integer = 0
                Dim yCoord As Integer = 60
                Dim Guia As Byte()
                fontSize = 7
                Guia = ascii.GetBytes("*         *")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, 648, 10, Alineacion.Centrado, Guia, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Guia de Recorte", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '****************************IMAGENES************************

                'Dibuja una Imagen en el Buffer:

                Dim Imagen As String
                Dim ImagenFondo As String
                xCoord = 0
                yCoord += 10
                'Dim width As Integer = 1300
                'Dim height As Integer = 1300
                Dim width As Integer = 630 '650
                Dim height As Integer = 670 '650

                Dim fName As Byte()
                Dim FondoImg As Byte()
                My.Resources.VRV_LOGO_FONDO.Save(Ruta & "VRV_LOGO_FONDO.JPG")
                '***************************Imagen de SISSA********************************
                Imagen = Ruta & "VRV_LOGO_FONDO.JPG"
                fName = ascii.GetBytes(Imagen)
                If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                    'error drawing image into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error, en el Logotipo de VRV.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If


                '*****************************Imagen del Empleado*******************************
                Dim Color As Integer = &H800000 '&H0    CC0033
                Dim thickness As Single = 80
                xCoord = 160 '140 '280
                yCoord = 290 '280 '270 '260 '240 '440
                width = 330
                height = 355
                fName = ascii.GetBytes(Ruta & "Frente.JPG")
                If (ZBRGDIDrawImageRect(fName, xCoord, yCoord, width, height, err) = 0) Then
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error al Imprimir la Foto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If


                thickness = 2
                width = 331 '351
                height = 356 '351
                Color = &H0
                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear el Marco de la Fotografia.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If


                '************************BANDA INFERIOR******************************
                Color = &HFF0000
                xCoord = 0
                yCoord = 940
                width = 610
                height = 70
                thickness = 80
                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear la Banda Inferior.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If

                Dim Empleado As Byte()
                Dim Departamento As Byte()
                Dim ExpiraTit As Byte()
                Dim Curp As Byte()
                Dim Nomina As Byte()
                xCoord -= xCoord
                yCoord = 648 '388 '378  '370
                width = 648 '270
                height -= 290
                fontSize = 9
                fontColor = &H0
                fontBold = &H1
                Dim Nombre As String = dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos")
                Nombre = Replace(Nombre, "Ñ", "N")
                Empleado = ascii.GetBytes(Nombre)

                If Nombre.Length >= 23 Then
                    fontSize = 8
                    height += 670
                End If

                If Nombre.Length < 29 Then yCoord += 45

                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Empleado, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Nombre del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                yCoord = 738
                Curp = ascii.GetBytes("CURP: " & dr_Credenciales("CURP"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Curp, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la CURP.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 50
                ExpiraTit = ascii.GetBytes("Vigencia: " & dr_Credenciales("FechaVenceCred"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, ExpiraTit, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir la Fecha de Expiración.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                fontSize = 9
                yCoord += 50
                Nomina = ascii.GetBytes("No. Empleado: " & dr_Credenciales("Clave"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Nomina, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Número de Nomina.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                fontSize = 11
                xCoord -= xCoord
                yCoord += 90 '100 '110
                fontColor = &HFFFFFF
                Departamento = ascii.GetBytes(dr_Credenciales("Departamento"))

                If Departamento.Length >= 22 Then
                    fontSize = 10
                    yCoord -= 20
                End If

                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Departamento, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error al Imprimir el Departamento del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If


                '************************TERMINA TEXTO DE LA TARJETA**********************************

                ' ***********************Imprime todo lo que contenga el Buffer***********************      

                If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                    'error printing buffer
                    MsgBox("Ocurrio un Error al Imprimir.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '  *********************************************************************************

                If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ascii = Nothing


                If File.Exists(Ruta & "Frente.JPG") Then File.Delete(Ruta & "Frente.JPG")
                If File.Exists(Ruta & "Codigo.JPG") Then File.Delete(Ruta & "Codigo.JPG")
                If File.Exists(Ruta & "VRV_LOGO_FONDO.JPG") Then File.Delete(Ruta & "VRV_LOGO_FONDO.JPG")

            Catch Ex As Exception
                FuncionesGlobales.TrataEx(Ex, True)
            End Try
        Else
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        '********************************TERMINA CRED VRV******************************************************

    End Sub

    Private Sub Imprimir_ZebraTrasera_VRV()
        SegundosDesconexion = 0

        If Not dr_Credenciales Is Nothing Then
            Dim ascii As New ASCIIEncoding()
            Dim prnDriver As Byte() = ascii.GetBytes(printerName)
            Dim Fuente As Byte() = ascii.GetBytes("Arial")

            Try
                ' *********************************Inicia Parte Trasera**********************************************
                'Iniciar las Graficas
                If (ZBRGDIInitGraphics(prnDriver, hDC, err) = 0) Then
                    MsgBox("Ha Ocurrido un Error de Conexion con la Impresora.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ZBRGDICloseGraphics(hDC, err)
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
                'ImageG = ("C:\SIAC\SIAC\Modulos\Modulo_Reclutamiento\bin\Debug\guia.JPG")
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
                Dim xCoord As Integer
                Dim yCoord As Integer  '100 '70
                Dim width As Integer
                Dim height As Integer
                Dim Registro As Byte()
                Dim Cuip As Byte()
                Dim Sangre As Byte()
                Dim Encabezado As Byte()
                Dim Autoriza As Byte()
                Dim fname As Byte()
                Dim LeyendaSEDENA As Byte()
                Dim Color As Integer
                Dim Thickness As Single

                ''************************BANDA INFERIOR******************************
                Color = &HFF0000    '&H800000
                xCoord = 0
                yCoord = 0
                width = 610
                height = 70
                Thickness = 80
                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, Thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear la Banda Inferior.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If


                xCoord = 15
                yCoord = 110
                width = 630 '1300
                height = 670 '1250
                Dim Imagen As String
                My.Resources.Fondo_VRV.Save(Ruta & "Fondo_VRV.JPG")
                '***************************Imagen de SISSA********************************
                Imagen = Ruta & "Fondo_VRV.JPG"
                fname = ascii.GetBytes(Imagen)
                If (ZBRGDIDrawImageRect(fname, xCoord, yCoord, width, height, err) = 0) Then
                    'error drawing image into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    'exit
                    MsgBox("Ha Ocurrido un Error, en el Logotipo de VRV.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                ''*****************************Firma del Empleado*******************************
                xCoord = 5 '15 '30 '60
                'yCoord += 435 '240 '270
                yCoord = 300
                width = 295 '345 '625 '650 '600 '550 '500 '460 '345 + 115 '176
                height = 156 '206 '439 '464 '414 '364 '314 '274 '206 + 68 '176
                If Not System.IO.Directory.Exists(Ruta) Then
                    System.IO.Directory.CreateDirectory(Ruta)
                End If

                If Not IsDBNull(dr_Credenciales("Firma_Representante")) Then
                    Using fs As New FileStream(Ruta & "Firma_Representante.JPG", FileMode.OpenOrCreate, FileAccess.Write)
                        fs.Write(dr_Credenciales("Firma_Representante"), 0, dr_Credenciales("Firma_Representante").Length)
                        fs.Flush()
                        fs.Close()
                    End Using

                    fname = ascii.GetBytes(Ruta & "Firma_Representante.JPG")
                    If (ZBRGDIDrawImageRect(fname, xCoord, yCoord, width, height, err) = 0) Then
                        ascii = Nothing
                        ZBRGDICloseGraphics(hDC, err)
                        'exit
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Autorizante.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Else
                    MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma de Autorización. ", MsgBoxStyle.Critical, frm_MENU.Text)
                End If


                xCoord += 325 '730

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
                        MsgBox("Ha Ocurrido un Error, al Imprimir la Firma del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Exit Sub
                    End If
                Else
                    MsgBox("El Empleado " & dr_Credenciales("Nombres") & " " & dr_Credenciales("Apellidos") & " No tiene Firma. ", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

                '*******MARCOS DE LAS FIRMAS*****
                xCoord = 5 '30
                'yCoord -= 335 '318 '240 '270
                'yCoord = 300
                Thickness = 2
                width += 1 '346 '305 '310 '300 '270 '260 '280 '250 '231 '351
                height += 1 '207 '225 '220 '215 '185 '180 '190 '160 '142 '351
                Color = &HFF0000

                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, Thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear el Marco de la Firma Autoriza.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If

                xCoord += 325 '355 '350 '365

                If (ZBRGDIDrawRectangle(xCoord, yCoord, width, height, Thickness, Color, err) = 0) Then
                    MsgBox("Error al Crear el Marco de la Firme del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                End If

                'If dr_Credenciales("Tipo") = "1" Then
                'Negro
                xCoord = 0
                yCoord = 130
                width = 610
                height = 100
                fontSize = 10
                fontColor = &H0
                fontBold = &H0
                Registro = ascii.GetBytes("Permiso de Secretaria de Seguridad Publica Federal:")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Registro, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Cargar el Permiso de la Secretaria de Seguridad Publica.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                yCoord += 100
                height -= 50
                fontSize = 12
                fontColor = &H0
                fontBold = &H1
                Registro = ascii.GetBytes(dr_Credenciales("Registro"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Registro, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Cargar el Permiso de la Secretaria de Seguridad Publica.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '**************AQUI SE HARA UN FOR DE UNA FUNCION QUE TRAE LAS ARMAS DEL EMPLEADO******************
                'End If

                '*******************************************************************************************
                yCoord += 250 '300 '280 '270 '230 '130 '200
                xCoord = 0
                fontSize = 7
                fontColor = &H0
                width = 300
                height += 60
                fontSize = 6
                fontBold = &H1
                If dr_Credenciales("Representante").ToString.Length > 22 Then fontSize = 6
                Autoriza = ascii.GetBytes(dr_Credenciales("Representante"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Autoriza, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                xCoord = width + 50

                Dim Firma As Byte() = ascii.GetBytes("Firma Empleado")

                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Firma, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Firma Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                yCoord += 30
                xCoord += 40
                Dim IMSS As Byte() = ascii.GetBytes("IMSS:")

                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, IMSS, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda del IMSS", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                xCoord += 70
                IMSS = ascii.GetBytes(dr_Credenciales("Seguro"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, IMSS, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir el Numero de Segur0 Social.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                xCoord -= xCoord
                yCoord += 25
                fontBold = &H2 + &H1
                Dim Representante As Byte() = ascii.GetBytes("Representante Legal")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Representante, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir el Nombre del Autorizante.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                xCoord += 260
                Sangre = ascii.GetBytes("Tipo de Sangre:")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda del Tipo de Sangre.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                xCoord += 240
                Sangre = ascii.GetBytes(dr_Credenciales("TipoSangre") & " " & dr_Credenciales("FactorSangre"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Izquierda, Sangre, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir los Datos del Tipo de Sangre.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                xCoord -= xCoord '200
                yCoord += 40
                height = 100
                width = 600
                Dim Tel_Emerg As Byte() = ascii.GetBytes("Tel Emergencia: " & dr_Credenciales("Tel_Fijo") & " / " & dr_Credenciales("Tel_Cel"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Tel_Emerg, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir los Telefonos de Emergencia.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If


                xCoord = 0
                yCoord += 130
                width = 660 '48
                height = 30
                fontColor = &H0
                fontSize = 5
                fontBold = &H1

                Dim Leyenda As Byte() = ascii.GetBytes(dr_Credenciales("Empresa"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                yCoord += 25
                width -= 30
                height = 100
                Leyenda = ascii.GetBytes(dr_Credenciales("Direccion_Completa"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                width += 30
                yCoord += 50
                Leyenda = ascii.GetBytes("TELEFONO: " & dr_Credenciales("Telefono_Empresa"))
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                yCoord += 25
                Leyenda = ascii.GetBytes("LUNES-SABADO DE 8:30 A 19:00 HRS.")
                If (ZBRGDIDrawTextRect(xCoord, yCoord, width, height, Alineacion.Centrado, Leyenda, Fuente, fontSize, fontBold, fontColor, err) = 0) Then
                    'error drawing text into buffer
                    ascii = Nothing
                    ZBRGDICloseGraphics(hDC, err)
                    MsgBox("Ha Ocurrido un Error, al Imprimir la Leyenda de la Empresa", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                ' ***********************Imprime todo lo que contenga el Buffer***********************
                If (ZBRGDIPrintGraphics(hDC, err) = 0) Then
                    'error printing buffer
                    MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                '  *********************************************************************************
                If (ZBRGDICloseGraphics(hDC, err) = 0) Then
                    MsgBox("Ocurrio un Error al Imprimir las Tarjetas.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                ascii = Nothing

                If File.Exists(Ruta & "Firma.JPG") Then File.Delete(Ruta & "Firma.JPG")
                If File.Exists(Ruta & "Firma_Representante.JPG") Then File.Delete(Ruta & "Firma_Representante.JPG")
                If File.Exists(Ruta & "Fondo_VRV.JPG") Then File.Delete(Ruta & "Fondo_VRV.JPG")

            Catch Ex As Exception
                FuncionesGlobales.TrataEx(Ex, True)
            End Try
        Else
            MsgBox("No se encontró la Información de la Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

#End Region

End Class