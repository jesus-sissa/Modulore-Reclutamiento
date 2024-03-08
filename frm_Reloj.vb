Imports Modulo_Reclutamiento.Cn_Reclutamiento

Public Class frm_Reloj

    Private Dt_HuellasT As DataTable
    Private Dt_RelojHT As DataTable
    Private IP As String = ""
    Private Version As Integer = 0

    Private Sub frm_Reloj_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        cmb_Puesto.AgregaParametro("@Id_Departamento", 0, 1)
        cmb_Puesto.AgregaParametro("@Status", "A", 0)
        cmb_Departamento.Actualizar()
        cmb_Reloj.AgregaParametro("@Status", "A", 0)
        cmb_Reloj.Actualizar()
        'Solo Prenominas podra eliminar Usuarios de Reloj
        If btn_Eliminar.Visible Then lsv_EmpleadosReloj.CheckBoxes = True
    End Sub

    Sub Limpiar(Optional ByVal Solo_Huellas As Boolean = False)
        If Not Solo_Huellas Then
            lsv_Empleados.Items.Clear()
            btn_Agregar.Enabled = False
        End If
        lbl_0.Image = My.Resources.Delete
        lbl_1.Image = My.Resources.Delete
        lbl_2.Image = My.Resources.Delete
        lbl_3.Image = My.Resources.Delete
        lbl_4.Image = My.Resources.Delete
        lbl_5.Image = My.Resources.Delete
        lbl_6.Image = My.Resources.Delete
        lbl_7.Image = My.Resources.Delete
        lbl_8.Image = My.Resources.Delete
        lbl_9.Image = My.Resources.Delete
    End Sub

    Sub LimpiarSeleccion()
        lsv_Empleados.SelectedItems.Clear()
        lsv_EmpleadosReloj.SelectedItems.Clear()
    End Sub

    Private Sub cmb_Departamento_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Departamento.SelectedValueChanged
        SegundosDesconexion = 0

        If cmb_Departamento.Items.Count = 0 Then Exit Sub

        Call Limpiar()
        Call LimpiarSeleccion()
        If cmb_Departamento.SelectedValue = 0 Then
            cmb_Puesto.ActualizaValorParametro("@Id_Departamento", -1)
        Else
            cmb_Puesto.ActualizaValorParametro("@Id_Departamento", cmb_Departamento.SelectedValue)
        End If
        cmb_Puesto.Actualizar()
    End Sub

    Private Sub cmb_Puesto_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Puesto.SelectedValueChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call LimpiarSeleccion()
    End Sub

    Private Sub chk_Departamento_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Departamento.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call LimpiarSeleccion()
        cmb_Departamento.SelectedValue = 0
        cmb_Departamento.Enabled = Not chk_Departamento.Checked
    End Sub

    Private Sub chk_Puesto_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles chk_Puesto.CheckedChanged
        SegundosDesconexion = 0

        Call Limpiar()
        Call LimpiarSeleccion()
        cmb_Puesto.SelectedValue = 0
        cmb_Puesto.Enabled = Not chk_Puesto.Checked
    End Sub

    Private Sub btn_Mostrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Mostrar.Click
        SegundosDesconexion = 0

        If Not chk_Departamento.Checked AndAlso cmb_Departamento.SelectedValue = 0 Then
            MsgBox("Seleccione un Departamento.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Departamento.Focus()
            Exit Sub
        End If

        If Not chk_Puesto.Checked AndAlso cmb_Puesto.SelectedValue = 0 Then
            MsgBox("Seleccione un Puesto.", MsgBoxStyle.Critical, frm_MENU.Text)
            cmb_Puesto.Focus()
            Exit Sub
        End If

        'Aqui se llena la lista
        Dt_HuellasT = fn_RelojEmpleados_LlenarLista(cmb_Departamento.SelectedValue, cmb_Puesto.SelectedValue, 0, lsv_Empleados)

        If Dt_HuellasT Is Nothing Then
            Call Limpiar()
            MsgBox("Ocurrió un error al intentar llenar la lista de Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        ElseIf Dt_HuellasT.Rows.Count = 0 Then
            Call Limpiar()
            MsgBox("No existen Empleados con Huellas Capturadas para Agregar.", MsgBoxStyle.Critical, frm_MENU.Text)
        Else
            Call Limpiar(True)
        End If
        Call LimpiarSeleccion()
    End Sub

    Private Sub lsv_Empleados_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Empleados.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Limpiar(True)
        If lsv_Empleados.SelectedItems.Count = 0 Then Exit Sub

        lsv_EmpleadosReloj.SelectedItems.Clear()
        'Leer Huellas -> Template
        Dim dr As DataRow = fn_Empleados_LeerHuellasT(lsv_Empleados.SelectedItems(0).Tag, 0)
        If dr IsNot Nothing Then
            'Cuando se tenga guardado la nueva versión se pondrá también en el If ' OrElse dr("Once") <> "" '
            If dr("Uno") <> "" OrElse dr("Once") <> "" Then lbl_0.Image = My.Resources.HoraSi
            If dr("Dos") <> "" OrElse dr("Doce") <> "" Then lbl_1.Image = My.Resources.HoraSi
            If dr("Tres") <> "" OrElse dr("Trece") <> "" Then lbl_2.Image = My.Resources.HoraSi
            If dr("Cuatro") <> "" OrElse dr("Catorce") <> "" Then lbl_3.Image = My.Resources.HoraSi
            If dr("Cinco") <> "" OrElse dr("Quince") <> "" Then lbl_4.Image = My.Resources.HoraSi
            If dr("Seis") <> "" OrElse dr("Dieciseis") <> "" Then lbl_5.Image = My.Resources.HoraSi
            If dr("Siete") <> "" OrElse dr("Diecisiete") <> "" Then lbl_6.Image = My.Resources.HoraSi
            If dr("Ocho") <> "" OrElse dr("Dieciocho") <> "" Then lbl_7.Image = My.Resources.HoraSi
            If dr("Nueve") <> "" OrElse dr("Diecinueve") <> "" Then lbl_8.Image = My.Resources.HoraSi
            If dr("Diez") <> "" OrElse dr("Veinte") <> "" Then lbl_9.Image = My.Resources.HoraSi
        End If
    End Sub

    Private Sub lsv_Empleados_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_Empleados.ItemChecked
        SegundosDesconexion = 0

        btn_Agregar.Enabled = lsv_Empleados.CheckedItems.Count > 0 AndAlso cmb_Reloj.SelectedValue <> 0
    End Sub

    Private Sub cmb_Reloj_SelectedValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmb_Reloj.SelectedValueChanged
        SegundosDesconexion = 0

        IP = ""
        Version = 0
        lbl_Total.Text = "Total: 0"
        lsv_EmpleadosReloj.Items.Clear()
        Call LimpiarSeleccion()

        btn_Agregar.Enabled = lsv_Empleados.CheckedItems.Count > 0 AndAlso cmb_Reloj.SelectedValue <> 0
        If cmb_Reloj.SelectedValue = 0 Then Exit Sub

        Dim Dt As DataTable = cmb_Reloj.DataSource
        For Each Row As DataRow In Dt.Rows
            If Row("Id_Reloj") = cmb_Reloj.SelectedValue Then
                IP = Row("IP")
                Version = Row("Version")
                Exit For
            End If
        Next

        If Not fn_Reloj_LlenarLista(cmb_Reloj.SelectedValue, lsv_EmpleadosReloj) Then
            MsgBox("Ocurrio un error al llenar la lista de los empleados dados de Alta del Reloj: " & Chr(13) & cmb_Reloj.Text, MsgBoxStyle.Critical, frm_MENU)
        End If

        Dt_RelojHT = fn_EmpleadosXReloj_Agregados(cmb_Reloj.SelectedValue)
        lbl_Total.Text = "Total: " & lsv_EmpleadosReloj.Items.Count
    End Sub

    Private Sub lsv_EmpleadosReloj_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_EmpleadosReloj.SelectedIndexChanged
        SegundosDesconexion = 0

        Call Limpiar(True)
        If lsv_EmpleadosReloj.SelectedItems.Count = 0 Then Exit Sub

        lsv_Empleados.SelectedItems.Clear()
        For Each Row As DataRow In Dt_RelojHT.Rows
            If Row("Id_EmpleadoReloj") = lsv_EmpleadosReloj.SelectedItems(0).Tag Then
                If Row("Uno") <> "N" Then lbl_0.Image = My.Resources.HoraSi
                If Row("Dos") <> "N" Then lbl_1.Image = My.Resources.HoraSi
                If Row("Tres") <> "N" Then lbl_2.Image = My.Resources.HoraSi
                If Row("Cuatro") <> "N" Then lbl_3.Image = My.Resources.HoraSi
                If Row("Cinco") <> "N" Then lbl_4.Image = My.Resources.HoraSi
                If Row("Seis") <> "N" Then lbl_5.Image = My.Resources.HoraSi
                If Row("Siete") <> "N" Then lbl_6.Image = My.Resources.HoraSi
                If Row("Ocho") <> "N" Then lbl_7.Image = My.Resources.HoraSi
                If Row("Nueve") <> "N" Then lbl_8.Image = My.Resources.HoraSi
                If Row("Diez") <> "N" Then lbl_9.Image = My.Resources.HoraSi
            End If
        Next
    End Sub

    Private Sub lsv_EmpleadosReloj_ItemChecked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ItemCheckedEventArgs) Handles lsv_EmpleadosReloj.ItemChecked
        SegundosDesconexion = 0

        btn_Eliminar.Enabled = lsv_EmpleadosReloj.CheckedItems.Count > 0
    End Sub

    Private Sub btn_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Agregar.Click
        SegundosDesconexion = 0

        Dim Desconectar As Boolean = False
        Try
            'Conectarse al Reloj
            If Reloj.Connect_Net(IP, 4370) Then
                Desconectar = True
            Else
                MsgBox("No se pudo Conectar al Reloj Seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            'Revisar si ya existe el usuario sino crearlo
            Dim NombreLeido As String
            Dim Pss As String
            Dim Priv As Integer
            Dim Enroll As Boolean

            For Each Item As ListViewItem In lsv_Empleados.CheckedItems
                NombreLeido = ""
                Pss = ""
                Enroll = False

                Select Case Version
                    Case 9
                        If Reloj.GetUserInfo(1, CInt(Item.Text), NombreLeido, Pss, Priv, Enroll) Then
                            'Cuando existe se elimina el registro para agregar el nuevo con todas sus huellas
                            'Hasta 10 significa que también se eliminará el password
                            For I As Integer = 0 To 9
                                Reloj.DeleteEnrollData(1, CInt(Item.Text), 1, I)
                            Next

                            Reloj.SetUserInfo(1, CInt(Item.Text), Item.SubItems(1).Text, Pss, Priv, Enroll)

                            For Each Row As DataRow In Dt_HuellasT.Rows
                                If CInt(Row("Id_Empleado")) <> CInt(Item.Text) Then Continue For

                                If Row("Uno") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 0, Row("Uno"))
                                If Row("Dos") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 1, Row("Dos"))
                                If Row("Tres") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 2, Row("Tres"))
                                If Row("Cuatro") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 3, Row("Cuatro"))
                                If Row("Cinco") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 4, Row("Cinco"))
                                If Row("Seis") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 5, Row("Seis"))
                                If Row("Siete") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 6, Row("Siete"))
                                If Row("Ocho") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 7, Row("Ocho"))
                                If Row("Nueve") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 8, Row("Nueve"))
                                If Row("Diez") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 9, Row("Diez"))

                                Item.ForeColor = Color.Green 'Se creo el usuario y además se agregaron las huellas
                                Exit For
                            Next

                        Else
                            'Cuando no existe crear el registro con sus datos y agregarle todas sus huellas
                            If Reloj.SetUserInfo(1, CInt(Item.Text), Item.SubItems(1).Text, "", 0, True) Then
                                For Each Row As DataRow In Dt_HuellasT.Rows
                                    If CInt(Row("Id_Empleado")) <> CInt(Item.Tag) Then Continue For

                                    If Row("Uno") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 0, Row("Uno"))
                                    If Row("Dos") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 1, Row("Dos"))
                                    If Row("Tres") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 2, Row("Tres"))
                                    If Row("Cuatro") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 3, Row("Cuatro"))
                                    If Row("Cinco") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 4, Row("Cinco"))
                                    If Row("Seis") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 5, Row("Seis"))
                                    If Row("Siete") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 6, Row("Siete"))
                                    If Row("Ocho") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 7, Row("Ocho"))
                                    If Row("Nueve") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 8, Row("Nueve"))
                                    If Row("Diez") <> "" Then Reloj.SetUserTmpStr(1, CInt(Item.Text), 9, Row("Diez"))

                                    Item.ForeColor = Color.Green 'Se creo el usuario y además se agregaron las huellas
                                    Exit For
                                Next
                            Else
                                Item.ForeColor = Color.Red
                            End If
                        End If

                    Case 10
                        If Reloj.SSR_GetUserInfo(1, CInt(Item.Text), NombreLeido, Pss, Priv, Enroll) Then
                            'Cuando existe se elimina el registro para agregar el nuevo con todas sus huellas
                            For I As Integer = 0 To 9
                                Reloj.SSR_DeleteEnrollData(1, CInt(Item.Text), I)
                            Next

                            Reloj.SSR_SetUserInfo(1, CInt(Item.Text), Item.SubItems(1).Text, Pss, Priv, Enroll)

                            Dim n As String = ""
                            Dim s As String = ""
                            Dim z As Integer = 0
                            For Each Row As DataRow In Dt_HuellasT.Rows
                                If CInt(Row("Id_Empleado")) <> CInt(Item.Tag) Then Continue For

                                Try
                                    n = ""
                                    s = ""
                                    z = Row("Diecisiete").ToString.Length
                                    Reloj.FPTempConvertNewStr(Row("Diecisiete"), n, z)
                                    Reloj.FPTempConvertStr(Row("Diecisiete"), s, z)
                                Catch ex As Exception
                                End Try

                                If Row("Once") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 0, Row("Once"))
                                If Row("Doce") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 1, Row("Doce"))
                                If Row("Trece") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 2, Row("Trece"))
                                If Row("Catorce") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 3, Row("Catorce"))
                                If Row("Quince") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 4, Row("Quince"))
                                If Row("Dieciseis") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 5, Row("Dieciseis"))
                                If Row("Diecisiete") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 6, Row("Diecisiete"))
                                If Row("Dieciocho") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 7, Row("Dieciocho"))
                                If Row("Diecinueve") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 8, Row("Diecinueve"))
                                If Row("Veinte") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 9, Row("Veinte"))

                                Item.ForeColor = Color.Green 'Se creo el usuario y además se agregaron las huellas
                                Exit For
                            Next
                        Else
                            'Cuando no existe crear el registro con sus datos y agregarle todas sus huellas
                            If Reloj.SSR_SetUserInfo(1, CInt(Item.Text), Item.SubItems(1).Text, "", 0, True) Then
                                For Each Row As DataRow In Dt_HuellasT.Rows
                                    If CInt(Row("Id_Empleado")) <> CInt(Item.Tag) Then Continue For

                                    Dim n As String = ""
                                    Dim s As String = ""
                                    Dim z As Integer = 0
                                    Reloj.FPTempConvertNewStr(Row("Diecisiete"), n, z)
                                    Reloj.FPTempConvertStr(Row("Diecisiete"), s, z)

                                    If Row("Once") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 0, Row("Once"))
                                    If Row("Doce") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 1, Row("Doce"))
                                    If Row("Trece") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 2, Row("Trece"))
                                    If Row("Catorce") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 3, Row("Catorce"))
                                    If Row("Quince") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 4, Row("Quince"))
                                    If Row("Dieciseis") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 5, Row("Dieciseis"))
                                    If Row("Diecisiete") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 6, Row("Diecisiete"))
                                    If Row("Dieciocho") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 7, Row("Dieciocho"))
                                    If Row("Diecinueve") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 8, Row("Diecinueve"))
                                    If Row("Veinte") <> "" Then Reloj.SSR_SetUserTmpStr(1, CInt(Item.Text), 9, Row("Veinte"))

                                    Item.ForeColor = Color.Green 'Se creo el usuario y además se agregaron las huellas
                                    Exit For
                                Next
                            Else
                                Item.ForeColor = Color.Red
                            End If
                        End If
                End Select
            Next

            'Desconectarse al Reloj
            Reloj.Disconnect()
            Desconectar = False

            If fn_EmpleadosXReloj_Agregar(lsv_Empleados, cmb_Reloj.SelectedValue, Dt_HuellasT) Then
                'Volver a llenar la lista de reloj actualizada
                Call cmb_Reloj_SelectedValueChanged(cmb_Reloj, New System.EventArgs)
                MsgBox("Se agregaron los Empleados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ocurrio un error al Agregar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Catch
            If Desconectar Then Reloj.Disconnect() : Desconectar = False
            MsgBox("Ocurrio un error al intentar Cargar la Información al Reloj.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_Eliminar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Eliminar.Click
        SegundosDesconexion = 0

        'Sólo prenóminas podrá eliminar empleados en el reloj como en BD
        Dim Desconectar As Boolean = False
        Try
            'Conectarse al Reloj
            If Reloj.Connect_Net(IP, 4370) Then
                Desconectar = True
            Else
                MsgBox("No se pudo Conectar al Reloj Seleccionado.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If

            Dim Todos As Integer = 0
            Dim Dt_NoEliminados As New DataTable
            Dt_NoEliminados.Columns.Add("Id_EmpleadoReloj")
            Dt_NoEliminados.Columns.Add("Clave")
            Dt_NoEliminados.Columns.Add("Nombre")
            Dt_NoEliminados.Columns.Add("Departamento")
            Dt_NoEliminados.Columns.Add("Puesto")

            For Each Item As ListViewItem In lsv_EmpleadosReloj.CheckedItems
                'Para eliminar un usuario completamente hay que eliminar todas sus huellas capturadas
                For I As Integer = 0 To 9
                    Select Case Version
                        Case 9
                            If Reloj.DeleteEnrollData(1, CInt(Item.Text), 1, I) Then Todos += 1

                        Case 10
                            If Reloj.SSR_DeleteEnrollData(1, CInt(Item.Text), I) Then Todos += 1

                    End Select
                Next
                If Todos <> 9 Then Dt_NoEliminados.Rows.Add(Item.Tag, Item.Text, Item.SubItems(1).Text, Item.SubItems(2).Text, Item.SubItems(3).Text)
            Next

            'Desconectarse al Reloj
            Reloj.Disconnect()
            Desconectar = False

            If fn_EmpleadosXReloj_Eliminar(lsv_EmpleadosReloj, Dt_NoEliminados) Then
                Call cmb_Reloj_SelectedValueChanged(cmb_Reloj, New System.EventArgs)
                MsgBox("Se eliminaron los Empleados correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
            Else
                MsgBox("Ocurrio un error al Eliminar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
            End If
        Catch
            If Desconectar Then Reloj.Disconnect() : Desconectar = False
            MsgBox("Ocurrio un error al intentar Cargar la Información al Reloj.", MsgBoxStyle.Critical, frm_MENU.Text)
        End Try
    End Sub

    Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        SegundosDesconexion = 0

        Dim frm As New frm_Ayuda
        frm.Ayuda = frm_Ayuda.Query.Reloj
        frm.Size = New Size(670, 530)
        frm.Show()
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class