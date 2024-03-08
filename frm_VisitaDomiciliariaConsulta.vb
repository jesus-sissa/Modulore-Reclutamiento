Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales

Public Class frm_VisitaDomiciliariaConsulta

    Private Tipo As Integer

    Private Sub frm_VisitaDomiciliariaConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        'Listado sobre la consulta de las visitas
        lsv_ListadoConsulta.Columns.Add("Fecha")
        lsv_ListadoConsulta.Columns.Add("Hora")
        lsv_ListadoConsulta.Columns.Add("Clave")
        lsv_ListadoConsulta.Columns.Add("Nombre")
        lsv_ListadoConsulta.Columns.Add("EmpleadoVisita")

        cmb_Empleado.Actualizar()
        dtp_FechaDesde.Value = Today.Date
        dtp_FechaHasta.Value = Today.Date
    End Sub

    Sub Botones()
        btn_Exportar.Enabled = lsv_ListadoConsulta.Items.Count > 0
        btn_Visitas.Enabled = lsv_ListadoConsulta.SelectedItems.Count > 0
        btn_Importar.Enabled = lsv_ListadoConsulta.SelectedItems.Count > 0
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_ListadoConsulta.Items.Count)
    End Sub

#Region "Consulta"

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        SegundosDesconexion = 0

        lsv_ListadoConsulta.Items.Clear()
        Call Botones()
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        SegundosDesconexion = 0

        lsv_ListadoConsulta.Items.Clear()
        Call Botones()
    End Sub

    Private Sub rdb_Empleados_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Empleados.CheckedChanged
        SegundosDesconexion = 0
        lsv_ListadoConsulta.Items.Clear()

        'Tipo = 1 si es Empleado o Tipo = 2 si es Prospecto
        If rdb_Empleados.Checked Then
            cmb_Empleado.DataSource = Nothing
            cmb_Empleado.StoredProcedure = "Cat_EmpleadosCombo_GetTodos"
            cmb_Empleado.ValueMember = "Id_Empleado"
            cmb_Empleado.DisplayMember = "Nombre"
            cmb_Empleado.Clave = "Clave"
            cmb_Empleado.Sucursal = True
            cmb_Empleado.Empresa = False
            cmb_Empleado.Pista = False
            cmb_Empleado.Tipo = 0
            cmb_Empleado.Actualizar()
            lbl_Empleado.Text = "Empleado"
            Tipo = 1
        Else
            cmb_Empleado.DataSource = Nothing
            cmb_Empleado.StoredProcedure = "Cat_EmpleadosPCombo_GetTodos"
            cmb_Empleado.ValueMember = "Id_EmpleadoP"
            cmb_Empleado.DisplayMember = "Nombre"
            cmb_Empleado.Clave = "Clave"
            cmb_Empleado.Sucursal = True
            cmb_Empleado.Empresa = False
            cmb_Empleado.Pista = False
            cmb_Empleado.Tipo = 0
            cmb_Empleado.Actualizar()
            lbl_Empleado.Text = "Prospecto"
            Tipo = 2
        End If
        Call Botones()
    End Sub

    Private Sub cmb_Empleado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_ListadoConsulta.Items.Clear()
        Call Botones()
    End Sub

    Private Sub chk_Empleado_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Empleado.CheckedChanged
        SegundosDesconexion = 0

        lsv_ListadoConsulta.Items.Clear()
        cmb_Empleado.SelectedValue = 0
        cmb_Empleado.Enabled = Not chk_Empleado.Checked
        tbx_Clave.Enabled = Not chk_Empleado.Checked
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor

        If dtp_FechaHasta.Value.Date < dtp_FechaDesde.Value.Date Then
            Me.Cursor = Cursors.Default
            MsgBox("La Fecha Hasta debe ser mayor a la Fecha Desde.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaHasta.Focus()
            Exit Sub
        End If

        If rdb_Empleados.Checked = False And rdb_Prospectos.Checked = False Then
            Me.Cursor = Cursors.Default
            MsgBox("Seleccione si es Prospecto o Empleado para realizar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            btn_Mostrar.Focus()
            Exit Sub
        End If

        If cmb_Empleado.SelectedValue = 0 And chk_Empleado.Checked = False Then
            Me.Cursor = Cursors.Default
            MsgBox("Tiene que seleccionar un " & lbl_Empleado.Text & " para realizar la consulta", MsgBoxStyle.Critical, frm_MENU.Text)
            btn_Mostrar.Focus()
            Exit Sub
        End If

        'Llenar la Lista
        'Tipo = 1 si es Empleado o Tipo = 2 si es Prospecto
        lsv_ListadoConsulta.Items.Clear()
        If Not fn_VisitaDomiciliaria_LlenarLista(lsv_ListadoConsulta, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, Tipo, cmb_Empleado.SelectedValue) Then
            Me.Cursor = Cursors.Default
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call Botones()
        Me.Cursor = Cursors.Default
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_ListadoConsulta.Items.Count)
    End Sub

    Private Sub lsv_ListadoConsulta_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_ListadoConsulta.SelectedIndexChanged
        SegundosDesconexion = 0
        Call Botones()
    End Sub

#End Region

#Region "Controles"

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        fn_Exportar_Excel(lsv_ListadoConsulta, 2, Me.Text, 0, 2, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Visitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Visitas.Click
        SegundosDesconexion = 0

        'Mostrar la información desglozada (usando la ventana de frm_visitasdomiciliarias)
        Dim frm As New frm_VisitaDomiciliaria
        If Tipo = 1 Then
            'Dado a que en la consulta se envia en la misma columna el resultado
            frm.Id_Empleado = lsv_ListadoConsulta.SelectedItems(0).SubItems(5).Text
        ElseIf Tipo = 2 Then
            'Dado a que en la consulta se envia en la misma columna el resultado
            frm.Id_EmpleadoP = lsv_ListadoConsulta.SelectedItems(0).SubItems(5).Text
        End If
        frm.Clave = lsv_ListadoConsulta.SelectedItems(0).SubItems(2).Text
        frm.Nombre = lsv_ListadoConsulta.SelectedItems(0).SubItems(3).Text
        frm.ShowDialog()
    End Sub

    Private Sub btn_Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm.MaxArchivos = 6
        frm.Id_Tabla = lsv_ListadoConsulta.SelectedItems(0).Tag
        frm.Tipo = frm_CargarArchivos.Query.VisitasDomiciliarias
        frm.DescripcionEnable = True
        frm.ShowDialog()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

#End Region

    Private Sub dtp_FechaDesde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaDesde.KeyPress
        If Asc(e.KeyChar) = 13 Then dtp_FechaHasta.Focus()
    End Sub

    Private Sub dtp_FechaHasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaHasta.KeyPress
        If Asc(e.KeyChar) = 13 Then rdb_Empleados.Focus()
    End Sub


    Private Sub rdb_Empleados_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Empleados.KeyPress
        If Asc(e.KeyChar) = 13 Then rdb_Prospectos.Focus()
    End Sub


    Private Sub rdb_Prospectos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rdb_Prospectos.KeyPress
        If Asc(e.KeyChar) = 13 Then
            If cmb_Empleado.Enabled Then
                cmb_Empleado.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_Empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedIndexChanged

    End Sub
End Class