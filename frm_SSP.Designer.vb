<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_SSP
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
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Gbx_lista = New System.Windows.Forms.GroupBox()
        Me.Btn_Cerrar = New System.Windows.Forms.Button()
        Me.btn_Exportar = New System.Windows.Forms.Button()
        Me.Gbx_Botones = New System.Windows.Forms.GroupBox()
        Me.Gbx_Filtro = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.chk_estatal = New System.Windows.Forms.CheckBox()
        Me.chk_federal = New System.Windows.Forms.CheckBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.chk_operativo = New System.Windows.Forms.CheckBox()
        Me.chk_admin = New System.Windows.Forms.CheckBox()
        Me.chk_negativa = New System.Windows.Forms.CheckBox()
        Me.chk_positiva = New System.Windows.Forms.CheckBox()
        Me.Gbx_lista.SuspendLayout()
        Me.Gbx_Botones.SuspendLayout()
        Me.Gbx_Filtro.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_total
        '
        Me.lbl_total.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_total.Location = New System.Drawing.Point(596, 16)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(168, 23)
        Me.lbl_total.TabIndex = 0
        Me.lbl_total.Text = "Registros: 0"
        Me.lbl_total.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Gbx_lista
        '
        Me.Gbx_lista.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_lista.Controls.Add(Me.DataGridView1)
        Me.Gbx_lista.Controls.Add(Me.lbl_total)
        Me.Gbx_lista.Location = New System.Drawing.Point(7, 105)
        Me.Gbx_lista.Name = "Gbx_lista"
        Me.Gbx_lista.Size = New System.Drawing.Size(770, 395)
        Me.Gbx_lista.TabIndex = 4
        Me.Gbx_lista.TabStop = False
        '
        'Btn_Cerrar
        '
        Me.Btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.Btn_Cerrar.Location = New System.Drawing.Point(624, 14)
        Me.Btn_Cerrar.Name = "Btn_Cerrar"
        Me.Btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.Btn_Cerrar.TabIndex = 1
        Me.Btn_Cerrar.Text = "&Cerrar"
        Me.Btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.Btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Exportar
        '
        Me.btn_Exportar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Exportar.Enabled = False
        Me.btn_Exportar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Exportar
        Me.btn_Exportar.Location = New System.Drawing.Point(12, 14)
        Me.btn_Exportar.Name = "btn_Exportar"
        Me.btn_Exportar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Exportar.TabIndex = 0
        Me.btn_Exportar.Text = "&Exportar"
        Me.btn_Exportar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Exportar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Exportar.UseVisualStyleBackColor = True
        '
        'Gbx_Botones
        '
        Me.Gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Botones.Controls.Add(Me.Btn_Cerrar)
        Me.Gbx_Botones.Controls.Add(Me.btn_Exportar)
        Me.Gbx_Botones.Location = New System.Drawing.Point(7, 506)
        Me.Gbx_Botones.Name = "Gbx_Botones"
        Me.Gbx_Botones.Size = New System.Drawing.Size(770, 50)
        Me.Gbx_Botones.TabIndex = 5
        Me.Gbx_Botones.TabStop = False
        '
        'Gbx_Filtro
        '
        Me.Gbx_Filtro.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Filtro.Controls.Add(Me.GroupBox6)
        Me.Gbx_Filtro.Controls.Add(Me.GroupBox5)
        Me.Gbx_Filtro.Controls.Add(Me.GroupBox2)
        Me.Gbx_Filtro.Location = New System.Drawing.Point(7, 5)
        Me.Gbx_Filtro.Name = "Gbx_Filtro"
        Me.Gbx_Filtro.Size = New System.Drawing.Size(770, 94)
        Me.Gbx_Filtro.TabIndex = 3
        Me.Gbx_Filtro.TabStop = False
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chk_negativa)
        Me.GroupBox6.Controls.Add(Me.chk_positiva)
        Me.GroupBox6.Location = New System.Drawing.Point(386, 17)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(165, 44)
        Me.GroupBox6.TabIndex = 197
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Cartilla"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.chk_operativo)
        Me.GroupBox5.Controls.Add(Me.chk_admin)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 18)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(165, 43)
        Me.GroupBox5.TabIndex = 195
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Tipo empleado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.chk_estatal)
        Me.GroupBox2.Controls.Add(Me.chk_federal)
        Me.GroupBox2.Location = New System.Drawing.Point(202, 17)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(165, 44)
        Me.GroupBox2.TabIndex = 196
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Registro"
        '
        'chk_estatal
        '
        Me.chk_estatal.AutoSize = True
        Me.chk_estatal.Location = New System.Drawing.Point(73, 18)
        Me.chk_estatal.Name = "chk_estatal"
        Me.chk_estatal.Size = New System.Drawing.Size(58, 17)
        Me.chk_estatal.TabIndex = 15
        Me.chk_estatal.Text = "Estatal"
        Me.chk_estatal.UseVisualStyleBackColor = True
        '
        'chk_federal
        '
        Me.chk_federal.AutoSize = True
        Me.chk_federal.Location = New System.Drawing.Point(6, 18)
        Me.chk_federal.Name = "chk_federal"
        Me.chk_federal.Size = New System.Drawing.Size(61, 17)
        Me.chk_federal.TabIndex = 13
        Me.chk_federal.Text = "Federal"
        Me.chk_federal.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(6, 41)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(759, 348)
        Me.DataGridView1.TabIndex = 1
        '
        'chk_operativo
        '
        Me.chk_operativo.AutoSize = True
        Me.chk_operativo.Location = New System.Drawing.Point(74, 17)
        Me.chk_operativo.Name = "chk_operativo"
        Me.chk_operativo.Size = New System.Drawing.Size(55, 17)
        Me.chk_operativo.TabIndex = 17
        Me.chk_operativo.Text = "Optvo"
        Me.chk_operativo.UseVisualStyleBackColor = True
        '
        'chk_admin
        '
        Me.chk_admin.AutoSize = True
        Me.chk_admin.Location = New System.Drawing.Point(6, 17)
        Me.chk_admin.Name = "chk_admin"
        Me.chk_admin.Size = New System.Drawing.Size(54, 17)
        Me.chk_admin.TabIndex = 16
        Me.chk_admin.Text = "Adtvo"
        Me.chk_admin.UseVisualStyleBackColor = True
        '
        'chk_negativa
        '
        Me.chk_negativa.AutoSize = True
        Me.chk_negativa.Location = New System.Drawing.Point(75, 18)
        Me.chk_negativa.Name = "chk_negativa"
        Me.chk_negativa.Size = New System.Drawing.Size(69, 17)
        Me.chk_negativa.TabIndex = 17
        Me.chk_negativa.Text = "Negativa"
        Me.chk_negativa.UseVisualStyleBackColor = True
        '
        'chk_positiva
        '
        Me.chk_positiva.AutoSize = True
        Me.chk_positiva.Location = New System.Drawing.Point(6, 18)
        Me.chk_positiva.Name = "chk_positiva"
        Me.chk_positiva.Size = New System.Drawing.Size(63, 17)
        Me.chk_positiva.TabIndex = 16
        Me.chk_positiva.Text = "Positiva"
        Me.chk_positiva.UseVisualStyleBackColor = True
        '
        'frm_SSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Gbx_lista)
        Me.Controls.Add(Me.Gbx_Botones)
        Me.Controls.Add(Me.Gbx_Filtro)
        Me.Name = "frm_SSP"
        Me.Text = "frm_SSP"
        Me.Gbx_lista.ResumeLayout(False)
        Me.Gbx_Botones.ResumeLayout(False)
        Me.Gbx_Filtro.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lbl_total As Label
    Friend WithEvents Gbx_lista As GroupBox
    Friend WithEvents Btn_Cerrar As Button
    Friend WithEvents btn_Exportar As Button
    Friend WithEvents Gbx_Botones As GroupBox
    Friend WithEvents Gbx_Filtro As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents chk_estatal As CheckBox
    Friend WithEvents chk_federal As CheckBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents chk_operativo As CheckBox
    Friend WithEvents chk_admin As CheckBox
    Friend WithEvents chk_negativa As CheckBox
    Friend WithEvents chk_positiva As CheckBox
End Class
