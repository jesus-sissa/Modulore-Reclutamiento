Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosReingresosConsulta

    Private Sub frm_EmpleadosBajasConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_DepartamentoFiltro.Actualizar()
        cmb_PuestoFiltro.Actualizar()

        lsv_Listado.Columns.Add("Clave", 5)
        lsv_Listado.Columns.Add("Nombre", 20)
        lsv_Listado.Columns.Add("Departamento", 20)
        lsv_Listado.Columns.Add("Puesto", 15)
        lsv_Listado.Columns.Add("FechaRegistro", 15)

        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("B", "BAJAS")

    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged
        Call LimpiarLista()
        cmb_DepartamentoFiltro.SelectedValue = 0
        cmb_DepartamentoFiltro.Enabled = Not chk_DepartamentoFiltro.Checked
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        Call LimpiarLista()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        Call LimpiarLista()
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        Call LimpiarLista()
    End Sub



    Private Sub dtp_FechaDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaDesde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_FechaHasta.Focus()
    End Sub

    Private Sub dtp_FechaHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaHasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_DepartamentoFiltro.Focus()
    End Sub

    Private Sub cmb_DepartamentoFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_DepartamentoFiltro.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_PuestoFiltro.Enabled Then
                cmb_PuestoFiltro.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0
        Call LimpiarLista()
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedIndexChanged
        Call LimpiarLista()
    End Sub

    Sub LimpiarLista()
        lsv_Listado.Items.Clear()
        Call Contar_Registro()
        btn_Exportar.Enabled = False
    End Sub

    Sub Contar_Registro()
        SegundosDesconexion = 0
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Listado.Items.Count)
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        Dim Status As Char = ""
        SegundosDesconexion = 0
        lsv_Listado.Items.Clear()
        Call Contar_Registro()
        If dtp_FechaHasta.Value.Date < dtp_FechaDesde.Value.Date Then
            MsgBox("La Fecha Final debe ser mayor a la Fecha Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaHasta.Focus()
            Exit Sub
        End If

        If cmb_DepartamentoFiltro.Enabled AndAlso cmb_DepartamentoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DepartamentoFiltro.Focus()
            Exit Sub
        End If

        If cmb_PuestoFiltro.Enabled AndAlso cmb_PuestoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PuestoFiltro.Focus()
            Exit Sub
        End If

        If cmb_Status.Enabled AndAlso cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Estatus o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If

        If chk_Status.Checked Then
            Status = "T"
        Else
            Status = cmb_Status.SelectedValue
        End If

        If Not fn_EmpleadosReingresos_LlenarLista(lsv_Listado, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, Status) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Exportar.Enabled = lsv_Listado.Items.Count > 0

        Call Contar_Registro()

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

End Class