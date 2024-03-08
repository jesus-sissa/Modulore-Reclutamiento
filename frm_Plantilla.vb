Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_Plantilla
    Public Cont As Integer = 0
    Dim dt As DataTable
    Dim ValorAnterior As Integer
    Dim existe As Boolean = False
    Dim DeptoId As Integer

    Private Sub frm_Plantilla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        tbx_Puesto.Tag = 0
        DeptoId = fn_PlantillaConsulta_ObtenerDepto()

        Call Fn_Plantilla_Recalculo()
        Call LlenarLista()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        Me.Close()
    End Sub

    Sub Guardar()
        If Not fn_PlantillaDepartamento_Guardar(tbx_Puesto.Tag, CInt(tbx_PlantillaRequerida.Text), CInt(tbx_PlantillaActual.Text)) Then
            MsgBox("Ocurrió un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            MsgBox("Registros guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Call LlenarLista()
        End If
    End Sub

    Sub LlenarLista()
        Dim TotalReq As Integer = 0
        Dim TotalAct As Integer = 0
        lsv_Puestos.Items.Clear()
        Call Valores_Tbx_Cmb()
        Call Botones()
        fn_PlantillaDepartamento_LlenarLista(lsv_Puestos)
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Puestos.Items.Count)
        For Each Fila As ListViewItem In lsv_Puestos.Items
            TotalReq += CInt(Fila.SubItems(2).Text)
            TotalAct += CInt(Fila.SubItems(3).Text)
        Next

        lsv_Puestos.Items.Add("")

        Dim FilaN As ListViewItem = lsv_Puestos.Items(lsv_Puestos.Items.Count - 1)
        FilaN.SubItems.Add("TOTALES")
        FilaN.SubItems.Add(TotalReq)
        FilaN.SubItems.Add(TotalAct)
        FilaN.SubItems.Add(TotalReq - TotalAct)
    End Sub

    Sub Valores_Tbx_Cmb()
        tbx_Depto.Text = ""
        tbx_Depto.Text = 0
        tbx_Puesto.Text = ""
        tbx_Puesto.Text = 0
        tbx_PlantillaRequerida.Text = 0
        tbx_PlantillaActual.Text = 0
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click

        lsv_Puestos.Items(Cont).Remove() 'remueve item
        Call Guardar()
        Call Botones()
        btn_Cancelar.Enabled = False
        btn_Agregar.Enabled = False
        tbx_PlantillaRequerida.Enabled = False

    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click

        If lsv_Puestos.SelectedItems(0).SubItems(1).Text = "TOTALES" Then
            tbx_PlantillaRequerida.Enabled = False
            tbx_Depto.Text = 0
            tbx_Puesto.Text = 0
            tbx_PlantillaActual.Text = 0
            tbx_PlantillaRequerida.Text = 0
            Exit Sub
        End If
        tbx_Puesto.Tag = lsv_Puestos.SelectedItems(0).Tag
        btn_Agregar.Enabled = True
        tbx_PlantillaRequerida.Enabled = True
        tbx_Depto.Text = lsv_Puestos.SelectedItems(0).SubItems(0).Text
        tbx_Puesto.Text = lsv_Puestos.SelectedItems(0).SubItems(1).Text
        tbx_PlantillaRequerida.Text = lsv_Puestos.SelectedItems(0).SubItems(2).Text
        tbx_PlantillaActual.Text = lsv_Puestos.SelectedItems(0).SubItems(3).Text

        btn_Cancelar.Enabled = True
        Call Botones()
    End Sub

    Sub Botones()
        btn_Modificar.Enabled = False
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Puestos.Items.Count)
    End Sub

    Private Sub cmb_Puestos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        tbx_PlantillaRequerida.Clear()
        tbx_PlantillaActual.Clear()
    End Sub

    Private Sub lsv_Puestos_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Puestos.DoubleClick
        If lsv_Puestos.SelectedItems(0).SubItems(1).Text = "TOTALES" Then
            tbx_PlantillaRequerida.Enabled = False
            tbx_Depto.Text = 0
            tbx_Puesto.Text = 0
            tbx_PlantillaActual.Text = 0
            tbx_PlantillaRequerida.Text = 0
            Exit Sub
        End If
        btn_Modificar.PerformClick()
        tbx_PlantillaRequerida.Enabled = True
        btn_Agregar.Enabled = True
    End Sub

    Private Sub lsv_Puestos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puestos.SelectedIndexChanged
        btn_Modificar.Enabled = lsv_Puestos.SelectedItems.Count > 0
    End Sub

    Private Sub lsv_Puestos_MouseHover(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Puestos.MouseHover
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        Call Valores_Tbx_Cmb()
        lsv_Puestos.SelectedItems.Clear()
        Call Botones()
        tbx_PlantillaRequerida.Enabled = False
        btn_Agregar.Enabled = False
        btn_Cancelar.Enabled = False

        tbx_Depto.Focus()
    End Sub
End Class