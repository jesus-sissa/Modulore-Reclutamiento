Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_DocumentosXempleado

    Private Sub frm_DocumentosXempleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Status.AgregarItem("A", "ACTIVO")
        cmb_Status.AgregarItem("B", "BAJA")
        cmb_Status.AgregarItem("T", "TODOS")

        lsv_Datos.Columns.Add("Clave")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Ingreso")
        lsv_Datos.Columns.Add("Departamento")
        lsv_Datos.Columns.Add("Puesto")
        lsv_Datos.Columns.Add("Documento")
        lsv_Datos.Columns.Add("RegDocumento")
        lsv_Datos.Columns.Add("UsuarioDocumento")
        lsv_Datos.Columns.Add("Imagen")
        lsv_Datos.Columns.Add("UsuarioEscanea")
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub


    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        'Consultar lod Documentos Requeridos
        SegundosDesconexion = 0

        btn_Exportar.Enabled = False
        lsv_Datos.Items.Clear()
        Lbl_Numero.Text = "Registros: 0"
        If dtp_FechaDesde.Value.Date > dtp_FechaHasta.Value.Date Then
            MsgBox("El rango de fechas parece ser Incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            dtp_FechaDesde.Focus()
            Exit Sub
        End If
        If DateDiff(DateInterval.Day, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date) > 366 Then
            MsgBox("El rango de fechas no debe ser mayor a un año.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            dtp_FechaDesde.Focus()
            Exit Sub
        End If
        If cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione un Status para filtrar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            SegundosDesconexion = 0
            cmb_Status.Focus()
            Exit Sub
        End If
        Dim dt_Doctos As DataTable
        Dim dt_Empleados As DataTable

        dt_Doctos = fn_DoctosRequeridos_Consultar("A")
        If dt_Doctos Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar el catálogo de Documentos Requeridos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Doctos.Rows.Count = 0 Then
            MsgBox("No se encontraron elementos en el catálogo de Documentos Requeridos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'Consultar todos los documentos por Empleado
        dt_Empleados = fn_DoctosXempleado_Consultar(dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, cmb_Status.SelectedValue)
        If dt_Empleados Is Nothing Then
            MsgBox("Ocurrió un error al intentar consultar el catálogo de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If dt_Empleados.Rows.Count = 0 Then
            MsgBox("No se encontraron elementos en el catálogo de Documentos por Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If



        Dim EmpleadoAnterior As String = ""
        Dim DocumentoAnterior As String = ""
        Dim vista As DataView = New DataView(dt_Empleados)

        'Recorrer la lista para mostrarla en el Listview
        For Each Empleado As DataRow In dt_Empleados.Rows
            If EmpleadoAnterior <> Empleado("Clave") Then
                EmpleadoAnterior = Empleado("Clave")
                lsv_Datos.Items.Add(Empleado("Clave"))
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).Tag = Empleado("Id_Empleado")
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Empleado("Nombre"))
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Empleado("Ingreso"))
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Empleado("Departamento"))
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Empleado("Puesto"))
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                For Each Docto As DataRow In dt_Doctos.Rows
                    lsv_Datos.Items.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).Tag = Docto("Id_DoctoR")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add(Docto("Descripcion"))
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                    lsv_Datos.Items(lsv_Datos.Items.Count - 1).SubItems.Add("")
                Next

            End If
        Next

        Dim Dr_Filtrado() As DataRow
        EmpleadoAnterior = ""
        For Each Elemento As ListViewItem In lsv_Datos.Items
            If Elemento.Text <> "" Then
                EmpleadoAnterior = Elemento.Tag
                Dr_Filtrado = dt_Empleados.Select("Id_Empleado=" & EmpleadoAnterior)
            Else
                'recorrer cada documento y buscarlo en la tabla
                For iLocal As Integer = 0 To Dr_Filtrado.Length - 1
                    If Dr_Filtrado(iLocal)("Documento") = Elemento.SubItems(5).Text Then
                        Elemento.SubItems(6).Text = Dr_Filtrado(iLocal)("RegDocumento")
                        Elemento.SubItems(7).Text = Dr_Filtrado(iLocal)("UsuarioDocumento")
                        Elemento.SubItems(8).Text = Dr_Filtrado(iLocal)("Imagen")
                        Elemento.SubItems(9).Text = Dr_Filtrado(iLocal)("UsuarioEscanea")
                        Exit For
                    End If
                Next
            End If
        Next
        btn_Exportar.Enabled = lsv_Datos.Items.Count > 0
        Lbl_Numero.Text = "Registros: " & lsv_Datos.Items.Count.ToString
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0
        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 3, "DOCUMENTOS POR EMPLEADO", 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        SegundosDesconexion = 0
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        SegundosDesconexion = 0
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        SegundosDesconexion = 0
    End Sub
End Class