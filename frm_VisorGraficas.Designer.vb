<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisorGraficas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.gbx_Grafico = New System.Windows.Forms.GroupBox
        Me.pct_Logo = New System.Windows.Forms.PictureBox
        Me.chr_Grafica = New System.Windows.Forms.DataVisualization.Charting.Chart
        Me.chk_Profundizar = New System.Windows.Forms.CheckBox
        Me.gbx_Estilo = New System.Windows.Forms.GroupBox
        Me.lbl_Series = New System.Windows.Forms.Label
        Me.tbx_Serie2 = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Serie1 = New Modulo_Reclutamiento.cp_Textbox
        Me.chk_GridLines = New System.Windows.Forms.CheckBox
        Me.chk_Cluster = New System.Windows.Forms.CheckBox
        Me.cmb_ColumnColor = New System.Windows.Forms.ComboBox
        Me.lbl_ColumnColor = New System.Windows.Forms.Label
        Me.chk_Valores = New System.Windows.Forms.CheckBox
        Me.lbl_LeyendaP = New System.Windows.Forms.Label
        Me.cmb_BackColor2 = New System.Windows.Forms.ComboBox
        Me.lbl_Titulo = New System.Windows.Forms.Label
        Me.cmb_LegendDocking = New System.Windows.Forms.ComboBox
        Me.lbl_Eje = New System.Windows.Forms.Label
        Me.cmb_BackColorChart = New System.Windows.Forms.ComboBox
        Me.lbl_BackColorChart = New System.Windows.Forms.Label
        Me.chk_LeyendaN = New System.Windows.Forms.CheckBox
        Me.tbx_EjeY = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_EjeX = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Titulo = New Modulo_Reclutamiento.cp_Textbox
        Me.chk_3D = New System.Windows.Forms.CheckBox
        Me.cmb_ChartType = New System.Windows.Forms.ComboBox
        Me.lbl_Type = New System.Windows.Forms.Label
        Me.cmb_BackGradient = New System.Windows.Forms.ComboBox
        Me.cmb_BackColor1 = New System.Windows.Forms.ComboBox
        Me.lbl_Gradient = New System.Windows.Forms.Label
        Me.lbl_BackColor = New System.Windows.Forms.Label
        Me.btn_ExportarGrafica = New System.Windows.Forms.Button
        Me.btn_CopiarGrafico = New System.Windows.Forms.Button
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tlt_Mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbx_Grafico.SuspendLayout()
        CType(Me.pct_Logo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chr_Grafica, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Estilo.SuspendLayout()
        Me.gbx_Controles.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Grafico
        '
        Me.gbx_Grafico.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Grafico.Controls.Add(Me.pct_Logo)
        Me.gbx_Grafico.Controls.Add(Me.chr_Grafica)
        Me.gbx_Grafico.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Grafico.Name = "gbx_Grafico"
        Me.gbx_Grafico.Size = New System.Drawing.Size(671, 265)
        Me.gbx_Grafico.TabIndex = 0
        Me.gbx_Grafico.TabStop = False
        Me.gbx_Grafico.Text = "Gráfico"
        '
        'pct_Logo
        '
        Me.pct_Logo.BackColor = System.Drawing.Color.Transparent
        Me.pct_Logo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Logo.ErrorImage = Nothing
        Me.pct_Logo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Logo.Location = New System.Drawing.Point(3, 16)
        Me.pct_Logo.Name = "pct_Logo"
        Me.pct_Logo.Size = New System.Drawing.Size(100, 65)
        Me.pct_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Logo.TabIndex = 10
        Me.pct_Logo.TabStop = False
        '
        'chr_Grafica
        '
        Me.chr_Grafica.BackColor = System.Drawing.Color.Silver
        Me.chr_Grafica.BackSecondaryColor = System.Drawing.Color.Silver
        Me.chr_Grafica.BorderlineColor = System.Drawing.Color.Transparent
        Me.chr_Grafica.Dock = System.Windows.Forms.DockStyle.Fill
        Me.chr_Grafica.Location = New System.Drawing.Point(3, 16)
        Me.chr_Grafica.Name = "chr_Grafica"
        Me.chr_Grafica.Size = New System.Drawing.Size(665, 246)
        Me.chr_Grafica.TabIndex = 0
        Me.chr_Grafica.TabStop = False
        Me.chr_Grafica.Text = "Chart1"
        Me.chr_Grafica.Visible = False
        '
        'chk_Profundizar
        '
        Me.chk_Profundizar.AutoSize = True
        Me.chk_Profundizar.Location = New System.Drawing.Point(397, 14)
        Me.chk_Profundizar.Name = "chk_Profundizar"
        Me.chk_Profundizar.Size = New System.Drawing.Size(85, 17)
        Me.chk_Profundizar.TabIndex = 4
        Me.chk_Profundizar.Text = "Profundiazar"
        Me.tlt_Mensaje.SetToolTip(Me.chk_Profundizar, "Mostrar Subgráficas")
        Me.chk_Profundizar.UseVisualStyleBackColor = True
        '
        'gbx_Estilo
        '
        Me.gbx_Estilo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Estilo.Controls.Add(Me.chk_Profundizar)
        Me.gbx_Estilo.Controls.Add(Me.lbl_Series)
        Me.gbx_Estilo.Controls.Add(Me.tbx_Serie2)
        Me.gbx_Estilo.Controls.Add(Me.tbx_Serie1)
        Me.gbx_Estilo.Controls.Add(Me.chk_GridLines)
        Me.gbx_Estilo.Controls.Add(Me.chk_Cluster)
        Me.gbx_Estilo.Controls.Add(Me.cmb_ColumnColor)
        Me.gbx_Estilo.Controls.Add(Me.lbl_ColumnColor)
        Me.gbx_Estilo.Controls.Add(Me.chk_Valores)
        Me.gbx_Estilo.Controls.Add(Me.lbl_LeyendaP)
        Me.gbx_Estilo.Controls.Add(Me.cmb_BackColor2)
        Me.gbx_Estilo.Controls.Add(Me.lbl_Titulo)
        Me.gbx_Estilo.Controls.Add(Me.cmb_LegendDocking)
        Me.gbx_Estilo.Controls.Add(Me.lbl_Eje)
        Me.gbx_Estilo.Controls.Add(Me.cmb_BackColorChart)
        Me.gbx_Estilo.Controls.Add(Me.lbl_BackColorChart)
        Me.gbx_Estilo.Controls.Add(Me.chk_LeyendaN)
        Me.gbx_Estilo.Controls.Add(Me.tbx_EjeY)
        Me.gbx_Estilo.Controls.Add(Me.tbx_EjeX)
        Me.gbx_Estilo.Controls.Add(Me.tbx_Titulo)
        Me.gbx_Estilo.Controls.Add(Me.chk_3D)
        Me.gbx_Estilo.Controls.Add(Me.cmb_ChartType)
        Me.gbx_Estilo.Controls.Add(Me.lbl_Type)
        Me.gbx_Estilo.Controls.Add(Me.cmb_BackGradient)
        Me.gbx_Estilo.Controls.Add(Me.cmb_BackColor1)
        Me.gbx_Estilo.Controls.Add(Me.lbl_Gradient)
        Me.gbx_Estilo.Controls.Add(Me.lbl_BackColor)
        Me.gbx_Estilo.Enabled = False
        Me.gbx_Estilo.Location = New System.Drawing.Point(6, 273)
        Me.gbx_Estilo.Name = "gbx_Estilo"
        Me.gbx_Estilo.Size = New System.Drawing.Size(671, 278)
        Me.gbx_Estilo.TabIndex = 1
        Me.gbx_Estilo.TabStop = False
        Me.gbx_Estilo.Text = "Estilo de la Gráfica"
        '
        'lbl_Series
        '
        Me.lbl_Series.AutoSize = True
        Me.lbl_Series.Location = New System.Drawing.Point(103, 229)
        Me.lbl_Series.Name = "lbl_Series"
        Me.lbl_Series.Size = New System.Drawing.Size(36, 13)
        Me.lbl_Series.TabIndex = 23
        Me.lbl_Series.Text = "Series"
        '
        'tbx_Serie2
        '
        Me.tbx_Serie2.Control_Siguiente = Nothing
        Me.tbx_Serie2.Enabled = False
        Me.tbx_Serie2.Filtrado = True
        Me.tbx_Serie2.Location = New System.Drawing.Point(316, 226)
        Me.tbx_Serie2.MaxLength = 10
        Me.tbx_Serie2.Name = "tbx_Serie2"
        Me.tbx_Serie2.Size = New System.Drawing.Size(166, 20)
        Me.tbx_Serie2.TabIndex = 25
        Me.tbx_Serie2.Text = "SERIE 2"
        Me.tbx_Serie2.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_Serie2, "Nombre de la Segunda Serie (Máximo 10 Caracteres)")
        '
        'tbx_Serie1
        '
        Me.tbx_Serie1.Control_Siguiente = Nothing
        Me.tbx_Serie1.Filtrado = True
        Me.tbx_Serie1.Location = New System.Drawing.Point(145, 226)
        Me.tbx_Serie1.MaxLength = 10
        Me.tbx_Serie1.Name = "tbx_Serie1"
        Me.tbx_Serie1.Size = New System.Drawing.Size(166, 20)
        Me.tbx_Serie1.TabIndex = 24
        Me.tbx_Serie1.Text = "SERIE 1"
        Me.tbx_Serie1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_Serie1, "Nombre de la Primer Serie (Máximo 10 Caracteres)")
        '
        'chk_GridLines
        '
        Me.chk_GridLines.AutoSize = True
        Me.chk_GridLines.Checked = True
        Me.chk_GridLines.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_GridLines.Location = New System.Drawing.Point(272, 68)
        Me.chk_GridLines.Name = "chk_GridLines"
        Me.chk_GridLines.Size = New System.Drawing.Size(114, 17)
        Me.chk_GridLines.TabIndex = 9
        Me.chk_GridLines.Text = "Líneas de División"
        Me.chk_GridLines.UseVisualStyleBackColor = True
        '
        'chk_Cluster
        '
        Me.chk_Cluster.AutoSize = True
        Me.chk_Cluster.Enabled = False
        Me.chk_Cluster.Location = New System.Drawing.Point(328, 14)
        Me.chk_Cluster.Name = "chk_Cluster"
        Me.chk_Cluster.Size = New System.Drawing.Size(63, 17)
        Me.chk_Cluster.TabIndex = 3
        Me.chk_Cluster.Text = "Agrupar"
        Me.tlt_Mensaje.SetToolTip(Me.chk_Cluster, "Agrupa las Series del Gráfico")
        Me.chk_Cluster.UseVisualStyleBackColor = True
        '
        'cmb_ColumnColor
        '
        Me.cmb_ColumnColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColumnColor.FormattingEnabled = True
        Me.cmb_ColumnColor.Location = New System.Drawing.Point(145, 39)
        Me.cmb_ColumnColor.MaxDropDownItems = 20
        Me.cmb_ColumnColor.Name = "cmb_ColumnColor"
        Me.cmb_ColumnColor.Size = New System.Drawing.Size(121, 21)
        Me.cmb_ColumnColor.Sorted = True
        Me.cmb_ColumnColor.TabIndex = 6
        '
        'lbl_ColumnColor
        '
        Me.lbl_ColumnColor.AutoSize = True
        Me.lbl_ColumnColor.Location = New System.Drawing.Point(28, 42)
        Me.lbl_ColumnColor.Name = "lbl_ColumnColor"
        Me.lbl_ColumnColor.Size = New System.Drawing.Size(111, 13)
        Me.lbl_ColumnColor.TabIndex = 5
        Me.lbl_ColumnColor.Text = "Color de las Columnas"
        '
        'chk_Valores
        '
        Me.chk_Valores.AutoSize = True
        Me.chk_Valores.Checked = True
        Me.chk_Valores.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Valores.Location = New System.Drawing.Point(145, 250)
        Me.chk_Valores.Name = "chk_Valores"
        Me.chk_Valores.Size = New System.Drawing.Size(169, 17)
        Me.chk_Valores.TabIndex = 26
        Me.chk_Valores.Text = "Mostrar Valores de la Consulta"
        Me.tlt_Mensaje.SetToolTip(Me.chk_Valores, "Se Muestran u Ocultan los Valores de la Series")
        Me.chk_Valores.UseVisualStyleBackColor = True
        '
        'lbl_LeyendaP
        '
        Me.lbl_LeyendaP.AutoSize = True
        Me.lbl_LeyendaP.Location = New System.Drawing.Point(33, 150)
        Me.lbl_LeyendaP.Name = "lbl_LeyendaP"
        Me.lbl_LeyendaP.Size = New System.Drawing.Size(106, 13)
        Me.lbl_LeyendaP.TabIndex = 15
        Me.lbl_LeyendaP.Text = "Posición de Leyenda"
        '
        'cmb_BackColor2
        '
        Me.cmb_BackColor2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BackColor2.Enabled = False
        Me.cmb_BackColor2.FormattingEnabled = True
        Me.cmb_BackColor2.Location = New System.Drawing.Point(272, 93)
        Me.cmb_BackColor2.MaxDropDownItems = 20
        Me.cmb_BackColor2.Name = "cmb_BackColor2"
        Me.cmb_BackColor2.Size = New System.Drawing.Size(121, 21)
        Me.cmb_BackColor2.Sorted = True
        Me.cmb_BackColor2.TabIndex = 12
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Location = New System.Drawing.Point(104, 177)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Titulo.TabIndex = 18
        Me.lbl_Titulo.Text = "Título"
        '
        'cmb_LegendDocking
        '
        Me.cmb_LegendDocking.DisplayMember = "Posición de la Leyenda en el Gráfico"
        Me.cmb_LegendDocking.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LegendDocking.FormattingEnabled = True
        Me.cmb_LegendDocking.Location = New System.Drawing.Point(145, 147)
        Me.cmb_LegendDocking.MaxDropDownItems = 20
        Me.cmb_LegendDocking.Name = "cmb_LegendDocking"
        Me.cmb_LegendDocking.Size = New System.Drawing.Size(121, 21)
        Me.cmb_LegendDocking.Sorted = True
        Me.cmb_LegendDocking.TabIndex = 16
        Me.cmb_LegendDocking.ValueMember = "Posición de la Leyenda en el Gráfico"
        '
        'lbl_Eje
        '
        Me.lbl_Eje.AutoSize = True
        Me.lbl_Eje.Location = New System.Drawing.Point(112, 203)
        Me.lbl_Eje.Name = "lbl_Eje"
        Me.lbl_Eje.Size = New System.Drawing.Size(27, 13)
        Me.lbl_Eje.TabIndex = 20
        Me.lbl_Eje.Text = "Ejes"
        '
        'cmb_BackColorChart
        '
        Me.cmb_BackColorChart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BackColorChart.FormattingEnabled = True
        Me.cmb_BackColorChart.Location = New System.Drawing.Point(145, 66)
        Me.cmb_BackColorChart.MaxDropDownItems = 20
        Me.cmb_BackColorChart.Name = "cmb_BackColorChart"
        Me.cmb_BackColorChart.Size = New System.Drawing.Size(121, 21)
        Me.cmb_BackColorChart.Sorted = True
        Me.cmb_BackColorChart.TabIndex = 8
        '
        'lbl_BackColorChart
        '
        Me.lbl_BackColorChart.AutoSize = True
        Me.lbl_BackColorChart.Location = New System.Drawing.Point(6, 69)
        Me.lbl_BackColorChart.Name = "lbl_BackColorChart"
        Me.lbl_BackColorChart.Size = New System.Drawing.Size(133, 13)
        Me.lbl_BackColorChart.TabIndex = 7
        Me.lbl_BackColorChart.Text = "Color de Fondo del Gráfico"
        '
        'chk_LeyendaN
        '
        Me.chk_LeyendaN.AutoSize = True
        Me.chk_LeyendaN.Location = New System.Drawing.Point(272, 149)
        Me.chk_LeyendaN.Name = "chk_LeyendaN"
        Me.chk_LeyendaN.Size = New System.Drawing.Size(66, 17)
        Me.chk_LeyendaN.TabIndex = 17
        Me.chk_LeyendaN.Text = "Ninguna"
        Me.chk_LeyendaN.UseVisualStyleBackColor = True
        '
        'tbx_EjeY
        '
        Me.tbx_EjeY.Control_Siguiente = Me.tbx_Serie1
        Me.tbx_EjeY.Filtrado = True
        Me.tbx_EjeY.Location = New System.Drawing.Point(316, 200)
        Me.tbx_EjeY.MaxLength = 10
        Me.tbx_EjeY.Name = "tbx_EjeY"
        Me.tbx_EjeY.Size = New System.Drawing.Size(166, 20)
        Me.tbx_EjeY.TabIndex = 22
        Me.tbx_EjeY.Text = "EJE Y"
        Me.tbx_EjeY.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_EjeY, "Título del Eje Y (Máx. 10 Caracteres)")
        '
        'tbx_EjeX
        '
        Me.tbx_EjeX.Control_Siguiente = Me.tbx_EjeY
        Me.tbx_EjeX.Filtrado = True
        Me.tbx_EjeX.Location = New System.Drawing.Point(145, 200)
        Me.tbx_EjeX.MaxLength = 10
        Me.tbx_EjeX.Name = "tbx_EjeX"
        Me.tbx_EjeX.Size = New System.Drawing.Size(166, 20)
        Me.tbx_EjeX.TabIndex = 21
        Me.tbx_EjeX.Text = "EJE X"
        Me.tbx_EjeX.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_EjeX, "Título del Eje X (Máx. 10 Caracteres)")
        '
        'tbx_Titulo
        '
        Me.tbx_Titulo.Control_Siguiente = Me.tbx_EjeX
        Me.tbx_Titulo.Filtrado = True
        Me.tbx_Titulo.Location = New System.Drawing.Point(145, 174)
        Me.tbx_Titulo.MaxLength = 50
        Me.tbx_Titulo.Name = "tbx_Titulo"
        Me.tbx_Titulo.Size = New System.Drawing.Size(337, 20)
        Me.tbx_Titulo.TabIndex = 19
        Me.tbx_Titulo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_Titulo, "Título del Gráfico (Máximo 50 Caracteres)")
        '
        'chk_3D
        '
        Me.chk_3D.AutoSize = True
        Me.chk_3D.Location = New System.Drawing.Point(272, 14)
        Me.chk_3D.Name = "chk_3D"
        Me.chk_3D.Size = New System.Drawing.Size(56, 17)
        Me.chk_3D.TabIndex = 2
        Me.chk_3D.Text = "En 3D"
        Me.tlt_Mensaje.SetToolTip(Me.chk_3D, "Mostrar en Estilo 3D la Gráfica")
        Me.chk_3D.UseVisualStyleBackColor = True
        '
        'cmb_ChartType
        '
        Me.cmb_ChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ChartType.FormattingEnabled = True
        Me.cmb_ChartType.Location = New System.Drawing.Point(145, 12)
        Me.cmb_ChartType.MaxDropDownItems = 20
        Me.cmb_ChartType.Name = "cmb_ChartType"
        Me.cmb_ChartType.Size = New System.Drawing.Size(121, 21)
        Me.cmb_ChartType.Sorted = True
        Me.cmb_ChartType.TabIndex = 1
        Me.tlt_Mensaje.SetToolTip(Me.cmb_ChartType, "Estilo de la Gráfica")
        '
        'lbl_Type
        '
        Me.lbl_Type.AutoSize = True
        Me.lbl_Type.Location = New System.Drawing.Point(111, 15)
        Me.lbl_Type.Name = "lbl_Type"
        Me.lbl_Type.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Type.TabIndex = 0
        Me.lbl_Type.Text = "Tipo"
        '
        'cmb_BackGradient
        '
        Me.cmb_BackGradient.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BackGradient.FormattingEnabled = True
        Me.cmb_BackGradient.Location = New System.Drawing.Point(145, 120)
        Me.cmb_BackGradient.MaxDropDownItems = 20
        Me.cmb_BackGradient.Name = "cmb_BackGradient"
        Me.cmb_BackGradient.Size = New System.Drawing.Size(121, 21)
        Me.cmb_BackGradient.Sorted = True
        Me.cmb_BackGradient.TabIndex = 14
        '
        'cmb_BackColor1
        '
        Me.cmb_BackColor1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BackColor1.FormattingEnabled = True
        Me.cmb_BackColor1.Location = New System.Drawing.Point(145, 93)
        Me.cmb_BackColor1.MaxDropDownItems = 20
        Me.cmb_BackColor1.Name = "cmb_BackColor1"
        Me.cmb_BackColor1.Size = New System.Drawing.Size(121, 21)
        Me.cmb_BackColor1.Sorted = True
        Me.cmb_BackColor1.TabIndex = 11
        '
        'lbl_Gradient
        '
        Me.lbl_Gradient.AutoSize = True
        Me.lbl_Gradient.Location = New System.Drawing.Point(36, 123)
        Me.lbl_Gradient.Name = "lbl_Gradient"
        Me.lbl_Gradient.Size = New System.Drawing.Size(103, 13)
        Me.lbl_Gradient.TabIndex = 13
        Me.lbl_Gradient.Text = "Gradiente del Fondo"
        '
        'lbl_BackColor
        '
        Me.lbl_BackColor.AutoSize = True
        Me.lbl_BackColor.Location = New System.Drawing.Point(60, 96)
        Me.lbl_BackColor.Name = "lbl_BackColor"
        Me.lbl_BackColor.Size = New System.Drawing.Size(79, 13)
        Me.lbl_BackColor.TabIndex = 10
        Me.lbl_BackColor.Text = "Color de Fondo"
        '
        'btn_ExportarGrafica
        '
        Me.btn_ExportarGrafica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarGrafica.Enabled = False
        Me.btn_ExportarGrafica.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ExtraerImagenesEmpleado
        Me.btn_ExportarGrafica.Location = New System.Drawing.Point(6, 14)
        Me.btn_ExportarGrafica.Name = "btn_ExportarGrafica"
        Me.btn_ExportarGrafica.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarGrafica.TabIndex = 0
        Me.btn_ExportarGrafica.Text = "Exportar &Gráfica"
        Me.btn_ExportarGrafica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarGrafica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarGrafica.UseVisualStyleBackColor = True
        '
        'btn_CopiarGrafico
        '
        Me.btn_CopiarGrafico.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CopiarGrafico.Enabled = False
        Me.btn_CopiarGrafico.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ExtraerImagenesEmpleado
        Me.btn_CopiarGrafico.Location = New System.Drawing.Point(152, 14)
        Me.btn_CopiarGrafico.Name = "btn_CopiarGrafico"
        Me.btn_CopiarGrafico.Size = New System.Drawing.Size(140, 30)
        Me.btn_CopiarGrafico.TabIndex = 1
        Me.btn_CopiarGrafico.Text = "Copiar G&ráfica"
        Me.btn_CopiarGrafico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CopiarGrafico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CopiarGrafico.UseVisualStyleBackColor = True
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_CopiarGrafico)
        Me.gbx_Controles.Controls.Add(Me.btn_ExportarGrafica)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(6, 557)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(671, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(525, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_VisorGraficas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 611)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Grafico)
        Me.Controls.Add(Me.gbx_Estilo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(700, 650)
        Me.Name = "frm_VisorGraficas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visor de Gráficas"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.gbx_Grafico.ResumeLayout(False)
        CType(Me.pct_Logo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chr_Grafica, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Estilo.ResumeLayout(False)
        Me.gbx_Estilo.PerformLayout()
        Me.gbx_Controles.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Grafico As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Profundizar As System.Windows.Forms.CheckBox
    Friend WithEvents pct_Logo As System.Windows.Forms.PictureBox
    Friend WithEvents chr_Grafica As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents gbx_Estilo As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Series As System.Windows.Forms.Label
    Friend WithEvents tbx_Serie2 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Serie1 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents chk_GridLines As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Cluster As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_ColumnColor As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_ColumnColor As System.Windows.Forms.Label
    Friend WithEvents chk_Valores As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_LeyendaP As System.Windows.Forms.Label
    Friend WithEvents cmb_BackColor2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents cmb_LegendDocking As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Eje As System.Windows.Forms.Label
    Friend WithEvents cmb_BackColorChart As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_BackColorChart As System.Windows.Forms.Label
    Friend WithEvents chk_LeyendaN As System.Windows.Forms.CheckBox
    Friend WithEvents tbx_EjeY As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_EjeX As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Titulo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents chk_3D As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_ChartType As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Type As System.Windows.Forms.Label
    Friend WithEvents cmb_BackGradient As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_BackColor1 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Gradient As System.Windows.Forms.Label
    Friend WithEvents lbl_BackColor As System.Windows.Forms.Label
    Friend WithEvents btn_ExportarGrafica As System.Windows.Forms.Button
    Friend WithEvents btn_CopiarGrafico As System.Windows.Forms.Button
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tlt_Mensaje As System.Windows.Forms.ToolTip
End Class
