Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_Gafetes

    Dim Nuevo As Boolean = True

    Private Sub frm_Gafetes_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        cmb_Tipo.AgregarItem(1, "VISITANTE")
        cmb_Tipo.AgregarItem(2, "PROVEEDOR")
        cmb_Tipo.AgregarItem(3, "AREA SEGURA")

        lsv_Lista.Columns.Add("Tipo")
        lsv_Lista.Columns.Add("Descripcion")
        lsv_Lista.Columns.Add("Status")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0
        Call LimpiarLista()

        If cmb_Tipo.SelectedValue = 0 Then
            MsgBox("Sleccione un Tipo para poder guardar un nuevo Gafete.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If

        If tbx_Descripcion.Text.Trim = "" Then
            MsgBox("Ingrese una Descripcion para el nuevo Gafete.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If Nuevo = True Then

            If fn_Gafetes_Existe(cmb_Tipo.SelectedValue, tbx_Descripcion.Text.Trim) = False Then
                MsgBox("Ese Gafet ya existe o a ocurrido un Error al verificarlo.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If fn_Gafetes_Nuevo(cmb_Tipo.SelectedValue, tbx_Descripcion.Text.Trim) = False Then
                MsgBox("Error al guardar el nuevo Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Chk_Todos.Checked = True
            'cmb_Tipo.SelectedValue = 0
            tbx_Descripcion.Text = ""
            tbx_Descripcion.Tag = ""
            Call Llenarlista()


        Else

            If fn_Gafetes_Modificar(tbx_Descripcion.Tag, cmb_Tipo.SelectedValue, tbx_Descripcion.Text.Trim) = False Then
                MsgBox("Error al modificar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            tbx_Descripcion.Text = ""
            tbx_Descripcion.Tag = ""
            'Chk_Todos.Checked = True
            'cmb_Tipo.SelectedValue = 0
            Nuevo = True
            Call Llenarlista()


        End If

    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0
        If Nuevo = False Then
            MsgBox("Termine la Edicion o precione cancelar para continuar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        Call LimpiarLista()
        Call Llenarlista()
    End Sub

    Private Sub Llenarlista()

        If cmb_Tipo.SelectedValue = 0 And Chk_Todos.Checked = False Then
            MsgBox("Seleccione un tipo o marque la casilla «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If

        If fn_Gafetes_Llenarlista(lsv_Lista, cmb_Tipo.SelectedValue, IIf(chk_Activos.Checked, "A", "T")) = False Then
            MsgBox("Error al cargar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        lbl_Registros.Text = "Registros: " & lsv_Lista.Items.Count
    End Sub

    Private Sub Chk_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_Todos.CheckedChanged
        SegundosDesconexion = 0
        If Nuevo = True Then Call LimpiarLista()
        cmb_Tipo.Enabled = Chk_Todos.Checked = False
        cmb_Tipo.SelectedValue = 0
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        If lsv_Lista.Items.Count = 0 Then
            MsgBox("No hay Infomacion para Exportar.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        FuncionesGlobales.fn_Exportar_Excel(lsv_Lista, 2, Me.Text & " Tipo: " & IIf(Chk_Todos.Checked, "TODOS", cmb_Tipo.Text), 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Lista.DoubleClick
        SegundosDesconexion = 0

        If lsv_Lista.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Lista.SelectedItems(0).SubItems(2).Text = "BAJA" Then
            MsgBox("No puede modificar un gafete en status Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Lista.SelectedItems(0).SubItems(2).Text = "OCUPADO" Then
            MsgBox("No puede modificar un gafete en status Ocupado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Nuevo = False
        Chk_Todos.Checked = False
        tbx_Descripcion.Tag = lsv_Lista.SelectedItems(0).Tag
        tbx_Descripcion.Text = lsv_Lista.SelectedItems(0).SubItems(1).Text
        cmb_Tipo.Text = lsv_Lista.SelectedItems(0).SubItems(0).Text

    End Sub

    Private Sub chk_Activos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Activos.CheckedChanged
        SegundosDesconexion = 0
        If Nuevo = False Then
            MsgBox("Termine la Edicion o precione cancelar para continuar.", MsgBoxStyle.Information, frm_MENU.Text)
            Exit Sub
        End If
        Call LimpiarLista()
        Call Llenarlista()
    End Sub

    Private Sub Btn_AltaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_AltaBaja.Click
        SegundosDesconexion = 0

        If lsv_Lista.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If lsv_Lista.SelectedItems(0).SubItems(2).Text = "OCUPADO" Then
            MsgBox("No puede modificar un gafete en status Ocupado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If fn_Gafetes_Status(lsv_Lista.SelectedItems(0).Tag, IIf(lsv_Lista.SelectedItems(0).SubItems(2).Text = "ACTIVO", "B", "A")) = False Then
            MsgBox("Error al modificar el Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call Llenarlista()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0
        If Nuevo = True Then
            MsgBox("No se encuentra en modo de Edicion.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        cmb_Tipo.SelectedValue = 0
        tbx_Descripcion.Text = ""
        tbx_Descripcion.Tag = ""
        Nuevo = True
    End Sub

    Private Sub LimpiarLista()
        lsv_Lista.Items.Clear()
        lbl_Registros.Text = "Registros: 0"
    End Sub

    Private Sub cmb_Tipo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Tipo.SelectedIndexChanged
        SegundosDesconexion = 0
        If Nuevo = True Then Call LimpiarLista()
    End Sub

    Private Sub btn_Imprimir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Imprimir.Click
        SegundosDesconexion = 0
        If lsv_Lista.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un Registro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Dim frm_Gafete As New frm_GafeteImprimirPlant 'plantilla gafetes

        frm_Gafete.TextoImprimir = lsv_Lista.SelectedItems(0).SubItems(1).Text 'Ejem: Texto V-001
        frm_Gafete.TipoGafete = lsv_Lista.SelectedItems(0).Text 'Proveedor o Visitante
        frm_Gafete.ShowDialog()
    End Sub
End Class