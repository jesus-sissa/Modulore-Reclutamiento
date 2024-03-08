Imports System.IO
Public Class frm_BolsaDeTrabajo
    Dim Id_Empleo As Integer = 0
    Dim Clave_SucursalO As String = ""
    Dim Cnx_Sucursal As String = ""
    Private Sub frm_BolsaDeTrabajo_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If Cnx_Central = "" Then
            MsgBox("No se han definido los parámetros de conexión con la Base de Datos Central de SIAC. Si no captura estos parámetros no podrá tener acceso a las pantallas de este Módulo." & Chr(13) & "Para configurar estos parámetros vaya al Menu Archivo y seleccione la opción «Parámetros de Servidor Central».", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If

        Cp_cmb_ciudad.AgregarItem("1", "MONTERREY")
        Cp_cmb_ciudad.AgregarItem("2", "SALTILLO")
        Cp_cmb_EstatusContratacion.AgregarItem("1", "Contratar")
        Cp_cmb_EstatusContratacion.AgregarItem("2", "Urge Contratar")


        If Not Cn_Reclutamiento.fn_Vacantes_ObtenValores(Cp_Listview1) Then
            MsgBox("Ocurrió un error al intentar mostrar Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

        If Not Cn_Reclutamiento.fn_Postulados_ObtenValores(lsv_Catalogo) Then
            MsgBox("Ocurrió un error al intentar mostrar Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Sub LimpiarControles()
        Cp_cmb_ciudad.Text = "Seleccione..."
        Cp_cmb_EstatusContratacion.Text = "Seleccione..."

        txt_Titulo.Clear()

        Cp_Tbx_Sueldo.Clear()

        Tbx_Descripcion.Clear()
    End Sub

    Private Sub btn_Guardar_Referencias_Click(sender As Object, e As EventArgs) Handles btn_Guardar_Referencias.Click
        SegundosDesconexion = 0
        Dim Titulo = txt_Titulo.Text
        If txt_Titulo.Text = "" Then
            MsgBox("Agregar el titulo.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_Titulo.Focus()
            Exit Sub
        End If
        Dim Ciudad As String = ""
        If SucursalClave = "01" Then
            Ciudad = "MONTERREY"
        Else

            Ciudad = "SALTILLO"
        End If

        'If Cp_cmb_ciudad.Text = "Seleccione..." Then
        '    MsgBox("Seleccione una ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    Cp_cmb_ciudad.Focus()
        '    Exit Sub
        'End If

        If Cp_Tbx_Sueldo.Text = "" Then
            MsgBox("Agrege el sueldo", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_Tbx_Sueldo.Focus()
            Exit Sub
        End If

        If Cp_cmb_EstatusContratacion.Text = "Seleccione..." Then
            MsgBox("Seleccione un status.", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_cmb_EstatusContratacion.Focus()
            Exit Sub
        End If


        If Tbx_Descripcion.Text = "" Then
            MsgBox("Agrege una Descripcion", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Descripcion.Focus()
            Exit Sub
        End If


        If (Cn_Reclutamiento.fn_BolsaDeEmpleo_Add(Titulo, Ciudad, Cp_Tbx_Sueldo.Text, Cp_cmb_EstatusContratacion.Text, Tbx_Descripcion.Text)) Then
            MsgBox("La postulación se agrego correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        End If
        Call LimpiarControles()

        If Not Cn_Reclutamiento.fn_Vacantes_ObtenValores(Cp_Listview1) Then
            MsgBox("Ocurrió un error al intentar mostrar Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lsv_Catalogo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lsv_Catalogo.SelectedIndexChanged
        If lsv_Catalogo.SelectedItems.Count > 0 Then
            'Id = lsv_Catalogo.SelectedItems(0).Tag
            Btn_Validar.Enabled = True
            GroupBox2.Enabled = True
        Else
            'Id = 0
            Lb_Titulo.Text = ""
            Lb_NombreEmpleado.Text = ""
            Lb_Movil.Text = ""
            Tbx_Comentarios.Text = ""
            Btn_Validar.Enabled = False
            RadioButton4.Checked = False
            RadioButton3.Checked = False
            GroupBox2.Enabled = False

        End If

    End Sub

    Private Sub lsv_Catalogo_DoubleClick(sender As Object, e As EventArgs) Handles lsv_Catalogo.DoubleClick
        SegundosDesconexion = 0
        Dim DirectarioArchivo As String
        DirectarioArchivo = AppDomain.CurrentDomain.BaseDirectory() & "temp.pdf"
        Dim bytes() As Byte

        Dim Id_Prospecto = lsv_Catalogo.SelectedItems(0).SubItems(0).Text
        Dim Candidato = lsv_Catalogo.SelectedItems(0).SubItems(3).Text
        Dim frm As New frm_CV
        Dim tabla As DataTable = Cn_Reclutamiento.fn_ParametrosPDF_Read(Id_Prospecto)
        For Each fila As DataRow In tabla.Rows
            If fila("Archivo") IsNot DBNull.Value Then
                bytes = fila("Archivo")
                BytesArchivo(bytes, DirectarioArchivo)
                frm.AxAcroPDF1.src = DirectarioArchivo
                My.Computer.FileSystem.DeleteFile(DirectarioArchivo)
            Else
                MsgBox("El candidato (" & Candidato & ") no subio su CV.", MsgBoxStyle.Critical, frm_MENU.Text)
                Exit Sub
            End If
        Next
        frm.ShowDialog()
    End Sub


    Private Sub BytesArchivo(ByRef bytes() As Byte, Path As String)
        Dim k As Long
        If bytes Is Nothing Then
            Exit Sub
        End If
        Try
            k = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, k)
            fs.Close()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub Cp_Listview1_DoubleClick(sender As Object, e As EventArgs) Handles Cp_Listview1.DoubleClick



        btn_Guardar_Referencias.Enabled = False
        btn_Modificar_Referencias.Enabled = True
        GroupBox1.Enabled = True

        Id_Empleo = Cp_Listview1.SelectedItems(0).Tag
        txt_Titulo.Text = Cp_Listview1.SelectedItems(0).SubItems(0).Text
        Cp_Tbx_Sueldo.Text = Cp_Listview1.SelectedItems(0).SubItems(3).Text
        Cp_cmb_ciudad.Text = Cp_Listview1.SelectedItems(0).SubItems(1).Text
        Cp_cmb_EstatusContratacion.Text = Cp_Listview1.SelectedItems(0).SubItems(2).Text
        Tbx_Descripcion.Text = Cp_Listview1.SelectedItems(0).SubItems(5).Text

        If Cp_Listview1.SelectedItems(0).SubItems(4).Text = "ACTIVO" Then
            RadioButton1.Checked = True
            RadioButton2.Checked = False
        Else
            RadioButton1.Checked = False
            RadioButton2.Checked = True
        End If

    End Sub



    Private Sub btn_Modificar_Referencias_Click(sender As Object, e As EventArgs) Handles btn_Modificar_Referencias.Click
        GroupBox1.Enabled = False
        Dim Status As String = ""
        btn_Modificar_Referencias.Enabled = False
        SegundosDesconexion = 0
        Dim Titulo = txt_Titulo.Text
        If txt_Titulo.Text = "" Then
            MsgBox("Agregar el titulo.", MsgBoxStyle.Critical, frm_MENU.Text)
            txt_Titulo.Focus()
            Exit Sub
        End If
        If Cp_cmb_ciudad.Text = "Seleccione..." Then
            MsgBox("Seleccione una ciudad.", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_cmb_ciudad.Focus()
            Exit Sub
        End If
        If Cp_Tbx_Sueldo.Text = "" Then
            MsgBox("Agrege el sueldo", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_Tbx_Sueldo.Focus()
            Exit Sub
        End If

        If Cp_cmb_EstatusContratacion.Text = "Seleccione..." Then
            MsgBox("Seleccione un status.", MsgBoxStyle.Critical, frm_MENU.Text)
            Cp_cmb_EstatusContratacion.Focus()
            Exit Sub
        End If
        If RadioButton1.Checked Then
            Status = "A"
        End If
        If RadioButton2.Checked Then
            Status = "B"

        End If

        If Tbx_Descripcion.Text = "" Then
            MsgBox("Agrege una Descripcion", MsgBoxStyle.Critical, frm_MENU.Text)
            Tbx_Descripcion.Focus()
            Exit Sub
        End If
        If Cn_Reclutamiento.fn_vacante_Actualizar(Id_Empleo, Titulo, Cp_cmb_ciudad.Text, Cp_Tbx_Sueldo.Text, Cp_cmb_EstatusContratacion.Text, Tbx_Descripcion.Text, Status) Then
            MsgBox("Se a Actualizado la Vacante.", MsgBoxStyle.Information, frm_MENU.Text)
            GroupBox1.Enabled = False
            btn_Modificar_Referencias.Enabled = False
        Else
            Exit Sub
        End If
        Call LimpiarControles()
        If Not Cn_Reclutamiento.fn_Vacantes_ObtenValores(Cp_Listview1) Then
            MsgBox("Ocurrió un error al intentar mostrar Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
        btn_Guardar_Referencias.Enabled = True

    End Sub

    Private Sub Cp_Listview1_Click(sender As Object, e As EventArgs) Handles Cp_Listview1.Click
        Call LimpiarControles()
    End Sub

    Private Sub btn_Cancelar_Referencias_Click(sender As Object, e As EventArgs) Handles btn_Cancelar_Referencias.Click
        SegundosDesconexion = 0
        Call LimpiarControles()

        GroupBox1.Enabled = False
        RadioButton1.Checked = False
        RadioButton2.Checked = False

        btn_Modificar_Referencias.Enabled = False
        btn_Guardar_Referencias.Enabled = True
    End Sub

    Private Sub cmb_Sucursal_SelectedValueChanged(sender As Object, e As EventArgs)
        'LlenarLista()
    End Sub

    Private Sub lsv_Catalogo_Click(sender As Object, e As EventArgs) Handles lsv_Catalogo.Click

        Id_Empleo = lsv_Catalogo.SelectedItems(0).Text
        Lb_Titulo.Text = lsv_Catalogo.SelectedItems(0).SubItems(2).Text
        Lb_NombreEmpleado.Text = lsv_Catalogo.SelectedItems(0).SubItems(3).Text
        Lb_Movil.Text = lsv_Catalogo.SelectedItems(0).SubItems(5).Text
        Tbx_Comentarios.Text = lsv_Catalogo.SelectedItems(0).SubItems(10).Text

        If lsv_Catalogo.SelectedItems(0).SubItems(9).Text = "" Then
            RadioButton4.Checked = False
            RadioButton3.Checked = False
        Else
            If lsv_Catalogo.SelectedItems(0).SubItems(9).Text = "SI" Then
                RadioButton4.Checked = True
                RadioButton3.Checked = False
            Else
                RadioButton4.Checked = False
                RadioButton3.Checked = True
            End If
        End If

    End Sub

    Private Sub Btn_Validar_Click(sender As Object, e As EventArgs) Handles Btn_Validar.Click
        SegundosDesconexion = 0
        Dim Apto As String = ""

        If Tbx_Comentarios.Text = "" Then
            MsgBox("Ingrese un Comentario.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub
        End If
        If RadioButton4.Checked = False And RadioButton3.Checked = False Then
            MsgBox("Selecciona si es Aptoo o no.", MsgBoxStyle.Critical, frm_MENU.Text)
            Exit Sub

        End If
        If RadioButton4.Checked Then
            Apto = "A"
        End If
        If RadioButton3.Checked Then
            Apto = "N"
        End If


        If Cn_Reclutamiento.fn_ValidarProspeto(Id_Empleo, Tbx_Comentarios.Text, Apto) Then
            MsgBox("Se a Actualizado la Vacante.", MsgBoxStyle.Information, frm_MENU.Text)
            limpiarCotroles()
        End If


        If Not Cn_Reclutamiento.fn_Postulados_ObtenValores(lsv_Catalogo) Then
            MsgBox("Ocurrió un error al intentar mostrar Empleados.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Sub limpiarCotroles()
        Tbx_Comentarios.Text = ""
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        Lb_Titulo.Text = ""
        Lb_NombreEmpleado.Text = ""
        Lb_Movil.Text = ""
    End Sub
End Class