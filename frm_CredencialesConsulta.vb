Public Class frm_CredencialesConsulta

    Private Sub frm_CredencialesConsulta_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_CredencialesConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Empleado.Actualizar()
        cmb_Status.AgregarItem("A", "PENDIENTE")
        cmb_Status.AgregarItem("E", "ENTREGADA")
        cmb_Status.AgregarItem("C", "CANCELADA")
        cmb_Status.AgregarItem("B", "BAJA")

        cmb_StatusE.AgregarItem("A", "ACTIVO")
        cmb_StatusE.AgregarItem("B", "BAJA")

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("FechaExpide")
        lsv_Catalogo.Columns.Add("FechaExpira")
        lsv_Catalogo.Columns.Add("UsuarioExpide")
        lsv_Catalogo.Columns.Add("Status")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub chk_Empleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Empleados.CheckedChanged
        lsv_Catalogo.Items.Clear()
        Call Validar()
        If chk_Empleados.Checked Then
            cmb_Empleado.Enabled = False
            cmb_Empleado.SelectedValue = 0
        Else
            cmb_Empleado.Enabled = True
        End If
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        lsv_Catalogo.Items.Clear()
        Call Validar()
        If chk_Status.Checked Then
            cmb_Status.Enabled = False
            cmb_Status.SelectedValue = "0"
        Else
            cmb_Status.Enabled = True
        End If
    End Sub

    Private Sub chk_StatusE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_StatusE.CheckedChanged
        lsv_Catalogo.Items.Clear()
        Call Validar()
        If chk_StatusE.Checked Then
            cmb_StatusE.Enabled = False
            cmb_StatusE.SelectedValue = "0"
        Else
            cmb_StatusE.Enabled = True
        End If
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
        btn_Mostrar.Enabled = True
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        End If
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_Empleado_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedIndexChanged
        lsv_Catalogo.Items.Clear()
        btn_Mostrar.Enabled = False
        Call Validar()
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        lsv_Catalogo.Items.Clear()
        btn_Mostrar.Enabled = False
        Call Validar()
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        lsv_Catalogo.Items.Clear()
        btn_Mostrar.Enabled = False
        dtp_FechaHasta.MinDate = dtp_FechaDesde.Value
        Call Validar()
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        lsv_Catalogo.Items.Clear()
        btn_Mostrar.Enabled = False
        dtp_FechaDesde.MaxDate = dtp_FechaHasta.Value
        Call Validar()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        If Not Cn_Reclutamiento.fn_CredencialesConsulta_LlenarLista(lsv_Catalogo, cmb_Empleado.SelectedValue, dtp_FechaDesde.Value, dtp_FechaHasta.Value, cmb_Status.SelectedValue, cmb_StatusE.SelectedValue) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
        If lsv_Catalogo.Items.Count > 0 Then
            btn_Exportar.Enabled = True
        End If
    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        Dim Detalle As New frm_CredencialDetalleImprimirPlant
        Detalle.Id_Credencial = lsv_Catalogo.SelectedItems(0).Tag

        Detalle.ShowDialog()
    End Sub

    Private Sub GroupBox1_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Listado.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Catalogo.MouseMove
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub


    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub


End Class