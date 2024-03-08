Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_ModoContacto

    Private Sub frm_ModoContacto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call LlenarTipos()
        lsv_Detalle.Columns.Add("Descripcion")
        lsv_Detalle.Columns.Add("Status")
        Call Botones()
    End Sub

#Region "SUB's"

    Sub LlenarTipos()
        lsv_Tipo.Items.Clear()
        lsv_Detalle.Items.Clear()
        If Not fn_ModoContacto_LlenarLista(lsv_Tipo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Tipo.Items.Count)
    End Sub

    Sub LlenarDetalle()
        lsv_Detalle.Items.Clear()
        If lsv_Tipo.SelectedItems.Count > 0 Then
            If Not fn_ModoContactoD_LlenarLista(lsv_Tipo.SelectedItems(0).Tag, lsv_Detalle) Then
                MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Sub Botones()
        gbx_Detalle.Enabled = lsv_Tipo.SelectedItems.Count > 0
        btn_ExportarTipo.Enabled = lsv_Tipo.Items.Count > 0
        btn_ExportarDetalle.Enabled = lsv_Detalle.Items.Count > 0
        If lsv_Tipo.SelectedItems.Count = 0 Then
            btn_ModificarTipo.Enabled = False
            btn_AltaTipo.Enabled = False
            btn_BajaTipo.Enabled = False
        Else
            btn_ModificarTipo.Enabled = lsv_Tipo.SelectedItems(0).SubItems(1).Text = "ACTIVO"
            btn_AltaTipo.Enabled = lsv_Tipo.SelectedItems(0).SubItems(1).Text = "BAJA"
            btn_BajaTipo.Enabled = lsv_Tipo.SelectedItems(0).SubItems(1).Text = "ACTIVO"
        End If
        If lsv_Detalle.SelectedItems.Count = 0 Then
            btn_ModificarDetalle.Enabled = False
            btn_AltaDetalle.Enabled = False
            btn_BajaDetalle.Enabled = False
        Else
            btn_ModificarDetalle.Enabled = lsv_Detalle.SelectedItems(0).SubItems(1).Text = "ACTIVO"
            btn_AltaDetalle.Enabled = lsv_Detalle.SelectedItems(0).SubItems(1).Text = "BAJA"
            btn_BajaDetalle.Enabled = lsv_Detalle.SelectedItems(0).SubItems(1).Text = "ACTIVO"
        End If
    End Sub

    Sub Limpiar()
        tbx_DescripcionTipo.Clear()
        tbx_DescripcionDetalle.Clear()
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Tipo.Items.Count)
    End Sub

