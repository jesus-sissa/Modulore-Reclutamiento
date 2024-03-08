
Imports System.IO
Imports Microsoft
Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales
    Public Class Frm_Huellas_Prospectos

        Public Id_Empleado As Integer
        Public Clave_EmpleadoP As String
        Private Dt_Huellas As DataTable = New DataTable
        Private TeniaHuellasIMG As Boolean = False
        Private TeniaHuellasZK As Boolean = False
        Dim FMatchType As Integer
        Dim fpcHandle As Integer
        Dim pulgar As Integer = 0

        Private Sub frm_Huellas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
            Try

                'If Huellero.InitEngine = 0 Then


                Huellero.Refresh()

                '    fpcHandle = Huellero.CreateFPCacheDB()

                '    If (Huellero.IsRegister) Then

                '        Huellero.CancelEnroll()
                '    End If

                '    lbl_Status.Text = "Dispositivo Encontrado"
                '    lbl_Status.ForeColor = Color.Green




                Dt_Huellas.Columns.Add("Dedo") 'Dedo que fue Capturado
                Dt_Huellas.Columns.Add("HuellaV9") 'El String Template Versión 9
                Dt_Huellas.Columns.Add("HuellaV10") 'El String Template Versión 10
                Dt_Huellas.Columns.Add("Huella_Imagen") 'Hubicación de la Huella
                Dt_Huellas.Columns.Add("Huella_ImagenB", GetType(Byte())) 'Huella Convertida a Bytes
                Dt_Huellas.Columns.Add("DescargadaBD") 'Si ya existía en la BD o no

                Dim Elim As String = ""
                For I As Integer = 0 To 9
                    Dt_Huellas.Rows.Add(I, "", "", "", Nothing, "N")

                    Elim = fn_ArchivosPath("bin\Archivos\Huella_" & I.ToString & ".jpg")
                    If File.Exists(Elim) Then
                        Try
                            File.Delete(Elim)
                        Catch
                        End Try
                    End If
                Next

                'Leer Huellas -> Imagen
                Dim Dr As DataRow = fn_Empleados_LeerHuellas(Id_Empleado)

                Dim Dedos() As String = {"Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete",
                                "Ocho", "Nueve", "Diez", "Once", "Doce", "Trece", "Catorce",
                                "Quince", "Dieciseis", "Diecisiete", "Dieciocho", "Diecinueve", "Veinte"}

                If Dr IsNot Nothing Then
                    TeniaHuellasIMG = True
                    '-------Convirtiendo las Huellas a Bytes
                    For pos As Integer = 0 To 9
                        If Not IsDBNull(Dr(Dedos(pos))) Then
                            Call Crear_Imagen(pos, Dr(Dedos(pos)))
                            Dt_Huellas(pos)("Huella_ImagenB") = Dr(Dedos(pos))
                        End If
                    Next
                    '--------
                End If

                'Leer HuellasZK -> Template
                Dr = fn_Empleados_LeerHuellasT(Id_Empleado, 0)

                Dim Posicion As Integer = -1

                If Dr IsNot Nothing Then
                    TeniaHuellasZK = True

                    '--Almacenar HuellasZK en DT Temporal (1-10, 2-11, 3-13 ...)
                    For I As Integer = 0 To 9
                        Dt_Huellas(I)("HuellaV9") = Dr(Dedos(I))
                        Dt_Huellas(I)("HuellaV10") = Dr(Dedos(I + 10))
                    Next
                    '----------

                    If Dr("Uno") <> "" AndAlso Dr("Once") <> "" Then
                        Dt_Huellas(0)("DescargadaBD") = "S"
                        'lbl_H0.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 0
                    End If

                    If Dr("Dos") <> "" AndAlso Dr("Doce") <> "" Then
                        Dt_Huellas(1)("DescargadaBD") = "S"
                        'lbl_H1.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 1
                    End If

                    If Dr("Tres") <> "" AndAlso Dr("Trece") <> "" Then
                        Dt_Huellas(2)("DescargadaBD") = "S"
                        'lbl_H2.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 2
                    End If

                    If Dr("Cuatro") <> "" AndAlso Dr("Catorce") <> "" Then
                        Dt_Huellas(3)("DescargadaBD") = "S"
                        'lbl_H3.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 3
                    End If

                    If Dr("Cinco") <> "" AndAlso Dr("Quince") <> "" Then
                        Dt_Huellas(4)("DescargadaBD") = "S"
                        lbl_H4.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 4
                    End If

                    If Dr("Seis") <> "" AndAlso Dr("Dieciseis") <> "" Then
                        Dt_Huellas(5)("DescargadaBD") = "S"
                        lbl_H5.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 5
                    End If

                    If Dr("Siete") <> "" AndAlso Dr("Diecisiete") <> "" Then
                        Dt_Huellas(6)("DescargadaBD") = "S"
                        'lbl_H6.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 6
                    End If

                    If Dr("Ocho") <> "" AndAlso Dr("Dieciocho") <> "" Then
                        Dt_Huellas(7)("DescargadaBD") = "S"
                        'lbl_H7.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 7
                    End If

                    If Dr("Nueve") <> "" AndAlso Dr("Diecinueve") <> "" Then
                        Dt_Huellas(8)("DescargadaBD") = "S"
                        'lbl_H8.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 8
                    End If

                    If Dr("Diez") <> "" AndAlso Dr("Veinte") <> "" Then
                        Dt_Huellas(9)("DescargadaBD") = "S"
                        'lbl_H9.BackColor = Color.DeepSkyBlue
                    ElseIf Posicion = -1 Then
                        Posicion = 9
                    End If
                End If

                Call Posicion_Captura(Posicion)
                'Else
                '    lbl_Status.Text = "Dispositivo NO Encontrado"
                '    lbl_Status.ForeColor = Color.Red
                '    Huellero.FreeFPCacheDBEx(fpcHandle)
                '    Huellero.EndEngine()
                'End If

            Catch ex As Exception
                lbl_Status.Text = ex.Message
                lbl_Status.ForeColor = Color.Red
                If Dt_Huellas IsNot Nothing Then Dt_Huellas.Clear()
            End Try
        End Sub

        Sub Crear_Imagen(ByVal Dedo As Integer, ByVal Huella_B As Byte())
            Dim Ruta As String = fn_ArchivosPath("bin\Archivos\Huella_" & Dedo & ".jpg")
            Try
                If File.Exists(Ruta) Then File.Delete(Ruta)
            Catch
            End Try
            Dim fs As FileStream
            fs = New FileStream(Ruta, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(Huella_B, 0, Huella_B.Length)
            fs.Flush()
            fs.Dispose()
            fs.Close()

            Dt_Huellas(Dedo)("Huella_Imagen") = Ruta
        End Sub

        Private Sub Posicion_Captura(ByVal Posicion As Integer)
            Select Case Posicion
                Case -1, 0
                'Call Iniciar_Captura(lbl_H0)
                Case 1
                'Call Iniciar_Captura(lbl_H1)
                Case 2
                'Call Iniciar_Captura(lbl_H2)
                Case 3
                'Call Iniciar_Captura(lbl_H3)
                Case 4
                    Call Iniciar_Captura(lbl_H4)
                Case 5
                    Call Iniciar_Captura(lbl_H5)
                Case 6
                'Call Iniciar_Captura(lbl_H6)
                Case 7
                'Call Iniciar_Captura(lbl_H7)
                Case 8
                'Call Iniciar_Captura(lbl_H8)
                Case 9
                    'Call Iniciar_Captura(lbl_H9)
            End Select
        End Sub

        Sub Iniciar_Captura(ByVal lbl_Dedo As Label)
            pct_1.BackColor = Color.Gray
            pct_2.BackColor = Color.Gray
            pct_3.BackColor = Color.Gray
            pct_Huella.Tag = Nothing
            pct_Huella.Image = My.Resources.LogoNoDisponible

            Dim Dedo As String = VisualBasic.Right(lbl_Dedo.Name, 1)
            Dim Encontrado As Boolean = False

            Select Case lbl_Dedo.BackColor
                Case Color.Yellow, Color.DeepSkyBlue
                    For Each Con As Control In Me.Controls
                        If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor = Color.LawnGreen Then
                            For Each Row As DataRow In Dt_Huellas.Rows
                                'Regresar al Color anterior, cuando ya se tenía una guardada en BD o apenas capturada a Azul sino a Amarilla
                                If Row("Dedo") = VisualBasic.Right(Con.Name, 1) Then
                                    If (Row("DescargadaBD") = "N" AndAlso (Row("HuellaV9") <> "" OrElse Row("HuellaV10") <> "")) OrElse Row("DescargadaBD") = "S" Then
                                        Con.BackColor = Color.DeepSkyBlue
                                        Encontrado = True
                                        Exit For
                                    ElseIf Row("DescargadaBD") = "N" Then
                                        Con.BackColor = Color.Yellow
                                        Encontrado = True
                                        Exit For
                                    End If
                                End If
                            Next
                            If Encontrado Then Exit For
                        End If
                    Next
                    lbl_Dedo.BackColor = Color.LawnGreen
                    Huellero.EndInit()
                    Huellero.BeginEnroll() '8oct2014

                Case Color.LawnGreen
                    For Each Row As DataRow In Dt_Huellas.Rows
                        'Regresar al Color anterior, cuando ya se tenía una guardada en BD o apenas capturada a Azul sino a Amarilla 
                        If Row("Dedo") = Dedo Then
                            If (Row("DescargadaBD") = "N" AndAlso (Row("HuellaV9") <> "" AndAlso Row("HuellaV10") <> "")) OrElse Row("DescargadaBD") = "S" Then
                                lbl_Dedo.BackColor = Color.DeepSkyBlue
                                Exit For
                            ElseIf Row("DescargadaBD") = "N" Then
                                lbl_Dedo.BackColor = Color.Yellow
                                Exit For
                            End If
                        End If
                    Next
                    Huellero.EndInit()
                    Huellero.CancelEnroll() '8 octubre21014
            End Select
        End Sub

        'Private Sub btn_Ayuda_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Ayuda.Click
        '    SegundosDesconexion = 0

        '    Dim frm As New frm_Ayuda
        '    frm.Ayuda = frm_Ayuda.Query.Huellero
        '    frm.Size = New Size(670, 530)
        '    frm.Show()
        'End Sub

        Private Sub lbl_Dedos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_H4.Click
            SegundosDesconexion = 0
            pulgar = 1
            If Dt_Huellas.Rows.Count = 0 Then Exit Sub
            Call Iniciar_Captura(sender)
        End Sub
        Private Sub lbl_Dedos2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_H5.Click
            SegundosDesconexion = 0
            pulgar = 2
            If Dt_Huellas.Rows.Count = 0 Then Exit Sub
            Call Iniciar_Captura(sender)
        End Sub

        Private Sub Huellero_OnImageReceived(ByVal sender As System.Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnImageReceivedEvent) Handles Huellero.OnImageReceived
            Try
                pct_Huella.Tag = Nothing
                pct_Huella.Image = My.Resources.LogoNoDisponible
                pct_Huella.Refresh()

                If e.aImageValid Then
                    'If lbl_H0.BackColor <> Color.LawnGreen AndAlso lbl_H1.BackColor <> Color.LawnGreen AndAlso
                    'lbl_H2.BackColor <> Color.LawnGreen AndAlso lbl_H3.BackColor <> Color.LawnGreen AndAlso
                    'lbl_H4.BackColor <> Color.LawnGreen AndAlso lbl_H5.BackColor <> Color.LawnGreen AndAlso
                    'lbl_H6.BackColor <> Color.LawnGreen AndAlso lbl_H7.BackColor <> Color.LawnGreen AndAlso
                    'lbl_H8.BackColor <> Color.LawnGreen AndAlso lbl_H9.BackColor <> Color.LawnGreen Then
                    If lbl_H4.BackColor <> Color.LawnGreen AndAlso lbl_H5.BackColor <> Color.LawnGreen Then

                        Huellero.EndInit() 'new
                        Exit Sub
                    End If

                    Dim Ruta As String = fn_ArchivosPath("bin\Archivos\Huella_")
                    For Each Con As Control In Me.Controls
                        If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor = Color.LawnGreen Then
                            Ruta &= VisualBasic.Right(Con.Name, 1) & ".jpg"
                            Try
                                If File.Exists(Ruta) Then File.Delete(Ruta)
                            Catch
                            End Try

                            Huellero.SaveJPG(Ruta)
                            pct_Huella.ImageLocation = Ruta
                            pct_Huella.Refresh()


                            If pct_1.BackColor = Color.Gray Then
                                pct_1.BackColor = Color.Green 'La primer captura
                            ElseIf pct_2.BackColor = Color.Gray Then
                                pct_2.BackColor = Color.Green 'La segunda captura
                            Else
                                pct_Huella.Tag = Ruta
                                pct_3.BackColor = Color.Green 'La tercer captura
                            End If
                            Exit For
                        End If
                    Next
                End If
            Catch ex As Exception
                MsgBox(ex)
                'MsgBox("Ocurrio un error al intentar generar la Imagen de la Huella.", MsgBoxStyle.Critical, frm_MENU.Text)
            End Try


        End Sub

        Private Sub Huellero_OnEnroll(ByVal sender As System.Object, ByVal e As AxZKFPEngXControl.IZKFPEngXEvents_OnEnrollEvent) Handles Huellero.OnEnroll
            Try
                Dim Lectura As String = ""
                Dim ID As Integer = 0, ID2 As Integer = 0, Score As Integer = 0, ProcessNum As Integer = 0



                ' se lee en version que tenga
                'Lectura = Huellero.GetTemplateAsStringEx(Huellero.FPEngineVersion) ' se lee en version que tenga

                'If lbl_H0.BackColor <> Color.LawnGreen AndAlso lbl_H1.BackColor <> Color.LawnGreen AndAlso
                '   lbl_H2.BackColor <> Color.LawnGreen AndAlso lbl_H3.BackColor <> Color.LawnGreen AndAlso
                '   lbl_H4.BackColor <> Color.LawnGreen AndAlso lbl_H5.BackColor <> Color.LawnGreen AndAlso
                '   lbl_H6.BackColor <> Color.LawnGreen AndAlso lbl_H7.BackColor <> Color.LawnGreen AndAlso
                '   lbl_H8.BackColor <> Color.LawnGreen AndAlso lbl_H9.BackColor <> Color.LawnGreen Then
                If lbl_H4.BackColor <> Color.LawnGreen AndAlso lbl_H5.BackColor <> Color.LawnGreen Then
                    Huellero.EndInit() 'new
                    Exit Sub
                End If

                If Not e.actionResult Then
                    MsgBox("La Captura Fallo, intente de nuevo de ingresar la Huella.", MsgBoxStyle.Critical, frm_MENU.Text)
                Else
                    Dim sTempV9 As String = Huellero.GetTemplateAsStringEx("9")
                    Dim sTempV10 As String = Huellero.GetTemplateAsStringEx("10") 'se cambio fn 8/10/2014
                    Dim Encontrado As Boolean = False





                    'For Each Row As DataRow In Dt_Huellas.Rows
                    '    For Each Con As Control In Me.Controls
                    '        If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor <> Color.LawnGreen AndAlso Row("Dedo") = VisualBasic.Right(Con.Name, 1) AndAlso (Row("HuellaV9") <> "" AndAlso Row("HuellaV10") <> "") Then
                    '            'Verificar si la huella se encuentra registrada en ambas versiones
                    '            '-------------8octubre 2014
                    '            Huellero.AddRegTemplateStrToFPCacheDBEx(fpcHandle, 1, Row("HuellaV9"), Row("HuellaV10"))
                    '            ID = Huellero.IdentificationFromStrInFPCacheDB(fpcHandle, Lectura, Score, ProcessNum)
                    '            If ID > 0 Then
                    '                Huellero.RemoveRegTemplateFromFPCacheDBEx(fpcHandle, 1)
                    '                MsgBox("La Huella que esta capturando ya se encuentra registrada en el Dedo: '" & (CInt(Row("Dedo")) + 1).ToString & "'", MsgBoxStyle.Information, frm_MENU.Text)
                    '                Encontrado = True
                    '                Exit For
                    '            End If
                    '            Huellero.RemoveRegTemplateFromFPCacheDBEx(fpcHandle, 1)
                    '            '-------------------------
                    '        End If
                    '    Next
                    '    If Encontrado Then Exit For
                    'Next

                    If Not Encontrado Then
                        Dim fs As System.IO.FileStream = Nothing

                        For Each Con As Control In Me.Controls
                            If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor = Color.LawnGreen Then
                                For Each Row As DataRow In Dt_Huellas.Rows
                                    If Row("Dedo") = VisualBasic.Right(Con.Name, 1) Then
                                        Row("HuellaV9") = sTempV9
                                        Row("HuellaV10") = sTempV10
                                        Row("Huella_Imagen") = pct_Huella.Tag

                                        Huellero.FreeFPCacheDBEx(fpcHandle)
                                        Huellero.EndEngine()

                                        'Convertir la Foto a Bytes
                                        fs = New System.IO.FileStream(Row("Huella_Imagen"), System.IO.FileMode.Open)
                                        Row("Huella_ImagenB") = New Byte(fs.Length - 1) {}
                                        fs.Read(Row("Huella_ImagenB"), 0, Row("Huella_ImagenB").Length)
                                        fs.Close()
                                        fs.Dispose()


                                        '***Guardar la Información***'
                                        'If fn_EmpleadosHuellas_T_Actualizar(Id_Empleado, Dt_Huellas(Row("Dedo")), TeniaHuellasIMG, TeniaHuellasZK) Then
                                        If fn_Add_HuellasProspecto(Clave_EmpleadoP, pulgar, Dt_Huellas(Row("Dedo"))) Then
                                            Row("DescargadaBD") = "S"
                                            Con.BackColor = Color.DeepSkyBlue
                                            Dim Contador As Integer = 0
                                            Dim Num_Dedo As Integer = Row("Dedo")
                                            MsgBox("Huellas Guadadas.", MsgBoxStyle.Information, frm_MENU.Text)

ReiniciarPosicion:                          If Contador > 0 AndAlso Contador < 10 Then
                                                Num_Dedo += 1
                                            ElseIf Contador >= 10 Then
                                                Num_Dedo = 10
                                            End If

                                            Select Case Num_Dedo
                                                Case 0
                                                    'If Not (lbl_H1.BackColor = Color.Yellow) Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(1)
                                                    'End If
                                                Case 1
                                                    'If Not lbl_H2.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(2)
                                                    'End If
                                                Case 2
                                                    'If Not lbl_H3.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(3)
                                                    'End If
                                                Case 3
                                                    If Not lbl_H4.BackColor = Color.Yellow Then
                                                        Contador += 1 : GoTo ReiniciarPosicion
                                                    Else
                                                        Call Posicion_Captura(4)
                                                    End If
                                                Case 4
                                                    If Not lbl_H5.BackColor = Color.Yellow Then
                                                        Contador += 1 : GoTo ReiniciarPosicion
                                                    Else
                                                        Call Posicion_Captura(5)
                                                    End If
                                                Case 5
                                                    'If Not lbl_H6.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(6)
                                                    'End If
                                                Case 6
                                                    'If Not lbl_H7.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(7)
                                                    'End If
                                                Case 7
                                                    'If Not lbl_H8.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(8)
                                                    'End If
                                                Case 8
                                                    'If Not lbl_H9.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(9)
                                                    'End If
                                                Case 9
                                                    'If Not lbl_H0.BackColor = Color.Yellow Then
                                                    '    Contador += 1 : Num_Dedo = -1
                                                    '    GoTo ReiniciarPosicion
                                                    'Else
                                                    '    Call Posicion_Captura(0)
                                                    'End If
                                                Case 10
                                            End Select
                                        Else
                                            'Borrar los Datos Anteriores
                                            Row("HuellaV9") = ""
                                            Row("HuellaV10") = ""
                                            Row("Huella_Imagen") = ""
                                            Row("Huella_ImagenB") = Nothing
                                            Row("DescargadaBD") = "N"
                                            Con.BackColor = Color.Yellow
                                            Call Posicion_Captura(Row("Dedo"))
                                            MsgBox("Ha ocurrido un error al intentar guardar la Lectura de la Huella, intentelo de nuevo.", MsgBoxStyle.Critical, frm_MENU.Text)
                                        End If

                                        Encontrado = True
                                        Exit For
                                    End If
                                Next

                                If Encontrado Then Exit For
                            End If
                        Next
                        fs.Dispose()
                        fs.Close()
                    End If

                End If



                pct_1.BackColor = Color.Gray
                pct_2.BackColor = Color.Gray
                pct_3.BackColor = Color.Gray
                pct_Huella.Tag = Nothing
                pct_Huella.Image = My.Resources.LogoNoDisponible
                'Huellero.EndInit()
                'Huellero.BeginEnroll()

            Catch ex As Exception
                pct_1.BackColor = Color.Gray
                pct_2.BackColor = Color.Gray
                pct_3.BackColor = Color.Gray
                pct_Huella.Tag = Nothing
                pct_Huella.Image = My.Resources.LogoNoDisponible
                Huellero.EndInit()
                MsgBox("Ocurrio un error al leer la Huella.", MsgBoxStyle.Critical, frm_MENU.Text)

            End Try
        End Sub

        Private Sub frm_Huellas_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
            SegundosDesconexion = 0
            If Dt_Huellas.Rows.Count = 0 Then Exit Sub

            Select Case e.KeyData
                Case Keys.F1
                'Call Iniciar_Captura(lbl_H0)

                Case Keys.F2
                'Call Iniciar_Captura(lbl_H1)

                Case Keys.F3
                'Call Iniciar_Captura(lbl_H2)

                Case Keys.F4
                'Call Iniciar_Captura(lbl_H3)

                Case Keys.F5
                    Call Iniciar_Captura(lbl_H4)

                Case Keys.F6
                    Call Iniciar_Captura(lbl_H5)

                Case Keys.F7
                'Call Iniciar_Captura(lbl_H6)

                Case Keys.F8
                'Call Iniciar_Captura(lbl_H7)

                Case Keys.F9
                'Call Iniciar_Captura(lbl_H8)

                Case Keys.F10
                    'Call Iniciar_Captura(lbl_H9)
            End Select
        End Sub

        'Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        '    SegundosDesconexion = 0

        '    'Convertir las Imagenes a Bytes
        '    Dim fs As System.IO.FileStream = Nothing
        '    For Each Row As DataRow In Dt_Huellas.Rows
        '        If Not File.Exists(Row("Huella_Imagen")) OrElse Row("DescargadaBD") = "S" Then Continue For

        '        fs = New System.IO.FileStream(Row("Huella_Imagen"), System.IO.FileMode.Open)
        '        Row("Huella_ImagenB") = New Byte(fs.Length - 1) {}
        '        fs.Read(Row("Huella_ImagenB"), 0, Row("Huella_ImagenB").Length)
        '        fs.Close()
        '    Next
        '    fs.Dispose()

        '    Me.Cursor = Cursors.WaitCursor
        '    If fn_EmpleadosHuellas_T_Actualizar(Id_Empleado, Dt_Huellas, TeniaHuellas, TeniaHuellasT) Then
        '        MsgBox("Se guardaron las Huellas correctamente.", MsgBoxStyle.Information, frm_MENU.Text)
        '        Me.Close()
        '    Else
        '        MsgBox("Ha ocurrido un error al intentar guardar la Lectura de las Huellas.", MsgBoxStyle.Critical, frm_MENU.Text)
        '    End If
        '    Me.Cursor = Cursors.Default
        'End Sub

        'Private Sub btn_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Cerrar.Click
        '    SegundosDesconexion = 0

        '    Me.Close()
        'End Sub

        Private Sub frm_Huellas_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
            If Dt_Huellas Is Nothing Then Exit Sub
            If Dt_Huellas.Rows.Count = 0 Then Exit Sub

            '    'If DialogResult <> Windows.Forms.DialogResult.OK Then
            '    '    Dim ExistenCambios As Boolean = False
            '    '    For Each Con As Control In Me.Controls
            '    '        If VisualBasic.Left(Con.Name, 5) = "lbl_H" Then
            '    '            For Each Row As DataRow In Dt_Huellas.Rows
            '    '                'Regresar al Color anterior, cuando ya se tenía una guardada en BD cambiar a Blanco o apenas capturada a Azul sino a Amarilla
            '    '                If Row("Dedo") = VisualBasic.Right(Con.Name, 1) Then
            '    '                    If Row("DescargadaBD") = "N" AndAlso (Row("HuellaV9") <> "" AndAlso Row("HuellaV10") <> "") Then
            '    '                        ExistenCambios = True
            '    '                        Con.BackColor = Color.DeepSkyBlue
            '    '                    ElseIf Row("DescargadaBD") = "N" Then
            '    '                        Con.BackColor = Color.Yellow
            '    '                    ElseIf Row("DescargadaBD") = "S" Then
            '    '                        Con.BackColor = Color.White
            '    '                    End If
            '    '                End If
            '    '            Next
            '    '        End If
            '    '    Next
            '    '    Try
            '    '        Huellero.EndEngine()
            '    '        Huellero.CancelEnroll()
            '    '    Catch
            '    '    End Try
            '    '    If ExistenCambios AndAlso MsgBox("Los cambios realizados no se guardarán, seguro que desae salir?.", MsgBoxStyle.Question + MsgBoxStyle.YesNo, frm_MENU.Text) = MsgBoxResult.No Then
            '    '        e.Cancel = True
            '    '        Exit Sub
            '    '    End If
            '    'End If

            Huellero.Dispose()
            For Each Row In Dt_Huellas.Rows
                If File.Exists(Row("Huella_Imagen")) Then
                    Try
                        File.Delete(Row("Huella_Imagen"))
                    Catch
                    End Try
                End If
            Next
            DialogResult = DialogResult.OK
            SegundosDesconexion = 0
        End Sub

        Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_conectarSensor.Click
            Conectarsensor()

        End Sub

        Sub TransaccioHuella()
            Try


                pct_Huella.Tag = Nothing
                pct_Huella.Image = My.Resources.LogoNoDisponible

                Dim Ruta As String = fn_ArchivosPath("bin\Archivos\Huella_")
                For Each Con As Control In Me.Controls
                    If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor = Color.LawnGreen Then
                        Ruta &= VisualBasic.Right(Con.Name, 1) & ".jpg"
                        Try
                            If File.Exists(Ruta) Then File.Delete(Ruta)
                        Catch
                        End Try

                        Huellero.SaveJPG(Ruta)
                        pct_Huella.ImageLocation = Ruta
                        pct_Huella.Refresh()


                        If pct_1.BackColor = Color.Gray Then
                            pct_1.BackColor = Color.Green 'La primer captura
                        ElseIf pct_2.BackColor = Color.Gray Then
                            pct_2.BackColor = Color.Green 'La segunda captura
                        Else
                            pct_Huella.Tag = Ruta
                            pct_3.BackColor = Color.Green 'La tercer captura
                        End If


                        Exit For
                    End If
                Next

            Catch ex As Exception

                MsgBox("Ocurrio un error al intentar generar la Imagen de la Huella.", MsgBoxStyle.Critical, frm_MENU.Text)
            End Try


            Try
                Dim sTempV9 As String = Huellero.GetTemplateAsStringEx("9")
                Dim sTempV10 As String = Huellero.GetTemplateAsStringEx("10") 'se cambio fn 8/10/2014
                Dim Encontrado As Boolean = False


                If Not Encontrado Then
                    Dim fs As System.IO.FileStream = Nothing

                    For Each Con As Control In Me.Controls
                        If VisualBasic.Left(Con.Name, 5) = "lbl_H" AndAlso Con.BackColor = Color.LawnGreen Then
                            For Each Row As DataRow In Dt_Huellas.Rows
                                If Row("Dedo") = VisualBasic.Right(Con.Name, 1) Then
                                    Row("HuellaV9") = sTempV9
                                    Row("HuellaV10") = sTempV9
                                    Row("Huella_Imagen") = pct_Huella.Tag


                                    'Convertir la Foto a Bytes
                                    fs = New System.IO.FileStream(Row("Huella_Imagen"), System.IO.FileMode.Open)
                                    Row("Huella_ImagenB") = New Byte(fs.Length - 1) {}
                                    fs.Read(Row("Huella_ImagenB"), 0, Row("Huella_ImagenB").Length)
                                    fs.Close()



                                    '***Guardar la Información***'
                                    'If fn_EmpleadosHuellas_T_Actualizar(Id_Empleado, Dt_Huellas(Row("Dedo")), TeniaHuellasIMG, TeniaHuellasZK) Then
                                    If fn_Add_HuellasProspecto(Clave_EmpleadoP, pulgar, Dt_Huellas(Row("Dedo"))) Then
                                        Row("DescargadaBD") = "S"
                                        Con.BackColor = Color.DeepSkyBlue
                                        Dim Contador As Integer = 0
                                        Dim Num_Dedo As Integer = Row("Dedo")
                                        MsgBox("<----Huella Registrada---->", MsgBoxStyle.Information, frm_MENU.Text)

ReiniciarPosicion:                      If Contador > 0 AndAlso Contador < 10 Then
                                            Num_Dedo += 1
                                        ElseIf Contador >= 10 Then
                                            Num_Dedo = 10
                                        End If

                                        Select Case Num_Dedo
                                            Case 0
                                            'If Not (lbl_H1.BackColor = Color.Yellow) Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(1)
                                            'End If
                                            Case 1
                                            'If Not lbl_H2.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(2)
                                            'End If
                                            Case 2
                                            'If Not lbl_H3.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(3)
                                            'End If
                                            Case 3
                                                If Not lbl_H4.BackColor = Color.Yellow Then
                                                    Contador += 1 : GoTo ReiniciarPosicion
                                                Else
                                                    Call Posicion_Captura(4)
                                                End If
                                            Case 4
                                                If Not lbl_H5.BackColor = Color.Yellow Then
                                                    Contador += 1 : GoTo ReiniciarPosicion
                                                Else
                                                    Call Posicion_Captura(5)
                                                End If
                                            Case 5
                                            'If Not lbl_H6.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(6)
                                            'End If
                                            Case 6
                                            'If Not lbl_H7.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(7)
                                            'End If
                                            Case 7
                                            'If Not lbl_H8.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(8)
                                            'End If
                                            Case 8
                                            'If Not lbl_H9.BackColor = Color.Yellow Then
                                            '    Contador += 1 : GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(9)
                                            'End If
                                            Case 9
                                            'If Not lbl_H0.BackColor = Color.Yellow Then
                                            '    Contador += 1 : Num_Dedo = -1
                                            '    GoTo ReiniciarPosicion
                                            'Else
                                            '    Call Posicion_Captura(0)
                                            'End If
                                            Case 10
                                        End Select
                                    Else
                                        'Borrar los Datos Anteriores
                                        Row("HuellaV9") = ""
                                        Row("HuellaV10") = ""
                                        Row("Huella_Imagen") = ""
                                        Row("Huella_ImagenB") = Nothing
                                        Row("DescargadaBD") = "N"
                                        Con.BackColor = Color.Yellow
                                        Call Posicion_Captura(Row("Dedo"))
                                        MsgBox("Ha ocurrido un error al intentar guardar la Lectura de la Huella, intentelo de nuevo.", MsgBoxStyle.Critical, frm_MENU.Text)
                                    End If

                                    Encontrado = True
                                    Exit For
                                End If
                            Next

                            If Encontrado Then Exit For
                        End If
                    Next

                    'fs.Close()
                End If

            Catch ex As Exception

            End Try

            Conectarsensor()

        End Sub
        Sub Conectarsensor()

            If Huellero.InitEngine = 0 Then



                fpcHandle = Huellero.CreateFPCacheDB()

                If (Huellero.IsRegister) Then

                    Huellero.CancelEnroll()
                End If

                lbl_Status.Text = "Dispositivo Encontrado"
                lbl_Status.ForeColor = Color.Green



            Else
                Huellero.EndEngine()

                MsgBox("Initial Failed!. Error", MsgBoxStyle.Critical, frm_MENU.Text)
            End If



        End Sub

        Private Sub pct_3_BackColorChanged(sender As Object, e As EventArgs) Handles pct_3.BackColorChanged
            If pct_1.BackColor = Color.Green Then
                If pct_2.BackColor = Color.Green Then
                    If pct_3.BackColor = Color.Green Then

                        Call TransaccioHuella()
                    End If
                End If
            End If

        End Sub


    Private Sub btn_Cerrar_Click(sender As Object, e As EventArgs) Handles btn_Cerrar.Click
            Me.Close()

        End Sub

    End Class