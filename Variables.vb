Module Variables
    Public Clave_AutomaticaEmp As String
    Public Usar_ProspectosEmp As String
    Public Modo_ReingresoEmp As Byte
    Public Long_ClaveEmp As Byte = 4

    Public Cnx_Datos As String = ""
    Public ServDatos As String = ""
    Public BaseDatos As String = ""
    Public UsuarioDatos As String = ""
    Public ContraDatos As String = ""
    Public SucursalDatos As String = ""
    Public CadenaPermisosControles As String = ""

    Public Cnx_Central As String = ""


    Public UsuarioId As Long
    Public UsuarioN As String
    Public EmpresaId As Long
    Public EmpresaNombre As String
    Public Cnx_Sucursal As String = "" 'para los traspasos intersucursales
    Public SucursalClave As String

    Public SucursalId As Long
    Public SucursalN As String
    Public SucursalLAT As Decimal
    Public SucursalLON As Decimal
    Public DepartamentoId As Integer
    Public CiaId As Long
    Public ProcesoD As Long
    Public EstacioN As String
    Public EstacionIp As String
    Public EstacionMac As String
    Public ModuloId As Long
    Public MonedaId As Long
    Public ModuloClave As String
    Public ModuloNombre As String
    Public ModuloVersion As String
    Public ContraHash As String
    Public UsuarioTipo As Byte
    Public CambiarConexion As Boolean
    Public cont2 As Integer = 0
    Public LoginId As Long
    Public MinutosDesconexion As Integer 'Parametro de Cat_Sucursales
    Public SegundosDesconexion As Integer 'Contador de segundos para el Bloqueo
    Public TipoBloqueo As Byte '0=No Bloqueado; 1=Bloqueado por el Usuario; 2=Bloqueado por inactividad
    Public Intentos_Login As Byte
    Public Mail_ReporteFallas As String
    Public GoogleMapsKey As String
    Public Id_EmpleadoRecienCreado As Integer

    Public I As Long
    Public J As Long
    Public ResP As Integer
    Public BanderA As Boolean
    Public DiaMes_AuditSoftware As Byte

    Public ArregloAlertas As New ArrayList
    Public Ruta_Temporal As String = ""

    Public Structure Estructura_Archivo
        Dim Id_Archivo As String
        Dim Nombre_Archivo As String
        Dim Ruta_Archivo As String
        Dim RutaAnt_Archivo As String
        Dim Extension_Archivo As String
        Dim MimeType_Archivo As String
        Dim Descripcion_Archivo As String
        Dim FileSize_Archivo As Integer
        Dim Objeto_Archivo As Byte()
        Dim Adicional_Archivo As String
    End Structure

    Public Arreglo_Archivo() As Estructura_Archivo 'Arreglo para la Estructura de Archivos

End Module
