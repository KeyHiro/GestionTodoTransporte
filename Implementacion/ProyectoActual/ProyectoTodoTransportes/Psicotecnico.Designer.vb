﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Psicotecnico
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
        Me.guardarPsico = New System.Windows.Forms.Button()
        Me.date_psico = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbox_examinador = New System.Windows.Forms.ComboBox()
        Me.tbox_estado = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'guardarPsico
        '
        Me.guardarPsico.Location = New System.Drawing.Point(335, 251)
        Me.guardarPsico.Name = "guardarPsico"
        Me.guardarPsico.Size = New System.Drawing.Size(101, 28)
        Me.guardarPsico.TabIndex = 21
        Me.guardarPsico.Text = "Guardar"
        Me.guardarPsico.UseVisualStyleBackColor = True
        '
        'date_psico
        '
        Me.date_psico.Location = New System.Drawing.Point(103, 58)
        Me.date_psico.Name = "date_psico"
        Me.date_psico.Size = New System.Drawing.Size(334, 20)
        Me.date_psico.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(27, 187)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(40, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Estado"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Examinador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 64)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Fecha"
        '
        'cbox_examinador
        '
        Me.cbox_examinador.FormattingEnabled = True
        Me.cbox_examinador.Location = New System.Drawing.Point(102, 125)
        Me.cbox_examinador.Name = "cbox_examinador"
        Me.cbox_examinador.Size = New System.Drawing.Size(334, 21)
        Me.cbox_examinador.TabIndex = 22
        '
        'tbox_estado
        '
        Me.tbox_estado.Location = New System.Drawing.Point(103, 187)
        Me.tbox_estado.Name = "tbox_estado"
        Me.tbox_estado.Size = New System.Drawing.Size(333, 20)
        Me.tbox_estado.TabIndex = 23
        '
        'Psicotecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(467, 307)
        Me.Controls.Add(Me.tbox_estado)
        Me.Controls.Add(Me.cbox_examinador)
        Me.Controls.Add(Me.guardarPsico)
        Me.Controls.Add(Me.date_psico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Psicotecnico"
        Me.Text = "Practica Psicotecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents guardarPsico As System.Windows.Forms.Button
    Friend WithEvents date_psico As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbox_examinador As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_estado As System.Windows.Forms.TextBox
End Class