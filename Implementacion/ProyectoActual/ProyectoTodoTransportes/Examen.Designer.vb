﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Examen
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
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.Teorico = New System.Windows.Forms.TabPage()
        Me.Practico = New System.Windows.Forms.TabPage()
        Me.Municipal = New System.Windows.Forms.TabPage()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.Teorico)
        Me.TabControl1.Controls.Add(Me.Practico)
        Me.TabControl1.Controls.Add(Me.Municipal)
        Me.TabControl1.Location = New System.Drawing.Point(32, 29)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(683, 343)
        Me.TabControl1.TabIndex = 0
        '
        'Teorico
        '
        Me.Teorico.Location = New System.Drawing.Point(4, 22)
        Me.Teorico.Name = "Teorico"
        Me.Teorico.Padding = New System.Windows.Forms.Padding(3)
        Me.Teorico.Size = New System.Drawing.Size(675, 317)
        Me.Teorico.TabIndex = 0
        Me.Teorico.Text = "Examen Teorico"
        Me.Teorico.UseVisualStyleBackColor = True
        '
        'Practico
        '
        Me.Practico.Location = New System.Drawing.Point(4, 22)
        Me.Practico.Name = "Practico"
        Me.Practico.Padding = New System.Windows.Forms.Padding(3)
        Me.Practico.Size = New System.Drawing.Size(675, 347)
        Me.Practico.TabIndex = 1
        Me.Practico.Text = "Examen Practico"
        Me.Practico.UseVisualStyleBackColor = True
        '
        'Municipal
        '
        Me.Municipal.Location = New System.Drawing.Point(4, 22)
        Me.Municipal.Name = "Municipal"
        Me.Municipal.Size = New System.Drawing.Size(675, 317)
        Me.Municipal.TabIndex = 2
        Me.Municipal.Text = "Examen Municipal"
        Me.Municipal.UseVisualStyleBackColor = True
        '
        'Examen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(783, 430)
        Me.Controls.Add(Me.TabControl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Examen"
        Me.Text = "Examen"
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents Teorico As System.Windows.Forms.TabPage
    Friend WithEvents Practico As System.Windows.Forms.TabPage
    Friend WithEvents Municipal As System.Windows.Forms.TabPage
End Class
