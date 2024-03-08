<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_VisitaDomiciliaria
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_VisitaDomiciliaria))
        Dim ListViewColumnSorter4 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Me.lbl_Nombre = New System.Windows.Forms.Label()
        Me.lbl_Clave = New System.Windows.Forms.Label()
        Me.Tab_Referencias = New System.Windows.Forms.TabPage()
        Me.btn_Agregar_Ref = New System.Windows.Forms.Button()
        Me.lbl_RefDefPerA = New System.Windows.Forms.Label()
        Me.lsv_Referencias = New Modulo_Reclutamiento.cp_Listview()
        Me.lbl_RefTiempoA = New System.Windows.Forms.Label()
        Me.lbl_RefTiempoAños = New System.Windows.Forms.Label()
        Me.lbl_RefDefFamA = New System.Windows.Forms.Label()
        Me.lbl_RefTiempo = New System.Windows.Forms.Label()
        Me.lbl_RefTipoPerA = New System.Windows.Forms.Label()
        Me.lbl_RefNomA = New System.Windows.Forms.Label()
        Me.lbl_RefNombre = New System.Windows.Forms.Label()
        Me.lbl_RefDefFam = New System.Windows.Forms.Label()
        Me.lbl_RefTipoPer = New System.Windows.Forms.Label()
        Me.lbl_RefDefPer = New System.Windows.Forms.Label()
        Me.btn_Borrar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Modificar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Guardar_Ref = New System.Windows.Forms.Button()
        Me.tbx_RefTiempo = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_RefDefFam = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_RefNombre = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_RefTipoPer = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.tbx_RefDefPer = New Modulo_Reclutamiento.cp_Textbox()
        Me.TabIngresosEgresos = New System.Windows.Forms.TabPage()
        Me.btn_BorrarIngresosEgresos = New System.Windows.Forms.Button()
        Me.btn_CancelarIngresosEgresos = New System.Windows.Forms.Button()
        Me.btn_GuardarIngresosEgresos = New System.Windows.Forms.Button()
        Me.grp_HabitantesDomicilio = New System.Windows.Forms.GroupBox()
        Me.dgv_Familiares = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_IngresosMensDistrubucion = New System.Windows.Forms.GroupBox()
        Me.dgv_ingresos_mensuales = New System.Windows.Forms.DataGridView()
        Me.IdIngresoEgreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_Ingreso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dt_Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.grp_AlgunaPropiedad = New System.Windows.Forms.GroupBox()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.rdb_AlgunaPropiedad_NO = New System.Windows.Forms.RadioButton()
        Me.rdb_AlgunaPropiedad_SI = New System.Windows.Forms.RadioButton()
        Me.tbx_AlgunaPropiedad_Ubicacion = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_DeudaAct_Si = New System.Windows.Forms.RadioButton()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.grp_ManejaTDC = New System.Windows.Forms.GroupBox()
        Me.tbx_TarjetaCReditoManeja = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.grp_AutoPropio = New System.Windows.Forms.GroupBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.tbx_AutoPropio_Modelo = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_AutoPropio_NO = New System.Windows.Forms.RadioButton()
        Me.tbx_AutoPropio_Marca = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_AutoPropio_SI = New System.Windows.Forms.RadioButton()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.grp_FamiliarTrabajaCorporacion = New System.Windows.Forms.GroupBox()
        Me.rdb_FamiliarTrabajaCorporacion_NO = New System.Windows.Forms.RadioButton()
        Me.rdb_FamiliarTrabajaCorporacion_SI = New System.Windows.Forms.RadioButton()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.grp_NoDependientesEcono = New System.Windows.Forms.GroupBox()
        Me.tbx_NoDependientesEcono = New Modulo_Reclutamiento.cp_Textbox()
        Me.grp_NoPersonasAportan = New System.Windows.Forms.GroupBox()
        Me.tbx_NoPersonasAportan = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.grp_AsciendeIngreso = New System.Windows.Forms.GroupBox()
        Me.tbx_AsciendeIngreso = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.grp_IngresosDedicadosAhorro = New System.Windows.Forms.GroupBox()
        Me.tbx_IngresoDedicadoAhorro = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.grp_AsciendeDeuda = New System.Windows.Forms.GroupBox()
        Me.tbx_AsciendeDeuda = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_asiendedeuda = New System.Windows.Forms.Label()
        Me.grp_DeudaPlan = New System.Windows.Forms.GroupBox()
        Me.lbl_PlanEndeudaDescA = New System.Windows.Forms.Label()
        Me.rdb_PlanEndeuda_Si = New System.Windows.Forms.RadioButton()
        Me.tbx_PlanEndeudaDesc = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_PlanEndeuda_No = New System.Windows.Forms.RadioButton()
        Me.lbl_PlanEndeudaDesc = New System.Windows.Forms.Label()
        Me.grp_DeudaActual = New System.Windows.Forms.GroupBox()
        Me.rdb_DeudaAct_No = New System.Windows.Forms.RadioButton()
        Me.Tab_Visita = New System.Windows.Forms.TabPage()
        Me.btn_Cancelar_Visita = New System.Windows.Forms.Button()
        Me.grp_VisitasDomiciliarias = New System.Windows.Forms.GroupBox()
        Me.btn_Nuevo = New System.Windows.Forms.Button()
        Me.btn_Importar = New System.Windows.Forms.Button()
        Me.lsv_VisitasDomiciliarias = New Modulo_Reclutamiento.cp_Listview()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Guardar_Visita = New System.Windows.Forms.Button()
        Me.grp_Proxima = New System.Windows.Forms.GroupBox()
        Me.tbx_MotivoProx = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_HoraProx = New System.Windows.Forms.DateTimePicker()
        Me.lbl_MotivoPAsterisco = New System.Windows.Forms.Label()
        Me.lbl_HoraPAsterisco = New System.Windows.Forms.Label()
        Me.lbl_HoraProx = New System.Windows.Forms.Label()
        Me.lbl_MotivoProx = New System.Windows.Forms.Label()
        Me.lbl_FechaPAsterisco = New System.Windows.Forms.Label()
        Me.lbl_EmpPAsterisco = New System.Windows.Forms.Label()
        Me.lbl_NombreProx = New System.Windows.Forms.Label()
        Me.btn_BuscarProx = New System.Windows.Forms.Button()
        Me.cmb_NombreProx = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_FechaProx = New System.Windows.Forms.Label()
        Me.dtp_FechaProx = New System.Windows.Forms.DateTimePicker()
        Me.grp_Visita = New System.Windows.Forms.GroupBox()
        Me.lbl_ObsAsterisco = New System.Windows.Forms.Label()
        Me.tbx_MotivoVisita = New Modulo_Reclutamiento.cp_Textbox()
        Me.rtb_Observaciones = New System.Windows.Forms.RichTextBox()
        Me.chk_ProximaVisita = New System.Windows.Forms.CheckBox()
        Me.lbl_MotivoAsterisco = New System.Windows.Forms.Label()
        Me.lbl_FechaAsterisco = New System.Windows.Forms.Label()
        Me.lbl_EmpAsterisco = New System.Windows.Forms.Label()
        Me.dtp_HoraVisita = New System.Windows.Forms.DateTimePicker()
        Me.lbl_HoraAsterisco = New System.Windows.Forms.Label()
        Me.lbl_Observaciones = New System.Windows.Forms.Label()
        Me.lbl_HoraVisita = New System.Windows.Forms.Label()
        Me.lbl_NombreVisita = New System.Windows.Forms.Label()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.cmb_Nombre = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_MotivoVisita = New System.Windows.Forms.Label()
        Me.lbl_FechaVisita = New System.Windows.Forms.Label()
        Me.dtp_FechaVisita = New System.Windows.Forms.DateTimePicker()
        Me.Tab_VisitaDomiciliaria = New System.Windows.Forms.TabControl()
        Me.TabDescripcionCasaHabitacion = New System.Windows.Forms.TabPage()
        Me.grp_Interior = New System.Windows.Forms.GroupBox()
        Me.lbl_InteriorLO = New System.Windows.Forms.Label()
        Me.rdb_InteriorLO_No = New System.Windows.Forms.RadioButton()
        Me.rdb_InteriorLO_Si = New System.Windows.Forms.RadioButton()
        Me.rtb_InteriorDesc = New System.Windows.Forms.RichTextBox()
        Me.lbl_InteriorDescA = New System.Windows.Forms.Label()
        Me.lbl_InteriorDesc = New System.Windows.Forms.Label()
        Me.grp_Mobiliario = New System.Windows.Forms.GroupBox()
        Me.lbl_MobTipoOtroA = New System.Windows.Forms.Label()
        Me.tbx_MobTipoOtro = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_MobTipoOtro = New System.Windows.Forms.Label()
        Me.lbl_MobTipoA = New System.Windows.Forms.Label()
        Me.cmb_MobTipo = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_MobTipo = New System.Windows.Forms.Label()
        Me.lbl_MobCalidadOtroA = New System.Windows.Forms.Label()
        Me.tbx_MobCalidadOtro = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_MobCalidadA = New System.Windows.Forms.Label()
        Me.cmb_MobCalidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_MobCalidad = New System.Windows.Forms.Label()
        Me.lbl_MobCalidadOtro = New System.Windows.Forms.Label()
        Me.lbl_MobiliarioA = New System.Windows.Forms.Label()
        Me.cmb_Mobiliario = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_Mobiliario = New System.Windows.Forms.Label()
        Me.grp_Fachada = New System.Windows.Forms.GroupBox()
        Me.rtb_ExteriorDesc = New System.Windows.Forms.RichTextBox()
        Me.lbl_ExteriorDescA = New System.Windows.Forms.Label()
        Me.lbl_ExteriorDesc = New System.Windows.Forms.Label()
        Me.grp_Construccion = New System.Windows.Forms.GroupBox()
        Me.lbl_ConstOtroA = New System.Windows.Forms.Label()
        Me.tbx_ConstOtro = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ConstOtro = New System.Windows.Forms.Label()
        Me.lbl_ConstruccionA = New System.Windows.Forms.Label()
        Me.cmb_Construccion = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_Construccion = New System.Windows.Forms.Label()
        Me.grp_Habitacion = New System.Windows.Forms.GroupBox()
        Me.lbl_HabitacionOtroA = New System.Windows.Forms.Label()
        Me.tbx_HabitacionOtro = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_HabitacionOtro = New System.Windows.Forms.Label()
        Me.lbl_HabitacionA = New System.Windows.Forms.Label()
        Me.cmb_Habitacion = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_Habitacion = New System.Windows.Forms.Label()
        Me.grp_DistribucionIn = New System.Windows.Forms.GroupBox()
        Me.lbl_InmCantBanosA = New System.Windows.Forms.Label()
        Me.lbl_InmCantRecamarasA = New System.Windows.Forms.Label()
        Me.chk_InmCochera = New System.Windows.Forms.CheckBox()
        Me.chk_InmPatio = New System.Windows.Forms.CheckBox()
        Me.chk_InmComedor = New System.Windows.Forms.CheckBox()
        Me.chk_InmCuartoServicio = New System.Windows.Forms.CheckBox()
        Me.chk_InmCocina = New System.Windows.Forms.CheckBox()
        Me.chk_InmSala = New System.Windows.Forms.CheckBox()
        Me.tbx_InmCantBanos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_InmCantRecamaras = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_InmuebleOtro = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_InmuebleOtro = New System.Windows.Forms.Label()
        Me.lbl_InmCantBanos = New System.Windows.Forms.Label()
        Me.lbl_InmCantRecamaras = New System.Windows.Forms.Label()
        Me.grp_DescripcionIn = New System.Windows.Forms.GroupBox()
        Me.lbl_InmCantPisosA = New System.Windows.Forms.Label()
        Me.lbl_InmCantHabitantesA = New System.Windows.Forms.Label()
        Me.lbl_InmPropietarioA = New System.Windows.Forms.Label()
        Me.tbx_InmPropietario = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_InmCantHabitantes = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_InmCantPisos = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_InmPropietario = New System.Windows.Forms.Label()
        Me.lbl_InmCantHabitantes = New System.Windows.Forms.Label()
        Me.lbl_InmCantPisos = New System.Windows.Forms.Label()
        Me.btn_Borrar_Caracteristicas = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Caracteristicas = New System.Windows.Forms.Button()
        Me.btn_Guardar_Caracteristicas = New System.Windows.Forms.Button()
        Me.Tab_Referencias.SuspendLayout()
        Me.TabIngresosEgresos.SuspendLayout()
        Me.grp_HabitantesDomicilio.SuspendLayout()
        CType(Me.dgv_Familiares, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_IngresosMensDistrubucion.SuspendLayout()
        CType(Me.dgv_ingresos_mensuales, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_AlgunaPropiedad.SuspendLayout()
        Me.grp_ManejaTDC.SuspendLayout()
        Me.grp_AutoPropio.SuspendLayout()
        Me.grp_FamiliarTrabajaCorporacion.SuspendLayout()
        Me.grp_NoDependientesEcono.SuspendLayout()
        Me.grp_NoPersonasAportan.SuspendLayout()
        Me.grp_AsciendeIngreso.SuspendLayout()
        Me.grp_IngresosDedicadosAhorro.SuspendLayout()
        Me.grp_AsciendeDeuda.SuspendLayout()
        Me.grp_DeudaPlan.SuspendLayout()
        Me.grp_DeudaActual.SuspendLayout()
        Me.Tab_Visita.SuspendLayout()
        Me.grp_VisitasDomiciliarias.SuspendLayout()
        Me.grp_Proxima.SuspendLayout()
        Me.grp_Visita.SuspendLayout()
        Me.Tab_VisitaDomiciliaria.SuspendLayout()
        Me.TabDescripcionCasaHabitacion.SuspendLayout()
        Me.grp_Interior.SuspendLayout()
        Me.grp_Mobiliario.SuspendLayout()
        Me.grp_Fachada.SuspendLayout()
        Me.grp_Construccion.SuspendLayout()
        Me.grp_Habitacion.SuspendLayout()
        Me.grp_DistribucionIn.SuspendLayout()
        Me.grp_DescripcionIn.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Nombre.Location = New System.Drawing.Point(187, 9)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(587, 31)
        Me.lbl_Nombre.TabIndex = 1
        Me.lbl_Nombre.Text = "Nombre"
        '
        'lbl_Clave
        '
        Me.lbl_Clave.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Clave.ForeColor = System.Drawing.Color.Red
        Me.lbl_Clave.Location = New System.Drawing.Point(12, 9)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(179, 31)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "0000"
        Me.lbl_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Tab_Referencias
        '
        Me.Tab_Referencias.Controls.Add(Me.btn_Agregar_Ref)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefDefPerA)
        Me.Tab_Referencias.Controls.Add(Me.lsv_Referencias)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefTiempoA)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefTiempoAños)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefDefFamA)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefTiempo)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefTipoPerA)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefNomA)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefNombre)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefDefFam)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefTipoPer)
        Me.Tab_Referencias.Controls.Add(Me.lbl_RefDefPer)
        Me.Tab_Referencias.Controls.Add(Me.btn_Borrar_Referencias)
        Me.Tab_Referencias.Controls.Add(Me.btn_Cancelar_Referencias)
        Me.Tab_Referencias.Controls.Add(Me.btn_Modificar_Referencias)
        Me.Tab_Referencias.Controls.Add(Me.btn_Guardar_Ref)
        Me.Tab_Referencias.Controls.Add(Me.tbx_RefTiempo)
        Me.Tab_Referencias.Controls.Add(Me.tbx_RefDefFam)
        Me.Tab_Referencias.Controls.Add(Me.tbx_RefNombre)
        Me.Tab_Referencias.Controls.Add(Me.tbx_RefDefPer)
        Me.Tab_Referencias.Controls.Add(Me.cmb_RefTipoPer)
        Me.Tab_Referencias.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Referencias.Name = "Tab_Referencias"
        Me.Tab_Referencias.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Referencias.Size = New System.Drawing.Size(895, 655)
        Me.Tab_Referencias.TabIndex = 2
        Me.Tab_Referencias.Text = "Referencias Vecinales"
        Me.Tab_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Agregar_Ref
        '
        Me.btn_Agregar_Ref.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Ref.Location = New System.Drawing.Point(628, 115)
        Me.btn_Agregar_Ref.Name = "btn_Agregar_Ref"
        Me.btn_Agregar_Ref.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Ref.TabIndex = 16
        Me.btn_Agregar_Ref.Text = "Agregar"
        Me.btn_Agregar_Ref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Ref.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Ref.UseVisualStyleBackColor = True
        '
        'lbl_RefDefPerA
        '
        Me.lbl_RefDefPerA.AutoSize = True
        Me.lbl_RefDefPerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefDefPerA.ForeColor = System.Drawing.Color.Red
        Me.lbl_RefDefPerA.Location = New System.Drawing.Point(577, 76)
        Me.lbl_RefDefPerA.Name = "lbl_RefDefPerA"
        Me.lbl_RefDefPerA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_RefDefPerA.TabIndex = 8
        Me.lbl_RefDefPerA.Text = "*"
        Me.lbl_RefDefPerA.Visible = False
        '
        'lsv_Referencias
        '
        Me.lsv_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Referencias.FullRowSelect = True
        Me.lsv_Referencias.HideSelection = False
        Me.lsv_Referencias.Location = New System.Drawing.Point(6, 151)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter3
        Me.lsv_Referencias.MultiSelect = False
        Me.lsv_Referencias.Name = "lsv_Referencias"
        Me.lsv_Referencias.Row1 = 20
        Me.lsv_Referencias.Row10 = 0
        Me.lsv_Referencias.Row2 = 15
        Me.lsv_Referencias.Row3 = 20
        Me.lsv_Referencias.Row4 = 20
        Me.lsv_Referencias.Row5 = 15
        Me.lsv_Referencias.Row6 = 0
        Me.lsv_Referencias.Row7 = 0
        Me.lsv_Referencias.Row8 = 0
        Me.lsv_Referencias.Row9 = 0
        Me.lsv_Referencias.Size = New System.Drawing.Size(882, 454)
        Me.lsv_Referencias.TabIndex = 17
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'lbl_RefTiempoA
        '
        Me.lbl_RefTiempoA.AutoSize = True
        Me.lbl_RefTiempoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefTiempoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_RefTiempoA.Location = New System.Drawing.Point(257, 128)
        Me.lbl_RefTiempoA.Name = "lbl_RefTiempoA"
        Me.lbl_RefTiempoA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_RefTiempoA.TabIndex = 15
        Me.lbl_RefTiempoA.Text = "*"
        '
        'lbl_RefTiempoAños
        '
        Me.lbl_RefTiempoAños.AutoSize = True
        Me.lbl_RefTiempoAños.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefTiempoAños.Location = New System.Drawing.Point(221, 128)
        Me.lbl_RefTiempoAños.Name = "lbl_RefTiempoAños"
        Me.lbl_RefTiempoAños.Size = New System.Drawing.Size(30, 13)
        Me.lbl_RefTiempoAños.TabIndex = 14
        Me.lbl_RefTiempoAños.Text = "años"
        '
        'lbl_RefDefFamA
        '
        Me.lbl_RefDefFamA.AutoSize = True
        Me.lbl_RefDefFamA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefDefFamA.ForeColor = System.Drawing.Color.Red
        Me.lbl_RefDefFamA.Location = New System.Drawing.Point(577, 102)
        Me.lbl_RefDefFamA.Name = "lbl_RefDefFamA"
        Me.lbl_RefDefFamA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_RefDefFamA.TabIndex = 11
        Me.lbl_RefDefFamA.Text = "*"
        '
        'lbl_RefTiempo
        '
        Me.lbl_RefTiempo.AutoSize = True
        Me.lbl_RefTiempo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefTiempo.Location = New System.Drawing.Point(5, 128)
        Me.lbl_RefTiempo.Name = "lbl_RefTiempo"
        Me.lbl_RefTiempo.Size = New System.Drawing.Size(154, 13)
        Me.lbl_RefTiempo.TabIndex = 12
        Me.lbl_RefTiempo.Text = "Tiempo de conocer a la Familia"
        '
        'lbl_RefTipoPerA
        '
        Me.lbl_RefTipoPerA.AutoSize = True
        Me.lbl_RefTipoPerA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefTipoPerA.ForeColor = System.Drawing.Color.Red
        Me.lbl_RefTipoPerA.Location = New System.Drawing.Point(399, 49)
        Me.lbl_RefTipoPerA.Name = "lbl_RefTipoPerA"
        Me.lbl_RefTipoPerA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_RefTipoPerA.TabIndex = 5
        Me.lbl_RefTipoPerA.Text = "*"
        '
        'lbl_RefNomA
        '
        Me.lbl_RefNomA.AutoSize = True
        Me.lbl_RefNomA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefNomA.ForeColor = System.Drawing.Color.Red
        Me.lbl_RefNomA.Location = New System.Drawing.Point(520, 23)
        Me.lbl_RefNomA.Name = "lbl_RefNomA"
        Me.lbl_RefNomA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_RefNomA.TabIndex = 2
        Me.lbl_RefNomA.Text = "*"
        '
        'lbl_RefNombre
        '
        Me.lbl_RefNombre.AutoSize = True
        Me.lbl_RefNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefNombre.Location = New System.Drawing.Point(36, 23)
        Me.lbl_RefNombre.Name = "lbl_RefNombre"
        Me.lbl_RefNombre.Size = New System.Drawing.Size(123, 13)
        Me.lbl_RefNombre.TabIndex = 0
        Me.lbl_RefNombre.Text = "Nombre del Entrevistado"
        '
        'lbl_RefDefFam
        '
        Me.lbl_RefDefFam.AutoSize = True
        Me.lbl_RefDefFam.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefDefFam.Location = New System.Drawing.Point(44, 102)
        Me.lbl_RefDefFam.Name = "lbl_RefDefFam"
        Me.lbl_RefDefFam.Size = New System.Drawing.Size(115, 13)
        Me.lbl_RefDefFam.TabIndex = 9
        Me.lbl_RefDefFam.Text = "Definición de la Familia"
        '
        'lbl_RefTipoPer
        '
        Me.lbl_RefTipoPer.AutoSize = True
        Me.lbl_RefTipoPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefTipoPer.Location = New System.Drawing.Point(74, 49)
        Me.lbl_RefTipoPer.Name = "lbl_RefTipoPer"
        Me.lbl_RefTipoPer.Size = New System.Drawing.Size(85, 13)
        Me.lbl_RefTipoPer.TabIndex = 3
        Me.lbl_RefTipoPer.Text = "Tipo de Persona"
        '
        'lbl_RefDefPer
        '
        Me.lbl_RefDefPer.AutoSize = True
        Me.lbl_RefDefPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RefDefPer.Location = New System.Drawing.Point(37, 76)
        Me.lbl_RefDefPer.Name = "lbl_RefDefPer"
        Me.lbl_RefDefPer.Size = New System.Drawing.Size(122, 13)
        Me.lbl_RefDefPer.TabIndex = 6
        Me.lbl_RefDefPer.Text = "Definición de la Persona"
        '
        'btn_Borrar_Referencias
        '
        Me.btn_Borrar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Referencias.Enabled = False
        Me.btn_Borrar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Referencias.Location = New System.Drawing.Point(298, 611)
        Me.btn_Borrar_Referencias.Name = "btn_Borrar_Referencias"
        Me.btn_Borrar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Referencias.TabIndex = 20
        Me.btn_Borrar_Referencias.Text = "&Borrar"
        Me.btn_Borrar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Referencias
        '
        Me.btn_Cancelar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Referencias.Location = New System.Drawing.Point(444, 611)
        Me.btn_Cancelar_Referencias.Name = "btn_Cancelar_Referencias"
        Me.btn_Cancelar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Referencias.TabIndex = 21
        Me.btn_Cancelar_Referencias.Text = "&Cancelar"
        Me.btn_Cancelar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Modificar_Referencias
        '
        Me.btn_Modificar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_Referencias.Enabled = False
        Me.btn_Modificar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_Referencias.Location = New System.Drawing.Point(152, 611)
        Me.btn_Modificar_Referencias.Name = "btn_Modificar_Referencias"
        Me.btn_Modificar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Referencias.TabIndex = 19
        Me.btn_Modificar_Referencias.Text = "&Modificar"
        Me.btn_Modificar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Ref
        '
        Me.btn_Guardar_Ref.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Ref.Enabled = False
        Me.btn_Guardar_Ref.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Ref.Location = New System.Drawing.Point(6, 611)
        Me.btn_Guardar_Ref.Name = "btn_Guardar_Ref"
        Me.btn_Guardar_Ref.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Ref.TabIndex = 18
        Me.btn_Guardar_Ref.Text = "&Guardar"
        Me.btn_Guardar_Ref.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Ref.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Ref.UseVisualStyleBackColor = True
        '
        'tbx_RefTiempo
        '
        Me.tbx_RefTiempo.Control_Siguiente = Me.btn_Agregar_Ref
        Me.tbx_RefTiempo.Filtrado = True
        Me.tbx_RefTiempo.Location = New System.Drawing.Point(165, 125)
        Me.tbx_RefTiempo.MaxLength = 5
        Me.tbx_RefTiempo.Name = "tbx_RefTiempo"
        Me.tbx_RefTiempo.Size = New System.Drawing.Size(50, 20)
        Me.tbx_RefTiempo.TabIndex = 13
        Me.tbx_RefTiempo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_RefDefFam
        '
        Me.tbx_RefDefFam.Control_Siguiente = Me.tbx_RefTiempo
        Me.tbx_RefDefFam.Filtrado = True
        Me.tbx_RefDefFam.Location = New System.Drawing.Point(165, 99)
        Me.tbx_RefDefFam.MaxLength = 200
        Me.tbx_RefDefFam.Name = "tbx_RefDefFam"
        Me.tbx_RefDefFam.Size = New System.Drawing.Size(406, 20)
        Me.tbx_RefDefFam.TabIndex = 10
        Me.tbx_RefDefFam.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_RefNombre
        '
        Me.tbx_RefNombre.Control_Siguiente = Me.cmb_RefTipoPer
        Me.tbx_RefNombre.Filtrado = True
        Me.tbx_RefNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_RefNombre.Location = New System.Drawing.Point(165, 20)
        Me.tbx_RefNombre.MaxLength = 100
        Me.tbx_RefNombre.Name = "tbx_RefNombre"
        Me.tbx_RefNombre.Size = New System.Drawing.Size(350, 20)
        Me.tbx_RefNombre.TabIndex = 1
        Me.tbx_RefNombre.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_RefTipoPer
        '
        Me.cmb_RefTipoPer.Control_Siguiente = Me.tbx_RefDefPer
        Me.cmb_RefTipoPer.DisplayMember = "display"
        Me.cmb_RefTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RefTipoPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_RefTipoPer.FormattingEnabled = True
        Me.cmb_RefTipoPer.Location = New System.Drawing.Point(165, 46)
        Me.cmb_RefTipoPer.MaxDropDownItems = 20
        Me.cmb_RefTipoPer.Name = "cmb_RefTipoPer"
        Me.cmb_RefTipoPer.Size = New System.Drawing.Size(228, 21)
        Me.cmb_RefTipoPer.TabIndex = 4
        Me.cmb_RefTipoPer.ValueMember = "value"
        '
        'tbx_RefDefPer
        '
        Me.tbx_RefDefPer.Control_Siguiente = Me.tbx_RefDefFam
        Me.tbx_RefDefPer.Filtrado = True
        Me.tbx_RefDefPer.Location = New System.Drawing.Point(165, 73)
        Me.tbx_RefDefPer.MaxLength = 200
        Me.tbx_RefDefPer.Name = "tbx_RefDefPer"
        Me.tbx_RefDefPer.Size = New System.Drawing.Size(406, 20)
        Me.tbx_RefDefPer.TabIndex = 7
        Me.tbx_RefDefPer.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'TabIngresosEgresos
        '
        Me.TabIngresosEgresos.Controls.Add(Me.btn_BorrarIngresosEgresos)
        Me.TabIngresosEgresos.Controls.Add(Me.btn_CancelarIngresosEgresos)
        Me.TabIngresosEgresos.Controls.Add(Me.btn_GuardarIngresosEgresos)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_HabitantesDomicilio)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_IngresosMensDistrubucion)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_AlgunaPropiedad)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_ManejaTDC)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_AutoPropio)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_FamiliarTrabajaCorporacion)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_NoDependientesEcono)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_NoPersonasAportan)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_AsciendeIngreso)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_IngresosDedicadosAhorro)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_AsciendeDeuda)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_DeudaPlan)
        Me.TabIngresosEgresos.Controls.Add(Me.grp_DeudaActual)
        Me.TabIngresosEgresos.Location = New System.Drawing.Point(4, 22)
        Me.TabIngresosEgresos.Name = "TabIngresosEgresos"
        Me.TabIngresosEgresos.Padding = New System.Windows.Forms.Padding(3)
        Me.TabIngresosEgresos.Size = New System.Drawing.Size(895, 655)
        Me.TabIngresosEgresos.TabIndex = 1
        Me.TabIngresosEgresos.Text = "Ingresos y Egresos"
        Me.TabIngresosEgresos.UseVisualStyleBackColor = True
        '
        'btn_BorrarIngresosEgresos
        '
        Me.btn_BorrarIngresosEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_BorrarIngresosEgresos.Enabled = False
        Me.btn_BorrarIngresosEgresos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_BorrarIngresosEgresos.Location = New System.Drawing.Point(173, 614)
        Me.btn_BorrarIngresosEgresos.Name = "btn_BorrarIngresosEgresos"
        Me.btn_BorrarIngresosEgresos.Size = New System.Drawing.Size(140, 30)
        Me.btn_BorrarIngresosEgresos.TabIndex = 26
        Me.btn_BorrarIngresosEgresos.Text = "&Borrar"
        Me.btn_BorrarIngresosEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BorrarIngresosEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BorrarIngresosEgresos.UseVisualStyleBackColor = True
        '
        'btn_CancelarIngresosEgresos
        '
        Me.btn_CancelarIngresosEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarIngresosEgresos.Enabled = False
        Me.btn_CancelarIngresosEgresos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarIngresosEgresos.Location = New System.Drawing.Point(319, 614)
        Me.btn_CancelarIngresosEgresos.Name = "btn_CancelarIngresosEgresos"
        Me.btn_CancelarIngresosEgresos.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarIngresosEgresos.TabIndex = 27
        Me.btn_CancelarIngresosEgresos.Text = "&Cancelar"
        Me.btn_CancelarIngresosEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarIngresosEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarIngresosEgresos.UseVisualStyleBackColor = True
        '
        'btn_GuardarIngresosEgresos
        '
        Me.btn_GuardarIngresosEgresos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarIngresosEgresos.Enabled = False
        Me.btn_GuardarIngresosEgresos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_GuardarIngresosEgresos.Location = New System.Drawing.Point(27, 614)
        Me.btn_GuardarIngresosEgresos.Name = "btn_GuardarIngresosEgresos"
        Me.btn_GuardarIngresosEgresos.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarIngresosEgresos.TabIndex = 25
        Me.btn_GuardarIngresosEgresos.Text = "&Guardar"
        Me.btn_GuardarIngresosEgresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarIngresosEgresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarIngresosEgresos.UseVisualStyleBackColor = True
        '
        'grp_HabitantesDomicilio
        '
        Me.grp_HabitantesDomicilio.Controls.Add(Me.dgv_Familiares)
        Me.grp_HabitantesDomicilio.Enabled = False
        Me.grp_HabitantesDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_HabitantesDomicilio.Location = New System.Drawing.Point(10, 374)
        Me.grp_HabitantesDomicilio.Name = "grp_HabitantesDomicilio"
        Me.grp_HabitantesDomicilio.Size = New System.Drawing.Size(435, 234)
        Me.grp_HabitantesDomicilio.TabIndex = 21
        Me.grp_HabitantesDomicilio.TabStop = False
        Me.grp_HabitantesDomicilio.Text = "¿Quiénes habitan en el domicilio?"
        '
        'dgv_Familiares
        '
        Me.dgv_Familiares.AllowUserToAddRows = False
        Me.dgv_Familiares.AllowUserToDeleteRows = False
        Me.dgv_Familiares.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_Familiares.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3})
        Me.dgv_Familiares.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_Familiares.Enabled = False
        Me.dgv_Familiares.Location = New System.Drawing.Point(3, 16)
        Me.dgv_Familiares.Name = "dgv_Familiares"
        Me.dgv_Familiares.Size = New System.Drawing.Size(429, 215)
        Me.dgv_Familiares.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nombre"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nombre"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Parentesco"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Parentesco"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Dependiente"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Dependiente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'grp_IngresosMensDistrubucion
        '
        Me.grp_IngresosMensDistrubucion.Controls.Add(Me.dgv_ingresos_mensuales)
        Me.grp_IngresosMensDistrubucion.Enabled = False
        Me.grp_IngresosMensDistrubucion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_IngresosMensDistrubucion.Location = New System.Drawing.Point(464, 374)
        Me.grp_IngresosMensDistrubucion.Name = "grp_IngresosMensDistrubucion"
        Me.grp_IngresosMensDistrubucion.Size = New System.Drawing.Size(420, 234)
        Me.grp_IngresosMensDistrubucion.TabIndex = 19
        Me.grp_IngresosMensDistrubucion.TabStop = False
        Me.grp_IngresosMensDistrubucion.Text = "Sus ingresos mensuales en que forma los distribuye:"
        '
        'dgv_ingresos_mensuales
        '
        Me.dgv_ingresos_mensuales.AllowUserToAddRows = False
        Me.dgv_ingresos_mensuales.AllowUserToDeleteRows = False
        Me.dgv_ingresos_mensuales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ingresos_mensuales.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdIngresoEgreso, Me.dt_Ingreso, Me.dt_Cantidad})
        Me.dgv_ingresos_mensuales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgv_ingresos_mensuales.Enabled = False
        Me.dgv_ingresos_mensuales.Location = New System.Drawing.Point(3, 16)
        Me.dgv_ingresos_mensuales.Name = "dgv_ingresos_mensuales"
        Me.dgv_ingresos_mensuales.Size = New System.Drawing.Size(414, 215)
        Me.dgv_ingresos_mensuales.TabIndex = 0
        '
        'IdIngresoEgreso
        '
        Me.IdIngresoEgreso.DataPropertyName = "Id_IngresosEgresos"
        Me.IdIngresoEgreso.HeaderText = "IdIE"
        Me.IdIngresoEgreso.Name = "IdIngresoEgreso"
        Me.IdIngresoEgreso.Visible = False
        '
        'dt_Ingreso
        '
        Me.dt_Ingreso.DataPropertyName = "Ingreso"
        Me.dt_Ingreso.HeaderText = "Ingreso"
        Me.dt_Ingreso.Name = "dt_Ingreso"
        Me.dt_Ingreso.ReadOnly = True
        '
        'dt_Cantidad
        '
        Me.dt_Cantidad.DataPropertyName = "Cantidad"
        Me.dt_Cantidad.HeaderText = "Cantidad"
        Me.dt_Cantidad.Name = "dt_Cantidad"
        '
        'grp_AlgunaPropiedad
        '
        Me.grp_AlgunaPropiedad.Controls.Add(Me.Label35)
        Me.grp_AlgunaPropiedad.Controls.Add(Me.rdb_AlgunaPropiedad_NO)
        Me.grp_AlgunaPropiedad.Controls.Add(Me.rdb_AlgunaPropiedad_SI)
        Me.grp_AlgunaPropiedad.Controls.Add(Me.tbx_AlgunaPropiedad_Ubicacion)
        Me.grp_AlgunaPropiedad.Controls.Add(Me.Label36)
        Me.grp_AlgunaPropiedad.Enabled = False
        Me.grp_AlgunaPropiedad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_AlgunaPropiedad.Location = New System.Drawing.Point(10, 319)
        Me.grp_AlgunaPropiedad.Name = "grp_AlgunaPropiedad"
        Me.grp_AlgunaPropiedad.Size = New System.Drawing.Size(874, 49)
        Me.grp_AlgunaPropiedad.TabIndex = 24
        Me.grp_AlgunaPropiedad.TabStop = False
        Me.grp_AlgunaPropiedad.Text = "¿Cuenta con alguna propiedad?"
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label35.Location = New System.Drawing.Point(129, 23)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(55, 13)
        Me.Label35.TabIndex = 5
        Me.Label35.Text = "Ubicacion"
        '
        'rdb_AlgunaPropiedad_NO
        '
        Me.rdb_AlgunaPropiedad_NO.AutoSize = True
        Me.rdb_AlgunaPropiedad_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_AlgunaPropiedad_NO.Location = New System.Drawing.Point(66, 22)
        Me.rdb_AlgunaPropiedad_NO.Name = "rdb_AlgunaPropiedad_NO"
        Me.rdb_AlgunaPropiedad_NO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_AlgunaPropiedad_NO.TabIndex = 6
        Me.rdb_AlgunaPropiedad_NO.TabStop = True
        Me.rdb_AlgunaPropiedad_NO.Text = "No"
        Me.rdb_AlgunaPropiedad_NO.UseVisualStyleBackColor = True
        '
        'rdb_AlgunaPropiedad_SI
        '
        Me.rdb_AlgunaPropiedad_SI.AutoSize = True
        Me.rdb_AlgunaPropiedad_SI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_AlgunaPropiedad_SI.Location = New System.Drawing.Point(26, 22)
        Me.rdb_AlgunaPropiedad_SI.Name = "rdb_AlgunaPropiedad_SI"
        Me.rdb_AlgunaPropiedad_SI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_AlgunaPropiedad_SI.TabIndex = 5
        Me.rdb_AlgunaPropiedad_SI.TabStop = True
        Me.rdb_AlgunaPropiedad_SI.Text = "Si"
        Me.rdb_AlgunaPropiedad_SI.UseVisualStyleBackColor = True
        '
        'tbx_AlgunaPropiedad_Ubicacion
        '
        Me.tbx_AlgunaPropiedad_Ubicacion.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_AlgunaPropiedad_Ubicacion.Enabled = False
        Me.tbx_AlgunaPropiedad_Ubicacion.Filtrado = True
        Me.tbx_AlgunaPropiedad_Ubicacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_AlgunaPropiedad_Ubicacion.Location = New System.Drawing.Point(190, 19)
        Me.tbx_AlgunaPropiedad_Ubicacion.MaxLength = 200
        Me.tbx_AlgunaPropiedad_Ubicacion.Name = "tbx_AlgunaPropiedad_Ubicacion"
        Me.tbx_AlgunaPropiedad_Ubicacion.Size = New System.Drawing.Size(488, 20)
        Me.tbx_AlgunaPropiedad_Ubicacion.TabIndex = 3
        Me.tbx_AlgunaPropiedad_Ubicacion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'rdb_DeudaAct_Si
        '
        Me.rdb_DeudaAct_Si.AutoSize = True
        Me.rdb_DeudaAct_Si.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_DeudaAct_Si.Location = New System.Drawing.Point(29, 22)
        Me.rdb_DeudaAct_Si.Name = "rdb_DeudaAct_Si"
        Me.rdb_DeudaAct_Si.Size = New System.Drawing.Size(34, 17)
        Me.rdb_DeudaAct_Si.TabIndex = 0
        Me.rdb_DeudaAct_Si.TabStop = True
        Me.rdb_DeudaAct_Si.Text = "Si"
        Me.rdb_DeudaAct_Si.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(6, 44)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(0, 13)
        Me.Label36.TabIndex = 2
        '
        'grp_ManejaTDC
        '
        Me.grp_ManejaTDC.Controls.Add(Me.tbx_TarjetaCReditoManeja)
        Me.grp_ManejaTDC.Controls.Add(Me.Label37)
        Me.grp_ManejaTDC.Enabled = False
        Me.grp_ManejaTDC.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_ManejaTDC.Location = New System.Drawing.Point(595, 179)
        Me.grp_ManejaTDC.Name = "grp_ManejaTDC"
        Me.grp_ManejaTDC.Size = New System.Drawing.Size(289, 74)
        Me.grp_ManejaTDC.TabIndex = 23
        Me.grp_ManejaTDC.TabStop = False
        Me.grp_ManejaTDC.Text = "¿Qué tarjetas de crédito maneja?"
        '
        'tbx_TarjetaCReditoManeja
        '
        Me.tbx_TarjetaCReditoManeja.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_TarjetaCReditoManeja.Filtrado = True
        Me.tbx_TarjetaCReditoManeja.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_TarjetaCReditoManeja.Location = New System.Drawing.Point(12, 37)
        Me.tbx_TarjetaCReditoManeja.MaxLength = 200
        Me.tbx_TarjetaCReditoManeja.Name = "tbx_TarjetaCReditoManeja"
        Me.tbx_TarjetaCReditoManeja.Size = New System.Drawing.Size(271, 20)
        Me.tbx_TarjetaCReditoManeja.TabIndex = 3
        Me.tbx_TarjetaCReditoManeja.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label37.Location = New System.Drawing.Point(6, 44)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(0, 13)
        Me.Label37.TabIndex = 2
        '
        'grp_AutoPropio
        '
        Me.grp_AutoPropio.Controls.Add(Me.Label38)
        Me.grp_AutoPropio.Controls.Add(Me.Label39)
        Me.grp_AutoPropio.Controls.Add(Me.tbx_AutoPropio_Modelo)
        Me.grp_AutoPropio.Controls.Add(Me.rdb_AutoPropio_NO)
        Me.grp_AutoPropio.Controls.Add(Me.tbx_AutoPropio_Marca)
        Me.grp_AutoPropio.Controls.Add(Me.rdb_AutoPropio_SI)
        Me.grp_AutoPropio.Controls.Add(Me.Label40)
        Me.grp_AutoPropio.Enabled = False
        Me.grp_AutoPropio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_AutoPropio.Location = New System.Drawing.Point(10, 264)
        Me.grp_AutoPropio.Name = "grp_AutoPropio"
        Me.grp_AutoPropio.Size = New System.Drawing.Size(868, 49)
        Me.grp_AutoPropio.TabIndex = 22
        Me.grp_AutoPropio.TabStop = False
        Me.grp_AutoPropio.Text = "¿Cuenta con auto propio?"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.Location = New System.Drawing.Point(501, 20)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(42, 13)
        Me.Label38.TabIndex = 8
        Me.Label38.Text = "Modelo"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.Location = New System.Drawing.Point(228, 20)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(37, 13)
        Me.Label39.TabIndex = 7
        Me.Label39.Text = "Marca"
        '
        'tbx_AutoPropio_Modelo
        '
        Me.tbx_AutoPropio_Modelo.Control_Siguiente = Nothing
        Me.tbx_AutoPropio_Modelo.Enabled = False
        Me.tbx_AutoPropio_Modelo.Filtrado = True
        Me.tbx_AutoPropio_Modelo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_AutoPropio_Modelo.Location = New System.Drawing.Point(560, 17)
        Me.tbx_AutoPropio_Modelo.MaxLength = 200
        Me.tbx_AutoPropio_Modelo.Name = "tbx_AutoPropio_Modelo"
        Me.tbx_AutoPropio_Modelo.Size = New System.Drawing.Size(173, 20)
        Me.tbx_AutoPropio_Modelo.TabIndex = 6
        Me.tbx_AutoPropio_Modelo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'rdb_AutoPropio_NO
        '
        Me.rdb_AutoPropio_NO.AutoSize = True
        Me.rdb_AutoPropio_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_AutoPropio_NO.Location = New System.Drawing.Point(57, 20)
        Me.rdb_AutoPropio_NO.Name = "rdb_AutoPropio_NO"
        Me.rdb_AutoPropio_NO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_AutoPropio_NO.TabIndex = 6
        Me.rdb_AutoPropio_NO.TabStop = True
        Me.rdb_AutoPropio_NO.Text = "No"
        Me.rdb_AutoPropio_NO.UseVisualStyleBackColor = True
        '
        'tbx_AutoPropio_Marca
        '
        Me.tbx_AutoPropio_Marca.Control_Siguiente = Nothing
        Me.tbx_AutoPropio_Marca.Enabled = False
        Me.tbx_AutoPropio_Marca.Filtrado = True
        Me.tbx_AutoPropio_Marca.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_AutoPropio_Marca.Location = New System.Drawing.Point(290, 17)
        Me.tbx_AutoPropio_Marca.MaxLength = 200
        Me.tbx_AutoPropio_Marca.Name = "tbx_AutoPropio_Marca"
        Me.tbx_AutoPropio_Marca.Size = New System.Drawing.Size(164, 20)
        Me.tbx_AutoPropio_Marca.TabIndex = 5
        Me.tbx_AutoPropio_Marca.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'rdb_AutoPropio_SI
        '
        Me.rdb_AutoPropio_SI.AutoSize = True
        Me.rdb_AutoPropio_SI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_AutoPropio_SI.Location = New System.Drawing.Point(17, 20)
        Me.rdb_AutoPropio_SI.Name = "rdb_AutoPropio_SI"
        Me.rdb_AutoPropio_SI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_AutoPropio_SI.TabIndex = 5
        Me.rdb_AutoPropio_SI.TabStop = True
        Me.rdb_AutoPropio_SI.Text = "Si"
        Me.rdb_AutoPropio_SI.UseVisualStyleBackColor = True
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.Location = New System.Drawing.Point(6, 44)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(0, 13)
        Me.Label40.TabIndex = 2
        '
        'grp_FamiliarTrabajaCorporacion
        '
        Me.grp_FamiliarTrabajaCorporacion.Controls.Add(Me.rdb_FamiliarTrabajaCorporacion_NO)
        Me.grp_FamiliarTrabajaCorporacion.Controls.Add(Me.rdb_FamiliarTrabajaCorporacion_SI)
        Me.grp_FamiliarTrabajaCorporacion.Controls.Add(Me.Label41)
        Me.grp_FamiliarTrabajaCorporacion.Enabled = False
        Me.grp_FamiliarTrabajaCorporacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_FamiliarTrabajaCorporacion.Location = New System.Drawing.Point(595, 91)
        Me.grp_FamiliarTrabajaCorporacion.Name = "grp_FamiliarTrabajaCorporacion"
        Me.grp_FamiliarTrabajaCorporacion.Size = New System.Drawing.Size(289, 72)
        Me.grp_FamiliarTrabajaCorporacion.TabIndex = 20
        Me.grp_FamiliarTrabajaCorporacion.TabStop = False
        Me.grp_FamiliarTrabajaCorporacion.Text = "¿Tiene algún familiar que trabaje en alguna corporación policíaca o de seguridad " &
    "privada?"
        '
        'rdb_FamiliarTrabajaCorporacion_NO
        '
        Me.rdb_FamiliarTrabajaCorporacion_NO.AutoSize = True
        Me.rdb_FamiliarTrabajaCorporacion_NO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_FamiliarTrabajaCorporacion_NO.Location = New System.Drawing.Point(132, 40)
        Me.rdb_FamiliarTrabajaCorporacion_NO.Name = "rdb_FamiliarTrabajaCorporacion_NO"
        Me.rdb_FamiliarTrabajaCorporacion_NO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_FamiliarTrabajaCorporacion_NO.TabIndex = 8
        Me.rdb_FamiliarTrabajaCorporacion_NO.TabStop = True
        Me.rdb_FamiliarTrabajaCorporacion_NO.Text = "No"
        Me.rdb_FamiliarTrabajaCorporacion_NO.UseVisualStyleBackColor = True
        '
        'rdb_FamiliarTrabajaCorporacion_SI
        '
        Me.rdb_FamiliarTrabajaCorporacion_SI.AutoSize = True
        Me.rdb_FamiliarTrabajaCorporacion_SI.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_FamiliarTrabajaCorporacion_SI.Location = New System.Drawing.Point(92, 40)
        Me.rdb_FamiliarTrabajaCorporacion_SI.Name = "rdb_FamiliarTrabajaCorporacion_SI"
        Me.rdb_FamiliarTrabajaCorporacion_SI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_FamiliarTrabajaCorporacion_SI.TabIndex = 7
        Me.rdb_FamiliarTrabajaCorporacion_SI.TabStop = True
        Me.rdb_FamiliarTrabajaCorporacion_SI.Text = "Si"
        Me.rdb_FamiliarTrabajaCorporacion_SI.UseVisualStyleBackColor = True
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.Location = New System.Drawing.Point(6, 44)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(0, 13)
        Me.Label41.TabIndex = 2
        '
        'grp_NoDependientesEcono
        '
        Me.grp_NoDependientesEcono.Controls.Add(Me.tbx_NoDependientesEcono)
        Me.grp_NoDependientesEcono.Enabled = False
        Me.grp_NoDependientesEcono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_NoDependientesEcono.Location = New System.Drawing.Point(336, 204)
        Me.grp_NoDependientesEcono.Name = "grp_NoDependientesEcono"
        Me.grp_NoDependientesEcono.Size = New System.Drawing.Size(246, 49)
        Me.grp_NoDependientesEcono.TabIndex = 17
        Me.grp_NoDependientesEcono.TabStop = False
        Me.grp_NoDependientesEcono.Text = "No. de dependientes económicos:"
        '
        'tbx_NoDependientesEcono
        '
        Me.tbx_NoDependientesEcono.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_NoDependientesEcono.Filtrado = True
        Me.tbx_NoDependientesEcono.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NoDependientesEcono.Location = New System.Drawing.Point(50, 19)
        Me.tbx_NoDependientesEcono.MaxLength = 200
        Me.tbx_NoDependientesEcono.Name = "tbx_NoDependientesEcono"
        Me.tbx_NoDependientesEcono.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NoDependientesEcono.TabIndex = 3
        Me.tbx_NoDependientesEcono.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'grp_NoPersonasAportan
        '
        Me.grp_NoPersonasAportan.Controls.Add(Me.tbx_NoPersonasAportan)
        Me.grp_NoPersonasAportan.Controls.Add(Me.Label42)
        Me.grp_NoPersonasAportan.Enabled = False
        Me.grp_NoPersonasAportan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_NoPersonasAportan.Location = New System.Drawing.Point(10, 204)
        Me.grp_NoPersonasAportan.Name = "grp_NoPersonasAportan"
        Me.grp_NoPersonasAportan.Size = New System.Drawing.Size(320, 49)
        Me.grp_NoPersonasAportan.TabIndex = 18
        Me.grp_NoPersonasAportan.TabStop = False
        Me.grp_NoPersonasAportan.Text = "No. de personas que aportan a la economía familiar"
        '
        'tbx_NoPersonasAportan
        '
        Me.tbx_NoPersonasAportan.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_NoPersonasAportan.Filtrado = True
        Me.tbx_NoPersonasAportan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_NoPersonasAportan.Location = New System.Drawing.Point(84, 19)
        Me.tbx_NoPersonasAportan.MaxLength = 200
        Me.tbx_NoPersonasAportan.Name = "tbx_NoPersonasAportan"
        Me.tbx_NoPersonasAportan.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NoPersonasAportan.TabIndex = 3
        Me.tbx_NoPersonasAportan.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.Location = New System.Drawing.Point(6, 44)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(0, 13)
        Me.Label42.TabIndex = 2
        '
        'grp_AsciendeIngreso
        '
        Me.grp_AsciendeIngreso.Controls.Add(Me.tbx_AsciendeIngreso)
        Me.grp_AsciendeIngreso.Controls.Add(Me.Label43)
        Me.grp_AsciendeIngreso.Enabled = False
        Me.grp_AsciendeIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_AsciendeIngreso.Location = New System.Drawing.Point(10, 149)
        Me.grp_AsciendeIngreso.Name = "grp_AsciendeIngreso"
        Me.grp_AsciendeIngreso.Size = New System.Drawing.Size(225, 49)
        Me.grp_AsciendeIngreso.TabIndex = 15
        Me.grp_AsciendeIngreso.TabStop = False
        Me.grp_AsciendeIngreso.Text = "¿A cuánto ascienden sus ingresos?"
        '
        'tbx_AsciendeIngreso
        '
        Me.tbx_AsciendeIngreso.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_AsciendeIngreso.Filtrado = True
        Me.tbx_AsciendeIngreso.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_AsciendeIngreso.Location = New System.Drawing.Point(78, 19)
        Me.tbx_AsciendeIngreso.MaxLength = 200
        Me.tbx_AsciendeIngreso.Name = "tbx_AsciendeIngreso"
        Me.tbx_AsciendeIngreso.Size = New System.Drawing.Size(131, 20)
        Me.tbx_AsciendeIngreso.TabIndex = 3
        Me.tbx_AsciendeIngreso.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.Location = New System.Drawing.Point(14, 22)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(58, 13)
        Me.Label43.TabIndex = 2
        Me.Label43.Text = "Cantidad $"
        '
        'grp_IngresosDedicadosAhorro
        '
        Me.grp_IngresosDedicadosAhorro.Controls.Add(Me.tbx_IngresoDedicadoAhorro)
        Me.grp_IngresosDedicadosAhorro.Controls.Add(Me.Label44)
        Me.grp_IngresosDedicadosAhorro.Enabled = False
        Me.grp_IngresosDedicadosAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_IngresosDedicadosAhorro.Location = New System.Drawing.Point(241, 149)
        Me.grp_IngresosDedicadosAhorro.Name = "grp_IngresosDedicadosAhorro"
        Me.grp_IngresosDedicadosAhorro.Size = New System.Drawing.Size(341, 49)
        Me.grp_IngresosDedicadosAhorro.TabIndex = 16
        Me.grp_IngresosDedicadosAhorro.TabStop = False
        Me.grp_IngresosDedicadosAhorro.Text = "De los ingresos que obtiene, ¿cuánto dedica al ahorro?"
        '
        'tbx_IngresoDedicadoAhorro
        '
        Me.tbx_IngresoDedicadoAhorro.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_IngresoDedicadoAhorro.Filtrado = True
        Me.tbx_IngresoDedicadoAhorro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_IngresoDedicadoAhorro.Location = New System.Drawing.Point(78, 19)
        Me.tbx_IngresoDedicadoAhorro.MaxLength = 200
        Me.tbx_IngresoDedicadoAhorro.Name = "tbx_IngresoDedicadoAhorro"
        Me.tbx_IngresoDedicadoAhorro.Size = New System.Drawing.Size(121, 20)
        Me.tbx_IngresoDedicadoAhorro.TabIndex = 3
        Me.tbx_IngresoDedicadoAhorro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.Location = New System.Drawing.Point(12, 22)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(60, 13)
        Me.Label44.TabIndex = 2
        Me.Label44.Text = "Cantidad %"
        '
        'grp_AsciendeDeuda
        '
        Me.grp_AsciendeDeuda.Controls.Add(Me.tbx_AsciendeDeuda)
        Me.grp_AsciendeDeuda.Controls.Add(Me.lbl_asiendedeuda)
        Me.grp_AsciendeDeuda.Enabled = False
        Me.grp_AsciendeDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_AsciendeDeuda.Location = New System.Drawing.Point(225, 91)
        Me.grp_AsciendeDeuda.Name = "grp_AsciendeDeuda"
        Me.grp_AsciendeDeuda.Size = New System.Drawing.Size(357, 52)
        Me.grp_AsciendeDeuda.TabIndex = 13
        Me.grp_AsciendeDeuda.TabStop = False
        Me.grp_AsciendeDeuda.Text = "¿A cuánto ascienden sus deudas?"
        '
        'tbx_AsciendeDeuda
        '
        Me.tbx_AsciendeDeuda.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_AsciendeDeuda.Enabled = False
        Me.tbx_AsciendeDeuda.Filtrado = True
        Me.tbx_AsciendeDeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_AsciendeDeuda.Location = New System.Drawing.Point(123, 21)
        Me.tbx_AsciendeDeuda.MaxLength = 200
        Me.tbx_AsciendeDeuda.Name = "tbx_AsciendeDeuda"
        Me.tbx_AsciendeDeuda.Size = New System.Drawing.Size(132, 20)
        Me.tbx_AsciendeDeuda.TabIndex = 3
        Me.tbx_AsciendeDeuda.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_asiendedeuda
        '
        Me.lbl_asiendedeuda.AutoSize = True
        Me.lbl_asiendedeuda.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_asiendedeuda.Location = New System.Drawing.Point(49, 24)
        Me.lbl_asiendedeuda.Name = "lbl_asiendedeuda"
        Me.lbl_asiendedeuda.Size = New System.Drawing.Size(58, 13)
        Me.lbl_asiendedeuda.TabIndex = 2
        Me.lbl_asiendedeuda.Text = "Cantidad $"
        '
        'grp_DeudaPlan
        '
        Me.grp_DeudaPlan.Controls.Add(Me.lbl_PlanEndeudaDescA)
        Me.grp_DeudaPlan.Controls.Add(Me.rdb_PlanEndeuda_Si)
        Me.grp_DeudaPlan.Controls.Add(Me.tbx_PlanEndeudaDesc)
        Me.grp_DeudaPlan.Controls.Add(Me.rdb_PlanEndeuda_No)
        Me.grp_DeudaPlan.Controls.Add(Me.lbl_PlanEndeudaDesc)
        Me.grp_DeudaPlan.Enabled = False
        Me.grp_DeudaPlan.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_DeudaPlan.Location = New System.Drawing.Point(10, 33)
        Me.grp_DeudaPlan.Name = "grp_DeudaPlan"
        Me.grp_DeudaPlan.Size = New System.Drawing.Size(874, 52)
        Me.grp_DeudaPlan.TabIndex = 12
        Me.grp_DeudaPlan.TabStop = False
        Me.grp_DeudaPlan.Text = "Planes de Endeudamiento?"
        '
        'lbl_PlanEndeudaDescA
        '
        Me.lbl_PlanEndeudaDescA.AutoSize = True
        Me.lbl_PlanEndeudaDescA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PlanEndeudaDescA.ForeColor = System.Drawing.Color.Red
        Me.lbl_PlanEndeudaDescA.Location = New System.Drawing.Point(775, 23)
        Me.lbl_PlanEndeudaDescA.Name = "lbl_PlanEndeudaDescA"
        Me.lbl_PlanEndeudaDescA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_PlanEndeudaDescA.TabIndex = 4
        Me.lbl_PlanEndeudaDescA.Text = "*"
        '
        'rdb_PlanEndeuda_Si
        '
        Me.rdb_PlanEndeuda_Si.AutoSize = True
        Me.rdb_PlanEndeuda_Si.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_PlanEndeuda_Si.Location = New System.Drawing.Point(29, 24)
        Me.rdb_PlanEndeuda_Si.Name = "rdb_PlanEndeuda_Si"
        Me.rdb_PlanEndeuda_Si.Size = New System.Drawing.Size(34, 17)
        Me.rdb_PlanEndeuda_Si.TabIndex = 0
        Me.rdb_PlanEndeuda_Si.TabStop = True
        Me.rdb_PlanEndeuda_Si.Text = "Si"
        Me.rdb_PlanEndeuda_Si.UseVisualStyleBackColor = True
        '
        'tbx_PlanEndeudaDesc
        '
        Me.tbx_PlanEndeudaDesc.Control_Siguiente = Me.rdb_DeudaAct_Si
        Me.tbx_PlanEndeudaDesc.Enabled = False
        Me.tbx_PlanEndeudaDesc.Filtrado = True
        Me.tbx_PlanEndeudaDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_PlanEndeudaDesc.Location = New System.Drawing.Point(258, 21)
        Me.tbx_PlanEndeudaDesc.MaxLength = 200
        Me.tbx_PlanEndeudaDesc.Name = "tbx_PlanEndeudaDesc"
        Me.tbx_PlanEndeudaDesc.Size = New System.Drawing.Size(511, 20)
        Me.tbx_PlanEndeudaDesc.TabIndex = 3
        Me.tbx_PlanEndeudaDesc.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'rdb_PlanEndeuda_No
        '
        Me.rdb_PlanEndeuda_No.AutoSize = True
        Me.rdb_PlanEndeuda_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_PlanEndeuda_No.Location = New System.Drawing.Point(78, 24)
        Me.rdb_PlanEndeuda_No.Name = "rdb_PlanEndeuda_No"
        Me.rdb_PlanEndeuda_No.Size = New System.Drawing.Size(39, 17)
        Me.rdb_PlanEndeuda_No.TabIndex = 1
        Me.rdb_PlanEndeuda_No.TabStop = True
        Me.rdb_PlanEndeuda_No.Text = "No"
        Me.rdb_PlanEndeuda_No.UseVisualStyleBackColor = True
        '
        'lbl_PlanEndeudaDesc
        '
        Me.lbl_PlanEndeudaDesc.AutoSize = True
        Me.lbl_PlanEndeudaDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_PlanEndeudaDesc.Location = New System.Drawing.Point(189, 21)
        Me.lbl_PlanEndeudaDesc.Name = "lbl_PlanEndeudaDesc"
        Me.lbl_PlanEndeudaDesc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_PlanEndeudaDesc.TabIndex = 2
        Me.lbl_PlanEndeudaDesc.Text = "Descripción"
        '
        'grp_DeudaActual
        '
        Me.grp_DeudaActual.Controls.Add(Me.rdb_DeudaAct_No)
        Me.grp_DeudaActual.Controls.Add(Me.rdb_DeudaAct_Si)
        Me.grp_DeudaActual.Enabled = False
        Me.grp_DeudaActual.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_DeudaActual.Location = New System.Drawing.Point(10, 91)
        Me.grp_DeudaActual.Name = "grp_DeudaActual"
        Me.grp_DeudaActual.Size = New System.Drawing.Size(209, 52)
        Me.grp_DeudaActual.TabIndex = 14
        Me.grp_DeudaActual.TabStop = False
        Me.grp_DeudaActual.Text = "Actualmente tiene Deudas?"
        '
        'rdb_DeudaAct_No
        '
        Me.rdb_DeudaAct_No.AutoSize = True
        Me.rdb_DeudaAct_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_DeudaAct_No.Location = New System.Drawing.Point(78, 22)
        Me.rdb_DeudaAct_No.Name = "rdb_DeudaAct_No"
        Me.rdb_DeudaAct_No.Size = New System.Drawing.Size(39, 17)
        Me.rdb_DeudaAct_No.TabIndex = 1
        Me.rdb_DeudaAct_No.TabStop = True
        Me.rdb_DeudaAct_No.Text = "No"
        Me.rdb_DeudaAct_No.UseVisualStyleBackColor = True
        '
        'Tab_Visita
        '
        Me.Tab_Visita.Controls.Add(Me.btn_Cancelar_Visita)
        Me.Tab_Visita.Controls.Add(Me.grp_VisitasDomiciliarias)
        Me.Tab_Visita.Controls.Add(Me.btn_Cerrar)
        Me.Tab_Visita.Controls.Add(Me.btn_Guardar_Visita)
        Me.Tab_Visita.Controls.Add(Me.grp_Proxima)
        Me.Tab_Visita.Controls.Add(Me.grp_Visita)
        Me.Tab_Visita.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Visita.Name = "Tab_Visita"
        Me.Tab_Visita.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Visita.Size = New System.Drawing.Size(895, 655)
        Me.Tab_Visita.TabIndex = 0
        Me.Tab_Visita.Text = "Visita"
        Me.Tab_Visita.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Visita
        '
        Me.btn_Cancelar_Visita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Visita.Enabled = False
        Me.btn_Cancelar_Visita.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Visita.Location = New System.Drawing.Point(152, 605)
        Me.btn_Cancelar_Visita.Name = "btn_Cancelar_Visita"
        Me.btn_Cancelar_Visita.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Visita.TabIndex = 4
        Me.btn_Cancelar_Visita.Text = "&Cancelar"
        Me.btn_Cancelar_Visita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Visita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Visita.UseVisualStyleBackColor = True
        '
        'grp_VisitasDomiciliarias
        '
        Me.grp_VisitasDomiciliarias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_VisitasDomiciliarias.Controls.Add(Me.btn_Nuevo)
        Me.grp_VisitasDomiciliarias.Controls.Add(Me.btn_Importar)
        Me.grp_VisitasDomiciliarias.Controls.Add(Me.lsv_VisitasDomiciliarias)
        Me.grp_VisitasDomiciliarias.Controls.Add(Me.btn_Modificar)
        Me.grp_VisitasDomiciliarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_VisitasDomiciliarias.Location = New System.Drawing.Point(6, 7)
        Me.grp_VisitasDomiciliarias.Name = "grp_VisitasDomiciliarias"
        Me.grp_VisitasDomiciliarias.Size = New System.Drawing.Size(886, 289)
        Me.grp_VisitasDomiciliarias.TabIndex = 0
        Me.grp_VisitasDomiciliarias.TabStop = False
        Me.grp_VisitasDomiciliarias.Text = "Visitas Domiciliarias"
        '
        'btn_Nuevo
        '
        Me.btn_Nuevo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Nuevo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Nuevo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Agregar
        Me.btn_Nuevo.Location = New System.Drawing.Point(6, 253)
        Me.btn_Nuevo.Name = "btn_Nuevo"
        Me.btn_Nuevo.Size = New System.Drawing.Size(140, 30)
        Me.btn_Nuevo.TabIndex = 1
        Me.btn_Nuevo.Text = "&Nueva Visita"
        Me.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Nuevo.UseVisualStyleBackColor = True
        '
        'btn_Importar
        '
        Me.btn_Importar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Importar.Enabled = False
        Me.btn_Importar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Importar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_Importar.Location = New System.Drawing.Point(298, 253)
        Me.btn_Importar.Name = "btn_Importar"
        Me.btn_Importar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Importar.TabIndex = 3
        Me.btn_Importar.Text = "&Importar/Exportar"
        Me.btn_Importar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Importar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Importar.UseVisualStyleBackColor = True
        '
        'lsv_VisitasDomiciliarias
        '
        Me.lsv_VisitasDomiciliarias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_VisitasDomiciliarias.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_VisitasDomiciliarias.FullRowSelect = True
        Me.lsv_VisitasDomiciliarias.HideSelection = False
        Me.lsv_VisitasDomiciliarias.Location = New System.Drawing.Point(6, 20)
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_VisitasDomiciliarias.Lvs = ListViewColumnSorter4
        Me.lsv_VisitasDomiciliarias.MultiSelect = False
        Me.lsv_VisitasDomiciliarias.Name = "lsv_VisitasDomiciliarias"
        Me.lsv_VisitasDomiciliarias.Row1 = 10
        Me.lsv_VisitasDomiciliarias.Row10 = 0
        Me.lsv_VisitasDomiciliarias.Row2 = 10
        Me.lsv_VisitasDomiciliarias.Row3 = 20
        Me.lsv_VisitasDomiciliarias.Row4 = 55
        Me.lsv_VisitasDomiciliarias.Row5 = 0
        Me.lsv_VisitasDomiciliarias.Row6 = 0
        Me.lsv_VisitasDomiciliarias.Row7 = 0
        Me.lsv_VisitasDomiciliarias.Row8 = 0
        Me.lsv_VisitasDomiciliarias.Row9 = 0
        Me.lsv_VisitasDomiciliarias.Size = New System.Drawing.Size(874, 227)
        Me.lsv_VisitasDomiciliarias.TabIndex = 0
        Me.lsv_VisitasDomiciliarias.UseCompatibleStateImageBehavior = False
        Me.lsv_VisitasDomiciliarias.View = System.Windows.Forms.View.Details
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(152, 253)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 2
        Me.btn_Modificar.Text = "&Modificar Visita"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(752, 605)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Visita
        '
        Me.btn_Guardar_Visita.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Visita.Enabled = False
        Me.btn_Guardar_Visita.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Visita.Location = New System.Drawing.Point(6, 605)
        Me.btn_Guardar_Visita.Name = "btn_Guardar_Visita"
        Me.btn_Guardar_Visita.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Visita.TabIndex = 3
        Me.btn_Guardar_Visita.Text = "&Guardar"
        Me.btn_Guardar_Visita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Visita.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Visita.UseVisualStyleBackColor = True
        '
        'grp_Proxima
        '
        Me.grp_Proxima.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Proxima.Controls.Add(Me.tbx_MotivoProx)
        Me.grp_Proxima.Controls.Add(Me.dtp_HoraProx)
        Me.grp_Proxima.Controls.Add(Me.lbl_MotivoPAsterisco)
        Me.grp_Proxima.Controls.Add(Me.lbl_HoraPAsterisco)
        Me.grp_Proxima.Controls.Add(Me.lbl_HoraProx)
        Me.grp_Proxima.Controls.Add(Me.lbl_MotivoProx)
        Me.grp_Proxima.Controls.Add(Me.lbl_FechaPAsterisco)
        Me.grp_Proxima.Controls.Add(Me.lbl_EmpPAsterisco)
        Me.grp_Proxima.Controls.Add(Me.lbl_NombreProx)
        Me.grp_Proxima.Controls.Add(Me.btn_BuscarProx)
        Me.grp_Proxima.Controls.Add(Me.cmb_NombreProx)
        Me.grp_Proxima.Controls.Add(Me.lbl_FechaProx)
        Me.grp_Proxima.Controls.Add(Me.dtp_FechaProx)
        Me.grp_Proxima.Enabled = False
        Me.grp_Proxima.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Proxima.Location = New System.Drawing.Point(6, 501)
        Me.grp_Proxima.Name = "grp_Proxima"
        Me.grp_Proxima.Size = New System.Drawing.Size(886, 98)
        Me.grp_Proxima.TabIndex = 2
        Me.grp_Proxima.TabStop = False
        Me.grp_Proxima.Text = "Próxima Visita"
        '
        'tbx_MotivoProx
        '
        Me.tbx_MotivoProx.Control_Siguiente = Me.btn_Guardar_Visita
        Me.tbx_MotivoProx.Filtrado = True
        Me.tbx_MotivoProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MotivoProx.Location = New System.Drawing.Point(112, 72)
        Me.tbx_MotivoProx.MaxLength = 100
        Me.tbx_MotivoProx.Name = "tbx_MotivoProx"
        Me.tbx_MotivoProx.Size = New System.Drawing.Size(449, 20)
        Me.tbx_MotivoProx.TabIndex = 12
        Me.tbx_MotivoProx.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'dtp_HoraProx
        '
        Me.dtp_HoraProx.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraProx.CustomFormat = "HH:mm"
        Me.dtp_HoraProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraProx.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraProx.Location = New System.Drawing.Point(314, 46)
        Me.dtp_HoraProx.Name = "dtp_HoraProx"
        Me.dtp_HoraProx.ShowUpDown = True
        Me.dtp_HoraProx.Size = New System.Drawing.Size(62, 20)
        Me.dtp_HoraProx.TabIndex = 9
        '
        'lbl_MotivoPAsterisco
        '
        Me.lbl_MotivoPAsterisco.AutoSize = True
        Me.lbl_MotivoPAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MotivoPAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_MotivoPAsterisco.Location = New System.Drawing.Point(567, 75)
        Me.lbl_MotivoPAsterisco.Name = "lbl_MotivoPAsterisco"
        Me.lbl_MotivoPAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MotivoPAsterisco.TabIndex = 13
        Me.lbl_MotivoPAsterisco.Text = "*"
        '
        'lbl_HoraPAsterisco
        '
        Me.lbl_HoraPAsterisco.AutoSize = True
        Me.lbl_HoraPAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraPAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_HoraPAsterisco.Location = New System.Drawing.Point(382, 49)
        Me.lbl_HoraPAsterisco.Name = "lbl_HoraPAsterisco"
        Me.lbl_HoraPAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_HoraPAsterisco.TabIndex = 10
        Me.lbl_HoraPAsterisco.Text = "*"
        Me.lbl_HoraPAsterisco.Visible = False
        '
        'lbl_HoraProx
        '
        Me.lbl_HoraProx.AutoSize = True
        Me.lbl_HoraProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraProx.Location = New System.Drawing.Point(235, 49)
        Me.lbl_HoraProx.Name = "lbl_HoraProx"
        Me.lbl_HoraProx.Size = New System.Drawing.Size(73, 13)
        Me.lbl_HoraProx.TabIndex = 8
        Me.lbl_HoraProx.Text = "Hora de Visita"
        '
        'lbl_MotivoProx
        '
        Me.lbl_MotivoProx.AutoSize = True
        Me.lbl_MotivoProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MotivoProx.Location = New System.Drawing.Point(13, 75)
        Me.lbl_MotivoProx.Name = "lbl_MotivoProx"
        Me.lbl_MotivoProx.Size = New System.Drawing.Size(93, 13)
        Me.lbl_MotivoProx.TabIndex = 11
        Me.lbl_MotivoProx.Text = "Motivo de la Visita"
        '
        'lbl_FechaPAsterisco
        '
        Me.lbl_FechaPAsterisco.AutoSize = True
        Me.lbl_FechaPAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaPAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_FechaPAsterisco.Location = New System.Drawing.Point(218, 49)
        Me.lbl_FechaPAsterisco.Name = "lbl_FechaPAsterisco"
        Me.lbl_FechaPAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_FechaPAsterisco.TabIndex = 7
        Me.lbl_FechaPAsterisco.Text = "*"
        '
        'lbl_EmpPAsterisco
        '
        Me.lbl_EmpPAsterisco.AutoSize = True
        Me.lbl_EmpPAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpPAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_EmpPAsterisco.Location = New System.Drawing.Point(567, 22)
        Me.lbl_EmpPAsterisco.Name = "lbl_EmpPAsterisco"
        Me.lbl_EmpPAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_EmpPAsterisco.TabIndex = 4
        Me.lbl_EmpPAsterisco.Text = "*"
        '
        'lbl_NombreProx
        '
        Me.lbl_NombreProx.AutoSize = True
        Me.lbl_NombreProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreProx.Location = New System.Drawing.Point(37, 22)
        Me.lbl_NombreProx.Name = "lbl_NombreProx"
        Me.lbl_NombreProx.Size = New System.Drawing.Size(69, 13)
        Me.lbl_NombreProx.TabIndex = 0
        Me.lbl_NombreProx.Text = "Entrevistador"
        Me.lbl_NombreProx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_BuscarProx
        '
        Me.btn_BuscarProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BuscarProx.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_BuscarProx.Location = New System.Drawing.Point(524, 16)
        Me.btn_BuscarProx.Name = "btn_BuscarProx"
        Me.btn_BuscarProx.Size = New System.Drawing.Size(37, 25)
        Me.btn_BuscarProx.TabIndex = 3
        Me.btn_BuscarProx.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarProx.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarProx.UseVisualStyleBackColor = True
        '
        'cmb_NombreProx
        '
        Me.cmb_NombreProx.Clave = "Clave_Empleado"
        Me.cmb_NombreProx.Control_Siguiente = Me.btn_BuscarProx
        Me.cmb_NombreProx.DisplayMember = "Nombre"
        Me.cmb_NombreProx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NombreProx.Empresa = False
        Me.cmb_NombreProx.Filtro = Nothing
        Me.cmb_NombreProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_NombreProx.FormattingEnabled = True
        Me.cmb_NombreProx.Location = New System.Drawing.Point(112, 19)
        Me.cmb_NombreProx.MaxDropDownItems = 20
        Me.cmb_NombreProx.Name = "cmb_NombreProx"
        Me.cmb_NombreProx.Pista = False
        Me.cmb_NombreProx.Size = New System.Drawing.Size(406, 21)
        Me.cmb_NombreProx.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_NombreProx.Sucursal = True
        Me.cmb_NombreProx.TabIndex = 2
        Me.cmb_NombreProx.Tipo = 0
        Me.cmb_NombreProx.ValueMember = "Id_Empleado"
        '
        'lbl_FechaProx
        '
        Me.lbl_FechaProx.AutoSize = True
        Me.lbl_FechaProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaProx.Location = New System.Drawing.Point(15, 49)
        Me.lbl_FechaProx.Name = "lbl_FechaProx"
        Me.lbl_FechaProx.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FechaProx.TabIndex = 5
        Me.lbl_FechaProx.Text = "Fecha de la Visita"
        '
        'dtp_FechaProx
        '
        Me.dtp_FechaProx.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaProx.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaProx.Location = New System.Drawing.Point(112, 46)
        Me.dtp_FechaProx.Name = "dtp_FechaProx"
        Me.dtp_FechaProx.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaProx.TabIndex = 6
        Me.dtp_FechaProx.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'grp_Visita
        '
        Me.grp_Visita.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grp_Visita.Controls.Add(Me.lbl_ObsAsterisco)
        Me.grp_Visita.Controls.Add(Me.tbx_MotivoVisita)
        Me.grp_Visita.Controls.Add(Me.chk_ProximaVisita)
        Me.grp_Visita.Controls.Add(Me.lbl_MotivoAsterisco)
        Me.grp_Visita.Controls.Add(Me.lbl_FechaAsterisco)
        Me.grp_Visita.Controls.Add(Me.lbl_EmpAsterisco)
        Me.grp_Visita.Controls.Add(Me.dtp_HoraVisita)
        Me.grp_Visita.Controls.Add(Me.lbl_HoraAsterisco)
        Me.grp_Visita.Controls.Add(Me.rtb_Observaciones)
        Me.grp_Visita.Controls.Add(Me.lbl_Observaciones)
        Me.grp_Visita.Controls.Add(Me.lbl_HoraVisita)
        Me.grp_Visita.Controls.Add(Me.lbl_NombreVisita)
        Me.grp_Visita.Controls.Add(Me.btn_Buscar)
        Me.grp_Visita.Controls.Add(Me.cmb_Nombre)
        Me.grp_Visita.Controls.Add(Me.lbl_MotivoVisita)
        Me.grp_Visita.Controls.Add(Me.lbl_FechaVisita)
        Me.grp_Visita.Controls.Add(Me.dtp_FechaVisita)
        Me.grp_Visita.Enabled = False
        Me.grp_Visita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Visita.Location = New System.Drawing.Point(6, 302)
        Me.grp_Visita.Name = "grp_Visita"
        Me.grp_Visita.Size = New System.Drawing.Size(886, 193)
        Me.grp_Visita.TabIndex = 1
        Me.grp_Visita.TabStop = False
        Me.grp_Visita.Text = "Visita Domiciliaria"
        '
        'lbl_ObsAsterisco
        '
        Me.lbl_ObsAsterisco.AutoSize = True
        Me.lbl_ObsAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ObsAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_ObsAsterisco.Location = New System.Drawing.Point(869, 103)
        Me.lbl_ObsAsterisco.Name = "lbl_ObsAsterisco"
        Me.lbl_ObsAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ObsAsterisco.TabIndex = 16
        Me.lbl_ObsAsterisco.Text = "*"
        '
        'tbx_MotivoVisita
        '
        Me.tbx_MotivoVisita.Control_Siguiente = Me.rtb_Observaciones
        Me.tbx_MotivoVisita.Filtrado = True
        Me.tbx_MotivoVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MotivoVisita.Location = New System.Drawing.Point(112, 74)
        Me.tbx_MotivoVisita.MaxLength = 100
        Me.tbx_MotivoVisita.Name = "tbx_MotivoVisita"
        Me.tbx_MotivoVisita.Size = New System.Drawing.Size(449, 20)
        Me.tbx_MotivoVisita.TabIndex = 12
        Me.tbx_MotivoVisita.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'rtb_Observaciones
        '
        Me.rtb_Observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_Observaciones.Location = New System.Drawing.Point(112, 102)
        Me.rtb_Observaciones.MaxLength = 500
        Me.rtb_Observaciones.Name = "rtb_Observaciones"
        Me.rtb_Observaciones.Size = New System.Drawing.Size(751, 58)
        Me.rtb_Observaciones.TabIndex = 15
        Me.rtb_Observaciones.Text = ""
        '
        'chk_ProximaVisita
        '
        Me.chk_ProximaVisita.AutoSize = True
        Me.chk_ProximaVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_ProximaVisita.Location = New System.Drawing.Point(112, 166)
        Me.chk_ProximaVisita.Name = "chk_ProximaVisita"
        Me.chk_ProximaVisita.Size = New System.Drawing.Size(129, 17)
        Me.chk_ProximaVisita.TabIndex = 17
        Me.chk_ProximaVisita.Text = "Programar otra Visita?"
        Me.chk_ProximaVisita.UseVisualStyleBackColor = True
        '
        'lbl_MotivoAsterisco
        '
        Me.lbl_MotivoAsterisco.AutoSize = True
        Me.lbl_MotivoAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MotivoAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_MotivoAsterisco.Location = New System.Drawing.Point(567, 75)
        Me.lbl_MotivoAsterisco.Name = "lbl_MotivoAsterisco"
        Me.lbl_MotivoAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MotivoAsterisco.TabIndex = 13
        Me.lbl_MotivoAsterisco.Text = "*"
        '
        'lbl_FechaAsterisco
        '
        Me.lbl_FechaAsterisco.AutoSize = True
        Me.lbl_FechaAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_FechaAsterisco.Location = New System.Drawing.Point(218, 51)
        Me.lbl_FechaAsterisco.Name = "lbl_FechaAsterisco"
        Me.lbl_FechaAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_FechaAsterisco.TabIndex = 7
        Me.lbl_FechaAsterisco.Text = "*"
        '
        'lbl_EmpAsterisco
        '
        Me.lbl_EmpAsterisco.AutoSize = True
        Me.lbl_EmpAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_EmpAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_EmpAsterisco.Location = New System.Drawing.Point(567, 22)
        Me.lbl_EmpAsterisco.Name = "lbl_EmpAsterisco"
        Me.lbl_EmpAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_EmpAsterisco.TabIndex = 4
        Me.lbl_EmpAsterisco.Text = "*"
        '
        'dtp_HoraVisita
        '
        Me.dtp_HoraVisita.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraVisita.CustomFormat = "HH:mm"
        Me.dtp_HoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_HoraVisita.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraVisita.Location = New System.Drawing.Point(314, 48)
        Me.dtp_HoraVisita.Name = "dtp_HoraVisita"
        Me.dtp_HoraVisita.ShowUpDown = True
        Me.dtp_HoraVisita.Size = New System.Drawing.Size(62, 20)
        Me.dtp_HoraVisita.TabIndex = 9
        '
        'lbl_HoraAsterisco
        '
        Me.lbl_HoraAsterisco.AutoSize = True
        Me.lbl_HoraAsterisco.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraAsterisco.ForeColor = System.Drawing.Color.Red
        Me.lbl_HoraAsterisco.Location = New System.Drawing.Point(382, 51)
        Me.lbl_HoraAsterisco.Name = "lbl_HoraAsterisco"
        Me.lbl_HoraAsterisco.Size = New System.Drawing.Size(11, 13)
        Me.lbl_HoraAsterisco.TabIndex = 10
        Me.lbl_HoraAsterisco.Text = "*"
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Observaciones.Location = New System.Drawing.Point(28, 105)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(78, 13)
        Me.lbl_Observaciones.TabIndex = 14
        Me.lbl_Observaciones.Text = "Observaciones"
        '
        'lbl_HoraVisita
        '
        Me.lbl_HoraVisita.AutoSize = True
        Me.lbl_HoraVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HoraVisita.Location = New System.Drawing.Point(235, 51)
        Me.lbl_HoraVisita.Name = "lbl_HoraVisita"
        Me.lbl_HoraVisita.Size = New System.Drawing.Size(73, 13)
        Me.lbl_HoraVisita.TabIndex = 8
        Me.lbl_HoraVisita.Text = "Hora de Visita"
        '
        'lbl_NombreVisita
        '
        Me.lbl_NombreVisita.AutoSize = True
        Me.lbl_NombreVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreVisita.Location = New System.Drawing.Point(37, 24)
        Me.lbl_NombreVisita.Name = "lbl_NombreVisita"
        Me.lbl_NombreVisita.Size = New System.Drawing.Size(69, 13)
        Me.lbl_NombreVisita.TabIndex = 0
        Me.lbl_NombreVisita.Text = "Entrevistador"
        Me.lbl_NombreVisita.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(524, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(37, 25)
        Me.btn_Buscar.TabIndex = 3
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'cmb_Nombre
        '
        Me.cmb_Nombre.Clave = "Clave_Empleado"
        Me.cmb_Nombre.Control_Siguiente = Me.btn_Buscar
        Me.cmb_Nombre.DisplayMember = "Nombre"
        Me.cmb_Nombre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Nombre.Empresa = False
        Me.cmb_Nombre.Filtro = Nothing
        Me.cmb_Nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Nombre.FormattingEnabled = True
        Me.cmb_Nombre.Location = New System.Drawing.Point(112, 21)
        Me.cmb_Nombre.MaxDropDownItems = 20
        Me.cmb_Nombre.Name = "cmb_Nombre"
        Me.cmb_Nombre.Pista = False
        Me.cmb_Nombre.Size = New System.Drawing.Size(406, 21)
        Me.cmb_Nombre.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_Nombre.Sucursal = True
        Me.cmb_Nombre.TabIndex = 2
        Me.cmb_Nombre.Tipo = 0
        Me.cmb_Nombre.ValueMember = "Id_Empleado"
        '
        'lbl_MotivoVisita
        '
        Me.lbl_MotivoVisita.AutoSize = True
        Me.lbl_MotivoVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MotivoVisita.Location = New System.Drawing.Point(13, 77)
        Me.lbl_MotivoVisita.Name = "lbl_MotivoVisita"
        Me.lbl_MotivoVisita.Size = New System.Drawing.Size(93, 13)
        Me.lbl_MotivoVisita.TabIndex = 11
        Me.lbl_MotivoVisita.Text = "Motivo de la Visita"
        '
        'lbl_FechaVisita
        '
        Me.lbl_FechaVisita.AutoSize = True
        Me.lbl_FechaVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaVisita.Location = New System.Drawing.Point(15, 51)
        Me.lbl_FechaVisita.Name = "lbl_FechaVisita"
        Me.lbl_FechaVisita.Size = New System.Drawing.Size(91, 13)
        Me.lbl_FechaVisita.TabIndex = 5
        Me.lbl_FechaVisita.Text = "Fecha de la Visita"
        '
        'dtp_FechaVisita
        '
        Me.dtp_FechaVisita.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp_FechaVisita.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVisita.Location = New System.Drawing.Point(112, 48)
        Me.dtp_FechaVisita.Name = "dtp_FechaVisita"
        Me.dtp_FechaVisita.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaVisita.TabIndex = 6
        Me.dtp_FechaVisita.Value = New Date(2010, 3, 31, 0, 0, 0, 0)
        '
        'Tab_VisitaDomiciliaria
        '
        Me.Tab_VisitaDomiciliaria.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_VisitaDomiciliaria.Controls.Add(Me.Tab_Visita)
        Me.Tab_VisitaDomiciliaria.Controls.Add(Me.TabIngresosEgresos)
        Me.Tab_VisitaDomiciliaria.Controls.Add(Me.Tab_Referencias)
        Me.Tab_VisitaDomiciliaria.Controls.Add(Me.TabDescripcionCasaHabitacion)
        Me.Tab_VisitaDomiciliaria.Location = New System.Drawing.Point(3, 43)
        Me.Tab_VisitaDomiciliaria.Name = "Tab_VisitaDomiciliaria"
        Me.Tab_VisitaDomiciliaria.SelectedIndex = 0
        Me.Tab_VisitaDomiciliaria.Size = New System.Drawing.Size(903, 681)
        Me.Tab_VisitaDomiciliaria.TabIndex = 2
        '
        'TabDescripcionCasaHabitacion
        '
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.btn_Borrar_Caracteristicas)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_Interior)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.btn_Cancelar_Caracteristicas)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_Mobiliario)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.btn_Guardar_Caracteristicas)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_Fachada)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_Construccion)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_Habitacion)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_DistribucionIn)
        Me.TabDescripcionCasaHabitacion.Controls.Add(Me.grp_DescripcionIn)
        Me.TabDescripcionCasaHabitacion.Location = New System.Drawing.Point(4, 22)
        Me.TabDescripcionCasaHabitacion.Name = "TabDescripcionCasaHabitacion"
        Me.TabDescripcionCasaHabitacion.Padding = New System.Windows.Forms.Padding(3)
        Me.TabDescripcionCasaHabitacion.Size = New System.Drawing.Size(895, 655)
        Me.TabDescripcionCasaHabitacion.TabIndex = 3
        Me.TabDescripcionCasaHabitacion.Text = "Descripcion Casa Habitacion"
        Me.TabDescripcionCasaHabitacion.UseVisualStyleBackColor = True
        '
        'grp_Interior
        '
        Me.grp_Interior.Controls.Add(Me.lbl_InteriorLO)
        Me.grp_Interior.Controls.Add(Me.rdb_InteriorLO_No)
        Me.grp_Interior.Controls.Add(Me.rdb_InteriorLO_Si)
        Me.grp_Interior.Controls.Add(Me.rtb_InteriorDesc)
        Me.grp_Interior.Controls.Add(Me.lbl_InteriorDescA)
        Me.grp_Interior.Controls.Add(Me.lbl_InteriorDesc)
        Me.grp_Interior.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Interior.Location = New System.Drawing.Point(6, 447)
        Me.grp_Interior.Name = "grp_Interior"
        Me.grp_Interior.Size = New System.Drawing.Size(883, 88)
        Me.grp_Interior.TabIndex = 38
        Me.grp_Interior.TabStop = False
        Me.grp_Interior.Text = "Interior"
        '
        'lbl_InteriorLO
        '
        Me.lbl_InteriorLO.AutoSize = True
        Me.lbl_InteriorLO.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InteriorLO.Location = New System.Drawing.Point(3, 21)
        Me.lbl_InteriorLO.Name = "lbl_InteriorLO"
        Me.lbl_InteriorLO.Size = New System.Drawing.Size(95, 13)
        Me.lbl_InteriorLO.TabIndex = 0
        Me.lbl_InteriorLO.Text = "Limpio y Ordenado"
        '
        'rdb_InteriorLO_No
        '
        Me.rdb_InteriorLO_No.AutoSize = True
        Me.rdb_InteriorLO_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_InteriorLO_No.Location = New System.Drawing.Point(158, 19)
        Me.rdb_InteriorLO_No.Name = "rdb_InteriorLO_No"
        Me.rdb_InteriorLO_No.Size = New System.Drawing.Size(39, 17)
        Me.rdb_InteriorLO_No.TabIndex = 2
        Me.rdb_InteriorLO_No.TabStop = True
        Me.rdb_InteriorLO_No.Text = "No"
        Me.rdb_InteriorLO_No.UseVisualStyleBackColor = True
        '
        'rdb_InteriorLO_Si
        '
        Me.rdb_InteriorLO_Si.AutoSize = True
        Me.rdb_InteriorLO_Si.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdb_InteriorLO_Si.Location = New System.Drawing.Point(104, 19)
        Me.rdb_InteriorLO_Si.Name = "rdb_InteriorLO_Si"
        Me.rdb_InteriorLO_Si.Size = New System.Drawing.Size(34, 17)
        Me.rdb_InteriorLO_Si.TabIndex = 1
        Me.rdb_InteriorLO_Si.TabStop = True
        Me.rdb_InteriorLO_Si.Text = "Si"
        Me.rdb_InteriorLO_Si.UseVisualStyleBackColor = True
        '
        'rtb_InteriorDesc
        '
        Me.rtb_InteriorDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_InteriorDesc.Location = New System.Drawing.Point(104, 42)
        Me.rtb_InteriorDesc.MaxLength = 500
        Me.rtb_InteriorDesc.Name = "rtb_InteriorDesc"
        Me.rtb_InteriorDesc.Size = New System.Drawing.Size(762, 40)
        Me.rtb_InteriorDesc.TabIndex = 4
        Me.rtb_InteriorDesc.Text = ""
        '
        'lbl_InteriorDescA
        '
        Me.lbl_InteriorDescA.AutoSize = True
        Me.lbl_InteriorDescA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InteriorDescA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InteriorDescA.Location = New System.Drawing.Point(872, 45)
        Me.lbl_InteriorDescA.Name = "lbl_InteriorDescA"
        Me.lbl_InteriorDescA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InteriorDescA.TabIndex = 5
        Me.lbl_InteriorDescA.Text = "*"
        '
        'lbl_InteriorDesc
        '
        Me.lbl_InteriorDesc.AutoSize = True
        Me.lbl_InteriorDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InteriorDesc.Location = New System.Drawing.Point(35, 45)
        Me.lbl_InteriorDesc.Name = "lbl_InteriorDesc"
        Me.lbl_InteriorDesc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_InteriorDesc.TabIndex = 3
        Me.lbl_InteriorDesc.Text = "Descripción"
        '
        'grp_Mobiliario
        '
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobTipoOtroA)
        Me.grp_Mobiliario.Controls.Add(Me.tbx_MobTipoOtro)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobTipoOtro)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobTipoA)
        Me.grp_Mobiliario.Controls.Add(Me.cmb_MobTipo)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobTipo)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobCalidadOtroA)
        Me.grp_Mobiliario.Controls.Add(Me.tbx_MobCalidadOtro)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobCalidadA)
        Me.grp_Mobiliario.Controls.Add(Me.cmb_MobCalidad)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobCalidad)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobCalidadOtro)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_MobiliarioA)
        Me.grp_Mobiliario.Controls.Add(Me.cmb_Mobiliario)
        Me.grp_Mobiliario.Controls.Add(Me.lbl_Mobiliario)
        Me.grp_Mobiliario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Mobiliario.Location = New System.Drawing.Point(6, 337)
        Me.grp_Mobiliario.Name = "grp_Mobiliario"
        Me.grp_Mobiliario.Size = New System.Drawing.Size(883, 104)
        Me.grp_Mobiliario.TabIndex = 37
        Me.grp_Mobiliario.TabStop = False
        Me.grp_Mobiliario.Text = "Mobiliario"
        '
        'lbl_MobTipoOtroA
        '
        Me.lbl_MobTipoOtroA.AutoSize = True
        Me.lbl_MobTipoOtroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobTipoOtroA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MobTipoOtroA.Location = New System.Drawing.Point(818, 76)
        Me.lbl_MobTipoOtroA.Name = "lbl_MobTipoOtroA"
        Me.lbl_MobTipoOtroA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MobTipoOtroA.TabIndex = 14
        Me.lbl_MobTipoOtroA.Text = "*"
        Me.lbl_MobTipoOtroA.Visible = False
        '
        'tbx_MobTipoOtro
        '
        Me.tbx_MobTipoOtro.Control_Siguiente = Nothing
        Me.tbx_MobTipoOtro.Enabled = False
        Me.tbx_MobTipoOtro.Filtrado = True
        Me.tbx_MobTipoOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MobTipoOtro.Location = New System.Drawing.Point(406, 73)
        Me.tbx_MobTipoOtro.MaxLength = 200
        Me.tbx_MobTipoOtro.Name = "tbx_MobTipoOtro"
        Me.tbx_MobTipoOtro.Size = New System.Drawing.Size(406, 20)
        Me.tbx_MobTipoOtro.TabIndex = 13
        Me.tbx_MobTipoOtro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_MobTipoOtro
        '
        Me.lbl_MobTipoOtro.AutoSize = True
        Me.lbl_MobTipoOtro.Enabled = False
        Me.lbl_MobTipoOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobTipoOtro.Location = New System.Drawing.Point(373, 76)
        Me.lbl_MobTipoOtro.Name = "lbl_MobTipoOtro"
        Me.lbl_MobTipoOtro.Size = New System.Drawing.Size(27, 13)
        Me.lbl_MobTipoOtro.TabIndex = 12
        Me.lbl_MobTipoOtro.Text = "Otro"
        '
        'lbl_MobTipoA
        '
        Me.lbl_MobTipoA.AutoSize = True
        Me.lbl_MobTipoA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobTipoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MobTipoA.Location = New System.Drawing.Point(338, 76)
        Me.lbl_MobTipoA.Name = "lbl_MobTipoA"
        Me.lbl_MobTipoA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MobTipoA.TabIndex = 11
        Me.lbl_MobTipoA.Text = "*"
        '
        'cmb_MobTipo
        '
        Me.cmb_MobTipo.Control_Siguiente = Me.tbx_MobTipoOtro
        Me.cmb_MobTipo.DisplayMember = "display"
        Me.cmb_MobTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MobTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_MobTipo.FormattingEnabled = True
        Me.cmb_MobTipo.Location = New System.Drawing.Point(104, 73)
        Me.cmb_MobTipo.MaxDropDownItems = 20
        Me.cmb_MobTipo.Name = "cmb_MobTipo"
        Me.cmb_MobTipo.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MobTipo.TabIndex = 10
        Me.cmb_MobTipo.ValueMember = "value"
        '
        'lbl_MobTipo
        '
        Me.lbl_MobTipo.AutoSize = True
        Me.lbl_MobTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobTipo.Location = New System.Drawing.Point(8, 76)
        Me.lbl_MobTipo.Name = "lbl_MobTipo"
        Me.lbl_MobTipo.Size = New System.Drawing.Size(90, 13)
        Me.lbl_MobTipo.TabIndex = 9
        Me.lbl_MobTipo.Text = "Tipo de Mobiliario"
        '
        'lbl_MobCalidadOtroA
        '
        Me.lbl_MobCalidadOtroA.AutoSize = True
        Me.lbl_MobCalidadOtroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobCalidadOtroA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MobCalidadOtroA.Location = New System.Drawing.Point(818, 49)
        Me.lbl_MobCalidadOtroA.Name = "lbl_MobCalidadOtroA"
        Me.lbl_MobCalidadOtroA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MobCalidadOtroA.TabIndex = 8
        Me.lbl_MobCalidadOtroA.Text = "*"
        Me.lbl_MobCalidadOtroA.Visible = False
        '
        'tbx_MobCalidadOtro
        '
        Me.tbx_MobCalidadOtro.Control_Siguiente = Me.cmb_MobTipo
        Me.tbx_MobCalidadOtro.Enabled = False
        Me.tbx_MobCalidadOtro.Filtrado = True
        Me.tbx_MobCalidadOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_MobCalidadOtro.Location = New System.Drawing.Point(406, 46)
        Me.tbx_MobCalidadOtro.MaxLength = 200
        Me.tbx_MobCalidadOtro.Name = "tbx_MobCalidadOtro"
        Me.tbx_MobCalidadOtro.Size = New System.Drawing.Size(406, 20)
        Me.tbx_MobCalidadOtro.TabIndex = 7
        Me.tbx_MobCalidadOtro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_MobCalidadA
        '
        Me.lbl_MobCalidadA.AutoSize = True
        Me.lbl_MobCalidadA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobCalidadA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MobCalidadA.Location = New System.Drawing.Point(338, 49)
        Me.lbl_MobCalidadA.Name = "lbl_MobCalidadA"
        Me.lbl_MobCalidadA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MobCalidadA.TabIndex = 5
        Me.lbl_MobCalidadA.Text = "*"
        '
        'cmb_MobCalidad
        '
        Me.cmb_MobCalidad.Control_Siguiente = Me.tbx_MobCalidadOtro
        Me.cmb_MobCalidad.DisplayMember = "display"
        Me.cmb_MobCalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MobCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_MobCalidad.FormattingEnabled = True
        Me.cmb_MobCalidad.Location = New System.Drawing.Point(104, 46)
        Me.cmb_MobCalidad.MaxDropDownItems = 20
        Me.cmb_MobCalidad.Name = "cmb_MobCalidad"
        Me.cmb_MobCalidad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MobCalidad.TabIndex = 4
        Me.cmb_MobCalidad.ValueMember = "value"
        '
        'lbl_MobCalidad
        '
        Me.lbl_MobCalidad.AutoSize = True
        Me.lbl_MobCalidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobCalidad.Location = New System.Drawing.Point(56, 49)
        Me.lbl_MobCalidad.Name = "lbl_MobCalidad"
        Me.lbl_MobCalidad.Size = New System.Drawing.Size(42, 13)
        Me.lbl_MobCalidad.TabIndex = 3
        Me.lbl_MobCalidad.Text = "Calidad"
        '
        'lbl_MobCalidadOtro
        '
        Me.lbl_MobCalidadOtro.AutoSize = True
        Me.lbl_MobCalidadOtro.Enabled = False
        Me.lbl_MobCalidadOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobCalidadOtro.Location = New System.Drawing.Point(373, 49)
        Me.lbl_MobCalidadOtro.Name = "lbl_MobCalidadOtro"
        Me.lbl_MobCalidadOtro.Size = New System.Drawing.Size(27, 13)
        Me.lbl_MobCalidadOtro.TabIndex = 6
        Me.lbl_MobCalidadOtro.Text = "Otro"
        '
        'lbl_MobiliarioA
        '
        Me.lbl_MobiliarioA.AutoSize = True
        Me.lbl_MobiliarioA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_MobiliarioA.ForeColor = System.Drawing.Color.Red
        Me.lbl_MobiliarioA.Location = New System.Drawing.Point(338, 22)
        Me.lbl_MobiliarioA.Name = "lbl_MobiliarioA"
        Me.lbl_MobiliarioA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_MobiliarioA.TabIndex = 2
        Me.lbl_MobiliarioA.Text = "*"
        '
        'cmb_Mobiliario
        '
        Me.cmb_Mobiliario.Control_Siguiente = Me.cmb_MobCalidad
        Me.cmb_Mobiliario.DisplayMember = "display"
        Me.cmb_Mobiliario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Mobiliario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Mobiliario.FormattingEnabled = True
        Me.cmb_Mobiliario.Location = New System.Drawing.Point(104, 19)
        Me.cmb_Mobiliario.MaxDropDownItems = 20
        Me.cmb_Mobiliario.Name = "cmb_Mobiliario"
        Me.cmb_Mobiliario.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Mobiliario.TabIndex = 1
        Me.cmb_Mobiliario.ValueMember = "value"
        '
        'lbl_Mobiliario
        '
        Me.lbl_Mobiliario.AutoSize = True
        Me.lbl_Mobiliario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mobiliario.Location = New System.Drawing.Point(47, 22)
        Me.lbl_Mobiliario.Name = "lbl_Mobiliario"
        Me.lbl_Mobiliario.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Mobiliario.TabIndex = 0
        Me.lbl_Mobiliario.Text = "Mobiliario"
        '
        'grp_Fachada
        '
        Me.grp_Fachada.Controls.Add(Me.rtb_ExteriorDesc)
        Me.grp_Fachada.Controls.Add(Me.lbl_ExteriorDescA)
        Me.grp_Fachada.Controls.Add(Me.lbl_ExteriorDesc)
        Me.grp_Fachada.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Fachada.Location = New System.Drawing.Point(6, 266)
        Me.grp_Fachada.Name = "grp_Fachada"
        Me.grp_Fachada.Size = New System.Drawing.Size(883, 65)
        Me.grp_Fachada.TabIndex = 36
        Me.grp_Fachada.TabStop = False
        Me.grp_Fachada.Text = "Fachada Exterior"
        '
        'rtb_ExteriorDesc
        '
        Me.rtb_ExteriorDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtb_ExteriorDesc.Location = New System.Drawing.Point(106, 19)
        Me.rtb_ExteriorDesc.MaxLength = 500
        Me.rtb_ExteriorDesc.Name = "rtb_ExteriorDesc"
        Me.rtb_ExteriorDesc.Size = New System.Drawing.Size(762, 40)
        Me.rtb_ExteriorDesc.TabIndex = 1
        Me.rtb_ExteriorDesc.Text = ""
        '
        'lbl_ExteriorDescA
        '
        Me.lbl_ExteriorDescA.AutoSize = True
        Me.lbl_ExteriorDescA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ExteriorDescA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ExteriorDescA.Location = New System.Drawing.Point(872, 22)
        Me.lbl_ExteriorDescA.Name = "lbl_ExteriorDescA"
        Me.lbl_ExteriorDescA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ExteriorDescA.TabIndex = 2
        Me.lbl_ExteriorDescA.Text = "*"
        '
        'lbl_ExteriorDesc
        '
        Me.lbl_ExteriorDesc.AutoSize = True
        Me.lbl_ExteriorDesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ExteriorDesc.Location = New System.Drawing.Point(35, 22)
        Me.lbl_ExteriorDesc.Name = "lbl_ExteriorDesc"
        Me.lbl_ExteriorDesc.Size = New System.Drawing.Size(63, 13)
        Me.lbl_ExteriorDesc.TabIndex = 0
        Me.lbl_ExteriorDesc.Text = "Descripción"
        '
        'grp_Construccion
        '
        Me.grp_Construccion.Controls.Add(Me.lbl_ConstOtroA)
        Me.grp_Construccion.Controls.Add(Me.tbx_ConstOtro)
        Me.grp_Construccion.Controls.Add(Me.lbl_ConstOtro)
        Me.grp_Construccion.Controls.Add(Me.lbl_ConstruccionA)
        Me.grp_Construccion.Controls.Add(Me.cmb_Construccion)
        Me.grp_Construccion.Controls.Add(Me.lbl_Construccion)
        Me.grp_Construccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Construccion.Location = New System.Drawing.Point(6, 210)
        Me.grp_Construccion.Name = "grp_Construccion"
        Me.grp_Construccion.Size = New System.Drawing.Size(883, 50)
        Me.grp_Construccion.TabIndex = 35
        Me.grp_Construccion.TabStop = False
        Me.grp_Construccion.Text = "Tipo de Construcción"
        '
        'lbl_ConstOtroA
        '
        Me.lbl_ConstOtroA.AutoSize = True
        Me.lbl_ConstOtroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConstOtroA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ConstOtroA.Location = New System.Drawing.Point(818, 22)
        Me.lbl_ConstOtroA.Name = "lbl_ConstOtroA"
        Me.lbl_ConstOtroA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ConstOtroA.TabIndex = 5
        Me.lbl_ConstOtroA.Text = "*"
        Me.lbl_ConstOtroA.Visible = False
        '
        'tbx_ConstOtro
        '
        Me.tbx_ConstOtro.Control_Siguiente = Nothing
        Me.tbx_ConstOtro.Enabled = False
        Me.tbx_ConstOtro.Filtrado = True
        Me.tbx_ConstOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_ConstOtro.Location = New System.Drawing.Point(406, 19)
        Me.tbx_ConstOtro.MaxLength = 200
        Me.tbx_ConstOtro.Name = "tbx_ConstOtro"
        Me.tbx_ConstOtro.Size = New System.Drawing.Size(406, 20)
        Me.tbx_ConstOtro.TabIndex = 4
        Me.tbx_ConstOtro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_ConstOtro
        '
        Me.lbl_ConstOtro.AutoSize = True
        Me.lbl_ConstOtro.Enabled = False
        Me.lbl_ConstOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConstOtro.Location = New System.Drawing.Point(373, 22)
        Me.lbl_ConstOtro.Name = "lbl_ConstOtro"
        Me.lbl_ConstOtro.Size = New System.Drawing.Size(27, 13)
        Me.lbl_ConstOtro.TabIndex = 3
        Me.lbl_ConstOtro.Text = "Otro"
        '
        'lbl_ConstruccionA
        '
        Me.lbl_ConstruccionA.AutoSize = True
        Me.lbl_ConstruccionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ConstruccionA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ConstruccionA.Location = New System.Drawing.Point(338, 22)
        Me.lbl_ConstruccionA.Name = "lbl_ConstruccionA"
        Me.lbl_ConstruccionA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ConstruccionA.TabIndex = 2
        Me.lbl_ConstruccionA.Text = "*"
        '
        'cmb_Construccion
        '
        Me.cmb_Construccion.Control_Siguiente = Me.tbx_ConstOtro
        Me.cmb_Construccion.DisplayMember = "display"
        Me.cmb_Construccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Construccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Construccion.FormattingEnabled = True
        Me.cmb_Construccion.Location = New System.Drawing.Point(104, 19)
        Me.cmb_Construccion.MaxDropDownItems = 20
        Me.cmb_Construccion.Name = "cmb_Construccion"
        Me.cmb_Construccion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Construccion.TabIndex = 1
        Me.cmb_Construccion.ValueMember = "value"
        '
        'lbl_Construccion
        '
        Me.lbl_Construccion.AutoSize = True
        Me.lbl_Construccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Construccion.Location = New System.Drawing.Point(29, 22)
        Me.lbl_Construccion.Name = "lbl_Construccion"
        Me.lbl_Construccion.Size = New System.Drawing.Size(69, 13)
        Me.lbl_Construccion.TabIndex = 0
        Me.lbl_Construccion.Text = "Construcción"
        '
        'grp_Habitacion
        '
        Me.grp_Habitacion.Controls.Add(Me.lbl_HabitacionOtroA)
        Me.grp_Habitacion.Controls.Add(Me.tbx_HabitacionOtro)
        Me.grp_Habitacion.Controls.Add(Me.lbl_HabitacionOtro)
        Me.grp_Habitacion.Controls.Add(Me.lbl_HabitacionA)
        Me.grp_Habitacion.Controls.Add(Me.cmb_Habitacion)
        Me.grp_Habitacion.Controls.Add(Me.lbl_Habitacion)
        Me.grp_Habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_Habitacion.Location = New System.Drawing.Point(6, 154)
        Me.grp_Habitacion.Name = "grp_Habitacion"
        Me.grp_Habitacion.Size = New System.Drawing.Size(883, 50)
        Me.grp_Habitacion.TabIndex = 34
        Me.grp_Habitacion.TabStop = False
        Me.grp_Habitacion.Text = "Tipo de Vivienda"
        '
        'lbl_HabitacionOtroA
        '
        Me.lbl_HabitacionOtroA.AutoSize = True
        Me.lbl_HabitacionOtroA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HabitacionOtroA.ForeColor = System.Drawing.Color.Red
        Me.lbl_HabitacionOtroA.Location = New System.Drawing.Point(818, 22)
        Me.lbl_HabitacionOtroA.Name = "lbl_HabitacionOtroA"
        Me.lbl_HabitacionOtroA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_HabitacionOtroA.TabIndex = 5
        Me.lbl_HabitacionOtroA.Text = "*"
        Me.lbl_HabitacionOtroA.Visible = False
        '
        'tbx_HabitacionOtro
        '
        Me.tbx_HabitacionOtro.Control_Siguiente = Nothing
        Me.tbx_HabitacionOtro.Enabled = False
        Me.tbx_HabitacionOtro.Filtrado = True
        Me.tbx_HabitacionOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_HabitacionOtro.Location = New System.Drawing.Point(406, 19)
        Me.tbx_HabitacionOtro.MaxLength = 200
        Me.tbx_HabitacionOtro.Name = "tbx_HabitacionOtro"
        Me.tbx_HabitacionOtro.Size = New System.Drawing.Size(406, 20)
        Me.tbx_HabitacionOtro.TabIndex = 4
        Me.tbx_HabitacionOtro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_HabitacionOtro
        '
        Me.lbl_HabitacionOtro.AutoSize = True
        Me.lbl_HabitacionOtro.Enabled = False
        Me.lbl_HabitacionOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HabitacionOtro.Location = New System.Drawing.Point(373, 22)
        Me.lbl_HabitacionOtro.Name = "lbl_HabitacionOtro"
        Me.lbl_HabitacionOtro.Size = New System.Drawing.Size(27, 13)
        Me.lbl_HabitacionOtro.TabIndex = 3
        Me.lbl_HabitacionOtro.Text = "Otro"
        '
        'lbl_HabitacionA
        '
        Me.lbl_HabitacionA.AutoSize = True
        Me.lbl_HabitacionA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_HabitacionA.ForeColor = System.Drawing.Color.Red
        Me.lbl_HabitacionA.Location = New System.Drawing.Point(338, 22)
        Me.lbl_HabitacionA.Name = "lbl_HabitacionA"
        Me.lbl_HabitacionA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_HabitacionA.TabIndex = 2
        Me.lbl_HabitacionA.Text = "*"
        '
        'cmb_Habitacion
        '
        Me.cmb_Habitacion.Control_Siguiente = Me.tbx_HabitacionOtro
        Me.cmb_Habitacion.DisplayMember = "display"
        Me.cmb_Habitacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Habitacion.FormattingEnabled = True
        Me.cmb_Habitacion.Location = New System.Drawing.Point(104, 19)
        Me.cmb_Habitacion.MaxDropDownItems = 20
        Me.cmb_Habitacion.Name = "cmb_Habitacion"
        Me.cmb_Habitacion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Habitacion.TabIndex = 1
        Me.cmb_Habitacion.ValueMember = "value"
        '
        'lbl_Habitacion
        '
        Me.lbl_Habitacion.AutoSize = True
        Me.lbl_Habitacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Habitacion.Location = New System.Drawing.Point(70, 22)
        Me.lbl_Habitacion.Name = "lbl_Habitacion"
        Me.lbl_Habitacion.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Habitacion.TabIndex = 0
        Me.lbl_Habitacion.Text = "Tipo"
        '
        'grp_DistribucionIn
        '
        Me.grp_DistribucionIn.Controls.Add(Me.lbl_InmCantBanosA)
        Me.grp_DistribucionIn.Controls.Add(Me.lbl_InmCantRecamarasA)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmCochera)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmPatio)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmComedor)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmCuartoServicio)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmCocina)
        Me.grp_DistribucionIn.Controls.Add(Me.chk_InmSala)
        Me.grp_DistribucionIn.Controls.Add(Me.tbx_InmCantBanos)
        Me.grp_DistribucionIn.Controls.Add(Me.tbx_InmCantRecamaras)
        Me.grp_DistribucionIn.Controls.Add(Me.tbx_InmuebleOtro)
        Me.grp_DistribucionIn.Controls.Add(Me.lbl_InmuebleOtro)
        Me.grp_DistribucionIn.Controls.Add(Me.lbl_InmCantBanos)
        Me.grp_DistribucionIn.Controls.Add(Me.lbl_InmCantRecamaras)
        Me.grp_DistribucionIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_DistribucionIn.Location = New System.Drawing.Point(6, 71)
        Me.grp_DistribucionIn.Name = "grp_DistribucionIn"
        Me.grp_DistribucionIn.Size = New System.Drawing.Size(883, 77)
        Me.grp_DistribucionIn.TabIndex = 33
        Me.grp_DistribucionIn.TabStop = False
        Me.grp_DistribucionIn.Text = "Distribución del Inmueble"
        '
        'lbl_InmCantBanosA
        '
        Me.lbl_InmCantBanosA.AutoSize = True
        Me.lbl_InmCantBanosA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantBanosA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InmCantBanosA.Location = New System.Drawing.Point(189, 50)
        Me.lbl_InmCantBanosA.Name = "lbl_InmCantBanosA"
        Me.lbl_InmCantBanosA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InmCantBanosA.TabIndex = 5
        Me.lbl_InmCantBanosA.Text = "*"
        '
        'lbl_InmCantRecamarasA
        '
        Me.lbl_InmCantRecamarasA.AutoSize = True
        Me.lbl_InmCantRecamarasA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantRecamarasA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InmCantRecamarasA.Location = New System.Drawing.Point(189, 24)
        Me.lbl_InmCantRecamarasA.Name = "lbl_InmCantRecamarasA"
        Me.lbl_InmCantRecamarasA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InmCantRecamarasA.TabIndex = 2
        Me.lbl_InmCantRecamarasA.Text = "*"
        '
        'chk_InmCochera
        '
        Me.chk_InmCochera.AutoSize = True
        Me.chk_InmCochera.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmCochera.Location = New System.Drawing.Point(358, 46)
        Me.chk_InmCochera.Name = "chk_InmCochera"
        Me.chk_InmCochera.Size = New System.Drawing.Size(66, 17)
        Me.chk_InmCochera.TabIndex = 10
        Me.chk_InmCochera.Text = "Cochera"
        Me.chk_InmCochera.UseVisualStyleBackColor = True
        '
        'chk_InmPatio
        '
        Me.chk_InmPatio.AutoSize = True
        Me.chk_InmPatio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmPatio.Location = New System.Drawing.Point(477, 23)
        Me.chk_InmPatio.Name = "chk_InmPatio"
        Me.chk_InmPatio.Size = New System.Drawing.Size(50, 17)
        Me.chk_InmPatio.TabIndex = 8
        Me.chk_InmPatio.Text = "Patio"
        Me.chk_InmPatio.UseVisualStyleBackColor = True
        '
        'chk_InmComedor
        '
        Me.chk_InmComedor.AutoSize = True
        Me.chk_InmComedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmComedor.Location = New System.Drawing.Point(239, 46)
        Me.chk_InmComedor.Name = "chk_InmComedor"
        Me.chk_InmComedor.Size = New System.Drawing.Size(68, 17)
        Me.chk_InmComedor.TabIndex = 9
        Me.chk_InmComedor.Text = "Comedor"
        Me.chk_InmComedor.UseVisualStyleBackColor = True
        '
        'chk_InmCuartoServicio
        '
        Me.chk_InmCuartoServicio.AutoSize = True
        Me.chk_InmCuartoServicio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmCuartoServicio.Location = New System.Drawing.Point(477, 46)
        Me.chk_InmCuartoServicio.Name = "chk_InmCuartoServicio"
        Me.chk_InmCuartoServicio.Size = New System.Drawing.Size(113, 17)
        Me.chk_InmCuartoServicio.TabIndex = 11
        Me.chk_InmCuartoServicio.Text = "Cuarto de Servicio"
        Me.chk_InmCuartoServicio.UseVisualStyleBackColor = True
        '
        'chk_InmCocina
        '
        Me.chk_InmCocina.AutoSize = True
        Me.chk_InmCocina.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmCocina.Location = New System.Drawing.Point(358, 23)
        Me.chk_InmCocina.Name = "chk_InmCocina"
        Me.chk_InmCocina.Size = New System.Drawing.Size(59, 17)
        Me.chk_InmCocina.TabIndex = 7
        Me.chk_InmCocina.Text = "Cocina"
        Me.chk_InmCocina.UseVisualStyleBackColor = True
        '
        'chk_InmSala
        '
        Me.chk_InmSala.AutoSize = True
        Me.chk_InmSala.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_InmSala.Location = New System.Drawing.Point(239, 23)
        Me.chk_InmSala.Name = "chk_InmSala"
        Me.chk_InmSala.Size = New System.Drawing.Size(47, 17)
        Me.chk_InmSala.TabIndex = 6
        Me.chk_InmSala.Text = "Sala"
        Me.chk_InmSala.UseVisualStyleBackColor = True
        '
        'tbx_InmCantBanos
        '
        Me.tbx_InmCantBanos.Control_Siguiente = Me.chk_InmSala
        Me.tbx_InmCantBanos.Filtrado = True
        Me.tbx_InmCantBanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmCantBanos.Location = New System.Drawing.Point(133, 47)
        Me.tbx_InmCantBanos.MaxLength = 3
        Me.tbx_InmCantBanos.Name = "tbx_InmCantBanos"
        Me.tbx_InmCantBanos.Size = New System.Drawing.Size(50, 20)
        Me.tbx_InmCantBanos.TabIndex = 4
        Me.tbx_InmCantBanos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_InmCantRecamaras
        '
        Me.tbx_InmCantRecamaras.Control_Siguiente = Me.tbx_InmCantBanos
        Me.tbx_InmCantRecamaras.Filtrado = True
        Me.tbx_InmCantRecamaras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmCantRecamaras.Location = New System.Drawing.Point(133, 21)
        Me.tbx_InmCantRecamaras.MaxLength = 2
        Me.tbx_InmCantRecamaras.Name = "tbx_InmCantRecamaras"
        Me.tbx_InmCantRecamaras.Size = New System.Drawing.Size(50, 20)
        Me.tbx_InmCantRecamaras.TabIndex = 1
        Me.tbx_InmCantRecamaras.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_InmuebleOtro
        '
        Me.tbx_InmuebleOtro.Control_Siguiente = Nothing
        Me.tbx_InmuebleOtro.Filtrado = True
        Me.tbx_InmuebleOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmuebleOtro.Location = New System.Drawing.Point(653, 44)
        Me.tbx_InmuebleOtro.MaxLength = 30
        Me.tbx_InmuebleOtro.Name = "tbx_InmuebleOtro"
        Me.tbx_InmuebleOtro.Size = New System.Drawing.Size(210, 20)
        Me.tbx_InmuebleOtro.TabIndex = 13
        Me.tbx_InmuebleOtro.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_InmuebleOtro
        '
        Me.lbl_InmuebleOtro.AutoSize = True
        Me.lbl_InmuebleOtro.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmuebleOtro.Location = New System.Drawing.Point(615, 47)
        Me.lbl_InmuebleOtro.Name = "lbl_InmuebleOtro"
        Me.lbl_InmuebleOtro.Size = New System.Drawing.Size(32, 13)
        Me.lbl_InmuebleOtro.TabIndex = 12
        Me.lbl_InmuebleOtro.Text = "Otros"
        '
        'lbl_InmCantBanos
        '
        Me.lbl_InmCantBanos.AutoSize = True
        Me.lbl_InmCantBanos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantBanos.Location = New System.Drawing.Point(30, 50)
        Me.lbl_InmCantBanos.Name = "lbl_InmCantBanos"
        Me.lbl_InmCantBanos.Size = New System.Drawing.Size(97, 13)
        Me.lbl_InmCantBanos.TabIndex = 3
        Me.lbl_InmCantBanos.Text = "Cantidad de Baños"
        '
        'lbl_InmCantRecamaras
        '
        Me.lbl_InmCantRecamaras.AutoSize = True
        Me.lbl_InmCantRecamaras.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantRecamaras.Location = New System.Drawing.Point(6, 24)
        Me.lbl_InmCantRecamaras.Name = "lbl_InmCantRecamaras"
        Me.lbl_InmCantRecamaras.Size = New System.Drawing.Size(121, 13)
        Me.lbl_InmCantRecamaras.TabIndex = 0
        Me.lbl_InmCantRecamaras.Text = "Cantidad de Recamaras"
        '
        'grp_DescripcionIn
        '
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmCantPisosA)
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmCantHabitantesA)
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmPropietarioA)
        Me.grp_DescripcionIn.Controls.Add(Me.tbx_InmPropietario)
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmPropietario)
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmCantHabitantes)
        Me.grp_DescripcionIn.Controls.Add(Me.tbx_InmCantPisos)
        Me.grp_DescripcionIn.Controls.Add(Me.tbx_InmCantHabitantes)
        Me.grp_DescripcionIn.Controls.Add(Me.lbl_InmCantPisos)
        Me.grp_DescripcionIn.Enabled = False
        Me.grp_DescripcionIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grp_DescripcionIn.Location = New System.Drawing.Point(6, 15)
        Me.grp_DescripcionIn.Name = "grp_DescripcionIn"
        Me.grp_DescripcionIn.Size = New System.Drawing.Size(883, 50)
        Me.grp_DescripcionIn.TabIndex = 32
        Me.grp_DescripcionIn.TabStop = False
        Me.grp_DescripcionIn.Text = "Descripción del Inmueble"
        '
        'lbl_InmCantPisosA
        '
        Me.lbl_InmCantPisosA.AutoSize = True
        Me.lbl_InmCantPisosA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantPisosA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InmCantPisosA.Location = New System.Drawing.Point(857, 22)
        Me.lbl_InmCantPisosA.Name = "lbl_InmCantPisosA"
        Me.lbl_InmCantPisosA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InmCantPisosA.TabIndex = 8
        Me.lbl_InmCantPisosA.Text = "*"
        '
        'lbl_InmCantHabitantesA
        '
        Me.lbl_InmCantHabitantesA.AutoSize = True
        Me.lbl_InmCantHabitantesA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantHabitantesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InmCantHabitantesA.Location = New System.Drawing.Point(686, 22)
        Me.lbl_InmCantHabitantesA.Name = "lbl_InmCantHabitantesA"
        Me.lbl_InmCantHabitantesA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InmCantHabitantesA.TabIndex = 5
        Me.lbl_InmCantHabitantesA.Text = "*"
        '
        'lbl_InmPropietarioA
        '
        Me.lbl_InmPropietarioA.AutoSize = True
        Me.lbl_InmPropietarioA.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmPropietarioA.ForeColor = System.Drawing.Color.Red
        Me.lbl_InmPropietarioA.Location = New System.Drawing.Point(489, 22)
        Me.lbl_InmPropietarioA.Name = "lbl_InmPropietarioA"
        Me.lbl_InmPropietarioA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_InmPropietarioA.TabIndex = 2
        Me.lbl_InmPropietarioA.Text = "*"
        '
        'tbx_InmPropietario
        '
        Me.tbx_InmPropietario.Control_Siguiente = Me.tbx_InmCantHabitantes
        Me.tbx_InmPropietario.Filtrado = True
        Me.tbx_InmPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmPropietario.Location = New System.Drawing.Point(133, 19)
        Me.tbx_InmPropietario.MaxLength = 100
        Me.tbx_InmPropietario.Name = "tbx_InmPropietario"
        Me.tbx_InmPropietario.Size = New System.Drawing.Size(350, 20)
        Me.tbx_InmPropietario.TabIndex = 1
        Me.tbx_InmPropietario.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_InmCantHabitantes
        '
        Me.tbx_InmCantHabitantes.Control_Siguiente = Me.tbx_InmCantPisos
        Me.tbx_InmCantHabitantes.Filtrado = True
        Me.tbx_InmCantHabitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmCantHabitantes.Location = New System.Drawing.Point(630, 19)
        Me.tbx_InmCantHabitantes.MaxLength = 2
        Me.tbx_InmCantHabitantes.Name = "tbx_InmCantHabitantes"
        Me.tbx_InmCantHabitantes.Size = New System.Drawing.Size(50, 20)
        Me.tbx_InmCantHabitantes.TabIndex = 4
        Me.tbx_InmCantHabitantes.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_InmCantPisos
        '
        Me.tbx_InmCantPisos.Control_Siguiente = Nothing
        Me.tbx_InmCantPisos.Filtrado = True
        Me.tbx_InmCantPisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_InmCantPisos.Location = New System.Drawing.Point(801, 19)
        Me.tbx_InmCantPisos.MaxLength = 2
        Me.tbx_InmCantPisos.Name = "tbx_InmCantPisos"
        Me.tbx_InmCantPisos.Size = New System.Drawing.Size(50, 20)
        Me.tbx_InmCantPisos.TabIndex = 7
        Me.tbx_InmCantPisos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_InmPropietario
        '
        Me.lbl_InmPropietario.AutoSize = True
        Me.lbl_InmPropietario.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmPropietario.Location = New System.Drawing.Point(13, 22)
        Me.lbl_InmPropietario.Name = "lbl_InmPropietario"
        Me.lbl_InmPropietario.Size = New System.Drawing.Size(114, 13)
        Me.lbl_InmPropietario.TabIndex = 0
        Me.lbl_InmPropietario.Text = "Nombre del Propietario"
        '
        'lbl_InmCantHabitantes
        '
        Me.lbl_InmCantHabitantes.AutoSize = True
        Me.lbl_InmCantHabitantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantHabitantes.Location = New System.Drawing.Point(506, 22)
        Me.lbl_InmCantHabitantes.Name = "lbl_InmCantHabitantes"
        Me.lbl_InmCantHabitantes.Size = New System.Drawing.Size(118, 13)
        Me.lbl_InmCantHabitantes.TabIndex = 3
        Me.lbl_InmCantHabitantes.Text = "Cantidad de Habitantes"
        '
        'lbl_InmCantPisos
        '
        Me.lbl_InmCantPisos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_InmCantPisos.Location = New System.Drawing.Point(703, 16)
        Me.lbl_InmCantPisos.Name = "lbl_InmCantPisos"
        Me.lbl_InmCantPisos.Size = New System.Drawing.Size(92, 31)
        Me.lbl_InmCantPisos.TabIndex = 6
        Me.lbl_InmCantPisos.Text = "Cantidad de Pisos o Niveles"
        Me.lbl_InmCantPisos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Borrar_Caracteristicas
        '
        Me.btn_Borrar_Caracteristicas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Caracteristicas.Enabled = False
        Me.btn_Borrar_Caracteristicas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Caracteristicas.Location = New System.Drawing.Point(157, 618)
        Me.btn_Borrar_Caracteristicas.Name = "btn_Borrar_Caracteristicas"
        Me.btn_Borrar_Caracteristicas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Caracteristicas.TabIndex = 23
        Me.btn_Borrar_Caracteristicas.Text = "&Borrar"
        Me.btn_Borrar_Caracteristicas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Caracteristicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Caracteristicas.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Caracteristicas
        '
        Me.btn_Cancelar_Caracteristicas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Caracteristicas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Caracteristicas.Location = New System.Drawing.Point(303, 618)
        Me.btn_Cancelar_Caracteristicas.Name = "btn_Cancelar_Caracteristicas"
        Me.btn_Cancelar_Caracteristicas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Caracteristicas.TabIndex = 24
        Me.btn_Cancelar_Caracteristicas.Text = "&Cancelar"
        Me.btn_Cancelar_Caracteristicas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Caracteristicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Caracteristicas.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Caracteristicas
        '
        Me.btn_Guardar_Caracteristicas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Caracteristicas.Enabled = False
        Me.btn_Guardar_Caracteristicas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Caracteristicas.Location = New System.Drawing.Point(11, 618)
        Me.btn_Guardar_Caracteristicas.Name = "btn_Guardar_Caracteristicas"
        Me.btn_Guardar_Caracteristicas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Caracteristicas.TabIndex = 22
        Me.btn_Guardar_Caracteristicas.Text = "&Guardar"
        Me.btn_Guardar_Caracteristicas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Caracteristicas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Caracteristicas.UseVisualStyleBackColor = True
        '
        'frm_VisitaDomiciliaria
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(904, 725)
        Me.Controls.Add(Me.Tab_VisitaDomiciliaria)
        Me.Controls.Add(Me.lbl_Nombre)
        Me.Controls.Add(Me.lbl_Clave)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(910, 740)
        Me.Name = "frm_VisitaDomiciliaria"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Visita Domiciliaria al Empleado"
        Me.Tab_Referencias.ResumeLayout(False)
        Me.Tab_Referencias.PerformLayout()
        Me.TabIngresosEgresos.ResumeLayout(False)
        Me.grp_HabitantesDomicilio.ResumeLayout(False)
        CType(Me.dgv_Familiares, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_IngresosMensDistrubucion.ResumeLayout(False)
        CType(Me.dgv_ingresos_mensuales, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_AlgunaPropiedad.ResumeLayout(False)
        Me.grp_AlgunaPropiedad.PerformLayout()
        Me.grp_ManejaTDC.ResumeLayout(False)
        Me.grp_ManejaTDC.PerformLayout()
        Me.grp_AutoPropio.ResumeLayout(False)
        Me.grp_AutoPropio.PerformLayout()
        Me.grp_FamiliarTrabajaCorporacion.ResumeLayout(False)
        Me.grp_FamiliarTrabajaCorporacion.PerformLayout()
        Me.grp_NoDependientesEcono.ResumeLayout(False)
        Me.grp_NoDependientesEcono.PerformLayout()
        Me.grp_NoPersonasAportan.ResumeLayout(False)
        Me.grp_NoPersonasAportan.PerformLayout()
        Me.grp_AsciendeIngreso.ResumeLayout(False)
        Me.grp_AsciendeIngreso.PerformLayout()
        Me.grp_IngresosDedicadosAhorro.ResumeLayout(False)
        Me.grp_IngresosDedicadosAhorro.PerformLayout()
        Me.grp_AsciendeDeuda.ResumeLayout(False)
        Me.grp_AsciendeDeuda.PerformLayout()
        Me.grp_DeudaPlan.ResumeLayout(False)
        Me.grp_DeudaPlan.PerformLayout()
        Me.grp_DeudaActual.ResumeLayout(False)
        Me.grp_DeudaActual.PerformLayout()
        Me.Tab_Visita.ResumeLayout(False)
        Me.grp_VisitasDomiciliarias.ResumeLayout(False)
        Me.grp_Proxima.ResumeLayout(False)
        Me.grp_Proxima.PerformLayout()
        Me.grp_Visita.ResumeLayout(False)
        Me.grp_Visita.PerformLayout()
        Me.Tab_VisitaDomiciliaria.ResumeLayout(False)
        Me.TabDescripcionCasaHabitacion.ResumeLayout(False)
        Me.grp_Interior.ResumeLayout(False)
        Me.grp_Interior.PerformLayout()
        Me.grp_Mobiliario.ResumeLayout(False)
        Me.grp_Mobiliario.PerformLayout()
        Me.grp_Fachada.ResumeLayout(False)
        Me.grp_Fachada.PerformLayout()
        Me.grp_Construccion.ResumeLayout(False)
        Me.grp_Construccion.PerformLayout()
        Me.grp_Habitacion.ResumeLayout(False)
        Me.grp_Habitacion.PerformLayout()
        Me.grp_DistribucionIn.ResumeLayout(False)
        Me.grp_DistribucionIn.PerformLayout()
        Me.grp_DescripcionIn.ResumeLayout(False)
        Me.grp_DescripcionIn.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents Tab_Referencias As System.Windows.Forms.TabPage
    Friend WithEvents lbl_RefDefPerA As System.Windows.Forms.Label
    Friend WithEvents lsv_Referencias As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_RefTiempo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_RefDefFam As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_RefNombre As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_RefDefPer As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_RefTiempoA As System.Windows.Forms.Label
    Friend WithEvents lbl_RefTiempoAños As System.Windows.Forms.Label
    Friend WithEvents lbl_RefDefFamA As System.Windows.Forms.Label
    Friend WithEvents lbl_RefTiempo As System.Windows.Forms.Label
    Friend WithEvents lbl_RefTipoPerA As System.Windows.Forms.Label
    Friend WithEvents lbl_RefNomA As System.Windows.Forms.Label
    Friend WithEvents lbl_RefNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_RefDefFam As System.Windows.Forms.Label
    Friend WithEvents lbl_RefTipoPer As System.Windows.Forms.Label
    Friend WithEvents lbl_RefDefPer As System.Windows.Forms.Label
    Friend WithEvents btn_Borrar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar_Ref As System.Windows.Forms.Button
    Friend WithEvents cmb_RefTipoPer As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents TabIngresosEgresos As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Visita As System.Windows.Forms.TabPage
    Friend WithEvents btn_Guardar_Visita As System.Windows.Forms.Button
    Friend WithEvents grp_Proxima As System.Windows.Forms.GroupBox
    Friend WithEvents tbx_MotivoProx As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents dtp_HoraProx As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_MotivoPAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraPAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraProx As System.Windows.Forms.Label
    Friend WithEvents lbl_MotivoProx As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaPAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_EmpPAsterisco As System.Windows.Forms.Label
    Friend WithEvents cmb_NombreProx As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_BuscarProx As System.Windows.Forms.Button
    Friend WithEvents lbl_NombreProx As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaProx As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaProx As System.Windows.Forms.DateTimePicker
    Friend WithEvents grp_Visita As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_ObsAsterisco As System.Windows.Forms.Label
    Friend WithEvents tbx_MotivoVisita As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents rtb_Observaciones As System.Windows.Forms.RichTextBox
    Friend WithEvents chk_ProximaVisita As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_MotivoAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_EmpAsterisco As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_HoraAsterisco As System.Windows.Forms.Label
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraVisita As System.Windows.Forms.Label
    Friend WithEvents cmb_Nombre As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents lbl_NombreVisita As System.Windows.Forms.Label
    Friend WithEvents lbl_MotivoVisita As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaVisita As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaVisita As System.Windows.Forms.DateTimePicker
    Friend WithEvents Tab_VisitaDomiciliaria As System.Windows.Forms.TabControl
    Friend WithEvents btn_Agregar_Ref As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents grp_VisitasDomiciliarias As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents lsv_VisitasDomiciliarias As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Importar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_Visita As System.Windows.Forms.Button
    Friend WithEvents btn_Nuevo As System.Windows.Forms.Button
    Friend WithEvents TabDescripcionCasaHabitacion As TabPage
    Friend WithEvents grp_HabitantesDomicilio As GroupBox
    Friend WithEvents dgv_Familiares As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents grp_IngresosMensDistrubucion As GroupBox
    Friend WithEvents dgv_ingresos_mensuales As DataGridView
    Friend WithEvents IdIngresoEgreso As DataGridViewTextBoxColumn
    Friend WithEvents dt_Ingreso As DataGridViewTextBoxColumn
    Friend WithEvents dt_Cantidad As DataGridViewTextBoxColumn
    Friend WithEvents grp_AlgunaPropiedad As GroupBox
    Friend WithEvents Label35 As Label
    Friend WithEvents rdb_AlgunaPropiedad_NO As RadioButton
    Friend WithEvents rdb_AlgunaPropiedad_SI As RadioButton
    Friend WithEvents tbx_AlgunaPropiedad_Ubicacion As cp_Textbox
    Friend WithEvents rdb_DeudaAct_Si As RadioButton
    Friend WithEvents Label36 As Label
    Friend WithEvents grp_ManejaTDC As GroupBox
    Friend WithEvents tbx_TarjetaCReditoManeja As cp_Textbox
    Friend WithEvents Label37 As Label
    Friend WithEvents grp_AutoPropio As GroupBox
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
    Friend WithEvents tbx_AutoPropio_Modelo As cp_Textbox
    Friend WithEvents rdb_AutoPropio_NO As RadioButton
    Friend WithEvents tbx_AutoPropio_Marca As cp_Textbox
    Friend WithEvents rdb_AutoPropio_SI As RadioButton
    Friend WithEvents Label40 As Label
    Friend WithEvents grp_FamiliarTrabajaCorporacion As GroupBox
    Friend WithEvents rdb_FamiliarTrabajaCorporacion_NO As RadioButton
    Friend WithEvents rdb_FamiliarTrabajaCorporacion_SI As RadioButton
    Friend WithEvents Label41 As Label
    Friend WithEvents grp_NoDependientesEcono As GroupBox
    Friend WithEvents tbx_NoDependientesEcono As cp_Textbox
    Friend WithEvents grp_NoPersonasAportan As GroupBox
    Friend WithEvents tbx_NoPersonasAportan As cp_Textbox
    Friend WithEvents Label42 As Label
    Friend WithEvents grp_AsciendeIngreso As GroupBox
    Friend WithEvents tbx_AsciendeIngreso As cp_Textbox
    Friend WithEvents Label43 As Label
    Friend WithEvents grp_IngresosDedicadosAhorro As GroupBox
    Friend WithEvents tbx_IngresoDedicadoAhorro As cp_Textbox
    Friend WithEvents Label44 As Label
    Friend WithEvents grp_AsciendeDeuda As GroupBox
    Friend WithEvents tbx_AsciendeDeuda As cp_Textbox
    Friend WithEvents lbl_asiendedeuda As Label
    Friend WithEvents grp_DeudaPlan As GroupBox
    Friend WithEvents lbl_PlanEndeudaDescA As Label
    Friend WithEvents rdb_PlanEndeuda_Si As RadioButton
    Friend WithEvents tbx_PlanEndeudaDesc As cp_Textbox
    Friend WithEvents rdb_PlanEndeuda_No As RadioButton
    Friend WithEvents lbl_PlanEndeudaDesc As Label
    Friend WithEvents grp_DeudaActual As GroupBox
    Friend WithEvents rdb_DeudaAct_No As RadioButton
    Friend WithEvents grp_DescripcionIn As GroupBox
    Friend WithEvents lbl_InmCantPisosA As Label
    Friend WithEvents lbl_InmCantHabitantesA As Label
    Friend WithEvents lbl_InmPropietarioA As Label
    Friend WithEvents tbx_InmPropietario As cp_Textbox
    Friend WithEvents tbx_InmCantHabitantes As cp_Textbox
    Friend WithEvents tbx_InmCantPisos As cp_Textbox
    Friend WithEvents lbl_InmPropietario As Label
    Friend WithEvents lbl_InmCantHabitantes As Label
    Friend WithEvents lbl_InmCantPisos As Label
    Friend WithEvents grp_DistribucionIn As GroupBox
    Friend WithEvents lbl_InmCantBanosA As Label
    Friend WithEvents lbl_InmCantRecamarasA As Label
    Friend WithEvents chk_InmCochera As CheckBox
    Friend WithEvents chk_InmPatio As CheckBox
    Friend WithEvents chk_InmComedor As CheckBox
    Friend WithEvents chk_InmCuartoServicio As CheckBox
    Friend WithEvents chk_InmCocina As CheckBox
    Friend WithEvents chk_InmSala As CheckBox
    Friend WithEvents tbx_InmCantBanos As cp_Textbox
    Friend WithEvents tbx_InmCantRecamaras As cp_Textbox
    Friend WithEvents tbx_InmuebleOtro As cp_Textbox
    Friend WithEvents lbl_InmuebleOtro As Label
    Friend WithEvents lbl_InmCantBanos As Label
    Friend WithEvents lbl_InmCantRecamaras As Label
    Friend WithEvents grp_Habitacion As GroupBox
    Friend WithEvents lbl_HabitacionOtroA As Label
    Friend WithEvents tbx_HabitacionOtro As cp_Textbox
    Friend WithEvents lbl_HabitacionOtro As Label
    Friend WithEvents lbl_HabitacionA As Label
    Friend WithEvents cmb_Habitacion As cp_cmb_Manual
    Friend WithEvents lbl_Habitacion As Label
    Friend WithEvents grp_Construccion As GroupBox
    Friend WithEvents lbl_ConstOtroA As Label
    Friend WithEvents tbx_ConstOtro As cp_Textbox
    Friend WithEvents lbl_ConstOtro As Label
    Friend WithEvents lbl_ConstruccionA As Label
    Friend WithEvents cmb_Construccion As cp_cmb_Manual
    Friend WithEvents lbl_Construccion As Label
    Friend WithEvents grp_Fachada As GroupBox
    Friend WithEvents rtb_ExteriorDesc As RichTextBox
    Friend WithEvents lbl_ExteriorDescA As Label
    Friend WithEvents lbl_ExteriorDesc As Label
    Friend WithEvents grp_Mobiliario As GroupBox
    Friend WithEvents lbl_MobTipoOtroA As Label
    Friend WithEvents tbx_MobTipoOtro As cp_Textbox
    Friend WithEvents lbl_MobTipoOtro As Label
    Friend WithEvents lbl_MobTipoA As Label
    Friend WithEvents cmb_MobTipo As cp_cmb_Manual
    Friend WithEvents lbl_MobTipo As Label
    Friend WithEvents lbl_MobCalidadOtroA As Label
    Friend WithEvents tbx_MobCalidadOtro As cp_Textbox
    Friend WithEvents lbl_MobCalidadA As Label
    Friend WithEvents cmb_MobCalidad As cp_cmb_Manual
    Friend WithEvents lbl_MobCalidad As Label
    Friend WithEvents lbl_MobCalidadOtro As Label
    Friend WithEvents lbl_MobiliarioA As Label
    Friend WithEvents cmb_Mobiliario As cp_cmb_Manual
    Friend WithEvents lbl_Mobiliario As Label
    Friend WithEvents grp_Interior As GroupBox
    Friend WithEvents lbl_InteriorLO As Label
    Friend WithEvents rdb_InteriorLO_No As RadioButton
    Friend WithEvents rdb_InteriorLO_Si As RadioButton
    Friend WithEvents rtb_InteriorDesc As RichTextBox
    Friend WithEvents lbl_InteriorDescA As Label
    Friend WithEvents lbl_InteriorDesc As Label
    Friend WithEvents btn_BorrarIngresosEgresos As Button
    Friend WithEvents btn_CancelarIngresosEgresos As Button
    Friend WithEvents btn_GuardarIngresosEgresos As Button
    Friend WithEvents btn_Borrar_Caracteristicas As Button
    Friend WithEvents btn_Cancelar_Caracteristicas As Button
    Friend WithEvents btn_Guardar_Caracteristicas As Button
End Class
