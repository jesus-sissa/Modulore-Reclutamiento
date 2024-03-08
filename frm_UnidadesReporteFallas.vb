Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_UnidadesReporteFallas

    Private Sub frm_ReporteFallasUnidades_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp_FechaReporte.Value = Now.Date
        dtp_HoraReporte.Value = Now
        cmb_Unidad.AgregaParametro("@Id_Cia", CiaId, 1)
        'cmb_Unidad.AgregaParametro("@Id_Departamento", DepartamentoId, 1) '12/05/2014
        cmb_Unidad.AgregaParametro("@Status", "A", 0)
        cmb_Unidad.Actualizar()
        cmb_UsuarioReporta.Actualizar()
        cmb_Falla.AgregaParametro("@Id_Parte", -1, 1)
        cmb_Falla.Actualizar()
        cmb_Parte.Actualizar()
    End Sub

    Private Sub dtp_FechaReporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaReporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_HoraReporte.Focus()
    End Sub

    Private Sub dtp_HoraReporte_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraReporte.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then tbx_UsuarioReporta.Focus()
    End Sub

    Private Sub cmb_Parte_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Parte.SelectedValueChanged
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If cmb_Parte.Items.Count > 0 Then
            If cmb_Parte.SelectedValue = 0 Then
                cmb_Falla.ActualizaValorParametro("@Id_Parte", -1)
            Else
                cmb_Falla.ActualizaValorParametro("@Id_Parte", cmb_Parte.SelectedValue)
            End If
            cmb_Falla.Actualizar()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0

        If cmb_Unidad.SelectedValue = 0 Then
            MsgBox("Seleccione la Unidad que presenta la falla.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Unidad.Focus()
            Exit Sub
        End If
        If dtp_FechaReporte.Value.Date > Now.Date Then
            MsgBox("La Fecha parece ser incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaReporte.Focus()
            Exit Sub
        End If
        If cmb_UsuarioReporta.SelectedValue = 0 Then
            MsgBox("Seleccione el Usuario que Reporta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UsuarioReporta.Focus()
            Exit Sub
        End If

        If cmb_Parte.SelectedValue = 0 Then
            MsgBox("Seleccione la Parte que falla.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Parte.Focus()
            Exit Sub
        End If

        If cmb_Falla.SelectedValue = 0 Then
            MsgBox("Seleccione la Falla.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Falla.Focus()
            Exit Sub
        End If

        If Len(tbx_Observaciones.Text) < 10 Then
            MsgBox("Las Observaciones del Reporte deben ser mas explícitas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Observaciones.Focus()
            Exit Sub
        End If

        'Guardar CAPTURA de Reporte de Falla de Unidad SIN Atención
        If fn_UnidadesReporteFallas_NuevoSinAtender(cmb_Unidad.SelectedValue, dtp_FechaReporte.Value.Date, dtp_HoraReporte.Value.TimeOfDay.ToString, cmb_UsuarioReporta.SelectedValue, cmb_Falla.SelectedValue, tbx_Observaciones.Text, cmb_Unidad.Text) Then

            Dim Detalle As String = "            Sucursal:" & SucursalN & Chr(13) _
                                    & "            Unidad:" & tbx_Unidad.Text & " (" & cmb_Unidad.Text & ")" & Chr(13) _
                                    & " Fecha del Reporte:" & dtp_FechaReporte.Value.Date & " - " & dtp_HoraReporte.Text & Chr(13) _
                                    & "   Usuario Reporta:" & tbx_UsuarioReporta.Text & " - " & cmb_UsuarioReporta.Text & Chr(13) _
                                    & "             Parte:" & cmb_Parte.Text & Chr(13) _
                                    & "             Falla:" & cmb_Falla.Text & Chr(13) _
                                    & "     Observaciones:" & tbx_Observaciones.Text & Chr(13) _
                                    & "    Fecha Registro:" & Now.ToShortDateString & " - " & Now.ToShortTimeString

            Dim DetalleHTML As String = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><br><hr /></td></tr>" _
                                        & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Unidad:</b></label></td><td>" & tbx_Unidad.Text & " (" & cmb_Unidad.Text & ")" & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Fecha del Reporte:</b></label></td><td>" & dtp_FechaReporte.Value.Date & " - " & dtp_HoraReporte.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Usuario Reporta:</b></label></td><td>" & tbx_UsuarioReporta.Text & " - " & cmb_UsuarioReporta.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Parte:</b></label></td><td>" & cmb_Parte.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Falla:</b></label></td><td>" & cmb_Falla.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Observaciones:</b></label></td><td>" & tbx_Observaciones.Text & "</td></tr>" _
                                        & "<tr><td align='right'><label><b>Fecha Registro:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "<br></td></tr><tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"

            fn_AlertasGeneradas_Guardar("37", Detalle, Nothing, True, "FALLA EN UNIDAD DE RECLUTAMIENTO", "", DetalleHTML)

            cmb_Unidad.SelectedValue = 0
            dtp_FechaReporte.Value = Now.Date
            dtp_HoraReporte.Value = Now
            cmb_UsuarioReporta.SelectedValue = 0
            cmb_Falla.SelectedValue = 0
            cmb_Parte.SelectedValue = 0
            tbx_Observaciones.Clear()

            MsgBox("El Reporte se guardó correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_Unidad.Focus()
            tbx_Unidad.SelectAll()
        Else
            MsgBox("Ocurrió un error al intentar guardar el Reporte.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class