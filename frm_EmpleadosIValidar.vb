Imports NITGEN.SDK.NBioBSP

Public Class frm_EmpleadosIValidar

    Dim m_NBioAPI As NBioAPI
    Dim m_OpenedDeviceID As Byte
    Dim m_hNewFIR As NBioAPI.Type.HFIR
    Dim m_hNewFIR2 As NBioAPI.Type.HFIR
    Dim m_biFIR As NBioAPI.Type.FIR
    Dim m_textFIR As NBioAPI.Type.FIR_TEXTENCODE
    Dim m_Opciones As NBioAPI.Type.INIT_INFO_0

    Public Dt_Huellas As New DataTable

    Private Sub frm_EmpleadosIValidar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call InicializarDispositvo()
    End Sub

    Sub InicializarDispositvo()
        Try
            'Inicializar las Variables
            m_OpenedDeviceID = 0
            m_NBioAPI = New NBioAPI()
            m_OpenedDeviceID = NBioAPI.Type.DEVICE_ID.NONE
            m_hNewFIR = Nothing

            Dim iDeviceID As Byte = NBioAPI.Type.DEVICE_ID.AUTO

            'Cerrarlo si ya estaba abierto
            m_NBioAPI.CloseDevice(m_OpenedDeviceID)
            'Abrir el dispositivo
            Dim ret As Integer = m_NBioAPI.OpenDevice(iDeviceID)
            If ret = NBioAPI.Error.NONE Then
                m_OpenedDeviceID = iDeviceID
                tmr_Huella.Enabled = True
            Else
                tbx_Validacion.ForeColor = Color.Red
                tbx_Validacion.Text = "Dispositivo NO Inicializado"
            End If
        Catch ex As Exception
            MsgBox("Ocurrió un error al Iniciar el Dispositivo, Consulte al Administrador del Sistema", MsgBoxStyle.Critical, frm_MENU.Text)
            Me.Close()
        End Try
    End Sub

    Sub ValidarHuella()
        Me.Cursor = Cursors.WaitCursor

        'Pedir la huella del Visitante para compararla contra las de la base de datos.
        Dim TextEncode As NBioAPI.Type.FIR_TEXTENCODE = Nothing
        Dim winOption As New NBioAPI.Type.WINDOW_OPTION
        Dim myPayload = New NBioAPI.Type.FIR_PAYLOAD()
        Dim Lectura As String = ""

        myPayload.Data = "0"

        winOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_WELCOME
        winOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.NO_TOPMOST
        winOption.WindowStyle = NBioAPI.Type.WINDOW_STYLE.INVISIBLE

        winOption.FingerWnd = pct_Huella.Handle.ToInt32()

        m_Opciones.VerifyImageQuality = 70
        m_Opciones.EnrollImageQuality = 70
        m_Opciones.IdentifyImageQuality = 70
        m_Opciones.SecurityLevel = 6
        m_Opciones.DefaultTimeout = 10000
        m_Opciones.MaxFingersForEnroll = 10
        m_Opciones.SamplesPerFinger = 1
        m_NBioAPI.SetInitInfo(m_Opciones)

        ResP = m_NBioAPI.Capture(m_hNewFIR, 10000, winOption)

        If ResP = NBioAPI.Error.NONE Then
            'Get text encoded FIR data
            m_NBioAPI.GetTextFIRFromHandle(m_hNewFIR, m_textFIR, True) 'm_textFIR es un parametro de salida
            Lectura = m_textFIR.TextFIR

            'Ya tengo la lectura. Ahora debo utiizarla para comparar contra la tabla de dt_Huellas previamente cargada
            For Each Row As DataRow In Dt_Huellas.Rows
                If Comparar(Row("Huella"), Lectura) = 1 Then
                    Row("CambiarColor") = "S"
                    tmr_Huella.Enabled = True
                    tbx_Validacion.ForeColor = Color.Green
                    pct_HuellaV.Image = My.Resources.HoraSi
                    tbx_Validacion.Text = Row("Mano").ToString.ToUpper & " DEDO: " & Row("Dedo").ToString.ToUpper
                    Me.Cursor = Cursors.Default
                    Dim frm As New frm_EmpleadosI
                    Exit Sub
                End If
            Next
            tbx_Validacion.ForeColor = Color.Red
            tbx_Validacion.Text = "Huella No Encontrada."
            pct_HuellaV.Image = My.Resources.Delete
        Else
            'Error con el Dispositivo
            pct_Huella.Image = My.Resources.LogoNoDisponible
            pct_Huella.Refresh()
            tbx_Validacion.ForeColor = Color.Red
            tbx_Validacion.Text = "Error con el Dispositivo."
            pct_HuellaV.Image = My.Resources.Delete
            tmr_Huella.Enabled = True
        End If
        tmr_Huella.Enabled = True
        Me.Cursor = Cursors.Default
    End Sub

    Function Comparar(ByVal Huella1 As String, ByVal Huella2 As String) As Integer
        Dim Result As Boolean = False
        Dim HuellaA As New NBioAPI.Type.FIR_TEXTENCODE()
        Dim HuellaB As New NBioAPI.Type.FIR_TEXTENCODE()
        Dim myPayload = New NBioAPI.Type.FIR_PAYLOAD()
        HuellaA.TextFIR = Huella1
        HuellaB.TextFIR = Huella2

        ResP = m_NBioAPI.VerifyMatch(HuellaA, HuellaB, Result, myPayload)    ' Verify with text encoded FIR
        If ResP = 0 Then
            If Result Then
                'Acceso Correcto
                Return 1
            Else
                'No son Iguales
                Return 0
            End If
        Else
            'Error al verificar
            Return -1
        End If
    End Function

    Private Sub btn_Capturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar.Click
        SegundosDesconexion = 0

        pct_HuellaV.Image = My.Resources.Delete
        tmr_Huella.Enabled = False
        Call InicializarDispositvo()
        If tmr_Huella.Enabled Then Call ValidarHuella()
    End Sub

    Private Sub tmr_Huella_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Huella.Tick
        Dim HayDedo As Boolean
        If m_NBioAPI.CheckFinger(HayDedo) = NBioAPI.Error.NONE Then
            tmr_Huella.Enabled = False
            If HayDedo Then
                Call ValidarHuella()
            Else
                tmr_Huella.Enabled = True
                tbx_Validacion.ForeColor = Color.DarkGray
                tbx_Validacion.Text = "Poner Huella"
                pct_HuellaV.Image = My.Resources.Delete
                pct_Huella.Image = My.Resources.LogoNoDisponible
            End If
        End If
    End Sub

    Private Sub btn_Continuar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Continuar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

    Private Sub frm_EmpleadosIValidar_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If m_OpenedDeviceID > 0 Then
            m_NBioAPI.CloseDevice(m_OpenedDeviceID)
        End If
    End Sub

End Class