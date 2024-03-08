<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DocumentosXempleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DocumentosXempleado))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.gbx_Filtro = New System.Windows.Forms.GroupBox
        Me.lbl_Status = New System.Windows.Forms.Label
        Me.cmb_Status = New Modulo_Reclutamiento.cp_cmb_Manual
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.dtp_FechaHasta = New System.Windows.Forms.DateTimePicker
        Me.dtp_FechaDesde = New System.Windows.Forms.DateTimePicker
        Me.btn_Mostrar = New System.Windows.Forms.Button
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.lsv_Datos = New Modulo_Reclutamiento.cp_Listview
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Exportar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Filtro.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Filtro
        '
        Me.gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Filtro.Controls.Add(Me.lbl_Status)
        Me.gbx_Filtro.Controls.Add(Me.cmb_Status)
        Me.gbx_Filtro.Controls.Add(Me.Label2)
        Me.gbx_Filtro.Controls.Add(Me.Label1)
        Me.gbx_Filtro.Controls.Add(Me.dtp_FechaHasta)
        Me.gbx_Filtro.Controls.Add(Me.dtp_FechaDesde)
        Me.gbx_Filtro.Controls.Add(Me.btn_Mostrar)
        Me.gbx_Filtro.Location = New System.Drawing.Point(5, 5)
        Me.gbx_Filtro.Name = "gbx_Filtro"
        Me.gbx_Filtro.Size = New System.Drawing.Size(987, 103)
        Me.gbx_Filtro.TabIndex = 0
        Me.gbx_Filtro.TabStop = False
        '
        'lbl_Status
        '
        Me.lbl_Status.AutoSize = True
        Me.lbl_Status.Location = New System.Drawing.Point(31, 77)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(137, 13)
        Me.lbl_Status.TabIndex = 37
        Me.lbl_Status.Text = "Status Actual del Empleado"
        '
        'cmb_Status
        '
        Me.cmb_Status.Control_Siguiente = Nothing
        Me.cmb_Status.DisplayMember = "display"
        Me.cmb_Status.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Status.FormattingEnabled = True
        Me.cmb_Status.Location = New System.Drawing.Point(174, 74)
        Me.cmb_Status.MaxDropDownItems = 20
        Me.cmb_Status.Name = "cmb_Status"
        Me.cmb_Status.Size = New System.Drawing.Size(97, 21)
        Me.cmb_Status.TabIndex = 36
        Me.cmb_Status.ValueMember = "value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(48, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 13)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Fecha de Ingreso Inicial"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(120, 13)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "Fecha de Ingreso Inicial"
        '
        'dtp_FechaHasta
        '
        Me.dtp_FechaHasta.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaHasta.Location = New System.Drawing.Point(174, 45)
        Me.dtp_FechaHasta.Name = "dtp_FechaHasta"
        Me.dtp_FechaHasta.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaHasta.TabIndex = 33
        '
        'dtp_FechaDesde
        '
        Me.dtp_FechaDesde.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaDesde.Location = New System.Drawing.Point(174, 19)
        Me.dtp_FechaDesde.Name = "dtp_FechaDesde"
        Me.dtp_FechaDesde.Size = New System.Drawing.Size(98, 20)
        Me.dtp_FechaDesde.TabIndex = 32
        '
        'btn_Mostrar
        '
        Me.btn_Mostrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.btn_Mostrar.Location = New System.Drawing.Point(306, 67)
        Me.btn_Mostrar.Name = "btn_Mostrar"
        Me.btn_Mostrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Mostrar.TabIndex = 31
        Me.btn_Mostrar.Text = "Mostrar"
        Me.btn_Mostrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Mostrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Mostrar.UseVisualStyleBackColor = True
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Numero)
        Me.gbx_Datos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Datos.Location = New System.Drawing.Point(5, 111)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(987, 482)
        Me.gbx_Datos.TabIndex = 1
        Me.gbx_Datos.TabStop = False
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(764, 16)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(217, 23)
        Me.Lbl_Numero.TabIndex = 33
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(7, 42)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter1
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 7
        Me.lsv_Datos.Row10 = 15
        Me.lsv_Datos.Row2 = 15
        Me.lsv_Datos.Row3 = 10
        Me.lsv_Datos.Row4 = 12
        Me.lsv_Datos.Row5 = 12
        Me.lsv_Datos.Row6 = 12
        Me.lsv_Datos.Row7 = 8
        Me.lsv_Datos.Row8 = 8
        Me.lsv_Datos.Row9 = 8
        Me.lsv_Datos.Size = New System.Drawing.Size(974, 434)
        Me.lsv_Datos.TabIndex = 32
        Me.lsv_Datos.Tag = "Id_TipoParentesco"
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 599)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(987, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(7, 15)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 4
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(841, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 5
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_DocumentosXempleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1000, 656)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Filtro)
        Me.Name = "frm_DocumentosXempleado"
        Me.Text = "frm_DocumentosXempleado"
        Me.gbx_Filtro.ResumeLayout(False)
        Me.gbx_Filtro.PerformLayout()
        Me.gbx_Datos.ResumeLayout(False)
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Filtro As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Mostrar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
    Friend WithEvents lsv_Datos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Exportar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents dtp_FechaHasta As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_FechaDesde As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents cmb_Status As Modulo_Reclutamiento.cp_cmb_Manual
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
