Public Class frm_NotificacionAlertasD

    Public Id_Alerta As Integer
    Public Descripcion_Alerta As String

    Private Sub frm_NotificacionAlertasD_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Mostrar el detalle de la Alerta
        Me.Cursor = Cursors.WaitCursor
        If Not Cn_Notificaciones.fn_AlertasDetalle_LlenarLista(lsv_Datos, Id_Alerta) Then
            Me.Cursor = Cursors.Default
            btn_Exportar.Enabled = False
            MsgBox("Ocurrió un Error al intentar consultar los Datos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, Descripcion_Alerta & "  " & Date.Today.ToShortDateString & " - " & Date.Today.ToShortTimeString, 0, 0, frm_MENU.prg_Barra)
    End Sub

End Class