<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CredencialDetalleImprimirPlant
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
        Me.Gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Clave = New System.Windows.Forms.Label
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Status = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.tbx_FechaAutorizacion = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_FechaAuto = New System.Windows.Forms.Label
        Me.tbx_UsuarioAutoriza = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_UsuarioAutoriza = New System.Windows.Forms.Label
        Me.tbx_UsuarioExpide = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_UsuarioExp = New System.Windows.Forms.Label
        Me.tbx_FechaExpedicion = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Folio = New System.Windows.Forms.Label
        Me.tbx_FechaVencimiento = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Folio = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Puesto = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.lbl_Nombres = New System.Windows.Forms.Label
        Me.tbx_Apellidos = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_APaterno = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.tbx_FechaIngreso = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Departamento = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_FechaRegistro = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_FechaExpedicion = New System.Windows.Forms.Label
        Me.lbl_FechaIngreso = New System.Windows.Forms.Label
        Me.lbl_FechaRegistro = New System.Windows.Forms.Label
        Me.lbl_FechaVencimiento = New System.Windows.Forms.Label
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox
        Me.Gbx_Foto = New System.Windows.Forms.GroupBox
        Me.Label11 = New System.Windows.Forms.Label
        Me.pct_Firma = New System.Windows.Forms.PictureBox
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_brillo = New System.Windows.Forms.Label
        Me.btn_masc2 = New System.Windows.Forms.Button
        Me.btn_fotoOriginal = New System.Windows.Forms.Button
        Me.btn_cortaFoto = New System.Windows.Forms.Button
        Me.ptb_mascara = New System.Windows.Forms.PictureBox
        Me.pct_Codigo = New System.Windows.Forms.PictureBox
        Me.ptb_Foto = New System.Windows.Forms.PictureBox
        Me.tbr_brillo = New System.Windows.Forms.TrackBar
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ZebraTrasera = New System.Windows.Forms.Button
        Me.btn_ZebraFrente = New System.Windows.Forms.Button
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Impresion = New System.Windows.Forms.GroupBox
        Me.chk_Firma = New System.Windows.Forms.CheckBox
        Me.tbx_Firma = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_NumFir = New System.Windows.Forms.Label
        Me.rdb_FotoNo = New System.Windows.Forms.RadioButton
        Me.rdb_FotoSi = New System.Windows.Forms.RadioButton
        Me.tbx_Margen = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_ImprimirFoto = New System.Windows.Forms.Label
        Me.Lbl_MargenSup = New System.Windows.Forms.Label
        Me.Gbx_Reverso = New System.Windows.Forms.GroupBox
        Me.chk_Codigo = New System.Windows.Forms.CheckBox
        Me.chk_Leyenda = New System.Windows.Forms.CheckBox
        Me.rdb_ReversoNo = New System.Windows.Forms.RadioButton
        Me.rdb_ReversoSi = New System.Windows.Forms.RadioButton
        Me.Lbl_ImprimirRev = New System.Windows.Forms.Label
        Me.lbl_Impresora = New System.Windows.Forms.Label
        Me.lbl_Tit_Impresora = New System.Windows.Forms.Label
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lbl_Firma = New System.Windows.Forms.Label
        Me.Gbx_Datos.SuspendLayout()
        Me.Gbx_Foto.SuspendLayout()
        CType(Me.pct_Firma, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_mascara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbr_brillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Impresion.SuspendLayout()
        Me.Gbx_Reverso.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Datos
        '
        Me.Gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Clave)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Status)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_Status)
        Me.Gbx_Datos.Controls.Add(Me.tbx_FechaAutorizacion)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_FechaAuto)
        Me.Gbx_Datos.Controls.Add(Me.tbx_UsuarioAutoriza)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_UsuarioAutoriza)
        Me.Gbx_Datos.Controls.Add(Me.tbx_UsuarioExpide)
        Me.Gbx_Datos.Controls.Add(Me.Lbl_UsuarioExp)
        Me.Gbx_Datos.Controls.Add(Me.tbx_FechaExpedicion)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Folio)
        Me.Gbx_Datos.Controls.Add(Me.tbx_FechaVencimiento)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Folio)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Puesto)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Puesto)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Nombres)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Apellidos)
        Me.Gbx_Datos.Controls.Add(Me.lbl_APaterno)
        Me.Gbx_Datos.Controls.Add(Me.lbl_Departamento)
        Me.Gbx_Datos.Controls.Add(Me.tbx_FechaIngreso)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Departamento)
        Me.Gbx_Datos.Controls.Add(Me.tbx_FechaRegistro)
        Me.Gbx_Datos.Controls.Add(Me.lbl_FechaExpedicion)
        Me.Gbx_Datos.Controls.Add(Me.lbl_FechaIngreso)
        Me.Gbx_Datos.Controls.Add(Me.lbl_FechaRegistro)
        Me.Gbx_Datos.Controls.Add(Me.lbl_FechaVencimiento)
        Me.Gbx_Datos.Controls.Add(Me.tbx_Nombres)
        Me.Gbx_Datos.Location = New System.Drawing.Point(286, 33)
        Me.Gbx_Datos.Name = "Gbx_Datos"
        Me.Gbx_Datos.Size = New System.Drawing.Size(466, 343)
        Me.Gbx_Datos.TabIndex = 1
        Me.Gbx_Datos.TabStop = False
        '
        'Lbl_Clave
        '
        Me.Lbl_Clave.AutoSize = True
        Me.Lbl_Clave.Location = New System.Drawing.Point(111, 21)
        Me.Lbl_Clave.Name = "Lbl_Clave"
        Me.Lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_Clave.TabIndex = 0
        Me.Lbl_Clave.Text = "Clave"
        Me.Lbl_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Clave
        '
        Me.tbx_Clave.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Clave.Control_Siguiente = Nothing
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Clave.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbx_Clave.Location = New System.Drawing.Point(151, 13)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.ReadOnly = True
        Me.tbx_Clave.Size = New System.Drawing.Size(119, 26)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TabStop = False
        Me.tbx_Clave.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Status
        '
        Me.tbx_Status.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Status.Control_Siguiente = Nothing
        Me.tbx_Status.Filtrado = True
        Me.tbx_Status.Location = New System.Drawing.Point(151, 311)
        Me.tbx_Status.MaxLength = 10
        Me.tbx_Status.Name = "tbx_Status"
        Me.tbx_Status.ReadOnly = True
        Me.tbx_Status.Size = New System.Drawing.Size(214, 20)
        Me.tbx_Status.TabIndex = 27
        Me.tbx_Status.TabStop = False
        Me.tbx_Status.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(108, 314)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 26
        Me.Lbl_Status.Text = "Status"
        '
        'tbx_FechaAutorizacion
        '
        Me.tbx_FechaAutorizacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaAutorizacion.Control_Siguiente = Nothing
        Me.tbx_FechaAutorizacion.Filtrado = True
        Me.tbx_FechaAutorizacion.Location = New System.Drawing.Point(151, 259)
        Me.tbx_FechaAutorizacion.MaxLength = 10
        Me.tbx_FechaAutorizacion.Name = "tbx_FechaAutorizacion"
        Me.tbx_FechaAutorizacion.ReadOnly = True
        Me.tbx_FechaAutorizacion.Size = New System.Drawing.Size(69, 20)
        Me.tbx_FechaAutorizacion.TabIndex = 23
        Me.tbx_FechaAutorizacion.TabStop = False
        Me.tbx_FechaAutorizacion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_FechaAuto
        '
        Me.Lbl_FechaAuto.AutoSize = True
        Me.Lbl_FechaAuto.Location = New System.Drawing.Point(47, 262)
        Me.Lbl_FechaAuto.Name = "Lbl_FechaAuto"
        Me.Lbl_FechaAuto.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_FechaAuto.TabIndex = 22
        Me.Lbl_FechaAuto.Text = "Fecha Autorización"
        '
        'tbx_UsuarioAutoriza
        '
        Me.tbx_UsuarioAutoriza.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioAutoriza.Control_Siguiente = Nothing
        Me.tbx_UsuarioAutoriza.Filtrado = True
        Me.tbx_UsuarioAutoriza.Location = New System.Drawing.Point(151, 285)
        Me.tbx_UsuarioAutoriza.MaxLength = 30
        Me.tbx_UsuarioAutoriza.Name = "tbx_UsuarioAutoriza"
        Me.tbx_UsuarioAutoriza.ReadOnly = True
        Me.tbx_UsuarioAutoriza.Size = New System.Drawing.Size(305, 20)
        Me.tbx_UsuarioAutoriza.TabIndex = 25
        Me.tbx_UsuarioAutoriza.TabStop = False
        Me.tbx_UsuarioAutoriza.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_UsuarioAutoriza
        '
        Me.Lbl_UsuarioAutoriza.AutoSize = True
        Me.Lbl_UsuarioAutoriza.Location = New System.Drawing.Point(61, 288)
        Me.Lbl_UsuarioAutoriza.Name = "Lbl_UsuarioAutoriza"
        Me.Lbl_UsuarioAutoriza.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_UsuarioAutoriza.TabIndex = 24
        Me.Lbl_UsuarioAutoriza.Text = "Usuario Autoriza"
        '
        'tbx_UsuarioExpide
        '
        Me.tbx_UsuarioExpide.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_UsuarioExpide.Control_Siguiente = Nothing
        Me.tbx_UsuarioExpide.Filtrado = True
        Me.tbx_UsuarioExpide.Location = New System.Drawing.Point(151, 233)
        Me.tbx_UsuarioExpide.MaxLength = 30
        Me.tbx_UsuarioExpide.Name = "tbx_UsuarioExpide"
        Me.tbx_UsuarioExpide.ReadOnly = True
        Me.tbx_UsuarioExpide.Size = New System.Drawing.Size(305, 20)
        Me.tbx_UsuarioExpide.TabIndex = 21
        Me.tbx_UsuarioExpide.TabStop = False
        Me.tbx_UsuarioExpide.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_UsuarioExp
        '
        Me.Lbl_UsuarioExp.AutoSize = True
        Me.Lbl_UsuarioExp.Location = New System.Drawing.Point(67, 236)
        Me.Lbl_UsuarioExp.Name = "Lbl_UsuarioExp"
        Me.Lbl_UsuarioExp.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_UsuarioExp.TabIndex = 20
        Me.Lbl_UsuarioExp.Text = "Usuario Expide"
        '
        'tbx_FechaExpedicion
        '
        Me.tbx_FechaExpedicion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaExpedicion.Control_Siguiente = Nothing
        Me.tbx_FechaExpedicion.Filtrado = True
        Me.tbx_FechaExpedicion.Location = New System.Drawing.Point(151, 207)
        Me.tbx_FechaExpedicion.MaxLength = 10
        Me.tbx_FechaExpedicion.Name = "tbx_FechaExpedicion"
        Me.tbx_FechaExpedicion.ReadOnly = True
        Me.tbx_FechaExpedicion.Size = New System.Drawing.Size(69, 20)
        Me.tbx_FechaExpedicion.TabIndex = 17
        Me.tbx_FechaExpedicion.TabStop = False
        Me.tbx_FechaExpedicion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Folio
        '
        Me.lbl_Folio.AutoSize = True
        Me.lbl_Folio.Location = New System.Drawing.Point(48, 184)
        Me.lbl_Folio.Name = "lbl_Folio"
        Me.lbl_Folio.Size = New System.Drawing.Size(97, 13)
        Me.lbl_Folio.TabIndex = 14
        Me.lbl_Folio.Text = "Folio de Credencial"
        Me.lbl_Folio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_FechaVencimiento
        '
        Me.tbx_FechaVencimiento.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaVencimiento.Control_Siguiente = Nothing
        Me.tbx_FechaVencimiento.Filtrado = True
        Me.tbx_FechaVencimiento.Location = New System.Drawing.Point(387, 207)
        Me.tbx_FechaVencimiento.MaxLength = 10
        Me.tbx_FechaVencimiento.Name = "tbx_FechaVencimiento"
        Me.tbx_FechaVencimiento.ReadOnly = True
        Me.tbx_FechaVencimiento.Size = New System.Drawing.Size(69, 20)
        Me.tbx_FechaVencimiento.TabIndex = 19
        Me.tbx_FechaVencimiento.TabStop = False
        Me.tbx_FechaVencimiento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Folio
        '
        Me.tbx_Folio.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Folio.Control_Siguiente = Nothing
        Me.tbx_Folio.Filtrado = True
        Me.tbx_Folio.Location = New System.Drawing.Point(151, 181)
        Me.tbx_Folio.MaxLength = 4
        Me.tbx_Folio.Name = "tbx_Folio"
        Me.tbx_Folio.ReadOnly = True
        Me.tbx_Folio.Size = New System.Drawing.Size(69, 20)
        Me.tbx_Folio.TabIndex = 15
        Me.tbx_Folio.TabStop = False
        Me.tbx_Folio.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Puesto.Control_Siguiente = Nothing
        Me.tbx_Puesto.Filtrado = True
        Me.tbx_Puesto.Location = New System.Drawing.Point(151, 129)
        Me.tbx_Puesto.MaxLength = 30
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.ReadOnly = True
        Me.tbx_Puesto.Size = New System.Drawing.Size(305, 20)
        Me.tbx_Puesto.TabIndex = 9
        Me.tbx_Puesto.TabStop = False
        Me.tbx_Puesto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(105, 132)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 8
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(90, 51)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Nombres.TabIndex = 2
        Me.lbl_Nombres.Text = "Nombre(s)"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Apellidos
        '
        Me.tbx_Apellidos.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Apellidos.Control_Siguiente = Nothing
        Me.tbx_Apellidos.Filtrado = True
        Me.tbx_Apellidos.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Apellidos.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbx_Apellidos.Location = New System.Drawing.Point(151, 73)
        Me.tbx_Apellidos.MaxLength = 30
        Me.tbx_Apellidos.Name = "tbx_Apellidos"
        Me.tbx_Apellidos.ReadOnly = True
        Me.tbx_Apellidos.Size = New System.Drawing.Size(305, 26)
        Me.tbx_Apellidos.TabIndex = 5
        Me.tbx_Apellidos.TabStop = False
        Me.tbx_Apellidos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_APaterno
        '
        Me.lbl_APaterno.AutoSize = True
        Me.lbl_APaterno.Location = New System.Drawing.Point(11, 81)
        Me.lbl_APaterno.Name = "lbl_APaterno"
        Me.lbl_APaterno.Size = New System.Drawing.Size(134, 13)
        Me.lbl_APaterno.TabIndex = 4
        Me.lbl_APaterno.Text = "Apellido Paterno y Materno"
        Me.lbl_APaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(71, 106)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 6
        Me.lbl_Departamento.Text = "Departamento"
        '
        'tbx_FechaIngreso
        '
        Me.tbx_FechaIngreso.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaIngreso.Control_Siguiente = Nothing
        Me.tbx_FechaIngreso.Filtrado = True
        Me.tbx_FechaIngreso.Location = New System.Drawing.Point(387, 155)
        Me.tbx_FechaIngreso.MaxLength = 10
        Me.tbx_FechaIngreso.Name = "tbx_FechaIngreso"
        Me.tbx_FechaIngreso.ReadOnly = True
        Me.tbx_FechaIngreso.Size = New System.Drawing.Size(69, 20)
        Me.tbx_FechaIngreso.TabIndex = 13
        Me.tbx_FechaIngreso.TabStop = False
        Me.tbx_FechaIngreso.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Departamento
        '
        Me.tbx_Departamento.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Departamento.Control_Siguiente = Nothing
        Me.tbx_Departamento.Filtrado = True
        Me.tbx_Departamento.Location = New System.Drawing.Point(151, 103)
        Me.tbx_Departamento.MaxLength = 30
        Me.tbx_Departamento.Name = "tbx_Departamento"
        Me.tbx_Departamento.ReadOnly = True
        Me.tbx_Departamento.Size = New System.Drawing.Size(305, 20)
        Me.tbx_Departamento.TabIndex = 7
        Me.tbx_Departamento.TabStop = False
        Me.tbx_Departamento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_FechaRegistro
        '
        Me.tbx_FechaRegistro.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_FechaRegistro.Control_Siguiente = Nothing
        Me.tbx_FechaRegistro.Filtrado = True
        Me.tbx_FechaRegistro.Location = New System.Drawing.Point(151, 155)
        Me.tbx_FechaRegistro.MaxLength = 10
        Me.tbx_FechaRegistro.Name = "tbx_FechaRegistro"
        Me.tbx_FechaRegistro.ReadOnly = True
        Me.tbx_FechaRegistro.Size = New System.Drawing.Size(69, 20)
        Me.tbx_FechaRegistro.TabIndex = 11
        Me.tbx_FechaRegistro.TabStop = False
        Me.tbx_FechaRegistro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FechaExpedicion
        '
        Me.lbl_FechaExpedicion.AutoSize = True
        Me.lbl_FechaExpedicion.Location = New System.Drawing.Point(53, 210)
        Me.lbl_FechaExpedicion.Name = "lbl_FechaExpedicion"
        Me.lbl_FechaExpedicion.Size = New System.Drawing.Size(92, 13)
        Me.lbl_FechaExpedicion.TabIndex = 16
        Me.lbl_FechaExpedicion.Text = "Fecha Expedición"
        '
        'lbl_FechaIngreso
        '
        Me.lbl_FechaIngreso.AutoSize = True
        Me.lbl_FechaIngreso.Location = New System.Drawing.Point(306, 158)
        Me.lbl_FechaIngreso.Name = "lbl_FechaIngreso"
        Me.lbl_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FechaIngreso.TabIndex = 12
        Me.lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lbl_FechaRegistro
        '
        Me.lbl_FechaRegistro.AutoSize = True
        Me.lbl_FechaRegistro.Location = New System.Drawing.Point(66, 158)
        Me.lbl_FechaRegistro.Name = "lbl_FechaRegistro"
        Me.lbl_FechaRegistro.Size = New System.Drawing.Size(79, 13)
        Me.lbl_FechaRegistro.TabIndex = 10
        Me.lbl_FechaRegistro.Text = "Fecha Registro"
        '
        'lbl_FechaVencimiento
        '
        Me.lbl_FechaVencimiento.AutoSize = True
        Me.lbl_FechaVencimiento.Location = New System.Drawing.Point(283, 210)
        Me.lbl_FechaVencimiento.Name = "lbl_FechaVencimiento"
        Me.lbl_FechaVencimiento.Size = New System.Drawing.Size(98, 13)
        Me.lbl_FechaVencimiento.TabIndex = 18
        Me.lbl_FechaVencimiento.Text = "Fecha Vencimiento"
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Nombres.Control_Siguiente = Nothing
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Nombres.ForeColor = System.Drawing.Color.DarkGreen
        Me.tbx_Nombres.Location = New System.Drawing.Point(151, 43)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.ReadOnly = True
        Me.tbx_Nombres.Size = New System.Drawing.Size(305, 26)
        Me.tbx_Nombres.TabIndex = 3
        Me.tbx_Nombres.TabStop = False
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Gbx_Foto
        '
        Me.Gbx_Foto.Controls.Add(Me.Label11)
        Me.Gbx_Foto.Controls.Add(Me.pct_Firma)
        Me.Gbx_Foto.Controls.Add(Me.Label9)
        Me.Gbx_Foto.Controls.Add(Me.lbl_brillo)
        Me.Gbx_Foto.Controls.Add(Me.btn_masc2)
        Me.Gbx_Foto.Controls.Add(Me.btn_fotoOriginal)
        Me.Gbx_Foto.Controls.Add(Me.btn_cortaFoto)
        Me.Gbx_Foto.Controls.Add(Me.ptb_mascara)
        Me.Gbx_Foto.Controls.Add(Me.pct_Codigo)
        Me.Gbx_Foto.Controls.Add(Me.ptb_Foto)
        Me.Gbx_Foto.Controls.Add(Me.tbr_brillo)
        Me.Gbx_Foto.Location = New System.Drawing.Point(12, 33)
        Me.Gbx_Foto.Name = "Gbx_Foto"
        Me.Gbx_Foto.Size = New System.Drawing.Size(268, 450)
        Me.Gbx_Foto.TabIndex = 0
        Me.Gbx_Foto.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(232, 210)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "+"
        '
        'pct_Firma
        '
        Me.pct_Firma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Firma.Location = New System.Drawing.Point(2, 284)
        Me.pct_Firma.Name = "pct_Firma"
        Me.pct_Firma.Size = New System.Drawing.Size(260, 160)
        Me.pct_Firma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Firma.TabIndex = 36
        Me.pct_Firma.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(45, 210)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "-"
        '
        'lbl_brillo
        '
        Me.lbl_brillo.AutoSize = True
        Me.lbl_brillo.Location = New System.Drawing.Point(6, 200)
        Me.lbl_brillo.Name = "lbl_brillo"
        Me.lbl_brillo.Size = New System.Drawing.Size(29, 13)
        Me.lbl_brillo.TabIndex = 41
        Me.lbl_brillo.Text = "Brillo"
        '
        'btn_masc2
        '
        Me.btn_masc2.Enabled = False
        Me.btn_masc2.Location = New System.Drawing.Point(169, 248)
        Me.btn_masc2.Name = "btn_masc2"
        Me.btn_masc2.Size = New System.Drawing.Size(92, 31)
        Me.btn_masc2.TabIndex = 37
        Me.btn_masc2.Text = "Usar Mascara 2"
        Me.btn_masc2.UseVisualStyleBackColor = True
        '
        'btn_fotoOriginal
        '
        Me.btn_fotoOriginal.Enabled = False
        Me.btn_fotoOriginal.Location = New System.Drawing.Point(79, 248)
        Me.btn_fotoOriginal.Name = "btn_fotoOriginal"
        Me.btn_fotoOriginal.Size = New System.Drawing.Size(87, 31)
        Me.btn_fotoOriginal.TabIndex = 37
        Me.btn_fotoOriginal.Text = "&Volver Original"
        Me.btn_fotoOriginal.UseVisualStyleBackColor = True
        '
        'btn_cortaFoto
        '
        Me.btn_cortaFoto.Enabled = False
        Me.btn_cortaFoto.Location = New System.Drawing.Point(7, 248)
        Me.btn_cortaFoto.Name = "btn_cortaFoto"
        Me.btn_cortaFoto.Size = New System.Drawing.Size(69, 31)
        Me.btn_cortaFoto.TabIndex = 38
        Me.btn_cortaFoto.Text = "Cortar Foto"
        Me.btn_cortaFoto.UseVisualStyleBackColor = True
        '
        'ptb_mascara
        '
        Me.ptb_mascara.BackColor = System.Drawing.Color.Transparent
        Me.ptb_mascara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_mascara.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptb_mascara.ErrorImage = Nothing
        Me.ptb_mascara.InitialImage = Nothing
        Me.ptb_mascara.Location = New System.Drawing.Point(73, 41)
        Me.ptb_mascara.Name = "ptb_mascara"
        Me.ptb_mascara.Size = New System.Drawing.Size(120, 130)
        Me.ptb_mascara.TabIndex = 39
        Me.ptb_mascara.TabStop = False
        Me.ptb_mascara.Visible = False
        '
        'pct_Codigo
        '
        Me.pct_Codigo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Codigo.Location = New System.Drawing.Point(3, 284)
        Me.pct_Codigo.Name = "pct_Codigo"
        Me.pct_Codigo.Size = New System.Drawing.Size(256, 54)
        Me.pct_Codigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Codigo.TabIndex = 36
        Me.pct_Codigo.TabStop = False
        Me.pct_Codigo.Visible = False
        '
        'ptb_Foto
        '
        Me.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Foto.Location = New System.Drawing.Point(9, 13)
        Me.ptb_Foto.Name = "ptb_Foto"
        Me.ptb_Foto.Size = New System.Drawing.Size(248, 186)
        Me.ptb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_Foto.TabIndex = 35
        Me.ptb_Foto.TabStop = False
        '
        'tbr_brillo
        '
        Me.tbr_brillo.Enabled = False
        Me.tbr_brillo.Location = New System.Drawing.Point(55, 200)
        Me.tbr_brillo.Maximum = 100
        Me.tbr_brillo.Minimum = -100
        Me.tbr_brillo.Name = "tbr_brillo"
        Me.tbr_brillo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbr_brillo.Size = New System.Drawing.Size(179, 45)
        Me.tbr_brillo.TabIndex = 40
        Me.tbr_brillo.TickFrequency = 20
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ZebraTrasera)
        Me.Gbx_Botones.Controls.Add(Me.btn_ZebraFrente)
        Me.Gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(12, 600)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(740, 50)
        Me.Gbx_Botones.TabIndex = 4
        Me.Gbx_Botones.TabStop = False
        '
        'btn_ZebraTrasera
        '
        Me.btn_ZebraTrasera.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ZebraTrasera.Location = New System.Drawing.Point(155, 14)
        Me.btn_ZebraTrasera.Name = "btn_ZebraTrasera"
        Me.btn_ZebraTrasera.Size = New System.Drawing.Size(145, 30)
        Me.btn_ZebraTrasera.TabIndex = 2
        Me.btn_ZebraTrasera.Text = "Imprimir Zebra Trasera"
        Me.btn_ZebraTrasera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ZebraTrasera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ZebraTrasera.UseVisualStyleBackColor = True
        '
        'btn_ZebraFrente
        '
        Me.btn_ZebraFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ZebraFrente.Location = New System.Drawing.Point(9, 14)
        Me.btn_ZebraFrente.Name = "btn_ZebraFrente"
        Me.btn_ZebraFrente.Size = New System.Drawing.Size(140, 30)
        Me.btn_ZebraFrente.TabIndex = 2
        Me.btn_ZebraFrente.Text = "Imprimir Zebra Frente"
        Me.btn_ZebraFrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ZebraFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ZebraFrente.UseVisualStyleBackColor = True
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Enabled = False
        Me.btn_Imprimir.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(404, 14)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 0
        Me.btn_Imprimir.Text = "Imprimir Cred"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        Me.btn_Imprimir.Visible = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(594, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Gbx_Impresion
        '
        Me.Gbx_Impresion.Controls.Add(Me.chk_Firma)
        Me.Gbx_Impresion.Controls.Add(Me.tbx_Firma)
        Me.Gbx_Impresion.Controls.Add(Me.Lbl_NumFir)
        Me.Gbx_Impresion.Controls.Add(Me.rdb_FotoNo)
        Me.Gbx_Impresion.Controls.Add(Me.rdb_FotoSi)
        Me.Gbx_Impresion.Controls.Add(Me.tbx_Margen)
        Me.Gbx_Impresion.Controls.Add(Me.Lbl_ImprimirFoto)
        Me.Gbx_Impresion.Controls.Add(Me.Lbl_MargenSup)
        Me.Gbx_Impresion.Enabled = False
        Me.Gbx_Impresion.Location = New System.Drawing.Point(12, 489)
        Me.Gbx_Impresion.Name = "Gbx_Impresion"
        Me.Gbx_Impresion.Size = New System.Drawing.Size(742, 52)
        Me.Gbx_Impresion.TabIndex = 2
        Me.Gbx_Impresion.TabStop = False
        Me.Gbx_Impresion.Text = "Impresión"
        '
        'chk_Firma
        '
        Me.chk_Firma.AutoSize = True
        Me.chk_Firma.Checked = True
        Me.chk_Firma.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Firma.Location = New System.Drawing.Point(529, 21)
        Me.chk_Firma.Name = "chk_Firma"
        Me.chk_Firma.Size = New System.Drawing.Size(69, 17)
        Me.chk_Firma.TabIndex = 7
        Me.chk_Firma.Text = "Sin Firma"
        Me.chk_Firma.UseVisualStyleBackColor = True
        '
        'tbx_Firma
        '
        Me.tbx_Firma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Firma.Control_Siguiente = Nothing
        Me.tbx_Firma.Enabled = False
        Me.tbx_Firma.Filtrado = False
        Me.tbx_Firma.Location = New System.Drawing.Point(484, 19)
        Me.tbx_Firma.MaxLength = 4
        Me.tbx_Firma.Name = "tbx_Firma"
        Me.tbx_Firma.Size = New System.Drawing.Size(39, 20)
        Me.tbx_Firma.TabIndex = 6
        Me.tbx_Firma.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_NumFir
        '
        Me.Lbl_NumFir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_NumFir.AutoSize = True
        Me.Lbl_NumFir.Location = New System.Drawing.Point(391, 22)
        Me.Lbl_NumFir.Name = "Lbl_NumFir"
        Me.Lbl_NumFir.Size = New System.Drawing.Size(87, 13)
        Me.Lbl_NumFir.TabIndex = 5
        Me.Lbl_NumFir.Text = "Número de Firma"
        '
        'rdb_FotoNo
        '
        Me.rdb_FotoNo.AutoSize = True
        Me.rdb_FotoNo.Location = New System.Drawing.Point(324, 20)
        Me.rdb_FotoNo.Name = "rdb_FotoNo"
        Me.rdb_FotoNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_FotoNo.TabIndex = 4
        Me.rdb_FotoNo.TabStop = True
        Me.rdb_FotoNo.Text = "No"
        Me.rdb_FotoNo.UseVisualStyleBackColor = True
        '
        'rdb_FotoSi
        '
        Me.rdb_FotoSi.AutoSize = True
        Me.rdb_FotoSi.Location = New System.Drawing.Point(275, 20)
        Me.rdb_FotoSi.Name = "rdb_FotoSi"
        Me.rdb_FotoSi.Size = New System.Drawing.Size(34, 17)
        Me.rdb_FotoSi.TabIndex = 3
        Me.rdb_FotoSi.TabStop = True
        Me.rdb_FotoSi.Text = "Si"
        Me.rdb_FotoSi.UseVisualStyleBackColor = True
        '
        'tbx_Margen
        '
        Me.tbx_Margen.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.tbx_Margen.Control_Siguiente = Nothing
        Me.tbx_Margen.Filtrado = False
        Me.tbx_Margen.Location = New System.Drawing.Point(118, 19)
        Me.tbx_Margen.MaxLength = 4
        Me.tbx_Margen.Name = "tbx_Margen"
        Me.tbx_Margen.Size = New System.Drawing.Size(39, 20)
        Me.tbx_Margen.TabIndex = 1
        Me.tbx_Margen.Text = "1250"
        Me.tbx_Margen.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_ImprimirFoto
        '
        Me.Lbl_ImprimirFoto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ImprimirFoto.AutoSize = True
        Me.Lbl_ImprimirFoto.Location = New System.Drawing.Point(196, 22)
        Me.Lbl_ImprimirFoto.Name = "Lbl_ImprimirFoto"
        Me.Lbl_ImprimirFoto.Size = New System.Drawing.Size(66, 13)
        Me.Lbl_ImprimirFoto.TabIndex = 2
        Me.Lbl_ImprimirFoto.Text = "Imprimir Foto"
        '
        'Lbl_MargenSup
        '
        Me.Lbl_MargenSup.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_MargenSup.AutoSize = True
        Me.Lbl_MargenSup.Location = New System.Drawing.Point(27, 22)
        Me.Lbl_MargenSup.Name = "Lbl_MargenSup"
        Me.Lbl_MargenSup.Size = New System.Drawing.Size(85, 13)
        Me.Lbl_MargenSup.TabIndex = 0
        Me.Lbl_MargenSup.Text = "Margen Superior"
        '
        'Gbx_Reverso
        '
        Me.Gbx_Reverso.Controls.Add(Me.chk_Codigo)
        Me.Gbx_Reverso.Controls.Add(Me.chk_Leyenda)
        Me.Gbx_Reverso.Controls.Add(Me.rdb_ReversoNo)
        Me.Gbx_Reverso.Controls.Add(Me.rdb_ReversoSi)
        Me.Gbx_Reverso.Controls.Add(Me.Lbl_ImprimirRev)
        Me.Gbx_Reverso.Enabled = False
        Me.Gbx_Reverso.Location = New System.Drawing.Point(12, 547)
        Me.Gbx_Reverso.Name = "Gbx_Reverso"
        Me.Gbx_Reverso.Size = New System.Drawing.Size(742, 52)
        Me.Gbx_Reverso.TabIndex = 3
        Me.Gbx_Reverso.TabStop = False
        Me.Gbx_Reverso.Text = "Reverso"
        '
        'chk_Codigo
        '
        Me.chk_Codigo.AutoSize = True
        Me.chk_Codigo.Checked = True
        Me.chk_Codigo.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Codigo.Location = New System.Drawing.Point(529, 22)
        Me.chk_Codigo.Name = "chk_Codigo"
        Me.chk_Codigo.Size = New System.Drawing.Size(145, 17)
        Me.chk_Codigo.TabIndex = 4
        Me.chk_Codigo.Text = "Imprimir Código de Barras"
        Me.chk_Codigo.UseVisualStyleBackColor = True
        '
        'chk_Leyenda
        '
        Me.chk_Leyenda.AutoSize = True
        Me.chk_Leyenda.Checked = True
        Me.chk_Leyenda.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chk_Leyenda.Location = New System.Drawing.Point(394, 21)
        Me.chk_Leyenda.Name = "chk_Leyenda"
        Me.chk_Leyenda.Size = New System.Drawing.Size(105, 17)
        Me.chk_Leyenda.TabIndex = 3
        Me.chk_Leyenda.Text = "Imprimir Leyenda"
        Me.chk_Leyenda.UseVisualStyleBackColor = True
        '
        'rdb_ReversoNo
        '
        Me.rdb_ReversoNo.AutoSize = True
        Me.rdb_ReversoNo.Location = New System.Drawing.Point(324, 20)
        Me.rdb_ReversoNo.Name = "rdb_ReversoNo"
        Me.rdb_ReversoNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ReversoNo.TabIndex = 2
        Me.rdb_ReversoNo.Text = "No"
        Me.rdb_ReversoNo.UseVisualStyleBackColor = True
        '
        'rdb_ReversoSi
        '
        Me.rdb_ReversoSi.AutoSize = True
        Me.rdb_ReversoSi.Checked = True
        Me.rdb_ReversoSi.Location = New System.Drawing.Point(275, 20)
        Me.rdb_ReversoSi.Name = "rdb_ReversoSi"
        Me.rdb_ReversoSi.Size = New System.Drawing.Size(34, 17)
        Me.rdb_ReversoSi.TabIndex = 1
        Me.rdb_ReversoSi.TabStop = True
        Me.rdb_ReversoSi.Text = "Si"
        Me.rdb_ReversoSi.UseVisualStyleBackColor = True
        '
        'Lbl_ImprimirRev
        '
        Me.Lbl_ImprimirRev.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_ImprimirRev.AutoSize = True
        Me.Lbl_ImprimirRev.Location = New System.Drawing.Point(178, 22)
        Me.Lbl_ImprimirRev.Name = "Lbl_ImprimirRev"
        Me.Lbl_ImprimirRev.Size = New System.Drawing.Size(91, 13)
        Me.Lbl_ImprimirRev.TabIndex = 0
        Me.Lbl_ImprimirRev.Text = "Imprimir Reverso?"
        '
        'lbl_Impresora
        '
        Me.lbl_Impresora.AutoSize = True
        Me.lbl_Impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Impresora.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Impresora.Location = New System.Drawing.Point(117, 6)
        Me.lbl_Impresora.Name = "lbl_Impresora"
        Me.lbl_Impresora.Size = New System.Drawing.Size(85, 24)
        Me.lbl_Impresora.TabIndex = 5
        Me.lbl_Impresora.Text = "Nombre"
        '
        'lbl_Tit_Impresora
        '
        Me.lbl_Tit_Impresora.AutoSize = True
        Me.lbl_Tit_Impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tit_Impresora.Location = New System.Drawing.Point(13, 6)
        Me.lbl_Tit_Impresora.Name = "lbl_Tit_Impresora"
        Me.lbl_Tit_Impresora.Size = New System.Drawing.Size(109, 24)
        Me.lbl_Tit_Impresora.TabIndex = 6
        Me.lbl_Tit_Impresora.Text = "Impresora:"
        '
        'GroupBox6
        '
        Me.GroupBox6.Location = New System.Drawing.Point(287, 383)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(467, 100)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        '
        'lbl_Firma
        '
        Me.lbl_Firma.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Firma.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Firma.Location = New System.Drawing.Point(292, 396)
        Me.lbl_Firma.Name = "lbl_Firma"
        Me.lbl_Firma.Size = New System.Drawing.Size(455, 78)
        Me.lbl_Firma.TabIndex = 6
        Me.lbl_Firma.Text = "Firma"
        Me.lbl_Firma.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm_CredencialDetalleImprimirPlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 662)
        Me.Controls.Add(Me.lbl_Firma)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.lbl_Tit_Impresora)
        Me.Controls.Add(Me.lbl_Impresora)
        Me.Controls.Add(Me.Gbx_Reverso)
        Me.Controls.Add(Me.Gbx_Impresion)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Datos)
        Me.Controls.Add(Me.Gbx_Foto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CredencialDetalleImprimirPlant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Credencial"
        Me.Gbx_Datos.ResumeLayout(False)
        Me.Gbx_Datos.PerformLayout()
        Me.Gbx_Foto.ResumeLayout(False)
        Me.Gbx_Foto.PerformLayout()
        CType(Me.pct_Firma, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_mascara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbr_brillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Impresion.ResumeLayout(False)
        Me.Gbx_Impresion.PerformLayout()
        Me.Gbx_Reverso.ResumeLayout(False)
        Me.Gbx_Reverso.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_FechaVencimiento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Puesto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents tbx_Apellidos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_APaterno As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaIngreso As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Departamento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_FechaRegistro As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_FechaExpedicion As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaRegistro As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaVencimiento As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombres As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Folio As System.Windows.Forms.Label
    Friend WithEvents tbx_Folio As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Gbx_Foto As System.Windows.Forms.GroupBox
    Friend WithEvents ptb_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents tbx_FechaExpedicion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tbx_UsuarioAutoriza As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_UsuarioAutoriza As System.Windows.Forms.Label
    Friend WithEvents tbx_UsuarioExpide As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_UsuarioExp As System.Windows.Forms.Label
    Friend WithEvents tbx_Status As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents tbx_FechaAutorizacion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_FechaAuto As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Codigo As System.Windows.Forms.PictureBox
    Friend WithEvents Lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Gbx_Impresion As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_Margen As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_MargenSup As System.Windows.Forms.Label
    Friend WithEvents rdb_FotoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_FotoSi As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_ImprimirFoto As System.Windows.Forms.Label
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
    Friend WithEvents tbx_Firma As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NumFir As System.Windows.Forms.Label
    Friend WithEvents chk_Firma As System.Windows.Forms.CheckBox
    Friend WithEvents Gbx_Reverso As System.Windows.Forms.GroupBox
    Friend WithEvents chk_Codigo As System.Windows.Forms.CheckBox
    Friend WithEvents chk_Leyenda As System.Windows.Forms.CheckBox
    Friend WithEvents rdb_ReversoNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ReversoSi As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_ImprimirRev As System.Windows.Forms.Label
    Friend WithEvents btn_fotoOriginal As System.Windows.Forms.Button
    Friend WithEvents btn_cortaFoto As System.Windows.Forms.Button
    Friend WithEvents ptb_mascara As System.Windows.Forms.PictureBox
    Friend WithEvents tbr_brillo As System.Windows.Forms.TrackBar
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_brillo As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_ZebraTrasera As System.Windows.Forms.Button
    Friend WithEvents btn_ZebraFrente As System.Windows.Forms.Button
    Friend WithEvents btn_masc2 As System.Windows.Forms.Button
    Friend WithEvents lbl_Impresora As System.Windows.Forms.Label
    Friend WithEvents lbl_Tit_Impresora As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Firma As System.Windows.Forms.Label
    Friend WithEvents pct_Firma As System.Windows.Forms.PictureBox
End Class
