

Public Class frm_ImplementosInventario



    Private Sub frm_ImplementosInventario_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Descripción")
        lsv_Catalogo.Columns.Add("Stock Mínimo")
        lsv_Catalogo.Columns.Add("Existencia")
        lsv_Catalogo.Columns.Add("Status")
        'cmb_Implementos.Actualizar()

        'Aquí se inhabilita la pestaña Entradas
        Me.tab_Entradas.Parent = Nothing

        'Aqui se llena la lista de Implementos
        If Not Cn_Reclutamiento.fn_ImplementosInventarios_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aqui se ocultan o se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        Else
            btn_Exportar.Enabled = True
        End If

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

    End Sub


    Private Sub frm_Implementos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub


    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar

        'Aqui se ocultan o se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        Else
            btn_Exportar.Enabled = True
        End If

    End Sub


    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub


    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub


    Private Sub lsv_Catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.Click
        btn_Modificar.Enabled = True
    End Sub


    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick

        'Aquí se habilita la pestaña de Entradas
        Me.tab_Entradas.Parent = Me.Tab_Catalogo

        'Aqui se establece el texto del objeto seleccionado
        tbx_ClaveImplemento.Text = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        tbx_StockMinimo.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        tbx_Existencia.Text = lsv_Catalogo.SelectedItems(0).SubItems(3).Text
        tbx_Implemento.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        'cmb_Implementos.SelectedValue = lsv_Catalogo.SelectedItems(0).SubItems(5).Text

        'Aqui se cambia a la pestaña Listado
        Tab_Catalogo.SelectedTab = tab_Entradas

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub


    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged

        If Tab_Catalogo.SelectedIndex = 0 Then

            tbx_ClaveImplemento.Clear()
            tbx_Implemento.Clear()
            tbx_StockMinimo.Clear()
            tbx_Existencia.Clear()

            btn_Modificar.Enabled = False
            Me.tab_Entradas.Parent = Nothing

        End If

    End Sub


    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        'If tbx_ClaveImplemento.Text = "" Then
        'MsgBox("Capture la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
        'tbx_ClaveImplemento.Focus()
        'Exit Sub
        'End If

        'If cmb_Implementos.SelectedValue = 0 Then
        'MsgBox("Seleccione el Implemento.", MsgBoxStyle.Critical, frm_MENU.Text)
        'cmb_Implementos.Focus()
        'Exit Sub
        'End If

        If tbx_StockMinimo.Text = 0 Then
            MsgBox("Capture el Stock Mínimo.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_StockMinimo.Focus()
            Exit Sub
        End If

        'If tbx_Existencia.Text = 0 Then
        'MsgBox("Capture la Existencia.", MsgBoxStyle.Critical, frm_MENU.Text)
        'tbx_Existencia.Focus()
        'Exit Sub
        'End If

        If Cn_Reclutamiento.fn_ImplementosInventarios_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_StockMinimo.Text, tbx_Existencia.Text) Then

            MsgBox("Registro Modificado.", MsgBoxStyle.Information, frm_MENU.Text)

            Tab_Catalogo.SelectedTab = tab_Listado

        Else
            MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)

        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()

        'Aqui se Actualiza el listview (Listado de Implementos)
        Cn_Reclutamiento.fn_ImplementosInventarios_LlenarLista(lsv_Catalogo)

        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        Else
            btn_Exportar.Enabled = True
        End If

        btn_Modificar.Enabled = False

        'Aqui se limpia el contador de progreso
        Cn_Reclutamiento.fn_Menu_Progreso(0)

    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class