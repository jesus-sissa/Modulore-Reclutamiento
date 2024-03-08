Public Class cls_Documentos
    Private _firma As String
    Private _nombre As String
    Private _fotoEncabezado As String
    Private _fotoPiePagina As String
    Private _fotoLogo As String
    Private _fecha As String
    Private _persona As cls_Persona
    Private _beneficiario As String
    Private _firmasRepTes As List(Of cls_FirmasRepTes)
    Private _Huellas As cls_Huellas
    Private _RespuestasExamen As List(Of RespuestasExamen)
    Private _cuestionarioMedico As CuestionarioMedico
    Public Property Firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property FotoEncabezado As String
        Get
            Return _fotoEncabezado
        End Get
        Set(value As String)
            _fotoEncabezado = value
        End Set
    End Property

    Public Property FotoPiePagina As String
        Get
            Return _fotoPiePagina
        End Get
        Set(value As String)
            _fotoPiePagina = value
        End Set
    End Property

    Public Property Persona As cls_Persona
        Get
            Return _persona
        End Get
        Set(value As cls_Persona)
            _persona = value
        End Set
    End Property



    Public Property Fecha As String
        Get
            Return _fecha
        End Get
        Set(value As String)
            _fecha = value
        End Set
    End Property

    Public Property FotoLogo As String
        Get
            Return _fotoLogo
        End Get
        Set(value As String)
            _fotoLogo = value
        End Set
    End Property

    Public Property Beneficiario As String
        Get
            Return _beneficiario
        End Get
        Set(value As String)
            _beneficiario = value
        End Set
    End Property

    Public Property FirmasRepTes As List(Of cls_FirmasRepTes)
        Get
            Return _firmasRepTes
        End Get
        Set(value As List(Of cls_FirmasRepTes))
            _firmasRepTes = value
        End Set
    End Property

    Public Property Huellas As cls_Huellas
        Get
            Return _Huellas
        End Get
        Set(value As cls_Huellas)
            _Huellas = value
        End Set
    End Property

    Public Property RespuestasExamen As List(Of RespuestasExamen)
        Get
            Return _RespuestasExamen
        End Get
        Set(value As List(Of RespuestasExamen))
            _RespuestasExamen = value
        End Set
    End Property

    Public Property CuestionarioMedico As CuestionarioMedico
        Get
            Return _cuestionarioMedico
        End Get
        Set(value As CuestionarioMedico)
            _cuestionarioMedico = value
        End Set
    End Property
End Class

Public Class cls_Persona
    Private _nombre As String
    Private _sexo As String
    Private _edad As String
    Private _estadoCivil As String
    Private _curp As String
    Private _rfc As String
    Private _domicilio As String
    Private _puesto As String
    Private _sueldo As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Sexo As String
        Get
            Return _sexo
        End Get
        Set(value As String)
            _sexo = value
        End Set
    End Property

    Public Property Edad As String
        Get
            Return _edad
        End Get
        Set(value As String)
            _edad = value
        End Set
    End Property

    Public Property EstadoCivil As String
        Get
            Return _estadoCivil
        End Get
        Set(value As String)
            _estadoCivil = value
        End Set
    End Property

    Public Property Curp As String
        Get
            Return _curp
        End Get
        Set(value As String)
            _curp = value
        End Set
    End Property

    Public Property Rfc As String
        Get
            Return _rfc
        End Get
        Set(value As String)
            _rfc = value
        End Set
    End Property

    Public Property Domicilio As String
        Get
            Return _domicilio
        End Get
        Set(value As String)
            _domicilio = value
        End Set
    End Property

    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property

    Public Property Sueldo As String
        Get
            Return _sueldo
        End Get
        Set(value As String)
            _sueldo = value
        End Set
    End Property
End Class
Public Class cls_beneficiario
    Private _nombre As String
    Private _parentesco As String
    Private _porcentaje As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Parentesco As String
        Get
            Return _parentesco
        End Get
        Set(value As String)
            _parentesco = value
        End Set
    End Property

    Public Property Porcentaje As String
        Get
            Return _porcentaje
        End Get
        Set(value As String)
            _porcentaje = value
        End Set
    End Property
End Class

Public Class cls_FirmasRepTes
    Private _nombre As String
    Private _firma As String
    Private _posicion As String

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property Posicion As String
        Get
            Return _posicion
        End Get
        Set(value As String)
            _posicion = value
        End Set
    End Property
End Class

Public Class cls_Huellas
    Private _huellaD As String
    Private _huellaI As String

    Public Property HuellaD As String
        Get
            Return _huellaD
        End Get
        Set(value As String)
            _huellaD = value
        End Set
    End Property

    Public Property HuellaI As String
        Get
            Return _huellaI
        End Get
        Set(value As String)
            _huellaI = value
        End Set
    End Property
End Class

Public Class RespuestasExamen
    Private _IdPregunta As Integer
    Private _Pregunta As String
    Private _Respuesta As String
    Private _EsCorrecta As String
    Private _RespuestaCorrecta As String

    Public Property IdPregunta As Integer
        Get
            Return _IdPregunta
        End Get
        Set(value As Integer)
            _IdPregunta = value
        End Set
    End Property

    Public Property Pregunta As String
        Get
            Return _Pregunta
        End Get
        Set(value As String)
            _Pregunta = value
        End Set
    End Property

    Public Property Respuesta As String
        Get
            Return _Respuesta
        End Get
        Set(value As String)
            _Respuesta = value
        End Set
    End Property

    Public Property EsCorrecta As String
        Get
            Return _EsCorrecta
        End Get
        Set(value As String)
            _EsCorrecta = value
        End Set
    End Property

    Public Property RespuestaCorrecta As String
        Get
            Return _RespuestaCorrecta
        End Get
        Set(value As String)
            _RespuestaCorrecta = value
        End Set
    End Property
