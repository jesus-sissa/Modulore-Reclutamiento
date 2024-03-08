﻿Imports System.IO
Imports Modulo_Reclutamiento.FuncionesGlobales

Public Class frm_Ayuda

    Public Ayuda As Query = Query.Huellero

    <Flags()> Enum Query As Byte
        Huellero
        Reloj
        RelojConsulta
    End Enum

    Private Sub frm_Ayuda_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim sPath As String = ""
        Select Case Ayuda
            Case Query.Huellero
                sPath = fn_ArchivosPath("Archivos\frm_Huellero.txt")

            Case Query.Reloj
                sPath = fn_ArchivosPath("Archivos\frm_Reloj.txt")

            Case Query.RelojConsulta
                sPath = fn_ArchivosPath("Archivos\frm_RelojConsulta.txt")

        End Select

        Try
            If File.Exists(sPath) Then
                rtb_Ayuda.Text = File.ReadAllText(sPath)
            Else
                MsgBox("No se pudo cargar la Ayuda.", MsgBoxStyle.Information, frm_MENU.Text)
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("No se pudo cargar la Ayuda.", MsgBoxStyle.Information, frm_MENU.Text)
            Me.Close()
        End Try
    End Sub

    Private Sub lbl_Salir_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_Salir.MouseDown
        If e.Button = Windows.Forms.MouseButtons.Left Then
            lbl_Salir.Capture = False

            'Crear y mandar un WM_NCLBUTTONDOWN mensaje (es el mensaje mandado para cambiar la posición de la ventana).
            Const WM_NCLBUTTONDOWN As Integer = &HA1
            Const HTCAPTION As Integer = &H2
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTCAPTION), IntPtr.Zero)
            Me.DefWndProc(msg)
        End If
    End Sub

    Private Sub lbl_Salir_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Salir.MouseEnter
        Me.Cursor = Cursors.SizeAll
    End Sub

    Private Sub lbl_Resize_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Resize.MouseLeave, lbl_Salir.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lbl_Resize_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Resize.MouseEnter
        Me.Cursor = Cursors.SizeNWSE
    End Sub

    Private Sub lbl_Resize_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles lbl_Resize.MouseDown
        If e.Button = MouseButtons.Left Then
            lbl_Resize.Text = "+"
            lbl_Resize.Capture = False

            'Crear y mandar un WM_NCLBUTTONDOWN mensaje (es el mensaje mandado para cambiar el tamaño de la ventana).
            Const WM_NCLBUTTONDOWN As Integer = &HA1S
            Const HTBOTTOMRIGHT As Integer = 17
            Dim msg As Message = Message.Create(Me.Handle, WM_NCLBUTTONDOWN, New IntPtr(HTBOTTOMRIGHT), IntPtr.Zero)
            Me.DefWndProc(msg)
            lbl_Resize.Text = "="
        End If
    End Sub

    Private Sub rtb_Ayuda_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles rtb_Ayuda.MouseMove
        SegundosDesconexion = 0
    End Sub

    Private Sub frm_rtb_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles MyBase.KeyPress, rtb_Ayuda.KeyPress
        If Asc(e.KeyChar) = Keys.Escape Then
            SegundosDesconexion = 0
            Me.Close()
        End If
    End Sub

    Private Sub pct_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles pct_Cerrar.Click
        SegundosDesconexion = 0

        Me.Close()
    End Sub

End Class