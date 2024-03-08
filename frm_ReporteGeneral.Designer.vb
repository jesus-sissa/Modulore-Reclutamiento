<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ReporteGeneral
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
        Dim ListViewColumnSorter3 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_ReporteGeneral))
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.Gbx_lista = New System.Windows.Forms.GroupBox()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Lsv_Lista = New Modulo_Reclutamiento.cp_Listview()
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.cmb_Departamentos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Chk_Status = New System.Windows.Forms.CheckBox()
        Me.Lbl_Status = New System.Windows.Forms.Label()
        Me.Chk_Fecha = New System.Windows.Forms.CheckBox()
        Me.Chk_Puesto = New System.Windows.Forms.CheckBox()
        Me.Chk_Departamento = New System.Windows.Forms.CheckBox()
        Me.Btn_Mostrar = New System.Windows.Forms.Button()
        Me.Cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.Lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Puesto = New System.Windows.Forms.Label()
        Me.Lbl_Departamento = New System.Windows.Forms.Label()
        Me.Dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_lista.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(624, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(12, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Gbx_lista
        '
        Me.Gbx_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_lista.Controls.Add(Me.lbl_total)
        Me.Gbx_lista.Controls.Add(Me.Lsv_Lista)
        Me.Gbx_lista.Location = New System.Drawing.Point(7, 160)
        Me.Gbx_lista.Name = "Gbx_lista"
        Me.Gbx_lista.Size = New System.Drawing.Size(770, 340)
        Me.Gbx_lista.TabIndex = 1
        Me.Gbx_lista.TabStop = False
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(596, 16)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(168, 23)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "Registros: 0"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Lsv_Lista
        '
        Me.Lsv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_Lista.FullRowSelect = True
        Me.Lsv_Lista.HideSelection = False
        Me.Lsv_Lista.Location = New System.Drawing.Point(6, 42)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.Lsv_Lista.Lvs = ListViewColumnSorter3
        Me.Lsv_Lista.MultiSelect = False
        Me.Lsv_Lista.Name = "Lsv_Lista"
        Me.Lsv_Lista.Row1 = 10
        Me.Lsv_Lista.Row10 = 10
        Me.Lsv_Lista.Row2 = 10
        Me.Lsv_Lista.Row3 = 10
        Me.Lsv_Lista.Row4 = 10
        Me.Lsv_Lista.Row5 = 10
        Me.Lsv_Lista.Row6 = 10
        Me.Lsv_Lista.Row7 = 10
        Me.Lsv_Lista.Row8 = 10
        Me.Lsv_Lista.Row9 = 10
        Me.Lsv_Lista.Size = New System.Drawing.Size(758, 292)
        Me.Lsv_Lista.TabIndex = 1
        Me.Lsv_Lista.UseCompatibleStateImageBehavior = False
        Me.Lsv_Lista.View = System.Windows.Forms.View.Details
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Departamentos)
        Me.Gbx_Filtro.Controls.Add(Me.Cmb_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Chk_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Chk_Fecha)
        Me.Gbx_Filtro.Controls.Add(Me.Chk_Puesto)
        Me.Gbx_Filtro.Controls.Add(Me.Chk_Departamento)
        Me.Gbx_Filtro.Controls.Add(Me.Btn_Mostrar)
        Me.Gbx_Filtro.Controls.Add(Me.Cmb_Puesto)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Hasta)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.lbl_Puesto)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Departamento)
        Me.Gbx_Filtro.Controls.Add(Me.Dtp_Desde)
        Me.Gbx_Filtro.Controls.Add(Me.Dtp_Hasta)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 5)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(770, 149)
        Me.Gbx_Filtro.TabIndex = 0
        Me.Gbx_Filtro.TabStop = False
        '
        'cmb_Departamentos
        '
        Me.cmb_Departamentos.Clave = Nothing
        Me.cmb_Departamentos.Control_Siguiente = Nothing
        Me.cmb_Departamentos.DisplayMember = "Descripcion"
        Me.cmb_Departamentos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamentos.Empresa = False
        Me.cmb_Departamentos.Filtro = Nothing
        Me.cmb_Departamentos.FormattingEnabled = True
        Me.cmb_Departamentos.Location = New System.Drawing.Point(89, 13)
        Me.cmb_Departamentos.MaxDropDownItems = 20
        Me.cmb_Departamentos.Name = "cmb_Departamentos"
        Me.cmb_Departamentos.Pista = False
        Me.cmb_Departamentos.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Departamentos.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamentos.Sucursal = False
        Me.cmb_Departamentos.TabIndex = 1
        Me.cmb_Departamentos.Tipo = 0
        Me.cmb_Departamentos.ValueMember = "Id_Departamento"
        '
        'Cmb_Status
        '
        Me.Cmb_Status.Control_Siguiente = Nothing
        Me.Cmb_Status.DisplayMember = "display"
        Me.Cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Status.FormattingEnabled = True
        Me.Cmb_Status.Location = New System.Drawing.Point(89, 67)
        Me.Cmb_Status.MaxDropDownItems = 20
        Me.Cmb_Status.Name = "Cmb_Status"
        Me.Cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.Cmb_Status.TabIndex = 7
        Me.Cmb_Status.ValueMember = "value"
        '
        'Chk_Status
        '
        Me.Chk_Status.AutoSize = True
        Me.Chk_Status.Location = New System.Drawing.Point(323, 69)
        Me.Chk_Status.Name = "Chk_Status"
        Me.Chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Status.TabIndex = 8
        Me.Chk_Status.Text = "Todos"
        Me.Chk_Status.UseVisualStyleBackColor = True
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(40, 70)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Status.TabIndex = 6
        Me.Lbl_Status.Text = "Status:"
        '
        'Chk_Fecha
        '
        Me.Chk_Fecha.AutoSize = True
        Me.Chk_Fecha.Location = New System.Drawing.Point(194, 95)
        Me.Chk_Fecha.Name = "Chk_Fecha"
        Me.Chk_Fecha.Size = New System.Drawing.Size(119, 17)
        Me.Chk_Fecha.TabIndex = 11
        Me.Chk_Fecha.Text = "No Filtrar por Fecha"
        Me.Chk_Fecha.UseVisualStyleBackColor = True
        '
        'Chk_Puesto
        '
        Me.Chk_Puesto.AutoSize = True
        Me.Chk_Puesto.Location = New System.Drawing.Point(323, 42)
        Me.Chk_Puesto.Name = "Chk_Puesto"
        Me.Chk_Puesto.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Puesto.TabIndex = 5
        Me.Chk_Puesto.Text = "Todos"
        Me.Chk_Puesto.UseVisualStyleBackColor = True
        '
        'Chk_Departamento
        '
        Me.Chk_Departamento.AutoSize = True
        Me.Chk_Departamento.Location = New System.Drawing.Point(323, 15)
        Me.Chk_Departamento.Name = "Chk_Departamento"
        Me.Chk_Departamento.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Departamento.TabIndex = 2
        Me.Chk_Departamento.Text = "Todos"
        Me.Chk_Departamento.UseVisualStyleBackColor = True
        '
        'Btn_Mostrar
        '
        Me.Btn_Mostrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow
        Me.Btn_Mostrar.Location = New System.Drawing.Point(323, 113)
        Me.Btn_Mostrar.Name = "Btn_Mostrar"
        Me.Btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Mostrar.TabIndex = 14
        Me.Btn_Mostrar.Text = "&Mostrar"
        Me.Btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Mostrar.UseVisualStyleBackColor = True
        '
        'Cmb_Puesto
        '
        Me.Cmb_Puesto.Clave = "Clave"
        Me.Cmb_Puesto.Control_Siguiente = Nothing
        Me.Cmb_Puesto.DisplayMember = "Descripcion"
        Me.Cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Puesto.Empresa = False
        Me.Cmb_Puesto.Filtro = Nothing
        Me.Cmb_Puesto.FormattingEnabled = True
        Me.Cmb_Puesto.Location = New System.Drawing.Point(89, 40)
        Me.Cmb_Puesto.MaxDropDownItems = 20
        Me.Cmb_Puesto.Name = "Cmb_Puesto"
        Me.Cmb_Puesto.Pista = False
        Me.Cmb_Puesto.Size = New System.Drawing.Size(228, 21)
        Me.Cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.Cmb_Puesto.Sucursal = False
        Me.Cmb_Puesto.TabIndex = 4
        Me.Cmb_Puesto.Tipo = 0
        Me.Cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(45, 123)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Hasta.TabIndex = 12
        Me.Lbl_Hasta.Text = "Hasta:"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(42, 98)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Desde.TabIndex = 9
        Me.Lbl_Desde.Text = "Desde:"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(40, 43)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Puesto.TabIndex = 3
        Me.lbl_Puesto.Text = "Puesto:"
        '
        'Lbl_Departamento
        '
        Me.Lbl_Departamento.AutoSize = True
        Me.Lbl_Departamento.Location = New System.Drawing.Point(6, 16)
        Me.Lbl_Departamento.Name = "Lbl_Departamento"
        Me.Lbl_Departamento.Size = New System.Drawing.Size(77, 13)
        Me.Lbl_Departamento.TabIndex = 0
        Me.Lbl_Departamento.Text = "Departamento:"
        '
        'Dtp_Desde
        '
        Me.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Desde.Location = New System.Drawing.Point(89, 95)
        Me.Dtp_Desde.Name = "Dtp_Desde"
        Me.Dtp_Desde.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Desde.TabIndex = 10
        '
        'Dtp_Hasta
        '
        Me.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Hasta.Location = New System.Drawing.Point(89, 121)
        Me.Dtp_Hasta.Name = "Dtp_Hasta"
        Me.Dtp_Hasta.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Hasta.TabIndex = 13
        '
        'frm_ReporteGeneral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_lista)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ReporteGeneral"
        Me.Text = "Reporte General"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_lista.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_lista As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lsv_Lista As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents Lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents Btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents lbl_total As System.Windows.Forms.Label
    Friend WithEvents Btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Chk_Fecha As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Puesto As System.Windows.Forms.CheckBox
    Friend WithEvents Chk_Departamento As System.Windows.Forms.CheckBox
    Friend WithEvents Cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Departamentos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
End Class
