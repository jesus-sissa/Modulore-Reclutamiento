<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_AgregarColonia
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
        Me.lblAviso = New System.Windows.Forms.Label()
        Me.lblCP = New System.Windows.Forms.Label()
        Me.lblColonia = New System.Windows.Forms.Label()
        Me.lblCiudad = New System.Windows.Forms.Label()
        Me.lblEstado = New System.Windows.Forms.Label()
        Me.lblPais = New System.Windows.Forms.Label()
        Me.btnGuardar = New System.Windows.Forms.Button()
        Me.lbl_TituloCP = New System.Windows.Forms.Label()
        Me.lbl_TituloColonia = New System.Windows.Forms.Label()
        Me.lbl_TituloCiudad = New System.Windows.Forms.Label()
        Me.lbl_TituloEstado = New System.Windows.Forms.Label()
        Me.lbl_TituloPais = New System.Windows.Forms.Label()
        Me.lbl_Error = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_ValidarCodigoPostal = New System.Windows.Forms.Button()
        Me.tbx_NombreColonia = New System.Windows.Forms.TextBox()
        Me.lblNombreColonia = New System.Windows.Forms.Label()
        Me.tbx_CodigoPostal = New System.Windows.Forms.TextBox()
        Me.lbl_CodigoPostal = New System.Windows.Forms.Label()
        Me.lbl_Titulo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lblAviso
        '
        Me.lblAviso.AutoSize = True
        Me.lblAviso.ForeColor = System.Drawing.Color.Red
        Me.lblAviso.Location = New System.Drawing.Point(19, 374)
        Me.lblAviso.Name = "lblAviso"
        Me.lblAviso.Size = New System.Drawing.Size(306, 39)
        Me.lblAviso.TabIndex = 41
        Me.lblAviso.Text = "Asegúrese de que la colonia  agregada pertenezca al estado y" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "a la ciudad mostrad" &
    "a en la parte de superior, así como también " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "que el nombre de la colonia este b" &
    "ien escrito."
        '
        'lblCP
        '
        Me.lblCP.AutoSize = True
        Me.lblCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCP.ForeColor = System.Drawing.Color.Green
        Me.lblCP.Location = New System.Drawing.Point(144, 341)
        Me.lblCP.Name = "lblCP"
        Me.lblCP.Size = New System.Drawing.Size(40, 16)
        Me.lblCP.TabIndex = 40
        Me.lblCP.Text = "0000"
        '
        'lblColonia
        '
        Me.lblColonia.AutoSize = True
        Me.lblColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblColonia.ForeColor = System.Drawing.Color.Green
        Me.lblColonia.Location = New System.Drawing.Point(98, 315)
        Me.lblColonia.Name = "lblColonia"
        Me.lblColonia.Size = New System.Drawing.Size(61, 16)
        Me.lblColonia.TabIndex = 39
        Me.lblColonia.Text = "Colonia"
        '
        'lblCiudad
        '
        Me.lblCiudad.AutoSize = True
        Me.lblCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblCiudad.ForeColor = System.Drawing.Color.Green
        Me.lblCiudad.Location = New System.Drawing.Point(95, 290)
        Me.lblCiudad.Name = "lblCiudad"
        Me.lblCiudad.Size = New System.Drawing.Size(57, 16)
        Me.lblCiudad.TabIndex = 38
        Me.lblCiudad.Text = "Ciudad"
        '
        'lblEstado
        '
        Me.lblEstado.AutoSize = True
        Me.lblEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblEstado.ForeColor = System.Drawing.Color.Green
        Me.lblEstado.Location = New System.Drawing.Point(95, 265)
        Me.lblEstado.Name = "lblEstado"
        Me.lblEstado.Size = New System.Drawing.Size(57, 16)
        Me.lblEstado.TabIndex = 37
        Me.lblEstado.Text = "Estado"
        '
        'lblPais
        '
        Me.lblPais.AutoSize = True
        Me.lblPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold)
        Me.lblPais.ForeColor = System.Drawing.Color.Green
        Me.lblPais.Location = New System.Drawing.Point(77, 240)
        Me.lblPais.Name = "lblPais"
        Me.lblPais.Size = New System.Drawing.Size(39, 16)
        Me.lblPais.TabIndex = 36
        Me.lblPais.Text = "Pais"
        '
        'btnGuardar
        '
        Me.btnGuardar.Location = New System.Drawing.Point(126, 447)
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(75, 23)
        Me.btnGuardar.TabIndex = 35
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.UseVisualStyleBackColor = True
        '
        'lbl_TituloCP
        '
        Me.lbl_TituloCP.AutoSize = True
        Me.lbl_TituloCP.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloCP.Location = New System.Drawing.Point(28, 341)
        Me.lbl_TituloCP.Name = "lbl_TituloCP"
        Me.lbl_TituloCP.Size = New System.Drawing.Size(110, 16)
        Me.lbl_TituloCP.TabIndex = 34
        Me.lbl_TituloCP.Text = "Codigo Postal:"
        '
        'lbl_TituloColonia
        '
        Me.lbl_TituloColonia.AutoSize = True
        Me.lbl_TituloColonia.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloColonia.Location = New System.Drawing.Point(28, 315)
        Me.lbl_TituloColonia.Name = "lbl_TituloColonia"
        Me.lbl_TituloColonia.Size = New System.Drawing.Size(65, 16)
        Me.lbl_TituloColonia.TabIndex = 33
        Me.lbl_TituloColonia.Text = "Colonia:"
        '
        'lbl_TituloCiudad
        '
        Me.lbl_TituloCiudad.AutoSize = True
        Me.lbl_TituloCiudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloCiudad.Location = New System.Drawing.Point(28, 290)
        Me.lbl_TituloCiudad.Name = "lbl_TituloCiudad"
        Me.lbl_TituloCiudad.Size = New System.Drawing.Size(61, 16)
        Me.lbl_TituloCiudad.TabIndex = 32
        Me.lbl_TituloCiudad.Text = "Ciudad:"
        '
        'lbl_TituloEstado
        '
        Me.lbl_TituloEstado.AutoSize = True
        Me.lbl_TituloEstado.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloEstado.Location = New System.Drawing.Point(28, 265)
        Me.lbl_TituloEstado.Name = "lbl_TituloEstado"
        Me.lbl_TituloEstado.Size = New System.Drawing.Size(61, 16)
        Me.lbl_TituloEstado.TabIndex = 31
        Me.lbl_TituloEstado.Text = "Estado:"
        '
        'lbl_TituloPais
        '
        Me.lbl_TituloPais.AutoSize = True
        Me.lbl_TituloPais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_TituloPais.Location = New System.Drawing.Point(28, 240)
        Me.lbl_TituloPais.Name = "lbl_TituloPais"
        Me.lbl_TituloPais.Size = New System.Drawing.Size(43, 16)
        Me.lbl_TituloPais.TabIndex = 30
        Me.lbl_TituloPais.Text = "Pais:"
        '
        'lbl_Error
        '
        Me.lbl_Error.AutoSize = True
        Me.lbl_Error.ForeColor = System.Drawing.Color.Red
        Me.lbl_Error.Location = New System.Drawing.Point(67, 163)
        Me.lbl_Error.Name = "lbl_Error"
        Me.lbl_Error.Size = New System.Drawing.Size(29, 13)
        Me.lbl_Error.TabIndex = 29
        Me.lbl_Error.Text = "Error"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label2.ForeColor = System.Drawing.Color.Red
        Me.Label2.Location = New System.Drawing.Point(288, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 17)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.25!)
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(288, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 17)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "*"
        '
        'btn_ValidarCodigoPostal
        '
        Me.btn_ValidarCodigoPostal.Location = New System.Drawing.Point(126, 187)
        Me.btn_ValidarCodigoPostal.Name = "btn_ValidarCodigoPostal"
        Me.btn_ValidarCodigoPostal.Size = New System.Drawing.Size(75, 23)
        Me.btn_ValidarCodigoPostal.TabIndex = 26
        Me.btn_ValidarCodigoPostal.Text = "Validar"
        Me.btn_ValidarCodigoPostal.UseVisualStyleBackColor = True
        '
        'tbx_NombreColonia
        '
        Me.tbx_NombreColonia.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.tbx_NombreColonia.Location = New System.Drawing.Point(58, 137)
        Me.tbx_NombreColonia.MaxLength = 100
        Me.tbx_NombreColonia.Name = "tbx_NombreColonia"
        Me.tbx_NombreColonia.Size = New System.Drawing.Size(223, 23)
        Me.tbx_NombreColonia.TabIndex = 25
        '
        'lblNombreColonia
        '
        Me.lblNombreColonia.AutoSize = True
        Me.lblNombreColonia.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.lblNombreColonia.Location = New System.Drawing.Point(110, 118)
        Me.lblNombreColonia.Name = "lblNombreColonia"
        Me.lblNombreColonia.Size = New System.Drawing.Size(109, 16)
        Me.lblNombreColonia.TabIndex = 24
        Me.lblNombreColonia.Text = "Nombre Colonia"
        '
        'tbx_CodigoPostal
        '
        Me.tbx_CodigoPostal.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.tbx_CodigoPostal.Location = New System.Drawing.Point(58, 81)
        Me.tbx_CodigoPostal.MaxLength = 6
        Me.tbx_CodigoPostal.Name = "tbx_CodigoPostal"
        Me.tbx_CodigoPostal.Size = New System.Drawing.Size(223, 23)
        Me.tbx_CodigoPostal.TabIndex = 23
        '
        'lbl_CodigoPostal
        '
        Me.lbl_CodigoPostal.AutoSize = True
        Me.lbl_CodigoPostal.Font = New System.Drawing.Font("Arial", 10.25!)
        Me.lbl_CodigoPostal.Location = New System.Drawing.Point(123, 62)
        Me.lbl_CodigoPostal.Name = "lbl_CodigoPostal"
        Me.lbl_CodigoPostal.Size = New System.Drawing.Size(96, 16)
        Me.lbl_CodigoPostal.TabIndex = 22
        Me.lbl_CodigoPostal.Text = "Codigo Postal"
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.AutoSize = True
        Me.lbl_Titulo.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.Location = New System.Drawing.Point(103, 18)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(147, 22)
        Me.lbl_Titulo.TabIndex = 21
        Me.lbl_Titulo.Text = "Agregar Colonia"
        '
        'frm_AgregarColonia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(345, 535)
        Me.Controls.Add(Me.lblAviso)
        Me.Controls.Add(Me.lblCP)
        Me.Controls.Add(Me.lblColonia)
        Me.Controls.Add(Me.lblCiudad)
        Me.Controls.Add(Me.lblEstado)
        Me.Controls.Add(Me.lblPais)
        Me.Controls.Add(Me.btnGuardar)
        Me.Controls.Add(Me.lbl_TituloCP)
        Me.Controls.Add(Me.lbl_TituloColonia)
        Me.Controls.Add(Me.lbl_TituloCiudad)
        Me.Controls.Add(Me.lbl_TituloEstado)
        Me.Controls.Add(Me.lbl_TituloPais)
        Me.Controls.Add(Me.lbl_Error)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_ValidarCodigoPostal)
        Me.Controls.Add(Me.tbx_NombreColonia)
        Me.Controls.Add(Me.lblNombreColonia)
        Me.Controls.Add(Me.tbx_CodigoPostal)
        Me.Controls.Add(Me.lbl_CodigoPostal)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "frm_AgregarColonia"
        Me.Text = "frm_AgregarColonia"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAviso As Label
    Friend WithEvents lblCP As Label
    Friend WithEvents lblColonia As Label
    Friend WithEvents lblCiudad As Label
    Friend WithEvents lblEstado As Label
    Friend WithEvents lblPais As Label
    Friend WithEvents btnGuardar As Button
    Friend WithEvents lbl_TituloCP As Label
    Friend WithEvents lbl_TituloColonia As Label
    Friend WithEvents lbl_TituloCiudad As Label
    Friend WithEvents lbl_TituloEstado As Label
    Friend WithEvents lbl_TituloPais As Label
    Friend WithEvents lbl_Error As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btn_ValidarCodigoPostal As Button
    Friend WithEvents tbx_NombreColonia As TextBox
    Friend WithEvents lblNombreColonia As Label
    Public WithEvents tbx_CodigoPostal As TextBox
    Friend WithEvents lbl_CodigoPostal As Label
    Friend WithEvents lbl_Titulo As Label
End Class
