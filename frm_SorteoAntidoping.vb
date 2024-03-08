Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_SorteoAntidoping
    Dim Dt_Sorteo As DataTable = Nothing
    Private Sub frm_SorteoAntidoping_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        Dt_Sorteo = New DataTable

        Dim Columna As DataColumn
        Dim Llave(1) As DataColumn
        Columna = New DataColumn()
        Columna.DataType = System.Type.GetType("System.String")
        Columna.ColumnName = "Id_Empleado"
        Llave(0) = Columna
        Dt_Sorteo.Columns.Add(Columna)
        Dt_Sorteo.Columns.Add("Seleccionado")
        Dt_Sorteo.Columns.Add("Sorteado")
        Dt_Sorteo.PrimaryKey = Llave

        cmb_Departamento.Actualizar()
        cmb_Puesto.Actualizar()

        lsv_Disponibles.Clear()
        lsv_Disponibles.Columns.Add("Clave")
        lsv_Disponibles.Columns.Add("Empleado")
        lsv_Disponibles.Columns.Add("Departamento")
        lsv_Disponibles.Columns.Add("Puesto")
        lsv_Disponibles.Columns.Add("Ult Antidoping")
        lsv_Disponibles.Columns.Add("Dias")

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

        Call Limpiar_Disponibles()
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Sub Limpiar_Disponibles()
        lsv_Disponibles.Items.Clear()
        lbl_RegistrosDisponibles.Text = "Registros: 0"
    End Sub

    Sub Limpiar_Seleccionados()
        lsv_Seleccionados.Items.Clear()
        lbl_RegistrosSeleccionados.Text = "Registros: 0"
    End Sub

    Sub Limpiar_Sorteados()
        lsv_Sorteados.Items.Clear()
        lbl_RegistrosSorteados.Text = "Registros: 0"
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If cmb_Departamento.SelectedValue = "0" AndAlso chk_Departamento.Checked = False Then
            MsgBox("Seleccione un Departamento o marque Todos", MsgBoxStyle.Critical, Me.Text)
            cmb_Departamento.Focus()
            Exit Sub
        End If

        If cmb_Puesto.SelectedValue = "0" AndAlso chk_Puesto.Checked = False Then
            MsgBox("Seleccione un Puesto o marque Todos", MsgBoxStyle.Critical, Me.Text)
            cmb_Puesto.Focus()
            Exit Sub
        End If

        lsv_Disponibles.Items.Clear()

        If Not fn_SorteoAntodoping_ListaEmpleados(lsv_Disponibles, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue) Then
            MsgBox("Ocurrió un error al intentar listar los Empleados Disponibles", MsgBoxStyle.Critical, Me.Text)
        End If
        tbx_Dias.Text = 0
        tbx_Dias.Enabled = True
        tbx_Cantidad.Text = 0
        lbl_RegistrosDisponibles.Text = "Registros: " & lsv_Disponibles.Items.Count
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Private Sub btn_Filtrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Filtrar.Click
        SegundosDesconexion = 0
        If tbx_Dias.Text.Trim = "" OrElse Integer.Parse(tbx_Dias.Text) = 0 Then
            MsgBox("Indique la Cantidad de dias de filtro.", MsgBoxStyle.Critical, Me.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        If lsv_Disponibles.Items.Count = 0 Then
            MsgBox("No se tienen Empleados en la lista para realizar el filtro.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        Dim Dias As Integer = Integer.Parse(tbx_Dias.Text)
        For Each ItemDisponibles As ListViewItem In lsv_Disponibles.Items
            If Integer.Parse(ItemDisponibles.SubItems(5).Text) < Dias Then
                ItemDisponibles.Remove()
            End If
        Next

        tbx_Dias.Enabled = False
        lbl_RegistrosDisponibles.Text = "Registros: " & lsv_Disponibles.Items.Count
        Me.Cursor = Cursors.Default

        MsgBox("Filtro finalizado.", MsgBoxStyle.Information, Me.Text)

    End Sub

    Private Sub Chk_TodosDisponibles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chk_TodosDisponibles.CheckedChanged
        SegundosDesconexion = 0

        For Each ItemDisponibles As ListViewItem In lsv_Disponibles.Items
            ItemDisponibles.Checked = Chk_TodosDisponibles.Checked
        Next

    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        If lsv_Disponibles.CheckedItems.Count = 0 Then
            MsgBox("Marque los Empleados que serán agregados al sorteo", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim Encontrado As Boolean = False
        Dim ItemNuevo As ListViewItem
        For Each ItemDisponibles As ListViewItem In lsv_Disponibles.CheckedItems
            Encontrado = False
            For Each ItemSeleccionados As ListViewItem In lsv_Seleccionados.Items
                If ItemDisponibles.Tag = ItemSeleccionados.Tag Then
                    Encontrado = True
                    Exit For
                End If
            Next
            If Not Encontrado Then
                ItemNuevo = New ListViewItem
                ItemNuevo.Tag = ItemDisponibles.Tag
                ItemNuevo.Text = ItemDisponibles.Text
                ItemNuevo.SubItems.Add(ItemDisponibles.SubItems(1).Text)
                ItemNuevo.SubItems.Add(ItemDisponibles.SubItems(2).Text)
                ItemNuevo.SubItems.Add(ItemDisponibles.SubItems(3).Text)
                lsv_Seleccionados.Items.Add(ItemNuevo)
            End If
        Next

        lbl_RegistrosSeleccionados.Text = "Registros: " & lsv_Seleccionados.Items.Count
        Call Limpiar_Sorteados()
    End Sub

    Private Sub btn_Quitar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Quitar.Click
        SegundosDesconexion = 0

        If lsv_Seleccionados.CheckedItems.Count = 0 Then
            MsgBox("Seleccione un Empleado de la lista de Seleccionados.", MsgBoxStyle.Critical, Me.Text)
            lsv_Seleccionados.Focus()
            Exit Sub
        End If

        For Each ItemSeleccionados As ListViewItem In lsv_Seleccionados.CheckedItems
            ItemSeleccionados.Remove()
        Next

        lbl_RegistrosSeleccionados.Text = "Registros: " & lsv_Seleccionados.Items.Count
        Call Limpiar_Sorteados()
    End Sub

    Private Sub btn_Sortear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Sortear.Click
        SegundosDesconexion = 0
        Dim Indice As Integer
        Dim TotalSeleccionados As Integer = lsv_Seleccionados.Items.Count


        If tbx_Cantidad.Text.Trim = "" OrElse Integer.Parse(tbx_Cantidad.Text) = 0 Then
            MsgBox("Indique la cantidad de Empleados que desea obtener en el sorteo.", MsgBoxStyle.Critical, Me.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        Dim CantidadSorteados As Integer = Integer.Parse(tbx_Cantidad.Text)

        If CantidadSorteados > TotalSeleccionados Then
            MsgBox("La cantidad de Empleados que indicó es mayor al número de elementos seleccionados para el sorte.", MsgBoxStyle.Critical, Me.Text)
            tbx_Cantidad.Focus()
            Exit Sub
        End If

        Me.Cursor = Cursors.WaitCursor

        lsv_Sorteados.Items.Clear()
        Dim NuevoItem As ListViewItem

        If CantidadSorteados = TotalSeleccionados Then

            For Each ItemSeleccionados As ListViewItem In lsv_Seleccionados.Items
                NuevoItem = New ListViewItem
                NuevoItem.Tag = ItemSeleccionados.Tag
                NuevoItem.Text = ItemSeleccionados.Text
                NuevoItem.SubItems.Add(ItemSeleccionados.SubItems(1).Text)
                NuevoItem.SubItems.Add(ItemSeleccionados.SubItems(2).Text)
                NuevoItem.SubItems.Add(ItemSeleccionados.SubItems(3).Text)
                lsv_Sorteados.Items.Add(NuevoItem)
            Next
            lbl_RegistrosSorteados.Text = "Registros: " & lsv_Sorteados.Items.Count
        Else
            For Posicion As Integer = 1 To CantidadSorteados
                Indice = Sortear(TotalSeleccionados)

                NuevoItem = New ListViewItem
                NuevoItem.Tag = lsv_Seleccionados.Items(Indice).Tag
                NuevoItem.Text = lsv_Seleccionados.Items(Indice).Text
                NuevoItem.SubItems.Add(lsv_Seleccionados.Items(Indice).SubItems(1).Text)
                NuevoItem.SubItems.Add(lsv_Seleccionados.Items(Indice).SubItems(2).Text)
                NuevoItem.SubItems.Add(lsv_Seleccionados.Items(Indice).SubItems(3).Text)

                lsv_Sorteados.Items.Add(NuevoItem)

                lbl_RegistrosSorteados.Text = "Registros: " & lsv_Sorteados.Items.Count
            Next

        End If
        Randomize()

        Me.Cursor = Cursors.Default

    End Sub

    Private Function Sortear(ByVal TotalSeleccionados As Integer) As Integer
        Dim Indice As Integer = CInt(Math.Floor(TotalSeleccionados * Rnd()))

        For Each ItemSorteado As ListViewItem In lsv_Sorteados.Items
            If ItemSorteado.Tag = lsv_Seleccionados.Items(Indice).Tag Then
                Return Sortear(TotalSeleccionados)
            End If
        Next

        Return Indice
    End Function

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        If lsv_Sorteados.Items.Count = 0 Then
            MsgBox("No se puede exportar porque no tiene Empleados sorteados.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        If tbx_Dias.Enabled Then
            tbx_Dias.Text = 0
        End If

        If Not Exportar() Then
            MsgBox("Ocurrió un error al intentar exportar el Sorteo.", MsgBoxStyle.Critical, Me.Text)
        End If
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
                    Return Exportar_Openoffice()

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
                DatosUsuario = "FECHA: " & Format(Today.Date, "dd/MMM/yyyy") & "          "
                DatosUsuario = DatosUsuario & "HORA: " & frm_MENU.lbl_Hora.Text & "          "
                DatosUsuario = DatosUsuario & "ESTACION: " & EstacioN & "          "
                DatosUsuario = DatosUsuario & "USUARIO FIRMADO: " & UsuarioN


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
                .Range("I" & Fila).Value = "DEPARTAMENTO: " & IIf(chk_Departamento.Checked, "TODOS", cmb_Departamento.Text)
                Fila += 1
                .Range("I" & Fila).Value = "PUESTO: " & IIf(chk_Puesto.Checked, "TODOS", cmb_Puesto.Text)
                Fila += 1
                .Range("I" & Fila).Value = "FILTRO PARA DIAS DE ULTIMO EXAMEN: " & tbx_Dias.Text
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
                DatosUsuario = "FECHA: " & Format(Today.Date, "dd/MMM/yyyy") & "          "
                DatosUsuario = DatosUsuario & "HORA: " & frm_MENU.lbl_Hora.Text & "          "
                DatosUsuario = DatosUsuario & "ESTACION: " & EstacioN & "          "
                DatosUsuario = DatosUsuario & "USUARIO FIRMADO: " & UsuarioN
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
                .getCellRangeByName("I" & Fila).SetString("DEPARTAMENTO: " & IIf(chk_Departamento.Checked, "TODOS", cmb_Departamento.Text))
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("PUESTO: " & IIf(chk_Puesto.Checked, "TODOS", cmb_Puesto.Text))
                Fila += 1
                .getCellRangeByName("I" & Fila).SetString("FILTRO PARA DIAS DE ULTIMO EXAMEN: " & tbx_Dias.Text.Trim)
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

    Private Sub chk_Departamento_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Departamento.CheckedChanged
        SegundosDesconexion = 0
        cmb_Departamento.SelectedValue = "0"
        cmb_Departamento.Enabled = Not chk_Departamento.Checked
        Call Limpiar_Disponibles()
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Private Sub chk_Puesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Puesto.CheckedChanged
        SegundosDesconexion = 0
        cmb_Puesto.SelectedValue = "0"
        cmb_Puesto.Enabled = Not chk_Puesto.Checked
        Call Limpiar_Disponibles()
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Private Sub cmb_Departamento_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Departamento.SelectedValueChanged
        Call Limpiar_Disponibles()
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Private Sub cmb_Puesto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Puesto.SelectedValueChanged
        Call Limpiar_Disponibles()
        Call Limpiar_Seleccionados()
        Call Limpiar_Sorteados()
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If lsv_Sorteados.Items.Count = 0 Then
            MsgBox("No se tienen Empleados en la lista para ser guardados.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Dim EmpleadoAutoriza As Integer
        Dim frmf As New frm_FirmaElectronica
        frmf.PedirObservaciones = False
        frmf.Bloquear = False
        frmf.ShowDialog()
        If Not frmf.Firma Then
            frmf.Dispose()
            Exit Sub
        Else
            EmpleadoAutoriza = frmf.Empleado
            frmf.Dispose()
        End If

        If tbx_Dias.Enabled Then
            tbx_Dias.Text = 0
        End If

        Dt_Sorteo.Rows.Clear()
        Dim dr As DataRow
        For Each ItemDisponible As ListViewItem In lsv_Disponibles.Items
            dr = Dt_Sorteo.NewRow
            dr("Id_Empleado") = ItemDisponible.Tag
            dr("Seleccionado") = "N"
            dr("Sorteado") = "N"
            Dt_Sorteo.Rows.Add(dr)
        Next

        dr = Nothing
        For Each ItemSeleccionado As ListViewItem In lsv_Seleccionados.Items
            dr = Dt_Sorteo.Rows.Find(ItemSeleccionado.Tag)
            If dr IsNot Nothing Then
                dr.BeginEdit()
                dr("Seleccionado") = "S"
                dr.AcceptChanges()
            End If
        Next

        dr = Nothing
        For Each ItemSorteado As ListViewItem In lsv_Sorteados.Items
            dr = Dt_Sorteo.Rows.Find(ItemSorteado.Tag)
            If dr IsNot Nothing Then
                dr.BeginEdit()
                dr("Sorteado") = "S"
                dr.AcceptChanges()
            End If
        Next

        If tbx_Dias.Text.Trim = "" Then tbx_Dias.Text = 0

        If Not fn_SorteoAntodoping_Guardar(cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, lsv_Disponibles.Items.Count, _
                                           lsv_Seleccionados.Items.Count, lsv_Sorteados.Items.Count, tbx_Dias.Text.Trim, Dt_Sorteo, EmpleadoAutoriza) Then
            MsgBox("Ocurrió un error al intentar guardar el sorteo.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        Else
            If MsgBox("El sorteo se guardó correctamente." & vbNewLine & "¿Desea exportar el sorteo?", MsgBoxStyle.Question + MsgBoxStyle.YesNo, Me.Text) = MsgBoxResult.Yes Then
                If Not Exportar() Then
                    MsgBox("Ocurrió un error al exportar el sorteo.", MsgBoxStyle.Critical, Me.Text)
                End If
            End If

            Call Limpiar_Disponibles()
            Call Limpiar_Seleccionados()
            Call Limpiar_Sorteados()
            tbx_Cantidad.Clear()
            tbx_Dias.Clear()
        End If

    End Sub

    Private Sub tbx_Cantidad_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Cantidad.TextChanged
        SegundosDesconexion = 0
        Call Limpiar_Sorteados()
    End Sub
End Class