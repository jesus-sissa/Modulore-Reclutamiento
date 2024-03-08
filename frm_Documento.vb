Imports System.IO
Imports Microsoft.Web.WebView2.Core
Imports Newtonsoft.Json

Public Class frm_Documento
    Public Documento As Integer
    Public InfContrato As cls_Documentos
    Public DownloadPath As String

    Public Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Initwebview()
    End Sub

    Private Sub frm_DocumentoContrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim Index As String

        InfContrato.FotoEncabezado = Application.StartupPath & "\html\img\encabezado.jpg"
        InfContrato.FotoPiePagina = Application.StartupPath & "\html\img\pie.png"
        InfContrato.FotoLogo = Application.StartupPath & "\html\img\logo.png"

        Select Case Documento
            Case 1
                Index = "\html\Doc_AvisoCandidatos.html"
            Case 2
                Index = "\html\Doc_CartaConfidencialidad.html"
            Case 3
                Index = "\html\Doc_ConvenioConfidencialidad.html"
            Case 4
                Index = "\html\Doc_AvisoPrivacidad.html"
            Case 5
                Index = "\html\Doc_Concentimientos.html"
            Case 6
                Index = "\html\Doc_ContratoLaboral.html"
            Case 7
                Index = "\html\Doc_ExamenBarsit.html"
            Case 8
                Index = "\html\Doc_CuestionarioMedico.html"
        End Select

        Dim url As String = "file://" & Application.StartupPath & Index
        'WebView.Source = New Uri(url)
        WebView.Source = New Uri(url, UriKind.Absolute)

    End Sub

    Private Async Sub Initwebview()

        Dim wvEnvironment As CoreWebView2Environment = Nothing
        Await WebView.EnsureCoreWebView2Async(wvEnvironment)

        AddHandler WebView.WebMessageReceived, AddressOf WebMessage

    End Sub
    Private Sub WebMessage(sender As Object, e As CoreWebView2WebMessageReceivedEventArgs)
        Dim content As String = e.TryGetWebMessageAsString()
        If content.StartsWith("getData") Then
            'WebView.CoreWebView2.PostWebMessageAsString(JsonConvert.SerializeObject(cfdi))
            WebView.CoreWebView2.PostWebMessageAsString(JsonConvert.SerializeObject(InfContrato))
        End If
    End Sub

    Private Sub WebView_NavigationCompleted(sender As Object, e As CoreWebView2NavigationCompletedEventArgs) Handles WebView.NavigationCompleted

    End Sub

    Private Sub Btn_Imprimir_Click(sender As Object, e As EventArgs) Handles Btn_Imprimir.Click
        If DownloadPath Is Nothing Then
            MsgBox("Seleccione ruta para guardar los documentod")
            Exit Sub
        End If
        Try
            Dim printSettings As CoreWebView2PrintSettings = WebView.CoreWebView2.Environment.CreatePrintSettings()
            printSettings.ShouldPrintBackgrounds = True
            printSettings.MarginLeft = 0
            printSettings.MarginRight = 0
            printSettings.MarginTop = 0
            printSettings.MarginBottom = 0
            printSettings.Orientation = CoreWebView2PrintOrientation.Portrait

            Dim path As String
            Dim name As String = InfContrato.Nombre.Trim() & "." & "pdf"

            Select Case Documento
                Case 1
                    path = DownloadPath & "/AvisoCandidatos_" & name
                Case 2
                    path = DownloadPath & "/CartaConfidencialidad_" & name
                Case 3
                    path = DownloadPath & "/ConvenioConfidencialidad_" & name
                Case 4
                    path = DownloadPath & "/AvisoPrivacidad_" & name
                Case 5
                    path = DownloadPath & "/Concentimientos_" & name
                Case 6
                    path = DownloadPath & "/ContratoLaboral_" & name
                Case 7
                    path = DownloadPath & "/ExamenBarsit_" & name
                Case 8
                    path = DownloadPath & "/CuestionarioMedico_" & name
            End Select

            If File.Exists(path) Then
                File.Delete(path)
            End If

            WebView.CoreWebView2.PrintToPdfAsync(path, printSettings)
            MsgBox("Archivo Descargado")

        Catch ex As Exception

        End Try

    End Sub


End Class