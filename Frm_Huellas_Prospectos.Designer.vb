<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_Huellas_Prospectos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_Huellas_Prospectos))
        Me.Huellero = New AxZKFPEngXControl.AxZKFPEngX()
        Me.lbl_Status = New System.Windows.Forms.Label()
        Me.lbl_H5 = New System.Windows.Forms.Label()
        Me.lbl_H4 = New System.Windows.Forms.Label()
        Me.btn_conectarSensor = New System.Windows.Forms.Button()
        Me.pct_3 = New System.Windows.Forms.PictureBox()
        Me.pct_2 = New System.Windows.Forms.PictureBox()
        Me.pct_1 = New System.Windows.Forms.PictureBox()
        Me.btn_Cerrar = New System.Windows.Forms.Button()
        Me.pct_Manos = New System.Windows.Forms.PictureBox()
        Me.pct_Huella = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.Huellero, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Huellero
        '
        Me.Huellero.Enabled = True
        Me.Huellero.Location = New System.Drawing.Point(277, 157)
        Me.Huellero.Name = "Huellero"
        Me.Huellero.OcxState = CType(resources.GetObject("Huellero.OcxState"), System.Windows.Forms.AxHost.State)
        Me.Huellero.Size = New System.Drawing.Size(24, 24)
        Me.Huellero.TabIndex = 60
        '
        'lbl_Status
        '
        Me.lbl_Status.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lbl_Status.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Status.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Status.Location = New System.Drawing.Point(179, 323)
        Me.lbl_Status.Name = "lbl_Status"
        Me.lbl_Status.Size = New System.Drawing.Size(207, 33)
        Me.lbl_Status.TabIndex = 52
        Me.lbl_Status.Text = "STATUS"
        Me.lbl_Status.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_H5
        '
        Me.lbl_H5.AutoSize = True
        Me.lbl_H5.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H5.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H5.Location = New System.Drawing.Point(230, 108)
        Me.lbl_H5.Name = "lbl_H5"
        Me.lbl_H5.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H5.TabIndex = 55
        Me.lbl_H5.Text = " 6 "
        '
        'lbl_H4
        '
        Me.lbl_H4.AutoSize = True
        Me.lbl_H4.BackColor = System.Drawing.Color.Yellow
        Me.lbl_H4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_H4.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_H4.Location = New System.Drawing.Point(179, 108)
        Me.lbl_H4.Name = "lbl_H4"
        Me.lbl_H4.Size = New System.Drawing.Size(29, 20)
        Me.lbl_H4.TabIndex = 54
        Me.lbl_H4.Text = " 5 "
        '
        'btn_conectarSensor
        '
        Me.btn_conectarSensor.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_conectarSensor.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.conectar
        Me.btn_conectarSensor.Location = New System.Drawing.Point(118, 386)
        Me.btn_conectarSensor.Name = "btn_conectarSensor"
        Me.btn_conectarSensor.Size = New System.Drawing.Size(78, 68)
        Me.btn_conectarSensor.TabIndex = 61
        Me.btn_conectarSensor.UseVisualStyleBackColor = True
        '
        'pct_3
        '
        Me.pct_3.BackColor = System.Drawing.Color.Silver
        Me.pct_3.Location = New System.Drawing.Point(205, 287)
        Me.pct_3.Name = "pct_3"
        Me.pct_3.Size = New System.Drawing.Size(151, 23)
        Me.pct_3.TabIndex = 59
        Me.pct_3.TabStop = False
        '
        'pct_2
        '
        Me.pct_2.BackColor = System.Drawing.Color.Silver
        Me.pct_2.Location = New System.Drawing.Point(205, 258)
        Me.pct_2.Name = "pct_2"
        Me.pct_2.Size = New System.Drawing.Size(151, 23)
        Me.pct_2.TabIndex = 58
        Me.pct_2.TabStop = False
        '
        'pct_1
        '
        Me.pct_1.BackColor = System.Drawing.Color.Silver
        Me.pct_1.Location = New System.Drawing.Point(205, 229)
        Me.pct_1.Name = "pct_1"
        Me.pct_1.Size = New System.Drawing.Size(151, 23)
        Me.pct_1.TabIndex = 57
        Me.pct_1.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(310, 446)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(122, 37)
        Me.btn_Cerrar.TabIndex = 56
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'pct_Manos
        '
        Me.pct_Manos.BackColor = System.Drawing.Color.White
        Me.pct_Manos.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Manos.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Dos_Manos
        Me.pct_Manos.Location = New System.Drawing.Point(39, 12)
        Me.pct_Manos.Name = "pct_Manos"
        Me.pct_Manos.Size = New System.Drawing.Size(347, 210)
        Me.pct_Manos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Manos.TabIndex = 53
        Me.pct_Manos.TabStop = False
        '
        'pct_Huella
        '
        Me.pct_Huella.BackColor = System.Drawing.Color.White
        Me.pct_Huella.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pct_Huella.ErrorImage = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Huella.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.LogoNoDisponible
        Me.pct_Huella.InitialImage = Nothing
        Me.pct_Huella.Location = New System.Drawing.Point(56, 228)
        Me.pct_Huella.Name = "pct_Huella"
        Me.pct_Huella.Size = New System.Drawing.Size(117, 128)
        Me.pct_Huella.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pct_Huella.TabIndex = 51
        Me.pct_Huella.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(57, 457)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "&Conectar Lector de Huellas"
        '
        'Frm_Huellas_Prospectos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 495)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_conectarSensor)
        Me.Controls.Add(Me.Huellero)
        Me.Controls.Add(Me.pct_3)
        Me.Controls.Add(Me.pct_2)
        Me.Controls.Add(Me.pct_1)
        Me.Controls.Add(Me.btn_Cerrar)
        Me.Controls.Add(Me.lbl_Status)
        Me.Controls.Add(Me.lbl_H5)
        Me.Controls.Add(Me.lbl_H4)
        Me.Controls.Add(Me.pct_Manos)
        Me.Controls.Add(Me.pct_Huella)
        Me.MaximumSize = New System.Drawing.Size(451, 534)
        Me.Name = "Frm_Huellas_Prospectos"
        Me.Text = "Capturar Huellas"
        CType(Me.Huellero, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Manos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pct_Huella, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_conectarSensor As Button
    Friend WithEvents Huellero As AxZKFPEngXControl.AxZKFPEngX
    Friend WithEvents pct_3 As PictureBox
    Friend WithEvents pct_2 As PictureBox
    Friend WithEvents pct_1 As PictureBox
    Friend WithEvents btn_Cerrar As Button
    Friend WithEvents lbl_Status As Label
    Friend WithEvents lbl_H5 As Label
    Friend WithEvents lbl_H4 As Label
    Friend WithEvents pct_Manos As PictureBox
    Friend WithEvents pct_Huella As PictureBox
    Friend WithEvents Label1 As Label
End Class
