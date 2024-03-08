<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Empleados
    Inherits Modulo_Reclutamiento.frm_Base

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Empleados))
        Dim ListViewColumnSorter32 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter33 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter34 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter35 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter36 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter37 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter31 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter38 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter39 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter40 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.btn_FichaTecnica = New System.Windows.Forms.Button()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_Boleta = New System.Windows.Forms.Button()
        Me.btn_Visitas = New System.Windows.Forms.Button()
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox()
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox()
        Me.btn_Fotos = New System.Windows.Forms.Button()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Mapa = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Lbl_StatusL = New System.Windows.Forms.Label()
        Me.Lbl_PuestoL = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DepartamentoL = New System.Windows.Forms.Label()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview()
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.tab_DatosEmpleado = New System.Windows.Forms.TabControl()
        Me.tab_DatosGenerales = New System.Windows.Forms.TabPage()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label48 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdb_LPCno = New System.Windows.Forms.RadioButton()
        Me.rdb_LPCsi = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.rdb_negativassp = New System.Windows.Forms.RadioButton()
        Me.rdb_positivassp = New System.Windows.Forms.RadioButton()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.rdb_optvossp = New System.Windows.Forms.RadioButton()
        Me.rdb_adtvossp = New System.Windows.Forms.RadioButton()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_estatal = New System.Windows.Forms.CheckBox()
        Me.chk_federal = New System.Windows.Forms.CheckBox()
        Me.Btn_AgregarColonia = New System.Windows.Forms.Button()
        Me.gbx_CatalogoFirmas = New System.Windows.Forms.GroupBox()
        Me.rdb_No_CatFirmas = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_CatFirmas = New System.Windows.Forms.RadioButton()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.cmb_Colonias = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Zonas = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_CodigoPostal = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Latitud = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Longitud = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Genero = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_EstadoCivil = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_ViveConFam = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.tbx_CantidadHijos = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FechaNac = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaExpiraFed = New System.Windows.Forms.DateTimePicker()
        Me.lbl_FechaExpiraFed = New System.Windows.Forms.Label()
        Me.tbx_NumeroLicenciaFed = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_UMF = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Pasaporte = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_TipoLicencia = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.dtp_FechaExpira = New System.Windows.Forms.DateTimePicker()
        Me.lbl_NumeroLicenciaFed = New System.Windows.Forms.Label()
        Me.tbx_IdTributario = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_CURP = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_IMSS = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_CUIP = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumCartilla = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_RFC_Extranjero = New System.Windows.Forms.Label()
        Me.tbx_NumeroLicencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NumeroLicencia = New System.Windows.Forms.Label()
        Me.btn_ImprimirSolicitud = New System.Windows.Forms.Button()
        Me.btn_MapaEmpleado = New System.Windows.Forms.Button()
        Me.tbx_MontoDescuento = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_MontoDescuento = New System.Windows.Forms.Label()
        Me.cmb_TipoDescuento = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_TipoDescuento = New System.Windows.Forms.Label()
        Me.tbx_NumeroCredito = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NumeroCredito = New System.Windows.Forms.Label()
        Me.lbl_FechaActualizacionDG = New System.Windows.Forms.Label()
        Me.lbl_FechaActualDGview = New System.Windows.Forms.Label()
        Me.lbl_PortaArma = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.gbx_Porte = New System.Windows.Forms.GroupBox()
        Me.rdb_PorteArmaNo = New System.Windows.Forms.RadioButton()
        Me.rdb_PorteArmaSI = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaVenceCredencial = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_EmailDG = New System.Windows.Forms.Label()
        Me.tbx_MailPersonal = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Telefono1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_TelefonoMovil1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Elector = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_RFC = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_CUIP = New System.Windows.Forms.Label()
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_ComprobarListaNegra = New System.Windows.Forms.Button()
        Me.tbx_EmpleadoP = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_ApellidoPaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_ApellidoMaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Departamento_DG = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.cmb_ModoContactoD = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_EmpleadoReferencia = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Mail = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.cmb_ModoContacto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_EspecifiqueDG = New System.Windows.Forms.Label()
        Me.Lbl_ModoContatoDg = New System.Windows.Forms.Label()
        Me.Lbl_ViveCFamiliaDG = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Lbl_GeneroDG = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.cmb_Ciudad = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_ModoNacionalidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.dtp_FechaNaturalizacion = New System.Windows.Forms.DateTimePicker()
        Me.cmb_Estado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Pais = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_RFC = New System.Windows.Forms.Button()
        Me.btn_CURP = New System.Windows.Forms.Button()
        Me.lbl_CiudadNac = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Lbl_VerificaraDepoDG = New System.Windows.Forms.Label()
        Me.gbx_Verifica = New System.Windows.Forms.GroupBox()
        Me.rdb_No_Verifica = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_Verifica = New System.Windows.Forms.RadioButton()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.btn_UMF = New System.Windows.Forms.Button()
        Me.lbl_Infonavit = New System.Windows.Forms.Label()
        Me.gbx_CreditoInfonavit = New System.Windows.Forms.GroupBox()
        Me.rdb_No_CreditoInfonavit = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_CreditoInfonavit = New System.Windows.Forms.RadioButton()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Lbl_SaldraDG = New System.Windows.Forms.Label()
        Me.gbx_Ruta = New System.Windows.Forms.GroupBox()
        Me.rdb_No_Ruta = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_Ruta = New System.Windows.Forms.RadioButton()
        Me.btn_Codigo = New System.Windows.Forms.Button()
        Me.btn_BuscarEmpleados = New System.Windows.Forms.Button()
        Me.lbl_UMF = New System.Windows.Forms.Label()
        Me.lbl_EmpleadoReferencia = New System.Windows.Forms.Label()
        Me.lbl_FechaVenceCredencial = New System.Windows.Forms.Label()
        Me.tbx_NombreCompleto = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NombreCompleto = New System.Windows.Forms.Label()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lbl_AMaterno = New System.Windows.Forms.Label()
        Me.lbl_APaterno = New System.Windows.Forms.Label()
        Me.tbx_Fecha_FinLabores = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_FechaBaja = New System.Windows.Forms.Label()
        Me.lbl_FechaIngreso = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lbl_CantHijos = New System.Windows.Forms.Label()
        Me.cmb_Ciudades_DG = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_CertifAcademia = New System.Windows.Forms.Label()
        Me.gbx_CertifAcademia = New System.Windows.Forms.GroupBox()
        Me.rdb_No_CertifAcademia = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_CertifAcademia = New System.Windows.Forms.RadioButton()
        Me.tbx_SueldoBase = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Calle = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_EntreCalle1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_EntreCalle2 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumExterior = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumInterior = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Colonia = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Sueldo = New System.Windows.Forms.Label()
        Me.lbl_Pasaporte = New System.Windows.Forms.Label()
        Me.lbl_NumCartilla = New System.Windows.Forms.Label()
        Me.lbl_FechaExpira = New System.Windows.Forms.Label()
        Me.lbl_TipoLicencia = New System.Windows.Forms.Label()
        Me.lbl_IMSS = New System.Windows.Forms.Label()
        Me.lbl_CURP = New System.Windows.Forms.Label()
        Me.lbl_RFC = New System.Windows.Forms.Label()
        Me.lbl_Elector = New System.Windows.Forms.Label()
        Me.tbx_Edad = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Edad = New System.Windows.Forms.Label()
        Me.lbl_ModoNacionalidad = New System.Windows.Forms.Label()
        Me.lbl_PaisNacimiento = New System.Windows.Forms.Label()
        Me.lbl_EntreCalle2 = New System.Windows.Forms.Label()
        Me.lbl_EntreCalle1 = New System.Windows.Forms.Label()
        Me.lbl_LugarNac = New System.Windows.Forms.Label()
        Me.lbl_FechaNaturalizacion = New System.Windows.Forms.Label()
        Me.lbl_FechaNac = New System.Windows.Forms.Label()
        Me.lbl_TelefonoMovil1 = New System.Windows.Forms.Label()
        Me.lbl_Telefono1 = New System.Windows.Forms.Label()
        Me.lbl_Zona_DG = New System.Windows.Forms.Label()
        Me.lbl_Longitud = New System.Windows.Forms.Label()
        Me.lbl_CP = New System.Windows.Forms.Label()
        Me.lbl_Latitud = New System.Windows.Forms.Label()
        Me.lbl_Ciudad_DG = New System.Windows.Forms.Label()
        Me.lbl_NumInterior = New System.Windows.Forms.Label()
        Me.lbl_NumExterior = New System.Windows.Forms.Label()
        Me.lbl_Colonia = New System.Windows.Forms.Label()
        Me.lbl_Calle = New System.Windows.Forms.Label()
        Me.lbl_JefeArea = New System.Windows.Forms.Label()
        Me.lbl_Firmas = New System.Windows.Forms.Label()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.gbx_JefeArea = New System.Windows.Forms.GroupBox()
        Me.rdb_No_JefeArea = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_JefeArea = New System.Windows.Forms.RadioButton()
        Me.btn_Cancelar_DG = New System.Windows.Forms.Button()
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Guardar_DG = New System.Windows.Forms.Button()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Clave = New System.Windows.Forms.Label()
        Me.lbl_Departamento = New System.Windows.Forms.Label()
        Me.lbl_Puesto = New System.Windows.Forms.Label()
        Me.lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_ModoContacto = New System.Windows.Forms.TabPage()
        Me.cmb_Localizacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_AgregarContactos = New System.Windows.Forms.Button()
        Me.btn_Borrar = New System.Windows.Forms.Button()
        Me.btn_CancelarContac = New System.Windows.Forms.Button()
        Me.lsv_Contacto = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_Descripcion = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_Contacto = New System.Windows.Forms.Label()
        Me.tab_RasgosPersonales = New System.Windows.Forms.TabPage()
        Me.gbx_Principales = New System.Windows.Forms.GroupBox()
        Me.cmb_ComplexionR = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_ColorPiel = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.pct_RasgoPerfilIzq = New System.Windows.Forms.PictureBox()
        Me.btn_RasgoPerfilIzq = New System.Windows.Forms.Button()
        Me.pct_RasgoPerfilDer = New System.Windows.Forms.PictureBox()
        Me.btn_RasgoPerfilDer = New System.Windows.Forms.Button()
        Me.btn_RasgoFrente = New System.Windows.Forms.Button()
        Me.pct_RasgoFrente = New System.Windows.Forms.PictureBox()
        Me.cmb_FactorRH = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TipoSangreR = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Cara = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_UsaAnteojos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.tbx_EstaturaR = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_EstaturaRasgos = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Lbl_ComplexcionRasgos = New System.Windows.Forms.Label()
        Me.tbx_PesoR = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_PesoRasgos = New System.Windows.Forms.Label()
        Me.Label78 = New System.Windows.Forms.Label()
        Me.lbl_Cara = New System.Windows.Forms.Label()
        Me.lbl_UsaAnteojos = New System.Windows.Forms.Label()
        Me.lbl_FactorRH = New System.Windows.Forms.Label()
        Me.lbl_TipoSangreR = New System.Windows.Forms.Label()
        Me.gbx_Boca = New System.Windows.Forms.GroupBox()
        Me.cmb_ComisurasBoca = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TamañoBoca = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_TamañoRasgos = New System.Windows.Forms.Label()
        Me.Lbl_ComisurasRasgos = New System.Windows.Forms.Label()
        Me.gbx_Menton = New System.Windows.Forms.GroupBox()
        Me.Lbl_FormRasgos = New System.Windows.Forms.Label()
        Me.Lbl_InclinacionRasgos = New System.Windows.Forms.Label()
        Me.cmb_InclinacionMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TipoMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_TipoRasgos = New System.Windows.Forms.Label()
        Me.gbx_Labios = New System.Windows.Forms.GroupBox()
        Me.cmb_ProminenciaLabios = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AlturaNasoLabial = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_EspesorLabios = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_AlturaNasoLab = New System.Windows.Forms.Label()
        Me.Lbl_ProminenciaRasgos = New System.Windows.Forms.Label()
        Me.Lbl_EspesorRasgos = New System.Windows.Forms.Label()
        Me.gbx_Ojos = New System.Windows.Forms.GroupBox()
        Me.cmb_ColorOjos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_ForRasgos = New System.Windows.Forms.Label()
        Me.Lbl_TamRasgos = New System.Windows.Forms.Label()
        Me.cmb_TamañoOjos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaOjos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_ColRasgos = New System.Windows.Forms.Label()
        Me.gbx_Cejas = New System.Windows.Forms.GroupBox()
        Me.cmb_TamañoCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ImplantacionCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_DireccionCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_Tamaño = New System.Windows.Forms.Label()
        Me.Lbl_ImplanRasgos = New System.Windows.Forms.Label()
        Me.Lbl_FRasgos = New System.Windows.Forms.Label()
        Me.Lbl_DireccionRasgos = New System.Windows.Forms.Label()
        Me.gbx_Frente = New System.Windows.Forms.GroupBox()
        Me.cmb_AnchoFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_InclinacionFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AlturaFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_InclinRasgos = New System.Windows.Forms.Label()
        Me.Lbl_AnchRasgos = New System.Windows.Forms.Label()
        Me.Lbl_AltRasgos = New System.Windows.Forms.Label()
        Me.gbx_Nariz = New System.Windows.Forms.GroupBox()
        Me.cmb_AlturaNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_BaseNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AnchoNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_DorsoNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_RaizNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_AlturaRasgos = New System.Windows.Forms.Label()
        Me.Lbl_BaseRasgos = New System.Windows.Forms.Label()
        Me.Lbl_DorsoRasgos = New System.Windows.Forms.Label()
        Me.Lbl_AnchoRasgos = New System.Windows.Forms.Label()
        Me.Lbl_RaizRasgos = New System.Windows.Forms.Label()
        Me.gbx_Oreja = New System.Windows.Forms.GroupBox()
        Me.gbx_Lobulo = New System.Windows.Forms.GroupBox()
        Me.cmb_LobuloDimension = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_LobuloParticularidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_LobuloAdherencia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_ParticularidadRasgos = New System.Windows.Forms.Label()
        Me.Lbl_AdheRasgos = New System.Windows.Forms.Label()
        Me.Lbl_DimensionRasgos = New System.Windows.Forms.Label()
        Me.gbx_Helix = New System.Windows.Forms.GroupBox()
        Me.Lbl_SuperiorRasgos = New System.Windows.Forms.Label()
        Me.cmb_HelixContorno = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixAdherencia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixPosterior = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixSuperior = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_PosteriorRasgos = New System.Windows.Forms.Label()
        Me.Lbl_AdherenciaRasgos = New System.Windows.Forms.Label()
        Me.Lbl_ContornoRasgos = New System.Windows.Forms.Label()
        Me.cmb_OriginalOreja = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaOreja = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_OriginalRasgos = New System.Windows.Forms.Label()
        Me.Lbl_FormaRas = New System.Windows.Forms.Label()
        Me.gbx_Cabello = New System.Windows.Forms.GroupBox()
        Me.cmb_ColorCabello = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_ImplantacionCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Calvicie = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_CantidadCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_ImplantacionRasgos = New System.Windows.Forms.Label()
        Me.Lbl_CalvicieRasgos = New System.Windows.Forms.Label()
        Me.Lbl_ColorRasgos = New System.Windows.Forms.Label()
        Me.Lbl_FormaRasgos = New System.Windows.Forms.Label()
        Me.Lbl_CantidadRasgos = New System.Windows.Forms.Label()
        Me.btn_CancelarRasgos = New System.Windows.Forms.Button()
        Me.btn_GuardarRasgos = New System.Windows.Forms.Button()
        Me.tab_DatosEscolares = New System.Windows.Forms.TabPage()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.Label45 = New System.Windows.Forms.Label()
        Me.Label44 = New System.Windows.Forms.Label()
        Me.Label43 = New System.Windows.Forms.Label()
        Me.cmb_ATermino = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.tbx_Folio = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Promedio = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NombreCurso = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FInicioCurso = New System.Windows.Forms.DateTimePicker()
        Me.cmb_AInicio = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Documentacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_NombreEscuela = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Carrera = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Especialidad = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Documentacion = New System.Windows.Forms.Label()
        Me.gbx_CursosRecibidos = New System.Windows.Forms.GroupBox()
        Me.btn_BuscarCurso = New System.Windows.Forms.Button()
        Me.lbl_TipoCurso = New System.Windows.Forms.Label()
        Me.lbl_TipoCursoA = New System.Windows.Forms.Label()
        Me.cmb_TipoCurso = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_Borrar_DatosEscolares = New System.Windows.Forms.Button()
        Me.btn_Cancelar_DatosEscolares = New System.Windows.Forms.Button()
        Me.btn_Modificar_DatosEscolares = New System.Windows.Forms.Button()
        Me.lbl_DocumentoCursoA = New System.Windows.Forms.Label()
        Me.lbl_FTerminoCursoA = New System.Windows.Forms.Label()
        Me.lbl_FInicioCursoA = New System.Windows.Forms.Label()
        Me.lbl_CursoFinalizadoA = New System.Windows.Forms.Label()
        Me.lbl_NombreCursoA = New System.Windows.Forms.Label()
        Me.gbx_CursoFinalizado = New System.Windows.Forms.GroupBox()
        Me.rdb_No_CursoFin = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_CursoFin = New System.Windows.Forms.RadioButton()
        Me.btn_Agregar = New System.Windows.Forms.Button()
        Me.cmb_DocumentoCurso = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Comentarios = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FTerminoCurso = New System.Windows.Forms.DateTimePicker()
        Me.lbl_Comentarios = New System.Windows.Forms.Label()
        Me.btn_Guardar_DatosEscolares = New System.Windows.Forms.Button()
        Me.lsv_Cursos = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_Instructor = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NombreCurso = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.lbl_FechaTermino = New System.Windows.Forms.Label()
        Me.lbl_Instructor = New System.Windows.Forms.Label()
        Me.lbl_TipoDocto = New System.Windows.Forms.Label()
        Me.tbx_CedulaProfesional = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_CedulaProf = New System.Windows.Forms.Label()
        Me.lbl_Promedio = New System.Windows.Forms.Label()
        Me.lbl_Folio = New System.Windows.Forms.Label()
        Me.lbl_ATermino = New System.Windows.Forms.Label()
        Me.lbl_AInicio = New System.Windows.Forms.Label()
        Me.lbl_Carrera = New System.Windows.Forms.Label()
        Me.lbl_Especialidad = New System.Windows.Forms.Label()
        Me.lbl_NombreEscuela = New System.Windows.Forms.Label()
        Me.lbl_UltimosEstudios2 = New System.Windows.Forms.Label()
        Me.cmb_UltimosEstudios = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Comprobable = New System.Windows.Forms.Label()
        Me.tab_DatosFamiliares = New System.Windows.Forms.TabPage()
        Me.cmb_PaisesDatosFamiliares = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_CodigoPostal_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Telefono_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_LatitudEmpleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_LongitudEmpleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FechaIngreso_Empleos = New System.Windows.Forms.DateTimePicker()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.cmb_CiudadesDatosFamiliares = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.btn_Borrar_DatosFamiliares = New System.Windows.Forms.Button()
        Me.btn_Cancelar_DatosFamiliares = New System.Windows.Forms.Button()
        Me.btn_Modificar_Familiares = New System.Windows.Forms.Button()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.dtp_FecNac_Familiar = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Vive = New System.Windows.Forms.GroupBox()
        Me.rdb_Si_Vive = New System.Windows.Forms.RadioButton()
        Me.rdb_No_Vive = New System.Windows.Forms.RadioButton()
        Me.gbx_MismoDomicilio = New System.Windows.Forms.GroupBox()
        Me.rdb_Si_MismoDom = New System.Windows.Forms.RadioButton()
        Me.rdb_No_MismoDom = New System.Windows.Forms.RadioButton()
        Me.cmb_Parentesco = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Parentesco = New System.Windows.Forms.Label()
        Me.tbx_TelefonoFamiliares = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Domicilio_Familiares = New Modulo_Reclutamiento.cp_Textbox()
        Me.gbx_DepEconomico = New System.Windows.Forms.GroupBox()
        Me.rdb_Si_DepEcon = New System.Windows.Forms.RadioButton()
        Me.rdb_No_DepEcon = New System.Windows.Forms.RadioButton()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.lbl_Domicilio = New System.Windows.Forms.Label()
        Me.lbl_FNacimiento = New System.Windows.Forms.Label()
        Me.tbx_NombreFamiliar = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NombreFamiliar = New System.Windows.Forms.Label()
        Me.btn_Agregar_Familiares = New System.Windows.Forms.Button()
        Me.btn_Guardar_Familiares = New System.Windows.Forms.Button()
        Me.lsv_Familiares = New Modulo_Reclutamiento.cp_Listview()
        Me.tab_Empleos = New System.Windows.Forms.TabPage()
        Me.tbx_Colonias_Empleos = New System.Windows.Forms.TextBox()
        Me.cmb_Paises_Empleos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btn_MapaLaborales = New System.Windows.Forms.Button()
        Me.lsv_PredictivoEmpresas = New Modulo_Reclutamiento.cp_Listview()
        Me.lbl_LongitudEmpleos = New System.Windows.Forms.Label()
        Me.lbl_LatitudEmpleos = New System.Windows.Forms.Label()
        Me.tbx_EntreCalle2Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumeroExt_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumeroInt_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_EntreCalle2Empleos = New System.Windows.Forms.Label()
        Me.tbx_EntreCalle1Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_EntreCalle1Empleos = New System.Windows.Forms.Label()
        Me.lbl_EmpresaSeguridad = New System.Windows.Forms.Label()
        Me.gbx_EmpresaSeg = New System.Windows.Forms.GroupBox()
        Me.rdb_No_EmpresaSeg = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_EmpresaSeg = New System.Windows.Forms.RadioButton()
        Me.lbl_PorteArmas = New System.Windows.Forms.Label()
        Me.gbx_PorteArmas = New System.Windows.Forms.GroupBox()
        Me.rdb_No_PorteArmas = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_PorteArmas = New System.Windows.Forms.RadioButton()
        Me.lbl_ColoniaEmpleos = New System.Windows.Forms.Label()
        Me.Label79 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label72 = New System.Windows.Forms.Label()
        Me.Label126 = New System.Windows.Forms.Label()
        Me.Label71 = New System.Windows.Forms.Label()
        Me.Label125 = New System.Windows.Forms.Label()
        Me.Label70 = New System.Windows.Forms.Label()
        Me.Label65 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cmb_MotivoSeparacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_OtroMotivo = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Agregar_Empleos = New System.Windows.Forms.Button()
        Me.cmb_Ciudades_Empleos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.dtp_FechaBaja_Empleos = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_OtroMotEmpleos = New System.Windows.Forms.Label()
        Me.Lbl_MotSepEmpleos = New System.Windows.Forms.Label()
        Me.tbx_SueldoFinal_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_SueFinMenEmpleos = New System.Windows.Forms.Label()
        Me.tbx_SueldoInicial_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_SueIniMenEmpleos = New System.Windows.Forms.Label()
        Me.Lbl_TelefonoEmpleados = New System.Windows.Forms.Label()
        Me.tbx_PuestoJefe_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_PueJefInmEmpleado = New System.Windows.Forms.Label()
        Me.tbx_NombreJefe_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_NomJefInmEmpleos = New System.Windows.Forms.Label()
        Me.tbx_Puesto_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_PuestoEmpleados = New System.Windows.Forms.Label()
        Me.lbl_FBaja = New System.Windows.Forms.Label()
        Me.lbl_FIngreso = New System.Windows.Forms.Label()
        Me.btn_Borrar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Modificar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Guardar_Empleos = New System.Windows.Forms.Button()
        Me.lsv_Empleos = New Modulo_Reclutamiento.cp_Listview()
        Me.Lbl_Cp_Empleados = New System.Windows.Forms.Label()
        Me.Lbl_Ciudad_Empleos = New System.Windows.Forms.Label()
        Me.Lbl_NumeroInt_Empleos = New System.Windows.Forms.Label()
        Me.Lbl_NumeroExt_Empleos = New System.Windows.Forms.Label()
        Me.tbx_Calle_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_CalleE = New System.Windows.Forms.Label()
        Me.tbx_NombreEmpresa_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_NombreEmpE = New System.Windows.Forms.Label()
        Me.tab_Referencias = New System.Windows.Forms.TabPage()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label34 = New System.Windows.Forms.Label()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.txt_am = New Modulo_Reclutamiento.cp_Textbox()
        Me.txt_ap = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.cmb_ocupacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Nombre_Referencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_Masculino_Referencias = New System.Windows.Forms.RadioButton()
        Me.tbx_Colonias_Referencias = New System.Windows.Forms.TextBox()
        Me.cmb_Paises_Referencias = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_Colonia_Referencias = New System.Windows.Forms.Label()
        Me.tbx_EntreCalle2_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_EntreCalle2_Referencias = New System.Windows.Forms.Label()
        Me.tbx_EntreCalle1_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_EntreCalle1_Referencias = New System.Windows.Forms.Label()
        Me.Label68 = New System.Windows.Forms.Label()
        Me.tbx_Telefono_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Ciudades_Referencias = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_CodigoPostal_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Agregar_Referencias = New System.Windows.Forms.Button()
        Me.lbl_Telefono_Referencias = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.btn_Borrar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Modificar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Guardar_Referencias = New System.Windows.Forms.Button()
        Me.lsv_Referencias = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_NumeroInt_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumeroExt_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_CpR = New System.Windows.Forms.Label()
        Me.Lbl_CiudadR = New System.Windows.Forms.Label()
        Me.Lbl_NumIntR = New System.Windows.Forms.Label()
        Me.Lbl_NunExtR = New System.Windows.Forms.Label()
        Me.tbx_Calle_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_CalleR = New System.Windows.Forms.Label()
        Me.tbx_Ocupacion_Referencias = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_OcupacionR = New System.Windows.Forms.Label()
        Me.gbx_Genero_Referencias = New System.Windows.Forms.GroupBox()
        Me.rdb_Femenino_Referencias = New System.Windows.Forms.RadioButton()
        Me.lbl_NombreReferencia = New System.Windows.Forms.Label()
        Me.cmb_TipoReferencia = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_TipoReferencia = New System.Windows.Forms.Label()
        Me.tab_DatosVarios = New System.Windows.Forms.TabPage()
        Me.cmb_cantidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_refionesSSP = New System.Windows.Forms.Button()
        Me.cmb_region = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cmb_vista = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmb_lado = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label153 = New System.Windows.Forms.Label()
        Me.Label152 = New System.Windows.Forms.Label()
        Me.Label76 = New System.Windows.Forms.Label()
        Me.tbx_Comentarios_Señas = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Agregar_Señas = New System.Windows.Forms.Button()
        Me.lbl_Comentarios_Señas = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Lbl_Ejemplo2DV = New System.Windows.Forms.Label()
        Me.Lbl_EjemploDV = New System.Windows.Forms.Label()
        Me.btn_Borrar_DatosVarios = New System.Windows.Forms.Button()
        Me.btn_Cancelar_DatosVarios = New System.Windows.Forms.Button()
        Me.btn_Modificar_DatosVarios = New System.Windows.Forms.Button()
        Me.lsv_SeñasParticulares = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_CantidadSeñas = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_CantidadSeñas = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.tbx_UbicacionSeñas = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_UbicacionSeñas = New System.Windows.Forms.Label()
        Me.tbx_FormaSeñas = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_FormaSeñas = New System.Windows.Forms.Label()
        Me.cmb_SeñasParticulares = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Señas = New System.Windows.Forms.Label()
        Me.tbx_Habilidades = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Habilidades = New System.Windows.Forms.Label()
        Me.tbx_ActividadesCulturales = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ActivCulturales = New System.Windows.Forms.Label()
        Me.tbx_Idiomas = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Idiomas = New System.Windows.Forms.Label()
        Me.tbx_Vicios = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Vicios = New System.Windows.Forms.Label()
        Me.tbx_ValorVehiculo = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ValorVehiculo = New System.Windows.Forms.Label()
        Me.tbx_Modelo = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Modelo = New System.Windows.Forms.Label()
        Me.gbx_VehiculoPropio = New System.Windows.Forms.GroupBox()
        Me.rdb_No_Vehiculo = New System.Windows.Forms.RadioButton()
        Me.rdb_Si_Vehiculo = New System.Windows.Forms.RadioButton()
        Me.tbx_ValorVivienda = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ValorVivienda = New System.Windows.Forms.Label()
        Me.tbx_PagoMensual = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_PagoMensual = New System.Windows.Forms.Label()
        Me.cmb_TipoVivienda = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_TipoVivienda = New System.Windows.Forms.Label()
        Me.tbx_Descripcion_IngresoAdicional = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_DescripcionIA = New System.Windows.Forms.Label()
        Me.tbx_GastoFamiliar = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_IngresoAdicional = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_GastoFamiliar = New System.Windows.Forms.Label()
        Me.tbx_IngresoFamiliar = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_IngresoAdicional = New System.Windows.Forms.Label()
        Me.lbl_IngresoFamiliar = New System.Windows.Forms.Label()
        Me.btn_Guardar_DatosVarios = New System.Windows.Forms.Button()
        Me.tab_PapeleriaRecibida = New System.Windows.Forms.TabPage()
        Me.btn_DoctosCancelar = New System.Windows.Forms.Button()
        Me.btn_DoctosImportar = New System.Windows.Forms.Button()
        Me.lsv_PapeleriaRecibida = New Modulo_Reclutamiento.cp_Listview()
        Me.btn_Guardar_PapeleriaRecibida = New System.Windows.Forms.Button()
        Me.tab_DatosEmergencia = New System.Windows.Forms.TabPage()
        Me.tbx_TelefonoCelular_Emergencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Email_Emergencia = New System.Windows.Forms.TextBox()
        Me.Lbl_TelefonoCelDE = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbx_Relacion_Emergencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Domicilio_Emergencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_telefonoFijo_Emergencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Borrar_Emergencia = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Emergencia = New System.Windows.Forms.Button()
        Me.btn_Modificar_Emergencia = New System.Windows.Forms.Button()
        Me.btn_Guardar_Emergencia = New System.Windows.Forms.Button()
        Me.lsv_datosEmergencia = New Modulo_Reclutamiento.cp_Listview()
        Me.Lbl_ObservacionesDE = New System.Windows.Forms.Label()
        Me.rtb_Observaciones_Emergencia = New System.Windows.Forms.RichTextBox()
        Me.Lbl_EmailDE = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Lbl_TipoRelacionDE = New System.Windows.Forms.Label()
        Me.Lbl_TelefonoDE = New System.Windows.Forms.Label()
        Me.Lbl_DomicilioDE = New System.Windows.Forms.Label()
        Me.tbx_Nombre_Emergencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_NombreDE = New System.Windows.Forms.Label()
        Me.btn_Agregar_Emergencia = New System.Windows.Forms.Button()
        Me.tab_Adicionales = New System.Windows.Forms.TabPage()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.gbx_EstudioSocioEco = New System.Windows.Forms.GroupBox()
        Me.rdb_ESocioNO = New System.Windows.Forms.RadioButton()
        Me.rdb_ESocioSI = New System.Windows.Forms.RadioButton()
        Me.dtp_FechaESocioeconomico = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaExamenMedico = New System.Windows.Forms.DateTimePicker()
        Me.dtp_FechaCartaApenales = New System.Windows.Forms.DateTimePicker()
        Me.tbx_ObservacionesGrales = New System.Windows.Forms.TextBox()
        Me.tbx_ObservAntidoping = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.dtp_FechaPsicometrico = New System.Windows.Forms.DateTimePicker()
        Me.tbx_ObservPsicometrico = New System.Windows.Forms.TextBox()
        Me.lbl_ExaPsicometrico = New System.Windows.Forms.Label()
        Me.tbx_ObservEstudioSE = New System.Windows.Forms.TextBox()
        Me.tbx_ObservExaMedico = New System.Windows.Forms.TextBox()
        Me.tbx_ObservDemandas = New System.Windows.Forms.TextBox()
        Me.tbx_ObservEnfermedades = New System.Windows.Forms.TextBox()
        Me.tbx_ObservAntecedentes = New System.Windows.Forms.TextBox()
        Me.lbl_ResultadoAntidoping = New System.Windows.Forms.Label()
        Me.cmb_Antidoping = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.gbx_Demandas = New Modulo_Reclutamiento.cp_si_no()
        Me.lbl_ObservacionesGrales = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.lbl_AntecedentesPenales = New System.Windows.Forms.Label()
        Me.lbl_EstudioSocioeconomico = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.lbl_ExamenMedico = New System.Windows.Forms.Label()
        Me.lbl_Enfermedades = New System.Windows.Forms.Label()
        Me.lbl_Demandas = New System.Windows.Forms.Label()
        Me.dtp_FechaAntidoping = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Enfermedades = New Modulo_Reclutamiento.cp_si_no()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbx_ExamenAntidoping = New System.Windows.Forms.GroupBox()
        Me.rdb_AntidopingNo = New System.Windows.Forms.RadioButton()
        Me.rdb_AntidopingSI = New System.Windows.Forms.RadioButton()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.gbx_Antecedentes = New System.Windows.Forms.GroupBox()
        Me.rdb_CartaAPNO = New System.Windows.Forms.RadioButton()
        Me.rdb_CartaAPSI = New System.Windows.Forms.RadioButton()
        Me.gbx_ExamenMedico = New System.Windows.Forms.GroupBox()
        Me.rdb_ExMedNO = New System.Windows.Forms.RadioButton()
        Me.rdb_ExMedSI = New System.Windows.Forms.RadioButton()
        Me.gbx_ExamenPsicometrico = New System.Windows.Forms.GroupBox()
        Me.rdb_ExPsicoNO = New System.Windows.Forms.RadioButton()
        Me.rdb_ExPsicoSI = New System.Windows.Forms.RadioButton()
        Me.btn_CancelarAdicionales = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.tab_Expediente = New System.Windows.Forms.TabPage()
        Me.btn_CancelarExpediente = New System.Windows.Forms.Button()
        Me.btn_GuardarExpediente = New System.Windows.Forms.Button()
        Me.lbl_EstacionActualiza = New System.Windows.Forms.Label()
        Me.tbx_EstacionActualiza = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_ComentariosRevision = New System.Windows.Forms.Label()
        Me.tbx_ComentariosRevision = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FechaUltimaActual = New System.Windows.Forms.DateTimePicker()
        Me.cmb_UsuarioUltimaActual = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_UsuarioUltActual = New System.Windows.Forms.Label()
        Me.lbl_FechaUltimaActualiz = New System.Windows.Forms.Label()
        Me.dtp_Fecharevision = New System.Windows.Forms.DateTimePicker()
        Me.cmb_UsuarioRevisa = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_UsuarioRevisa = New System.Windows.Forms.Label()
        Me.lbl_FechaRevision = New System.Windows.Forms.Label()
        Me.tlt_RasgosMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_Investigacion = New System.Windows.Forms.Button()
        Me.btn_InvestigacionPersonal = New System.Windows.Forms.Button()
        Me.Tab_Catalogo.SuspendLayout
        Me.tab_Listado.SuspendLayout
        Me.Tab_Nuevo.SuspendLayout
        Me.tab_DatosEmpleado.SuspendLayout
        Me.tab_DatosGenerales.SuspendLayout
        Me.GroupBox3.SuspendLayout
        Me.GroupBox1.SuspendLayout
        Me.GroupBox6.SuspendLayout
        Me.GroupBox5.SuspendLayout
        Me.GroupBox2.SuspendLayout
        Me.gbx_CatalogoFirmas.SuspendLayout
        Me.gbx_Porte.SuspendLayout
        Me.gbx_Verifica.SuspendLayout
        Me.gbx_CreditoInfonavit.SuspendLayout
        Me.gbx_Ruta.SuspendLayout
        Me.gbx_CertifAcademia.SuspendLayout
        Me.gbx_JefeArea.SuspendLayout
        Me.tab_ModoContacto.SuspendLayout
        Me.tab_RasgosPersonales.SuspendLayout
        Me.gbx_Principales.SuspendLayout
        CType(Me.pct_RasgoPerfilIzq, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pct_RasgoPerfilDer, System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.pct_RasgoFrente, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbx_Boca.SuspendLayout
        Me.gbx_Menton.SuspendLayout
        Me.gbx_Labios.SuspendLayout
        Me.gbx_Ojos.SuspendLayout
        Me.gbx_Cejas.SuspendLayout
        Me.gbx_Frente.SuspendLayout
        Me.gbx_Nariz.SuspendLayout
        Me.gbx_Oreja.SuspendLayout
        Me.gbx_Lobulo.SuspendLayout
        Me.gbx_Helix.SuspendLayout
        Me.gbx_Cabello.SuspendLayout
        Me.tab_DatosEscolares.SuspendLayout
        Me.gbx_CursosRecibidos.SuspendLayout
        Me.gbx_CursoFinalizado.SuspendLayout
        Me.tab_DatosFamiliares.SuspendLayout
        Me.gbx_Vive.SuspendLayout
        Me.gbx_MismoDomicilio.SuspendLayout
        Me.gbx_DepEconomico.SuspendLayout
        Me.tab_Empleos.SuspendLayout
        Me.gbx_EmpresaSeg.SuspendLayout
        Me.gbx_PorteArmas.SuspendLayout
        Me.tab_Referencias.SuspendLayout
        Me.gbx_Genero_Referencias.SuspendLayout
        Me.tab_DatosVarios.SuspendLayout
        Me.gbx_VehiculoPropio.SuspendLayout
        Me.tab_PapeleriaRecibida.SuspendLayout
        Me.tab_DatosEmergencia.SuspendLayout
        Me.tab_Adicionales.SuspendLayout
        Me.gbx_EstudioSocioEco.SuspendLayout
        Me.gbx_ExamenAntidoping.SuspendLayout
        Me.gbx_Antecedentes.SuspendLayout
        Me.gbx_ExamenMedico.SuspendLayout
        Me.gbx_ExamenPsicometrico.SuspendLayout
        Me.tab_Expediente.SuspendLayout
        Me.SuspendLayout
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(1545, 745)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.btn_FichaTecnica)
        Me.tab_Listado.Controls.Add(Me.Lbl_Numero)
        Me.tab_Listado.Controls.Add(Me.cmb_PuestoFiltro)
        Me.tab_Listado.Controls.Add(Me.chk_Status)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.btn_Boleta)
        Me.tab_Listado.Controls.Add(Me.btn_Visitas)
        Me.tab_Listado.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.tab_Listado.Controls.Add(Me.chk_PuestoFiltro)
        Me.tab_Listado.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.tab_Listado.Controls.Add(Me.btn_Fotos)
        Me.tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Mapa)
        Me.tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.tab_Listado.Controls.Add(Me.btn_MostrarCatalogo)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_StatusL)
        Me.tab_Listado.Controls.Add(Me.Lbl_PuestoL)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_DepartamentoL)
        Me.tab_Listado.Controls.Add(Me.lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(1537, 719)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'btn_FichaTecnica
        '
        Me.btn_FichaTecnica.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_FichaTecnica.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Planear
        Me.btn_FichaTecnica.Location = New System.Drawing.Point(529, 681)
        Me.btn_FichaTecnica.Name = "btn_FichaTecnica"
        Me.btn_FichaTecnica.Size = New System.Drawing.Size(130, 30)
        Me.btn_FichaTecnica.TabIndex = 22
        Me.btn_FichaTecnica.Text = "&Ficha Tecnica"
        Me.btn_FichaTecnica.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FichaTecnica.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FichaTecnica.UseVisualStyleBackColor = True
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(1309, 92)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 21
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(88, 57)
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
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(322, 85)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 12
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(88, 83)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 11
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Boleta
        '
        Me.btn_Boleta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Boleta.Enabled = False
        Me.btn_Boleta.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Planear
        Me.btn_Boleta.Location = New System.Drawing.Point(398, 681)
        Me.btn_Boleta.Name = "btn_Boleta"
        Me.btn_Boleta.Size = New System.Drawing.Size(130, 30)
        Me.btn_Boleta.TabIndex = 17
        Me.btn_Boleta.Text = "&Boleta"
        Me.btn_Boleta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Boleta.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Boleta.UseVisualStyleBackColor = True
        '
        'btn_Visitas
        '
        Me.btn_Visitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Visitas.Enabled = False
        Me.btn_Visitas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.CasaVisita
        Me.btn_Visitas.Location = New System.Drawing.Point(267, 681)
        Me.btn_Visitas.Name = "btn_Visitas"
        Me.btn_Visitas.Size = New System.Drawing.Size(130, 30)
        Me.btn_Visitas.TabIndex = 17
        Me.btn_Visitas.Text = "Visita &Domiciliaria"
        Me.btn_Visitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Visitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Visitas.UseVisualStyleBackColor = True
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(88, 32)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 4
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(417, 61)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 9
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(417, 35)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 5
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'btn_Fotos
        '
        Me.btn_Fotos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Fotos.Enabled = False
        Me.btn_Fotos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_Fotos.Location = New System.Drawing.Point(136, 681)
        Me.btn_Fotos.Name = "btn_Fotos"
        Me.btn_Fotos.Size = New System.Drawing.Size(130, 30)
        Me.btn_Fotos.TabIndex = 16
        Me.btn_Fotos.Text = "&Fotos"
        Me.btn_Fotos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Fotos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Fotos.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(6, 681)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Modificar.TabIndex = 15
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(1404, 681)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Cerrar.TabIndex = 20
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Mapa
        '
        Me.btn_Mapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Mapa.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.MapaMundo
        Me.btn_Mapa.Location = New System.Drawing.Point(1274, 681)
        Me.btn_Mapa.Name = "btn_Mapa"
        Me.btn_Mapa.Size = New System.Drawing.Size(130, 30)
        Me.btn_Mapa.TabIndex = 19
        Me.btn_Mapa.Text = "&Ver en Mapa"
        Me.btn_Mapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mapa.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(660, 681)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Exportar.TabIndex = 18
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(495, 83)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(130, 30)
        Me.btn_MostrarCatalogo.TabIndex = 13
        Me.btn_MostrarCatalogo.Text = "M&ostrar"
        Me.btn_MostrarCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarCatalogo.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'Lbl_StatusL
        '
        Me.Lbl_StatusL.AutoSize = True
        Me.Lbl_StatusL.Location = New System.Drawing.Point(45, 86)
        Me.Lbl_StatusL.Name = "Lbl_StatusL"
        Me.Lbl_StatusL.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_StatusL.TabIndex = 10
        Me.Lbl_StatusL.Text = "Status"
        '
        'Lbl_PuestoL
        '
        Me.Lbl_PuestoL.AutoSize = True
        Me.Lbl_PuestoL.Location = New System.Drawing.Point(42, 60)
        Me.Lbl_PuestoL.Name = "Lbl_PuestoL"
        Me.Lbl_PuestoL.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoL.TabIndex = 7
        Me.Lbl_PuestoL.Text = "Puesto"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(88, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(537, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_DepartamentoL
        '
        Me.Lbl_DepartamentoL.AutoSize = True
        Me.Lbl_DepartamentoL.Location = New System.Drawing.Point(8, 35)
        Me.Lbl_DepartamentoL.Name = "Lbl_DepartamentoL"
        Me.Lbl_DepartamentoL.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DepartamentoL.TabIndex = 3
        Me.Lbl_DepartamentoL.Text = "Departamento"
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(42, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 118)
        ListViewColumnSorter32.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter32.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter32
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 10
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 35
        Me.lsv_Catalogo.Row3 = 15
        Me.lsv_Catalogo.Row4 = 15
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(1525, 557)
        Me.lsv_Catalogo.TabIndex = 14
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.tab_DatosEmpleado)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(1537, 719)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'tab_DatosEmpleado
        '
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosGenerales)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_ModoContacto)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_RasgosPersonales)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosEscolares)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosFamiliares)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Empleos)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Referencias)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosVarios)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_PapeleriaRecibida)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosEmergencia)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Adicionales)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Expediente)
        Me.tab_DatosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_DatosEmpleado.Location = New System.Drawing.Point(3, 3)
        Me.tab_DatosEmpleado.Name = "tab_DatosEmpleado"
        Me.tab_DatosEmpleado.SelectedIndex = 0
        Me.tab_DatosEmpleado.Size = New System.Drawing.Size(1531, 713)
        Me.tab_DatosEmpleado.TabIndex = 0
        '
        'tab_DatosGenerales
        '
        Me.tab_DatosGenerales.Controls.Add(Me.Label37)
        Me.tab_DatosGenerales.Controls.Add(Me.Label48)
        Me.tab_DatosGenerales.Controls.Add(Me.GroupBox3)
        Me.tab_DatosGenerales.Controls.Add(Me.GroupBox1)
        Me.tab_DatosGenerales.Controls.Add(Me.Btn_AgregarColonia)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_CatalogoFirmas)
        Me.tab_DatosGenerales.Controls.Add(Me.Label22)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Colonias)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaExpiraFed)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaExpiraFed)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroLicenciaFed)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroLicenciaFed)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_IdTributario)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_RFC_Extranjero)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_ImprimirSolicitud)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_MapaEmpleado)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_MontoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_MontoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_TipoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_TipoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroCredito)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroCredito)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaActualizacionDG)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaActualDGview)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_PortaArma)
        Me.tab_DatosGenerales.Controls.Add(Me.Label6)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_Porte)
        Me.tab_DatosGenerales.Controls.Add(Me.Label5)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaIngreso)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaVenceCredencial)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_EmailDG)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_MailPersonal)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_CUIP)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CUIP)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Puesto)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_ComprobarListaNegra)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_EmpleadoP)
        Me.tab_DatosGenerales.Controls.Add(Me.Label158)
        Me.tab_DatosGenerales.Controls.Add(Me.Label139)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoContactoD)
        Me.tab_DatosGenerales.Controls.Add(Me.Label163)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoContacto)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_EspecifiqueDG)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_ModoContatoDg)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ViveConFam)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_ViveCFamiliaDG)
        Me.tab_DatosGenerales.Controls.Add(Me.Label129)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Genero)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_GeneroDG)
        Me.tab_DatosGenerales.Controls.Add(Me.Label51)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Ciudad)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Estado)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Pais)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_RFC)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_CURP)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CiudadNac)
        Me.tab_DatosGenerales.Controls.Add(Me.Label156)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_VerificaraDepoDG)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_Verifica)
        Me.tab_DatosGenerales.Controls.Add(Me.Label155)
        Me.tab_DatosGenerales.Controls.Add(Me.Label154)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Infonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_CreditoInfonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.Label151)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_SaldraDG)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_Ruta)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Codigo)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_BuscarEmpleados)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoNacionalidad)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_EmpleadoReferencia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EmpleadoReferencia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaVenceCredencial)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NombreCompleto)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NombreCompleto)
        Me.tab_DatosGenerales.Controls.Add(Me.Label69)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_AMaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_APaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_ApellidoMaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_ApellidoPaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Fecha_FinLabores)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaBaja)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaIngreso)
        Me.tab_DatosGenerales.Controls.Add(Me.Label140)
        Me.tab_DatosGenerales.Controls.Add(Me.Label142)
        Me.tab_DatosGenerales.Controls.Add(Me.Label42)
        Me.tab_DatosGenerales.Controls.Add(Me.Label41)
        Me.tab_DatosGenerales.Controls.Add(Me.Label40)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_CantidadHijos)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CantHijos)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Zonas)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Ciudades_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CertifAcademia)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_CertifAcademia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_SueldoBase)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Sueldo)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaExpira)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_TipoLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Pasaporte)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Pasaporte)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumCartilla)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumCartilla)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaExpira)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_TipoLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_IMSS)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_IMSS)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_CURP)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CURP)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_RFC)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_RFC)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Elector)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Elector)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Edad)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Edad)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_ModoNacionalidad)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_PaisNacimiento)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_EntreCalle2)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EntreCalle2)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_EntreCalle1)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EntreCalle1)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_LugarNac)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaNaturalizacion)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaNac)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaNaturalizacion)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaNac)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_TelefonoMovil1)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_TelefonoMovil1)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Telefono1)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Telefono1)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Zona_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_CodigoPostal)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Longitud)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Latitud)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumInterior)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumExterior)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Colonia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Longitud)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CP)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Latitud)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Ciudad_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumInterior)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumExterior)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Colonia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Calle)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Calle)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_JefeArea)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Firmas)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Mail)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Mail)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Nombres)
        Me.tab_DatosGenerales.Controls.Add(Me.gbx_JefeArea)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Cancelar_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Clave)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Guardar_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Departamento_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_EstadoCivil)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Nombres)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Clave)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Departamento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Puesto)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EstadoCivil)
        Me.tab_DatosGenerales.Controls.Add(Me.Label2)
        Me.tab_DatosGenerales.Controls.Add(Me.Label144)
        Me.tab_DatosGenerales.Controls.Add(Me.Label149)
        Me.tab_DatosGenerales.Controls.Add(Me.Label3)
        Me.tab_DatosGenerales.Controls.Add(Me.Label4)
        Me.tab_DatosGenerales.Controls.Add(Me.Label1)
        Me.tab_DatosGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosGenerales.Name = "tab_DatosGenerales"
        Me.tab_DatosGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DatosGenerales.Size = New System.Drawing.Size(1523, 687)
        Me.tab_DatosGenerales.TabIndex = 0
        Me.tab_DatosGenerales.Text = "Datos Generales"
        Me.tab_DatosGenerales.UseVisualStyleBackColor = True
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(556, 531)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(39, 13)
        Me.Label37.TabIndex = 193
        Me.Label37.Text = "¿LPC?"
        '
        'Label48
        '
        Me.Label48.AutoSize = True
        Me.Label48.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label48.ForeColor = System.Drawing.Color.Red
        Me.Label48.Location = New System.Drawing.Point(717, 526)
        Me.Label48.Name = "Label48"
        Me.Label48.Size = New System.Drawing.Size(13, 16)
        Me.Label48.TabIndex = 194
        Me.Label48.Text = "*"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdb_LPCno)
        Me.GroupBox3.Controls.Add(Me.rdb_LPCsi)
        Me.GroupBox3.Location = New System.Drawing.Point(601, 517)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(110, 30)
        Me.GroupBox3.TabIndex = 192
        Me.GroupBox3.TabStop = False
        '
        'rdb_LPCno
        '
        Me.rdb_LPCno.AutoSize = True
        Me.rdb_LPCno.Location = New System.Drawing.Point(59, 10)
        Me.rdb_LPCno.Name = "rdb_LPCno"
        Me.rdb_LPCno.Size = New System.Drawing.Size(39, 17)
        Me.rdb_LPCno.TabIndex = 1
        Me.rdb_LPCno.Text = "No"
        Me.rdb_LPCno.UseVisualStyleBackColor = True
        '
        'rdb_LPCsi
        '
        Me.rdb_LPCsi.AutoSize = True
        Me.rdb_LPCsi.Location = New System.Drawing.Point(7, 9)
        Me.rdb_LPCsi.Name = "rdb_LPCsi"
        Me.rdb_LPCsi.Size = New System.Drawing.Size(34, 17)
        Me.rdb_LPCsi.TabIndex = 0
        Me.rdb_LPCsi.Text = "Si"
        Me.rdb_LPCsi.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox6)
        Me.GroupBox1.Controls.Add(Me.GroupBox5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(741, 402)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(221, 117)
        Me.GroupBox1.TabIndex = 191
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SSP"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.rdb_negativassp)
        Me.GroupBox6.Controls.Add(Me.rdb_positivassp)
        Me.GroupBox6.Location = New System.Drawing.Point(13, 74)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(165, 30)
        Me.GroupBox6.TabIndex = 194
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cartilla"
        '
        'rdb_negativassp
        '
        Me.rdb_negativassp.AutoSize = True
        Me.rdb_negativassp.Location = New System.Drawing.Point(74, 12)
        Me.rdb_negativassp.Name = "rdb_negativassp"
        Me.rdb_negativassp.Size = New System.Drawing.Size(68, 17)
        Me.rdb_negativassp.TabIndex = 12
        Me.rdb_negativassp.Text = "Negativa"
        Me.rdb_negativassp.UseVisualStyleBackColor = True
        '
        'rdb_positivassp
        '
        Me.rdb_positivassp.AutoSize = True
        Me.rdb_positivassp.Location = New System.Drawing.Point(6, 12)
        Me.rdb_positivassp.Name = "rdb_positivassp"
        Me.rdb_positivassp.Size = New System.Drawing.Size(62, 17)
        Me.rdb_positivassp.TabIndex = 11
        Me.rdb_positivassp.Text = "Positiva"
        Me.rdb_positivassp.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.rdb_optvossp)
        Me.GroupBox5.Controls.Add(Me.rdb_adtvossp)
        Me.GroupBox5.Location = New System.Drawing.Point(13, 12)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 30)
        Me.GroupBox5.TabIndex = 192
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo empleado"
        '
        'rdb_optvossp
        '
        Me.rdb_optvossp.AutoSize = True
        Me.rdb_optvossp.Location = New System.Drawing.Point(74, 12)
        Me.rdb_optvossp.Name = "rdb_optvossp"
        Me.rdb_optvossp.Size = New System.Drawing.Size(54, 17)
        Me.rdb_optvossp.TabIndex = 1
        Me.rdb_optvossp.Text = "Optvo"
        Me.rdb_optvossp.UseVisualStyleBackColor = True
        '
        'rdb_adtvossp
        '
        Me.rdb_adtvossp.AutoSize = True
        Me.rdb_adtvossp.Location = New System.Drawing.Point(6, 12)
        Me.rdb_adtvossp.Name = "rdb_adtvossp"
        Me.rdb_adtvossp.Size = New System.Drawing.Size(53, 17)
        Me.rdb_adtvossp.TabIndex = 0
        Me.rdb_adtvossp.Text = "Adtvo"
        Me.rdb_adtvossp.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_estatal)
        Me.GroupBox2.Controls.Add(Me.chk_federal)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 42)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 30)
        Me.GroupBox2.TabIndex = 193
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro"
        '
        'chk_estatal
        '
        Me.chk_estatal.AutoSize = True
        Me.chk_estatal.Location = New System.Drawing.Point(74, 10)
        Me.chk_estatal.Name = "chk_estatal"
        Me.chk_estatal.Size = New System.Drawing.Size(58, 17)
        Me.chk_estatal.TabIndex = 15
        Me.chk_estatal.Text = "Estatal"
        Me.chk_estatal.UseVisualStyleBackColor = True
        '
        'chk_federal
        '
        Me.chk_federal.AutoSize = True
        Me.chk_federal.Location = New System.Drawing.Point(6, 12)
        Me.chk_federal.Name = "chk_federal"
        Me.chk_federal.Size = New System.Drawing.Size(61, 17)
        Me.chk_federal.TabIndex = 13
        Me.chk_federal.Text = "Federal"
        Me.chk_federal.UseVisualStyleBackColor = True
        '
        'Btn_AgregarColonia
        '
        Me.Btn_AgregarColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Btn_AgregarColonia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.add
        Me.Btn_AgregarColonia.Location = New System.Drawing.Point(176, 155)
        Me.Btn_AgregarColonia.Name = "Btn_AgregarColonia"
        Me.Btn_AgregarColonia.Size = New System.Drawing.Size(26, 20)
        Me.Btn_AgregarColonia.TabIndex = 13
        Me.Btn_AgregarColonia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AgregarColonia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AgregarColonia.UseVisualStyleBackColor = True
        '
        'gbx_CatalogoFirmas
        '
        Me.gbx_CatalogoFirmas.Controls.Add(Me.rdb_No_CatFirmas)
        Me.gbx_CatalogoFirmas.Controls.Add(Me.rdb_Si_CatFirmas)
        Me.gbx_CatalogoFirmas.Location = New System.Drawing.Point(852, 342)
        Me.gbx_CatalogoFirmas.Name = "gbx_CatalogoFirmas"
        Me.gbx_CatalogoFirmas.Size = New System.Drawing.Size(110, 30)
        Me.gbx_CatalogoFirmas.TabIndex = 126
        Me.gbx_CatalogoFirmas.TabStop = False
        '
        'rdb_No_CatFirmas
        '
        Me.rdb_No_CatFirmas.AutoSize = True
        Me.rdb_No_CatFirmas.Location = New System.Drawing.Point(59, 10)
        Me.rdb_No_CatFirmas.Name = "rdb_No_CatFirmas"
        Me.rdb_No_CatFirmas.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_CatFirmas.TabIndex = 1
        Me.rdb_No_CatFirmas.Text = "No"
        Me.rdb_No_CatFirmas.UseVisualStyleBackColor = True
        '
        'rdb_Si_CatFirmas
        '
        Me.rdb_Si_CatFirmas.AutoSize = True
        Me.rdb_Si_CatFirmas.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Si_CatFirmas.Name = "rdb_Si_CatFirmas"
        Me.rdb_Si_CatFirmas.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CatFirmas.TabIndex = 0
        Me.rdb_Si_CatFirmas.Text = "Si"
        Me.rdb_Si_CatFirmas.UseVisualStyleBackColor = True
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(67, 155)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(13, 16)
        Me.Label22.TabIndex = 167
        Me.Label22.Text = "*"
        '
        'cmb_Colonias
        '
        Me.cmb_Colonias.Clave = Nothing
        Me.cmb_Colonias.Control_Siguiente = Me.cmb_Zonas
        Me.cmb_Colonias.DisplayMember = "nombre"
        Me.cmb_Colonias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Colonias.Empresa = False
        Me.cmb_Colonias.Filtro = Nothing
        Me.cmb_Colonias.FormattingEnabled = True
        Me.cmb_Colonias.Location = New System.Drawing.Point(115, 201)
        Me.cmb_Colonias.MaxDropDownItems = 20
        Me.cmb_Colonias.Name = "cmb_Colonias"
        Me.cmb_Colonias.Pista = False
        Me.cmb_Colonias.Size = New System.Drawing.Size(356, 21)
        Me.cmb_Colonias.StoredProcedure = "Cat_ColoniasCiudades_Get"
        Me.cmb_Colonias.Sucursal = False
        Me.cmb_Colonias.TabIndex = 16
        Me.cmb_Colonias.Tipo = 0
        Me.cmb_Colonias.ValueMember = "id_Colonia"
        '
        'cmb_Zonas
        '
        Me.cmb_Zonas.Clave = Nothing
        Me.cmb_Zonas.Control_Siguiente = Me.tbx_CodigoPostal
        Me.cmb_Zonas.DisplayMember = "Nombre"
        Me.cmb_Zonas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Zonas.Empresa = False
        Me.cmb_Zonas.Filtro = Nothing
        Me.cmb_Zonas.FormattingEnabled = True
        Me.cmb_Zonas.Location = New System.Drawing.Point(115, 277)
        Me.cmb_Zonas.MaxDropDownItems = 20
        Me.cmb_Zonas.Name = "cmb_Zonas"
        Me.cmb_Zonas.Pista = True
        Me.cmb_Zonas.Size = New System.Drawing.Size(149, 21)
        Me.cmb_Zonas.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_Zonas.Sucursal = False
        Me.cmb_Zonas.TabIndex = 23
        Me.cmb_Zonas.Tipo = 0
        Me.cmb_Zonas.ValueMember = "id_Zona"
        '
        'tbx_CodigoPostal
        '
        Me.tbx_CodigoPostal.Control_Siguiente = Me.tbx_Latitud
        Me.tbx_CodigoPostal.Filtrado = True
        Me.tbx_CodigoPostal.Location = New System.Drawing.Point(115, 155)
        Me.tbx_CodigoPostal.MaxLength = 6
        Me.tbx_CodigoPostal.Name = "tbx_CodigoPostal"
        Me.tbx_CodigoPostal.Size = New System.Drawing.Size(60, 20)
        Me.tbx_CodigoPostal.TabIndex = 12
        Me.tbx_CodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CodigoPostal.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Latitud
        '
        Me.tbx_Latitud.Control_Siguiente = Me.tbx_Longitud
        Me.tbx_Latitud.Filtrado = True
        Me.tbx_Latitud.Location = New System.Drawing.Point(199, 304)
        Me.tbx_Latitud.MaxLength = 11
        Me.tbx_Latitud.Name = "tbx_Latitud"
        Me.tbx_Latitud.Size = New System.Drawing.Size(70, 20)
        Me.tbx_Latitud.TabIndex = 27
        Me.tbx_Latitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Latitud.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Longitud
        '
        Me.tbx_Longitud.Control_Siguiente = Me.cmb_Genero
        Me.tbx_Longitud.Filtrado = True
        Me.tbx_Longitud.Location = New System.Drawing.Point(324, 304)
        Me.tbx_Longitud.MaxLength = 11
        Me.tbx_Longitud.Name = "tbx_Longitud"
        Me.tbx_Longitud.Size = New System.Drawing.Size(70, 20)
        Me.tbx_Longitud.TabIndex = 28
        Me.tbx_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Longitud.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_Genero
        '
        Me.cmb_Genero.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_Genero.DisplayMember = "display"
        Me.cmb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Genero.FormattingEnabled = True
        Me.cmb_Genero.Location = New System.Drawing.Point(119, 330)
        Me.cmb_Genero.MaxDropDownItems = 20
        Me.cmb_Genero.Name = "cmb_Genero"
        Me.cmb_Genero.Size = New System.Drawing.Size(114, 21)
        Me.cmb_Genero.TabIndex = 29
        Me.cmb_Genero.ValueMember = "value"
        '
        'cmb_EstadoCivil
        '
        Me.cmb_EstadoCivil.Clave = Nothing
        Me.cmb_EstadoCivil.Control_Siguiente = Me.cmb_ViveConFam
        Me.cmb_EstadoCivil.DisplayMember = "Descripcion"
        Me.cmb_EstadoCivil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EstadoCivil.Empresa = False
        Me.cmb_EstadoCivil.Filtro = Nothing
        Me.cmb_EstadoCivil.FormattingEnabled = True
        Me.cmb_EstadoCivil.Location = New System.Drawing.Point(359, 330)
        Me.cmb_EstadoCivil.MaxDropDownItems = 20
        Me.cmb_EstadoCivil.Name = "cmb_EstadoCivil"
        Me.cmb_EstadoCivil.Pista = False
        Me.cmb_EstadoCivil.Size = New System.Drawing.Size(110, 21)
        Me.cmb_EstadoCivil.StoredProcedure = "Cat_EstadoCivilCombo_Get"
        Me.cmb_EstadoCivil.Sucursal = False
        Me.cmb_EstadoCivil.TabIndex = 30
        Me.cmb_EstadoCivil.Tipo = 0
        Me.cmb_EstadoCivil.ValueMember = "Id_EstadoCivil"
        '
        'cmb_ViveConFam
        '
        Me.cmb_ViveConFam.Control_Siguiente = Me.tbx_CantidadHijos
        Me.cmb_ViveConFam.DisplayMember = "display"
        Me.cmb_ViveConFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViveConFam.FormattingEnabled = True
        Me.cmb_ViveConFam.Location = New System.Drawing.Point(119, 355)
        Me.cmb_ViveConFam.MaxDropDownItems = 20
        Me.cmb_ViveConFam.Name = "cmb_ViveConFam"
        Me.cmb_ViveConFam.Size = New System.Drawing.Size(114, 21)
        Me.cmb_ViveConFam.TabIndex = 33
        Me.cmb_ViveConFam.ValueMember = "value"
        '
        'tbx_CantidadHijos
        '
        Me.tbx_CantidadHijos.Control_Siguiente = Me.dtp_FechaNac
        Me.tbx_CantidadHijos.Filtrado = True
        Me.tbx_CantidadHijos.Location = New System.Drawing.Point(419, 355)
        Me.tbx_CantidadHijos.MaxLength = 2
        Me.tbx_CantidadHijos.Name = "tbx_CantidadHijos"
        Me.tbx_CantidadHijos.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadHijos.TabIndex = 34
        Me.tbx_CantidadHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CantidadHijos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_FechaNac
        '
        Me.dtp_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNac.Location = New System.Drawing.Point(119, 380)
        Me.dtp_FechaNac.Name = "dtp_FechaNac"
        Me.dtp_FechaNac.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaNac.TabIndex = 35
        Me.dtp_FechaNac.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtp_FechaExpiraFed
        '
        Me.dtp_FechaExpiraFed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpiraFed.Location = New System.Drawing.Point(852, 251)
        Me.dtp_FechaExpiraFed.Name = "dtp_FechaExpiraFed"
        Me.dtp_FechaExpiraFed.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaExpiraFed.TabIndex = 117
        Me.dtp_FechaExpiraFed.Value = New Date(2022, 1, 31, 11, 38, 0, 0)
        '
        'lbl_FechaExpiraFed
        '
        Me.lbl_FechaExpiraFed.AutoSize = True
        Me.lbl_FechaExpiraFed.Location = New System.Drawing.Point(731, 254)
        Me.lbl_FechaExpiraFed.Name = "lbl_FechaExpiraFed"
        Me.lbl_FechaExpiraFed.Size = New System.Drawing.Size(115, 13)
        Me.lbl_FechaExpiraFed.TabIndex = 164
        Me.lbl_FechaExpiraFed.Text = "F. Expira Licencia Fed:"
        '
        'tbx_NumeroLicenciaFed
        '
        Me.tbx_NumeroLicenciaFed.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumeroLicenciaFed.Filtrado = True
        Me.tbx_NumeroLicenciaFed.Location = New System.Drawing.Point(852, 225)
        Me.tbx_NumeroLicenciaFed.MaxLength = 50
        Me.tbx_NumeroLicenciaFed.Name = "tbx_NumeroLicenciaFed"
        Me.tbx_NumeroLicenciaFed.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroLicenciaFed.TabIndex = 115
        Me.tbx_NumeroLicenciaFed.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_UMF
        '
        Me.tbx_UMF.Control_Siguiente = Me.tbx_Pasaporte
        Me.tbx_UMF.Filtrado = True
        Me.tbx_UMF.Location = New System.Drawing.Point(852, 178)
        Me.tbx_UMF.MaxLength = 3
        Me.tbx_UMF.Name = "tbx_UMF"
        Me.tbx_UMF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_UMF.TabIndex = 109
        Me.tbx_UMF.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Pasaporte
        '
        Me.tbx_Pasaporte.Control_Siguiente = Me.cmb_TipoLicencia
        Me.tbx_Pasaporte.Filtrado = True
        Me.tbx_Pasaporte.Location = New System.Drawing.Point(602, 178)
        Me.tbx_Pasaporte.MaxLength = 10
        Me.tbx_Pasaporte.Name = "tbx_Pasaporte"
        Me.tbx_Pasaporte.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Pasaporte.TabIndex = 107
        Me.tbx_Pasaporte.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_TipoLicencia
        '
        Me.cmb_TipoLicencia.Clave = Nothing
        Me.cmb_TipoLicencia.Control_Siguiente = Me.dtp_FechaExpira
        Me.cmb_TipoLicencia.DisplayMember = "Descripcion"
        Me.cmb_TipoLicencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoLicencia.Empresa = False
        Me.cmb_TipoLicencia.Filtro = Nothing
        Me.cmb_TipoLicencia.FormattingEnabled = True
        Me.cmb_TipoLicencia.Location = New System.Drawing.Point(602, 225)
        Me.cmb_TipoLicencia.MaxDropDownItems = 20
        Me.cmb_TipoLicencia.MaxLength = 9
        Me.cmb_TipoLicencia.Name = "cmb_TipoLicencia"
        Me.cmb_TipoLicencia.Pista = False
        Me.cmb_TipoLicencia.Size = New System.Drawing.Size(110, 21)
        Me.cmb_TipoLicencia.StoredProcedure = "Cat_TipoLicenciaCombo_Get"
        Me.cmb_TipoLicencia.Sucursal = False
        Me.cmb_TipoLicencia.TabIndex = 114
        Me.cmb_TipoLicencia.Tipo = 0
        Me.cmb_TipoLicencia.ValueMember = "Id_TipoLicencia"
        '
        'dtp_FechaExpira
        '
        Me.dtp_FechaExpira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpira.Location = New System.Drawing.Point(602, 250)
        Me.dtp_FechaExpira.Name = "dtp_FechaExpira"
        Me.dtp_FechaExpira.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaExpira.TabIndex = 116
        Me.dtp_FechaExpira.Value = New Date(2022, 1, 31, 11, 38, 0, 0)
        '
        'lbl_NumeroLicenciaFed
        '
        Me.lbl_NumeroLicenciaFed.AutoSize = True
        Me.lbl_NumeroLicenciaFed.Location = New System.Drawing.Point(738, 228)
        Me.lbl_NumeroLicenciaFed.Name = "lbl_NumeroLicenciaFed"
        Me.lbl_NumeroLicenciaFed.Size = New System.Drawing.Size(108, 13)
        Me.lbl_NumeroLicenciaFed.TabIndex = 162
        Me.lbl_NumeroLicenciaFed.Text = "No. Licencia Federal:"
        '
        'tbx_IdTributario
        '
        Me.tbx_IdTributario.Control_Siguiente = Me.tbx_CURP
        Me.tbx_IdTributario.Filtrado = True
        Me.tbx_IdTributario.Location = New System.Drawing.Point(852, 201)
        Me.tbx_IdTributario.MaxLength = 15
        Me.tbx_IdTributario.Name = "tbx_IdTributario"
        Me.tbx_IdTributario.Size = New System.Drawing.Size(110, 20)
        Me.tbx_IdTributario.TabIndex = 113
        Me.tbx_IdTributario.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_CURP
        '
        Me.tbx_CURP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_CURP.Control_Siguiente = Me.tbx_IMSS
        Me.tbx_CURP.Filtrado = True
        Me.tbx_CURP.Location = New System.Drawing.Point(602, 130)
        Me.tbx_CURP.MaxLength = 20
        Me.tbx_CURP.Name = "tbx_CURP"
        Me.tbx_CURP.Size = New System.Drawing.Size(177, 20)
        Me.tbx_CURP.TabIndex = 97
        Me.tbx_CURP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_IMSS
        '
        Me.tbx_IMSS.Control_Siguiente = Me.tbx_CUIP
        Me.tbx_IMSS.Filtrado = True
        Me.tbx_IMSS.Location = New System.Drawing.Point(852, 129)
        Me.tbx_IMSS.MaxLength = 11
        Me.tbx_IMSS.Name = "tbx_IMSS"
        Me.tbx_IMSS.Size = New System.Drawing.Size(110, 20)
        Me.tbx_IMSS.TabIndex = 100
        Me.tbx_IMSS.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_CUIP
        '
        Me.tbx_CUIP.Control_Siguiente = Me.tbx_NumCartilla
        Me.tbx_CUIP.Filtrado = True
        Me.tbx_CUIP.Location = New System.Drawing.Point(602, 154)
        Me.tbx_CUIP.MaxLength = 20
        Me.tbx_CUIP.Name = "tbx_CUIP"
        Me.tbx_CUIP.Size = New System.Drawing.Size(177, 20)
        Me.tbx_CUIP.TabIndex = 103
        Me.tbx_CUIP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumCartilla
        '
        Me.tbx_NumCartilla.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumCartilla.Filtrado = True
        Me.tbx_NumCartilla.Location = New System.Drawing.Point(852, 155)
        Me.tbx_NumCartilla.MaxLength = 10
        Me.tbx_NumCartilla.Name = "tbx_NumCartilla"
        Me.tbx_NumCartilla.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumCartilla.TabIndex = 105
        Me.tbx_NumCartilla.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_RFC_Extranjero
        '
        Me.lbl_RFC_Extranjero.AutoSize = True
        Me.lbl_RFC_Extranjero.Location = New System.Drawing.Point(780, 204)
        Me.lbl_RFC_Extranjero.Name = "lbl_RFC_Extranjero"
        Me.lbl_RFC_Extranjero.Size = New System.Drawing.Size(66, 13)
        Me.lbl_RFC_Extranjero.TabIndex = 160
        Me.lbl_RFC_Extranjero.Text = "Id Tributario:"
        '
        'tbx_NumeroLicencia
        '
        Me.tbx_NumeroLicencia.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumeroLicencia.Filtrado = True
        Me.tbx_NumeroLicencia.Location = New System.Drawing.Point(601, 202)
        Me.tbx_NumeroLicencia.MaxLength = 50
        Me.tbx_NumeroLicencia.Name = "tbx_NumeroLicencia"
        Me.tbx_NumeroLicencia.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroLicencia.TabIndex = 112
        Me.tbx_NumeroLicencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_NumeroLicencia
        '
        Me.lbl_NumeroLicencia.AutoSize = True
        Me.lbl_NumeroLicencia.Location = New System.Drawing.Point(530, 204)
        Me.lbl_NumeroLicencia.Name = "lbl_NumeroLicencia"
        Me.lbl_NumeroLicencia.Size = New System.Drawing.Size(70, 13)
        Me.lbl_NumeroLicencia.TabIndex = 158
        Me.lbl_NumeroLicencia.Text = "No. Licencia:"
        '
        'btn_ImprimirSolicitud
        '
        Me.btn_ImprimirSolicitud.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_ImprimirSolicitud.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ImprimirSolicitud.Location = New System.Drawing.Point(462, 651)
        Me.btn_ImprimirSolicitud.Name = "btn_ImprimirSolicitud"
        Me.btn_ImprimirSolicitud.Size = New System.Drawing.Size(140, 30)
        Me.btn_ImprimirSolicitud.TabIndex = 190
        Me.btn_ImprimirSolicitud.TabStop = False
        Me.btn_ImprimirSolicitud.Text = "&Imprimir"
        Me.btn_ImprimirSolicitud.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ImprimirSolicitud.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ImprimirSolicitud.UseVisualStyleBackColor = True
        '
        'btn_MapaEmpleado
        '
        Me.btn_MapaEmpleado.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.MapaMundo
        Me.btn_MapaEmpleado.Location = New System.Drawing.Point(475, 271)
        Me.btn_MapaEmpleado.Name = "btn_MapaEmpleado"
        Me.btn_MapaEmpleado.Size = New System.Drawing.Size(31, 29)
        Me.btn_MapaEmpleado.TabIndex = 25
        Me.btn_MapaEmpleado.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MapaEmpleado.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_MapaEmpleado, "Comprobar si la persona se encuentra en Lista Negra")
        Me.btn_MapaEmpleado.UseVisualStyleBackColor = True
        '
        'tbx_MontoDescuento
        '
        Me.tbx_MontoDescuento.Control_Siguiente = Nothing
        Me.tbx_MontoDescuento.Enabled = False
        Me.tbx_MontoDescuento.Filtrado = True
        Me.tbx_MontoDescuento.Location = New System.Drawing.Point(852, 322)
        Me.tbx_MontoDescuento.MaxLength = 20
        Me.tbx_MontoDescuento.Name = "tbx_MontoDescuento"
        Me.tbx_MontoDescuento.Size = New System.Drawing.Size(110, 20)
        Me.tbx_MontoDescuento.TabIndex = 125
        Me.tbx_MontoDescuento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_MontoDescuento
        '
        Me.lbl_MontoDescuento.AutoSize = True
        Me.lbl_MontoDescuento.Enabled = False
        Me.lbl_MontoDescuento.Location = New System.Drawing.Point(739, 328)
        Me.lbl_MontoDescuento.Name = "lbl_MontoDescuento"
        Me.lbl_MontoDescuento.Size = New System.Drawing.Size(107, 13)
        Me.lbl_MontoDescuento.TabIndex = 132
        Me.lbl_MontoDescuento.Text = "Monto de Descuento"
        '
        'cmb_TipoDescuento
        '
        Me.cmb_TipoDescuento.Control_Siguiente = Me.tbx_MontoDescuento
        Me.cmb_TipoDescuento.DisplayMember = "display"
        Me.cmb_TipoDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDescuento.Enabled = False
        Me.cmb_TipoDescuento.FormattingEnabled = True
        Me.cmb_TipoDescuento.Location = New System.Drawing.Point(601, 376)
        Me.cmb_TipoDescuento.MaxDropDownItems = 20
        Me.cmb_TipoDescuento.Name = "cmb_TipoDescuento"
        Me.cmb_TipoDescuento.Size = New System.Drawing.Size(111, 21)
        Me.cmb_TipoDescuento.TabIndex = 124
        Me.cmb_TipoDescuento.ValueMember = "value"
        '
        'lbl_TipoDescuento
        '
        Me.lbl_TipoDescuento.AutoSize = True
        Me.lbl_TipoDescuento.Enabled = False
        Me.lbl_TipoDescuento.Location = New System.Drawing.Point(512, 380)
        Me.lbl_TipoDescuento.Name = "lbl_TipoDescuento"
        Me.lbl_TipoDescuento.Size = New System.Drawing.Size(83, 13)
        Me.lbl_TipoDescuento.TabIndex = 130
        Me.lbl_TipoDescuento.Text = "Tipo Descuento"
        '
        'tbx_NumeroCredito
        '
        Me.tbx_NumeroCredito.Control_Siguiente = Me.cmb_TipoDescuento
        Me.tbx_NumeroCredito.Enabled = False
        Me.tbx_NumeroCredito.Filtrado = True
        Me.tbx_NumeroCredito.Location = New System.Drawing.Point(852, 298)
        Me.tbx_NumeroCredito.MaxLength = 20
        Me.tbx_NumeroCredito.Name = "tbx_NumeroCredito"
        Me.tbx_NumeroCredito.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroCredito.TabIndex = 123
        Me.tbx_NumeroCredito.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_NumeroCredito
        '
        Me.lbl_NumeroCredito.AutoSize = True
        Me.lbl_NumeroCredito.Enabled = False
        Me.lbl_NumeroCredito.Location = New System.Drawing.Point(751, 301)
        Me.lbl_NumeroCredito.Name = "lbl_NumeroCredito"
        Me.lbl_NumeroCredito.Size = New System.Drawing.Size(95, 13)
        Me.lbl_NumeroCredito.TabIndex = 128
        Me.lbl_NumeroCredito.Text = "Número de Crédito"
        '
        'lbl_FechaActualizacionDG
        '
        Me.lbl_FechaActualizacionDG.AutoSize = True
        Me.lbl_FechaActualizacionDG.Location = New System.Drawing.Point(746, 278)
        Me.lbl_FechaActualizacionDG.Name = "lbl_FechaActualizacionDG"
        Me.lbl_FechaActualizacionDG.Size = New System.Drawing.Size(100, 13)
        Me.lbl_FechaActualizacionDG.TabIndex = 119
        Me.lbl_FechaActualizacionDG.Text = "F. de Actualizacion:"
        '
        'lbl_FechaActualDGview
        '
        Me.lbl_FechaActualDGview.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FechaActualDGview.ForeColor = System.Drawing.Color.Blue
        Me.lbl_FechaActualDGview.Location = New System.Drawing.Point(852, 276)
        Me.lbl_FechaActualDGview.Name = "lbl_FechaActualDGview"
        Me.lbl_FechaActualDGview.Size = New System.Drawing.Size(111, 15)
        Me.lbl_FechaActualDGview.TabIndex = 150
        Me.lbl_FechaActualDGview.Text = "--"
        Me.lbl_FechaActualDGview.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_PortaArma
        '
        Me.lbl_PortaArma.AutoSize = True
        Me.lbl_PortaArma.Location = New System.Drawing.Point(529, 498)
        Me.lbl_PortaArma.Name = "lbl_PortaArma"
        Me.lbl_PortaArma.Size = New System.Drawing.Size(71, 13)
        Me.lbl_PortaArma.TabIndex = 150
        Me.lbl_PortaArma.Text = "¿Porta Arma?"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(717, 495)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 152
        Me.Label6.Text = "*"
        '
        'gbx_Porte
        '
        Me.gbx_Porte.Controls.Add(Me.rdb_PorteArmaNo)
        Me.gbx_Porte.Controls.Add(Me.rdb_PorteArmaSI)
        Me.gbx_Porte.Location = New System.Drawing.Point(601, 488)
        Me.gbx_Porte.Name = "gbx_Porte"
        Me.gbx_Porte.Size = New System.Drawing.Size(110, 30)
        Me.gbx_Porte.TabIndex = 132
        Me.gbx_Porte.TabStop = False
        '
        'rdb_PorteArmaNo
        '
        Me.rdb_PorteArmaNo.AutoSize = True
        Me.rdb_PorteArmaNo.Location = New System.Drawing.Point(59, 10)
        Me.rdb_PorteArmaNo.Name = "rdb_PorteArmaNo"
        Me.rdb_PorteArmaNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_PorteArmaNo.TabIndex = 1
        Me.rdb_PorteArmaNo.Text = "No"
        Me.rdb_PorteArmaNo.UseVisualStyleBackColor = True
        '
        'rdb_PorteArmaSI
        '
        Me.rdb_PorteArmaSI.AutoSize = True
        Me.rdb_PorteArmaSI.Location = New System.Drawing.Point(7, 9)
        Me.rdb_PorteArmaSI.Name = "rdb_PorteArmaSI"
        Me.rdb_PorteArmaSI.Size = New System.Drawing.Size(34, 17)
        Me.rdb_PorteArmaSI.TabIndex = 0
        Me.rdb_PorteArmaSI.Text = "Si"
        Me.rdb_PorteArmaSI.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(472, 134)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 19
        Me.Label5.Text = "*"
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(602, 274)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaIngreso.TabIndex = 118
        '
        'dtp_FechaVenceCredencial
        '
        Me.dtp_FechaVenceCredencial.Enabled = False
        Me.dtp_FechaVenceCredencial.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaVenceCredencial.Location = New System.Drawing.Point(602, 322)
        Me.dtp_FechaVenceCredencial.Name = "dtp_FechaVenceCredencial"
        Me.dtp_FechaVenceCredencial.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaVenceCredencial.TabIndex = 120
        '
        'Lbl_EmailDG
        '
        Me.Lbl_EmailDG.AutoSize = True
        Me.Lbl_EmailDG.Location = New System.Drawing.Point(520, 33)
        Me.Lbl_EmailDG.Name = "Lbl_EmailDG"
        Me.Lbl_EmailDG.Size = New System.Drawing.Size(76, 13)
        Me.Lbl_EmailDG.TabIndex = 82
        Me.Lbl_EmailDG.Text = "Email Personal"
        '
        'tbx_MailPersonal
        '
        Me.tbx_MailPersonal.Control_Siguiente = Me.tbx_Telefono1
        Me.tbx_MailPersonal.Filtrado = True
        Me.tbx_MailPersonal.Location = New System.Drawing.Point(602, 30)
        Me.tbx_MailPersonal.MaxLength = 50
        Me.tbx_MailPersonal.Name = "tbx_MailPersonal"
        Me.tbx_MailPersonal.Size = New System.Drawing.Size(360, 20)
        Me.tbx_MailPersonal.TabIndex = 83
        Me.tbx_MailPersonal.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Telefono1
        '
        Me.tbx_Telefono1.Control_Siguiente = Me.tbx_TelefonoMovil1
        Me.tbx_Telefono1.Filtrado = True
        Me.tbx_Telefono1.Location = New System.Drawing.Point(602, 82)
        Me.tbx_Telefono1.MaxLength = 25
        Me.tbx_Telefono1.Name = "tbx_Telefono1"
        Me.tbx_Telefono1.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Telefono1.TabIndex = 87
        Me.tbx_Telefono1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_TelefonoMovil1
        '
        Me.tbx_TelefonoMovil1.Control_Siguiente = Me.tbx_Elector
        Me.tbx_TelefonoMovil1.Filtrado = True
        Me.tbx_TelefonoMovil1.Location = New System.Drawing.Point(852, 81)
        Me.tbx_TelefonoMovil1.MaxLength = 25
        Me.tbx_TelefonoMovil1.Name = "tbx_TelefonoMovil1"
        Me.tbx_TelefonoMovil1.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TelefonoMovil1.TabIndex = 89
        Me.tbx_TelefonoMovil1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Elector
        '
        Me.tbx_Elector.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Elector.Control_Siguiente = Me.tbx_RFC
        Me.tbx_Elector.Filtrado = True
        Me.tbx_Elector.Location = New System.Drawing.Point(602, 106)
        Me.tbx_Elector.MaxLength = 25
        Me.tbx_Elector.Name = "tbx_Elector"
        Me.tbx_Elector.Size = New System.Drawing.Size(177, 20)
        Me.tbx_Elector.TabIndex = 91
        Me.tbx_Elector.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_RFC
        '
        Me.tbx_RFC.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_RFC.Control_Siguiente = Me.tbx_CURP
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(852, 105)
        Me.tbx_RFC.MaxLength = 15
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(110, 20)
        Me.tbx_RFC.TabIndex = 93
        Me.tbx_RFC.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_CUIP
        '
        Me.lbl_CUIP.AutoSize = True
        Me.lbl_CUIP.Location = New System.Drawing.Point(564, 157)
        Me.lbl_CUIP.Name = "lbl_CUIP"
        Me.lbl_CUIP.Size = New System.Drawing.Size(32, 13)
        Me.lbl_CUIP.TabIndex = 102
        Me.lbl_CUIP.Text = "CUIP"
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
        Me.cmb_Puesto.Location = New System.Drawing.Point(115, 132)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(214, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 10
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'btn_ComprobarListaNegra
        '
        Me.btn_ComprobarListaNegra.Enabled = False
        Me.btn_ComprobarListaNegra.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ok
        Me.btn_ComprobarListaNegra.Location = New System.Drawing.Point(350, 5)
        Me.btn_ComprobarListaNegra.Name = "btn_ComprobarListaNegra"
        Me.btn_ComprobarListaNegra.Size = New System.Drawing.Size(24, 23)
        Me.btn_ComprobarListaNegra.TabIndex = 3
        Me.btn_ComprobarListaNegra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ComprobarListaNegra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_ComprobarListaNegra, "Comprobar si la persona se encuentra en Lista Negra")
        Me.btn_ComprobarListaNegra.UseVisualStyleBackColor = True
        '
        'tbx_EmpleadoP
        '
        Me.tbx_EmpleadoP.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_EmpleadoP.Filtrado = True
        Me.tbx_EmpleadoP.Location = New System.Drawing.Point(7, 8)
        Me.tbx_EmpleadoP.MaxLength = 12
        Me.tbx_EmpleadoP.Name = "tbx_EmpleadoP"
        Me.tbx_EmpleadoP.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EmpleadoP.TabIndex = 0
        Me.tbx_EmpleadoP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_EmpleadoP.Visible = False
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.Control_Siguiente = Me.tbx_ApellidoPaterno
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Location = New System.Drawing.Point(115, 57)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.Size = New System.Drawing.Size(214, 20)
        Me.tbx_Nombres.TabIndex = 6
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_ApellidoPaterno
        '
        Me.tbx_ApellidoPaterno.Control_Siguiente = Me.tbx_ApellidoMaterno
        Me.tbx_ApellidoPaterno.Filtrado = True
        Me.tbx_ApellidoPaterno.Location = New System.Drawing.Point(115, 81)
        Me.tbx_ApellidoPaterno.MaxLength = 30
        Me.tbx_ApellidoPaterno.Name = "tbx_ApellidoPaterno"
        Me.tbx_ApellidoPaterno.Size = New System.Drawing.Size(141, 20)
        Me.tbx_ApellidoPaterno.TabIndex = 7
        Me.tbx_ApellidoPaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_ApellidoMaterno
        '
        Me.tbx_ApellidoMaterno.Control_Siguiente = Me.cmb_Departamento_DG
        Me.tbx_ApellidoMaterno.Filtrado = True
        Me.tbx_ApellidoMaterno.Location = New System.Drawing.Point(333, 82)
        Me.tbx_ApellidoMaterno.MaxLength = 30
        Me.tbx_ApellidoMaterno.Name = "tbx_ApellidoMaterno"
        Me.tbx_ApellidoMaterno.Size = New System.Drawing.Size(136, 20)
        Me.tbx_ApellidoMaterno.TabIndex = 8
        Me.tbx_ApellidoMaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'cmb_Departamento_DG
        '
        Me.cmb_Departamento_DG.Clave = Nothing
        Me.cmb_Departamento_DG.Control_Siguiente = Nothing
        Me.cmb_Departamento_DG.DisplayMember = "Descripcion"
        Me.cmb_Departamento_DG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento_DG.Empresa = False
        Me.cmb_Departamento_DG.Filtro = Nothing
        Me.cmb_Departamento_DG.FormattingEnabled = True
        Me.cmb_Departamento_DG.Location = New System.Drawing.Point(115, 107)
        Me.cmb_Departamento_DG.MaxDropDownItems = 20
        Me.cmb_Departamento_DG.Name = "cmb_Departamento_DG"
        Me.cmb_Departamento_DG.Pista = False
        Me.cmb_Departamento_DG.Size = New System.Drawing.Size(214, 21)
        Me.cmb_Departamento_DG.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento_DG.Sucursal = False
        Me.cmb_Departamento_DG.TabIndex = 9
        Me.cmb_Departamento_DG.Tipo = 0
        Me.cmb_Departamento_DG.ValueMember = "Id_Departamento"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.ForeColor = System.Drawing.Color.Red
        Me.Label158.Location = New System.Drawing.Point(472, 380)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(13, 16)
        Me.Label158.TabIndex = 63
        Me.Label158.Text = "*"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Red
        Me.Label139.Location = New System.Drawing.Point(235, 379)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(13, 16)
        Me.Label139.TabIndex = 60
        Me.Label139.Text = "*"
        '
        'cmb_ModoContactoD
        '
        Me.cmb_ModoContactoD.Clave = ""
        Me.cmb_ModoContactoD.Control_Siguiente = Me.cmb_EmpleadoReferencia
        Me.cmb_ModoContactoD.DisplayMember = "Descripcion"
        Me.cmb_ModoContactoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ModoContactoD.Empresa = False
        Me.cmb_ModoContactoD.Filtro = Nothing
        Me.cmb_ModoContactoD.FormattingEnabled = True
        Me.cmb_ModoContactoD.Location = New System.Drawing.Point(119, 502)
        Me.cmb_ModoContactoD.MaxDropDownItems = 20
        Me.cmb_ModoContactoD.Name = "cmb_ModoContactoD"
        Me.cmb_ModoContactoD.Pista = False
        Me.cmb_ModoContactoD.Size = New System.Drawing.Size(294, 21)
        Me.cmb_ModoContactoD.StoredProcedure = "Cat_ModoContactoD_Get"
        Me.cmb_ModoContactoD.Sucursal = False
        Me.cmb_ModoContactoD.TabIndex = 43
        Me.cmb_ModoContactoD.Tipo = 0
        Me.cmb_ModoContactoD.ValueMember = "Id_ModoContactoD"
        '
        'cmb_EmpleadoReferencia
        '
        Me.cmb_EmpleadoReferencia.Clave = Nothing
        Me.cmb_EmpleadoReferencia.Control_Siguiente = Me.tbx_Mail
        Me.cmb_EmpleadoReferencia.DisplayMember = "Nombre"
        Me.cmb_EmpleadoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmpleadoReferencia.Empresa = False
        Me.cmb_EmpleadoReferencia.Filtro = Nothing
        Me.cmb_EmpleadoReferencia.FormattingEnabled = True
        Me.cmb_EmpleadoReferencia.Location = New System.Drawing.Point(119, 526)
        Me.cmb_EmpleadoReferencia.MaxDropDownItems = 20
        Me.cmb_EmpleadoReferencia.MaxLength = 9
        Me.cmb_EmpleadoReferencia.Name = "cmb_EmpleadoReferencia"
        Me.cmb_EmpleadoReferencia.Pista = True
        Me.cmb_EmpleadoReferencia.Size = New System.Drawing.Size(350, 21)
        Me.cmb_EmpleadoReferencia.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_EmpleadoReferencia.Sucursal = True
        Me.cmb_EmpleadoReferencia.TabIndex = 44
        Me.cmb_EmpleadoReferencia.Tipo = 0
        Me.cmb_EmpleadoReferencia.ValueMember = "Id_Empleado"
        '
        'tbx_Mail
        '
        Me.tbx_Mail.Control_Siguiente = Me.tbx_Telefono1
        Me.tbx_Mail.Filtrado = True
        Me.tbx_Mail.Location = New System.Drawing.Point(602, 58)
        Me.tbx_Mail.MaxLength = 50
        Me.tbx_Mail.Name = "tbx_Mail"
        Me.tbx_Mail.Size = New System.Drawing.Size(360, 20)
        Me.tbx_Mail.TabIndex = 85
        Me.tbx_Mail.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label163.ForeColor = System.Drawing.Color.Red
        Me.Label163.Location = New System.Drawing.Point(419, 503)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(13, 16)
        Me.Label163.TabIndex = 79
        Me.Label163.Text = "*"
        '
        'cmb_ModoContacto
        '
        Me.cmb_ModoContacto.Clave = Nothing
        Me.cmb_ModoContacto.Control_Siguiente = Me.cmb_ModoContactoD
        Me.cmb_ModoContacto.DisplayMember = "Descripcion"
        Me.cmb_ModoContacto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ModoContacto.Empresa = False
        Me.cmb_ModoContacto.Filtro = Nothing
        Me.cmb_ModoContacto.FormattingEnabled = True
        Me.cmb_ModoContacto.Location = New System.Drawing.Point(119, 478)
        Me.cmb_ModoContacto.MaxDropDownItems = 20
        Me.cmb_ModoContacto.Name = "cmb_ModoContacto"
        Me.cmb_ModoContacto.Pista = False
        Me.cmb_ModoContacto.Size = New System.Drawing.Size(294, 21)
        Me.cmb_ModoContacto.StoredProcedure = "Cat_ModoContacto_Get"
        Me.cmb_ModoContacto.Sucursal = False
        Me.cmb_ModoContacto.TabIndex = 42
        Me.cmb_ModoContacto.Tipo = 0
        Me.cmb_ModoContacto.ValueMember = "Id_ModoContacto"
        '
        'Lbl_EspecifiqueDG
        '
        Me.Lbl_EspecifiqueDG.AutoSize = True
        Me.Lbl_EspecifiqueDG.Location = New System.Drawing.Point(51, 505)
        Me.Lbl_EspecifiqueDG.Name = "Lbl_EspecifiqueDG"
        Me.Lbl_EspecifiqueDG.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_EspecifiqueDG.TabIndex = 77
        Me.Lbl_EspecifiqueDG.Text = "Especifique"
        '
        'Lbl_ModoContatoDg
        '
        Me.Lbl_ModoContatoDg.AutoSize = True
        Me.Lbl_ModoContatoDg.Location = New System.Drawing.Point(18, 481)
        Me.Lbl_ModoContatoDg.Name = "Lbl_ModoContatoDg"
        Me.Lbl_ModoContatoDg.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_ModoContatoDg.TabIndex = 75
        Me.Lbl_ModoContatoDg.Text = "Modo de Contacto"
        '
        'Lbl_ViveCFamiliaDG
        '
        Me.Lbl_ViveCFamiliaDG.AutoSize = True
        Me.Lbl_ViveCFamiliaDG.Location = New System.Drawing.Point(15, 358)
        Me.Lbl_ViveCFamiliaDG.Name = "Lbl_ViveCFamiliaDG"
        Me.Lbl_ViveCFamiliaDG.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_ViveCFamiliaDG.TabIndex = 53
        Me.Lbl_ViveCFamiliaDG.Text = "Vive con su Familia"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.ForeColor = System.Drawing.Color.Red
        Me.Label129.Location = New System.Drawing.Point(239, 356)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(13, 16)
        Me.Label129.TabIndex = 55
        Me.Label129.Text = "*"
        '
        'Lbl_GeneroDG
        '
        Me.Lbl_GeneroDG.AutoSize = True
        Me.Lbl_GeneroDG.Location = New System.Drawing.Point(71, 333)
        Me.Lbl_GeneroDG.Name = "Lbl_GeneroDG"
        Me.Lbl_GeneroDG.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_GeneroDG.TabIndex = 48
        Me.Lbl_GeneroDG.Text = "Género"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(239, 331)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(13, 16)
        Me.Label51.TabIndex = 50
        Me.Label51.Text = "*"
        '
        'cmb_Ciudad
        '
        Me.cmb_Ciudad.Clave = Nothing
        Me.cmb_Ciudad.Control_Siguiente = Me.cmb_ModoNacionalidad
        Me.cmb_Ciudad.DisplayMember = "Nombre"
        Me.cmb_Ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudad.Empresa = False
        Me.cmb_Ciudad.Filtro = Nothing
        Me.cmb_Ciudad.FormattingEnabled = True
        Me.cmb_Ciudad.Location = New System.Drawing.Point(320, 429)
        Me.cmb_Ciudad.MaxDropDownItems = 20
        Me.cmb_Ciudad.Name = "cmb_Ciudad"
        Me.cmb_Ciudad.Pista = True
        Me.cmb_Ciudad.Size = New System.Drawing.Size(149, 21)
        Me.cmb_Ciudad.StoredProcedure = "Cat_CiudadesEstado_Get"
        Me.cmb_Ciudad.Sucursal = False
        Me.cmb_Ciudad.TabIndex = 39
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'cmb_ModoNacionalidad
        '
        Me.cmb_ModoNacionalidad.Control_Siguiente = Me.dtp_FechaNaturalizacion
        Me.cmb_ModoNacionalidad.DisplayMember = "display"
        Me.cmb_ModoNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ModoNacionalidad.FormattingEnabled = True
        Me.cmb_ModoNacionalidad.Location = New System.Drawing.Point(119, 454)
        Me.cmb_ModoNacionalidad.MaxDropDownItems = 20
        Me.cmb_ModoNacionalidad.Name = "cmb_ModoNacionalidad"
        Me.cmb_ModoNacionalidad.Size = New System.Drawing.Size(145, 21)
        Me.cmb_ModoNacionalidad.TabIndex = 40
        Me.cmb_ModoNacionalidad.ValueMember = "value"
        '
        'dtp_FechaNaturalizacion
        '
        Me.dtp_FechaNaturalizacion.Enabled = False
        Me.dtp_FechaNaturalizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNaturalizacion.Location = New System.Drawing.Point(369, 454)
        Me.dtp_FechaNaturalizacion.Name = "dtp_FechaNaturalizacion"
        Me.dtp_FechaNaturalizacion.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaNaturalizacion.TabIndex = 41
        Me.dtp_FechaNaturalizacion.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
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
        Me.cmb_Estado.Location = New System.Drawing.Point(119, 429)
        Me.cmb_Estado.MaxDropDownItems = 20
        Me.cmb_Estado.Name = "cmb_Estado"
        Me.cmb_Estado.Pista = True
        Me.cmb_Estado.Size = New System.Drawing.Size(149, 21)
        Me.cmb_Estado.StoredProcedure = "Cat_EstadosPais_Get"
        Me.cmb_Estado.Sucursal = False
        Me.cmb_Estado.TabIndex = 38
        Me.cmb_Estado.Tipo = 0
        Me.cmb_Estado.ValueMember = "Id_Estado"
        '
        'cmb_Pais
        '
        Me.cmb_Pais.Clave = Nothing
        Me.cmb_Pais.Control_Siguiente = Me.cmb_Estado
        Me.cmb_Pais.DisplayMember = "Nombre"
        Me.cmb_Pais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Pais.Empresa = False
        Me.cmb_Pais.Filtro = Nothing
        Me.cmb_Pais.FormattingEnabled = True
        Me.cmb_Pais.Location = New System.Drawing.Point(119, 404)
        Me.cmb_Pais.MaxDropDownItems = 20
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.Pista = True
        Me.cmb_Pais.Size = New System.Drawing.Size(208, 21)
        Me.cmb_Pais.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Pais.Sucursal = False
        Me.cmb_Pais.TabIndex = 37
        Me.cmb_Pais.Tipo = 0
        Me.cmb_Pais.ValueMember = "Id_Pais"
        '
        'btn_RFC
        '
        Me.btn_RFC.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Crear_rfc_curp
        Me.btn_RFC.Location = New System.Drawing.Point(970, 104)
        Me.btn_RFC.Name = "btn_RFC"
        Me.btn_RFC.Size = New System.Drawing.Size(24, 23)
        Me.btn_RFC.TabIndex = 95
        Me.btn_RFC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RFC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_RFC, "Calcular el RFC")
        Me.btn_RFC.UseVisualStyleBackColor = True
        '
        'btn_CURP
        '
        Me.btn_CURP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Crear_rfc_curp
        Me.btn_CURP.Location = New System.Drawing.Point(785, 128)
        Me.btn_CURP.Name = "btn_CURP"
        Me.btn_CURP.Size = New System.Drawing.Size(24, 23)
        Me.btn_CURP.TabIndex = 98
        Me.btn_CURP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CURP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_CURP, "Calcular el CURP")
        Me.btn_CURP.UseVisualStyleBackColor = True
        '
        'lbl_CiudadNac
        '
        Me.lbl_CiudadNac.AutoSize = True
        Me.lbl_CiudadNac.Location = New System.Drawing.Point(274, 432)
        Me.lbl_CiudadNac.Name = "lbl_CiudadNac"
        Me.lbl_CiudadNac.Size = New System.Drawing.Size(40, 13)
        Me.lbl_CiudadNac.TabIndex = 68
        Me.lbl_CiudadNac.Text = "Ciudad"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.ForeColor = System.Drawing.Color.Red
        Me.Label156.Location = New System.Drawing.Point(718, 463)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(13, 16)
        Me.Label156.TabIndex = 148
        Me.Label156.Text = "*"
        '
        'Lbl_VerificaraDepoDG
        '
        Me.Lbl_VerificaraDepoDG.AutoSize = True
        Me.Lbl_VerificaraDepoDG.Location = New System.Drawing.Point(489, 470)
        Me.Lbl_VerificaraDepoDG.Name = "Lbl_VerificaraDepoDG"
        Me.Lbl_VerificaraDepoDG.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_VerificaraDepoDG.TabIndex = 146
        Me.Lbl_VerificaraDepoDG.Text = "¿Verificará Depósitos?"
        '
        'gbx_Verifica
        '
        Me.gbx_Verifica.Controls.Add(Me.rdb_No_Verifica)
        Me.gbx_Verifica.Controls.Add(Me.rdb_Si_Verifica)
        Me.gbx_Verifica.Location = New System.Drawing.Point(602, 458)
        Me.gbx_Verifica.Name = "gbx_Verifica"
        Me.gbx_Verifica.Size = New System.Drawing.Size(110, 30)
        Me.gbx_Verifica.TabIndex = 130
        Me.gbx_Verifica.TabStop = False
        Me.gbx_Verifica.Text = "(Pro, Morr o Caj)"
        '
        'rdb_No_Verifica
        '
        Me.rdb_No_Verifica.AutoSize = True
        Me.rdb_No_Verifica.Location = New System.Drawing.Point(59, 10)
        Me.rdb_No_Verifica.Name = "rdb_No_Verifica"
        Me.rdb_No_Verifica.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_Verifica.TabIndex = 1
        Me.rdb_No_Verifica.Text = "No"
        Me.rdb_No_Verifica.UseVisualStyleBackColor = True
        '
        'rdb_Si_Verifica
        '
        Me.rdb_Si_Verifica.AutoSize = True
        Me.rdb_Si_Verifica.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Si_Verifica.Name = "rdb_Si_Verifica"
        Me.rdb_Si_Verifica.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_Verifica.TabIndex = 0
        Me.rdb_Si_Verifica.Text = "Si"
        Me.rdb_Si_Verifica.UseVisualStyleBackColor = True
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.ForeColor = System.Drawing.Color.Red
        Me.Label155.Location = New System.Drawing.Point(718, 274)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(13, 16)
        Me.Label155.TabIndex = 118
        Me.Label155.Text = "*"
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label154.ForeColor = System.Drawing.Color.Red
        Me.Label154.Location = New System.Drawing.Point(718, 349)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(13, 16)
        Me.Label154.TabIndex = 127
        Me.Label154.Text = "*"
        '
        'btn_UMF
        '
        Me.btn_UMF.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_UMF.Location = New System.Drawing.Point(927, 177)
        Me.btn_UMF.Name = "btn_UMF"
        Me.btn_UMF.Size = New System.Drawing.Size(35, 20)
        Me.btn_UMF.TabIndex = 111
        Me.btn_UMF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_UMF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_UMF.UseVisualStyleBackColor = True
        '
        'lbl_Infonavit
        '
        Me.lbl_Infonavit.AutoSize = True
        Me.lbl_Infonavit.Location = New System.Drawing.Point(496, 352)
        Me.lbl_Infonavit.Name = "lbl_Infonavit"
        Me.lbl_Infonavit.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Infonavit.TabIndex = 125
        Me.lbl_Infonavit.Text = "Crédito INFONAVIT"
        '
        'gbx_CreditoInfonavit
        '
        Me.gbx_CreditoInfonavit.Controls.Add(Me.rdb_No_CreditoInfonavit)
        Me.gbx_CreditoInfonavit.Controls.Add(Me.rdb_Si_CreditoInfonavit)
        Me.gbx_CreditoInfonavit.Location = New System.Drawing.Point(602, 342)
        Me.gbx_CreditoInfonavit.Name = "gbx_CreditoInfonavit"
        Me.gbx_CreditoInfonavit.Size = New System.Drawing.Size(110, 30)
        Me.gbx_CreditoInfonavit.TabIndex = 122
        Me.gbx_CreditoInfonavit.TabStop = False
        '
        'rdb_No_CreditoInfonavit
        '
        Me.rdb_No_CreditoInfonavit.AutoSize = True
        Me.rdb_No_CreditoInfonavit.Location = New System.Drawing.Point(59, 10)
        Me.rdb_No_CreditoInfonavit.Name = "rdb_No_CreditoInfonavit"
        Me.rdb_No_CreditoInfonavit.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_CreditoInfonavit.TabIndex = 1
        Me.rdb_No_CreditoInfonavit.Text = "No"
        Me.rdb_No_CreditoInfonavit.UseVisualStyleBackColor = True
        '
        'rdb_Si_CreditoInfonavit
        '
        Me.rdb_Si_CreditoInfonavit.AutoSize = True
        Me.rdb_Si_CreditoInfonavit.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Si_CreditoInfonavit.Name = "rdb_Si_CreditoInfonavit"
        Me.rdb_Si_CreditoInfonavit.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CreditoInfonavit.TabIndex = 121
        Me.rdb_Si_CreditoInfonavit.Text = "Si"
        Me.rdb_Si_CreditoInfonavit.UseVisualStyleBackColor = True
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label151.ForeColor = System.Drawing.Color.Red
        Me.Label151.Location = New System.Drawing.Point(718, 433)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(13, 16)
        Me.Label151.TabIndex = 142
        Me.Label151.Text = "*"
        '
        'Lbl_SaldraDG
        '
        Me.Lbl_SaldraDG.AutoSize = True
        Me.Lbl_SaldraDG.Location = New System.Drawing.Point(518, 440)
        Me.Lbl_SaldraDG.Name = "Lbl_SaldraDG"
        Me.Lbl_SaldraDG.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_SaldraDG.TabIndex = 140
        Me.Lbl_SaldraDG.Text = "¿Saldrá a Ruta?"
        '
        'gbx_Ruta
        '
        Me.gbx_Ruta.Controls.Add(Me.rdb_No_Ruta)
        Me.gbx_Ruta.Controls.Add(Me.rdb_Si_Ruta)
        Me.gbx_Ruta.Location = New System.Drawing.Point(602, 428)
        Me.gbx_Ruta.Name = "gbx_Ruta"
        Me.gbx_Ruta.Size = New System.Drawing.Size(110, 30)
        Me.gbx_Ruta.TabIndex = 128
        Me.gbx_Ruta.TabStop = False
        '
        'rdb_No_Ruta
        '
        Me.rdb_No_Ruta.AutoSize = True
        Me.rdb_No_Ruta.Location = New System.Drawing.Point(59, 10)
        Me.rdb_No_Ruta.Name = "rdb_No_Ruta"
        Me.rdb_No_Ruta.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_Ruta.TabIndex = 1
        Me.rdb_No_Ruta.Text = "No"
        Me.rdb_No_Ruta.UseVisualStyleBackColor = True
        '
        'rdb_Si_Ruta
        '
        Me.rdb_Si_Ruta.AutoSize = True
        Me.rdb_Si_Ruta.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Si_Ruta.Name = "rdb_Si_Ruta"
        Me.rdb_Si_Ruta.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_Ruta.TabIndex = 0
        Me.rdb_Si_Ruta.Text = "Si"
        Me.rdb_Si_Ruta.UseVisualStyleBackColor = True
        '
        'btn_Codigo
        '
        Me.btn_Codigo.Enabled = False
        Me.btn_Codigo.Location = New System.Drawing.Point(375, 5)
        Me.btn_Codigo.Name = "btn_Codigo"
        Me.btn_Codigo.Size = New System.Drawing.Size(96, 23)
        Me.btn_Codigo.TabIndex = 4
        Me.btn_Codigo.Text = "Generar Codigo"
        Me.btn_Codigo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Codigo.UseVisualStyleBackColor = True
        Me.btn_Codigo.Visible = False
        '
        'btn_BuscarEmpleados
        '
        Me.btn_BuscarEmpleados.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_BuscarEmpleados.Location = New System.Drawing.Point(268, 4)
        Me.btn_BuscarEmpleados.Name = "btn_BuscarEmpleados"
        Me.btn_BuscarEmpleados.Size = New System.Drawing.Size(80, 23)
        Me.btn_BuscarEmpleados.TabIndex = 2
        Me.btn_BuscarEmpleados.Text = "Reingreso"
        Me.btn_BuscarEmpleados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarEmpleados.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarEmpleados.UseVisualStyleBackColor = True
        '
        'lbl_UMF
        '
        Me.lbl_UMF.AutoSize = True
        Me.lbl_UMF.Location = New System.Drawing.Point(816, 181)
        Me.lbl_UMF.Name = "lbl_UMF"
        Me.lbl_UMF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_UMF.TabIndex = 108
        Me.lbl_UMF.Text = "UMF"
        '
        'lbl_EmpleadoReferencia
        '
        Me.lbl_EmpleadoReferencia.AutoSize = True
        Me.lbl_EmpleadoReferencia.Location = New System.Drawing.Point(4, 529)
        Me.lbl_EmpleadoReferencia.Name = "lbl_EmpleadoReferencia"
        Me.lbl_EmpleadoReferencia.Size = New System.Drawing.Size(109, 13)
        Me.lbl_EmpleadoReferencia.TabIndex = 80
        Me.lbl_EmpleadoReferencia.Text = "Empleado Referencia"
        '
        'lbl_FechaVenceCredencial
        '
        Me.lbl_FechaVenceCredencial.AutoSize = True
        Me.lbl_FechaVenceCredencial.Location = New System.Drawing.Point(472, 324)
        Me.lbl_FechaVenceCredencial.Name = "lbl_FechaVenceCredencial"
        Me.lbl_FechaVenceCredencial.Size = New System.Drawing.Size(124, 13)
        Me.lbl_FechaVenceCredencial.TabIndex = 123
        Me.lbl_FechaVenceCredencial.Text = "Fecha Vence Credencial"
        '
        'tbx_NombreCompleto
        '
        Me.tbx_NombreCompleto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreCompleto.Control_Siguiente = Me.cmb_Departamento_DG
        Me.tbx_NombreCompleto.Filtrado = True
        Me.tbx_NombreCompleto.Location = New System.Drawing.Point(115, 33)
        Me.tbx_NombreCompleto.MaxLength = 100
        Me.tbx_NombreCompleto.Name = "tbx_NombreCompleto"
        Me.tbx_NombreCompleto.ReadOnly = True
        Me.tbx_NombreCompleto.Size = New System.Drawing.Size(354, 20)
        Me.tbx_NombreCompleto.TabIndex = 5
        Me.tbx_NombreCompleto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_NombreCompleto
        '
        Me.lbl_NombreCompleto.AutoSize = True
        Me.lbl_NombreCompleto.Location = New System.Drawing.Point(22, 36)
        Me.lbl_NombreCompleto.Name = "lbl_NombreCompleto"
        Me.lbl_NombreCompleto.Size = New System.Drawing.Size(91, 13)
        Me.lbl_NombreCompleto.TabIndex = 5
        Me.lbl_NombreCompleto.Text = "Nombre Completo"
        Me.lbl_NombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(262, 83)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(13, 16)
        Me.Label69.TabIndex = 14
        Me.Label69.Text = "*"
        '
        'lbl_AMaterno
        '
        Me.lbl_AMaterno.AutoSize = True
        Me.lbl_AMaterno.Location = New System.Drawing.Point(281, 85)
        Me.lbl_AMaterno.Name = "lbl_AMaterno"
        Me.lbl_AMaterno.Size = New System.Drawing.Size(46, 13)
        Me.lbl_AMaterno.TabIndex = 12
        Me.lbl_AMaterno.Text = "Materno"
        Me.lbl_AMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APaterno
        '
        Me.lbl_APaterno.AutoSize = True
        Me.lbl_APaterno.Location = New System.Drawing.Point(29, 84)
        Me.lbl_APaterno.Name = "lbl_APaterno"
        Me.lbl_APaterno.Size = New System.Drawing.Size(84, 13)
        Me.lbl_APaterno.TabIndex = 10
        Me.lbl_APaterno.Text = "Apellido Paterno"
        Me.lbl_APaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Fecha_FinLabores
        '
        Me.tbx_Fecha_FinLabores.Control_Siguiente = Nothing
        Me.tbx_Fecha_FinLabores.Filtrado = True
        Me.tbx_Fecha_FinLabores.Location = New System.Drawing.Point(602, 298)
        Me.tbx_Fecha_FinLabores.MaxLength = 8
        Me.tbx_Fecha_FinLabores.Name = "tbx_Fecha_FinLabores"
        Me.tbx_Fecha_FinLabores.ReadOnly = True
        Me.tbx_Fecha_FinLabores.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Fecha_FinLabores.TabIndex = 119
        Me.tbx_Fecha_FinLabores.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FechaBaja
        '
        Me.lbl_FechaBaja.AutoSize = True
        Me.lbl_FechaBaja.Location = New System.Drawing.Point(535, 301)
        Me.lbl_FechaBaja.Name = "lbl_FechaBaja"
        Me.lbl_FechaBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FechaBaja.TabIndex = 120
        Me.lbl_FechaBaja.Text = "Fecha Baja"
        '
        'lbl_FechaIngreso
        '
        Me.lbl_FechaIngreso.AutoSize = True
        Me.lbl_FechaIngreso.Location = New System.Drawing.Point(521, 278)
        Me.lbl_FechaIngreso.Name = "lbl_FechaIngreso"
        Me.lbl_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FechaIngreso.TabIndex = 116
        Me.lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.ForeColor = System.Drawing.Color.Red
        Me.Label140.Location = New System.Drawing.Point(968, 385)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(13, 16)
        Me.Label140.TabIndex = 145
        Me.Label140.Text = "*"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.ForeColor = System.Drawing.Color.Red
        Me.Label142.Location = New System.Drawing.Point(718, 407)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(13, 16)
        Me.Label142.TabIndex = 136
        Me.Label142.Text = "*"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(968, 354)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(13, 16)
        Me.Label42.TabIndex = 139
        Me.Label42.Text = "*"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(335, 108)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 16)
        Me.Label41.TabIndex = 19
        Me.Label41.Text = "*"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(335, 133)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 16)
        Me.Label40.TabIndex = 22
        Me.Label40.Text = "*"
        '
        'lbl_CantHijos
        '
        Me.lbl_CantHijos.AutoSize = True
        Me.lbl_CantHijos.Location = New System.Drawing.Point(338, 358)
        Me.lbl_CantHijos.Name = "lbl_CantHijos"
        Me.lbl_CantHijos.Size = New System.Drawing.Size(75, 13)
        Me.lbl_CantHijos.TabIndex = 56
        Me.lbl_CantHijos.Text = "Cantidad Hijos"
        '
        'cmb_Ciudades_DG
        '
        Me.cmb_Ciudades_DG.Clave = Nothing
        Me.cmb_Ciudades_DG.Control_Siguiente = Me.cmb_Zonas
        Me.cmb_Ciudades_DG.DisplayMember = "Nombre"
        Me.cmb_Ciudades_DG.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudades_DG.Empresa = False
        Me.cmb_Ciudades_DG.Filtro = Nothing
        Me.cmb_Ciudades_DG.FormattingEnabled = True
        Me.cmb_Ciudades_DG.Location = New System.Drawing.Point(248, 155)
        Me.cmb_Ciudades_DG.MaxDropDownItems = 20
        Me.cmb_Ciudades_DG.Name = "cmb_Ciudades_DG"
        Me.cmb_Ciudades_DG.Pista = False
        Me.cmb_Ciudades_DG.Size = New System.Drawing.Size(221, 21)
        Me.cmb_Ciudades_DG.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudades_DG.Sucursal = False
        Me.cmb_Ciudades_DG.TabIndex = 14
        Me.cmb_Ciudades_DG.Tipo = 0
        Me.cmb_Ciudades_DG.ValueMember = "id_Ciudad"
        '
        'lbl_CertifAcademia
        '
        Me.lbl_CertifAcademia.AutoSize = True
        Me.lbl_CertifAcademia.Location = New System.Drawing.Point(731, 381)
        Me.lbl_CertifAcademia.Name = "lbl_CertifAcademia"
        Me.lbl_CertifAcademia.Size = New System.Drawing.Size(115, 13)
        Me.lbl_CertifAcademia.TabIndex = 143
        Me.lbl_CertifAcademia.Text = "Certificación Academia"
        '
        'gbx_CertifAcademia
        '
        Me.gbx_CertifAcademia.Controls.Add(Me.rdb_No_CertifAcademia)
        Me.gbx_CertifAcademia.Controls.Add(Me.rdb_Si_CertifAcademia)
        Me.gbx_CertifAcademia.Location = New System.Drawing.Point(852, 371)
        Me.gbx_CertifAcademia.Name = "gbx_CertifAcademia"
        Me.gbx_CertifAcademia.Size = New System.Drawing.Size(110, 32)
        Me.gbx_CertifAcademia.TabIndex = 129
        Me.gbx_CertifAcademia.TabStop = False
        '
        'rdb_No_CertifAcademia
        '
        Me.rdb_No_CertifAcademia.AutoSize = True
        Me.rdb_No_CertifAcademia.Location = New System.Drawing.Point(59, 12)
        Me.rdb_No_CertifAcademia.Name = "rdb_No_CertifAcademia"
        Me.rdb_No_CertifAcademia.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_CertifAcademia.TabIndex = 1
        Me.rdb_No_CertifAcademia.Text = "No"
        Me.rdb_No_CertifAcademia.UseVisualStyleBackColor = True
        '
        'rdb_Si_CertifAcademia
        '
        Me.rdb_Si_CertifAcademia.AutoSize = True
        Me.rdb_Si_CertifAcademia.Location = New System.Drawing.Point(6, 12)
        Me.rdb_Si_CertifAcademia.Name = "rdb_Si_CertifAcademia"
        Me.rdb_Si_CertifAcademia.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CertifAcademia.TabIndex = 0
        Me.rdb_Si_CertifAcademia.Text = "Si"
        Me.rdb_Si_CertifAcademia.UseVisualStyleBackColor = True
        '
        'tbx_SueldoBase
        '
        Me.tbx_SueldoBase.Control_Siguiente = Me.tbx_Calle
        Me.tbx_SueldoBase.Filtrado = True
        Me.tbx_SueldoBase.Location = New System.Drawing.Point(419, 132)
        Me.tbx_SueldoBase.MaxLength = 6
        Me.tbx_SueldoBase.Name = "tbx_SueldoBase"
        Me.tbx_SueldoBase.Size = New System.Drawing.Size(50, 20)
        Me.tbx_SueldoBase.TabIndex = 11
        Me.tbx_SueldoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_SueldoBase.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Calle
        '
        Me.tbx_Calle.Control_Siguiente = Me.tbx_EntreCalle1
        Me.tbx_Calle.Filtrado = True
        Me.tbx_Calle.Location = New System.Drawing.Point(115, 229)
        Me.tbx_Calle.MaxLength = 100
        Me.tbx_Calle.Name = "tbx_Calle"
        Me.tbx_Calle.Size = New System.Drawing.Size(149, 20)
        Me.tbx_Calle.TabIndex = 19
        Me.tbx_Calle.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreCalle1
        '
        Me.tbx_EntreCalle1.Control_Siguiente = Me.tbx_EntreCalle2
        Me.tbx_EntreCalle1.Filtrado = False
        Me.tbx_EntreCalle1.Location = New System.Drawing.Point(115, 252)
        Me.tbx_EntreCalle1.MaxLength = 100
        Me.tbx_EntreCalle1.Name = "tbx_EntreCalle1"
        Me.tbx_EntreCalle1.Size = New System.Drawing.Size(149, 20)
        Me.tbx_EntreCalle1.TabIndex = 21
        Me.tbx_EntreCalle1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_EntreCalle2
        '
        Me.tbx_EntreCalle2.Control_Siguiente = Me.tbx_NumExterior
        Me.tbx_EntreCalle2.Filtrado = False
        Me.tbx_EntreCalle2.Location = New System.Drawing.Point(324, 229)
        Me.tbx_EntreCalle2.MaxLength = 100
        Me.tbx_EntreCalle2.Name = "tbx_EntreCalle2"
        Me.tbx_EntreCalle2.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle2.TabIndex = 20
        Me.tbx_EntreCalle2.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_NumExterior
        '
        Me.tbx_NumExterior.Control_Siguiente = Me.tbx_NumInterior
        Me.tbx_NumExterior.Filtrado = True
        Me.tbx_NumExterior.Location = New System.Drawing.Point(414, 252)
        Me.tbx_NumExterior.MaxLength = 6
        Me.tbx_NumExterior.Name = "tbx_NumExterior"
        Me.tbx_NumExterior.Size = New System.Drawing.Size(55, 20)
        Me.tbx_NumExterior.TabIndex = 22
        Me.tbx_NumExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NumExterior.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NumInterior
        '
        Me.tbx_NumInterior.Control_Siguiente = Me.tbx_Colonia
        Me.tbx_NumInterior.Filtrado = False
        Me.tbx_NumInterior.Location = New System.Drawing.Point(419, 276)
        Me.tbx_NumInterior.MaxLength = 10
        Me.tbx_NumInterior.Name = "tbx_NumInterior"
        Me.tbx_NumInterior.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumInterior.TabIndex = 24
        Me.tbx_NumInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NumInterior.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Colonia
        '
        Me.tbx_Colonia.Control_Siguiente = Me.cmb_Ciudades_DG
        Me.tbx_Colonia.Filtrado = True
        Me.tbx_Colonia.Location = New System.Drawing.Point(115, 178)
        Me.tbx_Colonia.MaxLength = 100
        Me.tbx_Colonia.Name = "tbx_Colonia"
        Me.tbx_Colonia.ReadOnly = True
        Me.tbx_Colonia.Size = New System.Drawing.Size(354, 20)
        Me.tbx_Colonia.TabIndex = 15
        Me.tbx_Colonia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Sueldo
        '
        Me.lbl_Sueldo.AutoSize = True
        Me.lbl_Sueldo.Location = New System.Drawing.Point(346, 135)
        Me.lbl_Sueldo.Name = "lbl_Sueldo"
        Me.lbl_Sueldo.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Sueldo.TabIndex = 18
        Me.lbl_Sueldo.Text = "Sueldo Base"
        '
        'lbl_Pasaporte
        '
        Me.lbl_Pasaporte.AutoSize = True
        Me.lbl_Pasaporte.Location = New System.Drawing.Point(541, 181)
        Me.lbl_Pasaporte.Name = "lbl_Pasaporte"
        Me.lbl_Pasaporte.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Pasaporte.TabIndex = 106
        Me.lbl_Pasaporte.Text = "Pasaporte"
        '
        'lbl_NumCartilla
        '
        Me.lbl_NumCartilla.AutoSize = True
        Me.lbl_NumCartilla.Location = New System.Drawing.Point(788, 157)
        Me.lbl_NumCartilla.Name = "lbl_NumCartilla"
        Me.lbl_NumCartilla.Size = New System.Drawing.Size(58, 13)
        Me.lbl_NumCartilla.TabIndex = 104
        Me.lbl_NumCartilla.Text = "No. Cartilla"
        '
        'lbl_FechaExpira
        '
        Me.lbl_FechaExpira.AutoSize = True
        Me.lbl_FechaExpira.Location = New System.Drawing.Point(484, 254)
        Me.lbl_FechaExpira.Name = "lbl_FechaExpira"
        Me.lbl_FechaExpira.Size = New System.Drawing.Size(112, 13)
        Me.lbl_FechaExpira.TabIndex = 114
        Me.lbl_FechaExpira.Text = "Fecha Expira Licencia"
        '
        'lbl_TipoLicencia
        '
        Me.lbl_TipoLicencia.AutoSize = True
        Me.lbl_TipoLicencia.Location = New System.Drawing.Point(525, 228)
        Me.lbl_TipoLicencia.Name = "lbl_TipoLicencia"
        Me.lbl_TipoLicencia.Size = New System.Drawing.Size(71, 13)
        Me.lbl_TipoLicencia.TabIndex = 112
        Me.lbl_TipoLicencia.Text = "Tipo Licencia"
        '
        'lbl_IMSS
        '
        Me.lbl_IMSS.AutoSize = True
        Me.lbl_IMSS.Location = New System.Drawing.Point(813, 133)
        Me.lbl_IMSS.Name = "lbl_IMSS"
        Me.lbl_IMSS.Size = New System.Drawing.Size(33, 13)
        Me.lbl_IMSS.TabIndex = 99
        Me.lbl_IMSS.Text = "IMSS"
        '
        'lbl_CURP
        '
        Me.lbl_CURP.AutoSize = True
        Me.lbl_CURP.Location = New System.Drawing.Point(559, 133)
        Me.lbl_CURP.Name = "lbl_CURP"
        Me.lbl_CURP.Size = New System.Drawing.Size(37, 13)
        Me.lbl_CURP.TabIndex = 96
        Me.lbl_CURP.Text = "CURP"
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(818, 109)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 92
        Me.lbl_RFC.Text = "RFC"
        '
        'lbl_Elector
        '
        Me.lbl_Elector.AutoSize = True
        Me.lbl_Elector.Location = New System.Drawing.Point(526, 109)
        Me.lbl_Elector.Name = "lbl_Elector"
        Me.lbl_Elector.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Elector.TabIndex = 90
        Me.lbl_Elector.Text = "Clave Elector"
        '
        'tbx_Edad
        '
        Me.tbx_Edad.Control_Siguiente = Me.cmb_Pais
        Me.tbx_Edad.Filtrado = True
        Me.tbx_Edad.Location = New System.Drawing.Point(419, 379)
        Me.tbx_Edad.MaxLength = 2
        Me.tbx_Edad.Name = "tbx_Edad"
        Me.tbx_Edad.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Edad.TabIndex = 36
        Me.tbx_Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Edad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Edad
        '
        Me.lbl_Edad.AutoSize = True
        Me.lbl_Edad.Location = New System.Drawing.Point(381, 382)
        Me.lbl_Edad.Name = "lbl_Edad"
        Me.lbl_Edad.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Edad.TabIndex = 61
        Me.lbl_Edad.Text = "Edad"
        '
        'lbl_ModoNacionalidad
        '
        Me.lbl_ModoNacionalidad.AutoSize = True
        Me.lbl_ModoNacionalidad.Location = New System.Drawing.Point(14, 457)
        Me.lbl_ModoNacionalidad.Name = "lbl_ModoNacionalidad"
        Me.lbl_ModoNacionalidad.Size = New System.Drawing.Size(99, 13)
        Me.lbl_ModoNacionalidad.TabIndex = 71
        Me.lbl_ModoNacionalidad.Text = "Modo Nacionalidad"
        '
        'lbl_PaisNacimiento
        '
        Me.lbl_PaisNacimiento.AutoSize = True
        Me.lbl_PaisNacimiento.Location = New System.Drawing.Point(28, 407)
        Me.lbl_PaisNacimiento.Name = "lbl_PaisNacimiento"
        Me.lbl_PaisNacimiento.Size = New System.Drawing.Size(85, 13)
        Me.lbl_PaisNacimiento.TabIndex = 64
        Me.lbl_PaisNacimiento.Text = "País Nacimiento"
        '
        'lbl_EntreCalle2
        '
        Me.lbl_EntreCalle2.AutoSize = True
        Me.lbl_EntreCalle2.Location = New System.Drawing.Point(267, 232)
        Me.lbl_EntreCalle2.Name = "lbl_EntreCalle2"
        Me.lbl_EntreCalle2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2.TabIndex = 30
        Me.lbl_EntreCalle2.Text = "Y la Calle"
        '
        'lbl_EntreCalle1
        '
        Me.lbl_EntreCalle1.AutoSize = True
        Me.lbl_EntreCalle1.Location = New System.Drawing.Point(40, 257)
        Me.lbl_EntreCalle1.Name = "lbl_EntreCalle1"
        Me.lbl_EntreCalle1.Size = New System.Drawing.Size(69, 13)
        Me.lbl_EntreCalle1.TabIndex = 28
        Me.lbl_EntreCalle1.Text = "Entre la Calle"
        '
        'lbl_LugarNac
        '
        Me.lbl_LugarNac.AutoSize = True
        Me.lbl_LugarNac.Location = New System.Drawing.Point(73, 434)
        Me.lbl_LugarNac.Name = "lbl_LugarNac"
        Me.lbl_LugarNac.Size = New System.Drawing.Size(40, 13)
        Me.lbl_LugarNac.TabIndex = 66
        Me.lbl_LugarNac.Text = "Estado"
        '
        'lbl_FechaNaturalizacion
        '
        Me.lbl_FechaNaturalizacion.AutoSize = True
        Me.lbl_FechaNaturalizacion.Location = New System.Drawing.Point(270, 457)
        Me.lbl_FechaNaturalizacion.Name = "lbl_FechaNaturalizacion"
        Me.lbl_FechaNaturalizacion.Size = New System.Drawing.Size(96, 13)
        Me.lbl_FechaNaturalizacion.TabIndex = 73
        Me.lbl_FechaNaturalizacion.Text = "Fecha Naturalizac."
        '
        'lbl_FechaNac
        '
        Me.lbl_FechaNac.AutoSize = True
        Me.lbl_FechaNac.Location = New System.Drawing.Point(20, 384)
        Me.lbl_FechaNac.Name = "lbl_FechaNac"
        Me.lbl_FechaNac.Size = New System.Drawing.Size(93, 13)
        Me.lbl_FechaNac.TabIndex = 58
        Me.lbl_FechaNac.Text = "Fecha Nacimiento"
        '
        'lbl_TelefonoMovil1
        '
        Me.lbl_TelefonoMovil1.AutoSize = True
        Me.lbl_TelefonoMovil1.Location = New System.Drawing.Point(769, 85)
        Me.lbl_TelefonoMovil1.Name = "lbl_TelefonoMovil1"
        Me.lbl_TelefonoMovil1.Size = New System.Drawing.Size(77, 13)
        Me.lbl_TelefonoMovil1.TabIndex = 88
        Me.lbl_TelefonoMovil1.Text = "Teléfono Móvil"
        '
        'lbl_Telefono1
        '
        Me.lbl_Telefono1.AutoSize = True
        Me.lbl_Telefono1.Location = New System.Drawing.Point(547, 85)
        Me.lbl_Telefono1.Name = "lbl_Telefono1"
        Me.lbl_Telefono1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono1.TabIndex = 86
        Me.lbl_Telefono1.Text = "Teléfono"
        '
        'lbl_Zona_DG
        '
        Me.lbl_Zona_DG.AutoSize = True
        Me.lbl_Zona_DG.Location = New System.Drawing.Point(77, 279)
        Me.lbl_Zona_DG.Name = "lbl_Zona_DG"
        Me.lbl_Zona_DG.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Zona_DG.TabIndex = 40
        Me.lbl_Zona_DG.Text = "Zona"
        '
        'lbl_Longitud
        '
        Me.lbl_Longitud.AutoSize = True
        Me.lbl_Longitud.Location = New System.Drawing.Point(275, 307)
        Me.lbl_Longitud.Name = "lbl_Longitud"
        Me.lbl_Longitud.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Longitud.TabIndex = 44
        Me.lbl_Longitud.Text = "Longitud"
        '
        'lbl_CP
        '
        Me.lbl_CP.AutoSize = True
        Me.lbl_CP.Location = New System.Drawing.Point(86, 158)
        Me.lbl_CP.Name = "lbl_CP"
        Me.lbl_CP.Size = New System.Drawing.Size(27, 13)
        Me.lbl_CP.TabIndex = 20
        Me.lbl_CP.Text = "C.P."
        '
        'lbl_Latitud
        '
        Me.lbl_Latitud.AutoSize = True
        Me.lbl_Latitud.Location = New System.Drawing.Point(154, 307)
        Me.lbl_Latitud.Name = "lbl_Latitud"
        Me.lbl_Latitud.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Latitud.TabIndex = 42
        Me.lbl_Latitud.Text = "Latitud"
        '
        'lbl_Ciudad_DG
        '
        Me.lbl_Ciudad_DG.AutoSize = True
        Me.lbl_Ciudad_DG.Location = New System.Drawing.Point(208, 158)
        Me.lbl_Ciudad_DG.Name = "lbl_Ciudad_DG"
        Me.lbl_Ciudad_DG.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ciudad_DG.TabIndex = 38
        Me.lbl_Ciudad_DG.Text = "Ciudad"
        '
        'lbl_NumInterior
        '
        Me.lbl_NumInterior.AutoSize = True
        Me.lbl_NumInterior.Location = New System.Drawing.Point(391, 279)
        Me.lbl_NumInterior.Name = "lbl_NumInterior"
        Me.lbl_NumInterior.Size = New System.Drawing.Size(22, 13)
        Me.lbl_NumInterior.TabIndex = 34
        Me.lbl_NumInterior.Text = "Int."
        '
        'lbl_NumExterior
        '
        Me.lbl_NumExterior.AutoSize = True
        Me.lbl_NumExterior.Location = New System.Drawing.Point(326, 255)
        Me.lbl_NumExterior.Name = "lbl_NumExterior"
        Me.lbl_NumExterior.Size = New System.Drawing.Size(82, 13)
        Me.lbl_NumExterior.TabIndex = 32
        Me.lbl_NumExterior.Text = "Número Exterior"
        '
        'lbl_Colonia
        '
        Me.lbl_Colonia.AutoSize = True
        Me.lbl_Colonia.Location = New System.Drawing.Point(67, 181)
        Me.lbl_Colonia.Name = "lbl_Colonia"
        Me.lbl_Colonia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia.TabIndex = 36
        Me.lbl_Colonia.Text = "Colonia"
        '
        'lbl_Calle
        '
        Me.lbl_Calle.AutoSize = True
        Me.lbl_Calle.Location = New System.Drawing.Point(83, 233)
        Me.lbl_Calle.Name = "lbl_Calle"
        Me.lbl_Calle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_Calle.TabIndex = 26
        Me.lbl_Calle.Text = "Calle"
        '
        'lbl_JefeArea
        '
        Me.lbl_JefeArea.AutoSize = True
        Me.lbl_JefeArea.Location = New System.Drawing.Point(508, 410)
        Me.lbl_JefeArea.Name = "lbl_JefeArea"
        Me.lbl_JefeArea.Size = New System.Drawing.Size(94, 13)
        Me.lbl_JefeArea.TabIndex = 134
        Me.lbl_JefeArea.Text = "¿Es Jefe de Área?"
        '
        'lbl_Firmas
        '
        Me.lbl_Firmas.AutoSize = True
        Me.lbl_Firmas.Location = New System.Drawing.Point(748, 352)
        Me.lbl_Firmas.Name = "lbl_Firmas"
        Me.lbl_Firmas.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Firmas.TabIndex = 137
        Me.lbl_Firmas.Text = "En Catálogo Firmas"
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Location = New System.Drawing.Point(520, 60)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Mail.TabIndex = 84
        Me.lbl_Mail.Text = "Email Empresa"
        '
        'gbx_JefeArea
        '
        Me.gbx_JefeArea.Controls.Add(Me.rdb_No_JefeArea)
        Me.gbx_JefeArea.Controls.Add(Me.rdb_Si_JefeArea)
        Me.gbx_JefeArea.Location = New System.Drawing.Point(602, 398)
        Me.gbx_JefeArea.Name = "gbx_JefeArea"
        Me.gbx_JefeArea.Size = New System.Drawing.Size(110, 30)
        Me.gbx_JefeArea.TabIndex = 126
        Me.gbx_JefeArea.TabStop = False
        '
        'rdb_No_JefeArea
        '
        Me.rdb_No_JefeArea.AutoSize = True
        Me.rdb_No_JefeArea.Location = New System.Drawing.Point(59, 10)
        Me.rdb_No_JefeArea.Name = "rdb_No_JefeArea"
        Me.rdb_No_JefeArea.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_JefeArea.TabIndex = 1
        Me.rdb_No_JefeArea.Text = "No"
        Me.rdb_No_JefeArea.UseVisualStyleBackColor = True
        '
        'rdb_Si_JefeArea
        '
        Me.rdb_Si_JefeArea.AutoSize = True
        Me.rdb_Si_JefeArea.Location = New System.Drawing.Point(6, 10)
        Me.rdb_Si_JefeArea.Name = "rdb_Si_JefeArea"
        Me.rdb_Si_JefeArea.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_JefeArea.TabIndex = 0
        Me.rdb_Si_JefeArea.Text = "Si"
        Me.rdb_Si_JefeArea.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_DG
        '
        Me.btn_Cancelar_DG.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DG.Location = New System.Drawing.Point(292, 651)
        Me.btn_Cancelar_DG.Name = "btn_Cancelar_DG"
        Me.btn_Cancelar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DG.TabIndex = 180
        Me.btn_Cancelar_DG.TabStop = False
        Me.btn_Cancelar_DG.Text = "&Cancelar"
        Me.btn_Cancelar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DG.UseVisualStyleBackColor = True
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(115, 9)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(74, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Guardar_DG
        '
        Me.btn_Guardar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_DG.Location = New System.Drawing.Point(119, 651)
        Me.btn_Guardar_DG.Name = "btn_Guardar_DG"
        Me.btn_Guardar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DG.TabIndex = 132
        Me.btn_Guardar_DG.Text = "&Guardar"
        Me.btn_Guardar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_DG.UseVisualStyleBackColor = True
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(58, 60)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Nombres.TabIndex = 8
        Me.lbl_Nombres.Text = "Nombre(s)"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(79, 12)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(39, 110)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 14
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(73, 135)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 16
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_EstadoCivil
        '
        Me.lbl_EstadoCivil.AutoSize = True
        Me.lbl_EstadoCivil.Location = New System.Drawing.Point(291, 333)
        Me.lbl_EstadoCivil.Name = "lbl_EstadoCivil"
        Me.lbl_EstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lbl_EstadoCivil.TabIndex = 51
        Me.lbl_EstadoCivil.Text = "Estado Civil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(335, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "*"
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.ForeColor = System.Drawing.Color.Red
        Me.Label144.Location = New System.Drawing.Point(905, 184)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(13, 16)
        Me.Label144.TabIndex = 110
        Me.Label144.Text = "*"
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label149.ForeColor = System.Drawing.Color.Red
        Me.Label149.Location = New System.Drawing.Point(961, 108)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(13, 16)
        Me.Label149.TabIndex = 94
        Me.Label149.Text = "*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(472, 436)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "*"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(962, 136)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 101
        Me.Label4.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(193, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "*"
        '
        'tab_ModoContacto
        '
        Me.tab_ModoContacto.Controls.Add(Me.cmb_Localizacion)
        Me.tab_ModoContacto.Controls.Add(Me.btn_AgregarContactos)
        Me.tab_ModoContacto.Controls.Add(Me.btn_Borrar)
        Me.tab_ModoContacto.Controls.Add(Me.btn_CancelarContac)
        Me.tab_ModoContacto.Controls.Add(Me.lsv_Contacto)
        Me.tab_ModoContacto.Controls.Add(Me.tbx_Descripcion)
        Me.tab_ModoContacto.Controls.Add(Me.lbl_Descripcion)
        Me.tab_ModoContacto.Controls.Add(Me.lbl_Contacto)
        Me.tab_ModoContacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_ModoContacto.Name = "tab_ModoContacto"
        Me.tab_ModoContacto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_ModoContacto.Size = New System.Drawing.Size(1523, 687)
        Me.tab_ModoContacto.TabIndex = 10
        Me.tab_ModoContacto.Text = "Contacto"
        Me.tab_ModoContacto.UseVisualStyleBackColor = True
        '
        'cmb_Localizacion
        '
        Me.cmb_Localizacion.Clave = "Clave"
        Me.cmb_Localizacion.Control_Siguiente = Nothing
        Me.cmb_Localizacion.DisplayMember = "Descripcion"
        Me.cmb_Localizacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Localizacion.Empresa = False
        Me.cmb_Localizacion.Filtro = Nothing
        Me.cmb_Localizacion.FormattingEnabled = True
        Me.cmb_Localizacion.Location = New System.Drawing.Point(99, 11)
        Me.cmb_Localizacion.MaxDropDownItems = 20
        Me.cmb_Localizacion.Name = "cmb_Localizacion"
        Me.cmb_Localizacion.Pista = True
        Me.cmb_Localizacion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Localizacion.StoredProcedure = "Cat_Localizacion_Get"
        Me.cmb_Localizacion.Sucursal = False
        Me.cmb_Localizacion.TabIndex = 1
        Me.cmb_Localizacion.Tipo = 0
        Me.cmb_Localizacion.ValueMember = "Id_Tlocalizacion"
        '
        'btn_AgregarContactos
        '
        Me.btn_AgregarContactos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_AgregarContactos.Location = New System.Drawing.Point(428, 32)
        Me.btn_AgregarContactos.Name = "btn_AgregarContactos"
        Me.btn_AgregarContactos.Size = New System.Drawing.Size(140, 30)
        Me.btn_AgregarContactos.TabIndex = 3
        Me.btn_AgregarContactos.Text = "Agregar"
        Me.btn_AgregarContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarContactos.UseVisualStyleBackColor = True
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar.Enabled = False
        Me.btn_Borrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar.Location = New System.Drawing.Point(19, 376)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 5
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_CancelarContac
        '
        Me.btn_CancelarContac.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarContac.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarContac.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarContac.Location = New System.Drawing.Point(187, 376)
        Me.btn_CancelarContac.Name = "btn_CancelarContac"
        Me.btn_CancelarContac.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarContac.TabIndex = 6
        Me.btn_CancelarContac.Text = "&Cancelar"
        Me.btn_CancelarContac.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarContac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarContac.UseVisualStyleBackColor = True
        '
        'lsv_Contacto
        '
        Me.lsv_Contacto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Contacto.FullRowSelect = True
        Me.lsv_Contacto.HideSelection = False
        Me.lsv_Contacto.Location = New System.Drawing.Point(19, 68)
        ListViewColumnSorter33.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter33.SortColumn = 0
        Me.lsv_Contacto.Lvs = ListViewColumnSorter33
        Me.lsv_Contacto.MultiSelect = False
        Me.lsv_Contacto.Name = "lsv_Contacto"
        Me.lsv_Contacto.Row1 = 15
        Me.lsv_Contacto.Row10 = 10
        Me.lsv_Contacto.Row2 = 25
        Me.lsv_Contacto.Row3 = 10
        Me.lsv_Contacto.Row4 = 10
        Me.lsv_Contacto.Row5 = 10
        Me.lsv_Contacto.Row6 = 10
        Me.lsv_Contacto.Row7 = 10
        Me.lsv_Contacto.Row8 = 10
        Me.lsv_Contacto.Row9 = 10
        Me.lsv_Contacto.Size = New System.Drawing.Size(1145, 302)
        Me.lsv_Contacto.TabIndex = 4
        Me.lsv_Contacto.UseCompatibleStateImageBehavior = False
        Me.lsv_Contacto.View = System.Windows.Forms.View.Details
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(99, 38)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Descripcion.TabIndex = 2
        Me.tbx_Descripcion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(27, 41)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Descripcion.TabIndex = 2
        Me.lbl_Descripcion.Text = "Descripción:"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(16, 14)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Contacto.TabIndex = 0
        Me.lbl_Contacto.Text = "Modo Contacto:"
        '
        'tab_RasgosPersonales
        '
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Principales)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Boca)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Menton)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Labios)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Ojos)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Cejas)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Frente)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Nariz)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Oreja)
        Me.tab_RasgosPersonales.Controls.Add(Me.gbx_Cabello)
        Me.tab_RasgosPersonales.Controls.Add(Me.btn_CancelarRasgos)
        Me.tab_RasgosPersonales.Controls.Add(Me.btn_GuardarRasgos)
        Me.tab_RasgosPersonales.Location = New System.Drawing.Point(4, 22)
        Me.tab_RasgosPersonales.Name = "tab_RasgosPersonales"
        Me.tab_RasgosPersonales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_RasgosPersonales.Size = New System.Drawing.Size(1523, 687)
        Me.tab_RasgosPersonales.TabIndex = 8
        Me.tab_RasgosPersonales.Text = "Rasgos"
        Me.tab_RasgosPersonales.UseVisualStyleBackColor = True
        '
        'gbx_Principales
        '
        Me.gbx_Principales.Controls.Add(Me.cmb_ComplexionR)
        Me.gbx_Principales.Controls.Add(Me.cmb_ColorPiel)
        Me.gbx_Principales.Controls.Add(Me.pct_RasgoPerfilIzq)
        Me.gbx_Principales.Controls.Add(Me.btn_RasgoPerfilIzq)
        Me.gbx_Principales.Controls.Add(Me.pct_RasgoPerfilDer)
        Me.gbx_Principales.Controls.Add(Me.btn_RasgoPerfilDer)
        Me.gbx_Principales.Controls.Add(Me.btn_RasgoFrente)
        Me.gbx_Principales.Controls.Add(Me.pct_RasgoFrente)
        Me.gbx_Principales.Controls.Add(Me.cmb_FactorRH)
        Me.gbx_Principales.Controls.Add(Me.cmb_TipoSangreR)
        Me.gbx_Principales.Controls.Add(Me.cmb_Cara)
        Me.gbx_Principales.Controls.Add(Me.cmb_UsaAnteojos)
        Me.gbx_Principales.Controls.Add(Me.Label112)
        Me.gbx_Principales.Controls.Add(Me.tbx_EstaturaR)
        Me.gbx_Principales.Controls.Add(Me.Lbl_EstaturaRasgos)
        Me.gbx_Principales.Controls.Add(Me.Label116)
        Me.gbx_Principales.Controls.Add(Me.Lbl_ComplexcionRasgos)
        Me.gbx_Principales.Controls.Add(Me.tbx_PesoR)
        Me.gbx_Principales.Controls.Add(Me.Lbl_PesoRasgos)
        Me.gbx_Principales.Controls.Add(Me.Label78)
        Me.gbx_Principales.Controls.Add(Me.lbl_Cara)
        Me.gbx_Principales.Controls.Add(Me.lbl_UsaAnteojos)
        Me.gbx_Principales.Controls.Add(Me.lbl_FactorRH)
        Me.gbx_Principales.Controls.Add(Me.lbl_TipoSangreR)
        Me.gbx_Principales.Location = New System.Drawing.Point(6, 2)
        Me.gbx_Principales.Name = "gbx_Principales"
        Me.gbx_Principales.Size = New System.Drawing.Size(896, 101)
        Me.gbx_Principales.TabIndex = 0
        Me.gbx_Principales.TabStop = False
        '
        'cmb_ComplexionR
        '
        Me.cmb_ComplexionR.Clave = Nothing
        Me.cmb_ComplexionR.Control_Siguiente = Nothing
        Me.cmb_ComplexionR.DisplayMember = "Descripcion"
        Me.cmb_ComplexionR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ComplexionR.Empresa = False
        Me.cmb_ComplexionR.Filtro = Nothing
        Me.cmb_ComplexionR.FormattingEnabled = True
        Me.cmb_ComplexionR.Location = New System.Drawing.Point(81, 20)
        Me.cmb_ComplexionR.MaxDropDownItems = 20
        Me.cmb_ComplexionR.Name = "cmb_ComplexionR"
        Me.cmb_ComplexionR.Pista = False
        Me.cmb_ComplexionR.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ComplexionR.StoredProcedure = "Cat_TipoComplexionCombo_Get"
        Me.cmb_ComplexionR.Sucursal = False
        Me.cmb_ComplexionR.TabIndex = 24
        Me.cmb_ComplexionR.Tipo = 0
        Me.cmb_ComplexionR.ValueMember = "Id_TipoComplexion"
        '
        'cmb_ColorPiel
        '
        Me.cmb_ColorPiel.Clave = Nothing
        Me.cmb_ColorPiel.Control_Siguiente = Nothing
        Me.cmb_ColorPiel.DisplayMember = "Descripcion"
        Me.cmb_ColorPiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorPiel.Empresa = False
        Me.cmb_ColorPiel.Filtro = Nothing
        Me.cmb_ColorPiel.FormattingEnabled = True
        Me.cmb_ColorPiel.Location = New System.Drawing.Point(81, 44)
        Me.cmb_ColorPiel.MaxDropDownItems = 20
        Me.cmb_ColorPiel.Name = "cmb_ColorPiel"
        Me.cmb_ColorPiel.Pista = False
        Me.cmb_ColorPiel.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ColorPiel.StoredProcedure = "Cat_ColorPielCombo_Get"
        Me.cmb_ColorPiel.Sucursal = False
        Me.cmb_ColorPiel.TabIndex = 23
        Me.cmb_ColorPiel.Tipo = 0
        Me.cmb_ColorPiel.ValueMember = "Id_ColorPiel"
        '
        'pct_RasgoPerfilIzq
        '
        Me.pct_RasgoPerfilIzq.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_RasgoPerfilIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_RasgoPerfilIzq.Location = New System.Drawing.Point(744, 10)
        Me.pct_RasgoPerfilIzq.Name = "pct_RasgoPerfilIzq"
        Me.pct_RasgoPerfilIzq.Size = New System.Drawing.Size(110, 29)
        Me.pct_RasgoPerfilIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_RasgoPerfilIzq.TabIndex = 20
        Me.pct_RasgoPerfilIzq.TabStop = False
        Me.pct_RasgoPerfilIzq.Visible = False
        '
        'btn_RasgoPerfilIzq
        '
        Me.btn_RasgoPerfilIzq.Enabled = False
        Me.btn_RasgoPerfilIzq.Location = New System.Drawing.Point(860, 74)
        Me.btn_RasgoPerfilIzq.Name = "btn_RasgoPerfilIzq"
        Me.btn_RasgoPerfilIzq.Size = New System.Drawing.Size(30, 23)
        Me.btn_RasgoPerfilIzq.TabIndex = 21
        Me.btn_RasgoPerfilIzq.Text = "PI"
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_RasgoPerfilIzq, "Mostrar Imagen de Perfil Izquierdo")
        Me.btn_RasgoPerfilIzq.UseVisualStyleBackColor = True
        '
        'pct_RasgoPerfilDer
        '
        Me.pct_RasgoPerfilDer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_RasgoPerfilDer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_RasgoPerfilDer.Location = New System.Drawing.Point(744, 10)
        Me.pct_RasgoPerfilDer.Name = "pct_RasgoPerfilDer"
        Me.pct_RasgoPerfilDer.Size = New System.Drawing.Size(110, 55)
        Me.pct_RasgoPerfilDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_RasgoPerfilDer.TabIndex = 19
        Me.pct_RasgoPerfilDer.TabStop = False
        Me.pct_RasgoPerfilDer.Visible = False
        '
        'btn_RasgoPerfilDer
        '
        Me.btn_RasgoPerfilDer.Enabled = False
        Me.btn_RasgoPerfilDer.Location = New System.Drawing.Point(860, 42)
        Me.btn_RasgoPerfilDer.Name = "btn_RasgoPerfilDer"
        Me.btn_RasgoPerfilDer.Size = New System.Drawing.Size(30, 23)
        Me.btn_RasgoPerfilDer.TabIndex = 20
        Me.btn_RasgoPerfilDer.Text = "PD"
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_RasgoPerfilDer, "Mostrar Imagen de Perfil Derecho")
        Me.btn_RasgoPerfilDer.UseVisualStyleBackColor = True
        '
        'btn_RasgoFrente
        '
        Me.btn_RasgoFrente.Enabled = False
        Me.btn_RasgoFrente.Location = New System.Drawing.Point(860, 10)
        Me.btn_RasgoFrente.Name = "btn_RasgoFrente"
        Me.btn_RasgoFrente.Size = New System.Drawing.Size(30, 23)
        Me.btn_RasgoFrente.TabIndex = 19
        Me.btn_RasgoFrente.Text = "F"
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_RasgoFrente, "Mostrar Imagen de Frente")
        Me.btn_RasgoFrente.UseVisualStyleBackColor = True
        '
        'pct_RasgoFrente
        '
        Me.pct_RasgoFrente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_RasgoFrente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_RasgoFrente.Location = New System.Drawing.Point(744, 10)
        Me.pct_RasgoFrente.Name = "pct_RasgoFrente"
        Me.pct_RasgoFrente.Size = New System.Drawing.Size(110, 87)
        Me.pct_RasgoFrente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_RasgoFrente.TabIndex = 18
        Me.pct_RasgoFrente.TabStop = False
        '
        'cmb_FactorRH
        '
        Me.cmb_FactorRH.Control_Siguiente = Nothing
        Me.cmb_FactorRH.DisplayMember = "display"
        Me.cmb_FactorRH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FactorRH.FormattingEnabled = True
        Me.cmb_FactorRH.Location = New System.Drawing.Point(331, 44)
        Me.cmb_FactorRH.MaxDropDownItems = 20
        Me.cmb_FactorRH.Name = "cmb_FactorRH"
        Me.cmb_FactorRH.Size = New System.Drawing.Size(145, 21)
        Me.cmb_FactorRH.TabIndex = 9
        Me.cmb_FactorRH.ValueMember = "value"
        '
        'cmb_TipoSangreR
        '
        Me.cmb_TipoSangreR.Control_Siguiente = Nothing
        Me.cmb_TipoSangreR.DisplayMember = "display"
        Me.cmb_TipoSangreR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoSangreR.FormattingEnabled = True
        Me.cmb_TipoSangreR.Location = New System.Drawing.Point(331, 20)
        Me.cmb_TipoSangreR.MaxDropDownItems = 20
        Me.cmb_TipoSangreR.Name = "cmb_TipoSangreR"
        Me.cmb_TipoSangreR.Size = New System.Drawing.Size(145, 21)
        Me.cmb_TipoSangreR.TabIndex = 7
        Me.cmb_TipoSangreR.ValueMember = "value"
        '
        'cmb_Cara
        '
        Me.cmb_Cara.Control_Siguiente = Nothing
        Me.cmb_Cara.DisplayMember = "display"
        Me.cmb_Cara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Cara.FormattingEnabled = True
        Me.cmb_Cara.Location = New System.Drawing.Point(82, 68)
        Me.cmb_Cara.MaxDropDownItems = 20
        Me.cmb_Cara.Name = "cmb_Cara"
        Me.cmb_Cara.Size = New System.Drawing.Size(145, 21)
        Me.cmb_Cara.TabIndex = 5
        Me.cmb_Cara.ValueMember = "value"
        '
        'cmb_UsaAnteojos
        '
        Me.cmb_UsaAnteojos.Control_Siguiente = Nothing
        Me.cmb_UsaAnteojos.DisplayMember = "display"
        Me.cmb_UsaAnteojos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsaAnteojos.FormattingEnabled = True
        Me.cmb_UsaAnteojos.Location = New System.Drawing.Point(593, 21)
        Me.cmb_UsaAnteojos.MaxDropDownItems = 20
        Me.cmb_UsaAnteojos.Name = "cmb_UsaAnteojos"
        Me.cmb_UsaAnteojos.Size = New System.Drawing.Size(145, 21)
        Me.cmb_UsaAnteojos.TabIndex = 11
        Me.cmb_UsaAnteojos.ValueMember = "value"
        '
        'Label112
        '
        Me.Label112.AutoSize = True
        Me.Label112.Location = New System.Drawing.Point(649, 72)
        Me.Label112.Name = "Label112"
        Me.Label112.Size = New System.Drawing.Size(15, 13)
        Me.Label112.TabIndex = 17
        Me.Label112.Text = "m"
        '
        'tbx_EstaturaR
        '
        Me.tbx_EstaturaR.Control_Siguiente = Me.cmb_UsaAnteojos
        Me.tbx_EstaturaR.Filtrado = True
        Me.tbx_EstaturaR.Location = New System.Drawing.Point(593, 68)
        Me.tbx_EstaturaR.MaxLength = 4
        Me.tbx_EstaturaR.Name = "tbx_EstaturaR"
        Me.tbx_EstaturaR.Size = New System.Drawing.Size(50, 20)
        Me.tbx_EstaturaR.TabIndex = 16
        Me.tbx_EstaturaR.Text = "0.0"
        Me.tbx_EstaturaR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_EstaturaR.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Lbl_EstaturaRasgos
        '
        Me.Lbl_EstaturaRasgos.AutoSize = True
        Me.Lbl_EstaturaRasgos.Location = New System.Drawing.Point(541, 70)
        Me.Lbl_EstaturaRasgos.Name = "Lbl_EstaturaRasgos"
        Me.Lbl_EstaturaRasgos.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_EstaturaRasgos.TabIndex = 15
        Me.Lbl_EstaturaRasgos.Text = "Estatura"
        '
        'Label116
        '
        Me.Label116.AutoSize = True
        Me.Label116.Location = New System.Drawing.Point(649, 50)
        Me.Label116.Name = "Label116"
        Me.Label116.Size = New System.Drawing.Size(19, 13)
        Me.Label116.TabIndex = 14
        Me.Label116.Text = "kg"
        '
        'Lbl_ComplexcionRasgos
        '
        Me.Lbl_ComplexcionRasgos.AutoSize = True
        Me.Lbl_ComplexcionRasgos.Location = New System.Drawing.Point(15, 23)
        Me.Lbl_ComplexcionRasgos.Name = "Lbl_ComplexcionRasgos"
        Me.Lbl_ComplexcionRasgos.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_ComplexcionRasgos.TabIndex = 0
        Me.Lbl_ComplexcionRasgos.Text = "Complexión"
        '
        'tbx_PesoR
        '
        Me.tbx_PesoR.Control_Siguiente = Me.tbx_EstaturaR
        Me.tbx_PesoR.Filtrado = True
        Me.tbx_PesoR.Location = New System.Drawing.Point(593, 45)
        Me.tbx_PesoR.MaxLength = 4
        Me.tbx_PesoR.Name = "tbx_PesoR"
        Me.tbx_PesoR.Size = New System.Drawing.Size(50, 20)
        Me.tbx_PesoR.TabIndex = 13
        Me.tbx_PesoR.Text = "0.0"
        Me.tbx_PesoR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_PesoR.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Lbl_PesoRasgos
        '
        Me.Lbl_PesoRasgos.AutoSize = True
        Me.Lbl_PesoRasgos.Location = New System.Drawing.Point(556, 48)
        Me.Lbl_PesoRasgos.Name = "Lbl_PesoRasgos"
        Me.Lbl_PesoRasgos.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_PesoRasgos.TabIndex = 12
        Me.Lbl_PesoRasgos.Text = "Peso"
        '
        'Label78
        '
        Me.Label78.AutoSize = True
        Me.Label78.Location = New System.Drawing.Point(25, 47)
        Me.Label78.Name = "Label78"
        Me.Label78.Size = New System.Drawing.Size(51, 13)
        Me.Label78.TabIndex = 2
        Me.Label78.Text = "Color Piel"
        '
        'lbl_Cara
        '
        Me.lbl_Cara.AutoSize = True
        Me.lbl_Cara.Location = New System.Drawing.Point(47, 71)
        Me.lbl_Cara.Name = "lbl_Cara"
        Me.lbl_Cara.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Cara.TabIndex = 4
        Me.lbl_Cara.Text = "Cara"
        '
        'lbl_UsaAnteojos
        '
        Me.lbl_UsaAnteojos.AutoSize = True
        Me.lbl_UsaAnteojos.Location = New System.Drawing.Point(517, 25)
        Me.lbl_UsaAnteojos.Name = "lbl_UsaAnteojos"
        Me.lbl_UsaAnteojos.Size = New System.Drawing.Size(70, 13)
        Me.lbl_UsaAnteojos.TabIndex = 10
        Me.lbl_UsaAnteojos.Text = "Usa Anteojos"
        '
        'lbl_FactorRH
        '
        Me.lbl_FactorRH.AutoSize = True
        Me.lbl_FactorRH.Location = New System.Drawing.Point(269, 47)
        Me.lbl_FactorRH.Name = "lbl_FactorRH"
        Me.lbl_FactorRH.Size = New System.Drawing.Size(56, 13)
        Me.lbl_FactorRH.TabIndex = 8
        Me.lbl_FactorRH.Text = "Factor RH"
        '
        'lbl_TipoSangreR
        '
        Me.lbl_TipoSangreR.AutoSize = True
        Me.lbl_TipoSangreR.Location = New System.Drawing.Point(260, 24)
        Me.lbl_TipoSangreR.Name = "lbl_TipoSangreR"
        Me.lbl_TipoSangreR.Size = New System.Drawing.Size(65, 13)
        Me.lbl_TipoSangreR.TabIndex = 6
        Me.lbl_TipoSangreR.Text = "Tipo Sangre"
        '
        'gbx_Boca
        '
        Me.gbx_Boca.Controls.Add(Me.cmb_ComisurasBoca)
        Me.gbx_Boca.Controls.Add(Me.cmb_TamañoBoca)
        Me.gbx_Boca.Controls.Add(Me.Lbl_TamañoRasgos)
        Me.gbx_Boca.Controls.Add(Me.Lbl_ComisurasRasgos)
        Me.gbx_Boca.Location = New System.Drawing.Point(262, 354)
        Me.gbx_Boca.Name = "gbx_Boca"
        Me.gbx_Boca.Size = New System.Drawing.Size(250, 69)
        Me.gbx_Boca.TabIndex = 6
        Me.gbx_Boca.TabStop = False
        Me.gbx_Boca.Text = "Boca"
        '
        'cmb_ComisurasBoca
        '
        Me.cmb_ComisurasBoca.Control_Siguiente = Nothing
        Me.cmb_ComisurasBoca.DisplayMember = "display"
        Me.cmb_ComisurasBoca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ComisurasBoca.FormattingEnabled = True
        Me.cmb_ComisurasBoca.Location = New System.Drawing.Point(74, 42)
        Me.cmb_ComisurasBoca.MaxDropDownItems = 20
        Me.cmb_ComisurasBoca.Name = "cmb_ComisurasBoca"
        Me.cmb_ComisurasBoca.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ComisurasBoca.TabIndex = 3
        Me.cmb_ComisurasBoca.ValueMember = "value"
        '
        'cmb_TamañoBoca
        '
        Me.cmb_TamañoBoca.Control_Siguiente = Nothing
        Me.cmb_TamañoBoca.DisplayMember = "display"
        Me.cmb_TamañoBoca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TamañoBoca.FormattingEnabled = True
        Me.cmb_TamañoBoca.Location = New System.Drawing.Point(74, 18)
        Me.cmb_TamañoBoca.MaxDropDownItems = 20
        Me.cmb_TamañoBoca.Name = "cmb_TamañoBoca"
        Me.cmb_TamañoBoca.Size = New System.Drawing.Size(146, 21)
        Me.cmb_TamañoBoca.TabIndex = 1
        Me.cmb_TamañoBoca.ValueMember = "value"
        '
        'Lbl_TamañoRasgos
        '
        Me.Lbl_TamañoRasgos.AutoSize = True
        Me.Lbl_TamañoRasgos.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_TamañoRasgos.Name = "Lbl_TamañoRasgos"
        Me.Lbl_TamañoRasgos.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_TamañoRasgos.TabIndex = 0
        Me.Lbl_TamañoRasgos.Text = "Tamaño"
        '
        'Lbl_ComisurasRasgos
        '
        Me.Lbl_ComisurasRasgos.AutoSize = True
        Me.Lbl_ComisurasRasgos.Location = New System.Drawing.Point(14, 45)
        Me.Lbl_ComisurasRasgos.Name = "Lbl_ComisurasRasgos"
        Me.Lbl_ComisurasRasgos.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_ComisurasRasgos.TabIndex = 2
        Me.Lbl_ComisurasRasgos.Text = "Comisuras"
        '
        'gbx_Menton
        '
        Me.gbx_Menton.Controls.Add(Me.Lbl_FormRasgos)
        Me.gbx_Menton.Controls.Add(Me.Lbl_InclinacionRasgos)
        Me.gbx_Menton.Controls.Add(Me.cmb_InclinacionMenton)
        Me.gbx_Menton.Controls.Add(Me.cmb_FormaMenton)
        Me.gbx_Menton.Controls.Add(Me.cmb_TipoMenton)
        Me.gbx_Menton.Controls.Add(Me.Lbl_TipoRasgos)
        Me.gbx_Menton.Location = New System.Drawing.Point(518, 108)
        Me.gbx_Menton.Name = "gbx_Menton"
        Me.gbx_Menton.Size = New System.Drawing.Size(250, 96)
        Me.gbx_Menton.TabIndex = 8
        Me.gbx_Menton.TabStop = False
        Me.gbx_Menton.Text = "Mentón"
        '
        'Lbl_FormRasgos
        '
        Me.Lbl_FormRasgos.AutoSize = True
        Me.Lbl_FormRasgos.Location = New System.Drawing.Point(40, 46)
        Me.Lbl_FormRasgos.Name = "Lbl_FormRasgos"
        Me.Lbl_FormRasgos.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_FormRasgos.TabIndex = 2
        Me.Lbl_FormRasgos.Text = "Forma"
        '
        'Lbl_InclinacionRasgos
        '
        Me.Lbl_InclinacionRasgos.AutoSize = True
        Me.Lbl_InclinacionRasgos.Location = New System.Drawing.Point(21, 70)
        Me.Lbl_InclinacionRasgos.Name = "Lbl_InclinacionRasgos"
        Me.Lbl_InclinacionRasgos.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_InclinacionRasgos.TabIndex = 4
        Me.Lbl_InclinacionRasgos.Text = "Inclinación"
        '
        'cmb_InclinacionMenton
        '
        Me.cmb_InclinacionMenton.Control_Siguiente = Nothing
        Me.cmb_InclinacionMenton.DisplayMember = "display"
        Me.cmb_InclinacionMenton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_InclinacionMenton.FormattingEnabled = True
        Me.cmb_InclinacionMenton.Location = New System.Drawing.Point(81, 67)
        Me.cmb_InclinacionMenton.MaxDropDownItems = 20
        Me.cmb_InclinacionMenton.Name = "cmb_InclinacionMenton"
        Me.cmb_InclinacionMenton.Size = New System.Drawing.Size(145, 21)
        Me.cmb_InclinacionMenton.TabIndex = 5
        Me.cmb_InclinacionMenton.ValueMember = "value"
        '
        'cmb_FormaMenton
        '
        Me.cmb_FormaMenton.Control_Siguiente = Nothing
        Me.cmb_FormaMenton.DisplayMember = "display"
        Me.cmb_FormaMenton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaMenton.FormattingEnabled = True
        Me.cmb_FormaMenton.Location = New System.Drawing.Point(81, 43)
        Me.cmb_FormaMenton.MaxDropDownItems = 20
        Me.cmb_FormaMenton.Name = "cmb_FormaMenton"
        Me.cmb_FormaMenton.Size = New System.Drawing.Size(145, 21)
        Me.cmb_FormaMenton.TabIndex = 3
        Me.cmb_FormaMenton.ValueMember = "value"
        '
        'cmb_TipoMenton
        '
        Me.cmb_TipoMenton.Control_Siguiente = Nothing
        Me.cmb_TipoMenton.DisplayMember = "display"
        Me.cmb_TipoMenton.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoMenton.FormattingEnabled = True
        Me.cmb_TipoMenton.Location = New System.Drawing.Point(81, 19)
        Me.cmb_TipoMenton.MaxDropDownItems = 20
        Me.cmb_TipoMenton.Name = "cmb_TipoMenton"
        Me.cmb_TipoMenton.Size = New System.Drawing.Size(145, 21)
        Me.cmb_TipoMenton.TabIndex = 1
        Me.cmb_TipoMenton.ValueMember = "value"
        '
        'Lbl_TipoRasgos
        '
        Me.Lbl_TipoRasgos.AutoSize = True
        Me.Lbl_TipoRasgos.Location = New System.Drawing.Point(48, 22)
        Me.Lbl_TipoRasgos.Name = "Lbl_TipoRasgos"
        Me.Lbl_TipoRasgos.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_TipoRasgos.TabIndex = 0
        Me.Lbl_TipoRasgos.Text = "Tipo"
        '
        'gbx_Labios
        '
        Me.gbx_Labios.Controls.Add(Me.cmb_ProminenciaLabios)
        Me.gbx_Labios.Controls.Add(Me.cmb_AlturaNasoLabial)
        Me.gbx_Labios.Controls.Add(Me.cmb_EspesorLabios)
        Me.gbx_Labios.Controls.Add(Me.Lbl_AlturaNasoLab)
        Me.gbx_Labios.Controls.Add(Me.Lbl_ProminenciaRasgos)
        Me.gbx_Labios.Controls.Add(Me.Lbl_EspesorRasgos)
        Me.gbx_Labios.Location = New System.Drawing.Point(262, 426)
        Me.gbx_Labios.Name = "gbx_Labios"
        Me.gbx_Labios.Size = New System.Drawing.Size(250, 98)
        Me.gbx_Labios.TabIndex = 7
        Me.gbx_Labios.TabStop = False
        Me.gbx_Labios.Text = "Labios"
        '
        'cmb_ProminenciaLabios
        '
        Me.cmb_ProminenciaLabios.Control_Siguiente = Nothing
        Me.cmb_ProminenciaLabios.DisplayMember = "display"
        Me.cmb_ProminenciaLabios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ProminenciaLabios.FormattingEnabled = True
        Me.cmb_ProminenciaLabios.Location = New System.Drawing.Point(74, 72)
        Me.cmb_ProminenciaLabios.MaxDropDownItems = 20
        Me.cmb_ProminenciaLabios.Name = "cmb_ProminenciaLabios"
        Me.cmb_ProminenciaLabios.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ProminenciaLabios.TabIndex = 5
        Me.cmb_ProminenciaLabios.ValueMember = "value"
        '
        'cmb_AlturaNasoLabial
        '
        Me.cmb_AlturaNasoLabial.Control_Siguiente = Nothing
        Me.cmb_AlturaNasoLabial.DisplayMember = "display"
        Me.cmb_AlturaNasoLabial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AlturaNasoLabial.FormattingEnabled = True
        Me.cmb_AlturaNasoLabial.Location = New System.Drawing.Point(74, 48)
        Me.cmb_AlturaNasoLabial.MaxDropDownItems = 20
        Me.cmb_AlturaNasoLabial.Name = "cmb_AlturaNasoLabial"
        Me.cmb_AlturaNasoLabial.Size = New System.Drawing.Size(146, 21)
        Me.cmb_AlturaNasoLabial.TabIndex = 3
        Me.cmb_AlturaNasoLabial.ValueMember = "value"
        '
        'cmb_EspesorLabios
        '
        Me.cmb_EspesorLabios.Control_Siguiente = Nothing
        Me.cmb_EspesorLabios.DisplayMember = "display"
        Me.cmb_EspesorLabios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EspesorLabios.FormattingEnabled = True
        Me.cmb_EspesorLabios.Location = New System.Drawing.Point(74, 18)
        Me.cmb_EspesorLabios.MaxDropDownItems = 20
        Me.cmb_EspesorLabios.Name = "cmb_EspesorLabios"
        Me.cmb_EspesorLabios.Size = New System.Drawing.Size(146, 21)
        Me.cmb_EspesorLabios.TabIndex = 1
        Me.cmb_EspesorLabios.ValueMember = "value"
        '
        'Lbl_AlturaNasoLab
        '
        Me.Lbl_AlturaNasoLab.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_AlturaNasoLab.Name = "Lbl_AlturaNasoLab"
        Me.Lbl_AlturaNasoLab.Size = New System.Drawing.Size(66, 32)
        Me.Lbl_AlturaNasoLab.TabIndex = 2
        Me.Lbl_AlturaNasoLab.Text = "Altura Naso-Labial"
        '
        'Lbl_ProminenciaRasgos
        '
        Me.Lbl_ProminenciaRasgos.AutoSize = True
        Me.Lbl_ProminenciaRasgos.Location = New System.Drawing.Point(6, 75)
        Me.Lbl_ProminenciaRasgos.Name = "Lbl_ProminenciaRasgos"
        Me.Lbl_ProminenciaRasgos.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_ProminenciaRasgos.TabIndex = 4
        Me.Lbl_ProminenciaRasgos.Text = "Prominencia"
        '
        'Lbl_EspesorRasgos
        '
        Me.Lbl_EspesorRasgos.AutoSize = True
        Me.Lbl_EspesorRasgos.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_EspesorRasgos.Name = "Lbl_EspesorRasgos"
        Me.Lbl_EspesorRasgos.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_EspesorRasgos.TabIndex = 0
        Me.Lbl_EspesorRasgos.Text = "Espesor"
        '
        'gbx_Ojos
        '
        Me.gbx_Ojos.Controls.Add(Me.cmb_ColorOjos)
        Me.gbx_Ojos.Controls.Add(Me.Lbl_ForRasgos)
        Me.gbx_Ojos.Controls.Add(Me.Lbl_TamRasgos)
        Me.gbx_Ojos.Controls.Add(Me.cmb_TamañoOjos)
        Me.gbx_Ojos.Controls.Add(Me.cmb_FormaOjos)
        Me.gbx_Ojos.Controls.Add(Me.Lbl_ColRasgos)
        Me.gbx_Ojos.Location = New System.Drawing.Point(262, 108)
        Me.gbx_Ojos.Name = "gbx_Ojos"
        Me.gbx_Ojos.Size = New System.Drawing.Size(250, 96)
        Me.gbx_Ojos.TabIndex = 4
        Me.gbx_Ojos.TabStop = False
        Me.gbx_Ojos.Text = "Ojos"
        '
        'cmb_ColorOjos
        '
        Me.cmb_ColorOjos.Clave = Nothing
        Me.cmb_ColorOjos.Control_Siguiente = Nothing
        Me.cmb_ColorOjos.DisplayMember = "Descripcion"
        Me.cmb_ColorOjos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorOjos.Empresa = False
        Me.cmb_ColorOjos.Filtro = Nothing
        Me.cmb_ColorOjos.FormattingEnabled = True
        Me.cmb_ColorOjos.Location = New System.Drawing.Point(75, 19)
        Me.cmb_ColorOjos.MaxDropDownItems = 20
        Me.cmb_ColorOjos.Name = "cmb_ColorOjos"
        Me.cmb_ColorOjos.Pista = False
        Me.cmb_ColorOjos.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ColorOjos.StoredProcedure = "Cat_ColorOjosCombo_Get"
        Me.cmb_ColorOjos.Sucursal = False
        Me.cmb_ColorOjos.TabIndex = 25
        Me.cmb_ColorOjos.Tipo = 0
        Me.cmb_ColorOjos.ValueMember = "Id_ColorOjos"
        '
        'Lbl_ForRasgos
        '
        Me.Lbl_ForRasgos.AutoSize = True
        Me.Lbl_ForRasgos.Location = New System.Drawing.Point(32, 46)
        Me.Lbl_ForRasgos.Name = "Lbl_ForRasgos"
        Me.Lbl_ForRasgos.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_ForRasgos.TabIndex = 2
        Me.Lbl_ForRasgos.Text = "Forma"
        '
        'Lbl_TamRasgos
        '
        Me.Lbl_TamRasgos.AutoSize = True
        Me.Lbl_TamRasgos.Location = New System.Drawing.Point(22, 70)
        Me.Lbl_TamRasgos.Name = "Lbl_TamRasgos"
        Me.Lbl_TamRasgos.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_TamRasgos.TabIndex = 4
        Me.Lbl_TamRasgos.Text = "Tamaño"
        '
        'cmb_TamañoOjos
        '
        Me.cmb_TamañoOjos.Control_Siguiente = Nothing
        Me.cmb_TamañoOjos.DisplayMember = "display"
        Me.cmb_TamañoOjos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TamañoOjos.FormattingEnabled = True
        Me.cmb_TamañoOjos.Location = New System.Drawing.Point(74, 67)
        Me.cmb_TamañoOjos.MaxDropDownItems = 20
        Me.cmb_TamañoOjos.Name = "cmb_TamañoOjos"
        Me.cmb_TamañoOjos.Size = New System.Drawing.Size(146, 21)
        Me.cmb_TamañoOjos.TabIndex = 5
        Me.cmb_TamañoOjos.ValueMember = "value"
        '
        'cmb_FormaOjos
        '
        Me.cmb_FormaOjos.Control_Siguiente = Nothing
        Me.cmb_FormaOjos.DisplayMember = "display"
        Me.cmb_FormaOjos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaOjos.FormattingEnabled = True
        Me.cmb_FormaOjos.Location = New System.Drawing.Point(74, 43)
        Me.cmb_FormaOjos.MaxDropDownItems = 20
        Me.cmb_FormaOjos.Name = "cmb_FormaOjos"
        Me.cmb_FormaOjos.Size = New System.Drawing.Size(146, 21)
        Me.cmb_FormaOjos.TabIndex = 3
        Me.cmb_FormaOjos.ValueMember = "value"
        '
        'Lbl_ColRasgos
        '
        Me.Lbl_ColRasgos.AutoSize = True
        Me.Lbl_ColRasgos.Location = New System.Drawing.Point(37, 22)
        Me.Lbl_ColRasgos.Name = "Lbl_ColRasgos"
        Me.Lbl_ColRasgos.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_ColRasgos.TabIndex = 0
        Me.Lbl_ColRasgos.Text = "Color"
        '
        'gbx_Cejas
        '
        Me.gbx_Cejas.Controls.Add(Me.cmb_TamañoCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_FormaCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_ImplantacionCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_DireccionCejas)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_Tamaño)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_ImplanRasgos)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_FRasgos)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_DireccionRasgos)
        Me.gbx_Cejas.Location = New System.Drawing.Point(6, 390)
        Me.gbx_Cejas.Name = "gbx_Cejas"
        Me.gbx_Cejas.Size = New System.Drawing.Size(250, 134)
        Me.gbx_Cejas.TabIndex = 3
        Me.gbx_Cejas.TabStop = False
        Me.gbx_Cejas.Text = "Cejas"
        '
        'cmb_TamañoCejas
        '
        Me.cmb_TamañoCejas.Control_Siguiente = Nothing
        Me.cmb_TamañoCejas.DisplayMember = "display"
        Me.cmb_TamañoCejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TamañoCejas.FormattingEnabled = True
        Me.cmb_TamañoCejas.Location = New System.Drawing.Point(81, 98)
        Me.cmb_TamañoCejas.MaxDropDownItems = 20
        Me.cmb_TamañoCejas.Name = "cmb_TamañoCejas"
        Me.cmb_TamañoCejas.Size = New System.Drawing.Size(146, 21)
        Me.cmb_TamañoCejas.TabIndex = 7
        Me.cmb_TamañoCejas.ValueMember = "value"
        '
        'cmb_FormaCejas
        '
        Me.cmb_FormaCejas.Control_Siguiente = Me.cmb_TamañoCejas
        Me.cmb_FormaCejas.DisplayMember = "display"
        Me.cmb_FormaCejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaCejas.FormattingEnabled = True
        Me.cmb_FormaCejas.Location = New System.Drawing.Point(81, 74)
        Me.cmb_FormaCejas.MaxDropDownItems = 20
        Me.cmb_FormaCejas.Name = "cmb_FormaCejas"
        Me.cmb_FormaCejas.Size = New System.Drawing.Size(146, 21)
        Me.cmb_FormaCejas.TabIndex = 5
        Me.cmb_FormaCejas.ValueMember = "value"
        '
        'cmb_ImplantacionCejas
        '
        Me.cmb_ImplantacionCejas.Control_Siguiente = Me.cmb_FormaCejas
        Me.cmb_ImplantacionCejas.DisplayMember = "display"
        Me.cmb_ImplantacionCejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ImplantacionCejas.FormattingEnabled = True
        Me.cmb_ImplantacionCejas.Location = New System.Drawing.Point(81, 50)
        Me.cmb_ImplantacionCejas.MaxDropDownItems = 20
        Me.cmb_ImplantacionCejas.Name = "cmb_ImplantacionCejas"
        Me.cmb_ImplantacionCejas.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ImplantacionCejas.TabIndex = 3
        Me.cmb_ImplantacionCejas.ValueMember = "value"
        '
        'cmb_DireccionCejas
        '
        Me.cmb_DireccionCejas.Control_Siguiente = Me.cmb_ImplantacionCejas
        Me.cmb_DireccionCejas.DisplayMember = "display"
        Me.cmb_DireccionCejas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DireccionCejas.FormattingEnabled = True
        Me.cmb_DireccionCejas.Location = New System.Drawing.Point(81, 26)
        Me.cmb_DireccionCejas.MaxDropDownItems = 20
        Me.cmb_DireccionCejas.Name = "cmb_DireccionCejas"
        Me.cmb_DireccionCejas.Size = New System.Drawing.Size(146, 21)
        Me.cmb_DireccionCejas.TabIndex = 1
        Me.cmb_DireccionCejas.ValueMember = "value"
        '
        'Lbl_Tamaño
        '
        Me.Lbl_Tamaño.AutoSize = True
        Me.Lbl_Tamaño.Location = New System.Drawing.Point(29, 101)
        Me.Lbl_Tamaño.Name = "Lbl_Tamaño"
        Me.Lbl_Tamaño.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_Tamaño.TabIndex = 6
        Me.Lbl_Tamaño.Text = "Tamaño"
        '
        'Lbl_ImplanRasgos
        '
        Me.Lbl_ImplanRasgos.AutoSize = True
        Me.Lbl_ImplanRasgos.Location = New System.Drawing.Point(8, 53)
        Me.Lbl_ImplanRasgos.Name = "Lbl_ImplanRasgos"
        Me.Lbl_ImplanRasgos.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_ImplanRasgos.TabIndex = 2
        Me.Lbl_ImplanRasgos.Text = "Implantación"
        '
        'Lbl_FRasgos
        '
        Me.Lbl_FRasgos.AutoSize = True
        Me.Lbl_FRasgos.Location = New System.Drawing.Point(39, 77)
        Me.Lbl_FRasgos.Name = "Lbl_FRasgos"
        Me.Lbl_FRasgos.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_FRasgos.TabIndex = 4
        Me.Lbl_FRasgos.Text = "Forma"
        '
        'Lbl_DireccionRasgos
        '
        Me.Lbl_DireccionRasgos.AutoSize = True
        Me.Lbl_DireccionRasgos.Location = New System.Drawing.Point(23, 29)
        Me.Lbl_DireccionRasgos.Name = "Lbl_DireccionRasgos"
        Me.Lbl_DireccionRasgos.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_DireccionRasgos.TabIndex = 0
        Me.Lbl_DireccionRasgos.Text = "Dirección"
        '
        'gbx_Frente
        '
        Me.gbx_Frente.Controls.Add(Me.cmb_AnchoFrente)
        Me.gbx_Frente.Controls.Add(Me.cmb_InclinacionFrente)
        Me.gbx_Frente.Controls.Add(Me.cmb_AlturaFrente)
        Me.gbx_Frente.Controls.Add(Me.Lbl_InclinRasgos)
        Me.gbx_Frente.Controls.Add(Me.Lbl_AnchRasgos)
        Me.gbx_Frente.Controls.Add(Me.Lbl_AltRasgos)
        Me.gbx_Frente.Location = New System.Drawing.Point(6, 269)
        Me.gbx_Frente.Name = "gbx_Frente"
        Me.gbx_Frente.Size = New System.Drawing.Size(250, 115)
        Me.gbx_Frente.TabIndex = 2
        Me.gbx_Frente.TabStop = False
        Me.gbx_Frente.Text = "Frente"
        '
        'cmb_AnchoFrente
        '
        Me.cmb_AnchoFrente.Control_Siguiente = Me.cmb_DireccionCejas
        Me.cmb_AnchoFrente.DisplayMember = "display"
        Me.cmb_AnchoFrente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AnchoFrente.FormattingEnabled = True
        Me.cmb_AnchoFrente.Location = New System.Drawing.Point(81, 72)
        Me.cmb_AnchoFrente.MaxDropDownItems = 20
        Me.cmb_AnchoFrente.Name = "cmb_AnchoFrente"
        Me.cmb_AnchoFrente.Size = New System.Drawing.Size(146, 21)
        Me.cmb_AnchoFrente.TabIndex = 5
        Me.cmb_AnchoFrente.ValueMember = "value"
        '
        'cmb_InclinacionFrente
        '
        Me.cmb_InclinacionFrente.Control_Siguiente = Me.cmb_AnchoFrente
        Me.cmb_InclinacionFrente.DisplayMember = "display"
        Me.cmb_InclinacionFrente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_InclinacionFrente.FormattingEnabled = True
        Me.cmb_InclinacionFrente.Location = New System.Drawing.Point(81, 48)
        Me.cmb_InclinacionFrente.MaxDropDownItems = 20
        Me.cmb_InclinacionFrente.Name = "cmb_InclinacionFrente"
        Me.cmb_InclinacionFrente.Size = New System.Drawing.Size(146, 21)
        Me.cmb_InclinacionFrente.TabIndex = 3
        Me.cmb_InclinacionFrente.ValueMember = "value"
        '
        'cmb_AlturaFrente
        '
        Me.cmb_AlturaFrente.Control_Siguiente = Me.cmb_InclinacionFrente
        Me.cmb_AlturaFrente.DisplayMember = "display"
        Me.cmb_AlturaFrente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AlturaFrente.FormattingEnabled = True
        Me.cmb_AlturaFrente.Location = New System.Drawing.Point(81, 24)
        Me.cmb_AlturaFrente.MaxDropDownItems = 20
        Me.cmb_AlturaFrente.Name = "cmb_AlturaFrente"
        Me.cmb_AlturaFrente.Size = New System.Drawing.Size(146, 21)
        Me.cmb_AlturaFrente.TabIndex = 1
        Me.cmb_AlturaFrente.ValueMember = "value"
        '
        'Lbl_InclinRasgos
        '
        Me.Lbl_InclinRasgos.AutoSize = True
        Me.Lbl_InclinRasgos.Location = New System.Drawing.Point(17, 51)
        Me.Lbl_InclinRasgos.Name = "Lbl_InclinRasgos"
        Me.Lbl_InclinRasgos.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_InclinRasgos.TabIndex = 2
        Me.Lbl_InclinRasgos.Text = "Inclinación"
        '
        'Lbl_AnchRasgos
        '
        Me.Lbl_AnchRasgos.AutoSize = True
        Me.Lbl_AnchRasgos.Location = New System.Drawing.Point(37, 75)
        Me.Lbl_AnchRasgos.Name = "Lbl_AnchRasgos"
        Me.Lbl_AnchRasgos.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_AnchRasgos.TabIndex = 4
        Me.Lbl_AnchRasgos.Text = "Ancho"
        '
        'Lbl_AltRasgos
        '
        Me.Lbl_AltRasgos.AutoSize = True
        Me.Lbl_AltRasgos.Location = New System.Drawing.Point(41, 27)
        Me.Lbl_AltRasgos.Name = "Lbl_AltRasgos"
        Me.Lbl_AltRasgos.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_AltRasgos.TabIndex = 0
        Me.Lbl_AltRasgos.Text = "Altura"
        '
        'gbx_Nariz
        '
        Me.gbx_Nariz.Controls.Add(Me.cmb_AlturaNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_BaseNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_AnchoNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_DorsoNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_RaizNariz)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_AlturaRasgos)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_BaseRasgos)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_DorsoRasgos)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_AnchoRasgos)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RaizRasgos)
        Me.gbx_Nariz.Location = New System.Drawing.Point(262, 207)
        Me.gbx_Nariz.Name = "gbx_Nariz"
        Me.gbx_Nariz.Size = New System.Drawing.Size(250, 144)
        Me.gbx_Nariz.TabIndex = 5
        Me.gbx_Nariz.TabStop = False
        Me.gbx_Nariz.Text = "Nariz"
        '
        'cmb_AlturaNariz
        '
        Me.cmb_AlturaNariz.Control_Siguiente = Nothing
        Me.cmb_AlturaNariz.DisplayMember = "display"
        Me.cmb_AlturaNariz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AlturaNariz.FormattingEnabled = True
        Me.cmb_AlturaNariz.Location = New System.Drawing.Point(74, 115)
        Me.cmb_AlturaNariz.MaxDropDownItems = 20
        Me.cmb_AlturaNariz.Name = "cmb_AlturaNariz"
        Me.cmb_AlturaNariz.Size = New System.Drawing.Size(146, 21)
        Me.cmb_AlturaNariz.TabIndex = 9
        Me.cmb_AlturaNariz.ValueMember = "value"
        '
        'cmb_BaseNariz
        '
        Me.cmb_BaseNariz.Control_Siguiente = Nothing
        Me.cmb_BaseNariz.DisplayMember = "display"
        Me.cmb_BaseNariz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_BaseNariz.FormattingEnabled = True
        Me.cmb_BaseNariz.Location = New System.Drawing.Point(74, 91)
        Me.cmb_BaseNariz.MaxDropDownItems = 20
        Me.cmb_BaseNariz.Name = "cmb_BaseNariz"
        Me.cmb_BaseNariz.Size = New System.Drawing.Size(146, 21)
        Me.cmb_BaseNariz.TabIndex = 7
        Me.cmb_BaseNariz.ValueMember = "value"
        '
        'cmb_AnchoNariz
        '
        Me.cmb_AnchoNariz.Control_Siguiente = Nothing
        Me.cmb_AnchoNariz.DisplayMember = "display"
        Me.cmb_AnchoNariz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AnchoNariz.FormattingEnabled = True
        Me.cmb_AnchoNariz.Location = New System.Drawing.Point(74, 67)
        Me.cmb_AnchoNariz.MaxDropDownItems = 20
        Me.cmb_AnchoNariz.Name = "cmb_AnchoNariz"
        Me.cmb_AnchoNariz.Size = New System.Drawing.Size(146, 21)
        Me.cmb_AnchoNariz.TabIndex = 5
        Me.cmb_AnchoNariz.ValueMember = "value"
        '
        'cmb_DorsoNariz
        '
        Me.cmb_DorsoNariz.Control_Siguiente = Nothing
        Me.cmb_DorsoNariz.DisplayMember = "display"
        Me.cmb_DorsoNariz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DorsoNariz.FormattingEnabled = True
        Me.cmb_DorsoNariz.Location = New System.Drawing.Point(74, 43)
        Me.cmb_DorsoNariz.MaxDropDownItems = 20
        Me.cmb_DorsoNariz.Name = "cmb_DorsoNariz"
        Me.cmb_DorsoNariz.Size = New System.Drawing.Size(146, 21)
        Me.cmb_DorsoNariz.TabIndex = 3
        Me.cmb_DorsoNariz.ValueMember = "value"
        '
        'cmb_RaizNariz
        '
        Me.cmb_RaizNariz.Control_Siguiente = Nothing
        Me.cmb_RaizNariz.DisplayMember = "display"
        Me.cmb_RaizNariz.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RaizNariz.FormattingEnabled = True
        Me.cmb_RaizNariz.Location = New System.Drawing.Point(74, 19)
        Me.cmb_RaizNariz.MaxDropDownItems = 20
        Me.cmb_RaizNariz.Name = "cmb_RaizNariz"
        Me.cmb_RaizNariz.Size = New System.Drawing.Size(146, 21)
        Me.cmb_RaizNariz.TabIndex = 1
        Me.cmb_RaizNariz.ValueMember = "value"
        '
        'Lbl_AlturaRasgos
        '
        Me.Lbl_AlturaRasgos.AutoSize = True
        Me.Lbl_AlturaRasgos.Location = New System.Drawing.Point(34, 118)
        Me.Lbl_AlturaRasgos.Name = "Lbl_AlturaRasgos"
        Me.Lbl_AlturaRasgos.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_AlturaRasgos.TabIndex = 8
        Me.Lbl_AlturaRasgos.Text = "Altura"
        '
        'Lbl_BaseRasgos
        '
        Me.Lbl_BaseRasgos.AutoSize = True
        Me.Lbl_BaseRasgos.Location = New System.Drawing.Point(37, 94)
        Me.Lbl_BaseRasgos.Name = "Lbl_BaseRasgos"
        Me.Lbl_BaseRasgos.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_BaseRasgos.TabIndex = 6
        Me.Lbl_BaseRasgos.Text = "Base"
        '
        'Lbl_DorsoRasgos
        '
        Me.Lbl_DorsoRasgos.AutoSize = True
        Me.Lbl_DorsoRasgos.Location = New System.Drawing.Point(33, 46)
        Me.Lbl_DorsoRasgos.Name = "Lbl_DorsoRasgos"
        Me.Lbl_DorsoRasgos.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_DorsoRasgos.TabIndex = 2
        Me.Lbl_DorsoRasgos.Text = "Dorso"
        '
        'Lbl_AnchoRasgos
        '
        Me.Lbl_AnchoRasgos.AutoSize = True
        Me.Lbl_AnchoRasgos.Location = New System.Drawing.Point(30, 70)
        Me.Lbl_AnchoRasgos.Name = "Lbl_AnchoRasgos"
        Me.Lbl_AnchoRasgos.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_AnchoRasgos.TabIndex = 4
        Me.Lbl_AnchoRasgos.Text = "Ancho"
        '
        'Lbl_RaizRasgos
        '
        Me.Lbl_RaizRasgos.AutoSize = True
        Me.Lbl_RaizRasgos.Location = New System.Drawing.Point(38, 22)
        Me.Lbl_RaizRasgos.Name = "Lbl_RaizRasgos"
        Me.Lbl_RaizRasgos.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_RaizRasgos.TabIndex = 0
        Me.Lbl_RaizRasgos.Text = "Raíz"
        '
        'gbx_Oreja
        '
        Me.gbx_Oreja.Controls.Add(Me.gbx_Lobulo)
        Me.gbx_Oreja.Controls.Add(Me.gbx_Helix)
        Me.gbx_Oreja.Controls.Add(Me.cmb_OriginalOreja)
        Me.gbx_Oreja.Controls.Add(Me.cmb_FormaOreja)
        Me.gbx_Oreja.Controls.Add(Me.Lbl_OriginalRasgos)
        Me.gbx_Oreja.Controls.Add(Me.Lbl_FormaRas)
        Me.gbx_Oreja.Location = New System.Drawing.Point(518, 207)
        Me.gbx_Oreja.Name = "gbx_Oreja"
        Me.gbx_Oreja.Size = New System.Drawing.Size(250, 317)
        Me.gbx_Oreja.TabIndex = 9
        Me.gbx_Oreja.TabStop = False
        Me.gbx_Oreja.Text = "Oreja Derecha"
        '
        'gbx_Lobulo
        '
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloDimension)
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloParticularidad)
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloAdherencia)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_ParticularidadRasgos)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_AdheRasgos)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_DimensionRasgos)
        Me.gbx_Lobulo.Location = New System.Drawing.Point(0, 205)
        Me.gbx_Lobulo.Name = "gbx_Lobulo"
        Me.gbx_Lobulo.Size = New System.Drawing.Size(250, 117)
        Me.gbx_Lobulo.TabIndex = 5
        Me.gbx_Lobulo.TabStop = False
        Me.gbx_Lobulo.Text = "Lóbulo"
        '
        'cmb_LobuloDimension
        '
        Me.cmb_LobuloDimension.Control_Siguiente = Nothing
        Me.cmb_LobuloDimension.DisplayMember = "display"
        Me.cmb_LobuloDimension.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LobuloDimension.FormattingEnabled = True
        Me.cmb_LobuloDimension.Location = New System.Drawing.Point(81, 80)
        Me.cmb_LobuloDimension.MaxDropDownItems = 20
        Me.cmb_LobuloDimension.Name = "cmb_LobuloDimension"
        Me.cmb_LobuloDimension.Size = New System.Drawing.Size(145, 21)
        Me.cmb_LobuloDimension.TabIndex = 5
        Me.cmb_LobuloDimension.ValueMember = "value"
        '
        'cmb_LobuloParticularidad
        '
        Me.cmb_LobuloParticularidad.Control_Siguiente = Nothing
        Me.cmb_LobuloParticularidad.DisplayMember = "display"
        Me.cmb_LobuloParticularidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LobuloParticularidad.FormattingEnabled = True
        Me.cmb_LobuloParticularidad.Location = New System.Drawing.Point(81, 56)
        Me.cmb_LobuloParticularidad.MaxDropDownItems = 20
        Me.cmb_LobuloParticularidad.Name = "cmb_LobuloParticularidad"
        Me.cmb_LobuloParticularidad.Size = New System.Drawing.Size(145, 21)
        Me.cmb_LobuloParticularidad.TabIndex = 3
        Me.cmb_LobuloParticularidad.ValueMember = "value"
        '
        'cmb_LobuloAdherencia
        '
        Me.cmb_LobuloAdherencia.Control_Siguiente = Nothing
        Me.cmb_LobuloAdherencia.DisplayMember = "display"
        Me.cmb_LobuloAdherencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_LobuloAdherencia.FormattingEnabled = True
        Me.cmb_LobuloAdherencia.Location = New System.Drawing.Point(81, 32)
        Me.cmb_LobuloAdherencia.MaxDropDownItems = 20
        Me.cmb_LobuloAdherencia.Name = "cmb_LobuloAdherencia"
        Me.cmb_LobuloAdherencia.Size = New System.Drawing.Size(145, 21)
        Me.cmb_LobuloAdherencia.TabIndex = 1
        Me.cmb_LobuloAdherencia.ValueMember = "value"
        '
        'Lbl_ParticularidadRasgos
        '
        Me.Lbl_ParticularidadRasgos.AutoSize = True
        Me.Lbl_ParticularidadRasgos.Location = New System.Drawing.Point(6, 59)
        Me.Lbl_ParticularidadRasgos.Name = "Lbl_ParticularidadRasgos"
        Me.Lbl_ParticularidadRasgos.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_ParticularidadRasgos.TabIndex = 2
        Me.Lbl_ParticularidadRasgos.Text = "Particularidad"
        '
        'Lbl_AdheRasgos
        '
        Me.Lbl_AdheRasgos.AutoSize = True
        Me.Lbl_AdheRasgos.Location = New System.Drawing.Point(14, 35)
        Me.Lbl_AdheRasgos.Name = "Lbl_AdheRasgos"
        Me.Lbl_AdheRasgos.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_AdheRasgos.TabIndex = 0
        Me.Lbl_AdheRasgos.Text = "Adherencia"
        '
        'Lbl_DimensionRasgos
        '
        Me.Lbl_DimensionRasgos.AutoSize = True
        Me.Lbl_DimensionRasgos.Location = New System.Drawing.Point(19, 83)
        Me.Lbl_DimensionRasgos.Name = "Lbl_DimensionRasgos"
        Me.Lbl_DimensionRasgos.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_DimensionRasgos.TabIndex = 4
        Me.Lbl_DimensionRasgos.Text = "Dimensión"
        '
        'gbx_Helix
        '
        Me.gbx_Helix.Controls.Add(Me.Lbl_SuperiorRasgos)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixContorno)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixAdherencia)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixPosterior)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixSuperior)
        Me.gbx_Helix.Controls.Add(Me.Lbl_PosteriorRasgos)
        Me.gbx_Helix.Controls.Add(Me.Lbl_AdherenciaRasgos)
        Me.gbx_Helix.Controls.Add(Me.Lbl_ContornoRasgos)
        Me.gbx_Helix.Location = New System.Drawing.Point(0, 76)
        Me.gbx_Helix.Name = "gbx_Helix"
        Me.gbx_Helix.Size = New System.Drawing.Size(250, 135)
        Me.gbx_Helix.TabIndex = 4
        Me.gbx_Helix.TabStop = False
        Me.gbx_Helix.Text = "Hélix"
        '
        'Lbl_SuperiorRasgos
        '
        Me.Lbl_SuperiorRasgos.AutoSize = True
        Me.Lbl_SuperiorRasgos.Location = New System.Drawing.Point(29, 26)
        Me.Lbl_SuperiorRasgos.Name = "Lbl_SuperiorRasgos"
        Me.Lbl_SuperiorRasgos.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_SuperiorRasgos.TabIndex = 0
        Me.Lbl_SuperiorRasgos.Text = "Superior"
        '
        'cmb_HelixContorno
        '
        Me.cmb_HelixContorno.Control_Siguiente = Nothing
        Me.cmb_HelixContorno.DisplayMember = "display"
        Me.cmb_HelixContorno.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HelixContorno.FormattingEnabled = True
        Me.cmb_HelixContorno.Location = New System.Drawing.Point(81, 95)
        Me.cmb_HelixContorno.MaxDropDownItems = 20
        Me.cmb_HelixContorno.Name = "cmb_HelixContorno"
        Me.cmb_HelixContorno.Size = New System.Drawing.Size(145, 21)
        Me.cmb_HelixContorno.TabIndex = 7
        Me.cmb_HelixContorno.ValueMember = "value"
        '
        'cmb_HelixAdherencia
        '
        Me.cmb_HelixAdherencia.Control_Siguiente = Nothing
        Me.cmb_HelixAdherencia.DisplayMember = "display"
        Me.cmb_HelixAdherencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HelixAdherencia.FormattingEnabled = True
        Me.cmb_HelixAdherencia.Location = New System.Drawing.Point(81, 71)
        Me.cmb_HelixAdherencia.MaxDropDownItems = 20
        Me.cmb_HelixAdherencia.Name = "cmb_HelixAdherencia"
        Me.cmb_HelixAdherencia.Size = New System.Drawing.Size(145, 21)
        Me.cmb_HelixAdherencia.TabIndex = 5
        Me.cmb_HelixAdherencia.ValueMember = "value"
        '
        'cmb_HelixPosterior
        '
        Me.cmb_HelixPosterior.Control_Siguiente = Nothing
        Me.cmb_HelixPosterior.DisplayMember = "display"
        Me.cmb_HelixPosterior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HelixPosterior.FormattingEnabled = True
        Me.cmb_HelixPosterior.Location = New System.Drawing.Point(81, 47)
        Me.cmb_HelixPosterior.MaxDropDownItems = 20
        Me.cmb_HelixPosterior.Name = "cmb_HelixPosterior"
        Me.cmb_HelixPosterior.Size = New System.Drawing.Size(145, 21)
        Me.cmb_HelixPosterior.TabIndex = 3
        Me.cmb_HelixPosterior.ValueMember = "value"
        '
        'cmb_HelixSuperior
        '
        Me.cmb_HelixSuperior.Control_Siguiente = Nothing
        Me.cmb_HelixSuperior.DisplayMember = "display"
        Me.cmb_HelixSuperior.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_HelixSuperior.FormattingEnabled = True
        Me.cmb_HelixSuperior.Location = New System.Drawing.Point(81, 23)
        Me.cmb_HelixSuperior.MaxDropDownItems = 20
        Me.cmb_HelixSuperior.Name = "cmb_HelixSuperior"
        Me.cmb_HelixSuperior.Size = New System.Drawing.Size(145, 21)
        Me.cmb_HelixSuperior.TabIndex = 1
        Me.cmb_HelixSuperior.ValueMember = "value"
        '
        'Lbl_PosteriorRasgos
        '
        Me.Lbl_PosteriorRasgos.AutoSize = True
        Me.Lbl_PosteriorRasgos.Location = New System.Drawing.Point(27, 50)
        Me.Lbl_PosteriorRasgos.Name = "Lbl_PosteriorRasgos"
        Me.Lbl_PosteriorRasgos.Size = New System.Drawing.Size(48, 13)
        Me.Lbl_PosteriorRasgos.TabIndex = 2
        Me.Lbl_PosteriorRasgos.Text = "Posterior"
        '
        'Lbl_AdherenciaRasgos
        '
        Me.Lbl_AdherenciaRasgos.AutoSize = True
        Me.Lbl_AdherenciaRasgos.Location = New System.Drawing.Point(14, 74)
        Me.Lbl_AdherenciaRasgos.Name = "Lbl_AdherenciaRasgos"
        Me.Lbl_AdherenciaRasgos.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_AdherenciaRasgos.TabIndex = 4
        Me.Lbl_AdherenciaRasgos.Text = "Adherencia"
        '
        'Lbl_ContornoRasgos
        '
        Me.Lbl_ContornoRasgos.AutoSize = True
        Me.Lbl_ContornoRasgos.Location = New System.Drawing.Point(25, 98)
        Me.Lbl_ContornoRasgos.Name = "Lbl_ContornoRasgos"
        Me.Lbl_ContornoRasgos.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_ContornoRasgos.TabIndex = 6
        Me.Lbl_ContornoRasgos.Text = "Contorno"
        '
        'cmb_OriginalOreja
        '
        Me.cmb_OriginalOreja.Control_Siguiente = Nothing
        Me.cmb_OriginalOreja.DisplayMember = "display"
        Me.cmb_OriginalOreja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_OriginalOreja.FormattingEnabled = True
        Me.cmb_OriginalOreja.Location = New System.Drawing.Point(81, 43)
        Me.cmb_OriginalOreja.MaxDropDownItems = 20
        Me.cmb_OriginalOreja.Name = "cmb_OriginalOreja"
        Me.cmb_OriginalOreja.Size = New System.Drawing.Size(145, 21)
        Me.cmb_OriginalOreja.TabIndex = 3
        Me.cmb_OriginalOreja.ValueMember = "value"
        '
        'cmb_FormaOreja
        '
        Me.cmb_FormaOreja.Control_Siguiente = Nothing
        Me.cmb_FormaOreja.DisplayMember = "display"
        Me.cmb_FormaOreja.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaOreja.FormattingEnabled = True
        Me.cmb_FormaOreja.Location = New System.Drawing.Point(81, 19)
        Me.cmb_FormaOreja.MaxDropDownItems = 20
        Me.cmb_FormaOreja.Name = "cmb_FormaOreja"
        Me.cmb_FormaOreja.Size = New System.Drawing.Size(145, 21)
        Me.cmb_FormaOreja.TabIndex = 1
        Me.cmb_FormaOreja.ValueMember = "value"
        '
        'Lbl_OriginalRasgos
        '
        Me.Lbl_OriginalRasgos.AutoSize = True
        Me.Lbl_OriginalRasgos.Location = New System.Drawing.Point(31, 46)
        Me.Lbl_OriginalRasgos.Name = "Lbl_OriginalRasgos"
        Me.Lbl_OriginalRasgos.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_OriginalRasgos.TabIndex = 2
        Me.Lbl_OriginalRasgos.Text = "Original"
        '
        'Lbl_FormaRas
        '
        Me.Lbl_FormaRas.AutoSize = True
        Me.Lbl_FormaRas.Location = New System.Drawing.Point(39, 22)
        Me.Lbl_FormaRas.Name = "Lbl_FormaRas"
        Me.Lbl_FormaRas.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_FormaRas.TabIndex = 0
        Me.Lbl_FormaRas.Text = "Forma"
        '
        'gbx_Cabello
        '
        Me.gbx_Cabello.Controls.Add(Me.cmb_ColorCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_ImplantacionCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_Calvicie)
        Me.gbx_Cabello.Controls.Add(Me.cmb_FormaCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_CantidadCabello)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_ImplantacionRasgos)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_CalvicieRasgos)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_ColorRasgos)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_FormaRasgos)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_CantidadRasgos)
        Me.gbx_Cabello.Location = New System.Drawing.Point(6, 108)
        Me.gbx_Cabello.Name = "gbx_Cabello"
        Me.gbx_Cabello.Size = New System.Drawing.Size(250, 155)
        Me.gbx_Cabello.TabIndex = 1
        Me.gbx_Cabello.TabStop = False
        Me.gbx_Cabello.Text = "Cabello"
        '
        'cmb_ColorCabello
        '
        Me.cmb_ColorCabello.Clave = Nothing
        Me.cmb_ColorCabello.Control_Siguiente = Nothing
        Me.cmb_ColorCabello.DisplayMember = "Descripcion"
        Me.cmb_ColorCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorCabello.Empresa = False
        Me.cmb_ColorCabello.Filtro = Nothing
        Me.cmb_ColorCabello.FormattingEnabled = True
        Me.cmb_ColorCabello.Location = New System.Drawing.Point(81, 43)
        Me.cmb_ColorCabello.MaxDropDownItems = 20
        Me.cmb_ColorCabello.Name = "cmb_ColorCabello"
        Me.cmb_ColorCabello.Pista = False
        Me.cmb_ColorCabello.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ColorCabello.StoredProcedure = "Cat_ColorCabelloCombo_Get"
        Me.cmb_ColorCabello.Sucursal = False
        Me.cmb_ColorCabello.TabIndex = 24
        Me.cmb_ColorCabello.Tipo = 0
        Me.cmb_ColorCabello.ValueMember = "Id_ColorCabello"
        '
        'cmb_ImplantacionCabello
        '
        Me.cmb_ImplantacionCabello.Control_Siguiente = Me.cmb_AlturaFrente
        Me.cmb_ImplantacionCabello.DisplayMember = "display"
        Me.cmb_ImplantacionCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ImplantacionCabello.FormattingEnabled = True
        Me.cmb_ImplantacionCabello.Location = New System.Drawing.Point(81, 115)
        Me.cmb_ImplantacionCabello.MaxDropDownItems = 20
        Me.cmb_ImplantacionCabello.Name = "cmb_ImplantacionCabello"
        Me.cmb_ImplantacionCabello.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ImplantacionCabello.TabIndex = 9
        Me.cmb_ImplantacionCabello.ValueMember = "value"
        '
        'cmb_Calvicie
        '
        Me.cmb_Calvicie.Control_Siguiente = Me.cmb_ImplantacionCabello
        Me.cmb_Calvicie.DisplayMember = "display"
        Me.cmb_Calvicie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Calvicie.FormattingEnabled = True
        Me.cmb_Calvicie.Location = New System.Drawing.Point(81, 91)
        Me.cmb_Calvicie.MaxDropDownItems = 20
        Me.cmb_Calvicie.Name = "cmb_Calvicie"
        Me.cmb_Calvicie.Size = New System.Drawing.Size(146, 21)
        Me.cmb_Calvicie.TabIndex = 7
        Me.cmb_Calvicie.ValueMember = "value"
        '
        'cmb_FormaCabello
        '
        Me.cmb_FormaCabello.Control_Siguiente = Me.cmb_Calvicie
        Me.cmb_FormaCabello.DisplayMember = "display"
        Me.cmb_FormaCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_FormaCabello.FormattingEnabled = True
        Me.cmb_FormaCabello.Location = New System.Drawing.Point(81, 67)
        Me.cmb_FormaCabello.MaxDropDownItems = 20
        Me.cmb_FormaCabello.Name = "cmb_FormaCabello"
        Me.cmb_FormaCabello.Size = New System.Drawing.Size(146, 21)
        Me.cmb_FormaCabello.TabIndex = 5
        Me.cmb_FormaCabello.ValueMember = "value"
        '
        'cmb_CantidadCabello
        '
        Me.cmb_CantidadCabello.Control_Siguiente = Nothing
        Me.cmb_CantidadCabello.DisplayMember = "display"
        Me.cmb_CantidadCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CantidadCabello.FormattingEnabled = True
        Me.cmb_CantidadCabello.Location = New System.Drawing.Point(81, 19)
        Me.cmb_CantidadCabello.MaxDropDownItems = 20
        Me.cmb_CantidadCabello.Name = "cmb_CantidadCabello"
        Me.cmb_CantidadCabello.Size = New System.Drawing.Size(146, 21)
        Me.cmb_CantidadCabello.TabIndex = 1
        Me.cmb_CantidadCabello.ValueMember = "value"
        '
        'Lbl_ImplantacionRasgos
        '
        Me.Lbl_ImplantacionRasgos.AutoSize = True
        Me.Lbl_ImplantacionRasgos.Location = New System.Drawing.Point(8, 118)
        Me.Lbl_ImplantacionRasgos.Name = "Lbl_ImplantacionRasgos"
        Me.Lbl_ImplantacionRasgos.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_ImplantacionRasgos.TabIndex = 8
        Me.Lbl_ImplantacionRasgos.Text = "Implantación"
        '
        'Lbl_CalvicieRasgos
        '
        Me.Lbl_CalvicieRasgos.AutoSize = True
        Me.Lbl_CalvicieRasgos.Location = New System.Drawing.Point(31, 94)
        Me.Lbl_CalvicieRasgos.Name = "Lbl_CalvicieRasgos"
        Me.Lbl_CalvicieRasgos.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_CalvicieRasgos.TabIndex = 6
        Me.Lbl_CalvicieRasgos.Text = "Calvicie"
        '
        'Lbl_ColorRasgos
        '
        Me.Lbl_ColorRasgos.AutoSize = True
        Me.Lbl_ColorRasgos.Location = New System.Drawing.Point(44, 46)
        Me.Lbl_ColorRasgos.Name = "Lbl_ColorRasgos"
        Me.Lbl_ColorRasgos.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_ColorRasgos.TabIndex = 2
        Me.Lbl_ColorRasgos.Text = "Color"
        '
        'Lbl_FormaRasgos
        '
        Me.Lbl_FormaRasgos.AutoSize = True
        Me.Lbl_FormaRasgos.Location = New System.Drawing.Point(39, 70)
        Me.Lbl_FormaRasgos.Name = "Lbl_FormaRasgos"
        Me.Lbl_FormaRasgos.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_FormaRasgos.TabIndex = 4
        Me.Lbl_FormaRasgos.Text = "Forma"
        '
        'Lbl_CantidadRasgos
        '
        Me.Lbl_CantidadRasgos.AutoSize = True
        Me.Lbl_CantidadRasgos.Location = New System.Drawing.Point(26, 22)
        Me.Lbl_CantidadRasgos.Name = "Lbl_CantidadRasgos"
        Me.Lbl_CantidadRasgos.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_CantidadRasgos.TabIndex = 0
        Me.Lbl_CantidadRasgos.Text = "Cantidad"
        '
        'btn_CancelarRasgos
        '
        Me.btn_CancelarRasgos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarRasgos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarRasgos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarRasgos.Location = New System.Drawing.Point(628, 651)
        Me.btn_CancelarRasgos.Name = "btn_CancelarRasgos"
        Me.btn_CancelarRasgos.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarRasgos.TabIndex = 11
        Me.btn_CancelarRasgos.Text = "&Cancelar"
        Me.btn_CancelarRasgos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarRasgos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarRasgos.UseVisualStyleBackColor = True
        '
        'btn_GuardarRasgos
        '
        Me.btn_GuardarRasgos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_GuardarRasgos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_GuardarRasgos.Location = New System.Drawing.Point(7, 651)
        Me.btn_GuardarRasgos.Name = "btn_GuardarRasgos"
        Me.btn_GuardarRasgos.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarRasgos.TabIndex = 10
        Me.btn_GuardarRasgos.Text = "&Guardar"
        Me.btn_GuardarRasgos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarRasgos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarRasgos.UseVisualStyleBackColor = True
        '
        'tab_DatosEscolares
        '
        Me.tab_DatosEscolares.Controls.Add(Me.Label47)
        Me.tab_DatosEscolares.Controls.Add(Me.Label46)
        Me.tab_DatosEscolares.Controls.Add(Me.Label45)
        Me.tab_DatosEscolares.Controls.Add(Me.Label44)
        Me.tab_DatosEscolares.Controls.Add(Me.Label43)
        Me.tab_DatosEscolares.Controls.Add(Me.cmb_ATermino)
        Me.tab_DatosEscolares.Controls.Add(Me.cmb_AInicio)
        Me.tab_DatosEscolares.Controls.Add(Me.cmb_Documentacion)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Documentacion)
        Me.tab_DatosEscolares.Controls.Add(Me.gbx_CursosRecibidos)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_Promedio)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_CedulaProfesional)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_Folio)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_Especialidad)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_Carrera)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_CedulaProf)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Promedio)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Folio)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_ATermino)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_AInicio)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Carrera)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Especialidad)
        Me.tab_DatosEscolares.Controls.Add(Me.tbx_NombreEscuela)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_NombreEscuela)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_UltimosEstudios2)
        Me.tab_DatosEscolares.Controls.Add(Me.cmb_UltimosEstudios)
        Me.tab_DatosEscolares.Controls.Add(Me.lbl_Comprobable)
        Me.tab_DatosEscolares.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosEscolares.Name = "tab_DatosEscolares"
        Me.tab_DatosEscolares.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DatosEscolares.Size = New System.Drawing.Size(1523, 687)
        Me.tab_DatosEscolares.TabIndex = 1
        Me.tab_DatosEscolares.Text = "Datos Escolares"
        Me.tab_DatosEscolares.UseVisualStyleBackColor = True
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label47.ForeColor = System.Drawing.Color.Red
        Me.Label47.Location = New System.Drawing.Point(499, 167)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(13, 16)
        Me.Label47.TabIndex = 21
        Me.Label47.Text = "*"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label46.ForeColor = System.Drawing.Color.Red
        Me.Label46.Location = New System.Drawing.Point(259, 168)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(13, 16)
        Me.Label46.TabIndex = 18
        Me.Label46.Text = "*"
        '
        'Label45
        '
        Me.Label45.AutoSize = True
        Me.Label45.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label45.ForeColor = System.Drawing.Color.Red
        Me.Label45.Location = New System.Drawing.Point(498, 71)
        Me.Label45.Name = "Label45"
        Me.Label45.Size = New System.Drawing.Size(13, 16)
        Me.Label45.TabIndex = 9
        Me.Label45.Text = "*"
        '
        'Label44
        '
        Me.Label44.AutoSize = True
        Me.Label44.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label44.ForeColor = System.Drawing.Color.Red
        Me.Label44.Location = New System.Drawing.Point(376, 48)
        Me.Label44.Name = "Label44"
        Me.Label44.Size = New System.Drawing.Size(13, 16)
        Me.Label44.TabIndex = 6
        Me.Label44.Text = "*"
        '
        'Label43
        '
        Me.Label43.AutoSize = True
        Me.Label43.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label43.ForeColor = System.Drawing.Color.Red
        Me.Label43.Location = New System.Drawing.Point(457, 21)
        Me.Label43.Name = "Label43"
        Me.Label43.Size = New System.Drawing.Size(13, 16)
        Me.Label43.TabIndex = 3
        Me.Label43.Text = "*"
        '
        'cmb_ATermino
        '
        Me.cmb_ATermino.Control_Siguiente = Me.tbx_Folio
        Me.cmb_ATermino.DisplayMember = "display"
        Me.cmb_ATermino.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ATermino.FormattingEnabled = True
        Me.cmb_ATermino.Location = New System.Drawing.Point(382, 166)
        Me.cmb_ATermino.MaxDropDownItems = 20
        Me.cmb_ATermino.Name = "cmb_ATermino"
        Me.cmb_ATermino.Size = New System.Drawing.Size(111, 21)
        Me.cmb_ATermino.TabIndex = 8
        Me.cmb_ATermino.ValueMember = "value"
        '
        'tbx_Folio
        '
        Me.tbx_Folio.Control_Siguiente = Me.tbx_Promedio
        Me.tbx_Folio.Filtrado = True
        Me.tbx_Folio.Location = New System.Drawing.Point(142, 191)
        Me.tbx_Folio.MaxLength = 12
        Me.tbx_Folio.Name = "tbx_Folio"
        Me.tbx_Folio.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Folio.TabIndex = 9
        Me.tbx_Folio.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Promedio
        '
        Me.tbx_Promedio.Control_Siguiente = Me.tbx_NombreCurso
        Me.tbx_Promedio.Filtrado = True
        Me.tbx_Promedio.Location = New System.Drawing.Point(382, 191)
        Me.tbx_Promedio.MaxLength = 4
        Me.tbx_Promedio.Name = "tbx_Promedio"
        Me.tbx_Promedio.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Promedio.TabIndex = 10
        Me.tbx_Promedio.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_NombreCurso
        '
        Me.tbx_NombreCurso.Control_Siguiente = Me.dtp_FInicioCurso
        Me.tbx_NombreCurso.Enabled = False
        Me.tbx_NombreCurso.Filtrado = True
        Me.tbx_NombreCurso.Location = New System.Drawing.Point(135, 46)
        Me.tbx_NombreCurso.MaxLength = 100
        Me.tbx_NombreCurso.Name = "tbx_NombreCurso"
        Me.tbx_NombreCurso.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreCurso.TabIndex = 13
        Me.tbx_NombreCurso.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'dtp_FInicioCurso
        '
        Me.dtp_FInicioCurso.Enabled = False
        Me.dtp_FInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FInicioCurso.Location = New System.Drawing.Point(135, 70)
        Me.dtp_FInicioCurso.Name = "dtp_FInicioCurso"
        Me.dtp_FInicioCurso.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FInicioCurso.TabIndex = 14
        Me.dtp_FInicioCurso.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'cmb_AInicio
        '
        Me.cmb_AInicio.Control_Siguiente = Me.cmb_ATermino
        Me.cmb_AInicio.DisplayMember = "display"
        Me.cmb_AInicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_AInicio.FormattingEnabled = True
        Me.cmb_AInicio.Location = New System.Drawing.Point(142, 166)
        Me.cmb_AInicio.MaxDropDownItems = 20
        Me.cmb_AInicio.Name = "cmb_AInicio"
        Me.cmb_AInicio.Size = New System.Drawing.Size(111, 21)
        Me.cmb_AInicio.TabIndex = 7
        Me.cmb_AInicio.ValueMember = "value"
        '
        'cmb_Documentacion
        '
        Me.cmb_Documentacion.Clave = Nothing
        Me.cmb_Documentacion.Control_Siguiente = Me.tbx_NombreEscuela
        Me.cmb_Documentacion.DisplayMember = "Descripcion"
        Me.cmb_Documentacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Documentacion.Empresa = False
        Me.cmb_Documentacion.Filtro = Nothing
        Me.cmb_Documentacion.FormattingEnabled = True
        Me.cmb_Documentacion.Location = New System.Drawing.Point(142, 45)
        Me.cmb_Documentacion.MaxDropDownItems = 20
        Me.cmb_Documentacion.Name = "cmb_Documentacion"
        Me.cmb_Documentacion.Pista = False
        Me.cmb_Documentacion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Documentacion.StoredProcedure = "Cat_TipoDoctoEscolarCombo_Get"
        Me.cmb_Documentacion.Sucursal = False
        Me.cmb_Documentacion.TabIndex = 2
        Me.cmb_Documentacion.Tipo = 0
        Me.cmb_Documentacion.ValueMember = "Id_TipoDoctoEscolar"
        '
        'tbx_NombreEscuela
        '
        Me.tbx_NombreEscuela.Control_Siguiente = Me.tbx_Carrera
        Me.tbx_NombreEscuela.Filtrado = True
        Me.tbx_NombreEscuela.Location = New System.Drawing.Point(142, 70)
        Me.tbx_NombreEscuela.MaxLength = 100
        Me.tbx_NombreEscuela.Name = "tbx_NombreEscuela"
        Me.tbx_NombreEscuela.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreEscuela.TabIndex = 3
        Me.tbx_NombreEscuela.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Carrera
        '
        Me.tbx_Carrera.Control_Siguiente = Me.tbx_Especialidad
        Me.tbx_Carrera.Filtrado = True
        Me.tbx_Carrera.Location = New System.Drawing.Point(142, 94)
        Me.tbx_Carrera.MaxLength = 100
        Me.tbx_Carrera.Name = "tbx_Carrera"
        Me.tbx_Carrera.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Carrera.TabIndex = 4
        Me.tbx_Carrera.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Especialidad
        '
        Me.tbx_Especialidad.Control_Siguiente = Me.cmb_AInicio
        Me.tbx_Especialidad.Filtrado = True
        Me.tbx_Especialidad.Location = New System.Drawing.Point(142, 142)
        Me.tbx_Especialidad.MaxLength = 100
        Me.tbx_Especialidad.Name = "tbx_Especialidad"
        Me.tbx_Especialidad.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Especialidad.TabIndex = 6
        Me.tbx_Especialidad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_Documentacion
        '
        Me.lbl_Documentacion.AutoSize = True
        Me.lbl_Documentacion.Location = New System.Drawing.Point(9, 48)
        Me.lbl_Documentacion.Name = "lbl_Documentacion"
        Me.lbl_Documentacion.Size = New System.Drawing.Size(127, 13)
        Me.lbl_Documentacion.TabIndex = 4
        Me.lbl_Documentacion.Text = "Documentación Recibida"
        '
        'gbx_CursosRecibidos
        '
        Me.gbx_CursosRecibidos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_BuscarCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_TipoCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_TipoCursoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.cmb_TipoCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Borrar_DatosEscolares)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Cancelar_DatosEscolares)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Modificar_DatosEscolares)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_DocumentoCursoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_FTerminoCursoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_FInicioCursoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_CursoFinalizadoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_NombreCursoA)
        Me.gbx_CursosRecibidos.Controls.Add(Me.gbx_CursoFinalizado)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Agregar)
        Me.gbx_CursosRecibidos.Controls.Add(Me.cmb_DocumentoCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.dtp_FTerminoCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.dtp_FInicioCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_Comentarios)
        Me.gbx_CursosRecibidos.Controls.Add(Me.tbx_Comentarios)
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Guardar_DatosEscolares)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lsv_Cursos)
        Me.gbx_CursosRecibidos.Controls.Add(Me.tbx_Instructor)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_NombreCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_FechaInicio)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_FechaTermino)
        Me.gbx_CursosRecibidos.Controls.Add(Me.tbx_NombreCurso)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_Instructor)
        Me.gbx_CursosRecibidos.Controls.Add(Me.lbl_TipoDocto)
        Me.gbx_CursosRecibidos.Location = New System.Drawing.Point(6, 215)
        Me.gbx_CursosRecibidos.Name = "gbx_CursosRecibidos"
        Me.gbx_CursosRecibidos.Size = New System.Drawing.Size(1511, 466)
        Me.gbx_CursosRecibidos.TabIndex = 26
        Me.gbx_CursosRecibidos.TabStop = False
        Me.gbx_CursosRecibidos.Text = "Cursos Recibidos"
        '
        'btn_BuscarCurso
        '
        Me.btn_BuscarCurso.Enabled = False
        Me.btn_BuscarCurso.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_BuscarCurso.Location = New System.Drawing.Point(253, 18)
        Me.btn_BuscarCurso.Name = "btn_BuscarCurso"
        Me.btn_BuscarCurso.Size = New System.Drawing.Size(35, 23)
        Me.btn_BuscarCurso.TabIndex = 12
        Me.btn_BuscarCurso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_BuscarCurso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_BuscarCurso.UseVisualStyleBackColor = True
        '
        'lbl_TipoCurso
        '
        Me.lbl_TipoCurso.AutoSize = True
        Me.lbl_TipoCurso.Location = New System.Drawing.Point(56, 23)
        Me.lbl_TipoCurso.Name = "lbl_TipoCurso"
        Me.lbl_TipoCurso.Size = New System.Drawing.Size(73, 13)
        Me.lbl_TipoCurso.TabIndex = 0
        Me.lbl_TipoCurso.Text = "Tipo de Curso"
        '
        'lbl_TipoCursoA
        '
        Me.lbl_TipoCursoA.AutoSize = True
        Me.lbl_TipoCursoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TipoCursoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_TipoCursoA.Location = New System.Drawing.Point(294, 21)
        Me.lbl_TipoCursoA.Name = "lbl_TipoCursoA"
        Me.lbl_TipoCursoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_TipoCursoA.TabIndex = 2
        Me.lbl_TipoCursoA.Text = "*"
        '
        'cmb_TipoCurso
        '
        Me.cmb_TipoCurso.Control_Siguiente = Nothing
        Me.cmb_TipoCurso.DisplayMember = "display"
        Me.cmb_TipoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoCurso.FormattingEnabled = True
        Me.cmb_TipoCurso.Location = New System.Drawing.Point(135, 19)
        Me.cmb_TipoCurso.MaxDropDownItems = 20
        Me.cmb_TipoCurso.Name = "cmb_TipoCurso"
        Me.cmb_TipoCurso.Size = New System.Drawing.Size(112, 21)
        Me.cmb_TipoCurso.TabIndex = 11
        Me.cmb_TipoCurso.ValueMember = "value"
        '
        'btn_Borrar_DatosEscolares
        '
        Me.btn_Borrar_DatosEscolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosEscolares.Enabled = False
        Me.btn_Borrar_DatosEscolares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosEscolares.Location = New System.Drawing.Point(298, 430)
        Me.btn_Borrar_DatosEscolares.Name = "btn_Borrar_DatosEscolares"
        Me.btn_Borrar_DatosEscolares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_DatosEscolares.TabIndex = 25
        Me.btn_Borrar_DatosEscolares.Text = "&Borrar"
        Me.btn_Borrar_DatosEscolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_DatosEscolares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_DatosEscolares.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_DatosEscolares
        '
        Me.btn_Cancelar_DatosEscolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_DatosEscolares.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DatosEscolares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DatosEscolares.Location = New System.Drawing.Point(444, 430)
        Me.btn_Cancelar_DatosEscolares.Name = "btn_Cancelar_DatosEscolares"
        Me.btn_Cancelar_DatosEscolares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DatosEscolares.TabIndex = 26
        Me.btn_Cancelar_DatosEscolares.Text = "&Cancelar"
        Me.btn_Cancelar_DatosEscolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DatosEscolares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DatosEscolares.UseVisualStyleBackColor = True
        '
        'btn_Modificar_DatosEscolares
        '
        Me.btn_Modificar_DatosEscolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_DatosEscolares.Enabled = False
        Me.btn_Modificar_DatosEscolares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_DatosEscolares.Location = New System.Drawing.Point(152, 430)
        Me.btn_Modificar_DatosEscolares.Name = "btn_Modificar_DatosEscolares"
        Me.btn_Modificar_DatosEscolares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_DatosEscolares.TabIndex = 24
        Me.btn_Modificar_DatosEscolares.Text = "&Modificar"
        Me.btn_Modificar_DatosEscolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_DatosEscolares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_DatosEscolares.UseVisualStyleBackColor = True
        '
        'lbl_DocumentoCursoA
        '
        Me.lbl_DocumentoCursoA.AutoSize = True
        Me.lbl_DocumentoCursoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_DocumentoCursoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_DocumentoCursoA.Location = New System.Drawing.Point(370, 143)
        Me.lbl_DocumentoCursoA.Name = "lbl_DocumentoCursoA"
        Me.lbl_DocumentoCursoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_DocumentoCursoA.TabIndex = 18
        Me.lbl_DocumentoCursoA.Text = "*"
        Me.lbl_DocumentoCursoA.Visible = False
        '
        'lbl_FTerminoCursoA
        '
        Me.lbl_FTerminoCursoA.AutoSize = True
        Me.lbl_FTerminoCursoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FTerminoCursoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FTerminoCursoA.Location = New System.Drawing.Point(251, 96)
        Me.lbl_FTerminoCursoA.Name = "lbl_FTerminoCursoA"
        Me.lbl_FTerminoCursoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_FTerminoCursoA.TabIndex = 13
        Me.lbl_FTerminoCursoA.Text = "*"
        Me.lbl_FTerminoCursoA.Visible = False
        '
        'lbl_FInicioCursoA
        '
        Me.lbl_FInicioCursoA.AutoSize = True
        Me.lbl_FInicioCursoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_FInicioCursoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FInicioCursoA.Location = New System.Drawing.Point(251, 72)
        Me.lbl_FInicioCursoA.Name = "lbl_FInicioCursoA"
        Me.lbl_FInicioCursoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_FInicioCursoA.TabIndex = 8
        Me.lbl_FInicioCursoA.Text = "*"
        Me.lbl_FInicioCursoA.Visible = False
        '
        'lbl_CursoFinalizadoA
        '
        Me.lbl_CursoFinalizadoA.AutoSize = True
        Me.lbl_CursoFinalizadoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_CursoFinalizadoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_CursoFinalizadoA.Location = New System.Drawing.Point(491, 83)
        Me.lbl_CursoFinalizadoA.Name = "lbl_CursoFinalizadoA"
        Me.lbl_CursoFinalizadoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_CursoFinalizadoA.TabIndex = 10
        Me.lbl_CursoFinalizadoA.Text = "*"
        Me.lbl_CursoFinalizadoA.Visible = False
        '
        'lbl_NombreCursoA
        '
        Me.lbl_NombreCursoA.AutoSize = True
        Me.lbl_NombreCursoA.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreCursoA.ForeColor = System.Drawing.Color.Red
        Me.lbl_NombreCursoA.Location = New System.Drawing.Point(491, 47)
        Me.lbl_NombreCursoA.Name = "lbl_NombreCursoA"
        Me.lbl_NombreCursoA.Size = New System.Drawing.Size(13, 16)
        Me.lbl_NombreCursoA.TabIndex = 5
        Me.lbl_NombreCursoA.Text = "*"
        Me.lbl_NombreCursoA.Visible = False
        '
        'gbx_CursoFinalizado
        '
        Me.gbx_CursoFinalizado.Controls.Add(Me.rdb_No_CursoFin)
        Me.gbx_CursoFinalizado.Controls.Add(Me.rdb_Si_CursoFin)
        Me.gbx_CursoFinalizado.Enabled = False
        Me.gbx_CursoFinalizado.Location = New System.Drawing.Point(373, 70)
        Me.gbx_CursoFinalizado.Name = "gbx_CursoFinalizado"
        Me.gbx_CursoFinalizado.Size = New System.Drawing.Size(110, 37)
        Me.gbx_CursoFinalizado.TabIndex = 9
        Me.gbx_CursoFinalizado.TabStop = False
        Me.gbx_CursoFinalizado.Text = "Finalizado"
        '
        'rdb_No_CursoFin
        '
        Me.rdb_No_CursoFin.AutoSize = True
        Me.rdb_No_CursoFin.Location = New System.Drawing.Point(63, 13)
        Me.rdb_No_CursoFin.Name = "rdb_No_CursoFin"
        Me.rdb_No_CursoFin.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_CursoFin.TabIndex = 15
        Me.rdb_No_CursoFin.Text = "No"
        Me.rdb_No_CursoFin.UseVisualStyleBackColor = True
        '
        'rdb_Si_CursoFin
        '
        Me.rdb_Si_CursoFin.AutoSize = True
        Me.rdb_Si_CursoFin.Location = New System.Drawing.Point(10, 13)
        Me.rdb_Si_CursoFin.Name = "rdb_Si_CursoFin"
        Me.rdb_Si_CursoFin.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CursoFin.TabIndex = 15
        Me.rdb_Si_CursoFin.Text = "Si"
        Me.rdb_Si_CursoFin.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar.Location = New System.Drawing.Point(496, 157)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 19
        Me.btn_Agregar.Text = "Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'cmb_DocumentoCurso
        '
        Me.cmb_DocumentoCurso.Clave = Nothing
        Me.cmb_DocumentoCurso.Control_Siguiente = Me.tbx_Comentarios
        Me.cmb_DocumentoCurso.DisplayMember = "Descripcion"
        Me.cmb_DocumentoCurso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DocumentoCurso.Empresa = False
        Me.cmb_DocumentoCurso.Enabled = False
        Me.cmb_DocumentoCurso.Filtro = Nothing
        Me.cmb_DocumentoCurso.FormattingEnabled = True
        Me.cmb_DocumentoCurso.Location = New System.Drawing.Point(136, 142)
        Me.cmb_DocumentoCurso.MaxDropDownItems = 20
        Me.cmb_DocumentoCurso.Name = "cmb_DocumentoCurso"
        Me.cmb_DocumentoCurso.Pista = False
        Me.cmb_DocumentoCurso.Size = New System.Drawing.Size(228, 21)
        Me.cmb_DocumentoCurso.StoredProcedure = "Cat_TipoDoctoEscolarCombo_Get"
        Me.cmb_DocumentoCurso.Sucursal = False
        Me.cmb_DocumentoCurso.TabIndex = 17
        Me.cmb_DocumentoCurso.Tag = "Id_TipoDoctoEscolar"
        Me.cmb_DocumentoCurso.Tipo = 0
        Me.cmb_DocumentoCurso.ValueMember = "Id_TipoDoctoEscolar"
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Comentarios.Enabled = False
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(136, 167)
        Me.tbx_Comentarios.MaxLength = 100
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Comentarios.TabIndex = 18
        Me.tbx_Comentarios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'dtp_FTerminoCurso
        '
        Me.dtp_FTerminoCurso.Enabled = False
        Me.dtp_FTerminoCurso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FTerminoCurso.Location = New System.Drawing.Point(135, 94)
        Me.dtp_FTerminoCurso.Name = "dtp_FTerminoCurso"
        Me.dtp_FTerminoCurso.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FTerminoCurso.TabIndex = 15
        Me.dtp_FTerminoCurso.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_Comentarios
        '
        Me.lbl_Comentarios.AutoSize = True
        Me.lbl_Comentarios.Enabled = False
        Me.lbl_Comentarios.Location = New System.Drawing.Point(65, 170)
        Me.lbl_Comentarios.Name = "lbl_Comentarios"
        Me.lbl_Comentarios.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Comentarios.TabIndex = 19
        Me.lbl_Comentarios.Text = "Comentarios"
        '
        'btn_Guardar_DatosEscolares
        '
        Me.btn_Guardar_DatosEscolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_DatosEscolares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_DatosEscolares.Location = New System.Drawing.Point(6, 430)
        Me.btn_Guardar_DatosEscolares.Name = "btn_Guardar_DatosEscolares"
        Me.btn_Guardar_DatosEscolares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DatosEscolares.TabIndex = 23
        Me.btn_Guardar_DatosEscolares.Text = "&Guardar"
        Me.btn_Guardar_DatosEscolares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_DatosEscolares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_DatosEscolares.UseVisualStyleBackColor = True
        '
        'lsv_Cursos
        '
        Me.lsv_Cursos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Cursos.FullRowSelect = True
        Me.lsv_Cursos.HideSelection = False
        Me.lsv_Cursos.Location = New System.Drawing.Point(6, 193)
        ListViewColumnSorter34.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter34.SortColumn = 0
        Me.lsv_Cursos.Lvs = ListViewColumnSorter34
        Me.lsv_Cursos.MultiSelect = False
        Me.lsv_Cursos.Name = "lsv_Cursos"
        Me.lsv_Cursos.Row1 = 15
        Me.lsv_Cursos.Row10 = 0
        Me.lsv_Cursos.Row2 = 10
        Me.lsv_Cursos.Row3 = 10
        Me.lsv_Cursos.Row4 = 10
        Me.lsv_Cursos.Row5 = 20
        Me.lsv_Cursos.Row6 = 10
        Me.lsv_Cursos.Row7 = 20
        Me.lsv_Cursos.Row8 = 0
        Me.lsv_Cursos.Row9 = 0
        Me.lsv_Cursos.Size = New System.Drawing.Size(1499, 231)
        Me.lsv_Cursos.TabIndex = 20
        Me.lsv_Cursos.UseCompatibleStateImageBehavior = False
        Me.lsv_Cursos.View = System.Windows.Forms.View.Details
        '
        'tbx_Instructor
        '
        Me.tbx_Instructor.Control_Siguiente = Me.cmb_DocumentoCurso
        Me.tbx_Instructor.Enabled = False
        Me.tbx_Instructor.Filtrado = True
        Me.tbx_Instructor.Location = New System.Drawing.Point(136, 118)
        Me.tbx_Instructor.MaxLength = 100
        Me.tbx_Instructor.Name = "tbx_Instructor"
        Me.tbx_Instructor.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Instructor.TabIndex = 16
        Me.tbx_Instructor.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_NombreCurso
        '
        Me.lbl_NombreCurso.AutoSize = True
        Me.lbl_NombreCurso.Enabled = False
        Me.lbl_NombreCurso.Location = New System.Drawing.Point(38, 49)
        Me.lbl_NombreCurso.Name = "lbl_NombreCurso"
        Me.lbl_NombreCurso.Size = New System.Drawing.Size(91, 13)
        Me.lbl_NombreCurso.TabIndex = 3
        Me.lbl_NombreCurso.Text = "Nombre del Curso"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Enabled = False
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(64, 74)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(65, 13)
        Me.lbl_FechaInicio.TabIndex = 6
        Me.lbl_FechaInicio.Text = "Fecha Inicio"
        '
        'lbl_FechaTermino
        '
        Me.lbl_FechaTermino.AutoSize = True
        Me.lbl_FechaTermino.Enabled = False
        Me.lbl_FechaTermino.Location = New System.Drawing.Point(51, 98)
        Me.lbl_FechaTermino.Name = "lbl_FechaTermino"
        Me.lbl_FechaTermino.Size = New System.Drawing.Size(78, 13)
        Me.lbl_FechaTermino.TabIndex = 11
        Me.lbl_FechaTermino.Text = "Fecha Terminó"
        '
        'lbl_Instructor
        '
        Me.lbl_Instructor.AutoSize = True
        Me.lbl_Instructor.Enabled = False
        Me.lbl_Instructor.Location = New System.Drawing.Point(79, 121)
        Me.lbl_Instructor.Name = "lbl_Instructor"
        Me.lbl_Instructor.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Instructor.TabIndex = 14
        Me.lbl_Instructor.Text = "Instructor"
        '
        'lbl_TipoDocto
        '
        Me.lbl_TipoDocto.AutoSize = True
        Me.lbl_TipoDocto.Enabled = False
        Me.lbl_TipoDocto.Location = New System.Drawing.Point(23, 145)
        Me.lbl_TipoDocto.Name = "lbl_TipoDocto"
        Me.lbl_TipoDocto.Size = New System.Drawing.Size(107, 13)
        Me.lbl_TipoDocto.TabIndex = 16
        Me.lbl_TipoDocto.Text = "Documento Recibido"
        '
        'tbx_CedulaProfesional
        '
        Me.tbx_CedulaProfesional.Control_Siguiente = Nothing
        Me.tbx_CedulaProfesional.Filtrado = True
        Me.tbx_CedulaProfesional.Location = New System.Drawing.Point(142, 118)
        Me.tbx_CedulaProfesional.MaxLength = 12
        Me.tbx_CedulaProfesional.Name = "tbx_CedulaProfesional"
        Me.tbx_CedulaProfesional.Size = New System.Drawing.Size(110, 20)
        Me.tbx_CedulaProfesional.TabIndex = 5
        Me.tbx_CedulaProfesional.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_CedulaProf
        '
        Me.lbl_CedulaProf.AutoSize = True
        Me.lbl_CedulaProf.Location = New System.Drawing.Point(41, 121)
        Me.lbl_CedulaProf.Name = "lbl_CedulaProf"
        Me.lbl_CedulaProf.Size = New System.Drawing.Size(95, 13)
        Me.lbl_CedulaProf.TabIndex = 12
        Me.lbl_CedulaProf.Text = "Cédula Profesional"
        '
        'lbl_Promedio
        '
        Me.lbl_Promedio.AutoSize = True
        Me.lbl_Promedio.Location = New System.Drawing.Point(325, 193)
        Me.lbl_Promedio.Name = "lbl_Promedio"
        Me.lbl_Promedio.Size = New System.Drawing.Size(51, 13)
        Me.lbl_Promedio.TabIndex = 24
        Me.lbl_Promedio.Text = "Promedio"
        '
        'lbl_Folio
        '
        Me.lbl_Folio.AutoSize = True
        Me.lbl_Folio.Location = New System.Drawing.Point(107, 193)
        Me.lbl_Folio.Name = "lbl_Folio"
        Me.lbl_Folio.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Folio.TabIndex = 22
        Me.lbl_Folio.Text = "Folio"
        '
        'lbl_ATermino
        '
        Me.lbl_ATermino.AutoSize = True
        Me.lbl_ATermino.Location = New System.Drawing.Point(310, 170)
        Me.lbl_ATermino.Name = "lbl_ATermino"
        Me.lbl_ATermino.Size = New System.Drawing.Size(67, 13)
        Me.lbl_ATermino.TabIndex = 19
        Me.lbl_ATermino.Text = "Año Terminó"
        '
        'lbl_AInicio
        '
        Me.lbl_AInicio.AutoSize = True
        Me.lbl_AInicio.Location = New System.Drawing.Point(82, 170)
        Me.lbl_AInicio.Name = "lbl_AInicio"
        Me.lbl_AInicio.Size = New System.Drawing.Size(54, 13)
        Me.lbl_AInicio.TabIndex = 16
        Me.lbl_AInicio.Text = "Año Inicio"
        '
        'lbl_Carrera
        '
        Me.lbl_Carrera.AutoSize = True
        Me.lbl_Carrera.Location = New System.Drawing.Point(95, 97)
        Me.lbl_Carrera.Name = "lbl_Carrera"
        Me.lbl_Carrera.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Carrera.TabIndex = 10
        Me.lbl_Carrera.Text = "Carrera"
        '
        'lbl_Especialidad
        '
        Me.lbl_Especialidad.AutoSize = True
        Me.lbl_Especialidad.Location = New System.Drawing.Point(69, 145)
        Me.lbl_Especialidad.Name = "lbl_Especialidad"
        Me.lbl_Especialidad.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Especialidad.TabIndex = 14
        Me.lbl_Especialidad.Text = "Especialidad"
        '
        'lbl_NombreEscuela
        '
        Me.lbl_NombreEscuela.AutoSize = True
        Me.lbl_NombreEscuela.Location = New System.Drawing.Point(4, 73)
        Me.lbl_NombreEscuela.Name = "lbl_NombreEscuela"
        Me.lbl_NombreEscuela.Size = New System.Drawing.Size(132, 13)
        Me.lbl_NombreEscuela.TabIndex = 7
        Me.lbl_NombreEscuela.Text = "Nombre Completo Escuela"
        '
        'lbl_UltimosEstudios2
        '
        Me.lbl_UltimosEstudios2.AutoSize = True
        Me.lbl_UltimosEstudios2.Location = New System.Drawing.Point(10, 23)
        Me.lbl_UltimosEstudios2.Name = "lbl_UltimosEstudios2"
        Me.lbl_UltimosEstudios2.Size = New System.Drawing.Size(126, 13)
        Me.lbl_UltimosEstudios2.TabIndex = 0
        Me.lbl_UltimosEstudios2.Text = "Ultimo Grado de Estudios"
        '
        'cmb_UltimosEstudios
        '
        Me.cmb_UltimosEstudios.Clave = Nothing
        Me.cmb_UltimosEstudios.Control_Siguiente = Me.cmb_Documentacion
        Me.cmb_UltimosEstudios.DisplayMember = "Descripcion"
        Me.cmb_UltimosEstudios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UltimosEstudios.Empresa = False
        Me.cmb_UltimosEstudios.Filtro = Nothing
        Me.cmb_UltimosEstudios.FormattingEnabled = True
        Me.cmb_UltimosEstudios.Location = New System.Drawing.Point(142, 20)
        Me.cmb_UltimosEstudios.MaxDropDownItems = 20
        Me.cmb_UltimosEstudios.Name = "cmb_UltimosEstudios"
        Me.cmb_UltimosEstudios.Pista = False
        Me.cmb_UltimosEstudios.Size = New System.Drawing.Size(228, 21)
        Me.cmb_UltimosEstudios.StoredProcedure = "Cat_GradosEscolaresCombo_Get"
        Me.cmb_UltimosEstudios.Sucursal = False
        Me.cmb_UltimosEstudios.TabIndex = 1
        Me.cmb_UltimosEstudios.Tipo = 0
        Me.cmb_UltimosEstudios.ValueMember = "Id_GradoEscolar"
        '
        'lbl_Comprobable
        '
        Me.lbl_Comprobable.AutoSize = True
        Me.lbl_Comprobable.Location = New System.Drawing.Point(376, 23)
        Me.lbl_Comprobable.Name = "lbl_Comprobable"
        Me.lbl_Comprobable.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Comprobable.TabIndex = 2
        Me.lbl_Comprobable.Text = "(Comprobable)"
        '
        'tab_DatosFamiliares
        '
        Me.tab_DatosFamiliares.Controls.Add(Me.cmb_PaisesDatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label15)
        Me.tab_DatosFamiliares.Controls.Add(Me.cmb_CiudadesDatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label21)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Borrar_DatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Cancelar_DatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Modificar_Familiares)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label54)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label128)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label127)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label53)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label52)
        Me.tab_DatosFamiliares.Controls.Add(Me.dtp_FecNac_Familiar)
        Me.tab_DatosFamiliares.Controls.Add(Me.gbx_Vive)
        Me.tab_DatosFamiliares.Controls.Add(Me.gbx_MismoDomicilio)
        Me.tab_DatosFamiliares.Controls.Add(Me.cmb_Parentesco)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_Parentesco)
        Me.tab_DatosFamiliares.Controls.Add(Me.tbx_TelefonoFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.tbx_Domicilio_Familiares)
        Me.tab_DatosFamiliares.Controls.Add(Me.gbx_DepEconomico)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_Telefono)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_Domicilio)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_FNacimiento)
        Me.tab_DatosFamiliares.Controls.Add(Me.tbx_NombreFamiliar)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_NombreFamiliar)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Agregar_Familiares)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Guardar_Familiares)
        Me.tab_DatosFamiliares.Controls.Add(Me.lsv_Familiares)
        Me.tab_DatosFamiliares.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosFamiliares.Name = "tab_DatosFamiliares"
        Me.tab_DatosFamiliares.Size = New System.Drawing.Size(1523, 687)
        Me.tab_DatosFamiliares.TabIndex = 2
        Me.tab_DatosFamiliares.Text = "Datos Familiares"
        Me.tab_DatosFamiliares.UseVisualStyleBackColor = True
        '
        'cmb_PaisesDatosFamiliares
        '
        Me.cmb_PaisesDatosFamiliares.Clave = Nothing
        Me.cmb_PaisesDatosFamiliares.Control_Siguiente = Me.tbx_CodigoPostal_Empleos
        Me.cmb_PaisesDatosFamiliares.DisplayMember = "Nombre"
        Me.cmb_PaisesDatosFamiliares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PaisesDatosFamiliares.Empresa = False
        Me.cmb_PaisesDatosFamiliares.Filtro = Nothing
        Me.cmb_PaisesDatosFamiliares.FormattingEnabled = True
        Me.cmb_PaisesDatosFamiliares.Location = New System.Drawing.Point(102, 95)
        Me.cmb_PaisesDatosFamiliares.MaxDropDownItems = 20
        Me.cmb_PaisesDatosFamiliares.Name = "cmb_PaisesDatosFamiliares"
        Me.cmb_PaisesDatosFamiliares.Pista = False
        Me.cmb_PaisesDatosFamiliares.Size = New System.Drawing.Size(350, 21)
        Me.cmb_PaisesDatosFamiliares.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_PaisesDatosFamiliares.Sucursal = False
        Me.cmb_PaisesDatosFamiliares.TabIndex = 4
        Me.cmb_PaisesDatosFamiliares.Tipo = 0
        Me.cmb_PaisesDatosFamiliares.ValueMember = "Id_Pais"
        '
        'tbx_CodigoPostal_Empleos
        '
        Me.tbx_CodigoPostal_Empleos.Control_Siguiente = Me.tbx_Telefono_Empleos
        Me.tbx_CodigoPostal_Empleos.Filtrado = True
        Me.tbx_CodigoPostal_Empleos.Location = New System.Drawing.Point(389, 100)
        Me.tbx_CodigoPostal_Empleos.MaxLength = 6
        Me.tbx_CodigoPostal_Empleos.Name = "tbx_CodigoPostal_Empleos"
        Me.tbx_CodigoPostal_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_CodigoPostal_Empleos.TabIndex = 5
        Me.tbx_CodigoPostal_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Telefono_Empleos
        '
        Me.tbx_Telefono_Empleos.Control_Siguiente = Me.tbx_LatitudEmpleos
        Me.tbx_Telefono_Empleos.Filtrado = True
        Me.tbx_Telefono_Empleos.Location = New System.Drawing.Point(392, 181)
        Me.tbx_Telefono_Empleos.MaxLength = 25
        Me.tbx_Telefono_Empleos.Name = "tbx_Telefono_Empleos"
        Me.tbx_Telefono_Empleos.Size = New System.Drawing.Size(83, 20)
        Me.tbx_Telefono_Empleos.TabIndex = 11
        Me.tbx_Telefono_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_LatitudEmpleos
        '
        Me.tbx_LatitudEmpleos.Control_Siguiente = Me.tbx_LongitudEmpleos
        Me.tbx_LatitudEmpleos.Filtrado = True
        Me.tbx_LatitudEmpleos.Location = New System.Drawing.Point(125, 205)
        Me.tbx_LatitudEmpleos.MaxLength = 11
        Me.tbx_LatitudEmpleos.Name = "tbx_LatitudEmpleos"
        Me.tbx_LatitudEmpleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_LatitudEmpleos.TabIndex = 12
        Me.tbx_LatitudEmpleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_LongitudEmpleos
        '
        Me.tbx_LongitudEmpleos.Control_Siguiente = Me.dtp_FechaIngreso_Empleos
        Me.tbx_LongitudEmpleos.Filtrado = True
        Me.tbx_LongitudEmpleos.Location = New System.Drawing.Point(392, 205)
        Me.tbx_LongitudEmpleos.MaxLength = 11
        Me.tbx_LongitudEmpleos.Name = "tbx_LongitudEmpleos"
        Me.tbx_LongitudEmpleos.Size = New System.Drawing.Size(83, 20)
        Me.tbx_LongitudEmpleos.TabIndex = 13
        Me.tbx_LongitudEmpleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'dtp_FechaIngreso_Empleos
        '
        Me.dtp_FechaIngreso_Empleos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso_Empleos.Location = New System.Drawing.Point(125, 229)
        Me.dtp_FechaIngreso_Empleos.Name = "dtp_FechaIngreso_Empleos"
        Me.dtp_FechaIngreso_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.dtp_FechaIngreso_Empleos.TabIndex = 14
        Me.dtp_FechaIngreso_Empleos.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(66, 98)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(27, 13)
        Me.Label15.TabIndex = 103
        Me.Label15.Text = "Pais"
        '
        'cmb_CiudadesDatosFamiliares
        '
        Me.cmb_CiudadesDatosFamiliares.Clave = Nothing
        Me.cmb_CiudadesDatosFamiliares.Control_Siguiente = Me.tbx_CodigoPostal_Empleos
        Me.cmb_CiudadesDatosFamiliares.DisplayMember = "Nombre"
        Me.cmb_CiudadesDatosFamiliares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadesDatosFamiliares.Empresa = False
        Me.cmb_CiudadesDatosFamiliares.Filtro = Nothing
        Me.cmb_CiudadesDatosFamiliares.FormattingEnabled = True
        Me.cmb_CiudadesDatosFamiliares.Location = New System.Drawing.Point(102, 191)
        Me.cmb_CiudadesDatosFamiliares.MaxDropDownItems = 20
        Me.cmb_CiudadesDatosFamiliares.Name = "cmb_CiudadesDatosFamiliares"
        Me.cmb_CiudadesDatosFamiliares.Pista = False
        Me.cmb_CiudadesDatosFamiliares.Size = New System.Drawing.Size(350, 21)
        Me.cmb_CiudadesDatosFamiliares.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_CiudadesDatosFamiliares.Sucursal = False
        Me.cmb_CiudadesDatosFamiliares.TabIndex = 8
        Me.cmb_CiudadesDatosFamiliares.Tipo = 0
        Me.cmb_CiudadesDatosFamiliares.ValueMember = "id_Ciudad"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(56, 194)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(40, 13)
        Me.Label21.TabIndex = 101
        Me.Label21.Text = "Ciudad"
        '
        'btn_Borrar_DatosFamiliares
        '
        Me.btn_Borrar_DatosFamiliares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosFamiliares.Enabled = False
        Me.btn_Borrar_DatosFamiliares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosFamiliares.Location = New System.Drawing.Point(295, 654)
        Me.btn_Borrar_DatosFamiliares.Name = "btn_Borrar_DatosFamiliares"
        Me.btn_Borrar_DatosFamiliares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_DatosFamiliares.TabIndex = 17
        Me.btn_Borrar_DatosFamiliares.Text = "&Borrar"
        Me.btn_Borrar_DatosFamiliares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_DatosFamiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_DatosFamiliares.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_DatosFamiliares
        '
        Me.btn_Cancelar_DatosFamiliares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_DatosFamiliares.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DatosFamiliares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DatosFamiliares.Location = New System.Drawing.Point(441, 654)
        Me.btn_Cancelar_DatosFamiliares.Name = "btn_Cancelar_DatosFamiliares"
        Me.btn_Cancelar_DatosFamiliares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DatosFamiliares.TabIndex = 18
        Me.btn_Cancelar_DatosFamiliares.Text = "&Cancelar"
        Me.btn_Cancelar_DatosFamiliares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DatosFamiliares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DatosFamiliares.UseVisualStyleBackColor = True
        '
        'btn_Modificar_Familiares
        '
        Me.btn_Modificar_Familiares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_Familiares.Enabled = False
        Me.btn_Modificar_Familiares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_Familiares.Location = New System.Drawing.Point(149, 654)
        Me.btn_Modificar_Familiares.Name = "btn_Modificar_Familiares"
        Me.btn_Modificar_Familiares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Familiares.TabIndex = 16
        Me.btn_Modificar_Familiares.Text = "&Modificar"
        Me.btn_Modificar_Familiares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Familiares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Familiares.UseVisualStyleBackColor = True
        '
        'Label54
        '
        Me.Label54.AutoSize = True
        Me.Label54.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label54.ForeColor = System.Drawing.Color.Red
        Me.Label54.Location = New System.Drawing.Point(336, 45)
        Me.Label54.Name = "Label54"
        Me.Label54.Size = New System.Drawing.Size(13, 16)
        Me.Label54.TabIndex = 20
        Me.Label54.Text = "*"
        '
        'Label128
        '
        Me.Label128.AutoSize = True
        Me.Label128.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label128.ForeColor = System.Drawing.Color.Red
        Me.Label128.Location = New System.Drawing.Point(217, 256)
        Me.Label128.Name = "Label128"
        Me.Label128.Size = New System.Drawing.Size(13, 16)
        Me.Label128.TabIndex = 19
        Me.Label128.Text = "*"
        '
        'Label127
        '
        Me.Label127.AutoSize = True
        Me.Label127.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label127.ForeColor = System.Drawing.Color.Red
        Me.Label127.Location = New System.Drawing.Point(257, 137)
        Me.Label127.Name = "Label127"
        Me.Label127.Size = New System.Drawing.Size(13, 16)
        Me.Label127.TabIndex = 19
        Me.Label127.Text = "*"
        '
        'Label53
        '
        Me.Label53.AutoSize = True
        Me.Label53.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label53.ForeColor = System.Drawing.Color.Red
        Me.Label53.Location = New System.Drawing.Point(382, 256)
        Me.Label53.Name = "Label53"
        Me.Label53.Size = New System.Drawing.Size(13, 16)
        Me.Label53.TabIndex = 19
        Me.Label53.Text = "*"
        '
        'Label52
        '
        Me.Label52.AutoSize = True
        Me.Label52.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label52.ForeColor = System.Drawing.Color.Red
        Me.Label52.Location = New System.Drawing.Point(458, 21)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(13, 16)
        Me.Label52.TabIndex = 18
        Me.Label52.Text = "*"
        '
        'dtp_FecNac_Familiar
        '
        Me.dtp_FecNac_Familiar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FecNac_Familiar.Location = New System.Drawing.Point(102, 69)
        Me.dtp_FecNac_Familiar.Name = "dtp_FecNac_Familiar"
        Me.dtp_FecNac_Familiar.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FecNac_Familiar.TabIndex = 3
        Me.dtp_FecNac_Familiar.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'gbx_Vive
        '
        Me.gbx_Vive.Controls.Add(Me.rdb_Si_Vive)
        Me.gbx_Vive.Controls.Add(Me.rdb_No_Vive)
        Me.gbx_Vive.Location = New System.Drawing.Point(102, 242)
        Me.gbx_Vive.Name = "gbx_Vive"
        Me.gbx_Vive.Size = New System.Drawing.Size(110, 37)
        Me.gbx_Vive.TabIndex = 12
        Me.gbx_Vive.TabStop = False
        Me.gbx_Vive.Text = "Vive"
        '
        'rdb_Si_Vive
        '
        Me.rdb_Si_Vive.AutoSize = True
        Me.rdb_Si_Vive.Location = New System.Drawing.Point(6, 15)
        Me.rdb_Si_Vive.Name = "rdb_Si_Vive"
        Me.rdb_Si_Vive.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_Vive.TabIndex = 9
        Me.rdb_Si_Vive.Text = "Si"
        Me.rdb_Si_Vive.UseVisualStyleBackColor = True
        '
        'rdb_No_Vive
        '
        Me.rdb_No_Vive.AutoSize = True
        Me.rdb_No_Vive.Location = New System.Drawing.Point(68, 14)
        Me.rdb_No_Vive.Name = "rdb_No_Vive"
        Me.rdb_No_Vive.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_Vive.TabIndex = 10
        Me.rdb_No_Vive.Text = "No"
        Me.rdb_No_Vive.UseVisualStyleBackColor = True
        '
        'gbx_MismoDomicilio
        '
        Me.gbx_MismoDomicilio.Controls.Add(Me.rdb_Si_MismoDom)
        Me.gbx_MismoDomicilio.Controls.Add(Me.rdb_No_MismoDom)
        Me.gbx_MismoDomicilio.Location = New System.Drawing.Point(102, 122)
        Me.gbx_MismoDomicilio.Name = "gbx_MismoDomicilio"
        Me.gbx_MismoDomicilio.Size = New System.Drawing.Size(149, 37)
        Me.gbx_MismoDomicilio.TabIndex = 13
        Me.gbx_MismoDomicilio.TabStop = False
        Me.gbx_MismoDomicilio.Text = "Vive en el mismo domicilio"
        '
        'rdb_Si_MismoDom
        '
        Me.rdb_Si_MismoDom.AutoSize = True
        Me.rdb_Si_MismoDom.Location = New System.Drawing.Point(10, 15)
        Me.rdb_Si_MismoDom.Name = "rdb_Si_MismoDom"
        Me.rdb_Si_MismoDom.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_MismoDom.TabIndex = 5
        Me.rdb_Si_MismoDom.Text = "Si"
        Me.rdb_Si_MismoDom.UseVisualStyleBackColor = True
        '
        'rdb_No_MismoDom
        '
        Me.rdb_No_MismoDom.AutoSize = True
        Me.rdb_No_MismoDom.Location = New System.Drawing.Point(69, 15)
        Me.rdb_No_MismoDom.Name = "rdb_No_MismoDom"
        Me.rdb_No_MismoDom.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_MismoDom.TabIndex = 6
        Me.rdb_No_MismoDom.Text = "No"
        Me.rdb_No_MismoDom.UseVisualStyleBackColor = True
        '
        'cmb_Parentesco
        '
        Me.cmb_Parentesco.Clave = Nothing
        Me.cmb_Parentesco.Control_Siguiente = Me.dtp_FecNac_Familiar
        Me.cmb_Parentesco.DisplayMember = "Descripcion"
        Me.cmb_Parentesco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Parentesco.Empresa = False
        Me.cmb_Parentesco.Filtro = Nothing
        Me.cmb_Parentesco.FormattingEnabled = True
        Me.cmb_Parentesco.Location = New System.Drawing.Point(102, 44)
        Me.cmb_Parentesco.MaxDropDownItems = 20
        Me.cmb_Parentesco.Name = "cmb_Parentesco"
        Me.cmb_Parentesco.Pista = False
        Me.cmb_Parentesco.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Parentesco.StoredProcedure = "Cat_TipoParentescoCombo_Get"
        Me.cmb_Parentesco.Sucursal = False
        Me.cmb_Parentesco.TabIndex = 2
        Me.cmb_Parentesco.Tipo = 0
        Me.cmb_Parentesco.ValueMember = "Id_TipoParentesco"
        '
        'lbl_Parentesco
        '
        Me.lbl_Parentesco.AutoSize = True
        Me.lbl_Parentesco.Location = New System.Drawing.Point(35, 47)
        Me.lbl_Parentesco.Name = "lbl_Parentesco"
        Me.lbl_Parentesco.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Parentesco.TabIndex = 2
        Me.lbl_Parentesco.Text = "Parentesco"
        '
        'tbx_TelefonoFamiliares
        '
        Me.tbx_TelefonoFamiliares.Control_Siguiente = Me.rdb_Si_Vive
        Me.tbx_TelefonoFamiliares.Filtrado = True
        Me.tbx_TelefonoFamiliares.Location = New System.Drawing.Point(102, 218)
        Me.tbx_TelefonoFamiliares.MaxLength = 25
        Me.tbx_TelefonoFamiliares.Name = "tbx_TelefonoFamiliares"
        Me.tbx_TelefonoFamiliares.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TelefonoFamiliares.TabIndex = 11
        Me.tbx_TelefonoFamiliares.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Domicilio_Familiares
        '
        Me.tbx_Domicilio_Familiares.Control_Siguiente = Nothing
        Me.tbx_Domicilio_Familiares.Filtrado = True
        Me.tbx_Domicilio_Familiares.Location = New System.Drawing.Point(102, 165)
        Me.tbx_Domicilio_Familiares.MaxLength = 100
        Me.tbx_Domicilio_Familiares.Name = "tbx_Domicilio_Familiares"
        Me.tbx_Domicilio_Familiares.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Domicilio_Familiares.TabIndex = 7
        Me.tbx_Domicilio_Familiares.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'gbx_DepEconomico
        '
        Me.gbx_DepEconomico.Controls.Add(Me.rdb_Si_DepEcon)
        Me.gbx_DepEconomico.Controls.Add(Me.rdb_No_DepEcon)
        Me.gbx_DepEconomico.Location = New System.Drawing.Point(236, 242)
        Me.gbx_DepEconomico.Name = "gbx_DepEconomico"
        Me.gbx_DepEconomico.Size = New System.Drawing.Size(140, 37)
        Me.gbx_DepEconomico.TabIndex = 14
        Me.gbx_DepEconomico.TabStop = False
        Me.gbx_DepEconomico.Text = "Dependiente Económico"
        '
        'rdb_Si_DepEcon
        '
        Me.rdb_Si_DepEcon.AutoSize = True
        Me.rdb_Si_DepEcon.Location = New System.Drawing.Point(10, 15)
        Me.rdb_Si_DepEcon.Name = "rdb_Si_DepEcon"
        Me.rdb_Si_DepEcon.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_DepEcon.TabIndex = 11
        Me.rdb_Si_DepEcon.Text = "Si"
        Me.rdb_Si_DepEcon.UseVisualStyleBackColor = True
        '
        'rdb_No_DepEcon
        '
        Me.rdb_No_DepEcon.AutoSize = True
        Me.rdb_No_DepEcon.Location = New System.Drawing.Point(95, 15)
        Me.rdb_No_DepEcon.Name = "rdb_No_DepEcon"
        Me.rdb_No_DepEcon.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_DepEcon.TabIndex = 12
        Me.rdb_No_DepEcon.Text = "No"
        Me.rdb_No_DepEcon.UseVisualStyleBackColor = True
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(47, 221)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 10
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'lbl_Domicilio
        '
        Me.lbl_Domicilio.AutoSize = True
        Me.lbl_Domicilio.Location = New System.Drawing.Point(53, 165)
        Me.lbl_Domicilio.Name = "lbl_Domicilio"
        Me.lbl_Domicilio.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Domicilio.TabIndex = 6
        Me.lbl_Domicilio.Text = "Domicilio"
        '
        'lbl_FNacimiento
        '
        Me.lbl_FNacimiento.AutoSize = True
        Me.lbl_FNacimiento.Location = New System.Drawing.Point(3, 73)
        Me.lbl_FNacimiento.Name = "lbl_FNacimiento"
        Me.lbl_FNacimiento.Size = New System.Drawing.Size(93, 13)
        Me.lbl_FNacimiento.TabIndex = 4
        Me.lbl_FNacimiento.Text = "Fecha Nacimiento"
        '
        'tbx_NombreFamiliar
        '
        Me.tbx_NombreFamiliar.Control_Siguiente = Me.cmb_Parentesco
        Me.tbx_NombreFamiliar.Filtrado = True
        Me.tbx_NombreFamiliar.Location = New System.Drawing.Point(102, 20)
        Me.tbx_NombreFamiliar.MaxLength = 100
        Me.tbx_NombreFamiliar.Name = "tbx_NombreFamiliar"
        Me.tbx_NombreFamiliar.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreFamiliar.TabIndex = 1
        Me.tbx_NombreFamiliar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_NombreFamiliar
        '
        Me.lbl_NombreFamiliar.AutoSize = True
        Me.lbl_NombreFamiliar.Location = New System.Drawing.Point(5, 23)
        Me.lbl_NombreFamiliar.Name = "lbl_NombreFamiliar"
        Me.lbl_NombreFamiliar.Size = New System.Drawing.Size(91, 13)
        Me.lbl_NombreFamiliar.TabIndex = 0
        Me.lbl_NombreFamiliar.Text = "Nombre Completo"
        '
        'btn_Agregar_Familiares
        '
        Me.btn_Agregar_Familiares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Familiares.Location = New System.Drawing.Point(496, 215)
        Me.btn_Agregar_Familiares.Name = "btn_Agregar_Familiares"
        Me.btn_Agregar_Familiares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Familiares.TabIndex = 13
        Me.btn_Agregar_Familiares.Text = "Agregar"
        Me.btn_Agregar_Familiares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Familiares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Familiares.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Familiares
        '
        Me.btn_Guardar_Familiares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Familiares.Enabled = False
        Me.btn_Guardar_Familiares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Familiares.Location = New System.Drawing.Point(3, 654)
        Me.btn_Guardar_Familiares.Name = "btn_Guardar_Familiares"
        Me.btn_Guardar_Familiares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Familiares.TabIndex = 15
        Me.btn_Guardar_Familiares.Text = "&Guardar"
        Me.btn_Guardar_Familiares.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Familiares.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Familiares.UseVisualStyleBackColor = True
        '
        'lsv_Familiares
        '
        Me.lsv_Familiares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Familiares.FullRowSelect = True
        Me.lsv_Familiares.HideSelection = False
        Me.lsv_Familiares.Location = New System.Drawing.Point(3, 326)
        ListViewColumnSorter35.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter35.SortColumn = 0
        Me.lsv_Familiares.Lvs = ListViewColumnSorter35
        Me.lsv_Familiares.MultiSelect = False
        Me.lsv_Familiares.Name = "lsv_Familiares"
        Me.lsv_Familiares.Row1 = 20
        Me.lsv_Familiares.Row10 = 0
        Me.lsv_Familiares.Row2 = 10
        Me.lsv_Familiares.Row3 = 10
        Me.lsv_Familiares.Row4 = 15
        Me.lsv_Familiares.Row5 = 10
        Me.lsv_Familiares.Row6 = 10
        Me.lsv_Familiares.Row7 = 5
        Me.lsv_Familiares.Row8 = 8
        Me.lsv_Familiares.Row9 = 8
        Me.lsv_Familiares.Size = New System.Drawing.Size(1517, 322)
        Me.lsv_Familiares.TabIndex = 14
        Me.lsv_Familiares.UseCompatibleStateImageBehavior = False
        Me.lsv_Familiares.View = System.Windows.Forms.View.Details
        '
        'tab_Empleos
        '
        Me.tab_Empleos.Controls.Add(Me.btn_Investigacion)
        Me.tab_Empleos.Controls.Add(Me.tbx_Colonias_Empleos)
        Me.tab_Empleos.Controls.Add(Me.cmb_Paises_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Label7)
        Me.tab_Empleos.Controls.Add(Me.btn_MapaLaborales)
        Me.tab_Empleos.Controls.Add(Me.lsv_PredictivoEmpresas)
        Me.tab_Empleos.Controls.Add(Me.tbx_LongitudEmpleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_LatitudEmpleos)
        Me.tab_Empleos.Controls.Add(Me.lbl_LongitudEmpleos)
        Me.tab_Empleos.Controls.Add(Me.lbl_LatitudEmpleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_EntreCalle2Empleos)
        Me.tab_Empleos.Controls.Add(Me.lbl_EntreCalle2Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_EntreCalle1Empleos)
        Me.tab_Empleos.Controls.Add(Me.lbl_EntreCalle1Empleos)
        Me.tab_Empleos.Controls.Add(Me.lbl_EmpresaSeguridad)
        Me.tab_Empleos.Controls.Add(Me.gbx_EmpresaSeg)
        Me.tab_Empleos.Controls.Add(Me.lbl_PorteArmas)
        Me.tab_Empleos.Controls.Add(Me.gbx_PorteArmas)
        Me.tab_Empleos.Controls.Add(Me.lbl_ColoniaEmpleos)
        Me.tab_Empleos.Controls.Add(Me.Label79)
        Me.tab_Empleos.Controls.Add(Me.Label12)
        Me.tab_Empleos.Controls.Add(Me.Label72)
        Me.tab_Empleos.Controls.Add(Me.Label126)
        Me.tab_Empleos.Controls.Add(Me.Label71)
        Me.tab_Empleos.Controls.Add(Me.Label125)
        Me.tab_Empleos.Controls.Add(Me.Label70)
        Me.tab_Empleos.Controls.Add(Me.Label65)
        Me.tab_Empleos.Controls.Add(Me.Label66)
        Me.tab_Empleos.Controls.Add(Me.Label64)
        Me.tab_Empleos.Controls.Add(Me.Label63)
        Me.tab_Empleos.Controls.Add(Me.Label61)
        Me.tab_Empleos.Controls.Add(Me.Label59)
        Me.tab_Empleos.Controls.Add(Me.cmb_MotivoSeparacion)
        Me.tab_Empleos.Controls.Add(Me.cmb_Ciudades_Empleos)
        Me.tab_Empleos.Controls.Add(Me.dtp_FechaBaja_Empleos)
        Me.tab_Empleos.Controls.Add(Me.dtp_FechaIngreso_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_OtroMotivo)
        Me.tab_Empleos.Controls.Add(Me.Lbl_OtroMotEmpleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_MotSepEmpleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_SueldoFinal_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_SueFinMenEmpleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_SueldoInicial_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_Telefono_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_SueIniMenEmpleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_TelefonoEmpleados)
        Me.tab_Empleos.Controls.Add(Me.tbx_PuestoJefe_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_PueJefInmEmpleado)
        Me.tab_Empleos.Controls.Add(Me.tbx_NombreJefe_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NomJefInmEmpleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_Puesto_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_PuestoEmpleados)
        Me.tab_Empleos.Controls.Add(Me.lbl_FBaja)
        Me.tab_Empleos.Controls.Add(Me.lbl_FIngreso)
        Me.tab_Empleos.Controls.Add(Me.btn_Borrar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Cancelar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Modificar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Agregar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Guardar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.lsv_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_CodigoPostal_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_NumeroInt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_NumeroExt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_Cp_Empleados)
        Me.tab_Empleos.Controls.Add(Me.Lbl_Ciudad_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NumeroInt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NumeroExt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_Calle_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_CalleE)
        Me.tab_Empleos.Controls.Add(Me.tbx_NombreEmpresa_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NombreEmpE)
        Me.tab_Empleos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Empleos.Name = "tab_Empleos"
        Me.tab_Empleos.Size = New System.Drawing.Size(1523, 687)
        Me.tab_Empleos.TabIndex = 4
        Me.tab_Empleos.Text = "Empleos"
        Me.tab_Empleos.UseVisualStyleBackColor = True
        '
        'tbx_Colonias_Empleos
        '
        Me.tbx_Colonias_Empleos.Location = New System.Drawing.Point(125, 100)
        Me.tbx_Colonias_Empleos.Name = "tbx_Colonias_Empleos"
        Me.tbx_Colonias_Empleos.Size = New System.Drawing.Size(186, 20)
        Me.tbx_Colonias_Empleos.TabIndex = 4
        '
        'cmb_Paises_Empleos
        '
        Me.cmb_Paises_Empleos.Clave = Nothing
        Me.cmb_Paises_Empleos.Control_Siguiente = Me.tbx_CodigoPostal_Empleos
        Me.cmb_Paises_Empleos.DisplayMember = "Nombre"
        Me.cmb_Paises_Empleos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Paises_Empleos.Empresa = False
        Me.cmb_Paises_Empleos.Filtro = Nothing
        Me.cmb_Paises_Empleos.FormattingEnabled = True
        Me.cmb_Paises_Empleos.Location = New System.Drawing.Point(125, 46)
        Me.cmb_Paises_Empleos.MaxDropDownItems = 20
        Me.cmb_Paises_Empleos.Name = "cmb_Paises_Empleos"
        Me.cmb_Paises_Empleos.Pista = False
        Me.cmb_Paises_Empleos.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Paises_Empleos.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Paises_Empleos.Sucursal = False
        Me.cmb_Paises_Empleos.TabIndex = 2
        Me.cmb_Paises_Empleos.Tipo = 0
        Me.cmb_Paises_Empleos.ValueMember = "Id_Pais"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Pais"
        '
        'btn_MapaLaborales
        '
        Me.btn_MapaLaborales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_MapaLaborales.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.MapaMundo
        Me.btn_MapaLaborales.Location = New System.Drawing.Point(441, 654)
        Me.btn_MapaLaborales.Name = "btn_MapaLaborales"
        Me.btn_MapaLaborales.Size = New System.Drawing.Size(140, 30)
        Me.btn_MapaLaborales.TabIndex = 32
        Me.btn_MapaLaborales.Text = "&Ver en Mapa"
        Me.btn_MapaLaborales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MapaLaborales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MapaLaborales.UseVisualStyleBackColor = True
        '
        'lsv_PredictivoEmpresas
        '
        Me.lsv_PredictivoEmpresas.AllowColumnReorder = True
        Me.lsv_PredictivoEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_PredictivoEmpresas.FullRowSelect = True
        Me.lsv_PredictivoEmpresas.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None
        Me.lsv_PredictivoEmpresas.HideSelection = False
        Me.lsv_PredictivoEmpresas.Location = New System.Drawing.Point(504, 10)
        ListViewColumnSorter36.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter36.SortColumn = 0
        Me.lsv_PredictivoEmpresas.Lvs = ListViewColumnSorter36
        Me.lsv_PredictivoEmpresas.MultiSelect = False
        Me.lsv_PredictivoEmpresas.Name = "lsv_PredictivoEmpresas"
        Me.lsv_PredictivoEmpresas.Row1 = 90
        Me.lsv_PredictivoEmpresas.Row10 = 0
        Me.lsv_PredictivoEmpresas.Row2 = 0
        Me.lsv_PredictivoEmpresas.Row3 = 0
        Me.lsv_PredictivoEmpresas.Row4 = 0
        Me.lsv_PredictivoEmpresas.Row5 = 0
        Me.lsv_PredictivoEmpresas.Row6 = 0
        Me.lsv_PredictivoEmpresas.Row7 = 0
        Me.lsv_PredictivoEmpresas.Row8 = 0
        Me.lsv_PredictivoEmpresas.Row9 = 0
        Me.lsv_PredictivoEmpresas.Size = New System.Drawing.Size(1005, 256)
        Me.lsv_PredictivoEmpresas.TabIndex = 20
        Me.lsv_PredictivoEmpresas.UseCompatibleStateImageBehavior = False
        Me.lsv_PredictivoEmpresas.View = System.Windows.Forms.View.Details
        Me.lsv_PredictivoEmpresas.Visible = False
        '
        'lbl_LongitudEmpleos
        '
        Me.lbl_LongitudEmpleos.AutoSize = True
        Me.lbl_LongitudEmpleos.Location = New System.Drawing.Point(339, 208)
        Me.lbl_LongitudEmpleos.Name = "lbl_LongitudEmpleos"
        Me.lbl_LongitudEmpleos.Size = New System.Drawing.Size(48, 13)
        Me.lbl_LongitudEmpleos.TabIndex = 28
        Me.lbl_LongitudEmpleos.Text = "Longitud"
        '
        'lbl_LatitudEmpleos
        '
        Me.lbl_LatitudEmpleos.AutoSize = True
        Me.lbl_LatitudEmpleos.Location = New System.Drawing.Point(83, 208)
        Me.lbl_LatitudEmpleos.Name = "lbl_LatitudEmpleos"
        Me.lbl_LatitudEmpleos.Size = New System.Drawing.Size(39, 13)
        Me.lbl_LatitudEmpleos.TabIndex = 26
        Me.lbl_LatitudEmpleos.Text = "Latitud"
        '
        'tbx_EntreCalle2Empleos
        '
        Me.tbx_EntreCalle2Empleos.Control_Siguiente = Me.tbx_NumeroExt_Empleos
        Me.tbx_EntreCalle2Empleos.Filtrado = False
        Me.tbx_EntreCalle2Empleos.Location = New System.Drawing.Point(330, 129)
        Me.tbx_EntreCalle2Empleos.MaxLength = 100
        Me.tbx_EntreCalle2Empleos.Name = "tbx_EntreCalle2Empleos"
        Me.tbx_EntreCalle2Empleos.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle2Empleos.TabIndex = 7
        Me.tbx_EntreCalle2Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroExt_Empleos
        '
        Me.tbx_NumeroExt_Empleos.Control_Siguiente = Me.tbx_NumeroInt_Empleos
        Me.tbx_NumeroExt_Empleos.Filtrado = True
        Me.tbx_NumeroExt_Empleos.Location = New System.Drawing.Point(125, 179)
        Me.tbx_NumeroExt_Empleos.MaxLength = 6
        Me.tbx_NumeroExt_Empleos.Name = "tbx_NumeroExt_Empleos"
        Me.tbx_NumeroExt_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_NumeroExt_Empleos.TabIndex = 10
        Me.tbx_NumeroExt_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NumeroInt_Empleos
        '
        Me.tbx_NumeroInt_Empleos.Control_Siguiente = Nothing
        Me.tbx_NumeroInt_Empleos.Filtrado = True
        Me.tbx_NumeroInt_Empleos.Location = New System.Drawing.Point(389, 155)
        Me.tbx_NumeroInt_Empleos.MaxLength = 6
        Me.tbx_NumeroInt_Empleos.Name = "tbx_NumeroInt_Empleos"
        Me.tbx_NumeroInt_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_NumeroInt_Empleos.TabIndex = 9
        Me.tbx_NumeroInt_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_EntreCalle2Empleos
        '
        Me.lbl_EntreCalle2Empleos.AutoSize = True
        Me.lbl_EntreCalle2Empleos.Location = New System.Drawing.Point(279, 132)
        Me.lbl_EntreCalle2Empleos.Name = "lbl_EntreCalle2Empleos"
        Me.lbl_EntreCalle2Empleos.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2Empleos.TabIndex = 8
        Me.lbl_EntreCalle2Empleos.Text = "Y la Calle"
        '
        'tbx_EntreCalle1Empleos
        '
        Me.tbx_EntreCalle1Empleos.Control_Siguiente = Me.tbx_EntreCalle2Empleos
        Me.tbx_EntreCalle1Empleos.Filtrado = False
        Me.tbx_EntreCalle1Empleos.Location = New System.Drawing.Point(125, 155)
        Me.tbx_EntreCalle1Empleos.MaxLength = 100
        Me.tbx_EntreCalle1Empleos.Name = "tbx_EntreCalle1Empleos"
        Me.tbx_EntreCalle1Empleos.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle1Empleos.TabIndex = 8
        Me.tbx_EntreCalle1Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle1Empleos
        '
        Me.lbl_EntreCalle1Empleos.AutoSize = True
        Me.lbl_EntreCalle1Empleos.Location = New System.Drawing.Point(53, 158)
        Me.lbl_EntreCalle1Empleos.Name = "lbl_EntreCalle1Empleos"
        Me.lbl_EntreCalle1Empleos.Size = New System.Drawing.Size(69, 13)
        Me.lbl_EntreCalle1Empleos.TabIndex = 6
        Me.lbl_EntreCalle1Empleos.Text = "Entre la Calle"
        '
        'lbl_EmpresaSeguridad
        '
        Me.lbl_EmpresaSeguridad.AutoSize = True
        Me.lbl_EmpresaSeguridad.Location = New System.Drawing.Point(20, 267)
        Me.lbl_EmpresaSeguridad.Name = "lbl_EmpresaSeguridad"
        Me.lbl_EmpresaSeguridad.Size = New System.Drawing.Size(99, 13)
        Me.lbl_EmpresaSeguridad.TabIndex = 36
        Me.lbl_EmpresaSeguridad.Text = "Empresa Seguridad"
        '
        'gbx_EmpresaSeg
        '
        Me.gbx_EmpresaSeg.Controls.Add(Me.rdb_No_EmpresaSeg)
        Me.gbx_EmpresaSeg.Controls.Add(Me.rdb_Si_EmpresaSeg)
        Me.gbx_EmpresaSeg.Location = New System.Drawing.Point(125, 251)
        Me.gbx_EmpresaSeg.Name = "gbx_EmpresaSeg"
        Me.gbx_EmpresaSeg.Size = New System.Drawing.Size(86, 34)
        Me.gbx_EmpresaSeg.TabIndex = 37
        Me.gbx_EmpresaSeg.TabStop = False
        '
        'rdb_No_EmpresaSeg
        '
        Me.rdb_No_EmpresaSeg.AutoSize = True
        Me.rdb_No_EmpresaSeg.Location = New System.Drawing.Point(44, 12)
        Me.rdb_No_EmpresaSeg.Name = "rdb_No_EmpresaSeg"
        Me.rdb_No_EmpresaSeg.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_EmpresaSeg.TabIndex = 17
        Me.rdb_No_EmpresaSeg.Text = "No"
        Me.rdb_No_EmpresaSeg.UseVisualStyleBackColor = True
        '
        'rdb_Si_EmpresaSeg
        '
        Me.rdb_Si_EmpresaSeg.AutoSize = True
        Me.rdb_Si_EmpresaSeg.Location = New System.Drawing.Point(6, 12)
        Me.rdb_Si_EmpresaSeg.Name = "rdb_Si_EmpresaSeg"
        Me.rdb_Si_EmpresaSeg.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_EmpresaSeg.TabIndex = 16
        Me.rdb_Si_EmpresaSeg.Text = "Si"
        Me.rdb_Si_EmpresaSeg.UseVisualStyleBackColor = True
        '
        'lbl_PorteArmas
        '
        Me.lbl_PorteArmas.AutoSize = True
        Me.lbl_PorteArmas.Location = New System.Drawing.Point(322, 267)
        Me.lbl_PorteArmas.Name = "lbl_PorteArmas"
        Me.lbl_PorteArmas.Size = New System.Drawing.Size(64, 13)
        Me.lbl_PorteArmas.TabIndex = 39
        Me.lbl_PorteArmas.Text = "Porte Armas"
        '
        'gbx_PorteArmas
        '
        Me.gbx_PorteArmas.Controls.Add(Me.rdb_No_PorteArmas)
        Me.gbx_PorteArmas.Controls.Add(Me.rdb_Si_PorteArmas)
        Me.gbx_PorteArmas.Enabled = False
        Me.gbx_PorteArmas.Location = New System.Drawing.Point(392, 251)
        Me.gbx_PorteArmas.Name = "gbx_PorteArmas"
        Me.gbx_PorteArmas.Size = New System.Drawing.Size(83, 34)
        Me.gbx_PorteArmas.TabIndex = 40
        Me.gbx_PorteArmas.TabStop = False
        '
        'rdb_No_PorteArmas
        '
        Me.rdb_No_PorteArmas.AutoSize = True
        Me.rdb_No_PorteArmas.Location = New System.Drawing.Point(44, 12)
        Me.rdb_No_PorteArmas.Name = "rdb_No_PorteArmas"
        Me.rdb_No_PorteArmas.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_PorteArmas.TabIndex = 19
        Me.rdb_No_PorteArmas.Text = "No"
        Me.rdb_No_PorteArmas.UseVisualStyleBackColor = True
        '
        'rdb_Si_PorteArmas
        '
        Me.rdb_Si_PorteArmas.AutoSize = True
        Me.rdb_Si_PorteArmas.Location = New System.Drawing.Point(6, 12)
        Me.rdb_Si_PorteArmas.Name = "rdb_Si_PorteArmas"
        Me.rdb_Si_PorteArmas.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_PorteArmas.TabIndex = 18
        Me.rdb_Si_PorteArmas.Text = "Si"
        Me.rdb_Si_PorteArmas.UseVisualStyleBackColor = True
        '
        'lbl_ColoniaEmpleos
        '
        Me.lbl_ColoniaEmpleos.AutoSize = True
        Me.lbl_ColoniaEmpleos.Location = New System.Drawing.Point(80, 100)
        Me.lbl_ColoniaEmpleos.Name = "lbl_ColoniaEmpleos"
        Me.lbl_ColoniaEmpleos.Size = New System.Drawing.Size(42, 13)
        Me.lbl_ColoniaEmpleos.TabIndex = 15
        Me.lbl_ColoniaEmpleos.Text = "Colonia"
        '
        'Label79
        '
        Me.Label79.AutoSize = True
        Me.Label79.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label79.ForeColor = System.Drawing.Color.Red
        Me.Label79.Location = New System.Drawing.Point(710, 241)
        Me.Label79.Name = "Label79"
        Me.Label79.Size = New System.Drawing.Size(13, 16)
        Me.Label79.TabIndex = 53
        Me.Label79.Text = "*"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(974, 239)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 16)
        Me.Label12.TabIndex = 56
        Me.Label12.Text = "*"
        '
        'Label72
        '
        Me.Label72.AutoSize = True
        Me.Label72.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label72.ForeColor = System.Drawing.Color.Red
        Me.Label72.Location = New System.Drawing.Point(974, 215)
        Me.Label72.Name = "Label72"
        Me.Label72.Size = New System.Drawing.Size(13, 16)
        Me.Label72.TabIndex = 50
        Me.Label72.Text = "*"
        '
        'Label126
        '
        Me.Label126.AutoSize = True
        Me.Label126.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label126.ForeColor = System.Drawing.Color.Red
        Me.Label126.Location = New System.Drawing.Point(477, 263)
        Me.Label126.Name = "Label126"
        Me.Label126.Size = New System.Drawing.Size(13, 16)
        Me.Label126.TabIndex = 41
        Me.Label126.Text = "*"
        '
        'Label71
        '
        Me.Label71.AutoSize = True
        Me.Label71.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label71.ForeColor = System.Drawing.Color.Red
        Me.Label71.Location = New System.Drawing.Point(477, 233)
        Me.Label71.Name = "Label71"
        Me.Label71.Size = New System.Drawing.Size(13, 16)
        Me.Label71.TabIndex = 35
        Me.Label71.Text = "*"
        '
        'Label125
        '
        Me.Label125.AutoSize = True
        Me.Label125.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label125.ForeColor = System.Drawing.Color.Red
        Me.Label125.Location = New System.Drawing.Point(217, 264)
        Me.Label125.Name = "Label125"
        Me.Label125.Size = New System.Drawing.Size(13, 16)
        Me.Label125.TabIndex = 38
        Me.Label125.Text = "*"
        '
        'Label70
        '
        Me.Label70.AutoSize = True
        Me.Label70.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label70.ForeColor = System.Drawing.Color.Red
        Me.Label70.Location = New System.Drawing.Point(217, 231)
        Me.Label70.Name = "Label70"
        Me.Label70.Size = New System.Drawing.Size(13, 16)
        Me.Label70.TabIndex = 32
        Me.Label70.Text = "*"
        '
        'Label65
        '
        Me.Label65.AutoSize = True
        Me.Label65.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label65.ForeColor = System.Drawing.Color.Red
        Me.Label65.Location = New System.Drawing.Point(477, 182)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(13, 16)
        Me.Label65.TabIndex = 25
        Me.Label65.Text = "*"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(974, 191)
        Me.Label66.Name = "Label66"
        Me.Label66.Size = New System.Drawing.Size(13, 16)
        Me.Label66.TabIndex = 47
        Me.Label66.Text = "*"
        '
        'Label64
        '
        Me.Label64.AutoSize = True
        Me.Label64.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label64.ForeColor = System.Drawing.Color.Red
        Me.Label64.Location = New System.Drawing.Point(481, 292)
        Me.Label64.Name = "Label64"
        Me.Label64.Size = New System.Drawing.Size(13, 16)
        Me.Label64.TabIndex = 44
        Me.Label64.Text = "*"
        '
        'Label63
        '
        Me.Label63.AutoSize = True
        Me.Label63.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label63.ForeColor = System.Drawing.Color.Red
        Me.Label63.Location = New System.Drawing.Point(852, 265)
        Me.Label63.Name = "Label63"
        Me.Label63.Size = New System.Drawing.Size(13, 16)
        Me.Label63.TabIndex = 59
        Me.Label63.Text = "*"
        '
        'Label61
        '
        Me.Label61.AutoSize = True
        Me.Label61.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label61.ForeColor = System.Drawing.Color.Red
        Me.Label61.Location = New System.Drawing.Point(217, 183)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(13, 16)
        Me.Label61.TabIndex = 12
        Me.Label61.Text = "*"
        '
        'Label59
        '
        Me.Label59.AutoSize = True
        Me.Label59.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label59.ForeColor = System.Drawing.Color.Red
        Me.Label59.Location = New System.Drawing.Point(481, 21)
        Me.Label59.Name = "Label59"
        Me.Label59.Size = New System.Drawing.Size(13, 16)
        Me.Label59.TabIndex = 2
        Me.Label59.Text = "*"
        '
        'cmb_MotivoSeparacion
        '
        Me.cmb_MotivoSeparacion.Clave = Nothing
        Me.cmb_MotivoSeparacion.Control_Siguiente = Me.tbx_OtroMotivo
        Me.cmb_MotivoSeparacion.DisplayMember = "Descripcion"
        Me.cmb_MotivoSeparacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MotivoSeparacion.Empresa = False
        Me.cmb_MotivoSeparacion.Filtro = Nothing
        Me.cmb_MotivoSeparacion.FormattingEnabled = True
        Me.cmb_MotivoSeparacion.Location = New System.Drawing.Point(618, 264)
        Me.cmb_MotivoSeparacion.MaxDropDownItems = 20
        Me.cmb_MotivoSeparacion.Name = "cmb_MotivoSeparacion"
        Me.cmb_MotivoSeparacion.Pista = False
        Me.cmb_MotivoSeparacion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MotivoSeparacion.StoredProcedure = "Cat_MotivosBajaCombo_Get"
        Me.cmb_MotivoSeparacion.Sucursal = False
        Me.cmb_MotivoSeparacion.TabIndex = 25
        Me.cmb_MotivoSeparacion.Tipo = 0
        Me.cmb_MotivoSeparacion.ValueMember = "Id_MotivoB"
        '
        'tbx_OtroMotivo
        '
        Me.tbx_OtroMotivo.Control_Siguiente = Me.btn_Agregar_Empleos
        Me.tbx_OtroMotivo.Filtrado = True
        Me.tbx_OtroMotivo.Location = New System.Drawing.Point(618, 290)
        Me.tbx_OtroMotivo.MaxLength = 100
        Me.tbx_OtroMotivo.Name = "tbx_OtroMotivo"
        Me.tbx_OtroMotivo.Size = New System.Drawing.Size(350, 20)
        Me.tbx_OtroMotivo.TabIndex = 26
        Me.tbx_OtroMotivo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'btn_Agregar_Empleos
        '
        Me.btn_Agregar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Empleos.Location = New System.Drawing.Point(618, 316)
        Me.btn_Agregar_Empleos.Name = "btn_Agregar_Empleos"
        Me.btn_Agregar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Empleos.TabIndex = 27
        Me.btn_Agregar_Empleos.Text = "Agregar"
        Me.btn_Agregar_Empleos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Empleos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Empleos.UseVisualStyleBackColor = True
        '
        'cmb_Ciudades_Empleos
        '
        Me.cmb_Ciudades_Empleos.Clave = Nothing
        Me.cmb_Ciudades_Empleos.Control_Siguiente = Me.tbx_CodigoPostal_Empleos
        Me.cmb_Ciudades_Empleos.DisplayMember = "Nombre"
        Me.cmb_Ciudades_Empleos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudades_Empleos.Empresa = False
        Me.cmb_Ciudades_Empleos.Filtro = Nothing
        Me.cmb_Ciudades_Empleos.FormattingEnabled = True
        Me.cmb_Ciudades_Empleos.Location = New System.Drawing.Point(125, 73)
        Me.cmb_Ciudades_Empleos.MaxDropDownItems = 20
        Me.cmb_Ciudades_Empleos.Name = "cmb_Ciudades_Empleos"
        Me.cmb_Ciudades_Empleos.Pista = False
        Me.cmb_Ciudades_Empleos.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Ciudades_Empleos.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudades_Empleos.Sucursal = False
        Me.cmb_Ciudades_Empleos.TabIndex = 3
        Me.cmb_Ciudades_Empleos.Tipo = 0
        Me.cmb_Ciudades_Empleos.ValueMember = "id_Ciudad"
        '
        'dtp_FechaBaja_Empleos
        '
        Me.dtp_FechaBaja_Empleos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaBaja_Empleos.Location = New System.Drawing.Point(392, 231)
        Me.dtp_FechaBaja_Empleos.Name = "dtp_FechaBaja_Empleos"
        Me.dtp_FechaBaja_Empleos.Size = New System.Drawing.Size(83, 20)
        Me.dtp_FechaBaja_Empleos.TabIndex = 15
        Me.dtp_FechaBaja_Empleos.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Lbl_OtroMotEmpleos
        '
        Me.Lbl_OtroMotEmpleos.AutoSize = True
        Me.Lbl_OtroMotEmpleos.Location = New System.Drawing.Point(550, 293)
        Me.Lbl_OtroMotEmpleos.Name = "Lbl_OtroMotEmpleos"
        Me.Lbl_OtroMotEmpleos.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_OtroMotEmpleos.TabIndex = 60
        Me.Lbl_OtroMotEmpleos.Text = "Otro Motivo"
        '
        'Lbl_MotSepEmpleos
        '
        Me.Lbl_MotSepEmpleos.AutoSize = True
        Me.Lbl_MotSepEmpleos.Location = New System.Drawing.Point(501, 267)
        Me.Lbl_MotSepEmpleos.Name = "Lbl_MotSepEmpleos"
        Me.Lbl_MotSepEmpleos.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_MotSepEmpleos.TabIndex = 57
        Me.Lbl_MotSepEmpleos.Text = "Motivo de Separación"
        '
        'tbx_SueldoFinal_Empleos
        '
        Me.tbx_SueldoFinal_Empleos.Control_Siguiente = Me.cmb_MotivoSeparacion
        Me.tbx_SueldoFinal_Empleos.Filtrado = True
        Me.tbx_SueldoFinal_Empleos.Location = New System.Drawing.Point(882, 240)
        Me.tbx_SueldoFinal_Empleos.MaxLength = 6
        Me.tbx_SueldoFinal_Empleos.Name = "tbx_SueldoFinal_Empleos"
        Me.tbx_SueldoFinal_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_SueldoFinal_Empleos.TabIndex = 24
        Me.tbx_SueldoFinal_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_SueFinMenEmpleos
        '
        Me.Lbl_SueFinMenEmpleos.AutoSize = True
        Me.Lbl_SueFinMenEmpleos.Location = New System.Drawing.Point(768, 243)
        Me.Lbl_SueFinMenEmpleos.Name = "Lbl_SueFinMenEmpleos"
        Me.Lbl_SueFinMenEmpleos.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_SueFinMenEmpleos.TabIndex = 54
        Me.Lbl_SueFinMenEmpleos.Text = "Sueldo Final Mensual"
        '
        'tbx_SueldoInicial_Empleos
        '
        Me.tbx_SueldoInicial_Empleos.Control_Siguiente = Me.tbx_SueldoFinal_Empleos
        Me.tbx_SueldoInicial_Empleos.Filtrado = True
        Me.tbx_SueldoInicial_Empleos.Location = New System.Drawing.Point(618, 240)
        Me.tbx_SueldoInicial_Empleos.MaxLength = 6
        Me.tbx_SueldoInicial_Empleos.Name = "tbx_SueldoInicial_Empleos"
        Me.tbx_SueldoInicial_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_SueldoInicial_Empleos.TabIndex = 23
        Me.tbx_SueldoInicial_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_SueIniMenEmpleos
        '
        Me.Lbl_SueIniMenEmpleos.AutoSize = True
        Me.Lbl_SueIniMenEmpleos.Location = New System.Drawing.Point(499, 243)
        Me.Lbl_SueIniMenEmpleos.Name = "Lbl_SueIniMenEmpleos"
        Me.Lbl_SueIniMenEmpleos.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_SueIniMenEmpleos.TabIndex = 51
        Me.Lbl_SueIniMenEmpleos.Text = "Sueldo Inicial Mensual"
        '
        'Lbl_TelefonoEmpleados
        '
        Me.Lbl_TelefonoEmpleados.AutoSize = True
        Me.Lbl_TelefonoEmpleados.Location = New System.Drawing.Point(337, 184)
        Me.Lbl_TelefonoEmpleados.Name = "Lbl_TelefonoEmpleados"
        Me.Lbl_TelefonoEmpleados.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_TelefonoEmpleados.TabIndex = 23
        Me.Lbl_TelefonoEmpleados.Text = "Teléfono"
        '
        'tbx_PuestoJefe_Empleos
        '
        Me.tbx_PuestoJefe_Empleos.Control_Siguiente = Me.tbx_SueldoInicial_Empleos
        Me.tbx_PuestoJefe_Empleos.Filtrado = True
        Me.tbx_PuestoJefe_Empleos.Location = New System.Drawing.Point(618, 216)
        Me.tbx_PuestoJefe_Empleos.MaxLength = 100
        Me.tbx_PuestoJefe_Empleos.Name = "tbx_PuestoJefe_Empleos"
        Me.tbx_PuestoJefe_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_PuestoJefe_Empleos.TabIndex = 22
        Me.tbx_PuestoJefe_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_PueJefInmEmpleado
        '
        Me.Lbl_PueJefInmEmpleado.AutoSize = True
        Me.Lbl_PueJefInmEmpleado.Location = New System.Drawing.Point(500, 219)
        Me.Lbl_PueJefInmEmpleado.Name = "Lbl_PueJefInmEmpleado"
        Me.Lbl_PueJefInmEmpleado.Size = New System.Drawing.Size(112, 13)
        Me.Lbl_PueJefInmEmpleado.TabIndex = 48
        Me.Lbl_PueJefInmEmpleado.Text = "Puesto Jefe Inmediato"
        '
        'tbx_NombreJefe_Empleos
        '
        Me.tbx_NombreJefe_Empleos.Control_Siguiente = Me.tbx_PuestoJefe_Empleos
        Me.tbx_NombreJefe_Empleos.Filtrado = True
        Me.tbx_NombreJefe_Empleos.Location = New System.Drawing.Point(618, 192)
        Me.tbx_NombreJefe_Empleos.MaxLength = 50
        Me.tbx_NombreJefe_Empleos.Name = "tbx_NombreJefe_Empleos"
        Me.tbx_NombreJefe_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreJefe_Empleos.TabIndex = 21
        Me.tbx_NombreJefe_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_NomJefInmEmpleos
        '
        Me.Lbl_NomJefInmEmpleos.AutoSize = True
        Me.Lbl_NomJefInmEmpleos.Location = New System.Drawing.Point(496, 195)
        Me.Lbl_NomJefInmEmpleos.Name = "Lbl_NomJefInmEmpleos"
        Me.Lbl_NomJefInmEmpleos.Size = New System.Drawing.Size(116, 13)
        Me.Lbl_NomJefInmEmpleos.TabIndex = 45
        Me.Lbl_NomJefInmEmpleos.Text = "Nombre Jefe Inmediato"
        '
        'tbx_Puesto_Empleos
        '
        Me.tbx_Puesto_Empleos.Control_Siguiente = Me.tbx_NombreJefe_Empleos
        Me.tbx_Puesto_Empleos.Filtrado = True
        Me.tbx_Puesto_Empleos.Location = New System.Drawing.Point(125, 291)
        Me.tbx_Puesto_Empleos.MaxLength = 100
        Me.tbx_Puesto_Empleos.Name = "tbx_Puesto_Empleos"
        Me.tbx_Puesto_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Puesto_Empleos.TabIndex = 20
        Me.tbx_Puesto_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_PuestoEmpleados
        '
        Me.Lbl_PuestoEmpleados.AutoSize = True
        Me.Lbl_PuestoEmpleados.Location = New System.Drawing.Point(79, 294)
        Me.Lbl_PuestoEmpleados.Name = "Lbl_PuestoEmpleados"
        Me.Lbl_PuestoEmpleados.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoEmpleados.TabIndex = 42
        Me.Lbl_PuestoEmpleados.Text = "Puesto"
        '
        'lbl_FBaja
        '
        Me.lbl_FBaja.AutoSize = True
        Me.lbl_FBaja.Location = New System.Drawing.Point(325, 235)
        Me.lbl_FBaja.Name = "lbl_FBaja"
        Me.lbl_FBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FBaja.TabIndex = 33
        Me.lbl_FBaja.Text = "Fecha Baja"
        '
        'lbl_FIngreso
        '
        Me.lbl_FIngreso.AutoSize = True
        Me.lbl_FIngreso.Location = New System.Drawing.Point(44, 233)
        Me.lbl_FIngreso.Name = "lbl_FIngreso"
        Me.lbl_FIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FIngreso.TabIndex = 30
        Me.lbl_FIngreso.Text = "Fecha Ingreso"
        '
        'btn_Borrar_Empleos
        '
        Me.btn_Borrar_Empleos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Empleos.Enabled = False
        Me.btn_Borrar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Empleos.Location = New System.Drawing.Point(295, 654)
        Me.btn_Borrar_Empleos.Name = "btn_Borrar_Empleos"
        Me.btn_Borrar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Empleos.TabIndex = 31
        Me.btn_Borrar_Empleos.Text = "&Borrar"
        Me.btn_Borrar_Empleos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Empleos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Empleos.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Empleos
        '
        Me.btn_Cancelar_Empleos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Empleos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Empleos.Location = New System.Drawing.Point(736, 654)
        Me.btn_Cancelar_Empleos.Name = "btn_Cancelar_Empleos"
        Me.btn_Cancelar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Empleos.TabIndex = 33
        Me.btn_Cancelar_Empleos.Text = "&Cancelar"
        Me.btn_Cancelar_Empleos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Empleos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Empleos.UseVisualStyleBackColor = True
        '
        'btn_Modificar_Empleos
        '
        Me.btn_Modificar_Empleos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_Empleos.Enabled = False
        Me.btn_Modificar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_Empleos.Location = New System.Drawing.Point(149, 654)
        Me.btn_Modificar_Empleos.Name = "btn_Modificar_Empleos"
        Me.btn_Modificar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Empleos.TabIndex = 30
        Me.btn_Modificar_Empleos.Text = "&Modificar"
        Me.btn_Modificar_Empleos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Empleos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Empleos.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Empleos
        '
        Me.btn_Guardar_Empleos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Empleos.Enabled = False
        Me.btn_Guardar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Empleos.Location = New System.Drawing.Point(3, 654)
        Me.btn_Guardar_Empleos.Name = "btn_Guardar_Empleos"
        Me.btn_Guardar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Empleos.TabIndex = 29
        Me.btn_Guardar_Empleos.Text = "&Guardar"
        Me.btn_Guardar_Empleos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Empleos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Empleos.UseVisualStyleBackColor = True
        '
        'lsv_Empleos
        '
        Me.lsv_Empleos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Empleos.FullRowSelect = True
        Me.lsv_Empleos.HideSelection = False
        Me.lsv_Empleos.Location = New System.Drawing.Point(3, 352)
        ListViewColumnSorter37.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter37.SortColumn = 0
        Me.lsv_Empleos.Lvs = ListViewColumnSorter37
        Me.lsv_Empleos.MultiSelect = False
        Me.lsv_Empleos.Name = "lsv_Empleos"
        Me.lsv_Empleos.Row1 = 15
        Me.lsv_Empleos.Row10 = 6
        Me.lsv_Empleos.Row2 = 10
        Me.lsv_Empleos.Row3 = 10
        Me.lsv_Empleos.Row4 = 10
        Me.lsv_Empleos.Row5 = 6
        Me.lsv_Empleos.Row6 = 6
        Me.lsv_Empleos.Row7 = 6
        Me.lsv_Empleos.Row8 = 10
        Me.lsv_Empleos.Row9 = 8
        Me.lsv_Empleos.Size = New System.Drawing.Size(1517, 296)
        Me.lsv_Empleos.TabIndex = 28
        Me.lsv_Empleos.UseCompatibleStateImageBehavior = False
        Me.lsv_Empleos.View = System.Windows.Forms.View.Details
        '
        'Lbl_Cp_Empleados
        '
        Me.Lbl_Cp_Empleados.AutoSize = True
        Me.Lbl_Cp_Empleados.Location = New System.Drawing.Point(356, 103)
        Me.Lbl_Cp_Empleados.Name = "Lbl_Cp_Empleados"
        Me.Lbl_Cp_Empleados.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_Cp_Empleados.TabIndex = 20
        Me.Lbl_Cp_Empleados.Text = "C.P."
        '
        'Lbl_Ciudad_Empleos
        '
        Me.Lbl_Ciudad_Empleos.AutoSize = True
        Me.Lbl_Ciudad_Empleos.Location = New System.Drawing.Point(79, 76)
        Me.Lbl_Ciudad_Empleos.Name = "Lbl_Ciudad_Empleos"
        Me.Lbl_Ciudad_Empleos.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Ciudad_Empleos.TabIndex = 17
        Me.Lbl_Ciudad_Empleos.Text = "Ciudad"
        '
        'Lbl_NumeroInt_Empleos
        '
        Me.Lbl_NumeroInt_Empleos.AutoSize = True
        Me.Lbl_NumeroInt_Empleos.Location = New System.Drawing.Point(305, 158)
        Me.Lbl_NumeroInt_Empleos.Name = "Lbl_NumeroInt_Empleos"
        Me.Lbl_NumeroInt_Empleos.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_NumeroInt_Empleos.TabIndex = 13
        Me.Lbl_NumeroInt_Empleos.Text = "Número Interior"
        '
        'Lbl_NumeroExt_Empleos
        '
        Me.Lbl_NumeroExt_Empleos.AutoSize = True
        Me.Lbl_NumeroExt_Empleos.Location = New System.Drawing.Point(40, 185)
        Me.Lbl_NumeroExt_Empleos.Name = "Lbl_NumeroExt_Empleos"
        Me.Lbl_NumeroExt_Empleos.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NumeroExt_Empleos.TabIndex = 10
        Me.Lbl_NumeroExt_Empleos.Text = "Número Exterior"
        '
        'tbx_Calle_Empleos
        '
        Me.tbx_Calle_Empleos.Control_Siguiente = Me.tbx_EntreCalle1Empleos
        Me.tbx_Calle_Empleos.Filtrado = True
        Me.tbx_Calle_Empleos.Location = New System.Drawing.Point(125, 129)
        Me.tbx_Calle_Empleos.MaxLength = 50
        Me.tbx_Calle_Empleos.Name = "tbx_Calle_Empleos"
        Me.tbx_Calle_Empleos.Size = New System.Drawing.Size(148, 20)
        Me.tbx_Calle_Empleos.TabIndex = 6
        Me.tbx_Calle_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_CalleE
        '
        Me.Lbl_CalleE.AutoSize = True
        Me.Lbl_CalleE.Location = New System.Drawing.Point(92, 136)
        Me.Lbl_CalleE.Name = "Lbl_CalleE"
        Me.Lbl_CalleE.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_CalleE.TabIndex = 3
        Me.Lbl_CalleE.Text = "Calle"
        '
        'tbx_NombreEmpresa_Empleos
        '
        Me.tbx_NombreEmpresa_Empleos.Control_Siguiente = Me.tbx_Calle_Empleos
        Me.tbx_NombreEmpresa_Empleos.Filtrado = True
        Me.tbx_NombreEmpresa_Empleos.Location = New System.Drawing.Point(125, 20)
        Me.tbx_NombreEmpresa_Empleos.MaxLength = 100
        Me.tbx_NombreEmpresa_Empleos.Name = "tbx_NombreEmpresa_Empleos"
        Me.tbx_NombreEmpresa_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreEmpresa_Empleos.TabIndex = 1
        Me.tbx_NombreEmpresa_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Lbl_NombreEmpE
        '
        Me.Lbl_NombreEmpE.AutoSize = True
        Me.Lbl_NombreEmpE.Location = New System.Drawing.Point(31, 23)
        Me.Lbl_NombreEmpE.Name = "Lbl_NombreEmpE"
        Me.Lbl_NombreEmpE.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_NombreEmpE.TabIndex = 0
        Me.Lbl_NombreEmpE.Text = "Nombre Empresa"
        '
        'tab_Referencias
        '
        Me.tab_Referencias.Controls.Add(Me.btn_InvestigacionPersonal)
        Me.tab_Referencias.Controls.Add(Me.Label36)
        Me.tab_Referencias.Controls.Add(Me.Label33)
        Me.tab_Referencias.Controls.Add(Me.Label34)
        Me.tab_Referencias.Controls.Add(Me.Label35)
        Me.tab_Referencias.Controls.Add(Me.txt_am)
        Me.tab_Referencias.Controls.Add(Me.txt_ap)
        Me.tab_Referencias.Controls.Add(Me.Label23)
        Me.tab_Referencias.Controls.Add(Me.cmb_ocupacion)
        Me.tab_Referencias.Controls.Add(Me.tbx_Colonias_Referencias)
        Me.tab_Referencias.Controls.Add(Me.cmb_Paises_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Label9)
        Me.tab_Referencias.Controls.Add(Me.lbl_Colonia_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_EntreCalle2_Referencias)
        Me.tab_Referencias.Controls.Add(Me.lbl_EntreCalle2_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_EntreCalle1_Referencias)
        Me.tab_Referencias.Controls.Add(Me.lbl_EntreCalle1_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Label68)
        Me.tab_Referencias.Controls.Add(Me.tbx_Telefono_Referencias)
        Me.tab_Referencias.Controls.Add(Me.lbl_Telefono_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Label39)
        Me.tab_Referencias.Controls.Add(Me.Label38)
        Me.tab_Referencias.Controls.Add(Me.Label30)
        Me.tab_Referencias.Controls.Add(Me.cmb_Ciudades_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Borrar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Cancelar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Modificar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Agregar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Guardar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.lsv_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_CodigoPostal_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_NumeroInt_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_NumeroExt_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CpR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CiudadR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_NumIntR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_NunExtR)
        Me.tab_Referencias.Controls.Add(Me.tbx_Calle_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CalleR)
        Me.tab_Referencias.Controls.Add(Me.tbx_Ocupacion_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Lbl_OcupacionR)
        Me.tab_Referencias.Controls.Add(Me.gbx_Genero_Referencias)
        Me.tab_Referencias.Controls.Add(Me.tbx_Nombre_Referencia)
        Me.tab_Referencias.Controls.Add(Me.lbl_NombreReferencia)
        Me.tab_Referencias.Controls.Add(Me.cmb_TipoReferencia)
        Me.tab_Referencias.Controls.Add(Me.lbl_TipoReferencia)
        Me.tab_Referencias.Location = New System.Drawing.Point(4, 22)
        Me.tab_Referencias.Name = "tab_Referencias"
        Me.tab_Referencias.Size = New System.Drawing.Size(1523, 687)
        Me.tab_Referencias.TabIndex = 5
        Me.tab_Referencias.Text = "Referencias"
        Me.tab_Referencias.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Red
        Me.Label36.Location = New System.Drawing.Point(482, 74)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 16)
        Me.Label36.TabIndex = 38
        Me.Label36.Text = "*"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Red
        Me.Label33.Location = New System.Drawing.Point(247, 72)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(13, 16)
        Me.Label33.TabIndex = 37
        Me.Label33.Text = "*"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(266, 74)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(46, 13)
        Me.Label34.TabIndex = 36
        Me.Label34.Text = "Materno"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(14, 73)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 13)
        Me.Label35.TabIndex = 35
        Me.Label35.Text = "Apellido Paterno"
        Me.Label35.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'txt_am
        '
        Me.txt_am.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_am.Control_Siguiente = Me.cmb_Departamento_DG
        Me.txt_am.Filtrado = True
        Me.txt_am.Location = New System.Drawing.Point(318, 71)
        Me.txt_am.MaxLength = 30
        Me.txt_am.Name = "txt_am"
        Me.txt_am.Size = New System.Drawing.Size(158, 20)
        Me.txt_am.TabIndex = 4
        Me.txt_am.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'txt_ap
        '
        Me.txt_ap.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ap.Control_Siguiente = Me.txt_am
        Me.txt_ap.Filtrado = True
        Me.txt_ap.Location = New System.Drawing.Point(104, 70)
        Me.txt_ap.MaxLength = 30
        Me.txt_ap.Name = "txt_ap"
        Me.txt_ap.Size = New System.Drawing.Size(141, 20)
        Me.txt_ap.TabIndex = 3
        Me.txt_ap.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(482, 95)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 16)
        Me.Label23.TabIndex = 32
        Me.Label23.Text = "*"
        '
        'cmb_ocupacion
        '
        Me.cmb_ocupacion.Clave = Nothing
        Me.cmb_ocupacion.Control_Siguiente = Me.tbx_Nombre_Referencia
        Me.cmb_ocupacion.DisplayMember = "Nombre"
        Me.cmb_ocupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ocupacion.Empresa = False
        Me.cmb_ocupacion.Filtro = Nothing
        Me.cmb_ocupacion.FormattingEnabled = True
        Me.cmb_ocupacion.ItemHeight = 13
        Me.cmb_ocupacion.Location = New System.Drawing.Point(104, 94)
        Me.cmb_ocupacion.MaxDropDownItems = 20
        Me.cmb_ocupacion.Name = "cmb_ocupacion"
        Me.cmb_ocupacion.Pista = False
        Me.cmb_ocupacion.Size = New System.Drawing.Size(372, 21)
        Me.cmb_ocupacion.StoredProcedure = "Cat_OcupacionRefSSPCombo_Get"
        Me.cmb_ocupacion.Sucursal = False
        Me.cmb_ocupacion.TabIndex = 5
        Me.cmb_ocupacion.Tipo = 0
        Me.cmb_ocupacion.ValueMember = "Id_OcupacionSSP"
        '
        'tbx_Nombre_Referencia
        '
        Me.tbx_Nombre_Referencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.tbx_Nombre_Referencia.Control_Siguiente = Me.rdb_Masculino_Referencias
        Me.tbx_Nombre_Referencia.Filtrado = True
        Me.tbx_Nombre_Referencia.Location = New System.Drawing.Point(104, 45)
        Me.tbx_Nombre_Referencia.MaxLength = 50
        Me.tbx_Nombre_Referencia.Name = "tbx_Nombre_Referencia"
        Me.tbx_Nombre_Referencia.Size = New System.Drawing.Size(372, 20)
        Me.tbx_Nombre_Referencia.TabIndex = 2
        Me.tbx_Nombre_Referencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'rdb_Masculino_Referencias
        '
        Me.rdb_Masculino_Referencias.AutoSize = True
        Me.rdb_Masculino_Referencias.Location = New System.Drawing.Point(12, 14)
        Me.rdb_Masculino_Referencias.Name = "rdb_Masculino_Referencias"
        Me.rdb_Masculino_Referencias.Size = New System.Drawing.Size(73, 17)
        Me.rdb_Masculino_Referencias.TabIndex = 6
        Me.rdb_Masculino_Referencias.Text = "Masculino"
        Me.rdb_Masculino_Referencias.UseVisualStyleBackColor = True
        '
        'tbx_Colonias_Referencias
        '
        Me.tbx_Colonias_Referencias.Location = New System.Drawing.Point(102, 186)
        Me.tbx_Colonias_Referencias.Name = "tbx_Colonias_Referencias"
        Me.tbx_Colonias_Referencias.Size = New System.Drawing.Size(182, 20)
        Me.tbx_Colonias_Referencias.TabIndex = 9
        '
        'cmb_Paises_Referencias
        '
        Me.cmb_Paises_Referencias.Clave = Nothing
        Me.cmb_Paises_Referencias.Control_Siguiente = Me.tbx_CodigoPostal_Empleos
        Me.cmb_Paises_Referencias.DisplayMember = "Nombre"
        Me.cmb_Paises_Referencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Paises_Referencias.Empresa = False
        Me.cmb_Paises_Referencias.Filtro = Nothing
        Me.cmb_Paises_Referencias.FormattingEnabled = True
        Me.cmb_Paises_Referencias.Location = New System.Drawing.Point(102, 160)
        Me.cmb_Paises_Referencias.MaxDropDownItems = 20
        Me.cmb_Paises_Referencias.Name = "cmb_Paises_Referencias"
        Me.cmb_Paises_Referencias.Pista = False
        Me.cmb_Paises_Referencias.Size = New System.Drawing.Size(183, 21)
        Me.cmb_Paises_Referencias.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Paises_Referencias.Sucursal = False
        Me.cmb_Paises_Referencias.TabIndex = 7
        Me.cmb_Paises_Referencias.Tipo = 0
        Me.cmb_Paises_Referencias.ValueMember = "Id_Pais"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(69, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(27, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Pais"
        '
        'lbl_Colonia_Referencias
        '
        Me.lbl_Colonia_Referencias.AutoSize = True
        Me.lbl_Colonia_Referencias.Location = New System.Drawing.Point(56, 189)
        Me.lbl_Colonia_Referencias.Name = "lbl_Colonia_Referencias"
        Me.lbl_Colonia_Referencias.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia_Referencias.TabIndex = 20
        Me.lbl_Colonia_Referencias.Text = "Colonia"
        '
        'tbx_EntreCalle2_Referencias
        '
        Me.tbx_EntreCalle2_Referencias.Control_Siguiente = Nothing
        Me.tbx_EntreCalle2_Referencias.Filtrado = False
        Me.tbx_EntreCalle2_Referencias.Location = New System.Drawing.Point(307, 236)
        Me.tbx_EntreCalle2_Referencias.MaxLength = 100
        Me.tbx_EntreCalle2_Referencias.Name = "tbx_EntreCalle2_Referencias"
        Me.tbx_EntreCalle2_Referencias.Size = New System.Drawing.Size(169, 20)
        Me.tbx_EntreCalle2_Referencias.TabIndex = 13
        Me.tbx_EntreCalle2_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle2_Referencias
        '
        Me.lbl_EntreCalle2_Referencias.AutoSize = True
        Me.lbl_EntreCalle2_Referencias.Location = New System.Drawing.Point(250, 239)
        Me.lbl_EntreCalle2_Referencias.Name = "lbl_EntreCalle2_Referencias"
        Me.lbl_EntreCalle2_Referencias.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2_Referencias.TabIndex = 14
        Me.lbl_EntreCalle2_Referencias.Text = "Y la Calle"
        '
        'tbx_EntreCalle1_Referencias
        '
        Me.tbx_EntreCalle1_Referencias.Control_Siguiente = Nothing
        Me.tbx_EntreCalle1_Referencias.Filtrado = False
        Me.tbx_EntreCalle1_Referencias.Location = New System.Drawing.Point(102, 236)
        Me.tbx_EntreCalle1_Referencias.MaxLength = 100
        Me.tbx_EntreCalle1_Referencias.Name = "tbx_EntreCalle1_Referencias"
        Me.tbx_EntreCalle1_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle1_Referencias.TabIndex = 12
        Me.tbx_EntreCalle1_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle1_Referencias
        '
        Me.lbl_EntreCalle1_Referencias.AutoSize = True
        Me.lbl_EntreCalle1_Referencias.Location = New System.Drawing.Point(27, 239)
        Me.lbl_EntreCalle1_Referencias.Name = "lbl_EntreCalle1_Referencias"
        Me.lbl_EntreCalle1_Referencias.Size = New System.Drawing.Size(69, 13)
        Me.lbl_EntreCalle1_Referencias.TabIndex = 12
        Me.lbl_EntreCalle1_Referencias.Text = "Entre la Calle"
        '
        'Label68
        '
        Me.Label68.AutoSize = True
        Me.Label68.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label68.ForeColor = System.Drawing.Color.Red
        Me.Label68.Location = New System.Drawing.Point(247, 283)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(13, 16)
        Me.Label68.TabIndex = 30
        Me.Label68.Text = "*"
        '
        'tbx_Telefono_Referencias
        '
        Me.tbx_Telefono_Referencias.Control_Siguiente = Me.cmb_Ciudades_Referencias
        Me.tbx_Telefono_Referencias.Filtrado = True
        Me.tbx_Telefono_Referencias.Location = New System.Drawing.Point(102, 282)
        Me.tbx_Telefono_Referencias.MaxLength = 25
        Me.tbx_Telefono_Referencias.Name = "tbx_Telefono_Referencias"
        Me.tbx_Telefono_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_Telefono_Referencias.TabIndex = 16
        Me.tbx_Telefono_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'cmb_Ciudades_Referencias
        '
        Me.cmb_Ciudades_Referencias.Clave = Nothing
        Me.cmb_Ciudades_Referencias.Control_Siguiente = Me.tbx_CodigoPostal_Referencias
        Me.cmb_Ciudades_Referencias.DisplayMember = "Nombre"
        Me.cmb_Ciudades_Referencias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ciudades_Referencias.Empresa = False
        Me.cmb_Ciudades_Referencias.Filtro = Nothing
        Me.cmb_Ciudades_Referencias.FormattingEnabled = True
        Me.cmb_Ciudades_Referencias.Location = New System.Drawing.Point(350, 160)
        Me.cmb_Ciudades_Referencias.MaxDropDownItems = 20
        Me.cmb_Ciudades_Referencias.Name = "cmb_Ciudades_Referencias"
        Me.cmb_Ciudades_Referencias.Pista = False
        Me.cmb_Ciudades_Referencias.Size = New System.Drawing.Size(126, 21)
        Me.cmb_Ciudades_Referencias.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudades_Referencias.Sucursal = False
        Me.cmb_Ciudades_Referencias.TabIndex = 8
        Me.cmb_Ciudades_Referencias.Tipo = 0
        Me.cmb_Ciudades_Referencias.ValueMember = "id_Ciudad"
        '
        'tbx_CodigoPostal_Referencias
        '
        Me.tbx_CodigoPostal_Referencias.Control_Siguiente = Me.btn_Agregar_Referencias
        Me.tbx_CodigoPostal_Referencias.Filtrado = True
        Me.tbx_CodigoPostal_Referencias.Location = New System.Drawing.Point(350, 186)
        Me.tbx_CodigoPostal_Referencias.MaxLength = 6
        Me.tbx_CodigoPostal_Referencias.Name = "tbx_CodigoPostal_Referencias"
        Me.tbx_CodigoPostal_Referencias.Size = New System.Drawing.Size(126, 20)
        Me.tbx_CodigoPostal_Referencias.TabIndex = 10
        Me.tbx_CodigoPostal_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Agregar_Referencias
        '
        Me.btn_Agregar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Referencias.Location = New System.Drawing.Point(362, 286)
        Me.btn_Agregar_Referencias.Name = "btn_Agregar_Referencias"
        Me.btn_Agregar_Referencias.Size = New System.Drawing.Size(114, 30)
        Me.btn_Agregar_Referencias.TabIndex = 17
        Me.btn_Agregar_Referencias.Text = "Agregar"
        Me.btn_Agregar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Referencias.UseVisualStyleBackColor = True
        '
        'lbl_Telefono_Referencias
        '
        Me.lbl_Telefono_Referencias.AutoSize = True
        Me.lbl_Telefono_Referencias.Location = New System.Drawing.Point(47, 285)
        Me.lbl_Telefono_Referencias.Name = "lbl_Telefono_Referencias"
        Me.lbl_Telefono_Referencias.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono_Referencias.TabIndex = 28
        Me.lbl_Telefono_Referencias.Text = "Teléfono"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(290, 134)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(13, 16)
        Me.Label39.TabIndex = 7
        Me.Label39.Text = "*"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(482, 46)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 16)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "*"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label30.ForeColor = System.Drawing.Color.Red
        Me.Label30.Location = New System.Drawing.Point(292, 21)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(13, 16)
        Me.Label30.TabIndex = 2
        Me.Label30.Text = "*"
        '
        'btn_Borrar_Referencias
        '
        Me.btn_Borrar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Referencias.Enabled = False
        Me.btn_Borrar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Referencias.Location = New System.Drawing.Point(295, 654)
        Me.btn_Borrar_Referencias.Name = "btn_Borrar_Referencias"
        Me.btn_Borrar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Referencias.TabIndex = 18
        Me.btn_Borrar_Referencias.Text = "&Borrar"
        Me.btn_Borrar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Referencias
        '
        Me.btn_Cancelar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Referencias.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Referencias.Location = New System.Drawing.Point(589, 654)
        Me.btn_Cancelar_Referencias.Name = "btn_Cancelar_Referencias"
        Me.btn_Cancelar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Referencias.TabIndex = 19
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
        Me.btn_Modificar_Referencias.Location = New System.Drawing.Point(149, 654)
        Me.btn_Modificar_Referencias.Name = "btn_Modificar_Referencias"
        Me.btn_Modificar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Referencias.TabIndex = 17
        Me.btn_Modificar_Referencias.Text = "&Modificar"
        Me.btn_Modificar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Referencias
        '
        Me.btn_Guardar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Referencias.Enabled = False
        Me.btn_Guardar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Referencias.Location = New System.Drawing.Point(3, 654)
        Me.btn_Guardar_Referencias.Name = "btn_Guardar_Referencias"
        Me.btn_Guardar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Referencias.TabIndex = 16
        Me.btn_Guardar_Referencias.Text = "&Guardar"
        Me.btn_Guardar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Referencias.UseVisualStyleBackColor = True
        '
        'lsv_Referencias
        '
        Me.lsv_Referencias.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Referencias.FullRowSelect = True
        Me.lsv_Referencias.HideSelection = False
        Me.lsv_Referencias.Location = New System.Drawing.Point(3, 322)
        ListViewColumnSorter31.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter31.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter31
        Me.lsv_Referencias.MultiSelect = False
        Me.lsv_Referencias.Name = "lsv_Referencias"
        Me.lsv_Referencias.Row1 = 10
        Me.lsv_Referencias.Row10 = 7
        Me.lsv_Referencias.Row2 = 15
        Me.lsv_Referencias.Row3 = 4
        Me.lsv_Referencias.Row4 = 14
        Me.lsv_Referencias.Row5 = 14
        Me.lsv_Referencias.Row6 = 6
        Me.lsv_Referencias.Row7 = 6
        Me.lsv_Referencias.Row8 = 6
        Me.lsv_Referencias.Row9 = 14
        Me.lsv_Referencias.Size = New System.Drawing.Size(1517, 326)
        Me.lsv_Referencias.TabIndex = 18
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'tbx_NumeroInt_Referencias
        '
        Me.tbx_NumeroInt_Referencias.Control_Siguiente = Me.tbx_Telefono_Referencias
        Me.tbx_NumeroInt_Referencias.Filtrado = True
        Me.tbx_NumeroInt_Referencias.Location = New System.Drawing.Point(340, 260)
        Me.tbx_NumeroInt_Referencias.MaxLength = 10
        Me.tbx_NumeroInt_Referencias.Name = "tbx_NumeroInt_Referencias"
        Me.tbx_NumeroInt_Referencias.Size = New System.Drawing.Size(136, 20)
        Me.tbx_NumeroInt_Referencias.TabIndex = 15
        Me.tbx_NumeroInt_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroExt_Referencias
        '
        Me.tbx_NumeroExt_Referencias.Control_Siguiente = Me.tbx_NumeroInt_Referencias
        Me.tbx_NumeroExt_Referencias.Filtrado = True
        Me.tbx_NumeroExt_Referencias.Location = New System.Drawing.Point(102, 260)
        Me.tbx_NumeroExt_Referencias.MaxLength = 10
        Me.tbx_NumeroExt_Referencias.Name = "tbx_NumeroExt_Referencias"
        Me.tbx_NumeroExt_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_NumeroExt_Referencias.TabIndex = 14
        Me.tbx_NumeroExt_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_CpR
        '
        Me.Lbl_CpR.AutoSize = True
        Me.Lbl_CpR.Location = New System.Drawing.Point(314, 190)
        Me.Lbl_CpR.Name = "Lbl_CpR"
        Me.Lbl_CpR.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_CpR.TabIndex = 26
        Me.Lbl_CpR.Text = "C.P."
        '
        'Lbl_CiudadR
        '
        Me.Lbl_CiudadR.AutoSize = True
        Me.Lbl_CiudadR.Location = New System.Drawing.Point(304, 163)
        Me.Lbl_CiudadR.Name = "Lbl_CiudadR"
        Me.Lbl_CiudadR.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_CiudadR.TabIndex = 24
        Me.Lbl_CiudadR.Text = "Ciudad"
        '
        'Lbl_NumIntR
        '
        Me.Lbl_NumIntR.AutoSize = True
        Me.Lbl_NumIntR.Location = New System.Drawing.Point(250, 267)
        Me.Lbl_NumIntR.Name = "Lbl_NumIntR"
        Me.Lbl_NumIntR.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NumIntR.TabIndex = 18
        Me.Lbl_NumIntR.Text = "Número interior"
        '
        'Lbl_NunExtR
        '
        Me.Lbl_NunExtR.AutoSize = True
        Me.Lbl_NunExtR.Location = New System.Drawing.Point(14, 263)
        Me.Lbl_NunExtR.Name = "Lbl_NunExtR"
        Me.Lbl_NunExtR.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NunExtR.TabIndex = 16
        Me.Lbl_NunExtR.Text = "Número Exterior"
        '
        'tbx_Calle_Referencias
        '
        Me.tbx_Calle_Referencias.Control_Siguiente = Me.tbx_NumeroExt_Referencias
        Me.tbx_Calle_Referencias.Filtrado = True
        Me.tbx_Calle_Referencias.Location = New System.Drawing.Point(102, 212)
        Me.tbx_Calle_Referencias.MaxLength = 50
        Me.tbx_Calle_Referencias.Name = "tbx_Calle_Referencias"
        Me.tbx_Calle_Referencias.Size = New System.Drawing.Size(374, 20)
        Me.tbx_Calle_Referencias.TabIndex = 11
        Me.tbx_Calle_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_CalleR
        '
        Me.Lbl_CalleR.AutoSize = True
        Me.Lbl_CalleR.Location = New System.Drawing.Point(66, 215)
        Me.Lbl_CalleR.Name = "Lbl_CalleR"
        Me.Lbl_CalleR.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_CalleR.TabIndex = 10
        Me.Lbl_CalleR.Text = "Calle"
        '
        'tbx_Ocupacion_Referencias
        '
        Me.tbx_Ocupacion_Referencias.Control_Siguiente = Me.tbx_Calle_Referencias
        Me.tbx_Ocupacion_Referencias.Filtrado = True
        Me.tbx_Ocupacion_Referencias.Location = New System.Drawing.Point(510, 94)
        Me.tbx_Ocupacion_Referencias.MaxLength = 50
        Me.tbx_Ocupacion_Referencias.Name = "tbx_Ocupacion_Referencias"
        Me.tbx_Ocupacion_Referencias.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Ocupacion_Referencias.TabIndex = 0
        Me.tbx_Ocupacion_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        Me.tbx_Ocupacion_Referencias.Visible = False
        '
        'Lbl_OcupacionR
        '
        Me.Lbl_OcupacionR.AutoSize = True
        Me.Lbl_OcupacionR.Location = New System.Drawing.Point(39, 94)
        Me.Lbl_OcupacionR.Name = "Lbl_OcupacionR"
        Me.Lbl_OcupacionR.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_OcupacionR.TabIndex = 8
        Me.Lbl_OcupacionR.Text = "Ocupación"
        '
        'gbx_Genero_Referencias
        '
        Me.gbx_Genero_Referencias.Controls.Add(Me.rdb_Masculino_Referencias)
        Me.gbx_Genero_Referencias.Controls.Add(Me.rdb_Femenino_Referencias)
        Me.gbx_Genero_Referencias.Location = New System.Drawing.Point(102, 117)
        Me.gbx_Genero_Referencias.Name = "gbx_Genero_Referencias"
        Me.gbx_Genero_Referencias.Size = New System.Drawing.Size(182, 37)
        Me.gbx_Genero_Referencias.TabIndex = 6
        Me.gbx_Genero_Referencias.TabStop = False
        Me.gbx_Genero_Referencias.Text = "Género"
        '
        'rdb_Femenino_Referencias
        '
        Me.rdb_Femenino_Referencias.AutoSize = True
        Me.rdb_Femenino_Referencias.Location = New System.Drawing.Point(91, 14)
        Me.rdb_Femenino_Referencias.Name = "rdb_Femenino_Referencias"
        Me.rdb_Femenino_Referencias.Size = New System.Drawing.Size(71, 17)
        Me.rdb_Femenino_Referencias.TabIndex = 5
        Me.rdb_Femenino_Referencias.Text = "Femenino"
        Me.rdb_Femenino_Referencias.UseVisualStyleBackColor = True
        '
        'lbl_NombreReferencia
        '
        Me.lbl_NombreReferencia.AutoSize = True
        Me.lbl_NombreReferencia.Location = New System.Drawing.Point(7, 48)
        Me.lbl_NombreReferencia.Name = "lbl_NombreReferencia"
        Me.lbl_NombreReferencia.Size = New System.Drawing.Size(91, 13)
        Me.lbl_NombreReferencia.TabIndex = 3
        Me.lbl_NombreReferencia.Text = "Nombre Completo"
        '
        'cmb_TipoReferencia
        '
        Me.cmb_TipoReferencia.Clave = Nothing
        Me.cmb_TipoReferencia.Control_Siguiente = Me.tbx_Nombre_Referencia
        Me.cmb_TipoReferencia.DisplayMember = "Descripcion"
        Me.cmb_TipoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoReferencia.Empresa = False
        Me.cmb_TipoReferencia.Filtro = Nothing
        Me.cmb_TipoReferencia.FormattingEnabled = True
        Me.cmb_TipoReferencia.Location = New System.Drawing.Point(104, 20)
        Me.cmb_TipoReferencia.MaxDropDownItems = 20
        Me.cmb_TipoReferencia.Name = "cmb_TipoReferencia"
        Me.cmb_TipoReferencia.Pista = False
        Me.cmb_TipoReferencia.Size = New System.Drawing.Size(182, 21)
        Me.cmb_TipoReferencia.StoredProcedure = "Cat_TipoReferenciaCombo_Get"
        Me.cmb_TipoReferencia.Sucursal = False
        Me.cmb_TipoReferencia.TabIndex = 1
        Me.cmb_TipoReferencia.Tipo = 0
        Me.cmb_TipoReferencia.ValueMember = "Id_TipoReferencia"
        '
        'lbl_TipoReferencia
        '
        Me.lbl_TipoReferencia.AutoSize = True
        Me.lbl_TipoReferencia.Location = New System.Drawing.Point(15, 23)
        Me.lbl_TipoReferencia.Name = "lbl_TipoReferencia"
        Me.lbl_TipoReferencia.Size = New System.Drawing.Size(83, 13)
        Me.lbl_TipoReferencia.TabIndex = 0
        Me.lbl_TipoReferencia.Text = "Tipo Referencia"
        '
        'tab_DatosVarios
        '
        Me.tab_DatosVarios.Controls.Add(Me.cmb_cantidad)
        Me.tab_DatosVarios.Controls.Add(Me.btn_refionesSSP)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_region)
        Me.tab_DatosVarios.Controls.Add(Me.Label32)
        Me.tab_DatosVarios.Controls.Add(Me.Label31)
        Me.tab_DatosVarios.Controls.Add(Me.Label27)
        Me.tab_DatosVarios.Controls.Add(Me.Label25)
        Me.tab_DatosVarios.Controls.Add(Me.Label26)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_vista)
        Me.tab_DatosVarios.Controls.Add(Me.Label24)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_lado)
        Me.tab_DatosVarios.Controls.Add(Me.Label153)
        Me.tab_DatosVarios.Controls.Add(Me.Label152)
        Me.tab_DatosVarios.Controls.Add(Me.Label76)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Comentarios_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Comentarios_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.Label124)
        Me.tab_DatosVarios.Controls.Add(Me.Label119)
        Me.tab_DatosVarios.Controls.Add(Me.Label29)
        Me.tab_DatosVarios.Controls.Add(Me.Label28)
        Me.tab_DatosVarios.Controls.Add(Me.Lbl_Ejemplo2DV)
        Me.tab_DatosVarios.Controls.Add(Me.Lbl_EjemploDV)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Borrar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Cancelar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Modificar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Agregar_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.lsv_SeñasParticulares)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_CantidadSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_CantidadSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.Label62)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_UbicacionSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_UbicacionSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_FormaSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_FormaSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_SeñasParticulares)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Habilidades)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Habilidades)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_ActividadesCulturales)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_ActivCulturales)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Idiomas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Idiomas)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Vicios)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Vicios)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_ValorVehiculo)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_ValorVehiculo)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Modelo)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Modelo)
        Me.tab_DatosVarios.Controls.Add(Me.gbx_VehiculoPropio)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_ValorVivienda)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_ValorVivienda)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_PagoMensual)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_PagoMensual)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_TipoVivienda)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_TipoVivienda)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_Descripcion_IngresoAdicional)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_DescripcionIA)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_GastoFamiliar)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_GastoFamiliar)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_IngresoAdicional)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_IngresoFamiliar)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_IngresoAdicional)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_IngresoFamiliar)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Guardar_DatosVarios)
        Me.tab_DatosVarios.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosVarios.Name = "tab_DatosVarios"
        Me.tab_DatosVarios.Size = New System.Drawing.Size(1523, 687)
        Me.tab_DatosVarios.TabIndex = 6
        Me.tab_DatosVarios.Text = "Datos Varios"
        Me.tab_DatosVarios.UseVisualStyleBackColor = True
        '
        'cmb_cantidad
        '
        Me.cmb_cantidad.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_cantidad.DisplayMember = "display"
        Me.cmb_cantidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_cantidad.FormattingEnabled = True
        Me.cmb_cantidad.Location = New System.Drawing.Point(184, 390)
        Me.cmb_cantidad.MaxDropDownItems = 20
        Me.cmb_cantidad.Name = "cmb_cantidad"
        Me.cmb_cantidad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_cantidad.TabIndex = 131
        Me.cmb_cantidad.ValueMember = "value"
        '
        'btn_refionesSSP
        '
        Me.btn_refionesSSP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_refionesSSP.Location = New System.Drawing.Point(295, 363)
        Me.btn_refionesSSP.Name = "btn_refionesSSP"
        Me.btn_refionesSSP.Size = New System.Drawing.Size(117, 21)
        Me.btn_refionesSSP.TabIndex = 130
        Me.btn_refionesSSP.Text = "Ver regiones"
        Me.btn_refionesSSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refionesSSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refionesSSP.UseVisualStyleBackColor = True
        '
        'cmb_region
        '
        Me.cmb_region.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_region.DisplayMember = "display"
        Me.cmb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_region.FormattingEnabled = True
        Me.cmb_region.Location = New System.Drawing.Point(184, 362)
        Me.cmb_region.MaxDropDownItems = 20
        Me.cmb_region.Name = "cmb_region"
        Me.cmb_region.Size = New System.Drawing.Size(86, 21)
        Me.cmb_region.TabIndex = 129
        Me.cmb_region.ValueMember = "value"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(418, 391)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 16)
        Me.Label32.TabIndex = 127
        Me.Label32.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(418, 309)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 16)
        Me.Label31.TabIndex = 126
        Me.Label31.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(276, 363)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 16)
        Me.Label27.TabIndex = 125
        Me.Label27.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(137, 363)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 123
        Me.Label25.Text = "Region"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(142, 365)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 13)
        Me.Label26.TabIndex = 124
        '
        'cmb_vista
        '
        Me.cmb_vista.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_vista.DisplayMember = "display"
        Me.cmb_vista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_vista.FormattingEnabled = True
        Me.cmb_vista.Location = New System.Drawing.Point(184, 308)
        Me.cmb_vista.MaxDropDownItems = 20
        Me.cmb_vista.Name = "cmb_vista"
        Me.cmb_vista.Size = New System.Drawing.Size(228, 21)
        Me.cmb_vista.TabIndex = 121
        Me.cmb_vista.ValueMember = "value"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(149, 311)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 120
        Me.Label24.Text = "Vista"
        '
        'cmb_lado
        '
        Me.cmb_lado.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_lado.DisplayMember = "display"
        Me.cmb_lado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_lado.FormattingEnabled = True
        Me.cmb_lado.Location = New System.Drawing.Point(184, 335)
        Me.cmb_lado.MaxDropDownItems = 20
        Me.cmb_lado.Name = "cmb_lado"
        Me.cmb_lado.Size = New System.Drawing.Size(228, 21)
        Me.cmb_lado.TabIndex = 119
        Me.cmb_lado.ValueMember = "value"
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label153.ForeColor = System.Drawing.Color.Red
        Me.Label153.Location = New System.Drawing.Point(418, 340)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(13, 16)
        Me.Label153.TabIndex = 118
        Me.Label153.Text = "*"
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label152.ForeColor = System.Drawing.Color.Red
        Me.Label152.Location = New System.Drawing.Point(540, 415)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(13, 16)
        Me.Label152.TabIndex = 118
        Me.Label152.Text = "*"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Red
        Me.Label76.Location = New System.Drawing.Point(418, 284)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(13, 16)
        Me.Label76.TabIndex = 118
        Me.Label76.Text = "*"
        '
        'tbx_Comentarios_Señas
        '
        Me.tbx_Comentarios_Señas.Control_Siguiente = Me.btn_Agregar_Señas
        Me.tbx_Comentarios_Señas.Filtrado = True
        Me.tbx_Comentarios_Señas.Location = New System.Drawing.Point(184, 439)
        Me.tbx_Comentarios_Señas.MaxLength = 50
        Me.tbx_Comentarios_Señas.Name = "tbx_Comentarios_Señas"
        Me.tbx_Comentarios_Señas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Comentarios_Señas.TabIndex = 19
        Me.tbx_Comentarios_Señas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'btn_Agregar_Señas
        '
        Me.btn_Agregar_Señas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Señas.Location = New System.Drawing.Point(556, 433)
        Me.btn_Agregar_Señas.Name = "btn_Agregar_Señas"
        Me.btn_Agregar_Señas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Señas.TabIndex = 21
        Me.btn_Agregar_Señas.Text = "Agregar"
        Me.btn_Agregar_Señas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Señas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Señas.UseVisualStyleBackColor = True
        '
        'lbl_Comentarios_Señas
        '
        Me.lbl_Comentarios_Señas.AutoSize = True
        Me.lbl_Comentarios_Señas.Location = New System.Drawing.Point(114, 442)
        Me.lbl_Comentarios_Señas.Name = "lbl_Comentarios_Señas"
        Me.lbl_Comentarios_Señas.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Comentarios_Señas.TabIndex = 37
        Me.lbl_Comentarios_Señas.Text = "Comentarios"
        '
        'Label124
        '
        Me.Label124.AutoSize = True
        Me.Label124.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label124.ForeColor = System.Drawing.Color.Red
        Me.Label124.Location = New System.Drawing.Point(346, 149)
        Me.Label124.Name = "Label124"
        Me.Label124.Size = New System.Drawing.Size(13, 16)
        Me.Label124.TabIndex = 11
        Me.Label124.Text = "*"
        '
        'Label119
        '
        Me.Label119.AutoSize = True
        Me.Label119.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label119.ForeColor = System.Drawing.Color.Red
        Me.Label119.Location = New System.Drawing.Point(346, 152)
        Me.Label119.Name = "Label119"
        Me.Label119.Size = New System.Drawing.Size(13, 16)
        Me.Label119.TabIndex = 11
        Me.Label119.Text = "*"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Red
        Me.Label29.Location = New System.Drawing.Point(418, 89)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(13, 16)
        Me.Label29.TabIndex = 11
        Me.Label29.Text = "*"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Red
        Me.Label28.Location = New System.Drawing.Point(276, 17)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(13, 16)
        Me.Label28.TabIndex = 2
        Me.Label28.Text = "*"
        '
        'Lbl_Ejemplo2DV
        '
        Me.Lbl_Ejemplo2DV.AutoSize = True
        Me.Lbl_Ejemplo2DV.Location = New System.Drawing.Point(540, 262)
        Me.Lbl_Ejemplo2DV.Name = "Lbl_Ejemplo2DV"
        Me.Lbl_Ejemplo2DV.Size = New System.Drawing.Size(268, 13)
        Me.Lbl_Ejemplo2DV.TabIndex = 30
        Me.Lbl_Ejemplo2DV.Text = "(Ejemplo: Computación,75:Carpintería,50;Mecánica,75)"
        '
        'Lbl_EjemploDV
        '
        Me.Lbl_EjemploDV.AutoSize = True
        Me.Lbl_EjemploDV.Location = New System.Drawing.Point(540, 214)
        Me.Lbl_EjemploDV.Name = "Lbl_EjemploDV"
        Me.Lbl_EjemploDV.Size = New System.Drawing.Size(219, 13)
        Me.Lbl_EjemploDV.TabIndex = 25
        Me.Lbl_EjemploDV.Text = "(Ejemplo: Inglés,100;Francés,50;Japonés,75)"
        '
        'btn_Borrar_DatosVarios
        '
        Me.btn_Borrar_DatosVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosVarios.Enabled = False
        Me.btn_Borrar_DatosVarios.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosVarios.Location = New System.Drawing.Point(295, 654)
        Me.btn_Borrar_DatosVarios.Name = "btn_Borrar_DatosVarios"
        Me.btn_Borrar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_DatosVarios.TabIndex = 25
        Me.btn_Borrar_DatosVarios.Text = "&Borrar"
        Me.btn_Borrar_DatosVarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_DatosVarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_DatosVarios.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_DatosVarios
        '
        Me.btn_Cancelar_DatosVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_DatosVarios.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DatosVarios.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DatosVarios.Location = New System.Drawing.Point(441, 654)
        Me.btn_Cancelar_DatosVarios.Name = "btn_Cancelar_DatosVarios"
        Me.btn_Cancelar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DatosVarios.TabIndex = 26
        Me.btn_Cancelar_DatosVarios.Text = "&Cancelar"
        Me.btn_Cancelar_DatosVarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DatosVarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DatosVarios.UseVisualStyleBackColor = True
        '
        'btn_Modificar_DatosVarios
        '
        Me.btn_Modificar_DatosVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_DatosVarios.Enabled = False
        Me.btn_Modificar_DatosVarios.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_DatosVarios.Location = New System.Drawing.Point(149, 654)
        Me.btn_Modificar_DatosVarios.Name = "btn_Modificar_DatosVarios"
        Me.btn_Modificar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_DatosVarios.TabIndex = 24
        Me.btn_Modificar_DatosVarios.Text = "&Modificar"
        Me.btn_Modificar_DatosVarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_DatosVarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_DatosVarios.UseVisualStyleBackColor = True
        '
        'lsv_SeñasParticulares
        '
        Me.lsv_SeñasParticulares.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_SeñasParticulares.FullRowSelect = True
        Me.lsv_SeñasParticulares.HideSelection = False
        Me.lsv_SeñasParticulares.Location = New System.Drawing.Point(3, 468)
        ListViewColumnSorter38.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter38.SortColumn = 0
        Me.lsv_SeñasParticulares.Lvs = ListViewColumnSorter38
        Me.lsv_SeñasParticulares.MultiSelect = False
        Me.lsv_SeñasParticulares.Name = "lsv_SeñasParticulares"
        Me.lsv_SeñasParticulares.Row1 = 10
        Me.lsv_SeñasParticulares.Row10 = 0
        Me.lsv_SeñasParticulares.Row2 = 15
        Me.lsv_SeñasParticulares.Row3 = 15
        Me.lsv_SeñasParticulares.Row4 = 15
        Me.lsv_SeñasParticulares.Row5 = 10
        Me.lsv_SeñasParticulares.Row6 = 15
        Me.lsv_SeñasParticulares.Row7 = 20
        Me.lsv_SeñasParticulares.Row8 = 0
        Me.lsv_SeñasParticulares.Row9 = 0
        Me.lsv_SeñasParticulares.Size = New System.Drawing.Size(1517, 180)
        Me.lsv_SeñasParticulares.TabIndex = 22
        Me.lsv_SeñasParticulares.UseCompatibleStateImageBehavior = False
        Me.lsv_SeñasParticulares.View = System.Windows.Forms.View.Details
        '
        'tbx_CantidadSeñas
        '
        Me.tbx_CantidadSeñas.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_CantidadSeñas.Filtrado = True
        Me.tbx_CantidadSeñas.Location = New System.Drawing.Point(448, 386)
        Me.tbx_CantidadSeñas.MaxLength = 2
        Me.tbx_CantidadSeñas.Name = "tbx_CantidadSeñas"
        Me.tbx_CantidadSeñas.Size = New System.Drawing.Size(86, 20)
        Me.tbx_CantidadSeñas.TabIndex = 20
        Me.tbx_CantidadSeñas.TabStop = False
        Me.tbx_CantidadSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tbx_CantidadSeñas.Visible = False
        '
        'lbl_CantidadSeñas
        '
        Me.lbl_CantidadSeñas.AutoSize = True
        Me.lbl_CantidadSeñas.Location = New System.Drawing.Point(129, 393)
        Me.lbl_CantidadSeñas.Name = "lbl_CantidadSeñas"
        Me.lbl_CantidadSeñas.Size = New System.Drawing.Size(49, 13)
        Me.lbl_CantidadSeñas.TabIndex = 39
        Me.lbl_CantidadSeñas.Text = "Cantidad"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(142, 395)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(0, 13)
        Me.Label62.TabIndex = 114
        '
        'tbx_UbicacionSeñas
        '
        Me.tbx_UbicacionSeñas.Control_Siguiente = Me.tbx_Comentarios_Señas
        Me.tbx_UbicacionSeñas.Filtrado = True
        Me.tbx_UbicacionSeñas.Location = New System.Drawing.Point(448, 308)
        Me.tbx_UbicacionSeñas.MaxLength = 50
        Me.tbx_UbicacionSeñas.Name = "tbx_UbicacionSeñas"
        Me.tbx_UbicacionSeñas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_UbicacionSeñas.TabIndex = 18
        Me.tbx_UbicacionSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        Me.tbx_UbicacionSeñas.Visible = False
        '
        'lbl_UbicacionSeñas
        '
        Me.lbl_UbicacionSeñas.AutoSize = True
        Me.lbl_UbicacionSeñas.Location = New System.Drawing.Point(147, 340)
        Me.lbl_UbicacionSeñas.Name = "lbl_UbicacionSeñas"
        Me.lbl_UbicacionSeñas.Size = New System.Drawing.Size(31, 13)
        Me.lbl_UbicacionSeñas.TabIndex = 35
        Me.lbl_UbicacionSeñas.Text = "Lado"
        '
        'tbx_FormaSeñas
        '
        Me.tbx_FormaSeñas.Control_Siguiente = Me.tbx_UbicacionSeñas
        Me.tbx_FormaSeñas.Filtrado = True
        Me.tbx_FormaSeñas.Location = New System.Drawing.Point(184, 414)
        Me.tbx_FormaSeñas.MaxLength = 50
        Me.tbx_FormaSeñas.Name = "tbx_FormaSeñas"
        Me.tbx_FormaSeñas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_FormaSeñas.TabIndex = 17
        Me.tbx_FormaSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_FormaSeñas
        '
        Me.lbl_FormaSeñas.AutoSize = True
        Me.lbl_FormaSeñas.Location = New System.Drawing.Point(142, 417)
        Me.lbl_FormaSeñas.Name = "lbl_FormaSeñas"
        Me.lbl_FormaSeñas.Size = New System.Drawing.Size(36, 13)
        Me.lbl_FormaSeñas.TabIndex = 33
        Me.lbl_FormaSeñas.Text = "Forma"
        '
        'cmb_SeñasParticulares
        '
        Me.cmb_SeñasParticulares.Clave = Nothing
        Me.cmb_SeñasParticulares.Control_Siguiente = Me.tbx_FormaSeñas
        Me.cmb_SeñasParticulares.DisplayMember = "Descripcion"
        Me.cmb_SeñasParticulares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SeñasParticulares.Empresa = False
        Me.cmb_SeñasParticulares.Filtro = Nothing
        Me.cmb_SeñasParticulares.FormattingEnabled = True
        Me.cmb_SeñasParticulares.Location = New System.Drawing.Point(184, 283)
        Me.cmb_SeñasParticulares.MaxDropDownItems = 20
        Me.cmb_SeñasParticulares.Name = "cmb_SeñasParticulares"
        Me.cmb_SeñasParticulares.Pista = False
        Me.cmb_SeñasParticulares.Size = New System.Drawing.Size(228, 21)
        Me.cmb_SeñasParticulares.StoredProcedure = "Cat_TipoSenasCombo_Get"
        Me.cmb_SeñasParticulares.Sucursal = False
        Me.cmb_SeñasParticulares.TabIndex = 16
        Me.cmb_SeñasParticulares.Tipo = 0
        Me.cmb_SeñasParticulares.ValueMember = "Id_TipoSena"
        '
        'lbl_Señas
        '
        Me.lbl_Señas.AutoSize = True
        Me.lbl_Señas.Location = New System.Drawing.Point(107, 286)
        Me.lbl_Señas.Name = "lbl_Señas"
        Me.lbl_Señas.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Señas.TabIndex = 31
        Me.lbl_Señas.Text = "Tipo de señal"
        '
        'tbx_Habilidades
        '
        Me.tbx_Habilidades.Control_Siguiente = Me.cmb_SeñasParticulares
        Me.tbx_Habilidades.Filtrado = True
        Me.tbx_Habilidades.Location = New System.Drawing.Point(184, 259)
        Me.tbx_Habilidades.MaxLength = 50
        Me.tbx_Habilidades.Name = "tbx_Habilidades"
        Me.tbx_Habilidades.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Habilidades.TabIndex = 15
        Me.tbx_Habilidades.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Habilidades
        '
        Me.lbl_Habilidades.AutoSize = True
        Me.lbl_Habilidades.Location = New System.Drawing.Point(9, 262)
        Me.lbl_Habilidades.Name = "lbl_Habilidades"
        Me.lbl_Habilidades.Size = New System.Drawing.Size(169, 13)
        Me.lbl_Habilidades.TabIndex = 28
        Me.lbl_Habilidades.Text = "Habilidades o Aptitudes/%Dominio"
        '
        'tbx_ActividadesCulturales
        '
        Me.tbx_ActividadesCulturales.Control_Siguiente = Me.tbx_Habilidades
        Me.tbx_ActividadesCulturales.Filtrado = True
        Me.tbx_ActividadesCulturales.Location = New System.Drawing.Point(184, 235)
        Me.tbx_ActividadesCulturales.MaxLength = 50
        Me.tbx_ActividadesCulturales.Name = "tbx_ActividadesCulturales"
        Me.tbx_ActividadesCulturales.Size = New System.Drawing.Size(350, 20)
        Me.tbx_ActividadesCulturales.TabIndex = 14
        Me.tbx_ActividadesCulturales.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_ActivCulturales
        '
        Me.lbl_ActivCulturales.AutoSize = True
        Me.lbl_ActivCulturales.Location = New System.Drawing.Point(11, 238)
        Me.lbl_ActivCulturales.Name = "lbl_ActivCulturales"
        Me.lbl_ActivCulturales.Size = New System.Drawing.Size(167, 13)
        Me.lbl_ActivCulturales.TabIndex = 26
        Me.lbl_ActivCulturales.Text = "Actividades Culturales/Deportivas"
        '
        'tbx_Idiomas
        '
        Me.tbx_Idiomas.Control_Siguiente = Me.tbx_ActividadesCulturales
        Me.tbx_Idiomas.Filtrado = True
        Me.tbx_Idiomas.Location = New System.Drawing.Point(184, 211)
        Me.tbx_Idiomas.MaxLength = 50
        Me.tbx_Idiomas.Name = "tbx_Idiomas"
        Me.tbx_Idiomas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Idiomas.TabIndex = 13
        Me.tbx_Idiomas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Idiomas
        '
        Me.lbl_Idiomas.AutoSize = True
        Me.lbl_Idiomas.Location = New System.Drawing.Point(81, 214)
        Me.lbl_Idiomas.Name = "lbl_Idiomas"
        Me.lbl_Idiomas.Size = New System.Drawing.Size(97, 13)
        Me.lbl_Idiomas.TabIndex = 23
        Me.lbl_Idiomas.Text = "Idiomas/ %Dominio"
        '
        'tbx_Vicios
        '
        Me.tbx_Vicios.Control_Siguiente = Me.tbx_Idiomas
        Me.tbx_Vicios.Filtrado = True
        Me.tbx_Vicios.Location = New System.Drawing.Point(184, 187)
        Me.tbx_Vicios.MaxLength = 50
        Me.tbx_Vicios.Name = "tbx_Vicios"
        Me.tbx_Vicios.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Vicios.TabIndex = 12
        Me.tbx_Vicios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_Vicios
        '
        Me.lbl_Vicios.AutoSize = True
        Me.lbl_Vicios.Location = New System.Drawing.Point(143, 190)
        Me.lbl_Vicios.Name = "lbl_Vicios"
        Me.lbl_Vicios.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Vicios.TabIndex = 21
        Me.lbl_Vicios.Text = "Vicios"
        '
        'tbx_ValorVehiculo
        '
        Me.tbx_ValorVehiculo.Control_Siguiente = Me.tbx_Vicios
        Me.tbx_ValorVehiculo.Enabled = False
        Me.tbx_ValorVehiculo.Filtrado = True
        Me.tbx_ValorVehiculo.Location = New System.Drawing.Point(448, 161)
        Me.tbx_ValorVehiculo.MaxLength = 10
        Me.tbx_ValorVehiculo.Name = "tbx_ValorVehiculo"
        Me.tbx_ValorVehiculo.Size = New System.Drawing.Size(86, 20)
        Me.tbx_ValorVehiculo.TabIndex = 11
        Me.tbx_ValorVehiculo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_ValorVehiculo
        '
        Me.lbl_ValorVehiculo.AutoSize = True
        Me.lbl_ValorVehiculo.Location = New System.Drawing.Point(365, 164)
        Me.lbl_ValorVehiculo.Name = "lbl_ValorVehiculo"
        Me.lbl_ValorVehiculo.Size = New System.Drawing.Size(77, 13)
        Me.lbl_ValorVehiculo.TabIndex = 19
        Me.lbl_ValorVehiculo.Text = "Valor Vehículo"
        '
        'tbx_Modelo
        '
        Me.tbx_Modelo.Control_Siguiente = Me.tbx_ValorVehiculo
        Me.tbx_Modelo.Enabled = False
        Me.tbx_Modelo.Filtrado = True
        Me.tbx_Modelo.Location = New System.Drawing.Point(448, 137)
        Me.tbx_Modelo.MaxLength = 4
        Me.tbx_Modelo.Name = "tbx_Modelo"
        Me.tbx_Modelo.Size = New System.Drawing.Size(86, 20)
        Me.tbx_Modelo.TabIndex = 10
        Me.tbx_Modelo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Modelo
        '
        Me.lbl_Modelo.AutoSize = True
        Me.lbl_Modelo.Location = New System.Drawing.Point(372, 140)
        Me.lbl_Modelo.Name = "lbl_Modelo"
        Me.lbl_Modelo.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Modelo.TabIndex = 17
        Me.lbl_Modelo.Text = "Modelo (Año)"
        '
        'gbx_VehiculoPropio
        '
        Me.gbx_VehiculoPropio.Controls.Add(Me.rdb_No_Vehiculo)
        Me.gbx_VehiculoPropio.Controls.Add(Me.rdb_Si_Vehiculo)
        Me.gbx_VehiculoPropio.Location = New System.Drawing.Point(184, 137)
        Me.gbx_VehiculoPropio.Name = "gbx_VehiculoPropio"
        Me.gbx_VehiculoPropio.Size = New System.Drawing.Size(156, 37)
        Me.gbx_VehiculoPropio.TabIndex = 16
        Me.gbx_VehiculoPropio.TabStop = False
        Me.gbx_VehiculoPropio.Text = "Vehículo Propio"
        '
        'rdb_No_Vehiculo
        '
        Me.rdb_No_Vehiculo.AutoSize = True
        Me.rdb_No_Vehiculo.Location = New System.Drawing.Point(97, 15)
        Me.rdb_No_Vehiculo.Name = "rdb_No_Vehiculo"
        Me.rdb_No_Vehiculo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_Vehiculo.TabIndex = 8
        Me.rdb_No_Vehiculo.Text = "No"
        Me.rdb_No_Vehiculo.UseVisualStyleBackColor = True
        '
        'rdb_Si_Vehiculo
        '
        Me.rdb_Si_Vehiculo.AutoSize = True
        Me.rdb_Si_Vehiculo.Location = New System.Drawing.Point(18, 15)
        Me.rdb_Si_Vehiculo.Name = "rdb_Si_Vehiculo"
        Me.rdb_Si_Vehiculo.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_Vehiculo.TabIndex = 7
        Me.rdb_Si_Vehiculo.Text = "Si"
        Me.rdb_Si_Vehiculo.UseVisualStyleBackColor = True
        '
        'tbx_ValorVivienda
        '
        Me.tbx_ValorVivienda.Control_Siguiente = Me.rdb_Si_Vehiculo
        Me.tbx_ValorVivienda.Filtrado = True
        Me.tbx_ValorVivienda.Location = New System.Drawing.Point(448, 113)
        Me.tbx_ValorVivienda.MaxLength = 10
        Me.tbx_ValorVivienda.Name = "tbx_ValorVivienda"
        Me.tbx_ValorVivienda.Size = New System.Drawing.Size(86, 20)
        Me.tbx_ValorVivienda.TabIndex = 9
        Me.tbx_ValorVivienda.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_ValorVivienda
        '
        Me.lbl_ValorVivienda.AutoSize = True
        Me.lbl_ValorVivienda.Location = New System.Drawing.Point(367, 116)
        Me.lbl_ValorVivienda.Name = "lbl_ValorVivienda"
        Me.lbl_ValorVivienda.Size = New System.Drawing.Size(75, 13)
        Me.lbl_ValorVivienda.TabIndex = 14
        Me.lbl_ValorVivienda.Text = "Valor Vivienda"
        '
        'tbx_PagoMensual
        '
        Me.tbx_PagoMensual.Control_Siguiente = Me.tbx_ValorVivienda
        Me.tbx_PagoMensual.Filtrado = True
        Me.tbx_PagoMensual.Location = New System.Drawing.Point(184, 113)
        Me.tbx_PagoMensual.MaxLength = 10
        Me.tbx_PagoMensual.Name = "tbx_PagoMensual"
        Me.tbx_PagoMensual.Size = New System.Drawing.Size(86, 20)
        Me.tbx_PagoMensual.TabIndex = 6
        Me.tbx_PagoMensual.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_PagoMensual
        '
        Me.lbl_PagoMensual.AutoSize = True
        Me.lbl_PagoMensual.Location = New System.Drawing.Point(103, 116)
        Me.lbl_PagoMensual.Name = "lbl_PagoMensual"
        Me.lbl_PagoMensual.Size = New System.Drawing.Size(75, 13)
        Me.lbl_PagoMensual.TabIndex = 12
        Me.lbl_PagoMensual.Text = "Pago Mensual"
        '
        'cmb_TipoVivienda
        '
        Me.cmb_TipoVivienda.Clave = Nothing
        Me.cmb_TipoVivienda.Control_Siguiente = Me.tbx_PagoMensual
        Me.cmb_TipoVivienda.DisplayMember = "Descripcion"
        Me.cmb_TipoVivienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoVivienda.Empresa = False
        Me.cmb_TipoVivienda.Filtro = Nothing
        Me.cmb_TipoVivienda.FormattingEnabled = True
        Me.cmb_TipoVivienda.Location = New System.Drawing.Point(184, 88)
        Me.cmb_TipoVivienda.MaxDropDownItems = 20
        Me.cmb_TipoVivienda.Name = "cmb_TipoVivienda"
        Me.cmb_TipoVivienda.Pista = False
        Me.cmb_TipoVivienda.Size = New System.Drawing.Size(228, 21)
        Me.cmb_TipoVivienda.StoredProcedure = "Cat_TipoViviendaCombo_Get"
        Me.cmb_TipoVivienda.Sucursal = False
        Me.cmb_TipoVivienda.TabIndex = 5
        Me.cmb_TipoVivienda.Tipo = 0
        Me.cmb_TipoVivienda.ValueMember = "Id_TipoVivienda"
        '
        'lbl_TipoVivienda
        '
        Me.lbl_TipoVivienda.AutoSize = True
        Me.lbl_TipoVivienda.Location = New System.Drawing.Point(106, 91)
        Me.lbl_TipoVivienda.Name = "lbl_TipoVivienda"
        Me.lbl_TipoVivienda.Size = New System.Drawing.Size(72, 13)
        Me.lbl_TipoVivienda.TabIndex = 9
        Me.lbl_TipoVivienda.Text = "Tipo Vivienda"
        '
        'tbx_Descripcion_IngresoAdicional
        '
        Me.tbx_Descripcion_IngresoAdicional.Control_Siguiente = Me.cmb_TipoVivienda
        Me.tbx_Descripcion_IngresoAdicional.Filtrado = True
        Me.tbx_Descripcion_IngresoAdicional.Location = New System.Drawing.Point(184, 64)
        Me.tbx_Descripcion_IngresoAdicional.MaxLength = 50
        Me.tbx_Descripcion_IngresoAdicional.Name = "tbx_Descripcion_IngresoAdicional"
        Me.tbx_Descripcion_IngresoAdicional.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Descripcion_IngresoAdicional.TabIndex = 4
        Me.tbx_Descripcion_IngresoAdicional.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_DescripcionIA
        '
        Me.lbl_DescripcionIA.AutoSize = True
        Me.lbl_DescripcionIA.Location = New System.Drawing.Point(115, 67)
        Me.lbl_DescripcionIA.Name = "lbl_DescripcionIA"
        Me.lbl_DescripcionIA.Size = New System.Drawing.Size(63, 13)
        Me.lbl_DescripcionIA.TabIndex = 7
        Me.lbl_DescripcionIA.Text = "Descripción"
        '
        'tbx_GastoFamiliar
        '
        Me.tbx_GastoFamiliar.Control_Siguiente = Me.tbx_IngresoAdicional
        Me.tbx_GastoFamiliar.Filtrado = True
        Me.tbx_GastoFamiliar.Location = New System.Drawing.Point(448, 16)
        Me.tbx_GastoFamiliar.MaxLength = 10
        Me.tbx_GastoFamiliar.Name = "tbx_GastoFamiliar"
        Me.tbx_GastoFamiliar.Size = New System.Drawing.Size(86, 20)
        Me.tbx_GastoFamiliar.TabIndex = 2
        Me.tbx_GastoFamiliar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_IngresoAdicional
        '
        Me.tbx_IngresoAdicional.Control_Siguiente = Me.tbx_Descripcion_IngresoAdicional
        Me.tbx_IngresoAdicional.Filtrado = True
        Me.tbx_IngresoAdicional.Location = New System.Drawing.Point(184, 40)
        Me.tbx_IngresoAdicional.MaxLength = 10
        Me.tbx_IngresoAdicional.Name = "tbx_IngresoAdicional"
        Me.tbx_IngresoAdicional.Size = New System.Drawing.Size(86, 20)
        Me.tbx_IngresoAdicional.TabIndex = 3
        Me.tbx_IngresoAdicional.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_GastoFamiliar
        '
        Me.lbl_GastoFamiliar.AutoSize = True
        Me.lbl_GastoFamiliar.Location = New System.Drawing.Point(326, 19)
        Me.lbl_GastoFamiliar.Name = "lbl_GastoFamiliar"
        Me.lbl_GastoFamiliar.Size = New System.Drawing.Size(116, 13)
        Me.lbl_GastoFamiliar.TabIndex = 3
        Me.lbl_GastoFamiliar.Text = "Gasto Familiar Mensual"
        '
        'tbx_IngresoFamiliar
        '
        Me.tbx_IngresoFamiliar.Control_Siguiente = Me.tbx_GastoFamiliar
        Me.tbx_IngresoFamiliar.Filtrado = True
        Me.tbx_IngresoFamiliar.Location = New System.Drawing.Point(184, 16)
        Me.tbx_IngresoFamiliar.MaxLength = 10
        Me.tbx_IngresoFamiliar.Name = "tbx_IngresoFamiliar"
        Me.tbx_IngresoFamiliar.Size = New System.Drawing.Size(86, 20)
        Me.tbx_IngresoFamiliar.TabIndex = 1
        Me.tbx_IngresoFamiliar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_IngresoAdicional
        '
        Me.lbl_IngresoAdicional.AutoSize = True
        Me.lbl_IngresoAdicional.Location = New System.Drawing.Point(91, 43)
        Me.lbl_IngresoAdicional.Name = "lbl_IngresoAdicional"
        Me.lbl_IngresoAdicional.Size = New System.Drawing.Size(88, 13)
        Me.lbl_IngresoAdicional.TabIndex = 5
        Me.lbl_IngresoAdicional.Text = "Ingreso Adicional"
        '
        'lbl_IngresoFamiliar
        '
        Me.lbl_IngresoFamiliar.AutoSize = True
        Me.lbl_IngresoFamiliar.Location = New System.Drawing.Point(55, 19)
        Me.lbl_IngresoFamiliar.Name = "lbl_IngresoFamiliar"
        Me.lbl_IngresoFamiliar.Size = New System.Drawing.Size(123, 13)
        Me.lbl_IngresoFamiliar.TabIndex = 0
        Me.lbl_IngresoFamiliar.Text = "Ingreso Familiar Mensual"
        '
        'btn_Guardar_DatosVarios
        '
        Me.btn_Guardar_DatosVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_DatosVarios.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_DatosVarios.Location = New System.Drawing.Point(3, 654)
        Me.btn_Guardar_DatosVarios.Name = "btn_Guardar_DatosVarios"
        Me.btn_Guardar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DatosVarios.TabIndex = 23
        Me.btn_Guardar_DatosVarios.Text = "&Guardar"
        Me.btn_Guardar_DatosVarios.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_DatosVarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_DatosVarios.UseVisualStyleBackColor = True
        '
        'tab_PapeleriaRecibida
        '
        Me.tab_PapeleriaRecibida.Controls.Add(Me.btn_DoctosCancelar)
        Me.tab_PapeleriaRecibida.Controls.Add(Me.btn_DoctosImportar)
        Me.tab_PapeleriaRecibida.Controls.Add(Me.lsv_PapeleriaRecibida)
        Me.tab_PapeleriaRecibida.Controls.Add(Me.btn_Guardar_PapeleriaRecibida)
        Me.tab_PapeleriaRecibida.Location = New System.Drawing.Point(4, 22)
        Me.tab_PapeleriaRecibida.Name = "tab_PapeleriaRecibida"
        Me.tab_PapeleriaRecibida.Size = New System.Drawing.Size(1523, 687)
        Me.tab_PapeleriaRecibida.TabIndex = 7
        Me.tab_PapeleriaRecibida.Text = "Papeleria Recibida"
        Me.tab_PapeleriaRecibida.UseVisualStyleBackColor = True
        '
        'btn_DoctosCancelar
        '
        Me.btn_DoctosCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DoctosCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_DoctosCancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_DoctosCancelar.Location = New System.Drawing.Point(295, 654)
        Me.btn_DoctosCancelar.Name = "btn_DoctosCancelar"
        Me.btn_DoctosCancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_DoctosCancelar.TabIndex = 118
        Me.btn_DoctosCancelar.Text = "&Cancelar"
        Me.btn_DoctosCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DoctosCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_DoctosCancelar.UseVisualStyleBackColor = True
        '
        'btn_DoctosImportar
        '
        Me.btn_DoctosImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DoctosImportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_DoctosImportar.Location = New System.Drawing.Point(149, 654)
        Me.btn_DoctosImportar.Name = "btn_DoctosImportar"
        Me.btn_DoctosImportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_DoctosImportar.TabIndex = 2
        Me.btn_DoctosImportar.Text = "&Importar/Exportar"
        Me.btn_DoctosImportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DoctosImportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_DoctosImportar.UseVisualStyleBackColor = True
        '
        'lsv_PapeleriaRecibida
        '
        Me.lsv_PapeleriaRecibida.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_PapeleriaRecibida.CheckBoxes = True
        Me.lsv_PapeleriaRecibida.FullRowSelect = True
        Me.lsv_PapeleriaRecibida.HideSelection = False
        Me.lsv_PapeleriaRecibida.Location = New System.Drawing.Point(3, 3)
        ListViewColumnSorter39.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter39.SortColumn = 0
        Me.lsv_PapeleriaRecibida.Lvs = ListViewColumnSorter39
        Me.lsv_PapeleriaRecibida.MultiSelect = False
        Me.lsv_PapeleriaRecibida.Name = "lsv_PapeleriaRecibida"
        Me.lsv_PapeleriaRecibida.Row1 = 25
        Me.lsv_PapeleriaRecibida.Row10 = 0
        Me.lsv_PapeleriaRecibida.Row2 = 10
        Me.lsv_PapeleriaRecibida.Row3 = 0
        Me.lsv_PapeleriaRecibida.Row4 = 0
        Me.lsv_PapeleriaRecibida.Row5 = 0
        Me.lsv_PapeleriaRecibida.Row6 = 0
        Me.lsv_PapeleriaRecibida.Row7 = 0
        Me.lsv_PapeleriaRecibida.Row8 = 0
        Me.lsv_PapeleriaRecibida.Row9 = 0
        Me.lsv_PapeleriaRecibida.Size = New System.Drawing.Size(1517, 645)
        Me.lsv_PapeleriaRecibida.TabIndex = 0
        Me.lsv_PapeleriaRecibida.UseCompatibleStateImageBehavior = False
        Me.lsv_PapeleriaRecibida.View = System.Windows.Forms.View.Details
        '
        'btn_Guardar_PapeleriaRecibida
        '
        Me.btn_Guardar_PapeleriaRecibida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_PapeleriaRecibida.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_PapeleriaRecibida.Location = New System.Drawing.Point(3, 654)
        Me.btn_Guardar_PapeleriaRecibida.Name = "btn_Guardar_PapeleriaRecibida"
        Me.btn_Guardar_PapeleriaRecibida.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_PapeleriaRecibida.TabIndex = 1
        Me.btn_Guardar_PapeleriaRecibida.Text = "&Guardar"
        Me.btn_Guardar_PapeleriaRecibida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_PapeleriaRecibida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_PapeleriaRecibida.UseVisualStyleBackColor = True
        '
        'tab_DatosEmergencia
        '
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_TelefonoCelular_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_TelefonoCelDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.Label8)
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_Relacion_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.btn_Borrar_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.btn_Cancelar_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.btn_Modificar_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.btn_Guardar_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.lsv_datosEmergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_ObservacionesDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.rtb_Observaciones_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_EmailDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_Email_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Label11)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_TipoRelacionDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_telefonoFijo_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_Domicilio_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_TelefonoDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_DomicilioDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.tbx_Nombre_Emergencia)
        Me.tab_DatosEmergencia.Controls.Add(Me.Lbl_NombreDE)
        Me.tab_DatosEmergencia.Controls.Add(Me.btn_Agregar_Emergencia)
        Me.tab_DatosEmergencia.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosEmergencia.Name = "tab_DatosEmergencia"
        Me.tab_DatosEmergencia.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DatosEmergencia.Size = New System.Drawing.Size(1523, 687)
        Me.tab_DatosEmergencia.TabIndex = 9
        Me.tab_DatosEmergencia.Text = "Datos Emergencia"
        Me.tab_DatosEmergencia.UseVisualStyleBackColor = True
        '
        'tbx_TelefonoCelular_Emergencia
        '
        Me.tbx_TelefonoCelular_Emergencia.Control_Siguiente = Me.tbx_Email_Emergencia
        Me.tbx_TelefonoCelular_Emergencia.Filtrado = True
        Me.tbx_TelefonoCelular_Emergencia.Location = New System.Drawing.Point(112, 123)
        Me.tbx_TelefonoCelular_Emergencia.MaxLength = 20
        Me.tbx_TelefonoCelular_Emergencia.Name = "tbx_TelefonoCelular_Emergencia"
        Me.tbx_TelefonoCelular_Emergencia.Size = New System.Drawing.Size(130, 20)
        Me.tbx_TelefonoCelular_Emergencia.TabIndex = 5
        Me.tbx_TelefonoCelular_Emergencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Email_Emergencia
        '
        Me.tbx_Email_Emergencia.Location = New System.Drawing.Point(112, 150)
        Me.tbx_Email_Emergencia.MaxLength = 50
        Me.tbx_Email_Emergencia.Name = "tbx_Email_Emergencia"
        Me.tbx_Email_Emergencia.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Email_Emergencia.TabIndex = 6
        '
        'Lbl_TelefonoCelDE
        '
        Me.Lbl_TelefonoCelDE.AutoSize = True
        Me.Lbl_TelefonoCelDE.Location = New System.Drawing.Point(22, 126)
        Me.Lbl_TelefonoCelDE.Name = "Lbl_TelefonoCelDE"
        Me.Lbl_TelefonoCelDE.Size = New System.Drawing.Size(84, 13)
        Me.Lbl_TelefonoCelDE.TabIndex = 11
        Me.Lbl_TelefonoCelDE.Text = "Teléfono Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(399, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 16)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "*"
        '
        'tbx_Relacion_Emergencia
        '
        Me.tbx_Relacion_Emergencia.Control_Siguiente = Me.tbx_Domicilio_Emergencia
        Me.tbx_Relacion_Emergencia.Filtrado = True
        Me.tbx_Relacion_Emergencia.Location = New System.Drawing.Point(112, 44)
        Me.tbx_Relacion_Emergencia.MaxLength = 30
        Me.tbx_Relacion_Emergencia.Name = "tbx_Relacion_Emergencia"
        Me.tbx_Relacion_Emergencia.Size = New System.Drawing.Size(281, 20)
        Me.tbx_Relacion_Emergencia.TabIndex = 2
        Me.tbx_Relacion_Emergencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Domicilio_Emergencia
        '
        Me.tbx_Domicilio_Emergencia.Control_Siguiente = Me.tbx_telefonoFijo_Emergencia
        Me.tbx_Domicilio_Emergencia.Filtrado = True
        Me.tbx_Domicilio_Emergencia.Location = New System.Drawing.Point(112, 71)
        Me.tbx_Domicilio_Emergencia.MaxLength = 50
        Me.tbx_Domicilio_Emergencia.Name = "tbx_Domicilio_Emergencia"
        Me.tbx_Domicilio_Emergencia.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Domicilio_Emergencia.TabIndex = 3
        Me.tbx_Domicilio_Emergencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_telefonoFijo_Emergencia
        '
        Me.tbx_telefonoFijo_Emergencia.Control_Siguiente = Me.tbx_TelefonoCelular_Emergencia
        Me.tbx_telefonoFijo_Emergencia.Filtrado = True
        Me.tbx_telefonoFijo_Emergencia.Location = New System.Drawing.Point(112, 97)
        Me.tbx_telefonoFijo_Emergencia.MaxLength = 20
        Me.tbx_telefonoFijo_Emergencia.Name = "tbx_telefonoFijo_Emergencia"
        Me.tbx_telefonoFijo_Emergencia.Size = New System.Drawing.Size(130, 20)
        Me.tbx_telefonoFijo_Emergencia.TabIndex = 4
        Me.tbx_telefonoFijo_Emergencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Borrar_Emergencia
        '
        Me.btn_Borrar_Emergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Emergencia.Enabled = False
        Me.btn_Borrar_Emergencia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Emergencia.Location = New System.Drawing.Point(298, 651)
        Me.btn_Borrar_Emergencia.Name = "btn_Borrar_Emergencia"
        Me.btn_Borrar_Emergencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Emergencia.TabIndex = 12
        Me.btn_Borrar_Emergencia.Text = "&Borrar"
        Me.btn_Borrar_Emergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Emergencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Emergencia.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Emergencia
        '
        Me.btn_Cancelar_Emergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Emergencia.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_Emergencia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Emergencia.Location = New System.Drawing.Point(444, 651)
        Me.btn_Cancelar_Emergencia.Name = "btn_Cancelar_Emergencia"
        Me.btn_Cancelar_Emergencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Emergencia.TabIndex = 13
        Me.btn_Cancelar_Emergencia.Text = "&Cancelar"
        Me.btn_Cancelar_Emergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Emergencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Emergencia.UseVisualStyleBackColor = True
        '
        'btn_Modificar_Emergencia
        '
        Me.btn_Modificar_Emergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_Emergencia.Enabled = False
        Me.btn_Modificar_Emergencia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_Emergencia.Location = New System.Drawing.Point(152, 651)
        Me.btn_Modificar_Emergencia.Name = "btn_Modificar_Emergencia"
        Me.btn_Modificar_Emergencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Emergencia.TabIndex = 11
        Me.btn_Modificar_Emergencia.Text = "&Modificar"
        Me.btn_Modificar_Emergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Emergencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Emergencia.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Emergencia
        '
        Me.btn_Guardar_Emergencia.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Emergencia.Enabled = False
        Me.btn_Guardar_Emergencia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Emergencia.Location = New System.Drawing.Point(6, 651)
        Me.btn_Guardar_Emergencia.Name = "btn_Guardar_Emergencia"
        Me.btn_Guardar_Emergencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Emergencia.TabIndex = 10
        Me.btn_Guardar_Emergencia.Text = "&Guardar"
        Me.btn_Guardar_Emergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Emergencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Emergencia.UseVisualStyleBackColor = True
        '
        'lsv_datosEmergencia
        '
        Me.lsv_datosEmergencia.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_datosEmergencia.FullRowSelect = True
        Me.lsv_datosEmergencia.HideSelection = False
        Me.lsv_datosEmergencia.Location = New System.Drawing.Point(6, 308)
        ListViewColumnSorter40.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter40.SortColumn = 0
        Me.lsv_datosEmergencia.Lvs = ListViewColumnSorter40
        Me.lsv_datosEmergencia.MultiSelect = False
        Me.lsv_datosEmergencia.Name = "lsv_datosEmergencia"
        Me.lsv_datosEmergencia.Row1 = 20
        Me.lsv_datosEmergencia.Row10 = 0
        Me.lsv_datosEmergencia.Row2 = 10
        Me.lsv_datosEmergencia.Row3 = 15
        Me.lsv_datosEmergencia.Row4 = 10
        Me.lsv_datosEmergencia.Row5 = 15
        Me.lsv_datosEmergencia.Row6 = 10
        Me.lsv_datosEmergencia.Row7 = 15
        Me.lsv_datosEmergencia.Row8 = 0
        Me.lsv_datosEmergencia.Row9 = 0
        Me.lsv_datosEmergencia.Size = New System.Drawing.Size(1511, 337)
        Me.lsv_datosEmergencia.TabIndex = 9
        Me.lsv_datosEmergencia.UseCompatibleStateImageBehavior = False
        Me.lsv_datosEmergencia.View = System.Windows.Forms.View.Details
        '
        'Lbl_ObservacionesDE
        '
        Me.Lbl_ObservacionesDE.AutoSize = True
        Me.Lbl_ObservacionesDE.Location = New System.Drawing.Point(28, 179)
        Me.Lbl_ObservacionesDE.Name = "Lbl_ObservacionesDE"
        Me.Lbl_ObservacionesDE.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_ObservacionesDE.TabIndex = 16
        Me.Lbl_ObservacionesDE.Text = "Observaciones"
        '
        'rtb_Observaciones_Emergencia
        '
        Me.rtb_Observaciones_Emergencia.Location = New System.Drawing.Point(112, 176)
        Me.rtb_Observaciones_Emergencia.MaxLength = 300
        Me.rtb_Observaciones_Emergencia.Name = "rtb_Observaciones_Emergencia"
        Me.rtb_Observaciones_Emergencia.Size = New System.Drawing.Size(350, 126)
        Me.rtb_Observaciones_Emergencia.TabIndex = 7
        Me.rtb_Observaciones_Emergencia.Text = ""
        '
        'Lbl_EmailDE
        '
        Me.Lbl_EmailDE.AutoSize = True
        Me.Lbl_EmailDE.Location = New System.Drawing.Point(74, 153)
        Me.Lbl_EmailDE.Name = "Lbl_EmailDE"
        Me.Lbl_EmailDE.Size = New System.Drawing.Size(32, 13)
        Me.Lbl_EmailDE.TabIndex = 14
        Me.Lbl_EmailDE.Text = "Email"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(468, 21)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(13, 16)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "*"
        '
        'Lbl_TipoRelacionDE
        '
        Me.Lbl_TipoRelacionDE.AutoSize = True
        Me.Lbl_TipoRelacionDE.Location = New System.Drawing.Point(18, 47)
        Me.Lbl_TipoRelacionDE.Name = "Lbl_TipoRelacionDE"
        Me.Lbl_TipoRelacionDE.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_TipoRelacionDE.TabIndex = 3
        Me.Lbl_TipoRelacionDE.Text = "Tipo de Relación"
        '
        'Lbl_TelefonoDE
        '
        Me.Lbl_TelefonoDE.AutoSize = True
        Me.Lbl_TelefonoDE.Location = New System.Drawing.Point(38, 100)
        Me.Lbl_TelefonoDE.Name = "Lbl_TelefonoDE"
        Me.Lbl_TelefonoDE.Size = New System.Drawing.Size(68, 13)
        Me.Lbl_TelefonoDE.TabIndex = 9
        Me.Lbl_TelefonoDE.Text = "Teléfono Fijo"
        '
        'Lbl_DomicilioDE
        '
        Me.Lbl_DomicilioDE.AutoSize = True
        Me.Lbl_DomicilioDE.Location = New System.Drawing.Point(57, 74)
        Me.Lbl_DomicilioDE.Name = "Lbl_DomicilioDE"
        Me.Lbl_DomicilioDE.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_DomicilioDE.TabIndex = 6
        Me.Lbl_DomicilioDE.Text = "Domicilio"
        '
        'tbx_Nombre_Emergencia
        '
        Me.tbx_Nombre_Emergencia.Control_Siguiente = Me.tbx_Relacion_Emergencia
        Me.tbx_Nombre_Emergencia.Filtrado = True
        Me.tbx_Nombre_Emergencia.Location = New System.Drawing.Point(112, 20)
        Me.tbx_Nombre_Emergencia.MaxLength = 50
        Me.tbx_Nombre_Emergencia.Name = "tbx_Nombre_Emergencia"
        Me.tbx_Nombre_Emergencia.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Nombre_Emergencia.TabIndex = 1
        Me.tbx_Nombre_Emergencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_NombreDE
        '
        Me.Lbl_NombreDE.AutoSize = True
        Me.Lbl_NombreDE.Location = New System.Drawing.Point(15, 23)
        Me.Lbl_NombreDE.Name = "Lbl_NombreDE"
        Me.Lbl_NombreDE.Size = New System.Drawing.Size(91, 13)
        Me.Lbl_NombreDE.TabIndex = 0
        Me.Lbl_NombreDE.Text = "Nombre Completo"
        '
        'btn_Agregar_Emergencia
        '
        Me.btn_Agregar_Emergencia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Emergencia.Location = New System.Drawing.Point(468, 272)
        Me.btn_Agregar_Emergencia.Name = "btn_Agregar_Emergencia"
        Me.btn_Agregar_Emergencia.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Emergencia.TabIndex = 8
        Me.btn_Agregar_Emergencia.Text = "Agregar"
        Me.btn_Agregar_Emergencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Emergencia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Emergencia.UseVisualStyleBackColor = True
        '
        'tab_Adicionales
        '
        Me.tab_Adicionales.Controls.Add(Me.Label13)
        Me.tab_Adicionales.Controls.Add(Me.gbx_EstudioSocioEco)
        Me.tab_Adicionales.Controls.Add(Me.dtp_FechaESocioeconomico)
        Me.tab_Adicionales.Controls.Add(Me.dtp_FechaExamenMedico)
        Me.tab_Adicionales.Controls.Add(Me.dtp_FechaCartaApenales)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservacionesGrales)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservAntidoping)
        Me.tab_Adicionales.Controls.Add(Me.Label20)
        Me.tab_Adicionales.Controls.Add(Me.dtp_FechaPsicometrico)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservPsicometrico)
        Me.tab_Adicionales.Controls.Add(Me.lbl_ExaPsicometrico)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservEstudioSE)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservExaMedico)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservDemandas)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservEnfermedades)
        Me.tab_Adicionales.Controls.Add(Me.tbx_ObservAntecedentes)
        Me.tab_Adicionales.Controls.Add(Me.lbl_ResultadoAntidoping)
        Me.tab_Adicionales.Controls.Add(Me.cmb_Antidoping)
        Me.tab_Adicionales.Controls.Add(Me.gbx_Demandas)
        Me.tab_Adicionales.Controls.Add(Me.lbl_ObservacionesGrales)
        Me.tab_Adicionales.Controls.Add(Me.Label10)
        Me.tab_Adicionales.Controls.Add(Me.lbl_AntecedentesPenales)
        Me.tab_Adicionales.Controls.Add(Me.lbl_EstudioSocioeconomico)
        Me.tab_Adicionales.Controls.Add(Me.Label16)
        Me.tab_Adicionales.Controls.Add(Me.Label17)
        Me.tab_Adicionales.Controls.Add(Me.Label18)
        Me.tab_Adicionales.Controls.Add(Me.lbl_ExamenMedico)
        Me.tab_Adicionales.Controls.Add(Me.lbl_Enfermedades)
        Me.tab_Adicionales.Controls.Add(Me.lbl_Demandas)
        Me.tab_Adicionales.Controls.Add(Me.dtp_FechaAntidoping)
        Me.tab_Adicionales.Controls.Add(Me.gbx_Enfermedades)
        Me.tab_Adicionales.Controls.Add(Me.Label14)
        Me.tab_Adicionales.Controls.Add(Me.gbx_ExamenAntidoping)
        Me.tab_Adicionales.Controls.Add(Me.Label19)
        Me.tab_Adicionales.Controls.Add(Me.gbx_Antecedentes)
        Me.tab_Adicionales.Controls.Add(Me.gbx_ExamenMedico)
        Me.tab_Adicionales.Controls.Add(Me.gbx_ExamenPsicometrico)
        Me.tab_Adicionales.Controls.Add(Me.btn_CancelarAdicionales)
        Me.tab_Adicionales.Controls.Add(Me.btn_Guardar)
        Me.tab_Adicionales.Location = New System.Drawing.Point(4, 22)
        Me.tab_Adicionales.Name = "tab_Adicionales"
        Me.tab_Adicionales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Adicionales.Size = New System.Drawing.Size(1523, 687)
        Me.tab_Adicionales.TabIndex = 11
        Me.tab_Adicionales.Text = "Adicionales"
        Me.tab_Adicionales.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(136, 181)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 16)
        Me.Label13.TabIndex = 16
        Me.Label13.Text = "*"
        '
        'gbx_EstudioSocioEco
        '
        Me.gbx_EstudioSocioEco.Controls.Add(Me.rdb_ESocioNO)
        Me.gbx_EstudioSocioEco.Controls.Add(Me.rdb_ESocioSI)
        Me.gbx_EstudioSocioEco.Location = New System.Drawing.Point(38, 74)
        Me.gbx_EstudioSocioEco.Name = "gbx_EstudioSocioEco"
        Me.gbx_EstudioSocioEco.Size = New System.Drawing.Size(97, 28)
        Me.gbx_EstudioSocioEco.TabIndex = 6
        Me.gbx_EstudioSocioEco.TabStop = False
        '
        'rdb_ESocioNO
        '
        Me.rdb_ESocioNO.AutoSize = True
        Me.rdb_ESocioNO.Location = New System.Drawing.Point(48, 7)
        Me.rdb_ESocioNO.Name = "rdb_ESocioNO"
        Me.rdb_ESocioNO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ESocioNO.TabIndex = 1
        Me.rdb_ESocioNO.TabStop = True
        Me.rdb_ESocioNO.Text = "No"
        Me.rdb_ESocioNO.UseVisualStyleBackColor = True
        '
        'rdb_ESocioSI
        '
        Me.rdb_ESocioSI.AutoSize = True
        Me.rdb_ESocioSI.Location = New System.Drawing.Point(4, 7)
        Me.rdb_ESocioSI.Name = "rdb_ESocioSI"
        Me.rdb_ESocioSI.Size = New System.Drawing.Size(36, 17)
        Me.rdb_ESocioSI.TabIndex = 0
        Me.rdb_ESocioSI.TabStop = True
        Me.rdb_ESocioSI.Text = "Sí"
        Me.rdb_ESocioSI.UseVisualStyleBackColor = True
        '
        'dtp_FechaESocioeconomico
        '
        Me.dtp_FechaESocioeconomico.Enabled = False
        Me.dtp_FechaESocioeconomico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaESocioeconomico.Location = New System.Drawing.Point(155, 78)
        Me.dtp_FechaESocioeconomico.Name = "dtp_FechaESocioeconomico"
        Me.dtp_FechaESocioeconomico.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaESocioeconomico.TabIndex = 7
        '
        'dtp_FechaExamenMedico
        '
        Me.dtp_FechaExamenMedico.Enabled = False
        Me.dtp_FechaExamenMedico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExamenMedico.Location = New System.Drawing.Point(156, 131)
        Me.dtp_FechaExamenMedico.Name = "dtp_FechaExamenMedico"
        Me.dtp_FechaExamenMedico.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaExamenMedico.TabIndex = 12
        '
        'dtp_FechaCartaApenales
        '
        Me.dtp_FechaCartaApenales.Enabled = False
        Me.dtp_FechaCartaApenales.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaCartaApenales.Location = New System.Drawing.Point(156, 27)
        Me.dtp_FechaCartaApenales.Name = "dtp_FechaCartaApenales"
        Me.dtp_FechaCartaApenales.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaCartaApenales.TabIndex = 4
        '
        'tbx_ObservacionesGrales
        '
        Me.tbx_ObservacionesGrales.Location = New System.Drawing.Point(155, 389)
        Me.tbx_ObservacionesGrales.MaxLength = 100
        Me.tbx_ObservacionesGrales.Multiline = True
        Me.tbx_ObservacionesGrales.Name = "tbx_ObservacionesGrales"
        Me.tbx_ObservacionesGrales.Size = New System.Drawing.Size(558, 55)
        Me.tbx_ObservacionesGrales.TabIndex = 35
        '
        'tbx_ObservAntidoping
        '
        Me.tbx_ObservAntidoping.Location = New System.Drawing.Point(272, 209)
        Me.tbx_ObservAntidoping.MaxLength = 300
        Me.tbx_ObservAntidoping.Multiline = True
        Me.tbx_ObservAntidoping.Name = "tbx_ObservAntidoping"
        Me.tbx_ObservAntidoping.Size = New System.Drawing.Size(441, 72)
        Me.tbx_ObservAntidoping.TabIndex = 23
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(136, 234)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(13, 16)
        Me.Label20.TabIndex = 21
        Me.Label20.Text = "*"
        '
        'dtp_FechaPsicometrico
        '
        Me.dtp_FechaPsicometrico.Enabled = False
        Me.dtp_FechaPsicometrico.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaPsicometrico.Location = New System.Drawing.Point(155, 180)
        Me.dtp_FechaPsicometrico.Name = "dtp_FechaPsicometrico"
        Me.dtp_FechaPsicometrico.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaPsicometrico.TabIndex = 17
        '
        'tbx_ObservPsicometrico
        '
        Me.tbx_ObservPsicometrico.Location = New System.Drawing.Point(272, 158)
        Me.tbx_ObservPsicometrico.MaxLength = 300
        Me.tbx_ObservPsicometrico.Multiline = True
        Me.tbx_ObservPsicometrico.Name = "tbx_ObservPsicometrico"
        Me.tbx_ObservPsicometrico.Size = New System.Drawing.Size(441, 45)
        Me.tbx_ObservPsicometrico.TabIndex = 18
        '
        'lbl_ExaPsicometrico
        '
        Me.lbl_ExaPsicometrico.AutoSize = True
        Me.lbl_ExaPsicometrico.Location = New System.Drawing.Point(41, 161)
        Me.lbl_ExaPsicometrico.Name = "lbl_ExaPsicometrico"
        Me.lbl_ExaPsicometrico.Size = New System.Drawing.Size(108, 13)
        Me.lbl_ExaPsicometrico.TabIndex = 14
        Me.lbl_ExaPsicometrico.Text = "Examen Psicométrico"
        '
        'tbx_ObservEstudioSE
        '
        Me.tbx_ObservEstudioSE.Location = New System.Drawing.Point(272, 57)
        Me.tbx_ObservEstudioSE.MaxLength = 300
        Me.tbx_ObservEstudioSE.Multiline = True
        Me.tbx_ObservEstudioSE.Name = "tbx_ObservEstudioSE"
        Me.tbx_ObservEstudioSE.Size = New System.Drawing.Size(441, 45)
        Me.tbx_ObservEstudioSE.TabIndex = 8
        '
        'tbx_ObservExaMedico
        '
        Me.tbx_ObservExaMedico.Location = New System.Drawing.Point(272, 108)
        Me.tbx_ObservExaMedico.MaxLength = 300
        Me.tbx_ObservExaMedico.Multiline = True
        Me.tbx_ObservExaMedico.Name = "tbx_ObservExaMedico"
        Me.tbx_ObservExaMedico.Size = New System.Drawing.Size(441, 45)
        Me.tbx_ObservExaMedico.TabIndex = 13
        '
        'tbx_ObservDemandas
        '
        Me.tbx_ObservDemandas.Location = New System.Drawing.Point(155, 338)
        Me.tbx_ObservDemandas.MaxLength = 300
        Me.tbx_ObservDemandas.Multiline = True
        Me.tbx_ObservDemandas.Name = "tbx_ObservDemandas"
        Me.tbx_ObservDemandas.Size = New System.Drawing.Size(558, 45)
        Me.tbx_ObservDemandas.TabIndex = 33
        '
        'tbx_ObservEnfermedades
        '
        Me.tbx_ObservEnfermedades.Location = New System.Drawing.Point(155, 287)
        Me.tbx_ObservEnfermedades.MaxLength = 300
        Me.tbx_ObservEnfermedades.Multiline = True
        Me.tbx_ObservEnfermedades.Name = "tbx_ObservEnfermedades"
        Me.tbx_ObservEnfermedades.Size = New System.Drawing.Size(558, 45)
        Me.tbx_ObservEnfermedades.TabIndex = 28
        '
        'tbx_ObservAntecedentes
        '
        Me.tbx_ObservAntecedentes.Location = New System.Drawing.Point(272, 6)
        Me.tbx_ObservAntecedentes.MaxLength = 300
        Me.tbx_ObservAntecedentes.Multiline = True
        Me.tbx_ObservAntecedentes.Name = "tbx_ObservAntecedentes"
        Me.tbx_ObservAntecedentes.Size = New System.Drawing.Size(441, 45)
        Me.tbx_ObservAntecedentes.TabIndex = 1
        '
        'lbl_ResultadoAntidoping
        '
        Me.lbl_ResultadoAntidoping.AutoSize = True
        Me.lbl_ResultadoAntidoping.Location = New System.Drawing.Point(40, 263)
        Me.lbl_ResultadoAntidoping.Name = "lbl_ResultadoAntidoping"
        Me.lbl_ResultadoAntidoping.Size = New System.Drawing.Size(108, 13)
        Me.lbl_ResultadoAntidoping.TabIndex = 24
        Me.lbl_ResultadoAntidoping.Text = "Resultado Antidoping"
        '
        'cmb_Antidoping
        '
        Me.cmb_Antidoping.Control_Siguiente = Nothing
        Me.cmb_Antidoping.DisplayMember = "display"
        Me.cmb_Antidoping.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Antidoping.Enabled = False
        Me.cmb_Antidoping.FormattingEnabled = True
        Me.cmb_Antidoping.Location = New System.Drawing.Point(156, 260)
        Me.cmb_Antidoping.MaxDropDownItems = 20
        Me.cmb_Antidoping.Name = "cmb_Antidoping"
        Me.cmb_Antidoping.Size = New System.Drawing.Size(110, 21)
        Me.cmb_Antidoping.TabIndex = 25
        Me.cmb_Antidoping.ValueMember = "value"
        '
        'gbx_Demandas
        '
        Me.gbx_Demandas.ControlSiguiente = Nothing
        Me.gbx_Demandas.Location = New System.Drawing.Point(38, 350)
        Me.gbx_Demandas.Name = "gbx_Demandas"
        Me.gbx_Demandas.SelectedValue = Global.Microsoft.VisualBasic.ChrW(48)
        Me.gbx_Demandas.Size = New System.Drawing.Size(97, 28)
        Me.gbx_Demandas.TabIndex = 31
        Me.gbx_Demandas.TabStop = False
        '
        'lbl_ObservacionesGrales
        '
        Me.lbl_ObservacionesGrales.AutoSize = True
        Me.lbl_ObservacionesGrales.Location = New System.Drawing.Point(19, 393)
        Me.lbl_ObservacionesGrales.Name = "lbl_ObservacionesGrales"
        Me.lbl_ObservacionesGrales.Size = New System.Drawing.Size(129, 13)
        Me.lbl_ObservacionesGrales.TabIndex = 34
        Me.lbl_ObservacionesGrales.Text = "Observaciones Generales"
        Me.lbl_ObservacionesGrales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(136, 28)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 16)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "*"
        '
        'lbl_AntecedentesPenales
        '
        Me.lbl_AntecedentesPenales.AutoSize = True
        Me.lbl_AntecedentesPenales.Location = New System.Drawing.Point(28, 6)
        Me.lbl_AntecedentesPenales.Name = "lbl_AntecedentesPenales"
        Me.lbl_AntecedentesPenales.Size = New System.Drawing.Size(120, 13)
        Me.lbl_AntecedentesPenales.TabIndex = 0
        Me.lbl_AntecedentesPenales.Text = "Carta de NO A. Penales"
        '
        'lbl_EstudioSocioeconomico
        '
        Me.lbl_EstudioSocioeconomico.AutoSize = True
        Me.lbl_EstudioSocioeconomico.Location = New System.Drawing.Point(25, 58)
        Me.lbl_EstudioSocioeconomico.Name = "lbl_EstudioSocioeconomico"
        Me.lbl_EstudioSocioeconomico.Size = New System.Drawing.Size(124, 13)
        Me.lbl_EstudioSocioeconomico.TabIndex = 5
        Me.lbl_EstudioSocioeconomico.Text = "Estudio Socioeconomico"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(136, 130)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(13, 16)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "*"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(135, 307)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(13, 16)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "*"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(135, 357)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(13, 16)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "*"
        '
        'lbl_ExamenMedico
        '
        Me.lbl_ExamenMedico.AutoSize = True
        Me.lbl_ExamenMedico.Location = New System.Drawing.Point(66, 111)
        Me.lbl_ExamenMedico.Name = "lbl_ExamenMedico"
        Me.lbl_ExamenMedico.Size = New System.Drawing.Size(83, 13)
        Me.lbl_ExamenMedico.TabIndex = 9
        Me.lbl_ExamenMedico.Text = "Examen Médico"
        '
        'lbl_Enfermedades
        '
        Me.lbl_Enfermedades.AutoSize = True
        Me.lbl_Enfermedades.Location = New System.Drawing.Point(73, 288)
        Me.lbl_Enfermedades.Name = "lbl_Enfermedades"
        Me.lbl_Enfermedades.Size = New System.Drawing.Size(75, 13)
        Me.lbl_Enfermedades.TabIndex = 26
        Me.lbl_Enfermedades.Text = "Enfermedades"
        '
        'lbl_Demandas
        '
        Me.lbl_Demandas.AutoSize = True
        Me.lbl_Demandas.Location = New System.Drawing.Point(90, 338)
        Me.lbl_Demandas.Name = "lbl_Demandas"
        Me.lbl_Demandas.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Demandas.TabIndex = 30
        Me.lbl_Demandas.Text = "Demandas"
        '
        'dtp_FechaAntidoping
        '
        Me.dtp_FechaAntidoping.Enabled = False
        Me.dtp_FechaAntidoping.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaAntidoping.Location = New System.Drawing.Point(155, 234)
        Me.dtp_FechaAntidoping.Name = "dtp_FechaAntidoping"
        Me.dtp_FechaAntidoping.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaAntidoping.TabIndex = 22
        '
        'gbx_Enfermedades
        '
        Me.gbx_Enfermedades.ControlSiguiente = Nothing
        Me.gbx_Enfermedades.Location = New System.Drawing.Point(38, 299)
        Me.gbx_Enfermedades.Name = "gbx_Enfermedades"
        Me.gbx_Enfermedades.SelectedValue = Global.Microsoft.VisualBasic.ChrW(48)
        Me.gbx_Enfermedades.Size = New System.Drawing.Size(97, 28)
        Me.gbx_Enfermedades.TabIndex = 27
        Me.gbx_Enfermedades.TabStop = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(136, 78)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(13, 16)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "*"
        '
        'gbx_ExamenAntidoping
        '
        Me.gbx_ExamenAntidoping.Controls.Add(Me.rdb_AntidopingNo)
        Me.gbx_ExamenAntidoping.Controls.Add(Me.rdb_AntidopingSI)
        Me.gbx_ExamenAntidoping.Location = New System.Drawing.Point(39, 226)
        Me.gbx_ExamenAntidoping.Name = "gbx_ExamenAntidoping"
        Me.gbx_ExamenAntidoping.Size = New System.Drawing.Size(97, 28)
        Me.gbx_ExamenAntidoping.TabIndex = 20
        Me.gbx_ExamenAntidoping.TabStop = False
        '
        'rdb_AntidopingNo
        '
        Me.rdb_AntidopingNo.AutoSize = True
        Me.rdb_AntidopingNo.Location = New System.Drawing.Point(48, 7)
        Me.rdb_AntidopingNo.Name = "rdb_AntidopingNo"
        Me.rdb_AntidopingNo.Size = New System.Drawing.Size(39, 17)
        Me.rdb_AntidopingNo.TabIndex = 1
        Me.rdb_AntidopingNo.TabStop = True
        Me.rdb_AntidopingNo.Text = "No"
        Me.rdb_AntidopingNo.UseVisualStyleBackColor = True
        '
        'rdb_AntidopingSI
        '
        Me.rdb_AntidopingSI.AutoSize = True
        Me.rdb_AntidopingSI.Location = New System.Drawing.Point(4, 7)
        Me.rdb_AntidopingSI.Name = "rdb_AntidopingSI"
        Me.rdb_AntidopingSI.Size = New System.Drawing.Size(36, 17)
        Me.rdb_AntidopingSI.TabIndex = 0
        Me.rdb_AntidopingSI.TabStop = True
        Me.rdb_AntidopingSI.Text = "Sí"
        Me.rdb_AntidopingSI.UseVisualStyleBackColor = True
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(51, 214)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(98, 13)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "Examen Antidoping"
        '
        'gbx_Antecedentes
        '
        Me.gbx_Antecedentes.Controls.Add(Me.rdb_CartaAPNO)
        Me.gbx_Antecedentes.Controls.Add(Me.rdb_CartaAPSI)
        Me.gbx_Antecedentes.Location = New System.Drawing.Point(38, 19)
        Me.gbx_Antecedentes.Name = "gbx_Antecedentes"
        Me.gbx_Antecedentes.Size = New System.Drawing.Size(97, 28)
        Me.gbx_Antecedentes.TabIndex = 2
        Me.gbx_Antecedentes.TabStop = False
        '
        'rdb_CartaAPNO
        '
        Me.rdb_CartaAPNO.AutoSize = True
        Me.rdb_CartaAPNO.Location = New System.Drawing.Point(48, 7)
        Me.rdb_CartaAPNO.Name = "rdb_CartaAPNO"
        Me.rdb_CartaAPNO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_CartaAPNO.TabIndex = 1
        Me.rdb_CartaAPNO.TabStop = True
        Me.rdb_CartaAPNO.Text = "No"
        Me.rdb_CartaAPNO.UseVisualStyleBackColor = True
        '
        'rdb_CartaAPSI
        '
        Me.rdb_CartaAPSI.AutoSize = True
        Me.rdb_CartaAPSI.Location = New System.Drawing.Point(4, 7)
        Me.rdb_CartaAPSI.Name = "rdb_CartaAPSI"
        Me.rdb_CartaAPSI.Size = New System.Drawing.Size(36, 17)
        Me.rdb_CartaAPSI.TabIndex = 0
        Me.rdb_CartaAPSI.TabStop = True
        Me.rdb_CartaAPSI.Text = "Sí"
        Me.rdb_CartaAPSI.UseVisualStyleBackColor = True
        '
        'gbx_ExamenMedico
        '
        Me.gbx_ExamenMedico.Controls.Add(Me.rdb_ExMedNO)
        Me.gbx_ExamenMedico.Controls.Add(Me.rdb_ExMedSI)
        Me.gbx_ExamenMedico.Location = New System.Drawing.Point(38, 123)
        Me.gbx_ExamenMedico.Name = "gbx_ExamenMedico"
        Me.gbx_ExamenMedico.Size = New System.Drawing.Size(97, 28)
        Me.gbx_ExamenMedico.TabIndex = 10
        Me.gbx_ExamenMedico.TabStop = False
        '
        'rdb_ExMedNO
        '
        Me.rdb_ExMedNO.AutoSize = True
        Me.rdb_ExMedNO.Location = New System.Drawing.Point(48, 7)
        Me.rdb_ExMedNO.Name = "rdb_ExMedNO"
        Me.rdb_ExMedNO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ExMedNO.TabIndex = 1
        Me.rdb_ExMedNO.TabStop = True
        Me.rdb_ExMedNO.Text = "No"
        Me.rdb_ExMedNO.UseVisualStyleBackColor = True
        '
        'rdb_ExMedSI
        '
        Me.rdb_ExMedSI.AutoSize = True
        Me.rdb_ExMedSI.Location = New System.Drawing.Point(4, 7)
        Me.rdb_ExMedSI.Name = "rdb_ExMedSI"
        Me.rdb_ExMedSI.Size = New System.Drawing.Size(36, 17)
        Me.rdb_ExMedSI.TabIndex = 0
        Me.rdb_ExMedSI.TabStop = True
        Me.rdb_ExMedSI.Text = "Sí"
        Me.rdb_ExMedSI.UseVisualStyleBackColor = True
        '
        'gbx_ExamenPsicometrico
        '
        Me.gbx_ExamenPsicometrico.Controls.Add(Me.rdb_ExPsicoNO)
        Me.gbx_ExamenPsicometrico.Controls.Add(Me.rdb_ExPsicoSI)
        Me.gbx_ExamenPsicometrico.Location = New System.Drawing.Point(38, 175)
        Me.gbx_ExamenPsicometrico.Name = "gbx_ExamenPsicometrico"
        Me.gbx_ExamenPsicometrico.Size = New System.Drawing.Size(97, 28)
        Me.gbx_ExamenPsicometrico.TabIndex = 15
        Me.gbx_ExamenPsicometrico.TabStop = False
        '
        'rdb_ExPsicoNO
        '
        Me.rdb_ExPsicoNO.AutoSize = True
        Me.rdb_ExPsicoNO.Location = New System.Drawing.Point(48, 7)
        Me.rdb_ExPsicoNO.Name = "rdb_ExPsicoNO"
        Me.rdb_ExPsicoNO.Size = New System.Drawing.Size(39, 17)
        Me.rdb_ExPsicoNO.TabIndex = 1
        Me.rdb_ExPsicoNO.TabStop = True
        Me.rdb_ExPsicoNO.Text = "No"
        Me.rdb_ExPsicoNO.UseVisualStyleBackColor = True
        '
        'rdb_ExPsicoSI
        '
        Me.rdb_ExPsicoSI.AutoSize = True
        Me.rdb_ExPsicoSI.Location = New System.Drawing.Point(4, 7)
        Me.rdb_ExPsicoSI.Name = "rdb_ExPsicoSI"
        Me.rdb_ExPsicoSI.Size = New System.Drawing.Size(36, 17)
        Me.rdb_ExPsicoSI.TabIndex = 0
        Me.rdb_ExPsicoSI.TabStop = True
        Me.rdb_ExPsicoSI.Text = "Sí"
        Me.rdb_ExPsicoSI.UseVisualStyleBackColor = True
        '
        'btn_CancelarAdicionales
        '
        Me.btn_CancelarAdicionales.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarAdicionales.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarAdicionales.Location = New System.Drawing.Point(573, 450)
        Me.btn_CancelarAdicionales.Name = "btn_CancelarAdicionales"
        Me.btn_CancelarAdicionales.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarAdicionales.TabIndex = 37
        Me.btn_CancelarAdicionales.Text = "&Cancelar"
        Me.btn_CancelarAdicionales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarAdicionales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarAdicionales.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(155, 450)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 36
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tab_Expediente
        '
        Me.tab_Expediente.Controls.Add(Me.btn_CancelarExpediente)
        Me.tab_Expediente.Controls.Add(Me.btn_GuardarExpediente)
        Me.tab_Expediente.Controls.Add(Me.lbl_EstacionActualiza)
        Me.tab_Expediente.Controls.Add(Me.tbx_EstacionActualiza)
        Me.tab_Expediente.Controls.Add(Me.lbl_ComentariosRevision)
        Me.tab_Expediente.Controls.Add(Me.tbx_ComentariosRevision)
        Me.tab_Expediente.Controls.Add(Me.dtp_FechaUltimaActual)
        Me.tab_Expediente.Controls.Add(Me.cmb_UsuarioUltimaActual)
        Me.tab_Expediente.Controls.Add(Me.lbl_UsuarioUltActual)
        Me.tab_Expediente.Controls.Add(Me.lbl_FechaUltimaActualiz)
        Me.tab_Expediente.Controls.Add(Me.dtp_Fecharevision)
        Me.tab_Expediente.Controls.Add(Me.cmb_UsuarioRevisa)
        Me.tab_Expediente.Controls.Add(Me.lbl_UsuarioRevisa)
        Me.tab_Expediente.Controls.Add(Me.lbl_FechaRevision)
        Me.tab_Expediente.Location = New System.Drawing.Point(4, 22)
        Me.tab_Expediente.Name = "tab_Expediente"
        Me.tab_Expediente.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Expediente.Size = New System.Drawing.Size(1523, 687)
        Me.tab_Expediente.TabIndex = 12
        Me.tab_Expediente.Text = "Expediente"
        Me.tab_Expediente.UseVisualStyleBackColor = True
        '
        'btn_CancelarExpediente
        '
        Me.btn_CancelarExpediente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarExpediente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarExpediente.Location = New System.Drawing.Point(369, 217)
        Me.btn_CancelarExpediente.Name = "btn_CancelarExpediente"
        Me.btn_CancelarExpediente.Size = New System.Drawing.Size(140, 30)
        Me.btn_CancelarExpediente.TabIndex = 8
        Me.btn_CancelarExpediente.Text = "&Cancelar"
        Me.btn_CancelarExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CancelarExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CancelarExpediente.UseVisualStyleBackColor = True
        '
        'btn_GuardarExpediente
        '
        Me.btn_GuardarExpediente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_GuardarExpediente.Location = New System.Drawing.Point(159, 217)
        Me.btn_GuardarExpediente.Name = "btn_GuardarExpediente"
        Me.btn_GuardarExpediente.Size = New System.Drawing.Size(140, 30)
        Me.btn_GuardarExpediente.TabIndex = 7
        Me.btn_GuardarExpediente.Text = "&Guardar"
        Me.btn_GuardarExpediente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_GuardarExpediente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_GuardarExpediente.UseVisualStyleBackColor = True
        '
        'lbl_EstacionActualiza
        '
        Me.lbl_EstacionActualiza.AutoSize = True
        Me.lbl_EstacionActualiza.Enabled = False
        Me.lbl_EstacionActualiza.Location = New System.Drawing.Point(59, 181)
        Me.lbl_EstacionActualiza.Name = "lbl_EstacionActualiza"
        Me.lbl_EstacionActualiza.Size = New System.Drawing.Size(94, 13)
        Me.lbl_EstacionActualiza.TabIndex = 10
        Me.lbl_EstacionActualiza.Text = "Estación Actualiza"
        '
        'tbx_EstacionActualiza
        '
        Me.tbx_EstacionActualiza.BackColor = System.Drawing.Color.White
        Me.tbx_EstacionActualiza.Control_Siguiente = Me.btn_Agregar
        Me.tbx_EstacionActualiza.Filtrado = True
        Me.tbx_EstacionActualiza.Location = New System.Drawing.Point(159, 178)
        Me.tbx_EstacionActualiza.MaxLength = 50
        Me.tbx_EstacionActualiza.Name = "tbx_EstacionActualiza"
        Me.tbx_EstacionActualiza.ReadOnly = True
        Me.tbx_EstacionActualiza.Size = New System.Drawing.Size(350, 20)
        Me.tbx_EstacionActualiza.TabIndex = 6
        Me.tbx_EstacionActualiza.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_ComentariosRevision
        '
        Me.lbl_ComentariosRevision.AutoSize = True
        Me.lbl_ComentariosRevision.Location = New System.Drawing.Point(44, 66)
        Me.lbl_ComentariosRevision.Name = "lbl_ComentariosRevision"
        Me.lbl_ComentariosRevision.Size = New System.Drawing.Size(109, 13)
        Me.lbl_ComentariosRevision.TabIndex = 4
        Me.lbl_ComentariosRevision.Text = "Comentarios Revisión"
        '
        'tbx_ComentariosRevision
        '
        Me.tbx_ComentariosRevision.Control_Siguiente = Me.btn_Agregar
        Me.tbx_ComentariosRevision.Filtrado = True
        Me.tbx_ComentariosRevision.Location = New System.Drawing.Point(159, 63)
        Me.tbx_ComentariosRevision.MaxLength = 300
        Me.tbx_ComentariosRevision.Multiline = True
        Me.tbx_ComentariosRevision.Name = "tbx_ComentariosRevision"
        Me.tbx_ComentariosRevision.Size = New System.Drawing.Size(350, 57)
        Me.tbx_ComentariosRevision.TabIndex = 3
        Me.tbx_ComentariosRevision.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'dtp_FechaUltimaActual
        '
        Me.dtp_FechaUltimaActual.Enabled = False
        Me.dtp_FechaUltimaActual.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaUltimaActual.Location = New System.Drawing.Point(159, 125)
        Me.dtp_FechaUltimaActual.Name = "dtp_FechaUltimaActual"
        Me.dtp_FechaUltimaActual.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaUltimaActual.TabIndex = 4
        '
        'cmb_UsuarioUltimaActual
        '
        Me.cmb_UsuarioUltimaActual.Clave = Nothing
        Me.cmb_UsuarioUltimaActual.Control_Siguiente = Me.tbx_Mail
        Me.cmb_UsuarioUltimaActual.DisplayMember = "Nombre"
        Me.cmb_UsuarioUltimaActual.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioUltimaActual.Empresa = False
        Me.cmb_UsuarioUltimaActual.Enabled = False
        Me.cmb_UsuarioUltimaActual.Filtro = Nothing
        Me.cmb_UsuarioUltimaActual.FormattingEnabled = True
        Me.cmb_UsuarioUltimaActual.Location = New System.Drawing.Point(159, 151)
        Me.cmb_UsuarioUltimaActual.MaxDropDownItems = 20
        Me.cmb_UsuarioUltimaActual.MaxLength = 9
        Me.cmb_UsuarioUltimaActual.Name = "cmb_UsuarioUltimaActual"
        Me.cmb_UsuarioUltimaActual.Pista = True
        Me.cmb_UsuarioUltimaActual.Size = New System.Drawing.Size(350, 21)
        Me.cmb_UsuarioUltimaActual.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioUltimaActual.Sucursal = True
        Me.cmb_UsuarioUltimaActual.TabIndex = 5
        Me.cmb_UsuarioUltimaActual.Tipo = 0
        Me.cmb_UsuarioUltimaActual.ValueMember = "Id_Empleado"
        '
        'lbl_UsuarioUltActual
        '
        Me.lbl_UsuarioUltActual.AutoSize = True
        Me.lbl_UsuarioUltActual.Location = New System.Drawing.Point(12, 154)
        Me.lbl_UsuarioUltActual.Name = "lbl_UsuarioUltActual"
        Me.lbl_UsuarioUltActual.Size = New System.Drawing.Size(141, 13)
        Me.lbl_UsuarioUltActual.TabIndex = 8
        Me.lbl_UsuarioUltActual.Text = "Usuario Última Actualización"
        '
        'lbl_FechaUltimaActualiz
        '
        Me.lbl_FechaUltimaActualiz.AutoSize = True
        Me.lbl_FechaUltimaActualiz.Location = New System.Drawing.Point(18, 128)
        Me.lbl_FechaUltimaActualiz.Name = "lbl_FechaUltimaActualiz"
        Me.lbl_FechaUltimaActualiz.Size = New System.Drawing.Size(135, 13)
        Me.lbl_FechaUltimaActualiz.TabIndex = 6
        Me.lbl_FechaUltimaActualiz.Text = "Fecha Última Actualización"
        '
        'dtp_Fecharevision
        '
        Me.dtp_Fecharevision.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_Fecharevision.Location = New System.Drawing.Point(159, 10)
        Me.dtp_Fecharevision.Name = "dtp_Fecharevision"
        Me.dtp_Fecharevision.Size = New System.Drawing.Size(110, 20)
        Me.dtp_Fecharevision.TabIndex = 1
        '
        'cmb_UsuarioRevisa
        '
        Me.cmb_UsuarioRevisa.Clave = Nothing
        Me.cmb_UsuarioRevisa.Control_Siguiente = Me.tbx_Mail
        Me.cmb_UsuarioRevisa.DisplayMember = "Nombre"
        Me.cmb_UsuarioRevisa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioRevisa.Empresa = False
        Me.cmb_UsuarioRevisa.Filtro = Nothing
        Me.cmb_UsuarioRevisa.FormattingEnabled = True
        Me.cmb_UsuarioRevisa.Location = New System.Drawing.Point(159, 36)
        Me.cmb_UsuarioRevisa.MaxDropDownItems = 20
        Me.cmb_UsuarioRevisa.MaxLength = 9
        Me.cmb_UsuarioRevisa.Name = "cmb_UsuarioRevisa"
        Me.cmb_UsuarioRevisa.Pista = True
        Me.cmb_UsuarioRevisa.Size = New System.Drawing.Size(350, 21)
        Me.cmb_UsuarioRevisa.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_UsuarioRevisa.Sucursal = True
        Me.cmb_UsuarioRevisa.TabIndex = 2
        Me.cmb_UsuarioRevisa.Tipo = 0
        Me.cmb_UsuarioRevisa.ValueMember = "Id_Empleado"
        '
        'lbl_UsuarioRevisa
        '
        Me.lbl_UsuarioRevisa.AutoSize = True
        Me.lbl_UsuarioRevisa.Location = New System.Drawing.Point(66, 39)
        Me.lbl_UsuarioRevisa.Name = "lbl_UsuarioRevisa"
        Me.lbl_UsuarioRevisa.Size = New System.Drawing.Size(87, 13)
        Me.lbl_UsuarioRevisa.TabIndex = 2
        Me.lbl_UsuarioRevisa.Text = "Usuario Revisión"
        '
        'lbl_FechaRevision
        '
        Me.lbl_FechaRevision.AutoSize = True
        Me.lbl_FechaRevision.Location = New System.Drawing.Point(72, 13)
        Me.lbl_FechaRevision.Name = "lbl_FechaRevision"
        Me.lbl_FechaRevision.Size = New System.Drawing.Size(81, 13)
        Me.lbl_FechaRevision.TabIndex = 0
        Me.lbl_FechaRevision.Text = "Fecha Revisión"
        '
        'btn_Investigacion
        '
        Me.btn_Investigacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Investigacion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Investigacion.Enabled = False
        Me.btn_Investigacion.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.investigacion
        Me.btn_Investigacion.Location = New System.Drawing.Point(587, 654)
        Me.btn_Investigacion.Name = "btn_Investigacion"
        Me.btn_Investigacion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Investigacion.TabIndex = 74
        Me.btn_Investigacion.Text = "&Investigacion"
        Me.btn_Investigacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Investigacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Investigacion.UseVisualStyleBackColor = True
        '
        'btn_InvestigacionPersonal
        '
        Me.btn_InvestigacionPersonal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_InvestigacionPersonal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_InvestigacionPersonal.Enabled = False
        Me.btn_InvestigacionPersonal.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.investigacion
        Me.btn_InvestigacionPersonal.Location = New System.Drawing.Point(443, 654)
        Me.btn_InvestigacionPersonal.Name = "btn_InvestigacionPersonal"
        Me.btn_InvestigacionPersonal.Size = New System.Drawing.Size(140, 30)
        Me.btn_InvestigacionPersonal.TabIndex = 352
        Me.btn_InvestigacionPersonal.Text = "&Investigacion"
        Me.btn_InvestigacionPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_InvestigacionPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_InvestigacionPersonal.UseVisualStyleBackColor = True
        '
        'frm_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancelar_DG
        Me.ClientSize = New System.Drawing.Size(1545, 745)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(729, 575)
        Me.Name = "frm_Empleados"
        Me.Text = "Catálogo de Empleados"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.tab_DatosEmpleado.ResumeLayout(False)
        Me.tab_DatosGenerales.ResumeLayout(False)
        Me.tab_DatosGenerales.PerformLayout
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout
        Me.gbx_CatalogoFirmas.ResumeLayout(False)
        Me.gbx_CatalogoFirmas.PerformLayout
        Me.gbx_Porte.ResumeLayout(False)
        Me.gbx_Porte.PerformLayout
        Me.gbx_Verifica.ResumeLayout(False)
        Me.gbx_Verifica.PerformLayout
        Me.gbx_CreditoInfonavit.ResumeLayout(False)
        Me.gbx_CreditoInfonavit.PerformLayout
        Me.gbx_Ruta.ResumeLayout(False)
        Me.gbx_Ruta.PerformLayout
        Me.gbx_CertifAcademia.ResumeLayout(False)
        Me.gbx_CertifAcademia.PerformLayout
        Me.gbx_JefeArea.ResumeLayout(False)
        Me.gbx_JefeArea.PerformLayout
        Me.tab_ModoContacto.ResumeLayout(False)
        Me.tab_ModoContacto.PerformLayout
        Me.tab_RasgosPersonales.ResumeLayout(False)
        Me.gbx_Principales.ResumeLayout(False)
        Me.gbx_Principales.PerformLayout
        CType(Me.pct_RasgoPerfilIzq, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pct_RasgoPerfilDer, System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.pct_RasgoFrente, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbx_Boca.ResumeLayout(False)
        Me.gbx_Boca.PerformLayout
        Me.gbx_Menton.ResumeLayout(False)
        Me.gbx_Menton.PerformLayout
        Me.gbx_Labios.ResumeLayout(False)
        Me.gbx_Labios.PerformLayout
        Me.gbx_Ojos.ResumeLayout(False)
        Me.gbx_Ojos.PerformLayout
        Me.gbx_Cejas.ResumeLayout(False)
        Me.gbx_Cejas.PerformLayout
        Me.gbx_Frente.ResumeLayout(False)
        Me.gbx_Frente.PerformLayout
        Me.gbx_Nariz.ResumeLayout(False)
        Me.gbx_Nariz.PerformLayout
        Me.gbx_Oreja.ResumeLayout(False)
        Me.gbx_Oreja.PerformLayout
        Me.gbx_Lobulo.ResumeLayout(False)
        Me.gbx_Lobulo.PerformLayout
        Me.gbx_Helix.ResumeLayout(False)
        Me.gbx_Helix.PerformLayout
        Me.gbx_Cabello.ResumeLayout(False)
        Me.gbx_Cabello.PerformLayout
        Me.tab_DatosEscolares.ResumeLayout(False)
        Me.tab_DatosEscolares.PerformLayout
        Me.gbx_CursosRecibidos.ResumeLayout(False)
        Me.gbx_CursosRecibidos.PerformLayout
        Me.gbx_CursoFinalizado.ResumeLayout(False)
        Me.gbx_CursoFinalizado.PerformLayout
        Me.tab_DatosFamiliares.ResumeLayout(False)
        Me.tab_DatosFamiliares.PerformLayout
        Me.gbx_Vive.ResumeLayout(False)
        Me.gbx_Vive.PerformLayout
        Me.gbx_MismoDomicilio.ResumeLayout(False)
        Me.gbx_MismoDomicilio.PerformLayout
        Me.gbx_DepEconomico.ResumeLayout(False)
        Me.gbx_DepEconomico.PerformLayout
        Me.tab_Empleos.ResumeLayout(False)
        Me.tab_Empleos.PerformLayout
        Me.gbx_EmpresaSeg.ResumeLayout(False)
        Me.gbx_EmpresaSeg.PerformLayout
        Me.gbx_PorteArmas.ResumeLayout(False)
        Me.gbx_PorteArmas.PerformLayout
        Me.tab_Referencias.ResumeLayout(False)
        Me.tab_Referencias.PerformLayout
        Me.gbx_Genero_Referencias.ResumeLayout(False)
        Me.gbx_Genero_Referencias.PerformLayout
        Me.tab_DatosVarios.ResumeLayout(False)
        Me.tab_DatosVarios.PerformLayout
        Me.gbx_VehiculoPropio.ResumeLayout(False)
        Me.gbx_VehiculoPropio.PerformLayout
        Me.tab_PapeleriaRecibida.ResumeLayout(False)
        Me.tab_DatosEmergencia.ResumeLayout(False)
        Me.tab_DatosEmergencia.PerformLayout
        Me.tab_Adicionales.ResumeLayout(False)
        Me.tab_Adicionales.PerformLayout
        Me.gbx_EstudioSocioEco.ResumeLayout(False)
        Me.gbx_EstudioSocioEco.PerformLayout
        Me.gbx_ExamenAntidoping.ResumeLayout(False)
        Me.gbx_ExamenAntidoping.PerformLayout
        Me.gbx_Antecedentes.ResumeLayout(False)
        Me.gbx_Antecedentes.PerformLayout
        Me.gbx_ExamenMedico.ResumeLayout(False)
        Me.gbx_ExamenMedico.PerformLayout
        Me.gbx_ExamenPsicometrico.ResumeLayout(False)
        Me.gbx_ExamenPsicometrico.PerformLayout
        Me.tab_Expediente.ResumeLayout(False)
        Me.tab_Expediente.PerformLayout
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_Nombres As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar_DG As System.Windows.Forms.Button
    Friend WithEvents tbx_Nombres As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EstadoCivil As System.Windows.Forms.Label
    Friend WithEvents cmb_EstadoCivil As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents cmb_Departamento_DG As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_CatalogoFirmas As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_CatFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CatFirmas As System.Windows.Forms.RadioButton
    Friend WithEvents tab_DatosEmpleado As System.Windows.Forms.TabControl
    Friend WithEvents tab_DatosGenerales As System.Windows.Forms.TabPage
    Friend WithEvents tab_DatosEscolares As System.Windows.Forms.TabPage
    Friend WithEvents tab_DatosFamiliares As System.Windows.Forms.TabPage
    Friend WithEvents tab_Empleos As System.Windows.Forms.TabPage
    Friend WithEvents tab_Referencias As System.Windows.Forms.TabPage
    Friend WithEvents tab_DatosVarios As System.Windows.Forms.TabPage
    Friend WithEvents tab_PapeleriaRecibida As System.Windows.Forms.TabPage
    Friend WithEvents cmb_UltimosEstudios As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Comprobable As System.Windows.Forms.Label
    Friend WithEvents lbl_UltimosEstudios2 As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreEscuela As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreEscuela As System.Windows.Forms.Label
    Friend WithEvents lbl_Promedio As System.Windows.Forms.Label
    Friend WithEvents lbl_Folio As System.Windows.Forms.Label
    Friend WithEvents lbl_ATermino As System.Windows.Forms.Label
    Friend WithEvents lbl_AInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_Carrera As System.Windows.Forms.Label
    Friend WithEvents lbl_Especialidad As System.Windows.Forms.Label
    Friend WithEvents tbx_Carrera As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Promedio As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Folio As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Especialidad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_Familiares As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_Telefono As System.Windows.Forms.Label
    Friend WithEvents lbl_Domicilio As System.Windows.Forms.Label
    Friend WithEvents lbl_FNacimiento As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreFamiliar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreFamiliar As System.Windows.Forms.Label
    Friend WithEvents gbx_DepEconomico As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Si_DepEcon As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_No_DepEcon As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_TelefonoFamiliares As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Domicilio_Familiares As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Parentesco As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Parentesco As System.Windows.Forms.Label
    Friend WithEvents lbl_Documentacion As System.Windows.Forms.Label
    Friend WithEvents cmb_Documentacion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_CursosRecibidos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Cursos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_Instructor As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreCurso As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaTermino As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreCurso As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Instructor As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoDocto As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_DG As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar_DatosEscolares As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar_Familiares As System.Windows.Forms.Button
    Friend WithEvents lbl_Comentarios As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentarios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents gbx_Vive As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Si_Vive As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_No_Vive As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_MismoDomicilio As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Si_MismoDom As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_No_MismoDom As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_FBaja As System.Windows.Forms.Label
    Friend WithEvents lbl_FIngreso As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_Empleos As System.Windows.Forms.Button
    Friend WithEvents lsv_Empleos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_CodigoPostal_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroInt_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroExt_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_Cp_Empleados As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ciudad_Empleos As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumeroInt_Empleos As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumeroExt_Empleos As System.Windows.Forms.Label
    Friend WithEvents tbx_Calle_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CalleE As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreEmpresa_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NombreEmpE As System.Windows.Forms.Label
    Friend WithEvents tbx_Puesto_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PuestoEmpleados As System.Windows.Forms.Label
    Friend WithEvents tbx_OtroMotivo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_OtroMotEmpleos As System.Windows.Forms.Label
    Friend WithEvents Lbl_MotSepEmpleos As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoFinal_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_SueFinMenEmpleos As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoInicial_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Telefono_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_SueIniMenEmpleos As System.Windows.Forms.Label
    Friend WithEvents Lbl_TelefonoEmpleados As System.Windows.Forms.Label
    Friend WithEvents tbx_PuestoJefe_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PueJefInmEmpleado As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreJefe_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NomJefInmEmpleos As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoReferencia As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_TipoReferencia As System.Windows.Forms.Label
    Friend WithEvents tbx_CodigoPostal_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroInt_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroExt_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CpR As System.Windows.Forms.Label
    Friend WithEvents Lbl_CiudadR As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumIntR As System.Windows.Forms.Label
    Friend WithEvents Lbl_NunExtR As System.Windows.Forms.Label
    Friend WithEvents tbx_Calle_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CalleR As System.Windows.Forms.Label
    Friend WithEvents tbx_Ocupacion_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents gbx_Genero_Referencias As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Masculino_Referencias As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Femenino_Referencias As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Nombre_Referencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreReferencia As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_Referencias As System.Windows.Forms.Button
    Friend WithEvents lsv_Referencias As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_GastoFamiliar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_GastoFamiliar As System.Windows.Forms.Label
    Friend WithEvents tbx_IngresoAdicional As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_IngresoFamiliar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_IngresoAdicional As System.Windows.Forms.Label
    Friend WithEvents lbl_IngresoFamiliar As System.Windows.Forms.Label
    Friend WithEvents tbx_PagoMensual As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_PagoMensual As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoVivienda As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_TipoVivienda As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion_IngresoAdicional As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_DescripcionIA As System.Windows.Forms.Label
    Friend WithEvents tbx_ValorVehiculo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ValorVehiculo As System.Windows.Forms.Label
    Friend WithEvents tbx_Modelo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Modelo As System.Windows.Forms.Label
    Friend WithEvents gbx_VehiculoPropio As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_Vehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_Vehiculo As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_ValorVivienda As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ValorVivienda As System.Windows.Forms.Label
    Friend WithEvents lbl_Mail As System.Windows.Forms.Label
    Friend WithEvents tbx_Mail As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Firmas As System.Windows.Forms.Label
    Friend WithEvents dtp_FInicioCurso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FTerminoCurso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FecNac_Familiar As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaBaja_Empleos As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaIngreso_Empleos As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_Vicios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Vicios As System.Windows.Forms.Label
    Friend WithEvents tbx_Habilidades As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Habilidades As System.Windows.Forms.Label
    Friend WithEvents tbx_ActividadesCulturales As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ActivCulturales As System.Windows.Forms.Label
    Friend WithEvents tbx_Idiomas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Idiomas As System.Windows.Forms.Label
    Friend WithEvents tbx_FormaSeñas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_FormaSeñas As System.Windows.Forms.Label
    Friend WithEvents cmb_SeñasParticulares As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Señas As System.Windows.Forms.Label
    Friend WithEvents Label62 As System.Windows.Forms.Label
    Friend WithEvents tbx_UbicacionSeñas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_UbicacionSeñas As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_DatosVarios As System.Windows.Forms.Button
    Friend WithEvents tbx_CantidadSeñas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CantidadSeñas As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_PapeleriaRecibida As System.Windows.Forms.Button
    Friend WithEvents tbx_CodigoPostal As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumInterior As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumExterior As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Colonia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CP As System.Windows.Forms.Label
    Friend WithEvents lbl_Ciudad_DG As System.Windows.Forms.Label
    Friend WithEvents lbl_NumInterior As System.Windows.Forms.Label
    Friend WithEvents lbl_NumExterior As System.Windows.Forms.Label
    Friend WithEvents lbl_Colonia As System.Windows.Forms.Label
    Friend WithEvents tbx_Calle As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Calle As System.Windows.Forms.Label
    Friend WithEvents lbl_Zona_DG As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaNac As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaNac As System.Windows.Forms.Label
    Friend WithEvents tbx_TelefonoMovil1 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_TelefonoMovil1 As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono1 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Telefono1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Edad As System.Windows.Forms.Label
    Friend WithEvents lbl_LugarNac As System.Windows.Forms.Label
    Friend WithEvents tbx_CURP As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CURP As System.Windows.Forms.Label
    Friend WithEvents tbx_RFC As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_RFC As System.Windows.Forms.Label
    Friend WithEvents tbx_Elector As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Elector As System.Windows.Forms.Label
    Friend WithEvents tbx_NumCartilla As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NumCartilla As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaExpira As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoLicencia As System.Windows.Forms.Label
    Friend WithEvents tbx_IMSS As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_IMSS As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoLicencia As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents dtp_FechaExpira As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_SueldoBase As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Sueldo As System.Windows.Forms.Label
    Friend WithEvents lbl_CertifAcademia As System.Windows.Forms.Label
    Friend WithEvents gbx_CertifAcademia As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_CertifAcademia As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CertifAcademia As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents cmb_DocumentoCurso As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_CursoFinalizado As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_CursoFin As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CursoFin As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Agregar_Familiares As System.Windows.Forms.Button
    Friend WithEvents cmb_Ciudades_DG As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Zonas As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_AInicio As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ATermino As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_Agregar_Empleos As System.Windows.Forms.Button
    Friend WithEvents cmb_Ciudades_Empleos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MotivoSeparacion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudades_Referencias As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar_Señas As System.Windows.Forms.Button
    Friend WithEvents lsv_SeñasParticulares As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_CantidadHijos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CantHijos As System.Windows.Forms.Label
    Friend WithEvents Lbl_EjemploDV As System.Windows.Forms.Label
    Friend WithEvents Lbl_Ejemplo2DV As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Label47 As System.Windows.Forms.Label
    Friend WithEvents Label46 As System.Windows.Forms.Label
    Friend WithEvents Label45 As System.Windows.Forms.Label
    Friend WithEvents Label44 As System.Windows.Forms.Label
    Friend WithEvents Label43 As System.Windows.Forms.Label
    Friend WithEvents lbl_DocumentoCursoA As System.Windows.Forms.Label
    Friend WithEvents lbl_FTerminoCursoA As System.Windows.Forms.Label
    Friend WithEvents lbl_FInicioCursoA As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreCursoA As System.Windows.Forms.Label
    Friend WithEvents Label54 As System.Windows.Forms.Label
    Friend WithEvents Label53 As System.Windows.Forms.Label
    Friend WithEvents Label52 As System.Windows.Forms.Label
    Friend WithEvents Label66 As System.Windows.Forms.Label
    Friend WithEvents Label64 As System.Windows.Forms.Label
    Friend WithEvents Label63 As System.Windows.Forms.Label
    Friend WithEvents Label61 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Telefono_Referencias As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentarios_Señas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Comentarios_Señas As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaBaja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents tbx_Fecha_FinLabores As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_AMaterno As System.Windows.Forms.Label
    Friend WithEvents lbl_APaterno As System.Windows.Forms.Label
    Friend WithEvents tbx_ApellidoMaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_ApellidoPaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreCompleto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NombreCompleto As System.Windows.Forms.Label
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaVenceCredencial As System.Windows.Forms.Label
    Friend WithEvents cmb_EmpleadoReferencia As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_EmpleadoReferencia As System.Windows.Forms.Label
    Friend WithEvents btn_Modificar_Familiares As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_DatosEscolares As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_DatosEscolares As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar_DatosEscolares As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar_DatosFamiliares As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_DatosFamiliares As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar_Empleos As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_Empleos As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_Empleos As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar_DatosVarios As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_DatosVarios As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_DatosVarios As System.Windows.Forms.Button
    Friend WithEvents btn_Fotos As System.Windows.Forms.Button
    Friend WithEvents tab_RasgosPersonales As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Cabello As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoSangreR As System.Windows.Forms.Label
    Friend WithEvents Lbl_ColorRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_ColRasgos As System.Windows.Forms.Label
    Friend WithEvents lbl_Cara As System.Windows.Forms.Label
    Friend WithEvents Label78 As System.Windows.Forms.Label
    Friend WithEvents Lbl_ComplexcionRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_CantidadRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_ImplantacionRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_CalvicieRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_FormaRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Ojos As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_ForRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_TamRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Cejas As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Tamaño As System.Windows.Forms.Label
    Friend WithEvents Lbl_ImplanRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_FRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_DireccionRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Frente As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_InclinRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_AnchRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_AltRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Nariz As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_AlturaRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_BaseRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_DorsoRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_AnchoRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_RaizRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Boca As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_TamañoRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_ComisurasRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Menton As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_FormRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_InclinacionRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Labios As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_AlturaNasoLab As System.Windows.Forms.Label
    Friend WithEvents Lbl_ProminenciaRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_EspesorRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Oreja As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_PosteriorRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_OriginalRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_AdherenciaRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_FormaRas As System.Windows.Forms.Label
    Friend WithEvents Lbl_SuperiorRasgos As System.Windows.Forms.Label
    Friend WithEvents btn_GuardarRasgos As System.Windows.Forms.Button
    Friend WithEvents Lbl_ContornoRasgos As System.Windows.Forms.Label
    Friend WithEvents btn_CancelarRasgos As System.Windows.Forms.Button
    Friend WithEvents gbx_Helix As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lobulo As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_ParticularidadRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_AdheRasgos As System.Windows.Forms.Label
    Friend WithEvents Lbl_DimensionRasgos As System.Windows.Forms.Label
    Friend WithEvents gbx_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents tbx_EstaturaR As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_EstaturaRasgos As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents tbx_PesoR As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PesoRasgos As System.Windows.Forms.Label
    Friend WithEvents lbl_ColoniaEmpleos As System.Windows.Forms.Label
    Friend WithEvents lbl_UsaAnteojos As System.Windows.Forms.Label
    Friend WithEvents cmb_UsaAnteojos As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_Cara As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_CantidadCabello As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_AnchoFrente As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_InclinacionFrente As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_AlturaFrente As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ImplantacionCabello As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_Calvicie As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_FormaCabello As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_TamañoCejas As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_FormaCejas As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ImplantacionCejas As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_DireccionCejas As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_TamañoOjos As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_FormaOjos As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_AlturaNariz As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_BaseNariz As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_AnchoNariz As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_DorsoNariz As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_RaizNariz As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ComisurasBoca As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_TamañoBoca As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_EspesorLabios As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_InclinacionMenton As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_FormaMenton As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_TipoMenton As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ProminenciaLabios As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_AlturaNasoLabial As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_OriginalOreja As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_FormaOreja As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_LobuloDimension As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_LobuloParticularidad As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_LobuloAdherencia As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_HelixContorno As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_HelixAdherencia As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_HelixPosterior As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_HelixSuperior As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents tbx_CedulaProfesional As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CedulaProf As System.Windows.Forms.Label
    Friend WithEvents tbx_Pasaporte As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Pasaporte As System.Windows.Forms.Label
    Friend WithEvents cmb_FactorRH As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_TipoSangreR As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents lbl_FactorRH As System.Windows.Forms.Label
    Friend WithEvents cmb_ModoNacionalidad As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents lbl_PaisNacimiento As System.Windows.Forms.Label
    Friend WithEvents lbl_ModoNacionalidad As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaNaturalizacion As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaNaturalizacion As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreCalle2 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle2 As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreCalle1 As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle1 As System.Windows.Forms.Label
    Friend WithEvents lbl_PorteArmas As System.Windows.Forms.Label
    Friend WithEvents gbx_PorteArmas As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_PorteArmas As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_PorteArmas As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_EntreCalle2Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle2Empleos As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreCalle1Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle1Empleos As System.Windows.Forms.Label
    Friend WithEvents lbl_EmpresaSeguridad As System.Windows.Forms.Label
    Friend WithEvents gbx_EmpresaSeg As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_EmpresaSeg As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_EmpresaSeg As System.Windows.Forms.RadioButton
    Friend WithEvents Label79 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreCalle2_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle2_Referencias As System.Windows.Forms.Label
    Friend WithEvents tbx_EntreCalle1_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_EntreCalle1_Referencias As System.Windows.Forms.Label
    Friend WithEvents lbl_Colonia_Referencias As System.Windows.Forms.Label
    Friend WithEvents Label124 As System.Windows.Forms.Label
    Friend WithEvents Label119 As System.Windows.Forms.Label
    Friend WithEvents Label126 As System.Windows.Forms.Label
    Friend WithEvents Label125 As System.Windows.Forms.Label
    Friend WithEvents Label128 As System.Windows.Forms.Label
    Friend WithEvents Label127 As System.Windows.Forms.Label
    Friend WithEvents lbl_CursoFinalizadoA As System.Windows.Forms.Label
    Friend WithEvents Label140 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents lbl_JefeArea As System.Windows.Forms.Label
    Friend WithEvents gbx_JefeArea As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_JefeArea As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_JefeArea As System.Windows.Forms.RadioButton
    Friend WithEvents tbx_Longitud As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Latitud As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Longitud As System.Windows.Forms.Label
    Friend WithEvents lbl_Latitud As System.Windows.Forms.Label
    Friend WithEvents tbx_LongitudEmpleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_LatitudEmpleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_LongitudEmpleos As System.Windows.Forms.Label
    Friend WithEvents lbl_LatitudEmpleos As System.Windows.Forms.Label
    Friend WithEvents lsv_PredictivoEmpresas As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Mapa As System.Windows.Forms.Button
    Friend WithEvents btn_MapaLaborales As System.Windows.Forms.Button
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_MostrarCatalogo As System.Windows.Forms.Button
    Friend WithEvents Lbl_PuestoL As System.Windows.Forms.Label
    Friend WithEvents Lbl_DepartamentoL As System.Windows.Forms.Label
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_UMF As System.Windows.Forms.Label
    Friend WithEvents tbx_UMF As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents btn_BuscarEmpleados As System.Windows.Forms.Button
    Friend WithEvents Lbl_SaldraDG As System.Windows.Forms.Label
    Friend WithEvents gbx_Ruta As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_Ruta As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_Ruta As System.Windows.Forms.RadioButton
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents lbl_Infonavit As System.Windows.Forms.Label
    Friend WithEvents gbx_CreditoInfonavit As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_CreditoInfonavit As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CreditoInfonavit As System.Windows.Forms.RadioButton
    Friend WithEvents btn_UMF As System.Windows.Forms.Button
    Friend WithEvents Label153 As System.Windows.Forms.Label
    Friend WithEvents Label152 As System.Windows.Forms.Label
    Friend WithEvents Label76 As System.Windows.Forms.Label
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents btn_Visitas As System.Windows.Forms.Button
    Friend WithEvents btn_Codigo As System.Windows.Forms.Button
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Lbl_VerificaraDepoDG As System.Windows.Forms.Label
    Friend WithEvents gbx_Verifica As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_Verifica As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_Verifica As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_TipoCurso As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoCursoA As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoCurso As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_BuscarCurso As System.Windows.Forms.Button
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_StatusL As System.Windows.Forms.Label
    Friend WithEvents pct_RasgoFrente As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DoctosImportar As System.Windows.Forms.Button
    Friend WithEvents btn_RasgoFrente As System.Windows.Forms.Button
    Friend WithEvents btn_RasgoPerfilIzq As System.Windows.Forms.Button
    Friend WithEvents btn_RasgoPerfilDer As System.Windows.Forms.Button
    Friend WithEvents pct_RasgoPerfilIzq As System.Windows.Forms.PictureBox
    Friend WithEvents pct_RasgoPerfilDer As System.Windows.Forms.PictureBox
    Friend WithEvents tlt_RasgosMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_CiudadNac As System.Windows.Forms.Label
    Friend WithEvents btn_RFC As System.Windows.Forms.Button
    Friend WithEvents btn_CURP As System.Windows.Forms.Button
    Friend WithEvents cmb_Pais As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudad As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Estado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Genero As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_GeneroDG As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents cmb_ViveConFam As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_ViveCFamiliaDG As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents cmb_ModoContactoD As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents cmb_ModoContacto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_EspecifiqueDG As System.Windows.Forms.Label
    Friend WithEvents Lbl_ModoContatoDg As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents btn_ComprobarListaNegra As System.Windows.Forms.Button
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Boleta As System.Windows.Forms.Button
    Friend WithEvents tbx_CUIP As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CUIP As System.Windows.Forms.Label
    Friend WithEvents tab_DatosEmergencia As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_EmailDE As System.Windows.Forms.Label
    Friend WithEvents tbx_Email_Emergencia As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Lbl_TipoRelacionDE As System.Windows.Forms.Label
    Friend WithEvents tbx_telefonoFijo_Emergencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Domicilio_Emergencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_TelefonoDE As System.Windows.Forms.Label
    Friend WithEvents Lbl_DomicilioDE As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre_Emergencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NombreDE As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar_Emergencia As System.Windows.Forms.Button
    Friend WithEvents Lbl_ObservacionesDE As System.Windows.Forms.Label
    Friend WithEvents rtb_Observaciones_Emergencia As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_Borrar_Emergencia As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar_Emergencia As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar_Emergencia As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar_Emergencia As System.Windows.Forms.Button
    Friend WithEvents lsv_datosEmergencia As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_Relacion_Emergencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents tbx_TelefonoCelular_Emergencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_TelefonoCelDE As System.Windows.Forms.Label
    Friend WithEvents Lbl_EmailDG As System.Windows.Forms.Label
    Friend WithEvents tbx_MailPersonal As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_PapeleriaRecibida As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents tab_ModoContacto As System.Windows.Forms.TabPage
    Friend WithEvents lsv_Contacto As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_Descripcion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_CancelarContac As System.Windows.Forms.Button
    Friend WithEvents btn_AgregarContactos As System.Windows.Forms.Button
    Friend WithEvents cmb_Localizacion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_EmpleadoP As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaVenceCredencial As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbx_Porte As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_PorteArmaNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PorteArmaSI As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_PortaArma As System.Windows.Forms.Label
    Friend WithEvents tab_Adicionales As System.Windows.Forms.TabPage
    Friend WithEvents lbl_ObservacionesGrales As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents lbl_AntecedentesPenales As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents lbl_EstudioSocioeconomico As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents lbl_ExamenMedico As System.Windows.Forms.Label
    Friend WithEvents lbl_Enfermedades As System.Windows.Forms.Label
    Friend WithEvents lbl_Demandas As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaAntidoping As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_Demandas As Modulo_Reclutamiento.cp_si_no
    Friend WithEvents gbx_Enfermedades As Modulo_Reclutamiento.cp_si_no
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_Antidoping As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_FichaTecnica As System.Windows.Forms.Button
    Friend WithEvents tbx_Edad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_CancelarAdicionales As System.Windows.Forms.Button
    Friend WithEvents tbx_ObservEnfermedades As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ObservAntecedentes As System.Windows.Forms.TextBox
    Friend WithEvents dtp_FechaPsicometrico As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_ObservPsicometrico As System.Windows.Forms.TextBox
    Friend WithEvents lbl_ExaPsicometrico As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents tbx_ObservEstudioSE As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ObservExaMedico As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ObservDemandas As System.Windows.Forms.TextBox
    Friend WithEvents tbx_ObservAntidoping As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents lbl_ResultadoAntidoping As System.Windows.Forms.Label
    Friend WithEvents tbx_ObservacionesGrales As System.Windows.Forms.TextBox
    Friend WithEvents gbx_ExamenAntidoping As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_AntidopingNo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_AntidopingSI As System.Windows.Forms.RadioButton
    Friend WithEvents dtp_FechaCartaApenales As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaExamenMedico As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaESocioeconomico As System.Windows.Forms.DateTimePicker
    Friend WithEvents gbx_EstudioSocioEco As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ESocioNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ESocioSI As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_Antecedentes As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_CartaAPNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_CartaAPSI As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_ExamenMedico As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ExMedNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ExMedSI As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_ExamenPsicometrico As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_ExPsicoNO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_ExPsicoSI As System.Windows.Forms.RadioButton
    Friend WithEvents tab_Expediente As System.Windows.Forms.TabPage
    Friend WithEvents lbl_EstacionActualiza As System.Windows.Forms.Label
    Friend WithEvents tbx_EstacionActualiza As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ComentariosRevision As System.Windows.Forms.Label
    Friend WithEvents tbx_ComentariosRevision As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents dtp_FechaUltimaActual As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_UsuarioUltimaActual As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_UsuarioUltActual As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaUltimaActualiz As System.Windows.Forms.Label
    Friend WithEvents dtp_Fecharevision As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_UsuarioRevisa As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_UsuarioRevisa As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaRevision As System.Windows.Forms.Label
    Friend WithEvents btn_CancelarExpediente As System.Windows.Forms.Button
    Friend WithEvents btn_GuardarExpediente As System.Windows.Forms.Button
    Friend WithEvents lbl_FechaActualizacionDG As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaActualDGview As System.Windows.Forms.Label
    Friend WithEvents btn_DoctosCancelar As System.Windows.Forms.Button
    Friend WithEvents tbx_MontoDescuento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_MontoDescuento As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoDescuento As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents lbl_TipoDescuento As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroCredito As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NumeroCredito As System.Windows.Forms.Label
    Friend WithEvents btn_MapaEmpleado As System.Windows.Forms.Button
    Friend WithEvents cmb_Paises_Empleos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Paises_Referencias As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_ImprimirSolicitud As System.Windows.Forms.Button
    Friend WithEvents cmb_ColorPiel As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ColorCabello As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ColorOjos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_ComplexionR As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_PaisesDatosFamiliares As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents cmb_CiudadesDatosFamiliares As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroLicencia As cp_Textbox
    Friend WithEvents lbl_NumeroLicencia As Label
    Friend WithEvents tbx_IdTributario As cp_Textbox
    Friend WithEvents lbl_RFC_Extranjero As Label
    Friend WithEvents tbx_NumeroLicenciaFed As cp_Textbox
    Friend WithEvents lbl_NumeroLicenciaFed As Label
    Friend WithEvents dtp_FechaExpiraFed As DateTimePicker
    Friend WithEvents lbl_FechaExpiraFed As Label
    Friend WithEvents cmb_Colonias As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label22 As Label
    Friend WithEvents tbx_Colonias_Referencias As TextBox
    Friend WithEvents tbx_Colonias_Empleos As TextBox
    Friend WithEvents Btn_AgregarColonia As Button
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cmb_vista As cp_cmb_Manual
    Friend WithEvents Label24 As Label
    Friend WithEvents cmb_lado As cp_cmb_Manual
    Friend WithEvents cmb_region As cp_cmb_Manual
    Friend WithEvents btn_refionesSSP As Button
    Friend WithEvents cmb_cantidad As cp_cmb_Manual
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdb_positivassp As RadioButton
    Friend WithEvents rdb_negativassp As RadioButton
    Friend WithEvents chk_federal As CheckBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents rdb_optvossp As RadioButton
    Friend WithEvents rdb_adtvossp As RadioButton
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_estatal As CheckBox
    Friend WithEvents Label36 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_am As cp_Textbox
    Friend WithEvents txt_ap As cp_Textbox
    Friend WithEvents Label23 As Label
    Friend WithEvents cmb_ocupacion As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_OcupacionR As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label48 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdb_LPCno As RadioButton
    Friend WithEvents rdb_LPCsi As RadioButton
    Friend WithEvents btn_Investigacion As Button
    Friend WithEvents btn_InvestigacionPersonal As Button
End Class
