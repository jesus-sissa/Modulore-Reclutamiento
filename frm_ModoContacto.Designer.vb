<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ModoContacto
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
        Me.components = New System.ComponentModel.Container
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.Label3 = New System.Windows.Forms.Label
        Me.lbl_ModoTipo = New System.Windows.Forms.Label
        Me.gbx_Tipo = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.btn_AgregarTipo = New System.Windows.Forms.Button
        Me.btn_ModificarTipo = New System.Windows.Forms.Button
        Me.btn_AltaTipo = New System.Windows.Forms.Button
        Me.btn_BajaTipo = New System.Windows.Forms.Button
        Me.lsv_Tipo = New Modulo_Reclutamiento.cp_Listview
        Me.tbx_DescripcionTipo = New Modulo_Reclutamiento.cp_Textbox
        Me.gbx_Detalle = New System.Windows.Forms.GroupBox
        Me.btn_AgregarDetalle = New System.Windows.Forms.Button
        Me.btn_ModificarDetalle = New System.Windows.Forms.Button
        Me.btn_AltaDetalle = New System.Windows.Forms.Button
        Me.btn_BajaDetalle = New System.Windows.Forms.Button
        Me.Label4 = New System.Windows.Forms.Label
        Me.lsv_Detalle = New Modulo_Reclutamiento.cp_Listview
        Me.tbx_DescripcionDetalle = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_ModoDetalle = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ExportarDetalle = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_ExportarTipo = New System.Windows.Forms.Button
        Me.tlt_Mensaje = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbx_Tipo.SuspendLayout()
        Me.gbx_Detalle.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(405, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "*"
        '
        'lbl_ModoTipo
        '
        Me.lbl_ModoTipo.AutoSize = True
        Me.lbl_ModoTipo.Location = New System.Drawing.Point(12, 22)
        Me.lbl_ModoTipo.Name = "lbl_ModoTipo"
        Me.lbl_ModoTipo.Size = New System.Drawing.Size(95, 13)
        Me.lbl_ModoTipo.TabIndex = 0
        Me.lbl_ModoTipo.Text = "Modo de Contacto"
        Me.lbl_ModoTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Tipo
        '
        Me.gbx_Tipo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Tipo.Controls.Add(Me.Lbl_Numero)
        Me.gbx_Tipo.Controls.Add(Me.btn_AgregarTipo)
        Me.gbx_Tipo.Controls.Add(Me.btn_ModificarTipo)
        Me.gbx_Tipo.Controls.Add(Me.btn_AltaTipo)
        Me.gbx_Tipo.Controls.Add(Me.btn_BajaTipo)
        Me.gbx_Tipo.Controls.Add(Me.Label3)
        Me.gbx_Tipo.Controls.Add(Me.lsv_Tipo)
        Me.gbx_Tipo.Controls.Add(Me.tbx_DescripcionTipo)
        Me.gbx_Tipo.Controls.Add(Me.lbl_ModoTipo)
        Me.gbx_Tipo.Location = New System.Drawing.Point(8, 2)
        Me.gbx_Tipo.Name = "gbx_Tipo"
        Me.gbx_Tipo.Size = New System.Drawing.Size(768, 349)
        Me.gbx_Tipo.TabIndex = 0
        Me.gbx_Tipo.TabStop = False
        Me.gbx_Tipo.Text = "Tipos"
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(642, 22)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(120, 23)
        Me.Lbl_Numero.TabIndex = 22
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_AgregarTipo
        '
        Me.btn_AgregarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarTipo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_AgregarTipo.Location = New System.Drawing.Point(424, 16)
        Me.btn_AgregarTipo.Name = "btn_AgregarTipo"
        Me.btn_AgregarTipo.Size = New System.Drawing.Size(31, 25)
        Me.btn_AgregarTipo.TabIndex = 3
        Me.tlt_Mensaje.SetToolTip(Me.btn_AgregarTipo, "Agregar un Tipo de Modo de Contacto")
        Me.btn_AgregarTipo.UseVisualStyleBackColor = True
        '
        'btn_ModificarTipo
        '
        Me.btn_ModificarTipo.Enabled = False
        Me.btn_ModificarTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ModificarTipo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_ModificarTipo.Location = New System.Drawing.Point(461, 16)
        Me.btn_ModificarTipo.Name = "btn_ModificarTipo"
        Me.btn_ModificarTipo.Size = New System.Drawing.Size(31, 25)
        Me.btn_ModificarTipo.TabIndex = 4
        Me.btn_ModificarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarTipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarTipo.UseVisualStyleBackColor = True
        '
        'btn_AltaTipo
        '
        Me.btn_AltaTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AltaTipo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.add
        Me.btn_AltaTipo.Location = New System.Drawing.Point(498, 16)
        Me.btn_AltaTipo.Name = "btn_AltaTipo"
        Me.btn_AltaTipo.Size = New System.Drawing.Size(31, 25)
        Me.btn_AltaTipo.TabIndex = 5
        Me.tlt_Mensaje.SetToolTip(Me.btn_AltaTipo, "Alta de un Tipo de Modo de Contacto")
        Me.btn_AltaTipo.UseVisualStyleBackColor = True
        '
        'btn_BajaTipo
        '
        Me.btn_BajaTipo.Enabled = False
        Me.btn_BajaTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BajaTipo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.quitar
        Me.btn_BajaTipo.Location = New System.Drawing.Point(535, 16)
        Me.btn_BajaTipo.Name = "btn_BajaTipo"
        Me.btn_BajaTipo.Size = New System.Drawing.Size(31, 25)
        Me.btn_BajaTipo.TabIndex = 6
        Me.tlt_Mensaje.SetToolTip(Me.btn_BajaTipo, "Baja de un Tipo de Modo de Contacto")
        Me.btn_BajaTipo.UseVisualStyleBackColor = True
        '
        'lsv_Tipo
        '
        Me.lsv_Tipo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Tipo.FullRowSelect = True
        Me.lsv_Tipo.HideSelection = False
        Me.lsv_Tipo.Location = New System.Drawing.Point(6, 47)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Tipo.Lvs = ListViewColumnSorter1
        Me.lsv_Tipo.MultiSelect = False
        Me.lsv_Tipo.Name = "lsv_Tipo"
        Me.lsv_Tipo.Row1 = 30
        Me.lsv_Tipo.Row10 = 0
        Me.lsv_Tipo.Row2 = 15
        Me.lsv_Tipo.Row3 = 0
        Me.lsv_Tipo.Row4 = 0
        Me.lsv_Tipo.Row5 = 0
        Me.lsv_Tipo.Row6 = 0
        Me.lsv_Tipo.Row7 = 0
        Me.lsv_Tipo.Row8 = 0
        Me.lsv_Tipo.Row9 = 0
        Me.lsv_Tipo.Size = New System.Drawing.Size(756, 296)
        Me.lsv_Tipo.TabIndex = 7
        Me.lsv_Tipo.Tag = "Id_GradoEscolar"
        Me.lsv_Tipo.UseCompatibleStateImageBehavior = False
        Me.lsv_Tipo.View = System.Windows.Forms.View.Details
        '
        'tbx_DescripcionTipo
        '
        Me.tbx_DescripcionTipo.Control_Siguiente = Me.btn_AgregarTipo
        Me.tbx_DescripcionTipo.Filtrado = True
        Me.tbx_DescripcionTipo.Location = New System.Drawing.Point(113, 19)
        Me.tbx_DescripcionTipo.MaxLength = 50
        Me.tbx_DescripcionTipo.Name = "tbx_DescripcionTipo"
        Me.tbx_DescripcionTipo.Size = New System.Drawing.Size(286, 20)
        Me.tbx_DescripcionTipo.TabIndex = 1
        Me.tbx_DescripcionTipo.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_DescripcionTipo, "Tipo de Modo de Contacto")
        '
        'gbx_Detalle
        '
        Me.gbx_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Detalle.Controls.Add(Me.btn_AgregarDetalle)
        Me.gbx_Detalle.Controls.Add(Me.btn_ModificarDetalle)
        Me.gbx_Detalle.Controls.Add(Me.btn_AltaDetalle)
        Me.gbx_Detalle.Controls.Add(Me.btn_BajaDetalle)
        Me.gbx_Detalle.Controls.Add(Me.Label4)
        Me.gbx_Detalle.Controls.Add(Me.lsv_Detalle)
        Me.gbx_Detalle.Controls.Add(Me.tbx_DescripcionDetalle)
        Me.gbx_Detalle.Controls.Add(Me.lbl_ModoDetalle)
        Me.gbx_Detalle.Enabled = False
        Me.gbx_Detalle.Location = New System.Drawing.Point(8, 357)
        Me.gbx_Detalle.Name = "gbx_Detalle"
        Me.gbx_Detalle.Size = New System.Drawing.Size(768, 142)
        Me.gbx_Detalle.TabIndex = 1
        Me.gbx_Detalle.TabStop = False
        Me.gbx_Detalle.Text = "Detalle"
        '
        'btn_AgregarDetalle
        '
        Me.btn_AgregarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AgregarDetalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.btn_AgregarDetalle.Location = New System.Drawing.Point(424, 19)
        Me.btn_AgregarDetalle.Name = "btn_AgregarDetalle"
        Me.btn_AgregarDetalle.Size = New System.Drawing.Size(31, 25)
        Me.btn_AgregarDetalle.TabIndex = 3
        Me.tlt_Mensaje.SetToolTip(Me.btn_AgregarDetalle, "Agregar una Descripción de Modo de Contacto")
        Me.btn_AgregarDetalle.UseVisualStyleBackColor = True
        '
        'btn_ModificarDetalle
        '
        Me.btn_ModificarDetalle.Enabled = False
        Me.btn_ModificarDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ModificarDetalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_ModificarDetalle.Location = New System.Drawing.Point(461, 19)
        Me.btn_ModificarDetalle.Name = "btn_ModificarDetalle"
        Me.btn_ModificarDetalle.Size = New System.Drawing.Size(31, 25)
        Me.btn_ModificarDetalle.TabIndex = 4
        Me.btn_ModificarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ModificarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ModificarDetalle.UseVisualStyleBackColor = True
        '
        'btn_AltaDetalle
        '
        Me.btn_AltaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_AltaDetalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.add
        Me.btn_AltaDetalle.Location = New System.Drawing.Point(498, 19)
        Me.btn_AltaDetalle.Name = "btn_AltaDetalle"
        Me.btn_AltaDetalle.Size = New System.Drawing.Size(31, 25)
        Me.btn_AltaDetalle.TabIndex = 5
        Me.tlt_Mensaje.SetToolTip(Me.btn_AltaDetalle, "Alta de una Descripción de Modo de Contacto")
        Me.btn_AltaDetalle.UseVisualStyleBackColor = True
        '
        'btn_BajaDetalle
        '
        Me.btn_BajaDetalle.Enabled = False
        Me.btn_BajaDetalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_BajaDetalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.quitar
        Me.btn_BajaDetalle.Location = New System.Drawing.Point(535, 19)
        Me.btn_BajaDetalle.Name = "btn_BajaDetalle"
        Me.btn_BajaDetalle.Size = New System.Drawing.Size(31, 25)
        Me.btn_BajaDetalle.TabIndex = 6
        Me.tlt_Mensaje.SetToolTip(Me.btn_BajaDetalle, "Baja de una Descripción de Modo de Contacto")
        Me.btn_BajaDetalle.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(405, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 16)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "*"
        '
        'lsv_Detalle
        '
        Me.lsv_Detalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Detalle.FullRowSelect = True
        Me.lsv_Detalle.HideSelection = False
        Me.lsv_Detalle.Location = New System.Drawing.Point(6, 50)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Detalle.Lvs = ListViewColumnSorter2
        Me.lsv_Detalle.MultiSelect = False
        Me.lsv_Detalle.Name = "lsv_Detalle"
        Me.lsv_Detalle.Row1 = 30
        Me.lsv_Detalle.Row10 = 0
        Me.lsv_Detalle.Row2 = 15
        Me.lsv_Detalle.Row3 = 0
        Me.lsv_Detalle.Row4 = 0
        Me.lsv_Detalle.Row5 = 0
        Me.lsv_Detalle.Row6 = 0
        Me.lsv_Detalle.Row7 = 0
        Me.lsv_Detalle.Row8 = 0
        Me.lsv_Detalle.Row9 = 0
        Me.lsv_Detalle.Size = New System.Drawing.Size(756, 86)
        Me.lsv_Detalle.TabIndex = 7
        Me.lsv_Detalle.Tag = "Id_GradoEscolar"
        Me.lsv_Detalle.UseCompatibleStateImageBehavior = False
        Me.lsv_Detalle.View = System.Windows.Forms.View.Details
        '
        'tbx_DescripcionDetalle
        '
        Me.tbx_DescripcionDetalle.Control_Siguiente = Me.btn_AgregarDetalle
        Me.tbx_DescripcionDetalle.Filtrado = True
        Me.tbx_DescripcionDetalle.Location = New System.Drawing.Point(113, 22)
        Me.tbx_DescripcionDetalle.MaxLength = 50
        Me.tbx_DescripcionDetalle.Name = "tbx_DescripcionDetalle"
        Me.tbx_DescripcionDetalle.Size = New System.Drawing.Size(286, 20)
        Me.tbx_DescripcionDetalle.TabIndex = 1
        Me.tbx_DescripcionDetalle.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tlt_Mensaje.SetToolTip(Me.tbx_DescripcionDetalle, "Descripción del Tipo de Modo de Contacto")
        '
        'lbl_ModoDetalle
        '
        Me.lbl_ModoDetalle.Location = New System.Drawing.Point(6, 16)
        Me.lbl_ModoDetalle.Name = "lbl_ModoDetalle"
        Me.lbl_ModoDetalle.Size = New System.Drawing.Size(101, 30)
        Me.lbl_ModoDetalle.TabIndex = 0
        Me.lbl_ModoDetalle.Text = "Descripción de Modo de Contacto"
        Me.lbl_ModoDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarDetalle)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_ExportarTipo)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 505)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(768, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_ExportarDetalle
        '
        Me.btn_ExportarDetalle.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarDetalle.Enabled = False
        Me.btn_ExportarDetalle.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarDetalle.Location = New System.Drawing.Point(152, 13)
        Me.btn_ExportarDetalle.Name = "btn_ExportarDetalle"
        Me.btn_ExportarDetalle.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarDetalle.TabIndex = 1
        Me.btn_ExportarDetalle.Text = "&Exportar Detalle"
        Me.btn_ExportarDetalle.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarDetalle.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarDetalle.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(622, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 2
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_ExportarTipo
        '
        Me.btn_ExportarTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_ExportarTipo.Enabled = False
        Me.btn_ExportarTipo.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_ExportarTipo.Location = New System.Drawing.Point(6, 13)
        Me.btn_ExportarTipo.Name = "btn_ExportarTipo"
        Me.btn_ExportarTipo.Size = New System.Drawing.Size(140, 30)
        Me.btn_ExportarTipo.TabIndex = 0
        Me.btn_ExportarTipo.Text = "&Exportar Tipos"
        Me.btn_ExportarTipo.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ExportarTipo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ExportarTipo.UseVisualStyleBackColor = True
        '
        'frm_ModoContacto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Detalle)
        Me.Controls.Add(Me.gbx_Tipo)
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ModoContacto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Catálogo Modo de Contacto"
        Me.gbx_Tipo.ResumeLayout(False)
        Me.gbx_Tipo.PerformLayout()
        Me.gbx_Detalle.ResumeLayout(False)
        Me.gbx_Detalle.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_ExportarTipo As System.Windows.Forms.Button
    Friend WithEvents lsv_Tipo As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_DescripcionTipo As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ModoTipo As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbx_Tipo As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Detalle As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Detalle As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ExportarDetalle As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_DescripcionDetalle As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ModoDetalle As System.Windows.Forms.Label
    Friend WithEvents btn_AltaTipo As System.Windows.Forms.Button
    Friend WithEvents btn_BajaTipo As System.Windows.Forms.Button
    Friend WithEvents btn_AltaDetalle As System.Windows.Forms.Button
    Friend WithEvents btn_BajaDetalle As System.Windows.Forms.Button
    Friend WithEvents tlt_Mensaje As System.Windows.Forms.ToolTip
    Friend WithEvents btn_ModificarTipo As System.Windows.Forms.Button
    Friend WithEvents btn_ModificarDetalle As System.Windows.Forms.Button
    Friend WithEvents btn_AgregarTipo As System.Windows.Forms.Button
    Friend WithEvents btn_AgregarDetalle As System.Windows.Forms.Button
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label

End Class
