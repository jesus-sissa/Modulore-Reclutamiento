<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_EmpleadosP
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmpleadosP))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter3 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter4 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter5 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter6 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter7 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter8 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter9 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter10 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter11 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.chk_Aptos = New System.Windows.Forms.CheckBox()
        Me.lbl_apto = New System.Windows.Forms.Label()
        Me.cmb_aptos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_Hasta = New System.Windows.Forms.Label()
        Me.Lbl_Desde = New System.Windows.Forms.Label()
        Me.Dtp_Desde = New System.Windows.Forms.DateTimePicker()
        Me.Dtp_Hasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_Numero = New System.Windows.Forms.Label()
        Me.btn_Baja = New System.Windows.Forms.Button()
        Me.chk_Status = New System.Windows.Forms.CheckBox()
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_Visitas = New System.Windows.Forms.Button()
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox()
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox()
        Me.btn_Modificar = New System.Windows.Forms.Button()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Mapa = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button()
        Me.btn_Buscar = New System.Windows.Forms.Button()
        Me.Lbl_LStatus = New System.Windows.Forms.Label()
        Me.Lbl_LPuesto = New System.Windows.Forms.Label()
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_LDepartamento = New System.Windows.Forms.Label()
        Me.lbl_Buscar = New System.Windows.Forms.Label()
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview()
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.tab_DatosEmpleado = New System.Windows.Forms.TabControl()
        Me.tab_DatosGenerales = New System.Windows.Forms.TabPage()
        Me.Btn_AgregarColonia = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
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
        Me.tbx_NumCartilla = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_RFC_Extranjero = New System.Windows.Forms.Label()
        Me.tbx_NumeroLicencia = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NumeroLicencia = New System.Windows.Forms.Label()
        Me.tbx_MontoDescuento = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_MontoDescuento = New System.Windows.Forms.Label()
        Me.cmb_TipoDescuento = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_TipoDescuento = New System.Windows.Forms.Label()
        Me.tbx_NumeroCredito = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_NumeroCredito = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_NombreCompleto = New System.Windows.Forms.Label()
        Me.tbx_ExpInfonavit = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DGInfonavit = New System.Windows.Forms.Label()
        Me.btn_ComprobarListaNegra = New System.Windows.Forms.Button()
        Me.Label155 = New System.Windows.Forms.Label()
        Me.cmb_Verifica = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.btn_Guardar_DG = New System.Windows.Forms.Button()
        Me.cmb_Ruta = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_JefeArea = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_CertifAcademia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.dtp_FechaIngreso = New System.Windows.Forms.DateTimePicker()
        Me.cmb_CatalogoFirmas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_CreditoInfonavit = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ModoContactoD = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_Mail = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Telefono1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_TelefonoMovil1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Elector = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_RFC = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label163 = New System.Windows.Forms.Label()
        Me.cmb_ModoContacto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_DGEspecifique = New System.Windows.Forms.Label()
        Me.Lbl_DGModoContacto = New System.Windows.Forms.Label()
        Me.cmb_Ciudad = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_ModoNacionalidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Estado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Pais = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_RFC = New System.Windows.Forms.Button()
        Me.btn_CURP = New System.Windows.Forms.Button()
        Me.lbl_CiudadNac = New System.Windows.Forms.Label()
        Me.btn_Validar = New System.Windows.Forms.Button()
        Me.Lbl_DGEjemplo = New System.Windows.Forms.Label()
        Me.Label156 = New System.Windows.Forms.Label()
        Me.Lbl_DgVerificara = New System.Windows.Forms.Label()
        Me.Label154 = New System.Windows.Forms.Label()
        Me.btn_UMF = New System.Windows.Forms.Button()
        Me.lbl_Infonavit = New System.Windows.Forms.Label()
        Me.Label151 = New System.Windows.Forms.Label()
        Me.Label150 = New System.Windows.Forms.Label()
        Me.lbl_UMF = New System.Windows.Forms.Label()
        Me.cmb_EmpleadoReferencia = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_EmpleadoReferencia = New System.Windows.Forms.Label()
        Me.tbx_NombreCompleto = New Modulo_Reclutamiento.cp_Textbox()
        Me.cmb_Departamento_DG = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_SueldoBase = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Calle = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_EntreCalle1 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_EntreCalle2 = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumExterior = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_NumInterior = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label69 = New System.Windows.Forms.Label()
        Me.lbl_AMaterno = New System.Windows.Forms.Label()
        Me.lbl_APaterno = New System.Windows.Forms.Label()
        Me.tbx_ApellidoMaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_ApellidoPaterno = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Fecha_FinLabores = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_FechaBaja = New System.Windows.Forms.Label()
        Me.lbl_FechaIngreso = New System.Windows.Forms.Label()
        Me.Lbl_DGViveFamilia = New System.Windows.Forms.Label()
        Me.Label144 = New System.Windows.Forms.Label()
        Me.Label140 = New System.Windows.Forms.Label()
        Me.Label142 = New System.Windows.Forms.Label()
        Me.Label42 = New System.Windows.Forms.Label()
        Me.Label41 = New System.Windows.Forms.Label()
        Me.Label40 = New System.Windows.Forms.Label()
        Me.lbl_CantHijos = New System.Windows.Forms.Label()
        Me.cmb_Ciudades_DG = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_CertifAcademia = New System.Windows.Forms.Label()
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
        Me.dtp_FechaNaturalizacion = New System.Windows.Forms.DateTimePicker()
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
        Me.lbl_Genero = New System.Windows.Forms.Label()
        Me.Label139 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_Mail = New System.Windows.Forms.Label()
        Me.tbx_Nombres = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Cancelar_DG = New System.Windows.Forms.Button()
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Nombres = New System.Windows.Forms.Label()
        Me.lbl_Clave = New System.Windows.Forms.Label()
        Me.lbl_Departamento = New System.Windows.Forms.Label()
        Me.lbl_Puesto = New System.Windows.Forms.Label()
        Me.lbl_EstadoCivil = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label149 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tab_Contacto = New System.Windows.Forms.TabPage()
        Me.cmb_Localizacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.btn_AgregarContactos = New System.Windows.Forms.Button()
        Me.btn_borrarP = New System.Windows.Forms.Button()
        Me.btn_cancelarP = New System.Windows.Forms.Button()
        Me.lsv_Contacto = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_Descripcion = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Descripcion = New System.Windows.Forms.Label()
        Me.lbl_Contacto = New System.Windows.Forms.Label()
        Me.tab_Entrevistas = New System.Windows.Forms.TabPage()
        Me.btn_EntrevistasCancelar = New System.Windows.Forms.Button()
        Me.gbx_Entrevistas = New System.Windows.Forms.GroupBox()
        Me.lsv_Entrevistas = New Modulo_Reclutamiento.cp_Listview()
        Me.gbx_Entrevista = New System.Windows.Forms.GroupBox()
        Me.Label50 = New System.Windows.Forms.Label()
        Me.Label51 = New System.Windows.Forms.Label()
        Me.Label129 = New System.Windows.Forms.Label()
        Me.Label158 = New System.Windows.Forms.Label()
        Me.cmb_EmpleadoEntrevista = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_ComentariosEntrevista = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Agregar_Entrevista = New System.Windows.Forms.Button()
        Me.tbx_ClaveE = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_Nombre_Baja = New System.Windows.Forms.Label()
        Me.dtp_FechaEntrevista = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_EApto = New System.Windows.Forms.Label()
        Me.Lbl_EFecha = New System.Windows.Forms.Label()
        Me.gbx_Apto = New System.Windows.Forms.GroupBox()
        Me.rdb_NoApto = New System.Windows.Forms.RadioButton()
        Me.rdb_SiApto = New System.Windows.Forms.RadioButton()
        Me.Lbl_EComentarios = New System.Windows.Forms.Label()
        Me.tab_Foto = New System.Windows.Forms.TabPage()
        Me.btn_FotografiaCancelar = New System.Windows.Forms.Button()
        Me.gbx_FrenteFormal = New System.Windows.Forms.GroupBox()
        Me.btn_Guardar_FotoFormal = New System.Windows.Forms.Button()
        Me.btn_ImportaFormal = New System.Windows.Forms.Button()
        Me.btn_TomarFrenteFormal = New System.Windows.Forms.Button()
        Me.pct_FrenteFormal = New System.Windows.Forms.PictureBox()
        Me.btn_LimpiarFrenteFormal = New System.Windows.Forms.Button()
        Me.Lbl_EFotografia = New System.Windows.Forms.Label()
        Me.gbx_FotoProspecto = New System.Windows.Forms.GroupBox()
        Me.btn_Guardar_Foto = New System.Windows.Forms.Button()
        Me.btn_Importa = New System.Windows.Forms.Button()
        Me.btn_TomarFrente = New System.Windows.Forms.Button()
        Me.pct_Frente = New System.Windows.Forms.PictureBox()
        Me.btn_LimpiarFrente = New System.Windows.Forms.Button()
        Me.tab_RasgosPersonales = New System.Windows.Forms.TabPage()
        Me.gbx_Principales = New System.Windows.Forms.GroupBox()
        Me.pct_RasgoFrente = New System.Windows.Forms.PictureBox()
        Me.cmb_ColorPiel = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FactorRH = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TipoSangreR = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ComplexionR = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Cara = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_UsaAnteojos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label112 = New System.Windows.Forms.Label()
        Me.tbx_EstaturaR = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_REstatura = New System.Windows.Forms.Label()
        Me.Label116 = New System.Windows.Forms.Label()
        Me.Lbl_RComplexion = New System.Windows.Forms.Label()
        Me.tbx_PesoR = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_RPeso = New System.Windows.Forms.Label()
        Me.Lbl_RColorPiel = New System.Windows.Forms.Label()
        Me.lbl_Cara = New System.Windows.Forms.Label()
        Me.lbl_UsaAnteojos = New System.Windows.Forms.Label()
        Me.lbl_FactorRH = New System.Windows.Forms.Label()
        Me.lbl_TipoSangreR = New System.Windows.Forms.Label()
        Me.gbx_Boca = New System.Windows.Forms.GroupBox()
        Me.cmb_ComisurasBoca = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TamañoBoca = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RTamaño3 = New System.Windows.Forms.Label()
        Me.Lbl_RComisuras = New System.Windows.Forms.Label()
        Me.gbx_Menton = New System.Windows.Forms.GroupBox()
        Me.Lbl_RForma3 = New System.Windows.Forms.Label()
        Me.Lbl_RInclinacion = New System.Windows.Forms.Label()
        Me.cmb_InclinacionMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_TipoMenton = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RTipo = New System.Windows.Forms.Label()
        Me.gbx_Labios = New System.Windows.Forms.GroupBox()
        Me.cmb_ProminenciaLabios = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AlturaNasoLabial = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_EspesorLabios = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RAlturaLabial = New System.Windows.Forms.Label()
        Me.Lbl_RProminencia = New System.Windows.Forms.Label()
        Me.Lbl_REspesor = New System.Windows.Forms.Label()
        Me.gbx_Ojos = New System.Windows.Forms.GroupBox()
        Me.Lbl_R_Forma2 = New System.Windows.Forms.Label()
        Me.Lbl_RTamaño = New System.Windows.Forms.Label()
        Me.cmb_TamañoOjos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ColorOjos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaOjos = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RColor2 = New System.Windows.Forms.Label()
        Me.gbx_Cejas = New System.Windows.Forms.GroupBox()
        Me.cmb_TamañoCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ImplantacionCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_DireccionCejas = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RTamaño2 = New System.Windows.Forms.Label()
        Me.Lbl_RImplantacion2 = New System.Windows.Forms.Label()
        Me.Lbl_RForma4 = New System.Windows.Forms.Label()
        Me.Lbl_RDireccion = New System.Windows.Forms.Label()
        Me.gbx_Frente = New System.Windows.Forms.GroupBox()
        Me.cmb_AnchoFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_InclinacionFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AlturaFrente = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RAltura2 = New System.Windows.Forms.Label()
        Me.Lbl_RAncho = New System.Windows.Forms.Label()
        Me.Lbl_RAltura = New System.Windows.Forms.Label()
        Me.gbx_Nariz = New System.Windows.Forms.GroupBox()
        Me.cmb_AlturaNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_BaseNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_AnchoNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_DorsoNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_RaizNariz = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RAltura3 = New System.Windows.Forms.Label()
        Me.Lbl_RBase = New System.Windows.Forms.Label()
        Me.Lbl_RDorso = New System.Windows.Forms.Label()
        Me.Lbl_RAncho2 = New System.Windows.Forms.Label()
        Me.Lbl_RRaiz = New System.Windows.Forms.Label()
        Me.gbx_Oreja = New System.Windows.Forms.GroupBox()
        Me.gbx_Lobulo = New System.Windows.Forms.GroupBox()
        Me.cmb_LobuloDimension = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_LobuloParticularidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_LobuloAdherencia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RParticularidad = New System.Windows.Forms.Label()
        Me.Lbl_RAdherencia = New System.Windows.Forms.Label()
        Me.Lbl_RDimension = New System.Windows.Forms.Label()
        Me.gbx_Helix = New System.Windows.Forms.GroupBox()
        Me.Lbl_RSuperior = New System.Windows.Forms.Label()
        Me.cmb_HelixContorno = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixAdherencia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixPosterior = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_HelixSuperior = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RPosterior = New System.Windows.Forms.Label()
        Me.Lbl_RAdherencia2 = New System.Windows.Forms.Label()
        Me.Lbl_RContorno = New System.Windows.Forms.Label()
        Me.cmb_OriginalOreja = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaOreja = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_ROriginal = New System.Windows.Forms.Label()
        Me.Lbl_RForma2 = New System.Windows.Forms.Label()
        Me.gbx_Cabello = New System.Windows.Forms.GroupBox()
        Me.cmb_ImplantacionCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_Calvicie = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_FormaCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ColorCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_CantidadCabello = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Lbl_RImplantacion = New System.Windows.Forms.Label()
        Me.Lbl_RCalvicie = New System.Windows.Forms.Label()
        Me.Lbl_RColor = New System.Windows.Forms.Label()
        Me.Lbl_RForma = New System.Windows.Forms.Label()
        Me.Lbl_RCantidad = New System.Windows.Forms.Label()
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
        Me.btn_Agregar_Curso = New System.Windows.Forms.Button()
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
        Me.btn_Borrar_DatosFamiliares = New System.Windows.Forms.Button()
        Me.btn_Cancelar_DatosFamiliares = New System.Windows.Forms.Button()
        Me.btn_Modificar_Familiares = New System.Windows.Forms.Button()
        Me.Label54 = New System.Windows.Forms.Label()
        Me.Label128 = New System.Windows.Forms.Label()
        Me.Label127 = New System.Windows.Forms.Label()
        Me.Label53 = New System.Windows.Forms.Label()
        Me.Label52 = New System.Windows.Forms.Label()
        Me.cmb_CiudadesFamiliares = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_TelefonoFamiliares = New Modulo_Reclutamiento.cp_Textbox()
        Me.rdb_Si_Vive = New System.Windows.Forms.RadioButton()
        Me.dtp_FecNac_Familiar = New System.Windows.Forms.DateTimePicker()
        Me.gbx_Vive = New System.Windows.Forms.GroupBox()
        Me.rdb_No_Vive = New System.Windows.Forms.RadioButton()
        Me.gbx_MismoDomicilio = New System.Windows.Forms.GroupBox()
        Me.rdb_Si_MismoDom = New System.Windows.Forms.RadioButton()
        Me.rdb_No_MismoDom = New System.Windows.Forms.RadioButton()
        Me.lbl_Ciudad = New System.Windows.Forms.Label()
        Me.cmb_Parentesco = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Parentesco = New System.Windows.Forms.Label()
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
        Me.btn_Investigacion = New System.Windows.Forms.Button()
        Me.tbx_Colonias_Empleos = New System.Windows.Forms.TextBox()
        Me.cmb_Paises_Empleos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_CodigoPostal_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_Telefono_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_LatitudEmpleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_LongitudEmpleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.dtp_FechaIngreso_Empleos = New System.Windows.Forms.DateTimePicker()
        Me.Label7 = New System.Windows.Forms.Label()
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
        Me.Label67 = New System.Windows.Forms.Label()
        Me.Label66 = New System.Windows.Forms.Label()
        Me.Label64 = New System.Windows.Forms.Label()
        Me.Label63 = New System.Windows.Forms.Label()
        Me.Label61 = New System.Windows.Forms.Label()
        Me.Label60 = New System.Windows.Forms.Label()
        Me.Label59 = New System.Windows.Forms.Label()
        Me.cmb_MotivoSeparacion = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.tbx_OtroMotivo = New Modulo_Reclutamiento.cp_Textbox()
        Me.btn_Agregar_Empleos = New System.Windows.Forms.Button()
        Me.cmb_Ciudades_Empleos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.dtp_FechaBaja_Empleos = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_OtroMotE = New System.Windows.Forms.Label()
        Me.Lbl_MotSepE = New System.Windows.Forms.Label()
        Me.tbx_SueldoFinal_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_SueFinMenE = New System.Windows.Forms.Label()
        Me.tbx_SueldoInicial_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_SueIniMenE = New System.Windows.Forms.Label()
        Me.Lbl_TelefonoE = New System.Windows.Forms.Label()
        Me.tbx_PuestoJefe_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_PuestJefInmE = New System.Windows.Forms.Label()
        Me.tbx_NombreJefe_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_NomJefInmE = New System.Windows.Forms.Label()
        Me.tbx_Puesto_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_PuestoE = New System.Windows.Forms.Label()
        Me.lbl_FBaja = New System.Windows.Forms.Label()
        Me.lbl_FIngreso = New System.Windows.Forms.Label()
        Me.btn_LimpiarLaborales = New System.Windows.Forms.Button()
        Me.btn_MapaLaborales = New System.Windows.Forms.Button()
        Me.btn_Borrar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Modificar_Empleos = New System.Windows.Forms.Button()
        Me.btn_Guardar_Empleos = New System.Windows.Forms.Button()
        Me.lsv_Empleos = New Modulo_Reclutamiento.cp_Listview()
        Me.Lbl_CPE = New System.Windows.Forms.Label()
        Me.Lbl_CiudadE = New System.Windows.Forms.Label()
        Me.Lbl_NumIntE = New System.Windows.Forms.Label()
        Me.Lbl_NumExtE = New System.Windows.Forms.Label()
        Me.tbx_Calle_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_CalleE = New System.Windows.Forms.Label()
        Me.tbx_NombreEmpresa_Empleos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_NomEmpresaE = New System.Windows.Forms.Label()
        Me.tab_Referencias = New System.Windows.Forms.TabPage()
        Me.btn_InvestigacionPersonal = New System.Windows.Forms.Button()
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
        Me.tbx_Colonia_Referencias = New System.Windows.Forms.TextBox()
        Me.cmb_Paises_Referencias = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label3 = New System.Windows.Forms.Label()
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
        Me.Lbl_CPR = New System.Windows.Forms.Label()
        Me.Lbl_CiudadR = New System.Windows.Forms.Label()
        Me.Lbl_NumIntR = New System.Windows.Forms.Label()
        Me.Lbl_NumExtR = New System.Windows.Forms.Label()
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
        Me.lbl_CantidadSeñas = New System.Windows.Forms.Label()
        Me.Label62 = New System.Windows.Forms.Label()
        Me.lbl_UbicacionSeñas = New System.Windows.Forms.Label()
        Me.tbx_UbicacionSeñas = New Modulo_Reclutamiento.cp_Textbox()
        Me.lbl_FormaSeñas = New System.Windows.Forms.Label()
        Me.cmb_SeñasParticulares = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.lbl_Señas = New System.Windows.Forms.Label()
        Me.Label124 = New System.Windows.Forms.Label()
        Me.Label119 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Lbl_DVEjemplo2 = New System.Windows.Forms.Label()
        Me.Lbl_DVEjemplo = New System.Windows.Forms.Label()
        Me.btn_refionesSSP = New System.Windows.Forms.Button()
        Me.btn_Borrar_DatosVarios = New System.Windows.Forms.Button()
        Me.btn_Cancelar_DatosVarios = New System.Windows.Forms.Button()
        Me.btn_Modificar_DatosVarios = New System.Windows.Forms.Button()
        Me.lsv_SeñasParticulares = New Modulo_Reclutamiento.cp_Listview()
        Me.tbx_CantidadSeñas = New Modulo_Reclutamiento.cp_Textbox()
        Me.tbx_FormaSeñas = New Modulo_Reclutamiento.cp_Textbox()
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
        Me.tab_DatosSocioEcon = New System.Windows.Forms.TabPage()
        Me.Gbx_DSocio2 = New System.Windows.Forms.GroupBox()
        Me.Tbx_DSComentarios = New Modulo_Reclutamiento.cp_Textbox()
        Me.Btn_DsAgregar = New System.Windows.Forms.Button()
        Me.Lbl_DSComentarios = New System.Windows.Forms.Label()
        Me.Lsv_DS = New Modulo_Reclutamiento.cp_Listview()
        Me.Tbx_DSCantidad = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSCantidad = New System.Windows.Forms.Label()
        Me.Label56 = New System.Windows.Forms.Label()
        Me.Tbx_DSUbicacion = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSUbicacion = New System.Windows.Forms.Label()
        Me.Tbx_DSForma = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSForma = New System.Windows.Forms.Label()
        Me.Cmb_DSSeñasPart = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_DSSeñasPart = New System.Windows.Forms.Label()
        Me.gbx_DSocio = New System.Windows.Forms.GroupBox()
        Me.Gbx_Idioma = New System.Windows.Forms.GroupBox()
        Me.Lbl_DsEjemplo2 = New System.Windows.Forms.Label()
        Me.Gbx_AfiliacionAgrupacion = New System.Windows.Forms.GroupBox()
        Me.Dtp_DSHasta = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DSHasta = New System.Windows.Forms.Label()
        Me.Tbx_DsNombre = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSNombre = New System.Windows.Forms.Label()
        Me.Dtp_DSDesde = New System.Windows.Forms.DateTimePicker()
        Me.Lbl_DSDesde = New System.Windows.Forms.Label()
        Me.Cmb_DSTipo = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_DSTipo = New System.Windows.Forms.Label()
        Me.Label122 = New System.Windows.Forms.Label()
        Me.Tbx_DSHabApidom = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label123 = New System.Windows.Forms.Label()
        Me.Lbl_DSHabApiDom = New System.Windows.Forms.Label()
        Me.Tbx_DSValor = New Modulo_Reclutamiento.cp_Textbox()
        Me.Label130 = New System.Windows.Forms.Label()
        Me.Lbl_DSEjemplo = New System.Windows.Forms.Label()
        Me.Tbx_DSModelo = New Modulo_Reclutamiento.cp_Textbox()
        Me.Tbx_DSIdiomasDominio = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSModelo = New System.Windows.Forms.Label()
        Me.Lbl_DSIdiomasDomina = New System.Windows.Forms.Label()
        Me.Gbx_Vehiculo = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.Rdb_DSSi2 = New System.Windows.Forms.RadioButton()
        Me.Tbx_DSVicios = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSVicios = New System.Windows.Forms.Label()
        Me.Tbx_DSValorVive = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSValorVivi = New System.Windows.Forms.Label()
        Me.Tbx_DSPagoMensual = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSPagoMen = New System.Windows.Forms.Label()
        Me.Cmb_DsTipoVivi = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Lbl_DSTipoVivienda = New System.Windows.Forms.Label()
        Me.Tbx_DSDescipcion = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSDescipcion = New System.Windows.Forms.Label()
        Me.Tbx_DSGastFamMens = New Modulo_Reclutamiento.cp_Textbox()
        Me.Tbx_DSIngAdi = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSGasFamMen = New System.Windows.Forms.Label()
        Me.Tbx_DsIngFamMen = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSIngAdi = New System.Windows.Forms.Label()
        Me.Lbl_DSIngFamMen = New System.Windows.Forms.Label()
        Me.Lbl_DSViveFam = New System.Windows.Forms.Label()
        Me.Gbx_ViveFam = New System.Windows.Forms.GroupBox()
        Me.Rdb_DSNo = New System.Windows.Forms.RadioButton()
        Me.Rdb_DSSi = New System.Windows.Forms.RadioButton()
        Me.Tbx_DsCantHijos = New Modulo_Reclutamiento.cp_Textbox()
        Me.Lbl_DSCantHijos = New System.Windows.Forms.Label()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btn_EliminarHuellaD = New System.Windows.Forms.Button()
        Me.btn_EliminarHuellasIzq = New System.Windows.Forms.Button()
        Me.btn_CapturarHuellas = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.pbx_HuellaDer = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.pbx_HuellaIzq = New System.Windows.Forms.PictureBox()
        Me.tlt_RasgosMensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.Tab_Catalogo.SuspendLayout
        Me.tab_Listado.SuspendLayout
        Me.Tab_Nuevo.SuspendLayout
        Me.tab_DatosEmpleado.SuspendLayout
        Me.tab_DatosGenerales.SuspendLayout
        Me.tab_Contacto.SuspendLayout
        Me.tab_Entrevistas.SuspendLayout
        Me.gbx_Entrevistas.SuspendLayout
        Me.gbx_Entrevista.SuspendLayout
        Me.gbx_Apto.SuspendLayout
        Me.tab_Foto.SuspendLayout
        Me.gbx_FrenteFormal.SuspendLayout
        CType(Me.pct_FrenteFormal, System.ComponentModel.ISupportInitialize).BeginInit
        Me.gbx_FotoProspecto.SuspendLayout
        CType(Me.pct_Frente, System.ComponentModel.ISupportInitialize).BeginInit
        Me.tab_RasgosPersonales.SuspendLayout
        Me.gbx_Principales.SuspendLayout
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
        Me.tab_DatosSocioEcon.SuspendLayout
        Me.Gbx_DSocio2.SuspendLayout
        Me.gbx_DSocio.SuspendLayout
        Me.Gbx_AfiliacionAgrupacion.SuspendLayout
        Me.Gbx_Vehiculo.SuspendLayout
        Me.Gbx_ViveFam.SuspendLayout
        Me.TabPage1.SuspendLayout
        Me.GroupBox2.SuspendLayout
        CType(Me.pbx_HuellaDer, System.ComponentModel.ISupportInitialize).BeginInit
        Me.GroupBox1.SuspendLayout
        CType(Me.pbx_HuellaIzq, System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Location = New System.Drawing.Point(2, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(1024, 731)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.chk_Aptos)
        Me.tab_Listado.Controls.Add(Me.lbl_apto)
        Me.tab_Listado.Controls.Add(Me.cmb_aptos)
        Me.tab_Listado.Controls.Add(Me.Lbl_Hasta)
        Me.tab_Listado.Controls.Add(Me.Lbl_Desde)
        Me.tab_Listado.Controls.Add(Me.Dtp_Desde)
        Me.tab_Listado.Controls.Add(Me.Dtp_Hasta)
        Me.tab_Listado.Controls.Add(Me.Lbl_Numero)
        Me.tab_Listado.Controls.Add(Me.btn_Baja)
        Me.tab_Listado.Controls.Add(Me.chk_Status)
        Me.tab_Listado.Controls.Add(Me.cmb_Status)
        Me.tab_Listado.Controls.Add(Me.btn_Visitas)
        Me.tab_Listado.Controls.Add(Me.cmb_PuestoFiltro)
        Me.tab_Listado.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.tab_Listado.Controls.Add(Me.chk_PuestoFiltro)
        Me.tab_Listado.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Mapa)
        Me.tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.tab_Listado.Controls.Add(Me.btn_MostrarCatalogo)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_LStatus)
        Me.tab_Listado.Controls.Add(Me.Lbl_LPuesto)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_LDepartamento)
        Me.tab_Listado.Controls.Add(Me.lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(1016, 705)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'chk_Aptos
        '
        Me.chk_Aptos.AutoSize = True
        Me.chk_Aptos.Location = New System.Drawing.Point(219, 142)
        Me.chk_Aptos.Name = "chk_Aptos"
        Me.chk_Aptos.Size = New System.Drawing.Size(56, 17)
        Me.chk_Aptos.TabIndex = 133
        Me.chk_Aptos.Text = "Todos"
        Me.chk_Aptos.UseVisualStyleBackColor = True
        '
        'lbl_apto
        '
        Me.lbl_apto.AutoSize = True
        Me.lbl_apto.Location = New System.Drawing.Point(42, 144)
        Me.lbl_apto.Name = "lbl_apto"
        Me.lbl_apto.Size = New System.Drawing.Size(29, 13)
        Me.lbl_apto.TabIndex = 132
        Me.lbl_apto.Text = "Apto"
        '
        'cmb_aptos
        '
        Me.cmb_aptos.Control_Siguiente = Nothing
        Me.cmb_aptos.DisplayMember = "display"
        Me.cmb_aptos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_aptos.FormattingEnabled = True
        Me.cmb_aptos.Location = New System.Drawing.Point(85, 140)
        Me.cmb_aptos.MaxDropDownItems = 20
        Me.cmb_aptos.Name = "cmb_aptos"
        Me.cmb_aptos.Size = New System.Drawing.Size(121, 21)
        Me.cmb_aptos.TabIndex = 131
        Me.cmb_aptos.ValueMember = "value"
        '
        'Lbl_Hasta
        '
        Me.Lbl_Hasta.AutoSize = True
        Me.Lbl_Hasta.Location = New System.Drawing.Point(216, 34)
        Me.Lbl_Hasta.Name = "Lbl_Hasta"
        Me.Lbl_Hasta.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_Hasta.TabIndex = 129
        Me.Lbl_Hasta.Text = "Hasta:"
        '
        'Lbl_Desde
        '
        Me.Lbl_Desde.AutoSize = True
        Me.Lbl_Desde.Location = New System.Drawing.Point(41, 35)
        Me.Lbl_Desde.Name = "Lbl_Desde"
        Me.Lbl_Desde.Size = New System.Drawing.Size(41, 13)
        Me.Lbl_Desde.TabIndex = 127
        Me.Lbl_Desde.Text = "Desde:"
        '
        'Dtp_Desde
        '
        Me.Dtp_Desde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Desde.Location = New System.Drawing.Point(88, 32)
        Me.Dtp_Desde.Name = "Dtp_Desde"
        Me.Dtp_Desde.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Desde.TabIndex = 128
        '
        'Dtp_Hasta
        '
        Me.Dtp_Hasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_Hasta.Location = New System.Drawing.Point(260, 32)
        Me.Dtp_Hasta.Name = "Dtp_Hasta"
        Me.Dtp_Hasta.Size = New System.Drawing.Size(99, 20)
        Me.Dtp_Hasta.TabIndex = 130
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(786, 139)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 22
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Baja
        '
        Me.btn_Baja.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Baja.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Baja.Enabled = False
        Me.btn_Baja.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Trash
        Me.btn_Baja.Location = New System.Drawing.Point(550, 567)
        Me.btn_Baja.Name = "btn_Baja"
        Me.btn_Baja.Size = New System.Drawing.Size(140, 30)
        Me.btn_Baja.TabIndex = 126
        Me.btn_Baja.Text = "&Baja"
        Me.btn_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Baja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Baja.UseVisualStyleBackColor = True
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(219, 116)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 125
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(85, 112)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(121, 21)
        Me.cmb_Status.TabIndex = 124
        Me.cmb_Status.ValueMember = "value"
        '
        'btn_Visitas
        '
        Me.btn_Visitas.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Visitas.Enabled = False
        Me.btn_Visitas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.CasaVisita
        Me.btn_Visitas.Location = New System.Drawing.Point(142, 567)
        Me.btn_Visitas.Name = "btn_Visitas"
        Me.btn_Visitas.Size = New System.Drawing.Size(130, 30)
        Me.btn_Visitas.TabIndex = 123
        Me.btn_Visitas.Text = "Visita &Domiciliaria"
        Me.btn_Visitas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Visitas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Visitas.UseVisualStyleBackColor = True
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(85, 85)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 122
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(85, 58)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 122
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(414, 87)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 121
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(414, 61)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 121
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(6, 567)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(878, 567)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Cerrar.TabIndex = 8
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Mapa
        '
        Me.btn_Mapa.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Mapa.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.MapaMundo
        Me.btn_Mapa.Location = New System.Drawing.Point(414, 567)
        Me.btn_Mapa.Name = "btn_Mapa"
        Me.btn_Mapa.Size = New System.Drawing.Size(130, 30)
        Me.btn_Mapa.TabIndex = 6
        Me.btn_Mapa.Text = "&Ver en Mapa"
        Me.btn_Mapa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mapa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mapa.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(278, 567)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Exportar.TabIndex = 6
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(330, 127)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(140, 30)
        Me.btn_MostrarCatalogo.TabIndex = 2
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
        'Lbl_LStatus
        '
        Me.Lbl_LStatus.AutoSize = True
        Me.Lbl_LStatus.Location = New System.Drawing.Point(42, 117)
        Me.Lbl_LStatus.Name = "Lbl_LStatus"
        Me.Lbl_LStatus.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_LStatus.TabIndex = 0
        Me.Lbl_LStatus.Text = "Status"
        '
        'Lbl_LPuesto
        '
        Me.Lbl_LPuesto.AutoSize = True
        Me.Lbl_LPuesto.Location = New System.Drawing.Point(39, 88)
        Me.Lbl_LPuesto.Name = "Lbl_LPuesto"
        Me.Lbl_LPuesto.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_LPuesto.TabIndex = 0
        Me.Lbl_LPuesto.Text = "Puesto"
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
        'Lbl_LDepartamento
        '
        Me.Lbl_LDepartamento.AutoSize = True
        Me.Lbl_LDepartamento.Location = New System.Drawing.Point(5, 61)
        Me.Lbl_LDepartamento.Name = "Lbl_LDepartamento"
        Me.Lbl_LDepartamento.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_LDepartamento.TabIndex = 0
        Me.Lbl_LDepartamento.Text = "Departamento"
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
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 167)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 32
        Me.lsv_Catalogo.Row3 = 14
        Me.lsv_Catalogo.Row4 = 14
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 10
        Me.lsv_Catalogo.Row9 = 10
        Me.lsv_Catalogo.Size = New System.Drawing.Size(1002, 394)
        Me.lsv_Catalogo.TabIndex = 3
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
        Me.Tab_Nuevo.Size = New System.Drawing.Size(1016, 705)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'tab_DatosEmpleado
        '
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosGenerales)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Contacto)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Entrevistas)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Foto)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_RasgosPersonales)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosEscolares)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosFamiliares)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Empleos)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Referencias)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosVarios)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_PapeleriaRecibida)
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_DatosSocioEcon)
        Me.tab_DatosEmpleado.Controls.Add(Me.TabPage1)
        Me.tab_DatosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_DatosEmpleado.Location = New System.Drawing.Point(3, 3)
        Me.tab_DatosEmpleado.Name = "tab_DatosEmpleado"
        Me.tab_DatosEmpleado.SelectedIndex = 0
        Me.tab_DatosEmpleado.Size = New System.Drawing.Size(1010, 699)
        Me.tab_DatosEmpleado.TabIndex = 0
        '
        'tab_DatosGenerales
        '
        Me.tab_DatosGenerales.Controls.Add(Me.Btn_AgregarColonia)
        Me.tab_DatosGenerales.Controls.Add(Me.Label6)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Colonias)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaExpiraFed)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaExpiraFed)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroLicenciaFed)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroLicenciaFed)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_IdTributario)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_RFC_Extranjero)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroLicencia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_MontoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_MontoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_TipoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_TipoDescuento)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NumeroCredito)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NumeroCredito)
        Me.tab_DatosGenerales.Controls.Add(Me.Label4)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_NombreCompleto)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_ExpInfonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DGInfonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_ComprobarListaNegra)
        Me.tab_DatosGenerales.Controls.Add(Me.Label155)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ViveConFam)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Genero)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Verifica)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Ruta)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_JefeArea)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_CertifAcademia)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_CatalogoFirmas)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_CreditoInfonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoContactoD)
        Me.tab_DatosGenerales.Controls.Add(Me.Label163)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoContacto)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DGEspecifique)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DGModoContacto)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Ciudad)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Estado)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Pais)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_RFC)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_CURP)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_CiudadNac)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Validar)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DGEjemplo)
        Me.tab_DatosGenerales.Controls.Add(Me.Label156)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DgVerificara)
        Me.tab_DatosGenerales.Controls.Add(Me.Label154)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Infonavit)
        Me.tab_DatosGenerales.Controls.Add(Me.Label151)
        Me.tab_DatosGenerales.Controls.Add(Me.Label150)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_UMF)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_ModoNacionalidad)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_EmpleadoReferencia)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EmpleadoReferencia)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_NombreCompleto)
        Me.tab_DatosGenerales.Controls.Add(Me.Label69)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_AMaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_APaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_ApellidoMaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_ApellidoPaterno)
        Me.tab_DatosGenerales.Controls.Add(Me.dtp_FechaIngreso)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Fecha_FinLabores)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaBaja)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_FechaIngreso)
        Me.tab_DatosGenerales.Controls.Add(Me.Lbl_DGViveFamilia)
        Me.tab_DatosGenerales.Controls.Add(Me.Label144)
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
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Genero)
        Me.tab_DatosGenerales.Controls.Add(Me.Label139)
        Me.tab_DatosGenerales.Controls.Add(Me.Label5)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Mail)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Mail)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Nombres)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Cancelar_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.tbx_Clave)
        Me.tab_DatosGenerales.Controls.Add(Me.btn_Guardar_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Departamento_DG)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_Puesto)
        Me.tab_DatosGenerales.Controls.Add(Me.cmb_EstadoCivil)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Nombres)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Clave)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Departamento)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_Puesto)
        Me.tab_DatosGenerales.Controls.Add(Me.lbl_EstadoCivil)
        Me.tab_DatosGenerales.Controls.Add(Me.Label2)
        Me.tab_DatosGenerales.Controls.Add(Me.Label149)
        Me.tab_DatosGenerales.Controls.Add(Me.Label1)
        Me.tab_DatosGenerales.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosGenerales.Name = "tab_DatosGenerales"
        Me.tab_DatosGenerales.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DatosGenerales.Size = New System.Drawing.Size(1002, 673)
        Me.tab_DatosGenerales.TabIndex = 0
        Me.tab_DatosGenerales.Text = "Datos Generales"
        Me.tab_DatosGenerales.UseVisualStyleBackColor = True
        '
        'Btn_AgregarColonia
        '
        Me.Btn_AgregarColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.25!)
        Me.Btn_AgregarColonia.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.add
        Me.Btn_AgregarColonia.Location = New System.Drawing.Point(179, 165)
        Me.Btn_AgregarColonia.Name = "Btn_AgregarColonia"
        Me.Btn_AgregarColonia.Size = New System.Drawing.Size(26, 21)
        Me.Btn_AgregarColonia.TabIndex = 11
        Me.Btn_AgregarColonia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AgregarColonia.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AgregarColonia.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(74, 164)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 16)
        Me.Label6.TabIndex = 169
        Me.Label6.Text = "*"
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
        Me.cmb_Colonias.ItemHeight = 13
        Me.cmb_Colonias.Location = New System.Drawing.Point(119, 189)
        Me.cmb_Colonias.MaxDropDownItems = 20
        Me.cmb_Colonias.Name = "cmb_Colonias"
        Me.cmb_Colonias.Pista = False
        Me.cmb_Colonias.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Colonias.StoredProcedure = "Cat_ColoniasCiudades_Get"
        Me.cmb_Colonias.Sucursal = False
        Me.cmb_Colonias.TabIndex = 13
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
        Me.cmb_Zonas.ItemHeight = 13
        Me.cmb_Zonas.Location = New System.Drawing.Point(119, 269)
        Me.cmb_Zonas.MaxDropDownItems = 20
        Me.cmb_Zonas.Name = "cmb_Zonas"
        Me.cmb_Zonas.Pista = True
        Me.cmb_Zonas.Size = New System.Drawing.Size(210, 21)
        Me.cmb_Zonas.StoredProcedure = "Cat_ZonasCiudades_Get"
        Me.cmb_Zonas.Sucursal = False
        Me.cmb_Zonas.TabIndex = 19
        Me.cmb_Zonas.Tipo = 0
        Me.cmb_Zonas.ValueMember = "id_Zona"
        '
        'tbx_CodigoPostal
        '
        Me.tbx_CodigoPostal.Control_Siguiente = Me.tbx_Latitud
        Me.tbx_CodigoPostal.Filtrado = True
        Me.tbx_CodigoPostal.Location = New System.Drawing.Point(119, 165)
        Me.tbx_CodigoPostal.MaxLength = 6
        Me.tbx_CodigoPostal.Name = "tbx_CodigoPostal"
        Me.tbx_CodigoPostal.Size = New System.Drawing.Size(57, 20)
        Me.tbx_CodigoPostal.TabIndex = 10
        Me.tbx_CodigoPostal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CodigoPostal.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Latitud
        '
        Me.tbx_Latitud.Control_Siguiente = Me.tbx_Longitud
        Me.tbx_Latitud.Filtrado = True
        Me.tbx_Latitud.Location = New System.Drawing.Point(119, 296)
        Me.tbx_Latitud.MaxLength = 11
        Me.tbx_Latitud.Name = "tbx_Latitud"
        Me.tbx_Latitud.Size = New System.Drawing.Size(86, 20)
        Me.tbx_Latitud.TabIndex = 20
        Me.tbx_Latitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Latitud.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Longitud
        '
        Me.tbx_Longitud.Control_Siguiente = Me.cmb_Genero
        Me.tbx_Longitud.Filtrado = True
        Me.tbx_Longitud.Location = New System.Drawing.Point(383, 296)
        Me.tbx_Longitud.MaxLength = 11
        Me.tbx_Longitud.Name = "tbx_Longitud"
        Me.tbx_Longitud.Size = New System.Drawing.Size(86, 20)
        Me.tbx_Longitud.TabIndex = 21
        Me.tbx_Longitud.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Longitud.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'cmb_Genero
        '
        Me.cmb_Genero.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_Genero.DisplayMember = "display"
        Me.cmb_Genero.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Genero.FormattingEnabled = True
        Me.cmb_Genero.Location = New System.Drawing.Point(119, 322)
        Me.cmb_Genero.MaxDropDownItems = 20
        Me.cmb_Genero.Name = "cmb_Genero"
        Me.cmb_Genero.Size = New System.Drawing.Size(114, 21)
        Me.cmb_Genero.TabIndex = 22
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
        Me.cmb_EstadoCivil.Location = New System.Drawing.Point(359, 322)
        Me.cmb_EstadoCivil.MaxDropDownItems = 20
        Me.cmb_EstadoCivil.Name = "cmb_EstadoCivil"
        Me.cmb_EstadoCivil.Pista = False
        Me.cmb_EstadoCivil.Size = New System.Drawing.Size(110, 21)
        Me.cmb_EstadoCivil.StoredProcedure = "Cat_EstadoCivilCombo_Get"
        Me.cmb_EstadoCivil.Sucursal = False
        Me.cmb_EstadoCivil.TabIndex = 23
        Me.cmb_EstadoCivil.Tipo = 0
        Me.cmb_EstadoCivil.ValueMember = "Id_EstadoCivil"
        '
        'cmb_ViveConFam
        '
        Me.cmb_ViveConFam.Control_Siguiente = Me.tbx_CantidadHijos
        Me.cmb_ViveConFam.DisplayMember = "display"
        Me.cmb_ViveConFam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ViveConFam.FormattingEnabled = True
        Me.cmb_ViveConFam.Location = New System.Drawing.Point(119, 349)
        Me.cmb_ViveConFam.MaxDropDownItems = 20
        Me.cmb_ViveConFam.Name = "cmb_ViveConFam"
        Me.cmb_ViveConFam.Size = New System.Drawing.Size(114, 21)
        Me.cmb_ViveConFam.TabIndex = 24
        Me.cmb_ViveConFam.ValueMember = "value"
        '
        'tbx_CantidadHijos
        '
        Me.tbx_CantidadHijos.Control_Siguiente = Me.dtp_FechaNac
        Me.tbx_CantidadHijos.Filtrado = True
        Me.tbx_CantidadHijos.Location = New System.Drawing.Point(419, 349)
        Me.tbx_CantidadHijos.MaxLength = 2
        Me.tbx_CantidadHijos.Name = "tbx_CantidadHijos"
        Me.tbx_CantidadHijos.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadHijos.TabIndex = 25
        Me.tbx_CantidadHijos.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CantidadHijos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'dtp_FechaNac
        '
        Me.dtp_FechaNac.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNac.Location = New System.Drawing.Point(119, 376)
        Me.dtp_FechaNac.Name = "dtp_FechaNac"
        Me.dtp_FechaNac.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FechaNac.TabIndex = 26
        Me.dtp_FechaNac.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'dtp_FechaExpiraFed
        '
        Me.dtp_FechaExpiraFed.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpiraFed.Location = New System.Drawing.Point(837, 242)
        Me.dtp_FechaExpiraFed.Name = "dtp_FechaExpiraFed"
        Me.dtp_FechaExpiraFed.Size = New System.Drawing.Size(97, 20)
        Me.dtp_FechaExpiraFed.TabIndex = 60
        Me.dtp_FechaExpiraFed.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_FechaExpiraFed
        '
        Me.lbl_FechaExpiraFed.AutoSize = True
        Me.lbl_FechaExpiraFed.Location = New System.Drawing.Point(704, 246)
        Me.lbl_FechaExpiraFed.Name = "lbl_FechaExpiraFed"
        Me.lbl_FechaExpiraFed.Size = New System.Drawing.Size(136, 13)
        Me.lbl_FechaExpiraFed.TabIndex = 167
        Me.lbl_FechaExpiraFed.Text = "Fecha Expira Licencia Fed:"
        '
        'tbx_NumeroLicenciaFed
        '
        Me.tbx_NumeroLicenciaFed.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumeroLicenciaFed.Filtrado = True
        Me.tbx_NumeroLicenciaFed.Location = New System.Drawing.Point(824, 216)
        Me.tbx_NumeroLicenciaFed.MaxLength = 50
        Me.tbx_NumeroLicenciaFed.Name = "tbx_NumeroLicenciaFed"
        Me.tbx_NumeroLicenciaFed.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroLicenciaFed.TabIndex = 58
        Me.tbx_NumeroLicenciaFed.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_UMF
        '
        Me.tbx_UMF.Control_Siguiente = Me.tbx_Pasaporte
        Me.tbx_UMF.Filtrado = True
        Me.tbx_UMF.Location = New System.Drawing.Point(823, 139)
        Me.tbx_UMF.MaxLength = 3
        Me.tbx_UMF.Name = "tbx_UMF"
        Me.tbx_UMF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_UMF.TabIndex = 51
        Me.tbx_UMF.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Pasaporte
        '
        Me.tbx_Pasaporte.Control_Siguiente = Me.cmb_TipoLicencia
        Me.tbx_Pasaporte.Filtrado = True
        Me.tbx_Pasaporte.Location = New System.Drawing.Point(602, 165)
        Me.tbx_Pasaporte.MaxLength = 10
        Me.tbx_Pasaporte.Name = "tbx_Pasaporte"
        Me.tbx_Pasaporte.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Pasaporte.TabIndex = 53
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
        Me.cmb_TipoLicencia.Location = New System.Drawing.Point(602, 215)
        Me.cmb_TipoLicencia.MaxDropDownItems = 20
        Me.cmb_TipoLicencia.MaxLength = 9
        Me.cmb_TipoLicencia.Name = "cmb_TipoLicencia"
        Me.cmb_TipoLicencia.Pista = False
        Me.cmb_TipoLicencia.Size = New System.Drawing.Size(110, 21)
        Me.cmb_TipoLicencia.StoredProcedure = "Cat_TipoLicenciaCombo_Get"
        Me.cmb_TipoLicencia.Sucursal = False
        Me.cmb_TipoLicencia.TabIndex = 57
        Me.cmb_TipoLicencia.Tipo = 0
        Me.cmb_TipoLicencia.ValueMember = "Id_TipoLicencia"
        '
        'dtp_FechaExpira
        '
        Me.dtp_FechaExpira.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaExpira.Location = New System.Drawing.Point(602, 242)
        Me.dtp_FechaExpira.Name = "dtp_FechaExpira"
        Me.dtp_FechaExpira.Size = New System.Drawing.Size(97, 20)
        Me.dtp_FechaExpira.TabIndex = 59
        Me.dtp_FechaExpira.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_NumeroLicenciaFed
        '
        Me.lbl_NumeroLicenciaFed.AutoSize = True
        Me.lbl_NumeroLicenciaFed.Location = New System.Drawing.Point(713, 219)
        Me.lbl_NumeroLicenciaFed.Name = "lbl_NumeroLicenciaFed"
        Me.lbl_NumeroLicenciaFed.Size = New System.Drawing.Size(108, 13)
        Me.lbl_NumeroLicenciaFed.TabIndex = 165
        Me.lbl_NumeroLicenciaFed.Text = "No. Licencia Federal:"
        '
        'tbx_IdTributario
        '
        Me.tbx_IdTributario.Control_Siguiente = Me.tbx_CURP
        Me.tbx_IdTributario.Filtrado = True
        Me.tbx_IdTributario.Location = New System.Drawing.Point(823, 190)
        Me.tbx_IdTributario.MaxLength = 15
        Me.tbx_IdTributario.Name = "tbx_IdTributario"
        Me.tbx_IdTributario.Size = New System.Drawing.Size(110, 20)
        Me.tbx_IdTributario.TabIndex = 56
        Me.tbx_IdTributario.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_CURP
        '
        Me.tbx_CURP.Control_Siguiente = Me.tbx_IMSS
        Me.tbx_CURP.Filtrado = True
        Me.tbx_CURP.Location = New System.Drawing.Point(602, 112)
        Me.tbx_CURP.MaxLength = 20
        Me.tbx_CURP.Name = "tbx_CURP"
        Me.tbx_CURP.Size = New System.Drawing.Size(143, 20)
        Me.tbx_CURP.TabIndex = 40
        Me.tbx_CURP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_IMSS
        '
        Me.tbx_IMSS.Control_Siguiente = Me.tbx_NumCartilla
        Me.tbx_IMSS.Filtrado = True
        Me.tbx_IMSS.Location = New System.Drawing.Point(823, 108)
        Me.tbx_IMSS.MaxLength = 11
        Me.tbx_IMSS.Name = "tbx_IMSS"
        Me.tbx_IMSS.Size = New System.Drawing.Size(110, 20)
        Me.tbx_IMSS.TabIndex = 42
        Me.tbx_IMSS.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_NumCartilla
        '
        Me.tbx_NumCartilla.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumCartilla.Filtrado = True
        Me.tbx_NumCartilla.Location = New System.Drawing.Point(602, 139)
        Me.tbx_NumCartilla.MaxLength = 10
        Me.tbx_NumCartilla.Name = "tbx_NumCartilla"
        Me.tbx_NumCartilla.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumCartilla.TabIndex = 50
        Me.tbx_NumCartilla.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_RFC_Extranjero
        '
        Me.lbl_RFC_Extranjero.AutoSize = True
        Me.lbl_RFC_Extranjero.Location = New System.Drawing.Point(750, 193)
        Me.lbl_RFC_Extranjero.Name = "lbl_RFC_Extranjero"
        Me.lbl_RFC_Extranjero.Size = New System.Drawing.Size(65, 13)
        Me.lbl_RFC_Extranjero.TabIndex = 163
        Me.lbl_RFC_Extranjero.Text = "id Tributario:"
        '
        'tbx_NumeroLicencia
        '
        Me.tbx_NumeroLicencia.Control_Siguiente = Me.tbx_UMF
        Me.tbx_NumeroLicencia.Filtrado = True
        Me.tbx_NumeroLicencia.Location = New System.Drawing.Point(602, 192)
        Me.tbx_NumeroLicencia.MaxLength = 50
        Me.tbx_NumeroLicencia.Name = "tbx_NumeroLicencia"
        Me.tbx_NumeroLicencia.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroLicencia.TabIndex = 55
        Me.tbx_NumeroLicencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_NumeroLicencia
        '
        Me.lbl_NumeroLicencia.AutoSize = True
        Me.lbl_NumeroLicencia.Location = New System.Drawing.Point(529, 195)
        Me.lbl_NumeroLicencia.Name = "lbl_NumeroLicencia"
        Me.lbl_NumeroLicencia.Size = New System.Drawing.Size(70, 13)
        Me.lbl_NumeroLicencia.TabIndex = 141
        Me.lbl_NumeroLicencia.Text = "No. Licencia:"
        '
        'tbx_MontoDescuento
        '
        Me.tbx_MontoDescuento.Control_Siguiente = Me.cmb_TipoLicencia
        Me.tbx_MontoDescuento.Enabled = False
        Me.tbx_MontoDescuento.Filtrado = True
        Me.tbx_MontoDescuento.Location = New System.Drawing.Point(823, 297)
        Me.tbx_MontoDescuento.MaxLength = 20
        Me.tbx_MontoDescuento.Name = "tbx_MontoDescuento"
        Me.tbx_MontoDescuento.Size = New System.Drawing.Size(110, 20)
        Me.tbx_MontoDescuento.TabIndex = 64
        Me.tbx_MontoDescuento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'lbl_MontoDescuento
        '
        Me.lbl_MontoDescuento.AutoSize = True
        Me.lbl_MontoDescuento.Enabled = False
        Me.lbl_MontoDescuento.Location = New System.Drawing.Point(712, 301)
        Me.lbl_MontoDescuento.Name = "lbl_MontoDescuento"
        Me.lbl_MontoDescuento.Size = New System.Drawing.Size(110, 13)
        Me.lbl_MontoDescuento.TabIndex = 113
        Me.lbl_MontoDescuento.Text = "Monto de Descuento:"
        '
        'cmb_TipoDescuento
        '
        Me.cmb_TipoDescuento.Control_Siguiente = Me.tbx_MontoDescuento
        Me.cmb_TipoDescuento.DisplayMember = "display"
        Me.cmb_TipoDescuento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_TipoDescuento.Enabled = False
        Me.cmb_TipoDescuento.FormattingEnabled = True
        Me.cmb_TipoDescuento.Location = New System.Drawing.Point(602, 297)
        Me.cmb_TipoDescuento.MaxDropDownItems = 20
        Me.cmb_TipoDescuento.Name = "cmb_TipoDescuento"
        Me.cmb_TipoDescuento.Size = New System.Drawing.Size(85, 21)
        Me.cmb_TipoDescuento.TabIndex = 63
        Me.cmb_TipoDescuento.ValueMember = "value"
        '
        'lbl_TipoDescuento
        '
        Me.lbl_TipoDescuento.AutoSize = True
        Me.lbl_TipoDescuento.Enabled = False
        Me.lbl_TipoDescuento.Location = New System.Drawing.Point(513, 301)
        Me.lbl_TipoDescuento.Name = "lbl_TipoDescuento"
        Me.lbl_TipoDescuento.Size = New System.Drawing.Size(83, 13)
        Me.lbl_TipoDescuento.TabIndex = 111
        Me.lbl_TipoDescuento.Text = "Tipo Descuento"
        '
        'tbx_NumeroCredito
        '
        Me.tbx_NumeroCredito.Control_Siguiente = Me.cmb_TipoDescuento
        Me.tbx_NumeroCredito.Enabled = False
        Me.tbx_NumeroCredito.Filtrado = True
        Me.tbx_NumeroCredito.Location = New System.Drawing.Point(823, 271)
        Me.tbx_NumeroCredito.MaxLength = 20
        Me.tbx_NumeroCredito.Name = "tbx_NumeroCredito"
        Me.tbx_NumeroCredito.Size = New System.Drawing.Size(110, 20)
        Me.tbx_NumeroCredito.TabIndex = 62
        Me.tbx_NumeroCredito.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_NumeroCredito
        '
        Me.lbl_NumeroCredito.AutoSize = True
        Me.lbl_NumeroCredito.Enabled = False
        Me.lbl_NumeroCredito.Location = New System.Drawing.Point(722, 275)
        Me.lbl_NumeroCredito.Name = "lbl_NumeroCredito"
        Me.lbl_NumeroCredito.Size = New System.Drawing.Size(98, 13)
        Me.lbl_NumeroCredito.TabIndex = 109
        Me.lbl_NumeroCredito.Text = "Número de Crédito:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(472, 431)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "*"
        '
        'lbl_NombreCompleto
        '
        Me.lbl_NombreCompleto.AutoSize = True
        Me.lbl_NombreCompleto.Location = New System.Drawing.Point(22, 38)
        Me.lbl_NombreCompleto.Name = "lbl_NombreCompleto"
        Me.lbl_NombreCompleto.Size = New System.Drawing.Size(94, 13)
        Me.lbl_NombreCompleto.TabIndex = 2
        Me.lbl_NombreCompleto.Text = "Nombre Completo:"
        Me.lbl_NombreCompleto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_ExpInfonavit
        '
        Me.tbx_ExpInfonavit.Control_Siguiente = Nothing
        Me.tbx_ExpInfonavit.Filtrado = True
        Me.tbx_ExpInfonavit.Location = New System.Drawing.Point(823, 165)
        Me.tbx_ExpInfonavit.Name = "tbx_ExpInfonavit"
        Me.tbx_ExpInfonavit.Size = New System.Drawing.Size(110, 20)
        Me.tbx_ExpInfonavit.TabIndex = 54
        Me.tbx_ExpInfonavit.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        Me.tbx_ExpInfonavit.Visible = False
        '
        'Lbl_DGInfonavit
        '
        Me.Lbl_DGInfonavit.AutoSize = True
        Me.Lbl_DGInfonavit.Location = New System.Drawing.Point(748, 168)
        Me.Lbl_DGInfonavit.Name = "Lbl_DGInfonavit"
        Me.Lbl_DGInfonavit.Size = New System.Drawing.Size(69, 13)
        Me.Lbl_DGInfonavit.TabIndex = 100
        Me.Lbl_DGInfonavit.Text = "Exp.Infonavit"
        Me.Lbl_DGInfonavit.Visible = False
        '
        'btn_ComprobarListaNegra
        '
        Me.btn_ComprobarListaNegra.Enabled = False
        Me.btn_ComprobarListaNegra.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ok
        Me.btn_ComprobarListaNegra.Location = New System.Drawing.Point(444, 58)
        Me.btn_ComprobarListaNegra.Name = "btn_ComprobarListaNegra"
        Me.btn_ComprobarListaNegra.Size = New System.Drawing.Size(24, 23)
        Me.btn_ComprobarListaNegra.TabIndex = 4
        Me.btn_ComprobarListaNegra.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ComprobarListaNegra.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_ComprobarListaNegra, "Comprobar si la persona se encuentra en Lista Negra")
        Me.btn_ComprobarListaNegra.UseVisualStyleBackColor = True
        '
        'Label155
        '
        Me.Label155.AutoSize = True
        Me.Label155.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label155.ForeColor = System.Drawing.Color.Red
        Me.Label155.Location = New System.Drawing.Point(470, 88)
        Me.Label155.Name = "Label155"
        Me.Label155.Size = New System.Drawing.Size(13, 16)
        Me.Label155.TabIndex = 14
        Me.Label155.Text = "*"
        '
        'cmb_Verifica
        '
        Me.cmb_Verifica.Control_Siguiente = Me.btn_Guardar_DG
        Me.cmb_Verifica.DisplayMember = "display"
        Me.cmb_Verifica.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Verifica.FormattingEnabled = True
        Me.cmb_Verifica.Location = New System.Drawing.Point(602, 431)
        Me.cmb_Verifica.MaxDropDownItems = 20
        Me.cmb_Verifica.Name = "cmb_Verifica"
        Me.cmb_Verifica.Size = New System.Drawing.Size(85, 21)
        Me.cmb_Verifica.TabIndex = 72
        Me.cmb_Verifica.ValueMember = "value"
        '
        'btn_Guardar_DG
        '
        Me.btn_Guardar_DG.Enabled = False
        Me.btn_Guardar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_DG.Location = New System.Drawing.Point(119, 537)
        Me.btn_Guardar_DG.Name = "btn_Guardar_DG"
        Me.btn_Guardar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DG.TabIndex = 138
        Me.btn_Guardar_DG.Text = "&Guardar"
        Me.btn_Guardar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_DG.UseVisualStyleBackColor = True
        '
        'cmb_Ruta
        '
        Me.cmb_Ruta.Control_Siguiente = Me.cmb_Verifica
        Me.cmb_Ruta.DisplayMember = "display"
        Me.cmb_Ruta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Ruta.FormattingEnabled = True
        Me.cmb_Ruta.Location = New System.Drawing.Point(823, 403)
        Me.cmb_Ruta.MaxDropDownItems = 20
        Me.cmb_Ruta.Name = "cmb_Ruta"
        Me.cmb_Ruta.Size = New System.Drawing.Size(85, 21)
        Me.cmb_Ruta.TabIndex = 71
        Me.cmb_Ruta.ValueMember = "value"
        '
        'cmb_JefeArea
        '
        Me.cmb_JefeArea.Control_Siguiente = Me.cmb_Ruta
        Me.cmb_JefeArea.DisplayMember = "display"
        Me.cmb_JefeArea.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_JefeArea.FormattingEnabled = True
        Me.cmb_JefeArea.Location = New System.Drawing.Point(602, 403)
        Me.cmb_JefeArea.MaxDropDownItems = 20
        Me.cmb_JefeArea.Name = "cmb_JefeArea"
        Me.cmb_JefeArea.Size = New System.Drawing.Size(85, 21)
        Me.cmb_JefeArea.TabIndex = 70
        Me.cmb_JefeArea.ValueMember = "value"
        '
        'cmb_CertifAcademia
        '
        Me.cmb_CertifAcademia.Control_Siguiente = Me.dtp_FechaIngreso
        Me.cmb_CertifAcademia.DisplayMember = "display"
        Me.cmb_CertifAcademia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CertifAcademia.FormattingEnabled = True
        Me.cmb_CertifAcademia.Location = New System.Drawing.Point(602, 323)
        Me.cmb_CertifAcademia.MaxDropDownItems = 20
        Me.cmb_CertifAcademia.Name = "cmb_CertifAcademia"
        Me.cmb_CertifAcademia.Size = New System.Drawing.Size(85, 21)
        Me.cmb_CertifAcademia.TabIndex = 65
        Me.cmb_CertifAcademia.ValueMember = "value"
        '
        'dtp_FechaIngreso
        '
        Me.dtp_FechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso.Location = New System.Drawing.Point(602, 350)
        Me.dtp_FechaIngreso.Name = "dtp_FechaIngreso"
        Me.dtp_FechaIngreso.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FechaIngreso.TabIndex = 67
        Me.dtp_FechaIngreso.Value = New Date(2010, 4, 12, 0, 0, 0, 0)
        '
        'cmb_CatalogoFirmas
        '
        Me.cmb_CatalogoFirmas.Control_Siguiente = Me.cmb_CertifAcademia
        Me.cmb_CatalogoFirmas.DisplayMember = "display"
        Me.cmb_CatalogoFirmas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CatalogoFirmas.FormattingEnabled = True
        Me.cmb_CatalogoFirmas.Location = New System.Drawing.Point(823, 323)
        Me.cmb_CatalogoFirmas.MaxDropDownItems = 20
        Me.cmb_CatalogoFirmas.Name = "cmb_CatalogoFirmas"
        Me.cmb_CatalogoFirmas.Size = New System.Drawing.Size(85, 21)
        Me.cmb_CatalogoFirmas.TabIndex = 66
        Me.cmb_CatalogoFirmas.ValueMember = "value"
        '
        'cmb_CreditoInfonavit
        '
        Me.cmb_CreditoInfonavit.Control_Siguiente = Me.tbx_NumeroCredito
        Me.cmb_CreditoInfonavit.DisplayMember = "display"
        Me.cmb_CreditoInfonavit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CreditoInfonavit.FormattingEnabled = True
        Me.cmb_CreditoInfonavit.Location = New System.Drawing.Point(602, 268)
        Me.cmb_CreditoInfonavit.MaxDropDownItems = 20
        Me.cmb_CreditoInfonavit.Name = "cmb_CreditoInfonavit"
        Me.cmb_CreditoInfonavit.Size = New System.Drawing.Size(85, 21)
        Me.cmb_CreditoInfonavit.TabIndex = 60
        Me.cmb_CreditoInfonavit.ValueMember = "value"
        '
        'cmb_ModoContactoD
        '
        Me.cmb_ModoContactoD.Clave = ""
        Me.cmb_ModoContactoD.Control_Siguiente = Me.tbx_Mail
        Me.cmb_ModoContactoD.DisplayMember = "Descripcion"
        Me.cmb_ModoContactoD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ModoContactoD.Empresa = False
        Me.cmb_ModoContactoD.Filtro = Nothing
        Me.cmb_ModoContactoD.FormattingEnabled = True
        Me.cmb_ModoContactoD.Location = New System.Drawing.Point(119, 510)
        Me.cmb_ModoContactoD.MaxDropDownItems = 20
        Me.cmb_ModoContactoD.Name = "cmb_ModoContactoD"
        Me.cmb_ModoContactoD.Pista = False
        Me.cmb_ModoContactoD.Size = New System.Drawing.Size(294, 21)
        Me.cmb_ModoContactoD.StoredProcedure = "Cat_ModoContactoD_Get"
        Me.cmb_ModoContactoD.Sucursal = False
        Me.cmb_ModoContactoD.TabIndex = 34
        Me.cmb_ModoContactoD.Tipo = 0
        Me.cmb_ModoContactoD.ValueMember = "Id_ModoContactoD"
        '
        'tbx_Mail
        '
        Me.tbx_Mail.Control_Siguiente = Me.tbx_Telefono1
        Me.tbx_Mail.Filtrado = True
        Me.tbx_Mail.Location = New System.Drawing.Point(602, 35)
        Me.tbx_Mail.MaxLength = 50
        Me.tbx_Mail.Name = "tbx_Mail"
        Me.tbx_Mail.Size = New System.Drawing.Size(331, 20)
        Me.tbx_Mail.TabIndex = 34
        Me.tbx_Mail.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Telefono1
        '
        Me.tbx_Telefono1.Control_Siguiente = Me.tbx_TelefonoMovil1
        Me.tbx_Telefono1.Filtrado = True
        Me.tbx_Telefono1.Location = New System.Drawing.Point(602, 61)
        Me.tbx_Telefono1.MaxLength = 25
        Me.tbx_Telefono1.Name = "tbx_Telefono1"
        Me.tbx_Telefono1.Size = New System.Drawing.Size(110, 20)
        Me.tbx_Telefono1.TabIndex = 35
        Me.tbx_Telefono1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_TelefonoMovil1
        '
        Me.tbx_TelefonoMovil1.Control_Siguiente = Me.tbx_Elector
        Me.tbx_TelefonoMovil1.Filtrado = True
        Me.tbx_TelefonoMovil1.Location = New System.Drawing.Point(823, 61)
        Me.tbx_TelefonoMovil1.MaxLength = 25
        Me.tbx_TelefonoMovil1.Name = "tbx_TelefonoMovil1"
        Me.tbx_TelefonoMovil1.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TelefonoMovil1.TabIndex = 36
        Me.tbx_TelefonoMovil1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Elector
        '
        Me.tbx_Elector.Control_Siguiente = Me.tbx_RFC
        Me.tbx_Elector.Filtrado = True
        Me.tbx_Elector.Location = New System.Drawing.Point(602, 87)
        Me.tbx_Elector.MaxLength = 25
        Me.tbx_Elector.Name = "tbx_Elector"
        Me.tbx_Elector.Size = New System.Drawing.Size(143, 20)
        Me.tbx_Elector.TabIndex = 37
        Me.tbx_Elector.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_RFC
        '
        Me.tbx_RFC.Control_Siguiente = Me.tbx_CURP
        Me.tbx_RFC.Filtrado = True
        Me.tbx_RFC.Location = New System.Drawing.Point(823, 85)
        Me.tbx_RFC.MaxLength = 15
        Me.tbx_RFC.Name = "tbx_RFC"
        Me.tbx_RFC.Size = New System.Drawing.Size(110, 20)
        Me.tbx_RFC.TabIndex = 38
        Me.tbx_RFC.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'Label163
        '
        Me.Label163.AutoSize = True
        Me.Label163.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label163.ForeColor = System.Drawing.Color.Red
        Me.Label163.Location = New System.Drawing.Point(419, 511)
        Me.Label163.Name = "Label163"
        Me.Label163.Size = New System.Drawing.Size(13, 16)
        Me.Label163.TabIndex = 74
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
        Me.cmb_ModoContacto.Location = New System.Drawing.Point(119, 483)
        Me.cmb_ModoContacto.MaxDropDownItems = 20
        Me.cmb_ModoContacto.Name = "cmb_ModoContacto"
        Me.cmb_ModoContacto.Pista = False
        Me.cmb_ModoContacto.Size = New System.Drawing.Size(294, 21)
        Me.cmb_ModoContacto.StoredProcedure = "Cat_ModoContacto_Get"
        Me.cmb_ModoContacto.Sucursal = False
        Me.cmb_ModoContacto.TabIndex = 33
        Me.cmb_ModoContacto.Tipo = 0
        Me.cmb_ModoContacto.ValueMember = "Id_ModoContacto"
        '
        'Lbl_DGEspecifique
        '
        Me.Lbl_DGEspecifique.AutoSize = True
        Me.Lbl_DGEspecifique.Location = New System.Drawing.Point(51, 513)
        Me.Lbl_DGEspecifique.Name = "Lbl_DGEspecifique"
        Me.Lbl_DGEspecifique.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_DGEspecifique.TabIndex = 72
        Me.Lbl_DGEspecifique.Text = "Especifique:"
        '
        'Lbl_DGModoContacto
        '
        Me.Lbl_DGModoContacto.AutoSize = True
        Me.Lbl_DGModoContacto.Location = New System.Drawing.Point(18, 486)
        Me.Lbl_DGModoContacto.Name = "Lbl_DGModoContacto"
        Me.Lbl_DGModoContacto.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_DGModoContacto.TabIndex = 70
        Me.Lbl_DGModoContacto.Text = "Modo de Contacto:"
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
        Me.cmb_Ciudad.TabIndex = 30
        Me.cmb_Ciudad.Tipo = 0
        Me.cmb_Ciudad.ValueMember = "Id_Ciudad"
        '
        'cmb_ModoNacionalidad
        '
        Me.cmb_ModoNacionalidad.Control_Siguiente = Nothing
        Me.cmb_ModoNacionalidad.DisplayMember = "display"
        Me.cmb_ModoNacionalidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ModoNacionalidad.FormattingEnabled = True
        Me.cmb_ModoNacionalidad.Location = New System.Drawing.Point(119, 456)
        Me.cmb_ModoNacionalidad.MaxDropDownItems = 20
        Me.cmb_ModoNacionalidad.Name = "cmb_ModoNacionalidad"
        Me.cmb_ModoNacionalidad.Size = New System.Drawing.Size(145, 21)
        Me.cmb_ModoNacionalidad.TabIndex = 31
        Me.cmb_ModoNacionalidad.ValueMember = "value"
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
        Me.cmb_Estado.TabIndex = 29
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
        Me.cmb_Pais.Location = New System.Drawing.Point(119, 402)
        Me.cmb_Pais.MaxDropDownItems = 20
        Me.cmb_Pais.Name = "cmb_Pais"
        Me.cmb_Pais.Pista = True
        Me.cmb_Pais.Size = New System.Drawing.Size(208, 21)
        Me.cmb_Pais.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Pais.Sucursal = False
        Me.cmb_Pais.TabIndex = 28
        Me.cmb_Pais.Tipo = 0
        Me.cmb_Pais.ValueMember = "Id_Pais"
        '
        'btn_RFC
        '
        Me.btn_RFC.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Crear_rfc_curp
        Me.btn_RFC.Location = New System.Drawing.Point(944, 86)
        Me.btn_RFC.Name = "btn_RFC"
        Me.btn_RFC.Size = New System.Drawing.Size(24, 23)
        Me.btn_RFC.TabIndex = 39
        Me.btn_RFC.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_RFC.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_RFC, "Calcular el RFC")
        Me.btn_RFC.UseVisualStyleBackColor = True
        '
        'btn_CURP
        '
        Me.btn_CURP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Crear_rfc_curp
        Me.btn_CURP.Location = New System.Drawing.Point(751, 110)
        Me.btn_CURP.Name = "btn_CURP"
        Me.btn_CURP.Size = New System.Drawing.Size(24, 23)
        Me.btn_CURP.TabIndex = 41
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
        Me.lbl_CiudadNac.TabIndex = 63
        Me.lbl_CiudadNac.Text = "Ciudad"
        '
        'btn_Validar
        '
        Me.btn_Validar.Enabled = False
        Me.btn_Validar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Validar.Location = New System.Drawing.Point(265, 537)
        Me.btn_Validar.Name = "btn_Validar"
        Me.btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Validar.TabIndex = 139
        Me.btn_Validar.Tag = "VALIDAR PROSPECTOS"
        Me.btn_Validar.Text = "&Validar"
        Me.btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Validar.UseVisualStyleBackColor = True
        Me.btn_Validar.Visible = False
        '
        'Lbl_DGEjemplo
        '
        Me.Lbl_DGEjemplo.AutoSize = True
        Me.Lbl_DGEjemplo.Location = New System.Drawing.Point(712, 436)
        Me.Lbl_DGEjemplo.Name = "Lbl_DGEjemplo"
        Me.Lbl_DGEjemplo.Size = New System.Drawing.Size(142, 13)
        Me.Lbl_DGEjemplo.TabIndex = 136
        Me.Lbl_DGEjemplo.Text = "(Proceso, Morralla o Cajeros)"
        '
        'Label156
        '
        Me.Label156.AutoSize = True
        Me.Label156.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label156.ForeColor = System.Drawing.Color.Red
        Me.Label156.Location = New System.Drawing.Point(693, 433)
        Me.Label156.Name = "Label156"
        Me.Label156.Size = New System.Drawing.Size(13, 16)
        Me.Label156.TabIndex = 135
        Me.Label156.Text = "*"
        '
        'Lbl_DgVerificara
        '
        Me.Lbl_DgVerificara.AutoSize = True
        Me.Lbl_DgVerificara.Location = New System.Drawing.Point(489, 436)
        Me.Lbl_DgVerificara.Name = "Lbl_DgVerificara"
        Me.Lbl_DgVerificara.Size = New System.Drawing.Size(107, 13)
        Me.Lbl_DgVerificara.TabIndex = 133
        Me.Lbl_DgVerificara.Text = "Verificará Depósitos?"
        '
        'Label154
        '
        Me.Label154.AutoSize = True
        Me.Label154.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label154.ForeColor = System.Drawing.Color.Red
        Me.Label154.Location = New System.Drawing.Point(693, 270)
        Me.Label154.Name = "Label154"
        Me.Label154.Size = New System.Drawing.Size(13, 16)
        Me.Label154.TabIndex = 108
        Me.Label154.Text = "*"
        '
        'btn_UMF
        '
        Me.btn_UMF.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_UMF.Location = New System.Drawing.Point(898, 137)
        Me.btn_UMF.Name = "btn_UMF"
        Me.btn_UMF.Size = New System.Drawing.Size(35, 23)
        Me.btn_UMF.TabIndex = 52
        Me.btn_UMF.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_UMF.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_UMF.UseVisualStyleBackColor = True
        '
        'lbl_Infonavit
        '
        Me.lbl_Infonavit.AutoSize = True
        Me.lbl_Infonavit.Location = New System.Drawing.Point(496, 275)
        Me.lbl_Infonavit.Name = "lbl_Infonavit"
        Me.lbl_Infonavit.Size = New System.Drawing.Size(100, 13)
        Me.lbl_Infonavit.TabIndex = 106
        Me.lbl_Infonavit.Text = "Crédito INFONAVIT"
        '
        'Label151
        '
        Me.Label151.AutoSize = True
        Me.Label151.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label151.ForeColor = System.Drawing.Color.Red
        Me.Label151.Location = New System.Drawing.Point(914, 405)
        Me.Label151.Name = "Label151"
        Me.Label151.Size = New System.Drawing.Size(13, 16)
        Me.Label151.TabIndex = 132
        Me.Label151.Text = "*"
        '
        'Label150
        '
        Me.Label150.AutoSize = True
        Me.Label150.Location = New System.Drawing.Point(739, 407)
        Me.Label150.Name = "Label150"
        Me.Label150.Size = New System.Drawing.Size(78, 13)
        Me.Label150.TabIndex = 130
        Me.Label150.Text = "Saldrá a Ruta?"
        '
        'lbl_UMF
        '
        Me.lbl_UMF.AutoSize = True
        Me.lbl_UMF.Location = New System.Drawing.Point(787, 142)
        Me.lbl_UMF.Name = "lbl_UMF"
        Me.lbl_UMF.Size = New System.Drawing.Size(30, 13)
        Me.lbl_UMF.TabIndex = 94
        Me.lbl_UMF.Text = "UMF"
        '
        'cmb_EmpleadoReferencia
        '
        Me.cmb_EmpleadoReferencia.Clave = Nothing
        Me.cmb_EmpleadoReferencia.Control_Siguiente = Me.cmb_JefeArea
        Me.cmb_EmpleadoReferencia.DisplayMember = "Nombre"
        Me.cmb_EmpleadoReferencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmpleadoReferencia.Empresa = False
        Me.cmb_EmpleadoReferencia.Filtro = Nothing
        Me.cmb_EmpleadoReferencia.FormattingEnabled = True
        Me.cmb_EmpleadoReferencia.Location = New System.Drawing.Point(602, 376)
        Me.cmb_EmpleadoReferencia.MaxDropDownItems = 20
        Me.cmb_EmpleadoReferencia.MaxLength = 9
        Me.cmb_EmpleadoReferencia.Name = "cmb_EmpleadoReferencia"
        Me.cmb_EmpleadoReferencia.Pista = True
        Me.cmb_EmpleadoReferencia.Size = New System.Drawing.Size(306, 21)
        Me.cmb_EmpleadoReferencia.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_EmpleadoReferencia.Sucursal = True
        Me.cmb_EmpleadoReferencia.TabIndex = 69
        Me.cmb_EmpleadoReferencia.Tipo = 0
        Me.cmb_EmpleadoReferencia.ValueMember = "Id_Empleado"
        '
        'lbl_EmpleadoReferencia
        '
        Me.lbl_EmpleadoReferencia.AutoSize = True
        Me.lbl_EmpleadoReferencia.Location = New System.Drawing.Point(487, 379)
        Me.lbl_EmpleadoReferencia.Name = "lbl_EmpleadoReferencia"
        Me.lbl_EmpleadoReferencia.Size = New System.Drawing.Size(109, 13)
        Me.lbl_EmpleadoReferencia.TabIndex = 125
        Me.lbl_EmpleadoReferencia.Text = "Empleado Referencia"
        '
        'tbx_NombreCompleto
        '
        Me.tbx_NombreCompleto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_NombreCompleto.Control_Siguiente = Me.cmb_Departamento_DG
        Me.tbx_NombreCompleto.Filtrado = True
        Me.tbx_NombreCompleto.Location = New System.Drawing.Point(119, 34)
        Me.tbx_NombreCompleto.MaxLength = 100
        Me.tbx_NombreCompleto.Name = "tbx_NombreCompleto"
        Me.tbx_NombreCompleto.ReadOnly = True
        Me.tbx_NombreCompleto.Size = New System.Drawing.Size(349, 20)
        Me.tbx_NombreCompleto.TabIndex = 2
        Me.tbx_NombreCompleto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        Me.tlt_RasgosMensaje.SetToolTip(Me.tbx_NombreCompleto, "Nombre Completo del Prospecto")
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
        Me.cmb_Departamento_DG.ItemHeight = 13
        Me.cmb_Departamento_DG.Location = New System.Drawing.Point(119, 110)
        Me.cmb_Departamento_DG.MaxDropDownItems = 20
        Me.cmb_Departamento_DG.Name = "cmb_Departamento_DG"
        Me.cmb_Departamento_DG.Pista = False
        Me.cmb_Departamento_DG.Size = New System.Drawing.Size(199, 21)
        Me.cmb_Departamento_DG.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento_DG.Sucursal = False
        Me.cmb_Departamento_DG.TabIndex = 7
        Me.cmb_Departamento_DG.Tipo = 0
        Me.cmb_Departamento_DG.ValueMember = "Id_Departamento"
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Me.tbx_SueldoBase
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.ItemHeight = 13
        Me.cmb_Puesto.Location = New System.Drawing.Point(119, 137)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(198, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 8
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'tbx_SueldoBase
        '
        Me.tbx_SueldoBase.Control_Siguiente = Me.tbx_Calle
        Me.tbx_SueldoBase.Filtrado = False
        Me.tbx_SueldoBase.Location = New System.Drawing.Point(407, 138)
        Me.tbx_SueldoBase.MaxLength = 6
        Me.tbx_SueldoBase.Name = "tbx_SueldoBase"
        Me.tbx_SueldoBase.Size = New System.Drawing.Size(62, 20)
        Me.tbx_SueldoBase.TabIndex = 9
        Me.tbx_SueldoBase.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_SueldoBase.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_Calle
        '
        Me.tbx_Calle.Control_Siguiente = Me.tbx_EntreCalle1
        Me.tbx_Calle.Filtrado = True
        Me.tbx_Calle.Location = New System.Drawing.Point(119, 216)
        Me.tbx_Calle.MaxLength = 100
        Me.tbx_Calle.Name = "tbx_Calle"
        Me.tbx_Calle.Size = New System.Drawing.Size(145, 20)
        Me.tbx_Calle.TabIndex = 14
        Me.tbx_Calle.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_EntreCalle1
        '
        Me.tbx_EntreCalle1.Control_Siguiente = Me.tbx_EntreCalle2
        Me.tbx_EntreCalle1.Filtrado = False
        Me.tbx_EntreCalle1.Location = New System.Drawing.Point(119, 243)
        Me.tbx_EntreCalle1.MaxLength = 100
        Me.tbx_EntreCalle1.Name = "tbx_EntreCalle1"
        Me.tbx_EntreCalle1.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle1.TabIndex = 16
        Me.tbx_EntreCalle1.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_EntreCalle2
        '
        Me.tbx_EntreCalle2.Control_Siguiente = Me.tbx_NumExterior
        Me.tbx_EntreCalle2.Filtrado = False
        Me.tbx_EntreCalle2.Location = New System.Drawing.Point(332, 215)
        Me.tbx_EntreCalle2.MaxLength = 100
        Me.tbx_EntreCalle2.Name = "tbx_EntreCalle2"
        Me.tbx_EntreCalle2.Size = New System.Drawing.Size(136, 20)
        Me.tbx_EntreCalle2.TabIndex = 15
        Me.tbx_EntreCalle2.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_NumExterior
        '
        Me.tbx_NumExterior.Control_Siguiente = Me.tbx_NumInterior
        Me.tbx_NumExterior.Filtrado = True
        Me.tbx_NumExterior.Location = New System.Drawing.Point(337, 241)
        Me.tbx_NumExterior.MaxLength = 6
        Me.tbx_NumExterior.Name = "tbx_NumExterior"
        Me.tbx_NumExterior.Size = New System.Drawing.Size(55, 20)
        Me.tbx_NumExterior.TabIndex = 17
        Me.tbx_NumExterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NumExterior.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        Me.tlt_RasgosMensaje.SetToolTip(Me.tbx_NumExterior, "Número Exterior")
        '
        'tbx_NumInterior
        '
        Me.tbx_NumInterior.Control_Siguiente = Nothing
        Me.tbx_NumInterior.Filtrado = False
        Me.tbx_NumInterior.Location = New System.Drawing.Point(419, 242)
        Me.tbx_NumInterior.MaxLength = 10
        Me.tbx_NumInterior.Name = "tbx_NumInterior"
        Me.tbx_NumInterior.Size = New System.Drawing.Size(50, 20)
        Me.tbx_NumInterior.TabIndex = 18
        Me.tbx_NumInterior.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_NumInterior.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_RasgosMensaje.SetToolTip(Me.tbx_NumInterior, "Número Interior")
        '
        'Label69
        '
        Me.Label69.AutoSize = True
        Me.Label69.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label69.ForeColor = System.Drawing.Color.Red
        Me.Label69.Location = New System.Drawing.Point(262, 87)
        Me.Label69.Name = "Label69"
        Me.Label69.Size = New System.Drawing.Size(13, 16)
        Me.Label69.TabIndex = 11
        Me.Label69.Text = "*"
        '
        'lbl_AMaterno
        '
        Me.lbl_AMaterno.AutoSize = True
        Me.lbl_AMaterno.Location = New System.Drawing.Point(280, 89)
        Me.lbl_AMaterno.Name = "lbl_AMaterno"
        Me.lbl_AMaterno.Size = New System.Drawing.Size(46, 13)
        Me.lbl_AMaterno.TabIndex = 9
        Me.lbl_AMaterno.Text = "Matreno"
        Me.lbl_AMaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_APaterno
        '
        Me.lbl_APaterno.AutoSize = True
        Me.lbl_APaterno.Location = New System.Drawing.Point(29, 89)
        Me.lbl_APaterno.Name = "lbl_APaterno"
        Me.lbl_APaterno.Size = New System.Drawing.Size(87, 13)
        Me.lbl_APaterno.TabIndex = 7
        Me.lbl_APaterno.Text = "Apellido Paterno:"
        Me.lbl_APaterno.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_ApellidoMaterno
        '
        Me.tbx_ApellidoMaterno.Control_Siguiente = Me.btn_ComprobarListaNegra
        Me.tbx_ApellidoMaterno.Filtrado = True
        Me.tbx_ApellidoMaterno.Location = New System.Drawing.Point(332, 86)
        Me.tbx_ApellidoMaterno.MaxLength = 30
        Me.tbx_ApellidoMaterno.Name = "tbx_ApellidoMaterno"
        Me.tbx_ApellidoMaterno.Size = New System.Drawing.Size(136, 20)
        Me.tbx_ApellidoMaterno.TabIndex = 6
        Me.tbx_ApellidoMaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_ApellidoPaterno
        '
        Me.tbx_ApellidoPaterno.Control_Siguiente = Me.tbx_ApellidoMaterno
        Me.tbx_ApellidoPaterno.Filtrado = True
        Me.tbx_ApellidoPaterno.Location = New System.Drawing.Point(119, 86)
        Me.tbx_ApellidoPaterno.MaxLength = 30
        Me.tbx_ApellidoPaterno.Name = "tbx_ApellidoPaterno"
        Me.tbx_ApellidoPaterno.Size = New System.Drawing.Size(137, 20)
        Me.tbx_ApellidoPaterno.TabIndex = 5
        Me.tbx_ApellidoPaterno.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Fecha_FinLabores
        '
        Me.tbx_Fecha_FinLabores.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Fecha_FinLabores.Control_Siguiente = Nothing
        Me.tbx_Fecha_FinLabores.Filtrado = True
        Me.tbx_Fecha_FinLabores.Location = New System.Drawing.Point(823, 349)
        Me.tbx_Fecha_FinLabores.MaxLength = 8
        Me.tbx_Fecha_FinLabores.Name = "tbx_Fecha_FinLabores"
        Me.tbx_Fecha_FinLabores.ReadOnly = True
        Me.tbx_Fecha_FinLabores.Size = New System.Drawing.Size(117, 20)
        Me.tbx_Fecha_FinLabores.TabIndex = 68
        Me.tbx_Fecha_FinLabores.TabStop = False
        Me.tbx_Fecha_FinLabores.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_FechaBaja
        '
        Me.lbl_FechaBaja.AutoSize = True
        Me.lbl_FechaBaja.Location = New System.Drawing.Point(756, 353)
        Me.lbl_FechaBaja.Name = "lbl_FechaBaja"
        Me.lbl_FechaBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FechaBaja.TabIndex = 123
        Me.lbl_FechaBaja.Text = "Fecha Baja"
        '
        'lbl_FechaIngreso
        '
        Me.lbl_FechaIngreso.AutoSize = True
        Me.lbl_FechaIngreso.Location = New System.Drawing.Point(521, 353)
        Me.lbl_FechaIngreso.Name = "lbl_FechaIngreso"
        Me.lbl_FechaIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FechaIngreso.TabIndex = 121
        Me.lbl_FechaIngreso.Text = "Fecha Ingreso"
        '
        'Lbl_DGViveFamilia
        '
        Me.Lbl_DGViveFamilia.AutoSize = True
        Me.Lbl_DGViveFamilia.Location = New System.Drawing.Point(15, 352)
        Me.Lbl_DGViveFamilia.Name = "Lbl_DGViveFamilia"
        Me.Lbl_DGViveFamilia.Size = New System.Drawing.Size(101, 13)
        Me.Lbl_DGViveFamilia.TabIndex = 50
        Me.Lbl_DGViveFamilia.Text = "Vive con su Familia:"
        '
        'Label144
        '
        Me.Label144.AutoSize = True
        Me.Label144.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label144.ForeColor = System.Drawing.Color.Red
        Me.Label144.Location = New System.Drawing.Point(879, 139)
        Me.Label144.Name = "Label144"
        Me.Label144.Size = New System.Drawing.Size(13, 16)
        Me.Label144.TabIndex = 96
        Me.Label144.Text = "*"
        '
        'Label140
        '
        Me.Label140.AutoSize = True
        Me.Label140.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label140.ForeColor = System.Drawing.Color.Red
        Me.Label140.Location = New System.Drawing.Point(693, 324)
        Me.Label140.Name = "Label140"
        Me.Label140.Size = New System.Drawing.Size(13, 16)
        Me.Label140.TabIndex = 117
        Me.Label140.Text = "*"
        '
        'Label142
        '
        Me.Label142.AutoSize = True
        Me.Label142.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label142.ForeColor = System.Drawing.Color.Red
        Me.Label142.Location = New System.Drawing.Point(693, 405)
        Me.Label142.Name = "Label142"
        Me.Label142.Size = New System.Drawing.Size(13, 16)
        Me.Label142.TabIndex = 129
        Me.Label142.Text = "*"
        '
        'Label42
        '
        Me.Label42.AutoSize = True
        Me.Label42.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label42.ForeColor = System.Drawing.Color.Red
        Me.Label42.Location = New System.Drawing.Point(914, 324)
        Me.Label42.Name = "Label42"
        Me.Label42.Size = New System.Drawing.Size(13, 16)
        Me.Label42.TabIndex = 120
        Me.Label42.Text = "*"
        '
        'Label41
        '
        Me.Label41.AutoSize = True
        Me.Label41.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label41.ForeColor = System.Drawing.Color.Red
        Me.Label41.Location = New System.Drawing.Point(319, 108)
        Me.Label41.Name = "Label41"
        Me.Label41.Size = New System.Drawing.Size(13, 16)
        Me.Label41.TabIndex = 17
        Me.Label41.Text = "*"
        '
        'Label40
        '
        Me.Label40.AutoSize = True
        Me.Label40.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label40.ForeColor = System.Drawing.Color.Red
        Me.Label40.Location = New System.Drawing.Point(319, 138)
        Me.Label40.Name = "Label40"
        Me.Label40.Size = New System.Drawing.Size(13, 16)
        Me.Label40.TabIndex = 20
        Me.Label40.Text = "*"
        '
        'lbl_CantHijos
        '
        Me.lbl_CantHijos.AutoSize = True
        Me.lbl_CantHijos.Location = New System.Drawing.Point(338, 352)
        Me.lbl_CantHijos.Name = "lbl_CantHijos"
        Me.lbl_CantHijos.Size = New System.Drawing.Size(75, 13)
        Me.lbl_CantHijos.TabIndex = 53
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
        Me.cmb_Ciudades_DG.ItemHeight = 13
        Me.cmb_Ciudades_DG.Location = New System.Drawing.Point(270, 165)
        Me.cmb_Ciudades_DG.MaxDropDownItems = 20
        Me.cmb_Ciudades_DG.Name = "cmb_Ciudades_DG"
        Me.cmb_Ciudades_DG.Pista = False
        Me.cmb_Ciudades_DG.Size = New System.Drawing.Size(199, 21)
        Me.cmb_Ciudades_DG.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_Ciudades_DG.Sucursal = False
        Me.cmb_Ciudades_DG.TabIndex = 12
        Me.cmb_Ciudades_DG.Tipo = 0
        Me.cmb_Ciudades_DG.ValueMember = "Id_Ciudad"
        '
        'lbl_CertifAcademia
        '
        Me.lbl_CertifAcademia.AutoSize = True
        Me.lbl_CertifAcademia.Location = New System.Drawing.Point(481, 327)
        Me.lbl_CertifAcademia.Name = "lbl_CertifAcademia"
        Me.lbl_CertifAcademia.Size = New System.Drawing.Size(115, 13)
        Me.lbl_CertifAcademia.TabIndex = 115
        Me.lbl_CertifAcademia.Text = "Certificación Académia"
        '
        'lbl_Sueldo
        '
        Me.lbl_Sueldo.AutoSize = True
        Me.lbl_Sueldo.Location = New System.Drawing.Point(334, 140)
        Me.lbl_Sueldo.Name = "lbl_Sueldo"
        Me.lbl_Sueldo.Size = New System.Drawing.Size(67, 13)
        Me.lbl_Sueldo.TabIndex = 16
        Me.lbl_Sueldo.Text = "Sueldo Base"
        '
        'lbl_Pasaporte
        '
        Me.lbl_Pasaporte.AutoSize = True
        Me.lbl_Pasaporte.Location = New System.Drawing.Point(541, 168)
        Me.lbl_Pasaporte.Name = "lbl_Pasaporte"
        Me.lbl_Pasaporte.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Pasaporte.TabIndex = 98
        Me.lbl_Pasaporte.Text = "Pasaporte"
        '
        'lbl_NumCartilla
        '
        Me.lbl_NumCartilla.AutoSize = True
        Me.lbl_NumCartilla.Location = New System.Drawing.Point(538, 142)
        Me.lbl_NumCartilla.Name = "lbl_NumCartilla"
        Me.lbl_NumCartilla.Size = New System.Drawing.Size(58, 13)
        Me.lbl_NumCartilla.TabIndex = 92
        Me.lbl_NumCartilla.Text = "No. Cartilla"
        '
        'lbl_FechaExpira
        '
        Me.lbl_FechaExpira.AutoSize = True
        Me.lbl_FechaExpira.Location = New System.Drawing.Point(484, 246)
        Me.lbl_FechaExpira.Name = "lbl_FechaExpira"
        Me.lbl_FechaExpira.Size = New System.Drawing.Size(112, 13)
        Me.lbl_FechaExpira.TabIndex = 104
        Me.lbl_FechaExpira.Text = "Fecha Expira Licencia"
        '
        'lbl_TipoLicencia
        '
        Me.lbl_TipoLicencia.AutoSize = True
        Me.lbl_TipoLicencia.Location = New System.Drawing.Point(525, 219)
        Me.lbl_TipoLicencia.Name = "lbl_TipoLicencia"
        Me.lbl_TipoLicencia.Size = New System.Drawing.Size(74, 13)
        Me.lbl_TipoLicencia.TabIndex = 102
        Me.lbl_TipoLicencia.Text = "Tipo Licencia:"
        '
        'lbl_IMSS
        '
        Me.lbl_IMSS.AutoSize = True
        Me.lbl_IMSS.Location = New System.Drawing.Point(784, 116)
        Me.lbl_IMSS.Name = "lbl_IMSS"
        Me.lbl_IMSS.Size = New System.Drawing.Size(33, 13)
        Me.lbl_IMSS.TabIndex = 89
        Me.lbl_IMSS.Text = "IMSS"
        '
        'lbl_CURP
        '
        Me.lbl_CURP.AutoSize = True
        Me.lbl_CURP.Location = New System.Drawing.Point(559, 115)
        Me.lbl_CURP.Name = "lbl_CURP"
        Me.lbl_CURP.Size = New System.Drawing.Size(37, 13)
        Me.lbl_CURP.TabIndex = 86
        Me.lbl_CURP.Text = "CURP"
        '
        'lbl_RFC
        '
        Me.lbl_RFC.AutoSize = True
        Me.lbl_RFC.Location = New System.Drawing.Point(789, 89)
        Me.lbl_RFC.Name = "lbl_RFC"
        Me.lbl_RFC.Size = New System.Drawing.Size(28, 13)
        Me.lbl_RFC.TabIndex = 83
        Me.lbl_RFC.Text = "RFC"
        '
        'lbl_Elector
        '
        Me.lbl_Elector.AutoSize = True
        Me.lbl_Elector.Location = New System.Drawing.Point(526, 90)
        Me.lbl_Elector.Name = "lbl_Elector"
        Me.lbl_Elector.Size = New System.Drawing.Size(70, 13)
        Me.lbl_Elector.TabIndex = 81
        Me.lbl_Elector.Text = "Clave Elector"
        '
        'tbx_Edad
        '
        Me.tbx_Edad.Control_Siguiente = Me.cmb_Pais
        Me.tbx_Edad.Filtrado = True
        Me.tbx_Edad.Location = New System.Drawing.Point(419, 375)
        Me.tbx_Edad.MaxLength = 2
        Me.tbx_Edad.Name = "tbx_Edad"
        Me.tbx_Edad.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Edad.TabIndex = 27
        Me.tbx_Edad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_Edad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lbl_Edad
        '
        Me.lbl_Edad.AutoSize = True
        Me.lbl_Edad.Location = New System.Drawing.Point(381, 379)
        Me.lbl_Edad.Name = "lbl_Edad"
        Me.lbl_Edad.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Edad.TabIndex = 57
        Me.lbl_Edad.Text = "Edad"
        '
        'lbl_ModoNacionalidad
        '
        Me.lbl_ModoNacionalidad.AutoSize = True
        Me.lbl_ModoNacionalidad.Location = New System.Drawing.Point(14, 459)
        Me.lbl_ModoNacionalidad.Name = "lbl_ModoNacionalidad"
        Me.lbl_ModoNacionalidad.Size = New System.Drawing.Size(102, 13)
        Me.lbl_ModoNacionalidad.TabIndex = 66
        Me.lbl_ModoNacionalidad.Text = "Modo Nacionalidad:"
        '
        'lbl_PaisNacimiento
        '
        Me.lbl_PaisNacimiento.AutoSize = True
        Me.lbl_PaisNacimiento.Location = New System.Drawing.Point(28, 405)
        Me.lbl_PaisNacimiento.Name = "lbl_PaisNacimiento"
        Me.lbl_PaisNacimiento.Size = New System.Drawing.Size(88, 13)
        Me.lbl_PaisNacimiento.TabIndex = 59
        Me.lbl_PaisNacimiento.Text = "País Nacimiento:"
        '
        'lbl_EntreCalle2
        '
        Me.lbl_EntreCalle2.AutoSize = True
        Me.lbl_EntreCalle2.Location = New System.Drawing.Point(275, 218)
        Me.lbl_EntreCalle2.Name = "lbl_EntreCalle2"
        Me.lbl_EntreCalle2.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2.TabIndex = 27
        Me.lbl_EntreCalle2.Text = "Y la Calle"
        '
        'lbl_EntreCalle1
        '
        Me.lbl_EntreCalle1.AutoSize = True
        Me.lbl_EntreCalle1.Location = New System.Drawing.Point(44, 246)
        Me.lbl_EntreCalle1.Name = "lbl_EntreCalle1"
        Me.lbl_EntreCalle1.Size = New System.Drawing.Size(72, 13)
        Me.lbl_EntreCalle1.TabIndex = 29
        Me.lbl_EntreCalle1.Text = "Entre la Calle:"
        '
        'lbl_LugarNac
        '
        Me.lbl_LugarNac.AutoSize = True
        Me.lbl_LugarNac.Location = New System.Drawing.Point(73, 434)
        Me.lbl_LugarNac.Name = "lbl_LugarNac"
        Me.lbl_LugarNac.Size = New System.Drawing.Size(43, 13)
        Me.lbl_LugarNac.TabIndex = 61
        Me.lbl_LugarNac.Text = "Estado:"
        '
        'dtp_FechaNaturalizacion
        '
        Me.dtp_FechaNaturalizacion.Enabled = False
        Me.dtp_FechaNaturalizacion.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaNaturalizacion.Location = New System.Drawing.Point(383, 456)
        Me.dtp_FechaNaturalizacion.Name = "dtp_FechaNaturalizacion"
        Me.dtp_FechaNaturalizacion.Size = New System.Drawing.Size(86, 20)
        Me.dtp_FechaNaturalizacion.TabIndex = 32
        Me.dtp_FechaNaturalizacion.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'lbl_FechaNaturalizacion
        '
        Me.lbl_FechaNaturalizacion.AutoSize = True
        Me.lbl_FechaNaturalizacion.Location = New System.Drawing.Point(270, 459)
        Me.lbl_FechaNaturalizacion.Name = "lbl_FechaNaturalizacion"
        Me.lbl_FechaNaturalizacion.Size = New System.Drawing.Size(107, 13)
        Me.lbl_FechaNaturalizacion.TabIndex = 68
        Me.lbl_FechaNaturalizacion.Text = "Fecha Naturalización"
        '
        'lbl_FechaNac
        '
        Me.lbl_FechaNac.AutoSize = True
        Me.lbl_FechaNac.Location = New System.Drawing.Point(20, 380)
        Me.lbl_FechaNac.Name = "lbl_FechaNac"
        Me.lbl_FechaNac.Size = New System.Drawing.Size(96, 13)
        Me.lbl_FechaNac.TabIndex = 55
        Me.lbl_FechaNac.Text = "Fecha Nacimiento:"
        '
        'lbl_TelefonoMovil1
        '
        Me.lbl_TelefonoMovil1.AutoSize = True
        Me.lbl_TelefonoMovil1.Location = New System.Drawing.Point(740, 65)
        Me.lbl_TelefonoMovil1.Name = "lbl_TelefonoMovil1"
        Me.lbl_TelefonoMovil1.Size = New System.Drawing.Size(77, 13)
        Me.lbl_TelefonoMovil1.TabIndex = 79
        Me.lbl_TelefonoMovil1.Text = "Teléfono Móvil"
        '
        'lbl_Telefono1
        '
        Me.lbl_Telefono1.AutoSize = True
        Me.lbl_Telefono1.Location = New System.Drawing.Point(547, 64)
        Me.lbl_Telefono1.Name = "lbl_Telefono1"
        Me.lbl_Telefono1.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono1.TabIndex = 77
        Me.lbl_Telefono1.Text = "Teléfono"
        '
        'lbl_Zona_DG
        '
        Me.lbl_Zona_DG.AutoSize = True
        Me.lbl_Zona_DG.Location = New System.Drawing.Point(81, 272)
        Me.lbl_Zona_DG.Name = "lbl_Zona_DG"
        Me.lbl_Zona_DG.Size = New System.Drawing.Size(35, 13)
        Me.lbl_Zona_DG.TabIndex = 34
        Me.lbl_Zona_DG.Text = "Zona:"
        '
        'lbl_Longitud
        '
        Me.lbl_Longitud.AutoSize = True
        Me.lbl_Longitud.Location = New System.Drawing.Point(329, 299)
        Me.lbl_Longitud.Name = "lbl_Longitud"
        Me.lbl_Longitud.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Longitud.TabIndex = 43
        Me.lbl_Longitud.Text = "Longitud"
        '
        'lbl_CP
        '
        Me.lbl_CP.AutoSize = True
        Me.lbl_CP.Location = New System.Drawing.Point(86, 168)
        Me.lbl_CP.Name = "lbl_CP"
        Me.lbl_CP.Size = New System.Drawing.Size(27, 13)
        Me.lbl_CP.TabIndex = 18
        Me.lbl_CP.Text = "C.P."
        '
        'lbl_Latitud
        '
        Me.lbl_Latitud.AutoSize = True
        Me.lbl_Latitud.Location = New System.Drawing.Point(74, 299)
        Me.lbl_Latitud.Name = "lbl_Latitud"
        Me.lbl_Latitud.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Latitud.TabIndex = 41
        Me.lbl_Latitud.Text = "Latitud:"
        '
        'lbl_Ciudad_DG
        '
        Me.lbl_Ciudad_DG.AutoSize = True
        Me.lbl_Ciudad_DG.Location = New System.Drawing.Point(225, 168)
        Me.lbl_Ciudad_DG.Name = "lbl_Ciudad_DG"
        Me.lbl_Ciudad_DG.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Ciudad_DG.TabIndex = 21
        Me.lbl_Ciudad_DG.Text = "Ciudad:"
        '
        'lbl_NumInterior
        '
        Me.lbl_NumInterior.AutoSize = True
        Me.lbl_NumInterior.Location = New System.Drawing.Point(394, 244)
        Me.lbl_NumInterior.Name = "lbl_NumInterior"
        Me.lbl_NumInterior.Size = New System.Drawing.Size(22, 13)
        Me.lbl_NumInterior.TabIndex = 32
        Me.lbl_NumInterior.Text = "Int."
        '
        'lbl_NumExterior
        '
        Me.lbl_NumExterior.AutoSize = True
        Me.lbl_NumExterior.Location = New System.Drawing.Point(267, 244)
        Me.lbl_NumExterior.Name = "lbl_NumExterior"
        Me.lbl_NumExterior.Size = New System.Drawing.Size(68, 13)
        Me.lbl_NumExterior.TabIndex = 31
        Me.lbl_NumExterior.Text = "Número Ext.:"
        '
        'lbl_Colonia
        '
        Me.lbl_Colonia.AutoSize = True
        Me.lbl_Colonia.Location = New System.Drawing.Point(63, 193)
        Me.lbl_Colonia.Name = "lbl_Colonia"
        Me.lbl_Colonia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia.TabIndex = 23
        Me.lbl_Colonia.Text = "Colonia"
        '
        'lbl_Calle
        '
        Me.lbl_Calle.AutoSize = True
        Me.lbl_Calle.Location = New System.Drawing.Point(83, 219)
        Me.lbl_Calle.Name = "lbl_Calle"
        Me.lbl_Calle.Size = New System.Drawing.Size(33, 13)
        Me.lbl_Calle.TabIndex = 25
        Me.lbl_Calle.Text = "Calle:"
        '
        'lbl_JefeArea
        '
        Me.lbl_JefeArea.AutoSize = True
        Me.lbl_JefeArea.Location = New System.Drawing.Point(508, 406)
        Me.lbl_JefeArea.Name = "lbl_JefeArea"
        Me.lbl_JefeArea.Size = New System.Drawing.Size(88, 13)
        Me.lbl_JefeArea.TabIndex = 127
        Me.lbl_JefeArea.Text = "Es Jefe de Área?"
        '
        'lbl_Firmas
        '
        Me.lbl_Firmas.AutoSize = True
        Me.lbl_Firmas.Location = New System.Drawing.Point(719, 327)
        Me.lbl_Firmas.Name = "lbl_Firmas"
        Me.lbl_Firmas.Size = New System.Drawing.Size(98, 13)
        Me.lbl_Firmas.TabIndex = 118
        Me.lbl_Firmas.Text = "En Catálogo Firmas"
        '
        'lbl_Genero
        '
        Me.lbl_Genero.AutoSize = True
        Me.lbl_Genero.Location = New System.Drawing.Point(71, 325)
        Me.lbl_Genero.Name = "lbl_Genero"
        Me.lbl_Genero.Size = New System.Drawing.Size(45, 13)
        Me.lbl_Genero.TabIndex = 45
        Me.lbl_Genero.Text = "Género:"
        '
        'Label139
        '
        Me.Label139.AutoSize = True
        Me.Label139.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label139.ForeColor = System.Drawing.Color.Red
        Me.Label139.Location = New System.Drawing.Point(239, 350)
        Me.Label139.Name = "Label139"
        Me.Label139.Size = New System.Drawing.Size(13, 16)
        Me.Label139.TabIndex = 52
        Me.Label139.Text = "*"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(239, 323)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 16)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "*"
        '
        'lbl_Mail
        '
        Me.lbl_Mail.AutoSize = True
        Me.lbl_Mail.Location = New System.Drawing.Point(520, 38)
        Me.lbl_Mail.Name = "lbl_Mail"
        Me.lbl_Mail.Size = New System.Drawing.Size(76, 13)
        Me.lbl_Mail.TabIndex = 75
        Me.lbl_Mail.Text = "Email Personal"
        '
        'tbx_Nombres
        '
        Me.tbx_Nombres.Control_Siguiente = Me.tbx_ApellidoPaterno
        Me.tbx_Nombres.Filtrado = True
        Me.tbx_Nombres.Location = New System.Drawing.Point(119, 60)
        Me.tbx_Nombres.MaxLength = 30
        Me.tbx_Nombres.Name = "tbx_Nombres"
        Me.tbx_Nombres.Size = New System.Drawing.Size(210, 20)
        Me.tbx_Nombres.TabIndex = 3
        Me.tbx_Nombres.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'btn_Cancelar_DG
        '
        Me.btn_Cancelar_DG.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_DG.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_DG.Location = New System.Drawing.Point(411, 537)
        Me.btn_Cancelar_DG.Name = "btn_Cancelar_DG"
        Me.btn_Cancelar_DG.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DG.TabIndex = 140
        Me.btn_Cancelar_DG.Text = "&Cancelar"
        Me.btn_Cancelar_DG.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_DG.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_DG.UseVisualStyleBackColor = True
        '
        'tbx_Clave
        '
        Me.tbx_Clave.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Clave.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(119, 9)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.ReadOnly = True
        Me.tbx_Clave.Size = New System.Drawing.Size(70, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TabStop = False
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Nombres
        '
        Me.lbl_Nombres.AutoSize = True
        Me.lbl_Nombres.Location = New System.Drawing.Point(58, 63)
        Me.lbl_Nombres.Name = "lbl_Nombres"
        Me.lbl_Nombres.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Nombres.TabIndex = 4
        Me.lbl_Nombres.Text = "Nombre(s):"
        Me.lbl_Nombres.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(79, 12)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(37, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave:"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(39, 113)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(77, 13)
        Me.lbl_Departamento.TabIndex = 11
        Me.lbl_Departamento.Text = "Departamento:"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(73, 140)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Puesto.TabIndex = 13
        Me.lbl_Puesto.Text = "Puesto:"
        '
        'lbl_EstadoCivil
        '
        Me.lbl_EstadoCivil.AutoSize = True
        Me.lbl_EstadoCivil.Location = New System.Drawing.Point(291, 325)
        Me.lbl_EstadoCivil.Name = "lbl_EstadoCivil"
        Me.lbl_EstadoCivil.Size = New System.Drawing.Size(62, 13)
        Me.lbl_EstadoCivil.TabIndex = 48
        Me.lbl_EstadoCivil.Text = "Estado Civil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(335, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "*"
        '
        'Label149
        '
        Me.Label149.AutoSize = True
        Me.Label149.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label149.ForeColor = System.Drawing.Color.Red
        Me.Label149.Location = New System.Drawing.Point(935, 110)
        Me.Label149.Name = "Label149"
        Me.Label149.Size = New System.Drawing.Size(13, 16)
        Me.Label149.TabIndex = 91
        Me.Label149.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(206, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "*"
        '
        'tab_Contacto
        '
        Me.tab_Contacto.Controls.Add(Me.cmb_Localizacion)
        Me.tab_Contacto.Controls.Add(Me.btn_AgregarContactos)
        Me.tab_Contacto.Controls.Add(Me.btn_borrarP)
        Me.tab_Contacto.Controls.Add(Me.btn_cancelarP)
        Me.tab_Contacto.Controls.Add(Me.lsv_Contacto)
        Me.tab_Contacto.Controls.Add(Me.tbx_Descripcion)
        Me.tab_Contacto.Controls.Add(Me.lbl_Descripcion)
        Me.tab_Contacto.Controls.Add(Me.lbl_Contacto)
        Me.tab_Contacto.Location = New System.Drawing.Point(4, 22)
        Me.tab_Contacto.Name = "tab_Contacto"
        Me.tab_Contacto.Size = New System.Drawing.Size(1002, 673)
        Me.tab_Contacto.TabIndex = 12
        Me.tab_Contacto.Text = "Contacto"
        Me.tab_Contacto.UseVisualStyleBackColor = True
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
        Me.cmb_Localizacion.Location = New System.Drawing.Point(93, 15)
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
        Me.btn_AgregarContactos.Location = New System.Drawing.Point(422, 36)
        Me.btn_AgregarContactos.Name = "btn_AgregarContactos"
        Me.btn_AgregarContactos.Size = New System.Drawing.Size(140, 30)
        Me.btn_AgregarContactos.TabIndex = 3
        Me.btn_AgregarContactos.Text = "Agregar"
        Me.btn_AgregarContactos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_AgregarContactos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_AgregarContactos.UseVisualStyleBackColor = True
        '
        'btn_borrarP
        '
        Me.btn_borrarP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_borrarP.Enabled = False
        Me.btn_borrarP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_borrarP.Location = New System.Drawing.Point(11, 352)
        Me.btn_borrarP.Name = "btn_borrarP"
        Me.btn_borrarP.Size = New System.Drawing.Size(140, 30)
        Me.btn_borrarP.TabIndex = 5
        Me.btn_borrarP.Text = "&Borrar"
        Me.btn_borrarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_borrarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_borrarP.UseVisualStyleBackColor = True
        '
        'btn_cancelarP
        '
        Me.btn_cancelarP.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelarP.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_cancelarP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_cancelarP.Location = New System.Drawing.Point(157, 352)
        Me.btn_cancelarP.Name = "btn_cancelarP"
        Me.btn_cancelarP.Size = New System.Drawing.Size(140, 30)
        Me.btn_cancelarP.TabIndex = 6
        Me.btn_cancelarP.Text = "&Cancelar"
        Me.btn_cancelarP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cancelarP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cancelarP.UseVisualStyleBackColor = True
        '
        'lsv_Contacto
        '
        Me.lsv_Contacto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Contacto.FullRowSelect = True
        Me.lsv_Contacto.HideSelection = False
        Me.lsv_Contacto.Location = New System.Drawing.Point(13, 72)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Contacto.Lvs = ListViewColumnSorter2
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
        Me.lsv_Contacto.Size = New System.Drawing.Size(588, 267)
        Me.lsv_Contacto.TabIndex = 4
        Me.lsv_Contacto.UseCompatibleStateImageBehavior = False
        Me.lsv_Contacto.View = System.Windows.Forms.View.Details
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Control_Siguiente = Nothing
        Me.tbx_Descripcion.Filtrado = True
        Me.tbx_Descripcion.Location = New System.Drawing.Point(93, 42)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(228, 20)
        Me.tbx_Descripcion.TabIndex = 2
        Me.tbx_Descripcion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'lbl_Descripcion
        '
        Me.lbl_Descripcion.AutoSize = True
        Me.lbl_Descripcion.Location = New System.Drawing.Point(21, 45)
        Me.lbl_Descripcion.Name = "lbl_Descripcion"
        Me.lbl_Descripcion.Size = New System.Drawing.Size(66, 13)
        Me.lbl_Descripcion.TabIndex = 34
        Me.lbl_Descripcion.Text = "Descripción:"
        '
        'lbl_Contacto
        '
        Me.lbl_Contacto.AutoSize = True
        Me.lbl_Contacto.Location = New System.Drawing.Point(10, 18)
        Me.lbl_Contacto.Name = "lbl_Contacto"
        Me.lbl_Contacto.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Contacto.TabIndex = 33
        Me.lbl_Contacto.Text = "Modo Contacto:"
        '
        'tab_Entrevistas
        '
        Me.tab_Entrevistas.Controls.Add(Me.btn_EntrevistasCancelar)
        Me.tab_Entrevistas.Controls.Add(Me.gbx_Entrevistas)
        Me.tab_Entrevistas.Controls.Add(Me.gbx_Entrevista)
        Me.tab_Entrevistas.Location = New System.Drawing.Point(4, 22)
        Me.tab_Entrevistas.Name = "tab_Entrevistas"
        Me.tab_Entrevistas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Entrevistas.Size = New System.Drawing.Size(1002, 673)
        Me.tab_Entrevistas.TabIndex = 10
        Me.tab_Entrevistas.Text = "Entrevistas"
        Me.tab_Entrevistas.UseVisualStyleBackColor = True
        '
        'btn_EntrevistasCancelar
        '
        Me.btn_EntrevistasCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_EntrevistasCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_EntrevistasCancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_EntrevistasCancelar.Location = New System.Drawing.Point(6, 636)
        Me.btn_EntrevistasCancelar.Name = "btn_EntrevistasCancelar"
        Me.btn_EntrevistasCancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_EntrevistasCancelar.TabIndex = 27
        Me.btn_EntrevistasCancelar.Text = "&Cancelar"
        Me.btn_EntrevistasCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EntrevistasCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EntrevistasCancelar.UseVisualStyleBackColor = True
        '
        'gbx_Entrevistas
        '
        Me.gbx_Entrevistas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Entrevistas.Controls.Add(Me.lsv_Entrevistas)
        Me.gbx_Entrevistas.Location = New System.Drawing.Point(6, 176)
        Me.gbx_Entrevistas.Name = "gbx_Entrevistas"
        Me.gbx_Entrevistas.Size = New System.Drawing.Size(933, 454)
        Me.gbx_Entrevistas.TabIndex = 1
        Me.gbx_Entrevistas.TabStop = False
        '
        'lsv_Entrevistas
        '
        Me.lsv_Entrevistas.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lsv_Entrevistas.FullRowSelect = True
        Me.lsv_Entrevistas.HideSelection = False
        Me.lsv_Entrevistas.Location = New System.Drawing.Point(3, 16)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Entrevistas.Lvs = ListViewColumnSorter3
        Me.lsv_Entrevistas.MultiSelect = False
        Me.lsv_Entrevistas.Name = "lsv_Entrevistas"
        Me.lsv_Entrevistas.Row1 = 10
        Me.lsv_Entrevistas.Row10 = 0
        Me.lsv_Entrevistas.Row2 = 25
        Me.lsv_Entrevistas.Row3 = 10
        Me.lsv_Entrevistas.Row4 = 40
        Me.lsv_Entrevistas.Row5 = 0
        Me.lsv_Entrevistas.Row6 = 0
        Me.lsv_Entrevistas.Row7 = 0
        Me.lsv_Entrevistas.Row8 = 0
        Me.lsv_Entrevistas.Row9 = 0
        Me.lsv_Entrevistas.Size = New System.Drawing.Size(927, 435)
        Me.lsv_Entrevistas.TabIndex = 0
        Me.lsv_Entrevistas.UseCompatibleStateImageBehavior = False
        Me.lsv_Entrevistas.View = System.Windows.Forms.View.Details
        '
        'gbx_Entrevista
        '
        Me.gbx_Entrevista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Entrevista.Controls.Add(Me.Label50)
        Me.gbx_Entrevista.Controls.Add(Me.Label51)
        Me.gbx_Entrevista.Controls.Add(Me.Label129)
        Me.gbx_Entrevista.Controls.Add(Me.Label158)
        Me.gbx_Entrevista.Controls.Add(Me.cmb_EmpleadoEntrevista)
        Me.gbx_Entrevista.Controls.Add(Me.lbl_Nombre_Baja)
        Me.gbx_Entrevista.Controls.Add(Me.tbx_ClaveE)
        Me.gbx_Entrevista.Controls.Add(Me.btn_Agregar_Entrevista)
        Me.gbx_Entrevista.Controls.Add(Me.dtp_FechaEntrevista)
        Me.gbx_Entrevista.Controls.Add(Me.tbx_ComentariosEntrevista)
        Me.gbx_Entrevista.Controls.Add(Me.Lbl_EApto)
        Me.gbx_Entrevista.Controls.Add(Me.Lbl_EFecha)
        Me.gbx_Entrevista.Controls.Add(Me.gbx_Apto)
        Me.gbx_Entrevista.Controls.Add(Me.Lbl_EComentarios)
        Me.gbx_Entrevista.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Entrevista.Name = "gbx_Entrevista"
        Me.gbx_Entrevista.Size = New System.Drawing.Size(933, 164)
        Me.gbx_Entrevista.TabIndex = 0
        Me.gbx_Entrevista.TabStop = False
        '
        'Label50
        '
        Me.Label50.AutoSize = True
        Me.Label50.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label50.ForeColor = System.Drawing.Color.Red
        Me.Label50.Location = New System.Drawing.Point(611, 104)
        Me.Label50.Name = "Label50"
        Me.Label50.Size = New System.Drawing.Size(13, 16)
        Me.Label50.TabIndex = 12
        Me.Label50.Text = "*"
        '
        'Label51
        '
        Me.Label51.AutoSize = True
        Me.Label51.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label51.ForeColor = System.Drawing.Color.Red
        Me.Label51.Location = New System.Drawing.Point(251, 74)
        Me.Label51.Name = "Label51"
        Me.Label51.Size = New System.Drawing.Size(13, 16)
        Me.Label51.TabIndex = 9
        Me.Label51.Text = "*"
        '
        'Label129
        '
        Me.Label129.AutoSize = True
        Me.Label129.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label129.ForeColor = System.Drawing.Color.Red
        Me.Label129.Location = New System.Drawing.Point(611, 45)
        Me.Label129.Name = "Label129"
        Me.Label129.Size = New System.Drawing.Size(13, 16)
        Me.Label129.TabIndex = 6
        Me.Label129.Text = "*"
        '
        'Label158
        '
        Me.Label158.AutoSize = True
        Me.Label158.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label158.ForeColor = System.Drawing.Color.Red
        Me.Label158.Location = New System.Drawing.Point(237, 19)
        Me.Label158.Name = "Label158"
        Me.Label158.Size = New System.Drawing.Size(13, 16)
        Me.Label158.TabIndex = 2
        Me.Label158.Text = "*"
        '
        'cmb_EmpleadoEntrevista
        '
        Me.cmb_EmpleadoEntrevista.Clave = "Clave_Empleado"
        Me.cmb_EmpleadoEntrevista.Control_Siguiente = Me.tbx_ComentariosEntrevista
        Me.cmb_EmpleadoEntrevista.DisplayMember = "Nombre"
        Me.cmb_EmpleadoEntrevista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_EmpleadoEntrevista.Empresa = False
        Me.cmb_EmpleadoEntrevista.Filtro = Me.tbx_ClaveE
        Me.cmb_EmpleadoEntrevista.FormattingEnabled = True
        Me.cmb_EmpleadoEntrevista.Location = New System.Drawing.Point(135, 45)
        Me.cmb_EmpleadoEntrevista.MaxDropDownItems = 20
        Me.cmb_EmpleadoEntrevista.Name = "cmb_EmpleadoEntrevista"
        Me.cmb_EmpleadoEntrevista.Pista = True
        Me.cmb_EmpleadoEntrevista.Size = New System.Drawing.Size(470, 21)
        Me.cmb_EmpleadoEntrevista.StoredProcedure = "Cat_EmpleadosCombo_Get"
        Me.cmb_EmpleadoEntrevista.Sucursal = True
        Me.cmb_EmpleadoEntrevista.TabIndex = 5
        Me.cmb_EmpleadoEntrevista.Tipo = 0
        Me.cmb_EmpleadoEntrevista.ValueMember = "Id_Empleado"
        '
        'tbx_ComentariosEntrevista
        '
        Me.tbx_ComentariosEntrevista.Control_Siguiente = Me.btn_Agregar_Entrevista
        Me.tbx_ComentariosEntrevista.Filtrado = False
        Me.tbx_ComentariosEntrevista.Location = New System.Drawing.Point(135, 104)
        Me.tbx_ComentariosEntrevista.MaxLength = 300
        Me.tbx_ComentariosEntrevista.Multiline = True
        Me.tbx_ComentariosEntrevista.Name = "tbx_ComentariosEntrevista"
        Me.tbx_ComentariosEntrevista.Size = New System.Drawing.Size(470, 53)
        Me.tbx_ComentariosEntrevista.TabIndex = 11
        Me.tbx_ComentariosEntrevista.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Agregar_Entrevista
        '
        Me.btn_Agregar_Entrevista.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Agregar_Entrevista.Location = New System.Drawing.Point(628, 127)
        Me.btn_Agregar_Entrevista.Name = "btn_Agregar_Entrevista"
        Me.btn_Agregar_Entrevista.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Entrevista.TabIndex = 13
        Me.btn_Agregar_Entrevista.Text = "&Agregar"
        Me.btn_Agregar_Entrevista.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Entrevista.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Entrevista.UseVisualStyleBackColor = True
        '
        'tbx_ClaveE
        '
        Me.tbx_ClaveE.Control_Siguiente = Me.cmb_EmpleadoEntrevista
        Me.tbx_ClaveE.Filtrado = True
        Me.tbx_ClaveE.Location = New System.Drawing.Point(129, 38)
        Me.tbx_ClaveE.MaxLength = 4
        Me.tbx_ClaveE.Name = "tbx_ClaveE"
        Me.tbx_ClaveE.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveE.TabIndex = 4
        Me.tbx_ClaveE.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveE.Visible = False
        '
        'lbl_Nombre_Baja
        '
        Me.lbl_Nombre_Baja.AutoSize = True
        Me.lbl_Nombre_Baja.Location = New System.Drawing.Point(4, 48)
        Me.lbl_Nombre_Baja.Name = "lbl_Nombre_Baja"
        Me.lbl_Nombre_Baja.Size = New System.Drawing.Size(125, 13)
        Me.lbl_Nombre_Baja.TabIndex = 3
        Me.lbl_Nombre_Baja.Text = "Empleado que Entrevistó"
        Me.lbl_Nombre_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dtp_FechaEntrevista
        '
        Me.dtp_FechaEntrevista.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaEntrevista.Location = New System.Drawing.Point(135, 19)
        Me.dtp_FechaEntrevista.Name = "dtp_FechaEntrevista"
        Me.dtp_FechaEntrevista.Size = New System.Drawing.Size(96, 20)
        Me.dtp_FechaEntrevista.TabIndex = 1
        '
        'Lbl_EApto
        '
        Me.Lbl_EApto.AutoSize = True
        Me.Lbl_EApto.Location = New System.Drawing.Point(94, 77)
        Me.Lbl_EApto.Name = "Lbl_EApto"
        Me.Lbl_EApto.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_EApto.TabIndex = 7
        Me.Lbl_EApto.Text = "Apto?"
        '
        'Lbl_EFecha
        '
        Me.Lbl_EFecha.AutoSize = True
        Me.Lbl_EFecha.Location = New System.Drawing.Point(27, 23)
        Me.Lbl_EFecha.Name = "Lbl_EFecha"
        Me.Lbl_EFecha.Size = New System.Drawing.Size(102, 13)
        Me.Lbl_EFecha.TabIndex = 0
        Me.Lbl_EFecha.Text = "Fecha de Entrevista"
        '
        'gbx_Apto
        '
        Me.gbx_Apto.Controls.Add(Me.rdb_NoApto)
        Me.gbx_Apto.Controls.Add(Me.rdb_SiApto)
        Me.gbx_Apto.Location = New System.Drawing.Point(135, 67)
        Me.gbx_Apto.Name = "gbx_Apto"
        Me.gbx_Apto.Size = New System.Drawing.Size(110, 31)
        Me.gbx_Apto.TabIndex = 8
        Me.gbx_Apto.TabStop = False
        '
        'rdb_NoApto
        '
        Me.rdb_NoApto.AutoSize = True
        Me.rdb_NoApto.Location = New System.Drawing.Point(59, 10)
        Me.rdb_NoApto.Name = "rdb_NoApto"
        Me.rdb_NoApto.Size = New System.Drawing.Size(39, 17)
        Me.rdb_NoApto.TabIndex = 1
        Me.rdb_NoApto.Text = "No"
        Me.rdb_NoApto.UseVisualStyleBackColor = True
        '
        'rdb_SiApto
        '
        Me.rdb_SiApto.AutoSize = True
        Me.rdb_SiApto.Location = New System.Drawing.Point(6, 10)
        Me.rdb_SiApto.Name = "rdb_SiApto"
        Me.rdb_SiApto.Size = New System.Drawing.Size(34, 17)
        Me.rdb_SiApto.TabIndex = 0
        Me.rdb_SiApto.Text = "Si"
        Me.rdb_SiApto.UseVisualStyleBackColor = True
        '
        'Lbl_EComentarios
        '
        Me.Lbl_EComentarios.AutoSize = True
        Me.Lbl_EComentarios.Location = New System.Drawing.Point(64, 110)
        Me.Lbl_EComentarios.Name = "Lbl_EComentarios"
        Me.Lbl_EComentarios.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_EComentarios.TabIndex = 10
        Me.Lbl_EComentarios.Text = "Comentarios"
        '
        'tab_Foto
        '
        Me.tab_Foto.Controls.Add(Me.btn_FotografiaCancelar)
        Me.tab_Foto.Controls.Add(Me.gbx_FrenteFormal)
        Me.tab_Foto.Controls.Add(Me.Lbl_EFotografia)
        Me.tab_Foto.Controls.Add(Me.gbx_FotoProspecto)
        Me.tab_Foto.Location = New System.Drawing.Point(4, 22)
        Me.tab_Foto.Name = "tab_Foto"
        Me.tab_Foto.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Foto.Size = New System.Drawing.Size(1002, 673)
        Me.tab_Foto.TabIndex = 11
        Me.tab_Foto.Text = "Fotografía"
        Me.tab_Foto.UseVisualStyleBackColor = True
        '
        'btn_FotografiaCancelar
        '
        Me.btn_FotografiaCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_FotografiaCancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_FotografiaCancelar.Location = New System.Drawing.Point(12, 526)
        Me.btn_FotografiaCancelar.Name = "btn_FotografiaCancelar"
        Me.btn_FotografiaCancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_FotografiaCancelar.TabIndex = 28
        Me.btn_FotografiaCancelar.Text = "&Cancelar"
        Me.btn_FotografiaCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_FotografiaCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_FotografiaCancelar.UseVisualStyleBackColor = True
        '
        'gbx_FrenteFormal
        '
        Me.gbx_FrenteFormal.Controls.Add(Me.btn_Guardar_FotoFormal)
        Me.gbx_FrenteFormal.Controls.Add(Me.btn_ImportaFormal)
        Me.gbx_FrenteFormal.Controls.Add(Me.btn_TomarFrenteFormal)
        Me.gbx_FrenteFormal.Controls.Add(Me.pct_FrenteFormal)
        Me.gbx_FrenteFormal.Controls.Add(Me.btn_LimpiarFrenteFormal)
        Me.gbx_FrenteFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_FrenteFormal.Location = New System.Drawing.Point(456, 6)
        Me.gbx_FrenteFormal.Name = "gbx_FrenteFormal"
        Me.gbx_FrenteFormal.Size = New System.Drawing.Size(445, 444)
        Me.gbx_FrenteFormal.TabIndex = 1
        Me.gbx_FrenteFormal.TabStop = False
        Me.gbx_FrenteFormal.Text = "Frente Formal"
        '
        'btn_Guardar_FotoFormal
        '
        Me.btn_Guardar_FotoFormal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_FotoFormal.Enabled = False
        Me.btn_Guardar_FotoFormal.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_FotoFormal.Location = New System.Drawing.Point(135, 410)
        Me.btn_Guardar_FotoFormal.Name = "btn_Guardar_FotoFormal"
        Me.btn_Guardar_FotoFormal.Size = New System.Drawing.Size(37, 25)
        Me.btn_Guardar_FotoFormal.TabIndex = 3
        Me.btn_Guardar_FotoFormal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_FotoFormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_Guardar_FotoFormal, "Guardar Fotografía")
        Me.btn_Guardar_FotoFormal.UseVisualStyleBackColor = True
        '
        'btn_ImportaFormal
        '
        Me.btn_ImportaFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ImportaFormal.Location = New System.Drawing.Point(6, 410)
        Me.btn_ImportaFormal.Name = "btn_ImportaFormal"
        Me.btn_ImportaFormal.Size = New System.Drawing.Size(37, 25)
        Me.btn_ImportaFormal.TabIndex = 0
        Me.btn_ImportaFormal.Text = "..."
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_ImportaFormal, "Importar Fotografía")
        Me.btn_ImportaFormal.UseVisualStyleBackColor = True
        '
        'btn_TomarFrenteFormal
        '
        Me.btn_TomarFrenteFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TomarFrenteFormal.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_TomarFrenteFormal.Location = New System.Drawing.Point(49, 410)
        Me.btn_TomarFrenteFormal.Name = "btn_TomarFrenteFormal"
        Me.btn_TomarFrenteFormal.Size = New System.Drawing.Size(37, 25)
        Me.btn_TomarFrenteFormal.TabIndex = 1
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_TomarFrenteFormal, "Tomar Fotografía con WebCam")
        Me.btn_TomarFrenteFormal.UseVisualStyleBackColor = True
        '
        'pct_FrenteFormal
        '
        Me.pct_FrenteFormal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_FrenteFormal.BackColor = System.Drawing.Color.White
        Me.pct_FrenteFormal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_FrenteFormal.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_FrenteFormal.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_FrenteFormal.Location = New System.Drawing.Point(6, 19)
        Me.pct_FrenteFormal.Name = "pct_FrenteFormal"
        Me.pct_FrenteFormal.Size = New System.Drawing.Size(433, 385)
        Me.pct_FrenteFormal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_FrenteFormal.TabIndex = 127
        Me.pct_FrenteFormal.TabStop = False
        '
        'btn_LimpiarFrenteFormal
        '
        Me.btn_LimpiarFrenteFormal.Enabled = False
        Me.btn_LimpiarFrenteFormal.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarFrenteFormal.Image = CType(resources.GetObject("btn_LimpiarFrenteFormal.Image"), System.Drawing.Image)
        Me.btn_LimpiarFrenteFormal.Location = New System.Drawing.Point(92, 410)
        Me.btn_LimpiarFrenteFormal.Name = "btn_LimpiarFrenteFormal"
        Me.btn_LimpiarFrenteFormal.Size = New System.Drawing.Size(37, 25)
        Me.btn_LimpiarFrenteFormal.TabIndex = 2
        Me.btn_LimpiarFrenteFormal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_LimpiarFrenteFormal, "Eliminar Fotografía")
        Me.btn_LimpiarFrenteFormal.UseVisualStyleBackColor = True
        '
        'Lbl_EFotografia
        '
        Me.Lbl_EFotografia.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_EFotografia.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Lbl_EFotografia.Location = New System.Drawing.Point(9, 453)
        Me.Lbl_EFotografia.Name = "Lbl_EFotografia"
        Me.Lbl_EFotografia.Size = New System.Drawing.Size(434, 59)
        Me.Lbl_EFotografia.TabIndex = 2
        Me.Lbl_EFotografia.Text = "NOTA: Las Imagenes seleccionadas serán reducidas a una resolución de 800 x 600 co" &
    "mo máximo para el correcto funcionamiento del sistema."
        Me.Lbl_EFotografia.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'gbx_FotoProspecto
        '
        Me.gbx_FotoProspecto.Controls.Add(Me.btn_Guardar_Foto)
        Me.gbx_FotoProspecto.Controls.Add(Me.btn_Importa)
        Me.gbx_FotoProspecto.Controls.Add(Me.btn_TomarFrente)
        Me.gbx_FotoProspecto.Controls.Add(Me.pct_Frente)
        Me.gbx_FotoProspecto.Controls.Add(Me.btn_LimpiarFrente)
        Me.gbx_FotoProspecto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_FotoProspecto.Location = New System.Drawing.Point(6, 6)
        Me.gbx_FotoProspecto.Name = "gbx_FotoProspecto"
        Me.gbx_FotoProspecto.Size = New System.Drawing.Size(444, 444)
        Me.gbx_FotoProspecto.TabIndex = 0
        Me.gbx_FotoProspecto.TabStop = False
        Me.gbx_FotoProspecto.Text = "Frente"
        '
        'btn_Guardar_Foto
        '
        Me.btn_Guardar_Foto.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Foto.Enabled = False
        Me.btn_Guardar_Foto.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Foto.Location = New System.Drawing.Point(135, 410)
        Me.btn_Guardar_Foto.Name = "btn_Guardar_Foto"
        Me.btn_Guardar_Foto.Size = New System.Drawing.Size(37, 25)
        Me.btn_Guardar_Foto.TabIndex = 3
        Me.btn_Guardar_Foto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Foto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_Guardar_Foto, "Guardar Fotografía")
        Me.btn_Guardar_Foto.UseVisualStyleBackColor = True
        '
        'btn_Importa
        '
        Me.btn_Importa.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Importa.Location = New System.Drawing.Point(6, 410)
        Me.btn_Importa.Name = "btn_Importa"
        Me.btn_Importa.Size = New System.Drawing.Size(37, 25)
        Me.btn_Importa.TabIndex = 0
        Me.btn_Importa.Text = "..."
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_Importa, "Importar Fotografía")
        Me.btn_Importa.UseVisualStyleBackColor = True
        '
        'btn_TomarFrente
        '
        Me.btn_TomarFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_TomarFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_TomarFrente.Location = New System.Drawing.Point(49, 410)
        Me.btn_TomarFrente.Name = "btn_TomarFrente"
        Me.btn_TomarFrente.Size = New System.Drawing.Size(37, 25)
        Me.btn_TomarFrente.TabIndex = 1
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_TomarFrente, "Tomar Fotografía con WebCam")
        Me.btn_TomarFrente.UseVisualStyleBackColor = True
        '
        'pct_Frente
        '
        Me.pct_Frente.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Frente.BackColor = System.Drawing.Color.White
        Me.pct_Frente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Frente.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Frente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Frente.Location = New System.Drawing.Point(6, 19)
        Me.pct_Frente.Name = "pct_Frente"
        Me.pct_Frente.Size = New System.Drawing.Size(432, 385)
        Me.pct_Frente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Frente.TabIndex = 127
        Me.pct_Frente.TabStop = False
        '
        'btn_LimpiarFrente
        '
        Me.btn_LimpiarFrente.Enabled = False
        Me.btn_LimpiarFrente.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarFrente.Image = CType(resources.GetObject("btn_LimpiarFrente.Image"), System.Drawing.Image)
        Me.btn_LimpiarFrente.Location = New System.Drawing.Point(92, 410)
        Me.btn_LimpiarFrente.Name = "btn_LimpiarFrente"
        Me.btn_LimpiarFrente.Size = New System.Drawing.Size(37, 25)
        Me.btn_LimpiarFrente.TabIndex = 2
        Me.btn_LimpiarFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.tlt_RasgosMensaje.SetToolTip(Me.btn_LimpiarFrente, "Eliminar Fotografía")
        Me.btn_LimpiarFrente.UseVisualStyleBackColor = True
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
        Me.tab_RasgosPersonales.Size = New System.Drawing.Size(1002, 673)
        Me.tab_RasgosPersonales.TabIndex = 8
        Me.tab_RasgosPersonales.Text = "Rasgos"
        Me.tab_RasgosPersonales.UseVisualStyleBackColor = True
        '
        'gbx_Principales
        '
        Me.gbx_Principales.Controls.Add(Me.pct_RasgoFrente)
        Me.gbx_Principales.Controls.Add(Me.cmb_ColorPiel)
        Me.gbx_Principales.Controls.Add(Me.cmb_FactorRH)
        Me.gbx_Principales.Controls.Add(Me.cmb_TipoSangreR)
        Me.gbx_Principales.Controls.Add(Me.cmb_ComplexionR)
        Me.gbx_Principales.Controls.Add(Me.cmb_Cara)
        Me.gbx_Principales.Controls.Add(Me.cmb_UsaAnteojos)
        Me.gbx_Principales.Controls.Add(Me.Label112)
        Me.gbx_Principales.Controls.Add(Me.tbx_EstaturaR)
        Me.gbx_Principales.Controls.Add(Me.Lbl_REstatura)
        Me.gbx_Principales.Controls.Add(Me.Label116)
        Me.gbx_Principales.Controls.Add(Me.Lbl_RComplexion)
        Me.gbx_Principales.Controls.Add(Me.tbx_PesoR)
        Me.gbx_Principales.Controls.Add(Me.Lbl_RPeso)
        Me.gbx_Principales.Controls.Add(Me.Lbl_RColorPiel)
        Me.gbx_Principales.Controls.Add(Me.lbl_Cara)
        Me.gbx_Principales.Controls.Add(Me.lbl_UsaAnteojos)
        Me.gbx_Principales.Controls.Add(Me.lbl_FactorRH)
        Me.gbx_Principales.Controls.Add(Me.lbl_TipoSangreR)
        Me.gbx_Principales.Location = New System.Drawing.Point(6, 6)
        Me.gbx_Principales.Name = "gbx_Principales"
        Me.gbx_Principales.Size = New System.Drawing.Size(896, 103)
        Me.gbx_Principales.TabIndex = 0
        Me.gbx_Principales.TabStop = False
        '
        'pct_RasgoFrente
        '
        Me.pct_RasgoFrente.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_RasgoFrente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_RasgoFrente.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_RasgoFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_RasgoFrente.Location = New System.Drawing.Point(765, 10)
        Me.pct_RasgoFrente.Name = "pct_RasgoFrente"
        Me.pct_RasgoFrente.Size = New System.Drawing.Size(125, 87)
        Me.pct_RasgoFrente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_RasgoFrente.TabIndex = 18
        Me.pct_RasgoFrente.TabStop = False
        '
        'cmb_ColorPiel
        '
        Me.cmb_ColorPiel.Control_Siguiente = Nothing
        Me.cmb_ColorPiel.DisplayMember = "display"
        Me.cmb_ColorPiel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorPiel.FormattingEnabled = True
        Me.cmb_ColorPiel.Location = New System.Drawing.Point(82, 44)
        Me.cmb_ColorPiel.MaxDropDownItems = 20
        Me.cmb_ColorPiel.Name = "cmb_ColorPiel"
        Me.cmb_ColorPiel.Size = New System.Drawing.Size(145, 21)
        Me.cmb_ColorPiel.TabIndex = 3
        Me.cmb_ColorPiel.ValueMember = "value"
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
        'cmb_ComplexionR
        '
        Me.cmb_ComplexionR.Control_Siguiente = Nothing
        Me.cmb_ComplexionR.DisplayMember = "display"
        Me.cmb_ComplexionR.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ComplexionR.FormattingEnabled = True
        Me.cmb_ComplexionR.Location = New System.Drawing.Point(82, 20)
        Me.cmb_ComplexionR.MaxDropDownItems = 20
        Me.cmb_ComplexionR.Name = "cmb_ComplexionR"
        Me.cmb_ComplexionR.Size = New System.Drawing.Size(145, 21)
        Me.cmb_ComplexionR.TabIndex = 1
        Me.cmb_ComplexionR.ValueMember = "value"
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
        'Lbl_REstatura
        '
        Me.Lbl_REstatura.AutoSize = True
        Me.Lbl_REstatura.Location = New System.Drawing.Point(541, 70)
        Me.Lbl_REstatura.Name = "Lbl_REstatura"
        Me.Lbl_REstatura.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_REstatura.TabIndex = 15
        Me.Lbl_REstatura.Text = "Estatura"
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
        'Lbl_RComplexion
        '
        Me.Lbl_RComplexion.AutoSize = True
        Me.Lbl_RComplexion.Location = New System.Drawing.Point(15, 23)
        Me.Lbl_RComplexion.Name = "Lbl_RComplexion"
        Me.Lbl_RComplexion.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_RComplexion.TabIndex = 0
        Me.Lbl_RComplexion.Text = "Complexión"
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
        'Lbl_RPeso
        '
        Me.Lbl_RPeso.AutoSize = True
        Me.Lbl_RPeso.Location = New System.Drawing.Point(556, 48)
        Me.Lbl_RPeso.Name = "Lbl_RPeso"
        Me.Lbl_RPeso.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_RPeso.TabIndex = 12
        Me.Lbl_RPeso.Text = "Peso"
        '
        'Lbl_RColorPiel
        '
        Me.Lbl_RColorPiel.AutoSize = True
        Me.Lbl_RColorPiel.Location = New System.Drawing.Point(25, 47)
        Me.Lbl_RColorPiel.Name = "Lbl_RColorPiel"
        Me.Lbl_RColorPiel.Size = New System.Drawing.Size(51, 13)
        Me.Lbl_RColorPiel.TabIndex = 2
        Me.Lbl_RColorPiel.Text = "Color Piel"
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
        Me.gbx_Boca.Controls.Add(Me.Lbl_RTamaño3)
        Me.gbx_Boca.Controls.Add(Me.Lbl_RComisuras)
        Me.gbx_Boca.Location = New System.Drawing.Point(262, 376)
        Me.gbx_Boca.Name = "gbx_Boca"
        Me.gbx_Boca.Size = New System.Drawing.Size(250, 73)
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
        'Lbl_RTamaño3
        '
        Me.Lbl_RTamaño3.AutoSize = True
        Me.Lbl_RTamaño3.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_RTamaño3.Name = "Lbl_RTamaño3"
        Me.Lbl_RTamaño3.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_RTamaño3.TabIndex = 0
        Me.Lbl_RTamaño3.Text = "Tamaño"
        '
        'Lbl_RComisuras
        '
        Me.Lbl_RComisuras.AutoSize = True
        Me.Lbl_RComisuras.Location = New System.Drawing.Point(14, 45)
        Me.Lbl_RComisuras.Name = "Lbl_RComisuras"
        Me.Lbl_RComisuras.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_RComisuras.TabIndex = 2
        Me.Lbl_RComisuras.Text = "Comisuras"
        '
        'gbx_Menton
        '
        Me.gbx_Menton.Controls.Add(Me.Lbl_RForma3)
        Me.gbx_Menton.Controls.Add(Me.Lbl_RInclinacion)
        Me.gbx_Menton.Controls.Add(Me.cmb_InclinacionMenton)
        Me.gbx_Menton.Controls.Add(Me.cmb_FormaMenton)
        Me.gbx_Menton.Controls.Add(Me.cmb_TipoMenton)
        Me.gbx_Menton.Controls.Add(Me.Lbl_RTipo)
        Me.gbx_Menton.Location = New System.Drawing.Point(518, 115)
        Me.gbx_Menton.Name = "gbx_Menton"
        Me.gbx_Menton.Size = New System.Drawing.Size(250, 100)
        Me.gbx_Menton.TabIndex = 8
        Me.gbx_Menton.TabStop = False
        Me.gbx_Menton.Text = "Mentón"
        '
        'Lbl_RForma3
        '
        Me.Lbl_RForma3.AutoSize = True
        Me.Lbl_RForma3.Location = New System.Drawing.Point(40, 46)
        Me.Lbl_RForma3.Name = "Lbl_RForma3"
        Me.Lbl_RForma3.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_RForma3.TabIndex = 2
        Me.Lbl_RForma3.Text = "Forma"
        '
        'Lbl_RInclinacion
        '
        Me.Lbl_RInclinacion.AutoSize = True
        Me.Lbl_RInclinacion.Location = New System.Drawing.Point(21, 70)
        Me.Lbl_RInclinacion.Name = "Lbl_RInclinacion"
        Me.Lbl_RInclinacion.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_RInclinacion.TabIndex = 4
        Me.Lbl_RInclinacion.Text = "Inclinación"
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
        'Lbl_RTipo
        '
        Me.Lbl_RTipo.AutoSize = True
        Me.Lbl_RTipo.Location = New System.Drawing.Point(48, 22)
        Me.Lbl_RTipo.Name = "Lbl_RTipo"
        Me.Lbl_RTipo.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_RTipo.TabIndex = 0
        Me.Lbl_RTipo.Text = "Tipo"
        '
        'gbx_Labios
        '
        Me.gbx_Labios.Controls.Add(Me.cmb_ProminenciaLabios)
        Me.gbx_Labios.Controls.Add(Me.cmb_AlturaNasoLabial)
        Me.gbx_Labios.Controls.Add(Me.cmb_EspesorLabios)
        Me.gbx_Labios.Controls.Add(Me.Lbl_RAlturaLabial)
        Me.gbx_Labios.Controls.Add(Me.Lbl_RProminencia)
        Me.gbx_Labios.Controls.Add(Me.Lbl_REspesor)
        Me.gbx_Labios.Location = New System.Drawing.Point(262, 455)
        Me.gbx_Labios.Name = "gbx_Labios"
        Me.gbx_Labios.Size = New System.Drawing.Size(250, 108)
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
        'Lbl_RAlturaLabial
        '
        Me.Lbl_RAlturaLabial.Location = New System.Drawing.Point(6, 42)
        Me.Lbl_RAlturaLabial.Name = "Lbl_RAlturaLabial"
        Me.Lbl_RAlturaLabial.Size = New System.Drawing.Size(66, 32)
        Me.Lbl_RAlturaLabial.TabIndex = 2
        Me.Lbl_RAlturaLabial.Text = "Altura Naso-Labial"
        '
        'Lbl_RProminencia
        '
        Me.Lbl_RProminencia.AutoSize = True
        Me.Lbl_RProminencia.Location = New System.Drawing.Point(6, 75)
        Me.Lbl_RProminencia.Name = "Lbl_RProminencia"
        Me.Lbl_RProminencia.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_RProminencia.TabIndex = 4
        Me.Lbl_RProminencia.Text = "Prominencia"
        '
        'Lbl_REspesor
        '
        Me.Lbl_REspesor.AutoSize = True
        Me.Lbl_REspesor.Location = New System.Drawing.Point(23, 21)
        Me.Lbl_REspesor.Name = "Lbl_REspesor"
        Me.Lbl_REspesor.Size = New System.Drawing.Size(45, 13)
        Me.Lbl_REspesor.TabIndex = 0
        Me.Lbl_REspesor.Text = "Espesor"
        '
        'gbx_Ojos
        '
        Me.gbx_Ojos.Controls.Add(Me.Lbl_R_Forma2)
        Me.gbx_Ojos.Controls.Add(Me.Lbl_RTamaño)
        Me.gbx_Ojos.Controls.Add(Me.cmb_TamañoOjos)
        Me.gbx_Ojos.Controls.Add(Me.cmb_ColorOjos)
        Me.gbx_Ojos.Controls.Add(Me.cmb_FormaOjos)
        Me.gbx_Ojos.Controls.Add(Me.Lbl_RColor2)
        Me.gbx_Ojos.Location = New System.Drawing.Point(262, 115)
        Me.gbx_Ojos.Name = "gbx_Ojos"
        Me.gbx_Ojos.Size = New System.Drawing.Size(250, 100)
        Me.gbx_Ojos.TabIndex = 4
        Me.gbx_Ojos.TabStop = False
        Me.gbx_Ojos.Text = "Ojos"
        '
        'Lbl_R_Forma2
        '
        Me.Lbl_R_Forma2.AutoSize = True
        Me.Lbl_R_Forma2.Location = New System.Drawing.Point(32, 46)
        Me.Lbl_R_Forma2.Name = "Lbl_R_Forma2"
        Me.Lbl_R_Forma2.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_R_Forma2.TabIndex = 2
        Me.Lbl_R_Forma2.Text = "Forma"
        '
        'Lbl_RTamaño
        '
        Me.Lbl_RTamaño.AutoSize = True
        Me.Lbl_RTamaño.Location = New System.Drawing.Point(22, 70)
        Me.Lbl_RTamaño.Name = "Lbl_RTamaño"
        Me.Lbl_RTamaño.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_RTamaño.TabIndex = 4
        Me.Lbl_RTamaño.Text = "Tamaño"
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
        'cmb_ColorOjos
        '
        Me.cmb_ColorOjos.Control_Siguiente = Nothing
        Me.cmb_ColorOjos.DisplayMember = "display"
        Me.cmb_ColorOjos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorOjos.FormattingEnabled = True
        Me.cmb_ColorOjos.Location = New System.Drawing.Point(74, 19)
        Me.cmb_ColorOjos.MaxDropDownItems = 20
        Me.cmb_ColorOjos.Name = "cmb_ColorOjos"
        Me.cmb_ColorOjos.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ColorOjos.TabIndex = 1
        Me.cmb_ColorOjos.ValueMember = "value"
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
        'Lbl_RColor2
        '
        Me.Lbl_RColor2.AutoSize = True
        Me.Lbl_RColor2.Location = New System.Drawing.Point(37, 22)
        Me.Lbl_RColor2.Name = "Lbl_RColor2"
        Me.Lbl_RColor2.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_RColor2.TabIndex = 0
        Me.Lbl_RColor2.Text = "Color"
        '
        'gbx_Cejas
        '
        Me.gbx_Cejas.Controls.Add(Me.cmb_TamañoCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_FormaCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_ImplantacionCejas)
        Me.gbx_Cejas.Controls.Add(Me.cmb_DireccionCejas)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_RTamaño2)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_RImplantacion2)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_RForma4)
        Me.gbx_Cejas.Controls.Add(Me.Lbl_RDireccion)
        Me.gbx_Cejas.Location = New System.Drawing.Point(6, 397)
        Me.gbx_Cejas.Name = "gbx_Cejas"
        Me.gbx_Cejas.Size = New System.Drawing.Size(250, 166)
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
        'Lbl_RTamaño2
        '
        Me.Lbl_RTamaño2.AutoSize = True
        Me.Lbl_RTamaño2.Location = New System.Drawing.Point(29, 101)
        Me.Lbl_RTamaño2.Name = "Lbl_RTamaño2"
        Me.Lbl_RTamaño2.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_RTamaño2.TabIndex = 6
        Me.Lbl_RTamaño2.Text = "Tamaño"
        '
        'Lbl_RImplantacion2
        '
        Me.Lbl_RImplantacion2.AutoSize = True
        Me.Lbl_RImplantacion2.Location = New System.Drawing.Point(8, 53)
        Me.Lbl_RImplantacion2.Name = "Lbl_RImplantacion2"
        Me.Lbl_RImplantacion2.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_RImplantacion2.TabIndex = 2
        Me.Lbl_RImplantacion2.Text = "Implantación"
        '
        'Lbl_RForma4
        '
        Me.Lbl_RForma4.AutoSize = True
        Me.Lbl_RForma4.Location = New System.Drawing.Point(39, 77)
        Me.Lbl_RForma4.Name = "Lbl_RForma4"
        Me.Lbl_RForma4.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_RForma4.TabIndex = 4
        Me.Lbl_RForma4.Text = "Forma"
        '
        'Lbl_RDireccion
        '
        Me.Lbl_RDireccion.AutoSize = True
        Me.Lbl_RDireccion.Location = New System.Drawing.Point(23, 29)
        Me.Lbl_RDireccion.Name = "Lbl_RDireccion"
        Me.Lbl_RDireccion.Size = New System.Drawing.Size(52, 13)
        Me.Lbl_RDireccion.TabIndex = 0
        Me.Lbl_RDireccion.Text = "Dirección"
        '
        'gbx_Frente
        '
        Me.gbx_Frente.Controls.Add(Me.cmb_AnchoFrente)
        Me.gbx_Frente.Controls.Add(Me.cmb_InclinacionFrente)
        Me.gbx_Frente.Controls.Add(Me.cmb_AlturaFrente)
        Me.gbx_Frente.Controls.Add(Me.Lbl_RAltura2)
        Me.gbx_Frente.Controls.Add(Me.Lbl_RAncho)
        Me.gbx_Frente.Controls.Add(Me.Lbl_RAltura)
        Me.gbx_Frente.Location = New System.Drawing.Point(6, 276)
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
        'Lbl_RAltura2
        '
        Me.Lbl_RAltura2.AutoSize = True
        Me.Lbl_RAltura2.Location = New System.Drawing.Point(17, 51)
        Me.Lbl_RAltura2.Name = "Lbl_RAltura2"
        Me.Lbl_RAltura2.Size = New System.Drawing.Size(58, 13)
        Me.Lbl_RAltura2.TabIndex = 2
        Me.Lbl_RAltura2.Text = "Inclinación"
        '
        'Lbl_RAncho
        '
        Me.Lbl_RAncho.AutoSize = True
        Me.Lbl_RAncho.Location = New System.Drawing.Point(37, 75)
        Me.Lbl_RAncho.Name = "Lbl_RAncho"
        Me.Lbl_RAncho.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_RAncho.TabIndex = 4
        Me.Lbl_RAncho.Text = "Ancho"
        '
        'Lbl_RAltura
        '
        Me.Lbl_RAltura.AutoSize = True
        Me.Lbl_RAltura.Location = New System.Drawing.Point(41, 27)
        Me.Lbl_RAltura.Name = "Lbl_RAltura"
        Me.Lbl_RAltura.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_RAltura.TabIndex = 0
        Me.Lbl_RAltura.Text = "Altura"
        '
        'gbx_Nariz
        '
        Me.gbx_Nariz.Controls.Add(Me.cmb_AlturaNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_BaseNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_AnchoNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_DorsoNariz)
        Me.gbx_Nariz.Controls.Add(Me.cmb_RaizNariz)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RAltura3)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RBase)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RDorso)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RAncho2)
        Me.gbx_Nariz.Controls.Add(Me.Lbl_RRaiz)
        Me.gbx_Nariz.Location = New System.Drawing.Point(262, 220)
        Me.gbx_Nariz.Name = "gbx_Nariz"
        Me.gbx_Nariz.Size = New System.Drawing.Size(250, 150)
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
        'Lbl_RAltura3
        '
        Me.Lbl_RAltura3.AutoSize = True
        Me.Lbl_RAltura3.Location = New System.Drawing.Point(34, 118)
        Me.Lbl_RAltura3.Name = "Lbl_RAltura3"
        Me.Lbl_RAltura3.Size = New System.Drawing.Size(34, 13)
        Me.Lbl_RAltura3.TabIndex = 8
        Me.Lbl_RAltura3.Text = "Altura"
        '
        'Lbl_RBase
        '
        Me.Lbl_RBase.AutoSize = True
        Me.Lbl_RBase.Location = New System.Drawing.Point(37, 94)
        Me.Lbl_RBase.Name = "Lbl_RBase"
        Me.Lbl_RBase.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_RBase.TabIndex = 6
        Me.Lbl_RBase.Text = "Base"
        '
        'Lbl_RDorso
        '
        Me.Lbl_RDorso.AutoSize = True
        Me.Lbl_RDorso.Location = New System.Drawing.Point(33, 46)
        Me.Lbl_RDorso.Name = "Lbl_RDorso"
        Me.Lbl_RDorso.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_RDorso.TabIndex = 2
        Me.Lbl_RDorso.Text = "Dorso"
        '
        'Lbl_RAncho2
        '
        Me.Lbl_RAncho2.AutoSize = True
        Me.Lbl_RAncho2.Location = New System.Drawing.Point(30, 70)
        Me.Lbl_RAncho2.Name = "Lbl_RAncho2"
        Me.Lbl_RAncho2.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_RAncho2.TabIndex = 4
        Me.Lbl_RAncho2.Text = "Ancho"
        '
        'Lbl_RRaiz
        '
        Me.Lbl_RRaiz.AutoSize = True
        Me.Lbl_RRaiz.Location = New System.Drawing.Point(38, 22)
        Me.Lbl_RRaiz.Name = "Lbl_RRaiz"
        Me.Lbl_RRaiz.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_RRaiz.TabIndex = 0
        Me.Lbl_RRaiz.Text = "Raíz"
        '
        'gbx_Oreja
        '
        Me.gbx_Oreja.Controls.Add(Me.gbx_Lobulo)
        Me.gbx_Oreja.Controls.Add(Me.gbx_Helix)
        Me.gbx_Oreja.Controls.Add(Me.cmb_OriginalOreja)
        Me.gbx_Oreja.Controls.Add(Me.cmb_FormaOreja)
        Me.gbx_Oreja.Controls.Add(Me.Lbl_ROriginal)
        Me.gbx_Oreja.Controls.Add(Me.Lbl_RForma2)
        Me.gbx_Oreja.Location = New System.Drawing.Point(518, 221)
        Me.gbx_Oreja.Name = "gbx_Oreja"
        Me.gbx_Oreja.Size = New System.Drawing.Size(250, 342)
        Me.gbx_Oreja.TabIndex = 9
        Me.gbx_Oreja.TabStop = False
        Me.gbx_Oreja.Text = "Oreja Derecha"
        '
        'gbx_Lobulo
        '
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloDimension)
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloParticularidad)
        Me.gbx_Lobulo.Controls.Add(Me.cmb_LobuloAdherencia)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_RParticularidad)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_RAdherencia)
        Me.gbx_Lobulo.Controls.Add(Me.Lbl_RDimension)
        Me.gbx_Lobulo.Location = New System.Drawing.Point(0, 216)
        Me.gbx_Lobulo.Name = "gbx_Lobulo"
        Me.gbx_Lobulo.Size = New System.Drawing.Size(250, 126)
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
        'Lbl_RParticularidad
        '
        Me.Lbl_RParticularidad.AutoSize = True
        Me.Lbl_RParticularidad.Location = New System.Drawing.Point(6, 59)
        Me.Lbl_RParticularidad.Name = "Lbl_RParticularidad"
        Me.Lbl_RParticularidad.Size = New System.Drawing.Size(71, 13)
        Me.Lbl_RParticularidad.TabIndex = 2
        Me.Lbl_RParticularidad.Text = "Particularidad"
        '
        'Lbl_RAdherencia
        '
        Me.Lbl_RAdherencia.AutoSize = True
        Me.Lbl_RAdherencia.Location = New System.Drawing.Point(14, 35)
        Me.Lbl_RAdherencia.Name = "Lbl_RAdherencia"
        Me.Lbl_RAdherencia.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_RAdherencia.TabIndex = 0
        Me.Lbl_RAdherencia.Text = "Adherencia"
        '
        'Lbl_RDimension
        '
        Me.Lbl_RDimension.AutoSize = True
        Me.Lbl_RDimension.Location = New System.Drawing.Point(19, 83)
        Me.Lbl_RDimension.Name = "Lbl_RDimension"
        Me.Lbl_RDimension.Size = New System.Drawing.Size(56, 13)
        Me.Lbl_RDimension.TabIndex = 4
        Me.Lbl_RDimension.Text = "Dimensión"
        '
        'gbx_Helix
        '
        Me.gbx_Helix.Controls.Add(Me.Lbl_RSuperior)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixContorno)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixAdherencia)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixPosterior)
        Me.gbx_Helix.Controls.Add(Me.cmb_HelixSuperior)
        Me.gbx_Helix.Controls.Add(Me.Lbl_RPosterior)
        Me.gbx_Helix.Controls.Add(Me.Lbl_RAdherencia2)
        Me.gbx_Helix.Controls.Add(Me.Lbl_RContorno)
        Me.gbx_Helix.Location = New System.Drawing.Point(0, 83)
        Me.gbx_Helix.Name = "gbx_Helix"
        Me.gbx_Helix.Size = New System.Drawing.Size(250, 135)
        Me.gbx_Helix.TabIndex = 4
        Me.gbx_Helix.TabStop = False
        Me.gbx_Helix.Text = "Hélix"
        '
        'Lbl_RSuperior
        '
        Me.Lbl_RSuperior.AutoSize = True
        Me.Lbl_RSuperior.Location = New System.Drawing.Point(29, 26)
        Me.Lbl_RSuperior.Name = "Lbl_RSuperior"
        Me.Lbl_RSuperior.Size = New System.Drawing.Size(46, 13)
        Me.Lbl_RSuperior.TabIndex = 0
        Me.Lbl_RSuperior.Text = "Superior"
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
        'Lbl_RPosterior
        '
        Me.Lbl_RPosterior.AutoSize = True
        Me.Lbl_RPosterior.Location = New System.Drawing.Point(27, 50)
        Me.Lbl_RPosterior.Name = "Lbl_RPosterior"
        Me.Lbl_RPosterior.Size = New System.Drawing.Size(48, 13)
        Me.Lbl_RPosterior.TabIndex = 2
        Me.Lbl_RPosterior.Text = "Posterior"
        '
        'Lbl_RAdherencia2
        '
        Me.Lbl_RAdherencia2.AutoSize = True
        Me.Lbl_RAdherencia2.Location = New System.Drawing.Point(14, 74)
        Me.Lbl_RAdherencia2.Name = "Lbl_RAdherencia2"
        Me.Lbl_RAdherencia2.Size = New System.Drawing.Size(61, 13)
        Me.Lbl_RAdherencia2.TabIndex = 4
        Me.Lbl_RAdherencia2.Text = "Adherencia"
        '
        'Lbl_RContorno
        '
        Me.Lbl_RContorno.AutoSize = True
        Me.Lbl_RContorno.Location = New System.Drawing.Point(25, 98)
        Me.Lbl_RContorno.Name = "Lbl_RContorno"
        Me.Lbl_RContorno.Size = New System.Drawing.Size(50, 13)
        Me.Lbl_RContorno.TabIndex = 6
        Me.Lbl_RContorno.Text = "Contorno"
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
        'Lbl_ROriginal
        '
        Me.Lbl_ROriginal.AutoSize = True
        Me.Lbl_ROriginal.Location = New System.Drawing.Point(31, 46)
        Me.Lbl_ROriginal.Name = "Lbl_ROriginal"
        Me.Lbl_ROriginal.Size = New System.Drawing.Size(42, 13)
        Me.Lbl_ROriginal.TabIndex = 2
        Me.Lbl_ROriginal.Text = "Original"
        '
        'Lbl_RForma2
        '
        Me.Lbl_RForma2.AutoSize = True
        Me.Lbl_RForma2.Location = New System.Drawing.Point(39, 22)
        Me.Lbl_RForma2.Name = "Lbl_RForma2"
        Me.Lbl_RForma2.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_RForma2.TabIndex = 0
        Me.Lbl_RForma2.Text = "Forma"
        '
        'gbx_Cabello
        '
        Me.gbx_Cabello.Controls.Add(Me.cmb_ImplantacionCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_Calvicie)
        Me.gbx_Cabello.Controls.Add(Me.cmb_FormaCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_ColorCabello)
        Me.gbx_Cabello.Controls.Add(Me.cmb_CantidadCabello)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_RImplantacion)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_RCalvicie)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_RColor)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_RForma)
        Me.gbx_Cabello.Controls.Add(Me.Lbl_RCantidad)
        Me.gbx_Cabello.Location = New System.Drawing.Point(6, 115)
        Me.gbx_Cabello.Name = "gbx_Cabello"
        Me.gbx_Cabello.Size = New System.Drawing.Size(250, 155)
        Me.gbx_Cabello.TabIndex = 1
        Me.gbx_Cabello.TabStop = False
        Me.gbx_Cabello.Text = "Cabello"
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
        'cmb_ColorCabello
        '
        Me.cmb_ColorCabello.Control_Siguiente = Nothing
        Me.cmb_ColorCabello.DisplayMember = "display"
        Me.cmb_ColorCabello.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ColorCabello.FormattingEnabled = True
        Me.cmb_ColorCabello.Location = New System.Drawing.Point(81, 43)
        Me.cmb_ColorCabello.MaxDropDownItems = 20
        Me.cmb_ColorCabello.Name = "cmb_ColorCabello"
        Me.cmb_ColorCabello.Size = New System.Drawing.Size(146, 21)
        Me.cmb_ColorCabello.TabIndex = 3
        Me.cmb_ColorCabello.ValueMember = "value"
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
        'Lbl_RImplantacion
        '
        Me.Lbl_RImplantacion.AutoSize = True
        Me.Lbl_RImplantacion.Location = New System.Drawing.Point(8, 118)
        Me.Lbl_RImplantacion.Name = "Lbl_RImplantacion"
        Me.Lbl_RImplantacion.Size = New System.Drawing.Size(67, 13)
        Me.Lbl_RImplantacion.TabIndex = 8
        Me.Lbl_RImplantacion.Text = "Implantación"
        '
        'Lbl_RCalvicie
        '
        Me.Lbl_RCalvicie.AutoSize = True
        Me.Lbl_RCalvicie.Location = New System.Drawing.Point(31, 94)
        Me.Lbl_RCalvicie.Name = "Lbl_RCalvicie"
        Me.Lbl_RCalvicie.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_RCalvicie.TabIndex = 6
        Me.Lbl_RCalvicie.Text = "Calvicie"
        '
        'Lbl_RColor
        '
        Me.Lbl_RColor.AutoSize = True
        Me.Lbl_RColor.Location = New System.Drawing.Point(44, 46)
        Me.Lbl_RColor.Name = "Lbl_RColor"
        Me.Lbl_RColor.Size = New System.Drawing.Size(31, 13)
        Me.Lbl_RColor.TabIndex = 2
        Me.Lbl_RColor.Text = "Color"
        '
        'Lbl_RForma
        '
        Me.Lbl_RForma.AutoSize = True
        Me.Lbl_RForma.Location = New System.Drawing.Point(39, 70)
        Me.Lbl_RForma.Name = "Lbl_RForma"
        Me.Lbl_RForma.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_RForma.TabIndex = 4
        Me.Lbl_RForma.Text = "Forma"
        '
        'Lbl_RCantidad
        '
        Me.Lbl_RCantidad.AutoSize = True
        Me.Lbl_RCantidad.Location = New System.Drawing.Point(26, 22)
        Me.Lbl_RCantidad.Name = "Lbl_RCantidad"
        Me.Lbl_RCantidad.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_RCantidad.TabIndex = 0
        Me.Lbl_RCantidad.Text = "Cantidad"
        '
        'btn_CancelarRasgos
        '
        Me.btn_CancelarRasgos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_CancelarRasgos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_CancelarRasgos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_CancelarRasgos.Location = New System.Drawing.Point(628, 636)
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
        Me.btn_GuardarRasgos.Location = New System.Drawing.Point(7, 636)
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
        Me.tab_DatosEscolares.Size = New System.Drawing.Size(1002, 673)
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
        Me.cmb_ATermino.TabIndex = 20
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
        Me.tbx_Folio.TabIndex = 23
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
        Me.tbx_Promedio.TabIndex = 25
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
        Me.tbx_NombreCurso.TabIndex = 4
        Me.tbx_NombreCurso.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'dtp_FInicioCurso
        '
        Me.dtp_FInicioCurso.Enabled = False
        Me.dtp_FInicioCurso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FInicioCurso.Location = New System.Drawing.Point(135, 70)
        Me.dtp_FInicioCurso.Name = "dtp_FInicioCurso"
        Me.dtp_FInicioCurso.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FInicioCurso.TabIndex = 7
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
        Me.cmb_AInicio.TabIndex = 17
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
        Me.cmb_Documentacion.TabIndex = 5
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
        Me.tbx_NombreEscuela.TabIndex = 8
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
        Me.tbx_Carrera.TabIndex = 11
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
        Me.tbx_Especialidad.TabIndex = 15
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
        Me.gbx_CursosRecibidos.Controls.Add(Me.btn_Agregar_Curso)
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
        Me.gbx_CursosRecibidos.Size = New System.Drawing.Size(984, 451)
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
        Me.btn_BuscarCurso.TabIndex = 119
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
        Me.cmb_TipoCurso.TabIndex = 1
        Me.cmb_TipoCurso.ValueMember = "value"
        '
        'btn_Borrar_DatosEscolares
        '
        Me.btn_Borrar_DatosEscolares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosEscolares.Enabled = False
        Me.btn_Borrar_DatosEscolares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosEscolares.Location = New System.Drawing.Point(298, 415)
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
        Me.btn_Cancelar_DatosEscolares.Location = New System.Drawing.Point(444, 415)
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
        Me.btn_Modificar_DatosEscolares.Location = New System.Drawing.Point(152, 415)
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
        Me.rdb_No_CursoFin.TabIndex = 1
        Me.rdb_No_CursoFin.Text = "No"
        Me.rdb_No_CursoFin.UseVisualStyleBackColor = True
        '
        'rdb_Si_CursoFin
        '
        Me.rdb_Si_CursoFin.AutoSize = True
        Me.rdb_Si_CursoFin.Location = New System.Drawing.Point(10, 13)
        Me.rdb_Si_CursoFin.Name = "rdb_Si_CursoFin"
        Me.rdb_Si_CursoFin.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_CursoFin.TabIndex = 0
        Me.rdb_Si_CursoFin.Text = "Si"
        Me.rdb_Si_CursoFin.UseVisualStyleBackColor = True
        '
        'btn_Agregar_Curso
        '
        Me.btn_Agregar_Curso.Enabled = False
        Me.btn_Agregar_Curso.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Curso.Location = New System.Drawing.Point(496, 157)
        Me.btn_Agregar_Curso.Name = "btn_Agregar_Curso"
        Me.btn_Agregar_Curso.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Curso.TabIndex = 21
        Me.btn_Agregar_Curso.Text = "Agregar"
        Me.btn_Agregar_Curso.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Curso.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Curso.UseVisualStyleBackColor = True
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
        Me.tbx_Comentarios.Control_Siguiente = Me.btn_Agregar_Curso
        Me.tbx_Comentarios.Enabled = False
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(136, 167)
        Me.tbx_Comentarios.MaxLength = 100
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Comentarios.TabIndex = 20
        Me.tbx_Comentarios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'dtp_FTerminoCurso
        '
        Me.dtp_FTerminoCurso.Enabled = False
        Me.dtp_FTerminoCurso.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FTerminoCurso.Location = New System.Drawing.Point(135, 94)
        Me.dtp_FTerminoCurso.Name = "dtp_FTerminoCurso"
        Me.dtp_FTerminoCurso.Size = New System.Drawing.Size(100, 20)
        Me.dtp_FTerminoCurso.TabIndex = 12
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
        Me.btn_Guardar_DatosEscolares.Location = New System.Drawing.Point(6, 415)
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
        ListViewColumnSorter4.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter4.SortColumn = 0
        Me.lsv_Cursos.Lvs = ListViewColumnSorter4
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
        Me.lsv_Cursos.Size = New System.Drawing.Size(972, 216)
        Me.lsv_Cursos.TabIndex = 22
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
        Me.tbx_Instructor.TabIndex = 15
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
        Me.tbx_CedulaProfesional.TabIndex = 13
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
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Borrar_DatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Cancelar_DatosFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.btn_Modificar_Familiares)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label54)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label128)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label127)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label53)
        Me.tab_DatosFamiliares.Controls.Add(Me.Label52)
        Me.tab_DatosFamiliares.Controls.Add(Me.cmb_CiudadesFamiliares)
        Me.tab_DatosFamiliares.Controls.Add(Me.dtp_FecNac_Familiar)
        Me.tab_DatosFamiliares.Controls.Add(Me.gbx_Vive)
        Me.tab_DatosFamiliares.Controls.Add(Me.gbx_MismoDomicilio)
        Me.tab_DatosFamiliares.Controls.Add(Me.lbl_Ciudad)
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
        Me.tab_DatosFamiliares.Size = New System.Drawing.Size(1002, 673)
        Me.tab_DatosFamiliares.TabIndex = 2
        Me.tab_DatosFamiliares.Text = "Datos Familiares"
        Me.tab_DatosFamiliares.UseVisualStyleBackColor = True
        '
        'btn_Borrar_DatosFamiliares
        '
        Me.btn_Borrar_DatosFamiliares.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosFamiliares.Enabled = False
        Me.btn_Borrar_DatosFamiliares.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosFamiliares.Location = New System.Drawing.Point(295, 639)
        Me.btn_Borrar_DatosFamiliares.Name = "btn_Borrar_DatosFamiliares"
        Me.btn_Borrar_DatosFamiliares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_DatosFamiliares.TabIndex = 16
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
        Me.btn_Cancelar_DatosFamiliares.Location = New System.Drawing.Point(441, 639)
        Me.btn_Cancelar_DatosFamiliares.Name = "btn_Cancelar_DatosFamiliares"
        Me.btn_Cancelar_DatosFamiliares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DatosFamiliares.TabIndex = 17
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
        Me.btn_Modificar_Familiares.Location = New System.Drawing.Point(149, 639)
        Me.btn_Modificar_Familiares.Name = "btn_Modificar_Familiares"
        Me.btn_Modificar_Familiares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Familiares.TabIndex = 15
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
        Me.Label54.Location = New System.Drawing.Point(336, 43)
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
        Me.Label128.Location = New System.Drawing.Point(217, 222)
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
        Me.Label127.Location = New System.Drawing.Point(257, 108)
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
        Me.Label53.Location = New System.Drawing.Point(382, 222)
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
        Me.Label52.Location = New System.Drawing.Point(458, 17)
        Me.Label52.Name = "Label52"
        Me.Label52.Size = New System.Drawing.Size(13, 16)
        Me.Label52.TabIndex = 18
        Me.Label52.Text = "*"
        '
        'cmb_CiudadesFamiliares
        '
        Me.cmb_CiudadesFamiliares.Clave = Nothing
        Me.cmb_CiudadesFamiliares.Control_Siguiente = Me.tbx_TelefonoFamiliares
        Me.cmb_CiudadesFamiliares.DisplayMember = "Nombre"
        Me.cmb_CiudadesFamiliares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_CiudadesFamiliares.Empresa = False
        Me.cmb_CiudadesFamiliares.Filtro = Nothing
        Me.cmb_CiudadesFamiliares.FormattingEnabled = True
        Me.cmb_CiudadesFamiliares.Location = New System.Drawing.Point(102, 159)
        Me.cmb_CiudadesFamiliares.MaxDropDownItems = 20
        Me.cmb_CiudadesFamiliares.Name = "cmb_CiudadesFamiliares"
        Me.cmb_CiudadesFamiliares.Pista = False
        Me.cmb_CiudadesFamiliares.Size = New System.Drawing.Size(350, 21)
        Me.cmb_CiudadesFamiliares.StoredProcedure = "Cat_CiudadesPais_Get"
        Me.cmb_CiudadesFamiliares.Sucursal = False
        Me.cmb_CiudadesFamiliares.TabIndex = 9
        Me.cmb_CiudadesFamiliares.Tipo = 0
        Me.cmb_CiudadesFamiliares.ValueMember = "id_Ciudad"
        '
        'tbx_TelefonoFamiliares
        '
        Me.tbx_TelefonoFamiliares.Control_Siguiente = Me.rdb_Si_Vive
        Me.tbx_TelefonoFamiliares.Filtrado = True
        Me.tbx_TelefonoFamiliares.Location = New System.Drawing.Point(102, 184)
        Me.tbx_TelefonoFamiliares.MaxLength = 25
        Me.tbx_TelefonoFamiliares.Name = "tbx_TelefonoFamiliares"
        Me.tbx_TelefonoFamiliares.Size = New System.Drawing.Size(110, 20)
        Me.tbx_TelefonoFamiliares.TabIndex = 11
        Me.tbx_TelefonoFamiliares.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'rdb_Si_Vive
        '
        Me.rdb_Si_Vive.AutoSize = True
        Me.rdb_Si_Vive.Location = New System.Drawing.Point(10, 15)
        Me.rdb_Si_Vive.Name = "rdb_Si_Vive"
        Me.rdb_Si_Vive.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_Vive.TabIndex = 0
        Me.rdb_Si_Vive.Text = "Si"
        Me.rdb_Si_Vive.UseVisualStyleBackColor = True
        '
        'dtp_FecNac_Familiar
        '
        Me.dtp_FecNac_Familiar.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FecNac_Familiar.Location = New System.Drawing.Point(102, 69)
        Me.dtp_FecNac_Familiar.Name = "dtp_FecNac_Familiar"
        Me.dtp_FecNac_Familiar.Size = New System.Drawing.Size(110, 20)
        Me.dtp_FecNac_Familiar.TabIndex = 5
        Me.dtp_FecNac_Familiar.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'gbx_Vive
        '
        Me.gbx_Vive.Controls.Add(Me.rdb_Si_Vive)
        Me.gbx_Vive.Controls.Add(Me.rdb_No_Vive)
        Me.gbx_Vive.Location = New System.Drawing.Point(102, 208)
        Me.gbx_Vive.Name = "gbx_Vive"
        Me.gbx_Vive.Size = New System.Drawing.Size(110, 37)
        Me.gbx_Vive.TabIndex = 12
        Me.gbx_Vive.TabStop = False
        Me.gbx_Vive.Text = "Vive"
        '
        'rdb_No_Vive
        '
        Me.rdb_No_Vive.AutoSize = True
        Me.rdb_No_Vive.Location = New System.Drawing.Point(68, 14)
        Me.rdb_No_Vive.Name = "rdb_No_Vive"
        Me.rdb_No_Vive.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_Vive.TabIndex = 1
        Me.rdb_No_Vive.Text = "No"
        Me.rdb_No_Vive.UseVisualStyleBackColor = True
        '
        'gbx_MismoDomicilio
        '
        Me.gbx_MismoDomicilio.Controls.Add(Me.rdb_Si_MismoDom)
        Me.gbx_MismoDomicilio.Controls.Add(Me.rdb_No_MismoDom)
        Me.gbx_MismoDomicilio.Location = New System.Drawing.Point(102, 93)
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
        Me.rdb_Si_MismoDom.TabIndex = 0
        Me.rdb_Si_MismoDom.Text = "Si"
        Me.rdb_Si_MismoDom.UseVisualStyleBackColor = True
        '
        'rdb_No_MismoDom
        '
        Me.rdb_No_MismoDom.AutoSize = True
        Me.rdb_No_MismoDom.Location = New System.Drawing.Point(69, 15)
        Me.rdb_No_MismoDom.Name = "rdb_No_MismoDom"
        Me.rdb_No_MismoDom.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_MismoDom.TabIndex = 1
        Me.rdb_No_MismoDom.Text = "No"
        Me.rdb_No_MismoDom.UseVisualStyleBackColor = True
        '
        'lbl_Ciudad
        '
        Me.lbl_Ciudad.AutoSize = True
        Me.lbl_Ciudad.Location = New System.Drawing.Point(56, 162)
        Me.lbl_Ciudad.Name = "lbl_Ciudad"
        Me.lbl_Ciudad.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Ciudad.TabIndex = 8
        Me.lbl_Ciudad.Text = "Ciudad"
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
        Me.cmb_Parentesco.Location = New System.Drawing.Point(102, 42)
        Me.cmb_Parentesco.MaxDropDownItems = 20
        Me.cmb_Parentesco.Name = "cmb_Parentesco"
        Me.cmb_Parentesco.Pista = False
        Me.cmb_Parentesco.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Parentesco.StoredProcedure = "Cat_TipoParentescoCombo_Get"
        Me.cmb_Parentesco.Sucursal = False
        Me.cmb_Parentesco.TabIndex = 3
        Me.cmb_Parentesco.Tipo = 0
        Me.cmb_Parentesco.ValueMember = "Id_TipoParentesco"
        '
        'lbl_Parentesco
        '
        Me.lbl_Parentesco.AutoSize = True
        Me.lbl_Parentesco.Location = New System.Drawing.Point(35, 45)
        Me.lbl_Parentesco.Name = "lbl_Parentesco"
        Me.lbl_Parentesco.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Parentesco.TabIndex = 2
        Me.lbl_Parentesco.Text = "Parentesco"
        '
        'tbx_Domicilio_Familiares
        '
        Me.tbx_Domicilio_Familiares.Control_Siguiente = Me.cmb_CiudadesFamiliares
        Me.tbx_Domicilio_Familiares.Filtrado = True
        Me.tbx_Domicilio_Familiares.Location = New System.Drawing.Point(102, 135)
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
        Me.gbx_DepEconomico.Location = New System.Drawing.Point(236, 208)
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
        Me.rdb_Si_DepEcon.TabIndex = 0
        Me.rdb_Si_DepEcon.Text = "Si"
        Me.rdb_Si_DepEcon.UseVisualStyleBackColor = True
        '
        'rdb_No_DepEcon
        '
        Me.rdb_No_DepEcon.AutoSize = True
        Me.rdb_No_DepEcon.Location = New System.Drawing.Point(95, 15)
        Me.rdb_No_DepEcon.Name = "rdb_No_DepEcon"
        Me.rdb_No_DepEcon.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_DepEcon.TabIndex = 1
        Me.rdb_No_DepEcon.Text = "No"
        Me.rdb_No_DepEcon.UseVisualStyleBackColor = True
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Location = New System.Drawing.Point(47, 187)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono.TabIndex = 10
        Me.lbl_Telefono.Text = "Teléfono"
        '
        'lbl_Domicilio
        '
        Me.lbl_Domicilio.AutoSize = True
        Me.lbl_Domicilio.Location = New System.Drawing.Point(47, 138)
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
        Me.tbx_NombreFamiliar.Location = New System.Drawing.Point(102, 16)
        Me.tbx_NombreFamiliar.MaxLength = 100
        Me.tbx_NombreFamiliar.Name = "tbx_NombreFamiliar"
        Me.tbx_NombreFamiliar.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreFamiliar.TabIndex = 1
        Me.tbx_NombreFamiliar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_NombreFamiliar
        '
        Me.lbl_NombreFamiliar.AutoSize = True
        Me.lbl_NombreFamiliar.Location = New System.Drawing.Point(5, 19)
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
        Me.btn_Agregar_Familiares.TabIndex = 11
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
        Me.btn_Guardar_Familiares.Location = New System.Drawing.Point(3, 639)
        Me.btn_Guardar_Familiares.Name = "btn_Guardar_Familiares"
        Me.btn_Guardar_Familiares.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Familiares.TabIndex = 14
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
        Me.lsv_Familiares.Location = New System.Drawing.Point(3, 251)
        ListViewColumnSorter5.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter5.SortColumn = 0
        Me.lsv_Familiares.Lvs = ListViewColumnSorter5
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
        Me.lsv_Familiares.Size = New System.Drawing.Size(996, 382)
        Me.lsv_Familiares.TabIndex = 13
        Me.lsv_Familiares.UseCompatibleStateImageBehavior = False
        Me.lsv_Familiares.View = System.Windows.Forms.View.Details
        '
        'tab_Empleos
        '
        Me.tab_Empleos.Controls.Add(Me.btn_Investigacion)
        Me.tab_Empleos.Controls.Add(Me.tbx_Colonias_Empleos)
        Me.tab_Empleos.Controls.Add(Me.cmb_Paises_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Label7)
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
        Me.tab_Empleos.Controls.Add(Me.Label67)
        Me.tab_Empleos.Controls.Add(Me.Label66)
        Me.tab_Empleos.Controls.Add(Me.Label64)
        Me.tab_Empleos.Controls.Add(Me.Label63)
        Me.tab_Empleos.Controls.Add(Me.Label61)
        Me.tab_Empleos.Controls.Add(Me.Label60)
        Me.tab_Empleos.Controls.Add(Me.Label59)
        Me.tab_Empleos.Controls.Add(Me.cmb_MotivoSeparacion)
        Me.tab_Empleos.Controls.Add(Me.cmb_Ciudades_Empleos)
        Me.tab_Empleos.Controls.Add(Me.dtp_FechaBaja_Empleos)
        Me.tab_Empleos.Controls.Add(Me.dtp_FechaIngreso_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_OtroMotivo)
        Me.tab_Empleos.Controls.Add(Me.Lbl_OtroMotE)
        Me.tab_Empleos.Controls.Add(Me.Lbl_MotSepE)
        Me.tab_Empleos.Controls.Add(Me.tbx_SueldoFinal_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_SueFinMenE)
        Me.tab_Empleos.Controls.Add(Me.tbx_SueldoInicial_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_Telefono_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_SueIniMenE)
        Me.tab_Empleos.Controls.Add(Me.Lbl_TelefonoE)
        Me.tab_Empleos.Controls.Add(Me.tbx_PuestoJefe_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_PuestJefInmE)
        Me.tab_Empleos.Controls.Add(Me.tbx_NombreJefe_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NomJefInmE)
        Me.tab_Empleos.Controls.Add(Me.tbx_Puesto_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_PuestoE)
        Me.tab_Empleos.Controls.Add(Me.lbl_FBaja)
        Me.tab_Empleos.Controls.Add(Me.lbl_FIngreso)
        Me.tab_Empleos.Controls.Add(Me.btn_LimpiarLaborales)
        Me.tab_Empleos.Controls.Add(Me.btn_MapaLaborales)
        Me.tab_Empleos.Controls.Add(Me.btn_Borrar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Cancelar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Modificar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Agregar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.btn_Guardar_Empleos)
        Me.tab_Empleos.Controls.Add(Me.lsv_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_CodigoPostal_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_NumeroInt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.tbx_NumeroExt_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_CPE)
        Me.tab_Empleos.Controls.Add(Me.Lbl_CiudadE)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NumIntE)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NumExtE)
        Me.tab_Empleos.Controls.Add(Me.tbx_Calle_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_CalleE)
        Me.tab_Empleos.Controls.Add(Me.tbx_NombreEmpresa_Empleos)
        Me.tab_Empleos.Controls.Add(Me.Lbl_NomEmpresaE)
        Me.tab_Empleos.Location = New System.Drawing.Point(4, 22)
        Me.tab_Empleos.Name = "tab_Empleos"
        Me.tab_Empleos.Size = New System.Drawing.Size(1002, 673)
        Me.tab_Empleos.TabIndex = 4
        Me.tab_Empleos.Text = "Empleos"
        Me.tab_Empleos.UseVisualStyleBackColor = True
        '
        'btn_Investigacion
        '
        Me.btn_Investigacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Investigacion.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Investigacion.Enabled = False
        Me.btn_Investigacion.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.investigacion
        Me.btn_Investigacion.Location = New System.Drawing.Point(590, 639)
        Me.btn_Investigacion.Name = "btn_Investigacion"
        Me.btn_Investigacion.Size = New System.Drawing.Size(140, 30)
        Me.btn_Investigacion.TabIndex = 73
        Me.btn_Investigacion.Text = "&Investigacion"
        Me.btn_Investigacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Investigacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Investigacion.UseVisualStyleBackColor = True
        '
        'tbx_Colonias_Empleos
        '
        Me.tbx_Colonias_Empleos.Location = New System.Drawing.Point(125, 98)
        Me.tbx_Colonias_Empleos.Name = "tbx_Colonias_Empleos"
        Me.tbx_Colonias_Empleos.Size = New System.Drawing.Size(216, 20)
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
        'tbx_CodigoPostal_Empleos
        '
        Me.tbx_CodigoPostal_Empleos.Control_Siguiente = Me.tbx_Telefono_Empleos
        Me.tbx_CodigoPostal_Empleos.Filtrado = True
        Me.tbx_CodigoPostal_Empleos.Location = New System.Drawing.Point(389, 99)
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
        Me.tbx_Telefono_Empleos.Location = New System.Drawing.Point(349, 151)
        Me.tbx_Telefono_Empleos.MaxLength = 25
        Me.tbx_Telefono_Empleos.Name = "tbx_Telefono_Empleos"
        Me.tbx_Telefono_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_Telefono_Empleos.TabIndex = 9
        Me.tbx_Telefono_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_LatitudEmpleos
        '
        Me.tbx_LatitudEmpleos.Control_Siguiente = Me.tbx_LongitudEmpleos
        Me.tbx_LatitudEmpleos.Filtrado = True
        Me.tbx_LatitudEmpleos.Location = New System.Drawing.Point(349, 176)
        Me.tbx_LatitudEmpleos.MaxLength = 11
        Me.tbx_LatitudEmpleos.Name = "tbx_LatitudEmpleos"
        Me.tbx_LatitudEmpleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_LatitudEmpleos.TabIndex = 11
        Me.tbx_LatitudEmpleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'tbx_LongitudEmpleos
        '
        Me.tbx_LongitudEmpleos.Control_Siguiente = Me.dtp_FechaIngreso_Empleos
        Me.tbx_LongitudEmpleos.Filtrado = True
        Me.tbx_LongitudEmpleos.Location = New System.Drawing.Point(349, 203)
        Me.tbx_LongitudEmpleos.MaxLength = 11
        Me.tbx_LongitudEmpleos.Name = "tbx_LongitudEmpleos"
        Me.tbx_LongitudEmpleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_LongitudEmpleos.TabIndex = 13
        Me.tbx_LongitudEmpleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'dtp_FechaIngreso_Empleos
        '
        Me.dtp_FechaIngreso_Empleos.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaIngreso_Empleos.Location = New System.Drawing.Point(125, 234)
        Me.dtp_FechaIngreso_Empleos.Name = "dtp_FechaIngreso_Empleos"
        Me.dtp_FechaIngreso_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.dtp_FechaIngreso_Empleos.TabIndex = 14
        Me.dtp_FechaIngreso_Empleos.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(92, 50)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 71
        Me.Label7.Text = "Pais"
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
        Me.lsv_PredictivoEmpresas.Location = New System.Drawing.Point(509, 56)
        ListViewColumnSorter6.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter6.SortColumn = 0
        Me.lsv_PredictivoEmpresas.Lvs = ListViewColumnSorter6
        Me.lsv_PredictivoEmpresas.MultiSelect = False
        Me.lsv_PredictivoEmpresas.Name = "lsv_PredictivoEmpresas"
        Me.lsv_PredictivoEmpresas.Row1 = 60
        Me.lsv_PredictivoEmpresas.Row10 = 0
        Me.lsv_PredictivoEmpresas.Row2 = 35
        Me.lsv_PredictivoEmpresas.Row3 = 0
        Me.lsv_PredictivoEmpresas.Row4 = 0
        Me.lsv_PredictivoEmpresas.Row5 = 0
        Me.lsv_PredictivoEmpresas.Row6 = 0
        Me.lsv_PredictivoEmpresas.Row7 = 0
        Me.lsv_PredictivoEmpresas.Row8 = 0
        Me.lsv_PredictivoEmpresas.Row9 = 0
        Me.lsv_PredictivoEmpresas.Size = New System.Drawing.Size(484, 150)
        Me.lsv_PredictivoEmpresas.TabIndex = 18
        Me.lsv_PredictivoEmpresas.UseCompatibleStateImageBehavior = False
        Me.lsv_PredictivoEmpresas.View = System.Windows.Forms.View.Details
        Me.lsv_PredictivoEmpresas.Visible = False
        '
        'lbl_LongitudEmpleos
        '
        Me.lbl_LongitudEmpleos.AutoSize = True
        Me.lbl_LongitudEmpleos.Location = New System.Drawing.Point(296, 206)
        Me.lbl_LongitudEmpleos.Name = "lbl_LongitudEmpleos"
        Me.lbl_LongitudEmpleos.Size = New System.Drawing.Size(48, 13)
        Me.lbl_LongitudEmpleos.TabIndex = 28
        Me.lbl_LongitudEmpleos.Text = "Longitud"
        '
        'lbl_LatitudEmpleos
        '
        Me.lbl_LatitudEmpleos.AutoSize = True
        Me.lbl_LatitudEmpleos.Location = New System.Drawing.Point(304, 179)
        Me.lbl_LatitudEmpleos.Name = "lbl_LatitudEmpleos"
        Me.lbl_LatitudEmpleos.Size = New System.Drawing.Size(39, 13)
        Me.lbl_LatitudEmpleos.TabIndex = 26
        Me.lbl_LatitudEmpleos.Text = "Latitud"
        '
        'tbx_EntreCalle2Empleos
        '
        Me.tbx_EntreCalle2Empleos.Control_Siguiente = Me.tbx_NumeroExt_Empleos
        Me.tbx_EntreCalle2Empleos.Filtrado = False
        Me.tbx_EntreCalle2Empleos.Location = New System.Drawing.Point(349, 125)
        Me.tbx_EntreCalle2Empleos.MaxLength = 100
        Me.tbx_EntreCalle2Empleos.Name = "tbx_EntreCalle2Empleos"
        Me.tbx_EntreCalle2Empleos.Size = New System.Drawing.Size(126, 20)
        Me.tbx_EntreCalle2Empleos.TabIndex = 7
        Me.tbx_EntreCalle2Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroExt_Empleos
        '
        Me.tbx_NumeroExt_Empleos.Control_Siguiente = Me.tbx_NumeroInt_Empleos
        Me.tbx_NumeroExt_Empleos.Filtrado = True
        Me.tbx_NumeroExt_Empleos.Location = New System.Drawing.Point(125, 177)
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
        Me.tbx_NumeroInt_Empleos.Location = New System.Drawing.Point(125, 207)
        Me.tbx_NumeroInt_Empleos.MaxLength = 6
        Me.tbx_NumeroInt_Empleos.Name = "tbx_NumeroInt_Empleos"
        Me.tbx_NumeroInt_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_NumeroInt_Empleos.TabIndex = 12
        Me.tbx_NumeroInt_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'lbl_EntreCalle2Empleos
        '
        Me.lbl_EntreCalle2Empleos.AutoSize = True
        Me.lbl_EntreCalle2Empleos.Location = New System.Drawing.Point(292, 128)
        Me.lbl_EntreCalle2Empleos.Name = "lbl_EntreCalle2Empleos"
        Me.lbl_EntreCalle2Empleos.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2Empleos.TabIndex = 8
        Me.lbl_EntreCalle2Empleos.Text = "Y la Calle"
        '
        'tbx_EntreCalle1Empleos
        '
        Me.tbx_EntreCalle1Empleos.Control_Siguiente = Me.tbx_EntreCalle2Empleos
        Me.tbx_EntreCalle1Empleos.Filtrado = False
        Me.tbx_EntreCalle1Empleos.Location = New System.Drawing.Point(125, 151)
        Me.tbx_EntreCalle1Empleos.MaxLength = 100
        Me.tbx_EntreCalle1Empleos.Name = "tbx_EntreCalle1Empleos"
        Me.tbx_EntreCalle1Empleos.Size = New System.Drawing.Size(152, 20)
        Me.tbx_EntreCalle1Empleos.TabIndex = 8
        Me.tbx_EntreCalle1Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle1Empleos
        '
        Me.lbl_EntreCalle1Empleos.AutoSize = True
        Me.lbl_EntreCalle1Empleos.Location = New System.Drawing.Point(57, 154)
        Me.lbl_EntreCalle1Empleos.Name = "lbl_EntreCalle1Empleos"
        Me.lbl_EntreCalle1Empleos.Size = New System.Drawing.Size(69, 13)
        Me.lbl_EntreCalle1Empleos.TabIndex = 6
        Me.lbl_EntreCalle1Empleos.Text = "Entre la Calle"
        '
        'lbl_EmpresaSeguridad
        '
        Me.lbl_EmpresaSeguridad.AutoSize = True
        Me.lbl_EmpresaSeguridad.Location = New System.Drawing.Point(20, 273)
        Me.lbl_EmpresaSeguridad.Name = "lbl_EmpresaSeguridad"
        Me.lbl_EmpresaSeguridad.Size = New System.Drawing.Size(99, 13)
        Me.lbl_EmpresaSeguridad.TabIndex = 36
        Me.lbl_EmpresaSeguridad.Text = "Empresa Seguridad"
        '
        'gbx_EmpresaSeg
        '
        Me.gbx_EmpresaSeg.Controls.Add(Me.rdb_No_EmpresaSeg)
        Me.gbx_EmpresaSeg.Controls.Add(Me.rdb_Si_EmpresaSeg)
        Me.gbx_EmpresaSeg.Location = New System.Drawing.Point(125, 257)
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
        Me.rdb_No_EmpresaSeg.TabIndex = 1
        Me.rdb_No_EmpresaSeg.Text = "No"
        Me.rdb_No_EmpresaSeg.UseVisualStyleBackColor = True
        '
        'rdb_Si_EmpresaSeg
        '
        Me.rdb_Si_EmpresaSeg.AutoSize = True
        Me.rdb_Si_EmpresaSeg.Location = New System.Drawing.Point(6, 12)
        Me.rdb_Si_EmpresaSeg.Name = "rdb_Si_EmpresaSeg"
        Me.rdb_Si_EmpresaSeg.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_EmpresaSeg.TabIndex = 0
        Me.rdb_Si_EmpresaSeg.Text = "Si"
        Me.rdb_Si_EmpresaSeg.UseVisualStyleBackColor = True
        '
        'lbl_PorteArmas
        '
        Me.lbl_PorteArmas.AutoSize = True
        Me.lbl_PorteArmas.Location = New System.Drawing.Point(279, 273)
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
        Me.gbx_PorteArmas.Location = New System.Drawing.Point(349, 257)
        Me.gbx_PorteArmas.Name = "gbx_PorteArmas"
        Me.gbx_PorteArmas.Size = New System.Drawing.Size(86, 34)
        Me.gbx_PorteArmas.TabIndex = 40
        Me.gbx_PorteArmas.TabStop = False
        '
        'rdb_No_PorteArmas
        '
        Me.rdb_No_PorteArmas.AutoSize = True
        Me.rdb_No_PorteArmas.Location = New System.Drawing.Point(44, 12)
        Me.rdb_No_PorteArmas.Name = "rdb_No_PorteArmas"
        Me.rdb_No_PorteArmas.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_PorteArmas.TabIndex = 1
        Me.rdb_No_PorteArmas.Text = "No"
        Me.rdb_No_PorteArmas.UseVisualStyleBackColor = True
        '
        'rdb_Si_PorteArmas
        '
        Me.rdb_Si_PorteArmas.AutoSize = True
        Me.rdb_Si_PorteArmas.Location = New System.Drawing.Point(6, 12)
        Me.rdb_Si_PorteArmas.Name = "rdb_Si_PorteArmas"
        Me.rdb_Si_PorteArmas.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_PorteArmas.TabIndex = 0
        Me.rdb_Si_PorteArmas.Text = "Si"
        Me.rdb_Si_PorteArmas.UseVisualStyleBackColor = True
        '
        'lbl_ColoniaEmpleos
        '
        Me.lbl_ColoniaEmpleos.AutoSize = True
        Me.lbl_ColoniaEmpleos.Location = New System.Drawing.Point(74, 101)
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
        Me.Label79.Location = New System.Drawing.Point(717, 261)
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
        Me.Label12.Location = New System.Drawing.Point(981, 262)
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
        Me.Label72.Location = New System.Drawing.Point(981, 238)
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
        Me.Label126.Location = New System.Drawing.Point(441, 271)
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
        Me.Label71.Location = New System.Drawing.Point(441, 235)
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
        Me.Label125.Location = New System.Drawing.Point(217, 270)
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
        Me.Label70.Location = New System.Drawing.Point(217, 236)
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
        Me.Label65.Location = New System.Drawing.Point(441, 152)
        Me.Label65.Name = "Label65"
        Me.Label65.Size = New System.Drawing.Size(13, 16)
        Me.Label65.TabIndex = 25
        Me.Label65.Text = "*"
        '
        'Label67
        '
        Me.Label67.AutoSize = True
        Me.Label67.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label67.ForeColor = System.Drawing.Color.Red
        Me.Label67.Location = New System.Drawing.Point(481, 71)
        Me.Label67.Name = "Label67"
        Me.Label67.Size = New System.Drawing.Size(13, 16)
        Me.Label67.TabIndex = 19
        Me.Label67.Text = "*"
        '
        'Label66
        '
        Me.Label66.AutoSize = True
        Me.Label66.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label66.ForeColor = System.Drawing.Color.Red
        Me.Label66.Location = New System.Drawing.Point(981, 214)
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
        Me.Label64.Location = New System.Drawing.Point(481, 310)
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
        Me.Label63.Location = New System.Drawing.Point(859, 285)
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
        Me.Label61.Location = New System.Drawing.Point(217, 177)
        Me.Label61.Name = "Label61"
        Me.Label61.Size = New System.Drawing.Size(13, 16)
        Me.Label61.TabIndex = 12
        Me.Label61.Text = "*"
        '
        'Label60
        '
        Me.Label60.AutoSize = True
        Me.Label60.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label60.ForeColor = System.Drawing.Color.Red
        Me.Label60.Location = New System.Drawing.Point(280, 122)
        Me.Label60.Name = "Label60"
        Me.Label60.Size = New System.Drawing.Size(13, 16)
        Me.Label60.TabIndex = 5
        Me.Label60.Text = "*"
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
        Me.cmb_MotivoSeparacion.Location = New System.Drawing.Point(625, 284)
        Me.cmb_MotivoSeparacion.MaxDropDownItems = 20
        Me.cmb_MotivoSeparacion.Name = "cmb_MotivoSeparacion"
        Me.cmb_MotivoSeparacion.Pista = False
        Me.cmb_MotivoSeparacion.Size = New System.Drawing.Size(228, 21)
        Me.cmb_MotivoSeparacion.StoredProcedure = "Cat_MotivosBajaCombo_Get"
        Me.cmb_MotivoSeparacion.Sucursal = False
        Me.cmb_MotivoSeparacion.TabIndex = 23
        Me.cmb_MotivoSeparacion.Tipo = 0
        Me.cmb_MotivoSeparacion.ValueMember = "id_MotivoB"
        '
        'tbx_OtroMotivo
        '
        Me.tbx_OtroMotivo.Control_Siguiente = Me.btn_Agregar_Empleos
        Me.tbx_OtroMotivo.Filtrado = True
        Me.tbx_OtroMotivo.Location = New System.Drawing.Point(625, 310)
        Me.tbx_OtroMotivo.MaxLength = 100
        Me.tbx_OtroMotivo.Name = "tbx_OtroMotivo"
        Me.tbx_OtroMotivo.Size = New System.Drawing.Size(350, 20)
        Me.tbx_OtroMotivo.TabIndex = 24
        Me.tbx_OtroMotivo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'btn_Agregar_Empleos
        '
        Me.btn_Agregar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Empleos.Location = New System.Drawing.Point(625, 336)
        Me.btn_Agregar_Empleos.Name = "btn_Agregar_Empleos"
        Me.btn_Agregar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Empleos.TabIndex = 25
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
        Me.cmb_Ciudades_Empleos.Location = New System.Drawing.Point(125, 71)
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
        Me.dtp_FechaBaja_Empleos.Location = New System.Drawing.Point(349, 232)
        Me.dtp_FechaBaja_Empleos.Name = "dtp_FechaBaja_Empleos"
        Me.dtp_FechaBaja_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.dtp_FechaBaja_Empleos.TabIndex = 15
        Me.dtp_FechaBaja_Empleos.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Lbl_OtroMotE
        '
        Me.Lbl_OtroMotE.AutoSize = True
        Me.Lbl_OtroMotE.Location = New System.Drawing.Point(557, 313)
        Me.Lbl_OtroMotE.Name = "Lbl_OtroMotE"
        Me.Lbl_OtroMotE.Size = New System.Drawing.Size(62, 13)
        Me.Lbl_OtroMotE.TabIndex = 60
        Me.Lbl_OtroMotE.Text = "Otro Motivo"
        '
        'Lbl_MotSepE
        '
        Me.Lbl_MotSepE.AutoSize = True
        Me.Lbl_MotSepE.Location = New System.Drawing.Point(508, 287)
        Me.Lbl_MotSepE.Name = "Lbl_MotSepE"
        Me.Lbl_MotSepE.Size = New System.Drawing.Size(111, 13)
        Me.Lbl_MotSepE.TabIndex = 57
        Me.Lbl_MotSepE.Text = "Motivo de Separación"
        '
        'tbx_SueldoFinal_Empleos
        '
        Me.tbx_SueldoFinal_Empleos.Control_Siguiente = Me.cmb_MotivoSeparacion
        Me.tbx_SueldoFinal_Empleos.Filtrado = True
        Me.tbx_SueldoFinal_Empleos.Location = New System.Drawing.Point(889, 260)
        Me.tbx_SueldoFinal_Empleos.MaxLength = 6
        Me.tbx_SueldoFinal_Empleos.Name = "tbx_SueldoFinal_Empleos"
        Me.tbx_SueldoFinal_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_SueldoFinal_Empleos.TabIndex = 22
        Me.tbx_SueldoFinal_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_SueFinMenE
        '
        Me.Lbl_SueFinMenE.AutoSize = True
        Me.Lbl_SueFinMenE.Location = New System.Drawing.Point(775, 263)
        Me.Lbl_SueFinMenE.Name = "Lbl_SueFinMenE"
        Me.Lbl_SueFinMenE.Size = New System.Drawing.Size(108, 13)
        Me.Lbl_SueFinMenE.TabIndex = 54
        Me.Lbl_SueFinMenE.Text = "Sueldo Final Mensual"
        '
        'tbx_SueldoInicial_Empleos
        '
        Me.tbx_SueldoInicial_Empleos.Control_Siguiente = Me.tbx_SueldoFinal_Empleos
        Me.tbx_SueldoInicial_Empleos.Filtrado = True
        Me.tbx_SueldoInicial_Empleos.Location = New System.Drawing.Point(625, 260)
        Me.tbx_SueldoInicial_Empleos.MaxLength = 6
        Me.tbx_SueldoInicial_Empleos.Name = "tbx_SueldoInicial_Empleos"
        Me.tbx_SueldoInicial_Empleos.Size = New System.Drawing.Size(86, 20)
        Me.tbx_SueldoInicial_Empleos.TabIndex = 21
        Me.tbx_SueldoInicial_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_SueIniMenE
        '
        Me.Lbl_SueIniMenE.AutoSize = True
        Me.Lbl_SueIniMenE.Location = New System.Drawing.Point(506, 263)
        Me.Lbl_SueIniMenE.Name = "Lbl_SueIniMenE"
        Me.Lbl_SueIniMenE.Size = New System.Drawing.Size(113, 13)
        Me.Lbl_SueIniMenE.TabIndex = 51
        Me.Lbl_SueIniMenE.Text = "Sueldo Inicial Mensual"
        '
        'Lbl_TelefonoE
        '
        Me.Lbl_TelefonoE.AutoSize = True
        Me.Lbl_TelefonoE.Location = New System.Drawing.Point(292, 154)
        Me.Lbl_TelefonoE.Name = "Lbl_TelefonoE"
        Me.Lbl_TelefonoE.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_TelefonoE.TabIndex = 23
        Me.Lbl_TelefonoE.Text = "Teléfono"
        '
        'tbx_PuestoJefe_Empleos
        '
        Me.tbx_PuestoJefe_Empleos.Control_Siguiente = Me.tbx_SueldoInicial_Empleos
        Me.tbx_PuestoJefe_Empleos.Filtrado = True
        Me.tbx_PuestoJefe_Empleos.Location = New System.Drawing.Point(625, 236)
        Me.tbx_PuestoJefe_Empleos.MaxLength = 100
        Me.tbx_PuestoJefe_Empleos.Name = "tbx_PuestoJefe_Empleos"
        Me.tbx_PuestoJefe_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_PuestoJefe_Empleos.TabIndex = 20
        Me.tbx_PuestoJefe_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_PuestJefInmE
        '
        Me.Lbl_PuestJefInmE.AutoSize = True
        Me.Lbl_PuestJefInmE.Location = New System.Drawing.Point(507, 239)
        Me.Lbl_PuestJefInmE.Name = "Lbl_PuestJefInmE"
        Me.Lbl_PuestJefInmE.Size = New System.Drawing.Size(112, 13)
        Me.Lbl_PuestJefInmE.TabIndex = 48
        Me.Lbl_PuestJefInmE.Text = "Puesto Jefe Inmediato"
        '
        'tbx_NombreJefe_Empleos
        '
        Me.tbx_NombreJefe_Empleos.Control_Siguiente = Me.tbx_PuestoJefe_Empleos
        Me.tbx_NombreJefe_Empleos.Filtrado = True
        Me.tbx_NombreJefe_Empleos.Location = New System.Drawing.Point(625, 212)
        Me.tbx_NombreJefe_Empleos.MaxLength = 50
        Me.tbx_NombreJefe_Empleos.Name = "tbx_NombreJefe_Empleos"
        Me.tbx_NombreJefe_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_NombreJefe_Empleos.TabIndex = 19
        Me.tbx_NombreJefe_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_NomJefInmE
        '
        Me.Lbl_NomJefInmE.AutoSize = True
        Me.Lbl_NomJefInmE.Location = New System.Drawing.Point(503, 215)
        Me.Lbl_NomJefInmE.Name = "Lbl_NomJefInmE"
        Me.Lbl_NomJefInmE.Size = New System.Drawing.Size(116, 13)
        Me.Lbl_NomJefInmE.TabIndex = 45
        Me.Lbl_NomJefInmE.Text = "Nombre Jefe Inmediato"
        '
        'tbx_Puesto_Empleos
        '
        Me.tbx_Puesto_Empleos.Control_Siguiente = Me.tbx_NombreJefe_Empleos
        Me.tbx_Puesto_Empleos.Filtrado = True
        Me.tbx_Puesto_Empleos.Location = New System.Drawing.Point(125, 310)
        Me.tbx_Puesto_Empleos.MaxLength = 100
        Me.tbx_Puesto_Empleos.Name = "tbx_Puesto_Empleos"
        Me.tbx_Puesto_Empleos.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Puesto_Empleos.TabIndex = 16
        Me.tbx_Puesto_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_PuestoE
        '
        Me.Lbl_PuestoE.AutoSize = True
        Me.Lbl_PuestoE.Location = New System.Drawing.Point(79, 313)
        Me.Lbl_PuestoE.Name = "Lbl_PuestoE"
        Me.Lbl_PuestoE.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoE.TabIndex = 42
        Me.Lbl_PuestoE.Text = "Puesto"
        '
        'lbl_FBaja
        '
        Me.lbl_FBaja.AutoSize = True
        Me.lbl_FBaja.Location = New System.Drawing.Point(282, 236)
        Me.lbl_FBaja.Name = "lbl_FBaja"
        Me.lbl_FBaja.Size = New System.Drawing.Size(61, 13)
        Me.lbl_FBaja.TabIndex = 33
        Me.lbl_FBaja.Text = "Fecha Baja"
        '
        'lbl_FIngreso
        '
        Me.lbl_FIngreso.AutoSize = True
        Me.lbl_FIngreso.Location = New System.Drawing.Point(44, 238)
        Me.lbl_FIngreso.Name = "lbl_FIngreso"
        Me.lbl_FIngreso.Size = New System.Drawing.Size(75, 13)
        Me.lbl_FIngreso.TabIndex = 30
        Me.lbl_FIngreso.Text = "Fecha Ingreso"
        '
        'btn_LimpiarLaborales
        '
        Me.btn_LimpiarLaborales.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Trash16
        Me.btn_LimpiarLaborales.Location = New System.Drawing.Point(509, 20)
        Me.btn_LimpiarLaborales.Name = "btn_LimpiarLaborales"
        Me.btn_LimpiarLaborales.Size = New System.Drawing.Size(140, 30)
        Me.btn_LimpiarLaborales.TabIndex = 17
        Me.btn_LimpiarLaborales.Text = "&Limpiar Todo"
        Me.btn_LimpiarLaborales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LimpiarLaborales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LimpiarLaborales.UseVisualStyleBackColor = True
        '
        'btn_MapaLaborales
        '
        Me.btn_MapaLaborales.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_MapaLaborales.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.MapaMundo
        Me.btn_MapaLaborales.Location = New System.Drawing.Point(441, 639)
        Me.btn_MapaLaborales.Name = "btn_MapaLaborales"
        Me.btn_MapaLaborales.Size = New System.Drawing.Size(140, 30)
        Me.btn_MapaLaborales.TabIndex = 30
        Me.btn_MapaLaborales.Text = "&Ver en Mapa"
        Me.btn_MapaLaborales.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MapaLaborales.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MapaLaborales.UseVisualStyleBackColor = True
        '
        'btn_Borrar_Empleos
        '
        Me.btn_Borrar_Empleos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Empleos.Enabled = False
        Me.btn_Borrar_Empleos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Empleos.Location = New System.Drawing.Point(295, 639)
        Me.btn_Borrar_Empleos.Name = "btn_Borrar_Empleos"
        Me.btn_Borrar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Empleos.TabIndex = 29
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
        Me.btn_Cancelar_Empleos.Location = New System.Drawing.Point(736, 640)
        Me.btn_Cancelar_Empleos.Name = "btn_Cancelar_Empleos"
        Me.btn_Cancelar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Empleos.TabIndex = 31
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
        Me.btn_Modificar_Empleos.Location = New System.Drawing.Point(149, 639)
        Me.btn_Modificar_Empleos.Name = "btn_Modificar_Empleos"
        Me.btn_Modificar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Empleos.TabIndex = 28
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
        Me.btn_Guardar_Empleos.Location = New System.Drawing.Point(3, 639)
        Me.btn_Guardar_Empleos.Name = "btn_Guardar_Empleos"
        Me.btn_Guardar_Empleos.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Empleos.TabIndex = 27
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
        Me.lsv_Empleos.Location = New System.Drawing.Point(3, 372)
        ListViewColumnSorter7.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter7.SortColumn = 0
        Me.lsv_Empleos.Lvs = ListViewColumnSorter7
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
        Me.lsv_Empleos.Size = New System.Drawing.Size(999, 261)
        Me.lsv_Empleos.TabIndex = 26
        Me.lsv_Empleos.UseCompatibleStateImageBehavior = False
        Me.lsv_Empleos.View = System.Windows.Forms.View.Details
        '
        'Lbl_CPE
        '
        Me.Lbl_CPE.AutoSize = True
        Me.Lbl_CPE.Location = New System.Drawing.Point(356, 102)
        Me.Lbl_CPE.Name = "Lbl_CPE"
        Me.Lbl_CPE.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_CPE.TabIndex = 20
        Me.Lbl_CPE.Text = "C.P."
        '
        'Lbl_CiudadE
        '
        Me.Lbl_CiudadE.AutoSize = True
        Me.Lbl_CiudadE.Location = New System.Drawing.Point(79, 71)
        Me.Lbl_CiudadE.Name = "Lbl_CiudadE"
        Me.Lbl_CiudadE.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_CiudadE.TabIndex = 17
        Me.Lbl_CiudadE.Text = "Ciudad"
        '
        'Lbl_NumIntE
        '
        Me.Lbl_NumIntE.AutoSize = True
        Me.Lbl_NumIntE.Location = New System.Drawing.Point(47, 210)
        Me.Lbl_NumIntE.Name = "Lbl_NumIntE"
        Me.Lbl_NumIntE.Size = New System.Drawing.Size(79, 13)
        Me.Lbl_NumIntE.TabIndex = 13
        Me.Lbl_NumIntE.Text = "Número Interior"
        '
        'Lbl_NumExtE
        '
        Me.Lbl_NumExtE.AutoSize = True
        Me.Lbl_NumExtE.Location = New System.Drawing.Point(43, 180)
        Me.Lbl_NumExtE.Name = "Lbl_NumExtE"
        Me.Lbl_NumExtE.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NumExtE.TabIndex = 10
        Me.Lbl_NumExtE.Text = "Número Exterior"
        '
        'tbx_Calle_Empleos
        '
        Me.tbx_Calle_Empleos.Control_Siguiente = Me.tbx_EntreCalle1Empleos
        Me.tbx_Calle_Empleos.Filtrado = True
        Me.tbx_Calle_Empleos.Location = New System.Drawing.Point(125, 125)
        Me.tbx_Calle_Empleos.MaxLength = 50
        Me.tbx_Calle_Empleos.Name = "tbx_Calle_Empleos"
        Me.tbx_Calle_Empleos.Size = New System.Drawing.Size(152, 20)
        Me.tbx_Calle_Empleos.TabIndex = 6
        Me.tbx_Calle_Empleos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_CalleE
        '
        Me.Lbl_CalleE.AutoSize = True
        Me.Lbl_CalleE.Location = New System.Drawing.Point(89, 128)
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
        'Lbl_NomEmpresaE
        '
        Me.Lbl_NomEmpresaE.AutoSize = True
        Me.Lbl_NomEmpresaE.Location = New System.Drawing.Point(31, 23)
        Me.Lbl_NomEmpresaE.Name = "Lbl_NomEmpresaE"
        Me.Lbl_NomEmpresaE.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_NomEmpresaE.TabIndex = 0
        Me.Lbl_NomEmpresaE.Text = "Nombre Empresa"
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
        Me.tab_Referencias.Controls.Add(Me.tbx_Colonia_Referencias)
        Me.tab_Referencias.Controls.Add(Me.cmb_Paises_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Label3)
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
        Me.tab_Referencias.Controls.Add(Me.Lbl_CPR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CiudadR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_NumIntR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_NumExtR)
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
        Me.tab_Referencias.Size = New System.Drawing.Size(1002, 673)
        Me.tab_Referencias.TabIndex = 5
        Me.tab_Referencias.Text = "Referencias"
        Me.tab_Referencias.UseVisualStyleBackColor = True
        '
        'btn_InvestigacionPersonal
        '
        Me.btn_InvestigacionPersonal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_InvestigacionPersonal.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_InvestigacionPersonal.Enabled = False
        Me.btn_InvestigacionPersonal.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.investigacion
        Me.btn_InvestigacionPersonal.Location = New System.Drawing.Point(441, 639)
        Me.btn_InvestigacionPersonal.Name = "btn_InvestigacionPersonal"
        Me.btn_InvestigacionPersonal.Size = New System.Drawing.Size(140, 30)
        Me.btn_InvestigacionPersonal.TabIndex = 351
        Me.btn_InvestigacionPersonal.Text = "&Investigacion"
        Me.btn_InvestigacionPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_InvestigacionPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_InvestigacionPersonal.UseVisualStyleBackColor = True
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.ForeColor = System.Drawing.Color.Red
        Me.Label36.Location = New System.Drawing.Point(493, 75)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(13, 16)
        Me.Label36.TabIndex = 82
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
        Me.Label33.TabIndex = 81
        Me.Label33.Text = "*"
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(266, 74)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(46, 13)
        Me.Label34.TabIndex = 80
        Me.Label34.Text = "Materno"
        Me.Label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(14, 73)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(84, 13)
        Me.Label35.TabIndex = 79
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
        Me.txt_am.Size = New System.Drawing.Size(169, 20)
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
        Me.Label23.Location = New System.Drawing.Point(493, 101)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(13, 16)
        Me.Label23.TabIndex = 78
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
        Me.cmb_ocupacion.Location = New System.Drawing.Point(104, 96)
        Me.cmb_ocupacion.MaxDropDownItems = 20
        Me.cmb_ocupacion.Name = "cmb_ocupacion"
        Me.cmb_ocupacion.Pista = False
        Me.cmb_ocupacion.Size = New System.Drawing.Size(383, 21)
        Me.cmb_ocupacion.StoredProcedure = "Cat_OcupacionRefSSPCombo_Get"
        Me.cmb_ocupacion.Sucursal = False
        Me.cmb_ocupacion.TabIndex = 5
        Me.cmb_ocupacion.Tipo = 0
        Me.cmb_ocupacion.ValueMember = "Id_OcupacionSSP"
        '
        'tbx_Nombre_Referencia
        '
        Me.tbx_Nombre_Referencia.Control_Siguiente = Me.rdb_Masculino_Referencias
        Me.tbx_Nombre_Referencia.Filtrado = True
        Me.tbx_Nombre_Referencia.Location = New System.Drawing.Point(104, 45)
        Me.tbx_Nombre_Referencia.MaxLength = 50
        Me.tbx_Nombre_Referencia.Name = "tbx_Nombre_Referencia"
        Me.tbx_Nombre_Referencia.Size = New System.Drawing.Size(383, 20)
        Me.tbx_Nombre_Referencia.TabIndex = 2
        Me.tbx_Nombre_Referencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'rdb_Masculino_Referencias
        '
        Me.rdb_Masculino_Referencias.AutoSize = True
        Me.rdb_Masculino_Referencias.Location = New System.Drawing.Point(12, 14)
        Me.rdb_Masculino_Referencias.Name = "rdb_Masculino_Referencias"
        Me.rdb_Masculino_Referencias.Size = New System.Drawing.Size(73, 17)
        Me.rdb_Masculino_Referencias.TabIndex = 4
        Me.rdb_Masculino_Referencias.Text = "Masculino"
        Me.rdb_Masculino_Referencias.UseVisualStyleBackColor = True
        '
        'tbx_Colonia_Referencias
        '
        Me.tbx_Colonia_Referencias.Location = New System.Drawing.Point(104, 198)
        Me.tbx_Colonia_Referencias.Name = "tbx_Colonia_Referencias"
        Me.tbx_Colonia_Referencias.Size = New System.Drawing.Size(182, 20)
        Me.tbx_Colonia_Referencias.TabIndex = 9
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
        Me.cmb_Paises_Referencias.Location = New System.Drawing.Point(104, 166)
        Me.cmb_Paises_Referencias.MaxDropDownItems = 20
        Me.cmb_Paises_Referencias.Name = "cmb_Paises_Referencias"
        Me.cmb_Paises_Referencias.Pista = False
        Me.cmb_Paises_Referencias.Size = New System.Drawing.Size(182, 21)
        Me.cmb_Paises_Referencias.StoredProcedure = "Cat_Paises_Get"
        Me.cmb_Paises_Referencias.Sucursal = False
        Me.cmb_Paises_Referencias.TabIndex = 7
        Me.cmb_Paises_Referencias.Tipo = 0
        Me.cmb_Paises_Referencias.ValueMember = "Id_Pais"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 168)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 73
        Me.Label3.Text = "Pais"
        '
        'lbl_Colonia_Referencias
        '
        Me.lbl_Colonia_Referencias.AutoSize = True
        Me.lbl_Colonia_Referencias.Location = New System.Drawing.Point(56, 201)
        Me.lbl_Colonia_Referencias.Name = "lbl_Colonia_Referencias"
        Me.lbl_Colonia_Referencias.Size = New System.Drawing.Size(42, 13)
        Me.lbl_Colonia_Referencias.TabIndex = 20
        Me.lbl_Colonia_Referencias.Text = "Colonia"
        '
        'tbx_EntreCalle2_Referencias
        '
        Me.tbx_EntreCalle2_Referencias.Control_Siguiente = Nothing
        Me.tbx_EntreCalle2_Referencias.Filtrado = False
        Me.tbx_EntreCalle2_Referencias.Location = New System.Drawing.Point(309, 248)
        Me.tbx_EntreCalle2_Referencias.MaxLength = 100
        Me.tbx_EntreCalle2_Referencias.Name = "tbx_EntreCalle2_Referencias"
        Me.tbx_EntreCalle2_Referencias.Size = New System.Drawing.Size(178, 20)
        Me.tbx_EntreCalle2_Referencias.TabIndex = 13
        Me.tbx_EntreCalle2_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle2_Referencias
        '
        Me.lbl_EntreCalle2_Referencias.AutoSize = True
        Me.lbl_EntreCalle2_Referencias.Location = New System.Drawing.Point(252, 251)
        Me.lbl_EntreCalle2_Referencias.Name = "lbl_EntreCalle2_Referencias"
        Me.lbl_EntreCalle2_Referencias.Size = New System.Drawing.Size(51, 13)
        Me.lbl_EntreCalle2_Referencias.TabIndex = 14
        Me.lbl_EntreCalle2_Referencias.Text = "Y la Calle"
        '
        'tbx_EntreCalle1_Referencias
        '
        Me.tbx_EntreCalle1_Referencias.Control_Siguiente = Nothing
        Me.tbx_EntreCalle1_Referencias.Filtrado = False
        Me.tbx_EntreCalle1_Referencias.Location = New System.Drawing.Point(104, 248)
        Me.tbx_EntreCalle1_Referencias.MaxLength = 100
        Me.tbx_EntreCalle1_Referencias.Name = "tbx_EntreCalle1_Referencias"
        Me.tbx_EntreCalle1_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_EntreCalle1_Referencias.TabIndex = 12
        Me.tbx_EntreCalle1_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_EntreCalle1_Referencias
        '
        Me.lbl_EntreCalle1_Referencias.AutoSize = True
        Me.lbl_EntreCalle1_Referencias.Location = New System.Drawing.Point(29, 251)
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
        Me.Label68.Location = New System.Drawing.Point(255, 305)
        Me.Label68.Name = "Label68"
        Me.Label68.Size = New System.Drawing.Size(13, 16)
        Me.Label68.TabIndex = 28
        Me.Label68.Text = "*"
        '
        'tbx_Telefono_Referencias
        '
        Me.tbx_Telefono_Referencias.Control_Siguiente = Me.cmb_Ciudades_Referencias
        Me.tbx_Telefono_Referencias.Filtrado = True
        Me.tbx_Telefono_Referencias.Location = New System.Drawing.Point(104, 298)
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
        Me.cmb_Ciudades_Referencias.Location = New System.Drawing.Point(342, 165)
        Me.cmb_Ciudades_Referencias.MaxDropDownItems = 20
        Me.cmb_Ciudades_Referencias.Name = "cmb_Ciudades_Referencias"
        Me.cmb_Ciudades_Referencias.Pista = False
        Me.cmb_Ciudades_Referencias.Size = New System.Drawing.Size(145, 21)
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
        Me.tbx_CodigoPostal_Referencias.Location = New System.Drawing.Point(342, 198)
        Me.tbx_CodigoPostal_Referencias.MaxLength = 6
        Me.tbx_CodigoPostal_Referencias.Name = "tbx_CodigoPostal_Referencias"
        Me.tbx_CodigoPostal_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_CodigoPostal_Referencias.TabIndex = 10
        Me.tbx_CodigoPostal_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Agregar_Referencias
        '
        Me.btn_Agregar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Referencias.Location = New System.Drawing.Point(342, 298)
        Me.btn_Agregar_Referencias.Name = "btn_Agregar_Referencias"
        Me.btn_Agregar_Referencias.Size = New System.Drawing.Size(112, 29)
        Me.btn_Agregar_Referencias.TabIndex = 17
        Me.btn_Agregar_Referencias.Text = "Agregar"
        Me.btn_Agregar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Referencias.UseVisualStyleBackColor = True
        '
        'lbl_Telefono_Referencias
        '
        Me.lbl_Telefono_Referencias.AutoSize = True
        Me.lbl_Telefono_Referencias.Location = New System.Drawing.Point(49, 301)
        Me.lbl_Telefono_Referencias.Name = "lbl_Telefono_Referencias"
        Me.lbl_Telefono_Referencias.Size = New System.Drawing.Size(49, 13)
        Me.lbl_Telefono_Referencias.TabIndex = 26
        Me.lbl_Telefono_Referencias.Text = "Teléfono"
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label39.ForeColor = System.Drawing.Color.Red
        Me.Label39.Location = New System.Drawing.Point(292, 140)
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
        Me.Label38.Location = New System.Drawing.Point(493, 46)
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
        Me.btn_Borrar_Referencias.Location = New System.Drawing.Point(295, 639)
        Me.btn_Borrar_Referencias.Name = "btn_Borrar_Referencias"
        Me.btn_Borrar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Referencias.TabIndex = 21
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
        Me.btn_Cancelar_Referencias.Location = New System.Drawing.Point(587, 639)
        Me.btn_Cancelar_Referencias.Name = "btn_Cancelar_Referencias"
        Me.btn_Cancelar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Referencias.TabIndex = 22
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
        Me.btn_Modificar_Referencias.Location = New System.Drawing.Point(149, 639)
        Me.btn_Modificar_Referencias.Name = "btn_Modificar_Referencias"
        Me.btn_Modificar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Referencias.TabIndex = 20
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
        Me.btn_Guardar_Referencias.Location = New System.Drawing.Point(3, 639)
        Me.btn_Guardar_Referencias.Name = "btn_Guardar_Referencias"
        Me.btn_Guardar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Referencias.TabIndex = 19
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
        Me.lsv_Referencias.Location = New System.Drawing.Point(3, 324)
        ListViewColumnSorter8.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter8.SortColumn = 0
        Me.lsv_Referencias.Lvs = ListViewColumnSorter8
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
        Me.lsv_Referencias.Size = New System.Drawing.Size(994, 302)
        Me.lsv_Referencias.TabIndex = 18
        Me.lsv_Referencias.UseCompatibleStateImageBehavior = False
        Me.lsv_Referencias.View = System.Windows.Forms.View.Details
        '
        'tbx_NumeroInt_Referencias
        '
        Me.tbx_NumeroInt_Referencias.Control_Siguiente = Me.tbx_Telefono_Referencias
        Me.tbx_NumeroInt_Referencias.Filtrado = True
        Me.tbx_NumeroInt_Referencias.Location = New System.Drawing.Point(342, 272)
        Me.tbx_NumeroInt_Referencias.MaxLength = 10
        Me.tbx_NumeroInt_Referencias.Name = "tbx_NumeroInt_Referencias"
        Me.tbx_NumeroInt_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_NumeroInt_Referencias.TabIndex = 15
        Me.tbx_NumeroInt_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_NumeroExt_Referencias
        '
        Me.tbx_NumeroExt_Referencias.Control_Siguiente = Me.tbx_NumeroInt_Referencias
        Me.tbx_NumeroExt_Referencias.Filtrado = True
        Me.tbx_NumeroExt_Referencias.Location = New System.Drawing.Point(104, 272)
        Me.tbx_NumeroExt_Referencias.MaxLength = 10
        Me.tbx_NumeroExt_Referencias.Name = "tbx_NumeroExt_Referencias"
        Me.tbx_NumeroExt_Referencias.Size = New System.Drawing.Size(145, 20)
        Me.tbx_NumeroExt_Referencias.TabIndex = 14
        Me.tbx_NumeroExt_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_CPR
        '
        Me.Lbl_CPR.AutoSize = True
        Me.Lbl_CPR.Location = New System.Drawing.Point(309, 201)
        Me.Lbl_CPR.Name = "Lbl_CPR"
        Me.Lbl_CPR.Size = New System.Drawing.Size(27, 13)
        Me.Lbl_CPR.TabIndex = 24
        Me.Lbl_CPR.Text = "C.P."
        '
        'Lbl_CiudadR
        '
        Me.Lbl_CiudadR.AutoSize = True
        Me.Lbl_CiudadR.Location = New System.Drawing.Point(296, 168)
        Me.Lbl_CiudadR.Name = "Lbl_CiudadR"
        Me.Lbl_CiudadR.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_CiudadR.TabIndex = 22
        Me.Lbl_CiudadR.Text = "Ciudad"
        '
        'Lbl_NumIntR
        '
        Me.Lbl_NumIntR.AutoSize = True
        Me.Lbl_NumIntR.Location = New System.Drawing.Point(252, 275)
        Me.Lbl_NumIntR.Name = "Lbl_NumIntR"
        Me.Lbl_NumIntR.Size = New System.Drawing.Size(78, 13)
        Me.Lbl_NumIntR.TabIndex = 18
        Me.Lbl_NumIntR.Text = "Número interior"
        '
        'Lbl_NumExtR
        '
        Me.Lbl_NumExtR.AutoSize = True
        Me.Lbl_NumExtR.Location = New System.Drawing.Point(16, 275)
        Me.Lbl_NumExtR.Name = "Lbl_NumExtR"
        Me.Lbl_NumExtR.Size = New System.Drawing.Size(82, 13)
        Me.Lbl_NumExtR.TabIndex = 16
        Me.Lbl_NumExtR.Text = "Número Exterior"
        '
        'tbx_Calle_Referencias
        '
        Me.tbx_Calle_Referencias.Control_Siguiente = Me.tbx_NumeroExt_Referencias
        Me.tbx_Calle_Referencias.Filtrado = True
        Me.tbx_Calle_Referencias.Location = New System.Drawing.Point(104, 224)
        Me.tbx_Calle_Referencias.MaxLength = 50
        Me.tbx_Calle_Referencias.Name = "tbx_Calle_Referencias"
        Me.tbx_Calle_Referencias.Size = New System.Drawing.Size(383, 20)
        Me.tbx_Calle_Referencias.TabIndex = 11
        Me.tbx_Calle_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_CalleR
        '
        Me.Lbl_CalleR.AutoSize = True
        Me.Lbl_CalleR.Location = New System.Drawing.Point(68, 227)
        Me.Lbl_CalleR.Name = "Lbl_CalleR"
        Me.Lbl_CalleR.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_CalleR.TabIndex = 10
        Me.Lbl_CalleR.Text = "Calle"
        '
        'tbx_Ocupacion_Referencias
        '
        Me.tbx_Ocupacion_Referencias.Control_Siguiente = Me.tbx_Calle_Referencias
        Me.tbx_Ocupacion_Referencias.Filtrado = True
        Me.tbx_Ocupacion_Referencias.Location = New System.Drawing.Point(544, 74)
        Me.tbx_Ocupacion_Referencias.MaxLength = 50
        Me.tbx_Ocupacion_Referencias.Name = "tbx_Ocupacion_Referencias"
        Me.tbx_Ocupacion_Referencias.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Ocupacion_Referencias.TabIndex = 350
        Me.tbx_Ocupacion_Referencias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        Me.tbx_Ocupacion_Referencias.Visible = False
        '
        'Lbl_OcupacionR
        '
        Me.Lbl_OcupacionR.AutoSize = True
        Me.Lbl_OcupacionR.Location = New System.Drawing.Point(29, 99)
        Me.Lbl_OcupacionR.Name = "Lbl_OcupacionR"
        Me.Lbl_OcupacionR.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_OcupacionR.TabIndex = 8
        Me.Lbl_OcupacionR.Text = "Ocupación"
        '
        'gbx_Genero_Referencias
        '
        Me.gbx_Genero_Referencias.Controls.Add(Me.rdb_Masculino_Referencias)
        Me.gbx_Genero_Referencias.Controls.Add(Me.rdb_Femenino_Referencias)
        Me.gbx_Genero_Referencias.Location = New System.Drawing.Point(104, 126)
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
        Me.rdb_Femenino_Referencias.TabIndex = 6
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
        Me.tab_DatosVarios.Controls.Add(Me.lbl_CantidadSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.Label62)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_UbicacionSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_UbicacionSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_FormaSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.cmb_SeñasParticulares)
        Me.tab_DatosVarios.Controls.Add(Me.lbl_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.Label124)
        Me.tab_DatosVarios.Controls.Add(Me.Label119)
        Me.tab_DatosVarios.Controls.Add(Me.Label29)
        Me.tab_DatosVarios.Controls.Add(Me.Label28)
        Me.tab_DatosVarios.Controls.Add(Me.Lbl_DVEjemplo2)
        Me.tab_DatosVarios.Controls.Add(Me.Lbl_DVEjemplo)
        Me.tab_DatosVarios.Controls.Add(Me.btn_refionesSSP)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Borrar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Cancelar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Modificar_DatosVarios)
        Me.tab_DatosVarios.Controls.Add(Me.btn_Agregar_Señas)
        Me.tab_DatosVarios.Controls.Add(Me.lsv_SeñasParticulares)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_CantidadSeñas)
        Me.tab_DatosVarios.Controls.Add(Me.tbx_FormaSeñas)
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
        Me.tab_DatosVarios.Size = New System.Drawing.Size(1002, 673)
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
        Me.cmb_cantidad.Location = New System.Drawing.Point(184, 391)
        Me.cmb_cantidad.MaxDropDownItems = 20
        Me.cmb_cantidad.Name = "cmb_cantidad"
        Me.cmb_cantidad.Size = New System.Drawing.Size(228, 21)
        Me.cmb_cantidad.TabIndex = 154
        Me.cmb_cantidad.ValueMember = "value"
        '
        'cmb_region
        '
        Me.cmb_region.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_region.DisplayMember = "display"
        Me.cmb_region.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_region.FormattingEnabled = True
        Me.cmb_region.Location = New System.Drawing.Point(184, 363)
        Me.cmb_region.MaxDropDownItems = 20
        Me.cmb_region.Name = "cmb_region"
        Me.cmb_region.Size = New System.Drawing.Size(86, 21)
        Me.cmb_region.TabIndex = 152
        Me.cmb_region.ValueMember = "value"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Red
        Me.Label32.Location = New System.Drawing.Point(418, 392)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(13, 16)
        Me.Label32.TabIndex = 151
        Me.Label32.Text = "*"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Red
        Me.Label31.Location = New System.Drawing.Point(418, 310)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(13, 16)
        Me.Label31.TabIndex = 150
        Me.Label31.Text = "*"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Red
        Me.Label27.Location = New System.Drawing.Point(276, 364)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(13, 16)
        Me.Label27.TabIndex = 149
        Me.Label27.Text = "*"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(137, 364)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(41, 13)
        Me.Label25.TabIndex = 147
        Me.Label25.Text = "Region"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(142, 366)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(0, 13)
        Me.Label26.TabIndex = 148
        '
        'cmb_vista
        '
        Me.cmb_vista.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_vista.DisplayMember = "display"
        Me.cmb_vista.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_vista.FormattingEnabled = True
        Me.cmb_vista.Location = New System.Drawing.Point(184, 309)
        Me.cmb_vista.MaxDropDownItems = 20
        Me.cmb_vista.Name = "cmb_vista"
        Me.cmb_vista.Size = New System.Drawing.Size(228, 21)
        Me.cmb_vista.TabIndex = 146
        Me.cmb_vista.ValueMember = "value"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(149, 312)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(30, 13)
        Me.Label24.TabIndex = 145
        Me.Label24.Text = "Vista"
        '
        'cmb_lado
        '
        Me.cmb_lado.Control_Siguiente = Me.cmb_EstadoCivil
        Me.cmb_lado.DisplayMember = "display"
        Me.cmb_lado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_lado.FormattingEnabled = True
        Me.cmb_lado.Location = New System.Drawing.Point(184, 336)
        Me.cmb_lado.MaxDropDownItems = 20
        Me.cmb_lado.Name = "cmb_lado"
        Me.cmb_lado.Size = New System.Drawing.Size(228, 21)
        Me.cmb_lado.TabIndex = 144
        Me.cmb_lado.ValueMember = "value"
        '
        'Label153
        '
        Me.Label153.AutoSize = True
        Me.Label153.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label153.ForeColor = System.Drawing.Color.Red
        Me.Label153.Location = New System.Drawing.Point(418, 341)
        Me.Label153.Name = "Label153"
        Me.Label153.Size = New System.Drawing.Size(13, 16)
        Me.Label153.TabIndex = 143
        Me.Label153.Text = "*"
        '
        'Label152
        '
        Me.Label152.AutoSize = True
        Me.Label152.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label152.ForeColor = System.Drawing.Color.Red
        Me.Label152.Location = New System.Drawing.Point(540, 416)
        Me.Label152.Name = "Label152"
        Me.Label152.Size = New System.Drawing.Size(13, 16)
        Me.Label152.TabIndex = 142
        Me.Label152.Text = "*"
        '
        'Label76
        '
        Me.Label76.AutoSize = True
        Me.Label76.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label76.ForeColor = System.Drawing.Color.Red
        Me.Label76.Location = New System.Drawing.Point(418, 285)
        Me.Label76.Name = "Label76"
        Me.Label76.Size = New System.Drawing.Size(13, 16)
        Me.Label76.TabIndex = 141
        Me.Label76.Text = "*"
        '
        'tbx_Comentarios_Señas
        '
        Me.tbx_Comentarios_Señas.Control_Siguiente = Me.btn_Agregar_Señas
        Me.tbx_Comentarios_Señas.Filtrado = True
        Me.tbx_Comentarios_Señas.Location = New System.Drawing.Point(184, 440)
        Me.tbx_Comentarios_Señas.MaxLength = 50
        Me.tbx_Comentarios_Señas.Name = "tbx_Comentarios_Señas"
        Me.tbx_Comentarios_Señas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Comentarios_Señas.TabIndex = 134
        Me.tbx_Comentarios_Señas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'btn_Agregar_Señas
        '
        Me.btn_Agregar_Señas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_Agregar_Señas.Location = New System.Drawing.Point(564, 427)
        Me.btn_Agregar_Señas.Name = "btn_Agregar_Señas"
        Me.btn_Agregar_Señas.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar_Señas.TabIndex = 20
        Me.btn_Agregar_Señas.Text = "Agregar"
        Me.btn_Agregar_Señas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar_Señas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar_Señas.UseVisualStyleBackColor = True
        '
        'lbl_Comentarios_Señas
        '
        Me.lbl_Comentarios_Señas.AutoSize = True
        Me.lbl_Comentarios_Señas.Location = New System.Drawing.Point(114, 443)
        Me.lbl_Comentarios_Señas.Name = "lbl_Comentarios_Señas"
        Me.lbl_Comentarios_Señas.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Comentarios_Señas.TabIndex = 138
        Me.lbl_Comentarios_Señas.Text = "Comentarios"
        '
        'lbl_CantidadSeñas
        '
        Me.lbl_CantidadSeñas.AutoSize = True
        Me.lbl_CantidadSeñas.Location = New System.Drawing.Point(129, 394)
        Me.lbl_CantidadSeñas.Name = "lbl_CantidadSeñas"
        Me.lbl_CantidadSeñas.Size = New System.Drawing.Size(49, 13)
        Me.lbl_CantidadSeñas.TabIndex = 139
        Me.lbl_CantidadSeñas.Text = "Cantidad"
        '
        'Label62
        '
        Me.Label62.AutoSize = True
        Me.Label62.Location = New System.Drawing.Point(142, 396)
        Me.Label62.Name = "Label62"
        Me.Label62.Size = New System.Drawing.Size(0, 13)
        Me.Label62.TabIndex = 140
        '
        'lbl_UbicacionSeñas
        '
        Me.lbl_UbicacionSeñas.AutoSize = True
        Me.lbl_UbicacionSeñas.Location = New System.Drawing.Point(147, 341)
        Me.lbl_UbicacionSeñas.Name = "lbl_UbicacionSeñas"
        Me.lbl_UbicacionSeñas.Size = New System.Drawing.Size(31, 13)
        Me.lbl_UbicacionSeñas.TabIndex = 137
        Me.lbl_UbicacionSeñas.Text = "Lado"
        '
        'tbx_UbicacionSeñas
        '
        Me.tbx_UbicacionSeñas.Control_Siguiente = Nothing
        Me.tbx_UbicacionSeñas.Filtrado = True
        Me.tbx_UbicacionSeñas.Location = New System.Drawing.Point(484, 312)
        Me.tbx_UbicacionSeñas.MaxLength = 50
        Me.tbx_UbicacionSeñas.Name = "tbx_UbicacionSeñas"
        Me.tbx_UbicacionSeñas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_UbicacionSeñas.TabIndex = 133
        Me.tbx_UbicacionSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'lbl_FormaSeñas
        '
        Me.lbl_FormaSeñas.AutoSize = True
        Me.lbl_FormaSeñas.Location = New System.Drawing.Point(142, 418)
        Me.lbl_FormaSeñas.Name = "lbl_FormaSeñas"
        Me.lbl_FormaSeñas.Size = New System.Drawing.Size(36, 13)
        Me.lbl_FormaSeñas.TabIndex = 136
        Me.lbl_FormaSeñas.Text = "Forma"
        '
        'cmb_SeñasParticulares
        '
        Me.cmb_SeñasParticulares.Clave = Nothing
        Me.cmb_SeñasParticulares.Control_Siguiente = Me.tbx_UbicacionSeñas
        Me.cmb_SeñasParticulares.DisplayMember = "Descripcion"
        Me.cmb_SeñasParticulares.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_SeñasParticulares.Empresa = False
        Me.cmb_SeñasParticulares.Filtro = Nothing
        Me.cmb_SeñasParticulares.FormattingEnabled = True
        Me.cmb_SeñasParticulares.Location = New System.Drawing.Point(184, 284)
        Me.cmb_SeñasParticulares.MaxDropDownItems = 20
        Me.cmb_SeñasParticulares.Name = "cmb_SeñasParticulares"
        Me.cmb_SeñasParticulares.Pista = False
        Me.cmb_SeñasParticulares.Size = New System.Drawing.Size(228, 21)
        Me.cmb_SeñasParticulares.StoredProcedure = "Cat_TipoSenasCombo_Get"
        Me.cmb_SeñasParticulares.Sucursal = False
        Me.cmb_SeñasParticulares.TabIndex = 132
        Me.cmb_SeñasParticulares.Tipo = 0
        Me.cmb_SeñasParticulares.ValueMember = "Id_TipoSena"
        '
        'lbl_Señas
        '
        Me.lbl_Señas.AutoSize = True
        Me.lbl_Señas.Location = New System.Drawing.Point(107, 287)
        Me.lbl_Señas.Name = "lbl_Señas"
        Me.lbl_Señas.Size = New System.Drawing.Size(71, 13)
        Me.lbl_Señas.TabIndex = 135
        Me.lbl_Señas.Text = "Tipo de señal"
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
        'Lbl_DVEjemplo2
        '
        Me.Lbl_DVEjemplo2.AutoSize = True
        Me.Lbl_DVEjemplo2.Location = New System.Drawing.Point(540, 262)
        Me.Lbl_DVEjemplo2.Name = "Lbl_DVEjemplo2"
        Me.Lbl_DVEjemplo2.Size = New System.Drawing.Size(268, 13)
        Me.Lbl_DVEjemplo2.TabIndex = 30
        Me.Lbl_DVEjemplo2.Text = "(Ejemplo: Computación,75:Carpintería,50;Mecánica,75)"
        '
        'Lbl_DVEjemplo
        '
        Me.Lbl_DVEjemplo.AutoSize = True
        Me.Lbl_DVEjemplo.Location = New System.Drawing.Point(540, 214)
        Me.Lbl_DVEjemplo.Name = "Lbl_DVEjemplo"
        Me.Lbl_DVEjemplo.Size = New System.Drawing.Size(219, 13)
        Me.Lbl_DVEjemplo.TabIndex = 25
        Me.Lbl_DVEjemplo.Text = "(Ejemplo: Inglés,100;Francés,50;Japonés,75)"
        '
        'btn_refionesSSP
        '
        Me.btn_refionesSSP.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_refionesSSP.Location = New System.Drawing.Point(295, 364)
        Me.btn_refionesSSP.Name = "btn_refionesSSP"
        Me.btn_refionesSSP.Size = New System.Drawing.Size(117, 21)
        Me.btn_refionesSSP.TabIndex = 153
        Me.btn_refionesSSP.Text = "Ver regiones"
        Me.btn_refionesSSP.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_refionesSSP.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_refionesSSP.UseVisualStyleBackColor = True
        '
        'btn_Borrar_DatosVarios
        '
        Me.btn_Borrar_DatosVarios.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_DatosVarios.Enabled = False
        Me.btn_Borrar_DatosVarios.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_DatosVarios.Location = New System.Drawing.Point(295, 639)
        Me.btn_Borrar_DatosVarios.Name = "btn_Borrar_DatosVarios"
        Me.btn_Borrar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_DatosVarios.TabIndex = 24
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
        Me.btn_Cancelar_DatosVarios.Location = New System.Drawing.Point(441, 639)
        Me.btn_Cancelar_DatosVarios.Name = "btn_Cancelar_DatosVarios"
        Me.btn_Cancelar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_DatosVarios.TabIndex = 25
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
        Me.btn_Modificar_DatosVarios.Location = New System.Drawing.Point(149, 639)
        Me.btn_Modificar_DatosVarios.Name = "btn_Modificar_DatosVarios"
        Me.btn_Modificar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_DatosVarios.TabIndex = 23
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
        Me.lsv_SeñasParticulares.Location = New System.Drawing.Point(3, 463)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.lsv_SeñasParticulares.Lvs = ListViewColumnSorter9
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
        Me.lsv_SeñasParticulares.Size = New System.Drawing.Size(996, 170)
        Me.lsv_SeñasParticulares.TabIndex = 21
        Me.lsv_SeñasParticulares.UseCompatibleStateImageBehavior = False
        Me.lsv_SeñasParticulares.View = System.Windows.Forms.View.Details
        '
        'tbx_CantidadSeñas
        '
        Me.tbx_CantidadSeñas.Control_Siguiente = Me.tbx_Nombres
        Me.tbx_CantidadSeñas.Filtrado = True
        Me.tbx_CantidadSeñas.Location = New System.Drawing.Point(484, 392)
        Me.tbx_CantidadSeñas.MaxLength = 2
        Me.tbx_CantidadSeñas.Name = "tbx_CantidadSeñas"
        Me.tbx_CantidadSeñas.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CantidadSeñas.TabIndex = 19
        Me.tbx_CantidadSeñas.TabStop = False
        Me.tbx_CantidadSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_FormaSeñas
        '
        Me.tbx_FormaSeñas.Control_Siguiente = Nothing
        Me.tbx_FormaSeñas.Filtrado = True
        Me.tbx_FormaSeñas.Location = New System.Drawing.Point(184, 416)
        Me.tbx_FormaSeñas.MaxLength = 50
        Me.tbx_FormaSeñas.Name = "tbx_FormaSeñas"
        Me.tbx_FormaSeñas.Size = New System.Drawing.Size(350, 20)
        Me.tbx_FormaSeñas.TabIndex = 16
        Me.tbx_FormaSeñas.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'tbx_Habilidades
        '
        Me.tbx_Habilidades.Control_Siguiente = Nothing
        Me.tbx_Habilidades.Filtrado = True
        Me.tbx_Habilidades.Location = New System.Drawing.Point(184, 259)
        Me.tbx_Habilidades.MaxLength = 50
        Me.tbx_Habilidades.Name = "tbx_Habilidades"
        Me.tbx_Habilidades.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Habilidades.TabIndex = 14
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
        Me.tbx_ActividadesCulturales.TabIndex = 27
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
        Me.btn_Guardar_DatosVarios.Location = New System.Drawing.Point(3, 639)
        Me.btn_Guardar_DatosVarios.Name = "btn_Guardar_DatosVarios"
        Me.btn_Guardar_DatosVarios.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_DatosVarios.TabIndex = 22
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
        Me.tab_PapeleriaRecibida.Size = New System.Drawing.Size(1002, 673)
        Me.tab_PapeleriaRecibida.TabIndex = 7
        Me.tab_PapeleriaRecibida.Text = "Papeleria Recibida"
        Me.tab_PapeleriaRecibida.UseVisualStyleBackColor = True
        '
        'btn_DoctosCancelar
        '
        Me.btn_DoctosCancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DoctosCancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_DoctosCancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_DoctosCancelar.Location = New System.Drawing.Point(295, 639)
        Me.btn_DoctosCancelar.Name = "btn_DoctosCancelar"
        Me.btn_DoctosCancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_DoctosCancelar.TabIndex = 117
        Me.btn_DoctosCancelar.Text = "&Cancelar"
        Me.btn_DoctosCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_DoctosCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_DoctosCancelar.UseVisualStyleBackColor = True
        '
        'btn_DoctosImportar
        '
        Me.btn_DoctosImportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_DoctosImportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_DoctosImportar.Location = New System.Drawing.Point(149, 639)
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
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.lsv_PapeleriaRecibida.Lvs = ListViewColumnSorter10
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
        Me.lsv_PapeleriaRecibida.Size = New System.Drawing.Size(996, 630)
        Me.lsv_PapeleriaRecibida.TabIndex = 0
        Me.lsv_PapeleriaRecibida.UseCompatibleStateImageBehavior = False
        Me.lsv_PapeleriaRecibida.View = System.Windows.Forms.View.Details
        '
        'btn_Guardar_PapeleriaRecibida
        '
        Me.btn_Guardar_PapeleriaRecibida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_PapeleriaRecibida.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_PapeleriaRecibida.Location = New System.Drawing.Point(3, 639)
        Me.btn_Guardar_PapeleriaRecibida.Name = "btn_Guardar_PapeleriaRecibida"
        Me.btn_Guardar_PapeleriaRecibida.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_PapeleriaRecibida.TabIndex = 1
        Me.btn_Guardar_PapeleriaRecibida.Text = "&Guardar"
        Me.btn_Guardar_PapeleriaRecibida.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_PapeleriaRecibida.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_PapeleriaRecibida.UseVisualStyleBackColor = True
        '
        'tab_DatosSocioEcon
        '
        Me.tab_DatosSocioEcon.Controls.Add(Me.Gbx_DSocio2)
        Me.tab_DatosSocioEcon.Controls.Add(Me.gbx_DSocio)
        Me.tab_DatosSocioEcon.Location = New System.Drawing.Point(4, 22)
        Me.tab_DatosSocioEcon.Name = "tab_DatosSocioEcon"
        Me.tab_DatosSocioEcon.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_DatosSocioEcon.Size = New System.Drawing.Size(1002, 673)
        Me.tab_DatosSocioEcon.TabIndex = 9
        Me.tab_DatosSocioEcon.Text = "D. Socioeconómicos"
        Me.tab_DatosSocioEcon.UseVisualStyleBackColor = True
        '
        'Gbx_DSocio2
        '
        Me.Gbx_DSocio2.Controls.Add(Me.Tbx_DSComentarios)
        Me.Gbx_DSocio2.Controls.Add(Me.Lbl_DSComentarios)
        Me.Gbx_DSocio2.Controls.Add(Me.Btn_DsAgregar)
        Me.Gbx_DSocio2.Controls.Add(Me.Lsv_DS)
        Me.Gbx_DSocio2.Controls.Add(Me.Tbx_DSCantidad)
        Me.Gbx_DSocio2.Controls.Add(Me.Lbl_DSCantidad)
        Me.Gbx_DSocio2.Controls.Add(Me.Label56)
        Me.Gbx_DSocio2.Controls.Add(Me.Tbx_DSUbicacion)
        Me.Gbx_DSocio2.Controls.Add(Me.Lbl_DSUbicacion)
        Me.Gbx_DSocio2.Controls.Add(Me.Tbx_DSForma)
        Me.Gbx_DSocio2.Controls.Add(Me.Lbl_DSForma)
        Me.Gbx_DSocio2.Controls.Add(Me.Cmb_DSSeñasPart)
        Me.Gbx_DSocio2.Controls.Add(Me.Lbl_DSSeñasPart)
        Me.Gbx_DSocio2.Location = New System.Drawing.Point(6, 356)
        Me.Gbx_DSocio2.Name = "Gbx_DSocio2"
        Me.Gbx_DSocio2.Size = New System.Drawing.Size(989, 244)
        Me.Gbx_DSocio2.TabIndex = 1
        Me.Gbx_DSocio2.TabStop = False
        '
        'Tbx_DSComentarios
        '
        Me.Tbx_DSComentarios.Control_Siguiente = Me.Btn_DsAgregar
        Me.Tbx_DSComentarios.Filtrado = True
        Me.Tbx_DSComentarios.Location = New System.Drawing.Point(184, 93)
        Me.Tbx_DSComentarios.MaxLength = 50
        Me.Tbx_DSComentarios.Name = "Tbx_DSComentarios"
        Me.Tbx_DSComentarios.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSComentarios.TabIndex = 19
        Me.Tbx_DSComentarios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Btn_DsAgregar
        '
        Me.Btn_DsAgregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.Btn_DsAgregar.Location = New System.Drawing.Point(545, 83)
        Me.Btn_DsAgregar.Name = "Btn_DsAgregar"
        Me.Btn_DsAgregar.Size = New System.Drawing.Size(140, 33)
        Me.Btn_DsAgregar.TabIndex = 25
        Me.Btn_DsAgregar.Text = "Agregar"
        Me.Btn_DsAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_DsAgregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_DsAgregar.UseVisualStyleBackColor = True
        '
        'Lbl_DSComentarios
        '
        Me.Lbl_DSComentarios.AutoSize = True
        Me.Lbl_DSComentarios.Location = New System.Drawing.Point(113, 96)
        Me.Lbl_DSComentarios.Name = "Lbl_DSComentarios"
        Me.Lbl_DSComentarios.Size = New System.Drawing.Size(65, 13)
        Me.Lbl_DSComentarios.TabIndex = 8
        Me.Lbl_DSComentarios.Text = "Comentarios"
        '
        'Lsv_DS
        '
        Me.Lsv_DS.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lsv_DS.FullRowSelect = True
        Me.Lsv_DS.HideSelection = False
        Me.Lsv_DS.Location = New System.Drawing.Point(3, 119)
        ListViewColumnSorter11.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter11.SortColumn = 0
        Me.Lsv_DS.Lvs = ListViewColumnSorter11
        Me.Lsv_DS.MultiSelect = False
        Me.Lsv_DS.Name = "Lsv_DS"
        Me.Lsv_DS.Row1 = 15
        Me.Lsv_DS.Row10 = 0
        Me.Lsv_DS.Row2 = 15
        Me.Lsv_DS.Row3 = 15
        Me.Lsv_DS.Row4 = 25
        Me.Lsv_DS.Row5 = 0
        Me.Lsv_DS.Row6 = 10
        Me.Lsv_DS.Row7 = 0
        Me.Lsv_DS.Row8 = 0
        Me.Lsv_DS.Row9 = 0
        Me.Lsv_DS.Size = New System.Drawing.Size(980, 119)
        Me.Lsv_DS.TabIndex = 26
        Me.Lsv_DS.UseCompatibleStateImageBehavior = False
        Me.Lsv_DS.View = System.Windows.Forms.View.Details
        '
        'Tbx_DSCantidad
        '
        Me.Tbx_DSCantidad.Control_Siguiente = Me.tbx_Nombres
        Me.Tbx_DSCantidad.Filtrado = True
        Me.Tbx_DSCantidad.Location = New System.Drawing.Point(484, 15)
        Me.Tbx_DSCantidad.MaxLength = 2
        Me.Tbx_DSCantidad.Name = "Tbx_DSCantidad"
        Me.Tbx_DSCantidad.Size = New System.Drawing.Size(50, 20)
        Me.Tbx_DSCantidad.TabIndex = 16
        Me.Tbx_DSCantidad.TabStop = False
        Me.Tbx_DSCantidad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSCantidad
        '
        Me.Lbl_DSCantidad.AutoSize = True
        Me.Lbl_DSCantidad.Location = New System.Drawing.Point(429, 18)
        Me.Lbl_DSCantidad.Name = "Lbl_DSCantidad"
        Me.Lbl_DSCantidad.Size = New System.Drawing.Size(49, 13)
        Me.Lbl_DSCantidad.TabIndex = 2
        Me.Lbl_DSCantidad.Text = "Cantidad"
        '
        'Label56
        '
        Me.Label56.AutoSize = True
        Me.Label56.Location = New System.Drawing.Point(142, 122)
        Me.Label56.Name = "Label56"
        Me.Label56.Size = New System.Drawing.Size(0, 13)
        Me.Label56.TabIndex = 12
        '
        'Tbx_DSUbicacion
        '
        Me.Tbx_DSUbicacion.Control_Siguiente = Me.Tbx_DSComentarios
        Me.Tbx_DSUbicacion.Filtrado = True
        Me.Tbx_DSUbicacion.Location = New System.Drawing.Point(184, 67)
        Me.Tbx_DSUbicacion.MaxLength = 50
        Me.Tbx_DSUbicacion.Name = "Tbx_DSUbicacion"
        Me.Tbx_DSUbicacion.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSUbicacion.TabIndex = 18
        Me.Tbx_DSUbicacion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_DSUbicacion
        '
        Me.Lbl_DSUbicacion.AutoSize = True
        Me.Lbl_DSUbicacion.Location = New System.Drawing.Point(123, 70)
        Me.Lbl_DSUbicacion.Name = "Lbl_DSUbicacion"
        Me.Lbl_DSUbicacion.Size = New System.Drawing.Size(55, 13)
        Me.Lbl_DSUbicacion.TabIndex = 6
        Me.Lbl_DSUbicacion.Text = "Ubicación"
        '
        'Tbx_DSForma
        '
        Me.Tbx_DSForma.Control_Siguiente = Me.Tbx_DSUbicacion
        Me.Tbx_DSForma.Filtrado = True
        Me.Tbx_DSForma.Location = New System.Drawing.Point(184, 41)
        Me.Tbx_DSForma.MaxLength = 50
        Me.Tbx_DSForma.Name = "Tbx_DSForma"
        Me.Tbx_DSForma.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSForma.TabIndex = 17
        Me.Tbx_DSForma.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_DSForma
        '
        Me.Lbl_DSForma.AutoSize = True
        Me.Lbl_DSForma.Location = New System.Drawing.Point(142, 44)
        Me.Lbl_DSForma.Name = "Lbl_DSForma"
        Me.Lbl_DSForma.Size = New System.Drawing.Size(36, 13)
        Me.Lbl_DSForma.TabIndex = 4
        Me.Lbl_DSForma.Text = "Forma"
        '
        'Cmb_DSSeñasPart
        '
        Me.Cmb_DSSeñasPart.Clave = Nothing
        Me.Cmb_DSSeñasPart.Control_Siguiente = Me.Tbx_DSForma
        Me.Cmb_DSSeñasPart.DisplayMember = "Descripcion"
        Me.Cmb_DSSeñasPart.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_DSSeñasPart.Empresa = False
        Me.Cmb_DSSeñasPart.Filtro = Nothing
        Me.Cmb_DSSeñasPart.FormattingEnabled = True
        Me.Cmb_DSSeñasPart.Location = New System.Drawing.Point(184, 14)
        Me.Cmb_DSSeñasPart.MaxDropDownItems = 20
        Me.Cmb_DSSeñasPart.Name = "Cmb_DSSeñasPart"
        Me.Cmb_DSSeñasPart.Pista = False
        Me.Cmb_DSSeñasPart.Size = New System.Drawing.Size(228, 21)
        Me.Cmb_DSSeñasPart.StoredProcedure = "Cat_TipoSenasCombo_Get"
        Me.Cmb_DSSeñasPart.Sucursal = False
        Me.Cmb_DSSeñasPart.TabIndex = 15
        Me.Cmb_DSSeñasPart.Tipo = 0
        Me.Cmb_DSSeñasPart.ValueMember = "Id_TipoSena"
        '
        'Lbl_DSSeñasPart
        '
        Me.Lbl_DSSeñasPart.AutoSize = True
        Me.Lbl_DSSeñasPart.Location = New System.Drawing.Point(84, 17)
        Me.Lbl_DSSeñasPart.Name = "Lbl_DSSeñasPart"
        Me.Lbl_DSSeñasPart.Size = New System.Drawing.Size(95, 13)
        Me.Lbl_DSSeñasPart.TabIndex = 0
        Me.Lbl_DSSeñasPart.Text = "Señas Particulares"
        '
        'gbx_DSocio
        '
        Me.gbx_DSocio.Controls.Add(Me.Gbx_Idioma)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DsEjemplo2)
        Me.gbx_DSocio.Controls.Add(Me.Gbx_AfiliacionAgrupacion)
        Me.gbx_DSocio.Controls.Add(Me.Label122)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSHabApidom)
        Me.gbx_DSocio.Controls.Add(Me.Label123)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSHabApiDom)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSValor)
        Me.gbx_DSocio.Controls.Add(Me.Label130)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSEjemplo)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSModelo)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSIdiomasDominio)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSModelo)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSIdiomasDomina)
        Me.gbx_DSocio.Controls.Add(Me.Gbx_Vehiculo)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSVicios)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSVicios)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSValorVive)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSValorVivi)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSPagoMensual)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSPagoMen)
        Me.gbx_DSocio.Controls.Add(Me.Cmb_DsTipoVivi)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSTipoVivienda)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSDescipcion)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSDescipcion)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSGastFamMens)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSGasFamMen)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DSIngAdi)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DsIngFamMen)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSIngAdi)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSIngFamMen)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSViveFam)
        Me.gbx_DSocio.Controls.Add(Me.Gbx_ViveFam)
        Me.gbx_DSocio.Controls.Add(Me.Tbx_DsCantHijos)
        Me.gbx_DSocio.Controls.Add(Me.Lbl_DSCantHijos)
        Me.gbx_DSocio.Location = New System.Drawing.Point(6, 6)
        Me.gbx_DSocio.Name = "gbx_DSocio"
        Me.gbx_DSocio.Size = New System.Drawing.Size(983, 348)
        Me.gbx_DSocio.TabIndex = 0
        Me.gbx_DSocio.TabStop = False
        '
        'Gbx_Idioma
        '
        Me.Gbx_Idioma.Location = New System.Drawing.Point(540, 154)
        Me.Gbx_Idioma.Name = "Gbx_Idioma"
        Me.Gbx_Idioma.Size = New System.Drawing.Size(416, 100)
        Me.Gbx_Idioma.TabIndex = 24
        Me.Gbx_Idioma.TabStop = False
        Me.Gbx_Idioma.Text = "Idiomas"
        '
        'Lbl_DsEjemplo2
        '
        Me.Lbl_DsEjemplo2.AutoSize = True
        Me.Lbl_DsEjemplo2.Location = New System.Drawing.Point(181, 322)
        Me.Lbl_DsEjemplo2.Name = "Lbl_DsEjemplo2"
        Me.Lbl_DsEjemplo2.Size = New System.Drawing.Size(268, 13)
        Me.Lbl_DsEjemplo2.TabIndex = 32
        Me.Lbl_DsEjemplo2.Text = "(Ejemplo: Computación,75:Carpintería,50;Mecánica,75)"
        '
        'Gbx_AfiliacionAgrupacion
        '
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Dtp_DSHasta)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Lbl_DSHasta)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Tbx_DsNombre)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Lbl_DSNombre)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Dtp_DSDesde)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Lbl_DSDesde)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Cmb_DSTipo)
        Me.Gbx_AfiliacionAgrupacion.Controls.Add(Me.Lbl_DSTipo)
        Me.Gbx_AfiliacionAgrupacion.Location = New System.Drawing.Point(540, 23)
        Me.Gbx_AfiliacionAgrupacion.Name = "Gbx_AfiliacionAgrupacion"
        Me.Gbx_AfiliacionAgrupacion.Size = New System.Drawing.Size(416, 106)
        Me.Gbx_AfiliacionAgrupacion.TabIndex = 79
        Me.Gbx_AfiliacionAgrupacion.TabStop = False
        Me.Gbx_AfiliacionAgrupacion.Text = "Afiliación o Agrupación"
        '
        'Dtp_DSHasta
        '
        Me.Dtp_DSHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_DSHasta.Location = New System.Drawing.Point(199, 72)
        Me.Dtp_DSHasta.Name = "Dtp_DSHasta"
        Me.Dtp_DSHasta.Size = New System.Drawing.Size(96, 20)
        Me.Dtp_DSHasta.TabIndex = 23
        Me.Dtp_DSHasta.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Lbl_DSHasta
        '
        Me.Lbl_DSHasta.AutoSize = True
        Me.Lbl_DSHasta.Location = New System.Drawing.Point(158, 76)
        Me.Lbl_DSHasta.Name = "Lbl_DSHasta"
        Me.Lbl_DSHasta.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_DSHasta.TabIndex = 104
        Me.Lbl_DSHasta.Text = "Hasta"
        '
        'Tbx_DsNombre
        '
        Me.Tbx_DsNombre.Control_Siguiente = Nothing
        Me.Tbx_DsNombre.Filtrado = True
        Me.Tbx_DsNombre.Location = New System.Drawing.Point(56, 19)
        Me.Tbx_DsNombre.MaxLength = 50
        Me.Tbx_DsNombre.Name = "Tbx_DsNombre"
        Me.Tbx_DsNombre.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DsNombre.TabIndex = 20
        Me.Tbx_DsNombre.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_DSNombre
        '
        Me.Lbl_DSNombre.AutoSize = True
        Me.Lbl_DSNombre.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_DSNombre.Name = "Lbl_DSNombre"
        Me.Lbl_DSNombre.Size = New System.Drawing.Size(44, 13)
        Me.Lbl_DSNombre.TabIndex = 69
        Me.Lbl_DSNombre.Text = "Nombre"
        '
        'Dtp_DSDesde
        '
        Me.Dtp_DSDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Dtp_DSDesde.Location = New System.Drawing.Point(56, 72)
        Me.Dtp_DSDesde.Name = "Dtp_DSDesde"
        Me.Dtp_DSDesde.Size = New System.Drawing.Size(96, 20)
        Me.Dtp_DSDesde.TabIndex = 22
        Me.Dtp_DSDesde.Value = New Date(1900, 1, 1, 0, 0, 0, 0)
        '
        'Lbl_DSDesde
        '
        Me.Lbl_DSDesde.AutoSize = True
        Me.Lbl_DSDesde.Location = New System.Drawing.Point(12, 76)
        Me.Lbl_DSDesde.Name = "Lbl_DSDesde"
        Me.Lbl_DSDesde.Size = New System.Drawing.Size(38, 13)
        Me.Lbl_DSDesde.TabIndex = 103
        Me.Lbl_DSDesde.Text = "Desde"
        '
        'Cmb_DSTipo
        '
        Me.Cmb_DSTipo.Clave = Nothing
        Me.Cmb_DSTipo.Control_Siguiente = Nothing
        Me.Cmb_DSTipo.DisplayMember = "Descripcion"
        Me.Cmb_DSTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_DSTipo.Empresa = False
        Me.Cmb_DSTipo.Filtro = Nothing
        Me.Cmb_DSTipo.FormattingEnabled = True
        Me.Cmb_DSTipo.Location = New System.Drawing.Point(56, 45)
        Me.Cmb_DSTipo.MaxDropDownItems = 20
        Me.Cmb_DSTipo.Name = "Cmb_DSTipo"
        Me.Cmb_DSTipo.Pista = False
        Me.Cmb_DSTipo.Size = New System.Drawing.Size(228, 21)
        Me.Cmb_DSTipo.StoredProcedure = "Cat_TipoViviendaCombo_Get"
        Me.Cmb_DSTipo.Sucursal = False
        Me.Cmb_DSTipo.TabIndex = 21
        Me.Cmb_DSTipo.Tipo = 0
        Me.Cmb_DSTipo.ValueMember = "Id_TipoVivienda"
        '
        'Lbl_DSTipo
        '
        Me.Lbl_DSTipo.AutoSize = True
        Me.Lbl_DSTipo.Location = New System.Drawing.Point(22, 48)
        Me.Lbl_DSTipo.Name = "Lbl_DSTipo"
        Me.Lbl_DSTipo.Size = New System.Drawing.Size(28, 13)
        Me.Lbl_DSTipo.TabIndex = 55
        Me.Lbl_DSTipo.Text = "Tipo"
        '
        'Label122
        '
        Me.Label122.AutoSize = True
        Me.Label122.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label122.ForeColor = System.Drawing.Color.Red
        Me.Label122.Location = New System.Drawing.Point(418, 128)
        Me.Label122.Name = "Label122"
        Me.Label122.Size = New System.Drawing.Size(13, 16)
        Me.Label122.TabIndex = 82
        Me.Label122.Text = "*"
        '
        'Tbx_DSHabApidom
        '
        Me.Tbx_DSHabApidom.Control_Siguiente = Nothing
        Me.Tbx_DSHabApidom.Filtrado = True
        Me.Tbx_DSHabApidom.Location = New System.Drawing.Point(184, 299)
        Me.Tbx_DSHabApidom.MaxLength = 50
        Me.Tbx_DSHabApidom.Name = "Tbx_DSHabApidom"
        Me.Tbx_DSHabApidom.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSHabApidom.TabIndex = 14
        Me.Tbx_DSHabApidom.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Label123
        '
        Me.Label123.AutoSize = True
        Me.Label123.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label123.ForeColor = System.Drawing.Color.Red
        Me.Label123.Location = New System.Drawing.Point(276, 50)
        Me.Label123.Name = "Label123"
        Me.Label123.Size = New System.Drawing.Size(13, 16)
        Me.Label123.TabIndex = 73
        Me.Label123.Text = "*"
        '
        'Lbl_DSHabApiDom
        '
        Me.Lbl_DSHabApiDom.AutoSize = True
        Me.Lbl_DSHabApiDom.Location = New System.Drawing.Point(9, 302)
        Me.Lbl_DSHabApiDom.Name = "Lbl_DSHabApiDom"
        Me.Lbl_DSHabApiDom.Size = New System.Drawing.Size(169, 13)
        Me.Lbl_DSHabApiDom.TabIndex = 30
        Me.Lbl_DSHabApiDom.Text = "Habilidades o Aptitudes/%Dominio"
        '
        'Tbx_DSValor
        '
        Me.Tbx_DSValor.Control_Siguiente = Nothing
        Me.Tbx_DSValor.Filtrado = True
        Me.Tbx_DSValor.Location = New System.Drawing.Point(448, 206)
        Me.Tbx_DSValor.MaxLength = 10
        Me.Tbx_DSValor.Name = "Tbx_DSValor"
        Me.Tbx_DSValor.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSValor.TabIndex = 11
        Me.Tbx_DSValor.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Label130
        '
        Me.Label130.AutoSize = True
        Me.Label130.Location = New System.Drawing.Point(365, 209)
        Me.Label130.Name = "Label130"
        Me.Label130.Size = New System.Drawing.Size(77, 13)
        Me.Label130.TabIndex = 90
        Me.Label130.Text = "Valor Vehículo"
        '
        'Lbl_DSEjemplo
        '
        Me.Lbl_DSEjemplo.AutoSize = True
        Me.Lbl_DSEjemplo.Location = New System.Drawing.Point(181, 283)
        Me.Lbl_DSEjemplo.Name = "Lbl_DSEjemplo"
        Me.Lbl_DSEjemplo.Size = New System.Drawing.Size(219, 13)
        Me.Lbl_DSEjemplo.TabIndex = 27
        Me.Lbl_DSEjemplo.Text = "(Ejemplo: Inglés,100;Francés,50;Japonés,75)"
        '
        'Tbx_DSModelo
        '
        Me.Tbx_DSModelo.Control_Siguiente = Me.Tbx_DSValor
        Me.Tbx_DSModelo.Filtrado = True
        Me.Tbx_DSModelo.Location = New System.Drawing.Point(448, 180)
        Me.Tbx_DSModelo.MaxLength = 4
        Me.Tbx_DSModelo.Name = "Tbx_DSModelo"
        Me.Tbx_DSModelo.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSModelo.TabIndex = 10
        Me.Tbx_DSModelo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tbx_DSIdiomasDominio
        '
        Me.Tbx_DSIdiomasDominio.Control_Siguiente = Me.tbx_ActividadesCulturales
        Me.Tbx_DSIdiomasDominio.Filtrado = True
        Me.Tbx_DSIdiomasDominio.Location = New System.Drawing.Point(184, 260)
        Me.Tbx_DSIdiomasDominio.MaxLength = 50
        Me.Tbx_DSIdiomasDominio.Name = "Tbx_DSIdiomasDominio"
        Me.Tbx_DSIdiomasDominio.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSIdiomasDominio.TabIndex = 13
        Me.Tbx_DSIdiomasDominio.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_DSModelo
        '
        Me.Lbl_DSModelo.AutoSize = True
        Me.Lbl_DSModelo.Location = New System.Drawing.Point(372, 183)
        Me.Lbl_DSModelo.Name = "Lbl_DSModelo"
        Me.Lbl_DSModelo.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_DSModelo.TabIndex = 88
        Me.Lbl_DSModelo.Text = "Modelo (Año)"
        '
        'Lbl_DSIdiomasDomina
        '
        Me.Lbl_DSIdiomasDomina.AutoSize = True
        Me.Lbl_DSIdiomasDomina.Location = New System.Drawing.Point(81, 263)
        Me.Lbl_DSIdiomasDomina.Name = "Lbl_DSIdiomasDomina"
        Me.Lbl_DSIdiomasDomina.Size = New System.Drawing.Size(97, 13)
        Me.Lbl_DSIdiomasDomina.TabIndex = 25
        Me.Lbl_DSIdiomasDomina.Text = "Idiomas/ %Dominio"
        '
        'Gbx_Vehiculo
        '
        Me.Gbx_Vehiculo.Controls.Add(Me.RadioButton3)
        Me.Gbx_Vehiculo.Controls.Add(Me.Rdb_DSSi2)
        Me.Gbx_Vehiculo.Location = New System.Drawing.Point(184, 180)
        Me.Gbx_Vehiculo.Name = "Gbx_Vehiculo"
        Me.Gbx_Vehiculo.Size = New System.Drawing.Size(156, 37)
        Me.Gbx_Vehiculo.TabIndex = 87
        Me.Gbx_Vehiculo.TabStop = False
        Me.Gbx_Vehiculo.Text = "Vehículo Propio"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Checked = True
        Me.RadioButton3.Location = New System.Drawing.Point(97, 15)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton3.TabIndex = 8
        Me.RadioButton3.TabStop = True
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'Rdb_DSSi2
        '
        Me.Rdb_DSSi2.AutoSize = True
        Me.Rdb_DSSi2.Location = New System.Drawing.Point(18, 15)
        Me.Rdb_DSSi2.Name = "Rdb_DSSi2"
        Me.Rdb_DSSi2.Size = New System.Drawing.Size(34, 17)
        Me.Rdb_DSSi2.TabIndex = 7
        Me.Rdb_DSSi2.Text = "Si"
        Me.Rdb_DSSi2.UseVisualStyleBackColor = True
        '
        'Tbx_DSVicios
        '
        Me.Tbx_DSVicios.Control_Siguiente = Me.tbx_Idiomas
        Me.Tbx_DSVicios.Filtrado = True
        Me.Tbx_DSVicios.Location = New System.Drawing.Point(184, 232)
        Me.Tbx_DSVicios.MaxLength = 50
        Me.Tbx_DSVicios.Name = "Tbx_DSVicios"
        Me.Tbx_DSVicios.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSVicios.TabIndex = 12
        Me.Tbx_DSVicios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_DSVicios
        '
        Me.Lbl_DSVicios.AutoSize = True
        Me.Lbl_DSVicios.Location = New System.Drawing.Point(143, 235)
        Me.Lbl_DSVicios.Name = "Lbl_DSVicios"
        Me.Lbl_DSVicios.Size = New System.Drawing.Size(35, 13)
        Me.Lbl_DSVicios.TabIndex = 23
        Me.Lbl_DSVicios.Text = "Vicios"
        '
        'Tbx_DSValorVive
        '
        Me.Tbx_DSValorVive.Control_Siguiente = Me.Rdb_DSSi2
        Me.Tbx_DSValorVive.Filtrado = True
        Me.Tbx_DSValorVive.Location = New System.Drawing.Point(448, 154)
        Me.Tbx_DSValorVive.MaxLength = 10
        Me.Tbx_DSValorVive.Name = "Tbx_DSValorVive"
        Me.Tbx_DSValorVive.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSValorVive.TabIndex = 9
        Me.Tbx_DSValorVive.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSValorVivi
        '
        Me.Lbl_DSValorVivi.AutoSize = True
        Me.Lbl_DSValorVivi.Location = New System.Drawing.Point(367, 157)
        Me.Lbl_DSValorVivi.Name = "Lbl_DSValorVivi"
        Me.Lbl_DSValorVivi.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_DSValorVivi.TabIndex = 85
        Me.Lbl_DSValorVivi.Text = "Valor Vivienda"
        '
        'Tbx_DSPagoMensual
        '
        Me.Tbx_DSPagoMensual.Control_Siguiente = Me.Tbx_DSValorVive
        Me.Tbx_DSPagoMensual.Filtrado = True
        Me.Tbx_DSPagoMensual.Location = New System.Drawing.Point(184, 154)
        Me.Tbx_DSPagoMensual.MaxLength = 10
        Me.Tbx_DSPagoMensual.Name = "Tbx_DSPagoMensual"
        Me.Tbx_DSPagoMensual.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSPagoMensual.TabIndex = 7
        Me.Tbx_DSPagoMensual.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSPagoMen
        '
        Me.Lbl_DSPagoMen.AutoSize = True
        Me.Lbl_DSPagoMen.Location = New System.Drawing.Point(103, 157)
        Me.Lbl_DSPagoMen.Name = "Lbl_DSPagoMen"
        Me.Lbl_DSPagoMen.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_DSPagoMen.TabIndex = 83
        Me.Lbl_DSPagoMen.Text = "Pago Mensual"
        '
        'Cmb_DsTipoVivi
        '
        Me.Cmb_DsTipoVivi.Clave = Nothing
        Me.Cmb_DsTipoVivi.Control_Siguiente = Me.Tbx_DSPagoMensual
        Me.Cmb_DsTipoVivi.DisplayMember = "Descripcion"
        Me.Cmb_DsTipoVivi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_DsTipoVivi.Empresa = False
        Me.Cmb_DsTipoVivi.Filtro = Nothing
        Me.Cmb_DsTipoVivi.FormattingEnabled = True
        Me.Cmb_DsTipoVivi.Location = New System.Drawing.Point(184, 127)
        Me.Cmb_DsTipoVivi.MaxDropDownItems = 20
        Me.Cmb_DsTipoVivi.Name = "Cmb_DsTipoVivi"
        Me.Cmb_DsTipoVivi.Pista = False
        Me.Cmb_DsTipoVivi.Size = New System.Drawing.Size(228, 21)
        Me.Cmb_DsTipoVivi.StoredProcedure = "Cat_TipoViviendaCombo_Get"
        Me.Cmb_DsTipoVivi.Sucursal = False
        Me.Cmb_DsTipoVivi.TabIndex = 6
        Me.Cmb_DsTipoVivi.Tipo = 0
        Me.Cmb_DsTipoVivi.ValueMember = "Id_TipoVivienda"
        '
        'Lbl_DSTipoVivienda
        '
        Me.Lbl_DSTipoVivienda.AutoSize = True
        Me.Lbl_DSTipoVivienda.Location = New System.Drawing.Point(106, 130)
        Me.Lbl_DSTipoVivienda.Name = "Lbl_DSTipoVivienda"
        Me.Lbl_DSTipoVivienda.Size = New System.Drawing.Size(72, 13)
        Me.Lbl_DSTipoVivienda.TabIndex = 80
        Me.Lbl_DSTipoVivienda.Text = "Tipo Vivienda"
        '
        'Tbx_DSDescipcion
        '
        Me.Tbx_DSDescipcion.Control_Siguiente = Me.Cmb_DsTipoVivi
        Me.Tbx_DSDescipcion.Filtrado = True
        Me.Tbx_DSDescipcion.Location = New System.Drawing.Point(184, 101)
        Me.Tbx_DSDescipcion.MaxLength = 50
        Me.Tbx_DSDescipcion.Name = "Tbx_DSDescipcion"
        Me.Tbx_DSDescipcion.Size = New System.Drawing.Size(350, 20)
        Me.Tbx_DSDescipcion.TabIndex = 5
        Me.Tbx_DSDescipcion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'Lbl_DSDescipcion
        '
        Me.Lbl_DSDescipcion.AutoSize = True
        Me.Lbl_DSDescipcion.Location = New System.Drawing.Point(115, 104)
        Me.Lbl_DSDescipcion.Name = "Lbl_DSDescipcion"
        Me.Lbl_DSDescipcion.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_DSDescipcion.TabIndex = 78
        Me.Lbl_DSDescipcion.Text = "Descripción"
        '
        'Tbx_DSGastFamMens
        '
        Me.Tbx_DSGastFamMens.Control_Siguiente = Me.Tbx_DSIngAdi
        Me.Tbx_DSGastFamMens.Filtrado = True
        Me.Tbx_DSGastFamMens.Location = New System.Drawing.Point(448, 46)
        Me.Tbx_DSGastFamMens.MaxLength = 10
        Me.Tbx_DSGastFamMens.Name = "Tbx_DSGastFamMens"
        Me.Tbx_DSGastFamMens.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSGastFamMens.TabIndex = 3
        Me.Tbx_DSGastFamMens.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Tbx_DSIngAdi
        '
        Me.Tbx_DSIngAdi.Control_Siguiente = Me.Tbx_DSDescipcion
        Me.Tbx_DSIngAdi.Filtrado = True
        Me.Tbx_DSIngAdi.Location = New System.Drawing.Point(184, 75)
        Me.Tbx_DSIngAdi.MaxLength = 10
        Me.Tbx_DSIngAdi.Name = "Tbx_DSIngAdi"
        Me.Tbx_DSIngAdi.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DSIngAdi.TabIndex = 4
        Me.Tbx_DSIngAdi.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSGasFamMen
        '
        Me.Lbl_DSGasFamMen.AutoSize = True
        Me.Lbl_DSGasFamMen.Location = New System.Drawing.Point(326, 49)
        Me.Lbl_DSGasFamMen.Name = "Lbl_DSGasFamMen"
        Me.Lbl_DSGasFamMen.Size = New System.Drawing.Size(116, 13)
        Me.Lbl_DSGasFamMen.TabIndex = 74
        Me.Lbl_DSGasFamMen.Text = "Gasto Familiar Mensual"
        '
        'Tbx_DsIngFamMen
        '
        Me.Tbx_DsIngFamMen.Control_Siguiente = Me.Tbx_DSGastFamMens
        Me.Tbx_DsIngFamMen.Filtrado = True
        Me.Tbx_DsIngFamMen.Location = New System.Drawing.Point(184, 49)
        Me.Tbx_DsIngFamMen.MaxLength = 10
        Me.Tbx_DsIngFamMen.Name = "Tbx_DsIngFamMen"
        Me.Tbx_DsIngFamMen.Size = New System.Drawing.Size(86, 20)
        Me.Tbx_DsIngFamMen.TabIndex = 2
        Me.Tbx_DsIngFamMen.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSIngAdi
        '
        Me.Lbl_DSIngAdi.AutoSize = True
        Me.Lbl_DSIngAdi.Location = New System.Drawing.Point(91, 78)
        Me.Lbl_DSIngAdi.Name = "Lbl_DSIngAdi"
        Me.Lbl_DSIngAdi.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_DSIngAdi.TabIndex = 76
        Me.Lbl_DSIngAdi.Text = "Ingreso Adicional"
        '
        'Lbl_DSIngFamMen
        '
        Me.Lbl_DSIngFamMen.AutoSize = True
        Me.Lbl_DSIngFamMen.Location = New System.Drawing.Point(55, 52)
        Me.Lbl_DSIngFamMen.Name = "Lbl_DSIngFamMen"
        Me.Lbl_DSIngFamMen.Size = New System.Drawing.Size(123, 13)
        Me.Lbl_DSIngFamMen.TabIndex = 71
        Me.Lbl_DSIngFamMen.Text = "Ingreso Familiar Mensual"
        '
        'Lbl_DSViveFam
        '
        Me.Lbl_DSViveFam.AutoSize = True
        Me.Lbl_DSViveFam.Location = New System.Drawing.Point(80, 23)
        Me.Lbl_DSViveFam.Name = "Lbl_DSViveFam"
        Me.Lbl_DSViveFam.Size = New System.Drawing.Size(98, 13)
        Me.Lbl_DSViveFam.TabIndex = 67
        Me.Lbl_DSViveFam.Text = "Vive con su Familia"
        '
        'Gbx_ViveFam
        '
        Me.Gbx_ViveFam.Controls.Add(Me.Rdb_DSNo)
        Me.Gbx_ViveFam.Controls.Add(Me.Rdb_DSSi)
        Me.Gbx_ViveFam.Location = New System.Drawing.Point(184, 8)
        Me.Gbx_ViveFam.Name = "Gbx_ViveFam"
        Me.Gbx_ViveFam.Size = New System.Drawing.Size(94, 35)
        Me.Gbx_ViveFam.TabIndex = 68
        Me.Gbx_ViveFam.TabStop = False
        '
        'Rdb_DSNo
        '
        Me.Rdb_DSNo.AutoSize = True
        Me.Rdb_DSNo.Location = New System.Drawing.Point(49, 12)
        Me.Rdb_DSNo.Name = "Rdb_DSNo"
        Me.Rdb_DSNo.Size = New System.Drawing.Size(39, 17)
        Me.Rdb_DSNo.TabIndex = 1
        Me.Rdb_DSNo.Text = "No"
        Me.Rdb_DSNo.UseVisualStyleBackColor = True
        '
        'Rdb_DSSi
        '
        Me.Rdb_DSSi.AutoSize = True
        Me.Rdb_DSSi.Checked = True
        Me.Rdb_DSSi.Location = New System.Drawing.Point(6, 12)
        Me.Rdb_DSSi.Name = "Rdb_DSSi"
        Me.Rdb_DSSi.Size = New System.Drawing.Size(34, 17)
        Me.Rdb_DSSi.TabIndex = 0
        Me.Rdb_DSSi.TabStop = True
        Me.Rdb_DSSi.Text = "Si"
        Me.Rdb_DSSi.UseVisualStyleBackColor = True
        '
        'Tbx_DsCantHijos
        '
        Me.Tbx_DsCantHijos.Control_Siguiente = Me.cmb_EstadoCivil
        Me.Tbx_DsCantHijos.Filtrado = True
        Me.Tbx_DsCantHijos.Location = New System.Drawing.Point(448, 20)
        Me.Tbx_DsCantHijos.MaxLength = 2
        Me.Tbx_DsCantHijos.Name = "Tbx_DsCantHijos"
        Me.Tbx_DsCantHijos.Size = New System.Drawing.Size(50, 20)
        Me.Tbx_DsCantHijos.TabIndex = 1
        Me.Tbx_DsCantHijos.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Lbl_DSCantHijos
        '
        Me.Lbl_DSCantHijos.AutoSize = True
        Me.Lbl_DSCantHijos.Location = New System.Drawing.Point(367, 23)
        Me.Lbl_DSCantHijos.Name = "Lbl_DSCantHijos"
        Me.Lbl_DSCantHijos.Size = New System.Drawing.Size(75, 13)
        Me.Lbl_DSCantHijos.TabIndex = 69
        Me.Lbl_DSCantHijos.Text = "Cantidad Hijos"
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button1)
        Me.TabPage1.Controls.Add(Me.btn_EliminarHuellaD)
        Me.TabPage1.Controls.Add(Me.btn_EliminarHuellasIzq)
        Me.TabPage1.Controls.Add(Me.btn_CapturarHuellas)
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Controls.Add(Me.GroupBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1002, 673)
        Me.TabPage1.TabIndex = 13
        Me.TabPage1.Text = "Captura de Huellas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button1.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Button1.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.Button1.Location = New System.Drawing.Point(18, 626)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(140, 30)
        Me.Button1.TabIndex = 38
        Me.Button1.Text = "&Cancelar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btn_EliminarHuellaD
        '
        Me.btn_EliminarHuellaD.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_EliminarHuellaD.Location = New System.Drawing.Point(310, 290)
        Me.btn_EliminarHuellaD.Name = "btn_EliminarHuellaD"
        Me.btn_EliminarHuellaD.Size = New System.Drawing.Size(141, 37)
        Me.btn_EliminarHuellaD.TabIndex = 37
        Me.btn_EliminarHuellaD.Text = "Eliminar"
        Me.btn_EliminarHuellaD.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarHuellaD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_EliminarHuellaD.UseVisualStyleBackColor = True
        '
        'btn_EliminarHuellasIzq
        '
        Me.btn_EliminarHuellasIzq.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_EliminarHuellasIzq.Location = New System.Drawing.Point(50, 290)
        Me.btn_EliminarHuellasIzq.Name = "btn_EliminarHuellasIzq"
        Me.btn_EliminarHuellasIzq.Size = New System.Drawing.Size(141, 37)
        Me.btn_EliminarHuellasIzq.TabIndex = 36
        Me.btn_EliminarHuellasIzq.Text = "Eliminar"
        Me.btn_EliminarHuellasIzq.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_EliminarHuellasIzq.UseVisualStyleBackColor = True
        '
        'btn_CapturarHuellas
        '
        Me.btn_CapturarHuellas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_CapturarHuellas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.huella
        Me.btn_CapturarHuellas.Location = New System.Drawing.Point(50, 24)
        Me.btn_CapturarHuellas.Name = "btn_CapturarHuellas"
        Me.btn_CapturarHuellas.Size = New System.Drawing.Size(123, 63)
        Me.btn_CapturarHuellas.TabIndex = 35
        Me.btn_CapturarHuellas.Text = "Capturar Huellas"
        Me.btn_CapturarHuellas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CapturarHuellas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CapturarHuellas.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.pbx_HuellaDer)
        Me.GroupBox2.Location = New System.Drawing.Point(278, 93)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 191)
        Me.GroupBox2.TabIndex = 34
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Huellas Pulgar Derecho"
        '
        'pbx_HuellaDer
        '
        Me.pbx_HuellaDer.Location = New System.Drawing.Point(32, 30)
        Me.pbx_HuellaDer.Name = "pbx_HuellaDer"
        Me.pbx_HuellaDer.Size = New System.Drawing.Size(141, 141)
        Me.pbx_HuellaDer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_HuellaDer.TabIndex = 0
        Me.pbx_HuellaDer.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.pbx_HuellaIzq)
        Me.GroupBox1.Location = New System.Drawing.Point(18, 93)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(200, 191)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Huellas Pulgar Izquierdo"
        '
        'pbx_HuellaIzq
        '
        Me.pbx_HuellaIzq.Location = New System.Drawing.Point(32, 30)
        Me.pbx_HuellaIzq.Name = "pbx_HuellaIzq"
        Me.pbx_HuellaIzq.Size = New System.Drawing.Size(141, 141)
        Me.pbx_HuellaIzq.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx_HuellaIzq.TabIndex = 0
        Me.pbx_HuellaIzq.TabStop = False
        '
        'frm_EmpleadosP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cancelar_DG
        Me.ClientSize = New System.Drawing.Size(1024, 732)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(1040, 669)
        Me.Name = "frm_EmpleadosP"
        Me.Text = "Catálogo de Prospectos"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.tab_DatosEmpleado.ResumeLayout(False)
        Me.tab_DatosGenerales.ResumeLayout(False)
        Me.tab_DatosGenerales.PerformLayout
        Me.tab_Contacto.ResumeLayout(False)
        Me.tab_Contacto.PerformLayout
        Me.tab_Entrevistas.ResumeLayout(False)
        Me.gbx_Entrevistas.ResumeLayout(False)
        Me.gbx_Entrevista.ResumeLayout(False)
        Me.gbx_Entrevista.PerformLayout
        Me.gbx_Apto.ResumeLayout(False)
        Me.gbx_Apto.PerformLayout
        Me.tab_Foto.ResumeLayout(False)
        Me.gbx_FrenteFormal.ResumeLayout(False)
        CType(Me.pct_FrenteFormal, System.ComponentModel.ISupportInitialize).EndInit
        Me.gbx_FotoProspecto.ResumeLayout(False)
        CType(Me.pct_Frente, System.ComponentModel.ISupportInitialize).EndInit
        Me.tab_RasgosPersonales.ResumeLayout(False)
        Me.gbx_Principales.ResumeLayout(False)
        Me.gbx_Principales.PerformLayout
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
        Me.tab_DatosSocioEcon.ResumeLayout(False)
        Me.Gbx_DSocio2.ResumeLayout(False)
        Me.Gbx_DSocio2.PerformLayout
        Me.gbx_DSocio.ResumeLayout(False)
        Me.gbx_DSocio.PerformLayout
        Me.Gbx_AfiliacionAgrupacion.ResumeLayout(False)
        Me.Gbx_AfiliacionAgrupacion.PerformLayout
        Me.Gbx_Vehiculo.ResumeLayout(False)
        Me.Gbx_Vehiculo.PerformLayout
        Me.Gbx_ViveFam.ResumeLayout(False)
        Me.Gbx_ViveFam.PerformLayout
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.pbx_HuellaDer, System.ComponentModel.ISupportInitialize).EndInit
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.pbx_HuellaIzq, System.ComponentModel.ISupportInitialize).EndInit
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
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents cmb_Departamento_DG As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
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
    Friend WithEvents lbl_Ciudad As System.Windows.Forms.Label
    Friend WithEvents lbl_FBaja As System.Windows.Forms.Label
    Friend WithEvents lbl_FIngreso As System.Windows.Forms.Label
    Friend WithEvents btn_Guardar_Empleos As System.Windows.Forms.Button
    Friend WithEvents lsv_Empleos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_CodigoPostal_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroInt_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroExt_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CPE As System.Windows.Forms.Label
    Friend WithEvents Lbl_CiudadE As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumIntE As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumExtE As System.Windows.Forms.Label
    Friend WithEvents tbx_Calle_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CalleE As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreEmpresa_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NomEmpresaE As System.Windows.Forms.Label
    Friend WithEvents tbx_Puesto_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PuestoE As System.Windows.Forms.Label
    Friend WithEvents tbx_OtroMotivo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_OtroMotE As System.Windows.Forms.Label
    Friend WithEvents Lbl_MotSepE As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoFinal_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_SueFinMenE As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoInicial_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Telefono_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_SueIniMenE As System.Windows.Forms.Label
    Friend WithEvents Lbl_TelefonoE As System.Windows.Forms.Label
    Friend WithEvents tbx_PuestoJefe_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PuestJefInmE As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreJefe_Empleos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_NomJefInmE As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoReferencia As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_TipoReferencia As System.Windows.Forms.Label
    Friend WithEvents tbx_CodigoPostal_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroInt_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumeroExt_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_CPR As System.Windows.Forms.Label
    Friend WithEvents Lbl_CiudadR As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumIntR As System.Windows.Forms.Label
    Friend WithEvents Lbl_NumExtR As System.Windows.Forms.Label
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
    Friend WithEvents lbl_Genero As System.Windows.Forms.Label
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
    Friend WithEvents btn_Guardar_DatosVarios As System.Windows.Forms.Button
    Friend WithEvents tbx_CantidadSeñas As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Guardar_PapeleriaRecibida As System.Windows.Forms.Button
    Friend WithEvents tbx_CodigoPostal As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumInterior As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_NumExterior As Modulo_Reclutamiento.cp_Textbox
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
    Friend WithEvents tbx_Edad As Modulo_Reclutamiento.cp_Textbox
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
    Friend WithEvents lsv_PapeleriaRecibida As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Agregar_Curso As System.Windows.Forms.Button
    Friend WithEvents cmb_DocumentoCurso As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_CursoFinalizado As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_CursoFin As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_CursoFin As System.Windows.Forms.RadioButton
    Friend WithEvents btn_Agregar_Familiares As System.Windows.Forms.Button
    Friend WithEvents cmb_Ciudades_DG As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Zonas As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_AInicio As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ATermino As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_CiudadesFamiliares As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar_Empleos As System.Windows.Forms.Button
    Friend WithEvents cmb_Ciudades_Empleos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_MotivoSeparacion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudades_Referencias As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_Agregar_Referencias As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar_Señas As System.Windows.Forms.Button
    Friend WithEvents lsv_SeñasParticulares As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_CantidadHijos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CantHijos As System.Windows.Forms.Label
    Friend WithEvents Lbl_DVEjemplo As System.Windows.Forms.Label
    Friend WithEvents Lbl_DVEjemplo2 As System.Windows.Forms.Label
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label40 As System.Windows.Forms.Label
    Friend WithEvents Label39 As System.Windows.Forms.Label
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents Label30 As System.Windows.Forms.Label
    Friend WithEvents Label42 As System.Windows.Forms.Label
    Friend WithEvents Label41 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DGViveFamilia As System.Windows.Forms.Label
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
    Friend WithEvents Label60 As System.Windows.Forms.Label
    Friend WithEvents Label59 As System.Windows.Forms.Label
    Friend WithEvents Label67 As System.Windows.Forms.Label
    Friend WithEvents Label68 As System.Windows.Forms.Label
    Friend WithEvents tbx_Telefono_Referencias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Telefono_Referencias As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaBaja As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaIngreso As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaIngreso As System.Windows.Forms.DateTimePicker
    Friend WithEvents tbx_Fecha_FinLabores As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_AMaterno As System.Windows.Forms.Label
    Friend WithEvents lbl_APaterno As System.Windows.Forms.Label
    Friend WithEvents tbx_ApellidoMaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_ApellidoPaterno As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label69 As System.Windows.Forms.Label
    Friend WithEvents tbx_NombreCompleto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label72 As System.Windows.Forms.Label
    Friend WithEvents Label71 As System.Windows.Forms.Label
    Friend WithEvents Label70 As System.Windows.Forms.Label
    Friend WithEvents Label65 As System.Windows.Forms.Label
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
    Friend WithEvents tab_RasgosPersonales As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Cabello As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_TipoSangreR As System.Windows.Forms.Label
    Friend WithEvents Lbl_RColor As System.Windows.Forms.Label
    Friend WithEvents Lbl_RColor2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Cara As System.Windows.Forms.Label
    Friend WithEvents Lbl_RColorPiel As System.Windows.Forms.Label
    Friend WithEvents Lbl_RComplexion As System.Windows.Forms.Label
    Friend WithEvents Lbl_RCantidad As System.Windows.Forms.Label
    Friend WithEvents Lbl_RImplantacion As System.Windows.Forms.Label
    Friend WithEvents Lbl_RCalvicie As System.Windows.Forms.Label
    Friend WithEvents Lbl_RForma As System.Windows.Forms.Label
    Friend WithEvents gbx_Ojos As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_R_Forma2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RTamaño As System.Windows.Forms.Label
    Friend WithEvents gbx_Cejas As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RTamaño2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RImplantacion2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RForma4 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RDireccion As System.Windows.Forms.Label
    Friend WithEvents gbx_Frente As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RAltura2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RAncho As System.Windows.Forms.Label
    Friend WithEvents Lbl_RAltura As System.Windows.Forms.Label
    Friend WithEvents gbx_Nariz As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RAltura3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RBase As System.Windows.Forms.Label
    Friend WithEvents Lbl_RDorso As System.Windows.Forms.Label
    Friend WithEvents Lbl_RAncho2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RRaiz As System.Windows.Forms.Label
    Friend WithEvents gbx_Boca As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RTamaño3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RComisuras As System.Windows.Forms.Label
    Friend WithEvents gbx_Menton As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RForma3 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RInclinacion As System.Windows.Forms.Label
    Friend WithEvents Lbl_RTipo As System.Windows.Forms.Label
    Friend WithEvents gbx_Labios As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RAlturaLabial As System.Windows.Forms.Label
    Friend WithEvents Lbl_RProminencia As System.Windows.Forms.Label
    Friend WithEvents Lbl_REspesor As System.Windows.Forms.Label
    Friend WithEvents gbx_Oreja As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RPosterior As System.Windows.Forms.Label
    Friend WithEvents Lbl_ROriginal As System.Windows.Forms.Label
    Friend WithEvents Lbl_RAdherencia2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RForma2 As System.Windows.Forms.Label
    Friend WithEvents Lbl_RSuperior As System.Windows.Forms.Label
    Friend WithEvents btn_GuardarRasgos As System.Windows.Forms.Button
    Friend WithEvents Lbl_RContorno As System.Windows.Forms.Label
    Friend WithEvents btn_CancelarRasgos As System.Windows.Forms.Button
    Friend WithEvents gbx_Helix As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lobulo As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_RParticularidad As System.Windows.Forms.Label
    Friend WithEvents Lbl_RAdherencia As System.Windows.Forms.Label
    Friend WithEvents Lbl_RDimension As System.Windows.Forms.Label
    Friend WithEvents gbx_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents Label112 As System.Windows.Forms.Label
    Friend WithEvents tbx_EstaturaR As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_REstatura As System.Windows.Forms.Label
    Friend WithEvents Label116 As System.Windows.Forms.Label
    Friend WithEvents tbx_PesoR As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_RPeso As System.Windows.Forms.Label
    Friend WithEvents tab_DatosSocioEcon As System.Windows.Forms.TabPage
    Friend WithEvents lbl_ColoniaEmpleos As System.Windows.Forms.Label
    Friend WithEvents Gbx_AfiliacionAgrupacion As System.Windows.Forms.GroupBox
    Friend WithEvents Dtp_DSHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DSHasta As System.Windows.Forms.Label
    Friend WithEvents Tbx_DsNombre As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSNombre As System.Windows.Forms.Label
    Friend WithEvents Dtp_DSDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_DSDesde As System.Windows.Forms.Label
    Friend WithEvents Cmb_DSTipo As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_DSTipo As System.Windows.Forms.Label
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
    Friend WithEvents cmb_ColorPiel As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ComplexionR As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ColorCabello As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_ColorOjos As Modulo_Reclutamiento.cp_cmb_Manual
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
    Friend WithEvents gbx_DSocio As System.Windows.Forms.GroupBox
    Friend WithEvents Label122 As System.Windows.Forms.Label
    Friend WithEvents Label123 As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSValor As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label130 As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSModelo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSModelo As System.Windows.Forms.Label
    Friend WithEvents Gbx_Vehiculo As System.Windows.Forms.GroupBox
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_DSSi2 As System.Windows.Forms.RadioButton
    Friend WithEvents Tbx_DSValorVive As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSValorVivi As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSPagoMensual As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSPagoMen As System.Windows.Forms.Label
    Friend WithEvents Cmb_DsTipoVivi As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_DSTipoVivienda As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSDescipcion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSDescipcion As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSGastFamMens As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Tbx_DSIngAdi As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSGasFamMen As System.Windows.Forms.Label
    Friend WithEvents Tbx_DsIngFamMen As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSIngAdi As System.Windows.Forms.Label
    Friend WithEvents Lbl_DSIngFamMen As System.Windows.Forms.Label
    Friend WithEvents Lbl_DSViveFam As System.Windows.Forms.Label
    Friend WithEvents Gbx_ViveFam As System.Windows.Forms.GroupBox
    Friend WithEvents Rdb_DSNo As System.Windows.Forms.RadioButton
    Friend WithEvents Rdb_DSSi As System.Windows.Forms.RadioButton
    Friend WithEvents Tbx_DsCantHijos As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSCantHijos As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSHabApidom As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSHabApiDom As System.Windows.Forms.Label
    Friend WithEvents Lbl_DSEjemplo As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSIdiomasDominio As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSIdiomasDomina As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSVicios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSVicios As System.Windows.Forms.Label
    Friend WithEvents Lbl_DsEjemplo2 As System.Windows.Forms.Label
    Friend WithEvents Gbx_DSocio2 As System.Windows.Forms.GroupBox
    Friend WithEvents Tbx_DSComentarios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Btn_DsAgregar As System.Windows.Forms.Button
    Friend WithEvents Lbl_DSComentarios As System.Windows.Forms.Label
    Friend WithEvents Lsv_DS As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Tbx_DSCantidad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSCantidad As System.Windows.Forms.Label
    Friend WithEvents Label56 As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSUbicacion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSUbicacion As System.Windows.Forms.Label
    Friend WithEvents Tbx_DSForma As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DSForma As System.Windows.Forms.Label
    Friend WithEvents Cmb_DSSeñasPart As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_DSSeñasPart As System.Windows.Forms.Label
    Friend WithEvents Gbx_Idioma As System.Windows.Forms.GroupBox
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
    Friend WithEvents Label139 As System.Windows.Forms.Label
    Friend WithEvents Label142 As System.Windows.Forms.Label
    Friend WithEvents lbl_JefeArea As System.Windows.Forms.Label
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
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_MostrarCatalogo As System.Windows.Forms.Button
    Friend WithEvents Lbl_LPuesto As System.Windows.Forms.Label
    Friend WithEvents Lbl_LDepartamento As System.Windows.Forms.Label
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_UMF As System.Windows.Forms.Label
    Friend WithEvents tbx_UMF As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label144 As System.Windows.Forms.Label
    Friend WithEvents Label149 As System.Windows.Forms.Label
    Friend WithEvents Label150 As System.Windows.Forms.Label
    Friend WithEvents Label151 As System.Windows.Forms.Label
    Friend WithEvents lbl_Infonavit As System.Windows.Forms.Label
    Friend WithEvents btn_UMF As System.Windows.Forms.Button
    Friend WithEvents Label154 As System.Windows.Forms.Label
    Friend WithEvents btn_Visitas As System.Windows.Forms.Button
    Friend WithEvents Label156 As System.Windows.Forms.Label
    Friend WithEvents Lbl_DgVerificara As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoCurso As System.Windows.Forms.Label
    Friend WithEvents lbl_TipoCursoA As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoCurso As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_BuscarCurso As System.Windows.Forms.Button
    Friend WithEvents Lbl_DGEjemplo As System.Windows.Forms.Label
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_LStatus As System.Windows.Forms.Label
    Friend WithEvents btn_Validar As System.Windows.Forms.Button
    Friend WithEvents pct_RasgoFrente As System.Windows.Forms.PictureBox
    Friend WithEvents btn_DoctosImportar As System.Windows.Forms.Button
    Friend WithEvents tlt_RasgosMensaje As System.Windows.Forms.ToolTip
    Friend WithEvents lbl_CiudadNac As System.Windows.Forms.Label
    Friend WithEvents btn_RFC As System.Windows.Forms.Button
    Friend WithEvents btn_CURP As System.Windows.Forms.Button
    Friend WithEvents cmb_Pais As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Ciudad As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Estado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tab_Entrevistas As System.Windows.Forms.TabPage
    Friend WithEvents gbx_Entrevistas As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Entrevistas As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_Entrevista As System.Windows.Forms.GroupBox
    Friend WithEvents Label50 As System.Windows.Forms.Label
    Friend WithEvents Label51 As System.Windows.Forms.Label
    Friend WithEvents Label129 As System.Windows.Forms.Label
    Friend WithEvents Label158 As System.Windows.Forms.Label
    Friend WithEvents cmb_EmpleadoEntrevista As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_ComentariosEntrevista As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Agregar_Entrevista As System.Windows.Forms.Button
    Friend WithEvents tbx_ClaveE As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Nombre_Baja As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaEntrevista As System.Windows.Forms.DateTimePicker
    Friend WithEvents Lbl_EApto As System.Windows.Forms.Label
    Friend WithEvents Lbl_EFecha As System.Windows.Forms.Label
    Friend WithEvents gbx_Apto As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_NoApto As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_SiApto As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_EComentarios As System.Windows.Forms.Label
    Friend WithEvents tab_Foto As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_EFotografia As System.Windows.Forms.Label
    Friend WithEvents gbx_FotoProspecto As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Importa As System.Windows.Forms.Button
    Friend WithEvents btn_TomarFrente As System.Windows.Forms.Button
    Friend WithEvents pct_Frente As System.Windows.Forms.PictureBox
    Friend WithEvents btn_LimpiarFrente As System.Windows.Forms.Button
    Friend WithEvents cmb_ModoContactoD As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label163 As System.Windows.Forms.Label
    Friend WithEvents cmb_ModoContacto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_DGEspecifique As System.Windows.Forms.Label
    Friend WithEvents Lbl_DGModoContacto As System.Windows.Forms.Label
    Friend WithEvents cmb_ViveConFam As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_Genero As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_Verifica As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_Ruta As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_JefeArea As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_CertifAcademia As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_CatalogoFirmas As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents cmb_CreditoInfonavit As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_Baja As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar_Foto As System.Windows.Forms.Button
    Friend WithEvents btn_LimpiarLaborales As System.Windows.Forms.Button
    Friend WithEvents gbx_FrenteFormal As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar_FotoFormal As System.Windows.Forms.Button
    Friend WithEvents btn_ImportaFormal As System.Windows.Forms.Button
    Friend WithEvents btn_TomarFrenteFormal As System.Windows.Forms.Button
    Friend WithEvents pct_FrenteFormal As System.Windows.Forms.PictureBox
    Friend WithEvents btn_LimpiarFrenteFormal As System.Windows.Forms.Button
    Friend WithEvents Label155 As System.Windows.Forms.Label
    Friend WithEvents btn_ComprobarListaNegra As System.Windows.Forms.Button
    Friend WithEvents tbx_ExpInfonavit As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DGInfonavit As System.Windows.Forms.Label
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents tab_Contacto As System.Windows.Forms.TabPage
    Friend WithEvents cmb_Localizacion As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents btn_AgregarContactos As System.Windows.Forms.Button
    Friend WithEvents btn_borrarP As System.Windows.Forms.Button
    Friend WithEvents btn_cancelarP As System.Windows.Forms.Button
    Friend WithEvents lsv_Contacto As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_Descripcion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Descripcion As System.Windows.Forms.Label
    Friend WithEvents lbl_Contacto As System.Windows.Forms.Label
    Friend WithEvents lbl_NombreCompleto As System.Windows.Forms.Label
    Friend WithEvents chk_Aptos As System.Windows.Forms.CheckBox
    Friend WithEvents lbl_apto As System.Windows.Forms.Label
    Friend WithEvents cmb_aptos As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_Hasta As System.Windows.Forms.Label
    Friend WithEvents Lbl_Desde As System.Windows.Forms.Label
    Friend WithEvents Dtp_Desde As System.Windows.Forms.DateTimePicker
    Friend WithEvents Dtp_Hasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_DoctosCancelar As System.Windows.Forms.Button
    Friend WithEvents btn_EntrevistasCancelar As System.Windows.Forms.Button
    Friend WithEvents btn_FotografiaCancelar As System.Windows.Forms.Button
    Friend WithEvents tbx_NumeroCredito As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NumeroCredito As System.Windows.Forms.Label
    Friend WithEvents tbx_MontoDescuento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_MontoDescuento As System.Windows.Forms.Label
    Friend WithEvents cmb_TipoDescuento As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents lbl_TipoDescuento As System.Windows.Forms.Label
    Friend WithEvents cmb_Paises_Empleos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Paises_Referencias As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_NumeroLicencia As cp_Textbox
    Friend WithEvents lbl_NumeroLicencia As Label
    Friend WithEvents tbx_IdTributario As cp_Textbox
    Friend WithEvents lbl_RFC_Extranjero As Label
    Friend WithEvents tbx_NumeroLicenciaFed As cp_Textbox
    Friend WithEvents lbl_NumeroLicenciaFed As Label
    Friend WithEvents dtp_FechaExpiraFed As DateTimePicker
    Friend WithEvents lbl_FechaExpiraFed As Label
    Friend WithEvents cmb_Colonias As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label6 As Label
    Friend WithEvents tbx_Colonia_Referencias As TextBox
    Friend WithEvents tbx_Colonias_Empleos As TextBox
    Friend WithEvents Btn_AgregarColonia As Button
    Friend WithEvents btn_Guardar_DG As Button
    Friend WithEvents Lbl_OcupacionR As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label34 As Label
    Friend WithEvents Label35 As Label
    Friend WithEvents txt_am As cp_Textbox
    Friend WithEvents txt_ap As cp_Textbox
    Friend WithEvents Label23 As Label
    Friend WithEvents cmb_ocupacion As cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_cantidad As cp_cmb_Manual
    Friend WithEvents btn_refionesSSP As Button
    Friend WithEvents cmb_region As cp_cmb_Manual
    Friend WithEvents Label32 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents cmb_vista As cp_cmb_Manual
    Friend WithEvents Label24 As Label
    Friend WithEvents cmb_lado As cp_cmb_Manual
    Friend WithEvents Label153 As Label
    Friend WithEvents Label152 As Label
    Friend WithEvents Label76 As Label
    Friend WithEvents tbx_Comentarios_Señas As cp_Textbox
    Friend WithEvents lbl_Comentarios_Señas As Label
    Friend WithEvents lbl_CantidadSeñas As Label
    Friend WithEvents Label62 As Label
    Friend WithEvents lbl_UbicacionSeñas As Label
    Friend WithEvents tbx_UbicacionSeñas As cp_Textbox
    Friend WithEvents lbl_FormaSeñas As Label
    Friend WithEvents cmb_SeñasParticulares As cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Señas As Label
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Button1 As Button
    Friend WithEvents btn_EliminarHuellaD As Button
    Friend WithEvents btn_EliminarHuellasIzq As Button
    Friend WithEvents btn_CapturarHuellas As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents pbx_HuellaDer As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents pbx_HuellaIzq As PictureBox
    Friend WithEvents btn_Investigacion As Button
    Friend WithEvents btn_InvestigacionPersonal As Button
End Class
