<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosCartas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_EmpleadosCartas))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.btn_ConstanciaBaja = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_ConstanciaIngresos = New System.Windows.Forms.Button
        Me.chk_PuestoFiltro = New System.Windows.Forms.CheckBox
        Me.chk_DepartamentoFiltro = New System.Windows.Forms.CheckBox
        Me.Lbl_Puesto = New System.Windows.Forms.Label
        Me.Lbl_Departamento = New System.Windows.Forms.Label
        Me.btn_MostrarCatalogo = New System.Windows.Forms.Button
        Me.Gbx_Lista = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.chk_Status = New System.Windows.Forms.CheckBox
        Me.Lbl_Status = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_CartaRecomendacion = New System.Windows.Forms.Button
        Me.btn_CartaBecas = New System.Windows.Forms.Button
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.lsv_Catalogo = New Modulo_Reclutamiento.cp_Listview
        Me.Gbx_Lista.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_ConstanciaBaja
        '
        Me.btn_ConstanciaBaja.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ConstanciaBaja.Location = New System.Drawing.Point(286, 19)
        Me.btn_ConstanciaBaja.Name = "btn_ConstanciaBaja"
        Me.btn_ConstanciaBaja.Size = New System.Drawing.Size(130, 30)
        Me.btn_ConstanciaBaja.TabIndex = 0
        Me.btn_ConstanciaBaja.Text = "Constancia Baja"
        Me.btn_ConstanciaBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConstanciaBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ConstanciaBaja.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(633, 19)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_ConstanciaIngresos
        '
        Me.btn_ConstanciaIngresos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ConstanciaIngresos.Location = New System.Drawing.Point(4, 19)
        Me.btn_ConstanciaIngresos.Name = "btn_ConstanciaIngresos"
        Me.btn_ConstanciaIngresos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ConstanciaIngresos.TabIndex = 2
        Me.btn_ConstanciaIngresos.Text = "Constancia Ingresos"
        Me.btn_ConstanciaIngresos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConstanciaIngresos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ConstanciaIngresos.UseVisualStyleBackColor = True
        '
        'chk_PuestoFiltro
        '
        Me.chk_PuestoFiltro.AutoSize = True
        Me.chk_PuestoFiltro.Location = New System.Drawing.Point(420, 43)
        Me.chk_PuestoFiltro.Name = "chk_PuestoFiltro"
        Me.chk_PuestoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_PuestoFiltro.TabIndex = 21
        Me.chk_PuestoFiltro.Text = "Todos"
        Me.chk_PuestoFiltro.UseVisualStyleBackColor = True
        '
        'chk_DepartamentoFiltro
        '
        Me.chk_DepartamentoFiltro.AutoSize = True
        Me.chk_DepartamentoFiltro.Location = New System.Drawing.Point(420, 17)
        Me.chk_DepartamentoFiltro.Name = "chk_DepartamentoFiltro"
        Me.chk_DepartamentoFiltro.Size = New System.Drawing.Size(56, 17)
        Me.chk_DepartamentoFiltro.TabIndex = 18
        Me.chk_DepartamentoFiltro.Text = "Todos"
        Me.chk_DepartamentoFiltro.UseVisualStyleBackColor = True
        '
        'Lbl_Puesto
        '
        Me.Lbl_Puesto.AutoSize = True
        Me.Lbl_Puesto.Location = New System.Drawing.Point(45, 42)
        Me.Lbl_Puesto.Name = "Lbl_Puesto"
        Me.Lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_Puesto.TabIndex = 19
        Me.Lbl_Puesto.Text = "Puesto"
        '
        'Lbl_Departamento
        '
        Me.Lbl_Departamento.AutoSize = True
        Me.Lbl_Departamento.Location = New System.Drawing.Point(11, 17)
        Me.Lbl_Departamento.Name = "Lbl_Departamento"
        Me.Lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_Departamento.TabIndex = 16
        Me.Lbl_Departamento.Text = "Departamento"
        '
        'btn_MostrarCatalogo
        '
        Me.btn_MostrarCatalogo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_MostrarCatalogo.Location = New System.Drawing.Point(528, 31)
        Me.btn_MostrarCatalogo.Name = "btn_MostrarCatalogo"
        Me.btn_MostrarCatalogo.Size = New System.Drawing.Size(130, 29)
        Me.btn_MostrarCatalogo.TabIndex = 22
        Me.btn_MostrarCatalogo.Text = "M&ostrar"
        Me.btn_MostrarCatalogo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_MostrarCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_MostrarCatalogo.UseVisualStyleBackColor = True
        '
        'Gbx_Lista
        '
        Me.Gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Lista.Controls.Add(Me.Lbl_Numero)
        Me.Gbx_Lista.Controls.Add(Me.lsv_Catalogo)
        Me.Gbx_Lista.Location = New System.Drawing.Point(8, 118)
        Me.Gbx_Lista.Name = "Gbx_Lista"
        Me.Gbx_Lista.Size = New System.Drawing.Size(769, 366)
        Me.Gbx_Lista.TabIndex = 23
        Me.Gbx_Lista.TabStop = False
        Me.Gbx_Lista.Text = "Detalle"
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(541, 14)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 23
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.chk_Status)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Status)
        Me.Gbx_Filtro.Controls.Add(Me.btn_MostrarCatalogo)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Departamento)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_PuestoFiltro)
        Me.Gbx_Filtro.Controls.Add(Me.Lbl_Puesto)
        Me.Gbx_Filtro.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.Gbx_Filtro.Controls.Add(Me.chk_DepartamentoFiltro)
        Me.Gbx_Filtro.Controls.Add(Me.chk_PuestoFiltro)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(8, 12)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(769, 100)
        Me.Gbx_Filtro.TabIndex = 24
        Me.Gbx_Filtro.TabStop = False
        Me.Gbx_Filtro.Text = "Datos"
        '
        'chk_Status
        '
        Me.chk_Status.AutoSize = True
        Me.chk_Status.Location = New System.Drawing.Point(326, 69)
        Me.chk_Status.Name = "chk_Status"
        Me.chk_Status.Size = New System.Drawing.Size(56, 17)
        Me.chk_Status.TabIndex = 25
        Me.chk_Status.Text = "Todos"
        Me.chk_Status.UseVisualStyleBackColor = True
        '
        'Lbl_Status
        '
        Me.Lbl_Status.AutoSize = True
        Me.Lbl_Status.Location = New System.Drawing.Point(48, 69)
        Me.Lbl_Status.Name = "Lbl_Status"
        Me.Lbl_Status.Size = New System.Drawing.Size(37, 13)
        Me.Lbl_Status.TabIndex = 23
        Me.Lbl_Status.Text = "Status"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_CartaRecomendacion)
        Me.Gbx_Botones.Controls.Add(Me.btn_CartaBecas)
        Me.Gbx_Botones.Controls.Add(Me.btn_ConstanciaBaja)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_ConstanciaIngresos)
        Me.Gbx_Botones.Location = New System.Drawing.Point(8, 490)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(769, 59)
        Me.Gbx_Botones.TabIndex = 25
        Me.Gbx_Botones.TabStop = False
        Me.Gbx_Botones.Text = "Imprimir"
        '
        'btn_CartaRecomendacion
        '
        Me.btn_CartaRecomendacion.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_CartaRecomendacion.Location = New System.Drawing.Point(422, 19)
        Me.btn_CartaRecomendacion.Name = "btn_CartaRecomendacion"
        Me.btn_CartaRecomendacion.Size = New System.Drawing.Size(145, 30)
        Me.btn_CartaRecomendacion.TabIndex = 4
        Me.btn_CartaRecomendacion.Text = "Carta Recomendacion"
        Me.btn_CartaRecomendacion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CartaRecomendacion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CartaRecomendacion.UseVisualStyleBackColor = True
        '
        'btn_CartaBecas
        '
        Me.btn_CartaBecas.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_CartaBecas.Location = New System.Drawing.Point(150, 19)
        Me.btn_CartaBecas.Name = "btn_CartaBecas"
        Me.btn_CartaBecas.Size = New System.Drawing.Size(130, 30)
        Me.btn_CartaBecas.TabIndex = 3
        Me.btn_CartaBecas.Text = "Carta para Becas"
        Me.btn_CartaBecas.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_CartaBecas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_CartaBecas.UseVisualStyleBackColor = True
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(91, 66)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(228, 21)
        Me.cmb_Status.TabIndex = 24
        Me.cmb_Status.ValueMember = "value"
        '
        'cmb_PuestoFiltro
        '
        Me.cmb_PuestoFiltro.Clave = Nothing
        Me.cmb_PuestoFiltro.Control_Siguiente = Nothing
        Me.cmb_PuestoFiltro.DisplayMember = "Descripcion"
        Me.cmb_PuestoFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PuestoFiltro.Empresa = False
        Me.cmb_PuestoFiltro.Filtro = Nothing
        Me.cmb_PuestoFiltro.FormattingEnabled = True
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(91, 39)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_PuestoFiltro.StoredProcedure = "Cat_PuestosCombo_Get"
        Me.cmb_PuestoFiltro.Sucursal = False
        Me.cmb_PuestoFiltro.TabIndex = 20
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(91, 14)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 17
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'lsv_Catalogo
        '
        Me.lsv_Catalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Catalogo.FullRowSelect = True
        Me.lsv_Catalogo.HideSelection = False
        Me.lsv_Catalogo.Location = New System.Drawing.Point(6, 40)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Catalogo.Lvs = ListViewColumnSorter1
        Me.lsv_Catalogo.MultiSelect = False
        Me.lsv_Catalogo.Name = "lsv_Catalogo"
        Me.lsv_Catalogo.Row1 = 8
        Me.lsv_Catalogo.Row10 = 0
        Me.lsv_Catalogo.Row2 = 31
        Me.lsv_Catalogo.Row3 = 14
        Me.lsv_Catalogo.Row4 = 23
        Me.lsv_Catalogo.Row5 = 8
        Me.lsv_Catalogo.Row6 = 12
        Me.lsv_Catalogo.Row7 = 0
        Me.lsv_Catalogo.Row8 = 0
        Me.lsv_Catalogo.Row9 = 0
        Me.lsv_Catalogo.Size = New System.Drawing.Size(757, 320)
        Me.lsv_Catalogo.TabIndex = 15
        Me.lsv_Catalogo.Tag = "Id"
        Me.lsv_Catalogo.UseCompatibleStateImageBehavior = False
        Me.lsv_Catalogo.View = System.Windows.Forms.View.Details
        '
        'frm_EmpleadosCartas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Controls.Add(Me.Gbx_Lista)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_EmpleadosCartas"
        Me.Text = "Expedicion de tipos de Cartas"
        Me.Gbx_Lista.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.Gbx_Filtro.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ConstanciaBaja As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ConstanciaIngresos As System.Windows.Forms.Button
    Friend WithEvents lsv_Catalogo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents chk_PuestoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents chk_DepartamentoFiltro As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents Lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents btn_MostrarCatalogo As System.Windows.Forms.Button
    Friend WithEvents Gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_CartaRecomendacion As System.Windows.Forms.Button
    Friend WithEvents btn_CartaBecas As System.Windows.Forms.Button
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Lbl_Status As System.Windows.Forms.Label
    Friend WithEvents chk_Status As System.Windows.Forms.CheckBox
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label

End Class
