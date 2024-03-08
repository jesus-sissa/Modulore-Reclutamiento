Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_VisitaDomiciliaria

    Public Id_Empleado As Integer = 0
    Public Id_EmpleadoP As Integer = 0
    Public Clave As String
    Public Nombre As String

    Private Id_Visita As Integer = 0
    Private Id_VisitaInmueble As Integer = 0

    Private ActualizaIngresosEgresos As Boolean = False
    Private Id_IngresosEgresos As Integer = 0

    Private Sub frm_VisitasDomiciliarias_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        'Modificar el título del formulario
        If Id_Empleado > 0 Then
            Text = "Visita Domiciliaria a Empleados"
        ElseIf Id_EmpleadoP > 0 Then
            Text = "Visita Domiciliaria a Prospectos"
        End If

        If Not fn_VisitaDomiciliaria_LlenarLista(lsv_VisitasDomiciliarias, Id_Empleado, Id_EmpleadoP) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Visitas Domiciliarias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Me.TabDescripcionCasaHabitacion.Parent = Nothing
        Me.Tab_Referencias.Parent = Nothing
        Me.TabIngresosEgresos.Parent = Nothing

        lbl_Clave.Text = Clave
        lbl_Nombre.Text = Nombre

        ' cmb_Nombre.AgregaParametro("@Id_Sucursal", 1, 1)
        cmb_Nombre.Actualizar()

        'cmb_NombreProx.AgregaParametro("@Id_Sucursal", 1, 1)
        cmb_NombreProx.Actualizar()

        'Agregar nombres de las columnas del Listado de las Referencias
        lsv_Referencias.Columns.Add("Nombre")
        lsv_Referencias.Columns.Add("TipoPersona")
        lsv_Referencias.Columns.Add("DefinicionPersona")
        lsv_Referencias.Columns.Add("DefinicionFamilia")
        lsv_Referencias.Columns.Add("TiempoDeConocer")
        lsv_Referencias.Row1 = 20
        lsv_Referencias.Row2 = 15
        lsv_Referencias.Row3 = 20
        lsv_Referencias.Row4 = 20
        lsv_Referencias.Row5 = 15

        'Agregar Valores del Combo Habitación
        cmb_Habitacion.AgregarItem(1, "CASA INDEPENDIENTE")
        cmb_Habitacion.AgregarItem(2, "CASA DUPLEX")
        cmb_Habitacion.AgregarItem(3, "DEPARTAMENTO")
        cmb_Habitacion.AgregarItem(4, "VECINDAD")
        cmb_Habitacion.AgregarItem(5, "OTRO")

        'Agregar Valores del Combo Construcción
        cmb_Construccion.AgregarItem(1, "BLOCK")
        cmb_Construccion.AgregarItem(2, "TABIQUE O LADRILLO")
        cmb_Construccion.AgregarItem(3, "CONCRETO")
        cmb_Construccion.AgregarItem(4, "LAMINA")
        cmb_Construccion.AgregarItem(5, "OTRO")

        'Agregar Valores del Combo Mobiliario
        cmb_Mobiliario.AgregarItem(1, "MUY COMPLETO")
        cmb_Mobiliario.AgregarItem(2, "COMPLETO")
        cmb_Mobiliario.AgregarItem(3, "INDISPENSABLE")
        cmb_Mobiliario.AgregarItem(4, "ESCASO")

        'Agregar Valores del Combo Calidad del Mobiliario
        cmb_MobCalidad.AgregarItem(1, "BUENA")
        cmb_MobCalidad.AgregarItem(2, "REGULAR")
        cmb_MobCalidad.AgregarItem(3, "MALA")
        cmb_MobCalidad.AgregarItem(4, "OTRO")

        'Agregar Valores del Combo Tipo de Mobiliario
        cmb_MobTipo.AgregarItem(1, "LUJO")
        cmb_MobTipo.AgregarItem(2, "MODESTO")
        cmb_MobTipo.AgregarItem(3, "MALO")
        cmb_MobTipo.AgregarItem(4, "OTRO")

        'Agregar Valores del Combo Definición de la Persona
        cmb_RefTipoPer.AgregarItem(1, "AGRESIVA")
        cmb_RefTipoPer.AgregarItem(2, "IMPULSIVA")
        cmb_RefTipoPer.AgregarItem(3, "ENOJONA")
        cmb_RefTipoPer.AgregarItem(4, "TRANQUILA")
        cmb_RefTipoPer.AgregarItem(5, "SERIO")
        cmb_RefTipoPer.AgregarItem(6, "AMIGABLE")
        cmb_RefTipoPer.AgregarItem(7, "OTRO")

        dtp_FechaVisita.Value = Today.Date
        dtp_HoraVisita.Value = Now.ToLongDateString

        IniciarDgvIngresis_Mensuales()


    End Sub

#Region "KeyPess"

    Private Sub dtp_FechaVisita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaVisita.KeyPress
        If Asc(e.KeyChar) = 13 Then dtp_HoraVisita.Focus()
    End Sub

    Private Sub dtp_HoraVisita_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraVisita.KeyPress
        If Asc(e.KeyChar) = 13 Then tbx_MotivoVisita.Focus()
    End Sub

    Private Sub dtp_FechaProx_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_FechaProx.KeyPress
        If Asc(e.KeyChar) = 13 Then dtp_HoraProx.Focus()
    End Sub

    Private Sub dtp_HoraProx_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_HoraProx.KeyPress
        If Asc(e.KeyChar) = 13 Then tbx_MotivoProx.Focus()
    End Sub

#End Region

