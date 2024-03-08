<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PromocionEmpleados
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
        Me.gbx_Consulta = New System.Windows.Forms.GroupBox
        Me.cmb_Empleados = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Departamento = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Puesto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_SueldoDiarioN = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_Empleados = New System.Windows.Forms.Label
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox
        Me.Lbl_Puestos = New System.Windows.Forms.Label
        Me.Lbl_Depto = New System.Windows.Forms.Label
        Me.gbx_Actuales = New System.Windows.Forms.GroupBox
        Me.gbx_VerificaServiciosA = New System.Windows.Forms.GroupBox
        Me.rdb_No_VerificaServicio = New System.Windows.Forms.RadioButton
        Me.rdb_Si_VerificaServicio = New System.Windows.Forms.RadioButton
        Me.gbx_SaleaRutaA = New System.Windows.Forms.GroupBox
        Me.rdb_No_SaleaRuta = New System.Windows.Forms.RadioButton
        Me.rdb_Si_SaleaRuta = New System.Windows.Forms.RadioButton
        Me.Lbl_VerificaServ = New System.Windows.Forms.Label
        Me.Lbl_SaleRuta = New System.Windows.Forms.Label
        Me.tbx_SueldoDiarioA = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_SueldoDiarioDA = New System.Windows.Forms.Label
        Me.tbx_PuestoA = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_PuestoDA = New System.Windows.Forms.Label
        Me.tbx_DepartamentoA = New Modulo_Reclutamiento.cp_Textbox
        Me.Lbl_DeptoDA = New System.Windows.Forms.Label
        Me.gbx_Nuevos = New System.Windows.Forms.GroupBox
        Me.gbx_VerificaServiciosN = New System.Windows.Forms.GroupBox
        Me.rdb_No_VerificaServicioN = New System.Windows.Forms.RadioButton
        Me.rdb_Si_VerificaServicioN = New System.Windows.Forms.RadioButton
        Me.gbx_SaleaRutaN = New System.Windows.Forms.GroupBox
        Me.rdb_No_SaleaRutaN = New System.Windows.Forms.RadioButton
        Me.rdb_Si_SaleaRutaN = New System.Windows.Forms.RadioButton
        Me.Lbl_VerificaServDN = New System.Windows.Forms.Label
        Me.Lbl_SaleRutaDN = New System.Windows.Forms.Label
        Me.Lbl_SueldoDiarioDN = New System.Windows.Forms.Label
        Me.Lbl_PuestoDN = New System.Windows.Forms.Label
        Me.Lbl_DeptoDN = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.gbx_Promociones = New System.Windows.Forms.GroupBox
        Me.lsv_CatPromo = New Modulo_Reclutamiento.cp_Listview
        Me.lbl_Total = New System.Windows.Forms.Label
        Me.gbx_Consulta.SuspendLayout()
        Me.gbx_Actuales.SuspendLayout()
        Me.gbx_VerificaServiciosA.SuspendLayout()
        Me.gbx_SaleaRutaA.SuspendLayout()
        Me.gbx_Nuevos.SuspendLayout()
        Me.gbx_VerificaServiciosN.SuspendLayout()
        Me.gbx_SaleaRutaN.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.gbx_Promociones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Consulta
        '
        Me.gbx_Consulta.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Consulta.Controls.Add(Me.cmb_Empleados)
        Me.gbx_Consulta.Controls.Add(Me.Lbl_Empleados)
        Me.gbx_Consulta.Controls.Add(Me.cmb_PuestoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.chk_PuestoFiltro)
        Me.gbx_Consulta.Controls.Add(Me.Lbl_Puestos)
        Me.gbx_Consulta.Controls.Add(Me.Lbl_Depto)
        Me.gbx_Consulta.Location = New System.Drawing.Point(7, 2)
        Me.gbx_Consulta.Name = "gbx_Consulta"
        Me.gbx_Consulta.Size = New System.Drawing.Size(879, 103)
        Me.gbx_Consulta.TabIndex = 0
        Me.gbx_Consulta.TabStop = False
        '
        'cmb_Empleados
        '
        Me.cmb_Empleados.Clave = Nothing
        Me.cmb_Empleados.Control_Siguiente = Me.cmb_Departamento
        Me.cmb_Empleados.DisplayMember = "Nombre"
        Me.cmb_Empleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleados.Empresa = False
        Me.cmb_Empleados.Filtro = Nothing
        Me.cmb_Empleados.FormattingEnabled = True
        Me.cmb_Empleados.Location = New System.Drawing.Point(87, 70)
        Me.cmb_Empleados.MaxDropDownItems = 20
        Me.cmb_Empleados.Name = "cmb_Empleados"
        Me.cmb_Empleados.Pista = False
        Me.cmb_Empleados.Size = New System.Drawing.Size(481, 21)
        Me.cmb_Empleados.StoredProcedure = "Cat_Empleados_ComboGetByPuesto"
        Me.cmb_Empleados.Sucursal = True
        Me.cmb_Empleados.TabIndex = 6
        Me.cmb_Empleados.Tipo = 0
        Me.cmb_Empleados.ValueMember = "Id_Empleado"
        '
        'cmb_Departamento
        '
        Me.cmb_Departamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Departamento.Clave = Nothing
        Me.cmb_Departamento.Control_Siguiente = Me.cmb_Puesto
        Me.cmb_Departamento.DisplayMember = "Descripcion"
        Me.cmb_Departamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Departamento.Empresa = False
        Me.cmb_Departamento.Filtro = Nothing
        Me.cmb_Departamento.FormattingEnabled = True
        Me.cmb_Departamento.Location = New System.Drawing.Point(86, 19)
        Me.cmb_Departamento.MaxDropDownItems = 20
        Me.cmb_Departamento.Name = "cmb_Departamento"
        Me.cmb_Departamento.Pista = False
        Me.cmb_Departamento.Size = New System.Drawing.Size(348, 21)
        Me.cmb_Departamento.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_Departamento.Sucursal = False
        Me.cmb_Departamento.TabIndex = 1
        Me.cmb_Departamento.Tipo = 0
        Me.cmb_Departamento.ValueMember = "Id_Departamento"
        '
        'cmb_Puesto
        '
        Me.cmb_Puesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmb_Puesto.Clave = Nothing
        Me.cmb_Puesto.Control_Siguiente = Me.tbx_SueldoDiarioN
        Me.cmb_Puesto.DisplayMember = "Descripcion"
        Me.cmb_Puesto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puesto.Empresa = False
        Me.cmb_Puesto.Filtro = Nothing
        Me.cmb_Puesto.FormattingEnabled = True
        Me.cmb_Puesto.Location = New System.Drawing.Point(86, 46)
        Me.cmb_Puesto.MaxDropDownItems = 20
        Me.cmb_Puesto.Name = "cmb_Puesto"
        Me.cmb_Puesto.Pista = False
        Me.cmb_Puesto.Size = New System.Drawing.Size(348, 21)
        Me.cmb_Puesto.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_Puesto.Sucursal = False
        Me.cmb_Puesto.TabIndex = 3
        Me.cmb_Puesto.Tipo = 0
        Me.cmb_Puesto.ValueMember = "Id_Puesto"
        '
        'tbx_SueldoDiarioN
        '
        Me.tbx_SueldoDiarioN.Control_Siguiente = Nothing
        Me.tbx_SueldoDiarioN.Filtrado = True
        Me.tbx_SueldoDiarioN.Location = New System.Drawing.Point(86, 73)
        Me.tbx_SueldoDiarioN.MaxLength = 6
        Me.tbx_SueldoDiarioN.Name = "tbx_SueldoDiarioN"
        Me.tbx_SueldoDiarioN.Size = New System.Drawing.Size(110, 20)
        Me.tbx_SueldoDiarioN.TabIndex = 5
        Me.tbx_SueldoDiarioN.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_SueldoDiarioN.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Decimales
        '
        'Lbl_Empleados
        '
        Me.Lbl_Empleados.AutoSize = True
        Me.Lbl_Empleados.Location = New System.Drawing.Point(22, 73)
        Me.Lbl_Empleados.Name = "Lbl_Empleados"
        Me.Lbl_Empleados.Size = New System.Drawing.Size(59, 13)
        Me.Lbl_Empleados.TabIndex = 5
        Me.Lbl_Empleados.Text = "Empleados"
        '
        'cmb_PuestoFiltro
        '
        Me.cmb_PuestoFiltro.Clave = Nothing
        Me.cmb_PuestoFiltro.Control_Siguiente = Me.cmb_Empleados
        Me.cmb_PuestoFiltro.DisplayMember = "Descripcion"
        Me.cmb_PuestoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PuestoFiltro.Empresa = False
        Me.cmb_PuestoFiltro.Filtro = Nothing
        Me.cmb_PuestoFiltro.FormattingEnabled = True
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(87, 43)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(305, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 3
        Me.cmb_PuestoFiltro.Tipo = 0
        Me.cmb_PuestoFiltro.ValueMember = "Id_Puesto"
        '
        'cmb_DepartamentoFiltro
        '
        Me.cmb_DepartamentoFiltro.Clave = Nothing
        Me.cmb_DepartamentoFiltro.Control_Siguiente = Nothing
        Me.cmb_DepartamentoFiltro.DisplayMember = "Descripcion"
        Me.cmb_DepartamentoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DepartamentoFiltro.Empresa = False
        Me.cmb_DepartamentoFiltro.Filtro = Nothing
        Me.cmb_DepartamentoFiltro.FormattingEnabled = True
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(87, 14)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(305, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 1
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(398, 44)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 4
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'Lbl_Puestos
        '
        Me.Lbl_Puestos.AutoSize = True
        Me.Lbl_Puestos.Location = New System.Drawing.Point(41, 44)
        Me.Lbl_Puestos.Name = "Lbl_Puestos"
        Me.Lbl_Puestos.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Puestos.TabIndex = 2
        Me.Lbl_Puestos.Text = "Puesto"
        '
        'Lbl_Depto
        '
        Me.Lbl_Depto.AutoSize = True
        Me.Lbl_Depto.Location = New System.Drawing.Point(7, 17)
        Me.Lbl_Depto.Name = "Lbl_Depto"
        Me.Lbl_Depto.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Depto.TabIndex = 0
        Me.Lbl_Depto.Text = "Departamento"
        '
        'gbx_Actuales
        '
        Me.gbx_Actuales.Controls.Add(Me.gbx_VerificaServiciosA)
        Me.gbx_Actuales.Controls.Add(Me.gbx_SaleaRutaA)
        Me.gbx_Actuales.Controls.Add(Me.Lbl_VerificaServ)
        Me.gbx_Actuales.Controls.Add(Me.Lbl_SaleRuta)
        Me.gbx_Actuales.Controls.Add(Me.tbx_SueldoDiarioA)
        Me.gbx_Actuales.Controls.Add(Me.Lbl_SueldoDiarioDA)
        Me.gbx_Actuales.Controls.Add(Me.tbx_PuestoA)
        Me.gbx_Actuales.Controls.Add(Me.Lbl_PuestoDA)
        Me.gbx_Actuales.Controls.Add(Me.tbx_DepartamentoA)
        Me.gbx_Actuales.Controls.Add(Me.Lbl_DeptoDA)
        Me.gbx_Actuales.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Actuales.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Actuales.Name = "gbx_Actuales"
        Me.gbx_Actuales.Size = New System.Drawing.Size(434, 142)
        Me.gbx_Actuales.TabIndex = 0
        Me.gbx_Actuales.TabStop = False
        Me.gbx_Actuales.Text = "Datos Actuales"
        '
        'gbx_VerificaServiciosA
        '
        Me.gbx_VerificaServiciosA.Controls.Add(Me.rdb_No_VerificaServicio)
        Me.gbx_VerificaServiciosA.Controls.Add(Me.rdb_Si_VerificaServicio)
        Me.gbx_VerificaServiciosA.Location = New System.Drawing.Point(291, 98)
        Me.gbx_VerificaServiciosA.Name = "gbx_VerificaServiciosA"
        Me.gbx_VerificaServiciosA.Size = New System.Drawing.Size(104, 33)
        Me.gbx_VerificaServiciosA.TabIndex = 9
        Me.gbx_VerificaServiciosA.TabStop = False
        '
        'rdb_No_VerificaServicio
        '
        Me.rdb_No_VerificaServicio.AutoSize = True
        Me.rdb_No_VerificaServicio.Enabled = False
        Me.rdb_No_VerificaServicio.Location = New System.Drawing.Point(60, 11)
        Me.rdb_No_VerificaServicio.Name = "rdb_No_VerificaServicio"
        Me.rdb_No_VerificaServicio.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_VerificaServicio.TabIndex = 1
        Me.rdb_No_VerificaServicio.Text = "No"
        Me.rdb_No_VerificaServicio.UseVisualStyleBackColor = True
        '
        'rdb_Si_VerificaServicio
        '
        Me.rdb_Si_VerificaServicio.AutoSize = True
        Me.rdb_Si_VerificaServicio.Enabled = False
        Me.rdb_Si_VerificaServicio.Location = New System.Drawing.Point(11, 11)
        Me.rdb_Si_VerificaServicio.Name = "rdb_Si_VerificaServicio"
        Me.rdb_Si_VerificaServicio.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_VerificaServicio.TabIndex = 0
        Me.rdb_Si_VerificaServicio.Text = "Si"
        Me.rdb_Si_VerificaServicio.UseVisualStyleBackColor = True
        '
        'gbx_SaleaRutaA
        '
        Me.gbx_SaleaRutaA.Controls.Add(Me.rdb_No_SaleaRuta)
        Me.gbx_SaleaRutaA.Controls.Add(Me.rdb_Si_SaleaRuta)
        Me.gbx_SaleaRutaA.Location = New System.Drawing.Point(87, 98)
        Me.gbx_SaleaRutaA.Name = "gbx_SaleaRutaA"
        Me.gbx_SaleaRutaA.Size = New System.Drawing.Size(104, 33)
        Me.gbx_SaleaRutaA.TabIndex = 7
        Me.gbx_SaleaRutaA.TabStop = False
        '
        'rdb_No_SaleaRuta
        '
        Me.rdb_No_SaleaRuta.AutoSize = True
        Me.rdb_No_SaleaRuta.Enabled = False
        Me.rdb_No_SaleaRuta.Location = New System.Drawing.Point(60, 11)
        Me.rdb_No_SaleaRuta.Name = "rdb_No_SaleaRuta"
        Me.rdb_No_SaleaRuta.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_SaleaRuta.TabIndex = 1
        Me.rdb_No_SaleaRuta.Text = "No"
        Me.rdb_No_SaleaRuta.UseVisualStyleBackColor = True
        '
        'rdb_Si_SaleaRuta
        '
        Me.rdb_Si_SaleaRuta.AutoSize = True
        Me.rdb_Si_SaleaRuta.Enabled = False
        Me.rdb_Si_SaleaRuta.Location = New System.Drawing.Point(11, 11)
        Me.rdb_Si_SaleaRuta.Name = "rdb_Si_SaleaRuta"
        Me.rdb_Si_SaleaRuta.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_SaleaRuta.TabIndex = 0
        Me.rdb_Si_SaleaRuta.Text = "Si"
        Me.rdb_Si_SaleaRuta.UseVisualStyleBackColor = True
        '
        'Lbl_VerificaServ
        '
        Me.Lbl_VerificaServ.AutoSize = True
        Me.Lbl_VerificaServ.Location = New System.Drawing.Point(197, 111)
        Me.Lbl_VerificaServ.Name = "Lbl_VerificaServ"
        Me.Lbl_VerificaServ.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_VerificaServ.TabIndex = 8
        Me.Lbl_VerificaServ.Text = "Verifica Servicios"
        '
        'Lbl_SaleRuta
        '
        Me.Lbl_SaleRuta.AutoSize = True
        Me.Lbl_SaleRuta.Location = New System.Drawing.Point(18, 111)
        Me.Lbl_SaleRuta.Name = "Lbl_SaleRuta"
        Me.Lbl_SaleRuta.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_SaleRuta.TabIndex = 6
        Me.Lbl_SaleRuta.Text = "Sale a Ruta"
        '
        'tbx_SueldoDiarioA
        '
        Me.tbx_SueldoDiarioA.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_SueldoDiarioA.Control_Siguiente = Nothing
        Me.tbx_SueldoDiarioA.Filtrado = True
        Me.tbx_SueldoDiarioA.Location = New System.Drawing.Point(87, 72)
        Me.tbx_SueldoDiarioA.Name = "tbx_SueldoDiarioA"
        Me.tbx_SueldoDiarioA.ReadOnly = True
        Me.tbx_SueldoDiarioA.Size = New System.Drawing.Size(104, 20)
        Me.tbx_SueldoDiarioA.TabIndex = 5
        Me.tbx_SueldoDiarioA.TabStop = False
        Me.tbx_SueldoDiarioA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_SueldoDiarioA.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Lbl_SueldoDiarioDA
        '
        Me.Lbl_SueldoDiarioDA.AutoSize = True
        Me.Lbl_SueldoDiarioDA.Location = New System.Drawing.Point(10, 75)
        Me.Lbl_SueldoDiarioDA.Name = "Lbl_SueldoDiarioDA"
        Me.Lbl_SueldoDiarioDA.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_SueldoDiarioDA.TabIndex = 4
        Me.Lbl_SueldoDiarioDA.Text = "Sueldo Diario"
        '
        'tbx_PuestoA
        '
        Me.tbx_PuestoA.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_PuestoA.Control_Siguiente = Nothing
        Me.tbx_PuestoA.Filtrado = True
        Me.tbx_PuestoA.Location = New System.Drawing.Point(87, 46)
        Me.tbx_PuestoA.Name = "tbx_PuestoA"
        Me.tbx_PuestoA.ReadOnly = True
        Me.tbx_PuestoA.Size = New System.Drawing.Size(341, 20)
        Me.tbx_PuestoA.TabIndex = 3
        Me.tbx_PuestoA.TabStop = False
        Me.tbx_PuestoA.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Lbl_PuestoDA
        '
        Me.Lbl_PuestoDA.AutoSize = True
        Me.Lbl_PuestoDA.Location = New System.Drawing.Point(41, 49)
        Me.Lbl_PuestoDA.Name = "Lbl_PuestoDA"
        Me.Lbl_PuestoDA.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoDA.TabIndex = 2
        Me.Lbl_PuestoDA.Text = "Puesto"
        '
        'tbx_DepartamentoA
        '
        Me.tbx_DepartamentoA.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_DepartamentoA.Control_Siguiente = Nothing
        Me.tbx_DepartamentoA.Filtrado = True
        Me.tbx_DepartamentoA.Location = New System.Drawing.Point(87, 19)
        Me.tbx_DepartamentoA.Name = "tbx_DepartamentoA"
        Me.tbx_DepartamentoA.ReadOnly = True
        Me.tbx_DepartamentoA.Size = New System.Drawing.Size(341, 20)
        Me.tbx_DepartamentoA.TabIndex = 1
        Me.tbx_DepartamentoA.TabStop = False
        Me.tbx_DepartamentoA.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'Lbl_DeptoDA
        '
        Me.Lbl_DeptoDA.AutoSize = True
        Me.Lbl_DeptoDA.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_DeptoDA.Name = "Lbl_DeptoDA"
        Me.Lbl_DeptoDA.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DeptoDA.TabIndex = 0
        Me.Lbl_DeptoDA.Text = "Departamento"
        '
        'gbx_Nuevos
        '
        Me.gbx_Nuevos.Controls.Add(Me.cmb_Puesto)
        Me.gbx_Nuevos.Controls.Add(Me.cmb_Departamento)
        Me.gbx_Nuevos.Controls.Add(Me.gbx_VerificaServiciosN)
        Me.gbx_Nuevos.Controls.Add(Me.gbx_SaleaRutaN)
        Me.gbx_Nuevos.Controls.Add(Me.Lbl_VerificaServDN)
        Me.gbx_Nuevos.Controls.Add(Me.Lbl_SaleRutaDN)
        Me.gbx_Nuevos.Controls.Add(Me.Lbl_SueldoDiarioDN)
        Me.gbx_Nuevos.Controls.Add(Me.Lbl_PuestoDN)
        Me.gbx_Nuevos.Controls.Add(Me.Lbl_DeptoDN)
        Me.gbx_Nuevos.Controls.Add(Me.tbx_SueldoDiarioN)
        Me.gbx_Nuevos.Dock = System.Windows.Forms.DockStyle.Fill
        Me.gbx_Nuevos.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Nuevos.Name = "gbx_Nuevos"
        Me.gbx_Nuevos.Size = New System.Drawing.Size(441, 142)
        Me.gbx_Nuevos.TabIndex = 0
        Me.gbx_Nuevos.TabStop = False
        Me.gbx_Nuevos.Text = "Datos Nuevos"
        '
        'gbx_VerificaServiciosN
        '
        Me.gbx_VerificaServiciosN.Controls.Add(Me.rdb_No_VerificaServicioN)
        Me.gbx_VerificaServiciosN.Controls.Add(Me.rdb_Si_VerificaServicioN)
        Me.gbx_VerificaServiciosN.Location = New System.Drawing.Point(290, 99)
        Me.gbx_VerificaServiciosN.Name = "gbx_VerificaServiciosN"
        Me.gbx_VerificaServiciosN.Size = New System.Drawing.Size(104, 33)
        Me.gbx_VerificaServiciosN.TabIndex = 9
        Me.gbx_VerificaServiciosN.TabStop = False
        '
        'rdb_No_VerificaServicioN
        '
        Me.rdb_No_VerificaServicioN.AutoSize = True
        Me.rdb_No_VerificaServicioN.Location = New System.Drawing.Point(60, 11)
        Me.rdb_No_VerificaServicioN.Name = "rdb_No_VerificaServicioN"
        Me.rdb_No_VerificaServicioN.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_VerificaServicioN.TabIndex = 1
        Me.rdb_No_VerificaServicioN.Text = "No"
        Me.rdb_No_VerificaServicioN.UseVisualStyleBackColor = True
        '
        'rdb_Si_VerificaServicioN
        '
        Me.rdb_Si_VerificaServicioN.AutoSize = True
        Me.rdb_Si_VerificaServicioN.Location = New System.Drawing.Point(11, 11)
        Me.rdb_Si_VerificaServicioN.Name = "rdb_Si_VerificaServicioN"
        Me.rdb_Si_VerificaServicioN.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_VerificaServicioN.TabIndex = 0
        Me.rdb_Si_VerificaServicioN.Text = "Si"
        Me.rdb_Si_VerificaServicioN.UseVisualStyleBackColor = True
        '
        'gbx_SaleaRutaN
        '
        Me.gbx_SaleaRutaN.Controls.Add(Me.rdb_No_SaleaRutaN)
        Me.gbx_SaleaRutaN.Controls.Add(Me.rdb_Si_SaleaRutaN)
        Me.gbx_SaleaRutaN.Location = New System.Drawing.Point(86, 99)
        Me.gbx_SaleaRutaN.Name = "gbx_SaleaRutaN"
        Me.gbx_SaleaRutaN.Size = New System.Drawing.Size(104, 33)
        Me.gbx_SaleaRutaN.TabIndex = 7
        Me.gbx_SaleaRutaN.TabStop = False
        '
        'rdb_No_SaleaRutaN
        '
        Me.rdb_No_SaleaRutaN.AutoSize = True
        Me.rdb_No_SaleaRutaN.Location = New System.Drawing.Point(60, 11)
        Me.rdb_No_SaleaRutaN.Name = "rdb_No_SaleaRutaN"
        Me.rdb_No_SaleaRutaN.Size = New System.Drawing.Size(39, 17)
        Me.rdb_No_SaleaRutaN.TabIndex = 1
        Me.rdb_No_SaleaRutaN.Text = "No"
        Me.rdb_No_SaleaRutaN.UseVisualStyleBackColor = True
        '
        'rdb_Si_SaleaRutaN
        '
        Me.rdb_Si_SaleaRutaN.AutoSize = True
        Me.rdb_Si_SaleaRutaN.Location = New System.Drawing.Point(11, 11)
        Me.rdb_Si_SaleaRutaN.Name = "rdb_Si_SaleaRutaN"
        Me.rdb_Si_SaleaRutaN.Size = New System.Drawing.Size(34, 17)
        Me.rdb_Si_SaleaRutaN.TabIndex = 0
        Me.rdb_Si_SaleaRutaN.Text = "Si"
        Me.rdb_Si_SaleaRutaN.UseVisualStyleBackColor = True
        '
        'Lbl_VerificaServDN
        '
        Me.Lbl_VerificaServDN.AutoSize = True
        Me.Lbl_VerificaServDN.Location = New System.Drawing.Point(196, 111)
        Me.Lbl_VerificaServDN.Name = "Lbl_VerificaServDN"
        Me.Lbl_VerificaServDN.Size = New System.Drawing.Size(88, 13)
        Me.Lbl_VerificaServDN.TabIndex = 8
        Me.Lbl_VerificaServDN.Text = "Verifica Servicios"
        '
        'Lbl_SaleRutaDN
        '
        Me.Lbl_SaleRutaDN.AutoSize = True
        Me.Lbl_SaleRutaDN.Location = New System.Drawing.Point(17, 111)
        Me.Lbl_SaleRutaDN.Name = "Lbl_SaleRutaDN"
        Me.Lbl_SaleRutaDN.Size = New System.Drawing.Size(63, 13)
        Me.Lbl_SaleRutaDN.TabIndex = 6
        Me.Lbl_SaleRutaDN.Text = "Sale a Ruta"
        '
        'Lbl_SueldoDiarioDN
        '
        Me.Lbl_SueldoDiarioDN.AutoSize = True
        Me.Lbl_SueldoDiarioDN.Location = New System.Drawing.Point(10, 76)
        Me.Lbl_SueldoDiarioDN.Name = "Lbl_SueldoDiarioDN"
        Me.Lbl_SueldoDiarioDN.Size = New System.Drawing.Size(70, 13)
        Me.Lbl_SueldoDiarioDN.TabIndex = 4
        Me.Lbl_SueldoDiarioDN.Text = "Sueldo Diario"
        '
        'Lbl_PuestoDN
        '
        Me.Lbl_PuestoDN.AutoSize = True
        Me.Lbl_PuestoDN.Location = New System.Drawing.Point(40, 49)
        Me.Lbl_PuestoDN.Name = "Lbl_PuestoDN"
        Me.Lbl_PuestoDN.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoDN.TabIndex = 2
        Me.Lbl_PuestoDN.Text = "Puesto"
        '
        'Lbl_DeptoDN
        '
        Me.Lbl_DeptoDN.AutoSize = True
        Me.Lbl_DeptoDN.Location = New System.Drawing.Point(6, 22)
        Me.Lbl_DeptoDN.Name = "Lbl_DeptoDN"
        Me.Lbl_DeptoDN.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DeptoDN.TabIndex = 0
        Me.Lbl_DeptoDN.Text = "Departamento"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 511)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(879, 50)
        Me.Gbx_Botones.TabIndex = 3
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(152, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 1
        Me.btn_Cancelar.Text = "C&ancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(733, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(7, 363)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.gbx_Actuales)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.gbx_Nuevos)
        Me.SplitContainer1.Size = New System.Drawing.Size(879, 142)
        Me.SplitContainer1.SplitterDistance = 434
        Me.SplitContainer1.TabIndex = 2
        '
        'gbx_Promociones
        '
        Me.gbx_Promociones.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Promociones.Controls.Add(Me.lsv_CatPromo)
        Me.gbx_Promociones.Controls.Add(Me.lbl_Total)
        Me.gbx_Promociones.Location = New System.Drawing.Point(7, 111)
        Me.gbx_Promociones.Name = "gbx_Promociones"
        Me.gbx_Promociones.Size = New System.Drawing.Size(879, 246)
        Me.gbx_Promociones.TabIndex = 1
        Me.gbx_Promociones.TabStop = False
        Me.gbx_Promociones.Text = "Promociones"
        '
        'lsv_CatPromo
        '
        Me.lsv_CatPromo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_CatPromo.FullRowSelect = True
        Me.lsv_CatPromo.HideSelection = False
        Me.lsv_CatPromo.Location = New System.Drawing.Point(6, 32)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_CatPromo.Lvs = ListViewColumnSorter1
        Me.lsv_CatPromo.MultiSelect = False
        Me.lsv_CatPromo.Name = "lsv_CatPromo"
        Me.lsv_CatPromo.Row1 = 20
        Me.lsv_CatPromo.Row10 = 0
        Me.lsv_CatPromo.Row2 = 12
        Me.lsv_CatPromo.Row3 = 12
        Me.lsv_CatPromo.Row4 = 8
        Me.lsv_CatPromo.Row5 = 12
        Me.lsv_CatPromo.Row6 = 12
        Me.lsv_CatPromo.Row7 = 8
        Me.lsv_CatPromo.Row8 = 0
        Me.lsv_CatPromo.Row9 = 0
        Me.lsv_CatPromo.Size = New System.Drawing.Size(867, 208)
        Me.lsv_CatPromo.TabIndex = 1
        Me.lsv_CatPromo.UseCompatibleStateImageBehavior = False
        Me.lsv_CatPromo.View = System.Windows.Forms.View.Details
        '
        'lbl_Total
        '
        Me.lbl_Total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Total.Location = New System.Drawing.Point(728, 16)
        Me.lbl_Total.Name = "lbl_Total"
        Me.lbl_Total.Size = New System.Drawing.Size(145, 13)
        Me.lbl_Total.TabIndex = 0
        Me.lbl_Total.Text = "Registros: 0"
        Me.lbl_Total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frm_PromocionEmpleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(894, 571)
        Me.Controls.Add(Me.gbx_Promociones)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.gbx_Consulta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_PromocionEmpleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Promoción de Empleados"
        Me.gbx_Consulta.ResumeLayout(False)
        Me.gbx_Consulta.PerformLayout()
        Me.gbx_Actuales.ResumeLayout(False)
        Me.gbx_Actuales.PerformLayout()
        Me.gbx_VerificaServiciosA.ResumeLayout(False)
        Me.gbx_VerificaServiciosA.PerformLayout()
        Me.gbx_SaleaRutaA.ResumeLayout(False)
        Me.gbx_SaleaRutaA.PerformLayout()
        Me.gbx_Nuevos.ResumeLayout(False)
        Me.gbx_Nuevos.PerformLayout()
        Me.gbx_VerificaServiciosN.ResumeLayout(False)
        Me.gbx_VerificaServiciosN.PerformLayout()
        Me.gbx_SaleaRutaN.ResumeLayout(False)
        Me.gbx_SaleaRutaN.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.gbx_Promociones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Consulta As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Puestos As System.Windows.Forms.Label
    Friend WithEvents Lbl_Depto As System.Windows.Forms.Label
    Friend WithEvents Lbl_Empleados As System.Windows.Forms.Label
    Friend WithEvents cmb_Empleados As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Actuales As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Nuevos As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tbx_DepartamentoA As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_DeptoDA As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoDiarioA As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_SueldoDiarioDA As System.Windows.Forms.Label
    Friend WithEvents tbx_PuestoA As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Lbl_PuestoDA As System.Windows.Forms.Label
    Friend WithEvents Lbl_VerificaServ As System.Windows.Forms.Label
    Friend WithEvents Lbl_SaleRuta As System.Windows.Forms.Label
    Friend WithEvents gbx_SaleaRutaA As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_SaleaRuta As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_SaleaRuta As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_VerificaServiciosA As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_VerificaServicio As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_VerificaServicio As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_VerificaServiciosN As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_VerificaServicioN As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_VerificaServicioN As System.Windows.Forms.RadioButton
    Friend WithEvents gbx_SaleaRutaN As System.Windows.Forms.GroupBox
    Friend WithEvents rdb_No_SaleaRutaN As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Si_SaleaRutaN As System.Windows.Forms.RadioButton
    Friend WithEvents Lbl_VerificaServDN As System.Windows.Forms.Label
    Friend WithEvents Lbl_SaleRutaDN As System.Windows.Forms.Label
    Friend WithEvents Lbl_SueldoDiarioDN As System.Windows.Forms.Label
    Friend WithEvents Lbl_PuestoDN As System.Windows.Forms.Label
    Friend WithEvents Lbl_DeptoDN As System.Windows.Forms.Label
    Friend WithEvents tbx_SueldoDiarioN As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Puesto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Departamento As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents gbx_Promociones As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_Total As System.Windows.Forms.Label
    Friend WithEvents lsv_CatPromo As Modulo_Reclutamiento.cp_Listview
End Class