End Class

Public Class CuestionarioMedico
    Private _inforpersonal As InformPersonal
    Private _AntecedentesMedicos As AntecedentesMedicos
    Private _AntecedentesGinecologicos As AntecedentesGinecologicos
    Private _IdAntecedemteMedico As Integer
    Private _IdAntecedemteGinecologico As Integer
    Private _antidoping As String
    Private _isSigned As String
    Private _firma As String
    Private _servicioMedico As String
    Private _servicioMedicoAprobacion As String
    Private _observaciones As String
    Private _fechaRegistro As String


    Public Property Inforpersonal As InformPersonal
        Get
            Return _inforpersonal
        End Get
        Set(value As InformPersonal)
            _inforpersonal = value
        End Set
    End Property

    Public Property AntecedentesMedicos As AntecedentesMedicos
        Get
            Return _AntecedentesMedicos
        End Get
        Set(value As AntecedentesMedicos)
            _AntecedentesMedicos = value
        End Set
    End Property

    Public Property Antidoping As String
        Get
            Return _antidoping
        End Get
        Set(value As String)
            _antidoping = value
        End Set
    End Property

    Public Property IsSigned As String
        Get
            Return _isSigned
        End Get
        Set(value As String)
            _isSigned = value
        End Set
    End Property

    Public Property Firma As String
        Get
            Return _firma
        End Get
        Set(value As String)
            _firma = value
        End Set
    End Property

    Public Property ServicioMedicoAprobacion As String
        Get
            Return _servicioMedicoAprobacion
        End Get
        Set(value As String)
            _servicioMedicoAprobacion = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _observaciones
        End Get
        Set(value As String)
            _observaciones = value
        End Set
    End Property

    Public Property FechaRegistro As String
        Get
            Return _fechaRegistro
        End Get
        Set(value As String)
            _fechaRegistro = value
        End Set
    End Property

    Public Property ServicioMedico As String
        Get
            Return _servicioMedico
        End Get
        Set(value As String)
            _servicioMedico = value
        End Set
    End Property

    Public Property IdAntecedemteMedico As Integer
        Get
            Return _IdAntecedemteMedico
        End Get
        Set(value As Integer)
            _IdAntecedemteMedico = value
        End Set
    End Property

    Public Property IdAntecedemteGinecologico As Integer
        Get
            Return _IdAntecedemteGinecologico
        End Get
        Set(value As Integer)
            _IdAntecedemteGinecologico = value
        End Set
    End Property

    Public Property AntecedentesGinecologicos As AntecedentesGinecologicos
        Get
            Return _AntecedentesGinecologicos
        End Get
        Set(value As AntecedentesGinecologicos)
            _AntecedentesGinecologicos = value
        End Set
    End Property
End Class

Public Class InformPersonal
    Private _id As Integer
    Private _puesto As String
    Private _nombre As String
    Private _edad As Integer
    Private _ultimoGradoEstudio As Integer
    Private _fechaNacimiento As String
    Private _genero As String
    Private _estadoCivil As String
    Private _lugarNacimiento As String
    Private _estadoNacimiento As String
    Private _calle As String
    Private _numero As String
    Private _colonia As String
    Private _ciudad As String
    Private _cp As String
    Private _estado As String
    Private _telefono As String
    Private _celular As String
    Private _noHijos As String
    Private _edadHijos As String
    Private _estanSanos As String
    Private _complexion As String
    Private _peso As String
    Private _altura As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Puesto As String
        Get
            Return _puesto
        End Get
        Set(value As String)
            _puesto = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Edad As Integer
        Get
            Return _edad
        End Get
        Set(value As Integer)
            _edad = value
        End Set
    End Property

    Public Property UltimoGradoEstudio As Integer
        Get
            Return _ultimoGradoEstudio
        End Get
        Set(value As Integer)
            _ultimoGradoEstudio = value
        End Set
    End Property

    Public Property FechaNacimiento As String
        Get
            Return _fechaNacimiento
        End Get
        Set(value As String)
            _fechaNacimiento = value
        End Set
    End Property

    Public Property Genero As String
        Get
            Return _genero
        End Get
        Set(value As String)
            _genero = value
        End Set
    End Property

    Public Property EstadoCivil As String
        Get
            Return _estadoCivil
        End Get
        Set(value As String)
            _estadoCivil = value
        End Set
    End Property

    Public Property LugarNacimiento As String
        Get
            Return _lugarNacimiento
        End Get
        Set(value As String)
            _lugarNacimiento = value
        End Set
    End Property

    Public Property EstadoNacimiento As String
        Get
            Return _estadoNacimiento
        End Get
        Set(value As String)
            _estadoNacimiento = value
        End Set
    End Property

    Public Property Calle As String
        Get
            Return _calle
        End Get
        Set(value As String)
            _calle = value
        End Set
    End Property

    Public Property Numero As String
        Get
            Return _numero
        End Get
        Set(value As String)
            _numero = value
        End Set
    End Property

    Public Property Colonia As String
        Get
            Return _colonia
        End Get
        Set(value As String)
            _colonia = value
        End Set
    End Property

    Public Property Ciudad As String
        Get
            Return _ciudad
        End Get
        Set(value As String)
            _ciudad = value
        End Set
    End Property

    Public Property Cp As String
        Get
            Return _cp
        End Get
        Set(value As String)
            _cp = value
        End Set
    End Property

    Public Property Estado As String
        Get
            Return _estado
        End Get
        Set(value As String)
            _estado = value
        End Set
    End Property

    Public Property Telefono As String
        Get
            Return _telefono
        End Get
        Set(value As String)
            _telefono = value
        End Set
    End Property

    Public Property Celular As String
        Get
            Return _celular
        End Get
        Set(value As String)
            _celular = value
        End Set
    End Property

    Public Property NoHijos As String
        Get
            Return _noHijos
        End Get
        Set(value As String)
            _noHijos = value
        End Set
    End Property

    Public Property EdadHijos As String
        Get
            Return _edadHijos
        End Get
        Set(value As String)
            _edadHijos = value
        End Set
    End Property

    Public Property EstanSanos As String
        Get
            Return _estanSanos
        End Get
        Set(value As String)
            _estanSanos = value
        End Set
    End Property

    Public Property Complexion As String
        Get
            Return _complexion
        End Get
        Set(value As String)
            _complexion = value
        End Set
    End Property

    Public Property Peso As String
        Get
            Return _peso
        End Get
        Set(value As String)
            _peso = value
        End Set
    End Property

    Public Property Altura As String
        Get
            Return _altura
        End Get
        Set(value As String)
            _altura = value
        End Set
    End Property

