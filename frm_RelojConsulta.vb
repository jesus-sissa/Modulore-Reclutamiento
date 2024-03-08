Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_RelojConsulta

    Private Sub frm_RelojConsulta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Reloj.Visible = False
        cmb_Reloj.Actualizar()
    End Sub

    Sub Botones()
        If tab_ListasEmpleados.TabCount = 0 Then Exit Sub
        Select Case tab_ListasEmpleados.SelectedTab.Name
            Case tab_Registros.Name
                btn_ExportarReg.Enabled = lsv_EmpleadosReg.Items.Count > 0
                btn_ExportarR.Enabled = lsv_EmpleadosR.Items.Count > 0

            Case tab_Templates.Name
                btn_ExportarReg.Enabled = lsv_TemplatesReg.Items.Count > 0
                btn_ExportarR.Enabled = lsv_TemplatesR.Items.Count > 0

        End Select
        btn_ImportarR.Enabled = lsv_EmpleadosR.Items.Count > 0
        btn_ImportarT.Enabled = lsv_TemplatesR.Items.Count > 0
    End Sub

    Sub Limpiar()
        lsv_EmpleadosReg.Items.Clear()
        lsv_EmpleadosR.Items.Clear()
        lsv_TemplatesReg.Items.Clear()
        lsv_TemplatesR.Items.Clear()

        lbl_EmpleadosReg.Text = "Total: 0"
        lbl_EmpleadosR.Text = "Total: 0"
        lbl_TemplatesReg.Text = "Total: 0"
        lbl_TemplatesR.Text = "Total: 0"
    End Sub

    Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Ayuda
        frm.Ayuda = frm_Ayuda.Query.RelojConsulta
        frm.Size = New Size(670, 530)
        frm.Show()
    End Sub

    Private Sub cmb_Reloj_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Reloj.SelectedValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call Botones()
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If cmb_Reloj.SelectedValue = 0 Then
            MsgBox("Debe de seleccionar un Reloj.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Reloj.Focus()
            Exit Sub
        End If

        Dim IP As String = ""
        Dim Version As Integer = 0
        Dim Dt As DataTable = cmb_Reloj.DataSource
        For Each Row As DataRow In Dt.Rows
            If Row("Id_Reloj") = cmb_Reloj.SelectedValue Then
                IP = Row("IP")
                Version = Row("Version")
                Exit For
            End If
        Next

        Call Limpiar()
        lsv_EmpleadosReg.Refresh()
        lsv_EmpleadosR.Refresh()
        lsv_TemplatesReg.Refresh()
        lsv_TemplatesR.Refresh()
        Call Botones()

        'Registros
        If Not fn_Reloj_LlenarLista(cmb_Reloj.SelectedValue, lsv_EmpleadosReg) Then
            MsgBox("Ocurrio un error al llenar la lista de los empleados dados de Alta del Reloj: " & Chr(13) & cmb_Reloj.Text, MsgBoxStyle.Critical, frm_MENU)
        End If

        'Templates
        If Not fn_Reloj_LlenarLista(cmb_Reloj.SelectedValue, lsv_TemplatesReg) Then
            MsgBox("Ocurrio un error al llenar la lista de las huellas dadas de Alta del Reloj: " & Chr(13) & cmb_Reloj.Text, MsgBoxStyle.Critical, frm_MENU)
        End If

        Dim Desconectar As Boolean = False
        Try
            'Conectarse al Reloj
            If Reloj.Connect_Net(IP, 4370) Then
                Desconectar = True
                If Reloj.ReadAllUserID(1) Then
                    If Not Reloj.ReadAllTemplate(1) Then
                        MsgBox("No se pudo leer la información del Reloj.", MsgBoxStyle.Critical, frm_MENU.Text)
                        Reloj.Disconnect()
                        Exit Sub
                    End If
                Else
                    MsgBox("No se pudo leer la información del Reloj.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Reloj.Disconnect()
                    Exit Sub
                End If
            Else
                MsgBox("No se pudo Conectar al Reloj Seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim Nombre As String = ""
            Dim Texto1 As String = ""
            Dim Clave As String = 0
            Dim Int1 As Integer = 0
            Dim En As Boolean = False
            Dim Elem As ListViewItem

            Select Case Version
                Case 9
                    While Reloj.GetAllUserInfo(1, Clave, Nombre, Texto1, Int1, En)
                        'Agregar a la lista de Empleados
                        Elem = lsv_EmpleadosR.Items.Add(Clave) 'Clave
                        Elem.SubItems.Add(Nombre) 'Nombre

                        'Agregar también a la lista de Templates
                        For I As Integer = 0 To 9
                            If Not Reloj.GetUserTmpStr(1, Clave, I, Texto1, Int1) Then Continue For

                            Elem = lsv_TemplatesR.Items.Add(Clave)
                            Elem.SubItems.Add(Nombre)
                            Select Case I 'El número del Dedo
                                Case 0
                                    Elem.SubItems.Add("Meñique Izq.")

                                Case 1
                                    Elem.SubItems.Add("Anular Izq.")

                                Case 2
                                    Elem.SubItems.Add("Medio Izq.")

                                Case 3
                                    Elem.SubItems.Add("Indice Izq.")

                                Case 4
                                    Elem.SubItems.Add("Pulgar Izq.")

                                Case 5
                                    Elem.SubItems.Add("Pulgar Der.")

                                Case 6
                                    Elem.SubItems.Add("Indice Der.")

                                Case 7
                                    Elem.SubItems.Add("Medio Der.")

                                Case 8
                                    Elem.SubItems.Add("Anular Der.")

                                Case 9
                                    Elem.SubItems.Add("Meñique Der.")

                            End Select
                            Elem.Tag = Texto1 'El Template del Dedo
                        Next

                        Clave = 0
                        Nombre = ""
                        Texto1 = ""
                        Int1 = 0
                        En = False
                    End While

                Case 10
                    While Reloj.SSR_GetAllUserInfo(1, Clave, Nombre, Texto1, Int1, En)
                        'Agregar a la lista de Empleados
                        Elem = lsv_EmpleadosR.Items.Add(Clave) 'Clave
                        Elem.SubItems.Add(Nombre) 'Nombre

                        'Agregar tambien a la lista de Templates
                        For I As Integer = 0 To 9
                            If Not Reloj.SSR_GetUserTmpStr(1, Clave, I, Texto1, Int1) Then Continue For

                            Elem = lsv_TemplatesR.Items.Add(Clave)
                            Elem.SubItems.Add(Nombre)
                            Select Case I 'El número del Dedo
                                Case 0
                                    Elem.SubItems.Add("Meñique Izq.")

                                Case 1
                                    Elem.SubItems.Add("Anular Izq.")

                                Case 2
                                    Elem.SubItems.Add("Medio Izq.")

                                Case 3
                                    Elem.SubItems.Add("Indice Izq.")

                                Case 4
                                    Elem.SubItems.Add("Pulgar Izq.")

                                Case 5
                                    Elem.SubItems.Add("Pulgar Der.")

                                Case 6
                                    Elem.SubItems.Add("Indice Der.")

                                Case 7
                                    Elem.SubItems.Add("Medio Der.")

                                Case 8
                                    Elem.SubItems.Add("Anular Der.")

                                Case 9
                                    Elem.SubItems.Add("Meñique Der.")

                            End Select
                            Elem.Tag = Texto1 'El Template del Dedo
                        Next

                        Clave = 0
                        Nombre = ""
                        Texto1 = ""
                        Int1 = 0
                        En = False
                    End While

            End Select

            'Desconectarse al Reloj
            Reloj.Disconnect()
        Catch
            If Desconectar Then Reloj.Disconnect()
            MsgBox("Ocurrio un error al tratar de mostrar los Usuarios Registrados en el Reloj: " & cmb_Reloj.Text, MsgBoxStyle.Critical, frm_MENU.Text)
        End Try

        lbl_EmpleadosReg.Text = "Total: " & lsv_EmpleadosReg.Items.Count
        lbl_EmpleadosR.Text = "Total: " & lsv_EmpleadosR.Items.Count
        lbl_TemplatesReg.Text = "Total: " & lsv_TemplatesReg.Items.Count
        lbl_TemplatesR.Text = "Total: " & lsv_TemplatesR.Items.Count
        Call Botones()
    End Sub

    Private Sub btn_ImportarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImportarR.Click
        SegundosDesconexion = 0


    End Sub

    Private Sub btn_ImportarT_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ImportarT.Click
        SegundosDesconexion = 0


    End Sub

    Private Sub btn_ExportarReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarReg.Click
        SegundosDesconexion = 0

        Select Case tab_ListasEmpleados.SelectedTab.Name
            Case tab_Registros.Name
                FuncionesGlobales.fn_Exportar_Excel(lsv_EmpleadosReg, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)

            Case tab_Templates.Name
                FuncionesGlobales.fn_Exportar_Excel(lsv_TemplatesReg, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)

        End Select
    End Sub

    Private Sub btn_ExportarR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_ExportarR.Click
        SegundosDesconexion = 0

        Select Case tab_ListasEmpleados.SelectedTab.Name
            Case tab_Registros.Name
                FuncionesGlobales.fn_Exportar_Excel(lsv_EmpleadosR, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)

            Case tab_Templates.Name
                FuncionesGlobales.fn_Exportar_Excel(lsv_TemplatesR, 2, Me.Text, 0, 0, frm_MENU.prg_Barra)

        End Select
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class