Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales

Public Class frm_Graficos

    Private Sub frm_Graficos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        lsv_Datos.Columns.Add("Clave")
        lsv_Datos.Columns.Add("Nombre")
        lsv_Datos.Columns.Add("Departamento")
        lsv_Datos.Columns.Add("Puesto")
        lsv_Datos.Columns.Add("Status")
        lsv_Datos.Columns.Add("FechaIngreso")

        cmb_TipoConsulta.AgregarItem(1, "RENUNCIAS")
        cmb_TipoConsulta.AgregarItem(2, "RECLUTADOS")
        cmb_TipoConsulta.AgregarItem(3, "CONTRATADOS")
        cmb_TipoConsulta.AgregarItem(5, "ENTREVISTAS")
        cmb_TipoConsulta.AgregarItem(4, "ALTAS Y BAJAS")
        'cmb_TipoConsulta.AgregarItem(5, "Rotación")
        cmb_Especifique.Items.Add("Seleccione...")
        cmb_Especifique.SelectedIndex = 0
        cmb_Departamento.Actualizar()
        cmb_Puesto.Actualizar()
        'dtp_Desde.Value = Today.Date
        'dtp_Hasta.Value = Today.Date      

        dtp_Desde.Value = Today.Date
        dtp_Hasta.Value = Today.Date
    End Sub

