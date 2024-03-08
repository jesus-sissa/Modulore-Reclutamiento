
Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_UnidadesMedicoFamiliares

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click

        'Aqui se cierra la ventana
        Me.Close()

    End Sub

    Private Sub frm_UnidadesMedicoFamiliares_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Aqui se llena la lista
        fn_UMF_LlenarLista(lsv_Catalogo)
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click

        'Aqui se limpian los textbox
        tbx_UMF.Tag = 0
        tbx_UMF.Clear()
        tbx_Municipio.Clear()
        tbx_CP.Clear()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If tbx_UMF.Text = "" Then tbx_UMF.Text = 0
        If tbx_CP.Text = "" Then tbx_CP.Text = 0

        If tbx_UMF.Text = 0 Then
            MsgBox("Capture el Número de UMF.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_UMF.Focus()
            Exit Sub
        End If

        If tbx_Municipio.Text = "" Then
            MsgBox("Capture el Municipio.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Municipio.Focus()
            Exit Sub
        End If

        If tbx_CP.Text = 0 Then
            MsgBox("Capture el Código Postal.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_CP.Focus()
            Exit Sub
        End If

        'En caso de que todo sea valido
        If Tab_Nuevo.Text = "Nuevo" Then

            If Not fn_UMF_Validar(tbx_UMF.Text) Then
                'En caso de que el número de UMF ya exista en la base de datos
                MsgBox("UMF ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)
                'tbx_UMF.Text = 0
                tbx_UMF.Focus()
                Exit Sub
            End If

            'Si se esta Insertando
            If fn_UMF_Nuevo(tbx_UMF.Text, tbx_Municipio.Text, tbx_CP.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                tbx_UMF.Tag = 0
                tbx_UMF.Clear()
                tbx_Municipio.Clear()
                tbx_CP.Clear()

                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                Cn_Reclutamiento.fn_Menu_Progreso(40)

            Else

                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        Else

            'Si se esta actualizando
            If fn_UMF_Actualizar(tbx_UMF.Tag, tbx_UMF.Text, tbx_Municipio.Text, tbx_CP.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                tbx_UMF.Tag = 0
                tbx_UMF.Clear()
                tbx_Municipio.Clear()
                Tab_Nuevo.Text = "Nuevo"

                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado
                Cn_Reclutamiento.fn_Menu_Progreso(40)

            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()
        Cn_Reclutamiento.fn_Menu_Progreso(50)

        'Aqui se Actualiza el listview
        fn_UMF_LlenarLista(lsv_Catalogo)

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
        tbx_UMF.Tag = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        tbx_UMF.Text = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        tbx_Municipio.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        tbx_CP.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text

        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo

    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub Tab_Nuevo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Nuevo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub
End Class