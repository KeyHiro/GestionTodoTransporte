﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Curso
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
        Me.cbox_Area = New System.Windows.Forms.ComboBox()
        Me.lbl_Licencia = New System.Windows.Forms.Label()
        Me.cbox_Producto = New System.Windows.Forms.ComboBox()
        Me.lbl_Producto = New System.Windows.Forms.Label()
        Me.lbl_Codigo = New System.Windows.Forms.Label()
        Me.tbox_Codigo = New System.Windows.Forms.TextBox()
        Me.lbl_FechaTermino = New System.Windows.Forms.Label()
        Me.lbl_FechaInicio = New System.Windows.Forms.Label()
        Me.date_FechaInicio = New System.Windows.Forms.DateTimePicker()
        Me.date_FechaTermino = New System.Windows.Forms.DateTimePicker()
        Me.btn_Guardar = New System.Windows.Forms.Button()
        Me.HorarioTeorico = New System.Windows.Forms.DataGridView()
        Me.dg_HorarioTeorico = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dg_Profesor = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.dg_Eliminar = New System.Windows.Forms.DataGridViewButtonColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.HorarioTeorico, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cbox_Area
        '
        Me.cbox_Area.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Area.FormattingEnabled = True
        Me.cbox_Area.Location = New System.Drawing.Point(150, 12)
        Me.cbox_Area.Name = "cbox_Area"
        Me.cbox_Area.Size = New System.Drawing.Size(278, 21)
        Me.cbox_Area.TabIndex = 50
        '
        'lbl_Licencia
        '
        Me.lbl_Licencia.AutoSize = True
        Me.lbl_Licencia.Location = New System.Drawing.Point(21, 15)
        Me.lbl_Licencia.Name = "lbl_Licencia"
        Me.lbl_Licencia.Size = New System.Drawing.Size(89, 13)
        Me.lbl_Licencia.TabIndex = 51
        Me.lbl_Licencia.Text = "Tipo de Licencia:"
        '
        'cbox_Producto
        '
        Me.cbox_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_Producto.FormattingEnabled = True
        Me.cbox_Producto.Location = New System.Drawing.Point(150, 42)
        Me.cbox_Producto.Name = "cbox_Producto"
        Me.cbox_Producto.Size = New System.Drawing.Size(278, 21)
        Me.cbox_Producto.TabIndex = 48
        '
        'lbl_Producto
        '
        Me.lbl_Producto.AutoSize = True
        Me.lbl_Producto.Location = New System.Drawing.Point(21, 45)
        Me.lbl_Producto.Name = "lbl_Producto"
        Me.lbl_Producto.Size = New System.Drawing.Size(53, 13)
        Me.lbl_Producto.TabIndex = 49
        Me.lbl_Producto.Text = "Producto:"
        '
        'lbl_Codigo
        '
        Me.lbl_Codigo.AutoSize = True
        Me.lbl_Codigo.Location = New System.Drawing.Point(21, 74)
        Me.lbl_Codigo.Name = "lbl_Codigo"
        Me.lbl_Codigo.Size = New System.Drawing.Size(43, 13)
        Me.lbl_Codigo.TabIndex = 52
        Me.lbl_Codigo.Text = "Código:"
        '
        'tbox_Codigo
        '
        Me.tbox_Codigo.Location = New System.Drawing.Point(150, 71)
        Me.tbox_Codigo.MaxLength = 10
        Me.tbox_Codigo.Name = "tbox_Codigo"
        Me.tbox_Codigo.Size = New System.Drawing.Size(278, 20)
        Me.tbox_Codigo.TabIndex = 53
        '
        'lbl_FechaTermino
        '
        Me.lbl_FechaTermino.AutoSize = True
        Me.lbl_FechaTermino.Location = New System.Drawing.Point(443, 48)
        Me.lbl_FechaTermino.Name = "lbl_FechaTermino"
        Me.lbl_FechaTermino.Size = New System.Drawing.Size(96, 13)
        Me.lbl_FechaTermino.TabIndex = 54
        Me.lbl_FechaTermino.Text = "Fecha de Termino:"
        '
        'lbl_FechaInicio
        '
        Me.lbl_FechaInicio.AutoSize = True
        Me.lbl_FechaInicio.Location = New System.Drawing.Point(443, 18)
        Me.lbl_FechaInicio.Name = "lbl_FechaInicio"
        Me.lbl_FechaInicio.Size = New System.Drawing.Size(83, 13)
        Me.lbl_FechaInicio.TabIndex = 55
        Me.lbl_FechaInicio.Text = "Fecha de Inicio:"
        '
        'date_FechaInicio
        '
        Me.date_FechaInicio.Location = New System.Drawing.Point(572, 15)
        Me.date_FechaInicio.Name = "date_FechaInicio"
        Me.date_FechaInicio.Size = New System.Drawing.Size(278, 20)
        Me.date_FechaInicio.TabIndex = 56
        '
        'date_FechaTermino
        '
        Me.date_FechaTermino.Location = New System.Drawing.Point(572, 45)
        Me.date_FechaTermino.Name = "date_FechaTermino"
        Me.date_FechaTermino.Size = New System.Drawing.Size(278, 20)
        Me.date_FechaTermino.TabIndex = 57
        '
        'btn_Guardar
        '
        Me.btn_Guardar.Enabled = False
        Me.btn_Guardar.Location = New System.Drawing.Point(480, 74)
        Me.btn_Guardar.Name = "btn_Guardar"
        Me.btn_Guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_Guardar.TabIndex = 58
        Me.btn_Guardar.Text = "Guardar"
        Me.btn_Guardar.UseVisualStyleBackColor = True
        '
        'HorarioTeorico
        '
        Me.HorarioTeorico.AllowUserToAddRows = False
        Me.HorarioTeorico.BackgroundColor = System.Drawing.SystemColors.Control
        Me.HorarioTeorico.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HorarioTeorico.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.HorarioTeorico.ColumnHeadersVisible = False
        Me.HorarioTeorico.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.dg_HorarioTeorico, Me.dg_Profesor, Me.dg_Eliminar})
        Me.HorarioTeorico.GridColor = System.Drawing.SystemColors.ControlLight
        Me.HorarioTeorico.Location = New System.Drawing.Point(47, 164)
        Me.HorarioTeorico.Name = "HorarioTeorico"
        Me.HorarioTeorico.RowHeadersVisible = False
        Me.HorarioTeorico.Size = New System.Drawing.Size(301, 150)
        Me.HorarioTeorico.TabIndex = 59
        '
        'dg_HorarioTeorico
        '
        Me.dg_HorarioTeorico.HeaderText = "Horario"
        Me.dg_HorarioTeorico.Name = "dg_HorarioTeorico"
        '
        'dg_Profesor
        '
        Me.dg_Profesor.HeaderText = "Profesor"
        Me.dg_Profesor.Name = "dg_Profesor"
        '
        'dg_Eliminar
        '
        Me.dg_Eliminar.HeaderText = "Eliminar"
        Me.dg_Eliminar.Name = "dg_Eliminar"
        Me.dg_Eliminar.Text = "X"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(273, 135)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 60
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Curso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(760, 400)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.HorarioTeorico)
        Me.Controls.Add(Me.btn_Guardar)
        Me.Controls.Add(Me.date_FechaTermino)
        Me.Controls.Add(Me.date_FechaInicio)
        Me.Controls.Add(Me.lbl_FechaInicio)
        Me.Controls.Add(Me.lbl_FechaTermino)
        Me.Controls.Add(Me.tbox_Codigo)
        Me.Controls.Add(Me.lbl_Codigo)
        Me.Controls.Add(Me.cbox_Area)
        Me.Controls.Add(Me.lbl_Licencia)
        Me.Controls.Add(Me.cbox_Producto)
        Me.Controls.Add(Me.lbl_Producto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Curso"
        Me.Text = "Curso"
        CType(Me.HorarioTeorico, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbox_Area As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Licencia As System.Windows.Forms.Label
    Friend WithEvents cbox_Producto As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Producto As System.Windows.Forms.Label
    Friend WithEvents lbl_Codigo As System.Windows.Forms.Label
    Friend WithEvents tbox_Codigo As System.Windows.Forms.TextBox
    Friend WithEvents lbl_FechaTermino As System.Windows.Forms.Label
    Friend WithEvents lbl_FechaInicio As System.Windows.Forms.Label
    Friend WithEvents date_FechaInicio As System.Windows.Forms.DateTimePicker
    Friend WithEvents date_FechaTermino As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_Guardar As System.Windows.Forms.Button
    Friend WithEvents HorarioTeorico As System.Windows.Forms.DataGridView
    Friend WithEvents dg_HorarioTeorico As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dg_Profesor As System.Windows.Forms.DataGridViewComboBoxColumn
    Friend WithEvents dg_Eliminar As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
