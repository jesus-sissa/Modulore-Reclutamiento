<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_NotificacionAlertas
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.lbl_Titulo = New System.Windows.Forms.Label
        Me.myTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lbl_Mensaje = New System.Windows.Forms.Label
        Me.lbl_Detalles = New System.Windows.Forms.Label
        Me.lbl_Cerrar = New System.Windows.Forms.Label
        Me.lbl_Atendida = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Titulo
        '
        Me.lbl_Titulo.Dock = System.Windows.Forms.DockStyle.Top
        Me.lbl_Titulo.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Titulo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lbl_Titulo.Location = New System.Drawing.Point(0, 0)
        Me.lbl_Titulo.Margin = New System.Windows.Forms.Padding(5, 0, 5, 0)
        Me.lbl_Titulo.Name = "lbl_Titulo"
        Me.lbl_Titulo.Size = New System.Drawing.Size(353, 24)
        Me.lbl_Titulo.TabIndex = 0
        Me.lbl_Titulo.Text = "lbl_Titulo"
        Me.lbl_Titulo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'myTimer
        '
        Me.myTimer.Enabled = True
        '
        'lbl_Mensaje
        '
        Me.lbl_Mensaje.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbl_Mensaje.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Mensaje.Location = New System.Drawing.Point(0, 28)
        Me.lbl_Mensaje.Name = "lbl_Mensaje"
        Me.lbl_Mensaje.Size = New System.Drawing.Size(353, 110)
        Me.lbl_Mensaje.TabIndex = 1
        Me.lbl_Mensaje.Text = "lbl_Mensaje"
        Me.lbl_Mensaje.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lbl_Detalles
        '
        Me.lbl_Detalles.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Detalles.AutoSize = True
        Me.lbl_Detalles.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Detalles.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Detalles.Location = New System.Drawing.Point(293, 142)
        Me.lbl_Detalles.Name = "lbl_Detalles"
        Me.lbl_Detalles.Size = New System.Drawing.Size(55, 16)
        Me.lbl_Detalles.TabIndex = 9
        Me.lbl_Detalles.Text = "Detalles"
        '
        'lbl_Cerrar
        '
        Me.lbl_Cerrar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.messagebox_critical
        Me.lbl_Cerrar.Location = New System.Drawing.Point(329, 0)
        Me.lbl_Cerrar.Name = "lbl_Cerrar"
        Me.lbl_Cerrar.Size = New System.Drawing.Size(24, 24)
        Me.lbl_Cerrar.TabIndex = 10
        '
        'lbl_Atendida
        '
        Me.lbl_Atendida.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_Atendida.AutoSize = True
        Me.lbl_Atendida.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Atendida.ForeColor = System.Drawing.Color.Blue
        Me.lbl_Atendida.Location = New System.Drawing.Point(1, 142)
        Me.lbl_Atendida.Name = "lbl_Atendida"
        Me.lbl_Atendida.Size = New System.Drawing.Size(59, 16)
        Me.lbl_Atendida.TabIndex = 12
        Me.lbl_Atendida.Text = "Atendida"
        '
        'frm_NotificacionAlertas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(353, 164)
        Me.ControlBox = False
        Me.Controls.Add(Me.lbl_Atendida)
        Me.Controls.Add(Me.lbl_Cerrar)
        Me.Controls.Add(Me.lbl_Detalles)
        Me.Controls.Add(Me.lbl_Titulo)
        Me.Controls.Add(Me.lbl_Mensaje)
        Me.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frm_NotificacionAlertas"
        Me.Opacity = 0
        Me.ShowInTaskbar = False
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_Titulo As System.Windows.Forms.Label
    Friend WithEvents myTimer As System.Windows.Forms.Timer
    Friend WithEvents lbl_Mensaje As System.Windows.Forms.Label
    Friend WithEvents lbl_Detalles As System.Windows.Forms.Label
    Friend WithEvents lbl_Cerrar As System.Windows.Forms.Label
    Friend WithEvents lbl_Atendida As System.Windows.Forms.Label
End Class
