Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosporFuera
    Dim Id_Emp As Integer
    Dim RutaImagenTemp As String ' 31 enero 2013
    Dim TeniaImagenes As Boolean = False
    Dim FileSize As Long = 0
    Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Imagen|*.jpg", .Multiselect = False}
    Dim Ruta As String

    Private Sub frm_EmpleadosporFuera_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' Verificar longitud CveEmpleado 
        tbx_Clave.MaxLength = Long_ClaveEmp '11/04/2014

        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("B", "BAJAS")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

        cmb_Genero.AgregarItem("M", "MASCULINO")
        cmb_Genero.AgregarItem("F", "FEMENINO")

        cmb_EstadoCivil.Actualizar()

        cmb_Ciudad.AgregaParametro("@Status", "A", 0)
        cmb_Ciudad.AgregaParametro("@Id_Estado", -1, 1)
        cmb_Ciudad.Actualizar()

        cmb_Estado.AgregaParametro("@Status", "A", 0)
        cmb_Estado.AgregaParametro("@Id_Pais", 1, 1) '(idpais,1=mexico,1=integer)
        cmb_Estado.Actualizar()

        cmb_Puesto.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_Puesto.AgregaParametro("@Status", "A", 0)
        cmb_Puesto.Actualizar()
        cmb_Departamento.Actualizar()

        cmb_DepartamentoFiltro.Select() 'manda el foco

        Ruta = Application.StartupPath & "\"
        Dialogo.InitialDirectory = "C:\"

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Status")
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_Clave.Text.Trim = "" Then
            MsgBox("Indique la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If tbx_Nombres.Text.Trim = "" Then
            MsgBox("Indique el Nombre del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombres.Focus()
            Exit Sub
        End If

        If tbx_ApellidoPaterno.Text.Trim = "" Then
            MsgBox("Indique el Apellido Paterno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ApellidoPaterno.Focus()
            Exit Sub
        End If

        If tbx_ApellidoMaterno.Text.Trim = "" Then
            MsgBox("Indique el Apellido Materno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ApellidoMaterno.Focus()
            Exit Sub
        End If

        If cmb_Genero.SelectedValue = "0" Then
            MsgBox("Indique el Género del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Genero.Focus()
            Exit Sub
        End If

        If cmb_EstadoCivil.SelectedValue = "0" Then
            MsgBox("Indique el Estado Civil.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_EstadoCivil.Focus()
            Exit Sub
        End If


        If tbx_Calle.Text.Trim = "" Then
            MsgBox("Indique la calle donde vive.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Calle.Focus()
            Exit Sub
        End If

        If tbx_Numero.Text.Trim = "" Then
            MsgBox("Indique el Número.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Numero.Focus()
            Exit Sub
        End If

        If tbx_Colonia.Text.Trim = "" Then
            MsgBox("Indique la Colonia.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Colonia.Focus()
            Exit Sub
        End If

        If cmb_Ciudad.SelectedValue = 0 Then
            MsgBox("Indique la Ciudad de acuerdo al Estado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ciudad.Focus()
            Exit Sub
        End If

        If cmb_Departamento.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Departamento.Focus()
            Exit Sub
        End If

        If cmb_Puesto.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Puesto.Focus()
            Exit Sub
        End If

        tbx_Clave.Text = FuncionesGlobales.fn_PonerCeros(tbx_Clave.Text.Trim, 4)
        tbx_NombreCompleto.Text = (tbx_Nombres.Text.Trim & " " & tbx_ApellidoPaterno.Text.Trim & " " & tbx_ApellidoMaterno.Text.Trim)
        Dim MailPersonal As String
        If tbx_MailPersonal.Text.Trim = "" Then MailPersonal = "" Else MailPersonal = tbx_MailPersonal.Text.Trim

        '-----validar si clave existe-------------

        If fn_EmpleadosXF_ValidarClave(tbx_Clave.Text.Trim) AndAlso tbx_Clave.Text.Trim <> lbl_ClaveCompara.Text Then
            MsgBox("La Clave que Capturó ya existe en la Base de Datos, Capture Otra", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        '---------------Variables para fotos----------------
        Dim ImgBytesFrente As Byte() = Nothing
        Dim ImgBytesFirma As Byte() = Nothing
        Dim ImgBytesCodigo As Byte() = Nothing

        '---Crea el Codigo de Barras y la convierte a Bytes

        If pct_Frente.Image IsNot Nothing Then ImgBytesFrente = ImageToByteArray(pct_Frente.Image)
        If pct_Firma.Image IsNot Nothing Then ImgBytesFirma = ImageToByteArray(pct_Firma.Image)


        'Inserta un Nuevo empleado
        If tbp_Nuevo.Text = "Nuevo" Then

            Id_Emp = fn_EmpleadosXF_Guardar(tbx_Clave.Text, tbx_NombreCompleto.Text, cmb_Departamento.SelectedValue,
                                            cmb_Puesto.SelectedValue, cmb_Genero.SelectedValue,
                                            cmb_EstadoCivil.SelectedValue, MailPersonal, tbx_ApellidoPaterno.Text,
                                            tbx_ApellidoMaterno.Text, tbx_Nombres.Text, tbx_Calle.Text, tbx_Numero.Text,
                                            tbx_Colonia.Text,
                                            tbx_Telefono.Text, dtp_FechaNac.Value.Date,
                                            dtp_FechaIngreso.Value.Date, cmb_Ciudad.SelectedValue,
                                            tbx_NSS.Text.Trim, tbx_RFC.Text.Trim, tbx_CURP.Text.Trim,
                                            tbx_IdTributario.Text.Trim)

            If Id_Emp = 0 Then
                Exit Sub
                MsgBox("Error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                If Not fn_EmpleadosXF_GuardaImagenes(Id_Emp, ImgBytesFrente, ImgBytesFirma) Then
                    MsgBox("Error al intentar guardar los datos de Imagenes.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If

                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LimpiarObjetos_DatosGenerales()
                tbx_Clave.Focus()
            End If
        Else
            If Not fn_EmpleadosXF_GuardarCambios(tbx_Clave.Tag, tbx_Clave.Text, tbx_NombreCompleto.Text,
                                                 cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue,
                                                 cmb_Genero.SelectedValue, cmb_EstadoCivil.SelectedValue,
                                                 MailPersonal, tbx_ApellidoPaterno.Text, tbx_ApellidoMaterno.Text,
                                                 tbx_Nombres.Text, tbx_Calle.Text, tbx_Numero.Text,
                                                 tbx_Colonia.Text, tbx_Telefono.Text, dtp_FechaNac.Value.Date,
                                                 ImgBytesFrente, ImgBytesFirma, ImgBytesCodigo,
                                                 dtp_FechaIngreso.Value.Date, cmb_Ciudad.SelectedValue,
                                                 tbx_NSS.Text.Trim, tbx_RFC.Text.Trim,
                                                 tbx_CURP.Text.Trim, tbx_IdTributario.Text.Trim) Then
                MsgBox("Error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("Datos Actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LimpiarObjetos_DatosGenerales()
                Tab_Catalogo.SelectedTab = tbp_Listado 'regresa al listado

            End If
        End If
    End Sub

    Private Sub LimpiarObjetos_DatosGenerales()

        lsv_Catalogo.SelectedItems.Clear()
        tbx_Clave.Tag = 0
        tbx_NombreCompleto.Clear()
        tbx_Nombres.Clear()
        tbx_ApellidoPaterno.Clear()
        tbx_ApellidoMaterno.Clear()
        tbx_Clave.Clear()
        cmb_Departamento.SelectedValue = 0
        cmb_Puesto.SelectedValue = 0
        cmb_EstadoCivil.SelectedValue = 0
        tbx_MailPersonal.Clear()
        tbx_Calle.Clear()
        tbx_Numero.Clear()
        tbx_Colonia.Clear()
        cmb_Ciudad.SelectedValue = 0
        tbx_Telefono.Clear()
        cmb_Ciudad.SelectedValue = 0
        cmb_Estado.SelectedValue = 0
        dtp_FechaNac.Value = Date.Today
        cmb_Genero.SelectedValue = "0"
        dtp_FechaIngreso.Value = Date.Today

        'pct_Frente.Dispose()
        pct_Frente.Image = Nothing
        'pct_Firma.Dispose()
        pct_Firma.Image = Nothing
        'pct_Codigo.Dispose()
        pct_Codigo.Image = Nothing

        btn_LimpiarFrente.Enabled = False
        btn_LimpiarFirma.Enabled = False
        btn_ExtraerFirma.Enabled = False
        btn_ExtraerFrente.Enabled = False

    End Sub

    Sub NombreCompleto()
        tbx_NombreCompleto.Text = tbx_Nombres.Text.Trim & " " & tbx_ApellidoPaterno.Text.Trim & " " & tbx_ApellidoMaterno.Text.Trim
        If Trim(tbx_NombreCompleto.Text) = "" Then
            tbx_NombreCompleto.Clear()
        End If
    End Sub

    Private Sub tbx_Nombres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Nombres.TextChanged
        Call NombreCompleto()
    End Sub

    Private Sub tbx_ApellidoPaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ApellidoPaterno.TextChanged
        Call NombreCompleto()
    End Sub

    Private Sub tbx_ApellidoMaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ApellidoMaterno.TextChanged
        Call NombreCompleto()
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedValueChanged
        SegundosDesconexion = 0
        lsv_Catalogo.Items.Clear()
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
        Call BotonesCatalogo()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Call BotonesCatalogo()
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
    End Sub

    Sub BotonesCatalogo()
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Baja.Enabled = False
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_Modificar.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO"
            btn_Baja.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO"
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Id_Emp = lsv_Catalogo.SelectedItems(0).Tag
        Else
            Id_Emp = 0
        End If
        Call BotonesCatalogo()
    End Sub

    Private Sub btn_MostrarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarCatalogo.Click
        SegundosDesconexion = 0

        Call LlenarListaEmpleadosXF()
    End Sub

    Sub LlenarListaEmpleadosXF()
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
        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            If Tab_Catalogo.SelectedIndex = 0 Then
                MsgBox("Seleccione un Status para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Status.Focus()
                Exit Sub
            End If
        End If

        Dim St As String
        If chk_Status.Checked Then
            St = "T"
        Else
            St = cmb_Status.SelectedValue
        End If
        Me.Cursor = Cursors.WaitCursor
        lsv_Catalogo.Items.Clear()

        'Aqui se llena la lista
        If Not fn_EmpleadosXF_LlenarLista(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, St) Then
            MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aqui se ocultan y se muestran los botones de reporte
        Call BotonesCatalogo()
        Me.Cursor = Cursors.Default

        FuncionesGlobales.fn_NumRegistros(Lbl_NumeroR, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        If Tab_Catalogo.SelectedIndex = 1 Then
            tbx_Clave.Select()
        Else
            Call LimpiarObjetos_DatosGenerales()
            tbp_Nuevo.Text = "Nuevo"
            cmb_DepartamentoFiltro.Focus()
        End If
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedValueChanged
        SegundosDesconexion = 0

        'Llenar los Puestos
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub cmb_Estado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Estado.Items.Count > 0 Then
            cmb_Ciudad.ActualizaValorParametro("@Id_Estado", cmb_Estado.SelectedValue)
            cmb_Ciudad.Actualizar()
        End If
    End Sub

    Private Sub cmb_Departamento_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Departamento.SelectedValueChanged
        SegundosDesconexion = 0

        'Llenar los Puestos
        If cmb_Departamento.Items.Count > 0 Then
            If cmb_Departamento.SelectedValue = 0 Then
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", cmb_Departamento.SelectedValue)
            End If
            cmb_Puesto.Actualizar()
        End If
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        If Not fn_EmpleadosXF_BajaAlta(lsv_Catalogo.SelectedItems(0).Tag) Then
            MsgBox("Ocurrió un error al intentar dar de baja al Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            MsgBox("El Empleado fue dado de baja Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarListaEmpleadosXF()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Sub Modificar()
        SegundosDesconexion = 0

        If Not btn_Modificar.Enabled Then Exit Sub

        Tab_Catalogo.SelectedTab = tbp_Nuevo
        tbp_Nuevo.Text = "Modificar"

        Call LlenarDatosGenerales(Id_Emp)
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        Call Modificar()
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        Call Modificar()
    End Sub

    Sub LlenarDatosGenerales(ByVal Id_EmpleadoXF As Integer)
        'Aqui se obtienen los DATOS GENERALES del Empleado seleccionado
        Dim Dr_Datos As DataRow = fn_EmpleadosXF_Read(Id_Emp)

        If Not Dr_Datos Is Nothing Then
            tbx_Clave.Text = Dr_Datos("Clave")
            tbx_Clave.Tag = Dr_Datos("IdEmpXF") 'almacena id_empeladoXF

            tbx_ApellidoPaterno.Text = Dr_Datos("APaterno")
            tbx_ApellidoMaterno.Text = Dr_Datos("AMaterno")
            tbx_Nombres.Text = Dr_Datos("Nombres")
            tbx_NombreCompleto.Text = Dr_Datos("Nombre")
            cmb_Genero.SelectedValue = Dr_Datos("Sexo")
            cmb_EstadoCivil.SelectedValue = Dr_Datos("Id_EstadoCivil")
            dtp_FechaNac.Value = Dr_Datos("FechaNacimiento")
            tbx_MailPersonal.Text = Dr_Datos("Mail_Personal")
            tbx_Telefono.Text = Dr_Datos("Telefono")

            tbx_NSS.Text = Dr_Datos("Numero_Seguro")

            tbx_RFC.Text = Dr_Datos("RFC")
            tbx_IdTributario.Text = Dr_Datos("IdTributario")

            tbx_CURP.Text = Dr_Datos("CURP")

            tbx_Calle.Text = Dr_Datos("Calle")
            tbx_Numero.Text = Dr_Datos("Numero")
            tbx_Colonia.Text = Dr_Datos("Colonia")
            cmb_Estado.SelectedValue = Dr_Datos("Id_Estado")
            cmb_Ciudad.SelectedValue = Dr_Datos("Id_Ciudad")
            cmb_Departamento.SelectedValue = Dr_Datos("Id_Departamento")
            cmb_Puesto.SelectedValue = Dr_Datos("Id_Puesto")
            dtp_FechaIngreso.Value = Dr_Datos("FechaIngreso")

            lbl_ClaveCompara.Text = Dr_Datos("Clave")

            If Not IsDBNull(Dr_Datos("Frente")) Then pct_Frente.Image = ByteArrayToImage(Dr_Datos("Frente"))
            If Not IsDBNull(Dr_Datos("Firma")) Then pct_Firma.Image = ByteArrayToImage(Dr_Datos("Firma"))
        End If

        If pct_Frente.Image Is Nothing Then
            btn_LimpiarFrente.Enabled = False
            btn_ExtraerFrente.Enabled = False
        Else
            btn_LimpiarFrente.Enabled = True
            btn_ExtraerFrente.Enabled = True
        End If

        If pct_Firma.Image Is Nothing Then
            btn_LimpiarFirma.Enabled = False
            btn_ExtraerFirma.Enabled = False
        Else
            btn_LimpiarFirma.Enabled = True
            btn_ExtraerFirma.Enabled = True
        End If

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Call LimpiarObjetos_DatosGenerales()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tbp_Listado

        'Aqui se ajusta el titulo de la pestaña
        tbp_Nuevo.Text = "Nuevo"
        Id_Emp = 0

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

    Sub Examinar(ByVal Pct As PictureBox, ByVal Btn As Button, ByVal NombreJPG As String)
        Dialogo.ShowDialog()
        If Dialogo.FileName <> "" Then
            Me.Cursor = Cursors.WaitCursor
            btn_Guardar.Enabled = True
            Dim Imagen As Image = Image.FromFile(Dialogo.FileName)

            'almacene la ruta de la imagen temporal para luego convertirlo en bytes
            RutaImagenTemp = FuncionesGlobales.fn_ReducirImagen(NombreJPG, Imagen, 200000, 30, Ruta, 800, 600)

            Pct.Image = Image.FromFile(RutaImagenTemp) '31enero2013
            'Pct.Load(RutaImagenTemp)' asim staba
            Imagen.Dispose() 'libera la variable imagen
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

    Private Sub btn_TomarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarFrente.Click
        SegundosDesconexion = 0
        Call CapturarCamara(pct_Frente, btn_LimpiarFrente)
        If pct_Frente.Image IsNot Nothing Then btn_ExtraerFrente.Enabled = True
    End Sub

    Private Sub btn_TomarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarFirma.Click
        SegundosDesconexion = 0
        Call CapturarCamara(pct_Firma, btn_LimpiarFirma)
        If pct_Firma.Image IsNot Nothing Then btn_ExtraerFirma.Enabled = True
    End Sub

    Private Sub btn_ExaminarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarFrente.Click
        SegundosDesconexion = 0
        Call Examinar(pct_Frente, btn_LimpiarFrente, "PCT_Frente")
        If pct_Frente.Image IsNot Nothing Then btn_ExtraerFrente.Enabled = True
    End Sub

    Private Sub btn_ExaminarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExaminarFirma.Click
        SegundosDesconexion = 0
        Call Examinar(pct_Firma, btn_LimpiarFirma, "PCT_Firma")
        If pct_Firma.Image IsNot Nothing Then btn_ExtraerFirma.Enabled = True
    End Sub

    Private Sub btn_LimpiarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarFrente.Click
        SegundosDesconexion = 0
        If pct_Frente.Image Is Nothing Then Exit Sub
        pct_Frente.Image.Dispose()
        pct_Frente.Image = Nothing
    End Sub

    Private Sub btn_LimpiarFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarFirma.Click
        SegundosDesconexion = 0
        If pct_Firma.Image Is Nothing Then Exit Sub
        pct_Firma.Image.Dispose()
        pct_Firma.Image = Nothing
    End Sub

    Private Sub btn_ExtraerFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFrente.Click
        SegundosDesconexion = 0
        ExtraeImagenes(pct_Frente, tbx_Clave.Text & " - Frente.jpg")
    End Sub

    Private Sub btn_ExtraerFirma_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExtraerFirma.Click
        SegundosDesconexion = 0
        ExtraeImagenes(pct_Firma, tbx_Clave.Text & " - Firma.jpg")

    End Sub

    Sub ExtraeImagenes(ByVal pct As PictureBox, ByVal NameFile As String)
        Dim RutaExportar As String
        Dim Copia As Bitmap = Nothing
        If pct.Image IsNot Nothing Then
            RutaExportar = GuardarImagenes(NameFile)
            If RutaExportar = Nothing Then Exit Sub 'se sale si cancela la extraccion de la imagen
            Copia = New Bitmap(pct.Image)
            Copia.Save(RutaExportar, System.Drawing.Imaging.ImageFormat.Jpeg)
            MsgBox("Imagen extraida correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Copia.Dispose()
        End If
    End Sub

    Private Function GuardarImagenes(ByVal NombreArchivo As String) As String
        SegundosDesconexion = 0

        Dim Dialogo As New FolderBrowserDialog With {.Description = "Seleccione la Carpeta para las Imágenes.", .ShowNewFolderButton = True}
        If Dialogo.ShowDialog() = Windows.Forms.DialogResult.Cancel Then Return Nothing
        Try
            Dim CarpetaDestino As String = Dialogo.SelectedPath
            If CarpetaDestino.Length = 3 Then
                CarpetaDestino = CarpetaDestino & NombreArchivo
            Else
                CarpetaDestino = CarpetaDestino & "\" & NombreArchivo
            End If
            Cn_Login.fn_Log_Create("EXTRAER FOTOS DEL EMPLEADO: " & tbx_Clave.Text & " - " & tbx_NombreCompleto.Text)
            Dialogo.Dispose()
            Return CarpetaDestino
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


End Class