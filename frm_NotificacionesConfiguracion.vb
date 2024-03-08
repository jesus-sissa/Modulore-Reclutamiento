Public Class frm_NotificacionesConfiguracion

    Dim Encab As String

    Private Sub frm_NotificacionesConfiguracion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Puestos.Columns.Add("Clave")
        lsv_Puestos.Columns.Add("Descripción")

        lsv_Departamentos.Columns.Add("Clave")
        lsv_Departamentos.Columns.Add("Descripción")

        'lsv_EmpleadosNotifica.Columns.Add("Clave")
        lsv_EmpleadosNotifica.Columns.Add("Departamento")
        lsv_EmpleadosNotifica.Columns(0).Width = 250


        LlenarListaPuestos()
        LlenarListaDeptos()

        Encab = tbx_Encabezado.Text

    End Sub

    Sub LlenarListaPuestos()
        Cn_Reclutamiento.fn_ConfiguracionNotificaciones_LlenarListaPuestos(lsv_Puestos)
    End Sub

    Sub LlenarListaDeptos()
        Cn_Reclutamiento.fn_ConfiguracionNotificaciones_LlenarListaDepartamentos(lsv_Departamentos)
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

        If lsv_Puestos.SelectedItems.Count = 0 Then
            MsgBox("Debe seleccionar un Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Puestos.Focus()
            Exit Sub
        End If

        If lsv_Departamentos.CheckedItems.Count = 0 Then
            MsgBox("Debe seleccionar por lo menos un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            lsv_Departamentos.Focus()
            Exit Sub
        End If

        For Each Depto As ListViewItem In lsv_Departamentos.CheckedItems
            For Each elemento As ListViewItem In lsv_EmpleadosNotifica.Items
                If Depto.SubItems(1).Text = elemento.SubItems(0).Text Then Depto.Checked = False
            Next
        Next

        Dim IdPuesto As Integer = lsv_Puestos.SelectedItems(0).Tag
        If Not Cn_Reclutamiento.fn_ConfiguracionNotificaciones_Guardar(IdPuesto, lsv_Departamentos) Then
            MsgBox("No se pudo agregar la nueva Configuración de Notificación.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            'MsgBox("Los datos han sido guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        LlenarListaDeptos()
        Cn_Reclutamiento.fn_ConfiguracionNotificaciones_LlenarListaDepNotificar(lsv_EmpleadosNotifica, lsv_Puestos.SelectedItems(0).Tag)

    End Sub

    Private Sub lsv_Puestos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puestos.SelectedIndexChanged

        If lsv_Puestos.SelectedItems.Count = 0 Then Exit Sub
        tbx_Encabezado.Clear()
        tbx_Encabezado.Text = Encab & " " & lsv_Puestos.SelectedItems(0).SubItems(1).Text
        Cn_Reclutamiento.fn_ConfiguracionNotificaciones_LlenarListaDepNotificar(lsv_EmpleadosNotifica, lsv_Puestos.SelectedItems(0).Tag)

    End Sub

    Private Sub btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Quitar.Click

        If lsv_EmpleadosNotifica.CheckedItems.Count = 0 Then Exit Sub

        If Not Cn_Reclutamiento.fn_ConfiguracionNotificaciones_Borrar(lsv_EmpleadosNotifica) Then
            MsgBox("No se pudo actualizar la Configuración de Notificación.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            'MsgBox("Los datos han sido actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If

        LlenarListaDeptos()
        Cn_Reclutamiento.fn_ConfiguracionNotificaciones_LlenarListaDepNotificar(lsv_EmpleadosNotifica, lsv_Puestos.SelectedItems(0).Tag)

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Puestos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puestos.MouseHover, lsv_Departamentos.MouseHover, lsv_EmpleadosNotifica.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class