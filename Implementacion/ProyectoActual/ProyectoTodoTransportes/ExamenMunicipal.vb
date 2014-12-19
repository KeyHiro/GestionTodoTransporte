﻿Public Class ExamenMunicipal
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim Instructores(,) As String
    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub
    Private Sub ExamenMunicipal_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        loadCBOX("Funcionario")
        loadCBOX("Estudiante")
    End Sub

#Region "Métodos"
    Sub loadCBOX(ByVal Nombre As String)

        Dim n As Integer
        Dim items() As String
        If Nombre.Equals("Funcionario") Then
            cbox_funcionario.Items.Clear()

            n = con.count("Funcionario") - 1
            items = con.toArray(n, "Nombre", "Funcionario")
            For i As Integer = 0 To n
                cbox_funcionario.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_funcionario.SelectedIndex = 0

        ElseIf Nombre.Equals("Estudiante") Then
            cbox_estudiante.Items.Clear()

            n = con.count("Cliente") - 1
            items = con.toArrayWhere(n, "Nombre", "Cliente", "TipoCliente = 'Estudiante'")
            For i As Integer = 0 To n
                cbox_estudiante.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_estudiante.SelectedIndex = 0
        End If
    End Sub

    Function validar() As Boolean

        If tbox_estado.Text.Trim.Equals("") Then
            STATUS.Text = "ERROR: Ingrese los datos."
            Return False
        End If
        Return True
    End Function
#End Region

#Region "VALIDACION DE ENTRADA"
    Private Sub tbox_codMunicipal_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        Herramientas.soloNumeros(e)
    End Sub
#End Region

    Private Sub btn_Municipal_Click(sender As System.Object, e As System.EventArgs) Handles btn_Municipal.Click
        Dim Documento As Integer = 0
        Dim Funcionario As Integer = CInt(con.selectWhereQuery("idFuncionario", "Funcionario", "Nombre = '" & cbox_funcionario.Text & "'"))
        Dim Comentario As String = rtbox_comentario.Text
        If validar() Then
            Dim Fecha As String = Format(date_examen.Value, "yyyy-MM-dd")
            Dim Estado As String = tbox_estado.Text()
            Dim Tipo As String = "Examen Municipal"
            Dim Cliente As Integer = CInt(con.SelectWhere2Query("idCliente", "Cliente", "Nombre = '" & cbox_estudiante.Text & "'", "TipoCliente = 'Estudiante'"))
            Dim Compra As Integer = CInt(con.selectWhereQuery("idCompra", "Compra", "Cliente = '" & Cliente & "'"))
            Dim Matricula As String = con.selectWhereQuery("Codigo", "Matricula", "CodigoCompra = '" & Compra & "'")
            Dim Estudiante As Integer = con.selectWhereQuery("idEstudiante", "Estudiante", "idEstudiante = '" & Matricula & "'")
            Try
                con.regDocumento2(Tipo, Funcionario, Fecha, Estado)
                Documento = CInt(con.last("idDOCUMENTO", "Documento"))
                con.regExMun(Documento, Comentario)
                con.regEstDoc(Estudiante, Documento)
                STATUS.Text = "Examen Municipal de: " & cbox_estudiante.Text() & " fue agregada exitosamente."
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class