Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales
Public Class frm_ReporteGeneral

    Private Sub frm_ReporteGeneral_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0
        Lsv_Lista.Columns.Add("EmpleadoId")
        Lsv_Lista.Columns.Add("Sucursal")
        Lsv_Lista.Columns.Add("Num Nomina")
        Lsv_Lista.Columns.Add("Nombre Completo")
        Lsv_Lista.Columns.Add("Nombre")
        Lsv_Lista.Columns.Add("A. Paterno")
        Lsv_Lista.Columns.Add("A. Materno")
        Lsv_Lista.Columns.Add("Sexo")
        Lsv_Lista.Columns.Add("Fecha Ingreso")
        Lsv_Lista.Columns.Add("Mail Empresa")
        Lsv_Lista.Columns.Add("Mail Personal")
        Lsv_Lista.Columns.Add("Fecha Nacimiento")
        Lsv_Lista.Columns.Add("Modo Nacionalidad")
        Lsv_Lista.Columns.Add("Pais Nacimiento")
        Lsv_Lista.Columns.Add("Fecha Naturalizacion")

        Cmb_Status.AgregarItem("A", "ACTIVOS")
        Cmb_Status.AgregarItem("B", "BAJAS")

        Cmb_Departamentos.AgregaParametro("@Status", "A", 0)
        Cmb_Departamentos.Actualizar()

        Cmb_Puesto.AgregaParametro("@Id_Departamento", -1, 1)
        Cmb_Puesto.AgregaParametro("@Status", "A", 0)
        Cmb_Puesto.Actualizar()

    End Sub

    Private Sub LlenarLista()
        SegundosDesconexion = 0
        If Cmb_Departamentos.SelectedIndex = 0 And Chk_Departamento.Checked = False Then
            MsgBox("Seleccione un Departamento o Marque Todos", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Departamentos.Focus()
            Exit Sub
        End If
        If Cmb_Puesto.SelectedIndex = 0 And Chk_Puesto.Checked = False Then
            MsgBox("Seleccione un Puesto o Marque Todos", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Puesto.Focus()
            Exit Sub
        End If
        If Cmb_Status.SelectedIndex = 0 And Chk_Status.Checked = False Then
            MsgBox("Seleccione un Status o Marque Todos", MsgBoxStyle.Critical, frm_MENU.Text)
            Cmb_Status.Focus()
            Exit Sub
        End If
        If Dtp_Desde.Value.Date > Dtp_Hasta.Value.Date Then
            MsgBox("Las Fechas son Incorrectas", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If
        If fn_ReporteGeneral_LlenarLista(Lsv_Lista, IIf(Chk_Departamento.Checked, 0, Cmb_Departamentos.SelectedValue), IIf(Chk_Status.Checked, "T", Cmb_Status.SelectedValue), IIf(Chk_Puesto.Checked, 0, Cmb_Puesto.SelectedValue), Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date, IIf(Chk_Fecha.Checked, "N", "S")) = False Then
            MsgBox("Error al Cargar los Registros", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        btn_Exportar.Enabled = True
        lbl_total.Text = "Registros: " & Lsv_Lista.Items.Count
        If Chk_Status.Checked Then
            For Each Linea As ListViewItem In Lsv_Lista.Items
                If Linea.SubItems(Lsv_Lista.Columns.Count - 1).Text = "BAJA" Then
                    Linea.BackColor = Color.LightCoral
                Else
                    Linea.BackColor = Color.White
                End If
            Next
        End If
    End Sub

    Private Sub Btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        fn_Exportar_Excel(Lsv_Lista, 0, "Reporte General" & Today.Date, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub Btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Mostrar.Click
        SegundosDesconexion = 0
        Call LlenarLista()
    End Sub

    Private Sub Chk_Departamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Departamento.CheckedChanged
        SegundosDesconexion = 0
        Cmb_Departamentos.SelectedIndex = 0
        Cmb_Departamentos.Enabled = (Chk_Departamento.Checked = False)
    End Sub

    Private Sub Chk_Puesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Puesto.CheckedChanged
        SegundosDesconexion = 0
        Cmb_Puesto.SelectedIndex = 0
        Cmb_Puesto.Enabled = (Chk_Puesto.Checked = False)
    End Sub

    Private Sub Chk_Fecha_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Fecha.CheckedChanged
        SegundosDesconexion = 0
        Dtp_Desde.Value = Today
        Dtp_Hasta.Value = Today
        Dtp_Desde.Enabled = (Chk_Fecha.Checked = False)
        Dtp_Hasta.Enabled = (Chk_Fecha.Checked = False)
    End Sub

    Private Sub Lsv_Lista_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Lsv_Lista.SelectedIndexChanged
        SegundosDesconexion = 0
        If Lsv_Lista.Items.Count > 0 Then
            btn_Exportar.Enabled = True
        Else
            btn_Exportar.Enabled = False
        End If
    End Sub

    Private Sub Chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Status.CheckedChanged
        SegundosDesconexion = 0
        Cmb_Status.SelectedIndex = 0
        Cmb_Status.Enabled = (Chk_Status.Checked = False)
    End Sub

    Private Sub cmb_Departamentos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Departamentos.SelectedIndexChanged
        Lsv_Lista.Items.Clear()
        If cmb_Departamentos.Items.Count > 0 Then
            If cmb_Departamentos.SelectedValue = 0 Then
                Cmb_Puesto.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                Cmb_Puesto.ActualizaValorParametro("@Id_Departamento", cmb_Departamentos.SelectedValue)
            End If
            Cmb_Puesto.Actualizar()
        End If
    End Sub

    Private Sub Cmb_Puesto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Puesto.SelectedIndexChanged
        Lsv_Lista.Items.Clear()
    End Sub

    Private Sub Cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Status.SelectedIndexChanged
        Lsv_Lista.Items.Clear()
    End Sub

    Private Sub Dtp_Desde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Desde.ValueChanged
        Lsv_Lista.Items.Clear()
    End Sub

    Private Sub Dtp_Hasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Dtp_Hasta.ValueChanged
        Lsv_Lista.Items.Clear()
    End Sub
End Class