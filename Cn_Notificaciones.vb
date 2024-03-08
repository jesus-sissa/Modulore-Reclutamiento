
Public Class Cn_Notificaciones

    Public Enum TipoAlerta As Byte
        Critica = 1
        Advertencia = 2
        Informacion = 3
    End Enum

    Public Shared Function fn_ChecarAlertas() As DataTable
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_Read", CommandType.StoredProcedure, cnn)
        Cn_Datos.Crea_Parametro(cmd, "@UsuarioId", SqlDbType.Int, UsuarioId) 'Destino
        Cn_Datos.Crea_Parametro(cmd, "@Status", SqlDbType.VarChar, "A")
        Dim Tbl As DataTable = Cn_Datos.EjecutaConsulta(cmd)

        Return Tbl

    End Function

    Public Shared Function fn_AlertasDetalle_LlenarLista(ByVal lsv As cp_Listview, ByVal Id_Alerta As Integer) As Boolean
        Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
        Try
            Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradasD_Get", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Id_Alerta", SqlDbType.Int, Id_Alerta)
            lsv.Actualizar(cmd, "Id_Entidad")

            Return True
        Catch ex As Exception
            FuncionesGlobales.TrataEx(ex)
            Return False
        End Try

    End Function

    Public Shared Function fn_AlertasAtender(ByVal Clave_AlertaTipo As String, ByVal Notas_Atencion As String) As Boolean
        Try
            Dim cnn As SqlClient.SqlConnection = Cn_Datos.Crea_ConexionSTD
            Dim cmd As SqlClient.SqlCommand = Cn_Datos.Crea_Comando("Cat_AlertasGeneradas_AtenderByClave", CommandType.StoredProcedure, cnn)
            Cn_Datos.Crea_Parametro(cmd, "@Clave_AlertaTipo", SqlDbType.VarChar, Clave_AlertaTipo)
            Cn_Datos.Crea_Parametro(cmd, "@Usuario_Valida", SqlDbType.Int, UsuarioId)
            Cn_Datos.Crea_Parametro(cmd, "@Estacion_Valida", SqlDbType.VarChar, EstacioN)
            Cn_Datos.Crea_Parametro(cmd, "@Notas_Atencion", SqlDbType.VarChar, Notas_Atencion)

            Dim cant As Integer = Cn_Datos.EjecutarNonQuery(cmd)

            Return True
        Catch
            Return False
        End Try

    End Function

    'Public Shared Function fn_MostrarAlertas()

    '    Dim Tabla As DataTable
    '    Dim Indice As Integer = -1
    '    Tabla = fn_ChecarAlertas()
    '    Try
    '        For cont = 0 To Tabla.Rows.Count - 1
    '            If ArregloAlertas.Contains(Tabla.Rows(cont)("Clave")) Then
    '                Continue For
    '            End If
    '            Indice += 1
    '            ArregloAlertas.Add(Tabla.Rows(cont)("Clave"))

    '            Dim frm As New frm_NotificacionAlertas

    '            frm.IndiceArreglo = Tabla.Rows(cont)("Alerta")
    '            frm.Id_Alerta = Tabla.Rows(cont)("Alerta")
    '            frm.lbl_Titulo.Text = Tabla.Rows(cont)("Descripcion")
    '            frm.lbl_Mensaje.Text = Tabla.Rows(cont)("Detalles")
    '            frm.Indice = Indice
    '            frm.Tipo = Tabla.Rows(cont)("TipoAlerta")
    '            frm.Clave = Tabla.Rows(cont)("Clave")
    '            frm.lbl_Cerrar.Visible = True
    '            If Tabla.Rows(cont)("TieneDetalle") = "S" Then
    '                frm.lbl_Detalles.Visible = True
    '            Else
    '                frm.lbl_Detalles.Visible = False
    '            End If

    '            Select Case (Tabla.Rows(cont)("TipoAlerta"))
    '                Case TipoAlerta.Critica
    '                    frm.BackColor = Color.Firebrick
    '                Case TipoAlerta.Advertencia
    '                    frm.BackColor = Color.Goldenrod
    '                Case TipoAlerta.Informacion
    '                    frm.BackColor = Color.LightGreen
    '            End Select

    '            frm.Show()

    '        Next
    '        Return True
    '    Catch ex As Exception
    '        FuncionesGlobales.TrataEx(ex)
    '        Return False
    '    End Try

    'End Function

End Class
