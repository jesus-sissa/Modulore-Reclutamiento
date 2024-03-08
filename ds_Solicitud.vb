Partial Class ds_Solicitud
    'Partial Class dt_cursosDataTable

    '    Private Sub dt_cursosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
    '    End FinalizadoSub

    'End Class

    Partial Class dt_IengresosDataTable

        Private Sub dt_IengresosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Valor_ViviendaColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class dt_EmpleoAnt1DataTable

        Private Sub dt_EmpleoAnt1DataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.DomicilioColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

    End Class

    Partial Class Dt_RasgosDataTable

        Private Sub Dt_RasgosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
        End Sub

    End Class

    Partial Class Dt_PadreDataTable

        Private Sub Dt_PadreDataTable_Dt_PadreRowChanging(ByVal sender As System.Object, ByVal e As Dt_PadreRowChangeEvent) Handles Me.Dt_PadreRowChanging

        End Sub

    End Class

    Partial Class Dt_DatosFDataTable

        Private Sub Dt_DatosFDataTable_Dt_DatosFRowChanging(ByVal sender As System.Object, ByVal e As Dt_DatosFRowChangeEvent) Handles Me.Dt_DatosFRowChanging

        End Sub

    End Class

    Partial Class dt_DatosDataTable

        Private Sub dt_DatosDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Id_EmpleadoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub dt_DatosDataTable_dt_DatosRowChanging(ByVal sender As System.Object, ByVal e As dt_DatosRowChangeEvent) Handles Me.dt_DatosRowChanging

        End Sub

    End Class

    Partial Class dt_SolicitudDataTable

        Private Sub dt_SolicitudDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.Id_EmpleadoColumn.ColumnName) Then
                'Agregar código de usuario aquí
            End If

        End Sub

        Private Sub dt_SolicitudDataTable_dt_SolicitudRowChanging(ByVal sender As System.Object, ByVal e As dt_SolicitudRowChangeEvent) Handles Me.dt_SolicitudRowChanging

        End Sub

    End Class

End Class
