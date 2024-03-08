
Public Class frm_CartaAcceso

    Dim Empresa As String
    Dim AsuntoFalta As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S), YA QUE FALTO EL DIA -DD- DE -MMMMMMMM- DEL PRESENTE AÑO POR MOTIVOS PERSONALES"
    Dim AsuntoNuevoIngreso As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S) DE NUEVO INGRESO. ASÍ MISMO AGRADECERÉ SE REALICEN LOS PROCEDIMIENTOS INDICADOS PARA EL INGRESO, E INFORMEN A LA BREVEDAD POSIBLE CUALQUIER ANOMALIA."
    Dim AsuntoExterno As String = "POR MEDIO DEL PRESENTE SOLICITO QUE SE LE FACILITE EL ACCESO A LAS INSTALACIONES DE VALORES A LA(S) SIGUIENTE(S) PERSONA(S). ASÍ MISMO AGRADECERÉ SE REALICEN LOS PROCEDIMIENTOS INDICADOS PARA EL INGRESO, E INFORMEN A LA BREVEDAD POSIBLE CUALQUIER ANOMALIA."
    Dim AsuntoOtro As String = ""


    Dim tt_Asunto As ToolTip

    Private Sub frm_CartaAcceso_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_CartaAcceso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tt_Asunto = New ToolTip
        Dim dr As DataRow = Cn_Reclutamiento.fn_CartasAcceso_ObtenerEmpresa
        Empresa = dr("Nombre")

        tbx_Empresa.Text = Empresa
        cmb_Empleado1.Actualizar()
        cmb_Autoriza.Actualizar()
        cmb_DirigidoA.Actualizar()
        lsv_PersonasAutorizadas.Columns.Add("Clave")
        lsv_PersonasAutorizadas.Columns.Add("Nombre")
        lsv_PersonasAutorizadas.Columns.Add("Empresa")

        dtp_FechaInicio.Value = Today
        dtp_FechaExpira.Value = Today

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub LimpiaPantalla()
        tbx_Nombre.Text = ""
        'tbx_Empresa.Text = ""
        tbx_Asunto.Clear()
        cmb_Autoriza.SelectedValue = 0
        btn_Guardar.Enabled = True
        tbx_Nombre.Focus()
        cmb_DirigidoA.SelectedValue = 0
        rdb_Falta.Checked = False
        rdb_NuevoIngreso.Checked = False
        rdb_Otro.Checked = False
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If rdb_Empleado.Checked Then
            If cmb_Empleado1.SelectedValue = 0 Then
                MsgBox("Seleccione Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Empleado1.Focus()
                Exit Sub
            End If
            lsv_PersonasAutorizadas.Items.Add(tbx_ClaveEmpleado.Text)
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).Tag = cmb_Empleado1.SelectedValue
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(cmb_Empleado1.Text)
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(tbx_Empresa.Text)

            cmb_Empleado1.SelectedValue = 0
            'tbx_Empresa.Clear()
            btn_Guardar.Enabled = True
            cmb_Empleado1.Focus()
        Else
            If tbx_Nombre.Text = "" Or tbx_Nombre.Text.Length < 10 Then
                MsgBox("Nombre Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Nombre.SelectAll()
                tbx_Nombre.Focus()
                Exit Sub
            End If
            If tbx_Empresa.Text = "" Then
                MsgBox("Indique la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_Empresa.Focus()
                Exit Sub
            End If
            'lsv_PersonasAutorizadas.Columns(0).Width = 0
            lsv_PersonasAutorizadas.Items.Add("0")
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).Tag = 0
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(tbx_Nombre.Text)
            lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.Items.Count - 1).SubItems.Add(tbx_Empresa.Text)
            tbx_Nombre.Clear()
            tbx_Empresa.Clear()
            btn_Guardar.Enabled = True
            tbx_Nombre.Focus()
        End If
    End Sub

    Private Sub lsv_PersonasAutorizadas_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_PersonasAutorizadas.SelectedIndexChanged
        btn_Borrar.Enabled = lsv_PersonasAutorizadas.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        lsv_PersonasAutorizadas.Items(lsv_PersonasAutorizadas.SelectedItems(0).Index).Remove()
        btn_Guardar.Enabled = (lsv_PersonasAutorizadas.Items.Count > 0)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        Dim frm As New frm_Reporte
        Dim Tipo As Integer

        If dtp_FechaExpira.Value.Date < dtp_FechaInicio.Value.Date Then
            MsgBox("La Fecha Expira debe ser mayor a la Fecha Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaExpira.Focus()
            Exit Sub
        End If

        If tbx_Asunto.Text = "" Then
            MsgBox("Capture el Asunto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Asunto.Focus()
            Exit Sub
        End If
        If cmb_Autoriza.SelectedValue = 0 Then
            MsgBox("Seleccione Autoriza.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Autoriza.Focus()
            Exit Sub
        End If
        If rdb_Empleado.Checked Then
            Tipo = 1
        Else
            Tipo = 2
        End If

        If cmb_DirigidoA.SelectedValue = 0 Then
            MsgBox("Seleccione Dirigido a.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DirigidoA.Focus()
            Exit Sub
        End If

        Dim ID As Integer = Cn_Reclutamiento.fn_CartasAcceso_Nuevo(tbx_Asunto.Text, cmb_Autoriza.SelectedValue, lsv_PersonasAutorizadas.Items, dtp_FechaInicio.Value, dtp_FechaExpira.Value, Tipo, cmb_DirigidoA.SelectedValue)
        If ID > 0 Then


            frm.crv.ReportSource = Cn_Reclutamiento.fn_CartasAcceso_GeneraReporte(ID)
            frm.ShowDialog()
        End If

        lsv_PersonasAutorizadas.Items.Clear()
        Call LimpiaPantalla()
        btn_Guardar.Enabled = False
        dtp_FechaInicio.Value = Today
        dtp_FechaExpira.Value = Today
        rdb_Empleado.Checked = True
    End Sub

    Private Sub rdb_Empleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Empleado.CheckedChanged
        tbx_Asunto.Clear()
        If rdb_Empleado.Checked = False Then
            tbx_Empresa.Text = ""
            tbx_Empresa.ReadOnly = False
            cmb_Empleado1.SelectedValue = 0
            lbl_Empleado.Enabled = False
            tbx_ClaveEmpleado.Enabled = False
            cmb_Empleado1.Enabled = False
            lbl_Nombre.Enabled = True
            tbx_Nombre.Enabled = True
        Else
            tbx_Empresa.Text = Empresa
            tbx_Empresa.ReadOnly = True
            tbx_Nombre.Text = ""
            lbl_Empleado.Enabled = True
            tbx_ClaveEmpleado.Enabled = True
            cmb_Empleado1.Enabled = True
            lbl_Nombre.Enabled = False
            tbx_Nombre.Enabled = False

            rdb_NuevoIngreso.Enabled = True
            rdb_Falta.Enabled = True
            rdb_Otro.Enabled = True
            rdb_NuevoIngreso.Checked = False
            rdb_Falta.Checked = False
            rdb_Otro.Checked = False

            rdb_Externo.Enabled = False
            rdb_Externo.Checked = False
        End If
    End Sub

    Private Sub rdb_Falta_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Falta.CheckedChanged
        If rdb_Falta.Checked Then
            tbx_Asunto.Text = AsuntoFalta
        End If
    End Sub

    Private Sub rdb_NuevoIngreso_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_NuevoIngreso.CheckedChanged
        If rdb_NuevoIngreso.Checked Then
            tbx_Asunto.Text = AsuntoNuevoIngreso
            tt_Asunto.IsBalloon = True
            tt_Asunto.ToolTipIcon = ToolTipIcon.Warning
            tt_Asunto.ToolTipTitle = "Atención"
        End If
    End Sub

    Private Sub rdb_Externo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Externo.CheckedChanged
        If rdb_Externo.Checked Then
            tbx_Asunto.Text = AsuntoExterno
            tt_Asunto.IsBalloon = True
            tt_Asunto.ToolTipIcon = ToolTipIcon.Warning
            tt_Asunto.ToolTipTitle = "Atención"
        End If
    End Sub

    Private Sub rdb_Otro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Otro.CheckedChanged
        If rdb_Otro.Checked Then
            tbx_Asunto.Text = AsuntoOtro
        End If
    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Datos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub rdb_Visitante_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Visitante.CheckedChanged
        rdb_NuevoIngreso.Enabled = False
        rdb_Falta.Enabled = False
        rdb_NuevoIngreso.Checked = False
        rdb_Falta.Checked = False

        rdb_Externo.Enabled = True
        rdb_Otro.Enabled = True
        rdb_Externo.Checked = False
        rdb_Otro.Checked = False
    End Sub

End Class

