Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_EmpleadosCartas

    Private Sub frm_EmpleadosCartas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Status")
        lsv_Catalogo.Columns.Add("UltimaValidacion")


        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("B", "BAJAS")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()
        Call deshabilita_botones()
    End Sub

    Private Sub btn_MostrarCatalogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_MostrarCatalogo.Click
        Dim St As String = ""
        Me.Cursor = Cursors.WaitCursor

        If cmb_DepartamentoFiltro.Enabled AndAlso cmb_DepartamentoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DepartamentoFiltro.Focus()
            Exit Sub
        End If
        If cmb_PuestoFiltro.Enabled AndAlso cmb_PuestoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PuestoFiltro.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled AndAlso cmb_Status.SelectedValue = "0" Then
            MsgBox("Seleccione el Status para la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Status.Focus()
            Exit Sub
        End If
        If chk_Status.Checked Then
            St = "T"
        Else
            St = cmb_Status.SelectedValue
        End If

        If Not fn_Empleados_LlenarListaCartas(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, St) Then
            MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        For j As Byte = 6 To lsv_Catalogo.Columns.Count - 1
            lsv_Catalogo.Columns(j).Width = 0
        Next

        Me.Cursor = Cursors.Default
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

        Call deshabilita_botones()
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        'Llenar los Puestos
        lsv_Catalogo.Items.Clear()
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 AndAlso Not chk_DepartamentoFiltro.Checked Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_DepartamentoFiltro.SelectedValue = 0
        cmb_DepartamentoFiltro.Enabled = Not chk_DepartamentoFiltro.Checked

        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 AndAlso Not chk_DepartamentoFiltro.Checked Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
        Call deshabilita_botones()
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
        Call deshabilita_botones()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            If lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "BAJA" Then
                btn_CartaRecomendacion.Enabled = True
                btn_CartaBecas.Enabled = False
                btn_ConstanciaBaja.Enabled = True
                btn_ConstanciaIngresos.Enabled = False
            Else
                btn_CartaRecomendacion.Enabled = False
                btn_CartaBecas.Enabled = True
                btn_ConstanciaBaja.Enabled = False
                btn_ConstanciaIngresos.Enabled = True
            End If
        Else
            Call deshabilita_botones()
        End If
    End Sub

    Sub deshabilita_botones()
        btn_CartaRecomendacion.Enabled = False
        btn_CartaBecas.Enabled = False
        btn_ConstanciaBaja.Enabled = False
        btn_ConstanciaIngresos.Enabled = False
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub btn_ConstanciaBaja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConstanciaBaja.Click
        SegundosDesconexion = 0

        '------llenat DT del Dataset
        Dim Ds As New ds_OtrasCartas
        Call fn_Empleados_ReporteCartasImprimir(lsv_Catalogo.SelectedItems(0).Tag, Ds.Cat_Empleados_GetCartasRpt)

        If Ds.Cat_Empleados_GetCartasRpt IsNot Nothing AndAlso _
        Ds.Cat_Empleados_GetCartasRpt.Rows.Count > 0 Then

            Dim Ciudad As String = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("Ciudad")
            Dim Fecha2 As String, FechaIngreso As Date, FechaFin As Date
            Dim FechaI As String, FechaF As String
            Fecha2 = (Today.ToString("D", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper

            Dim frm As New frm_Reporte
            Dim crystal As New rpt_ConstaciaBaja
            frm.crv.ReportSource = crystal

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With crystal.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top
                    Dim Left_Obj As Integer = .Left '+- 342default
                    Dim Width_Obj As Integer = .Width '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}

            crystal.SetDataSource(Ds)
            With crystal
                .SetParameterValue("Fecha", Ciudad & " ," & Fecha2)

                FechaIngreso = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaIngreso")
                FechaI = (FechaIngreso.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_Ingreso", FechaI)

                FechaFin = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaBaja")
                FechaF = (FechaFin.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_FinLabores", FechaF)

            End With
            frm.ShowDialog()
        End If
    End Sub

    Private Sub btn_ConstanciaIngresos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ConstanciaIngresos.Click
        SegundosDesconexion = 0

        '------llenat DT del Dataset
        Dim Ds As New ds_OtrasCartas
        Call fn_Empleados_ReporteCartasImprimir(lsv_Catalogo.SelectedItems(0).Tag, Ds.Cat_Empleados_GetCartasRpt)

        If Ds.Cat_Empleados_GetCartasRpt IsNot Nothing AndAlso _
        Ds.Cat_Empleados_GetCartasRpt.Rows.Count > 0 Then

            Dim Ciudad As String = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("Ciudad")
            Dim Fecha2 As String, FechaIngreso As Date, FechaI As String, ImporteLetra As String
            Fecha2 = (Today.ToString("D", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper

            Dim frm As New frm_Reporte
            Dim crystal As New rpt_ConstaciaIngresos
            frm.crv.ReportSource = crystal

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With crystal.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top '120
                    Dim Left_Obj As Integer = .Left '+- 342default '240
                    Dim Width_Obj As Integer = .Width '1440Default
                    Dim Height_Obj As Integer = .Height '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Height_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}

            crystal.SetDataSource(Ds)
            With crystal
                .SetParameterValue("Fecha", Ciudad & " ," & Fecha2)

                FechaIngreso = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaIngreso")
                FechaI = (FechaIngreso.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_Ingreso", FechaI)

                ImporteLetra = FuncionesGlobales.fn_EnLetras(Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("sueldoDiario"), 0)
                .SetParameterValue("Salario_D_Letra", ImporteLetra)

                .SetParameterValue("Salario_DI", CDec(Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("sueldoDiario") * 1.0452)) 'Salario_DI Pendiente
                ImporteLetra = FuncionesGlobales.fn_EnLetras((CDec(Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("sueldoDiario")) * 1.0452), 0)
                .SetParameterValue("Salario_DI_Letra", ImporteLetra)
            End With
            frm.ShowDialog()

        End If
        '-*-----------------------------
    End Sub

    Private Sub btn_CartaBecas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CartaBecas.Click
        SegundosDesconexion = 0

        '------llenat DT del Dataset
        Dim Ds As New ds_OtrasCartas
        Call fn_Empleados_ReporteCartasImprimir(lsv_Catalogo.SelectedItems(0).Tag, Ds.Cat_Empleados_GetCartasRpt)

        If Ds.Cat_Empleados_GetCartasRpt IsNot Nothing AndAlso _
        Ds.Cat_Empleados_GetCartasRpt.Rows.Count > 0 Then

            Dim Ciudad As String = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("Ciudad")
            Dim Fecha2 As String, FechaIngreso As Date, FechaI As String, ImporteLetra As String
            Fecha2 = (Today.ToString("D", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper

            Dim frm As New frm_Reporte
            Dim crystal As New rpt_CartaParaBecas
            frm.crv.ReportSource = crystal

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With crystal.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top
                    Dim Left_Obj As Integer = .Left '+- 342default
                    Dim Width_Obj As Integer = .Width '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}
            crystal.SetDataSource(Ds)
            With crystal
                .SetParameterValue("Fecha", Ciudad & " ," & Fecha2)

                FechaIngreso = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaIngreso")
                FechaI = (FechaIngreso.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_Ingreso", FechaI)

                .SetParameterValue("Salario_Mensual", CDec(Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("sueldoDiario")) * 30.5) 'salarioMensual
                ImporteLetra = FuncionesGlobales.fn_EnLetras((CDec(Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("sueldoDiario")) * 30.5), 0)
                .SetParameterValue("Importe_Letra", ImporteLetra)
            End With
            frm.ShowDialog()
        End If


    End Sub

    Private Sub btn_CartaRecomendacion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CartaRecomendacion.Click
        SegundosDesconexion = 0

        '------llenat DT del Dataset
        Dim Ds As New ds_OtrasCartas
        Call fn_Empleados_ReporteCartasImprimir(lsv_Catalogo.SelectedItems(0).Tag, Ds.Cat_Empleados_GetCartasRpt)

        If Ds.Cat_Empleados_GetCartasRpt IsNot Nothing AndAlso _
        Ds.Cat_Empleados_GetCartasRpt.Rows.Count > 0 Then

            Dim Ciudad As String = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("Ciudad")
            Dim Fecha2 As String, FechaIngreso As Date, FechaFin As Date
            Dim FechaI As String, FechaF As String
            Fecha2 = (Today.ToString("D", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper

            Dim frm As New frm_Reporte
            Dim crystal As New rpt_CartaRecomendacion
            frm.crv.ReportSource = crystal

            '--------------pruebas de imagen en reportes {
            If Not IsDBNull(Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")) Then

                Dim imagenNueva As Image = Nothing
                Dim imagenBytes As Byte() = Ds.Cat_Empleados_GetCartasRpt.Rows(0)("logoEmpresa")
                Dim ms_ByteToImagen As New IO.MemoryStream(imagenBytes)
                imagenNueva = Image.FromStream(ms_ByteToImagen, True)

                Dim Ancho As Integer = imagenNueva.Width
                Dim Alto As Integer = imagenNueva.Height
                Dim valordiv As Decimal = 0.0

                With crystal.ReportDefinition.Sections("Section1").ReportObjects("Logo")

                    Dim Top_Obj As Integer = .Top
                    Dim Left_Obj As Integer = .Left '+- 342default
                    Dim Width_Obj As Integer = .Width '1440Default

                    If Ancho > Alto Then valordiv = Width_Obj / Ancho Else valordiv = Width_Obj / Alto
                    Dim nuevoAncho As Integer = Ancho * valordiv
                    Dim NuevoAlto As Integer = Alto * valordiv

                    If Ancho > Alto Then
                        'horizontal
                        Top_Obj = Top_Obj + ((Width_Obj - NuevoAlto) / 2)
                        .Top = Top_Obj
                    Else
                        'vertical,cuadrado
                        Left_Obj = Left_Obj + ((Width_Obj - nuevoAncho) / 2)
                        .Left = Left_Obj
                    End If
                    .Width = nuevoAncho
                    .Height = NuevoAlto
                End With

                '-------liberar objetos
                ms_ByteToImagen.Dispose()
                imagenNueva.Dispose()
            End If
            '--------------}

            crystal.SetDataSource(Ds)
            With crystal
                .SetParameterValue("Fecha", Ciudad & " ," & Fecha2)

                FechaIngreso = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaIngreso")
                FechaI = (FechaIngreso.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_Ingreso", FechaI)

                FechaFin = Ds.Cat_Empleados_GetCartasRpt.Rows(0).Item("FechaBaja")
                FechaF = (FechaFin.ToString("dd " + """de""" + " MMMM " + """de""" + " yyyy", Globalization.CultureInfo.CreateSpecificCulture("es-MX"))).ToUpper
                .SetParameterValue("Fecha_FinLabores", FechaF)

            End With
            frm.ShowDialog()
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        Call deshabilita_botones()
    End Sub

End Class
