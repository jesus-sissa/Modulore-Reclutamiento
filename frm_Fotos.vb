Imports System.Runtime.InteropServices

Public Class frm_Fotos

    Const WM_CAP As Short = &H400S

    Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Const WM_CAP_DLG_VIDEOSOURCE As Integer = WM_CAP + 42
    Const WM_CAP_DLG_VIDEODISPLAY As Integer = WM_CAP + 43
    Const WM_CAP_GET_VIDEOFORMAT As Integer = WM_CAP + 44
    Const WM_CAP_SET_VIDEOFORMAT As Integer = WM_CAP + 45

    Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Const WM_CAP_SET_OVERLAY As Integer = WM_CAP + 51
    Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Const WM_CAP_GET_STATUS As Integer = WM_CAP + 54

    Const WS_CHILD As Integer = &H40000000
    Const WS_VISIBLE As Integer = &H10000000
    Const SWP_NOMOVE As Short = &H2S
    Const SWP_NOSIZE As Short = 1
    Const SWP_NOZORDER As Short = &H4S
    Const HWND_BOTTOM As Short = 1

    Dim iDevice As Integer = 0 ' Current device ID
    Dim hHwnd As Integer ' Handle to preview window

    Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Declare Function capCreateCaptureWindowA Lib "avicap32.dll" (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean

    Dim Iniciado As Boolean = False

    Private Sub frm_Fotos_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Iniciado Then
            Call ClosePreviewWindow()
        End If
    End Sub

    Private Sub frm_Fotos_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Cursor = Cursors.WaitCursor
        Call LoadDeviceList()
        If lst_Camaras.Items.Count > 0 Then
            lst_Camaras.SelectedIndex = 0
            lbl_Camara.Text = lst_Camaras.SelectedItems(0).ToString
        Else
            Me.Cursor = Cursors.Default
            MsgBox("No se detectó ninguna Cámara.", MsgBoxStyle.Critical, frm_MENU.Text)
            BanderA = False
            Me.Close()
        End If

        If UsuarioTipo = 2 OrElse UsuarioTipo = 4 OrElse UsuarioTipo = 5 Then
            btn_Resolucion.Visible = True
        End If
    End Sub

    Private Sub LoadDeviceList()
        Dim strName As String = Space(100)
        Dim strVer As String = Space(100)
        Dim bReturn As Boolean
        Dim x As Integer = 0
        ' Load name of all avialable devices into the lstDevices
        Do
            '   Get Driver name and version
            bReturn = capGetDriverDescriptionA(x, strName, 100, strVer, 100)
            ' If there was a device add device name to the list
            If bReturn Then lst_Camaras.Items.Add(strName.Trim)
            x += 1
        Loop Until bReturn = False
    End Sub

    Private Sub OpenPreviewWindow()
        Dim iHeight As Integer = pct_Foto.Height
        Dim iWidth As Integer = pct_Foto.Width
        ' Open Preview window in picturebox
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, 480, pct_Foto.Handle.ToInt32, 0)
        ' Connect to device
        If SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
            'Set the preview scale
            SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
            'Set the preview rate in milliseconds
            SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
            'Start previewing the image from the camera
            SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
            ' Resize window to fit in picturebox
            SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, pct_Foto.Width, pct_Foto.Height, SWP_NOMOVE Or SWP_NOZORDER)
            Iniciado = True
            btn_Capturar.Enabled = True
            btn_Resolucion.Enabled = True
        Else
            ' Error connecting to device close window
            Iniciado = False
            btn_Capturar.Enabled = False
            btn_Resolucion.Enabled = False
            DestroyWindow(hHwnd)
            MsgBox("No se pudo Inicializar la cámara.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If
    End Sub

    Private Sub ClosePreviewWindow()
        SegundosDesconexion = 0

        ' Disconnect from device
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        ' close window
        DestroyWindow(hHwnd)
    End Sub

    Private Sub btn_Capturar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Capturar.Click
        Call Capturar()
    End Sub

    Sub Capturar()
        SegundosDesconexion = 0

        Dim data As IDataObject
        Dim bmap As Image

        ' Copy image to clipboard 
        SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
        ' Get image from clipboard and convert it to a bitmap
        data = Clipboard.GetDataObject()
        If data.GetDataPresent(GetType(System.Drawing.Bitmap)) Then
            bmap = CType(data.GetData(GetType(System.Drawing.Bitmap)), Image)
            pct_Foto.Image = bmap
            Call ClosePreviewWindow()
            BanderA = True
            Me.Close()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0

        BanderA = False
        Me.Close()
    End Sub

    Private Sub tmr_Iniciar_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tmr_Iniciar.Tick
        Me.Cursor = Cursors.WaitCursor
        tmr_Iniciar.Enabled = False
        If lst_Camaras.Items.Count > 0 Then
            iDevice = lst_Camaras.SelectedIndex
            OpenPreviewWindow()
            Me.Cursor = Cursors.Default
        Else
            Me.Cursor = Cursors.Default
            BanderA = False
            Me.Close()
        End If
    End Sub

    Private Sub frm_Fotos_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        Select Case e.KeyCode
            Case Keys.F2
                If btn_Capturar.Enabled Then
                    Call Capturar()
                End If
            Case Keys.Escape
                BanderA = False
                Me.Close()
        End Select
    End Sub

    Private Sub btn_Resolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Resolucion.Click
        'Abrir ventana para seleccionar el Formato 
        SendMessage(hHwnd, WM_CAP_DLG_VIDEOFORMAT, 0, 0)
    End Sub

End Class