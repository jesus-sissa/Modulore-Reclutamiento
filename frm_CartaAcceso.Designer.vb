<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CartaAcceso
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
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.cmb_Empleado1 = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveEmpleado = New Modulo_Reclutamiento.cp_Textbox
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.gbx_Tipo = New System.Windows.Forms.GroupBox
        Me.rdb_Visitante = New System.Windows.Forms.RadioButton
        Me.rdb_Empleado = New System.Windows.Forms.RadioButton
        Me.lbl_Instrucciones = New System.Windows.Forms.Label
        Me.tbx_Empresa = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Asunto = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Empresa = New System.Windows.Forms.Label
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.tbx_Nombre = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.lsv_PersonasAutorizadas = New Modulo_Reclutamiento.cp_Listview
        Me.Lbl_TipoCarta = New System.Windows.Forms.Label
        Me.Gbx_TipoCarta = New System.Windows.Forms.GroupBox
        Me.rdb_Externo = New System.Windows.Forms.RadioButton
        Me.rdb_Otro = New System.Windows.Forms.RadioButton
        Me.rdb_NuevoIngreso = New System.Windows.Forms.RadioButton
        Me.rdb_Falta = New System.Windows.Forms.RadioButton
        Me.lbl_FechaExpira = New System.Windows.Forms.Label
        Me.dtp_FechaExpira = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaInicio = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaInicio = New System.Windows.Forms.Label
        Me.lbl_Dirigida = New System.Windows.Forms.Label
        Me.lbl_Asunto = New System.Windows.Forms.Label
        Me.lbl_Autoriza = New System.Windows.Forms.Label
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Datos2 = New System.Windows.Forms.GroupBox
        Me.cmb_DirigidoA = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveDirigida = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Autoriza = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.Gbx_Datos.SuspendLayout()
        Me.gbx_Tipo.SuspendLayout()
        Me.Gbx_TipoCarta.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Datos2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.cmb_Empleado1)
        Me.Gbx_Datos.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Datos.Controls.Add(Me.tbx_ClaveEmpleado)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Empleado)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Tipo)
        Me.Gbx_Datos.Controls.Add(Me.gbx_Tipo)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Instrucciones)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Empresa)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Empresa)
        Me.Gbx_Datos.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Nombre)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Nombre)
        Me.Gbx_Datos.Controls.Add(Me.lsv_PersonasAutorizadas)
        Me.Gbx_Datos.Location = New System.Drawing.Point(6, 4)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(771, 355)
        Me.Gbx_Datos.TabIndex = 0
        Me.Gbx_Datos.TabStop = False
        '
        'cmb_Empleado1
        '
        Me.cmb_Empleado1.Clave = "Clave_Empleado"
        Me.cmb_Empleado1.Control_Siguiente = Nothing
        Me.cmb_Empleado1.DisplayMember = "Nombre"
        Me.cmb_Empleado1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado1.Empresa = False
        Me.cmb_Empleado1.Filtro = Me.tbx_ClaveEmpleado
        Me.cmb_Empleado1.FormattingEnabled = True
        Me.cmb_Empleado1.Location = New System.Drawing.Point(83, 73)
        Me.cmb_Empleado1.MaxDropDownItems = 20
        Me.cmb_Empleado1.Name = "cmb_Empleado1"
        Me.cmb_Empleado1.Pista = True
        Me.cmb_Empleado1.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Empleado1.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleado1.Sucursal = True
        Me.cmb_Empleado1.TabIndex = 12
        Me.cmb_Empleado1.Tipo = 0
        Me.cmb_Empleado1.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveEmpleado
        '
        Me.tbx_ClaveEmpleado.Control_Siguiente = Nothing
        Me.tbx_ClaveEmpleado.Filtrado = True
        Me.tbx_ClaveEmpleado.Location = New System.Drawing.Point(78, 70)
        Me.tbx_ClaveEmpleado.MaxLength = 12
        Me.tbx_ClaveEmpleado.Name = "tbx_ClaveEmpleado"
        Me.tbx_ClaveEmpleado.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveEmpleado.TabIndex = 4
        Me.tbx_ClaveEmpleado.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveEmpleado.Visible = False
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Trash16
        Me.btn_Borrar.Location = New System.Drawing.Point(6, 315)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 1
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Location = New System.Drawing.Point(23, 77)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 3
        Me.lbl_Empleado.Text = "Empleado"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(49, 46)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tipo.TabIndex = 1
        Me.lbl_Tipo.Text = "Tipo"
        '
        'gbx_Tipo
        '
        Me.gbx_Tipo.Controls.Add(Me.rdb_Visitante)
        Me.gbx_Tipo.Controls.Add(Me.rdb_Empleado)
        Me.gbx_Tipo.Location = New System.Drawing.Point(83, 34)
        Me.gbx_Tipo.Name = "gbx_Tipo"
        Me.gbx_Tipo.Size = New System.Drawing.Size(171, 33)
        Me.gbx_Tipo.TabIndex = 2
        Me.gbx_Tipo.TabStop = False
        '
        'rdb_Visitante
        '
        Me.rdb_Visitante.AutoSize = True
        Me.rdb_Visitante.Location = New System.Drawing.Point(100, 10)
        Me.rdb_Visitante.Name = "rdb_Visitante"
        Me.rdb_Visitante.Size = New System.Drawing.Size(65, 17)
        Me.rdb_Visitante.TabIndex = 1
        Me.rdb_Visitante.Text = "Visitante"
        Me.rdb_Visitante.UseVisualStyleBackColor = True
        '
        'rdb_Empleado
        '
        Me.rdb_Empleado.AutoSize = True
        Me.rdb_Empleado.Checked = True
        Me.rdb_Empleado.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Empleado.Name = "rdb_Empleado"
        Me.rdb_Empleado.Size = New System.Drawing.Size(72, 17)
        Me.rdb_Empleado.TabIndex = 0
        Me.rdb_Empleado.TabStop = True
        Me.rdb_Empleado.Text = "Empleado"
        Me.rdb_Empleado.UseVisualStyleBackColor = True
        '
        'lbl_Instrucciones
        '
        Me.lbl_Instrucciones.AutoSize = True
        Me.lbl_Instrucciones.Location = New System.Drawing.Point(80, 18)
        Me.lbl_Instrucciones.Name = "lbl_Instrucciones"
        Me.lbl_Instrucciones.Size = New System.Drawing.Size(334, 13)
        Me.lbl_Instrucciones.TabIndex = 0
        Me.lbl_Instrucciones.Text = "Agregue una a una las personas que tendrán acceso al Área Segura."
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.Control_Siguiente = Me.tbx_Asunto
        Me.tbx_Empresa.Filtrado = False
        Me.tbx_Empresa.Location = New System.Drawing.Point(83, 126)
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.ReadOnly = True
        Me.tbx_Empresa.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Empresa.TabIndex = 9
        Me.tbx_Empresa.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Asunto
        '
        Me.tbx_Asunto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Asunto.Control_Siguiente = Nothing
        Me.tbx_Asunto.Filtrado = True
        Me.tbx_Asunto.Location = New System.Drawing.Point(83, 84)
        Me.tbx_Asunto.MaxLength = 600
        Me.tbx_Asunto.Multiline = True
        Me.tbx_Asunto.Name = "tbx_Asunto"
        Me.tbx_Asunto.Size = New System.Drawing.Size(400, 27)
        Me.tbx_Asunto.TabIndex = 19
        Me.tbx_Asunto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(29, 129)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 8
        Me.lbl_Empresa.Text = "Empresa"
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(498, 116)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 10
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Nombre.Enabled = False
        Me.tbx_Nombre.Filtrado = False
        Me.tbx_Nombre.Location = New System.Drawing.Point(83, 100)
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Nombre.TabIndex = 7
        Me.tbx_Nombre.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Enabled = False
        Me.lbl_Nombre.Location = New System.Drawing.Point(33, 103)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 6
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lsv_PersonasAutorizadas
        '
        Me.lsv_PersonasAutorizadas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_PersonasAutorizadas.FullRowSelect = True
        Me.lsv_PersonasAutorizadas.HideSelection = False
        Me.lsv_PersonasAutorizadas.Location = New System.Drawing.Point(6, 152)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_PersonasAutorizadas.Lvs = ListViewColumnSorter2
        Me.lsv_PersonasAutorizadas.MultiSelect = False
        Me.lsv_PersonasAutorizadas.Name = "lsv_PersonasAutorizadas"
        Me.lsv_PersonasAutorizadas.Row1 = 5
        Me.lsv_PersonasAutorizadas.Row10 = 0
        Me.lsv_PersonasAutorizadas.Row2 = 30
        Me.lsv_PersonasAutorizadas.Row3 = 30
        Me.lsv_PersonasAutorizadas.Row4 = 0
        Me.lsv_PersonasAutorizadas.Row5 = 0
        Me.lsv_PersonasAutorizadas.Row6 = 0
        Me.lsv_PersonasAutorizadas.Row7 = 0
        Me.lsv_PersonasAutorizadas.Row8 = 0
        Me.lsv_PersonasAutorizadas.Row9 = 0
        Me.lsv_PersonasAutorizadas.Size = New System.Drawing.Size(759, 157)
        Me.lsv_PersonasAutorizadas.TabIndex = 11
        Me.lsv_PersonasAutorizadas.Tag = "Id_TipoParentesco"
        Me.lsv_PersonasAutorizadas.UseCompatibleStateImageBehavior = False
        Me.lsv_PersonasAutorizadas.View = System.Windows.Forms.View.Details
        '
        'Lbl_TipoCarta
        '
        Me.Lbl_TipoCarta.AutoSize = True
        Me.Lbl_TipoCarta.Location = New System.Drawing.Point(6, 56)
        Me.Lbl_TipoCarta.Name = "Lbl_TipoCarta"
        Me.Lbl_TipoCarta.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_TipoCarta.TabIndex = 16
        Me.Lbl_TipoCarta.Text = "Tipo de Carta"
        '
        'Gbx_TipoCarta
        '
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_Externo)
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_Otro)
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_NuevoIngreso)
        Me.Gbx_TipoCarta.Controls.Add(Me.rdb_Falta)
        Me.Gbx_TipoCarta.Location = New System.Drawing.Point(83, 45)
        Me.Gbx_TipoCarta.Name = "Gbx_TipoCarta"
        Me.Gbx_TipoCarta.Size = New System.Drawing.Size(400, 33)
        Me.Gbx_TipoCarta.TabIndex = 17
        Me.Gbx_TipoCarta.TabStop = False
        '
        'rdb_Externo
        '
        Me.rdb_Externo.AutoSize = True
        Me.rdb_Externo.Enabled = False
        Me.rdb_Externo.Location = New System.Drawing.Point(227, 10)
        Me.rdb_Externo.Name = "rdb_Externo"
        Me.rdb_Externo.Size = New System.Drawing.Size(113, 17)
        Me.rdb_Externo.TabIndex = 3
        Me.rdb_Externo.Text = "Personas Externas"
        Me.rdb_Externo.UseVisualStyleBackColor = True
        '
        'rdb_Otro
        '
        Me.rdb_Otro.AutoSize = True
        Me.rdb_Otro.Location = New System.Drawing.Point(350, 11)
        Me.rdb_Otro.Name = "rdb_Otro"
        Me.rdb_Otro.Size = New System.Drawing.Size(45, 17)
        Me.rdb_Otro.TabIndex = 2
        Me.rdb_Otro.Text = "Otro"
        Me.rdb_Otro.UseVisualStyleBackColor = True
        '
        'rdb_NuevoIngreso
        '
        Me.rdb_NuevoIngreso.AutoSize = True
        Me.rdb_NuevoIngreso.Location = New System.Drawing.Point(120, 11)
        Me.rdb_NuevoIngreso.Name = "rdb_NuevoIngreso"
        Me.rdb_NuevoIngreso.Size = New System.Drawing.Size(95, 17)
        Me.rdb_NuevoIngreso.TabIndex = 1
        Me.rdb_NuevoIngreso.Text = "Nuevo Ingreso"
        Me.rdb_NuevoIngreso.UseVisualStyleBackColor = True
        '
        'rdb_Falta
        '
        Me.rdb_Falta.AutoSize = True
        Me.rdb_Falta.Location = New System.Drawing.Point(6, 11)
        Me.rdb_Falta.Name = "rdb_Falta"
        Me.rdb_Falta.Size = New System.Drawing.Size(105, 17)
        Me.rdb_Falta.TabIndex = 0
        Me.rdb_Falta.Text = "Acceso por Falta"
        Me.rdb_Falta.UseVisualStyleBackColor = True
        '
        'lbl_FechaExpira
        '
        Me.lbl_FechaExpira.AutoSize = True
        Me.lbl_FechaExpira.Location = New System.Drawing.Point(187, 25)
        Me.lbl_FechaExpira.Name = "lbl_FechaExpira"
        Me.lbl_FechaExpira.Size = New System.Drawing.Size(69, 13)
        Me.lbl_FechaExpira.TabIndex = 14
        Me.lbl_FechaExpira.Text = "Fecha Expira"
        '
        'dtp_FechaExpira
        '
        Me.dtp_FechaExpira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpira.Location = New System.Drawing.Point(262, 19)
        Me.dtp_FechaExpira.Name = "dtp_FechaExpira"
        Me.dtp_FechaExpira.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaExpira.TabIndex = 15
        Me.dtp_FechaExpira.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtp_FechaInicio
        '
        Me.dtp_FechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaInicio.Location = New System.Drawing.Point(83, 19)
        Me.dtp_FechaInicio.Name = "dtp_FechaInicio"
        Me.dtp_FechaInicio.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaInicio.TabIndex = 13
        Me.dtp_FechaInicio.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(12, 23)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 12
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'lbl_Dirigida
        '
        Me.lbl_Dirigida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Dirigida.AutoSize = True
        Me.lbl_Dirigida.Location = New System.Drawing.Point(26, 147)
        Me.lbl_Dirigida.Name = "lbl_Dirigida"
        Me.lbl_Dirigida.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Dirigida.TabIndex = 23
        Me.lbl_Dirigida.Text = "Dirigida a"
        '
        'lbl_Asunto
        '
        Me.lbl_Asunto.AutoSize = True
        Me.lbl_Asunto.Location = New System.Drawing.Point(37, 87)
        Me.lbl_Asunto.Name = "lbl_Asunto"
        Me.lbl_Asunto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Asunto.TabIndex = 18
        Me.lbl_Asunto.Text = "Asunto"
        '
        'lbl_Autoriza
        '
        Me.lbl_Autoriza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lbl_Autoriza.AutoSize = True
        Me.lbl_Autoriza.Location = New System.Drawing.Point(32, 120)
        Me.lbl_Autoriza.Name = "lbl_Autoriza"
        Me.lbl_Autoriza.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Autoriza.TabIndex = 20
        Me.lbl_Autoriza.Text = "Autoriza"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(6, 546)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(771, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(625, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Datos2
        '
        Me.Gbx_Datos2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos2.Controls.Add(Me.tbx_Asunto)
        Me.Gbx_Datos2.Controls.Add(Me.lbl_Autoriza)
        Me.Gbx_Datos2.Controls.Add(Me.lbl_Asunto)
        Me.Gbx_Datos2.Controls.Add(Me.cmb_DirigidoA)
        Me.Gbx_Datos2.Controls.Add(Me.Lbl_TipoCarta)
        Me.Gbx_Datos2.Controls.Add(Me.lbl_Dirigida)
        Me.Gbx_Datos2.Controls.Add(Me.lbl_FechaExpira)
        Me.Gbx_Datos2.Controls.Add(Me.dtp_FechaExpira)
        Me.Gbx_Datos2.Controls.Add(Me.dtp_FechaInicio)
        Me.Gbx_Datos2.Controls.Add(Me.Gbx_TipoCarta)
        Me.Gbx_Datos2.Controls.Add(Me.lbl_FechaInicio)
        Me.Gbx_Datos2.Controls.Add(Me.cmb_Autoriza)
        Me.Gbx_Datos2.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Datos2.Controls.Add(Me.tbx_ClaveDirigida)
        Me.Gbx_Datos2.Location = New System.Drawing.Point(6, 363)
        Me.Gbx_Datos2.Name = "Gbx_Datos2"
        Me.Gbx_Datos2.Size = New System.Drawing.Size(771, 177)
        Me.Gbx_Datos2.TabIndex = 2
        Me.Gbx_Datos2.TabStop = False
        '
        'cmb_DirigidoA
        '
        Me.cmb_DirigidoA.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_DirigidoA.Clave = "Clave_Empleado"
        Me.cmb_DirigidoA.Control_Siguiente = Nothing
        Me.cmb_DirigidoA.DisplayMember = "Nombre"
        Me.cmb_DirigidoA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DirigidoA.Empresa = False
        Me.cmb_DirigidoA.Filtro = Me.tbx_ClaveDirigida
        Me.cmb_DirigidoA.FormattingEnabled = True
        Me.cmb_DirigidoA.Location = New System.Drawing.Point(83, 143)
        Me.cmb_DirigidoA.MaxDropDownItems = 20
        Me.cmb_DirigidoA.Name = "cmb_DirigidoA"
        Me.cmb_DirigidoA.Pista = True
        Me.cmb_DirigidoA.Size = New System.Drawing.Size(400, 21)
        Me.cmb_DirigidoA.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_DirigidoA.Sucursal = True
        Me.cmb_DirigidoA.TabIndex = 25
        Me.cmb_DirigidoA.Tipo = 0
        Me.cmb_DirigidoA.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveDirigida
        '
        Me.tbx_ClaveDirigida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_ClaveDirigida.Control_Siguiente = Nothing
        Me.tbx_ClaveDirigida.Filtrado = True
        Me.tbx_ClaveDirigida.Location = New System.Drawing.Point(78, 144)
        Me.tbx_ClaveDirigida.MaxLength = 12
        Me.tbx_ClaveDirigida.Name = "tbx_ClaveDirigida"
        Me.tbx_ClaveDirigida.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveDirigida.TabIndex = 24
        Me.tbx_ClaveDirigida.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveDirigida.Visible = False
        '
        'cmb_Autoriza
        '
        Me.cmb_Autoriza.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_Autoriza.Clave = "Clave_Empleado"
        Me.cmb_Autoriza.Control_Siguiente = Nothing
        Me.cmb_Autoriza.DisplayMember = "Nombre"
        Me.cmb_Autoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Autoriza.Empresa = False
        Me.cmb_Autoriza.Filtro = Me.tbx_Clave
        Me.cmb_Autoriza.FormattingEnabled = True
        Me.cmb_Autoriza.Location = New System.Drawing.Point(83, 116)
        Me.cmb_Autoriza.MaxDropDownItems = 20
        Me.cmb_Autoriza.Name = "cmb_Autoriza"
        Me.cmb_Autoriza.Pista = True
        Me.cmb_Autoriza.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Autoriza.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Autoriza.Sucursal = True
        Me.cmb_Autoriza.TabIndex = 22
        Me.cmb_Autoriza.Tipo = 0
        Me.cmb_Autoriza.ValueMember = "Id_Empleado"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Clave.Control_Siguiente = Nothing
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(75, 112)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 21
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'frm_CartaAcceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 603)
        Me.Controls.Add(Me.Gbx_Datos2)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CartaAcceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carta de Acceso a Áreas Seguras"
        Me.Gbx_Datos.ResumeLayout(False)
        Me.Gbx_Datos.PerformLayout()
        Me.gbx_Tipo.ResumeLayout(False)
        Me.gbx_Tipo.PerformLayout()
        Me.Gbx_TipoCarta.ResumeLayout(False)
        Me.Gbx_TipoCarta.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Datos2.ResumeLayout(False)
        Me.Gbx_Datos2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Nombre As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lsv_PersonasAutorizadas As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Autoriza As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents tbx_Empresa As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Asunto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Asunto As System.Windows.Forms.Label
    Friend WithEvents lbl_Instrucciones As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaExpira As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaExpira As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents rdb_Visitante As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Empleado As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoCarta As System.Windows.Forms.Label
    Friend WithEvents Gbx_TipoCarta As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Otro As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_NuevoIngreso As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Falta As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Autoriza As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveEmpleado As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_DirigidoA As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveDirigida As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Dirigida As System.Windows.Forms.Label
    Friend WithEvents rdb_Externo As System.Windows.Forms.RadioButton
    Friend WithEvents Gbx_Datos2 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Empleado1 As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
End Class
