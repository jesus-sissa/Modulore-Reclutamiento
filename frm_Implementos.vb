Public Class frm_Implementos

    Dim IdImplemento As Integer

    Private Sub frm_Implementos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        lsv_Catalogo.Columns.Add("Descripción")
        lsv_Catalogo.Columns.Add("Precio")
        lsv_Catalogo.Columns.Add("Proveedor")
        lsv_Catalogo.Columns.Add("Status")
        cmb_Proveedores.Actualizar()

        'Aqui se llena la lista
        If Not Cn_Reclutamiento.fn_Implementos_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aqui se ocultan y se muestran los botones de reporte
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

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub lsv_Catalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.Click
        btn_Baja.Enabled = True
        btn_Modificar.Enabled = True
    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        'Aqui se filtra cuando el Color de Piel esta activa o baja
        If lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO" Then
            Cn_Reclutamiento.fn_Implementos_CambiarStatus(lsv_Catalogo.SelectedItems(0).Tag, "B")
        Else
            Cn_Reclutamiento.fn_Implementos_CambiarStatus(lsv_Catalogo.SelectedItems(0).Tag, "A")
        End If

        'Aqui se actualiza la lista
        lsv_Catalogo.Items.Clear()
        Cn_Reclutamiento.fn_Implementos_LlenarLista(lsv_Catalogo)

        'Aqui se ocultan los botones
        btn_Baja.Enabled = False
        btn_Modificar.Enabled = False
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        tbx_ClaveImplemento.Tag = lsv_Catalogo.SelectedItems(0).SubItems(0).Text

        'Aqui se establece el texto del objeto seleccionado
        tbx_ClaveImplemento.Text = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        tbx_Descripcion.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        tbx_Precio.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        cmb_Proveedores.SelectedValue = lsv_Catalogo.SelectedItems(0).SubItems(5).Text

        btn_Guardar.Enabled = True
        btn_Cancelar.Enabled = True

        'Aqui se cambia el titulo de la pestaña
        tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = tab_Nuevo
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        If Tab_Catalogo.SelectedIndex = 0 Then
            tab_Nuevo.Text = "Nuevo"

            tbx_ClaveImplemento.Clear()
            cmb_Proveedores.SelectedValue = 0
            tbx_Descripcion.Clear()
            tbx_Precio.Clear()

            btn_Baja.Enabled = False
            btn_Modificar.Enabled = False
        End If
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        tab_Nuevo.Text = "Nuevo"

        tbx_ClaveImplemento.Clear()
        cmb_Proveedores.SelectedValue = 0
        tbx_Descripcion.Clear()
        tbx_Precio.Clear()

        btn_Baja.Enabled = False
        btn_Modificar.Enabled = False
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If tbx_ClaveImplemento.Text = "" Then
            MsgBox("Capture la Clave.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ClaveImplemento.Focus()
            Exit Sub
        End If

        If tbx_Descripcion.Text = "" Then
            MsgBox("Capture la Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If cmb_Proveedores.SelectedValue = 0 Then
            MsgBox("Seleccione el Proveedor.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Proveedores.Focus()
            Exit Sub
        End If

        If tbx_Precio.Text = "" Then
            MsgBox("Capture el Precio.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Precio.Focus()
            Exit Sub
        End If

        If Not Cn_Reclutamiento.fn_Implementos_Validar(tbx_ClaveImplemento.Text, tbx_ClaveImplemento.Tag) Then
            'En caso de que la Clave ya exista en la base de datos
            MsgBox("La Clave ya existe.", MsgBoxStyle.Critical, frm_MENU.Text)

            tbx_ClaveImplemento.Clear()
            cmb_Proveedores.SelectedValue = 0
            tbx_Descripcion.Text = ""
            tbx_Precio.Text = ""
            tbx_Descripcion.Focus()
            Exit Sub
        Else
            'En caso de que todo sea valido y sea un registro nuevo
            If tab_Nuevo.Text = "Nuevo" Then

                IdImplemento = Cn_Reclutamiento.fn_Implementos_Nuevo(tbx_ClaveImplemento.Text, tbx_Descripcion.Text, tbx_Precio.Text, cmb_Proveedores.SelectedValue)
                If IdImplemento > 0 Then

                    If Cn_Reclutamiento.fn_ImplementosInventarios_Nuevo(IdImplemento) Then

                        'En caso de que se haya hecho la transaccion
                        Cn_Reclutamiento.fn_Menu_Progreso(30)

                        'Aqui se limpian los textbox
                        MsgBox("Los datos se han guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                        tbx_ClaveImplemento.Clear()
                        cmb_Proveedores.SelectedValue = 0
                        tbx_Descripcion.Clear()
                        tbx_Precio.Clear()

                        'Aqui se Ajusta el titulo de la pestaña
                        Tab_Catalogo.SelectedTab = tab_Listado
                        tab_Nuevo.Text = "Nuevo"
                        Cn_Reclutamiento.fn_Menu_Progreso(40)

                    Else

                        'En caso de que no se haya hecho la transaccion
                        MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Cn_Reclutamiento.fn_Menu_Progreso(0)

                    End If
                End If

            Else

                'Si se esta actualizando

                If Cn_Reclutamiento.fn_Implementos_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_ClaveImplemento.Text, tbx_Descripcion.Text, tbx_Precio.Text, cmb_Proveedores.SelectedValue, "A") Then

                    'En caso de que se haya hecho la transaccion
                    MsgBox("Registro Modificado.", MsgBoxStyle.Information, frm_MENU.Text)
                    Cn_Reclutamiento.fn_Menu_Progreso(30)

                    'Aqui se limpian los textbox
                    tbx_ClaveImplemento.Clear()
                    cmb_Proveedores.SelectedValue = 0
                    tbx_Precio.Clear()
                    tbx_Descripcion.Clear()
                    tab_Nuevo.Text = "Nuevo"

                    'Aqui se cambia la pestaña seleccionada
                    Tab_Catalogo.SelectedTab = tab_Listado
                    Cn_Reclutamiento.fn_Menu_Progreso(40)

                Else
                    'En caso de que no se haya hecho la transaccion
                    MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Cn_Reclutamiento.fn_Menu_Progreso(0)

                End If

            End If

        End If

        'Aqui se limpia el listview
        lsv_Catalogo.Items.Clear()
        Cn_Reclutamiento.fn_Menu_Progreso(50)

        'Aqui se Actualiza el listview
        Cn_Reclutamiento.fn_Implementos_LlenarLista(lsv_Catalogo)
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        Else
            btn_Exportar.Enabled = True
        End If
        Cn_Reclutamiento.fn_Menu_Progreso(100)

        'Aqui se ocultan los botones
        btn_Baja.Enabled = False
        btn_Modificar.Enabled = False

        'Aqui se limpia el contador de progreso
        Cn_Reclutamiento.fn_Menu_Progreso(0)

        'End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

End Class