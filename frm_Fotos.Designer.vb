<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Fotos
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
        Me.dlg_Guardar = New System.Windows.Forms.SaveFileDialog
        Me.lst_Camaras = New System.Windows.Forms.ListBox
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Resolucion = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Capturar = New System.Windows.Forms.Button
        Me.tmr_Iniciar = New System.Windows.Forms.Timer(Me.components)
        Me.pct_Foto = New System.Windows.Forms.PictureBox
        Me.lbl_Camara = New System.Windows.Forms.Label
        Me.gbx_Botones.SuspendLayout()
        CType(Me.pct_Foto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dlg_Guardar
        '
        Me.dlg_Guardar.FileName = "Webcam1"
        Me.dlg_Guardar.Filter = "Bitmap|*.bmp"
        '
        'lst_Camaras
        '
        Me.lst_Camaras.Location = New System.Drawing.Point(242, 7)
        Me.lst_Camaras.Name = "lst_Camaras"
        Me.lst_Camaras.Size = New System.Drawing.Size(108, 56)
        Me.lst_Camaras.TabIndex = 1
        Me.lst_Camaras.Visible = False
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Resolucion)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Controls.Add(Me.btn_Capturar)
        Me.gbx_Botones.Location = New System.Drawing.Point(9, 336)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(387, 50)
        Me.gbx_Botones.TabIndex = 2
        Me.gbx_Botones.TabStop = False
        '
        'btn_Resolucion
        '
        Me.btn_Resolucion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Resolucion.Location = New System.Drawing.Point(152, 13)
        Me.btn_Resolucion.Name = "btn_Resolucion"
        Me.btn_Resolucion.Size = New System.Drawing.Size(83, 30)
        Me.btn_Resolucion.TabIndex = 2
        Me.btn_Resolucion.Text = "Resolución"
        Me.btn_Resolucion.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Resolucion.Visible = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(241, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar (Esc)"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'btn_Capturar
        '
        Me.btn_Capturar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Capturar.Enabled = False
        Me.btn_Capturar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Camara
        Me.btn_Capturar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Capturar.Name = "btn_Capturar"
        Me.btn_Capturar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Capturar.TabIndex = 0
        Me.btn_Capturar.Text = "Cap&turar (F2)"
        Me.btn_Capturar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Capturar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'tmr_Iniciar
        '
        Me.tmr_Iniciar.Enabled = True
        Me.tmr_Iniciar.Interval = 1000
        '
        'pct_Foto
        '
        Me.pct_Foto.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pct_Foto.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Foto.Location = New System.Drawing.Point(9, 32)
        Me.pct_Foto.Name = "pct_Foto"
        Me.pct_Foto.Size = New System.Drawing.Size(387, 298)
        Me.pct_Foto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pct_Foto.TabIndex = 6
        Me.pct_Foto.TabStop = False
        '
        'lbl_Camara
        '
        Me.lbl_Camara.AutoSize = True
        Me.lbl_Camara.Location = New System.Drawing.Point(6, 7)
        Me.lbl_Camara.Name = "lbl_Camara"
        Me.lbl_Camara.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Camara.TabIndex = 0
        Me.lbl_Camara.Text = "Camara"
        '
        'frm_Fotos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(404, 391)
        Me.Controls.Add(Me.lbl_Camara)
        Me.Controls.Add(Me.lst_Camaras)
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.pct_Foto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(410, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(410, 420)
        Me.Name = "frm_Fotos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Capturar Foto"
        Me.gbx_Botones.ResumeLayout(False)
        CType(Me.pct_Foto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_Capturar As System.Windows.Forms.Button
    Friend WithEvents dlg_Guardar As System.Windows.Forms.SaveFileDialog
    Friend WithEvents lst_Camaras As System.Windows.Forms.ListBox
    Friend WithEvents pct_Foto As System.Windows.Forms.PictureBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents tmr_Iniciar As System.Windows.Forms.Timer
    Friend WithEvents lbl_Camara As System.Windows.Forms.Label
    Friend WithEvents btn_Resolucion As System.Windows.Forms.Button
End Class
