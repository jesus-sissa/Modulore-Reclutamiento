﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_DescargarArchivo
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm_DescargarArchivo))
        Dim ListViewColumnSorter1 As Modulo_Reclutamiento.ListViewColumnSorter = New Modulo_Reclutamiento.ListViewColumnSorter
        Me.Gbx_Archivo = New System.Windows.Forms.GroupBox
        Me.Lvl_Nota = New System.Windows.Forms.Label
        Me.btn_Cerrar = New System.Windows.Forms.Button
        Me.btn_Descargar = New System.Windows.Forms.Button
        Me.lsv_Archivos = New Modulo_Reclutamiento.cp_Listview
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Gbx_Archivo.SuspendLayout()
        Me.SuspendLayout()
        '
        'Gbx_Archivo
        '
        Me.Gbx_Archivo.Controls.Add(Me.Lvl_Nota)
        Me.Gbx_Archivo.Controls.Add(Me.btn_Cerrar)
        Me.Gbx_Archivo.Controls.Add(Me.btn_Descargar)
        Me.Gbx_Archivo.Controls.Add(Me.lsv_Archivos)
        Me.Gbx_Archivo.Location = New System.Drawing.Point(7, 7)
        Me.Gbx_Archivo.Name = "Gbx_Archivo"
        Me.Gbx_Archivo.Size = New System.Drawing.Size(780, 375)
        Me.Gbx_Archivo.TabIndex = 0
        Me.Gbx_Archivo.TabStop = False
        '
        'Lvl_Nota
        '
        Me.Lvl_Nota.AutoSize = True
        Me.Lvl_Nota.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Lvl_Nota.Location = New System.Drawing.Point(6, 16)
        Me.Lvl_Nota.Name = "Lvl_Nota"
        Me.Lvl_Nota.Size = New System.Drawing.Size(186, 13)
        Me.Lvl_Nota.TabIndex = 0
        Me.Lvl_Nota.Text = "Doble Clic para descargar un Archivo."
        '
        'btn_Cerrar
        '
        Me.btn_Cerrar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_Cerrar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_Cerrar.Image = CType(resources.GetObject("btn_Cerrar.Image"), System.Drawing.Image)
        Me.btn_Cerrar.Location = New System.Drawing.Point(634, 334)
        Me.btn_Cerrar.Name = "btn_Cerrar"
        Me.btn_Cerrar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Cerrar.TabIndex = 3
        Me.btn_Cerrar.Text = "Cerrar"
        Me.btn_Cerrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Cerrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Cerrar.UseVisualStyleBackColor = True
        '
        'btn_Descargar
        '
        Me.btn_Descargar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_Descargar.Enabled = False
        Me.btn_Descargar.Image = Global.Modulo_Reclutamiento.My.Resources.Resources.Actualizar
        Me.btn_Descargar.Location = New System.Drawing.Point(6, 334)
        Me.btn_Descargar.Name = "btn_Descargar"
        Me.btn_Descargar.Size = New System.Drawing.Size(140, 30)
        Me.btn_Descargar.TabIndex = 2
        Me.btn_Descargar.Text = "Descargar Archivo"
        Me.btn_Descargar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btn_Descargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btn_Descargar.UseVisualStyleBackColor = True
        '
        'lsv_Archivos
        '
        Me.lsv_Archivos.AllowColumnReorder = True
        Me.lsv_Archivos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lsv_Archivos.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lsv_Archivos.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lsv_Archivos.FullRowSelect = True
        Me.lsv_Archivos.HideSelection = False
        Me.lsv_Archivos.Location = New System.Drawing.Point(6, 32)
        ListViewColumnSorter1.Order = System.Windows.Forms.SortOrder.None
        ListViewColumnSorter1.SortColumn = 0
        Me.lsv_Archivos.Lvs = ListViewColumnSorter1
        Me.lsv_Archivos.MultiSelect = False
        Me.lsv_Archivos.Name = "lsv_Archivos"
        Me.lsv_Archivos.Row1 = 15
        Me.lsv_Archivos.Row10 = 0
        Me.lsv_Archivos.Row2 = 40
        Me.lsv_Archivos.Row3 = 40
        Me.lsv_Archivos.Row4 = 0
        Me.lsv_Archivos.Row5 = 0
        Me.lsv_Archivos.Row6 = 0
        Me.lsv_Archivos.Row7 = 0
        Me.lsv_Archivos.Row8 = 0
        Me.lsv_Archivos.Row9 = 0
        Me.lsv_Archivos.Size = New System.Drawing.Size(768, 286)
        Me.lsv_Archivos.TabIndex = 1
        Me.lsv_Archivos.UseCompatibleStateImageBehavior = False
        Me.lsv_Archivos.View = System.Windows.Forms.View.Details
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "word2003")
        Me.ImageList1.Images.SetKeyName(1, "word2007")
        Me.ImageList1.Images.SetKeyName(2, "powerpoint2003")
        Me.ImageList1.Images.SetKeyName(3, "PowerPoint2007")
        Me.ImageList1.Images.SetKeyName(4, "pdf")
        '
        'frm_DescargarArchivo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btn_Cerrar
        Me.ClientSize = New System.Drawing.Size(794, 391)
        Me.Controls.Add(Me.Gbx_Archivo)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(800, 420)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(800, 420)
        Me.Name = "frm_DescargarArchivo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Descargar Archivo"
        Me.Gbx_Archivo.ResumeLayout(False)
        Me.Gbx_Archivo.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lsv_Archivos As Modulo_Reclutamiento.cp_Listview
    Friend WithEvents Gbx_Archivo As System.Windows.Forms.GroupBox
    Friend WithEvents btn_Cerrar As System.Windows.Forms.Button
    Friend WithEvents btn_Descargar As System.Windows.Forms.Button
    Friend WithEvents Lvl_Nota As System.Windows.Forms.Label
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
End Class
