<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ImplementosDevoluciones
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
        Me.lbl_Nombre_Devolucion = New System.Windows.Forms.Label
        Me.dgv_ImplementosDevolucion = New System.Windows.Forms.DataGridView
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.cmb_Empleado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Clave = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_PuestoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_DepartamentoFiltro = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.Lbl_PuestoL = New System.Windows.Forms.Label
        Me.Lbl_DepartamentoL = New System.Windows.Forms.Label
        CType(Me.dgv_ImplementosDevolucion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Nombre_Devolucion
        '
        Me.lbl_Nombre_Devolucion.AutoSize = True
        Me.lbl_Nombre_Devolucion.Location = New System.Drawing.Point(26, 67)
        Me.lbl_Nombre_Devolucion.Name = "lbl_Nombre_Devolucion"
        Me.lbl_Nombre_Devolucion.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Nombre_Devolucion.TabIndex = 3
        Me.lbl_Nombre_Devolucion.Text = "Empleado"
        Me.lbl_Nombre_Devolucion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'dgv_ImplementosDevolucion
        '
        Me.dgv_ImplementosDevolucion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgv_ImplementosDevolucion.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgv_ImplementosDevolucion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_ImplementosDevolucion.Location = New System.Drawing.Point(2, 94)
        Me.dgv_ImplementosDevolucion.Name = "dgv_ImplementosDevolucion"
        Me.dgv_ImplementosDevolucion.Size = New System.Drawing.Size(780, 406)
        Me.dgv_ImplementosDevolucion.TabIndex = 6
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(632, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 15
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 14
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(2, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(778, 50)
        Me.gbx_Botones.TabIndex = 16
        Me.gbx_Botones.TabStop = False
        '
        'cmb_Empleado
        '
        Me.cmb_Empleado.Clave = "Clave"
        Me.cmb_Empleado.Control_Siguiente = Nothing
        Me.cmb_Empleado.DisplayMember = "Nombre"
        Me.cmb_Empleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empleado.Empresa = False
        Me.cmb_Empleado.Filtro = Me.tbx_Clave
        Me.cmb_Empleado.FormattingEnabled = True
        Me.cmb_Empleado.Location = New System.Drawing.Point(86, 64)
        Me.cmb_Empleado.MaxDropDownItems = 20
        Me.cmb_Empleado.Name = "cmb_Empleado"
        Me.cmb_Empleado.Pista = True
        Me.cmb_Empleado.Size = New System.Drawing.Size(456, 21)
        Me.cmb_Empleado.StoredProcedure = "Cat_Empleados_Get"
        Me.cmb_Empleado.Sucursal = True
        Me.cmb_Empleado.TabIndex = 5
        Me.cmb_Empleado.Tipo = 0
        Me.cmb_Empleado.ValueMember = "Id_Empleado"
        '
        'tbx_Clave
        '
        Me.tbx_Clave.Control_Siguiente = Me.cmb_Empleado
        Me.tbx_Clave.Filtrado = True
        Me.tbx_Clave.Location = New System.Drawing.Point(79, 68)
        Me.tbx_Clave.MaxLength = 12
        Me.tbx_Clave.Name = "tbx_Clave"
        Me.tbx_Clave.Size = New System.Drawing.Size(50, 20)
        Me.tbx_Clave.TabIndex = 4
        Me.tbx_Clave.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_Clave.Visible = False
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
        Me.cmb_PuestoFiltro.Location = New System.Drawing.Point(86, 37)
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
        Me.cmb_DepartamentoFiltro.Location = New System.Drawing.Point(86, 12)
        Me.cmb_DepartamentoFiltro.MaxDropDownItems = 20
        Me.cmb_DepartamentoFiltro.Name = "cmb_DepartamentoFiltro"
        Me.cmb_DepartamentoFiltro.Pista = False
        Me.cmb_DepartamentoFiltro.Size = New System.Drawing.Size(323, 21)
        Me.cmb_DepartamentoFiltro.StoredProcedure = "Cat_DepartamentosCombo_Get"
        Me.cmb_DepartamentoFiltro.Sucursal = False
        Me.cmb_DepartamentoFiltro.TabIndex = 18
        Me.cmb_DepartamentoFiltro.Tipo = 0
        Me.cmb_DepartamentoFiltro.ValueMember = "Id_Departamento"
        '
        'Lbl_PuestoL
        '
        Me.Lbl_PuestoL.AutoSize = True
        Me.Lbl_PuestoL.Location = New System.Drawing.Point(40, 40)
        Me.Lbl_PuestoL.Name = "Lbl_PuestoL"
        Me.Lbl_PuestoL.Size = New System.Drawing.Size(40, 13)
        Me.Lbl_PuestoL.TabIndex = 19
        Me.Lbl_PuestoL.Text = "Puesto"
        '
        'Lbl_DepartamentoL
        '
        Me.Lbl_DepartamentoL.AutoSize = True
        Me.Lbl_DepartamentoL.Location = New System.Drawing.Point(6, 15)
        Me.Lbl_DepartamentoL.Name = "Lbl_DepartamentoL"
        Me.Lbl_DepartamentoL.Size = New System.Drawing.Size(74, 13)
        Me.Lbl_DepartamentoL.TabIndex = 17
        Me.Lbl_DepartamentoL.Text = "Departamento"
        '
        'frm_ImplementosDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.cmb_PuestoFiltro)
        Me.Controls.Add(Me.cmb_DepartamentoFiltro)
        Me.Controls.Add(Me.Lbl_PuestoL)
        Me.Controls.Add(Me.Lbl_DepartamentoL)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.dgv_ImplementosDevolucion)
        Me.Controls.Add(Me.cmb_Empleado)
        Me.Controls.Add(Me.lbl_Nombre_Devolucion)
        Me.Controls.Add(Me.tbx_Clave)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ImplementosDevoluciones"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Devolución de Implementos"
        CType(Me.dgv_ImplementosDevolucion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbx_Clave As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_Empleado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Nombre_Devolucion As System.Windows.Forms.Label
    Friend WithEvents dgv_ImplementosDevolucion As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_PuestoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_DepartamentoFiltro As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents Lbl_PuestoL As System.Windows.Forms.Label
    Friend WithEvents Lbl_DepartamentoL As System.Windows.Forms.Label
End Class
