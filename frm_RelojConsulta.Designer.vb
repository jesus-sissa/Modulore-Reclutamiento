<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RelojConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_RelojConsulta))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter4 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ImportarT = New System.Windows.Forms.Button
        Me.btn_ImportarR = New System.Windows.Forms.Button
        Me.btn_ExportarR = New System.Windows.Forms.Button
        Me.btn_ExportarReg = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.btn_Ayuda = New System.Windows.Forms.Button
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_Reloj = New System.Windows.Forms.Label
        Me.gbx_EmpleadosReg = New System.Windows.Forms.GroupBox
        Me.lbl_EmpleadosReg = New System.Windows.Forms.Label
        Me.gbx_EmpleadosR = New System.Windows.Forms.GroupBox
        Me.Reloj = New Axzkemkeeper.AxCZKEM
        Me.lbl_EmpleadosR = New System.Windows.Forms.Label
        Me.spl_Registros = New System.Windows.Forms.SplitContainer
        Me.tab_Templates = New System.Windows.Forms.TabPage
        Me.spl_Templates = New System.Windows.Forms.SplitContainer
        Me.gbx_TemplatesReg = New System.Windows.Forms.GroupBox
        Me.lbl_TemplatesReg = New System.Windows.Forms.Label
        Me.gbx_TemplatesR = New System.Windows.Forms.GroupBox
        Me.lbl_TemplatesR = New System.Windows.Forms.Label
        Me.tab_Registros = New System.Windows.Forms.TabPage
        Me.tab_ListasEmpleados = New System.Windows.Forms.TabControl
        Me.lsv_EmpleadosReg = New Modulo_Reclutamiento.cp_Listview
        Me.clh_ClaveReg = New System.Windows.Forms.ColumnHeader
        Me.clh_NombreReg = New System.Windows.Forms.ColumnHeader
        Me.lsv_EmpleadosR = New Modulo_Reclutamiento.cp_Listview
        Me.clh_ClaveR = New System.Windows.Forms.ColumnHeader
        Me.clh_NombreR = New System.Windows.Forms.ColumnHeader
        Me.lsv_TemplatesReg = New Modulo_Reclutamiento.cp_Listview
        Me.clh_ClaveRegT = New System.Windows.Forms.ColumnHeader
        Me.clh_NombreRegT = New System.Windows.Forms.ColumnHeader
        Me.clh_DedoRegT = New System.Windows.Forms.ColumnHeader
        Me.lsv_TemplatesR = New Modulo_Reclutamiento.cp_Listview
        Me.clh_ClaveRT = New System.Windows.Forms.ColumnHeader
        Me.clh_NombreRT = New System.Windows.Forms.ColumnHeader
        Me.clh_DedoRT = New System.Windows.Forms.ColumnHeader
        Me.cmb_Reloj = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Consulta.SuspendLayout()
        Me.gbx_EmpleadosReg.SuspendLayout()
        Me.gbx_EmpleadosR.SuspendLayout()
        CType(Me.Reloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.spl_Registros.Panel1.SuspendLayout()
        Me.spl_Registros.Panel2.SuspendLayout()
        Me.spl_Registros.SuspendLayout()
        Me.tab_Templates.SuspendLayout()
        Me.spl_Templates.Panel1.SuspendLayout()
        Me.spl_Templates.Panel2.SuspendLayout()
        Me.spl_Templates.SuspendLayout()
        Me.gbx_TemplatesReg.SuspendLayout()
        Me.gbx_TemplatesR.SuspendLayout()
        Me.tab_Registros.SuspendLayout()
        Me.tab_ListasEmpleados.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ImportarT)
        Me.gbx_Botones.Controls.Add(Me.btn_ImportarR)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarR)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarReg)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 386)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(735, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_ImportarT
        '
        Me.btn_ImportarT.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ImportarT.Enabled = False
        Me.btn_ImportarT.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_ImportarT.Location = New System.Drawing.Point(152, 13)
        Me.btn_ImportarT.Name = "btn_ImportarT"
        Me.btn_ImportarT.Size = New System.Drawing.Size(140, 30)
        Me.btn_ImportarT.TabIndex = 1
        Me.btn_ImportarT.Text = "&Importar Temp"
        Me.btn_ImportarT.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImportarT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImportarT.UseVisualStyleBackColor = True
        '
        'btn_ImportarR
        '
        Me.btn_ImportarR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ImportarR.Enabled = False
        Me.btn_ImportarR.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_ImportarR.Location = New System.Drawing.Point(6, 13)
        Me.btn_ImportarR.Name = "btn_ImportarR"
        Me.btn_ImportarR.Size = New System.Drawing.Size(140, 30)
        Me.btn_ImportarR.TabIndex = 0
        Me.btn_ImportarR.Text = "&Importar Reg"
        Me.btn_ImportarR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImportarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImportarR.UseVisualStyleBackColor = True
        '
        'btn_ExportarR
        '
        Me.btn_ExportarR.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarR.Enabled = False
        Me.btn_ExportarR.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarR.Location = New System.Drawing.Point(434, 13)
        Me.btn_ExportarR.Name = "btn_ExportarR"
        Me.btn_ExportarR.Size = New System.Drawing.Size(130, 30)
        Me.btn_ExportarR.TabIndex = 3
        Me.btn_ExportarR.Text = "Exportar &Reloj"
        Me.btn_ExportarR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarR.UseVisualStyleBackColor = True
        '
        'btn_ExportarReg
        '
        Me.btn_ExportarReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarReg.Enabled = False
        Me.btn_ExportarReg.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarReg.Location = New System.Drawing.Point(298, 13)
        Me.btn_ExportarReg.Name = "btn_ExportarReg"
        Me.btn_ExportarReg.Size = New System.Drawing.Size(130, 30)
        Me.btn_ExportarReg.TabIndex = 2
        Me.btn_ExportarReg.Text = "&Exportar Reg."
        Me.btn_ExportarReg.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarReg.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarReg.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(589, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 4
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.btn_Ayuda)
        Me.gbx_Consulta.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Reloj)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Reloj)
        Me.gbx_Consulta.Location = New System.Drawing.Point(12, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(735, 53)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(703, 10)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 3
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(237, 13)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 2
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_Reloj
        '
        Me.lbl_Reloj.AutoSize = True
        Me.lbl_Reloj.Location = New System.Drawing.Point(6, 22)
        Me.lbl_Reloj.Name = "lbl_Reloj"
        Me.lbl_Reloj.Size = New System.Drawing.Size(31, 13)
        Me.lbl_Reloj.TabIndex = 0
        Me.lbl_Reloj.Text = "Reloj"
        '
        'gbx_EmpleadosReg
        '
        Me.gbx_EmpleadosReg.Controls.Add(Me.lbl_EmpleadosReg)
        Me.gbx_EmpleadosReg.Controls.Add(Me.lsv_EmpleadosReg)
        Me.gbx_EmpleadosReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_EmpleadosReg.Location = New System.Drawing.Point(0, 0)
        Me.gbx_EmpleadosReg.Name = "gbx_EmpleadosReg"
        Me.gbx_EmpleadosReg.Size = New System.Drawing.Size(360, 287)
        Me.gbx_EmpleadosReg.TabIndex = 0
        Me.gbx_EmpleadosReg.TabStop = False
        Me.gbx_EmpleadosReg.Text = "Registrados"
        '
        'lbl_EmpleadosReg
        '
        Me.lbl_EmpleadosReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_EmpleadosReg.Location = New System.Drawing.Point(277, 16)
        Me.lbl_EmpleadosReg.Name = "lbl_EmpleadosReg"
        Me.lbl_EmpleadosReg.Size = New System.Drawing.Size(77, 13)
        Me.lbl_EmpleadosReg.TabIndex = 1
        Me.lbl_EmpleadosReg.Text = "Total: 0"
        '
        'gbx_EmpleadosR
        '
        Me.gbx_EmpleadosR.Controls.Add(Me.Reloj)
        Me.gbx_EmpleadosR.Controls.Add(Me.lbl_EmpleadosR)
        Me.gbx_EmpleadosR.Controls.Add(Me.lsv_EmpleadosR)
        Me.gbx_EmpleadosR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_EmpleadosR.Location = New System.Drawing.Point(0, 0)
        Me.gbx_EmpleadosR.Name = "gbx_EmpleadosR"
        Me.gbx_EmpleadosR.Size = New System.Drawing.Size(357, 287)
        Me.gbx_EmpleadosR.TabIndex = 0
        Me.gbx_EmpleadosR.TabStop = False
        Me.gbx_EmpleadosR.Text = "En el Reloj"
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        Me.Reloj.Location = New System.Drawing.Point(77, 69)
        Me.Reloj.Name = "Reloj"
        Me.Reloj.OcxState = CType(resources.GetObject("Reloj.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Reloj.Size = New System.Drawing.Size(192, 192)
        Me.Reloj.TabIndex = 2
        '
        'lbl_EmpleadosR
        '
        Me.lbl_EmpleadosR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_EmpleadosR.Location = New System.Drawing.Point(274, 16)
        Me.lbl_EmpleadosR.Name = "lbl_EmpleadosR"
        Me.lbl_EmpleadosR.Size = New System.Drawing.Size(77, 13)
        Me.lbl_EmpleadosR.TabIndex = 1
        Me.lbl_EmpleadosR.Text = "Total: 0"
        '
        'spl_Registros
        '
        Me.spl_Registros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spl_Registros.Location = New System.Drawing.Point(3, 3)
        Me.spl_Registros.Name = "spl_Registros"
        '
        'spl_Registros.Panel1
        '
        Me.spl_Registros.Panel1.Controls.Add(Me.gbx_EmpleadosReg)
        Me.spl_Registros.Panel1MinSize = 100
        '
        'spl_Registros.Panel2
        '
        Me.spl_Registros.Panel2.Controls.Add(Me.gbx_EmpleadosR)
        Me.spl_Registros.Panel2MinSize = 100
        Me.spl_Registros.Size = New System.Drawing.Size(721, 287)
        Me.spl_Registros.SplitterDistance = 360
        Me.spl_Registros.TabIndex = 10
        '
        'tab_Templates
        '
        Me.tab_Templates.Controls.Add(Me.spl_Templates)
        Me.tab_Templates.Location = New System.Drawing.Point(4, 22)
        Me.tab_Templates.Name = "tab_Templates"
        Me.tab_Templates.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Templates.Size = New System.Drawing.Size(727, 293)
        Me.tab_Templates.TabIndex = 1
        Me.tab_Templates.Text = "Huellas"
        Me.tab_Templates.UseVisualStyleBackColor = True
        '
        'spl_Templates
        '
        Me.spl_Templates.Dock = System.Windows.Forms.DockStyle.Fill
        Me.spl_Templates.Location = New System.Drawing.Point(3, 3)
        Me.spl_Templates.Name = "spl_Templates"
        '
        'spl_Templates.Panel1
        '
        Me.spl_Templates.Panel1.Controls.Add(Me.gbx_TemplatesReg)
        Me.spl_Templates.Panel1MinSize = 100
        '
        'spl_Templates.Panel2
        '
        Me.spl_Templates.Panel2.Controls.Add(Me.gbx_TemplatesR)
        Me.spl_Templates.Panel2MinSize = 100
        Me.spl_Templates.Size = New System.Drawing.Size(721, 287)
        Me.spl_Templates.SplitterDistance = 360
        Me.spl_Templates.TabIndex = 11
        '
        'gbx_TemplatesReg
        '
        Me.gbx_TemplatesReg.Controls.Add(Me.lbl_TemplatesReg)
        Me.gbx_TemplatesReg.Controls.Add(Me.lsv_TemplatesReg)
        Me.gbx_TemplatesReg.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_TemplatesReg.Location = New System.Drawing.Point(0, 0)
        Me.gbx_TemplatesReg.Name = "gbx_TemplatesReg"
        Me.gbx_TemplatesReg.Size = New System.Drawing.Size(360, 287)
        Me.gbx_TemplatesReg.TabIndex = 0
        Me.gbx_TemplatesReg.TabStop = False
        Me.gbx_TemplatesReg.Text = "Registrados"
        '
        'lbl_TemplatesReg
        '
        Me.lbl_TemplatesReg.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TemplatesReg.Location = New System.Drawing.Point(277, 16)
        Me.lbl_TemplatesReg.Name = "lbl_TemplatesReg"
        Me.lbl_TemplatesReg.Size = New System.Drawing.Size(77, 13)
        Me.lbl_TemplatesReg.TabIndex = 1
        Me.lbl_TemplatesReg.Text = "Total: 0"
        '
        'gbx_TemplatesR
        '
        Me.gbx_TemplatesR.Controls.Add(Me.lbl_TemplatesR)
        Me.gbx_TemplatesR.Controls.Add(Me.lsv_TemplatesR)
        Me.gbx_TemplatesR.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_TemplatesR.Location = New System.Drawing.Point(0, 0)
        Me.gbx_TemplatesR.Name = "gbx_TemplatesR"
        Me.gbx_TemplatesR.Size = New System.Drawing.Size(357, 287)
        Me.gbx_TemplatesR.TabIndex = 0
        Me.gbx_TemplatesR.TabStop = False
        Me.gbx_TemplatesR.Text = "En el Reloj"
        '
        'lbl_TemplatesR
        '
        Me.lbl_TemplatesR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_TemplatesR.Location = New System.Drawing.Point(274, 16)
        Me.lbl_TemplatesR.Name = "lbl_TemplatesR"
        Me.lbl_TemplatesR.Size = New System.Drawing.Size(77, 13)
        Me.lbl_TemplatesR.TabIndex = 1
        Me.lbl_TemplatesR.Text = "Total: 0"
        '
        'tab_Registros
        '
        Me.tab_Registros.Controls.Add(Me.spl_Registros)
        Me.tab_Registros.Location = New System.Drawing.Point(4, 22)
        Me.tab_Registros.Name = "tab_Registros"
        Me.tab_Registros.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Registros.Size = New System.Drawing.Size(727, 293)
        Me.tab_Registros.TabIndex = 0
        Me.tab_Registros.Text = "Registros"
        Me.tab_Registros.UseVisualStyleBackColor = True
        '
        'tab_ListasEmpleados
        '
        Me.tab_ListasEmpleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tab_ListasEmpleados.Controls.Add(Me.tab_Registros)
        Me.tab_ListasEmpleados.Controls.Add(Me.tab_Templates)
        Me.tab_ListasEmpleados.Location = New System.Drawing.Point(12, 61)
        Me.tab_ListasEmpleados.Name = "tab_ListasEmpleados"
        Me.tab_ListasEmpleados.SelectedIndex = 0
        Me.tab_ListasEmpleados.Size = New System.Drawing.Size(735, 319)
        Me.tab_ListasEmpleados.TabIndex = 1
        '
        'lsv_EmpleadosReg
        '
        Me.lsv_EmpleadosReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EmpleadosReg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_ClaveReg, Me.clh_NombreReg})
        Me.lsv_EmpleadosReg.FullRowSelect = True
        Me.lsv_EmpleadosReg.HideSelection = False
        Me.lsv_EmpleadosReg.Location = New System.Drawing.Point(3, 32)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_EmpleadosReg.Lvs = ListViewColumnSorter1
        Me.lsv_EmpleadosReg.MultiSelect = False
        Me.lsv_EmpleadosReg.Name = "lsv_EmpleadosReg"
        Me.lsv_EmpleadosReg.Row1 = 10
        Me.lsv_EmpleadosReg.Row10 = 0
        Me.lsv_EmpleadosReg.Row2 = 50
        Me.lsv_EmpleadosReg.Row3 = 0
        Me.lsv_EmpleadosReg.Row4 = 0
        Me.lsv_EmpleadosReg.Row5 = 0
        Me.lsv_EmpleadosReg.Row6 = 0
        Me.lsv_EmpleadosReg.Row7 = 0
        Me.lsv_EmpleadosReg.Row8 = 0
        Me.lsv_EmpleadosReg.Row9 = 0
        Me.lsv_EmpleadosReg.Size = New System.Drawing.Size(354, 251)
        Me.lsv_EmpleadosReg.TabIndex = 0
        Me.lsv_EmpleadosReg.Tag = "Id_TipoParentesco"
        Me.lsv_EmpleadosReg.UseCompatibleStateImageBehavior = False
        Me.lsv_EmpleadosReg.View = System.Windows.Forms.View.Details
        '
        'clh_ClaveReg
        '
        Me.clh_ClaveReg.Text = "Clave"
        Me.clh_ClaveReg.Width = 35
        '
        'clh_NombreReg
        '
        Me.clh_NombreReg.Text = "Nombre"
        Me.clh_NombreReg.Width = 177
        '
        'lsv_EmpleadosR
        '
        Me.lsv_EmpleadosR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EmpleadosR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_ClaveR, Me.clh_NombreR})
        Me.lsv_EmpleadosR.FullRowSelect = True
        Me.lsv_EmpleadosR.HideSelection = False
        Me.lsv_EmpleadosR.Location = New System.Drawing.Point(3, 32)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_EmpleadosR.Lvs = ListViewColumnSorter2
        Me.lsv_EmpleadosR.MultiSelect = False
        Me.lsv_EmpleadosR.Name = "lsv_EmpleadosR"
        Me.lsv_EmpleadosR.Row1 = 10
        Me.lsv_EmpleadosR.Row10 = 0
        Me.lsv_EmpleadosR.Row2 = 50
        Me.lsv_EmpleadosR.Row3 = 0
        Me.lsv_EmpleadosR.Row4 = 0
        Me.lsv_EmpleadosR.Row5 = 0
        Me.lsv_EmpleadosR.Row6 = 0
        Me.lsv_EmpleadosR.Row7 = 0
        Me.lsv_EmpleadosR.Row8 = 0
        Me.lsv_EmpleadosR.Row9 = 0
        Me.lsv_EmpleadosR.Size = New System.Drawing.Size(351, 251)
        Me.lsv_EmpleadosR.TabIndex = 0
        Me.lsv_EmpleadosR.Tag = "Id_TipoParentesco"
        Me.lsv_EmpleadosR.UseCompatibleStateImageBehavior = False
        Me.lsv_EmpleadosR.View = System.Windows.Forms.View.Details
        '
        'clh_ClaveR
        '
        Me.clh_ClaveR.Text = "Clave"
        Me.clh_ClaveR.Width = 35
        '
        'clh_NombreR
        '
        Me.clh_NombreR.Text = "Nombre"
        Me.clh_NombreR.Width = 176
        '
        'lsv_TemplatesReg
        '
        Me.lsv_TemplatesReg.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TemplatesReg.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_ClaveRegT, Me.clh_NombreRegT, Me.clh_DedoRegT})
        Me.lsv_TemplatesReg.FullRowSelect = True
        Me.lsv_TemplatesReg.HideSelection = False
        Me.lsv_TemplatesReg.Location = New System.Drawing.Point(3, 32)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_TemplatesReg.Lvs = ListViewColumnSorter3
        Me.lsv_TemplatesReg.MultiSelect = False
        Me.lsv_TemplatesReg.Name = "lsv_TemplatesReg"
        Me.lsv_TemplatesReg.Row1 = 10
        Me.lsv_TemplatesReg.Row10 = 0
        Me.lsv_TemplatesReg.Row2 = 50
        Me.lsv_TemplatesReg.Row3 = 15
        Me.lsv_TemplatesReg.Row4 = 0
        Me.lsv_TemplatesReg.Row5 = 0
        Me.lsv_TemplatesReg.Row6 = 0
        Me.lsv_TemplatesReg.Row7 = 0
        Me.lsv_TemplatesReg.Row8 = 0
        Me.lsv_TemplatesReg.Row9 = 0
        Me.lsv_TemplatesReg.Size = New System.Drawing.Size(354, 251)
        Me.lsv_TemplatesReg.TabIndex = 0
        Me.lsv_TemplatesReg.Tag = "Id_TipoParentesco"
        Me.lsv_TemplatesReg.UseCompatibleStateImageBehavior = False
        Me.lsv_TemplatesReg.View = System.Windows.Forms.View.Details
        '
        'clh_ClaveRegT
        '
        Me.clh_ClaveRegT.Text = "Clave"
        Me.clh_ClaveRegT.Width = 35
        '
        'clh_NombreRegT
        '
        Me.clh_NombreRegT.Text = "Nombre"
        Me.clh_NombreRegT.Width = 177
        '
        'clh_DedoRegT
        '
        Me.clh_DedoRegT.Text = "Dedo"
        Me.clh_DedoRegT.Width = 53
        '
        'lsv_TemplatesR
        '
        Me.lsv_TemplatesR.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_TemplatesR.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_ClaveRT, Me.clh_NombreRT, Me.clh_DedoRT})
        Me.lsv_TemplatesR.FullRowSelect = True
        Me.lsv_TemplatesR.HideSelection = False
        Me.lsv_TemplatesR.Location = New System.Drawing.Point(3, 32)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_TemplatesR.Lvs = ListViewColumnSorter4
        Me.lsv_TemplatesR.MultiSelect = False
        Me.lsv_TemplatesR.Name = "lsv_TemplatesR"
        Me.lsv_TemplatesR.Row1 = 10
        Me.lsv_TemplatesR.Row10 = 0
        Me.lsv_TemplatesR.Row2 = 50
        Me.lsv_TemplatesR.Row3 = 15
        Me.lsv_TemplatesR.Row4 = 0
        Me.lsv_TemplatesR.Row5 = 0
        Me.lsv_TemplatesR.Row6 = 0
        Me.lsv_TemplatesR.Row7 = 0
        Me.lsv_TemplatesR.Row8 = 0
        Me.lsv_TemplatesR.Row9 = 0
        Me.lsv_TemplatesR.Size = New System.Drawing.Size(351, 251)
        Me.lsv_TemplatesR.TabIndex = 0
        Me.lsv_TemplatesR.Tag = "Id_TipoParentesco"
        Me.lsv_TemplatesR.UseCompatibleStateImageBehavior = False
        Me.lsv_TemplatesR.View = System.Windows.Forms.View.Details
        '
        'clh_ClaveRT
        '
        Me.clh_ClaveRT.Text = "Clave"
        Me.clh_ClaveRT.Width = 35
        '
        'clh_NombreRT
        '
        Me.clh_NombreRT.Text = "Nombre"
        Me.clh_NombreRT.Width = 176
        '
        'clh_DedoRT
        '
        Me.clh_DedoRT.Text = "Dedo"
        Me.clh_DedoRT.Width = 53
        '
        'cmb_Reloj
        '
        Me.cmb_Reloj.Clave = Nothing
        Me.cmb_Reloj.Control_Siguiente = Nothing
        Me.cmb_Reloj.DisplayMember = "Descripcion"
        Me.cmb_Reloj.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Reloj.Empresa = False
        Me.cmb_Reloj.Filtro = Nothing
        Me.cmb_Reloj.FormattingEnabled = True
        Me.cmb_Reloj.Location = New System.Drawing.Point(43, 19)
        Me.cmb_Reloj.MaxDropDownItems = 20
        Me.cmb_Reloj.Name = "cmb_Reloj"
        Me.cmb_Reloj.Pista = False
        Me.cmb_Reloj.Size = New System.Drawing.Size(188, 21)
        Me.cmb_Reloj.StoredProcedure = "Cat_RelojesCombo_Get"
        Me.cmb_Reloj.Sucursal = True
        Me.cmb_Reloj.TabIndex = 1
        Me.cmb_Reloj.Tipo = 0
        Me.cmb_Reloj.ValueMember = "Id_Reloj"
        '
        'frm_RelojConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(759, 448)
        Me.Controls.Add(Me.tab_ListasEmpleados)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(775, 486)
        Me.Name = "frm_RelojConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Relojes"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
        Me.gbx_EmpleadosReg.ResumeLayout(False)
        Me.gbx_EmpleadosR.ResumeLayout(False)
        CType(Me.Reloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.spl_Registros.Panel1.ResumeLayout(False)
        Me.spl_Registros.Panel2.ResumeLayout(False)
        Me.spl_Registros.ResumeLayout(False)
        Me.tab_Templates.ResumeLayout(False)
        Me.spl_Templates.Panel1.ResumeLayout(False)
        Me.spl_Templates.Panel2.ResumeLayout(False)
        Me.spl_Templates.ResumeLayout(False)
        Me.gbx_TemplatesReg.ResumeLayout(False)
        Me.gbx_TemplatesR.ResumeLayout(False)
        Me.tab_Registros.ResumeLayout(False)
        Me.tab_ListasEmpleados.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_EmpleadosReg As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_EmpleadosReg As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_EmpleadosReg As System.Windows.Forms.Label
    Friend WithEvents gbx_EmpleadosR As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_EmpleadosR As System.Windows.Forms.Label
    Friend WithEvents lsv_EmpleadosR As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents cmb_Reloj As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Reloj As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents spl_Registros As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
    Friend WithEvents btn_ExportarR As System.Windows.Forms.Button
    Friend WithEvents btn_ExportarReg As System.Windows.Forms.Button
    Friend WithEvents btn_ImportarR As System.Windows.Forms.Button
    Friend WithEvents Reloj As Axzkemkeeper.AxCZKEM
    Friend WithEvents clh_ClaveReg As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_NombreReg As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_ClaveR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_NombreR As System.Windows.Forms.ColumnHeader
    Friend WithEvents btn_ImportarT As System.Windows.Forms.Button
    Friend WithEvents tab_Templates As System.Windows.Forms.TabPage
    Friend WithEvents spl_Templates As System.Windows.Forms.SplitContainer
    Friend WithEvents gbx_TemplatesReg As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TemplatesReg As System.Windows.Forms.Label
    Friend WithEvents lsv_TemplatesReg As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_TemplatesR As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TemplatesR As System.Windows.Forms.Label
    Friend WithEvents lsv_TemplatesR As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents clh_ClaveRT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_NombreRT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_ClaveRegT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_NombreRegT As System.Windows.Forms.ColumnHeader
    Friend WithEvents tab_Registros As System.Windows.Forms.TabPage
    Friend WithEvents tab_ListasEmpleados As System.Windows.Forms.TabControl
    Friend WithEvents clh_DedoRegT As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_DedoRT As System.Windows.Forms.ColumnHeader
End Class
