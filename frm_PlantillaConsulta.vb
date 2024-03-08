Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_PlantillaConsulta

    Private Sub frm_PlantillaConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        fn_PlantillaConsulta_LlenarLista(lsv_Datos)
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Datos.Items.Count)

        lsv_Empleados.Columns.Add("Clave")
        lsv_Empleados.Columns.Add("Nombre")
        lsv_Empleados.Columns.Add("Departamento")
        lsv_Empleados.Columns.Add("Puesto")

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Private Sub lsv_Datos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.SelectedIndexChanged
        'Consultar los Empleados por el Id_Plantilla
        If lsv_Datos.SelectedItems.Count > 0 Then
            If Not fn_PlantillaConsulta_LlenarListaD(lsv_Empleados, lsv_Datos.SelectedItems(0).SubItems(4).Text, lsv_Datos.SelectedItems(0).SubItems(5).Text) Then
                MsgBox("Ocurrió un error al intentar consultar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Else
            lsv_Empleados.Items.Clear()
        End If
    End Sub

    Private Sub lsv_Datos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Datos.MouseHover, lsv_Empleados.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub
End Class