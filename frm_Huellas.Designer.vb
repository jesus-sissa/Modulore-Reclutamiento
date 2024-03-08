<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm_Huellas
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Huellas))
        Me.lbl_H0 = New System.Windows.Forms.Label()
        Me.lbl_H1 = New System.Windows.Forms.Label()
        Me.lbl_H2 = New System.Windows.Forms.Label()
        Me.lbl_H3 = New System.Windows.Forms.Label()
        Me.lbl_H4 = New System.Windows.Forms.Label()
        Me.lbl_H5 = New System.Windows.Forms.Label()
        Me.lbl_H6 = New System.Windows.Forms.Label()
        Me.lbl_H7 = New System.Windows.Forms.Label()
        Me.lbl_H8 = New System.Windows.Forms.Label()
        Me.lbl_H9 = New System.Windows.Forms.Label()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.Huellero = New AxZKFPEngXControl.AxZKFPEngX()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.pct_3 = New System.Windows.Forms.PictureBox()
        Me.btn_Ayuda = New System.Windows.Forms.Button()
        Me.pct_2 = New System.Windows.Forms.PictureBox()
        Me.pct_1 = New System.Windows.Forms.PictureBox()
        Me.pct_Manos = New System.Windows.Forms.PictureBox()
        Me.pct_Huella = New System.Windows.Forms.PictureBox()
        Me.btn_conectarSensor = New System.Windows.Forms.Button()
        CType(Me.Huellero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_H0
        '
        Me.lbl_H0.AutoSize = True
        Me.lbl_H0.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H0.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H0.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H0.Location = New System.Drawing.Point(36, 187)
        Me.lbl_H0.Name = "lbl_H0"
        Me.lbl_H0.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H0.TabIndex = 3
        Me.lbl_H0.Text = " 1 "
        '
        'lbl_H1
        '
        Me.lbl_H1.AutoSize = True
        Me.lbl_H1.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H1.Location = New System.Drawing.Point(71, 169)
        Me.lbl_H1.Name = "lbl_H1"
        Me.lbl_H1.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H1.TabIndex = 4
        Me.lbl_H1.Text = " 2 "
        '
        'lbl_H2
        '
        Me.lbl_H2.AutoSize = True
        Me.lbl_H2.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H2.Location = New System.Drawing.Point(108, 165)
        Me.lbl_H2.Name = "lbl_H2"
        Me.lbl_H2.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H2.TabIndex = 5
        Me.lbl_H2.Text = " 3 "
        '
        'lbl_H3
        '
        Me.lbl_H3.AutoSize = True
        Me.lbl_H3.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H3.Location = New System.Drawing.Point(136, 188)
        Me.lbl_H3.Name = "lbl_H3"
        Me.lbl_H3.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H3.TabIndex = 6
        Me.lbl_H3.Text = " 4 "
        '
        'lbl_H4
        '
        Me.lbl_H4.AutoSize = True
        Me.lbl_H4.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H4.Location = New System.Drawing.Point(153, 279)
        Me.lbl_H4.Name = "lbl_H4"
        Me.lbl_H4.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H4.TabIndex = 7
        Me.lbl_H4.Text = " 5 "
        '
        'lbl_H5
        '
        Me.lbl_H5.AutoSize = True
        Me.lbl_H5.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H5.Location = New System.Drawing.Point(191, 279)
        Me.lbl_H5.Name = "lbl_H5"
        Me.lbl_H5.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H5.TabIndex = 8
        Me.lbl_H5.Text = " 6 "
        '
        'lbl_H6
        '
        Me.lbl_H6.AutoSize = True
        Me.lbl_H6.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H6.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H6.Location = New System.Drawing.Point(208, 188)
        Me.lbl_H6.Name = "lbl_H6"
        Me.lbl_H6.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H6.TabIndex = 9
        Me.lbl_H6.Text = " 7 "
        '
        'lbl_H7
        '
        Me.lbl_H7.AutoSize = True
        Me.lbl_H7.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H7.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H7.Location = New System.Drawing.Point(238, 165)
        Me.lbl_H7.Name = "lbl_H7"
        Me.lbl_H7.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H7.TabIndex = 10
        Me.lbl_H7.Text = " 8 "
        '
        'lbl_H8
        '
        Me.lbl_H8.AutoSize = True
        Me.lbl_H8.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H8.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H8.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H8.Location = New System.Drawing.Point(275, 169)
        Me.lbl_H8.Name = "lbl_H8"
        Me.lbl_H8.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H8.TabIndex = 11
        Me.lbl_H8.Text = " 9 "
        '
        'lbl_H9
        '
        Me.lbl_H9.AutoSize = True
        Me.lbl_H9.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H9.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H9.Location = New System.Drawing.Point(307, 187)
        Me.lbl_H9.Name = "lbl_H9"
        Me.lbl_H9.Size = New System.Drawing.Size(28, 20)
        Me.lbl_H9.TabIndex = 12
        Me.lbl_H9.Text = "10"
        '
        'lbl_Status
        '
        Me.lbl_Status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(208, 12)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(152, 112)
        Me.lbl_Status.TabIndex = 2
        Me.lbl_Status.Text = "STATUS"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Huellero
        '
        Me.Huellero.Enabled = True
        Me.Huellero.Location = New System.Drawing.Point(280, 127)
        Me.Huellero.Name = "Huellero"
        Me.Huellero.OcxState = CType(resources.GetObject("Huellero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Huellero.Size = New System.Drawing.Size(24, 24)
        Me.Huellero.TabIndex = 29
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(238, 419)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(122, 37)
        Me.btn_Cerrar.TabIndex = 14
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'pct_3
        '
        Me.pct_3.BackColor = System.Drawing.Color.Silver
        Me.pct_3.Location = New System.Drawing.Point(251, 385)
        Me.pct_3.Name = "pct_3"
        Me.pct_3.Size = New System.Drawing.Size(109, 23)
        Me.pct_3.TabIndex = 28
        Me.pct_3.TabStop = False
        '
        'btn_Ayuda
        '
        Me.btn_Ayuda.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Ayuda.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.help_contents
        Me.btn_Ayuda.Location = New System.Drawing.Point(346, 0)
        Me.btn_Ayuda.Name = "btn_Ayuda"
        Me.btn_Ayuda.Size = New System.Drawing.Size(26, 24)
        Me.btn_Ayuda.TabIndex = 1
        Me.btn_Ayuda.UseVisualStyleBackColor = True
        '
        'pct_2
        '
        Me.pct_2.BackColor = System.Drawing.Color.Silver
        Me.pct_2.Location = New System.Drawing.Point(131, 385)
        Me.pct_2.Name = "pct_2"
        Me.pct_2.Size = New System.Drawing.Size(110, 23)
        Me.pct_2.TabIndex = 24
        Me.pct_2.TabStop = False
        '
        'pct_1
        '
        Me.pct_1.BackColor = System.Drawing.Color.Silver
        Me.pct_1.Location = New System.Drawing.Point(12, 385)
        Me.pct_1.Name = "pct_1"
        Me.pct_1.Size = New System.Drawing.Size(109, 23)
        Me.pct_1.TabIndex = 23
        Me.pct_1.TabStop = False
        '
        'pct_Manos
        '
        Me.pct_Manos.BackColor = System.Drawing.Color.White
        Me.pct_Manos.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Manos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Dos_Manos
        Me.pct_Manos.Location = New System.Drawing.Point(12, 164)
        Me.pct_Manos.Name = "pct_Manos"
        Me.pct_Manos.Size = New System.Drawing.Size(348, 244)
        Me.pct_Manos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Manos.TabIndex = 5
        Me.pct_Manos.TabStop = False
        '
        'pct_Huella
        '
        Me.pct_Huella.BackColor = System.Drawing.Color.White
        Me.pct_Huella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Huella.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Huella.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Huella.InitialImage = Nothing
        Me.pct_Huella.Location = New System.Drawing.Point(57, 12)
        Me.pct_Huella.Name = "pct_Huella"
        Me.pct_Huella.Size = New System.Drawing.Size(138, 146)
        Me.pct_Huella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Huella.TabIndex = 0
        Me.pct_Huella.TabStop = False
        '
        'btn_conectarSensor
        '
        Me.btn_conectarSensor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_conectarSensor.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.agt_reload
        Me.btn_conectarSensor.ImageAlign = System.Drawing.ContentAlignment.TopLeft
        Me.btn_conectarSensor.Location = New System.Drawing.Point(25, 420)
        Me.btn_conectarSensor.Name = "btn_conectarSensor"
        Me.btn_conectarSensor.Size = New System.Drawing.Size(195, 37)
        Me.btn_conectarSensor.TabIndex = 30
        Me.btn_conectarSensor.Text = "&Conectar Lector de Huellas"
        Me.btn_conectarSensor.UseVisualStyleBackColor = True
        '
        'frm_Huellas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(372, 468)
        Me.Controls.Add(Me.btn_conectarSensor)
        Me.Controls.Add(Me.Huellero)
        Me.Controls.Add(Me.pct_3)
        Me.Controls.Add(Me.btn_Ayuda)
        Me.Controls.Add(Me.pct_2)
        Me.Controls.Add(Me.pct_1)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.lbl_H9)
        Me.Controls.Add(Me.lbl_H8)
        Me.Controls.Add(Me.lbl_H7)
        Me.Controls.Add(Me.lbl_H6)
        Me.Controls.Add(Me.lbl_H5)
        Me.Controls.Add(Me.lbl_H4)
        Me.Controls.Add(Me.lbl_H3)
        Me.Controls.Add(Me.lbl_H2)
        Me.Controls.Add(Me.lbl_H1)
        Me.Controls.Add(Me.lbl_H0)
        Me.Controls.Add(Me.pct_Manos)
        Me.Controls.Add(Me.pct_Huella)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_Huellas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Captura de Huellas"
        CType(Me.Huellero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pct_Huella As System.Windows.Forms.PictureBox
    Friend WithEvents pct_Manos As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_H0 As System.Windows.Forms.Label
    Friend WithEvents lbl_H1 As System.Windows.Forms.Label
    Friend WithEvents lbl_H2 As System.Windows.Forms.Label
    Friend WithEvents lbl_H3 As System.Windows.Forms.Label
    Friend WithEvents lbl_H4 As System.Windows.Forms.Label
    Friend WithEvents lbl_H5 As System.Windows.Forms.Label
    Friend WithEvents lbl_H6 As System.Windows.Forms.Label
    Friend WithEvents lbl_H7 As System.Windows.Forms.Label
    Friend WithEvents lbl_H8 As System.Windows.Forms.Label
    Friend WithEvents lbl_H9 As System.Windows.Forms.Label
    Friend WithEvents lbl_Status As System.Windows.Forms.Label
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents pct_1 As System.Windows.Forms.PictureBox
    Friend WithEvents pct_2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_Ayuda As System.Windows.Forms.Button
    Friend WithEvents pct_3 As System.Windows.Forms.PictureBox
    Friend WithEvents Huellero As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents btn_conectarSensor As Button
End Class
