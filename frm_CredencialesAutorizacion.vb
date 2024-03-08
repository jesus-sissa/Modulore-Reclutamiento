Public Class frm_CredencialesAutorizacion

    Private Sub frm_CredencialesAutorizacion_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        rdb_Interno.Checked = True
        Call LlenarLista()
    End Sub

    Sub LlenarLista()
        btn_Cancelar.Enabled = False
        btn_Entregar.Enabled = False
        lsv_Catalogo.SelectedItems.Clear()
        btn_Detalle.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        'Aqui se llena la lista de Credenciales
        If rdb_Interno.Checked = True Then
            If Not Cn_Reclutamiento.fn_Credenciales_LlenarLista(lsv_Catalogo) Then
                MsgBox("Ha ocurrido un Error al intentar cargar la lista de Empleados Internos.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            If Not Cn_Reclutamiento.fn_Credenciales_LlenarListaXF(lsv_Catalogo) Then
                MsgBox("Ha ocurrido un Error al intentar cargar la lista de Empleados Externos.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
        lbl_Cuenta.Text = lsv_Catalogo.Items.Count() & " Registros"
        tbx_Buscar.Clear()
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        'Aqui se selecciona el objeto que coincida con el criterio de busqueda
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        FuncionesGlobales.fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        Dim FormaValida As New frm_FirmaElectronica
        FormaValida.ShowDialog()

        If FormaValida.Firma Then
            If Cn_Reclutamiento.fn_Credenciales_Actualizar("C", "C", lsv_Catalogo) Then
                MsgBox("Registros Cancelados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LlenarLista()
            Else
                MsgBox("No se pudo realizar la cancelación. Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("No se validó la Cancelación.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub lsv_Catalogo_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.DoubleClick
        Call Detalle()
    End Sub

    Private Sub btn_Detalle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Detalle.Click
        SegundosDesconexion = 0
        Call Detalle()
    End Sub

    Sub Detalle()
        lsv_Catalogo.SelectedItems(0).Checked = False
        'Dim Detalle As New frm_CredencialDetalleImprimir
        Dim Detalle As New frm_CredencialDetalleImprimirPlant 'plantilla

        If rdb_Externo.Checked Then Detalle.TipoEmpleado = 2
        Detalle.Id_Credencial = lsv_Catalogo.SelectedItems(0).Tag

        Detalle.ShowDialog()
    End Sub

    Private Sub btn_Entregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Entregar.Click
        SegundosDesconexion = 0
        Dim FormaValida As New frm_FirmaElectronica
        FormaValida.ShowDialog()

        If FormaValida.Firma Then
            If Cn_Reclutamiento.fn_Credenciales_Actualizar("E", "E", lsv_Catalogo) Then
                MsgBox("Registros modificados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                Call LlenarLista()
            Else
                MsgBox("No se pudo realizar la tarea. Consulte al Administrador del Sistema.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            MsgBox("No realizó ningún movimiento.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_ConfigPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConfigPrint.Click
        SegundosDesconexion = 0
        Dim dlg_Impresora As New PrintDialog()
        Dim dlg_Result As DialogResult
        dlg_Result = dlg_Impresora.ShowDialog

        If dlg_Result = Windows.Forms.DialogResult.OK Then
            My.Settings.Zebra = dlg_Impresora.PrinterSettings.PrinterName()
            My.Settings.Save()
        End If
    End Sub

    Private Sub rdb_Interno_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Interno.CheckedChanged
        Call LlenarLista()
    End Sub

    Private Sub lsv_Catalogo_ItemChecked(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Catalogo.ItemChecked
        btn_Cancelar.Enabled = lsv_Catalogo.CheckedItems.Count > 0
        btn_Entregar.Enabled = lsv_Catalogo.CheckedItems.Count > 0
    End Sub

    Private Sub lsv_Catalogo_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Catalogo.MouseMove
        SegundosDesconexion = 0
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        btn_Detalle.Enabled = lsv_Catalogo.SelectedItems.Count > 0
    End Sub
End Class