#Region "Sub"

    Private Function Validar() As Boolean
        SegundosDesconexion = 0
        If cmb_TipoConsulta.SelectedValue = 0 Then
            MsgBox("Seleccione el Tipo de Consulta.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_TipoConsulta.Focus()
            Return False
        End If

        If cmb_Especifique.SelectedIndex = 0 Then
            MsgBox("Seleccione la Especificación.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Especifique.Focus()
            Return False
        End If

        If dtp_Desde.Value.Date > dtp_Hasta.Value.Date Then
            MsgBox("La Fecha Inicial no puede ser mayor que la Fecha Final.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Return False
        End If

        If DateDiff(DateInterval.Day, dtp_Desde.Value.Date, dtp_Hasta.Value.Date) > 365 Then
            MsgBox("Sólo se permiten Consultas no Mayores a un Año.", MsgBoxStyle.Critical, frm_MENU.Text)
            dtp_Desde.Focus()
            Return False
        End If

        If Not chk_DepTodos.Checked AndAlso cmb_Departamento.SelectedValue = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Seleccione un Departamento o Marque la Casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Departamento.Focus()
            Return False
        End If

        If Not chk_Puesto.Checked AndAlso cmb_Puesto.SelectedValue = 0 Then
            Me.Cursor = Cursors.Default
            MsgBox("Seleccione un Puesto o Marque la Casilla de «Todos».", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Puesto.Focus()
            Return False
        End If

        Return True
    End Function

    Sub Botones()
        SegundosDesconexion = 0
        btn_ExportarDatos.Enabled = lsv_Datos.Items.Count > 0
        btn_Graficar.Enabled = lsv_Datos.Items.Count > 0
        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Datos.Items.Count)
    End Sub

#End Region

    Private Sub cmb_TipoConsulta_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_TipoConsulta.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        Call Botones()
        If cmb_Especifique.Items.Count > 1 Then
            For Items As Integer = 1 To cmb_Especifique.Items.Count - 1
                cmb_Especifique.Items.RemoveAt(1)
            Next
        End If
        cmb_Especifique.Enabled = True
        cmb_Especifique.SelectedIndex = 0
        Select Case cmb_TipoConsulta.SelectedValue
            Case 1 'Renuncias
                cmb_Especifique.Items.Add("POR MOTIVOS")
                cmb_Especifique.Items.Add("POR DEPARTAMENTOS")
            Case 2 'Reclutados
                cmb_Especifique.Items.Add("POR MODO DE CONTACTOS")
                cmb_Especifique.Items.Add("POR PUESTOS")
            Case 3 'Contratados
                cmb_Especifique.Items.Add("POR MODOS DE CONTACTO")
                cmb_Especifique.Items.Add("POR DEPARTAMENTOS")
            Case 4 'Altas y Bajas
                cmb_Especifique.Items.Add("POR MES")
                cmb_Especifique.Items.Add("POR DEPARTAMENTOS")
            Case 5 'Entrevistas
                cmb_Especifique.Items.Add("POR RECLUTADOR")
                cmb_Especifique.Items.Add("APTOS Y NO APTOS")
        End Select
    End Sub

    Private Sub cmb_Especifique_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Especifique.SelectedIndexChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        Call Botones()
    End Sub

    Private Sub dtp_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp_Desde.ValueChanged, dtp_Hasta.ValueChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        Call Botones()
    End Sub

    Private Sub cmb_DepartamentoPuesto_SelectedValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmb_Departamento.SelectedValueChanged, cmb_Puesto.SelectedValueChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        Call Botones()
    End Sub

    Private Sub chk_DepTodos_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_DepTodos.CheckedChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        cmb_Departamento.Enabled = Not chk_DepTodos.Checked
        cmb_Departamento.SelectedValue = 0
        Call Botones()
    End Sub

    Private Sub chk_Puesto_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_Puesto.CheckedChanged
        SegundosDesconexion = 0

        lsv_Datos.Items.Clear()
        cmb_Puesto.Enabled = Not chk_Puesto.Checked
        cmb_Puesto.SelectedValue = 0
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If Validar() = False Then Exit Sub
        lsv_Datos.Items.Clear()
        Dim ConsultaCorrecta As Boolean = False
        Select Case cmb_TipoConsulta.SelectedValue
            Case 1 'Renuncias
                ConsultaCorrecta = fn_EmpleadosBaja_LlenarLista(lsv_Datos, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                fn_Columna(lsv_Datos, 10, 15, 15, 15, 10, 12, 10, 10, 0, 0)
            Case 2 'Reclutados
                ConsultaCorrecta = fn_Reclutados_LlenarLista(lsv_Datos, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                fn_Columna(lsv_Datos, 10, 15, 13, 13, 10, 10, 12, 12, 0, 0)
            Case 3 'Contratados
                ConsultaCorrecta = fn_Contratados_LlenarLista(lsv_Datos, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                fn_Columna(lsv_Datos, 10, 15, 10, 10, 10, 10, 10, 10, 10, 0)
            Case 4 'Altas y Bajas
                ConsultaCorrecta = fn_IndicadorAltaBajaEmpleado_LlenarLista(lsv_Datos, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                fn_Columna(lsv_Datos, 10, 20, 15, 15, 12, 12, 12, 12, 12, 0)
            Case 5 'Entrevistas
                ConsultaCorrecta = fn_Entrevistas_LlenarLista(lsv_Datos, cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, dtp_Desde.Value.Date, dtp_Hasta.Value.Date)
                fn_Columna(lsv_Datos, 10, 15, 10, 15, 12, 12, 10, 10, 0, 0)
        End Select
        If Not ConsultaCorrecta Then
            MsgBox("Ocurrio un error al intentar llenar la lista.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        Call Botones()

        FuncionesGlobales.fn_NumRegistros(Lbl_Numero, lsv_Datos.Items.Count)

    End Sub

#Region "KEYPRESS"

    Private Sub dtp_Desde_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Desde.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then dtp_Hasta.Focus()
    End Sub

    Private Sub dtp_Hasta_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles dtp_Hasta.KeyPress
        If Asc(e.KeyChar) = Keys.Enter Then
            If cmb_Departamento.Enabled Then
                cmb_Departamento.Focus()
            Else
                btn_Mostrar.Focus()
            End If
        End If
    End Sub

#End Region

    Private Sub btn_ExportarDatos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarDatos.Click
        SegundosDesconexion = 0

        FuncionesGlobales.fn_Exportar_Excel(lsv_Datos, 2, cmb_TipoConsulta.Text, 0, 0, frm_MENU.prg_Barra)
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub btn_Graficar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Graficar.Click
        SegundosDesconexion = 0

        Dim frm As New frm_VisorGraficas
        frm.lsv = lsv_Datos
        frm.tbx_Titulo.Text = cmb_TipoConsulta.Text.ToUpper & " - " & cmb_Especifique.Text.ToUpper
        Select Case cmb_TipoConsulta.SelectedValue
            Case 1 'RENUNCIAS
                If cmb_Especifique.SelectedIndex = 1 Then
                    'Por Motivo
                    frm.Tipo = frm_VisorGraficas.Query.RenunciaMotivo
                    frm.tbx_Serie1.Text = "MOTIVOS"
                Else
                    'Por Departamento
                    frm.Tipo = frm_VisorGraficas.Query.RenunciaDepartamento
                    frm.tbx_Serie1.Text = "DEPARTAMENTOS"
                End If

            Case 2 'RECLUTADOS
                If cmb_Especifique.SelectedIndex = 1 Then
                    'Por Modo de Contacto
                    frm.Tipo = frm_VisorGraficas.Query.ReclutadosModContacto
                    frm.tbx_Serie1.Text = "MODO CONTACTO"
                Else
                    'Por Puesto
                    frm.Tipo = frm_VisorGraficas.Query.ReclutadosPuesto
                    frm.tbx_Serie1.Text = "PUESTOS"
                End If

            Case 3 'CONTRATADOS
                If cmb_Especifique.SelectedIndex = 1 Then
                    'Por Modo de Contacto
                    frm.Tipo = frm_VisorGraficas.Query.ContratadoModContacto
                    frm.tbx_Serie1.Text = "MODO CONTACTO"
                Else
                    'Por Departamento
                    frm.Tipo = frm_VisorGraficas.Query.ContratadoDep
                    frm.tbx_Serie1.Text = "DEPARTAMENTOS"
                End If

            Case 4 'ALTAS Y BAJAS
                If cmb_Especifique.SelectedIndex = 1 Then
                    'Por Mes
                    frm.Tipo = frm_VisorGraficas.Query.AltasBajasMes
                    frm.Desde = dtp_Desde.Value.Date
                    frm.Hasta = dtp_Hasta.Value.Date
                    frm.tbx_Serie1.Text = "ALTAS"
                    frm.tbx_Serie2.Text = "BAJAS"
                Else
                    'Por Departamento
                    frm.Tipo = frm_VisorGraficas.Query.AltasBajasDep
                    frm.Desde = dtp_Desde.Value.Date
                    frm.Hasta = dtp_Hasta.Value.Date
                    frm.tbx_Serie1.Text = "ALTAS"
                    frm.tbx_Serie2.Text = "BAJAS"
                End If

            Case 5 'ENTREVISTAS
                If cmb_Especifique.SelectedIndex = 1 Then
                    'Por Entrevistador
                    frm.Tipo = frm_VisorGraficas.Query.EntrevReclutador
                    frm.tbx_Serie1.Text = "RECLUTADOR"
                Else
                    'Aptos y No Aptos
                    frm.Tipo = frm_VisorGraficas.Query.EntrevAptoNoApto
                    frm.tbx_Serie1.Text = "APTOS"
                End If
        End Select

        frm.ShowDialog()
    End Sub
End Class