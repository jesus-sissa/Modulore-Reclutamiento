Imports System.Deployment.Application
Imports System.IO
Imports System.Threading

Public Class frm_MENU

    Private Segundos As Integer = 0
    Dim Fecha As Date = Today.Date

    Private Sub frm_MENU_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If LoginId > 0 Then
            Cn_Login.Login_CerrarSesion()
            'Insertar en Usr_Log
            If TipoBloqueo <> 0 Then
                Cn_Login.fn_Log_Create("CIERRE DE SESION (DESPUES DE BLOQUEO)")
            Else
                Cn_Login.fn_Log_Create("CIERRE DE SESION")
            End If
        End If
    End Sub

    Private Sub frm_MENU_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString
        tmr_Inicio.Enabled = False
        tmr_Hora.Enabled = False
        Call Deshabilitar_Todo()
        'Cambiar la configuración regional
        'Thread.CurrentThread.CurrentCulture = New CultureInfo("es-ES", False)

        ' Obtengo la informacion de formato numerico
        Dim nfi As Globalization.NumberFormatInfo = Thread.CurrentThread.CurrentCulture.NumberFormat
        ' Obtengo la informacion de formato fecha
        Dim Dfi As Globalization.DateTimeFormatInfo = Thread.CurrentThread.CurrentCulture.DateTimeFormat

        If nfi.NumberDecimalSeparator <> "." Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.NumberGroupSeparator <> "," Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If nfi.CurrencySymbol <> "$" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada.", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortDatePattern <> "dd/MM/yyyy" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada(" & Dfi.ShortDatePattern & ").", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        If Dfi.ShortTimePattern <> "HH:mm:ss" And Dfi.ShortTimePattern <> "hh:mm tt" Then
            MsgBox("La configuración Regional de Windows parece no ser la apropiada(" & Dfi.ShortTimePattern & ").", MsgBoxStyle.Critical, Me.Text)
            End
        End If
        tmr_Inicio.Enabled = True
    End Sub

    Private Sub tmr_Inicio_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Inicio.Tick
        TipoBloqueo = 0
        SegundosDesconexion = 0
        tmr_Inicio.Enabled = False

        Dim frmSet As New frm_Settings
        'verificar Si hay tipoesquema y DAtos de conexion
        If My.Settings.TipoEsquema = "0" Then
            frmSet.ShowDialog()
            If My.Settings.TipoEsquema = "0" Then
                MsgBox("No se ha especifica el tipo de esquema a utiliar.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If

        If Cn_Reclutamiento.fn_CuentaSettings() = 10 Then
            frmSet.ShowDialog()
            If Cn_Reclutamiento.fn_CuentaSettings() = 10 Then
                MsgBox("No se han capturado el nombre del servidor y la base de datos.", MsgBoxStyle.Critical, Me.Text)
                Me.Close() : Exit Sub
            End If
        End If
        '---------------

        frm_Login.ShowDialog()
        If SucursalId = 0 Then
            Me.Close()
            Exit Sub
        End If

        Me.Text = "SIAC. Módulo Reclutamiento v" & ModuloVersion & "  ** Conectado A: " & SucursalDatos

        Me.Cursor = Cursors.WaitCursor
        cn_Mensajes.ActualizarMensajes()


        'Se está generando un archivo de excel pero este se queda en la maquina local
        'y Se genera una Alerta
        'Call NotificarEmpleadosSinInformacion()


        Call NotificarCredencialesPorExpirar()
        Call VerificarEmpleadosBaja()
        Call NotificarEmpleadosSinCredencial()
        Call NotificarCredencialesExpiradas()

        Me.Cursor = Cursors.Default
        Segundos = 270
        tmr_Hora.Enabled = True

        Ruta_Temporal = String.Format(System.Environment.SystemDirectory.Substring(0, 3)) & "Siac\Temporales\"

        If Not Directory.Exists(Ruta_Temporal) Then
            System.IO.Directory.CreateDirectory(Ruta_Temporal)
        End If

    End Sub

    Private Sub tmr_Hora_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Hora.Tick
        lbl_Fecha.Text = Date.Today.ToShortDateString
        lbl_Hora.Text = System.DateTime.Now.ToLongTimeString

        Segundos += 1
        SegundosDesconexion += 1
        If SegundosDesconexion >= (MinutosDesconexion * 60) Then
            SegundosDesconexion = 0
            tmr_Hora.Enabled = False
            'Insertar en Usr_Log
            Cn_Login.fn_Log_Create("BLOQUEO POR INACTIVIDAD")
            TipoBloqueo = 2
            Call CerrarModales()
            Call Deshabilitar_Todo()
            Me.Hide()
            frm_Login.ShowDialog()
            tmr_Hora.Enabled = True
        End If
        If Segundos >= 300 Then
            cn_Mensajes.ActualizarMensajes()
            'Código agregado para manejar la ventana de notificación de Alertas

            'If Not Cn_Notificaciones.fn_MostrarAlertas() Then
            'End If
            Segundos = 0
        End If
    End Sub

    Sub Deshabilitar_Todo()
        Dim SubSub As Integer = 0
        For Each element As ToolStripItem In MenuStrip.Items
            If TypeOf (element) Is ToolStripMenuItem Then
                SubSub = 0
                For Each Child As ToolStripItem In CType(element, ToolStripMenuItem).DropDownItems
                    If TypeOf (Child) Is ToolStripMenuItem Then
                        For Each SubChild As ToolStripItem In CType(Child, ToolStripMenuItem).DropDownItems
                            SubSub = SubSub + 1
                            If TypeOf (SubChild) Is ToolStripMenuItem And SubChild.Tag <> "" Then
                                SubChild.Enabled = False
                            End If

                        Next
                        If SubSub = 0 And Child.Tag <> "" Then
                            Child.Enabled = False
                        End If

                    End If
                Next
            End If
        Next
        'ToolStrip
        For Each element As ToolStripItem In ToolStrip.Items
            If TypeOf (element) Is ToolStripButton Then
                If element.Tag <> "" Then
                    element.Enabled = False
                End If
            End If
        Next
    End Sub

    Sub CerrarModales()
        'Dim Contador As Integer = Application.OpenForms.Count
        'For ILocal As Integer = 0 To Contador - 1
        '    If Application.OpenForms(ILocal).Modal Then
        '        Application.OpenForms(ILocal).Dispose()
        '    End If
        'Next

        Dim forms As String = ""

        For Each frm As Form In Application.OpenForms
            If frm.Modal Then
                forms = forms & "|" & frm.Name
            End If
        Next

        For Each nombre As String In forms.Split("|")
            If nombre = "" Then Continue For
            Try
                Application.OpenForms(nombre).Dispose()
            Catch ex As Exception
            End Try
        Next

    End Sub

    Sub NotificarEmpleadosSinInformacion()
        Dim Detalles As String = ""
        If Not Cn_Reclutamiento.fn_AlertasGeneradas_Existe("04") Then
            Me.Cursor = Cursors.WaitCursor
            Dim dt_Escolares As DataTable = Cn_Reclutamiento.fn_Menu_ObtenerEmpleadosSinEscolares
            If dt_Escolares Is Nothing Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If
            If dt_Escolares.Rows.Count > 0 Then
                'FuncionesGlobales.fn_ExportarTabla_Excel(dt_Escolares, 2, Me.Text, 0, 0, Me.prg_Barra)
                For Each Elemento As DataRow In dt_Escolares.Rows
                    Detalles &= Elemento("Clave") & "-"
                    Detalles &= Elemento("Nombre") & "; "
                    If Detalles.Length > 200 Then
                        Exit For
                    End If
                Next
            End If

            If Not Cn_Reclutamiento.fn_AlertasGeneradas_Guardar("04", Detalles, dt_Escolares, False, "", "", "") Then
                'MsgBox("Ha ocurrido un error al intentar guardar la Alerta.", MsgBoxStyle.Critical, Me.Text)
            End If
            Me.Cursor = Cursors.Default
        End If

        'Dim dt_Laborales As DataTable = Cn_Reclutamiento.fn_Menu_ObtenerEmpleadosSinLaborales
        'If dt_Laborales.Rows.Count > 0 Then
        '    cn_Mensajes.fn_EnviarMensajes_Enviar(Modulo, Asunto, Mensaje)
        'End If

    End Sub

    Sub NotificarCredencialesPorExpirar()
        Dim Detalles As String = ""
        If Not Cn_Reclutamiento.fn_AlertasGeneradas_Existe("09") Then
            Me.Cursor = Cursors.WaitCursor
            Dim dt_Credenciales As DataTable = Cn_Reclutamiento.fn_Menu_ObtenerCredencialesPorExpirar
            If dt_Credenciales Is Nothing Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If dt_Credenciales.Rows.Count > 0 Then
                If dt_Credenciales.Rows.Count < 6 Then
                    For Each Elemento As DataRow In dt_Credenciales.Rows
                        Detalles &= Elemento("Clave") & "-"
                        Detalles &= Elemento("Nombre") & "; "
                        If Detalles.Length > 200 Then
                            Exit For
                        End If
                    Next
                Else
                    Detalles = "EMPLEADOS VARIOS (VER DETALLES)"
                End If

                If Not Cn_Reclutamiento.fn_AlertasGeneradas_Guardar("09", Detalles, dt_Credenciales, False, "", "", "") Then
                    'MsgBox("Ha ocurrido un error al intentar guardar la Alerta.", MsgBoxStyle.Critical, Me.Text)
                End If
            End If
            dt_Credenciales.Dispose()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Sub VerificarEmpleadosBaja()
        Cn_Reclutamiento.fn_EmpleadosBaja_ActualizarAuto()
    End Sub

    Sub NotificarEmpleadosSinCredencial()
        Dim Detalles As String = ""
        If Not Cn_Reclutamiento.fn_AlertasGeneradas_Existe("23") Then
            Me.Cursor = Cursors.WaitCursor
            Dim dt_Credenciales As DataTable = Cn_Reclutamiento.fn_Menu_ObtenerEmpleadosSinCredencial

            If dt_Credenciales Is Nothing Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If dt_Credenciales.Rows.Count > 0 Then
                If dt_Credenciales.Rows.Count < 6 Then
                    For Each Elemento As DataRow In dt_Credenciales.Rows
                        Detalles &= Elemento("Clave") & "-"
                        Detalles &= Elemento("Nombre") & "; "
                        If Detalles.Length > 200 Then
                            Exit For
                        End If
                    Next
                Else
                    Detalles = "EMPLEADOS VARIOS (VER DETALLES)"
                End If
                Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'>NOTIFICACION DE EMPLEADOS SIN CREDENCIAL</td></tr>" _
                                     & "<tr><td colspan='4' align='center'><label>Sucursal:</label> " & SucursalN & " </td></tr>" _
                                    & "<tr><td colspan='4'><br><hr/></td></tr></table>" _
                                    & FuncionesGlobales.fn_DatatableToHTML(dt_Credenciales, "DETALLE", 1, 2, 10) _
                                    & "<table style='border: solid 1px' width='100%'><tr><td align='right'><label><b>Fecha de Notificación:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>" _
                                    & "<tr><td colspan='2'><hr/></td></tr><tr><td colspan='2' align='center'>Pie</td></tr></table><br/></body></html>"


                Dim Pie As String = "Agente de Servicios SIAC " & Today.Year.ToString
                DetalleHTML = Replace(DetalleHTML, "Pie", Pie)

                If Not Cn_Reclutamiento.fn_AlertasGeneradas_Guardar("23", Detalles, dt_Credenciales, True, "NOTIFICACION DE EMPLEADOS SIN CREDENCIAL", "", DetalleHTML) Then

                End If
            End If
            dt_Credenciales.Dispose()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Sub NotificarCredencialesExpiradas()
        Dim Detalles As String = ""
        If Not Cn_Reclutamiento.fn_AlertasGeneradas_Existe("24") Then
            Me.Cursor = Cursors.WaitCursor
            Dim dt_Credenciales As DataTable = Cn_Reclutamiento.fn_Menu_ObtenerCredencialesExpiradas
            If dt_Credenciales Is Nothing Then
                Me.Cursor = Cursors.Default
                Exit Sub
            End If

            If dt_Credenciales.Rows.Count > 0 Then
                If dt_Credenciales.Rows.Count < 6 Then
                    For Each Elemento As DataRow In dt_Credenciales.Rows
                        Detalles &= Elemento("Clave") & "-"
                        Detalles &= Elemento("Nombre") & "; "
                        If Detalles.Length > 200 Then
                            Exit For
                        End If
                    Next
                Else
                    Detalles = "EMPLEADOS VARIOS (VER DETALLES)"
                End If
                Dim DetalleHTML As String = "<html><body><table style='border: solid 1px' width='100%'><tr><td colspan='4' align='center'><b>Boletín Informativo</b></td></tr>" _
                                    & "<tr><td colspan='4' align='center'>NOTIFICACION DE EMPLEADOS CON CREDENCIAL EXPIRADA</td></tr>" _
                                    & "<tr><td colspan='4' align='center'><label>Sucursal:</label> " & SucursalN & " </td></tr>" _
                                    & "<tr><td colspan='4'><br><hr/></td></tr></table>" _
                                    & FuncionesGlobales.fn_DatatableToHTML(dt_Credenciales, "DETALLE", 1, 2, 10) _
                                    & "<table style='border: solid 1px' width='100%'><tr><td align='right'><label><b>Fecha de Notificación:</b></label></td><td>" & Now.ToShortDateString & " - " & Now.ToShortTimeString & "</td></tr>" _
                                    & "<tr><td colspan='2'><hr/></td></tr><tr><td colspan='2' align='center'>Pie</td></tr></table><br/></body></html>"


                Dim Pie As String = "Agente de Servicios SIAC " & Today.Year.ToString
                DetalleHTML = Replace(DetalleHTML, "Pie", Pie)

                If Not Cn_Reclutamiento.fn_AlertasGeneradas_Guardar("24", Detalles, dt_Credenciales, True, "NOTIFICACION DE EMPLEADOS CON CREDENCIAL EXPIRADA", "", DetalleHTML) Then
                    'MsgBox("Ha ocurrido un error al intentar guardar la Alerta.", MsgBoxStyle.Critical, Me.Text)
                End If
            End If
            dt_Credenciales.Dispose()

            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub tsb_Bloquear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Bloquear.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BLOQUEAR SISTEMA")
        TipoBloqueo = 1

        tmr_Hora.Enabled = False
        'Call Deshabilitar_Todo() 'asi staba 31/12/2012
        Me.Hide()
        frm_Login.ShowDialog()
        tmr_Hora.Enabled = True

    End Sub

    Private Sub tsb_LeerMensajes_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_LeerMensajes.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub tsb_NuevoMensaje_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_NuevoMensaje.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")
        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub tsb_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Salir.Click
        Me.Close()
    End Sub

    Private Sub VerMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: LEER MENSAJES ")

        cn_Mensajes.Msg.Hide(ToolStrip)
        FuncionesGlobales.MostrarVentana(frm_VerMensajes)
    End Sub

    Private Sub EnviarMensajesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EnviarMensajesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ENVIAR MENSAJES")

        FuncionesGlobales.MostrarVentana(frm_EnviarMensajes)
    End Sub

    Private Sub CatálogoDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeEmpleadosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE EMPLEADOS")

        FuncionesGlobales.MostrarVentana(frm_Empleados, True)
    End Sub

    Private Sub tsb_Empleados_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsb_Empleados.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE EMPLEADOS")

        Dim frm As New frm_Empleados
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub GradosEscolaresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GradosEscolaresToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE GRADOS ESCOLARES")

        '    Dim Opcion As String = sender.tag
        '    'obtiene los controles a los que tiene acceso el usuario firmado, para cada pantalla a la que entra
        '    If Opcion Is Nothing OrElse Opcion.Trim = "" Then 'Si el Submenu no tiene Tag, el usuario debe tener acceso a todos los controles
        '        CadenaPermisosControles = "--"
        '    Else
        'CadenaPermisosControles = Cn_Login.Controles_ReadSQL(Opcion)
        '    End If

        FuncionesGlobales.MostrarVentana(frm_GradosEscolares, True)
    End Sub

    Private Sub ParentescosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ParentescosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE PARENTESCO")

        FuncionesGlobales.MostrarVentana(frm_TiposParentescos, True)
    End Sub

    Private Sub TiposDeLicenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeLicenciaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE LICENCIAS")

        FuncionesGlobales.MostrarVentana(frm_TipoLicencia, True)
    End Sub

    Private Sub TiposDeReferenciaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeReferenciaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE REFERENCIAS")

        FuncionesGlobales.MostrarVentana(frm_TipoReferencia, True)
    End Sub

    Private Sub TiposDeDocumentosEscolaresToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeDocumentosEscolaresToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE DOCUMENTOS ESCOLARES")

        FuncionesGlobales.MostrarVentana(frm_TipoDoctoEscolar, True)
    End Sub

    Private Sub TiposDeSeñasParticularesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeSeñasParticularesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE SEÑAS")

        FuncionesGlobales.MostrarVentana(frm_TipoSenas, True)
    End Sub

    Private Sub TiposDeViviendaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TiposDeViviendaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE VIVIENDA")

        FuncionesGlobales.MostrarVentana(frm_TipoVivienda, True)
    End Sub

    Private Sub DocumentosRequeridosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentosRequeridosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE DOCUMENTOS REQUERIDOS")

        FuncionesGlobales.MostrarVentana(frm_DoctosRequeridos, True)
    End Sub

    Private Sub BajaDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BajaDeEmpleadosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BAJA DE EMPLEADOS")

        Dim frm As New frm_EmpleadosBaja
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub AsignaciónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AsignaciónToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ASIGNAR IMPLEMENTOS")

        FuncionesGlobales.MostrarVentana(frm_ImplementosAsignar, True)
    End Sub

    Private Sub CatalogoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE IMPLEMENTOS")

        FuncionesGlobales.MostrarVentana(frm_Implementos, True)
    End Sub

    Private Sub InventariosEntradasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InventariosEntradasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: INVENTARIO DE IMPLEMENTOS")

        FuncionesGlobales.MostrarVentana(frm_ImplementosInventario, True)
    End Sub

    Private Sub DevolucionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DevolucionesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DEVOLUCIONES DE IMPLEMENTOS")

        FuncionesGlobales.MostrarVentana(frm_ImplementosDevoluciones, True)
    End Sub

    Private Sub MotivosDeBajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MotivosDeBajaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE MOTIVOS DE BAJA")

        FuncionesGlobales.MostrarVentana(frm_MotivosBaja, True)
    End Sub

    Private Sub ExpediciónDeCredencialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExpediciónDeCredencialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: EXPEDIR CREDENCIALES")

        frm_CredencialesExpedir.ShowDialog()
    End Sub

    Private Sub AutorizaciónDeCredencialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AutorizaciónDeCredencialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: IMPRIMIR O CANCELAR CREDENCIALES")

        FuncionesGlobales.MostrarVentana(frm_CredencialesAutorizacion, True)
    End Sub

    Private Sub MotivosDeExpedicionDeCredencialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MotivosDeExpedicionDeCredencialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE MOTIVOS DE EXPEDICION DE CREDENCIALES")

        FuncionesGlobales.MostrarVentana(frm_MotivosExpedicionCred, True)
    End Sub

    Private Sub ToolStripButton6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton6.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE GRADOS ESCOLARES")

        FuncionesGlobales.MostrarVentana(frm_GradosEscolares, True)
    End Sub

    Private Sub ToolStripButton7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton7.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE PARENTESCO")

        FuncionesGlobales.MostrarVentana(frm_TiposParentescos, True)
    End Sub

    Private Sub ToolStripButton8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton8.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE LICENCIAS")

        FuncionesGlobales.MostrarVentana(frm_TipoLicencia, True)
    End Sub

    Private Sub ToolStripButton9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton9.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE REFERENCIAS")

        FuncionesGlobales.MostrarVentana(frm_TipoReferencia, True)
    End Sub

    Private Sub ToolStripButton10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton10.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE DOCUMENTOS ESCOLARES")

        FuncionesGlobales.MostrarVentana(frm_TipoDoctoEscolar, True)
    End Sub

    Private Sub ToolStripButton11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton11.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE TIPOS DE VIVIENDAS")

        FuncionesGlobales.MostrarVentana(frm_TipoVivienda, True)
    End Sub

    Private Sub ToolStripButton12_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton12.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE MOTIVOS DE BAJA")

        FuncionesGlobales.MostrarVentana(frm_MotivosBaja, True)
    End Sub

    Private Sub ToolStripButton13_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton13.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE DOCUMENTOS REQUERIDOS")

        FuncionesGlobales.MostrarVentana(frm_DoctosRequeridos, True)
    End Sub

    Private Sub ToolStripButton14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton14.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: BAJA DE EMPLEADOS")
        Dim frm As New frm_EmpleadosBaja

        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ToolStripButton15_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton15.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: EXPEDIR CREDENCIALES")

        frm_CredencialesExpedir.ShowDialog()
    End Sub

    Private Sub ConsultaDeCartasDeAccesoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCartasDeAccesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE CARTAS DE ACCESO")

        FuncionesGlobales.MostrarVentana(frm_CartasAccesoConsulta, True)
    End Sub

    Private Sub CartaDeAccesoToolStripMenuItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CartaDeAccesoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GENERAR CARTA DE ACCESO")

        FuncionesGlobales.MostrarVentana(frm_CartaAcceso, True)
    End Sub

    Private Sub ReportarFallaEnEquipoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnEquipoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLA EN EQUIPO")

        Dim frm As New frm_ReporteFallas
        frm.ShowDialog()
    End Sub

    Private Sub PlantillaPorDepartamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PlantillaPorDepartamentoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PLANTILLA DE EMPLEADOS POR DEPARTAMENTO")
        Dim frm As New frm_Plantilla
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub ReportarFallaEnSistemaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaEnSistemaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLA EN SISTEMA")

        Dim frm As New frm_ReporteFallasS
        frm.ShowDialog()
    End Sub

    Private Sub ConsultaDePlantillaLaboralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDePlantillaLaboralToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE PLANTILLA LABORAL")

        FuncionesGlobales.MostrarVentana(frm_PlantillaConsulta, True)
    End Sub

    Private Sub ActualizacionesInstaladasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizacionesInstaladasToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ACTUALIZACIONES")

        FuncionesGlobales.MostrarVentana(frm_ActualizacionesConsultar, True)
    End Sub

    Private Sub ConsultaDeEmpleadosDadosDeBajaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeEmpleadosDadosDeBajaToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE BAJA DE EMPLEADOS")

        FuncionesGlobales.MostrarVentana(frm_EmpleadosBajasConsulta, True)
    End Sub

    Private Sub CatálogoDeProspectosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatálogoDeProspectosToolStripMenuItem.Click, tsb_Prospectos.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE PROSPECTOS")
        If Usar_ProspectosEmp = "S" Then
            FuncionesGlobales.MostrarVentana(frm_EmpleadosP, True)
        Else
            MsgBox("Vaya a la pantalla Empleados y seleccione en la pestaña «Nuevo» para agregar Empleados", MsgBoxStyle.Exclamation, Me.Text)
        End If

    End Sub

    Private Sub UnidadesMédicoFamiliarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UnidadesMédicoFamiliarToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE UMF's")

        FuncionesGlobales.MostrarVentana(frm_UnidadesMedicoFamiliares, True)
    End Sub

    Private Sub EmpleadosEnListaNegraToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosEnListaNegraToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: EMPLEADOS EN LISTA NEGRA")

        FuncionesGlobales.MostrarVentana(frm_EmpleadosListaNegra, True)
    End Sub

    Private Sub AcercaDeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AcercaDeToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: ACERCA DE")

        Dim frm As New frm_About
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub GráficaDeAltasYBajasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GráficaDeAltasYBajasToolStripMenuItem.Click, tsb_Graficas.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: GRAFICAS")

        Dim frm As New frm_Graficos
        FuncionesGlobales.MostrarVentana(frm, True)

        'Dim frm As New frm_IndicadorAltaBajaEmpleados
        'FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultaDeVisitasDomiciliariasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeVisitasDomiciliariasToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE VISITAS DOMICILIARIAS")

        Dim frm As New frm_VisitaDomiciliariaConsulta
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub SeguimientoAFallasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SeguimientoAFallasToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SEGUIMIENTO A FALLAS")

        Dim frm As New frm_ReporteFallasConsultar
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ModoDeContactoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModoDeContactoToolStripMenuItem.Click
        'Inicializar la variable de desconexión
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO MODO DE CONTACTO")

        Dim frm As New frm_ModoContacto
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ReportarFallaDeUnidadToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReportarFallaDeUnidadToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTAR FALLA DE UNIDAD")
        Dim frm As New frm_UnidadesReporteFallas
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub SolicitudDeEquipoServicioYOtrosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SolicitudDeEquipoServicioYOtrosToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: SOLICITUD DE EQUIPO, SERVICIO Y OTROS")
        Dim frm As New frm_ReporteFallasI
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub ConsultaDeAlertasRecibidasToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeAlertasRecibidasToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE ALERTAS RECIBIDAS")
        Dim frm As New frm_AlertasConsultas
        FuncionesGlobales.MostrarVentana(frm)
    End Sub

    Private Sub BuscarActualizacionesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BuscarActualizacionesToolStripMenuItem.Click
        Call InstallUpdateSyncWithInfo()
    End Sub

    Private Sub InstallUpdateSyncWithInfo()
        Dim info As UpdateCheckInfo = Nothing
        Me.Cursor = Cursors.WaitCursor
        If (ApplicationDeployment.IsNetworkDeployed) Then
            Dim AD As ApplicationDeployment = ApplicationDeployment.CurrentDeployment

            Try
                info = AD.CheckForDetailedUpdate()
            Catch dde As DeploymentDownloadException
                Me.Cursor = Cursors.Default
                MsgBox("La actualización no se puede descargar en este momento. " + Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            Catch ioe As InvalidOperationException
                Me.Cursor = Cursors.Default
                MsgBox("Esta no es una Aplicacion ClickOnce. No se puede actualizar. Error: " & ioe.Message, MsgBoxStyle.Critical, Me.Text)
                Return
            End Try

            If (info.UpdateAvailable) Then
                Dim doUpdate As Boolean = True

                If (Not info.IsUpdateRequired) Then
                    Me.Cursor = Cursors.Default
                    Dim dr As DialogResult = MsgBox("Está disponible la nueva versión " & info.AvailableVersion.ToString & ". Desea Instalarla Ahora?", MsgBoxStyle.OkCancel + MsgBoxStyle.Question, Me.Text)
                    If (Not System.Windows.Forms.DialogResult.OK = dr) Then
                        doUpdate = False
                    End If
                Else
                    Me.Cursor = Cursors.Default
                    ' Display a message that the app MUST reboot. Display the minimum required version.
                    MsgBox("El Sistema ha detectado una actualización marcada como obligatoria. La versión mínima requerida es " & _
                        info.MinimumRequiredVersion.ToString() & _
                        ". Se instalará la Actualización y se reiniciará el Sistema.", MsgBoxStyle.Information + MsgBoxStyle.OkOnly, Me.Text)
                End If
                Me.Cursor = Cursors.WaitCursor
                If (doUpdate) Then
                    Try
                        AD.Update()
                        Me.Cursor = Cursors.Default
                        MsgBox("La Actualización se instaló correctamente, El Sistema se reiniciará.", MsgBoxStyle.Exclamation, Me.Text)
                        Application.Restart()
                    Catch dde As DeploymentDownloadException
                        Me.Cursor = Cursors.Default
                        MsgBox("No se pudo instalar la Actualziación. " & Chr(13) & Chr(13) & "Por favor verifique su conexión a la red o intente de nuevo mas tarde. Error: " + dde.Message, MsgBoxStyle.Critical + MsgBoxStyle.OkOnly, Me.Text)
                        Return
                    End Try
                End If
            Else
                Me.Cursor = Cursors.Default
                MsgBox("No se encontraron Actualizaciones Disponibles.", MsgBoxStyle.Information, Me.Text)
            End If
        Else
            Me.Cursor = Cursors.Default
            MsgBox("Esta no es una aplicación ClickOnce Válida.", MsgBoxStyle.Critical, Me.Text)
        End If
    End Sub


    Private Sub PromociónDeEmpleadosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PromociónDeEmpleadosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PROMOCION DE DE EMPLEADOS")

        FuncionesGlobales.MostrarVentana(frm_PromocionEmpleados, True)
    End Sub

    Private Sub ConsultaBolsadeTrabajoenwebToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaBolsadeTrabajoenwebToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE BOLSA DE TRABAJO EN WEB")

        Dim frm As New frm_ConsultaWeb
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub DescargarManualDeUsuarioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DescargarManualDeUsuarioToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: DESCARGAR MANUAL DE USUARIO")

        Dim frm As New frm_DescargarArchivo
        frm.ShowDialog()
        frm.Dispose()
    End Sub

    Private Sub ActualizarCredencialesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ActualizarCredencialesToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: EXPEDICION DE TIPOS DE CARTAS")

        Dim frm As New frm_EmpleadosCartas
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub RecortarFotoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RecortarFotoToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: RECORTAR FOTO")

        FuncionesGlobales.MostrarVentana(frm_RecortarFoto, False)
    End Sub

    Private Sub ConsultaDeCredencialesToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeCredencialesToolStripMenuItem1.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE CREDENCIALES")

        FuncionesGlobales.MostrarVentana(frm_CredencialesConsulta, True)
    End Sub

    Private Sub CambiarConexiónToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0

        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CAMBIAR CONEXION")
        TipoBloqueo = 3

        Dim frm As New frm_Login
        CambiarConexion = True

        tmr_Hora.Enabled = False
        Me.Hide()
        frm.ShowDialog()
        tmr_Hora.Enabled = True
    End Sub

    Private Sub CatalogoDeEmpleadosExternosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeEmpleadosExternosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: EMPLEADOS X FUERA")

        Dim frm As New frm_EmpleadosporFuera
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultaDeReingresosToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeReingresosToolStripMenuItem.Click
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
        'Validar la Sesion
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        'Insertar en Usr_Log
        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE REINGRESOS")
        Dim frm As New frm_EmpleadosReingresosConsulta
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ReporteGeneralToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ReporteGeneralToolStripMenuItem.Click
        SegundosDesconexion = 0

        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE GENERAL")
        Dim frm As New frm_ReporteGeneral
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub CatalogoDeGafetesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CatalogoDeGafetesToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CATALOGO DE GAFETES")
        Dim frm As New frm_Gafetes
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub SorteoAntidopingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SorteoAntidopingToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: SORTEO ANTIDOPING")
        Dim frm As New frm_SorteoAntidoping
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultaDeSorteoAntidopingToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConsultaDeSorteoAntidopingToolStripMenuItem1.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DE SORTEO ANTIDOPING")
        Dim frm As New frm_SorteoAntidopingConsulta
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConfiguraciónLocalToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraciónLocalToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONFIGURACION LOCAL")
        Dim frm As New frm_ObtenerImagen_Settings
        frm.Tipo = 2
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub DocumentosPorEmpleadoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DocumentosPorEmpleadoToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: DOCUMENTOS POR EMPLEADO")
        Dim frm As New frm_DocumentosXempleado
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub BolsaDeTrabajoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BolsaDeTrabajoToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: BOLSA DE TRABAJO")
        Dim frm As New frm_BolsaDeTrabajo
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ParametrsoDeServidorCentralToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ParametrsoDeServidorCentralToolStripMenuItem.Click
        'ParametrosDeServidorCentralToolStripMenuItem1.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If
        Cn_Login.fn_Log_Create("ABRIR VENTANA: PARAMETROS SERVIDOR CENTRAL")
        Dim frm As New frm_SettingsCentral
        FuncionesGlobales.MostrarVentana(frm, False)
    End Sub

    Private Sub SSPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SSPToolStripMenuItem.Click
        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: REPORTE SSP")
        Dim frm As New frm_SSP
        FuncionesGlobales.MostrarVentana(frm, True)
    End Sub

    Private Sub ConsultaDocumentacionDeContratacionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ConsultaDocumentacionDeContratacionToolStripMenuItem.Click

        SegundosDesconexion = 0
        If Not Cn_Login.fn_ValidaSesion(LoginId) Then
            End
        End If

        Cn_Login.fn_Log_Create("ABRIR VENTANA: CONSULTA DOCUMENTACION DE CONTRATACION")
        Dim frm As New frm_Consulta_Documentacion_Contratacion
        FuncionesGlobales.MostrarVentana(frm, True)

    End Sub
End Class
