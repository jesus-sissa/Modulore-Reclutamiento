<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosporFuera
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmpleadosporFuera))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_CiudadNac = New System.Windows.Forms.Label()
        Me.lbl_LugarNac = New System.Windows.Forms.Label()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.lbl_FechaIngreso = New System.Windows.Forms.Label()
        Me.lbl_Numero = New System.Windows.Forms.Label()
        Me.lbl_Colonia = New System.Windows.Forms.Label()
        Me.lbl_Calle = New System.Windows.Forms.Label()
        Me.lbl_Telefono1 = New System.Windows.Forms.Label()
        Me.Lbl_EmailPersonal = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Lbl_Genero = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.lbl_FechaNac = New System.Windows.Forms.Label()
        Me.lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.lbl_Departamento = New System.Windows.Forms.Label()
        Me.lbl_Puesto = New System.Windows.Forms.Label()
        Me.lbl_NombreCompleto = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lbl_AMaterno = New System.Windows.Forms.Label()
        Me.lbl_APaterno = New System.Windows.Forms.Label()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_Clave = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.btn_Cancelar = New System.Windows.Forms.Button()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tbp_Listado = New System.Windows.Forms.TabPage()
        Me.Lbl_NumeroR = New System.Windows.Forms.Label()
        Me.btn_Baja = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox()
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox()
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button()
        Me.Lbl_LStatus = New System.Windows.Forms.Label()
        Me.Lbl_LPuesto = New System.Windows.Forms.Label()
        Me.Lbl_LDepartamento = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview()
        Me.tbp_Nuevo = New System.Windows.Forms.TabPage()
        Me.lbl_NSS = New System.Windows.Forms.Label()
        Me.tbx_NSS = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Curp = New System.Windows.Forms.Label()
        Me.tbx_CURP = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_RFC = New System.Windows.Forms.Label()
        Me.tbx_RFC = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ClaveCompara = New System.Windows.Forms.Label()
        Me.pct_Codigo = New System.Windows.Forms.PictureBox()
        Me.gbx_Firma = New System.Windows.Forms.GroupBox()
        Me.btn_ExtraerFirma = New System.Windows.Forms.Button()
        Me.btn_ExaminarFirma = New System.Windows.Forms.Button()
        Me.btn_TomarFirma = New System.Windows.Forms.Button()
        Me.btn_LimpiarFirma = New System.Windows.Forms.Button()
        Me.pct_Firma = New System.Windows.Forms.PictureBox()
        Me.gbx_Frente = New System.Windows.Forms.GroupBox()
        Me.btn_ExtraerFrente = New System.Windows.Forms.Button()
        Me.btn_ExaminarFrente = New System.Windows.Forms.Button()
        Me.btn_TomarFrente = New System.Windows.Forms.Button()
        Me.pct_Frente = New System.Windows.Forms.PictureBox()
        Me.btn_LimpiarFrente = New System.Windows.Forms.Button()
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_ApellidoPaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_ApellidoMaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Ciudad = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Estado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_NombreCompleto = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Numero = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Colonia = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Departamento = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Calle = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Telefono = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_EstadoCivil = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_MailPersonal = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Genero = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.tbx_IdTributario = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_RFC_Extranjero = New System.Windows.Forms.Label()
        Me.Tab_Catalogo.SuspendLayout()
        Me.tbp_Listado.SuspendLayout()
        Me.tbp_Nuevo.SuspendLayout()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Firma.SuspendLayout()
        CType(Me.pct_Firma, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Frente.SuspendLayout()
        CType(Me.pct_Frente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(148, 537)
        Me.dtp_FechaIngreso.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(132, 22)
        Me.dtp_FechaIngreso.TabIndex = 49
        '
        'dtp_FechaNac
        '
        Me.dtp_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNac.Location = New System.Drawing.Point(472, 178)
        Me.dtp_FechaNac.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dtp_FechaNac.Name = "dtp_FechaNac"
        Me.dtp_FechaNac.Size = New System.Drawing.Size(132, 22)
        Me.dtp_FechaNac.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(305, 180)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(16, 19)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(625, 112)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(16, 19)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "*"
        '
        'lbl_CiudadNac
        '
        Me.lbl_CiudadNac.AutoSize = True
        Me.lbl_CiudadNac.Location = New System.Drawing.Point(87, 443)
        Me.lbl_CiudadNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_CiudadNac.Name = "lbl_CiudadNac"
        Me.lbl_CiudadNac.Size = New System.Drawing.Size(52, 17)
        Me.lbl_CiudadNac.TabIndex = 42
        Me.lbl_CiudadNac.Text = "Ciudad"
        '
        'lbl_LugarNac
        '
        Me.lbl_LugarNac.AutoSize = True
        Me.lbl_LugarNac.Location = New System.Drawing.Point(88, 412)
        Me.lbl_LugarNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_LugarNac.Name = "lbl_LugarNac"
        Me.lbl_LugarNac.Size = New System.Drawing.Size(52, 17)
        Me.lbl_LugarNac.TabIndex = 40
        Me.lbl_LugarNac.Text = "Estado"
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.ForeColor = System.Drawing.Color.Red
        Me.Label155.Location = New System.Drawing.Point(289, 542)
        Me.Label155.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(16, 19)
        Me.Label155.TabIndex = 50
        Me.Label155.Text = "*"
        '
        'lbl_FechaIngreso
        '
        Me.lbl_FechaIngreso.AutoSize = True
        Me.lbl_FechaIngreso.Location = New System.Drawing.Point(41, 542)
        Me.lbl_FechaIngreso.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_FechaIngreso.Name = "lbl_FechaIngreso"
        Me.lbl_FechaIngreso.Size = New System.Drawing.Size(98, 17)
        Me.lbl_FechaIngreso.TabIndex = 48
        Me.lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'lbl_Numero
        '
        Me.lbl_Numero.AutoSize = True
        Me.lbl_Numero.Location = New System.Drawing.Point(83, 346)
        Me.lbl_Numero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Numero.Name = "lbl_Numero"
        Me.lbl_Numero.Size = New System.Drawing.Size(58, 17)
        Me.lbl_Numero.TabIndex = 36
        Me.lbl_Numero.Text = "Número"
        '
        'lbl_Colonia
        '
        Me.lbl_Colonia.AutoSize = True
        Me.lbl_Colonia.Location = New System.Drawing.Point(84, 378)
        Me.lbl_Colonia.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Colonia.Name = "lbl_Colonia"
        Me.lbl_Colonia.Size = New System.Drawing.Size(55, 17)
        Me.lbl_Colonia.TabIndex = 38
        Me.lbl_Colonia.Text = "Colonia"
        '
        'lbl_Calle
        '
        Me.lbl_Calle.AutoSize = True
        Me.lbl_Calle.Location = New System.Drawing.Point(101, 314)
        Me.lbl_Calle.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Calle.Name = "lbl_Calle"
        Me.lbl_Calle.Size = New System.Drawing.Size(39, 17)
        Me.lbl_Calle.TabIndex = 34
        Me.lbl_Calle.Text = "Calle"
        '
        'lbl_Telefono1
        '
        Me.lbl_Telefono1.AutoSize = True
        Me.lbl_Telefono1.Location = New System.Drawing.Point(77, 250)
        Me.lbl_Telefono1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Telefono1.Name = "lbl_Telefono1"
        Me.lbl_Telefono1.Size = New System.Drawing.Size(64, 17)
        Me.lbl_Telefono1.TabIndex = 26
        Me.lbl_Telefono1.Text = "Teléfono"
        '
        'Lbl_EmailPersonal
        '
        Me.Lbl_EmailPersonal.AutoSize = True
        Me.Lbl_EmailPersonal.Location = New System.Drawing.Point(41, 214)
        Me.Lbl_EmailPersonal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_EmailPersonal.Name = "Lbl_EmailPersonal"
        Me.Lbl_EmailPersonal.Size = New System.Drawing.Size(102, 17)
        Me.Lbl_EmailPersonal.TabIndex = 24
        Me.Lbl_EmailPersonal.Text = "Email Personal"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Red
        Me.Label139.Location = New System.Drawing.Point(613, 180)
        Me.Label139.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(16, 19)
        Me.Label139.TabIndex = 23
        Me.Label139.Text = "*"
        '
        'Lbl_Genero
        '
        Me.Lbl_Genero.AutoSize = True
        Me.Lbl_Genero.Location = New System.Drawing.Point(87, 146)
        Me.Lbl_Genero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_Genero.Name = "Lbl_Genero"
        Me.Lbl_Genero.Size = New System.Drawing.Size(56, 17)
        Me.Lbl_Genero.TabIndex = 15
        Me.Lbl_Genero.Text = "Género"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(305, 144)
        Me.Label51.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(16, 19)
        Me.Label51.TabIndex = 17
        Me.Label51.Text = "*"
        '
        'lbl_FechaNac
        '
        Me.lbl_FechaNac.AutoSize = True
        Me.lbl_FechaNac.Location = New System.Drawing.Point(339, 182)
        Me.lbl_FechaNac.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_FechaNac.Name = "lbl_FechaNac"
        Me.lbl_FechaNac.Size = New System.Drawing.Size(121, 17)
        Me.lbl_FechaNac.TabIndex = 21
        Me.lbl_FechaNac.Text = "Fecha Nacimiento"
        '
        'lbl_EstadoCivil
        '
        Me.lbl_EstadoCivil.AutoSize = True
        Me.lbl_EstadoCivil.Location = New System.Drawing.Point(60, 182)
        Me.lbl_EstadoCivil.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_EstadoCivil.Name = "lbl_EstadoCivil"
        Me.lbl_EstadoCivil.Size = New System.Drawing.Size(81, 17)
        Me.lbl_EstadoCivil.TabIndex = 18
        Me.lbl_EstadoCivil.Text = "Estado Civil"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(43, 476)
        Me.lbl_Departamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(98, 17)
        Me.lbl_Departamento.TabIndex = 44
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(88, 507)
        Me.lbl_Puesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(52, 17)
        Me.lbl_Puesto.TabIndex = 46
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_NombreCompleto
        '
        Me.lbl_NombreCompleto.AutoSize = True
        Me.lbl_NombreCompleto.Location = New System.Drawing.Point(21, 55)
        Me.lbl_NombreCompleto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NombreCompleto.Name = "lbl_NombreCompleto"
        Me.lbl_NombreCompleto.Size = New System.Drawing.Size(121, 17)
        Me.lbl_NombreCompleto.TabIndex = 4
        Me.lbl_NombreCompleto.Text = "Nombre Completo"
        Me.lbl_NombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(339, 113)
        Me.Label69.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(16, 19)
        Me.Label69.TabIndex = 11
        Me.Label69.Text = "*"
        '
        'lbl_AMaterno
        '
        Me.lbl_AMaterno.AutoSize = True
        Me.lbl_AMaterno.Location = New System.Drawing.Point(369, 116)
        Me.lbl_AMaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_AMaterno.Name = "lbl_AMaterno"
        Me.lbl_AMaterno.Size = New System.Drawing.Size(60, 17)
        Me.lbl_AMaterno.TabIndex = 12
        Me.lbl_AMaterno.Text = "Materno"
        Me.lbl_AMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APaterno
        '
        Me.lbl_APaterno.AutoSize = True
        Me.lbl_APaterno.Location = New System.Drawing.Point(31, 114)
        Me.lbl_APaterno.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_APaterno.Name = "lbl_APaterno"
        Me.lbl_APaterno.Size = New System.Drawing.Size(112, 17)
        Me.lbl_APaterno.TabIndex = 9
        Me.lbl_APaterno.Text = "Apellido Paterno"
        Me.lbl_APaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(69, 85)
        Me.lbl_Nombres.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(75, 17)
        Me.lbl_Nombres.TabIndex = 6
        Me.lbl_Nombres.Text = "Nombre(s)"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(439, 82)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 19)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "*"
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(97, 23)
        Me.lbl_Clave.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(43, 17)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(248, 21)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(149, 590)
        Me.btn_Guardar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Guardar.TabIndex = 54
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(443, 590)
        Me.btn_Cancelar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(173, 37)
        Me.btn_Cancelar.TabIndex = 55
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tbp_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.tbp_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(1272, 690)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tbp_Listado
        '
        Me.tbp_Listado.Controls.Add(Me.Lbl_NumeroR)
        Me.tbp_Listado.Controls.Add(Me.btn_Baja)
        Me.tbp_Listado.Controls.Add(Me.btn_Modificar)
        Me.tbp_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tbp_Listado.Controls.Add(Me.chk_Status)
        Me.tbp_Listado.Controls.Add(Me.cmb_Status)
        Me.tbp_Listado.Controls.Add(Me.cmb_PuestoFiltro)
        Me.tbp_Listado.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.tbp_Listado.Controls.Add(Me.chk_PuestoFiltro)
        Me.tbp_Listado.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.tbp_Listado.Controls.Add(Me.btn_MostrarCatalogo)
        Me.tbp_Listado.Controls.Add(Me.Lbl_LStatus)
        Me.tbp_Listado.Controls.Add(Me.Lbl_LPuesto)
        Me.tbp_Listado.Controls.Add(Me.Lbl_LDepartamento)
        Me.tbp_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tbp_Listado.Location = New System.Drawing.Point(4, 25)
        Me.tbp_Listado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbp_Listado.Name = "tbp_Listado"
        Me.tbp_Listado.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbp_Listado.Size = New System.Drawing.Size(1264, 661)
        Me.tbp_Listado.TabIndex = 0
        Me.tbp_Listado.Text = "Listado"
        Me.tbp_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_NumeroR
        '
        Me.Lbl_NumeroR.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_NumeroR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_NumeroR.Location = New System.Drawing.Point(944, 92)
        Me.Lbl_NumeroR.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_NumeroR.Name = "Lbl_NumeroR"
        Me.Lbl_NumeroR.Size = New System.Drawing.Size(296, 28)
        Me.Lbl_NumeroR.TabIndex = 22
        Me.Lbl_NumeroR.Text = "Registros: 0"
        Me.Lbl_NumeroR.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Trash
        Me.btn_Baja.Location = New System.Drawing.Point(217, 614)
        Me.btn_Baja.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(187, 37)
        Me.btn_Baja.TabIndex = 12
        Me.btn_Baja.Text = "&Baja"
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(23, 614)
        Me.btn_Modificar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Modificar.TabIndex = 11
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(1053, 614)
        Me.btn_Cerrar.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(187, 37)
        Me.btn_Cerrar.TabIndex = 13
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(445, 90)
        Me.chk_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(70, 21)
        Me.chk_Status.TabIndex = 8
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(132, 85)
        Me.cmb_Status.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(303, 24)
        Me.cmb_Status.TabIndex = 7
        Me.cmb_Status.ValueMember = "value"
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(132, 52)
        Me.cmb_PuestoFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(429, 24)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 4
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(132, 18)
        Me.cmb_DepartamentoFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(429, 24)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 1
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(571, 54)
        Me.chk_PuestoFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(70, 21)
        Me.chk_PuestoFiltro.TabIndex = 5
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(571, 22)
        Me.chk_DepartamentoFiltro.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(70, 21)
        Me.chk_DepartamentoFiltro.TabIndex = 2
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(523, 80)
        Me.btn_MostrarCatalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(187, 37)
        Me.btn_MostrarCatalogo.TabIndex = 9
        Me.btn_MostrarCatalogo.Text = "M&ostrar"
        Me.btn_MostrarCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarCatalogo.UseVisualStyleBackColor = True
        '
        'Lbl_LStatus
        '
        Me.Lbl_LStatus.AutoSize = True
        Me.Lbl_LStatus.Location = New System.Drawing.Point(75, 91)
        Me.Lbl_LStatus.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LStatus.Name = "Lbl_LStatus"
        Me.Lbl_LStatus.Size = New System.Drawing.Size(48, 17)
        Me.Lbl_LStatus.TabIndex = 6
        Me.Lbl_LStatus.Text = "Status"
        '
        'Lbl_LPuesto
        '
        Me.Lbl_LPuesto.AutoSize = True
        Me.Lbl_LPuesto.Location = New System.Drawing.Point(71, 55)
        Me.Lbl_LPuesto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LPuesto.Name = "Lbl_LPuesto"
        Me.Lbl_LPuesto.Size = New System.Drawing.Size(52, 17)
        Me.Lbl_LPuesto.TabIndex = 3
        Me.Lbl_LPuesto.Text = "Puesto"
        '
        'Lbl_LDepartamento
        '
        Me.Lbl_LDepartamento.AutoSize = True
        Me.Lbl_LDepartamento.Location = New System.Drawing.Point(25, 22)
        Me.Lbl_LDepartamento.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbl_LDepartamento.Name = "Lbl_LDepartamento"
        Me.Lbl_LDepartamento.Size = New System.Drawing.Size(98, 17)
        Me.Lbl_LDepartamento.TabIndex = 0
        Me.Lbl_LDepartamento.Text = "Departamento"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(23, 124)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 32
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(1216, 482)
        Me.lsv_Catalogo.TabIndex = 10
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tbp_Nuevo
        '
        Me.tbp_Nuevo.Controls.Add(Me.tbx_IdTributario)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_RFC_Extranjero)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_NSS)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_NSS)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Curp)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_CURP)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_RFC)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_RFC)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_ClaveCompara)
        Me.tbp_Nuevo.Controls.Add(Me.pct_Codigo)
        Me.tbp_Nuevo.Controls.Add(Me.gbx_Firma)
        Me.tbp_Nuevo.Controls.Add(Me.gbx_Frente)
        Me.tbp_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.tbp_Nuevo.Controls.Add(Me.dtp_FechaIngreso)
        Me.tbp_Nuevo.Controls.Add(Me.dtp_FechaNac)
        Me.tbp_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.tbp_Nuevo.Controls.Add(Me.Label1)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Clave)
        Me.tbp_Nuevo.Controls.Add(Me.Label2)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Nombres)
        Me.tbp_Nuevo.Controls.Add(Me.Label4)
        Me.tbp_Nuevo.Controls.Add(Me.Label3)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_APaterno)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_AMaterno)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_CiudadNac)
        Me.tbp_Nuevo.Controls.Add(Me.Label69)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_LugarNac)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_NombreCompleto)
        Me.tbp_Nuevo.Controls.Add(Me.Label155)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_FechaIngreso)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Puesto)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Departamento)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Numero)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Colonia)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Calle)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_EstadoCivil)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_Telefono1)
        Me.tbp_Nuevo.Controls.Add(Me.lbl_FechaNac)
        Me.tbp_Nuevo.Controls.Add(Me.Lbl_EmailPersonal)
        Me.tbp_Nuevo.Controls.Add(Me.Label51)
        Me.tbp_Nuevo.Controls.Add(Me.Lbl_Genero)
        Me.tbp_Nuevo.Controls.Add(Me.Label139)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Clave)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Nombres)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_ApellidoPaterno)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_ApellidoMaterno)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_Ciudad)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_Estado)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_NombreCompleto)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Numero)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Colonia)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_Departamento)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Calle)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_Puesto)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_Telefono)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_EstadoCivil)
        Me.tbp_Nuevo.Controls.Add(Me.tbx_MailPersonal)
        Me.tbp_Nuevo.Controls.Add(Me.cmb_Genero)
        Me.tbp_Nuevo.Location = New System.Drawing.Point(4, 25)
        Me.tbp_Nuevo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbp_Nuevo.Name = "tbp_Nuevo"
        Me.tbp_Nuevo.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbp_Nuevo.Size = New System.Drawing.Size(1264, 661)
        Me.tbp_Nuevo.TabIndex = 1
        Me.tbp_Nuevo.Text = "Nuevo"
        Me.tbp_Nuevo.UseVisualStyleBackColor = True
        '
        'lbl_NSS
        '
        Me.lbl_NSS.AutoSize = True
        Me.lbl_NSS.Location = New System.Drawing.Point(355, 250)
        Me.lbl_NSS.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_NSS.Name = "lbl_NSS"
        Me.lbl_NSS.Size = New System.Drawing.Size(108, 17)
        Me.lbl_NSS.TabIndex = 28
        Me.lbl_NSS.Text = "Numero Seguro"
        '
        'tbx_NSS
        '
        Me.tbx_NSS.Control_Siguiente = Nothing
        Me.tbx_NSS.Filtrado = True
        Me.tbx_NSS.Location = New System.Drawing.Point(471, 246)
        Me.tbx_NSS.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_NSS.MaxLength = 14
        Me.tbx_NSS.Name = "tbx_NSS"
        Me.tbx_NSS.Size = New System.Drawing.Size(145, 22)
        Me.tbx_NSS.TabIndex = 29
        Me.tbx_NSS.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Curp
        '
        Me.lbl_Curp.AutoSize = True
        Me.lbl_Curp.Location = New System.Drawing.Point(359, 282)
        Me.lbl_Curp.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_Curp.Name = "lbl_Curp"
        Me.lbl_Curp.Size = New System.Drawing.Size(46, 17)
        Me.lbl_Curp.TabIndex = 32
        Me.lbl_Curp.Text = "CURP"
        '
        'tbx_CURP
        '
        Me.tbx_CURP.Control_Siguiente = Nothing
        Me.tbx_CURP.Filtrado = True
        Me.tbx_CURP.Location = New System.Drawing.Point(416, 278)
        Me.tbx_CURP.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_CURP.MaxLength = 25
        Me.tbx_CURP.Name = "tbx_CURP"
        Me.tbx_CURP.Size = New System.Drawing.Size(201, 22)
        Me.tbx_CURP.TabIndex = 33
        Me.tbx_CURP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(105, 282)
        Me.lbl_RFC.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(35, 17)
        Me.lbl_RFC.TabIndex = 30
        Me.lbl_RFC.Text = "RFC"
        '
        'tbx_RFC
        '
        Me.tbx_RFC.Control_Siguiente = Nothing
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(149, 278)
        Me.tbx_RFC.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_RFC.MaxLength = 14
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(145, 22)
        Me.tbx_RFC.TabIndex = 31
        Me.tbx_RFC.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_ClaveCompara
        '
        Me.lbl_ClaveCompara.AutoSize = True
        Me.lbl_ClaveCompara.Location = New System.Drawing.Point(305, 21)
        Me.lbl_ClaveCompara.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_ClaveCompara.Name = "lbl_ClaveCompara"
        Me.lbl_ClaveCompara.Size = New System.Drawing.Size(48, 17)
        Me.lbl_ClaveCompara.TabIndex = 3
        Me.lbl_ClaveCompara.Text = "WXYZ"
        Me.lbl_ClaveCompara.Visible = False
        '
        'pct_Codigo
        '
        Me.pct_Codigo.Location = New System.Drawing.Point(0, 0)
        Me.pct_Codigo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pct_Codigo.Name = "pct_Codigo"
        Me.pct_Codigo.Size = New System.Drawing.Size(133, 62)
        Me.pct_Codigo.TabIndex = 34
        Me.pct_Codigo.TabStop = False
        '
        'gbx_Firma
        '
        Me.gbx_Firma.Controls.Add(Me.btn_ExtraerFirma)
        Me.gbx_Firma.Controls.Add(Me.btn_ExaminarFirma)
        Me.gbx_Firma.Controls.Add(Me.btn_TomarFirma)
        Me.gbx_Firma.Controls.Add(Me.btn_LimpiarFirma)
        Me.gbx_Firma.Controls.Add(Me.pct_Firma)
        Me.gbx_Firma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Firma.Location = New System.Drawing.Point(952, 7)
        Me.gbx_Firma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Firma.Name = "gbx_Firma"
        Me.gbx_Firma.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Firma.Size = New System.Drawing.Size(293, 254)
        Me.gbx_Firma.TabIndex = 52
        Me.gbx_Firma.TabStop = False
        Me.gbx_Firma.Text = "Firma"
        '
        'btn_ExtraerFirma
        '
        Me.btn_ExtraerFirma.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExtraerFirma.Enabled = False
        Me.btn_ExtraerFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExtraerFirma.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ExtraerImagenesEmpleado
        Me.btn_ExtraerFirma.Location = New System.Drawing.Point(180, 215)
        Me.btn_ExtraerFirma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ExtraerFirma.Name = "btn_ExtraerFirma"
        Me.btn_ExtraerFirma.Size = New System.Drawing.Size(49, 31)
        Me.btn_ExtraerFirma.TabIndex = 3
        Me.btn_ExtraerFirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExtraerFirma.UseVisualStyleBackColor = True
        '
        'btn_ExaminarFirma
        '
        Me.btn_ExaminarFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExaminarFirma.Location = New System.Drawing.Point(8, 215)
        Me.btn_ExaminarFirma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ExaminarFirma.Name = "btn_ExaminarFirma"
        Me.btn_ExaminarFirma.Size = New System.Drawing.Size(49, 31)
        Me.btn_ExaminarFirma.TabIndex = 0
        Me.btn_ExaminarFirma.Text = "..."
        Me.btn_ExaminarFirma.UseVisualStyleBackColor = True
        '
        'btn_TomarFirma
        '
        Me.btn_TomarFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TomarFirma.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_TomarFirma.Location = New System.Drawing.Point(65, 215)
        Me.btn_TomarFirma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_TomarFirma.Name = "btn_TomarFirma"
        Me.btn_TomarFirma.Size = New System.Drawing.Size(49, 31)
        Me.btn_TomarFirma.TabIndex = 1
        Me.btn_TomarFirma.UseVisualStyleBackColor = True
        '
        'btn_LimpiarFirma
        '
        Me.btn_LimpiarFirma.Enabled = False
        Me.btn_LimpiarFirma.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarFirma.Image = CType(resources.GetObject("btn_LimpiarFirma.Image"), System.Drawing.Image)
        Me.btn_LimpiarFirma.Location = New System.Drawing.Point(123, 215)
        Me.btn_LimpiarFirma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_LimpiarFirma.Name = "btn_LimpiarFirma"
        Me.btn_LimpiarFirma.Size = New System.Drawing.Size(49, 31)
        Me.btn_LimpiarFirma.TabIndex = 2
        Me.btn_LimpiarFirma.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LimpiarFirma.UseVisualStyleBackColor = True
        '
        'pct_Firma
        '
        Me.pct_Firma.BackColor = System.Drawing.Color.White
        Me.pct_Firma.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Firma.Location = New System.Drawing.Point(8, 23)
        Me.pct_Firma.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pct_Firma.Name = "pct_Firma"
        Me.pct_Firma.Size = New System.Drawing.Size(272, 187)
        Me.pct_Firma.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Firma.TabIndex = 129
        Me.pct_Firma.TabStop = False
        '
        'gbx_Frente
        '
        Me.gbx_Frente.Controls.Add(Me.btn_ExtraerFrente)
        Me.gbx_Frente.Controls.Add(Me.btn_ExaminarFrente)
        Me.gbx_Frente.Controls.Add(Me.btn_TomarFrente)
        Me.gbx_Frente.Controls.Add(Me.pct_Frente)
        Me.gbx_Frente.Controls.Add(Me.btn_LimpiarFrente)
        Me.gbx_Frente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Frente.Location = New System.Drawing.Point(651, 7)
        Me.gbx_Frente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Frente.Name = "gbx_Frente"
        Me.gbx_Frente.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.gbx_Frente.Size = New System.Drawing.Size(293, 254)
        Me.gbx_Frente.TabIndex = 51
        Me.gbx_Frente.TabStop = False
        Me.gbx_Frente.Text = "Frente"
        '
        'btn_ExtraerFrente
        '
        Me.btn_ExtraerFrente.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExtraerFrente.Enabled = False
        Me.btn_ExtraerFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExtraerFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ExtraerImagenesEmpleado
        Me.btn_ExtraerFrente.Location = New System.Drawing.Point(180, 215)
        Me.btn_ExtraerFrente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ExtraerFrente.Name = "btn_ExtraerFrente"
        Me.btn_ExtraerFrente.Size = New System.Drawing.Size(49, 31)
        Me.btn_ExtraerFrente.TabIndex = 3
        Me.btn_ExtraerFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExtraerFrente.UseVisualStyleBackColor = True
        '
        'btn_ExaminarFrente
        '
        Me.btn_ExaminarFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ExaminarFrente.Location = New System.Drawing.Point(8, 215)
        Me.btn_ExaminarFrente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_ExaminarFrente.Name = "btn_ExaminarFrente"
        Me.btn_ExaminarFrente.Size = New System.Drawing.Size(49, 31)
        Me.btn_ExaminarFrente.TabIndex = 0
        Me.btn_ExaminarFrente.Text = "..."
        Me.btn_ExaminarFrente.UseVisualStyleBackColor = True
        '
        'btn_TomarFrente
        '
        Me.btn_TomarFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TomarFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_TomarFrente.Location = New System.Drawing.Point(65, 215)
        Me.btn_TomarFrente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_TomarFrente.Name = "btn_TomarFrente"
        Me.btn_TomarFrente.Size = New System.Drawing.Size(49, 31)
        Me.btn_TomarFrente.TabIndex = 1
        Me.btn_TomarFrente.UseVisualStyleBackColor = True
        '
        'pct_Frente
        '
        Me.pct_Frente.BackColor = System.Drawing.Color.White
        Me.pct_Frente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Frente.Location = New System.Drawing.Point(8, 23)
        Me.pct_Frente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.pct_Frente.Name = "pct_Frente"
        Me.pct_Frente.Size = New System.Drawing.Size(272, 187)
        Me.pct_Frente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Frente.TabIndex = 127
        Me.pct_Frente.TabStop = False
        '
        'btn_LimpiarFrente
        '
        Me.btn_LimpiarFrente.Enabled = False
        Me.btn_LimpiarFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarFrente.Image = CType(resources.GetObject("btn_LimpiarFrente.Image"), System.Drawing.Image)
        Me.btn_LimpiarFrente.Location = New System.Drawing.Point(123, 215)
        Me.btn_LimpiarFrente.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btn_LimpiarFrente.Name = "btn_LimpiarFrente"
        Me.btn_LimpiarFrente.Size = New System.Drawing.Size(49, 31)
        Me.btn_LimpiarFrente.TabIndex = 2
        Me.btn_LimpiarFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LimpiarFrente.UseVisualStyleBackColor = True
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(151, 20)
        Me.tbx_Clave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(92, 22)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.Control_Siguiente = Me.tbx_ApellidoPaterno
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Location = New System.Drawing.Point(151, 81)
        Me.tbx_Nombres.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.Size = New System.Drawing.Size(279, 22)
        Me.tbx_Nombres.TabIndex = 7
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_ApellidoPaterno
        '
        Me.tbx_ApellidoPaterno.Control_Siguiente = Me.tbx_ApellidoMaterno
        Me.tbx_ApellidoPaterno.Filtrado = True
        Me.tbx_ApellidoPaterno.Location = New System.Drawing.Point(151, 112)
        Me.tbx_ApellidoPaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_ApellidoPaterno.MaxLength = 30
        Me.tbx_ApellidoPaterno.Name = "tbx_ApellidoPaterno"
        Me.tbx_ApellidoPaterno.Size = New System.Drawing.Size(181, 22)
        Me.tbx_ApellidoPaterno.TabIndex = 10
        Me.tbx_ApellidoPaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_ApellidoMaterno
        '
        Me.tbx_ApellidoMaterno.Control_Siguiente = Nothing
        Me.tbx_ApellidoMaterno.Filtrado = True
        Me.tbx_ApellidoMaterno.Location = New System.Drawing.Point(436, 112)
        Me.tbx_ApellidoMaterno.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_ApellidoMaterno.MaxLength = 30
        Me.tbx_ApellidoMaterno.Name = "tbx_ApellidoMaterno"
        Me.tbx_ApellidoMaterno.Size = New System.Drawing.Size(180, 22)
        Me.tbx_ApellidoMaterno.TabIndex = 13
        Me.tbx_ApellidoMaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = Nothing
        Me.cmb_Ciudad.Control_Siguiente = Nothing
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(148, 439)
        Me.cmb_Ciudad.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = True
        Me.cmb_Ciudad.Size = New System.Drawing.Size(280, 24)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 43
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'cmb_Estado
        '
        Me.cmb_Estado.Clave = Nothing
        Me.cmb_Estado.Control_Siguiente = Me.cmb_Ciudad
        Me.cmb_Estado.DisplayMember = "Nombre"
        Me.cmb_Estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Estado.Empresa = False
        Me.cmb_Estado.Filtro = Nothing
        Me.cmb_Estado.FormattingEnabled = True
        Me.cmb_Estado.Location = New System.Drawing.Point(149, 406)
        Me.cmb_Estado.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Estado.MaxDropDownItems = 20
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Pista = True
        Me.cmb_Estado.Size = New System.Drawing.Size(279, 24)
        Me.cmb_Estado.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_Estado.Sucursal = False
        Me.cmb_Estado.TabIndex = 41
        Me.cmb_Estado.Tipo = 0
        Me.cmb_Estado.ValueMember = "Id_Estado"
        '
        'tbx_NombreCompleto
        '
        Me.tbx_NombreCompleto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreCompleto.Control_Siguiente = Nothing
        Me.tbx_NombreCompleto.Filtrado = True
        Me.tbx_NombreCompleto.Location = New System.Drawing.Point(151, 52)
        Me.tbx_NombreCompleto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_NombreCompleto.MaxLength = 100
        Me.tbx_NombreCompleto.Name = "tbx_NombreCompleto"
        Me.tbx_NombreCompleto.ReadOnly = True
        Me.tbx_NombreCompleto.Size = New System.Drawing.Size(465, 22)
        Me.tbx_NombreCompleto.TabIndex = 5
        Me.tbx_NombreCompleto.TabStop = False
        Me.tbx_NombreCompleto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Numero
        '
        Me.tbx_Numero.Control_Siguiente = Nothing
        Me.tbx_Numero.Filtrado = True
        Me.tbx_Numero.Location = New System.Drawing.Point(149, 342)
        Me.tbx_Numero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Numero.MaxLength = 6
        Me.tbx_Numero.Name = "tbx_Numero"
        Me.tbx_Numero.Size = New System.Drawing.Size(72, 22)
        Me.tbx_Numero.TabIndex = 37
        Me.tbx_Numero.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Numero.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Colonia
        '
        Me.tbx_Colonia.Control_Siguiente = Nothing
        Me.tbx_Colonia.Filtrado = True
        Me.tbx_Colonia.Location = New System.Drawing.Point(148, 374)
        Me.tbx_Colonia.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Colonia.MaxLength = 100
        Me.tbx_Colonia.Name = "tbx_Colonia"
        Me.tbx_Colonia.Size = New System.Drawing.Size(467, 22)
        Me.tbx_Colonia.TabIndex = 39
        Me.tbx_Colonia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
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
        Me.cmb_Departamento.Location = New System.Drawing.Point(149, 473)
        Me.cmb_Departamento.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(279, 24)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 45
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'tbx_Calle
        '
        Me.tbx_Calle.Control_Siguiente = Nothing
        Me.tbx_Calle.Filtrado = True
        Me.tbx_Calle.Location = New System.Drawing.Point(149, 310)
        Me.tbx_Calle.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Calle.MaxLength = 100
        Me.tbx_Calle.Name = "tbx_Calle"
        Me.tbx_Calle.Size = New System.Drawing.Size(465, 22)
        Me.tbx_Calle.TabIndex = 35
        Me.tbx_Calle.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
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
        Me.cmb_Puesto.Location = New System.Drawing.Point(149, 503)
        Me.cmb_Puesto.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(279, 24)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 47
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'tbx_Telefono
        '
        Me.tbx_Telefono.Control_Siguiente = Nothing
        Me.tbx_Telefono.Filtrado = True
        Me.tbx_Telefono.Location = New System.Drawing.Point(151, 246)
        Me.tbx_Telefono.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_Telefono.MaxLength = 25
        Me.tbx_Telefono.Name = "tbx_Telefono"
        Me.tbx_Telefono.Size = New System.Drawing.Size(145, 22)
        Me.tbx_Telefono.TabIndex = 27
        Me.tbx_Telefono.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_EstadoCivil
        '
        Me.cmb_EstadoCivil.Clave = Nothing
        Me.cmb_EstadoCivil.Control_Siguiente = Nothing
        Me.cmb_EstadoCivil.DisplayMember = "Descripcion"
        Me.cmb_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoCivil.Empresa = False
        Me.cmb_EstadoCivil.Filtro = Nothing
        Me.cmb_EstadoCivil.FormattingEnabled = True
        Me.cmb_EstadoCivil.Location = New System.Drawing.Point(151, 178)
        Me.cmb_EstadoCivil.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_EstadoCivil.MaxDropDownItems = 20
        Me.cmb_EstadoCivil.Name = "cmb_EstadoCivil"
        Me.cmb_EstadoCivil.Pista = False
        Me.cmb_EstadoCivil.Size = New System.Drawing.Size(153, 24)
        Me.cmb_EstadoCivil.StoredProcedure = "Cat_EstadoCivilCombo_Get"
        Me.cmb_EstadoCivil.Sucursal = False
        Me.cmb_EstadoCivil.TabIndex = 19
        Me.cmb_EstadoCivil.Tipo = 0
        Me.cmb_EstadoCivil.ValueMember = "Id_EstadoCivil"
        '
        'tbx_MailPersonal
        '
        Me.tbx_MailPersonal.Control_Siguiente = Nothing
        Me.tbx_MailPersonal.Filtrado = True
        Me.tbx_MailPersonal.Location = New System.Drawing.Point(151, 210)
        Me.tbx_MailPersonal.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.tbx_MailPersonal.MaxLength = 50
        Me.tbx_MailPersonal.Name = "tbx_MailPersonal"
        Me.tbx_MailPersonal.Size = New System.Drawing.Size(465, 22)
        Me.tbx_MailPersonal.TabIndex = 25
        Me.tbx_MailPersonal.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Genero
        '
        Me.cmb_Genero.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_Genero.DisplayMember = "display"
        Me.cmb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Genero.FormattingEnabled = True
        Me.cmb_Genero.Location = New System.Drawing.Point(151, 143)
        Me.cmb_Genero.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.cmb_Genero.MaxDropDownItems = 20
        Me.cmb_Genero.Name = "cmb_Genero"
        Me.cmb_Genero.Size = New System.Drawing.Size(151, 24)
        Me.cmb_Genero.TabIndex = 16
        Me.cmb_Genero.ValueMember = "value"
        '
        'tbx_IdTributario
        '
        Me.tbx_IdTributario.Control_Siguiente = Me.tbx_CURP
        Me.tbx_IdTributario.Filtrado = True
        Me.tbx_IdTributario.Location = New System.Drawing.Point(416, 342)
        Me.tbx_IdTributario.Margin = New System.Windows.Forms.Padding(4)
        Me.tbx_IdTributario.MaxLength = 15
        Me.tbx_IdTributario.Name = "tbx_IdTributario"
        Me.tbx_IdTributario.Size = New System.Drawing.Size(145, 22)
        Me.tbx_IdTributario.TabIndex = 166
        Me.tbx_IdTributario.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_RFC_Extranjero
        '
        Me.lbl_RFC_Extranjero.AutoSize = True
        Me.lbl_RFC_Extranjero.Location = New System.Drawing.Point(319, 345)
        Me.lbl_RFC_Extranjero.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lbl_RFC_Extranjero.Name = "lbl_RFC_Extranjero"
        Me.lbl_RFC_Extranjero.Size = New System.Drawing.Size(88, 17)
        Me.lbl_RFC_Extranjero.TabIndex = 165
        Me.lbl_RFC_Extranjero.Text = "id Tributario:"
        '
        'frm_EmpleadosporFuera
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1272, 690)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1287, 728)
        Me.Name = "frm_EmpleadosporFuera"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Empleados por Fuera"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tbp_Listado.ResumeLayout(False)
        Me.tbp_Listado.PerformLayout()
        Me.tbp_Nuevo.ResumeLayout(False)
        Me.tbp_Nuevo.PerformLayout()
        CType(Me.pct_Codigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Firma.ResumeLayout(False)
        CType(Me.pct_Firma, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Frente.ResumeLayout(False)
        CType(Me.pct_Frente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreCompleto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreCompleto As System.Windows.Forms.Label
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents lbl_AMaterno As System.Windows.Forms.Label
    Friend WithEvents lbl_APaterno As System.Windows.Forms.Label
    Friend WithEvents tbx_ApellidoMaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_ApellidoPaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Nombres As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Departamento As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents cmb_Genero As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_EstadoCivil As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_Genero As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaNac As System.Windows.Forms.Label
    Friend WithEvents lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents Lbl_EmailPersonal As System.Windows.Forms.Label
    Friend WithEvents tbx_MailPersonal As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Telefono As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Telefono1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Calle As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Calle As System.Windows.Forms.Label
    Friend WithEvents tbx_Numero As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Colonia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents lbl_Colonia As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_Ciudad As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Estado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_CiudadNac As System.Windows.Forms.Label
    Friend WithEvents lbl_LugarNac As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tbp_Listado As System.Windows.Forms.TabPage
    Friend WithEvents tbp_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents btn_MostrarCatalogo As System.Windows.Forms.Button
    Friend WithEvents Lbl_LStatus As System.Windows.Forms.Label
    Friend WithEvents Lbl_LPuesto As System.Windows.Forms.Label
    Friend WithEvents Lbl_LDepartamento As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Frente As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ExtraerFrente As System.Windows.Forms.Button
    Friend WithEvents btn_ExaminarFrente As System.Windows.Forms.Button
    Friend WithEvents btn_TomarFrente As System.Windows.Forms.Button
    Friend WithEvents pct_Frente As System.Windows.Forms.PictureBox
    Friend WithEvents btn_LimpiarFrente As System.Windows.Forms.Button
    Friend WithEvents gbx_Firma As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ExtraerFirma As System.Windows.Forms.Button
    Friend WithEvents btn_ExaminarFirma As System.Windows.Forms.Button
    Friend WithEvents btn_TomarFirma As System.Windows.Forms.Button
    Friend WithEvents btn_LimpiarFirma As System.Windows.Forms.Button
    Friend WithEvents pct_Firma As System.Windows.Forms.PictureBox
    Friend WithEvents pct_Codigo As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_ClaveCompara As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumeroR As System.Windows.Forms.Label
    Friend WithEvents lbl_Curp As System.Windows.Forms.Label
    Friend WithEvents tbx_CURP As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_RFC As System.Windows.Forms.Label
    Friend WithEvents tbx_RFC As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NSS As System.Windows.Forms.Label
    Friend WithEvents tbx_NSS As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_IdTributario As cp_Textbox
    Friend WithEvents lbl_RFC_Extranjero As Label
End Class
