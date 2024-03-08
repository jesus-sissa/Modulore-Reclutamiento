<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_LoginEmpresa
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
        Me.cmb_Sucursal = New System.Windows.Forms.ComboBox
        Me.cmb_Empresa = New System.Windows.Forms.ComboBox
        Me.cmd_Cancel = New System.Windows.Forms.Button
        Me.cmd_OK = New System.Windows.Forms.Button
        Me.Gbx_Login = New System.Windows.Forms.GroupBox
        Me.Lbl_Sucursal = New System.Windows.Forms.Label
        Me.UsernameLabel = New System.Windows.Forms.Label
        Me.gbx_Botones = New System.Windows.Forms.GroupBox
        Me.Gbx_Login.SuspendLayout()
        Me.gbx_Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmb_Sucursal
        '
        Me.cmb_Sucursal.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Sucursal.FormattingEnabled = True
        Me.cmb_Sucursal.Location = New System.Drawing.Point(19, 90)
        Me.cmb_Sucursal.Name = "cmb_Sucursal"
        Me.cmb_Sucursal.Size = New System.Drawing.Size(434, 24)
        Me.cmb_Sucursal.TabIndex = 3
        '
        'cmb_Empresa
        '
        Me.cmb_Empresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmb_Empresa.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_Empresa.FormattingEnabled = True
        Me.cmb_Empresa.Location = New System.Drawing.Point(19, 37)
        Me.cmb_Empresa.Name = "cmb_Empresa"
        Me.cmb_Empresa.Size = New System.Drawing.Size(434, 24)
        Me.cmb_Empresa.TabIndex = 1
        '
        'cmd_Cancel
        '
        Me.cmd_Cancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cmd_Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.cmd_Cancel.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Cerrar
        Me.cmd_Cancel.Location = New System.Drawing.Point(316, 13)
        Me.cmd_Cancel.Name = "cmd_Cancel"
        Me.cmd_Cancel.Size = New System.Drawing.Size(140, 30)
        Me.cmd_Cancel.TabIndex = 1
        Me.cmd_Cancel.Text = "&Cancelar"
        Me.cmd_Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'cmd_OK
        '
        Me.cmd_OK.CausesValidation = False
        Me.cmd_OK.Image = Global.Modulo_Reclutamiento.My.Resources.Resources._1rightarrow1
        Me.cmd_OK.Location = New System.Drawing.Point(19, 13)
        Me.cmd_OK.Name = "cmd_OK"
        Me.cmd_OK.Size = New System.Drawing.Size(140, 30)
        Me.cmd_OK.TabIndex = 0
        Me.cmd_OK.Text = "&Aceptar"
        Me.cmd_OK.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmd_OK.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        '
        'Gbx_Login
        '
        Me.Gbx_Login.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Gbx_Login.Controls.Add(Me.Lbl_Sucursal)
        Me.Gbx_Login.Controls.Add(Me.UsernameLabel)
        Me.Gbx_Login.Controls.Add(Me.cmb_Empresa)
        Me.Gbx_Login.Controls.Add(Me.cmb_Sucursal)
        Me.Gbx_Login.Location = New System.Drawing.Point(8, 12)
        Me.Gbx_Login.Name = "Gbx_Login"
        Me.Gbx_Login.Size = New System.Drawing.Size(471, 127)
        Me.Gbx_Login.TabIndex = 0
        Me.Gbx_Login.TabStop = False
        '
        'Lbl_Sucursal
        '
        Me.Lbl_Sucursal.AutoSize = True
        Me.Lbl_Sucursal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lbl_Sucursal.Location = New System.Drawing.Point(16, 70)
        Me.Lbl_Sucursal.Name = "Lbl_Sucursal"
        Me.Lbl_Sucursal.Size = New System.Drawing.Size(71, 17)
        Me.Lbl_Sucursal.TabIndex = 2
        Me.Lbl_Sucursal.Text = "Sucursal"
        Me.Lbl_Sucursal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UsernameLabel.Location = New System.Drawing.Point(16, 17)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(71, 17)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "Empresa"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'gbx_Botones
        '
        Me.gbx_Botones.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbx_Botones.Controls.Add(Me.cmd_Cancel)
        Me.gbx_Botones.Controls.Add(Me.cmd_OK)
        Me.gbx_Botones.Location = New System.Drawing.Point(8, 85)
        Me.gbx_Botones.Name = "gbx_Botones"
        Me.gbx_Botones.Size = New System.Drawing.Size(471, 50)
        Me.gbx_Botones.TabIndex = 1
        Me.gbx_Botones.TabStop = False
        '
        'frm_LoginEmpresa
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(494, 201)
        Me.ControlBox = False
        Me.Controls.Add(Me.gbx_Botones)
        Me.Controls.Add(Me.Gbx_Login)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximumSize = New System.Drawing.Size(500, 230)
        Me.MinimumSize = New System.Drawing.Size(500, 230)
        Me.Name = "frm_LoginEmpresa"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Seleccione Empresa y Sucursal."
        Me.TopMost = True
        Me.Gbx_Login.ResumeLayout(False)
        Me.Gbx_Login.PerformLayout()
        Me.gbx_Botones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents cmb_Sucursal As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_Empresa As System.Windows.Forms.ComboBox
    Friend WithEvents cmd_Cancel As System.Windows.Forms.Button
    Friend WithEvents cmd_OK As System.Windows.Forms.Button
    Friend WithEvents Gbx_Login As System.Windows.Forms.GroupBox
    Friend WithEvents gbx_Botones As System.Windows.Forms.GroupBox
    Friend WithEvents Lbl_Sucursal As System.Windows.Forms.Label
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
End Class
