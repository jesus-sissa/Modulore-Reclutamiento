Imports System.IO

Public Class frm_CredencialesExpedir

    Private Sub frm_CredencialesExpedir_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdb_Interno.Checked = True
        cmb_Empleado.Actualizar()
        cmb_MotivoExpedicion.Actualizar()
        cmb_UsuarioAutoriza.Actualizar()
    End Sub

    Private Sub LimpiarObjetos()
        tbx_Nombres.Clear()
        tbx_Apellidos.Clear()
        tbx_Departamento.Clear()
        tbx_Puesto.Clear()
        tbx_FechaRegistro.Clear()
        tbx_FechaIngreso.Clear()
        tbx_FechaVenceActual.Clear()
        tbx_FechaExpideActual.Clear()
        cmb_MotivoExpedicion.SelectedValue = 0
        rdb_Si_EntregoAnterior.Checked = True
        'tbx_Folio.Clear()
        dtp_FechaExpedicion.Value = Today
        dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 6, dtp_FechaExpedicion.Value)
        tbx_Comentarios.Clear()
        ptb_Foto.Image = Nothing
        pct_Codigo.Image = Nothing
        btn_Guardar.Enabled = False
    End Sub

    Private Sub tbx_Clave_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Clave.TextChanged
        Call LimpiarObjetos()
    End Sub

    Private Sub cmb_Empleado_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedIndexChanged
        Call LimpiarObjetos()
        Call Buscar_Empleado()
    End Sub

    Sub Buscar_Empleado()
        If cmb_Empleado.SelectedValue = 0 Then
            'MsgBox("Indique la Clave del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            'tbx_Clave.Focus()
            Exit Sub
        Else
            Dim Dr_Credenciales As DataRow
            Dim Dr_Foto As DataRow
            ptb_Foto.Image = Nothing
            pct_Codigo.Image = Nothing

            If rdb_Externo.Checked = True Then
                Dr_Credenciales = Cn_Reclutamiento.fn_EmpleadosXFCred_ObtenValores(cmb_Empleado.SelectedValue)
                Dr_Foto = Cn_Reclutamiento.fn_EmpleadosXF_LeerImagenes(cmb_Empleado.SelectedValue)
            Else
                Dr_Credenciales = Cn_Reclutamiento.fn_EmpleadosCred_ObtenValores(cmb_Empleado.SelectedValue)
                Dr_Foto = Cn_Reclutamiento.fn_Empleados_LeerImagenes(cmb_Empleado.SelectedValue)
            End If

            If Not Dr_Credenciales Is Nothing Then

                tbx_Nombres.Text = Dr_Credenciales("Nombres")
                tbx_Apellidos.Text = Dr_Credenciales("Apellidos")
                tbx_Departamento.Text = Dr_Credenciales("Departamento")
                tbx_Puesto.Text = Dr_Credenciales("Puesto")
                tbx_FechaRegistro.Text = Format(Dr_Credenciales("Fecha_Registro"), "dd/MM/yyyy")
                tbx_FechaIngreso.Text = Format(Dr_Credenciales("Fecha_Ingreso"), "dd/MM/yyyy")
                tbx_FechaVenceActual.Text = Dr_Credenciales("FechaVenceCred")
                tbx_FechaExpideActual.Text = Dr_Credenciales("FechaExpide")

                btn_Guardar.Enabled = True

                cmb_MotivoExpedicion.Focus()

                'CONSULTAR FOTOS
                If dr_Foto IsNot Nothing Then
                    If Not IsDBNull(dr_Foto("Frente")) Then
                        Dim ms1 As MemoryStream = New MemoryStream(dr_Foto("Frente"), 0, dr_Foto("Frente").Length)
                        ms1.Write(dr_Foto("Frente"), 0, dr_Foto("Frente").Length)
                        ptb_Foto.Image = Image.FromStream(ms1, True)
                    End If
                    If Not IsDBNull(dr_Foto("Codigo")) Then
                        Dim ms2 As MemoryStream = New MemoryStream(dr_Foto("Codigo"), 0, dr_Foto("Codigo").Length)
                        ms2.Write(dr_Foto("Codigo"), 0, dr_Foto("Codigo").Length)
                        pct_Codigo.Image = Image.FromStream(ms2, True)
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
        If frm_CredencialesAutorizacion.Visible = True Then
            frm_CredencialesAutorizacion.LlenarLista()
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        'If tbx_Folio.Text = "" Then
        '    MsgBox("Capture el Folio de Credencial.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    tbx_Folio.Focus()
        '    Exit Sub
        'End If
        If cmb_MotivoExpedicion.SelectedValue = 0 Then
            MsgBox("Seleccione el Motivo de Expedición.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_MotivoExpedicion.Focus()
            Exit Sub
        End If

        Dim EntregoAnterior As String = ""
        Dim Tipo As Byte = 1

        If rdb_Externo.Checked = True Then Tipo = 2

        If rdb_Si_EntregoAnterior.Checked = True Then
            EntregoAnterior = "S"
        Else
            EntregoAnterior = "N"
        End If

        If Cn_Reclutamiento.fn_Credenciales_Validar(cmb_Empleado.SelectedValue, Tipo) Then
            If Cn_Reclutamiento.fn_Credenciales_Nuevo(cmb_Empleado.SelectedValue, tbx_Clave.Text, dtp_FechaExpedicion.Value, EntregoAnterior, dtp_FechaVencimiento.Value, tbx_Comentarios.Text, cmb_MotivoExpedicion.SelectedValue, cmb_UsuarioAutoriza.SelectedValue, Tipo) Then
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Clave.Clear()
                Call LimpiarObjetos()
                tbx_Clave.Focus()
            Else
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Else
            MsgBox("Ya existe una Credencial pendiente de autorizar para este Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        tbx_Clave.Clear()
        cmb_Empleado.SelectedValue = 0
        Call LimpiarObjetos()
    End Sub

    Private Sub frm_CredencialesExpedir_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub dtp_FechaExpedicion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaExpedicion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            dtp_FechaVencimiento.Focus()
        End If
    End Sub

    Private Sub dtp_FechaExpedicion_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaExpedicion.ValueChanged
        dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 6, dtp_FechaExpedicion.Value)
    End Sub

    Private Sub dtp_FechaVencimiento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaVencimiento.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_Comentarios.Focus()
        End If
    End Sub

    Private Sub dtp_FechaVencimiento_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaVencimiento.ValueChanged
        If dtp_FechaVencimiento.Value <= dtp_FechaExpedicion.Value Then
            dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 6, dtp_FechaExpedicion.Value)
            Exit Sub
        End If
        'If dtp_FechaVencimiento.Value <= dtp_FechaExpedicion.Value Then
        '    dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 6, dtp_FechaExpedicion.Value)
        '   
        'Else
        '    If dtp_FechaVencimiento.Value > DateAdd(DateInterval.Month, 12, dtp_FechaExpedicion.Value) Then
        '        dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 12, dtp_FechaExpedicion.Value)
        '        Exit Sub
        '    End If
        '    If dtp_FechaVencimiento.Value < DateAdd(DateInterval.Month, 1, dtp_FechaExpedicion.Value) Then
        '        dtp_FechaVencimiento.Value = DateAdd(DateInterval.Month, 1, dtp_FechaExpedicion.Value)
        '        Exit Sub
        '    End If
        'End If
    End Sub

    Private Sub GroupBox4_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Gbx_Empleado.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub gbx_Imagenes_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles gbx_Imagenes.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub rdb_Interno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Interno.CheckedChanged
        If rdb_Interno.Checked = True Then
            cmb_Empleado.StoredProcedure = "Cat_EmpleadosCombo_Get"
            cmb_Empleado.Sucursal = True
            cmb_Empleado.Actualizar()
        End If
    End Sub

    Private Sub rdb_Externo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Externo.CheckedChanged
        If rdb_Externo.Checked = True Then
            cmb_Empleado.StoredProcedure = "Cat_EmpleadosXFCombo_Get"
            cmb_Empleado.Sucursal = False
            cmb_Empleado.Actualizar()
        End If
    End Sub
End Class