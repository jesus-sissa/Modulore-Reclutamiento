Imports System.Windows.Forms.DataVisualization.Charting

'''<summary> Gestión de Gráficas (al ocurrir un error se muestra el Logo de SISSA) </summary>
Public Class frm_VisorGraficas

    '''<summary> El Tipo de Gráfica a Realizar. </summary>
    Public Tipo As Query
    '''<summary> ListView que se usará para Generar la Gráfica </summary>
    Public lsv As cp_Listview = Nothing
    '''<summary> DataTable que se usará para Generar la Gráfica (no es obligatoria) </summary>
    Public Dt_Nueva As New DataTable
    '''<summary> Fecha Incial en que se realizo la Consulta </summary>
    Public Desde As Date
    '''<summary> Fecha Final en que se realizo la Consulta </summary>
    Public Hasta As Date
    '''<summary> Departamento en que se realizo la Consulta </summary>
    Public Departamento As String
    '''<summary> Puesto en que se realizo la Consulta </summary>
    Public Puesto As String

    'Private ScrollBarClick As Boolean = False
    Private SubGraficas As Boolean = False
    Private Dt_Final As New DataTable

    <Flags()> _
    Enum Query As Byte
        RenunciaMotivo
        RenunciaDepartamento
        ReclutadosModContacto
        ReclutadosPuesto
        ContratadoDep
        ContratadoModContacto
        AltasBajasMes
        AltasBajasDep
        EntrevReclutador
        EntrevAptoNoApto
    End Enum

    Private Sub frm_VisorGraficas_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Call CargarCombos()
        'Cuando no se envía un DataTable Convertir el ListView a DataTable
        If lsv IsNot Nothing Then
            Call CambiarLsv()
        End If
        'Según el Tipo se llena la información para la Gráfica
        Call LlenarGrafica()
    End Sub

