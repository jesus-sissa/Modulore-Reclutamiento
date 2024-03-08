<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_BuscarCliente
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
        Dim ListViewColumnSorter2 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.lbl_Buscar = New System.Windows.Forms.Label
        Me.tbx_Buscar = New Modulo_Reclutamiento.cp_Textbox
        Me.lsv_Clientes = New Modulo_Reclutamiento.cp_Listview
        Me.Lbl_Nota = New System.Windows.Forms.Label
        Me.lbl_Modo1 = New System.Windows.Forms.Label
        Me.lbl_Modo = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lbl_Buscar
        '
        Me.lbl_Buscar.AutoSize = True
        Me.lbl_Buscar.Location = New System.Drawing.Point(11, 15)
        Me.lbl_Buscar.Name = "lbl_Buscar"
        Me.lbl_Buscar.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Buscar.TabIndex = 2
        Me.lbl_Buscar.Text = "Buscar:"
        '
        'tbx_Buscar
        '
        Me.tbx_Buscar.Control_Siguiente = Nothing
        Me.tbx_Buscar.Filtrado = False
        Me.tbx_Buscar.Location = New System.Drawing.Point(60, 12)
        Me.tbx_Buscar.Name = "tbx_Buscar"
        Me.tbx_Buscar.Size = New System.Drawing.Size(448, 20)
        Me.tbx_Buscar.TabIndex = 0
        Me.tbx_Buscar.TipoDatos = Modulo_Reclutamiento.FuncionesGlobales.Validar_Cadena.LetrasNumerosYCar
        '
        'lsv_Clientes
        '
        Me.lsv_Clientes.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Clientes.FullRowSelect = True
        Me.lsv_Clientes.HideSelection = False
        Me.lsv_Clientes.Location = New System.Drawing.Point(5, 53)
        ListViewColumnSorter2.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter2.SortColumn = 0
        Me.lsv_Clientes.Lvs = ListViewColumnSorter2
        Me.lsv_Clientes.MultiSelect = False
        Me.lsv_Clientes.Name = "lsv_Clientes"
        Me.lsv_Clientes.Row1 = 70
        Me.lsv_Clientes.Row10 = 0
        Me.lsv_Clientes.Row2 = 20
        Me.lsv_Clientes.Row3 = 0
        Me.lsv_Clientes.Row4 = 0
        Me.lsv_Clientes.Row5 = 0
        Me.lsv_Clientes.Row6 = 0
        Me.lsv_Clientes.Row7 = 0
        Me.lsv_Clientes.Row8 = 0
        Me.lsv_Clientes.Row9 = 0
        Me.lsv_Clientes.Size = New System.Drawing.Size(588, 369)
        Me.lsv_Clientes.TabIndex = 1
        Me.lsv_Clientes.UseCompatibleStateImageBehavior = False
        Me.lsv_Clientes.View = System.Windows.Forms.View.Details
        '
        'Lbl_Nota
        '
        Me.Lbl_Nota.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Lbl_Nota.AutoSize = True
        Me.Lbl_Nota.Location = New System.Drawing.Point(9, 425)
        Me.Lbl_Nota.Name = "Lbl_Nota"
        Me.Lbl_Nota.Size = New System.Drawing.Size(353, 13)
        Me.Lbl_Nota.TabIndex = 3
        Me.Lbl_Nota.Text = "Doble Click para Seleccionar un Cliente y cerrar la ventana de búsqueda."
        '
        'lbl_Modo1
        '
        Me.lbl_Modo1.AutoSize = True
        Me.lbl_Modo1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Modo1.Location = New System.Drawing.Point(8, 33)
        Me.lbl_Modo1.Name = "lbl_Modo1"
        Me.lbl_Modo1.Size = New System.Drawing.Size(355, 15)
        Me.lbl_Modo1.TabIndex = 4
        Me.lbl_Modo1.Text = "Actualmente el modo de Reingreso de Empleados es: "
        '
        'lbl_Modo
        '
        Me.lbl_Modo.AutoSize = True
        Me.lbl_Modo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_Modo.ForeColor = System.Drawing.Color.Red
        Me.lbl_Modo.Location = New System.Drawing.Point(360, 34)
        Me.lbl_Modo.Name = "lbl_Modo"
        Me.lbl_Modo.Size = New System.Drawing.Size(43, 15)
        Me.lbl_Modo.TabIndex = 5
        Me.lbl_Modo.Text = "Modo"
        '
        'Frm_BuscarCliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 441)
        Me.Controls.Add(Me.lbl_Modo1)
        Me.Controls.Add(Me.Lbl_Nota)
        Me.Controls.Add(Me.lbl_Buscar)
        Me.Controls.Add(Me.tbx_Buscar)
        Me.Controls.Add(Me.lsv_Clientes)
        Me.Controls.Add(Me.lbl_Modo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(519, 446)
        Me.Name = "Frm_BuscarCliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Buscar Cliente"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lsv_Clientes As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents tbx_Buscar As Modulo_Reclutamiento.cp_Textbox
    Friend WithEvents lbl_Buscar As System.Windows.Forms.Label
    Friend WithEvents Lbl_Nota As System.Windows.Forms.Label
    Friend WithEvents lbl_Modo1 As System.Windows.Forms.Label
    Friend WithEvents lbl_Modo As System.Windows.Forms.Label
End Class
