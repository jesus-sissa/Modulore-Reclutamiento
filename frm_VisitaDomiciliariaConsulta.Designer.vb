<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisitaDomiciliariaConsulta
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
        Me.gbx_Controles = New System.Windows.Forms.GroupBox
        Me.btn_Importar = New System.Windows.Forms.Button
        Me.btn_Visitas = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.rdb_Prospectos = New System.Windows.Forms.RadioButton
        Me.rdb_Empleados = New System.Windows.Forms.RadioButton
        Me.cmb_Empleado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.chk_Empleado = New System.Windows.Forms.CheckBox
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.lsv_ListadoConsulta = New Modulo_Reclutamiento.cp_Listview
        Me.gbx_Controles.SuspendLayout()
        Me.gbx_Consulta.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Controles
        '
        Me.gbx_Controles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Controles.Controls.Add(Me.btn_Importar)
        Me.gbx_Controles.Controls.Add(Me.btn_Visitas)
        Me.gbx_Controles.Controls.Add(Me.btn_Exportar)
        Me.gbx_Controles.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Controles.Location = New System.Drawing.Point(7, 555)
        Me.gbx_Controles.Name = "gbx_Controles"
        Me.gbx_Controles.Size = New System.Drawing.Size(870, 50)
        Me.gbx_Controles.TabIndex = 2
        Me.gbx_Controles.TabStop = False
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Enabled = False
        Me.btn_Importar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_Importar.Location = New System.Drawing.Point(288, 14)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Importar.TabIndex = 2
        Me.btn_Importar.Text = "&Importar/Exportar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'btn_Visitas
        '
        Me.btn_Visitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Visitas.Enabled = False
        Me.btn_Visitas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.CasaVisita
        Me.btn_Visitas.Location = New System.Drawing.Point(152, 14)
        Me.btn_Visitas.Name = "btn_Visitas"
        Me.btn_Visitas.Size = New System.Drawing.Size(130, 30)
        Me.btn_Visitas.TabIndex = 1
        Me.btn_Visitas.Text = "Visita &Domiciliaria"
        Me.btn_Visitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Visitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Visitas.UseVisualStyleBackColor = True
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
        Me.btn_Cerrar.Location = New System.Drawing.Point(723, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.Lbl_Numero)
        Me.gbx_Consulta.Controls.Add(Me.rdb_Prospectos)
        Me.gbx_Consulta.Controls.Add(Me.rdb_Empleados)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Empleado)
        Me.gbx_Consulta.Controls.Add(Me.chk_Empleado)
        Me.gbx_Consulta.Controls.Add(Me.lbl_Empleado)
        Me.gbx_Consulta.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Consulta.Controls.Add(Me.lbl_FechaHasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_FechaHasta)
        Me.gbx_Consulta.Controls.Add(Me.dtp_FechaDesde)
        Me.gbx_Consulta.Controls.Add(Me.lbl_FechaDesde)
        Me.gbx_Consulta.Controls.Add(Me.lsv_ListadoConsulta)
        Me.gbx_Consulta.Controls.Add(Me.tbx_Clave)
        Me.gbx_Consulta.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(870, 547)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(733, 63)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(130, 23)
        Me.Lbl_Numero.TabIndex = 24
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb_Prospectos
        '
        Me.rdb_Prospectos.AutoSize = True
        Me.rdb_Prospectos.Location = New System.Drawing.Point(182, 45)
        Me.rdb_Prospectos.Name = "rdb_Prospectos"
        Me.rdb_Prospectos.Size = New System.Drawing.Size(78, 17)
        Me.rdb_Prospectos.TabIndex = 5
        Me.rdb_Prospectos.TabStop = True
        Me.rdb_Prospectos.Text = "Prospectos"
        Me.rdb_Prospectos.UseVisualStyleBackColor = True
        '
        'rdb_Empleados
        '
        Me.rdb_Empleados.AutoSize = True
        Me.rdb_Empleados.Checked = True
        Me.rdb_Empleados.Location = New System.Drawing.Point(86, 45)
        Me.rdb_Empleados.Name = "rdb_Empleados"
        Me.rdb_Empleados.Size = New System.Drawing.Size(77, 17)
        Me.rdb_Empleados.TabIndex = 4
        Me.rdb_Empleados.TabStop = True
        Me.rdb_Empleados.Text = "Empleados"
        Me.rdb_Empleados.UseVisualStyleBackColor = True
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave"
        Me.cmb_Empleado.Control_Siguiente = Me.btn_Mostrar
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_Clave
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(86, 68)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = False
        Me.cmb_Empleado.Size = New System.Drawing.Size(378, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_EmpleadosCombo_GetTodos"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 8
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(569, 59)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 10
        Me.btn_Mostrar.Text = "&Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Nothing
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(81, 60)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 7
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'chk_Empleado
        '
        Me.chk_Empleado.AutoSize = True
        Me.chk_Empleado.Location = New System.Drawing.Point(470, 70)
        Me.chk_Empleado.Name = "chk_Empleado"
        Me.chk_Empleado.Size = New System.Drawing.Size(56, 17)
        Me.chk_Empleado.TabIndex = 9
        Me.chk_Empleado.Text = "Todos"
        Me.chk_Empleado.UseVisualStyleBackColor = True
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(26, 71)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 6
        Me.lbl_Empleado.Text = "Empleado"
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
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaHasta.TabIndex = 3
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(86, 19)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(100, 20)
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
        'lsv_ListadoConsulta
        '
        Me.lsv_ListadoConsulta.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_ListadoConsulta.FullRowSelect = True
        Me.lsv_ListadoConsulta.HideSelection = False
        Me.lsv_ListadoConsulta.Location = New System.Drawing.Point(6, 95)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_ListadoConsulta.Lvs = ListViewColumnSorter1
        Me.lsv_ListadoConsulta.MultiSelect = False
        Me.lsv_ListadoConsulta.Name = "lsv_ListadoConsulta"
        Me.lsv_ListadoConsulta.Row1 = 15
        Me.lsv_ListadoConsulta.Row10 = 0
        Me.lsv_ListadoConsulta.Row2 = 10
        Me.lsv_ListadoConsulta.Row3 = 10
        Me.lsv_ListadoConsulta.Row4 = 30
        Me.lsv_ListadoConsulta.Row5 = 30
        Me.lsv_ListadoConsulta.Row6 = 0
        Me.lsv_ListadoConsulta.Row7 = 0
        Me.lsv_ListadoConsulta.Row8 = 0
        Me.lsv_ListadoConsulta.Row9 = 0
        Me.lsv_ListadoConsulta.Size = New System.Drawing.Size(857, 446)
        Me.lsv_ListadoConsulta.TabIndex = 11
        Me.lsv_ListadoConsulta.Tag = ""
        Me.lsv_ListadoConsulta.UseCompatibleStateImageBehavior = False
        Me.lsv_ListadoConsulta.View = System.Windows.Forms.View.Details
        '
        'frm_VisitaDomiciliariaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 611)
        Me.Controls.Add(Me.gbx_Controles)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 650)
        Me.Name = "frm_VisitaDomiciliariaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Visitas Domiciliarias"
        Me.gbx_Controles.ResumeLayout(False)
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
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
    Friend WithEvents lsv_ListadoConsulta As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents chk_Empleado As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents cmb_Empleado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents rdb_Prospectos As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Empleados As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Visitas As System.Windows.Forms.Button
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
