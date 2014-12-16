﻿Public Class Bienvenido

    Dim con As Conexion = New Conexion

    Private Sub btn_Login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Login.Click
        If validar() Then
            Dim login As Boolean = con.iniciarSesion(tbox_Usuario.Text, tbox_Contra.Text)
            If login Then
                Dim principal As Principal = New Principal(tbox_Usuario.Text, con)
                principal.Show()
                Me.Close()
            Else
                STATUS.Text = "El Usuario y Contraseña ingresados no son validos."
            End If
        End If
    End Sub

    Private Sub Bienvenido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'MOMENTANEO POR DESARROLLO
        tbox_Usuario.Text = "Desarrollador"
        tbox_Contra.Text = "1234asd"
    End Sub

    Function validar() As Boolean
        If tbox_Usuario.Text.Trim.Equals("") Or tbox_Contra.Text.Trim.Equals("") Then
            STATUS.Text = "Debe ingresar sus datos de inicio de sesión para continuar."
            Return False
        Else
            Return True
        End If
    End Function

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub
End Class