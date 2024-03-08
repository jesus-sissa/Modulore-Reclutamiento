<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_CargarDoctos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_CargarDoctos))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ExportarTodos = New System.Windows.Forms.Button
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Principales = New System.Windows.Forms.GroupBox
        Me.btn_Buscar = New System.Windows.Forms.Button
        Me.lbl_ComboSFP = New System.Windows.Forms.Label
        Me.gbx_Archivos = New System.Windows.Forms.GroupBox
        Me.btn_LimpiarTodo = New System.Windows.Forms.Button
        Me.btn_Limpiar = New System.Windows.Forms.Button
        Me.gbx_VistaPrevia = New System.Windows.Forms.GroupBox
        Me.pct_Imagen = New System.Windows.Forms.PictureBox
        Me.lsv_Archivos = New Modulo_Reclutamiento.cp_Listview
        Me.cmb_Docto = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Principales.SuspendLayout()
        Me.gbx_Archivos.SuspendLayout()
        Me.gbx_VistaPrevia.SuspendLayout()
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarTodos)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Botones.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Botones.Location = New System.Drawing.Point(0, 291)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(684, 50)
        Me.gbx_Botones.TabIndex = 4
        Me.gbx_Botones.TabStop = False
        '
        'btn_ExportarTodos
        '
        Me.btn_ExportarTodos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarTodos.Enabled = False
        Me.btn_ExportarTodos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarTodos.Location = New System.Drawing.Point(152, 13)
        Me.btn_ExportarTodos.Name = "btn_ExportarTodos"
        Me.btn_ExportarTodos.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarTodos.TabIndex = 3
        Me.btn_ExportarTodos.Text = "&Exportar Todos"
        Me.btn_ExportarTodos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarTodos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarTodos.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 1
        Me.btn_Exportar.Text = "&Exportar Archivo"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(538, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Principales
        '
        Me.gbx_Principales.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Principales.Controls.Add(Me.btn_Buscar)
        Me.gbx_Principales.Controls.Add(Me.cmb_Docto)
        Me.gbx_Principales.Controls.Add(Me.lbl_ComboSFP)
        Me.gbx_Principales.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Principales.Location = New System.Drawing.Point(6, 4)
        Me.gbx_Principales.Name = "gbx_Principales"
        Me.gbx_Principales.Size = New System.Drawing.Size(672, 52)
        Me.gbx_Principales.TabIndex = 5
        Me.gbx_Principales.TabStop = False
        Me.gbx_Principales.Text = "Datos Principales"
        '
        'btn_Buscar
        '
        Me.btn_Buscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Buscar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Img_AddImagen2
        Me.btn_Buscar.Location = New System.Drawing.Point(480, 13)
        Me.btn_Buscar.Name = "btn_Buscar"
        Me.btn_Buscar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Buscar.TabIndex = 2
        Me.btn_Buscar.Text = "Seleccionar Imagen"
        Me.btn_Buscar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Buscar.UseVisualStyleBackColor = True
        '
        'lbl_ComboSFP
        '
        Me.lbl_ComboSFP.AutoSize = True
        Me.lbl_ComboSFP.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_ComboSFP.Location = New System.Drawing.Point(6, 22)
        Me.lbl_ComboSFP.Name = "lbl_ComboSFP"
        Me.lbl_ComboSFP.Size = New System.Drawing.Size(62, 13)
        Me.lbl_ComboSFP.TabIndex = 9
        Me.lbl_ComboSFP.Text = "Documento"
        '
        'gbx_Archivos
        '
        Me.gbx_Archivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Archivos.Controls.Add(Me.btn_LimpiarTodo)
        Me.gbx_Archivos.Controls.Add(Me.btn_Limpiar)
        Me.gbx_Archivos.Controls.Add(Me.lsv_Archivos)
        Me.gbx_Archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Archivos.Location = New System.Drawing.Point(6, 62)
        Me.gbx_Archivos.Name = "gbx_Archivos"
        Me.gbx_Archivos.Size = New System.Drawing.Size(453, 229)
        Me.gbx_Archivos.TabIndex = 6
        Me.gbx_Archivos.TabStop = False
        Me.gbx_Archivos.Text = "Archivos"
        '
        'btn_LimpiarTodo
        '
        Me.btn_LimpiarTodo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_LimpiarTodo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_LimpiarTodo.Image = CType(resources.GetObject("btn_LimpiarTodo.Image"), System.Drawing.Image)
        Me.btn_LimpiarTodo.Location = New System.Drawing.Point(115, 193)
        Me.btn_LimpiarTodo.Name = "btn_LimpiarTodo"
        Me.btn_LimpiarTodo.Size = New System.Drawing.Size(100, 30)
        Me.btn_LimpiarTodo.TabIndex = 3
        Me.btn_LimpiarTodo.Text = "Eliminar &Todo"
        Me.btn_LimpiarTodo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_LimpiarTodo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_LimpiarTodo.UseVisualStyleBackColor = True
        Me.btn_LimpiarTodo.Visible = False
        '
        'btn_Limpiar
        '
        Me.btn_Limpiar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Limpiar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Limpiar.Image = CType(resources.GetObject("btn_Limpiar.Image"), System.Drawing.Image)
        Me.btn_Limpiar.Location = New System.Drawing.Point(9, 193)
        Me.btn_Limpiar.Name = "btn_Limpiar"
        Me.btn_Limpiar.Size = New System.Drawing.Size(100, 30)
        Me.btn_Limpiar.TabIndex = 2
        Me.btn_Limpiar.Text = "&Eliminar"
        Me.btn_Limpiar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Limpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Limpiar.UseVisualStyleBackColor = True
        '
        'gbx_VistaPrevia
        '
        Me.gbx_VistaPrevia.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_VistaPrevia.Controls.Add(Me.pct_Imagen)
        Me.gbx_VistaPrevia.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_VistaPrevia.Location = New System.Drawing.Point(465, 62)
        Me.gbx_VistaPrevia.Name = "gbx_VistaPrevia"
        Me.gbx_VistaPrevia.Size = New System.Drawing.Size(213, 229)
        Me.gbx_VistaPrevia.TabIndex = 7
        Me.gbx_VistaPrevia.TabStop = False
        Me.gbx_VistaPrevia.Text = "Vista Previa"
        '
        'pct_Imagen
        '
        Me.pct_Imagen.BackColor = System.Drawing.SystemColors.Window
        Me.pct_Imagen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Imagen.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pct_Imagen.Dock = System.Windows.Forms.DockStyle.Fill
        Me.pct_Imagen.Location = New System.Drawing.Point(3, 16)
        Me.pct_Imagen.Name = "pct_Imagen"
        Me.pct_Imagen.Size = New System.Drawing.Size(207, 210)
        Me.pct_Imagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Imagen.TabIndex = 1
        Me.pct_Imagen.TabStop = False
        '
        'lsv_Archivos
        '
        Me.lsv_Archivos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Archivos.FullRowSelect = True
        Me.lsv_Archivos.HideSelection = False
        Me.lsv_Archivos.Location = New System.Drawing.Point(9, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Archivos.Lvs = ListViewColumnSorter1
        Me.lsv_Archivos.MultiSelect = False
        Me.lsv_Archivos.Name = "lsv_Archivos"
        Me.lsv_Archivos.Row1 = 50
        Me.lsv_Archivos.Row10 = 0
        Me.lsv_Archivos.Row2 = 15
        Me.lsv_Archivos.Row3 = 15
        Me.lsv_Archivos.Row4 = 30
        Me.lsv_Archivos.Row5 = 0
        Me.lsv_Archivos.Row6 = 0
        Me.lsv_Archivos.Row7 = 0
        Me.lsv_Archivos.Row8 = 0
        Me.lsv_Archivos.Row9 = 0
        Me.lsv_Archivos.Size = New System.Drawing.Size(438, 168)
        Me.lsv_Archivos.TabIndex = 0
        Me.lsv_Archivos.UseCompatibleStateImageBehavior = False
        Me.lsv_Archivos.View = System.Windows.Forms.View.Details
        '
        'cmb_Docto
        '
        Me.cmb_Docto.Clave = Nothing
        Me.cmb_Docto.Control_Siguiente = Nothing
        Me.cmb_Docto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Docto.Empresa = False
        Me.cmb_Docto.Filtro = Nothing
        Me.cmb_Docto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Docto.FormattingEnabled = True
        Me.cmb_Docto.Location = New System.Drawing.Point(74, 19)
        Me.cmb_Docto.MaxDropDownItems = 20
        Me.cmb_Docto.Name = "cmb_Docto"
        Me.cmb_Docto.Pista = True
        Me.cmb_Docto.Size = New System.Drawing.Size(400, 21)
        Me.cmb_Docto.StoredProcedure = Nothing
        Me.cmb_Docto.Sucursal = False
        Me.cmb_Docto.TabIndex = 12
        Me.cmb_Docto.Tipo = 0
        Me.cmb_Docto.Visible = False
        '
        'frm_CargarDoctos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 341)
        Me.Controls.Add(Me.gbx_VistaPrevia)
        Me.Controls.Add(Me.gbx_Archivos)
        Me.Controls.Add(Me.gbx_Principales)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_CargarDoctos"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga de Documentos"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Principales.ResumeLayout(False)
        Me.gbx_Principales.PerformLayout()
        Me.gbx_Archivos.ResumeLayout(False)
        Me.gbx_VistaPrevia.ResumeLayout(False)
        CType(Me.pct_Imagen, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ExportarTodos As System.Windows.Forms.Button
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Principales As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Buscar As System.Windows.Forms.Button
    Friend WithEvents cmb_Docto As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_ComboSFP As System.Windows.Forms.Label
    Friend WithEvents gbx_Archivos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_LimpiarTodo As System.Windows.Forms.Button
    Friend WithEvents btn_Limpiar As System.Windows.Forms.Button
    Friend WithEvents lsv_Archivos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_VistaPrevia As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Imagen As System.Windows.Forms.PictureBox
End Class
