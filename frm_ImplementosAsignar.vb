
Public Class frm_ImplementosAsignar

    Dim Existencia As Integer = 0
    Dim renglon As ListViewItem
    Dim dt_Implementos As DataTable

    Private Sub frm_ImplementosAsignar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Empleado.AgregaParametro("@Id_Puesto", -1, 1)
        cmb_Empleado.Actualizar()
        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

        lsv_Implementos.Columns.Add("Cantidad")
        lsv_Implementos.Columns.Add("Implemento")
        lsv_Implementos.Columns.Add("Comentarios")
        cmb_Implementos.Actualizar()

        'Aquí se obtienen el inventario de la implementos 
        dt_Implementos = Cn_Reclutamiento.fn_ImplementosInventarios_ObtenValores

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        If tbx_Clave.Text = "" Then
            MsgBox("Capture la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If cmb_Empleado.SelectedValue = 0 Then
            MsgBox("Seleccione el Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Empleado.Focus()
            Exit Sub
        End If

        If cmb_Implementos.SelectedValue = 0 Then
            MsgBox("Seleccione el Implemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Implementos.Focus()
            Exit Sub
        End If

        If tbx_Cantidad.Text = "" Then
            MsgBox("Capture la Cantidad.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        For Each dr As DataRow In dt_Implementos.Rows
            If dr("Id_Implemento") = cmb_Implementos.SelectedValue Then
                If dr("Existencia") >= tbx_Cantidad.Text Then
                    renglon = lsv_Implementos.Items.Add(tbx_Cantidad.Text)
                    renglon.SubItems.Add(cmb_Implementos.Text)
                    renglon.SubItems.Add(tbx_Comentarios.Text)
                    renglon.SubItems.Add(cmb_Implementos.SelectedValue)
                    renglon.SubItems.Add(dr("Id_Inventario"))
                    renglon.SubItems.Add(cmb_Empleado.SelectedValue)

                    tbx_Cantidad.Clear()
                    tbx_Comentarios.Clear()
                    cmb_Implementos.SelectedValue = 0
                    cmb_Implementos.Focus()
                Else
                    'MsgBox("La Existencia es insuficiente.", MsgBoxStyle.Critical, frm_MENU.Text)
                    MsgBox("La Existencia de " & cmb_Implementos.Text & " es insuficiente.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_Cantidad.Focus()
                End If
            End If
        Next
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Borrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar.Click
        Dim Linea As ListViewItem

        If lsv_Implementos.Items.Count > 0 Then
            For Each Linea In lsv_Implementos.CheckedItems
                lsv_Implementos.Items.Remove(Linea)
            Next
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If lsv_Implementos.Items.Count > 0 Then
            dt_Implementos = Cn_Reclutamiento.fn_ImplementosInventarios_ObtenValores

            'Aquí se recorre el listado de Implementos agregados para validar Existencia
            For Each num As ListViewItem In lsv_Implementos.Items
                'Aquí se recorre el datatable con el inventario de todos los Implementos
                For Each dr_Implementos As DataRow In dt_Implementos.Rows

                    If dr_Implementos("Id_Inventario") = num.SubItems(4).Text Then
                        'Cuando coincide el ID del datatable y el del listado
                        If dr_Implementos("Existencia") < num.Text Then

                            MsgBox("La Existencia de " & num.SubItems(2).Text & " es insuficiente.", MsgBoxStyle.Critical, frm_MENU.Text)
                            Exit Sub

                        End If
                    End If
                Next
            Next

            If Cn_Reclutamiento.fn_ImplementosAsignar_Transaccion(lsv_Implementos, cmb_Empleado.SelectedValue) Then
                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                tbx_Clave.Clear()
                cmb_Empleado.SelectedValue = 0
                cmb_Implementos.SelectedValue = 0
                tbx_Cantidad.Clear()
                tbx_Comentarios.Clear()
                lsv_Implementos.Items.Clear()
                tbx_Clave.Focus()
            End If
        Else
            MsgBox("No se han agregado Implementos.", MsgBoxStyle.Information, frm_MENU.Text)
            btn_Agregar.Focus()
        End If
    End Sub

    Private Sub frm_ImplementosAsignar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub lsv_Implementos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Implementos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedIndexChanged
        If cmb_PuestoFiltro.Items.Count > 0 Then

            If cmb_PuestoFiltro.SelectedValue = 0 Then
                cmb_Empleado.ActualizaValorParametro("@Id_Puesto", -1)
            Else
                cmb_Empleado.ActualizaValorParametro("@Id_Puesto", cmb_PuestoFiltro.SelectedValue)
            End If
            cmb_Empleado.Actualizar()

        End If
    End Sub

End Class