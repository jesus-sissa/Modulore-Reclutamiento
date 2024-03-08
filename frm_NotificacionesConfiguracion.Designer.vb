<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NotificacionesConfiguracion
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
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Dim ListViewColumnSorter3 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Puestos = New System.Windows.Forms.GroupBox
        Me.lsv_Puestos = New Modulo_Reclutamiento.cp_Listview
        Me.Gbx_DeptoEmp = New System.Windows.Forms.GroupBox
        Me.tbx_Encabezado = New Modulo_Reclutamiento.cp_Textbox
        Me.btn_Quitar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.lsv_Departamentos = New Modulo_Reclutamiento.cp_Listview
        Me.lsv_EmpleadosNotifica = New Modulo_Reclutamiento.cp_Listview
        Me.GroupBox2.SuspendLayout()
        Me.gbx_Puestos.SuspendLayout()
        Me.Gbx_DeptoEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.btn_Cerrar)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 516)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(886, 50)
        Me.GroupBox2.TabIndex = 5
        Me.GroupBox2.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(740, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Puestos
        '
        Me.gbx_Puestos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.gbx_Puestos.Controls.Add(Me.lsv_Puestos)
        Me.gbx_Puestos.Location = New System.Drawing.Point(3, 4)
        Me.gbx_Puestos.Name = "gbx_Puestos"
        Me.gbx_Puestos.Size = New System.Drawing.Size(293, 506)
        Me.gbx_Puestos.TabIndex = 6
        Me.gbx_Puestos.TabStop = False
        '
        'lsv_Puestos
        '
        Me.lsv_Puestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Puestos.FullRowSelect = True
        Me.lsv_Puestos.HideSelection = False
        Me.lsv_Puestos.Location = New System.Drawing.Point(7, 19)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Puestos.Lvs = ListViewColumnSorter1
        Me.lsv_Puestos.MultiSelect = False
        Me.lsv_Puestos.Name = "lsv_Puestos"
        Me.lsv_Puestos.Row1 = 20
        Me.lsv_Puestos.Row10 = 0
        Me.lsv_Puestos.Row2 = 70
        Me.lsv_Puestos.Row3 = 0
        Me.lsv_Puestos.Row4 = 0
        Me.lsv_Puestos.Row5 = 0
        Me.lsv_Puestos.Row6 = 0
        Me.lsv_Puestos.Row7 = 0
        Me.lsv_Puestos.Row8 = 0
        Me.lsv_Puestos.Row9 = 0
        Me.lsv_Puestos.Size = New System.Drawing.Size(280, 481)
        Me.lsv_Puestos.TabIndex = 0
        Me.lsv_Puestos.UseCompatibleStateImageBehavior = False
        Me.lsv_Puestos.View = System.Windows.Forms.View.Details
        '
        'Gbx_DeptoEmp
        '
        Me.Gbx_DeptoEmp.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_DeptoEmp.Controls.Add(Me.tbx_Encabezado)
        Me.Gbx_DeptoEmp.Controls.Add(Me.btn_Quitar)
        Me.Gbx_DeptoEmp.Controls.Add(Me.btn_Agregar)
        Me.Gbx_DeptoEmp.Controls.Add(Me.lsv_Departamentos)
        Me.Gbx_DeptoEmp.Controls.Add(Me.lsv_EmpleadosNotifica)
        Me.Gbx_DeptoEmp.Location = New System.Drawing.Point(302, 4)
        Me.Gbx_DeptoEmp.Name = "Gbx_DeptoEmp"
        Me.Gbx_DeptoEmp.Size = New System.Drawing.Size(580, 506)
        Me.Gbx_DeptoEmp.TabIndex = 6
        Me.Gbx_DeptoEmp.TabStop = False
        '
        'tbx_Encabezado
        '
        Me.tbx_Encabezado.BackColor = System.Drawing.SystemColors.Control
        Me.tbx_Encabezado.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tbx_Encabezado.Control_Siguiente = Nothing
        Me.tbx_Encabezado.Filtrado = True
        Me.tbx_Encabezado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Encabezado.Location = New System.Drawing.Point(309, 13)
        Me.tbx_Encabezado.MaxLength = 50
        Me.tbx_Encabezado.Multiline = True
        Me.tbx_Encabezado.Name = "tbx_Encabezado"
        Me.tbx_Encabezado.Size = New System.Drawing.Size(272, 51)
        Me.tbx_Encabezado.TabIndex = 3
        Me.tbx_Encabezado.Text = "Departamentos que serán Notificados al dar de alta un Empleado del Puesto"
        Me.tbx_Encabezado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.tbx_Encabezado.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'btn_Quitar
        '
        Me.btn_Quitar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.previous
        Me.btn_Quitar.Location = New System.Drawing.Point(266, 242)
        Me.btn_Quitar.Name = "btn_Quitar"
        Me.btn_Quitar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Quitar.TabIndex = 1
        Me.btn_Quitar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._next
        Me.btn_Agregar.Location = New System.Drawing.Point(266, 161)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(40, 40)
        Me.btn_Agregar.TabIndex = 1
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'lsv_Departamentos
        '
        Me.lsv_Departamentos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lsv_Departamentos.CheckBoxes = True
        Me.lsv_Departamentos.FullRowSelect = True
        Me.lsv_Departamentos.HideSelection = False
        Me.lsv_Departamentos.Location = New System.Drawing.Point(6, 19)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Departamentos.Lvs = ListViewColumnSorter2
        Me.lsv_Departamentos.MultiSelect = False
        Me.lsv_Departamentos.Name = "lsv_Departamentos"
        Me.lsv_Departamentos.Row1 = 25
        Me.lsv_Departamentos.Row10 = 0
        Me.lsv_Departamentos.Row2 = 70
        Me.lsv_Departamentos.Row3 = 0
        Me.lsv_Departamentos.Row4 = 0
        Me.lsv_Departamentos.Row5 = 0
        Me.lsv_Departamentos.Row6 = 0
        Me.lsv_Departamentos.Row7 = 0
        Me.lsv_Departamentos.Row8 = 0
        Me.lsv_Departamentos.Row9 = 0
        Me.lsv_Departamentos.Size = New System.Drawing.Size(257, 481)
        Me.lsv_Departamentos.TabIndex = 0
        Me.lsv_Departamentos.UseCompatibleStateImageBehavior = False
        Me.lsv_Departamentos.View = System.Windows.Forms.View.Details
        '
        'lsv_EmpleadosNotifica
        '
        Me.lsv_EmpleadosNotifica.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_EmpleadosNotifica.CheckBoxes = True
        Me.lsv_EmpleadosNotifica.FullRowSelect = True
        Me.lsv_EmpleadosNotifica.HideSelection = False
        Me.lsv_EmpleadosNotifica.Location = New System.Drawing.Point(309, 67)
        ListViewColumnSorter3.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter3.SortColumn = 0
        Me.lsv_EmpleadosNotifica.Lvs = ListViewColumnSorter3
        Me.lsv_EmpleadosNotifica.MultiSelect = False
        Me.lsv_EmpleadosNotifica.Name = "lsv_EmpleadosNotifica"
        Me.lsv_EmpleadosNotifica.Row1 = 90
        Me.lsv_EmpleadosNotifica.Row10 = 0
        Me.lsv_EmpleadosNotifica.Row2 = 0
        Me.lsv_EmpleadosNotifica.Row3 = 0
        Me.lsv_EmpleadosNotifica.Row4 = 0
        Me.lsv_EmpleadosNotifica.Row5 = 0
        Me.lsv_EmpleadosNotifica.Row6 = 0
        Me.lsv_EmpleadosNotifica.Row7 = 0
        Me.lsv_EmpleadosNotifica.Row8 = 0
        Me.lsv_EmpleadosNotifica.Row9 = 0
        Me.lsv_EmpleadosNotifica.Size = New System.Drawing.Size(265, 433)
        Me.lsv_EmpleadosNotifica.TabIndex = 0
        Me.lsv_EmpleadosNotifica.UseCompatibleStateImageBehavior = False
        Me.lsv_EmpleadosNotifica.View = System.Windows.Forms.View.Details
        '
        'frm_NotificacionesConfiguracion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 571)
        Me.Controls.Add(Me.Gbx_DeptoEmp)
        Me.Controls.Add(Me.gbx_Puestos)
        Me.Controls.Add(Me.GroupBox2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(900, 600)
        Me.Name = "frm_NotificacionesConfiguracion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración de Notificaciones"
        Me.GroupBox2.ResumeLayout(False)
        Me.gbx_Puestos.ResumeLayout(False)
        Me.Gbx_DeptoEmp.ResumeLayout(False)
        Me.Gbx_DeptoEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Puestos As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_DeptoEmp As System.Windows.Forms.GroupBox
    Friend WithEvents lsv_Departamentos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lsv_Puestos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lsv_EmpleadosNotifica As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents btn_Quitar As System.Windows.Forms.Button
    Friend WithEvents tbx_Encabezado As Modulo_Reclutamiento.cp_Textbox
End Class
