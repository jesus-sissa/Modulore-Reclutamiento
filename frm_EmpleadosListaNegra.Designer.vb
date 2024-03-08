<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosListaNegra
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
        Me.rdb_Todos = New System.Windows.Forms.RadioButton
        Me.rdb_UZ = New System.Windows.Forms.RadioButton
        Me.rdb_PT = New System.Windows.Forms.RadioButton
        Me.rdb_KO = New System.Windows.Forms.RadioButton
        Me.rdb_FJ = New System.Windows.Forms.RadioButton
        Me.rdb_AE = New System.Windows.Forms.RadioButton
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_Buscar = New System.Windows.Forms.Label
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage
        Me.Lbl_Puestos = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.lbl_Motivo = New System.Windows.Forms.Label
        Me.lbl_Empresa = New System.Windows.Forms.Label
        Me.lbl_Nombre = New System.Windows.Forms.Label
        Me.tbx_Puesto = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Motivo = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Empresa = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Nombre = New Modulo_Reclutamiento.cp_Textbox
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
        Me.Tab_Catalogo.Size = New System.Drawing.Size(784, 561)
        Me.Tab_Catalogo.TabIndex = 0
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lbl_Numero)
        Me.tab_Listado.Controls.Add(Me.rdb_Todos)
        Me.tab_Listado.Controls.Add(Me.rdb_UZ)
        Me.tab_Listado.Controls.Add(Me.rdb_PT)
        Me.tab_Listado.Controls.Add(Me.rdb_KO)
        Me.tab_Listado.Controls.Add(Me.rdb_FJ)
        Me.tab_Listado.Controls.Add(Me.rdb_AE)
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
        Me.tab_Listado.Size = New System.Drawing.Size(776, 535)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Listado"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(615, 44)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(153, 23)
        Me.Lbl_Numero.TabIndex = 22
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'rdb_Todos
        '
        Me.rdb_Todos.AutoSize = True
        Me.rdb_Todos.Location = New System.Drawing.Point(492, 47)
        Me.rdb_Todos.Name = "rdb_Todos"
        Me.rdb_Todos.Size = New System.Drawing.Size(55, 17)
        Me.rdb_Todos.TabIndex = 8
        Me.rdb_Todos.TabStop = True
        Me.rdb_Todos.Text = "Todos"
        Me.rdb_Todos.UseVisualStyleBackColor = True
        '
        'rdb_UZ
        '
        Me.rdb_UZ.AutoSize = True
        Me.rdb_UZ.Location = New System.Drawing.Point(405, 47)
        Me.rdb_UZ.Name = "rdb_UZ"
        Me.rdb_UZ.Size = New System.Drawing.Size(49, 17)
        Me.rdb_UZ.TabIndex = 7
        Me.rdb_UZ.TabStop = True
        Me.rdb_UZ.Text = "U - Z"
        Me.rdb_UZ.UseVisualStyleBackColor = True
        '
        'rdb_PT
        '
        Me.rdb_PT.AutoSize = True
        Me.rdb_PT.Location = New System.Drawing.Point(317, 47)
        Me.rdb_PT.Name = "rdb_PT"
        Me.rdb_PT.Size = New System.Drawing.Size(48, 17)
        Me.rdb_PT.TabIndex = 6
        Me.rdb_PT.TabStop = True
        Me.rdb_PT.Text = "P - T"
        Me.rdb_PT.UseVisualStyleBackColor = True
        '
        'rdb_KO
        '
        Me.rdb_KO.AutoSize = True
        Me.rdb_KO.Location = New System.Drawing.Point(232, 47)
        Me.rdb_KO.Name = "rdb_KO"
        Me.rdb_KO.Size = New System.Drawing.Size(49, 17)
        Me.rdb_KO.TabIndex = 5
        Me.rdb_KO.TabStop = True
        Me.rdb_KO.Text = "K - O"
        Me.rdb_KO.UseVisualStyleBackColor = True
        '
        'rdb_FJ
        '
        Me.rdb_FJ.AutoSize = True
        Me.rdb_FJ.Location = New System.Drawing.Point(143, 47)
        Me.rdb_FJ.Name = "rdb_FJ"
        Me.rdb_FJ.Size = New System.Drawing.Size(45, 17)
        Me.rdb_FJ.TabIndex = 4
        Me.rdb_FJ.TabStop = True
        Me.rdb_FJ.Text = "F - J"
        Me.rdb_FJ.UseVisualStyleBackColor = True
        '
        'rdb_AE
        '
        Me.rdb_AE.AutoSize = True
        Me.rdb_AE.Location = New System.Drawing.Point(57, 47)
        Me.rdb_AE.Name = "rdb_AE"
        Me.rdb_AE.Size = New System.Drawing.Size(48, 17)
        Me.rdb_AE.TabIndex = 3
        Me.rdb_AE.TabStop = True
        Me.rdb_AE.Text = "A - E"
        Me.rdb_AE.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(8, 498)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 10
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(628, 498)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 12
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(154, 498)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 11
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
        Me.tbx_Buscar.Control_Siguiente = Nothing
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
        Me.lsv_Catalogo.Location = New System.Drawing.Point(8, 70)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 20
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 15
        Me.lsv_Catalogo.Row3 = 10
        Me.lsv_Catalogo.Row4 = 54
        Me.lsv_Catalogo.Row5 = 0
        Me.lsv_Catalogo.Row6 = 0
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(760, 422)
        Me.lsv_Catalogo.TabIndex = 9
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.Lbl_Puestos)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Cancelar)
        Me.Tab_Nuevo.Controls.Add(Me.btn_Guardar)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Motivo)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Empresa)
        Me.Tab_Nuevo.Controls.Add(Me.lbl_Nombre)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Puesto)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Motivo)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Empresa)
        Me.Tab_Nuevo.Controls.Add(Me.tbx_Nombre)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(776, 535)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Nuevo"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'Lbl_Puestos
        '
        Me.Lbl_Puestos.AutoSize = True
        Me.Lbl_Puestos.Location = New System.Drawing.Point(64, 99)
        Me.Lbl_Puestos.Name = "Lbl_Puestos"
        Me.Lbl_Puestos.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Puestos.TabIndex = 4
        Me.Lbl_Puestos.Text = "Puesto"
        Me.Lbl_Puestos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(320, 200)
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
        Me.btn_Guardar.Location = New System.Drawing.Point(110, 200)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 8
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'lbl_Motivo
        '
        Me.lbl_Motivo.AutoSize = True
        Me.lbl_Motivo.Location = New System.Drawing.Point(64, 126)
        Me.lbl_Motivo.Name = "lbl_Motivo"
        Me.lbl_Motivo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Motivo.TabIndex = 6
        Me.lbl_Motivo.Text = "Motivo"
        Me.lbl_Motivo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Empresa
        '
        Me.lbl_Empresa.AutoSize = True
        Me.lbl_Empresa.Location = New System.Drawing.Point(56, 73)
        Me.lbl_Empresa.Name = "lbl_Empresa"
        Me.lbl_Empresa.Size = New System.Drawing.Size(48, 13)
        Me.lbl_Empresa.TabIndex = 2
        Me.lbl_Empresa.Text = "Empresa"
        Me.lbl_Empresa.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Nombre
        '
        Me.lbl_Nombre.AutoSize = True
        Me.lbl_Nombre.Location = New System.Drawing.Point(60, 47)
        Me.lbl_Nombre.Name = "lbl_Nombre"
        Me.lbl_Nombre.Size = New System.Drawing.Size(44, 13)
        Me.lbl_Nombre.TabIndex = 0
        Me.lbl_Nombre.Text = "Nombre"
        Me.lbl_Nombre.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.Control_Siguiente = Me.tbx_Motivo
        Me.tbx_Puesto.Filtrado = True
        Me.tbx_Puesto.Location = New System.Drawing.Point(110, 96)
        Me.tbx_Puesto.MaxLength = 150
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Puesto.TabIndex = 5
        Me.tbx_Puesto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Motivo
        '
        Me.tbx_Motivo.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Motivo.Filtrado = True
        Me.tbx_Motivo.Location = New System.Drawing.Point(110, 123)
        Me.tbx_Motivo.MaxLength = 250
        Me.tbx_Motivo.Multiline = True
        Me.tbx_Motivo.Name = "tbx_Motivo"
        Me.tbx_Motivo.Size = New System.Drawing.Size(350, 71)
        Me.tbx_Motivo.TabIndex = 7
        Me.tbx_Motivo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Empresa
        '
        Me.tbx_Empresa.Control_Siguiente = Me.tbx_Puesto
        Me.tbx_Empresa.Filtrado = True
        Me.tbx_Empresa.Location = New System.Drawing.Point(110, 70)
        Me.tbx_Empresa.MaxLength = 150
        Me.tbx_Empresa.Name = "tbx_Empresa"
        Me.tbx_Empresa.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Empresa.TabIndex = 3
        Me.tbx_Empresa.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'tbx_Nombre
        '
        Me.tbx_Nombre.Control_Siguiente = Me.tbx_Empresa
        Me.tbx_Nombre.Filtrado = True
        Me.tbx_Nombre.Location = New System.Drawing.Point(110, 44)
        Me.tbx_Nombre.MaxLength = 60
        Me.tbx_Nombre.Name = "tbx_Nombre"
        Me.tbx_Nombre.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Nombre.TabIndex = 1
        Me.tbx_Nombre.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Letras
        '
        'frm_EmpleadosListaNegra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EmpleadosListaNegra"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo de Empleados en Lista Negra"
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
    Friend WithEvents lbl_Nombre As System.Windows.Forms.Label
    Friend WithEvents tbx_Nombre As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents lbl_Motivo As System.Windows.Forms.Label
    Friend WithEvents lbl_Empresa As System.Windows.Forms.Label
    Friend WithEvents tbx_Motivo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Empresa As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents rdb_UZ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_PT As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_KO As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_FJ As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_AE As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Todos As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_Puestos As System.Windows.Forms.Label
    Friend WithEvents tbx_Puesto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
