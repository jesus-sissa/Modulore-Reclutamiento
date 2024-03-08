
Public Class frm_MotivosBaja


    Private Sub frm_MotivosBaja_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Aqui se llena la lista de Motivos de Baja (Empleados)
        If Not Cn_Reclutamiento.fn_MotivosBaja_LlenarLista(lsv_Catalogo) Then
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


    Private Sub frm_MotivosBaja_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress
        SegundosDesconexion = 0

        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If

    End Sub


    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)

    End Sub

    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar

        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
        Else
            btn_Exportar.Enabled = True
        End If

    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)

    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        'Aqui se establece el texto del objeto seleccionado
        tbx_Status.Enabled = False
        tbx_Descripcion.Text = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        tbx_Status.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text

        btn_Guardar.Enabled = True
        btn_Cancelar.Enabled = True

        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo

    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        SegundosDesconexion = 0
        'Aqui se filtra cuando el Motivo de Baja esta Activo o Baja 
        If lsv_Catalogo.SelectedItems(0).SubItems(2).Text = "ACTIVO" Then
            Cn_Reclutamiento.fn_MotivosBaja_CambiarStatus(lsv_Catalogo.SelectedItems(0).Tag, "B")
        Else
            Cn_Reclutamiento.fn_MotivosBaja_CambiarStatus(lsv_Catalogo.SelectedItems(0).Tag, "A")
        End If

        'corregido subitem era (2) y no (3) 31/03/2015
        lsv_Catalogo.Items.Clear()
        Cn_Reclutamiento.fn_MotivosBaja_LlenarLista(lsv_Catalogo)

        'Aqui se ocultan los botones
        btn_Baja.Enabled = False
        btn_Modificar.Enabled = False

    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If tbx_Descripcion.Text = "" Then
            MsgBox("Capture la Descripción.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        If Tab_Nuevo.Text = "Nuevo" Then
            'Si es un Motivo de Baja nuevo
            If Cn_Reclutamiento.fn_MotivosBaja_Nuevo(tbx_Descripcion.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                MsgBox("Los datos se han guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                tbx_Descripcion.Clear()
                tbx_Status.Clear()

                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"

                'Aqui se cambia la pestaña seleccionada
                Tab_Catalogo.SelectedTab = tab_Listado

                Cn_Reclutamiento.fn_Menu_Progreso(50)
                Cn_Reclutamiento.fn_Menu_Progreso(100)
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            Else

                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        Else

            'Si se esta actualizando

            If Cn_Reclutamiento.fn_MotivosBaja_Actualizar(lsv_Catalogo.SelectedItems(0).Tag, tbx_Descripcion.Text) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los textbox
                tbx_Status.Clear()
                tbx_Descripcion.Clear()
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
        Cn_Reclutamiento.fn_MotivosBaja_LlenarLista(lsv_Catalogo)
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

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        tbx_Descripcion.Text = ""
        tbx_Status.Text = ""

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged

        If Tab_Catalogo.SelectedTab.Text = "Nuevo" Then
            tbx_Status.Text = "ACTIVO"
        End If

    End Sub

    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Baja.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub

End Class