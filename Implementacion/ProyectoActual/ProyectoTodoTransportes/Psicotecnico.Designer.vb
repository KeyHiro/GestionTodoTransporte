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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbox_codigo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.date_examen = New System.Windows.Forms.DateTimePicker()
        Me.cbox_examinador = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_psico = New System.Windows.Forms.Button()
        Me.cbox_estado = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(75, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo:"
        '
        'tbox_codigo
        '
        Me.tbox_codigo.Location = New System.Drawing.Point(180, 44)
        Me.tbox_codigo.Name = "tbox_codigo"
        Me.tbox_codigo.Size = New System.Drawing.Size(332, 20)
        Me.tbox_codigo.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Fecha:"
        '
        'date_examen
        '
        Me.date_examen.Location = New System.Drawing.Point(180, 82)
        Me.date_examen.Name = "date_examen"
        Me.date_examen.Size = New System.Drawing.Size(332, 20)
        Me.date_examen.TabIndex = 5
        '
        'cbox_examinador
        '
        Me.cbox_examinador.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_examinador.FormattingEnabled = True
        Me.cbox_examinador.Location = New System.Drawing.Point(180, 117)
        Me.cbox_examinador.Name = "cbox_examinador"
        Me.cbox_examinador.Size = New System.Drawing.Size(332, 21)
        Me.cbox_examinador.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(75, 120)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Examinador:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(75, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Estado:"
        '
        'btn_psico
        '
        Me.btn_psico.Enabled = False
        Me.btn_psico.Location = New System.Drawing.Point(401, 210)
        Me.btn_psico.Name = "btn_psico"
        Me.btn_psico.Size = New System.Drawing.Size(111, 23)
        Me.btn_psico.TabIndex = 10
        Me.btn_psico.Text = "Guardar"
        Me.btn_psico.UseVisualStyleBackColor = True
        '
        'cbox_estado
        '
        Me.cbox_estado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbox_estado.FormattingEnabled = True
        Me.cbox_estado.Items.AddRange(New Object() {"APROBADO", "REPROBADO", "PENDIENTE"})
        Me.cbox_estado.Location = New System.Drawing.Point(180, 157)
        Me.cbox_estado.Name = "cbox_estado"
        Me.cbox_estado.Size = New System.Drawing.Size(332, 21)
        Me.cbox_estado.TabIndex = 11
        '
        'Psicotecnico
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(762, 394)
        Me.Controls.Add(Me.cbox_estado)
        Me.Controls.Add(Me.btn_psico)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbox_examinador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.date_examen)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbox_codigo)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Psicotecnico"
        Me.Text = "Psicotecnico"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tbox_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents date_examen As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbox_examinador As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_psico As System.Windows.Forms.Button
    Friend WithEvents cbox_estado As System.Windows.Forms.ComboBox
End Class
