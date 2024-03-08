<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UnidadesMedicoFamiliares
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
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl
        Me.tab_Listado = New System.Windows.Forms.TabPage
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.lbl_CP = New System.Windows.Forms.Label
        Me.lbl_NumUMF = New System.Windows.Forms.Label
        Me.lbl_Municipio = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_CP = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_UMF = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Municipio = New Modulo_Reclutamiento.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.Tab_Nuevo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 623)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Numero)
        Me.tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.Lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 597)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(546, 30)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 30
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(8, 559)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 4
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 559)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 6
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(154, 559)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 5
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Buscar
        Me.btn_Buscar.Location = New System.Drawing.Point(631, 4)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "B&uscar"
        Me.btn_Buscar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Me.btn_Buscar
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 7)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Lbl_Buscar
        '
        Me.Lbl_Buscar.AutoSize = True
        Me.Lbl_Buscar.Location = New System.Drawing.Point(8, 10)
        Me.Lbl_Buscar.Name = "Lbl_Buscar"
        Me.Lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.Lbl_Buscar.TabIndex = 0
        Me.Lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 56)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 5
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 50
        Me.lsv_Catalogo.Row3 = 8
        Me.lsv_Catalogo.Row4 = 0
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(760, 498)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.lbl_CP)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_NumUMF)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Municipio)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_CP)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_UMF)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Municipio)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(776, 597)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'lbl_CP
        '
        Me.lbl_CP.AutoSize = True
        Me.lbl_CP.Location = New System.Drawing.Point(77, 99)
        Me.lbl_CP.Name = "lbl_CP"
        Me.lbl_CP.Size = New System.Drawing.Size(27, 13)
        Me.lbl_CP.TabIndex = 4
        Me.lbl_CP.Text = "C.P."
        '
        'lbl_NumUMF
        '
        Me.lbl_NumUMF.AutoSize = True
        Me.lbl_NumUMF.Location = New System.Drawing.Point(54, 47)
        Me.lbl_NumUMF.Name = "lbl_NumUMF"
        Me.lbl_NumUMF.Size = New System.Drawing.Size(50, 13)
        Me.lbl_NumUMF.TabIndex = 0
        Me.lbl_NumUMF.Text = "No. UMF"
        '
        'lbl_Municipio
        '
        Me.lbl_Municipio.AutoSize = True
        Me.lbl_Municipio.Location = New System.Drawing.Point(52, 73)
        Me.lbl_Municipio.Name = "lbl_Municipio"
        Me.lbl_Municipio.Size = New System.Drawing.Size(52, 13)
        Me.lbl_Municipio.TabIndex = 2
        Me.lbl_Municipio.Text = "Municipio"
        Me.lbl_Municipio.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(256, 121)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 7
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(110, 122)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_CP
        '
        Me.tbx_CP.Control_Siguiente = Me.btn_Guardar
        Me.tbx_CP.Filtrado = True
        Me.tbx_CP.Location = New System.Drawing.Point(110, 96)
        Me.tbx_CP.MaxLength = 5
        Me.tbx_CP.Name = "tbx_CP"
        Me.tbx_CP.Size = New System.Drawing.Size(50, 20)
        Me.tbx_CP.TabIndex = 5
        Me.tbx_CP.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_UMF
        '
        Me.tbx_UMF.Control_Siguiente = Me.tbx_Municipio
        Me.tbx_UMF.Filtrado = True
        Me.tbx_UMF.Location = New System.Drawing.Point(110, 44)
        Me.tbx_UMF.MaxLength = 3
        Me.tbx_UMF.Name = "tbx_UMF"
        Me.tbx_UMF.Size = New System.Drawing.Size(50, 20)
        Me.tbx_UMF.TabIndex = 1
        Me.tbx_UMF.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Municipio
        '
        Me.tbx_Municipio.Control_Siguiente = Me.tbx_CP
        Me.tbx_Municipio.Filtrado = True
        Me.tbx_Municipio.Location = New System.Drawing.Point(110, 70)
        Me.tbx_Municipio.MaxLength = 50
        Me.tbx_Municipio.Name = "tbx_Municipio"
        Me.tbx_Municipio.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Municipio.TabIndex = 3
        Me.tbx_Municipio.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'frm_UnidadesMedicoFamiliares
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 623)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_UnidadesMedicoFamiliares"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de UMF"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.Tab_Nuevo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents Tab_Nuevo As System.Windows.Forms.TabPage
    Friend WithEvents Lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents lbl_Municipio As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_Municipio As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_NumUMF As System.Windows.Forms.Label
    Friend WithEvents tbx_UMF As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_CP As System.Windows.Forms.Label
    Friend WithEvents tbx_CP As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
