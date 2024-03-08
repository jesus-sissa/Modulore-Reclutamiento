<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_UnidadesReporteFallas
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
        Me.gbx_DatosReporte = New System.Windows.Forms.GroupBox
        Me.lbl_ObservacionesA = New System.Windows.Forms.Label
        Me.tbx_UsuarioReporta = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_UsuarioReporta = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Parte = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.cmb_Falla = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.tbx_Observaciones = New Modulo_Reclutamiento.cp_Textbox
        Me.btn_Guardar = New System.Windows.Forms.Button
        Me.tbx_Unidad = New Modulo_Reclutamiento.cp_Textbox
        Me.cmb_Unidad = New Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
        Me.dtp_FechaReporte = New System.Windows.Forms.DateTimePicker
        Me.lbl_FallaA = New System.Windows.Forms.Label
        Me.lbl_ParteA = New System.Windows.Forms.Label
        Me.lbl_UsuarioA = New System.Windows.Forms.Label
        Me.lbl_HoraA = New System.Windows.Forms.Label
        Me.lbl_FechaA = New System.Windows.Forms.Label
        Me.lbl_UnidadA = New System.Windows.Forms.Label
        Me.lbl_Unidad = New System.Windows.Forms.Label
        Me.Lbl_Hora = New System.Windows.Forms.Label
        Me.dtp_HoraReporte = New System.Windows.Forms.DateTimePicker
        Me.lbl_FallaReportada = New System.Windows.Forms.Label
        Me.lbl_UsuarioReporta = New System.Windows.Forms.Label
        Me.lbl_FechaReporteFalla = New System.Windows.Forms.Label
        Me.lbl_Parte = New System.Windows.Forms.Label
        Me.lbl_Falla = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.gbx_DatosReporte.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbx_DatosReporte
        '
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_ObservacionesA)
        Me.gbx_DatosReporte.Controls.Add(Me.tbx_UsuarioReporta)
        Me.gbx_DatosReporte.Controls.Add(Me.tbx_Unidad)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_FallaA)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_ParteA)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_UsuarioA)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_HoraA)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_FechaA)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_UnidadA)
        Me.gbx_DatosReporte.Controls.Add(Me.cmb_Unidad)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_Unidad)
        Me.gbx_DatosReporte.Controls.Add(Me.Lbl_Hora)
        Me.gbx_DatosReporte.Controls.Add(Me.dtp_HoraReporte)
        Me.gbx_DatosReporte.Controls.Add(Me.tbx_Observaciones)
        Me.gbx_DatosReporte.Controls.Add(Me.cmb_UsuarioReporta)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_FallaReportada)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_UsuarioReporta)
        Me.gbx_DatosReporte.Controls.Add(Me.dtp_FechaReporte)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_FechaReporteFalla)
        Me.gbx_DatosReporte.Controls.Add(Me.cmb_Parte)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_Parte)
        Me.gbx_DatosReporte.Controls.Add(Me.lbl_Falla)
        Me.gbx_DatosReporte.Controls.Add(Me.cmb_Falla)
        Me.gbx_DatosReporte.Location = New System.Drawing.Point(3, 2)
        Me.gbx_DatosReporte.Name = "gbx_DatosReporte"
        Me.gbx_DatosReporte.Size = New System.Drawing.Size(468, 290)
        Me.gbx_DatosReporte.TabIndex = 0
        Me.gbx_DatosReporte.TabStop = False
        '
        'lbl_ObservacionesA
        '
        Me.lbl_ObservacionesA.AutoSize = True
        Me.lbl_ObservacionesA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ObservacionesA.Location = New System.Drawing.Point(454, 156)
        Me.lbl_ObservacionesA.Name = "lbl_ObservacionesA"
        Me.lbl_ObservacionesA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ObservacionesA.TabIndex = 22
        Me.lbl_ObservacionesA.Text = "*"
        '
        'tbx_UsuarioReporta
        '
        Me.tbx_UsuarioReporta.Control_Siguiente = Me.cmb_UsuarioReporta
        Me.tbx_UsuarioReporta.Filtrado = True
        Me.tbx_UsuarioReporta.Location = New System.Drawing.Point(96, 72)
        Me.tbx_UsuarioReporta.MaxLength = 12
        Me.tbx_UsuarioReporta.Name = "tbx_UsuarioReporta"
        Me.tbx_UsuarioReporta.Size = New System.Drawing.Size(55, 20)
        Me.tbx_UsuarioReporta.TabIndex = 11
        Me.tbx_UsuarioReporta.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_UsuarioReporta
        '
        Me.cmb_UsuarioReporta.Clave = "Clave_Empleado"
        Me.cmb_UsuarioReporta.Control_Siguiente = Me.cmb_Parte
        Me.cmb_UsuarioReporta.DisplayMember = "Nombre"
        Me.cmb_UsuarioReporta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_UsuarioReporta.Empresa = False
        Me.cmb_UsuarioReporta.Filtro = Me.tbx_UsuarioReporta
        Me.cmb_UsuarioReporta.FormattingEnabled = True
        Me.cmb_UsuarioReporta.Location = New System.Drawing.Point(157, 72)
        Me.cmb_UsuarioReporta.MaxDropDownItems = 20
        Me.cmb_UsuarioReporta.Name = "cmb_UsuarioReporta"
        Me.cmb_UsuarioReporta.Pista = False
        Me.cmb_UsuarioReporta.Size = New System.Drawing.Size(291, 21)
        Me.cmb_UsuarioReporta.StoredProcedure = "Cat_Empleados_ComboGetActivos"
        Me.cmb_UsuarioReporta.Sucursal = True
        Me.cmb_UsuarioReporta.TabIndex = 12
        Me.cmb_UsuarioReporta.Tipo = 0
        Me.cmb_UsuarioReporta.ValueMember = "Id_Empleado"
        '
        'cmb_Parte
        '
        Me.cmb_Parte.Clave = Nothing
        Me.cmb_Parte.Control_Siguiente = Me.cmb_Falla
        Me.cmb_Parte.DisplayMember = "Descripcion"
        Me.cmb_Parte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Parte.Empresa = False
        Me.cmb_Parte.Filtro = Nothing
        Me.cmb_Parte.FormattingEnabled = True
        Me.cmb_Parte.Location = New System.Drawing.Point(96, 99)
        Me.cmb_Parte.MaxDropDownItems = 20
        Me.cmb_Parte.Name = "cmb_Parte"
        Me.cmb_Parte.Pista = True
        Me.cmb_Parte.Size = New System.Drawing.Size(291, 21)
        Me.cmb_Parte.StoredProcedure = "Cat_UnidadesPartes_Get"
        Me.cmb_Parte.Sucursal = False
        Me.cmb_Parte.TabIndex = 15
        Me.cmb_Parte.Tipo = 0
        Me.cmb_Parte.ValueMember = "Id_Parte"
        '
        'cmb_Falla
        '
        Me.cmb_Falla.Clave = Nothing
        Me.cmb_Falla.Control_Siguiente = Me.tbx_Observaciones
        Me.cmb_Falla.DisplayMember = "Descripcion"
        Me.cmb_Falla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Falla.Empresa = False
        Me.cmb_Falla.Filtro = Nothing
        Me.cmb_Falla.FormattingEnabled = True
        Me.cmb_Falla.Location = New System.Drawing.Point(96, 126)
        Me.cmb_Falla.MaxDropDownItems = 20
        Me.cmb_Falla.Name = "cmb_Falla"
        Me.cmb_Falla.Pista = True
        Me.cmb_Falla.Size = New System.Drawing.Size(291, 21)
        Me.cmb_Falla.StoredProcedure = "Cat_UnidadesPartesF_Get"
        Me.cmb_Falla.Sucursal = False
        Me.cmb_Falla.TabIndex = 18
        Me.cmb_Falla.Tipo = 0
        Me.cmb_Falla.ValueMember = "Id_ParteF"
        '
        'tbx_Observaciones
        '
        Me.tbx_Observaciones.Control_Siguiente = Me.btn_Guardar
        Me.tbx_Observaciones.Filtrado = True
        Me.tbx_Observaciones.Location = New System.Drawing.Point(96, 153)
        Me.tbx_Observaciones.MaxLength = 200
        Me.tbx_Observaciones.Multiline = True
        Me.tbx_Observaciones.Name = "tbx_Observaciones"
        Me.tbx_Observaciones.Size = New System.Drawing.Size(352, 131)
        Me.tbx_Observaciones.TabIndex = 21
        Me.tbx_Observaciones.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.Ninguno
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Guardar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Guardar
        Me.btn_Guardar.Location = New System.Drawing.Point(6, 13)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Guardar.TabIndex = 0
        Me.btn_Guardar.Text = "&Guardar"
        Me.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'tbx_Unidad
        '
        Me.tbx_Unidad.Control_Siguiente = Me.cmb_Unidad
        Me.tbx_Unidad.Filtrado = True
        Me.tbx_Unidad.Location = New System.Drawing.Point(96, 19)
        Me.tbx_Unidad.MaxLength = 8
        Me.tbx_Unidad.Name = "tbx_Unidad"
        Me.tbx_Unidad.Size = New System.Drawing.Size(55, 20)
        Me.tbx_Unidad.TabIndex = 1
        Me.tbx_Unidad.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'cmb_Unidad
        '
        Me.cmb_Unidad.Clave = "Clave"
        Me.cmb_Unidad.Control_Siguiente = Me.dtp_FechaReporte
        Me.cmb_Unidad.DisplayMember = "Descripcion"
        Me.cmb_Unidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Unidad.Empresa = False
        Me.cmb_Unidad.Filtro = Me.tbx_Unidad
        Me.cmb_Unidad.FormattingEnabled = True
        Me.cmb_Unidad.Location = New System.Drawing.Point(157, 19)
        Me.cmb_Unidad.MaxDropDownItems = 20
        Me.cmb_Unidad.Name = "cmb_Unidad"
        Me.cmb_Unidad.Pista = False
        Me.cmb_Unidad.Size = New System.Drawing.Size(291, 21)
        Me.cmb_Unidad.StoredProcedure = "Cat_Unidades_ComboGet"
        Me.cmb_Unidad.Sucursal = True
        Me.cmb_Unidad.TabIndex = 2
        Me.cmb_Unidad.Tipo = 0
        Me.cmb_Unidad.ValueMember = "Id_Unidad"
        '
        'dtp_FechaReporte
        '
        Me.dtp_FechaReporte.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_FechaReporte.Location = New System.Drawing.Point(96, 46)
        Me.dtp_FechaReporte.Name = "dtp_FechaReporte"
        Me.dtp_FechaReporte.Size = New System.Drawing.Size(95, 20)
        Me.dtp_FechaReporte.TabIndex = 5
        '
        'lbl_FallaA
        '
        Me.lbl_FallaA.AutoSize = True
        Me.lbl_FallaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FallaA.Location = New System.Drawing.Point(393, 129)
        Me.lbl_FallaA.Name = "lbl_FallaA"
        Me.lbl_FallaA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_FallaA.TabIndex = 19
        Me.lbl_FallaA.Text = "*"
        '
        'lbl_ParteA
        '
        Me.lbl_ParteA.AutoSize = True
        Me.lbl_ParteA.ForeColor = System.Drawing.Color.Red
        Me.lbl_ParteA.Location = New System.Drawing.Point(393, 102)
        Me.lbl_ParteA.Name = "lbl_ParteA"
        Me.lbl_ParteA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_ParteA.TabIndex = 16
        Me.lbl_ParteA.Text = "*"
        '
        'lbl_UsuarioA
        '
        Me.lbl_UsuarioA.AutoSize = True
        Me.lbl_UsuarioA.ForeColor = System.Drawing.Color.Red
        Me.lbl_UsuarioA.Location = New System.Drawing.Point(454, 75)
        Me.lbl_UsuarioA.Name = "lbl_UsuarioA"
        Me.lbl_UsuarioA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_UsuarioA.TabIndex = 13
        Me.lbl_UsuarioA.Text = "*"
        '
        'lbl_HoraA
        '
        Me.lbl_HoraA.AutoSize = True
        Me.lbl_HoraA.ForeColor = System.Drawing.Color.Red
        Me.lbl_HoraA.Location = New System.Drawing.Point(330, 50)
        Me.lbl_HoraA.Name = "lbl_HoraA"
        Me.lbl_HoraA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_HoraA.TabIndex = 9
        Me.lbl_HoraA.Text = "*"
        '
        'lbl_FechaA
        '
        Me.lbl_FechaA.AutoSize = True
        Me.lbl_FechaA.ForeColor = System.Drawing.Color.Red
        Me.lbl_FechaA.Location = New System.Drawing.Point(197, 50)
        Me.lbl_FechaA.Name = "lbl_FechaA"
        Me.lbl_FechaA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_FechaA.TabIndex = 6
        Me.lbl_FechaA.Text = "*"
        '
        'lbl_UnidadA
        '
        Me.lbl_UnidadA.AutoSize = True
        Me.lbl_UnidadA.ForeColor = System.Drawing.Color.Red
        Me.lbl_UnidadA.Location = New System.Drawing.Point(454, 22)
        Me.lbl_UnidadA.Name = "lbl_UnidadA"
        Me.lbl_UnidadA.Size = New System.Drawing.Size(11, 13)
        Me.lbl_UnidadA.TabIndex = 3
        Me.lbl_UnidadA.Text = "*"
        '
        'lbl_Unidad
        '
        Me.lbl_Unidad.AutoSize = True
        Me.lbl_Unidad.Location = New System.Drawing.Point(49, 22)
        Me.lbl_Unidad.Name = "lbl_Unidad"
        Me.lbl_Unidad.Size = New System.Drawing.Size(41, 13)
        Me.lbl_Unidad.TabIndex = 0
        Me.lbl_Unidad.Text = "Unidad"
        '
        'Lbl_Hora
        '
        Me.Lbl_Hora.AutoSize = True
        Me.Lbl_Hora.Location = New System.Drawing.Point(226, 51)
        Me.Lbl_Hora.Name = "Lbl_Hora"
        Me.Lbl_Hora.Size = New System.Drawing.Size(30, 13)
        Me.Lbl_Hora.TabIndex = 7
        Me.Lbl_Hora.Text = "Hora"
        '
        'dtp_HoraReporte
        '
        Me.dtp_HoraReporte.CustomFormat = "HH:mm"
        Me.dtp_HoraReporte.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp_HoraReporte.Location = New System.Drawing.Point(262, 46)
        Me.dtp_HoraReporte.Name = "dtp_HoraReporte"
        Me.dtp_HoraReporte.ShowUpDown = True
        Me.dtp_HoraReporte.Size = New System.Drawing.Size(62, 20)
        Me.dtp_HoraReporte.TabIndex = 8
        '
        'lbl_FallaReportada
        '
        Me.lbl_FallaReportada.AutoSize = True
        Me.lbl_FallaReportada.Location = New System.Drawing.Point(12, 156)
        Me.lbl_FallaReportada.Name = "lbl_FallaReportada"
        Me.lbl_FallaReportada.Size = New System.Drawing.Size(78, 13)
        Me.lbl_FallaReportada.TabIndex = 20
        Me.lbl_FallaReportada.Text = "Observaciones"
        '
        'lbl_UsuarioReporta
        '
        Me.lbl_UsuarioReporta.AutoSize = True
        Me.lbl_UsuarioReporta.Location = New System.Drawing.Point(6, 75)
        Me.lbl_UsuarioReporta.Name = "lbl_UsuarioReporta"
        Me.lbl_UsuarioReporta.Size = New System.Drawing.Size(84, 13)
        Me.lbl_UsuarioReporta.TabIndex = 10
        Me.lbl_UsuarioReporta.Text = "Usuario Reporta"
        '
        'lbl_FechaReporteFalla
        '
        Me.lbl_FechaReporteFalla.AutoSize = True
        Me.lbl_FechaReporteFalla.Location = New System.Drawing.Point(53, 50)
        Me.lbl_FechaReporteFalla.Name = "lbl_FechaReporteFalla"
        Me.lbl_FechaReporteFalla.Size = New System.Drawing.Size(37, 13)
        Me.lbl_FechaReporteFalla.TabIndex = 4
        Me.lbl_FechaReporteFalla.Text = "Fecha"
        '
        'lbl_Parte
        '
        Me.lbl_Parte.AutoSize = True
        Me.lbl_Parte.Location = New System.Drawing.Point(58, 102)
        Me.lbl_Parte.Name = "lbl_Parte"
        Me.lbl_Parte.Size = New System.Drawing.Size(32, 13)
        Me.lbl_Parte.TabIndex = 14
        Me.lbl_Parte.Text = "Parte"
        '
        'lbl_Falla
        '
        Me.lbl_Falla.AutoSize = True
        Me.lbl_Falla.Location = New System.Drawing.Point(37, 129)
        Me.lbl_Falla.Name = "lbl_Falla"
        Me.lbl_Falla.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Falla.TabIndex = 17
        Me.lbl_Falla.Text = "Tipo Falla"
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.btn_Guardar)
        Me.gbx_Botones.Controls.Add(Me.btn_Cerrar)
        Me.gbx_Botones.Location = New System.Drawing.Point(5, 294)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(464, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.btn_Cerrar.Location = New System.Drawing.Point(316, 13)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 1
        Me.btn_Cerrar.Text = "&Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'frm_UnidadesReporteFallas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(474, 351)
        Me.Controls.Add(Me.gbx_DatosReporte)
        Me.Controls.Add(Me.gbx_Botones)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(480, 380)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(480, 380)
        Me.Name = "frm_UnidadesReporteFallas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Reportar Falla de Unidad"
        Me.gbx_DatosReporte.ResumeLayout(False)
        Me.gbx_DatosReporte.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbx_DatosReporte As System.Windows.Forms.GroupBox
    Friend WithEvents lbl_FallaReportada As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioReporta As System.Windows.Forms.Label
    Friend WithEvents dtp_FechaReporte As System.Windows.Forms.DateTimePicker
    Friend WithEvents lbl_FechaReporteFalla As System.Windows.Forms.Label
    Friend WithEvents cmb_UsuarioReporta As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents tbx_Observaciones As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents cmb_Falla As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents cmb_Parte As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Falla As System.Windows.Forms.Label
    Friend WithEvents lbl_Parte As System.Windows.Forms.Label
    Friend WithEvents Lbl_Hora As System.Windows.Forms.Label
    Friend WithEvents dtp_HoraReporte As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmb_Unidad As Modulo_Reclutamiento.cp_cmb_SimpleFiltradoParam
    Friend WithEvents lbl_Unidad As System.Windows.Forms.Label
    Friend WithEvents lbl_FallaA As System.Windows.Forms.Label
    Friend WithEvents lbl_ParteA As System.Windows.Forms.Label
    Friend WithEvents lbl_UsuarioA As System.Windows.Forms.Label
    Friend WithEvents lbl_HoraA As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaA As System.Windows.Forms.Label
    Friend WithEvents lbl_UnidadA As System.Windows.Forms.Label
    Friend WithEvents tbx_Unidad As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents tbx_UsuarioReporta As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_ObservacionesA As System.Windows.Forms.Label
End Class
