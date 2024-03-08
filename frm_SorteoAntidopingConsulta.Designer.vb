<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SorteoAntidopingConsulta
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
        Dim ListViewColumnSorter9 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter10 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter11 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter12 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.lbl_FechaHasta = New System.Windows.Forms.Label
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker
        Me.lbl_FechaDesde = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosSorteos = New System.Windows.Forms.Label
        Me.lsv_Sorteos = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.GroupBox4 = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosDisponibles = New System.Windows.Forms.Label
        Me.lsv_Disponibles = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox5 = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosSeleccionados = New System.Windows.Forms.Label
        Me.lsv_Seleccionados = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox6 = New System.Windows.Forms.GroupBox
        Me.lbl_RegistrosSorteados = New System.Windows.Forms.Label
        Me.lsv_Sorteados = New Modulo_Reclutamiento.cp_Listview
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.GroupBox1.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Mostrar)
        Me.GroupBox1.Controls.Add(Me.lbl_FechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaHasta)
        Me.GroupBox1.Controls.Add(Me.dtp_FechaDesde)
        Me.GroupBox1.Controls.Add(Me.lbl_FechaDesde)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(879, 56)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(318, 14)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 11
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'lbl_FechaHasta
        '
        Me.lbl_FechaHasta.AutoSize = True
        Me.lbl_FechaHasta.Location = New System.Drawing.Point(163, 23)
        Me.lbl_FechaHasta.Name = "lbl_FechaHasta"
        Me.lbl_FechaHasta.Size = New System.Drawing.Size(35, 13)
        Me.lbl_FechaHasta.TabIndex = 6
        Me.lbl_FechaHasta.Text = "Hasta"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(204, 19)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaHasta.TabIndex = 7
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(59, 19)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaDesde.TabIndex = 5
        '
        'lbl_FechaDesde
        '
        Me.lbl_FechaDesde.AutoSize = True
        Me.lbl_FechaDesde.Location = New System.Drawing.Point(15, 23)
        Me.lbl_FechaDesde.Name = "lbl_FechaDesde"
        Me.lbl_FechaDesde.Size = New System.Drawing.Size(38, 13)
        Me.lbl_FechaDesde.TabIndex = 4
        Me.lbl_FechaDesde.Text = "Desde"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Cancelar)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(1, 509)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(880, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(11, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 2
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(734, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.lbl_RegistrosSorteos)
        Me.GroupBox2.Controls.Add(Me.lsv_Sorteos)
        Me.GroupBox2.Location = New System.Drawing.Point(2, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(879, 210)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Sorteos"
        '
        'lbl_RegistrosSorteos
        '
        Me.lbl_RegistrosSorteos.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosSorteos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosSorteos.Location = New System.Drawing.Point(761, 13)
        Me.lbl_RegistrosSorteos.Name = "lbl_RegistrosSorteos"
        Me.lbl_RegistrosSorteos.Size = New System.Drawing.Size(109, 23)
        Me.lbl_RegistrosSorteos.TabIndex = 23
        Me.lbl_RegistrosSorteos.Text = "Registros: 0000"
        Me.lbl_RegistrosSorteos.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Sorteos
        '
        Me.lsv_Sorteos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Sorteos.FullRowSelect = True
        Me.lsv_Sorteos.HideSelection = False
        Me.lsv_Sorteos.Location = New System.Drawing.Point(6, 39)
        ListViewColumnSorter9.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter9.SortColumn = 0
        Me.lsv_Sorteos.Lvs = ListViewColumnSorter9
        Me.lsv_Sorteos.MultiSelect = False
        Me.lsv_Sorteos.Name = "lsv_Sorteos"
        Me.lsv_Sorteos.Row1 = 10
        Me.lsv_Sorteos.Row10 = 10
        Me.lsv_Sorteos.Row2 = 8
        Me.lsv_Sorteos.Row3 = 10
        Me.lsv_Sorteos.Row4 = 10
        Me.lsv_Sorteos.Row5 = 10
        Me.lsv_Sorteos.Row6 = 10
        Me.lsv_Sorteos.Row7 = 10
        Me.lsv_Sorteos.Row8 = 10
        Me.lsv_Sorteos.Row9 = 15
        Me.lsv_Sorteos.Size = New System.Drawing.Size(866, 165)
        Me.lsv_Sorteos.TabIndex = 0
        Me.lsv_Sorteos.UseCompatibleStateImageBehavior = False
        Me.lsv_Sorteos.View = System.Windows.Forms.View.Details
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.TableLayoutPanel1)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 280)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(871, 229)
        Me.GroupBox3.TabIndex = 4
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Detalle"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox6, 2, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 16)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(865, 210)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.lbl_RegistrosDisponibles)
        Me.GroupBox4.Controls.Add(Me.lsv_Disponibles)
        Me.GroupBox4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(340, 204)
        Me.GroupBox4.TabIndex = 0
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Empleados disponibles"
        '
        'lbl_RegistrosDisponibles
        '
        Me.lbl_RegistrosDisponibles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosDisponibles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosDisponibles.Location = New System.Drawing.Point(225, 16)
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
        Me.lsv_Disponibles.FullRowSelect = True
        Me.lsv_Disponibles.HideSelection = False
        Me.lsv_Disponibles.Location = New System.Drawing.Point(2, 42)
        ListViewColumnSorter10.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter10.SortColumn = 0
        Me.lsv_Disponibles.Lvs = ListViewColumnSorter10
        Me.lsv_Disponibles.MultiSelect = False
        Me.lsv_Disponibles.Name = "lsv_Disponibles"
        Me.lsv_Disponibles.Row1 = 15
        Me.lsv_Disponibles.Row10 = 0
        Me.lsv_Disponibles.Row2 = 30
        Me.lsv_Disponibles.Row3 = 20
        Me.lsv_Disponibles.Row4 = 20
        Me.lsv_Disponibles.Row5 = 0
        Me.lsv_Disponibles.Row6 = 0
        Me.lsv_Disponibles.Row7 = 0
        Me.lsv_Disponibles.Row8 = 0
        Me.lsv_Disponibles.Row9 = 0
        Me.lsv_Disponibles.Size = New System.Drawing.Size(334, 154)
        Me.lsv_Disponibles.TabIndex = 0
        Me.lsv_Disponibles.UseCompatibleStateImageBehavior = False
        Me.lsv_Disponibles.View = System.Windows.Forms.View.Details
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.lbl_RegistrosSeleccionados)
        Me.GroupBox5.Controls.Add(Me.lsv_Seleccionados)
        Me.GroupBox5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox5.Location = New System.Drawing.Point(349, 3)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(253, 204)
        Me.GroupBox5.TabIndex = 1
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Empleados en sorteo"
        '
        'lbl_RegistrosSeleccionados
        '
        Me.lbl_RegistrosSeleccionados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosSeleccionados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosSeleccionados.Location = New System.Drawing.Point(138, 16)
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
        Me.lsv_Seleccionados.FullRowSelect = True
        Me.lsv_Seleccionados.HideSelection = False
        Me.lsv_Seleccionados.Location = New System.Drawing.Point(4, 42)
        ListViewColumnSorter11.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter11.SortColumn = 0
        Me.lsv_Seleccionados.Lvs = ListViewColumnSorter11
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
        Me.lsv_Seleccionados.Size = New System.Drawing.Size(247, 154)
        Me.lsv_Seleccionados.TabIndex = 1
        Me.lsv_Seleccionados.UseCompatibleStateImageBehavior = False
        Me.lsv_Seleccionados.View = System.Windows.Forms.View.Details
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.lbl_RegistrosSorteados)
        Me.GroupBox6.Controls.Add(Me.lsv_Sorteados)
        Me.GroupBox6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox6.Location = New System.Drawing.Point(608, 3)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(254, 204)
        Me.GroupBox6.TabIndex = 2
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Empleados sorteados"
        '
        'lbl_RegistrosSorteados
        '
        Me.lbl_RegistrosSorteados.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_RegistrosSorteados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_RegistrosSorteados.Location = New System.Drawing.Point(140, 16)
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
        Me.lsv_Sorteados.Location = New System.Drawing.Point(4, 42)
        ListViewColumnSorter12.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter12.SortColumn = 0
        Me.lsv_Sorteados.Lvs = ListViewColumnSorter12
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
        Me.lsv_Sorteados.Size = New System.Drawing.Size(245, 154)
        Me.lsv_Sorteados.TabIndex = 1
        Me.lsv_Sorteados.UseCompatibleStateImageBehavior = False
        Me.lsv_Sorteados.View = System.Windows.Forms.View.Details
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.cancelar1A
        Me.btn_Cancelar.Location = New System.Drawing.Point(157, 14)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 4
        Me.btn_Cancelar.Text = "Cancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'frm_SorteoAntidopingConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(884, 561)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.GroupBox1)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_SorteoAntidopingConsulta"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Sorteo Antidoping"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FechaHasta As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaDesde As System.Windows.Forms.Label
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Sorteos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_RegistrosSorteos As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_RegistrosDisponibles As System.Windows.Forms.Label
    Friend WithEvents lsv_Disponibles As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Seleccionados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_RegistrosSorteados As System.Windows.Forms.Label
    Friend WithEvents lsv_Sorteados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_RegistrosSeleccionados As System.Windows.Forms.Label
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
End Class
