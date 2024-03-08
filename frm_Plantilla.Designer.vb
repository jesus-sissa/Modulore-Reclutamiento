<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Plantilla
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
        Me.Gbx_Listado = New System.Windows.Forms.GroupBox
        Me.Lbl_Numero = New System.Windows.Forms.Label
        Me.btn_Cancelar = New System.Windows.Forms.Button
        Me.btn_Agregar = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl_NumExterior = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Modificar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.tbx_PlantillaActual = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Depto = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Puesto = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_PlantillaRequerida = New Modulo_Reclutamiento.cp_Textbox
        Me.lsv_Puestos = New Modulo_Reclutamiento.cp_Listview
        Me.Gbx_Listado.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Listado
        '
        Me.Gbx_Listado.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Listado.Controls.Add(Me.Lbl_Numero)
        Me.Gbx_Listado.Controls.Add(Me.btn_Cancelar)
        Me.Gbx_Listado.Controls.Add(Me.btn_Agregar)
        Me.Gbx_Listado.Controls.Add(Me.tbx_PlantillaActual)
        Me.Gbx_Listado.Controls.Add(Me.Label1)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Depto)
        Me.Gbx_Listado.Controls.Add(Me.tbx_Puesto)
        Me.Gbx_Listado.Controls.Add(Me.tbx_PlantillaRequerida)
        Me.Gbx_Listado.Controls.Add(Me.lbl_NumExterior)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Departamento)
        Me.Gbx_Listado.Controls.Add(Me.lbl_Puesto)
        Me.Gbx_Listado.Controls.Add(Me.lsv_Puestos)
        Me.Gbx_Listado.Location = New System.Drawing.Point(5, 12)
        Me.Gbx_Listado.Name = "Gbx_Listado"
        Me.Gbx_Listado.Size = New System.Drawing.Size(784, 497)
        Me.Gbx_Listado.TabIndex = 0
        Me.Gbx_Listado.TabStop = False
        '
        'Lbl_Numero
        '
        Me.Lbl_Numero.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Numero.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Numero.Location = New System.Drawing.Point(555, 97)
        Me.Lbl_Numero.Name = "Lbl_Numero"
        Me.Lbl_Numero.Size = New System.Drawing.Size(222, 23)
        Me.Lbl_Numero.TabIndex = 12
        Me.Lbl_Numero.Text = "Registros: 0"
        Me.Lbl_Numero.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btn_Cancelar
        '
        Me.btn_Cancelar.Enabled = False
        Me.btn_Cancelar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cancelar
        Me.btn_Cancelar.Location = New System.Drawing.Point(326, 89)
        Me.btn_Cancelar.Name = "btn_Cancelar"
        Me.btn_Cancelar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cancelar.TabIndex = 11
        Me.btn_Cancelar.Text = "C&ancelar"
        Me.btn_Cancelar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cancelar.UseVisualStyleBackColor = True
        '
        'btn_Agregar
        '
        Me.btn_Agregar.Enabled = False
        Me.btn_Agregar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Agregar.Location = New System.Drawing.Point(163, 89)
        Me.btn_Agregar.Name = "btn_Agregar"
        Me.btn_Agregar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Agregar.TabIndex = 10
        Me.btn_Agregar.Text = "Guardar"
        Me.btn_Agregar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Agregar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Agregar.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(25, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(76, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Plantilla Actual"
        '
        'lbl_NumExterior
        '
        Me.lbl_NumExterior.AutoSize = True
        Me.lbl_NumExterior.Location = New System.Drawing.Point(6, 76)
        Me.lbl_NumExterior.Name = "lbl_NumExterior"
        Me.lbl_NumExterior.Size = New System.Drawing.Size(95, 13)
        Me.lbl_NumExterior.TabIndex = 6
        Me.lbl_NumExterior.Text = "Plantilla Requerida"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Location = New System.Drawing.Point(27, 24)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 0
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Location = New System.Drawing.Point(61, 50)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 3
        Me.lbl_Puesto.Text = "Puesto"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_Modificar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(5, 515)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(784, 50)
        Me.Gbx_Botones.TabIndex = 1
        Me.Gbx_Botones.TabStop = False
        '
        'btn_Modificar
        '
        Me.btn_Modificar.Enabled = False
        Me.btn_Modificar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Editar
        Me.btn_Modificar.Location = New System.Drawing.Point(9, 13)
        Me.btn_Modificar.Name = "btn_Modificar"
        Me.btn_Modificar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Modificar.TabIndex = 0
        Me.btn_Modificar.Text = "&Modificar"
        Me.btn_Modificar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Modificar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Modificar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(638, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'tbx_PlantillaActual
        '
        Me.tbx_PlantillaActual.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_PlantillaActual.Control_Siguiente = Nothing
        Me.tbx_PlantillaActual.Enabled = False
        Me.tbx_PlantillaActual.Filtrado = True
        Me.tbx_PlantillaActual.Location = New System.Drawing.Point(107, 99)
        Me.tbx_PlantillaActual.MaxLength = 3
        Me.tbx_PlantillaActual.Name = "tbx_PlantillaActual"
        Me.tbx_PlantillaActual.ReadOnly = True
        Me.tbx_PlantillaActual.Size = New System.Drawing.Size(50, 20)
        Me.tbx_PlantillaActual.TabIndex = 9
        Me.tbx_PlantillaActual.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_Depto
        '
        Me.tbx_Depto.Control_Siguiente = Nothing
        Me.tbx_Depto.Enabled = False
        Me.tbx_Depto.Filtrado = True
        Me.tbx_Depto.Location = New System.Drawing.Point(107, 21)
        Me.tbx_Depto.MaxLength = 4
        Me.tbx_Depto.Name = "tbx_Depto"
        Me.tbx_Depto.Size = New System.Drawing.Size(359, 20)
        Me.tbx_Depto.TabIndex = 1
        Me.tbx_Depto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.Control_Siguiente = Nothing
        Me.tbx_Puesto.Enabled = False
        Me.tbx_Puesto.Filtrado = True
        Me.tbx_Puesto.Location = New System.Drawing.Point(107, 47)
        Me.tbx_Puesto.MaxLength = 4
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.Size = New System.Drawing.Size(359, 20)
        Me.tbx_Puesto.TabIndex = 4
        Me.tbx_Puesto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasYnumeros
        '
        'tbx_PlantillaRequerida
        '
        Me.tbx_PlantillaRequerida.Control_Siguiente = Nothing
        Me.tbx_PlantillaRequerida.Enabled = False
        Me.tbx_PlantillaRequerida.Filtrado = True
        Me.tbx_PlantillaRequerida.Location = New System.Drawing.Point(107, 73)
        Me.tbx_PlantillaRequerida.MaxLength = 3
        Me.tbx_PlantillaRequerida.Name = "tbx_PlantillaRequerida"
        Me.tbx_PlantillaRequerida.Size = New System.Drawing.Size(50, 20)
        Me.tbx_PlantillaRequerida.TabIndex = 7
        Me.tbx_PlantillaRequerida.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'lsv_Puestos
        '
        Me.lsv_Puestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Puestos.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Puestos.FullRowSelect = True
        Me.lsv_Puestos.HideSelection = False
        Me.lsv_Puestos.Location = New System.Drawing.Point(7, 125)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Puestos.Lvs = ListViewColumnSorter1
        Me.lsv_Puestos.MultiSelect = False
        Me.lsv_Puestos.Name = "lsv_Puestos"
        Me.lsv_Puestos.Row1 = 20
        Me.lsv_Puestos.Row10 = 0
        Me.lsv_Puestos.Row2 = 30
        Me.lsv_Puestos.Row3 = 8
        Me.lsv_Puestos.Row4 = 8
        Me.lsv_Puestos.Row5 = 8
        Me.lsv_Puestos.Row6 = 0
        Me.lsv_Puestos.Row7 = 0
        Me.lsv_Puestos.Row8 = 0
        Me.lsv_Puestos.Row9 = 0
        Me.lsv_Puestos.Size = New System.Drawing.Size(770, 366)
        Me.lsv_Puestos.TabIndex = 13
        Me.lsv_Puestos.UseCompatibleStateImageBehavior = False
        Me.lsv_Puestos.View = System.Windows.Forms.View.Details
        '
        'frm_Plantilla
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(794, 571)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Listado)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_Plantilla"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Plantilla por Departamento"
        Me.Gbx_Listado.ResumeLayout(False)
        Me.Gbx_Listado.PerformLayout()
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Listado As System.Windows.Forms.GroupBox
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents lsv_Puestos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents tbx_PlantillaActual As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbx_PlantillaRequerida As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_NumExterior As System.Windows.Forms.Label
    Friend WithEvents btn_Agregar As System.Windows.Forms.Button
    Friend WithEvents tbx_Depto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Puesto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents btn_Modificar As System.Windows.Forms.Button
    Friend WithEvents btn_Cancelar As System.Windows.Forms.Button
    Friend WithEvents Lbl_Numero As System.Windows.Forms.Label
End Class
