Imports System.IO
Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales

Public Class frm_EmpleadosP
    'variables para controlar la papeleria recibida
    Dim Id_Seleccionado As Integer = 0
    Dim Nombre_Seleccionado As String = ""
    Dim Clave_Seleccionado As String = ""
    '***********************************************
    Dim CursosAgregados As Boolean = False
    Dim FamiliaresAgregados As Boolean = False
    Dim EmpleosAgregados As Boolean = False
    Dim ReferenciasAgregadas As Boolean = False
    Dim SeñasAgregadas As Boolean = False
    Dim Datoscontacto As Boolean = False
    Dim CuentaSeñas As Integer = 0
    Dim Id As Integer
    Dim Id_EmpleadoEscolar As Integer = 0
    Dim Id_EmpleadoIngresos As Integer = 0
    Dim Id_EmpleadoRasgos As Integer = 0
    Dim LimpiaTodo As Boolean = False
    Dim Modificando As Boolean = False
    Dim dt_PredictivoEmpresas As DataTable
    Dim Predictivo As Boolean = False
    'Dim Adjunto As String = ""
    Dim PuestoPrevio As Integer
    Dim PapeleriaRecibida As Integer = 0
    Dim ParamAgregar As Integer = 0
    Dim ClaveProspecto As Integer = 0
    Dim Tipo As Char = ""
    Dim RutaTemp As String = Application.StartupPath & "\"

    'variables para referencias laborales y personales
    Dim IdReferencia As Integer = 0
    Dim CandidatoReferencia As String
    Dim Referencia As String
    Dim TelefonoReferencia As String

#Region "CATÁLOGO"

    Private Sub frm_EmpleadosP_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        tbx_NombreFamiliar.Focus()
        Dim Pais As Integer = 1
        ' Verificar longitud CveEmpleado y tipoDato CveEmpleado
        tbx_Clave.MaxLength = Long_ClaveEmp '11/04/2014

        cmb_aptos.AgregarItem("S", "SI APTOS")
        cmb_aptos.AgregarItem("N", "NO APTOS")
        '--------------------

        lsv_PredictivoEmpresas.Left = 125
        lsv_PredictivoEmpresas.Top = 40

        lsv_Catalogo.Columns.Add("Clave")
        lsv_Catalogo.Columns.Add("Nombre")
        lsv_Catalogo.Columns.Add("Departamento")
        lsv_Catalogo.Columns.Add("Puesto")
        lsv_Catalogo.Columns.Add("Status")

        cmb_PuestoFiltro.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_PuestoFiltro.AgregaParametro("@Status", "A", 0)
        cmb_PuestoFiltro.Actualizar()
        cmb_DepartamentoFiltro.Actualizar()

        cmb_Status.AgregarItem("A", "ACTIVOS")
        cmb_Status.AgregarItem("B", "BAJAS")
        cmb_Status.AgregarItem("V", "VALIDADOS")

        'Aqui se Actualizan los combos de DATOS GENERALES
        cmb_Genero.AgregarItem("M", "MASCULINO")
        cmb_Genero.AgregarItem("F", "FEMENINO")
        cmb_ViveConFam.AgregarItem("S", "SI")
        cmb_ViveConFam.AgregarItem("N", "NO")
#Region "Lado,vista,Combo de region y cantidad"
        ''Se agregan nuevos combos para la pestaña de datos varios JESUS ORTEGA 18/08/2023
        cmb_lado.AgregarItem("1", "IZQUIERDO")
        cmb_lado.AgregarItem("2", "DERECHO")
        cmb_lado.AgregarItem("3", "UNICO")

        cmb_vista.AgregarItem("1", "FRONTAL (FRENTE)")
        cmb_vista.AgregarItem("2", "DORSAL (DETRAS)")
        cmb_region.AgregarItem("1", "1")
        cmb_region.AgregarItem("2", "2")
        cmb_region.AgregarItem("3", "3")
        cmb_region.AgregarItem("4", "4")
        cmb_region.AgregarItem("5", "5")
        cmb_region.AgregarItem("6", "6")
        cmb_region.AgregarItem("7", "7")
        cmb_region.AgregarItem("8", "8")
        cmb_region.AgregarItem("9", "9")
        cmb_region.AgregarItem("10", "10")
        cmb_region.AgregarItem("11", "11")
        cmb_region.AgregarItem("12", "12")
        cmb_region.AgregarItem("13", "13")
        cmb_region.AgregarItem("14", "14")
        cmb_region.AgregarItem("15", "15")
        cmb_region.AgregarItem("16", "16")
        cmb_region.AgregarItem("17", "17")
        cmb_region.AgregarItem("18", "18")
        cmb_region.AgregarItem("19", "19")
        cmb_region.AgregarItem("20", "20")
        cmb_region.AgregarItem("21", "21")
        cmb_region.AgregarItem("22", "22")
        cmb_region.AgregarItem("23", "23")
        cmb_region.AgregarItem("24", "24")
        cmb_region.AgregarItem("25", "25")
        cmb_region.AgregarItem("26", "26")
        cmb_region.AgregarItem("27", "27")
        cmb_region.AgregarItem("28", "28")
        cmb_region.AgregarItem("29", "29")
        cmb_region.AgregarItem("30", "30")
        cmb_region.AgregarItem("31", "31")
        cmb_region.AgregarItem("32", "32")
        cmb_region.AgregarItem("33", "33")
        cmb_region.AgregarItem("34", "34")
        cmb_region.AgregarItem("35", "35")
        cmb_region.AgregarItem("36", "36")
        cmb_region.AgregarItem("37", "37")
        cmb_region.AgregarItem("38", "38")
        cmb_region.AgregarItem("39", "39")
        cmb_region.AgregarItem("40", "40")
        cmb_region.AgregarItem("41", "41")
        cmb_region.AgregarItem("42", "42")
        cmb_region.AgregarItem("43", "43")
        cmb_region.AgregarItem("44", "44")
        cmb_region.AgregarItem("45", "45")
        cmb_region.AgregarItem("46", "46")
        cmb_region.AgregarItem("47", "47")
        cmb_region.AgregarItem("48", "48")
        cmb_region.AgregarItem("49", "49")
        cmb_region.AgregarItem("50", "50")
        cmb_region.AgregarItem("51", "51")
        cmb_region.AgregarItem("52", "52")
        cmb_region.AgregarItem("53", "53")
        cmb_region.AgregarItem("54", "54")
        cmb_region.AgregarItem("55", "55")
        cmb_region.AgregarItem("56", "56")
        cmb_region.AgregarItem("57", "57")
        cmb_region.AgregarItem("58", "58")
        cmb_region.AgregarItem("59", "59")
        cmb_region.AgregarItem("60", "60")

        cmb_cantidad.AgregarItem("1", "1")
        cmb_cantidad.AgregarItem("2", "2")
        cmb_cantidad.AgregarItem("3", "3")
        cmb_cantidad.AgregarItem("4", "4")
        cmb_cantidad.AgregarItem("5", "5")
        cmb_cantidad.AgregarItem("6", "6")
        cmb_cantidad.AgregarItem("7", "7")
        cmb_cantidad.AgregarItem("8", "8")
        cmb_cantidad.AgregarItem("9", "9")
        cmb_cantidad.AgregarItem("10", "10")
        cmb_cantidad.AgregarItem("11", "11")
        cmb_cantidad.AgregarItem("12", "12")
        cmb_cantidad.AgregarItem("13", "13")
        cmb_cantidad.AgregarItem("14", "14")
        cmb_cantidad.AgregarItem("15", "15")
        cmb_cantidad.AgregarItem("16", "16")
        cmb_cantidad.AgregarItem("17", "17")
        cmb_cantidad.AgregarItem("18", "18")
        cmb_cantidad.AgregarItem("19", "19")
        cmb_cantidad.AgregarItem("20", "20")
        cmb_cantidad.AgregarItem("21", "21")
        cmb_cantidad.AgregarItem("22", "22")
        cmb_cantidad.AgregarItem("23", "23")
        cmb_cantidad.AgregarItem("24", "24")
        cmb_cantidad.AgregarItem("25", "25")
        cmb_cantidad.AgregarItem("26", "26")
        cmb_cantidad.AgregarItem("27", "27")
        cmb_cantidad.AgregarItem("28", "28")
        cmb_cantidad.AgregarItem("29", "29")
        cmb_cantidad.AgregarItem("30", "30")
        cmb_cantidad.AgregarItem("31", "31")
        cmb_cantidad.AgregarItem("32", "32")
        cmb_cantidad.AgregarItem("33", "33")
        cmb_cantidad.AgregarItem("34", "34")
        cmb_cantidad.AgregarItem("35", "35")
        cmb_cantidad.AgregarItem("36", "36")
        cmb_cantidad.AgregarItem("37", "37")
        cmb_cantidad.AgregarItem("38", "38")
        cmb_cantidad.AgregarItem("39", "39")
        cmb_cantidad.AgregarItem("40", "40")
        cmb_cantidad.AgregarItem("41", "41")
        cmb_cantidad.AgregarItem("42", "42")
        cmb_cantidad.AgregarItem("43", "43")
        cmb_cantidad.AgregarItem("44", "44")
        cmb_cantidad.AgregarItem("45", "45")
        cmb_cantidad.AgregarItem("46", "46")
        cmb_cantidad.AgregarItem("47", "47")
        cmb_cantidad.AgregarItem("48", "48")
        cmb_cantidad.AgregarItem("49", "49")
        cmb_cantidad.AgregarItem("50", "50")
        cmb_cantidad.AgregarItem("51", "51")
        cmb_cantidad.AgregarItem("52", "52")
        cmb_cantidad.AgregarItem("53", "53")
        cmb_cantidad.AgregarItem("54", "54")
        cmb_cantidad.AgregarItem("55", "55")
        cmb_cantidad.AgregarItem("56", "56")
        cmb_cantidad.AgregarItem("57", "57")
        cmb_cantidad.AgregarItem("58", "58")
        cmb_cantidad.AgregarItem("59", "59")
        cmb_cantidad.AgregarItem("60", "60")
        cmb_cantidad.AgregarItem("61", "61")
        cmb_cantidad.AgregarItem("62", "62")
        cmb_cantidad.AgregarItem("63", "63")
        cmb_cantidad.AgregarItem("64", "64")
        cmb_cantidad.AgregarItem("65", "65")
        cmb_cantidad.AgregarItem("66", "66")
        cmb_cantidad.AgregarItem("67", "67")
        cmb_cantidad.AgregarItem("68", "68")
        cmb_cantidad.AgregarItem("69", "69")
        cmb_cantidad.AgregarItem("70", "70")
        cmb_cantidad.AgregarItem("71", "71")
        cmb_cantidad.AgregarItem("72", "72")
        cmb_cantidad.AgregarItem("73", "73")
        cmb_cantidad.AgregarItem("74", "74")
        cmb_cantidad.AgregarItem("75", "75")
        cmb_cantidad.AgregarItem("76", "76")
        cmb_cantidad.AgregarItem("77", "77")
        cmb_cantidad.AgregarItem("78", "78")
        cmb_cantidad.AgregarItem("79", "79")
        cmb_cantidad.AgregarItem("80", "80")
        cmb_cantidad.AgregarItem("81", "81")
        cmb_cantidad.AgregarItem("82", "82")
        cmb_cantidad.AgregarItem("83", "83")
        cmb_cantidad.AgregarItem("84", "84")
        cmb_cantidad.AgregarItem("85", "85")
        cmb_cantidad.AgregarItem("86", "86")
        cmb_cantidad.AgregarItem("87", "87")
        cmb_cantidad.AgregarItem("88", "88")
        cmb_cantidad.AgregarItem("89", "89")
        cmb_cantidad.AgregarItem("90", "90")
        cmb_cantidad.AgregarItem("91", "91")
        cmb_cantidad.AgregarItem("92", "92")
        cmb_cantidad.AgregarItem("93", "93")
        cmb_cantidad.AgregarItem("94", "94")
        cmb_cantidad.AgregarItem("95", "95")
        cmb_cantidad.AgregarItem("96", "96")
        cmb_cantidad.AgregarItem("97", "97")
        cmb_cantidad.AgregarItem("98", "98")
        cmb_cantidad.AgregarItem("99", "99")
