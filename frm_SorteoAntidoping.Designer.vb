<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SorteoAntidoping
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
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.chk_Puesto = New System.Windows.Forms.CheckBox
        Me.Lbl_PuestoL = New System.Windows.Forms.Label
        Me.cmb_Departamento = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.chk_Departamento = New System.Windows.Forms.CheckBox
        Me.Lbl_DepartamentoL = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_Filtrar = New System.Windows.Forms.Button
        Me.Chk_TodosDisponibles = New System.Windows.Forms.CheckBox
        Me.tbx_Dias = New Modulo_Reclutamiento.cp_Textbox
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lbl_RegistrosDisponibles = New System.Windows.Forms.Label
        Me.lsv_Disponibles = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.tbx_Cantidad = New Modulo_Reclutamiento.cp_Textbox
        Me.btn_Sortear = New System.Windows.Forms.Button
        Me.btn_Quitar = New System.Windows.Forms.Button
        Me.lbl_RegistrosSeleccionados = New System.Windows.Forms.Label
        Me.lsv_Seleccionados = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.lbl_RegistrosSorteados = New System.Windows.Forms.Label
        Me.lsv_Sorteados = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox1.Controls.Add(Me.btn_Mostrar)
        Me.GroupBox1.Controls.Add(Me.cmb_Puesto)
        Me.GroupBox1.Controls.Add(Me.chk_Puesto)
        Me.GroupBox1.Controls.Add(Me.Lbl_PuestoL)
        Me.GroupBox1.Controls.Add(Me.cmb_Departamento)
        Me.GroupBox1.Controls.Add(Me.chk_Departamento)
        Me.GroupBox1.Controls.Add(Me.Lbl_DepartamentoL)
        Me.GroupBox1.Location = New System.Drawing.Point(1, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(880, 80)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(732, 42)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 21
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow
        Me.btn_Mostrar.Location = New System.Drawing.Point(494, 42)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Mostrar.TabIndex = 20
        Me.btn_Mostrar.Text = "M&ostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Nothing
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.Location = New System.Drawing.Point(88, 46)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(323, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 18
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'chk_Puesto
        '
        Me.chk_Puesto.AutoSize = True
        Me.chk_Puesto.Location = New System.Drawing.Point(417, 50)
        Me.chk_Puesto.Name = "chk_Puesto"
        Me.chk_Puesto.Size = New System.Drawing.Size(56, 17)
        Me.chk_Puesto.TabIndex = 19
        Me.chk_Puesto.Text = "Todos"
        Me.chk_Puesto.UseVisualStyleBackColor = True
        '
        'Lbl_PuestoL
        '
        Me.Lbl_PuestoL.AutoSize = True
        Me.Lbl_PuestoL.Location = New System.Drawing.Point(42, 49)
        Me.Lbl_PuestoL.Name = "Lbl_PuestoL"
        Me.Lbl_PuestoL.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoL.TabIndex = 17
        Me.Lbl_PuestoL.Text = "Puesto"
        '
        'cmb_Departamento
        '
        Me.cmb_Departamento.Clave = Nothing
        Me.cmb_Departamento.Control_Siguiente = Nothing
        Me.cmb_Departamento.DisplayMember = "Descripcion"
        Me.cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento.Empresa = False
        Me.cmb_Departamento.Filtro = Nothing
        Me.cmb_Departamento.FormattingEnabled = True
        Me.cmb_Departamento.Location = New System.Drawing.Point(88, 19)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(323, 21)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 15
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'chk_Departamento
        '
        Me.chk_Departamento.AutoSize = True
        Me.chk_Departamento.Location = New System.Drawing.Point(417, 22)
        Me.chk_Departamento.Name = "chk_Departamento"
        Me.chk_Departamento.Size = New System.Drawing.Size(56, 17)
        Me.chk_Departamento.TabIndex = 16
        Me.chk_Departamento.Text = "Todos"
        Me.chk_Departamento.UseVisualStyleBackColor = True
        '
        'Lbl_DepartamentoL
        '
        Me.Lbl_DepartamentoL.AutoSize = True
        Me.Lbl_DepartamentoL.Location = New System.Drawing.Point(8, 22)
        Me.Lbl_DepartamentoL.Name = "Lbl_DepartamentoL"
        Me.Lbl_DepartamentoL.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DepartamentoL.TabIndex = 14
        Me.Lbl_DepartamentoL.Text = "Departamento"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(212, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(127, 13)
        Me.Label4.TabIndex = 23
        Me.Label4.Text = "días de su último examen"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 13)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Filtrar los que tengan más de"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(1, 86)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(880, 474)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_Filtrar)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Chk_TodosDisponibles)
        Me.GroupBox2.Controls.Add(Me.tbx_Dias)
        Me.GroupBox2.Controls.Add(Me.btn_Agregar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.lbl_RegistrosDisponibles)
        Me.GroupBox2.Controls.Add(Me.lsv_Disponibles)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(346, 468)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Empleados disponibles"
        '
        'btn_Filtrar
        '
        Me.btn_Filtrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow
        Me.btn_Filtrar.Location = New System.Drawing.Point(11, 38)
        Me.btn_Filtrar.Name = "btn_Filtrar"
        Me.btn_Filtrar.Size = New System.Drawing.Size(42, 30)
        Me.btn_Filtrar.TabIndex = 25
        Me.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Filtrar.UseVisualStyleBackColor = True
        '
        'Chk_TodosDisponibles
        '
        Me.Chk_TodosDisponibles.AutoSize = True
        Me.Chk_TodosDisponibles.Location = New System.Drawing.Point(6, 84)
        Me.Chk_TodosDisponibles.Name = "Chk_TodosDisponibles"
        Me.Chk_TodosDisponibles.Size = New System.Drawing.Size(115, 17)
        Me.Chk_TodosDisponibles.TabIndex = 24
        Me.Chk_TodosDisponibles.Text = "Seleccionar Todos"
        Me.Chk_TodosDisponibles.UseVisualStyleBackColor = True
        '
        'tbx_Dias
        '
        Me.tbx_Dias.Control_Siguiente = Nothing
        Me.tbx_Dias.Filtrado = True
        Me.tbx_Dias.Location = New System.Drawing.Point(156, 19)
        Me.tbx_Dias.MaxLength = 3
        Me.tbx_Dias.Name = "tbx_Dias"
        Me.tbx_Dias.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Dias.TabIndex = 22
        Me.tbx_Dias.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._next
        Me.btn_Agregar.Location = New System.Drawing.Point(300, 47)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(42, 30)
        Me.btn_Agregar.TabIndex = 23
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosDisponibles
        '
        Me.lbl_RegistrosDisponibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosDisponibles.Location = New System.Drawing.Point(237, 80)
        Me.lbl_RegistrosDisponibles.Name = "lbl_RegistrosDisponibles"
        Me.lbl_RegistrosDisponibles.Size = New System.Drawing.Size(109, 23)
        Me.lbl_RegistrosDisponibles.TabIndex = 22
        Me.lbl_RegistrosDisponibles.Text = "Registros: 0000"
        Me.lbl_RegistrosDisponibles.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Disponibles
        '
        Me.lsv_Disponibles.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Disponibles.CheckBoxes = True
        Me.lsv_Disponibles.FullRowSelect = True
        Me.lsv_Disponibles.HideSelection = False
        Me.lsv_Disponibles.Location = New System.Drawing.Point(2, 106)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Disponibles.Lvs = ListViewColumnSorter1
        Me.lsv_Disponibles.MultiSelect = False
        Me.lsv_Disponibles.Name = "lsv_Disponibles"
        Me.lsv_Disponibles.Row1 = 15
        Me.lsv_Disponibles.Row10 = 0
        Me.lsv_Disponibles.Row2 = 30
        Me.lsv_Disponibles.Row3 = 20
        Me.lsv_Disponibles.Row4 = 20
        Me.lsv_Disponibles.Row5 = 15
        Me.lsv_Disponibles.Row6 = 0
        Me.lsv_Disponibles.Row7 = 0
        Me.lsv_Disponibles.Row8 = 0
        Me.lsv_Disponibles.Row9 = 0
        Me.lsv_Disponibles.Size = New System.Drawing.Size(340, 354)
        Me.lsv_Disponibles.TabIndex = 0
        Me.lsv_Disponibles.UseCompatibleStateImageBehavior = False
        Me.lsv_Disponibles.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.tbx_Cantidad)
        Me.GroupBox3.Controls.Add(Me.btn_Sortear)
        Me.GroupBox3.Controls.Add(Me.btn_Quitar)
        Me.GroupBox3.Controls.Add(Me.lbl_RegistrosSeleccionados)
        Me.GroupBox3.Controls.Add(Me.lsv_Seleccionados)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(355, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(258, 468)
        Me.GroupBox3.TabIndex = 1
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Empleados en sorteo"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Cantidad de Empleados a sortear"
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Nothing
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(180, 19)
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cantidad.TabIndex = 26
        Me.tbx_Cantidad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'btn_Sortear
        '
        Me.btn_Sortear.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Sortear.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Procesar
        Me.btn_Sortear.Location = New System.Drawing.Point(210, 47)
        Me.btn_Sortear.Name = "btn_Sortear"
        Me.btn_Sortear.Size = New System.Drawing.Size(42, 30)
        Me.btn_Sortear.TabIndex = 25
        Me.btn_Sortear.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Sortear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Sortear.UseVisualStyleBackColor = True
        '
        'btn_Quitar
        '
        Me.btn_Quitar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.previous
        Me.btn_Quitar.Location = New System.Drawing.Point(6, 47)
        Me.btn_Quitar.Name = "btn_Quitar"
        Me.btn_Quitar.Size = New System.Drawing.Size(42, 30)
        Me.btn_Quitar.TabIndex = 24
        Me.btn_Quitar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Quitar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Quitar.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosSeleccionados
        '
        Me.lbl_RegistrosSeleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosSeleccionados.Location = New System.Drawing.Point(147, 78)
        Me.lbl_RegistrosSeleccionados.Name = "lbl_RegistrosSeleccionados"
        Me.lbl_RegistrosSeleccionados.Size = New System.Drawing.Size(109, 23)
        Me.lbl_RegistrosSeleccionados.TabIndex = 23
        Me.lbl_RegistrosSeleccionados.Text = "Registros: 0000"
        Me.lbl_RegistrosSeleccionados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Seleccionados
        '
        Me.lsv_Seleccionados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Seleccionados.CheckBoxes = True
        Me.lsv_Seleccionados.FullRowSelect = True
        Me.lsv_Seleccionados.HideSelection = False
        Me.lsv_Seleccionados.Location = New System.Drawing.Point(4, 106)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Seleccionados.Lvs = ListViewColumnSorter2
        Me.lsv_Seleccionados.MultiSelect = False
        Me.lsv_Seleccionados.Name = "lsv_Seleccionados"
        Me.lsv_Seleccionados.Row1 = 20
        Me.lsv_Seleccionados.Row10 = 0
        Me.lsv_Seleccionados.Row2 = 75
        Me.lsv_Seleccionados.Row3 = 0
        Me.lsv_Seleccionados.Row4 = 0
        Me.lsv_Seleccionados.Row5 = 0
        Me.lsv_Seleccionados.Row6 = 0
        Me.lsv_Seleccionados.Row7 = 0
        Me.lsv_Seleccionados.Row8 = 0
        Me.lsv_Seleccionados.Row9 = 0
        Me.lsv_Seleccionados.Size = New System.Drawing.Size(252, 354)
        Me.lsv_Seleccionados.TabIndex = 1
        Me.lsv_Seleccionados.UseCompatibleStateImageBehavior = False
        Me.lsv_Seleccionados.View = System.Windows.Forms.View.Details
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.btn_Guardar)
        Me.GroupBox4.Controls.Add(Me.btn_Exportar)
        Me.GroupBox4.Controls.Add(Me.lbl_RegistrosSorteados)
        Me.GroupBox4.Controls.Add(Me.lsv_Sorteados)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(619, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(258, 468)
        Me.GroupBox4.TabIndex = 2
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Empleados sorteados"
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(54, 22)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(42, 30)
        Me.btn_Guardar.TabIndex = 27
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Img_Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 22)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(42, 30)
        Me.btn_Exportar.TabIndex = 26
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'lbl_RegistrosSorteados
        '
        Me.lbl_RegistrosSorteados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosSorteados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosSorteados.Location = New System.Drawing.Point(144, 32)
        Me.lbl_RegistrosSorteados.Name = "lbl_RegistrosSorteados"
        Me.lbl_RegistrosSorteados.Size = New System.Drawing.Size(109, 23)
        Me.lbl_RegistrosSorteados.TabIndex = 23
        Me.lbl_RegistrosSorteados.Text = "Registros: 0000"
        Me.lbl_RegistrosSorteados.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Sorteados
        '
        Me.lsv_Sorteados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Sorteados.FullRowSelect = True
        Me.lsv_Sorteados.HideSelection = False
        Me.lsv_Sorteados.Location = New System.Drawing.Point(4, 58)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_Sorteados.Lvs = ListViewColumnSorter3
        Me.lsv_Sorteados.MultiSelect = False
        Me.lsv_Sorteados.Name = "lsv_Sorteados"
        Me.lsv_Sorteados.Row1 = 20
        Me.lsv_Sorteados.Row10 = 0
        Me.lsv_Sorteados.Row2 = 75
        Me.lsv_Sorteados.Row3 = 0
        Me.lsv_Sorteados.Row4 = 0
        Me.lsv_Sorteados.Row5 = 0
        Me.lsv_Sorteados.Row6 = 0
        Me.lsv_Sorteados.Row7 = 0
        Me.lsv_Sorteados.Row8 = 0
        Me.lsv_Sorteados.Row9 = 0
        Me.lsv_Sorteados.Size = New System.Drawing.Size(249, 402)
        Me.lsv_Sorteados.TabIndex = 1
        Me.lsv_Sorteados.UseCompatibleStateImageBehavior = False
        Me.lsv_Sorteados.View = System.Windows.Forms.View.Details
        '
        'frm_SorteoAntidoping
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_SorteoAntidoping"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sorteo Antidoping"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_Departamento As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Departamento As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_DepartamentoL As System.Windows.Forms.Label
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_Puesto As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_PuestoL As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Disponibles As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lsv_Seleccionados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lsv_Sorteados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_RegistrosDisponibles As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosSeleccionados As System.Windows.Forms.Label
    Friend WithEvents lbl_RegistrosSorteados As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents tbx_Dias As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Quitar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Sortear As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Chk_TodosDisponibles As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Filtrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
End Class
