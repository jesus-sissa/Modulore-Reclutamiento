<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosReingresosConsulta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmpleadosReingresosConsulta))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.lbl_Depto = New System.Windows.Forms.Label
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.lsv_Listado = New Modulo_Reclutamiento.cp_Listview
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Consulta.SuspendLayout()
        Me.gbx_Listado.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Exportar)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(7, 505)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(769, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(623, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.chk_Status)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Status)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Status)
        Me.gbx_Consulta.Controls.Add(Me.cmb_PuestoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.chk_PuestoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Puesto)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Depto)
        Me.gbx_Consulta.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Consulta.Controls.Add(Me.lbl_FechaHasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_FechaHasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_FechaDesde)
        Me.gbx_Consulta.Controls.Add(Me.lbl_FechaDesde)
        Me.gbx_Consulta.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(769, 130)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(320, 101)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 12
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(45, 102)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Status.TabIndex = 10
        Me.lbl_Status.Text = "Status"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(86, 99)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 11
        Me.cmb_Status.ValueMember = "value"
        '
        'cmb_PuestoFiltro
        '
        Me.cmb_PuestoFiltro.Clave = Nothing
        Me.cmb_PuestoFiltro.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_PuestoFiltro.DisplayMember = "Descripcion"
        Me.cmb_PuestoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PuestoFiltro.Empresa = False
        Me.cmb_PuestoFiltro.Filtro = Nothing
        Me.cmb_PuestoFiltro.FormattingEnabled = True
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(86, 72)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 8
        Me.cmb_PuestoFiltro.Tipo = 0
        Me.cmb_PuestoFiltro.ValueMember = "Id_Puesto"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(478, 94)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 13
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_DepartamentoFiltro
        '
        Me.cmb_DepartamentoFiltro.Clave = Nothing
        Me.cmb_DepartamentoFiltro.Control_Siguiente = Me.cmb_PuestoFiltro
        Me.cmb_DepartamentoFiltro.DisplayMember = "Descripcion"
        Me.cmb_DepartamentoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DepartamentoFiltro.Empresa = False
        Me.cmb_DepartamentoFiltro.Filtro = Nothing
        Me.cmb_DepartamentoFiltro.FormattingEnabled = True
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(86, 45)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 5
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(415, 74)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 9
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(415, 48)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 6
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(40, 75)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 7
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_Depto
        '
        Me.lbl_Depto.AutoSize = True
        Me.lbl_Depto.Location = New System.Drawing.Point(6, 48)
        Me.lbl_Depto.Name = "lbl_Depto"
        Me.lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Depto.TabIndex = 4
        Me.lbl_Depto.Text = "Departamento"
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(190, 23)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_FechaHasta.TabIndex = 2
        Me.lbl_FechaHasta.Text = "Hasta"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(231, 19)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaHasta.TabIndex = 3
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(86, 19)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaDesde.TabIndex = 1
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(42, 23)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_FechaDesde.TabIndex = 0
        Me.lbl_FechaDesde.Text = "Desde"
        '
        'gbx_Listado
        '
        Me.gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Listado.Controls.Add(Me.Lbl_Numero)
        Me.gbx_Listado.Controls.Add(Me.lsv_Listado)
        Me.gbx_Listado.Location = New System.Drawing.Point(7, 138)
        Me.gbx_Listado.Name = "gbx_Listado"
        Me.gbx_Listado.Size = New System.Drawing.Size(769, 366)
        Me.gbx_Listado.TabIndex = 1
        Me.gbx_Listado.TabStop = False
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(541, 10)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 0
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Listado
        '
        Me.lsv_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Listado.FullRowSelect = True
        Me.lsv_Listado.HideSelection = False
        Me.lsv_Listado.Location = New System.Drawing.Point(6, 35)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Listado.Lvs = ListViewColumnSorter1
        Me.lsv_Listado.MultiSelect = False
        Me.lsv_Listado.Name = "lsv_Listado"
        Me.lsv_Listado.Row1 = 10
        Me.lsv_Listado.Row10 = 0
        Me.lsv_Listado.Row2 = 20
        Me.lsv_Listado.Row3 = 15
        Me.lsv_Listado.Row4 = 15
        Me.lsv_Listado.Row5 = 10
        Me.lsv_Listado.Row6 = 10
        Me.lsv_Listado.Row7 = 10
        Me.lsv_Listado.Row8 = 0
        Me.lsv_Listado.Row9 = 0
        Me.lsv_Listado.Size = New System.Drawing.Size(757, 324)
        Me.lsv_Listado.TabIndex = 1
        Me.lsv_Listado.Tag = "Id_TipoParentesco"
        Me.lsv_Listado.UseCompatibleStateImageBehavior = False
        Me.lsv_Listado.View = System.Windows.Forms.View.Details
        '
        'frm_EmpleadosReingresosConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Listado)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EmpleadosReingresosConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Reingresos"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
        Me.gbx_Listado.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_FechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaDesde As System.Windows.Forms.Label
    Friend WithEvents lsv_Listado As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
End Class
