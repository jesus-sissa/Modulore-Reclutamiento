<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CredencialesAutorizacion
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.Gbx_Principal = New System.Windows.Forms.GroupBox
        Me.gbx_Internos = New System.Windows.Forms.GroupBox
        Me.lbl_Cuenta = New System.Windows.Forms.Label
        Me.rdb_Externo = New System.Windows.Forms.RadioButton
        Me.rdb_Interno = New System.Windows.Forms.RadioButton
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.Lbl_DobleClick = New System.Windows.Forms.Label
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ConfigPrint = New System.Windows.Forms.Button
        Me.btn_Detalle = New System.Windows.Forms.Button
        Me.btn_Entregar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Principal.SuspendLayout()
        Me.gbx_Internos.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Principal
        '
        Me.Gbx_Principal.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Principal.Controls.Add(Me.gbx_Internos)
        Me.Gbx_Principal.Controls.Add(Me.Lbl_DobleClick)
        Me.Gbx_Principal.Controls.Add(Me.btn_Buscar)
        Me.Gbx_Principal.Controls.Add(Me.tbx_Buscar)
        Me.Gbx_Principal.Controls.Add(Me.lbl_Buscar)
        Me.Gbx_Principal.Location = New System.Drawing.Point(5, 2)
        Me.Gbx_Principal.Name = "Gbx_Principal"
        Me.Gbx_Principal.Size = New System.Drawing.Size(774, 496)
        Me.Gbx_Principal.TabIndex = 0
        Me.Gbx_Principal.TabStop = False
        '
        'gbx_Internos
        '
        Me.gbx_Internos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Internos.Controls.Add(Me.lbl_Cuenta)
        Me.gbx_Internos.Controls.Add(Me.rdb_Externo)
        Me.gbx_Internos.Controls.Add(Me.rdb_Interno)
        Me.gbx_Internos.Controls.Add(Me.lsv_Catalogo)
        Me.gbx_Internos.Location = New System.Drawing.Point(9, 47)
        Me.gbx_Internos.Name = "gbx_Internos"
        Me.gbx_Internos.Size = New System.Drawing.Size(748, 415)
        Me.gbx_Internos.TabIndex = 9
        Me.gbx_Internos.TabStop = False
        Me.gbx_Internos.Text = "Empleados"
        '
        'lbl_Cuenta
        '
        Me.lbl_Cuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Cuenta.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Cuenta.ForeColor = System.Drawing.Color.Black
        Me.lbl_Cuenta.Location = New System.Drawing.Point(549, 18)
        Me.lbl_Cuenta.Name = "lbl_Cuenta"
        Me.lbl_Cuenta.Size = New System.Drawing.Size(193, 17)
        Me.lbl_Cuenta.TabIndex = 29
        Me.lbl_Cuenta.Text = "0 Registros"
        Me.lbl_Cuenta.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb_Externo
        '
        Me.rdb_Externo.AutoSize = True
        Me.rdb_Externo.Location = New System.Drawing.Point(87, 18)
        Me.rdb_Externo.Name = "rdb_Externo"
        Me.rdb_Externo.Size = New System.Drawing.Size(66, 17)
        Me.rdb_Externo.TabIndex = 28
        Me.rdb_Externo.TabStop = True
        Me.rdb_Externo.Text = "Externos"
        Me.rdb_Externo.UseVisualStyleBackColor = True
        '
        'rdb_Interno
        '
        Me.rdb_Interno.AutoSize = True
        Me.rdb_Interno.Location = New System.Drawing.Point(13, 18)
        Me.rdb_Interno.Name = "rdb_Interno"
        Me.rdb_Interno.Size = New System.Drawing.Size(63, 17)
        Me.rdb_Interno.TabIndex = 27
        Me.rdb_Interno.TabStop = True
        Me.rdb_Interno.Text = "Internos"
        Me.rdb_Interno.UseVisualStyleBackColor = True
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.CheckBoxes = True
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 41)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 18
        Me.lsv_Catalogo.Row3 = 12
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 7
        Me.lsv_Catalogo.Row6 = 7
        Me.lsv_Catalogo.Row7 = 18
        Me.lsv_Catalogo.Row8 = 20
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(736, 368)
        Me.lsv_Catalogo.TabIndex = 7
        Me.lsv_Catalogo.Tag = "Id_TipoParentesco"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Lbl_DobleClick
        '
        Me.Lbl_DobleClick.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_DobleClick.AutoSize = True
        Me.Lbl_DobleClick.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_DobleClick.Location = New System.Drawing.Point(6, 475)
        Me.Lbl_DobleClick.Name = "Lbl_DobleClick"
        Me.Lbl_DobleClick.Size = New System.Drawing.Size(366, 13)
        Me.Lbl_DobleClick.TabIndex = 8
        Me.Lbl_DobleClick.Text = "Haga Doble Click en un elemento para ver el detalle e Imprimir."
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(617, 19)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 6
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(68, 21)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(543, 20)
        Me.tbx_Buscar.TabIndex = 5
        Me.tbx_Buscar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(19, 24)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 4
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ConfigPrint)
        Me.Gbx_Botones.Controls.Add(Me.btn_Detalle)
        Me.Gbx_Botones.Controls.Add(Me.btn_Entregar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 504)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(774, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_ConfigPrint
        '
        Me.btn_ConfigPrint.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ConfigPrint.Location = New System.Drawing.Point(447, 14)
        Me.btn_ConfigPrint.Name = "btn_ConfigPrint"
        Me.btn_ConfigPrint.Size = New System.Drawing.Size(140, 30)
        Me.btn_ConfigPrint.TabIndex = 9
        Me.btn_ConfigPrint.Text = "Configurar Impresora"
        Me.btn_ConfigPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConfigPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ConfigPrint.UseVisualStyleBackColor = True
        '
        'btn_Detalle
        '
        Me.btn_Detalle.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Detalle.Enabled = False
        Me.btn_Detalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.CredencialDetalle
        Me.btn_Detalle.Location = New System.Drawing.Point(9, 14)
        Me.btn_Detalle.Name = "btn_Detalle"
        Me.btn_Detalle.Size = New System.Drawing.Size(140, 30)
        Me.btn_Detalle.TabIndex = 8
        Me.btn_Detalle.Text = "&Detalle"
        Me.btn_Detalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Detalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Detalle.UseVisualStyleBackColor = True
        '
        'btn_Entregar
        '
        Me.btn_Entregar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Entregar.Enabled = False
        Me.btn_Entregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.ok
        Me.btn_Entregar.Location = New System.Drawing.Point(301, 14)
        Me.btn_Entregar.Name = "btn_Entregar"
        Me.btn_Entregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Entregar.TabIndex = 7
        Me.btn_Entregar.Text = "&Entregada"
        Me.btn_Entregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Entregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Entregar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.cancelar1A
        Me.btn_Cancelar.Location = New System.Drawing.Point(155, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 6
        Me.btn_Cancelar.Text = "&Cancelar Cred"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_CredencialesAutorizacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Principal)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_CredencialesAutorizacion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir, Cancelar y Entregar Credenciales"
        Me.Gbx_Principal.ResumeLayout(False)
        Me.Gbx_Principal.PerformLayout()
        Me.gbx_Internos.ResumeLayout(False)
        Me.gbx_Internos.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Principal As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Entregar As System.Windows.Forms.Button
    Friend WithEvents Lbl_DobleClick As System.Windows.Forms.Label
    Friend WithEvents btn_Detalle As System.Windows.Forms.Button
    Friend WithEvents btn_ConfigPrint As System.Windows.Forms.Button
    Friend WithEvents gbx_Internos As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_Externo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Interno As System.Windows.Forms.RadioButton
    Friend WithEvents lbl_Cuenta As System.Windows.Forms.Label
End Class
