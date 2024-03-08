<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Investigacion_Personal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Investigacion_Personal))
        Me.Label7 = New System.Windows.Forms.Label()
        Me.tbx_ConocimientoTrabajosCandidato = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbx_RelacionFamiliar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbx_AnosConocerlo = New System.Windows.Forms.TextBox()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.cmb_Recomendacion = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_RefTipoPer = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.cmb_ConfirmaDomicilio = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.lbl_cand = New System.Windows.Forms.Label()
        Me.lbl_candidato = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_Referencia = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(121, 49)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 60
        Me.Label7.Text = "Años"
        '
        'tbx_ConocimientoTrabajosCandidato
        '
        Me.tbx_ConocimientoTrabajosCandidato.Location = New System.Drawing.Point(10, 283)
        Me.tbx_ConocimientoTrabajosCandidato.MaxLength = 300
        Me.tbx_ConocimientoTrabajosCandidato.Multiline = True
        Me.tbx_ConocimientoTrabajosCandidato.Name = "tbx_ConocimientoTrabajosCandidato"
        Me.tbx_ConocimientoTrabajosCandidato.Size = New System.Drawing.Size(510, 72)
        Me.tbx_ConocimientoTrabajosCandidato.TabIndex = 59
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(9, 368)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 20)
        Me.Label6.TabIndex = 57
        Me.Label6.Text = "¿Lo recomienda?"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 260)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(374, 20)
        Me.Label5.TabIndex = 56
        Me.Label5.Text = "¿Conoce en que lugares ha trabajado el candidato?"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 149)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(270, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "¿Como es su relacion con su familia?"
        '
        'tbx_RelacionFamiliar
        '
        Me.tbx_RelacionFamiliar.Location = New System.Drawing.Point(13, 172)
        Me.tbx_RelacionFamiliar.MaxLength = 300
        Me.tbx_RelacionFamiliar.Multiline = True
        Me.tbx_RelacionFamiliar.Name = "tbx_RelacionFamiliar"
        Me.tbx_RelacionFamiliar.Size = New System.Drawing.Size(507, 76)
        Me.tbx_RelacionFamiliar.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(232, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "¿Como considera al candidato?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(217, 20)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "Confirma Domicilio Candidato"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(177, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "¿Tiempo de Conocerlo?"
        '
        'tbx_AnosConocerlo
        '
        Me.tbx_AnosConocerlo.Location = New System.Drawing.Point(46, 45)
        Me.tbx_AnosConocerlo.MaxLength = 5
        Me.tbx_AnosConocerlo.Name = "tbx_AnosConocerlo"
        Me.tbx_AnosConocerlo.Size = New System.Drawing.Size(69, 26)
        Me.tbx_AnosConocerlo.TabIndex = 50
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(418, 573)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_cerrar.TabIndex = 69
        Me.btn_cerrar.Text = "&Cancelar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(22, 573)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Guardar.TabIndex = 68
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.lbl_Telefono)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_Referencia)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 52)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(539, 83)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de Referencia"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tbx_AnosConocerlo)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmb_Recomendacion)
        Me.GroupBox2.Controls.Add(Me.cmb_RefTipoPer)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbx_ConocimientoTrabajosCandidato)
        Me.GroupBox2.Controls.Add(Me.cmb_ConfirmaDomicilio)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tbx_RelacionFamiliar)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(9, 141)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(539, 428)
        Me.GroupBox2.TabIndex = 72
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Investigacion"
        '
        'cmb_Recomendacion
        '
        Me.cmb_Recomendacion.Control_Siguiente = Nothing
        Me.cmb_Recomendacion.DisplayMember = "display"
        Me.cmb_Recomendacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Recomendacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Recomendacion.FormattingEnabled = True
        Me.cmb_Recomendacion.Location = New System.Drawing.Point(13, 391)
        Me.cmb_Recomendacion.MaxDropDownItems = 20
        Me.cmb_Recomendacion.Name = "cmb_Recomendacion"
        Me.cmb_Recomendacion.Size = New System.Drawing.Size(119, 21)
        Me.cmb_Recomendacion.TabIndex = 67
        Me.cmb_Recomendacion.ValueMember = "value"
        '
        'cmb_RefTipoPer
        '
        Me.cmb_RefTipoPer.Control_Siguiente = Nothing
        Me.cmb_RefTipoPer.DisplayMember = "display"
        Me.cmb_RefTipoPer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_RefTipoPer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_RefTipoPer.FormattingEnabled = True
        Me.cmb_RefTipoPer.Location = New System.Drawing.Point(13, 115)
        Me.cmb_RefTipoPer.MaxDropDownItems = 20
        Me.cmb_RefTipoPer.Name = "cmb_RefTipoPer"
        Me.cmb_RefTipoPer.Size = New System.Drawing.Size(228, 21)
        Me.cmb_RefTipoPer.TabIndex = 58
        Me.cmb_RefTipoPer.ValueMember = "value"
        '
        'cmb_ConfirmaDomicilio
        '
        Me.cmb_ConfirmaDomicilio.Control_Siguiente = Nothing
        Me.cmb_ConfirmaDomicilio.DisplayMember = "display"
        Me.cmb_ConfirmaDomicilio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_ConfirmaDomicilio.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_ConfirmaDomicilio.FormattingEnabled = True
        Me.cmb_ConfirmaDomicilio.Location = New System.Drawing.Point(258, 51)
        Me.cmb_ConfirmaDomicilio.MaxDropDownItems = 20
        Me.cmb_ConfirmaDomicilio.Name = "cmb_ConfirmaDomicilio"
        Me.cmb_ConfirmaDomicilio.Size = New System.Drawing.Size(141, 21)
        Me.cmb_ConfirmaDomicilio.TabIndex = 65
        Me.cmb_ConfirmaDomicilio.ValueMember = "value"
        '
        'lbl_cand
        '
        Me.lbl_cand.AutoSize = True
        Me.lbl_cand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cand.Location = New System.Drawing.Point(21, 18)
        Me.lbl_cand.Name = "lbl_cand"
        Me.lbl_cand.Size = New System.Drawing.Size(90, 20)
        Me.lbl_cand.TabIndex = 74
        Me.lbl_cand.Text = "Candidato :"
        '
        'lbl_candidato
        '
        Me.lbl_candidato.AutoSize = True
        Me.lbl_candidato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_candidato.Location = New System.Drawing.Point(115, 18)
        Me.lbl_candidato.Name = "lbl_candidato"
        Me.lbl_candidato.Size = New System.Drawing.Size(24, 20)
        Me.lbl_candidato.TabIndex = 73
        Me.lbl_candidato.Text = "---"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(20, 50)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "Telefono :"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefono.Location = New System.Drawing.Point(118, 50)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(24, 20)
        Me.lbl_Telefono.TabIndex = 74
        Me.lbl_Telefono.Text = "---"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(20, 22)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(95, 20)
        Me.Label16.TabIndex = 73
        Me.Label16.Text = "Referencia :"
        '
        'lbl_Referencia
        '
        Me.lbl_Referencia.AutoSize = True
        Me.lbl_Referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Referencia.Location = New System.Drawing.Point(118, 22)
        Me.lbl_Referencia.Name = "lbl_Referencia"
        Me.lbl_Referencia.Size = New System.Drawing.Size(24, 20)
        Me.lbl_Referencia.TabIndex = 72
        Me.lbl_Referencia.Text = "---"
        '
        'frm_Investigacion_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 615)
        Me.Controls.Add(Me.lbl_cand)
        Me.Controls.Add(Me.lbl_candidato)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.btn_Guardar)
        Me.MaximumSize = New System.Drawing.Size(576, 654)
        Me.Name = "frm_Investigacion_Personal"
        Me.Text = "Investigacion Personal"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_ConfirmaDomicilio As cp_cmb_Manual
    Friend WithEvents Label7 As Label
    Friend WithEvents tbx_ConocimientoTrabajosCandidato As TextBox
    Friend WithEvents cmb_RefTipoPer As cp_cmb_Manual
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbx_RelacionFamiliar As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbx_AnosConocerlo As TextBox
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents cmb_Recomendacion As cp_cmb_Manual
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_Telefono As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_Referencia As Label
    Friend WithEvents lbl_cand As Label
    Friend WithEvents lbl_candidato As Label
End Class
