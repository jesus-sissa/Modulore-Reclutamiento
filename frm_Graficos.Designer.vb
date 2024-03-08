<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Graficos
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
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Graficos))
        Me.gbx_Controles = New System.Windows.Forms.GroupBox()
        Me.btn_Graficar = New System.Windows.Forms.Button()
        Me.btn_ExportarDatos = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.gbx_Rangos = New System.Windows.Forms.GroupBox()
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_Mostrar = New System.Windows.Forms.Button()
        Me.chk_Puesto = New System.Windows.Forms.CheckBox()
        Me.lbl_Puesto = New System.Windows.Forms.Label()
        Me.cmb_Departamento = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_DepTodos = New System.Windows.Forms.CheckBox()
        Me.dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Desde = New System.Windows.Forms.Label()
        Me.lbl_Departamento = New System.Windows.Forms.Label()
        Me.lbl_Hasta = New System.Windows.Forms.Label()
        Me.dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Lista = New System.Windows.Forms.GroupBox()
        Me.lsv_Datos = New Modulo_Reclutamiento.cp_Listview()
        Me.gbx_Tipo = New System.Windows.Forms.GroupBox()
        Me.cmb_Especifique = New System.Windows.Forms.ComboBox()
        Me.lbl_Especifique = New System.Windows.Forms.Label()
        Me.cmb_TipoConsulta = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Rangos.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.gbx_Tipo.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Graficar)
        Me.gbx_Controles.Controls.Add(Me.btn_ExportarDatos)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(5, 574)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(882, 50)
        Me.gbx_Controles.TabIndex = 3
        Me.gbx_Controles.TabStop = False
        '
        'btn_Graficar
        '
        Me.btn_Graficar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Graficar.Enabled = False
        Me.btn_Graficar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Graficas
        Me.btn_Graficar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Graficar.Name = "btn_Graficar"
        Me.btn_Graficar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Graficar.TabIndex = 1
        Me.btn_Graficar.Text = "&Graficar"
        Me.btn_Graficar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Graficar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Graficar.UseVisualStyleBackColor = True
        '
        'btn_ExportarDatos
        '
        Me.btn_ExportarDatos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarDatos.Enabled = False
        Me.btn_ExportarDatos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarDatos.Location = New System.Drawing.Point(6, 14)
        Me.btn_ExportarDatos.Name = "btn_ExportarDatos"
        Me.btn_ExportarDatos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarDatos.TabIndex = 0
        Me.btn_ExportarDatos.Text = "&Exportar Datos"
        Me.btn_ExportarDatos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarDatos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarDatos.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(736, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Rangos
        '
        Me.gbx_Rangos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Rangos.Controls.Add(Me.cmb_Puesto)
        Me.gbx_Rangos.Controls.Add(Me.chk_Puesto)
        Me.gbx_Rangos.Controls.Add(Me.lbl_Puesto)
        Me.gbx_Rangos.Controls.Add(Me.cmb_Departamento)
        Me.gbx_Rangos.Controls.Add(Me.chk_DepTodos)
        Me.gbx_Rangos.Controls.Add(Me.dtp_Desde)
        Me.gbx_Rangos.Controls.Add(Me.lbl_Desde)
        Me.gbx_Rangos.Controls.Add(Me.lbl_Departamento)
        Me.gbx_Rangos.Controls.Add(Me.lbl_Hasta)
        Me.gbx_Rangos.Controls.Add(Me.dtp_Hasta)
        Me.gbx_Rangos.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Rangos.Location = New System.Drawing.Point(263, 2)
        Me.gbx_Rangos.Name = "gbx_Rangos"
        Me.gbx_Rangos.Size = New System.Drawing.Size(624, 91)
        Me.gbx_Rangos.TabIndex = 1
        Me.gbx_Rangos.TabStop = False
        Me.gbx_Rangos.Text = "Rangos"
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.Location = New System.Drawing.Point(86, 64)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(323, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 8
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(477, 55)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'chk_Puesto
        '
        Me.chk_Puesto.AutoSize = True
        Me.chk_Puesto.Location = New System.Drawing.Point(415, 66)
        Me.chk_Puesto.Name = "chk_Puesto"
        Me.chk_Puesto.Size = New System.Drawing.Size(56, 17)
        Me.chk_Puesto.TabIndex = 9
        Me.chk_Puesto.Text = "Todos"
        Me.chk_Puesto.UseVisualStyleBackColor = True
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(40, 67)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 7
        Me.lbl_Puesto.Text = "Puesto"
        '
        'cmb_Departamento
        '
        Me.cmb_Departamento.Clave = "Clave"
        Me.cmb_Departamento.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Departamento.DisplayMember = "Descripcion"
        Me.cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento.Empresa = False
        Me.cmb_Departamento.Filtro = Nothing
        Me.cmb_Departamento.FormattingEnabled = True
        Me.cmb_Departamento.Location = New System.Drawing.Point(86, 39)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(323, 21)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 5
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'chk_DepTodos
        '
        Me.chk_DepTodos.AutoSize = True
        Me.chk_DepTodos.Location = New System.Drawing.Point(415, 41)
        Me.chk_DepTodos.Name = "chk_DepTodos"
        Me.chk_DepTodos.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepTodos.TabIndex = 6
        Me.chk_DepTodos.Text = "Todos"
        Me.chk_DepTodos.UseVisualStyleBackColor = True
        '
        'dtp_Desde
        '
        Me.dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Desde.Location = New System.Drawing.Point(86, 16)
        Me.dtp_Desde.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.dtp_Desde.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Desde.Name = "dtp_Desde"
        Me.dtp_Desde.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Desde.TabIndex = 1
        Me.dtp_Desde.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'lbl_Desde
        '
        Me.lbl_Desde.AutoSize = True
        Me.lbl_Desde.Location = New System.Drawing.Point(42, 19)
        Me.lbl_Desde.Name = "lbl_Desde"
        Me.lbl_Desde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_Desde.TabIndex = 0
        Me.lbl_Desde.Text = "Desde"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(6, 42)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 4
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Hasta
        '
        Me.lbl_Hasta.AutoSize = True
        Me.lbl_Hasta.Location = New System.Drawing.Point(188, 19)
        Me.lbl_Hasta.Name = "lbl_Hasta"
        Me.lbl_Hasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Hasta.TabIndex = 2
        Me.lbl_Hasta.Text = "Hasta"
        '
        'dtp_Hasta
        '
        Me.dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Hasta.Location = New System.Drawing.Point(229, 16)
        Me.dtp_Hasta.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.dtp_Hasta.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtp_Hasta.Name = "dtp_Hasta"
        Me.dtp_Hasta.Size = New System.Drawing.Size(96, 20)
        Me.dtp_Hasta.TabIndex = 3
        Me.dtp_Hasta.Value = New Date(2009, 6, 24, 0, 0, 0, 0)
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.lsv_Datos)
        Me.gbx_Lista.Location = New System.Drawing.Point(5, 122)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(882, 446)
        Me.gbx_Lista.TabIndex = 2
        Me.gbx_Lista.TabStop = False
        '
        'lsv_Datos
        '
        Me.lsv_Datos.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar
        Me.lsv_Datos.Activation = System.Windows.Forms.ItemActivation.OneClick
        Me.lsv_Datos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.HoverSelection = True
        Me.lsv_Datos.ImeMode = System.Windows.Forms.ImeMode.Off
        Me.lsv_Datos.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 10
        Me.lsv_Datos.Row10 = 10
        Me.lsv_Datos.Row2 = 10
        Me.lsv_Datos.Row3 = 10
        Me.lsv_Datos.Row4 = 10
        Me.lsv_Datos.Row5 = 10
        Me.lsv_Datos.Row6 = 10
        Me.lsv_Datos.Row7 = 10
        Me.lsv_Datos.Row8 = 10
        Me.lsv_Datos.Row9 = 10
        Me.lsv_Datos.Size = New System.Drawing.Size(876, 427)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'gbx_Tipo
        '
        Me.gbx_Tipo.Controls.Add(Me.cmb_Especifique)
        Me.gbx_Tipo.Controls.Add(Me.lbl_Especifique)
        Me.gbx_Tipo.Controls.Add(Me.cmb_TipoConsulta)
        Me.gbx_Tipo.Location = New System.Drawing.Point(5, 2)
        Me.gbx_Tipo.Name = "gbx_Tipo"
        Me.gbx_Tipo.Size = New System.Drawing.Size(252, 91)
        Me.gbx_Tipo.TabIndex = 0
        Me.gbx_Tipo.TabStop = False
        Me.gbx_Tipo.Text = "Tipo de Consulta"
        '
        'cmb_Especifique
        '
        Me.cmb_Especifique.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Especifique.FormattingEnabled = True
        Me.cmb_Especifique.Location = New System.Drawing.Point(6, 64)
        Me.cmb_Especifique.MaxDropDownItems = 20
        Me.cmb_Especifique.Name = "cmb_Especifique"
        Me.cmb_Especifique.Size = New System.Drawing.Size(240, 21)
        Me.cmb_Especifique.TabIndex = 2
        '
        'lbl_Especifique
        '
        Me.lbl_Especifique.AutoSize = True
        Me.lbl_Especifique.Location = New System.Drawing.Point(6, 48)
        Me.lbl_Especifique.Name = "lbl_Especifique"
        Me.lbl_Especifique.Size = New System.Drawing.Size(62, 13)
        Me.lbl_Especifique.TabIndex = 1
        Me.lbl_Especifique.Text = "Especifique"
        '
        'cmb_TipoConsulta
        '
        Me.cmb_TipoConsulta.Control_Siguiente = Me.dtp_Desde
        Me.cmb_TipoConsulta.DisplayMember = "display"
        Me.cmb_TipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoConsulta.FormattingEnabled = True
        Me.cmb_TipoConsulta.Location = New System.Drawing.Point(6, 16)
        Me.cmb_TipoConsulta.MaxDropDownItems = 20
        Me.cmb_TipoConsulta.Name = "cmb_TipoConsulta"
        Me.cmb_TipoConsulta.Size = New System.Drawing.Size(240, 21)
        Me.cmb_TipoConsulta.TabIndex = 0
        Me.cmb_TipoConsulta.ValueMember = "value"
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(665, 96)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 22
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_Graficos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 641)
        Me.Controls.Add(Me.Lbl_Numero)
        Me.Controls.Add(Me.gbx_Tipo)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Controls.Add(Me.gbx_Rangos)
        Me.Controls.Add(Me.gbx_Controles)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(910, 680)
        Me.Name = "frm_Graficos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gráficos"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Rangos.ResumeLayout(False)
        Me.gbx_Rangos.PerformLayout()
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Tipo.ResumeLayout(False)
        Me.gbx_Tipo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Controles As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ExportarDatos As System.Windows.Forms.Button
    Friend WithEvents gbx_Rangos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents gbx_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_TipoConsulta As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents cmb_Departamento As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Puesto As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents chk_DepTodos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Especifique As System.Windows.Forms.Label
    Friend WithEvents cmb_Especifique As System.Windows.Forms.ComboBox
    Friend WithEvents btn_Graficar As System.Windows.Forms.Button
    Friend WithEvents lsv_Datos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
