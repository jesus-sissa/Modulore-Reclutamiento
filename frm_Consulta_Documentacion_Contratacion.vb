
Imports Modulo_Reclutamiento.Cn_Reclutamiento
Public Class frm_Consulta_Documentacion_Contratacion
    Dim Id_Selecionado As Integer = 0
    Dim _ClaveProspecto As String
    Dim _Prospecto As String
    Private _contratos As frm_Documento
    Private DownloadPath As String = Nothing
    Private Sub frmConsultaDocumentosContratacion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Pais As Integer = 1

        cmb_filtro.AgregarItem("P", "Prospectos")
        cmb_filtro.AgregarItem("E", "Empleados")
        cmb_filtro.SelectedValue = "P"

        cmb_aptos.AgregarItem("S", "SI APTOS")
        cmb_aptos.AgregarItem("N", "NO APTOS")
        '--------------------

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Status")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("B", "BAJAS")
        cmb_Status.AgregarItem("V", "VALIDADOS")


    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged
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

        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(sender As Object, e As EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked

        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub btn_MostrarCatalogo_Click(sender As Object, e As EventArgs) Handles btn_MostrarCatalogo.Click
        SegundosDesconexion = 0

        Call LlenarListaProspectos()
    End Sub

    Sub LlenarListaProspectos()
        If cmb_DepartamentoFiltro.SelectedValue Is Nothing Then Exit Sub
        If cmb_PuestoFiltro.SelectedValue Is Nothing Then Exit Sub

        If Dtp_Desde.Value.Date > Dtp_Hasta.Value.Date Then
            MsgBox("Las Fechas son Incorrectas", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date) > 366 Then
            MsgBox("El rango de fechas maximo es de un año.", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If

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


        If cmb_aptos.Enabled And cmb_aptos.SelectedValue = "0" Then
            MsgBox("Seleccione si desea mostar solo Aptos o No Aptos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_aptos.Focus()
            Exit Sub
        End If

        Dim St As String
        If chk_Status.Checked Then
            St = "T"
        Else
            St = cmb_Status.SelectedValue
        End If

        Dim Apto As String
        If chk_Aptos.Checked Then
            Apto = "T"
        Else
            Apto = cmb_aptos.SelectedValue
        End If
        Me.Cursor = Cursors.WaitCursor
        lsv_Catalogo.Items.Clear()

        If cmb_filtro.SelectedValue = "P" Then
            If Not fn_Prospectos_LlenarLista(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, St, Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date, Apto) Then
                MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Prospectos.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else

            'Aqui se llena la lista
            If Not Cn_Reclutamiento.fn_Empleados_LlenarLista(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, St) Then
                MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

        End If

        'Aqui se llena la lista

        'Aqui se ocultan y se muestran los botones de reporte
        'Call BotonesCatalogo()
        Me.Cursor = Cursors.Default

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub
    Private Sub cmbs_Catalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged, cmb_PuestoFiltro.SelectedValueChanged, cmb_DepartamentoFiltro.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        'Call BotonesCatalogo()
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedValueChanged
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

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        'Call BotonesCatalogo()
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub chk_Aptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Aptos.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        'Call BotonesCatalogo()
        cmb_aptos.SelectedValue = 0
        cmb_aptos.Enabled = Not chk_Aptos.Checked
        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub btn_Modificar_Click(sender As Object, e As EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        btn_AvisoCandidatos.Enabled = False
        btn_CartaConfidencialidad.Enabled = False
        btn_ConvenioConfidencialidad.Enabled = False
        btn_AvisoPrivacidad.Enabled = False
        btn_Concentimientos.Enabled = False
        btn_ContratoLaboral.Enabled = False
        btn_ExamenB.Enabled = False
        If Id_Selecionado <> "0" Then
            DocumentosContatacion()
        End If



    End Sub

    Private Sub DocumentosContatacion()

        Dim Documentos = Cn_Reclutamiento.fn_DocumentosContratosEmp(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2), lsv_documentospros)
        Dim Examen = Cn_Reclutamiento.fn_ResultadoExamenBarsit(Id_Selecionado, cp_lsv_ResultadosExamen)

        If lsv_documentospros.Items.Count > 0 Then
            MsgBox("Documentos Encontrados")

            If lsv_documentospros.Items(0).SubItems(1).Text = "S" Then
                btn_AvisoCandidatos.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(2).Text = "S" Then
                btn_CartaConfidencialidad.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(3).Text = "S" Then
                btn_ConvenioConfidencialidad.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(4).Text = "S" Then
                btn_AvisoPrivacidad.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(5).Text = "S" Then
                btn_Concentimientos.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(6).Text = "S" Then
                btn_ContratoLaboral.Enabled = True
            End If
            If lsv_documentospros.Items(0).SubItems(7).Text = "S" Then
                btn_ExamenB.Enabled = True
            End If

            _Prospecto = lsv_documentospros.Items(0).SubItems(8).Text

        End If
        If cp_lsv_ResultadosExamen.Items.Count > 0 Then

            If cp_lsv_ResultadosExamen.Items(0).SubItems(1).Text = "SI" Then
                btn_ExamenB.Enabled = True
            End If
        End If

    End Sub



    Private Sub lsv_Catalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Id_Selecionado = lsv_Catalogo.SelectedItems(0).Tag
            _ClaveProspecto = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
            btn_Modificar.Enabled = True
        Else
            Id_Selecionado = 0
            _ClaveProspecto = "0"
            btn_Modificar.Enabled = False
        End If

    End Sub

    Private Sub btn_AvisoCandidatos_Click(sender As Object, e As EventArgs) Handles btn_AvisoCandidatos.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 1
        _contratos.Text = "Aviso Candidatos"

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With
        _contratos.InfContrato = info
        _contratos.Show()
    End Sub

    Private Sub btn_CartaConfidencialidad_Click(sender As Object, e As EventArgs) Handles btn_CartaConfidencialidad.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 2
        _contratos.Text = "Carta Confidencialidad"

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With
        _contratos.InfContrato = info
        _contratos.Show()
    End Sub

    Private Sub btn_ConvenioConfidencialidad_Click(sender As Object, e As EventArgs) Handles btn_ConvenioConfidencialidad.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 3
        _contratos.Text = "Convenio Confidencialidad"

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .FirmasRepTes = Cn_Reclutamiento.fn_GetFirmasTestigoReprecentante(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With
        _contratos.InfContrato = info
        _contratos.Show()
    End Sub

    Private Sub btn_AvisoPrivacidad_Click(sender As Object, e As EventArgs) Handles btn_AvisoPrivacidad.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 4

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With
        _contratos.InfContrato = info
        _contratos.Text = "Aviso Privacidad"
        _contratos.Show()
    End Sub

    Private Sub btn_Concentimientos_Click(sender As Object, e As EventArgs) Handles btn_Concentimientos.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 5

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With
        _contratos.InfContrato = info
        _contratos.Text = "Concentimientos"
        _contratos.Show()
    End Sub

    Private Sub btn_ContratoLaboral_Click(sender As Object, e As EventArgs) Handles btn_ContratoLaboral.Click

        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 6

        Dim prospecto As New cls_Persona
        With prospecto
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Sexo = lsv_documentospros.Items(0).SubItems(10).Text
            .Edad = lsv_documentospros.Items(0).SubItems(11).Text
            .EstadoCivil = lsv_documentospros.Items(0).SubItems(12).Text
            .Curp = lsv_documentospros.Items(0).SubItems(13).Text
            .Rfc = lsv_documentospros.Items(0).SubItems(14).Text
            .Domicilio = lsv_documentospros.Items(0).SubItems(15).Text
            .Puesto = lsv_documentospros.Items(0).SubItems(9).Text
            .Sueldo = CDbl(lsv_documentospros.Items(0).SubItems(16).Text).ToString("C")
        End With

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .Persona = prospecto
            .Beneficiario = lsv_documentospros.Items(0).SubItems(18).Text
            .FirmasRepTes = Cn_Reclutamiento.fn_GetFirmasTestigoReprecentante(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
            .Huellas = Cn_Reclutamiento.fn_Get_HuellasProspecto(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        End With


        _contratos.InfContrato = info
        _contratos.Text = "Contrato Laboral"
        _contratos.Show()
    End Sub
    Private Sub btn_path_Click(sender As Object, e As EventArgs) Handles btn_path.Click
        Dim dialog = New FolderBrowserDialog()
        dialog.SelectedPath = Application.StartupPath
        If DialogResult.OK = dialog.ShowDialog() Then
            DownloadPath = dialog.SelectedPath
            txt_path.Text = dialog.SelectedPath
        End If
    End Sub



    Private Sub btn_CuestionarioMedico_Click(sender As Object, e As EventArgs) Handles btn_CuestionarioMedico.Click


        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 8
        _contratos.Text = "Cuestionario Medico"

        Dim cuestionarioMedico As CuestionarioMedico = Cn_Reclutamiento.fn_CM_Cuestionario(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
        With cuestionarioMedico
            .Inforpersonal = Cn_Reclutamiento.fn_CM_InformacionPersonal(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
            .AntecedentesMedicos = Cn_Reclutamiento.fn_CM_AntecedenteMedico(cuestionarioMedico.IdAntecedemteMedico)
            .AntecedentesGinecologicos = Cn_Reclutamiento.fn_CM_AntecedenteGinecologico(cuestionarioMedico.IdAntecedemteGinecologico)
        End With

        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_documentospros.Items(0).SubItems(8).Text
            .Firma = lsv_documentospros.Items(0).SubItems(17).Text
            .Fecha = lsv_documentospros.Items(0).SubItems(0).Text
            .CuestionarioMedico = cuestionarioMedico
        End With
        _contratos.InfContrato = info

        _contratos.Show()


    End Sub

    Private Sub cmb_filtro_SelectedValueChanged(sender As Object, e As EventArgs) Handles cmb_filtro.SelectedValueChanged
        If cmb_filtro.SelectedValue = "E" Then
            Dtp_Desde.Enabled = False
            Dtp_Hasta.Enabled = False
        Else
            Dtp_Desde.Enabled = True
            Dtp_Hasta.Enabled = True
        End If
    End Sub

    Private Sub btn_ExamenB_Click(sender As Object, e As EventArgs) Handles btn_ExamenB.Click
        _contratos = New frm_Documento
        _contratos.DownloadPath = DownloadPath
        _contratos.Documento = 7
        _contratos.Text = "Examen Barsit"
        Dim prospecto As New cls_Persona
        With prospecto
            '.Sexo = lsv_documentospros.Items(0).SubItems(11).Text
            '.Edad = lsv_documentospros.Items(0).SubItems(12).Text
            '.EstadoCivil = lsv_documentospros.Items(0).SubItems(13).Text
            '.Puesto = lsv_Catalogo.Items(0).SubItems(3).Text
            .Puesto = lsv_Catalogo.SelectedItems(0).SubItems(3).Text

        End With
        Dim info As New cls_Documentos
        With info
            .Nombre = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
            .RespuestasExamen = fn_RespuestasExamen(Id_Selecionado, IIf(cmb_filtro.SelectedValue = "P", 1, 2))
            .Fecha = cp_lsv_ResultadosExamen.Items(0).SubItems(3).Text
            .Persona = prospecto
        End With
        _contratos.InfContrato = info

        _contratos.Show()
    End Sub
End Class