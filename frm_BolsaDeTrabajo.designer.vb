<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_BolsaDeTrabajo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_BolsaDeTrabajo))
        Me.Tab_Nuevo = New System.Windows.Forms.TabPage()
        Me.tab_DatosEmpleado = New System.Windows.Forms.TabControl()
        Me.tab_Referencias = New System.Windows.Forms.TabPage()
        Me.txt_Titulo = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Tbx_Descripcion = New System.Windows.Forms.TextBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.btn_Borrar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Cancelar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Modificar_Referencias = New System.Windows.Forms.Button()
        Me.btn_Guardar_Referencias = New System.Windows.Forms.Button()
        Me.Lbl_CiudadR = New System.Windows.Forms.Label()
        Me.Lbl_CalleR = New System.Windows.Forms.Label()
        Me.Lbl_OcupacionR = New System.Windows.Forms.Label()
        Me.lbl_NombreReferencia = New System.Windows.Forms.Label()
        Me.lbl_TipoReferencia = New System.Windows.Forms.Label()
        Me.tab_Listado = New System.Windows.Forms.TabPage()
        Me.Lb_Movil = New System.Windows.Forms.Label()
        Me.Lb_NombreEmpleado = New System.Windows.Forms.Label()
        Me.Lb_Titulo = New System.Windows.Forms.Label()
        Me.Tbx_Comentarios = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.Btn_Validar = New System.Windows.Forms.Button()
        Me.Tab_Catalogo = New System.Windows.Forms.TabControl()
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview()
        Me.Cp_Listview1 = New Modulo_Reclutamiento.cp_Listview()
        Me.Cp_Tbx_Sueldo = New Modulo_Reclutamiento.cp_Textbox()
        Me.Cp_cmb_EstatusContratacion = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Cp_cmb_ciudad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Tab_Nuevo.SuspendLayout()
        Me.tab_DatosEmpleado.SuspendLayout()
        Me.tab_Referencias.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.tab_Listado.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Tab_Catalogo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tab_Nuevo
        '
        Me.Tab_Nuevo.Controls.Add(Me.tab_DatosEmpleado)
        Me.Tab_Nuevo.Location = New System.Drawing.Point(4, 22)
        Me.Tab_Nuevo.Name = "Tab_Nuevo"
        Me.Tab_Nuevo.Padding = New System.Windows.Forms.Padding(3)
        Me.Tab_Nuevo.Size = New System.Drawing.Size(1084, 742)
        Me.Tab_Nuevo.TabIndex = 1
        Me.Tab_Nuevo.Text = "Publicar"
        Me.Tab_Nuevo.UseVisualStyleBackColor = True
        '
        'tab_DatosEmpleado
        '
        Me.tab_DatosEmpleado.Controls.Add(Me.tab_Referencias)
        Me.tab_DatosEmpleado.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tab_DatosEmpleado.Location = New System.Drawing.Point(3, 3)
        Me.tab_DatosEmpleado.Name = "tab_DatosEmpleado"
        Me.tab_DatosEmpleado.SelectedIndex = 0
        Me.tab_DatosEmpleado.Size = New System.Drawing.Size(1078, 736)
        Me.tab_DatosEmpleado.TabIndex = 0
        '
        'tab_Referencias
        '
        Me.tab_Referencias.Controls.Add(Me.txt_Titulo)
        Me.tab_Referencias.Controls.Add(Me.GroupBox1)
        Me.tab_Referencias.Controls.Add(Me.Cp_Listview1)
        Me.tab_Referencias.Controls.Add(Me.Tbx_Descripcion)
        Me.tab_Referencias.Controls.Add(Me.Cp_Tbx_Sueldo)
        Me.tab_Referencias.Controls.Add(Me.Cp_cmb_EstatusContratacion)
        Me.tab_Referencias.Controls.Add(Me.Cp_cmb_ciudad)
        Me.tab_Referencias.Controls.Add(Me.Label38)
        Me.tab_Referencias.Controls.Add(Me.btn_Borrar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Cancelar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Modificar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.btn_Guardar_Referencias)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CiudadR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_CalleR)
        Me.tab_Referencias.Controls.Add(Me.Lbl_OcupacionR)
        Me.tab_Referencias.Controls.Add(Me.lbl_NombreReferencia)
        Me.tab_Referencias.Controls.Add(Me.lbl_TipoReferencia)
        Me.tab_Referencias.Location = New System.Drawing.Point(4, 22)
        Me.tab_Referencias.Name = "tab_Referencias"
        Me.tab_Referencias.Size = New System.Drawing.Size(1070, 710)
        Me.tab_Referencias.TabIndex = 5
        Me.tab_Referencias.Text = "Vacante"
        Me.tab_Referencias.UseVisualStyleBackColor = True
        '
        'txt_Titulo
        '
        Me.txt_Titulo.Location = New System.Drawing.Point(149, 9)
        Me.txt_Titulo.Name = "txt_Titulo"
        Me.txt_Titulo.Size = New System.Drawing.Size(372, 20)
        Me.txt_Titulo.TabIndex = 39
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RadioButton2)
        Me.GroupBox1.Controls.Add(Me.RadioButton1)
        Me.GroupBox1.Enabled = False
        Me.GroupBox1.Location = New System.Drawing.Point(148, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(136, 50)
        Me.GroupBox1.TabIndex = 38
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Vacante activa"
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(72, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton2.TabIndex = 37
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "No"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(15, 19)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton1.TabIndex = 36
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "Si"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'Tbx_Descripcion
        '
        Me.Tbx_Descripcion.Location = New System.Drawing.Point(148, 198)
        Me.Tbx_Descripcion.Multiline = True
        Me.Tbx_Descripcion.Name = "Tbx_Descripcion"
        Me.Tbx_Descripcion.Size = New System.Drawing.Size(900, 124)
        Me.Tbx_Descripcion.TabIndex = 5
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Enabled = False
        Me.Label38.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label38.ForeColor = System.Drawing.Color.Red
        Me.Label38.Location = New System.Drawing.Point(337, 31)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(13, 16)
        Me.Label38.TabIndex = 5
        Me.Label38.Text = "*"
        '
        'btn_Borrar_Referencias
        '
        Me.btn_Borrar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Borrar_Referencias.Enabled = False
        Me.btn_Borrar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar_Referencias.Location = New System.Drawing.Point(295, 677)
        Me.btn_Borrar_Referencias.Name = "btn_Borrar_Referencias"
        Me.btn_Borrar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar_Referencias.TabIndex = 18
        Me.btn_Borrar_Referencias.Text = "&Borrar"
        Me.btn_Borrar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Cancelar_Referencias
        '
        Me.btn_Cancelar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar_Referencias.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cancelar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar_Referencias.Location = New System.Drawing.Point(441, 677)
        Me.btn_Cancelar_Referencias.Name = "btn_Cancelar_Referencias"
        Me.btn_Cancelar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar_Referencias.TabIndex = 19
        Me.btn_Cancelar_Referencias.Text = "&Cancelar"
        Me.btn_Cancelar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Modificar_Referencias
        '
        Me.btn_Modificar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Modificar_Referencias.Enabled = False
        Me.btn_Modificar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar_Referencias.Location = New System.Drawing.Point(149, 677)
        Me.btn_Modificar_Referencias.Name = "btn_Modificar_Referencias"
        Me.btn_Modificar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar_Referencias.TabIndex = 17
        Me.btn_Modificar_Referencias.Text = "&Modificar"
        Me.btn_Modificar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar_Referencias.UseVisualStyleBackColor = True
        '
        'btn_Guardar_Referencias
        '
        Me.btn_Guardar_Referencias.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar_Referencias.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar_Referencias.Location = New System.Drawing.Point(3, 677)
        Me.btn_Guardar_Referencias.Name = "btn_Guardar_Referencias"
        Me.btn_Guardar_Referencias.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar_Referencias.TabIndex = 10
        Me.btn_Guardar_Referencias.Text = "&Guardar"
        Me.btn_Guardar_Referencias.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar_Referencias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar_Referencias.UseVisualStyleBackColor = True
        '
        'Lbl_CiudadR
        '
        Me.Lbl_CiudadR.AutoSize = True
        Me.Lbl_CiudadR.Location = New System.Drawing.Point(21, 85)
        Me.Lbl_CiudadR.Name = "Lbl_CiudadR"
        Me.Lbl_CiudadR.Size = New System.Drawing.Size(104, 13)
        Me.Lbl_CiudadR.TabIndex = 24
        Me.Lbl_CiudadR.Text = "Estatus contratacion"
        '
        'Lbl_CalleR
        '
        Me.Lbl_CalleR.AutoSize = True
        Me.Lbl_CalleR.Location = New System.Drawing.Point(25, 201)
        Me.Lbl_CalleR.Name = "Lbl_CalleR"
        Me.Lbl_CalleR.Size = New System.Drawing.Size(103, 13)
        Me.Lbl_CalleR.TabIndex = 10
        Me.Lbl_CalleR.Text = "Descripcion General"
        '
        'Lbl_OcupacionR
        '
        Me.Lbl_OcupacionR.AutoSize = True
        Me.Lbl_OcupacionR.Location = New System.Drawing.Point(102, 63)
        Me.Lbl_OcupacionR.Name = "Lbl_OcupacionR"
        Me.Lbl_OcupacionR.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_OcupacionR.TabIndex = 8
        Me.Lbl_OcupacionR.Text = "Sueldo"
        '
        'lbl_NombreReferencia
        '
        Me.lbl_NombreReferencia.AutoSize = True
        Me.lbl_NombreReferencia.Location = New System.Drawing.Point(102, 37)
        Me.lbl_NombreReferencia.Name = "lbl_NombreReferencia"
        Me.lbl_NombreReferencia.Size = New System.Drawing.Size(40, 13)
        Me.lbl_NombreReferencia.TabIndex = 3
        Me.lbl_NombreReferencia.Text = "Ciudad"
        '
        'lbl_TipoReferencia
        '
        Me.lbl_TipoReferencia.AutoSize = True
        Me.lbl_TipoReferencia.Location = New System.Drawing.Point(44, 9)
        Me.lbl_TipoReferencia.Name = "lbl_TipoReferencia"
        Me.lbl_TipoReferencia.Size = New System.Drawing.Size(88, 13)
        Me.lbl_TipoReferencia.TabIndex = 0
        Me.lbl_TipoReferencia.Text = "Titulo del Empleo"
        '
        'tab_Listado
        '
        Me.tab_Listado.Controls.Add(Me.Lb_Movil)
        Me.tab_Listado.Controls.Add(Me.Lb_NombreEmpleado)
        Me.tab_Listado.Controls.Add(Me.Lb_Titulo)
        Me.tab_Listado.Controls.Add(Me.Tbx_Comentarios)
        Me.tab_Listado.Controls.Add(Me.Label1)
        Me.tab_Listado.Controls.Add(Me.GroupBox2)
        Me.tab_Listado.Controls.Add(Me.Btn_Validar)
        Me.tab_Listado.Controls.Add(Me.lsv_Catalogo)
        Me.tab_Listado.Location = New System.Drawing.Point(4, 22)
        Me.tab_Listado.Name = "tab_Listado"
        Me.tab_Listado.Padding = New System.Windows.Forms.Padding(3)
        Me.tab_Listado.Size = New System.Drawing.Size(1084, 742)
        Me.tab_Listado.TabIndex = 0
        Me.tab_Listado.Text = "Postulados"
        Me.tab_Listado.UseVisualStyleBackColor = True
        '
        'Lb_Movil
        '
        Me.Lb_Movil.AutoSize = True
        Me.Lb_Movil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Movil.Location = New System.Drawing.Point(655, 86)
        Me.Lb_Movil.Name = "Lb_Movil"
        Me.Lb_Movil.Size = New System.Drawing.Size(14, 20)
        Me.Lb_Movil.TabIndex = 44
        Me.Lb_Movil.Text = "."
        '
        'Lb_NombreEmpleado
        '
        Me.Lb_NombreEmpleado.AutoSize = True
        Me.Lb_NombreEmpleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_NombreEmpleado.Location = New System.Drawing.Point(655, 61)
        Me.Lb_NombreEmpleado.Name = "Lb_NombreEmpleado"
        Me.Lb_NombreEmpleado.Size = New System.Drawing.Size(14, 20)
        Me.Lb_NombreEmpleado.TabIndex = 43
        Me.Lb_NombreEmpleado.Text = "."
        '
        'Lb_Titulo
        '
        Me.Lb_Titulo.AutoSize = True
        Me.Lb_Titulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lb_Titulo.Location = New System.Drawing.Point(655, 36)
        Me.Lb_Titulo.Name = "Lb_Titulo"
        Me.Lb_Titulo.Size = New System.Drawing.Size(14, 20)
        Me.Lb_Titulo.TabIndex = 42
        Me.Lb_Titulo.Text = "."
        '
        'Tbx_Comentarios
        '
        Me.Tbx_Comentarios.Location = New System.Drawing.Point(18, 24)
        Me.Tbx_Comentarios.Multiline = True
        Me.Tbx_Comentarios.Name = "Tbx_Comentarios"
        Me.Tbx_Comentarios.Size = New System.Drawing.Size(554, 124)
        Me.Tbx_Comentarios.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 41
        Me.Label1.Text = "Comentarios"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.RadioButton3)
        Me.GroupBox2.Controls.Add(Me.RadioButton4)
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.Location = New System.Drawing.Point(18, 149)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(136, 50)
        Me.GroupBox2.TabIndex = 39
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Es apto"
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.Location = New System.Drawing.Point(72, 19)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(39, 17)
        Me.RadioButton3.TabIndex = 37
        Me.RadioButton3.Text = "No"
        Me.RadioButton3.UseVisualStyleBackColor = True
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.Location = New System.Drawing.Point(15, 19)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(34, 17)
        Me.RadioButton4.TabIndex = 36
        Me.RadioButton4.Text = "Si"
        Me.RadioButton4.UseVisualStyleBackColor = True
        '
        'Btn_Validar
        '
        Me.Btn_Validar.Enabled = False
        Me.Btn_Validar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.Btn_Validar.Location = New System.Drawing.Point(432, 168)
        Me.Btn_Validar.Name = "Btn_Validar"
        Me.Btn_Validar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Validar.TabIndex = 15
        Me.Btn_Validar.Text = "&Validar"
        Me.Btn_Validar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Validar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Validar.UseVisualStyleBackColor = True
        '
        'Tab_Catalogo
        '
        Me.Tab_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab_Catalogo.Controls.Add(Me.tab_Listado)
        Me.Tab_Catalogo.Controls.Add(Me.Tab_Nuevo)
        Me.Tab_Catalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tab_Catalogo.Location = New System.Drawing.Point(1, 5)
        Me.Tab_Catalogo.Name = "Tab_Catalogo"
        Me.Tab_Catalogo.SelectedIndex = 0
        Me.Tab_Catalogo.Size = New System.Drawing.Size(1092, 768)
        Me.Tab_Catalogo.TabIndex = 1
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(3, 218)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter2
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 0
        Me.lsv_Catalogo.Row10 = 5
        Me.lsv_Catalogo.Row2 = 7
        Me.lsv_Catalogo.Row3 = 12
        Me.lsv_Catalogo.Row4 = 12
        Me.lsv_Catalogo.Row5 = 10
        Me.lsv_Catalogo.Row6 = 10
        Me.lsv_Catalogo.Row7 = 8
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(1078, 521)
        Me.lsv_Catalogo.TabIndex = 14
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'Cp_Listview1
        '
        Me.Cp_Listview1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Cp_Listview1.FullRowSelect = True
        Me.Cp_Listview1.HideSelection = False
        Me.Cp_Listview1.Location = New System.Drawing.Point(3, 353)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.Cp_Listview1.Lvs = ListViewColumnSorter1
        Me.Cp_Listview1.MultiSelect = False
        Me.Cp_Listview1.Name = "Cp_Listview1"
        Me.Cp_Listview1.Row1 = 0
        Me.Cp_Listview1.Row10 = 0
        Me.Cp_Listview1.Row2 = 15
        Me.Cp_Listview1.Row3 = 15
        Me.Cp_Listview1.Row4 = 15
        Me.Cp_Listview1.Row5 = 10
        Me.Cp_Listview1.Row6 = 10
        Me.Cp_Listview1.Row7 = 10
        Me.Cp_Listview1.Row8 = 0
        Me.Cp_Listview1.Row9 = 0
        Me.Cp_Listview1.Size = New System.Drawing.Size(1046, 288)
        Me.Cp_Listview1.TabIndex = 35
        Me.Cp_Listview1.Tag = "Id"
        Me.Cp_Listview1.UseCompatibleStateImageBehavior = False
        Me.Cp_Listview1.View = System.Windows.Forms.View.Details
        '
        'Cp_Tbx_Sueldo
        '
        Me.Cp_Tbx_Sueldo.Control_Siguiente = Nothing
        Me.Cp_Tbx_Sueldo.Filtrado = True
        Me.Cp_Tbx_Sueldo.Location = New System.Drawing.Point(149, 59)
        Me.Cp_Tbx_Sueldo.MaxLength = 50
        Me.Cp_Tbx_Sueldo.Name = "Cp_Tbx_Sueldo"
        Me.Cp_Tbx_Sueldo.Size = New System.Drawing.Size(372, 20)
        Me.Cp_Tbx_Sueldo.TabIndex = 3
        Me.Cp_Tbx_Sueldo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'Cp_cmb_EstatusContratacion
        '
        Me.Cp_cmb_EstatusContratacion.Control_Siguiente = Nothing
        Me.Cp_cmb_EstatusContratacion.DisplayMember = "display"
        Me.Cp_cmb_EstatusContratacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_EstatusContratacion.FormattingEnabled = True
        Me.Cp_cmb_EstatusContratacion.Location = New System.Drawing.Point(148, 85)
        Me.Cp_cmb_EstatusContratacion.MaxDropDownItems = 20
        Me.Cp_cmb_EstatusContratacion.Name = "Cp_cmb_EstatusContratacion"
        Me.Cp_cmb_EstatusContratacion.Size = New System.Drawing.Size(372, 21)
        Me.Cp_cmb_EstatusContratacion.TabIndex = 4
        Me.Cp_cmb_EstatusContratacion.ValueMember = "value"
        '
        'Cp_cmb_ciudad
        '
        Me.Cp_cmb_ciudad.Control_Siguiente = Nothing
        Me.Cp_cmb_ciudad.DisplayMember = "display"
        Me.Cp_cmb_ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cp_cmb_ciudad.Enabled = False
        Me.Cp_cmb_ciudad.FormattingEnabled = True
        Me.Cp_cmb_ciudad.Location = New System.Drawing.Point(149, 31)
        Me.Cp_cmb_ciudad.MaxDropDownItems = 20
        Me.Cp_cmb_ciudad.Name = "Cp_cmb_ciudad"
        Me.Cp_cmb_ciudad.Size = New System.Drawing.Size(372, 21)
        Me.Cp_cmb_ciudad.TabIndex = 2
        Me.Cp_cmb_ciudad.ValueMember = "value"
        '
        'frm_BolsaDeTrabajo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1096, 766)
        Me.Controls.Add(Me.Tab_Catalogo)
        Me.Name = "frm_BolsaDeTrabajo"
        Me.Text = "frm_BolsaDeTrabajo"
        Me.Tab_Nuevo.ResumeLayout(False)
        Me.tab_DatosEmpleado.ResumeLayout(False)
        Me.tab_Referencias.ResumeLayout(False)
        Me.tab_Referencias.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.tab_Listado.ResumeLayout(False)
        Me.tab_Listado.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Tab_Catalogo.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Tab_Nuevo As TabPage
    Friend WithEvents tab_DatosEmpleado As TabControl
    Friend WithEvents tab_Referencias As TabPage
    Friend WithEvents txt_Titulo As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Cp_Listview1 As cp_Listview
    Friend WithEvents Tbx_Descripcion As TextBox
    Friend WithEvents Cp_Tbx_Sueldo As cp_Textbox
    Friend WithEvents Cp_cmb_EstatusContratacion As cp_cmb_Manual
    Friend WithEvents Cp_cmb_ciudad As cp_cmb_Manual
    Friend WithEvents Label38 As Label
    Friend WithEvents btn_Borrar_Referencias As Button
    Friend WithEvents btn_Cancelar_Referencias As Button
    Friend WithEvents btn_Modificar_Referencias As Button
    Friend WithEvents btn_Guardar_Referencias As Button
    Friend WithEvents Lbl_CiudadR As Label
    Friend WithEvents Lbl_CalleR As Label
    Friend WithEvents Lbl_OcupacionR As Label
    Friend WithEvents lbl_NombreReferencia As Label
    Friend WithEvents lbl_TipoReferencia As Label
    Friend WithEvents tab_Listado As TabPage
    Friend WithEvents lsv_Catalogo As cp_Listview
    Friend WithEvents Tab_Catalogo As TabControl
    Friend WithEvents Lb_Movil As Label
    Friend WithEvents Lb_NombreEmpleado As Label
    Friend WithEvents Lb_Titulo As Label
    Friend WithEvents Tbx_Comentarios As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Btn_Validar As Button
End Class
