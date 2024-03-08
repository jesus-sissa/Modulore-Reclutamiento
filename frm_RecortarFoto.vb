Imports System.Drawing.Imaging
Imports System.IO

Public Class frm_RecortarFoto
    '--variables editor imagen
    Private Mover As Boolean = False
    Private p_Mouse As Point = Nothing
    Private imgEditado As Image
    Private img As Image
    Dim cropBitmap As Bitmap
    Dim banderaImg As Boolean = False
    Dim AnchoMascara As Short = 0
    Dim AltoMascara As Short = 0
    Dim ban As String = ""

    Private Sub frm_RecortarFoto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdb_Interno.Checked = True
        ptb_Foto.Controls.Add(ptb_mascara)
        cmb_NombreEmpleado.Actualizar()

        img = Nothing
        ptb_Foto.Image = Nothing

        tbr_brillo.Enabled = False
        tbr_brillo.Value = 0
        btn_fotoOriginal.Enabled = False
        ptb_mascara.Visible = False
        btn_masc2.Enabled = False
        btn_cortaFoto.Enabled = False

        ptb_Foto.Width = 446
        ptb_Foto.Height = 335
    End Sub

    Private Sub ptb_mascara_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptb_mascara.MouseDown
        SegundosDesconexion = 0
        Cursor = Cursors.SizeAll
        Mover = True
        ' guarda rl el x e y donde se hizo clic   
        p_Mouse.X = e.X
        p_Mouse.Y = e.Y
    End Sub

    Private Sub ptb_mascara_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles ptb_mascara.MouseMove

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
            imgEditado = cropBitmap 'pasamos la imagen editada a guardar en laBDD
            ptb_Foto.SizeMode = PictureBoxSizeMode.Zoom

            ptb_Foto.Refresh() 'refresca la imagen
            '-+--------------------
            ptb_Foto.Image.Save("C:\Documents and Settings\programador3\Escritorio\fotoPrueba.jpg")
        Catch exc As Exception

        End Try
        '-----------Guarda la imagen el BDD
        Dim Bytes As Byte()
        'aqui pasa la imagen del picturebox a byte()ptb_Foto.Image
        Bytes = Cn_Reclutamiento.ImageToByteArray(imgEditado) 'imprimimos la imagenOriginal editada y No del PictureBox
        If rdb_Interno.Checked = True Then
            If Not Cn_Reclutamiento.fn_EmpleadosI_ActualizaCredencial(cmb_NombreEmpleado.SelectedValue, Bytes) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            If Not Cn_Reclutamiento.fn_EmpleadosXFI_ActualizaCredencial(cmb_NombreEmpleado.SelectedValue, Bytes) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar la foto", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

        tbr_brillo.Enabled = False
        btn_cortaFoto.Enabled = False
        btn_fotoOriginal.Enabled = True
        ptb_mascara.Visible = False
        btn_masc2.Enabled = False
        tbr_brillo.Value = 0
        banderaImg = False
        '-*--------*-****************************************
        ptb_Foto.Width = 446 'vuelve al tamaño original del picturebox
        ptb_Foto.Height = 335

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

    Private Sub btn_fotoOriginal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_fotoOriginal.Click
        SegundosDesconexion = 0
        ptb_Foto.Width = 446
        ptb_Foto.Height = 335

        'Vuelve a la imagen de frente Original
        Dim TablaFoto As New DataTable
        If ban = "F" Then
            ptb_Foto.Image = img
        Else
            If rdb_Interno.Checked = True Then
                TablaFoto = Cn_Reclutamiento.fn_Empleados_RecortarImagen(cmb_NombreEmpleado.SelectedValue)
            Else
                TablaFoto = Cn_Reclutamiento.fn_EmpleadosXF_RecortarImagen(cmb_NombreEmpleado.SelectedValue)
            End If

            If TablaFoto Is Nothing Then
                MsgBox("Ocurrio un Error al Consultar La Foto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            ElseIf TablaFoto.Rows.Count = 0 Then
                MsgBox("No se encontro la informacion del Empleado.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                Exit Sub
            Else
                If Not IsDBNull(TablaFoto.Rows(0)("Frente")) Then
                    Dim ms2 As MemoryStream = New MemoryStream(TablaFoto.Rows(0)("Frente"), 0, TablaFoto.Rows(0)("Frente").Length)
                    ms2.Write(TablaFoto.Rows(0)("Frente"), 0, TablaFoto.Rows(0)("Frente").Length)

                    img = Image.FromStream(ms2, True)
                    ptb_Foto.Image = img
                    ban = "F"

                End If
            End If

        End If
        '-------------ajusta la imagen----------------------
        Dim ANCHOES As Single, ALTOESC As Single
        Dim RESUL As Single

        ANCHOES = ptb_Foto.Image.Width / ptb_Foto.Width 'ANCHO 446
        ALTOESC = ptb_Foto.Image.Height / ptb_Foto.Height ' ALTO 335
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

    Private Sub btn_masc2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_masc2.Click
        SegundosDesconexion = 0

        If btn_masc2.Text = "Usar Mascara 2" Then
            ptb_mascara.Width = 241 'estas medidas son proporcionales a 120 y 130 y son definidas
            ptb_mascara.Height = 261  'Nota: la imagen en el picturebox debe abarcar todo y en Zoom
            btn_masc2.Text = "Usar Mascara 1"
        Else
            ptb_mascara.Width = 216  'X 1.1155
            ptb_mascara.Height = 234
            btn_masc2.Text = "Usar Mascara 2"
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub cmb_NombreEmpleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_NombreEmpleado.SelectedIndexChanged
        SegundosDesconexion = 0
        ptb_Foto.Width = 446
        ptb_Foto.Height = 335

        If cmb_NombreEmpleado.SelectedValue = 0 Then
            tbr_brillo.Enabled = False
            ptb_mascara.Visible = False
            btn_masc2.Enabled = False
            btn_cortaFoto.Enabled = False
            tbr_brillo.Value = 0
            btn_fotoOriginal.Enabled = False
            ptb_Foto.Image = Nothing
            Exit Sub
        End If

        Dim TablaFoto As New DataTable
        img = Nothing
        imgEditado = Nothing

        ban = ""
        'cargar los datos de la credencial
        If rdb_Interno.Checked = True Then
            TablaFoto = Cn_Reclutamiento.fn_Empleados_RecortarImagen(cmb_NombreEmpleado.SelectedValue)
        Else
            TablaFoto = Cn_Reclutamiento.fn_EmpleadosXF_RecortarImagen(cmb_NombreEmpleado.SelectedValue)
        End If

        If TablaFoto Is Nothing Then
            MsgBox("Ocurrio un Error al Consultar La Foto del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        ElseIf TablaFoto.Rows.Count = 0 Then
            MsgBox("No se encontro la informacion del Empleado.", MsgBoxStyle.Exclamation, frm_MENU.Text)
            Exit Sub
        Else
            'Muestra La foto Frente O Credencial

            If Not IsDBNull(TablaFoto.Rows(0)("Credencial")) Then
                Dim ms1 As MemoryStream = New MemoryStream(TablaFoto.Rows(0)("Credencial"), 0, TablaFoto.Rows(0)("Credencial").Length)
                ms1.Write(TablaFoto.Rows(0)("Credencial"), 0, TablaFoto.Rows(0)("Credencial").Length)
                'pasamos la imagen real de la base de datos ala variable img
                img = Image.FromStream(ms1, True)
                ptb_Foto.Image = img
                ' Habilita el botonOriginal
                btn_fotoOriginal.Enabled = True
                ban = "C"

                tbr_brillo.Enabled = False
                ptb_mascara.Visible = False
                btn_masc2.Enabled = False
                btn_cortaFoto.Enabled = False
                tbr_brillo.Value = 0

            ElseIf Not IsDBNull(TablaFoto.Rows(0)("Frente")) Then
                Dim ms2 As MemoryStream = New MemoryStream(TablaFoto.Rows(0)("Frente"), 0, TablaFoto.Rows(0)("Frente").Length)
                ms2.Write(TablaFoto.Rows(0)("Frente"), 0, TablaFoto.Rows(0)("Frente").Length)

                img = Image.FromStream(ms2, True)
                ptb_Foto.Image = img
                ban = "F"
                '-----------------------------
                tbr_brillo.Enabled = True
                ptb_mascara.Visible = True
                btn_cortaFoto.Enabled = True
                btn_fotoOriginal.Enabled = False
                btn_masc2.Enabled = True
                '-------------ajusta la imagen----------------------
                Dim ANCHOES As Single, ALTOESC As Single
                Dim RESUL As Single

                ANCHOES = (ptb_Foto.Image.Width) / ptb_Foto.Width 'ANCHO 446
                ALTOESC = ptb_Foto.Image.Height / ptb_Foto.Height ' ALTO 335
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
            End If
        End If
    End Sub

    Private Sub rdb_Interno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Interno.CheckedChanged
        If rdb_Interno.Checked = True Then
            cmb_NombreEmpleado.StoredProcedure = "Cat_Empleados_ComboGetActivos"
            cmb_NombreEmpleado.Sucursal = True
            cmb_NombreEmpleado.Actualizar()
        End If
    End Sub

    Private Sub rdb_Externo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Externo.CheckedChanged
        If rdb_Externo.Checked = True Then
            cmb_NombreEmpleado.StoredProcedure = "Cat_EmpleadosXFCombo_Get"
            cmb_NombreEmpleado.Sucursal = False
            cmb_NombreEmpleado.Actualizar()
        End If
    End Sub
End Class