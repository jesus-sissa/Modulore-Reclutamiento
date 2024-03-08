<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CredencialesExpedir
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
        Me.lbl_Nombre_Baja = New System.Windows.Forms.Label
        Me.lbl_APaterno = New System.Windows.Forms.Label
        Me.lbl_Nombres = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.dtp_FechaExpedicion = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaExpedicion = New System.Windows.Forms.Label
        Me.dtp_FechaVencimiento = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaVencimiento = New System.Windows.Forms.Label
        Me.Lbl_FechaRegistro = New System.Windows.Forms.Label
        Me.Lbl_FechaIngreso = New System.Windows.Forms.Label
        Me.lbl_EntregoAnterior = New System.Windows.Forms.Label
        Me.Gbx_Entrega = New System.Windows.Forms.GroupBox
        Me.rdb_No_EntregoAnterior = New System.Windows.Forms.RadioButton
        Me.rdb_Si_EntregoAnterior = New System.Windows.Forms.RadioButton
        Me.lbl_Comentarios = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Imagenes = New System.Windows.Forms.GroupBox
        Me.pct_Codigo = New System.Windows.Forms.PictureBox
        Me.ptb_Foto = New System.Windows.Forms.PictureBox
        Me.Gbx_Empleado = New System.Windows.Forms.GroupBox
        Me.rdb_Externo = New System.Windows.Forms.RadioButton
        Me.rdb_Interno = New System.Windows.Forms.RadioButton
        Me.tbx_FechaExpideActual = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_FechaExpAct = New System.Windows.Forms.Label
        Me.tbx_FechaVenceActual = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_FechaVenceActual = New System.Windows.Forms.Label
        Me.tbx_Puesto = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.cmb_Empleado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Apellidos = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_FechaIngreso = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Departamento = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_FechaRegistro = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_UsuarioAutoriza = New System.Windows.Forms.Label
        Me.lbl_MotivoExpedicion = New System.Windows.Forms.Label
        Me.Gbx_Credencial = New System.Windows.Forms.GroupBox
        Me.cmb_MotivoExpedicion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_UsuarioAutoriza = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveAutoriza = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Comentarios = New Modulo_Reclutamiento.cp_Textbox
        Me.Gbx_Entrega.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Imagenes.SuspendLayout()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Empleado.SuspendLayout()
        Me.Gbx_Credencial.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre_Baja
        '
        Me.lbl_Nombre_Baja.AutoSize = True
        Me.lbl_Nombre_Baja.Location = New System.Drawing.Point(86, 52)
        Me.lbl_Nombre_Baja.Name = "lbl_Nombre_Baja"
        Me.lbl_Nombre_Baja.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Nombre_Baja.TabIndex = 0
        Me.lbl_Nombre_Baja.Text = "Empleado"
        Me.lbl_Nombre_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APaterno
        '
        Me.lbl_APaterno.AutoSize = True
        Me.lbl_APaterno.Location = New System.Drawing.Point(6, 106)
        Me.lbl_APaterno.Name = "lbl_APaterno"
        Me.lbl_APaterno.Size = New System.Drawing.Size(134, 13)
        Me.lbl_APaterno.TabIndex = 6
        Me.lbl_APaterno.Text = "Apellido Paterno y Materno"
        Me.lbl_APaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(85, 79)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Nombres.TabIndex = 4
        Me.lbl_Nombres.Text = "Nombre(s)"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(66, 132)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 8
        Me.lbl_Departamento.Text = "Departamento"
        '
        'dtp_FechaExpedicion
        '
        Me.dtp_FechaExpedicion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpedicion.Location = New System.Drawing.Point(146, 80)
        Me.dtp_FechaExpedicion.Name = "dtp_FechaExpedicion"
        Me.dtp_FechaExpedicion.Size = New System.Drawing.Size(96, 20)
        Me.dtp_FechaExpedicion.TabIndex = 25
        Me.dtp_FechaExpedicion.Value = New Date(2010, 4, 12, 0, 0, 0, 0)
        '
        'lbl_FechaExpedicion
        '
        Me.lbl_FechaExpedicion.AutoSize = True
        Me.lbl_FechaExpedicion.Location = New System.Drawing.Point(48, 84)
        Me.lbl_FechaExpedicion.Name = "lbl_FechaExpedicion"
        Me.lbl_FechaExpedicion.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaExpedicion.TabIndex = 24
        Me.lbl_FechaExpedicion.Text = "Fecha Expedición"
        '
        'dtp_FechaVencimiento
        '
        Me.dtp_FechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVencimiento.Location = New System.Drawing.Point(352, 80)
        Me.dtp_FechaVencimiento.Name = "dtp_FechaVencimiento"
        Me.dtp_FechaVencimiento.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaVencimiento.TabIndex = 27
        Me.dtp_FechaVencimiento.Value = New Date(2010, 4, 12, 0, 0, 0, 0)
        '
        'lbl_FechaVencimiento
        '
        Me.lbl_FechaVencimiento.AutoSize = True
        Me.lbl_FechaVencimiento.Location = New System.Drawing.Point(248, 84)
        Me.lbl_FechaVencimiento.Name = "lbl_FechaVencimiento"
        Me.lbl_FechaVencimiento.Size = New System.Drawing.Size(98, 13)
        Me.lbl_FechaVencimiento.TabIndex = 26
        Me.lbl_FechaVencimiento.Text = "Fecha Vencimiento"
        '
        'Lbl_FechaRegistro
        '
        Me.Lbl_FechaRegistro.AutoSize = True
        Me.Lbl_FechaRegistro.Location = New System.Drawing.Point(61, 184)
        Me.Lbl_FechaRegistro.Name = "Lbl_FechaRegistro"
        Me.Lbl_FechaRegistro.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_FechaRegistro.TabIndex = 12
        Me.Lbl_FechaRegistro.Text = "Fecha Registro"
        '
        'Lbl_FechaIngreso
        '
        Me.Lbl_FechaIngreso.AutoSize = True
        Me.Lbl_FechaIngreso.Location = New System.Drawing.Point(323, 184)
        Me.Lbl_FechaIngreso.Name = "Lbl_FechaIngreso"
        Me.Lbl_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_FechaIngreso.TabIndex = 14
        Me.Lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lbl_EntregoAnterior
        '
        Me.lbl_EntregoAnterior.AutoSize = True
        Me.lbl_EntregoAnterior.Location = New System.Drawing.Point(57, 25)
        Me.lbl_EntregoAnterior.Name = "lbl_EntregoAnterior"
        Me.lbl_EntregoAnterior.Size = New System.Drawing.Size(83, 13)
        Me.lbl_EntregoAnterior.TabIndex = 16
        Me.lbl_EntregoAnterior.Text = "Entregó Anterior"
        '
        'Gbx_Entrega
        '
        Me.Gbx_Entrega.Controls.Add(Me.rdb_No_EntregoAnterior)
        Me.Gbx_Entrega.Controls.Add(Me.rdb_Si_EntregoAnterior)
        Me.Gbx_Entrega.Location = New System.Drawing.Point(146, 10)
        Me.Gbx_Entrega.Name = "Gbx_Entrega"
        Me.Gbx_Entrega.Size = New System.Drawing.Size(110, 37)
        Me.Gbx_Entrega.TabIndex = 17
        Me.Gbx_Entrega.TabStop = False
        '
        'rdb_No_EntregoAnterior
        '
        Me.rdb_No_EntregoAnterior.AutoSize = True
        Me.rdb_No_EntregoAnterior.Location = New System.Drawing.Point(59, 13)
        Me.rdb_No_EntregoAnterior.Name = "rdb_No_EntregoAnterior"
        Me.rdb_No_EntregoAnterior.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_EntregoAnterior.TabIndex = 1
        Me.rdb_No_EntregoAnterior.Text = "No"
        Me.rdb_No_EntregoAnterior.UseVisualStyleBackColor = True
        '
        'rdb_Si_EntregoAnterior
        '
        Me.rdb_Si_EntregoAnterior.AutoSize = True
        Me.rdb_Si_EntregoAnterior.Checked = True
        Me.rdb_Si_EntregoAnterior.Location = New System.Drawing.Point(6, 13)
        Me.rdb_Si_EntregoAnterior.Name = "rdb_Si_EntregoAnterior"
        Me.rdb_Si_EntregoAnterior.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_EntregoAnterior.TabIndex = 0
        Me.rdb_Si_EntregoAnterior.TabStop = True
        Me.rdb_Si_EntregoAnterior.Text = "Si"
        Me.rdb_Si_EntregoAnterior.UseVisualStyleBackColor = True
        '
        'lbl_Comentarios
        '
        Me.lbl_Comentarios.AutoSize = True
        Me.lbl_Comentarios.Location = New System.Drawing.Point(75, 109)
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Comentarios.TabIndex = 28
        Me.lbl_Comentarios.Text = "Comentarios"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 545)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(785, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
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
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(639, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Imagenes
        '
        Me.gbx_Imagenes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Imagenes.Controls.Add(Me.pct_Codigo)
        Me.gbx_Imagenes.Controls.Add(Me.ptb_Foto)
        Me.gbx_Imagenes.Location = New System.Drawing.Point(5, 5)
        Me.gbx_Imagenes.Name = "gbx_Imagenes"
        Me.gbx_Imagenes.Size = New System.Drawing.Size(250, 534)
        Me.gbx_Imagenes.TabIndex = 2
        Me.gbx_Imagenes.TabStop = False
        '
        'pct_Codigo
        '
        Me.pct_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Codigo.Location = New System.Drawing.Point(6, 276)
        Me.pct_Codigo.Name = "pct_Codigo"
        Me.pct_Codigo.Size = New System.Drawing.Size(238, 69)
        Me.pct_Codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Codigo.TabIndex = 37
        Me.pct_Codigo.TabStop = False
        '
        'ptb_Foto
        '
        Me.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Foto.Location = New System.Drawing.Point(6, 49)
        Me.ptb_Foto.Name = "ptb_Foto"
        Me.ptb_Foto.Size = New System.Drawing.Size(238, 220)
        Me.ptb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_Foto.TabIndex = 35
        Me.ptb_Foto.TabStop = False
        '
        'Gbx_Empleado
        '
        Me.Gbx_Empleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Empleado.Controls.Add(Me.rdb_Externo)
        Me.Gbx_Empleado.Controls.Add(Me.rdb_Interno)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_FechaExpideActual)
        Me.Gbx_Empleado.Controls.Add(Me.Lbl_FechaExpAct)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_FechaVenceActual)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_FechaVenceActual)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_Puesto)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_Puesto)
        Me.Gbx_Empleado.Controls.Add(Me.cmb_Empleado)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_Nombre_Baja)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_Nombres)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_Apellidos)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_APaterno)
        Me.Gbx_Empleado.Controls.Add(Me.lbl_Departamento)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_FechaIngreso)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_Departamento)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_FechaRegistro)
        Me.Gbx_Empleado.Controls.Add(Me.Lbl_FechaIngreso)
        Me.Gbx_Empleado.Controls.Add(Me.Lbl_FechaRegistro)
        Me.Gbx_Empleado.Controls.Add(Me.tbx_Nombres)
        Me.Gbx_Empleado.Location = New System.Drawing.Point(261, 5)
        Me.Gbx_Empleado.Name = "Gbx_Empleado"
        Me.Gbx_Empleado.Size = New System.Drawing.Size(529, 269)
        Me.Gbx_Empleado.TabIndex = 0
        Me.Gbx_Empleado.TabStop = False
        Me.Gbx_Empleado.Text = "Empleado"
        '
        'rdb_Externo
        '
        Me.rdb_Externo.AutoSize = True
        Me.rdb_Externo.Location = New System.Drawing.Point(326, 26)
        Me.rdb_Externo.Name = "rdb_Externo"
        Me.rdb_Externo.Size = New System.Drawing.Size(61, 17)
        Me.rdb_Externo.TabIndex = 26
        Me.rdb_Externo.TabStop = True
        Me.rdb_Externo.Text = "Externo"
        Me.rdb_Externo.UseVisualStyleBackColor = True
        '
        'rdb_Interno
        '
        Me.rdb_Interno.AutoSize = True
        Me.rdb_Interno.Location = New System.Drawing.Point(245, 25)
        Me.rdb_Interno.Name = "rdb_Interno"
        Me.rdb_Interno.Size = New System.Drawing.Size(58, 17)
        Me.rdb_Interno.TabIndex = 26
        Me.rdb_Interno.TabStop = True
        Me.rdb_Interno.Text = "Interno"
        Me.rdb_Interno.UseVisualStyleBackColor = True
        '
        'tbx_FechaExpideActual
        '
        Me.tbx_FechaExpideActual.Control_Siguiente = Nothing
        Me.tbx_FechaExpideActual.Filtrado = True
        Me.tbx_FechaExpideActual.Location = New System.Drawing.Point(146, 207)
        Me.tbx_FechaExpideActual.MaxLength = 10
        Me.tbx_FechaExpideActual.Name = "tbx_FechaExpideActual"
        Me.tbx_FechaExpideActual.ReadOnly = True
        Me.tbx_FechaExpideActual.Size = New System.Drawing.Size(110, 20)
        Me.tbx_FechaExpideActual.TabIndex = 25
        Me.tbx_FechaExpideActual.TabStop = False
        Me.tbx_FechaExpideActual.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_FechaExpAct
        '
        Me.Lbl_FechaExpAct.AutoSize = True
        Me.Lbl_FechaExpAct.Location = New System.Drawing.Point(15, 210)
        Me.Lbl_FechaExpAct.Name = "Lbl_FechaExpAct"
        Me.Lbl_FechaExpAct.Size = New System.Drawing.Size(125, 13)
        Me.Lbl_FechaExpAct.TabIndex = 24
        Me.Lbl_FechaExpAct.Text = "Fecha Expedición Actual"
        '
        'tbx_FechaVenceActual
        '
        Me.tbx_FechaVenceActual.Control_Siguiente = Nothing
        Me.tbx_FechaVenceActual.Filtrado = True
        Me.tbx_FechaVenceActual.Location = New System.Drawing.Point(146, 233)
        Me.tbx_FechaVenceActual.MaxLength = 10
        Me.tbx_FechaVenceActual.Name = "tbx_FechaVenceActual"
        Me.tbx_FechaVenceActual.ReadOnly = True
        Me.tbx_FechaVenceActual.Size = New System.Drawing.Size(110, 20)
        Me.tbx_FechaVenceActual.TabIndex = 23
        Me.tbx_FechaVenceActual.TabStop = False
        Me.tbx_FechaVenceActual.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FechaVenceActual
        '
        Me.lbl_FechaVenceActual.AutoSize = True
        Me.lbl_FechaVenceActual.Location = New System.Drawing.Point(9, 236)
        Me.lbl_FechaVenceActual.Name = "lbl_FechaVenceActual"
        Me.lbl_FechaVenceActual.Size = New System.Drawing.Size(131, 13)
        Me.lbl_FechaVenceActual.TabIndex = 22
        Me.lbl_FechaVenceActual.Text = "Fecha Vencimiento Actual"
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.Control_Siguiente = Nothing
        Me.tbx_Puesto.Filtrado = True
        Me.tbx_Puesto.Location = New System.Drawing.Point(146, 155)
        Me.tbx_Puesto.MaxLength = 30
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.ReadOnly = True
        Me.tbx_Puesto.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Puesto.TabIndex = 11
        Me.tbx_Puesto.TabStop = False
        Me.tbx_Puesto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(100, 158)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 10
        Me.lbl_Puesto.Text = "Puesto"
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave_Empleado"
        Me.cmb_Empleado.Control_Siguiente = Nothing
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_Clave
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(146, 49)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = False
        Me.cmb_Empleado.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 2
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.cmb_Empleado
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(146, 43)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'tbx_Apellidos
        '
        Me.tbx_Apellidos.Control_Siguiente = Nothing
        Me.tbx_Apellidos.Filtrado = True
        Me.tbx_Apellidos.Location = New System.Drawing.Point(146, 103)
        Me.tbx_Apellidos.MaxLength = 30
        Me.tbx_Apellidos.Name = "tbx_Apellidos"
        Me.tbx_Apellidos.ReadOnly = True
        Me.tbx_Apellidos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Apellidos.TabIndex = 7
        Me.tbx_Apellidos.TabStop = False
        Me.tbx_Apellidos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_FechaIngreso
        '
        Me.tbx_FechaIngreso.Control_Siguiente = Nothing
        Me.tbx_FechaIngreso.Filtrado = True
        Me.tbx_FechaIngreso.Location = New System.Drawing.Point(404, 181)
        Me.tbx_FechaIngreso.MaxLength = 10
        Me.tbx_FechaIngreso.Name = "tbx_FechaIngreso"
        Me.tbx_FechaIngreso.ReadOnly = True
        Me.tbx_FechaIngreso.Size = New System.Drawing.Size(92, 20)
        Me.tbx_FechaIngreso.TabIndex = 15
        Me.tbx_FechaIngreso.TabStop = False
        Me.tbx_FechaIngreso.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Departamento
        '
        Me.tbx_Departamento.Control_Siguiente = Nothing
        Me.tbx_Departamento.Filtrado = True
        Me.tbx_Departamento.Location = New System.Drawing.Point(146, 129)
        Me.tbx_Departamento.MaxLength = 30
        Me.tbx_Departamento.Name = "tbx_Departamento"
        Me.tbx_Departamento.ReadOnly = True
        Me.tbx_Departamento.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Departamento.TabIndex = 9
        Me.tbx_Departamento.TabStop = False
        Me.tbx_Departamento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_FechaRegistro
        '
        Me.tbx_FechaRegistro.Control_Siguiente = Nothing
        Me.tbx_FechaRegistro.Filtrado = True
        Me.tbx_FechaRegistro.Location = New System.Drawing.Point(146, 181)
        Me.tbx_FechaRegistro.MaxLength = 10
        Me.tbx_FechaRegistro.Name = "tbx_FechaRegistro"
        Me.tbx_FechaRegistro.ReadOnly = True
        Me.tbx_FechaRegistro.Size = New System.Drawing.Size(92, 20)
        Me.tbx_FechaRegistro.TabIndex = 13
        Me.tbx_FechaRegistro.TabStop = False
        Me.tbx_FechaRegistro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.Control_Siguiente = Nothing
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Location = New System.Drawing.Point(146, 76)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.ReadOnly = True
        Me.tbx_Nombres.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Nombres.TabIndex = 5
        Me.tbx_Nombres.TabStop = False
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_UsuarioAutoriza
        '
        Me.lbl_UsuarioAutoriza.AutoSize = True
        Me.lbl_UsuarioAutoriza.Location = New System.Drawing.Point(56, 156)
        Me.lbl_UsuarioAutoriza.Name = "lbl_UsuarioAutoriza"
        Me.lbl_UsuarioAutoriza.Size = New System.Drawing.Size(84, 13)
        Me.lbl_UsuarioAutoriza.TabIndex = 30
        Me.lbl_UsuarioAutoriza.Text = "Usuario Autoriza"
        '
        'lbl_MotivoExpedicion
        '
        Me.lbl_MotivoExpedicion.AutoSize = True
        Me.lbl_MotivoExpedicion.Location = New System.Drawing.Point(31, 56)
        Me.lbl_MotivoExpedicion.Name = "lbl_MotivoExpedicion"
        Me.lbl_MotivoExpedicion.Size = New System.Drawing.Size(109, 13)
        Me.lbl_MotivoExpedicion.TabIndex = 20
        Me.lbl_MotivoExpedicion.Text = "Motivo de Expedición"
        '
        'Gbx_Credencial
        '
        Me.Gbx_Credencial.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_MotivoExpedicion)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_UsuarioAutoriza)
        Me.Gbx_Credencial.Controls.Add(Me.cmb_MotivoExpedicion)
        Me.Gbx_Credencial.Controls.Add(Me.cmb_UsuarioAutoriza)
        Me.Gbx_Credencial.Controls.Add(Me.tbx_ClaveAutoriza)
        Me.Gbx_Credencial.Controls.Add(Me.dtp_FechaExpedicion)
        Me.Gbx_Credencial.Controls.Add(Me.dtp_FechaVencimiento)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_FechaVencimiento)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_FechaExpedicion)
        Me.Gbx_Credencial.Controls.Add(Me.tbx_Comentarios)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_Comentarios)
        Me.Gbx_Credencial.Controls.Add(Me.lbl_EntregoAnterior)
        Me.Gbx_Credencial.Controls.Add(Me.Gbx_Entrega)
        Me.Gbx_Credencial.Location = New System.Drawing.Point(261, 281)
        Me.Gbx_Credencial.Name = "Gbx_Credencial"
        Me.Gbx_Credencial.Size = New System.Drawing.Size(528, 258)
        Me.Gbx_Credencial.TabIndex = 3
        Me.Gbx_Credencial.TabStop = False
        Me.Gbx_Credencial.Text = "Credencial Nueva"
        '
        'cmb_MotivoExpedicion
        '
        Me.cmb_MotivoExpedicion.Clave = Nothing
        Me.cmb_MotivoExpedicion.Control_Siguiente = Me.dtp_FechaExpedicion
        Me.cmb_MotivoExpedicion.DisplayMember = "Descripcion"
        Me.cmb_MotivoExpedicion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MotivoExpedicion.Empresa = False
        Me.cmb_MotivoExpedicion.Filtro = Nothing
        Me.cmb_MotivoExpedicion.FormattingEnabled = True
        Me.cmb_MotivoExpedicion.Location = New System.Drawing.Point(146, 53)
        Me.cmb_MotivoExpedicion.MaxDropDownItems = 20
        Me.cmb_MotivoExpedicion.Name = "cmb_MotivoExpedicion"
        Me.cmb_MotivoExpedicion.Pista = False
        Me.cmb_MotivoExpedicion.Size = New System.Drawing.Size(350, 21)
        Me.cmb_MotivoExpedicion.StoredProcedure = "Cat_MotivosExpedicionCCombo_Get"
        Me.cmb_MotivoExpedicion.Sucursal = False
        Me.cmb_MotivoExpedicion.TabIndex = 21
        Me.cmb_MotivoExpedicion.Tipo = 0
        Me.cmb_MotivoExpedicion.ValueMember = "Id_MotivoE"
        '
        'cmb_UsuarioAutoriza
        '
        Me.cmb_UsuarioAutoriza.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.cmb_UsuarioAutoriza.Clave = "Clave_Empleado"
        Me.cmb_UsuarioAutoriza.Control_Siguiente = Me.btn_Guardar
        Me.cmb_UsuarioAutoriza.DisplayMember = "Nombre"
        Me.cmb_UsuarioAutoriza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cmb_UsuarioAutoriza.Empresa = False
        Me.cmb_UsuarioAutoriza.Filtro = Me.tbx_ClaveAutoriza
        Me.cmb_UsuarioAutoriza.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_UsuarioAutoriza.FormattingEnabled = True
        Me.cmb_UsuarioAutoriza.Location = New System.Drawing.Point(146, 153)
        Me.cmb_UsuarioAutoriza.MaxDropDownItems = 20
        Me.cmb_UsuarioAutoriza.Name = "cmb_UsuarioAutoriza"
        Me.cmb_UsuarioAutoriza.Pista = True
        Me.cmb_UsuarioAutoriza.Size = New System.Drawing.Size(350, 103)
        Me.cmb_UsuarioAutoriza.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioAutoriza.Sucursal = True
        Me.cmb_UsuarioAutoriza.TabIndex = 32
        Me.cmb_UsuarioAutoriza.Tipo = 0
        Me.cmb_UsuarioAutoriza.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveAutoriza
        '
        Me.tbx_ClaveAutoriza.Control_Siguiente = Me.cmb_UsuarioAutoriza
        Me.tbx_ClaveAutoriza.Filtrado = True
        Me.tbx_ClaveAutoriza.Location = New System.Drawing.Point(100, 168)
        Me.tbx_ClaveAutoriza.MaxLength = 12
        Me.tbx_ClaveAutoriza.Name = "tbx_ClaveAutoriza"
        Me.tbx_ClaveAutoriza.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveAutoriza.TabIndex = 31
        Me.tbx_ClaveAutoriza.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveAutoriza.Visible = False
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Control_Siguiente = Me.cmb_UsuarioAutoriza
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(146, 106)
        Me.tbx_Comentarios.MaxLength = 150
        Me.tbx_Comentarios.Multiline = True
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(350, 40)
        Me.tbx_Comentarios.TabIndex = 29
        Me.tbx_Comentarios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'frm_Credenciales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(794, 608)
        Me.Controls.Add(Me.Gbx_Credencial)
        Me.Controls.Add(Me.Gbx_Empleado)
        Me.Controls.Add(Me.gbx_Imagenes)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Credenciales"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Expedición de Credenciales"
        Me.Gbx_Entrega.ResumeLayout(False)
        Me.Gbx_Entrega.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Imagenes.ResumeLayout(False)
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Empleado.ResumeLayout(False)
        Me.Gbx_Empleado.PerformLayout()
        Me.Gbx_Credencial.ResumeLayout(False)
        Me.Gbx_Credencial.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ptb_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Empleado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Nombre_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_APaterno As System.Windows.Forms.Label
    Friend WithEvents tbx_Apellidos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents tbx_Departamento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents dtp_FechaExpedicion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaExpedicion As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaVencimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Nombres As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_FechaRegistro As System.Windows.Forms.Label
    Friend WithEvents Lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaRegistro As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_FechaIngreso As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntregoAnterior As System.Windows.Forms.Label
    Friend WithEvents Gbx_Entrega As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_EntregoAnterior As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_EntregoAnterior As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Comentarios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Comentarios As System.Windows.Forms.Label
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Imagenes As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Empleado As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Puesto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaVenceActual As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_FechaVenceActual As System.Windows.Forms.Label
    Friend WithEvents lbl_MotivoExpedicion As System.Windows.Forms.Label
    Friend WithEvents cmb_MotivoExpedicion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents pct_Codigo As System.Windows.Forms.PictureBox
    Friend WithEvents cmb_UsuarioAutoriza As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ClaveAutoriza As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_UsuarioAutoriza As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaExpideActual As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_FechaExpAct As System.Windows.Forms.Label
    Friend WithEvents Gbx_Credencial As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Externo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Interno As System.Windows.Forms.RadioButton
End Class
