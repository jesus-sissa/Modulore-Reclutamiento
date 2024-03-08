<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ObtenerImagen_Settings
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
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_Camara = New System.Windows.Forms.GroupBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Cmb_Resolucion = New System.Windows.Forms.ComboBox
        Me.Cmb_Camara = New System.Windows.Forms.ComboBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.gbx_Imagenes = New System.Windows.Forms.GroupBox
        Me.gbx_Impresora = New System.Windows.Forms.GroupBox
        Me.Label7 = New System.Windows.Forms.Label
        Me.cmb_Zebra = New System.Windows.Forms.ComboBox
        Me.tbx_CompresionImagen = New Modulo_Reclutamiento.cp_Textbox
        Me.tbx_TamanoMaxImagen = New Modulo_Reclutamiento.cp_Textbox
        Me.gbx_Botones.SuspendLayout()
        Me.gbx_Camara.SuspendLayout()
        Me.gbx_Imagenes.SuspendLayout()
        Me.gbx_Impresora.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.gbx_Botones.Location = New System.Drawing.Point(0, 206)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(424, 50)
        Me.gbx_Botones.TabIndex = 3
        Me.gbx_Botones.TabStop = False
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Guardar.CausesValidation = False
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 14)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.BackColor = System.Drawing.SystemColors.Control
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(278, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'gbx_Camara
        '
        Me.gbx_Camara.Controls.Add(Me.Label5)
        Me.gbx_Camara.Controls.Add(Me.Label3)
        Me.gbx_Camara.Controls.Add(Me.Cmb_Resolucion)
        Me.gbx_Camara.Controls.Add(Me.Cmb_Camara)
        Me.gbx_Camara.Location = New System.Drawing.Point(0, 0)
        Me.gbx_Camara.Name = "gbx_Camara"
        Me.gbx_Camara.Size = New System.Drawing.Size(424, 92)
        Me.gbx_Camara.TabIndex = 4
        Me.gbx_Camara.TabStop = False
        Me.gbx_Camara.Text = "Cámara"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Resolución"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(18, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Cámara Web"
        '
        'Cmb_Resolucion
        '
        Me.Cmb_Resolucion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Resolucion.FormattingEnabled = True
        Me.Cmb_Resolucion.Location = New System.Drawing.Point(93, 46)
        Me.Cmb_Resolucion.Name = "Cmb_Resolucion"
        Me.Cmb_Resolucion.Size = New System.Drawing.Size(200, 21)
        Me.Cmb_Resolucion.TabIndex = 18
        '
        'Cmb_Camara
        '
        Me.Cmb_Camara.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.Cmb_Camara.FormattingEnabled = True
        Me.Cmb_Camara.Location = New System.Drawing.Point(93, 19)
        Me.Cmb_Camara.Name = "Cmb_Camara"
        Me.Cmb_Camara.Size = New System.Drawing.Size(300, 21)
        Me.Cmb_Camara.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(126, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Compresión de Imagenes"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(215, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(125, 13)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Tamaño Max. de Imagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(181, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 13)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(387, 22)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "Kb."
        '
        'gbx_Imagenes
        '
        Me.gbx_Imagenes.Controls.Add(Me.Label6)
        Me.gbx_Imagenes.Controls.Add(Me.tbx_CompresionImagen)
        Me.gbx_Imagenes.Controls.Add(Me.Label4)
        Me.gbx_Imagenes.Controls.Add(Me.Label1)
        Me.gbx_Imagenes.Controls.Add(Me.tbx_TamanoMaxImagen)
        Me.gbx_Imagenes.Controls.Add(Me.Label2)
        Me.gbx_Imagenes.Location = New System.Drawing.Point(0, 98)
        Me.gbx_Imagenes.Name = "gbx_Imagenes"
        Me.gbx_Imagenes.Size = New System.Drawing.Size(424, 49)
        Me.gbx_Imagenes.TabIndex = 5
        Me.gbx_Imagenes.TabStop = False
        Me.gbx_Imagenes.Text = "Imagenes"
        '
        'gbx_Impresora
        '
        Me.gbx_Impresora.Controls.Add(Me.cmb_Zebra)
        Me.gbx_Impresora.Controls.Add(Me.Label7)
        Me.gbx_Impresora.Location = New System.Drawing.Point(0, 153)
        Me.gbx_Impresora.Name = "gbx_Impresora"
        Me.gbx_Impresora.Size = New System.Drawing.Size(424, 52)
        Me.gbx_Impresora.TabIndex = 6
        Me.gbx_Impresora.TabStop = False
        Me.gbx_Impresora.Text = "Impresora"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(19, 22)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Credenciales"
        '
        'cmb_Zebra
        '
        Me.cmb_Zebra.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Zebra.FormattingEnabled = True
        Me.cmb_Zebra.Location = New System.Drawing.Point(93, 19)
        Me.cmb_Zebra.Name = "cmb_Zebra"
        Me.cmb_Zebra.Size = New System.Drawing.Size(300, 21)
        Me.cmb_Zebra.TabIndex = 21
        '
        'tbx_CompresionImagen
        '
        Me.tbx_CompresionImagen.Control_Siguiente = Nothing
        Me.tbx_CompresionImagen.Filtrado = True
        Me.tbx_CompresionImagen.Location = New System.Drawing.Point(140, 19)
        Me.tbx_CompresionImagen.MaxLength = 3
        Me.tbx_CompresionImagen.Name = "tbx_CompresionImagen"
        Me.tbx_CompresionImagen.Size = New System.Drawing.Size(35, 20)
        Me.tbx_CompresionImagen.TabIndex = 22
        Me.tbx_CompresionImagen.Text = "999"
        Me.tbx_CompresionImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_CompresionImagen.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'tbx_TamanoMaxImagen
        '
        Me.tbx_TamanoMaxImagen.Control_Siguiente = Nothing
        Me.tbx_TamanoMaxImagen.Filtrado = True
        Me.tbx_TamanoMaxImagen.Location = New System.Drawing.Point(346, 19)
        Me.tbx_TamanoMaxImagen.MaxLength = 4
        Me.tbx_TamanoMaxImagen.Name = "tbx_TamanoMaxImagen"
        Me.tbx_TamanoMaxImagen.Size = New System.Drawing.Size(35, 20)
        Me.tbx_TamanoMaxImagen.TabIndex = 24
        Me.tbx_TamanoMaxImagen.Text = "1024"
        Me.tbx_TamanoMaxImagen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.tbx_TamanoMaxImagen.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Numeros_Enteros
        '
        'frm_ObtenerImagen_Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(424, 256)
        Me.Controls.Add(Me.gbx_Impresora)
        Me.Controls.Add(Me.gbx_Imagenes)
        Me.Controls.Add(Me.gbx_Camara)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_ObtenerImagen_Settings"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Configuración"
        Me.gbx_Botones.ResumeLayout(False)
        Me.gbx_Camara.ResumeLayout(False)
        Me.gbx_Camara.PerformLayout()
        Me.gbx_Imagenes.ResumeLayout(False)
        Me.gbx_Imagenes.PerformLayout()
        Me.gbx_Impresora.ResumeLayout(False)
        Me.gbx_Impresora.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents gbx_Camara As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Cmb_Resolucion As System.Windows.Forms.ComboBox
    Friend WithEvents Cmb_Camara As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents tbx_TamanoMaxImagen As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents tbx_CompresionImagen As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbx_Imagenes As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Impresora As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents cmb_Zebra As System.Windows.Forms.ComboBox
End Class
