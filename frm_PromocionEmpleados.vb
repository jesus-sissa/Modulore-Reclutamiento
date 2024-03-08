Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_PromocionEmpleados

    Private Sub frm_PromocionEmpleados_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'AL usar combos en cascada se invierte el orden en el codigo
        cmb_Empleados.AgregaParametro("@Id_Departamento", -1, 1)
        cmb_Empleados.AgregaParametro("@Id_Puesto", -1, 1) 'Se manda -1 para que no traiga ningun dato y el 0 para traer todos
        cmb_Empleados.AgregaParametro("@Status", "A", 0)
        cmb_Empleados.Actualizar()

        lsv_CatPromo.Columns.Add("Fecha")
        lsv_CatPromo.Columns.Add("Empleado")
        lsv_CatPromo.Columns.Add("Departamento Ant")
        lsv_CatPromo.Columns.Add("Puesto Ant")
        lsv_CatPromo.Columns.Add("Sueldo Ant")
        lsv_CatPromo.Columns.Add("Documento Actual")
        lsv_CatPromo.Columns.Add("Puesto Actual")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", -1, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()

        cmb_DepartamentoFiltro.Actualizar()

        'para llenar combos en Datos Nuevos
        cmb_Puesto.AgregaParametro("@Id_Departamento", -1, 1)
        cmb_Puesto.AgregaParametro("@Status", "A", 0)
        cmb_Puesto.Actualizar()

        cmb_Departamento.Actualizar()
    End Sub

