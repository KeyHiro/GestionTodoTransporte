﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ClasePractica
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.date_horarioPract = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cbox_instructor = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbox_cursoPract = New System.Windows.Forms.ComboBox()
        Me.tbox_idPractica = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(298, 190)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 23)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'date_horarioPract
        '
        Me.date_horarioPract.Location = New System.Drawing.Point(143, 124)
        Me.date_horarioPract.Name = "date_horarioPract"
        Me.date_horarioPract.Size = New System.Drawing.Size(256, 20)
        Me.date_horarioPract.TabIndex = 23
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(10, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(44, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Horario:"
        '
        'cbox_instructor
        '
        Me.cbox_instructor.FormattingEnabled = True
        Me.cbox_instructor.Location = New System.Drawing.Point(143, 84)
        Me.cbox_instructor.Name = "cbox_instructor"
        Me.cbox_instructor.Size = New System.Drawing.Size(256, 21)
        Me.cbox_instructor.TabIndex = 21
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 87)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(54, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Instructor:"
        '
        'cbox_cursoPract
        '
        Me.cbox_cursoPract.FormattingEnabled = True
        Me.cbox_cursoPract.Location = New System.Drawing.Point(143, 47)
        Me.cbox_cursoPract.Name = "cbox_cursoPract"
        Me.cbox_cursoPract.Size = New System.Drawing.Size(256, 21)
        Me.cbox_cursoPract.TabIndex = 19
        '
        'tbox_idPractica
        '
        Me.tbox_idPractica.Location = New System.Drawing.Point(143, 12)
        Me.tbox_idPractica.Name = "tbox_idPractica"
        Me.tbox_idPractica.Size = New System.Drawing.Size(256, 20)
        Me.tbox_idPractica.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Curso:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(10, 12)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(68, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Identificador:"
        '
        'ClasePractica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(447, 254)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.date_horarioPract)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cbox_instructor)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbox_cursoPract)
        Me.Controls.Add(Me.tbox_idPractica)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "ClasePractica"
        Me.Text = "ClasePractica"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents date_horarioPract As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cbox_instructor As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cbox_cursoPract As System.Windows.Forms.ComboBox
    Friend WithEvents tbox_idPractica As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
