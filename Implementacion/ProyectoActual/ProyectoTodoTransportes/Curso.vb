﻿Public Class Curso
    Dim con As New Conexion
    Dim USER As String = ""
    Dim STATUS As ToolStripStatusLabel
    Dim datacbox As DataCBOX

    Sub New(ByVal usuario As String, ByVal conexion As Conexion, ByVal estado As ToolStripStatusLabel)
        con = conexion
        datacbox = New DataCBOX(con)
        USER = usuario
        STATUS = estado
        InitializeComponent()
    End Sub

    Private Sub Curso_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        loadDataViewGrid()
        loadCBOX("Area")
        loadCBOX("Producto")
    End Sub

    Sub loadCBOX(ByVal Nombre As String)
        Dim items() As String
        Dim n As Integer

        If Nombre.Equals("Area") Then
            cbox_Area.Items.Clear()

            n = con.count("Area") - 1
            items = con.toArray(n, "Nombre", "Area")

            For i As Integer = 0 To n
                cbox_Area.Items.Add(items(i))
            Next
            If con.countWhere("Producto", "Area = 'Otros'") = 0 Then cbox_Area.Items.Remove("Otros")
            If n >= 0 Then cbox_Area.SelectedIndex = 0

        ElseIf Nombre.Equals("Producto") Then

            cbox_Producto.Items.Clear()

            n = con.countWhere("producto", "Area = '" & cbox_Area.Text & "'") - 1
            items = con.toArrayWhere(n, "Nombre", "Producto", "Area = '" & cbox_Area.Text & "'")
            For i As Integer = 0 To n
                cbox_Producto.Items.Add(items(i))
            Next
            If n >= 0 Then cbox_Producto.SelectedIndex = 0
        End If
    End Sub

    Private Sub cbox_Area_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbox_Area.SelectedIndexChanged
        loadCBOX("Producto")
    End Sub

    Private Sub btn_Guardar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Guardar.Click
        If validar() Then
            Dim Codigo As String = tbox_Codigo.Text
            Dim Producto As String = cbox_Producto.Text
            Dim FechaInicio As String = Format(date_FechaInicio.Value, "yyyy-MM-dd")
            Dim FechaTermino As String = Format(date_FechaTermino.Value, "yyyy-MM-dd")

            Try
                con.regCurso(Codigo, Producto, FechaInicio, FechaTermino)
                STATUS.Text = "Curso " & Codigo & " fue agregado exitosamente."
            Catch ex As Exception
                STATUS.Text = "Curso no" & Codigo & " fue agregado exitosamente."
            End Try
        End If
    End Sub

    Function validar() As Boolean
        If tbox_Codigo.Text.Trim.Equals("") Then Return False
        Return True
    End Function

    Sub reset()
        tbox_Codigo.Text = ""
        date_FechaInicio.Value = Date.Now
        date_FechaTermino.Value = Date.Now
    End Sub


    Sub loadDataViewGrid()
        Dim Data As DataTable
        Data = datacbox.Profesores()
        DataGridView1.DataSource = Data

        DG_HTmanana.RowTemplate.Height = 22
    End Sub

    Private Sub DG_HTmanana_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_HTmanana.CellClick

        DG_HTmanana.BeginEdit(True)
        If DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Profesor.Name).Selected = True Or
            DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Hora.Name).Selected Or
            DG_HTmanana.Rows(e.RowIndex).Cells(HTM_Minutos.Name).Selected Then

            DirectCast(DG_HTmanana.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        End If


        If DG_HTmanana.Columns(e.ColumnIndex).Name = "HTM_Eliminar" Then
            DG_HTmanana.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub

    Private Sub DG_HTtarde_click(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DG_HTtarde.CellClick

        DG_HTtarde.BeginEdit(True)
        If DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Profesor.Name).Selected = True Or
            DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Hora.Name).Selected Or
            DG_HTtarde.Rows(e.RowIndex).Cells(HTT_Minutos.Name).Selected Then

            DirectCast(DG_HTtarde.EditingControl, DataGridViewComboBoxEditingControl).DroppedDown = True
        End If


        If DG_HTtarde.Columns(e.ColumnIndex).Name = "HTT_Eliminar" Then
            DG_HTtarde.Rows.RemoveAt(e.RowIndex)
        End If
    End Sub


    Private Sub ADD_manana_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_manana.Click
        DG_HTmanana.Rows.Add()
        
    End Sub

    Private Sub ADD_tarde_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ADD_tarde.Click
        DG_HTtarde.Rows.Add()
    End Sub

End Class