#Region "Eventos Privados"

    Private Sub Llenar_cmbEmpleados()
        'Llenar los Empleados en el combo
        If cmb_PuestoFiltro.Items.Count > 0 AndAlso cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_PuestoFiltro.SelectedValue = 0 AndAlso Not chk_PuestoFiltro.Checked Then
                '-1 para que sólo muestre el Seleccione...
                cmb_Empleados.ActualizaValorParametro("@Id_Departamento", -1)
                cmb_Empleados.ActualizaValorParametro("@Id_Puesto", -1)
            ElseIf cmb_PuestoFiltro.SelectedValue = 0 AndAlso chk_PuestoFiltro.Checked Then
                If CInt(cmb_DepartamentoFiltro.SelectedValue) = 0 Then
                    cmb_Empleados.ActualizaValorParametro("@Id_Departamento", -1)
                Else
                    cmb_Empleados.ActualizaValorParametro("@Id_Departamento", CInt(cmb_DepartamentoFiltro.SelectedValue))
                End If
                cmb_Empleados.ActualizaValorParametro("@Id_Puesto", 0) '0 para que muestre todos los empleados según el departamento
            ElseIf cmb_PuestoFiltro.SelectedValue <> 0 Then
                cmb_Empleados.ActualizaValorParametro("@Id_Departamento", CInt(cmb_DepartamentoFiltro.SelectedValue))
                cmb_Empleados.ActualizaValorParametro("@Id_Puesto", cmb_PuestoFiltro.SelectedValue)
            End If
            cmb_Empleados.Actualizar()
        End If
    End Sub

    Private Sub LlenarLista()
        FuncionesGlobales.fn_NumRegistros(lbl_Total, lsv_CatPromo.Items.Count)
        ' Aqui llena la lista de  la tabla cat_promociones
        If Not Cn_Reclutamiento.fn_EmpleadosPromo_LlenarLista(lsv_CatPromo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, cmb_Empleados.SelectedValue) Then
            MsgBox("Ocurrió un error al intentar mostrar el Catálogo de EmpleadosPromociones.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.fn_NumRegistros(lbl_Total, lsv_CatPromo.Items.Count)

        Dim Dr_Empleado As DataRow = fn_Empleados_ObtenValores(cmb_Empleados.SelectedValue)

        If Dr_Empleado IsNot Nothing Then
            tbx_DepartamentoA.Text = Dr_Empleado("Departamento")
            tbx_DepartamentoA.Tag = Dr_Empleado("Id_Departamento") 'almacena valor tag
            tbx_PuestoA.Text = Dr_Empleado("Puesto")
            tbx_PuestoA.Tag = Dr_Empleado("Id_Puesto") 'almacena valor tag
            tbx_SueldoDiarioA.Text = Dr_Empleado("SueldoBase")

            If Dr_Empleado("SaleRuta") = "N" Then
                rdb_No_SaleaRuta.Checked = True
            Else
                rdb_Si_SaleaRuta.Checked = True
            End If

            If Dr_Empleado("VerificaServicios") = "N" Then
                rdb_No_VerificaServicio.Checked = True
            Else
                rdb_Si_VerificaServicio.Checked = True
            End If
        Else
            MsgBox("Ocurrio un error al mostrar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Limpiar()
        lsv_CatPromo.Items.Clear()
        FuncionesGlobales.fn_NumRegistros(lbl_Total, lsv_CatPromo.Items.Count)
        btn_Cancelar.Enabled = False

        tbx_DepartamentoA.Clear()
        tbx_DepartamentoA.Tag = Nothing
        tbx_PuestoA.Clear()
        tbx_PuestoA.Tag = Nothing
        tbx_SueldoDiarioA.Clear()
        rdb_Si_SaleaRuta.Checked = False
        rdb_No_SaleaRuta.Checked = False
        rdb_Si_VerificaServicio.Checked = False
        rdb_No_VerificaServicio.Checked = False

        cmb_Departamento.SelectedValue = 0
        tbx_SueldoDiarioN.Clear()
        rdb_Si_SaleaRutaN.Checked = False
        rdb_No_SaleaRutaN.Checked = False
        rdb_Si_VerificaServicioN.Checked = False
        rdb_No_VerificaServicioN.Checked = False
    End Sub

#End Region

    Private Sub cmb_DepartamentoFiltro_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_DepartamentoFiltro.KeyPress
        SegundosDesconexion = 0
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_PuestoFiltro.Enabled Then
                cmb_PuestoFiltro.Focus()
            Else
                cmb_Empleados.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedValueChanged
        SegundosDesconexion = 0
        'Llenar los Puestos
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
            Call Llenar_cmbEmpleados()
        End If
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedValueChanged
        SegundosDesconexion = 0

        Call LLenar_cmbEmpleados()
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        SegundosDesconexion = 0

        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
        Call Llenar_cmbEmpleados()
    End Sub

    Private Sub cmb_Empleados_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleados.SelectedValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        If cmb_DepartamentoFiltro.SelectedValue = 0 Then Exit Sub
        If cmb_PuestoFiltro.SelectedValue = 0 AndAlso Not chk_PuestoFiltro.Checked Then Exit Sub
        If cmb_Empleados.SelectedValue = 0 Then Exit Sub
        Call LlenarLista()
    End Sub
    Private Sub cmb_Departamento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Departamento.SelectedValueChanged
        SegundosDesconexion = 0
        'Llenar los Puestos

        If cmb_Departamento.Items.Count > 0 Then
            If cmb_Departamento.SelectedValue = 0 Then
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", -1) ' se pone la cadena Seleccione...
            Else
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", cmb_Departamento.SelectedValue)
            End If
            cmb_Puesto.Actualizar()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_DepartamentoA.Text = "" Then
            MsgBox("Seleccione un Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleados.Focus()
            Exit Sub
        End If
        If (tbx_DepartamentoA.Text = cmb_Departamento.Text) And (tbx_PuestoA.Text = cmb_Puesto.Text) Then
            MsgBox("El Departamento y Puesto Es el Actual - Asigne Otro Diferente.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Departamento.SelectedValue = 0
            cmb_Departamento.Focus()
            Exit Sub
        End If

        If cmb_Departamento.SelectedValue = 0 Then
            MsgBox("Indique el Nuevo Departamento a Promover.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Departamento.Focus()
            Exit Sub
        End If
        If cmb_Puesto.SelectedValue = 0 Then
            MsgBox("Indique el Nuevo Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Puesto.Focus()
            Exit Sub
        End If
        If tbx_SueldoDiarioN.Text = "" Then
            MsgBox("Indique el Sueldo Diario.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_SueldoDiarioN.Focus()
            Exit Sub
        End If
        If Not rdb_Si_SaleaRutaN.Checked And Not rdb_No_SaleaRutaN.Checked Then
            MsgBox("Indique SiSale a Ruta .", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_SaleaRutaN.Focus()
            Exit Sub
        End If
        If Not rdb_Si_VerificaServicioN.Checked And Not rdb_No_VerificaServicioN.Checked Then
            MsgBox("Indique Si Verifica Servicios .", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_SaleaRutaN.Focus()
            Exit Sub
        End If

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.Max_Caracteres_Obs = 300
        frm.ShowDialog()

        If Not frm.Firma Then Exit Sub

        Dim SalearutaA As String
        Dim VerificaservicioA As String
        Dim SalearutaN As String
        Dim VerificaservicioN As String

        If rdb_Si_SaleaRuta.Checked Then SalearutaA = "S" Else SalearutaA = "N"
        If rdb_Si_VerificaServicio.Checked Then VerificaservicioA = "S" Else VerificaservicioA = "N" 'rtb_ObservacionesA.Text,

        If rdb_Si_SaleaRutaN.Checked Then SalearutaN = "S" Else SalearutaN = "N"
        If rdb_Si_VerificaServicioN.Checked Then VerificaservicioN = "S" Else VerificaservicioN = "N"
        Dim Id_Empleado As Integer = cmb_Empleados.SelectedValue
        If fn_EmpleadosPromo_Guardar(Id_Empleado, tbx_DepartamentoA.Tag, tbx_PuestoA.Tag, tbx_SueldoDiarioA.Text, _
                                     SalearutaA, VerificaservicioA, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, _
                                     tbx_SueldoDiarioN.Text, SalearutaN, VerificaservicioN, frm.Observaciones, "A") Then
            Dim Puesto As Integer = cmb_Puesto.SelectedValue
            cmb_DepartamentoFiltro.SelectedValue = cmb_Departamento.SelectedValue
            cmb_PuestoFiltro.SelectedValue = Puesto
            cmb_Empleados.SelectedValue = Id_Empleado
            MsgBox("Datos Guardados Corerctamente", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            MsgBox("Ocurrió un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub rtb_ObservacionesN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.Max_Caracteres_Obs = 300
        frm.ShowDialog()

        If frm.Firma Then
            If fn_EmpleadosPromo_Cancela(lsv_CatPromo.SelectedItems(0).Tag, frm.Observaciones) Then
                Dim Dr_Empleado As DataRow = fn_Empleados_ObtenValores(cmb_Empleados.SelectedValue)
                If Dr_Empleado IsNot Nothing Then
                    cmb_DepartamentoFiltro.SelectedValue = Dr_Empleado("Id_Departamento")
                    cmb_PuestoFiltro.SelectedValue = Dr_Empleado("Id_Puesto")
                    cmb_Empleados.SelectedValue = Dr_Empleado("Id_Empleado")
                Else
                    cmb_DepartamentoFiltro.SelectedValue = 0
                End If
                MsgBox("Datos Cancelados Correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Hubo un Error en la Operación", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        'Aqui se cierra la ventana
        Me.Close()
    End Sub

    Private Sub lsv_CatPromo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_CatPromo.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Cancelar.Enabled = False
        If lsv_CatPromo.SelectedItems.Count > 0 AndAlso _
        lsv_CatPromo.SelectedItems(0).SubItems(8).Text <> "CANCELADO" AndAlso _
        ((lsv_CatPromo.SelectedItems(0).SubItems(5).Text = tbx_DepartamentoA.Text.Trim) _
         AndAlso (lsv_CatPromo.SelectedItems(0).SubItems(6).Text = tbx_PuestoA.Text.Trim)) Then
            btn_Cancelar.Enabled = True
        End If
    End Sub

End Class