#End Region '

        cmb_Puesto.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_Puesto.AgregaParametro("@Status", "A", 0)
        cmb_Puesto.Actualizar()
        cmb_Departamento_DG.Actualizar()

        cmb_EstadoCivil.Actualizar()
        'cmb_Ciudades_DG.ValorParametro = Pais
        'cmb_Ciudades_DG.Actualizar()
        cmb_Zonas.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_Zonas.Actualizar()

        cmb_Ciudades_DG.AgregaParametro("@Id_Pais", Pais, 1)
        cmb_Ciudades_DG.Actualizar()

        cmb_Colonias.AgregaParametro("@Id_Ciudad", -1, 1)
        cmb_Colonias.Actualizar()

        'cmb_Zonas.ValorParametro = 0
        'cmb_Zonas.Actualizar()

        cmb_TipoLicencia.Actualizar()
        cmb_EmpleadoReferencia.Actualizar()
        cmb_ModoNacionalidad.AgregarItem("1", "NACIMIENTO")
        cmb_ModoNacionalidad.AgregarItem("2", "NATURALIZADO")
        cmb_ModoNacionalidad.AgregarItem("3", "EXTRANJERO")

        cmb_Ciudad.AgregaParametro("@Status", "A", 0)
        cmb_Ciudad.AgregaParametro("@Id_Estado", -1, 1)
        cmb_Ciudad.Actualizar()
        cmb_Estado.AgregaParametro("@Status", "A", 0)
        cmb_Estado.AgregaParametro("@Id_Pais", -1, 1)
        cmb_Estado.Actualizar()
        cmb_Pais.AgregaParametro("@Status", "A", 0)
        cmb_Pais.Actualizar()

        cmb_ModoContactoD.AgregaParametro("@Id_ModoContacto", 0, 1)
        cmb_ModoContactoD.AgregaParametro("@Status", "A", 0)
        cmb_ModoContactoD.Actualizar()
        cmb_ModoContacto.AgregaParametro("@Tipo", 2, 1)
        cmb_ModoContacto.AgregaParametro("@Status", "A", 0)
        cmb_ModoContacto.Actualizar()

        cmb_Localizacion.Actualizar()

        cmb_CreditoInfonavit.AgregarItem("S", "SI")
        cmb_CreditoInfonavit.AgregarItem("N", "NO")
        cmb_TipoDescuento.AgregarItem("I", "IMPORTE")
        cmb_TipoDescuento.AgregarItem("P", "PORCENTAJE")
        cmb_TipoDescuento.AgregarItem("V", "VSM")

        cmb_CatalogoFirmas.AgregarItem("S", "SI")
        cmb_CatalogoFirmas.AgregarItem("N", "NO")
        cmb_CertifAcademia.AgregarItem("S", "SI")
        cmb_CertifAcademia.AgregarItem("N", "NO")
        cmb_JefeArea.AgregarItem("S", "SI")
        cmb_JefeArea.AgregarItem("N", "NO")
        cmb_Ruta.AgregarItem("S", "SI")
        cmb_Ruta.AgregarItem("N", "NO")
        cmb_Verifica.AgregarItem("S", "SI")
        cmb_Verifica.AgregarItem("N", "NO")
        'Aquí se inicializa el valor del Id 
        'que va a contener el Id del Prospecto en caso de que se seleccione uno
        Id = 0

        'Aquí se actualizan los combos de ENTREVISTAS
        cmb_EmpleadoEntrevista.Actualizar()
        lsv_Entrevistas.Columns.Add("Fecha", 100)
        lsv_Entrevistas.Columns.Add("Entrevistó", 250)
        lsv_Entrevistas.Columns.Add("Apto", 80)
        lsv_Entrevistas.Columns.Add("Comentarios", 250)
        lsv_Entrevistas.Columns.Add("IDE", 0)

        'Aquí se actualizan los combos de RASGOS
        cmb_ComplexionR.AgregarItem("1", "DELGADA")
        cmb_ComplexionR.AgregarItem("2", "REGULAR")
        cmb_ComplexionR.AgregarItem("3", "ROBUSTA")
        cmb_ComplexionR.AgregarItem("4", "ATLETICA")
        cmb_ComplexionR.AgregarItem("5", "OBESA")
        cmb_ColorPiel.AgregarItem("1", "ALBINO")
        cmb_ColorPiel.AgregarItem("2", "BLANCO")
        cmb_ColorPiel.AgregarItem("3", "AMARILLO")
        cmb_ColorPiel.AgregarItem("4", "MORENO CLARO")
        cmb_ColorPiel.AgregarItem("5", "MORENO")
        cmb_ColorPiel.AgregarItem("6", "MORENO OSCURO")
        cmb_ColorPiel.AgregarItem("7", "NEGRO")
        cmb_ColorPiel.AgregarItem("8", "OTRO")
        cmb_Cara.AgregarItem("1", "ALARGADA")
        cmb_Cara.AgregarItem("2", "CUADRADA")
        cmb_Cara.AgregarItem("3", "OVALADA")
        cmb_Cara.AgregarItem("4", "REDONDA")
        cmb_TipoSangreR.AgregarItem("1", "A")
        cmb_TipoSangreR.AgregarItem("2", "B")
        cmb_TipoSangreR.AgregarItem("3", "O")
        cmb_TipoSangreR.AgregarItem("4", "AB")
        cmb_FactorRH.AgregarItem("1", "POSITIVO")
        cmb_FactorRH.AgregarItem("2", "NEGATIVO")
        cmb_UsaAnteojos.AgregarItem("S", "SI")
        cmb_UsaAnteojos.AgregarItem("N", "NO")

        cmb_CantidadCabello.AgregarItem("1", "ABUNDANTE")
        cmb_CantidadCabello.AgregarItem("2", "ESCASO")
        cmb_CantidadCabello.AgregarItem("3", "REGULAR")
        cmb_CantidadCabello.AgregarItem("4", "SIN CABELLO")

        cmb_ColorCabello.AgregarItem("1", "ALBINO")
        cmb_ColorCabello.AgregarItem("2", "CANO TOTAL")
        cmb_ColorCabello.AgregarItem("3", "CASTAÑO CLARO")
        cmb_ColorCabello.AgregarItem("4", "CASTAÑO OSCURO")
        cmb_ColorCabello.AgregarItem("5", "ENTRECANO")
        cmb_ColorCabello.AgregarItem("6", "NEGRO")
        cmb_ColorCabello.AgregarItem("7", "PELIRROJO")
        cmb_ColorCabello.AgregarItem("8", "RUBIO")
        cmb_ColorCabello.AgregarItem("9", "NO APLICA")

        cmb_FormaCabello.AgregarItem("1", "CRESPO")
        cmb_FormaCabello.AgregarItem("2", "LACIO")
        cmb_FormaCabello.AgregarItem("3", "ONDULADO")
        cmb_FormaCabello.AgregarItem("4", "RIZADO")
        cmb_FormaCabello.AgregarItem("5", "NO APLICA")

        cmb_Calvicie.AgregarItem("1", "FRONTAL")
        cmb_Calvicie.AgregarItem("2", "TONSURAL")
        cmb_Calvicie.AgregarItem("3", "FRONTOPARIETAL")
        cmb_Calvicie.AgregarItem("4", "TOTAL")
        cmb_Calvicie.AgregarItem("5", "NO APLICA")

        cmb_ImplantacionCabello.AgregarItem("1", "CIRCULAR")
        cmb_ImplantacionCabello.AgregarItem("2", "RECTANGULAR")
        cmb_ImplantacionCabello.AgregarItem("3", "EN PUNTA")
        cmb_ImplantacionCabello.AgregarItem("4", "NO APLICA")

        cmb_AlturaFrente.AgregarItem("1", "GRANDE")
        cmb_AlturaFrente.AgregarItem("2", "MEDIANA")
        cmb_AlturaFrente.AgregarItem("3", "PEQUEÑA")
        cmb_InclinacionFrente.AgregarItem("1", "OBLICUA")
        cmb_InclinacionFrente.AgregarItem("2", "INTERMEDIA")
        cmb_InclinacionFrente.AgregarItem("3", "VERTICAL")
        cmb_InclinacionFrente.AgregarItem("4", "PROMINENTE")
        cmb_AnchoFrente.AgregarItem("1", "GRANDE")
        cmb_AnchoFrente.AgregarItem("2", "MEDIANA")
        cmb_AnchoFrente.AgregarItem("3", "PEQUEÑA")

        cmb_DireccionCejas.AgregarItem("1", "INTERNAS")
        cmb_DireccionCejas.AgregarItem("2", "EXTERNAS")
        cmb_DireccionCejas.AgregarItem("3", "HORIZONTAL")
        cmb_ImplantacionCejas.AgregarItem("1", "ALTAS")
        cmb_ImplantacionCejas.AgregarItem("2", "BAJAS")
        cmb_ImplantacionCejas.AgregarItem("3", "PROXIMAS")
        cmb_ImplantacionCejas.AgregarItem("4", "SEPARADAS")
        cmb_FormaCejas.AgregarItem("1", "ARQUEADAS")
        cmb_FormaCejas.AgregarItem("2", "ARQ SINUOSAS")
        cmb_FormaCejas.AgregarItem("3", "RECTILINEAS")
        cmb_FormaCejas.AgregarItem("4", "RECT SINUOSAS")
        cmb_TamañoCejas.AgregarItem("1", "GRUESAS")
        cmb_TamañoCejas.AgregarItem("2", "DELGADAS")
        cmb_TamañoCejas.AgregarItem("3", "CORTAS")
        cmb_TamañoCejas.AgregarItem("4", "LARGAS")

        cmb_ColorOjos.AgregarItem("1", "AZUL")
        cmb_ColorOjos.AgregarItem("2", "CAFE CLARO")
        cmb_ColorOjos.AgregarItem("3", "CAFE OSCURO")
        cmb_ColorOjos.AgregarItem("4", "GRIS")
        cmb_ColorOjos.AgregarItem("5", "VERDE")
        cmb_ColorOjos.AgregarItem("6", "OTRO")
        cmb_FormaOjos.AgregarItem("1", "ALRGADOS")
        cmb_FormaOjos.AgregarItem("2", "S")
        cmb_FormaOjos.AgregarItem("3", "OVALES")
        cmb_TamañoOjos.AgregarItem("1", "GRANDES")
        cmb_TamañoOjos.AgregarItem("2", "PEQUEÑOS")
        cmb_TamañoOjos.AgregarItem("3", "REGULARES")

        cmb_RaizNariz.AgregarItem("1", "GRANDE")
        cmb_RaizNariz.AgregarItem("2", "MEDIANA")
        cmb_RaizNariz.AgregarItem("3", "PEQUEÑA")
        cmb_DorsoNariz.AgregarItem("1", "CONCAVO")
        cmb_DorsoNariz.AgregarItem("2", "CONVEXO")
        cmb_DorsoNariz.AgregarItem("3", "RECTO")
        cmb_DorsoNariz.AgregarItem("4", "SINUOSO")
        cmb_AnchoNariz.AgregarItem("1", "GRANDE")
        cmb_AnchoNariz.AgregarItem("2", "MEDIANA")
        cmb_AnchoNariz.AgregarItem("3", "PEQUEÑA")
        cmb_BaseNariz.AgregarItem("1", "ABATIDA")
        cmb_BaseNariz.AgregarItem("2", "HORIZONTAL")
        cmb_BaseNariz.AgregarItem("3", "LEVANTADA")
        cmb_AlturaNariz.AgregarItem("1", "GRANDE")
        cmb_AlturaNariz.AgregarItem("2", "MEDIANA")
        cmb_AlturaNariz.AgregarItem("3", "PEQUEÑA")

        cmb_TamañoBoca.AgregarItem("1", "GRANDE")
        cmb_TamañoBoca.AgregarItem("2", "MEDIANA")
        cmb_TamañoBoca.AgregarItem("3", "PEQUEÑA")
        cmb_ComisurasBoca.AgregarItem("1", "ABATIDAS")
        cmb_ComisurasBoca.AgregarItem("2", "ELEVADAS")
        cmb_ComisurasBoca.AgregarItem("3", "SIMETRICAS")
        cmb_ComisurasBoca.AgregarItem("4", "ASIMETRICAS")

        cmb_EspesorLabios.AgregarItem("1", "DELGADOS")
        cmb_EspesorLabios.AgregarItem("2", "MEDIANOS")
        cmb_EspesorLabios.AgregarItem("3", "GRUESOS")
        cmb_EspesorLabios.AgregarItem("4", "MORRUDOS")
        cmb_AlturaNasoLabial.AgregarItem("1", "GRANDE")
        cmb_AlturaNasoLabial.AgregarItem("2", "MEDIANA")
        cmb_AlturaNasoLabial.AgregarItem("3", "PEQUEÑA")
        cmb_ProminenciaLabios.AgregarItem("1", "LABIO INFERIOR")
        cmb_ProminenciaLabios.AgregarItem("2", "LABIO SUPERIOR")
        cmb_ProminenciaLabios.AgregarItem("3", "NINGUNO")

        cmb_TipoMenton.AgregarItem("1", "BILOVADO")
        cmb_TipoMenton.AgregarItem("2", "FOSETA")
        cmb_TipoMenton.AgregarItem("3", "BORLA")
        cmb_TipoMenton.AgregarItem("4", "NINGUNA")
        cmb_FormaMenton.AgregarItem("1", "OVAL")
        cmb_FormaMenton.AgregarItem("2", "CUADRADO")
        cmb_FormaMenton.AgregarItem("3", "EN PUNTA")
        cmb_InclinacionMenton.AgregarItem("1", "HUYENTE")
        cmb_InclinacionMenton.AgregarItem("2", "PROMINENTE")
        cmb_InclinacionMenton.AgregarItem("3", "VERTICAL")

        cmb_FormaOreja.AgregarItem("1", "CUADRADA")
        cmb_FormaOreja.AgregarItem("2", "OVALADA")
        cmb_FormaOreja.AgregarItem("3", "REDONDA")
        cmb_FormaOreja.AgregarItem("4", "TRIANGULAR")
        cmb_OriginalOreja.AgregarItem("1", "GRANDE")
        cmb_OriginalOreja.AgregarItem("2", "MEDIANO")
        cmb_OriginalOreja.AgregarItem("3", "PEQUEÑO")
        cmb_HelixSuperior.AgregarItem("1", "GRANDE")
        cmb_HelixSuperior.AgregarItem("2", "MEDIANA")
        cmb_HelixSuperior.AgregarItem("3", "PEQUEÑA")
        cmb_HelixPosterior.AgregarItem("1", "GRANDE")
        cmb_HelixPosterior.AgregarItem("2", "MEDIANA")
        cmb_HelixPosterior.AgregarItem("3", "PEQUEÑA")
        cmb_HelixAdherencia.AgregarItem("1", "UNIDO")
        cmb_HelixAdherencia.AgregarItem("2", "SEPARADO")
        cmb_HelixAdherencia.AgregarItem("3", "MUY SEPARADO")
        cmb_HelixContorno.AgregarItem("1", "DESCENDENTE")
        cmb_HelixContorno.AgregarItem("2", "EN ESCUADRA")
        cmb_HelixContorno.AgregarItem("3", "EN GOLFO")
        cmb_HelixContorno.AgregarItem("4", "INTERMEDIO")
        cmb_LobuloAdherencia.AgregarItem("1", "UNIDO")
        cmb_LobuloAdherencia.AgregarItem("2", "SEPARADO")
        cmb_LobuloAdherencia.AgregarItem("3", "MUY SEPARADO")
        cmb_LobuloParticularidad.AgregarItem("1", "PERFORADO")
        cmb_LobuloParticularidad.AgregarItem("2", "FOSETA")
        cmb_LobuloParticularidad.AgregarItem("3", "ISLOTE")
        cmb_LobuloDimension.AgregarItem("1", "GRANDE")
        cmb_LobuloDimension.AgregarItem("2", "MEDIANO")
        cmb_LobuloDimension.AgregarItem("3", "PEQUEÑO")

        'Aquí se inicializa el valor del Id de la pestaña
        Id_EmpleadoRasgos = 0

        'Aqui se actualizan los combos de DATOS ESCOLARES
        cmb_UltimosEstudios.Actualizar()
        cmb_Documentacion.Actualizar()
        cmb_TipoCurso.AgregarItem("S", "INTERNO")
        cmb_TipoCurso.AgregarItem("N", "EXTERNO")
        cmb_DocumentoCurso.Actualizar()
        lsv_Cursos.Columns.Add("Curso")
        lsv_Cursos.Columns.Add("FechaInicio")
        lsv_Cursos.Columns.Add("FechaFin")
        lsv_Cursos.Columns.Add("Instructor")
        lsv_Cursos.Columns.Add("TipoDocumento")
        lsv_Cursos.Columns.Add("Comentarios")
        lsv_Cursos.Columns.Add("Id_TipoDocumento")

        Dim a As Integer = 0
        For a = 1950 To Today.Year
            cmb_AInicio.AgregarItem(a.ToString, a.ToString)
        Next

        For a = 1950 To Today.Year
            cmb_ATermino.AgregarItem(a.ToString, a.ToString)
        Next
        'Aquí se inicializa el valor del Id de la pestaña
        Id_EmpleadoEscolar = 0

        'Aqui se actualizan los combos de DATOS FAMILIARES
        cmb_Parentesco.Actualizar()
        'cmb_CiudadesFamiliares.ValorParametro = Pais
        cmb_CiudadesFamiliares.AgregaParametro("@Id_Pais", Pais, 1)
        cmb_CiudadesFamiliares.Actualizar()
        lsv_Familiares.Columns.Add("Nombre")
        lsv_Familiares.Columns.Add("Parentesco")
        lsv_Familiares.Columns.Add("FechaNac")
        lsv_Familiares.Columns.Add("Domicilio")
        lsv_Familiares.Columns.Add("Ciudad")
        lsv_Familiares.Columns.Add("Telefono")
        lsv_Familiares.Columns.Add("Vive")
        lsv_Familiares.Columns.Add("MismoDomicilio")
        lsv_Familiares.Columns.Add("DependienteEconomico")
        lsv_Familiares.Columns.Add("")
        lsv_Familiares.Columns.Add("Id_Ciudad")
        lsv_Familiares.Columns.Add("")
        lsv_Familiares.Columns(9).Width = 0
        lsv_Familiares.Columns(10).Width = 0
        lsv_Familiares.Columns(11).Width = 0

        'Aqui se actualizan los combos de EMPLEOS
        cmb_Ciudades_Empleos.AgregaParametro("@Id_Pais", cmb_Paises_Empleos.SelectedValue, 0)
        cmb_Paises_Empleos.Actualizar()


        cmb_MotivoSeparacion.AgregaParametro("@Tipo", 2, 1)
        cmb_MotivoSeparacion.Actualizar()

        lsv_Empleos.Columns.Add("NombreEmpresa")
        lsv_Empleos.Columns.Add("Calle")
        lsv_Empleos.Columns.Add("EntreCalle1")
        lsv_Empleos.Columns.Add("EntreCalle2")
        lsv_Empleos.Columns.Add("NumeroExt")
        lsv_Empleos.Columns.Add("NumeroInt")
        lsv_Empleos.Columns.Add("Colonia")
        lsv_Empleos.Columns.Add("Ciudad")
        lsv_Empleos.Columns.Add("CodigoPostal")
        lsv_Empleos.Columns.Add("Latitud")
        lsv_Empleos.Columns.Add("Longitud")
        lsv_Empleos.Columns.Add("FechaIngreso")
        lsv_Empleos.Columns.Add("FechaBaja")
        lsv_Empleos.Columns.Add("Puesto")
        lsv_Empleos.Columns.Add("NombreJefe")
        lsv_Empleos.Columns.Add("PuestoJefe")
        lsv_Empleos.Columns.Add("Telefono")
        lsv_Empleos.Columns.Add("SueldoIni")
        lsv_Empleos.Columns.Add("SueldoFin")
        lsv_Empleos.Columns.Add("MotivoBaja")
        lsv_Empleos.Columns.Add("Otro")
        lsv_Empleos.Columns.Add("EmpresaSeg")
        lsv_Empleos.Columns.Add("PorteArmas")

        lsv_PredictivoEmpresas.Columns.Add("") 'Nombre
        lsv_PredictivoEmpresas.Columns.Add("") 'Direccion
        'lsv_PredictivoEmpresas.Col

        'Aquí se actualizan los combos de REFERENCIAS
        cmb_TipoReferencia.Actualizar()
        cmb_ocupacion.Actualizar()

        cmb_Ciudades_Referencias.AgregaParametro("@Id_Pais", cmb_Paises_Referencias.SelectedValue, 0)
        cmb_Paises_Referencias.Actualizar()

        lsv_Referencias.Columns.Add("Descripcion")             '1
        lsv_Referencias.Columns.Add("Nombre")                  '2
        lsv_Referencias.Columns.Add("Sexo")                    '3
        lsv_Referencias.Columns.Add("Ocupacion")               '4
        lsv_Referencias.Columns.Add("Domicilio")               '5
        lsv_Referencias.Columns.Add("EntreCalle1")             '6
        lsv_Referencias.Columns.Add("EntreCalle2")             '7
        lsv_Referencias.Columns.Add("NumeroExt")               '8
        lsv_Referencias.Columns.Add("NumeroInt")               '9
        lsv_Referencias.Columns.Add("Colonia")                 '10
        lsv_Referencias.Columns.Add("Ciudad")                  '11
        lsv_Referencias.Columns.Add("CodigoPostal")            '12
        lsv_Referencias.Columns.Add("Telefono")                '13
        lsv_Referencias.Columns.Add("Status")                  '14

        'Aquí se actualizan los combos de DATOS VARIOS
        Id_EmpleadoIngresos = 0
        cmb_TipoVivienda.Actualizar()
        cmb_SeñasParticulares.Actualizar()
        lsv_SeñasParticulares.Columns.Add("Descripcion")
        lsv_SeñasParticulares.Columns.Add("Forma")
        lsv_SeñasParticulares.Columns.Add("Ubicacion")
        lsv_SeñasParticulares.Columns.Add("Comentarios")
        lsv_SeñasParticulares.Columns.Add("Cantidad")

        lsv_Contacto.Columns.Add("Descripción")
        lsv_Contacto.Columns.Add("Contacto")

        'Aquí se llena el listview de los Tipos de Documentos para la PAPELERIA RECIBIDA
        Call CargarPapeleriaRecibida()

        'Aquí se llena el datatable que contiene todas las empresas para usarlo en el Predictivo
        dt_PredictivoEmpresas = fn_EmpleosP_ObtenerPredictivoEmpresas()

        btn_Validar.Visible = False
        'Verifica si tiene privilegios para habilitar el botón Validar
        If UsuarioTipo = 1 Or UsuarioTipo = 3 Then
            If InStr(CadenaPermisosControles, "VALIDAR PROSPECTOS") > 0 Then
                btn_Validar.Visible = True
            End If
        Else
            btn_Validar.Visible = True
        End If
        Call BotonesCatalogo()
    End Sub

    Private Sub Tab_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tab_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        If Tab_Catalogo.SelectedIndex = 0 Then
            Tab_Nuevo.Text = "Nuevo"
            Id = 0 ' resetear ID --
            Id_Seleccionado = 0
            Clave_Seleccionado = ""
            Nombre_Seleccionado = ""

            Arreglo_Archivo = Nothing
            lsv_Catalogo.SelectedItems.Clear() '--

            Call LimpiarObjetos()
            btn_Validar.Enabled = False
            btn_Guardar_DG.Enabled = False
            btn_Agregar_Entrevista.Visible = True
            gbx_FotoProspecto.Enabled = True
            btn_GuardarRasgos.Visible = True
        Else
            'Aqui se inhabilitan todas las pestañas
            'y se habilitan hasta que se capturen los DATOS GENERALES del nuevo Prospecto
            Me.tab_DatosEscolares.Parent = Nothing
            Me.tab_RasgosPersonales.Parent = Nothing
            Me.tab_DatosFamiliares.Parent = Nothing
            Me.tab_Empleos.Parent = Nothing
            Me.tab_Referencias.Parent = Nothing
            Me.tab_DatosVarios.Parent = Nothing
            Me.tab_PapeleriaRecibida.Parent = Nothing
            Me.tab_DatosSocioEcon.Parent = Nothing
            Me.tab_Contacto.Parent = Nothing

            FamiliaresAgregados = False
            EmpleosAgregados = False
            ReferenciasAgregadas = False
            SeñasAgregadas = False

            If tbx_Clave.Text = "" Then
                'Consultar la Ultima clave de Empleado
                'If Clave_AutomaticaEmp = "S" Then
                Dim Dt_Parametros As DataTable = fn_ParametrosLocales_Read()
                If Dt_Parametros IsNot Nothing AndAlso Dt_Parametros.Rows.Count > 0 Then
                    tbx_Clave.Text = CInt(Dt_Parametros.Rows(0)("Ult_EmpleadoP")) + 1
                    tbx_Clave.Text = fn_PonerCeros(tbx_Clave.Text, 4)
                Else
                    MsgBox("No se pudo Consultar la Clave para el Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If
                'End If
                tbx_Clave.ReadOnly = True 'Clave_AutomaticaEmp = "S"
            End If

            tbx_Clave.Focus()
        End If


        Call BotonesCatalogo()
    End Sub

    Sub BotonesCatalogo()
        btn_Modificar.Enabled = lsv_Catalogo.SelectedItems.Count > 0

        btn_Visitas.Enabled = lsv_Catalogo.SelectedItems.Count > 0
        btn_Exportar.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Mapa.Enabled = lsv_Catalogo.Items.Count > 0
        btn_Baja.Enabled = False
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            btn_Baja.Enabled = lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO"
        End If
    End Sub

    Private Sub tab_Listado_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Tab_Catalogo.MouseMove, tab_DatosEmpleado.MouseMove, tab_DatosEscolares.MouseMove, tab_DatosFamiliares.MouseMove, tab_DatosGenerales.MouseMove, tab_DatosSocioEcon.MouseMove, tab_DatosVarios.MouseMove, tab_Empleos.MouseMove, tab_Listado.MouseMove, Tab_Nuevo.MouseMove, tab_PapeleriaRecibida.MouseMove, tab_RasgosPersonales.MouseMove, tab_Referencias.MouseMove
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        If Asc(e.KeyChar) = 13 Then
            Call Buscar()
        End If
    End Sub

    Private Sub BTN_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click
        SegundosDesconexion = 0

        Call Buscar()
    End Sub

    Private Sub chk_DepartamentoFiltro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_DepartamentoFiltro.CheckedChanged

        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_DepartamentoFiltro.SelectedValue = 0
        cmb_DepartamentoFiltro.Enabled = Not chk_DepartamentoFiltro.Checked

        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 AndAlso Not chk_DepartamentoFiltro.Checked Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If

        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub chk_PuestoFiltro_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_PuestoFiltro.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        cmb_PuestoFiltro.SelectedValue = 0
        cmb_PuestoFiltro.Enabled = Not chk_PuestoFiltro.Checked
        Call BotonesCatalogo()
        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub btn_MostrarCatalogo_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MostrarCatalogo.Click
        SegundosDesconexion = 0

        Call LlenarListaProspectos()
    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Id = lsv_Catalogo.SelectedItems(0).Tag
        Else
            Id = 0
        End If
        Call BotonesCatalogo()
    End Sub

    Private Sub BTN_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click, lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Id_Seleccionado = 0
        If Not btn_Modificar.Enabled Then Exit Sub

        'Activar o Desactivar los Botones de Edición dependiendo del Estatus del Prospecto
        'A un Prospecto VALIDADO ya no se le puede editar nada
        Id_Seleccionado = lsv_Catalogo.SelectedItems(0).Tag
        Dim Activo As Boolean = lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "ACTIVO"
        btn_Agregar_Entrevista.Visible = Activo
        gbx_FotoProspecto.Enabled = Activo
        gbx_FrenteFormal.Enabled = Activo
        btn_GuardarRasgos.Visible = Activo

        btn_Agregar_Curso.Visible = Activo
        btn_Guardar_DatosEscolares.Visible = Activo
        btn_Modificar_DatosEscolares.Visible = Activo
        btn_Borrar_DatosEscolares.Visible = Activo

        btn_Agregar_Familiares.Visible = Activo
        btn_Guardar_Familiares.Visible = Activo
        btn_Modificar_Familiares.Visible = Activo
        btn_Borrar_DatosFamiliares.Visible = Activo

        btn_Agregar_Empleos.Visible = Activo
        btn_Guardar_Empleos.Visible = Activo
        btn_Modificar_Empleos.Visible = Activo
        btn_Borrar_Empleos.Visible = Activo

        btn_Agregar_Referencias.Visible = Activo
        btn_Guardar_Referencias.Visible = Activo
        btn_Modificar_Referencias.Visible = Activo
        btn_Borrar_Referencias.Visible = Activo

        btn_Agregar_Señas.Visible = Activo
        btn_Guardar_DatosVarios.Visible = Activo
        btn_Modificar_DatosVarios.Visible = Activo
        btn_Borrar_DatosVarios.Visible = Activo

        lsv_PapeleriaRecibida.Enabled = Activo
        btn_Guardar_PapeleriaRecibida.Visible = Activo
        btn_DoctosImportar.Visible = Activo

        'Aqui se llenan los DATOS GENERALES del Empleado seleccionado
        Call LlenarDG(Id)

        'Aquí se llenan todos los datos de las demas pestañas del Empleado seleccionado
        Call LlenarMasDatos(Id)
    End Sub

    Private Sub btn_Visitas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Visitas.Click
        SegundosDesconexion = 0

        Cn_Login.fn_Log_Create("CREAR VISITA DOMICILIARIA DEL PROSPECTO: " & lsv_Catalogo.SelectedItems(0).Text & " - " & lsv_Catalogo.SelectedItems(0).SubItems(1).Text)

        Dim frm As New frm_VisitaDomiciliaria
        frm.Id_EmpleadoP = lsv_Catalogo.SelectedItems(0).Tag
        frm.Clave = lsv_Catalogo.SelectedItems(0).Text
        frm.Nombre = lsv_Catalogo.SelectedItems(0).SubItems(1).Text
        If lsv_Catalogo.SelectedItems(0).SubItems(4).Text = "VALIDADO" Then
            frm.btn_Nuevo.Visible = False
            frm.btn_Modificar.Visible = False
            frm.btn_Importar.Location = New Point(6, 253)
        End If
        frm.ShowDialog()
    End Sub

    Private Sub BTN_Exportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Exportar.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Catalogo, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Mapa_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Mapa.Click
        SegundosDesconexion = 0

        If lsv_Catalogo.Items.Count = 0 Then
            MsgBox("No existe información capturada, por lo tanto no se pueden mostrar los puntos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        Else
            Dim frm As New frm_MapasGo
            frm.Text = "Mapa de Localización de Prospectos."
            frm.Lsv_Lista = lsv_Catalogo
            frm.ColLat = 5
            frm.ColLon = 6
            frm.Nombre = "0+1"
            frm.ZoomdelMapa = 12
            frm.ShowDialog()

        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        'Aqui se cierra la ventana
        Me.Close()
    End Sub

    Public Sub LimpiarObjetos()
        LimpiaTodo = True
        Call LimpiarEntrevistas()
        Call LimpiarFoto()
        Call DatosGenerales_LimpiarObjetos()
        Call Rasgos_LimpiarObjetos()
        Call DatosEscolares_LimpiarObjetos()
        Call Cursos_LimpiarObjetos()
        Call DatosFamiliares_LimpiarObjetos()
        Call Empleos_LimpiarObjetos()
        Call Referencias_LimpiarObjetos()
        Call DatosVarios_LimpiarObjetos()
        Call Señas_LimpiarObjetos()
    End Sub

    Sub Buscar()
        Dim Fila_Inicio As Integer = 0
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Catalogo.SelectedItems(0).Index + 1
        End If
        If fn_Buscar_enListView(lsv_Catalogo, tbx_Buscar.Text, 0, Fila_Inicio) Then
            btn_Modificar.Enabled = True
        Else
            btn_Modificar.Enabled = False
        End If
    End Sub

    Sub LlenarListaProspectos()
        If cmb_DepartamentoFiltro.SelectedValue Is Nothing Then Exit Sub
        If cmb_PuestoFiltro.SelectedValue Is Nothing Then Exit Sub

        If Dtp_Desde.Value.Date > Dtp_Hasta.Value.Date Then
            MsgBox("Las Fechas son Incorrectas", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Day, Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date) > 366 Then
            MsgBox("El rango de fechas maximo es de un año.", MsgBoxStyle.Critical, frm_MENU.Text)
            Dtp_Desde.Focus()
            Exit Sub
        End If

        If cmb_DepartamentoFiltro.Enabled AndAlso cmb_DepartamentoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DepartamentoFiltro.Focus()
            Exit Sub
        End If
        If cmb_PuestoFiltro.Enabled AndAlso cmb_PuestoFiltro.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_PuestoFiltro.Focus()
            Exit Sub
        End If
        If cmb_Status.Enabled And cmb_Status.SelectedValue = "0" Then
            If Tab_Catalogo.SelectedIndex = 0 Then
                MsgBox("Seleccione un Status para Filtrar la consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Status.Focus()
                Exit Sub
            End If
        End If

        If cmb_aptos.Enabled And cmb_aptos.SelectedValue = "0" Then
            MsgBox("Seleccione si desea mostar solo Aptos o No Aptos.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_aptos.Focus()
            Exit Sub
        End If

        Dim St As String
        If chk_Status.Checked Then
            St = "T"
        Else
            St = cmb_Status.SelectedValue
        End If

        Dim Apto As String
        If chk_Aptos.Checked Then
            Apto = "T"
        Else
            Apto = cmb_aptos.SelectedValue
        End If
        Me.Cursor = Cursors.WaitCursor
        lsv_Catalogo.Items.Clear()

        'Aqui se llena la lista
        If Not fn_Prospectos_LlenarLista(lsv_Catalogo, cmb_DepartamentoFiltro.SelectedValue, cmb_PuestoFiltro.SelectedValue, St, Dtp_Desde.Value.Date, Dtp_Hasta.Value.Date, Apto) Then
            MsgBox("Ocurrió un error al intentar mostrar el Catálogo de Prospectos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        'Aqui se ocultan y se muestran los botones de reporte
        Call BotonesCatalogo()
        Me.Cursor = Cursors.Default

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)

    End Sub

    Private Sub chk_Status_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Status.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Call BotonesCatalogo()
        cmb_Status.SelectedValue = 0
        cmb_Status.Enabled = Not chk_Status.Checked
        Lbl_Numero.Text = "Empleados: 0"
    End Sub

#End Region

#Region "DATOS GENERALES"

    Private Sub tbx_Nombres_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Nombres.TextChanged
        Call NombreCompleto()
    End Sub

    Private Sub tbx_ApellidoPaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ApellidoPaterno.TextChanged
        Call NombreCompleto()
    End Sub

    Private Sub tbx_ApellidoMaterno_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_ApellidoMaterno.TextChanged
        Call NombreCompleto()
    End Sub

    Sub NombreCompleto()
        tbx_NombreCompleto.Text = tbx_Nombres.Text.Trim & " " & tbx_ApellidoPaterno.Text.Trim & " " & tbx_ApellidoMaterno.Text.Trim
        If Trim(tbx_NombreCompleto.Text) = "" Then
            tbx_NombreCompleto.Clear()
            btn_ComprobarListaNegra.Enabled = False
        Else
            btn_ComprobarListaNegra.Enabled = True
        End If
    End Sub

    Private Sub btn_ComprobarListaNegra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ComprobarListaNegra.Click
        SegundosDesconexion = 0

        If Trim(tbx_NombreCompleto.Text) = "" Then Exit Sub

        'Revisar si existe en la lista negra
        Dim frm As New Frm_BuscarCliente
        frm.Nombres = tbx_Nombres.Text.Trim
        frm.APaterno = tbx_ApellidoPaterno.Text.Trim
        frm.AMaterno = tbx_ApellidoMaterno.Text.Trim
        frm.Consulta = Frm_BuscarCliente.Query.ListaNegra

        frm.MaximizeBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frm.ShowDialog()

        If frm.lsv_Clientes.Items.Count > 0 AndAlso
        MsgBox("El Prospecto tuvo coincidencias en la Lista Negra, aún desea agregarlo?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
            btn_Guardar_DG.Enabled = False
            Exit Sub
        End If

        'Revisar si ya existe como prospecto
        frm = New Frm_BuscarCliente
        frm.Nombres = tbx_Nombres.Text.Trim
        frm.APaterno = tbx_ApellidoPaterno.Text.Trim
        frm.AMaterno = tbx_ApellidoMaterno.Text.Trim
        frm.Consulta = Frm_BuscarCliente.Query.ProspectosExistentes
        frm.MaximizeBox = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frm.ShowDialog()

        btn_Guardar_DG.Enabled = True
        If frm.Id <> 0 Then
            Id = frm.Id
            Id_Seleccionado = frm.Id
            Call LlenarDG(Id)
            Call LlenarMasDatos(Id)
        End If
    End Sub

    Sub LlenarDG(ByVal Id_Prospecto As Integer)
        'Aqui se obtienen los DATOS GENERALES del Empleado seleccionado
        Dim Dr_Datos As DataRow = fn_Prospectos_Read(Id_Prospecto)

        If Not Dr_Datos Is Nothing Then
            tbx_Clave.Text = Dr_Datos("Clave_EmpleadoP")
            tbx_Clave.ReadOnly = True 'nuevo 29/03/2014
            'para controlar la pepeleria recibida
            Clave_Seleccionado = Dr_Datos("Clave_EmpleadoP")
            Nombre_Seleccionado = Dr_Datos("Nombre")
            '*****************************************
            tbx_NombreCompleto.Text = Dr_Datos("Nombre")
            cmb_Departamento_DG.SelectedValue = Dr_Datos("Id_Departamento")
            cmb_Puesto.SelectedValue = Dr_Datos("Id_Puesto")
            cmb_EstadoCivil.SelectedValue = Dr_Datos("Id_EstadoCivil")
            cmb_Ciudades_DG.SelectedValue = Dr_Datos("Id_Ciudad")
            cmb_Zonas.SelectedValue = Dr_Datos("Zona")
            tbx_Mail.Text = Dr_Datos("Mail")
            cmb_Genero.SelectedValue = Dr_Datos("Sexo")
            cmb_CatalogoFirmas.SelectedValue = Dr_Datos("Catalogo")
            tbx_SueldoBase.Text = Dr_Datos("Sueldo_Diario")
            tbx_Calle.Text = Dr_Datos("Calle")
            tbx_NumExterior.Text = Dr_Datos("Numero")
            tbx_NumInterior.Text = Dr_Datos("NumeroInt")
            ' tbx_Colonia.Text = Dr_Datos("Colonia")
            cmb_Colonias.Text = Dr_Datos("Colonia")
            tbx_CodigoPostal.Text = Dr_Datos("CP")
            tbx_Telefono1.Text = Dr_Datos("Telefono")
            tbx_TelefonoMovil1.Text = Dr_Datos("Telefono_Movil")
            dtp_FechaNac.Value = Dr_Datos("Fecha_Nacimiento")
            cmb_Pais.SelectedValue = Dr_Datos("PaisNac")
            cmb_Estado.SelectedValue = Dr_Datos("EstadoNacimiento")
            cmb_Ciudad.SelectedValue = Dr_Datos("CiudadNacimiento")
            cmb_ModoContacto.SelectedValue = Dr_Datos("Id_ModoContacto")
            cmb_ModoContactoD.SelectedValue = Dr_Datos("Id_ModoContactoD")

            tbx_RFC.Text = Dr_Datos("RFC")
            tbx_IdTributario.Text = Dr_Datos("IdTributario")

            tbx_CURP.Text = Dr_Datos("CURP")
            tbx_IMSS.Text = Dr_Datos("Numero_Seguro")
            tbx_Elector.Text = Dr_Datos("Clave_Elector")
            cmb_TipoLicencia.SelectedValue = Dr_Datos("Tipo_Licencia")

            If Dr_Datos("Vence_Licencia") Is DBNull.Value Then
                dtp_FechaExpira.Value = #1/1/1900#
            Else
                dtp_FechaExpira.Value = Dr_Datos("Vence_Licencia")
            End If

            If Dr_Datos("Vence_LicenciaFed") Is DBNull.Value Then
                dtp_FechaExpiraFed.Value = #1/1/1900#
            Else
                dtp_FechaExpiraFed.Value = Dr_Datos("Vence_LicenciaFed")
            End If

            tbx_NumCartilla.Text = Dr_Datos("Numero_Cartilla")
            tbx_NumeroLicencia.Text = Dr_Datos("NumeroLicencia")
            tbx_NumeroLicenciaFed.Text = Dr_Datos("NumeroLicenciaFed")

            cmb_CertifAcademia.SelectedValue = Dr_Datos("Certificacion_Academia")
            cmb_ViveConFam.SelectedValue = Dr_Datos("Vive_ConFamilia")
            tbx_CantidadHijos.Text = Dr_Datos("Cantidad_Hijos")
            tbx_Edad.Text = Dr_Datos("Edad")
            dtp_FechaIngreso.Value = Dr_Datos("FechaIngreso")
            tbx_ApellidoPaterno.Text = Dr_Datos("APaterno")
            tbx_ApellidoMaterno.Text = Dr_Datos("AMaterno")
            tbx_Nombres.Text = Dr_Datos("Nombres")
            cmb_EmpleadoReferencia.SelectedValue = Dr_Datos("Id_EmpleadoRef")
            tbx_EntreCalle1.Text = Dr_Datos("Entre_Calle1")
            tbx_EntreCalle2.Text = Dr_Datos("Entre_Calle2")
            cmb_ModoNacionalidad.SelectedValue = Dr_Datos("Modo_Nacionalidad")
            dtp_FechaNaturalizacion.Value = Dr_Datos("Fecha_Naturalizacion")
            tbx_Pasaporte.Text = Dr_Datos("Numero_Pasaporte")
            cmb_JefeArea.SelectedValue = Dr_Datos("Jefe_Area")
            cmb_Ruta.SelectedValue = Dr_Datos("SaleRuta")

            'Aquí se llenan los Datos Varios
            tbx_Vicios.Text = Dr_Datos("Vicios")
            tbx_Idiomas.Text = Dr_Datos("Idiomas")
            tbx_ActividadesCulturales.Text = Dr_Datos("ActivDepCult")
            tbx_Habilidades.Text = Dr_Datos("Habilidades")
            tbx_Latitud.Text = Dr_Datos("Latitud")
            tbx_Longitud.Text = Dr_Datos("Longitud")
            tbx_UMF.Text = Dr_Datos("UMF")

            'INFONAVIT
            If Dr_Datos("CreditoInfonavit") = "" Then
                cmb_CreditoInfonavit.SelectedValue = "0"
            Else
                cmb_CreditoInfonavit.SelectedValue = Dr_Datos("CreditoInfonavit")
            End If
            tbx_NumeroCredito.Text = Dr_Datos("Numero_Credito")
            If Dr_Datos("Tipo_Descuento") = "" Then
                cmb_TipoDescuento.SelectedValue = "0"
            Else
                cmb_TipoDescuento.SelectedValue = Dr_Datos("Tipo_Descuento")
            End If
            tbx_MontoDescuento.Text = Dr_Datos("Monto_Descuento")
            'Fin INFONAVIT

            If Dr_Datos("VerificaServicios") = "" Then
                cmb_Verifica.SelectedValue = "0"
            Else
                cmb_Verifica.SelectedValue = Dr_Datos("VerificaServicios")
            End If

            Select Case Dr_Datos("Status")
                Case "ACTIVO"
                    btn_Validar.Enabled = True
                    btn_Guardar_DG.Enabled = True

                Case "BAJA"
                    btn_Guardar_DG.Enabled = True

                Case "VALIDADO"
                    btn_Guardar_DG.Enabled = False
                    MsgBox("El Prospecto ya se encuentra Validado, se debe de revisar el Catálogo de Empleados.", MsgBoxStyle.Information, frm_MENU.Text)

            End Select
        End If
        PuestoPrevio = cmb_Puesto.SelectedValue
    End Sub

    Private Sub cmb_Puesto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Puesto.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Puesto.SelectedValue = fn_ParametrosGlobales(ParametrosGlobales.Puesto_Cajero) Then
            cmb_Genero.SelectedValue = "F"
        Else
            cmb_Genero.SelectedValue = "M"
        End If
    End Sub

    Private Sub dtp_FechaNac_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaNac.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then tbx_Edad.Focus()
    End Sub

    Private Sub cmb_ModoNacionalidad_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_ModoNacionalidad.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If dtp_FechaNaturalizacion.Enabled Then
                dtp_FechaNaturalizacion.Focus()
            Else
                cmb_ModoContacto.Focus()
            End If
        End If
    End Sub

    Private Sub dtp_FechaNaturalizacion_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaNaturalizacion.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_ModoContacto.Focus()
    End Sub

    Private Sub dtp_FechaExpira_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaExpira.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_FechaExpiraFed.Focus()
    End Sub

    Private Sub dtp_FechaIngreso_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaIngreso.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_EmpleadoReferencia.Focus()
    End Sub

    Private Sub tbx_CodigoPostal_Leave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_UMF.Click
        If tbx_CodigoPostal.Text = "" Then tbx_CodigoPostal.Text = "0"
        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.UMF
        frm.CP = CInt(tbx_CodigoPostal.Text)
        frm.Lbl_Nota.Text = "Doble Click para Seleccionar una UMF y cerrar la ventana de búsqueda."
        frm.ShowDialog()

        If frm.UMF > 0 Then
            tbx_UMF.Text = fn_PonerCeros(frm.UMF, 3)
        Else
            tbx_UMF.Text = ""
        End If
    End Sub

    Private Sub cmb_Ciudades_DG_SelectedValueChanged_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Ciudades_DG.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Ciudades_DG.Items.Count = 0 Then Exit Sub


        If cmb_Ciudades_DG.SelectedValue Is Nothing Then Exit Sub
        If cmb_Ciudades_DG.SelectedValue = 0 Then
            cmb_Zonas.ActualizaValorParametro("@Id_Ciudad", -1)
            cmb_Colonias.ActualizaValorParametro("@Id_Ciudad", -1)
        Else
            cmb_Zonas.ActualizaValorParametro("@Id_Ciudad", cmb_Ciudades_DG.SelectedValue)
            cmb_Colonias.ActualizaValorParametro("@Id_Ciudad", cmb_Ciudades_DG.SelectedValue)
        End If
        'cmb_Zonas.ValorParametro = cmb_Ciudades_DG.SelectedValue
        cmb_Zonas.Actualizar()
        cmb_Colonias.Actualizar()
    End Sub

    Private Sub dtp_FechaNac_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaNac.Enter
        If dtp_FechaNac.Value = #1/1/1900# Then
            dtp_FechaNac.Value = Today '.AddYears(-30)
        End If
    End Sub

    Private Sub dtp_FechaNaturalizacion_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaNaturalizacion.Enter
        If dtp_FechaNaturalizacion.Value = #1/1/1900# Then
            dtp_FechaNaturalizacion.Value = Today
        End If
    End Sub

    Private Sub dtp_FechaExpira_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaExpira.Enter
        If dtp_FechaExpira.Value = #1/1/1900# Then
            dtp_FechaExpira.Value = Today
        End If
    End Sub

    Private Sub cmb_ModoNacionalidad_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ModoNacionalidad.SelectedIndexChanged
        SegundosDesconexion = 0

        dtp_FechaNaturalizacion.Enabled = cmb_ModoNacionalidad.SelectedValue = 2
    End Sub

    Private Sub dtp_FechaNac_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaNac.ValueChanged
        SegundosDesconexion = 0

        tbx_Edad.Text = Microsoft.VisualBasic.Left((DateDiff(DateInterval.Month, dtp_FechaNac.Value.Date, Today.Date) / 12), 2)
    End Sub

    Private Sub btn_CURP_RFC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CURP.Click, btn_RFC.Click
        SegundosDesconexion = 0

        If sender.Equals(btn_CURP) Then
            tbx_CURP.Clear()
        ElseIf sender.Equals(btn_RFC) Then
            tbx_RFC.Clear()
            tbx_IdTributario.Clear()
        End If

        If tbx_Nombres.Text = "" Then
            MsgBox("Indique el Nombre del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombres.Focus()
            Exit Sub
        End If
        If tbx_ApellidoPaterno.Text = "" Then
            MsgBox("Indique el Apellido Paterno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ApellidoPaterno.Focus()
            Exit Sub
        End If
        If tbx_ApellidoMaterno.Text = "" Then
            MsgBox("Indique el Apellido Materno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ApellidoMaterno.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Year, dtp_FechaNac.Value.Date, Today.Date) > 70 OrElse DateDiff(DateInterval.Year, dtp_FechaNac.Value.Date, Today.Date) < 17 Then
            MsgBox("Indique una Fecha de Nacimiento Válida.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaNac.Focus()
            Exit Sub
        End If

        If sender.Equals(btn_CURP) Then
            Dim Sexo As String
            Select Case cmb_Genero.SelectedValue
                Case "0"
                    MsgBox("Indique el Género del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Genero.Focus()
                    Exit Sub

                Case "M"
                    Sexo = "H"

                Case "F"
                    Sexo = "M"
            End Select

            If cmb_Estado.SelectedValue = 0 Then
                MsgBox("Indique el Estado en el que nació el Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_Estado.Focus()
                Exit Sub
            End If

            Dim Dt_EstadosPrefijo As DataTable = cmb_Estado.DataSource
            Dim Prefijo As String
            Try
                For Each Elemento As DataRow In Dt_EstadosPrefijo.Rows
                    If Elemento("Id_Estado") = cmb_Estado.SelectedValue Then
                        Prefijo = Elemento("Prefijo")
                        Exit For
                    End If
                Next
                tbx_CURP.Text = FuncionesGlobales.fn_CalcularCUPR(tbx_Nombres.Text, tbx_ApellidoPaterno.Text, tbx_ApellidoMaterno.Text, dtp_FechaNac.Value.Date, Sexo, Prefijo)
                MsgBox("Verifique el CURP calculado con un Documento Oficial.", MsgBoxStyle.Information, frm_MENU.Text)
            Catch
            End Try
        ElseIf sender.Equals(btn_RFC) Then
            Try
                tbx_RFC.Text = FuncionesGlobales.fn_CalcularRFC(tbx_Nombres.Text, tbx_ApellidoPaterno.Text, tbx_ApellidoMaterno.Text, dtp_FechaNac.Value.Date)
                MsgBox("Verifique el RFC calculado con un Documento Oficial.", MsgBoxStyle.Information, frm_MENU.Text)
            Catch
            End Try
        End If
    End Sub

    Private Sub cmb_Pais_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Pais.SelectedValueChanged
        SegundosDesconexion = 0
        If cmb_Pais.Items.Count > 0 Then
            cmb_Estado.ActualizaValorParametro("@Id_Pais", cmb_Pais.SelectedValue)
            cmb_Estado.Actualizar()
            If cmb_Pais.SelectedValue = 1 Then
                cmb_ModoNacionalidad.SelectedValue = "1"
            Else
                cmb_ModoNacionalidad.SelectedValue = "0"
            End If
        End If
    End Sub

    Private Sub cmb_Estado_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Estado.SelectedValueChanged
        SegundosDesconexion = 0
        If cmb_Estado.Items.Count > 0 Then
            cmb_Ciudad.ActualizaValorParametro("@Id_Estado", cmb_Estado.SelectedValue)
            cmb_Ciudad.Actualizar()
        End If
    End Sub

    Private Sub cmb_ModoContacto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_ModoContacto.SelectedValueChanged
        If cmb_ModoContacto.Items.Count > 0 Then
            cmb_ModoContactoD.ActualizaValorParametro("@Id_ModoContacto", cmb_ModoContacto.SelectedValue)
            cmb_ModoContactoD.Actualizar()
        End If
    End Sub

    Private Sub DatosGenerales_LimpiarObjetos()
        tbx_NombreCompleto.Clear()
        tbx_Nombres.Clear()
        tbx_ApellidoPaterno.Clear()
        tbx_ApellidoMaterno.Clear()
        tbx_Clave.Clear()
        tbx_Clave.ReadOnly = False '--
        cmb_Departamento_DG.SelectedValue = 0
        cmb_Puesto.SelectedValue = 0
        cmb_EstadoCivil.SelectedValue = 0
        tbx_Mail.Clear()
        tbx_SueldoBase.Clear()
        tbx_Calle.Clear()
        tbx_NumExterior.Clear()
        tbx_NumInterior.Clear()
        cmb_Colonias.SelectedValue = 0
        ' tbx_Colonia.Clear()
        tbx_CodigoPostal.Clear()
        cmb_Ciudades_DG.SelectedValue = 0
        cmb_Zonas.SelectedValue = 0
        tbx_Telefono1.Clear()
        tbx_TelefonoMovil1.Clear()
        cmb_Ciudad.SelectedValue = 0
        cmb_Estado.SelectedValue = 0
        cmb_Pais.SelectedValue = 0
        dtp_FechaNac.Value = #1/1/1900#
        cmb_Genero.SelectedValue = "0"
        cmb_ViveConFam.SelectedValue = "0"
        tbx_CantidadHijos.Clear()
        tbx_Edad.Clear()
        tbx_Elector.Clear()

        tbx_RFC.Clear()
        tbx_IdTributario.Clear()

        tbx_CURP.Clear()
        tbx_IMSS.Clear()

        tbx_NumCartilla.Clear()
        tbx_NumeroLicencia.Clear()

        cmb_TipoLicencia.SelectedValue = 0

        dtp_FechaExpira.Value = #1/1/1900#
        dtp_FechaExpiraFed.Value = #1/1/1900#

        cmb_CertifAcademia.SelectedValue = "0"
        cmb_CatalogoFirmas.SelectedValue = "0"
        dtp_FechaIngreso.Value = Today.ToShortDateString
        tbx_Fecha_FinLabores.Clear()
        cmb_EmpleadoReferencia.SelectedValue = 0
        cmb_ModoNacionalidad.SelectedValue = 0
        tbx_Pasaporte.Clear()
        tbx_EntreCalle1.Clear()
        tbx_EntreCalle2.Clear()
        dtp_FechaNaturalizacion.Value = #1/1/1900#
        cmb_JefeArea.SelectedValue = "0"
        tbx_Latitud.Clear()
        tbx_Longitud.Clear()
        tbx_UMF.Clear()
        cmb_Ruta.SelectedValue = "0"
        cmb_CreditoInfonavit.SelectedValue = "0"
        tbx_NumeroCredito.Clear()
        cmb_TipoDescuento.SelectedValue = "0"
        tbx_MontoDescuento.Clear()
        cmb_ModoContactoD.SelectedValue = 0
        cmb_ModoContacto.SelectedValue = 0
        Call LimpiarEntrevistas()
        Call LimpiarFoto()
    End Sub

    Private Sub btn_Guardar_DG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.F2, btn_Guardar_DG.Click
        SegundosDesconexion = 0

        If cmb_Colonias.Text = "Seleccione..." Then
            MsgBox("Favor de seleccionar una colonia", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If tbx_Clave.Text.Trim = "" Then
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            MsgBox("Indique la clave del prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Clave.Focus()
            Exit Sub
        End If

        If tbx_Nombres.Text.Trim = "" Then
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            MsgBox("Indique el Nombre del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombres.Focus()
            Exit Sub
        End If
        If tbx_ApellidoPaterno.Text.Trim = "" Then
            MsgBox("Indique el Apellido Paterno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            tbx_ApellidoPaterno.Focus()
            Exit Sub
        End If
        If tbx_ApellidoMaterno.Text.Trim = "" Then
            MsgBox("Indique el Apellido Materno del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            tbx_ApellidoMaterno.Focus()
            Exit Sub
        End If
        If cmb_Departamento_DG.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Departamento_DG.Focus()
            Exit Sub
        End If
        If cmb_Puesto.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Puesto.Focus()
            Exit Sub
        End If

        If InStr(tbx_NumExterior.Text.Trim, "-") Then
            tbx_NumExterior.Text = Replace(tbx_NumExterior.Text, "-", "")
        End If

        If cmb_Ciudades_DG.SelectedValue <> 0 Then
            If cmb_Zonas.SelectedValue = 0 Then
                MsgBox("Seleccione la Zona.", MsgBoxStyle.Critical, frm_MENU.Text)
                tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
                cmb_Zonas.Focus()
                Exit Sub
            End If
        End If
        If cmb_Genero.SelectedValue = "0" Then
            MsgBox("Indique el Género del Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Genero.Focus()
            Exit Sub
        End If
        If cmb_ViveConFam.SelectedValue = "0" Then
            MsgBox("Indique si Vive con su Familia.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_ViveConFam.Focus()
            Exit Sub
        End If
        If cmb_Ciudad.SelectedValue = 0 Then
            MsgBox("Indique la Ciudad en el que nació el Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Ciudad.Focus()
            Exit Sub
        End If
        If cmb_ModoContactoD.SelectedValue = 0 Then
            MsgBox("Seleccione la Especificación del Modo de Contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_ModoContactoD.Focus()
            Exit Sub
        End If
        If tbx_UMF.Text = "" Then
            MsgBox("Indique la Unidad de Medicina Familiar (UMF).", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            tbx_UMF.Focus()
            Exit Sub
        End If
        If cmb_CatalogoFirmas.SelectedValue = "0" Then
            MsgBox("Indique si aparecerá o no en el Catálogo de Firmas.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_CatalogoFirmas.Focus()
            Exit Sub
        End If
        If cmb_CertifAcademia.SelectedValue = "0" Then
            MsgBox("Indique si tiene Certificación Académica.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_CertifAcademia.Focus()
            Exit Sub
        End If
        If cmb_JefeArea.SelectedValue = "0" Then
            MsgBox("Indique si será Jefe de Área.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_JefeArea.Focus()
            Exit Sub
        End If
        If cmb_Ruta.SelectedValue = "0" Then
            MsgBox("Indique si el Prospecto saldrá o no a Ruta (TV o ATMs).", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Ruta.Focus()
            Exit Sub
        End If
        If cmb_CreditoInfonavit.SelectedValue = "0" Then
            MsgBox("Indique si tiene Crédito Infonavit.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_CreditoInfonavit.Focus()
            Exit Sub
        End If
        If cmb_CreditoInfonavit.SelectedValue = "S" Then
            If tbx_NumeroCredito.Text.Trim = "" Then
                MsgBox("Indique el Número de Crédito Infonavit.", MsgBoxStyle.Critical, frm_MENU.Text)
                tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
                tbx_NumeroCredito.Focus()
                Exit Sub
            End If
            If cmb_TipoDescuento.SelectedValue = "0" Then
                MsgBox("Indique el Tipo de Descuento del Crédito Infonavit.", MsgBoxStyle.Critical, frm_MENU.Text)
                tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
                cmb_TipoDescuento.Focus()
                Exit Sub
            End If
            If tbx_MontoDescuento.Text.Trim = "" Then
                MsgBox("Indique el Monto del Descuento del Crédito Infonavit.", MsgBoxStyle.Critical, frm_MENU.Text)
                tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
                tbx_MontoDescuento.Focus()
                Exit Sub
            End If
            If cmb_TipoDescuento.SelectedValue = "P" Then
                If CDec(tbx_MontoDescuento.Text.Trim) > 100 Then
                    MsgBox("El monto del descuento Infonavit parece ser incorrecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
                    tbx_MontoDescuento.Focus()
                    tbx_MontoDescuento.SelectAll()
                    Exit Sub
                End If
            End If
        End If

        If cmb_Verifica.SelectedValue = "0" Then
            MsgBox("Indique si el Prospecto verificará depósitos o no (Proceso, Morralla o ATMs).", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectTab(tab_DatosGenerales)
            cmb_Verifica.Focus()
            Exit Sub
        End If

        If tbx_IMSS.Text.Trim = "" Then tbx_IMSS.Text = 0
        If tbx_Edad.Text.Trim = "" Then tbx_Edad.Text = 0
        If tbx_SueldoBase.Text.Trim = "" Then tbx_SueldoBase.Text = 0
        If tbx_CantidadHijos.Text.Trim = "" Then tbx_CantidadHijos.Text = 0
        If tbx_NumExterior.Text.Trim = "" Then tbx_NumExterior.Text = 0
        If tbx_CodigoPostal.Text.Trim = "" Then tbx_CodigoPostal.Text = 0
        If tbx_Latitud.Text.Trim = "" Then tbx_Latitud.Text = 0
        If tbx_Longitud.Text.Trim = "" Then tbx_Longitud.Text = 0
        If tbx_MontoDescuento.Text.Trim = "" Then tbx_MontoDescuento.Text = 0

        If ValidarCodigoPostalGuardar() Then
            MsgBox("El codigo Postal esta erroneo", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If


        tbx_NombreCompleto.Text = (tbx_Nombres.Text.Trim & " " & tbx_ApellidoPaterno.Text.Trim & " " & tbx_ApellidoMaterno.Text.Trim)
        Dim LugarNac As String = cmb_Estado.Text & ", " & cmb_Ciudad.Text

        If Tab_Nuevo.Text = "Nuevo" Then

            If Cn_Reclutamiento.fn_EmpleadosP_ValidarClave(tbx_Clave.Text.Trim) Then
                'En caso de que la Clave capturada ya exista
                'Es Nuevo Ingreso y le debo sugerir la siguiente clave
                'Consultar la Ultima clave de Prospecto para sugerirla
                'If Clave_AutomaticaEmp = "S" Then
                Dim Dt_Parametros As DataTable = fn_ParametrosLocales_Read()
                Dim Clave_Sugerida As String = "0001"

                If Dt_Parametros IsNot Nothing AndAlso Dt_Parametros.Rows.Count > 0 Then
                    Clave_Sugerida = CInt(Dt_Parametros.Rows(0)("Ult_EmpleadoP")) + 1
                    Clave_Sugerida = FuncionesGlobales.fn_PonerCeros(Clave_Sugerida, 4)
                Else
                    MsgBox("No se pudo Consultar la Clave para el Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                If MsgBox("La Clave " & tbx_Clave.Text & " ya existe." & Chr(13) & "Desea continuar y asignar la Clave Siguiente: " & Clave_Sugerida, MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                    tbx_Clave.Text = Clave_Sugerida
                Else
                    MsgBox("No se guardó el registro del Prospecto.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                    Exit Sub
                End If
                'Else
                '    MsgBox("La Clave ya Existe Capture una Nueva.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                '    tbx_Clave.Focus()
                '    Exit Sub
                'End If
            End If

            'Si se esta Insertando un nuevo Prospecto
            Id = fn_EmpleadosP_Nuevo(tbx_Clave.Text.Trim, tbx_NombreCompleto.Text.Trim, cmb_Departamento_DG.SelectedValue,
                                     cmb_Puesto.SelectedValue, cmb_Genero.SelectedValue, cmb_EstadoCivil.SelectedValue,
                                     tbx_Mail.Text.Trim,
                                    cmb_CatalogoFirmas.SelectedValue, tbx_ApellidoPaterno.Text.Trim,
                                    tbx_ApellidoMaterno.Text.Trim, tbx_Nombres.Text.Trim, tbx_SueldoBase.Text,
                                    tbx_Calle.Text, tbx_NumExterior.Text,
                                    tbx_NumInterior.Text, cmb_Colonias.Text, cmb_Zonas.SelectedValue,
                                    tbx_CodigoPostal.Text, tbx_Telefono1.Text, tbx_TelefonoMovil1.Text,
                                    dtp_FechaNac.Value, LugarNac, tbx_RFC.Text, tbx_CURP.Text,
                                    tbx_IMSS.Text, tbx_Elector.Text, cmb_TipoLicencia.SelectedValue,
                                    dtp_FechaExpira.Value,
                                    tbx_NumCartilla.Text, cmb_CertifAcademia.SelectedValue,
                                    cmb_ViveConFam.SelectedValue,
                                    tbx_CantidadHijos.Text, tbx_Edad.Text, cmb_EmpleadoReferencia.SelectedValue,
                                    tbx_EntreCalle1.Text, tbx_EntreCalle2.Text, cmb_ModoNacionalidad.SelectedValue,
                                    cmb_Pais.Text,
                                    dtp_FechaNaturalizacion.Value, tbx_Pasaporte.Text, cmb_JefeArea.SelectedValue,
                                    tbx_Latitud.Text, tbx_Longitud.Text, tbx_UMF.Text, cmb_ModoContactoD.SelectedValue,
                                    lsv_Entrevistas,
                                    cmb_Ruta.SelectedValue, cmb_CreditoInfonavit.SelectedValue, cmb_Verifica.SelectedValue,
                                    cmb_Ciudad.SelectedValue, tbx_NumeroCredito.Text.Trim,
                                    cmb_TipoDescuento.SelectedValue, CDec(tbx_MontoDescuento.Text.Trim),
                                    tbx_NumeroLicencia.Text,
                                    tbx_NumeroLicenciaFed.Text,
                                    dtp_FechaExpiraFed.Value,
                                    tbx_IdTributario.Text)

            If Id > 0 Then
                btn_Validar.Enabled = True
                Id_Seleccionado = Id
                Clave_Seleccionado = tbx_Clave.Text.Trim
                Nombre_Seleccionado = tbx_NombreCompleto.Text.Trim

                'Aumentar el consecutivo de Clave en Cat_Sucursales
                'If Clave_AutomaticaEmp = "S" Then
                If Not fn_EmpleadosP_IncrementaEmpleadoP(CInt(tbx_Clave.Text)) Then
                    MsgBox("Error al intentar guardar la última Clave Generada.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                'End If

                Call GuardarImagen()

                FuncionesGlobales.fn_Menu_Progreso(100)
                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)

                tbx_Clave.Tag = tbx_Clave.Text
                Tab_Nuevo.Text = "Modificar"

                FamiliaresAgregados = False
                EmpleosAgregados = False
                ReferenciasAgregadas = False
                SeñasAgregadas = False

                'Aqui se habilitan todas las pestañas
                'una vez que se han capturado e insertado los DATOS GENERALES
                'en la tabla de Prospectos
                Me.tab_RasgosPersonales.Parent = Me.tab_DatosEmpleado
                Me.tab_DatosEscolares.Parent = Me.tab_DatosEmpleado
                Me.tab_DatosFamiliares.Parent = Me.tab_DatosEmpleado
                Me.tab_Empleos.Parent = Me.tab_DatosEmpleado
                Me.tab_Referencias.Parent = Me.tab_DatosEmpleado
                Me.tab_DatosVarios.Parent = Me.tab_DatosEmpleado
                Me.tab_PapeleriaRecibida.Parent = Me.tab_DatosEmpleado
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            '«-----Si se esta actualizando------»
            Dim Calcular As Boolean = False
            If PuestoPrevio <> cmb_Puesto.SelectedValue Then Calcular = True
            'ACTUALIZAR
            If fn_EmpleadosP_Update(Id, tbx_NombreCompleto.Text.Trim, cmb_Departamento_DG.SelectedValue,
                                    cmb_Puesto.SelectedValue, cmb_Genero.SelectedValue,
                                    cmb_EstadoCivil.SelectedValue, tbx_Mail.Text.Trim,
                                                cmb_CatalogoFirmas.SelectedValue, tbx_ApellidoPaterno.Text.Trim,
                                                tbx_ApellidoMaterno.Text.Trim, tbx_Nombres.Text.Trim,
                                                tbx_SueldoBase.Text, tbx_Calle.Text, tbx_NumExterior.Text,
                                                tbx_NumInterior.Text, cmb_Colonias.Text, cmb_Zonas.SelectedValue,
                                                tbx_CodigoPostal.Text, tbx_Telefono1.Text,
                                                tbx_TelefonoMovil1.Text, dtp_FechaNac.Value, LugarNac,
                                                tbx_RFC.Text, tbx_CURP.Text,
                                                tbx_IMSS.Text, tbx_Elector.Text, cmb_TipoLicencia.SelectedValue,
                                                dtp_FechaExpira.Value,
                                                tbx_NumCartilla.Text, cmb_CertifAcademia.SelectedValue,
                                                cmb_ViveConFam.SelectedValue,
                                                tbx_CantidadHijos.Text, tbx_Edad.Text,
                                                cmb_EmpleadoReferencia.SelectedValue, tbx_EntreCalle1.Text,
                                                tbx_EntreCalle2.Text, cmb_ModoNacionalidad.SelectedValue,
                                                cmb_Pais.Text, dtp_FechaNaturalizacion.Value, tbx_Pasaporte.Text,
                                                cmb_JefeArea.SelectedValue, tbx_Latitud.Text, tbx_Longitud.Text,
                                                tbx_UMF.Text, cmb_ModoContactoD.SelectedValue,
                                                cmb_Ruta.SelectedValue, cmb_CreditoInfonavit.SelectedValue,
                                                cmb_Verifica.SelectedValue, cmb_Ciudad.SelectedValue,
                                                tbx_NumeroCredito.Text.Trim, cmb_TipoDescuento.SelectedValue,
                                                CDec(tbx_MontoDescuento.Text.Trim),
                                                tbx_NumeroLicencia.Text,
                                                tbx_NumeroLicenciaFed.Text,
                                                dtp_FechaExpiraFed.Value,
                                                tbx_IdTributario.Text) Then

                'actualiza las variables para la papeleria recibida
                Clave_Seleccionado = tbx_Clave.Text.Trim
                Nombre_Seleccionado = tbx_NombreCompleto.Text.Trim

                Call GuardarImagen()

                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(40)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)
                'En caso de que se haya hecho la transaccion
                MsgBox("Registro Modificado.", MsgBoxStyle.Information, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If
        Call LlenarListaProspectos()
    End Sub

    Sub GuardarImagen()
        'Convertir las Imagenes en Bytes
        'Para no crear conflicto las imagenes que existían se eliminan
        Try
            If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
            If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
        Catch
        End Try

        'Se vuelven a generar las imagenes si es que tienen alguna cargada
        'para luego guardarlas o actualizarlas

        'Primero la foto de Frente
        Dim BytesFrente As Byte() = Nothing
        Dim fsFrente
        If pct_Frente.Tag > 0 Then
            Dim FotoFrente As New Bitmap(pct_Frente.Image)
            FotoFrente.Save(RutaTemp & "Frente.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            fsFrente = New FileStream(RutaTemp & "Frente.jpg", FileMode.Open)
            BytesFrente = New Byte(fsFrente.Length - 1) {}
            fsFrente.Read(BytesFrente, 0, BytesFrente.Length)
            fsFrente.Close()

            Dim ms As New MemoryStream()
            FotoFrente.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            ms.Seek(0, SeekOrigin.Begin)
            Image.FromStream(ms).Save(Ruta_Temporal & "Frente.jpg")
            ms.Close()
            ms.Dispose()

        End If

        'Segundo la foto de Frente Formal
        Dim BytesFormal As Byte() = Nothing
        Dim fsFormal
        If pct_FrenteFormal.Tag > 0 Then
            Dim FotoFormal As New Bitmap(pct_FrenteFormal.Image)
            FotoFormal.Save(RutaTemp & "FrenteFormal.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            fsFormal = New FileStream(RutaTemp & "FrenteFormal.jpg", FileMode.Open)
            BytesFormal = New Byte(fsFormal.Length - 1) {}
            fsFormal.Read(BytesFormal, 0, BytesFormal.Length)
            fsFormal.Close()

            Dim ms As New MemoryStream()
            FotoFormal.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
            ms.Seek(0, SeekOrigin.Begin)
            Image.FromStream(ms).Save(Ruta_Temporal & "FrenteFormal.jpg")
            ms.Close()
            ms.Dispose()
        End If

        If Not fn_EmpleadosPI_Actualizar(Id, BytesFrente, BytesFormal, (pct_Frente.Tag = 2 OrElse pct_FrenteFormal.Tag = 2)) Then
            MsgBox("Error al intentar guardar las Fotografías.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            If pct_Frente.Tag = 1 Then pct_Frente.Tag = 2 'Se cambia el valor porque ya se encuentra en BD
            If pct_FrenteFormal.Tag = 1 Then pct_FrenteFormal.Tag = 2 'Se cambia el valor porque ya se encuentra en BD
        End If

        Try
            If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
            If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
        Catch
        End Try
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub btn_Cancelar_DG_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_DG.Click
        SegundosDesconexion = 0

        'Aqui se limpian los textbox de todas las pestañas
        'Call LimpiarEntrevistas()
        lsv_Entrevistas.Items.Clear()
        'Call LimpiarFoto()
        'Call DatosGenerales_LimpiarObjetos()
        'Call DatosEscolares_LimpiarObjetos()
        'Call Cursos_LimpiarObjetos()
        'Call DatosFamiliares_LimpiarObjetos()
        'Call Referencias_LimpiarObjetos()
        'Call DatosVarios_LimpiarObjetos()

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado

        'Aqui se ajusta el titulo de la pestaña
        Tab_Nuevo.Text = "Nuevo"

        'Aquí se inicializa la variable Id 
        'para indicar que no se ha seleccionado ningún Prospecto
        'o que no se ha agregado un Prospecto nuevo
        Id = 0
        btn_Validar.Enabled = False
        btn_Guardar_DG.Enabled = False
    End Sub

    Sub LlenarMasDatos(ByVal ID As Integer)
        'Aqui se cambia el titulo de la pestaña
        Tab_Nuevo.Text = "Modificar"

        'Aqui se cambia la pestaña
        Tab_Catalogo.SelectedTab = Tab_Nuevo

        Me.tab_Contacto.Parent = Me.tab_DatosEmpleado
        Me.tab_RasgosPersonales.Parent = Me.tab_DatosEmpleado
        Me.tab_DatosEscolares.Parent = Me.tab_DatosEmpleado
        Me.tab_DatosFamiliares.Parent = Me.tab_DatosEmpleado
        Me.tab_Empleos.Parent = Me.tab_DatosEmpleado
        Me.tab_Referencias.Parent = Me.tab_DatosEmpleado
        Me.tab_DatosVarios.Parent = Me.tab_DatosEmpleado
        Me.tab_PapeleriaRecibida.Parent = Me.tab_DatosEmpleado

        'Aquí se obtienen los RASGOS del Empleado seleccionado
        Dim dr_Rasgos As DataRow = fn_RasgosP_ObtenValores(ID)

        If Not dr_Rasgos Is Nothing Then
            cmb_ComplexionR.SelectedValue = dr_Rasgos("Complexion")
            cmb_ColorPiel.SelectedValue = dr_Rasgos("PielColor")
            cmb_Cara.SelectedValue = dr_Rasgos("CaraForma")
            cmb_TipoSangreR.SelectedValue = dr_Rasgos("SangreTipo")
            cmb_FactorRH.SelectedValue = dr_Rasgos("SangreFactorRH")
            tbx_PesoR.Text = dr_Rasgos("Peso")
            tbx_EstaturaR.Text = dr_Rasgos("Estatura")
            cmb_UsaAnteojos.SelectedValue = dr_Rasgos("UsaAnteojos")

            cmb_CantidadCabello.SelectedValue = dr_Rasgos("CabelloCantidad")
            cmb_ColorCabello.SelectedValue = dr_Rasgos("CabelloColor")
            cmb_FormaCabello.SelectedValue = dr_Rasgos("CabelloForma")
            cmb_Calvicie.SelectedValue = dr_Rasgos("CabelloCalvicie")
            cmb_ImplantacionCabello.SelectedValue = dr_Rasgos("CabelloImplantacion")

            cmb_AlturaFrente.SelectedValue = dr_Rasgos("FrenteAltura")
            cmb_InclinacionFrente.SelectedValue = dr_Rasgos("FrenteInclinacion")
            cmb_AnchoFrente.SelectedValue = dr_Rasgos("FrenteAncho")

            cmb_DireccionCejas.SelectedValue = dr_Rasgos("CejasDireccion")
            cmb_ImplantacionCejas.SelectedValue = dr_Rasgos("CejasImplantacion")
            cmb_FormaCejas.SelectedValue = dr_Rasgos("CejasForma")
            cmb_TamañoCejas.SelectedValue = dr_Rasgos("CejasTamano")

            cmb_ColorOjos.SelectedValue = dr_Rasgos("OjosColor")
            cmb_FormaOjos.SelectedValue = dr_Rasgos("OjosForma")
            cmb_TamañoOjos.SelectedValue = dr_Rasgos("OjosTamano")

            cmb_RaizNariz.SelectedValue = dr_Rasgos("NarizRaiz")
            cmb_DorsoNariz.SelectedValue = dr_Rasgos("NarizDorso")
            cmb_AnchoNariz.SelectedValue = dr_Rasgos("NarizAncho")
            cmb_BaseNariz.SelectedValue = dr_Rasgos("NarizBase")
            cmb_AlturaNariz.SelectedValue = dr_Rasgos("NarizAltura")

            cmb_TamañoBoca.SelectedValue = dr_Rasgos("BocaTamano")
            cmb_ComisurasBoca.SelectedValue = dr_Rasgos("BocaComisuras")

            cmb_EspesorLabios.SelectedValue = dr_Rasgos("LabiosEspesor")
            cmb_AlturaNasoLabial.SelectedValue = dr_Rasgos("LabiosAlturaNasolabial")
            cmb_ProminenciaLabios.SelectedValue = dr_Rasgos("LabiosProminencia")

            cmb_TipoMenton.SelectedValue = dr_Rasgos("MentonTipo")
            cmb_FormaMenton.SelectedValue = dr_Rasgos("MentonForma")
            cmb_InclinacionMenton.SelectedValue = dr_Rasgos("MentonInclinacion")

            cmb_FormaOreja.SelectedValue = dr_Rasgos("OrejaForma")
            cmb_OriginalOreja.SelectedValue = dr_Rasgos("OrejaOriginal")
            cmb_HelixSuperior.SelectedValue = dr_Rasgos("HelixSuperior")
            cmb_HelixPosterior.SelectedValue = dr_Rasgos("HelixPosterior")
            cmb_HelixAdherencia.SelectedValue = dr_Rasgos("HelixAdherencia")
            cmb_HelixContorno.SelectedValue = dr_Rasgos("HelixContorno")
            cmb_LobuloAdherencia.SelectedValue = dr_Rasgos("LobuloAdherencia")
            cmb_LobuloDimension.SelectedValue = dr_Rasgos("LobuloDimension")
            cmb_LobuloParticularidad.SelectedValue = dr_Rasgos("LobuloParticularidad")

            Id_EmpleadoRasgos = ID
        Else
            Id_EmpleadoRasgos = 0
        End If

        'Las entrevistas del prospecto
        If Not fn_ProspectosEntrevistas_LlenarLista(lsv_Entrevistas, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Entrevistas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'La imagen del prospecto
        Dim DR As DataRow = fn_EmpleadosPI_LeerImagenes(ID)
        If DR IsNot Nothing Then
            'Frente
            If Not IsDBNull(DR("Frente")) Then
                'Se carga la imagen en la pestaña de Fotografía
                Dim ms_Frente As MemoryStream = New MemoryStream(DR("Frente"), 0, DR("Frente").Length)
                ms_Frente.Write(DR("Frente"), 0, DR("Frente").Length)
                pct_Frente.Image = Image.FromStream(ms_Frente, True)

                'Se carga la imagen en el PicturBox de Rasgos (cuando no existe fotografía de frente formal)
                pct_RasgoFrente.Image = New Bitmap(ms_Frente)

                btn_LimpiarFrente.Enabled = True
                btn_Guardar_Foto.Enabled = True
                pct_Frente.Tag = 2 'Significa que es una imagen traida de BD
            Else
                btn_LimpiarFrente.Enabled = False
                btn_Guardar_Foto.Enabled = False
                pct_Frente.Tag = 0 'Que no tiene imagen
            End If

            'Frente Formal
            If Not IsDBNull(DR("FrenteFormal")) Then
                'Se carga la imagen en la pestaña de Fotografía
                Dim ms_Frente As MemoryStream = New MemoryStream(DR("FrenteFormal"), 0, DR("FrenteFormal").Length)
                ms_Frente.Write(DR("FrenteFormal"), 0, DR("FrenteFormal").Length)
                pct_FrenteFormal.Image = Image.FromStream(ms_Frente, True)

                'Se carga la imagen en el PicturBox de Rasgos (cuando exista sino queda la de Frente)
                pct_RasgoFrente.Image = New Bitmap(ms_Frente)

                btn_LimpiarFrenteFormal.Enabled = True
                btn_Guardar_FotoFormal.Enabled = True
                pct_FrenteFormal.Tag = 2 'Significa que es una imagen traida de BD
            Else
                btn_LimpiarFrenteFormal.Enabled = False
                btn_Guardar_FotoFormal.Enabled = False
                pct_FrenteFormal.Tag = 0 'Que no tiene imagen
            End If
        Else
            btn_LimpiarFrente.Enabled = False
            btn_Guardar_Foto.Enabled = False
            pct_Frente.Tag = 0

            btn_LimpiarFrenteFormal.Enabled = False
            btn_Guardar_FotoFormal.Enabled = False
            pct_FrenteFormal.Tag = 0
        End If

        ' Aqui se obtienen los DATOS ESCOLARES del Prospecto seleccionado
        Dim Dr_DatosEscolares As DataRow = fn_DatosEscolaresP_ObtenValores(ID)

        If Not Dr_DatosEscolares Is Nothing Then
            cmb_UltimosEstudios.SelectedValue = Dr_DatosEscolares("Id_GradoEscolar")
            cmb_Documentacion.SelectedValue = Dr_DatosEscolares("Id_TipoDoctoEscolar")
            tbx_NombreEscuela.Text = Dr_DatosEscolares("NombreEscuela")
            tbx_Carrera.Text = Dr_DatosEscolares("Carrera")
            tbx_Especialidad.Text = Dr_DatosEscolares("Especialidad")
            cmb_AInicio.SelectedValue = Dr_DatosEscolares("FechaInicio")
            cmb_ATermino.SelectedValue = Dr_DatosEscolares("FechaFin")
            tbx_Folio.Text = Dr_DatosEscolares("Folio")
            tbx_Promedio.Text = Dr_DatosEscolares("Promedio")
            tbx_CedulaProfesional.Text = Dr_DatosEscolares("CedulaProfesional")
            Id_EmpleadoEscolar = ID
        Else
            Id_EmpleadoEscolar = 0
        End If

        'Aqui se llena el listview de CURSOS RECIBIDOS con los datos del Prospecto seleccionado
        cmb_TipoCurso.SelectedValue = "0"
        If Not fn_CursosRecibidosP_ObtenValores(lsv_Cursos, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar los Cursos.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aqui se llena el listview de DATOS FAMILIARES con los datos del Prospecto seleccionado
        If Not fn_DatosFamiliaresP_ObtenValores(lsv_Familiares, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar los Datos Familiares.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aquí se llena el listview de EMPLEOS con los datos del Prospecto seleccionado
        cmb_Paises_Empleos.SelectedValue = 0
        If Not fn_EmpleosP_ObtenValores(lsv_Empleos, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar los Empleos anteriores.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_MapaLaborales.Enabled = lsv_Empleos.Items.Count > 0

        'Aquí se llena el listview de REFERENCIAS con los datos del Prospecto seleccionado
        If Not fn_ReferenciasP_ObtenValores(lsv_Referencias, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Referencias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aquí se obtienen los DATOS VARIOS del Prospecto seleccionado
        'Los datos de ingresos
        Dim Dr_DatosIngresos As DataRow = fn_DatosIngresosP_ObtenValores(ID)

        If Not Dr_DatosIngresos Is Nothing Then
            tbx_IngresoFamiliar.Text = Dr_DatosIngresos("Ingreso_Mensual")
            tbx_IngresoAdicional.Text = Dr_DatosIngresos("Ingreso_Adicional")
            tbx_Descripcion_IngresoAdicional.Text = Dr_DatosIngresos("Descripcion_Adicional")
            tbx_GastoFamiliar.Text = Dr_DatosIngresos("Gasto_Mensual")
            cmb_TipoVivienda.SelectedValue = Dr_DatosIngresos("Id_TipoVivienda")
            tbx_PagoMensual.Text = Dr_DatosIngresos("Pago_Mensual")
            tbx_ValorVivienda.Text = Dr_DatosIngresos("Valor_Vivienda")
            If Dr_DatosIngresos("Vehiculo_Propio") = "S" Then
                rdb_Si_Vehiculo.Checked = True
                rdb_No_Vehiculo.Checked = False
            Else
                rdb_Si_Vehiculo.Checked = False
                rdb_No_Vehiculo.Checked = True
            End If
            tbx_Modelo.Text = Dr_DatosIngresos("Modelo_Vehiculo")
            tbx_ValorVehiculo.Text = Dr_DatosIngresos("Valor_Vehiculo")
            Id_EmpleadoIngresos = ID
        Else
            Id_EmpleadoIngresos = 0
        End If

        'Se llena el listview de Señas Particulares
        If Not fn_SeñasParticularesP_ObtenValores(lsv_SeñasParticulares, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Señas Particulares.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        'AQUI SE LLENA LA LISTA DE CONTACTOS
        If Not fn_ContactoP_CargarLista(lsv_Contacto, ID) Then
            MsgBox("Ha ocurrido un error al intentar mostrar los modos de contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        'Aquí se llena el listview de los Tipos de Documentos y se marcan los que tiene el Prospecto
        Call CargarPapeleriaRecibida()

        'llenar huellas de prospectp
        LlenarHuellasProspecto(ID)

    End Sub

    Private Sub btn_Baja_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Baja.Click
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = True
        frm.ShowDialog()
        If frm.Firma Then
            'Se pregunta si también se quiere mandar este usuario a la lista negra
            If MsgBox("Desea además agregar al prospecto: " & lsv_Catalogo.SelectedItems(0).SubItems(1).Text & " a la Lista Negra?", MessageBoxButtons.YesNo + MsgBoxStyle.Question, "Agregar a Lista Negra") = MsgBoxResult.Yes Then
                If Not fn_ListaNegra_Nuevo(lsv_Catalogo.SelectedItems(0).SubItems(1).Text, "SISSA", lsv_Catalogo.SelectedItems(0).SubItems(3).Text, frm.Observaciones) Then
                    MsgBox("No se ha podido agregar el prospecto a la Lista Negra.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            'Se da de baja al empleado
            If Not fn_EmpleadosP_ActualizaStatus(lsv_Catalogo.SelectedItems(0).Tag, "B", frm.Observaciones, False) Then
                MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                MsgBox("Los datos han sido actualizados satisfactoriamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
            Call LlenarListaProspectos()
            tbx_Buscar.Clear()
        End If
    End Sub

    Private Sub cmbs_Catalogo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedValueChanged, cmb_PuestoFiltro.SelectedValueChanged, cmb_DepartamentoFiltro.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Call BotonesCatalogo()
    End Sub

#End Region

#Region "ENTREVISTAS"

    Sub LimpiarEntrevistas()
        dtp_FechaEntrevista.Value = Today.Date
        cmb_EmpleadoEntrevista.SelectedValue = 0
        rdb_SiApto.Checked = False
        rdb_NoApto.Checked = False
        tbx_ComentariosEntrevista.Clear()
        lsv_Entrevistas.Items.Clear()
    End Sub

    Private Sub btn_Agregar_Entrevista_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Entrevista.Click
        If cmb_EmpleadoEntrevista.SelectedValue = "0" Then
            MsgBox("Indique el Empleado que entrevistó.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_EmpleadoEntrevista.Focus()
            Exit Sub
        End If
        If rdb_SiApto.Checked = False And rdb_NoApto.Checked = False Then
            MsgBox("Indique si el Prospecto es Apto o No Apto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If tbx_ComentariosEntrevista.Text = "" Or tbx_ComentariosEntrevista.TextLength < 10 Then
            MsgBox("Indique comentarios mas completos.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_ComentariosEntrevista.SelectAll()
            tbx_ComentariosEntrevista.Focus()
            Exit Sub
        End If

        Dim Apto As Char
        If rdb_SiApto.Checked Then
            Apto = "S"
        ElseIf rdb_NoApto.Checked Then
            Apto = "N"
        End If

        If Id = 0 Then 'Agregar a la lista y se guardan al guardar el prospecto
            lsv_Entrevistas.Items.Add(dtp_FechaEntrevista.Value.Date.ToShortDateString)
            lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).Tag = 0
            lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).SubItems.Add(cmb_EmpleadoEntrevista.Text)
            If rdb_SiApto.Checked Then
                lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).SubItems.Add("Si")
            ElseIf rdb_NoApto.Checked Then
                lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).SubItems.Add("No")
            End If
            lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).SubItems.Add(tbx_ComentariosEntrevista.Text)
            lsv_Entrevistas.Items(lsv_Entrevistas.Items.Count - 1).SubItems.Add(cmb_EmpleadoEntrevista.SelectedValue)
        Else 'guardar de inmediato en la BD

            If Not fn_EmpleadosPentrevista_Nuevo(Id, dtp_FechaEntrevista.Value.Date, cmb_EmpleadoEntrevista.SelectedValue, Apto, tbx_ComentariosEntrevista.Text.Trim) Then
                MsgBox("Ocurrió un error al intentar guardar los datos de la entrevista.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            Call fn_ProspectosEntrevistas_LlenarLista(lsv_Entrevistas, Id)
        End If

        dtp_FechaEntrevista.Value = Today.Date
        cmb_EmpleadoEntrevista.SelectedValue = 0
        rdb_SiApto.Checked = False
        rdb_NoApto.Checked = False
        tbx_ComentariosEntrevista.Clear()

        dtp_FechaEntrevista.Focus()
    End Sub

#End Region

#Region "FOTOGRAFIA"

    Sub LimpiarFoto()
        pct_Frente.Image = My.Resources.LogoNoDisponible
        pct_FrenteFormal.Image = My.Resources.LogoNoDisponible

        pct_Frente.Tag = 0 'Significa que ya no tiene imagen
        pct_FrenteFormal.Tag = 0 'Significa que ya no tiene imagen

        Try
            If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
            If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
        Catch
        End Try
    End Sub

    Private Sub RedurcirImagen(ByRef Adjunto As String)
        'Si existían fotos se eliminan
        Try
            If File.Exists(RutaTemp & "Adjunto.jpg") Then Kill(RutaTemp & "Adjunto.jpg")
            If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
            If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
        Catch
        End Try

        'Se vuelven a generar las imagenes si es que tienen alguna cargada
        'para luego cambiarles el tamaño para la alerta

        'Frente Formal es la que se utiliza principalmente
        If pct_FrenteFormal.Tag > 0 Then
            Dim FotoFormal As New Bitmap(pct_FrenteFormal.Image)
            FotoFormal.Save(RutaTemp & "FrenteFormal.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim Imagen As Image = Image.FromFile(RutaTemp & "FrenteFormal.jpg")
            Adjunto = fn_ReducirImagen("Adjunto", Imagen, 100000, 30, RutaTemp, 170, 150)
            Imagen.Dispose()
        ElseIf pct_FrenteFormal.Tag > 0 Then
            Dim FotoFrente As New Bitmap(pct_FrenteFormal.Image)
            FotoFrente.Save(RutaTemp & "Frente.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)
            Dim Imagen As Image = Image.FromFile(RutaTemp & "Frente.jpg")
            Adjunto = fn_ReducirImagen("Adjunto", Imagen, 100000, 30, RutaTemp, 170, 150)
            Imagen.Dispose()
        End If
    End Sub

    Private Sub btn_TomarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_TomarFrente.Click, btn_TomarFrenteFormal.Click
        SegundosDesconexion = 0

        'Tomar la Foto del Frente o FrenteFormal desde la cámara
        Dim frm As New frm_Fotos
        BanderA = False
        frm.ShowDialog()
        If BanderA Then
            If sender.Equals(btn_TomarFrente) Then
                pct_Frente.Image = frm.pct_Foto.Image
                pct_Frente.Refresh()
                pct_Frente.Tag = 1 'Significa que es una imagen nueva
                btn_LimpiarFrente.Enabled = True
            Else
                pct_FrenteFormal.Image = frm.pct_Foto.Image
                pct_FrenteFormal.Refresh()
                pct_FrenteFormal.Tag = 1 'Significa que es una imagen nueva
                btn_LimpiarFrenteFormal.Enabled = True
            End If
        Else
            If sender.Equals(btn_TomarFrente) Then
                If pct_Frente.Tag = 0 Then 'Si no tenia imagen desde el principio, queda vacío
                    pct_Frente.Image = My.Resources.LogoNoDisponible
                    btn_LimpiarFrente.Enabled = False
                End If
            Else
                If pct_FrenteFormal.Tag = 0 Then 'Si no tenia imagen desde el principio, queda vacío
                    pct_FrenteFormal.Image = My.Resources.LogoNoDisponible
                    btn_LimpiarFrenteFormal.Enabled = False
                End If
            End If
        End If
        frm.Dispose()
    End Sub

    Private Sub btn_LimpiarFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarFrente.Click, btn_LimpiarFrenteFormal.Click
        SegundosDesconexion = 0
        If sender.Equals(btn_LimpiarFrente) Then
            If MsgBox("¿Confirma que desea eliminar la Fotografía de Frente del Prospecto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Fotografía") = MsgBoxResult.Yes Then
                pct_Frente.Image = My.Resources.LogoNoDisponible
                btn_LimpiarFrente.Enabled = False
                btn_Guardar_Foto.Enabled = False
                'se guarda el tag para saber si era una imagen de BD (que es 2)
                Dim tag As Integer = pct_Frente.Tag
                pct_Frente.Tag = 0
                If tag = 2 Then Call GuardarImagen()
                Try
                    If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
                Catch
                End Try
            Else
                Exit Sub
            End If
        Else
            If MsgBox("¿Confirma que desea eliminar la Fotografía de Frente Formal del Prospecto?", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "Eliminar Fotografía") = MsgBoxResult.Yes Then
                pct_FrenteFormal.Image = My.Resources.LogoNoDisponible
                btn_LimpiarFrenteFormal.Enabled = False
                btn_Guardar_FotoFormal.Enabled = False
                'se guarda el tag para saber si era una imagen de BD (2)
                Dim tag As Integer = pct_FrenteFormal.Tag
                pct_FrenteFormal.Tag = 0
                If tag = 2 Then Call GuardarImagen()
                Try
                    If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
                Catch
                End Try
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub btn_Guardar_Foto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Foto.Click, btn_Guardar_FotoFormal.Click
        SegundosDesconexion = 0

        Call GuardarImagen()
    End Sub

    Private Sub btn_Importa_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importa.Click, btn_ImportaFormal.Click
        SegundosDesconexion = 0

        Dim Dialogo As New OpenFileDialog With {.Filter = "Archivos de Imagen|*.jpg", .Multiselect = False}
        Dialogo.ShowDialog()

        If Dialogo.FileName <> "" Then
            Me.Cursor = Cursors.WaitCursor

            Dim Imagen As Image = CargarImagen(Dialogo.FileName)


            'Dim Imagen As Image = Image.FromFile(Dialogo.FileName)
            Dim RutaFinal As String

            If sender.Equals(btn_Importa) Then
                pct_Frente.Image = CargarImagen(fn_ReducirImagen("Frente", Imagen, 200000, 30, RutaTemp, 800, 600))
                pct_Frente.Refresh()
                pct_Frente.Tag = 1 'Imagen Nueva
                btn_LimpiarFrente.Enabled = True
                btn_Guardar_Foto.Enabled = Id > 0
            Else
                pct_FrenteFormal.Image = CargarImagen(fn_ReducirImagen("Frente", Imagen, 200000, 30, RutaTemp, 800, 600))
                pct_FrenteFormal.Refresh()
                pct_FrenteFormal.Tag = 1 'Imagen Nueava
                btn_LimpiarFrenteFormal.Enabled = True
                btn_Guardar_FotoFormal.Enabled = Id > 0
            End If

            Imagen.Dispose()
            Me.Cursor = Cursors.Default
        Else
            If sender.Equals(btn_Importa) Then
                If pct_Frente.Tag = 0 Then 'Si no tenía imagen desde el principio, queda vacío
                    pct_Frente.Image = My.Resources.LogoNoDisponible
                    btn_LimpiarFrente.Enabled = False
                    btn_Guardar_Foto.Enabled = False
                End If
            Else
                If pct_FrenteFormal.Tag = 0 Then 'Si no tenía imagen desde el principio, queda vacío
                    pct_FrenteFormal.Image = My.Resources.LogoNoDisponible
                    btn_LimpiarFrenteFormal.Enabled = False
                    btn_Guardar_FotoFormal.Enabled = False
                End If
            End If
        End If
    End Sub

#End Region

    Public Function CargarImagen(path As String) As Image
        Dim ms As MemoryStream = Nothing
        Dim Imagen As Image
        Dim ImagenB As Byte() = File.ReadAllBytes(path)
        ms = New MemoryStream(ImagenB)
        Imagen = Image.FromStream(ms, True)
        Return Imagen
    End Function

#Region "RASGOS"

    Private Sub pct_RasgoFrente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_RasgoFrente.Click
        SegundosDesconexion = 0

        Dim frm As New frm_VisorImagenes
        frm.Imagen = pct_RasgoFrente.Image
        frm.MaximizeBox = True
        frm.MinimizeBox = True
        frm.TopMost = True
        frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable
        frm.Show()
    End Sub

    Private Sub btn_GuardarRasgos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_GuardarRasgos.Click
        SegundosDesconexion = 0

        If tbx_EstaturaR.Text = "" Then tbx_EstaturaR.Text = 0.0
        If tbx_PesoR.Text = "" Then tbx_PesoR.Text = 0.0

        If Id_EmpleadoRasgos > 0 Then
            If Not fn_RasgosP_Actualizar(Id, cmb_ComplexionR.SelectedValue, cmb_ColorPiel.SelectedValue, cmb_Cara.SelectedValue, cmb_TipoSangreR.SelectedValue, cmb_FactorRH.SelectedValue, tbx_PesoR.Text, tbx_EstaturaR.Text, cmb_UsaAnteojos.SelectedValue, cmb_CantidadCabello.SelectedValue, cmb_ColorCabello.SelectedValue, cmb_FormaCabello.SelectedValue, cmb_Calvicie.SelectedValue, cmb_ImplantacionCabello.SelectedValue, _
                                                         cmb_AlturaFrente.SelectedValue, cmb_InclinacionFrente.SelectedValue, cmb_AnchoFrente.SelectedValue, cmb_DireccionCejas.SelectedValue, cmb_ImplantacionCejas.SelectedValue, cmb_FormaCejas.SelectedValue, cmb_TamañoCejas.SelectedValue, cmb_ColorOjos.SelectedValue, cmb_FormaOjos.SelectedValue, cmb_TamañoOjos.SelectedValue, _
                                                         cmb_RaizNariz.SelectedValue, cmb_DorsoNariz.SelectedValue, cmb_AnchoNariz.SelectedValue, cmb_BaseNariz.SelectedValue, cmb_AlturaNariz.SelectedValue, cmb_TamañoBoca.SelectedValue, cmb_ComisurasBoca.SelectedValue, cmb_EspesorLabios.SelectedValue, cmb_AlturaNasoLabial.SelectedValue, cmb_ProminenciaLabios.SelectedValue, _
                                                         cmb_TipoMenton.SelectedValue, cmb_FormaMenton.SelectedValue, cmb_InclinacionMenton.SelectedValue, cmb_FormaOreja.SelectedValue, cmb_OriginalOreja.SelectedValue, cmb_HelixSuperior.SelectedValue, cmb_HelixPosterior.SelectedValue, cmb_HelixAdherencia.SelectedValue, cmb_HelixContorno.SelectedValue, cmb_LobuloAdherencia.SelectedValue, cmb_LobuloParticularidad.SelectedValue, cmb_LobuloDimension.SelectedValue) Then
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        Else
            'Si se va a insertar un registro de un Prospecto nuevo o de uno seleccionado
            Id_EmpleadoRasgos = fn_RasgosP_Nuevo(Id, cmb_ComplexionR.SelectedValue, cmb_ColorPiel.SelectedValue, cmb_Cara.SelectedValue, cmb_TipoSangreR.SelectedValue, cmb_FactorRH.SelectedValue, tbx_PesoR.Text, tbx_EstaturaR.Text, cmb_UsaAnteojos.SelectedValue, cmb_CantidadCabello.SelectedValue, cmb_ColorCabello.SelectedValue, cmb_FormaCabello.SelectedValue, cmb_Calvicie.SelectedValue, cmb_ImplantacionCabello.SelectedValue, _
                                                         cmb_AlturaFrente.SelectedValue, cmb_InclinacionFrente.SelectedValue, cmb_AnchoFrente.SelectedValue, cmb_DireccionCejas.SelectedValue, cmb_ImplantacionCejas.SelectedValue, cmb_FormaCejas.SelectedValue, cmb_TamañoCejas.SelectedValue, cmb_ColorOjos.SelectedValue, cmb_FormaOjos.SelectedValue, cmb_TamañoOjos.SelectedValue, _
                                                         cmb_RaizNariz.SelectedValue, cmb_DorsoNariz.SelectedValue, cmb_AnchoNariz.SelectedValue, cmb_BaseNariz.SelectedValue, cmb_AlturaNariz.SelectedValue, cmb_TamañoBoca.SelectedValue, cmb_ComisurasBoca.SelectedValue, cmb_EspesorLabios.SelectedValue, cmb_AlturaNasoLabial.SelectedValue, cmb_ProminenciaLabios.SelectedValue, _
                                                         cmb_TipoMenton.SelectedValue, cmb_FormaMenton.SelectedValue, cmb_InclinacionMenton.SelectedValue, cmb_FormaOreja.SelectedValue, cmb_OriginalOreja.SelectedValue, cmb_HelixSuperior.SelectedValue, cmb_HelixPosterior.SelectedValue, cmb_HelixAdherencia.SelectedValue, cmb_HelixContorno.SelectedValue, cmb_LobuloAdherencia.SelectedValue, cmb_LobuloParticularidad.SelectedValue, cmb_LobuloDimension.SelectedValue)
            If Id_EmpleadoRasgos > 0 Then
                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_CancelarRasgos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_CancelarRasgos.Click
        SegundosDesconexion = 0

        'Aqui se cambia de pestaña
        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Sub Rasgos_LimpiarObjetos()
        pct_RasgoFrente.Image = My.Resources.LogoNoDisponible
        cmb_ComplexionR.SelectedValue = 0
        cmb_Cara.SelectedValue = 0
        cmb_ColorPiel.SelectedValue = 0
        cmb_TipoSangreR.SelectedValue = 0
        cmb_FactorRH.SelectedValue = 0
        cmb_UsaAnteojos.SelectedValue = 0
        tbx_PesoR.Clear()
        tbx_EstaturaR.Clear()
        cmb_CantidadCabello.SelectedValue = 0
        cmb_ColorCabello.SelectedValue = 0
        cmb_FormaCabello.SelectedValue = 0
        cmb_Calvicie.SelectedValue = 0
        cmb_ImplantacionCabello.SelectedValue = 0
        cmb_AlturaFrente.SelectedValue = 0
        cmb_InclinacionFrente.SelectedValue = 0
        cmb_AnchoFrente.SelectedValue = 0
        cmb_DireccionCejas.SelectedValue = 0
        cmb_ImplantacionCejas.SelectedValue = 0
        cmb_FormaCejas.SelectedValue = 0
        cmb_TamañoCejas.SelectedValue = 0
        cmb_ColorOjos.SelectedValue = 0
        cmb_FormaOjos.SelectedValue = 0
        cmb_TamañoOjos.SelectedValue = 0
        cmb_RaizNariz.SelectedValue = 0
        cmb_DorsoNariz.SelectedValue = 0
        cmb_AnchoNariz.SelectedValue = 0
        cmb_BaseNariz.SelectedValue = 0
        cmb_AlturaNariz.SelectedValue = 0
        cmb_TamañoBoca.SelectedValue = 0
        cmb_ComisurasBoca.SelectedValue = 0
        cmb_EspesorLabios.SelectedValue = 0
        cmb_AlturaNasoLabial.SelectedValue = 0
        cmb_ProminenciaLabios.SelectedValue = 0
        cmb_TipoMenton.SelectedValue = 0
        cmb_FormaMenton.SelectedValue = 0
        cmb_InclinacionMenton.SelectedValue = 0
        cmb_FormaOreja.SelectedValue = 0
        cmb_OriginalOreja.SelectedValue = 0
        cmb_HelixSuperior.SelectedValue = 0
        cmb_HelixPosterior.SelectedValue = 0
        cmb_HelixAdherencia.SelectedValue = 0
        cmb_HelixContorno.SelectedValue = 0
        cmb_LobuloAdherencia.SelectedValue = 0
        cmb_LobuloParticularidad.SelectedValue = 0
        cmb_LobuloDimension.SelectedValue = 0
    End Sub

#End Region

#Region "DATOS ESCOLARES"

    Private Sub DatosEscolares_LimpiarObjetos()
        cmb_UltimosEstudios.SelectedValue = 0
        cmb_Documentacion.SelectedValue = 0
        tbx_NombreEscuela.Clear()
        tbx_Carrera.Clear()
        tbx_Especialidad.Clear()
        cmb_AInicio.SelectedValue = "0"
        cmb_ATermino.SelectedValue = "0"
        tbx_Folio.Clear()
        tbx_Promedio.Clear()
        tbx_CedulaProfesional.Clear()
    End Sub

    Private Sub Cursos_LimpiarObjetos()
        cmb_TipoCurso.Tag = Nothing
        tbx_NombreCurso.Clear()
        dtp_FInicioCurso.Value = #1/1/1900#
        dtp_FTerminoCurso.Value = #1/1/1900#
        rdb_Si_CursoFin.Checked = False
        rdb_No_CursoFin.Checked = False
        tbx_Instructor.Clear()
        cmb_DocumentoCurso.SelectedValue = 0
        tbx_Comentarios.Clear()

        tbx_NombreCurso.Tag = 0

        'Aqui se limpia el listview lsv_Cursos
        If Tab_Catalogo.SelectedIndex = 0 Then
            lsv_Cursos.Items.Clear()
        End If

        btn_Modificar_DatosEscolares.Enabled = False
        btn_Borrar_DatosEscolares.Enabled = False

        Modificando = False
    End Sub

    Private Sub btn_Guardar_DatosEscolares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_DatosEscolares.Click
        SegundosDesconexion = 0

        If cmb_UltimosEstudios.SelectedValue = 0 Then
            MsgBox("Seleccione Ultimo Grado de Estudios.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_UltimosEstudios.Focus()
            Exit Sub
        End If
        If cmb_Documentacion.SelectedValue = 0 Then
            MsgBox("Seleccione la Documentación Recibida.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Documentacion.Focus()
            Exit Sub
        End If
        If tbx_NombreEscuela.Text = "" Then
            MsgBox("Capture el Nombre de Escuela.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreEscuela.Focus()
            Exit Sub
        End If
        If cmb_AInicio.SelectedValue = "0" Then
            MsgBox("Seleccione el Año de Inicio.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_AInicio.Focus()
            Exit Sub
        End If

        If cmb_ATermino.SelectedValue = "0" Then
            MsgBox("Seleccione el Año de Termino.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_ATermino.Focus()
            Exit Sub
        End If

        If CInt(cmb_AInicio.SelectedValue) > CInt(cmb_ATermino.SelectedValue) Then
            MsgBox("El Año de Inicio debe ser menor al Año de Termino.", MsgBoxStyle.Critical, frm_MENU.Text)
            'cmb_AInicio.SelectedValue = cmb_ATermino.SelectedValue
            cmb_AInicio.Focus()
        End If

        If tbx_Promedio.Text = "" Then tbx_Promedio.Text = 0

        If Id_EmpleadoEscolar > 0 Then
            'Si se están actualizando los Datos Escolares de un Prospecto nuevo o de uno seleccionado
            If fn_DatosEscolaresP_Actualizar(Id, cmb_UltimosEstudios.SelectedValue, tbx_NombreEscuela.Text, tbx_Carrera.Text, tbx_Especialidad.Text, _
                                                             cmb_Documentacion.SelectedValue, tbx_Folio.Text, CInt(cmb_AInicio.SelectedValue), CInt(cmb_ATermino.SelectedValue), tbx_Promedio.Text, tbx_CedulaProfesional.Text) Then
                'MsgBox("Registro Modificado.", MsgBoxStyle.Information, frm_MENU.Text)

                'En caso de que se haya hecho la transaccion
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)
                FuncionesGlobales.fn_Menu_Progreso(0)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            'Si se va a insertar un registro de un Prospecto nuevo o de uno seleccionado
            Id_EmpleadoEscolar = fn_DatosEscolaresP_Nuevo(Id, cmb_UltimosEstudios.SelectedValue, tbx_NombreEscuela.Text, tbx_Carrera.Text, tbx_Especialidad.Text, _
                                                                          cmb_Documentacion.SelectedValue, tbx_Folio.Text, CInt(cmb_AInicio.SelectedValue), CInt(cmb_ATermino.SelectedValue), tbx_Promedio.Text, tbx_CedulaProfesional.Text)
            If Id_EmpleadoEscolar > 0 Then
                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If

        If CursosAgregados Then
            'Si se han agregado nuevos Cursos en el listview
            If Not fn_CursosRecibidosP_Guardar(Id, lsv_Cursos) Then
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            Else
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
                CursosAgregados = False
                Call Cursos_LimpiarObjetos()
            End If

            FuncionesGlobales.fn_Menu_Progreso(0)
            'Aquí se actualizan los datos del listview de Cursos Recibidos
            If Not fn_CursosRecibidosP_ObtenValores(lsv_Cursos, Id) Then
                MsgBox("Ha ocurrido un error al intentar mostrar los Cursos.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Agregar_Curso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Curso.Click
        SegundosDesconexion = 0

        If cmb_TipoCurso.SelectedValue = "S" And tbx_NombreCurso.Text = "" Then
            MsgBox("Debe de Seleccionar un Curso Interno.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoCurso.Focus()
            Exit Sub
        End If

        If tbx_NombreCurso.Text = "" Then
            MsgBox("Capture el Nombre del Curso.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreCurso.Focus()
            Exit Sub
        End If

        If tbx_Instructor.Text = "" Then
            MsgBox("Capture el nombre del Instructor.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Instructor.Focus()
            Exit Sub
        End If

        If cmb_DocumentoCurso.SelectedValue = 0 Then
            MsgBox("Seleccione el Documento recibido.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_DocumentoCurso.Focus()
            Exit Sub
        End If

        If dtp_FInicioCurso.Value > dtp_FTerminoCurso.Value Then
            MsgBox("La Fecha de Inicio debe ser menor a la Fecha Terminó.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FInicioCurso.Focus()
            Exit Sub
        End If

        If Not rdb_Si_CursoFin.Checked And Not rdb_No_CursoFin.Checked Then
            MsgBox("Seleccione Finalizado.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_CursoFinalizado.Focus()
            Exit Sub
        End If

        Dim renglon As ListViewItem

        renglon = lsv_Cursos.Items.Add(tbx_NombreCurso.Text)
        renglon.SubItems.Add(dtp_FInicioCurso.Value)
        renglon.SubItems.Add(dtp_FTerminoCurso.Value)
        If rdb_Si_CursoFin.Checked Then
            renglon.SubItems.Add("SI")
        Else
            renglon.SubItems.Add("NO")
        End If
        renglon.SubItems.Add(tbx_Instructor.Text)
        renglon.SubItems.Add(cmb_DocumentoCurso.Text)
        renglon.SubItems.Add(tbx_Comentarios.Text)
        renglon.SubItems.Add(cmb_DocumentoCurso.SelectedValue)
        renglon.SubItems.Add(cmb_TipoCurso.SelectedValue)
        If cmb_TipoCurso.Tag = Nothing Then cmb_TipoCurso.Tag = 0
        renglon.SubItems.Add(cmb_TipoCurso.Tag)

        'Se le asigna un valor al Tag de la linea agregada
        'tbx_NombreCurso.Tag = 0 ----> Curso Nuevo
        'tbx_NombreCurso.Tag > 0 ----> Curso Existente Modificado
        'cmb_TipoCurso.Tag = 0 ------> No proviene de un curso Interno
        'cmb_TipoCurso.Tag > 0 ------> Es el Id_Programa (del Curso que tomo)
        renglon.Tag = tbx_NombreCurso.Tag

        CursosAgregados = True

        cmb_TipoCurso.SelectedValue = "0"
        Call Cursos_LimpiarObjetos()
    End Sub

    Private Sub btn_Modificar_DatosEscolares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_DatosEscolares.Click
        SegundosDesconexion = 0

        Call Cursos_LimpiarObjetos()

        If lsv_Cursos.SelectedItems(0).SubItems(8).Text = "S" Then
            cmb_TipoCurso.SelectedValue = "S"
        ElseIf lsv_Cursos.SelectedItems(0).SubItems(8).Text = "N" Then
            cmb_TipoCurso.SelectedValue = "N"
        End If

        cmb_TipoCurso.Tag = lsv_Cursos.SelectedItems(0).SubItems(9).Text
        tbx_NombreCurso.Tag = lsv_Cursos.SelectedItems(0).Tag
        tbx_NombreCurso.Text = lsv_Cursos.SelectedItems(0).SubItems(0).Text
        dtp_FInicioCurso.Value = lsv_Cursos.SelectedItems(0).SubItems(1).Text
        dtp_FTerminoCurso.Value = lsv_Cursos.SelectedItems(0).SubItems(2).Text
        If lsv_Cursos.SelectedItems(0).SubItems(3).Text = "SI" Then
            rdb_Si_CursoFin.Checked = True
            rdb_No_CursoFin.Checked = False
        Else
            rdb_No_CursoFin.Checked = True
            rdb_Si_CursoFin.Checked = False
        End If
        tbx_Instructor.Text = lsv_Cursos.SelectedItems(0).SubItems(4).Text
        cmb_DocumentoCurso.SelectedValue = lsv_Cursos.SelectedItems(0).SubItems(7).Text
        tbx_Comentarios.Text = lsv_Cursos.SelectedItems(0).SubItems(6).Text

        Modificando = True
        lsv_Cursos.SelectedItems(0).Remove()
    End Sub

    Private Sub btn_Borrar_DatosEscolares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_DatosEscolares.Click
        SegundosDesconexion = 0

        If MsgBox("Los datos seleccionados serán borrados permanentemente. ¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
            If lsv_Cursos.SelectedItems(0).Tag > 0 Then
                If Not fn_CursosRecibidos_Borrar(lsv_Cursos.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar los Cursos Recibidos.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                fn_CursosRecibidosP_ObtenValores(lsv_Cursos, Id)
            Else
                lsv_Cursos.SelectedItems(0).Remove()
            End If
        End If
        If lsv_Cursos.Items.Count = 0 Then
            btn_Guardar_DatosEscolares.Enabled = False
            CursosAgregados = False
        End If
        btn_Modificar_DatosEscolares.Enabled = False
        btn_Borrar_DatosEscolares.Enabled = False
    End Sub

    Private Sub btn_Cancelar_DatosEscolares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_DatosEscolares.Click
        SegundosDesconexion = 0

        If CursosAgregados Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

    Private Sub dtp_FInicioCurso_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FInicioCurso.Enter
        If dtp_FInicioCurso.Value = #1/1/1900# Then
            dtp_FInicioCurso.Value = Today
        End If
    End Sub

    Private Sub dtp_FTerminoCurso_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FTerminoCurso.Enter
        If dtp_FTerminoCurso.Value = #1/1/1900# Then
            dtp_FTerminoCurso.Value = Today
        End If
    End Sub

    Private Sub lsv_Cursos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Cursos.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Cursos.SelectedItems.Count > 0 Then
            If Not Modificando Then
                btn_Modificar_DatosEscolares.Enabled = True
                btn_Borrar_DatosEscolares.Enabled = True
            End If
        Else
            btn_Modificar_DatosEscolares.Enabled = False
            btn_Borrar_DatosEscolares.Enabled = False
        End If
    End Sub

    Private Sub cmb_TipoCurso_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoCurso.SelectedValueChanged
        Call Cursos_LimpiarObjetos()
        lbl_NombreCurso.Enabled = cmb_TipoCurso.SelectedValue = "N"
        tbx_NombreCurso.Enabled = cmb_TipoCurso.SelectedValue = "N"
        lbl_NombreCursoA.Visible = cmb_TipoCurso.SelectedValue = "N"
        lbl_FechaInicio.Enabled = cmb_TipoCurso.SelectedValue = "N"
        dtp_FInicioCurso.Enabled = cmb_TipoCurso.SelectedValue = "N"
        lbl_FInicioCursoA.Visible = cmb_TipoCurso.SelectedValue = "N"
        lbl_FechaTermino.Enabled = cmb_TipoCurso.SelectedValue = "N"
        dtp_FTerminoCurso.Enabled = cmb_TipoCurso.SelectedValue = "N"
        lbl_FTerminoCursoA.Visible = cmb_TipoCurso.SelectedValue = "N"
        gbx_CursoFinalizado.Enabled = cmb_TipoCurso.SelectedValue = "N"
        lbl_CursoFinalizadoA.Visible = cmb_TipoCurso.SelectedValue = "N"
        lbl_Instructor.Enabled = cmb_TipoCurso.SelectedValue = "N"
        tbx_Instructor.Enabled = cmb_TipoCurso.SelectedValue = "N"
        lbl_TipoDocto.Enabled = cmb_TipoCurso.SelectedValue <> "0"
        cmb_DocumentoCurso.Enabled = cmb_TipoCurso.SelectedValue <> "0"
        lbl_DocumentoCursoA.Visible = cmb_TipoCurso.SelectedValue <> "0"
        lbl_Comentarios.Enabled = cmb_TipoCurso.SelectedValue <> "0"
        tbx_Comentarios.Enabled = cmb_TipoCurso.SelectedValue <> "0"
        btn_Agregar_Curso.Enabled = cmb_TipoCurso.SelectedValue <> "0"
        btn_BuscarCurso.Enabled = cmb_TipoCurso.SelectedValue = "S"
    End Sub

    Private Sub btn_BuscarCurso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_BuscarCurso.Click
        Dim frm As New Frm_BuscarCliente
        'Clave = Nombre del Curso
        'Nombre = Instructor
        'Cadena = Comentarios
        frm.Id_Empleado = Id
        frm.Consulta = Frm_BuscarCliente.Query.CursoCapacitacion
        frm.ShowDialog()
        If frm.Clave <> "" Then
            cmb_TipoCurso.Tag = frm.Id
            tbx_NombreCurso.Text = frm.Clave
            dtp_FInicioCurso.Value = frm.Fecha
            dtp_FTerminoCurso.Value = frm.Fecha
            tbx_Instructor.Text = frm.Nombres
            tbx_Comentarios.Text = frm.Cadena
            rdb_Si_CursoFin.Checked = True
        Else
            cmb_TipoCurso.SelectedValue = 0
        End If
    End Sub

#End Region

#Region "DATOS FAMILIARES"

    Private Sub DatosFamiliares_LimpiarObjetos()
        tbx_NombreFamiliar.Clear()
        cmb_Parentesco.SelectedValue = 0
        dtp_FecNac_Familiar.Value = #1/1/1900#
        tbx_Domicilio_Familiares.Clear()
        cmb_CiudadesFamiliares.SelectedValue = 0
        tbx_TelefonoFamiliares.Clear()

        rdb_Si_Vive.Checked = False
        rdb_No_Vive.Checked = False
        rdb_Si_MismoDom.Checked = False
        rdb_No_MismoDom.Checked = False
        rdb_Si_DepEcon.Checked = False
        rdb_No_DepEcon.Checked = False

        tbx_NombreFamiliar.Tag = Nothing

        If LimpiaTodo Then
            'Aqui se limpia el listview lsv_Cursos
            lsv_Familiares.Items.Clear()

            btn_Guardar_Familiares.Enabled = False
        End If
        Modificando = False
        btn_Modificar_Familiares.Enabled = False
    End Sub

    Private Sub btn_Agregar_Familiares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Familiares.Click
        SegundosDesconexion = 0

        If tbx_NombreFamiliar.Text = "" Then
            MsgBox("Capture el Nombre del Familiar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreFamiliar.Focus()
            Exit Sub
        End If

        If cmb_Parentesco.SelectedValue = 0 Then
            MsgBox("Seleccione el Parentesco.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Parentesco.Focus()
            Exit Sub
        End If

        'If dtp_FecNac_Familiar.Value = #1/1/1900# Then
        '    MsgBox("Capture la Fecha de Nacimiento del Familiar.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    dtp_FecNac_Familiar.Focus()
        '    Exit Sub
        'End If

        If Not rdb_Si_Vive.Checked And Not rdb_No_Vive.Checked Then
            MsgBox("Seleccione si Vive.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_Vive.Focus()
            Exit Sub
        End If

        If Not rdb_Si_MismoDom.Checked And Not rdb_No_MismoDom.Checked Then
            MsgBox("Seleccione Mismo Domicilio.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_MismoDomicilio.Focus()
            Exit Sub
        End If

        If Not rdb_Si_DepEcon.Checked And Not rdb_No_DepEcon.Checked Then
            MsgBox("Seleccione Dependiente Económico.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_DepEconomico.Focus()
            Exit Sub
        End If

        Dim Linea As ListViewItem

        Linea = lsv_Familiares.Items.Add(tbx_NombreFamiliar.Text)
        Linea.SubItems.Add(cmb_Parentesco.Text)
        Linea.SubItems.Add(dtp_FecNac_Familiar.Value.ToShortDateString)
        Linea.SubItems.Add(tbx_Domicilio_Familiares.Text)
        If cmb_CiudadesFamiliares.SelectedValue = 0 Then
            Linea.SubItems.Add("")
        Else
            Linea.SubItems.Add(cmb_CiudadesFamiliares.Text)
        End If
        Linea.SubItems.Add(tbx_TelefonoFamiliares.Text)
        If rdb_Si_Vive.Checked Then
            Linea.SubItems.Add("SI")
        Else
            Linea.SubItems.Add("NO")
        End If
        If rdb_Si_MismoDom.Checked Then
            Linea.SubItems.Add("SI")
        Else
            Linea.SubItems.Add("NO")
        End If
        If rdb_Si_DepEcon.Checked Then
            Linea.SubItems.Add("SI")
        Else
            Linea.SubItems.Add("NO")
        End If
        Linea.SubItems.Add(cmb_Parentesco.SelectedValue)
        Linea.SubItems.Add(cmb_CiudadesFamiliares.SelectedValue)

        'Para indicar si es un registro que se modificó o un registro nuevo
        If Modificando Then
            Linea.SubItems(0).Tag = 1 'Registro Modificado
        Else
            Linea.SubItems(0).Tag = 0 'Registro Nuevo
        End If
        Linea.Tag = tbx_NombreFamiliar.Tag
        tbx_NombreFamiliar.Tag = Nothing

        FamiliaresAgregados = True
        LimpiaTodo = False
        Call DatosFamiliares_LimpiarObjetos()
        btn_Guardar_Familiares.Enabled = True
        Modificando = False
    End Sub

    Private Sub btn_Guardar_Familiares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Familiares.Click
        SegundosDesconexion = 0

        If FamiliaresAgregados Then
            'En caso de que se hayan agregado nuevos Familiares en el listview

            If fn_DatosFamiliaresP_Nuevo(Id, lsv_Familiares) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)
                FuncionesGlobales.fn_Menu_Progreso(0)

                'En caso de que se haya hecho la transaccion
                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                FamiliaresAgregados = False

                'Aqui se limpian los textbox de la pestaña Datos Familiares
                LimpiaTodo = False
                Call DatosFamiliares_LimpiarObjetos()
                btn_Guardar_Familiares.Enabled = False
                btn_Modificar_Familiares.Enabled = False
                btn_Borrar_DatosFamiliares.Enabled = False
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else

            'En caso de que no se hayan agregado nuevos Familiares en el listview
            MsgBox("No se han agregado nuevos Familiares.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreFamiliar.Focus()
        End If

        'Aquí se actualiza el listview de DATOS FAMILIARES con los datos del Prospecto seleccionado
        If Not fn_DatosFamiliaresP_ObtenValores(lsv_Familiares, Id) Then
            MsgBox("Ha ocurrido un error al intentar mostrar los Datos Familiares.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        lsv_Familiares.Columns(10).Width = 0
    End Sub

    Private Sub dtp_FecNac_Familiar_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FecNac_Familiar.Enter
        If dtp_FecNac_Familiar.Value = #1/1/1900# Then
            dtp_FecNac_Familiar.Value = Today
        End If
    End Sub

    Private Sub rdb_Si_MismoDom_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Si_MismoDom.CheckedChanged
        SegundosDesconexion = 0

        If rdb_Si_MismoDom.Checked Then

            If cmb_Colonias.Text = "Seleccione..." Then
                MsgBox("Favor de ingresar una colonia en el apartado de Datos Generales", MsgBoxStyle.Critical, frm_MENU.Text)
            Else
                tbx_Domicilio_Familiares.Text = tbx_Calle.Text & " " & tbx_NumExterior.Text & " " & tbx_NumInterior.Text & " " & cmb_Colonias.Text
                cmb_CiudadesFamiliares.SelectedValue = cmb_Ciudades_DG.SelectedValue
            End If

        Else
            tbx_Domicilio_Familiares.Clear()
            cmb_CiudadesFamiliares.SelectedValue = 0
        End If
    End Sub

    Private Sub lsv_Familiares_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Familiares.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_Familiares.SelectedItems.Count > 0 Then
            If Not Modificando Then
                btn_Modificar_Familiares.Enabled = True
                btn_Borrar_DatosFamiliares.Enabled = True
            End If
        End If
    End Sub

    Private Sub btn_Modificar_Familiares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_Familiares.Click
        SegundosDesconexion = 0

        LimpiaTodo = False
        Call DatosFamiliares_LimpiarObjetos()
        btn_Borrar_DatosFamiliares.Enabled = False

        tbx_NombreFamiliar.Tag = lsv_Familiares.SelectedItems(0).Tag
        tbx_NombreFamiliar.Text = lsv_Familiares.SelectedItems(0).SubItems(0).Text
        If lsv_Familiares.SelectedItems(0).SubItems(9).Text = "" Then
            cmb_Parentesco.SelectedValue = 0
        Else
            cmb_Parentesco.SelectedValue = lsv_Familiares.SelectedItems(0).SubItems(9).Text
        End If
        dtp_FecNac_Familiar.Value = lsv_Familiares.SelectedItems(0).SubItems(2).Text
        tbx_Domicilio_Familiares.Text = lsv_Familiares.SelectedItems(0).SubItems(3).Text
        If lsv_Familiares.SelectedItems(0).SubItems(10).Text = "" Then
            cmb_CiudadesFamiliares.SelectedValue = 0
        Else
            cmb_CiudadesFamiliares.SelectedValue = lsv_Familiares.SelectedItems(0).SubItems(10).Text
        End If
        If lsv_Familiares.SelectedItems(0).SubItems(6).Text = "SI" Then
            rdb_Si_Vive.Checked = True
            rdb_No_Vive.Checked = False
        Else
            rdb_No_Vive.Checked = True
            rdb_Si_Vive.Checked = False
        End If
        If lsv_Familiares.SelectedItems(0).SubItems(7).Text = "SI" Then
            rdb_Si_MismoDom.Checked = True
            rdb_No_MismoDom.Checked = False
        Else
            rdb_No_MismoDom.Checked = True
            rdb_Si_MismoDom.Checked = False
        End If
        If lsv_Familiares.SelectedItems(0).SubItems(8).Text = "SI" Then
            rdb_Si_DepEcon.Checked = True
            rdb_No_DepEcon.Checked = False
        Else
            rdb_No_DepEcon.Checked = True
            rdb_Si_DepEcon.Checked = False
        End If

        If lsv_Familiares.SelectedItems(0).SubItems(0).Tag = 1 Or lsv_Familiares.SelectedItems(0).SubItems(0).Tag Is Nothing Then Modificando = True

        lsv_Familiares.SelectedItems(0).Remove()
    End Sub

    Private Sub btn_Borrar_DatosFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_DatosFamiliares.Click
        SegundosDesconexion = 0

        If MsgBox("Los datos seleccionados serán borrados permanentemente. ¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
            'lsv_Familiares.SelectedItems(0).Tag 
            If lsv_Familiares.SelectedItems(0).SubItems(0).Tag = 1 Or lsv_Familiares.SelectedItems(0).SubItems(0).Tag Is Nothing Then
                If Not fn_DatosFamiliaresP_Borrar(lsv_Familiares.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar los Datos Familiares.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            fn_DatosFamiliaresP_ObtenValores(lsv_Familiares, Id)
        End If
        btn_Modificar_Familiares.Enabled = False
        btn_Borrar_DatosFamiliares.Enabled = False
    End Sub

    Private Sub btn_Cancelar_DatosFamiliares_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_DatosFamiliares.Click
        SegundosDesconexion = 0

        If FamiliaresAgregados Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

#End Region

#Region "EMPLEOS"

    Public Sub Empleos_LimpiarObjetos()
        tbx_NombreEmpresa_Empleos.Clear()
        tbx_Calle_Empleos.Clear()
        tbx_NumeroExt_Empleos.Clear()
        tbx_NumeroInt_Empleos.Clear()
        cmb_Paises_Empleos.SelectedValue = 0
        cmb_Ciudades_Empleos.SelectedValue = 0
        tbx_Colonias_Empleos.Clear()
        tbx_CodigoPostal_Empleos.Clear()
        dtp_FechaIngreso_Empleos.Value = #1/1/1900#
        dtp_FechaBaja_Empleos.Value = #1/1/1900#
        tbx_Puesto_Empleos.Clear()
        tbx_NombreJefe_Empleos.Clear()
        tbx_PuestoJefe_Empleos.Clear()
        tbx_Telefono_Empleos.Clear()
        tbx_SueldoInicial_Empleos.Clear()
        tbx_SueldoFinal_Empleos.Clear()
        cmb_MotivoSeparacion.SelectedValue = 0
        tbx_OtroMotivo.Clear()

        tbx_EntreCalle1Empleos.Clear()
        tbx_EntreCalle2Empleos.Clear()
        rdb_Si_EmpresaSeg.Checked = False
        rdb_No_EmpresaSeg.Checked = False
        rdb_Si_PorteArmas.Checked = False
        rdb_No_PorteArmas.Checked = False
        ' tbx_ColoniaEmpleos.Clear()
        tbx_LatitudEmpleos.Clear()
        tbx_LongitudEmpleos.Clear()

        tbx_NombreEmpresa_Empleos.Tag = 0

        If Tab_Catalogo.SelectedIndex = 0 Then
            lsv_Empleos.Items.Clear()
            btn_Guardar_Empleos.Enabled = False
        End If

        btn_Modificar_Empleos.Enabled = False
        btn_Borrar_Empleos.Enabled = False

        Modificando = False
    End Sub

    Private Sub btn_Agregar_Empleos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Empleos.Click
        SegundosDesconexion = 0

        If tbx_NombreEmpresa_Empleos.Text = "" Then
            MsgBox("Capture el Nombre de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreEmpresa_Empleos.Focus()
            Exit Sub
        End If

        If tbx_Calle_Empleos.Text = "" Then
            MsgBox("Capture la Calle.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Calle_Empleos.Focus()
            Exit Sub
        End If

        If tbx_NumeroExt_Empleos.Text = "" Then
            MsgBox("Capture el Número Exterior.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NumeroExt_Empleos.Focus()
            Exit Sub
        End If

        If InStr(tbx_NumeroExt_Empleos.Text.Trim, "-") Then
            tbx_NumeroExt_Empleos.Text = Replace(tbx_NumeroExt_Empleos.Text, "-", "")
        End If

        If cmb_Ciudades_Empleos.SelectedValue = 0 Then
            MsgBox("Seleccione la Ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Ciudades_Empleos.Focus()
            Exit Sub
        End If


        If tbx_Telefono_Empleos.Text = "" Then
            MsgBox("Capture el Teléfono de la Empresa.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Telefono_Empleos.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Year, dtp_FechaIngreso_Empleos.Value, Today) > 50 Then
            MsgBox("Fecha de Ingreso es incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaIngreso_Empleos.Focus()
            Exit Sub
        End If

        If DateDiff(DateInterval.Year, dtp_FechaBaja_Empleos.Value, Today) > 50 Then
            MsgBox("Fecha de Ingreso es incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaBaja_Empleos.Focus()
            Exit Sub
        End If

        If dtp_FechaBaja_Empleos.Value < dtp_FechaIngreso_Empleos.Value Then
            MsgBox("Fecha de Ingreso debe ser mayor a Fecha de Baja.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_FechaIngreso_Empleos.Focus()
            Exit Sub
        End If

        If Not rdb_Si_EmpresaSeg.Checked And Not rdb_No_EmpresaSeg.Checked Then
            MsgBox("Seleccione si es Empresa de Seguridad.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_EmpresaSeg.Focus()
            Exit Sub
        End If

        If rdb_Si_EmpresaSeg.Checked Then
            If Not rdb_Si_PorteArmas.Checked And Not rdb_No_PorteArmas.Checked Then
                MsgBox("Seleccione Porte de Armas.", MsgBoxStyle.Critical, frm_MENU.Text)
                gbx_PorteArmas.Focus()
                Exit Sub
            End If
        End If

        If tbx_Puesto_Empleos.Text = "" Then
            MsgBox("Capture el Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Puesto_Empleos.Focus()
            Exit Sub
        End If

        If tbx_NombreJefe_Empleos.Text = "" Then
            MsgBox("Capture el Nombre del Jefe Inmediato.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_NombreJefe_Empleos.Focus()
            Exit Sub
        End If

        If tbx_PuestoJefe_Empleos.Text = "" Then
            MsgBox("Capture el Puesto del Jefe Inmediato.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_PuestoJefe_Empleos.Focus()
            Exit Sub
        End If

        If tbx_SueldoInicial_Empleos.Text = "" Then
            MsgBox("Capture el Sueldo Inicial.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_SueldoInicial_Empleos.Focus()
            Exit Sub
        End If

        If tbx_SueldoFinal_Empleos.Text = "" Then
            MsgBox("Capture el Sueldo Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_SueldoFinal_Empleos.Focus()
            Exit Sub
        End If

        If cmb_MotivoSeparacion.SelectedValue = 0 Then
            MsgBox("Seleccione el Motivo de Separación.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_MotivoSeparacion.Focus()
            Exit Sub
        End If

        'NombreEmpresa  item
        'Calle          subitem(1)
        'EntreCalle1    subitem(2)
        'EntreCalle2    subitem(3)
        'NumeroExt      subitem(4)
        'NumeroInt      subitem(5)
        'Colonia        subitem(6)
        'Ciudad         subitem(7)
        'CodigoPostal   subitem(8)
        'Latitud        subitem(9)
        'Longitud       subitem(10)
        'FIngreso       subitem(11)
        'FBaja          subitem(12)
        'Puesto         subitem(13)
        'NombreJefe     subitem(14)
        'PuestoJefe     subitem(15)
        'Telefono       subitem(16)
        'SueldoInicial  subitem(17)
        'SueldoFinal    subitem(18)
        'MotivoSep      subitem(19)
        'OtroMotivo     subitem(20)
        'EmpResaSeg     subitem(21)
        'PorteArmas     subitem(22)
        'Id_Ciudad      subitem(23)
        'Id_MotivoSep   subitem(24)

        Dim Linea As ListViewItem

        Linea = lsv_Empleos.Items.Add(tbx_NombreEmpresa_Empleos.Text)
        Linea.SubItems.Add(tbx_Calle_Empleos.Text)          '1
        Linea.SubItems.Add(tbx_EntreCalle1Empleos.Text)     '2
        Linea.SubItems.Add(tbx_EntreCalle2Empleos.Text)     '3
        Linea.SubItems.Add(tbx_NumeroExt_Empleos.Text)      '4
        Linea.SubItems.Add(tbx_NumeroInt_Empleos.Text)      '5
        Linea.SubItems.Add(tbx_Colonias_Empleos.Text)       '6
        Linea.SubItems.Add(cmb_Ciudades_Empleos.Text)       '7
        Linea.SubItems.Add(tbx_CodigoPostal_Empleos.Text)   '8
        Linea.SubItems.Add(tbx_LatitudEmpleos.Text)         '9
        Linea.SubItems.Add(tbx_LongitudEmpleos.Text)        '10
        Linea.SubItems.Add(dtp_FechaIngreso_Empleos.Value)  '11
        Linea.SubItems.Add(dtp_FechaBaja_Empleos.Value)     '12
        Linea.SubItems.Add(tbx_Puesto_Empleos.Text)         '13
        Linea.SubItems.Add(tbx_NombreJefe_Empleos.Text)     '14
        Linea.SubItems.Add(tbx_PuestoJefe_Empleos.Text)     '15
        Linea.SubItems.Add(tbx_Telefono_Empleos.Text)       '16
        Linea.SubItems.Add(tbx_SueldoInicial_Empleos.Text)  '17
        Linea.SubItems.Add(tbx_SueldoFinal_Empleos.Text)    '18
        Linea.SubItems.Add(cmb_MotivoSeparacion.Text)       '19
        Linea.SubItems.Add(tbx_OtroMotivo.Text)             '20


        If rdb_Si_EmpresaSeg.Checked Then
            Linea.SubItems.Add("SI")                        '22
        Else
            Linea.SubItems.Add("NO")                        '23
        End If
        If rdb_Si_PorteArmas.Checked Then
            Linea.SubItems.Add("SI")                        '24
        Else
            Linea.SubItems.Add("NO")                        '25
        End If
        Linea.SubItems.Add(cmb_Ciudades_Empleos.SelectedValue) '26
        Linea.SubItems.Add(cmb_MotivoSeparacion.SelectedValue) '27
        Linea.SubItems.Add(cmb_Paises_Empleos.SelectedValue)
        'Se le asigna un valor al Tag de la linea agregada
        'tbx_NombreEmpresa_Empleos.Tag = 0 ----> Empleo Nuevo
        'tbx_NombreEmpresa_Empleos.Tag > 0 ----> Empleo Existente Modificado
        Linea.Tag = tbx_NombreEmpresa_Empleos.Tag

        EmpleosAgregados = True

        Empleos_LimpiarObjetos()

        btn_Guardar_Empleos.Enabled = True
    End Sub

    Private Sub btn_Guardar_Empleos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Empleos.Click
        SegundosDesconexion = 0

        If EmpleosAgregados Then
            If fn_EmpleosP_Guardar(Id, lsv_Empleos) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)

                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                EmpleosAgregados = False

                'Aqui se limpian los textbox
                Call Empleos_LimpiarObjetos()
                btn_Guardar_Empleos.Enabled = False
                btn_Modificar_Empleos.Enabled = False
                btn_Borrar_Empleos.Enabled = False

                'Aquí se actualiza el listview de EMPLEOS 
                If Not fn_EmpleosP_ObtenValores(lsv_Empleos, Id) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar las Empleos anteriores.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            MsgBox("No se han agregado nuevos Empleos.", MsgBoxStyle.Information, frm_MENU.Text)
            tbx_NombreEmpresa_Empleos.Focus()
        End If
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub btn_Modificar_Empleos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_Empleos.Click, lsv_Empleos.DoubleClick
        SegundosDesconexion = 0

        Predictivo = True
        Call Empleos_LimpiarObjetos()

        'NombreEmpresa  item
        'Calle          subitem(1)
        'EntreCalle1    subitem(2)
        'EntreCalle2    subitem(3)
        'NumeroExt      subitem(4)
        'NumeroInt      subitem(5)
        'Colonia        subitem(6)
        'Ciudad         subitem(7)
        'CodigoPostal   subitem(8)
        'Latitud        subitem(9)
        'Longitud       subitem(10)
        'FIngreso       subitem(11)
        'FBaja          subitem(12)
        'Puesto         subitem(13)
        'NombreJefe     subitem(14)
        'PuestoJefe     subitem(15)
        'Telefono       subitem(16)
        'SueldoInicial  subitem(17)
        'SueldoFinal    subitem(18)
        'MotivoSep      subitem(19)
        'OtroMotivo     subitem(20)
        'EmpResaSeg     subitem(21)
        'PorteArmas     subitem(22)
        'Id_Ciudad      subitem(23)
        'Id_MotivoSep   subitem(24)
        'Id_Pais        subitem(25)



        tbx_NombreEmpresa_Empleos.Tag = lsv_Empleos.SelectedItems(0).Tag
        tbx_NombreEmpresa_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(0).Text

        tbx_Calle_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(1).Text
        tbx_EntreCalle1Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(2).Text
        tbx_EntreCalle2Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(3).Text

        tbx_NumeroExt_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(4).Text
        tbx_NumeroInt_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(5).Text
        tbx_CodigoPostal_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(8).Text

        tbx_LatitudEmpleos.Text = lsv_Empleos.SelectedItems(0).SubItems(9).Text
        tbx_LongitudEmpleos.Text = lsv_Empleos.SelectedItems(0).SubItems(10).Text

        dtp_FechaIngreso_Empleos.Value = lsv_Empleos.SelectedItems(0).SubItems(11).Text
        dtp_FechaBaja_Empleos.Value = lsv_Empleos.SelectedItems(0).SubItems(12).Text

        tbx_Puesto_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(13).Text
        tbx_NombreJefe_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(14).Text
        tbx_PuestoJefe_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(15).Text

        tbx_Telefono_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(16).Text
        tbx_SueldoInicial_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(17).Text
        tbx_SueldoFinal_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(18).Text

        tbx_OtroMotivo.Text = lsv_Empleos.SelectedItems(0).SubItems(20).Text
        cmb_Paises_Empleos.SelectedValue = lsv_Empleos.SelectedItems(0).SubItems(25).Text
        cmb_Ciudades_Empleos.SelectedValue = lsv_Empleos.SelectedItems(0).SubItems(23).Text
        cmb_MotivoSeparacion.SelectedValue = lsv_Empleos.SelectedItems(0).SubItems(24).Text



        If lsv_Empleos.SelectedItems(0).SubItems(21).Text = "SI" Then
            rdb_Si_EmpresaSeg.Checked = True
            If lsv_Empleos.SelectedItems(0).SubItems(22).Text = "SI" Then
                rdb_Si_PorteArmas.Checked = True
            Else
                rdb_No_PorteArmas.Checked = True
            End If
        Else
            rdb_No_EmpresaSeg.Checked = True
        End If
        tbx_Colonias_Empleos.Text = lsv_Empleos.SelectedItems(0).SubItems(6).Text

        Modificando = True

        lsv_Empleos.SelectedItems(0).Remove()
    End Sub

    Private Sub btn_Borrar_Empleos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_Empleos.Click
        SegundosDesconexion = 0

        If MsgBox("Los datos seleccionados serán borrados permanentemente. ¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
            If lsv_Empleos.SelectedItems(0).Tag > 0 Then
                If Not fn_EmpleosP_Borrar(lsv_Empleos.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar las Empresas de Seguridad.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            Call fn_EmpleosP_ObtenValores(lsv_Empleos, Id)
        End If
        If lsv_Empleos.Items.Count = 0 Then
            btn_Guardar_Empleos.Enabled = False
            EmpleosAgregados = False
        End If
        btn_Modificar_Empleos.Enabled = False
        btn_Borrar_Empleos.Enabled = False
    End Sub

    Private Sub btn_MapaLaborales_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_MapaLaborales.Click
        SegundosDesconexion = 0

        'Para Agregar Columnas como Nombre o Descripcion el formato es "Columna+Columna2+Columna3"
        Dim frm As New frm_MapasGo
        frm.Text = "Mapa de Localización de Empresas(Referencias Laborales)."
        frm.Lsv_Lista = lsv_Empleos
        frm.ColLat = 9
        frm.ColLon = 10
        frm.Nombre = "0"
        frm.TipoMapa = 3
        frm.ZoomdelMapa = 12
        frm.ShowDialog()
    End Sub

    Private Sub btn_Cancelar_Empleos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_Empleos.Click
        SegundosDesconexion = 0

        If EmpleosAgregados Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

    Private Sub lsv_Empleos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Empleos.SelectedIndexChanged
        SegundosDesconexion = 0

        btn_Modificar_Empleos.Enabled = False
        btn_Borrar_Empleos.Enabled = False
        btn_Investigacion.Enabled = False
        If lsv_Empleos.SelectedItems.Count > 0 Then
            IdReferencia = Integer.Parse(lsv_Empleos.SelectedItems(0).Tag)
            Referencia = lsv_Empleos.SelectedItems(0).SubItems(14).Text
            CandidatoReferencia = tbx_NombreCompleto.Text
            TelefonoReferencia = lsv_Empleos.SelectedItems(0).SubItems(16).Text
            If Not Modificando Then
                btn_Modificar_Empleos.Enabled = True
                btn_Borrar_Empleos.Enabled = True
                btn_Investigacion.Enabled = True
            End If
        End If

    End Sub

    Private Sub tbx_NombreEmpresa_Empleos_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_NombreEmpresa_Empleos.TextChanged
        If Predictivo Then Exit Sub
        lsv_PredictivoEmpresas.Items.Clear()
        'LimpiarDatosPredictivo()
        Dim Encontrado As Boolean = False

        If Len(tbx_NombreEmpresa_Empleos.Text) > 3 AndAlso dt_PredictivoEmpresas IsNot Nothing AndAlso dt_PredictivoEmpresas.Rows.Count > 0 Then
            For Each elemento As DataRow In dt_PredictivoEmpresas.Rows
                If InStr(1, elemento("Empresa"), tbx_NombreEmpresa_Empleos.Text) > 0 Then
                    lsv_PredictivoEmpresas.Items.Add(elemento("Empresa"))
                    lsv_PredictivoEmpresas.Items(lsv_PredictivoEmpresas.Items.Count - 1).Tag = elemento("ID")
                    lsv_PredictivoEmpresas.Items(lsv_PredictivoEmpresas.Items.Count - 1).SubItems.Add(elemento("Direccion"))
                    lsv_PredictivoEmpresas.Items(lsv_PredictivoEmpresas.Items.Count - 1).SubItems.Add(elemento("IDP"))
                    Encontrado = True
                End If
            Next
            If Encontrado Then
                lsv_PredictivoEmpresas.Visible = True
            Else
                lsv_PredictivoEmpresas.Visible = False
            End If
        Else
            lsv_PredictivoEmpresas.Visible = False
        End If
        Predictivo = False
    End Sub

    Private Sub tbx_NombreEmpresa_Empleos_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles tbx_NombreEmpresa_Empleos.KeyDown
        If lsv_PredictivoEmpresas.Visible AndAlso e.KeyCode = Keys.Down Then
            If lsv_PredictivoEmpresas.Items.Count > 0 Then
                lsv_PredictivoEmpresas.Focus()
                lsv_PredictivoEmpresas.Items(0).Selected = True
                Predictivo = True
            End If
            'tbx_NombreEmpresa_Empleos.Text = lsv_PredictivoEmpresas.SelectedItems(0).Text
        End If
    End Sub

    Private Sub tbx_NombreEmpresa_Empleos_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_NombreEmpresa_Empleos.KeyPress
        Predictivo = False
    End Sub

    Private Sub dtp_FechaIngreso_Empleos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaIngreso_Empleos.Enter
        If dtp_FechaIngreso_Empleos.Value = #1/1/1900# Then
            dtp_FechaIngreso_Empleos.Value = Today
        End If
    End Sub

    Private Sub dtp_FechaBaja_Empleos_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_FechaBaja_Empleos.Enter
        If dtp_FechaBaja_Empleos.Value = #1/1/1900# Then
            dtp_FechaBaja_Empleos.Value = Today
        End If
    End Sub

    Private Sub rdb_Si_EmpresaSeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Si_EmpresaSeg.CheckedChanged
        SegundosDesconexion = 0

        gbx_PorteArmas.Enabled = rdb_Si_EmpresaSeg.Checked
    End Sub

    Private Sub rdb_No_EmpresaSeg_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_No_EmpresaSeg.CheckedChanged
        SegundosDesconexion = 0

        If rdb_No_EmpresaSeg.Checked Then
            rdb_Si_PorteArmas.Checked = False
            rdb_No_PorteArmas.Checked = False
        End If
    End Sub

    Private Sub lsv_PredictivoEmpresas_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles lsv_PredictivoEmpresas.KeyPress
        'If lsv_PredictivoEmpresas.SelectedItems.Count = 0 Then Exit Sub

        If Asc(e.KeyChar) = Keys.Escape Then
            'LimpiarDatosPredictivo()
            lsv_PredictivoEmpresas.Visible = False
            tbx_NombreEmpresa_Empleos.Focus()
            tbx_NombreEmpresa_Empleos.SelectionStart = Len(tbx_NombreEmpresa_Empleos.Text)
        End If
        If Asc(e.KeyChar) = Keys.Enter Then
            tbx_NombreEmpresa_Empleos.Text = lsv_PredictivoEmpresas.SelectedItems(0).Text
            tbx_NombreEmpresa_Empleos.Focus()
            tbx_NombreEmpresa_Empleos.SelectionStart = Len(tbx_NombreEmpresa_Empleos.Text)
            lsv_PredictivoEmpresas.Visible = False
            Predictivo = False
            Call LimpiarDatosPredictivo()
            Call LlenarDatosPredictivo()
        End If
    End Sub

    Private Sub lsv_PredictivoEmpresas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles lsv_PredictivoEmpresas.KeyUp
        If e.KeyCode = Keys.Escape Then
            'LimpiarDatosPredictivo()
            lsv_PredictivoEmpresas.Visible = False
            tbx_NombreEmpresa_Empleos.Focus()
            tbx_NombreEmpresa_Empleos.SelectionStart = Len(tbx_NombreEmpresa_Empleos.Text)
            Predictivo = True
        End If
    End Sub

    Private Sub lsv_PredictivoEmpresas_MouseDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_PredictivoEmpresas.MouseDoubleClick
        If lsv_PredictivoEmpresas.SelectedItems.Count = 0 Then Exit Sub
        tbx_NombreEmpresa_Empleos.Text = lsv_PredictivoEmpresas.SelectedItems(0).Text
        tbx_NombreEmpresa_Empleos.Focus()
        tbx_NombreEmpresa_Empleos.SelectionStart = Len(tbx_NombreEmpresa_Empleos.Text)
        lsv_PredictivoEmpresas.Visible = False
        Predictivo = False

        Call LimpiarDatosPredictivo()
        Call LlenarDatosPredictivo()
    End Sub

    Private Sub lsv_PredictivoEmpresas_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_PredictivoEmpresas.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_PredictivoEmpresas.SelectedItems.Count = 0 Then Exit Sub
        Predictivo = True
    End Sub

    Sub LimpiarDatosPredictivo()
        tbx_Calle_Empleos.Clear()
        tbx_EntreCalle1Empleos.Clear()
        tbx_EntreCalle2Empleos.Clear()
        tbx_NumeroExt_Empleos.Clear()
        tbx_NumeroInt_Empleos.Clear()
        tbx_Colonias_Empleos.Clear()
        cmb_Ciudades_Empleos.SelectedValue = 0
        tbx_CodigoPostal_Empleos.Clear()
        tbx_LatitudEmpleos.Clear()
        tbx_LongitudEmpleos.Clear()
        tbx_Telefono_Empleos.Clear()
    End Sub

    Sub LlenarDatosPredictivo()
        Dim dr_Datos As DataRow
        If CInt(lsv_PredictivoEmpresas.SelectedItems(0).Tag) > 0 Then
            'Consultar por el Id_EmpleadosLaborales
            dr_Datos = fn_EmpleosP_ObtenValoresPredictivo(CInt(lsv_PredictivoEmpresas.SelectedItems(0).Tag), "E")
        ElseIf CInt(lsv_PredictivoEmpresas.SelectedItems(0).SubItems(2).Text) > 0 Then
            'Consultar por el Id_EmpleadosPLaborales
            dr_Datos = fn_EmpleosP_ObtenValoresPredictivo(CInt(lsv_PredictivoEmpresas.SelectedItems(0).SubItems(2).Text), "P")
        End If

        If Not dr_Datos Is Nothing Then
            tbx_Calle_Empleos.Text = dr_Datos("Calle")
            tbx_EntreCalle1Empleos.Text = dr_Datos("EntreCalle1")
            tbx_EntreCalle2Empleos.Text = dr_Datos("EntreCalle2")
            tbx_NumeroExt_Empleos.Text = dr_Datos("NumeroExt")
            tbx_NumeroInt_Empleos.Text = dr_Datos("NumeroInt")
            tbx_Colonias_Empleos.Text = dr_Datos("Colonia")
            cmb_Ciudades_Empleos.SelectedValue = dr_Datos("Id_Ciudad")
            tbx_CodigoPostal_Empleos.Text = dr_Datos("CodigoPostal")
            tbx_LatitudEmpleos.Text = dr_Datos("Latitud")
            tbx_LongitudEmpleos.Text = dr_Datos("Longitud")
            tbx_Telefono_Empleos.Text = dr_Datos("Telefono")
        End If
    End Sub

#End Region

#Region "REFERENCIAS"

    Public Sub Referencias_LimpiarObjetos()
        cmb_TipoReferencia.SelectedValue = 0
        cmb_ocupacion.SelectedValue = 0
        tbx_Nombre_Referencia.Clear()
        rdb_Masculino_Referencias.Checked = False
        rdb_Femenino_Referencias.Checked = False
        tbx_Ocupacion_Referencias.Clear()
        tbx_Calle_Referencias.Clear()
        tbx_NumeroExt_Referencias.Clear()
        tbx_NumeroInt_Referencias.Clear()
        tbx_Telefono_Referencias.Clear()
        cmb_Paises_Referencias.SelectedValue = 0
        cmb_Ciudades_Referencias.SelectedValue = 0
        tbx_Colonia_Referencias.Clear()
        tbx_CodigoPostal_Referencias.Clear()

        tbx_EntreCalle1_Referencias.Clear()
        tbx_EntreCalle2_Referencias.Clear()
        ' tbx_Colonia_Referencias.Clear()

        tbx_Nombre_Referencia.Tag = 0

        If Tab_Catalogo.SelectedIndex = 0 Then
            lsv_Referencias.Items.Clear()
            btn_Guardar_Referencias.Enabled = False
        End If

        txt_ap.Clear()
        txt_am.Clear()
        btn_Modificar_Referencias.Enabled = False
        btn_Borrar_Referencias.Enabled = False
        lsv_Referencias.Enabled = True
        Modificando = False
    End Sub

    Private Sub btn_Agregar_Referencias_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_Agregar_Referencias.Click
        SegundosDesconexion = 0

        If cmb_TipoReferencia.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoReferencia.Focus()
            Exit Sub
        End If

        If tbx_Nombre_Referencia.Text = "" Then
            MsgBox("Capture el Nombre.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Nombre_Referencia.Focus()
            Exit Sub
        End If
        If txt_ap.Text = "" Then
            MsgBox("Capture el apellido paterno.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_ap.Focus()
            Exit Sub
        End If

        If txt_am.Text = "" Then
            MsgBox("Capture el apellido materno.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_am.Focus()
            Exit Sub
        End If

        If cmb_ocupacion.SelectedValue = 0 Then
            MsgBox("Seleccione una ocupacion.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoReferencia.Focus()
            Exit Sub
        End If

        If Not rdb_Masculino_Referencias.Checked And Not rdb_Femenino_Referencias.Checked Then
            MsgBox("Seleccione el Género.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_Genero_Referencias.Focus()
            Exit Sub
        End If

        If InStr(tbx_NumeroExt_Referencias.Text.Trim, "-") Then
            tbx_NumeroExt_Referencias.Text = Replace(tbx_NumeroExt_Referencias.Text, "-", "")
        End If

        If tbx_Telefono_Referencias.Text = "" Then
            MsgBox("Capture el Teléfono.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Telefono_Referencias.Focus()
            Exit Sub
        End If

        Dim Linea As ListViewItem

        Linea = lsv_Referencias.Items.Add(cmb_TipoReferencia.Text)
        Linea.SubItems.Add(tbx_Nombre_Referencia.Text)          '1
        If rdb_Masculino_Referencias.Checked Then
            Linea.SubItems.Add("M")                             '2
        Else
            Linea.SubItems.Add("F")                             '2
        End If
        Linea.SubItems.Add(cmb_ocupacion.Text)      '3
        Linea.SubItems.Add(tbx_Calle_Referencias.Text)          '4
        Linea.SubItems.Add(tbx_EntreCalle1_Referencias.Text)    '5
        Linea.SubItems.Add(tbx_EntreCalle2_Referencias.Text)    '6
        If tbx_NumeroExt_Referencias.Text = "" Then
            Linea.SubItems.Add("0")                             '7
        Else
            Linea.SubItems.Add(tbx_NumeroExt_Referencias.Text)  '7
        End If
        Linea.SubItems.Add(tbx_NumeroInt_Referencias.Text)      '8
        Linea.SubItems.Add(tbx_Colonia_Referencias.Text)        '9
        If cmb_Ciudades_Referencias.SelectedValue = 0 Then
            Linea.SubItems.Add("")                              '10
        Else
            Linea.SubItems.Add(cmb_Ciudades_Referencias.Text)   '10
        End If
        If tbx_CodigoPostal_Referencias.Text = "" Then
            Linea.SubItems.Add("0")                             '11
        Else
            Linea.SubItems.Add(tbx_CodigoPostal_Referencias.Text) '11
        End If
        Linea.SubItems.Add(tbx_Telefono_Referencias.Text)       '12
        Linea.SubItems.Add("ACTIVO")                            '13
        Linea.SubItems.Add(cmb_TipoReferencia.SelectedValue)    '14
        Linea.SubItems.Add(cmb_Paises_Referencias.SelectedValue) '15
        Linea.SubItems.Add(cmb_Ciudades_Referencias.SelectedValue) '16
        'Linea.SubItems.Add("P")    '17
        Linea.SubItems.Add(cmb_ocupacion.SelectedValue)    '18
        Linea.SubItems.Add(txt_ap.Text)    '19
        Linea.SubItems.Add(txt_am.Text)    '20


        'Linea.SubItems.Add()
        'Para indicar si es un registro que se modificó o un registro nuevo
        If Modificando Then
            Linea.SubItems(0).Tag = 1 'Registro modificado
        Else
            Linea.SubItems(0).Tag = 0 'Registro Nuevo
        End If

        'Se le asigna un valor al Tag de la linea agregada
        'tbx_Nombre_Referencia.Tag = 0 ----> Referencia Nueva
        'tbx_Nombre_Referencia.Tag > 0 ----> Referencia Existente Modificada
        Linea.Tag = tbx_Nombre_Referencia.Tag

        ReferenciasAgregadas = True
        'For Each c In lsv_Referencias.Columns
        '    c.Width = 20
        'Next

        Call Referencias_LimpiarObjetos()
        lsv_Referencias.Enabled = True
        btn_Guardar_Referencias.Enabled = True
    End Sub

    Private Sub btn_Guardar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Referencias.Click
        SegundosDesconexion = 0

        'Tipo Referencia    ---> item
        'NombreReferencia   ---> subitem(1)
        'Sexo               ---> subitem(2)
        'Ocupacion          ---> subitem(3)
        'Calle              ---> subitem(4)
        'EntreCalle1        ---> subitem(5)
        'EntreCalle2        ---> subitem(6)
        'NumeroExt          ---> subitem(7)
        'NumeroInt          ---> subitem(8)
        'Colonia            ---> subitem(9)
        'Ciudad             ---> subitem(10)
        'CodigoPostal       ---> subitem(11)
        'Telefono           ---> subitem(12)
        'Status             ---> subitem(13)
        'Id_TipoReferencia  ---> subitem(14)
        'Id_Ciudades        ---> subitem(15)


        If ReferenciasAgregadas Then
            If fn_ReferenciasP_Guardar(Id, lsv_Referencias) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)
                FuncionesGlobales.fn_Menu_Progreso(0)

                MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

                ReferenciasAgregadas = False

                'Aqui se limpian los textbox
                Call Referencias_LimpiarObjetos()
                btn_Guardar_Referencias.Enabled = False
                btn_Modificar_Referencias.Enabled = False
                btn_Borrar_Referencias.Enabled = False
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            MsgBox("No se han agregado nuevas Referencias.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoReferencia.Focus()
        End If

        'Aquí se actualiza el listview de REFERENCIAS 
        If Not fn_ReferenciasP_ObtenValores(lsv_Referencias, Id) Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Referencias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub btn_Modificar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_Referencias.Click
        Call Modificar_Referencias()
    End Sub

    Private Sub lsv_Referencias_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Referencias.DoubleClick
        Call Modificar_Referencias()
    End Sub

    Sub Modificar_Referencias()
        SegundosDesconexion = 0

        Call Referencias_LimpiarObjetos()

        cmb_TipoReferencia.SelectedValue = lsv_Referencias.SelectedItems(0).SubItems(14).Text
        tbx_Nombre_Referencia.Tag = lsv_Referencias.SelectedItems(0).Tag
        tbx_Nombre_Referencia.Text = lsv_Referencias.SelectedItems(0).SubItems(1).Text
        If lsv_Referencias.SelectedItems(0).SubItems(2).Text = "M" Then
            rdb_Masculino_Referencias.Checked = True
            rdb_Femenino_Referencias.Checked = False
        Else
            rdb_Femenino_Referencias.Checked = True
            rdb_Masculino_Referencias.Checked = False
        End If
        tbx_Ocupacion_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(3).Text
        tbx_Calle_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(4).Text
        tbx_EntreCalle1_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(5).Text
        tbx_EntreCalle2_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(6).Text
        tbx_NumeroExt_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(7).Text
        tbx_NumeroInt_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(8).Text
        cmb_Paises_Referencias.SelectedValue = lsv_Referencias.SelectedItems(0).SubItems(15).Text
        cmb_Ciudades_Referencias.SelectedValue = lsv_Referencias.SelectedItems(0).SubItems(16).Text
        tbx_Colonia_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(9).Text
        tbx_CodigoPostal_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(11).Text
        tbx_Telefono_Referencias.Text = lsv_Referencias.SelectedItems(0).SubItems(12).Text

        'Nuevos campos SSP
        cmb_ocupacion.SelectedValue = lsv_Referencias.SelectedItems(0).SubItems(14).Text 'Id_Ocupacion
        txt_ap.Text = lsv_Referencias.SelectedItems(0).SubItems(18).Text
        txt_am.Text = lsv_Referencias.SelectedItems(0).SubItems(19).Text
        ''


        Modificando = True

        lsv_Referencias.SelectedItems(0).Remove()
    End Sub

    Private Sub btn_Borrar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_Referencias.Click
        SegundosDesconexion = 0

        If MsgBox("Los datos seleccionados serán borrados permanentemente. ¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
            If lsv_Referencias.SelectedItems(0).Tag > 0 Then
                If Not fn_ReferenciasP_Borrar(lsv_Referencias.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar las Empresas de Seguridad.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            fn_ReferenciasP_ObtenValores(lsv_Referencias, Id)
        End If
        If lsv_Referencias.Items.Count = 0 Then
            btn_Guardar_Referencias.Enabled = False
            ReferenciasAgregadas = False
        End If
        btn_Modificar_Referencias.Enabled = False
        btn_Borrar_Referencias.Enabled = False
    End Sub

    Private Sub btn_Cancelar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_Referencias.Click
        SegundosDesconexion = 0

        If ReferenciasAgregadas Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

    Private Sub lsv_Referencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Referencias.SelectedIndexChanged
        SegundosDesconexion = 0
        btn_InvestigacionPersonal.Enabled = False
        If lsv_Referencias.SelectedItems.Count > 0 Then
            IdReferencia = Integer.Parse(lsv_Referencias.SelectedItems(0).Tag)
            Referencia = lsv_Referencias.SelectedItems(0).SubItems(1).Text + " " + lsv_Referencias.SelectedItems(0).SubItems(18).Text + " " + lsv_Referencias.SelectedItems(0).SubItems(19).Text

            CandidatoReferencia = tbx_NombreCompleto.Text
            TelefonoReferencia = lsv_Referencias.SelectedItems(0).SubItems(12).Text
            If Not Modificando Then
                btn_Modificar_Referencias.Enabled = True
                btn_Borrar_Referencias.Enabled = True
                btn_InvestigacionPersonal.Enabled = True
            End If
        End If
    End Sub

#End Region

#Region "DATOS VARIOS"

    Public Sub DatosVarios_LimpiarObjetos()
        tbx_IngresoFamiliar.Clear()
        tbx_IngresoAdicional.Clear()
        tbx_Descripcion_IngresoAdicional.Clear()
        tbx_GastoFamiliar.Clear()
        cmb_TipoVivienda.SelectedValue = 0
        tbx_PagoMensual.Clear()
        tbx_ValorVivienda.Clear()
        rdb_Si_Vehiculo.Checked = False
        rdb_No_Vehiculo.Checked = False
        tbx_Modelo.Clear()
        tbx_ValorVehiculo.Clear()
        tbx_Vicios.Clear()
        tbx_Idiomas.Clear()
        tbx_ActividadesCulturales.Clear()
        tbx_Habilidades.Clear()
        cmb_SeñasParticulares.SelectedValue = 0
        tbx_FormaSeñas.Clear()
        tbx_UbicacionSeñas.Clear()
        tbx_CantidadSeñas.Clear()
    End Sub

    Public Sub Señas_LimpiarObjetos()
        cmb_SeñasParticulares.SelectedValue = 0
        cmb_vista.SelectedIndex = 0
        cmb_lado.SelectedIndex = 0
        cmb_cantidad.SelectedIndex = 0
        cmb_region.SelectedIndex = 0
        tbx_FormaSeñas.Clear()
        tbx_UbicacionSeñas.Clear()
        tbx_Comentarios_Señas.Clear()
        tbx_CantidadSeñas.Clear()

        tbx_FormaSeñas.Tag = 0

        If Tab_Catalogo.SelectedIndex = 0 Then
            lsv_SeñasParticulares.Items.Clear()
        End If

        btn_Modificar_DatosVarios.Enabled = False
        btn_Borrar_DatosVarios.Enabled = False

        Modificando = False
    End Sub

    Private Sub btn_Agregar_Señas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Señas.Click
        SegundosDesconexion = 0

        'If cmb_SeñasParticulares.SelectedValue = 0 Then
        '    MsgBox("Seleccione el Tipo de Seña.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    cmb_SeñasParticulares.Focus() 'Deshabiltd 21/10/1982
        '    Exit Sub
        'End If

        'If cmb_SeñasParticulares.SelectedValue <> 9 Then
        '    If tbx_FormaSeñas.Text = "" Then
        '        MsgBox("Capture la Forma.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        tbx_FormaSeñas.Focus()
        '        Exit Sub
        '    End If

        '    If tbx_UbicacionSeñas.Text = "" Then
        '        MsgBox("Capture la Ubicación.", MsgBoxStyle.Critical, frm_MENU.Text)
        '        tbx_UbicacionSeñas.Focus()
        '        Exit Sub
        '    End If
        'End If
        If cmb_SeñasParticulares.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Seña.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_SeñasParticulares.Focus()
            Exit Sub
        End If

        If cmb_SeñasParticulares.SelectedValue <> 9 Then


            If cmb_vista.SelectedValue = 0.ToString Then
                MsgBox("Capture la vista.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_vista.Focus()
                Exit Sub
            End If

            If cmb_lado.SelectedValue = 0.ToString Then
                MsgBox("Capture el lado.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_lado.Focus()
                Exit Sub
            End If
            If cmb_region.SelectedValue = 0 Then
                MsgBox("Capture la region.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_region.Focus()
                Exit Sub
            End If

            If cmb_cantidad.SelectedValue = 0 Then
                MsgBox("Capture la cantidad.", MsgBoxStyle.Critical, frm_MENU.Text)
                cmb_cantidad.Focus()
                Exit Sub
            End If

            If tbx_FormaSeñas.Text = "" Then
                MsgBox("Capture la Forma.", MsgBoxStyle.Critical, frm_MENU.Text)
                tbx_FormaSeñas.Focus()
                Exit Sub
            End If

        End If

        If tbx_CantidadSeñas.Text = "" Then tbx_CantidadSeñas.Text = 0

        Dim Linea As ListViewItem

        'Linea = lsv_SeñasParticulares.Items.Add(cmb_SeñasParticulares.Text)
        'Linea.SubItems.Add(tbx_FormaSeñas.Text)
        'Linea.SubItems.Add(tbx_UbicacionSeñas.Text)
        'Linea.SubItems.Add(tbx_Comentarios_Señas.Text)
        'Linea.SubItems.Add(cmb_SeñasParticulares.SelectedValue)
        'Linea.SubItems.Add(tbx_CantidadSeñas.Text)
        Linea = lsv_SeñasParticulares.Items.Add(cmb_SeñasParticulares.Text)
        Linea.SubItems.Add(cmb_vista.Text) 'VISTA
        Linea.SubItems.Add(cmb_lado.Text)
        Linea.SubItems.Add(cmb_region.SelectedValue)
        Linea.SubItems.Add(cmb_cantidad.SelectedValue)
        Linea.SubItems.Add(tbx_FormaSeñas.Text)

        Linea.SubItems.Add(tbx_Comentarios_Señas.Text)
        Linea.SubItems.Add(cmb_SeñasParticulares.SelectedValue)

        Linea.SubItems.Add(cmb_vista.SelectedValue)
        Linea.SubItems.Add(cmb_lado.SelectedValue)

        'Se le asigna un valor al Tag de la linea agregada
        'tbx_FormaSeñas.Tag = 0 ----> Seña Nueva
        'tbx_FormaSeñas.Tag > 0 ----> Seña Existente Modificada
        Linea.Tag = tbx_FormaSeñas.Tag

        SeñasAgregadas = True

        Call Señas_LimpiarObjetos()

        btn_Guardar_DatosVarios.Enabled = True
    End Sub

    Private Sub btn_Guardar_DatosVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_DatosVarios.Click
        SegundosDesconexion = 0

        Dim VehiculoPropio As Char

        If tbx_IngresoFamiliar.Text = "" Then
            MsgBox("Capture el Ingreso Familiar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_IngresoFamiliar.Focus()
            Exit Sub
        End If

        If cmb_TipoVivienda.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Vivienda.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoVivienda.Focus()
            Exit Sub
        End If

        If Not rdb_Si_Vehiculo.Checked And Not rdb_No_Vehiculo.Checked Then
            MsgBox("Seleccione Vehículo Propio.", MsgBoxStyle.Critical, frm_MENU.Text)
            gbx_VehiculoPropio.Focus()
            Exit Sub
        End If

        If tbx_IngresoAdicional.Text = "" Then tbx_IngresoAdicional.Text = 0
        If tbx_GastoFamiliar.Text = "" Then tbx_GastoFamiliar.Text = 0
        If tbx_PagoMensual.Text = "" Then tbx_PagoMensual.Text = 0
        If tbx_ValorVivienda.Text = "" Then tbx_ValorVivienda.Text = 0
        If tbx_Modelo.Text = "" Then tbx_Modelo.Text = 0
        If tbx_ValorVehiculo.Text = "" Then tbx_ValorVehiculo.Text = 0
        If rdb_Si_Vehiculo.Checked Then VehiculoPropio = "S" Else VehiculoPropio = "N"
        If tbx_CantidadSeñas.Text = "" Then tbx_CantidadSeñas.Text = 0

        If Id_EmpleadoIngresos > 0 Then
            If fn_EmpleadosIngresosP_Actualizar(Id, tbx_IngresoFamiliar.Text, tbx_IngresoAdicional.Text, tbx_Descripcion_IngresoAdicional.Text, tbx_GastoFamiliar.Text, cmb_TipoVivienda.SelectedValue, tbx_PagoMensual.Text, tbx_ValorVivienda.Text, VehiculoPropio, tbx_Modelo.Text, tbx_ValorVehiculo.Text) Then
                'En caso de que se haya hecho la transaccion
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)
                FuncionesGlobales.fn_Menu_Progreso(0)
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        Else
            Id_EmpleadoIngresos = fn_EmpleadosIngresosP_Nuevo(Id, tbx_IngresoFamiliar.Text, tbx_IngresoAdicional.Text, tbx_Descripcion_IngresoAdicional.Text, tbx_GastoFamiliar.Text, cmb_TipoVivienda.SelectedValue, tbx_PagoMensual.Text, tbx_ValorVivienda.Text, VehiculoPropio, tbx_Modelo.Text, tbx_ValorVehiculo.Text)
        End If

        If Not fn_EmpleadosP_ActualizarVarios(Id, tbx_Vicios.Text, tbx_Habilidades.Text, tbx_ActividadesCulturales.Text, tbx_Idiomas.Text) Then
            'En caso de que no se haya hecho la transaccion
            MsgBox("No se puede editar el elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.fn_Menu_Progreso(0)
        End If

        If SeñasAgregadas Then
            If fn_EmpleadosSenasP_Guardar(Id, lsv_SeñasParticulares) Then
                FuncionesGlobales.fn_Menu_Progreso(30)
                FuncionesGlobales.fn_Menu_Progreso(50)
                FuncionesGlobales.fn_Menu_Progreso(100)

                SeñasAgregadas = False

                Call Señas_LimpiarObjetos()
                btn_Modificar_DatosVarios.Enabled = False
                btn_Borrar_DatosVarios.Enabled = False
            Else
                'En caso de que no se haya hecho la transaccion
                MsgBox("No se puede agregar el nuevo elemento.", MsgBoxStyle.Critical, frm_MENU.Text)
                FuncionesGlobales.fn_Menu_Progreso(0)
            End If
        End If

        'Se actualiza el listview de Señas Particulares
        If Not fn_SeñasParticularesP_ObtenValores(lsv_SeñasParticulares, Id) Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Señas Particulares.", MsgBoxStyle.Critical, frm_MENU.Text)
            FuncionesGlobales.fn_Menu_Progreso(0)
            Exit Sub
        End If

        MsgBox("Datos guardados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        FuncionesGlobales.fn_Menu_Progreso(0)
    End Sub

    Private Sub btn_Modificar_DatosVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_DatosVarios.Click
        SegundosDesconexion = 0

        'Call DatosVarios_LimpiarObjetos()

        'tbx_FormaSeñas.Tag = lsv_SeñasParticulares.SelectedItems(0).Tag
        'cmb_SeñasParticulares.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(4).Text
        'tbx_FormaSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(1).Text
        'tbx_UbicacionSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(2).Text
        'tbx_Comentarios_Señas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(3).Text
        'tbx_CantidadSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(5).Text

        tbx_FormaSeñas.Tag = lsv_SeñasParticulares.SelectedItems(0).Tag
        cmb_SeñasParticulares.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(7).Text
        cmb_vista.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(8).Text 'IIf(lsv_SeñasParticulares.SelectedItems(0).SubItems(1).Text = "FRONTAL(FRENTE)", "F", "D")
        cmb_lado.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(9).Text 'IIf(lsv_SeñasParticulares.SelectedItems(0).SubItems(2).Text = "IZQUIERDO", "I", "D")
        cmb_region.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(3).Text
        cmb_cantidad.SelectedValue = lsv_SeñasParticulares.SelectedItems(0).SubItems(4).Text
        tbx_FormaSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(5).Text
        'tbx_UbicacionSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(2).Text
        tbx_Comentarios_Señas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(6).Text
        'tbx_CantidadSeñas.Text = lsv_SeñasParticulares.SelectedItems(0).SubItems(5).Text

        Modificando = True
        lsv_SeñasParticulares.SelectedItems(0).Remove()
    End Sub

    Private Sub btn_Borrar_DatosVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_DatosVarios.Click
        SegundosDesconexion = 0

        If MsgBox("Los datos seleccionados serán borrados permanentemente. ¿Desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
            If lsv_SeñasParticulares.SelectedItems(0).Tag > 0 Then
                If Not fn_SeñasParticularesP_Borrar(lsv_SeñasParticulares.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar mostrar las Señas Particulares.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
            fn_SeñasParticularesP_ObtenValores(lsv_SeñasParticulares, Id)
        End If
        If lsv_SeñasParticulares.Items.Count = 0 Then SeñasAgregadas = False
        btn_Modificar_DatosVarios.Enabled = False
        btn_Borrar_DatosVarios.Enabled = False
    End Sub

    Private Sub btn_Cancelar_DatosVarios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_DatosVarios.Click
        SegundosDesconexion = 0

        If SeñasAgregadas Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

    Private Sub lsv_SeñasParticulares_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_SeñasParticulares.SelectedIndexChanged
        SegundosDesconexion = 0

        If lsv_SeñasParticulares.SelectedItems.Count > 0 Then
            If Not Modificando Then
                btn_Modificar_DatosVarios.Enabled = True
                btn_Borrar_DatosVarios.Enabled = True
            End If
        End If
    End Sub

    Private Sub rdb_Si_Vehiculo_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdb_Si_Vehiculo.CheckedChanged
        SegundosDesconexion = 0

        tbx_Modelo.Enabled = rdb_Si_Vehiculo.Checked
        tbx_ValorVehiculo.Enabled = rdb_Si_Vehiculo.Checked
    End Sub

#End Region

#Region "PAPELERIA RECIBIDA"

    Sub CargarPapeleriaRecibida()
        lsv_PapeleriaRecibida.Items.Clear()
        If Not fn_DoctoRequeridosProspecto_LlenarLista(lsv_PapeleriaRecibida, Id) Then
            MsgBox("Ha ocurrido un error al intentar mostrar la Papelería Recibida.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        PapeleriaRecibida = lsv_PapeleriaRecibida.CheckedItems.Count
    End Sub

    Private Sub btn_Guardar_PapeleriaRecibida_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_PapeleriaRecibida.Click
        SegundosDesconexion = 0
        'este boton solo puede Crear y Eliminar Documentos
        'las imagenes se gestionan desde la pantalla de Cargar Documentos
        If Not fn_ProspectosDoctos_Actualizar(Id, lsv_PapeleriaRecibida) Then
            MsgBox("Ha ocurrido un error al intentar agregar la Papelería Recibida.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        Call CargarPapeleriaRecibida()
        MsgBox("Registro Modificado.", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Private Sub btn_DoctosImportar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoctosImportar.Click
        SegundosDesconexion = 0

        If Id_Seleccionado = 0 Then
            MsgBox("Ocurrió un error al comprobar la información del Prospecto, vuelva a consultarlo.", MsgBoxStyle.Critical, Me.Text)
            Exit Sub
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CARGAR DOCUMENTOS PARA EL PROSPECTO: " & Clave_Seleccionado & "-" & Nombre_Seleccionado)
        Dim frm As New frm_CargarDoctos
        frm.IdEmp = Id_Seleccionado
        frm.NombreEmpleado = Clave_Seleccionado & "-" & Nombre_Seleccionado
        frm.ClaveEmpleado = Clave_Seleccionado
        frm.Lista = lsv_PapeleriaRecibida
        frm.Tipo = frm_CargarDoctos.Query.Prospectos
        frm.ShowDialog()

        Call CargarPapeleriaRecibida()

    End Sub

#End Region

#Region "D. SOCIOECONÓMICOS"
    'No tiene Información
#End Region

#Region "VALIDACION"

    Private Sub btn_Validar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Validar.Click
        SegundosDesconexion = 0

        ''VALIDAR EL SUELDO BASE
        If tbx_SueldoBase.Text.Trim = "" Then tbx_SueldoBase.Text = 0

        'VALIDAR ENTREVISTAS
        If lsv_Entrevistas.Items.Count = 0 Then
            MsgBox("Faltan Datos de Entrevistas del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_Entrevistas
            Exit Sub
        End If

        'VALIDAR LA FOTOGRAFÍA FORMAL
        If pct_FrenteFormal.Tag = 0 Then
            MsgBox("Falta la Fotografía de Frente Formal por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_Foto
            pct_FrenteFormal.Focus()
            Exit Sub
        End If

        'VALIDAR RASGOS
        If Not ValidarRasgos() Then
            MsgBox("Faltan Rasgos del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_RasgosPersonales
            Exit Sub
        End If

        'VALIDAR DATOS ESCOLARES
        If Not ValidarDatosEscolares() Then
            MsgBox("Faltan Datos Escolares del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_DatosEscolares
            Exit Sub
        End If

        'VALIDAR DATOS FAMILIARES
        If Not ValidarDatosFamiliares() Then
            MsgBox("Faltan Datos Familiares del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_DatosFamiliares
            Exit Sub
        End If

        'VALIDAR DATOS LABORALES
        If Not ValidarDatosLaborales() Then
            MsgBox("Faltan Datos de Empleos del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_Empleos
            Exit Sub
        End If

        'VALIDAR REFERENCIAS
        If Not ValidarDatosReferencias() Then
            MsgBox("Faltan Datos de Referencias del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_Referencias
            Exit Sub
        End If

        'VALIDAR DATOS VARIOS
        If Not ValidarDatosVarios() Then
            MsgBox("Faltan Datos Varios del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_DatosVarios
            Exit Sub
        End If

        If lsv_PapeleriaRecibida.CheckedItems.Count < 5 Then
            'Para que por lo menos tenga 4 documentos marcados
            MsgBox("Falta Papelería Recibida del Prospecto por capturar.", MsgBoxStyle.Critical, frm_MENU.Text)
            tab_DatosEmpleado.SelectedTab = tab_PapeleriaRecibida
            Exit Sub
        End If

        'Sin_Validar: '28/01/2015
        Dim Clave As String = ""
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.ShowDialog()

        If frm.Firma Then

            Dim ClaveManual As String = ""

            If Clave_AutomaticaEmp = "S" Then
                ClaveManual = tbx_Clave.Text.Trim
            Else
                ClaveManual = InputBox("Capture la Clave para el Nuevo Empleado.", "Capturar Clave...")
            End If

            If ClaveManual = "" Then
                MsgBox("No se pudo Validar al Prospecto.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            If ClaveManual.Length > 12 Then
                MsgBox("La Nueva Clave para el Empleado debe ser Menor a 12 Caracteres.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'SE LE MANDA LA CLAVE QUE CAPTURA EL RECLUTADOR.
            If Not fn_EmpleadosP_ActualizaStatus(Id, "V", frm.Observaciones, True, dtp_FechaIngreso.Value.Date, ClaveManual.ToUpper) Then
                MsgBox("Ha ocurrido un error al intentar guardar los datos.", MsgBoxStyle.Critical, frm_MENU.Text)
                Try
                    If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
                    If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
                Catch
                End Try
                Exit Sub
            Else
                Call GuardarImagen()

                btn_Validar.Enabled = False

                'YA SE INSERTÓ EL NUEVO EMPLEADO PERO NO TENGO LA CLAVE GENERADA CUANDO ES AUTOMÁTICA YA QUE
                'SE CREA DENTRO DEL PROCEDIMIENTO
                If Clave_AutomaticaEmp = "S" Then
                    Dim dr_Empleado As DataRow = fn_Empleados_ObtenValores(Id_EmpleadoRecienCreado)
                    If dr_Empleado IsNot Nothing Then
                        Clave = dr_Empleado("Clave")
                        dr_Empleado = Nothing
                    End If

                Else
                    Clave = ClaveManual
                End If
                Id_EmpleadoRecienCreado = 0


                'Falta generarle el codigo de barras

                '****A partir del 24 de Enero de 2017 ya no se guarda el código de barras porque ya no se usa en las Credenciales

                ' ''Dim Dt As DataTable
                ' ''Dt = fn_ClaveEmpleado_Consultar(Id)
                ' ''If Dt Is Nothing Then
                ' ''    MsgBox("Los datos han sido guardados correctamente pero no se pudo guardar el Código de Barras. Debe ir al catálogo de empleados y actualizar la información.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                ' ''Else
                ' ''    If Dt.Rows.Count = 0 Then
                ' ''        MsgBox("Los datos han sido guardados correctamente pero no se pudo guardar el Código de Barras. Debe ir al catálogo de empleados y actualizar la información.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                ' ''    Else
                ' ''        Dim Id As Integer = Dt.Rows(0)("Id_Empleado")
                ' ''        Clave = Dt.Rows(0)("Clave_Empleado")
                ' ''        Dim Id_EmpleadoI As Integer = Dt.Rows(0)("Id_EmpleadoI")
                ' ''        Dim TImagen As Boolean = False
                ' ''        If Id_EmpleadoI > 0 Then TImagen = True
                ' ''        Dt.Dispose()
                ' ''        If Clave <> "" Then
                ' ''            Dim Bytes As Byte()
                ' ''            Dim fs 'As New System.IO.FileStream("", FileMode.Open)
                ' ''            Codigo.DataToEncode = FuncionesGlobales.fn_PonerCeros(Clave, Clave.Length + 3)
                ' ''            pct_Codigo.Image = Codigo.BMPPicture
                ' ''            'Extraer el Codigo
                ' ''            Dim Imagen1 As New Bitmap(pct_Codigo.Image)
                ' ''            Imagen1.Save(RutaTemp & "PCT_Codigo.jpg", System.Drawing.Imaging.ImageFormat.Jpeg)

                ' ''            'Convertir las Imagenes en Bytes
                ' ''            If File.Exists(RutaTemp & "PCT_Codigo.jpg") Then
                ' ''                fs = New System.IO.FileStream(RutaTemp & "PCT_Codigo.jpg", System.IO.FileMode.Open)
                ' ''                Bytes = New Byte(fs.Length - 1) {}
                ' ''                fs.Read(Bytes, 0, Bytes.Length)
                ' ''                fs.Close()
                ' ''            End If

                ' ''            'Guardar el Codigo de Barras
                ' ''            If Not fn_EmpleadosI_Actualizar(Id, Bytes, TImagen, TipoFoto.Codigo) Then
                ' ''                MsgBox("Los datos han sido guardados correctamente pero no se pudo guardar el Código de Barras. Debe ir al catálogo de empleados y actualizar la información.", MsgBoxStyle.Exclamation, frm_MENU.Text)
                ' ''            Else
                ' ''                MsgBox("Los datos han sido guardado correctamente. Para que se le pueda expedir una credencial, primero debe ir al catálogo de empleados y capturar las Fotografías.", MsgBoxStyle.Information, frm_MENU.Text)
                ' ''            End If
                ' ''        End If
                ' ''    End If
                ' ''End If
                Try
                    If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
                    If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
                    If File.Exists(RutaTemp & "PCT_Codigo.jpg") Then Kill(RutaTemp & "PCT_Codigo.jpg")
                Catch
                End Try
                'Fin Codigo de Barras
            End If

            'Traer la o las Imagenes
            Dim Adjunto As String = ""
            Call RedurcirImagen(Adjunto)

            'Enviar la Alerta 
            Dim Detalles As String = "         Sucursal:" & SucursalN & Chr(13) _
                                    & "          Nombre:" & Clave & " - " & tbx_NombreCompleto.Text & Chr(13) _
                                    & "    Departamento:" & cmb_Departamento_DG.Text & Chr(13) _
                                    & "          Puesto:" & cmb_Puesto.Text & Chr(13) _
                                    & "   Fecha Ingreso:" & dtp_FechaIngreso.Value.Date.ToShortDateString & Chr(13) _
                                    & "Fecha Validación:" & Now.Date.ToShortDateString & Chr(13) _
                                    & "            Hora:" & Now.ToShortTimeString & Chr(13) & Chr(13) _
                                    & "Pendiente que el Jefe de Área valide el Nuevo Ingreso(Intranet) para que el departamento de Nóminas de seguimiento al trámite correspondiente."

            Dim DetallesHTML As String = "<html><body><table style='border: solid 1px'><tr><td colspan='3' align='center'><b>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='3' align='center'>Encabezado</td></tr> " _
                                    & "<tr><td colspan='3'><br><hr /></td></tr> " _
                                    & "<tr><td rowspan='9'><img src='cid:1' style='width:170px; height:150px; border:solid 1px'/> </tr>" _
                                    & "<tr><td align='right'><label><b>Sucursal:</b></label></td><td>" & SucursalN & "</td></tr>" _
                                    & "<tr><td align='right'><label><b>Nombre:</b></label></td><td>" & Clave & " - " & tbx_NombreCompleto.Text & "</td></tr> " _
                                    & "<tr><td align='right'><label><b>Departamento:</b></label></td><td>" & cmb_Departamento_DG.Text & "</td></tr>" _
                                    & "<tr><td align='right'><label><b>Puesto:</b></label></td><td>" & cmb_Puesto.Text & "</td></tr>" _
                                    & "<tr><td align='right'><label><b>Fecha Ingreso:</b></label></td><td>" & dtp_FechaIngreso.Value.Date.ToShortDateString & "</td></tr>" _
                                    & "<tr><td align='right'><label><b>Fecha Validación:</b></label></td><td>" & Now.Date.ToShortDateString & " - " & Now.ToShortTimeString & "<br></td></tr>" _
                                    & "<tr><td align='right'><label><b>Validado Por:</b></label></td><td>" & UsuarioN & "<br></td></tr>" _
                                    & "<tr><td align='right'><label><b>Nota:</b></label></td><td>Pendiente que el Jefe de Área valide el Nuevo Ingreso(Intranet) para que el departamento" _
                                    & "de Nóminas de seguimiento al trámite correspondiente.<br></td></tr>" _
                                    & "<tr><td colspan='3'><hr /></td></tr><tr><td colspan='3' align='center'>Pie</td></tr></table></body></html>"

            fn_AlertasGeneradas_Guardar("12", Detalles, Nothing, True, "REGISTRO DE NUEVO INGRESO", Adjunto, DetallesHTML)
            Try
                If File.Exists(RutaTemp & "Adjunto.jpg") Then Kill(RutaTemp & "Adjunto.jpg")
                If File.Exists(RutaTemp & "Frente.jpg") Then Kill(RutaTemp & "Frente.jpg")
                If File.Exists(RutaTemp & "FrenteFormal.jpg") Then Kill(RutaTemp & "FrenteFormal.jpg")
            Catch
            End Try
        End If

        'Aqui se Actualiza el listview
        Tab_Catalogo.SelectedTab = tab_Listado
        Call LlenarListaProspectos()
        Call BotonesCatalogo()
    End Sub

    Function ValidarRasgos() As Boolean
        If Id_EmpleadoRasgos = 0 Then Return False
        For Each Control As Control In gbx_Principales.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            ElseIf Control.Name = "tbx_PesoR" AndAlso Val(Control.Text) = 0 Then
                Return False
            ElseIf Control.Name = "tbx_EstaturaR" AndAlso Val(Control.Text) = 0 Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Frente.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Cejas.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Ojos.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Nariz.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Boca.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Labios.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next


        For Each Control As Control In gbx_Menton.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next


        For Each Control As Control In gbx_Oreja.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Helix.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        For Each Control As Control In gbx_Lobulo.Controls
            If Control.Text = "Seleccione..." Then
                Return False
            End If
        Next

        Return True
    End Function

    Function ValidarDatosEscolares() As Boolean
        If Id_EmpleadoEscolar = 0 Then Return False
        Return True
    End Function

    Function ValidarDatosFamiliares() As Boolean
        If (lsv_Familiares.Items.Count = 0) OrElse (lsv_Familiares.Items.Count > 0 And lsv_Familiares.Items(0).Tag = 0) Then Return False
        Return True
    End Function

    Function ValidarDatosLaborales() As Boolean
        If (lsv_Empleos.Items.Count = 0) OrElse (lsv_Empleos.Items.Count > 0 And lsv_Empleos.Items(0).Tag = 0) Then Return False
        Return True
    End Function

    Function ValidarDatosReferencias() As Boolean
        If (lsv_Referencias.Items.Count = 0) OrElse (lsv_Referencias.Items.Count > 0 And lsv_Referencias.Items(0).Tag = 0) Then Return False
        Return True
    End Function

    Function ValidarDatosVarios() As Boolean
        If Id_EmpleadoIngresos = 0 Then Return False
        Return True
    End Function

    Function ValidarPapeleriaRecibida() As Boolean
        If PapeleriaRecibida < 6 Then Return False
        Return True
    End Function

#End Region

    Private Sub frm_Empleados_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Arreglo_Archivo = Nothing
    End Sub

    Private Sub btn_LimpiarLaborales_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_LimpiarLaborales.Click
        Call LimpiarDatosPredictivo()
    End Sub

    Private Sub cmb_Departamento_DG_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Departamento_DG.SelectedValueChanged
        'Llenar los Puestos
        If cmb_Departamento_DG.Items.Count > 0 Then
            If cmb_Departamento_DG.SelectedValue = 0 Then
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_Puesto.ActualizaValorParametro("@Id_Departamento", cmb_Departamento_DG.SelectedValue)
            End If
            cmb_Puesto.Actualizar()
        End If
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedValueChanged
        'Llenar los Puestos
        If cmb_DepartamentoFiltro.Items.Count > 0 Then
            If cmb_DepartamentoFiltro.SelectedValue = 0 Then
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", -1)
            Else
                cmb_PuestoFiltro.ActualizaValorParametro("@Id_Departamento", cmb_DepartamentoFiltro.SelectedValue)
            End If
            cmb_PuestoFiltro.Actualizar()
        End If
    End Sub

    Private Sub cmb_DepartamentoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_DepartamentoFiltro.SelectedIndexChanged
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_PuestoFiltro_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_PuestoFiltro.SelectedIndexChanged
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub cmb_Status_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Status.SelectedIndexChanged
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Catalogo.Items.Count)
    End Sub

    Private Sub btn_AgregarContactos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_AgregarContactos.Click
        If cmb_Localizacion.SelectedIndex = 0 Then
            MsgBox("Seleccione un modo de contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Localizacion.Focus()
            Exit Sub
        End If

        If tbx_Descripcion.Text = "" Then
            MsgBox("Agrege la descripción del modo de contacto", MsgBoxStyle.Critical, frm_MENU.Text)
            tbx_Descripcion.Focus()
            Exit Sub
        End If

        Dim Contacto As ListViewItem
        Contacto = lsv_Contacto.Items.Add(cmb_Localizacion.Text)
        Contacto.SubItems.Add(tbx_Descripcion.Text)
        Contacto.Tag = cmb_Localizacion.SelectedValue

        If Not fn_ContactoP_Nuevo(Id, Contacto.Tag, Contacto.SubItems(1).Text) Then
            MsgBox("Ocurrio un error al guardar los contactos.", MsgBoxStyle.Critical, frm_MENU.Text)
            btn_AgregarContactos.Focus()
            Exit Sub
        End If
        cmb_Localizacion.SelectedIndex = 0
        tbx_Descripcion.Text = ""
        Datoscontacto = True
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_borrarP.Click

        If lsv_Contacto.SelectedItems.Count = 0 Then
            MsgBox("Seleccione el contacto a borrar de la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        If Not fn_ContactoP_Borrar(lsv_Contacto.SelectedItems(0).Tag) Then
            MsgBox("Ocurrio un error al intentar borrar el contacto.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Call fn_ContactoP_CargarLista(lsv_Contacto, Id)

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancelarP.Click
        SegundosDesconexion = 0

        If Datoscontacto Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                Tab_Catalogo.SelectedTab = tab_Listado
            End If
        Else
            Tab_Catalogo.SelectedTab = tab_Listado
        End If
    End Sub

    Private Sub lsv_Contacto_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Contacto.SelectedIndexChanged
        If lsv_Contacto.SelectedItems.Count > 0 Then
            btn_borrarP.Enabled = True
        Else
            btn_borrarP.Enabled = False
        End If
    End Sub

    Private Sub chk_Aptos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Aptos.CheckedChanged
        SegundosDesconexion = 0

        lsv_Catalogo.Items.Clear()
        Call BotonesCatalogo()
        cmb_aptos.SelectedValue = 0
        cmb_aptos.Enabled = Not chk_Aptos.Checked
        Lbl_Numero.Text = "Empleados: 0"
    End Sub

    Private Sub lsv_PapeleriaRecibida_ItemCheck(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckEventArgs) Handles lsv_PapeleriaRecibida.ItemCheck
        If e.CurrentValue = CheckState.Checked Then
            If lsv_PapeleriaRecibida.Items(e.Index).SubItems(1).Text = "SI" Then
                MsgBox("No puede desmarcar este documento porque tiene imagenes registradas." & vbNewLine & _
                "Elimine primero las imagenes.", MsgBoxStyle.Critical, Me.Text)
                e.NewValue = CheckState.Checked
            End If
        End If
    End Sub

    Private Sub btn_DoctosCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_DoctosCancelar.Click
        SegundosDesconexion = 0

        Tab_Catalogo.SelectedTab = tab_Listado

    End Sub

    Private Sub btn_EntrevistasCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_EntrevistasCancelar.Click
        SegundosDesconexion = 0

        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Sub btn_FotografiaCancelar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_FotografiaCancelar.Click
        SegundosDesconexion = 0

        Tab_Catalogo.SelectedTab = tab_Listado
    End Sub

    Private Sub cmb_CreditoInfonavit_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_CreditoInfonavit.SelectedIndexChanged
        If cmb_CreditoInfonavit.SelectedValue = "S" Then
            lbl_TipoDescuento.Enabled = True
            lbl_MontoDescuento.Enabled = True
            lbl_NumeroCredito.Enabled = True
            cmb_TipoDescuento.Enabled = True
            tbx_MontoDescuento.Enabled = True
            tbx_NumeroCredito.Enabled = True
        Else
            lbl_TipoDescuento.Enabled = False
            lbl_MontoDescuento.Enabled = False
            lbl_NumeroCredito.Enabled = False
            cmb_TipoDescuento.Enabled = False
            tbx_MontoDescuento.Enabled = False
            tbx_NumeroCredito.Enabled = False
            cmb_TipoDescuento.SelectedValue = "0"
            tbx_MontoDescuento.Clear()
            tbx_NumeroCredito.Clear()
        End If
    End Sub

    Private Sub cmb_Paises_Empleos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Paises_Empleos.SelectedIndexChanged
        cmb_Ciudades_Empleos.ActualizaValorParametro("@Id_Pais", cmb_Paises_Empleos.SelectedValue)
        cmb_Ciudades_Empleos.Actualizar()
    End Sub

    Private Sub cmb_Paises_Referencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Paises_Referencias.SelectedIndexChanged
        cmb_Ciudades_Referencias.ActualizaValorParametro("@Id_Pais", cmb_Paises_Referencias.SelectedValue)
        cmb_Ciudades_Referencias.Actualizar()
    End Sub

    Private Sub dtp_FechaExpiraFed_KeyPress(sender As Object, e As KeyPressEventArgs) Handles dtp_FechaExpiraFed.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then cmb_CreditoInfonavit.Focus()
    End Sub

    Private Sub dtp_FechaExpiraFed_Enter(sender As Object, e As EventArgs) Handles dtp_FechaExpiraFed.Enter
        If dtp_FechaExpiraFed.Value = #1/1/1900# Then
            dtp_FechaExpiraFed.Value = Today
        End If
    End Sub


    ''' <summary>
    ''' Este metodo nos ayuda a buscar el pais, el estado y el muncipio en base al codigo postal
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub buscarLugar(sender As Object, e As KeyPressEventArgs) Handles tbx_CodigoPostal.KeyPress

        If tbx_CodigoPostal.TextLength > 0 AndAlso Asc(e.KeyChar) = Keys.Enter Then

            Dim Dr_Lugar As DataTable = fn_BuscarLugar(tbx_CodigoPostal.Text)

            If Dr_Lugar IsNot Nothing Then

                cmb_Ciudades_DG.SelectedValue = Dr_Lugar.Rows(0)("Id_ciudad").ToString()

                cmb_Colonias.DataSource = Dr_Lugar
                cmb_Colonias.DisplayMember = "nombre"
                cmb_Colonias.ValueMember = "id_Colonia"
            Else
                MsgBox("El Codigo Postal es erroneo.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        End If
    End Sub


    ''' <summary>
    ''' Este metodo nos sirve para asegurar que que no se guarden los datos del cliente si el CP no es valido
    ''' </summary>
    ''' <returns></returns>
    Private Function ValidarCodigoPostalGuardar() As Boolean
        Dim validarCodigoPostal As DataTable = fn_BuscarLugar(tbx_CodigoPostal.Text)
        If validarCodigoPostal Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function


    Private Function ValidarCodigoPostalEmpleos() As Boolean
        Dim validarCodigoPostal As DataTable = fn_BuscarLugar(tbx_CodigoPostal_Empleos.Text)

        If validarCodigoPostal Is Nothing Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Sub cmb_Colonias_SelectionChangeCommitted(sender As Object, e As EventArgs) Handles cmb_Colonias.SelectionChangeCommitted
        Dim colonias As DataTable
        colonias = cmb_Colonias.DataSource

        Try
            If colonias IsNot Nothing Then
                For i As Integer = 0 To colonias.Rows.Count - 1
                    If cmb_Colonias.Text = colonias.Rows(i)("nombre") Then
                        tbx_CodigoPostal.Text = colonias.Rows(i)("c_CodigoPostal").ToString()
                        tbx_CodigoPostal.Enabled = False
                    End If
                Next
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub cmb_Ciudades_DG_Click(sender As Object, e As EventArgs) Handles cmb_Ciudades_DG.Click
        tbx_CodigoPostal.Enabled = True
        tbx_CodigoPostal.Text = ""
    End Sub

    Private Sub Btn_AgregarColonia_Click(sender As Object, e As EventArgs) Handles Btn_AgregarColonia.Click
        If tbx_CodigoPostal.Text.Trim() <> "" Then
            frm_AgregarColonia.tbx_CodigoPostal.Text = tbx_CodigoPostal.Text
            frm_AgregarColonia.ShowDialog()
        Else
            MsgBox("Favor de introducir el codigo postal", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        MessageBox.Show(lsv_Referencias.SelectedItems(0).SubItems(16).Text)
    End Sub

    Private Sub btn_refionesSSP_Click(sender As Object, e As EventArgs) Handles btn_refionesSSP.Click
        Dim frm As New frm_RegionesSSP
        frm.ShowDialog()
    End Sub

    Private Sub btn_CapturarHuellas_Click(sender As Object, e As EventArgs) Handles btn_CapturarHuellas.Click
        Dim frm As New Frm_Huellas_Prospectos
        frm.Clave_EmpleadoP = Id
        frm.ShowDialog()
        If frm.DialogResult = DialogResult.OK Then
            LlenarHuellasProspecto(Id)
        End If
    End Sub

#Region "HuellasProspecto"
    Sub LlenarHuellasProspecto(ByVal Id As Integer)
        Dim huellas As cls_Huellas = fn_Get_HuellasProspecto(Id, 1)
        If huellas IsNot Nothing Then
            If huellas.HuellaD IsNot Nothing Then
                pbx_HuellaDer.Image = Base64ToImage(huellas.HuellaD)
            End If
            If huellas.HuellaI IsNot Nothing Then
                pbx_HuellaIzq.Image = Base64ToImage(huellas.HuellaI)
            End If
        Else
            pbx_HuellaDer.Image = Nothing
            pbx_HuellaIzq.Image = Nothing
        End If
    End Sub

    Private Sub btn_EliminarHuellasIzq_Click(sender As Object, e As EventArgs) Handles btn_EliminarHuellasIzq.Click
        If Cn_Reclutamiento.fn_Del_HuellasProspecto(tbx_Clave.Text, 2) Then
            MsgBox("huella Eliminada")
            pbx_HuellaIzq.Image.Dispose()
            pbx_HuellaIzq.Image = Nothing
        Else
            MsgBox("Error al Eliminadar Huella")
        End If
    End Sub

    Private Sub btn_EliminarHuellaD_Click(sender As Object, e As EventArgs) Handles btn_EliminarHuellaD.Click
        If Cn_Reclutamiento.fn_Del_HuellasProspecto(tbx_Clave.Text, 1) Then
            MsgBox("huella Eliminada")
            pbx_HuellaDer.Image.Dispose()
            pbx_HuellaDer.Image = Nothing
        Else
            MsgBox("Error al Eliminadar Huella")
        End If
    End Sub

    Private Sub btn_Investigacion_Click(sender As Object, e As EventArgs) Handles btn_Investigacion.Click

        If lsv_Empleos.SelectedItems.Count > 0 Then
            Dim frm As New frm_Investigacion_Laboral
            frm.EmpOrPros = "P"
            frm.Id = IdReferencia
            frm.IdEmp = Id
            frm.Candidato = CandidatoReferencia
            frm.Referencia = Referencia
            frm.Telefono = TelefonoReferencia
            frm.ShowDialog()
        End If


    End Sub

    Private Sub btn_InvestigacionPersonal_Click(sender As Object, e As EventArgs) Handles btn_InvestigacionPersonal.Click
        If lsv_Referencias.SelectedItems.Count > 0 Then
            Dim frm As New frm_Investigacion_Personal
            frm.EmpOrPros = "P"
            frm.Id = IdReferencia
            frm.IdEmp = Id
            frm.Candidato = CandidatoReferencia
            frm.Referencia = Referencia
            frm.Telefono = TelefonoReferencia
            frm.ShowDialog()
        End If


    End Sub


#End Region

End Class
