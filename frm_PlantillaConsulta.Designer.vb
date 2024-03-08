<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_PlantillaConsulta
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
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Empleados = New System.Windows.Forms.GroupBox
        Me.gbx_Datos = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.lsv_Datos = New Modulo_Reclutamiento.cp_Listview
        Me.lsv_Empleados = New Modulo_Reclutamiento.cp_Listview
        Me.Gbx_Botones.SuspendLayout()
        Me.gbx_Empleados.SuspendLayout()
        Me.gbx_Datos.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 584)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 2
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(624, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 0
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Empleados
        '
        Me.gbx_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Empleados.Controls.Add(Me.lsv_Empleados)
        Me.gbx_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Empleados.Location = New System.Drawing.Point(7, 333)
        Me.gbx_Empleados.Name = "gbx_Empleados"
        Me.gbx_Empleados.Size = New System.Drawing.Size(770, 245)
        Me.gbx_Empleados.TabIndex = 1
        Me.gbx_Empleados.TabStop = False
        Me.gbx_Empleados.Text = "Empleados Activos"
        '
        'gbx_Datos
        '
        Me.gbx_Datos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Datos.Controls.Add(Me.Lbl_Numero)
        Me.gbx_Datos.Controls.Add(Me.lsv_Datos)
        Me.gbx_Datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Datos.Location = New System.Drawing.Point(7, 4)
        Me.gbx_Datos.Name = "gbx_Datos"
        Me.gbx_Datos.Size = New System.Drawing.Size(770, 323)
        Me.gbx_Datos.TabIndex = 0
        Me.gbx_Datos.TabStop = False
        Me.gbx_Datos.Text = "Plantilla"
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(542, 16)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 23
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lsv_Datos
        '
        Me.lsv_Datos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Datos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Datos.FullRowSelect = True
        Me.lsv_Datos.HideSelection = False
        Me.lsv_Datos.Location = New System.Drawing.Point(6, 44)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Datos.Lvs = ListViewColumnSorter2
        Me.lsv_Datos.MultiSelect = False
        Me.lsv_Datos.Name = "lsv_Datos"
        Me.lsv_Datos.Row1 = 30
        Me.lsv_Datos.Row10 = 0
        Me.lsv_Datos.Row2 = 30
        Me.lsv_Datos.Row3 = 15
        Me.lsv_Datos.Row4 = 15
        Me.lsv_Datos.Row5 = 0
        Me.lsv_Datos.Row6 = 0
        Me.lsv_Datos.Row7 = 0
        Me.lsv_Datos.Row8 = 0
        Me.lsv_Datos.Row9 = 0
        Me.lsv_Datos.Size = New System.Drawing.Size(758, 273)
        Me.lsv_Datos.TabIndex = 0
        Me.lsv_Datos.UseCompatibleStateImageBehavior = False
        Me.lsv_Datos.View = System.Windows.Forms.View.Details
        '
        'lsv_Empleados
        '
        Me.lsv_Empleados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Empleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Empleados.FullRowSelect = True
        Me.lsv_Empleados.HideSelection = False
        Me.lsv_Empleados.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Empleados.Lvs = ListViewColumnSorter1
        Me.lsv_Empleados.MultiSelect = False
        Me.lsv_Empleados.Name = "lsv_Empleados"
        Me.lsv_Empleados.Row1 = 15
        Me.lsv_Empleados.Row10 = 0
        Me.lsv_Empleados.Row2 = 40
        Me.lsv_Empleados.Row3 = 20
        Me.lsv_Empleados.Row4 = 20
        Me.lsv_Empleados.Row5 = 0
        Me.lsv_Empleados.Row6 = 0
        Me.lsv_Empleados.Row7 = 0
        Me.lsv_Empleados.Row8 = 0
        Me.lsv_Empleados.Row9 = 0
        Me.lsv_Empleados.Size = New System.Drawing.Size(758, 220)
        Me.lsv_Empleados.TabIndex = 0
        Me.lsv_Empleados.UseCompatibleStateImageBehavior = False
        Me.lsv_Empleados.View = System.Windows.Forms.View.Details
        '
        'frm_PlantillaConsulta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 641)
        Me.Controls.Add(Me.gbx_Datos)
        Me.Controls.Add(Me.gbx_Empleados)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_PlantillaConsulta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Consulta de Plantilla"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.gbx_Empleados.ResumeLayout(False)
        Me.gbx_Datos.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Empleados As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents gbx_Empleados As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Datos As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Datos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
