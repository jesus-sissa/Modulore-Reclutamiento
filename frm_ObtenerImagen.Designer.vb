<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_ObtenerImagen
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btn_Setting = New System.Windows.Forms.Button
        Me.Btn_AddImagen = New System.Windows.Forms.Button
        Me.Btn_Aceptar = New System.Windows.Forms.Button
        Me.btn_Scan = New System.Windows.Forms.Button
        Me.btn_NuevaFoto = New System.Windows.Forms.Button
        Me.btn_Salir = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Btn_RotarDerecha = New System.Windows.Forms.Button
        Me.Btn_Guardar = New System.Windows.Forms.Button
        Me.Chk_Recortar = New System.Windows.Forms.CheckBox
        Me.Btn_AplicarRecorte = New System.Windows.Forms.Button
        Me.btn_MenosBrillo = New System.Windows.Forms.Button
        Me.btn_MasBrillo = New System.Windows.Forms.Button
        Me.lbl_Brillo = New System.Windows.Forms.Label
        Me.btn_Rotar = New System.Windows.Forms.Button
        Me.btn_Original = New System.Windows.Forms.Button
        Me.btn_Capturar = New System.Windows.Forms.Button
        Me.lbl_Camara = New System.Windows.Forms.Label
        Me.Ctr_Camara = New Camera_NET.CameraControl
        Me.tmr_Foto = New System.Windows.Forms.Timer(Me.components)
        Me.sfd_Guardar = New System.Windows.Forms.SaveFileDialog
        Me.Pct_Foto = New System.Windows.Forms.PictureBox
        Me.lbl_NombreDocumento = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.Pct_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.btn_Setting)
        Me.GroupBox1.Controls.Add(Me.Btn_AddImagen)
        Me.GroupBox1.Controls.Add(Me.Btn_Aceptar)
        Me.GroupBox1.Controls.Add(Me.btn_Scan)
        Me.GroupBox1.Controls.Add(Me.btn_NuevaFoto)
        Me.GroupBox1.Controls.Add(Me.btn_Salir)
        Me.GroupBox1.Location = New System.Drawing.Point(2, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(778, 61)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Origen de la Imagen"
        '
        'btn_Setting
        '
        Me.btn_Setting.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.CatalogosGlobales
        Me.btn_Setting.Location = New System.Drawing.Point(339, 22)
        Me.btn_Setting.Name = "btn_Setting"
        Me.btn_Setting.Size = New System.Drawing.Size(100, 30)
        Me.btn_Setting.TabIndex = 46
        Me.btn_Setting.Text = "Configuración"
        Me.btn_Setting.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Setting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Setting.UseVisualStyleBackColor = True
        '
        'Btn_AddImagen
        '
        Me.Btn_AddImagen.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_AddImagen.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.folder_open
        Me.Btn_AddImagen.Location = New System.Drawing.Point(223, 22)
        Me.Btn_AddImagen.Name = "Btn_AddImagen"
        Me.Btn_AddImagen.Size = New System.Drawing.Size(100, 30)
        Me.Btn_AddImagen.TabIndex = 45
        Me.Btn_AddImagen.Text = "Archivo"
        Me.Btn_AddImagen.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_AddImagen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_AddImagen.UseVisualStyleBackColor = True
        '
        'Btn_Aceptar
        '
        Me.Btn_Aceptar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.HoraSi
        Me.Btn_Aceptar.Location = New System.Drawing.Point(561, 22)
        Me.Btn_Aceptar.Name = "Btn_Aceptar"
        Me.Btn_Aceptar.Size = New System.Drawing.Size(100, 30)
        Me.Btn_Aceptar.TabIndex = 44
        Me.Btn_Aceptar.Text = "Aceptar"
        Me.Btn_Aceptar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Aceptar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Aceptar.UseVisualStyleBackColor = True
        '
        'btn_Scan
        '
        Me.btn_Scan.Enabled = False
        Me.btn_Scan.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.scanner_app___copia
        Me.btn_Scan.Location = New System.Drawing.Point(117, 22)
        Me.btn_Scan.Name = "btn_Scan"
        Me.btn_Scan.Size = New System.Drawing.Size(100, 30)
        Me.btn_Scan.TabIndex = 42
        Me.btn_Scan.Text = "Escaner"
        Me.btn_Scan.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Scan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Scan.UseVisualStyleBackColor = True
        '
        'btn_NuevaFoto
        '
        Me.btn_NuevaFoto.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara2
        Me.btn_NuevaFoto.Location = New System.Drawing.Point(11, 22)
        Me.btn_NuevaFoto.Name = "btn_NuevaFoto"
        Me.btn_NuevaFoto.Size = New System.Drawing.Size(100, 30)
        Me.btn_NuevaFoto.TabIndex = 41
        Me.btn_NuevaFoto.Text = "Camara"
        Me.btn_NuevaFoto.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_NuevaFoto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_NuevaFoto.UseVisualStyleBackColor = True
        '
        'btn_Salir
        '
        Me.btn_Salir.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Salir.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Delete
        Me.btn_Salir.Location = New System.Drawing.Point(667, 22)
        Me.btn_Salir.Name = "btn_Salir"
        Me.btn_Salir.Size = New System.Drawing.Size(100, 30)
        Me.btn_Salir.TabIndex = 43
        Me.btn_Salir.Text = "Cerrar"
        Me.btn_Salir.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Salir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Salir.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.Btn_RotarDerecha)
        Me.GroupBox2.Controls.Add(Me.Btn_Guardar)
        Me.GroupBox2.Controls.Add(Me.Chk_Recortar)
        Me.GroupBox2.Controls.Add(Me.Btn_AplicarRecorte)
        Me.GroupBox2.Controls.Add(Me.btn_MenosBrillo)
        Me.GroupBox2.Controls.Add(Me.btn_MasBrillo)
        Me.GroupBox2.Controls.Add(Me.lbl_Brillo)
        Me.GroupBox2.Controls.Add(Me.btn_Rotar)
        Me.GroupBox2.Controls.Add(Me.btn_Original)
        Me.GroupBox2.Controls.Add(Me.btn_Capturar)
        Me.GroupBox2.Location = New System.Drawing.Point(650, 76)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(130, 481)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        '
        'Btn_RotarDerecha
        '
        Me.Btn_RotarDerecha.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.refresh_derecha
        Me.Btn_RotarDerecha.Location = New System.Drawing.Point(69, 221)
        Me.Btn_RotarDerecha.Name = "Btn_RotarDerecha"
        Me.Btn_RotarDerecha.Size = New System.Drawing.Size(50, 50)
        Me.Btn_RotarDerecha.TabIndex = 54
        Me.Btn_RotarDerecha.Text = "Rotar"
        Me.Btn_RotarDerecha.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Btn_RotarDerecha.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_RotarDerecha.UseVisualStyleBackColor = True
        '
        'Btn_Guardar
        '
        Me.Btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Guardar.Location = New System.Drawing.Point(15, 75)
        Me.Btn_Guardar.Name = "Btn_Guardar"
        Me.Btn_Guardar.Size = New System.Drawing.Size(100, 50)
        Me.Btn_Guardar.TabIndex = 53
        Me.Btn_Guardar.Text = "Guardar [F3]"
        Me.Btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_Guardar.UseVisualStyleBackColor = True
        Me.Btn_Guardar.Visible = False
        '
        'Chk_Recortar
        '
        Me.Chk_Recortar.Appearance = System.Windows.Forms.Appearance.Button
        Me.Chk_Recortar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Seleccionar
        Me.Chk_Recortar.Location = New System.Drawing.Point(15, 287)
        Me.Chk_Recortar.Name = "Chk_Recortar"
        Me.Chk_Recortar.Size = New System.Drawing.Size(100, 50)
        Me.Chk_Recortar.TabIndex = 52
        Me.Chk_Recortar.Text = "Recortar"
        Me.Chk_Recortar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Chk_Recortar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Chk_Recortar.UseVisualStyleBackColor = True
        '
        'Btn_AplicarRecorte
        '
        Me.Btn_AplicarRecorte.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.RecortarImagen
        Me.Btn_AplicarRecorte.Location = New System.Drawing.Point(15, 352)
        Me.Btn_AplicarRecorte.Name = "Btn_AplicarRecorte"
        Me.Btn_AplicarRecorte.Size = New System.Drawing.Size(100, 50)
        Me.Btn_AplicarRecorte.TabIndex = 51
        Me.Btn_AplicarRecorte.Text = "Aplicar Recorte"
        Me.Btn_AplicarRecorte.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.Btn_AplicarRecorte.UseVisualStyleBackColor = True
        '
        'btn_MenosBrillo
        '
        Me.btn_MenosBrillo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MenosBrillo.Location = New System.Drawing.Point(20, 185)
        Me.btn_MenosBrillo.Name = "btn_MenosBrillo"
        Me.btn_MenosBrillo.Size = New System.Drawing.Size(25, 25)
        Me.btn_MenosBrillo.TabIndex = 50
        Me.btn_MenosBrillo.Text = "-"
        Me.btn_MenosBrillo.UseVisualStyleBackColor = True
        '
        'btn_MasBrillo
        '
        Me.btn_MasBrillo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_MasBrillo.Location = New System.Drawing.Point(86, 185)
        Me.btn_MasBrillo.Name = "btn_MasBrillo"
        Me.btn_MasBrillo.Size = New System.Drawing.Size(25, 25)
        Me.btn_MasBrillo.TabIndex = 48
        Me.btn_MasBrillo.Text = "+"
        Me.btn_MasBrillo.UseVisualStyleBackColor = True
        '
        'lbl_Brillo
        '
        Me.lbl_Brillo.AutoSize = True
        Me.lbl_Brillo.Location = New System.Drawing.Point(51, 191)
        Me.lbl_Brillo.Name = "lbl_Brillo"
        Me.lbl_Brillo.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Brillo.TabIndex = 49
        Me.lbl_Brillo.Text = "Brillo"
        '
        'btn_Rotar
        '
        Me.btn_Rotar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.refresh
        Me.btn_Rotar.Location = New System.Drawing.Point(19, 221)
        Me.btn_Rotar.Name = "btn_Rotar"
        Me.btn_Rotar.Size = New System.Drawing.Size(50, 50)
        Me.btn_Rotar.TabIndex = 46
        Me.btn_Rotar.Text = "Rotar"
        Me.btn_Rotar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Rotar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Rotar.UseVisualStyleBackColor = True
        '
        'btn_Original
        '
        Me.btn_Original.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.imagen_original
        Me.btn_Original.Location = New System.Drawing.Point(15, 411)
        Me.btn_Original.Name = "btn_Original"
        Me.btn_Original.Size = New System.Drawing.Size(100, 50)
        Me.btn_Original.TabIndex = 47
        Me.btn_Original.Text = "Original"
        Me.btn_Original.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_Original.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Original.UseVisualStyleBackColor = True
        '
        'btn_Capturar
        '
        Me.btn_Capturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Capturar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_Capturar.Location = New System.Drawing.Point(15, 19)
        Me.btn_Capturar.Name = "btn_Capturar"
        Me.btn_Capturar.Size = New System.Drawing.Size(100, 50)
        Me.btn_Capturar.TabIndex = 45
        Me.btn_Capturar.Text = "Capturar [F2]"
        Me.btn_Capturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText
        Me.btn_Capturar.UseVisualStyleBackColor = True
        '
        'lbl_Camara
        '
        Me.lbl_Camara.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Camara.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Camara.Location = New System.Drawing.Point(2, 543)
        Me.lbl_Camara.Name = "lbl_Camara"
        Me.lbl_Camara.Size = New System.Drawing.Size(639, 18)
        Me.lbl_Camara.TabIndex = 2
        Me.lbl_Camara.Text = "Desde:"
        Me.lbl_Camara.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Ctr_Camara
        '
        Me.Ctr_Camara.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Ctr_Camara.DirectShowLogFilepath = ""
        Me.Ctr_Camara.Location = New System.Drawing.Point(5, 100)
        Me.Ctr_Camara.Name = "Ctr_Camara"
        Me.Ctr_Camara.Size = New System.Drawing.Size(635, 440)
        Me.Ctr_Camara.TabIndex = 4
        '
        'tmr_Foto
        '
        Me.tmr_Foto.Interval = 1000
        '
        'Pct_Foto
        '
        Me.Pct_Foto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Pct_Foto.Location = New System.Drawing.Point(5, 101)
        Me.Pct_Foto.Name = "Pct_Foto"
        Me.Pct_Foto.Size = New System.Drawing.Size(635, 439)
        Me.Pct_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.Pct_Foto.TabIndex = 3
        Me.Pct_Foto.TabStop = False
        '
        'lbl_NombreDocumento
        '
        Me.lbl_NombreDocumento.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_NombreDocumento.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_NombreDocumento.Location = New System.Drawing.Point(2, 73)
        Me.lbl_NombreDocumento.Name = "lbl_NombreDocumento"
        Me.lbl_NombreDocumento.Size = New System.Drawing.Size(639, 18)
        Me.lbl_NombreDocumento.TabIndex = 5
        Me.lbl_NombreDocumento.Text = "Obteniendo imagen para:"
        Me.lbl_NombreDocumento.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'frm_ObtenerImagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.lbl_NombreDocumento)
        Me.Controls.Add(Me.Ctr_Camara)
        Me.Controls.Add(Me.Pct_Foto)
        Me.Controls.Add(Me.lbl_Camara)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 600)
        Me.Name = "frm_ObtenerImagen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Obtener Imagen"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.Pct_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Btn_AddImagen As System.Windows.Forms.Button
    Friend WithEvents Btn_Aceptar As System.Windows.Forms.Button
    Friend WithEvents btn_Scan As System.Windows.Forms.Button
    Friend WithEvents btn_NuevaFoto As System.Windows.Forms.Button
    Friend WithEvents btn_Salir As System.Windows.Forms.Button
    Friend WithEvents Btn_RotarDerecha As System.Windows.Forms.Button
    Friend WithEvents Btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents Chk_Recortar As System.Windows.Forms.CheckBox
    Friend WithEvents Btn_AplicarRecorte As System.Windows.Forms.Button
    Friend WithEvents btn_MenosBrillo As System.Windows.Forms.Button
    Friend WithEvents btn_MasBrillo As System.Windows.Forms.Button
    Friend WithEvents lbl_Brillo As System.Windows.Forms.Label
    Friend WithEvents btn_Rotar As System.Windows.Forms.Button
    Friend WithEvents btn_Original As System.Windows.Forms.Button
    Friend WithEvents btn_Capturar As System.Windows.Forms.Button
    Friend WithEvents lbl_Camara As System.Windows.Forms.Label
    Friend WithEvents Pct_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents Ctr_Camara As Camera_NET.CameraControl
    Friend WithEvents btn_Setting As System.Windows.Forms.Button
    Friend WithEvents tmr_Foto As System.Windows.Forms.Timer
    Friend WithEvents sfd_Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lbl_NombreDocumento As System.Windows.Forms.Label
End Class
