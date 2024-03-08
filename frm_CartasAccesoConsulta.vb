Public Class frm_CartasAccesoConsulta

    Private Sub frm_CartasAccesoConsulta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_CartasAccesoConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Empleado.Actualizar()
        cmb_Status.AgregarItem("A", "ACTIVA")
        cmb_Status.AgregarItem("C", "CANCELADA")

        lsv_Catalogo.Columns.Add("Fecha")
        lsv_Catalogo.Columns.Add("UsuarioRegistro")
        lsv_Catalogo.Columns.Add("UsuarioAutoriza")
        lsv_Catalogo.Columns.Add("Observaciones")
        lsv_Catalogo.Columns.Add("FechaInicio")
        lsv_Catalogo.Columns.Add("FechaFin")
        lsv_Catalogo.Columns.Add("Status")

        lsv_Detalle.Columns.Add("Clave")
        lsv_Detalle.Columns.Add("Nombre")
        lsv_Detalle.Columns.Add("Empresa")
    End Sub

    Private Sub Validar()
        If cmb_Empleado.SelectedValue = 0 And Not chk_Empleados.Checked Then
            btn_Mostrar.Enabled = False
            Exit Sub
        End If

        If cmb_Status.SelectedValue = "0" And Not chk_Status.Checked Then
            btn_Mostrar.Enabled = False
            Exit Sub
        End If
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
        btn_Mostrar.Enabled = True
    End Sub

    Private Sub chk_Empleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Empleados.CheckedChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Call Validar()
        If chk_Empleados.Checked Then
            cmb_Empleado.Enabled = False
            cmb_Empleado.SelectedValue = 0
        Else
            cmb_Empleado.Enabled = True
        End If

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        Call Validar()
        If chk_Status.Checked Then
            cmb_Status.Enabled = False
            cmb_Status.SelectedValue = "0"
        Else
            cmb_Status.Enabled = True
        End If

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub cmb_Empleado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedIndexChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_Mostrar.Enabled = False
        Call Validar()

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_Mostrar.Enabled = False
        Call Validar()

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_Mostrar.Enabled = False
        dtp_FechaHasta.MinDate = dtp_FechaDesde.Value
        Call Validar()

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        lsv_Catalogo.Items.Clear()
        lsv_Detalle.Items.Clear()
        btn_Mostrar.Enabled = False
        dtp_FechaDesde.MaxDate = dtp_FechaHasta.Value
        Call Validar()

        btn_Reimprimir.Enabled = False
        btn_Cancelar.Enabled = False
        btn_Exportar.Enabled = False
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If Not Cn_Reclutamiento.fn_CartasAccesoConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, cmb_Status.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If lsv_Catalogo.Items.Count > 0 Then btn_Exportar.Enabled = True
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick, btn_Reimprimir.Click
        Dim frm As New frm_Reporte
        frm.crv.ReportSource = Cn_Reclutamiento.fn_CartasAcceso_GeneraReporte(lsv_Catalogo.SelectedItems(0).Tag)
        frm.Text = "Carta de Acceso"
        frm.ShowDialog()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Dim Frm As New frm_FirmaElectronica
        Frm.Bloquear = True
        Frm.PedirObservaciones = False
        Frm.ShowDialog()

        If Frm.Firma Then
            If Cn_Reclutamiento.fn_CartasAccesoConsulta_ActualizarStatus(lsv_Catalogo.SelectedItems(0).Tag, "C") Then
                'MsgBox("Registro modificado.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If

            If Not Cn_Reclutamiento.fn_CartasAccesoConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value, dtp_FechaHasta.Value, cmb_Status.SelectedValue) Then
                MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            btn_Reimprimir.Enabled = False
            btn_Cancelar.Enabled = False
        Else
            MsgBox("No se validó la autorización.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Cancelar.Enabled = False

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_Reimprimir.Enabled = True
            btn_Cancelar.Enabled = True
            If Not Cn_Reclutamiento.fn_CartasAccesoConsulta_LlenarDetalle(lsv_Detalle, lsv_Catalogo.SelectedItems(0).Tag) Then
                MsgBox("Ha ocurrido un error al intentar cargar el detalle.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            lsv_Detalle.Items.Clear()
            btn_Reimprimir.Enabled = False
            btn_Cancelar.Enabled = False
        End If
    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Datos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class