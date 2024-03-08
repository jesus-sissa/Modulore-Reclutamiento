<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Investigacion_Laboral
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_Investigacion_Laboral))
        Me.cmb_Desempeño = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.lbl_Referencia = New System.Windows.Forms.Label()
        Me.lbl_cand = New System.Windows.Forms.Label()
        Me.lbl_candidato = New System.Windows.Forms.Label()
        Me.cmb_MotivoSalida = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.tbx_porque = New System.Windows.Forms.TextBox()
        Me.tbx_Acual = New System.Windows.Forms.TextBox()
        Me.cmb_Recomendable = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_DelegadoSindical = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_PertenecioSindicato = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_Demando = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmb_Disponibilidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cmb_Asistencia = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmb_Actitud = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cmb_Honestidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_Puntualidad = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_Conducta = New Modulo_Reclutamiento.cp_cmb_Manual()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cerrar = New System.Windows.Forms.Button()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.lbl_Telefono = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_Desempeño
        '
        Me.cmb_Desempeño.Control_Siguiente = Nothing
        Me.cmb_Desempeño.DisplayMember = "display"
        Me.cmb_Desempeño.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Desempeño.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Desempeño.FormattingEnabled = True
        Me.cmb_Desempeño.Location = New System.Drawing.Point(19, 50)
        Me.cmb_Desempeño.MaxDropDownItems = 20
        Me.cmb_Desempeño.Name = "cmb_Desempeño"
        Me.cmb_Desempeño.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Desempeño.TabIndex = 95
        Me.cmb_Desempeño.ValueMember = "value"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(23, 24)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(73, 20)
        Me.Label16.TabIndex = 94
        Me.Label16.Text = "Nombre :"
        '
        'lbl_Referencia
        '
        Me.lbl_Referencia.AutoSize = True
        Me.lbl_Referencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Referencia.Location = New System.Drawing.Point(121, 24)
        Me.lbl_Referencia.Name = "lbl_Referencia"
        Me.lbl_Referencia.Size = New System.Drawing.Size(24, 20)
        Me.lbl_Referencia.TabIndex = 93
        Me.lbl_Referencia.Text = "---"
        '
        'lbl_cand
        '
        Me.lbl_cand.AutoSize = True
        Me.lbl_cand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_cand.Location = New System.Drawing.Point(18, 19)
        Me.lbl_cand.Name = "lbl_cand"
        Me.lbl_cand.Size = New System.Drawing.Size(90, 20)
        Me.lbl_cand.TabIndex = 90
        Me.lbl_cand.Text = "Candidato :"
        '
        'lbl_candidato
        '
        Me.lbl_candidato.AutoSize = True
        Me.lbl_candidato.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_candidato.Location = New System.Drawing.Point(114, 19)
        Me.lbl_candidato.Name = "lbl_candidato"
        Me.lbl_candidato.Size = New System.Drawing.Size(24, 20)
        Me.lbl_candidato.TabIndex = 89
        Me.lbl_candidato.Text = "---"
        '
        'cmb_MotivoSalida
        '
        Me.cmb_MotivoSalida.Clave = Nothing
        Me.cmb_MotivoSalida.Control_Siguiente = Nothing
        Me.cmb_MotivoSalida.DisplayMember = "Descripcion"
        Me.cmb_MotivoSalida.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_MotivoSalida.Empresa = False
        Me.cmb_MotivoSalida.Filtro = Nothing
        Me.cmb_MotivoSalida.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_MotivoSalida.FormattingEnabled = True
        Me.cmb_MotivoSalida.Location = New System.Drawing.Point(20, 179)
        Me.cmb_MotivoSalida.MaxDropDownItems = 20
        Me.cmb_MotivoSalida.Name = "cmb_MotivoSalida"
        Me.cmb_MotivoSalida.Pista = False
        Me.cmb_MotivoSalida.Size = New System.Drawing.Size(277, 24)
        Me.cmb_MotivoSalida.StoredProcedure = "Cat_MotivosBajaCombo_Get"
        Me.cmb_MotivoSalida.Sucursal = False
        Me.cmb_MotivoSalida.TabIndex = 88
        Me.cmb_MotivoSalida.Tipo = 0
        Me.cmb_MotivoSalida.ValueMember = "Id_MotivoB"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(217, 279)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(82, 20)
        Me.Label14.TabIndex = 87
        Me.Label14.Text = "¿Por que?"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(217, 221)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 20)
        Me.Label13.TabIndex = 86
        Me.Label13.Text = "¿A cual?"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(6, 156)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(125, 20)
        Me.Label12.TabIndex = 85
        Me.Label12.Text = "Motivo de Salida"
        '
        'tbx_porque
        '
        Me.tbx_porque.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_porque.Location = New System.Drawing.Point(212, 297)
        Me.tbx_porque.Name = "tbx_porque"
        Me.tbx_porque.Size = New System.Drawing.Size(280, 22)
        Me.tbx_porque.TabIndex = 84
        '
        'tbx_Acual
        '
        Me.tbx_Acual.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbx_Acual.Location = New System.Drawing.Point(221, 244)
        Me.tbx_Acual.Name = "tbx_Acual"
        Me.tbx_Acual.Size = New System.Drawing.Size(247, 22)
        Me.tbx_Acual.TabIndex = 83
        '
        'cmb_Recomendable
        '
        Me.cmb_Recomendable.Control_Siguiente = Nothing
        Me.cmb_Recomendable.DisplayMember = "display"
        Me.cmb_Recomendable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Recomendable.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Recomendable.FormattingEnabled = True
        Me.cmb_Recomendable.Location = New System.Drawing.Point(19, 302)
        Me.cmb_Recomendable.MaxDropDownItems = 20
        Me.cmb_Recomendable.Name = "cmb_Recomendable"
        Me.cmb_Recomendable.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Recomendable.TabIndex = 82
        Me.cmb_Recomendable.ValueMember = "value"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(0, 279)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(158, 20)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "¿Es Recomendable?"
        '
        'cmb_DelegadoSindical
        '
        Me.cmb_DelegadoSindical.Control_Siguiente = Nothing
        Me.cmb_DelegadoSindical.DisplayMember = "display"
        Me.cmb_DelegadoSindical.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_DelegadoSindical.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_DelegadoSindical.FormattingEnabled = True
        Me.cmb_DelegadoSindical.Location = New System.Drawing.Point(491, 249)
        Me.cmb_DelegadoSindical.MaxDropDownItems = 20
        Me.cmb_DelegadoSindical.Name = "cmb_DelegadoSindical"
        Me.cmb_DelegadoSindical.Size = New System.Drawing.Size(119, 24)
        Me.cmb_DelegadoSindical.TabIndex = 80
        Me.cmb_DelegadoSindical.ValueMember = "value"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(482, 221)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(181, 20)
        Me.Label10.TabIndex = 79
        Me.Label10.Text = "¿Fue delegado sindical?"
        '
        'cmb_PertenecioSindicato
        '
        Me.cmb_PertenecioSindicato.Control_Siguiente = Nothing
        Me.cmb_PertenecioSindicato.DisplayMember = "display"
        Me.cmb_PertenecioSindicato.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_PertenecioSindicato.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_PertenecioSindicato.FormattingEnabled = True
        Me.cmb_PertenecioSindicato.Location = New System.Drawing.Point(19, 244)
        Me.cmb_PertenecioSindicato.MaxDropDownItems = 20
        Me.cmb_PertenecioSindicato.Name = "cmb_PertenecioSindicato"
        Me.cmb_PertenecioSindicato.Size = New System.Drawing.Size(119, 24)
        Me.cmb_PertenecioSindicato.TabIndex = 78
        Me.cmb_PertenecioSindicato.ValueMember = "value"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 221)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(186, 20)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "¿Pertenecio a Sindicato?"
        '
        'cmb_Demando
        '
        Me.cmb_Demando.Control_Siguiente = Nothing
        Me.cmb_Demando.DisplayMember = "display"
        Me.cmb_Demando.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Demando.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Demando.FormattingEnabled = True
        Me.cmb_Demando.Location = New System.Drawing.Point(322, 179)
        Me.cmb_Demando.MaxDropDownItems = 20
        Me.cmb_Demando.Name = "cmb_Demando"
        Me.cmb_Demando.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Demando.TabIndex = 76
        Me.cmb_Demando.ValueMember = "value"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(318, 156)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 20)
        Me.Label8.TabIndex = 75
        Me.Label8.Text = "¿Demando?"
        '
        'cmb_Disponibilidad
        '
        Me.cmb_Disponibilidad.Control_Siguiente = Nothing
        Me.cmb_Disponibilidad.DisplayMember = "display"
        Me.cmb_Disponibilidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Disponibilidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Disponibilidad.FormattingEnabled = True
        Me.cmb_Disponibilidad.Location = New System.Drawing.Point(296, 115)
        Me.cmb_Disponibilidad.MaxDropDownItems = 20
        Me.cmb_Disponibilidad.Name = "cmb_Disponibilidad"
        Me.cmb_Disponibilidad.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Disponibilidad.TabIndex = 74
        Me.cmb_Disponibilidad.ValueMember = "value"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(292, 92)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 20)
        Me.Label7.TabIndex = 73
        Me.Label7.Text = "Disponibilidad"
        '
        'cmb_Asistencia
        '
        Me.cmb_Asistencia.Control_Siguiente = Nothing
        Me.cmb_Asistencia.DisplayMember = "display"
        Me.cmb_Asistencia.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Asistencia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Asistencia.FormattingEnabled = True
        Me.cmb_Asistencia.Location = New System.Drawing.Point(155, 115)
        Me.cmb_Asistencia.MaxDropDownItems = 20
        Me.cmb_Asistencia.Name = "cmb_Asistencia"
        Me.cmb_Asistencia.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Asistencia.TabIndex = 72
        Me.cmb_Asistencia.ValueMember = "value"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(151, 92)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 20)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Asistencia"
        '
        'cmb_Actitud
        '
        Me.cmb_Actitud.Control_Siguiente = Nothing
        Me.cmb_Actitud.DisplayMember = "display"
        Me.cmb_Actitud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Actitud.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Actitud.FormattingEnabled = True
        Me.cmb_Actitud.Location = New System.Drawing.Point(19, 115)
        Me.cmb_Actitud.MaxDropDownItems = 20
        Me.cmb_Actitud.Name = "cmb_Actitud"
        Me.cmb_Actitud.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Actitud.TabIndex = 70
        Me.cmb_Actitud.ValueMember = "value"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 92)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 20)
        Me.Label5.TabIndex = 69
        Me.Label5.Text = "Actitud"
        '
        'cmb_Honestidad
        '
        Me.cmb_Honestidad.Control_Siguiente = Nothing
        Me.cmb_Honestidad.DisplayMember = "display"
        Me.cmb_Honestidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Honestidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Honestidad.FormattingEnabled = True
        Me.cmb_Honestidad.Location = New System.Drawing.Point(433, 50)
        Me.cmb_Honestidad.MaxDropDownItems = 20
        Me.cmb_Honestidad.Name = "cmb_Honestidad"
        Me.cmb_Honestidad.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Honestidad.TabIndex = 68
        Me.cmb_Honestidad.ValueMember = "value"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(429, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 20)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Honestidad"
        '
        'cmb_Puntualidad
        '
        Me.cmb_Puntualidad.Control_Siguiente = Nothing
        Me.cmb_Puntualidad.DisplayMember = "display"
        Me.cmb_Puntualidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Puntualidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Puntualidad.FormattingEnabled = True
        Me.cmb_Puntualidad.Location = New System.Drawing.Point(296, 50)
        Me.cmb_Puntualidad.MaxDropDownItems = 20
        Me.cmb_Puntualidad.Name = "cmb_Puntualidad"
        Me.cmb_Puntualidad.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Puntualidad.TabIndex = 66
        Me.cmb_Puntualidad.ValueMember = "value"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(292, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 20)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Puntualidad"
        '
        'cmb_Conducta
        '
        Me.cmb_Conducta.Control_Siguiente = Nothing
        Me.cmb_Conducta.DisplayMember = "display"
        Me.cmb_Conducta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Conducta.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Conducta.FormattingEnabled = True
        Me.cmb_Conducta.Location = New System.Drawing.Point(155, 50)
        Me.cmb_Conducta.MaxDropDownItems = 20
        Me.cmb_Conducta.Name = "cmb_Conducta"
        Me.cmb_Conducta.Size = New System.Drawing.Size(119, 24)
        Me.cmb_Conducta.TabIndex = 64
        Me.cmb_Conducta.ValueMember = "value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(151, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 63
        Me.Label2.Text = "Conducta"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 20)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Desempeño"
        '
        'btn_cerrar
        '
        Me.btn_cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_cerrar.Location = New System.Drawing.Point(553, 478)
        Me.btn_cerrar.Name = "btn_cerrar"
        Me.btn_cerrar.Size = New System.Drawing.Size(130, 30)
        Me.btn_cerrar.TabIndex = 92
        Me.btn_cerrar.Text = "&Cancelar"
        Me.btn_cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_cerrar.UseVisualStyleBackColor = True
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(11, 478)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(130, 30)
        Me.btn_Guardar.TabIndex = 91
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.lbl_Telefono)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.lbl_Referencia)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 51)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(671, 81)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informacion de Referencia"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(23, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(79, 20)
        Me.Label15.TabIndex = 96
        Me.Label15.Text = "Telefono :"
        '
        'lbl_Telefono
        '
        Me.lbl_Telefono.AutoSize = True
        Me.lbl_Telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Telefono.Location = New System.Drawing.Point(121, 54)
        Me.lbl_Telefono.Name = "lbl_Telefono"
        Me.lbl_Telefono.Size = New System.Drawing.Size(24, 20)
        Me.lbl_Telefono.TabIndex = 95
        Me.lbl_Telefono.Text = "---"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.cmb_Desempeño)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.cmb_Conducta)
        Me.GroupBox2.Controls.Add(Me.tbx_porque)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.cmb_MotivoSalida)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.cmb_Recomendable)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.cmb_Puntualidad)
        Me.GroupBox2.Controls.Add(Me.tbx_Acual)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.cmb_Honestidad)
        Me.GroupBox2.Controls.Add(Me.cmb_DelegadoSindical)
        Me.GroupBox2.Controls.Add(Me.cmb_Actitud)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.cmb_PertenecioSindicato)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.cmb_Asistencia)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.cmb_Disponibilidad)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.cmb_Demando)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(12, 138)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(671, 334)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion de Investigacion"
        '
        'frm_Investigacion_Laboral
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(690, 520)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_cerrar)
        Me.Controls.Add(Me.lbl_candidato)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.lbl_cand)
        Me.MaximumSize = New System.Drawing.Size(706, 559)
        Me.Name = "frm_Investigacion_Laboral"
        Me.Text = "Investigacion Laboral"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_Desempeño As cp_cmb_Manual
    Friend WithEvents Label16 As Label
    Friend WithEvents lbl_Referencia As Label
    Friend WithEvents btn_cerrar As Button
    Friend WithEvents btn_Guardar As Button
    Friend WithEvents lbl_cand As Label
    Friend WithEvents lbl_candidato As Label
    Friend WithEvents cmb_MotivoSalida As cp_cmb_SimpleFiltradoParam
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents tbx_porque As TextBox
    Friend WithEvents tbx_Acual As TextBox
    Friend WithEvents cmb_Recomendable As cp_cmb_Manual
    Friend WithEvents Label11 As Label
    Friend WithEvents cmb_DelegadoSindical As cp_cmb_Manual
    Friend WithEvents Label10 As Label
    Friend WithEvents cmb_PertenecioSindicato As cp_cmb_Manual
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_Demando As cp_cmb_Manual
    Friend WithEvents Label8 As Label
    Friend WithEvents cmb_Disponibilidad As cp_cmb_Manual
    Friend WithEvents Label7 As Label
    Friend WithEvents cmb_Asistencia As cp_cmb_Manual
    Friend WithEvents Label6 As Label
    Friend WithEvents cmb_Actitud As cp_cmb_Manual
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_Honestidad As cp_cmb_Manual
    Friend WithEvents Label4 As Label
    Friend WithEvents cmb_Puntualidad As cp_cmb_Manual
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_Conducta As cp_cmb_Manual
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label15 As Label
    Friend WithEvents lbl_Telefono As Label
    Friend WithEvents GroupBox2 As GroupBox
End Class
