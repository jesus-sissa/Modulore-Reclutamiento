Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales

Public Class Frm_BuscarCliente
    Public Cliente As Boolean = True
    Public Clave As String
    Public Consulta As Query = Query.Clientes
    Public Id As Integer = 0
    Public Tipo As Char = "" 'E=Empleado; P=Prospecto
    Public Status As Char = "A" 'A=Activo; B=Baja; T=Todos
    Public Cadena As String
    Public APaterno As String
    Public AMaterno As String
    Public Nombres As String
    Public UMF As Integer = 0
    Public CP As Integer = 0
    Public Fecha As Date = Today.Date
    Public Id_Empleado As Integer = 0

    <Flags()> _
    Enum Query As Byte
        Clientes
        Empleados
        CajaBancaria
        EmpleadosyProspectos
        UMF
        EmpleadosTodos
        CursoCapacitacion
        ListaNegra
        ProspectosExistentes
    End Enum

    Private Sub Frm_BuscarCliente_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        lbl_Modo1.Text = "-"
        lbl_Modo.Text = "-"

        Select Case Consulta
            Case Query.Clientes
                lsv_Clientes.Row1 = 70
                lsv_Clientes.Row2 = 20

                If Not fn_BuscarClientes_LlenarLista(lsv_Clientes, Cliente) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los clientes.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Clientes"

            Case Query.Empleados
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70
                lbl_Modo1.Text = "Actualmente el modo de Reingreso de Empleados es: "
                lbl_Modo.Text = If(Modo_ReingresoEmp = 1, "NUEVO NUMERO DE NOMINA", "MISMO NUMERO DE NOMINA")

                If Not fn_BuscarClientes_LlenarListaEmpleados(lsv_Clientes, Status) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados"
                Lbl_Nota.Text = "Doble Click para Seleccionar un Empleado y cerrar la ventana de búsqueda."

            Case Query.CajaBancaria
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_BuscarClientes_LlenarListaCajasBancarias(lsv_Clientes) Then
                    MsgBox("Ha ocurrido un error al intentar cargar las cajas bancarias.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Cajas Bancarias"
                Lbl_Nota.Text = "Doble Click para Seleccionar un Cliente y cerrar la ventana de búsqueda."

            Case Query.EmpleadosyProspectos
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70
                lsv_Clientes.Row3 = 0
                If Not fn_BuscarClientes_LlenarListaEmpleadosyProspectos(lsv_Clientes, Nombres, APaterno, AMaterno) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados y Prospectos"
                Lbl_Nota.Text = "Doble Click para Seleccionar un Empleado o Prospecto y cerrar la ventana de búsqueda."

            Case Query.UMF
                lsv_Clientes.Row1 = 15
                lsv_Clientes.Row2 = 50
                lsv_Clientes.Row3 = 20
                If Not fn_UMF_LlenarLista(lsv_Clientes) Then
                    MsgBox("Ha ocurrido un error al intentar cargar las UMF's.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    For Each Elemento As ListViewItem In lsv_Clientes.Items
                        If CInt(Elemento.SubItems(2).Text) = CP Then
                            Elemento.Selected = True
                            Elemento.EnsureVisible()
                            Exit Sub
                        End If
                    Next
                End If
                Text = "Buscar Unidad Médico Familiar"
                Lbl_Nota.Text = "Doble Click para Seleccionar una Unidad Médico Familiar y cerrar la ventana de búsqueda."

            Case Query.EmpleadosTodos
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 70

                If Not fn_Empleados_LlenarListaEmpleados(lsv_Clientes) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Empleados"
                Lbl_Nota.Text = "Doble Click para Seleccionar un Empleado y cerrar la ventana de búsqueda."

            Case Query.CursoCapacitacion
                lsv_Clientes.Row1 = 20
                lsv_Clientes.Row2 = 35
                lsv_Clientes.Row3 = 35
                lsv_Clientes.Row4 = 0

                If Not fn_CursosRecibidos_LlenarLista(lsv_Clientes, Id_Empleado) Then
                    MsgBox("Ha ocurrido un error al intentar cargar los Cursos tomados del Empleado.", MsgBoxStyle.Critical, frm_MENU.Text)
                ElseIf lsv_Clientes.Items.Count = 0 Then
                    Me.Close()
                    MsgBox("El Empleado no tiene Cursos Internos", MsgBoxStyle.Critical, frm_MENU.Text)
                End If
                Text = "Buscar Cursos"
                Lbl_Nota.Text = "Doble Click para Seleccionar un Curso y cerrar la ventana de búsqueda."

            Case Query.ListaNegra
                Me.Cursor = Cursors.WaitCursor
                Me.Size = New Size(700, 449)
                lsv_Clientes.Row1 = 40
                lsv_Clientes.Row2 = 25
                lsv_Clientes.Row3 = 25
                lsv_Clientes.Row4 = 20

                If Not fn_ListaNegra_Comprobar(lsv_Clientes, Nombres, APaterno, AMaterno) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Coincidencias del Empleado Buscado.", MsgBoxStyle.Critical, frm_MENU.Text)
                ElseIf lsv_Clientes.Items.Count = 0 Then
                    Me.Cursor = Cursors.Default
                    Me.Close()
                    MsgBox("No se encontró ningúna coincidencia para el Empleado en la Lista Negra.", MsgBoxStyle.Information, frm_MENU.Text)
                End If
                Text = "Personas en Lista Negra"
                Lbl_Nota.Text = lsv_Clientes.Items.Count.ToString & " Coincidencias"
                Me.Cursor = Cursors.Default

            Case Query.ProspectosExistentes
                Me.Cursor = Cursors.WaitCursor
                Me.Size = New Size(700, 449)
                lsv_Clientes.Row1 = 40
                lsv_Clientes.Row2 = 25
                lsv_Clientes.Row3 = 25
                lsv_Clientes.Row4 = 20

                If Not fn_EmpleadosP_Comprobar(lsv_Clientes, Nombres, APaterno, AMaterno) Then
                    Me.Cursor = Cursors.Default
                    MsgBox("Ha ocurrido un error al intentar cargar las Coincidencias del Empleado Buscado.", MsgBoxStyle.Critical, frm_MENU.Text)
                ElseIf lsv_Clientes.Items.Count = 0 Then
                    Me.Cursor = Cursors.Default
                    Me.Close()
                    'MsgBox("No se encontró ningúna coincidencia en Prospectos.", MsgBoxStyle.Information, frm_MENU.Text)
                Else
                    tbx_Buscar.Text = ((Nombres & " " & APaterno).Trim & " " & AMaterno).Trim
                    Call Buscar()
                End If
                Text = "Coincidencias en Prospectos"
                Lbl_Nota.Text = lsv_Clientes.Items.Count.ToString & " Coincidencias. Doble Click para Seleccionar un Prospecto y cerrar la ventana de búsqueda."
                Me.Cursor = Cursors.Default
        End Select

        tbx_Buscar.Focus()
    End Sub

    Private Sub lsv_Clientes_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lsv_Clientes.DoubleClick
        If lsv_Clientes.SelectedItems.Count = 0 Then Exit Sub
        Select Case Consulta
            Case Query.Clientes
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.Empleados
                Clave = lsv_Clientes.SelectedItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CajaBancaria
                Clave = lsv_Clientes.SelectedItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.EmpleadosyProspectos
                Clave = lsv_Clientes.SelectedItems(0).Text
                If Clave = "" Then Clave = 0
                Id = lsv_Clientes.SelectedItems(0).Tag
                Tipo = lsv_Clientes.SelectedItems(0).SubItems(2).Text
            Case Query.UMF
                UMF = lsv_Clientes.SelectedItems(0).Text
            Case Query.EmpleadosTodos
                Clave = lsv_Clientes.SelectedItems(0).Text
                Id = lsv_Clientes.SelectedItems(0).Tag
            Case Query.CursoCapacitacion
                Id = lsv_Clientes.SelectedItems(0).Tag
                Fecha = CDate(lsv_Clientes.SelectedItems(0).Text)
                Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                Nombres = lsv_Clientes.SelectedItems(0).SubItems(2).Text
                Cadena = lsv_Clientes.SelectedItems(0).SubItems(3).Text
            Case Query.ProspectosExistentes
                Id = lsv_Clientes.SelectedItems(0).Tag
        End Select

        Me.Close()
    End Sub

    Private Sub lsv_Clientes_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lsv_Clientes.SelectedIndexChanged
        Select Case Consulta
            Case Query.Clientes
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If
            Case Query.Empleados
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If
            Case Query.CajaBancaria
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If
            Case Query.EmpleadosyProspectos
                'If lsv_Clientes.SelectedItems.Count > 0 Then
                '    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                '    Id = lsv_Clientes.SelectedItems(0).Tag
                'End If
            Case Query.UMF
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    UMF = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                End If
            Case Query.EmpleadosTodos
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(0).Text
                    Id = lsv_Clientes.SelectedItems(0).Tag
                End If
            Case Query.CursoCapacitacion
                If lsv_Clientes.SelectedItems.Count > 0 Then
                    Id = lsv_Clientes.SelectedItems(0).Tag
                    Fecha = CDate(lsv_Clientes.SelectedItems(0).Text)
                    Clave = lsv_Clientes.SelectedItems(0).SubItems(1).Text
                    Nombres = lsv_Clientes.SelectedItems(0).SubItems(2).Text
                    Cadena = lsv_Clientes.SelectedItems(0).SubItems(3).Text
                End If
        End Select
    End Sub

    Sub Buscar()
        SegundosDesconexion = 0
        Dim Fila_Inicio As Integer = 0
        If lsv_Clientes.SelectedItems.Count > 0 Then
            Fila_Inicio = lsv_Clientes.SelectedItems(0).Index + 1
        End If
        fn_Buscar_enListView(lsv_Clientes, tbx_Buscar.Text, 0, Fila_Inicio)
    End Sub

    Private Sub tbx_Buscar_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbx_Buscar.KeyPress
        Call Buscar()
    End Sub

    Private Sub tbx_Buscar_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tbx_Buscar.TextChanged
        Call Buscar()
    End Sub

    Private Sub lsv_Clientes_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lsv_Clientes.MouseMove
        'Inicializar la variable de desconexion
        SegundosDesconexion = 0
    End Sub


End Class

