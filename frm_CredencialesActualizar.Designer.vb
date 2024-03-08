<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CredencialesActualizar
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
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.btn_ImpFrente = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_ImpAtras = New System.Windows.Forms.Button
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox
        Me.Label143 = New System.Windows.Forms.Label
        Me.Label141 = New System.Windows.Forms.Label
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.dtp_FechaExpira = New System.Windows.Forms.DateTimePicker
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ImpFrente
        '
        Me.btn_ImpFrente.Enabled = False
        Me.btn_ImpFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ImpFrente.Location = New System.Drawing.Point(6, 19)
        Me.btn_ImpFrente.Name = "btn_ImpFrente"
        Me.btn_ImpFrente.Size = New System.Drawing.Size(130, 29)
        Me.btn_ImpFrente.TabIndex = 0
        Me.btn_ImpFrente.Text = "Imprimir Adelante"
        Me.btn_ImpFrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImpFrente.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(593, 19)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 29)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_ImpAtras
        '
        Me.btn_ImpAtras.Enabled = False
        Me.btn_ImpAtras.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ImpAtras.Location = New System.Drawing.Point(142, 19)
        Me.btn_ImpAtras.Name = "btn_ImpAtras"
        Me.btn_ImpAtras.Size = New System.Drawing.Size(130, 29)
        Me.btn_ImpAtras.TabIndex = 2
        Me.btn_ImpAtras.Text = "Imprimir Atras"
        Me.btn_ImpAtras.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImpAtras.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImpAtras.UseVisualStyleBackColor = True
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(420, 43)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 21
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(420, 17)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 18
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'Label143
        '
        Me.Label143.AutoSize = True
        Me.Label143.Location = New System.Drawing.Point(45, 42)
        Me.Label143.Name = "Label143"
        Me.Label143.Size = New System.Drawing.Size(40, 13)
        Me.Label143.TabIndex = 19
        Me.Label143.Text = "Puesto"
        '
        'Label141
        '
        Me.Label141.AutoSize = True
        Me.Label141.Location = New System.Drawing.Point(11, 17)
        Me.Label141.Name = "Label141"
        Me.Label141.Size = New System.Drawing.Size(74, 13)
        Me.Label141.TabIndex = 16
        Me.Label141.Text = "Departamento"
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(528, 31)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(130, 29)
        Me.btn_MostrarCatalogo.TabIndex = 22
        Me.btn_MostrarCatalogo.Text = "M&ostrar"
        Me.btn_MostrarCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarCatalogo.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaExpira)
        Me.GroupBox1.Controls.Add(Me.lsv_Catalogo)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 91)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(729, 402)
        Me.GroupBox1.TabIndex = 23
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalle"
        '
        'dtp_FechaExpira
        '
        Me.dtp_FechaExpira.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.dtp_FechaExpira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpira.Location = New System.Drawing.Point(6, 376)
        Me.dtp_FechaExpira.Name = "dtp_FechaExpira"
        Me.dtp_FechaExpira.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaExpira.TabIndex = 16
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn_MostrarCatalogo)
        Me.GroupBox2.Controls.Add(Me.Label141)
        Me.GroupBox2.Controls.Add(Me.cmb_PuestoFiltro)
        Me.GroupBox2.Controls.Add(Me.Label143)
        Me.GroupBox2.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.GroupBox2.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.GroupBox2.Controls.Add(Me.chk_PuestoFiltro)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(729, 73)
        Me.GroupBox2.TabIndex = 24
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.btn_ImpFrente)
        Me.GroupBox3.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox3.Controls.Add(Me.btn_ImpAtras)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 499)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(729, 59)
        Me.GroupBox3.TabIndex = 25
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Imprimir"
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(91, 39)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 20
        Me.cmb_PuestoFiltro.Tipo = 0
        Me.cmb_PuestoFiltro.ValueMember = "Id_Puesto"
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(91, 14)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 17
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.CheckBoxes = True
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 35
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(717, 351)
        Me.lsv_Catalogo.TabIndex = 15
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'frm_CredencialesActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 570)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frm_CredencialesActualizar"
        Me.Text = "Actualización de Credenciales"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ImpFrente As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ImpAtras As System.Windows.Forms.Button
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents Label143 As System.Windows.Forms.Label
    Friend WithEvents Label141 As System.Windows.Forms.Label
    Friend WithEvents btn_MostrarCatalogo As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_FechaExpira As System.Windows.Forms.DateTimePicker

End Class
