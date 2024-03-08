<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_EmpleadosIValidar
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
        Me.btn_Continuar = New System.Windows.Forms.Button
        Me.gbx_Descripcion = New System.Windows.Forms.GroupBox
        Me.pct_HuellaV = New System.Windows.Forms.PictureBox
        Me.tbx_Puesto = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Departamento = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Empleado = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_Validacion = New Modulo_Reclutamiento.cp_Textbox
        Me.lbl_Puesto = New System.Windows.Forms.Label
        Me.lbl_Departamento = New System.Windows.Forms.Label
        Me.lbl_Empleado = New System.Windows.Forms.Label
        Me.btn_Capturar = New System.Windows.Forms.Button
        Me.lbl_Validacion = New System.Windows.Forms.Label
        Me.pct_Huella = New System.Windows.Forms.PictureBox
        Me.tmr_Huella = New System.Windows.Forms.Timer(Me.components)
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.gbx_Descripcion.SuspendLayout()
        CType(Me.pct_HuellaV, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_Continuar
        '
        Me.btn_Continuar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._next
        Me.btn_Continuar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Continuar.Name = "btn_Continuar"
        Me.btn_Continuar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Continuar.TabIndex = 0
        Me.btn_Continuar.Text = "&Continuar"
        Me.btn_Continuar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Continuar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Continuar.UseVisualStyleBackColor = True
        '
        'gbx_Descripcion
        '
        Me.gbx_Descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Descripcion.Controls.Add(Me.pct_HuellaV)
        Me.gbx_Descripcion.Controls.Add(Me.tbx_Puesto)
        Me.gbx_Descripcion.Controls.Add(Me.tbx_Departamento)
        Me.gbx_Descripcion.Controls.Add(Me.tbx_Empleado)
        Me.gbx_Descripcion.Controls.Add(Me.tbx_Validacion)
        Me.gbx_Descripcion.Controls.Add(Me.lbl_Puesto)
        Me.gbx_Descripcion.Controls.Add(Me.lbl_Departamento)
        Me.gbx_Descripcion.Controls.Add(Me.lbl_Empleado)
        Me.gbx_Descripcion.Controls.Add(Me.btn_Capturar)
        Me.gbx_Descripcion.Controls.Add(Me.lbl_Validacion)
        Me.gbx_Descripcion.Controls.Add(Me.pct_Huella)
        Me.gbx_Descripcion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbx_Descripcion.Location = New System.Drawing.Point(12, -2)
        Me.gbx_Descripcion.Name = "gbx_Descripcion"
        Me.gbx_Descripcion.Size = New System.Drawing.Size(500, 129)
        Me.gbx_Descripcion.TabIndex = 8
        Me.gbx_Descripcion.TabStop = False
        Me.gbx_Descripcion.Text = "Descripción"
        '
        'pct_HuellaV
        '
        Me.pct_HuellaV.BackColor = System.Drawing.Color.Transparent
        Me.pct_HuellaV.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Delete
        Me.pct_HuellaV.Location = New System.Drawing.Point(64, 91)
        Me.pct_HuellaV.Name = "pct_HuellaV"
        Me.pct_HuellaV.Size = New System.Drawing.Size(17, 17)
        Me.pct_HuellaV.TabIndex = 140
        Me.pct_HuellaV.TabStop = False
        '
        'tbx_Puesto
        '
        Me.tbx_Puesto.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Puesto.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Puesto.Control_Siguiente = Nothing
        Me.tbx_Puesto.Filtrado = True
        Me.tbx_Puesto.Location = New System.Drawing.Point(162, 93)
        Me.tbx_Puesto.Name = "tbx_Puesto"
        Me.tbx_Puesto.ReadOnly = True
        Me.tbx_Puesto.Size = New System.Drawing.Size(332, 20)
        Me.tbx_Puesto.TabIndex = 136
        Me.tbx_Puesto.TabStop = False
        Me.tbx_Puesto.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'tbx_Departamento
        '
        Me.tbx_Departamento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Departamento.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Departamento.Control_Siguiente = Nothing
        Me.tbx_Departamento.Filtrado = True
        Me.tbx_Departamento.Location = New System.Drawing.Point(162, 67)
        Me.tbx_Departamento.Name = "tbx_Departamento"
        Me.tbx_Departamento.ReadOnly = True
        Me.tbx_Departamento.Size = New System.Drawing.Size(332, 20)
        Me.tbx_Departamento.TabIndex = 135
        Me.tbx_Departamento.TabStop = False
        Me.tbx_Departamento.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'tbx_Empleado
        '
        Me.tbx_Empleado.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Empleado.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Empleado.Control_Siguiente = Nothing
        Me.tbx_Empleado.Filtrado = True
        Me.tbx_Empleado.Location = New System.Drawing.Point(162, 41)
        Me.tbx_Empleado.Name = "tbx_Empleado"
        Me.tbx_Empleado.ReadOnly = True
        Me.tbx_Empleado.Size = New System.Drawing.Size(332, 20)
        Me.tbx_Empleado.TabIndex = 134
        Me.tbx_Empleado.TabStop = False
        Me.tbx_Empleado.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'tbx_Validacion
        '
        Me.tbx_Validacion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbx_Validacion.BackColor = System.Drawing.SystemColors.Window
        Me.tbx_Validacion.Control_Siguiente = Nothing
        Me.tbx_Validacion.Filtrado = True
        Me.tbx_Validacion.ForeColor = System.Drawing.Color.DarkGray
        Me.tbx_Validacion.Location = New System.Drawing.Point(162, 15)
        Me.tbx_Validacion.Name = "tbx_Validacion"
        Me.tbx_Validacion.ReadOnly = True
        Me.tbx_Validacion.Size = New System.Drawing.Size(332, 20)
        Me.tbx_Validacion.TabIndex = 133
        Me.tbx_Validacion.TabStop = False
        Me.tbx_Validacion.Text = "Poner Huella"
        Me.tbx_Validacion.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'lbl_Puesto
        '
        Me.lbl_Puesto.AutoSize = True
        Me.lbl_Puesto.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Puesto.Location = New System.Drawing.Point(116, 96)
        Me.lbl_Puesto.Name = "lbl_Puesto"
        Me.lbl_Puesto.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Puesto.TabIndex = 131
        Me.lbl_Puesto.Text = "Puesto"
        '
        'lbl_Departamento
        '
        Me.lbl_Departamento.AutoSize = True
        Me.lbl_Departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Departamento.Location = New System.Drawing.Point(82, 70)
        Me.lbl_Departamento.Name = "lbl_Departamento"
        Me.lbl_Departamento.Size = New System.Drawing.Size(74, 13)
        Me.lbl_Departamento.TabIndex = 132
        Me.lbl_Departamento.Text = "Departamento"
        '
        'lbl_Empleado
        '
        Me.lbl_Empleado.AutoSize = True
        Me.lbl_Empleado.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Empleado.Location = New System.Drawing.Point(102, 44)
        Me.lbl_Empleado.Name = "lbl_Empleado"
        Me.lbl_Empleado.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Empleado.TabIndex = 130
        Me.lbl_Empleado.Text = "Empleado"
        '
        'btn_Capturar
        '
        Me.btn_Capturar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Capturar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Fingerprint24x24
        Me.btn_Capturar.Location = New System.Drawing.Point(6, 91)
        Me.btn_Capturar.Name = "btn_Capturar"
        Me.btn_Capturar.Size = New System.Drawing.Size(30, 25)
        Me.btn_Capturar.TabIndex = 1
        Me.btn_Capturar.UseVisualStyleBackColor = True
        '
        'lbl_Validacion
        '
        Me.lbl_Validacion.AutoSize = True
        Me.lbl_Validacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Validacion.Location = New System.Drawing.Point(100, 18)
        Me.lbl_Validacion.Name = "lbl_Validacion"
        Me.lbl_Validacion.Size = New System.Drawing.Size(56, 13)
        Me.lbl_Validacion.TabIndex = 0
        Me.lbl_Validacion.Text = "Validación"
        '
        'pct_Huella
        '
        Me.pct_Huella.BackColor = System.Drawing.Color.White
        Me.pct_Huella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Huella.Location = New System.Drawing.Point(6, 16)
        Me.pct_Huella.Name = "pct_Huella"
        Me.pct_Huella.Size = New System.Drawing.Size(75, 73)
        Me.pct_Huella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Huella.TabIndex = 128
        Me.pct_Huella.TabStop = False
        '
        'tmr_Huella
        '
        Me.tmr_Huella.Interval = 2000
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Continuar)
        Me.gbx_Botones.Location = New System.Drawing.Point(12, 133)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(520, 50)
        Me.gbx_Botones.TabIndex = 9
        Me.gbx_Botones.TabStop = False
        '
        'frm_EmpleadosIValidar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.gbx_Descripcion)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(550, 220)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(550, 220)
        Me.Name = "frm_EmpleadosIValidar"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Validar Huellas del Empleado"
        Me.gbx_Descripcion.ResumeLayout(False)
        Me.gbx_Descripcion.PerformLayout()
        CType(Me.pct_HuellaV, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_Continuar As System.Windows.Forms.Button
    Friend WithEvents gbx_Descripcion As System.Windows.Forms.GroupBox
    Friend WithEvents pct_Huella As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_Validacion As System.Windows.Forms.Label
    Friend WithEvents btn_Capturar As System.Windows.Forms.Button
    Friend WithEvents lbl_Departamento As System.Windows.Forms.Label
    Friend WithEvents lbl_Puesto As System.Windows.Forms.Label
    Friend WithEvents lbl_Empleado As System.Windows.Forms.Label
    Friend WithEvents tbx_Puesto As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Departamento As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Empleado As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_Validacion As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tmr_Huella As System.Windows.Forms.Timer
    Friend WithEvents pct_HuellaV As System.Windows.Forms.PictureBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
End Class
