Imports System.Drawing.Printing
Imports Camera_NET

Public Class frm_ObtenerImagen_Settings
    Public Tipo As Integer = 1
    'Tipo 1: Solo modifica la camara y resolucion
    'Tipo 2: Puede modificar todo
    'Tipo 3: Solo Impresora
    Public Guardado As Boolean = False
    Private _CameraChoice As CameraChoice = New CameraChoice()

    Private Sub frm_ObtenerImagen_Settings_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call ListarCamaras()
        Call ListarImpresoras()

        tbx_CompresionImagen.Text = My.Settings.CompresionImagen
        tbx_TamanoMaxImagen.Text = My.Settings.TamanoMaxImagen

        Try
            cmb_Zebra.Text = My.Settings.Zebra
        Catch ex As Exception
            cmb_Zebra.Text = ""
        End Try

        gbx_Camara.Enabled = False
        gbx_Imagenes.Enabled = False
        gbx_Impresora.Enabled = False
        Select Case Tipo
            Case 1
                gbx_Camara.Enabled = True
            Case 2
                gbx_Camara.Enabled = True
                gbx_Imagenes.Enabled = True
                gbx_Impresora.Enabled = True
            Case 3
                gbx_Impresora.Enabled = True
        End Select
    End Sub

    Sub ListarImpresoras()
        Dim pd As New PrintDocument

        ' obtiene la impresora predeterminada   
        '{Dim instacia As New PrinterSettings
        'Dim printerPredeter As String = instacia.PrinterName}
        Dim Impresora_Predeterminada As String = pd.PrinterSettings.PrinterName

        For Each impresoras In PrinterSettings.InstalledPrinters
            cmb_Zebra.Items.Add(impresoras)
        Next

    End Sub

    Sub ListarCamaras()
        Cmb_Camara.Items.Clear()
        _CameraChoice.UpdateDeviceList()

        Dim NombreCamara As String = My.Settings.Camara
        Dim IndexCamara As Integer = -1

        For Each Camara_Device In _CameraChoice.Devices
            Cmb_Camara.Items.Add(Camara_Device.Name)
            If NombreCamara = Camara_Device.Name Then
                IndexCamara = Cmb_Camara.Items.Count - 1
            End If
        Next

        If IndexCamara > -1 Then
            Cmb_Camara.SelectedIndex = IndexCamara
        End If

    End Sub

    Sub ListaResoluciones()
        Cmb_Resolucion.Items.Clear()
        If Cmb_Camara.SelectedIndex = -1 Then
            Exit Sub
        End If
        Dim resolutions As ResolutionList = Camera.GetResolutionList(_CameraChoice.Devices(Cmb_Camara.SelectedIndex).Mon)
        Dim SetResolucionStr As String = My.Settings.Resolucion
        Dim SetResolucion As Camera_NET.Resolution = Nothing

        If SetResolucionStr.ToUpper.Contains("X") Then
            SetResolucion = New Camera_NET.Resolution(SetResolucionStr.Split("x")(0), SetResolucionStr.Split("x")(1))
        End If

        If resolutions Is Nothing Then
            Exit Sub
        End If

        Dim IndexResolucion As Integer = -1

        For Index As Integer = 0 To resolutions.Count - 1
            Cmb_Resolucion.Items.Add(resolutions(Index).ToString)
            If resolutions(Index).CompareTo(SetResolucion) = 0 Then
                IndexResolucion = Index
            End If
        Next

        If IndexResolucion > -1 Then
            Cmb_Resolucion.SelectedIndex = IndexResolucion
        End If
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        SegundosDesconexion = 0

        If gbx_Camara.Enabled Then
            My.Settings.Camara = Cmb_Camara.Text
            My.Settings.Resolucion = Cmb_Resolucion.Text
        End If

        Dim Valor As Integer = 0

        If gbx_Imagenes.Enabled Then

            If tbx_CompresionImagen.Text.Trim = "" Then
                MsgBox("Indique el porcentaje de compresión de las imagenes.", MsgBoxStyle.Critical, Me.Text)
                tbx_CompresionImagen.Focus()
                Exit Sub
            ElseIf (Not Integer.TryParse(tbx_CompresionImagen.Text, Valor)) OrElse Integer.Parse(tbx_CompresionImagen.Text) < 1 Then
                MsgBox("El porcentaje de compresión no es válido.", MsgBoxStyle.Critical, Me.Text)
                tbx_CompresionImagen.Focus()
                Exit Sub
            End If

            If tbx_TamanoMaxImagen.Text.Trim = "" Then
                MsgBox("Indique el tamaño máximo para guardar imagenes.", MsgBoxStyle.Critical, Me.Text)
                tbx_TamanoMaxImagen.Focus()
                Exit Sub
            ElseIf (Not Integer.TryParse(tbx_TamanoMaxImagen.Text, Valor)) OrElse Integer.Parse(tbx_TamanoMaxImagen.Text) < 1 Then
                MsgBox("El tamaño no es válido.", MsgBoxStyle.Critical, Me.Text)
                tbx_TamanoMaxImagen.Focus()
                Exit Sub
            End If

            My.Settings.CompresionImagen = tbx_CompresionImagen.Text
            My.Settings.TamanoMaxImagen = tbx_TamanoMaxImagen.Text

        End If

        If gbx_Impresora.Enabled Then
            If cmb_Zebra.Text = "" And cmb_Zebra.Items.Count > 0 Then
                MsgBox("Seleccione una impresora.", MsgBoxStyle.Critical, Me.Text)
                cmb_Zebra.Focus()
                Exit Sub
            End If

            My.Settings.Zebra = cmb_Zebra.Text
        End If

        My.Settings.Save()
        Guardado = True
        Me.Close()
    End Sub

    Private Sub Cmb_Camara_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cmb_Camara.SelectedIndexChanged
        SegundosDesconexion = 0
        If Cmb_Camara.SelectedIndex < 0 Then
            Cmb_Resolucion.Items.Clear()
        Else
            Call ListaResoluciones()
        End If
    End Sub

    Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        SegundosDesconexion = 0
        Me.Close()
    End Sub

End Class