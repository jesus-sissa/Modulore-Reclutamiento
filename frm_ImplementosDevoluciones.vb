
Public Class frm_ImplementosDevoluciones

    Private Sub frm_ImplementosDevoluciones_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub frm_ImplementosDevoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Empleado.AgregaParametro("@Id_Puesto", -1, 1)
        cmb_Empleado.Actualizar()
        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

        dgv_ImplementosDevolucion.Columns(0).Width = 0
        dgv_ImplementosDevolucion.Columns(0).Visible = False
        dgv_ImplementosDevolucion.Columns(1).Width = 200
        dgv_ImplementosDevolucion.Columns(2).Width = 120
        dgv_ImplementosDevolucion.Columns(3).Width = 200
        dgv_ImplementosDevolucion.Columns(4).Width = 120
        dgv_ImplementosDevolucion.Columns(5).Width = 200
        dgv_ImplementosDevolucion.Columns(6).Width = 0
        dgv_ImplementosDevolucion.Columns(6).Visible = False
    End Sub

    Private Sub cmb_Empleado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Empleado.SelectedValueChanged
        dgv_ImplementosDevolucion.DataSource = Cn_Reclutamiento.fn_ImpementosDevolucion_ObtenValores(cmb_Empleado.SelectedValue)

        If dgv_ImplementosDevolucion.Rows.Count > 0 Then
            dgv_ImplementosDevolucion.Columns(0).ReadOnly = True
            dgv_ImplementosDevolucion.Columns(1).ReadOnly = True
            dgv_ImplementosDevolucion.Columns(2).ReadOnly = True
            dgv_ImplementosDevolucion.Columns(3).ReadOnly = True
            dgv_ImplementosDevolucion.Columns(6).ReadOnly = True
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

    Private Sub dgv_ImplementosDevolucion_DataError(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewDataErrorEventArgs) Handles dgv_ImplementosDevolucion.DataError
        MsgBox("Tipo de datos incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click

        If tbx_Clave.Text = "" Then
            MsgBox("Capture la Clave del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If Cn_Reclutamiento.fn_ImplementosInventario_Actualizar(cmb_Empleado.SelectedValue, dgv_ImplementosDevolucion.DataSource) Then
            'En caso de que se haya hecho la transaccion
            MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            ' tbx_Clave.Text = 0
            tbx_Clave.Focus()
        Else
            MsgBox("Ha ocurrido un error al intentar cargar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

    End Sub

    Private Sub dgv_ImplementosDevolucion_CellValidating(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellValidatingEventArgs) Handles dgv_ImplementosDevolucion.CellValidating
        Dim Fila As Integer = dgv_ImplementosDevolucion.CurrentCell.RowIndex

        If IsNumeric(e.FormattedValue) AndAlso dgv_ImplementosDevolucion.CurrentCell.ColumnIndex = 4 AndAlso e.FormattedValue > dgv_ImplementosDevolucion.Rows(Fila).Cells(2).Value Then
            MsgBox("La Cantidad de Devolución debe ser menor a la Cantidad Asignada.", MsgBoxStyle.Critical, frm_MENU.Text)
            e.Cancel = True
            dgv_ImplementosDevolucion.CancelEdit()
        End If
    End Sub

    Private Sub dgv_ImplementosDevolucion_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dgv_ImplementosDevolucion.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedIndexChanged
        If cmb_PuestoFiltro.Items.Count > 0 Then

            If cmb_PuestoFiltro.SelectedValue = 0 Then
                cmb_Empleado.ActualizaValorParametro("@Id_Puesto", -1)
            Else
                cmb_Empleado.ActualizaValorParametro("@Id_Puesto", cmb_PuestoFiltro.SelectedValue)
            End If
            cmb_Empleado.Actualizar()

        End If
    End Sub

End Class