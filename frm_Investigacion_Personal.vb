Public Class frm_Investigacion_Personal
    Public Id As Integer = 0
    Public IdEmp As Integer = 0
    Public Nombre As String
    Public Candidato As String
    Public Referencia As String
    Public Telefono As String
    Private stat As String
    Public EmpOrPros As String
    Dim datos As DataRow = Nothing
    Private Sub frm_InvestigacionPersonal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        lbl_candidato.Text = Candidato
        lbl_Referencia.Text = Referencia
        lbl_Telefono.Text = Telefono
        If EmpOrPros = "E" Then
            lbl_cand.Text = "Empleado"
        End If



        'Agregar Valores del Combo Definición de la Persona
        cmb_RefTipoPer.AgregarItem(1, "AGRESIVA")
        cmb_RefTipoPer.AgregarItem(2, "IMPULSIVA")
        cmb_RefTipoPer.AgregarItem(3, "ENOJONA")
        cmb_RefTipoPer.AgregarItem(4, "TRANQUILA")
        cmb_RefTipoPer.AgregarItem(5, "SERIO")
        cmb_RefTipoPer.AgregarItem(6, "AMIGABLE")
        cmb_RefTipoPer.AgregarItem(7, "OTRO")
        'agregar valor al combo de confirma domicilio de candidato
        cmb_ConfirmaDomicilio.AgregarItem("S", "SI")
        cmb_ConfirmaDomicilio.AgregarItem("N", "NO")
        'agregar valor al combo de recomienda candidato
        cmb_Recomendacion.AgregarItem("S", "SI")
        cmb_Recomendacion.AgregarItem("N", "NO")
        'extraer datos segun sea prospectp ó empleado
        If EmpOrPros = "P" Then
            datos = Cn_Reclutamiento.fn_Consulta_ReferenciaPersonalP(Id)
        Else
            datos = Cn_Reclutamiento.fn_Consulta_ReferenciaPersonal(Id)
        End If
        'asignar datos
        If Not datos Is Nothing Then
            stat = "UP"
            btn_Guardar.Text = "Actualizar"
            tbx_AnosConocerlo.Text = datos("TiempoConocerlo")
            cmb_ConfirmaDomicilio.SelectedValue = datos("ConfirmaDomicilio")
            cmb_RefTipoPer.SelectedValue = datos("ConsideraAlCandidato")
            tbx_RelacionFamiliar.Text = datos("RelacionFamiliar")
            tbx_ConocimientoTrabajosCandidato.Text = datos("ConocimientoEmpleosCandidato")
            cmb_Recomendacion.SelectedValue = datos("Recomendado")
        Else
            stat = "SV"
        End If


    End Sub

    Private Sub btn_cerrar_Click(sender As Object, e As EventArgs) Handles btn_cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(sender As Object, e As EventArgs) Handles btn_Guardar.Click
        'validaciones 
        If tbx_AnosConocerlo.Text = "" And tbx_AnosConocerlo.Text IsNot Nothing Then
            MsgBox("No ha ingresado Años de conocer al candidato.")
            Exit Sub
        End If

        If cmb_ConfirmaDomicilio.SelectedValue <> "S" AndAlso cmb_ConfirmaDomicilio.SelectedValue <> "N" Then
            MsgBox("No ha confirmado el domicilio del candidato.")
            Exit Sub
        End If

        If cmb_RefTipoPer.SelectedValue = 0 Then
            MsgBox("No ha seleccionado que tipo de persona es el candidato.")
            Exit Sub
        End If

        If tbx_RelacionFamiliar.Text = "" Then
            MsgBox("No ha descrito la relacion familiar del candidato con su familia.")
            Exit Sub
        End If

        If tbx_ConocimientoTrabajosCandidato.Text = "" Then
            MsgBox("No ha puesto si conoce o no los lugares donde el candidato ha trabajado.")
            Exit Sub
        End If

        If cmb_Recomendacion.SelectedValue <> "S" AndAlso cmb_Recomendacion.SelectedValue <> "N" Then
            MsgBox("No ha seleccionado si recomienda al candidato.")
            Exit Sub
        End If

        'prospecto
        If EmpOrPros = "P" Then
            'guardar
            If stat = "SV" Then

                If Cn_Reclutamiento.fn_GuardarReferenciaPersonalP(Id, IdEmp, Decimal.Parse(tbx_AnosConocerlo.Text), cmb_ConfirmaDomicilio.SelectedValue,
                                                                cmb_RefTipoPer.SelectedValue, tbx_RelacionFamiliar.Text, tbx_ConocimientoTrabajosCandidato.Text,
                                                                cmb_Recomendacion.SelectedValue) Then
                    stat = "UP"
                    btn_Guardar.Text = "Actualizar"
                    MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If

            Else 'actualizar
                If Cn_Reclutamiento.fn_ActualizarReferenciaPersonalP(Id, IdEmp, Decimal.Parse(tbx_AnosConocerlo.Text), cmb_ConfirmaDomicilio.SelectedValue,
                                                                cmb_RefTipoPer.SelectedValue, tbx_RelacionFamiliar.Text, tbx_ConocimientoTrabajosCandidato.Text,
                                                                cmb_Recomendacion.SelectedValue) Then

                    MsgBox("Datos Actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            End If

        Else 'empleado
            'guardar
            If stat = "SV" Then
                If Cn_Reclutamiento.fn_GuardarReferenciaPersonal(Id, IdEmp, Decimal.Parse(tbx_AnosConocerlo.Text), cmb_ConfirmaDomicilio.SelectedValue,
                                                                cmb_RefTipoPer.SelectedValue, tbx_RelacionFamiliar.Text, tbx_ConocimientoTrabajosCandidato.Text,
                                                                cmb_Recomendacion.SelectedValue) Then
                    stat = "UP"
                    btn_Guardar.Text = "Actualizar"
                    MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            Else 'actualizar
                If Cn_Reclutamiento.fn_ActualizarReferenciaPersonal(Id, IdEmp, Decimal.Parse(tbx_AnosConocerlo.Text), cmb_ConfirmaDomicilio.SelectedValue,
                                                                cmb_RefTipoPer.SelectedValue, tbx_RelacionFamiliar.Text, tbx_ConocimientoTrabajosCandidato.Text,
                                                                cmb_Recomendacion.SelectedValue) Then

                    MsgBox("Datos Actualizados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                End If
            End If

        End If

    End Sub

    Private Sub tbx_AnosConocerlo_Leave(sender As Object, e As EventArgs) Handles tbx_AnosConocerlo.Leave
        Dim val As Decimal = 0

        If Decimal.TryParse(tbx_AnosConocerlo.Text, val) Then

            tbx_AnosConocerlo.Text = val.ToString("N2")

        Else

            tbx_AnosConocerlo.Text = ""

        End If
    End Sub
End Class