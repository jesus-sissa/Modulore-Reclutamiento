<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Gafetes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Gafetes))
        Me.gbx_filtro = New System.Windows.Forms.GroupBox
        Me.Chk_Todos = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lbl_Tipo = New System.Windows.Forms.Label
        Me.tbx_Descripcion = New System.Windows.Forms.TextBox
        Me.gbx_Lista = New System.Windows.Forms.GroupBox
        Me.chk_Activos = New System.Windows.Forms.CheckBox
        Me.lbl_Registros = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Imprimir = New System.Windows.Forms.Button
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Btn_AltaBaja = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lsv_Lista = New Modulo_Reclutamiento.cp_Listview
        Me.cmb_Tipo = New Modulo_Reclutamiento.cp_cmb_Manual
        Me.gbx_filtro.SuspendLayout()
        Me.gbx_Lista.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_filtro
        '
        Me.gbx_filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_filtro.Controls.Add(Me.btn_Cancelar)
        Me.gbx_filtro.Controls.Add(Me.cmb_Tipo)
        Me.gbx_filtro.Controls.Add(Me.btn_Guardar)
        Me.gbx_filtro.Controls.Add(Me.Chk_Todos)
        Me.gbx_filtro.Controls.Add(Me.Label2)
        Me.gbx_filtro.Controls.Add(Me.lbl_Tipo)
        Me.gbx_filtro.Controls.Add(Me.tbx_Descripcion)
        Me.gbx_filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_filtro.Location = New System.Drawing.Point(6, 2)
        Me.gbx_filtro.Name = "gbx_filtro"
        Me.gbx_filtro.Size = New System.Drawing.Size(772, 77)
        Me.gbx_filtro.TabIndex = 0
        Me.gbx_filtro.TabStop = False
        '
        'Chk_Todos
        '
        Me.Chk_Todos.AutoSize = True
        Me.Chk_Todos.Location = New System.Drawing.Point(481, 21)
        Me.Chk_Todos.Name = "Chk_Todos"
        Me.Chk_Todos.Size = New System.Drawing.Size(56, 17)
        Me.Chk_Todos.TabIndex = 2
        Me.Chk_Todos.Text = "Todos"
        Me.Chk_Todos.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripcion"
        '
        'lbl_Tipo
        '
        Me.lbl_Tipo.AutoSize = True
        Me.lbl_Tipo.Location = New System.Drawing.Point(41, 22)
        Me.lbl_Tipo.Name = "lbl_Tipo"
        Me.lbl_Tipo.Size = New System.Drawing.Size(28, 13)
        Me.lbl_Tipo.TabIndex = 0
        Me.lbl_Tipo.Text = "Tipo"
        '
        'tbx_Descripcion
        '
        Me.tbx_Descripcion.Location = New System.Drawing.Point(75, 46)
        Me.tbx_Descripcion.MaxLength = 50
        Me.tbx_Descripcion.Name = "tbx_Descripcion"
        Me.tbx_Descripcion.Size = New System.Drawing.Size(400, 20)
        Me.tbx_Descripcion.TabIndex = 5
        '
        'gbx_Lista
        '
        Me.gbx_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Lista.Controls.Add(Me.chk_Activos)
        Me.gbx_Lista.Controls.Add(Me.lbl_Registros)
        Me.gbx_Lista.Controls.Add(Me.lsv_Lista)
        Me.gbx_Lista.Location = New System.Drawing.Point(6, 80)
        Me.gbx_Lista.Name = "gbx_Lista"
        Me.gbx_Lista.Size = New System.Drawing.Size(772, 426)
        Me.gbx_Lista.TabIndex = 1
        Me.gbx_Lista.TabStop = False
        '
        'chk_Activos
        '
        Me.chk_Activos.AutoSize = True
        Me.chk_Activos.Location = New System.Drawing.Point(6, 14)
        Me.chk_Activos.Name = "chk_Activos"
        Me.chk_Activos.Size = New System.Drawing.Size(85, 17)
        Me.chk_Activos.TabIndex = 0
        Me.chk_Activos.Text = "Solo Activos"
        Me.chk_Activos.UseVisualStyleBackColor = True
        '
        'lbl_Registros
        '
        Me.lbl_Registros.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Registros.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Registros.Location = New System.Drawing.Point(620, 10)
        Me.lbl_Registros.Name = "lbl_Registros"
        Me.lbl_Registros.Size = New System.Drawing.Size(146, 23)
        Me.lbl_Registros.TabIndex = 1
        Me.lbl_Registros.Text = "Registros: 0"
        Me.lbl_Registros.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Imprimir)
        Me.gbx_Botones.Controls.Add(Me.btn_Modificar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.Btn_AltaBaja)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Location = New System.Drawing.Point(6, 506)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(772, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Imprimir
        '
        Me.btn_Imprimir.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_Imprimir.Location = New System.Drawing.Point(444, 13)
        Me.btn_Imprimir.Name = "btn_Imprimir"
        Me.btn_Imprimir.Size = New System.Drawing.Size(140, 30)
        Me.btn_Imprimir.TabIndex = 10
        Me.btn_Imprimir.Text = "Imprimir"
        Me.btn_Imprimir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Imprimir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Imprimir.UseVisualStyleBackColor = True
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(298, 13)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 2
        Me.btn_Modificar.Text = "Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(626, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'Btn_AltaBaja
        '
        Me.Btn_AltaBaja.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.BajaReing
        Me.Btn_AltaBaja.Location = New System.Drawing.Point(152, 13)
        Me.Btn_AltaBaja.Name = "Btn_AltaBaja"
        Me.Btn_AltaBaja.Size = New System.Drawing.Size(140, 30)
        Me.Btn_AltaBaja.TabIndex = 1
        Me.Btn_AltaBaja.Text = "Alta/Baja"
        Me.Btn_AltaBaja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AltaBaja.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AltaBaja.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(623, 40)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 7
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(480, 41)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 6
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(623, 8)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 3
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lsv_Lista
        '
        Me.lsv_Lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Lista.FullRowSelect = True
        Me.lsv_Lista.HideSelection = False
        Me.lsv_Lista.Location = New System.Drawing.Point(6, 36)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Lista.Lvs = ListViewColumnSorter1
        Me.lsv_Lista.MultiSelect = False
        Me.lsv_Lista.Name = "lsv_Lista"
        Me.lsv_Lista.Row1 = 10
        Me.lsv_Lista.Row10 = 10
        Me.lsv_Lista.Row2 = 30
        Me.lsv_Lista.Row3 = 10
        Me.lsv_Lista.Row4 = 10
        Me.lsv_Lista.Row5 = 10
        Me.lsv_Lista.Row6 = 10
        Me.lsv_Lista.Row7 = 10
        Me.lsv_Lista.Row8 = 10
        Me.lsv_Lista.Row9 = 10
        Me.lsv_Lista.Size = New System.Drawing.Size(760, 384)
        Me.lsv_Lista.TabIndex = 2
        Me.lsv_Lista.UseCompatibleStateImageBehavior = False
        Me.lsv_Lista.View = System.Windows.Forms.View.Details
        '
        'cmb_Tipo
        '
        Me.cmb_Tipo.Control_Siguiente = Nothing
        Me.cmb_Tipo.DisplayMember = "display"
        Me.cmb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Tipo.FormattingEnabled = True
        Me.cmb_Tipo.Location = New System.Drawing.Point(75, 19)
        Me.cmb_Tipo.MaxDropDownItems = 20
        Me.cmb_Tipo.Name = "cmb_Tipo"
        Me.cmb_Tipo.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Tipo.TabIndex = 1
        Me.cmb_Tipo.ValueMember = "value"
        '
        'frm_Gafetes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Lista)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_filtro)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Gafetes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catalogo de Gafetes"
        Me.gbx_filtro.ResumeLayout(False)
        Me.gbx_filtro.PerformLayout()
        Me.gbx_Lista.ResumeLayout(False)
        Me.gbx_Lista.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_filtro As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Lista As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Lista As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_Registros As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Btn_AltaBaja As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lbl_Tipo As System.Windows.Forms.Label
    Friend WithEvents tbx_Descripcion As System.Windows.Forms.TextBox
    Friend WithEvents chk_Activos As System.Windows.Forms.CheckBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents Chk_Todos As System.Windows.Forms.CheckBox
    Friend WithEvents cmb_Tipo As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents btn_Imprimir As System.Windows.Forms.Button
End Class