#Region "SUB's"

    Sub CargarCombos()
        For Each ChartType As String In [Enum].GetNames(GetType(SeriesChartType))
            If ChartType = "Kagi" OrElse ChartType = "PointAndFigure" OrElse ChartType = "Renko" OrElse ChartType = "ThreeLineBreak" Then
                Continue For
            Else
                cmb_ChartType.Items.Add(ChartType)
            End If
        Next
        For Each Palette As String In [Enum].GetNames(GetType(ChartColorPalette))
            cmb_ColumnColor.Items.Add(Palette)
        Next
        For Each ColorName As String In [Enum].GetNames(GetType(KnownColor))
            cmb_BackColor1.Items.Add(ColorName)
            cmb_BackColor2.Items.Add(ColorName)
            cmb_BackColorChart.Items.Add(ColorName)
        Next
        For Each Gradient As String In [Enum].GetNames(GetType(GradientStyle))
            cmb_BackGradient.Items.Add(Gradient)
        Next
        For Each Dockings As String In [Enum].GetNames(GetType(Docking))
            cmb_LegendDocking.Items.Add(Dockings)
        Next
        cmb_ChartType.SelectedIndex = 5
        cmb_BackColor1.SelectedIndex = 152
        cmb_BackColor2.SelectedIndex = 152
        cmb_BackColorChart.SelectedIndex = 152
        cmb_BackGradient.SelectedIndex = 5
        cmb_LegendDocking.SelectedIndex = 2
        cmb_ColumnColor.SelectedIndex = 2
    End Sub

    Private Sub CambiarLsv()
        'Se usa el Dt_Nueva para convertir el lsv a datatable y realizar luego la gráfica.
        If lsv IsNot Nothing AndAlso lsv.Items.Count > 0 Then
            For Each Column As ColumnHeader In lsv.Columns
                Dt_Nueva.Columns.Add(Column.Text)
            Next
            For Each Item As ListViewItem In lsv.Items
                Dim DR_Nuevo As DataRow = Dt_Nueva.NewRow
                For ILocal As Integer = 0 To Item.SubItems.Count - 1
                    DR_Nuevo(lsv.Columns(ILocal).Text) = Item.SubItems(ILocal).Text
                Next
                Dt_Nueva.Rows.Add(DR_Nuevo)
            Next
        End If
    End Sub

    Private Sub LlenarGrafica()
        Try
            Dim ColumnasAñadir As Integer 'Es la cantidad de columnas a agregar a la Dt_Final
            Dim q1 = Nothing 'Es el query que debe contener la información para agregar a la gráfica
            Select Case Tipo
                Case Query.RenunciaMotivo
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("MotivoBaja") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("MotivoBaja"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.RenunciaDepartamento
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("Departamento") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.ReclutadosModContacto
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("DetalleContacto") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.ReclutadosPuesto
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("Puesto") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("Puesto"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.ContratadoDep
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("Departamento") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.ContratadoModContacto
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("DetalleContacto") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.AltasBajasMes
                    Dim Altas = From row In Dt_Nueva _
                                Where CDate(row("FechaIngreso")).Date >= Desde AndAlso CDate(row("FechaIngreso")).Date <= Hasta _
                                Group row By Meses = CDate(row("FechaIngreso")).Month, Años = Microsoft.VisualBasic.Right(row("FechaIngreso"), 2) Into z = Group _
                                Order By Años, Meses _
                                Select New With {.Mes = z(0)("MesIngreso") & " " & Años, .Cantidad = z.Count()}
                    'String.Format("{0} {1}", z(0)("MesIngreso"), Año)
                    Dim Bajas = From row In Dt_Nueva _
                                Where row("FechaBaja") <> "" AndAlso CDate(row("FechaBaja")).Date >= Desde AndAlso CDate(row("FechaBaja")).Date <= Hasta _
                                Group row By Meses = CDate(row("FechaBaja")).Month, Años = Microsoft.VisualBasic.Right(row("FechaBaja"), 2) Into z = Group _
                                Order By Años, Meses _
                                Select New With {.Mes = z(0)("MesBaja") & " " & Años, .Cantidad = z.Count()}

                    q1 = From A In Altas _
                         Join B In Bajas On A.Mes Equals B.Mes _
                         Select New With {.Concepto = A.Mes, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                    ColumnasAñadir = 3
                    chk_Profundizar.Enabled = False

                Case Query.AltasBajasDep
                    Dim Altas = From row In Dt_Nueva _
                                Where CDate(row("FechaIngreso")).Date >= Desde AndAlso CDate(row("FechaIngreso")).Date <= Hasta _
                                Group row By Departamento = row("Departamento") Into z = Group _
                                Order By Departamento _
                                Select New With {.Dep = Departamento, .Cantidad = z.Count()}

                    Dim Bajas = From row In Dt_Nueva _
                                Where row("FechaBaja") <> "" AndAlso CDate(row("FechaBaja")).Date >= Desde AndAlso CDate(row("FechaBaja")).Date <= Hasta _
                                Group row By Departamento = row("Departamento") Into z = Group _
                                Order By Departamento _
                                Select New With {.Dep = Departamento, .Cantidad = z.Count()}

                    q1 = From A In Altas _
                         Join B In Bajas On A.Dep Equals B.Dep _
                         Select New With {.Concepto = A.Dep, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                    ColumnasAñadir = 3
                    chk_Profundizar.Enabled = False

                Case Query.EntrevReclutador
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("Reclutador") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("Reclutador"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

                Case Query.EntrevAptoNoApto
                    q1 = From row In Dt_Nueva _
                         Group row By Concepto = row("Apto") Into z = Group _
                         Order By Concepto _
                         Select New With {.Concepto = z(0)("Apto"), .Cantidad = z.Count()}
                    ColumnasAñadir = 2

            End Select

            Dt_Final.Columns.Add("Concepto", GetType(String))
            Dt_Final.Columns.Add("Cantidad1", GetType(Integer))
            Select Case ColumnasAñadir
                Case 2 'Columnas: Concepto y Cantidad1
                    For Each ILocal In q1
                        Dt_Final.Rows.Add(ILocal.Concepto, ILocal.Cantidad)
                    Next
                Case 3 'Columnas: Concepto, Cantidad1 y Cantidad2
                    Dt_Final.Columns.Add("Cantidad2", GetType(Integer))
                    For Each ILocal In q1
                        Dt_Final.Rows.Add(ILocal.Concepto, ILocal.Cantidad1, ILocal.Cantidad2)
                    Next
            End Select

            Call GraficaCargar(ColumnasAñadir)
        Catch
            pct_Logo.Dock = DockStyle.Fill
            pct_Logo.Visible = True
            chr_Grafica.Visible = False
            gbx_Estilo.Enabled = False
            gbx_Estilo.Enabled = chr_Grafica.Visible
            MsgBox("No se pudo realizar el Graficado correctamente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub GraficaCargar(ByVal ColumnasAñadir As Integer)
        If Dt_Final IsNot Nothing AndAlso Dt_Final.Rows.Count > 0 Then
            chr_Grafica.DataSource = Dt_Final
            Dim ChartArea1 As New ChartArea()
            Dim Title1 As New Title()
            Dim Legend1 As New Legend()
            Dim Series1 As New Series()
            chr_Grafica.Series.Add(Series1)

            If ColumnasAñadir = 2 Then
                chr_Grafica.Series("Series1").XValueMember = "Concepto"
                chr_Grafica.Series("Series1").YValueMembers = "Cantidad1"
            Else
                Dim Series2 As New Series()
                chr_Grafica.Series.Add(Series2)
                chr_Grafica.Series("Series1").XValueMember = "Concepto"
                chr_Grafica.Series("Series1").YValueMembers = "Cantidad1"
                chr_Grafica.Series("Series2").XValueMember = "Concepto"
                chr_Grafica.Series("Series2").YValueMembers = "Cantidad2"
                tbx_Serie2.Enabled = True
            End If
            chr_Grafica.ChartAreas.Add(ChartArea1)
            chr_Grafica.Titles.Add(Title1)
            chr_Grafica.Legends.Add(Legend1)

            Call GraficaEstilo()
            pct_Logo.Visible = False
            chr_Grafica.Visible = True
            gbx_Estilo.Enabled = True
        Else
            pct_Logo.Dock = DockStyle.Fill
            pct_Logo.Visible = True
            chr_Grafica.Visible = False
            gbx_Estilo.Enabled = False
            gbx_Estilo.Enabled = chr_Grafica.Visible
            MsgBox("No se pudo realizar el Graficado correctamente.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Botones()
    End Sub

    Private Sub GraficaEstilo(Optional ByVal EjeXNumerico As Boolean = False)
        '**********************************PROPIEDADES FIJAS AL CREAR**********************************'
        chr_Grafica.BorderlineColor = Color.Transparent
        chr_Grafica.ChartAreas(0).Name = "ChartArea1"
        chr_Grafica.ChartAreas(0).ShadowOffset = 4
        chr_Grafica.ChartAreas(0).AxisX.IsLabelAutoFit = False
        chr_Grafica.ChartAreas(0).AxisX.LabelStyle.Font = New Font("Arial", 7)
        'chr_Grafica.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.DecreaseFont
        chr_Grafica.ChartAreas(0).AxisX.LabelAutoFitStyle = LabelAutoFitStyles.StaggeredLabels
        chr_Grafica.ChartAreas(0).AxisX.Interval = 1
        chr_Grafica.ChartAreas(0).AxisX.TitleFont = New Font("Arial", 8.25, FontStyle.Bold)
        chr_Grafica.ChartAreas(0).AxisY.LabelStyle.Font = New Font("Arial", 8.25, FontStyle.Bold)
        chr_Grafica.ChartAreas(0).AxisY.TitleFont = New Font("Arial", 8.25, FontStyle.Bold)
        chr_Grafica.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.WhiteSmoke
        chr_Grafica.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.WhiteSmoke
        chr_Grafica.Titles(0).Name = "Title1"
        chr_Grafica.Titles(0).Font = New Font("Arial", 12, FontStyle.Bold)
        chr_Grafica.Titles(0).TextStyle = TextStyle.Shadow
        chr_Grafica.Legends(0).Name = "Legend1"
        chr_Grafica.Legends(0).BackColor = Color.Transparent
        chr_Grafica.Legends(0).BackSecondaryColor = Color.Transparent
        chr_Grafica.Legends(0).BorderColor = Color.Transparent
        chr_Grafica.Legends(0).Font = New Font("Arial", 8.25, FontStyle.Bold)
        chr_Grafica.Legends(0).ShadowOffset = 4
        chr_Grafica.Legends(0).Alignment = StringAlignment.Center
        chr_Grafica.Legends(0).Title = " "
        chr_Grafica.Legends(0).TitleSeparator = LegendSeparatorStyle.ThickGradientLine
        For Each Serie As Series In chr_Grafica.Series
            Serie.ChartArea = "ChartArea1"
            Serie.Legend = "Legend1"
            Serie.ChartType = SeriesChartType.Parse(GetType(SeriesChartType), cmb_ChartType.SelectedItem.ToString)
            'Serie.BackGradientStyle = GradientStyle.VerticalCenter
            Serie.IsValueShownAsLabel = True
            Serie("LabelStyle") = "Bottom"
            Serie.Font = New Font("Arial", 8.25, FontStyle.Bold)
            Serie.ToolTip = "#VAL"
            Serie.LabelToolTip = "#VAL"
        Next

        '**********************************PROPIEDADES VARIABLES AL CREAR**********************************'
        chr_Grafica.Palette = ChartColorPalette.Parse(GetType(ChartColorPalette), cmb_ColumnColor.SelectedItem.ToString)
        chr_Grafica.BackColor = Color.FromName(cmb_BackColor1.SelectedItem.ToString)
        chr_Grafica.BackSecondaryColor = Color.FromName(cmb_BackColor2.SelectedItem.ToString)
        chr_Grafica.BackGradientStyle = GradientStyle.Parse(GetType(GradientStyle), cmb_BackGradient.SelectedItem.ToString)
        chr_Grafica.ChartAreas(0).AxisX.Title = tbx_EjeX.Text
        chr_Grafica.ChartAreas(0).AxisY.Title = tbx_EjeY.Text
        chr_Grafica.ChartAreas(0).Area3DStyle.Enable3D = chk_3D.Checked
        chr_Grafica.ChartAreas(0).BackColor = Color.FromName(cmb_BackColorChart.SelectedItem.ToString)
        chr_Grafica.ChartAreas(0).AxisX.MajorGrid.Enabled = chk_GridLines.Checked
        chr_Grafica.ChartAreas(0).AxisY.MajorGrid.Enabled = chk_GridLines.Checked
        If chk_3D.Checked Then
            chr_Grafica.ChartAreas(0).Area3DStyle.LightStyle = LightStyle.Realistic
            chr_Grafica.ChartAreas(0).Area3DStyle.IsClustered = chk_Cluster.Checked
        End If
        If chr_Grafica.Series.Count = 1 Then
            chr_Grafica.Series(0).Name = tbx_Serie1.Text
        Else
            chr_Grafica.Series(0).Name = tbx_Serie1.Text
            chr_Grafica.Series(1).Name = tbx_Serie2.Text
        End If
        chr_Grafica.Titles(0).Text = tbx_Titulo.Text
        chr_Grafica.Titles(0).Visible = tbx_Titulo.Text <> ""
        chr_Grafica.Legends(0).Docking = Docking.Parse(GetType(Docking), cmb_LegendDocking.SelectedItem.ToString)

        '**********************************AUTOESCALA DE EJES**********************************'
        If EjeXNumerico Then
            chr_Grafica.ChartAreas(0).AxisX.Minimum = [Double].NaN
            chr_Grafica.ChartAreas(0).AxisX.Maximum = [Double].NaN
        End If

        ''**********************************SCROLLBAR**********************************'
        'chr_Grafica.ChartAreas(0).CursorX.IsUserEnabled = Not chk_Profundizar.Checked
        'chr_Grafica.ChartAreas(0).CursorX.IsUserSelectionEnabled = Not chk_Profundizar.Checked
        'chr_Grafica.ChartAreas(0).CursorY.IsUserEnabled = Not chk_Profundizar.Checked
        'chr_Grafica.ChartAreas(0).CursorY.IsUserSelectionEnabled = Not chk_Profundizar.Checked
    End Sub

    Sub Botones()
        btn_ExportarGrafica.Enabled = chr_Grafica.Visible
        btn_CopiarGrafico.Enabled = chr_Grafica.Visible
    End Sub

#End Region

    Private Sub chr_Grafica_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chr_Grafica.MouseMove
        Try
            If chk_Profundizar.Checked Then
                Dim result As HitTestResult = chr_Grafica.HitTest(e.X, e.Y)

                For Each Serie As Series In chr_Grafica.Series
                    For Each point As DataPoint In Serie.Points
                        chr_Grafica.BackSecondaryColor = Color.FromName(cmb_BackColor2.SelectedItem.ToString)
                        point.BackHatchStyle = ChartHatchStyle.None
                        point.BorderWidth = 1
                    Next
                Next

                ' If a Data Point or a Legend item is selected.
                If result.ChartElementType = ChartElementType.DataPoint Or result.ChartElementType = ChartElementType.LegendItem Then
                    Me.Cursor = Cursors.Hand
                    Dim point As DataPoint
                    For Each Serie As Series In chr_Grafica.Series
                        point = Serie.Points(result.PointIndex)
                        point.BackSecondaryColor = Color.White
                        point.BackHatchStyle = ChartHatchStyle.Percent25
                        point.BorderWidth = 2
                    Next
                Else
                    Me.Cursor = Cursors.Default
                End If
            End If
        Catch
            Me.Cursor = Cursors.Default
        End Try
    End Sub

    Private Sub chr_Grafica_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chr_Grafica.MouseDown
        SegundosDesconexion = 0
        Try
            If chk_Profundizar.Checked Then
                ' Call Hit Test Method
                Dim result As HitTestResult = chr_Grafica.HitTest(e.X, e.Y)
                If result.ChartElementType <> ChartElementType.DataPoint Then
                    Return
                End If
                'Obtener el Nombre de cual se quiere Revisar
                Dim Seleccionado As String = chr_Grafica.Series(0).Points(result.PointIndex).AxisLabel.ToString

                ' Remove data points
                chr_Grafica.Series(0).Points.Clear()

                Dim ColumnasAñadir As Integer
                Dim q1 = Nothing
                'Cuando es False significa que esta en la gráfica principal
                'Al ir a una subgrafica se vuelve verdadero
                If SubGraficas = False Then
                    Select Case Tipo
                        Case Query.RenunciaMotivo
                            q1 = From row In Dt_Nueva _
                                 Where row("MotivoBaja") = Seleccionado _
                                 Group row By Concepto = row("Departamento") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.RenunciaDepartamento
                            q1 = From row In Dt_Nueva _
                                 Where row("Departamento") = Seleccionado _
                                 Group row By Concepto = row("MotivoBaja") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("MotivoBaja"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ReclutadosModContacto
                            q1 = From row In Dt_Nueva _
                                 Where row("DetalleContacto") = Seleccionado _
                                 Group row By Concepto = row("Puesto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Puesto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ReclutadosPuesto
                            q1 = From row In Dt_Nueva _
                                 Where row("Puesto") = Seleccionado _
                                 Group row By Concepto = row("DetalleContacto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ContratadoDep
                            q1 = From row In Dt_Nueva _
                                 Where row("Departamento") = Seleccionado _
                                 Group row By Concepto = row("DetalleContacto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ContratadoModContacto
                            q1 = From row In Dt_Nueva _
                                 Where row("DetalleContacto") = Seleccionado _
                                 Group row By Concepto = row("Departamento") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.EntrevReclutador
                            q1 = From row In Dt_Nueva _
                                 Where row("Reclutador") = Seleccionado _
                                 Group row By Concepto = row("Apto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Apto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.EntrevAptoNoApto
                            q1 = From row In Dt_Nueva _
                                 Where row("Apto") = Seleccionado _
                                 Group row By Concepto = row("Reclutador") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Reclutador"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                            'Case Query.AltasBajasMes
                            '    Dim Altas = From row In Dt_Nueva _
                            '                Where row("MesIngreso") = Microsoft.VisualBasic.Left(Seleccionado, 3) AndAlso Microsoft.VisualBasic.Right(row("FechaIngreso"), 2) = Microsoft.VisualBasic.Right(Seleccionado, 2) _
                            '                Group row By Departamento = row("Departamento") Into z = Group _
                            '                Order By Departamento _
                            '                Select New With {.Dep = Departamento, .Cantidad = z.Count()}
                            '    'String.Format("{0} {1}", z(0)("MesIngreso"), Año)
                            '    Dim Bajas = From row In Dt_Nueva _
                            '                Where row("MesBaja") = Microsoft.VisualBasic.Left(Seleccionado, 3) AndAlso Microsoft.VisualBasic.Right(row("FechaBaja"), 2) = Microsoft.VisualBasic.Right(Seleccionado, 2) _
                            '                Group row By Departamento = row("Departamento") Into z = Group _
                            '                Order By Departamento _
                            '                Select New With {.Dep = Departamento, .Cantidad = z.Count()}

                            '    q1 = From A In Altas _
                            '         Join B In Bajas On A.Dep Equals B.Dep _
                            '         Select New With {.Concepto = A.Dep, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                            '    ColumnasAñadir = 3

                            'Case Query.AltasBajasDep
                            '    Dim Altas = From row In Dt_Nueva _
                            '                Where row("Departamento") = Seleccionado _
                            '                Group row By Meses = CDate(row("FechaIngreso")).Month, Años = Microsoft.VisualBasic.Right(row("FechaIngreso"), 2) Into z = Group _
                            '                Order By Años, Meses _
                            '                Select New With {.Mes = z(0)("MesIngreso") & " " & Años, .Cantidad = z.Count()}

                            '    Dim Bajas = From row In Dt_Nueva _
                            '                Where row("Departamento") = Seleccionado _
                            '                Group row By Meses = CDate(row("FechaBaja")).Month, Años = Microsoft.VisualBasic.Right(row("FechaBaja"), 2) Into z = Group _
                            '                Order By Años, Meses _
                            '                Select New With {.Mes = z(0)("MesBaja") & " " & Años, .Cantidad = z.Count()}

                            '    q1 = From A In Altas _
                            '         Join B In Bajas On A.Mes Equals B.Mes _
                            '         Select New With {.Concepto = A.Mes, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                            '    ColumnasAñadir = 3
                    End Select

                    For Each Serie As Series In chr_Grafica.Series
                        Serie.ChartType = SeriesChartType.Parse(GetType(SeriesChartType), cmb_ChartType.SelectedItem.ToString)
                    Next
                    SubGraficas = True

                Else
                    Select Case Tipo
                        Case Query.RenunciaMotivo
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("MotivoBaja") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("MotivoBaja"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.RenunciaDepartamento
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("Departamento") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ReclutadosModContacto
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("DetalleContacto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ReclutadosPuesto
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("Puesto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Puesto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ContratadoDep
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("Departamento") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Departamento"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.ContratadoModContacto
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("DetalleContacto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("DetalleContacto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.EntrevReclutador
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("Reclutador") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Reclutador"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                        Case Query.EntrevAptoNoApto
                            q1 = From row In Dt_Nueva _
                                 Group row By Concepto = row("Apto") Into z = Group _
                                 Order By Concepto _
                                 Select New With {.Concepto = z(0)("Apto"), .Cantidad = z.Count()}
                            ColumnasAñadir = 2

                            'Case Query.AltasBajasMes
                            '    Dim Altas = From row In Dt_Nueva _
                            '                Where CDate(row("FechaIngreso")).Date >= Desde AndAlso CDate(row("FechaIngreso")).Date <= Hasta _
                            '                Group row By Meses = CDate(row("FechaIngreso")).Month, Años = Microsoft.VisualBasic.Right(row("FechaIngreso"), 2) Into z = Group _
                            '                Order By Años, Meses _
                            '                Select New With {.Mes = z(0)("MesIngreso") & " " & Años, .Cantidad = z.Count()}
                            '    'String.Format("{0} {1}", z(0)("MesIngreso"), Año)
                            '    Dim Bajas = From row In Dt_Nueva _
                            '                Where row("FechaBaja") <> "" AndAlso CDate(row("FechaBaja")).Date >= Desde AndAlso CDate(row("FechaBaja")).Date <= Hasta _
                            '                Group row By Meses = CDate(row("FechaBaja")).Month, Años = Microsoft.VisualBasic.Right(row("FechaBaja"), 2) Into z = Group _
                            '                Order By Años, Meses _
                            '                Select New With {.Mes = z(0)("MesBaja") & " " & Años, .Cantidad = z.Count()}

                            '    q1 = From A In Altas _
                            '         Join B In Bajas On A.Mes Equals B.Mes _
                            '         Select New With {.Concepto = A.Mes, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                            '    ColumnasAñadir = 3

                            'Case Query.AltasBajasDep
                            '    Dim Altas = From row In Dt_Nueva _
                            '                Where CDate(row("FechaIngreso")).Date >= Desde AndAlso CDate(row("FechaIngreso")).Date <= Hasta _
                            '                Group row By Departamento = row("Departamento") Into z = Group _
                            '                Order By Departamento _
                            '                Select New With {.Dep = Departamento, .Cantidad = z.Count()}

                            '    Dim Bajas = From row In Dt_Nueva _
                            '                Where row("FechaBaja") <> "" AndAlso CDate(row("FechaBaja")).Date >= Desde AndAlso CDate(row("FechaBaja")).Date <= Hasta _
                            '                Group row By Departamento = row("Departamento") Into z = Group _
                            '                Order By Departamento _
                            '                Select New With {.Dep = Departamento, .Cantidad = z.Count()}

                            '    q1 = From A In Altas _
                            '         Join B In Bajas On A.Dep Equals B.Dep _
                            '         Select New With {.Concepto = A.Dep, .Cantidad1 = A.Cantidad, .Cantidad2 = B.Cantidad}
                            '    ColumnasAñadir = 3

                    End Select

                    For Each Serie As Series In chr_Grafica.Series
                        Serie.ChartType = SeriesChartType.Parse(GetType(SeriesChartType), cmb_ChartType.SelectedItem.ToString)
                    Next
                    SubGraficas = False
                End If

                Dt_Final.Rows.Clear()
                Dt_Final.Columns.Clear()
                Dt_Final.Columns.Add("Concepto", GetType(String))
                Dt_Final.Columns.Add("Cantidad1", GetType(Integer))
                Select Case ColumnasAñadir
                    Case 2 'Columnas: Concepto y Cantidad1
                        For Each ILocal In q1
                            Dt_Final.Rows.Add(ILocal.Concepto, ILocal.Cantidad)
                        Next
                    Case 3 'Columnas: Concepto, Cantidad1 y Cantidad2
                        Dt_Final.Columns.Add("Cantidad2", GetType(Integer))
                        For Each ILocal In q1
                            Dt_Final.Rows.Add(ILocal.Concepto, ILocal.Cantidad1, ILocal.Cantidad2)
                        Next
                End Select
                chr_Grafica.DataSource = Nothing
                chr_Grafica.DataSource = Dt_Final
                chr_Grafica.ChartAreas(0).RecalculateAxesScale()
                chr_Grafica.Invalidate()
                Call Botones()
            End If
        Catch ex As Exception
            pct_Logo.Dock = DockStyle.Fill
            pct_Logo.Visible = True
            chr_Grafica.Visible = False
            gbx_Estilo.Enabled = False
            gbx_Estilo.Enabled = chr_Grafica.Visible
            MsgBox("No se pudo Realizar la Profundización.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chr_Grafica_GetToolTipText(ByVal sender As Object, ByVal e As System.Windows.Forms.DataVisualization.Charting.ToolTipEventArgs) Handles chr_Grafica.GetToolTipText
        SegundosDesconexion = 0
        '' Check selected chart element and set tooltip text
        Select Case e.HitTestResult.ChartElementType
            Case ChartElementType.Axis
                e.Text = e.HitTestResult.Axis.Name
            Case ChartElementType.ScrollBarLargeDecrement
                e.Text = "Decremento Largo de la Barra de Desplazamiento"
            Case ChartElementType.ScrollBarLargeIncrement
                e.Text = "Incremento Largo de la Barra de Desplazamiento"
            Case ChartElementType.ScrollBarSmallDecrement
                e.Text = "Decremento Corto de la Barra de Desplazamiento"
            Case ChartElementType.ScrollBarSmallIncrement
                e.Text = "Incremento Corto de la Barra de Desplazamiento"
            Case ChartElementType.ScrollBarThumbTracker
                e.Text = "Seguimiento de la Barra de Desplazamiento"
            Case ChartElementType.ScrollBarZoomReset
                e.Text = "Botón para Restablecer el Acercamiento"
                'Case ChartElementType.DataPoint
                '    'e.Text = "Data Point " + e.HitTestResult.PointIndex.ToString
            Case ChartElementType.Gridlines
                e.Text = "Líneas de Divisiones"
            Case ChartElementType.LegendArea
                e.Text = "Área de la Leyenda"
            Case ChartElementType.LegendItem
                e.Text = "Elemento de la Leyenda"
            Case ChartElementType.PlottingArea
                e.Text = "Área de Trazado"
            Case ChartElementType.StripLines
                e.Text = "Franjas de Líneas"
            Case ChartElementType.TickMarks
                e.Text = "Marcas de Graduación"
            Case ChartElementType.Title
                e.Text = "Título"
        End Select
    End Sub

    Private Sub cmb_ChartType_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ChartType.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Series.Count > 0 Then
                For Each Serie As Series In chr_Grafica.Series
                    Serie.ChartType = SeriesChartType.Parse(GetType(SeriesChartType), cmb_ChartType.SelectedItem.ToString)
                Next
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chk_3D_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_3D.CheckedChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.ChartAreas.Count > 0 AndAlso chr_Grafica.Series.Count > 2 Then
                chr_Grafica.ChartAreas(0).Area3DStyle.Enable3D = chk_3D.Checked
                chk_Cluster.Enabled = chk_3D.Checked
                chk_Cluster.Checked = False
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chk_Cluster_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Cluster.CheckedChanged
        SegundosDesconexion = 0
        Try
            If chk_3D.Checked Then chr_Grafica.ChartAreas(0).Area3DStyle.IsClustered = chk_Cluster.Checked
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_ColumnColor_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ColumnColor.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Series.Count > 0 Then chr_Grafica.Palette = ChartColorPalette.Parse(GetType(ChartColorPalette), cmb_ColumnColor.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_BackColorChart_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BackColorChart.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.ChartAreas.Count > 0 Then chr_Grafica.ChartAreas(0).BackColor = Color.FromName(cmb_BackColorChart.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chk_GridLines_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_GridLines.CheckedChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.ChartAreas.Count > 0 Then
                chr_Grafica.ChartAreas(0).AxisX.MajorGrid.Enabled = chk_GridLines.Checked
                chr_Grafica.ChartAreas(0).AxisY.MajorGrid.Enabled = chk_GridLines.Checked
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_BackColor1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BackColor1.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible Then chr_Grafica.BackColor = Color.FromName(cmb_BackColor1.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_BackColor2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BackColor2.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible Then chr_Grafica.BackSecondaryColor = Color.FromName(cmb_BackColor2.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_BackGradient_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_BackGradient.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible Then
                chr_Grafica.BackGradientStyle = GradientStyle.Parse(GetType(GradientStyle), cmb_BackGradient.SelectedItem.ToString)
                cmb_BackColor2.Enabled = chr_Grafica.BackGradientStyle <> GradientStyle.None
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chk_Leyenda_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_LeyendaN.CheckedChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Legends.Count > 0 Then
                chr_Grafica.Legends(0).Enabled = Not chk_LeyendaN.Checked
                cmb_LegendDocking.Enabled = Not chk_LeyendaN.Checked
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub cmb_LegendDocking_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_LegendDocking.SelectedIndexChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Legends.Count > 0 Then chr_Grafica.Legends(0).Docking = Docking.Parse(GetType(Docking), cmb_LegendDocking.SelectedItem.ToString)
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub tbx_Titulo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Titulo.TextChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Titles.Count > 0 Then
                chr_Grafica.Titles(0).Visible = tbx_Titulo.Text <> ""
                chr_Grafica.Titles(0).Text = tbx_Titulo.Text
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub tbx_EjeX_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_EjeX.TextChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.ChartAreas.Count > 0 Then chr_Grafica.ChartAreas(0).AxisX.Title = tbx_EjeX.Text
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub tbx_EjeY_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_EjeY.TextChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.ChartAreas.Count > 0 Then chr_Grafica.ChartAreas(0).AxisY.Title = tbx_EjeY.Text
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub chk_Valores_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Valores.CheckedChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Series.Count > 0 Then
                For Each Serie As Series In chr_Grafica.Series
                    Serie.IsValueShownAsLabel = chk_Valores.Checked
                Next
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub tbx_Serie1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Serie1.TextChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Series.Count > 0 Then
                If tbx_Serie1.Text <> "" Then
                    chr_Grafica.Series(0).Name = tbx_Serie1.Text
                Else
                    chr_Grafica.Series(0).Name = 1
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub tbx_Serie2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Serie2.TextChanged
        SegundosDesconexion = 0
        Try
            If chr_Grafica.Visible AndAlso chr_Grafica.Series.Count > 0 Then
                If tbx_Serie2.Text <> "" Then
                    chr_Grafica.Series(1).Name = tbx_Serie2.Text
                Else
                    chr_Grafica.Series(1).Name = 2
                End If
            End If
        Catch ex As Exception
            MsgBox("No se pudo realizar el Cambio", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

#Region "KEYPRESS"

    Private Sub cmb_ChartType_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_ChartType.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then chk_3D.Focus()
    End Sub

    Private Sub chk_3D_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_3D.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If chk_Cluster.Enabled Then
                chk_Cluster.Focus()
            ElseIf chk_Profundizar.Enabled Then
                chk_Profundizar.Focus()
            Else
                cmb_ColumnColor.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Cluster_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Cluster.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If chk_Profundizar.Enabled Then
                chk_Profundizar.Focus()
            Else
                cmb_ColumnColor.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Profundizar_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Profundizar.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_ColumnColor.Focus()
    End Sub

    Private Sub cmb_ColumnColor_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_ColumnColor.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_BackColorChart.Focus()
    End Sub

    Private Sub cmb_BackColorChart_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BackColorChart.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then chk_GridLines.Focus()
    End Sub

    Private Sub chk_GridLines_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_GridLines.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_BackColor1.Focus()
    End Sub

    Private Sub cmb_BackColor1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BackColor1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_BackColor2.Enabled Then
                cmb_BackColor2.Focus()
            Else
                cmb_BackGradient.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_BackColor2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BackColor2.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_BackGradient.Focus()
    End Sub

    Private Sub cmb_BackGradient_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_BackGradient.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_LegendDocking.Enabled Then
                cmb_LegendDocking.Focus()
            Else
                chk_LeyendaN.Focus()
            End If
        End If
    End Sub

    Private Sub cmb_LegendDocking_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_LegendDocking.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then chk_LeyendaN.Focus()
    End Sub

    Private Sub chk_LeyendaN_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_LeyendaN.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then tbx_Titulo.Focus()
    End Sub

    Private Sub tbx_Serie1_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Serie1.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If tbx_Serie2.Enabled Then
                tbx_Serie2.Focus()
            Else
                chk_Valores.Focus()
            End If
        End If
    End Sub

    Private Sub chk_Valores_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles chk_Valores.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then btn_ExportarGrafica.Focus()
    End Sub

#End Region

    Private Sub btn_ExportarGrafico_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CopiarGrafico.Click
        SegundosDesconexion = 0

        Dim stream As New System.IO.MemoryStream()
        chr_Grafica.SaveImage(stream, System.Drawing.Imaging.ImageFormat.Bmp)
        Dim bmp As New Bitmap(stream)
        Clipboard.SetDataObject(bmp)
    End Sub

    Private Sub btn_ExportarGrafica_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarGrafica.Click
        SegundosDesconexion = 0

        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "JPEG (*.jpg)|*.jpg"
        saveFileDialog1.RestoreDirectory = True
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            chr_Grafica.SaveImage(saveFileDialog1.FileName, ChartImageFormat.Jpeg)
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    'Sub Limpiar()
    '    If chr_Grafica.ChartAreas.Count > 0 Then chr_Grafica.ChartAreas.RemoveAt(0)
    '    If chr_Grafica.Titles.Count > 0 Then chr_Grafica.Titles.RemoveAt(0)
    '    If chr_Grafica.Legends.Count > 0 Then chr_Grafica.Legends.RemoveAt(0)
    '    For Serie As Integer = 0 To chr_Grafica.Series.Count - 1
    '        chr_Grafica.Series.RemoveAt(0)
    '    Next
    '    chr_Grafica.DataSource = Nothing
    '    chr_Grafica.Visible = False
    '    gbx_Estilo.Enabled = False
    '    pct_Logo.Visible = True
    'End Sub

    'Private Sub chr_Grafica_AxisScrollBarClicked(ByVal sender As Object, ByVal e As ScrollBarEventArgs) Handles chr_Grafica.AxisScrollBarClicked
    '    ' Handle zoom reset button
    '    If e.ButtonType = ScrollBarButtonType.ZoomReset Then
    '        ' Event is handled, no more processing required
    '        e.IsHandled = True

    '        ' Reset zoom on X and Y axis
    '        chr_Grafica.ChartAreas(0).AxisX.ScaleView.ZoomReset()
    '        chr_Grafica.ChartAreas(0).AxisY.ScaleView.ZoomReset()
    '    End If
    '    'ScrollBarClick = True
    'End Sub

    'Private Sub chr_Grafica_MouseUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles chr_Grafica.MouseUp
    '    SegundosDesconexion = 0
    '    If chk_Profundizar.Checked = False AndAlso chr_Grafica.ChartAreas(0).Area3DStyle.Enable3D = False AndAlso ScrollBarClick = False Then
    '        ' Zoom into the X axis
    '        chr_Grafica.ChartAreas(0).AxisX.ScaleView.Zoom(0, 0)
    '        chr_Grafica.ChartAreas(0).AxisY.ScaleView.Zoom(0, 0)

    '        ' Enable range selection and zooming end user interface
    '        chr_Grafica.ChartAreas(0).AxisX.ScaleView.Zoomable = True
    '        chr_Grafica.ChartAreas(0).AxisX.ScrollBar.IsPositionedInside = True
    '        chr_Grafica.ChartAreas(0).AxisX.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All
    '        chr_Grafica.ChartAreas(0).AxisY.ScaleView.Zoomable = True
    '        chr_Grafica.ChartAreas(0).AxisY.ScrollBar.IsPositionedInside = True
    '        chr_Grafica.ChartAreas(0).AxisY.ScrollBar.ButtonStyle = ScrollBarButtonStyles.All

    '        ' Change the scrollbar size
    '        chr_Grafica.ChartAreas(0).AxisX.ScrollBar.Size = 10
    '        chr_Grafica.ChartAreas(0).AxisY.ScrollBar.Size = 10

    '        ScrollBarClick = False
    '    End If
    'End Sub

    'Private Sub chk_Profundizar_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Profundizar.CheckedChanged
    '    '**********************************SCROLLBAR**********************************'
    '    '' Enable range selection and zooming end user interface
    '    chr_Grafica.ChartAreas(0).CursorX.IsUserEnabled = Not chk_Profundizar.Checked
    '    chr_Grafica.ChartAreas(0).CursorX.IsUserSelectionEnabled = Not chk_Profundizar.Checked
    '    chr_Grafica.ChartAreas(0).CursorY.IsUserEnabled = Not chk_Profundizar.Checked
    '    chr_Grafica.ChartAreas(0).CursorY.IsUserSelectionEnabled = Not chk_Profundizar.Checked
    'End Sub

End Class