#End Region

    Private Sub lsv_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Tipo.SelectedIndexChanged, lsv_Detalle.SelectedIndexChanged
        SegundosDesconexion = 0

        If sender.Equals(lsv_Tipo) Then Call LlenarDetalle()
        Call Botones()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarTipo.Click, btn_ExportarDetalle.Click
        SegundosDesconexion = 0

        If sender.Equals(btn_ExportarTipo) Then
            FuncionesGlobales.fn_Exportar_Excel(lsv_Tipo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        ElseIf sender.Equals(btn_ExportarDetalle) Then
            FuncionesGlobales.fn_Exportar_Excel(lsv_Detalle, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        End If
    End Sub

    'Private Sub lsv_Tipo_ColumnWidthChanged(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ColumnWidthChangedEventArgs) Handles lsv_Tipo.ColumnWidthChanged
    '    If lsv_Tipo.Columns(0).Width <> 235 Then
    '        lsv_Tipo.Columns(0).Width = 235
    '    End If
    'End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarTipo.Click, btn_AgregarDetalle.Click
        SegundosDesconexion = 0

        If sender.Equals(btn_AgregarTipo) Then
            If tbx_DescripcionTipo.Text = "" Then
                MsgBox("Ingrese una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_DescripcionTipo.Focus()
                Exit Sub
            End If

            If lsv_Tipo.Enabled Then
                'Crea un Nuevo Registro
                If fn_ModoContacto_Validar(tbx_DescripcionTipo.Text) Then
                    MsgBox("El registro ya existe, debe de ingresar otro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_DescripcionTipo.Clear()
                    tbx_DescripcionTipo.Focus()
                    Exit Sub
                End If
                If Not fn_ModoContacto_Nuevo(tbx_DescripcionTipo.Text) Then
                    MsgBox("No se pudo Agregar el nuevo registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else
                'Modifica un Registro Existente
                If Not fn_ModoContacto_Actualizar(lsv_Tipo.SelectedItems(0).Tag, tbx_DescripcionTipo.Text, "A") Then
                    MsgBox("No se pudo Modificar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                lsv_Tipo.Enabled = True
                gbx_Detalle.Enabled = False
            End If
            Call LlenarTipos()
            tbx_DescripcionTipo.Focus()

        ElseIf sender.Equals(btn_AgregarDetalle) Then
            If tbx_DescripcionDetalle.Text = "" Then
                MsgBox("Ingrese una Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_DescripcionDetalle.Focus()
                Exit Sub
            End If

            If lsv_Detalle.Enabled Then 'Crea un Nuevo Registro
                If fn_ModoContactoD_Validar(lsv_Tipo.SelectedItems(0).Tag, tbx_DescripcionDetalle.Text) Then
                    MsgBox("El registro ya existe, debe de ingresar otro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_DescripcionDetalle.Clear()
                    tbx_DescripcionDetalle.Focus()
                    Exit Sub
                End If
                If Not fn_ModoContactoD_Nuevo(lsv_Tipo.SelectedItems(0).Tag, tbx_DescripcionDetalle.Text) Then
                    MsgBox("No se pudo Agregar el nuevo registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
            Else 'Modifica un Nuevo Registro
                If Not fn_ModoContactoD_Actualizar(lsv_Detalle.SelectedItems(0).Tag, tbx_DescripcionDetalle.Text, "A") Then
                    MsgBox("No se pudo Modificar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                gbx_Tipo.Enabled = True
                lsv_Detalle.Enabled = True
            End If
            Call LlenarDetalle()
            tbx_DescripcionDetalle.Focus()
        End If

        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ModificarTipo.Click, btn_ModificarDetalle.Click
        SegundosDesconexion = 0

        If sender.Equals(btn_ModificarTipo) Then
            tbx_DescripcionTipo.Text = lsv_Tipo.SelectedItems(0).Text
            lsv_Tipo.Enabled = False
            btn_ModificarTipo.Enabled = False
            btn_BajaTipo.Enabled = False
            gbx_Detalle.Enabled = False
        ElseIf sender.Equals(btn_ModificarDetalle) Then
            tbx_DescripcionDetalle.Text = lsv_Detalle.SelectedItems(0).Text
            lsv_Detalle.Enabled = False
            btn_ModificarDetalle.Enabled = False
            btn_BajaDetalle.Enabled = False
            gbx_Tipo.Enabled = False
        End If
    End Sub

    Private Sub btn_AltaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AltaTipo.Click, btn_AltaDetalle.Click, btn_BajaTipo.Click, btn_BajaDetalle.Click
        SegundosDesconexion = 0

        If sender.Equals(btn_AltaTipo) Then
            If Not fn_ModoContacto_Actualizar(lsv_Tipo.SelectedItems(0).Tag, lsv_Tipo.SelectedItems(0).Text, "A") Then
                MsgBox("No se pudo Activar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarTipos()
        ElseIf sender.Equals(btn_BajaTipo) Then
            If Not fn_ModoContacto_Actualizar(lsv_Tipo.SelectedItems(0).Tag, lsv_Tipo.SelectedItems(0).Text, "B") Then
                MsgBox("No se pudo dar de Baja el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarTipos()
        ElseIf sender.Equals(btn_AltaDetalle) Then
            If Not fn_ModoContactoD_Actualizar(lsv_Detalle.SelectedItems(0).Tag, lsv_Detalle.SelectedItems(0).Text, "A") Then
                MsgBox("No se pudo Activar el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarDetalle()
        ElseIf sender.Equals(btn_BajaDetalle) Then
            If Not fn_ModoContactoD_Actualizar(lsv_Detalle.SelectedItems(0).Tag, lsv_Detalle.SelectedItems(0).Text, "B") Then
                MsgBox("No se pudo dar de Baja el registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call LlenarDetalle()
        End If
    End Sub

    Private Sub frm_ModoContacto_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            SegundosDesconexion = 0

            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class