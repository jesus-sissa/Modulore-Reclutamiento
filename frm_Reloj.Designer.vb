<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Reloj
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Reloj))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Empleados = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.Label141 = New System.Windows.Forms.Label
        Me.chk_Puesto = New System.Windows.Forms.CheckBox
        Me.Label143 = New System.Windows.Forms.Label
        Me.chk_Departamento = New System.Windows.Forms.CheckBox
        Me.lbl_Reloj = New System.Windows.Forms.Label
        Me.gbx_EmpleadosReloj = New System.Windows.Forms.GroupBox
        Me.Reloj = New Axzkemkeeper.AxCZKEM
        Me.btn_Eliminar = New System.Windows.Forms.Button
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Huellas = New System.Windows.Forms.GroupBox
        Me.lbl_4 = New System.Windows.Forms.Label
        Me.lbl_9 = New System.Windows.Forms.Label
        Me.lbl_8 = New System.Windows.Forms.Label
        Me.lbl_7 = New System.Windows.Forms.Label
        Me.lbl_6 = New System.Windows.Forms.Label
        Me.lbl_5 = New System.Windows.Forms.Label
        Me.lbl_3 = New System.Windows.Forms.Label
        Me.lbl_2 = New System.Windows.Forms.Label
        Me.lbl_1 = New System.Windows.Forms.Label
        Me.lbl_0 = New System.Windows.Forms.Label
        Me.pct_Manos = New System.Windows.Forms.PictureBox
        Me.btn_Ayuda = New System.Windows.Forms.Button
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Departamento = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.lsv_Empleados = New Modulo_Reclutamiento.cp_Listview
        Me.clh_Clave = New System.Windows.Forms.ColumnHeader
        Me.clh_Nombre = New System.Windows.Forms.ColumnHeader
        Me.clh_Departamento = New System.Windows.Forms.ColumnHeader
        Me.clh_Puesto = New System.Windows.Forms.ColumnHeader
        Me.lsv_EmpleadosReloj = New Modulo_Reclutamiento.cp_Listview
        Me.clh_ClaveR = New System.Windows.Forms.ColumnHeader
        Me.clh_NombreR = New System.Windows.Forms.ColumnHeader
        Me.clh_DepartamentoR = New System.Windows.Forms.ColumnHeader
        Me.clh_PuestoR = New System.Windows.Forms.ColumnHeader
        Me.cmb_Reloj = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.gbx_Empleados.SuspendLayout()
        Me.gbx_EmpleadosReloj.SuspendLayout()
        CType(Me.Reloj, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbx_Huellas.SuspendLayout()
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(318, 343)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 0
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(356, 524)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Empleados
        '
        Me.gbx_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Empleados.Controls.Add(Me.btn_Agregar)
        Me.gbx_Empleados.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Empleados.Controls.Add(Me.cmb_Puesto)
        Me.gbx_Empleados.Controls.Add(Me.cmb_Departamento)
        Me.gbx_Empleados.Controls.Add(Me.Label141)
        Me.gbx_Empleados.Controls.Add(Me.chk_Puesto)
        Me.gbx_Empleados.Controls.Add(Me.Label143)
        Me.gbx_Empleados.Controls.Add(Me.chk_Departamento)
        Me.gbx_Empleados.Controls.Add(Me.lsv_Empleados)
        Me.gbx_Empleados.Location = New System.Drawing.Point(3, 3)
        Me.gbx_Empleados.Name = "gbx_Empleados"
        Me.gbx_Empleados.Size = New System.Drawing.Size(464, 379)
        Me.gbx_Empleados.TabIndex = 7
        Me.gbx_Empleados.TabStop = False
        Me.gbx_Empleados.Text = "Empleados"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(80, 75)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 6
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(6, 22)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(74, 13)
        Me.Label141.TabIndex = 0
        Me.Label141.Text = "Departamento"
        '
        'chk_Puesto
        '
        Me.chk_Puesto.AutoSize = True
        Me.chk_Puesto.Location = New System.Drawing.Point(402, 48)
        Me.chk_Puesto.Name = "chk_Puesto"
        Me.chk_Puesto.Size = New System.Drawing.Size(56, 17)
        Me.chk_Puesto.TabIndex = 5
        Me.chk_Puesto.Text = "Todos"
        Me.chk_Puesto.UseVisualStyleBackColor = True
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(40, 49)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(40, 13)
        Me.Label143.TabIndex = 3
        Me.Label143.Text = "Puesto"
        '
        'chk_Departamento
        '
        Me.chk_Departamento.AutoSize = True
        Me.chk_Departamento.Location = New System.Drawing.Point(402, 22)
        Me.chk_Departamento.Name = "chk_Departamento"
        Me.chk_Departamento.Size = New System.Drawing.Size(56, 17)
        Me.chk_Departamento.TabIndex = 2
        Me.chk_Departamento.Text = "Todos"
        Me.chk_Departamento.UseVisualStyleBackColor = True
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
        'gbx_EmpleadosReloj
        '
        Me.gbx_EmpleadosReloj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.btn_Cerrar)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.Reloj)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.btn_Eliminar)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.lbl_Total)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.lsv_EmpleadosReloj)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.cmb_Reloj)
        Me.gbx_EmpleadosReloj.Controls.Add(Me.lbl_Reloj)
        Me.gbx_EmpleadosReloj.Location = New System.Drawing.Point(3, 3)
        Me.gbx_EmpleadosReloj.Name = "gbx_EmpleadosReloj"
        Me.gbx_EmpleadosReloj.Size = New System.Drawing.Size(502, 560)
        Me.gbx_EmpleadosReloj.TabIndex = 3
        Me.gbx_EmpleadosReloj.TabStop = False
        Me.gbx_EmpleadosReloj.Text = "Empleados en el Reloj"
        '
        'Reloj
        '
        Me.Reloj.Enabled = True
        Me.Reloj.Location = New System.Drawing.Point(307, 326)
        Me.Reloj.Name = "Reloj"
        Me.Reloj.OcxState = CType(resources.GetObject("Reloj.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Reloj.Size = New System.Drawing.Size(192, 192)
        Me.Reloj.TabIndex = 2
        Me.Reloj.Visible = False
        '
        'btn_Eliminar
        '
        Me.btn_Eliminar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Eliminar.Enabled = False
        Me.btn_Eliminar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Eliminar.Location = New System.Drawing.Point(3, 524)
        Me.btn_Eliminar.Name = "btn_Eliminar"
        Me.btn_Eliminar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Eliminar.TabIndex = 4
        Me.btn_Eliminar.Tag = "ELIMINAR EMPLEADOS RELOJ"
        Me.btn_Eliminar.Text = "&Eliminar"
        Me.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Eliminar.UseVisualStyleBackColor = True
        Me.btn_Eliminar.Visible = False
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.Location = New System.Drawing.Point(436, 22)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(63, 13)
        Me.lbl_Total.TabIndex = 2
        Me.lbl_Total.Text = "Total: 0"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Huellas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Empleados)
        Me.SplitContainer1.Panel1MinSize = 125
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_EmpleadosReloj)
        Me.SplitContainer1.Panel2MinSize = 125
        Me.SplitContainer1.Size = New System.Drawing.Size(981, 566)
        Me.SplitContainer1.SplitterDistance = 469
        Me.SplitContainer1.TabIndex = 0
        '
        'gbx_Huellas
        '
        Me.gbx_Huellas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Huellas.Controls.Add(Me.lbl_4)
        Me.gbx_Huellas.Controls.Add(Me.lbl_9)
        Me.gbx_Huellas.Controls.Add(Me.lbl_8)
        Me.gbx_Huellas.Controls.Add(Me.lbl_7)
        Me.gbx_Huellas.Controls.Add(Me.lbl_6)
        Me.gbx_Huellas.Controls.Add(Me.lbl_5)
        Me.gbx_Huellas.Controls.Add(Me.lbl_3)
        Me.gbx_Huellas.Controls.Add(Me.lbl_2)
        Me.gbx_Huellas.Controls.Add(Me.lbl_1)
        Me.gbx_Huellas.Controls.Add(Me.lbl_0)
        Me.gbx_Huellas.Controls.Add(Me.pct_Manos)
        Me.gbx_Huellas.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Huellas.Location = New System.Drawing.Point(3, 388)
        Me.gbx_Huellas.Name = "gbx_Huellas"
        Me.gbx_Huellas.Size = New System.Drawing.Size(464, 175)
        Me.gbx_Huellas.TabIndex = 8
        Me.gbx_Huellas.TabStop = False
        Me.gbx_Huellas.Text = "Huellas"
        '
        'lbl_4
        '
        Me.lbl_4.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_4.BackColor = System.Drawing.Color.Transparent
        Me.lbl_4.Image = CType(resources.GetObject("lbl_4.Image"), System.Drawing.Image)
        Me.lbl_4.Location = New System.Drawing.Point(219, 85)
        Me.lbl_4.Name = "lbl_4"
        Me.lbl_4.Size = New System.Drawing.Size(14, 14)
        Me.lbl_4.TabIndex = 4
        Me.lbl_4.Text = "_"
        '
        'lbl_9
        '
        Me.lbl_9.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_9.BackColor = System.Drawing.Color.Transparent
        Me.lbl_9.Image = CType(resources.GetObject("lbl_9.Image"), System.Drawing.Image)
        Me.lbl_9.Location = New System.Drawing.Point(313, 28)
        Me.lbl_9.Name = "lbl_9"
        Me.lbl_9.Size = New System.Drawing.Size(14, 14)
        Me.lbl_9.TabIndex = 9
        Me.lbl_9.Text = "_"
        '
        'lbl_8
        '
        Me.lbl_8.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_8.BackColor = System.Drawing.Color.Transparent
        Me.lbl_8.Image = CType(resources.GetObject("lbl_8.Image"), System.Drawing.Image)
        Me.lbl_8.Location = New System.Drawing.Point(293, 16)
        Me.lbl_8.Name = "lbl_8"
        Me.lbl_8.Size = New System.Drawing.Size(14, 14)
        Me.lbl_8.TabIndex = 8
        Me.lbl_8.Text = "_"
        '
        'lbl_7
        '
        Me.lbl_7.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_7.BackColor = System.Drawing.Color.Transparent
        Me.lbl_7.Image = CType(resources.GetObject("lbl_7.Image"), System.Drawing.Image)
        Me.lbl_7.Location = New System.Drawing.Point(270, 13)
        Me.lbl_7.Name = "lbl_7"
        Me.lbl_7.Size = New System.Drawing.Size(14, 14)
        Me.lbl_7.TabIndex = 7
        Me.lbl_7.Text = "_"
        '
        'lbl_6
        '
        Me.lbl_6.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_6.BackColor = System.Drawing.Color.Transparent
        Me.lbl_6.Image = CType(resources.GetObject("lbl_6.Image"), System.Drawing.Image)
        Me.lbl_6.Location = New System.Drawing.Point(253, 28)
        Me.lbl_6.Name = "lbl_6"
        Me.lbl_6.Size = New System.Drawing.Size(14, 14)
        Me.lbl_6.TabIndex = 6
        Me.lbl_6.Text = "_"
        '
        'lbl_5
        '
        Me.lbl_5.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_5.BackColor = System.Drawing.Color.Transparent
        Me.lbl_5.Image = CType(resources.GetObject("lbl_5.Image"), System.Drawing.Image)
        Me.lbl_5.Location = New System.Drawing.Point(242, 85)
        Me.lbl_5.Name = "lbl_5"
        Me.lbl_5.Size = New System.Drawing.Size(14, 14)
        Me.lbl_5.TabIndex = 5
        Me.lbl_5.Text = "_"
        '
        'lbl_3
        '
        Me.lbl_3.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_3.BackColor = System.Drawing.Color.Transparent
        Me.lbl_3.Image = CType(resources.GetObject("lbl_3.Image"), System.Drawing.Image)
        Me.lbl_3.Location = New System.Drawing.Point(207, 28)
        Me.lbl_3.Name = "lbl_3"
        Me.lbl_3.Size = New System.Drawing.Size(14, 14)
        Me.lbl_3.TabIndex = 3
        Me.lbl_3.Text = "_"
        '
        'lbl_2
        '
        Me.lbl_2.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_2.BackColor = System.Drawing.Color.Transparent
        Me.lbl_2.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Delete
        Me.lbl_2.Location = New System.Drawing.Point(190, 13)
        Me.lbl_2.Name = "lbl_2"
        Me.lbl_2.Size = New System.Drawing.Size(14, 14)
        Me.lbl_2.TabIndex = 2
        Me.lbl_2.Text = "_"
        '
        'lbl_1
        '
        Me.lbl_1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_1.BackColor = System.Drawing.Color.Transparent
        Me.lbl_1.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Delete
        Me.lbl_1.Location = New System.Drawing.Point(166, 16)
        Me.lbl_1.Name = "lbl_1"
        Me.lbl_1.Size = New System.Drawing.Size(14, 14)
        Me.lbl_1.TabIndex = 1
        Me.lbl_1.Text = "_"
        '
        'lbl_0
        '
        Me.lbl_0.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lbl_0.BackColor = System.Drawing.Color.Transparent
        Me.lbl_0.Image = CType(resources.GetObject("lbl_0.Image"), System.Drawing.Image)
        Me.lbl_0.Location = New System.Drawing.Point(146, 27)
        Me.lbl_0.Name = "lbl_0"
        Me.lbl_0.Size = New System.Drawing.Size(14, 14)
        Me.lbl_0.TabIndex = 0
        Me.lbl_0.Text = "_"
        '
        'pct_Manos
        '
        Me.pct_Manos.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.pct_Manos.BackColor = System.Drawing.Color.White
        Me.pct_Manos.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Manos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Dos_Manos
        Me.pct_Manos.Location = New System.Drawing.Point(129, 11)
        Me.pct_Manos.Name = "pct_Manos"
        Me.pct_Manos.Size = New System.Drawing.Size(217, 159)
        Me.pct_Manos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Manos.TabIndex = 6
        Me.pct_Manos.TabStop = False
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(954, 1)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 3
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Nothing
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.Location = New System.Drawing.Point(86, 48)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(310, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 4
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'cmb_Departamento
        '
        Me.cmb_Departamento.Clave = Nothing
        Me.cmb_Departamento.Control_Siguiente = Nothing
        Me.cmb_Departamento.DisplayMember = "Descripcion"
        Me.cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento.Empresa = False
        Me.cmb_Departamento.Filtro = Nothing
        Me.cmb_Departamento.FormattingEnabled = True
        Me.cmb_Departamento.Location = New System.Drawing.Point(86, 19)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(310, 21)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 1
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'lsv_Empleados
        '
        Me.lsv_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Empleados.CheckBoxes = True
        Me.lsv_Empleados.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_Clave, Me.clh_Nombre, Me.clh_Departamento, Me.clh_Puesto})
        Me.lsv_Empleados.FullRowSelect = True
        Me.lsv_Empleados.HideSelection = False
        Me.lsv_Empleados.Location = New System.Drawing.Point(3, 111)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Empleados.Lvs = ListViewColumnSorter1
        Me.lsv_Empleados.MultiSelect = False
        Me.lsv_Empleados.Name = "lsv_Empleados"
        Me.lsv_Empleados.Row1 = 10
        Me.lsv_Empleados.Row10 = 0
        Me.lsv_Empleados.Row2 = 45
        Me.lsv_Empleados.Row3 = 20
        Me.lsv_Empleados.Row4 = 20
        Me.lsv_Empleados.Row5 = 0
        Me.lsv_Empleados.Row6 = 0
        Me.lsv_Empleados.Row7 = 0
        Me.lsv_Empleados.Row8 = 0
        Me.lsv_Empleados.Row9 = 0
        Me.lsv_Empleados.Size = New System.Drawing.Size(458, 226)
        Me.lsv_Empleados.TabIndex = 0
        Me.lsv_Empleados.Tag = "Id_TipoParentesco"
        Me.lsv_Empleados.UseCompatibleStateImageBehavior = False
        Me.lsv_Empleados.View = System.Windows.Forms.View.Details
        '
        'clh_Clave
        '
        Me.clh_Clave.Text = "Clave"
        Me.clh_Clave.Width = 46
        '
        'clh_Nombre
        '
        Me.clh_Nombre.Text = "Nombre"
        Me.clh_Nombre.Width = 206
        '
        'clh_Departamento
        '
        Me.clh_Departamento.Text = "Departamento"
        Me.clh_Departamento.Width = 92
        '
        'clh_Puesto
        '
        Me.clh_Puesto.Text = "Puesto"
        Me.clh_Puesto.Width = 92
        '
        'lsv_EmpleadosReloj
        '
        Me.lsv_EmpleadosReloj.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EmpleadosReloj.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.clh_ClaveR, Me.clh_NombreR, Me.clh_DepartamentoR, Me.clh_PuestoR})
        Me.lsv_EmpleadosReloj.FullRowSelect = True
        Me.lsv_EmpleadosReloj.HideSelection = False
        Me.lsv_EmpleadosReloj.Location = New System.Drawing.Point(3, 46)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_EmpleadosReloj.Lvs = ListViewColumnSorter2
        Me.lsv_EmpleadosReloj.MultiSelect = False
        Me.lsv_EmpleadosReloj.Name = "lsv_EmpleadosReloj"
        Me.lsv_EmpleadosReloj.Row1 = 10
        Me.lsv_EmpleadosReloj.Row10 = 0
        Me.lsv_EmpleadosReloj.Row2 = 45
        Me.lsv_EmpleadosReloj.Row3 = 20
        Me.lsv_EmpleadosReloj.Row4 = 20
        Me.lsv_EmpleadosReloj.Row5 = 0
        Me.lsv_EmpleadosReloj.Row6 = 0
        Me.lsv_EmpleadosReloj.Row7 = 0
        Me.lsv_EmpleadosReloj.Row8 = 0
        Me.lsv_EmpleadosReloj.Row9 = 0
        Me.lsv_EmpleadosReloj.Size = New System.Drawing.Size(496, 472)
        Me.lsv_EmpleadosReloj.TabIndex = 0
        Me.lsv_EmpleadosReloj.Tag = "Id_TipoParentesco"
        Me.lsv_EmpleadosReloj.UseCompatibleStateImageBehavior = False
        Me.lsv_EmpleadosReloj.View = System.Windows.Forms.View.Details
        '
        'clh_ClaveR
        '
        Me.clh_ClaveR.Text = "Clave"
        Me.clh_ClaveR.Width = 50
        '
        'clh_NombreR
        '
        Me.clh_NombreR.Text = "Nombre"
        Me.clh_NombreR.Width = 223
        '
        'clh_DepartamentoR
        '
        Me.clh_DepartamentoR.Text = "Departamento"
        Me.clh_DepartamentoR.Width = 99
        '
        'clh_PuestoR
        '
        Me.clh_PuestoR.Text = "Puesto"
        Me.clh_PuestoR.Width = 99
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
        'frm_Reloj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(981, 566)
        Me.Controls.Add(Me.btn_Ayuda)
        Me.Controls.Add(Me.SplitContainer1)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(997, 604)
        Me.Name = "frm_Reloj"
        Me.Text = "Agregar Huellas a Relojes"
        Me.gbx_Empleados.ResumeLayout(False)
        Me.gbx_Empleados.PerformLayout()
        Me.gbx_EmpleadosReloj.ResumeLayout(False)
        Me.gbx_EmpleadosReloj.PerformLayout()
        CType(Me.Reloj, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbx_Huellas.ResumeLayout(False)
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Empleados As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Reloj As System.Windows.Forms.Label
    Friend WithEvents lsv_Empleados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lsv_EmpleadosReloj As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents cmb_Reloj As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_EmpleadosReloj As System.Windows.Forms.GroupBox
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents gbx_Huellas As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_4 As System.Windows.Forms.Label
    Friend WithEvents lbl_9 As System.Windows.Forms.Label
    Friend WithEvents lbl_8 As System.Windows.Forms.Label
    Friend WithEvents lbl_7 As System.Windows.Forms.Label
    Friend WithEvents lbl_6 As System.Windows.Forms.Label
    Friend WithEvents lbl_5 As System.Windows.Forms.Label
    Friend WithEvents lbl_3 As System.Windows.Forms.Label
    Friend WithEvents lbl_2 As System.Windows.Forms.Label
    Friend WithEvents lbl_1 As System.Windows.Forms.Label
    Friend WithEvents lbl_0 As System.Windows.Forms.Label
    Friend WithEvents pct_Manos As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Departamento As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents chk_Puesto As System.Windows.Forms.CheckBox
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents chk_Departamento As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents clh_Clave As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_Nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_Departamento As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_Puesto As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_ClaveR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_NombreR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_DepartamentoR As System.Windows.Forms.ColumnHeader
    Friend WithEvents clh_PuestoR As System.Windows.Forms.ColumnHeader
    Friend WithEvents Reloj As Axzkemkeeper.AxCZKEM
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
End Class
