
Public Class frm_Investigacion_Laboral

    Public Id As Integer = 0
    Public IdEmp As Integer = 0
    Public Nombre As String
    Public Candidato As String
    Public Referencia As String
    Public Telefono As String
    Private stat As String
    Public EmpOrPros As String
    Dim datos As DataRow = Nothing
    Private Sub frm_InvestigacionLaboral_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_candidato.Text = Candidato
        lbl_Referencia.Text = Referencia
        lbl_Telefono.Text = Telefono
        If EmpOrPros = "E" Then
            lbl_cand.Text = "Empleado"
        End If


        cmb_Desempeño.AgregarItem("NA", "N/A")
        cmb_Desempeño.AgregarItem("EX", "Excelente")
        cmb_Desempeño.AgregarItem("BU", "Bueno")
        cmb_Desempeño.AgregarItem("RE", "Regular")
        cmb_Desempeño.AgregarItem("MA", "Malo")

        cmb_Conducta.AgregarItem("NA", "N/A")
        cmb_Conducta.AgregarItem("EX", "Excelente")
        cmb_Conducta.AgregarItem("BU", "Buena")
        cmb_Conducta.AgregarItem("RE", "Regular")
        cmb_Conducta.AgregarItem("MA", "Mala")

        cmb_Puntualidad.AgregarItem("NA", "N/A")
        cmb_Puntualidad.AgregarItem("BU", "Buena")
        cmb_Puntualidad.AgregarItem("MA", "Mala")

        cmb_Honestidad.AgregarItem("NA", "N/A")
        cmb_Honestidad.AgregarItem("S", "SI")
        cmb_Honestidad.AgregarItem("N", "NO")

        cmb_Actitud.AgregarItem("NA", "N/A")
        cmb_Actitud.AgregarItem("EX", "Excelente")
        cmb_Actitud.AgregarItem("BU", "Buena")
        cmb_Actitud.AgregarItem("RE", "Regular")
        cmb_Actitud.AgregarItem("MA", "Mala")

        cmb_Asistencia.AgregarItem("NA", "N/A")
        cmb_Asistencia.AgregarItem("BU", "Buena")
        cmb_Asistencia.AgregarItem("MA", "Mala")

        cmb_Disponibilidad.AgregarItem("NA", "N/A")
        cmb_Disponibilidad.AgregarItem("S", "SI")
        cmb_Disponibilidad.AgregarItem("N", "NO")

        cmb_Demando.AgregarItem("NA", "N/A")
        cmb_Demando.AgregarItem("S", "SI")
        cmb_Demando.AgregarItem("N", "NO")

        cmb_PertenecioSindicato.AgregarItem("NA", "N/A")
        cmb_PertenecioSindicato.AgregarItem("S", "SI")
        cmb_PertenecioSindicato.AgregarItem("N", "NO")

        cmb_DelegadoSindical.AgregarItem("NA", "N/A")
        cmb_DelegadoSindical.AgregarItem("S", "SI")
        cmb_DelegadoSindical.AgregarItem("N", "NO")

        cmb_Recomendable.AgregarItem("NA", "N/A")
        cmb_Recomendable.AgregarItem("S", "SI")
        cmb_Recomendable.AgregarItem("N", "NO")


        cmb_MotivoSalida.AgregaParametro("@Tipo", 2, 1)
        cmb_MotivoSalida.Actualizar()

        If EmpOrPros = "P" Then
            datos = Cn_Reclutamiento.fn_Consulta_ReferenciaLaboralP(Id)
        Else
            datos = Cn_Reclutamiento.fn_Consulta_ReferenciaLaboral(Id)
        End If


        If Not datos Is Nothing Then
            stat = "UP"
            btn_Guardar.Text = "Actualizar"
            cmb_Desempeño.SelectedValue = datos("Desempeño")
            cmb_Conducta.SelectedValue = datos("Conducta")
            cmb_Puntualidad.SelectedValue = datos("Puntualidad")
            cmb_Honestidad.SelectedValue = datos("Honestidad")
            cmb_Actitud.SelectedValue = datos("Actitud")
            cmb_Asistencia.SelectedValue = datos("Asistencia")
            cmb_Disponibilidad.SelectedValue = datos("Disponibilidad")
            cmb_MotivoSalida.SelectedValue = datos("Motivo_Salida")
            cmb_Demando.SelectedValue = datos("Demando")
            cmb_PertenecioSindicato.SelectedValue = datos("PertenecioSindicato")
            tbx_Acual.Text = datos("Cual").ToString()
            cmb_DelegadoSindical.SelectedValue = datos("FueDelegadoSindical")
            cmb_Recomendable.SelectedValue = datos("Recomendable")
            tbx_porque.Text = datos("Porque").ToString()
        Else
            stat = "SV"
        End If




    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        'prospecto
        If EmpOrPros = "P" Then
            'guardar
            If stat = "SV" Then

                If Cn_Reclutamiento.fn_GuardarReferenciaLaboralP(Id, IdEmp, cmb_Desempeño.SelectedValue, cmb_Conducta.SelectedValue, cmb_Puntualidad.SelectedValue,
                                                                 cmb_Honestidad.SelectedValue, cmb_Actitud.SelectedValue, cmb_Asistencia.SelectedValue,
                                                                  cmb_Disponibilidad.SelectedValue, cmb_MotivoSalida.SelectedValue, cmb_Demando.SelectedValue,
                                                                   cmb_PertenecioSindicato.SelectedValue, tbx_Acual.Text, cmb_DelegadoSindical.SelectedValue,
                                                                    cmb_Recomendable.SelectedValue, tbx_porque.Text) Then
                    stat = "UP"
                    btn_Guardar.Text = "Actualizar"
                    MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If

            Else 'actualizar
                If Cn_Reclutamiento.fn_ActualizarReferenciaLaboralP(Id, IdEmp, cmb_Desempeño.SelectedValue, cmb_Conducta.SelectedValue, cmb_Puntualidad.SelectedValue,
                                                               cmb_Honestidad.SelectedValue, cmb_Actitud.SelectedValue, cmb_Asistencia.SelectedValue,
                                                                cmb_Disponibilidad.SelectedValue, cmb_MotivoSalida.SelectedValue, cmb_Demando.SelectedValue,
                                                                 cmb_PertenecioSindicato.SelectedValue, tbx_Acual.Text, cmb_DelegadoSindical.SelectedValue,
                                                                  cmb_Recomendable.SelectedValue, tbx_porque.Text) Then

                    MsgBox("Datos Actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            End If

        Else 'empleado
            'guardar
            If stat = "SV" Then
                If Cn_Reclutamiento.fn_GuardarReferenciaLaboral(Id, IdEmp, cmb_Desempeño.SelectedValue, cmb_Conducta.SelectedValue, cmb_Puntualidad.SelectedValue,
                                                                cmb_Honestidad.SelectedValue, cmb_Actitud.SelectedValue, cmb_Asistencia.SelectedValue,
                                                                 cmb_Disponibilidad.SelectedValue, cmb_MotivoSalida.SelectedValue, cmb_Demando.SelectedValue,
                                                                  cmb_PertenecioSindicato.SelectedValue, tbx_Acual.Text, cmb_DelegadoSindical.SelectedValue,
                                                                   cmb_Recomendable.SelectedValue, tbx_porque.Text) Then
                    stat = "UP"
                    btn_Guardar.Text = "Actualizar"
                    MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            Else 'actualizar
                If Cn_Reclutamiento.fn_ActualizarReferenciaLaboral(Id, IdEmp, cmb_Desempeño.SelectedValue, cmb_Conducta.SelectedValue, cmb_Puntualidad.SelectedValue,
                                                              cmb_Honestidad.SelectedValue, cmb_Actitud.SelectedValue, cmb_Asistencia.SelectedValue,
                                                               cmb_Disponibilidad.SelectedValue, cmb_MotivoSalida.SelectedValue, cmb_Demando.SelectedValue,
                                                                cmb_PertenecioSindicato.SelectedValue, tbx_Acual.Text, cmb_DelegadoSindical.SelectedValue,
                                                                 cmb_Recomendable.SelectedValue, tbx_porque.Text) Then

                    MsgBox("Datos Actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            End If

        End If

    End Sub
End Class