End Class
Public Class AntecedentesMedicos
    Private _Id As Integer
    Private _presionArterial As String
    Private _glucosa As String
    Private _IMC As String
    Private _respuestasIMC As List(Of ListaItems)
    Private _observaciones As String
    '--------------------------------------------------------------------
    Private _usaLentesoPupilentes As String
    Private _desdecuando As String
    Private _respuestaLentesPupilentes As String
    Private _opcionesAntecedentesFamiliares As List(Of ListaItems)
    '----------------------------------------------------------------------------
    Private _enfermedadCongenita As String
    Private _opcionesEnfermedadesCongenitas As List(Of ListaItems)
    Private _deformidadCongenita As String
    Private _enfermedadesInfantiles As String
    Private _opcionesEnfermedadesInfantiles As List(Of ListaItems)
    Private _otraEnfermedadInfantil As String
    Private _alergias As String
    Private _opcionesAlergias As List(Of ListaItems)
    '--------------------------------------------------------------------------------------
    Private _veUstedBien As String
    Private _ojoDerecho As String
    Private _ojoIzquierdo As String
    Private _cirugiaOcular As String
    Private _porqueRealizoCirugiaOcular As String
    Private _fechaCirugia As String
    Private _usaLentesContacto As String
    Private _opcionesUsaLentesContacto As List(Of ListaItems)

    '------------------------------------------------------------------------------------
    Private _enfermedadOidos As String
    Private _cualEnfermedadOidos As String
    Private _escuchaUstedBien As String
    Private _usaAparatoAuditivo As String
    Private _desdeCuandoUsaAparatoAuditivo As String
    Private _enfermedadesDentales As String
    Private _opcionesEnfermedadesDentales As List(Of ListaItems)
    Private _enfermedadesHormonales As String
    Private _opcionesEnfermedadesHormonales As List(Of ListaItems)
    Private _otrasEnfermedadesHormonales As String
    Private _enfermedadesPulmonares As String
    Private _opcionesEnfermedadesPulmonares As List(Of ListaItems)
    Private _otrasEnfermedadesPulmonares As String
    Private _enfermadesCorazon As String
    Private _opcionesEnfermedadesCorazon As List(Of ListaItems)
    Private _alteracionPresionArterial As String
    Private _opcionesAlteracionPresionArterial As List(Of ListaItems)
    Private _medicamentosAlteracionPresionArterial As String
    Private _controlMedicoAlteracionPresionArterial As String
    Private _opcionescontrolMedicoAlteracionPresionArterial As List(Of ListaItems)
    Private _enfermedadDigestiva As String
    Private _opcionEnfermedadesDigestivas As List(Of ListaItems)
    Private _enfermedadHigado
    Private _opcionesEnfermedadesHigado As List(Of ListaItems)
    Private _diabetesMellitus As String
    Private _opcionesDiabetesMelitus As List(Of ListaItems)
    Private _FechaUltimoExamenSangre As String

    Private _controlMedicoDiabetesMelitus As String
    Private _opcionesControlMedicoDiabetes As List(Of ListaItems)
    Private _enfermedadColesterol As String
    Private _medicamentosColesterol As String
    Private _enfermedadAcidoUrico As String
    Private _medicamentosAcidoUrico As String
    Private _enfermedadRinon As String
    Private _opcionesRinones As List(Of ListaItems)
    Private _enfermedadNeurologica As String
    Private _opcionesEnfermedadNuerologicas As List(Of ListaItems)
    Private _enfermedadesPsiquiatricas As String
    Private _opcionesEnfermedadesPsiquiatricas As List(Of ListaItems)
    Private _enfermedadOsteoMuscular As String
    Private _opcionesEnfermedadesOsteoMuscular As List(Of ListaItems)
    Private _enfermedadPiel As String
    Private _enfermedadUñas As String
    Private _enfermedadCabello
    Private _enfermedadesInfecciosas As String
    Private _opcionesEnfermedadesInfecciosas As List(Of ListaItems)
    Private _accidentesdeImportancia As String
    Private _tranfusionDeSangre As String
    Private _ingresoHospital As String
    Private _opcionesIngresoHospital As List(Of ListaItems)
    Private _cirugiasRealizadas As String
    Private _tieneSecuela As String
    Private _impedimentoFisicoPsicologico As String
    Private _enfermedadCronica As String
    Private _opcionesEnfermedadCronica As List(Of ListaItems)
    Private _otraEnfermedadCronica As String
    Private _padecidoCancerTumorMaligno As String
    Private _tieneVarices
    Private _tabaco As String
    Private _diariamenteFumo As String
    Private _semanalmenteFumo As String
    Private _fechaDejeFumar As String
    Private _alcohol As String
    Private _tipoBebida As String
    Private _drogas As String
    Private _fechaDejeDrogas As String
    Private _tipoDrogras As String
    Private _deportesActividadFisica As String
    Private _tipoEjercicio As String
    Private _tiempoDedicado As String
    Private _usoMedicamentos As String
    Private _opcionesUsoMedicamentos As List(Of ListaItems)
    Private _nombreMedicamento As String
    Private _medicamentoUsadoPara As String
    Private _horasSuenoDia As String
    Private _otrosTrabajos As String
    Private _dondeRealizaOtrosTrabajos As String
    Private _queHaceEnOtrosTrabajos As String
    Private _fechaDesdeQueRealizaOtrosTrabajos
    Private _realizaTareasDomesticas As String

    Public Property Id As Integer
        Get
            Return _Id
        End Get
        Set(value As Integer)
            _Id = value
        End Set
    End Property

    Public Property PresionArterial As String
        Get
            Return _presionArterial
        End Get
        Set(value As String)
            _presionArterial = value
        End Set
    End Property

    Public Property Glucosa As String
        Get
            Return _glucosa
        End Get
        Set(value As String)
            _glucosa = value
        End Set
    End Property

    Public Property IMC As String
        Get
            Return _IMC
        End Get
        Set(value As String)
            _IMC = value
        End Set
    End Property

    Public Property RespuestasIMC As List(Of ListaItems)
        Get
            Return _respuestasIMC
        End Get
        Set(value As List(Of ListaItems))
            _respuestasIMC = value
        End Set
    End Property

    Public Property Observaciones As String
        Get
            Return _observaciones
        End Get
        Set(value As String)
            _observaciones = value
        End Set
    End Property

    Public Property UsaLentesoPupilentes As String
        Get
            Return _usaLentesoPupilentes
        End Get
        Set(value As String)
            _usaLentesoPupilentes = value
        End Set
    End Property

    Public Property Desdecuando As String
        Get
            Return _desdecuando
        End Get
        Set(value As String)
            _desdecuando = value
        End Set
    End Property

    Public Property RespuestaLentesPupilentes As String
        Get
            Return _respuestaLentesPupilentes
        End Get
        Set(value As String)
            _respuestaLentesPupilentes = value
        End Set
    End Property


    Public Property OpcionesAntecedentesFamiliares As List(Of ListaItems)
        Get
            Return _opcionesAntecedentesFamiliares
        End Get
        Set(value As List(Of ListaItems))
            _opcionesAntecedentesFamiliares = value
        End Set
    End Property

    Public Property EnfermedadCongenita As String
        Get
            Return _enfermedadCongenita
        End Get
        Set(value As String)
            _enfermedadCongenita = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesCongenitas As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesCongenitas
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesCongenitas = value
        End Set
    End Property

    Public Property DeformidadCongenita As String
        Get
            Return _deformidadCongenita
        End Get
        Set(value As String)
            _deformidadCongenita = value
        End Set
    End Property

    Public Property EnfermedadesInfantiles As String
        Get
            Return _enfermedadesInfantiles
        End Get
        Set(value As String)
            _enfermedadesInfantiles = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesInfantiles As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesInfantiles
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesInfantiles = value
        End Set
    End Property

    Public Property OtraEnfermedadInfantil As String
        Get
            Return _otraEnfermedadInfantil
        End Get
        Set(value As String)
            _otraEnfermedadInfantil = value
        End Set
    End Property

    Public Property Alergias As String
        Get
            Return _alergias
        End Get
        Set(value As String)
            _alergias = value
        End Set
    End Property

    Public Property OpcionesAlergias As List(Of ListaItems)
        Get
            Return _opcionesAlergias
        End Get
        Set(value As List(Of ListaItems))
            _opcionesAlergias = value
        End Set
    End Property

    Public Property VeUstedBien As String
        Get
            Return _veUstedBien
        End Get
        Set(value As String)
            _veUstedBien = value
        End Set
    End Property

    Public Property OjoDerecho As String
        Get
            Return _ojoDerecho
        End Get
        Set(value As String)
            _ojoDerecho = value
        End Set
    End Property

    Public Property OjoIzquierdo As String
        Get
            Return _ojoIzquierdo
        End Get
        Set(value As String)
            _ojoIzquierdo = value
        End Set
    End Property

    Public Property CirugiaOcular As String
        Get
            Return _cirugiaOcular
        End Get
        Set(value As String)
            _cirugiaOcular = value
        End Set
    End Property

    Public Property PorqueRealizoCirugiaOcular As String
        Get
            Return _porqueRealizoCirugiaOcular
        End Get
        Set(value As String)
            _porqueRealizoCirugiaOcular = value
        End Set
    End Property

    Public Property FechaCirugia As String
        Get
            Return _fechaCirugia
        End Get
        Set(value As String)
            _fechaCirugia = value
        End Set
    End Property

    Public Property UsaLentesContacto As String
        Get
            Return _usaLentesContacto
        End Get
        Set(value As String)
            _usaLentesContacto = value
        End Set
    End Property

    Public Property OpcionesUsaLentesContacto As List(Of ListaItems)
        Get
            Return _opcionesUsaLentesContacto
        End Get
        Set(value As List(Of ListaItems))
            _opcionesUsaLentesContacto = value
        End Set
    End Property

    Public Property EnfermedadOidos As String
        Get
            Return _enfermedadOidos
        End Get
        Set(value As String)
            _enfermedadOidos = value
        End Set
    End Property

    Public Property CualEnfermedadOidos As String
        Get
            Return _cualEnfermedadOidos
        End Get
        Set(value As String)
            _cualEnfermedadOidos = value
        End Set
    End Property

    Public Property EscuchaUstedBien As String
        Get
            Return _escuchaUstedBien
        End Get
        Set(value As String)
            _escuchaUstedBien = value
        End Set
    End Property

    Public Property UsaAparatoAuditivo As String
        Get
            Return _usaAparatoAuditivo
        End Get
        Set(value As String)
            _usaAparatoAuditivo = value
        End Set
    End Property

    Public Property DesdeCuandoUsaAparatoAuditivo As String
        Get
            Return _desdeCuandoUsaAparatoAuditivo
        End Get
        Set(value As String)
            _desdeCuandoUsaAparatoAuditivo = value
        End Set
    End Property

    Public Property EnfermedadesDentales As String
        Get
            Return _enfermedadesDentales
        End Get
        Set(value As String)
            _enfermedadesDentales = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesDentales As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesDentales
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesDentales = value
        End Set
    End Property

    Public Property EnfermedadesHormonales As String
        Get
            Return _enfermedadesHormonales
        End Get
        Set(value As String)
            _enfermedadesHormonales = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesHormonales As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesHormonales
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesHormonales = value
        End Set
    End Property

    Public Property OtrasEnfermedadesHormonales As String
        Get
            Return _otrasEnfermedadesHormonales
        End Get
        Set(value As String)
            _otrasEnfermedadesHormonales = value
        End Set
    End Property

    Public Property EnfermedadesPulmonares As String
        Get
            Return _enfermedadesPulmonares
        End Get
        Set(value As String)
            _enfermedadesPulmonares = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesPulmonares As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesPulmonares
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesPulmonares = value
        End Set
    End Property

    Public Property OtrasEnfermedadesPulmonares As String
        Get
            Return _otrasEnfermedadesPulmonares
        End Get
        Set(value As String)
            _otrasEnfermedadesPulmonares = value
        End Set
    End Property

    Public Property EnfermadesCorazon As String
        Get
            Return _enfermadesCorazon
        End Get
        Set(value As String)
            _enfermadesCorazon = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesCorazon As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesCorazon
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesCorazon = value
        End Set
    End Property

    Public Property AlteracionPresionArterial As String
        Get
            Return _alteracionPresionArterial
        End Get
        Set(value As String)
            _alteracionPresionArterial = value
        End Set
    End Property

    Public Property OpcionesAlteracionPresionArterial As List(Of ListaItems)
        Get
            Return _opcionesAlteracionPresionArterial
        End Get
        Set(value As List(Of ListaItems))
            _opcionesAlteracionPresionArterial = value
        End Set
    End Property

    Public Property MedicamentosAlteracionPresionArterial As String
        Get
            Return _medicamentosAlteracionPresionArterial
        End Get
        Set(value As String)
            _medicamentosAlteracionPresionArterial = value
        End Set
    End Property



    Public Property EnfermedadDigestiva As String
        Get
            Return _enfermedadDigestiva
        End Get
        Set(value As String)
            _enfermedadDigestiva = value
        End Set
    End Property

    Public Property OpcionEnfermedadesDigestivas As List(Of ListaItems)
        Get
            Return _opcionEnfermedadesDigestivas
        End Get
        Set(value As List(Of ListaItems))
            _opcionEnfermedadesDigestivas = value
        End Set
    End Property

    Public Property EnfermedadHigado As Object
        Get
            Return _enfermedadHigado
        End Get
        Set(value As Object)
            _enfermedadHigado = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesHigado As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesHigado
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesHigado = value
        End Set
    End Property

    Public Property DiabetesMellitus As String
        Get
            Return _diabetesMellitus
        End Get
        Set(value As String)
            _diabetesMellitus = value
        End Set
    End Property

    Public Property OpcionesDiabetesMelitus As List(Of ListaItems)
        Get
            Return _opcionesDiabetesMelitus
        End Get
        Set(value As List(Of ListaItems))
            _opcionesDiabetesMelitus = value
        End Set
    End Property

    Public Property FechaUltimoExamenSangre As String
        Get
            Return _FechaUltimoExamenSangre
        End Get
        Set(value As String)
            _FechaUltimoExamenSangre = value
        End Set
    End Property

    Public Property ControlMedicoDiabetesMelitus As String
        Get
            Return _controlMedicoDiabetesMelitus
        End Get
        Set(value As String)
            _controlMedicoDiabetesMelitus = value
        End Set
    End Property

    Public Property OpcionesControlMedicoDiabetes As List(Of ListaItems)
        Get
            Return _opcionesControlMedicoDiabetes
        End Get
        Set(value As List(Of ListaItems))
            _opcionesControlMedicoDiabetes = value
        End Set
    End Property

    Public Property EnfermedadColesterol As String
        Get
            Return _enfermedadColesterol
        End Get
        Set(value As String)
            _enfermedadColesterol = value
        End Set
    End Property

    Public Property MedicamentosColesterol As String
        Get
            Return _medicamentosColesterol
        End Get
        Set(value As String)
            _medicamentosColesterol = value
        End Set
    End Property

    Public Property EnfermedadAcidoUrico As String
        Get
            Return _enfermedadAcidoUrico
        End Get
        Set(value As String)
            _enfermedadAcidoUrico = value
        End Set
    End Property

    Public Property MedicamentosAcidoUrico As String
        Get
            Return _medicamentosAcidoUrico
        End Get
        Set(value As String)
            _medicamentosAcidoUrico = value
        End Set
    End Property

    Public Property EnfermedadRinon As String
        Get
            Return _enfermedadRinon
        End Get
        Set(value As String)
            _enfermedadRinon = value
        End Set
    End Property

    Public Property OpcionesRinones As List(Of ListaItems)
        Get
            Return _opcionesRinones
        End Get
        Set(value As List(Of ListaItems))
            _opcionesRinones = value
        End Set
    End Property

    Public Property EnfermedadNeurologica As String
        Get
            Return _enfermedadNeurologica
        End Get
        Set(value As String)
            _enfermedadNeurologica = value
        End Set
    End Property

    Public Property OpcionesEnfermedadNuerologicas As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadNuerologicas
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadNuerologicas = value
        End Set
    End Property

    Public Property EnfermedadesPsiquiatricas As String
        Get
            Return _enfermedadesPsiquiatricas
        End Get
        Set(value As String)
            _enfermedadesPsiquiatricas = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesPsiquiatricas As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesPsiquiatricas
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesPsiquiatricas = value
        End Set
    End Property

    Public Property EnfermedadOsteoMuscular As String
        Get
            Return _enfermedadOsteoMuscular
        End Get
        Set(value As String)
            _enfermedadOsteoMuscular = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesOsteoMuscular As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesOsteoMuscular
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesOsteoMuscular = value
        End Set
    End Property

    Public Property EnfermedadPiel As String
        Get
            Return _enfermedadPiel
        End Get
        Set(value As String)
            _enfermedadPiel = value
        End Set
    End Property

    Public Property EnfermedadUñas As String
        Get
            Return _enfermedadUñas
        End Get
        Set(value As String)
            _enfermedadUñas = value
        End Set
    End Property

    Public Property EnfermedadCabello As Object
        Get
            Return _enfermedadCabello
        End Get
        Set(value As Object)
            _enfermedadCabello = value
        End Set
    End Property

    Public Property EnfermedadesInfecciosas As String
        Get
            Return _enfermedadesInfecciosas
        End Get
        Set(value As String)
            _enfermedadesInfecciosas = value
        End Set
    End Property

    Public Property OpcionesEnfermedadesInfecciosas As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadesInfecciosas
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadesInfecciosas = value
        End Set
    End Property

    Public Property AccidentesdeImportancia As String
        Get
            Return _accidentesdeImportancia
        End Get
        Set(value As String)
            _accidentesdeImportancia = value
        End Set
    End Property

    Public Property TranfusionDeSangre As String
        Get
            Return _tranfusionDeSangre
        End Get
        Set(value As String)
            _tranfusionDeSangre = value
        End Set
    End Property

    Public Property IngresoHospital As String
        Get
            Return _ingresoHospital
        End Get
        Set(value As String)
            _ingresoHospital = value
        End Set
    End Property

    Public Property OpcionesIngresoHospital As List(Of ListaItems)
        Get
            Return _opcionesIngresoHospital
        End Get
        Set(value As List(Of ListaItems))
            _opcionesIngresoHospital = value
        End Set
    End Property

    Public Property CirugiasRealizadas As String
        Get
            Return _cirugiasRealizadas
        End Get
        Set(value As String)
            _cirugiasRealizadas = value
        End Set
    End Property

    Public Property TieneSecuela As String
        Get
            Return _tieneSecuela
        End Get
        Set(value As String)
            _tieneSecuela = value
        End Set
    End Property

    Public Property ImpedimentoFisicoPsicologico As String
        Get
            Return _impedimentoFisicoPsicologico
        End Get
        Set(value As String)
            _impedimentoFisicoPsicologico = value
        End Set
    End Property

    Public Property EnfermedadCronica As String
        Get
            Return _enfermedadCronica
        End Get
        Set(value As String)
            _enfermedadCronica = value
        End Set
    End Property

    Public Property OpcionesEnfermedadCronica As List(Of ListaItems)
        Get
            Return _opcionesEnfermedadCronica
        End Get
        Set(value As List(Of ListaItems))
            _opcionesEnfermedadCronica = value
        End Set
    End Property

    Public Property OtraEnfermedadCronica As String
        Get
            Return _otraEnfermedadCronica
        End Get
        Set(value As String)
            _otraEnfermedadCronica = value
        End Set
    End Property

    Public Property PadecidoCancerTumorMaligno As String
        Get
            Return _padecidoCancerTumorMaligno
        End Get
        Set(value As String)
            _padecidoCancerTumorMaligno = value
        End Set
    End Property

    Public Property TieneVarices As Object
        Get
            Return _tieneVarices
        End Get
        Set(value As Object)
            _tieneVarices = value
        End Set
    End Property

    Public Property Tabaco As String
        Get
            Return _tabaco
        End Get
        Set(value As String)
            _tabaco = value
        End Set
    End Property

    Public Property FechaDejeFumar As String
        Get
            Return _fechaDejeFumar
        End Get
        Set(value As String)
            _fechaDejeFumar = value
        End Set
    End Property

    Public Property Alcohol As String
        Get
            Return _alcohol
        End Get
        Set(value As String)
            _alcohol = value
        End Set
    End Property

    Public Property TipoBebida As String
        Get
            Return _tipoBebida
        End Get
        Set(value As String)
            _tipoBebida = value
        End Set
    End Property

    Public Property Drogas As String
        Get
            Return _drogas
        End Get
        Set(value As String)
            _drogas = value
        End Set
    End Property

    Public Property FechaDejeDrogas As String
        Get
            Return _fechaDejeDrogas
        End Get
        Set(value As String)
            _fechaDejeDrogas = value
        End Set
    End Property

    Public Property TipoDrogras As String
        Get
            Return _tipoDrogras
        End Get
        Set(value As String)
            _tipoDrogras = value
        End Set
    End Property

    Public Property DeportesActividadFisica As String
        Get
            Return _deportesActividadFisica
        End Get
        Set(value As String)
            _deportesActividadFisica = value
        End Set
    End Property

    Public Property TipoEjercicio As String
        Get
            Return _tipoEjercicio
        End Get
        Set(value As String)
            _tipoEjercicio = value
        End Set
    End Property

    Public Property TiempoDedicado As String
        Get
            Return _tiempoDedicado
        End Get
        Set(value As String)
            _tiempoDedicado = value
        End Set
    End Property

    Public Property UsoMedicamentos As String
        Get
            Return _usoMedicamentos
        End Get
        Set(value As String)
            _usoMedicamentos = value
        End Set
    End Property

    Public Property OpcionesUsoMedicamentos As List(Of ListaItems)
        Get
            Return _opcionesUsoMedicamentos
        End Get
        Set(value As List(Of ListaItems))
            _opcionesUsoMedicamentos = value
        End Set
    End Property

    Public Property NombreMedicamento As String
        Get
            Return _nombreMedicamento
        End Get
        Set(value As String)
            _nombreMedicamento = value
        End Set
    End Property

    Public Property MedicamentoUsadoPara As String
        Get
            Return _medicamentoUsadoPara
        End Get
        Set(value As String)
            _medicamentoUsadoPara = value
        End Set
    End Property

    Public Property HorasSuenoDia As String
        Get
            Return _horasSuenoDia
        End Get
        Set(value As String)
            _horasSuenoDia = value
        End Set
    End Property

    Public Property OtrosTrabajos As String
        Get
            Return _otrosTrabajos
        End Get
        Set(value As String)
            _otrosTrabajos = value
        End Set
    End Property

    Public Property DondeRealizaOtrosTrabajos As String
        Get
            Return _dondeRealizaOtrosTrabajos
        End Get
        Set(value As String)
            _dondeRealizaOtrosTrabajos = value
        End Set
    End Property

    Public Property QueHaceEnOtrosTrabajos As String
        Get
            Return _queHaceEnOtrosTrabajos
        End Get
        Set(value As String)
            _queHaceEnOtrosTrabajos = value
        End Set
    End Property

    Public Property FechaDesdeQueRealizaOtrosTrabajos As Object
        Get
            Return _fechaDesdeQueRealizaOtrosTrabajos
        End Get
        Set(value As Object)
            _fechaDesdeQueRealizaOtrosTrabajos = value
        End Set
    End Property

    Public Property RealizaTareasDomesticas As String
        Get
            Return _realizaTareasDomesticas
        End Get
        Set(value As String)
            _realizaTareasDomesticas = value
        End Set
    End Property

    Public Property ControlMedicoAlteracionPresionArterial As String
        Get
            Return _controlMedicoAlteracionPresionArterial
        End Get
        Set(value As String)
            _controlMedicoAlteracionPresionArterial = value
        End Set
    End Property

    Public Property OpcionescontrolMedicoAlteracionPresionArterial As List(Of ListaItems)
        Get
            Return _opcionescontrolMedicoAlteracionPresionArterial
        End Get
        Set(value As List(Of ListaItems))
            _opcionescontrolMedicoAlteracionPresionArterial = value
        End Set
    End Property

    Public Property DiariamenteFumo As String
        Get
            Return _diariamenteFumo
        End Get
        Set(value As String)
            _diariamenteFumo = value
        End Set
    End Property

    Public Property SemanalmenteFumo As String
        Get
            Return _semanalmenteFumo
        End Get
        Set(value As String)
            _semanalmenteFumo = value
        End Set
    End Property
