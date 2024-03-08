<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Consulta_Documentacion_Contratacion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Consulta_Documentacion_Contratacion))
        Dim ListViewColumnSorter6 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter4 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter5 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Me.TabDocumentosProspectos = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_filtro = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview()
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_Aptos = New System.Windows.Forms.CheckBox()
        Me.Lbl_LDepartamento = New System.Windows.Forms.Label()
        Me.lbl_apto = New System.Windows.Forms.Label()
        Me.Lbl_LPuesto = New System.Windows.Forms.Label()
        Me.cmb_aptos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_LStatus = New System.Windows.Forms.Label()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button()
        Me.Lbl_Desde = New System.Windows.Forms.Label()
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox()
        Me.Dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox()
        Me.Dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.TabDocumentos = New System.Windows.Forms.TabPage()
        Me.lsv_documentospros = New Modulo_Reclutamiento.cp_Listview()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_path = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.cp_lsv_ResultadosExamen = New Modulo_Reclutamiento.cp_Listview()
        Me.btn_ExamenB = New System.Windows.Forms.Button()
        Me.btn_CuestionarioMedico = New System.Windows.Forms.Button()
        Me.btn_ContratoLaboral = New System.Windows.Forms.Button()
        Me.btn_AvisoPrivacidad = New System.Windows.Forms.Button()
        Me.btn_ConvenioConfidencialidad = New System.Windows.Forms.Button()
        Me.btn_Concentimientos = New System.Windows.Forms.Button()
        Me.btn_CartaConfidencialidad = New System.Windows.Forms.Button()
        Me.btn_AvisoCandidatos = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TabDocumentosProspectos.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabDocumentos.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabDocumentosProspectos
        '
        Me.TabDocumentosProspectos.Controls.Add(Me.TabPage1)
        Me.TabDocumentosProspectos.Controls.Add(Me.TabDocumentos)
        Me.TabDocumentosProspectos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabDocumentosProspectos.Location = New System.Drawing.Point(0, 0)
        Me.TabDocumentosProspectos.Name = "TabDocumentosProspectos"
        Me.TabDocumentosProspectos.SelectedIndex = 0
        Me.TabDocumentosProspectos.Size = New System.Drawing.Size(800, 450)
        Me.TabDocumentosProspectos.TabIndex = 152
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.cmb_filtro)
        Me.TabPage1.Controls.Add(Me.btn_Modificar)
        Me.TabPage1.Controls.Add(Me.Lbl_Numero)
        Me.TabPage1.Controls.Add(Me.lsv_Catalogo)
        Me.TabPage1.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.TabPage1.Controls.Add(Me.chk_Aptos)
        Me.TabPage1.Controls.Add(Me.Lbl_LDepartamento)
        Me.TabPage1.Controls.Add(Me.lbl_apto)
        Me.TabPage1.Controls.Add(Me.Lbl_LPuesto)
        Me.TabPage1.Controls.Add(Me.cmb_aptos)
        Me.TabPage1.Controls.Add(Me.Lbl_LStatus)
        Me.TabPage1.Controls.Add(Me.Lbl_Hasta)
        Me.TabPage1.Controls.Add(Me.btn_MostrarCatalogo)
        Me.TabPage1.Controls.Add(Me.Lbl_Desde)
        Me.TabPage1.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.TabPage1.Controls.Add(Me.Dtp_Desde)
        Me.TabPage1.Controls.Add(Me.chk_PuestoFiltro)
        Me.TabPage1.Controls.Add(Me.Dtp_Hasta)
        Me.TabPage1.Controls.Add(Me.cmb_PuestoFiltro)
        Me.TabPage1.Controls.Add(Me.chk_Status)
        Me.TabPage1.Controls.Add(Me.cmb_Status)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(792, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Prospectos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 155
        Me.Label1.Text = "Filtro:"
        '
        'cmb_filtro
        '
        Me.cmb_filtro.Control_Siguiente = Nothing
        Me.cmb_filtro.DisplayMember = "display"
        Me.cmb_filtro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_filtro.FormattingEnabled = True
        Me.cmb_filtro.Location = New System.Drawing.Point(103, 24)
        Me.cmb_filtro.MaxDropDownItems = 20
        Me.cmb_filtro.Name = "cmb_filtro"
        Me.cmb_filtro.Size = New System.Drawing.Size(121, 21)
        Me.cmb_filtro.TabIndex = 154
        Me.cmb_filtro.ValueMember = "value"
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(12, 383)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Modificar.TabIndex = 153
        Me.btn_Modificar.Text = "&Ver Informacion"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(564, 125)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 152
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 221)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter6
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 32
        Me.lsv_Catalogo.Row3 = 14
        Me.lsv_Catalogo.Row4 = 14
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(780, 156)
        Me.lsv_Catalogo.TabIndex = 151
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'cmb_DepartamentoFiltro
        '
        Me.cmb_DepartamentoFiltro.Clave = Nothing
        Me.cmb_DepartamentoFiltro.Control_Siguiente = Nothing
        Me.cmb_DepartamentoFiltro.DisplayMember = "Descripcion"
        Me.cmb_DepartamentoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DepartamentoFiltro.Empresa = False
        Me.cmb_DepartamentoFiltro.Filtro = Nothing
        Me.cmb_DepartamentoFiltro.FormattingEnabled = True
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(100, 77)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 140
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_Aptos
        '
        Me.chk_Aptos.AutoSize = True
        Me.chk_Aptos.Location = New System.Drawing.Point(234, 161)
        Me.chk_Aptos.Name = "chk_Aptos"
        Me.chk_Aptos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Aptos.TabIndex = 150
        Me.chk_Aptos.Text = "Todos"
        Me.chk_Aptos.UseVisualStyleBackColor = True
        '
        'Lbl_LDepartamento
        '
        Me.Lbl_LDepartamento.AutoSize = True
        Me.Lbl_LDepartamento.Location = New System.Drawing.Point(20, 80)
        Me.Lbl_LDepartamento.Name = "Lbl_LDepartamento"
        Me.Lbl_LDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_LDepartamento.TabIndex = 134
        Me.Lbl_LDepartamento.Text = "Departamento"
        '
        'lbl_apto
        '
        Me.lbl_apto.AutoSize = True
        Me.lbl_apto.Location = New System.Drawing.Point(57, 163)
        Me.lbl_apto.Name = "lbl_apto"
        Me.lbl_apto.Size = New System.Drawing.Size(29, 13)
        Me.lbl_apto.TabIndex = 149
        Me.lbl_apto.Text = "Apto"
        '
        'Lbl_LPuesto
        '
        Me.Lbl_LPuesto.AutoSize = True
        Me.Lbl_LPuesto.Location = New System.Drawing.Point(54, 107)
        Me.Lbl_LPuesto.Name = "Lbl_LPuesto"
        Me.Lbl_LPuesto.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_LPuesto.TabIndex = 136
        Me.Lbl_LPuesto.Text = "Puesto"
        '
        'cmb_aptos
        '
        Me.cmb_aptos.Control_Siguiente = Nothing
        Me.cmb_aptos.DisplayMember = "display"
        Me.cmb_aptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aptos.FormattingEnabled = True
        Me.cmb_aptos.Location = New System.Drawing.Point(100, 159)
        Me.cmb_aptos.MaxDropDownItems = 20
        Me.cmb_aptos.Name = "cmb_aptos"
        Me.cmb_aptos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_aptos.TabIndex = 148
        Me.cmb_aptos.ValueMember = "value"
        '
        'Lbl_LStatus
        '
        Me.Lbl_LStatus.AutoSize = True
        Me.Lbl_LStatus.Location = New System.Drawing.Point(57, 136)
        Me.Lbl_LStatus.Name = "Lbl_LStatus"
        Me.Lbl_LStatus.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_LStatus.TabIndex = 135
        Me.Lbl_LStatus.Text = "Status"
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(231, 53)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Hasta.TabIndex = 146
        Me.Lbl_Hasta.Text = "Hasta:"
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(345, 146)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(140, 30)
        Me.btn_MostrarCatalogo.TabIndex = 137
        Me.btn_MostrarCatalogo.Text = "M&ostrar"
        Me.btn_MostrarCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarCatalogo.UseVisualStyleBackColor = True
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(56, 54)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Desde.TabIndex = 144
        Me.Lbl_Desde.Text = "Desde:"
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(429, 80)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 138
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'Dtp_Desde
        '
        Me.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Desde.Location = New System.Drawing.Point(103, 51)
        Me.Dtp_Desde.Name = "Dtp_Desde"
        Me.Dtp_Desde.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Desde.TabIndex = 145
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(429, 106)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 139
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'Dtp_Hasta
        '
        Me.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Hasta.Location = New System.Drawing.Point(275, 51)
        Me.Dtp_Hasta.Name = "Dtp_Hasta"
        Me.Dtp_Hasta.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Hasta.TabIndex = 147
        '
        'cmb_PuestoFiltro
        '
        Me.cmb_PuestoFiltro.Clave = Nothing
        Me.cmb_PuestoFiltro.Control_Siguiente = Nothing
        Me.cmb_PuestoFiltro.DisplayMember = "Descripcion"
        Me.cmb_PuestoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PuestoFiltro.Empresa = False
        Me.cmb_PuestoFiltro.Filtro = Nothing
        Me.cmb_PuestoFiltro.FormattingEnabled = True
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(100, 104)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 141
        Me.cmb_PuestoFiltro.Tipo = 0
        Me.cmb_PuestoFiltro.ValueMember = "Id_Puesto"
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(234, 135)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 143
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(100, 131)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Status.TabIndex = 142
        Me.cmb_Status.ValueMember = "value"
        '
        'TabDocumentos
        '
        Me.TabDocumentos.Controls.Add(Me.lsv_documentospros)
        Me.TabDocumentos.Controls.Add(Me.Label2)
        Me.TabDocumentos.Controls.Add(Me.btn_path)
        Me.TabDocumentos.Controls.Add(Me.txt_path)
        Me.TabDocumentos.Controls.Add(Me.Gbx_Botones)
        Me.TabDocumentos.Location = New System.Drawing.Point(4, 22)
        Me.TabDocumentos.Name = "TabDocumentos"
        Me.TabDocumentos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDocumentos.Size = New System.Drawing.Size(792, 424)
        Me.TabDocumentos.TabIndex = 1
        Me.TabDocumentos.Text = "Documentos"
        Me.TabDocumentos.UseVisualStyleBackColor = True
        '
        'lsv_documentospros
        '
        Me.lsv_documentospros.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_documentospros.FullRowSelect = True
        Me.lsv_documentospros.HideSelection = False
        Me.lsv_documentospros.Location = New System.Drawing.Point(12, 49)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_documentospros.Lvs = ListViewColumnSorter4
        Me.lsv_documentospros.MultiSelect = False
        Me.lsv_documentospros.Name = "lsv_documentospros"
        Me.lsv_documentospros.Row1 = 10
        Me.lsv_documentospros.Row10 = 10
        Me.lsv_documentospros.Row2 = 10
        Me.lsv_documentospros.Row3 = 10
        Me.lsv_documentospros.Row4 = 10
        Me.lsv_documentospros.Row5 = 10
        Me.lsv_documentospros.Row6 = 10
        Me.lsv_documentospros.Row7 = 10
        Me.lsv_documentospros.Row8 = 10
        Me.lsv_documentospros.Row9 = 10
        Me.lsv_documentospros.Size = New System.Drawing.Size(771, 66)
        Me.lsv_documentospros.TabIndex = 14
        Me.lsv_documentospros.UseCompatibleStateImageBehavior = False
        Me.lsv_documentospros.View = System.Windows.Forms.View.Details
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(126, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Guardar Documentos en:"
        '
        'btn_path
        '
        Me.btn_path.Location = New System.Drawing.Point(475, 23)
        Me.btn_path.Name = "btn_path"
        Me.btn_path.Size = New System.Drawing.Size(42, 20)
        Me.btn_path.TabIndex = 12
        Me.btn_path.Text = "..."
        Me.btn_path.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_path.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Enabled = False
        Me.txt_path.Location = New System.Drawing.Point(12, 23)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(457, 20)
        Me.txt_path.TabIndex = 11
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Controls.Add(Me.GroupBox2)
        Me.Gbx_Botones.Controls.Add(Me.GroupBox1)
        Me.Gbx_Botones.Controls.Add(Me.cp_lsv_ResultadosExamen)
        Me.Gbx_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Gbx_Botones.Location = New System.Drawing.Point(3, 121)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(786, 300)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'cp_lsv_ResultadosExamen
        '
        Me.cp_lsv_ResultadosExamen.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cp_lsv_ResultadosExamen.FullRowSelect = True
        Me.cp_lsv_ResultadosExamen.HideSelection = False
        Me.cp_lsv_ResultadosExamen.Location = New System.Drawing.Point(9, 0)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.cp_lsv_ResultadosExamen.Lvs = ListViewColumnSorter5
        Me.cp_lsv_ResultadosExamen.MultiSelect = False
        Me.cp_lsv_ResultadosExamen.Name = "cp_lsv_ResultadosExamen"
        Me.cp_lsv_ResultadosExamen.Row1 = 10
        Me.cp_lsv_ResultadosExamen.Row10 = 10
        Me.cp_lsv_ResultadosExamen.Row2 = 10
        Me.cp_lsv_ResultadosExamen.Row3 = 10
        Me.cp_lsv_ResultadosExamen.Row4 = 10
        Me.cp_lsv_ResultadosExamen.Row5 = 10
        Me.cp_lsv_ResultadosExamen.Row6 = 10
        Me.cp_lsv_ResultadosExamen.Row7 = 10
        Me.cp_lsv_ResultadosExamen.Row8 = 10
        Me.cp_lsv_ResultadosExamen.Row9 = 10
        Me.cp_lsv_ResultadosExamen.Size = New System.Drawing.Size(771, 35)
        Me.cp_lsv_ResultadosExamen.TabIndex = 18
        Me.cp_lsv_ResultadosExamen.UseCompatibleStateImageBehavior = False
        Me.cp_lsv_ResultadosExamen.View = System.Windows.Forms.View.Details
        Me.cp_lsv_ResultadosExamen.Visible = False
        '
        'btn_ExamenB
        '
        Me.btn_ExamenB.Enabled = False
        Me.btn_ExamenB.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExamenB.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_ExamenB.Location = New System.Drawing.Point(367, 77)
        Me.btn_ExamenB.Name = "btn_ExamenB"
        Me.btn_ExamenB.Size = New System.Drawing.Size(163, 40)
        Me.btn_ExamenB.TabIndex = 17
        Me.btn_ExamenB.Text = "Examen Barsit"
        Me.btn_ExamenB.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExamenB.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExamenB.UseVisualStyleBackColor = True
        '
        'btn_CuestionarioMedico
        '
        Me.btn_CuestionarioMedico.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CuestionarioMedico.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_CuestionarioMedico.Location = New System.Drawing.Point(351, 19)
        Me.btn_CuestionarioMedico.Name = "btn_CuestionarioMedico"
        Me.btn_CuestionarioMedico.Size = New System.Drawing.Size(187, 40)
        Me.btn_CuestionarioMedico.TabIndex = 11
        Me.btn_CuestionarioMedico.Text = "Cuestionario Medico"
        Me.btn_CuestionarioMedico.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CuestionarioMedico.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CuestionarioMedico.UseVisualStyleBackColor = True
        '
        'btn_ContratoLaboral
        '
        Me.btn_ContratoLaboral.Enabled = False
        Me.btn_ContratoLaboral.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ContratoLaboral.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_ContratoLaboral.Location = New System.Drawing.Point(165, 21)
        Me.btn_ContratoLaboral.Name = "btn_ContratoLaboral"
        Me.btn_ContratoLaboral.Size = New System.Drawing.Size(179, 40)
        Me.btn_ContratoLaboral.TabIndex = 10
        Me.btn_ContratoLaboral.Text = "Contrato Laboral"
        Me.btn_ContratoLaboral.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ContratoLaboral.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ContratoLaboral.UseVisualStyleBackColor = True
        '
        'btn_AvisoPrivacidad
        '
        Me.btn_AvisoPrivacidad.Enabled = False
        Me.btn_AvisoPrivacidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AvisoPrivacidad.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_AvisoPrivacidad.Location = New System.Drawing.Point(350, 21)
        Me.btn_AvisoPrivacidad.Name = "btn_AvisoPrivacidad"
        Me.btn_AvisoPrivacidad.Size = New System.Drawing.Size(134, 40)
        Me.btn_AvisoPrivacidad.TabIndex = 9
        Me.btn_AvisoPrivacidad.Text = "Aviso Privacidad"
        Me.btn_AvisoPrivacidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AvisoPrivacidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AvisoPrivacidad.UseVisualStyleBackColor = True
        '
        'btn_ConvenioConfidencialidad
        '
        Me.btn_ConvenioConfidencialidad.Enabled = False
        Me.btn_ConvenioConfidencialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ConvenioConfidencialidad.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_ConvenioConfidencialidad.Location = New System.Drawing.Point(17, 77)
        Me.btn_ConvenioConfidencialidad.Name = "btn_ConvenioConfidencialidad"
        Me.btn_ConvenioConfidencialidad.Size = New System.Drawing.Size(187, 40)
        Me.btn_ConvenioConfidencialidad.TabIndex = 8
        Me.btn_ConvenioConfidencialidad.Text = "Convenio Confidencialidad"
        Me.btn_ConvenioConfidencialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConvenioConfidencialidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ConvenioConfidencialidad.UseVisualStyleBackColor = True
        '
        'btn_Concentimientos
        '
        Me.btn_Concentimientos.Enabled = False
        Me.btn_Concentimientos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Concentimientos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_Concentimientos.Location = New System.Drawing.Point(210, 77)
        Me.btn_Concentimientos.Name = "btn_Concentimientos"
        Me.btn_Concentimientos.Size = New System.Drawing.Size(151, 40)
        Me.btn_Concentimientos.TabIndex = 7
        Me.btn_Concentimientos.Text = "Concentimientos"
        Me.btn_Concentimientos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Concentimientos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Concentimientos.UseVisualStyleBackColor = True
        '
        'btn_CartaConfidencialidad
        '
        Me.btn_CartaConfidencialidad.Enabled = False
        Me.btn_CartaConfidencialidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_CartaConfidencialidad.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_CartaConfidencialidad.Location = New System.Drawing.Point(490, 21)
        Me.btn_CartaConfidencialidad.Name = "btn_CartaConfidencialidad"
        Me.btn_CartaConfidencialidad.Size = New System.Drawing.Size(173, 40)
        Me.btn_CartaConfidencialidad.TabIndex = 6
        Me.btn_CartaConfidencialidad.Text = "Carta Confidencialidad"
        Me.btn_CartaConfidencialidad.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CartaConfidencialidad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CartaConfidencialidad.UseVisualStyleBackColor = True
        '
        'btn_AvisoCandidatos
        '
        Me.btn_AvisoCandidatos.Enabled = False
        Me.btn_AvisoCandidatos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AvisoCandidatos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.btn_AvisoCandidatos.Location = New System.Drawing.Point(17, 21)
        Me.btn_AvisoCandidatos.Name = "btn_AvisoCandidatos"
        Me.btn_AvisoCandidatos.Size = New System.Drawing.Size(134, 40)
        Me.btn_AvisoCandidatos.TabIndex = 5
        Me.btn_AvisoCandidatos.Text = "Aviso Candidatos"
        Me.btn_AvisoCandidatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AvisoCandidatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AvisoCandidatos.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_AvisoCandidatos)
        Me.GroupBox1.Controls.Add(Me.btn_ContratoLaboral)
        Me.GroupBox1.Controls.Add(Me.btn_ExamenB)
        Me.GroupBox1.Controls.Add(Me.btn_AvisoPrivacidad)
        Me.GroupBox1.Controls.Add(Me.btn_CartaConfidencialidad)
        Me.GroupBox1.Controls.Add(Me.btn_Concentimientos)
        Me.GroupBox1.Controls.Add(Me.btn_ConvenioConfidencialidad)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(9, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(771, 128)
        Me.GroupBox1.TabIndex = 19
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Documencion de Contratacion"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.btn_CuestionarioMedico)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(10, 175)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(771, 75)
        Me.GroupBox2.TabIndex = 20
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Documentos Adiccionales"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.Button1.Location = New System.Drawing.Point(17, 20)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(161, 40)
        Me.Button1.TabIndex = 18
        Me.Button1.Text = "Referencias Laborares"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.documento
        Me.Button2.Location = New System.Drawing.Point(184, 19)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(161, 40)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Referencias Personales"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button2.UseVisualStyleBackColor = True
        '
        'frm_Consulta_Documentacion_Contratacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TabDocumentosProspectos)
        Me.Name = "frm_Consulta_Documentacion_Contratacion"
        Me.Text = "Consulta Documentacion de Contratacion"
        Me.TabDocumentosProspectos.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabDocumentos.ResumeLayout(False)
        Me.TabDocumentos.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabDocumentosProspectos As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_filtro As cp_cmb_Manual
    Friend WithEvents btn_Modificar As Button
    Friend WithEvents Lbl_Numero As Label
    Friend WithEvents lsv_Catalogo As cp_Listview
    Friend WithEvents cmb_DepartamentoFiltro As cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Aptos As CheckBox
    Friend WithEvents Lbl_LDepartamento As Label
    Friend WithEvents lbl_apto As Label
    Friend WithEvents Lbl_LPuesto As Label
    Friend WithEvents cmb_aptos As cp_cmb_Manual
    Friend WithEvents Lbl_LStatus As Label
    Friend WithEvents Lbl_Hasta As Label
    Friend WithEvents btn_MostrarCatalogo As Button
    Friend WithEvents Lbl_Desde As Label
    Friend WithEvents chk_DepartamentoFiltro As CheckBox
    Friend WithEvents Dtp_Desde As DateTimePicker
    Friend WithEvents chk_PuestoFiltro As CheckBox
    Friend WithEvents Dtp_Hasta As DateTimePicker
    Friend WithEvents cmb_PuestoFiltro As cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Status As CheckBox
    Friend WithEvents cmb_Status As cp_cmb_Manual
    Friend WithEvents TabDocumentos As TabPage
    Friend WithEvents lsv_documentospros As cp_Listview
    Friend WithEvents Label2 As Label
    Friend WithEvents btn_path As Button
    Friend WithEvents txt_path As TextBox
    Friend WithEvents Gbx_Botones As GroupBox
    Friend WithEvents btn_CuestionarioMedico As Button
    Friend WithEvents btn_ContratoLaboral As Button
    Friend WithEvents btn_AvisoPrivacidad As Button
    Friend WithEvents btn_ConvenioConfidencialidad As Button
    Friend WithEvents btn_Concentimientos As Button
    Friend WithEvents btn_CartaConfidencialidad As Button
    Friend WithEvents btn_AvisoCandidatos As Button
    Friend WithEvents btn_ExamenB As Button
    Friend WithEvents cp_lsv_ResultadosExamen As cp_Listview
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
End Class
