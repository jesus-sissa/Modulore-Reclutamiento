Imports System.IO

Public Class frm_MapasGo


    Public ZoomdelMapa As Integer = 13
    Public Lsv_Lista As ListView = Nothing
    Public ColLat As Integer = 0
    Public ColLon As Integer = 0
    Public LatitudUno As Decimal = 0
    Public LongitudUno As Decimal = 0
    Public DepartamentoUno As String = ""
    Public PuestoUno As String = ""
    Public Nombre As String = ""

    Public TipoMapa As Byte
    '1=Catalogo Empleados
    '2=Un Empleado
    '3=Ref. Laborales

    Private Sub frm_MapasGo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        SegundosDesconexion = 0

        Select Case TipoMapa
            Case 1
                If Lsv_Lista.Items.Count > 0 Then
                    Call MapaEmpleados()
                Else
                    MsgBox("No Hay Informacion para mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If
            Case 2
                Call MapaUnEmpleado()
            Case 3
                If Lsv_Lista.Items.Count > 0 Then
                    Call MapaRefLaborales()
                Else
                    MsgBox("No Hay Informacion para mostrar.", MsgBoxStyle.Critical, frm_MENU.Text)
                    Me.Close()
                End If
        End Select

    End Sub

    Private Sub MapaEmpleados()

        SegundosDesconexion = 0
        Dim UrlCoo As String = ""
        Dim Numero As Integer = 0
        Dim NumeroSin As Integer = 0
        Dim Title As String = ""


        UrlCoo = "<!DOCTYPE html>" & vbCrLf & _
                "<html>" & vbCrLf & _
                "<head>" & vbCrLf & _
                "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=8" & Chr(34) & ">" & vbCrLf & _
                "<style>" & vbCrLf & _
                "html, body {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "margin: 0;" & vbCrLf & _
                "padding: 0;" & vbCrLf & _
                "}" & vbCrLf & _
                "#map {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "}" & vbCrLf & _
                "</style>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id=" & Chr(34) & "map" & Chr(34) & "></div>" & vbCrLf & _
                "<script>" & vbCrLf & _
                " function initMap() {" & vbCrLf & _
                "var map = new google.maps.Map(document.getElementById('map'), {" & vbCrLf & _
                "center: {lat:  " & SucursalLAT & ", lng: " & SucursalLON & "}," & vbCrLf & _
                "scrollwheel: true," & vbCrLf & _
                "zoom: 12" & vbCrLf & _
                "});" & vbCrLf

        For Each fila As ListViewItem In Lsv_Lista.Items

            If fila.SubItems(6).Text <> 0 And fila.SubItems(7).Text <> 0 Then
                Numero += 1
                Title = fila.Text & " - " & fila.SubItems(1).Text

                UrlCoo &= "var marker" & Numero & " = new google.maps.Marker({" & vbCrLf
                UrlCoo &= "map: map," & vbCrLf
                UrlCoo &= "position: {lat: " & fila.SubItems(6).Text & ", lng: " & fila.SubItems(7).Text & "}," & vbCrLf
                UrlCoo &= "title: '" & Title & "'," & vbCrLf
                UrlCoo &= "animation: google.maps.Animation.DROP" & vbCrLf
                UrlCoo &= "});" & vbCrLf
                UrlCoo &= " var infowindow" & Numero & " = new google.maps.InfoWindow({" & vbCrLf
                UrlCoo &= "content: " & Chr(34) & " <h3>" & Title & "</h3>" & Chr(34) & " + " & Chr(34) & "<div id=\" & Chr(34) & "bodyContent\" & Chr(34) & ">" & Chr(34) & " + " & Chr(34) & "<b>Departamento: </b>" & fila.SubItems(2).Text & "<br><b>Puesto: </b>" & fila.SubItems(3).Text & "<br><br><b>Latitud: </b>" & fila.SubItems(6).Text & "<br><b>Longitud: </b>" & fila.SubItems(7).Text & Chr(34) & vbCrLf
                UrlCoo &= "  });" & vbCrLf
                UrlCoo &= " marker" & Numero & ".addListener('click', function() {" & vbCrLf
                UrlCoo &= "  infowindow" & Numero & ".open(marker" & Numero & ".get('map'), marker" & Numero & ");" & vbCrLf
                UrlCoo &= " });" & vbCrLf

            Else
                NumeroSin += 1
            End If

        Next

        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaEmpleados.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaEmpleados.HTML")

        If NumeroSin > 0 Then
            MsgBox("(" & NumeroSin & ") Empleados no Tienen Coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub MapaUnEmpleado()

        SegundosDesconexion = 0
        Dim UrlCoo As String = ""
        Dim Title As String = ""


        UrlCoo = "<!DOCTYPE html>" & vbCrLf & _
                "<html>" & vbCrLf & _
                "<head>" & vbCrLf & _
                "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=8" & Chr(34) & ">" & vbCrLf & _
                "<style>" & vbCrLf & _
                "html, body {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "margin: 0;" & vbCrLf & _
                "padding: 0;" & vbCrLf & _
                "}" & vbCrLf & _
                "#map {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "}" & vbCrLf & _
                "</style>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id=" & Chr(34) & "map" & Chr(34) & "></div>" & vbCrLf & _
                "<script>" & vbCrLf & _
                " function initMap() {" & vbCrLf & _
                "var map = new google.maps.Map(document.getElementById('map'), {" & vbCrLf & _
                "center: {lat:  " & SucursalLAT & ", lng: " & SucursalLON & "}," & vbCrLf & _
                "scrollwheel: true," & vbCrLf & _
                "zoom: 12" & vbCrLf & _
                "});" & vbCrLf


        Title = Nombre

        UrlCoo &= "var marker1 = new google.maps.Marker({" & vbCrLf
        UrlCoo &= "map: map," & vbCrLf
        UrlCoo &= "position: {lat: " & LatitudUno & ", lng: " & LongitudUno & "}," & vbCrLf
        UrlCoo &= "title: '" & Title & "'," & vbCrLf
        UrlCoo &= "animation: google.maps.Animation.DROP" & vbCrLf
        UrlCoo &= "});" & vbCrLf
        UrlCoo &= " var infowindow1 = new google.maps.InfoWindow({" & vbCrLf
        UrlCoo &= "content: " & Chr(34) & " <h3>" & Title & "</h3>" & Chr(34) & " + " & Chr(34) & "<div id=\" & Chr(34) & "bodyContent\" & Chr(34) & ">" & Chr(34) & " + " & Chr(34) & "<b>Departamento: </b>" & DepartamentoUno & "<br><b>Puesto: </b>" & PuestoUno & "<br><br><b>Latitud: </b>" & LatitudUno & "<br><b>Longitud: </b>" & LongitudUno & Chr(34) & vbCrLf
        UrlCoo &= "  });" & vbCrLf
        UrlCoo &= " marker1.addListener('click', function() {" & vbCrLf
        UrlCoo &= "  infowindow1.open(marker1.get('map'), marker1);" & vbCrLf
        UrlCoo &= " });" & vbCrLf



        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaEmpleados.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaEmpleados.HTML")


    End Sub

    Private Sub MapaRefLaborales()

        SegundosDesconexion = 0
        Dim UrlCoo As String = ""
        Dim Numero As Integer = 0
        Dim NumeroSin As Integer = 0
        Dim Title As String = ""


        UrlCoo = "<!DOCTYPE html>" & vbCrLf & _
                "<html>" & vbCrLf & _
                "<head>" & vbCrLf & _
                "<meta http-equiv=" & Chr(34) & "X-UA-Compatible" & Chr(34) & " content=" & Chr(34) & "IE=8" & Chr(34) & ">" & vbCrLf & _
                "<style>" & vbCrLf & _
                "html, body {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "margin: 0;" & vbCrLf & _
                "padding: 0;" & vbCrLf & _
                "}" & vbCrLf & _
                "#map {" & vbCrLf & _
                "height: 100%;" & vbCrLf & _
                "}" & vbCrLf & _
                "</style>" & vbCrLf & _
                "</head>" & vbCrLf & _
                "<body>" & vbCrLf & _
                "<div id=" & Chr(34) & "map" & Chr(34) & "></div>" & vbCrLf & _
                "<script>" & vbCrLf & _
                " function initMap() {" & vbCrLf & _
                "var map = new google.maps.Map(document.getElementById('map'), {" & vbCrLf & _
                "center: {lat:  " & SucursalLAT & ", lng: " & SucursalLON & "}," & vbCrLf & _
                "scrollwheel: true," & vbCrLf & _
                "zoom: 12" & vbCrLf & _
                "});" & vbCrLf

        For Each fila As ListViewItem In Lsv_Lista.Items

            If fila.SubItems(ColLat).Text <> 0 And fila.SubItems(ColLon).Text <> 0 Then
                Numero += 1
                Title = fila.Text

                UrlCoo &= "var marker" & Numero & " = new google.maps.Marker({" & vbCrLf
                UrlCoo &= "map: map," & vbCrLf
                UrlCoo &= "position: {lat: " & fila.SubItems(ColLat).Text & ", lng: " & fila.SubItems(ColLon).Text & "}," & vbCrLf
                UrlCoo &= "title: '" & Title & "'," & vbCrLf
                UrlCoo &= "animation: google.maps.Animation.DROP" & vbCrLf
                UrlCoo &= "});" & vbCrLf
                UrlCoo &= " var infowindow" & Numero & " = new google.maps.InfoWindow({" & vbCrLf
                UrlCoo &= "content: " & Chr(34) & " <h3>" & Title & "</h3>" & Chr(34) & " + " & Chr(34) & "<div id=\" & Chr(34) & "bodyContent\" & Chr(34) & ">" & Chr(34) & " + " & Chr(34) & "<b>Colonia: </b>" & fila.SubItems(6).Text & "<br><b>Ciudad: </b>" & fila.SubItems(7).Text & "<br><br><b>Latitud: </b>" & fila.SubItems(ColLat).Text & "<br><b>Longitud: </b>" & fila.SubItems(ColLon).Text & Chr(34) & vbCrLf
                UrlCoo &= "  });" & vbCrLf
                UrlCoo &= " marker" & Numero & ".addListener('click', function() {" & vbCrLf
                UrlCoo &= "  infowindow" & Numero & ".open(marker" & Numero & ".get('map'), marker" & Numero & ");" & vbCrLf
                UrlCoo &= " });" & vbCrLf

            Else
                NumeroSin += 1
            End If

        Next

        UrlCoo &= "}" & vbCrLf
        UrlCoo &= "</script>" & vbCrLf
        UrlCoo &= "<script src=" & Chr(34) & "https://maps.googleapis.com/maps/api/js?key=" & GoogleMapsKey & "&callback=initMap" & Chr(34) & vbCrLf
        UrlCoo &= "   async defer></script>" & vbCrLf
        UrlCoo &= "</body>" & vbCrLf
        UrlCoo &= "</html>"

        Call CrearArchivoHTML(UrlCoo, Application.StartupPath, "MapaEmpleados.HTML")
        Web_Mapa.Navigate(Application.StartupPath & "/MapaEmpleados.HTML")

        If NumeroSin > 0 Then
            MsgBox("(" & NumeroSin & ") Empresas no Tienen Coordenadas.", MsgBoxStyle.Critical, frm_MENU.Text)
        End If

    End Sub

    Private Sub CrearArchivoHTML(ByVal Texto As String, ByVal RutaDisco As String, ByVal NombreArchivo As String)
        SegundosDesconexion = 0
        Dim sRenglon As String = Nothing
        Dim strStreamW As Stream = Nothing
        Dim strStreamWriter As StreamWriter = Nothing
        Dim ContenidoArchivo As String = Nothing
        Dim PathArchivo As String

        Try
            If Directory.Exists(RutaDisco) = False Then
                Directory.CreateDirectory(RutaDisco)
            End If
            Windows.Forms.Cursor.Current = Cursors.WaitCursor
            PathArchivo = NombreArchivo

            If File.Exists(PathArchivo) Then
                File.Delete(PathArchivo)
            End If
            strStreamW = File.Create(PathArchivo)

            strStreamWriter = New StreamWriter(strStreamW, System.Text.Encoding.Default)
            strStreamWriter.WriteLine(Texto)
            strStreamWriter.Close()

        Catch ex As Exception
            MsgBox("Error al Guardar la información en el archivo." & ex.ToString, MsgBoxStyle.Critical, frm_MENU.Text)
            strStreamWriter.Close()
        End Try
    End Sub

End Class