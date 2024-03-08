<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImplementosAsignar
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
        Me.lbl_Nombre_Baja = New System.Windows.Forms.Label
        Me.lbl_Implemento = New System.Windows.Forms.Label
        Me.lbl_StockMinimo = New System.Windows.Forms.Label
        Me.lbl_Observaciones = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.btn_Borrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.Lbl_PuestoL = New System.Windows.Forms.Label
        Me.Lbl_DepartamentoL = New System.Windows.Forms.Label
        Me.lsv_Implementos = New Modulo_Reclutamiento.cp_Listview
        Me.cmb_Empleado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Comentarios = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Implementos = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Cantidad = New Modulo_Reclutamiento.cp_Textbox
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre_Baja
        '
        Me.lbl_Nombre_Baja.AutoSize = True
        Me.lbl_Nombre_Baja.Location = New System.Drawing.Point(25, 69)
        Me.lbl_Nombre_Baja.Name = "lbl_Nombre_Baja"
        Me.lbl_Nombre_Baja.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Nombre_Baja.TabIndex = 4
        Me.lbl_Nombre_Baja.Text = "Empleado"
        Me.lbl_Nombre_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Implemento
        '
        Me.lbl_Implemento.AutoSize = True
        Me.lbl_Implemento.Location = New System.Drawing.Point(18, 96)
        Me.lbl_Implemento.Name = "lbl_Implemento"
        Me.lbl_Implemento.Size = New System.Drawing.Size(61, 13)
        Me.lbl_Implemento.TabIndex = 6
        Me.lbl_Implemento.Text = "Implemento"
        '
        'lbl_StockMinimo
        '
        Me.lbl_StockMinimo.AutoSize = True
        Me.lbl_StockMinimo.Location = New System.Drawing.Point(30, 122)
        Me.lbl_StockMinimo.Name = "lbl_StockMinimo"
        Me.lbl_StockMinimo.Size = New System.Drawing.Size(49, 13)
        Me.lbl_StockMinimo.TabIndex = 8
        Me.lbl_StockMinimo.Text = "Cantidad"
        Me.lbl_StockMinimo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lbl_Observaciones
        '
        Me.lbl_Observaciones.AutoSize = True
        Me.lbl_Observaciones.Location = New System.Drawing.Point(14, 148)
        Me.lbl_Observaciones.Name = "lbl_Observaciones"
        Me.lbl_Observaciones.Size = New System.Drawing.Size(65, 13)
        Me.lbl_Observaciones.TabIndex = 10
        Me.lbl_Observaciones.Text = "Comentarios"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(623, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Agregar
        Me.btn_Agregar.Location = New System.Drawing.Point(441, 135)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 12
        Me.btn_Agregar.Text = "&Agregar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'btn_Borrar
        '
        Me.btn_Borrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Baja
        Me.btn_Borrar.Location = New System.Drawing.Point(587, 135)
        Me.btn_Borrar.Name = "btn_Borrar"
        Me.btn_Borrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Borrar.TabIndex = 1
        Me.btn_Borrar.Text = "&Borrar"
        Me.btn_Borrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Borrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Borrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.cmb_PuestoFiltro)
        Me.Gbx_Listado.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.Gbx_Listado.Controls.Add(Me.btn_Borrar)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_PuestoL)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_DepartamentoL)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Implementos)
        Me.Gbx_Listado.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Observaciones)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Nombre_Baja)
        Me.Gbx_Listado.Controls.Add(Me.cmb_Empleado)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Clave)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Comentarios)
        Me.Gbx_Listado.Controls.Add(Me.cmb_Implementos)
        Me.Gbx_Listado.Controls.Add(Me.lbl_StockMinimo)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Implemento)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Cantidad)
        Me.Gbx_Listado.Location = New System.Drawing.Point(7, 2)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(769, 594)
        Me.Gbx_Listado.TabIndex = 0
        Me.Gbx_Listado.TabStop = False
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(85, 38)
        Me.cmb_PuestoFiltro.MaxDropDownItems = 20
        Me.cmb_PuestoFiltro.Name = "cmb_PuestoFiltro"
        Me.cmb_PuestoFiltro.Pista = False
        Me.cmb_PuestoFiltro.Size = New System.Drawing.Size(323, 21)
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(85, 13)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 1
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'Lbl_PuestoL
        '
        Me.Lbl_PuestoL.AutoSize = True
        Me.Lbl_PuestoL.Location = New System.Drawing.Point(39, 41)
        Me.Lbl_PuestoL.Name = "Lbl_PuestoL"
        Me.Lbl_PuestoL.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoL.TabIndex = 2
        Me.Lbl_PuestoL.Text = "Puesto"
        '
        'Lbl_DepartamentoL
        '
        Me.Lbl_DepartamentoL.AutoSize = True
        Me.Lbl_DepartamentoL.Location = New System.Drawing.Point(5, 16)
        Me.Lbl_DepartamentoL.Name = "Lbl_DepartamentoL"
        Me.Lbl_DepartamentoL.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DepartamentoL.TabIndex = 0
        Me.Lbl_DepartamentoL.Text = "Departamento"
        '
        'lsv_Implementos
        '
        Me.lsv_Implementos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Implementos.CheckBoxes = True
        Me.lsv_Implementos.FullRowSelect = True
        Me.lsv_Implementos.HideSelection = False
        Me.lsv_Implementos.Location = New System.Drawing.Point(6, 174)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Implementos.Lvs = ListViewColumnSorter1
        Me.lsv_Implementos.MultiSelect = False
        Me.lsv_Implementos.Name = "lsv_Implementos"
        Me.lsv_Implementos.Row1 = 10
        Me.lsv_Implementos.Row10 = 0
        Me.lsv_Implementos.Row2 = 50
        Me.lsv_Implementos.Row3 = 35
        Me.lsv_Implementos.Row4 = 0
        Me.lsv_Implementos.Row5 = 0
        Me.lsv_Implementos.Row6 = 0
        Me.lsv_Implementos.Row7 = 0
        Me.lsv_Implementos.Row8 = 0
        Me.lsv_Implementos.Row9 = 0
        Me.lsv_Implementos.Size = New System.Drawing.Size(757, 414)
        Me.lsv_Implementos.TabIndex = 13
        Me.lsv_Implementos.UseCompatibleStateImageBehavior = False
        Me.lsv_Implementos.View = System.Windows.Forms.View.Details
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave_Empleado"
        Me.cmb_Empleado.Control_Siguiente = Nothing
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_Clave
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(85, 65)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = False
        Me.cmb_Empleado.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_Empleados_ComboGetByPuesto"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 5
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.cmb_Empleado
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(81, 65)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 1
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
        '
        'tbx_Comentarios
        '
        Me.tbx_Comentarios.Control_Siguiente = Me.btn_Agregar
        Me.tbx_Comentarios.Filtrado = True
        Me.tbx_Comentarios.Location = New System.Drawing.Point(85, 145)
        Me.tbx_Comentarios.MaxLength = 50
        Me.tbx_Comentarios.Name = "tbx_Comentarios"
        Me.tbx_Comentarios.Size = New System.Drawing.Size(350, 20)
        Me.tbx_Comentarios.TabIndex = 11
        Me.tbx_Comentarios.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'cmb_Implementos
        '
        Me.cmb_Implementos.Clave = Nothing
        Me.cmb_Implementos.Control_Siguiente = Me.tbx_Cantidad
        Me.cmb_Implementos.DisplayMember = "Descripcion"
        Me.cmb_Implementos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Implementos.Empresa = False
        Me.cmb_Implementos.Filtro = Nothing
        Me.cmb_Implementos.FormattingEnabled = True
        Me.cmb_Implementos.Location = New System.Drawing.Point(85, 92)
        Me.cmb_Implementos.MaxDropDownItems = 20
        Me.cmb_Implementos.Name = "cmb_Implementos"
        Me.cmb_Implementos.Pista = False
        Me.cmb_Implementos.Size = New System.Drawing.Size(350, 21)
        Me.cmb_Implementos.StoredProcedure = "Cat_Implementos_Get"
        Me.cmb_Implementos.Sucursal = False
        Me.cmb_Implementos.TabIndex = 7
        Me.cmb_Implementos.Tipo = 0
        Me.cmb_Implementos.ValueMember = "Id_Implemento"
        '
        'tbx_Cantidad
        '
        Me.tbx_Cantidad.Control_Siguiente = Me.tbx_Comentarios
        Me.tbx_Cantidad.Filtrado = True
        Me.tbx_Cantidad.Location = New System.Drawing.Point(85, 119)
        Me.tbx_Cantidad.MaxLength = 8
        Me.tbx_Cantidad.Name = "tbx_Cantidad"
        Me.tbx_Cantidad.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Cantidad.TabIndex = 9
        Me.tbx_Cantidad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 602)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(769, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'frm_ImplementosAsignar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 658)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ImplementosAsignar"
        Me.Text = "Asignación de Implementos"
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Listado.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Empleado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Nombre_Baja As System.Windows.Forms.Label
    Friend WithEvents lbl_Implemento As System.Windows.Forms.Label
    Friend WithEvents cmb_Implementos As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_StockMinimo As System.Windows.Forms.Label
    Friend WithEvents tbx_Cantidad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Observaciones As System.Windows.Forms.Label
    Friend WithEvents tbx_Comentarios As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lsv_Implementos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Borrar As System.Windows.Forms.Button
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_PuestoL As System.Windows.Forms.Label
    Friend WithEvents Lbl_DepartamentoL As System.Windows.Forms.Label
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
End Class