#Region "Sub"

    Sub IniciarDgvIngresis_Mensuales()
        Dim dt As New DataTable()
        dt.Columns.Add("Id_IngresosEgresos")
        dt.Columns.Add("Ingreso")
        dt.Columns.Add("Cantidad")
        dt.Rows.Add(0, "Renta", 0)
        dt.Rows.Add(0, "Agua", 0)
        dt.Rows.Add(0, "Luz", 0)
        dt.Rows.Add(0, "Alimentacion", 0)
        dt.Rows.Add(0, "Transporte", 0)
        dt.Rows.Add(0, "Escuela", 0)
        dt.Rows.Add(0, "Telefono", 0)
        dt.Rows.Add(0, "Distracciones", 0)
        dt.Rows.Add(0, "Otros", 0)
        dgv_ingresos_mensuales.DataSource = dt
        dgv_ingresos_mensuales.Enabled = False
    End Sub

    Sub Limpiar_Visitas()
        cmb_Nombre.SelectedValue = 0
        dtp_FechaVisita.Value = Now.ToShortDateString
        dtp_HoraVisita.Value = Now.ToLongDateString
        tbx_MotivoVisita.Clear()
        rtb_Observaciones.Clear()
        chk_ProximaVisita.Checked = False
    End Sub

    Sub Limpiar_Inmueble()
        tbx_InmPropietario.Clear()
        tbx_InmCantHabitantes.Clear()
        tbx_InmCantPisos.Clear()
        tbx_InmCantRecamaras.Clear()
        tbx_InmCantBanos.Clear()
        tbx_InmuebleOtro.Clear()
        chk_InmSala.Checked = False
        chk_InmCocina.Checked = False
        chk_InmPatio.Checked = False
        chk_InmComedor.Checked = False
        chk_InmCochera.Checked = False
        chk_InmCuartoServicio.Checked = False
        cmb_Habitacion.SelectedValue = 0
        cmb_Construccion.SelectedValue = 0
        rtb_ExteriorDesc.Clear()
        cmb_Mobiliario.SelectedValue = 0
        cmb_MobCalidad.SelectedValue = 0
        cmb_MobTipo.SelectedValue = 0
        rdb_InteriorLO_Si.Checked = False
        rdb_InteriorLO_No.Checked = False
        rtb_InteriorDesc.Clear()
    End Sub

    Sub Limpiar_Referencias()
        tbx_RefNombre.Tag = Nothing
        tbx_RefNombre.Clear()
        cmb_RefTipoPer.SelectedValue = 0
        tbx_RefDefPer.Clear()
        tbx_RefDefFam.Clear()
        tbx_RefTiempo.Clear()
    End Sub

    Sub LimpiarIngresosEgresos()
        rdb_PlanEndeuda_Si.Checked = False
        rdb_PlanEndeuda_No.Checked = False
        tbx_PlanEndeudaDesc.Clear()
        rdb_DeudaAct_Si.Checked = False
        rdb_DeudaAct_No.Checked = False

        tbx_AsciendeDeuda.Clear()
        tbx_AsciendeIngreso.Clear()
        tbx_IngresoDedicadoAhorro.Clear()
        rdb_FamiliarTrabajaCorporacion_SI.Checked = False
        rdb_FamiliarTrabajaCorporacion_NO.Checked = False
        tbx_NoPersonasAportan.Clear()
        tbx_NoDependientesEcono.Clear()
        rdb_AutoPropio_SI.Checked = False
        rdb_AutoPropio_NO.Checked = False
        tbx_AutoPropio_Marca.Clear()
        tbx_AutoPropio_Modelo.Clear()
        tbx_TarjetaCReditoManeja.Clear()
        rdb_AlgunaPropiedad_SI.Checked = False
        rdb_AlgunaPropiedad_NO.Checked = False
        tbx_AlgunaPropiedad_Ubicacion.Clear()

        'lsv_IngresosMensDistrubucion.Clear()
    End Sub
    Sub Todo_Enable(ByVal Activar As Boolean)
        'Pestaña Visita
        grp_Visita.Enabled = Activar
        If chk_ProximaVisita.Checked AndAlso Activar = False Then grp_Proxima.Enabled = False

        'Pestaña Características
        grp_DescripcionIn.Enabled = Activar
        grp_DistribucionIn.Enabled = Activar
        grp_DeudaPlan.Enabled = Activar
        grp_DeudaActual.Enabled = Activar
        grp_Habitacion.Enabled = Activar
        grp_Construccion.Enabled = Activar
        grp_Fachada.Enabled = Activar
        grp_Mobiliario.Enabled = Activar
        grp_Interior.Enabled = Activar
        btn_Borrar_Caracteristicas.Enabled = False
        btn_Guardar_Caracteristicas.Enabled = False
        If Activar AndAlso Id_VisitaInmueble = 0 Then
            btn_Guardar_Caracteristicas.Enabled = True
        ElseIf Activar AndAlso Id_VisitaInmueble > 0 Then
            btn_Guardar_Caracteristicas.Enabled = True
            btn_Borrar_Caracteristicas.Enabled = True
        End If

        'Pestaña Referencias (Descripcion casa habitacion)
        btn_Agregar_Ref.Enabled = Activar
        lsv_Referencias.Enabled = Activar
        btn_Guardar_Ref.Enabled = Activar AndAlso lsv_Referencias.Items.Count > 0

        'pestaña ingresos y egresos
        If Activar Then
            BotonesIngresosEgresos(Activar)
        Else
            BotonesIngresosEgresos(False)
        End If

    End Sub
    Sub BotonesIngresosEgresos(ByVal resp As Boolean)
        grp_DeudaPlan.Enabled = resp
        grp_DeudaActual.Enabled = resp
        grp_AsciendeDeuda.Enabled = resp
        grp_FamiliarTrabajaCorporacion.Enabled = resp
        grp_AsciendeIngreso.Enabled = resp
        grp_IngresosDedicadosAhorro.Enabled = resp
        grp_NoPersonasAportan.Enabled = resp
        grp_NoDependientesEcono.Enabled = resp
        grp_ManejaTDC.Enabled = resp
        grp_AutoPropio.Enabled = resp
        grp_AlgunaPropiedad.Enabled = resp
        grp_IngresosMensDistrubucion.Enabled = resp
        dgv_ingresos_mensuales.Enabled = resp
        btn_GuardarIngresosEgresos.Enabled = resp
        btn_BorrarIngresosEgresos.Enabled = resp
        btn_CancelarIngresosEgresos.Enabled = resp
    End Sub
    Sub Botones_Referencia()
        btn_Guardar_Ref.Enabled = lsv_Referencias.Items.Count > 0
        btn_Modificar_Referencias.Enabled = lsv_Referencias.SelectedItems.Count > 0
        btn_Borrar_Referencias.Enabled = lsv_Referencias.SelectedItems.Count > 0
    End Sub

    Private Function ValidarDatos() As Boolean
        Select Case Tab_VisitaDomiciliaria.SelectedTab.Name
            Case Tab_Visita.Name
                If cmb_Nombre.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione el Empleado que realizó la Visita Domiciliaria.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Nombre.Focus()
                    Return True
                End If
                If cmb_Nombre.SelectedValue = Id_Empleado Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Visitador no puede ser el mismo que el Empleado Visitado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Nombre.Focus()
                    Return True
                End If

                'If dtp_FechaVisita.Value < DateAdd(DateInterval.Month, -1, Today.Date) Then
                '    Me.Cursor = Cursors.Default
                '    MsgBox("La Fecha no debe ser mayor a un mes.", MsgBoxStyle.Critical, frm_MENU.Text)
                '    dtp_FechaVisita.Focus()
                '    Return True
                'Else
                If dtp_FechaVisita.Value.Date > Today.Date Then
                    Me.Cursor = Cursors.Default
                    MsgBox("La Fecha no debe ser mayor a la fecha actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                    dtp_FechaVisita.Focus()
                    Return True
                End If

                If tbx_MotivoVisita.TextLength < 5 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("El Motivo de la Visita debe ser más explícita.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_MotivoVisita.Focus()
                    Return True
                End If

                If rtb_Observaciones.TextLength < 10 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Las Observaciones de la Visita debe ser más explícita.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_MotivoVisita.Focus()
                    Return True
                End If

                'Validar los datos de la próxima visita
                If chk_ProximaVisita.Checked Then
                    If cmb_NombreProx.SelectedValue = 0 Then
                        Me.Cursor = Cursors.Default
                        MsgBox("Seleccione el Empleado que irá a la Próxima Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
                        cmb_NombreProx.Focus()
                        Return True
                    End If
                    If cmb_NombreProx.SelectedValue = Id_Empleado Then
                        Me.Cursor = Cursors.Default
                        MsgBox("El Visitador no puede ser el mismo que el Empleado Visitado.", MsgBoxStyle.Critical, frm_MENU.Text)
                        cmb_NombreProx.Focus()
                        Return True
                    End If
                    If dtp_FechaProx.Value.Date < dtp_FechaVisita.Value.Date Then
                        Me.Cursor = Cursors.Default
                        MsgBox("La Próxima Fecha no puede ser menor a la primer Fecha de Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
                        dtp_FechaProx.Focus()
                        Return True
                    End If
                    If tbx_MotivoProx.TextLength < 5 Then
                        Me.Cursor = Cursors.Default
                        MsgBox("El Motio de la Próxima Visita debe ser más explícita.", MsgBoxStyle.Critical, frm_MENU.Text)
                        tbx_MotivoProx.Focus()
                        Return True
                    End If
                End If

            Case TabDescripcionCasaHabitacion.Name
                If tbx_InmPropietario.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique el Nombre del Propietario del Inmueble.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmPropietario.Focus()
                    Return True
                End If

                If tbx_InmCantHabitantes.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique la Cantidad de Habitantes en la Vivienda.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmCantHabitantes.Focus()
                    Return True
                End If

                If tbx_InmCantPisos.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique la Cantidad de Pisos o Niveles de la Vivienda.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmCantPisos.Focus()
                    Return True
                End If

                If tbx_InmCantRecamaras.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique la Cantidad de Recamaras de la Vivienda.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmCantRecamaras.Focus()
                    Return True
                End If

                If tbx_InmCantBanos.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique la Cantidad de Baños de la Vivienda.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmCantBanos.Focus()
                    Return True
                ElseIf tbx_InmCantBanos.Text > 9 Then
                    MsgBox("La cantidad de Baños es Incorrecta.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmCantBanos.Focus()
                    Return True
                End If



                If chk_InmComedor.Checked = False And chk_InmSala.Checked = False And chk_InmCocina.Checked = False And chk_InmPatio.Checked = False And chk_InmCochera.Checked = False And chk_InmCuartoServicio.Checked = False And tbx_InmuebleOtro.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique la distribucción del Inmueble.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_InmuebleOtro.Focus()
                    Return True
                End If

                If rdb_PlanEndeuda_Si.Checked = False And rdb_PlanEndeuda_No.Checked = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione si tiene o no un Plan para un Endeudamiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_PlanEndeudaDesc.Focus()
                    Return True
                ElseIf rdb_PlanEndeuda_Si.Checked = True And tbx_PlanEndeudaDesc.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Se necesita una descripción en el Plan de Endeudamiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_PlanEndeudaDesc.Focus()
                    Return True
                End If

                If rdb_DeudaAct_Si.Checked = False And rdb_DeudaAct_No.Checked = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione si tiene o no una Deuda Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_AsciendeDeuda.Focus()
                    Return True
                ElseIf rdb_DeudaAct_Si.Checked = True And tbx_AsciendeDeuda.TextLength = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Se necesita una descripción en la Deuda Actual.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_AsciendeDeuda.Focus()
                    Return True
                End If

                If cmb_Habitacion.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione como es la Casa.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Habitacion.Focus()
                    Return True
                ElseIf cmb_Habitacion.Text = "OTRO" And tbx_HabitacionOtro.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique cual es la Otra forma de la Habitación.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_HabitacionOtro.Focus()
                    Return True
                End If

                If cmb_Construccion.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione cual es el tipo del material de la Construcción.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Construccion.Focus()
                    Return True
                ElseIf cmb_Construccion.Text = "OTRO" And tbx_ConstOtro.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique cual es el Otro tipo del material de la Construcción.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_ConstOtro.Focus()
                    Return True
                End If

                If rtb_ExteriorDesc.TextLength < 10 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Describa mejor como se encontraba la Fachada Exterior.", MsgBoxStyle.Critical, frm_MENU.Text)
                    rtb_ExteriorDesc.Focus()
                    Return True
                End If

                If cmb_Mobiliario.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione el Mobiliario.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_Mobiliario.Focus()
                    Return True
                End If

                If cmb_MobCalidad.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione cual es la Calidad del Mobiliario.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_MobCalidad.Focus()
                    Return True
                ElseIf cmb_MobCalidad.Text = "OTRO" And tbx_MobCalidadOtro.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique cual es la Otra Calidad del Mobiliario.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_MobCalidadOtro.Focus()
                    Return True
                End If

                If cmb_MobTipo.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione cual es el Tipo de Mobiliario.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_MobTipo.Focus()
                    Return True
                ElseIf cmb_MobTipo.Text = "OTRO" And tbx_MobTipoOtro.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Especifique cual es el Otro Tipo de Mobiliario.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_MobTipoOtro.Focus()
                    Return True
                End If

                If rdb_InteriorLO_Si.Checked = False And rdb_InteriorLO_No.Checked = False Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione si tenía o no el Interior de la Casa Limpio y Ordenado.", MsgBoxStyle.Critical, frm_MENU.Text)
                    rtb_InteriorDesc.Focus()
                    Return True
                ElseIf rtb_InteriorDesc.TextLength < 10 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Describa mejor como se encontraba el Interior de la Casa.", MsgBoxStyle.Critical, frm_MENU.Text)
                    rtb_InteriorDesc.Focus()
                    Return True
                End If

            Case Tab_Referencias.Name
                If tbx_RefNombre.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Escriba el Nombre de la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_RefNombre.Focus()
                    Return True
                End If

                If cmb_RefTipoPer.SelectedValue = 0 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Seleccione una Definición de la Persona.", MsgBoxStyle.Critical, frm_MENU.Text)
                    cmb_RefTipoPer.Focus()
                    Return True
                ElseIf cmb_RefTipoPer.Text = "OTRO" And tbx_RefDefPer.TextLength < 5 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Describa mejor la Definición de la Persona.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_RefDefPer.Focus()
                    Return True
                End If

                If tbx_RefDefFam.TextLength < 5 Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Describa mejor la Definición de la Familia.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_RefDefFam.Focus()
                    Return True
                End If

                If tbx_RefTiempo.Text = Nothing Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Escriba el Tiempo que tiene la persona de conocer a la Familia.", MsgBoxStyle.Critical, frm_MENU.Text)
                    tbx_RefTiempo.Focus()
                    Return True
                End If
        End Select

        Return False

    End Function

    Sub EnableOtros(ByVal lbl_Otro As Label, ByVal tbx_Otro As TextBox, ByVal lbl_OtroA As Label, ByVal cmb As ComboBox)
        'Los objetos de Otro se habilitan o deshabilitan cuando se seleccione la opción de Otro según el Combo
        If cmb.Text = "OTRO" Then
            lbl_Otro.Enabled = True
            tbx_Otro.Enabled = True
            lbl_OtroA.Visible = True
        Else
            lbl_Otro.Enabled = False
            tbx_Otro.Enabled = False
            tbx_Otro.Clear()
            lbl_OtroA.Visible = False
        End If
    End Sub

#End Region

#Region "Visita"

    Private Sub rtb_Observaciones_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles rtb_Observaciones.KeyPress
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Buscar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Buscar.Click, btn_BuscarProx.Click
        SegundosDesconexion = 0

        Dim frm As New Frm_BuscarCliente
        frm.Consulta = Frm_BuscarCliente.Query.Empleados
        frm.Lbl_Nota.Text = "Doble Click para Seleccionar un Empleado y cerrar la ventana de búsqueda."
        frm.ShowDialog()

        If sender.Equals(btn_Buscar) Then
            cmb_Nombre.SelectedValue = frm.Id
            ' tbx_Clave.Text = frm.Clave 6mayo2014sedesactivo
        Else 'sender.equals(btn_BuscarProx)
            ' tbx_ClaveProx.Text = frm.Clave
            cmb_NombreProx.SelectedValue = frm.Id
        End If
    End Sub

    Private Sub chk_ProximaVisita_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_ProximaVisita.CheckedChanged
        SegundosDesconexion = 0

        grp_Proxima.Enabled = chk_ProximaVisita.Checked
        cmb_NombreProx.SelectedValue = 0
        dtp_FechaProx.Value = Today.Date
        dtp_HoraProx.Value = Now.ToLongDateString
        tbx_MotivoProx.Clear()
    End Sub

    Private Sub lsv_VisitasDomiciliarias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_VisitasDomiciliarias.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Limpiar_Visitas()
        Call Limpiar_Inmueble()
        Call Limpiar_Referencias()
        Call LimpiarIngresosEgresos()

        If lsv_VisitasDomiciliarias.SelectedItems.Count = 0 Then
            Id_Visita = 0
            Id_VisitaInmueble = 0

            btn_Modificar.Enabled = False
            btn_Importar.Enabled = False

            'Aqui se inhabilitan todas las pestañas
            'y se habilitan hasta que se capturen los DATOS GENERALES de la visita
            Me.TabDescripcionCasaHabitacion.Parent = Nothing
            Me.Tab_Referencias.Parent = Nothing
            Me.TabIngresosEgresos.Parent = Nothing
        Else
            Id_Visita = lsv_VisitasDomiciliarias.SelectedItems(0).Tag
            Id_VisitaInmueble = lsv_VisitasDomiciliarias.SelectedItems(0).SubItems(4).Text

            btn_Modificar.Enabled = True
            btn_Importar.Enabled = True

            Me.TabDescripcionCasaHabitacion.Parent = Me.Tab_VisitaDomiciliaria
            Me.Tab_Referencias.Parent = Me.Tab_VisitaDomiciliaria
            Me.TabIngresosEgresos.Parent = Me.Tab_VisitaDomiciliaria

            'Carga la información del empleado o prospecto para modificarse
            Dim Dr As DataRow = fn_VisitaDomiciliaria_Read(Id_Visita)
            If Dr IsNot Nothing Then
                cmb_Nombre.SelectedValue = Dr("Usuario_Visita")
                dtp_FechaVisita.Value = Dr("Fecha_Visita")
                dtp_HoraVisita.Value = Today.Date & " " & Dr("Hora_Visita")
                tbx_MotivoVisita.Text = Dr("Motivo_Visita")
                rtb_Observaciones.Text = Dr("Observaciones")
                If Dr("UsuarioProx_Visita") > 0 Then
                    chk_ProximaVisita.Checked = True
                    cmb_NombreProx.SelectedValue = Dr("UsuarioProx_Visita")
                    dtp_FechaProx.Value = Dr("FechaProx_Visita")
                    dtp_HoraProx.Value = Today.Date & " " & Dr("HoraProx_Visita")
                    tbx_MotivoProx.Text = Dr("MotivoProx_Visita")
                End If
            End If

            Dr = Nothing

            'Llenar la pesataña de Inmueble
            If Id_Visita > 0 Then Dr = fn_VisitaDomiciliariaInmueble_Read(Id_Visita)

            If Dr IsNot Nothing Then
                tbx_InmPropietario.Text = Dr("Propietario")
                tbx_InmCantHabitantes.Text = Dr("Cantidad_Habitantes")
                tbx_InmCantPisos.Text = Dr("Cantidad_Plantas")
                tbx_InmCantRecamaras.Text = Dr("Cantidad_Recamaras")
                tbx_InmCantBanos.Text = Dr("Cantidad_Banos")
                If Dr("Tiene_Sala") = "S" Then chk_InmSala.Checked = True
                If Dr("Tiene_Cocina") = "S" Then chk_InmCocina.Checked = True
                If Dr("Tiene_Comedor") = "S" Then chk_InmComedor.Checked = True
                If Dr("Tiene_Cochera") = "S" Then chk_InmCochera.Checked = True
                If Dr("Tiene_PatioDelantero") = "S" Then chk_InmPatio.Checked = True
                If Dr("Tiene_PatioTrasero") = "S" Then chk_InmCuartoServicio.Checked = True
                tbx_InmuebleOtro.Text = Dr("Cantidad_MobiliarioOtro")
                'If Dr("Planea_Endeudamiento") = "S" Then rdb_PlanEndeuda_Si.Checked = True Else rdb_PlanEndeuda_No.Checked = True
                'tbx_PlanEndeudaDesc.Text = Dr("Descripcion_Endeudamiento")
                'If Dr("Endeudamiento_Actual") = "S" Then rdb_DeudaAct_Si.Checked = True Else rdb_DeudaAct_No.Checked = True
                'tbx_DeudaActDesc.Text = Dr("Descripcion_EndeudamientoA")
                cmb_Habitacion.SelectedValue = Dr("Tipo_Casa")
                tbx_HabitacionOtro.Text = Dr("Tipo_CasaOtro")
                cmb_Construccion.SelectedValue = Dr("Tipo_Material")
                tbx_ConstOtro.Text = Dr("Tipo_MaterialOtro")
                rtb_ExteriorDesc.Text = Dr("Observaciones_Exterior")
                cmb_Mobiliario.SelectedValue = Dr("Cantidad_Mobiliario")
                cmb_MobCalidad.SelectedValue = Dr("Calidad_Mobiliario")
                tbx_MobCalidadOtro.Text = Dr("Calidad_MobiliarioOtro")
                cmb_MobTipo.SelectedValue = Dr("Tipo_Mobiliario")
                tbx_MobTipoOtro.Text = Dr("Tipo_MobiliarioOtro")
                If Dr("Limpio_Ordenado") = "S" Then rdb_InteriorLO_Si.Checked = True Else rdb_InteriorLO_No.Checked = True
                rtb_InteriorDesc.Text = Dr("Observaciones_Interior")
            End If

            'Llenar la pestaña de Referencias
            Dim Dt As DataTable = fn_VisitaDomiciliariaRef_LlenarLista(lsv_Referencias, lsv_VisitasDomiciliarias.SelectedItems(0).Tag)
            Dt.Dispose()

            'Llenar Ingresos y Egresos
            Dim dtIngresos As DataTable = fn_VisitaDom_IngresosEgresos_LlenarLista(lsv_VisitasDomiciliarias.SelectedItems(0).Tag)
            If dtIngresos.Rows.Count > 0 Then
                ActualizaIngresosEgresos = True
                Id_IngresosEgresos = IIf(dtIngresos.Rows(0)("Id_IngresosEgresos"), Integer.Parse(dtIngresos.Rows(0)("Id_IngresosEgresos")), 0)
                If (dtIngresos.Rows(0)("PlanEndeudamiento") = "S") Then
                    rdb_PlanEndeuda_Si.Checked = True
                    rdb_PlanEndeuda_No.Checked = False
                Else
                    rdb_PlanEndeuda_Si.Checked = False
                    rdb_PlanEndeuda_No.Checked = True
                End If
                tbx_PlanEndeudaDesc.Text = IIf(dtIngresos.Rows(0)("PlanEndeuDescripcion") <> "", dtIngresos.Rows(0)("PlanEndeuDescripcion"), "")

                If dtIngresos.Rows(0)("TieneDeuda") = "S" Then
                    rdb_DeudaAct_Si.Checked = True
                    rdb_DeudaAct_No.Checked = False
                Else
                    rdb_DeudaAct_Si.Checked = False
                    rdb_DeudaAct_No.Checked = True
                End If
                tbx_AsciendeDeuda.Text = IIf(dtIngresos.Rows(0)("CantidadDeuda").ToString() <> "", Decimal.Parse(dtIngresos.Rows(0)("CantidadDeuda")).ToString("##,##0.00"), 0)
                tbx_AsciendeIngreso.Text = IIf(dtIngresos.Rows(0)("Ingresos").ToString() <> "", Decimal.Parse(dtIngresos.Rows(0)("Ingresos")).ToString("##,##0.00"), 0)
                tbx_IngresoDedicadoAhorro.Text = IIf(dtIngresos.Rows(0)("IngresoDedicadoAhorro") <> 0, dtIngresos.Rows(0)("IngresoDedicadoAhorro"), 0)
                tbx_NoPersonasAportan.Text = IIf(dtIngresos.Rows(0)("NoPersAportaEconomicamente") <> 0, dtIngresos.Rows(0)("NoPersAportaEconomicamente"), 0)
                tbx_NoDependientesEcono.Text = IIf(dtIngresos.Rows(0)("NoPerDependienteEconomico") <> 0, dtIngresos.Rows(0)("NoPerDependienteEconomico"), 0)
                If dtIngresos.Rows(0)("FamTrabCorpPoliOPriv") = "S" Then
                    rdb_FamiliarTrabajaCorporacion_SI.Checked = True
                    rdb_FamiliarTrabajaCorporacion_NO.Checked = False
                Else
                    rdb_FamiliarTrabajaCorporacion_SI.Checked = False
                    rdb_FamiliarTrabajaCorporacion_NO.Checked = True
                End If
                tbx_TarjetaCReditoManeja.Text = IIf(dtIngresos.Rows(0)("ManejaTDC") <> "", dtIngresos.Rows(0)("ManejaTDC"), "")
                If dtIngresos.Rows(0)("AutoPropio") = "S" Then
                    rdb_AutoPropio_SI.Checked = True
                    rdb_AutoPropio_NO.Checked = False
                Else
                    rdb_AutoPropio_SI.Checked = False
                    rdb_AutoPropio_NO.Checked = True
                End If
                tbx_AutoPropio_Marca.Text = IIf(dtIngresos.Rows(0)("Marca") <> "", dtIngresos.Rows(0)("Marca"), "")
                tbx_AutoPropio_Modelo.Text = IIf(dtIngresos.Rows(0)("Modelo") <> "", dtIngresos.Rows(0)("Modelo"), "")
                If dtIngresos.Rows(0)("TienePropiedad") = "S" Then
                    rdb_AlgunaPropiedad_SI.Checked = True
                    rdb_AlgunaPropiedad_NO.Checked = False
                Else
                    rdb_AlgunaPropiedad_SI.Checked = False
                    rdb_AlgunaPropiedad_NO.Checked = True
                End If
                tbx_AlgunaPropiedad_Ubicacion.Text = IIf(dtIngresos.Rows(0)("UbicacionPropiedad") <> "", dtIngresos.Rows(0)("UbicacionPropiedad"), "")

                Dim dtDistribucionIngresosMensuales = fn_VisitaDom_DistribucionIngresosMensuales_Llenartabla(Id_IngresosEgresos)
                If dtDistribucionIngresosMensuales.Rows.Count > 0 Then
                    dgv_ingresos_mensuales.DataSource = dtDistribucionIngresosMensuales
                    dgv_ingresos_mensuales.Update()
                End If

                Dim familiaresEnDomicilio = fn_VisitaDom_Familiares_LlenarLista(Id_Empleado, Id_EmpleadoP)
                If familiaresEnDomicilio.Rows.Count > 0 Then
                    dgv_Familiares.DataSource = familiaresEnDomicilio
                End If
            Else
                Dim dtDistribucionIngresosMensuales = fn_VisitaDom_DistribucionIngresosMensuales_Llenartabla(Id_IngresosEgresos)
                If dtDistribucionIngresosMensuales.Rows.Count > 0 Then
                    dgv_ingresos_mensuales.DataSource = dtDistribucionIngresosMensuales
                    dgv_ingresos_mensuales.Update()
                End If

                Dim familiaresEnDomicilio = fn_VisitaDom_Familiares_LlenarLista(Id_Empleado, Id_EmpleadoP)
                If familiaresEnDomicilio.Rows.Count > 0 Then
                    dgv_Familiares.DataSource = familiaresEnDomicilio
                End If
            End If


        End If

        Call Todo_Enable(False)
    End Sub

    Private Sub btn_Nuevo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Nuevo.Click, btn_Cancelar_Visita.Click
        SegundosDesconexion = 0

        'Revisar que existan datos antes de "Cancelar - Regresar"
        If sender.Equals(btn_Cancelar_Visita) Then
            For Each Elemento As ListViewItem In lsv_Referencias.Items
                If Elemento.Tag = Nothing Then
                    If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                        Tab_VisitaDomiciliaria.SelectedTab = Tab_Referencias
                        Exit Sub
                    End If
                    Exit For
                End If
            Next
        End If

        Call Limpiar_Visitas()
        Call Limpiar_Inmueble()
        Call Limpiar_Referencias()
        lsv_Referencias.Items.Clear()

        Id_Visita = 0
        Id_VisitaInmueble = 0

        Me.TabDescripcionCasaHabitacion.Parent = Nothing
        Me.Tab_Referencias.Parent = Nothing
        Me.TabIngresosEgresos.Parent = Nothing

        lsv_VisitasDomiciliarias.SelectedItems.Clear()
        btn_Modificar.Enabled = False
        btn_Importar.Enabled = False

        If sender.Equals(btn_Nuevo) Then
            Tab_Visita.Text = "Nueva Visita"
            lsv_VisitasDomiciliarias.Enabled = False
            btn_Nuevo.Enabled = False
            btn_Cancelar_Visita.Enabled = True
            btn_Guardar_Visita.Enabled = True
            grp_Visita.Enabled = True
            Call Todo_Enable(True)
        Else 'sender.equals(btn_Cancelar)
            Tab_Visita.Text = "Visita"
            lsv_VisitasDomiciliarias.Enabled = True
            btn_Nuevo.Enabled = True
            btn_Cancelar_Visita.Enabled = False
            btn_Guardar_Visita.Enabled = False
            grp_Visita.Enabled = False
            Call Todo_Enable(False)
            btn_Cancelar_Visita.Text = "&Cancelar"
        End If
    End Sub

    Private Sub btn_Modificar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar.Click
        SegundosDesconexion = 0

        Tab_Visita.Text = "Modificar Visita"
        lsv_VisitasDomiciliarias.Enabled = False
        btn_Nuevo.Enabled = False
        btn_Modificar.Enabled = False
        btn_Importar.Enabled = True
        grp_Visita.Enabled = True
        btn_Guardar_Visita.Enabled = True
        btn_Cancelar_Visita.Enabled = True
        Call Todo_Enable(True)
        grp_Proxima.Enabled = chk_ProximaVisita.Checked
    End Sub

    Private Sub btn_Importar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Importar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_CargarArchivos
        frm.Filtro = "Imagenes (*.jpg)|*.jpg"
        frm.MaxArchivos = 6
        frm.Id_Tabla = Id_Visita
        frm.Tipo = frm_CargarArchivos.Query.VisitasDomiciliarias
        frm.DescripcionEnable = True
        frm.ShowDialog()
    End Sub

    Private Sub btn_Guardar_Visita_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Visita.Click
        SegundosDesconexion = 0

        If ValidarDatos() Then Exit Sub

        If Id_Visita = 0 Then
            'Guardar los datos
            If Not fn_VisitaDomiciliaria_Nuevo(Id_Empleado, Id_EmpleadoP, dtp_FechaVisita.Value.Date, dtp_HoraVisita.Value.TimeOfDay.ToString, cmb_Nombre.SelectedValue, tbx_MotivoVisita.Text, rtb_Observaciones.Text, cmb_NombreProx.SelectedValue, dtp_FechaProx.Value.Date, dtp_HoraProx.Value.TimeOfDay.ToString, tbx_MotivoProx.Text, Id_Visita) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar los Datos de la Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Aqui se habilitan todas las pestañas
            'una vez que se han capturado e insertado los DATOS GENERALES
            Me.TabDescripcionCasaHabitacion.Parent = Me.Tab_VisitaDomiciliaria
            Me.Tab_Referencias.Parent = Me.Tab_VisitaDomiciliaria
            Me.TabIngresosEgresos.Parent = Me.Tab_VisitaDomiciliaria
            Tab_Visita.Text = "Modificar Visita"

            'Guardar registro del movimiento en bitácora.
            Cn_Login.fn_Log_Create("GUARDAR VISITA DOMICILIARIA DE: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
        Else
            'Guardar los datos modificados
            Me.Cursor = Cursors.WaitCursor
            If Not fn_VisitaDomiciliaria_Actualizar(Id_Visita, dtp_FechaVisita.Value.Date, dtp_HoraVisita.Value.TimeOfDay.ToString, cmb_Nombre.SelectedValue, tbx_MotivoVisita.Text, rtb_Observaciones.Text, cmb_NombreProx.SelectedValue, dtp_FechaProx.Value.Date, dtp_HoraProx.Value.TimeOfDay.ToString, tbx_MotivoProx.Text) Then
                Me.Cursor = Cursors.Default
                Cn_Login.fn_Log_Create("ERROR AL MODIFICAR VISITA DOMICILIARIA DE: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
                MsgBox("Error al intentar modificar los Datos de la Visita.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Guardar registro del movimiento en bitácora.
            Cn_Login.fn_Log_Create("MODIFICAR VISITA DOMICILIARIA DE: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
        End If

        'Se omite el cancelar visita porque ya se guardo información de esta en la base de datos
        btn_Cancelar_Visita.Text = "&Regresar"
        btn_Importar.Enabled = True
        If Not fn_VisitaDomiciliaria_LlenarLista(lsv_VisitasDomiciliarias, Id_Empleado, Id_EmpleadoP) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Visitas Domiciliarias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Me.Cursor = Cursors.Default
        MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        'cmb_Nombre.SelectedValue = 0
        'tbx_MotivoVisita.Clear()
        'rtb_Observaciones.Clear()
        'chk_ProximaVisita.Checked = False
        'cmb_NombreProx.SelectedValue = 0
        'tbx_MotivoProx.Clear()
        Call Limpiar_Visitas()
        If Not fn_VisitaDomiciliaria_LlenarLista(lsv_VisitasDomiciliarias, Id_Empleado, Id_EmpleadoP) Then
            MsgBox("Ocurrio un error al intentar llenar la lista de Visitas Domiciliarias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_VisitasDomiciliarias_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Dim FaltaGuardar As Boolean = False

        If tbx_RefNombre.Tag IsNot Nothing Then
            FaltaGuardar = True
        Else
            For Each Elemento As ListViewItem In lsv_Referencias.Items
                If Elemento.Tag = Nothing Then
                    FaltaGuardar = True
                    Exit For
                End If
            Next
        End If

        If FaltaGuardar Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                e.Cancel = True
            End If
        End If
    End Sub

#End Region

#Region "Características"

    Private Sub cmb_Habitacion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Habitacion.SelectedValueChanged
        SegundosDesconexion = 0

        'Los objetos de Otro para Habitación
        Call EnableOtros(lbl_HabitacionOtro, tbx_HabitacionOtro, lbl_HabitacionOtroA, cmb_Habitacion)
    End Sub

    Private Sub cmb_Construccion_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Construccion.SelectedValueChanged
        SegundosDesconexion = 0

        'Los objetos de Otro para Construcción
        Call EnableOtros(lbl_ConstOtro, tbx_ConstOtro, lbl_ConstOtroA, cmb_Construccion)
    End Sub

    Private Sub cmb_MobCalidad_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MobCalidad.SelectedValueChanged
        SegundosDesconexion = 0

        'Los objetos de Otro para Calidad de Mobiliario
        Call EnableOtros(lbl_MobCalidadOtro, tbx_MobCalidadOtro, lbl_MobCalidadOtroA, cmb_MobCalidad)
    End Sub

    Private Sub cmb_MobTipo_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_MobTipo.SelectedValueChanged
        SegundosDesconexion = 0

        'Los objetos de Otro para Tipo de Mobiliario
        Call EnableOtros(lbl_MobTipoOtro, tbx_MobTipoOtro, lbl_MobTipoOtroA, cmb_MobTipo)
    End Sub

    Private Sub rtb_InteriorDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub rtb_ExteriorDesc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        e.KeyChar = UCase(e.KeyChar)
    End Sub

    Private Sub btn_Guardar_Caracteristicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Caracteristicas.Click
        SegundosDesconexion = 0

        'Validar datos
        If ValidarDatos() Then Exit Sub

        Dim Sala, Cocina, Comedor, Cochera, Patio, CuartoServicios, PlanEndeuda, DeudaActual, Limpio As String

        'Especificar el Si o No
        If chk_InmSala.Checked Then Sala = "S" Else Sala = "N"
        If chk_InmCocina.Checked Then Cocina = "S" Else Cocina = "N"
        If chk_InmComedor.Checked Then Comedor = "S" Else Comedor = "N"
        If chk_InmCochera.Checked Then Cochera = "S" Else Cochera = "N"
        If chk_InmPatio.Checked Then Patio = "S" Else Patio = "N"
        If chk_InmCuartoServicio.Checked Then CuartoServicios = "S" Else CuartoServicios = "N"

        If rdb_PlanEndeuda_Si.Checked Then PlanEndeuda = "S" Else PlanEndeuda = "N"
        If rdb_DeudaAct_Si.Checked Then DeudaActual = "S" Else DeudaActual = "N"
        If rdb_InteriorLO_Si.Checked Then Limpio = "S" Else Limpio = "N"

        'Cuando se guarda nuevos datos del inmueble (características)
        If Id_VisitaInmueble = 0 Then
            Me.Cursor = Cursors.WaitCursor

            'Guardar los datos
            If Not fn_VisitaDomiciliariaInmueble_Nuevo(Id_Visita, cmb_Habitacion.SelectedValue, tbx_InmPropietario.Text, tbx_HabitacionOtro.Text, cmb_Construccion.SelectedValue,
                                                       tbx_ConstOtro.Text, tbx_InmCantHabitantes.Text, Sala, Cocina, Comedor, Cochera, Patio, CuartoServicios,
                                                       cmb_Mobiliario.SelectedValue, tbx_InmuebleOtro.Text, cmb_MobTipo.SelectedValue, tbx_MobTipoOtro.Text,
                                                       cmb_MobCalidad.SelectedValue, tbx_MobCalidadOtro.Text, tbx_InmCantPisos.Text, tbx_InmCantRecamaras.Text,
                                                       tbx_InmCantBanos.Text, PlanEndeuda, tbx_PlanEndeudaDesc.Text, DeudaActual, "", Limpio,
                                                       rtb_InteriorDesc.Text, rtb_ExteriorDesc.Text, Id_VisitaInmueble) Then
                Me.Cursor = Cursors.Default
                MsgBox("Error al intentar guardar las Características del Inmueble.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            btn_Borrar_Caracteristicas.Enabled = True

            'Guardar registro del movimiento en bitácora.
            Cn_Login.fn_Log_Create("GUARDAR CARACTERISTICAS DEL INMUEBLE DE: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)

            Me.Cursor = Cursors.Default
            MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            If MsgBox("La información será modificada, ¿desea continuar?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.Yes Then
                'Guardar los datos modificados
                Me.Cursor = Cursors.WaitCursor
                If Not fn_VisitaDomiciliariaInmueble_Actualizar(Id_VisitaInmueble, cmb_Habitacion.SelectedValue, tbx_InmPropietario.Text, tbx_HabitacionOtro.Text,
                                                                cmb_Construccion.SelectedValue, tbx_ConstOtro.Text, tbx_InmCantHabitantes.Text, Sala, Cocina, Comedor,
                                                                Cochera, Patio, CuartoServicios, cmb_Mobiliario.SelectedValue, tbx_InmuebleOtro.Text,
                                                                cmb_MobTipo.SelectedValue, tbx_MobTipoOtro.Text, cmb_MobCalidad.SelectedValue, tbx_MobCalidadOtro.Text,
                                                                tbx_InmCantPisos.Text, tbx_InmCantRecamaras.Text, tbx_InmCantBanos.Text, PlanEndeuda, tbx_PlanEndeudaDesc.Text,
                                                                DeudaActual, "", Limpio, rtb_InteriorDesc.Text, rtb_ExteriorDesc.Text) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Error al intentar modificar las Características del Inmueble.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Exit Sub
                End If

                'Guardar registro del movimiento en bitácora.
                Cn_Login.fn_Log_Create("MODIFICAR CARACTERISTICAS DEL INMUEBLE DE: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)

                Me.Cursor = Cursors.Default
                MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            End If
        End If
    End Sub

    Private Sub btn_Borrar_Caracteristicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_Caracteristicas.Click
        SegundosDesconexion = 0

        'Borrar un elemento que ya está guardado en la BD
        Dim frm As New frm_FirmaElectronica
        frm.Bloquear = True
        frm.PedirObservaciones = False
        frm.ShowDialog()

        If frm.Firma Then
            If Not fn_VisitaDomiciliariaInmueble_Borrar(Id_VisitaInmueble) Then
                MsgBox("Ha ocurrido un error al intentar borrar las Características del Inmueble.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
            btn_Borrar_Caracteristicas.Enabled = False
            tbx_InmPropietario.Clear()
            tbx_InmCantHabitantes.Clear()
            tbx_InmCantPisos.Clear()
            tbx_InmCantRecamaras.Clear()
            tbx_InmCantBanos.Clear()
            chk_InmSala.Checked = False
            chk_InmCocina.Checked = False
            chk_InmComedor.Checked = False
            chk_InmPatio.Checked = False
            chk_InmCochera.Checked = False
            chk_InmCuartoServicio.Checked = False
            tbx_InmuebleOtro.Clear()
            rdb_PlanEndeuda_Si.Checked = False
            rdb_PlanEndeuda_No.Checked = False
            tbx_PlanEndeudaDesc.Clear()
            rdb_DeudaAct_Si.Checked = False
            rdb_DeudaAct_No.Checked = False

            cmb_Habitacion.SelectedValue = 0
            cmb_Construccion.SelectedValue = 0
            rtb_ExteriorDesc.Clear()
            cmb_Mobiliario.SelectedValue = 0
            cmb_MobCalidad.SelectedValue = 0
            cmb_MobTipo.SelectedValue = 0
            rdb_InteriorLO_Si.Checked = False
            rdb_InteriorLO_No.Checked = False
            rtb_InteriorDesc.Clear()
            Id_VisitaInmueble = 0
        End If
    End Sub

    Private Sub btn_Cancelar_Caracteristicas_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_Caracteristicas.Click
        SegundosDesconexion = 0

        Tab_VisitaDomiciliaria.SelectedTab = Tab_Visita
    End Sub

#End Region

#Region "Referencias Vecinales"

    Private Sub cmb_RefTipoPer_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0

        'Los objetos de Otro para Construcción
        lbl_RefDefPerA.Visible = cmb_RefTipoPer.Text = "OTRO"
    End Sub

    Private Sub btn_Agregar_Ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar_Ref.Click
        SegundosDesconexion = 0

        If ValidarDatos() Then Exit Sub

        Try
            If lsv_Referencias.SelectedItems.Count > 0 Then lsv_Referencias.SelectedItems(0).Remove()

            Dim Linea As ListViewItem

            Linea = lsv_Referencias.Items.Add(tbx_RefNombre.Text)
            Linea.SubItems.Add(cmb_RefTipoPer.Text)
            Linea.SubItems.Add(tbx_RefDefPer.Text)
            Linea.SubItems.Add(tbx_RefDefFam.Text)
            Linea.SubItems.Add(tbx_RefTiempo.Text)
            Linea.Tag = tbx_RefNombre.Tag

            tbx_RefNombre.Clear()
            cmb_RefTipoPer.SelectedValue = 0
            tbx_RefDefPer.Clear()
            tbx_RefDefFam.Clear()
            tbx_RefTiempo.Clear()

            'Si se estaba modificando el registro se regresan los controles a su estado normal
            If tbx_RefNombre.Tag <> Nothing Then
                tbx_RefNombre.Tag = Nothing
                lsv_Referencias.Enabled = True
            End If

            Call Botones_Referencia()
        Catch
            MsgBox("Ha ocurrido un error al intentar Agregar la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub lsv_Referencias_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SegundosDesconexion = 0

        Call Botones_Referencia()
    End Sub

    Private Sub btn_Guardar_Ref_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar_Ref.Click
        SegundosDesconexion = 0

        Me.Cursor = Cursors.WaitCursor

        'Guardar los datos
        Dim RefDefPer As String
        For Each Elemento As ListViewItem In lsv_Referencias.Items
            Select Case Elemento.SubItems(1).Text
                Case "AGRESIVA"
                    RefDefPer = 1
                Case "IMPULSIVA"
                    RefDefPer = 2
                Case "ENOJONA"
                    RefDefPer = 3
                Case "TRANQUILA"
                    RefDefPer = 4
                Case "SERIO"
                    RefDefPer = 5
                Case "AMIGABLE"
                    RefDefPer = 6
                Case Else
                    RefDefPer = 7
            End Select

            If Elemento.Tag = Nothing Then
                'Se guarda si es un registro nueo (verificando cuando no tiene tag)
                If Not fn_VisitaDomiciliariaRef_Nuevo(Id_Visita, Elemento.Text, RefDefPer, Elemento.SubItems(2).Text, Elemento.SubItems(3).Text, Elemento.SubItems(4).Text) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrio un error al intentar guardar las Referencias de la Visita Domiciliaria.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            Else 'Se actualiza el que tenga valor en el tag
                If Not fn_VisitaDomiciliariaRef_Actualizar(Elemento.Tag, Elemento.Text, RefDefPer, Elemento.SubItems(2).Text, Elemento.SubItems(3).Text, Elemento.SubItems(4).Text) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ocurrio un error al intentar modificar las Referencias de la Visita Domiciliaria.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
            End If
        Next

        lsv_Referencias.Items.Clear()
        If fn_VisitaDomiciliariaRef_LlenarLista(lsv_Referencias, Id_Visita) Is Nothing Then
            MsgBox("Ha ocurrido un error al intentar mostrar las Referencias.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        Call Botones_Referencia()
        Me.Cursor = Cursors.Default
        MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
    End Sub

    Private Sub btn_Modificar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Modificar_Referencias.Click
        SegundosDesconexion = 0

        'Se pasan los valores seleccionados a los controles superiores para modificar
        tbx_RefNombre.Tag = lsv_Referencias.SelectedItems(0).Tag
        tbx_RefNombre.Text = lsv_Referencias.SelectedItems(0).Text
        cmb_RefTipoPer.Text = lsv_Referencias.SelectedItems(0).SubItems(1).Text
        tbx_RefDefPer.Text = lsv_Referencias.SelectedItems(0).SubItems(2).Text
        tbx_RefDefFam.Text = lsv_Referencias.SelectedItems(0).SubItems(3).Text
        tbx_RefTiempo.Text = lsv_Referencias.SelectedItems(0).SubItems(4).Text

        lsv_Referencias.Enabled = False
        btn_Guardar_Ref.Enabled = False
        btn_Borrar_Referencias.Enabled = False
        btn_Modificar_Referencias.Enabled = False
    End Sub

    Private Sub btn_Borrar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Borrar_Referencias.Click
        SegundosDesconexion = 0

        If lsv_Referencias.SelectedItems(0).Tag = Nothing Then
            'Borrar un elemento que no se ha guardado
            If MsgBox("Los datos seleccionados no se han guardado, ¿Desea eliminarlos?.", MsgBoxStyle.Question + MsgBoxStyle.OkCancel, frm_MENU.Text) = MsgBoxResult.Ok Then
                lsv_Referencias.SelectedItems(0).Remove()
            End If
        Else
            'Borrar un elemento que ya está guardado en la BD
            Dim frm As New frm_FirmaElectronica
            frm.Bloquear = True
            frm.PedirObservaciones = False
            frm.ShowDialog()

            If frm.Firma Then
                If Not fn_VisitaDomiciliariaRef_Borrar(lsv_Referencias.SelectedItems(0).Tag) Then
                    MsgBox("Ha ocurrido un error al intentar eliminar la Referencia.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                lsv_Referencias.SelectedItems(0).Remove()
            End If
        End If

        Call Botones_Referencia()
    End Sub

    Private Sub btn_Cancelar_Referencias_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cancelar_Referencias.Click
        SegundosDesconexion = 0

        If tbx_RefNombre.Tag IsNot Nothing Then
            If MsgBox("Existen datos que no han sido guardados. ¿Desea realmente salir?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        lsv_Referencias.Enabled = True
        Call Limpiar_Referencias()
        Tab_VisitaDomiciliaria.SelectedTab = Tab_Visita
    End Sub

    Private Sub btn_GuardarIngresosEgresos_Click(sender As Object, e As EventArgs) Handles btn_GuardarIngresosEgresos.Click
        'plan de endeudamiento
        If rdb_PlanEndeuda_Si.Checked = False And rdb_PlanEndeuda_No.Checked = False Then
            MsgBox("Seleccione si tiene plan de endeudamiento.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'plan de endeudamiento descripcion
        If rdb_PlanEndeuda_Si.Checked Then
            If tbx_PlanEndeudaDesc.Text = "" Then
                MsgBox("Agregar plan de endeudamiento.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        'actualmente tiene deuda
        If rdb_DeudaAct_Si.Checked = False And rdb_DeudaAct_No.Checked = False Then
            MsgBox("Seleccione si tiene actualmente una deuda.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        'cantidad de deuda
        If rdb_DeudaAct_Si.Checked Then
            If tbx_AsciendeDeuda.Text = "" Then
                MsgBox("Agregar Cantidad de Deuda.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        If tbx_AsciendeIngreso.Text = "" Then
            MsgBox("Agregar Ingreso.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If tbx_IngresoDedicadoAhorro.Text = "" Then
            MsgBox("Agregar Porcentaje de Ahorro.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If rdb_FamiliarTrabajaCorporacion_SI.Checked = False And rdb_FamiliarTrabajaCorporacion_NO.Checked = False Then
            MsgBox("Seleccione si ¿Tiene algún familiar que trabaje en alguna corporación policíaca o de seguridad privada?", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If rdb_AutoPropio_SI.Checked Then
            If tbx_AutoPropio_Marca.Text = "" Then
                MsgBox("Agregar marca del auto.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
            If tbx_AutoPropio_Modelo.Text = "" Then
                MsgBox("Agregar modelo del auto.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If
        If rdb_AlgunaPropiedad_SI.Checked Then
            If tbx_AlgunaPropiedad_Ubicacion.Text = "" Then
                MsgBox("Agregar ubicacion de la propiedad.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        End If

        If ActualizaIngresosEgresos Then
            If Cn_Reclutamiento.fn_VisitaDom_IngresosEgresos_Actualizar(Id_IngresosEgresos, Id_Visita, IIf(rdb_PlanEndeuda_Si.Checked, "S", "N"), tbx_PlanEndeudaDesc.Text,
                                                              IIf(rdb_DeudaAct_Si.Checked, "S", "N"), CDec(IIf(tbx_AsciendeDeuda.Text = "", 0, tbx_AsciendeDeuda.Text)),
                                                              CDec(tbx_AsciendeIngreso.Text), CDec(tbx_IngresoDedicadoAhorro.Text),
                                                              CInt(tbx_NoPersonasAportan.Text), CInt(tbx_NoDependientesEcono.Text),
                                                              IIf(rdb_FamiliarTrabajaCorporacion_SI.Checked, "S", "N"), tbx_TarjetaCReditoManeja.Text,
                                                              IIf(rdb_AutoPropio_SI.Checked, "S", "N"), tbx_AutoPropio_Marca.Text, tbx_AutoPropio_Modelo.Text,
                                                              IIf(rdb_AlgunaPropiedad_SI.Checked, "S", "S"), tbx_AlgunaPropiedad_Ubicacion.Text, dgv_ingresos_mensuales) Then
                'Guardar registro del movimiento en bitácora.
                Cn_Login.fn_Log_Create("ACTUALIZAR DATOS INGRESOS EGRESOS DE VISITA DOMICILIARIA: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
                MsgBox("Se Actualizo la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

            End If

        Else
            If Cn_Reclutamiento.fn_VisitaDom_IngresosEgresos_Nuevo(Id_Visita, IIf(rdb_PlanEndeuda_Si.Checked, "S", "N"), tbx_PlanEndeudaDesc.Text,
                                                              IIf(rdb_DeudaAct_Si.Checked, "S", "N"), CDec(IIf(tbx_AsciendeDeuda.Text = "", 0, tbx_AsciendeDeuda.Text)),
                                                              CDec(tbx_AsciendeIngreso.Text), CDec(tbx_IngresoDedicadoAhorro.Text),
                                                              CInt(tbx_NoPersonasAportan.Text), CInt(tbx_NoDependientesEcono.Text),
                                                              IIf(rdb_FamiliarTrabajaCorporacion_SI.Checked, "S", "N"), tbx_TarjetaCReditoManeja.Text,
                                                              IIf(rdb_AutoPropio_SI.Checked, "S", "N"), tbx_AutoPropio_Marca.Text, tbx_AutoPropio_Modelo.Text,
                                                              IIf(rdb_AlgunaPropiedad_SI.Checked, "S", "S"), tbx_AlgunaPropiedad_Ubicacion.Text, dgv_ingresos_mensuales) Then
                'Guardar registro del movimiento en bitácora.
                Cn_Login.fn_Log_Create("GUARDAR DATOS INGRESOS EGRESOS DE VISITA DOMICILIARIA: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
                MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)

            End If

        End If


    End Sub

    Private Sub btn_CancelarIngresosEgresos_Click(sender As Object, e As EventArgs) Handles btn_CancelarIngresosEgresos.Click
        SegundosDesconexion = 0
        BotonesIngresosEgresos(False)
        Tab_VisitaDomiciliaria.SelectedTab = Tab_Visita
    End Sub

    Private Sub rdb_PlanEndeuda_No_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_PlanEndeuda_No.CheckedChanged
        tbx_PlanEndeudaDesc.Enabled = False
        tbx_PlanEndeudaDesc.Text = ""
    End Sub

    Private Sub rdb_PlanEndeuda_Si_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_PlanEndeuda_Si.CheckedChanged
        tbx_PlanEndeudaDesc.Enabled = True
    End Sub

    Private Sub rdb_DeudaAct_No_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_DeudaAct_No.CheckedChanged
        tbx_AsciendeDeuda.Enabled = False
        tbx_AsciendeDeuda.Text = ""
    End Sub

    Private Sub rdb_DeudaAct_Si_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_DeudaAct_Si.CheckedChanged
        tbx_AsciendeDeuda.Enabled = True
    End Sub

    Private Sub tbx_AsciendeDeuda_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_AsciendeDeuda.KeyPress
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub tbx_AsciendeIngreso_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_AsciendeIngreso.KeyPress
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub rdb_AutoPropio_SI_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_AutoPropio_SI.CheckedChanged
        tbx_AutoPropio_Marca.Enabled = True
        tbx_AutoPropio_Modelo.Enabled = True
    End Sub

    Private Sub rdb_AutoPropio_NO_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_AutoPropio_NO.CheckedChanged
        tbx_AutoPropio_Marca.Enabled = False
        tbx_AutoPropio_Marca.Text = ""
        tbx_AutoPropio_Modelo.Enabled = False
        tbx_AutoPropio_Modelo.Text = ""
    End Sub

    Private Sub rdb_AlgunaPropiedad_SI_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_AlgunaPropiedad_SI.CheckedChanged
        tbx_AlgunaPropiedad_Ubicacion.Enabled = True
    End Sub

    Private Sub rdb_AlgunaPropiedad_NO_CheckedChanged(sender As Object, e As EventArgs) Handles rdb_AlgunaPropiedad_NO.CheckedChanged
        tbx_AlgunaPropiedad_Ubicacion.Enabled = False
        tbx_AlgunaPropiedad_Ubicacion.Text = ""
    End Sub

    Private Sub tbx_IngresoDedicadoAhorro_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_IngresoDedicadoAhorro.KeyPress
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub tbx_NoPersonasAportan_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_NoPersonasAportan.KeyPress
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub tbx_NoDependientesEcono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbx_NoDependientesEcono.KeyPress
        Dim numbers As TextBox = sender
        If InStr("1234567890.", e.KeyChar) = 0 And Asc(e.KeyChar) <> 8 Or (e.KeyChar = "." And InStr(numbers.Text, ".") > 0) Then
            e.KeyChar = Chr(0)
            e.Handled = True
        End If
    End Sub

    Private Sub btn_BorrarIngresosEgresos_Click(sender As Object, e As EventArgs) Handles btn_BorrarIngresosEgresos.Click
        SegundosDesconexion = 0
        If fn_VisitaDom_Distribucion_IngresoMensuales_Eliminar(Id_IngresosEgresos) Then
            Cn_Login.fn_Log_Create("SE ELIMINARON DATOS INGRESOS EGRESOS DE VISITA DOMICILIARIA: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
            LimpiarIngresosEgresos()
            Dim dt As New DataTable
            dgv_ingresos_mensuales.DataSource = dt
            IniciarDgvIngresis_Mensuales()
            MsgBox("Se guardó la información correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        Else
            Cn_Login.fn_Log_Create("FALLO O DATOS INEXISTENTES EN INGRESOS EGRESOS DE VISITA DOMICILIARIA: " & lbl_Clave.Text & " - " & lbl_Nombre.Text & " - " & dtp_FechaVisita.Value.ToShortDateString)
            MsgBox("No hay datos para eliminar.", MsgBoxStyle.Exclamation, frm_MENU.Text)
        End If


    End Sub










#End Region

End Class