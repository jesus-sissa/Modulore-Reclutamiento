<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_GafeteImprimirPlant
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
        Me.lbl_Tit_Impresora = New System.Windows.Forms.Label
        Me.lbl_Impresora = New System.Windows.Forms.Label
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_ConfigPrint = New System.Windows.Forms.Button
        Me.btn_ZebraTrasera = New System.Windows.Forms.Button
        Me.btn_ZebraFrente = New System.Windows.Forms.Button
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.Gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_Tit_Impresora
        '
        Me.lbl_Tit_Impresora.AutoSize = True
        Me.lbl_Tit_Impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Tit_Impresora.Location = New System.Drawing.Point(31, 9)
        Me.lbl_Tit_Impresora.Name = "lbl_Tit_Impresora"
        Me.lbl_Tit_Impresora.Size = New System.Drawing.Size(109, 24)
        Me.lbl_Tit_Impresora.TabIndex = 15
        Me.lbl_Tit_Impresora.Text = "Impresora:"
        '
        'lbl_Impresora
        '
        Me.lbl_Impresora.AutoSize = True
        Me.lbl_Impresora.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Impresora.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Impresora.Location = New System.Drawing.Point(135, 9)
        Me.lbl_Impresora.Name = "lbl_Impresora"
        Me.lbl_Impresora.Size = New System.Drawing.Size(85, 24)
        Me.lbl_Impresora.TabIndex = 13
        Me.lbl_Impresora.Text = "Nombre"
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.btn_ConfigPrint)
        Me.Gbx_Botones.Controls.Add(Me.btn_ZebraTrasera)
        Me.Gbx_Botones.Controls.Add(Me.btn_ZebraFrente)
        Me.Gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 73)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(605, 50)
        Me.Gbx_Botones.TabIndex = 12
        Me.Gbx_Botones.TabStop = False
        '
        'btn_ConfigPrint
        '
        Me.btn_ConfigPrint.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ConfigPrint.Location = New System.Drawing.Point(302, 14)
        Me.btn_ConfigPrint.Name = "btn_ConfigPrint"
        Me.btn_ConfigPrint.Size = New System.Drawing.Size(140, 30)
        Me.btn_ConfigPrint.TabIndex = 10
        Me.btn_ConfigPrint.Text = "Configurar Impresora"
        Me.btn_ConfigPrint.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ConfigPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ConfigPrint.UseVisualStyleBackColor = True
        '
        'btn_ZebraTrasera
        '
        Me.btn_ZebraTrasera.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ZebraTrasera.Location = New System.Drawing.Point(151, 14)
        Me.btn_ZebraTrasera.Name = "btn_ZebraTrasera"
        Me.btn_ZebraTrasera.Size = New System.Drawing.Size(145, 30)
        Me.btn_ZebraTrasera.TabIndex = 2
        Me.btn_ZebraTrasera.Text = "Imprimir Zebra Trasera"
        Me.btn_ZebraTrasera.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ZebraTrasera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ZebraTrasera.UseVisualStyleBackColor = True
        '
        'btn_ZebraFrente
        '
        Me.btn_ZebraFrente.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.btn_ZebraFrente.Location = New System.Drawing.Point(6, 14)
        Me.btn_ZebraFrente.Name = "btn_ZebraFrente"
        Me.btn_ZebraFrente.Size = New System.Drawing.Size(140, 30)
        Me.btn_ZebraFrente.TabIndex = 2
        Me.btn_ZebraFrente.Text = "Imprimir Zebra Frente"
        Me.btn_ZebraFrente.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_ZebraFrente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_ZebraFrente.UseVisualStyleBackColor = True
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(459, 14)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_GafeteImprimirPlant
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 132)
        Me.Controls.Add(Me.lbl_Tit_Impresora)
        Me.Controls.Add(Me.lbl_Impresora)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_GafeteImprimirPlant"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imprimir Gafete"
        Me.Gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Tit_Impresora As System.Windows.Forms.Label
    Friend WithEvents lbl_Impresora As System.Windows.Forms.Label
    Friend WithEvents Gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ZebraTrasera As System.Windows.Forms.Button
    Friend WithEvents btn_ZebraFrente As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_ConfigPrint As System.Windows.Forms.Button
End Class
