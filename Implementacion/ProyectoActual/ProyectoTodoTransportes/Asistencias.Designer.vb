﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Asistencias
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_estudiante = New System.Windows.Forms.Label()
        Me.cbox_estudiante = New System.Windows.Forms.ComboBox()
        Me.lbl_Fecha = New System.Windows.Forms.Label()
        Me.date_Fecha = New System.Windows.Forms.DateTimePicker()
        Me.sbox_hor2 = New System.Windows.Forms.NumericUpDown()
        Me.sbox_hor1 = New System.Windows.Forms.NumericUpDown()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.lbl_docente = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_resetear = New System.Windows.Forms.Button()
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Estudiante:"
        '
        'lbl_estudiante
        '
        Me.lbl_estudiante.AutoSize = True
        Me.lbl_estudiante.Location = New System.Drawing.Point(240, 39)
        Me.lbl_estudiante.Name = "lbl_estudiante"
        Me.lbl_estudiante.Size = New System.Drawing.Size(39, 13)
        Me.lbl_estudiante.TabIndex = 43
        Me.lbl_estudiante.Text = "Label8"
        '
        'cbox_estudiante
        '
        Me.cbox_estudiante.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbox_estudiante.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbox_estudiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cbox_estudiante.FormattingEnabled = True
        Me.cbox_estudiante.Location = New System.Drawing.Point(104, 36)
        Me.cbox_estudiante.Name = "cbox_estudiante"
        Me.cbox_estudiante.Size = New System.Drawing.Size(106, 21)
        Me.cbox_estudiante.TabIndex = 42
        '
        'lbl_Fecha
        '
        Me.lbl_Fecha.AutoSize = True
        Me.lbl_Fecha.Location = New System.Drawing.Point(27, 86)
        Me.lbl_Fecha.Name = "lbl_Fecha"
        Me.lbl_Fecha.Size = New System.Drawing.Size(40, 13)
        Me.lbl_Fecha.TabIndex = 63
        Me.lbl_Fecha.Text = "Fecha:"
        '
        'date_Fecha
        '
        Me.date_Fecha.Location = New System.Drawing.Point(104, 79)
        Me.date_Fecha.Name = "date_Fecha"
        Me.date_Fecha.Size = New System.Drawing.Size(210, 20)
        Me.date_Fecha.TabIndex = 62
        '
        'sbox_hor2
        '
        Me.sbox_hor2.Location = New System.Drawing.Point(224, 123)
        Me.sbox_hor2.Maximum = New Decimal(New Integer() {59, 0, 0, 0})
        Me.sbox_hor2.Name = "sbox_hor2"
        Me.sbox_hor2.Size = New System.Drawing.Size(45, 20)
        Me.sbox_hor2.TabIndex = 108
        '
        'sbox_hor1
        '
        Me.sbox_hor1.Location = New System.Drawing.Point(104, 123)
        Me.sbox_hor1.Maximum = New Decimal(New Integer() {23, 0, 0, 0})
        Me.sbox_hor1.Name = "sbox_hor1"
        Me.sbox_hor1.Size = New System.Drawing.Size(44, 20)
        Me.sbox_hor1.TabIndex = 107
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(290, 125)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(24, 13)
        Me.Label8.TabIndex = 106
        Me.Label8.Text = "hrs."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(181, 119)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 24)
        Me.Label9.TabIndex = 105
        Me.Label9.Text = ":"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(27, 130)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(44, 13)
        Me.Label10.TabIndex = 104
        Me.Label10.Text = "Horario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(27, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "Vehiculo:"
        '
        'ComboBox1
        '
        Me.ComboBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(104, 223)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(106, 20)
        Me.ComboBox1.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(240, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(39, 13)
        Me.Label3.TabIndex = 111
        Me.Label3.Text = "Label8"
        '
        'ComboBox2
        '
        Me.ComboBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.ComboBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(104, 176)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(210, 20)
        Me.ComboBox2.TabIndex = 113
        '
        'lbl_docente
        '
        Me.lbl_docente.AutoSize = True
        Me.lbl_docente.Location = New System.Drawing.Point(27, 179)
        Me.lbl_docente.Name = "lbl_docente"
        Me.lbl_docente.Size = New System.Drawing.Size(51, 13)
        Me.lbl_docente.TabIndex = 112
        Me.lbl_docente.Text = "Docente:"
        '
        'btn_guardar
        '
        Me.btn_guardar.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.SAVE
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(200, 277)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(114, 39)
        Me.btn_guardar.TabIndex = 114
        Me.btn_guardar.Text = "Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_resetear
        '
        Me.btn_resetear.Image = Global.ProyectoTodoTransportes.My.Resources.Resources.DELETE_BUTTON
        Me.btn_resetear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_resetear.Location = New System.Drawing.Point(30, 277)
        Me.btn_resetear.Name = "btn_resetear"
        Me.btn_resetear.Size = New System.Drawing.Size(118, 39)
        Me.btn_resetear.TabIndex = 115
        Me.btn_resetear.Text = "Resetear"
        Me.btn_resetear.UseVisualStyleBackColor = True
        '
        'Asistencias
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(391, 342)
        Me.Controls.Add(Me.btn_resetear)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.lbl_docente)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.sbox_hor2)
        Me.Controls.Add(Me.sbox_hor1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.lbl_Fecha)
        Me.Controls.Add(Me.date_Fecha)
        Me.Controls.Add(Me.lbl_estudiante)
        Me.Controls.Add(Me.cbox_estudiante)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Asistencias"
        Me.Text = "Asistencias"
        CType(Me.sbox_hor2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.sbox_hor1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl_estudiante As System.Windows.Forms.Label
    Friend WithEvents cbox_estudiante As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Fecha As System.Windows.Forms.Label
    Friend WithEvents date_Fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents sbox_hor2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents sbox_hor1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_docente As System.Windows.Forms.Label
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents btn_resetear As System.Windows.Forms.Button
End Class