End Class
Public Class AntecedentesGinecologicos
    Private _id As Integer
    Private _embarazos As Integer
    Private _nacimientos As Integer
    Private _cesarias As Integer
    Private _abortos As Integer
    Private _fechasNacimientoHijos As String
    Private _irregularidaddesMenstruales
    Private _infecciones As String
    Private _quistes As String
    Private _quisteslist As List(Of ListaItems)
    Private _esterilidad As String
    Private _otrosproblemas As String
    Private _cualesproblemas As String
    Private _bolitaSeno As String
    Private _quistesSenos As String
    Private _secrecion As String
    Private _otrosproblemaspecho As String
    Private _cualesproblemaspecho As String
    Private _revisionGinecologica As String
    Private _ultimaFechaRevisionmedica As String
    Private _lugares As List(Of ListaItems)
    Private _ultimaFechaExamenDetecCancer As String
    Private _respuestaUltimaFechaExamenCancer As List(Of ListaItems)
    Private _metodoAnticonceptivo As String
    Private _cualMetodoAnticonceptivo As String
    Private _ultimaFechaMenstruacion As String
    Private _respuestaUltimaFechaMenstruacion As List(Of ListaItems)
    Private _estaEmbarazada As String
    Private _fechaParto As String
    Private _sospechaEmbarazo As String

    Public Property Id As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Embarazos As Integer
        Get
            Return _embarazos
        End Get
        Set(value As Integer)
            _embarazos = value
        End Set
    End Property

    Public Property Nacimientos As Integer
        Get
            Return _nacimientos
        End Get
        Set(value As Integer)
            _nacimientos = value
        End Set
    End Property

    Public Property Cesarias As Integer
        Get
            Return _cesarias
        End Get
        Set(value As Integer)
            _cesarias = value
        End Set
    End Property

    Public Property Abortos As Integer
        Get
            Return _abortos
        End Get
        Set(value As Integer)
            _abortos = value
        End Set
    End Property

    Public Property FechasNacimientoHijos As String
        Get
            Return _fechasNacimientoHijos
        End Get
        Set(value As String)
            _fechasNacimientoHijos = value
        End Set
    End Property

    Public Property IrregularidaddesMenstruales As Object
        Get
            Return _irregularidaddesMenstruales
        End Get
        Set(value As Object)
            _irregularidaddesMenstruales = value
        End Set
    End Property

    Public Property Infecciones As String
        Get
            Return _infecciones
        End Get
        Set(value As String)
            _infecciones = value
        End Set
    End Property

    Public Property Quistes As String
        Get
            Return _quistes
        End Get
        Set(value As String)
            _quistes = value
        End Set
    End Property

    Public Property Quisteslist As List(Of ListaItems)
        Get
            Return _quisteslist
        End Get
        Set(value As List(Of ListaItems))
            _quisteslist = value
        End Set
    End Property

    Public Property Esterilidad As String
        Get
            Return _esterilidad
        End Get
        Set(value As String)
            _esterilidad = value
        End Set
    End Property

    Public Property Otrosproblemas As String
        Get
            Return _otrosproblemas
        End Get
        Set(value As String)
            _otrosproblemas = value
        End Set
    End Property

    Public Property Cualesproblemas As String
        Get
            Return _cualesproblemas
        End Get
        Set(value As String)
            _cualesproblemas = value
        End Set
    End Property

    Public Property BolitaSeno As String
        Get
            Return _bolitaSeno
        End Get
        Set(value As String)
            _bolitaSeno = value
        End Set
    End Property

    Public Property QuistesSenos As String
        Get
            Return _quistesSenos
        End Get
        Set(value As String)
            _quistesSenos = value
        End Set
    End Property

    Public Property Secrecion As String
        Get
            Return _secrecion
        End Get
        Set(value As String)
            _secrecion = value
        End Set
    End Property

    Public Property Otrosproblemaspecho As String
        Get
            Return _otrosproblemaspecho
        End Get
        Set(value As String)
            _otrosproblemaspecho = value
        End Set
    End Property

    Public Property Cualesproblemaspecho As String
        Get
            Return _cualesproblemaspecho
        End Get
        Set(value As String)
            _cualesproblemaspecho = value
        End Set
    End Property

    Public Property RevisionGinecologica As String
        Get
            Return _revisionGinecologica
        End Get
        Set(value As String)
            _revisionGinecologica = value
        End Set
    End Property

    Public Property UltimaFechaRevisionmedica As String
        Get
            Return _ultimaFechaRevisionmedica
        End Get
        Set(value As String)
            _ultimaFechaRevisionmedica = value
        End Set
    End Property

    Public Property Lugares As List(Of ListaItems)
        Get
            Return _lugares
        End Get
        Set(value As List(Of ListaItems))
            _lugares = value
        End Set
    End Property

    Public Property UltimaFechaExamenDetecCancer As String
        Get
            Return _ultimaFechaExamenDetecCancer
        End Get
        Set(value As String)
            _ultimaFechaExamenDetecCancer = value
        End Set
    End Property

    Public Property RespuestaUltimaFechaExamenCancer As List(Of ListaItems)
        Get
            Return _respuestaUltimaFechaExamenCancer
        End Get
        Set(value As List(Of ListaItems))
            _respuestaUltimaFechaExamenCancer = value
        End Set
    End Property

    Public Property MetodoAnticonceptivo As String
        Get
            Return _metodoAnticonceptivo
        End Get
        Set(value As String)
            _metodoAnticonceptivo = value
        End Set
    End Property

    Public Property CualMetodoAnticonceptivo As String
        Get
            Return _cualMetodoAnticonceptivo
        End Get
        Set(value As String)
            _cualMetodoAnticonceptivo = value
        End Set
    End Property

    Public Property UltimaFechaMenstruacion As String
        Get
            Return _ultimaFechaMenstruacion
        End Get
        Set(value As String)
            _ultimaFechaMenstruacion = value
        End Set
    End Property

    Public Property RespuestaUltimaFechaMenstruacion As List(Of ListaItems)
        Get
            Return _respuestaUltimaFechaMenstruacion
        End Get
        Set(value As List(Of ListaItems))
            _respuestaUltimaFechaMenstruacion = value
        End Set
    End Property

    Public Property EstaEmbarazada As String
        Get
            Return _estaEmbarazada
        End Get
        Set(value As String)
            _estaEmbarazada = value
        End Set
    End Property

    Public Property FechaParto As String
        Get
            Return _fechaParto
        End Get
        Set(value As String)
            _fechaParto = value
        End Set
    End Property

    Public Property SospechaEmbarazo As String
        Get
            Return _sospechaEmbarazo
        End Get
        Set(value As String)
            _sospechaEmbarazo = value
        End Set
    End Property
End Class
Public Class ListaItems
    Private _value As String
    Private _text As String
    Private _disabled As Boolean
    Private _group As String
    Private _selected As Boolean

    Public Property Value As String
        Get
            Return _value
        End Get
        Set(value As String)
            _value = value
        End Set
    End Property

    Public Property Text As String
        Get
            Return _text
        End Get
        Set(value As String)
            _text = value
        End Set
    End Property

    Public Property Disabled As Boolean
        Get
            Return _disabled
        End Get
        Set(value As Boolean)
            _disabled = value
        End Set
    End Property

    Public Property Group As String
        Get
            Return _group
        End Get
        Set(value As String)
            _group = value
        End Set
    End Property

    Public Property Selected As Boolean
        Get
            Return _selected
        End Get
        Set(value As Boolean)
            _selected = value
        End Set
    End Property
End Class
