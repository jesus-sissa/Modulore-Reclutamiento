<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImplementosInventario
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
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.tab_Entradas = New System.Windows.Forms.TabPage
        Me.tbx_Implemento = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Implementos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveImplemento = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Existencia = New System.Windows.Forms.Label
        Me.lbl_Implemento = New System.Windows.Forms.Label
        Me.lbl_Clave = New System.Windows.Forms.Label
        Me.lbl_StockMinimo = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_Existencia = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_StockMinimo = New Modulo_Reclutamiento.cp_Textbox
        Me.Tab_Catalogo.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.tab_Entradas.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Entradas)
        Me.Tab_Catalogo.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tab_Catalogo.Location = New System.Drawing.Point(0, 0)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 2
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Numero)
        Me.tab_Listado.Controls.Add(Me.btn_Modificar)
        Me.tab_Listado.Controls.Add(Me.btn_Cerrar)
        Me.tab_Listado.Controls.Add(Me.btn_Exportar)
        Me.tab_Listado.Controls.Add(Me.btn_Buscar)
        Me.tab_Listado.Controls.Add(Me.tbx_Buscar)
        Me.tab_Listado.Controls.Add(Me.lbl_Buscar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(548, 29)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 23
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(6, 497)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 5
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(630, 497)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 7
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(152, 497)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 6
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
        Me.tbx_Buscar.Location = New System.Drawing.Point(57, 6)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(568, 20)
        Me.tbx_Buscar.TabIndex = 1
        Me.tbx_Buscar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(3, 9)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 0
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 55)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 6
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 20
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 10
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(767, 436)
        Me.lsv_Catalogo.TabIndex = 3
        Me.lsv_Catalogo.Tag = "Id_Inventario"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'tab_Entradas
        '
        Me.tab_Entradas.Controls.Add(Me.tbx_Implemento)
        Me.tab_Entradas.Controls.Add(Me.cmb_Implementos)
        Me.tab_Entradas.Controls.Add(Me.lbl_Existencia)
        Me.tab_Entradas.Controls.Add(Me.lbl_Implemento)
        Me.tab_Entradas.Controls.Add(Me.lbl_Clave)
        Me.tab_Entradas.Controls.Add(Me.lbl_StockMinimo)
        Me.tab_Entradas.Controls.Add(Me.btn_Cancelar)
        Me.tab_Entradas.Controls.Add(Me.btn_Guardar)
        Me.tab_Entradas.Controls.Add(Me.tbx_Existencia)
        Me.tab_Entradas.Controls.Add(Me.tbx_ClaveImplemento)
        Me.tab_Entradas.Controls.Add(Me.tbx_StockMinimo)
        Me.tab_Entradas.Location = New System.Drawing.Point(4, 22)
        Me.tab_Entradas.Name = "tab_Entradas"
        Me.tab_Entradas.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Entradas.Size = New System.Drawing.Size(776, 535)
        Me.tab_Entradas.TabIndex = 1
        Me.tab_Entradas.Text = "Entradas"
        Me.tab_Entradas.UseVisualStyleBackColor = True
        '
        'tbx_Implemento
        '
        Me.tbx_Implemento.Control_Siguiente = Nothing
        Me.tbx_Implemento.Filtrado = True
        Me.tbx_Implemento.Location = New System.Drawing.Point(110, 70)
        Me.tbx_Implemento.MaxLength = 50
        Me.tbx_Implemento.Name = "tbx_Implemento"
        Me.tbx_Implemento.ReadOnly = True
        Me.tbx_Implemento.Size = New System.Drawing.Size(359, 20)
        Me.tbx_Implemento.TabIndex = 3
        Me.tbx_Implemento.TabStop = False
        Me.tbx_Implemento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Implementos
        '
        Me.cmb_Implementos.Clave = "Clave"
        Me.cmb_Implementos.Control_Siguiente = Nothing
        Me.cmb_Implementos.DisplayMember = "Descripcion"
        Me.cmb_Implementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Implementos.Empresa = False
        Me.cmb_Implementos.Filtro = Me.tbx_ClaveImplemento
        Me.cmb_Implementos.FormattingEnabled = True
        Me.cmb_Implementos.Location = New System.Drawing.Point(110, 209)
        Me.cmb_Implementos.MaxDropDownItems = 20
        Me.cmb_Implementos.Name = "cmb_Implementos"
        Me.cmb_Implementos.Pista = False
        Me.cmb_Implementos.Size = New System.Drawing.Size(359, 21)
        Me.cmb_Implementos.StoredProcedure = "Cat_Implementos_Get"
        Me.cmb_Implementos.Sucursal = False
        Me.cmb_Implementos.TabIndex = 10
        Me.cmb_Implementos.Tipo = 0
        Me.cmb_Implementos.ValueMember = "Id_Implemento"
        Me.cmb_Implementos.Visible = False
        '
        'tbx_ClaveImplemento
        '
        Me.tbx_ClaveImplemento.Control_Siguiente = Nothing
        Me.tbx_ClaveImplemento.Filtrado = True
        Me.tbx_ClaveImplemento.Location = New System.Drawing.Point(110, 44)
        Me.tbx_ClaveImplemento.MaxLength = 4
        Me.tbx_ClaveImplemento.Name = "tbx_ClaveImplemento"
        Me.tbx_ClaveImplemento.ReadOnly = True
        Me.tbx_ClaveImplemento.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveImplemento.TabIndex = 1
        Me.tbx_ClaveImplemento.TabStop = False
        Me.tbx_ClaveImplemento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lbl_Existencia
        '
        Me.lbl_Existencia.AutoSize = True
        Me.lbl_Existencia.Location = New System.Drawing.Point(49, 125)
        Me.lbl_Existencia.Name = "lbl_Existencia"
        Me.lbl_Existencia.Size = New System.Drawing.Size(55, 13)
        Me.lbl_Existencia.TabIndex = 6
        Me.lbl_Existencia.Text = "Existencia"
        Me.lbl_Existencia.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Implemento
        '
        Me.lbl_Implemento.AutoSize = True
        Me.lbl_Implemento.Location = New System.Drawing.Point(43, 73)
        Me.lbl_Implemento.Name = "lbl_Implemento"
        Me.lbl_Implemento.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Implemento.TabIndex = 2
        Me.lbl_Implemento.Text = "Implemento"
        '
        'lbl_Clave
        '
        Me.lbl_Clave.AutoSize = True
        Me.lbl_Clave.Location = New System.Drawing.Point(70, 47)
        Me.lbl_Clave.Name = "lbl_Clave"
        Me.lbl_Clave.Size = New System.Drawing.Size(34, 13)
        Me.lbl_Clave.TabIndex = 0
        Me.lbl_Clave.Text = "Clave"
        Me.lbl_Clave.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_StockMinimo
        '
        Me.lbl_StockMinimo.AutoSize = True
        Me.lbl_StockMinimo.Location = New System.Drawing.Point(31, 99)
        Me.lbl_StockMinimo.Name = "lbl_StockMinimo"
        Me.lbl_StockMinimo.Size = New System.Drawing.Size(73, 13)
        Me.lbl_StockMinimo.TabIndex = 4
        Me.lbl_StockMinimo.Text = "Stock Mínimo"
        Me.lbl_StockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(256, 148)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 9
        Me.btn_Cancelar.Text = "&Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(110, 148)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 8
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_Existencia
        '
        Me.tbx_Existencia.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Existencia.Filtrado = True
        Me.tbx_Existencia.Location = New System.Drawing.Point(110, 122)
        Me.tbx_Existencia.MaxLength = 8
        Me.tbx_Existencia.Name = "tbx_Existencia"
        Me.tbx_Existencia.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Existencia.TabIndex = 7
        Me.tbx_Existencia.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_StockMinimo
        '
        Me.tbx_StockMinimo.Control_Siguiente = Me.tbx_Existencia
        Me.tbx_StockMinimo.Filtrado = True
        Me.tbx_StockMinimo.Location = New System.Drawing.Point(110, 96)
        Me.tbx_StockMinimo.MaxLength = 8
        Me.tbx_StockMinimo.Name = "tbx_StockMinimo"
        Me.tbx_StockMinimo.Size = New System.Drawing.Size(50, 20)
        Me.tbx_StockMinimo.TabIndex = 5
        Me.tbx_StockMinimo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_ImplementosInventario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ImplementosInventario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inventario de Implementos"
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.tab_Entradas.ResumeLayout(False)
        Me.tab_Entradas.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tab_Catalogo As System.Windows.Forms.TabControl
    Friend WithEvents tab_Listado As System.Windows.Forms.TabPage
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tab_Entradas As System.Windows.Forms.TabPage
    Friend WithEvents lbl_Implemento As System.Windows.Forms.Label
    Friend WithEvents lbl_Clave As System.Windows.Forms.Label
    Friend WithEvents lbl_StockMinimo As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents tbx_StockMinimo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_ClaveImplemento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Existencia As System.Windows.Forms.Label
    Friend WithEvents tbx_Existencia As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Implementos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Implemento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
