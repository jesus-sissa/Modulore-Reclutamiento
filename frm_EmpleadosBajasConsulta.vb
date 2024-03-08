Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosBajasConsulta

    Private Sub frm_EmpleadosBajasConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_DepartamentoFiltro.Actualizar()
        cmb_PuestoFiltro.Actualizar()

        lsv_Listado.Columns.Add("Clave", 5)
        lsv_Listado.Columns.Add("APaterno", 10)
        lsv_Listado.Columns.Add("AMaterno", 10)
        lsv_Listado.Columns.Add("Nombre", 10)
        lsv_Listado.Columns.Add("Departamento", 10)
        lsv_Listado.Columns.Add("Puesto", 10)
        lsv_Listado.Columns.Add("FechaBaja", 10)
        lsv_Listado.Columns.Add("MotivoBaja", 15)
        lsv_Listado.Columns.Add("Observaciones", 15)
        lsv_Listado.Columns.Add("UsuarioRegistro", 15)
    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        cmb_DepartamentoFiltro.SelectedValue = 0
        cmb_DepartamentoFiltro.Enabled = Not chk_DepartamentoFiltro.Checked
        Call Validar()
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
        Call Validar()
    End Sub

    Private Sub Validar()
        btn_Exportar.Enabled = lsv_Listado.Items.Count > 0
        If cmb_DepartamentoFiltro.SelectedValue = 0 And Not chk_DepartamentoFiltro.Checked Then
            btn_Mostrar.Enabled = False
            Exit Sub
        End If
        If cmb_PuestoFiltro.SelectedValue = 0 And Not chk_PuestoFiltro.Checked Then
            btn_Mostrar.Enabled = False
            Exit Sub
        End If
        btn_Mostrar.Enabled = True
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Listado.Items.Count)
    End Sub

    Sub LimpiarDatosRegistro()
        tbx_FechaRegistro.Clear()
        tbx_UsuarioRegistro.Clear()
        rtb_Observaciones.Clear()
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Listado.Items.Count)
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        Call Validar()
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedIndexChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        Call Validar()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If dtp_FechaHasta.Value.Date < dtp_FechaDesde.Value.Date Then
            MsgBox("La Fecha Hasta debe ser mayor a la Fecha Desde.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaHasta.Focus()
            Exit Sub
        End If
        Call LimpiarDatosRegistro()
        Dim Tipo As Integer
        'Tipo = 1 = Empleados
        'Tipo = 2 = Prospectos
        If rdb_Empleados.Checked Then Tipo = 1 Else Tipo = 2
        If Not fn_EmpleadosBaja_LlenarLista(lsv_Listado, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, Tipo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Exportar.Enabled = lsv_Listado.Items.Count > 0

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Listado.Items.Count)

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Listado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Listado.SelectedIndexChanged
        Call LimpiarDatosRegistro()
        If lsv_Listado.SelectedItems.Count = 0 Then Exit Sub
        rtb_Observaciones.Text = lsv_Listado.SelectedItems(0).SubItems(8).Text
        tbx_FechaRegistro.Text = lsv_Listado.SelectedItems(0).SubItems(9).Text
        tbx_UsuarioRegistro.Text = lsv_Listado.SelectedItems(0).SubItems(10).Text
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        Call Validar()
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        Call Validar()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Listado, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Consulta.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Listado_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Listado.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_FechaDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaDesde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_FechaHasta.Focus()
    End Sub

    Private Sub dtp_FechaHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaHasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then rdb_Empleados.Focus()
    End Sub

    Private Sub rdb_Empleados_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Empleados.KeyPress, rdb_Prospectos.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_DepartamentoFiltro.Enabled Then
                cmb_DepartamentoFiltro.Focus()
            ElseIf cmb_PuestoFiltro.Enabled Then
                cmb_PuestoFiltro.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
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

    Private Sub rdb_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Prospectos.CheckedChanged, rdb_Empleados.CheckedChanged
        SegundosDesconexion = 0

        lsv_Listado.Items.Clear()
        Call LimpiarDatosRegistro()
        Call Validar()
    End Sub

End Class