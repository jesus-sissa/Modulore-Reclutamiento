
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosListaNegra

    Private Sub frm_EmpleadosListaNegra_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Empresa")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Motivo")

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Aqui se limpian los textbox
        tbx_Nombre.Clear()
        tbx_Empresa.Clear()
        tbx_Motivo.Clear()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If tbx_Nombre.Text = "" Then
            MsgBox("Capture el Nombre.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre.Focus()
            Exit Sub
        End If

        If tbx_Empresa.Text = "" Then
            MsgBox("Capture la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Empresa.Focus()
            Exit Sub
        End If

        If tbx_Motivo.Text = "" Then
            MsgBox("Capture el Motivo.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Motivo.Focus()
            Exit Sub
        End If

        'En caso de que todo sea valido
        If Tab_Nuevo.Text = "Nuevo" Then

            'Si se esta Insertando
            If fn_ListaNegra_Nuevo(tbx_Nombre.Text, tbx_Empresa.Text, tbx_Puesto.Text, tbx_Motivo.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                tbx_Nombre.Clear()
                tbx_Empresa.Clear()
                tbx_Motivo.Clear()

                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                Cn_Reclutamiento.fn_Menu_Progreso(40)

            Else

                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento")
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        Else

            'Si se esta actualizando
            If fn_ListaNegra_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Nombre.Text, tbx_Empresa.Text, tbx_Puesto.Text, tbx_Motivo.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                tbx_Nombre.Clear()
                tbx_Empresa.Clear()
                tbx_Motivo.Clear()
                Tab_Nuevo.Text = "Nuevo"

                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
                Cn_Reclutamiento.fn_Menu_Progreso(40)

            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento")
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()
        Cn_Reclutamiento.fn_Menu_Progreso(50)

        'Aqui se Actualiza el listview
        Call LlenarLista()

        Cn_Reclutamiento.fn_Menu_Progreso(100)

        'Aqui se ocultan los botones
        btn_Modificar.Enabled = False

        'Aqui se limpia el contador de progreso
        Cn_Reclutamiento.fn_Menu_Progreso(0)
    End Sub

    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar
        'Aqui se ocultan y se muestran los botones de reporte
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

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        'Aqui se establece el texto del objeto seleccionado
        tbx_Nombre.Text = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        tbx_Empresa.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        tbx_Puesto.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        tbx_Motivo.Text = lsv_Catalogo.SelectedItems(0).SubItems(3).Text

        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Nuevo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Nuevo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub btn_Cerrar_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        Me.Cursor = Cursors.WaitCursor
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
        Me.Cursor = Cursors.Default
    End Sub

    Sub LlenarLista()
        lsv_Catalogo.Items.Clear()
        Me.Cursor = Cursors.WaitCursor
        If rdb_AE.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, Microsoft.VisualBasic.Left(rdb_AE.Text, 1), Microsoft.VisualBasic.Right(rdb_AE.Text, 1))
        ElseIf rdb_FJ.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, Microsoft.VisualBasic.Left(rdb_FJ.Text, 1), Microsoft.VisualBasic.Right(rdb_FJ.Text, 1))
        ElseIf rdb_KO.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, Microsoft.VisualBasic.Left(rdb_KO.Text, 1), Microsoft.VisualBasic.Right(rdb_KO.Text, 1))
        ElseIf rdb_PT.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, Microsoft.VisualBasic.Left(rdb_PT.Text, 1), Microsoft.VisualBasic.Right(rdb_PT.Text, 1))
        ElseIf rdb_UZ.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, Microsoft.VisualBasic.Left(rdb_UZ.Text, 1), Microsoft.VisualBasic.Right(rdb_UZ.Text, 1))
        ElseIf rdb_Todos.Checked Then
            fn_ListaNegra_LlenarLista(lsv_Catalogo, "A", "Z")
        End If
        Me.Cursor = Cursors.Default
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub rdb_AE_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_AE.CheckedChanged
        If rdb_AE.Checked Then Call LlenarLista()
    End Sub

    Private Sub rdb_FJ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_FJ.CheckedChanged
        If rdb_FJ.Checked Then Call LlenarLista()
    End Sub

    Private Sub rdb_KO_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_KO.CheckedChanged
        If rdb_KO.Checked Then Call LlenarLista()
    End Sub

    Private Sub rdb_PT_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_PT.CheckedChanged
        If rdb_PT.Checked Then Call LlenarLista()
    End Sub

    Private Sub rdb_UZ_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_UZ.CheckedChanged
        If rdb_UZ.Checked Then Call LlenarLista()
    End Sub

    Private Sub rdb_Todos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Todos.CheckedChanged
        If rdb_Todos.Checked Then
            If MsgBox("La consulta puede durar varios segundos extra cuando el catálogo es muy extenso. Desea continuar?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                Call LlenarLista()
            Else
                lsv_Catalogo.Items.Clear()
            End If
        End If
    End Sub

End Class