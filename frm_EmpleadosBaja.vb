Imports System.IO
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosBaja
    Dim Adjunto As String = ""

    Private Sub frm_EmpleadosBaja_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Try
            If File.Exists(Adjunto) Then Kill(Adjunto)
        Catch
        End Try
    End Sub

    Private Sub frm_EmpleadosBaja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub frm_EmpleadosBaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Nombre_Baja.Actualizar()

        ' cmb_MotivoBaja.ValorParametro = 2
        cmb_MotivoBaja.AgregaParametro("@Tipo", 2, 1)
        cmb_MotivoBaja.Actualizar()
        cmb_MotivoBaja.SelectedValue = 0
        tbx_Clave_Baja.Tag = 0
        rdb_ListaNegraSi.Tag = 0
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0

        Dim Status As Char = ""
        Dim BajaInmediata As Boolean = False
        Dim ListaNegra As Boolean = False

        If cmb_MotivoBaja.SelectedValue = 0 Then
            MsgBox("Seleccione Motivo de Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_MotivoBaja.Focus()
            Exit Sub
        End If

        If rdb_ListaNegraSi.Checked = False And rdb_ListaNegraNo.Checked = False Then
            MsgBox("Debe indicar si el Empleado será agregado a la lista negra o No.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If rdb_ListaNegraSi.Checked Then
            ListaNegra = True
            If rtb_Motivo.Text.Length < 10 Then
                MsgBox("Debe indicar el motivo por el cual se agrega el Empleado a la Lista Negra (mas de 10 caracteres).", MsgBoxStyle.Critical, frm_MENU.Text)
                rtb_Motivo.Focus()
                Exit Sub
            End If
        End If

        'Observaciones Obligatarias
        If rtb_Observaciones.Text = "" Or rtb_Observaciones.Text.Length < 30 Then
            MsgBox("Necesita agregar una observacion de Al menos 30 caracteres")
            Exit Sub
        End If
        If dtp_FechaFinLabores_Baja.Value.Date <= Now.Date Then
            'Si la fecha de fin de labores es la fecha de hoy o dias anteriores
            'Baja Inmediata
            BajaInmediata = True
            If fn_Empleados_ValidarDependencias(cmb_Nombre_Baja.SelectedValue) Then
                Status = "V"
                'se le cambia el Status = 'B' al la tabla de Empleados
                'fn_Empleados_Baja(cmb_Nombre_Baja.SelectedValue)
            Else
                MsgBox("No se puede dar de Baja el Empleado porque tiene dependencias registradas.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Se revisa si el empleado tiene armas asignadas o no
            '' '' '''SE DEJA COMENTADO DESDE EL 02 ENERO 2012 para revisar la manera correcta a realizar este paso
            '' '' ''If Not fn_Empleados_ValidarArmas(cmb_Nombre_Baja.SelectedValue) Then
            '' '' ''    MsgBox("No se puede dar de Baja el Empleado porque tiene Armas Asignadas.", MsgBoxStyle.Critical, frm_MENU.Text)
            '' '' ''    Exit Sub
            '' '' ''End If
        Else
            BajaInmediata = False
            'Si la fecha de fin de labores es futura
            'Programar Baja
            Status = "A"
        End If

        Dim RutaTemp As String = My.Application.Info.DirectoryPath & "\"
        If tbx_Clave_Baja.Tag > 0 Then
            'Falta ver si es una modificacion de la baja pero es para la fecha actual
            'En este caso se deberia registrar la baja de inmediato y cancelar las bajas programadas
            If Not fn_EmpleadosBaja_Actualizar(tbx_Clave_Baja.Tag, dtp_FechaFinLabores_Baja.Value.Date, rtb_Observaciones.Text, cmb_MotivoBaja.SelectedValue, Status, tbx_Puesto_Baja.Tag, tbx_Departamento_Baja.Tag, ListaNegra, rdb_ListaNegraSi.Tag, cmb_Nombre_Baja.SelectedValue, cmb_Nombre_Baja.Text, tbx_Puesto_Baja.Text, rtb_Motivo.Text) Then
                MsgBox("Ha ocurrido un error al intentar registrar la baja.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Else
            If Not fn_EmpleadosBaja_Nuevo(cmb_Nombre_Baja.SelectedValue, dtp_FechaFinLabores_Baja.Value.Date, rtb_Observaciones.Text, cmb_MotivoBaja.SelectedValue, Status, BajaInmediata, ListaNegra, cmb_Nombre_Baja.Text, rtb_Motivo.Text, tbx_Puesto_Baja.Text, tbx_Puesto_Baja.Tag, tbx_Departamento_Baja.Tag) Then
                MsgBox("Ha ocurrido un error al intentar registrar la baja.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            Else
                'Proceder con la Alerta y Mail
                If Adjunto = "S" Then
                    'Dim filesize As Long = 0
                    'Extraer la imagen a una Carpeta
                    Adjunto = FuncionesGlobales.fn_ReducirImagen("Frente", ptb_Foto.Image, 100000, 30, RutaTemp, 170, 150)
                    ptb_Foto.Image = Nothing
                End If

                'Aquí se inserta la Alerta de Baja
                Dim Detalles As String = "       Sucursal:" & SucursalN & Chr(13) _
                                        & "        Nombre:" & tbx_Clave_Baja.Text & " - " & cmb_Nombre_Baja.Text & Chr(13) _
                                        & "  Departamento:" & tbx_Departamento_Baja.Text & Chr(13) _
                                        & "        Puesto:" & tbx_Puesto_Baja.Text & Chr(13) _
                                        & "    Fecha Baja:" & dtp_FechaFinLabores_Baja.Value.Date & Chr(13) _
                                        & "Fecha Registro:" & Now.ToShortDateString & " - " & Now.ToShortTimeString

                'Dim DetalleHTML As String = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr><tr><td colspan='3' align='center'>Encabezado</td></tr><tr><td colspan='3'><br><hr /></td></tr><tr><td rowspan='8'><img src='cid:1' style='width:170px; height:150px; border:solid 1px'/></td></tr>" _
                '                    & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                '                        & "<tr><td align='right'><label><b>Nombre:</b></label></td><td>" & tbx_Clave_Baja.Text & " - " & cmb_Nombre_Baja.Text & "</td></tr><tr><td align='right'><label><b>Departamento:</b></label></td>" _
                '                            & "<td>" & tbx_Departamento_Baja.Text & "</td></tr><tr><td align='right'><label><b>Puesto:</b></label></td><td>" & tbx_Puesto_Baja.Text & "</td></tr>" & "<tr><td align='right'><b>Fecha Ingreso</b></td><td>" & tbx_FechaIngreso_Baja.Text & "</td></tr>" & "<tr><td align='right'><label><b>Fecha Baja:</b></label></td>" _
                '                            & "<td>" & dtp_FechaFinLabores_Baja.Value.Date & " - " & Now.ToShortTimeString & "</td></tr>" &
                '                            "<tr><td align='right'><label><b>Observaciones:</b></label></td><td>" & rtb_Observaciones.Text & "</td></tr>" &
                '                            "<tr><td align='right'><label><b>Validado Por:</b></label></td><td>" & UsuarioN & "<br></td> </tr></table></body></html>"
                Dim DetalleHTML As String = "<html><body><table style='border: solid 1px'>
		                                    <tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr>
		                                    <tr><td colspan='3' align='center'>Encabezado</td></tr>
		                                    <tr><td colspan='3'><br><hr /></td></tr>
		                                    <tr><td rowspan='8'><img src='cid:1' style='width:170px; height:150px; border:solid 1px'/></td><td>
				                                    <table>
						                                <tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>
					                                    <tr><td align='right'><label><b>Nombre:</b></label></td><td>" & tbx_Clave_Baja.Text & " - " & cmb_Nombre_Baja.Text & "</td></tr>
					                                    <tr><td align='right'><label><b>Departamento:</b></label></td><td>" & tbx_Departamento_Baja.Text & "</td></tr>
					                                    <tr><td align='right'><label><b>Puesto:</b></label></td><td>" & tbx_Puesto_Baja.Text & "</td></tr>
					                                    <tr><td align='right'><b>Fecha Ingreso</b></td><td>" & tbx_FechaIngreso_Baja.Text & "</td></tr>
					                                    <tr><td align='right'><label><b>Fecha Baja:</b></label></td><td>" & dtp_FechaFinLabores_Baja.Value.Date & " - " & Now.ToShortTimeString & "</td></tr>
					                                    <tr><td align='right'><label><b>Observaciones:</b></label></td><td>" & rtb_Observaciones.Text & "</td></tr>
					                                    <tr><td align='right'><label><b>Validado Por:</b></label></td><td>" & UsuarioN & "<br></td></tr>
				                                    </table
				
			                                    </td>
		                                    </tr></table></body></html>"

                fn_AlertasGeneradas_Guardar("13", Detalles, Nothing, True, "BAJA DE EMPLEADO", Adjunto, DetalleHTML)
                MsgBox("El empleado se dio de Baja correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If

        tbx_Clave_Baja.Clear()
        tbx_Clave_Baja.Focus()
        tbx_Clave_Baja.Tag = 0
        cmb_Nombre_Baja.SelectedValue = 0
        cmb_MotivoBaja.SelectedValue = 0
        tbx_Departamento_Baja.Clear()
        tbx_Puesto_Baja.Clear()
        tbx_FechaIngreso_Baja.Clear()
        dtp_FechaFinLabores_Baja.Value = Today
        rtb_Observaciones.Clear()
        rdb_ListaNegraSi.Tag = 0

        If Status = "V" Then cmb_Nombre_Baja.Actualizar()

        dtp_FechaFinLabores_Baja.Enabled = False

        rdb_ListaNegraSi.Checked = False
        rdb_ListaNegraNo.Checked = True
        rdb_ListaNegraNo.Checked = False
        rtb_Observaciones.Enabled = False
        btn_Baja.Enabled = False

        Try
            If File.Exists(RutaTemp) Then Kill(RutaTemp)
        Catch
        End Try
        pct_Codigo.Image = Nothing
    End Sub

    Private Sub tbx_Clave_Baja_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Clave_Baja.TextChanged
        tbx_Departamento_Baja.Clear()
        tbx_Puesto_Baja.Clear()
        tbx_FechaIngreso_Baja.Clear()
        dtp_FechaFinLabores_Baja.Value = Today
        rtb_Observaciones.Clear()
        cmb_MotivoBaja.SelectedValue = 0

        rdb_ListaNegraSi.Checked = False
        rdb_ListaNegraNo.Checked = True
        rdb_ListaNegraNo.Checked = False

        dtp_FechaFinLabores_Baja.Enabled = False
        rtb_Observaciones.Enabled = False
        btn_Baja.Enabled = False
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click

        ' esta oculto este boton porque iva ligado a tbx_clave empleado
        SegundosDesconexion = 0

        'If cmb_Nombre_Baja.SelectedValue = 0 Then
        '    MsgBox("Indique la Clave del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    tbx_Clave_Baja.Focus() '7mayo2014
        '    Exit Sub
        'Else
        Dim Dr_EmpleadoBaja As DataRow = fn_Empleados_ObtenValores(cmb_Nombre_Baja.SelectedValue)
        If Dr_EmpleadoBaja IsNot Nothing Then
            tbx_Departamento_Baja.Enabled = True
            tbx_Puesto_Baja.Enabled = True
            tbx_FechaIngreso_Baja.Enabled = True
            dtp_FechaFinLabores_Baja.Enabled = True
            cmb_MotivoBaja.Enabled = True
            rtb_Observaciones.Enabled = True

            tbx_Departamento_Baja.Text = Dr_EmpleadoBaja("Departamento")
            tbx_Departamento_Baja.Tag = Dr_EmpleadoBaja("Id_Departamento")
            tbx_Puesto_Baja.Text = Dr_EmpleadoBaja("Puesto")
            tbx_Puesto_Baja.Tag = Dr_EmpleadoBaja("Id_Puesto")
            tbx_FechaIngreso_Baja.Text = Format(Dr_EmpleadoBaja("FechaIngreso"), "dd/MM/yyyy")
            dtp_FechaFinLabores_Baja.Focus()

            If Dr_EmpleadoBaja("Status") = "BAJA" Then
                btn_Baja.Enabled = False
                dtp_FechaFinLabores_Baja.Value = Dr_EmpleadoBaja("FechaBaja")

                MsgBox("Este Empleado ya fue dado de baja anteriormente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                btn_Baja.Enabled = True
            End If

            Dim dr As DataRow = fn_EmpleadosBaja_ObtenValores(cmb_Nombre_Baja.SelectedValue)
            If dr IsNot Nothing Then
                Dim Dr_EmpleadoListaNegra As DataRow = fn_EmpleadosBaja_LitsaNegra(dr("Id_ListaNegra"))

                If Dr_EmpleadoListaNegra IsNot Nothing Then
                    rdb_ListaNegraSi.Checked = True
                    rdb_ListaNegraSi.Tag = Dr_EmpleadoListaNegra("Id_ListaNegra")
                    rtb_Motivo.Text = Dr_EmpleadoListaNegra("Motivo")
                Else
                    rdb_ListaNegraSi.Tag = 0
                    rdb_ListaNegraNo.Checked = True
                End If

                If dr("Status") = "ACTIVO" Then
                    dtp_FechaFinLabores_Baja.Value = dr("FechaBaja")
                    cmb_MotivoBaja.SelectedValue = dr("Id_MotivoB")
                    rtb_Observaciones.Text = dr("Observaciones")
                    If MsgBox("El Empleado seleccionado ya tiene programada su Baja, ¿Desea modificarla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                        btn_Baja.Enabled = True
                        tbx_Clave_Baja.Tag = dr("Id_Baja")
                    Else
                        btn_Baja.Enabled = False
                    End If
                Else
                    tbx_Clave_Baja.Tag = 0
                End If
            Else
                tbx_Clave_Baja.Tag = 0
                rdb_ListaNegraSi.Tag = 0
            End If

            ptb_Foto.Image = Nothing
            pct_Codigo.Image = Nothing

            'CONSULTAR FOTOS
            Dim dr_Foto As DataRow = Cn_Reclutamiento.fn_Empleados_LeerImagenes(cmb_Nombre_Baja.SelectedValue)
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
                'If dr_Foto("TieneFrente") = "SI" Then
                '    Adjunto = "S"
                'Else
                '    Adjunto = ""
                'End If

                'Siempre es si porque siempre va a traer una imagen, puede ser la del empleado
                'o la de Imagen No Disponible.
                Adjunto = "S"
            Else
                Adjunto = ""
            End If
        End If
        ' End If 7mayo2014
    End Sub

    Private Sub frm_EmpleadosBaja_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_Motivo_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Motivo.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rdb_ListaNegraSi_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ListaNegraSi.CheckedChanged
        SegundosDesconexion = 0

        If rdb_ListaNegraSi.Checked Then
            lbl_Motivo.Enabled = True
            rtb_Motivo.Enabled = True
            lbl_AsteriscoLN.Visible = True
            rtb_Motivo.Clear()
        End If
    End Sub

    Private Sub rdb_ListaNegraNo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_ListaNegraNo.CheckedChanged
        SegundosDesconexion = 0

        If rdb_ListaNegraNo.Checked Then
            lbl_AsteriscoLN.Visible = False
            lbl_Motivo.Enabled = False
            rtb_Motivo.Enabled = False
            rtb_Motivo.Clear()
        End If
    End Sub

    Private Sub cmb_Nombre_Baja_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Nombre_Baja.SelectedIndexChanged
        If cmb_Nombre_Baja.SelectedValue = 0 Then
            tbx_Departamento_Baja.Clear()
            tbx_Puesto_Baja.Clear()
            tbx_FechaIngreso_Baja.Clear()
            dtp_FechaFinLabores_Baja.Value = Today
            rtb_Observaciones.Clear()
            cmb_MotivoBaja.SelectedValue = 0

            rdb_ListaNegraSi.Checked = False
            rdb_ListaNegraNo.Checked = True
            rdb_ListaNegraNo.Checked = False

            dtp_FechaFinLabores_Baja.Enabled = False
            rtb_Observaciones.Enabled = False
            btn_Baja.Enabled = False

            ptb_Foto.Image = Nothing
            pct_Codigo.Image = Nothing
            Exit Sub
        End If

        Dim Dr_EmpleadoBaja As DataRow = fn_Empleados_ObtenValores(cmb_Nombre_Baja.SelectedValue)
        If Dr_EmpleadoBaja IsNot Nothing Then
            tbx_Departamento_Baja.Enabled = True
            tbx_Puesto_Baja.Enabled = True
            tbx_FechaIngreso_Baja.Enabled = True
            dtp_FechaFinLabores_Baja.Enabled = True
            cmb_MotivoBaja.Enabled = True
            rtb_Observaciones.Enabled = True

            tbx_Departamento_Baja.Text = Dr_EmpleadoBaja("Departamento")
            tbx_Departamento_Baja.Tag = Dr_EmpleadoBaja("Id_Departamento")
            tbx_Puesto_Baja.Text = Dr_EmpleadoBaja("Puesto")
            tbx_Puesto_Baja.Tag = Dr_EmpleadoBaja("Id_Puesto")
            tbx_FechaIngreso_Baja.Text = Format(Dr_EmpleadoBaja("FechaIngreso"), "dd/MM/yyyy")
            dtp_FechaFinLabores_Baja.Focus()

            If Dr_EmpleadoBaja("Status") = "BAJA" Then
                btn_Baja.Enabled = False
                dtp_FechaFinLabores_Baja.Value = Dr_EmpleadoBaja("FechaBaja")

                MsgBox("Este Empleado ya fue dado de baja anteriormente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                btn_Baja.Enabled = True
            End If

            Dim dr As DataRow = fn_EmpleadosBaja_ObtenValores(cmb_Nombre_Baja.SelectedValue)
            If dr IsNot Nothing Then
                Dim Dr_EmpleadoListaNegra As DataRow = fn_EmpleadosBaja_LitsaNegra(dr("Id_ListaNegra"))

                If Dr_EmpleadoListaNegra IsNot Nothing Then
                    rdb_ListaNegraSi.Checked = True
                    rdb_ListaNegraSi.Tag = Dr_EmpleadoListaNegra("Id_ListaNegra")
                    rtb_Motivo.Text = Dr_EmpleadoListaNegra("Motivo")
                Else
                    rdb_ListaNegraSi.Tag = 0
                    rdb_ListaNegraNo.Checked = True
                End If

                If dr("Status") = "ACTIVO" Then
                    dtp_FechaFinLabores_Baja.Value = dr("FechaBaja")
                    cmb_MotivoBaja.SelectedValue = dr("Id_MotivoB")
                    rtb_Observaciones.Text = dr("Observaciones")
                    If MsgBox("El Empleado seleccionado ya tiene programada su Baja, ¿Desea modificarla?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                        btn_Baja.Enabled = True
                        tbx_Clave_Baja.Tag = dr("Id_Baja")
                    Else
                        btn_Baja.Enabled = False
                    End If
                Else
                    tbx_Clave_Baja.Tag = 0
                End If
            Else
                tbx_Clave_Baja.Tag = 0
                rdb_ListaNegraSi.Tag = 0
            End If

            ptb_Foto.Image = Nothing
            pct_Codigo.Image = Nothing

            'CONSULTAR FOTOS
            Dim dr_Foto As DataRow = Cn_Reclutamiento.fn_Empleados_LeerImagenes(cmb_Nombre_Baja.SelectedValue)
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
                'If dr_Foto("TieneFrente") = "SI" Then
                '    Adjunto = "S"
                'Else
                '    Adjunto = ""
                'End If

                'Siempre es si porque siempre va a traer una imagen, puede ser la del empleado
                'o la de Imagen No Disponible.
                Adjunto = "S"
            Else
                Adjunto = ""
            End If
        End If

    End Sub
End Class