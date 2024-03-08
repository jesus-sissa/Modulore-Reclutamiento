<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosBaja
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
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaBaja = New System.Windows.Forms.Label
        Me.lbl_FechaIngreso = New System.Windows.Forms.Label
        Me.rdb_No_CatFirmas = New System.Windows.Forms.RadioButton
        Me.rdb_Si_CatFirmas = New System.Windows.Forms.RadioButton
        Me.btn_Cancelar_DG = New System.Windows.Forms.Button
        Me.btn_Guardar_DG = New System.Windows.Forms.Button
        Me.lbl_Nombres = New System.Windows.Forms.Label
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.lbl_EstadoCivil = New System.Windows.Forms.Label
        Me.lbl_Nombre_Baja = New System.Windows.Forms.Label
        Me.lbl_Departamento_Baja = New System.Windows.Forms.Label
        Me.lbl_Puesto_Baja = New System.Windows.Forms.Label
        Me.lbl_FechaFinLabores_Baja = New System.Windows.Forms.Label
        Me.lbl_FechaIngreso_Baja = New System.Windows.Forms.Label
        Me.dtp_FechaFinLabores_Baja = New System.Windows.Forms.DateTimePicker
        Me.btn_Baja = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_MotivoBaja = New System.Windows.Forms.Label
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.lbl_AsteriscoLN = New System.Windows.Forms.Label
        Me.lbl_AsteriscoAgregarLN = New System.Windows.Forms.Label
        Me.lbl_AsteriscoFecha = New System.Windows.Forms.Label
        Me.lbl_Motivo = New System.Windows.Forms.Label
        Me.rtb_Motivo = New System.Windows.Forms.RichTextBox
        Me.gbx_ListaNegra = New System.Windows.Forms.GroupBox
        Me.rdb_ListaNegraSi = New System.Windows.Forms.RadioButton
        Me.rdb_ListaNegraNo = New System.Windows.Forms.RadioButton
        Me.lbl_AsteriscoMotivo = New System.Windows.Forms.Label
        Me.cmb_MotivoBaja = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_FechaIngreso_Baja = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Puesto_Baja = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Departamento_Baja = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Nombre_Baja = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave_Baja = New Modulo_Reclutamiento.cp_Textbox
        Me.gbx_Foto = New System.Windows.Forms.GroupBox
        Me.pct_Codigo = New System.Windows.Forms.PictureBox
        Me.ptb_Foto = New System.Windows.Forms.PictureBox
        Me.tbx_NombreCompleto = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Departamento_DG = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Fecha_FinLabores = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_ListaNegra.SuspendLayout()
        Me.gbx_Foto.SuspendLayout()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(622, 341)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaIngreso.TabIndex = 92
        Me.dtp_FechaIngreso.Value = New Date(2010, 3, 29, 0, 0, 0, 0)
        '
        'lbl_FechaBaja
        '
        Me.lbl_FechaBaja.AutoSize = True
        Me.lbl_FechaBaja.Location = New System.Drawing.Point(555, 370)
        Me.lbl_FechaBaja.Name = "lbl_FechaBaja"
        Me.lbl_FechaBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FechaBaja.TabIndex = 93
        Me.lbl_FechaBaja.Text = "Fecha Baja"
        '
        'lbl_FechaIngreso
        '
        Me.lbl_FechaIngreso.AutoSize = True
        Me.lbl_FechaIngreso.Location = New System.Drawing.Point(541, 345)
        Me.lbl_FechaIngreso.Name = "lbl_FechaIngreso"
        Me.lbl_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FechaIngreso.TabIndex = 91
        Me.lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'rdb_No_CatFirmas
        '
        Me.rdb_No_CatFirmas.AutoSize = True
        Me.rdb_No_CatFirmas.Checked = True
        Me.rdb_No_CatFirmas.Location = New System.Drawing.Point(59, 11)
        Me.rdb_No_CatFirmas.Name = "rdb_No_CatFirmas"
        Me.rdb_No_CatFirmas.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_CatFirmas.TabIndex = 1
        Me.rdb_No_CatFirmas.TabStop = True
        Me.rdb_No_CatFirmas.Text = "No"
        Me.rdb_No_CatFirmas.UseVisualStyleBackColor = True
        '
        'rdb_Si_CatFirmas
        '
        Me.rdb_Si_CatFirmas.AutoSize = True
        Me.rdb_Si_CatFirmas.Location = New System.Drawing.Point(6, 11)
        Me.rdb_Si_CatFirmas.Name = "rdb_Si_CatFirmas"
        Me.rdb_Si_CatFirmas.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CatFirmas.TabIndex = 0
        Me.rdb_Si_CatFirmas.Text = "Si"
        Me.rdb_Si_CatFirmas.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_DG
        '
        Me.btn_Cancelar_DG.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DG.Location = New System.Drawing.Point(707, 566)
        Me.btn_Cancelar_DG.Name = "btn_Cancelar_DG"
        Me.btn_Cancelar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DG.TabIndex = 96
        Me.btn_Cancelar_DG.Text = "&Cancelar"
        Me.btn_Cancelar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DG.UseVisualStyleBackColor = True
        '
        'btn_Guardar_DG
        '
        Me.btn_Guardar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_DG.Location = New System.Drawing.Point(561, 566)
        Me.btn_Guardar_DG.Name = "btn_Guardar_DG"
        Me.btn_Guardar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DG.TabIndex = 95
        Me.btn_Guardar_DG.Text = "&Guardar"
        Me.btn_Guardar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_DG.UseVisualStyleBackColor = True
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(49, 75)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Nombres.TabIndex = 5
        Me.lbl_Nombres.Text = "Nombre(s)"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(70, 23)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(30, 152)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 13
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(64, 179)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 16
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_EstadoCivil
        '
        Me.lbl_EstadoCivil.AutoSize = True
        Me.lbl_EstadoCivil.Location = New System.Drawing.Point(42, 471)
        Me.lbl_EstadoCivil.Name = "lbl_EstadoCivil"
        Me.lbl_EstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lbl_EstadoCivil.TabIndex = 50
        Me.lbl_EstadoCivil.Text = "Estado Civil"
        '
        'lbl_Nombre_Baja
        '
        Me.lbl_Nombre_Baja.AutoSize = True
        Me.lbl_Nombre_Baja.Location = New System.Drawing.Point(53, 19)
        Me.lbl_Nombre_Baja.Name = "lbl_Nombre_Baja"
        Me.lbl_Nombre_Baja.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Nombre_Baja.TabIndex = 0
        Me.lbl_Nombre_Baja.Text = "Empleado"
        Me.lbl_Nombre_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Departamento_Baja
        '
        Me.lbl_Departamento_Baja.AutoSize = True
        Me.lbl_Departamento_Baja.Location = New System.Drawing.Point(33, 46)
        Me.lbl_Departamento_Baja.Name = "lbl_Departamento_Baja"
        Me.lbl_Departamento_Baja.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento_Baja.TabIndex = 4
        Me.lbl_Departamento_Baja.Text = "Departamento"
        '
        'lbl_Puesto_Baja
        '
        Me.lbl_Puesto_Baja.AutoSize = True
        Me.lbl_Puesto_Baja.Location = New System.Drawing.Point(67, 73)
        Me.lbl_Puesto_Baja.Name = "lbl_Puesto_Baja"
        Me.lbl_Puesto_Baja.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto_Baja.TabIndex = 6
        Me.lbl_Puesto_Baja.Text = "Puesto"
        '
        'lbl_FechaFinLabores_Baja
        '
        Me.lbl_FechaFinLabores_Baja.AutoSize = True
        Me.lbl_FechaFinLabores_Baja.Location = New System.Drawing.Point(12, 125)
        Me.lbl_FechaFinLabores_Baja.Name = "lbl_FechaFinLabores_Baja"
        Me.lbl_FechaFinLabores_Baja.Size = New System.Drawing.Size(95, 13)
        Me.lbl_FechaFinLabores_Baja.TabIndex = 10
        Me.lbl_FechaFinLabores_Baja.Text = "Fecha Fin Labores"
        '
        'lbl_FechaIngreso_Baja
        '
        Me.lbl_FechaIngreso_Baja.AutoSize = True
        Me.lbl_FechaIngreso_Baja.Location = New System.Drawing.Point(32, 98)
        Me.lbl_FechaIngreso_Baja.Name = "lbl_FechaIngreso_Baja"
        Me.lbl_FechaIngreso_Baja.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FechaIngreso_Baja.TabIndex = 8
        Me.lbl_FechaIngreso_Baja.Text = "Fecha Ingreso"
        '
        'dtp_FechaFinLabores_Baja
        '
        Me.dtp_FechaFinLabores_Baja.Enabled = False
        Me.dtp_FechaFinLabores_Baja.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaFinLabores_Baja.Location = New System.Drawing.Point(113, 121)
        Me.dtp_FechaFinLabores_Baja.Name = "dtp_FechaFinLabores_Baja"
        Me.dtp_FechaFinLabores_Baja.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaFinLabores_Baja.TabIndex = 11
        Me.dtp_FechaFinLabores_Baja.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'btn_Baja
        '
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Baja.Location = New System.Drawing.Point(111, 437)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 23
        Me.btn_Baja.Text = "&Baja"
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(257, 437)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 24
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(29, 177)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 16
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(437, 40)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        Me.btn_Buscar.Visible = False
        '
        'lbl_MotivoBaja
        '
        Me.lbl_MotivoBaja.AutoSize = True
        Me.lbl_MotivoBaja.Location = New System.Drawing.Point(44, 150)
        Me.lbl_MotivoBaja.Name = "lbl_MotivoBaja"
        Me.lbl_MotivoBaja.Size = New System.Drawing.Size(63, 13)
        Me.lbl_MotivoBaja.TabIndex = 13
        Me.lbl_MotivoBaja.Text = "Motivo Baja"
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Location = New System.Drawing.Point(113, 174)
        Me.rtb_Observaciones.MaxLength = 500
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(399, 143)
        Me.rtb_Observaciones.TabIndex = 17
        Me.rtb_Observaciones.Text = ""
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.lbl_AsteriscoLN)
        Me.gbx_Datos.Controls.Add(Me.lbl_AsteriscoAgregarLN)
        Me.gbx_Datos.Controls.Add(Me.lbl_AsteriscoFecha)
        Me.gbx_Datos.Controls.Add(Me.lbl_Motivo)
        Me.gbx_Datos.Controls.Add(Me.rtb_Motivo)
        Me.gbx_Datos.Controls.Add(Me.gbx_ListaNegra)
        Me.gbx_Datos.Controls.Add(Me.lbl_AsteriscoMotivo)
        Me.gbx_Datos.Controls.Add(Me.rtb_Observaciones)
        Me.gbx_Datos.Controls.Add(Me.lbl_Puesto_Baja)
        Me.gbx_Datos.Controls.Add(Me.cmb_MotivoBaja)
        Me.gbx_Datos.Controls.Add(Me.lbl_Departamento_Baja)
        Me.gbx_Datos.Controls.Add(Me.lbl_MotivoBaja)
        Me.gbx_Datos.Controls.Add(Me.lbl_Nombre_Baja)
        Me.gbx_Datos.Controls.Add(Me.btn_Buscar)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaIngreso_Baja)
        Me.gbx_Datos.Controls.Add(Me.lbl_FechaFinLabores_Baja)
        Me.gbx_Datos.Controls.Add(Me.tbx_FechaIngreso_Baja)
        Me.gbx_Datos.Controls.Add(Me.btn_Baja)
        Me.gbx_Datos.Controls.Add(Me.tbx_Puesto_Baja)
        Me.gbx_Datos.Controls.Add(Me.dtp_FechaFinLabores_Baja)
        Me.gbx_Datos.Controls.Add(Me.tbx_Departamento_Baja)
        Me.gbx_Datos.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Datos.Controls.Add(Me.cmb_Nombre_Baja)
        Me.gbx_Datos.Controls.Add(Me.lbl_Observaciones)
        Me.gbx_Datos.Controls.Add(Me.tbx_Clave_Baja)
        Me.gbx_Datos.Location = New System.Drawing.Point(270, 6)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(518, 561)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'lbl_AsteriscoLN
        '
        Me.lbl_AsteriscoLN.AutoSize = True
        Me.lbl_AsteriscoLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AsteriscoLN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_AsteriscoLN.Location = New System.Drawing.Point(525, 369)
        Me.lbl_AsteriscoLN.Name = "lbl_AsteriscoLN"
        Me.lbl_AsteriscoLN.Size = New System.Drawing.Size(15, 20)
        Me.lbl_AsteriscoLN.TabIndex = 22
        Me.lbl_AsteriscoLN.Text = "*"
        Me.lbl_AsteriscoLN.Visible = False
        '
        'lbl_AsteriscoAgregarLN
        '
        Me.lbl_AsteriscoAgregarLN.AutoSize = True
        Me.lbl_AsteriscoAgregarLN.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AsteriscoAgregarLN.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_AsteriscoAgregarLN.Location = New System.Drawing.Point(307, 336)
        Me.lbl_AsteriscoAgregarLN.Name = "lbl_AsteriscoAgregarLN"
        Me.lbl_AsteriscoAgregarLN.Size = New System.Drawing.Size(15, 20)
        Me.lbl_AsteriscoAgregarLN.TabIndex = 19
        Me.lbl_AsteriscoAgregarLN.Text = "*"
        '
        'lbl_AsteriscoFecha
        '
        Me.lbl_AsteriscoFecha.AutoSize = True
        Me.lbl_AsteriscoFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AsteriscoFecha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_AsteriscoFecha.Location = New System.Drawing.Point(217, 120)
        Me.lbl_AsteriscoFecha.Name = "lbl_AsteriscoFecha"
        Me.lbl_AsteriscoFecha.Size = New System.Drawing.Size(15, 20)
        Me.lbl_AsteriscoFecha.TabIndex = 12
        Me.lbl_AsteriscoFecha.Text = "*"
        '
        'lbl_Motivo
        '
        Me.lbl_Motivo.AutoSize = True
        Me.lbl_Motivo.Enabled = False
        Me.lbl_Motivo.Location = New System.Drawing.Point(10, 371)
        Me.lbl_Motivo.Name = "lbl_Motivo"
        Me.lbl_Motivo.Size = New System.Drawing.Size(96, 13)
        Me.lbl_Motivo.TabIndex = 20
        Me.lbl_Motivo.Text = "Motivo Lista Negra"
        '
        'rtb_Motivo
        '
        Me.rtb_Motivo.Enabled = False
        Me.rtb_Motivo.Location = New System.Drawing.Point(112, 371)
        Me.rtb_Motivo.MaxLength = 250
        Me.rtb_Motivo.Name = "rtb_Motivo"
        Me.rtb_Motivo.Size = New System.Drawing.Size(400, 60)
        Me.rtb_Motivo.TabIndex = 21
        Me.rtb_Motivo.Text = ""
        '
        'gbx_ListaNegra
        '
        Me.gbx_ListaNegra.Controls.Add(Me.rdb_ListaNegraSi)
        Me.gbx_ListaNegra.Controls.Add(Me.rdb_ListaNegraNo)
        Me.gbx_ListaNegra.Location = New System.Drawing.Point(113, 323)
        Me.gbx_ListaNegra.Name = "gbx_ListaNegra"
        Me.gbx_ListaNegra.Size = New System.Drawing.Size(188, 42)
        Me.gbx_ListaNegra.TabIndex = 18
        Me.gbx_ListaNegra.TabStop = False
        Me.gbx_ListaNegra.Text = "Agregar a la Lista Negra?"
        '
        'rdb_ListaNegraSi
        '
        Me.rdb_ListaNegraSi.AutoSize = True
        Me.rdb_ListaNegraSi.Location = New System.Drawing.Point(50, 20)
        Me.rdb_ListaNegraSi.Name = "rdb_ListaNegraSi"
        Me.rdb_ListaNegraSi.Size = New System.Drawing.Size(34, 17)
        Me.rdb_ListaNegraSi.TabIndex = 0
        Me.rdb_ListaNegraSi.TabStop = True
        Me.rdb_ListaNegraSi.Text = "Si"
        Me.rdb_ListaNegraSi.UseVisualStyleBackColor = True
        '
        'rdb_ListaNegraNo
        '
        Me.rdb_ListaNegraNo.AutoSize = True
        Me.rdb_ListaNegraNo.Location = New System.Drawing.Point(113, 20)
        Me.rdb_ListaNegraNo.Name = "rdb_ListaNegraNo"
        Me.rdb_ListaNegraNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ListaNegraNo.TabIndex = 1
        Me.rdb_ListaNegraNo.TabStop = True
        Me.rdb_ListaNegraNo.Text = "No"
        Me.rdb_ListaNegraNo.UseVisualStyleBackColor = True
        '
        'lbl_AsteriscoMotivo
        '
        Me.lbl_AsteriscoMotivo.AutoSize = True
        Me.lbl_AsteriscoMotivo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_AsteriscoMotivo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbl_AsteriscoMotivo.Location = New System.Drawing.Point(348, 147)
        Me.lbl_AsteriscoMotivo.Name = "lbl_AsteriscoMotivo"
        Me.lbl_AsteriscoMotivo.Size = New System.Drawing.Size(15, 20)
        Me.lbl_AsteriscoMotivo.TabIndex = 15
        Me.lbl_AsteriscoMotivo.Text = "*"
        '
        'cmb_MotivoBaja
        '
        Me.cmb_MotivoBaja.Clave = Nothing
        Me.cmb_MotivoBaja.Control_Siguiente = Nothing
        Me.cmb_MotivoBaja.DisplayMember = "Descripcion"
        Me.cmb_MotivoBaja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MotivoBaja.Empresa = False
        Me.cmb_MotivoBaja.Enabled = False
        Me.cmb_MotivoBaja.Filtro = Nothing
        Me.cmb_MotivoBaja.FormattingEnabled = True
        Me.cmb_MotivoBaja.Location = New System.Drawing.Point(113, 147)
        Me.cmb_MotivoBaja.MaxDropDownItems = 20
        Me.cmb_MotivoBaja.Name = "cmb_MotivoBaja"
        Me.cmb_MotivoBaja.Pista = False
        Me.cmb_MotivoBaja.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MotivoBaja.StoredProcedure = "Cat_MotivosBajaCombo_Get"
        Me.cmb_MotivoBaja.Sucursal = False
        Me.cmb_MotivoBaja.TabIndex = 14
        Me.cmb_MotivoBaja.Tipo = 0
        Me.cmb_MotivoBaja.ValueMember = "id_MotivoB"
        '
        'tbx_FechaIngreso_Baja
        '
        Me.tbx_FechaIngreso_Baja.Control_Siguiente = Nothing
        Me.tbx_FechaIngreso_Baja.Filtrado = True
        Me.tbx_FechaIngreso_Baja.Location = New System.Drawing.Point(113, 95)
        Me.tbx_FechaIngreso_Baja.MaxLength = 50
        Me.tbx_FechaIngreso_Baja.Name = "tbx_FechaIngreso_Baja"
        Me.tbx_FechaIngreso_Baja.ReadOnly = True
        Me.tbx_FechaIngreso_Baja.Size = New System.Drawing.Size(110, 20)
        Me.tbx_FechaIngreso_Baja.TabIndex = 9
        Me.tbx_FechaIngreso_Baja.TabStop = False
        Me.tbx_FechaIngreso_Baja.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Puesto_Baja
        '
        Me.tbx_Puesto_Baja.Control_Siguiente = Nothing
        Me.tbx_Puesto_Baja.Filtrado = True
        Me.tbx_Puesto_Baja.Location = New System.Drawing.Point(113, 69)
        Me.tbx_Puesto_Baja.MaxLength = 50
        Me.tbx_Puesto_Baja.Name = "tbx_Puesto_Baja"
        Me.tbx_Puesto_Baja.ReadOnly = True
        Me.tbx_Puesto_Baja.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Puesto_Baja.TabIndex = 7
        Me.tbx_Puesto_Baja.TabStop = False
        Me.tbx_Puesto_Baja.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Departamento_Baja
        '
        Me.tbx_Departamento_Baja.Control_Siguiente = Nothing
        Me.tbx_Departamento_Baja.Filtrado = True
        Me.tbx_Departamento_Baja.Location = New System.Drawing.Point(113, 43)
        Me.tbx_Departamento_Baja.MaxLength = 50
        Me.tbx_Departamento_Baja.Name = "tbx_Departamento_Baja"
        Me.tbx_Departamento_Baja.ReadOnly = True
        Me.tbx_Departamento_Baja.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Departamento_Baja.TabIndex = 5
        Me.tbx_Departamento_Baja.TabStop = False
        Me.tbx_Departamento_Baja.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_Nombre_Baja
        '
        Me.cmb_Nombre_Baja.Clave = "Clave_Empleado"
        Me.cmb_Nombre_Baja.Control_Siguiente = Me.btn_Buscar
        Me.cmb_Nombre_Baja.DisplayMember = "Nombre"
        Me.cmb_Nombre_Baja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nombre_Baja.Empresa = False
        Me.cmb_Nombre_Baja.Filtro = Me.tbx_Clave_Baja
        Me.cmb_Nombre_Baja.FormattingEnabled = True
        Me.cmb_Nombre_Baja.Location = New System.Drawing.Point(113, 16)
        Me.cmb_Nombre_Baja.MaxDropDownItems = 20
        Me.cmb_Nombre_Baja.Name = "cmb_Nombre_Baja"
        Me.cmb_Nombre_Baja.Pista = False
        Me.cmb_Nombre_Baja.Size = New System.Drawing.Size(399, 21)
        Me.cmb_Nombre_Baja.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_Nombre_Baja.Sucursal = True
        Me.cmb_Nombre_Baja.TabIndex = 2
        Me.cmb_Nombre_Baja.Tipo = 0
        Me.cmb_Nombre_Baja.ValueMember = "Id_Empleado"
        '
        'tbx_Clave_Baja
        '
        Me.tbx_Clave_Baja.Control_Siguiente = Me.cmb_Nombre_Baja
        Me.tbx_Clave_Baja.Filtrado = True
        Me.tbx_Clave_Baja.Location = New System.Drawing.Point(113, 9)
        Me.tbx_Clave_Baja.MaxLength = 12
        Me.tbx_Clave_Baja.Name = "tbx_Clave_Baja"
        Me.tbx_Clave_Baja.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave_Baja.TabIndex = 1
        Me.tbx_Clave_Baja.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave_Baja.Visible = False
        '
        'gbx_Foto
        '
        Me.gbx_Foto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Foto.Controls.Add(Me.pct_Codigo)
        Me.gbx_Foto.Controls.Add(Me.ptb_Foto)
        Me.gbx_Foto.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Foto.Name = "gbx_Foto"
        Me.gbx_Foto.Size = New System.Drawing.Size(258, 561)
        Me.gbx_Foto.TabIndex = 0
        Me.gbx_Foto.TabStop = False
        '
        'pct_Codigo
        '
        Me.pct_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Codigo.Location = New System.Drawing.Point(6, 246)
        Me.pct_Codigo.Name = "pct_Codigo"
        Me.pct_Codigo.Size = New System.Drawing.Size(238, 54)
        Me.pct_Codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Codigo.TabIndex = 37
        Me.pct_Codigo.TabStop = False
        '
        'ptb_Foto
        '
        Me.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Foto.Location = New System.Drawing.Point(6, 19)
        Me.ptb_Foto.Name = "ptb_Foto"
        Me.ptb_Foto.Size = New System.Drawing.Size(238, 220)
        Me.ptb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_Foto.TabIndex = 35
        Me.ptb_Foto.TabStop = False
        '
        'tbx_NombreCompleto
        '
        Me.tbx_NombreCompleto.Control_Siguiente = Me.cmb_Departamento_DG
        Me.tbx_NombreCompleto.Filtrado = True
        Me.tbx_NombreCompleto.Location = New System.Drawing.Point(110, 46)
        Me.tbx_NombreCompleto.MaxLength = 100
        Me.tbx_NombreCompleto.Name = "tbx_NombreCompleto"
        Me.tbx_NombreCompleto.ReadOnly = True
        Me.tbx_NombreCompleto.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreCompleto.TabIndex = 0
        Me.tbx_NombreCompleto.TabStop = False
        Me.tbx_NombreCompleto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_Departamento_DG
        '
        Me.cmb_Departamento_DG.Clave = Nothing
        Me.cmb_Departamento_DG.Control_Siguiente = Me.cmb_Puesto
        Me.cmb_Departamento_DG.DisplayMember = "Descripcion"
        Me.cmb_Departamento_DG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento_DG.Empresa = False
        Me.cmb_Departamento_DG.Filtro = Nothing
        Me.cmb_Departamento_DG.FormattingEnabled = True
        Me.cmb_Departamento_DG.Location = New System.Drawing.Point(110, 149)
        Me.cmb_Departamento_DG.MaxDropDownItems = 20
        Me.cmb_Departamento_DG.Name = "cmb_Departamento_DG"
        Me.cmb_Departamento_DG.Pista = True
        Me.cmb_Departamento_DG.Size = New System.Drawing.Size(210, 21)
        Me.cmb_Departamento_DG.StoredProcedure = "Cat_Departamentos_Get"
        Me.cmb_Departamento_DG.Sucursal = False
        Me.cmb_Departamento_DG.TabIndex = 14
        Me.cmb_Departamento_DG.Tipo = 0
        Me.cmb_Departamento_DG.ValueMember = "Id_Departamento"
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
        Me.cmb_Puesto.Location = New System.Drawing.Point(110, 176)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = True
        Me.cmb_Puesto.Size = New System.Drawing.Size(210, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_Puestos_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 17
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'tbx_Fecha_FinLabores
        '
        Me.tbx_Fecha_FinLabores.Control_Siguiente = Nothing
        Me.tbx_Fecha_FinLabores.Filtrado = True
        Me.tbx_Fecha_FinLabores.Location = New System.Drawing.Point(622, 367)
        Me.tbx_Fecha_FinLabores.MaxLength = 8
        Me.tbx_Fecha_FinLabores.Name = "tbx_Fecha_FinLabores"
        Me.tbx_Fecha_FinLabores.ReadOnly = True
        Me.tbx_Fecha_FinLabores.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Fecha_FinLabores.TabIndex = 0
        Me.tbx_Fecha_FinLabores.TabStop = False
        Me.tbx_Fecha_FinLabores.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.Control_Siguiente = Nothing
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Location = New System.Drawing.Point(110, 72)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.Size = New System.Drawing.Size(210, 20)
        Me.tbx_Nombres.TabIndex = 6
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(110, 20)
        Me.tbx_Clave.MaxLength = 4
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_EmpleadosBaja
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.gbx_Foto)
        Me.Controls.Add(Me.gbx_Datos)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EmpleadosBaja"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Baja de Empleados"
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Datos.PerformLayout()
        Me.gbx_ListaNegra.ResumeLayout(False)
        Me.gbx_ListaNegra.PerformLayout()
        Me.gbx_Foto.ResumeLayout(False)
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbx_NombreCompleto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Departamento_DG As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_Fecha_FinLabores As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_FechaBaja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombres As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents rdb_No_CatFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CatFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Cancelar_DG As System.Windows.Forms.Button
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Guardar_DG As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombre_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaFinLabores_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso_Baja As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaFinLabores_Baja As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents cmb_Nombre_Baja As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Departamento_Baja As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Puesto_Baja As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_FechaIngreso_Baja As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Clave_Baja As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_MotivoBaja As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_MotivoBaja As System.Windows.Forms.Label
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Foto As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Codigo As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_AsteriscoMotivo As System.Windows.Forms.Label
    Friend WithEvents gbx_ListaNegra As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ListaNegraNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ListaNegraSi As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Motivo As System.Windows.Forms.Label
    Friend WithEvents rtb_Motivo As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_AsteriscoLN As System.Windows.Forms.Label
    Friend WithEvents lbl_AsteriscoAgregarLN As System.Windows.Forms.Label
    Friend WithEvents lbl_AsteriscoFecha As System.Windows.Forms.Label
End Class
