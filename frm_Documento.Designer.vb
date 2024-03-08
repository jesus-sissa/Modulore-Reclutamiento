<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Documento
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
        Me.WebView = New Microsoft.Web.WebView2.WinForms.WebView2()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.Btn_Imprimir = New System.Windows.Forms.ToolStripButton()
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'WebView
        '
        Me.WebView.AllowExternalDrop = True
        Me.WebView.CreationProperties = Nothing
        Me.WebView.DefaultBackgroundColor = System.Drawing.Color.White
        Me.WebView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebView.Location = New System.Drawing.Point(0, 0)
        Me.WebView.Name = "WebView"
        Me.WebView.Size = New System.Drawing.Size(800, 450)
        Me.WebView.TabIndex = 1
        Me.WebView.ZoomFactor = 1.0R
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Btn_Imprimir})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 407)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 43)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'Btn_Imprimir
        '
        Me.Btn_Imprimir.AutoSize = False
        Me.Btn_Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Btn_Imprimir.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Imprimir
        Me.Btn_Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Btn_Imprimir.Name = "Btn_Imprimir"
        Me.Btn_Imprimir.Size = New System.Drawing.Size(40, 40)
        Me.Btn_Imprimir.Text = "Imprimir"
        '
        'frm_Documento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.WebView)
        Me.Name = "frm_Documento"
        Me.Text = "frm_Documento"
        CType(Me.WebView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents WebView As Microsoft.Web.WebView2.WinForms.WebView2
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents Btn_Imprimir As ToolStripButton
End Class
