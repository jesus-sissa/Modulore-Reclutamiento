Imports Modulo_Reclutamiento.Cn_Reclutamiento
Imports Modulo_Reclutamiento.FuncionesGlobales
Imports Microsoft.Office.Interop
Public Class frm_SSP
    Private Sub Btn_Mostrar_Click(sender As Object, e As EventArgs)


    End Sub
    Sub Consultar()
        Dim tbl As New DataTable
        Dim tipo As Integer = 0
        Dim registro As Integer
        Dim cartilla As Integer


        If (chk_admin.Checked) Then
            tipo = 1
        ElseIf (chk_operativo.Checked) Then
            tipo = 2
        Else
            tipo = 0
        End If


        If (chk_federal.Checked And chk_estatal.Checked) Then
            registro = 3
        ElseIf (chk_estatal.Checked) Then
            registro = 2
        ElseIf (chk_federal.Checked) Then
            registro = 1
        Else
            registro = 0
        End If

        If (chk_positiva.Checked) Then
            cartilla = 1
        ElseIf (chk_negativa.Checked) Then
            cartilla = 2
        Else
            cartilla = 0
        End If

        tbl = fn_ReporteSSP(tipo, registro, cartilla)
        DataGridView1.DataSource = tbl
        lbl_total.Text = "Registros: " + (DataGridView1.Rows.Count - 1).ToString
        btn_Exportar.Enabled = tbl.Rows.Count
    End Sub

    Private Sub frm_SSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Consultar()
    End Sub

    Private Sub chk_admin_CheckedChanged(sender As Object, e As EventArgs) Handles chk_admin.CheckedChanged
        If (chk_admin.Checked) Then
            chk_operativo.Checked = False
            Consultar()
        ElseIf (chk_admin.Checked = False And chk_operativo.Checked = False) Then
            Consultar()
        End If

    End Sub

    Private Sub chk_operativo_CheckedChanged(sender As Object, e As EventArgs) Handles chk_operativo.CheckedChanged
        If (chk_operativo.Checked) Then
            chk_admin.Checked = False
            Consultar()
        ElseIf (chk_admin.Checked = False And chk_operativo.Checked = False) Then
            Consultar()
        End If

    End Sub

    Private Sub chk_positiva_CheckedChanged(sender As Object, e As EventArgs) Handles chk_positiva.CheckedChanged

        If (chk_positiva.Checked) Then
            chk_negativa.Checked = False
            Consultar()
        ElseIf (chk_positiva.Checked = False And chk_negativa.Checked = False) Then
            Consultar()
        End If

    End Sub

    Private Sub chk_negativa_CheckedChanged(sender As Object, e As EventArgs) Handles chk_negativa.CheckedChanged
        If (chk_negativa.Checked) Then
            chk_positiva.Checked = False
            Consultar()
        ElseIf (chk_positiva.Checked = False And chk_negativa.Checked = False) Then
            Consultar()
        End If
    End Sub

    Private Sub chk_federal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_federal.CheckedChanged
        Consultar()
    End Sub

    Private Sub chk_estatal_CheckedChanged(sender As Object, e As EventArgs) Handles chk_estatal.CheckedChanged
        Consultar()
    End Sub

    Private Sub btn_Exportar_Click(sender As Object, e As EventArgs) Handles btn_Exportar.Click
        GridAExcel(DataGridView1)
    End Sub
    Function GridAExcel(ByVal miDataGridView As DataGridView) As Boolean
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            exLibro = exApp.Workbooks.Add 'crea el libro de excel
            exHoja = exLibro.Worksheets.Add()
            'cuenta filas y columnas
            Dim NCol As Integer = miDataGridView.ColumnCount
            Dim NRow As Integer = miDataGridView.RowCount

            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = miDataGridView.Columns(i - 1).Name.ToString
            Next

            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = miDataGridView.Rows(Fila).Cells(Col).Value
                Next
            Next


            exHoja.Rows.Item(1).Font.Bold = 1 'titulo en negritas
            exHoja.Rows.Item(1).HorizontalAlignment = 3 'alineación al centro
            exHoja.Columns.AutoFit() 'autoajuste de la columna
            exHoja.Columns.HorizontalAlignment = 2

            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function
End Class