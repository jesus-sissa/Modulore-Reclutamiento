Imports System.Windows.Forms

Public Class frm_NotificacionAlertas

    Public Indice As Integer
    Public IndiceArreglo As Integer
    Public Clave As String
    Public Tipo As Cn_Notificaciones.TipoAlerta
    Public Id_Alerta As Integer

    Private IsLoading As Boolean = True
    Private IsVisible As Boolean = False
    Private IsClosing As Boolean = False
    

    Private Sub frmNotification_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Left = (SystemInformation.WorkingArea.Size.Width - Size.Width)
        Top = (SystemInformation.WorkingArea.Size.Height - Size.Height) - (Indice * Size.Height)
        If Top < 0 Then
            Indice = Indice - 8
            Left = (SystemInformation.WorkingArea.Size.Width - Size.Width * 2)
            Top = (SystemInformation.WorkingArea.Size.Height - Size.Height) - (Indice * Size.Height)
        End If
    End Sub

    Private Sub myTimer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles myTimer.Tick
        If IsLoading Then
            FadeIn()
        ElseIf IsVisible Then
            Opacity = 1
            IsLoading = False
            IsVisible = True
            IsClosing = False
            myTimer.Enabled = False
            'If Tipo = FuncionesGlobales.TipoAlerta.Critica Then
            '    Opacity = 1
            '    IsLoading = False
            '    IsVisible = True
            '    IsClosing = False
            '    myTimer.Enabled = False
            'Else
            '    IsVisible = False
            '    IsClosing = True
            '    myTimer.Interval = 100
            'End If
        ElseIf IsClosing Then
            FadeDown()
        End If
    End Sub

    Private Sub FadeIn()
        If (Opacity < 0.99) Then
            Opacity = (Opacity + 0.05)
            Update()
        Else
            IsLoading = False
            IsVisible = True
            myTimer.Interval = 3000
        End If
    End Sub

    Private Sub FadeDown()
        If (Opacity > 0.01) Then
            Opacity = (Opacity - 0.05)
            Update()
        Else
            'ArregloAlertas.Remove(CDec(IndiceArreglo))
            Me.Close()
            Me.Dispose()
        End If
    End Sub

    'Private Sub NotificationMouseEnter(ByVal sender As Object, ByVal e As EventArgs) Handles lbl_Titulo.MouseEnter, lbl_Mensaje.MouseEnter
    '    Opacity = 1
    '    IsLoading = False
    '    IsVisible = True
    '    IsClosing = False
    '    myTimer.Interval = 3000
    '    myTimer.Enabled = False
    'End Sub

    Private Sub NotificationMouseLeave(ByVal sender As Object, ByVal e As EventArgs) Handles lbl_Titulo.MouseLeave
        myTimer.Enabled = True
    End Sub

    Private Sub lbl_Detalles_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Detalles.Click
        Dim frm As New frm_NotificacionAlertasD
        frm.Id_Alerta = Id_Alerta
        frm.Descripcion_Alerta = lbl_Titulo.Text
        frm.ShowDialog()
    End Sub

    Private Sub lbl_Atendida_MouseEnter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Atendida.MouseEnter, lbl_Cerrar.MouseEnter, lbl_Detalles.MouseEnter
        Me.Cursor = Cursors.Hand
    End Sub

    Private Sub lbl_Atendida_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Atendida.MouseLeave, lbl_Cerrar.MouseLeave, lbl_Detalles.MouseLeave
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub lbl_Atendida_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles lbl_Atendida.Click
        'marcar la alerta como atendida
        Cn_Notificaciones.fn_AlertasAtender(Clave, "")
        'Eliminar la Alerta del Arreglo
        ArregloAlertas.Remove(Clave)
        'Me.Close()
        IsVisible = False
        IsClosing = True
        myTimer.Enabled = True
        myTimer.Interval = 100
        FadeDown()
    End Sub

    Private Sub lbl_Cerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lbl_Cerrar.Click
        myTimer.Enabled = True
        'Eliminar la Alerta del Arreglo para que en la siguiente vuelta se vuelva a mostrar
        ArregloAlertas.Remove(Clave)
        'Me.Close()
        IsVisible = False
        IsClosing = True
        myTimer.Enabled = True
        myTimer.Interval = 100
        FadeDown()
    End Sub
End Class