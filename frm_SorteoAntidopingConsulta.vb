Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_SorteoAntidopingConsulta

    Private Sub frm_SorteoAntidopingConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        lsv_Sorteos.Clear()
        lsv_Sorteos.Columns.Add("Fecha")
        lsv_Sorteos.Columns.Add("Hora")
        lsv_Sorteos.Columns.Add("Departamento")
        lsv_Sorteos.Columns.Add("Puesto")
        lsv_Sorteos.Columns.Add("Dias Filtrados")
        lsv_Sorteos.Columns.Add("Total Disponibles")
        lsv_Sorteos.Columns.Add("Total Seleccionados")
        lsv_Sorteos.Columns.Add("Total Sorteados")
        lsv_Sorteos.Columns.Add("Usuario Autoriza")
        lsv_Sorteos.Columns.Add("Estacion Autoriza")
        lsv_Sorteos.Columns.Add("Status")

        lsv_Disponibles.Clear()
        lsv_Disponibles.Columns.Add("Clave")
        lsv_Disponibles.Columns.Add("Empleado")
        lsv_Disponibles.Columns.Add("Departamento")
        lsv_Disponibles.Columns.Add("Puesto")

        lsv_Seleccionados.Clear()
        lsv_Seleccionados.Columns.Add("Clave")
        lsv_Seleccionados.Columns.Add("Empleado")
        lsv_Seleccionados.Columns.Add("Departamento")
        lsv_Seleccionados.Columns.Add("Puesto")

        lsv_Sorteados.Clear()
        lsv_Sorteados.Columns.Add("Clave")
        lsv_Sorteados.Columns.Add("Empleado")
        lsv_Sorteados.Columns.Add("Departamento")
        lsv_Sorteados.Columns.Add("Puesto")

        Call Limpiar_Sorteos()

    End Sub

    Sub Limpiar_Resultado()
        lsv_Disponibles.Items.Clear()
        lbl_RegistrosDisponibles.Text = "Registros: 0"
        lsv_Seleccionados.Items.Clear()
        lbl_RegistrosSeleccionados.Text = "Registros: 0"
        lsv_Sorteados.Items.Clear()
        lbl_RegistrosSorteados.Text = "Registros: 0"
    End Sub

    Sub Limpiar_Sorteos()
        lsv_Sorteos.Items.Clear()
        lbl_RegistrosSorteos.Text = "Registros: 0"
        Call Limpiar_Resultado()
        Call Botones()
    End Sub

    Sub Botones()
        btn_Exportar.Enabled = lsv_Sorteos.SelectedItems.Count > 0 AndAlso lsv_Sorteos.SelectedItems(0).SubItems(10).Text = "ACTIVO"
        btn_Cancelar.Enabled = lsv_Sorteos.SelectedItems.Count > 0 AndAlso lsv_Sorteos.SelectedItems(0).SubItems(10).Text = "ACTIVO"
    End Sub

    Sub MostrarDetalle()

        If lsv_Sorteos.SelectedItems.Count > 0 Then
            Dim Dt_Detalle As DataTable = fn_SorteoAntidopingConsulta_Detalle(lsv_Sorteos.SelectedItems(0).Tag)
            If Dt_Detalle Is Nothing Then
                Call Limpiar_Resultado()
                MsgBox("Ocurrió un error al intentar mostrar el detalle del sorteo.", MsgBoxStyle.Critical, Me.Text)
                Exit Sub
            Else
                Me.Cursor = Cursors.WaitCursor
                Dim Item As ListViewItem
                For Each Dr_Detalle As DataRow In Dt_Detalle.Rows
                    Item = New ListViewItem
                    Item.Tag = Dr_Detalle("Id_Empleado")
                    Item.Text = Dr_Detalle("Clave")
                    Item.SubItems.Add(Dr_Detalle("Empleado"))
                    Item.SubItems.Add(Dr_Detalle("Departamento"))
                    Item.SubItems.Add(Dr_Detalle("Puesto"))
                    lsv_Disponibles.Items.Add(Item)
                    If Dr_Detalle("Seleccionado") = "SI" Then
                        Item = New ListViewItem
                        Item.Tag = Dr_Detalle("Id_Empleado")
                        Item.Text = Dr_Detalle("Clave")
                        Item.SubItems.Add(Dr_Detalle("Empleado"))
                        lsv_Seleccionados.Items.Add(Item)
                    End If
                    If Dr_Detalle("Sorteado") = "SI" Then
                        Item = New ListViewItem
                        Item.Tag = Dr_Detalle("Id_Empleado")
                        Item.Text = Dr_Detalle("Clave")
                        Item.SubItems.Add(Dr_Detalle("Empleado"))
                        lsv_Sorteados.Items.Add(Item)
                    End If
                Next
                Me.Cursor = Cursors.Default
                lbl_RegistrosDisponibles.Text = "Registros: " & lsv_Disponibles.Items.Count
                lbl_RegistrosSeleccionados.Text = "Registros: " & lsv_Seleccionados.Items.Count
                lbl_RegistrosSorteados.Text = "Registros: " & lsv_Sorteados.Items.Count
            End If
        Else
            Call Limpiar_Resultado()
        End If
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If dtp_FechaDesde.Value.Date > dtp_FechaHasta.Value.Date Then
            MsgBox("La fecha inicial no puede ser mayor a la fecha final.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Call ListarSorteos()

    End Sub

    Sub ListarSorteos()
        lsv_Sorteos.Items.Clear()
        If Not fn_SorteoAntidopingConsulta_Sorteos(lsv_Sorteos, dtp_FechaDesde.Value.Date, dtp_FechaHasta.Value.Date, "T") Then
            MsgBox("Ocurrió un error al intentar mostrar los sorteos.", MsgBoxStyle.Critical, Me.Text)
        End If

        lbl_RegistrosSorteos.Text = "Registros: " & lsv_Sorteos.Items.Count
        Call Botones()
    End Sub

    Private Sub dtp_FechaDesde_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaDesde.ValueChanged
        SegundosDesconexion = 0
        Call Limpiar_Sorteos()
    End Sub

    Private Sub dtp_FechaHasta_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaHasta.ValueChanged
        Call Limpiar_Sorteos()
    End Sub

    Private Sub lsv_Sorteos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Sorteos.SelectedIndexChanged
        SegundosDesconexion = 0

        Call MostrarDetalle()
        Call Botones()
    End Sub

    Private Function Exportar() As Boolean
        Dim versionHC As Boolean = False
        Dim ObjetoHC As String = ""
        Try
            '-----para Microsoft Office(Excel)
            Try
                ObjetoHC = "Excel.Application"
                versionHC = True
                Return Exportar_Excel_Kingsoft(ObjetoHC)
            Catch ex As Exception
                versionHC = False
            End Try

            '-----para KingSoft Office (Spreadsheets) 
            If versionHC = False Then
                Try
                    ObjetoHC = "Ket.Application"
                    versionHC = True
                    Return Exportar_Excel_Kingsoft(ObjetoHC)
                Catch ex As Exception
                    versionHC = False
                End Try
            End If

            '----------para Apache OpenOffice 4.0 (Calc)--
            If versionHC = False Then

                Try
                    Dim objServManager = CreateObject("com.sun.star.ServiceManager")
                    versionHC = True
                    objServManager = Nothing
                    versionHC = True
                    Return Exportar_Openoffice()
                    'fn_Exportar_CalcOpenOffice(Lista, Filas_sin_Texto, Titulo, Cols_Izquierda_Omitir, Cols_Derecha_Omitir, Bar)
                Catch ex As Exception
                    versionHC = False
                End Try
            End If
            If versionHC = False Then
                MsgBox("No se encontró niguna paqueteria  de gestión de hoja de cálculo para la exportación de la lista, por lo tanto se procederá a guardar el archivo.", MsgBoxStyle.Exclamation, Me.Text)
            End If

            Return versionHC
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Exportar_Excel_Kingsoft(ByVal ObjetoHC As String) As Boolean
        Dim objExcel As Object
        Dim Bar As ToolStripProgressBar = frm_MENU.prg_Barra
        Dim FilaInicialDatos As Integer = 6
        Bar.Minimum = 0
        Bar.Maximum = lsv_Disponibles.Items.Count + lsv_Seleccionados.Items.Count + lsv_Sorteados.Items.Count + 2
        Try
            Bar.Value = 0
            objExcel = CreateObject(ObjetoHC)

            objExcel.UserControl = True
            Dim oldCI As System.Globalization.CultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("en-US")
            System.Threading.Thread.CurrentThread.CurrentCulture = New System.Globalization.CultureInfo("es-MX")
            System.Threading.Thread.CurrentThread.CurrentCulture = oldCI

            objExcel.SheetsInNewWorkbook = 1
            objExcel.Workbooks.Add()

            With objExcel
                .Range("A1").Value = EmpresaNombre & " - SUCURSAL " & SucursalN
                .Range("A1").Font.Bold = True
                .Range("A1:J1").Merge()
                .range("A1").select()
                .selection.horizontalalignment = -4108
                'coloca el Titulo del Reporte
                .Range("A2").Value = "SORTEO ALEATORIO DE EMPLEADOS PARA EXAMEN ANTIDOPING"
                .Range("A2").Font.Bold = True
                .Range("A2:J2").Merge()
                .RANGE("A2").Select()
                .Selection.HorizontalAlignment = -4108
                '.Selection.Font.Size = 10
                'Coloca el Rango de Fechas o Algun otro dato
                Dim DatosUsuario As String
                DatosUsuario = "FECHA: " & lsv_Sorteos.SelectedItems(0).Text & "          "
                DatosUsuario = DatosUsuario & "HORA: " & lsv_Sorteos.SelectedItems(0).SubItems(1).Text & "          "
                DatosUsuario = DatosUsuario & "ESTACION: " & lsv_Sorteos.SelectedItems(0).SubItems(9).Text & "          "
                DatosUsuario = DatosUsuario & "USUARIO FIRMADO: " & lsv_Sorteos.SelectedItems(0).SubItems(8).Text

                .Range("A3").Value = DatosUsuario
                .Range("A3").Font.Bold = True
                .Range("A3:J3").Merge()
                .RANGE("A3").SELECT()
                .Selection.HorizontalAlignment = -4108
                '.Selection.Font.Size = 10

                .Range("A5").Value = "EMPLEADOS DISPONIBLES"
                .Range("A5").Font.Bold = True
                .Range("A5:D5").Merge()
                .RANGE("A5").SELECT()
                .Selection.HorizontalAlignment = -4108
                .Range("A5:D6").Borders().LineStyle = 1
                .Selection.Font.Size = 10

                .Range("F5").Value = "EMPLEADOS SELECCIONADOS"
                .Range("F5").Font.Bold = True
                .Range("F5:G5").Merge()
                .RANGE("F5").SELECT()
                .Selection.HorizontalAlignment = -4108
                .Range("F5:G6").Borders().LineStyle = 1
                .Selection.Font.Size = 10

                .Range("I5").Value = "EMPLEADOS SORTEADOS"
                .Range("I5").Font.Bold = True
                .Range("I5:J5").Merge()
                .RANGE("I5").SELECT()
                .Selection.HorizontalAlignment = -4108
                .Range("I5:J6").Borders().LineStyle = 1
                .Selection.Font.Size = 10

                'Define el ancho de las columnas
                .range("A1").ColumnWidth = 8
                .range("B1").ColumnWidth = 30
                .range("C1").ColumnWidth = 25
                .range("D1").ColumnWidth = 25
                .range("E1").ColumnWidth = 5
                .range("F1").ColumnWidth = 8
                .range("G1").ColumnWidth = 30
                .range("H1").ColumnWidth = 5
                .range("I1").ColumnWidth = 8
                .range("J1").ColumnWidth = 30

                .Range("A6").Value = "CLAVE"
                .Range("B6").Value = "EMPLEADO"
                .Range("C6").Value = "DEPARTAMENTO"
                .Range("D6").Value = "PUESTO"

                .Range("F6").Value = "CLAVE"
                .Range("G6").Value = "EMPLEADO"

                .Range("I6").Value = "CLAVE"
                .Range("J6").Value = "PUESTO"

                .Range("A6:J6").Font.Bold = True
                .Range("A6:J6").Font.Size = 10



                Dim Fila As Integer = FilaInicialDatos

                For Each ItemDisponible As ListViewItem In lsv_Disponibles.Items
                    Fila += 1
                    .range("A" & Fila).value = "'" & ItemDisponible.Text
                    .range("B" & Fila).value = ItemDisponible.SubItems(1).Text
                    .range("C" & Fila).value = ItemDisponible.SubItems(2).Text
                    .range("D" & Fila).value = ItemDisponible.SubItems(3).Text
                    Bar.Value += 1
                Next

                .Range("A" & FilaInicialDatos + 1 & ":D" & Fila).Font.Size = 10
                .range("A" & FilaInicialDatos + 1 & ":D" & Fila).Borders(7).LineStyle = 1
                .range("A" & FilaInicialDatos + 1 & ":D" & Fila).Borders(8).LineStyle = 1
                .range("A" & FilaInicialDatos + 1 & ":D" & Fila).Borders(9).LineStyle = 1
                .range("A" & FilaInicialDatos + 1 & ":D" & Fila).Borders(10).LineStyle = 1

                Fila = FilaInicialDatos
                For Each ItemSeleccionado As ListViewItem In lsv_Seleccionados.Items
                    Fila += 1
                    .range("F" & Fila).value = "'" & ItemSeleccionado.Text
                    .range("G" & Fila).value = ItemSeleccionado.SubItems(1).Text
                    Bar.Value += 1
                Next

                .Range("F" & FilaInicialDatos + 1 & ":G" & Fila).Font.Size = 10
                .range("F" & FilaInicialDatos + 1 & ":G" & Fila).Borders(7).LineStyle = 1
                .range("F" & FilaInicialDatos + 1 & ":G" & Fila).Borders(8).LineStyle = 1
                .range("F" & FilaInicialDatos + 1 & ":G" & Fila).Borders(9).LineStyle = 1
                .range("F" & FilaInicialDatos + 1 & ":G" & Fila).Borders(10).LineStyle = 1

                Fila = FilaInicialDatos
                For Each ItemSorteado As ListViewItem In lsv_Sorteados.Items
                    Fila += 1
                    .range("I" & Fila).value = "'" & ItemSorteado.Text
                    .range("J" & Fila).value = ItemSorteado.SubItems(1).Text
                    Bar.Value += 1
                Next
                .Range("I" & FilaInicialDatos + 1 & ":J" & Fila).Font.Size = 10
                .range("I" & FilaInicialDatos + 1 & ":J" & Fila).Borders(7).LineStyle = 1
                .range("I" & FilaInicialDatos + 1 & ":J" & Fila).Borders(8).LineStyle = 1
                .range("I" & FilaInicialDatos + 1 & ":J" & Fila).Borders(9).LineStyle = 1
                .range("I" & FilaInicialDatos + 1 & ":J" & Fila).Borders(10).LineStyle = 1

                Fila += 2
                .Range("I" & Fila).Value = "INFORMACION DEL SORTEO"
                .Range("I" & Fila & ":J" & Fila).Font.Size = 10
                .Range("I" & Fila).Font.Bold = True
                .Range("I" & Fila & ":J" & Fila).Merge()
                .RANGE("I" & Fila).SELECT()
                .Selection.HorizontalAlignment = -4108
                .Range("I" & Fila & ":J" & Fila).Borders().LineStyle = 1

                Fila += 1
                .Range("I" & Fila).Value = "DEPARTAMENTO: " & lsv_Sorteos.SelectedItems(0).SubItems(2).Text
                Fila += 1
                .Range("I" & Fila).Value = "PUESTO: " & lsv_Sorteos.SelectedItems(0).SubItems(3).Text
                Fila += 1
                .Range("I" & Fila).Value = "FILTRO PARA DIAS DE ULTIMO EXAMEN: " & lsv_Sorteos.SelectedItems(0).SubItems(4).Text
                Fila += 1
                .Range("I" & Fila).Value = "CANTIDAD EMPLEADOS DISPONIBLES: " & lsv_Disponibles.Items.Count
                Fila += 1
                .Range("I" & Fila).Value = "CANTIDAD EMPLEADOS SELECCIONADOS: " & lsv_Seleccionados.Items.Count
                Fila += 1
                .Range("I" & Fila).Value = "CANTIDAD EMPLEADOS SORTEADOS: " & lsv_Sorteados.Items.Count
                .Range("I" & Fila - 5 & ":J" & Fila).Font.Size = 8
                .range("I" & Fila - 5 & ":J" & Fila).Borders(7).LineStyle = 1
                .range("I" & Fila - 5 & ":J" & Fila).Borders(8).LineStyle = 1
                .range("I" & Fila - 5 & ":J" & Fila).Borders(9).LineStyle = 1
                .range("I" & Fila - 5 & ":J" & Fila).Borders(10).LineStyle = 1

                objExcel.ActiveWindow.DisplayGridlines = False
                Bar.Value = Bar.Maximum

                .Range("A1").select()
            End With
            objExcel.Visible = True
            objExcel = Nothing

            Bar.Value = 0
            Return True
        Catch ex As Exception
            Bar.Value = 0
            objExcel = Nothing
            Return False
        End Try
    End Function

    Private Function Exportar_Openoffice() As Boolean
        Dim Bar As ToolStripProgressBar = frm_MENU.prg_Barra
        Dim FilaInicialDatos As Integer = 6
        Bar.Minimum = 0
        Bar.Maximum = lsv_Disponibles.Items.Count + lsv_Seleccionados.Items.Count + lsv_Sorteados.Items.Count + 2
        Try
            Bar.Value = 1
            Dim objServManager As Object
            Dim objDesktop As Object
            Dim objDocument As Object '--->
            Dim objSheet1 As Object
            Dim objArguments As Object() = {} 'ok

            objServManager = CreateObject("com.sun.star.ServiceManager")
            objDesktop = objServManager.createInstance("com.sun.star.frame.Desktop")
            objDocument = objDesktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, objArguments)

            Dim TablaBorde As Object, LineaBorde As Object

            LineaBorde = objServManager.Bridge_GetStruct("com.sun.star.table.BorderLine")
            LineaBorde.Color = 0
            LineaBorde.InnerLineWidth = 0
            LineaBorde.OuterLineWidth = 20
            LineaBorde.LineDistance = 0

            TablaBorde = objServManager.Bridge_GetStruct("com.sun.star.table.TableBorder")
            TablaBorde.IsTopLineValid = True
            TablaBorde.IsBottomLineValid = True
            TablaBorde.IsLeftLineValid = True
            TablaBorde.IsRightLineValid = True

            '-Lineas-Horizontales -
            TablaBorde.LeftLine = LineaBorde 'izquierda 
            TablaBorde.RightLine = LineaBorde 'inferior
            TablaBorde.TopLine = LineaBorde 'superior
            TablaBorde.BottomLine = LineaBorde 'inferior



            objSheet1 = objDocument.Sheets.getByIndex(0)
            With objSheet1
                .getCellRangeByName("A1").SetString(EmpresaNombre & " - SUCURSAL " & SucursalN)
                .getCellRangeByName("A1:J1").Merge(True) 'combina celda
                .getCellRangeByName("A1:J1").CharWeight = 150 ' negrita
                .getCellRangeByName("A2").SetString("SORTEO ALEATORIO DE EMPLEADOS PARA EXAMEN ANTIDOPING")
                .getCellRangeByName("A2:J2").Merge(True) 'combina celda
                .getCellRangeByName("A2:J2").CharWeight = 150 ' negrita
                Dim DatosUsuario As String
                DatosUsuario = "FECHA: " & lsv_Sorteos.SelectedItems(0).Text & "          "
                DatosUsuario = DatosUsuario & "HORA: " & lsv_Sorteos.SelectedItems(0).SubItems(1).Text & "          "
                DatosUsuario = DatosUsuario & "ESTACION: " & lsv_Sorteos.SelectedItems(0).SubItems(9).Text & "          "
                DatosUsuario = DatosUsuario & "USUARIO FIRMADO: " & lsv_Sorteos.SelectedItems(0).SubItems(8).Text
                .getCellRangeByName("A3").SetString(DatosUsuario)
                .getCellRangeByName("A3:J3").Merge(True) 'combina celda
                .getCellRangeByName("A3:J3").CharWeight = 150 ' negrita

                .getCellRangeByName("A1:J3").VertJustify = 2 'centrar
                .getCellRangeByName("A1:J3").HoriJustify = 2 ' centrar

                .getCellRangeByName("A5").SetString("EMPLEADOS DISPONIBLES")
                .getCellRangeByName("A5:D5").Merge(True) 'combina celda
                .getCellRangeByName("A5:D5").CharWeight = 150 ' negrita
                .getCellRangeByName("F5").SetString("EMPLEADOS SELECCIONADOS")
                .getCellRangeByName("F5:G5").Merge(True) 'combina celda
                .getCellRangeByName("F5:G5").CharWeight = 150 ' negrita
                .getCellRangeByName("I5").SetString("EMPLEADOS SORTEADOS")
                .getCellRangeByName("I5:J5").Merge(True) 'combina celda
                .getCellRangeByName("I5:J5").CharWeight = 150 ' negrita
                .getCellRangeByName("A5:J5").VertJustify = 2 'centrar
                .getCellRangeByName("A5:J5").HoriJustify = 2 ' centrar

                .getCellRangeByName("A6").SetString("CLAVE")
                .getCellRangeByName("A6").TableBorder = TablaBorde
                .getCellRangeByName("B6").SetString("EMPLEADO")
                .getCellRangeByName("B6").TableBorder = TablaBorde
                .getCellRangeByName("C6").SetString("DEPARTAMENTO")
                .getCellRangeByName("C6").TableBorder = TablaBorde
                .getCellRangeByName("D6").SetString("PUESTO")
                .getCellRangeByName("D6").TableBorder = TablaBorde
                .getCellRangeByName("F6").SetString("CLAVE")
                .getCellRangeByName("F6").TableBorder = TablaBorde
                .getCellRangeByName("G6").SetString("EMPLEADO")
                .getCellRangeByName("G6").TableBorder = TablaBorde
                .getCellRangeByName("I6").SetString("CLAVE")
                .getCellRangeByName("I6").TableBorder = TablaBorde
                .getCellRangeByName("J6").SetString("EMPLEADO")
                .getCellRangeByName("J6").TableBorder = TablaBorde
                .getCellRangeByName("A5:J6").CharWeight = 150 ' negrita


                .getCellRangeByName("A5:D5").TableBorder = TablaBorde
                .getCellRangeByName("F5:G5").TableBorder = TablaBorde
                .getCellRangeByName("I5:J5").TableBorder = TablaBorde

                'FALTA PONER TAMAÑO DE LETRA
                .getColumns.getByName("A1").Width = 1500
                .getColumns.getByName("B1").Width = 10000
                .getColumns.getByName("C1").Width = 5500
                .getColumns.getByName("D1").Width = 5500
                .getColumns.getByName("E1").Width = 1000
                .getColumns.getByName("F1").Width = 1500
                .getColumns.getByName("G1").Width = 10000
                .getColumns.getByName("H1").Width = 1000
                .getColumns.getByName("I1").Width = 1500
                .getColumns.getByName("J1").Width = 10000

                Dim Fila As Integer = FilaInicialDatos

                For Each ItemDisponible As ListViewItem In lsv_Disponibles.Items
                    Fila += 1
                    .getCellRangeByName("A" & Fila).SetString(ItemDisponible.Text)
                    .getCellRangeByName("B" & Fila).SetString(ItemDisponible.SubItems(1).Text)
                    .getCellRangeByName("C" & Fila).SetString(ItemDisponible.SubItems(2).Text)
                    .getCellRangeByName("D" & Fila).SetString(ItemDisponible.SubItems(3).Text)
                    Bar.Value += 1
                Next

                .getCellRangeByName("A" & FilaInicialDatos & ":D" & Fila).TableBorder = TablaBorde

                Fila = FilaInicialDatos
                For Each ItemSeleccionado As ListViewItem In lsv_Seleccionados.Items
                    Fila += 1
                    .getCellRangeByName("F" & Fila).SetString(ItemSeleccionado.Text)
                    .getCellRangeByName("G" & Fila).SetString(ItemSeleccionado.SubItems(1).Text)
                    Bar.Value += 1
                Next

                .getCellRangeByName("F" & FilaInicialDatos & ":G" & Fila).TableBorder = TablaBorde

                Fila = FilaInicialDatos
                For Each ItemSorteado As ListViewItem In lsv_Sorteados.Items
                    Fila += 1
                    .getCellRangeByName("I" & Fila).SetString(ItemSorteado.Text)
                    .getCellRangeByName("J" & Fila).SetString(ItemSorteado.SubItems(1).Text)
                    Bar.Value += 1
                Next

                .getCellRangeByName("I" & FilaInicialDatos & ":J" & Fila).TableBorder = TablaBorde

                Fila += 2
                .getCellRangeByName("I" & Fila).SetString("INFORMACION DEL SORTEO")
                .getCellRangeByName("I" & Fila & ":J" & Fila).Merge(True) 'combina celda
                .getCellRangeByName("I" & Fila & ":J" & Fila).CharWeight = 150 ' negrita
                .getCellRangeByName("I" & Fila & ":J" & Fila).TableBorder = TablaBorde
                .getCellRangeByName("I" & Fila & ":J" & Fila).VertJustify = 2 'centrar
                .getCellRangeByName("I" & Fila & ":J" & Fila).HoriJustify = 2 ' centrar
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("DEPARTAMENTO: " & lsv_Sorteos.SelectedItems(0).SubItems(2).Text)
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("PUESTO: " & lsv_Sorteos.SelectedItems(0).SubItems(3).Text)
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("FILTRO PARA DIAS DE ULTIMO EXAMEN: " & lsv_Sorteos.SelectedItems(0).SubItems(4).Text)
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("CANTIDAD EMPLEADOS DISPONIBLES: " & lsv_Disponibles.Items.Count)
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("CANTIDAD EMPLEADOS SELECCIONADOS: " & lsv_Seleccionados.Items.Count)
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("CANTIDAD EMPLEADOS SORTEADOS: " & lsv_Sorteados.Items.Count)

                .getCellRangeByName("I" & Fila - 5 & ":J" & Fila).TableBorder = TablaBorde

            End With

            Bar.Value = Bar.Maximum
            objServManager = Nothing
            Bar.Value = 0
            Return True
        Catch ex As Exception
            Bar.Value = Bar.Minimum
            Return False
        End Try
    End Function

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        If lsv_Sorteos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un sorteo de la lista.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If lsv_Sorteos.SelectedItems(0).SubItems(10).Text = "CANCELADO" Then
            MsgBox("No se puede exportar un sorteo con estatus en CANCELADO.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If Not Exportar() Then
            MsgBox("Ocurrió un error al intentar exportar el sorteo.", MsgBoxStyle.Critical, Me.Text)
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Cancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar.Click
        SegundosDesconexion = 0

        If lsv_Sorteos.SelectedItems.Count = 0 Then
            MsgBox("Seleccione un sorteo de la lista.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If lsv_Sorteos.SelectedItems(0).SubItems(10).Text = "CANCELADO" Then
            MsgBox("No se puede cancelar un sorteo con estatus en CANCELADO.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim Observaciones As String = ""
        Dim frmf As New frm_FirmaElectronica
        frmf.Bloquear = True
        frmf.PedirObservaciones = True
        frmf.Max_Caracteres_Obs = 300
        frmf.ShowDialog()
        If Not frmf.Firma Then
            frmf.Dispose()
            Exit Sub
        Else
            Observaciones = frmf.Observaciones
            frmf.Dispose()
        End If

        If Not fn_SorteoAntidopingConsulta_Status(lsv_Sorteos.SelectedItems(0).Tag, Observaciones, "B") Then
            MsgBox("Ocurrió un error al intentar cancelar el sorteo.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        Else
            Call Limpiar_Sorteos()
            Call ListarSorteos()
            MsgBox("El sorteo se canceló correctamente.", MsgBoxStyle.Information, Me.Text)
        End If

    End Sub
End Class