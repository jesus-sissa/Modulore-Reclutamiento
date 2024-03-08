

Public Class frm_TipoSangre

    Private Sub frm_TipoSangre_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'Aqui se llena la lista
        If Not Cn_Reclutamiento.fn_TipoSangre_LlenarLista(lsv_Catalogo) Then
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
            'btn_Imprimir.Enabled = False
        Else
            btn_Exportar.Enabled = True
            'btn_Imprimir.Enabled = True
        End If

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
        'Aquí se actualizan el combo

        cmb_Tipo.AgregarItem("P", "POSITIVO")
        cmb_Tipo.AgregarItem("N", "NEGATIVO")

    End Sub


    Private Sub frm_TipoSangre_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
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

    Private Sub lsv_Catalogo_AlActualizar() Handles lsv_Catalogo.AlActualizar

        'Aqui se ocultan y se muestran los botones de reporte
        If lsv_Catalogo.Items.Count = 0 Then
            btn_Exportar.Enabled = False
            'btn_Imprimir.Enabled = False
        Else
            btn_Exportar.Enabled = True
            'btn_Imprimir.Enabled = True
        End If

    End Sub


    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If tbx_Grupo.Text = "" Then
            MsgBox("Capture el Grupo.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Grupo.Focus()
            Exit Sub
        End If

        If cmb_Tipo.SelectedValue = "" Or cmb_Tipo.SelectedValue = "0" Then
            MsgBox("Seleccione el Tipo.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Tipo.Focus()
            Exit Sub
        End If

        If Not Cn_Reclutamiento.fn_TipoSangre_Validar(tbx_Grupo.Text, cmb_Tipo.SelectedValue) Then

            'En caso de que El grupo y tipo de sangre ya existan en la base de datos
            MsgBox("El Grupo y Tipo ya existen.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Grupo.Text = ""
            cmb_Tipo.SelectedValue = "0"

        Else

            'Si se esta Insertando
            If Cn_Reclutamiento.fn_TipoSangre_Nuevo(tbx_Grupo.Text, cmb_Tipo.SelectedValue) Then

                'En caso de que se haya hecho la transaccion
                Cn_Reclutamiento.fn_Menu_Progreso(30)

                'Aqui se limpian los datos
                MsgBox("Los datos se han guardado correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                tbx_Grupo.Text = ""
                cmb_Tipo.SelectedValue = "0"

                'Aqui se Ajusta el titulo de la pestaña
                Tab_Nuevo.Text = "Nuevo"
                Cn_Reclutamiento.fn_Menu_Progreso(40)

                'Aqui se limpia el listview
                lsv_Catalogo.Items.Clear()
                Cn_Reclutamiento.fn_Menu_Progreso(50)

                'Aqui se Actualiza el listview
                Cn_Reclutamiento.fn_TipoSangre_LlenarLista(lsv_Catalogo)
                If lsv_Catalogo.Items.Count = 0 Then
                    btn_Exportar.Enabled = False
                    'btn_Imprimir.Enabled = False
                Else
                    btn_Exportar.Enabled = True
                    'btn_Imprimir.Enabled = True
                End If
                Cn_Reclutamiento.fn_Menu_Progreso(100)

                'Aqui se limpia el contador de progreso
                Cn_Reclutamiento.fn_Menu_Progreso(0)


            Else

                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Cn_Reclutamiento.fn_Menu_Progreso(0)

            End If

        End If

    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click

        'Aqui se limpian los datos

        tbx_Grupo.Text = ""
        cmb_Tipo.SelectedValue = 0

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"

    End Sub


    Private Sub lsv_Catalogo_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class