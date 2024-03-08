<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_RecortarFoto
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
        Me.Gbx_Foto = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_masc2 = New System.Windows.Forms.Button
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.lbl_brillo = New System.Windows.Forms.Label
        Me.btn_fotoOriginal = New System.Windows.Forms.Button
        Me.btn_cortaFoto = New System.Windows.Forms.Button
        Me.ptb_mascara = New System.Windows.Forms.PictureBox
        Me.ptb_Foto = New System.Windows.Forms.PictureBox
        Me.tbr_brillo = New System.Windows.Forms.TrackBar
        Me.lbl_Nombre_Baja = New System.Windows.Forms.Label
        Me.gbx_empleado = New System.Windows.Forms.GroupBox
        Me.rdb_Externo = New System.Windows.Forms.RadioButton
        Me.rdb_Interno = New System.Windows.Forms.RadioButton
        Me.cmb_NombreEmpleado = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_ClaveEmpleado = New Modulo_Reclutamiento.cp_Textbox
        Me.Gbx_Foto.SuspendLayout()
        CType(Me.ptb_mascara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbr_brillo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbx_empleado.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Foto
        '
        Me.Gbx_Foto.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Foto.Controls.Add(Me.btn_masc2)
        Me.Gbx_Foto.Controls.Add(Me.Label11)
        Me.Gbx_Foto.Controls.Add(Me.Label9)
        Me.Gbx_Foto.Controls.Add(Me.lbl_brillo)
        Me.Gbx_Foto.Controls.Add(Me.btn_fotoOriginal)
        Me.Gbx_Foto.Controls.Add(Me.btn_cortaFoto)
        Me.Gbx_Foto.Controls.Add(Me.ptb_mascara)
        Me.Gbx_Foto.Controls.Add(Me.ptb_Foto)
        Me.Gbx_Foto.Controls.Add(Me.tbr_brillo)
        Me.Gbx_Foto.Location = New System.Drawing.Point(7, 73)
        Me.Gbx_Foto.Name = "Gbx_Foto"
        Me.Gbx_Foto.Size = New System.Drawing.Size(536, 444)
        Me.Gbx_Foto.TabIndex = 3
        Me.Gbx_Foto.TabStop = False
        Me.Gbx_Foto.Text = "Editar Foto"
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(390, 408)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 45
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_masc2
        '
        Me.btn_masc2.Enabled = False
        Me.btn_masc2.Location = New System.Drawing.Point(6, 408)
        Me.btn_masc2.Name = "btn_masc2"
        Me.btn_masc2.Size = New System.Drawing.Size(120, 30)
        Me.btn_masc2.TabIndex = 44
        Me.btn_masc2.Text = "Usar Mascara 2"
        Me.btn_masc2.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(448, 364)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(18, 19)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "+"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(54, 366)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(14, 19)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "-"
        '
        'lbl_brillo
        '
        Me.lbl_brillo.AutoSize = True
        Me.lbl_brillo.Location = New System.Drawing.Point(20, 367)
        Me.lbl_brillo.Name = "lbl_brillo"
        Me.lbl_brillo.Size = New System.Drawing.Size(29, 13)
        Me.lbl_brillo.TabIndex = 41
        Me.lbl_brillo.Text = "Brillo"
        '
        'btn_fotoOriginal
        '
        Me.btn_fotoOriginal.Enabled = False
        Me.btn_fotoOriginal.Location = New System.Drawing.Point(132, 408)
        Me.btn_fotoOriginal.Name = "btn_fotoOriginal"
        Me.btn_fotoOriginal.Size = New System.Drawing.Size(120, 30)
        Me.btn_fotoOriginal.TabIndex = 37
        Me.btn_fotoOriginal.Text = "&Volver Original"
        Me.btn_fotoOriginal.UseVisualStyleBackColor = True
        '
        'btn_cortaFoto
        '
        Me.btn_cortaFoto.Enabled = False
        Me.btn_cortaFoto.Location = New System.Drawing.Point(258, 408)
        Me.btn_cortaFoto.Name = "btn_cortaFoto"
        Me.btn_cortaFoto.Size = New System.Drawing.Size(120, 30)
        Me.btn_cortaFoto.TabIndex = 38
        Me.btn_cortaFoto.Text = "Cortar Foto"
        Me.btn_cortaFoto.UseVisualStyleBackColor = True
        '
        'ptb_mascara
        '
        Me.ptb_mascara.BackColor = System.Drawing.Color.Transparent
        Me.ptb_mascara.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ptb_mascara.Cursor = System.Windows.Forms.Cursors.Default
        Me.ptb_mascara.ErrorImage = Nothing
        Me.ptb_mascara.InitialImage = Nothing
        Me.ptb_mascara.Location = New System.Drawing.Point(151, 83)
        Me.ptb_mascara.Name = "ptb_mascara"
        Me.ptb_mascara.Size = New System.Drawing.Size(216, 234)
        Me.ptb_mascara.TabIndex = 39
        Me.ptb_mascara.TabStop = False
        Me.ptb_mascara.Visible = False
        '
        'ptb_Foto
        '
        Me.ptb_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.ptb_Foto.Location = New System.Drawing.Point(38, 19)
        Me.ptb_Foto.Name = "ptb_Foto"
        Me.ptb_Foto.Size = New System.Drawing.Size(446, 335)
        Me.ptb_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.ptb_Foto.TabIndex = 35
        Me.ptb_Foto.TabStop = False
        '
        'tbr_brillo
        '
        Me.tbr_brillo.Enabled = False
        Me.tbr_brillo.Location = New System.Drawing.Point(74, 357)
        Me.tbr_brillo.Maximum = 100
        Me.tbr_brillo.Minimum = -100
        Me.tbr_brillo.Name = "tbr_brillo"
        Me.tbr_brillo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbr_brillo.Size = New System.Drawing.Size(368, 45)
        Me.tbr_brillo.TabIndex = 40
        Me.tbr_brillo.TickFrequency = 20
        '
        'lbl_Nombre_Baja
        '
        Me.lbl_Nombre_Baja.AutoSize = True
        Me.lbl_Nombre_Baja.Location = New System.Drawing.Point(18, 32)
        Me.lbl_Nombre_Baja.Name = "lbl_Nombre_Baja"
        Me.lbl_Nombre_Baja.Size = New System.Drawing.Size(54, 13)
        Me.lbl_Nombre_Baja.TabIndex = 4
        Me.lbl_Nombre_Baja.Text = "Empleado"
        Me.lbl_Nombre_Baja.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'gbx_empleado
        '
        Me.gbx_empleado.Controls.Add(Me.rdb_Externo)
        Me.gbx_empleado.Controls.Add(Me.rdb_Interno)
        Me.gbx_empleado.Controls.Add(Me.cmb_NombreEmpleado)
        Me.gbx_empleado.Controls.Add(Me.lbl_Nombre_Baja)
        Me.gbx_empleado.Controls.Add(Me.tbx_ClaveEmpleado)
        Me.gbx_empleado.Location = New System.Drawing.Point(7, 1)
        Me.gbx_empleado.Name = "gbx_empleado"
        Me.gbx_empleado.Size = New System.Drawing.Size(536, 66)
        Me.gbx_empleado.TabIndex = 7
        Me.gbx_empleado.TabStop = False
        Me.gbx_empleado.Text = "Empleado"
        '
        'rdb_Externo
        '
        Me.rdb_Externo.AutoSize = True
        Me.rdb_Externo.Location = New System.Drawing.Point(278, 11)
        Me.rdb_Externo.Name = "rdb_Externo"
        Me.rdb_Externo.Size = New System.Drawing.Size(61, 17)
        Me.rdb_Externo.TabIndex = 28
        Me.rdb_Externo.TabStop = True
        Me.rdb_Externo.Text = "Externo"
        Me.rdb_Externo.UseVisualStyleBackColor = True
        '
        'rdb_Interno
        '
        Me.rdb_Interno.AutoSize = True
        Me.rdb_Interno.Location = New System.Drawing.Point(197, 10)
        Me.rdb_Interno.Name = "rdb_Interno"
        Me.rdb_Interno.Size = New System.Drawing.Size(58, 17)
        Me.rdb_Interno.TabIndex = 27
        Me.rdb_Interno.TabStop = True
        Me.rdb_Interno.Text = "Interno"
        Me.rdb_Interno.UseVisualStyleBackColor = True
        '
        'cmb_NombreEmpleado
        '
        Me.cmb_NombreEmpleado.Clave = "Clave_Empleado"
        Me.cmb_NombreEmpleado.Control_Siguiente = Nothing
        Me.cmb_NombreEmpleado.DisplayMember = "Nombre"
        Me.cmb_NombreEmpleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_NombreEmpleado.Empresa = False
        Me.cmb_NombreEmpleado.Filtro = Me.tbx_ClaveEmpleado
        Me.cmb_NombreEmpleado.FormattingEnabled = True
        Me.cmb_NombreEmpleado.Location = New System.Drawing.Point(74, 29)
        Me.cmb_NombreEmpleado.MaxDropDownItems = 20
        Me.cmb_NombreEmpleado.Name = "cmb_NombreEmpleado"
        Me.cmb_NombreEmpleado.Pista = False
        Me.cmb_NombreEmpleado.Size = New System.Drawing.Size(410, 21)
        Me.cmb_NombreEmpleado.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_NombreEmpleado.Sucursal = True
        Me.cmb_NombreEmpleado.TabIndex = 6
        Me.cmb_NombreEmpleado.Tipo = 0
        Me.cmb_NombreEmpleado.ValueMember = "Id_Empleado"
        '
        'tbx_ClaveEmpleado
        '
        Me.tbx_ClaveEmpleado.Control_Siguiente = Me.cmb_NombreEmpleado
        Me.tbx_ClaveEmpleado.Filtrado = True
        Me.tbx_ClaveEmpleado.Location = New System.Drawing.Point(76, 13)
        Me.tbx_ClaveEmpleado.MaxLength = 12
        Me.tbx_ClaveEmpleado.Name = "tbx_ClaveEmpleado"
        Me.tbx_ClaveEmpleado.Size = New System.Drawing.Size(50, 20)
        Me.tbx_ClaveEmpleado.TabIndex = 5
        Me.tbx_ClaveEmpleado.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        Me.tbx_ClaveEmpleado.Visible = False
        '
        'frm_RecortarFoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(554, 531)
        Me.Controls.Add(Me.gbx_empleado)
        Me.Controls.Add(Me.Gbx_Foto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_RecortarFoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Recortar Foto para la Credencial"
        Me.Gbx_Foto.ResumeLayout(False)
        Me.Gbx_Foto.PerformLayout()
        CType(Me.ptb_mascara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ptb_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbr_brillo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbx_empleado.ResumeLayout(False)
        Me.gbx_empleado.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Gbx_Foto As System.Windows.Forms.GroupBox
    Friend WithEvents btn_masc2 As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents lbl_brillo As System.Windows.Forms.Label
    Friend WithEvents btn_fotoOriginal As System.Windows.Forms.Button
    Friend WithEvents btn_cortaFoto As System.Windows.Forms.Button
    Friend WithEvents ptb_mascara As System.Windows.Forms.PictureBox
    Friend WithEvents ptb_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents tbr_brillo As System.Windows.Forms.TrackBar
    Friend WithEvents tbx_ClaveEmpleado As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents cmb_NombreEmpleado As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Nombre_Baja As System.Windows.Forms.Label
    Friend WithEvents gbx_empleado As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents rdb_Externo As System.Windows.Forms.RadioButton
    Friend WithEvents rdb_Interno As System.Windows.Forms.RadioButton
End Class
